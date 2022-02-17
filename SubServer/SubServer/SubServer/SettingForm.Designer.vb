<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SettingForm
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SettingForm))
        Me.TBServerPort = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BChange = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TBNewpass = New System.Windows.Forms.TextBox()
        Me.cbAutoAdd = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbFontSize = New System.Windows.Forms.ComboBox()
        Me.TBOldpass = New System.Windows.Forms.TextBox()
        Me.cbWindowState = New System.Windows.Forms.CheckBox()
        Me.pSettingPanel = New System.Windows.Forms.Panel()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TBCPass = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dgvRate = New System.Windows.Forms.DataGridView()
        Me.dgvindex = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvpeso = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvseconds = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.pSettingPanel.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvRate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TBServerPort
        '
        Me.TBServerPort.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBServerPort.Location = New System.Drawing.Point(125, 13)
        Me.TBServerPort.MaxLength = 4
        Me.TBServerPort.Name = "TBServerPort"
        Me.TBServerPort.Size = New System.Drawing.Size(120, 26)
        Me.TBServerPort.TabIndex = 19
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(29, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 19)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Server Port : "
        '
        'BChange
        '
        Me.BChange.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BChange.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BChange.ForeColor = System.Drawing.Color.Black
        Me.BChange.Location = New System.Drawing.Point(186, 79)
        Me.BChange.Name = "BChange"
        Me.BChange.Size = New System.Drawing.Size(60, 24)
        Me.BChange.TabIndex = 18
        Me.BChange.Text = "Change"
        Me.BChange.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(10, 54)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(110, 19)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "New Password :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(41, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 19)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Font Size :"
        '
        'TBNewpass
        '
        Me.TBNewpass.BackColor = System.Drawing.Color.White
        Me.TBNewpass.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TBNewpass.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBNewpass.ForeColor = System.Drawing.Color.Black
        Me.TBNewpass.Location = New System.Drawing.Point(126, 54)
        Me.TBNewpass.MaxLength = 15
        Me.TBNewpass.Name = "TBNewpass"
        Me.TBNewpass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TBNewpass.Size = New System.Drawing.Size(120, 19)
        Me.TBNewpass.TabIndex = 14
        Me.TBNewpass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TBNewpass.UseSystemPasswordChar = True
        '
        'cbAutoAdd
        '
        Me.cbAutoAdd.AutoSize = True
        Me.cbAutoAdd.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbAutoAdd.ForeColor = System.Drawing.Color.Black
        Me.cbAutoAdd.Location = New System.Drawing.Point(13, 82)
        Me.cbAutoAdd.Name = "cbAutoAdd"
        Me.cbAutoAdd.Size = New System.Drawing.Size(127, 23)
        Me.cbAutoAdd.TabIndex = 17
        Me.cbAutoAdd.Text = "Auto Add Client"
        Me.cbAutoAdd.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(17, 32)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(103, 19)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Old Password :"
        '
        'cbFontSize
        '
        Me.cbFontSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbFontSize.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbFontSize.ForeColor = System.Drawing.Color.Black
        Me.cbFontSize.FormattingEnabled = True
        Me.cbFontSize.Items.AddRange(New Object() {"8", "9", "10", "11", "12", "14", "16", "18", "20"})
        Me.cbFontSize.Location = New System.Drawing.Point(125, 47)
        Me.cbFontSize.Name = "cbFontSize"
        Me.cbFontSize.Size = New System.Drawing.Size(121, 27)
        Me.cbFontSize.TabIndex = 17
        '
        'TBOldpass
        '
        Me.TBOldpass.BackColor = System.Drawing.Color.White
        Me.TBOldpass.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TBOldpass.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBOldpass.ForeColor = System.Drawing.Color.Black
        Me.TBOldpass.Location = New System.Drawing.Point(126, 32)
        Me.TBOldpass.MaxLength = 15
        Me.TBOldpass.Name = "TBOldpass"
        Me.TBOldpass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TBOldpass.Size = New System.Drawing.Size(120, 19)
        Me.TBOldpass.TabIndex = 12
        Me.TBOldpass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TBOldpass.UseSystemPasswordChar = True
        '
        'cbWindowState
        '
        Me.cbWindowState.AutoSize = True
        Me.cbWindowState.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbWindowState.ForeColor = System.Drawing.Color.Black
        Me.cbWindowState.Location = New System.Drawing.Point(13, 111)
        Me.cbWindowState.Name = "cbWindowState"
        Me.cbWindowState.Size = New System.Drawing.Size(96, 23)
        Me.cbWindowState.TabIndex = 7
        Me.cbWindowState.Text = "Full Screen"
        Me.cbWindowState.UseVisualStyleBackColor = True
        '
        'pSettingPanel
        '
        Me.pSettingPanel.BackColor = System.Drawing.Color.LightGray
        Me.pSettingPanel.Controls.Add(Me.GroupBox4)
        Me.pSettingPanel.Controls.Add(Me.GroupBox3)
        Me.pSettingPanel.Controls.Add(Me.GroupBox2)
        Me.pSettingPanel.Controls.Add(Me.GroupBox1)
        Me.pSettingPanel.Location = New System.Drawing.Point(24, 45)
        Me.pSettingPanel.Name = "pSettingPanel"
        Me.pSettingPanel.Size = New System.Drawing.Size(551, 305)
        Me.pSettingPanel.TabIndex = 13
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Button5)
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.Controls.Add(Me.TBCPass)
        Me.GroupBox4.Controls.Add(Me.Button3)
        Me.GroupBox4.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(283, 203)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(251, 79)
        Me.GroupBox4.TabIndex = 22
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Client"
        '
        'Button5
        '
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ForeColor = System.Drawing.Color.Black
        Me.Button5.Location = New System.Drawing.Point(176, 42)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(60, 24)
        Me.Button5.TabIndex = 19
        Me.Button5.Text = "Set"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(10, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 19)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Set Password :"
        '
        'TBCPass
        '
        Me.TBCPass.BackColor = System.Drawing.Color.White
        Me.TBCPass.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TBCPass.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBCPass.ForeColor = System.Drawing.Color.Black
        Me.TBCPass.Location = New System.Drawing.Point(116, 17)
        Me.TBCPass.MaxLength = 15
        Me.TBCPass.Name = "TBCPass"
        Me.TBCPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TBCPass.Size = New System.Drawing.Size(120, 19)
        Me.TBCPass.TabIndex = 12
        Me.TBCPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TBCPass.UseSystemPasswordChar = True
        '
        'Button3
        '
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.Black
        Me.Button3.Location = New System.Drawing.Point(186, 79)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(60, 24)
        Me.Button3.TabIndex = 18
        Me.Button3.Text = "Change"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.TBOldpass)
        Me.GroupBox3.Controls.Add(Me.BChange)
        Me.GroupBox3.Controls.Add(Me.TBNewpass)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(15, 166)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(262, 116)
        Me.GroupBox3.TabIndex = 21
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Security"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.TBServerPort)
        Me.GroupBox2.Controls.Add(Me.cbFontSize)
        Me.GroupBox2.Controls.Add(Me.cbAutoAdd)
        Me.GroupBox2.Controls.Add(Me.cbWindowState)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(15, 13)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(260, 147)
        Me.GroupBox2.TabIndex = 25
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Basic"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dgvRate)
        Me.GroupBox1.Controls.Add(Me.Button9)
        Me.GroupBox1.Controls.Add(Me.Button11)
        Me.GroupBox1.Controls.Add(Me.Button10)
        Me.GroupBox1.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(281, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(253, 184)
        Me.GroupBox1.TabIndex = 24
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Rate"
        '
        'dgvRate
        '
        Me.dgvRate.AllowUserToAddRows = False
        Me.dgvRate.AllowUserToDeleteRows = False
        Me.dgvRate.AllowUserToResizeRows = False
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        Me.dgvRate.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvRate.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvRate.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvRate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvRate.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dgvindex, Me.dgvpeso, Me.dgvseconds})
        Me.dgvRate.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke
        Me.dgvRate.Location = New System.Drawing.Point(16, 19)
        Me.dgvRate.MultiSelect = False
        Me.dgvRate.Name = "dgvRate"
        Me.dgvRate.ReadOnly = True
        Me.dgvRate.RowHeadersVisible = False
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black
        Me.dgvRate.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.dgvRate.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvRate.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvRate.Size = New System.Drawing.Size(222, 128)
        Me.dgvRate.TabIndex = 0
        '
        'dgvindex
        '
        DataGridViewCellStyle3.NullValue = Nothing
        Me.dgvindex.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvindex.HeaderText = "Index"
        Me.dgvindex.Name = "dgvindex"
        Me.dgvindex.ReadOnly = True
        Me.dgvindex.Visible = False
        '
        'dgvpeso
        '
        Me.dgvpeso.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle4.NullValue = "0"
        Me.dgvpeso.DefaultCellStyle = DataGridViewCellStyle4
        Me.dgvpeso.HeaderText = "Peso"
        Me.dgvpeso.Name = "dgvpeso"
        Me.dgvpeso.ReadOnly = True
        Me.dgvpeso.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'dgvseconds
        '
        Me.dgvseconds.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.dgvseconds.HeaderText = "Seconds"
        Me.dgvseconds.Name = "dgvseconds"
        Me.dgvseconds.ReadOnly = True
        Me.dgvseconds.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Button9
        '
        Me.Button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button9.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button9.ForeColor = System.Drawing.Color.Black
        Me.Button9.Location = New System.Drawing.Point(16, 153)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(60, 24)
        Me.Button9.TabIndex = 21
        Me.Button9.Text = "Add"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'Button11
        '
        Me.Button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button11.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button11.ForeColor = System.Drawing.Color.Black
        Me.Button11.Location = New System.Drawing.Point(178, 153)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(60, 24)
        Me.Button11.TabIndex = 23
        Me.Button11.Text = "Delete"
        Me.Button11.UseVisualStyleBackColor = True
        '
        'Button10
        '
        Me.Button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button10.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button10.ForeColor = System.Drawing.Color.Black
        Me.Button10.Location = New System.Drawing.Point(99, 153)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(60, 24)
        Me.Button10.TabIndex = 22
        Me.Button10.Text = "Edit"
        Me.Button10.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.ForeColor = System.Drawing.Color.Black
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(599, 30)
        Me.Panel1.TabIndex = 20
        '
        'Button1
        '
        Me.Button1.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Location = New System.Drawing.Point(500, 354)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 30)
        Me.Button1.TabIndex = 19
        Me.Button1.Text = "Close"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.Black
        Me.Button4.Location = New System.Drawing.Point(424, 354)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 30)
        Me.Button4.TabIndex = 18
        Me.Button4.Text = "Apply"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Black
        Me.Button2.Location = New System.Drawing.Point(24, 356)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(80, 30)
        Me.Button2.TabIndex = 19
        Me.Button2.Text = "Exit Program"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.ForeColor = System.Drawing.Color.Black
        Me.Button6.Location = New System.Drawing.Point(110, 356)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(97, 30)
        Me.Button6.TabIndex = 21
        Me.Button6.Text = "License Manager"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'SettingForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(599, 400)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.pSettingPanel)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "SettingForm"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Setting"
        Me.TopMost = True
        Me.pSettingPanel.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgvRate, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cbWindowState As System.Windows.Forms.CheckBox
    Friend WithEvents pSettingPanel As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TBNewpass As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TBOldpass As System.Windows.Forms.TextBox
    Friend WithEvents cbAutoAdd As System.Windows.Forms.CheckBox
    Friend WithEvents BChange As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cbFontSize As System.Windows.Forms.ComboBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button11 As System.Windows.Forms.Button
    Friend WithEvents Button10 As System.Windows.Forms.Button
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents dgvRate As System.Windows.Forms.DataGridView
    Friend WithEvents dgvindex As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvpeso As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvseconds As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TBServerPort As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TBCPass As System.Windows.Forms.TextBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
End Class
