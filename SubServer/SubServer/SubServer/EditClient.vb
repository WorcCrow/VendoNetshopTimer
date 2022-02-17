Public Class EditClient
    Public index As String

    Private Sub EditClient_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MakePanelDragable(Panel1, Me)
        TextBox1.Text = clist(index).name
        TextBox2.Text = clist(index).ip
        TextBox1.SelectAll()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        clist(index).name = TextBox1.Text
        SaveData("./data/client.dat", clist)
        Me.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class