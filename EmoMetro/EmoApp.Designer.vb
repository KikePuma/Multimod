<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class EmoApp
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
        Me.ThemeCheckBox = New MetroFramework.Controls.MetroCheckBox()
        Me.PraatButton = New MetroFramework.Controls.MetroButton()
        Me.ElanButton = New MetroFramework.Controls.MetroButton()
        Me.OpenFileDialog = New System.Windows.Forms.OpenFileDialog()
        Me.WebcamButton = New MetroFramework.Controls.MetroButton()
        Me.EmotivButton = New MetroFramework.Controls.MetroButton()
        Me.SuspendLayout()
        '
        'ThemeCheckBox
        '
        Me.ThemeCheckBox.AutoSize = True
        Me.ThemeCheckBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.ThemeCheckBox.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ThemeCheckBox.Location = New System.Drawing.Point(391, 470)
        Me.ThemeCheckBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ThemeCheckBox.Name = "ThemeCheckBox"
        Me.ThemeCheckBox.Size = New System.Drawing.Size(95, 17)
        Me.ThemeCheckBox.Style = MetroFramework.MetroColorStyle.Green
        Me.ThemeCheckBox.TabIndex = 1
        Me.ThemeCheckBox.Text = "Light Theme"
        Me.ThemeCheckBox.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.ThemeCheckBox.UseSelectable = True
        '
        'PraatButton
        '
        Me.PraatButton.Location = New System.Drawing.Point(23, 455)
        Me.PraatButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PraatButton.Name = "PraatButton"
        Me.PraatButton.Size = New System.Drawing.Size(111, 31)
        Me.PraatButton.Style = MetroFramework.MetroColorStyle.Red
        Me.PraatButton.TabIndex = 2
        Me.PraatButton.Text = "PRAAT"
        Me.PraatButton.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.PraatButton.UseSelectable = True
        '
        'ElanButton
        '
        Me.ElanButton.Location = New System.Drawing.Point(140, 455)
        Me.ElanButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ElanButton.Name = "ElanButton"
        Me.ElanButton.Size = New System.Drawing.Size(111, 31)
        Me.ElanButton.Style = MetroFramework.MetroColorStyle.Red
        Me.ElanButton.TabIndex = 3
        Me.ElanButton.Text = "ELAN"
        Me.ElanButton.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.ElanButton.UseSelectable = True
        '
        'OpenFileDialog
        '
        Me.OpenFileDialog.FileName = "\dev"
        '
        'WebcamButton
        '
        Me.WebcamButton.Location = New System.Drawing.Point(23, 418)
        Me.WebcamButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.WebcamButton.Name = "WebcamButton"
        Me.WebcamButton.Size = New System.Drawing.Size(111, 31)
        Me.WebcamButton.Style = MetroFramework.MetroColorStyle.Red
        Me.WebcamButton.TabIndex = 4
        Me.WebcamButton.Text = "WEBCAM"
        Me.WebcamButton.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.WebcamButton.UseSelectable = True
        '
        'EmotivButton
        '
        Me.EmotivButton.Location = New System.Drawing.Point(140, 418)
        Me.EmotivButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.EmotivButton.Name = "EmotivButton"
        Me.EmotivButton.Size = New System.Drawing.Size(111, 31)
        Me.EmotivButton.Style = MetroFramework.MetroColorStyle.Red
        Me.EmotivButton.TabIndex = 5
        Me.EmotivButton.Text = "EMOTIV"
        Me.EmotivButton.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.EmotivButton.UseSelectable = True
        '
        'EmoApp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(500, 500)
        Me.Controls.Add(Me.EmotivButton)
        Me.Controls.Add(Me.WebcamButton)
        Me.Controls.Add(Me.ElanButton)
        Me.Controls.Add(Me.PraatButton)
        Me.Controls.Add(Me.ThemeCheckBox)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "EmoApp"
        Me.Padding = New System.Windows.Forms.Padding(20, 74, 20, 20)
        Me.Resizable = False
        Me.Style = MetroFramework.MetroColorStyle.Green
        Me.Text = "EmotivApp"
        Me.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ThemeCheckBox As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents PraatButton As MetroFramework.Controls.MetroButton
    Friend WithEvents ElanButton As MetroFramework.Controls.MetroButton
    Friend WithEvents OpenFileDialog As OpenFileDialog
    Friend WithEvents WebcamButton As MetroFramework.Controls.MetroButton
    Friend WithEvents EmotivButton As MetroFramework.Controls.MetroButton
End Class
