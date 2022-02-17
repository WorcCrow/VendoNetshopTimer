Public Class Protector
    Dim proc
    Sub New(ByVal prc As String)
        proc = prc
        InitializeComponent()
    End Sub

    Private Sub Protector_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ProtectProcess(proc)
    End Sub
End Class
