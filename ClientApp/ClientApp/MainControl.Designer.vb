<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainControl
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainControl))
        Me.niSystemTray = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.cmsNotifyIcon = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TTEnable = New System.Windows.Forms.ToolTip(Me.components)
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btnSwap = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnChat = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PBTime = New System.Windows.Forms.ProgressBar()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lbConStatus = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lTime = New System.Windows.Forms.Label()
        Me.PTitlebar = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmsNotifyIcon.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.PTitlebar.SuspendLayout()
        Me.SuspendLayout()
        '
        'niSystemTray
        '
        Me.niSystemTray.ContextMenuStrip = Me.cmsNotifyIcon
        Me.niSystemTray.Icon = CType(resources.GetObject("niSystemTray.Icon"), System.Drawing.Icon)
        Me.niSystemTray.Visible = True
        '
        'cmsNotifyIcon
        '
        Me.cmsNotifyIcon.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.cmsNotifyIcon.Name = "cmsNotifyIcon"
        Me.cmsNotifyIcon.Size = New System.Drawing.Size(93, 26)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(92, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Transparent
        Me.Button2.BackgroundImage = Global.ClientApp.My.Resources.Resources.LockIcon
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Navy
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Location = New System.Drawing.Point(90, 106)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(35, 35)
        Me.Button2.TabIndex = 14
        Me.TTEnable.SetToolTip(Me.Button2, "Lock")
        Me.Button2.UseVisualStyleBackColor = False
        '
        'btnSwap
        '
        Me.btnSwap.BackColor = System.Drawing.Color.Transparent
        Me.btnSwap.BackgroundImage = Global.ClientApp.My.Resources.Resources.SwapIcon
        Me.btnSwap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSwap.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Navy
        Me.btnSwap.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue
        Me.btnSwap.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSwap.Location = New System.Drawing.Point(49, 106)
        Me.btnSwap.Name = "btnSwap"
        Me.btnSwap.Size = New System.Drawing.Size(35, 35)
        Me.btnSwap.TabIndex = 13
        Me.TTEnable.SetToolTip(Me.btnSwap, "Swap")
        Me.btnSwap.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Navy
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(131, 106)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(35, 35)
        Me.Button1.TabIndex = 12
        Me.Button1.Tag = "123"
        Me.TTEnable.SetToolTip(Me.Button1, "Logout")
        Me.Button1.UseVisualStyleBackColor = False
        '
        'btnChat
        '
        Me.btnChat.BackColor = System.Drawing.Color.Transparent
        Me.btnChat.BackgroundImage = CType(resources.GetObject("btnChat.BackgroundImage"), System.Drawing.Image)
        Me.btnChat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnChat.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Navy
        Me.btnChat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue
        Me.btnChat.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnChat.Location = New System.Drawing.Point(8, 106)
        Me.btnChat.Name = "btnChat"
        Me.btnChat.Size = New System.Drawing.Size(35, 35)
        Me.btnChat.TabIndex = 11
        Me.TTEnable.SetToolTip(Me.btnChat, "Chat")
        Me.btnChat.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.AliceBlue
        Me.Panel2.BackgroundImage = CType(resources.GetObject("Panel2.BackgroundImage"), System.Drawing.Image)
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel2.Controls.Add(Me.Button2)
        Me.Panel2.Controls.Add(Me.btnSwap)
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Controls.Add(Me.btnChat)
        Me.Panel2.Controls.Add(Me.PBTime)
        Me.Panel2.Controls.Add(Me.Panel1)
        Me.Panel2.Controls.Add(Me.PTitlebar)
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(173, 169)
        Me.Panel2.TabIndex = 10
        '
        'PBTime
        '
        Me.PBTime.BackColor = System.Drawing.Color.Red
        Me.PBTime.ForeColor = System.Drawing.SystemColors.Desktop
        Me.PBTime.Location = New System.Drawing.Point(8, 152)
        Me.PBTime.Name = "PBTime"
        Me.PBTime.Size = New System.Drawing.Size(158, 10)
        Me.PBTime.TabIndex = 1
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.lbConStatus)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.lTime)
        Me.Panel1.Location = New System.Drawing.Point(20, 35)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(136, 52)
        Me.Panel1.TabIndex = 3
        '
        'lbConStatus
        '
        Me.lbConStatus.AutoSize = True
        Me.lbConStatus.ForeColor = System.Drawing.Color.Red
        Me.lbConStatus.Location = New System.Drawing.Point(55, 31)
        Me.lbConStatus.Name = "lbConStatus"
        Me.lbConStatus.Size = New System.Drawing.Size(73, 13)
        Me.lbConStatus.TabIndex = 10
        Me.lbConStatus.Text = "Disconnected"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Status :"
        '
        'lTime
        '
        Me.lTime.AutoSize = True
        Me.lTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lTime.Location = New System.Drawing.Point(3, 0)
        Me.lTime.Name = "lTime"
        Me.lTime.Size = New System.Drawing.Size(128, 31)
        Me.lTime.TabIndex = 1
        Me.lTime.Text = "00:00:00"
        '
        'PTitlebar
        '
        Me.PTitlebar.BackColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(19, Byte), Integer))
        Me.PTitlebar.Controls.Add(Me.Label2)
        Me.PTitlebar.Dock = System.Windows.Forms.DockStyle.Top
        Me.PTitlebar.Location = New System.Drawing.Point(0, 0)
        Me.PTitlebar.Name = "PTitlebar"
        Me.PTitlebar.Size = New System.Drawing.Size(173, 29)
        Me.PTitlebar.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(147, -4)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(26, 36)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "-"
        '
        'MainControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(173, 169)
        Me.Controls.Add(Me.Panel2)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MainControl"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Time"
        Me.TopMost = True
        Me.cmsNotifyIcon.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.PTitlebar.ResumeLayout(False)
        Me.PTitlebar.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lTime As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lbConStatus As System.Windows.Forms.Label
    Friend WithEvents niSystemTray As System.Windows.Forms.NotifyIcon
    Friend WithEvents cmsNotifyIcon As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents PTitlebar As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PBTime As System.Windows.Forms.ProgressBar
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btnChat As System.Windows.Forms.Button
    Friend WithEvents btnSwap As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents TTEnable As System.Windows.Forms.ToolTip

End Class
