Imports System.Net.Sockets

Public Class ClientData

    <Serializable()>
    Public Class ClientInfo
        Public name As String
        Public ip As String
        Public starttime As Long
        Public endtime As Long
        'Public arr As Array

        Public Sub New(ByVal name As String, ByVal ip As String, ByVal starttime As Long, ByVal endtime As Long)
            Me.name = name
            Me.ip = ip
            Me.starttime = starttime
            Me.endtime = endtime
            'Me.arr = arr
        End Sub

        Public Sub New()
        End Sub

        Public Sub AddTime(ByVal sec As Long)
            If Me.endtime < DateTime.Now.Ticks Then
                Me.starttime = DateTime.Now.Ticks
                Me.endtime = DateTime.Now.Ticks + (sec * 10000000)
            Else
                Me.endtime = Me.endtime + (sec * 10000000)
            End If
        End Sub

        Public Sub Logout()
            Me.starttime = Nothing
            Me.endtime = Nothing
        End Sub

        Public Sub SwapTime(ByVal src As ClientInfo)
            Dim temp As ClientInfo = New ClientInfo
            temp.starttime = Me.starttime
            temp.endtime = Me.endtime
            Me.starttime = src.starttime
            Me.endtime = src.endtime
            src.starttime = temp.starttime
            src.endtime = temp.endtime
        End Sub

        Public Function Started()
            If starttime <> 0 Then
                Return New Date(starttime).ToString("T")
            Else
                Return ""
            End If
        End Function

        Public Function RemainingTime()
            Return SecToTime(RemainingTick())
        End Function

        Public Function RemainingTick()
            If Me.endtime > DateTime.Now.Ticks Then
                Dim ret As Long = System.Math.Floor((Me.endtime - DateTime.Now.Ticks) / 10000000)
                Return ret
            Else
                Return 0
            End If
        End Function
    End Class

    Public Class ClientDataSent
        Public RemoteC As TcpClient
        Public dat As String

        Public Sub New(ByVal RemoteC As TcpClient, ByVal dat As String)
            Me.RemoteC = RemoteC
            Me.dat = dat
        End Sub

        Public Sub New()
        End Sub
    End Class
End Class
