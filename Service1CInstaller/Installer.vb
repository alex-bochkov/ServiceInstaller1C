Imports System
Imports System.Runtime.InteropServices
Namespace ObjTec.Services
    Friend Class NativeMethods
        Private Sub New()
        End Sub
        <DllImport("advapi32.dll", EntryPoint:="OpenSCManagerW", ExactSpelling:=True, CharSet:=CharSet.Unicode, SetLastError:=True)> _
        Friend Shared Function OpenSCManager(machineName As String, databaseName As String, dwAccess As UInteger) As IntPtr
        End Function
        <DllImport("advapi32.dll", SetLastError:=True, CharSet:=CharSet.Auto)> _
        Friend Shared Function CreateService(hSCManager As IntPtr, lpServiceName As String, lpDisplayName As String, dwDesiredAccess As UInteger, dwServiceType As UInteger, dwStartType As UInteger, _
            dwErrorControl As UInteger, lpBinaryPathName As String, lpLoadOrderGroup As String, lpdwTagId As UInteger, lpDependencies As String, lpServiceStartName As String, _
            lpPassword As String) As IntPtr
        End Function
        <DllImport("advapi32.dll", SetLastError:=True, CharSet:=CharSet.Auto)> _
        Friend Shared Function ChangeServiceConfig(hService As IntPtr, dwServiceType As UInteger, dwStartType As UInteger, dwErrorControl As UInteger, _
            lpBinaryPathName As String, lpLoadOrderGroup As String, lpdwTagId As UInteger, lpDependencies As String, lpServiceStartName As String, _
            lpPassword As String, lpDisplayName As String) As IntPtr
        End Function
        <DllImport("advapi32.dll")> _
        Friend Shared Function CloseServiceHandle(scHandle As IntPtr) As <MarshalAs(UnmanagedType.Bool)> Boolean
        End Function
        <DllImport("advapi32", SetLastError:=True)> _
        Friend Shared Function StartService(hService As IntPtr, dwNumServiceArgs As Integer, lpServiceArgVectors As String()) As <MarshalAs(UnmanagedType.Bool)> Boolean
        End Function
        <DllImport("advapi32.dll", SetLastError:=True)> _
        Friend Shared Function OpenService(scHandle As IntPtr, lpSvcName As String, dwNumServiceArgs As Integer) As IntPtr
        End Function
        <DllImport("advapi32.dll")> _
        Friend Shared Function DeleteService(svHandle As IntPtr) As Integer
        End Function
    End Class
    Public Class ServiceInstaller
        Public Shared Function InstallService(svcPath As String, svcName As String, svcDispName As String, lpDependencies As String, User As String, Password As String) As Boolean
            Dim SC_MANAGER_CREATE_SERVICE As UInteger = &H2
            Dim SC_MANAGER_ALL_ACCESS As UInteger = &HF003F
            Dim SERVICE_WIN32_OWN_PROCESS As UInteger = &H10
            Dim SERVICE_ERROR_NORMAL As UInteger = &H1
            Dim STANDARD_RIGHTS_REQUIRED As UInteger = &HF0000
            Dim SERVICE_QUERY_CONFIG As UInteger = &H1
            Dim SERVICE_CHANGE_CONFIG As UInteger = &H2
            Dim SERVICE_QUERY_STATUS As UInteger = &H4
            Dim SERVICE_ENUMERATE_DEPENDENTS As UInteger = &H8
            Dim SERVICE_START As UInteger = &H10
            Dim SERVICE_STOP As UInteger = &H20
            Dim SERVICE_PAUSE_CONTINUE As UInteger = &H40
            Dim SERVICE_INTERROGATE As UInteger = &H80
            Dim SERVICE_USER_DEFINED_CONTROL As UInteger = &H100
            Dim SERVICE_ALL_ACCESS As UInteger = (STANDARD_RIGHTS_REQUIRED Or SERVICE_QUERY_CONFIG Or SERVICE_CHANGE_CONFIG Or SERVICE_QUERY_STATUS Or SERVICE_ENUMERATE_DEPENDENTS Or SERVICE_START Or SERVICE_STOP Or SERVICE_PAUSE_CONTINUE Or SERVICE_INTERROGATE Or SERVICE_USER_DEFINED_CONTROL)
            Dim SERVICE_AUTO_START As UInteger = &H2
            Dim sc_handle As IntPtr = NativeMethods.OpenSCManager(Nothing, Nothing, SC_MANAGER_ALL_ACCESS)
            If Not sc_handle.Equals(IntPtr.Zero) Then
                Dim sv_handle As IntPtr = NativeMethods.CreateService(sc_handle, svcName, svcDispName, SERVICE_ALL_ACCESS, SERVICE_WIN32_OWN_PROCESS, SERVICE_AUTO_START, _
                    SERVICE_ERROR_NORMAL, svcPath, Nothing, 0, lpDependencies, User, IIf(Password = "", Nothing, Password))
                If sv_handle.Equals(IntPtr.Zero) Then
                    'Console.WriteLine(Marshal.GetLastWin32Error())
                    NativeMethods.CloseServiceHandle(sv_handle)
                    NativeMethods.CloseServiceHandle(sc_handle)
                    Return False
                Else
                    'Dim test As Boolean = NativeMethods.StartService(sv_handle, 0, Nothing)
                    NativeMethods.CloseServiceHandle(sv_handle)
                    'If Not test Then
                    '    Return False
                    'End If
                    NativeMethods.CloseServiceHandle(sc_handle)
                    Return True
                End If
            Else
                Return False
            End If
        End Function

        Public Shared Function TestConnection() As Boolean

            Dim SC_MANAGER_CREATE_SERVICE As UInteger = &H2
            Dim SC_MANAGER_ALL_ACCESS As UInteger = &HF003F
            Dim SERVICE_WIN32_OWN_PROCESS As UInteger = &H10
            Dim SERVICE_ERROR_NORMAL As UInteger = &H1
            Dim STANDARD_RIGHTS_REQUIRED As UInteger = &HF0000
            Dim SERVICE_QUERY_CONFIG As UInteger = &H1
            Dim SERVICE_CHANGE_CONFIG As UInteger = &H2
            Dim SERVICE_QUERY_STATUS As UInteger = &H4
            Dim SERVICE_ENUMERATE_DEPENDENTS As UInteger = &H8
            Dim SERVICE_START As UInteger = &H10
            Dim SERVICE_STOP As UInteger = &H20
            Dim SERVICE_PAUSE_CONTINUE As UInteger = &H40
            Dim SERVICE_INTERROGATE As UInteger = &H80
            Dim SERVICE_USER_DEFINED_CONTROL As UInteger = &H100
            Dim SERVICE_ALL_ACCESS As UInteger = (STANDARD_RIGHTS_REQUIRED Or SERVICE_QUERY_CONFIG Or SERVICE_CHANGE_CONFIG Or SERVICE_QUERY_STATUS Or SERVICE_ENUMERATE_DEPENDENTS Or SERVICE_START Or SERVICE_STOP Or SERVICE_PAUSE_CONTINUE Or SERVICE_INTERROGATE Or SERVICE_USER_DEFINED_CONTROL)
            Dim SERVICE_AUTO_START As UInteger = &H2
            Dim sc_handle As IntPtr = NativeMethods.OpenSCManager(Nothing, Nothing, SC_MANAGER_ALL_ACCESS)

            If Not sc_handle.Equals(IntPtr.Zero) Then
                Return True
            Else
                Return False
            End If

        End Function

        Public Shared Function ChangeServiceParameters(svcPath As String, svcName As String, svcDispName As String, lpDependencies As String, User As String, Password As String) As Boolean
            Dim SC_MANAGER_CREATE_SERVICE As UInteger = &H2
            Dim SC_MANAGER_ALL_ACCESS As UInteger = &HF003F
            Dim SERVICE_WIN32_OWN_PROCESS As UInteger = &H10
            Dim SERVICE_ERROR_NORMAL As UInteger = &H1
            Dim STANDARD_RIGHTS_REQUIRED As UInteger = &HF0000
            Dim SERVICE_QUERY_CONFIG As UInteger = &H1
            Dim SERVICE_CHANGE_CONFIG As UInteger = &H2
            Dim SERVICE_QUERY_STATUS As UInteger = &H4
            Dim SERVICE_ENUMERATE_DEPENDENTS As UInteger = &H8
            Dim SERVICE_START As UInteger = &H10
            Dim SERVICE_STOP As UInteger = &H20
            Dim SERVICE_PAUSE_CONTINUE As UInteger = &H40
            Dim SERVICE_INTERROGATE As UInteger = &H80
            Dim SERVICE_USER_DEFINED_CONTROL As UInteger = &H100
            Dim SERVICE_ALL_ACCESS As UInteger = (STANDARD_RIGHTS_REQUIRED Or SERVICE_QUERY_CONFIG Or SERVICE_CHANGE_CONFIG Or SERVICE_QUERY_STATUS Or SERVICE_ENUMERATE_DEPENDENTS Or SERVICE_START Or SERVICE_STOP Or SERVICE_PAUSE_CONTINUE Or SERVICE_INTERROGATE Or SERVICE_USER_DEFINED_CONTROL)
            Dim SERVICE_AUTO_START As UInteger = &H2


            Dim GENERIC_WRITE As UInteger = &H40000000
            Dim sc_hndl As IntPtr = NativeMethods.OpenSCManager(Nothing, Nothing, GENERIC_WRITE)
            If sc_hndl.ToInt32() <> 0 Then
                Dim svc_hndl As IntPtr = NativeMethods.OpenService(sc_hndl, svcName, SC_MANAGER_ALL_ACCESS)
                If svc_hndl.ToInt32() <> 0 Then

                    Dim i As Integer = NativeMethods.ChangeServiceConfig(svc_hndl, SERVICE_WIN32_OWN_PROCESS, SERVICE_AUTO_START,
                                        SERVICE_ERROR_NORMAL, svcPath, Nothing, 0, lpDependencies, IIf(User = "", Nothing, User), IIf(Password = "", Nothing, Password), svcDispName)
                    ''ErrorCode = i
                    NativeMethods.CloseServiceHandle(svc_hndl)
                    If i <> 0 Then
                        NativeMethods.CloseServiceHandle(sc_hndl)
                        Return True
                    Else
                        NativeMethods.CloseServiceHandle(sc_hndl)
                        Return False
                    End If

                Else
                    Return False
                End If
            Else
                Return False
            End If

        End Function
        Public Shared Function UninstallService(svcName As String) As Boolean
            Dim GENERIC_WRITE As UInteger = &H40000000
            Dim sc_hndl As IntPtr = NativeMethods.OpenSCManager(Nothing, Nothing, GENERIC_WRITE)
            If sc_hndl.ToInt32() <> 0 Then
                Dim DELETE As Integer = &H10000
                Dim svc_hndl As IntPtr = NativeMethods.OpenService(sc_hndl, svcName, DELETE)
                If svc_hndl.ToInt32() <> 0 Then
                    Dim i As Integer = NativeMethods.DeleteService(svc_hndl)
                    NativeMethods.CloseServiceHandle(svc_hndl)
                    If i <> 0 Then
                        NativeMethods.CloseServiceHandle(sc_hndl)
                        Return True
                    Else
                        NativeMethods.CloseServiceHandle(sc_hndl)
                        Return False
                    End If
                Else
                    Return False
                End If
            Else
                Return False
            End If
        End Function
    End Class
End Namespace

