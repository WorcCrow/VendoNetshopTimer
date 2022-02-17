Imports System.Net.Sockets
Imports System.Threading
Imports System.Text
Imports System.IO
Imports System.Net

Module NetworkConnection
    Public Client As TcpClient = New TcpClient
    Public NetStream As NetworkStream

    Public Server As TcpListener
    Public ConnStat As Boolean = False
    Public RefreshConnection As Boolean = False

    Function PortIsOpen(ByVal host As String, ByVal port As String)
        Try
            Dim C = New TcpClient(Setting("Server"), CInt(Setting("Port")))
            C.Close()
            Return 1
        Catch ex As Exception
            Console.WriteLine("#IsPortOpen# : " & ex.Message)
            Return 0
        End Try
    End Function

    Sub ConnectServer()
        While True
            If Ping(GetSetting("Server")) Then
                ConnStat = False
                CheckUpdate = True
                Try
                    Client = New TcpClient(Setting("Server"), CInt(Setting("Port")))
                    NetStream = Client.GetStream
                    ConnStat = True
                    CheckUpdate = True
                    WaitForData()
                Catch ex As Exception
                    Console.WriteLine("#Connect Server# :" & ex.Message)
                End Try
            End If
            Thread.Sleep(4000)
        End While
    End Sub

    Function Ping(ByVal server As String)
        Try
            Return My.Computer.Network.Ping(server)
        Catch ex As Exception
            Return 0
        End Try
    End Function

    Sub WaitForData()
        NetStream = Client.GetStream
        NetStream.Flush()

        While True
            If Client.Connected Then
                'Dim RecvData As StringBuilder = New StringBuilder
                Dim RecvData As String = Nothing
                If NetStream.CanRead Then
                    Dim RecvByte(1024) As Byte
                    Dim DataSize As Integer = 0
                    Do
                        DataSize = NetStream.Read(RecvByte, 0, RecvByte.Length)
                        'RecvData.Append(Encoding.ASCII.GetString(RecvByte, 0, DataSize))
                        RecvData &= Encoding.ASCII.GetString(RecvByte, 0, DataSize)
                    Loop While NetStream.DataAvailable


                    If RecvData.Length = 0 Then
                        If CheckConnection(Client) Then
                            Exit Sub
                        End If
                    Else
                        Dim CollectedData = RecvData.ToString.Split(";")
                        For Each dat In CollectedData
                            If dat <> "" Then
                                'DataReceive.Add(New ClientData.ClientDataSent(Client, dat.ToString))
                                Dim a = Decrypt("*&@JF*4^%#", Encoding.ASCII.GetBytes(dat.ToString))
                                DataReceive.Add(New ClientData.ClientDataSent(Client, a))
                            End If
                        Next
                    End If
                End If
            End If
        End While
    End Sub

    Sub ClearString(ByVal str As String)
        For Each c In str
            If Asc(c) >= 32 And Asc(c) <= 126 Then

            End If
        Next
    End Sub

    Function CheckConnection(ByVal RemoteC As TcpClient)
        'Check if the Server is still active
        Try
            Dim NStream As NetworkStream = RemoteC.GetStream
            Dim Recv() As Byte = Encoding.ASCII.GetBytes(" ")
            NStream.Write(Recv, 0, Recv.Length)
            Return 1
        Catch ex As Exception
            Console.WriteLine("#Check Connection# : Disconnected from" & RemoteC.Client.RemoteEndPoint.ToString.Split(":")(0))
            RemoteC.Close()
            Return 0
        End Try
    End Function

    Function SubmitData(ByVal RemoteC As TcpClient, ByVal MSG As String)
        Try
            Dim NStream As NetworkStream = RemoteC.GetStream
            'MSG = MSG & ";"
            MSG = Encoding.ASCII.GetString(Encrypt("*&@JF*4^%#", MSG)) & ";"
            NStream.Write(Encoding.ASCII.GetBytes(MSG), 0, MSG.Length)
            NStream.Flush()
            Return 1
        Catch ex As Exception
            ErrorLog(SystemDateTime() & " -> " & ex.Message)
            Return 0
        End Try
    End Function
End Module
