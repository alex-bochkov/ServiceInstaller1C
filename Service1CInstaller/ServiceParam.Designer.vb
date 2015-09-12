<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ServiceParam
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ServiceParam))
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.PortProcessEnd = New System.Windows.Forms.MaskedTextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PortProcessBegin = New System.Windows.Forms.MaskedTextBox()
        Me.PortMngr = New System.Windows.Forms.MaskedTextBox()
        Me.DisplayName = New System.Windows.Forms.TextBox()
        Me.ExeFile = New System.Windows.Forms.TextBox()
        Me.PortAgent = New System.Windows.Forms.MaskedTextBox()
        Me.ClusterFiles = New System.Windows.Forms.TextBox()
        Me.CheckBoxDebug = New System.Windows.Forms.CheckBox()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.FolderBrowserDialog = New System.Windows.Forms.FolderBrowserDialog()
        Me.OpenFileDialog = New System.Windows.Forms.OpenFileDialog()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.ButtonSave = New System.Windows.Forms.Button()
        Me.RadioButtonUser1 = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RadioButtonUser2 = New System.Windows.Forms.RadioButton()
        Me.Login = New System.Windows.Forms.TextBox()
        Me.Password = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(138, 94)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(50, 23)
        Me.Button3.TabIndex = 14
        Me.Button3.Text = "-1000"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(195, 94)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(50, 23)
        Me.Button2.TabIndex = 14
        Me.Button2.Text = "+1000"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'PortProcessEnd
        '
        Me.PortProcessEnd.Location = New System.Drawing.Point(195, 68)
        Me.PortProcessEnd.Mask = "00000"
        Me.PortProcessEnd.Name = "PortProcessEnd"
        Me.PortProcessEnd.Size = New System.Drawing.Size(50, 20)
        Me.PortProcessEnd.TabIndex = 13
        Me.PortProcessEnd.ValidatingType = GetType(Integer)
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(7, 6)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(149, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Отображаемое имя службы"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(152, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Путь к исполняемому файлу"
        '
        'PortProcessBegin
        '
        Me.PortProcessBegin.Location = New System.Drawing.Point(138, 68)
        Me.PortProcessBegin.Mask = "00000"
        Me.PortProcessBegin.Name = "PortProcessBegin"
        Me.PortProcessBegin.Size = New System.Drawing.Size(51, 20)
        Me.PortProcessBegin.TabIndex = 13
        Me.PortProcessBegin.ValidatingType = GetType(Integer)
        '
        'PortMngr
        '
        Me.PortMngr.Location = New System.Drawing.Point(138, 44)
        Me.PortMngr.Mask = "00000"
        Me.PortMngr.Name = "PortMngr"
        Me.PortMngr.Size = New System.Drawing.Size(51, 20)
        Me.PortMngr.TabIndex = 13
        Me.PortMngr.ValidatingType = GetType(Integer)
        '
        'DisplayName
        '
        Me.DisplayName.BackColor = System.Drawing.SystemColors.Window
        Me.DisplayName.Location = New System.Drawing.Point(5, 22)
        Me.DisplayName.Name = "DisplayName"
        Me.DisplayName.Size = New System.Drawing.Size(531, 20)
        Me.DisplayName.TabIndex = 9
        '
        'ExeFile
        '
        Me.ExeFile.Location = New System.Drawing.Point(5, 61)
        Me.ExeFile.Name = "ExeFile"
        Me.ExeFile.Size = New System.Drawing.Size(454, 20)
        Me.ExeFile.TabIndex = 9
        '
        'PortAgent
        '
        Me.PortAgent.Location = New System.Drawing.Point(138, 18)
        Me.PortAgent.Mask = "00000"
        Me.PortAgent.Name = "PortAgent"
        Me.PortAgent.Size = New System.Drawing.Size(51, 20)
        Me.PortAgent.TabIndex = 13
        Me.PortAgent.ValidatingType = GetType(Integer)
        '
        'ClusterFiles
        '
        Me.ClusterFiles.Location = New System.Drawing.Point(5, 97)
        Me.ClusterFiles.Name = "ClusterFiles"
        Me.ClusterFiles.Size = New System.Drawing.Size(454, 20)
        Me.ClusterFiles.TabIndex = 9
        '
        'CheckBoxDebug
        '
        Me.CheckBoxDebug.AutoSize = True
        Me.CheckBoxDebug.Location = New System.Drawing.Point(10, 252)
        Me.CheckBoxDebug.Name = "CheckBoxDebug"
        Me.CheckBoxDebug.Size = New System.Drawing.Size(185, 17)
        Me.CheckBoxDebug.TabIndex = 12
        Me.CheckBoxDebug.Text = "Разрешить отладку на сервере"
        Me.CheckBoxDebug.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(465, 59)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(71, 23)
        Me.Button6.TabIndex = 10
        Me.Button6.Text = "Выбрать"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 71)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(105, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Рабочих процессов"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(465, 95)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(71, 23)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "Выбрать"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 46)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(116, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Менеджера кластера"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 81)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(139, 13)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Каталог файлов кластера"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(103, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Агента сервера 1С"
        '
        'OpenFileDialog
        '
        Me.OpenFileDialog.FileName = "OpenFileDialog"
        Me.OpenFileDialog.Filter = "ragent.exe|ragent.exe"
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Button4.Image = Global.Service1CInstaller.My.Resources.Resources._stop
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button4.Location = New System.Drawing.Point(275, 275)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(261, 48)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "Отменить операцию"
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button4.UseVisualStyleBackColor = True
        '
        'ButtonSave
        '
        Me.ButtonSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.ButtonSave.Image = Global.Service1CInstaller.My.Resources.Resources.save_all
        Me.ButtonSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonSave.Location = New System.Drawing.Point(5, 275)
        Me.ButtonSave.Name = "ButtonSave"
        Me.ButtonSave.Size = New System.Drawing.Size(264, 48)
        Me.ButtonSave.TabIndex = 3
        Me.ButtonSave.Text = "Сохранить изменения"
        Me.ButtonSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonSave.UseVisualStyleBackColor = True
        '
        'RadioButtonUser1
        '
        Me.RadioButtonUser1.AutoSize = True
        Me.RadioButtonUser1.Location = New System.Drawing.Point(17, 19)
        Me.RadioButtonUser1.Name = "RadioButtonUser1"
        Me.RadioButtonUser1.Size = New System.Drawing.Size(129, 17)
        Me.RadioButtonUser1.TabIndex = 15
        Me.RadioButtonUser1.TabStop = True
        Me.RadioButtonUser1.Text = "Локальной системы"
        Me.RadioButtonUser1.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Password)
        Me.GroupBox1.Controls.Add(Me.Login)
        Me.GroupBox1.Controls.Add(Me.RadioButtonUser2)
        Me.GroupBox1.Controls.Add(Me.RadioButtonUser1)
        Me.GroupBox1.Location = New System.Drawing.Point(275, 123)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(261, 123)
        Me.GroupBox1.TabIndex = 16
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Вход от имени"
        '
        'RadioButtonUser2
        '
        Me.RadioButtonUser2.AutoSize = True
        Me.RadioButtonUser2.Location = New System.Drawing.Point(17, 42)
        Me.RadioButtonUser2.Name = "RadioButtonUser2"
        Me.RadioButtonUser2.Size = New System.Drawing.Size(161, 17)
        Me.RadioButtonUser2.TabIndex = 15
        Me.RadioButtonUser2.TabStop = True
        Me.RadioButtonUser2.Text = "Отдельной учетной записи"
        Me.RadioButtonUser2.UseVisualStyleBackColor = True
        '
        'Login
        '
        Me.Login.Location = New System.Drawing.Point(81, 66)
        Me.Login.Name = "Login"
        Me.Login.Size = New System.Drawing.Size(134, 20)
        Me.Login.TabIndex = 16
        '
        'Password
        '
        Me.Password.Location = New System.Drawing.Point(81, 92)
        Me.Password.Name = "Password"
        Me.Password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Password.Size = New System.Drawing.Size(134, 20)
        Me.Password.TabIndex = 16
        Me.Password.UseSystemPasswordChar = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(32, 69)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(38, 13)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Логин"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(32, 94)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(45, 13)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "Пароль"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Button3)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Button2)
        Me.GroupBox2.Controls.Add(Me.PortAgent)
        Me.GroupBox2.Controls.Add(Me.PortMngr)
        Me.GroupBox2.Controls.Add(Me.PortProcessEnd)
        Me.GroupBox2.Controls.Add(Me.PortProcessBegin)
        Me.GroupBox2.Location = New System.Drawing.Point(8, 123)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(261, 123)
        Me.GroupBox2.TabIndex = 18
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Рабочие порты"
        '
        'ServiceParam
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(543, 328)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.ButtonSave)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DisplayName)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.ExeFile)
        Me.Controls.Add(Me.CheckBoxDebug)
        Me.Controls.Add(Me.ClusterFiles)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ServiceParam"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Параметры запуска службы сервера 1С"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents PortProcessEnd As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PortProcessBegin As System.Windows.Forms.MaskedTextBox
    Friend WithEvents ButtonSave As System.Windows.Forms.Button
    Friend WithEvents PortMngr As System.Windows.Forms.MaskedTextBox
    Friend WithEvents DisplayName As System.Windows.Forms.TextBox
    Friend WithEvents ExeFile As System.Windows.Forms.TextBox
    Friend WithEvents PortAgent As System.Windows.Forms.MaskedTextBox
    Friend WithEvents ClusterFiles As System.Windows.Forms.TextBox
    Friend WithEvents CheckBoxDebug As System.Windows.Forms.CheckBox
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents FolderBrowserDialog As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents OpenFileDialog As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents RadioButtonUser1 As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Password As System.Windows.Forms.TextBox
    Friend WithEvents Login As System.Windows.Forms.TextBox
    Friend WithEvents RadioButtonUser2 As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
End Class
