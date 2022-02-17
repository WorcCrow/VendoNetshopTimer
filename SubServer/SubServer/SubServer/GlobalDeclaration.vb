Imports System.Net.Sockets
Imports System.IO.Ports
Imports System.Threading


Module GlobalDeclaration
    Public screenWidth As Integer = My.Computer.Screen.WorkingArea.Width
    Public screenHeight As Integer = My.Computer.Screen.WorkingArea.Height

    Public FadeFor As String

    Public MouseX = 0
    Public MouseY = 0
    Public FormMove = False

    Public AutorizationLevel = "Operator"


    Public totalCredit As Integer

    'List of Registered Client
    Public clist As New List(Of ClientData.ClientInfo)

    'List of Connected Client
    Public ConnectedClient As New List(Of TcpClient)

    'List of Registered Client
    Public UnregClient As New List(Of String)

    'List of Receive Data from Client
    Public DataReceive As New List(Of ClientData.ClientDataSent)



    'List of Report from File Log
    Public DataReport As New List(Of String)

    'Password Result after Confirmation
    Public PassResult As String

    'Trigger an Update on True
    Public CheckUpdate As Boolean = True



    'SerialPort for CoinSlot
    Public CoinSlot As SerialPort = New SerialPort

    'Connection Status of CoinSlot
    Public SlotStat As Boolean = False

    'Thread for Reading from CoinSlot
    Public ReadSlot As Thread

    'Machine ID
    Public MachineId As String = My.Computer.Name
End Module
