<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.cmdGetinfo = New System.Windows.Forms.Button()
        Me.chDul = New System.Windows.Forms.CheckBox()
        Me.chSID = New System.Windows.Forms.CheckBox()
        Me.chNotify = New System.Windows.Forms.CheckBox()
        Me.txtApiSMSru = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtSysN = New System.Windows.Forms.TextBox()
        Me.txtDirectorN = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtSendFrom = New System.Windows.Forms.TextBox()
        Me.txtServerName = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtMsgtoDir = New System.Windows.Forms.TextBox()
        Me.Сообщение = New System.Windows.Forms.Label()
        Me.lblTimer = New System.Windows.Forms.Label()
        Me.cmdStart = New System.Windows.Forms.Button()
        Me.tmrCheck = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(2, 3)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TextBox1.Size = New System.Drawing.Size(910, 329)
        Me.TextBox1.TabIndex = 0
        '
        'cmdGetinfo
        '
        Me.cmdGetinfo.Location = New System.Drawing.Point(2, 387)
        Me.cmdGetinfo.Name = "cmdGetinfo"
        Me.cmdGetinfo.Size = New System.Drawing.Size(286, 35)
        Me.cmdGetinfo.TabIndex = 1
        Me.cmdGetinfo.Text = "Get Now State"
        Me.cmdGetinfo.UseVisualStyleBackColor = True
        '
        'chDul
        '
        Me.chDul.AutoSize = True
        Me.chDul.Location = New System.Drawing.Point(2, 343)
        Me.chDul.Name = "chDul"
        Me.chDul.Size = New System.Drawing.Size(162, 17)
        Me.chDul.TabIndex = 2
        Me.chDul.Text = "описание учетных записей"
        Me.chDul.UseVisualStyleBackColor = True
        '
        'chSID
        '
        Me.chSID.AutoSize = True
        Me.chSID.Location = New System.Drawing.Point(2, 366)
        Me.chSID.Name = "chSID"
        Me.chSID.Size = New System.Drawing.Size(132, 17)
        Me.chSID.TabIndex = 3
        Me.chSID.Text = "SID учетных записей"
        Me.chSID.UseVisualStyleBackColor = True
        '
        'chNotify
        '
        Me.chNotify.AutoSize = True
        Me.chNotify.Location = New System.Drawing.Point(299, 338)
        Me.chNotify.Name = "chNotify"
        Me.chNotify.Size = New System.Drawing.Size(309, 17)
        Me.chNotify.TabIndex = 4
        Me.chNotify.Text = "Включить внешние оповещение о критических ошибках"
        Me.chNotify.UseVisualStyleBackColor = True
        '
        'txtApiSMSru
        '
        Me.txtApiSMSru.Location = New System.Drawing.Point(612, 463)
        Me.txtApiSMSru.Name = "txtApiSMSru"
        Me.txtApiSMSru.Size = New System.Drawing.Size(206, 20)
        Me.txtApiSMSru.TabIndex = 6
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(830, 358)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(82, 159)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Применить"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(296, 466)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(115, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "API для сайта SMS.ru"
        '
        'txtSysN
        '
        Me.txtSysN.Location = New System.Drawing.Point(612, 358)
        Me.txtSysN.Name = "txtSysN"
        Me.txtSysN.Size = New System.Drawing.Size(206, 20)
        Me.txtSysN.TabIndex = 9
        Me.txtSysN.Text = "375291234567"
        '
        'txtDirectorN
        '
        Me.txtDirectorN.Location = New System.Drawing.Point(612, 395)
        Me.txtDirectorN.Name = "txtDirectorN"
        Me.txtDirectorN.Size = New System.Drawing.Size(206, 20)
        Me.txtDirectorN.TabIndex = 10
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(296, 381)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(310, 13)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Отправлять сообщение чтобы связались с тех поддержкой"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(296, 358)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(202, 13)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Телефон системного администратора"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(296, 504)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 13)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Имя сервера"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(296, 486)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(273, 13)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Имя отправителя(должно быть добавлено на sms.ru)"
        '
        'txtSendFrom
        '
        Me.txtSendFrom.Location = New System.Drawing.Point(612, 482)
        Me.txtSendFrom.Name = "txtSendFrom"
        Me.txtSendFrom.Size = New System.Drawing.Size(206, 20)
        Me.txtSendFrom.TabIndex = 15
        Me.txtSendFrom.Text = "critical-er"
        '
        'txtServerName
        '
        Me.txtServerName.Location = New System.Drawing.Point(612, 501)
        Me.txtServerName.Name = "txtServerName"
        Me.txtServerName.Size = New System.Drawing.Size(206, 20)
        Me.txtServerName.TabIndex = 16
        Me.txtServerName.Text = "server name"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(296, 398)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(52, 13)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Телефон"
        '
        'txtMsgtoDir
        '
        Me.txtMsgtoDir.Location = New System.Drawing.Point(612, 415)
        Me.txtMsgtoDir.Name = "txtMsgtoDir"
        Me.txtMsgtoDir.Size = New System.Drawing.Size(206, 20)
        Me.txtMsgtoDir.TabIndex = 18
        '
        'Сообщение
        '
        Me.Сообщение.AutoSize = True
        Me.Сообщение.Location = New System.Drawing.Point(294, 418)
        Me.Сообщение.Name = "Сообщение"
        Me.Сообщение.Size = New System.Drawing.Size(65, 13)
        Me.Сообщение.TabIndex = 19
        Me.Сообщение.Text = "Сообщение"
        '
        'lblTimer
        '
        Me.lblTimer.AutoSize = True
        Me.lblTimer.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lblTimer.Location = New System.Drawing.Point(79, 434)
        Me.lblTimer.Name = "lblTimer"
        Me.lblTimer.Size = New System.Drawing.Size(96, 25)
        Me.lblTimer.TabIndex = 20
        Me.lblTimer.Text = "lblTimer"
        '
        'cmdStart
        '
        Me.cmdStart.Location = New System.Drawing.Point(2, 482)
        Me.cmdStart.Name = "cmdStart"
        Me.cmdStart.Size = New System.Drawing.Size(286, 39)
        Me.cmdStart.TabIndex = 21
        Me.cmdStart.Text = "Start\Stop daemon checker"
        Me.cmdStart.UseVisualStyleBackColor = True
        '
        'tmrCheck
        '
        Me.tmrCheck.Enabled = True
        Me.tmrCheck.Interval = 1000
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(924, 531)
        Me.Controls.Add(Me.cmdStart)
        Me.Controls.Add(Me.lblTimer)
        Me.Controls.Add(Me.Сообщение)
        Me.Controls.Add(Me.txtMsgtoDir)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtServerName)
        Me.Controls.Add(Me.txtSendFrom)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtDirectorN)
        Me.Controls.Add(Me.txtSysN)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtApiSMSru)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.chNotify)
        Me.Controls.Add(Me.chSID)
        Me.Controls.Add(Me.chDul)
        Me.Controls.Add(Me.cmdGetinfo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "SYSTEM STATUS CONTROL"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents cmdGetinfo As System.Windows.Forms.Button
    Friend WithEvents chDul As System.Windows.Forms.CheckBox
    Friend WithEvents chSID As System.Windows.Forms.CheckBox
    Friend WithEvents chNotify As System.Windows.Forms.CheckBox
    Friend WithEvents txtApiSMSru As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtSysN As System.Windows.Forms.TextBox
    Friend WithEvents txtDirectorN As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtSendFrom As System.Windows.Forms.TextBox
    Friend WithEvents txtServerName As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtMsgtoDir As System.Windows.Forms.TextBox
    Friend WithEvents Сообщение As System.Windows.Forms.Label
    Friend WithEvents lblTimer As System.Windows.Forms.Label
    Friend WithEvents cmdStart As System.Windows.Forms.Button
    Friend WithEvents tmrCheck As System.Windows.Forms.Timer

End Class
