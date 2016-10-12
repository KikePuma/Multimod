'importamos las librerias necesarias
Imports AForge.Video
Imports AForge.Video.FFMPEG
Imports AForge.Video.DirectShow

Public Class WebcamForm
    'declaramos la variable para la camara
    Dim camera As VideoCaptureDevice
    'declaramos un Bitmap para poder 
    Dim frame As Bitmap
    'declaramos el grabador
    Dim recording As New VideoFileWriter
    'declaramos el estilo inicial del Form
    Dim initialFormStyle As Integer = Style
    'declaramos una variable para saber cuando estamos grabando
    Dim onAir As Boolean = False


    'creamos una subrutina para grabar con la camara
    Private Sub Record(sender As Object, eventArgs As NewFrameEventArgs)
        'si no estamos grabando...
        If onAir = False Then
            'ponemos los datos de la camara en el Bitmap
            frame = DirectCast(eventArgs.Frame.Clone(), Bitmap)
            'y los presentamos en el PictureBox
            preview.Image = DirectCast(eventArgs.Frame.Clone(), Bitmap)
            'si estamos grabando...
        Else
            Try
                'ponemos los datos de la camara en el Bitmap
                frame = DirectCast(eventArgs.Frame.Clone(), Bitmap)
                'los presentamos en el PictureBox
                preview.Image = DirectCast(eventArgs.Frame.Clone(), Bitmap)
                'y los guardamos en la memoria
                recording.WriteVideoFrame(frame)
            Catch ex As Exception
            End Try
        End If
    End Sub
    'subrutina del boton de las camaras
    Private Sub cameraButton_Click(sender As Object, e As EventArgs) Handles cameraButton.Click
        'creamos un dialogo con todas las camaras disponibles
        Dim availableCameras As VideoCaptureDeviceForm = New VideoCaptureDeviceForm()
        'si se ha seleccionado una camara...
        If availableCameras.ShowDialog = DialogResult.OK Then
            'guardamos la camara seleccionada
            camera = availableCameras.VideoDevice
            'creamos el evento para grabar a partir de la subrutina anterior
            AddHandler camera.NewFrame, New NewFrameEventHandler(AddressOf Record)
            'encendemos la camara
            camera.Start()
        End If
    End Sub

    Private Sub recordButton_Click(sender As Object, e As EventArgs) Handles recordButton.Click
        'si no estamos grabando...
        If onAir = False Then
            'definimos donde y con que nombre/formato se va a guardar el archivo de video
            videoName = defaultOutputPath + DateTime.Now.ToString("yy.MM.dd HH.mm.ss") + videoExtension
            'ponemos este bloque Try Catch para evitar errores del estilo "No se ha escogido camara" o "La ruta es invalida"
            Try
                'definimos el ancho y el alto del fotograma
                Dim videoWidth As Integer = camera.VideoResolution.FrameSize.Width
                Dim videoHeight As Integer = camera.VideoResolution.FrameSize.Height
                'creamos el archivo de video segun los parametros configurados anteriormente
                recording.Open(videoName, videoWidth, videoHeight, 30, VideoCodec.Default, 300 * 1000)
                'empezamos a guardar datos
                recording.WriteVideoFrame(frame)
                'cambiamos el booleano, el estilo y refrescamos el form para saber que estamos grabando
                onAir = True
                Style = MetroFramework.MetroColorStyle.Red
                Refresh()
            Catch ex As Exception
            End Try
        Else
            'indicamos que dejamos de grabar
            onAir = False
            Style = initialFormStyle
            Refresh()
            'dejamos de grabar
            recording.Close()
        End If
    End Sub

    Private Sub WebcamForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        'apagamos la camara
        Try
            camera.Stop()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub WebcamForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'ajustamos la imagen de la camara al PictureBox
        preview.SizeMode = PictureBoxSizeMode.Zoom
        'cambiamos el tema del Form segun el actual
        Theme = CurrentTheme
        recordButton.Theme = CurrentTheme
        cameraButton.Theme = CurrentTheme
        Refresh()
    End Sub
End Class

