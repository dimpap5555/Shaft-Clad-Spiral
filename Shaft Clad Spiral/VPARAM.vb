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
	' Token: 0x02000024 RID: 36
	<DesignerGenerated()>
	Public Partial Class VPARAM
		Inherits Form

		' Token: 0x06000642 RID: 1602 RVA: 0x000506B4 File Offset: 0x0004EAB4
		<DebuggerNonUserCode()>
		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.VPARAM_Load
			Me.InitializeComponent()
		End Sub

		' Token: 0x170001FD RID: 509
		' (get) Token: 0x06000645 RID: 1605 RVA: 0x00052534 File Offset: 0x00050934
		' (set) Token: 0x06000646 RID: 1606 RVA: 0x00052548 File Offset: 0x00050948
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

		' Token: 0x170001FE RID: 510
		' (get) Token: 0x06000647 RID: 1607 RVA: 0x00052594 File Offset: 0x00050994
		' (set) Token: 0x06000648 RID: 1608 RVA: 0x000525A8 File Offset: 0x000509A8
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

		' Token: 0x170001FF RID: 511
		' (get) Token: 0x06000649 RID: 1609 RVA: 0x000525F4 File Offset: 0x000509F4
		' (set) Token: 0x0600064A RID: 1610 RVA: 0x00052608 File Offset: 0x00050A08
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

		' Token: 0x17000200 RID: 512
		' (get) Token: 0x0600064B RID: 1611 RVA: 0x00052654 File Offset: 0x00050A54
		' (set) Token: 0x0600064C RID: 1612 RVA: 0x00052668 File Offset: 0x00050A68
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

		' Token: 0x17000201 RID: 513
		' (get) Token: 0x0600064D RID: 1613 RVA: 0x000526B4 File Offset: 0x00050AB4
		' (set) Token: 0x0600064E RID: 1614 RVA: 0x000526C8 File Offset: 0x00050AC8
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

		' Token: 0x17000202 RID: 514
		' (get) Token: 0x0600064F RID: 1615 RVA: 0x000526D4 File Offset: 0x00050AD4
		' (set) Token: 0x06000650 RID: 1616 RVA: 0x000526E8 File Offset: 0x00050AE8
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

		' Token: 0x17000203 RID: 515
		' (get) Token: 0x06000651 RID: 1617 RVA: 0x00052734 File Offset: 0x00050B34
		' (set) Token: 0x06000652 RID: 1618 RVA: 0x00052748 File Offset: 0x00050B48
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

		' Token: 0x17000204 RID: 516
		' (get) Token: 0x06000653 RID: 1619 RVA: 0x00052794 File Offset: 0x00050B94
		' (set) Token: 0x06000654 RID: 1620 RVA: 0x000527A8 File Offset: 0x00050BA8
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

		' Token: 0x17000205 RID: 517
		' (get) Token: 0x06000655 RID: 1621 RVA: 0x000527B4 File Offset: 0x00050BB4
		' (set) Token: 0x06000656 RID: 1622 RVA: 0x000527C8 File Offset: 0x00050BC8
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

		' Token: 0x17000206 RID: 518
		' (get) Token: 0x06000657 RID: 1623 RVA: 0x00052814 File Offset: 0x00050C14
		' (set) Token: 0x06000658 RID: 1624 RVA: 0x00052828 File Offset: 0x00050C28
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

		' Token: 0x17000207 RID: 519
		' (get) Token: 0x06000659 RID: 1625 RVA: 0x00052874 File Offset: 0x00050C74
		' (set) Token: 0x0600065A RID: 1626 RVA: 0x00052888 File Offset: 0x00050C88
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

		' Token: 0x17000208 RID: 520
		' (get) Token: 0x0600065B RID: 1627 RVA: 0x000528D4 File Offset: 0x00050CD4
		' (set) Token: 0x0600065C RID: 1628 RVA: 0x000528E8 File Offset: 0x00050CE8
		Friend Overridable Property Meandrflg As CheckBox
			<DebuggerNonUserCode()>
			Get
				Return Me._Meandrflg
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As CheckBox)
				Dim value2 As EventHandler = AddressOf Me.Meandrflg_click
				If Me._Meandrflg IsNot Nothing Then
					RemoveHandler Me._Meandrflg.Click, value2
				End If
				Me._Meandrflg = value
				If Me._Meandrflg IsNot Nothing Then
					AddHandler Me._Meandrflg.Click, value2
				End If
			End Set
		End Property

		' Token: 0x17000209 RID: 521
		' (get) Token: 0x0600065D RID: 1629 RVA: 0x00052934 File Offset: 0x00050D34
		' (set) Token: 0x0600065E RID: 1630 RVA: 0x00052948 File Offset: 0x00050D48
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

		' Token: 0x1700020A RID: 522
		' (get) Token: 0x0600065F RID: 1631 RVA: 0x00052994 File Offset: 0x00050D94
		' (set) Token: 0x06000660 RID: 1632 RVA: 0x000529A8 File Offset: 0x00050DA8
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

		' Token: 0x1700020B RID: 523
		' (get) Token: 0x06000661 RID: 1633 RVA: 0x000529F4 File Offset: 0x00050DF4
		' (set) Token: 0x06000662 RID: 1634 RVA: 0x00052A08 File Offset: 0x00050E08
		Friend Overridable Property Vlvspind As RadioButton
			<DebuggerNonUserCode()>
			Get
				Return Me._Vlvspind
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As RadioButton)
				Dim value2 As EventHandler = AddressOf Me.Vlvspind_CheckedChanged
				If Me._Vlvspind IsNot Nothing Then
					RemoveHandler Me._Vlvspind.Click, value2
				End If
				Me._Vlvspind = value
				If Me._Vlvspind IsNot Nothing Then
					AddHandler Me._Vlvspind.Click, value2
				End If
			End Set
		End Property

		' Token: 0x1700020C RID: 524
		' (get) Token: 0x06000663 RID: 1635 RVA: 0x00052A54 File Offset: 0x00050E54
		' (set) Token: 0x06000664 RID: 1636 RVA: 0x00052A68 File Offset: 0x00050E68
		Friend Overridable Property Vlvseat As RadioButton
			<DebuggerNonUserCode()>
			Get
				Return Me._Vlvseat
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As RadioButton)
				Dim value2 As EventHandler = AddressOf Me.Vlvseat_CheckedChanged
				If Me._Vlvseat IsNot Nothing Then
					RemoveHandler Me._Vlvseat.Click, value2
				End If
				Me._Vlvseat = value
				If Me._Vlvseat IsNot Nothing Then
					AddHandler Me._Vlvseat.Click, value2
				End If
			End Set
		End Property

		' Token: 0x1700020D RID: 525
		' (get) Token: 0x06000665 RID: 1637 RVA: 0x00052AB4 File Offset: 0x00050EB4
		' (set) Token: 0x06000666 RID: 1638 RVA: 0x00052AC8 File Offset: 0x00050EC8
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

		' Token: 0x1700020E RID: 526
		' (get) Token: 0x06000667 RID: 1639 RVA: 0x00052AD4 File Offset: 0x00050ED4
		' (set) Token: 0x06000668 RID: 1640 RVA: 0x00052AE8 File Offset: 0x00050EE8
		Friend Overridable Property Stationslct As ListBox
			<DebuggerNonUserCode()>
			Get
				Return Me._Stationslct
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ListBox)
				Dim value2 As EventHandler = AddressOf Me.Stationslct_SelectedIndexChanged
				If Me._Stationslct IsNot Nothing Then
					RemoveHandler Me._Stationslct.SelectedIndexChanged, value2
				End If
				Me._Stationslct = value
				If Me._Stationslct IsNot Nothing Then
					AddHandler Me._Stationslct.SelectedIndexChanged, value2
				End If
			End Set
		End Property

		' Token: 0x1700020F RID: 527
		' (get) Token: 0x06000669 RID: 1641 RVA: 0x00052B34 File Offset: 0x00050F34
		' (set) Token: 0x0600066A RID: 1642 RVA: 0x00052B48 File Offset: 0x00050F48
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

		' Token: 0x17000210 RID: 528
		' (get) Token: 0x0600066B RID: 1643 RVA: 0x00052B94 File Offset: 0x00050F94
		' (set) Token: 0x0600066C RID: 1644 RVA: 0x00052BA8 File Offset: 0x00050FA8
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

		' Token: 0x17000211 RID: 529
		' (get) Token: 0x0600066D RID: 1645 RVA: 0x00052BF4 File Offset: 0x00050FF4
		' (set) Token: 0x0600066E RID: 1646 RVA: 0x00052C08 File Offset: 0x00051008
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

		' Token: 0x17000212 RID: 530
		' (get) Token: 0x0600066F RID: 1647 RVA: 0x00052C14 File Offset: 0x00051014
		' (set) Token: 0x06000670 RID: 1648 RVA: 0x00052C28 File Offset: 0x00051028
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

		' Token: 0x17000213 RID: 531
		' (get) Token: 0x06000671 RID: 1649 RVA: 0x00052C74 File Offset: 0x00051074
		' (set) Token: 0x06000672 RID: 1650 RVA: 0x00052C88 File Offset: 0x00051088
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

		' Token: 0x17000214 RID: 532
		' (get) Token: 0x06000673 RID: 1651 RVA: 0x00052CD4 File Offset: 0x000510D4
		' (set) Token: 0x06000674 RID: 1652 RVA: 0x00052CE8 File Offset: 0x000510E8
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

		' Token: 0x17000215 RID: 533
		' (get) Token: 0x06000675 RID: 1653 RVA: 0x00052D34 File Offset: 0x00051134
		' (set) Token: 0x06000676 RID: 1654 RVA: 0x00052D48 File Offset: 0x00051148
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

		' Token: 0x17000216 RID: 534
		' (get) Token: 0x06000677 RID: 1655 RVA: 0x00052D54 File Offset: 0x00051154
		' (set) Token: 0x06000678 RID: 1656 RVA: 0x00052D68 File Offset: 0x00051168
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

		' Token: 0x17000217 RID: 535
		' (get) Token: 0x06000679 RID: 1657 RVA: 0x00052DB4 File Offset: 0x000511B4
		' (set) Token: 0x0600067A RID: 1658 RVA: 0x00052DC8 File Offset: 0x000511C8
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

		' Token: 0x17000218 RID: 536
		' (get) Token: 0x0600067B RID: 1659 RVA: 0x00052E14 File Offset: 0x00051214
		' (set) Token: 0x0600067C RID: 1660 RVA: 0x00052E28 File Offset: 0x00051228
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

		' Token: 0x0600067D RID: 1661 RVA: 0x00052E74 File Offset: 0x00051274
		Private Sub Cnlbtn_Click(sender As Object, e As EventArgs)
			Me.DialogResult = DialogResult.Cancel
			Me.Close()
		End Sub

		' Token: 0x0600067E RID: 1662 RVA: 0x00052E84 File Offset: 0x00051284
		Private Sub Cnfrmbtn_Click(sender As Object, e As EventArgs)
			Dim fs As FileStream = New FileStream(Application.StartupPath + "\Vcladparam.txt", FileMode.Create)
			Dim w As StreamWriter = New StreamWriter(fs)
			If Positioncal.ValveFlg Then
				' The following expression was wrapped in a checked-expression
				Positioncal.Diameter = Conversions.ToDouble(Me.Diatxt.Text) - CDbl((CInt((2S * Positioncal.CurrPos)) * Positioncal.CladdingDir)) * Positioncal.CladWidth / 2.0 * Math.Sin(Positioncal.ConeAngle * 3.141592653589793 / 180.0)
				Positioncal.Distance = Conversions.ToDouble(Me.Distxt.Text) - CDbl((CInt(Positioncal.CurrPos) * Positioncal.CladdingDir)) * Positioncal.CladWidth / 2.0 * Math.Cos(Positioncal.ConeAngle * 3.141592653589793 / 180.0)
			Else
				' The following expression was wrapped in a checked-expression
				Positioncal.Diameter = Conversions.ToDouble(Me.Diatxt.Text) + CDbl((CInt((2S * Positioncal.CurrPos)) * Positioncal.CladdingDir)) * Positioncal.CladWidth / 2.0 * Math.Sin(Positioncal.ConeAngle * 3.141592653589793 / 180.0)
				Positioncal.Distance = Conversions.ToDouble(Me.Distxt.Text) - CDbl((CInt(Positioncal.CurrPos) * Positioncal.CladdingDir)) * Positioncal.CladWidth / 2.0 * Math.Cos(Positioncal.ConeAngle * 3.141592653589793 / 180.0)
			End If
			Positioncal.PostureAngle = Conversions.ToDouble(Me.Postatxt.Text)
			Positioncal.InitialAng = Conversions.ToDouble(Me.Initang.Text) - CDbl((Positioncal.DirectionFlg * 360)) / CDbl(Positioncal.PPR) - Math.Floor((Conversions.ToDouble(Me.Initang.Text) - CDbl((Positioncal.DirectionFlg * 360)) / CDbl(Positioncal.PPR)) / 360.0) * 360.0
			Dim num As Integer = Conversions.ToInteger(Me.Widthtxt.Text)
			If num < CInt(Math.Round(Positioncal.CladWidth)) Then
				Dim msgbxres As Short = CShort(Interaction.MsgBox("The minimum clad width is " + Positioncal.CladWidth.ToString("#.0") + ". Adjust width accordingly?" & vbCrLf & "(If yes, meander movement will also be disabled)", MsgBoxStyle.YesNo, "Question"))
				If msgbxres = 6S Then
					Positioncal.Width1 = 2.5
					Me.Widthtxt.Text = Positioncal.Width1.ToString("#.00")
					Positioncal.MeanderFlg = 0S
					Me.Meandrflg.CheckState = CheckState.Unchecked
				End If
			ElseIf num < CInt(Math.Round(2.0 * Positioncal.MeanderAmp + Positioncal.CladWidth)) Then
				If Me.Meandrflg.CheckState = CheckState.Checked Then
					Dim msgbxres As Short = CShort(Interaction.MsgBox("The desired width is smaller than the meander width." & vbCrLf & "Adjust meander amplitude accordingly (Yes)?" & vbCrLf & "Disable meander movement (No)?", MsgBoxStyle.YesNo, "Question"))
					If msgbxres = 6S Then
						' The following expression was wrapped in a unchecked-expression
						Positioncal.MeanderAmp = Positioncal.Width1 - Positioncal.CladWidth / 2.0
						Me.Meandramp.Text = Positioncal.MeanderAmp.ToString("#.00")
						Interaction.MsgBox("The meander amplitude has been recalculated to " + Conversions.ToString(Positioncal.MeanderAmp) + "mm", MsgBoxStyle.Information, "Information")
					ElseIf msgbxres = 7S Then
						Positioncal.MeanderFlg = 0S
						Me.Meandrflg.CheckState = CheckState.Unchecked
					End If
				End If
			ElseIf num < CInt(Math.Round(1.5 * Positioncal.Pitch + 2.0 * Positioncal.MeanderAmp + Positioncal.CladWidth)) AndAlso Me.Meandrflg.CheckState = CheckState.Checked Then
				Dim msgbxres As Short = CShort(Interaction.MsgBox("The desired width is only slightly larger to the clad width." & vbCrLf & "Adjust meander amplitude to achieve the desired width in one revolution?", MsgBoxStyle.YesNo, "Question"))
				If msgbxres = 6S Then
					' The following expression was wrapped in a unchecked-expression
					Positioncal.MeanderAmp = Positioncal.Width1 - Positioncal.CladWidth / 2.0
					Me.Meandramp.Text = Positioncal.MeanderAmp.ToString("#.0")
					Interaction.MsgBox("The meander amplitude has been recalculated to " + Positioncal.MeanderAmp.ToString("#0.0 mm"), MsgBoxStyle.Information, "Information")
				End If
			End If
			If Me.Stationslct.SelectedIndex <> -1 AndAlso Positioncal.Width1 >= Positioncal.CladWidth Then
				Select Case Me.Stationslct.SelectedIndex
					Case 0
						Positioncal.StationPosition = 2
					Case 1
						Positioncal.StationPosition = 3
					Case 2
						Positioncal.StationPosition = 4
					Case 3
						Positioncal.StationPosition = 5
				End Select
				Me.Widthtxt.Text = Positioncal.Width1.ToString("#.00")
				Me.DialogResult = DialogResult.OK
				Me.Close()
				w.WriteLine(Me.Diatxt.Text)
				w.WriteLine(Me.Widthtxt.Text)
				w.WriteLine(Me.Distxt.Text)
				w.WriteLine(Me.Pittxt.Text)
				w.WriteLine(Me.Postatxt.Text)
				w.WriteLine(Positioncal.StationPosition.ToString())
				w.WriteLine(Me.Conatxt.Text)
				w.WriteLine(Me.Inioverwtxt.Text)
				w.WriteLine(Me.Finoverwtxt.Text)
				w.WriteLine(Me.Meandramp.Text)
				w.WriteLine(Me.Meandrptc.Text)
				w.WriteLine(Positioncal.MeanderFlg.ToString())
				w.WriteLine(Me.Initang.Text)
				w.WriteLine(Me.Tooloffsettxt.Text)
				w.WriteLine(Positioncal.ValveFlg.ToString())
				w.WriteLine(Positioncal.CladdingDir.ToString())
				w.WriteLine(Positioncal.CurrPos.ToString())
				w.Close()
				Me.DialogResult = DialogResult.OK
				Me.Close()
			ElseIf Positioncal.Width1 < Positioncal.CladWidth Then
				Interaction.MsgBox("The width should be at least " + Positioncal.CladWidth.ToString("#.0") + ". Please adjust accordingly", MsgBoxStyle.Exclamation, "Information")
				w.Close()
			ElseIf Me.Stationslct.SelectedIndex = -1 Then
				Interaction.MsgBox("Please select the desired cone angle", MsgBoxStyle.Exclamation, "Cone Angle Selection")
				w.Close()
			End If
		End Sub

		' Token: 0x0600067F RID: 1663 RVA: 0x0005349C File Offset: 0x0005189C
		Private Sub Tooloffsettxt_TextChanged(sender As Object, e As EventArgs)
			If Versioned.IsNumeric(Me.Tooloffsettxt.Text) Then
				Dim value As Double = Conversions.ToDouble(Me.Tooloffsettxt.Text)
				Me.Tooloffsettxt.Text = value.ToString("#0.00")
				Positioncal.ToolOffset = value
			Else
				Interaction.MsgBox("This is not a valid value", MsgBoxStyle.Exclamation, Nothing)
				Me.Tooloffsettxt.Text = Conversions.ToString(0)
				Positioncal.ToolOffset = 0.0
			End If
		End Sub

		' Token: 0x06000680 RID: 1664 RVA: 0x00053518 File Offset: 0x00051918
		Private Sub Diatxt_Leave(sender As Object, e As EventArgs)
			If Char.IsNumber(Conversions.ToChar(Me.Diatxt.Text)) Then
				Dim value As Double = Conversions.ToDouble(Me.Diatxt.Text)
				Me.Diatxt.Text = value.ToString("#0.0")
				Positioncal.Diameter = value
			Else
				Interaction.MsgBox("This is not a valid value (0<D<500mm)", MsgBoxStyle.Exclamation, Nothing)
				Me.Diatxt.Text = 50.ToString("#0.0")
				Positioncal.Diameter = 50.0
			End If
		End Sub

		' Token: 0x06000681 RID: 1665 RVA: 0x000535A4 File Offset: 0x000519A4
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

		' Token: 0x06000682 RID: 1666 RVA: 0x00053630 File Offset: 0x00051A30
		Private Sub Distxt_Leave(sender As Object, e As EventArgs)
			If Versioned.IsNumeric(Me.Distxt.Text) Then
				If Conversions.ToDouble(Me.Distxt.Text) >= Positioncal.MinDistance Then
					Dim value As Double = Conversions.ToDouble(Me.Distxt.Text)
					Me.Distxt.Text = value.ToString("#0.00")
					Positioncal.Distance = value
				Else
					Interaction.MsgBox("The minimum distance from the Chuck has been specified to " + Positioncal.MinDistance.ToString("#0.0"), MsgBoxStyle.Exclamation, Nothing)
					Me.Distxt.Text = 500.ToString("#0.00")
					Positioncal.Distance = 500.0
				End If
			Else
				Interaction.MsgBox("This is not a valid value", MsgBoxStyle.Exclamation, Nothing)
				Me.Distxt.Text = 500.ToString("#0.00")
				Positioncal.Distance = 500.0
			End If
		End Sub

		' Token: 0x06000683 RID: 1667 RVA: 0x00053724 File Offset: 0x00051B24
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

		' Token: 0x06000684 RID: 1668 RVA: 0x000537B0 File Offset: 0x00051BB0
		Private Sub Postatxt_Leave(sender As Object, e As EventArgs)
			If Versioned.IsNumeric(Me.Postatxt.Text) Then
				If Conversions.ToDouble(Me.Postatxt.Text) > 0.0 And Conversions.ToDouble(Me.Postatxt.Text) < 180.0 Then
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

		' Token: 0x06000685 RID: 1669 RVA: 0x000538AC File Offset: 0x00051CAC
		Private Sub Inioverwtxt_Leave(sender As Object, e As EventArgs)
			If Char.IsNumber(Conversions.ToChar(Me.Inioverwtxt.Text)) Then
				If If((-If((Operators.CompareString(Me.Inioverwtxt.Text, Conversions.ToString(0) + Me.Inioverwtxt.Text, False) >= 0 > False), 1, 0)), 1, 0) < 500 Then
					Dim value As Double = Conversions.ToDouble(Me.Inioverwtxt.Text)
					Me.Inioverwtxt.Text = value.ToString("#0.0")
					Positioncal.IniOverWeld = CSng(value)
				Else
					Interaction.MsgBox("The Initial overweldshould be within 0 and 500%", MsgBoxStyle.Exclamation, Nothing)
					Me.Inioverwtxt.Text = 0.ToString("#0.0")
					Positioncal.IniOverWeld = 0F
				End If
			Else
				Interaction.MsgBox("This is not a valid value (0% <= Overweld < 500%)", MsgBoxStyle.Exclamation, Nothing)
				Me.Inioverwtxt.Text = 0.ToString("#0.0")
				Positioncal.IniOverWeld = 0F
			End If
		End Sub

		' Token: 0x06000686 RID: 1670 RVA: 0x000539A0 File Offset: 0x00051DA0
		Private Sub Finoverwtxt_Leave(sender As Object, e As EventArgs)
			If Char.IsNumber(Conversions.ToChar(Me.Finoverwtxt.Text)) Then
				If If((-If((Operators.CompareString(Me.Finoverwtxt.Text, Conversions.ToString(0) + Me.Finoverwtxt.Text, False) >= 0 > False), 1, 0)), 1, 0) < 500 Then
					Dim value As Double = Conversions.ToDouble(Me.Finoverwtxt.Text)
					Me.Finoverwtxt.Text = value.ToString("#0.0")
					Positioncal.FinOverWeld = CSng(value)
				Else
					Interaction.MsgBox("The Initial overweldshould be within 0 and 500%", MsgBoxStyle.Exclamation, Nothing)
					Me.Finoverwtxt.Text = 0.ToString("#0.0")
					Positioncal.FinOverWeld = 0F
				End If
			Else
				Interaction.MsgBox("This is not a valid value (0% <= Overweld < 500%)", MsgBoxStyle.Exclamation, Nothing)
				Me.Finoverwtxt.Text = 0.ToString("#0.0")
				Positioncal.FinOverWeld = 0F
			End If
		End Sub

		' Token: 0x06000687 RID: 1671 RVA: 0x00053A94 File Offset: 0x00051E94
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

		' Token: 0x06000688 RID: 1672 RVA: 0x00053B20 File Offset: 0x00051F20
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

		' Token: 0x06000689 RID: 1673 RVA: 0x00053BAC File Offset: 0x00051FAC
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

		' Token: 0x0600068A RID: 1674 RVA: 0x00053CC4 File Offset: 0x000520C4
		Private Sub Conatxt_Leave(sender As Object, e As EventArgs)
			If Versioned.IsNumeric(Me.Conatxt.Text) Then
				Dim value As Double = Conversions.ToDouble(Me.Conatxt.Text)
				Me.Conatxt.Text = value.ToString("#0.00")
				Positioncal.ConeAngle = value
			Else
				Interaction.MsgBox("This is not a valid value", MsgBoxStyle.Exclamation, Nothing)
				Me.Conatxt.Text = 60.ToString("#0.00")
				Positioncal.ConeAngle = 60.0
			End If
		End Sub

		' Token: 0x0600068B RID: 1675 RVA: 0x00053D4C File Offset: 0x0005214C
		Private Sub VPARAM_Load(sender As Object, e As EventArgs)
			Me.Diatxt.Text = Positioncal.Diameter.ToString("#0.0")
			Me.Widthtxt.Text = Positioncal.Width1.ToString("#0.0")
			Me.Distxt.Text = Positioncal.Distance.ToString("#0.00")
			Me.Pittxt.Text = Positioncal.Pitch.ToString("#0.00")
			Me.Postatxt.Text = Positioncal.PostureAngle.ToString("#0.00")
			Select Case Positioncal.StationPosition
				Case 2
					Me.Stationslct.SelectedIndex = 0
				Case 3
					Me.Stationslct.SelectedIndex = 1
				Case 4
					Me.Stationslct.SelectedIndex = 2
				Case 5
					Me.Stationslct.SelectedIndex = 3
			End Select
			Me.Conatxt.Text = Positioncal.ConeAngle.ToString("#0.00")
			Me.Inioverwtxt.Text = Positioncal.IniOverWeld.ToString("#0.0")
			Me.Finoverwtxt.Text = Positioncal.FinOverWeld.ToString("#0.0")
			Me.Meandramp.Text = Positioncal.MeanderAmp.ToString("#0.0")
			Me.Meandrptc.Text = Positioncal.MeanderPitch.ToString("#0.0")
			Me.Meandrflg.CheckState = CType(Positioncal.MeanderFlg, CheckState)
			Me.Initang.Text = Positioncal.InitialAng.ToString("#0.00")
			Me.Tooloffsettxt.Text = Positioncal.ToolOffset.ToString("#0.0")
			Select Case Positioncal.ValveFlg
				Case False
					Me.Vlvseat.Checked = False
					Me.Vlvspind.Checked = True
				Case True
					Me.Vlvseat.Checked = True
					Me.Vlvspind.Checked = False
			End Select
			Select Case Positioncal.CladdingDir
				Case -1
					Me.Rightdirflg.Checked = False
					Me.Leftdirflg.Checked = True
				Case 1
					Me.Rightdirflg.Checked = True
					Me.Leftdirflg.Checked = False
			End Select
			Me.CurrPosStat.Checked = (Positioncal.CurrPos <> 0S)
		End Sub

		' Token: 0x0600068C RID: 1676 RVA: 0x00053F9C File Offset: 0x0005239C
		Private Sub Vlvseat_CheckedChanged(sender As Object, e As EventArgs)
			If Me.Vlvseat.Checked Then
				Positioncal.ValveFlg = True
			End If
		End Sub

		' Token: 0x0600068D RID: 1677 RVA: 0x00053FB4 File Offset: 0x000523B4
		Private Sub Vlvspind_CheckedChanged(sender As Object, e As EventArgs)
			If Me.Vlvspind.Checked Then
				Positioncal.ValveFlg = False
			End If
		End Sub

		' Token: 0x0600068E RID: 1678 RVA: 0x00053FCC File Offset: 0x000523CC
		Private Sub Leftdirflg_CheckedChanged(sender As Object, e As EventArgs)
			If Me.Leftdirflg.Checked Then
				Positioncal.CladdingDir = -1
			End If
		End Sub

		' Token: 0x0600068F RID: 1679 RVA: 0x00053FE4 File Offset: 0x000523E4
		Private Sub Rightdirflg_CheckedChanged(sender As Object, e As EventArgs)
			If Me.Rightdirflg.Checked Then
				Positioncal.CladdingDir = 1
			End If
		End Sub

		' Token: 0x06000690 RID: 1680 RVA: 0x00053FFC File Offset: 0x000523FC
		Private Sub WD_20_CheckedChanged(sender As Object, e As EventArgs)
			If Me.WD_20.Checked Then
				Positioncal.Toolno = 0
			End If
		End Sub

		' Token: 0x06000691 RID: 1681 RVA: 0x00054014 File Offset: 0x00052414
		Private Sub WD_13_CheckedChanged(sender As Object, e As EventArgs)
			If Me.WD_13.Checked Then
				Positioncal.Toolno = 1
			End If
		End Sub

		' Token: 0x06000692 RID: 1682 RVA: 0x0005402C File Offset: 0x0005242C
		Private Sub Meandrflg_click(sender As Object, e As EventArgs)
			If Me.Meandrflg.Checked Then
				Positioncal.MeanderFlg = 1S
			Else
				Positioncal.MeanderFlg = 0S
			End If
		End Sub

		' Token: 0x06000693 RID: 1683 RVA: 0x0005404C File Offset: 0x0005244C
		Private Sub CurrPosStat_Click(sender As Object, e As EventArgs)
			Dim form2rect As Rectangle = New Rectangle(50, 100, 694, 440)
			If Me.CurrPosStat.Checked Then
				MyProject.Forms.Posıtıonupload.DesktopBounds = form2rect
				MyProject.Forms.Posıtıonupload.ShowDialog()
				If MyProject.Forms.Posıtıonupload.DialogResult = DialogResult.OK Then
					Positioncal.WorkXAxisOffset = Positioncal.Position(0, 0)
					Positioncal.WorkYAxisTilt = Positioncal.Position(4, 0)
					Positioncal.WorkZAxisYaw = Positioncal.Position(5, 0)
					Me.Initang.Text = Positioncal.Position(7, 0).ToString("#0.0")
					Me.Diatxt.Text = (Math.Abs(Positioncal.Position(2, 0)) * 2.0).ToString("#0.0")
					Me.Distxt.Text = Positioncal.Position(1, 0).ToString("#0.00")
					Me.Tooloffsettxt.Text = "0.0"
					If Positioncal.Position(3, 0) > 0.0 Then
						Me.Postatxt.Text = (Positioncal.Position(3, 0) - 90.0).ToString("#0.00")
					Else
						Me.Postatxt.Text = (Positioncal.Position(3, 0) + 180.0 + 90.0).ToString("#0.00")
					End If
					Me.Diatxt_Leave(Me, e)
					Me.Distxt_Leave(Me, e)
					Me.Initang_Leave(Me, e)
					Me.Postatxt_Leave(Me, e)
					Positioncal.CurrPos = 1S
				Else
					Me.CurrPosStat.Checked = False
					Positioncal.CurrPos = 0S
				End If
			Else
				Me.Diatxt.Text = Positioncal.Diameter.ToString("#0.0")
				Me.Distxt.Text = Positioncal.Distance.ToString("#0.0")
				Positioncal.CurrPos = 0S
			End If
		End Sub

		' Token: 0x06000694 RID: 1684 RVA: 0x00054260 File Offset: 0x00052660
		Private Sub Stationslct_SelectedIndexChanged(sender As Object, e As EventArgs)
			Select Case Me.Stationslct.SelectedIndex
				Case 0
					Positioncal.StationPosition = 2
				Case 1
					Positioncal.StationPosition = 3
				Case 2
					Positioncal.StationPosition = 4
				Case 3
					Positioncal.StationPosition = 5
			End Select
		End Sub

		' Token: 0x04000297 RID: 663
		<AccessedThroughProperty("Diatxt")>
		Private _Diatxt As TextBox

		' Token: 0x04000298 RID: 664
		<AccessedThroughProperty("Widthtxt")>
		Private _Widthtxt As TextBox

		' Token: 0x04000299 RID: 665
		<AccessedThroughProperty("Distxt")>
		Private _Distxt As TextBox

		' Token: 0x0400029A RID: 666
		<AccessedThroughProperty("Pittxt")>
		Private _Pittxt As TextBox

		' Token: 0x0400029B RID: 667
		<AccessedThroughProperty("GroupBox2")>
		Private _GroupBox2 As GroupBox

		' Token: 0x0400029C RID: 668
		<AccessedThroughProperty("Cnfrmbtn")>
		Private _Cnfrmbtn As Button

		' Token: 0x0400029D RID: 669
		<AccessedThroughProperty("Cnlbtn")>
		Private _Cnlbtn As Button

		' Token: 0x0400029E RID: 670
		<AccessedThroughProperty("GroupBox3")>
		Private _GroupBox3 As GroupBox

		' Token: 0x0400029F RID: 671
		<AccessedThroughProperty("Postatxt")>
		Private _Postatxt As TextBox

		' Token: 0x040002A0 RID: 672
		<AccessedThroughProperty("Meandramp")>
		Private _Meandramp As TextBox

		' Token: 0x040002A1 RID: 673
		<AccessedThroughProperty("Inioverwtxt")>
		Private _Inioverwtxt As TextBox

		' Token: 0x040002A2 RID: 674
		<AccessedThroughProperty("Meandrflg")>
		Private _Meandrflg As CheckBox

		' Token: 0x040002A3 RID: 675
		<AccessedThroughProperty("Meandrptc")>
		Private _Meandrptc As TextBox

		' Token: 0x040002A4 RID: 676
		<AccessedThroughProperty("Initang")>
		Private _Initang As TextBox

		' Token: 0x040002A5 RID: 677
		<AccessedThroughProperty("Vlvspind")>
		Private _Vlvspind As RadioButton

		' Token: 0x040002A6 RID: 678
		<AccessedThroughProperty("Vlvseat")>
		Private _Vlvseat As RadioButton

		' Token: 0x040002A7 RID: 679
		<AccessedThroughProperty("GroupBox4")>
		Private _GroupBox4 As GroupBox

		' Token: 0x040002A8 RID: 680
		<AccessedThroughProperty("Stationslct")>
		Private _Stationslct As ListBox

		' Token: 0x040002A9 RID: 681
		<AccessedThroughProperty("Tooloffsettxt")>
		Private _Tooloffsettxt As TextBox

		' Token: 0x040002AA RID: 682
		<AccessedThroughProperty("Finoverwtxt")>
		Private _Finoverwtxt As TextBox

		' Token: 0x040002AB RID: 683
		<AccessedThroughProperty("GroupBox1")>
		Private _GroupBox1 As GroupBox

		' Token: 0x040002AC RID: 684
		<AccessedThroughProperty("Rightdirflg")>
		Private _Rightdirflg As RadioButton

		' Token: 0x040002AD RID: 685
		<AccessedThroughProperty("Leftdirflg")>
		Private _Leftdirflg As RadioButton

		' Token: 0x040002AE RID: 686
		<AccessedThroughProperty("Conatxt")>
		Private _Conatxt As TextBox

		' Token: 0x040002AF RID: 687
		<AccessedThroughProperty("GroupBox5")>
		Private _GroupBox5 As GroupBox

		' Token: 0x040002B0 RID: 688
		<AccessedThroughProperty("WD_13")>
		Private _WD_13 As RadioButton

		' Token: 0x040002B1 RID: 689
		<AccessedThroughProperty("WD_20")>
		Private _WD_20 As RadioButton

		' Token: 0x040002B2 RID: 690
		<AccessedThroughProperty("CurrPosStat")>
		Private _CurrPosStat As CheckBox
	End Class
End Namespace
