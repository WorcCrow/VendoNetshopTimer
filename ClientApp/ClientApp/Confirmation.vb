Public Class Confirmation

    Private Sub Confirmation_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MakePanelDragable(PTitlebar, Me)
        LRandom.Text = random.Next(100000, 999999)
        TBConfirmAnswer.Text = ""
        TBConfirmAnswer.Select()
    End Sub

    Private Sub TBConfirmAnswer_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TBConfirmAnswer.KeyDown
        If e.KeyCode = 13 Then
            If TBConfirmAnswer.Text = LRandom.Text Then
                Confirm = 1
                Me.Close()
            Else
                Confirm = 0
                Me.Close()
            End If
        End If
    End Sub
End Class