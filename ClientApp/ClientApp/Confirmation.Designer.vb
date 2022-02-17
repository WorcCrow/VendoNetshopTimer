<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Confirmation
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
        Me.PTitlebar = New System.Windows.Forms.Panel()
        Me.LRandom = New System.Windows.Forms.Label()
        Me.TBConfirmAnswer = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'PTitlebar
        '
        Me.PTitlebar.BackColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(19, Byte), Integer))
        Me.PTitlebar.Dock = System.Windows.Forms.DockStyle.Top
        Me.PTitlebar.Location = New System.Drawing.Point(0, 0)
        Me.PTitlebar.Name = "PTitlebar"
        Me.PTitlebar.Size = New System.Drawing.Size(237, 25)
        Me.PTitlebar.TabIndex = 6
        '
        'LRandom
        '
        Me.LRandom.AutoSize = True
        Me.LRandom.BackColor = System.Drawing.Color.Transparent
        Me.LRandom.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LRandom.ForeColor = System.Drawing.Color.White
        Me.LRandom.Location = New System.Drawing.Point(86, 86)
        Me.LRandom.Name = "LRandom"
        Me.LRandom.Size = New System.Drawing.Size(70, 22)
        Me.LRandom.TabIndex = 7
        Me.LRandom.Text = "000000"
        '
        'TBConfirmAnswer
        '
        Me.TBConfirmAnswer.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBConfirmAnswer.Location = New System.Drawing.Point(37, 31)
        Me.TBConfirmAnswer.MaxLength = 6
        Me.TBConfirmAnswer.Name = "TBConfirmAnswer"
        Me.TBConfirmAnswer.Size = New System.Drawing.Size(168, 35)
        Me.TBConfirmAnswer.TabIndex = 8
        Me.TBConfirmAnswer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(33, 108)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(178, 22)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Confirm to Continue"
        '
        'Confirmation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.ClientApp.My.Resources.Resources.GradientBlue2
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(237, 144)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TBConfirmAnswer)
        Me.Controls.Add(Me.LRandom)
        Me.Controls.Add(Me.PTitlebar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Confirmation"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Confirmation"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PTitlebar As System.Windows.Forms.Panel
    Friend WithEvents LRandom As System.Windows.Forms.Label
    Friend WithEvents TBConfirmAnswer As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
