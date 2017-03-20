'importamos las librerias necesarias
Imports WMPLib

Public Class DataViewerForm
    'definimos las variables a usar
    Dim currentTime As String = "00:00:00"
    Dim filename As String = NullPath
    Dim csvPath As String = ""
    Dim controlPoints As Integer = 0
    Dim minDuration As Integer = 0
    'creamos una subrutina para escribir el header del CSV
    Private Sub WriteHeader(ByVal csvReader As IO.StreamReader, ByVal fullLine As String, ByVal splitLine As String(), ByVal separator As String)
        'leemos la linea entera
        fullLine = csvReader.ReadLine()
        'la separamos en columnas
        splitLine = Split(fullLine, separator)
        'definimos el numero de columnas que tendrá el DataGridView
        csvView.ColumnCount = splitLine.Length - 1
        'rellenamos las columnas con los datos que tenemos
        csvView.Rows.Add(splitLine)
    End Sub

    Private Sub WriteTags()
        Try
            Dim app As Microsoft.Office.Interop.Excel.Application
            app = New Microsoft.Office.Interop.Excel.Application
            app.Workbooks.Open(csvPath)
        Catch ex As Exception
            EtiquetaButton.Text = csvPath
        End Try

    End Sub


    'creamos una subrutina para escribir los datos del CSV
    Private Sub WriteCSV(ByVal csvReader As IO.StreamReader)
        Dim fullLine As String = ""
        Dim splitLine As String()
        Dim separator As String = ","
        Dim readerMode As String = "line"

        WriteHeader(csvReader, fullLine, splitLine, separator)
        If readerMode = "full" Then
            ' ###### LEER TODO EL CSV ######
            'creamos un bucle mientras haya caracteres
            Do While csvReader.Peek() <> -1
                Try
                    'leemos la linea entera
                    fullLine = csvReader.ReadLine()
                    'la separamos en columnas
                    splitLine = Split(fullLine, separator)
                    'definimos el numero de columnas que tendrá el DataGridView
                    csvView.ColumnCount = splitLine.Length - 1
                    'rellenamos las columnas con los datos que tenemos
                    csvView.Rows.Add(splitLine)
                Catch ex As Exception
                    Console.WriteLine("Full error: " + ex.ToString)
                End Try
            Loop
        ElseIf readerMode = "line" Then
            ' ### LEER UNA LINEA DEL CSV ###
            'definimos las variables necesarias
            Dim csvTime As String()
            'creamos un bucle mientras haya caracteres
            Do While csvReader.Peek() <> -1
                'leemos la linea entera
                fullLine = csvReader.ReadLine()
                'la separamos en columnas
                splitLine = Split(fullLine, separator)
                'leemos el tiempo a mostrar y lo separamos
                csvTime = Split(timeTextBox.Text, ":")
                'buscamos todas aquellas filas en las que coincidan los segundos
                If Not splitLine(0).Length = 2 Then
                    splitLine(0) = "0" + splitLine(0)
                End If
                If splitLine(0) = csvTime(2) Then
                    'definimos el numero de columnas que tendrá el DataGridView
                    csvView.ColumnCount = splitLine.Length - 1
                    'rellenamos las columnas con los datos que tenemos
                    csvView.Rows.Add(splitLine)
                End If
            Loop
        End If
    End Sub
    'creamos una subrutina para cargar el CSV
    Private Sub loadCSV(ByVal url As String)
        'borramos el CSV ya existente
        Try
            csvView.Rows.Clear()
        Catch ex As Exception
        End Try
        Try
            'definimos las variables necesarias
            Dim csv As String = url

            'verificamos que existe el csv
            If IO.File.Exists(csv) = True Then
                'creamos el lector del csv
                Dim csvReader As New IO.StreamReader(csv)
                'escribimos el encabezado y leemos los datos del csv
                WriteCSV(csvReader)
            Else
                MetroFramework.MetroMessageBox.Show(Me, "File does not exist!", "File error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            Console.WriteLine("Import Error: " + ex.Message)
        End Try
    End Sub
    'creamos una subrutina para cargar el archivo de video
    Private Sub PlayFile(ByVal url As String)
        'añadimos un punto a los 2 necesarios para iniciar los controles de video
        controlPoints = controlPoints + 1
        checkControls()
        'fijamos la url del video
        videoPlayer.URL = url
        'quitamos el UI del WMPlayer
        videoPlayer.uiMode = "None"
        'empezamos la visualizacion del video
        videoPlayer.Ctlcontrols.play()
        'ponemos que el inicio sea el momento 00:00
        videoPlayer.Ctlcontrols.currentPosition = 0
        'habilitamos el Timer para mostrar solamente 1 fotograma
        MyTimer.Enabled = True
    End Sub
    'creamos una subrutina para cargar el archivo de la webcam
    Private Sub WebcamFile(ByVal url As String)
        'añadimos un punto a los 2 necesarios para iniciar los controles de video
        controlPoints = controlPoints + 1
        checkControls()
        'fijamos la url del video
        personalPlayer.URL = url
        'quitamos el UI del WMPlayer
        personalPlayer.uiMode = "None"
        'empezamos la visualizacion del video
        personalPlayer.Ctlcontrols.play()
        'ponemos que el inicio sea el momento 00:00
        personalPlayer.Ctlcontrols.currentPosition = 0
        'habilitamos el Timer para mostrar solamente 1 fotograma
        MyTimer.Enabled = True
    End Sub
    'creamos una subrutina para habilitar los controles de video una vez hayamos cargado ambos videos
    Private Sub checkControls()
        If controlPoints = 2 Then
            'habilitamos los controles de video
            durationTrackBar.Enabled = True
            timeTextBox.Enabled = True
            setTimeButton.Enabled = True
        End If
    End Sub
    'cuando haya un error a la hora de cargar el vídeo...
    Private Sub player_MediaError(sender As Object, e As AxWMPLib._WMPOCXEvents_MediaErrorEvent) Handles videoPlayer.MediaError
        'informamos al usuario
        Msg = "Cannot play media file"
        MsgForm.Show()
        Close()
    End Sub
    'cuandro abramos el Form...
    Private Sub DataViewerForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'cargamos el Theme actual y quitamos el UI de los player
        Theme = CurrentTheme
        durationTrackBar.Theme = CurrentTheme
        timeTextBox.Theme = CurrentTheme
        setTimeButton.Theme = CurrentTheme
        loadWebcamButton.Theme = CurrentTheme
        loadVideoButton.Theme = CurrentTheme
        loadCsvButton.Theme = CurrentTheme
        eegViewerLabel.Theme = CurrentTheme
        csvView.BackgroundColor = MetroBackColor
        If DarkTheme Then
            eegViewer.Image = My.Resources.dsensors
        Else
            eegViewer.Image = My.Resources.lsensors
        End If
        videoPlayer.uiMode = "none"
        personalPlayer.uiMode = "none"
        'definimos que solo se pueda seleccionar un archivo por Opener
        openCsvFile.Multiselect = False
        openVideoFile.Multiselect = False
        'refrescamos el Form
        Refresh()
    End Sub
    'en cada tick del Timer...
    Private Sub MyTimer_Tick(sender As Object, e As EventArgs) Handles MyTimer.Tick
        'intantamos detener el VideoPLayer mientras este se está ejecutando
        While videoPlayer.playState = WMPPlayState.wmppsPlaying
            videoPlayer.Ctlcontrols.pause()
        End While
        'intantamos detener el WebcamPlayer mientras este se está ejecutando
        While personalPlayer.playState = WMPPlayState.wmppsPlaying
            personalPlayer.Ctlcontrols.pause()
        End While
        'evitamos errores de frames fantasma al mover de más la barra
        Try
            minDuration = videoPlayer.currentMedia.duration
            If minDuration > personalPlayer.currentMedia.duration Then
                minDuration = personalPlayer.currentMedia.duration
            End If
            durationTrackBar.Maximum = minDuration
        Catch ex As Exception
        End Try
        'si el VideoPlayer ya está parado...
        If videoPlayer.playState = WMPPlayState.wmppsPaused Then
            'mostramos el momento del video en el que estamos con un formato correcto (00:00:00)
            If timeTextBox.Text.Length < 9 Then
                currentTime = "00:" & videoPlayer.Ctlcontrols.currentPositionString
            Else
                currentTime = videoPlayer.Ctlcontrols.currentPositionString
            End If
            timeTextBox.Text = currentTime
            'y paramos el Timer para encender los botones de cargar video
            loadVideoButton.Enabled = True
            loadWebcamButton.Enabled = True
            MyTimer.Enabled = False
            'este If evita problemas estéticos cuando se carga el video
            If timeTextBox.Text = "00:" Then
                timeTextBox.Text = "00:00:00"
            End If
        End If
    End Sub
    'cuando cambie el valor de la TrackBar
    Private Sub durationTrackBar_ValueChanged(sender As Object, e As EventArgs) Handles durationTrackBar.ValueChanged
        'si se está inicializando el TrackBar, omitimos errores
        If durationTrackBar.Value = 0 Then
            Exit Sub
        End If
        'si no, cambiamos el posicion de los vídeos a donde marquemos con la TrackBar
        videoPlayer.Ctlcontrols.currentPosition = durationTrackBar.Value
        personalPlayer.Ctlcontrols.currentPosition = durationTrackBar.Value
        'iniciamos el vídeo desde ahi
        videoPlayer.Ctlcontrols.play()
        personalPlayer.Ctlcontrols.play()
        'cambiamos los valores mostrados en el CSV
        loadCSV(csvPath)
        'congelamos el frame
        MyTimer.Enabled = True
        'refrescamos el Form
        Refresh()
    End Sub
    'creamos una subrutina para comprobar que el parametro obtenido tiene un formato correcto
    Private Function isCorrectFormat(ByVal time As String) As Boolean
        'si el string no existe o esta vacio, salimos de la subrutina
        If time = Nothing Or time = String.Empty Then
            Return False
        End If
        'si la longitud del String es 2, entonces tiene un buen formato
        If time.Length = 2 Then
            Return True
            'sino, mostramos un error con como deberia ser y retornamos el video al principio
        Else
            Try
                Msg = "Default format is HH:MM:SS"
                MsgForm.Show()
            Catch ex As Exception
            End Try
            timeTextBox.Text = "00:00:00"
            Return False
        End If
    End Function
    'creamos una subrutina para pasar de String a Integer (fijo que ya hay algo que lo haga, pero no me apetecia buscarlo)
    Private Function StringToInteger(ByVal time As String) As Integer
        Dim data As Integer = 0
        If IsNumeric(time) Then
            data = Integer.Parse(time)
        Else
            data = 0
        End If
        Return data
    End Function
    'creamos la subrutina para cuando se quiera cambiar el tiempo de manera manual
    Private Sub setTimeButton_Click(sender As Object, e As EventArgs) Handles setTimeButton.Click
        'definimos las variables a usar
        Dim fullTime As String
        Dim partialTime As String()
        Dim finalTime As Integer = 0
        'inicializamos el tiempo cogiendo lo que haya en el TextBox
        fullTime = timeTextBox.Text
        'y lo separamos en 3 strings diferentes para trabajar con horas, minutos y segundos
        partialTime = fullTime.Split(":")
        'si el tiempo no ha sido introducido en un formato correcto, provocamos un error de formato y finalizamos la subrutina
        If Not partialTime.Length = 3 Then
            isCorrectFormat("00:00:100")
            Exit Sub
        End If
        'ahora pasaremos el tiempo a segundos mediante una forma un poco rudimentaria
        For i As Integer = 0 To 2 Step 1
            'pero antes comprobamos que se haya segmentado bien el tiempo introducido
            If isCorrectFormat(partialTime(i)) Then
                If i = 0 Then
                    finalTime = finalTime + (StringToInteger(partialTime(i)) * 3600)
                ElseIf i = 1 Then
                    finalTime = finalTime + (StringToInteger(partialTime(i)) * 60)
                ElseIf i = 2 Then
                    finalTime = finalTime + StringToInteger(partialTime(i))
                End If
            End If
        Next
        'si resulta que el tiempo introducido excede la duracion real del video, ponemos el ultimo frame
        If finalTime > minDuration Then
            videoPlayer.Ctlcontrols.currentPosition = minDuration
            personalPlayer.Ctlcontrols.currentPosition = minDuration
            durationTrackBar.Value = minDuration
            'sino, cambiamos a donde se haya introducido
        Else
            videoPlayer.Ctlcontrols.currentPosition = finalTime
            personalPlayer.Ctlcontrols.currentPosition = finalTime
            durationTrackBar.Value = finalTime
        End If
        'iniciamos el vídeo desde ahi
        videoPlayer.Ctlcontrols.play()
        personalPlayer.Ctlcontrols.play()
        'congelamos el frame
        MyTimer.Enabled = True
        'refrescamos el Form
        Refresh()
    End Sub
    'creamos la rutina para cargar videos en el Video Player
    Private Sub loadVideobutton_Click(sender As Object, e As EventArgs) Handles loadVideoButton.Click
        'cargamos el video
        If openVideoFile.ShowDialog = DialogResult.OK Then
            loadVideoButton.Enabled = False
            loadWebcamButton.Enabled = False
            PlayFile(openVideoFile.FileName)
        End If
    End Sub
    'creamos la rutina para cargar videos en el Webcam Player
    Private Sub loadWebcamButton_Click(sender As Object, e As EventArgs) Handles loadWebcamButton.Click
        'cargamos el video
        If openVideoFile.ShowDialog = DialogResult.OK Then
            loadVideoButton.Enabled = False
            loadWebcamButton.Enabled = False
            WebcamFile(openVideoFile.FileName)
        End If
    End Sub
    'subrutina del timer para evitar bugs
    Private Sub BugTimerTick(sender As Object, e As EventArgs) Handles BugsTimer.Tick
        'evitamos bugs de botones que no se encienden al cargar el segundo video antes que el primero
        If loadVideoButton.Enabled = False Or loadWebcamButton.Enabled = False Then
            loadVideoButton.Enabled = True
            loadWebcamButton.Enabled = True
        End If
        If videoPlayer.playState = WMPPlayState.wmppsPlaying Or personalPlayer.playState = WMPPlayState.wmppsPlaying Then

            'evitamos que no se pare el segundo video al cargarlo despues del primero
            MyTimer.Enabled = True
        End If
    End Sub
    'creamos la subrutina para mostrar el csv
    Private Sub loadCsvButton_Click(sender As Object, e As EventArgs) Handles loadCsvButton.Click
        'abrimos el archivo CSV
        If openCsvFile.ShowDialog() = DialogResult.OK Then
            csvPath = openCsvFile.FileName
            loadCSV(csvPath)
        End If
    End Sub

    Private Sub EtiquetaButton_Click(sender As Object, e As EventArgs) Handles EtiquetaButton.Click
        If EtiquetaButton.Text = "Añadir Etiqueta" Then
            If csvPath = "" Then
                Exit Sub
            End If
            EtiquetaButton.Text = "Aceptar"
            MetroTextBox1.Text = ""
            MetroTextBox1.Visible = True
        ElseIf EtiquetaButton.Text = "Aceptar" Then
            EtiquetaButton.Text = "Añadir Etiqueta"
            MetroTextBox1.Visible = False
            WriteTags()
        End If
    End Sub
End Class