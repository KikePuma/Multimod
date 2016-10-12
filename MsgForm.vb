Public Class MsgForm
    'creamos la subrutina para cuando se muestre el Form
    Private Sub MsgForm_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        'ponemos el tema actual
        Me.Theme = CurrentTheme
        MsgLabel.Theme = CurrentTheme
        'cambiamos el mensaje a mostrar
        MsgLabel.Text = Msg
        'refrescamos el Form
        Me.Refresh()
    End Sub

End Class