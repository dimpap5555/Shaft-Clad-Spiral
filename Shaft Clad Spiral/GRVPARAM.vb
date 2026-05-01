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
	' Token: 0x0200000F RID: 15
	<DesignerGenerated()>
	Public Partial Class GRVPARAM
		Inherits Form

		' Token: 0x0600022D RID: 557 RVA: 0x0002E180 File Offset: 0x0002C580
		<DebuggerNonUserCode()>
		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.groovecladparam_load
			Me.InitializeComponent()
		End Sub

		' Token: 0x170000CA RID: 202
		' (get) Token: 0x06000230 RID: 560 RVA: 0x00030A44 File Offset: 0x0002EE44
		' (set) Token: 0x06000231 RID: 561 RVA: 0x00030A58 File Offset: 0x0002EE58
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

		' Token: 0x170000CB RID: 203
		' (get) Token: 0x06000232 RID: 562 RVA: 0x00030AA4 File Offset: 0x0002EEA4
		' (set) Token: 0x06000233 RID: 563 RVA: 0x00030AB8 File Offset: 0x0002EEB8
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

		' Token: 0x170000CC RID: 204
		' (get) Token: 0x06000234 RID: 564 RVA: 0x00030B04 File Offset: 0x0002EF04
		' (set) Token: 0x06000235 RID: 565 RVA: 0x00030B18 File Offset: 0x0002EF18
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

		' Token: 0x170000CD RID: 205
		' (get) Token: 0x06000236 RID: 566 RVA: 0x00030B64 File Offset: 0x0002EF64
		' (set) Token: 0x06000237 RID: 567 RVA: 0x00030B78 File Offset: 0x0002EF78
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

		' Token: 0x170000CE RID: 206
		' (get) Token: 0x06000238 RID: 568 RVA: 0x00030BC4 File Offset: 0x0002EFC4
		' (set) Token: 0x06000239 RID: 569 RVA: 0x00030BD8 File Offset: 0x0002EFD8
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

		' Token: 0x170000CF RID: 207
		' (get) Token: 0x0600023A RID: 570 RVA: 0x00030BE4 File Offset: 0x0002EFE4
		' (set) Token: 0x0600023B RID: 571 RVA: 0x00030BF8 File Offset: 0x0002EFF8
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

		' Token: 0x170000D0 RID: 208
		' (get) Token: 0x0600023C RID: 572 RVA: 0x00030C44 File Offset: 0x0002F044
		' (set) Token: 0x0600023D RID: 573 RVA: 0x00030C58 File Offset: 0x0002F058
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

		' Token: 0x170000D1 RID: 209
		' (get) Token: 0x0600023E RID: 574 RVA: 0x00030CA4 File Offset: 0x0002F0A4
		' (set) Token: 0x0600023F RID: 575 RVA: 0x00030CB8 File Offset: 0x0002F0B8
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

		' Token: 0x170000D2 RID: 210
		' (get) Token: 0x06000240 RID: 576 RVA: 0x00030CC4 File Offset: 0x0002F0C4
		' (set) Token: 0x06000241 RID: 577 RVA: 0x00030CD8 File Offset: 0x0002F0D8
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

		' Token: 0x170000D3 RID: 211
		' (get) Token: 0x06000242 RID: 578 RVA: 0x00030D24 File Offset: 0x0002F124
		' (set) Token: 0x06000243 RID: 579 RVA: 0x00030D38 File Offset: 0x0002F138
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

		' Token: 0x170000D4 RID: 212
		' (get) Token: 0x06000244 RID: 580 RVA: 0x00030D84 File Offset: 0x0002F184
		' (set) Token: 0x06000245 RID: 581 RVA: 0x00030D98 File Offset: 0x0002F198
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

		' Token: 0x170000D5 RID: 213
		' (get) Token: 0x06000246 RID: 582 RVA: 0x00030DE4 File Offset: 0x0002F1E4
		' (set) Token: 0x06000247 RID: 583 RVA: 0x00030DF8 File Offset: 0x0002F1F8
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

		' Token: 0x170000D6 RID: 214
		' (get) Token: 0x06000248 RID: 584 RVA: 0x00030E44 File Offset: 0x0002F244
		' (set) Token: 0x06000249 RID: 585 RVA: 0x00030E58 File Offset: 0x0002F258
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

		' Token: 0x170000D7 RID: 215
		' (get) Token: 0x0600024A RID: 586 RVA: 0x00030EA4 File Offset: 0x0002F2A4
		' (set) Token: 0x0600024B RID: 587 RVA: 0x00030EB8 File Offset: 0x0002F2B8
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

		' Token: 0x170000D8 RID: 216
		' (get) Token: 0x0600024C RID: 588 RVA: 0x00030F04 File Offset: 0x0002F304
		' (set) Token: 0x0600024D RID: 589 RVA: 0x00030F18 File Offset: 0x0002F318
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

		' Token: 0x170000D9 RID: 217
		' (get) Token: 0x0600024E RID: 590 RVA: 0x00030F64 File Offset: 0x0002F364
		' (set) Token: 0x0600024F RID: 591 RVA: 0x00030F78 File Offset: 0x0002F378
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

		' Token: 0x170000DA RID: 218
		' (get) Token: 0x06000250 RID: 592 RVA: 0x00030F84 File Offset: 0x0002F384
		' (set) Token: 0x06000251 RID: 593 RVA: 0x00030F98 File Offset: 0x0002F398
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

		' Token: 0x170000DB RID: 219
		' (get) Token: 0x06000252 RID: 594 RVA: 0x00030FE4 File Offset: 0x0002F3E4
		' (set) Token: 0x06000253 RID: 595 RVA: 0x00030FF8 File Offset: 0x0002F3F8
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

		' Token: 0x170000DC RID: 220
		' (get) Token: 0x06000254 RID: 596 RVA: 0x00031044 File Offset: 0x0002F444
		' (set) Token: 0x06000255 RID: 597 RVA: 0x00031058 File Offset: 0x0002F458
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

		' Token: 0x170000DD RID: 221
		' (get) Token: 0x06000256 RID: 598 RVA: 0x000310A4 File Offset: 0x0002F4A4
		' (set) Token: 0x06000257 RID: 599 RVA: 0x000310B8 File Offset: 0x0002F4B8
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

		' Token: 0x170000DE RID: 222
		' (get) Token: 0x06000258 RID: 600 RVA: 0x000310C4 File Offset: 0x0002F4C4
		' (set) Token: 0x06000259 RID: 601 RVA: 0x000310D8 File Offset: 0x0002F4D8
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

		' Token: 0x170000DF RID: 223
		' (get) Token: 0x0600025A RID: 602 RVA: 0x00031124 File Offset: 0x0002F524
		' (set) Token: 0x0600025B RID: 603 RVA: 0x00031138 File Offset: 0x0002F538
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

		' Token: 0x170000E0 RID: 224
		' (get) Token: 0x0600025C RID: 604 RVA: 0x00031184 File Offset: 0x0002F584
		' (set) Token: 0x0600025D RID: 605 RVA: 0x00031198 File Offset: 0x0002F598
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

		' Token: 0x170000E1 RID: 225
		' (get) Token: 0x0600025E RID: 606 RVA: 0x000311E4 File Offset: 0x0002F5E4
		' (set) Token: 0x0600025F RID: 607 RVA: 0x000311F8 File Offset: 0x0002F5F8
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

		' Token: 0x170000E2 RID: 226
		' (get) Token: 0x06000260 RID: 608 RVA: 0x00031244 File Offset: 0x0002F644
		' (set) Token: 0x06000261 RID: 609 RVA: 0x00031258 File Offset: 0x0002F658
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

		' Token: 0x170000E3 RID: 227
		' (get) Token: 0x06000262 RID: 610 RVA: 0x00031264 File Offset: 0x0002F664
		' (set) Token: 0x06000263 RID: 611 RVA: 0x00031278 File Offset: 0x0002F678
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

		' Token: 0x170000E4 RID: 228
		' (get) Token: 0x06000264 RID: 612 RVA: 0x000312C4 File Offset: 0x0002F6C4
		' (set) Token: 0x06000265 RID: 613 RVA: 0x000312D8 File Offset: 0x0002F6D8
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

		' Token: 0x170000E5 RID: 229
		' (get) Token: 0x06000266 RID: 614 RVA: 0x00031324 File Offset: 0x0002F724
		' (set) Token: 0x06000267 RID: 615 RVA: 0x00031338 File Offset: 0x0002F738
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

		' Token: 0x170000E6 RID: 230
		' (get) Token: 0x06000268 RID: 616 RVA: 0x00031384 File Offset: 0x0002F784
		' (set) Token: 0x06000269 RID: 617 RVA: 0x00031398 File Offset: 0x0002F798
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

		' Token: 0x170000E7 RID: 231
		' (get) Token: 0x0600026A RID: 618 RVA: 0x000313A4 File Offset: 0x0002F7A4
		' (set) Token: 0x0600026B RID: 619 RVA: 0x000313B8 File Offset: 0x0002F7B8
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

		' Token: 0x170000E8 RID: 232
		' (get) Token: 0x0600026C RID: 620 RVA: 0x00031404 File Offset: 0x0002F804
		' (set) Token: 0x0600026D RID: 621 RVA: 0x00031418 File Offset: 0x0002F818
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

		' Token: 0x170000E9 RID: 233
		' (get) Token: 0x0600026E RID: 622 RVA: 0x00031464 File Offset: 0x0002F864
		' (set) Token: 0x0600026F RID: 623 RVA: 0x00031478 File Offset: 0x0002F878
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

		' Token: 0x170000EA RID: 234
		' (get) Token: 0x06000270 RID: 624 RVA: 0x000314C4 File Offset: 0x0002F8C4
		' (set) Token: 0x06000271 RID: 625 RVA: 0x000314D8 File Offset: 0x0002F8D8
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

		' Token: 0x170000EB RID: 235
		' (get) Token: 0x06000272 RID: 626 RVA: 0x00031524 File Offset: 0x0002F924
		' (set) Token: 0x06000273 RID: 627 RVA: 0x00031538 File Offset: 0x0002F938
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

		' Token: 0x170000EC RID: 236
		' (get) Token: 0x06000274 RID: 628 RVA: 0x00031584 File Offset: 0x0002F984
		' (set) Token: 0x06000275 RID: 629 RVA: 0x00031598 File Offset: 0x0002F998
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

		' Token: 0x170000ED RID: 237
		' (get) Token: 0x06000276 RID: 630 RVA: 0x000315E4 File Offset: 0x0002F9E4
		' (set) Token: 0x06000277 RID: 631 RVA: 0x000315F8 File Offset: 0x0002F9F8
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

		' Token: 0x170000EE RID: 238
		' (get) Token: 0x06000278 RID: 632 RVA: 0x00031644 File Offset: 0x0002FA44
		' (set) Token: 0x06000279 RID: 633 RVA: 0x00031658 File Offset: 0x0002FA58
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

		' Token: 0x0600027A RID: 634 RVA: 0x000316A4 File Offset: 0x0002FAA4
		Private Sub groovecladparam_load(sender As Object, e As EventArgs)
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
			If Positioncal.MeanderFlg = 1S Then
				Me.MeandrFlg.Checked = True
			Else
				Me.MeandrFlg.Checked = False
			End If
			Me.CurrPosStat.Checked = (Positioncal.CurrPos <> 0S)
			Me.Rockangvartxt.SelectedIndex = CInt(Positioncal.Rockangvar)
		End Sub

		' Token: 0x0600027B RID: 635 RVA: 0x00031944 File Offset: 0x0002FD44
		Private Sub Cnlbtn_Click(sender As Object, e As EventArgs)
			Me.Close()
		End Sub

		' Token: 0x0600027C RID: 636 RVA: 0x0003194C File Offset: 0x0002FD4C
		Private Sub Cnfrmbtn_Click(sender As Object, e As EventArgs)
			Dim fs As FileStream = New FileStream(Application.StartupPath + "\Groovecladparam.txt", FileMode.Create)
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
				w.WriteLine(Positioncal.Rockangvar.ToString())
				w.Close()
				Me.DialogResult = DialogResult.OK
				Me.Close()
			End If
		End Sub

		' Token: 0x0600027D RID: 637 RVA: 0x00031EE4 File Offset: 0x000302E4
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

		' Token: 0x0600027E RID: 638 RVA: 0x00031F78 File Offset: 0x00030378
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

		' Token: 0x0600027F RID: 639 RVA: 0x00032014 File Offset: 0x00030414
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

		' Token: 0x06000280 RID: 640 RVA: 0x000320A0 File Offset: 0x000304A0
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

		' Token: 0x06000281 RID: 641 RVA: 0x00032194 File Offset: 0x00030594
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

		' Token: 0x06000282 RID: 642 RVA: 0x00032220 File Offset: 0x00030620
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

		' Token: 0x06000283 RID: 643 RVA: 0x00032320 File Offset: 0x00030720
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

		' Token: 0x06000284 RID: 644 RVA: 0x00032420 File Offset: 0x00030820
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

		' Token: 0x06000285 RID: 645 RVA: 0x00032518 File Offset: 0x00030918
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

		' Token: 0x06000286 RID: 646 RVA: 0x00032618 File Offset: 0x00030A18
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

		' Token: 0x06000287 RID: 647 RVA: 0x000326A4 File Offset: 0x00030AA4
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

		' Token: 0x06000288 RID: 648 RVA: 0x00032730 File Offset: 0x00030B30
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

		' Token: 0x06000289 RID: 649 RVA: 0x00032848 File Offset: 0x00030C48
		Private Sub CurrPosStat_Click(sender As Object, e As EventArgs)
			Dim form2rect As Rectangle = New Rectangle(50, 100, 694, 440)
			If Me.CurrPosStat.Checked Then
				MyProject.Forms.Posıtıonupload.DesktopBounds = form2rect
				MyProject.Forms.Posıtıonupload.ShowDialog()
				If MyProject.Forms.Posıtıonupload.DialogResult = DialogResult.OK Then
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

		' Token: 0x0600028A RID: 650 RVA: 0x00032A6C File Offset: 0x00030E6C
		Private Sub A1_Click(sender As Object, e As EventArgs)
			If Me.A1.Checked Then
				Positioncal.StationPosition = 1
			End If
		End Sub

		' Token: 0x0600028B RID: 651 RVA: 0x00032A84 File Offset: 0x00030E84
		Private Sub A2_CheckedChanged(sender As Object, e As EventArgs)
			If Me.A2.Checked Then
				Positioncal.StationPosition = 2
			End If
		End Sub

		' Token: 0x0600028C RID: 652 RVA: 0x00032A9C File Offset: 0x00030E9C
		Private Sub A3_CheckedChanged(sender As Object, e As EventArgs)
			If Me.A3.Checked Then
				Positioncal.StationPosition = 3
			End If
		End Sub

		' Token: 0x0600028D RID: 653 RVA: 0x00032AB4 File Offset: 0x00030EB4
		Private Sub Leftdirflg_CheckedChanged(sender As Object, e As EventArgs)
			If Me.Leftdirflg.Checked Then
				Positioncal.CladdingDir = -1
			End If
		End Sub

		' Token: 0x0600028E RID: 654 RVA: 0x00032ACC File Offset: 0x00030ECC
		Private Sub Rightdirflg_CheckedChanged(sender As Object, e As EventArgs)
			If Me.Rightdirflg.Checked Then
				Positioncal.CladdingDir = 1
			End If
		End Sub

		' Token: 0x0600028F RID: 655 RVA: 0x00032AE4 File Offset: 0x00030EE4
		Private Sub FL_400_CheckedChanged(sender As Object, e As EventArgs)
			If Me.FL_400.Checked Then
				Positioncal.Toolno = 0
			End If
		End Sub

		' Token: 0x06000290 RID: 656 RVA: 0x00032AFC File Offset: 0x00030EFC
		Private Sub FL_300_CheckedChanged(sender As Object, e As EventArgs)
			If Me.FL_300.Checked Then
				Positioncal.Toolno = 1
			End If
		End Sub

		' Token: 0x06000291 RID: 657 RVA: 0x00032B14 File Offset: 0x00030F14
		Private Sub FL_200_CheckedChanged(sender As Object, e As EventArgs)
			If Me.FL_200.Checked Then
				Positioncal.Toolno = 2
			End If
		End Sub

		' Token: 0x06000292 RID: 658 RVA: 0x00032B2C File Offset: 0x00030F2C
		Private Sub MeandrFlg_click(sender As Object, e As EventArgs)
			If Me.MeandrFlg.Checked Then
				Positioncal.MeanderFlg = 1S
			Else
				Positioncal.MeanderFlg = 0S
			End If
		End Sub

		' Token: 0x06000293 RID: 659 RVA: 0x00032B4C File Offset: 0x00030F4C
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

		' Token: 0x06000294 RID: 660 RVA: 0x00032C60 File Offset: 0x00031060
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

		' Token: 0x06000295 RID: 661 RVA: 0x00032D74 File Offset: 0x00031174
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

		' Token: 0x06000296 RID: 662 RVA: 0x00032E00 File Offset: 0x00031200
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

		' Token: 0x06000297 RID: 663 RVA: 0x00032E88 File Offset: 0x00031288
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

		' Token: 0x06000298 RID: 664 RVA: 0x00032F64 File Offset: 0x00031364
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

		' Token: 0x06000299 RID: 665 RVA: 0x0003304C File Offset: 0x0003144C
		Private Sub Rockangvartxt_SelectedIndexChanged(sender As Object, e As EventArgs)
			Select Case Me.Rockangvartxt.SelectedIndex
				Case 0
					Positioncal.Rockangvar = 0S
				Case 1
					Positioncal.Rockangvar = 1S
			End Select
		End Sub

		' Token: 0x040000D5 RID: 213
		<AccessedThroughProperty("Diatxt")>
		Private _Diatxt As TextBox

		' Token: 0x040000D6 RID: 214
		<AccessedThroughProperty("Widthtxt")>
		Private _Widthtxt As TextBox

		' Token: 0x040000D7 RID: 215
		<AccessedThroughProperty("Distxt")>
		Private _Distxt As TextBox

		' Token: 0x040000D8 RID: 216
		<AccessedThroughProperty("Pittxt")>
		Private _Pittxt As TextBox

		' Token: 0x040000D9 RID: 217
		<AccessedThroughProperty("GroupBox2")>
		Private _GroupBox2 As GroupBox

		' Token: 0x040000DA RID: 218
		<AccessedThroughProperty("Cnfrmbtn")>
		Private _Cnfrmbtn As Button

		' Token: 0x040000DB RID: 219
		<AccessedThroughProperty("Cnlbtn")>
		Private _Cnlbtn As Button

		' Token: 0x040000DC RID: 220
		<AccessedThroughProperty("GroupBox3")>
		Private _GroupBox3 As GroupBox

		' Token: 0x040000DD RID: 221
		<AccessedThroughProperty("Postatxt")>
		Private _Postatxt As TextBox

		' Token: 0x040000DE RID: 222
		<AccessedThroughProperty("Meandramp")>
		Private _Meandramp As TextBox

		' Token: 0x040000DF RID: 223
		<AccessedThroughProperty("Conatxt")>
		Private _Conatxt As TextBox

		' Token: 0x040000E0 RID: 224
		<AccessedThroughProperty("Inioverwtxt")>
		Private _Inioverwtxt As TextBox

		' Token: 0x040000E1 RID: 225
		<AccessedThroughProperty("MeandrFlg")>
		Private _MeandrFlg As CheckBox

		' Token: 0x040000E2 RID: 226
		<AccessedThroughProperty("Meandrptc")>
		Private _Meandrptc As TextBox

		' Token: 0x040000E3 RID: 227
		<AccessedThroughProperty("Initang")>
		Private _Initang As TextBox

		' Token: 0x040000E4 RID: 228
		<AccessedThroughProperty("GroupBox1")>
		Private _GroupBox1 As GroupBox

		' Token: 0x040000E5 RID: 229
		<AccessedThroughProperty("A2")>
		Private _A2 As RadioButton

		' Token: 0x040000E6 RID: 230
		<AccessedThroughProperty("A1")>
		Private _A1 As RadioButton

		' Token: 0x040000E7 RID: 231
		<AccessedThroughProperty("Tooloffsettxt")>
		Private _Tooloffsettxt As TextBox

		' Token: 0x040000E8 RID: 232
		<AccessedThroughProperty("GroupBox4")>
		Private _GroupBox4 As GroupBox

		' Token: 0x040000E9 RID: 233
		<AccessedThroughProperty("Rightdirflg")>
		Private _Rightdirflg As RadioButton

		' Token: 0x040000EA RID: 234
		<AccessedThroughProperty("Leftdirflg")>
		Private _Leftdirflg As RadioButton

		' Token: 0x040000EB RID: 235
		<AccessedThroughProperty("Finoverwtxt")>
		Private _Finoverwtxt As TextBox

		' Token: 0x040000EC RID: 236
		<AccessedThroughProperty("A3")>
		Private _A3 As RadioButton

		' Token: 0x040000ED RID: 237
		<AccessedThroughProperty("GroupBox5")>
		Private _GroupBox5 As GroupBox

		' Token: 0x040000EE RID: 238
		<AccessedThroughProperty("FL_200")>
		Private _FL_200 As RadioButton

		' Token: 0x040000EF RID: 239
		<AccessedThroughProperty("FL_400")>
		Private _FL_400 As RadioButton

		' Token: 0x040000F0 RID: 240
		<AccessedThroughProperty("CurrPosStat")>
		Private _CurrPosStat As CheckBox

		' Token: 0x040000F1 RID: 241
		<AccessedThroughProperty("GroupBox6")>
		Private _GroupBox6 As GroupBox

		' Token: 0x040000F2 RID: 242
		<AccessedThroughProperty("Intoverwtxt")>
		Private _Intoverwtxt As TextBox

		' Token: 0x040000F3 RID: 243
		<AccessedThroughProperty("Leftangtxt")>
		Private _Leftangtxt As TextBox

		' Token: 0x040000F4 RID: 244
		<AccessedThroughProperty("Layernotxt")>
		Private _Layernotxt As TextBox

		' Token: 0x040000F5 RID: 245
		<AccessedThroughProperty("Rightangtxt")>
		Private _Rightangtxt As TextBox

		' Token: 0x040000F6 RID: 246
		<AccessedThroughProperty("Layerhttxt")>
		Private _Layerhttxt As TextBox

		' Token: 0x040000F7 RID: 247
		<AccessedThroughProperty("Rockangtxt")>
		Private _Rockangtxt As TextBox

		' Token: 0x040000F8 RID: 248
		<AccessedThroughProperty("FL_300")>
		Private _FL_300 As RadioButton

		' Token: 0x040000F9 RID: 249
		<AccessedThroughProperty("Rockangvartxt")>
		Private _Rockangvartxt As ComboBox
	End Class
End Namespace
