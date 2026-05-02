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
	' Token: 0x0200000A RID: 10
	<DesignerGenerated()>
	Public Partial Class CONGRVPARAM
		Inherits Form

		' Token: 0x060000EB RID: 235 RVA: 0x0001EB64 File Offset: 0x0001CF64
		<DebuggerNonUserCode()>
		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.congroovecladparam_load
			Me.InitializeComponent()
		End Sub

		' Token: 0x17000057 RID: 87
		' (get) Token: 0x060000EE RID: 238 RVA: 0x000215BC File Offset: 0x0001F9BC
		' (set) Token: 0x060000EF RID: 239 RVA: 0x000215D0 File Offset: 0x0001F9D0
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

		' Token: 0x17000058 RID: 88
		' (get) Token: 0x060000F0 RID: 240 RVA: 0x0002161C File Offset: 0x0001FA1C
		' (set) Token: 0x060000F1 RID: 241 RVA: 0x00021630 File Offset: 0x0001FA30
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

		' Token: 0x17000059 RID: 89
		' (get) Token: 0x060000F2 RID: 242 RVA: 0x0002167C File Offset: 0x0001FA7C
		' (set) Token: 0x060000F3 RID: 243 RVA: 0x00021690 File Offset: 0x0001FA90
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

		' Token: 0x1700005A RID: 90
		' (get) Token: 0x060000F4 RID: 244 RVA: 0x000216DC File Offset: 0x0001FADC
		' (set) Token: 0x060000F5 RID: 245 RVA: 0x000216F0 File Offset: 0x0001FAF0
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

		' Token: 0x1700005B RID: 91
		' (get) Token: 0x060000F6 RID: 246 RVA: 0x0002173C File Offset: 0x0001FB3C
		' (set) Token: 0x060000F7 RID: 247 RVA: 0x00021750 File Offset: 0x0001FB50
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

		' Token: 0x1700005C RID: 92
		' (get) Token: 0x060000F8 RID: 248 RVA: 0x0002175C File Offset: 0x0001FB5C
		' (set) Token: 0x060000F9 RID: 249 RVA: 0x00021770 File Offset: 0x0001FB70
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

		' Token: 0x1700005D RID: 93
		' (get) Token: 0x060000FA RID: 250 RVA: 0x000217BC File Offset: 0x0001FBBC
		' (set) Token: 0x060000FB RID: 251 RVA: 0x000217D0 File Offset: 0x0001FBD0
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

		' Token: 0x1700005E RID: 94
		' (get) Token: 0x060000FC RID: 252 RVA: 0x0002181C File Offset: 0x0001FC1C
		' (set) Token: 0x060000FD RID: 253 RVA: 0x00021830 File Offset: 0x0001FC30
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

		' Token: 0x1700005F RID: 95
		' (get) Token: 0x060000FE RID: 254 RVA: 0x0002183C File Offset: 0x0001FC3C
		' (set) Token: 0x060000FF RID: 255 RVA: 0x00021850 File Offset: 0x0001FC50
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

		' Token: 0x17000060 RID: 96
		' (get) Token: 0x06000100 RID: 256 RVA: 0x0002189C File Offset: 0x0001FC9C
		' (set) Token: 0x06000101 RID: 257 RVA: 0x000218B0 File Offset: 0x0001FCB0
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

		' Token: 0x17000061 RID: 97
		' (get) Token: 0x06000102 RID: 258 RVA: 0x000218FC File Offset: 0x0001FCFC
		' (set) Token: 0x06000103 RID: 259 RVA: 0x00021910 File Offset: 0x0001FD10
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

		' Token: 0x17000062 RID: 98
		' (get) Token: 0x06000104 RID: 260 RVA: 0x0002195C File Offset: 0x0001FD5C
		' (set) Token: 0x06000105 RID: 261 RVA: 0x00021970 File Offset: 0x0001FD70
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

		' Token: 0x17000063 RID: 99
		' (get) Token: 0x06000106 RID: 262 RVA: 0x000219BC File Offset: 0x0001FDBC
		' (set) Token: 0x06000107 RID: 263 RVA: 0x000219D0 File Offset: 0x0001FDD0
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

		' Token: 0x17000064 RID: 100
		' (get) Token: 0x06000108 RID: 264 RVA: 0x00021A1C File Offset: 0x0001FE1C
		' (set) Token: 0x06000109 RID: 265 RVA: 0x00021A30 File Offset: 0x0001FE30
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

		' Token: 0x17000065 RID: 101
		' (get) Token: 0x0600010A RID: 266 RVA: 0x00021A7C File Offset: 0x0001FE7C
		' (set) Token: 0x0600010B RID: 267 RVA: 0x00021A90 File Offset: 0x0001FE90
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

		' Token: 0x17000066 RID: 102
		' (get) Token: 0x0600010C RID: 268 RVA: 0x00021ADC File Offset: 0x0001FEDC
		' (set) Token: 0x0600010D RID: 269 RVA: 0x00021AF0 File Offset: 0x0001FEF0
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

		' Token: 0x17000067 RID: 103
		' (get) Token: 0x0600010E RID: 270 RVA: 0x00021AFC File Offset: 0x0001FEFC
		' (set) Token: 0x0600010F RID: 271 RVA: 0x00021B10 File Offset: 0x0001FF10
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

		' Token: 0x17000068 RID: 104
		' (get) Token: 0x06000110 RID: 272 RVA: 0x00021B5C File Offset: 0x0001FF5C
		' (set) Token: 0x06000111 RID: 273 RVA: 0x00021B70 File Offset: 0x0001FF70
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

		' Token: 0x17000069 RID: 105
		' (get) Token: 0x06000112 RID: 274 RVA: 0x00021B7C File Offset: 0x0001FF7C
		' (set) Token: 0x06000113 RID: 275 RVA: 0x00021B90 File Offset: 0x0001FF90
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
					RemoveHandler Me._Rightdirflg.CheckedChanged, value2
				End If
				Me._Rightdirflg = value
				If Me._Rightdirflg IsNot Nothing Then
					AddHandler Me._Rightdirflg.CheckedChanged, value2
				End If
			End Set
		End Property

		' Token: 0x1700006A RID: 106
		' (get) Token: 0x06000114 RID: 276 RVA: 0x00021BDC File Offset: 0x0001FFDC
		' (set) Token: 0x06000115 RID: 277 RVA: 0x00021BF0 File Offset: 0x0001FFF0
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
					RemoveHandler Me._Leftdirflg.CheckedChanged, value2
				End If
				Me._Leftdirflg = value
				If Me._Leftdirflg IsNot Nothing Then
					AddHandler Me._Leftdirflg.CheckedChanged, value2
				End If
			End Set
		End Property

		' Token: 0x1700006B RID: 107
		' (get) Token: 0x06000116 RID: 278 RVA: 0x00021C3C File Offset: 0x0002003C
		' (set) Token: 0x06000117 RID: 279 RVA: 0x00021C50 File Offset: 0x00020050
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

		' Token: 0x1700006C RID: 108
		' (get) Token: 0x06000118 RID: 280 RVA: 0x00021C9C File Offset: 0x0002009C
		' (set) Token: 0x06000119 RID: 281 RVA: 0x00021CB0 File Offset: 0x000200B0
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

		' Token: 0x1700006D RID: 109
		' (get) Token: 0x0600011A RID: 282 RVA: 0x00021CBC File Offset: 0x000200BC
		' (set) Token: 0x0600011B RID: 283 RVA: 0x00021CD0 File Offset: 0x000200D0
		Friend Overridable Property FL_200 As RadioButton
			<DebuggerNonUserCode()>
			Get
				Return Me._FL_200
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As RadioButton)
				Dim value2 As EventHandler = AddressOf Me.FL_200_CheckedChanged
				If Me._FL_200 IsNot Nothing Then
					RemoveHandler Me._FL_200.CheckedChanged, value2
				End If
				Me._FL_200 = value
				If Me._FL_200 IsNot Nothing Then
					AddHandler Me._FL_200.CheckedChanged, value2
				End If
			End Set
		End Property

		' Token: 0x1700006E RID: 110
		' (get) Token: 0x0600011C RID: 284 RVA: 0x00021D1C File Offset: 0x0002011C
		' (set) Token: 0x0600011D RID: 285 RVA: 0x00021D30 File Offset: 0x00020130
		Friend Overridable Property FL_400 As RadioButton
			<DebuggerNonUserCode()>
			Get
				Return Me._FL_400
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As RadioButton)
				Dim value2 As EventHandler = AddressOf Me.FL_400_CheckedChanged
				If Me._FL_400 IsNot Nothing Then
					RemoveHandler Me._FL_400.CheckedChanged, value2
				End If
				Me._FL_400 = value
				If Me._FL_400 IsNot Nothing Then
					AddHandler Me._FL_400.CheckedChanged, value2
				End If
			End Set
		End Property

		' Token: 0x1700006F RID: 111
		' (get) Token: 0x0600011E RID: 286 RVA: 0x00021D7C File Offset: 0x0002017C
		' (set) Token: 0x0600011F RID: 287 RVA: 0x00021D90 File Offset: 0x00020190
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

		' Token: 0x17000070 RID: 112
		' (get) Token: 0x06000120 RID: 288 RVA: 0x00021DDC File Offset: 0x000201DC
		' (set) Token: 0x06000121 RID: 289 RVA: 0x00021DF0 File Offset: 0x000201F0
		Friend Overridable Property GroupBox6 As GroupBox
			<DebuggerNonUserCode()>
			Get
				Return Me._GroupBox6
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As GroupBox)
				Me._GroupBox6 = value
			End Set
		End Property

		' Token: 0x17000071 RID: 113
		' (get) Token: 0x06000122 RID: 290 RVA: 0x00021DFC File Offset: 0x000201FC
		' (set) Token: 0x06000123 RID: 291 RVA: 0x00021E10 File Offset: 0x00020210
		Friend Overridable Property Intoverwtxt As TextBox
			<DebuggerNonUserCode()>
			Get
				Return Me._Intoverwtxt
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As EventHandler = AddressOf Me.Intoverwtxt_Leave
				If Me._Intoverwtxt IsNot Nothing Then
					RemoveHandler Me._Intoverwtxt.Leave, value2
				End If
				Me._Intoverwtxt = value
				If Me._Intoverwtxt IsNot Nothing Then
					AddHandler Me._Intoverwtxt.Leave, value2
				End If
			End Set
		End Property

		' Token: 0x17000072 RID: 114
		' (get) Token: 0x06000124 RID: 292 RVA: 0x00021E5C File Offset: 0x0002025C
		' (set) Token: 0x06000125 RID: 293 RVA: 0x00021E70 File Offset: 0x00020270
		Friend Overridable Property Leftangtxt As TextBox
			<DebuggerNonUserCode()>
			Get
				Return Me._Leftangtxt
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As EventHandler = AddressOf Me.Leftangtxt_Leave
				If Me._Leftangtxt IsNot Nothing Then
					RemoveHandler Me._Leftangtxt.Leave, value2
				End If
				Me._Leftangtxt = value
				If Me._Leftangtxt IsNot Nothing Then
					AddHandler Me._Leftangtxt.Leave, value2
				End If
			End Set
		End Property

		' Token: 0x17000073 RID: 115
		' (get) Token: 0x06000126 RID: 294 RVA: 0x00021EBC File Offset: 0x000202BC
		' (set) Token: 0x06000127 RID: 295 RVA: 0x00021ED0 File Offset: 0x000202D0
		Friend Overridable Property Layernotxt As TextBox
			<DebuggerNonUserCode()>
			Get
				Return Me._Layernotxt
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As EventHandler = AddressOf Me.Layernotxt_Leave
				If Me._Layernotxt IsNot Nothing Then
					RemoveHandler Me._Layernotxt.Leave, value2
				End If
				Me._Layernotxt = value
				If Me._Layernotxt IsNot Nothing Then
					AddHandler Me._Layernotxt.Leave, value2
				End If
			End Set
		End Property

		' Token: 0x17000074 RID: 116
		' (get) Token: 0x06000128 RID: 296 RVA: 0x00021F1C File Offset: 0x0002031C
		' (set) Token: 0x06000129 RID: 297 RVA: 0x00021F30 File Offset: 0x00020330
		Friend Overridable Property Rightangtxt As TextBox
			<DebuggerNonUserCode()>
			Get
				Return Me._Rightangtxt
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As EventHandler = AddressOf Me.Rightangtxt_Leave
				If Me._Rightangtxt IsNot Nothing Then
					RemoveHandler Me._Rightangtxt.Leave, value2
				End If
				Me._Rightangtxt = value
				If Me._Rightangtxt IsNot Nothing Then
					AddHandler Me._Rightangtxt.Leave, value2
				End If
			End Set
		End Property

		' Token: 0x17000075 RID: 117
		' (get) Token: 0x0600012A RID: 298 RVA: 0x00021F7C File Offset: 0x0002037C
		' (set) Token: 0x0600012B RID: 299 RVA: 0x00021F90 File Offset: 0x00020390
		Friend Overridable Property Layerhttxt As TextBox
			<DebuggerNonUserCode()>
			Get
				Return Me._Layerhttxt
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As EventHandler = AddressOf Me.Layerhttxt_Leave
				If Me._Layerhttxt IsNot Nothing Then
					RemoveHandler Me._Layerhttxt.Leave, value2
				End If
				Me._Layerhttxt = value
				If Me._Layerhttxt IsNot Nothing Then
					AddHandler Me._Layerhttxt.Leave, value2
				End If
			End Set
		End Property

		' Token: 0x17000076 RID: 118
		' (get) Token: 0x0600012C RID: 300 RVA: 0x00021FDC File Offset: 0x000203DC
		' (set) Token: 0x0600012D RID: 301 RVA: 0x00021FF0 File Offset: 0x000203F0
		Friend Overridable Property Rockangtxt As TextBox
			<DebuggerNonUserCode()>
			Get
				Return Me._Rockangtxt
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As EventHandler = AddressOf Me.Rockangtxt_Leave
				If Me._Rockangtxt IsNot Nothing Then
					RemoveHandler Me._Rockangtxt.Leave, value2
				End If
				Me._Rockangtxt = value
				If Me._Rockangtxt IsNot Nothing Then
					AddHandler Me._Rockangtxt.Leave, value2
				End If
			End Set
		End Property

		' Token: 0x17000077 RID: 119
		' (get) Token: 0x0600012E RID: 302 RVA: 0x0002203C File Offset: 0x0002043C
		' (set) Token: 0x0600012F RID: 303 RVA: 0x00022050 File Offset: 0x00020450
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

		' Token: 0x17000078 RID: 120
		' (get) Token: 0x06000130 RID: 304 RVA: 0x0002209C File Offset: 0x0002049C
		' (set) Token: 0x06000131 RID: 305 RVA: 0x000220B0 File Offset: 0x000204B0
		Friend Overridable Property GroupBox7 As GroupBox
			<DebuggerNonUserCode()>
			Get
				Return Me._GroupBox7
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As GroupBox)
				Me._GroupBox7 = value
			End Set
		End Property

		' Token: 0x17000079 RID: 121
		' (get) Token: 0x06000132 RID: 306 RVA: 0x000220BC File Offset: 0x000204BC
		' (set) Token: 0x06000133 RID: 307 RVA: 0x000220D0 File Offset: 0x000204D0
		Friend Overridable Property Vlvspind As RadioButton
			<DebuggerNonUserCode()>
			Get
				Return Me._Vlvspind
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As RadioButton)
				Dim value2 As EventHandler = AddressOf Me.Vlvspind_CheckedClick
				If Me._Vlvspind IsNot Nothing Then
					RemoveHandler Me._Vlvspind.Click, value2
				End If
				Me._Vlvspind = value
				If Me._Vlvspind IsNot Nothing Then
					AddHandler Me._Vlvspind.Click, value2
				End If
			End Set
		End Property

		' Token: 0x1700007A RID: 122
		' (get) Token: 0x06000134 RID: 308 RVA: 0x0002211C File Offset: 0x0002051C
		' (set) Token: 0x06000135 RID: 309 RVA: 0x00022130 File Offset: 0x00020530
		Friend Overridable Property Vlvseat As RadioButton
			<DebuggerNonUserCode()>
			Get
				Return Me._Vlvseat
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As RadioButton)
				Dim value2 As EventHandler = AddressOf Me.Vlvseat_CheckedClick
				If Me._Vlvseat IsNot Nothing Then
					RemoveHandler Me._Vlvseat.Click, value2
				End If
				Me._Vlvseat = value
				If Me._Vlvseat IsNot Nothing Then
					AddHandler Me._Vlvseat.Click, value2
				End If
			End Set
		End Property

		' Token: 0x1700007B RID: 123
		' (get) Token: 0x06000136 RID: 310 RVA: 0x0002217C File Offset: 0x0002057C
		' (set) Token: 0x06000137 RID: 311 RVA: 0x00022190 File Offset: 0x00020590
		Friend Overridable Property FL_300 As RadioButton
			<DebuggerNonUserCode()>
			Get
				Return Me._FL_300
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As RadioButton)
				Dim value2 As EventHandler = AddressOf Me.FL_300_CheckedChanged
				If Me._FL_300 IsNot Nothing Then
					RemoveHandler Me._FL_300.CheckedChanged, value2
				End If
				Me._FL_300 = value
				If Me._FL_300 IsNot Nothing Then
					AddHandler Me._FL_300.CheckedChanged, value2
				End If
			End Set
		End Property

		' Token: 0x1700007C RID: 124
		' (get) Token: 0x06000138 RID: 312 RVA: 0x000221DC File Offset: 0x000205DC
		' (set) Token: 0x06000139 RID: 313 RVA: 0x000221F0 File Offset: 0x000205F0
		Friend Overridable Property Rockangvartxt As ComboBox
			<DebuggerNonUserCode()>
			Get
				Return Me._Rockangvartxt
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ComboBox)
				Dim value2 As EventHandler = AddressOf Me.Rockangvartxt_SelectedIndexChanged
				If Me._Rockangvartxt IsNot Nothing Then
					RemoveHandler Me._Rockangvartxt.SelectedIndexChanged, value2
				End If
				Me._Rockangvartxt = value
				If Me._Rockangvartxt IsNot Nothing Then
					AddHandler Me._Rockangvartxt.SelectedIndexChanged, value2
				End If
			End Set
		End Property

		' Token: 0x0600013A RID: 314 RVA: 0x0002223C File Offset: 0x0002063C
		Private Sub congroovecladparam_load(sender As Object, e As EventArgs)
			Me.Diatxt.Text = Positioncal.Diameter.ToString("#0.0")
			Me.Widthtxt.Text = Positioncal.Width1.ToString("#0.0")
			Me.Distxt.Text = Positioncal.Distance.ToString("#0.00")
			Me.Pittxt.Text = Positioncal.Pitch.ToString("#0.00")
			Me.Tooloffsettxt.Text = Positioncal.ToolOffset.ToString("#0.0")
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
			If Positioncal.CladdingDir = 1 Then
				Me.Rightdirflg.Checked = True
			Else
				Me.Leftdirflg.Checked = True
			End If
			Me.Leftangtxt.Text = (Positioncal.Leftangle * 180.0 / 3.141592653589793).ToString("#0.00")
			Me.Rightangtxt.Text = (Positioncal.Rightangle * 180.0 / 3.141592653589793).ToString("#0.00")
			Me.Layerhttxt.Text = Positioncal.Layerheight.ToString("#0.0")
			Me.Layernotxt.Text = Positioncal.Layernumber.ToString("#0")
			Me.Intoverwtxt.Text = Positioncal.Intoverweld.ToString("#0.0")
			Me.Rockangtxt.Text = Positioncal.Rockangle.ToString("#0.00")
			Me.Postatxt.Text = Positioncal.PostureAngle.ToString("#0.00")
			Me.Conatxt.Text = Positioncal.ConeAngle.ToString("#0.00")
			Me.Inioverwtxt.Text = Positioncal.IniOverWeld.ToString("#0.0")
			Me.Finoverwtxt.Text = Positioncal.FinOverWeld.ToString("#0.0")
			Me.Meandramp.Text = Positioncal.MeanderAmp.ToString("#0.0")
			Me.Meandrptc.Text = Positioncal.MeanderPitch.ToString("#0.0")
			Me.MeandrFlg.CheckState = CType(Positioncal.MeanderFlg, CheckState)
			Me.CurrPosStat.Checked = (Positioncal.CurrPos <> 0S)
			Select Case Positioncal.ValveFlg
				Case False
					Me.Vlvseat.Checked = False
					Me.Vlvspind.Checked = True
				Case True
					Me.Vlvseat.Checked = True
					Me.Vlvspind.Checked = False
			End Select
			Me.Rockangvartxt.SelectedIndex = CInt(Positioncal.Rockangvar)
		End Sub

		' Token: 0x0600013B RID: 315 RVA: 0x00022520 File Offset: 0x00020920
		Private Sub Cnlbtn_Click(sender As Object, e As EventArgs)
			Me.Close()
		End Sub

		' Token: 0x0600013C RID: 316 RVA: 0x00022528 File Offset: 0x00020928
		Private Sub Cnfrmbtn_Click(sender As Object, e As EventArgs)
			Dim fs As FileStream = New FileStream(Application.StartupPath + "\Congroovecladparam.txt", FileMode.Create)
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
			If Me.Stationslct.SelectedIndex <> -1 And Positioncal.Width1 >= Positioncal.CladWidth Then
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
				w.WriteLine(Me.Diatxt.Text)
				w.WriteLine(Me.Widthtxt.Text)
				w.WriteLine(Me.Distxt.Text)
				w.WriteLine(Me.Pittxt.Text)
				w.WriteLine(Me.Tooloffsettxt.Text)
				w.WriteLine(Positioncal.StationPosition.ToString())
				w.WriteLine(Positioncal.CladdingDir.ToString())
				w.WriteLine(Positioncal.Leftangle.ToString())
				w.WriteLine(Positioncal.Rightangle.ToString())
				w.WriteLine(Positioncal.Layerheight.ToString())
				w.WriteLine(Positioncal.Layernumber.ToString())
				w.WriteLine(Positioncal.Intoverweld.ToString())
				w.WriteLine(Positioncal.Rockangle.ToString())
				w.WriteLine(Me.Postatxt.Text)
				w.WriteLine(Me.Conatxt.Text)
				w.WriteLine(Me.Inioverwtxt.Text)
				w.WriteLine(Me.Finoverwtxt.Text)
				w.WriteLine(Me.Meandramp.Text)
				w.WriteLine(Me.Meandrptc.Text)
				w.WriteLine(Me.Initang.Text)
				w.WriteLine(Positioncal.MeanderFlg.ToString())
				w.WriteLine(Positioncal.CurrPos.ToString())
				w.WriteLine(Positioncal.ValveFlg.ToString())
				w.WriteLine(Positioncal.Rockangvar.ToString())
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

		' Token: 0x0600013D RID: 317 RVA: 0x00022B64 File Offset: 0x00020F64
		Private Sub Tooloffsettxt_TextChanged(sender As Object, e As EventArgs)
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

		' Token: 0x0600013E RID: 318 RVA: 0x00022BF8 File Offset: 0x00020FF8
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

		' Token: 0x0600013F RID: 319 RVA: 0x00022C94 File Offset: 0x00021094
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

		' Token: 0x06000140 RID: 320 RVA: 0x00022D20 File Offset: 0x00021120
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

		' Token: 0x06000141 RID: 321 RVA: 0x00022E14 File Offset: 0x00021214
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

		' Token: 0x06000142 RID: 322 RVA: 0x00022EA0 File Offset: 0x000212A0
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

		' Token: 0x06000143 RID: 323 RVA: 0x00022FA0 File Offset: 0x000213A0
		Private Sub Conatxt_Leave(sender As Object, e As EventArgs)
			If Versioned.IsNumeric(Me.Conatxt.Text) Then
				If Conversions.ToDouble(Me.Conatxt.Text) <= 90.0 And Conversions.ToDouble(Me.Conatxt.Text) >= -90.0 Then
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

		' Token: 0x06000144 RID: 324 RVA: 0x000230A0 File Offset: 0x000214A0
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

		' Token: 0x06000145 RID: 325 RVA: 0x00023198 File Offset: 0x00021598
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

		' Token: 0x06000146 RID: 326 RVA: 0x00023298 File Offset: 0x00021698
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

		' Token: 0x06000147 RID: 327 RVA: 0x00023324 File Offset: 0x00021724
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

		' Token: 0x06000148 RID: 328 RVA: 0x000233B0 File Offset: 0x000217B0
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

		' Token: 0x06000149 RID: 329 RVA: 0x000234C8 File Offset: 0x000218C8
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

		' Token: 0x0600014A RID: 330 RVA: 0x000236EC File Offset: 0x00021AEC
		Private Sub Leftdirflg_CheckedChanged(sender As Object, e As EventArgs)
			If Me.Leftdirflg.Checked Then
				Positioncal.CladdingDir = -1
			End If
		End Sub

		' Token: 0x0600014B RID: 331 RVA: 0x00023704 File Offset: 0x00021B04
		Private Sub Rightdirflg_CheckedChanged(sender As Object, e As EventArgs)
			If Me.Rightdirflg.Checked Then
				Positioncal.CladdingDir = 1
			End If
		End Sub

		' Token: 0x0600014C RID: 332 RVA: 0x0002371C File Offset: 0x00021B1C
		Private Sub FL_400_CheckedChanged(sender As Object, e As EventArgs)
			If Me.FL_400.Checked Then
				Positioncal.Toolno = 0
			End If
		End Sub

		' Token: 0x0600014D RID: 333 RVA: 0x00023734 File Offset: 0x00021B34
		Private Sub FL_300_CheckedChanged(sender As Object, e As EventArgs)
			If Me.FL_300.Checked Then
				Positioncal.Toolno = 1
			End If
		End Sub

		' Token: 0x0600014E RID: 334 RVA: 0x0002374C File Offset: 0x00021B4C
		Private Sub FL_200_CheckedChanged(sender As Object, e As EventArgs)
			If Me.FL_200.Checked Then
				Positioncal.Toolno = 2
			End If
		End Sub

		' Token: 0x0600014F RID: 335 RVA: 0x00023764 File Offset: 0x00021B64
		Private Sub MeandrFlg_click(sender As Object, e As EventArgs)
			If Me.MeandrFlg.Checked Then
				Positioncal.MeanderFlg = 1S
			Else
				Positioncal.MeanderFlg = 0S
			End If
		End Sub

		' Token: 0x06000150 RID: 336 RVA: 0x00023784 File Offset: 0x00021B84
		Private Sub Leftangtxt_Leave(sender As Object, e As EventArgs)
			If Versioned.IsNumeric(Me.Leftangtxt.Text) Then
				If Conversions.ToDouble(Me.Leftangtxt.Text) <= 80.0 And Conversions.ToDouble(Me.Leftangtxt.Text) >= -80.0 Then
					Dim value As Double = Conversions.ToDouble(Me.Leftangtxt.Text)
					Me.Leftangtxt.Text = value.ToString("#0.00")
					Positioncal.Leftangle = value * 3.141592653589793 / 180.0
				Else
					Interaction.MsgBox("The Cone angle should be within -80 and 80 degrees to the axis", MsgBoxStyle.Exclamation, Nothing)
					Me.Leftangtxt.Text = 90.ToString("#0.00")
					Positioncal.Leftangle = 1.5707963267948966
				End If
			Else
				Interaction.MsgBox("This is not a valid value", MsgBoxStyle.Exclamation, Nothing)
				Me.Leftangtxt.Text = 90.ToString("#0.00")
				Positioncal.Leftangle = 1.5707963267948966
			End If
		End Sub

		' Token: 0x06000151 RID: 337 RVA: 0x00023898 File Offset: 0x00021C98
		Private Sub Rightangtxt_Leave(sender As Object, e As EventArgs)
			If Versioned.IsNumeric(Me.Leftangtxt.Text) Then
				If Conversions.ToDouble(Me.Rightangtxt.Text) <= 80.0 And Conversions.ToDouble(Me.Rightangtxt.Text) >= -80.0 Then
					Dim value As Double = Conversions.ToDouble(Me.Rightangtxt.Text)
					Me.Rightangtxt.Text = value.ToString("#0.00")
					Positioncal.Rightangle = value * 3.141592653589793 / 180.0
				Else
					Interaction.MsgBox("The Cone angle should be within -80 and 80 degrees to the axis", MsgBoxStyle.Exclamation, Nothing)
					Me.Rightangtxt.Text = 90.ToString("#0.00")
					Positioncal.Rightangle = 1.5707963267948966
				End If
			Else
				Interaction.MsgBox("This is not a valid value", MsgBoxStyle.Exclamation, Nothing)
				Me.Rightangtxt.Text = 90.ToString("#0.00")
				Positioncal.Rightangle = 1.5707963267948966
			End If
		End Sub

		' Token: 0x06000152 RID: 338 RVA: 0x000239AC File Offset: 0x00021DAC
		Private Sub Layerhttxt_Leave(sender As Object, e As EventArgs)
			If Char.IsNumber(Conversions.ToChar(Me.Layerhttxt.Text)) Then
				Dim value As Double = Conversions.ToDouble(Me.Layerhttxt.Text)
				Me.Layerhttxt.Text = value.ToString("#0.00")
				Positioncal.Layerheight = value
			Else
				Interaction.MsgBox("This is not a valid value", MsgBoxStyle.Exclamation, Nothing)
				Me.Layerhttxt.Text = 1.ToString("#0.00")
				Positioncal.Layerheight = 1.0
			End If
		End Sub

		' Token: 0x06000153 RID: 339 RVA: 0x00023A38 File Offset: 0x00021E38
		Private Sub Layernotxt_Leave(sender As Object, e As EventArgs)
			If Char.IsNumber(Conversions.ToChar(Me.Layernotxt.Text)) Then
				' The following expression was wrapped in a checked-expression
				Dim value As Integer = CInt(Math.Round(Conversions.ToDouble(Me.Layernotxt.Text)))
				Me.Layernotxt.Text = value.ToString("#0")
				Positioncal.Layernumber = value
			Else
				Interaction.MsgBox("This is not a valid value", MsgBoxStyle.Exclamation, Nothing)
				Me.Layernotxt.Text = 1.ToString("#0")
				Positioncal.Layernumber = 1
			End If
		End Sub

		' Token: 0x06000154 RID: 340 RVA: 0x00023AC0 File Offset: 0x00021EC0
		Private Sub Intoverwtxt_Leave(sender As Object, e As EventArgs)
			If Char.IsNumber(Conversions.ToChar(Me.Intoverwtxt.Text)) Then
				If Conversions.ToDouble(Me.Intoverwtxt.Text) <= 200.0 Then
					Dim value As Short = Conversions.ToShort(Me.Intoverwtxt.Text)
					Me.Intoverwtxt.Text = value.ToString("#0.0")
					Positioncal.Intoverweld = CSng(value)
				Else
					Interaction.MsgBox("The intermediate overweld should be within 0 and 200%", MsgBoxStyle.Exclamation, Nothing)
					Me.Intoverwtxt.Text = 50.ToString("#0.0")
					Positioncal.Intoverweld = 50F
				End If
			Else
				Interaction.MsgBox("This is not a valid value", MsgBoxStyle.Exclamation, Nothing)
				Me.Intoverwtxt.Text = 50.ToString("#0.0")
				Positioncal.Intoverweld = 50F
			End If
		End Sub

		' Token: 0x06000155 RID: 341 RVA: 0x00023B9C File Offset: 0x00021F9C
		Private Sub Rockangtxt_Leave(sender As Object, e As EventArgs)
			If Char.IsNumber(Conversions.ToChar(Me.Rockangtxt.Text)) Then
				If Conversions.ToDouble(Me.Rockangtxt.Text) <= 45.0 Then
					' The following expression was wrapped in a checked-expression
					Dim value As Short = CShort(Math.Round(Conversions.ToDouble(Me.Rockangtxt.Text)))
					Me.Rockangtxt.Text = value.ToString("#0.00")
					Positioncal.Rockangle = CDbl(value)
				Else
					Interaction.MsgBox("The intermediate overweld should be within 0 and 45 Deg", MsgBoxStyle.Exclamation, Nothing)
					Me.Rockangtxt.Text = 10.ToString("#0.00")
					Positioncal.Rockangle = 10.0
				End If
			Else
				Interaction.MsgBox("This is not a valid value", MsgBoxStyle.Exclamation, Nothing)
				Me.Rockangtxt.Text = 10.ToString("#0.00")
				Positioncal.Rockangle = 10.0
			End If
		End Sub

		' Token: 0x06000156 RID: 342 RVA: 0x00023C84 File Offset: 0x00022084
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

		' Token: 0x06000157 RID: 343 RVA: 0x00023CD4 File Offset: 0x000220D4
		Private Sub Vlvseat_CheckedClick(sender As Object, e As EventArgs)
			If Me.Vlvseat.Checked Then
				Positioncal.ValveFlg = True
			End If
		End Sub

		' Token: 0x06000158 RID: 344 RVA: 0x00023CEC File Offset: 0x000220EC
		Private Sub Vlvspind_CheckedClick(sender As Object, e As EventArgs)
			If Me.Vlvspind.Checked Then
				Positioncal.ValveFlg = False
			End If
		End Sub

		' Token: 0x06000159 RID: 345 RVA: 0x00023D04 File Offset: 0x00022104
		Private Sub Rockangvartxt_SelectedIndexChanged(sender As Object, e As EventArgs)
			Select Case Me.Rockangvartxt.SelectedIndex
				Case 0
					Positioncal.Rockangvar = 0S
				Case 1
					Positioncal.Rockangvar = 1S
			End Select
		End Sub

		' Token: 0x0400005B RID: 91
		<AccessedThroughProperty("Diatxt")>
		Private _Diatxt As TextBox

		' Token: 0x0400005C RID: 92
		<AccessedThroughProperty("Widthtxt")>
		Private _Widthtxt As TextBox

		' Token: 0x0400005D RID: 93
		<AccessedThroughProperty("Distxt")>
		Private _Distxt As TextBox

		' Token: 0x0400005E RID: 94
		<AccessedThroughProperty("Pittxt")>
		Private _Pittxt As TextBox

		' Token: 0x0400005F RID: 95
		<AccessedThroughProperty("GroupBox2")>
		Private _GroupBox2 As GroupBox

		' Token: 0x04000060 RID: 96
		<AccessedThroughProperty("Cnfrmbtn")>
		Private _Cnfrmbtn As Button

		' Token: 0x04000061 RID: 97
		<AccessedThroughProperty("Cnlbtn")>
		Private _Cnlbtn As Button

		' Token: 0x04000062 RID: 98
		<AccessedThroughProperty("GroupBox3")>
		Private _GroupBox3 As GroupBox

		' Token: 0x04000063 RID: 99
		<AccessedThroughProperty("Postatxt")>
		Private _Postatxt As TextBox

		' Token: 0x04000064 RID: 100
		<AccessedThroughProperty("Meandramp")>
		Private _Meandramp As TextBox

		' Token: 0x04000065 RID: 101
		<AccessedThroughProperty("Conatxt")>
		Private _Conatxt As TextBox

		' Token: 0x04000066 RID: 102
		<AccessedThroughProperty("Inioverwtxt")>
		Private _Inioverwtxt As TextBox

		' Token: 0x04000067 RID: 103
		<AccessedThroughProperty("MeandrFlg")>
		Private _MeandrFlg As CheckBox

		' Token: 0x04000068 RID: 104
		<AccessedThroughProperty("Meandrptc")>
		Private _Meandrptc As TextBox

		' Token: 0x04000069 RID: 105
		<AccessedThroughProperty("Initang")>
		Private _Initang As TextBox

		' Token: 0x0400006A RID: 106
		<AccessedThroughProperty("GroupBox1")>
		Private _GroupBox1 As GroupBox

		' Token: 0x0400006B RID: 107
		<AccessedThroughProperty("Tooloffsettxt")>
		Private _Tooloffsettxt As TextBox

		' Token: 0x0400006C RID: 108
		<AccessedThroughProperty("GroupBox4")>
		Private _GroupBox4 As GroupBox

		' Token: 0x0400006D RID: 109
		<AccessedThroughProperty("Rightdirflg")>
		Private _Rightdirflg As RadioButton

		' Token: 0x0400006E RID: 110
		<AccessedThroughProperty("Leftdirflg")>
		Private _Leftdirflg As RadioButton

		' Token: 0x0400006F RID: 111
		<AccessedThroughProperty("Finoverwtxt")>
		Private _Finoverwtxt As TextBox

		' Token: 0x04000070 RID: 112
		<AccessedThroughProperty("GroupBox5")>
		Private _GroupBox5 As GroupBox

		' Token: 0x04000071 RID: 113
		<AccessedThroughProperty("FL_200")>
		Private _FL_200 As RadioButton

		' Token: 0x04000072 RID: 114
		<AccessedThroughProperty("FL_400")>
		Private _FL_400 As RadioButton

		' Token: 0x04000073 RID: 115
		<AccessedThroughProperty("CurrPosStat")>
		Private _CurrPosStat As CheckBox

		' Token: 0x04000074 RID: 116
		<AccessedThroughProperty("GroupBox6")>
		Private _GroupBox6 As GroupBox

		' Token: 0x04000075 RID: 117
		<AccessedThroughProperty("Intoverwtxt")>
		Private _Intoverwtxt As TextBox

		' Token: 0x04000076 RID: 118
		<AccessedThroughProperty("Leftangtxt")>
		Private _Leftangtxt As TextBox

		' Token: 0x04000077 RID: 119
		<AccessedThroughProperty("Layernotxt")>
		Private _Layernotxt As TextBox

		' Token: 0x04000078 RID: 120
		<AccessedThroughProperty("Rightangtxt")>
		Private _Rightangtxt As TextBox

		' Token: 0x04000079 RID: 121
		<AccessedThroughProperty("Layerhttxt")>
		Private _Layerhttxt As TextBox

		' Token: 0x0400007A RID: 122
		<AccessedThroughProperty("Rockangtxt")>
		Private _Rockangtxt As TextBox

		' Token: 0x0400007B RID: 123
		<AccessedThroughProperty("Stationslct")>
		Private _Stationslct As ListBox

		' Token: 0x0400007C RID: 124
		<AccessedThroughProperty("GroupBox7")>
		Private _GroupBox7 As GroupBox

		' Token: 0x0400007D RID: 125
		<AccessedThroughProperty("Vlvspind")>
		Private _Vlvspind As RadioButton

		' Token: 0x0400007E RID: 126
		<AccessedThroughProperty("Vlvseat")>
		Private _Vlvseat As RadioButton

		' Token: 0x0400007F RID: 127
		<AccessedThroughProperty("FL_300")>
		Private _FL_300 As RadioButton

		' Token: 0x04000080 RID: 128
		<AccessedThroughProperty("Rockangvartxt")>
		Private _Rockangvartxt As ComboBox
	End Class
End Namespace
