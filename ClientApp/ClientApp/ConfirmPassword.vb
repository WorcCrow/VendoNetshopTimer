Public Class ConfirmPassword
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Dim NoPass As Boolean = False

    Private Sub ConfirmPassword_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MakePanelDragable(PTitlebar, Me)
        ButtonStyle(Button1)
        ButtonStyle(Button2)

        Select Case ConfirmMode
            Case "SetPassLock"
                Label3.Text = "Set Lock Password"
                HorizontalCenterAlign(Label3, Me)
            Case "UnLock"
                Label3.Text = "Enter Password to Unlock"
                HorizontalCenterAlign(Label3, Me)
            Case "Admin"
                If GetSetting("Password") = "0" Then
                    SubmitData(Client, "PASS:REQUEST")
                End If
                Label3.Text = "Enter Password"
                HorizontalCenterAlign(Label3, Me)
        End Select
        MTBOPass.Select()
        MTBOPass.Text = ""
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Select Case ConfirmMode
            Case "SetPassLock"
                If MTBOPass.Text = "" Then
                    Confirm = 0
                    Me.Close()
                Else
                    LockPassword = MTBOPass.Text
                    Confirm = 1
                    Me.Close()
                End If
            Case "UnLock"
                If MTBOPass.Text = "" Then
                    Confirm = 0
                    Me.Close()
                Else
                    If MTBOPass.Text = LockPassword Then
                        Confirm = 1
                        Me.Close()
                    Else
                        Confirm = 2
                        Me.Close()
                    End If
                End If

            Case "Admin"
                If GetSetting("Password") = GetHash(MTBOPass.Text) Then
                    Confirm = 1
                    Me.Close()
                Else
                    Confirm = 0
                    Me.Close()
                End If
        End Select
    End Sub
End Class