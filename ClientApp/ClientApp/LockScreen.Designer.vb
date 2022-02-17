<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LockScreen
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LockScreen))
        Me.AWMVideo = New AxWMPLib.AxWindowsMediaPlayer()
        Me.pbImage = New System.Windows.Forms.PictureBox()
        CType(Me.AWMVideo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AWMVideo
        '
        Me.AWMVideo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AWMVideo.Enabled = True
        Me.AWMVideo.Location = New System.Drawing.Point(0, 0)
        Me.AWMVideo.Name = "AWMVideo"
        Me.AWMVideo.OcxState = CType(resources.GetObject("AWMVideo.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AWMVideo.Size = New System.Drawing.Size(800, 600)
        Me.AWMVideo.TabIndex = 2
        '
        'pbImage
        '
        Me.pbImage.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pbImage.Enabled = False
        Me.pbImage.Image = Global.ClientApp.My.Resources.Resources.DefaultWallpaper
        Me.pbImage.Location = New System.Drawing.Point(0, 0)
        Me.pbImage.Name = "pbImage"
        Me.pbImage.Size = New System.Drawing.Size(800, 600)
        Me.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbImage.TabIndex = 0
        Me.pbImage.TabStop = False
        '
        'LockScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(800, 600)
        Me.Controls.Add(Me.pbImage)
        Me.Controls.Add(Me.AWMVideo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.Name = "LockScreen"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "LockScreen"
        Me.TopMost = True
        CType(Me.AWMVideo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pbImage As System.Windows.Forms.PictureBox
    Friend WithEvents AWMVideo As AxWMPLib.AxWindowsMediaPlayer
End Class
