Public Class SwapingForm
    Private Sub SwapingForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If UnitList.Count Then
            MakePanelDragable(PTitlebar, Me)
            AddHandler Label1.MouseEnter, Sub()
                                              Label1.ForeColor = Color.Red
                                          End Sub
            AddHandler Label1.MouseLeave, Sub()
                                              Label1.ForeColor = Color.White
                                          End Sub
            For Each unit In UnitList
                Dim item = New SwapItem
                item.obj = Me
                item.pcname = unit.name
                item.ip = unit.ip
                FLPItemList.Controls.Add(item)
            Next
        Else
            Me.Close()
        End If
    End Sub

    Private Sub FLPItemList_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles FLPItemList.MouseEnter
        FLPItemList.Focus()
    End Sub
    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click
        Me.Close()
    End Sub

    Private Sub FLPItemList_MouseWheel(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles FLPItemList.MouseWheel
        FLPItemList.Refresh()
    End Sub
End Class