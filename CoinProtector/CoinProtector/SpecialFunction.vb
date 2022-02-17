Imports System.Threading
Imports System.IO

Module SpecialFunction
    Public protection = True

    Function Myname()
        Dim appname = Path.GetFileName(Application.ExecutablePath)
        appname = appname.Substring(0, appname.LastIndexOf("."))
        Return appname
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

    Sub ProcessRestart(ByVal prc As String)
        Try
            Dim procs = Process.GetProcessesByName(prc)
            For Each p In procs
                p.Kill()
            Next

            Process.Start(prc)
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
                                             Try
                                                 Dim proce = Process.GetProcessesByName(prc)
                                                 If proce.Length = 0 Then
                                                     ProcessRestart(prc)
                                                 End If

                                                 For Each p In proce
                                                     p.WaitForExit()
                                                 Next
                                             Catch ex As Exception
                                             End Try

                                             Thread.Sleep(100)
                                         End While
                                     End Sub)
    End Sub
End Module
