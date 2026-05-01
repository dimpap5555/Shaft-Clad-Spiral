Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.IO
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports WindowsApplication1.My

Namespace WindowsApplication1
	' Token: 0x0200001A RID: 26
	<DesignerGenerated()>
	Public Partial Class POCKETPARAM
		Inherits Form

		' Token: 0x06000515 RID: 1301 RVA: 0x00045414 File Offset: 0x00043814
		<DebuggerNonUserCode()>
		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.POCKETPARAM_Load
			Me.InitializeComponent()
		End Sub

		' Token: 0x1700019F RID: 415
		' (get) Token: 0x06000518 RID: 1304 RVA: 0x00046F40 File Offset: 0x00045340
		' (set) Token: 0x06000519 RID: 1305 RVA: 0x00046F54 File Offset: 0x00045354
		Friend Overridable Property Diatxt As TextBox
			<DebuggerNonUserCode()>
			Get
				Return Me._Diatxt
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As EventHandler = AddressOf Me.Lengthtxt_TextChanged
				Dim value3 As EventHandler = AddressOf Me.Lengthtxt_Leave
				If Me._Diatxt IsNot Nothing Then
					RemoveHandler Me._Diatxt.TextChanged, value2
					RemoveHandler Me._Diatxt.Leave, value3
				End If
				Me._Diatxt = value
				If Me._Diatxt IsNot Nothing Then
					AddHandler Me._Diatxt.TextChanged, value2
					AddHandler Me._Diatxt.Leave, value3
				End If
			End Set
		End Property

		' Token: 0x170001A0 RID: 416
		' (get) Token: 0x0600051A RID: 1306 RVA: 0x00046FC4 File Offset: 0x000453C4
		' (set) Token: 0x0600051B RID: 1307 RVA: 0x00046FD8 File Offset: 0x000453D8
		Friend Overridable Property Widthtxt As TextBox
			<DebuggerNonUserCode()>
			Get
				Return Me._Widthtxt
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As EventHandler = AddressOf Me.Widthtxt_Leave
				If Me._Widthtxt IsNot Nothing Then
					RemoveHandler Me._Widthtxt.Leave, value2
				End If
				Me._Widthtxt = value
				If Me._Widthtxt IsNot Nothing Then
					AddHandler Me._Widthtxt.Leave, value2
				End If
			End Set
		End Property

		' Token: 0x170001A1 RID: 417
		' (get) Token: 0x0600051C RID: 1308 RVA: 0x00047024 File Offset: 0x00045424
		' (set) Token: 0x0600051D RID: 1309 RVA: 0x00047038 File Offset: 0x00045438
		Friend Overridable Property Xtxt As TextBox
			<DebuggerNonUserCode()>
			Get
				Return Me._Xtxt
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As EventHandler = AddressOf Me.Xtxt_Leave
				If Me._Xtxt IsNot Nothing Then
					RemoveHandler Me._Xtxt.Leave, value2
				End If
				Me._Xtxt = value
				If Me._Xtxt IsNot Nothing Then
					AddHandler Me._Xtxt.Leave, value2
				End If
			End Set
		End Property

		' Token: 0x170001A2 RID: 418
		' (get) Token: 0x0600051E RID: 1310 RVA: 0x00047084 File Offset: 0x00045484
		' (set) Token: 0x0600051F RID: 1311 RVA: 0x00047098 File Offset: 0x00045498
		Friend Overridable Property Pittxt As TextBox
			<DebuggerNonUserCode()>
			Get
				Return Me._Pittxt
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As EventHandler = AddressOf Me.Pittxt_Leave
				If Me._Pittxt IsNot Nothing Then
					RemoveHandler Me._Pittxt.Leave, value2
				End If
				Me._Pittxt = value
				If Me._Pittxt IsNot Nothing Then
					AddHandler Me._Pittxt.Leave, value2
				End If
			End Set
		End Property

		' Token: 0x170001A3 RID: 419
		' (get) Token: 0x06000520 RID: 1312 RVA: 0x000470E4 File Offset: 0x000454E4
		' (set) Token: 0x06000521 RID: 1313 RVA: 0x000470F8 File Offset: 0x000454F8
		Friend Overridable Property GroupBox2 As GroupBox
			<DebuggerNonUserCode()>
			Get
				Return Me._GroupBox2
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As GroupBox)
				Me._GroupBox2 = value
			End Set
		End Property

		' Token: 0x170001A4 RID: 420
		' (get) Token: 0x06000522 RID: 1314 RVA: 0x00047104 File Offset: 0x00045504
		' (set) Token: 0x06000523 RID: 1315 RVA: 0x00047118 File Offset: 0x00045518
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

		' Token: 0x170001A5 RID: 421
		' (get) Token: 0x06000524 RID: 1316 RVA: 0x00047164 File Offset: 0x00045564
		' (set) Token: 0x06000525 RID: 1317 RVA: 0x00047178 File Offset: 0x00045578
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

		' Token: 0x170001A6 RID: 422
		' (get) Token: 0x06000526 RID: 1318 RVA: 0x000471C4 File Offset: 0x000455C4
		' (set) Token: 0x06000527 RID: 1319 RVA: 0x000471D8 File Offset: 0x000455D8
		Friend Overridable Property GroupBox3 As GroupBox
			<DebuggerNonUserCode()>
			Get
				Return Me._GroupBox3
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As GroupBox)
				Me._GroupBox3 = value
			End Set
		End Property

		' Token: 0x170001A7 RID: 423
		' (get) Token: 0x06000528 RID: 1320 RVA: 0x000471E4 File Offset: 0x000455E4
		' (set) Token: 0x06000529 RID: 1321 RVA: 0x000471F8 File Offset: 0x000455F8
		Friend Overridable Property Postatxt As TextBox
			<DebuggerNonUserCode()>
			Get
				Return Me._Postatxt
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As EventHandler = AddressOf Me.Postatxt_Leave
				If Me._Postatxt IsNot Nothing Then
					RemoveHandler Me._Postatxt.Leave, value2
				End If
				Me._Postatxt = value
				If Me._Postatxt IsNot Nothing Then
					AddHandler Me._Postatxt.Leave, value2
				End If
			End Set
		End Property

		' Token: 0x170001A8 RID: 424
		' (get) Token: 0x0600052A RID: 1322 RVA: 0x00047244 File Offset: 0x00045644
		' (set) Token: 0x0600052B RID: 1323 RVA: 0x00047258 File Offset: 0x00045658
		Friend Overridable Property Inioverwtxt As TextBox
			<DebuggerNonUserCode()>
			Get
				Return Me._Inioverwtxt
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As EventHandler = AddressOf Me.Inioverwtxt_Leave
				If Me._Inioverwtxt IsNot Nothing Then
					RemoveHandler Me._Inioverwtxt.Leave, value2
				End If
				Me._Inioverwtxt = value
				If Me._Inioverwtxt IsNot Nothing Then
					AddHandler Me._Inioverwtxt.Leave, value2
				End If
			End Set
		End Property

		' Token: 0x170001A9 RID: 425
		' (get) Token: 0x0600052C RID: 1324 RVA: 0x000472A4 File Offset: 0x000456A4
		' (set) Token: 0x0600052D RID: 1325 RVA: 0x000472B8 File Offset: 0x000456B8
		Friend Overridable Property Finoverwtxt As TextBox
			<DebuggerNonUserCode()>
			Get
				Return Me._Finoverwtxt
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As EventHandler = AddressOf Me.Finoverwtxt_Leave
				If Me._Finoverwtxt IsNot Nothing Then
					RemoveHandler Me._Finoverwtxt.Leave, value2
				End If
				Me._Finoverwtxt = value
				If Me._Finoverwtxt IsNot Nothing Then
					AddHandler Me._Finoverwtxt.Leave, value2
				End If
			End Set
		End Property

		' Token: 0x170001AA RID: 426
		' (get) Token: 0x0600052E RID: 1326 RVA: 0x00047304 File Offset: 0x00045704
		' (set) Token: 0x0600052F RID: 1327 RVA: 0x00047318 File Offset: 0x00045718
		Friend Overridable Property Initang As TextBox
			<DebuggerNonUserCode()>
			Get
				Return Me._Initang
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As EventHandler = AddressOf Me.Initang_Leave
				If Me._Initang IsNot Nothing Then
					RemoveHandler Me._Initang.Leave, value2
				End If
				Me._Initang = value
				If Me._Initang IsNot Nothing Then
					AddHandler Me._Initang.Leave, value2
				End If
			End Set
		End Property

		' Token: 0x170001AB RID: 427
		' (get) Token: 0x06000530 RID: 1328 RVA: 0x00047364 File Offset: 0x00045764
		' (set) Token: 0x06000531 RID: 1329 RVA: 0x00047378 File Offset: 0x00045778
		Friend Overridable Property Tooloffsettxt As TextBox
			<DebuggerNonUserCode()>
			Get
				Return Me._Tooloffsettxt
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As EventHandler = AddressOf Me.Tooloffsettxt_TextChanged
				If Me._Tooloffsettxt IsNot Nothing Then
					RemoveHandler Me._Tooloffsettxt.Leave, value2
				End If
				Me._Tooloffsettxt = value
				If Me._Tooloffsettxt IsNot Nothing Then
					AddHandler Me._Tooloffsettxt.Leave, value2
				End If
			End Set
		End Property

		' Token: 0x170001AC RID: 428
		' (get) Token: 0x06000532 RID: 1330 RVA: 0x000473C4 File Offset: 0x000457C4
		' (set) Token: 0x06000533 RID: 1331 RVA: 0x000473D8 File Offset: 0x000457D8
		Friend Overridable Property Ztxt As TextBox
			<DebuggerNonUserCode()>
			Get
				Return Me._Ztxt
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As EventHandler = AddressOf Me.Ztxt_Leave
				If Me._Ztxt IsNot Nothing Then
					RemoveHandler Me._Ztxt.Leave, value2
				End If
				Me._Ztxt = value
				If Me._Ztxt IsNot Nothing Then
					AddHandler Me._Ztxt.Leave, value2
				End If
			End Set
		End Property

		' Token: 0x170001AD RID: 429
		' (get) Token: 0x06000534 RID: 1332 RVA: 0x00047424 File Offset: 0x00045824
		' (set) Token: 0x06000535 RID: 1333 RVA: 0x00047438 File Offset: 0x00045838
		Friend Overridable Property Ytxt As TextBox
			<DebuggerNonUserCode()>
			Get
				Return Me._Ytxt
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As EventHandler = AddressOf Me.Ytxt_Leave
				If Me._Ytxt IsNot Nothing Then
					RemoveHandler Me._Ytxt.Leave, value2
				End If
				Me._Ytxt = value
				If Me._Ytxt IsNot Nothing Then
					AddHandler Me._Ytxt.Leave, value2
				End If
			End Set
		End Property

		' Token: 0x170001AE RID: 430
		' (get) Token: 0x06000536 RID: 1334 RVA: 0x00047484 File Offset: 0x00045884
		' (set) Token: 0x06000537 RID: 1335 RVA: 0x00047498 File Offset: 0x00045898
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

		' Token: 0x170001AF RID: 431
		' (get) Token: 0x06000538 RID: 1336 RVA: 0x000474A4 File Offset: 0x000458A4
		' (set) Token: 0x06000539 RID: 1337 RVA: 0x000474B8 File Offset: 0x000458B8
		Friend Overridable Property A3 As RadioButton
			<DebuggerNonUserCode()>
			Get
				Return Me._A3
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As RadioButton)
				Dim value2 As EventHandler = AddressOf Me.A3_CheckedChanged
				If Me._A3 IsNot Nothing Then
					RemoveHandler Me._A3.CheckedChanged, value2
				End If
				Me._A3 = value
				If Me._A3 IsNot Nothing Then
					AddHandler Me._A3.CheckedChanged, value2
				End If
			End Set
		End Property

		' Token: 0x170001B0 RID: 432
		' (get) Token: 0x0600053A RID: 1338 RVA: 0x00047504 File Offset: 0x00045904
		' (set) Token: 0x0600053B RID: 1339 RVA: 0x00047518 File Offset: 0x00045918
		Friend Overridable Property A2 As RadioButton
			<DebuggerNonUserCode()>
			Get
				Return Me._A2
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As RadioButton)
				Dim value2 As EventHandler = AddressOf Me.A2_CheckedChanged
				If Me._A2 IsNot Nothing Then
					RemoveHandler Me._A2.CheckedChanged, value2
				End If
				Me._A2 = value
				If Me._A2 IsNot Nothing Then
					AddHandler Me._A2.CheckedChanged, value2
				End If
			End Set
		End Property

		' Token: 0x170001B1 RID: 433
		' (get) Token: 0x0600053C RID: 1340 RVA: 0x00047564 File Offset: 0x00045964
		' (set) Token: 0x0600053D RID: 1341 RVA: 0x00047578 File Offset: 0x00045978
		Friend Overridable Property A1 As RadioButton
			<DebuggerNonUserCode()>
			Get
				Return Me._A1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As RadioButton)
				Dim value2 As EventHandler = AddressOf Me.A1_Click
				If Me._A1 IsNot Nothing Then
					RemoveHandler Me._A1.Click, value2
				End If
				Me._A1 = value
				If Me._A1 IsNot Nothing Then
					AddHandler Me._A1.Click, value2
				End If
			End Set
		End Property

		' Token: 0x170001B2 RID: 434
		' (get) Token: 0x0600053E RID: 1342 RVA: 0x000475C4 File Offset: 0x000459C4
		' (set) Token: 0x0600053F RID: 1343 RVA: 0x000475D8 File Offset: 0x000459D8
		Friend Overridable Property GroupBox5 As GroupBox
			<DebuggerNonUserCode()>
			Get
				Return Me._GroupBox5
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As GroupBox)
				Me._GroupBox5 = value
			End Set
		End Property

		' Token: 0x170001B3 RID: 435
		' (get) Token: 0x06000540 RID: 1344 RVA: 0x000475E4 File Offset: 0x000459E4
		' (set) Token: 0x06000541 RID: 1345 RVA: 0x000475F8 File Offset: 0x000459F8
		Friend Overridable Property WD_13 As RadioButton
			<DebuggerNonUserCode()>
			Get
				Return Me._WD_13
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As RadioButton)
				Dim value2 As EventHandler = AddressOf Me.WD_13_CheckedChanged
				If Me._WD_13 IsNot Nothing Then
					RemoveHandler Me._WD_13.CheckedChanged, value2
				End If
				Me._WD_13 = value
				If Me._WD_13 IsNot Nothing Then
					AddHandler Me._WD_13.CheckedChanged, value2
				End If
			End Set
		End Property

		' Token: 0x170001B4 RID: 436
		' (get) Token: 0x06000542 RID: 1346 RVA: 0x00047644 File Offset: 0x00045A44
		' (set) Token: 0x06000543 RID: 1347 RVA: 0x00047658 File Offset: 0x00045A58
		Friend Overridable Property WD_20 As RadioButton
			<DebuggerNonUserCode()>
			Get
				Return Me._WD_20
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As RadioButton)
				Dim value2 As EventHandler = AddressOf Me.WD_20_CheckedChanged
				If Me._WD_20 IsNot Nothing Then
					RemoveHandler Me._WD_20.CheckedChanged, value2
				End If
				Me._WD_20 = value
				If Me._WD_20 IsNot Nothing Then
					AddHandler Me._WD_20.CheckedChanged, value2
				End If
			End Set
		End Property

		' Token: 0x170001B5 RID: 437
		' (get) Token: 0x06000544 RID: 1348 RVA: 0x000476A4 File Offset: 0x00045AA4
		' (set) Token: 0x06000545 RID: 1349 RVA: 0x000476B8 File Offset: 0x00045AB8
		Friend Overridable Property CurrPosStat As CheckBox
			<DebuggerNonUserCode()>
			Get
				Return Me._CurrPosStat
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As CheckBox)
				Dim value2 As EventHandler = AddressOf Me.CheckBox2_Click
				If Me._CurrPosStat IsNot Nothing Then
					RemoveHandler Me._CurrPosStat.Click, value2
				End If
				Me._CurrPosStat = value
				If Me._CurrPosStat IsNot Nothing Then
					AddHandler Me._CurrPosStat.Click, value2
				End If
			End Set
		End Property

		' Token: 0x170001B6 RID: 438
		' (get) Token: 0x06000546 RID: 1350 RVA: 0x00047704 File Offset: 0x00045B04
		' (set) Token: 0x06000547 RID: 1351 RVA: 0x00047718 File Offset: 0x00045B18
		Friend Overridable Property Conatxt As TextBox
			<DebuggerNonUserCode()>
			Get
				Return Me._Conatxt
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As EventHandler = AddressOf Me.Conatxt_TextChanged
				If Me._Conatxt IsNot Nothing Then
					RemoveHandler Me._Conatxt.TextChanged, value2
				End If
				Me._Conatxt = value
				If Me._Conatxt IsNot Nothing Then
					AddHandler Me._Conatxt.TextChanged, value2
				End If
			End Set
		End Property

		' Token: 0x170001B7 RID: 439
		' (get) Token: 0x06000548 RID: 1352 RVA: 0x00047764 File Offset: 0x00045B64
		' (set) Token: 0x06000549 RID: 1353 RVA: 0x00047778 File Offset: 0x00045B78
		Friend Overridable Property Lengthtxt As TextBox
			<DebuggerNonUserCode()>
			Get
				Return Me._Lengthtxt
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As EventHandler = AddressOf Me.Lengthtxt_TextChanged
				Dim value3 As EventHandler = AddressOf Me.Lengthtxt_Leave
				If Me._Lengthtxt IsNot Nothing Then
					RemoveHandler Me._Lengthtxt.TextChanged, value2
					RemoveHandler Me._Lengthtxt.Leave, value3
				End If
				Me._Lengthtxt = value
				If Me._Lengthtxt IsNot Nothing Then
					AddHandler Me._Lengthtxt.TextChanged, value2
					AddHandler Me._Lengthtxt.Leave, value3
				End If
			End Set
		End Property

		' Token: 0x0600054A RID: 1354 RVA: 0x000477E8 File Offset: 0x00045BE8
		Private Sub Cnlbtn_Click(sender As Object, e As EventArgs)
			Me.Close()
		End Sub

		' Token: 0x0600054B RID: 1355 RVA: 0x000477F0 File Offset: 0x00045BF0
		Private Sub Cnfrmbtn_Click(sender As Object, e As EventArgs)
			Dim fs As FileStream = New FileStream(Application.StartupPath + "\Pocketcladparam.txt", FileMode.Create)
			Dim w As StreamWriter = New StreamWriter(fs)
			Positioncal.Diameter = Conversions.ToDouble(Me.Diatxt.Text)
			Positioncal.Width1 = Conversions.ToDouble(Me.Widthtxt.Text)
			Positioncal.Xpos = Conversions.ToDouble(Me.Xtxt.Text)
			Positioncal.Ypos = Conversions.ToDouble(Me.Ytxt.Text)
			Positioncal.Zpos = Conversions.ToDouble(Me.Ztxt.Text)
			Positioncal.Pitch = Conversions.ToDouble(Me.Pittxt.Text)
			Positioncal.PostureAngle = Conversions.ToDouble(Me.Postatxt.Text)
			Positioncal.ConeAngle = Conversions.ToDouble(Me.Conatxt.Text)
			Positioncal.IniOverWeld = Conversions.ToSingle(Me.Inioverwtxt.Text)
			Positioncal.FinOverWeld = Conversions.ToSingle(Me.Finoverwtxt.Text)
			Positioncal.InitialAng = Conversions.ToDouble(Me.Initang.Text)
			Positioncal.ToolOffset = Conversions.ToDouble(Me.Tooloffsettxt.Text)
			Dim num As Integer = Conversions.ToInteger(Me.Widthtxt.Text)
			If num < CInt(Math.Round(Positioncal.CladWidth)) Then
				' The following expression was wrapped in a checked-expression
				Dim msgbxres As Short = CShort(Interaction.MsgBox("The minimum clad width is greater than " + Positioncal.CladWidth.ToString("#.00") + ". Adjust width accordingly?", MsgBoxStyle.YesNo, "Question"))
				If msgbxres = 6S Then
					Positioncal.Width1 = Positioncal.CladWidth + 0.1
					Me.Widthtxt.Text = Positioncal.Width1.ToString("#.00")
					Interaction.MsgBox("The width has been recalculated to " + Positioncal.Width1.ToString("#0.00 mm"), MsgBoxStyle.Information, "Information")
				End If
			End If
			If Positioncal.Width1 < Positioncal.CladWidth Then
				Interaction.MsgBox("The width should be at least " + Positioncal.CladWidth.ToString("#.00") + ". Please adjust accordingly", MsgBoxStyle.Exclamation, "Information")
			Else
				w.WriteLine(Me.Diatxt.Text)
				w.WriteLine(Me.Widthtxt.Text)
				w.WriteLine(Me.Xtxt.Text)
				w.WriteLine(Me.Ytxt.Text)
				w.WriteLine(Me.Ztxt.Text)
				w.WriteLine(Me.Pittxt.Text)
				w.WriteLine(Me.Postatxt.Text)
				w.WriteLine(Me.Conatxt.Text)
				w.WriteLine(Me.Inioverwtxt.Text)
				w.WriteLine(Me.Finoverwtxt.Text)
				w.WriteLine(Me.Initang.Text)
				w.WriteLine(Me.Tooloffsettxt.Text)
				w.WriteLine(Positioncal.StationPosition.ToString())
				w.WriteLine(Positioncal.CurrPos.ToString())
				w.Close()
				Me.DialogResult = DialogResult.OK
				Me.Close()
			End If
		End Sub

		' Token: 0x0600054C RID: 1356 RVA: 0x00047AF8 File Offset: 0x00045EF8
		Private Sub Tooloffsettxt_TextChanged(sender As Object, e As EventArgs)
			If Versioned.IsNumeric(Me.Tooloffsettxt.Text) Then
				Dim value As Double = Conversions.ToDouble(Me.Tooloffsettxt.Text)
				Me.Tooloffsettxt.Text = value.ToString("#0.0")
				Positioncal.ToolOffset = value
			Else
				Interaction.MsgBox("This is not a valid value", MsgBoxStyle.Exclamation, Nothing)
				Me.Tooloffsettxt.Text = "0.0"
				Positioncal.ToolOffset = 0.0
			End If
		End Sub

		' Token: 0x0600054D RID: 1357 RVA: 0x00047B74 File Offset: 0x00045F74
		Private Sub Diatxt_Leave(sender As Object, e As EventArgs)
			If Char.IsNumber(Conversions.ToChar(Me.Diatxt.Text)) Then
				Dim value As Double = Conversions.ToDouble(Me.Diatxt.Text)
				Me.Diatxt.Text = value.ToString("#0.0")
				Positioncal.Length = value
			Else
				Interaction.MsgBox("This is not a valid value", MsgBoxStyle.Exclamation, Nothing)
				Me.Diatxt.Text = 50.ToString("#0.0")
				Positioncal.Diameter = 50.0
			End If
		End Sub

		' Token: 0x0600054E RID: 1358 RVA: 0x00047C00 File Offset: 0x00046000
		Private Sub Widthtxt_Leave(sender As Object, e As EventArgs)
			If Char.IsNumber(Conversions.ToChar(Me.Widthtxt.Text)) Then
				Dim value As Double = Conversions.ToDouble(Me.Widthtxt.Text)
				Me.Widthtxt.Text = value.ToString("#0.0")
			Else
				Interaction.MsgBox("This is not a valid value (0 < W mm)", MsgBoxStyle.Exclamation, Nothing)
				Me.Widthtxt.Text = 15.ToString("#0.0")
			End If
		End Sub

		' Token: 0x0600054F RID: 1359 RVA: 0x00047C78 File Offset: 0x00046078
		Private Sub Xtxt_Leave(sender As Object, e As EventArgs)
			If Versioned.IsNumeric(Me.Xtxt.Text) Then
				Dim value As Double = Conversions.ToDouble(Me.Xtxt.Text)
				Me.Xtxt.Text = value.ToString("#0.0")
				Positioncal.Xpos = value
			Else
				Interaction.MsgBox("This is not a valid value", MsgBoxStyle.Exclamation, Nothing)
				Me.Xtxt.Text = 500.ToString("#0.0")
				Positioncal.Xpos = 500.0
			End If
		End Sub

		' Token: 0x06000550 RID: 1360 RVA: 0x00047D00 File Offset: 0x00046100
		Private Sub Ytxt_Leave(sender As Object, e As EventArgs)
			If Char.IsNumber(Conversions.ToChar(Me.Ytxt.Text)) Then
				Dim value As Double = Conversions.ToDouble(Me.Ytxt.Text)
				Me.Ytxt.Text = value.ToString("#0.0")
				Positioncal.Ypos = value
			Else
				Interaction.MsgBox("This is not a valid value", MsgBoxStyle.Exclamation, Nothing)
				Me.Ytxt.Text = 500.ToString("#0.0")
				Positioncal.Ypos = 500.0
			End If
		End Sub

		' Token: 0x06000551 RID: 1361 RVA: 0x00047D90 File Offset: 0x00046190
		Private Sub Ztxt_Leave(sender As Object, e As EventArgs)
			If Versioned.IsNumeric(Me.Ztxt.Text) Then
				Dim value As Double = Conversions.ToDouble(Me.Ztxt.Text)
				Me.Ztxt.Text = value.ToString("#0.0")
				Positioncal.Zpos = value
			Else
				Interaction.MsgBox("This is not a valid value", MsgBoxStyle.Exclamation, Nothing)
				Me.Ztxt.Text = 500.ToString("#0.0")
				Positioncal.Zpos = 500.0
			End If
		End Sub

		' Token: 0x06000552 RID: 1362 RVA: 0x00047E18 File Offset: 0x00046218
		Private Sub Pittxt_Leave(sender As Object, e As EventArgs)
			If Char.IsNumber(Conversions.ToChar(Me.Pittxt.Text)) Then
				Dim value As Double = Conversions.ToDouble(Me.Pittxt.Text)
				Me.Pittxt.Text = value.ToString("#0.00")
				Positioncal.Pitch = value
			Else
				Interaction.MsgBox("This is not a valid value (Pitch > 0 mm)", MsgBoxStyle.Exclamation, Nothing)
				Me.Pittxt.Text = 4.ToString("#0.00")
				Positioncal.Pitch = 4.0
			End If
		End Sub

		' Token: 0x06000553 RID: 1363 RVA: 0x00047EA4 File Offset: 0x000462A4
		Private Sub Postatxt_Leave(sender As Object, e As EventArgs)
			If Versioned.IsNumeric(Me.Postatxt.Text) Then
				Dim value As Double = Conversions.ToDouble(Me.Postatxt.Text)
				If value >= 0.0 And value <= 180.0 Then
					Me.Postatxt.Text = value.ToString("#0.00")
					Positioncal.PostureAngle = value
				Else
					Interaction.MsgBox("The posture angle should be within 0 and 180 degrees to the axis", MsgBoxStyle.Exclamation, Nothing)
					Me.Postatxt.Text = 90.ToString("#0.00")
					Positioncal.PostureAngle = 90.0
				End If
			Else
				Interaction.MsgBox("This is not a valid value", MsgBoxStyle.Exclamation, Nothing)
				Me.Postatxt.Text = 90.ToString("#0.00")
				Positioncal.PostureAngle = 90.0
			End If
		End Sub

		' Token: 0x06000554 RID: 1364 RVA: 0x00047F88 File Offset: 0x00046388
		Private Sub Conatxt_TextChanged(sender As Object, e As EventArgs)
			If Versioned.IsNumeric(Me.Conatxt.Text) Then
				Dim value As Double = Conversions.ToDouble(Me.Conatxt.Text)
				If value >= -90.0 And value <= 90.0 Then
					Me.Conatxt.Text = value.ToString("#0.00")
					Positioncal.ConeAngle = value
				Else
					Interaction.MsgBox("The posture angle should be within -90 and 90 degrees to the axis", MsgBoxStyle.Exclamation, Nothing)
					Me.Conatxt.Text = 0.ToString("#0.00")
					Positioncal.ConeAngle = 0.0
				End If
			Else
				Interaction.MsgBox("This is not a valid value", MsgBoxStyle.Exclamation, Nothing)
				Me.Conatxt.Text = 0.ToString("#0.00")
				Positioncal.ConeAngle = 0.0
			End If
		End Sub

		' Token: 0x06000555 RID: 1365 RVA: 0x00048068 File Offset: 0x00046468
		Private Sub Inioverwtxt_Leave(sender As Object, e As EventArgs)
			If Char.IsNumber(Conversions.ToChar(Me.Inioverwtxt.Text)) Then
				Dim value As Double = Conversions.ToDouble(Me.Inioverwtxt.Text)
				Me.Inioverwtxt.Text = value.ToString("#0.0")
				Positioncal.MeanderAmp = value
			Else
				Interaction.MsgBox("This is not a valid value (Overweld > 0%)", MsgBoxStyle.Exclamation, Nothing)
				Me.Inioverwtxt.Text = 100.ToString("#0.0")
				Positioncal.IniOverWeld = 100F
			End If
		End Sub

		' Token: 0x06000556 RID: 1366 RVA: 0x000480F0 File Offset: 0x000464F0
		Private Sub Finoverwtxt_Leave(sender As Object, e As EventArgs)
			If Char.IsNumber(Conversions.ToChar(Me.Finoverwtxt.Text)) Then
				Dim value As Double = Conversions.ToDouble(Me.Finoverwtxt.Text)
				Me.Finoverwtxt.Text = value.ToString("#0.0")
				Positioncal.MeanderPitch = value
			Else
				Interaction.MsgBox("This is not a valid value (Overweld > 0%)", MsgBoxStyle.Exclamation, Nothing)
				Me.Finoverwtxt.Text = 100.ToString("#0.0")
				Positioncal.FinOverWeld = 100F
			End If
		End Sub

		' Token: 0x06000557 RID: 1367 RVA: 0x00048178 File Offset: 0x00046578
		Private Sub Initang_Leave(sender As Object, e As EventArgs)
			If Char.IsNumber(Conversions.ToChar(Me.Initang.Text)) Then
				Dim value As Double = Conversions.ToDouble(Me.Initang.Text)
				Me.Initang.Text = value.ToString("#0.00")
				Positioncal.InitialAng = value
			Else
				Interaction.MsgBox("This is not a valid value", MsgBoxStyle.Exclamation, Nothing)
				Me.Initang.Text = 0.ToString("#0.00")
				Positioncal.InitialAng = 0.0
			End If
		End Sub

		' Token: 0x06000558 RID: 1368 RVA: 0x00048204 File Offset: 0x00046604
		Private Sub A1_Click(sender As Object, e As EventArgs)
			If Me.A1.Checked Then
				Positioncal.StationPosition = 1
			End If
		End Sub

		' Token: 0x06000559 RID: 1369 RVA: 0x0004821C File Offset: 0x0004661C
		Private Sub A2_CheckedChanged(sender As Object, e As EventArgs)
			If Me.A2.Checked Then
				Positioncal.StationPosition = 2
			End If
		End Sub

		' Token: 0x0600055A RID: 1370 RVA: 0x00048234 File Offset: 0x00046634
		Private Sub A3_CheckedChanged(sender As Object, e As EventArgs)
			If Me.A3.Checked Then
				Positioncal.StationPosition = 3
			End If
		End Sub

		' Token: 0x0600055B RID: 1371 RVA: 0x0004824C File Offset: 0x0004664C
		Private Sub WD_20_CheckedChanged(sender As Object, e As EventArgs)
			If Me.WD_20.Checked Then
				Positioncal.Toolno = 0
			End If
		End Sub

		' Token: 0x0600055C RID: 1372 RVA: 0x00048264 File Offset: 0x00046664
		Private Sub WD_13_CheckedChanged(sender As Object, e As EventArgs)
			If Me.WD_13.Checked Then
				Positioncal.Toolno = 1
			End If
		End Sub

		' Token: 0x0600055D RID: 1373 RVA: 0x0004827C File Offset: 0x0004667C
		Private Sub CheckBox2_Click(sender As Object, e As EventArgs)
			Dim form2rect As Rectangle = New Rectangle(50, 100, 694, 440)
			If Me.CurrPosStat.Checked Then
				MyProject.Forms.Posıtıonupload.DesktopBounds = form2rect
				MyProject.Forms.Posıtıonupload.ShowDialog()
				If MyProject.Forms.Posıtıonupload.DialogResult = DialogResult.OK Then
					Positioncal.CurrPos = 1S
					Me.Xtxt.Text = Positioncal.Position(0, 0).ToString("#0.0")
					Me.Ytxt.Text = Positioncal.Position(1, 0).ToString("#0.0")
					Me.Ztxt.Text = Positioncal.Position(2, 0).ToString("#0.0")
					Positioncal.WorkYAxisTilt = Conversions.ToDouble(Positioncal.Position(4, 0).ToString("#0.00"))
					Positioncal.WorkZAxisYaw = Conversions.ToDouble(Positioncal.Position(5, 0).ToString("#0.00"))
					Me.Tooloffsettxt.Text = "0.0"
					Positioncal.ToolOffset = 0.0
					If Positioncal.Position(3, 0) > 0.0 Then
						Me.Postatxt.Text = (Positioncal.Position(3, 0) - 90.0).ToString("#0.00")
					Else
						Me.Postatxt.Text = (Positioncal.Position(3, 0) + 180.0 + 90.0).ToString("#0.00")
					End If
					Me.Xtxt_Leave(Me, e)
					Me.Ytxt_Leave(Me, e)
					Me.Ztxt_Leave(Me, e)
					Me.Postatxt_Leave(Me, e)
				Else
					Me.CurrPosStat.Checked = False
					Positioncal.CurrPos = 0S
				End If
			Else
				Me.Xtxt.Text = Positioncal.Xpos.ToString("#0.0")
				Me.Ytxt.Text = Positioncal.Ypos.ToString("#0.0")
				Me.Ztxt.Text = Positioncal.Zpos.ToString("#0.0")
				Me.Postatxt.Text = Positioncal.PostureAngle.ToString("#0.00")
				Positioncal.CurrPos = 0S
			End If
		End Sub

		' Token: 0x0600055E RID: 1374 RVA: 0x000484D0 File Offset: 0x000468D0
		Private Sub Lengthtxt_TextChanged(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x0600055F RID: 1375 RVA: 0x000484D4 File Offset: 0x000468D4
		Private Sub Lengthtxt_Leave(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x06000560 RID: 1376 RVA: 0x000484D8 File Offset: 0x000468D8
		Private Sub POCKETPARAM_Load(sender As Object, e As EventArgs)
			Me.Diatxt.Text = Positioncal.Diameter.ToString("#0.0")
			Me.Widthtxt.Text = Positioncal.Width1.ToString("#0.0")
			Me.Xtxt.Text = Positioncal.Xpos.ToString("#0.00")
			Me.Ytxt.Text = Positioncal.Ypos.ToString("#0.00")
			Me.Ztxt.Text = Positioncal.Zpos.ToString("#0.00")
			Me.Pittxt.Text = Positioncal.Pitch.ToString("#0.00")
			Me.Postatxt.Text = Positioncal.PostureAngle.ToString("#0.00")
			Me.Conatxt.Text = Positioncal.ConeAngle.ToString("#0.00")
			Me.Inioverwtxt.Text = Positioncal.IniOverWeld.ToString("#0.0")
			Me.Finoverwtxt.Text = Positioncal.FinOverWeld.ToString("#0.0")
			Me.Initang.Text = Positioncal.InitialAng.ToString("#0.00")
			Select Case Positioncal.StationPosition
				Case 1
					Me.A1.Checked = True
				Case 2
					Me.A2.Checked = True
				Case 3
					Me.A3.Checked = True
			End Select
		End Sub

		' Token: 0x040001C1 RID: 449
		<AccessedThroughProperty("Diatxt")>
		Private _Diatxt As TextBox

		' Token: 0x040001C2 RID: 450
		<AccessedThroughProperty("Widthtxt")>
		Private _Widthtxt As TextBox

		' Token: 0x040001C3 RID: 451
		<AccessedThroughProperty("Xtxt")>
		Private _Xtxt As TextBox

		' Token: 0x040001C4 RID: 452
		<AccessedThroughProperty("Pittxt")>
		Private _Pittxt As TextBox

		' Token: 0x040001C5 RID: 453
		<AccessedThroughProperty("GroupBox2")>
		Private _GroupBox2 As GroupBox

		' Token: 0x040001C6 RID: 454
		<AccessedThroughProperty("Cnfrmbtn")>
		Private _Cnfrmbtn As Button

		' Token: 0x040001C7 RID: 455
		<AccessedThroughProperty("Cnlbtn")>
		Private _Cnlbtn As Button

		' Token: 0x040001C8 RID: 456
		<AccessedThroughProperty("GroupBox3")>
		Private _GroupBox3 As GroupBox

		' Token: 0x040001C9 RID: 457
		<AccessedThroughProperty("Postatxt")>
		Private _Postatxt As TextBox

		' Token: 0x040001CA RID: 458
		<AccessedThroughProperty("Inioverwtxt")>
		Private _Inioverwtxt As TextBox

		' Token: 0x040001CB RID: 459
		<AccessedThroughProperty("Finoverwtxt")>
		Private _Finoverwtxt As TextBox

		' Token: 0x040001CC RID: 460
		<AccessedThroughProperty("Initang")>
		Private _Initang As TextBox

		' Token: 0x040001CD RID: 461
		<AccessedThroughProperty("Tooloffsettxt")>
		Private _Tooloffsettxt As TextBox

		' Token: 0x040001CE RID: 462
		<AccessedThroughProperty("Ztxt")>
		Private _Ztxt As TextBox

		' Token: 0x040001CF RID: 463
		<AccessedThroughProperty("Ytxt")>
		Private _Ytxt As TextBox

		' Token: 0x040001D0 RID: 464
		<AccessedThroughProperty("GroupBox1")>
		Private _GroupBox1 As GroupBox

		' Token: 0x040001D1 RID: 465
		<AccessedThroughProperty("A3")>
		Private _A3 As RadioButton

		' Token: 0x040001D2 RID: 466
		<AccessedThroughProperty("A2")>
		Private _A2 As RadioButton

		' Token: 0x040001D3 RID: 467
		<AccessedThroughProperty("A1")>
		Private _A1 As RadioButton

		' Token: 0x040001D4 RID: 468
		<AccessedThroughProperty("GroupBox5")>
		Private _GroupBox5 As GroupBox

		' Token: 0x040001D5 RID: 469
		<AccessedThroughProperty("WD_13")>
		Private _WD_13 As RadioButton

		' Token: 0x040001D6 RID: 470
		<AccessedThroughProperty("WD_20")>
		Private _WD_20 As RadioButton

		' Token: 0x040001D7 RID: 471
		<AccessedThroughProperty("CurrPosStat")>
		Private _CurrPosStat As CheckBox

		' Token: 0x040001D8 RID: 472
		<AccessedThroughProperty("Conatxt")>
		Private _Conatxt As TextBox

		' Token: 0x040001D9 RID: 473
		<AccessedThroughProperty("Lengthtxt")>
		Private _Lengthtxt As TextBox
	End Class
End Namespace
