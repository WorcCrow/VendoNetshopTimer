Imports System.IO
Imports System.Text

Module Configuration
    Public Setting As New Dictionary(Of String, String)

    Sub DefaultConfig()
        Setting.Clear()
        Setting.Add("WebServer", "192.168.0.245")
        Setting.Add("SPass", GetHash("admin"))
        Setting.Add("CPass", GetHash("admin"))
        Setting.Add("Server", "127.0.0.1")
        Setting.Add("Port", "9672")
        Setting.Add("FullScreen", "True")
        Setting.Add("COM", "COM3")
        Setting.Add("LicenseCode", "984532181971321865")
    End Sub

    Sub ReadConfig(ByVal path As String)
        If File.Exists(path) Then
            Dim cSplit As Array
            If System.IO.File.Exists(path) = True Then
                Dim fileReader As System.IO.StreamReader
                fileReader = My.Computer.FileSystem.OpenTextFileReader(path)
                Using fileReader
                    While fileReader.Peek() >= 0
                        cSplit = fileReader.ReadLine().Split("=")
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
            End If
        Else
            DefaultConfig()
        End If
    End Sub

    Sub WriteConfig(ByVal filepath As String)
        Try
            Using SW As StreamWriter = New StreamWriter(filepath, False)
                For Each cfg In Setting
                    SW.WriteLine(cfg.Key & "=" & cfg.Value)
                Next
            End Using
        Catch ex As Exception
            ErrorLog(SystemDateTime() & " -> " & ex.Message)
        End Try
    End Sub

    Sub LoadDataFile(ByVal path As String, ByVal obj As Object)
        Try
            If Not File.Exists(path) Then
                Exit Sub
            End If

            Dim filebyte As Byte() = File.ReadAllBytes(path)
            Dim fileascii = Decrypt("Worc", filebyte)

            If fileascii = "-1" Then
                File.Delete(path)
                Exit Sub
            End If

            filebyte = Encoding.ASCII.GetBytes(fileascii)

            obj.Clear()
            Dim SBTemp As StringBuilder = New StringBuilder
            Using MS As MemoryStream = New MemoryStream(filebyte)
                While True
                    Dim byt As String = MS.ReadByte
                    If byt = -1 Then
                        obj.Add(SBTemp.ToString)
                        SBTemp = New StringBuilder
                        Exit While
                    End If
                    If Chr(byt) = ";" Then
                        obj.Add(SBTemp.ToString)
                        SBTemp = New StringBuilder
                    Else
                        SBTemp.Append(Chr(byt))
                    End If
                End While
            End Using
        Catch ex As Exception
            ErrorLog(SystemDateTime() & " -> " & ex.Message)
        End Try
    End Sub

    Sub UpdateDataFile(ByVal filepath As String, ByVal dat As String)
        Try
            If Not Directory.Exists(Path.GetDirectoryName(filepath)) Then
                Directory.CreateDirectory(filepath)
            End If
            Dim a = Encrypt("Worc", dat & ";")
            My.Computer.FileSystem.WriteAllBytes(filepath, a, True)
        Catch ex As Exception
            ErrorLog(SystemDateTime() & " -> " & ex.Message)
        End Try
    End Sub

    Sub ErrorLog(ByVal log As String)
        Try
            Using sw As StreamWriter = New StreamWriter("./log/" & SystemDate() & ".log", True)
                sw.WriteLine(log)
            End Using
        Catch 
        End Try
    End Sub
End Module

