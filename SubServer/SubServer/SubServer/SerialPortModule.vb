Imports System.IO.Ports
Imports System.Threading

Module SerialPortModule
    Function Connect2Serial(ByVal COM As String)
        Try
            CheckUpdate = True
            SlotStat = False
            CoinSlot.Dispose()
            CoinSlot.Close()
            With CoinSlot
                .DtrEnable = True
                .DataBits = 8
                .PortName = COM
                .BaudRate = 9600
                .ReadTimeout = 4000
                .Parity = Parity.None
                .StopBits = StopBits.One
                .Handshake = Handshake.None
                .Encoding = System.Text.Encoding.Default
            End With
            CoinSlot.Open()
            Return 1
        Catch ex As Exception
            Return 0
        End Try
    End Function

    Function Connect2Coin(ByVal COM As String)
        If Connect2Serial(COM) Then
            Try
                Thread.Sleep(2000)
                CoinSlot.WriteLine("WhoAmI")
                If "CoinTimer" = CoinSlot.ReadLine().Replace(vbCr, "") Then
                    CoinSlot.WriteLine("Worc")
                    If "9672" = CoinSlot.ReadLine().Replace(vbCr, "") Then
                        CheckUpdate = True
                        SlotStat = True
                        CoinSlot.ReadTimeout = -1
                        Return 1
                    End If
                End If
            Catch ex As Exception
                'Console.WriteLine("#Connect2Coin# : " & ex.Message & " " & COM)
                Return 0
            End Try
        End If
        'Console.WriteLine("#Connect2Coin# : Cannot Connect to " & COM)
        Return -1
    End Function

    'It will scan test all available Serial Ports
    Function ScanSerial()
        For Each COM In My.Computer.Ports.SerialPortNames
            If Connect2Serial(COM) Then
                Try
                    Thread.Sleep(2000)
                    CoinSlot.WriteLine("WhoAmI")
                    If "CoinTimer" = CoinSlot.ReadLine().Replace(vbCr, "") Then
                        Return COM
                    End If
                Catch
                End Try
            End If
        Next
        Return 0
    End Function

    'Test if Serial is Connected
    Sub CheckSerialConnection()
        Try
            CoinSlot.WriteLine("")
        Catch
            Try
                CoinSlot.Close()
            Catch
            End Try
        End Try
    End Sub

    'Sample Usage
    'Public Sub CoinConnect()
    '    Dim status = Connect2Coin(Setting("COM"))
    '    If status = 1 Then
    '        SerialReceive()
    '    Else
    '        Dim retry = True
    '        While retry
    '            Thread.Sleep(4000)
    '            Dim COM = ScanSerial()
    '            If COM <> "0" Then
    '                retry = False
    '                Setting("COM") = COM
    '                CoinConnect()
    '            End If
    '        End While
    '    End If
    'End Sub

    'Public Sub SerialReceive()
    '    If Not CoinSlot.IsOpen Then
    '        CoinSlot.Open()
    '    End If
    '    While CoinSlot.IsOpen
    '        Try
    '            Dim DataReceived As String
    '            DataReceived = CoinSlot.ReadLine()
    '            If DataReceived <> "" Then
    '                Console.WriteLine(DataReceived)
    '                ChangeTxt()
    '            End If

    '        Catch ex As Exception
    '            Console.WriteLine("#SerialReceive# : " & ex.Message)
    '        End Try
    '    End While
    '    CoinConnect()
    'End Sub
End Module
