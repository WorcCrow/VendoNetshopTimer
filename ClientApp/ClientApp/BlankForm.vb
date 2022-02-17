Imports System.Threading

Public Class BlankForm

    Private Sub BlankForm_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If FormClose Then
            FormClose = False
        Else
            e.Cancel = True
        End If
    End Sub

    Private Sub BlankForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Size = LockScreen.Size
        Me.Location = LockScreen.Location
        If CurrTime > 0 Then
            UnlockTSMI.Visible = True
        Else
            UnlockTSMI.Visible = False
        End If

    End Sub

    Private Sub BlankForm_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Right Then
            cmsLockScreen.Show(CType(sender, Control), e.Location)
        End If
    End Sub

    Private Sub UnlockTSMI_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UnlockTSMI.Click
        If CurrTime > 0 Then
            Confirm = -1
            ConfirmMode = "UnLock"
            ConfirmPassword.ShowDialog()

            If Confirm = 1 Then
                LOCKSTAT = False
                MainControl.UpdateLock()
            ElseIf Confirm = 0 Then
                MsgBox("Password Cannot be Empty")
            ElseIf Confirm = 2 Then
                MsgBox("Password is Invalid")
            End If
        End If
    End Sub

    Private Sub ExitTSMI_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitTSMI.Click
        Confirm = -1
        ConfirmMode = "Admin"
        ConfirmPassword.ShowDialog()
        If Confirm = 1 Then
            'New
            protection = False
            ProcessKill("CoinProtector")
            '-New
            FormClose = True
            MainControl.Close()
        ElseIf Confirm = 0 Then
            MsgBox("Password Invalid")
        End If
    End Sub

    Private Sub SettingTSMI_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SettingTSMI.Click
        Confirm = -1
        ConfirmMode = "Admin"
        ConfirmPassword.ShowDialog()

        If Confirm = 1 Then
            Customize.ShowDialog()
        ElseIf Confirm = 0 Then
            MsgBox("Password is Invalid")
        End If
    End Sub
End Class