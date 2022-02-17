Imports System.IO

Module Configuration
    Sub DefaultConfig()
        Setting.Clear()
        Setting.Add("Server", "127.0.0.1")
        Setting.Add("Port", "9672")
        Setting.Add("BackgroundMode", "Image")
        WriteConfig(CurrPath & "/data/Settings.ini")
    End Sub

    Sub ReadConfig(ByVal filepath As String)
        UnlockSetting()
        If File.Exists(filepath) Then
            Try
                Using StreamR = New StreamReader(filepath, True)
                    Dim cSplit As Array
                    While StreamR.Peek
                        cSplit = StreamR.ReadLine().Split("=")
                        If cSplit.Length = 2 Then
                            If cSplit(0) <> "" And cSplit(1) <> "" Then
                                If Setting.ContainsKey(cSplit(0)) Then
                                    Setting(cSplit(0)) = cSplit(1)
                                Else
                                    Setting.Add(cSplit(0), cSplit(1))
                                End If
                            End If
                        End If
                    End While
                End Using
            Catch ex As Exception
                ErrorLog(SystemDateTime() & " -> " & ex.Message)
            End Try
        Else
            DefaultConfig()
        End If
        LockSetting()
    End Sub

    Sub WriteConfig(ByVal filepath As String)
        Try
            UnlockSetting()
            Using StreamW = New StreamWriter(filepath, False)
                For Each cfg In Setting
                    StreamW.WriteLine(cfg.Key & "=" & cfg.Value)
                Next
            End Using
            LockSetting()
        Catch ex As Exception
            ErrorLog(SystemDateTime() & " -> " & ex.Message)
        End Try
    End Sub

    Sub ErrorLog(ByVal log As String)
        Try
            Using sw As StreamWriter = New StreamWriter("./report/" & SystemDate() & ".log", True)
                sw.WriteLine(log)
            End Using
        Catch
        End Try
    End Sub
End Module
