Namespace WindowsApplication1
	' Token: 0x02000024 RID: 36
	<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
	Public Partial Class VPARAM
		Inherits Global.System.Windows.Forms.Form

		' Token: 0x06000643 RID: 1603 RVA: 0x000506D8 File Offset: 0x0004EAD8
		<Global.System.Diagnostics.DebuggerNonUserCode()>
		Protected Overrides Sub Dispose(disposing As Boolean)
			If disposing AndAlso Me.components IsNot Nothing Then
				Me.components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		' Token: 0x06000644 RID: 1604 RVA: 0x000506F8 File Offset: 0x0004EAF8
		<Global.System.Diagnostics.DebuggerStepThrough()>
		Private Sub InitializeComponent()
			Me.Diatxt = New Global.System.Windows.Forms.TextBox()
			Me.Widthtxt = New Global.System.Windows.Forms.TextBox()
			Me.Distxt = New Global.System.Windows.Forms.TextBox()
			Me.Pittxt = New Global.System.Windows.Forms.TextBox()
			Me.GroupBox2 = New Global.System.Windows.Forms.GroupBox()
			Me.Tooloffsettxt = New Global.System.Windows.Forms.TextBox()
			Me.Cnfrmbtn = New Global.System.Windows.Forms.Button()
			Me.Cnlbtn = New Global.System.Windows.Forms.Button()
			Me.GroupBox3 = New Global.System.Windows.Forms.GroupBox()
			Me.CurrPosStat = New Global.System.Windows.Forms.CheckBox()
			Me.Conatxt = New Global.System.Windows.Forms.TextBox()
			Me.Finoverwtxt = New Global.System.Windows.Forms.TextBox()
			Me.Stationslct = New Global.System.Windows.Forms.ListBox()
			Me.Initang = New Global.System.Windows.Forms.TextBox()
			Me.Meandrptc = New Global.System.Windows.Forms.TextBox()
			Me.Meandrflg = New Global.System.Windows.Forms.CheckBox()
			Me.Postatxt = New Global.System.Windows.Forms.TextBox()
			Me.Meandramp = New Global.System.Windows.Forms.TextBox()
			Me.Inioverwtxt = New Global.System.Windows.Forms.TextBox()
			Me.GroupBox4 = New Global.System.Windows.Forms.GroupBox()
			Me.Vlvspind = New Global.System.Windows.Forms.RadioButton()
			Me.Vlvseat = New Global.System.Windows.Forms.RadioButton()
			Me.GroupBox1 = New Global.System.Windows.Forms.GroupBox()
			Me.Rightdirflg = New Global.System.Windows.Forms.RadioButton()
			Me.Leftdirflg = New Global.System.Windows.Forms.RadioButton()
			Me.GroupBox5 = New Global.System.Windows.Forms.GroupBox()
			Me.WD_13 = New Global.System.Windows.Forms.RadioButton()
			Me.WD_20 = New Global.System.Windows.Forms.RadioButton()
			Dim Dialab As Global.System.Windows.Forms.Label = New Global.System.Windows.Forms.Label()
			Dim Widthlab As Global.System.Windows.Forms.Label = New Global.System.Windows.Forms.Label()
			Dim Dislab As Global.System.Windows.Forms.Label = New Global.System.Windows.Forms.Label()
			Dim Pitlab As Global.System.Windows.Forms.Label = New Global.System.Windows.Forms.Label()
			Dim Label As Global.System.Windows.Forms.Label = New Global.System.Windows.Forms.Label()
			Dim Label2 As Global.System.Windows.Forms.Label = New Global.System.Windows.Forms.Label()
			Dim Label3 As Global.System.Windows.Forms.Label = New Global.System.Windows.Forms.Label()
			Dim Label4 As Global.System.Windows.Forms.Label = New Global.System.Windows.Forms.Label()
			Dim Label5 As Global.System.Windows.Forms.Label = New Global.System.Windows.Forms.Label()
			Dim Label6 As Global.System.Windows.Forms.Label = New Global.System.Windows.Forms.Label()
			Dim Label7 As Global.System.Windows.Forms.Label = New Global.System.Windows.Forms.Label()
			Dim Label8 As Global.System.Windows.Forms.Label = New Global.System.Windows.Forms.Label()
			Dim Label9 As Global.System.Windows.Forms.Label = New Global.System.Windows.Forms.Label()
			Me.GroupBox2.SuspendLayout()
			Me.GroupBox3.SuspendLayout()
			Me.GroupBox4.SuspendLayout()
			Me.GroupBox1.SuspendLayout()
			Me.GroupBox5.SuspendLayout()
			Me.SuspendLayout()
			Dialab.AutoSize = True
			Dialab.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 12F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 161)
			Dim control As Global.System.Windows.Forms.Control = Dialab
			Dim location As Global.System.Drawing.Point = New Global.System.Drawing.Point(42, 31)
			control.Location = location
			Dim control2 As Global.System.Windows.Forms.Control = Dialab
			Dim margin As Global.System.Windows.Forms.Padding = New Global.System.Windows.Forms.Padding(4, 0, 4, 0)
			control2.Margin = margin
			Dialab.Name = "Dialab"
			Dim control3 As Global.System.Windows.Forms.Control = Dialab
			Dim size As Global.System.Drawing.Size = New Global.System.Drawing.Size(127, 20)
			control3.Size = size
			Dialab.TabIndex = 1
			Dialab.Text = "Diameter (mm)"
			Widthlab.AutoSize = True
			Widthlab.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 12F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 161)
			Dim control4 As Global.System.Windows.Forms.Control = Widthlab
			location = New Global.System.Drawing.Point(69, 77)
			control4.Location = location
			Dim control5 As Global.System.Windows.Forms.Control = Widthlab
			margin = New Global.System.Windows.Forms.Padding(4, 0, 4, 0)
			control5.Margin = margin
			Widthlab.Name = "Widthlab"
			Dim control6 As Global.System.Windows.Forms.Control = Widthlab
			size = New Global.System.Drawing.Size(100, 20)
			control6.Size = size
			Widthlab.TabIndex = 3
			Widthlab.Text = "Width (mm)"
			Dislab.AutoSize = True
			Dislab.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 12F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 161)
			Dim control7 As Global.System.Windows.Forms.Control = Dislab
			location = New Global.System.Drawing.Point(44, 123)
			control7.Location = location
			Dim control8 As Global.System.Windows.Forms.Control = Dislab
			margin = New Global.System.Windows.Forms.Padding(4, 0, 4, 0)
			control8.Margin = margin
			Dislab.Name = "Dislab"
			Dim control9 As Global.System.Windows.Forms.Control = Dislab
			size = New Global.System.Drawing.Size(125, 20)
			control9.Size = size
			Dislab.TabIndex = 5
			Dislab.Text = "Distance (mm)"
			Pitlab.AutoSize = True
			Pitlab.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 12F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 161)
			Dim control10 As Global.System.Windows.Forms.Control = Pitlab
			location = New Global.System.Drawing.Point(75, 169)
			control10.Location = location
			Dim control11 As Global.System.Windows.Forms.Control = Pitlab
			margin = New Global.System.Windows.Forms.Padding(4, 0, 4, 0)
			control11.Margin = margin
			Pitlab.Name = "Pitlab"
			Dim control12 As Global.System.Windows.Forms.Control = Pitlab
			size = New Global.System.Drawing.Size(94, 20)
			control12.Size = size
			Pitlab.TabIndex = 7
			Pitlab.Text = "Pitch (mm)"
			Label.AutoSize = True
			Label.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 12F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 161)
			Dim control13 As Global.System.Windows.Forms.Control = Label
			location = New Global.System.Drawing.Point(4, 253)
			control13.Location = location
			Dim control14 As Global.System.Windows.Forms.Control = Label
			margin = New Global.System.Windows.Forms.Padding(4, 0, 4, 0)
			control14.Margin = margin
			Label.Name = "Label1"
			Dim control15 As Global.System.Windows.Forms.Control = Label
			size = New Global.System.Drawing.Size(165, 20)
			control15.Size = size
			Label.TabIndex = 7
			Label.Text = "Meander Amp (mm)"
			Label2.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 12F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 161)
			Dim control16 As Global.System.Windows.Forms.Control = Label2
			location = New Global.System.Drawing.Point(7, 21)
			control16.Location = location
			Dim control17 As Global.System.Windows.Forms.Control = Label2
			margin = New Global.System.Windows.Forms.Padding(4, 0, 4, 0)
			control17.Margin = margin
			Label2.Name = "Label2"
			Dim control18 As Global.System.Windows.Forms.Control = Label2
			size = New Global.System.Drawing.Size(162, 40)
			control18.Size = size
			Label2.TabIndex = 1
			Label2.Text = "Posture Angle (Deg to axis)"
			Label2.TextAlign = Global.System.Drawing.ContentAlignment.MiddleCenter
			Label3.AutoSize = True
			Label3.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 12F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 161)
			Dim control19 As Global.System.Windows.Forms.Control = Label3
			location = New Global.System.Drawing.Point(25, 164)
			control19.Location = location
			Dim control20 As Global.System.Windows.Forms.Control = Label3
			margin = New Global.System.Windows.Forms.Padding(4, 0, 4, 0)
			control20.Margin = margin
			Label3.Name = "Label3"
			Dim control21 As Global.System.Windows.Forms.Control = Label3
			size = New Global.System.Drawing.Size(144, 20)
			control21.Size = size
			Label3.TabIndex = 5
			Label3.Text = "Ini. Overweld (%)"
			Label4.AutoSize = True
			Label4.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 12F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 161)
			Dim control22 As Global.System.Windows.Forms.Control = Label4
			location = New Global.System.Drawing.Point(4, 118)
			control22.Location = location
			Dim control23 As Global.System.Windows.Forms.Control = Label4
			margin = New Global.System.Windows.Forms.Padding(4, 0, 4, 0)
			control23.Margin = margin
			Label4.Name = "Label4"
			Dim control24 As Global.System.Windows.Forms.Control = Label4
			size = New Global.System.Drawing.Size(168, 20)
			control24.Size = size
			Label4.TabIndex = 3
			Label4.Text = "Station Angle (Deg)"
			Label5.AutoSize = True
			Label5.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 12F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 161)
			Dim control25 As Global.System.Windows.Forms.Control = Label5
			location = New Global.System.Drawing.Point(1, 300)
			control25.Location = location
			Dim control26 As Global.System.Windows.Forms.Control = Label5
			margin = New Global.System.Windows.Forms.Padding(4, 0, 4, 0)
			control26.Margin = margin
			Label5.Name = "Label5"
			Dim control27 As Global.System.Windows.Forms.Control = Label5
			size = New Global.System.Drawing.Size(169, 20)
			control27.Size = size
			Label5.TabIndex = 20
			Label5.Text = "Meander Pitch (mm)"
			Label6.AutoSize = True
			Label6.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 12F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 161)
			Dim control28 As Global.System.Windows.Forms.Control = Label6
			location = New Global.System.Drawing.Point(15, 347)
			control28.Location = location
			Dim control29 As Global.System.Windows.Forms.Control = Label6
			margin = New Global.System.Windows.Forms.Padding(4, 0, 4, 0)
			control29.Margin = margin
			Label6.Name = "Label7"
			Dim control30 As Global.System.Windows.Forms.Control = Label6
			size = New Global.System.Drawing.Size(154, 20)
			control30.Size = size
			Label6.TabIndex = 22
			Label6.Text = "Initial Angle (Deg)"
			Label7.AutoSize = True
			Label7.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 12F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 161)
			Dim control31 As Global.System.Windows.Forms.Control = Label7
			location = New Global.System.Drawing.Point(26, 212)
			control31.Location = location
			Dim control32 As Global.System.Windows.Forms.Control = Label7
			margin = New Global.System.Windows.Forms.Padding(4, 0, 4, 0)
			control32.Margin = margin
			Label7.Name = "Label6"
			Dim control33 As Global.System.Windows.Forms.Control = Label7
			size = New Global.System.Drawing.Size(143, 20)
			control33.Size = size
			Label7.TabIndex = 9
			Label7.Text = "Tool Offset (mm)"
			Label8.AutoSize = True
			Label8.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 12F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 161)
			Dim control34 As Global.System.Windows.Forms.Control = Label8
			location = New Global.System.Drawing.Point(20, 210)
			control34.Location = location
			Dim control35 As Global.System.Windows.Forms.Control = Label8
			margin = New Global.System.Windows.Forms.Padding(4, 0, 4, 0)
			control35.Margin = margin
			Label8.Name = "Label8"
			Dim control36 As Global.System.Windows.Forms.Control = Label8
			size = New Global.System.Drawing.Size(149, 20)
			control36.Size = size
			Label8.TabIndex = 28
			Label8.Text = "Fin. Overweld (%)"
			Label9.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 12F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 161)
			Dim control37 As Global.System.Windows.Forms.Control = Label9
			location = New Global.System.Drawing.Point(7, 65)
			control37.Location = location
			Dim control38 As Global.System.Windows.Forms.Control = Label9
			margin = New Global.System.Windows.Forms.Padding(4, 0, 4, 0)
			control38.Margin = margin
			Label9.Name = "Label9"
			Dim control39 As Global.System.Windows.Forms.Control = Label9
			size = New Global.System.Drawing.Size(162, 40)
			control39.Size = size
			Label9.TabIndex = 30
			Label9.Text = "Cone Angle (Deg to axis)"
			Label9.TextAlign = Global.System.Drawing.ContentAlignment.MiddleCenter
			Me.Diatxt.Font = New Global.System.Drawing.Font("Arial", 12F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 161)
			Dim diatxt As Global.System.Windows.Forms.Control = Me.Diatxt
			location = New Global.System.Drawing.Point(169, 29)
			diatxt.Location = location
			Dim diatxt2 As Global.System.Windows.Forms.Control = Me.Diatxt
			margin = New Global.System.Windows.Forms.Padding(4, 5, 4, 5)
			diatxt2.Margin = margin
			Me.Diatxt.Name = "Diatxt"
			Dim diatxt3 As Global.System.Windows.Forms.Control = Me.Diatxt
			size = New Global.System.Drawing.Size(60, 26)
			diatxt3.Size = size
			Me.Diatxt.TabIndex = 0
			Me.Diatxt.Text = "300.00"
			Me.Diatxt.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
			Me.Widthtxt.Font = New Global.System.Drawing.Font("Arial", 12F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 161)
			Dim widthtxt As Global.System.Windows.Forms.Control = Me.Widthtxt
			location = New Global.System.Drawing.Point(169, 75)
			widthtxt.Location = location
			Dim widthtxt2 As Global.System.Windows.Forms.Control = Me.Widthtxt
			margin = New Global.System.Windows.Forms.Padding(4, 5, 4, 5)
			widthtxt2.Margin = margin
			Me.Widthtxt.Name = "Widthtxt"
			Dim widthtxt3 As Global.System.Windows.Forms.Control = Me.Widthtxt
			size = New Global.System.Drawing.Size(60, 26)
			widthtxt3.Size = size
			Me.Widthtxt.TabIndex = 1
			Me.Widthtxt.Text = "15.00"
			Me.Widthtxt.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
			Me.Distxt.Font = New Global.System.Drawing.Font("Arial", 12F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 161)
			Dim distxt As Global.System.Windows.Forms.Control = Me.Distxt
			location = New Global.System.Drawing.Point(169, 121)
			distxt.Location = location
			Dim distxt2 As Global.System.Windows.Forms.Control = Me.Distxt
			margin = New Global.System.Windows.Forms.Padding(4, 5, 4, 5)
			distxt2.Margin = margin
			Me.Distxt.Name = "Distxt"
			Dim distxt3 As Global.System.Windows.Forms.Control = Me.Distxt
			size = New Global.System.Drawing.Size(60, 26)
			distxt3.Size = size
			Me.Distxt.TabIndex = 2
			Me.Distxt.Text = "200.00"
			Me.Distxt.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
			Me.Pittxt.Font = New Global.System.Drawing.Font("Arial", 12F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 161)
			Dim pittxt As Global.System.Windows.Forms.Control = Me.Pittxt
			location = New Global.System.Drawing.Point(169, 167)
			pittxt.Location = location
			Dim pittxt2 As Global.System.Windows.Forms.Control = Me.Pittxt
			margin = New Global.System.Windows.Forms.Padding(4, 5, 4, 5)
			pittxt2.Margin = margin
			Me.Pittxt.Name = "Pittxt"
			Dim pittxt3 As Global.System.Windows.Forms.Control = Me.Pittxt
			size = New Global.System.Drawing.Size(60, 26)
			pittxt3.Size = size
			Me.Pittxt.TabIndex = 3
			Me.Pittxt.Text = "2.75"
			Me.Pittxt.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
			Me.GroupBox2.Controls.Add(Label7)
			Me.GroupBox2.Controls.Add(Me.Tooloffsettxt)
			Me.GroupBox2.Controls.Add(Pitlab)
			Me.GroupBox2.Controls.Add(Me.Diatxt)
			Me.GroupBox2.Controls.Add(Dialab)
			Me.GroupBox2.Controls.Add(Me.Pittxt)
			Me.GroupBox2.Controls.Add(Me.Widthtxt)
			Me.GroupBox2.Controls.Add(Dislab)
			Me.GroupBox2.Controls.Add(Widthlab)
			Me.GroupBox2.Controls.Add(Me.Distxt)
			Me.GroupBox2.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 9.75F, Global.System.Drawing.FontStyle.Bold Or Global.System.Drawing.FontStyle.Italic, Global.System.Drawing.GraphicsUnit.Point, 161)
			Dim groupBox As Global.System.Windows.Forms.Control = Me.GroupBox2
			location = New Global.System.Drawing.Point(50, 30)
			groupBox.Location = location
			Me.GroupBox2.Name = "GroupBox2"
			Dim groupBox2 As Global.System.Windows.Forms.Control = Me.GroupBox2
			size = New Global.System.Drawing.Size(250, 261)
			groupBox2.Size = size
			Me.GroupBox2.TabIndex = 1
			Me.GroupBox2.TabStop = False
			Me.GroupBox2.Text = "Basic Geometrical Parameters"
			Me.Tooloffsettxt.Font = New Global.System.Drawing.Font("Arial", 12F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 161)
			Dim tooloffsettxt As Global.System.Windows.Forms.Control = Me.Tooloffsettxt
			location = New Global.System.Drawing.Point(169, 212)
			tooloffsettxt.Location = location
			Dim tooloffsettxt2 As Global.System.Windows.Forms.Control = Me.Tooloffsettxt
			margin = New Global.System.Windows.Forms.Padding(4, 5, 4, 5)
			tooloffsettxt2.Margin = margin
			Me.Tooloffsettxt.Name = "Tooloffsettxt"
			Dim tooloffsettxt3 As Global.System.Windows.Forms.Control = Me.Tooloffsettxt
			size = New Global.System.Drawing.Size(60, 26)
			tooloffsettxt3.Size = size
			Me.Tooloffsettxt.TabIndex = 4
			Me.Tooloffsettxt.Text = "0.00"
			Me.Tooloffsettxt.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
			Me.Cnfrmbtn.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 11.25F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 161)
			Dim cnfrmbtn As Global.System.Windows.Forms.Control = Me.Cnfrmbtn
			location = New Global.System.Drawing.Point(394, 494)
			cnfrmbtn.Location = location
			Me.Cnfrmbtn.Name = "Cnfrmbtn"
			Dim cnfrmbtn2 As Global.System.Windows.Forms.Control = Me.Cnfrmbtn
			size = New Global.System.Drawing.Size(85, 26)
			cnfrmbtn2.Size = size
			Me.Cnfrmbtn.TabIndex = 6
			Me.Cnfrmbtn.Text = "Confirm"
			Me.Cnfrmbtn.TextAlign = Global.System.Drawing.ContentAlignment.TopCenter
			Me.Cnfrmbtn.UseVisualStyleBackColor = True
			Me.Cnlbtn.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 11.25F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 161)
			Dim cnlbtn As Global.System.Windows.Forms.Control = Me.Cnlbtn
			location = New Global.System.Drawing.Point(519, 494)
			cnlbtn.Location = location
			Me.Cnlbtn.Name = "Cnlbtn"
			Dim cnlbtn2 As Global.System.Windows.Forms.Control = Me.Cnlbtn
			size = New Global.System.Drawing.Size(85, 26)
			cnlbtn2.Size = size
			Me.Cnlbtn.TabIndex = 7
			Me.Cnlbtn.Text = "Cancel"
			Me.Cnlbtn.TextAlign = Global.System.Drawing.ContentAlignment.TopCenter
			Me.Cnlbtn.UseVisualStyleBackColor = True
			Me.GroupBox3.Controls.Add(Me.CurrPosStat)
			Me.GroupBox3.Controls.Add(Me.Conatxt)
			Me.GroupBox3.Controls.Add(Label9)
			Me.GroupBox3.Controls.Add(Label8)
			Me.GroupBox3.Controls.Add(Me.Finoverwtxt)
			Me.GroupBox3.Controls.Add(Me.Stationslct)
			Me.GroupBox3.Controls.Add(Label6)
			Me.GroupBox3.Controls.Add(Me.Initang)
			Me.GroupBox3.Controls.Add(Label5)
			Me.GroupBox3.Controls.Add(Me.Meandrptc)
			Me.GroupBox3.Controls.Add(Me.Meandrflg)
			Me.GroupBox3.Controls.Add(Label)
			Me.GroupBox3.Controls.Add(Me.Postatxt)
			Me.GroupBox3.Controls.Add(Label2)
			Me.GroupBox3.Controls.Add(Me.Meandramp)
			Me.GroupBox3.Controls.Add(Label3)
			Me.GroupBox3.Controls.Add(Label4)
			Me.GroupBox3.Controls.Add(Me.Inioverwtxt)
			Me.GroupBox3.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 9.75F, Global.System.Drawing.FontStyle.Bold Or Global.System.Drawing.FontStyle.Italic, Global.System.Drawing.GraphicsUnit.Point, 161)
			Dim groupBox3 As Global.System.Windows.Forms.Control = Me.GroupBox3
			location = New Global.System.Drawing.Point(378, 30)
			groupBox3.Location = location
			Me.GroupBox3.Name = "GroupBox3"
			Dim groupBox4 As Global.System.Windows.Forms.Control = Me.GroupBox3
			size = New Global.System.Drawing.Size(250, 445)
			groupBox4.Size = size
			Me.GroupBox3.TabIndex = 5
			Me.GroupBox3.TabStop = False
			Me.GroupBox3.Text = "Extra Geometrical Parameters"
			Me.CurrPosStat.AutoSize = True
			Dim currPosStat As Global.System.Windows.Forms.Control = Me.CurrPosStat
			location = New Global.System.Drawing.Point(59, 410)
			currPosStat.Location = location
			Me.CurrPosStat.Name = "CurrPosStat"
			Dim currPosStat2 As Global.System.Windows.Forms.Control = Me.CurrPosStat
			size = New Global.System.Drawing.Size(138, 20)
			currPosStat2.Size = size
			Me.CurrPosStat.TabIndex = 9
			Me.CurrPosStat.Text = "Position Upload"
			Me.CurrPosStat.UseVisualStyleBackColor = True
			Me.Conatxt.Font = New Global.System.Drawing.Font("Arial", 12F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 161)
			Dim conatxt As Global.System.Windows.Forms.Control = Me.Conatxt
			location = New Global.System.Drawing.Point(169, 73)
			conatxt.Location = location
			Dim conatxt2 As Global.System.Windows.Forms.Control = Me.Conatxt
			margin = New Global.System.Windows.Forms.Padding(4, 5, 4, 5)
			conatxt2.Margin = margin
			Me.Conatxt.Name = "Conatxt"
			Dim conatxt3 As Global.System.Windows.Forms.Control = Me.Conatxt
			size = New Global.System.Drawing.Size(60, 26)
			conatxt3.Size = size
			Me.Conatxt.TabIndex = 1
			Me.Conatxt.Text = "60.00"
			Me.Conatxt.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
			Me.Finoverwtxt.Font = New Global.System.Drawing.Font("Arial", 12F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 161)
			Dim finoverwtxt As Global.System.Windows.Forms.Control = Me.Finoverwtxt
			location = New Global.System.Drawing.Point(169, 208)
			finoverwtxt.Location = location
			Dim finoverwtxt2 As Global.System.Windows.Forms.Control = Me.Finoverwtxt
			margin = New Global.System.Windows.Forms.Padding(4, 5, 4, 5)
			finoverwtxt2.Margin = margin
			Me.Finoverwtxt.Name = "Finoverwtxt"
			Dim finoverwtxt3 As Global.System.Windows.Forms.Control = Me.Finoverwtxt
			size = New Global.System.Drawing.Size(60, 26)
			finoverwtxt3.Size = size
			Me.Finoverwtxt.TabIndex = 4
			Me.Finoverwtxt.Text = "100.00"
			Me.Finoverwtxt.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
			Me.Stationslct.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 12F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 161)
			Me.Stationslct.FormattingEnabled = True
			Me.Stationslct.IntegralHeight = False
			Me.Stationslct.ItemHeight = 20
			Me.Stationslct.Items.AddRange(New Object() { "30", "45", "60", "90" })
			Dim stationslct As Global.System.Windows.Forms.Control = Me.Stationslct
			location = New Global.System.Drawing.Point(170, 116)
			stationslct.Location = location
			Me.Stationslct.Name = "Stationslct"
			Dim stationslct2 As Global.System.Windows.Forms.Control = Me.Stationslct
			size = New Global.System.Drawing.Size(60, 26)
			stationslct2.Size = size
			Me.Stationslct.TabIndex = 2
			Me.Initang.Font = New Global.System.Drawing.Font("Arial", 12F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 161)
			Dim initang As Global.System.Windows.Forms.Control = Me.Initang
			location = New Global.System.Drawing.Point(169, 346)
			initang.Location = location
			Dim initang2 As Global.System.Windows.Forms.Control = Me.Initang
			margin = New Global.System.Windows.Forms.Padding(4, 5, 4, 5)
			initang2.Margin = margin
			Me.Initang.Name = "Initang"
			Dim initang3 As Global.System.Windows.Forms.Control = Me.Initang
			size = New Global.System.Drawing.Size(60, 26)
			initang3.Size = size
			Me.Initang.TabIndex = 7
			Me.Initang.Text = "0.0"
			Me.Initang.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
			Me.Meandrptc.CharacterCasing = Global.System.Windows.Forms.CharacterCasing.Lower
			Me.Meandrptc.Enabled = False
			Me.Meandrptc.Font = New Global.System.Drawing.Font("Arial", 12F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 161)
			Dim meandrptc As Global.System.Windows.Forms.Control = Me.Meandrptc
			location = New Global.System.Drawing.Point(169, 299)
			meandrptc.Location = location
			Dim meandrptc2 As Global.System.Windows.Forms.Control = Me.Meandrptc
			margin = New Global.System.Windows.Forms.Padding(4, 5, 4, 5)
			meandrptc2.Margin = margin
			Me.Meandrptc.Name = "Meandrptc"
			Dim meandrptc3 As Global.System.Windows.Forms.Control = Me.Meandrptc
			size = New Global.System.Drawing.Size(60, 26)
			meandrptc3.Size = size
			Me.Meandrptc.TabIndex = 6
			Me.Meandrptc.Text = "1.50"
			Me.Meandrptc.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
			Me.Meandrflg.AutoSize = True
			Me.Meandrflg.Enabled = False
			Dim meandrflg As Global.System.Windows.Forms.Control = Me.Meandrflg
			location = New Global.System.Drawing.Point(59, 382)
			meandrflg.Location = location
			Me.Meandrflg.Name = "Meandrflg"
			Dim meandrflg2 As Global.System.Windows.Forms.Control = Me.Meandrflg
			size = New Global.System.Drawing.Size(163, 20)
			meandrflg2.Size = size
			Me.Meandrflg.TabIndex = 8
			Me.Meandrflg.Text = "Meander Movement"
			Me.Meandrflg.UseVisualStyleBackColor = True
			Me.Postatxt.Font = New Global.System.Drawing.Font("Arial", 12F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 161)
			Dim postatxt As Global.System.Windows.Forms.Control = Me.Postatxt
			location = New Global.System.Drawing.Point(169, 29)
			postatxt.Location = location
			Dim postatxt2 As Global.System.Windows.Forms.Control = Me.Postatxt
			margin = New Global.System.Windows.Forms.Padding(4, 5, 4, 5)
			postatxt2.Margin = margin
			Me.Postatxt.Name = "Postatxt"
			Dim postatxt3 As Global.System.Windows.Forms.Control = Me.Postatxt
			size = New Global.System.Drawing.Size(60, 26)
			postatxt3.Size = size
			Me.Postatxt.TabIndex = 0
			Me.Postatxt.Text = "30.00"
			Me.Postatxt.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
			Me.Meandramp.Enabled = False
			Me.Meandramp.Font = New Global.System.Drawing.Font("Arial", 12F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 161)
			Dim meandramp As Global.System.Windows.Forms.Control = Me.Meandramp
			location = New Global.System.Drawing.Point(169, 252)
			meandramp.Location = location
			Dim meandramp2 As Global.System.Windows.Forms.Control = Me.Meandramp
			margin = New Global.System.Windows.Forms.Padding(4, 5, 4, 5)
			meandramp2.Margin = margin
			Me.Meandramp.Name = "Meandramp"
			Dim meandramp3 As Global.System.Windows.Forms.Control = Me.Meandramp
			size = New Global.System.Drawing.Size(60, 26)
			meandramp3.Size = size
			Me.Meandramp.TabIndex = 5
			Me.Meandramp.Text = "2.00"
			Me.Meandramp.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
			Me.Inioverwtxt.Font = New Global.System.Drawing.Font("Arial", 12F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 161)
			Dim inioverwtxt As Global.System.Windows.Forms.Control = Me.Inioverwtxt
			location = New Global.System.Drawing.Point(169, 162)
			inioverwtxt.Location = location
			Dim inioverwtxt2 As Global.System.Windows.Forms.Control = Me.Inioverwtxt
			margin = New Global.System.Windows.Forms.Padding(4, 5, 4, 5)
			inioverwtxt2.Margin = margin
			Me.Inioverwtxt.Name = "Inioverwtxt"
			Dim inioverwtxt3 As Global.System.Windows.Forms.Control = Me.Inioverwtxt
			size = New Global.System.Drawing.Size(60, 26)
			inioverwtxt3.Size = size
			Me.Inioverwtxt.TabIndex = 3
			Me.Inioverwtxt.Text = "100.00"
			Me.Inioverwtxt.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
			Me.GroupBox4.Controls.Add(Me.Vlvspind)
			Me.GroupBox4.Controls.Add(Me.Vlvseat)
			Me.GroupBox4.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 10F, Global.System.Drawing.FontStyle.Bold Or Global.System.Drawing.FontStyle.Italic, Global.System.Drawing.GraphicsUnit.Point, 161)
			Dim groupBox5 As Global.System.Windows.Forms.Control = Me.GroupBox4
			location = New Global.System.Drawing.Point(50, 297)
			groupBox5.Location = location
			Me.GroupBox4.Name = "GroupBox4"
			Dim groupBox6 As Global.System.Windows.Forms.Control = Me.GroupBox4
			size = New Global.System.Drawing.Size(250, 92)
			groupBox6.Size = size
			Me.GroupBox4.TabIndex = 2
			Me.GroupBox4.TabStop = False
			Me.GroupBox4.Text = "Part Selection"
			Me.Vlvspind.AutoSize = True
			Me.Vlvspind.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 12F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 161)
			Dim vlvspind As Global.System.Windows.Forms.Control = Me.Vlvspind
			location = New Global.System.Drawing.Point(63, 51)
			vlvspind.Location = location
			Me.Vlvspind.Name = "Vlvspind"
			Dim vlvspind2 As Global.System.Windows.Forms.Control = Me.Vlvspind
			size = New Global.System.Drawing.Size(136, 24)
			vlvspind2.Size = size
			Me.Vlvspind.TabIndex = 24
			Me.Vlvspind.Text = "Valve Spindle"
			Me.Vlvspind.UseVisualStyleBackColor = True
			Me.Vlvseat.AutoSize = True
			Me.Vlvseat.Checked = True
			Me.Vlvseat.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 12F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 161)
			Dim vlvseat As Global.System.Windows.Forms.Control = Me.Vlvseat
			location = New Global.System.Drawing.Point(63, 24)
			vlvseat.Location = location
			Me.Vlvseat.Name = "Vlvseat"
			Dim vlvseat2 As Global.System.Windows.Forms.Control = Me.Vlvseat
			size = New Global.System.Drawing.Size(114, 24)
			vlvseat2.Size = size
			Me.Vlvseat.TabIndex = 23
			Me.Vlvseat.TabStop = True
			Me.Vlvseat.Text = "Valve Seat"
			Me.Vlvseat.UseVisualStyleBackColor = True
			Me.GroupBox1.Controls.Add(Me.Rightdirflg)
			Me.GroupBox1.Controls.Add(Me.Leftdirflg)
			Me.GroupBox1.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 10F, Global.System.Drawing.FontStyle.Bold Or Global.System.Drawing.FontStyle.Italic, Global.System.Drawing.GraphicsUnit.Point, 161)
			Dim groupBox7 As Global.System.Windows.Forms.Control = Me.GroupBox1
			location = New Global.System.Drawing.Point(50, 395)
			groupBox7.Location = location
			Me.GroupBox1.Name = "GroupBox1"
			Dim groupBox8 As Global.System.Windows.Forms.Control = Me.GroupBox1
			size = New Global.System.Drawing.Size(250, 65)
			groupBox8.Size = size
			Me.GroupBox1.TabIndex = 3
			Me.GroupBox1.TabStop = False
			Me.GroupBox1.Text = "Cladding Direction"
			Me.Rightdirflg.AutoSize = True
			Me.Rightdirflg.Checked = True
			Me.Rightdirflg.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 12F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 161)
			Dim rightdirflg As Global.System.Windows.Forms.Control = Me.Rightdirflg
			location = New Global.System.Drawing.Point(132, 26)
			rightdirflg.Location = location
			Me.Rightdirflg.Name = "Rightdirflg"
			Dim rightdirflg2 As Global.System.Windows.Forms.Control = Me.Rightdirflg
			size = New Global.System.Drawing.Size(70, 24)
			rightdirflg2.Size = size
			Me.Rightdirflg.TabIndex = 1
			Me.Rightdirflg.TabStop = True
			Me.Rightdirflg.Text = "Right"
			Me.Rightdirflg.UseVisualStyleBackColor = True
			Me.Leftdirflg.AutoSize = True
			Me.Leftdirflg.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 12F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 161)
			Dim leftdirflg As Global.System.Windows.Forms.Control = Me.Leftdirflg
			location = New Global.System.Drawing.Point(21, 26)
			leftdirflg.Location = location
			Me.Leftdirflg.Name = "Leftdirflg"
			Dim leftdirflg2 As Global.System.Windows.Forms.Control = Me.Leftdirflg
			size = New Global.System.Drawing.Size(59, 24)
			leftdirflg2.Size = size
			Me.Leftdirflg.TabIndex = 0
			Me.Leftdirflg.Text = "Left"
			Me.Leftdirflg.UseVisualStyleBackColor = True
			Me.GroupBox5.Controls.Add(Me.WD_13)
			Me.GroupBox5.Controls.Add(Me.WD_20)
			Me.GroupBox5.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 10F, Global.System.Drawing.FontStyle.Bold Or Global.System.Drawing.FontStyle.Italic, Global.System.Drawing.GraphicsUnit.Point, 161)
			Dim groupBox9 As Global.System.Windows.Forms.Control = Me.GroupBox5
			location = New Global.System.Drawing.Point(50, 466)
			groupBox9.Location = location
			Me.GroupBox5.Name = "GroupBox5"
			Dim groupBox10 As Global.System.Windows.Forms.Control = Me.GroupBox5
			size = New Global.System.Drawing.Size(250, 65)
			groupBox10.Size = size
			Me.GroupBox5.TabIndex = 4
			Me.GroupBox5.TabStop = False
			Me.GroupBox5.Text = "Head Selectύon"
			Me.WD_13.AutoSize = True
			Me.WD_13.Enabled = False
			Me.WD_13.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 12F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 161)
			Dim wd_ As Global.System.Windows.Forms.Control = Me.WD_13
			location = New Global.System.Drawing.Point(132, 26)
			wd_.Location = location
			Me.WD_13.Name = "WD_13"
			Dim wd_2 As Global.System.Windows.Forms.Control = Me.WD_13
			size = New Global.System.Drawing.Size(81, 24)
			wd_2.Size = size
			Me.WD_13.TabIndex = 1
			Me.WD_13.Text = "WD 13"
			Me.WD_13.UseVisualStyleBackColor = True
			Me.WD_20.AutoSize = True
			Me.WD_20.Checked = True
			Me.WD_20.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 12F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 161)
			Dim wd_3 As Global.System.Windows.Forms.Control = Me.WD_20
			location = New Global.System.Drawing.Point(21, 26)
			wd_3.Location = location
			Me.WD_20.Name = "WD_20"
			Dim wd_4 As Global.System.Windows.Forms.Control = Me.WD_20
			size = New Global.System.Drawing.Size(81, 24)
			wd_4.Size = size
			Me.WD_20.TabIndex = 0
			Me.WD_20.TabStop = True
			Me.WD_20.Text = "WD 20"
			Me.WD_20.UseVisualStyleBackColor = True
			Dim autoScaleDimensions As Global.System.Drawing.SizeF = New Global.System.Drawing.SizeF(9F, 20F)
			Me.AutoScaleDimensions = autoScaleDimensions
			Me.AutoScaleMode = Global.System.Windows.Forms.AutoScaleMode.Font
			Me.AutoSize = True
			size = New Global.System.Drawing.Size(684, 562)
			Me.ClientSize = size
			Me.Controls.Add(Me.GroupBox5)
			Me.Controls.Add(Me.GroupBox1)
			Me.Controls.Add(Me.GroupBox3)
			Me.Controls.Add(Me.GroupBox4)
			Me.Controls.Add(Me.Cnlbtn)
			Me.Controls.Add(Me.Cnfrmbtn)
			Me.Controls.Add(Me.GroupBox2)
			Me.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 12F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 161)
			margin = New Global.System.Windows.Forms.Padding(4, 5, 4, 5)
			Me.Margin = margin
			Me.Name = "VPARAM"
			Me.Text = "Valve Clad Parameters"
			Me.GroupBox2.ResumeLayout(False)
			Me.GroupBox2.PerformLayout()
			Me.GroupBox3.ResumeLayout(False)
			Me.GroupBox3.PerformLayout()
			Me.GroupBox4.ResumeLayout(False)
			Me.GroupBox4.PerformLayout()
			Me.GroupBox1.ResumeLayout(False)
			Me.GroupBox1.PerformLayout()
			Me.GroupBox5.ResumeLayout(False)
			Me.GroupBox5.PerformLayout()
			Me.ResumeLayout(False)
		End Sub

		' Token: 0x04000296 RID: 662
		Private components As Global.System.ComponentModel.IContainer
	End Class
End Namespace
