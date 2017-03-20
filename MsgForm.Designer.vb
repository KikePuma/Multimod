<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MsgForm
    Inherits MetroFramework.Forms.MetroForm

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MsgLabel = New MetroFramework.Controls.MetroLabel()
        Me.SuspendLayout()
        '
        'MsgLabel
        '
        Me.MsgLabel.CausesValidation = False
        Me.MsgLabel.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MsgLabel.Location = New System.Drawing.Point(17, 49)
        Me.MsgLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.MsgLabel.Name = "MsgLabel"
        Me.MsgLabel.Size = New System.Drawing.Size(194, 58)
        Me.MsgLabel.Style = MetroFramework.MetroColorStyle.Red
        Me.MsgLabel.TabIndex = 0
        Me.MsgLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.MsgLabel.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'MsgForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(229, 123)
        Me.Controls.Add(Me.MsgLabel)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "MsgForm"
        Me.Padding = New System.Windows.Forms.Padding(15, 49, 15, 16)
        Me.ShowIcon = False
        Me.Style = MetroFramework.MetroColorStyle.Red
        Me.Text = "Message"
        Me.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MsgLabel As MetroFramework.Controls.MetroLabel
End Class
