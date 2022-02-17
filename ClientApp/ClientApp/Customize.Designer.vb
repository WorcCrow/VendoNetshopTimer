<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Customize
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Customize))
        Me.PTitlebar = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.PBackgroundImage = New System.Windows.Forms.Panel()
        Me.CBMute = New System.Windows.Forms.CheckBox()
        Me.LBBackgroundList = New System.Windows.Forms.ListBox()
        Me.BBrowse = New System.Windows.Forms.Button()
        Me.CBRandom = New System.Windows.Forms.CheckBox()
        Me.lOpacity = New System.Windows.Forms.Label()
        Me.TBOpacityLevel = New System.Windows.Forms.TrackBar()
        Me.CBTransparency = New System.Windows.Forms.CheckBox()
        Me.RBVideo = New System.Windows.Forms.RadioButton()
        Me.BTNViewChanges = New System.Windows.Forms.Button()
        Me.RBImage = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.BTNChangePass = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.MTBNPass = New System.Windows.Forms.MaskedTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.MTBOPass = New System.Windows.Forms.MaskedTextBox()
        Me.TBServer = New System.Windows.Forms.TextBox()
        Me.TBPort = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BTNSave = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.NUDOffTime = New System.Windows.Forms.NumericUpDown()
        Me.PTitlebar.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.PBackgroundImage.SuspendLayout()
        CType(Me.TBOpacityLevel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.NUDOffTime, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PTitlebar
        '
        Me.PTitlebar.BackColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(19, Byte), Integer))
        Me.PTitlebar.Controls.Add(Me.Label5)
        Me.PTitlebar.Controls.Add(Me.Label7)
        Me.PTitlebar.Dock = System.Windows.Forms.DockStyle.Top
        Me.PTitlebar.Location = New System.Drawing.Point(0, 0)
        Me.PTitlebar.Name = "PTitlebar"
        Me.PTitlebar.Size = New System.Drawing.Size(539, 25)
        Me.PTitlebar.TabIndex = 14
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label5.Font = New System.Drawing.Font("Century", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(482, 1)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(19, 25)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "-"
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label7.Font = New System.Drawing.Font("Century", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(513, -2)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(23, 25)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "x"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.PBackgroundImage)
        Me.GroupBox1.Controls.Add(Me.CBTransparency)
        Me.GroupBox1.Controls.Add(Me.RBVideo)
        Me.GroupBox1.Controls.Add(Me.BTNViewChanges)
        Me.GroupBox1.Controls.Add(Me.RBImage)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.GroupBox1.Location = New System.Drawing.Point(22, 212)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(508, 160)
        Me.GroupBox1.TabIndex = 16
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Customize"
        '
        'PBackgroundImage
        '
        Me.PBackgroundImage.Controls.Add(Me.CBMute)
        Me.PBackgroundImage.Controls.Add(Me.LBBackgroundList)
        Me.PBackgroundImage.Controls.Add(Me.BBrowse)
        Me.PBackgroundImage.Controls.Add(Me.CBRandom)
        Me.PBackgroundImage.Controls.Add(Me.lOpacity)
        Me.PBackgroundImage.Controls.Add(Me.TBOpacityLevel)
        Me.PBackgroundImage.ForeColor = System.Drawing.Color.Orange
        Me.PBackgroundImage.Location = New System.Drawing.Point(128, 11)
        Me.PBackgroundImage.Name = "PBackgroundImage"
        Me.PBackgroundImage.Size = New System.Drawing.Size(374, 142)
        Me.PBackgroundImage.TabIndex = 9
        '
        'CBMute
        '
        Me.CBMute.AutoSize = True
        Me.CBMute.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.CBMute.Location = New System.Drawing.Point(10, 54)
        Me.CBMute.Name = "CBMute"
        Me.CBMute.Size = New System.Drawing.Size(54, 17)
        Me.CBMute.TabIndex = 8
        Me.CBMute.Text = "Mute"
        Me.CBMute.UseVisualStyleBackColor = True
        '
        'LBBackgroundList
        '
        Me.LBBackgroundList.BackColor = System.Drawing.Color.LightSteelBlue
        Me.LBBackgroundList.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBBackgroundList.FormattingEnabled = True
        Me.LBBackgroundList.Location = New System.Drawing.Point(129, 3)
        Me.LBBackgroundList.Name = "LBBackgroundList"
        Me.LBBackgroundList.Size = New System.Drawing.Size(247, 134)
        Me.LBBackgroundList.TabIndex = 7
        '
        'BBrowse
        '
        Me.BBrowse.BackgroundImage = CType(resources.GetObject("BBrowse.BackgroundImage"), System.Drawing.Image)
        Me.BBrowse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BBrowse.FlatAppearance.BorderSize = 0
        Me.BBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BBrowse.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BBrowse.Location = New System.Drawing.Point(10, 8)
        Me.BBrowse.Name = "BBrowse"
        Me.BBrowse.Size = New System.Drawing.Size(113, 23)
        Me.BBrowse.TabIndex = 2
        Me.BBrowse.Text = "Browse Images"
        Me.BBrowse.UseVisualStyleBackColor = True
        '
        'CBRandom
        '
        Me.CBRandom.AutoSize = True
        Me.CBRandom.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.CBRandom.Location = New System.Drawing.Point(10, 32)
        Me.CBRandom.Name = "CBRandom"
        Me.CBRandom.Size = New System.Drawing.Size(72, 17)
        Me.CBRandom.TabIndex = 6
        Me.CBRandom.Text = "Random"
        Me.CBRandom.UseVisualStyleBackColor = True
        '
        'lOpacity
        '
        Me.lOpacity.AutoSize = True
        Me.lOpacity.Location = New System.Drawing.Point(50, 98)
        Me.lOpacity.Name = "lOpacity"
        Me.lOpacity.Size = New System.Drawing.Size(14, 13)
        Me.lOpacity.TabIndex = 5
        Me.lOpacity.Text = "0"
        Me.lOpacity.Visible = False
        '
        'TBOpacityLevel
        '
        Me.TBOpacityLevel.BackColor = System.Drawing.Color.MediumBlue
        Me.TBOpacityLevel.Location = New System.Drawing.Point(10, 78)
        Me.TBOpacityLevel.Maximum = 100
        Me.TBOpacityLevel.Name = "TBOpacityLevel"
        Me.TBOpacityLevel.Size = New System.Drawing.Size(104, 45)
        Me.TBOpacityLevel.TabIndex = 4
        Me.TBOpacityLevel.TickStyle = System.Windows.Forms.TickStyle.None
        Me.TBOpacityLevel.Visible = False
        '
        'CBTransparency
        '
        Me.CBTransparency.AutoSize = True
        Me.CBTransparency.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.CBTransparency.Location = New System.Drawing.Point(19, 89)
        Me.CBTransparency.Name = "CBTransparency"
        Me.CBTransparency.Size = New System.Drawing.Size(103, 17)
        Me.CBTransparency.TabIndex = 4
        Me.CBTransparency.Text = "Transparency"
        Me.CBTransparency.UseVisualStyleBackColor = True
        '
        'RBVideo
        '
        Me.RBVideo.AutoSize = True
        Me.RBVideo.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.RBVideo.Location = New System.Drawing.Point(19, 42)
        Me.RBVideo.Name = "RBVideo"
        Me.RBVideo.Size = New System.Drawing.Size(57, 17)
        Me.RBVideo.TabIndex = 8
        Me.RBVideo.TabStop = True
        Me.RBVideo.Text = "Video"
        Me.RBVideo.UseVisualStyleBackColor = True
        '
        'BTNViewChanges
        '
        Me.BTNViewChanges.BackgroundImage = Global.ClientApp.My.Resources.Resources.ButtonBack
        Me.BTNViewChanges.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTNViewChanges.FlatAppearance.BorderSize = 0
        Me.BTNViewChanges.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNViewChanges.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNViewChanges.ForeColor = System.Drawing.Color.Orange
        Me.BTNViewChanges.Location = New System.Drawing.Point(19, 126)
        Me.BTNViewChanges.Name = "BTNViewChanges"
        Me.BTNViewChanges.Size = New System.Drawing.Size(91, 27)
        Me.BTNViewChanges.TabIndex = 10
        Me.BTNViewChanges.Text = "View"
        Me.BTNViewChanges.UseVisualStyleBackColor = True
        '
        'RBImage
        '
        Me.RBImage.AutoSize = True
        Me.RBImage.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.RBImage.Location = New System.Drawing.Point(19, 19)
        Me.RBImage.Name = "RBImage"
        Me.RBImage.Size = New System.Drawing.Size(59, 17)
        Me.RBImage.TabIndex = 7
        Me.RBImage.TabStop = True
        Me.RBImage.Text = "Image"
        Me.RBImage.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.BTNChangePass)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.MTBNPass)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.MTBOPass)
        Me.GroupBox2.Controls.Add(Me.TBServer)
        Me.GroupBox2.Controls.Add(Me.TBPort)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.GroupBox2.Location = New System.Drawing.Point(22, 44)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(226, 162)
        Me.GroupBox2.TabIndex = 17
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Settings"
        '
        'BTNChangePass
        '
        Me.BTNChangePass.BackgroundImage = CType(resources.GetObject("BTNChangePass.BackgroundImage"), System.Drawing.Image)
        Me.BTNChangePass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTNChangePass.FlatAppearance.BorderSize = 0
        Me.BTNChangePass.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNChangePass.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNChangePass.ForeColor = System.Drawing.Color.Orange
        Me.BTNChangePass.Location = New System.Drawing.Point(138, 133)
        Me.BTNChangePass.Name = "BTNChangePass"
        Me.BTNChangePass.Size = New System.Drawing.Size(75, 23)
        Me.BTNChangePass.TabIndex = 19
        Me.BTNChangePass.Text = "Change"
        Me.BTNChangePass.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label4.Location = New System.Drawing.Point(10, 112)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(102, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "New Password : "
        '
        'MTBNPass
        '
        Me.MTBNPass.BackColor = System.Drawing.Color.LightSteelBlue
        Me.MTBNPass.Location = New System.Drawing.Point(113, 109)
        Me.MTBNPass.Name = "MTBNPass"
        Me.MTBNPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.MTBNPass.Size = New System.Drawing.Size(100, 20)
        Me.MTBNPass.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label3.Location = New System.Drawing.Point(16, 86)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Old Password : "
        '
        'MTBOPass
        '
        Me.MTBOPass.BackColor = System.Drawing.Color.LightSteelBlue
        Me.MTBOPass.Location = New System.Drawing.Point(113, 83)
        Me.MTBOPass.Name = "MTBOPass"
        Me.MTBOPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.MTBOPass.Size = New System.Drawing.Size(100, 20)
        Me.MTBOPass.TabIndex = 4
        '
        'TBServer
        '
        Me.TBServer.BackColor = System.Drawing.Color.LightSteelBlue
        Me.TBServer.Location = New System.Drawing.Point(113, 19)
        Me.TBServer.Name = "TBServer"
        Me.TBServer.Size = New System.Drawing.Size(100, 20)
        Me.TBServer.TabIndex = 3
        '
        'TBPort
        '
        Me.TBPort.BackColor = System.Drawing.Color.LightSteelBlue
        Me.TBPort.Location = New System.Drawing.Point(113, 45)
        Me.TBPort.Name = "TBPort"
        Me.TBPort.Size = New System.Drawing.Size(100, 20)
        Me.TBPort.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label2.Location = New System.Drawing.Point(68, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Port : "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label1.Location = New System.Drawing.Point(56, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Server : "
        '
        'BTNSave
        '
        Me.BTNSave.BackgroundImage = Global.ClientApp.My.Resources.Resources.ButtonBack
        Me.BTNSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTNSave.FlatAppearance.BorderSize = 0
        Me.BTNSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNSave.ForeColor = System.Drawing.Color.Orange
        Me.BTNSave.Location = New System.Drawing.Point(452, 378)
        Me.BTNSave.Name = "BTNSave"
        Me.BTNSave.Size = New System.Drawing.Size(75, 23)
        Me.BTNSave.TabIndex = 18
        Me.BTNSave.Text = "Save"
        Me.BTNSave.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.NUDOffTime)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.GroupBox3.Location = New System.Drawing.Point(254, 44)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(273, 162)
        Me.GroupBox3.TabIndex = 20
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Settings"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label9.Location = New System.Drawing.Point(9, 22)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(139, 13)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "Turn off computer (min)"
        '
        'NUDOffTime
        '
        Me.NUDOffTime.Location = New System.Drawing.Point(154, 20)
        Me.NUDOffTime.Maximum = New Decimal(New Integer() {60, 0, 0, 0})
        Me.NUDOffTime.Name = "NUDOffTime"
        Me.NUDOffTime.Size = New System.Drawing.Size(56, 20)
        Me.NUDOffTime.TabIndex = 2
        Me.NUDOffTime.Tag = ""
        '
        'Customize
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.ClientApp.My.Resources.Resources.GradientBlue2
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(539, 407)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.BTNSave)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.PTitlebar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Customize"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Customize LockScreen"
        Me.TopMost = True
        Me.PTitlebar.ResumeLayout(False)
        Me.PTitlebar.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.PBackgroundImage.ResumeLayout(False)
        Me.PBackgroundImage.PerformLayout()
        CType(Me.TBOpacityLevel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.NUDOffTime, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PTitlebar As System.Windows.Forms.Panel
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents PBackgroundImage As System.Windows.Forms.Panel
    Friend WithEvents CBMute As System.Windows.Forms.CheckBox
    Friend WithEvents LBBackgroundList As System.Windows.Forms.ListBox
    Friend WithEvents BBrowse As System.Windows.Forms.Button
    Friend WithEvents CBRandom As System.Windows.Forms.CheckBox
    Friend WithEvents TBOpacityLevel As System.Windows.Forms.TrackBar
    Friend WithEvents lOpacity As System.Windows.Forms.Label
    Friend WithEvents CBTransparency As System.Windows.Forms.CheckBox
    Friend WithEvents RBVideo As System.Windows.Forms.RadioButton
    Friend WithEvents BTNViewChanges As System.Windows.Forms.Button
    Friend WithEvents RBImage As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents MTBNPass As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents MTBOPass As System.Windows.Forms.MaskedTextBox
    Friend WithEvents TBServer As System.Windows.Forms.TextBox
    Friend WithEvents TBPort As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BTNSave As System.Windows.Forms.Button
    Friend WithEvents BTNChangePass As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents NUDOffTime As System.Windows.Forms.NumericUpDown
End Class
