Imports System
Imports System.Net
Imports System.IO


Module Notify
    Public nSysadm As String = My.Settings.sysadm.ToString
    Public nDirector As String = My.Settings.director.ToString
    Public smsru As String = "http://sms.ru/sms/send?api_id="

    Public Sub CriticalAlert(ByVal message As String, ByVal msg0 As String)
        Dim xmlfilepath As String
        Dim msgN As String
        Dim msgd As String
        Dim strFrom As String = My.Settings.from.ToString

        If My.Settings.alert = True Then


            nSysadm = My.Settings.sysadm.ToString
            nDirector = My.Settings.director.ToString


            xmlfilepath = Path.Combine(Application.CommonAppDataPath, "tmp.xml")

            message = message.Replace("=", "->")

            msgN = "CRITICAL|" & My.Settings.nameserver.ToString & "|+" & message.Replace(" ", "+")

            Using wc As New WebClient()
                Dim startupPath = Environment.GetFolderPath(Environment.SpecialFolder.Startup)
                wc.DownloadFile(smsru & Form1.txtApiSMSru.Text & "&from=" & strFrom & "&to=" & nSysadm & "&text=" & msgN & "&partner_id=29591", xmlfilepath)
            End Using

            If My.Settings.director.ToString <> "0" Then
                msgd = My.Settings.msgtodir
                msgd = msgd.Replace("{sysadminnumber}", nSysadm)
                msgd = msgd.Replace("{servername}", My.Settings.nameserver.ToString)
                msgd = msgd.Replace(" ", "+")

                Using wc As New WebClient()
                    Dim startupPath = Environment.GetFolderPath(Environment.SpecialFolder.Startup)
                    wc.DownloadFile(smsru & Form1.txtApiSMSru.Text & "&from=" & strFrom & "&to=" & nDirector & "&text=" & msgd & "&partner_id=29591", xmlfilepath)
                End Using

            End If

        Else
            Dim flogPath As String
            Dim nowDate As String
            Dim logData As String
            Dim d As DateTime = DateString

            nowDate = d.ToString("d-M")

            logData = vbCrLf & " LOG ADD INFO-" & d.ToString("dd.MM.yyyy") & "-" & TimeOfDay.ToString
            logData = logData & vbNewLine & message & vbNewLine

            flogPath = IO.Path.Combine(Application.CommonAppDataPath, "critical-log-" & nowDate & ".txt")


            My.Computer.FileSystem.WriteAllText(flogPath, logData, True, System.Text.Encoding.UTF8)

        End If


    End Sub


End Module
