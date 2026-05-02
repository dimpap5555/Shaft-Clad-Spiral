Namespace WindowsApplication1
	' Token: 0x02000014 RID: 20
	<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
	Public Partial Class MPosıtıonupload
		Inherits Global.System.Windows.Forms.Form

		' Token: 0x0600041E RID: 1054 RVA: 0x0003BC70 File Offset: 0x0003A070
		<Global.System.Diagnostics.DebuggerNonUserCode()>
		Protected Overrides Sub Dispose(disposing As Boolean)
			Try
				If disposing AndAlso Me.components IsNot Nothing Then
					Me.components.Dispose()
				End If
			Finally
				MyBase.Dispose(disposing)
			End Try
		End Sub

		' Token: 0x0600041F RID: 1055 RVA: 0x0003BCB0 File Offset: 0x0003A0B0
		<Global.System.Diagnostics.DebuggerStepThrough()>
		Private Sub InitializeComponent()
			Dim DataGridViewCellStyle As Global.System.Windows.Forms.DataGridViewCellStyle = New Global.System.Windows.Forms.DataGridViewCellStyle()
			Dim DataGridViewCellStyle2 As Global.System.Windows.Forms.DataGridViewCellStyle = New Global.System.Windows.Forms.DataGridViewCellStyle()
			Me.Xpostxt = New Global.System.Windows.Forms.TextBox()
			Me.GroupBox1 = New Global.System.Windows.Forms.GroupBox()
			Me.Label6 = New Global.System.Windows.Forms.Label()
			Me.Label5 = New Global.System.Windows.Forms.Label()
			Me.Label4 = New Global.System.Windows.Forms.Label()
			Me.Label3 = New Global.System.Windows.Forms.Label()
			Me.Label2 = New Global.System.Windows.Forms.Label()
			Me.Label1 = New Global.System.Windows.Forms.Label()
			Me.Rzpostxt = New Global.System.Windows.Forms.TextBox()
			Me.Rypostxt = New Global.System.Windows.Forms.TextBox()
			Me.Rxpostxt = New Global.System.Windows.Forms.TextBox()
			Me.Zpostxt = New Global.System.Windows.Forms.TextBox()
			Me.Ypostxt = New Global.System.Windows.Forms.TextBox()
			Me.GroupBox2 = New Global.System.Windows.Forms.GroupBox()
			Me.Label8 = New Global.System.Windows.Forms.Label()
			Me.Label7 = New Global.System.Windows.Forms.Label()
			Me.S2postxt = New Global.System.Windows.Forms.TextBox()
			Me.S1postxt = New Global.System.Windows.Forms.TextBox()
			Me.GroupBox3 = New Global.System.Windows.Forms.GroupBox()
			Me.Usrfrmtxt = New Global.System.Windows.Forms.TextBox()
			Me.Cnfrm_btn = New Global.System.Windows.Forms.Button()
			Me.Cncl_btn = New Global.System.Windows.Forms.Button()
			Me.Upload_btn = New Global.System.Windows.Forms.Button()
			Me.GridView = New Global.System.Windows.Forms.DataGridView()
			Me.Upbutton = New Global.System.Windows.Forms.Button()
			Me.Downbutton = New Global.System.Windows.Forms.Button()
			Me.Delbutton = New Global.System.Windows.Forms.Button()
			Me.GroupBox4 = New Global.System.Windows.Forms.GroupBox()
			Me.ConstBeam = New Global.System.Windows.Forms.CheckBox()
			Me.Label11 = New Global.System.Windows.Forms.Label()
			Me.Beamdiatxt = New Global.System.Windows.Forms.TextBox()
			Me.Label9 = New Global.System.Windows.Forms.Label()
			Me.Powertxt = New Global.System.Windows.Forms.TextBox()
			Me.Label10 = New Global.System.Windows.Forms.Label()
			Me.MenuStrip1 = New Global.System.Windows.Forms.MenuStrip()
			Me.ToolStripMenuItem1 = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.LoadDataFileToolStripMenuItem = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.SaveDataFileToolStripMenuItem = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.GroupBox1.SuspendLayout()
			Me.GroupBox2.SuspendLayout()
			Me.GroupBox3.SuspendLayout()
			CType(Me.GridView, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			Me.GroupBox4.SuspendLayout()
			Me.MenuStrip1.SuspendLayout()
			Me.SuspendLayout()
			Me.Xpostxt.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 9.75F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 161)
			Dim xpostxt As Global.System.Windows.Forms.Control = Me.Xpostxt
			Dim location As Global.System.Drawing.Point = New Global.System.Drawing.Point(26, 44)
			xpostxt.Location = location
			Me.Xpostxt.Name = "Xpostxt"
			Dim xpostxt2 As Global.System.Windows.Forms.Control = Me.Xpostxt
			Dim size As Global.System.Drawing.Size = New Global.System.Drawing.Size(75, 22)
			xpostxt2.Size = size
			Me.Xpostxt.TabIndex = 1
			Me.GroupBox1.Controls.Add(Me.Label6)
			Me.GroupBox1.Controls.Add(Me.Label5)
			Me.GroupBox1.Controls.Add(Me.Label4)
			Me.GroupBox1.Controls.Add(Me.Label3)
			Me.GroupBox1.Controls.Add(Me.Label2)
			Me.GroupBox1.Controls.Add(Me.Label1)
			Me.GroupBox1.Controls.Add(Me.Rzpostxt)
			Me.GroupBox1.Controls.Add(Me.Rypostxt)
			Me.GroupBox1.Controls.Add(Me.Rxpostxt)
			Me.GroupBox1.Controls.Add(Me.Zpostxt)
			Me.GroupBox1.Controls.Add(Me.Ypostxt)
			Me.GroupBox1.Controls.Add(Me.Xpostxt)
			Dim groupBox As Global.System.Windows.Forms.Control = Me.GroupBox1
			location = New Global.System.Drawing.Point(102, 136)
			groupBox.Location = location
			Me.GroupBox1.Name = "GroupBox1"
			Dim groupBox2 As Global.System.Windows.Forms.Control = Me.GroupBox1
			size = New Global.System.Drawing.Size(609, 98)
			groupBox2.Size = size
			Me.GroupBox1.TabIndex = 2
			Me.GroupBox1.TabStop = False
			Me.GroupBox1.Text = "Robot Position"
			Me.Label6.AutoSize = True
			Dim label As Global.System.Windows.Forms.Control = Me.Label6
			location = New Global.System.Drawing.Point(519, 28)
			label.Location = location
			Me.Label6.Name = "Label6"
			Dim label2 As Global.System.Windows.Forms.Control = Me.Label6
			size = New Global.System.Drawing.Size(49, 13)
			label2.Size = size
			Me.Label6.TabIndex = 9
			Me.Label6.Text = "Rz (Deg)"
			Me.Label5.AutoSize = True
			Dim label3 As Global.System.Windows.Forms.Control = Me.Label5
			location = New Global.System.Drawing.Point(424, 28)
			label3.Location = location
			Me.Label5.Name = "Label5"
			Dim label4 As Global.System.Windows.Forms.Control = Me.Label5
			size = New Global.System.Drawing.Size(49, 13)
			label4.Size = size
			Me.Label5.TabIndex = 9
			Me.Label5.Text = "Ry (Deg)"
			Me.Label4.AutoSize = True
			Dim label5 As Global.System.Windows.Forms.Control = Me.Label4
			location = New Global.System.Drawing.Point(326, 28)
			label5.Location = location
			Me.Label4.Name = "Label4"
			Dim label6 As Global.System.Windows.Forms.Control = Me.Label4
			size = New Global.System.Drawing.Size(49, 13)
			label6.Size = size
			Me.Label4.TabIndex = 8
			Me.Label4.Text = "Rx (Deg)"
			Me.Label3.AutoSize = True
			Dim label7 As Global.System.Windows.Forms.Control = Me.Label3
			location = New Global.System.Drawing.Point(236, 28)
			label7.Location = location
			Me.Label3.Name = "Label3"
			Dim label8 As Global.System.Windows.Forms.Control = Me.Label3
			size = New Global.System.Drawing.Size(39, 13)
			label8.Size = size
			Me.Label3.TabIndex = 8
			Me.Label3.Text = "Z (mm)"
			Me.Label2.AutoSize = True
			Dim label9 As Global.System.Windows.Forms.Control = Me.Label2
			location = New Global.System.Drawing.Point(139, 28)
			label9.Location = location
			Me.Label2.Name = "Label2"
			Dim label10 As Global.System.Windows.Forms.Control = Me.Label2
			size = New Global.System.Drawing.Size(39, 13)
			label10.Size = size
			Me.Label2.TabIndex = 8
			Me.Label2.Text = "Y (mm)"
			Me.Label1.AutoSize = True
			Dim label11 As Global.System.Windows.Forms.Control = Me.Label1
			location = New Global.System.Drawing.Point(44, 28)
			label11.Location = location
			Me.Label1.Name = "Label1"
			Dim label12 As Global.System.Windows.Forms.Control = Me.Label1
			size = New Global.System.Drawing.Size(39, 13)
			label12.Size = size
			Me.Label1.TabIndex = 7
			Me.Label1.Text = "X (mm)"
			Me.Rzpostxt.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 9.75F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 161)
			Dim rzpostxt As Global.System.Windows.Forms.Control = Me.Rzpostxt
			location = New Global.System.Drawing.Point(506, 44)
			rzpostxt.Location = location
			Me.Rzpostxt.Name = "Rzpostxt"
			Dim rzpostxt2 As Global.System.Windows.Forms.Control = Me.Rzpostxt
			size = New Global.System.Drawing.Size(75, 22)
			rzpostxt2.Size = size
			Me.Rzpostxt.TabIndex = 6
			Me.Rypostxt.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 9.75F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 161)
			Dim rypostxt As Global.System.Windows.Forms.Control = Me.Rypostxt
			location = New Global.System.Drawing.Point(410, 44)
			rypostxt.Location = location
			Me.Rypostxt.Name = "Rypostxt"
			Dim rypostxt2 As Global.System.Windows.Forms.Control = Me.Rypostxt
			size = New Global.System.Drawing.Size(75, 22)
			rypostxt2.Size = size
			Me.Rypostxt.TabIndex = 5
			Me.Rxpostxt.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 9.75F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 161)
			Dim rxpostxt As Global.System.Windows.Forms.Control = Me.Rxpostxt
			location = New Global.System.Drawing.Point(314, 44)
			rxpostxt.Location = location
			Me.Rxpostxt.Name = "Rxpostxt"
			Dim rxpostxt2 As Global.System.Windows.Forms.Control = Me.Rxpostxt
			size = New Global.System.Drawing.Size(75, 22)
			rxpostxt2.Size = size
			Me.Rxpostxt.TabIndex = 4
			Me.Zpostxt.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 9.75F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 161)
			Dim zpostxt As Global.System.Windows.Forms.Control = Me.Zpostxt
			location = New Global.System.Drawing.Point(218, 44)
			zpostxt.Location = location
			Me.Zpostxt.Name = "Zpostxt"
			Dim zpostxt2 As Global.System.Windows.Forms.Control = Me.Zpostxt
			size = New Global.System.Drawing.Size(75, 22)
			zpostxt2.Size = size
			Me.Zpostxt.TabIndex = 3
			Me.Ypostxt.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 9.75F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 161)
			Dim ypostxt As Global.System.Windows.Forms.Control = Me.Ypostxt
			location = New Global.System.Drawing.Point(122, 44)
			ypostxt.Location = location
			Me.Ypostxt.Name = "Ypostxt"
			Dim ypostxt2 As Global.System.Windows.Forms.Control = Me.Ypostxt
			size = New Global.System.Drawing.Size(75, 22)
			ypostxt2.Size = size
			Me.Ypostxt.TabIndex = 2
			Me.GroupBox2.Controls.Add(Me.Label8)
			Me.GroupBox2.Controls.Add(Me.Label7)
			Me.GroupBox2.Controls.Add(Me.S2postxt)
			Me.GroupBox2.Controls.Add(Me.S1postxt)
			Dim groupBox3 As Global.System.Windows.Forms.Control = Me.GroupBox2
			location = New Global.System.Drawing.Point(163, 240)
			groupBox3.Location = location
			Me.GroupBox2.Name = "GroupBox2"
			Dim groupBox4 As Global.System.Windows.Forms.Control = Me.GroupBox2
			size = New Global.System.Drawing.Size(242, 98)
			groupBox4.Size = size
			Me.GroupBox2.TabIndex = 3
			Me.GroupBox2.TabStop = False
			Me.GroupBox2.Text = "Station Position"
			Me.Label8.AutoSize = True
			Dim label13 As Global.System.Windows.Forms.Control = Me.Label8
			location = New Global.System.Drawing.Point(150, 25)
			label13.Location = location
			Me.Label8.Name = "Label8"
			Dim label14 As Global.System.Windows.Forms.Control = Me.Label8
			size = New Global.System.Drawing.Size(49, 13)
			label14.Size = size
			Me.Label8.TabIndex = 10
			Me.Label8.Text = "S2 (Deg)"
			Me.Label7.AutoSize = True
			Dim label15 As Global.System.Windows.Forms.Control = Me.Label7
			location = New Global.System.Drawing.Point(54, 25)
			label15.Location = location
			Me.Label7.Name = "Label7"
			Dim label16 As Global.System.Windows.Forms.Control = Me.Label7
			size = New Global.System.Drawing.Size(49, 13)
			label16.Size = size
			Me.Label7.TabIndex = 9
			Me.Label7.Text = "S1 (Deg)"
			Me.S2postxt.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 9.75F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 161)
			Dim s2postxt As Global.System.Windows.Forms.Control = Me.S2postxt
			location = New Global.System.Drawing.Point(137, 41)
			s2postxt.Location = location
			Me.S2postxt.Name = "S2postxt"
			Dim s2postxt2 As Global.System.Windows.Forms.Control = Me.S2postxt
			size = New Global.System.Drawing.Size(75, 22)
			s2postxt2.Size = size
			Me.S2postxt.TabIndex = 2
			Me.S1postxt.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 9.75F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 161)
			Dim s1postxt As Global.System.Windows.Forms.Control = Me.S1postxt
			location = New Global.System.Drawing.Point(41, 41)
			s1postxt.Location = location
			Me.S1postxt.Name = "S1postxt"
			Dim s1postxt2 As Global.System.Windows.Forms.Control = Me.S1postxt
			size = New Global.System.Drawing.Size(75, 22)
			s1postxt2.Size = size
			Me.S1postxt.TabIndex = 1
			Me.GroupBox3.Controls.Add(Me.Usrfrmtxt)
			Dim groupBox5 As Global.System.Windows.Forms.Control = Me.GroupBox3
			location = New Global.System.Drawing.Point(328, 32)
			groupBox5.Location = location
			Me.GroupBox3.Name = "GroupBox3"
			Dim groupBox6 As Global.System.Windows.Forms.Control = Me.GroupBox3
			size = New Global.System.Drawing.Size(156, 98)
			groupBox6.Size = size
			Me.GroupBox3.TabIndex = 5
			Me.GroupBox3.TabStop = False
			Me.GroupBox3.Text = "User Frame"
			Me.Usrfrmtxt.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 9.75F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 161)
			Dim usrfrmtxt As Global.System.Windows.Forms.Control = Me.Usrfrmtxt
			location = New Global.System.Drawing.Point(41, 41)
			usrfrmtxt.Location = location
			Me.Usrfrmtxt.Name = "Usrfrmtxt"
			Dim usrfrmtxt2 As Global.System.Windows.Forms.Control = Me.Usrfrmtxt
			size = New Global.System.Drawing.Size(75, 22)
			usrfrmtxt2.Size = size
			Me.Usrfrmtxt.TabIndex = 1
			Me.Cnfrm_btn.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 11.25F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 162)
			Dim cnfrm_btn As Global.System.Windows.Forms.Control = Me.Cnfrm_btn
			location = New Global.System.Drawing.Point(583, 634)
			cnfrm_btn.Location = location
			Me.Cnfrm_btn.Name = "Cnfrm_btn"
			Dim cnfrm_btn2 As Global.System.Windows.Forms.Control = Me.Cnfrm_btn
			size = New Global.System.Drawing.Size(87, 27)
			cnfrm_btn2.Size = size
			Me.Cnfrm_btn.TabIndex = 4
			Me.Cnfrm_btn.Text = "Confirm"
			Me.Cnfrm_btn.UseVisualStyleBackColor = True
			Me.Cncl_btn.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 11.25F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 162)
			Dim cncl_btn As Global.System.Windows.Forms.Control = Me.Cncl_btn
			location = New Global.System.Drawing.Point(676, 634)
			cncl_btn.Location = location
			Me.Cncl_btn.Name = "Cncl_btn"
			Dim cncl_btn2 As Global.System.Windows.Forms.Control = Me.Cncl_btn
			size = New Global.System.Drawing.Size(87, 27)
			cncl_btn2.Size = size
			Me.Cncl_btn.TabIndex = 5
			Me.Cncl_btn.Text = "Cancel"
			Me.Cncl_btn.UseVisualStyleBackColor = True
			Me.Upload_btn.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 11.25F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 162)
			Dim upload_btn As Global.System.Windows.Forms.Control = Me.Upload_btn
			location = New Global.System.Drawing.Point(369, 360)
			upload_btn.Location = location
			Me.Upload_btn.Name = "Upload_btn"
			Dim upload_btn2 As Global.System.Windows.Forms.Control = Me.Upload_btn
			size = New Global.System.Drawing.Size(87, 27)
			upload_btn2.Size = size
			Me.Upload_btn.TabIndex = 3
			Me.Upload_btn.Text = "Upload"
			Me.Upload_btn.UseVisualStyleBackColor = True
			DataGridViewCellStyle.BackColor = Global.System.Drawing.Color.FromArgb(224, 224, 224)
			Me.GridView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle
			Me.GridView.AutoSizeColumnsMode = Global.System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
			Me.GridView.CausesValidation = False
			Me.GridView.ColumnHeadersHeightSizeMode = Global.System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
			DataGridViewCellStyle2.Alignment = Global.System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
			DataGridViewCellStyle2.BackColor = Global.System.Drawing.SystemColors.Window
			DataGridViewCellStyle2.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 161)
			DataGridViewCellStyle2.ForeColor = Global.System.Drawing.SystemColors.ControlText
			DataGridViewCellStyle2.Format = "N3"
			DataGridViewCellStyle2.NullValue = Nothing
			DataGridViewCellStyle2.SelectionBackColor = Global.System.Drawing.SystemColors.Highlight
			DataGridViewCellStyle2.SelectionForeColor = Global.System.Drawing.SystemColors.HighlightText
			DataGridViewCellStyle2.WrapMode = Global.System.Windows.Forms.DataGridViewTriState.[False]
			Me.GridView.DefaultCellStyle = DataGridViewCellStyle2
			Dim gridView As Global.System.Windows.Forms.Control = Me.GridView
			location = New Global.System.Drawing.Point(32, 412)
			gridView.Location = location
			Me.GridView.Name = "GridView"
			Dim gridView2 As Global.System.Windows.Forms.Control = Me.GridView
			size = New Global.System.Drawing.Size(763, 155)
			gridView2.Size = size
			Me.GridView.TabIndex = 6
			Me.Upbutton.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 11.25F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 162)
			Dim upbutton As Global.System.Windows.Forms.Control = Me.Upbutton
			location = New Global.System.Drawing.Point(276, 585)
			upbutton.Location = location
			Me.Upbutton.Name = "Upbutton"
			Dim upbutton2 As Global.System.Windows.Forms.Control = Me.Upbutton
			size = New Global.System.Drawing.Size(87, 27)
			upbutton2.Size = size
			Me.Upbutton.TabIndex = 7
			Me.Upbutton.Text = "Up"
			Me.Upbutton.UseVisualStyleBackColor = True
			Me.Downbutton.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 11.25F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 162)
			Dim downbutton As Global.System.Windows.Forms.Control = Me.Downbutton
			location = New Global.System.Drawing.Point(369, 585)
			downbutton.Location = location
			Me.Downbutton.Name = "Downbutton"
			Dim downbutton2 As Global.System.Windows.Forms.Control = Me.Downbutton
			size = New Global.System.Drawing.Size(87, 27)
			downbutton2.Size = size
			Me.Downbutton.TabIndex = 7
			Me.Downbutton.Text = "Down"
			Me.Downbutton.UseVisualStyleBackColor = True
			Me.Delbutton.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 11.25F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 162)
			Dim delbutton As Global.System.Windows.Forms.Control = Me.Delbutton
			location = New Global.System.Drawing.Point(462, 585)
			delbutton.Location = location
			Me.Delbutton.Name = "Delbutton"
			Dim delbutton2 As Global.System.Windows.Forms.Control = Me.Delbutton
			size = New Global.System.Drawing.Size(87, 27)
			delbutton2.Size = size
			Me.Delbutton.TabIndex = 7
			Me.Delbutton.Text = "Delete"
			Me.Delbutton.UseVisualStyleBackColor = True
			Me.GroupBox4.Controls.Add(Me.ConstBeam)
			Me.GroupBox4.Controls.Add(Me.Label11)
			Me.GroupBox4.Controls.Add(Me.Beamdiatxt)
			Me.GroupBox4.Controls.Add(Me.Label9)
			Me.GroupBox4.Controls.Add(Me.Powertxt)
			Dim groupBox7 As Global.System.Windows.Forms.Control = Me.GroupBox4
			location = New Global.System.Drawing.Point(432, 240)
			groupBox7.Location = location
			Me.GroupBox4.Name = "GroupBox4"
			Dim groupBox8 As Global.System.Windows.Forms.Control = Me.GroupBox4
			size = New Global.System.Drawing.Size(279, 97)
			groupBox8.Size = size
			Me.GroupBox4.TabIndex = 8
			Me.GroupBox4.TabStop = False
			Me.GroupBox4.Text = "Laser Parameters"
			Me.ConstBeam.AutoSize = True
			Dim constBeam As Global.System.Windows.Forms.Control = Me.ConstBeam
			location = New Global.System.Drawing.Point(201, 37)
			constBeam.Location = location
			Me.ConstBeam.Name = "ConstBeam"
			Dim constBeam2 As Global.System.Windows.Forms.Control = Me.ConstBeam
			size = New Global.System.Drawing.Size(78, 30)
			constBeam2.Size = size
			Me.ConstBeam.TabIndex = 13
			Me.ConstBeam.Text = "Constant " & Global.System.Environment.NewLine & "Clad Width"
			Me.ConstBeam.UseVisualStyleBackColor = True
			Me.Label11.AutoSize = True
			Dim label17 As Global.System.Windows.Forms.Control = Me.Label11
			location = New Global.System.Drawing.Point(112, 25)
			label17.Location = location
			Me.Label11.Name = "Label11"
			Dim label18 As Global.System.Windows.Forms.Control = Me.Label11
			size = New Global.System.Drawing.Size(84, 13)
			label18.Size = size
			Me.Label11.TabIndex = 12
			Me.Label11.Text = "Clad Width (mm)"
			Me.Beamdiatxt.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 9.75F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 161)
			Dim beamdiatxt As Global.System.Windows.Forms.Control = Me.Beamdiatxt
			location = New Global.System.Drawing.Point(115, 41)
			beamdiatxt.Location = location
			Me.Beamdiatxt.Name = "Beamdiatxt"
			Dim beamdiatxt2 As Global.System.Windows.Forms.Control = Me.Beamdiatxt
			size = New Global.System.Drawing.Size(75, 22)
			beamdiatxt2.Size = size
			Me.Beamdiatxt.TabIndex = 11
			Me.Label9.AutoSize = True
			Dim label19 As Global.System.Windows.Forms.Control = Me.Label9
			location = New Global.System.Drawing.Point(28, 25)
			label19.Location = location
			Me.Label9.Name = "Label9"
			Dim label20 As Global.System.Windows.Forms.Control = Me.Label9
			size = New Global.System.Drawing.Size(57, 13)
			label20.Size = size
			Me.Label9.TabIndex = 10
			Me.Label9.Text = "Power (W)"
			Me.Powertxt.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 9.75F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 161)
			Dim powertxt As Global.System.Windows.Forms.Control = Me.Powertxt
			location = New Global.System.Drawing.Point(19, 41)
			powertxt.Location = location
			Me.Powertxt.Name = "Powertxt"
			Dim powertxt2 As Global.System.Windows.Forms.Control = Me.Powertxt
			size = New Global.System.Drawing.Size(75, 22)
			powertxt2.Size = size
			Me.Powertxt.TabIndex = 2
			Me.Label10.AutoSize = True
			Me.Label10.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 10F)
			Dim label21 As Global.System.Windows.Forms.Control = Me.Label10
			location = New Global.System.Drawing.Point(29, 392)
			label21.Location = location
			Me.Label10.Name = "Label10"
			Dim label22 As Global.System.Windows.Forms.Control = Me.Label10
			size = New Global.System.Drawing.Size(96, 17)
			label22.Size = size
			Me.Label10.TabIndex = 9
			Me.Label10.Text = "Tought Points"
			Me.MenuStrip1.Items.AddRange(New Global.System.Windows.Forms.ToolStripItem() { Me.ToolStripMenuItem1 })
			Dim menuStrip As Global.System.Windows.Forms.Control = Me.MenuStrip1
			location = New Global.System.Drawing.Point(0, 0)
			menuStrip.Location = location
			Me.MenuStrip1.Name = "MenuStrip1"
			Dim menuStrip2 As Global.System.Windows.Forms.Control = Me.MenuStrip1
			size = New Global.System.Drawing.Size(829, 24)
			menuStrip2.Size = size
			Me.MenuStrip1.TabIndex = 10
			Me.MenuStrip1.Text = "MenuStrip1"
			Me.ToolStripMenuItem1.DropDownItems.AddRange(New Global.System.Windows.Forms.ToolStripItem() { Me.LoadDataFileToolStripMenuItem, Me.SaveDataFileToolStripMenuItem })
			Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
			Dim toolStripMenuItem As Global.System.Windows.Forms.ToolStripItem = Me.ToolStripMenuItem1
			size = New Global.System.Drawing.Size(64, 20)
			toolStripMenuItem.Size = size
			Me.ToolStripMenuItem1.Text = "Data File"
			Me.LoadDataFileToolStripMenuItem.Name = "LoadDataFileToolStripMenuItem"
			Dim loadDataFileToolStripMenuItem As Global.System.Windows.Forms.ToolStripItem = Me.LoadDataFileToolStripMenuItem
			size = New Global.System.Drawing.Size(148, 22)
			loadDataFileToolStripMenuItem.Size = size
			Me.LoadDataFileToolStripMenuItem.Text = "Load Data File"
			Me.SaveDataFileToolStripMenuItem.Name = "SaveDataFileToolStripMenuItem"
			Dim saveDataFileToolStripMenuItem As Global.System.Windows.Forms.ToolStripItem = Me.SaveDataFileToolStripMenuItem
			size = New Global.System.Drawing.Size(148, 22)
			saveDataFileToolStripMenuItem.Size = size
			Me.SaveDataFileToolStripMenuItem.Text = "Save Data File"
			Dim autoScaleDimensions As Global.System.Drawing.SizeF = New Global.System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleDimensions = autoScaleDimensions
			Me.AutoScaleMode = Global.System.Windows.Forms.AutoScaleMode.Font
			size = New Global.System.Drawing.Size(829, 685)
			Me.ClientSize = size
			Me.Controls.Add(Me.Label10)
			Me.Controls.Add(Me.GroupBox4)
			Me.Controls.Add(Me.Delbutton)
			Me.Controls.Add(Me.Downbutton)
			Me.Controls.Add(Me.Upbutton)
			Me.Controls.Add(Me.GridView)
			Me.Controls.Add(Me.Cncl_btn)
			Me.Controls.Add(Me.Cnfrm_btn)
			Me.Controls.Add(Me.GroupBox3)
			Me.Controls.Add(Me.GroupBox2)
			Me.Controls.Add(Me.GroupBox1)
			Me.Controls.Add(Me.Upload_btn)
			Me.Controls.Add(Me.MenuStrip1)
			Me.MainMenuStrip = Me.MenuStrip1
			Me.Name = "MPosıtıonupload"
			Me.Text = "Multiple Posıtıon Upload"
			Me.GroupBox1.ResumeLayout(False)
			Me.GroupBox1.PerformLayout()
			Me.GroupBox2.ResumeLayout(False)
			Me.GroupBox2.PerformLayout()
			Me.GroupBox3.ResumeLayout(False)
			Me.GroupBox3.PerformLayout()
			CType(Me.GridView, Global.System.ComponentModel.ISupportInitialize).EndInit()
			Me.GroupBox4.ResumeLayout(False)
			Me.GroupBox4.PerformLayout()
			Me.MenuStrip1.ResumeLayout(False)
			Me.MenuStrip1.PerformLayout()
			Me.ResumeLayout(False)
			Me.PerformLayout()
		End Sub

		' Token: 0x0400015B RID: 347
		Private components As Global.System.ComponentModel.IContainer
	End Class
End Namespace
