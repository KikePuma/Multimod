Public Class WebcamForm

    Private Sub WebcamForm_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        Me.Theme = CurrentTheme
        Me.Refresh()
    End Sub

    Private Sub WebcamForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        WebCamPreview.Start()
        WebCamPreview.Start()
    End Sub

    Private Sub WebcamForm_Deactivate(sender As Object, e As EventArgs) Handles MyBase.Deactivate
        WebCamPreview.Stop()
    End Sub
End Class