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
	' Token: 0x02000008 RID: 8
	<DesignerGenerated()>
	Public Partial Class THREEDCLADPARAM
		Inherits Form

		' Token: 0x0600003F RID: 63 RVA: 0x00017370 File Offset: 0x00015770
		<DebuggerNonUserCode()>
		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.threedcladparam_load
			Me.InitializeComponent()
		End Sub

		' Token: 0x17000019 RID: 25
		' (get) Token: 0x06000042 RID: 66 RVA: 0x000195D4 File Offset: 0x000179D4
		' (set) Token: 0x06000043 RID: 67 RVA: 0x000195E8 File Offset: 0x000179E8
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

		' Token: 0x1700001A RID: 26
		' (get) Token: 0x06000044 RID: 68 RVA: 0x00019634 File Offset: 0x00017A34
		' (set) Token: 0x06000045 RID: 69 RVA: 0x00019648 File Offset: 0x00017A48
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

		' Token: 0x1700001B RID: 27
		' (get) Token: 0x06000046 RID: 70 RVA: 0x00019694 File Offset: 0x00017A94
		' (set) Token: 0x06000047 RID: 71 RVA: 0x000196A8 File Offset: 0x00017AA8
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

		' Token: 0x1700001C RID: 28
		' (get) Token: 0x06000048 RID: 72 RVA: 0x000196B4 File Offset: 0x00017AB4
		' (set) Token: 0x06000049 RID: 73 RVA: 0x000196C8 File Offset: 0x00017AC8
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

		' Token: 0x1700001D RID: 29
		' (get) Token: 0x0600004A RID: 74 RVA: 0x00019714 File Offset: 0x00017B14
		' (set) Token: 0x0600004B RID: 75 RVA: 0x00019728 File Offset: 0x00017B28
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

		' Token: 0x1700001E RID: 30
		' (get) Token: 0x0600004C RID: 76 RVA: 0x00019774 File Offset: 0x00017B74
		' (set) Token: 0x0600004D RID: 77 RVA: 0x00019788 File Offset: 0x00017B88
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

		' Token: 0x1700001F RID: 31
		' (get) Token: 0x0600004E RID: 78 RVA: 0x00019794 File Offset: 0x00017B94
		' (set) Token: 0x0600004F RID: 79 RVA: 0x000197A8 File Offset: 0x00017BA8
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

		' Token: 0x17000020 RID: 32
		' (get) Token: 0x06000050 RID: 80 RVA: 0x000197F4 File Offset: 0x00017BF4
		' (set) Token: 0x06000051 RID: 81 RVA: 0x00019808 File Offset: 0x00017C08
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

		' Token: 0x17000021 RID: 33
		' (get) Token: 0x06000052 RID: 82 RVA: 0x00019854 File Offset: 0x00017C54
		' (set) Token: 0x06000053 RID: 83 RVA: 0x00019868 File Offset: 0x00017C68
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

		' Token: 0x17000022 RID: 34
		' (get) Token: 0x06000054 RID: 84 RVA: 0x000198B4 File Offset: 0x00017CB4
		' (set) Token: 0x06000055 RID: 85 RVA: 0x000198C8 File Offset: 0x00017CC8
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

		' Token: 0x17000023 RID: 35
		' (get) Token: 0x06000056 RID: 86 RVA: 0x000198D4 File Offset: 0x00017CD4
		' (set) Token: 0x06000057 RID: 87 RVA: 0x000198E8 File Offset: 0x00017CE8
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

		' Token: 0x17000024 RID: 36
		' (get) Token: 0x06000058 RID: 88 RVA: 0x00019934 File Offset: 0x00017D34
		' (set) Token: 0x06000059 RID: 89 RVA: 0x00019948 File Offset: 0x00017D48
		Friend Overridable Property CladDirSelection As GroupBox
			<DebuggerNonUserCode()>
			Get
				Return Me._CladDirSelection
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As GroupBox)
				Dim value2 As EventHandler = AddressOf Me.CladDirSelection_Enter
				If Me._CladDirSelection IsNot Nothing Then
					RemoveHandler Me._CladDirSelection.Enter, value2
				End If
				Me._CladDirSelection = value
				If Me._CladDirSelection IsNot Nothing Then
					AddHandler Me._CladDirSelection.Enter, value2
				End If
			End Set
		End Property

		' Token: 0x17000025 RID: 37
		' (get) Token: 0x0600005A RID: 90 RVA: 0x00019994 File Offset: 0x00017D94
		' (set) Token: 0x0600005B RID: 91 RVA: 0x000199A8 File Offset: 0x00017DA8
		Friend Overridable Property Rightdirflg As RadioButton
			<DebuggerNonUserCode()>
			Get
				Return Me._Rightdirflg
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As RadioButton)
				Dim value2 As EventHandler = AddressOf Me.CladDirSelection_Enter
				If Me._Rightdirflg IsNot Nothing Then
					RemoveHandler Me._Rightdirflg.Click, value2
				End If
				Me._Rightdirflg = value
				If Me._Rightdirflg IsNot Nothing Then
					AddHandler Me._Rightdirflg.Click, value2
				End If
			End Set
		End Property

		' Token: 0x17000026 RID: 38
		' (get) Token: 0x0600005C RID: 92 RVA: 0x000199F4 File Offset: 0x00017DF4
		' (set) Token: 0x0600005D RID: 93 RVA: 0x00019A08 File Offset: 0x00017E08
		Friend Overridable Property Leftdirflg As RadioButton
			<DebuggerNonUserCode()>
			Get
				Return Me._Leftdirflg
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As RadioButton)
				Dim value2 As EventHandler = AddressOf Me.CladDirSelection_Enter
				If Me._Leftdirflg IsNot Nothing Then
					RemoveHandler Me._Leftdirflg.Click, value2
				End If
				Me._Leftdirflg = value
				If Me._Leftdirflg IsNot Nothing Then
					AddHandler Me._Leftdirflg.Click, value2
				End If
			End Set
		End Property

		' Token: 0x17000027 RID: 39
		' (get) Token: 0x0600005E RID: 94 RVA: 0x00019A54 File Offset: 0x00017E54
		' (set) Token: 0x0600005F RID: 95 RVA: 0x00019A68 File Offset: 0x00017E68
		Friend Overridable Property FocLengthSelection As GroupBox
			<DebuggerNonUserCode()>
			Get
				Return Me._FocLengthSelection
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As GroupBox)
				Me._FocLengthSelection = value
			End Set
		End Property

		' Token: 0x17000028 RID: 40
		' (get) Token: 0x06000060 RID: 96 RVA: 0x00019A74 File Offset: 0x00017E74
		' (set) Token: 0x06000061 RID: 97 RVA: 0x00019A88 File Offset: 0x00017E88
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

		' Token: 0x17000029 RID: 41
		' (get) Token: 0x06000062 RID: 98 RVA: 0x00019AD4 File Offset: 0x00017ED4
		' (set) Token: 0x06000063 RID: 99 RVA: 0x00019AE8 File Offset: 0x00017EE8
		Friend Overridable Property MovDirSelection As GroupBox
			<DebuggerNonUserCode()>
			Get
				Return Me._MovDirSelection
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As GroupBox)
				Me._MovDirSelection = value
			End Set
		End Property

		' Token: 0x1700002A RID: 42
		' (get) Token: 0x06000064 RID: 100 RVA: 0x00019AF4 File Offset: 0x00017EF4
		' (set) Token: 0x06000065 RID: 101 RVA: 0x00019B08 File Offset: 0x00017F08
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

		' Token: 0x1700002B RID: 43
		' (get) Token: 0x06000066 RID: 102 RVA: 0x00019B54 File Offset: 0x00017F54
		' (set) Token: 0x06000067 RID: 103 RVA: 0x00019B68 File Offset: 0x00017F68
		Friend Overridable Property SpinDirMov As RadioButton
			<DebuggerNonUserCode()>
			Get
				Return Me._SpinDirMov
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As RadioButton)
				Dim value2 As EventHandler = AddressOf Me.MovDirSelection_Enter
				If Me._SpinDirMov IsNot Nothing Then
					RemoveHandler Me._SpinDirMov.Click, value2
				End If
				Me._SpinDirMov = value
				If Me._SpinDirMov IsNot Nothing Then
					AddHandler Me._SpinDirMov.Click, value2
				End If
			End Set
		End Property

		' Token: 0x1700002C RID: 44
		' (get) Token: 0x06000068 RID: 104 RVA: 0x00019BB4 File Offset: 0x00017FB4
		' (set) Token: 0x06000069 RID: 105 RVA: 0x00019BC8 File Offset: 0x00017FC8
		Friend Overridable Property ZDirMov As RadioButton
			<DebuggerNonUserCode()>
			Get
				Return Me._ZDirMov
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As RadioButton)
				Dim value2 As EventHandler = AddressOf Me.MovDirSelection_Enter
				If Me._ZDirMov IsNot Nothing Then
					RemoveHandler Me._ZDirMov.Click, value2
				End If
				Me._ZDirMov = value
				If Me._ZDirMov IsNot Nothing Then
					AddHandler Me._ZDirMov.Click, value2
				End If
			End Set
		End Property

		' Token: 0x1700002D RID: 45
		' (get) Token: 0x0600006A RID: 106 RVA: 0x00019C14 File Offset: 0x00018014
		' (set) Token: 0x0600006B RID: 107 RVA: 0x00019C28 File Offset: 0x00018028
		Friend Overridable Property YDirMov As RadioButton
			<DebuggerNonUserCode()>
			Get
				Return Me._YDirMov
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As RadioButton)
				Dim value2 As EventHandler = AddressOf Me.MovDirSelection_Enter
				If Me._YDirMov IsNot Nothing Then
					RemoveHandler Me._YDirMov.Click, value2
				End If
				Me._YDirMov = value
				If Me._YDirMov IsNot Nothing Then
					AddHandler Me._YDirMov.Click, value2
				End If
			End Set
		End Property

		' Token: 0x1700002E RID: 46
		' (get) Token: 0x0600006C RID: 108 RVA: 0x00019C74 File Offset: 0x00018074
		' (set) Token: 0x0600006D RID: 109 RVA: 0x00019C88 File Offset: 0x00018088
		Friend Overridable Property XDirMov As RadioButton
			<DebuggerNonUserCode()>
			Get
				Return Me._XDirMov
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As RadioButton)
				Dim value2 As EventHandler = AddressOf Me.MovDirSelection_Enter
				If Me._XDirMov IsNot Nothing Then
					RemoveHandler Me._XDirMov.Click, value2
				End If
				Me._XDirMov = value
				If Me._XDirMov IsNot Nothing Then
					AddHandler Me._XDirMov.Click, value2
				End If
			End Set
		End Property

		' Token: 0x1700002F RID: 47
		' (get) Token: 0x0600006E RID: 110 RVA: 0x00019CD4 File Offset: 0x000180D4
		' (set) Token: 0x0600006F RID: 111 RVA: 0x00019CE8 File Offset: 0x000180E8
		Friend Overridable Property ArrayDirSelection As GroupBox
			<DebuggerNonUserCode()>
			Get
				Return Me._ArrayDirSelection
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As GroupBox)
				Me._ArrayDirSelection = value
			End Set
		End Property

		' Token: 0x17000030 RID: 48
		' (get) Token: 0x06000070 RID: 112 RVA: 0x00019CF4 File Offset: 0x000180F4
		' (set) Token: 0x06000071 RID: 113 RVA: 0x00019D08 File Offset: 0x00018108
		Friend Overridable Property Arrayangptctxt As TextBox
			<DebuggerNonUserCode()>
			Get
				Return Me._Arrayangptctxt
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As EventHandler = AddressOf Me.Arrayangptctxt_Leave
				If Me._Arrayangptctxt IsNot Nothing Then
					RemoveHandler Me._Arrayangptctxt.Leave, value2
				End If
				Me._Arrayangptctxt = value
				If Me._Arrayangptctxt IsNot Nothing Then
					AddHandler Me._Arrayangptctxt.Leave, value2
				End If
			End Set
		End Property

		' Token: 0x17000031 RID: 49
		' (get) Token: 0x06000072 RID: 114 RVA: 0x00019D54 File Offset: 0x00018154
		' (set) Token: 0x06000073 RID: 115 RVA: 0x00019D68 File Offset: 0x00018168
		Friend Overridable Property Arrayrecptctxt As TextBox
			<DebuggerNonUserCode()>
			Get
				Return Me._Arrayrecptctxt
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As EventHandler = AddressOf Me.Arrayrecptctxt_Leave
				If Me._Arrayrecptctxt IsNot Nothing Then
					RemoveHandler Me._Arrayrecptctxt.Leave, value2
				End If
				Me._Arrayrecptctxt = value
				If Me._Arrayrecptctxt IsNot Nothing Then
					AddHandler Me._Arrayrecptctxt.Leave, value2
				End If
			End Set
		End Property

		' Token: 0x17000032 RID: 50
		' (get) Token: 0x06000074 RID: 116 RVA: 0x00019DB4 File Offset: 0x000181B4
		' (set) Token: 0x06000075 RID: 117 RVA: 0x00019DC8 File Offset: 0x000181C8
		Friend Overridable Property Copiestxt As TextBox
			<DebuggerNonUserCode()>
			Get
				Return Me._Copiestxt
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As EventHandler = AddressOf Me.Copiestxt_TextChanged
				If Me._Copiestxt IsNot Nothing Then
					RemoveHandler Me._Copiestxt.Leave, value2
				End If
				Me._Copiestxt = value
				If Me._Copiestxt IsNot Nothing Then
					AddHandler Me._Copiestxt.Leave, value2
				End If
			End Set
		End Property

		' Token: 0x17000033 RID: 51
		' (get) Token: 0x06000076 RID: 118 RVA: 0x00019E14 File Offset: 0x00018214
		' (set) Token: 0x06000077 RID: 119 RVA: 0x00019E28 File Offset: 0x00018228
		Friend Overridable Property SpinDirArr As RadioButton
			<DebuggerNonUserCode()>
			Get
				Return Me._SpinDirArr
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As RadioButton)
				Dim value2 As EventHandler = AddressOf Me.ArrayDirSelection_Enter
				If Me._SpinDirArr IsNot Nothing Then
					RemoveHandler Me._SpinDirArr.Click, value2
				End If
				Me._SpinDirArr = value
				If Me._SpinDirArr IsNot Nothing Then
					AddHandler Me._SpinDirArr.Click, value2
				End If
			End Set
		End Property

		' Token: 0x17000034 RID: 52
		' (get) Token: 0x06000078 RID: 120 RVA: 0x00019E74 File Offset: 0x00018274
		' (set) Token: 0x06000079 RID: 121 RVA: 0x00019E88 File Offset: 0x00018288
		Friend Overridable Property ZDirArr As RadioButton
			<DebuggerNonUserCode()>
			Get
				Return Me._ZDirArr
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As RadioButton)
				Dim value2 As EventHandler = AddressOf Me.ArrayDirSelection_Enter
				If Me._ZDirArr IsNot Nothing Then
					RemoveHandler Me._ZDirArr.Click, value2
				End If
				Me._ZDirArr = value
				If Me._ZDirArr IsNot Nothing Then
					AddHandler Me._ZDirArr.Click, value2
				End If
			End Set
		End Property

		' Token: 0x17000035 RID: 53
		' (get) Token: 0x0600007A RID: 122 RVA: 0x00019ED4 File Offset: 0x000182D4
		' (set) Token: 0x0600007B RID: 123 RVA: 0x00019EE8 File Offset: 0x000182E8
		Friend Overridable Property YDirArr As RadioButton
			<DebuggerNonUserCode()>
			Get
				Return Me._YDirArr
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As RadioButton)
				Dim value2 As EventHandler = AddressOf Me.ArrayDirSelection_Enter
				If Me._YDirArr IsNot Nothing Then
					RemoveHandler Me._YDirArr.Click, value2
				End If
				Me._YDirArr = value
				If Me._YDirArr IsNot Nothing Then
					AddHandler Me._YDirArr.Click, value2
				End If
			End Set
		End Property

		' Token: 0x17000036 RID: 54
		' (get) Token: 0x0600007C RID: 124 RVA: 0x00019F34 File Offset: 0x00018334
		' (set) Token: 0x0600007D RID: 125 RVA: 0x00019F48 File Offset: 0x00018348
		Friend Overridable Property XDirArr As RadioButton
			<DebuggerNonUserCode()>
			Get
				Return Me._XDirArr
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As RadioButton)
				Dim value2 As EventHandler = AddressOf Me.ArrayDirSelection_Enter
				If Me._XDirArr IsNot Nothing Then
					RemoveHandler Me._XDirArr.Click, value2
				End If
				Me._XDirArr = value
				If Me._XDirArr IsNot Nothing Then
					AddHandler Me._XDirArr.Click, value2
				End If
			End Set
		End Property

		' Token: 0x17000037 RID: 55
		' (get) Token: 0x0600007E RID: 126 RVA: 0x00019F94 File Offset: 0x00018394
		' (set) Token: 0x0600007F RID: 127 RVA: 0x00019FA8 File Offset: 0x000183A8
		Friend Overridable Property Overlaymovdir As GroupBox
			<DebuggerNonUserCode()>
			Get
				Return Me._Overlaymovdir
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As GroupBox)
				Dim value2 As EventHandler = AddressOf Me.Overlaymovdir_Enter
				If Me._Overlaymovdir IsNot Nothing Then
					RemoveHandler Me._Overlaymovdir.Enter, value2
				End If
				Me._Overlaymovdir = value
				If Me._Overlaymovdir IsNot Nothing Then
					AddHandler Me._Overlaymovdir.Enter, value2
				End If
			End Set
		End Property

		' Token: 0x17000038 RID: 56
		' (get) Token: 0x06000080 RID: 128 RVA: 0x00019FF4 File Offset: 0x000183F4
		' (set) Token: 0x06000081 RID: 129 RVA: 0x0001A008 File Offset: 0x00018408
		Friend Overridable Property Posmov As RadioButton
			<DebuggerNonUserCode()>
			Get
				Return Me._Posmov
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As RadioButton)
				Dim value2 As EventHandler = AddressOf Me.Overlaymovdir_Enter
				If Me._Posmov IsNot Nothing Then
					RemoveHandler Me._Posmov.Click, value2
				End If
				Me._Posmov = value
				If Me._Posmov IsNot Nothing Then
					AddHandler Me._Posmov.Click, value2
				End If
			End Set
		End Property

		' Token: 0x17000039 RID: 57
		' (get) Token: 0x06000082 RID: 130 RVA: 0x0001A054 File Offset: 0x00018454
		' (set) Token: 0x06000083 RID: 131 RVA: 0x0001A068 File Offset: 0x00018468
		Friend Overridable Property Negmov As RadioButton
			<DebuggerNonUserCode()>
			Get
				Return Me._Negmov
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As RadioButton)
				Dim value2 As EventHandler = AddressOf Me.Overlaymovdir_Enter
				If Me._Negmov IsNot Nothing Then
					RemoveHandler Me._Negmov.Click, value2
				End If
				Me._Negmov = value
				If Me._Negmov IsNot Nothing Then
					AddHandler Me._Negmov.Click, value2
				End If
			End Set
		End Property

		' Token: 0x1700003A RID: 58
		' (get) Token: 0x06000084 RID: 132 RVA: 0x0001A0B4 File Offset: 0x000184B4
		' (set) Token: 0x06000085 RID: 133 RVA: 0x0001A0C8 File Offset: 0x000184C8
		Friend Overridable Property Arraymovdir As GroupBox
			<DebuggerNonUserCode()>
			Get
				Return Me._Arraymovdir
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As GroupBox)
				Dim value2 As EventHandler = AddressOf Me.Arraymovdir_Enter
				If Me._Arraymovdir IsNot Nothing Then
					RemoveHandler Me._Arraymovdir.Enter, value2
				End If
				Me._Arraymovdir = value
				If Me._Arraymovdir IsNot Nothing Then
					AddHandler Me._Arraymovdir.Enter, value2
				End If
			End Set
		End Property

		' Token: 0x1700003B RID: 59
		' (get) Token: 0x06000086 RID: 134 RVA: 0x0001A114 File Offset: 0x00018514
		' (set) Token: 0x06000087 RID: 135 RVA: 0x0001A128 File Offset: 0x00018528
		Friend Overridable Property Posarr As RadioButton
			<DebuggerNonUserCode()>
			Get
				Return Me._Posarr
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As RadioButton)
				Dim value2 As EventHandler = AddressOf Me.Arraymovdir_Enter
				If Me._Posarr IsNot Nothing Then
					RemoveHandler Me._Posarr.Click, value2
				End If
				Me._Posarr = value
				If Me._Posarr IsNot Nothing Then
					AddHandler Me._Posarr.Click, value2
				End If
			End Set
		End Property

		' Token: 0x1700003C RID: 60
		' (get) Token: 0x06000088 RID: 136 RVA: 0x0001A174 File Offset: 0x00018574
		' (set) Token: 0x06000089 RID: 137 RVA: 0x0001A188 File Offset: 0x00018588
		Friend Overridable Property Negarr As RadioButton
			<DebuggerNonUserCode()>
			Get
				Return Me._Negarr
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As RadioButton)
				Dim value2 As EventHandler = AddressOf Me.Arraymovdir_Enter
				If Me._Negarr IsNot Nothing Then
					RemoveHandler Me._Negarr.Click, value2
				End If
				Me._Negarr = value
				If Me._Negarr IsNot Nothing Then
					AddHandler Me._Negarr.Click, value2
				End If
			End Set
		End Property

		' Token: 0x1700003D RID: 61
		' (get) Token: 0x0600008A RID: 138 RVA: 0x0001A1D4 File Offset: 0x000185D4
		' (set) Token: 0x0600008B RID: 139 RVA: 0x0001A1E8 File Offset: 0x000185E8
		Friend Overridable Property Movement As ComboBox
			<DebuggerNonUserCode()>
			Get
				Return Me._Movement
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ComboBox)
				Dim value2 As EventHandler = AddressOf Me.Movement_SelectedIndexChanged
				If Me._Movement IsNot Nothing Then
					RemoveHandler Me._Movement.SelectedIndexChanged, value2
				End If
				Me._Movement = value
				If Me._Movement IsNot Nothing Then
					AddHandler Me._Movement.SelectedIndexChanged, value2
				End If
			End Set
		End Property

		' Token: 0x0600008C RID: 140 RVA: 0x0001A234 File Offset: 0x00018634
		Private Sub threedcladparam_load(sender As Object, e As EventArgs)
			Me.Widthtxt.Enabled = True
			Me.Pittxt.Enabled = True
			Me.Meandramp.Enabled = True
			Me.Stationslct.Enabled = True
			Me.Widthtxt.Text = Positioncal.Width1.ToString("#0.0")
			Me.Pittxt.Text = Positioncal.Pitch.ToString("#0.00")
			Me.Tooloffsettxt.Text = Positioncal.ToolOffset.ToString("#0.0")
			Me.Stationslct.SelectedIndex = Positioncal.StationPosition - 1
			If Positioncal.CladdingDir = 1 Then
				Me.Rightdirflg.Checked = True
			Else
				Me.Leftdirflg.Checked = True
			End If
			Select Case Positioncal.MovDir
				Case 0S
					Me.XDirMov.Checked = True
				Case 1S
					Me.YDirMov.Checked = True
				Case 2S
					Me.ZDirMov.Checked = True
				Case 3S
					Me.SpinDirMov.Checked = True
			End Select
			Select Case Positioncal.Overlaydir
				Case -1S
					Me.Negmov.Checked = True
				Case 1S
					Me.Posmov.Checked = True
			End Select
			Me.Meandramp.Text = Positioncal.MeanderAmp.ToString("#0.0")
			Me.Meandrptc.Text = Positioncal.MeanderPitch.ToString("#0.0")
			Me.MeandrFlg.CheckState = CType(Positioncal.MeanderFlg, CheckState)
			Select Case Positioncal.ArrDir
				Case 0S
					Me.XDirArr.Checked = True
				Case 1S
					Me.YDirArr.Checked = True
				Case 2S
					Me.ZDirArr.Checked = True
				Case 3S
					Me.SpinDirArr.Checked = True
			End Select
			Me.Copiestxt.Text = Positioncal.Copies.ToString("#0")
			Me.Arrayrecptctxt.Text = Positioncal.Arrayrecptc.ToString("#0.00")
			Me.Arrayangptctxt.Text = Positioncal.Arrayangptc.ToString("#0.00")
			Select Case Positioncal.Arraydir
				Case -1S
					Me.Negarr.Checked = True
				Case 1S
					Me.Posarr.Checked = True
			End Select
			Select Case Positioncal.CurrPos
				Case 0S
					Me.CurrPosStat.Checked = False
				Case 1S
					Me.CurrPosStat.Checked = True
			End Select
			Me.Movement.Items.Clear()
			Me.Movement.Items.Add("Synchro, circular interpolation")
			Me.Movement.Items.Add("Synchro, linear interpolation")
			Me.Movement.Items.Add("Asynchro, circular interpolation")
			Me.Movement.Items.Add("Asynchro, linear interpolation")
			Me.Movement.Items.Add("Robot only, circular interpolation")
			Me.Movement.Items.Add("Robot only, linear interpolation")
			Me.Movement.SelectedIndex = CInt(Positioncal.Movementtype)
			Me.Meandramp.Enabled = True
		End Sub

		' Token: 0x0600008D RID: 141 RVA: 0x0001A570 File Offset: 0x00018970
		Private Sub Cnlbtn_Click(sender As Object, e As EventArgs)
			Me.Close()
		End Sub

		' Token: 0x0600008E RID: 142 RVA: 0x0001A578 File Offset: 0x00018978
		Private Sub Cnfrmbtn_Click(sender As Object, e As EventArgs)
			Dim temppos As Double() = New Double(7) {}
			Dim MinCladwidth As Double = Positioncal.Position(9, 0)
			If(Positioncal.MovDir = 3S Or Positioncal.ArrDir = 3S) AndAlso Positioncal.Movementtype >= 4S Then
				Interaction.MsgBox("You have specified a movement in the spindle direction which cannot be accomplished with a robot only operation. Please adjust accordingly", MsgBoxStyle.Exclamation, Nothing)
			Else
				Dim num As Integer = 0
				Dim num2 As Integer = Positioncal.PointNo - 1
				For i As Integer = num To num2
					If Positioncal.Position(9, i) < MinCladwidth Then
						MinCladwidth = Positioncal.Position(9, i)
					End If
				Next
				If Positioncal.ConstBeamFlg <> 0S Then
					Dim num3 As Integer = CInt(Math.Round(Positioncal.Width1))
					If num3 < CInt(Math.Round(Positioncal.CladWidth)) Then
						Dim msgbxres As Short = CShort(Interaction.MsgBox("The minimum clad width is " + Positioncal.CladWidth.ToString("#.0") + ". Adjust width accordingly?" & vbCrLf & "(If yes, meander movement will also be disabled)", MsgBoxStyle.YesNo, "Question"))
						If msgbxres = 6S Then
							Positioncal.Width1 = Positioncal.CladWidth
							Me.Widthtxt.Text = Positioncal.Width1.ToString("#.0")
							Positioncal.MeanderFlg = 0S
							Me.MeandrFlg.CheckState = CheckState.Unchecked
							Interaction.MsgBox("The width has been recalculated to " + Positioncal.Width1.ToString("#0.0 mm"), MsgBoxStyle.Information, "Information")
						End If
					ElseIf num3 < CInt(Math.Round(2.0 * Positioncal.MeanderAmp + Positioncal.CladWidth)) Then
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
					ElseIf num3 < CInt(Math.Round(1.5 * Positioncal.Pitch + 2.0 * Positioncal.MeanderAmp + Positioncal.CladWidth)) AndAlso Me.MeandrFlg.CheckState = CheckState.Checked Then
						Dim msgbxres As Short = CShort(Interaction.MsgBox("The desired width is only slightly larger to the clad width." & vbCrLf & "Adjust meander amplitude to achieve the desired width in one revolution?", MsgBoxStyle.YesNo, "Question"))
						If msgbxres = 6S Then
							' The following expression was wrapped in a unchecked-expression
							Positioncal.MeanderAmp = Positioncal.Width1 - Positioncal.CladWidth / 2.0
							Me.Meandramp.Text = Positioncal.MeanderAmp.ToString("#.0")
							Interaction.MsgBox("The meander amplitude has been recalculated to " + Positioncal.MeanderAmp.ToString("#0.0 mm"), MsgBoxStyle.Information, "Information")
						End If
					End If
				End If
				If(Positioncal.MeanderFlg And Not Positioncal.ConstBeamFlg And If(-If((MinCladwidth <= 1.0 + Positioncal.CladWidth > False), 1S, 0S), 1S, 0S)) <> 0S Then
					Interaction.MsgBox("You have selected a meander movement with a variable clad width. The minimum clad width is smaller or only slightly greater than the beam diameter. Please adjust accordingly", MsgBoxStyle.Exclamation, Nothing)
				ElseIf Me.Stationslct.SelectedIndex <> -1 And Me.Movement.SelectedIndex <> -1 And Positioncal.Width1 >= Positioncal.CladWidth And Me.CurrPosStat.Checked Then
					Positioncal.StationPosition = Me.Stationslct.SelectedIndex + 1
					Positioncal.Movementtype = CShort(Me.Movement.SelectedIndex)
					If(Positioncal.PointNo < 4 And Positioncal.PointNo > 2) AndAlso (Positioncal.Movementtype = 0S Or Positioncal.Movementtype = 2S Or Positioncal.Movementtype = 4S) Then
						Interaction.MsgBox("At least four tought points are necessary for circular interpolation. You have uploaded " + Positioncal.PointNo.ToString() + " points. Linear interpolation will be used instead.", MsgBoxStyle.Exclamation, Nothing)
						Select Case Positioncal.Movementtype
							Case 0S
								Positioncal.Movementtype = 1S
								Me.Movement.SelectedIndex = 1
							Case 2S
								Positioncal.Movementtype = 3S
								Me.Movement.SelectedIndex = 3
							Case 4S
								Positioncal.Movementtype = 5S
								Me.Movement.SelectedIndex = 5
						End Select
					End If
					If Positioncal.CladdingDir = -1 Then
						Dim j As Integer = 0
						Do
							Dim num4 As Integer = 0
							Dim num5 As Integer = Positioncal.PointNo - 1
							For i As Integer = num4 To num5
								If j > 0 Then
									Positioncal.Position(j - 1, i) = temppos(i)
								End If
								If j < 10 Then
									temppos(i) = Positioncal.Position(j, i)
								End If
							Next
							Array.Reverse(temppos)
							j += 1
						Loop While j <= 10
					End If
					If(Positioncal.MeanderFlg And Not Positioncal.ConstBeamFlg) <> 0S Then
						Interaction.MsgBox("You have selected a meander movement with a variable clad width. Meander amplitude will be adjusted according to the correspondant clad width. Please specify the desired beam diameter in the Process Settings section", MsgBoxStyle.Exclamation, Nothing)
					End If
					Dim fs As FileStream = New FileStream(Application.StartupPath + "\3Dcladparam.txt", FileMode.Create)
					Dim w As StreamWriter = New StreamWriter(fs)
					w.WriteLine(Me.Widthtxt.Text)
					w.WriteLine(Me.Pittxt.Text)
					w.WriteLine(Me.Tooloffsettxt.Text)
					w.WriteLine(Positioncal.StationPosition.ToString())
					w.WriteLine(Positioncal.CladdingDir.ToString())
					w.WriteLine(Positioncal.MovDir.ToString())
					w.WriteLine(Positioncal.Overlaydir.ToString())
					w.WriteLine(Me.Meandramp.Text)
					w.WriteLine(Me.Meandrptc.Text)
					w.WriteLine(Positioncal.MeanderFlg.ToString())
					w.WriteLine(Positioncal.ArrDir.ToString())
					w.WriteLine(Positioncal.Copies.ToString())
					w.WriteLine(Positioncal.Arrayrecptc.ToString())
					w.WriteLine(Positioncal.Arrayangptc.ToString())
					w.WriteLine(Positioncal.Arraydir.ToString())
					w.WriteLine(Positioncal.CurrPos.ToString())
					w.WriteLine(Positioncal.ConstBeamFlg.ToString())
					w.WriteLine(Positioncal.Movementtype.ToString())
					w.Close()
					Me.DialogResult = DialogResult.OK
					Me.Close()
				ElseIf Positioncal.Width1 < Positioncal.CladWidth Then
					Interaction.MsgBox("The width should be at least " + Positioncal.CladWidth.ToString("#.0") + ". Please adjust accordingly", MsgBoxStyle.Exclamation, "Information")
				ElseIf Me.Stationslct.SelectedIndex = -1 Then
					Interaction.MsgBox("Please select the desired Station angle", MsgBoxStyle.Exclamation, "Station Angle Selection")
				ElseIf Me.Movement.SelectedIndex = -1 Then
					Interaction.MsgBox("Please select the desired movement type", MsgBoxStyle.Exclamation, "Station Angle Selection")
				ElseIf Not Me.CurrPosStat.Checked Then
					Interaction.MsgBox("You haven't specified any tought points. Click on 'Position Upload' and specify a trajectory.", MsgBoxStyle.Exclamation, "Trajectory Specification")
				End If
			End If
		End Sub

		' Token: 0x0600008F RID: 143 RVA: 0x0001AC04 File Offset: 0x00019004
		Private Sub Tooloffsettxt_TextChanged(sender As Object, e As EventArgs)
			If Versioned.IsNumeric(Me.Tooloffsettxt.Text) Then
				Dim value As Double = Conversions.ToDouble(Me.Tooloffsettxt.Text)
				Me.Tooloffsettxt.Text = value.ToString("#0.0")
				Positioncal.ToolOffset = Conversions.ToDouble(Me.Tooloffsettxt.Text)
			Else
				Interaction.MsgBox("This is not a valid value (Positive values towards the positive coordinate direction)", MsgBoxStyle.Exclamation, Nothing)
				Me.Tooloffsettxt.Text = 0.ToString("#0.0")
				Positioncal.ToolOffset = 0.0
			End If
		End Sub

		' Token: 0x06000090 RID: 144 RVA: 0x0001AC98 File Offset: 0x00019098
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

		' Token: 0x06000091 RID: 145 RVA: 0x0001AD24 File Offset: 0x00019124
		Private Sub Pittxt_Leave(sender As Object, e As EventArgs)
			If Versioned.IsNumeric(Me.Pittxt.Text) Then
				Dim value As Double = Conversions.ToDouble(Me.Pittxt.Text)
				Me.Pittxt.Text = value.ToString("#0.00")
				Positioncal.Pitch = value
			Else
				Interaction.MsgBox("This is not a valid numeric value (Positive values towards the positive coordinate direction)", MsgBoxStyle.Exclamation, Nothing)
				Me.Pittxt.Text = 4.ToString("#0.00")
				Positioncal.Pitch = 4.0
			End If
		End Sub

		' Token: 0x06000092 RID: 146 RVA: 0x0001ADA8 File Offset: 0x000191A8
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

		' Token: 0x06000093 RID: 147 RVA: 0x0001AE34 File Offset: 0x00019234
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

		' Token: 0x06000094 RID: 148 RVA: 0x0001AEC0 File Offset: 0x000192C0
		Private Sub CurrPosStat_Click(sender As Object, e As EventArgs)
			Dim form2rect As Rectangle = New Rectangle(50, 100, 845, 723)
			If Me.CurrPosStat.Checked Then
				Global.WindowsApplication1.My.MyProject.Forms.MPosıtıonupload.DesktopBounds = form2rect
				Global.WindowsApplication1.My.MyProject.Forms.MPosıtıonupload.ShowDialog()
				If Global.WindowsApplication1.My.MyProject.Forms.MPosıtıonupload.DialogResult = DialogResult.OK Then
					Positioncal.CurrPos = 1S
					If Positioncal.ConstBeamFlg <> 0S Then
						Positioncal.CladWidth = Positioncal.Position(9, 0)
						Positioncal.LaserPowerFin = CInt(Math.Round(Positioncal.Position(8, 0)))
						Me.Widthtxt.Enabled = True
						Me.Pittxt.Enabled = True
						Me.Meandramp.Enabled = True
					Else
						Me.Widthtxt.Enabled = False
						Me.Pittxt.Enabled = False
						Interaction.MsgBox("Only one track will be produced as a variable beam diameter has been specified", MsgBoxStyle.Exclamation, Nothing)
						If Positioncal.MeanderFlg <> 0S Then
							Me.Meandramp.Enabled = False
						End If
					End If
					Me.Stationslct.SelectedIndex = Positioncal.StationPosition - 1
					Me.Stationslct.Enabled = False
				Else
					Me.CurrPosStat.Checked = False
					Positioncal.CurrPos = 0S
				End If
			Else
				Positioncal.CurrPos = 0S
			End If
		End Sub

		' Token: 0x06000095 RID: 149 RVA: 0x0001AFFC File Offset: 0x000193FC
		Private Sub MeandrFlg_click(sender As Object, e As EventArgs)
			If Me.MeandrFlg.Checked Then
				Positioncal.MeanderFlg = 1S
			Else
				Positioncal.MeanderFlg = 0S
			End If
		End Sub

		' Token: 0x06000096 RID: 150 RVA: 0x0001B01C File Offset: 0x0001941C
		Private Sub Stationslct_SelectedIndexChanged(sender As Object, e As EventArgs)
			' The following expression was wrapped in a checked-expression
			Positioncal.StationPosition = Me.Stationslct.SelectedIndex + 1
		End Sub

		' Token: 0x06000097 RID: 151 RVA: 0x0001B030 File Offset: 0x00019430
		Private Sub Copiestxt_TextChanged(sender As Object, e As EventArgs)
			If Char.IsNumber(Conversions.ToChar(Me.Copiestxt.Text)) Then
				Dim value As Double = Conversions.ToDouble(Me.Copiestxt.Text)
				Me.Copiestxt.Text = value.ToString("#0")
				Positioncal.Copies = CShort(Math.Round(value))
			Else
				Interaction.MsgBox("This is not a valid value (Number of copies > 0)", MsgBoxStyle.Exclamation, Nothing)
				Me.Copiestxt.Text = 1.ToString("#0")
				Positioncal.Copies = 1S
			End If
		End Sub

		' Token: 0x06000098 RID: 152 RVA: 0x0001B0B8 File Offset: 0x000194B8
		Private Sub Arrayrecptctxt_Leave(sender As Object, e As EventArgs)
			If Versioned.IsNumeric(Me.Arrayrecptctxt.Text) Then
				Dim value As Double = Conversions.ToDouble(Me.Arrayrecptctxt.Text)
				Me.Arrayrecptctxt.Text = value.ToString("#0.00")
				Positioncal.Arrayrecptc = value
			Else
				Interaction.MsgBox("This is not a valid numeric value (Positive values towards the positive coordinate direction)", MsgBoxStyle.Exclamation, Nothing)
				Me.Arrayrecptctxt.Text = 3.0.ToString("#0")
				Positioncal.Arrayrecptc = 3.0
			End If
		End Sub

		' Token: 0x06000099 RID: 153 RVA: 0x0001B144 File Offset: 0x00019544
		Private Sub Arrayangptctxt_Leave(sender As Object, e As EventArgs)
			If Versioned.IsNumeric(Me.Arrayangptctxt.Text) Then
				Dim value As Double = Conversions.ToDouble(Me.Arrayangptctxt.Text)
				Me.Arrayangptctxt.Text = value.ToString("#0.00")
				Positioncal.Arrayangptc = value
			Else
				Interaction.MsgBox("This is not a valid numeric value (Positive values lead to anticlockwise rotation)", MsgBoxStyle.Exclamation, Nothing)
				Me.Arrayangptctxt.Text = 20.ToString("#0")
				Positioncal.Arrayangptc = 20.0
			End If
		End Sub

		' Token: 0x0600009A RID: 154 RVA: 0x0001B1CC File Offset: 0x000195CC
		Private Sub MovDirSelection_Enter(sender As Object, e As EventArgs)
			If Me.XDirMov.Checked Then
				Positioncal.MovDir = 0S
			ElseIf Me.YDirMov.Checked Then
				Positioncal.MovDir = 1S
			ElseIf Me.ZDirMov.Checked Then
				Positioncal.MovDir = 2S
			ElseIf Me.SpinDirMov.Checked Then
				Positioncal.MovDir = 3S
			End If
		End Sub

		' Token: 0x0600009B RID: 155 RVA: 0x0001B22C File Offset: 0x0001962C
		Private Sub ArrayDirSelection_Enter(sender As Object, e As EventArgs)
			If Me.XDirArr.Checked Then
				Positioncal.ArrDir = 0S
			ElseIf Me.YDirArr.Checked Then
				Positioncal.ArrDir = 1S
			ElseIf Me.ZDirArr.Checked Then
				Positioncal.ArrDir = 2S
			ElseIf Me.SpinDirArr.Checked Then
				Positioncal.ArrDir = 3S
			End If
		End Sub

		' Token: 0x0600009C RID: 156 RVA: 0x0001B28C File Offset: 0x0001968C
		Private Sub CladDirSelection_Enter(sender As Object, e As EventArgs)
			If Me.Leftdirflg.Checked Then
				Positioncal.CladdingDir = -1
			ElseIf Me.Rightdirflg.Checked Then
				Positioncal.CladdingDir = 1
			End If
		End Sub

		' Token: 0x0600009D RID: 157 RVA: 0x0001B2B8 File Offset: 0x000196B8
		Private Sub Overlaymovdir_Enter(sender As Object, e As EventArgs)
			If Me.Posmov.Checked Then
				Positioncal.Overlaydir = 1S
			ElseIf Me.Negmov.Checked Then
				Positioncal.Overlaydir = -1S
			End If
		End Sub

		' Token: 0x0600009E RID: 158 RVA: 0x0001B2E4 File Offset: 0x000196E4
		Private Sub Arraymovdir_Enter(sender As Object, e As EventArgs)
			If Me.Posarr.Checked Then
				Positioncal.Arraydir = 1S
			ElseIf Me.Negarr.Checked Then
				Positioncal.Arraydir = -1S
			End If
		End Sub

		' Token: 0x0600009F RID: 159 RVA: 0x0001B310 File Offset: 0x00019710
		Private Sub Movement_SelectedIndexChanged(sender As Object, e As EventArgs)
			' The following expression was wrapped in a checked-expression
			Positioncal.Movementtype = CShort(Me.Movement.SelectedIndex)
		End Sub

		' Token: 0x0400001B RID: 27
		<AccessedThroughProperty("Widthtxt")>
		Private _Widthtxt As TextBox

		' Token: 0x0400001C RID: 28
		<AccessedThroughProperty("Pittxt")>
		Private _Pittxt As TextBox

		' Token: 0x0400001D RID: 29
		<AccessedThroughProperty("GroupBox2")>
		Private _GroupBox2 As GroupBox

		' Token: 0x0400001E RID: 30
		<AccessedThroughProperty("Cnfrmbtn")>
		Private _Cnfrmbtn As Button

		' Token: 0x0400001F RID: 31
		<AccessedThroughProperty("Cnlbtn")>
		Private _Cnlbtn As Button

		' Token: 0x04000020 RID: 32
		<AccessedThroughProperty("GroupBox3")>
		Private _GroupBox3 As GroupBox

		' Token: 0x04000021 RID: 33
		<AccessedThroughProperty("Meandramp")>
		Private _Meandramp As TextBox

		' Token: 0x04000022 RID: 34
		<AccessedThroughProperty("MeandrFlg")>
		Private _MeandrFlg As CheckBox

		' Token: 0x04000023 RID: 35
		<AccessedThroughProperty("Meandrptc")>
		Private _Meandrptc As TextBox

		' Token: 0x04000024 RID: 36
		<AccessedThroughProperty("GroupBox1")>
		Private _GroupBox1 As GroupBox

		' Token: 0x04000025 RID: 37
		<AccessedThroughProperty("Tooloffsettxt")>
		Private _Tooloffsettxt As TextBox

		' Token: 0x04000026 RID: 38
		<AccessedThroughProperty("CladDirSelection")>
		Private _CladDirSelection As GroupBox

		' Token: 0x04000027 RID: 39
		<AccessedThroughProperty("Rightdirflg")>
		Private _Rightdirflg As RadioButton

		' Token: 0x04000028 RID: 40
		<AccessedThroughProperty("Leftdirflg")>
		Private _Leftdirflg As RadioButton

		' Token: 0x04000029 RID: 41
		<AccessedThroughProperty("FocLengthSelection")>
		Private _FocLengthSelection As GroupBox

		' Token: 0x0400002A RID: 42
		<AccessedThroughProperty("CurrPosStat")>
		Private _CurrPosStat As CheckBox

		' Token: 0x0400002B RID: 43
		<AccessedThroughProperty("MovDirSelection")>
		Private _MovDirSelection As GroupBox

		' Token: 0x0400002C RID: 44
		<AccessedThroughProperty("Stationslct")>
		Private _Stationslct As ListBox

		' Token: 0x0400002D RID: 45
		<AccessedThroughProperty("SpinDirMov")>
		Private _SpinDirMov As RadioButton

		' Token: 0x0400002E RID: 46
		<AccessedThroughProperty("ZDirMov")>
		Private _ZDirMov As RadioButton

		' Token: 0x0400002F RID: 47
		<AccessedThroughProperty("YDirMov")>
		Private _YDirMov As RadioButton

		' Token: 0x04000030 RID: 48
		<AccessedThroughProperty("XDirMov")>
		Private _XDirMov As RadioButton

		' Token: 0x04000031 RID: 49
		<AccessedThroughProperty("ArrayDirSelection")>
		Private _ArrayDirSelection As GroupBox

		' Token: 0x04000032 RID: 50
		<AccessedThroughProperty("Arrayangptctxt")>
		Private _Arrayangptctxt As TextBox

		' Token: 0x04000033 RID: 51
		<AccessedThroughProperty("Arrayrecptctxt")>
		Private _Arrayrecptctxt As TextBox

		' Token: 0x04000034 RID: 52
		<AccessedThroughProperty("Copiestxt")>
		Private _Copiestxt As TextBox

		' Token: 0x04000035 RID: 53
		<AccessedThroughProperty("SpinDirArr")>
		Private _SpinDirArr As RadioButton

		' Token: 0x04000036 RID: 54
		<AccessedThroughProperty("ZDirArr")>
		Private _ZDirArr As RadioButton

		' Token: 0x04000037 RID: 55
		<AccessedThroughProperty("YDirArr")>
		Private _YDirArr As RadioButton

		' Token: 0x04000038 RID: 56
		<AccessedThroughProperty("XDirArr")>
		Private _XDirArr As RadioButton

		' Token: 0x04000039 RID: 57
		<AccessedThroughProperty("Overlaymovdir")>
		Private _Overlaymovdir As GroupBox

		' Token: 0x0400003A RID: 58
		<AccessedThroughProperty("Posmov")>
		Private _Posmov As RadioButton

		' Token: 0x0400003B RID: 59
		<AccessedThroughProperty("Negmov")>
		Private _Negmov As RadioButton

		' Token: 0x0400003C RID: 60
		<AccessedThroughProperty("Arraymovdir")>
		Private _Arraymovdir As GroupBox

		' Token: 0x0400003D RID: 61
		<AccessedThroughProperty("Posarr")>
		Private _Posarr As RadioButton

		' Token: 0x0400003E RID: 62
		<AccessedThroughProperty("Negarr")>
		Private _Negarr As RadioButton

		' Token: 0x0400003F RID: 63
		<AccessedThroughProperty("Movement")>
		Private _Movement As ComboBox
	End Class
End Namespace
