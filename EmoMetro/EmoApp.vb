Public Class EmoApp

    'subrutina para cambiar el tema cuando pulsamos en el CheckBox
    Private Sub ThemeCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles ThemeCheckBox.CheckedChanged
        'bloque If Then Else para alternar entre tema claro y oscuro
        If DarkTheme Then
            CurrentTheme = MetroFramework.MetroThemeStyle.Light
            DarkTheme = 0
        Else
            CurrentTheme = MetroFramework.MetroThemeStyle.Dark
            DarkTheme = 1
        End If
        'actualizamos el tema de todos los elementos del programa y refrescamos el formulario principal
        Me.Theme = CurrentTheme
        ThemeCheckBox.Theme = CurrentTheme
        PraatButton.Theme = CurrentTheme
        ElanButton.Theme = CurrentTheme
        WebcamButton.Theme = CurrentTheme
        EmotivButton.Theme = CurrentTheme
        Me.Refresh()
    End Sub
    'subrutina al presionar el botón PRAAT
    Private Sub PraatButton_Click(sender As Object, e As EventArgs) Handles PraatButton.Click
        'bloque Try Catch para manejar posibles errores de ruta a la hora de abrir el programa
        Try
            System.Diagnostics.Process.Start(PraatPath)
        Catch ex As Exception
            'si nos salta un error, mostramos un formulario con el error correspondiente
            Msg = "No Program Path Specified" '' Msg = ex.Message
            MsgForm.Show()
            OpenFileDialog.ShowDialog()
            MsgForm.Close()
            'si la ruta no es la predefinida por defecto, mostramos un mensaje de éxito
            If OpenFileDialog.FileName <> NullPath Then
                PraatPath = OpenFileDialog.FileName
                Msg = "SUCCESSFULLY CHANGED!"
                MsgForm.Show()
            End If
            'volvemos a declarar la ruta nula para evitar posibles errores futuros
            OpenFileDialog.FileName = NullPath
        End Try
    End Sub
    'subrutina al presionar el botón ELAN
    Private Sub ElanButton_Click(sender As Object, e As EventArgs) Handles ElanButton.Click
        'bloque Try Catch para manejar posibles errores de ruta a la hora de abrir el programa
        Try
            System.Diagnostics.Process.Start(ElanPath)
        Catch ex As Exception
            'si nos salta un error, mostramos un formulario con el error correspondiente
            Msg = ex.Message '' Msg = ex.Message
            MsgForm.Show()
            OpenFileDialog.ShowDialog()
            MsgForm.Close()
            'si la ruta no es la predefinida por defecto, mostramos un mensaje de éxito
            If OpenFileDialog.FileName <> NullPath Then
                ElanPath = OpenFileDialog.FileName
                Msg = "SUCCESSFULLY CHANGED!"
                MsgForm.Show()
            End If
            'volvemos a declarar la ruta nula para evitar posibles errores futuros
            OpenFileDialog.FileName = NullPath
        End Try
    End Sub
    'subrutina al presionar el botón EMOTIV
    Private Sub EmotivButton_Click(sender As Object, e As EventArgs) Handles EmotivButton.Click
        'bloque Try Catch para manejar posibles errores de ruta a la hora de abrir el programa
        Try
            System.Diagnostics.Process.Start(EEGWriterPath)
        Catch ex As Exception
            'si nos salta un error, mostramos un formulario con el error correspondiente
            Msg = ex.Message '' Msg = ex.Message
            MsgForm.Size = Me.Size
            MsgForm.Show()
            '' MsgForm.Close()
        End Try
    End Sub
    'subrutina al presionar el botón WEBCAM
    Private Sub WebcamButton_Click(sender As Object, e As EventArgs) Handles WebcamButton.Click
        'mostramos el formulario con la webcam
        WebcamForm.Show()
    End Sub
End Class
