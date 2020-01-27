Public Class alg
    Public Shared Function jiami(strr As String, miyue0 As String, miyuenum0 As Long, miyuenum20 As Long)
        Dim d As String, f As String = "", e As String, c
        Dim savestr As String = ""
        Dim offset As Long, js As Integer, mynmod = miyuenum0 Mod 2147483647
        For a = 1 To Len(strr)
            d = Mid(strr, a, 1)
            c = Hex(AscW(d))
            If miyue0 <> "" Then
                offset = (a * mynmod) Mod 40 + 8
            Else
                offset = 47
            End If
            For i = 1 To Len(c)
                e = ChrW(Asc(Mid(c, i, 1)) - offset)
                f = f & e
            Next
            f = f & vbNullChar
            DoEvents()
        Next
        If miyue0 <> "" Then
            js = 0
            For i = 1 To Len(f)
                js += 1
                savestr = savestr & ChrW(AscW(f(i - 1)) - 30000 - Int(miyuenum20 * js / 10000000))
                If js = 4 Then js = 0
                DoEvents()
            Next
        Else
            savestr = f
        End If
        Return savestr
    End Function
End Class
