Imports System.Management
Imports System.Runtime.InteropServices

Public Class ServiceParam

    Public Serv As Form1.Service
    Public ItsAdd As Boolean = False
    Public ItsEdit As Boolean = False

    Private Sub ServiceParam_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        ExeFile.Text = Serv.ExeFile
        ClusterFiles.Text = Serv.ClusterFiles
        PortAgent.Text = Serv.PortAgent
        PortMngr.Text = Serv.PortMngr
        PortProcessBegin.Text = Serv.PortProcessBegin
        PortProcessEnd.Text = Serv.PortProcessEnd

        CheckBoxDebug.Checked = Serv.Debug

        'DescriptionService.Text = Serv.Description
        DisplayName.Text = Serv.DisplayName

        'Локальная(система)
        'Локальная(служба)
        'Сетевая(служба)

        'If Serv.User = "NT AUTHORITY\NetworkService" Then
        '    RadioButtonUser1.Checked = True
        '    TechUser.Text = TechUser.Items(2)

        'ElseIf Serv.User = "NT AUTHORITY\LocalService" Then
        '    RadioButtonUser1.Checked = True
        '    TechUser.Text = TechUser.Items(1)

        'Else
        If Serv.User = "LocalSystem" Then
            RadioButtonUser1.Checked = True
        Else
            RadioButtonUser2.Checked = True
            Login.Text = Serv.User
            Password.Text = ""
        End If

        If ItsAdd Then
            Text = "Добавление новой службы сервера 1С"
        ElseIf ItsEdit Then
            Text = "Изменение параметров существующей службы сервера 1С"
        End If

    End Sub

    Private Sub Button6_Click(sender As System.Object, e As System.EventArgs) Handles Button6.Click

        OpenFileDialog.FileName = ExeFile.Text
        OpenFileDialog.ShowDialog()
        ExeFile.Text = OpenFileDialog.FileName

    End Sub



    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click

        FolderBrowserDialog.RootFolder = Environment.SpecialFolder.MyComputer
        FolderBrowserDialog.SelectedPath = ClusterFiles.Text
        FolderBrowserDialog.ShowDialog()
        ClusterFiles.Text = FolderBrowserDialog.SelectedPath

    End Sub

    Private Sub Button3_Click_1(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        PortAgent.Text = (Convert.ToInt32(PortAgent.Text) - 1000).ToString
        PortMngr.Text = (Convert.ToInt32(PortMngr.Text) - 1000).ToString
        PortProcessBegin.Text = (Convert.ToInt32(PortProcessBegin.Text) - 1000).ToString
        PortProcessEnd.Text = (Convert.ToInt32(PortProcessEnd.Text) - 1000).ToString
    End Sub

    Private Sub Button2_Click_1(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        PortAgent.Text = (Convert.ToInt32(PortAgent.Text) + 1000).ToString
        PortMngr.Text = (Convert.ToInt32(PortMngr.Text) + 1000).ToString
        PortProcessBegin.Text = (Convert.ToInt32(PortProcessBegin.Text) + 1000).ToString
        PortProcessEnd.Text = (Convert.ToInt32(PortProcessEnd.Text) + 1000).ToString
    End Sub

    Function GetNewNameForService() As String

        Dim BaseName = "1C:Enterprise 8 Server Agent #"
        Dim i = 1

        GetNewNameForService = BaseName + i.ToString

        While Not CheckNameForService(GetNewNameForService)

            i = i + 1

            GetNewNameForService = BaseName + i.ToString

        End While

    End Function

    Function CheckNameForService(Name As String) As Boolean

        Dim search As New ManagementObjectSearcher("SELECT * FROM Win32_Service WHERE Name = '" + Name + "'")

        CheckNameForService = (search.Get().Count = 0)

    End Function

    Sub SetDefaultColor()

        DisplayName.BackColor = Color.White
        ExeFile.BackColor = Color.White
        ClusterFiles.BackColor = Color.White

        PortAgent.BackColor = Color.White
        PortMngr.BackColor = Color.White
        PortProcessBegin.BackColor = Color.White
        PortProcessEnd.BackColor = Color.White

    End Sub


    Private Sub ButtonSave_Click(sender As System.Object, e As System.EventArgs) Handles ButtonSave.Click

        SetDefaultColor()

        If DisplayName.Text = "" Then
            DisplayName.BackColor = Color.Pink
            MsgBox("Отображаемое имя службы должно быть указано", , Text)
            Return
        End If

        If ItsAdd Then
            Dim search As New ManagementObjectSearcher("SELECT * FROM Win32_Service WHERE DisplayName = '" + DisplayName.Text + "'")

            If search.Get().Count > 0 Then
                DisplayName.BackColor = Color.Pink
                MsgBox("Служба с таким именем уже зарегистрирована. Укажите другое наименование.", , Text)
                Return
            End If
        End If




        If ExeFile.Text = "" Then
            ExeFile.BackColor = Color.Pink
            MsgBox("Путь к исполняемому файлу должен быть указан", , Text)
            Return
        End If

        If Not My.Computer.FileSystem.FileExists(ExeFile.Text) Then
            ExeFile.BackColor = Color.Pink
            MsgBox("Исполняемый файл не существует", , Text)
            Return
        End If

        If ClusterFiles.Text = "" Then
            ClusterFiles.BackColor = Color.Pink
            MsgBox("Путь к каталогу файлов кластера должен быть указан", , Text)
            Return
        End If

        'search = New ManagementObjectSearcher("SELECT * FROM Win32_Service WHERE PathName like '%ragent.exe%""" + ClusterFiles.Text + """%'")

        'If search.Get().Count > 0 Then
        '    ClusterFiles.BackColor = Color.Pink
        '    MsgBox("Уже существует служба, использующая этот каталог файлов кластера. " + _
        '           vbNewLine + "Укажите другой каталог", , Text)
        '    Return
        'End If

        If PortProcessEnd.Text = 0 _
            Or PortProcessBegin.Text = 0 _
            Or PortAgent.Text = 0 _
            Or PortMngr.Text = 0 _
            Then

            PortAgent.BackColor = Color.Pink
            PortMngr.BackColor = Color.Pink
            PortProcessBegin.BackColor = Color.Pink
            PortProcessEnd.BackColor = Color.Pink

            MsgBox("Значения портов агента сервера, менеджера кластера и рабочих процессов должны быть указаны", , Text)
            Return
        End If


        If Not PortProcessEnd.Text > PortProcessBegin.Text Then
            PortProcessEnd.BackColor = Color.Pink
            PortProcessBegin.BackColor = Color.Pink
            MsgBox("Конечный порт рабочего процесса должен быть больше начального порта", , Text)
            Return
        End If


        Dim PathName = """" + ExeFile.Text + """ {0} -srvc -agent -regport {1} -port {2} -range {3}:{4} -d ""{5}"""

        PathName = String.Format(PathName, IIf(CheckBoxDebug.Checked, "-debug", ""), PortMngr.Text, _
                                 PortAgent.Text, PortProcessBegin.Text, PortProcessEnd.Text, ClusterFiles.Text)


        Dim lpDependencies = "Tcpip" + Char.MinValue + "Dnscache" + Char.MinValue + "lanmanworkstation" + Char.MinValue + "lanmanserver"

        Dim User = ""
        Dim Pwd = ""

        If RadioButtonUser1.Checked Then
            'If TechUser.Text = "Локальная система" Then
            User = "LocalSystem"
            'ElseIf TechUser.Text = "Локальная служба" Then
            '    User = "NT AUTHORITY\LocalService"
            'Else
            '    User = "NT AUTHORITY\NetworkService"
            'End If
        Else
            User = Login.Text
            Pwd = Password.Text
        End If

        If ItsAdd Then

            Dim ServName = GetNewNameForService()

            'TODO - обработка ошибок 
            If Not ObjTec.Services.ServiceInstaller.InstallService(PathName, ServName, DisplayName.Text, lpDependencies, User, Pwd) Then

                Dim ErrorCode = Marshal.GetLastWin32Error()
                MsgBox("Ошибка установки сервиса " + Form1.GetErrorDescription(ErrorCode), , Text)

            End If

        ElseIf ItsEdit Then

            If ObjTec.Services.ServiceInstaller.ChangeServiceParameters(PathName, Serv.Name, DisplayName.Text, lpDependencies, User, Pwd) Then
                Dim sc = New System.ServiceProcess.ServiceController(Serv.Name)
                If sc.Status = ServiceProcess.ServiceControllerStatus.Running Then
                    ' sc.Stop()
                    'MsgBox("Параметры существующей службы успешно изменены")
                    If MsgBox("Параметры успешно изменены, но служба в настоящий момент работает." + _
                              vbNewLine + "Перезапустить службу для применения изменений?", MsgBoxStyle.YesNo, Text) = MsgBoxResult.Yes Then
                        sc.Stop()
                        sc.WaitForStatus(ServiceProcess.ServiceControllerStatus.Stopped)
                        sc.Start()
                        sc.WaitForStatus(ServiceProcess.ServiceControllerStatus.Running)
                    End If

                End If
            Else
                Dim ErrorCode = Marshal.GetLastWin32Error()
                MsgBox("Ошибка изменения параметров сервиса " + Form1.GetErrorDescription(ErrorCode), , Text)
            End If

        End If



        Close()


    End Sub



    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        Close()
    End Sub





    Private Sub TechUser_SelectedIndexChanged(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub RadioButtonUser1_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButtonUser1.CheckedChanged

    End Sub

    Private Sub Label5_Click(sender As System.Object, e As System.EventArgs) Handles Label5.Click

    End Sub
End Class