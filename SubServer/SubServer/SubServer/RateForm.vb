Public Class RateForm
    Public Mode As String
    Public rateindex As Integer

    Dim reportstr As String = Nothing

    Private Sub RateForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        NumericOnly(TBPrice)
        NumericOnly(TBTime)
        MakePanelDragable(Panel1, Me)

        Select Case Mode
            Case "AddRate"
                Try
                    BAccept.Text = "Add"
                    LMode.Text = "Add Rate"
                    TBPrice.Text = ""
                    TBTime.Text = ""
                Catch ex As Exception
                End Try
            Case "EditRate"
                Try
                    rateindex = SettingForm.dgvRate.Rows(DGVSelectedRow(SettingForm.dgvRate)).Cells(SettingForm.dgvindex.Index).Value
                    BAccept.Text = "Edit"
                    LMode.Text = "Edit Rate"
                    TBPrice.Text = SettingForm.dgvRate.Rows(DGVSelectedRow(SettingForm.dgvRate)).Cells(SettingForm.dgvpeso.Index).Value
                    TBTime.Text = SettingForm.dgvRate.Rows(DGVSelectedRow(SettingForm.dgvRate)).Cells(SettingForm.dgvseconds.Index).Value
                Catch ex As Exception
                End Try
        End Select
        TBPrice.SelectAll()
    End Sub

    Private Sub BAccept_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BAccept.Click
        Select Case Mode
            Case "AddRate"
                Try
                    Rate.Add(New RateData.RateInfo(TBPrice.Text, TBTime.Text))
                    SettingForm.ListRate()

                    reportstr = "ACTIVITY," & SystemDateTime() & "," & " Rate Added " & TBPrice.Text & " = " & TBTime.Text
                    UpdateDataFile("./report/" & SystemDate() & ".dat", reportstr)
                    Me.Close()
                Catch ex As Exception
                End Try
            Case "EditRate"
                Try
                    Dim rateindex = SettingForm.dgvRate.Rows(DGVSelectedRow(SettingForm.dgvRate)).Cells(SettingForm.dgvindex.Index).Value

                    reportstr = "ACTIVITY," & SystemDateTime() & "," & " Rate Edited From " & Rate(rateindex).peso & " = " & Rate(rateindex).peso & " TO " & TBPrice.Text & " = " & TBTime.Text
                    UpdateDataFile("./report/" & SystemDate() & ".dat", reportstr)

                    Rate(rateindex).peso = TBPrice.Text
                    Rate(rateindex).minute = TBTime.Text

                    SettingForm.ListRate()
                    Me.Close()
                Catch ex As Exception
                End Try
              
        End Select
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class