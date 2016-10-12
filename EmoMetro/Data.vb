Module Data
    ''' <summary>
    '''  @ Kike 'Puma' Fontán
    '''  https://github.com/KikePuma/
    ''' </summary>

    ''' ## STYLE VARIABLES ##
    Public DarkTheme As Boolean = True
    Public CurrentTheme As Integer = MetroFramework.MetroThemeStyle.Dark

    ''' ## PROGRAM PATH ##
    Public NullPath As String = "\dev"
    Public PraatPath As String = My.Application.Info.DirectoryPath.ToString + "\xtern_\praat.exe"
    Public EEGWriterPath As String = My.Application.Info.DirectoryPath.ToString + "\xtern_\eegwriter\eegwriter.exe"
    Public ElanPath As String = NullPath

    ''' ### MESSAGES ###
    Public Msg As String = "\dev"

End Module
