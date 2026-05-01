Namespace WindowsApplication1
	' Token: 0x02000018 RID: 24
	<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
	Public Partial Class PPARAM
		Inherits Global.System.Windows.Forms.Form

		' Token: 0x0600048F RID: 1167 RVA: 0x0003F8F8 File Offset: 0x0003DCF8
		<Global.System.Diagnostics.DebuggerNonUserCode()>
		Protected Overrides Sub Dispose(disposing As Boolean)
			If disposing AndAlso Me.components IsNot Nothing Then
				Me.components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		' Token: 0x06000490 RID: 1168 RVA: 0x0003F918 File Offset: 0x0003DD18
		<Global.System.Diagnostics.DebuggerStepThrough()>
		Private Sub InitializeComponent()
			Me.Lengthtxt = New Global.System.Windows.Forms.TextBox()
			Me.Widthtxt = New Global.System.Windows.Forms.TextBox()
			Me.Xtxt = New Global.System.Windows.Forms.TextBox()
			Me.Pittxt = New Global.System.Windows.Forms.TextBox()
			Me.GroupBox2 = New Global.System.Windows.Forms.GroupBox()
			Me.Ztxt = New Global.System.Windows.Forms.TextBox()
			Me.Ytxt = New Global.System.Windows.Forms.TextBox()
			Me.Tooloffsettxt = New Global.System.Windows.Forms.TextBox()
			Me.Cnfrmbtn = New Global.System.Windows.Forms.Button()
			Me.Cnlbtn = New Global.System.Windows.Forms.Button()
			Me.GroupBox3 = New Global.System.Windows.Forms.GroupBox()
			Me.CurrPosStat = New Global.System.Windows.Forms.CheckBox()
			Me.Initang = New Global.System.Windows.Forms.TextBox()
			Me.Meandrptc = New Global.System.Windows.Forms.TextBox()
			Me.Meandrflg = New Global.System.Windows.Forms.CheckBox()
			Me.Postatxt = New Global.System.Windows.Forms.TextBox()
			Me.Meandramp = New Global.System.Windows.Forms.TextBox()
			Me.GroupBox1 = New Global.System.Windows.Forms.GroupBox()
			Me.A3 = New Global.System.Windows.Forms.RadioButton()
			Me.A2 = New Global.System.Windows.Forms.RadioButton()
			Me.A1 = New Global.System.Windows.Forms.RadioButton()
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
			Me.GroupBox2.SuspendLayout()
			Me.GroupBox3.SuspendLayout()
			Me.GroupBox1.SuspendLayout()
			Me.GroupBox5.SuspendLayout()
			Me.SuspendLayout()
			Dialab.AutoSize = True
			Dialab.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 12F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 161)
			Dim control As Global.System.Windows.Forms.Control = Dialab
			Dim location As Global.System.Drawing.Point = New Global.System.Drawing.Point(59, 31)
			control.Location = location
			Dim control2 As Global.System.Windows.Forms.Control = Dialab
			Dim margin As Global.System.Windows.Forms.Padding = New Global.System.Windows.Forms.Padding(4, 0, 4, 0)
			control2.Margin = margin
			Dialab.Name = "Dialab"
			Dim control3 As Global.System.Windows.Forms.Control = Dialab
			Dim size As Global.System.Drawing.Size = New Global.System.Drawing.Size(110, 20)
			control3.Size = size
			Dialab.TabIndex = 1
			Dialab.Text = "Length (mm)"
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
			location = New Global.System.Drawing.Point(102, 123)
			control7.Location = location
			Dim control8 As Global.System.Windows.Forms.Control = Dislab
			margin = New Global.System.Windows.Forms.Padding(4, 0, 4, 0)
			control8.Margin = margin
			Dislab.Name = "Dislab"
			Dim control9 As Global.System.Windows.Forms.Control = Dislab
			size = New Global.System.Drawing.Size(66, 20)
			control9.Size = size
			Dislab.TabIndex = 5
			Dislab.Text = "X (mm)"
			Pitlab.AutoSize = True
			Pitlab.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 12F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 161)
			Dim control10 As Global.System.Windows.Forms.Control = Pitlab
			location = New Global.System.Drawing.Point(76, 257)
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
			location = New Global.System.Drawing.Point(7, 78)
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
			location = New Global.System.Drawing.Point(10, 21)
			control16.Location = location
			Dim control17 As Global.System.Windows.Forms.Control = Label2
			margin = New Global.System.Windows.Forms.Padding(4, 0, 4, 0)
			control17.Margin = margin
			Label2.Name = "Label2"
			Dim control18 As Global.System.Windows.Forms.Control = Label2
			size = New Global.System.Drawing.Size(162, 40)
			control18.Size = size
			Label2.TabIndex = 1
			Label2.Text = "Posture Angle (Deg to horizontal)"
			Label2.TextAlign = Global.System.Drawing.ContentAlignment.MiddleCenter
			Label3.AutoSize = True
			Label3.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 12F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 161)
			Dim control19 As Global.System.Windows.Forms.Control = Label3
			location = New Global.System.Drawing.Point(3, 125)
			control19.Location = location
			Dim control20 As Global.System.Windows.Forms.Control = Label3
			margin = New Global.System.Windows.Forms.Padding(4, 0, 4, 0)
			control20.Margin = margin
			Label3.Name = "Label5"
			Dim control21 As Global.System.Windows.Forms.Control = Label3
			size = New Global.System.Drawing.Size(169, 20)
			control21.Size = size
			Label3.TabIndex = 20
			Label3.Text = "Meander Pitch (mm)"
			Label4.AutoSize = True
			Label4.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 12F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 161)
			Dim control22 As Global.System.Windows.Forms.Control = Label4
			location = New Global.System.Drawing.Point(18, 172)
			control22.Location = location
			Dim control23 As Global.System.Windows.Forms.Control = Label4
			margin = New Global.System.Windows.Forms.Padding(4, 0, 4, 0)
			control23.Margin = margin
			Label4.Name = "Label7"
			Dim control24 As Global.System.Windows.Forms.Control = Label4
			size = New Global.System.Drawing.Size(154, 20)
			control24.Size = size
			Label4.TabIndex = 22
			Label4.Text = "Initial Angle (Deg)"
			Label5.AutoSize = True
			Label5.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 12F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 161)
			Dim control25 As Global.System.Windows.Forms.Control = Label5
			location = New Global.System.Drawing.Point(24, 302)
			control25.Location = location
			Dim control26 As Global.System.Windows.Forms.Control = Label5
			margin = New Global.System.Windows.Forms.Padding(4, 0, 4, 0)
			control26.Margin = margin
			Label5.Name = "Label6"
			Dim control27 As Global.System.Windows.Forms.Control = Label5
			size = New Global.System.Drawing.Size(143, 20)
			control27.Size = size
			Label5.TabIndex = 9
			Label5.Text = "Tool Offset (mm)"
			Label6.AutoSize = True
			Label6.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 12F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 161)
			Dim control28 As Global.System.Windows.Forms.Control = Label6
			location = New Global.System.Drawing.Point(103, 169)
			control28.Location = location
			Dim control29 As Global.System.Windows.Forms.Control = Label6
			margin = New Global.System.Windows.Forms.Padding(4, 0, 4, 0)
			control29.Margin = margin
			Label6.Name = "Label9"
			Dim control30 As Global.System.Windows.Forms.Control = Label6
			size = New Global.System.Drawing.Size(66, 20)
			control30.Size = size
			Label6.TabIndex = 11
			Label6.Text = "Y (mm)"
			Label7.AutoSize = True
			Label7.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 12F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 161)
			Dim control31 As Global.System.Windows.Forms.Control = Label7
			location = New Global.System.Drawing.Point(103, 213)
			control31.Location = location
			Dim control32 As Global.System.Windows.Forms.Control = Label7
			margin = New Global.System.Windows.Forms.Padding(4, 0, 4, 0)
			control32.Margin = margin
			Label7.Name = "Label10"
			Dim control33 As Global.System.Windows.Forms.Control = Label7
			size = New Global.System.Drawing.Size(65, 20)
			control33.Size = size
			Label7.TabIndex = 13
			Label7.Text = "Z (mm)"
			Me.Lengthtxt.Font = New Global.System.Drawing.Font("Arial", 12F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 161)
			Dim lengthtxt As Global.System.Windows.Forms.Control = Me.Lengthtxt
			location = New Global.System.Drawing.Point(169, 29)
			lengthtxt.Location = location
			Dim lengthtxt2 As Global.System.Windows.Forms.Control = Me.Lengthtxt
			margin = New Global.System.Windows.Forms.Padding(4, 5, 4, 5)
			lengthtxt2.Margin = margin
			Me.Lengthtxt.Name = "Lengthtxt"
			Dim lengthtxt3 As Global.System.Windows.Forms.Control = Me.Lengthtxt
			size = New Global.System.Drawing.Size(60, 26)
			lengthtxt3.Size = size
			Me.Lengthtxt.TabIndex = 0
			Me.Lengthtxt.Text = "50.00"
			Me.Lengthtxt.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
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
			Me.Xtxt.Font = New Global.System.Drawing.Font("Arial", 12F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 161)
			Dim xtxt As Global.System.Windows.Forms.Control = Me.Xtxt
			location = New Global.System.Drawing.Point(169, 121)
			xtxt.Location = location
			Dim xtxt2 As Global.System.Windows.Forms.Control = Me.Xtxt
			margin = New Global.System.Windows.Forms.Padding(4, 5, 4, 5)
			xtxt2.Margin = margin
			Me.Xtxt.Name = "Xtxt"
			Dim xtxt3 As Global.System.Windows.Forms.Control = Me.Xtxt
			size = New Global.System.Drawing.Size(60, 26)
			xtxt3.Size = size
			Me.Xtxt.TabIndex = 2
			Me.Xtxt.Text = "500.00"
			Me.Xtxt.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
			Me.Pittxt.Font = New Global.System.Drawing.Font("Arial", 12F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 161)
			Dim pittxt As Global.System.Windows.Forms.Control = Me.Pittxt
			location = New Global.System.Drawing.Point(170, 255)
			pittxt.Location = location
			Dim pittxt2 As Global.System.Windows.Forms.Control = Me.Pittxt
			margin = New Global.System.Windows.Forms.Padding(4, 5, 4, 5)
			pittxt2.Margin = margin
			Me.Pittxt.Name = "Pittxt"
			Dim pittxt3 As Global.System.Windows.Forms.Control = Me.Pittxt
			size = New Global.System.Drawing.Size(60, 26)
			pittxt3.Size = size
			Me.Pittxt.TabIndex = 3
			Me.Pittxt.Text = "4.50"
			Me.Pittxt.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
			Me.GroupBox2.Controls.Add(Label7)
			Me.GroupBox2.Controls.Add(Me.Ztxt)
			Me.GroupBox2.Controls.Add(Label6)
			Me.GroupBox2.Controls.Add(Me.Ytxt)
			Me.GroupBox2.Controls.Add(Label5)
			Me.GroupBox2.Controls.Add(Me.Tooloffsettxt)
			Me.GroupBox2.Controls.Add(Pitlab)
			Me.GroupBox2.Controls.Add(Me.Lengthtxt)
			Me.GroupBox2.Controls.Add(Dialab)
			Me.GroupBox2.Controls.Add(Me.Pittxt)
			Me.GroupBox2.Controls.Add(Me.Widthtxt)
			Me.GroupBox2.Controls.Add(Dislab)
			Me.GroupBox2.Controls.Add(Widthlab)
			Me.GroupBox2.Controls.Add(Me.Xtxt)
			Me.GroupBox2.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 9.75F, Global.System.Drawing.FontStyle.Bold Or Global.System.Drawing.FontStyle.Italic, Global.System.Drawing.GraphicsUnit.Point, 161)
			Dim groupBox As Global.System.Windows.Forms.Control = Me.GroupBox2
			location = New Global.System.Drawing.Point(50, 30)
			groupBox.Location = location
			Me.GroupBox2.Name = "GroupBox2"
			Dim groupBox2 As Global.System.Windows.Forms.Control = Me.GroupBox2
			size = New Global.System.Drawing.Size(250, 359)
			groupBox2.Size = size
			Me.GroupBox2.TabIndex = 15
			Me.GroupBox2.TabStop = False
			Me.GroupBox2.Text = "Basic Geometrical Parameters"
			Me.Ztxt.Font = New Global.System.Drawing.Font("Arial", 12F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 161)
			Dim ztxt As Global.System.Windows.Forms.Control = Me.Ztxt
			location = New Global.System.Drawing.Point(170, 211)
			ztxt.Location = location
			Dim ztxt2 As Global.System.Windows.Forms.Control = Me.Ztxt
			margin = New Global.System.Windows.Forms.Padding(4, 5, 4, 5)
			ztxt2.Margin = margin
			Me.Ztxt.Name = "Ztxt"
			Dim ztxt3 As Global.System.Windows.Forms.Control = Me.Ztxt
			size = New Global.System.Drawing.Size(60, 26)
			ztxt3.Size = size
			Me.Ztxt.TabIndex = 12
			Me.Ztxt.Text = "500.00"
			Me.Ztxt.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
			Me.Ytxt.Font = New Global.System.Drawing.Font("Arial", 12F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 161)
			Dim ytxt As Global.System.Windows.Forms.Control = Me.Ytxt
			location = New Global.System.Drawing.Point(170, 167)
			ytxt.Location = location
			Dim ytxt2 As Global.System.Windows.Forms.Control = Me.Ytxt
			margin = New Global.System.Windows.Forms.Padding(4, 5, 4, 5)
			ytxt2.Margin = margin
			Me.Ytxt.Name = "Ytxt"
			Dim ytxt3 As Global.System.Windows.Forms.Control = Me.Ytxt
			size = New Global.System.Drawing.Size(60, 26)
			ytxt3.Size = size
			Me.Ytxt.TabIndex = 10
			Me.Ytxt.Text = "500.00"
			Me.Ytxt.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
			Me.Tooloffsettxt.Font = New Global.System.Drawing.Font("Arial", 12F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 161)
			Dim tooloffsettxt As Global.System.Windows.Forms.Control = Me.Tooloffsettxt
			location = New Global.System.Drawing.Point(169, 300)
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
			location = New Global.System.Drawing.Point(395, 415)
			cnfrmbtn.Location = location
			Me.Cnfrmbtn.Name = "Cnfrmbtn"
			Dim cnfrmbtn2 As Global.System.Windows.Forms.Control = Me.Cnfrmbtn
			size = New Global.System.Drawing.Size(85, 26)
			cnfrmbtn2.Size = size
			Me.Cnfrmbtn.TabIndex = 0
			Me.Cnfrmbtn.Text = "Confirm"
			Me.Cnfrmbtn.TextAlign = Global.System.Drawing.ContentAlignment.TopCenter
			Me.Cnfrmbtn.UseVisualStyleBackColor = True
			Me.Cnlbtn.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 11.25F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 161)
			Dim cnlbtn As Global.System.Windows.Forms.Control = Me.Cnlbtn
			location = New Global.System.Drawing.Point(520, 415)
			cnlbtn.Location = location
			Me.Cnlbtn.Name = "Cnlbtn"
			Dim cnlbtn2 As Global.System.Windows.Forms.Control = Me.Cnlbtn
			size = New Global.System.Drawing.Size(85, 26)
			cnlbtn2.Size = size
			Me.Cnlbtn.TabIndex = 1
			Me.Cnlbtn.Text = "Cancel"
			Me.Cnlbtn.TextAlign = Global.System.Drawing.ContentAlignment.TopCenter
			Me.Cnlbtn.UseVisualStyleBackColor = True
			Me.GroupBox3.Controls.Add(Me.CurrPosStat)
			Me.GroupBox3.Controls.Add(Label4)
			Me.GroupBox3.Controls.Add(Me.Initang)
			Me.GroupBox3.Controls.Add(Label3)
			Me.GroupBox3.Controls.Add(Me.Meandrptc)
			Me.GroupBox3.Controls.Add(Me.Meandrflg)
			Me.GroupBox3.Controls.Add(Label)
			Me.GroupBox3.Controls.Add(Me.Postatxt)
			Me.GroupBox3.Controls.Add(Label2)
			Me.GroupBox3.Controls.Add(Me.Meandramp)
			Me.GroupBox3.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 9.75F, Global.System.Drawing.FontStyle.Bold Or Global.System.Drawing.FontStyle.Italic, Global.System.Drawing.GraphicsUnit.Point, 161)
			Dim groupBox3 As Global.System.Windows.Forms.Control = Me.GroupBox3
			location = New Global.System.Drawing.Point(380, 30)
			groupBox3.Location = location
			Me.GroupBox3.Name = "GroupBox3"
			Dim groupBox4 As Global.System.Windows.Forms.Control = Me.GroupBox3
			size = New Global.System.Drawing.Size(248, 269)
			groupBox4.Size = size
			Me.GroupBox3.TabIndex = 18
			Me.GroupBox3.TabStop = False
			Me.GroupBox3.Text = "Extra Geometrical Parameters"
			Me.CurrPosStat.AutoSize = True
			Dim currPosStat As Global.System.Windows.Forms.Control = Me.CurrPosStat
			location = New Global.System.Drawing.Point(62, 235)
			currPosStat.Location = location
			Me.CurrPosStat.Name = "CurrPosStat"
			Dim currPosStat2 As Global.System.Windows.Forms.Control = Me.CurrPosStat
			size = New Global.System.Drawing.Size(138, 20)
			currPosStat2.Size = size
			Me.CurrPosStat.TabIndex = 21
			Me.CurrPosStat.Text = "Position Upload"
			Me.CurrPosStat.UseVisualStyleBackColor = True
			Me.Initang.Font = New Global.System.Drawing.Font("Arial", 12F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 161)
			Dim initang As Global.System.Windows.Forms.Control = Me.Initang
			location = New Global.System.Drawing.Point(172, 171)
			initang.Location = location
			Dim initang2 As Global.System.Windows.Forms.Control = Me.Initang
			margin = New Global.System.Windows.Forms.Padding(4, 5, 4, 5)
			initang2.Margin = margin
			Me.Initang.Name = "Initang"
			Dim initang3 As Global.System.Windows.Forms.Control = Me.Initang
			size = New Global.System.Drawing.Size(60, 26)
			initang3.Size = size
			Me.Initang.TabIndex = 6
			Me.Initang.Text = "0.0"
			Me.Initang.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
			Me.Meandrptc.Font = New Global.System.Drawing.Font("Arial", 12F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 161)
			Dim meandrptc As Global.System.Windows.Forms.Control = Me.Meandrptc
			location = New Global.System.Drawing.Point(172, 124)
			meandrptc.Location = location
			Dim meandrptc2 As Global.System.Windows.Forms.Control = Me.Meandrptc
			margin = New Global.System.Windows.Forms.Padding(4, 5, 4, 5)
			meandrptc2.Margin = margin
			Me.Meandrptc.Name = "Meandrptc"
			Dim meandrptc3 As Global.System.Windows.Forms.Control = Me.Meandrptc
			size = New Global.System.Drawing.Size(60, 26)
			meandrptc3.Size = size
			Me.Meandrptc.TabIndex = 5
			Me.Meandrptc.Text = "3.00"
			Me.Meandrptc.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
			Me.Meandrflg.AutoSize = True
			Dim meandrflg As Global.System.Windows.Forms.Control = Me.Meandrflg
			location = New Global.System.Drawing.Point(62, 205)
			meandrflg.Location = location
			Me.Meandrflg.Name = "Meandrflg"
			Dim meandrflg2 As Global.System.Windows.Forms.Control = Me.Meandrflg
			size = New Global.System.Drawing.Size(163, 20)
			meandrflg2.Size = size
			Me.Meandrflg.TabIndex = 7
			Me.Meandrflg.Text = "Meander Movement"
			Me.Meandrflg.UseVisualStyleBackColor = True
			Me.Postatxt.Font = New Global.System.Drawing.Font("Arial", 12F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 161)
			Dim postatxt As Global.System.Windows.Forms.Control = Me.Postatxt
			location = New Global.System.Drawing.Point(172, 29)
			postatxt.Location = location
			Dim postatxt2 As Global.System.Windows.Forms.Control = Me.Postatxt
			margin = New Global.System.Windows.Forms.Padding(4, 5, 4, 5)
			postatxt2.Margin = margin
			Me.Postatxt.Name = "Postatxt"
			Dim postatxt3 As Global.System.Windows.Forms.Control = Me.Postatxt
			size = New Global.System.Drawing.Size(60, 26)
			postatxt3.Size = size
			Me.Postatxt.TabIndex = 0
			Me.Postatxt.Text = "90.00"
			Me.Postatxt.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
			Me.Meandramp.Font = New Global.System.Drawing.Font("Arial", 12F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 161)
			Dim meandramp As Global.System.Windows.Forms.Control = Me.Meandramp
			location = New Global.System.Drawing.Point(172, 77)
			meandramp.Location = location
			Dim meandramp2 As Global.System.Windows.Forms.Control = Me.Meandramp
			margin = New Global.System.Windows.Forms.Padding(4, 5, 4, 5)
			meandramp2.Margin = margin
			Me.Meandramp.Name = "Meandramp"
			Dim meandramp3 As Global.System.Windows.Forms.Control = Me.Meandramp
			size = New Global.System.Drawing.Size(60, 26)
			meandramp3.Size = size
			Me.Meandramp.TabIndex = 4
			Me.Meandramp.Text = "2.00"
			Me.Meandramp.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
			Me.GroupBox1.Controls.Add(Me.A3)
			Me.GroupBox1.Controls.Add(Me.A2)
			Me.GroupBox1.Controls.Add(Me.A1)
			Me.GroupBox1.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 10F, Global.System.Drawing.FontStyle.Bold Or Global.System.Drawing.FontStyle.Italic, Global.System.Drawing.GraphicsUnit.Point, 161)
			Dim groupBox5 As Global.System.Windows.Forms.Control = Me.GroupBox1
			location = New Global.System.Drawing.Point(50, 395)
			groupBox5.Location = location
			Me.GroupBox1.Name = "GroupBox1"
			Dim groupBox6 As Global.System.Windows.Forms.Control = Me.GroupBox1
			size = New Global.System.Drawing.Size(250, 65)
			groupBox6.Size = size
			Me.GroupBox1.TabIndex = 19
			Me.GroupBox1.TabStop = False
			Me.GroupBox1.Text = "Robot Position"
			Me.A3.AutoSize = True
			Me.A3.Enabled = False
			Me.A3.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 12F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 161)
			Dim a As Global.System.Windows.Forms.Control = Me.A3
			location = New Global.System.Drawing.Point(192, 26)
			a.Location = location
			Me.A3.Name = "A3"
			Dim a2 As Global.System.Windows.Forms.Control = Me.A3
			size = New Global.System.Drawing.Size(37, 24)
			a2.Size = size
			Me.A3.TabIndex = 19
			Me.A3.Text = "3"
			Me.A3.UseVisualStyleBackColor = True
			Me.A2.AutoSize = True
			Me.A2.Enabled = False
			Me.A2.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 12F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 161)
			Dim a3 As Global.System.Windows.Forms.Control = Me.A2
			location = New Global.System.Drawing.Point(114, 26)
			a3.Location = location
			Me.A2.Name = "A2"
			Dim a4 As Global.System.Windows.Forms.Control = Me.A2
			size = New Global.System.Drawing.Size(37, 24)
			a4.Size = size
			Me.A2.TabIndex = 1
			Me.A2.Text = "2"
			Me.A2.UseVisualStyleBackColor = True
			Me.A1.AutoSize = True
			Me.A1.Checked = True
			Me.A1.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 12F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 161)
			Dim a5 As Global.System.Windows.Forms.Control = Me.A1
			location = New Global.System.Drawing.Point(21, 26)
			a5.Location = location
			Me.A1.Name = "A1"
			Dim a6 As Global.System.Windows.Forms.Control = Me.A1
			size = New Global.System.Drawing.Size(37, 24)
			a6.Size = size
			Me.A1.TabIndex = 0
			Me.A1.TabStop = True
			Me.A1.Text = "1"
			Me.A1.UseVisualStyleBackColor = True
			Me.GroupBox5.Controls.Add(Me.WD_13)
			Me.GroupBox5.Controls.Add(Me.WD_20)
			Me.GroupBox5.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 10F, Global.System.Drawing.FontStyle.Bold Or Global.System.Drawing.FontStyle.Italic, Global.System.Drawing.GraphicsUnit.Point, 161)
			Dim groupBox7 As Global.System.Windows.Forms.Control = Me.GroupBox5
			location = New Global.System.Drawing.Point(380, 305)
			groupBox7.Location = location
			Me.GroupBox5.Name = "GroupBox5"
			Dim groupBox8 As Global.System.Windows.Forms.Control = Me.GroupBox5
			size = New Global.System.Drawing.Size(250, 65)
			groupBox8.Size = size
			Me.GroupBox5.TabIndex = 20
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
			size = New Global.System.Drawing.Size(684, 492)
			Me.ClientSize = size
			Me.Controls.Add(Me.GroupBox5)
			Me.Controls.Add(Me.GroupBox1)
			Me.Controls.Add(Me.GroupBox3)
			Me.Controls.Add(Me.Cnlbtn)
			Me.Controls.Add(Me.Cnfrmbtn)
			Me.Controls.Add(Me.GroupBox2)
			Me.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 12F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 161)
			margin = New Global.System.Windows.Forms.Padding(4, 5, 4, 5)
			Me.Margin = margin
			Me.Name = "PPARAM"
			Me.Text = "Plane Clad Parameters"
			Me.GroupBox2.ResumeLayout(False)
			Me.GroupBox2.PerformLayout()
			Me.GroupBox3.ResumeLayout(False)
			Me.GroupBox3.PerformLayout()
			Me.GroupBox1.ResumeLayout(False)
			Me.GroupBox1.PerformLayout()
			Me.GroupBox5.ResumeLayout(False)
			Me.GroupBox5.PerformLayout()
			Me.ResumeLayout(False)
		End Sub

		' Token: 0x0400018F RID: 399
		Private components As Global.System.ComponentModel.IContainer
	End Class
End Namespace
