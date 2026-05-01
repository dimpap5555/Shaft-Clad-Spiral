Namespace WindowsApplication1
	' Token: 0x02000012 RID: 18
	<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
	Public Partial Class Miscsettings
		Inherits Global.System.Windows.Forms.Form

		' Token: 0x0600033E RID: 830 RVA: 0x00038A74 File Offset: 0x00036E74
		<Global.System.Diagnostics.DebuggerNonUserCode()>
		Protected Overrides Sub Dispose(disposing As Boolean)
			If disposing AndAlso Me.components IsNot Nothing Then
				Me.components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		' Token: 0x0600033F RID: 831 RVA: 0x00038A94 File Offset: 0x00036E94
		<Global.System.Diagnostics.DebuggerStepThrough()>
		Private Sub InitializeComponent()
			Me.GroupBox2 = New Global.System.Windows.Forms.GroupBox()
			Me.WorkXofftxt = New Global.System.Windows.Forms.TextBox()
			Me.Mindistxt = New Global.System.Windows.Forms.TextBox()
			Me.Horoffsettxt = New Global.System.Windows.Forms.TextBox()
			Me.Idlesptxt = New Global.System.Windows.Forms.TextBox()
			Me.Diamoffsettxt = New Global.System.Windows.Forms.TextBox()
			Me.Approsptxt = New Global.System.Windows.Forms.TextBox()
			Me.Distanceoffsettxt = New Global.System.Windows.Forms.TextBox()
			Me.Cnlbtn = New Global.System.Windows.Forms.Button()
			Me.Cnfrmbtn = New Global.System.Windows.Forms.Button()
			Me.GroupBox1 = New Global.System.Windows.Forms.GroupBox()
			Me.MaxZRobotPostxt = New Global.System.Windows.Forms.TextBox()
			Me.Tiltangtxt = New Global.System.Windows.Forms.TextBox()
			Me.Pprtxt = New Global.System.Windows.Forms.TextBox()
			Me.Powderset1txt = New Global.System.Windows.Forms.TextBox()
			Me.Powderset2txt = New Global.System.Windows.Forms.TextBox()
			Me.Positionleveltxt = New Global.System.Windows.Forms.TextBox()
			Me.GroupBox3 = New Global.System.Windows.Forms.GroupBox()
			Me.Reversedirflg = New Global.System.Windows.Forms.RadioButton()
			Me.Forwarddirflg = New Global.System.Windows.Forms.RadioButton()
			Me.WorkYAxisTilttxt = New Global.System.Windows.Forms.TextBox()
			Me.WorkZAxisYawtxt = New Global.System.Windows.Forms.TextBox()
			Dim Label6 As Global.System.Windows.Forms.Label = New Global.System.Windows.Forms.Label()
			Dim Diamoffsetlab As Global.System.Windows.Forms.Label = New Global.System.Windows.Forms.Label()
			Dim Dialab As Global.System.Windows.Forms.Label = New Global.System.Windows.Forms.Label()
			Dim Heightlab As Global.System.Windows.Forms.Label = New Global.System.Windows.Forms.Label()
			Dim Widthlab As Global.System.Windows.Forms.Label = New Global.System.Windows.Forms.Label()
			Dim Label7 As Global.System.Windows.Forms.Label = New Global.System.Windows.Forms.Label()
			Dim Label8 As Global.System.Windows.Forms.Label = New Global.System.Windows.Forms.Label()
			Dim Label9 As Global.System.Windows.Forms.Label = New Global.System.Windows.Forms.Label()
			Dim Label10 As Global.System.Windows.Forms.Label = New Global.System.Windows.Forms.Label()
			Dim Label11 As Global.System.Windows.Forms.Label = New Global.System.Windows.Forms.Label()
			Dim Label12 As Global.System.Windows.Forms.Label = New Global.System.Windows.Forms.Label()
			Dim Label13 As Global.System.Windows.Forms.Label = New Global.System.Windows.Forms.Label()
			Dim Label14 As Global.System.Windows.Forms.Label = New Global.System.Windows.Forms.Label()
			Dim Label15 As Global.System.Windows.Forms.Label = New Global.System.Windows.Forms.Label()
			Dim Label16 As Global.System.Windows.Forms.Label = New Global.System.Windows.Forms.Label()
			Me.GroupBox2.SuspendLayout()
			Me.GroupBox1.SuspendLayout()
			Me.GroupBox3.SuspendLayout()
			Me.SuspendLayout()
			Label6.AutoSize = True
			Label6.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 12F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 161)
			Dim control As Global.System.Windows.Forms.Control = Label6
			Dim location As Global.System.Drawing.Point = New Global.System.Drawing.Point(31, 217)
			control.Location = location
			Dim control2 As Global.System.Windows.Forms.Control = Label6
			Dim margin As Global.System.Windows.Forms.Padding = New Global.System.Windows.Forms.Padding(4, 0, 4, 0)
			control2.Margin = margin
			Label6.Name = "Label6"
			Dim control3 As Global.System.Windows.Forms.Control = Label6
			Dim size As Global.System.Drawing.Size = New Global.System.Drawing.Size(189, 20)
			control3.Size = size
			Label6.TabIndex = 9
			Label6.Text = "Ini. X Axis Offset (mm)"
			Diamoffsetlab.AutoSize = True
			Diamoffsetlab.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 12F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 161)
			Dim control4 As Global.System.Windows.Forms.Control = Diamoffsetlab
			location = New Global.System.Drawing.Point(32, 171)
			control4.Location = location
			Dim control5 As Global.System.Windows.Forms.Control = Diamoffsetlab
			margin = New Global.System.Windows.Forms.Padding(4, 0, 4, 0)
			control5.Margin = margin
			Diamoffsetlab.Name = "Diamoffsetlab"
			Dim control6 As Global.System.Windows.Forms.Control = Diamoffsetlab
			size = New Global.System.Drawing.Size(188, 20)
			control6.Size = size
			Diamoffsetlab.TabIndex = 7
			Diamoffsetlab.Text = "Ini. Z Axis Offset (mm)"
			Dialab.AutoSize = True
			Dialab.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 12F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 161)
			Dim control7 As Global.System.Windows.Forms.Control = Dialab
			location = New Global.System.Drawing.Point(66, 33)
			control7.Location = location
			Dim control8 As Global.System.Windows.Forms.Control = Dialab
			margin = New Global.System.Windows.Forms.Padding(4, 0, 4, 0)
			control8.Margin = margin
			Dialab.Name = "Dialab"
			Dim control9 As Global.System.Windows.Forms.Control = Dialab
			size = New Global.System.Drawing.Size(155, 20)
			control9.Size = size
			Dialab.TabIndex = 1
			Dialab.Text = "Idle Speed (mm/s)"
			Heightlab.AutoSize = True
			Heightlab.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 12F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 161)
			Dim control10 As Global.System.Windows.Forms.Control = Heightlab
			location = New Global.System.Drawing.Point(30, 125)
			control10.Location = location
			Dim control11 As Global.System.Windows.Forms.Control = Heightlab
			margin = New Global.System.Windows.Forms.Padding(4, 0, 4, 0)
			control11.Margin = margin
			Heightlab.Name = "Heightlab"
			Dim control12 As Global.System.Windows.Forms.Control = Heightlab
			size = New Global.System.Drawing.Size(189, 20)
			control12.Size = size
			Heightlab.TabIndex = 5
			Heightlab.Text = "Ini. Y Axis Offset (mm)"
			Widthlab.AutoSize = True
			Widthlab.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 12F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 161)
			Dim control13 As Global.System.Windows.Forms.Control = Widthlab
			location = New Global.System.Drawing.Point(17, 79)
			control13.Location = location
			Dim control14 As Global.System.Windows.Forms.Control = Widthlab
			margin = New Global.System.Windows.Forms.Padding(4, 0, 4, 0)
			control14.Margin = margin
			Widthlab.Name = "Widthlab"
			Dim control15 As Global.System.Windows.Forms.Control = Widthlab
			size = New Global.System.Drawing.Size(202, 20)
			control15.Size = size
			Widthlab.TabIndex = 3
			Widthlab.Text = "Approach Speed (mm/s)"
			Label7.AutoSize = True
			Label7.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 12F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 161)
			Dim control16 As Global.System.Windows.Forms.Control = Label7
			location = New Global.System.Drawing.Point(2, 33)
			control16.Location = location
			Dim control17 As Global.System.Windows.Forms.Control = Label7
			margin = New Global.System.Windows.Forms.Padding(4, 0, 4, 0)
			control17.Margin = margin
			Label7.Name = "Label3"
			Dim control18 As Global.System.Windows.Forms.Control = Label7
			size = New Global.System.Drawing.Size(219, 20)
			control18.Size = size
			Label7.TabIndex = 1
			Label7.Text = "Powder Settling Time 1 (s)"
			Label8.AutoSize = True
			Label8.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 12F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 161)
			Dim control19 As Global.System.Windows.Forms.Control = Label8
			location = New Global.System.Drawing.Point(98, 125)
			control19.Location = location
			Dim control20 As Global.System.Windows.Forms.Control = Label8
			margin = New Global.System.Windows.Forms.Padding(4, 0, 4, 0)
			control20.Margin = margin
			Label8.Name = "Label4"
			Dim control21 As Global.System.Windows.Forms.Control = Label8
			size = New Global.System.Drawing.Size(120, 20)
			control21.Size = size
			Label8.TabIndex = 5
			Label8.Text = "Position Level"
			Label9.AutoSize = True
			Label9.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 12F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 161)
			Dim control22 As Global.System.Windows.Forms.Control = Label9
			location = New Global.System.Drawing.Point(2, 79)
			control22.Location = location
			Dim control23 As Global.System.Windows.Forms.Control = Label9
			margin = New Global.System.Windows.Forms.Padding(4, 0, 4, 0)
			control23.Margin = margin
			Label9.Name = "Label5"
			Dim control24 As Global.System.Windows.Forms.Control = Label9
			size = New Global.System.Drawing.Size(219, 20)
			control24.Size = size
			Label9.TabIndex = 3
			Label9.Text = "Powder Settling Time 2 (s)"
			Label10.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 12F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 161)
			Dim control25 As Global.System.Windows.Forms.Control = Label10
			location = New Global.System.Drawing.Point(29, 391)
			control25.Location = location
			Dim control26 As Global.System.Windows.Forms.Control = Label10
			margin = New Global.System.Windows.Forms.Padding(4, 0, 4, 0)
			control26.Margin = margin
			Label10.Name = "Label1"
			Dim control27 As Global.System.Windows.Forms.Control = Label10
			size = New Global.System.Drawing.Size(191, 48)
			control27.Size = size
			Label10.TabIndex = 11
			Label10.Text = "Minimum Chuck Distance (mm)"
			Label10.TextAlign = Global.System.Drawing.ContentAlignment.TopRight
			Label11.AutoSize = True
			Label11.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 12F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 161)
			Dim control28 As Global.System.Windows.Forms.Control = Label11
			location = New Global.System.Drawing.Point(16, 262)
			control28.Location = location
			Dim control29 As Global.System.Windows.Forms.Control = Label11
			margin = New Global.System.Windows.Forms.Padding(4, 0, 4, 0)
			control29.Margin = margin
			Label11.Name = "Label2"
			Dim control30 As Global.System.Windows.Forms.Control = Label11
			size = New Global.System.Drawing.Size(205, 20)
			control30.Size = size
			Label11.TabIndex = 13
			Label11.Text = "Work X Axis Offset (mm)"
			Label12.AutoSize = True
			Label12.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 12F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 161)
			Dim control31 As Global.System.Windows.Forms.Control = Label12
			location = New Global.System.Drawing.Point(37, 170)
			control31.Location = location
			Dim control32 As Global.System.Windows.Forms.Control = Label12
			margin = New Global.System.Windows.Forms.Padding(4, 0, 4, 0)
			control32.Margin = margin
			Label12.Name = "Label7"
			Dim control33 As Global.System.Windows.Forms.Control = Label12
			size = New Global.System.Drawing.Size(181, 20)
			control33.Size = size
			Label12.TabIndex = 7
			Label12.Text = "Points Per Revolution"
			Label13.AutoSize = True
			Label13.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 12F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 161)
			Dim control34 As Global.System.Windows.Forms.Control = Label13
			location = New Global.System.Drawing.Point(110, 215)
			control34.Location = location
			Dim control35 As Global.System.Windows.Forms.Control = Label13
			margin = New Global.System.Windows.Forms.Padding(4, 0, 4, 0)
			control35.Margin = margin
			Label13.Name = "Label8"
			Dim control36 As Global.System.Windows.Forms.Control = Label13
			size = New Global.System.Drawing.Size(114, 20)
			control36.Size = size
			Label13.TabIndex = 9
			Label13.Text = "Tiltang Angle"
			Label14.AutoSize = True
			Label14.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 12F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 161)
			Dim control37 As Global.System.Windows.Forms.Control = Label14
			location = New Global.System.Drawing.Point(75, 262)
			control37.Location = location
			Dim control38 As Global.System.Windows.Forms.Control = Label14
			margin = New Global.System.Windows.Forms.Padding(4, 0, 4, 0)
			control38.Margin = margin
			Label14.Name = "Label10"
			Dim control39 As Global.System.Windows.Forms.Control = Label14
			size = New Global.System.Drawing.Size(143, 20)
			control39.Size = size
			Label14.TabIndex = 11
			Label14.Text = "Max Z Axis in RF"
			Me.GroupBox2.Controls.Add(Label16)
			Me.GroupBox2.Controls.Add(Me.WorkZAxisYawtxt)
			Me.GroupBox2.Controls.Add(Label15)
			Me.GroupBox2.Controls.Add(Me.WorkYAxisTilttxt)
			Me.GroupBox2.Controls.Add(Label11)
			Me.GroupBox2.Controls.Add(Me.WorkXofftxt)
			Me.GroupBox2.Controls.Add(Label10)
			Me.GroupBox2.Controls.Add(Me.Mindistxt)
			Me.GroupBox2.Controls.Add(Label6)
			Me.GroupBox2.Controls.Add(Me.Horoffsettxt)
			Me.GroupBox2.Controls.Add(Diamoffsetlab)
			Me.GroupBox2.Controls.Add(Me.Idlesptxt)
			Me.GroupBox2.Controls.Add(Dialab)
			Me.GroupBox2.Controls.Add(Me.Diamoffsettxt)
			Me.GroupBox2.Controls.Add(Me.Approsptxt)
			Me.GroupBox2.Controls.Add(Heightlab)
			Me.GroupBox2.Controls.Add(Widthlab)
			Me.GroupBox2.Controls.Add(Me.Distanceoffsettxt)
			Me.GroupBox2.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 9.75F, Global.System.Drawing.FontStyle.Bold Or Global.System.Drawing.FontStyle.Italic, Global.System.Drawing.GraphicsUnit.Point, 161)
			Dim groupBox As Global.System.Windows.Forms.Control = Me.GroupBox2
			location = New Global.System.Drawing.Point(12, 12)
			groupBox.Location = location
			Me.GroupBox2.Name = "GroupBox2"
			Dim groupBox2 As Global.System.Windows.Forms.Control = Me.GroupBox2
			size = New Global.System.Drawing.Size(307, 443)
			groupBox2.Size = size
			Me.GroupBox2.TabIndex = 16
			Me.GroupBox2.TabStop = False
			Me.GroupBox2.Text = "Basic Geometrical Parameters"
			Me.WorkXofftxt.Font = New Global.System.Drawing.Font("Arial", 12F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 161)
			Dim workXofftxt As Global.System.Windows.Forms.Control = Me.WorkXofftxt
			location = New Global.System.Drawing.Point(221, 261)
			workXofftxt.Location = location
			Dim workXofftxt2 As Global.System.Windows.Forms.Control = Me.WorkXofftxt
			margin = New Global.System.Windows.Forms.Padding(4, 5, 4, 5)
			workXofftxt2.Margin = margin
			Me.WorkXofftxt.Name = "WorkXofftxt"
			Dim workXofftxt3 As Global.System.Windows.Forms.Control = Me.WorkXofftxt
			size = New Global.System.Drawing.Size(60, 26)
			workXofftxt3.Size = size
			Me.WorkXofftxt.TabIndex = 5
			Me.WorkXofftxt.Text = "-5.00"
			Me.WorkXofftxt.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
			Me.Mindistxt.Font = New Global.System.Drawing.Font("Arial", 12F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 161)
			Dim mindistxt As Global.System.Windows.Forms.Control = Me.Mindistxt
			location = New Global.System.Drawing.Point(221, 397)
			mindistxt.Location = location
			Dim mindistxt2 As Global.System.Windows.Forms.Control = Me.Mindistxt
			margin = New Global.System.Windows.Forms.Padding(4, 5, 4, 5)
			mindistxt2.Margin = margin
			Me.Mindistxt.Name = "Mindistxt"
			Dim mindistxt3 As Global.System.Windows.Forms.Control = Me.Mindistxt
			size = New Global.System.Drawing.Size(60, 26)
			mindistxt3.Size = size
			Me.Mindistxt.TabIndex = 7
			Me.Mindistxt.Text = "40.00"
			Me.Mindistxt.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
			Me.Horoffsettxt.Font = New Global.System.Drawing.Font("Arial", 12F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 161)
			Dim horoffsettxt As Global.System.Windows.Forms.Control = Me.Horoffsettxt
			location = New Global.System.Drawing.Point(221, 215)
			horoffsettxt.Location = location
			Dim horoffsettxt2 As Global.System.Windows.Forms.Control = Me.Horoffsettxt
			margin = New Global.System.Windows.Forms.Padding(4, 5, 4, 5)
			horoffsettxt2.Margin = margin
			Me.Horoffsettxt.Name = "Horoffsettxt"
			Dim horoffsettxt3 As Global.System.Windows.Forms.Control = Me.Horoffsettxt
			size = New Global.System.Drawing.Size(60, 26)
			horoffsettxt3.Size = size
			Me.Horoffsettxt.TabIndex = 4
			Me.Horoffsettxt.Text = "0.00"
			Me.Horoffsettxt.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
			Me.Idlesptxt.Font = New Global.System.Drawing.Font("Arial", 12F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 161)
			Dim idlesptxt As Global.System.Windows.Forms.Control = Me.Idlesptxt
			location = New Global.System.Drawing.Point(221, 31)
			idlesptxt.Location = location
			Dim idlesptxt2 As Global.System.Windows.Forms.Control = Me.Idlesptxt
			margin = New Global.System.Windows.Forms.Padding(4, 5, 4, 5)
			idlesptxt2.Margin = margin
			Me.Idlesptxt.Name = "Idlesptxt"
			Dim idlesptxt3 As Global.System.Windows.Forms.Control = Me.Idlesptxt
			size = New Global.System.Drawing.Size(60, 26)
			idlesptxt3.Size = size
			Me.Idlesptxt.TabIndex = 0
			Me.Idlesptxt.Text = "50.0"
			Me.Idlesptxt.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
			Me.Diamoffsettxt.Font = New Global.System.Drawing.Font("Arial", 12F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 161)
			Dim diamoffsettxt As Global.System.Windows.Forms.Control = Me.Diamoffsettxt
			location = New Global.System.Drawing.Point(221, 169)
			diamoffsettxt.Location = location
			Dim diamoffsettxt2 As Global.System.Windows.Forms.Control = Me.Diamoffsettxt
			margin = New Global.System.Windows.Forms.Padding(4, 5, 4, 5)
			diamoffsettxt2.Margin = margin
			Me.Diamoffsettxt.Name = "Diamoffsettxt"
			Dim diamoffsettxt3 As Global.System.Windows.Forms.Control = Me.Diamoffsettxt
			size = New Global.System.Drawing.Size(60, 26)
			diamoffsettxt3.Size = size
			Me.Diamoffsettxt.TabIndex = 3
			Me.Diamoffsettxt.Text = "300.00"
			Me.Diamoffsettxt.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
			Me.Approsptxt.Font = New Global.System.Drawing.Font("Arial", 12F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 161)
			Dim approsptxt As Global.System.Windows.Forms.Control = Me.Approsptxt
			location = New Global.System.Drawing.Point(221, 77)
			approsptxt.Location = location
			Dim approsptxt2 As Global.System.Windows.Forms.Control = Me.Approsptxt
			margin = New Global.System.Windows.Forms.Padding(4, 5, 4, 5)
			approsptxt2.Margin = margin
			Me.Approsptxt.Name = "Approsptxt"
			Dim approsptxt3 As Global.System.Windows.Forms.Control = Me.Approsptxt
			size = New Global.System.Drawing.Size(60, 26)
			approsptxt3.Size = size
			Me.Approsptxt.TabIndex = 1
			Me.Approsptxt.Text = "15.0"
			Me.Approsptxt.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
			Me.Distanceoffsettxt.Font = New Global.System.Drawing.Font("Arial", 12F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 161)
			Dim distanceoffsettxt As Global.System.Windows.Forms.Control = Me.Distanceoffsettxt
			location = New Global.System.Drawing.Point(221, 123)
			distanceoffsettxt.Location = location
			Dim distanceoffsettxt2 As Global.System.Windows.Forms.Control = Me.Distanceoffsettxt
			margin = New Global.System.Windows.Forms.Padding(4, 5, 4, 5)
			distanceoffsettxt2.Margin = margin
			Me.Distanceoffsettxt.Name = "Distanceoffsettxt"
			Dim distanceoffsettxt3 As Global.System.Windows.Forms.Control = Me.Distanceoffsettxt
			size = New Global.System.Drawing.Size(60, 26)
			distanceoffsettxt3.Size = size
			Me.Distanceoffsettxt.TabIndex = 2
			Me.Distanceoffsettxt.Text = "200.00"
			Me.Distanceoffsettxt.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
			Me.Cnlbtn.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 11.25F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 161)
			Dim cnlbtn As Global.System.Windows.Forms.Control = Me.Cnlbtn
			location = New Global.System.Drawing.Point(552, 429)
			cnlbtn.Location = location
			Me.Cnlbtn.Name = "Cnlbtn"
			Dim cnlbtn2 As Global.System.Windows.Forms.Control = Me.Cnlbtn
			size = New Global.System.Drawing.Size(85, 26)
			cnlbtn2.Size = size
			Me.Cnlbtn.TabIndex = 2
			Me.Cnlbtn.Text = "Cancel"
			Me.Cnlbtn.TextAlign = Global.System.Drawing.ContentAlignment.TopCenter
			Me.Cnlbtn.UseVisualStyleBackColor = True
			Me.Cnfrmbtn.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 11.25F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 161)
			Dim cnfrmbtn As Global.System.Windows.Forms.Control = Me.Cnfrmbtn
			location = New Global.System.Drawing.Point(427, 429)
			cnfrmbtn.Location = location
			Me.Cnfrmbtn.Name = "Cnfrmbtn"
			Dim cnfrmbtn2 As Global.System.Windows.Forms.Control = Me.Cnfrmbtn
			size = New Global.System.Drawing.Size(85, 26)
			cnfrmbtn2.Size = size
			Me.Cnfrmbtn.TabIndex = 1
			Me.Cnfrmbtn.Text = "Confirm"
			Me.Cnfrmbtn.TextAlign = Global.System.Drawing.ContentAlignment.TopCenter
			Me.Cnfrmbtn.UseVisualStyleBackColor = True
			Me.GroupBox1.Controls.Add(Label14)
			Me.GroupBox1.Controls.Add(Me.MaxZRobotPostxt)
			Me.GroupBox1.Controls.Add(Label13)
			Me.GroupBox1.Controls.Add(Me.Tiltangtxt)
			Me.GroupBox1.Controls.Add(Label12)
			Me.GroupBox1.Controls.Add(Me.Pprtxt)
			Me.GroupBox1.Controls.Add(Me.Powderset1txt)
			Me.GroupBox1.Controls.Add(Label7)
			Me.GroupBox1.Controls.Add(Me.Powderset2txt)
			Me.GroupBox1.Controls.Add(Label8)
			Me.GroupBox1.Controls.Add(Label9)
			Me.GroupBox1.Controls.Add(Me.Positionleveltxt)
			Me.GroupBox1.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 9.75F, Global.System.Drawing.FontStyle.Bold Or Global.System.Drawing.FontStyle.Italic, Global.System.Drawing.GraphicsUnit.Point, 161)
			Dim groupBox3 As Global.System.Windows.Forms.Control = Me.GroupBox1
			location = New Global.System.Drawing.Point(343, 12)
			groupBox3.Location = location
			Me.GroupBox1.Name = "GroupBox1"
			Dim groupBox4 As Global.System.Windows.Forms.Control = Me.GroupBox1
			size = New Global.System.Drawing.Size(307, 300)
			groupBox4.Size = size
			Me.GroupBox1.TabIndex = 20
			Me.GroupBox1.TabStop = False
			Me.GroupBox1.Text = "Other Parameters"
			Me.MaxZRobotPostxt.Font = New Global.System.Drawing.Font("Arial", 12F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 161)
			Dim maxZRobotPostxt As Global.System.Windows.Forms.Control = Me.MaxZRobotPostxt
			location = New Global.System.Drawing.Point(221, 259)
			maxZRobotPostxt.Location = location
			Dim maxZRobotPostxt2 As Global.System.Windows.Forms.Control = Me.MaxZRobotPostxt
			margin = New Global.System.Windows.Forms.Padding(4, 5, 4, 5)
			maxZRobotPostxt2.Margin = margin
			Me.MaxZRobotPostxt.Name = "MaxZRobotPostxt"
			Dim maxZRobotPostxt3 As Global.System.Windows.Forms.Control = Me.MaxZRobotPostxt
			size = New Global.System.Drawing.Size(60, 26)
			maxZRobotPostxt3.Size = size
			Me.MaxZRobotPostxt.TabIndex = 10
			Me.MaxZRobotPostxt.Text = "0.5"
			Me.MaxZRobotPostxt.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
			Me.Tiltangtxt.Font = New Global.System.Drawing.Font("Arial", 12F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 161)
			Dim tiltangtxt As Global.System.Windows.Forms.Control = Me.Tiltangtxt
			location = New Global.System.Drawing.Point(221, 213)
			tiltangtxt.Location = location
			Dim tiltangtxt2 As Global.System.Windows.Forms.Control = Me.Tiltangtxt
			margin = New Global.System.Windows.Forms.Padding(4, 5, 4, 5)
			tiltangtxt2.Margin = margin
			Me.Tiltangtxt.Name = "Tiltangtxt"
			Dim tiltangtxt3 As Global.System.Windows.Forms.Control = Me.Tiltangtxt
			size = New Global.System.Drawing.Size(60, 26)
			tiltangtxt3.Size = size
			Me.Tiltangtxt.TabIndex = 4
			Me.Tiltangtxt.Text = "0.5"
			Me.Tiltangtxt.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
			Me.Pprtxt.Font = New Global.System.Drawing.Font("Arial", 12F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 161)
			Dim pprtxt As Global.System.Windows.Forms.Control = Me.Pprtxt
			location = New Global.System.Drawing.Point(221, 168)
			pprtxt.Location = location
			Dim pprtxt2 As Global.System.Windows.Forms.Control = Me.Pprtxt
			margin = New Global.System.Windows.Forms.Padding(4, 5, 4, 5)
			pprtxt2.Margin = margin
			Me.Pprtxt.Name = "Pprtxt"
			Dim pprtxt3 As Global.System.Windows.Forms.Control = Me.Pprtxt
			size = New Global.System.Drawing.Size(60, 26)
			pprtxt3.Size = size
			Me.Pprtxt.TabIndex = 3
			Me.Pprtxt.Text = "4"
			Me.Pprtxt.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
			Me.Powderset1txt.Font = New Global.System.Drawing.Font("Arial", 12F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 161)
			Dim powderset1txt As Global.System.Windows.Forms.Control = Me.Powderset1txt
			location = New Global.System.Drawing.Point(221, 31)
			powderset1txt.Location = location
			Dim powderset1txt2 As Global.System.Windows.Forms.Control = Me.Powderset1txt
			margin = New Global.System.Windows.Forms.Padding(4, 5, 4, 5)
			powderset1txt2.Margin = margin
			Me.Powderset1txt.Name = "Powderset1txt"
			Dim powderset1txt3 As Global.System.Windows.Forms.Control = Me.Powderset1txt
			size = New Global.System.Drawing.Size(60, 26)
			powderset1txt3.Size = size
			Me.Powderset1txt.TabIndex = 0
			Me.Powderset1txt.Text = "10.00"
			Me.Powderset1txt.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
			Me.Powderset2txt.Font = New Global.System.Drawing.Font("Arial", 12F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 161)
			Dim powderset2txt As Global.System.Windows.Forms.Control = Me.Powderset2txt
			location = New Global.System.Drawing.Point(221, 77)
			powderset2txt.Location = location
			Dim powderset2txt2 As Global.System.Windows.Forms.Control = Me.Powderset2txt
			margin = New Global.System.Windows.Forms.Padding(4, 5, 4, 5)
			powderset2txt2.Margin = margin
			Me.Powderset2txt.Name = "Powderset2txt"
			Dim powderset2txt3 As Global.System.Windows.Forms.Control = Me.Powderset2txt
			size = New Global.System.Drawing.Size(60, 26)
			powderset2txt3.Size = size
			Me.Powderset2txt.TabIndex = 1
			Me.Powderset2txt.Text = "1.00"
			Me.Powderset2txt.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
			Me.Positionleveltxt.Font = New Global.System.Drawing.Font("Arial", 12F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 161)
			Dim positionleveltxt As Global.System.Windows.Forms.Control = Me.Positionleveltxt
			location = New Global.System.Drawing.Point(221, 123)
			positionleveltxt.Location = location
			Dim positionleveltxt2 As Global.System.Windows.Forms.Control = Me.Positionleveltxt
			margin = New Global.System.Windows.Forms.Padding(4, 5, 4, 5)
			positionleveltxt2.Margin = margin
			Me.Positionleveltxt.Name = "Positionleveltxt"
			Dim positionleveltxt3 As Global.System.Windows.Forms.Control = Me.Positionleveltxt
			size = New Global.System.Drawing.Size(60, 26)
			positionleveltxt3.Size = size
			Me.Positionleveltxt.TabIndex = 2
			Me.Positionleveltxt.Text = "2"
			Me.Positionleveltxt.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
			Me.GroupBox3.Controls.Add(Me.Reversedirflg)
			Me.GroupBox3.Controls.Add(Me.Forwarddirflg)
			Me.GroupBox3.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 9.75F, Global.System.Drawing.FontStyle.Bold Or Global.System.Drawing.FontStyle.Italic, Global.System.Drawing.GraphicsUnit.Point, 161)
			Dim groupBox5 As Global.System.Windows.Forms.Control = Me.GroupBox3
			location = New Global.System.Drawing.Point(344, 319)
			groupBox5.Location = location
			Me.GroupBox3.Name = "GroupBox3"
			Dim groupBox6 As Global.System.Windows.Forms.Control = Me.GroupBox3
			size = New Global.System.Drawing.Size(306, 75)
			groupBox6.Size = size
			Me.GroupBox3.TabIndex = 0
			Me.GroupBox3.TabStop = False
			Me.GroupBox3.Text = "Rotation Direction"
			Me.Reversedirflg.AutoSize = True
			Dim reversedirflg As Global.System.Windows.Forms.Control = Me.Reversedirflg
			location = New Global.System.Drawing.Point(196, 31)
			reversedirflg.Location = location
			Me.Reversedirflg.Name = "Reversedirflg"
			Dim reversedirflg2 As Global.System.Windows.Forms.Control = Me.Reversedirflg
			size = New Global.System.Drawing.Size(85, 20)
			reversedirflg2.Size = size
			Me.Reversedirflg.TabIndex = 1
			Me.Reversedirflg.Text = "Reverse"
			Me.Reversedirflg.UseVisualStyleBackColor = True
			Me.Forwarddirflg.AutoSize = True
			Me.Forwarddirflg.Checked = True
			Dim forwarddirflg As Global.System.Windows.Forms.Control = Me.Forwarddirflg
			location = New Global.System.Drawing.Point(47, 32)
			forwarddirflg.Location = location
			Me.Forwarddirflg.Name = "Forwarddirflg"
			Dim forwarddirflg2 As Global.System.Windows.Forms.Control = Me.Forwarddirflg
			size = New Global.System.Drawing.Size(82, 20)
			forwarddirflg2.Size = size
			Me.Forwarddirflg.TabIndex = 0
			Me.Forwarddirflg.TabStop = True
			Me.Forwarddirflg.Text = "Forward"
			Me.Forwarddirflg.UseVisualStyleBackColor = True
			Me.WorkYAxisTilttxt.Font = New Global.System.Drawing.Font("Arial", 12F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 161)
			Dim workYAxisTilttxt As Global.System.Windows.Forms.Control = Me.WorkYAxisTilttxt
			location = New Global.System.Drawing.Point(221, 307)
			workYAxisTilttxt.Location = location
			Dim workYAxisTilttxt2 As Global.System.Windows.Forms.Control = Me.WorkYAxisTilttxt
			margin = New Global.System.Windows.Forms.Padding(4, 5, 4, 5)
			workYAxisTilttxt2.Margin = margin
			Me.WorkYAxisTilttxt.Name = "WorkYAxisTilttxt"
			Dim workYAxisTilttxt3 As Global.System.Windows.Forms.Control = Me.WorkYAxisTilttxt
			size = New Global.System.Drawing.Size(60, 26)
			workYAxisTilttxt3.Size = size
			Me.WorkYAxisTilttxt.TabIndex = 6
			Me.WorkYAxisTilttxt.Text = "0.00"
			Me.WorkYAxisTilttxt.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
			Label15.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 12F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 161)
			Dim control40 As Global.System.Windows.Forms.Control = Label15
			location = New Global.System.Drawing.Point(28, 299)
			control40.Location = location
			Dim control41 As Global.System.Windows.Forms.Control = Label15
			margin = New Global.System.Windows.Forms.Padding(4, 0, 4, 0)
			control41.Margin = margin
			Label15.Name = "Label9"
			Dim control42 As Global.System.Windows.Forms.Control = Label15
			size = New Global.System.Drawing.Size(191, 48)
			control42.Size = size
			Label15.TabIndex = 15
			Label15.Text = "Work Y Axis Tilt Angle (Deg to Vertical)"
			Label15.TextAlign = Global.System.Drawing.ContentAlignment.TopRight
			Label16.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 12F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 161)
			Dim control43 As Global.System.Windows.Forms.Control = Label16
			location = New Global.System.Drawing.Point(20, 345)
			control43.Location = location
			Dim control44 As Global.System.Windows.Forms.Control = Label16
			margin = New Global.System.Windows.Forms.Padding(4, 0, 4, 0)
			control44.Margin = margin
			Label16.Name = "Label11"
			Dim control45 As Global.System.Windows.Forms.Control = Label16
			size = New Global.System.Drawing.Size(199, 48)
			control45.Size = size
			Label16.TabIndex = 17
			Label16.Text = "Work Z Axis Yaw Angle (Deg to ZY Plane)"
			Label16.TextAlign = Global.System.Drawing.ContentAlignment.TopRight
			Me.WorkZAxisYawtxt.Font = New Global.System.Drawing.Font("Arial", 12F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 161)
			Dim workZAxisYawtxt As Global.System.Windows.Forms.Control = Me.WorkZAxisYawtxt
			location = New Global.System.Drawing.Point(221, 353)
			workZAxisYawtxt.Location = location
			Dim workZAxisYawtxt2 As Global.System.Windows.Forms.Control = Me.WorkZAxisYawtxt
			margin = New Global.System.Windows.Forms.Padding(4, 5, 4, 5)
			workZAxisYawtxt2.Margin = margin
			Me.WorkZAxisYawtxt.Name = "WorkZAxisYawtxt"
			Dim workZAxisYawtxt3 As Global.System.Windows.Forms.Control = Me.WorkZAxisYawtxt
			size = New Global.System.Drawing.Size(60, 26)
			workZAxisYawtxt3.Size = size
			Me.WorkZAxisYawtxt.TabIndex = 16
			Me.WorkZAxisYawtxt.Text = "0.00"
			Me.WorkZAxisYawtxt.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
			Dim autoScaleDimensions As Global.System.Drawing.SizeF = New Global.System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleDimensions = autoScaleDimensions
			Me.AutoScaleMode = Global.System.Windows.Forms.AutoScaleMode.Font
			size = New Global.System.Drawing.Size(662, 483)
			Me.ClientSize = size
			Me.Controls.Add(Me.GroupBox3)
			Me.Controls.Add(Me.GroupBox1)
			Me.Controls.Add(Me.Cnlbtn)
			Me.Controls.Add(Me.GroupBox2)
			Me.Controls.Add(Me.Cnfrmbtn)
			Me.FormBorderStyle = Global.System.Windows.Forms.FormBorderStyle.FixedDialog
			Me.MaximizeBox = False
			Me.MinimizeBox = False
			Me.Name = "Miscsettings"
			Me.ShowInTaskbar = False
			Me.StartPosition = Global.System.Windows.Forms.FormStartPosition.CenterParent
			Me.Text = "Miscelaneous Settings"
			Me.GroupBox2.ResumeLayout(False)
			Me.GroupBox2.PerformLayout()
			Me.GroupBox1.ResumeLayout(False)
			Me.GroupBox1.PerformLayout()
			Me.GroupBox3.ResumeLayout(False)
			Me.GroupBox3.PerformLayout()
			Me.ResumeLayout(False)
		End Sub

		' Token: 0x0400013D RID: 317
		Private components As Global.System.ComponentModel.IContainer
	End Class
End Namespace
