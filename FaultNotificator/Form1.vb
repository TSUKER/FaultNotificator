Imports System
Imports System.Management
Imports System.Net

Public Class Form1
    Dim flogPath As String
    Dim nowDate As String
    Dim logData As String
    Dim d As DateTime '= DateString

    Private Sub cmdGetinfo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGetinfo.Click
        Dim infNow As New clsComputerInfo
        Dim HostName As String = System.Net.Dns.GetHostName()
        Dim host As Net.IPHostEntry = Dns.GetHostEntry(HostName)
        Dim ip As Net.IPAddress() = host.AddressList

        Dim index As Integer


        Me.TextBox1.Text = "Local IP:" & vbNewLine
        For index = 0 To ip.Length - 1
            Me.TextBox1.Text = TextBox1.Text & ip(index).ToString & vbNewLine
        Next index

        Me.TextBox1.Text = TextBox1.Text & "Local hostname = " & HostName & vbNewLine
        Me.TextBox1.Text = TextBox1.Text & "Me MAC = " & infNow.GetMACAddress & vbNewLine
        Me.TextBox1.Text = TextBox1.Text & "CPU ID = " & infNow.GetProcessorId & vbNewLine
        Me.TextBox1.Text = TextBox1.Text & "SerialNumber 'C'= " & infNow.GetVolumeSerial("C") & vbNewLine
        Me.TextBox1.Text = TextBox1.Text & "MB ID = " & infNow.GetMotherBoardID & vbNewLine
        'GetHDDstate
        Me.TextBox1.Text = TextBox1.Text & "HDD STATE:"
        infNow.GetHDDstate()
        Me.TextBox1.Text = TextBox1.Text & vbNewLine & "Volume List:"
        infNow.GetlistV()
        Me.TextBox1.Text = TextBox1.Text & vbNewLine & "User List:"
        infNow.GetlistU()
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblTimer.Text = 1200

        Me.txtApiSMSru.Text = My.Settings.smsru.ToString
        Me.txtDirectorN.Text = My.Settings.director.ToString
        Me.txtSysN.Text = My.Settings.sysadm.ToString
        Me.txtMsgtoDir.Text = My.Settings.msgtodir.ToString
        Me.txtServerName.Text = My.Settings.nameserver.ToString
        Me.txtSendFrom.Text = My.Settings.from.ToString
        Me.chSID.Checked = My.Settings.usrsid
        Me.chNotify.Checked = My.Settings.alert

        Me.updinfo()
        ' nowDate = d.ToString("dd.MM.yyyy")

        ' MsgBox(IO.Path.Combine(Application.CommonAppDataPath, "log-" & nowDate & ".txt"))


    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        With My.Settings
            .smsru = Me.txtApiSMSru.Text
            .sysadm = Me.txtSysN.Text
            .director = Me.txtDirectorN.Text
            .msgtodir = Me.txtMsgtoDir.Text
            .nameserver = Me.txtServerName.Text
            .from = Me.txtSendFrom.Text
            .alert = Me.chNotify.Checked
            .usrsid = Me.chSID.Checked

        End With

        My.Settings.Save()

    End Sub

    Private Sub tmrCheck_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrCheck.Tick


        If lblTimer.Text = 0 Then
            nowDate = d.ToString("d-M")

            logData = vbCrLf & " LOG ADD INFO-" & d.ToString("dd.MM.yyyy") & "-" & TimeOfDay.ToString
            logData = logData & vbNewLine & Me.TextBox1.Text & vbNewLine

            flogPath = IO.Path.Combine(Application.CommonAppDataPath, "log-" & nowDate & ".txt")


            My.Computer.FileSystem.WriteAllText(flogPath, logData, True, System.Text.Encoding.UTF8)

            Me.updinfo()
            lblTimer.Text = 600
        Else
            lblTimer.Text = lblTimer.Text - 1
        End If

    End Sub

    Sub updinfo()
        Dim infNow As New clsComputerInfo
        Dim HostName As String = System.Net.Dns.GetHostName()
        Dim host As Net.IPHostEntry = Dns.GetHostEntry(HostName)
        Dim ip As Net.IPAddress() = host.AddressList

        Dim index As Integer

        Me.TextBox1.Text = "Local IP:" & vbNewLine
        For index = 0 To ip.Length - 1
            Me.TextBox1.Text = TextBox1.Text & ip(index).ToString & vbNewLine
        Next index

        Me.TextBox1.Text = TextBox1.Text & "Local hostname = " & HostName & vbNewLine
        Me.TextBox1.Text = TextBox1.Text & "Me MAC = " & infNow.GetMACAddress & vbNewLine
        Me.TextBox1.Text = TextBox1.Text & "CPU ID = " & infNow.GetProcessorId & vbNewLine
        Me.TextBox1.Text = TextBox1.Text & "SerialNumber 'C'= " & infNow.GetVolumeSerial("C") & vbNewLine
        Me.TextBox1.Text = TextBox1.Text & "MB ID = " & infNow.GetMotherBoardID & vbNewLine
        'GetHDDstate
        Me.TextBox1.Text = TextBox1.Text & "HDD STATE:"
        infNow.GetHDDstate()
        Me.TextBox1.Text = TextBox1.Text & vbNewLine & "Volume List:"
        infNow.GetlistV()
        Me.TextBox1.Text = TextBox1.Text & vbNewLine & "User List:"
        infNow.GetlistU()

    End Sub
    Private Sub cmdStart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdStart.Click
        If tmrCheck.Enabled = True Then
            tmrCheck.Enabled = False
        Else
            tmrCheck.Enabled = True
        End If
    End Sub
End Class
