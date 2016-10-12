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
        Me.videoPlayer = New AxWMPLib.AxWindowsMediaPlayer()
        Me.MyTimer = New System.Windows.Forms.Timer(Me.components)
        Me.timeTextBox = New MetroFramework.Controls.MetroTextBox()
        Me.setTimeButton = New MetroFramework.Controls.MetroButton()
        Me.personalPlayer = New AxWMPLib.AxWindowsMediaPlayer()
        Me.eegViewer = New System.Windows.Forms.PictureBox()
        Me.eegViewerLabel = New MetroFramework.Controls.MetroLabel()
        Me.loadVideoButton = New MetroFramework.Controls.MetroButton()
        Me.loadWebcamButton = New MetroFramework.Controls.MetroButton()
        Me.BugsTimer = New System.Windows.Forms.Timer(Me.components)
        Me.csvView = New System.Windows.Forms.DataGridView()
        Me.openCsvFile = New System.Windows.Forms.OpenFileDialog()
        Me.loadCsvButton = New MetroFramework.Controls.MetroButton()
        CType(Me.videoPlayer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.personalPlayer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eegViewer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.csvView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'durationTrackBar
        '
        Me.durationTrackBar.BackColor = System.Drawing.Color.Transparent
        Me.durationTrackBar.Enabled = False
        Me.durationTrackBar.Location = New System.Drawing.Point(23, 63)
        Me.durationTrackBar.Name = "durationTrackBar"
        Me.durationTrackBar.Size = New System.Drawing.Size(181, 23)
        Me.durationTrackBar.TabIndex = 1
        Me.durationTrackBar.Text = "MetroTrackBar1"
        Me.durationTrackBar.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.durationTrackBar.Value = 0
        '
        'openVideoFile
        '
        Me.openVideoFile.FileName = "\dev"
        '
        'videoPlayer
        '
        Me.videoPlayer.Enabled = True
        Me.videoPlayer.Location = New System.Drawing.Point(542, 63)
        Me.videoPlayer.Name = "videoPlayer"
        Me.videoPlayer.OcxState = CType(resources.GetObject("videoPlayer.OcxState"), System.Windows.Forms.AxHost.State)
        Me.videoPlayer.Size = New System.Drawing.Size(400, 300)
        Me.videoPlayer.TabIndex = 2
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
        Me.timeTextBox.Location = New System.Drawing.Point(210, 63)
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
        Me.setTimeButton.Location = New System.Drawing.Point(266, 63)
        Me.setTimeButton.Name = "setTimeButton"
        Me.setTimeButton.Size = New System.Drawing.Size(86, 23)
        Me.setTimeButton.TabIndex = 4
        Me.setTimeButton.Text = "set time"
        Me.setTimeButton.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.setTimeButton.UseSelectable = True
        '
        'personalPlayer
        '
        Me.personalPlayer.Enabled = True
        Me.personalPlayer.Location = New System.Drawing.Point(542, 396)
        Me.personalPlayer.Name = "personalPlayer"
        Me.personalPlayer.OcxState = CType(resources.GetObject("personalPlayer.OcxState"), System.Windows.Forms.AxHost.State)
        Me.personalPlayer.Size = New System.Drawing.Size(400, 300)
        Me.personalPlayer.TabIndex = 5
        '
        'eegViewer
        '
        Me.eegViewer.Image = My.Resources.Resources.dsensors
        Me.eegViewer.Location = New System.Drawing.Point(33, 101)
        Me.eegViewer.Name = "eegViewer"
        Me.eegViewer.Size = New System.Drawing.Size(481, 517)
        Me.eegViewer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.eegViewer.TabIndex = 9
        Me.eegViewer.TabStop = False
        '
        'eegViewerLabel
        '
        Me.eegViewerLabel.AutoSize = True
        Me.eegViewerLabel.Location = New System.Drawing.Point(392, 127)
        Me.eegViewerLabel.Name = "eegViewerLabel"
        Me.eegViewerLabel.Size = New System.Drawing.Size(122, 20)
        Me.eegViewerLabel.TabIndex = 10
        Me.eegViewerLabel.Text = "EEG Signal Viewer"
        Me.eegViewerLabel.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'loadVideoButton
        '
        Me.loadVideoButton.AutoSize = True
        Me.loadVideoButton.Location = New System.Drawing.Point(832, 36)
        Me.loadVideoButton.Name = "loadVideoButton"
        Me.loadVideoButton.Size = New System.Drawing.Size(110, 27)
        Me.loadVideoButton.TabIndex = 12
        Me.loadVideoButton.Text = "Video Player"
        Me.loadVideoButton.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.loadVideoButton.UseSelectable = True
        '
        'loadWebcamButton
        '
        Me.loadWebcamButton.AutoSize = True
        Me.loadWebcamButton.Location = New System.Drawing.Point(832, 369)
        Me.loadWebcamButton.Name = "loadWebcamButton"
        Me.loadWebcamButton.Size = New System.Drawing.Size(117, 27)
        Me.loadWebcamButton.TabIndex = 13
        Me.loadWebcamButton.Text = "Webcam Player"
        Me.loadWebcamButton.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.loadWebcamButton.UseSelectable = True
        '
        'BugsTimer
        '
        Me.BugsTimer.Enabled = True
        '
        'csvView
        '
        Me.csvView.BackgroundColor = System.Drawing.SystemColors.ControlText
        Me.csvView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.csvView.Location = New System.Drawing.Point(33, 600)
        Me.csvView.Name = "csvView"
        Me.csvView.RowTemplate.Height = 24
        Me.csvView.Size = New System.Drawing.Size(481, 96)
        Me.csvView.TabIndex = 14
        '
        'openCsvFile
        '
        Me.openCsvFile.DefaultExt = "csv"
        Me.openCsvFile.FileName = "excel"
        Me.openCsvFile.Filter = "CSV files (*.csv)|*.CSV"
        '
        'loadCsvButton
        '
        Me.loadCsvButton.Location = New System.Drawing.Point(404, 573)
        Me.loadCsvButton.Name = "loadCsvButton"
        Me.loadCsvButton.Size = New System.Drawing.Size(110, 21)
        Me.loadCsvButton.TabIndex = 15
        Me.loadCsvButton.Text = "CSV Reader"
        Me.loadCsvButton.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.loadCsvButton.UseSelectable = True
        '
        'DataViewerForm
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(965, 719)
        Me.Controls.Add(Me.loadCsvButton)
        Me.Controls.Add(Me.csvView)
        Me.Controls.Add(Me.loadWebcamButton)
        Me.Controls.Add(Me.loadVideoButton)
        Me.Controls.Add(Me.eegViewerLabel)
        Me.Controls.Add(Me.eegViewer)
        Me.Controls.Add(Me.personalPlayer)
        Me.Controls.Add(Me.setTimeButton)
        Me.Controls.Add(Me.timeTextBox)
        Me.Controls.Add(Me.videoPlayer)
        Me.Controls.Add(Me.durationTrackBar)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "DataViewerForm"
        Me.Style = MetroFramework.MetroColorStyle.Pink
        Me.Text = "DataViewerForm"
        Me.Theme = MetroFramework.MetroThemeStyle.Dark
        CType(Me.videoPlayer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.personalPlayer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eegViewer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.csvView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents durationTrackBar As MetroFramework.Controls.MetroTrackBar
    Friend WithEvents openVideoFile As OpenFileDialog
    Friend WithEvents videoPlayer As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents MyTimer As Timer
    Friend WithEvents timeTextBox As MetroFramework.Controls.MetroTextBox
    Friend WithEvents setTimeButton As MetroFramework.Controls.MetroButton
    Friend WithEvents personalPlayer As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents eegViewer As PictureBox
    Friend WithEvents eegViewerLabel As MetroFramework.Controls.MetroLabel
    Friend WithEvents loadVideoButton As MetroFramework.Controls.MetroButton
    Friend WithEvents loadWebcamButton As MetroFramework.Controls.MetroButton
    Friend WithEvents BugsTimer As Timer
    Friend WithEvents csvView As DataGridView
    Friend WithEvents openCsvFile As OpenFileDialog
    Friend WithEvents loadCsvButton As MetroFramework.Controls.MetroButton
End Class
