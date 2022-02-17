Imports System.Threading

Public Class Customize

    Private Sub Customize_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MakePanelDragable(PTitlebar, Me)
        ButtonStyle(BTNViewChanges)
        ButtonStyle(BTNSave)
        ButtonStyle(BTNChangePass)
        ButtonStyle(BBrowse)

        TBServer.Text = GetSetting("Server")
        TBPort.Text = GetSetting("Port")
        NUDOffTime.Value = GetSetting("OffTime")

        Dim opacity = GetSetting("Transparency")
        If opacity < 100 Then
            If opacity = 0 Then
                UpdateSetting("Transparency", 100)
                CBTransparency.Checked = False
            Else
                CBTransparency.Checked = True
            End If
        Else
            CBTransparency.Checked = False
        End If

        Select Case GetSetting("BackgroundMode")
            Case "Image"
                RBImage.Select()
            Case "Video"
                RBVideo.Select()
        End Select
    End Sub

    Private Sub RadioButton3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        UpdateSetting("BackgroundMode", RBVideo.Text)
    End Sub

    Private Sub Label7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label7.Click
        Me.Close()
    End Sub

    Dim minimize = False
    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label5.Click
        If minimize Then
            minimize = False
            Label5.Text = "-"
            Me.Size = New Point(539, 407)
        Else
            minimize = True
            Label5.Text = "+"
            Me.Size = New Point(100, 25)
        End If
    End Sub

    Private Sub TextBox2_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TBServer.LostFocus
        If Ping(TBServer.Text) Then
            UpdateSetting("Server", TBServer.Text)
        Else
            MsgBox(TBServer.Text & " Cannot be reached.")
            TBServer.Text = GetSetting("Server")
        End If
    End Sub

    Private Sub TextBox1_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TBPort.LostFocus
        UpdateSetting("Port", TBPort.Text)
    End Sub

    Private Sub BTNSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNSave.Click
        WriteConfig(CurrPath & "/data/Settings.ini")
        MsgBox("Settings Saved")
        Me.Close()
    End Sub

    Private Sub BTNChangePass_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNChangePass.Click
        If GetSetting("Password") = GetHash(MTBOPass.Text) Then
            UpdateSetting("Password", GetHash(MTBNPass.Text))
            MsgBox("Password Changed")
        Else
            MsgBox("Incorrect Old Password")
        End If
    End Sub

    Private Sub BTNViewChanges_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNViewChanges.Click
        UpdateSetting("Transparency", TBOpacityLevel.Value)
        LockScreen.ExecuteSetup()
    End Sub

    Private Sub BBrowse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BBrowse.Click
        Dim media As String = ""
        Dim type As String = ""
        Dim ofd As OpenFileDialog = New OpenFileDialog
        ofd.Multiselect = True

        If RBImage.Checked Then
            type = "ImageList"
            ofd.Title = "Browse for Image"
            ofd.Filter = "Image (*.jpg;*.jpeg;*.png;*.bmp)|*.jpg;*.jpeg;*.png;*.bmp"
        End If

        If RBVideo.Checked Then
            type = "VideoList"
            ofd.Title = "Browse for Video"
            ofd.Filter = "Video (*.mp4;*.avi;*.wmv)|*.mp4;*.avi;*.wmv"
        End If

        ofd.ShowDialog()
        LBBackgroundList.Items.Clear()
        For Each fi In ofd.FileNames
            LBBackgroundList.Items.Add(GetFileName(fi))
            media &= fi & ";"
        Next

        UpdateSetting(type, media)
    End Sub

    Private Sub CBTransparency_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBTransparency.CheckedChanged
        If CBTransparency.Checked Then
            TBOpacityLevel.Value = GetSetting("Transparency")
            TBOpacityLevel.Visible = True
            lOpacity.Text = TBOpacityLevel.Value
            lOpacity.Visible = True
        Else
            TBOpacityLevel.Visible = False
            lOpacity.Visible = False
        End If
    End Sub

    Private Sub TBOpacityLevel_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TBOpacityLevel.ValueChanged
        lOpacity.Text = TBOpacityLevel.Value
    End Sub

    Private Sub CBMute_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBMute.CheckedChanged
        UpdateSetting("Mute", CBMute.Checked)
    End Sub

    Private Sub CBRandom_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBRandom.CheckedChanged
        UpdateSetting("Random", CBRandom.Checked)
    End Sub

    Private Sub RBImage_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RBImage.CheckedChanged
        BBrowse.Text = "Browse Image"
        CBMute.Visible = False
        CBRandom.Checked = GetSetting("Random")
        LBBackgroundList.Items.Clear()
        For Each i In GetSetting("ImageList").ToString.Split(";")
            LBBackgroundList.Items.Add(GetFileName(i))
        Next
        UpdateSetting("BackgroundMode", RBImage.Text)
    End Sub

    Private Sub RBVideo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RBVideo.CheckedChanged
        BBrowse.Text = "Browse Video"
        CBMute.Visible = True
        CBMute.Checked = GetSetting("Mute")
        CBRandom.Checked = GetSetting("Random")
        LBBackgroundList.Items.Clear()
        For Each i In GetSetting("VideoList").ToString.Split(";")
            LBBackgroundList.Items.Add(GetFileName(i))
        Next
        UpdateSetting("BackgroundMode", RBVideo.Text)
    End Sub

    Private Sub NUDOffTime_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles NUDOffTime.LostFocus
        UpdateSetting("OffTime", NUDOffTime.Value)
    End Sub
End Class