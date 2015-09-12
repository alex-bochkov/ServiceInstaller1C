<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Форма переопределяет dispose для очистки списка компонентов.
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

    'Является обязательной для конструктора форм Windows Forms
    Private components As System.ComponentModel.IContainer

    'Примечание: следующая процедура является обязательной для конструктора форм Windows Forms
    'Для ее изменения используйте конструктор форм Windows Form.  
    'Не изменяйте ее в редакторе исходного кода.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.LinkLabel4 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel3 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.ListViewExistedServices = New System.Windows.Forms.ListView()
        Me.ServiceName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Status = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Port = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ClusterFiles = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.PathName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ButtonDelete = New System.Windows.Forms.Button()
        Me.ButtonEdit = New System.Windows.Forms.Button()
        Me.ButtonAdd = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.LinkLabel4)
        Me.GroupBox1.Controls.Add(Me.LinkLabel3)
        Me.GroupBox1.Controls.Add(Me.LinkLabel2)
        Me.GroupBox1.Controls.Add(Me.LinkLabel1)
        Me.GroupBox1.Controls.Add(Me.ListViewExistedServices)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(752, 259)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Установленные службы ""1С:Предприятие 8"""
        '
        'LinkLabel4
        '
        Me.LinkLabel4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LinkLabel4.AutoSize = True
        Me.LinkLabel4.Location = New System.Drawing.Point(649, 243)
        Me.LinkLabel4.Name = "LinkLabel4"
        Me.LinkLabel4.Size = New System.Drawing.Size(95, 13)
        Me.LinkLabel4.TabIndex = 3
        Me.LinkLabel4.TabStop = True
        Me.LinkLabel4.Text = "Обновить список"
        '
        'LinkLabel3
        '
        Me.LinkLabel3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LinkLabel3.AutoSize = True
        Me.LinkLabel3.Enabled = False
        Me.LinkLabel3.Location = New System.Drawing.Point(141, 243)
        Me.LinkLabel3.Name = "LinkLabel3"
        Me.LinkLabel3.Size = New System.Drawing.Size(84, 13)
        Me.LinkLabel3.TabIndex = 3
        Me.LinkLabel3.TabStop = True
        Me.LinkLabel3.Text = "Перезапустить"
        '
        'LinkLabel2
        '
        Me.LinkLabel2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LinkLabel2.AutoSize = True
        Me.LinkLabel2.Enabled = False
        Me.LinkLabel2.Location = New System.Drawing.Point(68, 243)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(67, 13)
        Me.LinkLabel2.TabIndex = 3
        Me.LinkLabel2.TabStop = True
        Me.LinkLabel2.Text = "Остановить"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Enabled = False
        Me.LinkLabel1.Location = New System.Drawing.Point(3, 243)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(59, 13)
        Me.LinkLabel1.TabIndex = 3
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Запустить"
        '
        'ListViewExistedServices
        '
        Me.ListViewExistedServices.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListViewExistedServices.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ServiceName, Me.Status, Me.Port, Me.ClusterFiles, Me.PathName})
        Me.ListViewExistedServices.FullRowSelect = True
        Me.ListViewExistedServices.Location = New System.Drawing.Point(6, 19)
        Me.ListViewExistedServices.MultiSelect = False
        Me.ListViewExistedServices.Name = "ListViewExistedServices"
        Me.ListViewExistedServices.Size = New System.Drawing.Size(738, 221)
        Me.ListViewExistedServices.TabIndex = 2
        Me.ListViewExistedServices.UseCompatibleStateImageBehavior = False
        Me.ListViewExistedServices.View = System.Windows.Forms.View.Details
        '
        'ServiceName
        '
        Me.ServiceName.Text = "Имя службы"
        Me.ServiceName.Width = 249
        '
        'Status
        '
        Me.Status.Text = "Состояние"
        Me.Status.Width = 85
        '
        'Port
        '
        Me.Port.Text = "Порт"
        Me.Port.Width = 50
        '
        'ClusterFiles
        '
        Me.ClusterFiles.Text = "Каталог файлов кластера"
        Me.ClusterFiles.Width = 197
        '
        'PathName
        '
        Me.PathName.Text = "Строка запуска"
        Me.PathName.Width = 525
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button1.Image = Global.Service1CInstaller.My.Resources.Resources.info
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(634, 270)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(123, 48)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "О программе"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ButtonDelete
        '
        Me.ButtonDelete.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ButtonDelete.Image = Global.Service1CInstaller.My.Resources.Resources.edit_delete_5986
        Me.ButtonDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonDelete.Location = New System.Drawing.Point(424, 270)
        Me.ButtonDelete.Name = "ButtonDelete"
        Me.ButtonDelete.Size = New System.Drawing.Size(204, 48)
        Me.ButtonDelete.TabIndex = 3
        Me.ButtonDelete.Text = "Удалить выделенную службу"
        Me.ButtonDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonDelete.UseVisualStyleBackColor = True
        '
        'ButtonEdit
        '
        Me.ButtonEdit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ButtonEdit.Image = Global.Service1CInstaller.My.Resources.Resources.edit
        Me.ButtonEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonEdit.Location = New System.Drawing.Point(214, 270)
        Me.ButtonEdit.Name = "ButtonEdit"
        Me.ButtonEdit.Size = New System.Drawing.Size(204, 48)
        Me.ButtonEdit.TabIndex = 3
        Me.ButtonEdit.Text = "Изменить выделенную службу"
        Me.ButtonEdit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonEdit.UseVisualStyleBackColor = True
        '
        'ButtonAdd
        '
        Me.ButtonAdd.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ButtonAdd.Image = Global.Service1CInstaller.My.Resources.Resources.edit_add_3860
        Me.ButtonAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonAdd.Location = New System.Drawing.Point(6, 270)
        Me.ButtonAdd.Name = "ButtonAdd"
        Me.ButtonAdd.Size = New System.Drawing.Size(202, 48)
        Me.ButtonAdd.TabIndex = 3
        Me.ButtonAdd.Text = "Добавить новую службу Скопировать выделенную"
        Me.ButtonAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonAdd.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(762, 321)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ButtonDelete)
        Me.Controls.Add(Me.ButtonEdit)
        Me.Controls.Add(Me.ButtonAdd)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ButtonEdit As System.Windows.Forms.Button
    Friend WithEvents ButtonAdd As System.Windows.Forms.Button
    Friend WithEvents ButtonDelete As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ListViewExistedServices As System.Windows.Forms.ListView
    Friend WithEvents ServiceName As System.Windows.Forms.ColumnHeader
    Friend WithEvents PathName As System.Windows.Forms.ColumnHeader
    Friend WithEvents Port As System.Windows.Forms.ColumnHeader
    Friend WithEvents ClusterFiles As System.Windows.Forms.ColumnHeader
    Friend WithEvents LinkLabel3 As System.Windows.Forms.LinkLabel
    Friend WithEvents LinkLabel2 As System.Windows.Forms.LinkLabel
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents Status As System.Windows.Forms.ColumnHeader
    Friend WithEvents LinkLabel4 As System.Windows.Forms.LinkLabel

End Class
