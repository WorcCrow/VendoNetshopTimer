<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RateForm
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
        Me.TBTime = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.BAccept = New System.Windows.Forms.Button()
        Me.TBPrice = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.LMode = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'TBTime
        '
        Me.TBTime.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBTime.Location = New System.Drawing.Point(127, 107)
        Me.TBTime.Name = "TBTime"
        Me.TBTime.Size = New System.Drawing.Size(150, 26)
        Me.TBTime.TabIndex = 1
        '
        'Button2
        '
        Me.Button2.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(202, 151)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 30)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Cancel"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'BAccept
        '
        Me.BAccept.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BAccept.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BAccept.Location = New System.Drawing.Point(126, 151)
        Me.BAccept.Name = "BAccept"
        Me.BAccept.Size = New System.Drawing.Size(75, 30)
        Me.BAccept.TabIndex = 2
        Me.BAccept.Text = "Add"
        Me.BAccept.UseVisualStyleBackColor = True
        '
        'TBPrice
        '
        Me.TBPrice.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBPrice.Location = New System.Drawing.Point(127, 76)
        Me.TBPrice.Name = "TBPrice"
        Me.TBPrice.Size = New System.Drawing.Size(150, 26)
        Me.TBPrice.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(34, 107)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 19)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Time(sec) : "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(34, 77)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 19)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Price : "
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.SubServer.My.Resources.Resources.TopNavBar
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(312, 30)
        Me.Panel1.TabIndex = 14
        '
        'LMode
        '
        Me.LMode.AutoSize = True
        Me.LMode.BackColor = System.Drawing.Color.Transparent
        Me.LMode.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LMode.Location = New System.Drawing.Point(34, 45)
        Me.LMode.Name = "LMode"
        Me.LMode.Size = New System.Drawing.Size(73, 19)
        Me.LMode.TabIndex = 15
        Me.LMode.Text = "Add Rate"
        '
        'RateForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.SubServer.My.Resources.Resources.FormBack2
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(312, 207)
        Me.Controls.Add(Me.LMode)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TBTime)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.BAccept)
        Me.Controls.Add(Me.TBPrice)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "RateForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RateForm"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents TBTime As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents BAccept As System.Windows.Forms.Button
    Friend WithEvents TBPrice As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LMode As System.Windows.Forms.Label
End Class
