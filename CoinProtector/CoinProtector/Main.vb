Module Main
    Sub Main(ByVal args As String())
        If ProcessRunning(Myname()) Then
            Application.Exit()
        End If

        If args.Length <> 0 Then
            Dim ProtectForm = New Protector(args(0))
            ProtectForm.ShowDialog()
        End If
    End Sub
End Module
