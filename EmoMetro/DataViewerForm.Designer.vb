<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DataViewerForm
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DataViewerForm))
        Me.durationTrackBar = New MetroFramework.Controls.MetroTrackBar()
        Me.openVideoFile = New System.Windows.Forms.OpenFileDialog()
        Me.player = New AxWMPLib.AxWindowsMediaPlayer()
        Me.MyTimer = New System.Windows.Forms.Timer(Me.components)
        Me.timeTextBox = New MetroFramework.Controls.MetroTextBox()
        Me.setTimeButton = New MetroFramework.Controls.MetroButton()
        CType(Me.player, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'durationTrackBar
        '
        Me.durationTrackBar.BackColor = System.Drawing.Color.Transparent
        Me.durationTrackBar.Enabled = False
        Me.durationTrackBar.Location = New System.Drawing.Point(239, 31)
        Me.durationTrackBar.Name = "durationTrackBar"
        Me.durationTrackBar.Size = New System.Drawing.Size(298, 23)
        Me.durationTrackBar.TabIndex = 1
        Me.durationTrackBar.Text = "MetroTrackBar1"
        Me.durationTrackBar.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.durationTrackBar.Value = 0
        '
        'openVideoFile
        '
        Me.openVideoFile.FileName = "\dev"
        '
        'player
        '
        Me.player.Enabled = True
        Me.player.Location = New System.Drawing.Point(23, 71)
        Me.player.Name = "player"
        Me.player.OcxState = CType(resources.GetObject("player.OcxState"), System.Windows.Forms.AxHost.State)
        Me.player.Size = New System.Drawing.Size(640, 480)
        Me.player.TabIndex = 2
        '
        'MyTimer
        '
        Me.MyTimer.Interval = 10
        '
        'timeTextBox
        '
        '
        '
        '
        Me.timeTextBox.CustomButton.Image = Nothing
        Me.timeTextBox.CustomButton.Location = New System.Drawing.Point(28, 1)
        Me.timeTextBox.CustomButton.Name = ""
        Me.timeTextBox.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.timeTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.timeTextBox.CustomButton.TabIndex = 1
        Me.timeTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.timeTextBox.CustomButton.UseSelectable = True
        Me.timeTextBox.CustomButton.Visible = False
        Me.timeTextBox.Enabled = False
        Me.timeTextBox.Lines = New String() {"00:00:00"}
        Me.timeTextBox.Location = New System.Drawing.Point(543, 31)
        Me.timeTextBox.MaxLength = 9
        Me.timeTextBox.Name = "timeTextBox"
        Me.timeTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.timeTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.timeTextBox.SelectedText = ""
        Me.timeTextBox.SelectionLength = 0
        Me.timeTextBox.SelectionStart = 0
        Me.timeTextBox.Size = New System.Drawing.Size(50, 23)
        Me.timeTextBox.TabIndex = 3
        Me.timeTextBox.Text = "00:00:00"
        Me.timeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.timeTextBox.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.timeTextBox.UseSelectable = True
        Me.timeTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.timeTextBox.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'setTimeButton
        '
        Me.setTimeButton.Enabled = False
        Me.setTimeButton.Location = New System.Drawing.Point(599, 30)
        Me.setTimeButton.Name = "setTimeButton"
        Me.setTimeButton.Size = New System.Drawing.Size(64, 23)
        Me.setTimeButton.TabIndex = 4
        Me.setTimeButton.Text = "set time"
        Me.setTimeButton.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.setTimeButton.UseSelectable = True
        '
        'DataViewerForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(965, 574)
        Me.Controls.Add(Me.setTimeButton)
        Me.Controls.Add(Me.timeTextBox)
        Me.Controls.Add(Me.player)
        Me.Controls.Add(Me.durationTrackBar)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "DataViewerForm"
        Me.Style = MetroFramework.MetroColorStyle.Pink
        Me.Text = "DataViewerForm"
        Me.Theme = MetroFramework.MetroThemeStyle.Dark
        CType(Me.player, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents durationTrackBar As MetroFramework.Controls.MetroTrackBar
    Friend WithEvents openVideoFile As OpenFileDialog
    Friend WithEvents player As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents MyTimer As Timer
    Friend WithEvents timeTextBox As MetroFramework.Controls.MetroTextBox
    Friend WithEvents setTimeButton As MetroFramework.Controls.MetroButton
End Class
