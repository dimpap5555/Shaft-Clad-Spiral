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
	' Token: 0x02000021 RID: 33
	<DesignerGenerated()>
	Public Partial Class SPARAM
		Inherits Form

		' Token: 0x060005E6 RID: 1510 RVA: 0x0004CC80 File Offset: 0x0004B080
		<DebuggerNonUserCode()>
		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.scladparam_load
			Me.InitializeComponent()
		End Sub

		' Token: 0x170001E0 RID: 480
		' (get) Token: 0x060005E9 RID: 1513 RVA: 0x0004EA30 File Offset: 0x0004CE30
		' (set) Token: 0x060005EA RID: 1514 RVA: 0x0004EA44 File Offset: 0x0004CE44
		Friend Overridable Property Diatxt As TextBox
			<DebuggerNonUserCode()>
			Get
				Return Me._Diatxt
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As EventHandler = AddressOf Me.Diatxt_Leave
				If Me._Diatxt IsNot Nothing Then
					RemoveHandler Me._Diatxt.Leave, value2
				End If
				Me._Diatxt = value
				If Me._Diatxt IsNot Nothing Then
					AddHandler Me._Diatxt.Leave, value2
				End If
			End Set
		End Property

		' Token: 0x170001E1 RID: 481
		' (get) Token: 0x060005EB RID: 1515 RVA: 0x0004EA90 File Offset: 0x0004CE90
		' (set) Token: 0x060005EC RID: 1516 RVA: 0x0004EAA4 File Offset: 0x0004CEA4
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

		' Token: 0x170001E2 RID: 482
		' (get) Token: 0x060005ED RID: 1517 RVA: 0x0004EAF0 File Offset: 0x0004CEF0
		' (set) Token: 0x060005EE RID: 1518 RVA: 0x0004EB04 File Offset: 0x0004CF04
		Friend Overridable Property Distxt As TextBox
			<DebuggerNonUserCode()>
			Get
				Return Me._Distxt
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As EventHandler = AddressOf Me.Distxt_Leave
				If Me._Distxt IsNot Nothing Then
					RemoveHandler Me._Distxt.Leave, value2
				End If
				Me._Distxt = value
				If Me._Distxt IsNot Nothing Then
					AddHandler Me._Distxt.Leave, value2
				End If
			End Set
		End Property

		' Token: 0x170001E3 RID: 483
		' (get) Token: 0x060005EF RID: 1519 RVA: 0x0004EB50 File Offset: 0x0004CF50
		' (set) Token: 0x060005F0 RID: 1520 RVA: 0x0004EB64 File Offset: 0x0004CF64
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

		' Token: 0x170001E4 RID: 484
		' (get) Token: 0x060005F1 RID: 1521 RVA: 0x0004EBB0 File Offset: 0x0004CFB0
		' (set) Token: 0x060005F2 RID: 1522 RVA: 0x0004EBC4 File Offset: 0x0004CFC4
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

		' Token: 0x170001E5 RID: 485
		' (get) Token: 0x060005F3 RID: 1523 RVA: 0x0004EBD0 File Offset: 0x0004CFD0
		' (set) Token: 0x060005F4 RID: 1524 RVA: 0x0004EBE4 File Offset: 0x0004CFE4
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

		' Token: 0x170001E6 RID: 486
		' (get) Token: 0x060005F5 RID: 1525 RVA: 0x0004EC30 File Offset: 0x0004D030
		' (set) Token: 0x060005F6 RID: 1526 RVA: 0x0004EC44 File Offset: 0x0004D044
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

		' Token: 0x170001E7 RID: 487
		' (get) Token: 0x060005F7 RID: 1527 RVA: 0x0004EC90 File Offset: 0x0004D090
		' (set) Token: 0x060005F8 RID: 1528 RVA: 0x0004ECA4 File Offset: 0x0004D0A4
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

		' Token: 0x170001E8 RID: 488
		' (get) Token: 0x060005F9 RID: 1529 RVA: 0x0004ECB0 File Offset: 0x0004D0B0
		' (set) Token: 0x060005FA RID: 1530 RVA: 0x0004ECC4 File Offset: 0x0004D0C4
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

		' Token: 0x170001E9 RID: 489
		' (get) Token: 0x060005FB RID: 1531 RVA: 0x0004ED10 File Offset: 0x0004D110
		' (set) Token: 0x060005FC RID: 1532 RVA: 0x0004ED24 File Offset: 0x0004D124
		Friend Overridable Property Meandramp As TextBox
			<DebuggerNonUserCode()>
			Get
				Return Me._Meandramp
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As EventHandler = AddressOf Me.Meandramp_Leave
				If Me._Meandramp IsNot Nothing Then
					RemoveHandler Me._Meandramp.Leave, value2
				End If
				Me._Meandramp = value
				If Me._Meandramp IsNot Nothing Then
					AddHandler Me._Meandramp.Leave, value2
				End If
			End Set
		End Property

		' Token: 0x170001EA RID: 490
		' (get) Token: 0x060005FD RID: 1533 RVA: 0x0004ED70 File Offset: 0x0004D170
		' (set) Token: 0x060005FE RID: 1534 RVA: 0x0004ED84 File Offset: 0x0004D184
		Friend Overridable Property Conatxt As TextBox
			<DebuggerNonUserCode()>
			Get
				Return Me._Conatxt
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As EventHandler = AddressOf Me.Conatxt_Leave
				If Me._Conatxt IsNot Nothing Then
					RemoveHandler Me._Conatxt.Leave, value2
				End If
				Me._Conatxt = value
				If Me._Conatxt IsNot Nothing Then
					AddHandler Me._Conatxt.Leave, value2
				End If
			End Set
		End Property

		' Token: 0x170001EB RID: 491
		' (get) Token: 0x060005FF RID: 1535 RVA: 0x0004EDD0 File Offset: 0x0004D1D0
		' (set) Token: 0x06000600 RID: 1536 RVA: 0x0004EDE4 File Offset: 0x0004D1E4
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

		' Token: 0x170001EC RID: 492
		' (get) Token: 0x06000601 RID: 1537 RVA: 0x0004EE30 File Offset: 0x0004D230
		' (set) Token: 0x06000602 RID: 1538 RVA: 0x0004EE44 File Offset: 0x0004D244
		Friend Overridable Property MeandrFlg As CheckBox
			<DebuggerNonUserCode()>
			Get
				Return Me._MeandrFlg
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As CheckBox)
				Dim value2 As EventHandler = AddressOf Me.MeandrFlg_click
				If Me._MeandrFlg IsNot Nothing Then
					RemoveHandler Me._MeandrFlg.Click, value2
				End If
				Me._MeandrFlg = value
				If Me._MeandrFlg IsNot Nothing Then
					AddHandler Me._MeandrFlg.Click, value2
				End If
			End Set
		End Property

		' Token: 0x170001ED RID: 493
		' (get) Token: 0x06000603 RID: 1539 RVA: 0x0004EE90 File Offset: 0x0004D290
		' (set) Token: 0x06000604 RID: 1540 RVA: 0x0004EEA4 File Offset: 0x0004D2A4
		Friend Overridable Property Meandrptc As TextBox
			<DebuggerNonUserCode()>
			Get
				Return Me._Meandrptc
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As EventHandler = AddressOf Me.Meandrptc_Leave
				If Me._Meandrptc IsNot Nothing Then
					RemoveHandler Me._Meandrptc.Leave, value2
				End If
				Me._Meandrptc = value
				If Me._Meandrptc IsNot Nothing Then
					AddHandler Me._Meandrptc.Leave, value2
				End If
			End Set
		End Property

		' Token: 0x170001EE RID: 494
		' (get) Token: 0x06000605 RID: 1541 RVA: 0x0004EEF0 File Offset: 0x0004D2F0
		' (set) Token: 0x06000606 RID: 1542 RVA: 0x0004EF04 File Offset: 0x0004D304
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

		' Token: 0x170001EF RID: 495
		' (get) Token: 0x06000607 RID: 1543 RVA: 0x0004EF50 File Offset: 0x0004D350
		' (set) Token: 0x06000608 RID: 1544 RVA: 0x0004EF64 File Offset: 0x0004D364
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

		' Token: 0x170001F0 RID: 496
		' (get) Token: 0x06000609 RID: 1545 RVA: 0x0004EF70 File Offset: 0x0004D370
		' (set) Token: 0x0600060A RID: 1546 RVA: 0x0004EF84 File Offset: 0x0004D384
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

		' Token: 0x170001F1 RID: 497
		' (get) Token: 0x0600060B RID: 1547 RVA: 0x0004EFD0 File Offset: 0x0004D3D0
		' (set) Token: 0x0600060C RID: 1548 RVA: 0x0004EFE4 File Offset: 0x0004D3E4
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

		' Token: 0x170001F2 RID: 498
		' (get) Token: 0x0600060D RID: 1549 RVA: 0x0004F030 File Offset: 0x0004D430
		' (set) Token: 0x0600060E RID: 1550 RVA: 0x0004F044 File Offset: 0x0004D444
		Friend Overridable Property Tooloffsettxt As TextBox
			<DebuggerNonUserCode()>
			Get
				Return Me._Tooloffsettxt
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As EventHandler = AddressOf Me.Tooloffsettxt_Leave
				If Me._Tooloffsettxt IsNot Nothing Then
					RemoveHandler Me._Tooloffsettxt.Leave, value2
				End If
				Me._Tooloffsettxt = value
				If Me._Tooloffsettxt IsNot Nothing Then
					AddHandler Me._Tooloffsettxt.Leave, value2
				End If
			End Set
		End Property

		' Token: 0x170001F3 RID: 499
		' (get) Token: 0x0600060F RID: 1551 RVA: 0x0004F090 File Offset: 0x0004D490
		' (set) Token: 0x06000610 RID: 1552 RVA: 0x0004F0A4 File Offset: 0x0004D4A4
		Friend Overridable Property GroupBox4 As GroupBox
			<DebuggerNonUserCode()>
			Get
				Return Me._GroupBox4
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As GroupBox)
				Me._GroupBox4 = value
			End Set
		End Property

		' Token: 0x170001F4 RID: 500
		' (get) Token: 0x06000611 RID: 1553 RVA: 0x0004F0B0 File Offset: 0x0004D4B0
		' (set) Token: 0x06000612 RID: 1554 RVA: 0x0004F0C4 File Offset: 0x0004D4C4
		Friend Overridable Property Rightdirflg As RadioButton
			<DebuggerNonUserCode()>
			Get
				Return Me._Rightdirflg
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As RadioButton)
				Dim value2 As EventHandler = AddressOf Me.Rightdirflg_CheckedChanged
				If Me._Rightdirflg IsNot Nothing Then
					RemoveHandler Me._Rightdirflg.Click, value2
				End If
				Me._Rightdirflg = value
				If Me._Rightdirflg IsNot Nothing Then
					AddHandler Me._Rightdirflg.Click, value2
				End If
			End Set
		End Property

		' Token: 0x170001F5 RID: 501
		' (get) Token: 0x06000613 RID: 1555 RVA: 0x0004F110 File Offset: 0x0004D510
		' (set) Token: 0x06000614 RID: 1556 RVA: 0x0004F124 File Offset: 0x0004D524
		Friend Overridable Property Leftdirflg As RadioButton
			<DebuggerNonUserCode()>
			Get
				Return Me._Leftdirflg
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As RadioButton)
				Dim value2 As EventHandler = AddressOf Me.Leftdirflg_CheckedChanged
				If Me._Leftdirflg IsNot Nothing Then
					RemoveHandler Me._Leftdirflg.Click, value2
				End If
				Me._Leftdirflg = value
				If Me._Leftdirflg IsNot Nothing Then
					AddHandler Me._Leftdirflg.Click, value2
				End If
			End Set
		End Property

		' Token: 0x170001F6 RID: 502
		' (get) Token: 0x06000615 RID: 1557 RVA: 0x0004F170 File Offset: 0x0004D570
		' (set) Token: 0x06000616 RID: 1558 RVA: 0x0004F184 File Offset: 0x0004D584
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

		' Token: 0x170001F7 RID: 503
		' (get) Token: 0x06000617 RID: 1559 RVA: 0x0004F1D0 File Offset: 0x0004D5D0
		' (set) Token: 0x06000618 RID: 1560 RVA: 0x0004F1E4 File Offset: 0x0004D5E4
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

		' Token: 0x170001F8 RID: 504
		' (get) Token: 0x06000619 RID: 1561 RVA: 0x0004F230 File Offset: 0x0004D630
		' (set) Token: 0x0600061A RID: 1562 RVA: 0x0004F244 File Offset: 0x0004D644
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

		' Token: 0x170001F9 RID: 505
		' (get) Token: 0x0600061B RID: 1563 RVA: 0x0004F250 File Offset: 0x0004D650
		' (set) Token: 0x0600061C RID: 1564 RVA: 0x0004F264 File Offset: 0x0004D664
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

		' Token: 0x170001FA RID: 506
		' (get) Token: 0x0600061D RID: 1565 RVA: 0x0004F2B0 File Offset: 0x0004D6B0
		' (set) Token: 0x0600061E RID: 1566 RVA: 0x0004F2C4 File Offset: 0x0004D6C4
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

		' Token: 0x170001FB RID: 507
		' (get) Token: 0x0600061F RID: 1567 RVA: 0x0004F310 File Offset: 0x0004D710
		' (set) Token: 0x06000620 RID: 1568 RVA: 0x0004F324 File Offset: 0x0004D724
		Friend Overridable Property CurrPosStat As CheckBox
			<DebuggerNonUserCode()>
			Get
				Return Me._CurrPosStat
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As CheckBox)
				Dim value2 As EventHandler = AddressOf Me.CurrPosStat_Click
				If Me._CurrPosStat IsNot Nothing Then
					RemoveHandler Me._CurrPosStat.Click, value2
				End If
				Me._CurrPosStat = value
				If Me._CurrPosStat IsNot Nothing Then
					AddHandler Me._CurrPosStat.Click, value2
				End If
			End Set
		End Property

		' Token: 0x06000621 RID: 1569 RVA: 0x0004F370 File Offset: 0x0004D770
		Private Sub scladparam_load(sender As Object, e As EventArgs)
			Me.Diatxt.Text = Positioncal.Diameter.ToString("#0.0")
			Me.Widthtxt.Text = Positioncal.Width1.ToString("#0.0")
			Me.Distxt.Text = Positioncal.Distance.ToString("#0.00")
			Me.Pittxt.Text = Positioncal.Pitch.ToString("#0.00")
			Me.Tooloffsettxt.Text = Positioncal.ToolOffset.ToString("#0.0")
			Select Case Positioncal.StationPosition
				Case 1
					Me.A1.Checked = True
				Case 2
					Me.A2.Checked = True
				Case 3
					Me.A3.Checked = True
			End Select
			If Positioncal.CladdingDir = 1 Then
				Me.Rightdirflg.Checked = True
			Else
				Me.Leftdirflg.Checked = True
			End If
			Me.Postatxt.Text = Positioncal.PostureAngle.ToString("#0.00")
			Me.Conatxt.Text = Positioncal.ConeAngle.ToString("#0.00")
			Me.Inioverwtxt.Text = Positioncal.IniOverWeld.ToString("#0.0")
			Me.Finoverwtxt.Text = Positioncal.FinOverWeld.ToString("#0.0")
			Me.Meandramp.Text = Positioncal.MeanderAmp.ToString("#0.0")
			Me.Meandrptc.Text = Positioncal.MeanderPitch.ToString("#0.0")
			If Positioncal.MeanderFlg = 1S Then
				Me.MeandrFlg.Checked = True
			Else
				Me.MeandrFlg.Checked = False
			End If
			Me.CurrPosStat.Checked = (Positioncal.CurrPos <> 0S)
		End Sub

		' Token: 0x06000622 RID: 1570 RVA: 0x0004F534 File Offset: 0x0004D934
		Private Sub Cnlbtn_Click(sender As Object, e As EventArgs)
			Me.Close()
		End Sub

		' Token: 0x06000623 RID: 1571 RVA: 0x0004F53C File Offset: 0x0004D93C
		Private Sub Cnfrmbtn_Click(sender As Object, e As EventArgs)
			Dim fs As FileStream = New FileStream(Application.StartupPath + "\Scladparam.txt", FileMode.Create)
			Dim w As StreamWriter = New StreamWriter(fs)
			Positioncal.Diameter = Conversions.ToDouble(Me.Diatxt.Text) + CDbl((CInt((2S * Positioncal.CurrPos)) * Positioncal.CladdingDir)) * Positioncal.CladWidth / 2.0 * Math.Sin(Positioncal.ConeAngle * 3.141592653589793 / 180.0)
			Positioncal.Distance = Conversions.ToDouble(Me.Distxt.Text) - CDbl((CInt(Positioncal.CurrPos) * Positioncal.CladdingDir)) * Positioncal.CladWidth / 2.0 * Math.Cos(Positioncal.ConeAngle * 3.141592653589793 / 180.0)
			Positioncal.PostureAngle = Conversions.ToDouble(Me.Postatxt.Text)
			Positioncal.InitialAng = Conversions.ToDouble(Me.Initang.Text) - CDbl((Positioncal.DirectionFlg * 360)) / CDbl(Positioncal.PPR) - Math.Floor((Conversions.ToDouble(Me.Initang.Text) - CDbl((Positioncal.DirectionFlg * 360)) / CDbl(Positioncal.PPR)) / 360.0) * 360.0
			Dim num As Integer = CInt(Math.Round(Positioncal.Width1))
			If num < CInt(Math.Round(Positioncal.CladWidth)) Then
				Dim msgbxres As Short = CShort(Interaction.MsgBox("The minimum clad width is " + Positioncal.CladWidth.ToString("#.0") + ". Adjust width accordingly?" & vbCrLf & "(If yes, meander movement will also be disabled)", MsgBoxStyle.YesNo, "Question"))
				If msgbxres = 6S Then
					Positioncal.Width1 = Positioncal.CladWidth
					Me.Widthtxt.Text = Positioncal.Width1.ToString("#.0")
					Positioncal.MeanderFlg = 0S
					Me.MeandrFlg.CheckState = CheckState.Unchecked
					Interaction.MsgBox("The width has been recalculated to " + Positioncal.Width1.ToString("#0.0 mm"), MsgBoxStyle.Information, "Information")
				End If
			ElseIf num < CInt(Math.Round(2.0 * Positioncal.MeanderAmp + Positioncal.CladWidth)) Then
				If Me.MeandrFlg.CheckState = CheckState.Checked Then
					Dim msgbxres As Short = CShort(Interaction.MsgBox("The desired width is smaller than the meander width." & vbCrLf & "Adjust meander amplitude accordingly (Yes)?" & vbCrLf & "Disable meander movement (No)?", MsgBoxStyle.YesNo, "Question"))
					If msgbxres = 6S Then
						' The following expression was wrapped in a unchecked-expression
						Positioncal.MeanderAmp = Positioncal.Width1 - Positioncal.CladWidth / 2.0
						Me.Meandramp.Text = Positioncal.MeanderAmp.ToString("#.0")
						Interaction.MsgBox("The meander amplitude has been recalculated to " + Conversions.ToString(Positioncal.MeanderAmp) + "mm", MsgBoxStyle.Information, "Information")
					ElseIf msgbxres = 7S Then
						Positioncal.MeanderFlg = 0S
						Me.MeandrFlg.CheckState = CheckState.Unchecked
					End If
				End If
			ElseIf num < CInt(Math.Round(1.5 * Positioncal.Pitch + 2.0 * Positioncal.MeanderAmp + Positioncal.CladWidth)) AndAlso Me.MeandrFlg.CheckState = CheckState.Checked Then
				Dim msgbxres As Short = CShort(Interaction.MsgBox("The desired width is only slightly larger to the clad width." & vbCrLf & "Adjust meander amplitude to achieve the desired width in one revolution?", MsgBoxStyle.YesNo, "Question"))
				If msgbxres = 6S Then
					' The following expression was wrapped in a unchecked-expression
					Positioncal.MeanderAmp = Positioncal.Width1 - Positioncal.CladWidth / 2.0
					Me.Meandramp.Text = Positioncal.MeanderAmp.ToString("#.0")
					Interaction.MsgBox("The meander amplitude has been recalculated to " + Positioncal.MeanderAmp.ToString("#0.0 mm"), MsgBoxStyle.Information, "Information")
				End If
			End If
			Dim rpm As Double = Positioncal.ProcessSpeed * 60.0 / (3.141592653589793 * Positioncal.Diameter)
			If rpm > 24.691358024691358 Then
				Interaction.MsgBox("The Process Speed is too high for the specified diameter. It will be reduced to " + 24.691358024691358.ToString("#0.0 mm/s"), MsgBoxStyle.Exclamation, Nothing)
				Positioncal.ProcessSpeed = 24.691358024691358
			End If
			If Positioncal.Width1 < Positioncal.CladWidth Then
				Interaction.MsgBox("The width should be at least " + Positioncal.CladWidth.ToString("#.0") + ". Please adjust accordingly", MsgBoxStyle.Exclamation, "Information")
			Else
				w.WriteLine(Me.Diatxt.Text)
				w.WriteLine(Me.Widthtxt.Text)
				w.WriteLine(Me.Distxt.Text)
				w.WriteLine(Me.Pittxt.Text)
				w.WriteLine(Me.Tooloffsettxt.Text)
				w.WriteLine(Positioncal.StationPosition.ToString())
				w.WriteLine(Positioncal.CladdingDir.ToString())
				w.WriteLine(Me.Postatxt.Text)
				w.WriteLine(Me.Conatxt.Text)
				w.WriteLine(Me.Inioverwtxt.Text)
				w.WriteLine(Me.Finoverwtxt.Text)
				w.WriteLine(Me.Meandramp.Text)
				w.WriteLine(Me.Meandrptc.Text)
				w.WriteLine(Me.Initang.Text)
				w.WriteLine(Positioncal.MeanderFlg.ToString())
				w.WriteLine(Positioncal.CurrPos.ToString())
				w.Close()
				Me.DialogResult = DialogResult.OK
				Me.Close()
			End If
		End Sub

		' Token: 0x06000624 RID: 1572 RVA: 0x0004FA64 File Offset: 0x0004DE64
		Private Sub Tooloffsettxt_Leave(sender As Object, e As EventArgs)
			If Versioned.IsNumeric(Me.Tooloffsettxt.Text) Then
				Dim value As Double = Conversions.ToDouble(Me.Tooloffsettxt.Text)
				Me.Tooloffsettxt.Text = value.ToString("#0.0")
				Positioncal.ToolOffset = Conversions.ToDouble(Me.Tooloffsettxt.Text)
			Else
				Interaction.MsgBox("This is not a valid value", MsgBoxStyle.Exclamation, Nothing)
				Me.Tooloffsettxt.Text = 0.ToString("#0.0")
				Positioncal.ToolOffset = 0.0
			End If
		End Sub

		' Token: 0x06000625 RID: 1573 RVA: 0x0004FAF8 File Offset: 0x0004DEF8
		Private Sub Diatxt_Leave(sender As Object, e As EventArgs)
			If Char.IsNumber(Conversions.ToChar(Me.Diatxt.Text)) Then
				Dim value As Double = Conversions.ToDouble(Me.Diatxt.Text)
				Me.Diatxt.Text = value.ToString("#0.0")
				Positioncal.Diameter = Conversions.ToDouble(Me.Diatxt.Text)
			Else
				Interaction.MsgBox("This is not a valid value (0<D<500mm)", MsgBoxStyle.Exclamation, Nothing)
				Me.Diatxt.Text = 50.ToString("#0.0")
				Positioncal.Diameter = 50.0
			End If
		End Sub

		' Token: 0x06000626 RID: 1574 RVA: 0x0004FB94 File Offset: 0x0004DF94
		Private Sub Widthtxt_Leave(sender As Object, e As EventArgs)
			If Char.IsNumber(Conversions.ToChar(Me.Widthtxt.Text)) Then
				Dim value As Double = Conversions.ToDouble(Me.Widthtxt.Text)
				Me.Widthtxt.Text = value.ToString("#0.0")
				Positioncal.Width1 = value
			Else
				Interaction.MsgBox("This is not a valid value (0 < W mm)", MsgBoxStyle.Exclamation, Nothing)
				Me.Widthtxt.Text = 15.ToString("#0.0")
				Positioncal.Width1 = 15.0
			End If
		End Sub

		' Token: 0x06000627 RID: 1575 RVA: 0x0004FC20 File Offset: 0x0004E020
		Private Sub Distxt_Leave(sender As Object, e As EventArgs)
			If Versioned.IsNumeric(Me.Distxt.Text) Then
				If Conversions.ToDouble(Me.Distxt.Text) >= Positioncal.MinDistance Then
					Dim value As Double = Conversions.ToDouble(Me.Distxt.Text)
					Me.Distxt.Text = value.ToString("#0.00")
					Positioncal.Distance = value
				Else
					Interaction.MsgBox("The minimum distance from the Chuck has been specified to " + Positioncal.MinDistance.ToString("#0.00"), MsgBoxStyle.Exclamation, Nothing)
					Me.Distxt.Text = 500.ToString("#0.00")
					Positioncal.Distance = 500.0
				End If
			Else
				Interaction.MsgBox("This is not a valid value", MsgBoxStyle.Exclamation, Nothing)
				Me.Distxt.Text = 500.ToString("#0.00")
				Positioncal.Distance = 500.0
			End If
		End Sub

		' Token: 0x06000628 RID: 1576 RVA: 0x0004FD14 File Offset: 0x0004E114
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

		' Token: 0x06000629 RID: 1577 RVA: 0x0004FDA0 File Offset: 0x0004E1A0
		Private Sub Postatxt_Leave(sender As Object, e As EventArgs)
			If Versioned.IsNumeric(Me.Postatxt.Text) Then
				If Conversions.ToDouble(Me.Postatxt.Text) >= 0.0 And Conversions.ToDouble(Me.Postatxt.Text) <= 180.0 Then
					Dim value As Double = Conversions.ToDouble(Me.Postatxt.Text)
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

		' Token: 0x0600062A RID: 1578 RVA: 0x0004FEA0 File Offset: 0x0004E2A0
		Private Sub Conatxt_Leave(sender As Object, e As EventArgs)
			If Versioned.IsNumeric(Me.Conatxt.Text) Then
				If Conversions.ToDouble(Me.Conatxt.Text) <= 120.0 And Conversions.ToDouble(Me.Conatxt.Text) >= -120.0 Then
					Dim value As Double = Conversions.ToDouble(Me.Conatxt.Text)
					Me.Conatxt.Text = value.ToString("#0.00")
					Positioncal.ConeAngle = value
				Else
					Interaction.MsgBox("The Cone angle should be within -90 and 90 degrees to the axis", MsgBoxStyle.Exclamation, Nothing)
					Me.Conatxt.Text = 0.ToString("#0.00")
					Positioncal.ConeAngle = 0.0
				End If
			Else
				Interaction.MsgBox("This is not a valid value", MsgBoxStyle.Exclamation, Nothing)
				Me.Conatxt.Text = 0.ToString("#0.00")
				Positioncal.ConeAngle = 0.0
			End If
		End Sub

		' Token: 0x0600062B RID: 1579 RVA: 0x0004FFA0 File Offset: 0x0004E3A0
		Private Sub Inioverwtxt_Leave(sender As Object, e As EventArgs)
			If Versioned.IsNumeric(Me.Inioverwtxt.Text) Then
				If Conversions.ToDouble(Me.Inioverwtxt.Text) <= 500.0 And Conversions.ToDouble(Me.Inioverwtxt.Text) >= 0.0 Then
					Dim value As Double = Conversions.ToDouble(Me.Inioverwtxt.Text)
					Me.Inioverwtxt.Text = value.ToString("#0.0")
					Positioncal.IniOverWeld = CSng(value)
				Else
					Interaction.MsgBox("The Initial overweld should be within 0 and 500%", MsgBoxStyle.Exclamation, Nothing)
					Me.Inioverwtxt.Text = 100.ToString("#0.0")
					Positioncal.IniOverWeld = 100F
				End If
			Else
				Interaction.MsgBox("This is not a valid value (0 <= Overweld < 500 %)", MsgBoxStyle.Exclamation, Nothing)
				Me.Inioverwtxt.Text = 100.ToString("#0.0")
				Positioncal.IniOverWeld = 100F
			End If
		End Sub

		' Token: 0x0600062C RID: 1580 RVA: 0x00050098 File Offset: 0x0004E498
		Private Sub Finoverwtxt_Leave(sender As Object, e As EventArgs)
			If Char.IsNumber(Conversions.ToChar(Me.Finoverwtxt.Text)) Then
				If Conversions.ToDouble(Me.Finoverwtxt.Text) <= 500.0 And Conversions.ToDouble(Me.Finoverwtxt.Text) >= 0.0 Then
					Dim value As Double = Conversions.ToDouble(Me.Finoverwtxt.Text)
					Me.Finoverwtxt.Text = value.ToString("#0.0")
					Positioncal.FinOverWeld = CSng(value)
				Else
					Interaction.MsgBox("The Final overweld should be within 0 and 500%", MsgBoxStyle.Exclamation, Nothing)
					Me.Finoverwtxt.Text = 100.ToString("#0.0")
					Positioncal.FinOverWeld = 100F
				End If
			Else
				Interaction.MsgBox("This is not a valid value (0 <= Overweld < 500 %)", MsgBoxStyle.Exclamation, Nothing)
				Me.Finoverwtxt.Text = 100.ToString("#0.0")
				Positioncal.FinOverWeld = 100F
			End If
		End Sub

		' Token: 0x0600062D RID: 1581 RVA: 0x00050198 File Offset: 0x0004E598
		Private Sub Meandramp_Leave(sender As Object, e As EventArgs)
			If Char.IsNumber(Conversions.ToChar(Me.Meandramp.Text)) Then
				Dim value As Double = Conversions.ToDouble(Me.Meandramp.Text)
				Me.Meandramp.Text = value.ToString("#0.0")
				Positioncal.MeanderAmp = value
			Else
				Interaction.MsgBox("This is not a valid value (Amplitude > 0 mm)", MsgBoxStyle.Exclamation, Nothing)
				Me.Meandramp.Text = 2.ToString("#0.0")
				Positioncal.MeanderAmp = 2.0
			End If
		End Sub

		' Token: 0x0600062E RID: 1582 RVA: 0x00050224 File Offset: 0x0004E624
		Private Sub Meandrptc_Leave(sender As Object, e As EventArgs)
			If Char.IsNumber(Conversions.ToChar(Me.Meandrptc.Text)) Then
				Dim value As Double = Conversions.ToDouble(Me.Meandrptc.Text)
				Me.Meandrptc.Text = value.ToString("#0.0")
				Positioncal.MeanderPitch = value
			Else
				Interaction.MsgBox("This is not a valid value (Meander Pitch > 0 mm)", MsgBoxStyle.Exclamation, Nothing)
				Me.Meandrptc.Text = 3.ToString("#0.0")
				Positioncal.MeanderPitch = 3.0
			End If
		End Sub

		' Token: 0x0600062F RID: 1583 RVA: 0x000502B0 File Offset: 0x0004E6B0
		Private Sub Initang_Leave(sender As Object, e As EventArgs)
			If Versioned.IsNumeric(Me.Initang.Text) Then
				Dim value As Double = Conversions.ToDouble(Me.Initang.Text)
				Me.Initang.Text = value.ToString("#0.00")
				Positioncal.InitialAng = value - CDbl((Positioncal.DirectionFlg * 360)) / CDbl(Positioncal.PPR) - Math.Floor((value - CDbl((Positioncal.DirectionFlg * 360)) / CDbl(Positioncal.PPR)) / 360.0) * 360.0
			Else
				Interaction.MsgBox("This is not a valid value", MsgBoxStyle.Exclamation, Nothing)
				Me.Initang.Text = 0.ToString("#0.00")
				Positioncal.InitialAng = 0.0 - CDbl((Positioncal.DirectionFlg * 360)) / CDbl(Positioncal.PPR) - Math.Floor((0.0 - CDbl((Positioncal.DirectionFlg * 360)) / CDbl(Positioncal.PPR)) / 360.0) * 360.0
			End If
		End Sub

		' Token: 0x06000630 RID: 1584 RVA: 0x000503C8 File Offset: 0x0004E7C8
		Private Sub CurrPosStat_Click(sender As Object, e As EventArgs)
			Dim form2rect As Rectangle = New Rectangle(50, 100, 694, 440)
			If Me.CurrPosStat.Checked Then
				Global.WindowsApplication1.My.MyProject.Forms.Posıtıonupload.DesktopBounds = form2rect
				Global.WindowsApplication1.My.MyProject.Forms.Posıtıonupload.ShowDialog()
				If Global.WindowsApplication1.My.MyProject.Forms.Posıtıonupload.DialogResult = DialogResult.OK Then
					Positioncal.CurrPos = 1S
					Positioncal.WorkXAxisOffset = Positioncal.Position(0, 0)
					Positioncal.WorkYAxisTilt = Positioncal.Position(4, 0)
					Positioncal.WorkZAxisYaw = Positioncal.Position(5, 0)
					Me.Initang.Text = Positioncal.Position(7, 0).ToString("#0.00")
					Me.Diatxt.Text = (Math.Abs(Positioncal.Position(2, 0)) * 2.0).ToString("#0.00")
					Me.Distxt.Text = Positioncal.Position(1, 0).ToString("#0.00")
					Me.Tooloffsettxt.Text = "0.0"
					Positioncal.ToolOffset = 0.0
					If Positioncal.Position(3, 0) > 0.0 Then
						Me.Postatxt.Text = (Positioncal.Position(3, 0) - 90.0).ToString("#0.00")
					Else
						Me.Postatxt.Text = (Positioncal.Position(3, 0) + 180.0 + 90.0).ToString("#0.00")
					End If
					Me.Diatxt_Leave(Me, e)
					Me.Distxt_Leave(Me, e)
					Me.Initang_Leave(Me, e)
					Me.Postatxt_Leave(Me, e)
				Else
					Me.CurrPosStat.Checked = False
					Positioncal.CurrPos = 0S
				End If
			Else
				Me.Diatxt.Text = Positioncal.Diameter.ToString("#0.00")
				Me.Distxt.Text = Positioncal.Distance.ToString("#0.00")
				Positioncal.CurrPos = 0S
			End If
		End Sub

		' Token: 0x06000631 RID: 1585 RVA: 0x000505EC File Offset: 0x0004E9EC
		Private Sub A1_Click(sender As Object, e As EventArgs)
			If Me.A1.Checked Then
				Positioncal.StationPosition = 1
			End If
		End Sub

		' Token: 0x06000632 RID: 1586 RVA: 0x00050604 File Offset: 0x0004EA04
		Private Sub A2_CheckedChanged(sender As Object, e As EventArgs)
			If Me.A2.Checked Then
				Positioncal.StationPosition = 2
			End If
		End Sub

		' Token: 0x06000633 RID: 1587 RVA: 0x0005061C File Offset: 0x0004EA1C
		Private Sub A3_CheckedChanged(sender As Object, e As EventArgs)
			If Me.A3.Checked Then
				Positioncal.StationPosition = 3
			End If
		End Sub

		' Token: 0x06000634 RID: 1588 RVA: 0x00050634 File Offset: 0x0004EA34
		Private Sub Leftdirflg_CheckedChanged(sender As Object, e As EventArgs)
			If Me.Leftdirflg.Checked Then
				Positioncal.CladdingDir = -1
			End If
		End Sub

		' Token: 0x06000635 RID: 1589 RVA: 0x0005064C File Offset: 0x0004EA4C
		Private Sub Rightdirflg_CheckedChanged(sender As Object, e As EventArgs)
			If Me.Rightdirflg.Checked Then
				Positioncal.CladdingDir = 1
			End If
		End Sub

		' Token: 0x06000636 RID: 1590 RVA: 0x00050664 File Offset: 0x0004EA64
		Private Sub WD_20_CheckedChanged(sender As Object, e As EventArgs)
			If Me.WD_20.Checked Then
				Positioncal.Toolno = 0
			End If
		End Sub

		' Token: 0x06000637 RID: 1591 RVA: 0x0005067C File Offset: 0x0004EA7C
		Private Sub WD_13_CheckedChanged(sender As Object, e As EventArgs)
			If Me.WD_13.Checked Then
				Positioncal.Toolno = 1
			End If
		End Sub

		' Token: 0x06000638 RID: 1592 RVA: 0x00050694 File Offset: 0x0004EA94
		Private Sub MeandrFlg_click(sender As Object, e As EventArgs)
			If Me.MeandrFlg.Checked Then
				Positioncal.MeanderFlg = 1S
			Else
				Positioncal.MeanderFlg = 0S
			End If
		End Sub

		' Token: 0x04000274 RID: 628
		<AccessedThroughProperty("Diatxt")>
		Private _Diatxt As TextBox

		' Token: 0x04000275 RID: 629
		<AccessedThroughProperty("Widthtxt")>
		Private _Widthtxt As TextBox

		' Token: 0x04000276 RID: 630
		<AccessedThroughProperty("Distxt")>
		Private _Distxt As TextBox

		' Token: 0x04000277 RID: 631
		<AccessedThroughProperty("Pittxt")>
		Private _Pittxt As TextBox

		' Token: 0x04000278 RID: 632
		<AccessedThroughProperty("GroupBox2")>
		Private _GroupBox2 As GroupBox

		' Token: 0x04000279 RID: 633
		<AccessedThroughProperty("Cnfrmbtn")>
		Private _Cnfrmbtn As Button

		' Token: 0x0400027A RID: 634
		<AccessedThroughProperty("Cnlbtn")>
		Private _Cnlbtn As Button

		' Token: 0x0400027B RID: 635
		<AccessedThroughProperty("GroupBox3")>
		Private _GroupBox3 As GroupBox

		' Token: 0x0400027C RID: 636
		<AccessedThroughProperty("Postatxt")>
		Private _Postatxt As TextBox

		' Token: 0x0400027D RID: 637
		<AccessedThroughProperty("Meandramp")>
		Private _Meandramp As TextBox

		' Token: 0x0400027E RID: 638
		<AccessedThroughProperty("Conatxt")>
		Private _Conatxt As TextBox

		' Token: 0x0400027F RID: 639
		<AccessedThroughProperty("Inioverwtxt")>
		Private _Inioverwtxt As TextBox

		' Token: 0x04000280 RID: 640
		<AccessedThroughProperty("MeandrFlg")>
		Private _MeandrFlg As CheckBox

		' Token: 0x04000281 RID: 641
		<AccessedThroughProperty("Meandrptc")>
		Private _Meandrptc As TextBox

		' Token: 0x04000282 RID: 642
		<AccessedThroughProperty("Initang")>
		Private _Initang As TextBox

		' Token: 0x04000283 RID: 643
		<AccessedThroughProperty("GroupBox1")>
		Private _GroupBox1 As GroupBox

		' Token: 0x04000284 RID: 644
		<AccessedThroughProperty("A2")>
		Private _A2 As RadioButton

		' Token: 0x04000285 RID: 645
		<AccessedThroughProperty("A1")>
		Private _A1 As RadioButton

		' Token: 0x04000286 RID: 646
		<AccessedThroughProperty("Tooloffsettxt")>
		Private _Tooloffsettxt As TextBox

		' Token: 0x04000287 RID: 647
		<AccessedThroughProperty("GroupBox4")>
		Private _GroupBox4 As GroupBox

		' Token: 0x04000288 RID: 648
		<AccessedThroughProperty("Rightdirflg")>
		Private _Rightdirflg As RadioButton

		' Token: 0x04000289 RID: 649
		<AccessedThroughProperty("Leftdirflg")>
		Private _Leftdirflg As RadioButton

		' Token: 0x0400028A RID: 650
		<AccessedThroughProperty("Finoverwtxt")>
		Private _Finoverwtxt As TextBox

		' Token: 0x0400028B RID: 651
		<AccessedThroughProperty("A3")>
		Private _A3 As RadioButton

		' Token: 0x0400028C RID: 652
		<AccessedThroughProperty("GroupBox5")>
		Private _GroupBox5 As GroupBox

		' Token: 0x0400028D RID: 653
		<AccessedThroughProperty("WD_13")>
		Private _WD_13 As RadioButton

		' Token: 0x0400028E RID: 654
		<AccessedThroughProperty("WD_20")>
		Private _WD_20 As RadioButton

		' Token: 0x0400028F RID: 655
		<AccessedThroughProperty("CurrPosStat")>
		Private _CurrPosStat As CheckBox
	End Class
End Namespace
