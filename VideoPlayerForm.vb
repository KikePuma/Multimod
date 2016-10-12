'importamos la librerias necesarias
Imports WMPLib

Public Class VideoPlayerForm
    'Default Form Size: 686;574
    Private Sub VideoPlayerForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'ajustamos el WMPlayer a nuestro gusto
        player.uiMode = "None"
        player.settings.volume = 0
        player.stretchToFit = True
        'cargamos el video
        If loadVideo.ShowDialog = DialogResult.OK Then
            player.URL = loadVideo.FileName
        End If
        'encendemos el Timer
        MyTimer.Enabled = True
    End Sub
    'creamos la subrutina para el boton de Play
    Public Sub playButton_Click(sender As Object, e As EventArgs) Handles playButton.Click
        player.Ctlcontrols.play()
    End Sub
    'creamos la subrutina para el boton de Pause
    Public Sub pauseButton_Click(sender As Object, e As EventArgs) Handles pauseButton.Click
        player.Ctlcontrols.pause()
    End Sub
    'creamos la subrutina para el boton de Stop
    Private Sub stopButton_Click(sender As Object, e As EventArgs) Handles stopButton.Click
        player.Ctlcontrols.stop()
    End Sub
    'creamos la subrutina del Timer
    Private Sub MyTimer_Tick(sender As Object, e As EventArgs) Handles MyTimer.Tick
        'intantamos detener el video mientras este se está ejecutando
        While player.playState = WMPPlayState.wmppsPlaying
            player.Ctlcontrols.pause()
        End While
        'si el video esta parado...
        If player.playState = WMPPlayState.wmppsPaused Then
            'devolvemos el video al segundo 0"
            player.Ctlcontrols.currentPosition = 0
            player.Ctlcontrols.play()
            player.Ctlcontrols.pause()
            'apagamos el Timer
            MyTimer.Enabled = False
        End If
    End Sub
End Class