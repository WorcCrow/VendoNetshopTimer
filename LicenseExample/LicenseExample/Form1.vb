Public Class Form1
    Dim Web As New System.Net.WebClient

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        UpdateLicense()
        LED.Text = key("Expiration")
        LRD.Text = DaysLeft()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        UpdateLicense()
        LED.Text = key("Expiration")
        LRD.Text = DaysLeft()
    End Sub


End Class
