Public Class EmoApp
    'creamos la subrutina para cambiar el tema con el CheckedBox
    Private Sub ThemeCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles ThemeCheckBox.CheckedChanged
        If DarkTheme Then
            'cambiamos al Light Theme cuando tengamos el Dark
            CurrentTheme = MetroFramework.MetroThemeStyle.Light
            ''MetroTextColor = MetroFramework.MetroColors.Black
            ''MetroBackColor = MetroFramework.MetroColors.White
            DarkTheme = False
            VideoPlayerForm.playButton.Image = My.Resources.lplay
            VideoPlayerForm.pauseButton.Image = My.Resources.lpause
            VideoPlayerForm.stopButton.Image = My.Resources.lstop
        Else
            'y lo mismo para a la inversa
            CurrentTheme = MetroFramework.MetroThemeStyle.Dark
            ''MetroTextColor = MetroFramework.MetroColors.White
            ''MetroBackColor = MetroFramework.MetroColors.Black
            DarkTheme = True
            VideoPlayerForm.playButton.Image = My.Resources.dplay
            VideoPlayerForm.pauseButton.Image = My.Resources.dpause
            VideoPlayerForm.stopButton.Image = My.Resources.dstop

        End If
        'actulizamos el tema de todos los formularios y sus objetos
        Me.Theme = CurrentTheme
        ThemeCheckBox.Theme = CurrentTheme
        SynchroButton.Theme = CurrentTheme
        DataViewerButton.Theme = CurrentTheme
        VideoPlayerButton.Theme = CurrentTheme
        AudioPlayerButton.Theme = CurrentTheme
        WebcamButton.Theme = CurrentTheme
        EmotivButton.Theme = CurrentTheme
        PraatButton.Theme = CurrentTheme
        ElanButton.Theme = CurrentTheme

        WebcamForm.Theme = CurrentTheme
        WebcamForm.recordButton.Theme = CurrentTheme
        WebcamForm.cameraButton.Theme = CurrentTheme

        VideoPlayerForm.Theme = CurrentTheme

        DataViewerForm.Theme = CurrentTheme
        DataViewerForm.durationTrackBar.Theme = CurrentTheme
        DataViewerForm.timeTextBox.Theme = CurrentTheme
        DataViewerForm.setTimeButton.Theme = CurrentTheme
        'y refrescamos todos ellos
        Me.Refresh()
        WebcamForm.Refresh()
        VideoPlayerForm.Refresh()
        DataViewerForm.Refresh()
    End Sub

    Private Sub PraatButton_Click(sender As Object, e As EventArgs) Handles PraatButton.Click
        Try
            System.Diagnostics.Process.Start(PraatPath)
        Catch startError As Exception
            'Console.WriteLine(startError.Message)
            Msg = "No Program Path Specified"
            MsgForm.ShowDialog()
            OpenFileDialog.ShowDialog()
            MsgForm.Close()
            If OpenFileDialog.FileName <> NullPath Then
                PraatPath = OpenFileDialog.FileName
                Msg = "SUCCESSFULLY CHANGED!"
                MsgForm.Show()
            End If
            OpenFileDialog.FileName = NullPath
        End Try
    End Sub

    Private Sub ElanButton_Click(sender As Object, e As EventArgs) Handles ElanButton.Click
        Try
            System.Diagnostics.Process.Start(ElanPath)
        Catch startError As Exception
            'Console.WriteLine(startError.Message)
            Msg = "No Program Path Specified"
            MsgForm.ShowDialog()
            OpenFileDialog.ShowDialog()
            MsgForm.Close()
            If OpenFileDialog.FileName <> NullPath Then
                ElanPath = OpenFileDialog.FileName
                Msg = "SUCCESSFULLY CHANGED!"
                MsgForm.Show()
            End If
            OpenFileDialog.FileName = NullPath
        End Try
    End Sub

    Private Sub WebcamButton_Click(sender As Object, e As EventArgs) Handles WebcamButton.Click
        WebcamForm.Show()
    End Sub

    Private Sub EmotivButton_Click(sender As Object, e As EventArgs) Handles EmotivButton.Click
        Try
            System.Diagnostics.Process.Start(EEGWriterPath)
        Catch ex As Exception

        End Try
    End Sub

    'creamos una subrutina para tener todos los archivos generados en una misma carpeta
    Private Sub getOutputFiles()
        Try
            'buscamos todos los .csv generados con el EEGWriter
            For Each csvFile As String In My.Computer.FileSystem.GetFiles(MyPath, FileIO.SearchOption.SearchTopLevelOnly, "*.csv")
                'y los copiamos a la ruta deseada
                My.Computer.FileSystem.MoveFile(csvFile, defaultOutputPath & My.Computer.FileSystem.GetName(csvFile))
            Next
        Catch ex As Exception
            'si nos sale una IOException, que es la as comun, mostramos el mensaje, pero por si acaso nosotros hemos recogido cualquier excepcion
            If TypeOf ex Is IO.IOException Then
                Console.WriteLine("HAY UNO O VARIOS ARCHIVOS QUE YA EXISTEN EN LA CARPETA DESTINO, POR FAVOR RENOMBRE DICHOS ARCHIVOS")
            End If
        End Try
    End Sub

    Private Sub synchroButton_Click(sender As Object, e As EventArgs) Handles SynchroButton.Click
        'la primera vez que pulsemos el boton de sincronizar
        If SynchroButton.Text = "START SYNCHRO" Then
            'si la camara no está visible
            If WebcamForm.Visible <> True Then
                'mostramos el Form de la cámara
                WebcamForm.Show()
                'si no se ha seleccionado una cámara previamente
                If Not cameraSet Then
                    'obligamos a ello
                    WebcamForm.cameraButton_Click(sender, e)
                End If
            End If
            'una vez hecho esto, cambiamos el texto del boton
            SynchroButton.Text = "START RECORDING"
            'si ya esta todo sincronizado...
        ElseIf SynchroButton.Text = "START RECORDING" Then
            'abrimos todo aquello que recoja datos
            EmotivButton_Click(sender, e)
            WebcamForm.startRecording()
            'cambiamos el texto del boton y el estilo del Form
            SynchroButton.Text = "STOP RECORDING"
            Style = MetroFramework.MetroColorStyle.Red
            Refresh()
            'si estamos grabando...
        ElseIf SynchroButton.Text = "STOP RECORDING" Then
            'paramos todo aquello que este grabando algo
            WebcamForm.startRecording()
            Dim eegWriterProcess As Process
            Dim eegWriterProcesses() As Process
            eegWriterProcesses = Process.GetProcessesByName("eegwriter")
            For Each eegWriterProcess In eegWriterProcesses
                eegWriterProcess.CloseMainWindow()
            Next
            'cambiamos los estilos y el texto
            SynchroButton.Text = "START SYNCHRO"
            Style = MetroFramework.MetroColorStyle.Green
            Refresh()
            'agrupamos los archivos en una misma carpeta
            getOutputFiles()
        End If
    End Sub

    Private Sub videoPlayerButton_Click(sender As Object, e As EventArgs) Handles VideoPlayerButton.Click
        VideoPlayerForm.Show()
    End Sub

    Private Sub dataViewerButton_Click(sender As Object, e As EventArgs) Handles DataViewerButton.Click
        DataViewerForm.Show()
    End Sub
End Class
