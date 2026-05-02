Namespace WindowsApplication1
	' Token: 0x02000008 RID: 8
	<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
	Public Partial Class THREEDCLADPARAM
		Inherits Global.System.Windows.Forms.Form

		' Token: 0x06000040 RID: 64 RVA: 0x00017394 File Offset: 0x00015794
		<Global.System.Diagnostics.DebuggerNonUserCode()>
		Protected Overrides Sub Dispose(disposing As Boolean)
			If disposing AndAlso Me.components IsNot Nothing Then
				Me.components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		' Token: 0x06000041 RID: 65 RVA: 0x000173B4 File Offset: 0x000157B4
		<Global.System.Diagnostics.DebuggerStepThrough()>
		Private Sub InitializeComponent()
			Me.Widthtxt = New Global.System.Windows.Forms.TextBox()
			Me.Pittxt = New Global.System.Windows.Forms.TextBox()
			Me.GroupBox2 = New Global.System.Windows.Forms.GroupBox()
			Me.Tooloffsettxt = New Global.System.Windows.Forms.TextBox()
			Me.Cnfrmbtn = New Global.System.Windows.Forms.Button()
			Me.Cnlbtn = New Global.System.Windows.Forms.Button()
			Me.GroupBox3 = New Global.System.Windows.Forms.GroupBox()
			Me.Meandrptc = New Global.System.Windows.Forms.TextBox()
			Me.MeandrFlg = New Global.System.Windows.Forms.CheckBox()
			Me.Meandramp = New Global.System.Windows.Forms.TextBox()
			Me.CurrPosStat = New Global.System.Windows.Forms.CheckBox()
			Me.GroupBox1 = New Global.System.Windows.Forms.GroupBox()
			Me.Stationslct = New Global.System.Windows.Forms.ListBox()
			Me.CladDirSelection = New Global.System.Windows.Forms.GroupBox()
			Me.Rightdirflg = New Global.System.Windows.Forms.RadioButton()
			Me.Leftdirflg = New Global.System.Windows.Forms.RadioButton()
			Me.FocLengthSelection = New Global.System.Windows.Forms.GroupBox()
			Me.Movement = New Global.System.Windows.Forms.ComboBox()
			Me.MovDirSelection = New Global.System.Windows.Forms.GroupBox()
			Me.SpinDirMov = New Global.System.Windows.Forms.RadioButton()
			Me.ZDirMov = New Global.System.Windows.Forms.RadioButton()
			Me.YDirMov = New Global.System.Windows.Forms.RadioButton()
			Me.XDirMov = New Global.System.Windows.Forms.RadioButton()
			Me.ArrayDirSelection = New Global.System.Windows.Forms.GroupBox()
			Me.Arrayangptctxt = New Global.System.Windows.Forms.TextBox()
			Me.Arrayrecptctxt = New Global.System.Windows.Forms.TextBox()
			Me.Copiestxt = New Global.System.Windows.Forms.TextBox()
			Me.SpinDirArr = New Global.System.Windows.Forms.RadioButton()
			Me.ZDirArr = New Global.System.Windows.Forms.RadioButton()
			Me.YDirArr = New Global.System.Windows.Forms.RadioButton()
			Me.XDirArr = New Global.System.Windows.Forms.RadioButton()
			Me.Overlaymovdir = New Global.System.Windows.Forms.GroupBox()
			Me.Posmov = New Global.System.Windows.Forms.RadioButton()
			Me.Negmov = New Global.System.Windows.Forms.RadioButton()
			Me.Arraymovdir = New Global.System.Windows.Forms.GroupBox()
			Me.Posarr = New Global.System.Windows.Forms.RadioButton()
			Me.Negarr = New Global.System.Windows.Forms.RadioButton()
			Dim Widthlab As Global.System.Windows.Forms.Label = New Global.System.Windows.Forms.Label()
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
			Me.CladDirSelection.SuspendLayout()
			Me.FocLengthSelection.SuspendLayout()
			Me.MovDirSelection.SuspendLayout()
			Me.ArrayDirSelection.SuspendLayout()
			Me.Overlaymovdir.SuspendLayout()
			Me.Arraymovdir.SuspendLayout()
			Me.SuspendLayout()
			Widthlab.AutoSize = True
			Widthlab.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 12F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 161)
			Dim control As Global.System.Windows.Forms.Control = Widthlab
			Dim location As Global.System.Drawing.Point = New Global.System.Drawing.Point(69, 33)
			control.Location = location
			Dim control2 As Global.System.Windows.Forms.Control = Widthlab
			Dim margin As Global.System.Windows.Forms.Padding = New Global.System.Windows.Forms.Padding(4, 0, 4, 0)
			control2.Margin = margin
			Widthlab.Name = "Widthlab"
			Dim control3 As Global.System.Windows.Forms.Control = Widthlab
			Dim size As Global.System.Drawing.Size = New Global.System.Drawing.Size(100, 20)
			control3.Size = size
			Widthlab.TabIndex = 3
			Widthlab.Text = "Width (mm)"
			Pitlab.AutoSize = True
			Pitlab.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 12F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 161)
			Dim control4 As Global.System.Windows.Forms.Control = Pitlab
			location = New Global.System.Drawing.Point(75, 81)
			control4.Location = location
			Dim control5 As Global.System.Windows.Forms.Control = Pitlab
			margin = New Global.System.Windows.Forms.Padding(4, 0, 4, 0)
			control5.Margin = margin
			Pitlab.Name = "Pitlab"
			Dim control6 As Global.System.Windows.Forms.Control = Pitlab
			size = New Global.System.Drawing.Size(94, 20)
			control6.Size = size
			Pitlab.TabIndex = 7
			Pitlab.Text = "Pitch (mm)"
			Label.AutoSize = True
			Label.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 12F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 161)
			Dim control7 As Global.System.Windows.Forms.Control = Label
			location = New Global.System.Drawing.Point(7, 30)
			control7.Location = location
			Dim control8 As Global.System.Windows.Forms.Control = Label
			margin = New Global.System.Windows.Forms.Padding(4, 0, 4, 0)
			control8.Margin = margin
			Label.Name = "Label1"
			Dim control9 As Global.System.Windows.Forms.Control = Label
			size = New Global.System.Drawing.Size(165, 20)
			control9.Size = size
			Label.TabIndex = 7
			Label.Text = "Meander Amp (mm)"
			Label2.AutoSize = True
			Label2.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 12F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 161)
			Dim control10 As Global.System.Windows.Forms.Control = Label2
			location = New Global.System.Drawing.Point(3, 77)
			control10.Location = location
			Dim control11 As Global.System.Windows.Forms.Control = Label2
			margin = New Global.System.Windows.Forms.Padding(4, 0, 4, 0)
			control11.Margin = margin
			Label2.Name = "Label5"
			Dim control12 As Global.System.Windows.Forms.Control = Label2
			size = New Global.System.Drawing.Size(169, 20)
			control12.Size = size
			Label2.TabIndex = 20
			Label2.Text = "Meander Pitch (mm)"
			Label3.AutoSize = True
			Label3.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 12F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 161)
			Dim control13 As Global.System.Windows.Forms.Control = Label3
			location = New Global.System.Drawing.Point(23, 127)
			control13.Location = location
			Dim control14 As Global.System.Windows.Forms.Control = Label3
			margin = New Global.System.Windows.Forms.Padding(4, 0, 4, 0)
			control14.Margin = margin
			Label3.Name = "Label6"
			Dim control15 As Global.System.Windows.Forms.Control = Label3
			size = New Global.System.Drawing.Size(143, 20)
			control15.Size = size
			Label3.TabIndex = 9
			Label3.Text = "Tool Offset (mm)"
			Label4.AutoSize = True
			Label4.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 12F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 161)
			Dim control16 As Global.System.Windows.Forms.Control = Label4
			location = New Global.System.Drawing.Point(1, 25)
			control16.Location = location
			Dim control17 As Global.System.Windows.Forms.Control = Label4
			margin = New Global.System.Windows.Forms.Padding(4, 0, 4, 0)
			control17.Margin = margin
			Label4.Name = "Label15"
			Dim control18 As Global.System.Windows.Forms.Control = Label4
			size = New Global.System.Drawing.Size(168, 20)
			control18.Size = size
			Label4.TabIndex = 4
			Label4.Text = "Station Angle (Deg)"
			Label5.AutoSize = True
			Label5.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 12F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 161)
			Dim control19 As Global.System.Windows.Forms.Control = Label5
			location = New Global.System.Drawing.Point(16, 172)
			control19.Location = location
			Dim control20 As Global.System.Windows.Forms.Control = Label5
			margin = New Global.System.Windows.Forms.Padding(4, 0, 4, 0)
			control20.Margin = margin
			Label5.Name = "Label2"
			Dim control21 As Global.System.Windows.Forms.Control = Label5
			size = New Global.System.Drawing.Size(152, 20)
			control21.Size = size
			Label5.TabIndex = 30
			Label5.Text = "Number of Copies"
			Label6.AutoSize = True
			Label6.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 12F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 161)
			Dim control22 As Global.System.Windows.Forms.Control = Label6
			location = New Global.System.Drawing.Point(29, 217)
			control22.Location = location
			Dim control23 As Global.System.Windows.Forms.Control = Label6
			margin = New Global.System.Windows.Forms.Padding(4, 0, 4, 0)
			control23.Margin = margin
			Label6.Name = "Label3"
			Dim control24 As Global.System.Windows.Forms.Control = Label6
			size = New Global.System.Drawing.Size(136, 20)
			control24.Size = size
			Label6.TabIndex = 32
			Label6.Text = "Rec. Pitch (mm)"
			Label7.AutoSize = True
			Label7.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 12F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 161)
			Dim control25 As Global.System.Windows.Forms.Control = Label7
			location = New Global.System.Drawing.Point(26, 264)
			control25.Location = location
			Dim control26 As Global.System.Windows.Forms.Control = Label7
			margin = New Global.System.Windows.Forms.Padding(4, 0, 4, 0)
			control26.Margin = margin
			Label7.Name = "Label4"
			Dim control27 As Global.System.Windows.Forms.Control = Label7
			size = New Global.System.Drawing.Size(138, 20)
			control27.Size = size
			Label7.TabIndex = 34
			Label7.Text = "Ang. Pitch (deg)"
			Me.Widthtxt.Font = New Global.System.Drawing.Font("Arial", 12F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 161)
			Dim widthtxt As Global.System.Windows.Forms.Control = Me.Widthtxt
			location = New Global.System.Drawing.Point(169, 30)
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
			Me.Pittxt.Font = New Global.System.Drawing.Font("Arial", 12F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 161)
			Dim pittxt As Global.System.Windows.Forms.Control = Me.Pittxt
			location = New Global.System.Drawing.Point(169, 77)
			pittxt.Location = location
			Dim pittxt2 As Global.System.Windows.Forms.Control = Me.Pittxt
			margin = New Global.System.Windows.Forms.Padding(4, 5, 4, 5)
			pittxt2.Margin = margin
			Me.Pittxt.Name = "Pittxt"
			Dim pittxt3 As Global.System.Windows.Forms.Control = Me.Pittxt
			size = New Global.System.Drawing.Size(60, 26)
			pittxt3.Size = size
			Me.Pittxt.TabIndex = 3
			Me.Pittxt.Text = "3.2"
			Me.Pittxt.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
			Me.GroupBox2.Controls.Add(Label3)
			Me.GroupBox2.Controls.Add(Me.Tooloffsettxt)
			Me.GroupBox2.Controls.Add(Pitlab)
			Me.GroupBox2.Controls.Add(Me.Pittxt)
			Me.GroupBox2.Controls.Add(Me.Widthtxt)
			Me.GroupBox2.Controls.Add(Widthlab)
			Me.GroupBox2.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 9.75F, Global.System.Drawing.FontStyle.Bold Or Global.System.Drawing.FontStyle.Italic, Global.System.Drawing.GraphicsUnit.Point, 161)
			Dim groupBox As Global.System.Windows.Forms.Control = Me.GroupBox2
			location = New Global.System.Drawing.Point(50, 30)
			groupBox.Location = location
			Me.GroupBox2.Name = "GroupBox2"
			Dim groupBox2 As Global.System.Windows.Forms.Control = Me.GroupBox2
			size = New Global.System.Drawing.Size(250, 170)
			groupBox2.Size = size
			Me.GroupBox2.TabIndex = 0
			Me.GroupBox2.TabStop = False
			Me.GroupBox2.Text = "Basic Geometrical Parameters"
			Me.Tooloffsettxt.Font = New Global.System.Drawing.Font("Arial", 12F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 161)
			Dim tooloffsettxt As Global.System.Windows.Forms.Control = Me.Tooloffsettxt
			location = New Global.System.Drawing.Point(169, 124)
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
			location = New Global.System.Drawing.Point(695, 402)
			cnfrmbtn.Location = location
			Me.Cnfrmbtn.Name = "Cnfrmbtn"
			Dim cnfrmbtn2 As Global.System.Windows.Forms.Control = Me.Cnfrmbtn
			size = New Global.System.Drawing.Size(85, 26)
			cnfrmbtn2.Size = size
			Me.Cnfrmbtn.TabIndex = 20
			Me.Cnfrmbtn.Text = "Confirm"
			Me.Cnfrmbtn.TextAlign = Global.System.Drawing.ContentAlignment.TopCenter
			Me.Cnfrmbtn.UseVisualStyleBackColor = True
			Me.Cnlbtn.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 11.25F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 161)
			Dim cnlbtn As Global.System.Windows.Forms.Control = Me.Cnlbtn
			location = New Global.System.Drawing.Point(820, 402)
			cnlbtn.Location = location
			Me.Cnlbtn.Name = "Cnlbtn"
			Dim cnlbtn2 As Global.System.Windows.Forms.Control = Me.Cnlbtn
			size = New Global.System.Drawing.Size(85, 26)
			cnlbtn2.Size = size
			Me.Cnlbtn.TabIndex = 21
			Me.Cnlbtn.Text = "Cancel"
			Me.Cnlbtn.TextAlign = Global.System.Drawing.ContentAlignment.TopCenter
			Me.Cnlbtn.UseVisualStyleBackColor = True
			Me.GroupBox3.Controls.Add(Label2)
			Me.GroupBox3.Controls.Add(Me.Meandrptc)
			Me.GroupBox3.Controls.Add(Me.MeandrFlg)
			Me.GroupBox3.Controls.Add(Label)
			Me.GroupBox3.Controls.Add(Me.Meandramp)
			Me.GroupBox3.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 9.75F, Global.System.Drawing.FontStyle.Bold Or Global.System.Drawing.FontStyle.Italic, Global.System.Drawing.GraphicsUnit.Point, 161)
			Dim groupBox3 As Global.System.Windows.Forms.Control = Me.GroupBox3
			location = New Global.System.Drawing.Point(360, 261)
			groupBox3.Location = location
			Me.GroupBox3.Name = "GroupBox3"
			Dim groupBox4 As Global.System.Windows.Forms.Control = Me.GroupBox3
			size = New Global.System.Drawing.Size(252, 176)
			groupBox4.Size = size
			Me.GroupBox3.TabIndex = 6
			Me.GroupBox3.TabStop = False
			Me.GroupBox3.Text = "Extra Geometrical Parameters"
			Me.Meandrptc.Font = New Global.System.Drawing.Font("Arial", 12F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 161)
			Dim meandrptc As Global.System.Windows.Forms.Control = Me.Meandrptc
			location = New Global.System.Drawing.Point(172, 76)
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
			Me.MeandrFlg.AutoSize = True
			Dim meandrFlg As Global.System.Windows.Forms.Control = Me.MeandrFlg
			location = New Global.System.Drawing.Point(55, 131)
			meandrFlg.Location = location
			Me.MeandrFlg.Name = "MeandrFlg"
			Dim meandrFlg2 As Global.System.Windows.Forms.Control = Me.MeandrFlg
			size = New Global.System.Drawing.Size(163, 20)
			meandrFlg2.Size = size
			Me.MeandrFlg.TabIndex = 7
			Me.MeandrFlg.Text = "Meander Movement"
			Me.MeandrFlg.UseVisualStyleBackColor = True
			Me.Meandramp.Font = New Global.System.Drawing.Font("Arial", 12F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 161)
			Dim meandramp As Global.System.Windows.Forms.Control = Me.Meandramp
			location = New Global.System.Drawing.Point(172, 29)
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
			Me.CurrPosStat.AutoSize = True
			Dim currPosStat As Global.System.Windows.Forms.Control = Me.CurrPosStat
			location = New Global.System.Drawing.Point(59, 22)
			currPosStat.Location = location
			Me.CurrPosStat.Name = "CurrPosStat"
			Dim currPosStat2 As Global.System.Windows.Forms.Control = Me.CurrPosStat
			size = New Global.System.Drawing.Size(141, 21)
			currPosStat2.Size = size
			Me.CurrPosStat.TabIndex = 8
			Me.CurrPosStat.Text = "Position Upload"
			Me.CurrPosStat.UseVisualStyleBackColor = True
			Me.GroupBox1.Controls.Add(Label4)
			Me.GroupBox1.Controls.Add(Me.Stationslct)
			Me.GroupBox1.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 10F, Global.System.Drawing.FontStyle.Bold Or Global.System.Drawing.FontStyle.Italic, Global.System.Drawing.GraphicsUnit.Point, 161)
			Dim groupBox5 As Global.System.Windows.Forms.Control = Me.GroupBox1
			location = New Global.System.Drawing.Point(50, 207)
			groupBox5.Location = location
			Me.GroupBox1.Name = "GroupBox1"
			Dim groupBox6 As Global.System.Windows.Forms.Control = Me.GroupBox1
			size = New Global.System.Drawing.Size(250, 65)
			groupBox6.Size = size
			Me.GroupBox1.TabIndex = 1
			Me.GroupBox1.TabStop = False
			Me.GroupBox1.Text = "Station Position"
			Me.Stationslct.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 12F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 161)
			Me.Stationslct.FormattingEnabled = True
			Me.Stationslct.IntegralHeight = False
			Me.Stationslct.ItemHeight = 20
			Me.Stationslct.Items.AddRange(New Object() { "0", "30", "45", "60", "90" })
			Dim stationslct As Global.System.Windows.Forms.Control = Me.Stationslct
			location = New Global.System.Drawing.Point(170, 22)
			stationslct.Location = location
			Me.Stationslct.Name = "Stationslct"
			Dim stationslct2 As Global.System.Windows.Forms.Control = Me.Stationslct
			size = New Global.System.Drawing.Size(60, 26)
			stationslct2.Size = size
			Me.Stationslct.TabIndex = 0
			Me.CladDirSelection.Controls.Add(Me.Rightdirflg)
			Me.CladDirSelection.Controls.Add(Me.Leftdirflg)
			Me.CladDirSelection.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 10F, Global.System.Drawing.FontStyle.Bold Or Global.System.Drawing.FontStyle.Italic, Global.System.Drawing.GraphicsUnit.Point, 161)
			Dim cladDirSelection As Global.System.Windows.Forms.Control = Me.CladDirSelection
			location = New Global.System.Drawing.Point(50, 278)
			cladDirSelection.Location = location
			Me.CladDirSelection.Name = "CladDirSelection"
			Dim cladDirSelection2 As Global.System.Windows.Forms.Control = Me.CladDirSelection
			size = New Global.System.Drawing.Size(250, 65)
			cladDirSelection2.Size = size
			Me.CladDirSelection.TabIndex = 2
			Me.CladDirSelection.TabStop = False
			Me.CladDirSelection.Text = "Cladding Direction"
			Me.Rightdirflg.AutoSize = True
			Me.Rightdirflg.Checked = True
			Me.Rightdirflg.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 12F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 161)
			Dim rightdirflg As Global.System.Windows.Forms.Control = Me.Rightdirflg
			location = New Global.System.Drawing.Point(145, 26)
			rightdirflg.Location = location
			Me.Rightdirflg.Name = "Rightdirflg"
			Dim rightdirflg2 As Global.System.Windows.Forms.Control = Me.Rightdirflg
			size = New Global.System.Drawing.Size(92, 24)
			rightdirflg2.Size = size
			Me.Rightdirflg.TabIndex = 1
			Me.Rightdirflg.TabStop = True
			Me.Rightdirflg.Text = "Forward"
			Me.Rightdirflg.UseVisualStyleBackColor = True
			Me.Leftdirflg.AutoSize = True
			Me.Leftdirflg.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 12F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 161)
			Dim leftdirflg As Global.System.Windows.Forms.Control = Me.Leftdirflg
			location = New Global.System.Drawing.Point(34, 26)
			leftdirflg.Location = location
			Me.Leftdirflg.Name = "Leftdirflg"
			Dim leftdirflg2 As Global.System.Windows.Forms.Control = Me.Leftdirflg
			size = New Global.System.Drawing.Size(93, 24)
			leftdirflg2.Size = size
			Me.Leftdirflg.TabIndex = 0
			Me.Leftdirflg.Text = "Reverse"
			Me.Leftdirflg.UseVisualStyleBackColor = True
			Me.FocLengthSelection.Controls.Add(Me.Movement)
			Me.FocLengthSelection.Controls.Add(Me.CurrPosStat)
			Me.FocLengthSelection.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 10F, Global.System.Drawing.FontStyle.Bold Or Global.System.Drawing.FontStyle.Italic, Global.System.Drawing.GraphicsUnit.Point, 161)
			Dim focLengthSelection As Global.System.Windows.Forms.Control = Me.FocLengthSelection
			location = New Global.System.Drawing.Point(50, 349)
			focLengthSelection.Location = location
			Me.FocLengthSelection.Name = "FocLengthSelection"
			Dim focLengthSelection2 As Global.System.Windows.Forms.Control = Me.FocLengthSelection
			size = New Global.System.Drawing.Size(250, 88)
			focLengthSelection2.Size = size
			Me.FocLengthSelection.TabIndex = 3
			Me.FocLengthSelection.TabStop = False
			Me.FocLengthSelection.Text = "Position Details"
			Me.Movement.FormattingEnabled = True
			Dim movement As Global.System.Windows.Forms.Control = Me.Movement
			location = New Global.System.Drawing.Point(8, 52)
			movement.Location = location
			Me.Movement.Name = "Movement"
			Dim movement2 As Global.System.Windows.Forms.Control = Me.Movement
			size = New Global.System.Drawing.Size(234, 24)
			movement2.Size = size
			Me.Movement.TabIndex = 10
			Me.MovDirSelection.Controls.Add(Me.SpinDirMov)
			Me.MovDirSelection.Controls.Add(Me.ZDirMov)
			Me.MovDirSelection.Controls.Add(Me.YDirMov)
			Me.MovDirSelection.Controls.Add(Me.XDirMov)
			Me.MovDirSelection.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 9.75F, Global.System.Drawing.FontStyle.Bold Or Global.System.Drawing.FontStyle.Italic, Global.System.Drawing.GraphicsUnit.Point, 161)
			Dim movDirSelection As Global.System.Windows.Forms.Control = Me.MovDirSelection
			location = New Global.System.Drawing.Point(362, 30)
			movDirSelection.Location = location
			Me.MovDirSelection.Name = "MovDirSelection"
			Dim movDirSelection2 As Global.System.Windows.Forms.Control = Me.MovDirSelection
			size = New Global.System.Drawing.Size(250, 170)
			movDirSelection2.Size = size
			Me.MovDirSelection.TabIndex = 4
			Me.MovDirSelection.TabStop = False
			Me.MovDirSelection.Text = "Overlay Movement"
			Me.SpinDirMov.AutoSize = True
			Me.SpinDirMov.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 12F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 161)
			Dim spinDirMov As Global.System.Windows.Forms.Control = Me.SpinDirMov
			location = New Global.System.Drawing.Point(53, 119)
			spinDirMov.Location = location
			Me.SpinDirMov.Name = "SpinDirMov"
			Dim spinDirMov2 As Global.System.Windows.Forms.Control = Me.SpinDirMov
			size = New Global.System.Drawing.Size(128, 44)
			spinDirMov2.Size = size
			Me.SpinDirMov.TabIndex = 28
			Me.SpinDirMov.Text = "Spindle Circ." & Global.System.Environment.NewLine & " Direction"
			Me.SpinDirMov.UseVisualStyleBackColor = True
			Me.ZDirMov.AutoSize = True
			Me.ZDirMov.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 12F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 161)
			Dim zdirMov As Global.System.Windows.Forms.Control = Me.ZDirMov
			location = New Global.System.Drawing.Point(53, 89)
			zdirMov.Location = location
			Me.ZDirMov.Name = "ZDirMov"
			Dim zdirMov2 As Global.System.Windows.Forms.Control = Me.ZDirMov
			size = New Global.System.Drawing.Size(115, 24)
			zdirMov2.Size = size
			Me.ZDirMov.TabIndex = 27
			Me.ZDirMov.Text = "Z Direction"
			Me.ZDirMov.UseVisualStyleBackColor = True
			Me.YDirMov.AutoSize = True
			Me.YDirMov.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 12F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 161)
			Dim ydirMov As Global.System.Windows.Forms.Control = Me.YDirMov
			location = New Global.System.Drawing.Point(53, 59)
			ydirMov.Location = location
			Me.YDirMov.Name = "YDirMov"
			Dim ydirMov2 As Global.System.Windows.Forms.Control = Me.YDirMov
			size = New Global.System.Drawing.Size(116, 24)
			ydirMov2.Size = size
			Me.YDirMov.TabIndex = 26
			Me.YDirMov.Text = "Y Direction"
			Me.YDirMov.UseVisualStyleBackColor = True
			Me.XDirMov.AutoSize = True
			Me.XDirMov.Checked = True
			Me.XDirMov.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 12F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 161)
			Dim xdirMov As Global.System.Windows.Forms.Control = Me.XDirMov
			location = New Global.System.Drawing.Point(53, 29)
			xdirMov.Location = location
			Me.XDirMov.Name = "XDirMov"
			Dim xdirMov2 As Global.System.Windows.Forms.Control = Me.XDirMov
			size = New Global.System.Drawing.Size(116, 24)
			xdirMov2.Size = size
			Me.XDirMov.TabIndex = 25
			Me.XDirMov.TabStop = True
			Me.XDirMov.Text = "X Direction"
			Me.XDirMov.UseVisualStyleBackColor = True
			Me.ArrayDirSelection.Controls.Add(Me.Arrayangptctxt)
			Me.ArrayDirSelection.Controls.Add(Label7)
			Me.ArrayDirSelection.Controls.Add(Me.Arrayrecptctxt)
			Me.ArrayDirSelection.Controls.Add(Label6)
			Me.ArrayDirSelection.Controls.Add(Me.Copiestxt)
			Me.ArrayDirSelection.Controls.Add(Label5)
			Me.ArrayDirSelection.Controls.Add(Me.SpinDirArr)
			Me.ArrayDirSelection.Controls.Add(Me.ZDirArr)
			Me.ArrayDirSelection.Controls.Add(Me.YDirArr)
			Me.ArrayDirSelection.Controls.Add(Me.XDirArr)
			Me.ArrayDirSelection.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 9.75F, Global.System.Drawing.FontStyle.Bold Or Global.System.Drawing.FontStyle.Italic, Global.System.Drawing.GraphicsUnit.Point, 161)
			Dim arrayDirSelection As Global.System.Windows.Forms.Control = Me.ArrayDirSelection
			location = New Global.System.Drawing.Point(675, 30)
			arrayDirSelection.Location = location
			Me.ArrayDirSelection.Name = "ArrayDirSelection"
			Dim arrayDirSelection2 As Global.System.Windows.Forms.Control = Me.ArrayDirSelection
			size = New Global.System.Drawing.Size(250, 298)
			arrayDirSelection2.Size = size
			Me.ArrayDirSelection.TabIndex = 7
			Me.ArrayDirSelection.TabStop = False
			Me.ArrayDirSelection.Text = "Array Parameters"
			Me.Arrayangptctxt.Font = New Global.System.Drawing.Font("Arial", 12F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 161)
			Dim arrayangptctxt As Global.System.Windows.Forms.Control = Me.Arrayangptctxt
			location = New Global.System.Drawing.Point(168, 261)
			arrayangptctxt.Location = location
			Dim arrayangptctxt2 As Global.System.Windows.Forms.Control = Me.Arrayangptctxt
			margin = New Global.System.Windows.Forms.Padding(4, 5, 4, 5)
			arrayangptctxt2.Margin = margin
			Me.Arrayangptctxt.Name = "Arrayangptctxt"
			Dim arrayangptctxt3 As Global.System.Windows.Forms.Control = Me.Arrayangptctxt
			size = New Global.System.Drawing.Size(60, 26)
			arrayangptctxt3.Size = size
			Me.Arrayangptctxt.TabIndex = 33
			Me.Arrayangptctxt.Text = "15.0"
			Me.Arrayangptctxt.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
			Me.Arrayrecptctxt.Font = New Global.System.Drawing.Font("Arial", 12F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 161)
			Dim arrayrecptctxt As Global.System.Windows.Forms.Control = Me.Arrayrecptctxt
			location = New Global.System.Drawing.Point(168, 214)
			arrayrecptctxt.Location = location
			Dim arrayrecptctxt2 As Global.System.Windows.Forms.Control = Me.Arrayrecptctxt
			margin = New Global.System.Windows.Forms.Padding(4, 5, 4, 5)
			arrayrecptctxt2.Margin = margin
			Me.Arrayrecptctxt.Name = "Arrayrecptctxt"
			Dim arrayrecptctxt3 As Global.System.Windows.Forms.Control = Me.Arrayrecptctxt
			size = New Global.System.Drawing.Size(60, 26)
			arrayrecptctxt3.Size = size
			Me.Arrayrecptctxt.TabIndex = 31
			Me.Arrayrecptctxt.Text = "100.0"
			Me.Arrayrecptctxt.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
			Me.Copiestxt.Font = New Global.System.Drawing.Font("Arial", 12F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 161)
			Dim copiestxt As Global.System.Windows.Forms.Control = Me.Copiestxt
			location = New Global.System.Drawing.Point(169, 169)
			copiestxt.Location = location
			Dim copiestxt2 As Global.System.Windows.Forms.Control = Me.Copiestxt
			margin = New Global.System.Windows.Forms.Padding(4, 5, 4, 5)
			copiestxt2.Margin = margin
			Me.Copiestxt.Name = "Copiestxt"
			Dim copiestxt3 As Global.System.Windows.Forms.Control = Me.Copiestxt
			size = New Global.System.Drawing.Size(60, 26)
			copiestxt3.Size = size
			Me.Copiestxt.TabIndex = 29
			Me.Copiestxt.Text = "1"
			Me.Copiestxt.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
			Me.SpinDirArr.AutoSize = True
			Me.SpinDirArr.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 12F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 161)
			Dim spinDirArr As Global.System.Windows.Forms.Control = Me.SpinDirArr
			location = New Global.System.Drawing.Point(53, 119)
			spinDirArr.Location = location
			Me.SpinDirArr.Name = "SpinDirArr"
			Dim spinDirArr2 As Global.System.Windows.Forms.Control = Me.SpinDirArr
			size = New Global.System.Drawing.Size(128, 44)
			spinDirArr2.Size = size
			Me.SpinDirArr.TabIndex = 28
			Me.SpinDirArr.Text = "Spindle Circ." & Global.System.Environment.NewLine & " Direction"
			Me.SpinDirArr.UseVisualStyleBackColor = True
			Me.ZDirArr.AutoSize = True
			Me.ZDirArr.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 12F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 161)
			Dim zdirArr As Global.System.Windows.Forms.Control = Me.ZDirArr
			location = New Global.System.Drawing.Point(53, 89)
			zdirArr.Location = location
			Me.ZDirArr.Name = "ZDirArr"
			Dim zdirArr2 As Global.System.Windows.Forms.Control = Me.ZDirArr
			size = New Global.System.Drawing.Size(115, 24)
			zdirArr2.Size = size
			Me.ZDirArr.TabIndex = 27
			Me.ZDirArr.Text = "Z Direction"
			Me.ZDirArr.UseVisualStyleBackColor = True
			Me.YDirArr.AutoSize = True
			Me.YDirArr.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 12F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 161)
			Dim ydirArr As Global.System.Windows.Forms.Control = Me.YDirArr
			location = New Global.System.Drawing.Point(53, 59)
			ydirArr.Location = location
			Me.YDirArr.Name = "YDirArr"
			Dim ydirArr2 As Global.System.Windows.Forms.Control = Me.YDirArr
			size = New Global.System.Drawing.Size(116, 24)
			ydirArr2.Size = size
			Me.YDirArr.TabIndex = 26
			Me.YDirArr.Text = "Y Direction"
			Me.YDirArr.UseVisualStyleBackColor = True
			Me.XDirArr.AutoSize = True
			Me.XDirArr.Checked = True
			Me.XDirArr.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 12F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 161)
			Dim xdirArr As Global.System.Windows.Forms.Control = Me.XDirArr
			location = New Global.System.Drawing.Point(53, 29)
			xdirArr.Location = location
			Me.XDirArr.Name = "XDirArr"
			Dim xdirArr2 As Global.System.Windows.Forms.Control = Me.XDirArr
			size = New Global.System.Drawing.Size(116, 24)
			xdirArr2.Size = size
			Me.XDirArr.TabIndex = 25
			Me.XDirArr.TabStop = True
			Me.XDirArr.Text = "X Direction"
			Me.XDirArr.UseVisualStyleBackColor = True
			Me.Overlaymovdir.Controls.Add(Me.Posmov)
			Me.Overlaymovdir.Controls.Add(Me.Negmov)
			Me.Overlaymovdir.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 9.75F, Global.System.Drawing.FontStyle.Bold Or Global.System.Drawing.FontStyle.Italic, Global.System.Drawing.GraphicsUnit.Point, 161)
			Dim overlaymovdir As Global.System.Windows.Forms.Control = Me.Overlaymovdir
			location = New Global.System.Drawing.Point(362, 204)
			overlaymovdir.Location = location
			Me.Overlaymovdir.Name = "Overlaymovdir"
			Dim overlaymovdir2 As Global.System.Windows.Forms.Control = Me.Overlaymovdir
			size = New Global.System.Drawing.Size(250, 51)
			overlaymovdir2.Size = size
			Me.Overlaymovdir.TabIndex = 5
			Me.Overlaymovdir.TabStop = False
			Me.Overlaymovdir.Text = "Overlay Direction"
			Me.Posmov.AutoSize = True
			Me.Posmov.Checked = True
			Me.Posmov.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 12F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 161)
			Dim posmov As Global.System.Windows.Forms.Control = Me.Posmov
			location = New Global.System.Drawing.Point(148, 21)
			posmov.Location = location
			Me.Posmov.Name = "Posmov"
			Dim posmov2 As Global.System.Windows.Forms.Control = Me.Posmov
			size = New Global.System.Drawing.Size(55, 24)
			posmov2.Size = size
			Me.Posmov.TabIndex = 26
			Me.Posmov.TabStop = True
			Me.Posmov.Text = "+ve"
			Me.Posmov.UseVisualStyleBackColor = True
			Me.Negmov.AutoSize = True
			Me.Negmov.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 12F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 161)
			Dim negmov As Global.System.Windows.Forms.Control = Me.Negmov
			location = New Global.System.Drawing.Point(53, 21)
			negmov.Location = location
			Me.Negmov.Name = "Negmov"
			Dim negmov2 As Global.System.Windows.Forms.Control = Me.Negmov
			size = New Global.System.Drawing.Size(51, 24)
			negmov2.Size = size
			Me.Negmov.TabIndex = 25
			Me.Negmov.Text = "-ve"
			Me.Negmov.UseVisualStyleBackColor = True
			Me.Arraymovdir.Controls.Add(Me.Posarr)
			Me.Arraymovdir.Controls.Add(Me.Negarr)
			Me.Arraymovdir.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 9.75F, Global.System.Drawing.FontStyle.Bold Or Global.System.Drawing.FontStyle.Italic, Global.System.Drawing.GraphicsUnit.Point, 161)
			Dim arraymovdir As Global.System.Windows.Forms.Control = Me.Arraymovdir
			location = New Global.System.Drawing.Point(675, 334)
			arraymovdir.Location = location
			Me.Arraymovdir.Name = "Arraymovdir"
			Dim arraymovdir2 As Global.System.Windows.Forms.Control = Me.Arraymovdir
			size = New Global.System.Drawing.Size(250, 51)
			arraymovdir2.Size = size
			Me.Arraymovdir.TabIndex = 8
			Me.Arraymovdir.TabStop = False
			Me.Arraymovdir.Text = "Array Direction"
			Me.Posarr.AutoSize = True
			Me.Posarr.Checked = True
			Me.Posarr.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 12F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 161)
			Dim posarr As Global.System.Windows.Forms.Control = Me.Posarr
			location = New Global.System.Drawing.Point(148, 21)
			posarr.Location = location
			Me.Posarr.Name = "Posarr"
			Dim posarr2 As Global.System.Windows.Forms.Control = Me.Posarr
			size = New Global.System.Drawing.Size(55, 24)
			posarr2.Size = size
			Me.Posarr.TabIndex = 26
			Me.Posarr.TabStop = True
			Me.Posarr.Text = "+ve"
			Me.Posarr.UseVisualStyleBackColor = True
			Me.Negarr.AutoSize = True
			Me.Negarr.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 12F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 161)
			Dim negarr As Global.System.Windows.Forms.Control = Me.Negarr
			location = New Global.System.Drawing.Point(53, 21)
			negarr.Location = location
			Me.Negarr.Name = "Negarr"
			Dim negarr2 As Global.System.Windows.Forms.Control = Me.Negarr
			size = New Global.System.Drawing.Size(51, 24)
			negarr2.Size = size
			Me.Negarr.TabIndex = 25
			Me.Negarr.Text = "-ve"
			Me.Negarr.UseVisualStyleBackColor = True
			Dim autoScaleDimensions As Global.System.Drawing.SizeF = New Global.System.Drawing.SizeF(9F, 20F)
			Me.AutoScaleDimensions = autoScaleDimensions
			Me.AutoScaleMode = Global.System.Windows.Forms.AutoScaleMode.Font
			Me.AutoSize = True
			size = New Global.System.Drawing.Size(984, 462)
			Me.ClientSize = size
			Me.Controls.Add(Me.Arraymovdir)
			Me.Controls.Add(Me.Overlaymovdir)
			Me.Controls.Add(Me.ArrayDirSelection)
			Me.Controls.Add(Me.MovDirSelection)
			Me.Controls.Add(Me.FocLengthSelection)
			Me.Controls.Add(Me.CladDirSelection)
			Me.Controls.Add(Me.GroupBox1)
			Me.Controls.Add(Me.GroupBox3)
			Me.Controls.Add(Me.Cnlbtn)
			Me.Controls.Add(Me.Cnfrmbtn)
			Me.Controls.Add(Me.GroupBox2)
			Me.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 12F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 161)
			margin = New Global.System.Windows.Forms.Padding(4, 5, 4, 5)
			Me.Margin = margin
			Me.Name = "THREEDCLADPARAM"
			Me.Text = "3D Clad Parameters"
			Me.GroupBox2.ResumeLayout(False)
			Me.GroupBox2.PerformLayout()
			Me.GroupBox3.ResumeLayout(False)
			Me.GroupBox3.PerformLayout()
			Me.GroupBox1.ResumeLayout(False)
			Me.GroupBox1.PerformLayout()
			Me.CladDirSelection.ResumeLayout(False)
			Me.CladDirSelection.PerformLayout()
			Me.FocLengthSelection.ResumeLayout(False)
			Me.FocLengthSelection.PerformLayout()
			Me.MovDirSelection.ResumeLayout(False)
			Me.MovDirSelection.PerformLayout()
			Me.ArrayDirSelection.ResumeLayout(False)
			Me.ArrayDirSelection.PerformLayout()
			Me.Overlaymovdir.ResumeLayout(False)
			Me.Overlaymovdir.PerformLayout()
			Me.Arraymovdir.ResumeLayout(False)
			Me.Arraymovdir.PerformLayout()
			Me.ResumeLayout(False)
		End Sub

		' Token: 0x0400001A RID: 26
		Private components As Global.System.ComponentModel.IContainer
	End Class
End Namespace
