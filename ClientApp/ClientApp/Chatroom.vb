Imports System.Threading
Imports System.Text

Public Class Chatroom

    Private Sub Chatroom_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MakePanelDragable(PTitlebar, Me)
        Me.MaximumSize = New Point(WAWidth, WAHeight)
        AddHandler Label1.MouseEnter, Sub()
                                          Label1.ForeColor = Color.Red
                                      End Sub
        AddHandler Label1.MouseLeave, Sub()
                                          Label1.ForeColor = Color.White
                                      End Sub
        AddHandler Label2.MouseEnter, Sub()
                                          Label2.ForeColor = Color.Red
                                      End Sub
        AddHandler Label2.MouseLeave, Sub()
                                          Label2.ForeColor = Color.White
                                      End Sub
        AddHandler Label3.MouseEnter, Sub()
                                          Label3.ForeColor = Color.Red
                                      End Sub
        AddHandler Label3.MouseLeave, Sub()
                                          Label3.ForeColor = Color.White
                                      End Sub
        txtMessage.Select()
    End Sub

    Private Sub txtMessage_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtMessage.KeyDown
        If e.KeyCode = 13 Then
            SubmitData(Client, "CHAT:" & "[" & Environment.MachineName & "] : -> " & txtMessage.Text)
            rtbChatroom.Text += "[ME] : -> " & txtMessage.Text & vbNewLine
            rtbChatroom.SelectionStart = rtbChatroom.Text.Length
            rtbChatroom.ScrollToCaret()
            txtMessage.Text = ""

            rtbChatroom.ScrollToCaret()
        End If
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click
        Me.Close()
    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        rtbChatroom.Text = ""
    End Sub

    Private Sub rtbChatroom_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles rtbChatroom.MouseMove
        txtMessage.Select()
    End Sub

    Private Sub Label2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub Label2_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnChat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnChat.Click
        rtbChatroom.Text = ""
    End Sub

    Public Maximize = False
    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click
        If Maximize Then
            Maximize = False
            Me.WindowState = FormWindowState.Normal
        Else
            Maximize = True
            Me.WindowState = FormWindowState.Maximized
        End If
    End Sub

    Private Sub rtbChatroom_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rtbChatroom.TextChanged
        rtbChatroom.SelectionStart = rtbChatroom.Text.Length
        rtbChatroom.ScrollToCaret()
    End Sub
End Class