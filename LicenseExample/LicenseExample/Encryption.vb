Imports System.Text

Module Encryption
    Function Encrypt(ByVal a As String, ByVal b As String, Optional ByVal min As Integer = 1, Optional ByVal max As Integer = 127, Optional ByVal alpha As Boolean = False)
        Try
            Dim c As StringBuilder = New StringBuilder,
                d As Byte(),
                e As Byte(),
                g As Random = New Random,
                h As String,
                i As Integer,
                j As String

            If a.Length <> 10 Then
                While c.Length < 9
                    c.Append(a)
                End While
                a = c.ToString
                c = New StringBuilder
            End If

            d = Encoding.ASCII.GetBytes(a)
            e = Encoding.ASCII.GetBytes(b)

            For Each f In e
                h = g.Next(0, 9)
                i = CInt(f) - CInt(d(h))
                j = Math.Abs(i).ToString.Length
                If i < 0 Then
                    j += 5
                    i = Math.Abs(i)
                End If
                c.Append(h & j & i)
            Next
            Return Shortener(c.ToString, min, max, alpha)
        Catch ex As Exception
            Return 0
        End Try
    End Function

    Function Shortener(ByVal a As String, Optional ByVal min As Integer = 1, Optional ByVal max As Integer = 127, Optional ByVal alpha As Boolean = False)
        Try
            Dim b = 0
            Dim c
            Dim d
            Dim e As StringBuilder = New StringBuilder
            Dim f = max
            Dim g = min

            While b < a.Length
                c = ""
                d = 0
                While d < 3
                    If (b + d) <= a.Length - 1 Then
                        c &= a(b + d)
                        If c = 0 Then
                            e.Append(c)
                            c = ""
                            b += 1
                        Else
                            d += 1
                        End If
                    Else
                        Exit While
                    End If
                End While

                While True
                    Select Case c.Length
                        Case 3
                            If c <= f Then
                                b += 3
                                e.Append(Chr(c))
                                Exit While
                            Else
                                c = c.Substring(0, c.Length - 1)
                            End If

                        Case 2
                            If c >= g Then
                                If alpha Then
                                    If IllegalChar(c) Then
                                        c = c.Substring(0, c.Length - 1)
                                    Else
                                        b += 2
                                        e.Append(Chr(c))
                                        Exit While
                                    End If
                                Else
                                    If c >= 48 And c <= 57 Then
                                        c = c.Substring(0, c.Length - 1)
                                    Else
                                        b += 2
                                        e.Append(Chr(c))
                                        Exit While
                                    End If
                                End If
                            Else
                                c = c.Substring(0, c.Length - 1)
                            End If

                        Case 1
                            If c >= g Then
                                b += 1
                                e.Append(Chr(c))
                                Exit While
                            Else
                                b += 1
                                e.Append(c)
                                Exit While
                            End If
                        Case Else
                            Exit While
                    End Select
                End While
            End While
            Return Encoding.ASCII.GetBytes(e.ToString)
        Catch ex As Exception
            Return 0
        End Try
    End Function

    Function Longer(ByVal a As Byte())
        Try
            Dim b = 0
            Dim c As StringBuilder = New StringBuilder

            While b < a.Length
                If a(b) >= 48 And a(b) <= 57 Then
                    c.Append(Chr(a(b)))
                Else
                    c.Append(a(b))
                End If
                b += 1
            End While
            Return c
        Catch ex As Exception
            Return 0
        End Try
    End Function

    Function Decrypt(ByVal a As String, ByVal b As Byte())
        Try
            Dim d As StringBuilder = New StringBuilder
            Dim c = Longer(b)
            If a.Length <> 10 Then
                While d.Length < 10
                    d.Append(a)
                End While
                a = d.ToString
                d = New StringBuilder
            End If

            Dim e As Byte() = Encoding.ASCII.GetBytes(a)
            Dim f = 0
            While f < c.Length
                If c(f) Like "[0-9]" Then
                    Dim g = CInt(c(f).ToString)
                    f += 1
                    Dim h = CInt(c(f).ToString)
                    Dim i = ""
                    If h > 5 Then
                        h -= 5
                        i = "-"
                    End If
                    For x = 1 To h
                        f += 1
                        i &= c(f)
                    Next
                    Dim temp = Chr(CInt(i) + e(g))
                    d.Append(temp)
                    f += 1
                Else
                    Return "Invalid Data"
                End If
            End While
            Return d.ToString
        Catch ex As Exception
            Return 0
        End Try
    End Function

    Function IllegalChar(ByVal a As Integer)
        Dim b() As Integer = {48, 49, 50, 51, 52, 53, 54, 55, 56, 57, 58, 59, 60, 61, 62, 63, 64, 91, 92, 96, 94, 95, 96}
        For Each c In b
            If c = a Then
                Return True
            End If
        Next
        Return False
    End Function

End Module
