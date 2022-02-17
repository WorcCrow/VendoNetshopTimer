Imports System.IO
Imports System.Text
Imports System.Security.Cryptography
Imports System.Threading
Imports System.Runtime.InteropServices

Module SpecialFunction
    Public Sub ShutdownTimer()
        STThread.Abort()
        STThread = New Thread(Sub()
                                  STTime = GetSetting("OffTime")
                                  While LOCKSTAT
                                      If STTime <= 0 Then
                                          Try
                                              Dim a As Process = New Process
                                              a.StartInfo.FileName = "C:\Windows\System32\shutdown.exe"
                                              a.StartInfo.Arguments = "/f /s /t 0"
                                              a.StartInfo.UseShellExecute = False
                                              a.StartInfo.CreateNoWindow = True
                                              a.Start()
                                          Catch ex As Exception
                                          End Try
                                      Else
                                          STTime -= 1
                                      End If
                                      Thread.Sleep(1000)
                                  End While
                              End Sub)
        STThread.IsBackground = True
        STThread.Start()
    End Sub

    Public Sub FastLoad(ByVal obj As Object)
        obj.Visible = True
        obj.Refresh()
        For Each ctrl In obj.Controls
            ctrl.update()
        Next
    End Sub

    Public Sub TaskBar(ByVal active As Boolean)
        Dim hWnd As Long
        If active Then
            hWnd = FindWindow("Shell_TrayWnd", "")
            ShowWindow(hWnd, 5)
            hWnd = FindWindow("Button", "Start")
            ShowWindow(hWnd, 5)
        Else
            hWnd = FindWindow("Shell_TrayWnd", "")
            ShowWindow(hWnd, 0)
            hWnd = FindWindow("Button", "Start")
            ShowWindow(hWnd, 0)
        End If
    End Sub

    Public Sub DisableSpecialKey()
        Try
            Dim objCurrentModule As ProcessModule = Process.GetCurrentProcess().MainModule
            objKeyboardProcess = New LowLevelKeyboardProc(AddressOf CaptureKey)
            ptrHook = SetWindowsHookEx(13, objKeyboardProcess, GetModuleHandle(objCurrentModule.ModuleName), 0)
        Catch ex As Exception
        End Try
    End Sub

    Public Sub EnableSpecialKey()
        Try
            UnhookWindowsHookEx(ptrHook)
        Catch ex As Exception
        End Try
    End Sub

    Public Sub FlushMemory()
        Try
            GC.Collect()
            GC.WaitForPendingFinalizers()
            If (Environment.OSVersion.Platform = PlatformID.Win32NT) Then
                SetProcessWorkingSetSize(Process.GetCurrentProcess().Handle, -1, -1)
                Dim myProcesses As Process() = Process.GetProcessesByName("ApplicationName")
                Dim myProcess As Process
                'Dim ProcessInfo As Process
                For Each myProcess In myProcesses
                    SetProcessWorkingSetSize(myProcess.Handle, -1, -1)
                Next myProcess
            End If
        Catch ex As Exception
        End Try
    End Sub

    Sub ForceMaximize()
        MoveWindow(lockhWnd, 0, 0, FixBWidth, FixBHeight, True)
        MoveWindow(blankhWnd, 0, 0, FixBWidth, FixBHeight, True)
    End Sub

    Sub MinimizeAll()
        For Each p In Process.GetProcesses
            If p.MainWindowTitle <> "" And p.MainWindowTitle <> "Timer" And p.MainWindowTitle <> "Windows Task Manager" Then
                ShowWindow(FindWindow(Nothing, p.MainWindowTitle), 11)
            End If
        Next
    End Sub

    Sub LockSetting()
        Try
            LockFile = File.Open("./data/Settings.ini", FileMode.OpenOrCreate)
        Catch ex As Exception
        End Try
    End Sub

    Sub UnlockSetting()
        Try
            LockFile.Close()
        Catch ex As Exception
        End Try
    End Sub

    Function MyName()
        Try
            Dim appname = Path.GetFileName(Application.ExecutablePath)
            appname = appname.Substring(0, appname.LastIndexOf("."))
            Return appname
        Catch ex As Exception
            Return 0
        End Try
    End Function

    Function ProcessRunning(ByVal prc As String)
        Try
            Dim procs = Process.GetProcessesByName(prc)
            For Each p In procs
                Return 1
            Next
            Return 0
        Catch ex As Exception
            Return 0
        End Try
    End Function

    Sub ProcessRestart(ByVal prc As String, Optional ByVal arg As String = "")
        Dim procs = Process.GetProcessesByName(prc)
        For Each p In procs
            p.Kill()
        Next
        Try
            Process.Start(prc, arg)
        Catch ex As Exception
        End Try
    End Sub

    Sub ProcessKill(ByVal prc As String)
        Try
            Dim procs = Process.GetProcessesByName(prc)
            For Each p In procs
                p.Kill()
            Next
        Catch ex As Exception
        End Try
    End Sub

    Sub ProtectProcess(ByVal prc As String)
        ThreadPool.QueueUserWorkItem(Sub()
                                         While protection
                                             Dim proce = Process.GetProcessesByName(prc)
                                             If proce.Length = 0 Then
                                                 ProcessRestart(prc, MyName)
                                             End If

                                             For Each p In proce
                                                 p.WaitForExit()
                                             Next
                                             Thread.Sleep(100)
                                         End While
                                     End Sub)
    End Sub

    Sub CreateDirectory(ByVal directorypath As String)
        If Not Directory.Exists(directorypath) Then
            Directory.CreateDirectory(directorypath)
        End If
    End Sub

    Function GetFileName(ByVal path As String)
        Return path.Substring(path.LastIndexOf("\") + 1)
    End Function

    Sub UpdateSetting(ByVal key As String, ByVal val As String)
        Try
            Setting.Add(key, val)
        Catch ex As Exception
            Setting(key) = val
        End Try
    End Sub

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

    Function GetSetting(ByVal key As String)
        Try
            Return Setting(key)
        Catch ex As Exception
            Return "0"
        End Try
    End Function

    Public Sub HorizontalCenterAlign(ByVal label As Windows.Forms.Label, ByVal parent As Object)
        label.Location = New Point((parent.Size.Width / 2) - label.Size.Width / 2, label.Location.Y)
    End Sub

    Public Sub ButtonStyle(ByVal obj As Windows.Forms.Button)
        AddHandler obj.MouseEnter, Sub()
                                       obj.Font = New Font(obj.Font, FontStyle.Bold Or FontStyle.Underline)
                                   End Sub
        AddHandler obj.MouseLeave, Sub()
                                       obj.Font = New Font(obj.Font, FontStyle.Regular)
                                   End Sub
    End Sub

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

    Public Function SecToTime(ByVal sec As Integer)
        Dim hour, min
        If sec < 0 Then
            sec = 0
        End If
        If sec >= 3600 Then
            hour = sec \ 3600
            hour = If(hour.ToString.Length = 2, hour, "0" & hour)
            sec = sec - (hour * 3600)
        Else
            hour = "00"
        End If
        If sec >= 60 Then
            min = sec \ 60
            min = If(min.ToString.Length = 2, min, "0" & min)
            sec = sec - (min * 60)
        Else
            min = "00"
        End If
        Return hour & ":" & min & ":" & If(sec.ToString.Length = 2, sec, "0" & sec)
    End Function

    Function SystemTick()
        Return DateTime.Now.Ticks
    End Function

    Function SystemDateTime()
        Return DateTime.Now.ToString("G")
    End Function

    Function SystemDate()
        Return DateTime.Now.ToString("M-d-yyyy")
    End Function

    Private Structure KBDLLHOOKSTRUCT
        Public key As Keys
        Public scanCode As Integer
        Public flags As Integer
        Public time As Integer
        Public extra As IntPtr
    End Structure
    Public Delegate Function LowLevelKeyboardProc(ByVal nCode As Integer, ByVal wParam As IntPtr, ByVal lParam As IntPtr) As IntPtr
    Private Function CaptureKey(ByVal nCode As Integer, ByVal wp As IntPtr, ByVal lp As IntPtr) As IntPtr
        Try
            If nCode >= 0 Then
                Dim objKeyInfo As KBDLLHOOKSTRUCT = DirectCast(Marshal.PtrToStructure(lp, GetType(KBDLLHOOKSTRUCT)), KBDLLHOOKSTRUCT)
                'Console.WriteLine(objKeyInfo.key)

                If objKeyInfo.key = 9 Then
                    ' Disabling Tab keys
                    Return CType(1, IntPtr)
                End If

                If objKeyInfo.key = 46 Then
                    ' Disabling Tab keys
                    Return CType(1, IntPtr)
                End If

                If objKeyInfo.key = 115 Then
                    ' Disabling Tab keys
                    Return CType(1, IntPtr)
                End If

                If objKeyInfo.key = 91 OrElse objKeyInfo.key = 92 Then
                    ' Disabling Windows keys
                    Return CType(1, IntPtr)
                End If

                If objKeyInfo.key = 162 OrElse objKeyInfo.key = 163 Then
                    ' Disabling Ctrl Keys
                    Return CType(1, IntPtr)
                End If

                If objKeyInfo.key = 164 OrElse objKeyInfo.key = 165 Then
                    ' Disabling Ctrl Keys
                    Return CType(1, IntPtr)
                End If
            End If
            Return CallNextHookEx(ptrHook, nCode, wp, lp)
        Catch ex As Exception
        End Try
    End Function
End Module
