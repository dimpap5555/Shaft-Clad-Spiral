Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.IO
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

Namespace WindowsApplication1
	' Token: 0x0200001F RID: 31
	Public Partial Class Processsetup
		Inherits Form

		' Token: 0x060005B2 RID: 1458 RVA: 0x0004A3A0 File Offset: 0x000487A0
		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.Processsetup_Load
			Me.ProcValid = New Valuevalidate()
			Me.InitializeComponent()
		End Sub

		' Token: 0x170001CF RID: 463
		' (get) Token: 0x060005B5 RID: 1461 RVA: 0x0004B8A4 File Offset: 0x00049CA4
		' (set) Token: 0x060005B6 RID: 1462 RVA: 0x0004B8B8 File Offset: 0x00049CB8
		Friend Overridable Property GroupBox1 As GroupBox
			<DebuggerNonUserCode()>
			Get
				Return Me._GroupBox1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As GroupBox)
				Me._GroupBox1 = value
			End Set
		End Property

		' Token: 0x170001D0 RID: 464
		' (get) Token: 0x060005B7 RID: 1463 RVA: 0x0004B8C4 File Offset: 0x00049CC4
		' (set) Token: 0x060005B8 RID: 1464 RVA: 0x0004B8D8 File Offset: 0x00049CD8
		Friend Overridable Property Lsrpinitxt As TextBox
			<DebuggerNonUserCode()>
			Get
				Return Me._Lsrpinitxt
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As EventHandler = AddressOf Me.Lsrpinitxt_Leave
				If Me._Lsrpinitxt IsNot Nothing Then
					RemoveHandler Me._Lsrpinitxt.Leave, value2
				End If
				Me._Lsrpinitxt = value
				If Me._Lsrpinitxt IsNot Nothing Then
					AddHandler Me._Lsrpinitxt.Leave, value2
				End If
			End Set
		End Property

		' Token: 0x170001D1 RID: 465
		' (get) Token: 0x060005B9 RID: 1465 RVA: 0x0004B924 File Offset: 0x00049D24
		' (set) Token: 0x060005BA RID: 1466 RVA: 0x0004B938 File Offset: 0x00049D38
		Friend Overridable Property Powdjtxt As TextBox
			<DebuggerNonUserCode()>
			Get
				Return Me._Powdjtxt
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As EventHandler = AddressOf Me.Powdjtxt_Leave
				If Me._Powdjtxt IsNot Nothing Then
					RemoveHandler Me._Powdjtxt.Leave, value2
				End If
				Me._Powdjtxt = value
				If Me._Powdjtxt IsNot Nothing Then
					AddHandler Me._Powdjtxt.Leave, value2
				End If
			End Set
		End Property

		' Token: 0x170001D2 RID: 466
		' (get) Token: 0x060005BB RID: 1467 RVA: 0x0004B984 File Offset: 0x00049D84
		' (set) Token: 0x060005BC RID: 1468 RVA: 0x0004B998 File Offset: 0x00049D98
		Friend Overridable Property Powdftxt As TextBox
			<DebuggerNonUserCode()>
			Get
				Return Me._Powdftxt
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As EventHandler = AddressOf Me.Powdftxt_Leave
				If Me._Powdftxt IsNot Nothing Then
					RemoveHandler Me._Powdftxt.Leave, value2
				End If
				Me._Powdftxt = value
				If Me._Powdftxt IsNot Nothing Then
					AddHandler Me._Powdftxt.Leave, value2
				End If
			End Set
		End Property

		' Token: 0x170001D3 RID: 467
		' (get) Token: 0x060005BD RID: 1469 RVA: 0x0004B9E4 File Offset: 0x00049DE4
		' (set) Token: 0x060005BE RID: 1470 RVA: 0x0004B9F8 File Offset: 0x00049DF8
		Friend Overridable Property Cnlbtn As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._Cnlbtn
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = AddressOf Me.Cnlbtn_Click
				If Me._Cnlbtn IsNot Nothing Then
					RemoveHandler Me._Cnlbtn.Click, value2
				End If
				Me._Cnlbtn = value
				If Me._Cnlbtn IsNot Nothing Then
					AddHandler Me._Cnlbtn.Click, value2
				End If
			End Set
		End Property

		' Token: 0x170001D4 RID: 468
		' (get) Token: 0x060005BF RID: 1471 RVA: 0x0004BA44 File Offset: 0x00049E44
		' (set) Token: 0x060005C0 RID: 1472 RVA: 0x0004BA58 File Offset: 0x00049E58
		Friend Overridable Property Cnfrmbtn As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._Cnfrmbtn
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = AddressOf Me.Cnfrmbtn_Click
				If Me._Cnfrmbtn IsNot Nothing Then
					RemoveHandler Me._Cnfrmbtn.Click, value2
				End If
				Me._Cnfrmbtn = value
				If Me._Cnfrmbtn IsNot Nothing Then
					AddHandler Me._Cnfrmbtn.Click, value2
				End If
			End Set
		End Property

		' Token: 0x170001D5 RID: 469
		' (get) Token: 0x060005C1 RID: 1473 RVA: 0x0004BAA4 File Offset: 0x00049EA4
		' (set) Token: 0x060005C2 RID: 1474 RVA: 0x0004BAB8 File Offset: 0x00049EB8
		Friend Overridable Property Beamdiatxt As TextBox
			<DebuggerNonUserCode()>
			Get
				Return Me._Beamdiatxt
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As EventHandler = AddressOf Me.Beamdiatxt_Leave
				If Me._Beamdiatxt IsNot Nothing Then
					RemoveHandler Me._Beamdiatxt.Leave, value2
				End If
				Me._Beamdiatxt = value
				If Me._Beamdiatxt IsNot Nothing Then
					AddHandler Me._Beamdiatxt.Leave, value2
				End If
			End Set
		End Property

		' Token: 0x170001D6 RID: 470
		' (get) Token: 0x060005C3 RID: 1475 RVA: 0x0004BB04 File Offset: 0x00049F04
		' (set) Token: 0x060005C4 RID: 1476 RVA: 0x0004BB18 File Offset: 0x00049F18
		Friend Overridable Property Procsp As TextBox
			<DebuggerNonUserCode()>
			Get
				Return Me._Procsp
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As EventHandler = AddressOf Me.Procsp_Leave
				If Me._Procsp IsNot Nothing Then
					RemoveHandler Me._Procsp.Leave, value2
				End If
				Me._Procsp = value
				If Me._Procsp IsNot Nothing Then
					AddHandler Me._Procsp.Leave, value2
				End If
			End Set
		End Property

		' Token: 0x170001D7 RID: 471
		' (get) Token: 0x060005C5 RID: 1477 RVA: 0x0004BB64 File Offset: 0x00049F64
		' (set) Token: 0x060005C6 RID: 1478 RVA: 0x0004BB78 File Offset: 0x00049F78
		Friend Overridable Property Lsrrdtrctxt As TextBox
			<DebuggerNonUserCode()>
			Get
				Return Me._Lsrrdtrctxt
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As EventHandler = AddressOf Me.Lsrrdtrctxt_TextChanged
				If Me._Lsrrdtrctxt IsNot Nothing Then
					RemoveHandler Me._Lsrrdtrctxt.Leave, value2
				End If
				Me._Lsrrdtrctxt = value
				If Me._Lsrrdtrctxt IsNot Nothing Then
					AddHandler Me._Lsrrdtrctxt.Leave, value2
				End If
			End Set
		End Property

		' Token: 0x170001D8 RID: 472
		' (get) Token: 0x060005C7 RID: 1479 RVA: 0x0004BBC4 File Offset: 0x00049FC4
		' (set) Token: 0x060005C8 RID: 1480 RVA: 0x0004BBD8 File Offset: 0x00049FD8
		Friend Overridable Property Lsrpfintxt As TextBox
			<DebuggerNonUserCode()>
			Get
				Return Me._Lsrpfintxt
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As EventHandler = AddressOf Me.Lsrpfintxt_TextChanged
				If Me._Lsrpfintxt IsNot Nothing Then
					RemoveHandler Me._Lsrpfintxt.Leave, value2
				End If
				Me._Lsrpfintxt = value
				If Me._Lsrpfintxt IsNot Nothing Then
					AddHandler Me._Lsrpfintxt.Leave, value2
				End If
			End Set
		End Property

		' Token: 0x170001D9 RID: 473
		' (get) Token: 0x060005C9 RID: 1481 RVA: 0x0004BC24 File Offset: 0x0004A024
		' (set) Token: 0x060005CA RID: 1482 RVA: 0x0004BC38 File Offset: 0x0004A038
		Friend Overridable Property Inioverpowdistxt As TextBox
			<DebuggerNonUserCode()>
			Get
				Return Me._Inioverpowdistxt
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Me._Inioverpowdistxt = value
			End Set
		End Property

		' Token: 0x170001DA RID: 474
		' (get) Token: 0x060005CB RID: 1483 RVA: 0x0004BC44 File Offset: 0x0004A044
		' (set) Token: 0x060005CC RID: 1484 RVA: 0x0004BC58 File Offset: 0x0004A058
		Friend Overridable Property Inioverpowertxt As TextBox
			<DebuggerNonUserCode()>
			Get
				Return Me._Inioverpowertxt
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As EventHandler = AddressOf Me.Inioverpowertxt_Leave
				If Me._Inioverpowertxt IsNot Nothing Then
					RemoveHandler Me._Inioverpowertxt.Leave, value2
				End If
				Me._Inioverpowertxt = value
				If Me._Inioverpowertxt IsNot Nothing Then
					AddHandler Me._Inioverpowertxt.Leave, value2
				End If
			End Set
		End Property

		' Token: 0x170001DB RID: 475
		' (get) Token: 0x060005CD RID: 1485 RVA: 0x0004BCA4 File Offset: 0x0004A0A4
		' (set) Token: 0x060005CE RID: 1486 RVA: 0x0004BCB8 File Offset: 0x0004A0B8
		Friend Overridable Property Inipowderredtxt As TextBox
			<DebuggerNonUserCode()>
			Get
				Return Me._Inipowderredtxt
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As EventHandler = AddressOf Me.Inipowderredtxt_Leave
				If Me._Inipowderredtxt IsNot Nothing Then
					RemoveHandler Me._Inipowderredtxt.Leave, value2
				End If
				Me._Inipowderredtxt = value
				If Me._Inipowderredtxt IsNot Nothing Then
					AddHandler Me._Inipowderredtxt.Leave, value2
				End If
			End Set
		End Property

		' Token: 0x170001DC RID: 476
		' (get) Token: 0x060005CF RID: 1487 RVA: 0x0004BD04 File Offset: 0x0004A104
		' (set) Token: 0x060005D0 RID: 1488 RVA: 0x0004BD18 File Offset: 0x0004A118
		Friend Overridable Property Finoverpowdistxt As TextBox
			<DebuggerNonUserCode()>
			Get
				Return Me._Finoverpowdistxt
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As EventHandler = AddressOf Me.Finoverpowdistxt_Leave
				If Me._Finoverpowdistxt IsNot Nothing Then
					RemoveHandler Me._Finoverpowdistxt.Leave, value2
				End If
				Me._Finoverpowdistxt = value
				If Me._Finoverpowdistxt IsNot Nothing Then
					AddHandler Me._Finoverpowdistxt.Leave, value2
				End If
			End Set
		End Property

		' Token: 0x170001DD RID: 477
		' (get) Token: 0x060005D1 RID: 1489 RVA: 0x0004BD64 File Offset: 0x0004A164
		' (set) Token: 0x060005D2 RID: 1490 RVA: 0x0004BD78 File Offset: 0x0004A178
		Friend Overridable Property Finoverpowertxt As TextBox
			<DebuggerNonUserCode()>
			Get
				Return Me._Finoverpowertxt
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Me._Finoverpowertxt = value
			End Set
		End Property

		' Token: 0x170001DE RID: 478
		' (get) Token: 0x060005D3 RID: 1491 RVA: 0x0004BD84 File Offset: 0x0004A184
		' (set) Token: 0x060005D4 RID: 1492 RVA: 0x0004BD98 File Offset: 0x0004A198
		Friend Overridable Property Finpowderredtxt As TextBox
			<DebuggerNonUserCode()>
			Get
				Return Me._Finpowderredtxt
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As EventHandler = AddressOf Me.Finpowderredtxt_Leave
				If Me._Finpowderredtxt IsNot Nothing Then
					RemoveHandler Me._Finpowderredtxt.Leave, value2
				End If
				Me._Finpowderredtxt = value
				If Me._Finpowderredtxt IsNot Nothing Then
					AddHandler Me._Finpowderredtxt.Leave, value2
				End If
			End Set
		End Property

		' Token: 0x170001DF RID: 479
		' (get) Token: 0x060005D5 RID: 1493 RVA: 0x0004BDE4 File Offset: 0x0004A1E4
		' (set) Token: 0x060005D6 RID: 1494 RVA: 0x0004BDF8 File Offset: 0x0004A1F8
		Private Property ProcValid As Valuevalidate
			<DebuggerNonUserCode()>
			Get
				Return Me._ProcValid
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Valuevalidate)
				Me._ProcValid = value
			End Set
		End Property

		' Token: 0x060005D7 RID: 1495 RVA: 0x0004BE04 File Offset: 0x0004A204
		Private Sub Processsetup_Load(sender As Object, e As EventArgs)
			Me.Lsrpinitxt.Text = Positioncal.LaserPowerIni.ToString("#0")
			Me.Lsrpfintxt.Text = Positioncal.LaserPowerFin.ToString("#0")
			Me.Lsrrdtrctxt.Text = Positioncal.LaserReductionTrackNo.ToString("#0")
			Me.Powdftxt.Text = Positioncal.PowderFeed.ToString("#0.00")
			Me.Powdjtxt.Text = Positioncal.PowderJar.ToString("#0")
			Me.Procsp.Text = Positioncal.ProcessSpeed.ToString("#0.00")
			Me.Beamdiatxt.Text = Positioncal.CladWidth.ToString("#0.00")
			Me.Inioverpowertxt.Text = Positioncal.IniOverPower.ToString("#0")
			Me.Finoverpowertxt.Text = Positioncal.FinOverPower.ToString("#0")
			Me.Inioverpowdistxt.Text = Positioncal.IniOverPowerDis.ToString("#0.00")
			Me.Finoverpowdistxt.Text = Positioncal.FinOverPowerDis.ToString("#0.00")
			Me.Inipowderredtxt.Text = Positioncal.IniPowderRed.ToString("#0")
			Me.Finpowderredtxt.Text = Positioncal.FinPowderRed.ToString("#0")
		End Sub

		' Token: 0x060005D8 RID: 1496 RVA: 0x0004BF64 File Offset: 0x0004A364
		Private Sub Cnfrmbtn_Click(sender As Object, e As EventArgs)
			Dim fs As FileStream = New FileStream(Application.StartupPath + "\Processsettings.txt", FileMode.Create)
			Dim w As StreamWriter = New StreamWriter(fs)
			Dim power As Double = CDbl(Positioncal.LaserPowerIni) * (1.0 + CDbl(Positioncal.IniOverPower) / 100.0)
			If power <= 4500.0 Then
				w.WriteLine(Me.Lsrpinitxt.Text)
				w.WriteLine(Me.Lsrpfintxt.Text)
				w.WriteLine(Me.Lsrrdtrctxt.Text)
				w.WriteLine(Me.Powdftxt.Text)
				w.WriteLine(Me.Powdjtxt.Text)
				w.WriteLine(Me.Procsp.Text)
				w.WriteLine(Me.Beamdiatxt.Text)
				w.WriteLine(Me.Inioverpowertxt.Text)
				w.WriteLine(Me.Finoverpowertxt.Text)
				w.WriteLine(Me.Inioverpowdistxt.Text)
				w.WriteLine(Me.Finoverpowdistxt.Text)
				w.WriteLine(Me.Inipowderredtxt.Text)
				w.WriteLine(Me.Finpowderredtxt.Text)
				w.Close()
				Me.DialogResult = DialogResult.OK
				Me.Close()
			Else
				Dim msgboxres As Integer = CInt(Interaction.MsgBox("The greatest overpower factor for the specified initial power is " + ((4500.0 / CDbl(Positioncal.LaserPowerIni) - 1.0) * 100.0).ToString("#0") + vbCrLf & "Would you like to use this value?", MsgBoxStyle.YesNo, Nothing))
				If msgboxres = 6 Then
					Me.Inioverpowertxt.Text = ((4500.0 / CDbl(Positioncal.LaserPowerIni) - 1.0) * 100.0).ToString("#0")
					Positioncal.IniOverPower = CInt(Math.Round((4500.0 / CDbl(Positioncal.LaserPowerIni) - 1.0) * 100.0))
					power = CDbl(Positioncal.LaserPowerIni) * (1.0 + CDbl(Positioncal.IniOverPower) / 100.0)
				End If
				w.Close()
			End If
		End Sub

		' Token: 0x060005D9 RID: 1497 RVA: 0x0004C198 File Offset: 0x0004A598
		Private Sub Cnlbtn_Click(sender As Object, e As EventArgs)
			Me.DialogResult = DialogResult.Cancel
			Me.Close()
		End Sub

		' Token: 0x060005DA RID: 1498 RVA: 0x0004C1A8 File Offset: 0x0004A5A8
		Private Sub Lsrpinitxt_Leave(sender As Object, e As EventArgs)
			Dim defval As Double = 3600.0
			If Char.IsNumber(Conversions.ToChar(Me.Lsrpinitxt.Text)) Then
				Dim value As Integer = Conversions.ToInteger(Me.Lsrpinitxt.Text)
				If CDbl(value) < 450.0 Or CDbl(value) > 4500.0 Then
					Interaction.MsgBox(String.Concat(New String() { "Valid values of laser power are within ", 450.0.ToString("#0"), " - ", 4500.0.ToString("#0"), "W. Please reenter" }), MsgBoxStyle.Exclamation, Nothing)
					Me.Lsrpinitxt.Text = defval.ToString("#0")
					Positioncal.LaserPowerIni = CInt(Math.Round(defval))
				Else
					Me.Lsrpinitxt.Text = value.ToString("#0")
					Positioncal.LaserPowerIni = value
				End If
			Else
				Interaction.MsgBox("This is not a valid value", MsgBoxStyle.Exclamation, Nothing)
				Me.Lsrpinitxt.Text = defval.ToString("#0")
				Positioncal.LaserPowerIni = CInt(Math.Round(defval))
			End If
		End Sub

		' Token: 0x060005DB RID: 1499 RVA: 0x0004C2E8 File Offset: 0x0004A6E8
		Private Sub Powdftxt_Leave(sender As Object, e As EventArgs)
			If Char.IsNumber(Conversions.ToChar(Me.Powdftxt.Text)) Then
				Dim value As Double = Conversions.ToDouble(Me.Powdftxt.Text)
				If value < 0.0 Or value > 100.0 Then
					Interaction.MsgBox("Valid values of powder feed are within 0-100%. Please reenter", MsgBoxStyle.Exclamation, Nothing)
					Me.Powdftxt.Text = 10.0.ToString("#0.00")
					Positioncal.PowderFeed = 10.0
				Else
					Me.Powdftxt.Text = value.ToString("#0.00")
					Positioncal.PowderFeed = value
				End If
			Else
				Interaction.MsgBox("This is not a valid value", MsgBoxStyle.Exclamation, Nothing)
				Me.Powdftxt.Text = 10.0.ToString("#0.00")
				Positioncal.PowderFeed = 10.0
			End If
		End Sub

		' Token: 0x060005DC RID: 1500 RVA: 0x0004C3D8 File Offset: 0x0004A7D8
		Private Sub Powdjtxt_Leave(sender As Object, e As EventArgs)
			If Char.IsNumber(Conversions.ToChar(Me.Powdjtxt.Text)) Then
				Dim value As Double = Conversions.ToDouble(Me.Powdjtxt.Text)
				If value < 1.0 Or value > 2.0 Then
					Interaction.MsgBox("Valid values are 1 and 2. Please reenter", MsgBoxStyle.Exclamation, Nothing)
					Me.Powdjtxt.Text = 1.ToString("#0")
					Positioncal.PowderJar = 1S
				Else
					Me.Powdjtxt.Text = value.ToString("#0")
					Positioncal.PowderJar = CShort(Math.Round(value))
				End If
			Else
				Interaction.MsgBox("This is not a valid value", MsgBoxStyle.Exclamation, Nothing)
				Me.Powdjtxt.Text = 1.ToString("#0")
				Positioncal.PowderJar = 1S
			End If
		End Sub

		' Token: 0x060005DD RID: 1501 RVA: 0x0004C4AC File Offset: 0x0004A8AC
		Private Sub Procsp_Leave(sender As Object, e As EventArgs)
			If Char.IsNumber(Conversions.ToChar(Me.Procsp.Text)) Then
				Dim value As Double = Conversions.ToDouble(Me.Procsp.Text)
				If value < 0.1 Or value > 100.0 Then
					Interaction.MsgBox("Valid values of process speed are within 0.1-100mm/s. Please reenter", MsgBoxStyle.Exclamation, Nothing)
					Me.Procsp.Text = 15.0.ToString("#0.0")
					Positioncal.ProcessSpeed = 15.0
				Else
					Me.Procsp.Text = value.ToString("#0.0")
					Positioncal.ProcessSpeed = value
				End If
			Else
				Interaction.MsgBox("This is not a valid value", MsgBoxStyle.Exclamation, Nothing)
				Me.Procsp.Text = 15.0.ToString("#0.00")
				Dim value As Double
				Positioncal.ProcessSpeed = value
			End If
		End Sub

		' Token: 0x060005DE RID: 1502 RVA: 0x0004C594 File Offset: 0x0004A994
		Private Sub Beamdiatxt_Leave(sender As Object, e As EventArgs)
			If Versioned.IsNumeric(Me.Beamdiatxt.Text) Then
				Dim value As Double = Conversions.ToDouble(Me.Beamdiatxt.Text)
				If value < 1.9 Or value > 6.25 Then
					Interaction.MsgBox(String.Concat(New String() { "Valid values of beam diameter are within ", 1.9.ToString("#0.00"), " - ", 6.25.ToString("#0.00"), "mm" }), MsgBoxStyle.Exclamation, Nothing)
					Me.Beamdiatxt.Text = 3.0.ToString("#0.00")
					Positioncal.CladWidth = 3.0
				Else
					Me.Beamdiatxt.Text = value.ToString("#0.00")
					Positioncal.CladWidth = value
				End If
			Else
				Interaction.MsgBox("This is not a valid value", MsgBoxStyle.Exclamation, Nothing)
				Me.Beamdiatxt.Text = 3.0.ToString("#0.00")
				Positioncal.CladWidth = 3.0
			End If
		End Sub

		' Token: 0x060005DF RID: 1503 RVA: 0x0004C6D4 File Offset: 0x0004AAD4
		Private Sub Lsrpfintxt_TextChanged(sender As Object, e As EventArgs)
			If Char.IsNumber(Conversions.ToChar(Me.Lsrpfintxt.Text)) Then
				Dim value As Integer = Conversions.ToInteger(Me.Lsrpfintxt.Text)
				If value < 0 Or CDbl(value) > 4500.0 Then
					Interaction.MsgBox(String.Concat(New String() { "Valid values of final laser power are within ", 450.0.ToString("#0"), " - ", 4500.0.ToString("#0"), "W" }), MsgBoxStyle.Exclamation, Nothing)
					Me.Lsrpfintxt.Text = 3600.ToString("#0")
					Positioncal.LaserPowerFin = 3600
				Else
					Me.Lsrpfintxt.Text = value.ToString("#0")
					Positioncal.LaserPowerFin = value
				End If
			Else
				Interaction.MsgBox("This is not a valid value", MsgBoxStyle.Exclamation, Nothing)
				Me.Lsrpfintxt.Text = 3600.ToString("#0")
				Positioncal.LaserPowerFin = 3600
			End If
		End Sub

		' Token: 0x060005E0 RID: 1504 RVA: 0x0004C804 File Offset: 0x0004AC04
		Private Sub Lsrrdtrctxt_TextChanged(sender As Object, e As EventArgs)
			If Char.IsNumber(Conversions.ToChar(Me.Lsrrdtrctxt.Text)) Then
				Dim value As Integer = Conversions.ToInteger(Me.Lsrrdtrctxt.Text)
				If value < 1 Or value > 10 Then
					Interaction.MsgBox("Valid values of power reduction track number are within 1-10", MsgBoxStyle.Exclamation, Nothing)
					Me.Lsrrdtrctxt.Text = 3.ToString("#0")
					Positioncal.LaserReductionTrackNo = 3
				Else
					Me.Lsrrdtrctxt.Text = value.ToString("#0")
					Positioncal.LaserReductionTrackNo = value
				End If
			Else
				Interaction.MsgBox("This is not a valid value", MsgBoxStyle.Exclamation, Nothing)
				Me.Lsrrdtrctxt.Text = 3.ToString("#0")
				Positioncal.LaserReductionTrackNo = 3
			End If
		End Sub

		' Token: 0x060005E1 RID: 1505 RVA: 0x0004C8C0 File Offset: 0x0004ACC0
		Private Sub Inioverpowertxt_Leave(sender As Object, e As EventArgs)
			If Char.IsNumber(Conversions.ToChar(Me.Inioverpowertxt.Text)) Then
				Dim value As Integer = Conversions.ToInteger(Me.Inioverpowertxt.Text)
				Dim power As Double = CDbl(Positioncal.LaserPowerIni) * (1.0 + CDbl(value) / 100.0)
				If power < 4500.0 Then
					If value < 0 Or value > 100 Then
						Interaction.MsgBox("Valid values of final laser overpower are within 0-100%", MsgBoxStyle.Exclamation, Nothing)
						Me.Inioverpowertxt.Text = 20.ToString("#0")
						Positioncal.IniOverPower = 20
					Else
						Me.Inioverpowertxt.Text = value.ToString("#0")
						Positioncal.IniOverPower = value
					End If
				Else
					Interaction.MsgBox("The greatest overpower factor for the specified initial power is " + ((6000.0 / CDbl(Positioncal.LaserPowerIni) - 1.0) * 100.0).ToString("#0"), MsgBoxStyle.Exclamation, Nothing)
					Me.Inioverpowertxt.Text = ((4500.0 / CDbl(Positioncal.LaserPowerIni) - 1.0) * 100.0).ToString("#0")
					Positioncal.IniOverPower = Conversions.ToInteger(Me.Inioverpowertxt.Text)
				End If
			Else
				Interaction.MsgBox("This is not a valid value", MsgBoxStyle.Exclamation, Nothing)
				Me.Inioverpowertxt.Text = 20.ToString("#0")
				Positioncal.IniOverPower = 20
			End If
		End Sub

		' Token: 0x060005E2 RID: 1506 RVA: 0x0004CA4C File Offset: 0x0004AE4C
		Private Sub Inipowderredtxt_Leave(sender As Object, e As EventArgs)
			If Versioned.IsNumeric(Me.Inipowderredtxt.Text) Then
				Dim value As Integer = Conversions.ToInteger(Me.Inipowderredtxt.Text)
				If value < -100 Or value > 100 Then
					Interaction.MsgBox("Valid values of initial powder reduction are within -100%-100%", MsgBoxStyle.Exclamation, Nothing)
					Me.Inipowderredtxt.Text = 5.ToString("#0")
					Positioncal.IniPowderRed = 5
				Else
					Me.Inipowderredtxt.Text = value.ToString("#0")
					Positioncal.IniPowderRed = value
				End If
			Else
				Interaction.MsgBox("This is not a valid value", MsgBoxStyle.Exclamation, Nothing)
				Me.Inipowderredtxt.Text = 5.ToString("#0")
				Positioncal.IniPowderRed = 5
			End If
		End Sub

		' Token: 0x060005E3 RID: 1507 RVA: 0x0004CB04 File Offset: 0x0004AF04
		Private Sub Finpowderredtxt_Leave(sender As Object, e As EventArgs)
			If Versioned.IsNumeric(Me.Finpowderredtxt.Text) Then
				Dim value As Integer = Conversions.ToInteger(Me.Finpowderredtxt.Text)
				If value < -100 Or value > 100 Then
					Interaction.MsgBox("Valid values of final powder reduction are within -100%-100%", MsgBoxStyle.Exclamation, Nothing)
					Me.Finpowderredtxt.Text = 5.ToString("#0")
					Positioncal.FinPowderRed = 5
				Else
					Me.Finpowderredtxt.Text = value.ToString("#0")
					Positioncal.FinPowderRed = value
				End If
			Else
				Interaction.MsgBox("This is not a valid value", MsgBoxStyle.Exclamation, Nothing)
				Me.Finpowderredtxt.Text = 5.ToString("#0")
				Positioncal.FinPowderRed = 5
			End If
		End Sub

		' Token: 0x060005E4 RID: 1508 RVA: 0x0004CBBC File Offset: 0x0004AFBC
		Private Sub Finoverpowdistxt_Leave(sender As Object, e As EventArgs)
			If Char.IsNumber(Conversions.ToChar(Me.Finoverpowdistxt.Text)) Then
				Dim value As Integer = Conversions.ToInteger(Me.Finoverpowdistxt.Text)
				If value < 0 Or value > 1000 Then
					Interaction.MsgBox("Valid values of initial powder reduction are within 0-1000mm", MsgBoxStyle.Exclamation, Nothing)
					Me.Finoverpowdistxt.Text = 100.ToString("#0")
					Positioncal.FinOverPowerDis = 100
				Else
					Me.Finoverpowdistxt.Text = value.ToString("#0")
					Positioncal.FinOverPowerDis = value
				End If
			Else
				Interaction.MsgBox("This is not a valid value", MsgBoxStyle.Exclamation, Nothing)
				Me.Finoverpowdistxt.Text = 100.ToString("#0")
				Positioncal.FinOverPowerDis = 100
			End If
		End Sub

		' Token: 0x04000262 RID: 610
		<AccessedThroughProperty("GroupBox1")>
		Private _GroupBox1 As GroupBox

		' Token: 0x04000263 RID: 611
		<AccessedThroughProperty("Lsrpinitxt")>
		Private _Lsrpinitxt As TextBox

		' Token: 0x04000264 RID: 612
		<AccessedThroughProperty("Powdjtxt")>
		Private _Powdjtxt As TextBox

		' Token: 0x04000265 RID: 613
		<AccessedThroughProperty("Powdftxt")>
		Private _Powdftxt As TextBox

		' Token: 0x04000266 RID: 614
		<AccessedThroughProperty("Cnlbtn")>
		Private _Cnlbtn As Button

		' Token: 0x04000267 RID: 615
		<AccessedThroughProperty("Cnfrmbtn")>
		Private _Cnfrmbtn As Button

		' Token: 0x04000268 RID: 616
		<AccessedThroughProperty("Beamdiatxt")>
		Private _Beamdiatxt As TextBox

		' Token: 0x04000269 RID: 617
		<AccessedThroughProperty("Procsp")>
		Private _Procsp As TextBox

		' Token: 0x0400026A RID: 618
		<AccessedThroughProperty("Lsrrdtrctxt")>
		Private _Lsrrdtrctxt As TextBox

		' Token: 0x0400026B RID: 619
		<AccessedThroughProperty("Lsrpfintxt")>
		Private _Lsrpfintxt As TextBox

		' Token: 0x0400026C RID: 620
		<AccessedThroughProperty("Inioverpowdistxt")>
		Private _Inioverpowdistxt As TextBox

		' Token: 0x0400026D RID: 621
		<AccessedThroughProperty("Inioverpowertxt")>
		Private _Inioverpowertxt As TextBox

		' Token: 0x0400026E RID: 622
		<AccessedThroughProperty("Inipowderredtxt")>
		Private _Inipowderredtxt As TextBox

		' Token: 0x0400026F RID: 623
		<AccessedThroughProperty("Finoverpowdistxt")>
		Private _Finoverpowdistxt As TextBox

		' Token: 0x04000270 RID: 624
		<AccessedThroughProperty("Finoverpowertxt")>
		Private _Finoverpowertxt As TextBox

		' Token: 0x04000271 RID: 625
		<AccessedThroughProperty("Finpowderredtxt")>
		Private _Finpowderredtxt As TextBox

		' Token: 0x04000272 RID: 626
		<AccessedThroughProperty("ProcValid")>
		Private _ProcValid As Valuevalidate
	End Class
End Namespace
