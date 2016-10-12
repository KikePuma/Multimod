'importamos la librerias necesarias
Imports WMPLib

Public Class VideoPlayerForm
    'Default Form Size: 686;574
    Private Sub VideoPlayerForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        player.uiMode = "None"
        player.settings.volume = 0
        player.stretchToFit = True
        If loadVideo.ShowDialog = DialogResult.OK Then
            player.URL = loadVideo.FileName
        End If
        MyTimer.Enabled = True
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

    Private Sub MyTimer_Tick(sender As Object, e As EventArgs) Handles MyTimer.Tick
        'intantamos detener el video mientras este se está ejecutando
        While player.playState = WMPPlayState.wmppsPlaying
            player.Ctlcontrols.pause()
        End While
        If player.playState = WMPPlayState.wmppsPaused Then
            MyTimer.Enabled = False
        End If
    End Sub
End Class