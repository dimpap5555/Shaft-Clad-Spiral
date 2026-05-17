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
        Me.components = New System.ComponentModel.Container()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenProjectToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveAsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseProjectToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConnectionSettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MisselaneousSettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.processcycle = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Quitbtn = New System.Windows.Forms.Button()
        Me.connect = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Offlinecheck = New System.Windows.Forms.CheckBox()
        Me.Countdown = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.RZCoord = New System.Windows.Forms.TextBox()
        Me.RYCoord = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.RXCoord = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ZCoord = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.YCoord = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.XCoord = New System.Windows.Forms.TextBox()
        Me.Progress = New System.Windows.Forms.Label()
        Me.ProgressBar = New System.Windows.Forms.ProgressBar()
        Me.hold = New System.Windows.Forms.Button()
        Me.run = New System.Windows.Forms.Button()
        Me.Download = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Procsetupbtn = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(362, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenProjectToolStripMenuItem1, Me.SaveToolStripMenuItem, Me.SaveAsToolStripMenuItem, Me.CloseProjectToolStripMenuItem, Me.ConnectionSettingsToolStripMenuItem, Me.MisselaneousSettingsToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'OpenProjectToolStripMenuItem1
        '
        Me.OpenProjectToolStripMenuItem1.Name = "OpenProjectToolStripMenuItem1"
        Me.OpenProjectToolStripMenuItem1.Size = New System.Drawing.Size(191, 22)
        Me.OpenProjectToolStripMenuItem1.Text = "Open Project"
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
        Me.SaveToolStripMenuItem.Text = "Save Project"
        '
        'SaveAsToolStripMenuItem
        '
        Me.SaveAsToolStripMenuItem.Name = "SaveAsToolStripMenuItem"
        Me.SaveAsToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
        Me.SaveAsToolStripMenuItem.Text = "Save Project As"
        '
        'CloseProjectToolStripMenuItem
        '
        Me.CloseProjectToolStripMenuItem.Name = "CloseProjectToolStripMenuItem"
        Me.CloseProjectToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
        Me.CloseProjectToolStripMenuItem.Text = "Close Project"
        '
        'ConnectionSettingsToolStripMenuItem
        '
        Me.ConnectionSettingsToolStripMenuItem.Name = "ConnectionSettingsToolStripMenuItem"
        Me.ConnectionSettingsToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
        Me.ConnectionSettingsToolStripMenuItem.Text = "Connection Settings"
        '
        'MisselaneousSettingsToolStripMenuItem
        '
        Me.MisselaneousSettingsToolStripMenuItem.Name = "MisselaneousSettingsToolStripMenuItem"
        Me.MisselaneousSettingsToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
        Me.MisselaneousSettingsToolStripMenuItem.Text = "Miscelaneous Settings"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HelpToolStripMenuItem1, Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'HelpToolStripMenuItem1
        '
        Me.HelpToolStripMenuItem1.Name = "HelpToolStripMenuItem1"
        Me.HelpToolStripMenuItem1.Size = New System.Drawing.Size(107, 22)
        Me.HelpToolStripMenuItem1.Text = "Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'processcycle
        '
        Me.processcycle.FormattingEnabled = True
        Me.processcycle.Location = New System.Drawing.Point(70, 259)
        Me.processcycle.Name = "processcycle"
        Me.processcycle.Size = New System.Drawing.Size(210, 21)
        Me.processcycle.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.Label1.Location = New System.Drawing.Point(80, 236)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(182, 20)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Choose Type of Cycle"
        '
        'Quitbtn
        '
        Me.Quitbtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.Quitbtn.Location = New System.Drawing.Point(130, 556)
        Me.Quitbtn.Name = "Quitbtn"
        Me.Quitbtn.Size = New System.Drawing.Size(85, 26)
        Me.Quitbtn.TabIndex = 1
        Me.Quitbtn.Text = "Quit"
        Me.Quitbtn.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Quitbtn.UseVisualStyleBackColor = True
        '
        'connect
        '
        Me.connect.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.connect.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.connect.ForeColor = System.Drawing.Color.Red
        Me.connect.Location = New System.Drawing.Point(41, 19)
        Me.connect.Name = "connect"
        Me.connect.Size = New System.Drawing.Size(127, 26)
        Me.connect.TabIndex = 0
        Me.connect.Text = "Disconnected"
        Me.connect.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.connect.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Offlinecheck)
        Me.GroupBox1.Controls.Add(Me.Countdown)
        Me.GroupBox1.Controls.Add(Me.connect)
        Me.GroupBox1.Location = New System.Drawing.Point(71, 42)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(209, 98)
        Me.GroupBox1.TabIndex = 22
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Connection"
        '
        'Offlinecheck
        '
        Me.Offlinecheck.AutoSize = True
        Me.Offlinecheck.Location = New System.Drawing.Point(64, 70)
        Me.Offlinecheck.Name = "Offlinecheck"
        Me.Offlinecheck.Size = New System.Drawing.Size(80, 17)
        Me.Offlinecheck.TabIndex = 2
        Me.Offlinecheck.Text = "Stay Offline"
        Me.Offlinecheck.UseVisualStyleBackColor = True
        '
        'Countdown
        '
        Me.Countdown.AutoSize = True
        Me.Countdown.Location = New System.Drawing.Point(58, 52)
        Me.Countdown.Name = "Countdown"
        Me.Countdown.Size = New System.Drawing.Size(92, 13)
        Me.Countdown.TabIndex = 1
        Me.Countdown.Text = "Connecting in 10s"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.RZCoord)
        Me.GroupBox2.Controls.Add(Me.RYCoord)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.RXCoord)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.ZCoord)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.YCoord)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.XCoord)
        Me.GroupBox2.Controls.Add(Me.Progress)
        Me.GroupBox2.Controls.Add(Me.ProgressBar)
        Me.GroupBox2.Controls.Add(Me.hold)
        Me.GroupBox2.Controls.Add(Me.run)
        Me.GroupBox2.Location = New System.Drawing.Point(20, 392)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(321, 158)
        Me.GroupBox2.TabIndex = 23
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Program Status"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(257, 106)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(49, 13)
        Me.Label7.TabIndex = 35
        Me.Label7.Text = "Rz (Deg)"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(210, 106)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 13)
        Me.Label6.TabIndex = 34
        Me.Label6.Text = "Ry (Deg)"
        '
        'RZCoord
        '
        Me.RZCoord.Location = New System.Drawing.Point(260, 122)
        Me.RZCoord.Name = "RZCoord"
        Me.RZCoord.Size = New System.Drawing.Size(43, 20)
        Me.RZCoord.TabIndex = 32
        '
        'RYCoord
        '
        Me.RYCoord.Location = New System.Drawing.Point(212, 122)
        Me.RYCoord.Name = "RYCoord"
        Me.RYCoord.Size = New System.Drawing.Size(43, 20)
        Me.RYCoord.TabIndex = 30
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(161, 106)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 13)
        Me.Label5.TabIndex = 29
        Me.Label5.Text = "Rx (Deg)"
        '
        'RXCoord
        '
        Me.RXCoord.Location = New System.Drawing.Point(164, 122)
        Me.RXCoord.Name = "RXCoord"
        Me.RXCoord.Size = New System.Drawing.Size(43, 20)
        Me.RXCoord.TabIndex = 28
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(118, 106)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 13)
        Me.Label4.TabIndex = 27
        Me.Label4.Text = "Z (mm)"
        '
        'ZCoord
        '
        Me.ZCoord.Location = New System.Drawing.Point(115, 122)
        Me.ZCoord.Name = "ZCoord"
        Me.ZCoord.Size = New System.Drawing.Size(43, 20)
        Me.ZCoord.TabIndex = 26
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(68, 106)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "Y (mm)"
        '
        'YCoord
        '
        Me.YCoord.Location = New System.Drawing.Point(65, 122)
        Me.YCoord.Name = "YCoord"
        Me.YCoord.Size = New System.Drawing.Size(43, 20)
        Me.YCoord.TabIndex = 24
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(19, 106)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "X (mm)"
        '
        'XCoord
        '
        Me.XCoord.Location = New System.Drawing.Point(16, 122)
        Me.XCoord.Name = "XCoord"
        Me.XCoord.Size = New System.Drawing.Size(43, 20)
        Me.XCoord.TabIndex = 22
        '
        'Progress
        '
        Me.Progress.AutoSize = True
        Me.Progress.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.Progress.Location = New System.Drawing.Point(90, 63)
        Me.Progress.Name = "Progress"
        Me.Progress.Size = New System.Drawing.Size(123, 15)
        Me.Progress.TabIndex = 21
        Me.Progress.Text = "Program Progress"
        '
        'ProgressBar
        '
        Me.ProgressBar.AccessibleName = ""
        Me.ProgressBar.Location = New System.Drawing.Point(66, 80)
        Me.ProgressBar.Name = "ProgressBar"
        Me.ProgressBar.Size = New System.Drawing.Size(178, 16)
        Me.ProgressBar.TabIndex = 20
        '
        'hold
        '
        Me.hold.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.hold.Location = New System.Drawing.Point(166, 29)
        Me.hold.Name = "hold"
        Me.hold.Size = New System.Drawing.Size(85, 26)
        Me.hold.TabIndex = 19
        Me.hold.Text = "Hold"
        Me.hold.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.hold.UseVisualStyleBackColor = True
        '
        'run
        '
        Me.run.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.run.Location = New System.Drawing.Point(59, 29)
        Me.run.Name = "run"
        Me.run.Size = New System.Drawing.Size(85, 26)
        Me.run.TabIndex = 18
        Me.run.TabStop = False
        Me.run.Text = "Running"
        Me.run.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.run.UseVisualStyleBackColor = True
        '
        'Download
        '
        Me.Download.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.Download.Location = New System.Drawing.Point(56, 28)
        Me.Download.Name = "Download"
        Me.Download.Size = New System.Drawing.Size(91, 26)
        Me.Download.TabIndex = 0
        Me.Download.Text = "Download"
        Me.Download.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Download.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Download)
        Me.GroupBox3.Location = New System.Drawing.Point(71, 299)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(209, 76)
        Me.GroupBox3.TabIndex = 25
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Program/Positions Download"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Procsetupbtn)
        Me.GroupBox4.Location = New System.Drawing.Point(71, 146)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(209, 76)
        Me.GroupBox4.TabIndex = 26
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Process Parameters"
        '
        'Procsetupbtn
        '
        Me.Procsetupbtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.Procsetupbtn.Location = New System.Drawing.Point(56, 29)
        Me.Procsetupbtn.Name = "Procsetupbtn"
        Me.Procsetupbtn.Size = New System.Drawing.Size(89, 26)
        Me.Procsetupbtn.TabIndex = 0
        Me.Procsetupbtn.Text = "Setup"
        Me.Procsetupbtn.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Procsetupbtn.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(362, 599)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.processcycle)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Quitbtn)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Robot Control"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

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
