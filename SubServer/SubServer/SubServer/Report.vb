Imports System.Text

Public Class Report
    Private Sub Report_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MakePanelDragable(Panel1, Me)
        LoadReport()
        LoadDataFile("./report/" & SystemDate() & ".dat", DataReport)

        Totalsales()
        Sales()
    End Sub

    Private Sub CBReport_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBReport.SelectedIndexChanged
        LoadDataFile("./report/" & CBReport.Text & ".dat", DataReport)
        Totalsales()
        Sales()
    End Sub

    Private Sub BTNActivity_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNActivity.Click
        Activity()
    End Sub

    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    'Functions and Sub

    Sub Totalsales()
        Dim sum As Integer = 0
        For Each dat In DataReport
            If dat <> "" Then
                If dat.Split(",")(0) = "SALES" Then
                    sum += dat.Split(",")(3)
                End If
            End If
        Next
        lTotalSales.Text = sum
    End Sub

    Sub Sales()
        Dim logs As StringBuilder = New StringBuilder
        rtbActivity.Text = ""
        For Each dat In DataReport
            If dat <> "" Then
                Dim dats = dat.Split(",")
                If dats(0) = "SALES" Then
                    If dats.Length = 5 Then
                        logs.Append(dats(1) & " -> " & dats(3) & dats(4) & dats(2) & vbNewLine)
                    End If
                End If
            End If
        Next
        rtbActivity.Text = logs.ToString
    End Sub

    Sub Activity()
        Try
            Dim logs As StringBuilder = New StringBuilder
            rtbActivity.Text = ""
            For Each dat In DataReport
                If dat <> "" Then
                    Dim dats = dat.Split(",")
                    If dats(0) = "ACTIVITY" Then
                        If dats.Length = 3 Then
                            logs.Append(dats(1) & " -> " & dats(2) & vbNewLine)
                        End If
                    End If
                End If
            Next
            rtbActivity.Text = logs.ToString
        Catch ex As Exception
            ErrorLog(SystemDateTime() & " -> " & ex.Message)
        End Try
    End Sub

    Sub LoadReport()
        Try
            CBReport.Items.Clear()
            For Each file In IO.Directory.GetFiles("./report/")
                Dim lastindex = file.LastIndexOf("/") + 1
                CBReport.Items.Add(file.Substring(lastindex, file.Length - (4 + lastindex)))
            Next
            CBReport.Text = SystemDate()
        Catch ex As Exception
             ErrorLog(SystemDateTime() & " -> " & ex.Message)
        End Try
        
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Sales()
    End Sub
End Class