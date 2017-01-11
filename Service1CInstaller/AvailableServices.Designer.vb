<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AvailableServices
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AvailableServices))
        Me.ListAllServices = New System.Windows.Forms.ListView()
        Me.ItemServiceType = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ItemAppPath = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ItemVersion = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ItemServiceTypePresentation = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ButtonAdd = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'ListAllServices
        '
        Me.ListAllServices.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListAllServices.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ItemServiceType, Me.ItemServiceTypePresentation, Me.ItemAppPath, Me.ItemVersion})
        Me.ListAllServices.FullRowSelect = True
        Me.ListAllServices.Location = New System.Drawing.Point(6, 17)
        Me.ListAllServices.MultiSelect = False
        Me.ListAllServices.Name = "ListAllServices"
        Me.ListAllServices.Size = New System.Drawing.Size(877, 270)
        Me.ListAllServices.TabIndex = 20
        Me.ListAllServices.UseCompatibleStateImageBehavior = False
        Me.ListAllServices.View = System.Windows.Forms.View.Details
        '
        'ItemServiceType
        '
        Me.ItemServiceType.Text = "Код службы"
        Me.ItemServiceType.Width = 0
        '
        'ItemAppPath
        '
        Me.ItemAppPath.Text = "Путь к исполняемому файлу"
        Me.ItemAppPath.Width = 462
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ListAllServices)
        Me.GroupBox1.Location = New System.Drawing.Point(4, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(889, 296)
        Me.GroupBox1.TabIndex = 21
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Создать новую службу из числа установленных приложений?"
        '
        'ItemVersion
        '
        Me.ItemVersion.Text = "Версия приложения"
        Me.ItemVersion.Width = 118
        '
        'ItemServiceTypePresentation
        '
        Me.ItemServiceTypePresentation.Text = "Вид службы"
        Me.ItemServiceTypePresentation.Width = 216
        '
        'ButtonAdd
        '
        Me.ButtonAdd.Image = Global.Service1CInstaller.My.Resources.Resources.edit_add_3860
        Me.ButtonAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonAdd.Location = New System.Drawing.Point(8, 15)
        Me.ButtonAdd.Name = "ButtonAdd"
        Me.ButtonAdd.Size = New System.Drawing.Size(287, 48)
        Me.ButtonAdd.TabIndex = 21
        Me.ButtonAdd.Text = "Новая служба сервера приложений"
        Me.ButtonAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonAdd.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Button2)
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(Me.ButtonAdd)
        Me.GroupBox2.Location = New System.Drawing.Point(4, 302)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(889, 69)
        Me.GroupBox2.TabIndex = 22
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Или ввести все параметры вручную"
        '
        'Button1
        '
        Me.Button1.Image = Global.Service1CInstaller.My.Resources.Resources.edit_add_3860
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(301, 15)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(287, 48)
        Me.Button1.TabIndex = 21
        Me.Button1.Text = "Новая служба сервера хранилища"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Image = Global.Service1CInstaller.My.Resources.Resources.edit_add_3860
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(594, 15)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(287, 48)
        Me.Button2.TabIndex = 21
        Me.Button2.Text = "Новая служба сервера администрирования"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button2.UseVisualStyleBackColor = True
        '
        'AvailableServices
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(898, 375)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "AvailableServices"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AvailableServices"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ListAllServices As ListView
    Friend WithEvents ItemServiceType As ColumnHeader
    Friend WithEvents ItemAppPath As ColumnHeader
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ItemServiceTypePresentation As ColumnHeader
    Friend WithEvents ItemVersion As ColumnHeader
    Friend WithEvents ButtonAdd As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
End Class
