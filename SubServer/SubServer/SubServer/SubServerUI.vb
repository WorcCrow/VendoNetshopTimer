Imports System.Threading
Imports System.Text
Imports System.Net.Sockets
Imports System.IO
Imports System.Runtime.Serialization.Formatters.Binary
Imports System.IO.Ports
Imports System.Xml.Serialization
Imports System.Xml
Imports System.Media
Imports System.Net.NetworkInformation

Public Class SubServerUI
    Private Sub SubServerUI_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MakePanelDragable(pNavbar, Me)

        ExecuteSetup()
        ExecuteThread()

        LoadStartupSettings()

        RefreshAuthorization()

        BTNEvent(btnLeft1)
        BTNEvent(btnLeft2)
        BTNEvent(btnLeft3)
        BTNEvent(btnLeft4)

        BTNEvent(btnRight1)
        BTNEvent(btnRight2)
        BTNEvent(btnRight3)
        BTNEvent(btnRight4)

        StartupLicenseCheck()
    End Sub

    Private Sub dgvClient_CellMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dgvClient.CellMouseDoubleClick
        If e.RowIndex <> -1 Then
            AddTime2.index = DGVSelectedRow(dgvClient)
            AddTime2.ShowDialog()
        End If
    End Sub

    Private Sub dgvClient_CellMouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dgvClient.CellMouseDown
        If e.RowIndex <> -1 Then
            If e.Button = MouseButtons.Right Then
                dgvClient.CurrentCell = dgvClient(e.ColumnIndex, e.RowIndex)

                If AutorizationLevel = "Admin" Then
                    LogoutToolStripMenuItem.Visible = True
                    DeleteToolStripMenuItem.Visible = True
                    EditToolStripMenuItem.Visible = True
                Else
                    LogoutToolStripMenuItem.Visible = False
                    DeleteToolStripMenuItem.Visible = False
                    EditToolStripMenuItem.Visible = False
                End If

                If dgvClient.SelectedRows.Count > 0 Then
                    dgvClient.ContextMenuStrip = CMSAdmin
                    MoveToolStripMenuItem.DropDownItems.Clear()
                    If dgvClient.Rows(DGVSelectedRow(dgvClient)).Cells(dgvstatus.Index).Value = "Offline" Then
                        MoveToolStripMenuItem.Enabled = True
                        For Each c In AvailableClient.Split(",")
                            If c <> "" Then
                                MoveToolStripMenuItem.DropDownItems.Add(c.Split(":")(0))
                            End If
                        Next
                        For Each item In MoveToolStripMenuItem.DropDownItems
                            AddMoveItem(item)
                        Next
                    Else
                        MoveToolStripMenuItem.Enabled = False
                    End If
                Else
                    dgvClient.ContextMenuStrip = Nothing
                End If
            End If
        End If
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogoutToolStripMenuItem.Click
        For Each item In dgvClient.SelectedRows
            Dim clientindex = item.Cells(dgvindex.Index).Value
            clist(clientindex).Logout()
            UpdateClient(clientindex)
            SaveData("./data/client.dat", clist)
        Next
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteToolStripMenuItem.Click
        For Each item In dgvClient.SelectedRows
            If item.Cells(dgvindex.Index).Value() >= 0 Then
                dgvClient.Rows.RemoveAt(item.index)
                Try
                    clist.RemoveAt(item.Cells(dgvindex.Index).Value())
                Catch
                End Try
                UpdateClient(item.index)
                SaveData("./data/client.dat", clist)
            End If
        Next
    End Sub

    Private Sub btnLeft2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLeft2.Click
        lbCredit.Select()
        If AutorizationLevel = "Admin" Then
            totalCredit += 100
            lbCredit.Text = totalCredit
            HorizontalCenterAlign(lbCredit, Me)
            My.Computer.Audio.Play(My.Resources.coin, AudioPlayMode.Background)
        End If
    End Sub

    Private Sub CMSAdmin_Opening(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles CMSAdmin.Opening
        If dgvClient.SelectedRows.Count > 0 Then
            dgvClient.ContextMenuStrip = CMSAdmin
        Else
            dgvClient.ContextMenuStrip = Nothing
        End If
    End Sub

    Private Sub EditToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles EditToolStripMenuItem.Click
        Dim selectedindex = DGVSelectedRow(dgvClient)
        Dim clistindex = dgvClient.Rows(selectedindex).Cells(dgvindex.Index).Value
        EditClient.index = clistindex
        EditClient.ShowDialog()
        dgvClient.Rows(selectedindex).Cells(dgvname.Index).Value = clist(clistindex).name
    End Sub

    Private Sub btnLeft4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLeft4.Click
        AutorizationLevel = "Operator"
        TSSLAuthLevel.ForeColor = Color.Red
        TSSLAuthLevel.Text = "Operator"
        btnRight4.Text = ""
        btnLeft1.Text = ""
        btnLeft2.Text = ""
        btnLeft3.Text = ""
        btnLeft4.Text = ""
        PBLogin.Visible = True
        RefreshAuthorization()
    End Sub

    Private Sub btnLeft3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLeft3.Click
        lbCredit.Select()
        If AutorizationLevel = "Admin" Then
            SettingForm.ShowDialog()
        End If
    End Sub

    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    'Functions and Sub
    Sub LoadStartupSettings()
        dgvClient.Size = New Point(dgvClient.Size.Width, screenHeight - (dgvClient.Location.Y + 100))

        If GetSetting("FullScreen") Then
            Me.Location = New Point(Me.Location.X, 0)
            Me.WindowState = FormWindowState.Maximized
        Else
            Me.WindowState = FormWindowState.Normal
            Me.Size = New Point((75 * screenWidth) / 100, My.Computer.Screen.WorkingArea.Height)
            Me.Location = New Point((screenWidth / 2) - (Me.Width / 2), 0)
        End If

        HorizontalCenterAlign(lbCredit, Me)

        If GetSetting("FontSize") Then
            dgvClient.AlternatingRowsDefaultCellStyle.Font = New Font("Times New Roman", GetSetting("FontSize"))
            dgvClient.Font = New Font("Times New Roman", GetSetting("FontSize"))
        End If
    End Sub

    Sub ExecuteSetup()
        CreateDirectory("./log")
        CreateDirectory("./data")
        CreateDirectory("./report")

        ReadConfig("./data/Settings.ini")
        LoadData("./data/client.dat", clist)
        dgvClientRefresh()

        LoadData("./data/rate.dat", Rate)
        SortRate()
    End Sub

    Sub ExecuteThread()
        ThreadPool.QueueUserWorkItem(AddressOf Counting)
        ThreadPool.QueueUserWorkItem(Sub()
                                         While True
                                             RefreshConnectedClient()
                                             If clist.Count <> dgvClient.Rows.Count Then
                                                 dgvClientRefresh()
                                             End If
                                             If GetSetting("AutoAddClient") Then
                                                 AutoAddClient(Me)
                                             End If
                                             Dim x = 0
                                             For Each luc In ListUnregClient()
                                                 x += 1
                                             Next
                                             TSSLConnectionRequest.Text = x
                                             Thread.Sleep(10000)
                                         End While
                                     End Sub)
        


        Dim startlistening As Thread = New Threading.Thread(AddressOf StartServer)
        startlistening.IsBackground = True
        startlistening.Start()

        Dim statusupdater As Thread = New Threading.Thread(AddressOf StatusCheck)
        statusupdater.IsBackground = True
        statusupdater.Start()

        Dim coin As Thread = New Threading.Thread(AddressOf CoinConnect)
        coin.IsBackground = True
        coin.Start()

        Dim Process As Thread = New Threading.Thread(AddressOf ProcessData)
        Process.IsBackground = True
        Process.Start()
    End Sub

    Sub BTNEvent(ByVal btn As Windows.Forms.Button)
        AddHandler btn.MouseEnter, AddressOf btnControlHover
        AddHandler btn.MouseLeave, AddressOf btnControlLeave
    End Sub

    Sub Visibility(ByVal btn As Windows.Forms.Button)
        If btn.Text = "" Then
            btn.Visible = False
        Else
            btn.Visible = True
        End If
    End Sub

    Sub RefreshAuthorization()
        Visibility(btnLeft1)
        Visibility(btnLeft2)
        Visibility(btnLeft3)
        Visibility(btnLeft4)

        Visibility(btnRight1)
        Visibility(btnRight2)
        Visibility(btnRight3)
        Visibility(btnRight4)
    End Sub

    Sub ProcessData()
        While True
            If DataReceive.Count Then
                Dim DataArr As Array = DataReceive(0).dat.Split(New Char() {":"c}, 2)
                If DataArr.Length = 2 Then
                    ProcessReceive(DataReceive(0).RemoteC, DataArr(0), DataArr(1))
                    DataReceive.RemoveAt(0)
                Else
                    DataReceive.RemoveAt(0)
                End If
            End If
            Thread.Sleep(1)
        End While
    End Sub

    Sub ProcessReceive(ByVal RemoteC As TcpClient, ByVal Comm As String, ByVal Val As String)
        Try
            Dim ip = RemoteC.Client.RemoteEndPoint.ToString.Split(":")(0)
            Select Case Comm
                Case "PASS"
                    If Val = "REQUEST" Then
                        If GetSetting("CPass") = "0" Then
                            UpdateSetting("CPass", GetHash("admin"))
                        End If
                        SubmitData(RemoteC, "PASS:" & GetSetting("CPass"))
                    End If
                Case "CHAT"
                    For Each clnt In ConnectedClient
                        Dim clntip = clnt.Client.RemoteEndPoint.ToString.Split(":")(0)
                        If clntip <> ip Then
                            SubmitData(clnt, "CHAT:" & Val)
                        End If
                    Next
                Case "LOGOUT"
                    If Val = "TRUE" Then
                        clist(GetIPIndex(ip)).Logout()
                        BeginInvoke(Sub() UpdateClient(GetIPIndex(ip)))
                        SaveData("./data/client.dat", clist)
                    End If

                Case "MOVE"
                    If Val = "LIST" Then
                        SubmitData(RemoteC, "LIST:" & AvailableClient())
                    Else
                        Try
                            Dim src = GetIPIndex(ip)
                            Dim dest = GetIPIndex(Val)
                            clist(src).SwapTime(clist(dest))
                            BeginInvoke(Sub() UpdateClient(src))
                            BeginInvoke(Sub() UpdateClient(dest))
                            SaveData("./data/client.dat", clist)
                        Catch
                        End Try
                    End If
            End Select
        Catch ex As Exception
            ErrorLog(SystemDateTime() & " -> " & ex.Message)
        End Try
    End Sub

    Public Sub StatusCheck()
        While True
            CheckSerialConnection()
            If CheckUpdate Then
                StatusUpdate()
            End If
            Thread.Sleep(4000)
        End While
    End Sub

    Sub StatusUpdate()
        If InvokeRequired Then
            Invoke(New MethodInvoker(AddressOf StatusUpdate))
        Else
            CheckUpdate = False
            If SlotStat Then
                TSSLCoinslot.ForeColor = Color.Green
                TSSLCoinslot.Text = "Ready"
            Else
                TSSLCoinslot.ForeColor = Color.Red
                TSSLCoinslot.Text = "Not Ready"
            End If
        End If
    End Sub

    Sub CoinConnect()
        Dim status = Connect2Coin(Setting("COM"))
        If status = 1 Then
            SerialReceive()
        Else
            Dim retry = True
            While retry
                Thread.Sleep(4000)
                Dim COM = ScanSerial()
                If COM <> "0" Then
                    retry = False
                    Setting("COM") = COM
                    CoinConnect()
                End If
            End While
        End If
    End Sub

    Sub btnControlHover(ByVal sender As Object, ByVal e As System.EventArgs)
        If sender.Text <> "" Then
            My.Computer.Audio.Play(My.Resources.sci_fi, AudioPlayMode.Background)
            If sender.Location.X = 0 Then
                sender.Size = New Point(120, 95)
            Else
                sender.Size = New Point(120, 95)
                sender.Location = New Point(sender.Location.X - 25, sender.Location.y)
            End If
        End If
    End Sub

    Sub btnControlLeave(ByVal sender As Object, ByVal e As System.EventArgs)
        If sender.Text <> "" Then
            If sender.Location.X = 0 Then
                sender.Size = New Point(95, 95)
            Else
                sender.Size = New Point(95, 95)
                sender.Location = New Point(Me.Size.Width - sender.size.Width, sender.Location.y)
            End If
        End If
    End Sub

    Sub Counting()
        While True
            Try
                BeginInvoke(New MethodInvoker(AddressOf CountDown))
                Thread.Sleep(1000)
            Catch
            End Try
        End While
    End Sub

    Sub CountDown()
        If InvokeRequired Then
            Invoke(New MethodInvoker(AddressOf CountDown))
        Else
            For Each item As DataGridViewRow In dgvClient.Rows
                Try
                    If IsConnected(item.Cells(dgvip.Index).Value) Then
                        item.Cells(dgvstatus.Index).Style.ForeColor = Color.Green
                        item.Cells(dgvstatus.Index).Value = "Online"
                    Else
                        item.Cells(dgvstatus.Index).Style.ForeColor = Color.White
                        item.Cells(dgvstatus.Index).Value = "Offline"
                    End If

                    If item.Cells(dgvcount.Index).Value > 0 Then
                        item.Cells(dgvcount.Index).Value -= 1
                        item.Cells(dgvtimeLeft.Index).Value = SecToTime(item.Cells(dgvcount.Index).Value)
                    Else
                        item.Cells(dgvstarted.Index).Value = ""
                    End If
                Catch ex As Exception
                    Console.WriteLine(ex.Message)
                End Try
            Next
        End If
    End Sub

    Sub SerialReceive()
        If Not CoinSlot.IsOpen Then
            CoinSlot.Open()
        End If
        While CoinSlot.IsOpen
            Try
                Dim DataReceived As String
                DataReceived = CoinSlot.ReadLine()
                If DataReceived <> "" Then
                    ChangeTxt()
                End If

            Catch ex As Exception
                Console.WriteLine("#SerialReceive# : " & ex.Message)
            End Try
        End While
        CoinConnect()
    End Sub

    Sub ChangeTxt()
        If InvokeRequired Then
            Invoke(New MethodInvoker(AddressOf ChangeTxt))
        Else
            totalCredit += 1
            lbCredit.Text = totalCredit
            HorizontalCenterAlign(lbCredit, Me)
            My.Computer.Audio.Play(My.Resources.coin, AudioPlayMode.Background)
        End If
    End Sub

    Sub dgvClientRefresh()
        If InvokeRequired Then
            Invoke(New MethodInvoker(AddressOf dgvClientRefresh))
        Else
            dgvClient.Rows.Clear()
            For Each clnt As ClientData.ClientInfo In clist
                DGVClientAddRows(clnt.name, clnt.ip, clnt.Started, clnt.RemainingTime, clnt.RemainingTick)
            Next
            dgvname.SortMode = DataGridViewColumnSortMode.Automatic
            dgvClient.Sort(dgvClient.Columns(dgvname.Index), System.ComponentModel.ListSortDirection.Ascending)
        End If
    End Sub

    Sub DGVClientAddRows(ByVal b As String, ByVal c As String, ByVal d As String, ByVal e As String, ByVal f As String)
        dgvClient.Rows.Add()
        Dim a = dgvClient.Rows.Count - 1
        dgvClient.Rows(a).Cells(dgvindex.Index).Value = a
        dgvClient.Rows(a).Cells(dgvname.Index).Value = b
        dgvClient.Rows(a).Cells(dgvip.Index).Value = c
        dgvClient.Rows(a).Cells(dgvstarted.Index).Value = d
        dgvClient.Rows(a).Cells(dgvtimeLeft.Index).Value = e
        dgvClient.Rows(a).Cells(dgvcount.Index).Value = f
    End Sub

    Sub AddMoveItem(ByVal obj As System.Windows.Forms.ToolStripMenuItem)
        AddHandler obj.Click, Sub()
                                  For Each item In dgvClient.SelectedRows
                                      Dim clientindex = item.Cells(dgvindex.Index).Value
                                      MsgBox(clientindex & "::::" & GetNameIndex(obj.Text))
                                      clist(clientindex).SwapTime(clist(GetNameIndex(obj.Text)))
                                      UpdateClient(clientindex)
                                      UpdateClient(GetNameIndex(obj.Text))
                                      SaveData("./data/client.dat", clist)
                                  Next
                              End Sub
    End Sub

    Private Sub ToolStripStatusLabel4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TSSLExpiryNotification.Click
        MsgBox("Login")
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PBLogin.Click
        lbCredit.Select()
        PassResult = "Nothing"
        ConfirmPassword.ShowDialog()
        If PassResult = "True" Then
            CheckUpdate = True
            AutorizationLevel = "Admin"
            TSSLAuthLevel.ForeColor = Color.Green
            TSSLAuthLevel.Text = "Admin"
            btnLeft1.Text = "Reports"
            btnLeft2.Text = "100 Credits"
            btnLeft3.Text = "Settings"
            btnLeft4.Text = "Logout"
            PBLogin.Visible = False
            RefreshAuthorization()
        ElseIf PassResult = "False" Then
            MsgBox("Invalid Password")
        End If
    End Sub

    Private Sub btnLeft1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLeft1.Click
        lbCredit.Select()
        If AutorizationLevel = "Admin" Then
            Report.Show()
        End If
    End Sub

    Private Sub PictureBox1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        MsgBox(Encoding.ASCII.GetString(Encrypt("Worc", "Hello World", 48, 122, True)))
    End Sub

    Private Sub PictureBox1_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ActivateForm.ShowDialog()
    End Sub
End Class
