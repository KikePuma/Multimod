Module Data

    '' =========================================
    '' || @Kike 'Puma' Fontán & Óscar Moldes  ||
    '' =========================================

    '' ## STYLE VARIABLES ##
    Public DarkTheme As Boolean = True
    Public CurrentTheme As Integer = MetroFramework.MetroThemeStyle.Dark

    '' ## PROGRAM PATH ##
    Public NullPath As String = "\dev"
    Public MyPath As String = My.Application.Info.DirectoryPath.ToString
    Public PraatPath As String = MyPath + "\xtern_\praat.exe"
    Public EEGWriterPath As String = MyPath + "\xtern_\eegwriter\eegwriter.exe"
    Public ElanPath As String = NullPath

    '' ### MESSAGES ###
    Public Msg As String = "\dev"

    '' ### WEBCAM VARIABLES ###
    Public camera As AForge.Video.DirectShow.VideoCaptureDevice = Nothing
    Public cameraSet As Boolean = False

    '' ### FILE VARIABLES ###
    Public defaultOutputPath As String = MyPath + "\output_\"
    Public xternPath As String = MyPath + "\xtern_\"

    Public videoExtension As String = ".avi"
    Public videoName As String = "errorSettingName"
    Public videoDefaultCodec As AForge.Video.FFMPEG.VideoCodec = AForge.Video.FFMPEG.VideoCodec.Default
    Public fps As Integer = 15 '15
    Public videoBitRate As Integer = 24915 '24915

    '' ## SYNCHRO VARIABLES ##


End Module
