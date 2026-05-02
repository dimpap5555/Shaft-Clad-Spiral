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
	' Token: 0x02000011 RID: 17
	<DesignerGenerated()>
	Public Partial Class KEYPARAM
		Inherits Form

		' Token: 0x060002E1 RID: 737 RVA: 0x00034A3C File Offset: 0x00032E3C
		<DebuggerNonUserCode()>
		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.KEYPARAM_Load
			Me.InitializeComponent()
		End Sub

		' Token: 0x17000111 RID: 273
		' (get) Token: 0x060002E4 RID: 740 RVA: 0x00036CE0 File Offset: 0x000350E0
		' (set) Token: 0x060002E5 RID: 741 RVA: 0x00036CF4 File Offset: 0x000350F4
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

		' Token: 0x17000112 RID: 274
		' (get) Token: 0x060002E6 RID: 742 RVA: 0x00036D00 File Offset: 0x00035100
		' (set) Token: 0x060002E7 RID: 743 RVA: 0x00036D14 File Offset: 0x00035114
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

		' Token: 0x17000113 RID: 275
		' (get) Token: 0x060002E8 RID: 744 RVA: 0x00036D60 File Offset: 0x00035160
		' (set) Token: 0x060002E9 RID: 745 RVA: 0x00036D74 File Offset: 0x00035174
		Friend Overridable Property Meandrflg As CheckBox
			<DebuggerNonUserCode()>
			Get
				Return Me._Meandrflg
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As CheckBox)
				Dim value2 As EventHandler = AddressOf Me.Meandrflg_CheckedChanged
				If Me._Meandrflg IsNot Nothing Then
					RemoveHandler Me._Meandrflg.CheckedChanged, value2
				End If
				Me._Meandrflg = value
				If Me._Meandrflg IsNot Nothing Then
					AddHandler Me._Meandrflg.CheckedChanged, value2
				End If
			End Set
		End Property

		' Token: 0x17000114 RID: 276
		' (get) Token: 0x060002EA RID: 746 RVA: 0x00036DC0 File Offset: 0x000351C0
		' (set) Token: 0x060002EB RID: 747 RVA: 0x00036DD4 File Offset: 0x000351D4
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

		' Token: 0x17000115 RID: 277
		' (get) Token: 0x060002EC RID: 748 RVA: 0x00036E20 File Offset: 0x00035220
		' (set) Token: 0x060002ED RID: 749 RVA: 0x00036E34 File Offset: 0x00035234
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

		' Token: 0x17000116 RID: 278
		' (get) Token: 0x060002EE RID: 750 RVA: 0x00036E80 File Offset: 0x00035280
		' (set) Token: 0x060002EF RID: 751 RVA: 0x00036E94 File Offset: 0x00035294
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

		' Token: 0x17000117 RID: 279
		' (get) Token: 0x060002F0 RID: 752 RVA: 0x00036EE0 File Offset: 0x000352E0
		' (set) Token: 0x060002F1 RID: 753 RVA: 0x00036EF4 File Offset: 0x000352F4
		Friend Overridable Property Overwtxt As TextBox
			<DebuggerNonUserCode()>
			Get
				Return Me._Overwtxt
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As EventHandler = AddressOf Me.Overwtxt_Leave
				If Me._Overwtxt IsNot Nothing Then
					RemoveHandler Me._Overwtxt.Leave, value2
				End If
				Me._Overwtxt = value
				If Me._Overwtxt IsNot Nothing Then
					AddHandler Me._Overwtxt.Leave, value2
				End If
			End Set
		End Property

		' Token: 0x17000118 RID: 280
		' (get) Token: 0x060002F2 RID: 754 RVA: 0x00036F40 File Offset: 0x00035340
		' (set) Token: 0x060002F3 RID: 755 RVA: 0x00036F54 File Offset: 0x00035354
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

		' Token: 0x17000119 RID: 281
		' (get) Token: 0x060002F4 RID: 756 RVA: 0x00036FA0 File Offset: 0x000353A0
		' (set) Token: 0x060002F5 RID: 757 RVA: 0x00036FB4 File Offset: 0x000353B4
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

		' Token: 0x1700011A RID: 282
		' (get) Token: 0x060002F6 RID: 758 RVA: 0x00037000 File Offset: 0x00035400
		' (set) Token: 0x060002F7 RID: 759 RVA: 0x00037014 File Offset: 0x00035414
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

		' Token: 0x1700011B RID: 283
		' (get) Token: 0x060002F8 RID: 760 RVA: 0x00037020 File Offset: 0x00035420
		' (set) Token: 0x060002F9 RID: 761 RVA: 0x00037034 File Offset: 0x00035434
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

		' Token: 0x1700011C RID: 284
		' (get) Token: 0x060002FA RID: 762 RVA: 0x00037080 File Offset: 0x00035480
		' (set) Token: 0x060002FB RID: 763 RVA: 0x00037094 File Offset: 0x00035494
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

		' Token: 0x1700011D RID: 285
		' (get) Token: 0x060002FC RID: 764 RVA: 0x000370E0 File Offset: 0x000354E0
		' (set) Token: 0x060002FD RID: 765 RVA: 0x000370F4 File Offset: 0x000354F4
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

		' Token: 0x1700011E RID: 286
		' (get) Token: 0x060002FE RID: 766 RVA: 0x00037140 File Offset: 0x00035540
		' (set) Token: 0x060002FF RID: 767 RVA: 0x00037154 File Offset: 0x00035554
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

		' Token: 0x1700011F RID: 287
		' (get) Token: 0x06000300 RID: 768 RVA: 0x000371A0 File Offset: 0x000355A0
		' (set) Token: 0x06000301 RID: 769 RVA: 0x000371B4 File Offset: 0x000355B4
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

		' Token: 0x17000120 RID: 288
		' (get) Token: 0x06000302 RID: 770 RVA: 0x000371C0 File Offset: 0x000355C0
		' (set) Token: 0x06000303 RID: 771 RVA: 0x000371D4 File Offset: 0x000355D4
		Friend Overridable Property KeyWidthtxt As TextBox
			<DebuggerNonUserCode()>
			Get
				Return Me._KeyWidthtxt
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As EventHandler = AddressOf Me.KeyWidthtxt_leave
				If Me._KeyWidthtxt IsNot Nothing Then
					RemoveHandler Me._KeyWidthtxt.Leave, value2
				End If
				Me._KeyWidthtxt = value
				If Me._KeyWidthtxt IsNot Nothing Then
					AddHandler Me._KeyWidthtxt.Leave, value2
				End If
			End Set
		End Property

		' Token: 0x17000121 RID: 289
		' (get) Token: 0x06000304 RID: 772 RVA: 0x00037220 File Offset: 0x00035620
		' (set) Token: 0x06000305 RID: 773 RVA: 0x00037234 File Offset: 0x00035634
		Friend Overridable Property KeyAngtxt As TextBox
			<DebuggerNonUserCode()>
			Get
				Return Me._KeyAngtxt
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As EventHandler = AddressOf Me.KeyAngtxt_Leave
				If Me._KeyAngtxt IsNot Nothing Then
					RemoveHandler Me._KeyAngtxt.Leave, value2
				End If
				Me._KeyAngtxt = value
				If Me._KeyAngtxt IsNot Nothing Then
					AddHandler Me._KeyAngtxt.Leave, value2
				End If
			End Set
		End Property

		' Token: 0x17000122 RID: 290
		' (get) Token: 0x06000306 RID: 774 RVA: 0x00037280 File Offset: 0x00035680
		' (set) Token: 0x06000307 RID: 775 RVA: 0x00037294 File Offset: 0x00035694
		Friend Overridable Property KeyLengthtxt As TextBox
			<DebuggerNonUserCode()>
			Get
				Return Me._KeyLengthtxt
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As EventHandler = AddressOf Me.KeyLengthtxt_Leave
				If Me._KeyLengthtxt IsNot Nothing Then
					RemoveHandler Me._KeyLengthtxt.Leave, value2
				End If
				Me._KeyLengthtxt = value
				If Me._KeyLengthtxt IsNot Nothing Then
					AddHandler Me._KeyLengthtxt.Leave, value2
				End If
			End Set
		End Property

		' Token: 0x17000123 RID: 291
		' (get) Token: 0x06000308 RID: 776 RVA: 0x000372E0 File Offset: 0x000356E0
		' (set) Token: 0x06000309 RID: 777 RVA: 0x000372F4 File Offset: 0x000356F4
		Friend Overridable Property KeyDisttxt As TextBox
			<DebuggerNonUserCode()>
			Get
				Return Me._KeyDisttxt
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As EventHandler = AddressOf Me.KeyDisttxt_Leave
				If Me._KeyDisttxt IsNot Nothing Then
					RemoveHandler Me._KeyDisttxt.Leave, value2
				End If
				Me._KeyDisttxt = value
				If Me._KeyDisttxt IsNot Nothing Then
					AddHandler Me._KeyDisttxt.Leave, value2
				End If
			End Set
		End Property

		' Token: 0x17000124 RID: 292
		' (get) Token: 0x0600030A RID: 778 RVA: 0x00037340 File Offset: 0x00035740
		' (set) Token: 0x0600030B RID: 779 RVA: 0x00037354 File Offset: 0x00035754
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

		' Token: 0x17000125 RID: 293
		' (get) Token: 0x0600030C RID: 780 RVA: 0x00037360 File Offset: 0x00035760
		' (set) Token: 0x0600030D RID: 781 RVA: 0x00037374 File Offset: 0x00035774
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

		' Token: 0x17000126 RID: 294
		' (get) Token: 0x0600030E RID: 782 RVA: 0x000373C0 File Offset: 0x000357C0
		' (set) Token: 0x0600030F RID: 783 RVA: 0x000373D4 File Offset: 0x000357D4
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

		' Token: 0x17000127 RID: 295
		' (get) Token: 0x06000310 RID: 784 RVA: 0x00037420 File Offset: 0x00035820
		' (set) Token: 0x06000311 RID: 785 RVA: 0x00037434 File Offset: 0x00035834
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

		' Token: 0x17000128 RID: 296
		' (get) Token: 0x06000312 RID: 786 RVA: 0x00037480 File Offset: 0x00035880
		' (set) Token: 0x06000313 RID: 787 RVA: 0x00037494 File Offset: 0x00035894
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

		' Token: 0x17000129 RID: 297
		' (get) Token: 0x06000314 RID: 788 RVA: 0x000374A0 File Offset: 0x000358A0
		' (set) Token: 0x06000315 RID: 789 RVA: 0x000374B4 File Offset: 0x000358B4
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

		' Token: 0x1700012A RID: 298
		' (get) Token: 0x06000316 RID: 790 RVA: 0x00037500 File Offset: 0x00035900
		' (set) Token: 0x06000317 RID: 791 RVA: 0x00037514 File Offset: 0x00035914
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

		' Token: 0x1700012B RID: 299
		' (get) Token: 0x06000318 RID: 792 RVA: 0x00037560 File Offset: 0x00035960
		' (set) Token: 0x06000319 RID: 793 RVA: 0x00037574 File Offset: 0x00035974
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

		' Token: 0x1700012C RID: 300
		' (get) Token: 0x0600031A RID: 794 RVA: 0x000375C0 File Offset: 0x000359C0
		' (set) Token: 0x0600031B RID: 795 RVA: 0x000375D4 File Offset: 0x000359D4
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

		' Token: 0x1700012D RID: 301
		' (get) Token: 0x0600031C RID: 796 RVA: 0x00037620 File Offset: 0x00035A20
		' (set) Token: 0x0600031D RID: 797 RVA: 0x00037634 File Offset: 0x00035A34
		Friend Overridable Property Keynotxt As TextBox
			<DebuggerNonUserCode()>
			Get
				Return Me._Keynotxt
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As EventHandler = AddressOf Me.Keynotxt_leave
				If Me._Keynotxt IsNot Nothing Then
					RemoveHandler Me._Keynotxt.Leave, value2
				End If
				Me._Keynotxt = value
				If Me._Keynotxt IsNot Nothing Then
					AddHandler Me._Keynotxt.Leave, value2
				End If
			End Set
		End Property

		' Token: 0x1700012E RID: 302
		' (get) Token: 0x0600031E RID: 798 RVA: 0x00037680 File Offset: 0x00035A80
		' (set) Token: 0x0600031F RID: 799 RVA: 0x00037694 File Offset: 0x00035A94
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

		' Token: 0x1700012F RID: 303
		' (get) Token: 0x06000320 RID: 800 RVA: 0x000376A0 File Offset: 0x00035AA0
		' (set) Token: 0x06000321 RID: 801 RVA: 0x000376B4 File Offset: 0x00035AB4
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

		' Token: 0x06000322 RID: 802 RVA: 0x00037700 File Offset: 0x00035B00
		Private Sub Cancel_Button_Click(sender As Object, e As EventArgs)
			Me.DialogResult = DialogResult.Cancel
			Me.Close()
		End Sub

		' Token: 0x06000323 RID: 803 RVA: 0x00037710 File Offset: 0x00035B10
		Private Sub Cnfrmbtn_Click(sender As Object, e As EventArgs)
			Dim fs As FileStream = New FileStream(Application.StartupPath + "\Keycladparam.txt", FileMode.Create)
			Dim w As StreamWriter = New StreamWriter(fs)
			Positioncal.Diameter = Conversions.ToDouble(Me.Diatxt.Text) + CDbl((CInt((2S * Positioncal.CurrPos)) * Positioncal.CladdingDir)) * Positioncal.CladWidth / 2.0 * Math.Sin(Positioncal.ConeAngle * 3.141592653589793 / 180.0)
			If Positioncal.CurrPos = 1S Then
				' The following expression was wrapped in a checked-expression
				Positioncal.Distance = Positioncal.Position(1, 0) - Positioncal.KeyDistance - Positioncal.KeyLength - Positioncal.KeyWidth / 2.0 - CDbl((CInt(Positioncal.CurrPos) * Positioncal.CladdingDir)) * Positioncal.CladWidth / 2.0 * Math.Cos(Positioncal.ConeAngle * 3.141592653589793 / 180.0)
			Else
				Positioncal.Distance = Conversions.ToDouble(Me.Distxt.Text)
			End If
			Positioncal.PostureAngle = Conversions.ToDouble(Me.Postatxt.Text)
			Positioncal.KeyAngle = Conversions.ToDouble(Me.KeyAngtxt.Text) - Math.Floor(Conversions.ToDouble(Me.KeyAngtxt.Text) / 360.0) * 360.0
			Dim num As Double = Conversions.ToDouble(Me.Widthtxt.Text)
			If num < Positioncal.CladWidth Then
				' The following expression was wrapped in a checked-expression
				Dim msgbxres As Short = CShort(Interaction.MsgBox("The minimum clad width is " + Positioncal.CladWidth.ToString("#.0") + ". Adjust width accordingly?" & vbCrLf & "(If yes, meander movement will also be disabled)", MsgBoxStyle.YesNo, "Question"))
				If msgbxres <> 6S Then
					Return
				End If
				Positioncal.Width1 = 2.5
				Me.Widthtxt.Text = Positioncal.Width1.ToString("#.00")
				Positioncal.MeanderFlg = 0S
				Me.Meandrflg.CheckState = CheckState.Unchecked
			ElseIf num < 2.0 * Positioncal.MeanderAmp Then
				If Me.Meandrflg.CheckState = CheckState.Checked Then
					' The following expression was wrapped in a checked-expression
					Dim msgbxres As Short = CShort(Interaction.MsgBox("The desired width is smaller than the meander width." & vbCrLf & "Adjust meander amplitude accordingly?", MsgBoxStyle.YesNo, "Question"))
					If msgbxres = 6S Then
						Positioncal.MeanderAmp = Positioncal.Width1 / 2.0
						Me.Meandramp.Text = Positioncal.MeanderAmp.ToString("#.00")
						Interaction.MsgBox("The meander amplitude has been recalculated to " + Conversions.ToString(Positioncal.MeanderAmp) + "mm", MsgBoxStyle.Information, "Information")
					End If
				End If
			ElseIf num < 1.5 * Positioncal.Pitch + 2.0 * Positioncal.MeanderAmp Then
				If Me.Meandrflg.CheckState = CheckState.Checked Then
					' The following expression was wrapped in a checked-expression
					Dim msgbxres As Short = CShort(Interaction.MsgBox("The desired width is only slightly larger to the clad width." & vbCrLf & "Adjust meander amplitude to achieve the desired width in one revolution?", MsgBoxStyle.YesNo, "Question"))
					If msgbxres = 6S Then
						Positioncal.MeanderAmp = Positioncal.Width1 / 2.0
						Me.Meandramp.Text = Positioncal.MeanderAmp.ToString("#.00")
					End If
				End If
			Else
				If num < Positioncal.KeyDistance + Positioncal.KeyWidth / 2.0 + Positioncal.KeyLength Then
					' The following expression was wrapped in a checked-expression
					Dim msgbxres As Short = CShort(Interaction.MsgBox("The clad width is not long enough to accomodate even an open key hole (Width < Key Distance + Key Width/2 + Key Length). Please adjust accordingly", MsgBoxStyle.Exclamation, Nothing))
					w.Close()
					Return
				End If
				If num <= Positioncal.KeyDistance + Positioncal.KeyWidth + Positioncal.KeyLength + Positioncal.CladWidth AndAlso Conversions.ToDouble(Me.Widthtxt.Text) > Positioncal.KeyDistance + Positioncal.KeyWidth / 2.0 + Positioncal.KeyLength Then
					' The following expression was wrapped in a checked-expression
					Dim msgbxres As Short = CShort(Interaction.MsgBox("The clad width is not long enough to accomodate a closed keyhole. Please adjust accordingly (Width >= Keyhole Distance + Keyhole Length + Keyhole Width + Clad Width)", MsgBoxStyle.Exclamation, Nothing))
					w.Close()
					Return
				End If
			End If
			If Positioncal.StationPosition = -1 Then
				Interaction.MsgBox("You have not specified a station angle.", MsgBoxStyle.Exclamation, Nothing)
			Else
				w.WriteLine(Me.Diatxt.Text)
				w.WriteLine(Me.Widthtxt.Text)
				w.WriteLine(Me.Distxt.Text)
				w.WriteLine(Me.Pittxt.Text)
				w.WriteLine(Me.Postatxt.Text)
				w.WriteLine(Me.Conatxt.Text)
				w.WriteLine(Me.Overwtxt.Text)
				w.WriteLine(Me.Meandramp.Text)
				w.WriteLine(Me.Meandrptc.Text)
				w.WriteLine(CInt(Me.Meandrflg.CheckState))
				w.WriteLine(Me.Keynotxt.Text)
				w.WriteLine(Me.KeyDisttxt.Text)
				w.WriteLine(Me.KeyWidthtxt.Text)
				w.WriteLine(Me.KeyLengthtxt.Text)
				w.WriteLine(Me.KeyAngtxt.Text)
				w.WriteLine(Positioncal.StationPosition.ToString())
				w.WriteLine(Positioncal.CurrPos.ToString())
				w.Close()
				Me.DialogResult = DialogResult.OK
				Me.Close()
			End If
		End Sub

		' Token: 0x06000324 RID: 804 RVA: 0x00037BEC File Offset: 0x00035FEC
		Private Sub Cnlbtn_Click(sender As Object, e As EventArgs)
			Me.DialogResult = DialogResult.Cancel
			Me.Close()
		End Sub

		' Token: 0x06000325 RID: 805 RVA: 0x00037BFC File Offset: 0x00035FFC
		Private Sub A1_Click(sender As Object, e As EventArgs)
			If Me.A1.Checked Then
				Positioncal.StationPosition = 1
			End If
		End Sub

		' Token: 0x06000326 RID: 806 RVA: 0x00037C14 File Offset: 0x00036014
		Private Sub A2_CheckedChanged(sender As Object, e As EventArgs)
			If Me.A2.Checked Then
				Positioncal.StationPosition = 2
			End If
		End Sub

		' Token: 0x06000327 RID: 807 RVA: 0x00037C2C File Offset: 0x0003602C
		Private Sub A3_CheckedChanged(sender As Object, e As EventArgs)
			If Me.A3.Checked Then
				Positioncal.StationPosition = 3
			End If
		End Sub

		' Token: 0x06000328 RID: 808 RVA: 0x00037C44 File Offset: 0x00036044
		Private Sub WD_20_CheckedChanged(sender As Object, e As EventArgs)
			If Me.WD_20.Checked Then
				Positioncal.Toolno = 0
			End If
		End Sub

		' Token: 0x06000329 RID: 809 RVA: 0x00037C5C File Offset: 0x0003605C
		Private Sub WD_13_CheckedChanged(sender As Object, e As EventArgs)
			If Me.WD_13.Checked Then
				Positioncal.Toolno = 1
			End If
		End Sub

		' Token: 0x0600032A RID: 810 RVA: 0x00037C74 File Offset: 0x00036074
		Private Sub CurrPosStat_Click(sender As Object, e As EventArgs)
			Dim form2rect As Rectangle = New Rectangle(50, 100, 694, 440)
			If Me.CurrPosStat.Checked Then
				Global.WindowsApplication1.My.MyProject.Forms.Posıtıonupload.DesktopBounds = form2rect
				Global.WindowsApplication1.My.MyProject.Forms.Posıtıonupload.ShowDialog()
				If Global.WindowsApplication1.My.MyProject.Forms.Posıtıonupload.DialogResult = DialogResult.OK Then
					Positioncal.CurrPos = 1S
					Me.Tooloffsettxt.Enabled = False
					Positioncal.WorkXAxisOffset = Positioncal.Position(0, 0)
					Positioncal.WorkYAxisTilt = Positioncal.Position(4, 0)
					Me.Diatxt.Text = (Math.Abs(Positioncal.Position(2, 0)) * 2.0).ToString("#0.00")
					Me.Distxt.Text = (Positioncal.Position(1, 0) - Positioncal.KeyDistance - Positioncal.KeyLength - Positioncal.KeyWidth / 2.0).ToString("#0.00")
					Me.KeyAngtxt.Text = Positioncal.Position(7, 0).ToString("#0.00")
					Me.Tooloffsettxt.Text = Conversions.ToString(0)
					If Positioncal.Position(3, 0) > 0.0 Then
						Me.Postatxt.Text = (Positioncal.Position(3, 0) - 90.0).ToString("#0.00")
					Else
						Me.Postatxt.Text = (Positioncal.Position(3, 0) + 180.0 + 90.0).ToString("#0.00")
					End If
					Me.Diatxt_Leave(Me, e)
					Me.Distxt_Leave(Me, e)
					Me.Postatxt_Leave(Me, e)
				Else
					Me.CurrPosStat.Checked = False
					Positioncal.CurrPos = 0S
				End If
			Else
				Me.Diatxt.Text = Positioncal.Diameter.ToString("#0.00")
				Me.Distxt.Text = Positioncal.Distance.ToString("#0.00")
				Me.Diatxt.Enabled = True
				Me.Distxt.Enabled = True
				Me.Tooloffsettxt.Enabled = True
				Me.Postatxt.Enabled = True
				Positioncal.CurrPos = 0S
			End If
		End Sub

		' Token: 0x0600032B RID: 811 RVA: 0x00037ECC File Offset: 0x000362CC
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

		' Token: 0x0600032C RID: 812 RVA: 0x00037F68 File Offset: 0x00036368
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

		' Token: 0x0600032D RID: 813 RVA: 0x00037FF4 File Offset: 0x000363F4
		Private Sub Distxt_Leave(sender As Object, e As EventArgs)
			If Versioned.IsNumeric(Me.Distxt.Text) Then
				If Conversions.ToDouble(Me.Distxt.Text) >= Positioncal.MinDistance Then
					Dim value As Double = Conversions.ToDouble(Me.Distxt.Text)
					Me.Distxt.Text = value.ToString("#0.0")
					Positioncal.Distance = value
				Else
					Interaction.MsgBox("The minimum distance from the Chuck has been specified to " + Positioncal.MinDistance.ToString("#0.00"), MsgBoxStyle.Exclamation, Nothing)
					Me.Distxt.Text = 500.ToString("#0.0")
					Positioncal.Distance = 500.0
				End If
			Else
				Interaction.MsgBox("This is not a valid value", MsgBoxStyle.Exclamation, Nothing)
				Me.Distxt.Text = 500.ToString("#0.0")
				Positioncal.Distance = 500.0
			End If
		End Sub

		' Token: 0x0600032E RID: 814 RVA: 0x000380E8 File Offset: 0x000364E8
		Private Sub Pittxt_Leave(sender As Object, e As EventArgs)
			If Char.IsNumber(Conversions.ToChar(Me.Pittxt.Text)) Then
				Dim value As Double = Conversions.ToDouble(Me.Pittxt.Text)
				Me.Pittxt.Text = value.ToString("#0.0")
				Positioncal.Pitch = value
			Else
				Interaction.MsgBox("This is not a valid value (Pitch > 0 mm)", MsgBoxStyle.Exclamation, Nothing)
				Me.Pittxt.Text = 4.ToString("#0.0")
				Positioncal.Pitch = 4.0
			End If
		End Sub

		' Token: 0x0600032F RID: 815 RVA: 0x00038174 File Offset: 0x00036574
		Private Sub Postatxt_Leave(sender As Object, e As EventArgs)
			If Versioned.IsNumeric(Me.Postatxt.Text) Then
				If Conversions.ToDouble(Me.Postatxt.Text) >= -145.0 And Conversions.ToDouble(Me.Postatxt.Text) <= 145.0 Then
					Dim value As Double = Conversions.ToDouble(Me.Postatxt.Text)
					Me.Postatxt.Text = value.ToString("#0.00")
					Positioncal.PostureAngle = value
				Else
					Interaction.MsgBox("The posture angle should be within -145 and 145 degrees to the axis", MsgBoxStyle.Exclamation, Nothing)
					Me.Postatxt.Text = 90.ToString("#0.00")
					Positioncal.PostureAngle = 90.0
				End If
			Else
				Interaction.MsgBox("This is not a valid value", MsgBoxStyle.Exclamation, Nothing)
				Me.Postatxt.Text = 90.ToString("#0.00")
				Positioncal.PostureAngle = 90.0
			End If
		End Sub

		' Token: 0x06000330 RID: 816 RVA: 0x00038274 File Offset: 0x00036674
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

		' Token: 0x06000331 RID: 817 RVA: 0x00038374 File Offset: 0x00036774
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

		' Token: 0x06000332 RID: 818 RVA: 0x00038408 File Offset: 0x00036808
		Private Sub Overwtxt_Leave(sender As Object, e As EventArgs)
			If Versioned.IsNumeric(Me.Overwtxt.Text) Then
				Dim value As Double = Conversions.ToDouble(Me.Overwtxt.Text)
				Me.Overwtxt.Text = value.ToString("#0.0")
				Positioncal.IniOverWeld = Conversions.ToSingle(Me.Overwtxt.Text)
			Else
				Interaction.MsgBox("This is not a valid value", MsgBoxStyle.Exclamation, Nothing)
				Me.Overwtxt.Text = 0.ToString("#0.0")
				Positioncal.IniOverWeld = 0F
			End If
		End Sub

		' Token: 0x06000333 RID: 819 RVA: 0x00038498 File Offset: 0x00036898
		Private Sub Meandramp_Leave(sender As Object, e As EventArgs)
			If Char.IsNumber(Conversions.ToChar(Me.Meandramp.Text)) Then
				Dim value As Double = Conversions.ToDouble(Me.Meandramp.Text)
				Me.Meandramp.Text = value.ToString("#0.0")
				Positioncal.MeanderAmp = value
			Else
				Interaction.MsgBox("This is not a valid value (Meander Amplitude > 0 mm)", MsgBoxStyle.Exclamation, Nothing)
				Me.Meandramp.Text = 2.ToString("#0.0")
				Positioncal.MeanderAmp = 2.0
			End If
		End Sub

		' Token: 0x06000334 RID: 820 RVA: 0x00038524 File Offset: 0x00036924
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

		' Token: 0x06000335 RID: 821 RVA: 0x000385B0 File Offset: 0x000369B0
		Private Sub Keynotxt_leave(sender As Object, e As EventArgs)
			If Char.IsNumber(Conversions.ToChar(Me.Keynotxt.Text)) Then
				Dim value As Double = CDbl(Conversions.ToInteger(Me.Keynotxt.Text))
				Me.Keynotxt.Text = value.ToString("#0")
				Positioncal.Keyno = CInt(Math.Round(value))
			Else
				Interaction.MsgBox("This is not a valid value (Key number > 0)", MsgBoxStyle.Exclamation, Nothing)
				Me.Keynotxt.Text = 1.ToString("#0")
				Positioncal.Keyno = 1
			End If
		End Sub

		' Token: 0x06000336 RID: 822 RVA: 0x00038638 File Offset: 0x00036A38
		Private Sub KeyWidthtxt_leave(sender As Object, e As EventArgs)
			If Char.IsNumber(Conversions.ToChar(Me.KeyWidthtxt.Text)) Then
				Dim value As Double = Conversions.ToDouble(Me.KeyWidthtxt.Text)
				Me.KeyWidthtxt.Text = value.ToString("#0.0")
				Positioncal.KeyWidth = value
			Else
				Interaction.MsgBox("This is not a valid value (Key width > 0 mm)", MsgBoxStyle.Exclamation, Nothing)
				Me.KeyWidthtxt.Text = 10.ToString("#0.0")
				Positioncal.KeyWidth = 10.0
			End If
		End Sub

		' Token: 0x06000337 RID: 823 RVA: 0x000386C4 File Offset: 0x00036AC4
		Private Sub KeyLengthtxt_Leave(sender As Object, e As EventArgs)
			If Char.IsNumber(Conversions.ToChar(Me.KeyLengthtxt.Text)) Then
				Dim value As Double = Conversions.ToDouble(Me.KeyLengthtxt.Text)
				Me.KeyLengthtxt.Text = value.ToString("#0.0")
				Positioncal.KeyLength = value
			Else
				Interaction.MsgBox("This is not a valid value (Key length > 0 mm)", MsgBoxStyle.Exclamation, Nothing)
				Me.KeyLengthtxt.Text = 30.ToString("#0.0")
				Positioncal.KeyLength = 30.0
			End If
		End Sub

		' Token: 0x06000338 RID: 824 RVA: 0x00038750 File Offset: 0x00036B50
		Private Sub KeyDisttxt_Leave(sender As Object, e As EventArgs)
			If Char.IsNumber(Conversions.ToChar(Me.KeyDisttxt.Text)) Then
				Dim value As Double = Conversions.ToDouble(Me.KeyDisttxt.Text)
				Me.KeyDisttxt.Text = value.ToString("#0.0")
				Positioncal.KeyDistance = value
			Else
				Interaction.MsgBox("This is not a valid value (Key distance > 0 mm)", MsgBoxStyle.Exclamation, Nothing)
				Me.KeyDisttxt.Text = 15.ToString("#0.0")
				Positioncal.KeyDistance = 15.0
			End If
		End Sub

		' Token: 0x06000339 RID: 825 RVA: 0x000387DC File Offset: 0x00036BDC
		Private Sub KeyAngtxt_Leave(sender As Object, e As EventArgs)
			If Char.IsNumber(Conversions.ToChar(Me.KeyAngtxt.Text)) Then
				Dim value As Double = Conversions.ToDouble(Me.KeyAngtxt.Text)
				Me.KeyAngtxt.Text = value.ToString("#0.0")
				Positioncal.KeyAngle = value
			Else
				Interaction.MsgBox("This is not a valid value (Key angle > 0 mm)", MsgBoxStyle.Exclamation, Nothing)
				Me.KeyAngtxt.Text = 0.ToString("#0.0")
				Positioncal.KeyAngle = 0.0
			End If
		End Sub

		' Token: 0x0600033A RID: 826 RVA: 0x00038868 File Offset: 0x00036C68
		Private Sub Meandrflg_CheckedChanged(sender As Object, e As EventArgs)
			If Me.Meandrflg.Checked Then
				' The following expression was wrapped in a checked-expression
				Positioncal.MeanderFlg = CShort(Me.Meandrflg.CheckState)
			End If
		End Sub

		' Token: 0x0600033B RID: 827 RVA: 0x00038888 File Offset: 0x00036C88
		Private Sub KEYPARAM_Load(sender As Object, e As EventArgs)
			Me.Diatxt.Text = Positioncal.Diameter.ToString("#0.0")
			Me.Widthtxt.Text = Positioncal.Width1.ToString("#0.0")
			Me.Distxt.Text = Positioncal.Distance.ToString("#0.00")
			Me.Pittxt.Text = Positioncal.Pitch.ToString("#0.00")
			Me.Postatxt.Text = Positioncal.PostureAngle.ToString("#0.00")
			Me.Conatxt.Text = Positioncal.ConeAngle.ToString("#0.00")
			Me.Overwtxt.Text = Positioncal.IniOverWeld.ToString("#0.0")
			Me.Meandramp.Text = Positioncal.MeanderAmp.ToString("#0.0")
			Me.Meandrptc.Text = Positioncal.MeanderPitch.ToString("#0.0")
			Me.Meandrflg.Checked = (Positioncal.MeanderFlg <> 0S)
			Me.Keynotxt.Text = Positioncal.Keyno.ToString("#0")
			Me.KeyDisttxt.Text = Positioncal.KeyDistance.ToString("#0.0")
			Me.KeyWidthtxt.Text = Positioncal.KeyWidth.ToString("#0.0")
			Me.KeyLengthtxt.Text = Positioncal.KeyLength.ToString("#0.0")
			Me.KeyAngtxt.Text = Positioncal.KeyAngle.ToString("#0.0")
			Me.Stationslct.SelectedIndex = Positioncal.StationPosition - 1
			Me.CurrPosStat.Checked = (Positioncal.CurrPos <> 0S)
		End Sub

		' Token: 0x0600033C RID: 828 RVA: 0x00038A3C File Offset: 0x00036E3C
		Private Sub Stationslct_SelectedIndexChanged(sender As Object, e As EventArgs)
			' The following expression was wrapped in a checked-expression
			Positioncal.StationPosition = Me.Stationslct.SelectedIndex + 1
		End Sub

		' Token: 0x0400011E RID: 286
		<AccessedThroughProperty("GroupBox3")>
		Private _GroupBox3 As GroupBox

		' Token: 0x0400011F RID: 287
		<AccessedThroughProperty("Meandrptc")>
		Private _Meandrptc As TextBox

		' Token: 0x04000120 RID: 288
		<AccessedThroughProperty("Meandrflg")>
		Private _Meandrflg As CheckBox

		' Token: 0x04000121 RID: 289
		<AccessedThroughProperty("Postatxt")>
		Private _Postatxt As TextBox

		' Token: 0x04000122 RID: 290
		<AccessedThroughProperty("Meandramp")>
		Private _Meandramp As TextBox

		' Token: 0x04000123 RID: 291
		<AccessedThroughProperty("Conatxt")>
		Private _Conatxt As TextBox

		' Token: 0x04000124 RID: 292
		<AccessedThroughProperty("Overwtxt")>
		Private _Overwtxt As TextBox

		' Token: 0x04000125 RID: 293
		<AccessedThroughProperty("Cnlbtn")>
		Private _Cnlbtn As Button

		' Token: 0x04000126 RID: 294
		<AccessedThroughProperty("Cnfrmbtn")>
		Private _Cnfrmbtn As Button

		' Token: 0x04000127 RID: 295
		<AccessedThroughProperty("GroupBox2")>
		Private _GroupBox2 As GroupBox

		' Token: 0x04000128 RID: 296
		<AccessedThroughProperty("Diatxt")>
		Private _Diatxt As TextBox

		' Token: 0x04000129 RID: 297
		<AccessedThroughProperty("Pittxt")>
		Private _Pittxt As TextBox

		' Token: 0x0400012A RID: 298
		<AccessedThroughProperty("Widthtxt")>
		Private _Widthtxt As TextBox

		' Token: 0x0400012B RID: 299
		<AccessedThroughProperty("Distxt")>
		Private _Distxt As TextBox

		' Token: 0x0400012C RID: 300
		<AccessedThroughProperty("GroupBox1")>
		Private _GroupBox1 As GroupBox

		' Token: 0x0400012D RID: 301
		<AccessedThroughProperty("KeyWidthtxt")>
		Private _KeyWidthtxt As TextBox

		' Token: 0x0400012E RID: 302
		<AccessedThroughProperty("KeyAngtxt")>
		Private _KeyAngtxt As TextBox

		' Token: 0x0400012F RID: 303
		<AccessedThroughProperty("KeyLengthtxt")>
		Private _KeyLengthtxt As TextBox

		' Token: 0x04000130 RID: 304
		<AccessedThroughProperty("KeyDisttxt")>
		Private _KeyDisttxt As TextBox

		' Token: 0x04000131 RID: 305
		<AccessedThroughProperty("GroupBox4")>
		Private _GroupBox4 As GroupBox

		' Token: 0x04000132 RID: 306
		<AccessedThroughProperty("A2")>
		Private _A2 As RadioButton

		' Token: 0x04000133 RID: 307
		<AccessedThroughProperty("A1")>
		Private _A1 As RadioButton

		' Token: 0x04000134 RID: 308
		<AccessedThroughProperty("Tooloffsettxt")>
		Private _Tooloffsettxt As TextBox

		' Token: 0x04000135 RID: 309
		<AccessedThroughProperty("GroupBox5")>
		Private _GroupBox5 As GroupBox

		' Token: 0x04000136 RID: 310
		<AccessedThroughProperty("WD_13")>
		Private _WD_13 As RadioButton

		' Token: 0x04000137 RID: 311
		<AccessedThroughProperty("WD_20")>
		Private _WD_20 As RadioButton

		' Token: 0x04000138 RID: 312
		<AccessedThroughProperty("A3")>
		Private _A3 As RadioButton

		' Token: 0x04000139 RID: 313
		<AccessedThroughProperty("CurrPosStat")>
		Private _CurrPosStat As CheckBox

		' Token: 0x0400013A RID: 314
		<AccessedThroughProperty("Keynotxt")>
		Private _Keynotxt As TextBox

		' Token: 0x0400013B RID: 315
		<AccessedThroughProperty("GroupBox6")>
		Private _GroupBox6 As GroupBox

		' Token: 0x0400013C RID: 316
		<AccessedThroughProperty("Stationslct")>
		Private _Stationslct As ListBox
	End Class
End Namespace
