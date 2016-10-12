<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AudioForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AudioForm))
        Me.audioPlayer = New AxWMPLib.AxWindowsMediaPlayer()
        Me.audioOpenner = New System.Windows.Forms.OpenFileDialog()
        CType(Me.audioPlayer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'audioPlayer
        '
        Me.audioPlayer.Enabled = True
        Me.audioPlayer.Location = New System.Drawing.Point(23, 63)
        Me.audioPlayer.Name = "audioPlayer"
        Me.audioPlayer.OcxState = CType(resources.GetObject("audioPlayer.OcxState"), System.Windows.Forms.AxHost.State)
        Me.audioPlayer.Size = New System.Drawing.Size(429, 61)
        Me.audioPlayer.TabIndex = 0
        '
        'audioOpenner
        '
        Me.audioOpenner.FileName = "file"
        '
        'AudioForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(475, 152)
        Me.Controls.Add(Me.audioPlayer)
        Me.Name = "AudioForm"
        Me.Style = MetroFramework.MetroColorStyle.Silver
        Me.Text = "AudioForm"
        Me.Theme = MetroFramework.MetroThemeStyle.Dark
        CType(Me.audioPlayer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents audioPlayer As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents audioOpenner As OpenFileDialog
End Class
