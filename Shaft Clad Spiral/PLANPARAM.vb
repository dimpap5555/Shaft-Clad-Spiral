Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

Namespace WindowsApplication1
	' Token: 0x02000019 RID: 25
	<DesignerGenerated()>
	Public Partial Class PLANPARAM
		Inherits Form

		' Token: 0x060004D6 RID: 1238 RVA: 0x000429A0 File Offset: 0x00040DA0
		<DebuggerNonUserCode()>
		Public Sub New()
			Me.InitializeComponent()
		End Sub

		' Token: 0x17000188 RID: 392
		' (get) Token: 0x060004D9 RID: 1241 RVA: 0x0004434C File Offset: 0x0004274C
		' (set) Token: 0x060004DA RID: 1242 RVA: 0x00044360 File Offset: 0x00042760
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

		' Token: 0x17000189 RID: 393
		' (get) Token: 0x060004DB RID: 1243 RVA: 0x000443AC File Offset: 0x000427AC
		' (set) Token: 0x060004DC RID: 1244 RVA: 0x000443C0 File Offset: 0x000427C0
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

		' Token: 0x1700018A RID: 394
		' (get) Token: 0x060004DD RID: 1245 RVA: 0x0004440C File Offset: 0x0004280C
		' (set) Token: 0x060004DE RID: 1246 RVA: 0x00044420 File Offset: 0x00042820
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

		' Token: 0x1700018B RID: 395
		' (get) Token: 0x060004DF RID: 1247 RVA: 0x0004446C File Offset: 0x0004286C
		' (set) Token: 0x060004E0 RID: 1248 RVA: 0x00044480 File Offset: 0x00042880
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

		' Token: 0x1700018C RID: 396
		' (get) Token: 0x060004E1 RID: 1249 RVA: 0x000444CC File Offset: 0x000428CC
		' (set) Token: 0x060004E2 RID: 1250 RVA: 0x000444E0 File Offset: 0x000428E0
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

		' Token: 0x1700018D RID: 397
		' (get) Token: 0x060004E3 RID: 1251 RVA: 0x000444EC File Offset: 0x000428EC
		' (set) Token: 0x060004E4 RID: 1252 RVA: 0x00044500 File Offset: 0x00042900
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

		' Token: 0x1700018E RID: 398
		' (get) Token: 0x060004E5 RID: 1253 RVA: 0x0004454C File Offset: 0x0004294C
		' (set) Token: 0x060004E6 RID: 1254 RVA: 0x00044560 File Offset: 0x00042960
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

		' Token: 0x1700018F RID: 399
		' (get) Token: 0x060004E7 RID: 1255 RVA: 0x000445AC File Offset: 0x000429AC
		' (set) Token: 0x060004E8 RID: 1256 RVA: 0x000445C0 File Offset: 0x000429C0
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

		' Token: 0x17000190 RID: 400
		' (get) Token: 0x060004E9 RID: 1257 RVA: 0x000445CC File Offset: 0x000429CC
		' (set) Token: 0x060004EA RID: 1258 RVA: 0x000445E0 File Offset: 0x000429E0
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

		' Token: 0x17000191 RID: 401
		' (get) Token: 0x060004EB RID: 1259 RVA: 0x0004462C File Offset: 0x00042A2C
		' (set) Token: 0x060004EC RID: 1260 RVA: 0x00044640 File Offset: 0x00042A40
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

		' Token: 0x17000192 RID: 402
		' (get) Token: 0x060004ED RID: 1261 RVA: 0x0004468C File Offset: 0x00042A8C
		' (set) Token: 0x060004EE RID: 1262 RVA: 0x000446A0 File Offset: 0x00042AA0
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

		' Token: 0x17000193 RID: 403
		' (get) Token: 0x060004EF RID: 1263 RVA: 0x000446EC File Offset: 0x00042AEC
		' (set) Token: 0x060004F0 RID: 1264 RVA: 0x00044700 File Offset: 0x00042B00
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

		' Token: 0x17000194 RID: 404
		' (get) Token: 0x060004F1 RID: 1265 RVA: 0x0004474C File Offset: 0x00042B4C
		' (set) Token: 0x060004F2 RID: 1266 RVA: 0x00044760 File Offset: 0x00042B60
		Friend Overridable Property CheckBox1 As CheckBox
			<DebuggerNonUserCode()>
			Get
				Return Me._CheckBox1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As CheckBox)
				Me._CheckBox1 = value
			End Set
		End Property

		' Token: 0x17000195 RID: 405
		' (get) Token: 0x060004F3 RID: 1267 RVA: 0x0004476C File Offset: 0x00042B6C
		' (set) Token: 0x060004F4 RID: 1268 RVA: 0x00044780 File Offset: 0x00042B80
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

		' Token: 0x17000196 RID: 406
		' (get) Token: 0x060004F5 RID: 1269 RVA: 0x000447CC File Offset: 0x00042BCC
		' (set) Token: 0x060004F6 RID: 1270 RVA: 0x000447E0 File Offset: 0x00042BE0
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

		' Token: 0x17000197 RID: 407
		' (get) Token: 0x060004F7 RID: 1271 RVA: 0x0004482C File Offset: 0x00042C2C
		' (set) Token: 0x060004F8 RID: 1272 RVA: 0x00044840 File Offset: 0x00042C40
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

		' Token: 0x17000198 RID: 408
		' (get) Token: 0x060004F9 RID: 1273 RVA: 0x0004484C File Offset: 0x00042C4C
		' (set) Token: 0x060004FA RID: 1274 RVA: 0x00044860 File Offset: 0x00042C60
		Friend Overridable Property Shortaxflg As RadioButton
			<DebuggerNonUserCode()>
			Get
				Return Me._Shortaxflg
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As RadioButton)
				Me._Shortaxflg = value
			End Set
		End Property

		' Token: 0x17000199 RID: 409
		' (get) Token: 0x060004FB RID: 1275 RVA: 0x0004486C File Offset: 0x00042C6C
		' (set) Token: 0x060004FC RID: 1276 RVA: 0x00044880 File Offset: 0x00042C80
		Friend Overridable Property Longaxflg As RadioButton
			<DebuggerNonUserCode()>
			Get
				Return Me._Longaxflg
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As RadioButton)
				Me._Longaxflg = value
			End Set
		End Property

		' Token: 0x1700019A RID: 410
		' (get) Token: 0x060004FD RID: 1277 RVA: 0x0004488C File Offset: 0x00042C8C
		' (set) Token: 0x060004FE RID: 1278 RVA: 0x000448A0 File Offset: 0x00042CA0
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

		' Token: 0x1700019B RID: 411
		' (get) Token: 0x060004FF RID: 1279 RVA: 0x000448EC File Offset: 0x00042CEC
		' (set) Token: 0x06000500 RID: 1280 RVA: 0x00044900 File Offset: 0x00042D00
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

		' Token: 0x1700019C RID: 412
		' (get) Token: 0x06000501 RID: 1281 RVA: 0x0004490C File Offset: 0x00042D0C
		' (set) Token: 0x06000502 RID: 1282 RVA: 0x00044920 File Offset: 0x00042D20
		Friend Overridable Property Rightdirflg As RadioButton
			<DebuggerNonUserCode()>
			Get
				Return Me._Rightdirflg
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As RadioButton)
				Me._Rightdirflg = value
			End Set
		End Property

		' Token: 0x1700019D RID: 413
		' (get) Token: 0x06000503 RID: 1283 RVA: 0x0004492C File Offset: 0x00042D2C
		' (set) Token: 0x06000504 RID: 1284 RVA: 0x00044940 File Offset: 0x00042D40
		Friend Overridable Property Leftdirflg As RadioButton
			<DebuggerNonUserCode()>
			Get
				Return Me._Leftdirflg
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As RadioButton)
				Me._Leftdirflg = value
			End Set
		End Property

		' Token: 0x1700019E RID: 414
		' (get) Token: 0x06000505 RID: 1285 RVA: 0x0004494C File Offset: 0x00042D4C
		' (set) Token: 0x06000506 RID: 1286 RVA: 0x00044960 File Offset: 0x00042D60
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

		' Token: 0x06000507 RID: 1287 RVA: 0x000449AC File Offset: 0x00042DAC
		Private Sub Cnlbtn_Click(sender As Object, e As EventArgs)
			Me.Close()
		End Sub

		' Token: 0x06000508 RID: 1288 RVA: 0x000449B4 File Offset: 0x00042DB4
		Private Sub Cnfrmbtn_Click(sender As Object, e As EventArgs)
			Positioncal.Diameter = Conversions.ToDouble(Me.Diatxt.Text)
			Positioncal.Width1 = Conversions.ToDouble(Me.Widthtxt.Text)
			Positioncal.Distance = Conversions.ToDouble(Me.Distxt.Text)
			Positioncal.Pitch = Conversions.ToDouble(Me.Pittxt.Text)
			Positioncal.PostureAngle = Conversions.ToDouble(Me.Postatxt.Text)
			Positioncal.ConeAngle = Conversions.ToDouble(Me.Conatxt.Text)
			Positioncal.IniOverWeld = Conversions.ToSingle(Me.Inioverwtxt.Text)
			Positioncal.FinOverWeld = Conversions.ToSingle(Me.Finoverwtxt.Text)
			Positioncal.MeanderAmp = Conversions.ToDouble(Me.Meandramp.Text)
			Positioncal.MeanderPitch = Conversions.ToDouble(Me.Meandrptc.Text)
			Positioncal.MeanderFlg = CShort(Me.CheckBox1.CheckState)
			Positioncal.InitialAng = Conversions.ToDouble(Me.Initang.Text)
			Positioncal.ToolOffset = Conversions.ToDouble(Me.Tooloffsettxt.Text)
			Positioncal.StationPosition = If((-If((Me.Shortaxflg.Checked > False), 1, 0)), 1, 0)
			If Me.Rightdirflg.Checked Then
				Positioncal.CladdingDir = 1
			Else
				Positioncal.CladdingDir = -1
			End If
			Dim num As Integer = Conversions.ToInteger(Me.Widthtxt.Text)
			If num < CInt(Math.Round(Positioncal.CladWidth)) Then
				Dim msgbxres As Short = CShort(Interaction.MsgBox("The minimum clad width is greater than " + Positioncal.CladWidth.ToString("#.00") + ". Adjust width accordingly?" & vbCrLf & "(If yes, meander movement will also be disabled)", MsgBoxStyle.YesNo, "Question"))
				If msgbxres = 6S Then
					' The following expression was wrapped in a unchecked-expression
					Positioncal.Width1 = Positioncal.CladWidth + 0.1
					Me.Widthtxt.Text = Positioncal.Width1.ToString("#.00")
					Positioncal.MeanderFlg = 0S
					Me.CheckBox1.CheckState = CheckState.Unchecked
					Interaction.MsgBox("The width has been recalculated to " + Positioncal.Width1.ToString("#0.00 mm"), MsgBoxStyle.Information, "Information")
				End If
			ElseIf num < CInt(Math.Round(2.0 * Positioncal.MeanderAmp)) Then
				If Me.CheckBox1.CheckState = CheckState.Checked Then
					Dim msgbxres As Short = CShort(Interaction.MsgBox("The desired width is smaller than the meander width." & vbCrLf & "Adjust meander amplitude accordingly?", MsgBoxStyle.YesNo, "Question"))
					If msgbxres = 6S Then
						Positioncal.MeanderAmp = Positioncal.Width1 / 2.0
						Me.Meandramp.Text = Positioncal.MeanderAmp.ToString("#.00")
						Interaction.MsgBox("The meander amplitude has been recalculated to " + Positioncal.MeanderAmp.ToString("#0.00 mm"), MsgBoxStyle.Information, "Information")
					End If
				End If
			ElseIf num < CInt(Math.Round(1.5 * Positioncal.Pitch + 2.0 * Positioncal.MeanderAmp)) AndAlso Me.CheckBox1.CheckState = CheckState.Checked Then
				Dim msgbxres As Short = CShort(Interaction.MsgBox("The desired width is only slightly larger to the clad width." & vbCrLf & "Adjust meander amplitude to achieve the desired width in one revolution?", MsgBoxStyle.YesNo, "Question"))
				If msgbxres = 6S Then
					Positioncal.MeanderAmp = Positioncal.Width1 / 2.0
					Me.Meandramp.Text = Positioncal.MeanderAmp.ToString("#.00")
					Interaction.MsgBox("The meander amplitude has been recalculated to " + Positioncal.MeanderAmp.ToString("#0.00 mm"), MsgBoxStyle.Information, "Information")
				End If
			End If
			Dim rpm As Double = Positioncal.ProcessSpeed * 60.0 / (3.141592653589793 * Positioncal.Diameter)
			If rpm > 9.66183574879227 Then
				Interaction.MsgBox("The Process Speed is too high for the specified diameter. It will be reduced to " + 9.66183574879227.ToString("#0.0 mm/s"), MsgBoxStyle.Exclamation, Nothing)
				Positioncal.ProcessSpeed = 9.66183574879227
			End If
			If Positioncal.Width1 < Positioncal.CladWidth Then
				Interaction.MsgBox("The width should be at least " + Positioncal.CladWidth.ToString("#.00") + ". Please adjust accordingly", MsgBoxStyle.Exclamation, "Information")
			Else
				Me.DialogResult = DialogResult.OK
				Me.Close()
			End If
		End Sub

		' Token: 0x06000509 RID: 1289 RVA: 0x00044DA0 File Offset: 0x000431A0
		Private Sub Tooloffsettxt_TextChanged(sender As Object, e As EventArgs)
			If Versioned.IsNumeric(Me.Tooloffsettxt.Text) Then
				Dim value As Double = Conversions.ToDouble(Me.Tooloffsettxt.Text)
				Me.Tooloffsettxt.Text = value.ToString("#0.00")
			Else
				Interaction.MsgBox("This is not a valid value", MsgBoxStyle.Exclamation, Nothing)
				Me.Tooloffsettxt.Text = "0.00"
			End If
		End Sub

		' Token: 0x0600050A RID: 1290 RVA: 0x00044E08 File Offset: 0x00043208
		Private Sub Diatxt_Leave(sender As Object, e As EventArgs)
			If Char.IsNumber(Conversions.ToChar(Me.Diatxt.Text)) Then
				Dim value As Double = Conversions.ToDouble(Me.Diatxt.Text)
				Me.Diatxt.Text = value.ToString("#0.00")
			Else
				Interaction.MsgBox("This is not a valid value (0<D<500mm)", MsgBoxStyle.Exclamation, Nothing)
				Me.Diatxt.Text = 50.ToString("#0.00")
			End If
		End Sub

		' Token: 0x0600050B RID: 1291 RVA: 0x00044E80 File Offset: 0x00043280
		Private Sub Widthtxt_Leave(sender As Object, e As EventArgs)
			If Char.IsNumber(Conversions.ToChar(Me.Widthtxt.Text)) Then
				Dim value As Double = Conversions.ToDouble(Me.Widthtxt.Text)
				Me.Widthtxt.Text = value.ToString("#0.00")
			Else
				Interaction.MsgBox("This is not a valid value (0 < W mm)", MsgBoxStyle.Exclamation, Nothing)
				Me.Widthtxt.Text = 15.ToString("#0.00")
			End If
		End Sub

		' Token: 0x0600050C RID: 1292 RVA: 0x00044EF8 File Offset: 0x000432F8
		Private Sub Distxt_Leave(sender As Object, e As EventArgs)
			If Char.IsNumber(Conversions.ToChar(Me.Distxt.Text)) Then
				If Conversions.ToDouble(Me.Distxt.Text) > Positioncal.MinDistance Then
					Dim value As Double = Conversions.ToDouble(Me.Distxt.Text)
					Me.Distxt.Text = value.ToString("#0.00")
				Else
					Interaction.MsgBox("The minimum distance from the Chuck has been specified to " + Positioncal.MinDistance.ToString("#0.00"), MsgBoxStyle.Exclamation, Nothing)
					Me.Distxt.Text = 500.ToString("#0.00")
				End If
			Else
				Interaction.MsgBox("This is not a valid value", MsgBoxStyle.Exclamation, Nothing)
				Me.Distxt.Text = 500.ToString("#0.00")
			End If
		End Sub

		' Token: 0x0600050D RID: 1293 RVA: 0x00044FCC File Offset: 0x000433CC
		Private Sub Pittxt_Leave(sender As Object, e As EventArgs)
			If Char.IsNumber(Conversions.ToChar(Me.Pittxt.Text)) Then
				Dim value As Double = Conversions.ToDouble(Me.Pittxt.Text)
				Me.Pittxt.Text = value.ToString("#0.00")
			Else
				Interaction.MsgBox("This is not a valid value (Pitch > 0 mm)", MsgBoxStyle.Exclamation, Nothing)
				Me.Pittxt.Text = 4.ToString("#0.00")
			End If
		End Sub

		' Token: 0x0600050E RID: 1294 RVA: 0x00045044 File Offset: 0x00043444
		Private Sub Postatxt_Leave(sender As Object, e As EventArgs)
			If Versioned.IsNumeric(Me.Postatxt.Text) Then
				Dim value As Double = Conversions.ToDouble(Me.Postatxt.Text)
				If value >= 0.0 And value <= 135.0 Then
					Me.Postatxt.Text = value.ToString("#0.00")
				Else
					Interaction.MsgBox("The posture angle should be within 45 and 135 degrees to the axis", MsgBoxStyle.Exclamation, Nothing)
					Me.Postatxt.Text = 90.ToString("#0.00")
				End If
			Else
				Interaction.MsgBox("This is not a valid value", MsgBoxStyle.Exclamation, Nothing)
				Me.Postatxt.Text = 90.ToString("#0.00")
			End If
		End Sub

		' Token: 0x0600050F RID: 1295 RVA: 0x00045100 File Offset: 0x00043500
		Private Sub Conatxt_Leave(sender As Object, e As EventArgs)
			If Versioned.IsNumeric(Me.Conatxt.Text) Then
				Dim value As Double = Conversions.ToDouble(Me.Conatxt.Text)
				If value <= 90.0 And value >= -90.0 Then
					Me.Conatxt.Text = value.ToString("#0.00")
				Else
					Interaction.MsgBox("The Cone angle should be within -90 and 90 degrees to the axis", MsgBoxStyle.Exclamation, Nothing)
					Me.Conatxt.Text = 0.ToString("#0.00")
				End If
			Else
				Interaction.MsgBox("This is not a valid value", MsgBoxStyle.Exclamation, Nothing)
				Me.Conatxt.Text = 0.ToString("#0.00")
			End If
		End Sub

		' Token: 0x06000510 RID: 1296 RVA: 0x000451BC File Offset: 0x000435BC
		Private Sub Inioverwtxt_Leave(sender As Object, e As EventArgs)
			If Char.IsNumber(Conversions.ToChar(Me.Inioverwtxt.Text)) Then
				Dim value As Double = Conversions.ToDouble(Me.Inioverwtxt.Text)
				Me.Inioverwtxt.Text = value.ToString("#0.00")
			Else
				Interaction.MsgBox("This is not a valid value (Overweld > 0 mm)", MsgBoxStyle.Exclamation, Nothing)
				Me.Inioverwtxt.Text = 0.ToString("#0.00")
			End If
		End Sub

		' Token: 0x06000511 RID: 1297 RVA: 0x00045234 File Offset: 0x00043634
		Private Sub Finoverwtxt_Leave(sender As Object, e As EventArgs)
			If Char.IsNumber(Conversions.ToChar(Me.Finoverwtxt.Text)) Then
				Dim value As Double = Conversions.ToDouble(Me.Finoverwtxt.Text)
				Me.Finoverwtxt.Text = value.ToString("#0.00")
			Else
				Interaction.MsgBox("This is not a valid value (Overweld > 0 mm)", MsgBoxStyle.Exclamation, Nothing)
				Me.Finoverwtxt.Text = 0.ToString("#0.00")
			End If
		End Sub

		' Token: 0x06000512 RID: 1298 RVA: 0x000452AC File Offset: 0x000436AC
		Private Sub Meandramp_Leave(sender As Object, e As EventArgs)
			If Char.IsNumber(Conversions.ToChar(Me.Meandramp.Text)) Then
				Dim value As Double = Conversions.ToDouble(Me.Meandramp.Text)
				Me.Meandramp.Text = value.ToString("#0.00")
			Else
				Interaction.MsgBox("This is not a valid value (Amplitude > 0 mm)", MsgBoxStyle.Exclamation, Nothing)
				Me.Meandramp.Text = 2.ToString("#0.00")
			End If
		End Sub

		' Token: 0x06000513 RID: 1299 RVA: 0x00045324 File Offset: 0x00043724
		Private Sub Meandrptc_Leave(sender As Object, e As EventArgs)
			If Char.IsNumber(Conversions.ToChar(Me.Meandrptc.Text)) Then
				Dim value As Double = Conversions.ToDouble(Me.Meandrptc.Text)
				Me.Meandrptc.Text = value.ToString("#0.00")
			Else
				Interaction.MsgBox("This is not a valid value (Meander Pitch > 0 mm)", MsgBoxStyle.Exclamation, Nothing)
				Me.Meandrptc.Text = 3.ToString("#0.00")
			End If
		End Sub

		' Token: 0x06000514 RID: 1300 RVA: 0x0004539C File Offset: 0x0004379C
		Private Sub Initang_Leave(sender As Object, e As EventArgs)
			If Char.IsNumber(Conversions.ToChar(Me.Initang.Text)) Then
				Dim value As Double = Conversions.ToDouble(Me.Initang.Text)
				Me.Initang.Text = value.ToString("#0.00")
			Else
				Interaction.MsgBox("This is not a valid value", MsgBoxStyle.Exclamation, Nothing)
				Me.Initang.Text = 0.ToString("#0.00")
			End If
		End Sub

		' Token: 0x040001A9 RID: 425
		<AccessedThroughProperty("Diatxt")>
		Private _Diatxt As TextBox

		' Token: 0x040001AA RID: 426
		<AccessedThroughProperty("Widthtxt")>
		Private _Widthtxt As TextBox

		' Token: 0x040001AB RID: 427
		<AccessedThroughProperty("Distxt")>
		Private _Distxt As TextBox

		' Token: 0x040001AC RID: 428
		<AccessedThroughProperty("Pittxt")>
		Private _Pittxt As TextBox

		' Token: 0x040001AD RID: 429
		<AccessedThroughProperty("GroupBox2")>
		Private _GroupBox2 As GroupBox

		' Token: 0x040001AE RID: 430
		<AccessedThroughProperty("Cnfrmbtn")>
		Private _Cnfrmbtn As Button

		' Token: 0x040001AF RID: 431
		<AccessedThroughProperty("Cnlbtn")>
		Private _Cnlbtn As Button

		' Token: 0x040001B0 RID: 432
		<AccessedThroughProperty("GroupBox3")>
		Private _GroupBox3 As GroupBox

		' Token: 0x040001B1 RID: 433
		<AccessedThroughProperty("Postatxt")>
		Private _Postatxt As TextBox

		' Token: 0x040001B2 RID: 434
		<AccessedThroughProperty("Meandramp")>
		Private _Meandramp As TextBox

		' Token: 0x040001B3 RID: 435
		<AccessedThroughProperty("Conatxt")>
		Private _Conatxt As TextBox

		' Token: 0x040001B4 RID: 436
		<AccessedThroughProperty("Inioverwtxt")>
		Private _Inioverwtxt As TextBox

		' Token: 0x040001B5 RID: 437
		<AccessedThroughProperty("CheckBox1")>
		Private _CheckBox1 As CheckBox

		' Token: 0x040001B6 RID: 438
		<AccessedThroughProperty("Meandrptc")>
		Private _Meandrptc As TextBox

		' Token: 0x040001B7 RID: 439
		<AccessedThroughProperty("Initang")>
		Private _Initang As TextBox

		' Token: 0x040001B8 RID: 440
		<AccessedThroughProperty("GroupBox1")>
		Private _GroupBox1 As GroupBox

		' Token: 0x040001B9 RID: 441
		<AccessedThroughProperty("Shortaxflg")>
		Private _Shortaxflg As RadioButton

		' Token: 0x040001BA RID: 442
		<AccessedThroughProperty("Longaxflg")>
		Private _Longaxflg As RadioButton

		' Token: 0x040001BB RID: 443
		<AccessedThroughProperty("Tooloffsettxt")>
		Private _Tooloffsettxt As TextBox

		' Token: 0x040001BC RID: 444
		<AccessedThroughProperty("GroupBox4")>
		Private _GroupBox4 As GroupBox

		' Token: 0x040001BD RID: 445
		<AccessedThroughProperty("Rightdirflg")>
		Private _Rightdirflg As RadioButton

		' Token: 0x040001BE RID: 446
		<AccessedThroughProperty("Leftdirflg")>
		Private _Leftdirflg As RadioButton

		' Token: 0x040001BF RID: 447
		<AccessedThroughProperty("Finoverwtxt")>
		Private _Finoverwtxt As TextBox
	End Class
End Namespace
