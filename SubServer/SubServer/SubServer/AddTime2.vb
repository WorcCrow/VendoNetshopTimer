Imports System.Text
Imports System.Threading

Public Class AddTime2
    Public index As String
    Dim clientname As String
    Dim clientindex As String

    Private Sub AddTime2_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        clientname = SubServerUI.dgvClient.Rows(index).Cells(SubServerUI.dgvname.Index).Value
        clientindex = SubServerUI.dgvClient.Rows(index).Cells(SubServerUI.dgvindex.Index).Value

        MakePanelDragable(Panel3, Me)

        cbAmount.Items.Clear()
        For avail = totalCredit To 1 Step -1
            If CreditToMinute(avail)(1) = 0 Then
                cbAmount.Items.Add(avail)
            End If
        Next
        If cbAmount.Items.Count Then
            cbAmount.Enabled = True
            cbAmount.SelectedIndex = 0
            lTimeformat.Text = SecToTime(CreditToMinute(totalCredit)(0))
            lCreditleft.Text = totalCredit - cbAmount.Text
        Else
            cbAmount.Enabled = False
            lTimeformat.Text = SecToTime(CreditToMinute(totalCredit)(0))
            lCreditleft.Text = totalCredit
        End If
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If cbAmount.Text <> "" Then
            totalCredit -= cbAmount.Text
            SubServerUI.lbCredit.Text = totalCredit

            AddTime(index, cbAmount.Text)
            SaveData("./data/client.dat", clist)

            Dim reportstr As String = "SALES," & SystemDateTime() & "," &
                clientname & "," & cbAmount.Text & "," & " credit was loaded on "
            UpdateDataFile("./report/" & SystemDate() & ".dat", reportstr)
        End If
        Me.Close()
    End Sub

    Private Sub cbAmount_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbAmount.SelectedIndexChanged
        lCreditleft.Text = totalCredit - cbAmount.Text
        lTimeformat.Text = SecToTime(CreditToMinute(cbAmount.Text)(0))
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    'Functions and Sub

    Sub AddTime(ByVal ndx As Integer, ByVal credit As Integer)
        lCreditleft.Text = totalCredit - cbAmount.Text
        clist(clientindex).AddTime(CLng(CreditToMinute(credit)(0)))
        UpdateClient(clientindex)
    End Sub
End Class