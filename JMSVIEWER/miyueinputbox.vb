Public Class miyueinputbox

    Public yuantext As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Label1.Text = "请再次输入您的密钥。" Then
            If TextBox1.Text <> TextBox2.Text Then
                MsgBox("两次密钥不相同！请重新输入！", MsgBoxStyle.Critical)
                Timer1.Enabled = True
                Label1.Text = yuantext
                TextBox1.Text = ""
                TextBox2.Text = ""
                TextBox1.Visible = True
                CheckBox1.Visible = True
                TextBox1.Focus()
            Else
                Form.miyue = TextBox1.Text
                Me.Close()
            End If
        ElseIf TextBox1.Enabled = True Then
            If TextBox1.Text = "" And Form.inputlimit = True Then
                MsgBox("请键入密钥！", MsgBoxStyle.Critical)
                Timer1.Enabled = True
                TextBox1.Focus()
            ElseIf TextBox1.TextLength < 6 And Form.inputlimit = True Then
                MsgBox("密钥位数过少，请至少设置6位以上的密钥！", MsgBoxStyle.Critical)
                Timer1.Enabled = True
                TextBox1.Focus()
            ElseIf TextBox1.Text <> "" Then
                If Form.needtoinputagain Then
                    Label1.Text = "请再次输入您的密钥。"
                    TextBox1.Visible = False
                    CheckBox1.Visible = False
                    TextBox2.Focus()
                    Exit Sub
                End If
                Form.miyue = TextBox1.Text
                Me.Close()
            End If
        Else
            Form.miyue = "根本没有密钥"
            Me.Close()
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        TextBox1.Enabled = Not CheckBox1.Checked
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form.inputcancel = True
        Me.Close()
    End Sub

    Private Sub miyueinputbox_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        TextBox1.Focus()
    End Sub

    Private Sub anjian(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyUp, TextBox2.KeyUp, Me.KeyUp
        If e.KeyCode = Keys.Enter And Timer1.Enabled = False Then
            If Button2.Focused = True Then
                Call Button2_Click(Nothing, EventArgs.Empty)
            Else
                Call Button1_Click(Nothing, EventArgs.Empty)
            End If
        End If
    End Sub

    Private Sub miyueinputbox_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        yuantext = Label1.Text
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Enabled = False
    End Sub
End Class