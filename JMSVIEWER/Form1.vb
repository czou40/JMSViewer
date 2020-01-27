Option Explicit On
Imports System.Windows.Forms.Application

Public Class Form
    Private Const err1 = "不是一个标准的JMS文件！"
    Private Const err2 = "文件打开失败，请您升级到最新版本的加密之神文件编辑器！"
    Public Const fileversion = "1.2.0.8"
    Public havesaved As Boolean, canfindnext As Boolean, firstfind As Boolean, _
        x As Integer, aa As String, bb As String, findtext As String, pathyuan As String, _
        showerr As String, specialerrflag As Boolean, filelength As Long
    Public miyueyuan As String, miyuenumyuan As String, miyuenum2yuan As String, miyue As String, miyuenum As Long, miyuenum2 As Long, jiaoyanyuan As String, jiaoyan As String,
        inputcancel As Boolean, inputlimit As Boolean, headinfo As String, needtoinputagain As Boolean,
        jmcancel As Boolean, loadingbuttonvisible As Boolean, tihuanbackup(32767) As String, specialtihuan As Boolean
    Public updatestr As String, threadwhattodo As Integer, updatedizhi As String, updateversion As String, errorinupdate As String

    Private Sub Form_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If havesaved = False Then
            Select Case MsgBox("是否要保存您的更改？", MsgBoxStyle.YesNoCancel + MsgBoxStyle.Question)
                Case MsgBoxResult.Yes
                    Call 保存SToolStripMenuItem_Click(Nothing, EventArgs.Empty)
                Case MsgBoxResult.Cancel
                    e.Cancel = True
            End Select
        End If
    End Sub

    Private Sub czth(type As Byte)
        Select Case type
            Case 1
                With chazhaotihuan
                    .Height = 125
                    .Text = "查找"
                    .Panel1.Visible = False
                End With
            Case 2
                With chazhaotihuan
                    .Height = 220
                    .Text = "替换"
                    .Panel1.Visible = True
                End With
        End Select
        chazhaotihuan.Show()
    End Sub

    Private Sub Form_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown, RichTextBox1.KeyDown
        If e.Control Then
            If e.KeyCode = Keys.E Or e.KeyCode = Keys.R Or e.KeyCode = Keys.L Or e.KeyCode = Keys.J Then
                e.Handled = True
            Else
                Select Case e.KeyCode
                    Case Keys.Z
                        e.Handled = True
                        If 撤销ZToolStripMenuItem.Enabled = True Then Call 撤销ZToolStripMenuItem_Click(sender, EventArgs.Empty)
                    Case Keys.Y
                        e.Handled = True
                        If 重复ToolStripMenuItem.Enabled = True Then Call 重复ToolStripMenuItem_Click(sender, EventArgs.Empty)
                    Case Keys.S
                        Call 保存SToolStripMenuItem_Click(sender, EventArgs.Empty)
                    Case Keys.O
                        Call 打开ToolStripMenuItem_Click(sender, EventArgs.Empty)
                    Case Keys.N
                        Call 新建ToolStripMenuItem_Click(sender, EventArgs.Empty)
                    Case Keys.F
                        Call 查找ToolStripMenuItem_Click(sender, EventArgs.Empty)
                    Case Keys.H
                        Call 替换IToolStripMenuItem_Click(sender, EventArgs.Empty)
                    Case Keys.G
                        Call 转到GToolStripMenuItem_Click(sender, EventArgs.Empty)
                    Case Keys.V
                        e.Handled = True
                        RichTextBox1.SelectedText = Clipboard.GetText
                End Select
            End If
        ElseIf e.KeyCode = Keys.F3 Then
            If 查找下一个NToolStripMenuItem.Enabled = True Then Call 查找下一个NToolStripMenuItem_Click(sender, EventArgs.Empty)
        ElseIf e.KeyCode = Keys.F5 Then
            Call 时间ToolStripMenuItem_Click(sender, EventArgs.Empty)
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Dim aaa = jiami(IO.File.ReadAllText("E:\Others\个人\hhh.jpg", System.Text.Encoding.GetEncoding("ANSI")), "432432", 32324222222000, 2029740000)
        'IO.File.WriteAllText("1.jpg", jiemi(aaa, "432432", 32324222222000, 2029740000, True), System.Text.Encoding.GetEncoding("ANSI"))
        Dim fontname As String = "宋体", fontsize As Single = 9, fontstyl As Drawing.FontStyle = 0
        miyue = ""
        SaveFileDialog1.Reset()
        OpenFileDialog1.Reset()
        Try
            Dim k = IO.File.ReadAllLines(Application.StartupPath & "\jmsviewer.ini", System.Text.Encoding.UTF8)
            For i = 0 To UBound(k)
                If k(i) Like "*FontStyle*" Then
                    fontstyl = Replace(Mid(k(i), InStr(k(i), "=") + 1), " ", "")
                ElseIf k(i) Like "*FontSize*" Then
                    fontsize = Replace(Mid(k(i), InStr(k(i), "=") + 1), " ", "")
                ElseIf k(i) Like "*Font*" Then
                    fontname = Replace(Mid(k(i), InStr(k(i), "=") + 1), " ", "")
                    fontname = Replace(fontname, "_", " ")
                ElseIf k(i) Like "*AutoLine*" Then
                    RichTextBox1.WordWrap = Replace(Mid(k(i), InStr(k(i), "=") + 1), " ", "")
                    自动换行AToolStripMenuItem.Checked = Replace(Mid(k(i), InStr(k(i), "=") + 1), " ", "")
                End If
            Next
        Catch ex As Exception
            Dim sss(10) As String
            sss(0) = "[格式]"
            sss(1) = "AutoLine = True"
            sss(2) = "Font = 宋体"
            sss(3) = "FontSize = 9"
            sss(4) = "FontStyle = 0"
            IO.File.WriteAllLines(Application.StartupPath & "\jmsviewer.ini", sss, System.Text.Encoding.UTF8)
        End Try
        Me.Text = "无标题 - 加密之神文件编辑器"
        NotifyIcon1.Visible = False
        NotifyIcon1.Icon = Me.Icon
        For Each a In My.Application.CommandLineArgs
            If a <> "" Then
                loading.Label1.Visible = True
                loading.Label2.Visible = True
                loading.PictureBox3.Visible = True
                OpenFileDialog1.FileName = a
                setjiemistr(OpenFileDialog1.FileName, "")
            End If
        Next
        RichTextBox1.Font = New Font(fontname, fontsize, fontstyl)
        FontDialog1.Font = RichTextBox1.Font
        'NotifyIcon1.Visible = False
        enablecx(False)
        enablecf(False)
        查找下一个NToolStripMenuItem.Enabled = False
        havesaved = True
        firstfind = True
        specialerrflag = False
        specialtihuan = False
        jmcancel = False
    End Sub

    Private Sub xinjian()
        SaveFileDialog1.Reset()
        OpenFileDialog1.Reset()
        RichTextBox1.Clear()
        Me.Text = "无标题 - 加密之神文件编辑器"
        enablecx(False)
        enablecf(False)
        查找下一个NToolStripMenuItem.Enabled = False
        havesaved = True
        specialerrflag = False
    End Sub

    Private Sub choosepath()
        pathyuan = OpenFileDialog1.FileName
        miyueyuan = miyue
        miyuenumyuan = miyuenum
        miyuenum2yuan = miyuenum2
        jiaoyanyuan = jiaoyan
        With OpenFileDialog1
            .Reset()
            .Filter = "加密文件(*.jms)|*.jms"
            .AddExtension = True
            .CheckFileExists = True
            .CheckPathExists = True
            .ShowDialog()
        End With
        If OpenFileDialog1.FileName <> "" Then
            loading.Label1.Visible = True
            loading.Label2.Visible = True
            loading.PictureBox3.Visible = True
            setjiemistr(OpenFileDialog1.FileName, "")
        Else
            OpenFileDialog1.FileName = pathyuan
        End If
    End Sub

    Private Sub head()
        headinfo = "This file is edited by JMSVIEWER " & My.Application.Info.Version.ToString & " File Version " & fileversion
        For i = 1 To 1000
            headinfo &= vbNullChar
        Next
        Dim myinfo As String, jyinfo As String, writemyinfo As String, writejyinfo As String, jychecknum As Long, check1 As String, _
            check2 As String, writecheck As String, mywei As String
        writemyinfo = ""
        writejyinfo = ""
        jychecknum = 0
        writecheck = ""
        check1 = "jycheck1:"
        check2 = "jycheck2:"
        myinfo = "myfirst:" & Mid(miyue, 1, 1) & " mylast:" & Mid(miyue, Len(miyue), 1)
        jyinfo = "jyinfo:" & jiaoyan
        mywei = "mywei:" & Len(miyue)
        For i = 15 To 19
            jychecknum += AscW(jiaoyan(i - 1))
        Next
        For i = 2 To (Len(miyue) - 1) / 2 + 1
            check1 &= Format(AscW(miyue(i - 1)) + AscW(miyue(Len(miyue) - i)) + jychecknum, "000000")
            check2 &= Format(AscW(miyue(i - 1)) - AscW(miyue(Len(miyue) - i)) * (-jychecknum), "000000")
        Next
        writemyinfo = jiamihead(myinfo, 482)
        writejyinfo = jiamihead(jyinfo, 312)
        writecheck = jiamihead(check1, 337) & vbLf & jiamihead(check2, 394)
        mywei = jiamihead(mywei, 421)
        headinfo = headinfo & vbLf & writemyinfo & vbLf & writejyinfo & vbLf & writecheck & vbLf & mywei & vbLf
    End Sub

    Private Function jiamihead(whattojiami As String, miyuenum As Long)
        Dim er As String = ""
        Dim jm As String = ""
        Dim s As Long, rand As Integer, j As String, back As String
        back = ""
        For i = 1 To Len(whattojiami)
            s = AscW(whattojiami(i - 1)) + miyuenum
            Do Until s = 1 Or s = 0
                er = s Mod 2 & er
                s = s \ 2
            Loop
            er = s Mod 2 & er
            s = s \ 2
            jm = "2" & er & jm
            er = ""
        Next
        For i = 1 To Len(jm)
            j = jm(i - 1)
            Randomize()
            rand = Rnd() * 2222
            Select Case j
                Case "0"
                    back &= ChrW(rand + 27777)
                Case "1"
                    back &= ChrW(rand + 30000)
                Case "2"
                    back &= ChrW(rand + 32223)
            End Select
        Next
        Return back
    End Function
    Private Function jiemihead(whattojiemi As String, miyuenum As Long)
        Dim jm As String = ""
        Dim j As Long, shi As Long, s As String, back As String, spl
        shi = 0
        back = ""
        For i = 1 To Len(whattojiemi)
            j = AscW(whattojiemi(i - 1))
            Select Case j
                Case Is >= 32223
                    jm &= "2"
                Case Is >= 30000
                    jm &= "1"
                Case Else
                    jm &= "0"
            End Select
        Next
        spl = Split(jm, "2")
        For i = UBound(spl) To 0 Step -1
            For k = Len(spl(i)) To 1 Step -1
                s = Mid(spl(i), k, 1)
                shi += s * 2 ^ (Len(spl(i)) - k)
            Next
            shi -= miyuenum
            back &= ChrW(shi)
            shi = 0
        Next
        back = Mid(back, 1, Len(back) - 1)
        Return back
    End Function

    Private Sub save(f As String, index As String)
        headinfo = ""
        If index = 2 Then
            Try
                With SaveFileDialog1
                    .Reset()
                    .Filter = "加密文件(*.jms)|*.jms"
                    .AddExtension = True
                    .ShowDialog()
                End With
                If SaveFileDialog1.FileName <> "" Then
                    If miyue <> "" Then
                        head()
                    End If
                    IO.File.WriteAllText(SaveFileDialog1.FileName, headinfo & f, System.Text.Encoding.UTF8)
                    OpenFileDialog1.FileName = SaveFileDialog1.FileName
                    havesaved = True
                    Me.Text = Mid(OpenFileDialog1.FileName, InStrRev(OpenFileDialog1.FileName, "\") + 1) & " - 加密之神文件编辑器"
                Else
                    miyue = miyueyuan
                    miyuenum = miyuenumyuan
                    miyuenum2 = miyuenum2yuan
                    jiaoyan = jiaoyanyuan
                End If
            Catch ex As Exception
            End Try
        ElseIf index = 1 Then
            If miyue <> "" Then
                head()
            End If
            IO.File.WriteAllText(OpenFileDialog1.FileName, headinfo & f, System.Text.Encoding.UTF8)
            SaveFileDialog1.FileName = OpenFileDialog1.FileName
            havesaved = True
        End If
    End Sub

    Private Sub setjiemistr(path As String, special As String)
        If special <> "" Then
        Else
            showerr = err1
            inputcancel = False
            inputlimit = False
            needtoinputagain = False
            miyuenum = 0
            miyuenum2 = 1
            jiaoyan = ""
            Dim getfileversion As String = ""
            Dim jyinfo As String, myinfo As String, myfirst As String = "", mylast As String = "", jychecknum As Long, jycheck1 As String,
                  jycheck2 As String, mywei As String, input1 As String, input2 As String
            Dim str As String = IO.File.ReadAllText(path, System.Text.Encoding.UTF8)
            filelength = str.Length
            If str Like "This file is edited by JMSVIEWER *" Then
                Try
                    getfileversion = Split(str, vbLf)(0)
                    getfileversion = Replace(Mid(getfileversion, InStr(getfileversion, "File Version") + 12), " ", "")
                    getfileversion = Replace(getfileversion, vbNullChar, "")
                    If getfileversion <> fileversion Then
                        If getfileversion = "1.1.6.8" Then
                            str = IO.File.ReadAllText(path, System.Text.Encoding.GetEncoding("GB2312"))
                        Else
                            MsgBox("此文档是由较高版本的加密之神文件编辑器创建的，本程序会试图打开它，但可能失败。强烈建议您升级到最新版本的加密之神文件编辑器！", vbInformation)
                            showerr = err2
                        End If
                    End If
                    myinfo = jiemihead(Split(str, vbLf)(1), 482)
                    myfirst = myinfo(Strings.InStr(myinfo, ":"))
                    mylast = myinfo(Strings.InStrRev(myinfo, ":"))
                    jyinfo = jiemihead(Split(str, vbLf)(2), 312)
                    jiaoyan = Mid(jyinfo, Strings.InStr(jyinfo, ":") + 1)
                    If myfirst = "根" Then
                        miyue = "根本没有密钥"
                    Else
                        loading.loadmsg.Text = "请输入密钥"
                        NotifyIcon1.Text = "加密之神文件编辑器"
                        Me.Hide()
                        loading.Show()
                        DoEvents()
                        input("请输入密钥", "要打开本文档，您需要提供密钥：", False)
                        If inputcancel Then
                            jiemierrreset()
                            Exit Sub
                        End If
                    End If
                Catch ex As Exception
                    MsgBox(err1, MsgBoxStyle.Critical)
                    jiemierrreset()
                    Exit Sub
                End Try
            Else
                miyue = ""
            End If
            If miyue <> "" Then
                Try
                    input1 = ""
                    input2 = ""
                    If getfileversion <> "1.1.6.8" Then
                        mywei = jiemihead(Split(str, vbLf)(5), 421)
                        mywei = Mid(mywei, Strings.InStr(mywei, ":") + 1)
                        If Int(mywei) <> Len(miyue) Then
                            MsgBox("密钥错误，请重新输入！", MsgBoxStyle.Critical)
                            jiemierrreset()
                            Exit Sub
                        End If
                    End If
                    If myfirst <> miyue(0) Or mylast <> miyue(Len(miyue) - 1) Then
                        MsgBox("密钥错误，请重新输入！", MsgBoxStyle.Critical)
                        jiemierrreset()
                        Exit Sub
                    End If
                    For i = 15 To 19
                        jychecknum += AscW(jiaoyan(i - 1))
                    Next
                    jycheck1 = jiemihead(Split(str, vbLf)(3), 337)
                    jycheck1 = Mid(jycheck1, InStr(jycheck1, ":") + 1)
                    jycheck2 = jiemihead(Split(str, vbLf)(4), 394)
                    jycheck2 = Mid(jycheck2, InStr(jycheck2, ":") + 1)
                    If (Len(miyue) - 1) \ 2 <> Len(jycheck1) \ 6 Then
                        MsgBox("密钥错误，请重新输入！", MsgBoxStyle.Critical)
                        jiemierrreset()
                        Exit Sub
                    End If
                    For i = 2 To (Len(miyue) - 1) / 2 + 1
                        input1 &= Format(AscW(miyue(i - 1)) + AscW(miyue(Len(miyue) - i)) + jychecknum, "000000")
                        input2 &= Format(AscW(miyue(i - 1)) - AscW(miyue(Len(miyue) - i)) * (-jychecknum), "000000")
                    Next
                    If jycheck1 <> input1 Or jycheck2 <> input2 Then
                        MsgBox("密钥错误，请重新输入！", MsgBoxStyle.Critical)
                        jiemierrreset()
                        Exit Sub
                    End If
                    For i = 20 To 24
                        miyuenum2 = miyuenum2 * AscW(Mid(jiaoyan, i, 1))
                    Next
                    For i = 1 To Len(miyue)
                        miyuenum += AscW(Mid(miyue, i, 1))
                        miyuenum2 -= AscW(Mid(miyue, i, 1)) ^ 2
                    Next
                    str = Mid(str, InStrRev(str, vbLf) + 1)
                Catch ex As Exception
                    MsgBox(showerr, MsgBoxStyle.Critical)
                    jiemierrreset()
                    Exit Sub
                End Try
            End If
            If miyue = "" Then
                loading.loadmsg.Text = "正在打开文件"
                NotifyIcon1.Text = loading.loadmsg.Text
                loading.Label1.Visible = False
                seeifshowloading(50000)
                DoEvents()
                Dim content As String = jiemi(str, miyue, miyuenum, miyuenum2, False)
                loading.Label1.Visible = True
                If specialerrflag = False Then
                    RichTextBox1.Text = content
                    loading.Close()
                    Me.Show()
                Else
                    jiemierrreset()
                    Exit Sub
                End If
            Else
                If getfileversion Like "1.1.6.8*" Then
                    loading.loadmsg.Text = "正在打开文件"
                    NotifyIcon1.Text = loading.loadmsg.Text
                    loading.Label1.Visible = False
                    seeifshowloading(50000)
                    DoEvents()
                    Dim content As String = jiemi(str, miyue, miyuenum, miyuenum2, False)
                    loading.Label1.Visible = True
                    If specialerrflag = False Then
                        RichTextBox1.Text = content
                        loading.Close()
                        Me.Show()
                    Else
                        jiemierrreset()
                        Exit Sub
                    End If
                Else
                    Dim separate
                    Dim showtext As String = ""
                    loading.loadmsg.Text = "正在打开文件"
                    NotifyIcon1.Text = loading.loadmsg.Text
                    seeifshowloading(50000)
                    DoEvents()
                    separate = Split(str, vbNullChar)
                    For i = 0 To UBound(separate)
                        Dim content As String = jiemi(separate(i), miyue, miyuenum, miyuenum2, False)
                        If specialerrflag = False Then
                            showtext &= content
                        Else
                            jiemierrreset()
                            Exit Sub
                        End If
                        If i Mod 10 = 0 Then
                            loading.loadmsg.Text = Math.Round(i / UBound(separate) * 100) & "%完成 正在打开文件"
                            NotifyIcon1.Text = loading.loadmsg.Text
                            DoEvents()
                            If jmcancel = True Then
                                jmcancel = False
                                jiemierrreset()
                                Exit Sub
                            End If
                        End If
                    Next
                    loading.loadmsg.Text = "100%完成 正在打开文件"
                    NotifyIcon1.Text = loading.loadmsg.Text
                    DoEvents()
                    loading.Close()
                    RichTextBox1.Text = showtext
                    Me.Show()
                End If
            End If
            Me.Text = Mid(path, InStrRev(path, "\") + 1) & " - 加密之神文件编辑器"
            enablecx(False)
            enablecf(False)
            havesaved = True
        End If
    End Sub

    Private Sub seeifshowloading(a As Integer)
        If filelength > a Then
            Me.Hide()
            loading.Show()
        End If
    End Sub

    Private Sub jiemierrreset()
        loading.Close()
        xinjian()
        Me.Show()
    End Sub

    Private Function jiemi(str As String, miyue0 As String, miyuenum0 As Long, miyuenum20 As Long, special As Boolean)
        Dim b, c, d
        Dim offset, count As Long
        Dim js As Integer, loadstr As String
        b = ""
        d = ""
        loadstr = ""
        count = 0
        js = 0
        If Not str = "" Then
            Try
                If miyue0 <> "" Then
                    For i = 1 To Len(str)
                        js += 1
                        loadstr = loadstr & ChrW((AscW(str(i - 1)) + 30000 + Int(miyuenum20 * js / 10000000)) Mod 65536)
                        If js = 4 Then js = 0
                        DoEvents()
                    Next
                Else
                    loadstr = str
                End If
                c = Split(loadstr, vbNullChar)
                For a = 1 To Len(loadstr)
                    Do While loadstr Like "*" & vbNullChar & "*"
                        For i = 0 To UBound(c) - 1 Step 1
                            count += 1
                            If miyue0 <> "" Then
                                offset = (count * (miyuenum0 Mod 2147483647)) Mod 40 + 8
                            Else
                                offset = 47
                            End If
                            For qaz = 1 To Len(c(i))
                                b = b & Chr(Asc(Mid(c(i), qaz, 1)) + offset)
                            Next
                            d = d & ChrW("&H" & b)
                            b = ""
                            loadstr = Mid(loadstr, Strings.InStr(loadstr, vbNullChar) + 1)
                            If i Mod 100 = 0 Then DoEvents()
                        Next
                    Loop
                Next
            Catch ex As Exception
                If special = False Then
                    OpenFileDialog1.FileName = pathyuan
                    miyue = miyueyuan
                    miyuenum = miyuenumyuan
                    miyuenum2 = miyuenum2yuan
                    jiaoyan = jiaoyanyuan
                End If
                specialerrflag = True
                MsgBox(showerr, MsgBoxStyle.Critical)
                Return ""
                Exit Function
            End Try
            Return d
        Else
            Return ""
        End If
    End Function

    Private Sub setjiamistr(index As Byte, special As String)
        Dim strr(32767) As String, separate As Double, baocun As String
        baocun = ""
        For i = 0 To 32767
            strr(i) = ""
        Next
        If special <> "" Then
            strr(0) = special
        Else
            miyueyuan = miyue
            miyuenumyuan = miyuenum
            miyuenum2yuan = miyuenum2
            jiaoyanyuan = jiaoyan
            filelength = RichTextBox1.TextLength
            If index = 2 Then
                Me.Hide()
                jiaoyan = ""
                miyuenum = 0
                miyuenum2 = 1
                inputcancel = False
                inputlimit = True
                needtoinputagain = True
                loading.loadmsg.Text = "请输入密钥"
                NotifyIcon1.Text = "加密之神文件编辑器"
                loading.Show()
                DoEvents()
                input("请输入密钥", "为了保证文件的安全，请您为本文档设置一个密钥，密钥必须6位以上。", True)
                If inputcancel = True Then
                    miyue = miyueyuan
                    miyuenum = miyuenumyuan
                    miyuenum2 = miyuenum2yuan
                    jiaoyan = jiaoyanyuan
                    loading.Close()
                    Me.Show()
                    Exit Sub
                End If
                If miyue <> "" Then
                    Randomize()
                    For i = 1 To 24
                        Dim isnumber As Integer, value As Integer
                        isnumber = Rnd()
                        If isnumber = 0 Then
                            value = Rnd() * 25 + 65
                            jiaoyan = jiaoyan & Chr(value)
                        Else
                            value = Rnd() * 9
                            jiaoyan = jiaoyan & value
                        End If
                    Next
                    For i = 20 To 24
                        miyuenum2 = miyuenum2 * AscW(Mid(jiaoyan, i, 1))
                    Next
                    For i = 1 To Len(miyue)
                        miyuenum += AscW(Mid(miyue, i, 1))
                        miyuenum2 -= AscW(Mid(miyue, i, 1)) ^ 2
                    Next
                End If
            End If
            loading.loadmsg.Text = "正在加密文件"
            NotifyIcon1.Text = loading.loadmsg.Text
            seeifshowloading(3000)
            DoEvents()
            If miyue = "" Then
                loading.Label1.Visible = False
                baocun = jiami(RichTextBox1.Text, miyue, miyuenum, miyuenum2)
                loading.Label1.Visible = True
            Else
                separate = RichTextBox1.TextLength / 1500
                If separate <> Int(separate) Then
                    separate = Int(separate) + 1
                End If
                For j = 1 To separate
                    strr(j) = Mid(RichTextBox1.Text, 1500 * j - 1499, 1500)
                    baocun &= jiami(strr(j), miyue, miyuenum, miyuenum2) & vbNullChar
                    If j Mod 10 = 0 Then
                        loading.loadmsg.Text = Math.Round(j / separate * 100) & "%完成 正在加密文件"
                        NotifyIcon1.Text = loading.loadmsg.Text
                        DoEvents()
                        If jmcancel = True Then
                            miyue = miyueyuan
                            miyuenum = miyuenumyuan
                            miyuenum2 = miyuenum2yuan
                            jiaoyan = jiaoyanyuan
                            jmcancel = False
                            loading.Close()
                            Me.show()
                            Exit Sub
                        End If
                    End If
                Next
            End If
            loading.loadmsg.Text = "100%完成 正在加密文件"
            NotifyIcon1.Text = loading.loadmsg.Text
            DoEvents()
            Threading.Thread.Sleep(300)
            loading.Close()
            save(baocun, index)
            Me.Show()
        End If
    End Sub

    Private Function jiami(strr As String, miyue0 As String, miyuenum0 As Long, miyuenum20 As Long)
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

    Private Sub input(title As String, massage As String, enablecheckbox As Boolean)
        With miyueinputbox
            .Text = title
            .TextBox1.Text = ""
            .TextBox1.Visible = True
            .TextBox1.Enabled = True
            .TextBox2.Text = ""
            .TextBox2.Visible = needtoinputagain
            .Label1.Text = massage
            .CheckBox1.Visible = enablecheckbox
            .CheckBox1.Checked = False
            .ShowDialog()
        End With
    End Sub

    Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs) Handles RichTextBox1.TextChanged
        havesaved = False
        If RichTextBox1.CanUndo Then
            specialtihuan = False
            x = 0
            canfindnext = False
            firstfind = True
            enablecx(True)
            ReDim tihuanbackup(32767)
            chazhaotihuan.i = 0
        Else
            specialtihuan = True
            If chazhaotihuan.i = 0 Then
                enablecx(False)
            Else
                enablecx(True)
            End If
        End If
        If Not specialtihuan Then
            If RichTextBox1.CanRedo Then
                enablecf(True)
            Else
                enablecf(False)
            End If
        End If
    End Sub

    Private Sub 撤销ZToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 撤销ZToolStripMenuItem.Click, _
        撤销ZToolStripMenuItem1.Click
        Dim selyuan As Integer = RichTextBox1.SelectionStart
        If specialtihuan Then
            If chazhaotihuan.i > 0 Then
                chazhaotihuan.i -= 1
                RichTextBox1.Text = tihuanbackup(chazhaotihuan.i)
                If chazhaotihuan.i = 0 Then
                    enablecx(False)
                End If
                enablecf(True)
            End If
            RichTextBox1.SelectionStart = selyuan
            RichTextBox1.ScrollToCaret()
        Else
            RichTextBox1.Undo()
            RichTextBox1.ScrollToCaret()
            If RichTextBox1.CanUndo Then
                enablecx(True)
            Else
                enablecx(False)
            End If
        End If
    End Sub

    Private Sub 重复ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 重复ToolStripMenuItem.Click, 重复YToolStripMenuItem.Click
        RichTextBox1.Redo()
        If specialtihuan Then
            chazhaotihuan.i += 1
            RichTextBox1.Text = tihuanbackup(chazhaotihuan.i)
            enablecx(True)
            If tihuanbackup(chazhaotihuan.i + 1) = "" Then
                enablecf(False)
            End If
        Else
            If RichTextBox1.CanRedo Then
                enablecf(True)
            Else
                enablecf(False)
            End If
        End If
    End Sub

    Private Sub enablecx(a As Boolean)
        撤销ZToolStripMenuItem.Enabled = a
        撤销ZToolStripMenuItem1.Enabled = a
    End Sub

    Private Sub enablecf(a As Boolean)
        重复ToolStripMenuItem.Enabled = a
        重复YToolStripMenuItem.Enabled = a
    End Sub

    Private Sub 打开ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 打开ToolStripMenuItem.Click
        If havesaved = False Then
            Select Case MsgBox("是否要保存您的更改？", MsgBoxStyle.YesNoCancel + MsgBoxStyle.Question)
                Case MsgBoxResult.Yes
                    Call 保存SToolStripMenuItem_Click(Nothing, EventArgs.Empty)
                    choosepath()
                Case MsgBoxResult.No
                    choosepath()
            End Select
        Else
            choosepath()
        End If
    End Sub

    Private Sub 另存为AToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 另存为AToolStripMenuItem.Click
        loading.Label1.Visible = True
        loading.Label2.Visible = True
        loading.PictureBox3.Visible = True
        setjiamistr(2, "")
    End Sub

    Private Sub 保存SToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 保存SToolStripMenuItem.Click
        loading.Label1.Visible = True
        loading.Label2.Visible = True
        loading.PictureBox3.Visible = True
        If OpenFileDialog1.FileName = "" Then
            setjiamistr(2, "")
        Else
            setjiamistr(1, "")
        End If
    End Sub

    Private Sub 新建ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 新建ToolStripMenuItem.Click
        If havesaved = False Then
            Select Case MsgBox("是否要保存您的更改？", MsgBoxStyle.YesNoCancel + MsgBoxStyle.Question)
                Case MsgBoxResult.Yes
                    Call 保存SToolStripMenuItem_Click(Nothing, EventArgs.Empty)
                    xinjian()
                Case MsgBoxResult.No
                    xinjian()
            End Select
        Else
            xinjian()
        End If
    End Sub

    Private Sub 退出XToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 退出XToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub 转到GToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 转到GToolStripMenuItem.Click
        Try
            Dim a = InputBox("请输入要转到的行数：")
            Dim b As Integer = 0, d = Split(RichTextBox1.Text, vbLf), c = UBound(d) + 1
            If a > c Then
                MsgBox("行号过大！", MsgBoxStyle.Critical)
                a = c
            End If
            For i = 0 To a - 2
                b = b + d(i).Length + 1
            Next
            RichTextBox1.SelectionStart = b
        Catch ex As Exception
        End Try
    End Sub

    Private Sub 查找ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 查找ToolStripMenuItem.Click
        czth(1)
    End Sub

    Private Sub 替换IToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 替换IToolStripMenuItem.Click
        czth(2)
    End Sub

    Private Sub 查找下一个NToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 查找下一个NToolStripMenuItem.Click
        Call chazhaotihuan.Button2_Click(Nothing, EventArgs.Empty)
    End Sub

    Private Sub 字体FToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 字体FToolStripMenuItem.Click
        Dim bbb As Boolean
        bbb = havesaved
        Try
            FontDialog1.ShowDialog()
            RichTextBox1.Font = FontDialog1.Font
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
            Exit Sub
        End Try
        Dim sss(10) As String
        sss(0) = "[格式]"
        sss(1) = "AutoLine = " & RichTextBox1.WordWrap
        sss(2) = "Font = " & Replace(FontDialog1.Font.Name, " ", "_")
        sss(3) = "FontSize = " & FontDialog1.Font.Size
        sss(4) = "FontStyle = " & FontDialog1.Font.Style
        IO.File.WriteAllLines(Application.StartupPath & "\jmsviewer.ini", sss, System.Text.Encoding.UTF8)
        If bbb <> havesaved Then havesaved = bbb
    End Sub

    Private Sub 自动换行AToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 自动换行AToolStripMenuItem.Click
        If 自动换行AToolStripMenuItem.Checked = True Then
            Try
                Dim k = IO.File.ReadAllLines(Application.StartupPath & "\jmsviewer.ini", System.Text.Encoding.UTF8)
                For i = 0 To UBound(k)
                    If k(i) Like "*AutoLine =*" Then
                        k(i) = "AutoLine = " & True
                    End If
                Next
                IO.File.WriteAllLines(Application.StartupPath & "\jmsviewer.ini", k, System.Text.Encoding.UTF8)
            Catch ex As Exception
            End Try
            RichTextBox1.WordWrap = True
        Else
            Try
                Dim k = IO.File.ReadAllLines(Application.StartupPath & "\jmsviewer.ini", System.Text.Encoding.UTF8)
                For i = 0 To UBound(k)
                    If k(i) Like "*AutoLine =*" Then
                        k(i) = "AutoLine = " & False
                    End If
                Next
                IO.File.WriteAllLines(Application.StartupPath & "\jmsviewer.ini", k, System.Text.Encoding.UTF8)
            Catch ex As Exception
            End Try
            RichTextBox1.WordWrap = False
        End If
    End Sub

    Private Sub 关于JMS编辑器AToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 关于JMS编辑器AToolStripMenuItem.Click
        AboutBox1.Show()
    End Sub

    Private Sub NotifyIcon1_DoubleClick(sender As Object, e As EventArgs) Handles NotifyIcon1.DoubleClick
        loading.Show()
        loading.TopMost = True
        loading.TopMost = False
        NotifyIcon1.Visible = False
    End Sub

    Private Sub 检查更新CToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 检查更新CToolStripMenuItem.Click
        Dim openinternet As New Threading.Thread(AddressOf opennet)
        Try
            loading.loadmsg.Text = "正在查找更新……"
            loading.Show()
            threadwhattodo = 1
            openinternet.Start()
            Do Until threadwhattodo = 0
                Threading.Thread.Sleep(1)
                DoEvents()
            Loop
            If errorinupdate <> "" Then
                MsgBox(errorinupdate, MsgBoxStyle.Critical)
                openinternet.Abort()
                loading.Close()
                Exit Sub
            End If
            updateversion = updatestr
            If updateversion <> Me.ProductVersion Then
                If MsgBox("发现新的版本：" & updateversion & "，您确定要下载吗？", MsgBoxStyle.YesNo + MsgBoxStyle.Question) = MsgBoxResult.Yes Then
                    loading.loadmsg.Text = "正在跳转到下载页面……"
                    threadwhattodo = 2
                    Do Until threadwhattodo = 0
                        Threading.Thread.Sleep(1)
                        DoEvents()
                    Loop
                    If errorinupdate <> "" Then
                        MsgBox(errorinupdate, MsgBoxStyle.Critical)
                        openinternet.Abort()
                        loading.Close()
                        Exit Sub
                    End If
                    openinternet.Abort()
                    loading.Close()
                Else
                    openinternet.Abort()
                    loading.Close()
                End If
            Else
                MsgBox("您的版本已是最新。", MsgBoxStyle.Information)
                openinternet.Abort()
                loading.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
            openinternet.Abort()
            loading.Close()
        End Try
    End Sub

    Private Sub opennet()
        errorinupdate = ""
        Try
            Do
                Dim client As Net.WebClient = New Net.WebClient
                If threadwhattodo = 1 Then
                    updatestr = client.DownloadString("http://www.zchsoftware.xyz/check_for_updates/version.txt")
                    threadwhattodo = 0
                ElseIf threadwhattodo = 2 Then
                    Diagnostics.Process.Start("http://www.zchsoftware.xyz/check_for_updates/" & updateversion & ".exe")
                    threadwhattodo = 0
                End If
            Loop
        Catch ex As Exception
            errorinupdate = ex.Message
            threadwhattodo = 0
        End Try
    End Sub

    Private Sub ContextMenuStrip1_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip1.Opening
        If RichTextBox1.SelectedText.Length <> 0 Then
            剪切TToolStripMenuItem.Enabled = True
            复制ToolStripMenuItem.Enabled = True
        Else
            剪切TToolStripMenuItem.Enabled = False
            复制ToolStripMenuItem.Enabled = False
        End If
        If RichTextBox1.Text <> "" Then
            全选AToolStripMenuItem.Enabled = True
        Else
            全选AToolStripMenuItem.Enabled = False
        End If
        If Clipboard.ContainsText Then
            粘贴PToolStripMenuItem.Enabled = True
        Else
            粘贴PToolStripMenuItem.Enabled = False
        End If
    End Sub

    Private Sub 剪切TToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 剪切TToolStripMenuItem.Click
        RichTextBox1.Cut()
    End Sub

    Private Sub 复制ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 复制ToolStripMenuItem.Click
        RichTextBox1.Copy()
    End Sub

    Private Sub 全选AToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 全选AToolStripMenuItem.Click
        RichTextBox1.SelectAll()
    End Sub

    Private Sub 粘贴PToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 粘贴PToolStripMenuItem.Click
        RichTextBox1.Paste()
    End Sub

    Private Sub Form_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Me.TopMost = True
        Me.TopMost = False
        Me.Focus()
    End Sub

    Private Sub Form_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        If Me.Visible = True Then
            Me.TopMost = True
            Me.TopMost = False
            Me.Focus()
        End If
    End Sub

    Private Sub 时间ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 时间ToolStripMenuItem.Click
        RichTextBox1.Focus()
        SendKeys.Send(Now)
        DoEvents()
    End Sub

    Private Sub 快捷键KToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 快捷键KToolStripMenuItem.Click
        kuaijiejian.Show()
    End Sub

    Private Sub 空格符IToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 空格符IToolStripMenuItem.Click
        RichTextBox1.Focus()
        SendKeys.Send("^I")
        DoEvents()
    End Sub

    Private Sub setwjgl()

    End Sub
End Class
