Public Class EmoApp
    Private Sub EmoApp_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


    Private Sub ThemeCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles ThemeCheckBox.CheckedChanged
        If DarkTheme Then
            CurrentTheme = MetroFramework.MetroThemeStyle.Light
            DarkTheme = 0
        Else
            CurrentTheme = MetroFramework.MetroThemeStyle.Dark
            DarkTheme = 1
        End If

        Me.Theme = CurrentTheme
        ThemeCheckBox.Theme = CurrentTheme
        PraatButton.Theme = CurrentTheme
        ElanButton.Theme = CurrentTheme
        WebcamButton.Theme = CurrentTheme
        Me.Refresh()

    End Sub

    Private Sub PraatButton_Click(sender As Object, e As EventArgs) Handles PraatButton.Click
        Try
            System.Diagnostics.Process.Start(PraatPath)
        Catch startError As Exception
            '''Console.WriteLine(startError.Message)
            Msg = "No Program Path Specified"
            MsgForm.Show()
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
            '''Console.WriteLine(startError.Message)
            Msg = "No Program Path Specified"
            MsgForm.Show()
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
End Class
