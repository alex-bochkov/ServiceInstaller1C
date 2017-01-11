Imports System.Management
Imports Microsoft.Win32
Imports System.IO
Imports System.Runtime.InteropServices
Imports System.Text

Public Class Form1

    <DllImport("msi.dll", SetLastError:=True)>
    Private Shared Function MsiEnumProducts(iProductIndex As Integer, lpProductBuf As StringBuilder) As Integer
    End Function

    Declare Auto Function MsiGetProductInfo Lib "msi.dll" (ByVal product As String, ByVal [property] As String,
         <MarshalAs(UnmanagedType.VBByRefStr)> ByRef valueBuf As String, ByRef len As Long) As Int32


    Public Enum MSI_ERROR As Integer
        ERROR_SUCCESS = 0
        ERROR_MORE_DATA = 234
        ERROR_NO_MORE_ITEMS = 259
        ERROR_INVALID_PARAMETER = 87
        ERROR_BAD_CONFIGURATION = 1610
    End Enum

    Structure InstalledServices
        Dim ProductType As String
        Dim ProductName As String
        Dim InstallLocation As String
        Dim ExePath As String
        Dim ProductID As String
        Dim ProductVersion As String
    End Structure

    Dim ListInstalledServices As List(Of InstalledServices) = New List(Of InstalledServices)

    Class Service
        Public Name As String
        Public DisplayName As String
        Public Description As String
        Public PathName As String
        Public User As String

        Public Debug As Boolean = False
        Public ExeFile As String = ""
        Public ClusterFiles As String = ""
        Public PortAgent As Integer = 1540
        Public PortMngr As Integer = 1541
        Public PortProcessBegin As Integer = 1560
        Public PortProcessEnd As Integer = 1591

        Sub ParsePath()

            Dim PathNameTemp = PathName.ToLower

            If PathNameTemp.Contains("-debug") _
                Or PathNameTemp.Contains("/debug") Then

                Debug = True

                PathNameTemp = PathNameTemp.Replace("-debug", "")
                PathNameTemp = PathNameTemp.Replace("/debug", "")

            End If

            Dim Ind = PathNameTemp.IndexOf("ragent.exe")
            If Ind > 0 Then
                ExeFile = PathNameTemp.Substring(0, Ind + 10)
                ExeFile = ExeFile.Replace("""", "")

                PathNameTemp = PathNameTemp.Substring(Ind + 11)
            End If

            Ind = PathNameTemp.IndexOf("-regport")
            If Ind > 0 Then

                Dim PortStr = ""
                Dim i = 0
                Dim Simb = PathNameTemp.Substring(Ind + 8 + i, 1)

                While "0123456789 ".Contains(Simb)

                    PortStr = PortStr + Simb
                    i = i + 1
                    Simb = PathNameTemp.Substring(Ind + 8 + i, 1)

                End While

                Try
                    PortMngr = Convert.ToInt32(PortStr)
                Catch ex As Exception

                End Try

            End If

            Ind = PathNameTemp.IndexOf("-port")
            If Ind > 0 Then

                Dim PortStr = ""
                Dim i = 0
                Dim Simb = PathNameTemp.Substring(Ind + 5 + i, 1)

                While "0123456789 ".Contains(Simb)

                    PortStr = PortStr + Simb
                    i = i + 1
                    Simb = PathNameTemp.Substring(Ind + 5 + i, 1)

                End While

                Try
                    PortAgent = Convert.ToInt32(PortStr)
                Catch ex As Exception

                End Try

            End If

            Ind = PathNameTemp.IndexOf("-range")
            If Ind > 0 Then

                Dim PortStr = ""
                Dim i = 0
                Dim Simb = PathNameTemp.Substring(Ind + 6 + i, 1)

                While "0123456789 :".Contains(Simb)

                    PortStr = PortStr + Simb
                    i = i + 1
                    Simb = PathNameTemp.Substring(Ind + 6 + i, 1)

                End While

                Try

                    Ind = PortStr.IndexOf(":")
                    PortProcessBegin = Convert.ToInt32(PortStr.Substring(0, Ind))
                    PortProcessEnd = Convert.ToInt32(PortStr.Substring(Ind + 1))

                Catch ex As Exception

                End Try

            End If

            Ind = PathNameTemp.IndexOf("-d")
            If Ind > 0 Then

                Dim PathStr = PathNameTemp.Substring(Ind + 2)
                Dim Simb = PathStr.Substring(0, 1)

                While " """.Contains(Simb)

                    PathStr = PathStr.Substring(2)
                    Simb = PathStr.Substring(1, 1)

                End While

                Ind = PathStr.IndexOf("""")
                If Ind > 0 Then
                    ClusterFiles = PathStr.Substring(0, Ind)

                End If

            End If


            'А теперь финт ушами - ищем полученные строки в иходной строке и вырезаем оттуда с корректным регистром
            Ind = PathName.ToLower.IndexOf(ExeFile)
            If Ind > 0 Then
                ExeFile = PathName.Substring(Ind, ExeFile.Length)
            End If

            Ind = PathName.ToLower.IndexOf(ClusterFiles)
            If Ind > 0 Then
                ClusterFiles = PathName.Substring(Ind, ClusterFiles.Length)
            End If

            '"C:\Program Files\1cv82\8.2.17.153\bin\ragent.exe" -debug -srvc -agent 
            '-regport 2541 -port 2540 -range 2560:2591 -d "C:\Program Files\1cv82\srvinfo"

        End Sub

    End Class

    Dim ArrayOfServices() As Service


    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        Text = My.Application.Info.ProductName + " / " + My.Application.Info.Copyright

        RefreshListService()

        GetListOfAllInstalledPlatforms()

    End Sub

    Sub RefreshListService()

        ListViewExistedServices.Items.Clear()

        Dim search As New ManagementObjectSearcher("SELECT * FROM Win32_Service WHERE PathName like '%ragent.exe%'")

        'Dim info

        Dim i = 0
        For Each info As ManagementObject In search.Get()

            Dim Srv = New Service
            Srv.Name = info("Name")
            Srv.DisplayName = info("DisplayName")
            Srv.Description = info("Description")
            Srv.PathName = info("PathName")
            Srv.User = info("StartName")
            Srv.ParsePath()


            Dim sc = New System.ServiceProcess.ServiceController(Srv.Name)

            Dim item1 = New ListViewItem(Srv.DisplayName)
            If sc.Status.ToString = "Running" Then
                item1.SubItems.Add("Работает")
            ElseIf sc.Status.ToString = "Stopped" Then
                item1.SubItems.Add("Остановлена")
            End If

            item1.SubItems.Add(Srv.PortMngr)
            item1.SubItems.Add(Srv.ClusterFiles)
            item1.SubItems.Add(Srv.PathName)

            ListViewExistedServices.Items.Add(item1)

            ReDim Preserve ArrayOfServices(i)
            ArrayOfServices(i) = Srv

            i = i + 1

        Next

        'info.Dispose()
        search.Dispose()

        ActivateButton()

    End Sub

    Public Function GetErrorDescription(ErrorNumber As Integer) As String

        Dim Desc = ""

        'If Procedure = "DeleteService" Then ' OpenService OpenSCManager ChangeServiceConfig CreateService

        'End If











        If ErrorNumber = 5 Then
            'ERROR_ACCESS_DENIED	
            Desc = "The handle does not have access to the service."
        ElseIf ErrorNumber = 1059 Then
            'ERROR_CIRCULAR_DEPENDENCY	
            Desc = "A circular service dependency was specified."
        ElseIf ErrorNumber = 1065 Then
            'ERROR_DATABASE_DOES_NOT_EXIST	
            Desc = "The specified database does not exist."
        ElseIf ErrorNumber = 1078 Then
            'ERROR_DUPLICATE_SERVICE_NAME	
            Desc = "The display name already exists in the service control manager database either as a service name or as another display name."
        ElseIf ErrorNumber = 6 Then
            'ERROR_INVALID_HANDLE	---------------
            Desc = "The handle to the specified service control manager database is invalid."
        ElseIf ErrorNumber = 123 Then
            'ERROR_INVALID_NAME	
            Desc = "The specified service name is invalid."
        ElseIf ErrorNumber = 87 Then
            'ERROR_INVALID_PARAMETER	
            Desc = "A parameter that was specified is invalid."
        ElseIf ErrorNumber = 1057 Then
            'ERROR_INVALID_SERVICE_ACCOUNT	
            Desc = "The account name does not exist, or a service is specified to share the same binary file as an already installed service but with an account name that is not the same as the installed service."
        ElseIf ErrorNumber = 1060 Then
            'ERROR_SERVICE_DOES_NOT_EXIST	
            Desc = "The specified service does not exist."
        ElseIf ErrorNumber = 1072 Then
            'ERROR_SERVICE_MARKED_FOR_DELETE	
            Desc = "The service has been marked for deletion."
        ElseIf ErrorNumber = 1073 Then
            'ERROR_SERVICE_EXISTS	
            Desc = "The specified service already exists in this database."
        End If

        GetErrorDescription = "№ " + ErrorNumber.ToString + " - " + Desc

    End Function

    Private Sub ButtonAdd_Click(sender As System.Object, e As System.EventArgs) Handles ButtonAdd.Click



        If ListViewExistedServices.SelectedItems.Count > 0 Then

            Dim Item = ListViewExistedServices.SelectedItems.Item(0)

            For Each Serv In ArrayOfServices

                If Serv.DisplayName = Item.SubItems(0).Text Then

                    Dim ClusterForm = New ServiceParam
                    ClusterForm.ItsAdd = True
                    ClusterForm.Serv = Serv
                    ClusterForm.ShowDialog()

                End If

            Next

        Else

            'Dim ClusterForm = New ServiceParam
            'ClusterForm.ItsAdd = True
            'ClusterForm.Serv = New Service
            'ClusterForm.FullServiceList = ListInstalledServices
            'ClusterForm.ShowDialog()

            Dim AddNewService = New AvailableServices
            AddNewService.FullServiceList = ListInstalledServices
            AddNewService.ShowDialog()


        End If

        RefreshListService()

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click

        Dim About = New AboutBox
        About.ShowDialog()

    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles ButtonDelete.Click



        If ListViewExistedServices.SelectedItems.Count > 0 Then

            Dim Item = ListViewExistedServices.SelectedItems.Item(0)

            For Each Serv In ArrayOfServices

                If Serv.DisplayName = Item.SubItems(0).Text Then

                    Dim Rez = MsgBox("Вы действительно хотите удалить службу сервера 1С " + vbNewLine +
                                     """" + Serv.DisplayName + """ ?", MsgBoxStyle.YesNo, "УДАЛЕНИЕ службы сервера 1С")

                    If Rez = MsgBoxResult.Yes Then

                        Dim StopError = False

                        Try
                            Dim sc = New System.ServiceProcess.ServiceController(Serv.Name)
                            If sc.Status = ServiceProcess.ServiceControllerStatus.Running Then
                                sc.Stop()
                                sc.WaitForStatus(ServiceProcess.ServiceControllerStatus.Stopped)
                            End If
                            sc.Dispose()
                        Catch ex As Exception
                            StopError = True
                        End Try

                        'delete Serv.Name

                        Dim Result = ObjTec.Services.ServiceInstaller.UninstallService(Serv.Name)

                        If Not Result Then
                            Dim ErrorCode As Integer = Marshal.GetLastWin32Error()
                            MsgBox("При удалении службы произошла ошибка: " + GetErrorDescription(ErrorCode), , Text)
                        Else
                            If StopError Then
                                MsgBox("Операция удаления прошла успешно, но службу остановить не удалось." + vbNewLine +
                                       "Она исчезнет из списка установленных служб после остановки вручную или перезагрузки.", , Text)
                            End If
                        End If

                        RefreshListService()

                    End If

                End If

            Next


        Else
            MsgBox("Необходимо выделить строку со службой сервера 1С, которую требуется удалить.", , Text)
        End If

    End Sub

    Private Sub ButtonEdit_Click(sender As System.Object, e As System.EventArgs) Handles ButtonEdit.Click



        If ListViewExistedServices.SelectedItems.Count > 0 Then

            Dim Item = ListViewExistedServices.SelectedItems.Item(0)

            For Each Serv In ArrayOfServices

                If Serv.DisplayName = Item.SubItems(0).Text Then

                    Dim ClusterForm = New ServiceParam
                    ClusterForm.ItsEdit = True
                    ClusterForm.Serv = Serv
                    ClusterForm.ShowDialog()

                    RefreshListService()

                End If

            Next

        Else

            MsgBox("Необходимо выделить строку со службой сервера 1С, которую требуется изменить.", , Text)

        End If

    End Sub


    Sub ChangeStatusService(Serv As Service, Operation As String)

        Try
            Dim sc = New System.ServiceProcess.ServiceController(Serv.Name)

            If sc.Status = ServiceProcess.ServiceControllerStatus.Running _
                And Operation = "Stop" Then

                sc.Stop()
                sc.WaitForStatus(ServiceProcess.ServiceControllerStatus.Stopped)

            ElseIf sc.Status = ServiceProcess.ServiceControllerStatus.Running _
                        And Operation = "Restart" Then

                sc.Stop()
                sc.WaitForStatus(ServiceProcess.ServiceControllerStatus.Stopped)

                sc.Start()
                sc.WaitForStatus(ServiceProcess.ServiceControllerStatus.Running)

            ElseIf sc.Status = ServiceProcess.ServiceControllerStatus.Stopped _
                   And Operation = "Start" Then

                sc.Start()
                sc.WaitForStatus(ServiceProcess.ServiceControllerStatus.Running)

            End If
        Catch ex As Exception
            MsgBox("Ошибка при выполнении операции: " + ex.Message + vbNewLine + ex.InnerException.Message, , Text)
        End Try


    End Sub


    Private Sub LinkLabel1_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked

        If ListViewExistedServices.SelectedItems.Count > 0 Then

            Dim Item = ListViewExistedServices.SelectedItems.Item(0)

            For Each Serv In ArrayOfServices

                If Serv.DisplayName = Item.SubItems(0).Text Then

                    ChangeStatusService(Serv, "Start")


                End If

            Next

        Else

            MsgBox("Необходимо выделить строку со службой сервера 1С, состояние которой требуется изменить", , Text)

        End If

        RefreshListService()



    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        If ListViewExistedServices.SelectedItems.Count > 0 Then

            Dim Item = ListViewExistedServices.SelectedItems.Item(0)

            For Each Serv In ArrayOfServices

                If Serv.DisplayName = Item.SubItems(0).Text Then

                    ChangeStatusService(Serv, "Stop")


                End If

            Next

        Else

            MsgBox("Необходимо выделить строку со службой сервера 1С, состояние которой требуется изменить", , Text)

        End If

        RefreshListService()
    End Sub

    Private Sub LinkLabel3_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel3.LinkClicked

        If ListViewExistedServices.SelectedItems.Count > 0 Then

            Dim Item = ListViewExistedServices.SelectedItems.Item(0)

            For Each Serv In ArrayOfServices

                If Serv.DisplayName = Item.SubItems(0).Text Then

                    ChangeStatusService(Serv, "Restart")


                End If

            Next

        Else

            MsgBox("Необходимо выделить строку со службой сервера 1С, состояние которой требуется изменить", , Text)

        End If

        RefreshListService()

    End Sub

    Sub ActivateButton()

        LinkLabel1.Enabled = False
        LinkLabel2.Enabled = False
        LinkLabel3.Enabled = False
        ButtonEdit.Enabled = False
        ButtonDelete.Enabled = False
        ButtonAdd.Text = "Добавить новую службу"

        If ListViewExistedServices.SelectedItems.Count > 0 Then

            Dim Item = ListViewExistedServices.SelectedItems.Item(0)

            ButtonEdit.Enabled = True
            ButtonDelete.Enabled = True
            ButtonAdd.Text = "Скопировать" + vbNewLine + "выделенную службу"

            If Item.SubItems(1).Text = "Работает" Then

                LinkLabel2.Enabled = True
                LinkLabel3.Enabled = True

            ElseIf Item.SubItems(1).Text = "Остановлена" Then

                LinkLabel1.Enabled = True

            End If

        End If
    End Sub

    Private Sub ListViewExistedServices_Click(sender As System.Object, e As System.EventArgs) Handles ListViewExistedServices.Click
        ActivateButton()
    End Sub



    Private Sub ListViewExistedServices_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ListViewExistedServices.SelectedIndexChanged
        ActivateButton()
    End Sub

    Private Sub LinkLabel4_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel4.LinkClicked
        RefreshListService()
    End Sub

    Private Sub Form1_Shown(sender As System.Object, e As System.EventArgs) Handles MyBase.Shown

        Dim UserHaveAccess = ObjTec.Services.ServiceInstaller.TestConnection()

        If Not UserHaveAccess Then

            MsgBox("Программа запущена без административных прав." +
                   vbNewLine + "Управление службами будет невозможно.", MsgBoxStyle.Information, Text)

        End If

    End Sub

    Function GetProductProperty(productID As String, sProperty As String) As String

        Dim lsIKC As String = New String(" ", 255)
        Dim liLen As Integer = 255
        MsiGetProductInfo(productID, sProperty, lsIKC, liLen)

        Return lsIKC.Substring(0, liLen).Trim

    End Function

    Sub AddAccesibleServices(InstallLocation As String, ProductName As String)


        Dim FileServer1C = My.Computer.FileSystem.GetFileInfo(Path.Combine(InstallLocation, "bin\ragent.exe"))
        If FileServer1C.Exists Then

            Dim myFileVersionInfo As FileVersionInfo = FileVersionInfo.GetVersionInfo(FileServer1C.FullName)

            Dim Service1C = New InstalledServices
            Service1C.InstallLocation = InstallLocation
            Service1C.ProductType = "AppServer"
            Service1C.ProductName = ProductName
            Service1C.ProductVersion = myFileVersionInfo.ProductVersion
            Service1C.ExePath = FileServer1C.FullName

            ListInstalledServices.Add(Service1C)

        End If

        Dim FileServerRepo = My.Computer.FileSystem.GetFileInfo(Path.Combine(InstallLocation, "bin\crserver.exe"))
        If FileServerRepo.Exists Then

            Dim myFileVersionInfo As FileVersionInfo = FileVersionInfo.GetVersionInfo(FileServerRepo.FullName)

            Dim Service1C = New InstalledServices
            Service1C.InstallLocation = InstallLocation
            Service1C.ProductType = "CRServer"
            Service1C.ProductName = ProductName
            Service1C.ProductVersion = myFileVersionInfo.ProductVersion
            Service1C.ExePath = FileServerRepo.FullName

            ListInstalledServices.Add(Service1C)

        End If

        Dim FileServerRas = My.Computer.FileSystem.GetFileInfo(Path.Combine(InstallLocation, "bin\ras.exe"))
        If FileServerRas.Exists Then

            Dim myFileVersionInfo As FileVersionInfo = FileVersionInfo.GetVersionInfo(FileServerRas.FullName)

            Dim Service1C = New InstalledServices
            Service1C.InstallLocation = InstallLocation
            Service1C.ProductType = "RASServer"
            Service1C.ProductName = ProductName
            Service1C.ProductVersion = myFileVersionInfo.ProductVersion
            Service1C.ExePath = FileServerRas.FullName

            ListInstalledServices.Add(Service1C)

        End If

    End Sub

    Sub GetListOfAllInstalledPlatforms()

        Dim sb As New StringBuilder(39)
        Dim [error] As MSI_ERROR = MSI_ERROR.ERROR_SUCCESS
        Dim index As Integer = 0
        While [error] = MSI_ERROR.ERROR_SUCCESS
            [error] = CType(MsiEnumProducts(index, sb), MSI_ERROR)
            Dim productID As String = sb.ToString()
            If [error] = MSI_ERROR.ERROR_SUCCESS Then
                'Console.WriteLine("ProductID=" & productID)

                Dim a1 = GetProductProperty(productID, "Publisher")
                If a1 = "1C" Then

                    Dim InstallLocation = GetProductProperty(productID, "InstallLocation")
                    Dim ProductName = GetProductProperty(productID, "ProductName")

                    AddAccesibleServices(InstallLocation, ProductName)

                End If

            End If
            index += 1
        End While

    End Sub

End Class

