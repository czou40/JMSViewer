Public Class chazhaotihuan
    Public a As Integer, i As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            i = 0
            ReDim Form.tihuanbackup(32767)
            Form.aa = Form.RichTextBox1.Text
            Form.x = InStr(Form.aa, TextBox1.Text, CompareMethod.Text) - 1
            Form.RichTextBox1.SelectionStart = Form.x
            Form.RichTextBox1.SelectionLength = TextBox1.TextLength
            Form.canfindnext = True
            Form.firstfind = False
            Form.查找下一个NToolStripMenuItem.Enabled = True
            Button2.Enabled = True
            Form.Focus()
        Catch ex As Exception
            MsgBox("没有找到要查找的内容！", MsgBoxStyle.Information)
        End Try
    End Sub

    Public Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form.aa = Mid(Form.RichTextBox1.Text, Form.x + TextBox1.TextLength + 1)
        Form.bb = InStr(Form.aa, TextBox1.Text, CompareMethod.Text)
        Form.x = Form.x + Form.bb + 2
        If Form.bb = 0 Then
            If Not sender Is Button3 Then MsgBox("搜索已达文件末尾。", MsgBoxStyle.Information)
            Form.x = 0
            Form.RichTextBox1.SelectionStart = Form.x
            Form.RichTextBox1.SelectionLength = 0
            Form.canfindnext = False
            Form.firstfind = True
            Button2.Enabled = False
            Form.查找下一个NToolStripMenuItem.Enabled = False
        Else
            Form.x = Form.x + TextBox1.TextLength - 3
            Form.RichTextBox1.SelectionStart = Form.x
            Form.RichTextBox1.SelectionLength = TextBox1.TextLength
        End If
        Form.Focus()
    End Sub

    Private Sub Form2_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        e.Cancel = True
        Me.Hide()
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Form.canfindnext = False Then
            Form.firstfind = True
            Button2.Enabled = False
            Form.查找下一个NToolStripMenuItem.Enabled = False
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Form.canfindnext = False
        Form.firstfind = True
        i = 0
        Button2.Enabled = False
        Form.查找下一个NToolStripMenuItem.Enabled = False
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form.tihuanbackup(i) = Form.RichTextBox1.Text
        i += 1
        Form.RichTextBox1.Text = Replace(Form.RichTextBox1.Text, TextBox1.Text, TextBox2.Text, 1, -1, CompareMethod.Text)
        Form.tihuanbackup(i) = Form.RichTextBox1.Text
        Form.Focus()
        Form.RichTextBox1.SelectionStart = Form.RichTextBox1.TextLength
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If Form.firstfind = False Then
            If Form.canfindnext Then
                Form.tihuanbackup(i) = Form.RichTextBox1.Text
                i += 1
                Form.RichTextBox1.Text = Mid(Form.RichTextBox1.Text, 1, Form.x) & Replace(Form.RichTextBox1.Text, TextBox1.Text, TextBox2.Text, Form.x + 1, 1, CompareMethod.Text)
                Form.tihuanbackup(i) = Form.RichTextBox1.Text
                Call Button2_Click(sender, EventArgs.Empty)
            Else
                Call Button1_Click(Nothing, EventArgs.Empty)
            End If
        Else
            Form.firstfind = False
            Call Button1_Click(Nothing, EventArgs.Empty)
        End If
    End Sub
End Class