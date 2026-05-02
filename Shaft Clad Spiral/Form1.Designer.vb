Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Windows.Forms

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits Form

    'Form overrides dispose to clean up the component list.
    <DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    <DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New Container()
        MenuStrip1 = New MenuStrip()
        FileToolStripMenuItem = New ToolStripMenuItem()
        OpenProjectToolStripMenuItem1 = New ToolStripMenuItem()
        SaveToolStripMenuItem = New ToolStripMenuItem()
        SaveAsToolStripMenuItem = New ToolStripMenuItem()
        CloseProjectToolStripMenuItem = New ToolStripMenuItem()
        ConnectionSettingsToolStripMenuItem = New ToolStripMenuItem()
        MisselaneousSettingsToolStripMenuItem = New ToolStripMenuItem()
        ExitToolStripMenuItem = New ToolStripMenuItem()
        HelpToolStripMenuItem = New ToolStripMenuItem()
        HelpToolStripMenuItem1 = New ToolStripMenuItem()
        AboutToolStripMenuItem = New ToolStripMenuItem()
        processcycle = New ComboBox()
        Label1 = New Label()
        Quitbtn = New Button()
        connect = New Button()
        GroupBox1 = New GroupBox()
        Offlinecheck = New CheckBox()
        Countdown = New Label()
        GroupBox2 = New GroupBox()
        Label7 = New Label()
        Label6 = New Label()
        RZCoord = New TextBox()
        RYCoord = New TextBox()
        Label5 = New Label()
        RXCoord = New TextBox()
        Label4 = New Label()
        ZCoord = New TextBox()
        Label3 = New Label()
        YCoord = New TextBox()
        Label2 = New Label()
        XCoord = New TextBox()
        Progress = New Label()
        ProgressBar = New ProgressBar()
        hold = New Button()
        run = New Button()
        Download = New Button()
        GroupBox3 = New GroupBox()
        GroupBox4 = New GroupBox()
        Procsetupbtn = New Button()
        Timer1 = New Timer(components)
        MenuStrip1.SuspendLayout()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        GroupBox3.SuspendLayout()
        GroupBox4.SuspendLayout()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.Items.AddRange(New ToolStripItem() {FileToolStripMenuItem, HelpToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(362, 24)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' FileToolStripMenuItem
        ' 
        FileToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {OpenProjectToolStripMenuItem1, SaveToolStripMenuItem, SaveAsToolStripMenuItem, CloseProjectToolStripMenuItem, ConnectionSettingsToolStripMenuItem, MisselaneousSettingsToolStripMenuItem, ExitToolStripMenuItem})
        FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        FileToolStripMenuItem.Size = New Size(37, 20)
        FileToolStripMenuItem.Text = "File"
        ' 
        ' OpenProjectToolStripMenuItem1
        ' 
        OpenProjectToolStripMenuItem1.Name = "OpenProjectToolStripMenuItem1"
        OpenProjectToolStripMenuItem1.Size = New Size(191, 22)
        OpenProjectToolStripMenuItem1.Text = "Open Project"
        ' 
        ' SaveToolStripMenuItem
        ' 
        SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        SaveToolStripMenuItem.Size = New Size(191, 22)
        SaveToolStripMenuItem.Text = "Save Project"
        ' 
        ' SaveAsToolStripMenuItem
        ' 
        SaveAsToolStripMenuItem.Name = "SaveAsToolStripMenuItem"
        SaveAsToolStripMenuItem.Size = New Size(191, 22)
        SaveAsToolStripMenuItem.Text = "Save Project As"
        ' 
        ' CloseProjectToolStripMenuItem
        ' 
        CloseProjectToolStripMenuItem.Name = "CloseProjectToolStripMenuItem"
        CloseProjectToolStripMenuItem.Size = New Size(191, 22)
        CloseProjectToolStripMenuItem.Text = "Close Project"
        ' 
        ' ConnectionSettingsToolStripMenuItem
        ' 
        ConnectionSettingsToolStripMenuItem.Name = "ConnectionSettingsToolStripMenuItem"
        ConnectionSettingsToolStripMenuItem.Size = New Size(191, 22)
        ConnectionSettingsToolStripMenuItem.Text = "Connection Settings"
        ' 
        ' MisselaneousSettingsToolStripMenuItem
        ' 
        MisselaneousSettingsToolStripMenuItem.Name = "MisselaneousSettingsToolStripMenuItem"
        MisselaneousSettingsToolStripMenuItem.Size = New Size(191, 22)
        MisselaneousSettingsToolStripMenuItem.Text = "Miscelaneous Settings"
        ' 
        ' ExitToolStripMenuItem
        ' 
        ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        ExitToolStripMenuItem.Size = New Size(191, 22)
        ExitToolStripMenuItem.Text = "Exit"
        ' 
        ' HelpToolStripMenuItem
        ' 
        HelpToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {HelpToolStripMenuItem1, AboutToolStripMenuItem})
        HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        HelpToolStripMenuItem.Size = New Size(44, 20)
        HelpToolStripMenuItem.Text = "Help"
        ' 
        ' HelpToolStripMenuItem1
        ' 
        HelpToolStripMenuItem1.Name = "HelpToolStripMenuItem1"
        HelpToolStripMenuItem1.Size = New Size(107, 22)
        HelpToolStripMenuItem1.Text = "Help"
        ' 
        ' AboutToolStripMenuItem
        ' 
        AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        AboutToolStripMenuItem.Size = New Size(107, 22)
        AboutToolStripMenuItem.Text = "About"
        ' 
        ' processcycle
        ' 
        processcycle.FormattingEnabled = True
        processcycle.Location = New Point(70, 259)
        processcycle.Name = "processcycle"
        processcycle.Size = New Size(210, 21)
        processcycle.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Microsoft Sans Serif", 12.0F, FontStyle.Bold, GraphicsUnit.Point, 161)
        Label1.Location = New Point(80, 236)
        Label1.Name = "Label1"
        Label1.Size = New Size(182, 20)
        Label1.TabIndex = 2
        Label1.Text = "Choose Type of Cycle"
        ' 
        ' Quitbtn
        ' 
        Quitbtn.Font = New Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 161)
        Quitbtn.Location = New Point(130, 556)
        Quitbtn.Name = "Quitbtn"
        Quitbtn.Size = New Size(85, 26)
        Quitbtn.TabIndex = 1
        Quitbtn.Text = "Quit"
        Quitbtn.TextAlign = ContentAlignment.TopCenter
        Quitbtn.UseVisualStyleBackColor = True
        ' 
        ' connect
        ' 
        connect.FlatStyle = FlatStyle.Popup
        connect.Font = New Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 161)
        connect.ForeColor = Color.Red
        connect.Location = New Point(41, 19)
        connect.Name = "connect"
        connect.Size = New Size(127, 26)
        connect.TabIndex = 0
        connect.Text = "Disconnected"
        connect.TextAlign = ContentAlignment.TopCenter
        connect.UseVisualStyleBackColor = True
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(Offlinecheck)
        GroupBox1.Controls.Add(Countdown)
        GroupBox1.Controls.Add(connect)
        GroupBox1.Location = New Point(71, 42)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(209, 98)
        GroupBox1.TabIndex = 22
        GroupBox1.TabStop = False
        GroupBox1.Text = "Connection"
        ' 
        ' Offlinecheck
        ' 
        Offlinecheck.AutoSize = True
        Offlinecheck.Location = New Point(64, 70)
        Offlinecheck.Name = "Offlinecheck"
        Offlinecheck.Size = New Size(80, 17)
        Offlinecheck.TabIndex = 2
        Offlinecheck.Text = "Stay Offline"
        Offlinecheck.UseVisualStyleBackColor = True
        ' 
        ' Countdown
        ' 
        Countdown.AutoSize = True
        Countdown.Location = New Point(58, 52)
        Countdown.Name = "Countdown"
        Countdown.Size = New Size(92, 13)
        Countdown.TabIndex = 1
        Countdown.Text = "Connecting in 10s"
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(Label7)
        GroupBox2.Controls.Add(Label6)
        GroupBox2.Controls.Add(RZCoord)
        GroupBox2.Controls.Add(RYCoord)
        GroupBox2.Controls.Add(Label5)
        GroupBox2.Controls.Add(RXCoord)
        GroupBox2.Controls.Add(Label4)
        GroupBox2.Controls.Add(ZCoord)
        GroupBox2.Controls.Add(Label3)
        GroupBox2.Controls.Add(YCoord)
        GroupBox2.Controls.Add(Label2)
        GroupBox2.Controls.Add(XCoord)
        GroupBox2.Controls.Add(Progress)
        GroupBox2.Controls.Add(ProgressBar)
        GroupBox2.Controls.Add(hold)
        GroupBox2.Controls.Add(run)
        GroupBox2.Location = New Point(20, 392)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(321, 158)
        GroupBox2.TabIndex = 23
        GroupBox2.TabStop = False
        GroupBox2.Text = "Program Status"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(257, 106)
        Label7.Name = "Label7"
        Label7.Size = New Size(49, 13)
        Label7.TabIndex = 35
        Label7.Text = "Rz (Deg)"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(210, 106)
        Label6.Name = "Label6"
        Label6.Size = New Size(49, 13)
        Label6.TabIndex = 34
        Label6.Text = "Ry (Deg)"
        ' 
        ' RZCoord
        ' 
        RZCoord.Location = New Point(260, 122)
        RZCoord.Name = "RZCoord"
        RZCoord.Size = New Size(43, 20)
        RZCoord.TabIndex = 32
        ' 
        ' RYCoord
        ' 
        RYCoord.Location = New Point(212, 122)
        RYCoord.Name = "RYCoord"
        RYCoord.Size = New Size(43, 20)
        RYCoord.TabIndex = 30
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(161, 106)
        Label5.Name = "Label5"
        Label5.Size = New Size(49, 13)
        Label5.TabIndex = 29
        Label5.Text = "Rx (Deg)"
        ' 
        ' RXCoord
        ' 
        RXCoord.Location = New Point(164, 122)
        RXCoord.Name = "RXCoord"
        RXCoord.Size = New Size(43, 20)
        RXCoord.TabIndex = 28
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(118, 106)
        Label4.Name = "Label4"
        Label4.Size = New Size(39, 13)
        Label4.TabIndex = 27
        Label4.Text = "Z (mm)"
        ' 
        ' ZCoord
        ' 
        ZCoord.Location = New Point(115, 122)
        ZCoord.Name = "ZCoord"
        ZCoord.Size = New Size(43, 20)
        ZCoord.TabIndex = 26
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(68, 106)
        Label3.Name = "Label3"
        Label3.Size = New Size(39, 13)
        Label3.TabIndex = 25
        Label3.Text = "Y (mm)"
        ' 
        ' YCoord
        ' 
        YCoord.Location = New Point(65, 122)
        YCoord.Name = "YCoord"
        YCoord.Size = New Size(43, 20)
        YCoord.TabIndex = 24
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(19, 106)
        Label2.Name = "Label2"
        Label2.Size = New Size(39, 13)
        Label2.TabIndex = 23
        Label2.Text = "X (mm)"
        ' 
        ' XCoord
        ' 
        XCoord.Location = New Point(16, 122)
        XCoord.Name = "XCoord"
        XCoord.Size = New Size(43, 20)
        XCoord.TabIndex = 22
        ' 
        ' Progress
        ' 
        Progress.AutoSize = True
        Progress.Font = New Font("Microsoft Sans Serif", 9.0F, FontStyle.Bold, GraphicsUnit.Point, 161)
        Progress.Location = New Point(90, 63)
        Progress.Name = "Progress"
        Progress.Size = New Size(123, 15)
        Progress.TabIndex = 21
        Progress.Text = "Program Progress"
        ' 
        ' ProgressBar
        ' 
        ProgressBar.AccessibleName = ""
        ProgressBar.Location = New Point(66, 80)
        ProgressBar.Name = "ProgressBar"
        ProgressBar.Size = New Size(178, 16)
        ProgressBar.TabIndex = 20
        ' 
        ' hold
        ' 
        hold.Font = New Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 161)
        hold.Location = New Point(166, 29)
        hold.Name = "hold"
        hold.Size = New Size(85, 26)
        hold.TabIndex = 19
        hold.Text = "Hold"
        hold.TextAlign = ContentAlignment.TopCenter
        hold.UseVisualStyleBackColor = True
        ' 
        ' run
        ' 
        run.Font = New Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 161)
        run.Location = New Point(59, 29)
        run.Name = "run"
        run.Size = New Size(85, 26)
        run.TabIndex = 18
        run.TabStop = False
        run.Text = "Running"
        run.TextAlign = ContentAlignment.TopCenter
        run.UseVisualStyleBackColor = True
        ' 
        ' Download
        ' 
        Download.Font = New Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 161)
        Download.Location = New Point(56, 28)
        Download.Name = "Download"
        Download.Size = New Size(91, 26)
        Download.TabIndex = 0
        Download.Text = "Download"
        Download.TextAlign = ContentAlignment.TopCenter
        Download.UseVisualStyleBackColor = True
        ' 
        ' GroupBox3
        ' 
        GroupBox3.Controls.Add(Download)
        GroupBox3.Location = New Point(71, 299)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(209, 76)
        GroupBox3.TabIndex = 25
        GroupBox3.TabStop = False
        GroupBox3.Text = "Program/Positions Download"
        ' 
        ' GroupBox4
        ' 
        GroupBox4.Controls.Add(Procsetupbtn)
        GroupBox4.Location = New Point(71, 146)
        GroupBox4.Name = "GroupBox4"
        GroupBox4.Size = New Size(209, 76)
        GroupBox4.TabIndex = 26
        GroupBox4.TabStop = False
        GroupBox4.Text = "Process Parameters"
        ' 
        ' Procsetupbtn
        ' 
        Procsetupbtn.Font = New Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 161)
        Procsetupbtn.Location = New Point(56, 29)
        Procsetupbtn.Name = "Procsetupbtn"
        Procsetupbtn.Size = New Size(89, 26)
        Procsetupbtn.TabIndex = 0
        Procsetupbtn.Text = "Setup"
        Procsetupbtn.TextAlign = ContentAlignment.TopCenter
        Procsetupbtn.UseVisualStyleBackColor = True
        ' 
        ' Timer1
        ' 
        Timer1.Interval = 1000
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(6.0F, 13.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(362, 599)
        Controls.Add(GroupBox4)
        Controls.Add(processcycle)
        Controls.Add(Label1)
        Controls.Add(GroupBox3)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Controls.Add(Quitbtn)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Name = "Form1"
        Text = "Robot Control"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        GroupBox3.ResumeLayout(False)
        GroupBox4.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Private components As IContainer

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenProjectToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveAsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CloseProjectToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents processcycle As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents HelpToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Quitbtn As Button
    Friend WithEvents connect As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents hold As Button
    Friend WithEvents run As Button
    Friend WithEvents Download As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Procsetupbtn As Button
    Friend WithEvents ConnectionSettingsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MisselaneousSettingsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Countdown As Label
    Friend WithEvents Offlinecheck As CheckBox
    Friend WithEvents Progress As Label
    Friend WithEvents ProgressBar As ProgressBar
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents RZCoord As TextBox
    Friend WithEvents RYCoord As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents RXCoord As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents ZCoord As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents YCoord As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents XCoord As TextBox
End Class
