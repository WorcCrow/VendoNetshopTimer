Imports System.Text

Public Class ConfirmPassword
    Private Sub ConfirmPassword_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        HorizontalCenterAlign(lMessage, Me)
        mtbPassword.Text = ""
        mtbPassword.Select()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If GetSetting("SPass") = "0" Then
            UpdateSetting("SPass", GetHash("admin"))
        End If

        If mtbPassword.Text = "" Then
            PassResult = "Nothing"
        ElseIf GetHash(mtbPassword.Text) = GetSetting("SPass") Then
            PassResult = True
        Else
            PassResult = False
        End If

        Dim reportstr As String = Nothing
        If PassResult = "True" Then
            reportstr = "ACTIVITY," & SystemDateTime() & "," & " Administrator Logged-in"
        ElseIf PassResult = "False" Then
            reportstr = "ACTIVITY," & SystemDateTime() & "," & " Attempted Login"
        End If

        UpdateDataFile("./report/" & SystemDate() & ".dat", reportstr)
        Me.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    'Functions and Sub
End Class