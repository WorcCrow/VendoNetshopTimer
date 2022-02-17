<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BlankForm
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
        Me.components = New System.ComponentModel.Container()
        Me.cmsLockScreen = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.UnlockTSMI = New System.Windows.Forms.ToolStripMenuItem()
        Me.SettingTSMI = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitTSMI = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoginToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CustomizeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmsLockScreen.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmsLockScreen
        '
        Me.cmsLockScreen.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UnlockTSMI, Me.SettingTSMI, Me.ExitTSMI})
        Me.cmsLockScreen.Name = "cmsLockScreen"
        Me.cmsLockScreen.Size = New System.Drawing.Size(153, 92)
        '
        'UnlockTSMI
        '
        Me.UnlockTSMI.Name = "UnlockTSMI"
        Me.UnlockTSMI.Size = New System.Drawing.Size(152, 22)
        Me.UnlockTSMI.Text = "Unlock"
        Me.UnlockTSMI.Visible = False
        '
        'SettingTSMI
        '
        Me.SettingTSMI.Name = "SettingTSMI"
        Me.SettingTSMI.Size = New System.Drawing.Size(152, 22)
        Me.SettingTSMI.Text = "Setting"
        '
        'ExitTSMI
        '
        Me.ExitTSMI.Name = "ExitTSMI"
        Me.ExitTSMI.Size = New System.Drawing.Size(152, 22)
        Me.ExitTSMI.Text = "Exit"
        '
        'LoginToolStripMenuItem
        '
        Me.LoginToolStripMenuItem.Name = "LoginToolStripMenuItem"
        Me.LoginToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.LoginToolStripMenuItem.Text = "Unlock"
        '
        'CustomizeToolStripMenuItem
        '
        Me.CustomizeToolStripMenuItem.Name = "CustomizeToolStripMenuItem"
        Me.CustomizeToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.CustomizeToolStripMenuItem.Text = "Settings"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'BlankForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(150, 150)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "BlankForm"
        Me.Opacity = 0.01R
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "BlankForm"
        Me.TopMost = True
        Me.cmsLockScreen.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmsLockScreen As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents LoginToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CustomizeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UnlockTSMI As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SettingTSMI As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitTSMI As System.Windows.Forms.ToolStripMenuItem
End Class
