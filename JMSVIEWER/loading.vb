Public Class loading
    Private jishu(5) As Integer, offset(5) As Integer, j As Integer, b As Bitmap

    Private Sub loading_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        On Error Resume Next
        Timer1.Enabled = False
    End Sub
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        On Error Resume Next
        PictureBox3.Parent = PictureBox1
        PictureBox4.Parent = PictureBox1
        For i = 0 To 5
            jishu(i) = 0
            offset(i) = 0
        Next
        j = 0
        b = New Bitmap(784, 86)
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
            Form.jmcancel = True
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
            If MsgBox("您确定要退出吗？", MsgBoxStyle.YesNo + MsgBoxStyle.Question) = MsgBoxResult.Yes Then Environment.Exit(0)
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
            Me.Hide()
            Form.NotifyIcon1.Visible = True
    End Sub

    Private Sub drawcircle(x As Integer)
        On Error Resume Next
        Dim g As Graphics = Graphics.FromImage(b)
        g.SmoothingMode = Drawing2D.SmoothingMode.HighQuality
        g.CompositingQuality = Drawing2D.CompositingQuality.HighQuality
        g.FillEllipse(Brushes.Black, x, PictureBox2.Height \ 2 - 5, 10, 10)
    End Sub

    Private Sub setdraw(index As Integer)
        On Error Resume Next
        Dim g As Graphics = Graphics.FromImage(b)
        g.Clear(Me.BackColor)
        For i = 0 To index
            offset(i) = jishu(i)
            If Me.Width \ 2 - 115 < offset(i) And offset(i) < Me.Width \ 2 + 85 Then
                jishu(i) += 3
            Else
                jishu(i) += 20
            End If
            If offset(5) <= Me.Width Then
                drawcircle(offset(i))
            Else
                For k = 0 To 5
                    jishu(k) = 0
                    offset(k) = 0
                Next
                j = -1
            End If
        Next
        If Not PictureBox2.IsDisposed Then PictureBox2.CreateGraphics.DrawImage(b, 0, 0)
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        On Error Resume Next
        Select Case j
            Case Is >= 30
                setdraw(5)
            Case Else
                setdraw(j \ 6)
        End Select
        j += 1
    End Sub

    Private Sub loading_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        On Error Resume Next
        Form.NotifyIcon1.Visible = False
    End Sub

    Private Sub loading_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Timer1.Enabled = True
    End Sub
End Class