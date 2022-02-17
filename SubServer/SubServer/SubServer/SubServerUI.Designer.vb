<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SubServerUI
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SubServerUI))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.pNavbar = New System.Windows.Forms.Panel()
        Me.lbCredit = New System.Windows.Forms.Label()
        Me.btnRight2 = New System.Windows.Forms.Button()
        Me.btnRight1 = New System.Windows.Forms.Button()
        Me.btnRight3 = New System.Windows.Forms.Button()
        Me.btnRight4 = New System.Windows.Forms.Button()
        Me.btnLeft1 = New System.Windows.Forms.Button()
        Me.btnLeft2 = New System.Windows.Forms.Button()
        Me.btnLeft3 = New System.Windows.Forms.Button()
        Me.btnLeft4 = New System.Windows.Forms.Button()
        Me.dgvClient = New System.Windows.Forms.DataGridView()
        Me.CMSAdmin = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.MoveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ssStatus = New System.Windows.Forms.StatusStrip()
        Me.TSSLExpiryNotification = New System.Windows.Forms.ToolStripStatusLabel()
        Me.TSSLCoinslot = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.TSSLConnectionRequest = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel5 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.TSSLAuthLevel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel3 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.PBLogin = New System.Windows.Forms.PictureBox()
        Me.dgvindex = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvip = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvtimeLeft = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvstarted = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvcount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvstatus = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pNavbar.SuspendLayout()
        CType(Me.dgvClient, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CMSAdmin.SuspendLayout()
        Me.ssStatus.SuspendLayout()
        CType(Me.PBLogin, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pNavbar
        '
        Me.pNavbar.BackColor = System.Drawing.Color.Transparent
        Me.pNavbar.BackgroundImage = CType(resources.GetObject("pNavbar.BackgroundImage"), System.Drawing.Image)
        Me.pNavbar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pNavbar.Controls.Add(Me.lbCredit)
        Me.pNavbar.Dock = System.Windows.Forms.DockStyle.Top
        Me.pNavbar.Location = New System.Drawing.Point(0, 0)
        Me.pNavbar.Name = "pNavbar"
        Me.pNavbar.Size = New System.Drawing.Size(800, 100)
        Me.pNavbar.TabIndex = 0
        '
        'lbCredit
        '
        Me.lbCredit.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbCredit.AutoSize = True
        Me.lbCredit.Font = New System.Drawing.Font("Mistral", 48.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbCredit.Location = New System.Drawing.Point(364, 9)
        Me.lbCredit.Name = "lbCredit"
        Me.lbCredit.Size = New System.Drawing.Size(63, 76)
        Me.lbCredit.TabIndex = 0
        Me.lbCredit.Text = "0"
        '
        'btnRight2
        '
        Me.btnRight2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRight2.BackColor = System.Drawing.Color.Transparent
        Me.btnRight2.BackgroundImage = CType(resources.GetObject("btnRight2.BackgroundImage"), System.Drawing.Image)
        Me.btnRight2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnRight2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRight2.FlatAppearance.BorderSize = 0
        Me.btnRight2.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.btnRight2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnRight2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnRight2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRight2.Location = New System.Drawing.Point(706, 228)
        Me.btnRight2.Margin = New System.Windows.Forms.Padding(0)
        Me.btnRight2.Name = "btnRight2"
        Me.btnRight2.Size = New System.Drawing.Size(94, 95)
        Me.btnRight2.TabIndex = 2
        Me.btnRight2.UseVisualStyleBackColor = False
        '
        'btnRight1
        '
        Me.btnRight1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRight1.BackColor = System.Drawing.Color.Transparent
        Me.btnRight1.BackgroundImage = CType(resources.GetObject("btnRight1.BackgroundImage"), System.Drawing.Image)
        Me.btnRight1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnRight1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRight1.FlatAppearance.BorderSize = 0
        Me.btnRight1.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.btnRight1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnRight1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnRight1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRight1.Location = New System.Drawing.Point(706, 130)
        Me.btnRight1.Margin = New System.Windows.Forms.Padding(0)
        Me.btnRight1.Name = "btnRight1"
        Me.btnRight1.Size = New System.Drawing.Size(94, 95)
        Me.btnRight1.TabIndex = 3
        Me.btnRight1.UseVisualStyleBackColor = False
        '
        'btnRight3
        '
        Me.btnRight3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRight3.BackColor = System.Drawing.Color.Transparent
        Me.btnRight3.BackgroundImage = CType(resources.GetObject("btnRight3.BackgroundImage"), System.Drawing.Image)
        Me.btnRight3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnRight3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRight3.FlatAppearance.BorderSize = 0
        Me.btnRight3.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.btnRight3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnRight3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnRight3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRight3.Location = New System.Drawing.Point(706, 326)
        Me.btnRight3.Margin = New System.Windows.Forms.Padding(0)
        Me.btnRight3.Name = "btnRight3"
        Me.btnRight3.Size = New System.Drawing.Size(94, 95)
        Me.btnRight3.TabIndex = 4
        Me.btnRight3.UseVisualStyleBackColor = False
        '
        'btnRight4
        '
        Me.btnRight4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRight4.BackColor = System.Drawing.Color.Transparent
        Me.btnRight4.BackgroundImage = CType(resources.GetObject("btnRight4.BackgroundImage"), System.Drawing.Image)
        Me.btnRight4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnRight4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRight4.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.btnRight4.FlatAppearance.BorderSize = 0
        Me.btnRight4.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.btnRight4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnRight4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnRight4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRight4.Location = New System.Drawing.Point(706, 428)
        Me.btnRight4.Margin = New System.Windows.Forms.Padding(0)
        Me.btnRight4.Name = "btnRight4"
        Me.btnRight4.Size = New System.Drawing.Size(94, 95)
        Me.btnRight4.TabIndex = 0
        Me.btnRight4.TabStop = False
        Me.btnRight4.UseVisualStyleBackColor = False
        '
        'btnLeft1
        '
        Me.btnLeft1.BackColor = System.Drawing.Color.Transparent
        Me.btnLeft1.BackgroundImage = CType(resources.GetObject("btnLeft1.BackgroundImage"), System.Drawing.Image)
        Me.btnLeft1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnLeft1.FlatAppearance.BorderSize = 0
        Me.btnLeft1.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.btnLeft1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnLeft1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnLeft1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLeft1.Location = New System.Drawing.Point(0, 130)
        Me.btnLeft1.Margin = New System.Windows.Forms.Padding(0)
        Me.btnLeft1.Name = "btnLeft1"
        Me.btnLeft1.Size = New System.Drawing.Size(94, 95)
        Me.btnLeft1.TabIndex = 6
        Me.btnLeft1.UseVisualStyleBackColor = False
        '
        'btnLeft2
        '
        Me.btnLeft2.BackColor = System.Drawing.Color.Transparent
        Me.btnLeft2.BackgroundImage = CType(resources.GetObject("btnLeft2.BackgroundImage"), System.Drawing.Image)
        Me.btnLeft2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnLeft2.FlatAppearance.BorderSize = 0
        Me.btnLeft2.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.btnLeft2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnLeft2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnLeft2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLeft2.Location = New System.Drawing.Point(0, 228)
        Me.btnLeft2.Margin = New System.Windows.Forms.Padding(0)
        Me.btnLeft2.Name = "btnLeft2"
        Me.btnLeft2.Size = New System.Drawing.Size(94, 95)
        Me.btnLeft2.TabIndex = 7
        Me.btnLeft2.UseVisualStyleBackColor = False
        '
        'btnLeft3
        '
        Me.btnLeft3.BackColor = System.Drawing.Color.Transparent
        Me.btnLeft3.BackgroundImage = CType(resources.GetObject("btnLeft3.BackgroundImage"), System.Drawing.Image)
        Me.btnLeft3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnLeft3.FlatAppearance.BorderSize = 0
        Me.btnLeft3.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.btnLeft3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnLeft3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnLeft3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLeft3.Location = New System.Drawing.Point(0, 326)
        Me.btnLeft3.Margin = New System.Windows.Forms.Padding(0)
        Me.btnLeft3.Name = "btnLeft3"
        Me.btnLeft3.Size = New System.Drawing.Size(94, 95)
        Me.btnLeft3.TabIndex = 8
        Me.btnLeft3.UseVisualStyleBackColor = False
        '
        'btnLeft4
        '
        Me.btnLeft4.BackColor = System.Drawing.Color.Transparent
        Me.btnLeft4.BackgroundImage = CType(resources.GetObject("btnLeft4.BackgroundImage"), System.Drawing.Image)
        Me.btnLeft4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnLeft4.FlatAppearance.BorderSize = 0
        Me.btnLeft4.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.btnLeft4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnLeft4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnLeft4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLeft4.Location = New System.Drawing.Point(0, 428)
        Me.btnLeft4.Margin = New System.Windows.Forms.Padding(0)
        Me.btnLeft4.Name = "btnLeft4"
        Me.btnLeft4.Size = New System.Drawing.Size(94, 95)
        Me.btnLeft4.TabIndex = 9
        Me.btnLeft4.UseVisualStyleBackColor = False
        '
        'dgvClient
        '
        Me.dgvClient.AllowUserToAddRows = False
        Me.dgvClient.AllowUserToDeleteRows = False
        Me.dgvClient.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Padding = New System.Windows.Forms.Padding(0, 4, 0, 4)
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightGray
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        Me.dgvClient.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvClient.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvClient.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvClient.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvClient.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.dgvClient.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvClient.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Padding = New System.Windows.Forms.Padding(0, 4, 0, 4)
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightGray
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvClient.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvClient.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dgvindex, Me.dgvname, Me.dgvip, Me.dgvtimeLeft, Me.dgvstarted, Me.dgvcount, Me.dgvstatus})
        Me.dgvClient.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dgvClient.DataMember = "12"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Padding = New System.Windows.Forms.Padding(0, 4, 0, 4)
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightGray
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvClient.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvClient.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvClient.GridColor = System.Drawing.SystemColors.Control
        Me.dgvClient.Location = New System.Drawing.Point(148, 130)
        Me.dgvClient.MultiSelect = False
        Me.dgvClient.Name = "dgvClient"
        Me.dgvClient.ReadOnly = True
        Me.dgvClient.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvClient.RowHeadersVisible = False
        Me.dgvClient.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvClient.Size = New System.Drawing.Size(502, 393)
        Me.dgvClient.TabIndex = 10
        '
        'CMSAdmin
        '
        Me.CMSAdmin.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MoveToolStripMenuItem, Me.EditToolStripMenuItem, Me.DeleteToolStripMenuItem, Me.LogoutToolStripMenuItem})
        Me.CMSAdmin.Name = "CMSAdmin"
        Me.CMSAdmin.Size = New System.Drawing.Size(113, 92)
        '
        'MoveToolStripMenuItem
        '
        Me.MoveToolStripMenuItem.Name = "MoveToolStripMenuItem"
        Me.MoveToolStripMenuItem.Size = New System.Drawing.Size(112, 22)
        Me.MoveToolStripMenuItem.Text = "Move"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(112, 22)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'DeleteToolStripMenuItem
        '
        Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        Me.DeleteToolStripMenuItem.Size = New System.Drawing.Size(112, 22)
        Me.DeleteToolStripMenuItem.Text = "Delete"
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(112, 22)
        Me.LogoutToolStripMenuItem.Text = "Logout"
        '
        'ssStatus
        '
        Me.ssStatus.BackColor = System.Drawing.Color.Transparent
        Me.ssStatus.BackgroundImage = Global.SubServer.My.Resources.Resources.StatusBar
        Me.ssStatus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ssStatus.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TSSLExpiryNotification, Me.TSSLCoinslot, Me.ToolStripStatusLabel1, Me.TSSLConnectionRequest, Me.ToolStripStatusLabel5, Me.TSSLAuthLevel, Me.ToolStripStatusLabel2})
        Me.ssStatus.Location = New System.Drawing.Point(0, 758)
        Me.ssStatus.Name = "ssStatus"
        Me.ssStatus.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ssStatus.Size = New System.Drawing.Size(800, 22)
        Me.ssStatus.TabIndex = 13
        '
        'TSSLExpiryNotification
        '
        Me.TSSLExpiryNotification.Font = New System.Drawing.Font("Tempus Sans ITC", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TSSLExpiryNotification.Name = "TSSLExpiryNotification"
        Me.TSSLExpiryNotification.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TSSLExpiryNotification.Size = New System.Drawing.Size(13, 17)
        Me.TSSLExpiryNotification.Text = "-"
        '
        'TSSLCoinslot
        '
        Me.TSSLCoinslot.Font = New System.Drawing.Font("Tempus Sans ITC", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TSSLCoinslot.Name = "TSSLCoinslot"
        Me.TSSLCoinslot.Size = New System.Drawing.Size(13, 17)
        Me.TSSLCoinslot.Text = "-"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Font = New System.Drawing.Font("Tempus Sans ITC", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(71, 17)
        Me.ToolStripStatusLabel1.Text = "Coin Slot : "
        '
        'TSSLConnectionRequest
        '
        Me.TSSLConnectionRequest.Font = New System.Drawing.Font("Tempus Sans ITC", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TSSLConnectionRequest.Name = "TSSLConnectionRequest"
        Me.TSSLConnectionRequest.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TSSLConnectionRequest.Size = New System.Drawing.Size(13, 17)
        Me.TSSLConnectionRequest.Text = "-"
        '
        'ToolStripStatusLabel5
        '
        Me.ToolStripStatusLabel5.Font = New System.Drawing.Font("Tempus Sans ITC", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripStatusLabel5.Name = "ToolStripStatusLabel5"
        Me.ToolStripStatusLabel5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ToolStripStatusLabel5.Size = New System.Drawing.Size(119, 17)
        Me.ToolStripStatusLabel5.Text = "Connection Request"
        '
        'TSSLAuthLevel
        '
        Me.TSSLAuthLevel.Font = New System.Drawing.Font("Tempus Sans ITC", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TSSLAuthLevel.ForeColor = System.Drawing.Color.Red
        Me.TSSLAuthLevel.Name = "TSSLAuthLevel"
        Me.TSSLAuthLevel.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TSSLAuthLevel.Size = New System.Drawing.Size(58, 17)
        Me.TSSLAuthLevel.Text = "Operator"
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.Font = New System.Drawing.Font("Tempus Sans ITC", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(130, 17)
        Me.ToolStripStatusLabel2.Text = "Authorization Level : "
        '
        'ToolStripStatusLabel3
        '
        Me.ToolStripStatusLabel3.Font = New System.Drawing.Font("Tempus Sans ITC", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripStatusLabel3.Name = "ToolStripStatusLabel3"
        Me.ToolStripStatusLabel3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ToolStripStatusLabel3.Size = New System.Drawing.Size(46, 17)
        Me.ToolStripStatusLabel3.Text = "Mode :"
        '
        'PBLogin
        '
        Me.PBLogin.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PBLogin.BackColor = System.Drawing.Color.Transparent
        Me.PBLogin.Image = Global.SubServer.My.Resources.Resources.LoginBlack
        Me.PBLogin.Location = New System.Drawing.Point(0, 708)
        Me.PBLogin.Name = "PBLogin"
        Me.PBLogin.Size = New System.Drawing.Size(52, 50)
        Me.PBLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PBLogin.TabIndex = 14
        Me.PBLogin.TabStop = False
        '
        'dgvindex
        '
        Me.dgvindex.HeaderText = "Index"
        Me.dgvindex.Name = "dgvindex"
        Me.dgvindex.ReadOnly = True
        Me.dgvindex.Visible = False
        '
        'dgvname
        '
        Me.dgvname.HeaderText = "Name"
        Me.dgvname.Name = "dgvname"
        Me.dgvname.ReadOnly = True
        '
        'dgvip
        '
        Me.dgvip.HeaderText = "IP"
        Me.dgvip.Name = "dgvip"
        Me.dgvip.ReadOnly = True
        '
        'dgvtimeLeft
        '
        Me.dgvtimeLeft.HeaderText = "Time Left"
        Me.dgvtimeLeft.Name = "dgvtimeLeft"
        Me.dgvtimeLeft.ReadOnly = True
        '
        'dgvstarted
        '
        Me.dgvstarted.HeaderText = "Started"
        Me.dgvstarted.Name = "dgvstarted"
        Me.dgvstarted.ReadOnly = True
        '
        'dgvcount
        '
        Me.dgvcount.HeaderText = "Counter"
        Me.dgvcount.Name = "dgvcount"
        Me.dgvcount.ReadOnly = True
        Me.dgvcount.Visible = False
        '
        'dgvstatus
        '
        Me.dgvstatus.HeaderText = "Status"
        Me.dgvstatus.Name = "dgvstatus"
        Me.dgvstatus.ReadOnly = True
        '
        'SubServerUI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 780)
        Me.ControlBox = False
        Me.Controls.Add(Me.PBLogin)
        Me.Controls.Add(Me.ssStatus)
        Me.Controls.Add(Me.dgvClient)
        Me.Controls.Add(Me.btnLeft4)
        Me.Controls.Add(Me.btnLeft3)
        Me.Controls.Add(Me.btnLeft2)
        Me.Controls.Add(Me.btnLeft1)
        Me.Controls.Add(Me.btnRight4)
        Me.Controls.Add(Me.btnRight3)
        Me.Controls.Add(Me.btnRight1)
        Me.Controls.Add(Me.btnRight2)
        Me.Controls.Add(Me.pNavbar)
        Me.DoubleBuffered = True
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "SubServerUI"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sub Server"
        Me.pNavbar.ResumeLayout(False)
        Me.pNavbar.PerformLayout()
        CType(Me.dgvClient, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CMSAdmin.ResumeLayout(False)
        Me.ssStatus.ResumeLayout(False)
        Me.ssStatus.PerformLayout()
        CType(Me.PBLogin, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pNavbar As System.Windows.Forms.Panel
    Friend WithEvents lbCredit As System.Windows.Forms.Label
    Friend WithEvents btnRight2 As System.Windows.Forms.Button
    Friend WithEvents btnRight1 As System.Windows.Forms.Button
    Friend WithEvents btnRight3 As System.Windows.Forms.Button
    Friend WithEvents btnRight4 As System.Windows.Forms.Button
    Friend WithEvents btnLeft1 As System.Windows.Forms.Button
    Friend WithEvents btnLeft2 As System.Windows.Forms.Button
    Friend WithEvents btnLeft3 As System.Windows.Forms.Button
    Friend WithEvents btnLeft4 As System.Windows.Forms.Button
    Friend WithEvents dgvClient As System.Windows.Forms.DataGridView
    Friend WithEvents ssStatus As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents TSSLCoinslot As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents TSSLExpiryNotification As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents TSSLAuthLevel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel3 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents CMSAdmin As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents MoveToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TSSLConnectionRequest As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel5 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents PBLogin As System.Windows.Forms.PictureBox
    Friend WithEvents ToolStripStatusLabel2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents dgvindex As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvname As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvip As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvtimeLeft As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvstarted As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvcount As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvstatus As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
