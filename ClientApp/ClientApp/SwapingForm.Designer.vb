<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SwapingForm
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
        Me.FLPItemList = New System.Windows.Forms.FlowLayoutPanel()
        Me.PTitlebar = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PTitlebar.SuspendLayout()
        Me.SuspendLayout()
        '
        'FLPItemList
        '
        Me.FLPItemList.AutoScroll = True
        Me.FLPItemList.BackColor = System.Drawing.Color.Transparent
        Me.FLPItemList.Location = New System.Drawing.Point(12, 31)
        Me.FLPItemList.Name = "FLPItemList"
        Me.FLPItemList.Size = New System.Drawing.Size(297, 331)
        Me.FLPItemList.TabIndex = 0
        '
        'PTitlebar
        '
        Me.PTitlebar.BackColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(19, Byte), Integer))
        Me.PTitlebar.Controls.Add(Me.Label1)
        Me.PTitlebar.Dock = System.Windows.Forms.DockStyle.Top
        Me.PTitlebar.Location = New System.Drawing.Point(0, 0)
        Me.PTitlebar.Name = "PTitlebar"
        Me.PTitlebar.Size = New System.Drawing.Size(275, 25)
        Me.PTitlebar.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Century", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(252, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(23, 25)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "x"
        '
        'SwapingForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.ClientApp.My.Resources.Resources.GradientBlue2
        Me.ClientSize = New System.Drawing.Size(275, 374)
        Me.ControlBox = False
        Me.Controls.Add(Me.PTitlebar)
        Me.Controls.Add(Me.FLPItemList)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "SwapingForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SwapingForm"
        Me.TopMost = True
        Me.PTitlebar.ResumeLayout(False)
        Me.PTitlebar.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents FLPItemList As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents PTitlebar As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
