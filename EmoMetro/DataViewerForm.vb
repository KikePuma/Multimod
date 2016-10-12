'importamos las librerias necesarias
Imports WMPLib

Public Class DataViewerForm
    'definimos las variables a usar
    Dim currentTime As String = "00:00:00"
    Dim filename As String = NullPath
    'creamos una subrutina para cargar el archivo de video
    Private Sub PlayFile(ByVal url As String)
        'habilitamos los controles de video
        durationTrackBar.Enabled = True
        timeTextBox.Enabled = True
        setTimeButton.Enabled = True
        'fijamos la url del video
        player.URL = url
        'quitamos el UI del WMPlayer
        player.uiMode = "None"
        'empezamos la visualizacion del video
        player.Ctlcontrols.play()
        'ponemos que el inicio sea el momento 00:00
        player.Ctlcontrols.currentPosition = 0
        'habilitamos el Timer para mostrar solamente 1 fotograma
        MyTimer.Enabled = True
    End Sub
    'cuando haya un error a la hora de cargar el vídeo...
    Private Sub player_MediaError(sender As Object, e As AxWMPLib._WMPOCXEvents_MediaErrorEvent) Handles player.MediaError
        'informamos al usuario
        Msg = "Cannot play media file"
        MsgForm.ShowDialog()
        Close()
    End Sub
    'cuandro abramos el Form...
    Private Sub DataViewerForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'cargamos el Theme actual y quitamos el UI del player
        Theme = CurrentTheme
        durationTrackBar.Theme = CurrentTheme
        timeTextBox.Theme = CurrentTheme
        setTimeButton.Theme = CurrentTheme
        player.uiMode = "none"
        'cargamos el video
        If openVideoFile.ShowDialog = DialogResult.OK Then
            PlayFile(openVideoFile.FileName)
        End If
        'refrescamos el Form
        Refresh()
    End Sub
    'en cada tick del Timer...
    Private Sub MyTimer_Tick(sender As Object, e As EventArgs) Handles MyTimer.Tick
        'intantamos detener el video mientras este se está ejecutando
        While player.playState = WMPPlayState.wmppsPlaying
            player.Ctlcontrols.pause()
        End While
        'evitamos errores de frames fantasma al mover de más la barra
        Try
            durationTrackBar.Maximum = player.currentMedia.duration
        Catch ex As Exception
        End Try
        'si el video ya está parado...
        If player.playState = WMPPlayState.wmppsPaused Then
            'mostramos el momento del video en el que estamos con un formato correcto (00:00:00)
            If timeTextBox.Text.Length < 9 Then
                currentTime = "00:" & player.Ctlcontrols.currentPositionString
            Else
                currentTime = player.Ctlcontrols.currentPositionString
            End If
            timeTextBox.Text = currentTime
            'y paramos el Timer
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
        'si no, cambiamos el posicion del vídeo a donde marquemos con la TrackBar
        player.Ctlcontrols.currentPosition = durationTrackBar.Value
        'iniciamos el vídeo desde ahi
        player.Ctlcontrols.play()
        'congelamos el frame
        MyTimer.Enabled = True
        'refrescamos el Form
        Refresh()
    End Sub
    'creamos una subrutina para comprobar que el parametro obtenido tiene un formato correcto
    Public Function isCorrectFormat(ByVal time As String) As Boolean
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
    Public Function StringToInteger(ByVal time As String) As Integer
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
        If finalTime > player.currentMedia.duration Then
            player.Ctlcontrols.currentPosition = player.currentMedia.duration
            durationTrackBar.Value = player.currentMedia.duration
            'sino, cambiamos a donde se haya introducido
        Else
            player.Ctlcontrols.currentPosition = finalTime
            durationTrackBar.Value = finalTime
        End If
        'iniciamos el vídeo desde ahi
        player.Ctlcontrols.play()
        'congelamos el frame
        MyTimer.Enabled = True
        'refrescamos el Form
        Refresh()
    End Sub
End Class