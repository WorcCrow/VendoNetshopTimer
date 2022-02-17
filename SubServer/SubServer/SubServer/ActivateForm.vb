Public Class ActivateForm

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub ActivateForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MakePanelDragable(Panel1, Me)

        ShowInfo()
    End Sub

    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        LicenseCode.ShowDialog()
        Application.Restart()
        Me.Refresh()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        UpdateLicense()
        ShowInfo()
    End Sub

    Sub ShowInfo()
        LRegisteredto.Text = GetLicInfo("FullName")
        LLicenseEmail.Text = GetLicInfo("LicenseEmail")
        LContact.Text = GetLicInfo("Contact")
        LPurchaseDate.Text = GetLicInfo("PurchaseDate")
        LExpirationDate.Text = GetLicInfo("Expiration")
        LRemainingDays.Text = DaysLeft() & " day/s left"
        LMachineID.Text = GetLicInfo("MachineID")

        Try
            LLicenseCode.Text = GetLicInfo("LicenseCode").ToString.Substring(0, 4) & "********" & GetLicInfo("LicenseCode").ToString.Substring(12, 4)
        Catch ex As Exception
            LLicenseCode.Text = "0"
        End Try
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        If DaysLeft() <= 0 Then
            ApplicationClose()
        End If
    End Sub
End Class