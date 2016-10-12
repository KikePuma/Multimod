Public Class MsgForm

    Private Sub MsgForm_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        Me.Theme = CurrentTheme
        MsgLabel.Theme = CurrentTheme
        MsgLabel.Text = Msg
        Me.Refresh()
    End Sub

End Class