Public Class VideoPlayerForm
    'Default Form Size: 686;574
    Private Sub VideoPlayerForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        player.uiMode = "None"
        player.settings.volume = 0
        player.stretchToFit = True
        If loadVideo.ShowDialog = DialogResult.OK Then
            player.URL = loadVideo.FileName
        End If

    End Sub

    Private Sub playButton_Click(sender As Object, e As EventArgs) Handles playButton.Click
        player.Ctlcontrols.play()
    End Sub

    Private Sub pauseButton_Click(sender As Object, e As EventArgs) Handles pauseButton.Click
        player.Ctlcontrols.pause()
    End Sub

    Private Sub stopButton_Click(sender As Object, e As EventArgs) Handles stopButton.Click
        player.Ctlcontrols.stop()
    End Sub
End Class