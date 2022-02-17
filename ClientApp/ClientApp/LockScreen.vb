Imports System.Threading
Imports WMPLib

Public Class LockScreen
    Private Sub LockScreen_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If FormClose Then
            MinimizeThread.Abort()
            FormClose = False
        Else
            e.Cancel = True
        End If
    End Sub

    Private Sub LockScreen_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ExecuteSetup()
        ExecuteThread()
    End Sub

    Public Sub ExecuteSetup()
        lockhWnd = Me.Handle
        blankhWnd = BlankForm.Handle

        Dim opacity = GetSetting("Transparency")
        If opacity < 100 Then
            If opacity = 0 Then
                UpdateSetting("Transparency", 100)
                Me.Opacity = 1
            Else
                Me.Opacity = GetSetting("Transparency") / 100
            End If
        Else
            Me.Opacity = 1
        End If

        Try
            Select Case Setting("BackgroundMode")
                Case "Image"
                    pbImage.BringToFront()
                    ImageMode()
                Case "Video"
                    AWMVideo.BringToFront()
                    VideoMode()
                Case "None"

            End Select
        Catch ex As Exception
        End Try
    End Sub

    Sub ExecuteThread()
        MinimizeThread.Abort()
        MinimizeThread = New Threading.Thread(Sub()
                                                  While True
                                                      'MinimizeAll()
                                                      ForceMaximize()
                                                      Thread.Sleep(1000)
                                                  End While
                                              End Sub)
        MinimizeThread.IsBackground = True
        MinimizeThread.Start()

        ThreadPool.QueueUserWorkItem(Sub()
                                         While True
                                             If Me.Visible Then
                                                 BeginInvoke(Sub()
                                                                 BlankForm.ShowDialog()
                                                             End Sub)
                                                 Exit While
                                             End If
                                             Thread.Sleep(1)
                                         End While
                                     End Sub)
    End Sub

    Sub VideoMode()
        SlideThread.Abort()
        AWMVideo.uiMode = "none"
        AWMVideo.stretchToFit = True
        Try
            If Setting("Mute") Then
                AWMVideo.settings.volume = 0
            Else
                AWMVideo.settings.volume = 100
            End If
        Catch ex As Exception
            AWMVideo.settings.volume = 100
        End Try

        Dim video = Setting("VideoList").Split(";")

        If video.Length > 2 Then
            SlideThread = New Thread(Sub()
                                         While LOCKSTAT
                                             For Each v In video
                                                 AWMVideo.URL = v
                                                 While True
                                                     If AWMVideo.playState = 10 Or AWMVideo.playState = 1 Then
                                                         Exit While
                                                     End If
                                                     Thread.Sleep(1000)
                                                 End While
                                             Next
                                             Thread.Sleep(1)
                                         End While
                                     End Sub)
            SlideThread.IsBackground = True
            SlideThread.Start()
        Else
            AWMVideo.settings.setMode("loop", True)
            AWMVideo.URL = video(0)
        End If
    End Sub

    Sub ImageMode()
        SlideThread.Abort()
        AWMVideo.Ctlcontrols.stop()
        Try
            Dim images As New List(Of String)
            For Each i In GetSetting("ImageList").ToString.Split(";")
                If IO.File.Exists(i) Then
                    images.Add(i)
                End If
            Next
            If images.Count > 1 Then
                SlideThread = New Thread(Sub()
                                             While LOCKSTAT
                                                 If GetSetting("Random") Then
                                                     pbImage.ImageLocation = images(random.Next(0, images.Count - 1))
                                                     Thread.Sleep(4000)
                                                 Else
                                                     For Each i In images
                                                         pbImage.ImageLocation = i
                                                         Thread.Sleep(4000)
                                                     Next
                                                 End If
                                                 Thread.Sleep(1)
                                             End While
                                         End Sub)
                SlideThread.IsBackground = True
                SlideThread.Start()
            ElseIf images.Count = 1 Then
                pbImage.ImageLocation = images(0)
            Else
                pbImage.Image = My.Resources.DefaultWallpaper
            End If
        Catch ex As Exception
            pbImage.Image = My.Resources.DefaultWallpaper
        End Try
    End Sub
End Class