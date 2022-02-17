Imports System.IO
Imports System.Threading
Imports System.Threading.Tasks

Public Class MainControl

    Private Sub MainControl_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ExecuteSetup()
        ExecuteThread()
        niSystemTray.Visible = False
        Me.Location = New Point(WAWidth - Me.Width, WAHeight - Me.Height)

        FastLoad(Me)
    End Sub

    Private Sub niSystemTray_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles niSystemTray.DoubleClick
        ShowForm()
    End Sub

    Private Sub MainControl_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If FormClose Then
            TaskBar(True)
            FormClose = False
        Else
            e.Cancel = True
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        SubmitData(Client, "LOGOUT:TRUE")
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Chatroom.Show()
    End Sub

    Private Sub MainControl_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        If Me.WindowState = FormWindowState.Minimized Then
            Me.Hide()
            niSystemTray.Visible = True
        End If
    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub BChatroom_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnChat.Click
        lTime.Focus()
        Chatroom.Show()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        lTime.Focus()
        Confirm = Nothing
        Confirmation.ShowDialog()
        If Confirm = 1 Then
            MsgBox("Logout Confirmed!")
            SubmitData(Client, "LOGOUT:TRUE")
            CurrTime = 0
        ElseIf Confirm = 0 Then
            MsgBox("Logout Failed!")
        End If
    End Sub

    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSwap.Click
        lTime.Focus()
        If Ping(GetSetting("Server")) Then
            If UnitList.Count Then
                SwapingForm.Show()
            End If
        Else
            MsgBox("Server Offline")
        End If
    End Sub

    Private Sub Button2_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Confirm = -1
        ConfirmMode = "SetPassLock"
        ConfirmPassword.ShowDialog()

        If Confirm = 1 Then
            LOCKSTAT = True
            UpdateLock()
        ElseIf Confirm = 0 Then
            MsgBox("Password Cannot be Empty")
        End If
    End Sub

    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    'Functions and Sub
    Sub StartProtector()
        If Not File.Exists("./CoinProtector.exe") Then
            File.WriteAllBytes("./CoinProtector.exe", My.Resources.CoinProtector)
        End If
        protection = True
        ProcessKill("CoinProtector")
        ProtectProcess("CoinProtector")
    End Sub

    Sub ExecuteThread()
        'StartProtector()

        Dim CountStart As Thread = New Threading.Thread(AddressOf CountDown)
        CountStart.IsBackground = True
        CountStart.Start()

        Dim statusupdater As Thread = New Threading.Thread(AddressOf StatusCheck)
        statusupdater.IsBackground = True
        statusupdater.Start()

        Dim conn As Thread = New Threading.Thread(AddressOf ConnectServer)
        conn.IsBackground = True
        conn.Start()

        Dim Prcss As Thread = New Threading.Thread(AddressOf ProcessData)
        Prcss.IsBackground = True
        Prcss.Start()

    End Sub

    Sub ExecuteSetup()
        MakePanelDragable(PTitlebar, Me)
        CreateDirectory("./data")
        CreateDirectory("./log")
        ReadConfig(CurrPath & "/data/Settings.ini")
    End Sub

    Sub ProcessData()
        While True
            If DataReceive.Count Then
                Dim DataArr As Array = DataReceive(0).dat.Split(New Char() {":"c}, 2)
                If DataArr.Length = 2 Then
                    ProcessReceive(DataArr(0), DataArr(1))
                    DataReceive.RemoveAt(0)
                Else
                    DataReceive.RemoveAt(0)
                End If
            End If
            Thread.Sleep(1)
        End While
    End Sub

    Sub ProcessReceive(ByVal Comm As String, ByVal Val As String)
        Select Case Comm
            Case "PASS"
                UpdateSetting("Password", Val)
                WriteConfig(CurrPath & "/data/Settings.ini")
            Case "TIME"
                CurrTime = Val
            Case "LIST"
                UnitList.Clear()
                For Each unit In Val.Split(",")
                    Dim unitsplit = unit.Split(":")
                    If unitsplit.Length = 2 Then
                        UnitList.Add(New ClientData.AvailableUnit(unitsplit(0), unitsplit(1)))
                    End If
                Next
            Case "CHAT"
                BeginInvoke(Sub()
                                Chatroom.rtbChatroom.Text &= Val & vbNewLine
                            End Sub)
        End Select
    End Sub

    Sub StatusCheck()
        While True
            If CheckUpdate Then
                CheckUpdate = False
                StatusUpdate()
            End If
            Thread.Sleep(1)
        End While
    End Sub

    Sub StatusUpdate()
        If InvokeRequired Then
            Invoke(New MethodInvoker(AddressOf StatusUpdate))
        Else
            If ConnStat Then
                lbConStatus.ForeColor = Color.Green
                lbConStatus.Text = "Connected"
                btnSwap.BackgroundImage = My.Resources.SwapIcon
                btnSwap.Enabled = True
                btnChat.BackgroundImage = My.Resources.ChatIcon2
                btnChat.Enabled = True
            Else
                lbConStatus.ForeColor = Color.Red
                lbConStatus.Text = "Disconnected"
                btnSwap.BackgroundImage = My.Resources.SwapIconDisable
                btnSwap.Enabled = False
                btnChat.BackgroundImage = My.Resources.ChatIcon2Disable
                btnChat.Enabled = False
                Chatroom.Close()
            End If
        End If
    End Sub

    Sub CountDown()
        Try
            LOCKSTAT = True
            UpdateLock()
            While True
                If CurrTime > 0 Then
                    LOCKSTAT = False
                    UpdateLock()
                    While CurrTime > 0
                        UpdateTimeDisplay()
                        CurrTime -= 1
                        Thread.Sleep(1000)
                    End While
                    LOCKSTAT = True
                    UpdateLock()
                End If
                Thread.Sleep(1000)
            End While
        Catch ex As Exception
            Console.WriteLine()
        End Try
    End Sub

    Sub UpdateTimeDisplay()
        If Me.InvokeRequired Then
            Me.Invoke(New MethodInvoker(AddressOf UpdateTimeDisplay))
        Else
            If UnitList.Count > 0 Then
                If ConnStat Then
                    btnSwap.BackgroundImage = My.Resources.SwapIcon
                    btnSwap.Enabled = True
                End If
            Else
                btnSwap.BackgroundImage = My.Resources.SwapIconDisable
                btnSwap.Enabled = False
            End If
            PBTime.Value = ((CurrTime Mod 60) * 100) / 60
            'PBTime.Value = CurrTime \ 60
            lTime.Text = SecToTime(CurrTime)
            niSystemTray.Text = "Time Left: " & SecToTime(CurrTime) & vbNewLine & "Status: " & lbConStatus.Text
        End If
    End Sub

    Sub UpdateLock()
        BeginInvoke(Sub()
                        If LOCKSTAT Then
                            TaskBar(False)
                            Me.Hide()
                            BlankForm.UnlockTSMI.Visible = False
                            LockScreen.Show()
                            ConfirmPassword.Close()
                            MinimizeAll()
                            DisableSpecialKey()
                            ShutdownTimer()
                        Else
                            TaskBar(True)
                            MinimizeThread.Abort()
                            FormClose = True
                            LockScreen.Dispose()
                            FormClose = True
                            BlankForm.Dispose()

                            FlushMemory()
                            FormClose = False
                            Me.Show()
                            EnableSpecialKey()
                        End If
                    End Sub)
    End Sub

    Sub ShowForm()
        Me.Show()
        Me.WindowState = FormWindowState.Normal
        niSystemTray.Visible = False
    End Sub
End Class
