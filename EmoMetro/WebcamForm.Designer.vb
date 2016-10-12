<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class WebcamForm
    Inherits MetroFramework.Forms.MetroForm

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.preview = New System.Windows.Forms.PictureBox()
        Me.recordButton = New MetroFramework.Controls.MetroButton()
        Me.cameraButton = New MetroFramework.Controls.MetroButton()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        CType(Me.preview, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'preview
        '
        Me.preview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.preview.Location = New System.Drawing.Point(24, 91)
        Me.preview.Margin = New System.Windows.Forms.Padding(4)
        Me.preview.Name = "preview"
        Me.preview.Size = New System.Drawing.Size(480, 360)
        Me.preview.TabIndex = 0
        Me.preview.TabStop = False
        '
        'recordButton
        '
        Me.recordButton.Location = New System.Drawing.Point(174, 39)
        Me.recordButton.Name = "recordButton"
        Me.recordButton.Size = New System.Drawing.Size(180, 32)
        Me.recordButton.TabIndex = 3
        Me.recordButton.Text = "Record"
        Me.recordButton.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.recordButton.UseSelectable = True
        '
        'cameraButton
        '
        Me.cameraButton.Location = New System.Drawing.Point(360, 39)
        Me.cameraButton.Name = "cameraButton"
        Me.cameraButton.Size = New System.Drawing.Size(144, 32)
        Me.cameraButton.TabIndex = 4
        Me.cameraButton.Text = "Cameras"
        Me.cameraButton.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.cameraButton.UseSelectable = True
        '
        'WebcamForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(528, 475)
        Me.Controls.Add(Me.cameraButton)
        Me.Controls.Add(Me.recordButton)
        Me.Controls.Add(Me.preview)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "WebcamForm"
        Me.Padding = New System.Windows.Forms.Padding(20, 74, 20, 20)
        Me.Text = "Webcam"
        Me.Theme = MetroFramework.MetroThemeStyle.Dark
        CType(Me.preview, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents preview As PictureBox
    Friend WithEvents recordButton As MetroFramework.Controls.MetroButton
    Friend WithEvents cameraButton As MetroFramework.Controls.MetroButton
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
End Class
