Public Class AudioForm
    Private Sub AudioForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        audioPlayer.uiMode = "full"
        If audioOpenner.ShowDialog = DialogResult.OK Then
            audioPlayer.URL = audioOpenner.FileName
        Else
            Me.Close()
        End If
    End Sub
End Class