<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.文件ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.新建ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.打开ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.保存SToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.另存为AToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.退出XToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.编辑ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.撤销ZToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.重复ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.查找ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.查找下一个NToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.替换IToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.转到GToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.空格符IToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.时间ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.格式EToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.自动换行AToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.字体FToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.工具TToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.将文件转为加密格式ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.将加密文件解密ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.帮助HToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.快捷键KToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.检查更新CToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.关于JMS编辑器AToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.撤销ZToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.重复YToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.剪切TToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.复制ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.粘贴PToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.全选AToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.FontDialog1 = New System.Windows.Forms.FontDialog()
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.MenuStrip1.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.AutoSize = False
        Me.MenuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(36, 36)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.文件ToolStripMenuItem, Me.编辑ToolStripMenuItem, Me.格式EToolStripMenuItem, Me.工具TToolStripMenuItem, Me.帮助HToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(7, 3, 0, 3)
        Me.MenuStrip1.Size = New System.Drawing.Size(964, 65)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        '文件ToolStripMenuItem
        '
        Me.文件ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.新建ToolStripMenuItem, Me.打开ToolStripMenuItem, Me.保存SToolStripMenuItem, Me.另存为AToolStripMenuItem, Me.ToolStripSeparator1, Me.退出XToolStripMenuItem})
        Me.文件ToolStripMenuItem.Image = CType(resources.GetObject("文件ToolStripMenuItem.Image"), System.Drawing.Image)
        Me.文件ToolStripMenuItem.Name = "文件ToolStripMenuItem"
        Me.文件ToolStripMenuItem.Size = New System.Drawing.Size(58, 59)
        Me.文件ToolStripMenuItem.Text = "文件(&F)"
        Me.文件ToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        '新建ToolStripMenuItem
        '
        Me.新建ToolStripMenuItem.Image = CType(resources.GetObject("新建ToolStripMenuItem.Image"), System.Drawing.Image)
        Me.新建ToolStripMenuItem.Name = "新建ToolStripMenuItem"
        Me.新建ToolStripMenuItem.Size = New System.Drawing.Size(148, 42)
        Me.新建ToolStripMenuItem.Text = "新建(&N)"
        '
        '打开ToolStripMenuItem
        '
        Me.打开ToolStripMenuItem.Image = CType(resources.GetObject("打开ToolStripMenuItem.Image"), System.Drawing.Image)
        Me.打开ToolStripMenuItem.Name = "打开ToolStripMenuItem"
        Me.打开ToolStripMenuItem.Size = New System.Drawing.Size(148, 42)
        Me.打开ToolStripMenuItem.Text = "打开(&O)"
        '
        '保存SToolStripMenuItem
        '
        Me.保存SToolStripMenuItem.Image = CType(resources.GetObject("保存SToolStripMenuItem.Image"), System.Drawing.Image)
        Me.保存SToolStripMenuItem.Name = "保存SToolStripMenuItem"
        Me.保存SToolStripMenuItem.Size = New System.Drawing.Size(148, 42)
        Me.保存SToolStripMenuItem.Text = "保存(&S)"
        '
        '另存为AToolStripMenuItem
        '
        Me.另存为AToolStripMenuItem.Image = CType(resources.GetObject("另存为AToolStripMenuItem.Image"), System.Drawing.Image)
        Me.另存为AToolStripMenuItem.Name = "另存为AToolStripMenuItem"
        Me.另存为AToolStripMenuItem.Size = New System.Drawing.Size(148, 42)
        Me.另存为AToolStripMenuItem.Text = "另存为(&A)"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(145, 6)
        '
        '退出XToolStripMenuItem
        '
        Me.退出XToolStripMenuItem.Image = CType(resources.GetObject("退出XToolStripMenuItem.Image"), System.Drawing.Image)
        Me.退出XToolStripMenuItem.Name = "退出XToolStripMenuItem"
        Me.退出XToolStripMenuItem.Size = New System.Drawing.Size(148, 42)
        Me.退出XToolStripMenuItem.Text = "退出(&X)"
        '
        '编辑ToolStripMenuItem
        '
        Me.编辑ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.撤销ZToolStripMenuItem, Me.重复ToolStripMenuItem, Me.ToolStripSeparator2, Me.查找ToolStripMenuItem, Me.查找下一个NToolStripMenuItem, Me.替换IToolStripMenuItem, Me.转到GToolStripMenuItem, Me.ToolStripSeparator6, Me.空格符IToolStripMenuItem, Me.时间ToolStripMenuItem})
        Me.编辑ToolStripMenuItem.Image = CType(resources.GetObject("编辑ToolStripMenuItem.Image"), System.Drawing.Image)
        Me.编辑ToolStripMenuItem.Name = "编辑ToolStripMenuItem"
        Me.编辑ToolStripMenuItem.Size = New System.Drawing.Size(59, 59)
        Me.编辑ToolStripMenuItem.Text = "编辑(&E)"
        Me.编辑ToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        '撤销ZToolStripMenuItem
        '
        Me.撤销ZToolStripMenuItem.Image = CType(resources.GetObject("撤销ZToolStripMenuItem.Image"), System.Drawing.Image)
        Me.撤销ZToolStripMenuItem.Name = "撤销ZToolStripMenuItem"
        Me.撤销ZToolStripMenuItem.Size = New System.Drawing.Size(174, 42)
        Me.撤销ZToolStripMenuItem.Text = "撤销(&Z)"
        '
        '重复ToolStripMenuItem
        '
        Me.重复ToolStripMenuItem.Image = CType(resources.GetObject("重复ToolStripMenuItem.Image"), System.Drawing.Image)
        Me.重复ToolStripMenuItem.Name = "重复ToolStripMenuItem"
        Me.重复ToolStripMenuItem.Size = New System.Drawing.Size(174, 42)
        Me.重复ToolStripMenuItem.Text = "重复(&Y)"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(171, 6)
        '
        '查找ToolStripMenuItem
        '
        Me.查找ToolStripMenuItem.Image = CType(resources.GetObject("查找ToolStripMenuItem.Image"), System.Drawing.Image)
        Me.查找ToolStripMenuItem.Name = "查找ToolStripMenuItem"
        Me.查找ToolStripMenuItem.Size = New System.Drawing.Size(174, 42)
        Me.查找ToolStripMenuItem.Text = "查找(&F)"
        '
        '查找下一个NToolStripMenuItem
        '
        Me.查找下一个NToolStripMenuItem.Image = CType(resources.GetObject("查找下一个NToolStripMenuItem.Image"), System.Drawing.Image)
        Me.查找下一个NToolStripMenuItem.Name = "查找下一个NToolStripMenuItem"
        Me.查找下一个NToolStripMenuItem.Size = New System.Drawing.Size(174, 42)
        Me.查找下一个NToolStripMenuItem.Text = "查找下一个(&N)"
        '
        '替换IToolStripMenuItem
        '
        Me.替换IToolStripMenuItem.Image = CType(resources.GetObject("替换IToolStripMenuItem.Image"), System.Drawing.Image)
        Me.替换IToolStripMenuItem.Name = "替换IToolStripMenuItem"
        Me.替换IToolStripMenuItem.Size = New System.Drawing.Size(174, 42)
        Me.替换IToolStripMenuItem.Text = "替换(&R)"
        '
        '转到GToolStripMenuItem
        '
        Me.转到GToolStripMenuItem.Image = CType(resources.GetObject("转到GToolStripMenuItem.Image"), System.Drawing.Image)
        Me.转到GToolStripMenuItem.Name = "转到GToolStripMenuItem"
        Me.转到GToolStripMenuItem.Size = New System.Drawing.Size(174, 42)
        Me.转到GToolStripMenuItem.Text = "转到(&G)"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(171, 6)
        '
        '空格符IToolStripMenuItem
        '
        Me.空格符IToolStripMenuItem.Name = "空格符IToolStripMenuItem"
        Me.空格符IToolStripMenuItem.Size = New System.Drawing.Size(174, 42)
        Me.空格符IToolStripMenuItem.Text = "空格符(&I)"
        '
        '时间ToolStripMenuItem
        '
        Me.时间ToolStripMenuItem.Image = CType(resources.GetObject("时间ToolStripMenuItem.Image"), System.Drawing.Image)
        Me.时间ToolStripMenuItem.Name = "时间ToolStripMenuItem"
        Me.时间ToolStripMenuItem.Size = New System.Drawing.Size(174, 42)
        Me.时间ToolStripMenuItem.Text = "时间/日期(&D)"
        '
        '格式EToolStripMenuItem
        '
        Me.格式EToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.自动换行AToolStripMenuItem, Me.字体FToolStripMenuItem})
        Me.格式EToolStripMenuItem.Image = CType(resources.GetObject("格式EToolStripMenuItem.Image"), System.Drawing.Image)
        Me.格式EToolStripMenuItem.Name = "格式EToolStripMenuItem"
        Me.格式EToolStripMenuItem.Size = New System.Drawing.Size(62, 59)
        Me.格式EToolStripMenuItem.Text = "格式(&O)"
        Me.格式EToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        '自动换行AToolStripMenuItem
        '
        Me.自动换行AToolStripMenuItem.Checked = True
        Me.自动换行AToolStripMenuItem.CheckOnClick = True
        Me.自动换行AToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.自动换行AToolStripMenuItem.Image = CType(resources.GetObject("自动换行AToolStripMenuItem.Image"), System.Drawing.Image)
        Me.自动换行AToolStripMenuItem.Name = "自动换行AToolStripMenuItem"
        Me.自动换行AToolStripMenuItem.Size = New System.Drawing.Size(172, 42)
        Me.自动换行AToolStripMenuItem.Text = "自动换行(&W)"
        '
        '字体FToolStripMenuItem
        '
        Me.字体FToolStripMenuItem.Image = CType(resources.GetObject("字体FToolStripMenuItem.Image"), System.Drawing.Image)
        Me.字体FToolStripMenuItem.Name = "字体FToolStripMenuItem"
        Me.字体FToolStripMenuItem.Size = New System.Drawing.Size(164, 42)
        Me.字体FToolStripMenuItem.Text = "字体(&F)"
        '
        '工具TToolStripMenuItem
        '
        Me.工具TToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.将文件转为加密格式ToolStripMenuItem, Me.将加密文件解密ToolStripMenuItem})
        Me.工具TToolStripMenuItem.Image = CType(resources.GetObject("工具TToolStripMenuItem.Image"), System.Drawing.Image)
        Me.工具TToolStripMenuItem.Name = "工具TToolStripMenuItem"
        Me.工具TToolStripMenuItem.Size = New System.Drawing.Size(59, 59)
        Me.工具TToolStripMenuItem.Text = "工具(&T)"
        Me.工具TToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.工具TToolStripMenuItem.Visible = False
        '
        '将文件转为加密格式ToolStripMenuItem
        '
        Me.将文件转为加密格式ToolStripMenuItem.Name = "将文件转为加密格式ToolStripMenuItem"
        Me.将文件转为加密格式ToolStripMenuItem.Size = New System.Drawing.Size(201, 22)
        Me.将文件转为加密格式ToolStripMenuItem.Text = "将文件转为加密格式(&L)"
        '
        '将加密文件解密ToolStripMenuItem
        '
        Me.将加密文件解密ToolStripMenuItem.Name = "将加密文件解密ToolStripMenuItem"
        Me.将加密文件解密ToolStripMenuItem.Size = New System.Drawing.Size(201, 22)
        Me.将加密文件解密ToolStripMenuItem.Text = "将已加密的文件解密(&U)"
        '
        '帮助HToolStripMenuItem
        '
        Me.帮助HToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.快捷键KToolStripMenuItem, Me.ToolStripSeparator7, Me.检查更新CToolStripMenuItem, Me.ToolStripSeparator3, Me.关于JMS编辑器AToolStripMenuItem})
        Me.帮助HToolStripMenuItem.Image = CType(resources.GetObject("帮助HToolStripMenuItem.Image"), System.Drawing.Image)
        Me.帮助HToolStripMenuItem.Name = "帮助HToolStripMenuItem"
        Me.帮助HToolStripMenuItem.Size = New System.Drawing.Size(61, 59)
        Me.帮助HToolStripMenuItem.Text = "帮助(&H)"
        Me.帮助HToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        '快捷键KToolStripMenuItem
        '
        Me.快捷键KToolStripMenuItem.Image = CType(resources.GetObject("快捷键KToolStripMenuItem.Image"), System.Drawing.Image)
        Me.快捷键KToolStripMenuItem.Name = "快捷键KToolStripMenuItem"
        Me.快捷键KToolStripMenuItem.Size = New System.Drawing.Size(248, 42)
        Me.快捷键KToolStripMenuItem.Text = "快捷键(&K)"
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(245, 6)
        '
        '检查更新CToolStripMenuItem
        '
        Me.检查更新CToolStripMenuItem.Image = CType(resources.GetObject("检查更新CToolStripMenuItem.Image"), System.Drawing.Image)
        Me.检查更新CToolStripMenuItem.Name = "检查更新CToolStripMenuItem"
        Me.检查更新CToolStripMenuItem.Size = New System.Drawing.Size(248, 42)
        Me.检查更新CToolStripMenuItem.Text = "检查更新(&C)"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(245, 6)
        '
        '关于JMS编辑器AToolStripMenuItem
        '
        Me.关于JMS编辑器AToolStripMenuItem.Image = CType(resources.GetObject("关于JMS编辑器AToolStripMenuItem.Image"), System.Drawing.Image)
        Me.关于JMS编辑器AToolStripMenuItem.Name = "关于JMS编辑器AToolStripMenuItem"
        Me.关于JMS编辑器AToolStripMenuItem.Size = New System.Drawing.Size(248, 42)
        Me.关于JMS编辑器AToolStripMenuItem.Text = "关于 加密之神文件编辑器(&A)"
        '
        'RichTextBox1
        '
        Me.RichTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RichTextBox1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.RichTextBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RichTextBox1.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.RichTextBox1.Location = New System.Drawing.Point(0, 65)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth
        Me.RichTextBox1.Size = New System.Drawing.Size(964, 452)
        Me.RichTextBox1.TabIndex = 1
        Me.RichTextBox1.Text = ""
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.撤销ZToolStripMenuItem1, Me.重复YToolStripMenuItem, Me.ToolStripSeparator4, Me.剪切TToolStripMenuItem, Me.复制ToolStripMenuItem, Me.粘贴PToolStripMenuItem, Me.ToolStripSeparator5, Me.全选AToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(117, 148)
        '
        '撤销ZToolStripMenuItem1
        '
        Me.撤销ZToolStripMenuItem1.Name = "撤销ZToolStripMenuItem1"
        Me.撤销ZToolStripMenuItem1.Size = New System.Drawing.Size(116, 22)
        Me.撤销ZToolStripMenuItem1.Text = "撤销(&Z)"
        '
        '重复YToolStripMenuItem
        '
        Me.重复YToolStripMenuItem.Name = "重复YToolStripMenuItem"
        Me.重复YToolStripMenuItem.Size = New System.Drawing.Size(116, 22)
        Me.重复YToolStripMenuItem.Text = "重复(&Y)"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(113, 6)
        '
        '剪切TToolStripMenuItem
        '
        Me.剪切TToolStripMenuItem.Name = "剪切TToolStripMenuItem"
        Me.剪切TToolStripMenuItem.Size = New System.Drawing.Size(116, 22)
        Me.剪切TToolStripMenuItem.Text = "剪切(&T)"
        '
        '复制ToolStripMenuItem
        '
        Me.复制ToolStripMenuItem.Name = "复制ToolStripMenuItem"
        Me.复制ToolStripMenuItem.Size = New System.Drawing.Size(116, 22)
        Me.复制ToolStripMenuItem.Text = "复制(&C)"
        '
        '粘贴PToolStripMenuItem
        '
        Me.粘贴PToolStripMenuItem.Name = "粘贴PToolStripMenuItem"
        Me.粘贴PToolStripMenuItem.Size = New System.Drawing.Size(116, 22)
        Me.粘贴PToolStripMenuItem.Text = "粘贴(&P)"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(113, 6)
        '
        '全选AToolStripMenuItem
        '
        Me.全选AToolStripMenuItem.Name = "全选AToolStripMenuItem"
        Me.全选AToolStripMenuItem.Size = New System.Drawing.Size(116, 22)
        Me.全选AToolStripMenuItem.Text = "全选(&A)"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.Text = "加密之神文件编辑器"
        Me.NotifyIcon1.Visible = True
        '
        'Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(964, 517)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Form"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "加密之神文件编辑器"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents 文件ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 新建ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 打开ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 保存SToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 另存为AToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 退出XToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents 编辑ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 格式EToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 撤销ZToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 查找ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 查找下一个NToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 替换IToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 转到GToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 自动换行AToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 字体FToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents FontDialog1 As System.Windows.Forms.FontDialog
    Friend WithEvents 帮助HToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 关于JMS编辑器AToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents 工具TToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 将文件转为加密格式ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 将加密文件解密ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 检查更新CToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents NotifyIcon1 As System.Windows.Forms.NotifyIcon
    Friend WithEvents 重复ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents 撤销ZToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 重复YToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents 剪切TToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 复制ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 粘贴PToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents 全选AToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents 时间ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 快捷键KToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator7 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents 空格符IToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
