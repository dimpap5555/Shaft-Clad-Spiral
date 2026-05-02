Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.IO
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports WindowsApplication1.WindowsApplication1.My

Namespace WindowsApplication1
	' Token: 0x02000009 RID: 9
	Public Partial Class BPARAM
		Inherits Form

		' Token: 0x060000A0 RID: 160 RVA: 0x0001B324 File Offset: 0x00019724
		<DebuggerNonUserCode()>
		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.VPARAM_Load
			Me.InitializeComponent()
		End Sub

		' Token: 0x1700003E RID: 62
		' (get) Token: 0x060000A3 RID: 163 RVA: 0x0001CF64 File Offset: 0x0001B364
		' (set) Token: 0x060000A4 RID: 164 RVA: 0x0001CF78 File Offset: 0x0001B378
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

		' Token: 0x1700003F RID: 63
		' (get) Token: 0x060000A5 RID: 165 RVA: 0x0001CFC4 File Offset: 0x0001B3C4
		' (set) Token: 0x060000A6 RID: 166 RVA: 0x0001CFD8 File Offset: 0x0001B3D8
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

		' Token: 0x17000040 RID: 64
		' (get) Token: 0x060000A7 RID: 167 RVA: 0x0001D024 File Offset: 0x0001B424
		' (set) Token: 0x060000A8 RID: 168 RVA: 0x0001D038 File Offset: 0x0001B438
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

		' Token: 0x17000041 RID: 65
		' (get) Token: 0x060000A9 RID: 169 RVA: 0x0001D084 File Offset: 0x0001B484
		' (set) Token: 0x060000AA RID: 170 RVA: 0x0001D098 File Offset: 0x0001B498
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

		' Token: 0x17000042 RID: 66
		' (get) Token: 0x060000AB RID: 171 RVA: 0x0001D0E4 File Offset: 0x0001B4E4
		' (set) Token: 0x060000AC RID: 172 RVA: 0x0001D0F8 File Offset: 0x0001B4F8
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

		' Token: 0x17000043 RID: 67
		' (get) Token: 0x060000AD RID: 173 RVA: 0x0001D104 File Offset: 0x0001B504
		' (set) Token: 0x060000AE RID: 174 RVA: 0x0001D118 File Offset: 0x0001B518
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

		' Token: 0x17000044 RID: 68
		' (get) Token: 0x060000AF RID: 175 RVA: 0x0001D164 File Offset: 0x0001B564
		' (set) Token: 0x060000B0 RID: 176 RVA: 0x0001D178 File Offset: 0x0001B578
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

		' Token: 0x17000045 RID: 69
		' (get) Token: 0x060000B1 RID: 177 RVA: 0x0001D1C4 File Offset: 0x0001B5C4
		' (set) Token: 0x060000B2 RID: 178 RVA: 0x0001D1D8 File Offset: 0x0001B5D8
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

		' Token: 0x17000046 RID: 70
		' (get) Token: 0x060000B3 RID: 179 RVA: 0x0001D1E4 File Offset: 0x0001B5E4
		' (set) Token: 0x060000B4 RID: 180 RVA: 0x0001D1F8 File Offset: 0x0001B5F8
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

		' Token: 0x17000047 RID: 71
		' (get) Token: 0x060000B5 RID: 181 RVA: 0x0001D244 File Offset: 0x0001B644
		' (set) Token: 0x060000B6 RID: 182 RVA: 0x0001D258 File Offset: 0x0001B658
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

		' Token: 0x17000048 RID: 72
		' (get) Token: 0x060000B7 RID: 183 RVA: 0x0001D2A4 File Offset: 0x0001B6A4
		' (set) Token: 0x060000B8 RID: 184 RVA: 0x0001D2B8 File Offset: 0x0001B6B8
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

		' Token: 0x17000049 RID: 73
		' (get) Token: 0x060000B9 RID: 185 RVA: 0x0001D304 File Offset: 0x0001B704
		' (set) Token: 0x060000BA RID: 186 RVA: 0x0001D318 File Offset: 0x0001B718
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

		' Token: 0x1700004A RID: 74
		' (get) Token: 0x060000BB RID: 187 RVA: 0x0001D364 File Offset: 0x0001B764
		' (set) Token: 0x060000BC RID: 188 RVA: 0x0001D378 File Offset: 0x0001B778
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

		' Token: 0x1700004B RID: 75
		' (get) Token: 0x060000BD RID: 189 RVA: 0x0001D3C4 File Offset: 0x0001B7C4
		' (set) Token: 0x060000BE RID: 190 RVA: 0x0001D3D8 File Offset: 0x0001B7D8
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

		' Token: 0x1700004C RID: 76
		' (get) Token: 0x060000BF RID: 191 RVA: 0x0001D424 File Offset: 0x0001B824
		' (set) Token: 0x060000C0 RID: 192 RVA: 0x0001D438 File Offset: 0x0001B838
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

		' Token: 0x1700004D RID: 77
		' (get) Token: 0x060000C1 RID: 193 RVA: 0x0001D484 File Offset: 0x0001B884
		' (set) Token: 0x060000C2 RID: 194 RVA: 0x0001D498 File Offset: 0x0001B898
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

		' Token: 0x1700004E RID: 78
		' (get) Token: 0x060000C3 RID: 195 RVA: 0x0001D4E4 File Offset: 0x0001B8E4
		' (set) Token: 0x060000C4 RID: 196 RVA: 0x0001D4F8 File Offset: 0x0001B8F8
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

		' Token: 0x1700004F RID: 79
		' (get) Token: 0x060000C5 RID: 197 RVA: 0x0001D544 File Offset: 0x0001B944
		' (set) Token: 0x060000C6 RID: 198 RVA: 0x0001D558 File Offset: 0x0001B958
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

		' Token: 0x17000050 RID: 80
		' (get) Token: 0x060000C7 RID: 199 RVA: 0x0001D564 File Offset: 0x0001B964
		' (set) Token: 0x060000C8 RID: 200 RVA: 0x0001D578 File Offset: 0x0001B978
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

		' Token: 0x17000051 RID: 81
		' (get) Token: 0x060000C9 RID: 201 RVA: 0x0001D5C4 File Offset: 0x0001B9C4
		' (set) Token: 0x060000CA RID: 202 RVA: 0x0001D5D8 File Offset: 0x0001B9D8
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

		' Token: 0x17000052 RID: 82
		' (get) Token: 0x060000CB RID: 203 RVA: 0x0001D624 File Offset: 0x0001BA24
		' (set) Token: 0x060000CC RID: 204 RVA: 0x0001D638 File Offset: 0x0001BA38
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

		' Token: 0x17000053 RID: 83
		' (get) Token: 0x060000CD RID: 205 RVA: 0x0001D684 File Offset: 0x0001BA84
		' (set) Token: 0x060000CE RID: 206 RVA: 0x0001D698 File Offset: 0x0001BA98
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

		' Token: 0x17000054 RID: 84
		' (get) Token: 0x060000CF RID: 207 RVA: 0x0001D6A4 File Offset: 0x0001BAA4
		' (set) Token: 0x060000D0 RID: 208 RVA: 0x0001D6B8 File Offset: 0x0001BAB8
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

		' Token: 0x17000055 RID: 85
		' (get) Token: 0x060000D1 RID: 209 RVA: 0x0001D704 File Offset: 0x0001BB04
		' (set) Token: 0x060000D2 RID: 210 RVA: 0x0001D718 File Offset: 0x0001BB18
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

		' Token: 0x17000056 RID: 86
		' (get) Token: 0x060000D3 RID: 211 RVA: 0x0001D764 File Offset: 0x0001BB64
		' (set) Token: 0x060000D4 RID: 212 RVA: 0x0001D778 File Offset: 0x0001BB78
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

		' Token: 0x060000D5 RID: 213 RVA: 0x0001D7C4 File Offset: 0x0001BBC4
		Private Sub Cnlbtn_Click(sender As Object, e As EventArgs)
			Me.DialogResult = DialogResult.Cancel
			Me.Close()
		End Sub

		' Token: 0x060000D6 RID: 214 RVA: 0x0001D7D4 File Offset: 0x0001BBD4
		Private Sub Cnfrmbtn_Click(sender As Object, e As EventArgs)
			Dim fs As FileStream = New FileStream(Application.StartupPath + "\Bcladparam.txt", FileMode.Create)
			Dim w As StreamWriter = New StreamWriter(fs)
			Positioncal.Diameter = Conversions.ToDouble(Me.Diatxt.Text) + CDbl((CInt((2S * Positioncal.CurrPos)) * Positioncal.CladdingDir)) * Positioncal.CladWidth / 2.0 * Math.Sin(Positioncal.ConeAngle * 3.141592653589793 / 180.0)
			Positioncal.Distance = Conversions.ToDouble(Me.Distxt.Text) - CDbl((CInt(Positioncal.CurrPos) * Positioncal.CladdingDir)) * Positioncal.CladWidth / 2.0 * Math.Cos(Positioncal.ConeAngle * 3.141592653589793 / 180.0)
			Positioncal.PostureAngle = Conversions.ToDouble(Me.Postatxt.Text)
			Positioncal.MeanderFlg = CShort(Me.Meandrflg.CheckState)
			Positioncal.InitialAng = Conversions.ToDouble(Me.Initang.Text) - CDbl((Positioncal.DirectionFlg * 360)) / CDbl(Positioncal.PPR) - Math.Floor((Conversions.ToDouble(Me.Initang.Text) - CDbl((Positioncal.DirectionFlg * 360)) / CDbl(Positioncal.PPR)) / 360.0) * 360.0
			Positioncal.ToolOffset = Conversions.ToDouble(Me.Tooloffsettxt.Text)
			Dim num As Integer = Conversions.ToInteger(Me.Widthtxt.Text)
			If num < CInt(Math.Round(Positioncal.CladWidth)) Then
				Dim msgbxres As Short = CShort(Interaction.MsgBox("The minimum clad width is " + Positioncal.CladWidth.ToString("#.0") + ". Adjust width accordingly?" & vbCrLf & "(If yes, meander movement will also be disabled)", MsgBoxStyle.YesNo, "Question"))
				If msgbxres = 6S Then
					Positioncal.Width1 = Positioncal.CladWidth
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
					Me.Meandramp.Text = Positioncal.MeanderAmp.ToString("#.00")
					Interaction.MsgBox("The meander amplitude has been recalculated to " + Positioncal.MeanderAmp.ToString("#0.00 mm"), MsgBoxStyle.Information, "Information")
				End If
			End If
			If Me.Stationslct.SelectedIndex = -1 Then
				Interaction.MsgBox("Please select the desired cone angle", MsgBoxStyle.Exclamation, "Cone Angle Selection")
			End If
			If Me.Stationslct.SelectedIndex <> -1 AndAlso Positioncal.Width1 >= Positioncal.CladWidth Then
				Select Case Me.Stationslct.SelectedIndex
					Case 0
						Positioncal.StationPosition = 1
					Case 1
						Positioncal.StationPosition = 2
					Case 2
						Positioncal.StationPosition = 3
					Case 3
						Positioncal.StationPosition = 4
					Case 4
						Positioncal.StationPosition = 5
				End Select
				Me.Widthtxt.Text = Positioncal.Width1.ToString("#.00")
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
				w.WriteLine(Positioncal.CladdingDir.ToString())
				w.WriteLine(Positioncal.CurrPos.ToString())
				w.Close()
				Me.DialogResult = DialogResult.OK
				Me.Close()
			ElseIf Positioncal.Width1 < Positioncal.CladWidth Then
				Interaction.MsgBox("The width should be at least " + Positioncal.CladWidth.ToString("#.0") + ". Please adjust accordingly", MsgBoxStyle.Exclamation, "Information")
				w.Close()
			End If
		End Sub

		' Token: 0x060000D7 RID: 215 RVA: 0x0001DD40 File Offset: 0x0001C140
		Private Sub Tooloffsettxt_TextChanged(sender As Object, e As EventArgs)
			If Versioned.IsNumeric(Me.Tooloffsettxt.Text) Then
				Dim value As Double = Conversions.ToDouble(Me.Tooloffsettxt.Text)
				Me.Tooloffsettxt.Text = value.ToString("#0.0")
				Positioncal.ToolOffset = value
			Else
				Interaction.MsgBox("This is not a valid value", MsgBoxStyle.Exclamation, Nothing)
				Me.Tooloffsettxt.Text = "0.0"
				Dim defval As Double
				Positioncal.ToolOffset = defval
			End If
		End Sub

		' Token: 0x060000D8 RID: 216 RVA: 0x0001DDB4 File Offset: 0x0001C1B4
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

		' Token: 0x060000D9 RID: 217 RVA: 0x0001DE40 File Offset: 0x0001C240
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

		' Token: 0x060000DA RID: 218 RVA: 0x0001DECC File Offset: 0x0001C2CC
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

		' Token: 0x060000DB RID: 219 RVA: 0x0001DFC0 File Offset: 0x0001C3C0
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

		' Token: 0x060000DC RID: 220 RVA: 0x0001E04C File Offset: 0x0001C44C
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

		' Token: 0x060000DD RID: 221 RVA: 0x0001E14C File Offset: 0x0001C54C
		Private Sub Inioverwtxt_Leave(sender As Object, e As EventArgs)
			If Versioned.IsNumeric(Me.Inioverwtxt.Text) Then
				If Conversions.ToDouble(Me.Inioverwtxt.Text) <= 120.0 And Conversions.ToDouble(Me.Inioverwtxt.Text) >= 0.0 Then
					Dim value As Double = Conversions.ToDouble(Me.Inioverwtxt.Text)
					Me.Inioverwtxt.Text = value.ToString("#0.0")
					Positioncal.IniOverWeld = CSng(value)
				Else
					Interaction.MsgBox("The Initial overweld should be within 0 and 120%", MsgBoxStyle.Exclamation, Nothing)
					Me.Inioverwtxt.Text = 100.ToString("#0.0")
					Positioncal.IniOverWeld = 100F
				End If
			Else
				Interaction.MsgBox("This is not a valid value (0 <= Overweld < 120 %)", MsgBoxStyle.Exclamation, Nothing)
				Me.Inioverwtxt.Text = 100.ToString("#0.0")
				Positioncal.IniOverWeld = 100F
			End If
		End Sub

		' Token: 0x060000DE RID: 222 RVA: 0x0001E244 File Offset: 0x0001C644
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

		' Token: 0x060000DF RID: 223 RVA: 0x0001E344 File Offset: 0x0001C744
		Private Sub Meandramp_Leave(sender As Object, e As EventArgs)
			If Char.IsNumber(Conversions.ToChar(Me.Meandramp.Text)) Then
				Dim value As Double = Conversions.ToDouble(Me.Meandramp.Text)
				Me.Meandramp.Text = value.ToString("#0.00")
			Else
				Interaction.MsgBox("This is not a valid value (Amplitude > 0 mm)", MsgBoxStyle.Exclamation, Nothing)
				Me.Meandramp.Text = 2.ToString("#0.00")
			End If
		End Sub

		' Token: 0x060000E0 RID: 224 RVA: 0x0001E3BC File Offset: 0x0001C7BC
		Private Sub Meandrptc_Leave(sender As Object, e As EventArgs)
			If Char.IsNumber(Conversions.ToChar(Me.Meandrptc.Text)) Then
				Dim value As Double = Conversions.ToDouble(Me.Meandrptc.Text)
				Me.Meandrptc.Text = value.ToString("#0.00")
				Positioncal.MeanderPitch = value
			Else
				Interaction.MsgBox("This is not a valid value (Meander Pitch > 0 mm)", MsgBoxStyle.Exclamation, Nothing)
				Me.Meandrptc.Text = 3.ToString("#0.00")
				Positioncal.MeanderPitch = 3.0
			End If
		End Sub

		' Token: 0x060000E1 RID: 225 RVA: 0x0001E448 File Offset: 0x0001C848
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

		' Token: 0x060000E2 RID: 226 RVA: 0x0001E560 File Offset: 0x0001C960
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

		' Token: 0x060000E3 RID: 227 RVA: 0x0001E660 File Offset: 0x0001CA60
		Private Sub VPARAM_Load(sender As Object, e As EventArgs)
			Me.Diatxt.Text = Positioncal.Diameter.ToString("#0.0")
			Me.Widthtxt.Text = Positioncal.Width1.ToString("#0.0")
			Me.Distxt.Text = Positioncal.Distance.ToString("#0.00")
			Me.Pittxt.Text = Positioncal.Pitch.ToString("#0.00")
			Me.Postatxt.Text = Positioncal.PostureAngle.ToString("#0.00")
			Select Case Positioncal.StationPosition
				Case 1
					Me.Stationslct.SelectedIndex = 0
				Case 2
					Me.Stationslct.SelectedIndex = 1
				Case 3
					Me.Stationslct.SelectedIndex = 2
				Case 4
					Me.Stationslct.SelectedIndex = 3
				Case 5
					Me.Stationslct.SelectedIndex = 4
			End Select
			Me.Conatxt.Text = Positioncal.ConeAngle.ToString("#0.00")
			Me.Inioverwtxt.Text = Positioncal.IniOverWeld.ToString("#0.0")
			Me.Finoverwtxt.Text = Positioncal.FinOverWeld.ToString("#0.0")
			Me.Meandramp.Text = Positioncal.MeanderAmp.ToString("#0.0")
			Me.Meandrptc.Text = Positioncal.MeanderPitch.ToString("#0.0")
			Me.Meandrflg.CheckState = CType(Positioncal.MeanderFlg, CheckState)
			Me.Initang.Text = Positioncal.InitialAng.ToString("#0.00")
			Me.Tooloffsettxt.Text = Conversions.ToString(Positioncal.ToolOffset)
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

		' Token: 0x060000E4 RID: 228 RVA: 0x0001E878 File Offset: 0x0001CC78
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
					Me.Initang.Text = Conversions.ToString(Positioncal.Position(7, 0))
					Me.Diatxt.Text = (Math.Abs(Positioncal.Position(2, 0)) * 2.0).ToString("#0.00")
					Me.Distxt.Text = Positioncal.Position(1, 0).ToString("#0.00")
					Me.Tooloffsettxt.Text = Conversions.ToString(0)
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

		' Token: 0x060000E5 RID: 229 RVA: 0x0001EA88 File Offset: 0x0001CE88
		Private Sub Leftdirflg_CheckedChanged(sender As Object, e As EventArgs)
			If Me.Leftdirflg.Checked Then
				Positioncal.CladdingDir = -1
			End If
		End Sub

		' Token: 0x060000E6 RID: 230 RVA: 0x0001EAA0 File Offset: 0x0001CEA0
		Private Sub Rightdirflg_CheckedChanged(sender As Object, e As EventArgs)
			If Me.Rightdirflg.Checked Then
				Positioncal.CladdingDir = 1
			End If
		End Sub

		' Token: 0x060000E7 RID: 231 RVA: 0x0001EAB8 File Offset: 0x0001CEB8
		Private Sub WD_20_CheckedChanged(sender As Object, e As EventArgs)
			If Me.WD_20.Checked Then
				Positioncal.Toolno = 0
			End If
		End Sub

		' Token: 0x060000E8 RID: 232 RVA: 0x0001EAD0 File Offset: 0x0001CED0
		Private Sub WD_13_CheckedChanged(sender As Object, e As EventArgs)
			If Me.WD_13.Checked Then
				Positioncal.Toolno = 1
			End If
		End Sub

		' Token: 0x060000E9 RID: 233 RVA: 0x0001EAE8 File Offset: 0x0001CEE8
		Private Sub Meandrflg_click(sender As Object, e As EventArgs)
			If Me.Meandrflg.Checked Then
				Positioncal.MeanderFlg = 1S
			Else
				Positioncal.MeanderFlg = 0S
			End If
		End Sub

		' Token: 0x060000EA RID: 234 RVA: 0x0001EB08 File Offset: 0x0001CF08
		Private Sub Stationslct_SelectedIndexChanged(sender As Object, e As EventArgs)
			Select Case Me.Stationslct.SelectedIndex
				Case 0
					Positioncal.StationPosition = 1
				Case 1
					Positioncal.StationPosition = 2
				Case 2
					Positioncal.StationPosition = 3
				Case 3
					Positioncal.StationPosition = 4
				Case 4
					Positioncal.StationPosition = 5
			End Select
		End Sub

		' Token: 0x04000041 RID: 65
		<AccessedThroughProperty("Diatxt")>
		Private _Diatxt As TextBox

		' Token: 0x04000042 RID: 66
		<AccessedThroughProperty("Widthtxt")>
		Private _Widthtxt As TextBox

		' Token: 0x04000043 RID: 67
		<AccessedThroughProperty("Distxt")>
		Private _Distxt As TextBox

		' Token: 0x04000044 RID: 68
		<AccessedThroughProperty("Pittxt")>
		Private _Pittxt As TextBox

		' Token: 0x04000045 RID: 69
		<AccessedThroughProperty("GroupBox2")>
		Private _GroupBox2 As GroupBox

		' Token: 0x04000046 RID: 70
		<AccessedThroughProperty("Cnfrmbtn")>
		Private _Cnfrmbtn As Button

		' Token: 0x04000047 RID: 71
		<AccessedThroughProperty("Cnlbtn")>
		Private _Cnlbtn As Button

		' Token: 0x04000048 RID: 72
		<AccessedThroughProperty("GroupBox3")>
		Private _GroupBox3 As GroupBox

		' Token: 0x04000049 RID: 73
		<AccessedThroughProperty("Postatxt")>
		Private _Postatxt As TextBox

		' Token: 0x0400004A RID: 74
		<AccessedThroughProperty("Meandramp")>
		Private _Meandramp As TextBox

		' Token: 0x0400004B RID: 75
		<AccessedThroughProperty("Inioverwtxt")>
		Private _Inioverwtxt As TextBox

		' Token: 0x0400004C RID: 76
		<AccessedThroughProperty("Meandrflg")>
		Private _Meandrflg As CheckBox

		' Token: 0x0400004D RID: 77
		<AccessedThroughProperty("Meandrptc")>
		Private _Meandrptc As TextBox

		' Token: 0x0400004E RID: 78
		<AccessedThroughProperty("Initang")>
		Private _Initang As TextBox

		' Token: 0x0400004F RID: 79
		<AccessedThroughProperty("Stationslct")>
		Private _Stationslct As ListBox

		' Token: 0x04000050 RID: 80
		<AccessedThroughProperty("Tooloffsettxt")>
		Private _Tooloffsettxt As TextBox

		' Token: 0x04000051 RID: 81
		<AccessedThroughProperty("Finoverwtxt")>
		Private _Finoverwtxt As TextBox

		' Token: 0x04000052 RID: 82
		<AccessedThroughProperty("GroupBox1")>
		Private _GroupBox1 As GroupBox

		' Token: 0x04000053 RID: 83
		<AccessedThroughProperty("Rightdirflg")>
		Private _Rightdirflg As RadioButton

		' Token: 0x04000054 RID: 84
		<AccessedThroughProperty("Leftdirflg")>
		Private _Leftdirflg As RadioButton

		' Token: 0x04000055 RID: 85
		<AccessedThroughProperty("Conatxt")>
		Private _Conatxt As TextBox

		' Token: 0x04000056 RID: 86
		<AccessedThroughProperty("GroupBox5")>
		Private _GroupBox5 As GroupBox

		' Token: 0x04000057 RID: 87
		<AccessedThroughProperty("WD_13")>
		Private _WD_13 As RadioButton

		' Token: 0x04000058 RID: 88
		<AccessedThroughProperty("WD_20")>
		Private _WD_20 As RadioButton

		' Token: 0x04000059 RID: 89
		<AccessedThroughProperty("CurrPosStat")>
		Private _CurrPosStat As CheckBox
	End Class
End Namespace
