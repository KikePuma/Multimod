<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WebcamForm
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
        Me.WebCamPreview = New WebCAM.WebCam()
        Me.SuspendLayout()
        '
        'WebCamPreview
        '
        Me.WebCamPreview.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.WebCamPreview.Imagen = Nothing
        Me.WebCamPreview.Location = New System.Drawing.Point(23, 86)
        Me.WebCamPreview.MilisegundosCaptura = 100
        Me.WebCamPreview.Name = "WebCamPreview"
        Me.WebCamPreview.Size = New System.Drawing.Size(509, 439)
        Me.WebCamPreview.TabIndex = 0
        '
        'WebcamForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(555, 548)
        Me.Controls.Add(Me.WebCamPreview)
        Me.Name = "WebcamForm"
        Me.Style = MetroFramework.MetroColorStyle.Red
        Me.Text = "Webcam"
        Me.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents WebCamPreview As WebCAM.WebCam
End Class
