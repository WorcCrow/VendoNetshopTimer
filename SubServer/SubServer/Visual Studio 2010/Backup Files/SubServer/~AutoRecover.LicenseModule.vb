Imports System.Text


Module LicenseModule
    Public LicInfo As New Dictionary(Of String, String)
    Public RamainingDays As String = Nothing

    Sub StartupLicenseCheck()
        If GetSetting("LicenseCode") <> "0" Then
            While True
                Dim ULresult = UpdateLicense()
                Select Case ULresult
                    Case 0
                        SubServerUI.TSSLExpiryNotification.Text = "Registered"
                        Exit While
                    Case 1
                        MsgBox("Incorrect License Code : " & GetSetting("LicenseCode"))
                        LicenseCode.ShowDialog()
                        If LicenseCode.pressed = 2 Then
                            ApplicationClose()
                        End If
                    Case 2
                        MsgBox("REPUBLIC ACT NO. 10088 " & vbNewLine & "AN ACT TO PROHIBIT AND PENALIZE THE UNAUTHORIZED USE, POSSESSION AND/OR CONTROL OF AUDIOVISUAL RECORDING DEVICES FOR THE UNAUTHORIZED RECORDING OF CINEMATOGRAPHIC FILMS AND OTHER AUDIOVISUAL WORKS AND/OR THEIR SOUNDTRACKS IN AN EXHIBITION FACILITY, PROVIDING PENALTIES THEREFOR AND FOR OTHER PURPOSES")
                        Kill(".\key.lic")
                        Setting.Remove("LicenseCode")
                        WriteConfig("./data/Settings.ini")
                        ApplicationClose()
                    Case 4
                        SubServerUI.TSSLExpiryNotification.Text = "Your License is Expired"
                        ActivateForm.ShowDialog()
                    Case 8
                        SubServerUI.TSSLExpiryNotification.Text = "Evaluation ends in " & DaysLeft() & " days."
                        Exit While
                    Case 16
                        SubServerUI.TSSLExpiryNotification.Text = "Cannot read license key."
                        LicenseCode.ShowDialog()
                        If LicenseCode.pressed = 2 Then
                            ApplicationClose()
                        End If
                End Select
            End While
        Else
            LicenseCode.ShowDialog()
            If LicenseCode.pressed = 2 Then
                ApplicationClose()
            End If
            StartupLicenseCheck()
        End If
    End Sub

    Function UpdateLicense()
        Try
            Dim a As System.Net.WebClient = New System.Net.WebClient
           a.Headers.Add(HttpRequestHeader.Cookie, "somecookie");
            Dim webserver = GetSetting("WebServer")
            MsgBox("http://" & webserver & "/license/verify.php?code=" & GetSetting("LicenseCode") & "&machine=" & MachineId)
            Dim b = a.DownloadString("http://" & webserver & "/license/verify.php?code=" & GetSetting("LicenseCode") & "&machine=" & MachineId)

            Dim c = Decrypt("#fS1>:5hp3", Encoding.ASCII.GetBytes(b))
            MsgBox(c)
            If c <> "Invalid" Then
                Try
                    Kill(".\key.lic")
                Catch ex As Exception
                End Try
                a.DownloadFile(c, ".\key.lic")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        If LicenseFileExist() Then
            Return LoadLicense()
        Else
            Return 16
        End If
    End Function

    Function LicenseFileExist()
        Return IO.File.Exists("./key.lic")
    End Function

    Function LoadLicense()
        Dim a = IO.File.ReadAllBytes("./key.lic")
        Dim b = Decrypt("#fS1>:5hp3", a)
        b = b.Split(";")
        LicInfo.Clear()
        For Each c In b
            If c.Split("=").length = 2 Then
                LicInfo.Add(c.Split("=")(0), c.Split("=")(1))
                MsgBox(c.Split("=")(0) & " -> " & c.Split("=")(1))
            End If
        Next

        Return LicenseChecking()
    End Function

    Function LicenseChecking()
        Dim cstatus As Integer = 0
        If GetSetting("LicenseCode") <> GetLicInfo("LicenseCode") Then
            Return 1
        End If

        If IsSysNotMatch() Then
            Return 2
        End If

        If IsExpired() Then
            Return 4
        End If

        If IsNearExpiration() Then
            Return 8
        End If

        Return 0
    End Function

    Function IsSysNotMatch()
        If LicInfo("MachineID") <> My.Computer.Name Then
            Return 1
        End If
        Return 0
    End Function

    Function IsExpired()
        If DateToTick(LicInfo("Expiration")) <= DateToTick(Date.Now.Date) Then
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
        Try
            Dim a As Long = DateToTick(LicInfo("Expiration")) - DateToTick(Date.Now.Date)
            a *= 0.0000001
            a /= 86400
            Return a
        Catch ex As Exception
            Return 0
        End Try
    End Function

    Sub UpdateLicInfo(ByVal key As String, ByVal val As String)
        Try
            LicInfo.Add(key, val)
        Catch ex As Exception
            LicInfo(key) = val
        End Try
    End Sub

    Function GetLicInfo(ByVal key As String)
        Try
            Return LicInfo(key)
        Catch ex As Exception
            Return "0"
        End Try
    End Function
End Module
