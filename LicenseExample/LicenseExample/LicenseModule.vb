Imports System.Text


Module LicenseModule
    Public key As New Dictionary(Of String, String)
    Public RamainingDays As String = Nothing

    Sub UpdateLicense()
        Dim a As System.Net.WebClient = New System.Net.WebClient
        Dim b = a.DownloadString("http://127.0.0.1/CloudServer/cgi/validate.php?key=984532181971321865")
        If b <> "Try Again Later" Then
            Dim c = Decrypt("#fS1>:5hp3", Encoding.ASCII.GetBytes(b))
            a.DownloadFile(c, ".\key.lic")
        End If

        LoadLicense()
    End Sub

    Sub LoadLicense()
        Dim a = IO.File.ReadAllBytes("./key.lic")
        Dim b = Decrypt("#fS1>:5hp3", a).Split(";")

        key.Clear()
        For Each c In b
            If c.Split("=").length = 2 Then
                key.Add(c.Split("=")(0), c.Split("=")(1))
            End If
        Next

        Select Case LicenseChecking()
            Case 1
                MsgBox("REPUBLIC ACT NO. 10088 " & vbNewLine & "AN ACT TO PROHIBIT AND PENALIZE THE UNAUTHORIZED USE, POSSESSION AND/OR CONTROL OF AUDIOVISUAL RECORDING DEVICES FOR THE UNAUTHORIZED RECORDING OF CINEMATOGRAPHIC FILMS AND OTHER AUDIOVISUAL WORKS AND/OR THEIR SOUNDTRACKS IN AN EXHIBITION FACILITY, PROVIDING PENALTIES THEREFOR AND FOR OTHER PURPOSES")
            Case 2
                MsgBox("Your License Expired")
            Case 4
                MsgBox("Your License Will Expire on " & DaysLeft() & " days")
        End Select
    End Sub

    Function LicenseChecking()
        Dim cstatus As Integer = 0
        If IsSysNotMatch() Then
            Return 1
        End If

        If IsExpired() Then
            Return 2
        End If

        If IsNearExpiration() Then
            Return 4
        End If

        Return 0
    End Function

    Function IsSysNotMatch()
        If key("ComputerName") <> My.Computer.Name Then
            Return 1
        End If
        Return 0
    End Function

    Function IsExpired()
        If DateToTick(key("Expiration")) <= DateToTick(Date.Now.Date) Then
            Return 1
        End If
        Return 0
    End Function

    Function IsNearExpiration()
        If DaysLeft() <= 5 Then
            Return 1
        End If
        Return 0
    End Function

    Function DateToTick(ByVal a As String)
        Dim b = a.Split("/")
        Return New Date(b(2), b(0), b(1)).Ticks
    End Function

    Function DaysLeft()
        Dim a As Long = DateToTick(key("Expiration")) - DateToTick(Date.Now.Date)
        a *= 0.0000001
        a /= 86400
        Return a
    End Function
End Module
