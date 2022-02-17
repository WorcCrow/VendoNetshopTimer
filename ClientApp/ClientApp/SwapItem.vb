Public Class SwapItem
    Public pcname As String
    Public ip As String
    Public obj As Object
    Private Sub UserControl1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lComputerName.Text = Me.pcname
        lComputerName.Location = New Point((Panel1.Size.Width \ 2) - (lComputerName.Size.Width \ 2), lComputerName.Location.Y)
    End Sub

    Private Sub lComputerName_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles lComputerName.MouseEnter
        Me.ForeColor = Color.LightGreen
        PictureBox1.Image = My.Resources.ComputerIconGreen
    End Sub

    Private Sub lComputerName_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles lComputerName.MouseLeave
        Me.ForeColor = Color.Black
        PictureBox1.Image = My.Resources.ComputerIconBlack
    End Sub

    Private Sub lComputerName_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lComputerName.Click
        Confirm = False
        Confirmation.ShowDialog()
        If Confirm Then
            SubmitData(Client, "MOVE:" & ip)
        Else
            MsgBox("Invalid Code!")
        End If
        obj.close()
    End Sub
End Class
