Imports System.Text
Imports System.Security.Cryptography
Imports System.IO

Module SpecialFunction
    Sub ApplicationClose()
        Process.GetCurrentProcess.Kill()
    End Sub

    Sub NumericOnly(ByVal obj As Windows.Forms.TextBox)
        AddHandler obj.KeyPress, Sub(sender As Object, e As System.Windows.Forms.KeyPressEventArgs)
                                     If Asc(e.KeyChar) = 8 Then
                                         e.Handled = False
                                     Else
                                         If e.KeyChar Like "[!0-9]" Then
                                             e.Handled = True
                                         End If
                                     End If
                                 End Sub
    End Sub

    Function DGVSelectedRow(ByVal dgv As Object)
        For Each selected In dgv.SelectedRows
            Return selected.index()
        Next
        Return -1
    End Function

    Public Sub MakePanelDragable(ByVal panel As System.Windows.Forms.Panel, ByVal form As Object)
        AddHandler panel.MouseUp, Sub()
                                      FormMove = False
                                  End Sub
        AddHandler panel.MouseDown, Sub()
                                        MouseX = Cursor.Position.X - form.Left
                                        MouseY = Cursor.Position.Y - form.Top
                                        FormMove = True
                                    End Sub
        AddHandler panel.MouseMove, Sub()
                                        If FormMove Then
                                            form.Left = Cursor.Position.X - MouseX
                                            form.Top = Cursor.Position.Y - MouseY
                                        End If
                                    End Sub
    End Sub

    Public Sub HorizontalCenterAlign(ByVal label As Windows.Forms.Label, ByVal parent As Object)
        label.Location = New Point((parent.Size.Width / 2) - label.Size.Width / 2, label.Location.Y)
    End Sub

    Sub UpdateSetting(ByVal key As String, ByVal val As String)
        Try
            Setting.Add(key, val)
        Catch ex As Exception
            Setting(key) = val
        End Try
    End Sub

    Function GetSetting(ByVal key As String)
        Try
            Return Setting(key)
        Catch ex As Exception
            Return "0"
        End Try
    End Function

    Sub UpdateClient(ByVal index As Integer)
        If index >= 0 Then
            For Each row As DataGridViewRow In SubServerUI.dgvClient.Rows
                If row.Cells(SubServerUI.dgvindex.Index).Value = index Then
                    row.Cells(SubServerUI.dgvstarted.Index).Value = clist(index).Started
                    row.Cells(SubServerUI.dgvtimeLeft.Index).Value = clist(index).RemainingTime
                    row.Cells(SubServerUI.dgvcount.Index).Value = clist(index).RemainingTick
                End If
            Next
            UpdateClientTime(clist(index).ip, clist(index).RemainingTick)
            UpdateClientList()
        End If
    End Sub

    Sub UpdateClientTime(ByVal IP As String, ByVal Time As String)
        For Each CClient In ConnectedClient
            If CClient.Client.RemoteEndPoint.ToString.Split(":")(0) = IP Then
                Try
                    SubmitData(CClient, "TIME:" & Time)
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
        Next
    End Sub

    Sub UpdateClientList()
        For Each CClient In ConnectedClient
            Try
                SubmitData(CClient, "LIST:" & AvailableClient())
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Next
    End Sub

    Sub AutoAddClient(ByVal obj As Object)
        For Each luc In ListUnregClient()
            Dim ip = luc
            clist.Add(New ClientData.ClientInfo(ip, ip, 0, 0))
            obj.BeginInvoke(Sub()
                                obj.DGVClientAddRows(ip, ip, 0, "00:00:00", 0)
                            End Sub)
            SaveData("./data/client.dat", clist)
        Next
    End Sub


    Function AvailableClient()
        Dim aclients As String = ""
        For Each clnt In clist
            If clnt.RemainingTick = 0 Then
                aclients &= clnt.name & ":" & clnt.ip & ","
            End If
        Next
        Return aclients
    End Function

    Function IsConnected(ByVal ip As String)
        If ConnectedClient.Count > 0 Then
            For Each cc In ConnectedClient
                If ip = cc.Client.RemoteEndPoint.ToString.Split(":")(0) Then
                    Return 1
                End If
            Next
            Return 0
        End If
        Return 0
    End Function

    Public Function GetHash(ByVal a As String)
        Dim b() As Byte = Encoding.ASCII.GetBytes(a),
        c = MD5.Create(),
        d() As Byte,
        f = ""
        d = c.ComputeHash(b)
        For Each e In d
            f += e.ToString("X2")
        Next
        Return f.ToLower
    End Function

    Function CreditToMinute(ByVal credit As Integer)
        Dim output(1) As Integer
        Dim minute As Integer = 0
        For Each rt As RateInfo In Rate
            If credit >= rt.peso Then
                minute += Math.Floor(credit / rt.peso) * rt.minute
                credit = credit Mod rt.peso
            End If
        Next
        output(0) = minute
        output(1) = credit
        Return output
    End Function

    Public Function SecToTime(ByVal s As Integer)
        If s < 0 Then
            s = 0
        End If
        Dim h, m
        If s >= 3600 Then
            h = s \ 3600
            h = If(h.ToString.Length = 2, h, "0" & h)
            s = s - (h * 3600)
        Else
            h = "00"
        End If
        If s >= 60 Then
            m = s \ 60
            m = If(m.ToString.Length = 2, m, "0" & m)
            s = s - (m * 60)
        Else
            m = "00"
        End If
        Return h & ":" & m & ":" & If(s.ToString.Length = 2, s, "0" & s)
    End Function

    Function GetIPIndex(ByVal ip As String)
        Dim ndx = 0
        For Each clnt In clist
            If clnt.ip = ip Then
                Return ndx
            End If
            ndx += 1
        Next
        Return -1
    End Function

    Function GetNameIndex(ByVal name As String)
        Dim ndx = 0
        For Each clnt In clist
            If clnt.name = name Then
                Return ndx
            End If
            ndx += 1
        Next
        Return -1
    End Function

    Sub CreateDirectory(ByVal directorypath As String)
        Try
            If Not Directory.Exists(directorypath) Then
                Directory.CreateDirectory(directorypath)
            End If
        Catch ex As Exception
            ErrorLog(SystemDateTime() & " -> " & ex.Message)
        End Try
    End Sub

    Function SystemTick()
        Return DateTime.Now.Ticks
    End Function

    Function SystemDateTime()
        Return DateTime.Now.ToString("G")
    End Function

    Function SystemDate()
        Return DateTime.Now.ToString("MM-dd-yyyy")
    End Function
End Module
