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
	' Token: 0x02000018 RID: 24
	<DesignerGenerated()>
	Public Partial Class PPARAM
		Inherits Form

		' Token: 0x0600048E RID: 1166 RVA: 0x0003F8D4 File Offset: 0x0003DCD4
		<DebuggerNonUserCode()>
		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.Pcladparam_Load
			Me.InitializeComponent()
		End Sub

		' Token: 0x17000170 RID: 368
		' (get) Token: 0x06000491 RID: 1169 RVA: 0x000412A4 File Offset: 0x0003F6A4
		' (set) Token: 0x06000492 RID: 1170 RVA: 0x000412B8 File Offset: 0x0003F6B8
		Friend Overridable Property Lengthtxt As TextBox
			<DebuggerNonUserCode()>
			Get
				Return Me._Lengthtxt
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As EventHandler = AddressOf Me.Lengthtxt_Leave
				If Me._Lengthtxt IsNot Nothing Then
					RemoveHandler Me._Lengthtxt.Leave, value2
				End If
				Me._Lengthtxt = value
				If Me._Lengthtxt IsNot Nothing Then
					AddHandler Me._Lengthtxt.Leave, value2
				End If
			End Set
		End Property

		' Token: 0x17000171 RID: 369
		' (get) Token: 0x06000493 RID: 1171 RVA: 0x00041304 File Offset: 0x0003F704
		' (set) Token: 0x06000494 RID: 1172 RVA: 0x00041318 File Offset: 0x0003F718
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

		' Token: 0x17000172 RID: 370
		' (get) Token: 0x06000495 RID: 1173 RVA: 0x00041364 File Offset: 0x0003F764
		' (set) Token: 0x06000496 RID: 1174 RVA: 0x00041378 File Offset: 0x0003F778
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

		' Token: 0x17000173 RID: 371
		' (get) Token: 0x06000497 RID: 1175 RVA: 0x000413C4 File Offset: 0x0003F7C4
		' (set) Token: 0x06000498 RID: 1176 RVA: 0x000413D8 File Offset: 0x0003F7D8
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

		' Token: 0x17000174 RID: 372
		' (get) Token: 0x06000499 RID: 1177 RVA: 0x00041424 File Offset: 0x0003F824
		' (set) Token: 0x0600049A RID: 1178 RVA: 0x00041438 File Offset: 0x0003F838
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

		' Token: 0x17000175 RID: 373
		' (get) Token: 0x0600049B RID: 1179 RVA: 0x00041444 File Offset: 0x0003F844
		' (set) Token: 0x0600049C RID: 1180 RVA: 0x00041458 File Offset: 0x0003F858
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

		' Token: 0x17000176 RID: 374
		' (get) Token: 0x0600049D RID: 1181 RVA: 0x000414A4 File Offset: 0x0003F8A4
		' (set) Token: 0x0600049E RID: 1182 RVA: 0x000414B8 File Offset: 0x0003F8B8
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

		' Token: 0x17000177 RID: 375
		' (get) Token: 0x0600049F RID: 1183 RVA: 0x00041504 File Offset: 0x0003F904
		' (set) Token: 0x060004A0 RID: 1184 RVA: 0x00041518 File Offset: 0x0003F918
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

		' Token: 0x17000178 RID: 376
		' (get) Token: 0x060004A1 RID: 1185 RVA: 0x00041524 File Offset: 0x0003F924
		' (set) Token: 0x060004A2 RID: 1186 RVA: 0x00041538 File Offset: 0x0003F938
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

		' Token: 0x17000179 RID: 377
		' (get) Token: 0x060004A3 RID: 1187 RVA: 0x00041584 File Offset: 0x0003F984
		' (set) Token: 0x060004A4 RID: 1188 RVA: 0x00041598 File Offset: 0x0003F998
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

		' Token: 0x1700017A RID: 378
		' (get) Token: 0x060004A5 RID: 1189 RVA: 0x000415E4 File Offset: 0x0003F9E4
		' (set) Token: 0x060004A6 RID: 1190 RVA: 0x000415F8 File Offset: 0x0003F9F8
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

		' Token: 0x1700017B RID: 379
		' (get) Token: 0x060004A7 RID: 1191 RVA: 0x00041644 File Offset: 0x0003FA44
		' (set) Token: 0x060004A8 RID: 1192 RVA: 0x00041658 File Offset: 0x0003FA58
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

		' Token: 0x1700017C RID: 380
		' (get) Token: 0x060004A9 RID: 1193 RVA: 0x000416A4 File Offset: 0x0003FAA4
		' (set) Token: 0x060004AA RID: 1194 RVA: 0x000416B8 File Offset: 0x0003FAB8
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

		' Token: 0x1700017D RID: 381
		' (get) Token: 0x060004AB RID: 1195 RVA: 0x00041704 File Offset: 0x0003FB04
		' (set) Token: 0x060004AC RID: 1196 RVA: 0x00041718 File Offset: 0x0003FB18
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

		' Token: 0x1700017E RID: 382
		' (get) Token: 0x060004AD RID: 1197 RVA: 0x00041764 File Offset: 0x0003FB64
		' (set) Token: 0x060004AE RID: 1198 RVA: 0x00041778 File Offset: 0x0003FB78
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

		' Token: 0x1700017F RID: 383
		' (get) Token: 0x060004AF RID: 1199 RVA: 0x000417C4 File Offset: 0x0003FBC4
		' (set) Token: 0x060004B0 RID: 1200 RVA: 0x000417D8 File Offset: 0x0003FBD8
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

		' Token: 0x17000180 RID: 384
		' (get) Token: 0x060004B1 RID: 1201 RVA: 0x00041824 File Offset: 0x0003FC24
		' (set) Token: 0x060004B2 RID: 1202 RVA: 0x00041838 File Offset: 0x0003FC38
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

		' Token: 0x17000181 RID: 385
		' (get) Token: 0x060004B3 RID: 1203 RVA: 0x00041844 File Offset: 0x0003FC44
		' (set) Token: 0x060004B4 RID: 1204 RVA: 0x00041858 File Offset: 0x0003FC58
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

		' Token: 0x17000182 RID: 386
		' (get) Token: 0x060004B5 RID: 1205 RVA: 0x000418A4 File Offset: 0x0003FCA4
		' (set) Token: 0x060004B6 RID: 1206 RVA: 0x000418B8 File Offset: 0x0003FCB8
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

		' Token: 0x17000183 RID: 387
		' (get) Token: 0x060004B7 RID: 1207 RVA: 0x00041904 File Offset: 0x0003FD04
		' (set) Token: 0x060004B8 RID: 1208 RVA: 0x00041918 File Offset: 0x0003FD18
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

		' Token: 0x17000184 RID: 388
		' (get) Token: 0x060004B9 RID: 1209 RVA: 0x00041964 File Offset: 0x0003FD64
		' (set) Token: 0x060004BA RID: 1210 RVA: 0x00041978 File Offset: 0x0003FD78
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

		' Token: 0x17000185 RID: 389
		' (get) Token: 0x060004BB RID: 1211 RVA: 0x00041984 File Offset: 0x0003FD84
		' (set) Token: 0x060004BC RID: 1212 RVA: 0x00041998 File Offset: 0x0003FD98
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

		' Token: 0x17000186 RID: 390
		' (get) Token: 0x060004BD RID: 1213 RVA: 0x000419E4 File Offset: 0x0003FDE4
		' (set) Token: 0x060004BE RID: 1214 RVA: 0x000419F8 File Offset: 0x0003FDF8
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

		' Token: 0x17000187 RID: 391
		' (get) Token: 0x060004BF RID: 1215 RVA: 0x00041A44 File Offset: 0x0003FE44
		' (set) Token: 0x060004C0 RID: 1216 RVA: 0x00041A58 File Offset: 0x0003FE58
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

		' Token: 0x060004C1 RID: 1217 RVA: 0x00041AA4 File Offset: 0x0003FEA4
		Private Sub Pcladparam_Load(sender As Object, e As EventArgs)
			Me.Lengthtxt.Text = Positioncal.Length.ToString("#0.00")
			Me.Widthtxt.Text = Positioncal.Width1.ToString("#0.00")
			Me.Xtxt.Text = Positioncal.Xpos.ToString("#0.00")
			Me.Ytxt.Text = Positioncal.Ypos.ToString("#0.00")
			Me.Ztxt.Text = Positioncal.Zpos.ToString("#0.00")
			Me.Pittxt.Text = Positioncal.Pitch.ToString("#0.00")
			Me.Postatxt.Text = Positioncal.PostureAngle.ToString("#0.00")
			Me.Meandramp.Text = Positioncal.MeanderAmp.ToString("#0.00")
			Me.Meandrptc.Text = Positioncal.MeanderPitch.ToString("#0.00")
			If Positioncal.MeanderFlg = 1S Then
				Me.Meandrflg.Checked = True
			Else
				Me.Meandrflg.Checked = False
			End If
			Me.Tooloffsettxt.Text = Conversions.ToString(Positioncal.ToolOffset)
			If Positioncal.CurrPos = 1S Then
				Me.CurrPosStat.Checked = True
			Else
				Me.CurrPosStat.Checked = False
			End If
			Positioncal.StationPosition = 1
			Me.A1.Enabled = True
			Me.A2.Enabled = False
			Me.A3.Enabled = False
			Me.WD_13.Enabled = False
			Me.WD_20.Enabled = True
		End Sub

		' Token: 0x060004C2 RID: 1218 RVA: 0x00041C38 File Offset: 0x00040038
		Private Sub Cnlbtn_Click(sender As Object, e As EventArgs)
			Me.Close()
		End Sub

		' Token: 0x060004C3 RID: 1219 RVA: 0x00041C40 File Offset: 0x00040040
		Private Sub Cnfrmbtn_Click(sender As Object, e As EventArgs)
			Dim fs As FileStream = New FileStream(Application.StartupPath + "\Pcladparam.txt", FileMode.Create)
			Dim w As StreamWriter = New StreamWriter(fs)
			Positioncal.Length = Conversions.ToDouble(Me.Lengthtxt.Text)
			Positioncal.Width1 = Conversions.ToDouble(Me.Widthtxt.Text)
			Positioncal.Xpos = Conversions.ToDouble(Me.Xtxt.Text)
			Positioncal.Ypos = Conversions.ToDouble(Me.Ytxt.Text)
			Positioncal.Zpos = Conversions.ToDouble(Me.Ztxt.Text)
			Positioncal.Pitch = Conversions.ToDouble(Me.Pittxt.Text)
			Positioncal.PostureAngle = Conversions.ToDouble(Me.Postatxt.Text)
			Positioncal.MeanderAmp = Conversions.ToDouble(Me.Meandramp.Text)
			Positioncal.MeanderPitch = Conversions.ToDouble(Me.Meandrptc.Text)
			Positioncal.MeanderFlg = CShort(Me.Meandrflg.CheckState)
			Positioncal.InitialAng = Conversions.ToDouble(Me.Initang.Text)
			Positioncal.ToolOffset = Conversions.ToDouble(Me.Tooloffsettxt.Text)
			Dim num As Integer = Conversions.ToInteger(Me.Widthtxt.Text)
			If num < CInt(Math.Round(Positioncal.CladWidth)) Then
				Dim msgbxres As Short = CShort(Interaction.MsgBox("The minimum clad width is greater than " + Positioncal.CladWidth.ToString("#.00") + ". Adjust width accordingly?" & vbCrLf & "(If yes, meander movement will also be disabled)", MsgBoxStyle.YesNo, "Question"))
				If msgbxres = 6S Then
					' The following expression was wrapped in a unchecked-expression
					Positioncal.Width1 = Positioncal.CladWidth + 0.1
					Me.Widthtxt.Text = Positioncal.Width1.ToString("#.00")
					Positioncal.MeanderFlg = 0S
					Me.Meandrflg.CheckState = CheckState.Unchecked
					Interaction.MsgBox("The width has been recalculated to " + Positioncal.Width1.ToString("#0.00 mm"), MsgBoxStyle.Information, "Information")
				End If
			ElseIf num < CInt(Math.Round(2.0 * Positioncal.MeanderAmp)) Then
				If Me.Meandrflg.CheckState = CheckState.Checked Then
					Dim msgbxres As Short = CShort(Interaction.MsgBox("The desired width is smaller than the meander width." & vbCrLf & "Adjust meander amplitude accordingly?", MsgBoxStyle.YesNo, "Question"))
					If msgbxres = 6S Then
						Positioncal.MeanderAmp = Positioncal.Width1 / 2.0
						Me.Meandramp.Text = Positioncal.MeanderAmp.ToString("#.00")
						Interaction.MsgBox("The meander amplitude has been recalculated to " + Positioncal.MeanderAmp.ToString("#0.00 mm"), MsgBoxStyle.Information, "Information")
					End If
				End If
			ElseIf num < CInt(Math.Round(1.5 * Positioncal.Pitch + 2.0 * Positioncal.MeanderAmp)) AndAlso Me.Meandrflg.CheckState = CheckState.Checked Then
				Dim msgbxres As Short = CShort(Interaction.MsgBox("The desired width is only slightly larger to the clad width." & vbCrLf & "Adjust meander amplitude to achieve the desired width in one revolution?", MsgBoxStyle.YesNo, "Question"))
				If msgbxres = 6S Then
					Positioncal.MeanderAmp = Positioncal.Width1 / 2.0
					Me.Meandramp.Text = Positioncal.MeanderAmp.ToString("#.00")
					Interaction.MsgBox("The meander amplitude has been recalculated to " + Positioncal.MeanderAmp.ToString("#0.00 mm"), MsgBoxStyle.Information, "Information")
				End If
			End If
			If Positioncal.Width1 < Positioncal.CladWidth Then
				Interaction.MsgBox("The width should be at least " + Positioncal.CladWidth.ToString("#.00") + ". Please adjust accordingly", MsgBoxStyle.Exclamation, "Information")
			Else
				w.WriteLine(Me.Lengthtxt.Text)
				w.WriteLine(Me.Widthtxt.Text)
				w.WriteLine(Me.Xtxt.Text)
				w.WriteLine(Me.Ytxt.Text)
				w.WriteLine(Me.Ztxt.Text)
				w.WriteLine(Me.Pittxt.Text)
				w.WriteLine(Me.Postatxt.Text)
				w.WriteLine(Me.Meandramp.Text)
				w.WriteLine(Me.Meandrptc.Text)
				w.WriteLine(CInt(Me.Meandrflg.CheckState))
				w.WriteLine(Me.Tooloffsettxt.Text)
				w.WriteLine(Positioncal.StationPosition.ToString())
				w.WriteLine(Positioncal.CurrPos.ToString())
				w.Close()
				Me.DialogResult = DialogResult.OK
				Me.Close()
			End If
		End Sub

		' Token: 0x060004C4 RID: 1220 RVA: 0x00042088 File Offset: 0x00040488
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

		' Token: 0x060004C5 RID: 1221 RVA: 0x00042104 File Offset: 0x00040504
		Private Sub Lengthtxt_Leave(sender As Object, e As EventArgs)
			If Char.IsNumber(Conversions.ToChar(Me.Lengthtxt.Text)) Then
				Dim value As Double = Conversions.ToDouble(Me.Lengthtxt.Text)
				Me.Lengthtxt.Text = value.ToString("#0.0")
				Positioncal.Length = value
			Else
				Interaction.MsgBox("This is not a valid value", MsgBoxStyle.Exclamation, Nothing)
				Me.Lengthtxt.Text = 50.ToString("#0.0")
				Positioncal.Length = 50.0
			End If
		End Sub

		' Token: 0x060004C6 RID: 1222 RVA: 0x00042190 File Offset: 0x00040590
		Private Sub Widthtxt_Leave(sender As Object, e As EventArgs)
			If Char.IsNumber(Conversions.ToChar(Me.Widthtxt.Text)) Then
				Dim value As Double = Conversions.ToDouble(Me.Widthtxt.Text)
				Me.Widthtxt.Text = value.ToString("#0.0")
			Else
				Interaction.MsgBox("This is not a valid value (0 < W mm)", MsgBoxStyle.Exclamation, Nothing)
				Me.Widthtxt.Text = 15.ToString("#0.0")
			End If
		End Sub

		' Token: 0x060004C7 RID: 1223 RVA: 0x00042208 File Offset: 0x00040608
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

		' Token: 0x060004C8 RID: 1224 RVA: 0x00042290 File Offset: 0x00040690
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

		' Token: 0x060004C9 RID: 1225 RVA: 0x00042320 File Offset: 0x00040720
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

		' Token: 0x060004CA RID: 1226 RVA: 0x000423A8 File Offset: 0x000407A8
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

		' Token: 0x060004CB RID: 1227 RVA: 0x00042434 File Offset: 0x00040834
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

		' Token: 0x060004CC RID: 1228 RVA: 0x00042518 File Offset: 0x00040918
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

		' Token: 0x060004CD RID: 1229 RVA: 0x000425A4 File Offset: 0x000409A4
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

		' Token: 0x060004CE RID: 1230 RVA: 0x00042630 File Offset: 0x00040A30
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

		' Token: 0x060004CF RID: 1231 RVA: 0x000426BC File Offset: 0x00040ABC
		Private Sub A1_Click(sender As Object, e As EventArgs)
			If Me.A1.Checked Then
				Positioncal.StationPosition = 1
			End If
		End Sub

		' Token: 0x060004D0 RID: 1232 RVA: 0x000426D4 File Offset: 0x00040AD4
		Private Sub A2_CheckedChanged(sender As Object, e As EventArgs)
			If Me.A2.Checked Then
				Positioncal.StationPosition = 2
			End If
		End Sub

		' Token: 0x060004D1 RID: 1233 RVA: 0x000426EC File Offset: 0x00040AEC
		Private Sub A3_CheckedChanged(sender As Object, e As EventArgs)
			If Me.A3.Checked Then
				Positioncal.StationPosition = 3
			End If
		End Sub

		' Token: 0x060004D2 RID: 1234 RVA: 0x00042704 File Offset: 0x00040B04
		Private Sub WD_20_CheckedChanged(sender As Object, e As EventArgs)
			If Me.WD_20.Checked Then
				Positioncal.Toolno = 0
			End If
		End Sub

		' Token: 0x060004D3 RID: 1235 RVA: 0x0004271C File Offset: 0x00040B1C
		Private Sub WD_13_CheckedChanged(sender As Object, e As EventArgs)
			If Me.WD_13.Checked Then
				Positioncal.Toolno = 1
			End If
		End Sub

		' Token: 0x060004D4 RID: 1236 RVA: 0x00042734 File Offset: 0x00040B34
		Private Sub CheckBox2_Click(sender As Object, e As EventArgs)
			Dim form2rect As Rectangle = New Rectangle(50, 100, 694, 440)
			If Me.CurrPosStat.Checked Then
				Global.WindowsApplication1.My.MyProject.Forms.Posıtıonupload.DesktopBounds = form2rect
				Global.WindowsApplication1.My.MyProject.Forms.Posıtıonupload.ShowDialog()
				If Global.WindowsApplication1.My.MyProject.Forms.Posıtıonupload.DialogResult = DialogResult.OK Then
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

		' Token: 0x060004D5 RID: 1237 RVA: 0x00042988 File Offset: 0x00040D88
		Private Sub Meandrflg_CheckedChanged(sender As Object, e As EventArgs)
			If Me.Meandrflg.Checked Then
				Positioncal.MeanderFlg = 1S
			End If
		End Sub

		' Token: 0x04000190 RID: 400
		<AccessedThroughProperty("Lengthtxt")>
		Private _Lengthtxt As TextBox

		' Token: 0x04000191 RID: 401
		<AccessedThroughProperty("Widthtxt")>
		Private _Widthtxt As TextBox

		' Token: 0x04000192 RID: 402
		<AccessedThroughProperty("Xtxt")>
		Private _Xtxt As TextBox

		' Token: 0x04000193 RID: 403
		<AccessedThroughProperty("Pittxt")>
		Private _Pittxt As TextBox

		' Token: 0x04000194 RID: 404
		<AccessedThroughProperty("GroupBox2")>
		Private _GroupBox2 As GroupBox

		' Token: 0x04000195 RID: 405
		<AccessedThroughProperty("Cnfrmbtn")>
		Private _Cnfrmbtn As Button

		' Token: 0x04000196 RID: 406
		<AccessedThroughProperty("Cnlbtn")>
		Private _Cnlbtn As Button

		' Token: 0x04000197 RID: 407
		<AccessedThroughProperty("GroupBox3")>
		Private _GroupBox3 As GroupBox

		' Token: 0x04000198 RID: 408
		<AccessedThroughProperty("Postatxt")>
		Private _Postatxt As TextBox

		' Token: 0x04000199 RID: 409
		<AccessedThroughProperty("Meandramp")>
		Private _Meandramp As TextBox

		' Token: 0x0400019A RID: 410
		<AccessedThroughProperty("Meandrflg")>
		Private _Meandrflg As CheckBox

		' Token: 0x0400019B RID: 411
		<AccessedThroughProperty("Meandrptc")>
		Private _Meandrptc As TextBox

		' Token: 0x0400019C RID: 412
		<AccessedThroughProperty("Initang")>
		Private _Initang As TextBox

		' Token: 0x0400019D RID: 413
		<AccessedThroughProperty("Tooloffsettxt")>
		Private _Tooloffsettxt As TextBox

		' Token: 0x0400019E RID: 414
		<AccessedThroughProperty("Ztxt")>
		Private _Ztxt As TextBox

		' Token: 0x0400019F RID: 415
		<AccessedThroughProperty("Ytxt")>
		Private _Ytxt As TextBox

		' Token: 0x040001A0 RID: 416
		<AccessedThroughProperty("GroupBox1")>
		Private _GroupBox1 As GroupBox

		' Token: 0x040001A1 RID: 417
		<AccessedThroughProperty("A3")>
		Private _A3 As RadioButton

		' Token: 0x040001A2 RID: 418
		<AccessedThroughProperty("A2")>
		Private _A2 As RadioButton

		' Token: 0x040001A3 RID: 419
		<AccessedThroughProperty("A1")>
		Private _A1 As RadioButton

		' Token: 0x040001A4 RID: 420
		<AccessedThroughProperty("GroupBox5")>
		Private _GroupBox5 As GroupBox

		' Token: 0x040001A5 RID: 421
		<AccessedThroughProperty("WD_13")>
		Private _WD_13 As RadioButton

		' Token: 0x040001A6 RID: 422
		<AccessedThroughProperty("WD_20")>
		Private _WD_20 As RadioButton

		' Token: 0x040001A7 RID: 423
		<AccessedThroughProperty("CurrPosStat")>
		Private _CurrPosStat As CheckBox
	End Class
End Namespace
