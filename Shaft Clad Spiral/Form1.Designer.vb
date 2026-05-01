Namespace WindowsApplication1
	' Token: 0x0200000E RID: 14
	<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
	Public Partial Class Form1
		Inherits Global.System.Windows.Forms.Form

		' Token: 0x060001C8 RID: 456 RVA: 0x00028160 File Offset: 0x00026560
		<Global.System.Diagnostics.DebuggerNonUserCode()>
		Protected Overrides Sub Dispose(disposing As Boolean)
			If disposing AndAlso Me.components IsNot Nothing Then
				Me.components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		' Token: 0x060001C9 RID: 457 RVA: 0x00028180 File Offset: 0x00026580
		<Global.System.Diagnostics.DebuggerStepThrough()>
		Private Sub InitializeComponent()
			Me.components = New Global.System.ComponentModel.Container()
			Me.MenuStrip1 = New Global.System.Windows.Forms.MenuStrip()
			Me.FileToolStripMenuItem = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.OpenProjectToolStripMenuItem1 = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.SaveToolStripMenuItem = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.SaveAsToolStripMenuItem = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.CloseProjectToolStripMenuItem = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.ConnectionSettingsToolStripMenuItem = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.MisselaneousSettingsToolStripMenuItem = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.ExitToolStripMenuItem = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.HelpToolStripMenuItem = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.HelpToolStripMenuItem1 = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.AboutToolStripMenuItem = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.processcycle = New Global.System.Windows.Forms.ComboBox()
			Me.Label1 = New Global.System.Windows.Forms.Label()
			Me.Quitbtn = New Global.System.Windows.Forms.Button()
			Me.connect = New Global.System.Windows.Forms.Button()
			Me.GroupBox1 = New Global.System.Windows.Forms.GroupBox()
			Me.Offlinecheck = New Global.System.Windows.Forms.CheckBox()
			Me.Countdown = New Global.System.Windows.Forms.Label()
			Me.GroupBox2 = New Global.System.Windows.Forms.GroupBox()
			Me.Label7 = New Global.System.Windows.Forms.Label()
			Me.Label6 = New Global.System.Windows.Forms.Label()
			Me.RZCoord = New Global.System.Windows.Forms.TextBox()
			Me.RYCoord = New Global.System.Windows.Forms.TextBox()
			Me.Label5 = New Global.System.Windows.Forms.Label()
			Me.RXCoord = New Global.System.Windows.Forms.TextBox()
			Me.Label4 = New Global.System.Windows.Forms.Label()
			Me.ZCoord = New Global.System.Windows.Forms.TextBox()
			Me.Label3 = New Global.System.Windows.Forms.Label()
			Me.YCoord = New Global.System.Windows.Forms.TextBox()
			Me.Label2 = New Global.System.Windows.Forms.Label()
			Me.XCoord = New Global.System.Windows.Forms.TextBox()
			Me.Progress = New Global.System.Windows.Forms.Label()
			Me.ProgressBar = New Global.System.Windows.Forms.ProgressBar()
			Me.hold = New Global.System.Windows.Forms.Button()
			Me.run = New Global.System.Windows.Forms.Button()
			Me.Download = New Global.System.Windows.Forms.Button()
			Me.GroupBox3 = New Global.System.Windows.Forms.GroupBox()
			Me.GroupBox4 = New Global.System.Windows.Forms.GroupBox()
			Me.Procsetupbtn = New Global.System.Windows.Forms.Button()
			Me.Timer1 = New Global.System.Windows.Forms.Timer(Me.components)
			Me.MenuStrip1.SuspendLayout()
			Me.GroupBox1.SuspendLayout()
			Me.GroupBox2.SuspendLayout()
			Me.GroupBox3.SuspendLayout()
			Me.GroupBox4.SuspendLayout()
			Me.SuspendLayout()
			Me.MenuStrip1.Items.AddRange(New Global.System.Windows.Forms.ToolStripItem() { Me.FileToolStripMenuItem, Me.HelpToolStripMenuItem })
			Dim menuStrip As Global.System.Windows.Forms.Control = Me.MenuStrip1
			Dim location As Global.System.Drawing.Point = New Global.System.Drawing.Point(0, 0)
			menuStrip.Location = location
			Me.MenuStrip1.Name = "MenuStrip1"
			Dim menuStrip2 As Global.System.Windows.Forms.Control = Me.MenuStrip1
			Dim size As Global.System.Drawing.Size = New Global.System.Drawing.Size(362, 24)
			menuStrip2.Size = size
			Me.MenuStrip1.TabIndex = 0
			Me.MenuStrip1.Text = "MenuStrip1"
			Me.FileToolStripMenuItem.DropDownItems.AddRange(New Global.System.Windows.Forms.ToolStripItem() { Me.OpenProjectToolStripMenuItem1, Me.SaveToolStripMenuItem, Me.SaveAsToolStripMenuItem, Me.CloseProjectToolStripMenuItem, Me.ConnectionSettingsToolStripMenuItem, Me.MisselaneousSettingsToolStripMenuItem, Me.ExitToolStripMenuItem })
			Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
			Dim fileToolStripMenuItem As Global.System.Windows.Forms.ToolStripItem = Me.FileToolStripMenuItem
			size = New Global.System.Drawing.Size(37, 20)
			fileToolStripMenuItem.Size = size
			Me.FileToolStripMenuItem.Text = "File"
			Me.OpenProjectToolStripMenuItem1.Name = "OpenProjectToolStripMenuItem1"
			Dim openProjectToolStripMenuItem As Global.System.Windows.Forms.ToolStripItem = Me.OpenProjectToolStripMenuItem1
			size = New Global.System.Drawing.Size(191, 22)
			openProjectToolStripMenuItem.Size = size
			Me.OpenProjectToolStripMenuItem1.Text = "Open Project"
			Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
			Dim saveToolStripMenuItem As Global.System.Windows.Forms.ToolStripItem = Me.SaveToolStripMenuItem
			size = New Global.System.Drawing.Size(191, 22)
			saveToolStripMenuItem.Size = size
			Me.SaveToolStripMenuItem.Text = "Save Project"
			Me.SaveAsToolStripMenuItem.Name = "SaveAsToolStripMenuItem"
			Dim saveAsToolStripMenuItem As Global.System.Windows.Forms.ToolStripItem = Me.SaveAsToolStripMenuItem
			size = New Global.System.Drawing.Size(191, 22)
			saveAsToolStripMenuItem.Size = size
			Me.SaveAsToolStripMenuItem.Text = "Save Project As"
			Me.CloseProjectToolStripMenuItem.Name = "CloseProjectToolStripMenuItem"
			Dim closeProjectToolStripMenuItem As Global.System.Windows.Forms.ToolStripItem = Me.CloseProjectToolStripMenuItem
			size = New Global.System.Drawing.Size(191, 22)
			closeProjectToolStripMenuItem.Size = size
			Me.CloseProjectToolStripMenuItem.Text = "Close Project"
			Me.ConnectionSettingsToolStripMenuItem.Name = "ConnectionSettingsToolStripMenuItem"
			Dim connectionSettingsToolStripMenuItem As Global.System.Windows.Forms.ToolStripItem = Me.ConnectionSettingsToolStripMenuItem
			size = New Global.System.Drawing.Size(191, 22)
			connectionSettingsToolStripMenuItem.Size = size
			Me.ConnectionSettingsToolStripMenuItem.Text = "Connection Settings"
			Me.MisselaneousSettingsToolStripMenuItem.Name = "MisselaneousSettingsToolStripMenuItem"
			Dim misselaneousSettingsToolStripMenuItem As Global.System.Windows.Forms.ToolStripItem = Me.MisselaneousSettingsToolStripMenuItem
			size = New Global.System.Drawing.Size(191, 22)
			misselaneousSettingsToolStripMenuItem.Size = size
			Me.MisselaneousSettingsToolStripMenuItem.Text = "Miscelaneous Settings"
			Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
			Dim exitToolStripMenuItem As Global.System.Windows.Forms.ToolStripItem = Me.ExitToolStripMenuItem
			size = New Global.System.Drawing.Size(191, 22)
			exitToolStripMenuItem.Size = size
			Me.ExitToolStripMenuItem.Text = "Exit"
			Me.HelpToolStripMenuItem.DropDownItems.AddRange(New Global.System.Windows.Forms.ToolStripItem() { Me.HelpToolStripMenuItem1, Me.AboutToolStripMenuItem })
			Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
			Dim helpToolStripMenuItem As Global.System.Windows.Forms.ToolStripItem = Me.HelpToolStripMenuItem
			size = New Global.System.Drawing.Size(44, 20)
			helpToolStripMenuItem.Size = size
			Me.HelpToolStripMenuItem.Text = "Help"
			Me.HelpToolStripMenuItem1.Name = "HelpToolStripMenuItem1"
			Dim helpToolStripMenuItem2 As Global.System.Windows.Forms.ToolStripItem = Me.HelpToolStripMenuItem1
			size = New Global.System.Drawing.Size(107, 22)
			helpToolStripMenuItem2.Size = size
			Me.HelpToolStripMenuItem1.Text = "Help"
			Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
			Dim aboutToolStripMenuItem As Global.System.Windows.Forms.ToolStripItem = Me.AboutToolStripMenuItem
			size = New Global.System.Drawing.Size(107, 22)
			aboutToolStripMenuItem.Size = size
			Me.AboutToolStripMenuItem.Text = "About"
			Me.processcycle.FormattingEnabled = True
			Dim processcycle As Global.System.Windows.Forms.Control = Me.processcycle
			location = New Global.System.Drawing.Point(70, 259)
			processcycle.Location = location
			Me.processcycle.Name = "processcycle"
			Dim processcycle2 As Global.System.Windows.Forms.Control = Me.processcycle
			size = New Global.System.Drawing.Size(210, 21)
			processcycle2.Size = size
			Me.processcycle.TabIndex = 0
			Me.Label1.AutoSize = True
			Me.Label1.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 12F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 161)
			Dim label As Global.System.Windows.Forms.Control = Me.Label1
			location = New Global.System.Drawing.Point(80, 236)
			label.Location = location
			Me.Label1.Name = "Label1"
			Dim label2 As Global.System.Windows.Forms.Control = Me.Label1
			size = New Global.System.Drawing.Size(182, 20)
			label2.Size = size
			Me.Label1.TabIndex = 2
			Me.Label1.Text = "Choose Type of Cycle"
			Me.Quitbtn.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 11.25F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 161)
			Dim quitbtn As Global.System.Windows.Forms.Control = Me.Quitbtn
			location = New Global.System.Drawing.Point(130, 556)
			quitbtn.Location = location
			Me.Quitbtn.Name = "Quitbtn"
			Dim quitbtn2 As Global.System.Windows.Forms.Control = Me.Quitbtn
			size = New Global.System.Drawing.Size(85, 26)
			quitbtn2.Size = size
			Me.Quitbtn.TabIndex = 1
			Me.Quitbtn.Text = "Quit"
			Me.Quitbtn.TextAlign = Global.System.Drawing.ContentAlignment.TopCenter
			Me.Quitbtn.UseVisualStyleBackColor = True
			Me.connect.FlatStyle = Global.System.Windows.Forms.FlatStyle.Popup
			Me.connect.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 11.25F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 161)
			Me.connect.ForeColor = Global.System.Drawing.Color.Red
			Dim connect As Global.System.Windows.Forms.Control = Me.connect
			location = New Global.System.Drawing.Point(41, 19)
			connect.Location = location
			Me.connect.Name = "connect"
			Dim connect2 As Global.System.Windows.Forms.Control = Me.connect
			size = New Global.System.Drawing.Size(127, 26)
			connect2.Size = size
			Me.connect.TabIndex = 0
			Me.connect.Text = "Disconnected"
			Me.connect.TextAlign = Global.System.Drawing.ContentAlignment.TopCenter
			Me.connect.UseVisualStyleBackColor = True
			Me.GroupBox1.Controls.Add(Me.Offlinecheck)
			Me.GroupBox1.Controls.Add(Me.Countdown)
			Me.GroupBox1.Controls.Add(Me.connect)
			Dim groupBox As Global.System.Windows.Forms.Control = Me.GroupBox1
			location = New Global.System.Drawing.Point(71, 42)
			groupBox.Location = location
			Me.GroupBox1.Name = "GroupBox1"
			Dim groupBox2 As Global.System.Windows.Forms.Control = Me.GroupBox1
			size = New Global.System.Drawing.Size(209, 98)
			groupBox2.Size = size
			Me.GroupBox1.TabIndex = 22
			Me.GroupBox1.TabStop = False
			Me.GroupBox1.Text = "Connection"
			Me.Offlinecheck.AutoSize = True
			Dim offlinecheck As Global.System.Windows.Forms.Control = Me.Offlinecheck
			location = New Global.System.Drawing.Point(64, 70)
			offlinecheck.Location = location
			Me.Offlinecheck.Name = "Offlinecheck"
			Dim offlinecheck2 As Global.System.Windows.Forms.Control = Me.Offlinecheck
			size = New Global.System.Drawing.Size(80, 17)
			offlinecheck2.Size = size
			Me.Offlinecheck.TabIndex = 2
			Me.Offlinecheck.Text = "Stay Offline"
			Me.Offlinecheck.UseVisualStyleBackColor = True
			Me.Countdown.AutoSize = True
			Dim countdown As Global.System.Windows.Forms.Control = Me.Countdown
			location = New Global.System.Drawing.Point(58, 52)
			countdown.Location = location
			Me.Countdown.Name = "Countdown"
			Dim countdown2 As Global.System.Windows.Forms.Control = Me.Countdown
			size = New Global.System.Drawing.Size(92, 13)
			countdown2.Size = size
			Me.Countdown.TabIndex = 1
			Me.Countdown.Text = "Connecting in 10s"
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
			Dim groupBox3 As Global.System.Windows.Forms.Control = Me.GroupBox2
			location = New Global.System.Drawing.Point(20, 392)
			groupBox3.Location = location
			Me.GroupBox2.Name = "GroupBox2"
			Dim groupBox4 As Global.System.Windows.Forms.Control = Me.GroupBox2
			size = New Global.System.Drawing.Size(321, 158)
			groupBox4.Size = size
			Me.GroupBox2.TabIndex = 23
			Me.GroupBox2.TabStop = False
			Me.GroupBox2.Text = "Program Status"
			Me.Label7.AutoSize = True
			Dim label3 As Global.System.Windows.Forms.Control = Me.Label7
			location = New Global.System.Drawing.Point(257, 106)
			label3.Location = location
			Me.Label7.Name = "Label7"
			Dim label4 As Global.System.Windows.Forms.Control = Me.Label7
			size = New Global.System.Drawing.Size(49, 13)
			label4.Size = size
			Me.Label7.TabIndex = 35
			Me.Label7.Text = "Rz (Deg)"
			Me.Label6.AutoSize = True
			Dim label5 As Global.System.Windows.Forms.Control = Me.Label6
			location = New Global.System.Drawing.Point(210, 106)
			label5.Location = location
			Me.Label6.Name = "Label6"
			Dim label6 As Global.System.Windows.Forms.Control = Me.Label6
			size = New Global.System.Drawing.Size(49, 13)
			label6.Size = size
			Me.Label6.TabIndex = 34
			Me.Label6.Text = "Ry (Deg)"
			Dim rzcoord As Global.System.Windows.Forms.Control = Me.RZCoord
			location = New Global.System.Drawing.Point(260, 122)
			rzcoord.Location = location
			Me.RZCoord.Name = "RZCoord"
			Dim rzcoord2 As Global.System.Windows.Forms.Control = Me.RZCoord
			size = New Global.System.Drawing.Size(43, 20)
			rzcoord2.Size = size
			Me.RZCoord.TabIndex = 32
			Dim rycoord As Global.System.Windows.Forms.Control = Me.RYCoord
			location = New Global.System.Drawing.Point(212, 122)
			rycoord.Location = location
			Me.RYCoord.Name = "RYCoord"
			Dim rycoord2 As Global.System.Windows.Forms.Control = Me.RYCoord
			size = New Global.System.Drawing.Size(43, 20)
			rycoord2.Size = size
			Me.RYCoord.TabIndex = 30
			Me.Label5.AutoSize = True
			Dim label7 As Global.System.Windows.Forms.Control = Me.Label5
			location = New Global.System.Drawing.Point(161, 106)
			label7.Location = location
			Me.Label5.Name = "Label5"
			Dim label8 As Global.System.Windows.Forms.Control = Me.Label5
			size = New Global.System.Drawing.Size(49, 13)
			label8.Size = size
			Me.Label5.TabIndex = 29
			Me.Label5.Text = "Rx (Deg)"
			Dim rxcoord As Global.System.Windows.Forms.Control = Me.RXCoord
			location = New Global.System.Drawing.Point(164, 122)
			rxcoord.Location = location
			Me.RXCoord.Name = "RXCoord"
			Dim rxcoord2 As Global.System.Windows.Forms.Control = Me.RXCoord
			size = New Global.System.Drawing.Size(43, 20)
			rxcoord2.Size = size
			Me.RXCoord.TabIndex = 28
			Me.Label4.AutoSize = True
			Dim label9 As Global.System.Windows.Forms.Control = Me.Label4
			location = New Global.System.Drawing.Point(118, 106)
			label9.Location = location
			Me.Label4.Name = "Label4"
			Dim label10 As Global.System.Windows.Forms.Control = Me.Label4
			size = New Global.System.Drawing.Size(39, 13)
			label10.Size = size
			Me.Label4.TabIndex = 27
			Me.Label4.Text = "Z (mm)"
			Dim zcoord As Global.System.Windows.Forms.Control = Me.ZCoord
			location = New Global.System.Drawing.Point(115, 122)
			zcoord.Location = location
			Me.ZCoord.Name = "ZCoord"
			Dim zcoord2 As Global.System.Windows.Forms.Control = Me.ZCoord
			size = New Global.System.Drawing.Size(43, 20)
			zcoord2.Size = size
			Me.ZCoord.TabIndex = 26
			Me.Label3.AutoSize = True
			Dim label11 As Global.System.Windows.Forms.Control = Me.Label3
			location = New Global.System.Drawing.Point(68, 106)
			label11.Location = location
			Me.Label3.Name = "Label3"
			Dim label12 As Global.System.Windows.Forms.Control = Me.Label3
			size = New Global.System.Drawing.Size(39, 13)
			label12.Size = size
			Me.Label3.TabIndex = 25
			Me.Label3.Text = "Y (mm)"
			Dim ycoord As Global.System.Windows.Forms.Control = Me.YCoord
			location = New Global.System.Drawing.Point(65, 122)
			ycoord.Location = location
			Me.YCoord.Name = "YCoord"
			Dim ycoord2 As Global.System.Windows.Forms.Control = Me.YCoord
			size = New Global.System.Drawing.Size(43, 20)
			ycoord2.Size = size
			Me.YCoord.TabIndex = 24
			Me.Label2.AutoSize = True
			Dim label13 As Global.System.Windows.Forms.Control = Me.Label2
			location = New Global.System.Drawing.Point(19, 106)
			label13.Location = location
			Me.Label2.Name = "Label2"
			Dim label14 As Global.System.Windows.Forms.Control = Me.Label2
			size = New Global.System.Drawing.Size(39, 13)
			label14.Size = size
			Me.Label2.TabIndex = 23
			Me.Label2.Text = "X (mm)"
			Dim xcoord As Global.System.Windows.Forms.Control = Me.XCoord
			location = New Global.System.Drawing.Point(16, 122)
			xcoord.Location = location
			Me.XCoord.Name = "XCoord"
			Dim xcoord2 As Global.System.Windows.Forms.Control = Me.XCoord
			size = New Global.System.Drawing.Size(43, 20)
			xcoord2.Size = size
			Me.XCoord.TabIndex = 22
			Me.Progress.AutoSize = True
			Me.Progress.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 9F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 161)
			Dim progress As Global.System.Windows.Forms.Control = Me.Progress
			location = New Global.System.Drawing.Point(90, 63)
			progress.Location = location
			Me.Progress.Name = "Progress"
			Dim progress2 As Global.System.Windows.Forms.Control = Me.Progress
			size = New Global.System.Drawing.Size(123, 15)
			progress2.Size = size
			Me.Progress.TabIndex = 21
			Me.Progress.Text = "Program Progress"
			Me.ProgressBar.AccessibleName = ""
			Dim progressBar As Global.System.Windows.Forms.Control = Me.ProgressBar
			location = New Global.System.Drawing.Point(66, 80)
			progressBar.Location = location
			Me.ProgressBar.Name = "ProgressBar"
			Dim progressBar2 As Global.System.Windows.Forms.Control = Me.ProgressBar
			size = New Global.System.Drawing.Size(178, 16)
			progressBar2.Size = size
			Me.ProgressBar.TabIndex = 20
			Me.hold.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 11.25F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 161)
			Dim hold As Global.System.Windows.Forms.Control = Me.hold
			location = New Global.System.Drawing.Point(166, 29)
			hold.Location = location
			Me.hold.Name = "hold"
			Dim hold2 As Global.System.Windows.Forms.Control = Me.hold
			size = New Global.System.Drawing.Size(85, 26)
			hold2.Size = size
			Me.hold.TabIndex = 19
			Me.hold.Text = "Hold"
			Me.hold.TextAlign = Global.System.Drawing.ContentAlignment.TopCenter
			Me.hold.UseVisualStyleBackColor = True
			Me.run.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 11.25F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 161)
			Dim run As Global.System.Windows.Forms.Control = Me.run
			location = New Global.System.Drawing.Point(59, 29)
			run.Location = location
			Me.run.Name = "run"
			Dim run2 As Global.System.Windows.Forms.Control = Me.run
			size = New Global.System.Drawing.Size(85, 26)
			run2.Size = size
			Me.run.TabIndex = 18
			Me.run.TabStop = False
			Me.run.Text = "Running"
			Me.run.TextAlign = Global.System.Drawing.ContentAlignment.TopCenter
			Me.run.UseVisualStyleBackColor = True
			Me.Download.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 11.25F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 161)
			Dim download As Global.System.Windows.Forms.Control = Me.Download
			location = New Global.System.Drawing.Point(56, 28)
			download.Location = location
			Me.Download.Name = "Download"
			Dim download2 As Global.System.Windows.Forms.Control = Me.Download
			size = New Global.System.Drawing.Size(91, 26)
			download2.Size = size
			Me.Download.TabIndex = 0
			Me.Download.Text = "Download"
			Me.Download.TextAlign = Global.System.Drawing.ContentAlignment.TopCenter
			Me.Download.UseVisualStyleBackColor = True
			Me.GroupBox3.Controls.Add(Me.Download)
			Dim groupBox5 As Global.System.Windows.Forms.Control = Me.GroupBox3
			location = New Global.System.Drawing.Point(71, 299)
			groupBox5.Location = location
			Me.GroupBox3.Name = "GroupBox3"
			Dim groupBox6 As Global.System.Windows.Forms.Control = Me.GroupBox3
			size = New Global.System.Drawing.Size(209, 76)
			groupBox6.Size = size
			Me.GroupBox3.TabIndex = 25
			Me.GroupBox3.TabStop = False
			Me.GroupBox3.Text = "Program/Positions Download"
			Me.GroupBox4.Controls.Add(Me.Procsetupbtn)
			Dim groupBox7 As Global.System.Windows.Forms.Control = Me.GroupBox4
			location = New Global.System.Drawing.Point(71, 146)
			groupBox7.Location = location
			Me.GroupBox4.Name = "GroupBox4"
			Dim groupBox8 As Global.System.Windows.Forms.Control = Me.GroupBox4
			size = New Global.System.Drawing.Size(209, 76)
			groupBox8.Size = size
			Me.GroupBox4.TabIndex = 26
			Me.GroupBox4.TabStop = False
			Me.GroupBox4.Text = "Process Parameters"
			Me.Procsetupbtn.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 11.25F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 161)
			Dim procsetupbtn As Global.System.Windows.Forms.Control = Me.Procsetupbtn
			location = New Global.System.Drawing.Point(56, 29)
			procsetupbtn.Location = location
			Me.Procsetupbtn.Name = "Procsetupbtn"
			Dim procsetupbtn2 As Global.System.Windows.Forms.Control = Me.Procsetupbtn
			size = New Global.System.Drawing.Size(89, 26)
			procsetupbtn2.Size = size
			Me.Procsetupbtn.TabIndex = 0
			Me.Procsetupbtn.Text = "Setup"
			Me.Procsetupbtn.TextAlign = Global.System.Drawing.ContentAlignment.TopCenter
			Me.Procsetupbtn.UseVisualStyleBackColor = True
			Me.Timer1.Interval = 1000
			Dim autoScaleDimensions As Global.System.Drawing.SizeF = New Global.System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleDimensions = autoScaleDimensions
			Me.AutoScaleMode = Global.System.Windows.Forms.AutoScaleMode.Font
			size = New Global.System.Drawing.Size(362, 599)
			Me.ClientSize = size
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

		' Token: 0x040000A9 RID: 169
		Private components As Global.System.ComponentModel.IContainer

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
End Namespace
