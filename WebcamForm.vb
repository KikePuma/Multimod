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
            videoName = defaultOutputPath + DateTime.Now.ToString("yy.MM.dd HH.mm.ss") + videoExtension
            'ponemos este bloque Try Catch para evitar errores del estilo "No se ha escogido camara" o "La ruta es invalida"
            Try
                'definimos el ancho y el alto del fotograma
                Dim videoWidth As Integer = camera.VideoResolution.FrameSize.Width
                Dim videoHeight As Integer = camera.VideoResolution.FrameSize.Height
                'creamos el archivo de video segun los parametros configurados anteriormente
                recording.Open(videoName, videoWidth, videoHeight, fps, VideoCodec.Default, videoBitRate * 1000)
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

