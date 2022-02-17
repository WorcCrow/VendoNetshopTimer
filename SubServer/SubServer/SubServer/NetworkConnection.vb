Imports System.Net.Sockets
Imports System.Net
Imports System.Text
Imports System.Threading
Imports System.IO

Module NetworkConnection
    Public Client As TcpClient = New TcpClient
    Public NetStream As NetworkStream

    Public Server As TcpListener
    Public ConnStat As Boolean = False
    Public RefreshConnection As Boolean = False

    Function PortIsOpen(ByVal host As String, ByVal port As String)
        Try
            Dim C = New TcpClient(GetSetting("127.0.0.1"), CInt(GetSetting("Port")))
            C.Close()
            Return 1
        Catch ex As Exception
            'Console.WriteLine("#IsPortOpen# : " & ex.Message)
            Return 0
        End Try
    End Function

    Public Sub StartServer()
        Try
            Server = New TcpListener(IPAddress.Any, CInt(GetSetting("Port")))
            Server.Start()

            Threading.ThreadPool.QueueUserWorkItem(AddressOf NewClient)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Sub NewClient()
        'Waiting for New Client to Connect
        Dim RemoteClient As TcpClient = Server.AcceptTcpClient()
        Try
            'Console.WriteLine("Client : " & RemoteClient.Client.RemoteEndPoint.ToString.Split(":")(0) & " has been connected.")
            Threading.ThreadPool.QueueUserWorkItem(AddressOf NewClient)

            RefreshConnectedClient()
            IfDuplicate(RemoteClient)
            IfClient(RemoteClient)

            ReceiveFromClient(RemoteClient)
        Catch ex As Exception
            'If client is already connected then remove
        End Try
    End Sub

    Sub ReceiveFromClient(ByVal RemoteC As TcpClient)
        Dim NStream As NetworkStream = RemoteC.GetStream
        NStream.Flush()
        While True
            'Dim RecvData As StringBuilder = New StringBuilder
            Dim RecvData As String = Nothing
            If NStream.CanRead Then
                Dim RecvByte(1024) As Byte
                Dim DataSize As Integer = 0
                Do
                    DataSize = NStream.Read(RecvByte, 0, RecvByte.Length)
                    'RecvData.AppendFormat(Encoding.ASCII.GetString(RecvByte, 0, DataSize))
                    RecvData &= Encoding.ASCII.GetString(RecvByte, 0, DataSize)
                Loop While NStream.DataAvailable

                If RecvData.Length = 0 Then
                    RefreshConnectedClient()
                    Exit Sub
                Else
                    Dim CollectedData = RecvData.ToString.Split(";")
                    For Each dat In CollectedData
                        If dat <> "" Then
                            'DataReceive.Add(New ClientData.ClientDataSent(RemoteC, dat.ToString))
                            Dim a = Decrypt("*&@JF*4^%#", Encoding.ASCII.GetBytes(dat.ToString))
                            DataReceive.Add(New ClientData.ClientDataSent(RemoteC, a))
                        End If
                    Next
                End If
            End If
        End While
    End Sub

    Sub RefreshConnectedClient()
        'Make sure to remove all inactive client stream
        For Each IP In ConnectedClient.ToList
            Try
                Dim NStream As NetworkStream = IP.GetStream
                Dim Recv() As Byte = Encoding.ASCII.GetBytes(" ")
                'Dim Recv() As Byte = {0}
                NStream.Write(Recv, 0, Recv.Length)
            Catch ex As Exception
                ' Console.WriteLine("#Refresh Connected Client# : " & IP.Client.RemoteEndPoint.ToString.Split(":")(0) & " Kicked")
                ConnectedClient.Remove(IP)
            End Try
        Next
    End Sub

    Sub IfClient(ByVal RemoteC As TcpClient)
        'If the Remote Client is belong to the List of Client then Update Time
        Dim RemoteIP = RemoteC.Client.RemoteEndPoint.ToString.Split(":")(0)
        For Each item In clist
            If item.ip = RemoteIP Then
                Console.WriteLine("#If Client# : " & RemoteC.Client.RemoteEndPoint.ToString.Split(":")(0) & " Time Updated")
                SubmitData(RemoteC, "TIME:" & item.RemainingTick.ToString)
                SubmitData(RemoteC, "LIST:" & AvailableClient())
            End If
        Next
    End Sub

    Sub IfDuplicate(ByVal RemoteC As TcpClient)
        'If the attempting client has already a connection then kick
        Dim Duplicate As Boolean = False
        For Each IP In ConnectedClient
            If RemoteC.Client.RemoteEndPoint.ToString.Split(":")(0) = IP.Client.RemoteEndPoint.ToString.Split(":")(0) Then
                Duplicate = True
            End If
        Next
        If Duplicate = False Then
            'Console.WriteLine("#If Duplicate# : " & RemoteC.Client.RemoteEndPoint.ToString & " accepted")
            ConnectedClient.Add(RemoteC)
        Else
            'Console.WriteLine("#If Duplicate# : " & RemoteC.Client.RemoteEndPoint.ToString & " has an existing connection")
            RemoteC.Close()
        End If
    End Sub

    Function ListUnregClient()
        Try
            UnregClient.Clear()
            For Each RemoteC In ConnectedClient
                UnregClient.Add(RemoteC.Client.RemoteEndPoint.ToString.Split(":")(0))
            Next
            Dim temp As New List(Of String)
            For Each ug In UnregClient
                Dim notexist = True
                For Each c In clist
                    If c.ip = ug Then
                        notexist = False
                        Exit For
                    End If
                Next
                If notexist Then
                    temp.Add(ug)
                End If
            Next

            Return temp.ToArray
        Catch ex As Exception
            ErrorLog(SystemDateTime() & " -> " & ex.Message)
            Return 0
        End Try
    End Function

    Sub ConnectServer()
        While True
            If My.Computer.Network.Ping(GetSetting("127.0.0.1")) Then
                If PortIsOpen(GetSetting("Server"), GetSetting("Port")) Then
                    ConnStat = False
                    CheckUpdate = True
                    Try
                        Client = New TcpClient(GetSetting("127.0.0.1"), CInt(GetSetting("Port")))
                        NetStream = Client.GetStream
                        ConnStat = True
                        CheckUpdate = True
                        WaitForData()
                    Catch ex As Exception
                        ErrorLog(SystemDateTime() & " -> " & ex.Message)
                    End Try
                End If
            End If
            Thread.Sleep(4000)
        End While
    End Sub

    Sub WaitForData()
        NetStream = Client.GetStream
        NetStream.Flush()
        Dim RecvByte(1024) As Byte
        While True
            Dim MemStream As MemoryStream = New MemoryStream
            Dim RecvData() As Byte
            Using MemStream
                Do
                    NetStream.Read(RecvByte, 0, RecvByte.Length)
                    NetStream.Flush()
                    MemStream.Write(RecvByte, 0, RecvByte.Length)
                    RecvByte = New Byte(1024) {}
                Loop While NetStream.DataAvailable
                RecvData = MemStream.ToArray
                MemStream.Flush()
            End Using
            Dim RecvString As String = Encoding.ASCII.GetString(RecvData)
            Dim RecvArr As Array = RecvString.Split(Chr(0))
            RecvData = Encoding.ASCII.GetBytes(RecvArr(0))
            DataReceive.Add(New ClientData.ClientDataSent(Client, RecvString))
        End While
    End Sub

    Function SubmitData(ByVal RemoteC As TcpClient, ByVal MSG As String)
        Try
            Dim NStream As NetworkStream = RemoteC.GetStream
            'MSG = MSG & ";"
            MSG = Encoding.ASCII.GetString(Encrypt("*&@JF*4^%#",MSG)) & ";"
            NStream.Write(Encoding.ASCII.GetBytes(MSG), 0, MSG.Length)
            NStream.Flush()
            Return 1
        Catch ex As Exception
            ErrorLog(SystemDateTime() & " -> " & ex.Message)
            Return 0
        End Try
    End Function
End Module
