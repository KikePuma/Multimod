<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class VideoPlayerForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(VideoPlayerForm))
        Me.player = New AxWMPLib.AxWindowsMediaPlayer()
        Me.pauseButton = New System.Windows.Forms.PictureBox()
        Me.playButton = New System.Windows.Forms.PictureBox()
        Me.stopButton = New System.Windows.Forms.PictureBox()
        Me.loadVideo = New System.Windows.Forms.OpenFileDialog()
        Me.MyTimer = New System.Windows.Forms.Timer(Me.components)
        CType(Me.player, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pauseButton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.playButton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.stopButton, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'player
        '
        Me.player.Dock = System.Windows.Forms.DockStyle.Fill
        Me.player.Enabled = True
        Me.player.Location = New System.Drawing.Point(15, 60)
        Me.player.Margin = New System.Windows.Forms.Padding(2)
        Me.player.Name = "player"
        Me.player.OcxState = CType(resources.GetObject("player.OcxState"), System.Windows.Forms.AxHost.State)
        Me.player.Size = New System.Drawing.Size(484, 390)
        Me.player.TabIndex = 0
        Me.player.UseWaitCursor = True
        '
        'pauseButton
        '
        Me.pauseButton.Image = Global.Multimod.My.Resources.Resources.dpause
        Me.pauseButton.Location = New System.Drawing.Point(455, 24)
        Me.pauseButton.Margin = New System.Windows.Forms.Padding(2)
        Me.pauseButton.Name = "pauseButton"
        Me.pauseButton.Size = New System.Drawing.Size(19, 20)
        Me.pauseButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pauseButton.TabIndex = 3
        Me.pauseButton.TabStop = False
        '
        'playButton
        '
        Me.playButton.Image = Global.Multimod.My.Resources.Resources.dplay
        Me.playButton.Location = New System.Drawing.Point(432, 24)
        Me.playButton.Margin = New System.Windows.Forms.Padding(2)
        Me.playButton.Name = "playButton"
        Me.playButton.Size = New System.Drawing.Size(19, 20)
        Me.playButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.playButton.TabIndex = 2
        Me.playButton.TabStop = False
        '
        'stopButton
        '
        Me.stopButton.Image = Global.Multimod.My.Resources.Resources.dstop
        Me.stopButton.Location = New System.Drawing.Point(478, 24)
        Me.stopButton.Margin = New System.Windows.Forms.Padding(2)
        Me.stopButton.Name = "stopButton"
        Me.stopButton.Size = New System.Drawing.Size(19, 20)
        Me.stopButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.stopButton.TabIndex = 1
        Me.stopButton.TabStop = False
        '
        'loadVideo
        '
        Me.loadVideo.FileName = ".avi"
        '
        'MyTimer
        '
        Me.MyTimer.Interval = 10
        '
        'VideoPlayerForm
        '
        Me.ApplyImageInvert = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(514, 466)
        Me.Controls.Add(Me.pauseButton)
        Me.Controls.Add(Me.playButton)
        Me.Controls.Add(Me.stopButton)
        Me.Controls.Add(Me.player)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "VideoPlayerForm"
        Me.Padding = New System.Windows.Forms.Padding(15, 60, 15, 16)
        Me.Style = MetroFramework.MetroColorStyle.Orange
        Me.Text = "VideoPlayer"
        Me.Theme = MetroFramework.MetroThemeStyle.Dark
        CType(Me.player, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pauseButton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.playButton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.stopButton, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents player As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents stopButton As PictureBox
    Friend WithEvents playButton As PictureBox
    Friend WithEvents pauseButton As PictureBox
    Friend WithEvents loadVideo As OpenFileDialog
    Friend WithEvents MyTimer As Timer
End Class
