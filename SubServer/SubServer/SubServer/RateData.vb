Module RateData
    Public Rate As New List(Of RateInfo)

    <Serializable()>
    Class RateInfo
        Public peso As Integer
        Public minute As Integer

        Sub New(ByVal peso As Integer, ByVal minute As Integer)
            Me.peso = peso
            Me.minute = minute
        End Sub
    End Class

    Public Sub SortRate()
        Rate.Sort(Function(x, y) x.peso.CompareTo(y.peso))
        Rate.Reverse()
    End Sub
End Module
