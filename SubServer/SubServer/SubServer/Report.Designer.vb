<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Report
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
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.rtbActivity = New System.Windows.Forms.RichTextBox()
        Me.pNavBar = New System.Windows.Forms.Panel()
        Me.CBReport = New System.Windows.Forms.ComboBox()
        Me.lTotalSales = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.BTNActivity = New System.Windows.Forms.Button()
        Me.Panel3.SuspendLayout()
        Me.pNavBar.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.DimGray
        Me.Panel3.Controls.Add(Me.rtbActivity)
        Me.Panel3.Controls.Add(Me.pNavBar)
        Me.Panel3.Location = New System.Drawing.Point(20, 56)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(595, 390)
        Me.Panel3.TabIndex = 2
        '
        'rtbActivity
        '
        Me.rtbActivity.BackColor = System.Drawing.Color.LightGray
        Me.rtbActivity.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.rtbActivity.Location = New System.Drawing.Point(0, 38)
        Me.rtbActivity.Name = "rtbActivity"
        Me.rtbActivity.ReadOnly = True
        Me.rtbActivity.Size = New System.Drawing.Size(595, 352)
        Me.rtbActivity.TabIndex = 1
        Me.rtbActivity.Text = ""
        '
        'pNavBar
        '
        Me.pNavBar.BackColor = System.Drawing.Color.DimGray
        Me.pNavBar.Controls.Add(Me.CBReport)
        Me.pNavBar.Controls.Add(Me.lTotalSales)
        Me.pNavBar.Controls.Add(Me.Label1)
        Me.pNavBar.Dock = System.Windows.Forms.DockStyle.Top
        Me.pNavBar.Location = New System.Drawing.Point(0, 0)
        Me.pNavBar.Name = "pNavBar"
        Me.pNavBar.Size = New System.Drawing.Size(595, 40)
        Me.pNavBar.TabIndex = 0
        '
        'CBReport
        '
        Me.CBReport.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBReport.FormattingEnabled = True
        Me.CBReport.Location = New System.Drawing.Point(462, 10)
        Me.CBReport.Name = "CBReport"
        Me.CBReport.Size = New System.Drawing.Size(121, 21)
        Me.CBReport.TabIndex = 2
        '
        'lTotalSales
        '
        Me.lTotalSales.AutoSize = True
        Me.lTotalSales.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lTotalSales.ForeColor = System.Drawing.Color.White
        Me.lTotalSales.Location = New System.Drawing.Point(105, 10)
        Me.lTotalSales.Name = "lTotalSales"
        Me.lTotalSales.Size = New System.Drawing.Size(17, 19)
        Me.lTotalSales.TabIndex = 1
        Me.lTotalSales.Text = "0"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(15, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Total Sales : "
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.SubServer.My.Resources.Resources.TopNavBar
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(638, 30)
        Me.Panel1.TabIndex = 27
        '
        'Button2
        '
        Me.Button2.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(540, 458)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 30)
        Me.Button2.TabIndex = 26
        Me.Button2.Text = "Close"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(23, 452)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 30)
        Me.Button1.TabIndex = 28
        Me.Button1.Text = "Sales"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'BTNActivity
        '
        Me.BTNActivity.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BTNActivity.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNActivity.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNActivity.Location = New System.Drawing.Point(99, 452)
        Me.BTNActivity.Name = "BTNActivity"
        Me.BTNActivity.Size = New System.Drawing.Size(75, 30)
        Me.BTNActivity.TabIndex = 29
        Me.BTNActivity.Text = "Activity"
        Me.BTNActivity.UseVisualStyleBackColor = True
        '
        'Report
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.SubServer.My.Resources.Resources.FormBack2
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(638, 500)
        Me.Controls.Add(Me.BTNActivity)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Panel3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Report"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Report"
        Me.TopMost = True
        Me.Panel3.ResumeLayout(False)
        Me.pNavBar.ResumeLayout(False)
        Me.pNavBar.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents pNavBar As System.Windows.Forms.Panel
    Friend WithEvents lTotalSales As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents rtbActivity As System.Windows.Forms.RichTextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents CBReport As System.Windows.Forms.ComboBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents BTNActivity As System.Windows.Forms.Button
End Class
