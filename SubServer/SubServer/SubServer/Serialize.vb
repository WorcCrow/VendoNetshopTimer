Imports System.IO
Imports System.Runtime.Serialization.Formatters.Binary

Module Serialize
    Sub SaveData(ByVal path As String, ByRef obj As Object)
        Try
            Dim datafile As String = path
            Dim stream As FileStream = File.Create(datafile)
            Dim formatter As New BinaryFormatter
            formatter.Serialize(stream, obj)
            stream.Close()
        Catch ex As Exception
            ErrorLog(SystemDateTime() & " -> " & ex.Message)
        End Try
    End Sub

    Sub LoadData(ByVal filepath As String, ByRef obj As Object)
        Try
            If Directory.Exists(Path.GetDirectoryName(filepath)) Then
                Dim stream As FileStream
                Dim formatter As New BinaryFormatter
                Dim datafile As String = filepath
                If File.Exists(datafile) Then
                    stream = File.OpenRead(datafile)
                    obj = formatter.Deserialize(stream)
                    stream.Close()
                End If
            End If
        Catch ex As Exception
            ErrorLog(SystemDateTime() & " -> " & ex.Message)
        End Try
    End Sub

    Sub SaveClistData(ByVal path As String)
        Try
            Dim datafile As String = path
            Dim storage As String = Nothing
            For Each c In clist
                storage &= c.name & "," & c.ip & "," & c.starttime & "," & c.endtime & ";"
            Next
            Dim dat = Encrypt("#2a/;\_*(F", storage)

            Dim stream As FileStream = File.Create(datafile)
            Dim formatter As New BinaryFormatter
            stream.Write(dat, 0, dat.length)
            stream.Close()
        Catch ex As Exception
            ErrorLog(SystemDateTime() & " -> " & ex.Message)
        End Try
    End Sub

    Sub LoadClistData(ByVal filepath As String)
        Try
            If Directory.Exists(Path.GetDirectoryName(filepath)) Then
                clist.Clear()
                Dim loadbyte As Byte() = File.ReadAllBytes(filepath)
                Dim dec = (Decrypt("#2a/;\_*(F", loadbyte))
                For Each item In dec.split(";")
                    If item <> "" Then
                        Dim i = item.split(",")
                        clist.Add(New ClientData.ClientInfo(i(0), i(1), i(2), i(3)))
                    End If
                Next
                SubServerUI.dgvClientRefresh()
            End If
        Catch ex As Exception
            ErrorLog(SystemDateTime() & " -> " & ex.Message)
        End Try
    End Sub
End Module
