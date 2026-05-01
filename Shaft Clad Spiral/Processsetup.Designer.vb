Namespace WindowsApplication1
	' Token: 0x0200001F RID: 31
	<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
	Public Partial Class Processsetup
		Inherits Global.System.Windows.Forms.Form

		' Token: 0x060005B3 RID: 1459 RVA: 0x0004A3CC File Offset: 0x000487CC
		<Global.System.Diagnostics.DebuggerNonUserCode()>
		Protected Overrides Sub Dispose(disposing As Boolean)
			If disposing AndAlso Me.components IsNot Nothing Then
				Me.components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		' Token: 0x060005B4 RID: 1460 RVA: 0x0004A3EC File Offset: 0x000487EC
		<Global.System.Diagnostics.DebuggerStepThrough()>
		Private Sub InitializeComponent()
			Me.GroupBox1 = New Global.System.Windows.Forms.GroupBox()
			Me.Finpowderredtxt = New Global.System.Windows.Forms.TextBox()
			Me.Inipowderredtxt = New Global.System.Windows.Forms.TextBox()
			Me.Finoverpowdistxt = New Global.System.Windows.Forms.TextBox()
			Me.Finoverpowertxt = New Global.System.Windows.Forms.TextBox()
			Me.Inioverpowdistxt = New Global.System.Windows.Forms.TextBox()
			Me.Inioverpowertxt = New Global.System.Windows.Forms.TextBox()
			Me.Lsrrdtrctxt = New Global.System.Windows.Forms.TextBox()
			Me.Lsrpfintxt = New Global.System.Windows.Forms.TextBox()
			Me.Beamdiatxt = New Global.System.Windows.Forms.TextBox()
			Me.Procsp = New Global.System.Windows.Forms.TextBox()
			Me.Lsrpinitxt = New Global.System.Windows.Forms.TextBox()
			Me.Powdjtxt = New Global.System.Windows.Forms.TextBox()
			Me.Powdftxt = New Global.System.Windows.Forms.TextBox()
			Me.Cnlbtn = New Global.System.Windows.Forms.Button()
			Me.Cnfrmbtn = New Global.System.Windows.Forms.Button()
			Dim Powdjlab As Global.System.Windows.Forms.Label = New Global.System.Windows.Forms.Label()
			Dim Lsrplab As Global.System.Windows.Forms.Label = New Global.System.Windows.Forms.Label()
			Dim Powdflab As Global.System.Windows.Forms.Label = New Global.System.Windows.Forms.Label()
			Dim Label6 As Global.System.Windows.Forms.Label = New Global.System.Windows.Forms.Label()
			Dim Label7 As Global.System.Windows.Forms.Label = New Global.System.Windows.Forms.Label()
			Dim Label8 As Global.System.Windows.Forms.Label = New Global.System.Windows.Forms.Label()
			Dim Label9 As Global.System.Windows.Forms.Label = New Global.System.Windows.Forms.Label()
			Dim Label10 As Global.System.Windows.Forms.Label = New Global.System.Windows.Forms.Label()
			Dim Label11 As Global.System.Windows.Forms.Label = New Global.System.Windows.Forms.Label()
			Dim Label12 As Global.System.Windows.Forms.Label = New Global.System.Windows.Forms.Label()
			Dim Label13 As Global.System.Windows.Forms.Label = New Global.System.Windows.Forms.Label()
			Dim Label14 As Global.System.Windows.Forms.Label = New Global.System.Windows.Forms.Label()
			Dim Label15 As Global.System.Windows.Forms.Label = New Global.System.Windows.Forms.Label()
			Me.GroupBox1.SuspendLayout()
			Me.SuspendLayout()
			Powdjlab.AutoSize = True
			Powdjlab.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 12F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 161)
			Dim control As Global.System.Windows.Forms.Control = Powdjlab
			Dim location As Global.System.Drawing.Point = New Global.System.Drawing.Point(310, 72)
			control.Location = location
			Dim control2 As Global.System.Windows.Forms.Control = Powdjlab
			Dim margin As Global.System.Windows.Forms.Padding = New Global.System.Windows.Forms.Padding(4, 0, 4, 0)
			control2.Margin = margin
			Powdjlab.Name = "Powdjlab"
			Dim control3 As Global.System.Windows.Forms.Control = Powdjlab
			Dim size As Global.System.Drawing.Size = New Global.System.Drawing.Size(161, 20)
			control3.Size = size
			Powdjlab.TabIndex = 13
			Powdjlab.Text = "Powder Jar (1 or 2)"
			Lsrplab.AutoSize = True
			Lsrplab.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 12F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 161)
			Dim control4 As Global.System.Windows.Forms.Control = Lsrplab
			location = New Global.System.Drawing.Point(7, 26)
			control4.Location = location
			Dim control5 As Global.System.Windows.Forms.Control = Lsrplab
			margin = New Global.System.Windows.Forms.Padding(4, 0, 4, 0)
			control5.Margin = margin
			Lsrplab.Name = "Lsrplab"
			Dim control6 As Global.System.Windows.Forms.Control = Lsrplab
			size = New Global.System.Drawing.Size(171, 20)
			control6.Size = size
			Lsrplab.TabIndex = 9
			Lsrplab.Text = "Laser Power Ini. (W)"
			Powdflab.AutoSize = True
			Powdflab.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 12F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 161)
			Dim control7 As Global.System.Windows.Forms.Control = Powdflab
			location = New Global.System.Drawing.Point(304, 26)
			control7.Location = location
			Dim control8 As Global.System.Windows.Forms.Control = Powdflab
			margin = New Global.System.Windows.Forms.Padding(4, 0, 4, 0)
			control8.Margin = margin
			Powdflab.Name = "Powdflab"
			Dim control9 As Global.System.Windows.Forms.Control = Powdflab
			size = New Global.System.Drawing.Size(169, 20)
			control9.Size = size
			Powdflab.TabIndex = 11
			Powdflab.Text = "Powder Feed (RPM)"
			Label6.AutoSize = True
			Label6.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 12F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 161)
			Dim control10 As Global.System.Windows.Forms.Control = Label6
			location = New Global.System.Drawing.Point(312, 209)
			control10.Location = location
			Dim control11 As Global.System.Windows.Forms.Control = Label6
			margin = New Global.System.Windows.Forms.Padding(4, 0, 4, 0)
			control11.Margin = margin
			Label6.Name = "Label6"
			Dim control12 As Global.System.Windows.Forms.Control = Label6
			size = New Global.System.Drawing.Size(159, 20)
			control12.Size = size
			Label6.TabIndex = 20
			Label6.Text = "Process Sp (mm/s)"
			Label7.AutoSize = True
			Label7.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 12F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 161)
			Dim control13 As Global.System.Windows.Forms.Control = Label7
			location = New Global.System.Drawing.Point(315, 258)
			control13.Location = location
			Dim control14 As Global.System.Windows.Forms.Control = Label7
			margin = New Global.System.Windows.Forms.Padding(4, 0, 4, 0)
			control14.Margin = margin
			Label7.Name = "Label1"
			Dim control15 As Global.System.Windows.Forms.Control = Label7
			size = New Global.System.Drawing.Size(137, 20)
			control15.Size = size
			Label7.TabIndex = 22
			Label7.Text = "Beam Dia. (mm)"
			Label8.AutoSize = True
			Label8.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 12F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 161)
			Dim control16 As Global.System.Windows.Forms.Control = Label8
			location = New Global.System.Drawing.Point(5, 72)
			control16.Location = location
			Dim control17 As Global.System.Windows.Forms.Control = Label8
			margin = New Global.System.Windows.Forms.Padding(4, 0, 4, 0)
			control17.Margin = margin
			Label8.Name = "Label2"
			Dim control18 As Global.System.Windows.Forms.Control = Label8
			size = New Global.System.Drawing.Size(176, 20)
			control18.Size = size
			Label8.TabIndex = 24
			Label8.Text = "Laser Power Fin. (W)"
			Label9.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 12F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 161)
			Dim control19 As Global.System.Windows.Forms.Control = Label9
			location = New Global.System.Drawing.Point(6, 107)
			control19.Location = location
			Dim control20 As Global.System.Windows.Forms.Control = Label9
			margin = New Global.System.Windows.Forms.Padding(4, 0, 4, 0)
			control20.Margin = margin
			Label9.Name = "Label3"
			Dim control21 As Global.System.Windows.Forms.Control = Label9
			size = New Global.System.Drawing.Size(166, 46)
			control21.Size = size
			Label9.TabIndex = 26
			Label9.Text = "Power Reduction Track Number"
			Label10.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 12F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 161)
			Dim control22 As Global.System.Windows.Forms.Control = Label10
			location = New Global.System.Drawing.Point(7, 154)
			control22.Location = location
			Dim control23 As Global.System.Windows.Forms.Control = Label10
			margin = New Global.System.Windows.Forms.Padding(4, 0, 4, 0)
			control23.Margin = margin
			Label10.Name = "Label4"
			Dim control24 As Global.System.Windows.Forms.Control = Label10
			size = New Global.System.Drawing.Size(150, 41)
			control24.Size = size
			Label10.TabIndex = 28
			Label10.Text = "Initial Overpower Factor (%)"
			Label11.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 12F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 161)
			Dim control25 As Global.System.Windows.Forms.Control = Label11
			location = New Global.System.Drawing.Point(7, 202)
			control25.Location = location
			Dim control26 As Global.System.Windows.Forms.Control = Label11
			margin = New Global.System.Windows.Forms.Padding(4, 0, 4, 0)
			control26.Margin = margin
			Label11.Name = "Label5"
			Dim control27 As Global.System.Windows.Forms.Control = Label11
			size = New Global.System.Drawing.Size(171, 41)
			control27.Size = size
			Label11.TabIndex = 30
			Label11.Text = "Overpower Distance (mm)"
			Label12.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 12F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 161)
			Dim control28 As Global.System.Windows.Forms.Control = Label12
			location = New Global.System.Drawing.Point(7, 295)
			control28.Location = location
			Dim control29 As Global.System.Windows.Forms.Control = Label12
			margin = New Global.System.Windows.Forms.Padding(4, 0, 4, 0)
			control29.Margin = margin
			Label12.Name = "Label7"
			Dim control30 As Global.System.Windows.Forms.Control = Label12
			size = New Global.System.Drawing.Size(171, 41)
			control30.Size = size
			Label12.TabIndex = 34
			Label12.Text = "Final Overpower Distance (mm)"
			Label13.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 12F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 161)
			Dim control31 As Global.System.Windows.Forms.Control = Label13
			location = New Global.System.Drawing.Point(7, 247)
			control31.Location = location
			Dim control32 As Global.System.Windows.Forms.Control = Label13
			margin = New Global.System.Windows.Forms.Padding(4, 0, 4, 0)
			control32.Margin = margin
			Label13.Name = "Label8"
			Dim control33 As Global.System.Windows.Forms.Control = Label13
			size = New Global.System.Drawing.Size(150, 41)
			control33.Size = size
			Label13.TabIndex = 32
			Label13.Text = "Final Overpower Factor (%)"
			Label14.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 12F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 161)
			Dim control34 As Global.System.Windows.Forms.Control = Label14
			location = New Global.System.Drawing.Point(312, 109)
			control34.Location = location
			Dim control35 As Global.System.Windows.Forms.Control = Label14
			margin = New Global.System.Windows.Forms.Padding(4, 0, 4, 0)
			control35.Margin = margin
			Label14.Name = "Label9"
			Dim control36 As Global.System.Windows.Forms.Control = Label14
			size = New Global.System.Drawing.Size(150, 41)
			control36.Size = size
			Label14.TabIndex = 36
			Label14.Text = "Initial Powder Reduction (%)"
			Label15.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 12F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 161)
			Dim control37 As Global.System.Windows.Forms.Control = Label15
			location = New Global.System.Drawing.Point(312, 155)
			control37.Location = location
			Dim control38 As Global.System.Windows.Forms.Control = Label15
			margin = New Global.System.Windows.Forms.Padding(4, 0, 4, 0)
			control38.Margin = margin
			Label15.Name = "Label10"
			Dim control39 As Global.System.Windows.Forms.Control = Label15
			size = New Global.System.Drawing.Size(150, 41)
			control39.Size = size
			Label15.TabIndex = 38
			Label15.Text = "Final Powder Reduction (%)"
			Me.GroupBox1.Controls.Add(Me.Finpowderredtxt)
			Me.GroupBox1.Controls.Add(Label15)
			Me.GroupBox1.Controls.Add(Me.Inipowderredtxt)
			Me.GroupBox1.Controls.Add(Label14)
			Me.GroupBox1.Controls.Add(Me.Finoverpowdistxt)
			Me.GroupBox1.Controls.Add(Label12)
			Me.GroupBox1.Controls.Add(Me.Finoverpowertxt)
			Me.GroupBox1.Controls.Add(Label13)
			Me.GroupBox1.Controls.Add(Me.Inioverpowdistxt)
			Me.GroupBox1.Controls.Add(Label11)
			Me.GroupBox1.Controls.Add(Me.Inioverpowertxt)
			Me.GroupBox1.Controls.Add(Label10)
			Me.GroupBox1.Controls.Add(Me.Lsrrdtrctxt)
			Me.GroupBox1.Controls.Add(Label9)
			Me.GroupBox1.Controls.Add(Me.Lsrpfintxt)
			Me.GroupBox1.Controls.Add(Label8)
			Me.GroupBox1.Controls.Add(Label7)
			Me.GroupBox1.Controls.Add(Me.Beamdiatxt)
			Me.GroupBox1.Controls.Add(Label6)
			Me.GroupBox1.Controls.Add(Me.Procsp)
			Me.GroupBox1.Controls.Add(Powdjlab)
			Me.GroupBox1.Controls.Add(Me.Lsrpinitxt)
			Me.GroupBox1.Controls.Add(Me.Powdjtxt)
			Me.GroupBox1.Controls.Add(Lsrplab)
			Me.GroupBox1.Controls.Add(Powdflab)
			Me.GroupBox1.Controls.Add(Me.Powdftxt)
			Me.GroupBox1.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 9.75F, Global.System.Drawing.FontStyle.Bold Or Global.System.Drawing.FontStyle.Italic, Global.System.Drawing.GraphicsUnit.Point, 161)
			Dim groupBox As Global.System.Windows.Forms.Control = Me.GroupBox1
			location = New Global.System.Drawing.Point(12, 12)
			groupBox.Location = location
			Me.GroupBox1.Name = "GroupBox1"
			Dim groupBox2 As Global.System.Windows.Forms.Control = Me.GroupBox1
			size = New Global.System.Drawing.Size(552, 351)
			groupBox2.Size = size
			Me.GroupBox1.TabIndex = 1
			Me.GroupBox1.TabStop = False
			Me.GroupBox1.Text = "Process Parameters"
			Me.Finpowderredtxt.Font = New Global.System.Drawing.Font("Arial", 12F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 161)
			Dim finpowderredtxt As Global.System.Windows.Forms.Control = Me.Finpowderredtxt
			location = New Global.System.Drawing.Point(472, 162)
			finpowderredtxt.Location = location
			Dim finpowderredtxt2 As Global.System.Windows.Forms.Control = Me.Finpowderredtxt
			margin = New Global.System.Windows.Forms.Padding(4, 5, 4, 5)
			finpowderredtxt2.Margin = margin
			Me.Finpowderredtxt.Name = "Finpowderredtxt"
			Dim finpowderredtxt3 As Global.System.Windows.Forms.Control = Me.Finpowderredtxt
			size = New Global.System.Drawing.Size(60, 26)
			finpowderredtxt3.Size = size
			Me.Finpowderredtxt.TabIndex = 10
			Me.Finpowderredtxt.Text = "5"
			Me.Finpowderredtxt.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
			Me.Inipowderredtxt.Font = New Global.System.Drawing.Font("Arial", 12F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 161)
			Dim inipowderredtxt As Global.System.Windows.Forms.Control = Me.Inipowderredtxt
			location = New Global.System.Drawing.Point(472, 116)
			inipowderredtxt.Location = location
			Dim inipowderredtxt2 As Global.System.Windows.Forms.Control = Me.Inipowderredtxt
			margin = New Global.System.Windows.Forms.Padding(4, 5, 4, 5)
			inipowderredtxt2.Margin = margin
			Me.Inipowderredtxt.Name = "Inipowderredtxt"
			Dim inipowderredtxt3 As Global.System.Windows.Forms.Control = Me.Inipowderredtxt
			size = New Global.System.Drawing.Size(60, 26)
			inipowderredtxt3.Size = size
			Me.Inipowderredtxt.TabIndex = 9
			Me.Inipowderredtxt.Text = "5"
			Me.Inipowderredtxt.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
			Me.Finoverpowdistxt.Font = New Global.System.Drawing.Font("Arial", 12F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 161)
			Dim finoverpowdistxt As Global.System.Windows.Forms.Control = Me.Finoverpowdistxt
			location = New Global.System.Drawing.Point(181, 300)
			finoverpowdistxt.Location = location
			Dim finoverpowdistxt2 As Global.System.Windows.Forms.Control = Me.Finoverpowdistxt
			margin = New Global.System.Windows.Forms.Padding(4, 5, 4, 5)
			finoverpowdistxt2.Margin = margin
			Me.Finoverpowdistxt.Name = "Finoverpowdistxt"
			Dim finoverpowdistxt3 As Global.System.Windows.Forms.Control = Me.Finoverpowdistxt
			size = New Global.System.Drawing.Size(60, 26)
			finoverpowdistxt3.Size = size
			Me.Finoverpowdistxt.TabIndex = 6
			Me.Finoverpowdistxt.Text = "20.00"
			Me.Finoverpowdistxt.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
			Me.Finoverpowertxt.Font = New Global.System.Drawing.Font("Arial", 12F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 161)
			Dim finoverpowertxt As Global.System.Windows.Forms.Control = Me.Finoverpowertxt
			location = New Global.System.Drawing.Point(181, 255)
			finoverpowertxt.Location = location
			Dim finoverpowertxt2 As Global.System.Windows.Forms.Control = Me.Finoverpowertxt
			margin = New Global.System.Windows.Forms.Padding(4, 5, 4, 5)
			finoverpowertxt2.Margin = margin
			Me.Finoverpowertxt.Name = "Finoverpowertxt"
			Dim finoverpowertxt3 As Global.System.Windows.Forms.Control = Me.Finoverpowertxt
			size = New Global.System.Drawing.Size(60, 26)
			finoverpowertxt3.Size = size
			Me.Finoverpowertxt.TabIndex = 5
			Me.Finoverpowertxt.Text = "20"
			Me.Finoverpowertxt.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
			Me.Inioverpowdistxt.Font = New Global.System.Drawing.Font("Arial", 12F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 161)
			Dim inioverpowdistxt As Global.System.Windows.Forms.Control = Me.Inioverpowdistxt
			location = New Global.System.Drawing.Point(181, 207)
			inioverpowdistxt.Location = location
			Dim inioverpowdistxt2 As Global.System.Windows.Forms.Control = Me.Inioverpowdistxt
			margin = New Global.System.Windows.Forms.Padding(4, 5, 4, 5)
			inioverpowdistxt2.Margin = margin
			Me.Inioverpowdistxt.Name = "Inioverpowdistxt"
			Dim inioverpowdistxt3 As Global.System.Windows.Forms.Control = Me.Inioverpowdistxt
			size = New Global.System.Drawing.Size(60, 26)
			inioverpowdistxt3.Size = size
			Me.Inioverpowdistxt.TabIndex = 4
			Me.Inioverpowdistxt.Text = "20.00"
			Me.Inioverpowdistxt.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
			Me.Inioverpowertxt.Font = New Global.System.Drawing.Font("Arial", 12F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 161)
			Dim inioverpowertxt As Global.System.Windows.Forms.Control = Me.Inioverpowertxt
			location = New Global.System.Drawing.Point(181, 162)
			inioverpowertxt.Location = location
			Dim inioverpowertxt2 As Global.System.Windows.Forms.Control = Me.Inioverpowertxt
			margin = New Global.System.Windows.Forms.Padding(4, 5, 4, 5)
			inioverpowertxt2.Margin = margin
			Me.Inioverpowertxt.Name = "Inioverpowertxt"
			Dim inioverpowertxt3 As Global.System.Windows.Forms.Control = Me.Inioverpowertxt
			size = New Global.System.Drawing.Size(60, 26)
			inioverpowertxt3.Size = size
			Me.Inioverpowertxt.TabIndex = 3
			Me.Inioverpowertxt.Text = "20"
			Me.Inioverpowertxt.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
			Me.Lsrrdtrctxt.Font = New Global.System.Drawing.Font("Arial", 12F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 161)
			Dim lsrrdtrctxt As Global.System.Windows.Forms.Control = Me.Lsrrdtrctxt
			location = New Global.System.Drawing.Point(181, 116)
			lsrrdtrctxt.Location = location
			Dim lsrrdtrctxt2 As Global.System.Windows.Forms.Control = Me.Lsrrdtrctxt
			margin = New Global.System.Windows.Forms.Padding(4, 5, 4, 5)
			lsrrdtrctxt2.Margin = margin
			Me.Lsrrdtrctxt.Name = "Lsrrdtrctxt"
			Dim lsrrdtrctxt3 As Global.System.Windows.Forms.Control = Me.Lsrrdtrctxt
			size = New Global.System.Drawing.Size(60, 26)
			lsrrdtrctxt3.Size = size
			Me.Lsrrdtrctxt.TabIndex = 2
			Me.Lsrrdtrctxt.Text = "3"
			Me.Lsrrdtrctxt.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
			Me.Lsrpfintxt.Font = New Global.System.Drawing.Font("Arial", 12F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 161)
			Dim lsrpfintxt As Global.System.Windows.Forms.Control = Me.Lsrpfintxt
			location = New Global.System.Drawing.Point(181, 70)
			lsrpfintxt.Location = location
			Dim lsrpfintxt2 As Global.System.Windows.Forms.Control = Me.Lsrpfintxt
			margin = New Global.System.Windows.Forms.Padding(4, 5, 4, 5)
			lsrpfintxt2.Margin = margin
			Me.Lsrpfintxt.Name = "Lsrpfintxt"
			Dim lsrpfintxt3 As Global.System.Windows.Forms.Control = Me.Lsrpfintxt
			size = New Global.System.Drawing.Size(60, 26)
			lsrpfintxt3.Size = size
			Me.Lsrpfintxt.TabIndex = 1
			Me.Lsrpfintxt.Text = "4000"
			Me.Lsrpfintxt.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
			Me.Beamdiatxt.Font = New Global.System.Drawing.Font("Arial", 12F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 161)
			Dim beamdiatxt As Global.System.Windows.Forms.Control = Me.Beamdiatxt
			location = New Global.System.Drawing.Point(472, 254)
			beamdiatxt.Location = location
			Dim beamdiatxt2 As Global.System.Windows.Forms.Control = Me.Beamdiatxt
			margin = New Global.System.Windows.Forms.Padding(4, 5, 4, 5)
			beamdiatxt2.Margin = margin
			Me.Beamdiatxt.Name = "Beamdiatxt"
			Dim beamdiatxt3 As Global.System.Windows.Forms.Control = Me.Beamdiatxt
			size = New Global.System.Drawing.Size(60, 26)
			beamdiatxt3.Size = size
			Me.Beamdiatxt.TabIndex = 12
			Me.Beamdiatxt.Text = "6.50"
			Me.Beamdiatxt.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
			Me.Procsp.Font = New Global.System.Drawing.Font("Arial", 12F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 161)
			Dim procsp As Global.System.Windows.Forms.Control = Me.Procsp
			location = New Global.System.Drawing.Point(472, 208)
			procsp.Location = location
			Dim procsp2 As Global.System.Windows.Forms.Control = Me.Procsp
			margin = New Global.System.Windows.Forms.Padding(4, 5, 4, 5)
			procsp2.Margin = margin
			Me.Procsp.Name = "Procsp"
			Dim procsp3 As Global.System.Windows.Forms.Control = Me.Procsp
			size = New Global.System.Drawing.Size(60, 26)
			procsp3.Size = size
			Me.Procsp.TabIndex = 11
			Me.Procsp.Text = "15.0"
			Me.Procsp.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
			Me.Lsrpinitxt.Font = New Global.System.Drawing.Font("Arial", 12F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 161)
			Dim lsrpinitxt As Global.System.Windows.Forms.Control = Me.Lsrpinitxt
			location = New Global.System.Drawing.Point(181, 24)
			lsrpinitxt.Location = location
			Dim lsrpinitxt2 As Global.System.Windows.Forms.Control = Me.Lsrpinitxt
			margin = New Global.System.Windows.Forms.Padding(4, 5, 4, 5)
			lsrpinitxt2.Margin = margin
			Me.Lsrpinitxt.Name = "Lsrpinitxt"
			Dim lsrpinitxt3 As Global.System.Windows.Forms.Control = Me.Lsrpinitxt
			size = New Global.System.Drawing.Size(60, 26)
			lsrpinitxt3.Size = size
			Me.Lsrpinitxt.TabIndex = 0
			Me.Lsrpinitxt.Text = "5000"
			Me.Lsrpinitxt.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
			Me.Powdjtxt.Enabled = False
			Me.Powdjtxt.Font = New Global.System.Drawing.Font("Arial", 12F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 161)
			Dim powdjtxt As Global.System.Windows.Forms.Control = Me.Powdjtxt
			location = New Global.System.Drawing.Point(472, 70)
			powdjtxt.Location = location
			Dim powdjtxt2 As Global.System.Windows.Forms.Control = Me.Powdjtxt
			margin = New Global.System.Windows.Forms.Padding(4, 5, 4, 5)
			powdjtxt2.Margin = margin
			Me.Powdjtxt.Name = "Powdjtxt"
			Dim powdjtxt3 As Global.System.Windows.Forms.Control = Me.Powdjtxt
			size = New Global.System.Drawing.Size(60, 26)
			powdjtxt3.Size = size
			Me.Powdjtxt.TabIndex = 8
			Me.Powdjtxt.Text = "1"
			Me.Powdjtxt.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
			Me.Powdftxt.Font = New Global.System.Drawing.Font("Arial", 12F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 161)
			Dim powdftxt As Global.System.Windows.Forms.Control = Me.Powdftxt
			location = New Global.System.Drawing.Point(472, 24)
			powdftxt.Location = location
			Dim powdftxt2 As Global.System.Windows.Forms.Control = Me.Powdftxt
			margin = New Global.System.Windows.Forms.Padding(4, 5, 4, 5)
			powdftxt2.Margin = margin
			Me.Powdftxt.Name = "Powdftxt"
			Dim powdftxt3 As Global.System.Windows.Forms.Control = Me.Powdftxt
			size = New Global.System.Drawing.Size(60, 26)
			powdftxt3.Size = size
			Me.Powdftxt.TabIndex = 7
			Me.Powdftxt.Text = "10.00"
			Me.Powdftxt.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Right
			Me.Cnlbtn.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 11.25F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 161)
			Dim cnlbtn As Global.System.Windows.Forms.Control = Me.Cnlbtn
			location = New Global.System.Drawing.Point(479, 378)
			cnlbtn.Location = location
			Me.Cnlbtn.Name = "Cnlbtn"
			Dim cnlbtn2 As Global.System.Windows.Forms.Control = Me.Cnlbtn
			size = New Global.System.Drawing.Size(85, 26)
			cnlbtn2.Size = size
			Me.Cnlbtn.TabIndex = 3
			Me.Cnlbtn.Text = "Cancel"
			Me.Cnlbtn.TextAlign = Global.System.Drawing.ContentAlignment.TopCenter
			Me.Cnlbtn.UseVisualStyleBackColor = True
			Me.Cnfrmbtn.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 11.25F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 161)
			Dim cnfrmbtn As Global.System.Windows.Forms.Control = Me.Cnfrmbtn
			location = New Global.System.Drawing.Point(354, 378)
			cnfrmbtn.Location = location
			Me.Cnfrmbtn.Name = "Cnfrmbtn"
			Dim cnfrmbtn2 As Global.System.Windows.Forms.Control = Me.Cnfrmbtn
			size = New Global.System.Drawing.Size(85, 26)
			cnfrmbtn2.Size = size
			Me.Cnfrmbtn.TabIndex = 2
			Me.Cnfrmbtn.Text = "Confirm"
			Me.Cnfrmbtn.TextAlign = Global.System.Drawing.ContentAlignment.TopCenter
			Me.Cnfrmbtn.UseVisualStyleBackColor = True
			Dim autoScaleDimensions As Global.System.Drawing.SizeF = New Global.System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleDimensions = autoScaleDimensions
			Me.AutoScaleMode = Global.System.Windows.Forms.AutoScaleMode.Font
			size = New Global.System.Drawing.Size(574, 415)
			Me.ClientSize = size
			Me.Controls.Add(Me.Cnlbtn)
			Me.Controls.Add(Me.Cnfrmbtn)
			Me.Controls.Add(Me.GroupBox1)
			Me.FormBorderStyle = Global.System.Windows.Forms.FormBorderStyle.FixedDialog
			Me.MaximizeBox = False
			Me.MinimizeBox = False
			Me.Name = "Processsetup"
			Me.ShowInTaskbar = False
			Me.StartPosition = Global.System.Windows.Forms.FormStartPosition.CenterParent
			Me.Text = "Processsetup"
			Me.GroupBox1.ResumeLayout(False)
			Me.GroupBox1.PerformLayout()
			Me.ResumeLayout(False)
		End Sub

		' Token: 0x04000261 RID: 609
		Private components As Global.System.ComponentModel.IContainer
	End Class
End Namespace
