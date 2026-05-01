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
	' Token: 0x0200000D RID: 13
	<DesignerGenerated()>
	Public Partial Class CRPARAM
		Inherits Form

		' Token: 0x06000171 RID: 369 RVA: 0x0002462C File Offset: 0x00022A2C
		<DebuggerNonUserCode()>
		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.CRPARAM_Load
			Me.InitializeComponent()
		End Sub

		' Token: 0x17000084 RID: 132
		' (get) Token: 0x06000174 RID: 372 RVA: 0x0002654C File Offset: 0x0002494C
		' (set) Token: 0x06000175 RID: 373 RVA: 0x00026560 File Offset: 0x00024960
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

		' Token: 0x17000085 RID: 133
		' (get) Token: 0x06000176 RID: 374 RVA: 0x000265AC File Offset: 0x000249AC
		' (set) Token: 0x06000177 RID: 375 RVA: 0x000265C0 File Offset: 0x000249C0
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

		' Token: 0x17000086 RID: 134
		' (get) Token: 0x06000178 RID: 376 RVA: 0x0002660C File Offset: 0x00024A0C
		' (set) Token: 0x06000179 RID: 377 RVA: 0x00026620 File Offset: 0x00024A20
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

		' Token: 0x17000087 RID: 135
		' (get) Token: 0x0600017A RID: 378 RVA: 0x0002666C File Offset: 0x00024A6C
		' (set) Token: 0x0600017B RID: 379 RVA: 0x00026680 File Offset: 0x00024A80
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

		' Token: 0x17000088 RID: 136
		' (get) Token: 0x0600017C RID: 380 RVA: 0x000266CC File Offset: 0x00024ACC
		' (set) Token: 0x0600017D RID: 381 RVA: 0x000266E0 File Offset: 0x00024AE0
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

		' Token: 0x17000089 RID: 137
		' (get) Token: 0x0600017E RID: 382 RVA: 0x000266EC File Offset: 0x00024AEC
		' (set) Token: 0x0600017F RID: 383 RVA: 0x00026700 File Offset: 0x00024B00
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

		' Token: 0x1700008A RID: 138
		' (get) Token: 0x06000180 RID: 384 RVA: 0x0002674C File Offset: 0x00024B4C
		' (set) Token: 0x06000181 RID: 385 RVA: 0x00026760 File Offset: 0x00024B60
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

		' Token: 0x1700008B RID: 139
		' (get) Token: 0x06000182 RID: 386 RVA: 0x000267AC File Offset: 0x00024BAC
		' (set) Token: 0x06000183 RID: 387 RVA: 0x000267C0 File Offset: 0x00024BC0
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

		' Token: 0x1700008C RID: 140
		' (get) Token: 0x06000184 RID: 388 RVA: 0x000267CC File Offset: 0x00024BCC
		' (set) Token: 0x06000185 RID: 389 RVA: 0x000267E0 File Offset: 0x00024BE0
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

		' Token: 0x1700008D RID: 141
		' (get) Token: 0x06000186 RID: 390 RVA: 0x0002682C File Offset: 0x00024C2C
		' (set) Token: 0x06000187 RID: 391 RVA: 0x00026840 File Offset: 0x00024C40
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

		' Token: 0x1700008E RID: 142
		' (get) Token: 0x06000188 RID: 392 RVA: 0x0002688C File Offset: 0x00024C8C
		' (set) Token: 0x06000189 RID: 393 RVA: 0x000268A0 File Offset: 0x00024CA0
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

		' Token: 0x1700008F RID: 143
		' (get) Token: 0x0600018A RID: 394 RVA: 0x000268EC File Offset: 0x00024CEC
		' (set) Token: 0x0600018B RID: 395 RVA: 0x00026900 File Offset: 0x00024D00
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

		' Token: 0x17000090 RID: 144
		' (get) Token: 0x0600018C RID: 396 RVA: 0x0002694C File Offset: 0x00024D4C
		' (set) Token: 0x0600018D RID: 397 RVA: 0x00026960 File Offset: 0x00024D60
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

		' Token: 0x17000091 RID: 145
		' (get) Token: 0x0600018E RID: 398 RVA: 0x000269AC File Offset: 0x00024DAC
		' (set) Token: 0x0600018F RID: 399 RVA: 0x000269C0 File Offset: 0x00024DC0
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

		' Token: 0x17000092 RID: 146
		' (get) Token: 0x06000190 RID: 400 RVA: 0x00026A0C File Offset: 0x00024E0C
		' (set) Token: 0x06000191 RID: 401 RVA: 0x00026A20 File Offset: 0x00024E20
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

		' Token: 0x17000093 RID: 147
		' (get) Token: 0x06000192 RID: 402 RVA: 0x00026A6C File Offset: 0x00024E6C
		' (set) Token: 0x06000193 RID: 403 RVA: 0x00026A80 File Offset: 0x00024E80
		Friend Overridable Property Crnkthrtxt As TextBox
			<DebuggerNonUserCode()>
			Get
				Return Me._Crnkthrtxt
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As EventHandler = AddressOf Me.Crnkthrtxt_Leave
				If Me._Crnkthrtxt IsNot Nothing Then
					RemoveHandler Me._Crnkthrtxt.Leave, value2
				End If
				Me._Crnkthrtxt = value
				If Me._Crnkthrtxt IsNot Nothing Then
					AddHandler Me._Crnkthrtxt.Leave, value2
				End If
			End Set
		End Property

		' Token: 0x17000094 RID: 148
		' (get) Token: 0x06000194 RID: 404 RVA: 0x00026ACC File Offset: 0x00024ECC
		' (set) Token: 0x06000195 RID: 405 RVA: 0x00026AE0 File Offset: 0x00024EE0
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

		' Token: 0x17000095 RID: 149
		' (get) Token: 0x06000196 RID: 406 RVA: 0x00026AEC File Offset: 0x00024EEC
		' (set) Token: 0x06000197 RID: 407 RVA: 0x00026B00 File Offset: 0x00024F00
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

		' Token: 0x17000096 RID: 150
		' (get) Token: 0x06000198 RID: 408 RVA: 0x00026B4C File Offset: 0x00024F4C
		' (set) Token: 0x06000199 RID: 409 RVA: 0x00026B60 File Offset: 0x00024F60
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

		' Token: 0x17000097 RID: 151
		' (get) Token: 0x0600019A RID: 410 RVA: 0x00026BAC File Offset: 0x00024FAC
		' (set) Token: 0x0600019B RID: 411 RVA: 0x00026BC0 File Offset: 0x00024FC0
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

		' Token: 0x17000098 RID: 152
		' (get) Token: 0x0600019C RID: 412 RVA: 0x00026BCC File Offset: 0x00024FCC
		' (set) Token: 0x0600019D RID: 413 RVA: 0x00026BE0 File Offset: 0x00024FE0
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

		' Token: 0x17000099 RID: 153
		' (get) Token: 0x0600019E RID: 414 RVA: 0x00026C2C File Offset: 0x0002502C
		' (set) Token: 0x0600019F RID: 415 RVA: 0x00026C40 File Offset: 0x00025040
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

		' Token: 0x1700009A RID: 154
		' (get) Token: 0x060001A0 RID: 416 RVA: 0x00026C8C File Offset: 0x0002508C
		' (set) Token: 0x060001A1 RID: 417 RVA: 0x00026CA0 File Offset: 0x000250A0
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

		' Token: 0x1700009B RID: 155
		' (get) Token: 0x060001A2 RID: 418 RVA: 0x00026CEC File Offset: 0x000250EC
		' (set) Token: 0x060001A3 RID: 419 RVA: 0x00026D00 File Offset: 0x00025100
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

		' Token: 0x1700009C RID: 156
		' (get) Token: 0x060001A4 RID: 420 RVA: 0x00026D4C File Offset: 0x0002514C
		' (set) Token: 0x060001A5 RID: 421 RVA: 0x00026D60 File Offset: 0x00025160
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

		' Token: 0x1700009D RID: 157
		' (get) Token: 0x060001A6 RID: 422 RVA: 0x00026DAC File Offset: 0x000251AC
		' (set) Token: 0x060001A7 RID: 423 RVA: 0x00026DC0 File Offset: 0x000251C0
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

		' Token: 0x1700009E RID: 158
		' (get) Token: 0x060001A8 RID: 424 RVA: 0x00026DCC File Offset: 0x000251CC
		' (set) Token: 0x060001A9 RID: 425 RVA: 0x00026DE0 File Offset: 0x000251E0
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

		' Token: 0x1700009F RID: 159
		' (get) Token: 0x060001AA RID: 426 RVA: 0x00026E2C File Offset: 0x0002522C
		' (set) Token: 0x060001AB RID: 427 RVA: 0x00026E40 File Offset: 0x00025240
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

		' Token: 0x170000A0 RID: 160
		' (get) Token: 0x060001AC RID: 428 RVA: 0x00026E8C File Offset: 0x0002528C
		' (set) Token: 0x060001AD RID: 429 RVA: 0x00026EA0 File Offset: 0x000252A0
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

		' Token: 0x060001AE RID: 430 RVA: 0x00026EEC File Offset: 0x000252EC
		Private Sub Cnlbtn_Click(sender As Object, e As EventArgs)
			Me.Close()
		End Sub

		' Token: 0x060001AF RID: 431 RVA: 0x00026EF4 File Offset: 0x000252F4
		Private Sub Cnfrmbtn_Click(sender As Object, e As EventArgs)
			Dim fs As FileStream = New FileStream(Application.StartupPath + "\Crcladparam.txt", FileMode.Create)
			Dim w As StreamWriter = New StreamWriter(fs)
			Positioncal.Diameter = Conversions.ToDouble(Me.Diatxt.Text) + CDbl((CInt((2S * Positioncal.CurrPos)) * Positioncal.CladdingDir)) * Positioncal.CladWidth / 2.0 * Math.Sin(Positioncal.ConeAngle * 3.141592653589793 / 180.0)
			Positioncal.Distance = Conversions.ToDouble(Me.Distxt.Text) - CDbl((CInt(Positioncal.CurrPos) * Positioncal.CladdingDir)) * Positioncal.CladWidth / 2.0 * Math.Cos(Positioncal.ConeAngle * 3.141592653589793 / 180.0)
			Positioncal.PostureAngle = Conversions.ToDouble(Me.Postatxt.Text)
			Positioncal.InitialAng = Conversions.ToDouble(Me.Initang.Text) - Math.Floor(Conversions.ToDouble(Me.Initang.Text) / 360.0) * 360.0
			Dim num As Integer = Conversions.ToInteger(Me.Widthtxt.Text)
			If num < CInt(Math.Round(Positioncal.CladWidth)) Then
				Dim msgbxres As Short = CShort(Interaction.MsgBox("The minimum clad width is " + Positioncal.CladWidth.ToString("#.0") + ". Adjust width accordingly?" & vbCrLf & "(If yes, meander movement will also be disabled)", MsgBoxStyle.YesNo, "Question"))
				If msgbxres = 6S Then
					Positioncal.Width1 = 2.5
					Me.Widthtxt.Text = Positioncal.Width1.ToString("#.00")
					Positioncal.MeanderFlg = 0S
					Me.Meandrflg.CheckState = CheckState.Unchecked
				End If
			ElseIf num < CInt(Math.Round(2.0 * Positioncal.MeanderAmp)) Then
				If Me.Meandrflg.CheckState = CheckState.Checked Then
					Dim msgbxres As Short = CShort(Interaction.MsgBox("The desired width is smaller than the meander width." & vbCrLf & "Adjust meander amplitude accordingly?", MsgBoxStyle.YesNo, "Question"))
					If msgbxres = 6S Then
						Positioncal.MeanderAmp = Positioncal.Width1 / 2.0
						Me.Meandramp.Text = Positioncal.MeanderAmp.ToString("#.0")
						Interaction.MsgBox("The meander amplitude has been recalculated to " + Conversions.ToString(Positioncal.MeanderAmp) + "mm", MsgBoxStyle.Information, "Information")
					End If
				End If
			ElseIf num < CInt(Math.Round(1.5 * Positioncal.Pitch + 2.0 * Positioncal.MeanderAmp)) AndAlso Me.Meandrflg.CheckState = CheckState.Checked Then
				Dim msgbxres As Short = CShort(Interaction.MsgBox("The desired width is only slightly larger to the clad width." & vbCrLf & "Adjust meander amplitude to achieve the desired width in one revolution?", MsgBoxStyle.YesNo, "Question"))
				If msgbxres = 6S Then
					Positioncal.MeanderAmp = Positioncal.Width1 / 2.0
					Me.Meandramp.Text = Positioncal.MeanderAmp.ToString("#.0")
				End If
			End If
			If Positioncal.Width1 < Positioncal.CladWidth Then
				Interaction.MsgBox("The width should be at least " + Positioncal.CladWidth.ToString("#.0") + ". Please adjust accordingly", MsgBoxStyle.Exclamation, "Information")
			Else
				w.WriteLine(Me.Diatxt.Text)
				w.WriteLine(Me.Crnkthrtxt.Text)
				w.WriteLine(Me.Widthtxt.Text)
				w.WriteLine(Me.Distxt.Text)
				w.WriteLine(Me.Pittxt.Text)
				w.WriteLine(Me.Postatxt.Text)
				w.WriteLine(Me.Conatxt.Text)
				w.WriteLine(Me.Inioverwtxt.Text)
				w.WriteLine(Me.Finoverwtxt.Text)
				w.WriteLine(Me.Meandramp.Text)
				w.WriteLine(Me.Meandrptc.Text)
				w.WriteLine(CInt(Me.Meandrflg.CheckState))
				w.WriteLine(Me.Initang.Text)
				w.WriteLine(Me.Tooloffsettxt.Text)
				w.WriteLine(Positioncal.StationPosition.ToString())
				w.WriteLine(Positioncal.CladdingDir.ToString())
				w.WriteLine(Positioncal.CurrPos.ToString())
				w.Close()
				Me.DialogResult = DialogResult.OK
				Me.Close()
			End If
		End Sub

		' Token: 0x060001B0 RID: 432 RVA: 0x00027324 File Offset: 0x00025724
		Private Sub Tooloffsettxt_TextChanged(sender As Object, e As EventArgs)
			If Versioned.IsNumeric(Me.Tooloffsettxt.Text) Then
				Dim value As Double = Conversions.ToDouble(Me.Tooloffsettxt.Text)
				Me.Tooloffsettxt.Text = value.ToString("#0.0")
				Positioncal.ToolOffset = value
			Else
				Interaction.MsgBox("This is not a valid value", MsgBoxStyle.Exclamation, Nothing)
				Me.Tooloffsettxt.Text = 0.ToString("#0.0")
				Positioncal.ToolOffset = 0.0
			End If
		End Sub

		' Token: 0x060001B1 RID: 433 RVA: 0x000273A8 File Offset: 0x000257A8
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

		' Token: 0x060001B2 RID: 434 RVA: 0x00027434 File Offset: 0x00025834
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

		' Token: 0x060001B3 RID: 435 RVA: 0x000274C0 File Offset: 0x000258C0
		Private Sub Distxt_Leave(sender As Object, e As EventArgs)
			If Char.IsNumber(Conversions.ToChar(Me.Distxt.Text)) Then
				If Conversions.ToDouble(Me.Distxt.Text) > Positioncal.MinDistance Then
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

		' Token: 0x060001B4 RID: 436 RVA: 0x000275BC File Offset: 0x000259BC
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

		' Token: 0x060001B5 RID: 437 RVA: 0x00027648 File Offset: 0x00025A48
		Private Sub Postatxt_Leave(sender As Object, e As EventArgs)
			If Versioned.IsNumeric(Me.Postatxt.Text) Then
				If Conversions.ToDouble(Me.Postatxt.Text) > 45.0 And Conversions.ToDouble(Me.Postatxt.Text) < 135.0 Then
					Dim value As Double = Conversions.ToDouble(Me.Postatxt.Text)
					Me.Postatxt.Text = value.ToString("#0.00")
					Positioncal.PostureAngle = value
				Else
					Interaction.MsgBox("The posture angle should be within 45 and 135 degrees to the axis", MsgBoxStyle.Exclamation, Nothing)
					Me.Postatxt.Text = 90.ToString("#0.00")
					Positioncal.PostureAngle = 90.0
				End If
			Else
				Interaction.MsgBox("This is not a valid value", MsgBoxStyle.Exclamation, Nothing)
				Me.Postatxt.Text = 90.ToString("#0.00")
				Positioncal.PostureAngle = 90.0
			End If
		End Sub

		' Token: 0x060001B6 RID: 438 RVA: 0x00027744 File Offset: 0x00025B44
		Private Sub Conatxt_Leave(sender As Object, e As EventArgs)
			If Versioned.IsNumeric(Me.Conatxt.Text) Then
				If Conversions.ToDouble(Me.Conatxt.Text) < 90.0 And Conversions.ToDouble(Me.Conatxt.Text) > -90.0 Then
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

		' Token: 0x060001B7 RID: 439 RVA: 0x0002783C File Offset: 0x00025C3C
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

		' Token: 0x060001B8 RID: 440 RVA: 0x00027934 File Offset: 0x00025D34
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

		' Token: 0x060001B9 RID: 441 RVA: 0x00027A34 File Offset: 0x00025E34
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

		' Token: 0x060001BA RID: 442 RVA: 0x00027AC0 File Offset: 0x00025EC0
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

		' Token: 0x060001BB RID: 443 RVA: 0x00027B4C File Offset: 0x00025F4C
		Private Sub Initang_Leave(sender As Object, e As EventArgs)
			If Versioned.IsNumeric(Me.Initang.Text) Then
				Dim value As Double = Conversions.ToDouble(Me.Initang.Text)
				Me.Initang.Text = value.ToString("#0.00")
				Positioncal.InitialAng = value
			Else
				Interaction.MsgBox("This is not a valid value", MsgBoxStyle.Exclamation, Nothing)
				Me.Initang.Text = 0.ToString("#0.00")
				Positioncal.InitialAng = 0.0
			End If
		End Sub

		' Token: 0x060001BC RID: 444 RVA: 0x00027BD0 File Offset: 0x00025FD0
		Private Sub A1_Click(sender As Object, e As EventArgs)
			If Me.A1.Checked Then
				Positioncal.StationPosition = 1
			End If
		End Sub

		' Token: 0x060001BD RID: 445 RVA: 0x00027BE8 File Offset: 0x00025FE8
		Private Sub A2_CheckedChanged(sender As Object, e As EventArgs)
			If Me.A2.Checked Then
				Positioncal.StationPosition = 2
			End If
		End Sub

		' Token: 0x060001BE RID: 446 RVA: 0x00027C00 File Offset: 0x00026000
		Private Sub A3_CheckedChanged(sender As Object, e As EventArgs)
			If Me.A3.Checked Then
				Positioncal.StationPosition = 3
			End If
		End Sub

		' Token: 0x060001BF RID: 447 RVA: 0x00027C18 File Offset: 0x00026018
		Private Sub Leftdirflg_CheckedChanged(sender As Object, e As EventArgs)
			If Me.Leftdirflg.Checked Then
				Positioncal.CladdingDir = -1
			End If
		End Sub

		' Token: 0x060001C0 RID: 448 RVA: 0x00027C30 File Offset: 0x00026030
		Private Sub Rightdirflg_CheckedChanged(sender As Object, e As EventArgs)
			If Me.Rightdirflg.Checked Then
				Positioncal.CladdingDir = 1
			End If
		End Sub

		' Token: 0x060001C1 RID: 449 RVA: 0x00027C48 File Offset: 0x00026048
		Private Sub WD_20_CheckedChanged(sender As Object, e As EventArgs)
			If Me.WD_20.Checked Then
				Positioncal.Toolno = 0
			End If
		End Sub

		' Token: 0x060001C2 RID: 450 RVA: 0x00027C60 File Offset: 0x00026060
		Private Sub WD_13_CheckedChanged(sender As Object, e As EventArgs)
			If Me.WD_13.Checked Then
				Positioncal.Toolno = 1
			End If
		End Sub

		' Token: 0x060001C3 RID: 451 RVA: 0x00027C78 File Offset: 0x00026078
		Private Sub CurrPosStat_Click(sender As Object, e As EventArgs)
			Dim form2rect As Rectangle = New Rectangle(50, 100, 694, 440)
			If Me.CurrPosStat.Checked Then
				Interaction.MsgBox("Please bring the journal to TDC position and the robot to its desired location before uploading", MsgBoxStyle.Exclamation, Nothing)
				MyProject.Forms.Posıtıonupload.DesktopBounds = form2rect
				MyProject.Forms.Posıtıonupload.ShowDialog()
				If MyProject.Forms.Posıtıonupload.DialogResult = DialogResult.OK Then
					Positioncal.CurrPos = 1S
					Positioncal.WorkXAxisOffset = Positioncal.Position(0, 0)
					Positioncal.WorkYAxisTilt = Positioncal.Position(4, 0)
					Positioncal.WorkZAxisYaw = Positioncal.Position(5, 0)
					Me.Initang.Text = Positioncal.Position(7, 0).ToString("#0.00")
					Me.Diatxt.Text = ((Math.Abs(Positioncal.Position(2, 0)) - Positioncal.CrankThrow) * 2.0).ToString("#0.00")
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

		' Token: 0x060001C4 RID: 452 RVA: 0x00027EB0 File Offset: 0x000262B0
		Private Sub CRPARAM_Load(sender As Object, e As EventArgs)
			Me.Diatxt.Text = Positioncal.Diameter.ToString("#0.0")
			Me.Crnkthrtxt.Text = Positioncal.CrankThrow.ToString("#0.0")
			Me.Widthtxt.Text = Positioncal.Width1.ToString("#0.0")
			Me.Distxt.Text = Positioncal.Distance.ToString("#0.0")
			Me.Pittxt.Text = Positioncal.Pitch.ToString("#0.0")
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
				Me.Meandrflg.Checked = True
			Else
				Me.Meandrflg.Checked = False
			End If
			Me.CurrPosStat.Checked = (Positioncal.CurrPos <> 0S)
		End Sub

		' Token: 0x060001C5 RID: 453 RVA: 0x00028090 File Offset: 0x00026490
		Private Sub Crnkthrtxt_Leave(sender As Object, e As EventArgs)
			If Char.IsNumber(Conversions.ToChar(Me.Crnkthrtxt.Text)) Then
				Dim value As Double = Conversions.ToDouble(Me.Crnkthrtxt.Text)
				Me.Crnkthrtxt.Text = value.ToString("#0.0")
				Positioncal.CrankThrow = value
			Else
				Interaction.MsgBox("This is not a valid value", MsgBoxStyle.Exclamation, Nothing)
				Me.Crnkthrtxt.Text = 0.ToString("#0.0")
				Positioncal.CrankThrow = 0.0
			End If
		End Sub

		' Token: 0x060001C6 RID: 454 RVA: 0x0002811C File Offset: 0x0002651C
		Private Sub Meandrflg_click(sender As Object, e As EventArgs)
			If Me.Meandrflg.Checked Then
				Positioncal.MeanderFlg = 1S
			Else
				Positioncal.MeanderFlg = 0S
			End If
		End Sub

		' Token: 0x0400008C RID: 140
		<AccessedThroughProperty("Diatxt")>
		Private _Diatxt As TextBox

		' Token: 0x0400008D RID: 141
		<AccessedThroughProperty("Widthtxt")>
		Private _Widthtxt As TextBox

		' Token: 0x0400008E RID: 142
		<AccessedThroughProperty("Distxt")>
		Private _Distxt As TextBox

		' Token: 0x0400008F RID: 143
		<AccessedThroughProperty("Pittxt")>
		Private _Pittxt As TextBox

		' Token: 0x04000090 RID: 144
		<AccessedThroughProperty("GroupBox2")>
		Private _GroupBox2 As GroupBox

		' Token: 0x04000091 RID: 145
		<AccessedThroughProperty("Cnfrmbtn")>
		Private _Cnfrmbtn As Button

		' Token: 0x04000092 RID: 146
		<AccessedThroughProperty("Cnlbtn")>
		Private _Cnlbtn As Button

		' Token: 0x04000093 RID: 147
		<AccessedThroughProperty("GroupBox3")>
		Private _GroupBox3 As GroupBox

		' Token: 0x04000094 RID: 148
		<AccessedThroughProperty("Postatxt")>
		Private _Postatxt As TextBox

		' Token: 0x04000095 RID: 149
		<AccessedThroughProperty("Meandramp")>
		Private _Meandramp As TextBox

		' Token: 0x04000096 RID: 150
		<AccessedThroughProperty("Conatxt")>
		Private _Conatxt As TextBox

		' Token: 0x04000097 RID: 151
		<AccessedThroughProperty("Inioverwtxt")>
		Private _Inioverwtxt As TextBox

		' Token: 0x04000098 RID: 152
		<AccessedThroughProperty("Meandrflg")>
		Private _Meandrflg As CheckBox

		' Token: 0x04000099 RID: 153
		<AccessedThroughProperty("Meandrptc")>
		Private _Meandrptc As TextBox

		' Token: 0x0400009A RID: 154
		<AccessedThroughProperty("Initang")>
		Private _Initang As TextBox

		' Token: 0x0400009B RID: 155
		<AccessedThroughProperty("Crnkthrtxt")>
		Private _Crnkthrtxt As TextBox

		' Token: 0x0400009C RID: 156
		<AccessedThroughProperty("GroupBox4")>
		Private _GroupBox4 As GroupBox

		' Token: 0x0400009D RID: 157
		<AccessedThroughProperty("Rightdirflg")>
		Private _Rightdirflg As RadioButton

		' Token: 0x0400009E RID: 158
		<AccessedThroughProperty("Leftdirflg")>
		Private _Leftdirflg As RadioButton

		' Token: 0x0400009F RID: 159
		<AccessedThroughProperty("GroupBox1")>
		Private _GroupBox1 As GroupBox

		' Token: 0x040000A0 RID: 160
		<AccessedThroughProperty("A2")>
		Private _A2 As RadioButton

		' Token: 0x040000A1 RID: 161
		<AccessedThroughProperty("A1")>
		Private _A1 As RadioButton

		' Token: 0x040000A2 RID: 162
		<AccessedThroughProperty("Tooloffsettxt")>
		Private _Tooloffsettxt As TextBox

		' Token: 0x040000A3 RID: 163
		<AccessedThroughProperty("Finoverwtxt")>
		Private _Finoverwtxt As TextBox

		' Token: 0x040000A4 RID: 164
		<AccessedThroughProperty("A3")>
		Private _A3 As RadioButton

		' Token: 0x040000A5 RID: 165
		<AccessedThroughProperty("GroupBox5")>
		Private _GroupBox5 As GroupBox

		' Token: 0x040000A6 RID: 166
		<AccessedThroughProperty("WD_13")>
		Private _WD_13 As RadioButton

		' Token: 0x040000A7 RID: 167
		<AccessedThroughProperty("WD_20")>
		Private _WD_20 As RadioButton

		' Token: 0x040000A8 RID: 168
		<AccessedThroughProperty("CurrPosStat")>
		Private _CurrPosStat As CheckBox
	End Class
End Namespace
