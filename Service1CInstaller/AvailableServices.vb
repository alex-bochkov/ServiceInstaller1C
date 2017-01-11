Imports System.IO

Public Class AvailableServices

    Public FullServiceList As List(Of Form1.InstalledServices) = New List(Of Form1.InstalledServices)

    Private Sub AvailableServices_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Text = My.Application.Info.ProductName + " / " + My.Application.Info.Copyright

        FullServiceList.Sort(Function(x, y) x.ProductType.CompareTo(y.ProductType))

        For Each Item In FullServiceList

            Dim item1 = New ListViewItem(Item.ProductType)

            Select Case Item.ProductType
                Case "AppServer"
                    item1.SubItems.Add("Сервер приложений")
                Case "RASServer"
                    item1.SubItems.Add("Сервер администрирования")
                Case "CRServer"
                    item1.SubItems.Add("Сервер хранилища")
            End Select

            item1.SubItems.Add(Item.ExePath)
            item1.SubItems.Add(Item.ProductVersion)

            ListAllServices.Items.Add(item1)


        Next

    End Sub

    Private Sub ButtonAdd_Click(sender As Object, e As EventArgs) Handles ButtonAdd.Click

        Dim ClusterForm = New ServiceParam
        ClusterForm.ItsAdd = True
        ClusterForm.Serv = New Form1.Service
        ClusterForm.ShowDialog()

        Close()

    End Sub



    Private Sub ListAllServices_DoubleClick(sender As Object, e As EventArgs) Handles ListAllServices.DoubleClick

        Dim Item = ListAllServices.SelectedItems.Item(0)

        If Item.SubItems(0).Text = "AppServer" Then

            Dim Serv = New Form1.Service
            Serv.ExeFile = Item.SubItems(2).Text

            Dim ClusterForm = New ServiceParam
            ClusterForm.ItsAdd = True
            ClusterForm.Serv = Serv
            ClusterForm.ShowDialog()

        End If

        Close()

    End Sub


End Class