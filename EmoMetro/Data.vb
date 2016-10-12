Module Data

    '' ===========================
    '' || @ Kike 'Puma' Fontán  ||
    '' ===========================

    '' ## STYLE VARIABLES ##
    Public DarkTheme As Boolean = True
    Public CurrentTheme As Integer = MetroFramework.MetroThemeStyle.Dark

    '' ## PROGRAM PATH ##
    Public NullPath As String = "\dev"
    Public PraatPath As String = My.Application.Info.DirectoryPath.ToString + "\xtern_\praat.exe"
    Public EEGWriterPath As String = My.Application.Info.DirectoryPath.ToString + "\xtern_\eegwriter\eegwriter.exe"
    Public ElanPath As String = NullPath

    '' ### MESSAGES ###
    Public Msg As String = "\dev"

    '' ### FILE VARIABLES ###
    Public defaultOutputPath As String = My.Application.Info.DirectoryPath.ToString + "\output_\"

    Public videoExtension As String = ".avi"
    Public videoName As String = "errorSettingName"
    Public videoDefaultCodec As AForge.Video.FFMPEG.VideoCodec = AForge.Video.FFMPEG.VideoCodec.Default
    Public fps As Integer = 30
    Public videoBitRate As Integer = 300
End Module
