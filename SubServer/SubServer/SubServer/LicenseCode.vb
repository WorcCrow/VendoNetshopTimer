Public Class LicenseCode
    Public pressed As Integer

    Private Sub LicenseCode_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MakePanelDragable(Panel1, Me)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        pressed = 1
        UpdateSetting("LicenseCode", TBLicenseCode.Text)
        WriteConfig("./data/Settings.ini")
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        pressed = 2
    End Sub
End Class