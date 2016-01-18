Imports System
Imports System.Management

Public Class clsComputerInfo

    Friend Function GetProcessorId() As String
        Dim strProcessorId As String = String.Empty
        Dim query As New SelectQuery("Win32_processor")
        Dim search As New ManagementObjectSearcher(query)
        Dim info As ManagementObject

        For Each info In search.Get()
            strProcessorId = info("processorId").ToString()
        Next
        Return strProcessorId

    End Function

    Friend Function GetMACAddress() As String

        Dim mc As ManagementClass = New ManagementClass("Win32_NetworkAdapterConfiguration")
        Dim moc As ManagementObjectCollection = mc.GetInstances()
        Dim MACAddress As String = String.Empty
        For Each mo As ManagementObject In moc

            If (MACAddress.Equals(String.Empty)) Then
                If CBool(mo("IPEnabled")) Then MACAddress = mo("MacAddress").ToString()

                mo.Dispose()
            End If
            MACAddress = MACAddress.Replace(":", String.Empty)

        Next
        Return MACAddress
    End Function

    Friend Function GetVolumeSerial(Optional ByVal strDriveLetter As String = "C") As String

        Dim disk As ManagementObject = New ManagementObject(String.Format("win32_logicaldisk.deviceid=""{0}:""", strDriveLetter))
        disk.Get()
        Return disk("VolumeSerialNumber").ToString()
    End Function

    Friend Function GetMotherBoardID() As String

        Dim strMotherBoardID As String = String.Empty
        Dim query As New SelectQuery("Win32_BaseBoard")
        Dim search As New ManagementObjectSearcher(query)
        Dim info As ManagementObject
        For Each info In search.Get()

            strMotherBoardID = info("SerialNumber").ToString()

        Next
        Return strMotherBoardID

    End Function
    Friend Function GetHDDstate(Optional ByVal strDriveLetter As String = "C") As String

        Dim strGetHDDstate As String = String.Empty

        Dim query As New SelectQuery("Select * from Win32_DiskDrive instance")

        Dim search As New ManagementObjectSearcher(query)
        Dim info As ManagementObject
        For Each info In search.Get()

            Form1.TextBox1.Text = Form1.TextBox1.Text & vbNewLine & info("Caption").ToString & " = " & info("status").ToString()
            If info("status").ToString = "Error" Then
                Notify.CriticalAlert(info("Caption").ToString.Replace("Device", "") & " > " & info("status").ToString, "hdd")
            End If
            If info("status").ToString = "Unknown" Then
                Notify.CriticalAlert(info("Caption").ToString.Replace("Device", "") & " > " & info("status").ToString, "hdd")
            End If
            '  If info("status").ToString = "Unknown" Then
            'Notify.CriticalAlert(info("Caption").ToString.Replace("Device", "") & " > " & info("status").ToString, "hdd")
            'End If
            If info("status").ToString = "Pred Fail" Then
                Notify.CriticalAlert(info("Caption").ToString.Replace("Device", "") & " > " & info("status").ToString, "hdd")
            End If

        Next

        Return (strGetHDDstate)

    End Function
    Friend Function GetlistV() As String

        Dim strGetHDDstate As String = String.Empty
        ' Dim 
        Dim query As New SelectQuery("Select * from Win32_DiskPartition instance")

        Dim search As New ManagementObjectSearcher(query)
        Dim info As ManagementObject
        For Each info In search.Get()
            Form1.TextBox1.Text = Form1.TextBox1.Text & vbNewLine & info("DeviceID").ToString & " |SIZE(GB)= " & System.Math.Round(info("size").ToString() / 1024 / 1024 / 1024, 3) & " |TYPE= " & info("Type").ToString() & " |PRIMARY= " & info("PrimaryPartition").ToString() & " |BOOT= " & info("Bootable").ToString()

            ' If info("Status").ToString = NullReferenceException Or info("Status").ToString = "OK" Then
            ' Form1.TextBox1.Text = Form1.TextBox1.Text & " |STATE=OK"
            ' Else
            ' Form1.TextBox1.Text = Form1.TextBox1.Text & " |STATE=" & info("Status").ToString
            ' End If

            ' strGetHDDstate = Form1.TextBox1.Text & vbNewLine & info("Caption")

        Next

        Return "0"

    End Function
    Friend Function GetlistU() As String
        Dim usersData As String = ""
        Dim strGetHDDstate As String = String.Empty
        ' Dim 
        Dim query As New SelectQuery("Select * from Win32_UserAccount")

        Dim search As New ManagementObjectSearcher(query)
        Dim info As ManagementObject
        For Each info In search.Get()


            usersData = vbNewLine & "TYPE=" & info("AccountType").ToString

            usersData = usersData & " |LOGIN= " & info("name").ToString
            usersData = usersData & " |DOMAIN=" & info("Domain").ToString
 
            usersData = usersData & " |FullName=" & info("FullName").ToString
            usersData = usersData & " |Local=" & info("LocalAccount").ToString
            usersData = usersData & " |Disabled=" & info("Disabled").ToString

            If info("Status").ToString = "Error" Then
                Notify.CriticalAlert("User Error > " & usersData & " |Status=" & info("Status").ToString, "user")
            End If

            If info("Status").ToString = "Pred Fail" Then
                Notify.CriticalAlert("User Error > " & usersData & " |Status=" & info("Status").ToString, "user")
                MsgBox("User Error > " & usersData & " |Status=" & info("Status").ToString)
            End If


            usersData = usersData & " |PwdChangeable=" & info("PasswordChangeable").ToString
            usersData = usersData & " |PwdExpires=" & info("PasswordExpires").ToString
            usersData = usersData & " |PwdRequired=" & info("PasswordRequired").ToString

            If Form1.chSID.Checked = True Then usersData = usersData & " |SID=" & info("SID").ToString
            If Form1.chDul.Checked = True Then usersData = usersData & vbNewLine & " >>|ОПИСАНИЕ=" & info("Description").ToString

            usersData = usersData & " |Status=" & info("Status").ToString

            Form1.TextBox1.Text = Form1.TextBox1.Text & usersData


        Next

        Return "0"

    End Function
    Private Function NullReferenceException() As String
        Throw New NotImplementedException
    End Function

End Class