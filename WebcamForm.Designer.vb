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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(WebcamForm))
        Me.preview = New System.Windows.Forms.PictureBox()
        Me.recordButton = New MetroFramework.Controls.MetroButton()
        Me.cameraButton = New MetroFramework.Controls.MetroButton()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.bitframe = New System.Windows.Forms.NumericUpDown()
        Me.bitrate = New System.Windows.Forms.NumericUpDown()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.preview, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bitframe, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bitrate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'preview
        '
        Me.preview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.preview.Location = New System.Drawing.Point(18, 74)
        Me.preview.Name = "preview"
        Me.preview.Size = New System.Drawing.Size(360, 293)
        Me.preview.TabIndex = 0
        Me.preview.TabStop = False
        '
        'recordButton
        '
        Me.recordButton.Location = New System.Drawing.Point(130, 32)
        Me.recordButton.Margin = New System.Windows.Forms.Padding(2)
        Me.recordButton.Name = "recordButton"
        Me.recordButton.Size = New System.Drawing.Size(135, 26)
        Me.recordButton.TabIndex = 3
        Me.recordButton.Text = "Record"
        Me.recordButton.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.recordButton.UseSelectable = True
        '
        'cameraButton
        '
        Me.cameraButton.Location = New System.Drawing.Point(270, 32)
        Me.cameraButton.Margin = New System.Windows.Forms.Padding(2)
        Me.cameraButton.Name = "cameraButton"
        Me.cameraButton.Size = New System.Drawing.Size(108, 26)
        Me.cameraButton.TabIndex = 4
        Me.cameraButton.Text = "Cameras"
        Me.cameraButton.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.cameraButton.UseSelectable = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(413, 230)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Sonido"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(416, 275)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = "Parar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(416, 246)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Grabar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'bitframe
        '
        Me.bitframe.Location = New System.Drawing.Point(408, 92)
        Me.bitframe.Name = "bitframe"
        Me.bitframe.Size = New System.Drawing.Size(83, 20)
        Me.bitframe.TabIndex = 10
        Me.bitframe.Value = New Decimal(New Integer() {30, 0, 0, 0})
        '
        'bitrate
        '
        Me.bitrate.Location = New System.Drawing.Point(408, 139)
        Me.bitrate.Maximum = New Decimal(New Integer() {-727379969, 232, 0, 0})
        Me.bitrate.Name = "bitrate"
        Me.bitrate.Size = New System.Drawing.Size(83, 20)
        Me.bitrate.TabIndex = 11
        Me.bitrate.Value = New Decimal(New Integer() {250000, 0, 0, 0})
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Cyan
        Me.Label2.Location = New System.Drawing.Point(409, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 13)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Frame"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Cyan
        Me.Label3.ForeColor = System.Drawing.SystemColors.MenuText
        Me.Label3.Location = New System.Drawing.Point(409, 118)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 13)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "BitRate"
        '
        'WebcamForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(550, 386)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.bitrate)
        Me.Controls.Add(Me.bitframe)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cameraButton)
        Me.Controls.Add(Me.recordButton)
        Me.Controls.Add(Me.preview)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(20, 20)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "WebcamForm"
        Me.Padding = New System.Windows.Forms.Padding(15, 60, 15, 16)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Webcam"
        Me.Theme = MetroFramework.MetroThemeStyle.Dark
        CType(Me.preview, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bitframe, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bitrate, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents preview As PictureBox
    Friend WithEvents recordButton As MetroFramework.Controls.MetroButton
    Friend WithEvents cameraButton As MetroFramework.Controls.MetroButton
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents Label1 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents bitframe As NumericUpDown
    Friend WithEvents bitrate As NumericUpDown
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
