Imports System.IO.Ports
Imports System.Management
Imports System.Threading

Public Class SettingForm
    Dim reportstr As String = "Nothing"

    Private Sub SettingForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MakePanelDragable(Panel1, Me)
        NumericOnly(TBServerPort)
        SetConfig()

        ListRate()
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DefaultConfig()
        SetConfig()
    End Sub

    Private Sub GroupBox2_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        MsgBox("Clicked")
    End Sub

    Private Sub cbWindowState_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbWindowState.CheckedChanged
        UpdateSetting("FullScreen", cbWindowState.Checked)

        If cbWindowState.Checked Then
            reportstr = "ACTIVITY," & SystemDateTime() & "," & " Administrator Enabled FullScreen"
        Else
            reportstr = "ACTIVITY," & SystemDateTime() & "," & " Administrator Disabled FullScreen"
        End If
        UpdateDataFile("./report/" & SystemDate() & ".dat", reportstr)
        SubServerUI.LoadStartupSettings()
    End Sub

    Private Sub BChange_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BChange.Click
        If TBNewpass.Text <> "" Then
            If GetHash(TBOldpass.Text) = GetSetting("SPass") Then
                UpdateSetting("SPass", GetHash(TBNewpass.Text))

                reportstr = "ACTIVITY," & SystemDateTime() & "," & " Password Changed Successfully"
                UpdateDataFile("./report/" & SystemDate() & ".dat", reportstr)
                MsgBox("Password Changed Successfuly")
            Else
                reportstr = "ACTIVITY," & SystemDateTime() & "," & " Failled to Change Password / Invalid Old Password"
                UpdateDataFile("./report/" & SystemDate() & ".dat", reportstr)
                MsgBox("Invalid Password")
            End If
        End If
    End Sub

    Private Sub cbFontSize_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbFontSize.SelectedIndexChanged
        SubServerUI.dgvClient.AlternatingRowsDefaultCellStyle.Font = New Font("Times New Roman", cbFontSize.Text)
        SubServerUI.dgvClient.Font = New Font("Times New Roman", cbFontSize.Text)

        reportstr = "ACTIVITY," & SystemDateTime() & "," & " Grid Font Size Changed to " & cbFontSize.Text
        UpdateDataFile("./report/" & SystemDate() & ".dat", reportstr)
        UpdateSetting("FontSize", cbFontSize.Text)
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        SaveData("./data/rate.dat", Rate)
        WriteConfig("./data/Settings.ini")
        MsgBox("Setting Saved")
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        RateForm.Mode = "AddRate"
        RateForm.ShowDialog()
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        RateForm.Mode = "EditRate"
        RateForm.ShowDialog()
    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        Try
            Dim rateindex = dgvRate.Rows(DGVSelectedRow(dgvRate)).Cells(dgvindex.Index).Value
            Rate.RemoveAt(rateindex)
            ListRate()

            reportstr = "ACTIVITY," & SystemDateTime() & "," & " Deleted Rate " & Rate(rateindex).peso & " = " & Rate(rateindex).minute
            UpdateDataFile("./report/" & SystemDate() & ".dat", reportstr)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub cbAutoAdd_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbAutoAdd.CheckedChanged
        UpdateSetting("AutoAddClient", cbAutoAdd.Checked)

        If cbAutoAdd.Checked Then
            reportstr = "ACTIVITY," & SystemDateTime() & "," & " Administrator Enabled Auto Add Client "
        Else
            reportstr = "ACTIVITY," & SystemDateTime() & "," & " Administrator Disabled Auto Add Client "
        End If
        UpdateDataFile("./report/" & SystemDate() & ".dat", reportstr)
        SubServerUI.LoadStartupSettings()
    End Sub

    Private Sub TBServerPort_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TBServerPort.LostFocus
        UpdateSetting("Port", TBServerPort.Text)

        reportstr = "ACTIVITY," & SystemDateTime() & "," & " Server Port Changed to " & TBServerPort.Text
        UpdateDataFile("./report/" & SystemDate() & ".dat", reportstr)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        reportstr = "ACTIVITY," & SystemDateTime() & "," & " Programmed Exited"
        UpdateDataFile("./report/" & SystemDate() & ".dat", reportstr)
        SubServerUI.Dispose()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    'Functions and Sub
    Sub SetConfig()
        TBCPass.Text = ""
        TBOldpass.Text = ""
        TBNewpass.Text = ""
        TBServerPort.Text = GetSetting("Port")
        cbWindowState.Checked = GetSetting("FullScreen")
        cbAutoAdd.Checked = GetSetting("AutoAddClient")
        cbFontSize.Text = GetSetting("FontSize")
    End Sub

    Sub ListRate()
        SortRate()
        Dim index As Integer = 0
        dgvRate.Rows.Clear()
        For Each r In Rate
            DGVRateAddRows(r.peso, r.minute)
        Next
    End Sub

    Sub DGVRateAddRows(ByVal b As String, ByVal c As String)
        dgvRate.Rows.Add()
        Dim a = dgvRate.Rows.Count - 1
        dgvRate.Rows(a).Cells(dgvindex.Index).Value = a
        dgvRate.Rows(a).Cells(dgvpeso.Index).Value = b
        dgvRate.Rows(a).Cells(dgvseconds.Index).Value = c
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        UpdateSetting("CPass", GetHash(TBCPass.Text))
        reportstr = "ACTIVITY," & SystemDateTime() & "," & " Client Password Set"
        UpdateDataFile("./report/" & SystemDate() & ".dat", reportstr)
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        ActivateForm.ShowDialog()
    End Sub
End Class