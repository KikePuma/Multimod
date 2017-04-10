'importamos las librerias necesarias
Imports AForge.Video
Imports AForge.Video.FFMPEG
Imports AForge.Video.DirectShow

Public Class WebcamForm
    'declaramos un Bitmap para poder 
    Dim frame As Bitmap
    'declaramos el grabador
    Dim recording As New VideoFileWriter
    'declaramos el estilo inicial del Form
    Dim initialFormStyle As Integer = Style
    'declaramos una variable para saber cuando estamos grabando
    Dim onAir As Boolean = False
    Public Declare Function mciSendString Lib "winmm.dll" Alias "mciSendStringA" (ByVal lpstrCommand As String, ByVal lpstrReturnString As String, ByVal uReturnLength As Integer, ByVal hwndCallback As Integer) As Integer


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Button1.Enabled = False
        Button2.Enabled = True
        Label1.Text = "Grabando..."
        mciSendString("open new Type waveaudio Alias recsound", "", 0, 0)
        mciSendString("record recsound", "", 0, 0)
        SaveFileDialog1.FileName = defaultOutputPath + DateTime.Now.ToString("ddMMyyyyHHmmssffff") + ".mp3"
        'ponemos nombre al archivo 

        '  mciSendString("save recsound " & SaveFileDialog1.FileName, "", 0, 0)
        'mciSendString("close recsound", "", 0, 0)
        ' Label1.Text = "Stopped..."

    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim temp As String
        If Label1.Text = "Playing..." Then
            Button1.Enabled = True
            Button2.Enabled = False
            Label1.Text = "detenido..."
            My.Computer.Audio.Stop()
        ElseIf Label1.Text = "Grabando..." Then
            ' SaveFileDialog1.Filter = "MP3 Audio Files|*.mp3"
            SaveFileDialog1.FileName = defaultOutputPath + DateTime.Now.ToString("ddMMyyyyHHmmssffff") + ".mp3"
            'ponemo nombre al archivo 
            ' If SaveFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            '   temp = SaveFileDialog1.FileName
            mciSendString("save recsound " & SaveFileDialog1.FileName, "", 0, 0)
            mciSendString("close recsound", "", 0, 0)
            Label1.Text = "Stopped..."
            Label1.Visible = True
            Button1.Enabled = True

            My.Computer.Audio.Stop()
            ' End If
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        OpenFileDialog1.Filter = "MP3 Audio Files|*.MP3"
        OpenFileDialog1.FileName = ""
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            Button1.Enabled = False
            My.Computer.Audio.Play(OpenFileDialog1.FileName, AudioPlayMode.Background)

            Label1.Visible = True
            Label1.Text = "Parado"
        End If
    End Sub

    'creamos una subrutina para grabar con la camara
    Private Sub Record(sender As Object, eventArgs As NewFrameEventArgs)
        'si no estamos grabando...
        If onAir = False Then
            Try
                'ponemos los datos de la camara en el Bitmap
                frame = DirectCast(eventArgs.Frame.Clone(), Bitmap)
                'y los presentamos en el PictureBox
                preview.Image = DirectCast(eventArgs.Frame.Clone(), Bitmap)
            Catch ex As Exception
            End Try
            'si estamos grabando...
        Else
            Try
                'ponemos los datos de la camara en el PictureBox
                preview.Image = DirectCast(eventArgs.Frame.Clone(), Bitmap)
            Catch ex As Exception
            End Try
            Try
                'los presentamos en el Bitmap
                frame = DirectCast(eventArgs.Frame.Clone(), Bitmap)
                'y los guardamos en la memoria
                recording.WriteVideoFrame(frame)
            Catch ex As Exception
            End Try
        End If
    End Sub
    'subrutina del boton de las camaras

    Public Sub cameraButton_Click(sender As Object, e As EventArgs) Handles cameraButton.Click
        'creamos un dialogo con todas las camaras disponibles
        Dim availableCameras As VideoCaptureDeviceForm = New VideoCaptureDeviceForm()
        'si se ha seleccionado una camara...
        If availableCameras.ShowDialog = DialogResult.OK Then
            'guardamos la camara seleccionada y marcamos que ya la hemos seleccionado
            camera = availableCameras.VideoDevice
            cameraSet = True
            'creamos el evento para grabar a partir de la subrutina anterior
            AddHandler camera.NewFrame, New NewFrameEventHandler(AddressOf Record)
            'cerramos posibles camaras abiertas
            Try
                camera.Stop()
            Catch ex As Exception
            End Try
            'encendemos la camara
            camera.Start()
        End If
    End Sub




    'creamos la subrutina que nos permita grabar desde fuera del Form
    Public Sub startRecording()
        'si no estamos grabando...
        If onAir = False Then
            'definimos donde y con que nombre/formato se va a guardar el archivo de video
            videoName = defaultOutputPath + DateTime.Now.ToString("dd.MM.yy HH.mm.ss.ffff") + videoExtension
            'ponemos este bloque Try Catch para evitar errores del estilo "No se ha escogido camara" o "La ruta es invalida"
            Try
                'definimos el ancho y el alto del fotograma
                Dim videoWidth As Integer = camera.VideoResolution.FrameSize.Width
                Dim videoHeight As Integer = camera.VideoResolution.FrameSize.Height
                Dim finalFrame As VideoCaptureDevice = New VideoCaptureDevice


                'creamos el archivo de video segun los parametros configurados anteriormente

                recording.Open(videoName, videoWidth, videoHeight, bitframe.Value, VideoCodec.Default, bitrate.Value)

                'empezamos a guardar datos
                recording.WriteVideoFrame(frame)




            Catch ex As Exception
            End Try
            'cambiamos el booleano, el estilo y refrescamos el form para saber que estamos grabando
            onAir = True
            Try
                Style = MetroFramework.MetroColorStyle.Red
                Refresh()
            Catch ex As Exception
            End Try

        Else
            'indicamos que dejamos de grabar
            onAir = False
            Try
                Style = initialFormStyle
                Refresh()
            Catch ex As Exception
            End Try
            Try
                'dejamos de grabar
                recording.Close()
            Catch ex As Exception
            End Try
        End If
    End Sub
    'al boton de grabar le damos dicha utilidad
    Private Sub recordButton_Click(sender As Object, e As EventArgs) Handles recordButton.Click
        startRecording()
    End Sub
    'subrutina al cerrar el Form
    Public Sub WebcamForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        'apagamos la camara
        Try
            camera.Stop()
        Catch ex As Exception
        End Try
        'cambiamos el texto del SynchroButton a uno apropiado
        Multimod.SynchroButton.Text = "START SYNCHRO"
    End Sub
    'subrutina al cargar el Form
    Private Sub WebcamForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'ajustamos la imagen de la camara al PictureBox
        preview.SizeMode = PictureBoxSizeMode.Zoom
        'cambiamos el tema del Form segun el actual
        Theme = CurrentTheme
        recordButton.Theme = CurrentTheme
        cameraButton.Theme = CurrentTheme
        Refresh()
        'abrimos la camara si ya previamente se ha seleccionado una
        Try
            If cameraSet Then
                AddHandler camera.NewFrame, New NewFrameEventHandler(AddressOf Record)
                camera.Start()
            End If
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
    End Sub


End Class

