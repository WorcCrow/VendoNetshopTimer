Imports System.Threading
Imports System.IO

Module GlobalDeclaration
    Public CheckUpdate As Boolean = True
    Public DataReceive As New List(Of ClientData.ClientDataSent)
    Public UnitList As New List(Of ClientData.AvailableUnit)

    Public CurrPath As String = My.Application.Info.DirectoryPath

    Public random As New Random

    Public lockhWnd As IntPtr = Nothing
    Public blankhWnd As IntPtr = Nothing

    Public SlideThread As Thread = New Thread(Sub()
                                              End Sub)

    Public MinimizeThread As Thread = New Thread(Sub()
                                                 End Sub)

    Public STTime As Integer = 0

    Public STThread As Thread = New Thread(Sub()
                                           End Sub)

    Public ConfirmMode As String = Nothing

    Public protection As Boolean = False

    Public Setting As New Dictionary(Of String, String)

    Public LockFile As FileStream

    Public LOCKSTAT As Boolean = True
    Public LockPassword As String = Nothing

    Public FormClose As Boolean = False

    Public CurrTime As Integer = 0

    Public WAWidth As Integer = My.Computer.Screen.WorkingArea.Width
    Public WAHeight As Integer = My.Computer.Screen.WorkingArea.Height

   
    Public BWidth As Integer = My.Computer.Screen.Bounds.Width
    Public BHeight As Integer = My.Computer.Screen.Bounds.Height
    Public FixBWidth As Integer = BWidth
    Public FixBHeight As Integer = BHeight

    Public FullScreenSize = New Point(FixBWidth, FixBHeight)


    Public dateToday As String = Date.Now.ToString("dd-MM-yyyy")
    Public timeToday As String = Date.Now.ToString("T")

    Public KeyProcess As Process

    Public MouseX = 0
    Public MouseY = 0
    Public FormMove = False

    Public Confirm As Integer = Nothing


    Public ptrHook As IntPtr
    Public objKeyboardProcess As LowLevelKeyboardProc
End Module
