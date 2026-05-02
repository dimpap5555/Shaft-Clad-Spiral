Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

Namespace WindowsApplication1
	' Token: 0x0200001C RID: 28
	Public Partial Class Posıtıonupload
		Inherits Form

		' Token: 0x06000573 RID: 1395 RVA: 0x00048648 File Offset: 0x00046A48
		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.Posıtıonupload_Load
			Me.Uframe = ""
			Me.InitializeComponent()
		End Sub

		' Token: 0x170001B8 RID: 440
		' (get) Token: 0x06000576 RID: 1398 RVA: 0x00049460 File Offset: 0x00047860
		' (set) Token: 0x06000577 RID: 1399 RVA: 0x00049474 File Offset: 0x00047874
		Friend Overridable Property Xpostxt As TextBox
			<DebuggerNonUserCode()>
			Get
				Return Me._Xpostxt
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As EventHandler = AddressOf Me.Xpostxt_Leave
				If Me._Xpostxt IsNot Nothing Then
					RemoveHandler Me._Xpostxt.Leave, value2
				End If
				Me._Xpostxt = value
				If Me._Xpostxt IsNot Nothing Then
					AddHandler Me._Xpostxt.Leave, value2
				End If
			End Set
		End Property

		' Token: 0x170001B9 RID: 441
		' (get) Token: 0x06000578 RID: 1400 RVA: 0x000494C0 File Offset: 0x000478C0
		' (set) Token: 0x06000579 RID: 1401 RVA: 0x000494D4 File Offset: 0x000478D4
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

		' Token: 0x170001BA RID: 442
		' (get) Token: 0x0600057A RID: 1402 RVA: 0x000494E0 File Offset: 0x000478E0
		' (set) Token: 0x0600057B RID: 1403 RVA: 0x000494F4 File Offset: 0x000478F4
		Friend Overridable Property Rzpostxt As TextBox
			<DebuggerNonUserCode()>
			Get
				Return Me._Rzpostxt
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As EventHandler = AddressOf Me.Rzpostxt_Leave
				If Me._Rzpostxt IsNot Nothing Then
					RemoveHandler Me._Rzpostxt.Leave, value2
				End If
				Me._Rzpostxt = value
				If Me._Rzpostxt IsNot Nothing Then
					AddHandler Me._Rzpostxt.Leave, value2
				End If
			End Set
		End Property

		' Token: 0x170001BB RID: 443
		' (get) Token: 0x0600057C RID: 1404 RVA: 0x00049540 File Offset: 0x00047940
		' (set) Token: 0x0600057D RID: 1405 RVA: 0x00049554 File Offset: 0x00047954
		Friend Overridable Property Rypostxt As TextBox
			<DebuggerNonUserCode()>
			Get
				Return Me._Rypostxt
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As EventHandler = AddressOf Me.Rypostxt_Leave
				If Me._Rypostxt IsNot Nothing Then
					RemoveHandler Me._Rypostxt.Leave, value2
				End If
				Me._Rypostxt = value
				If Me._Rypostxt IsNot Nothing Then
					AddHandler Me._Rypostxt.Leave, value2
				End If
			End Set
		End Property

		' Token: 0x170001BC RID: 444
		' (get) Token: 0x0600057E RID: 1406 RVA: 0x000495A0 File Offset: 0x000479A0
		' (set) Token: 0x0600057F RID: 1407 RVA: 0x000495B4 File Offset: 0x000479B4
		Friend Overridable Property Rxpostxt As TextBox
			<DebuggerNonUserCode()>
			Get
				Return Me._Rxpostxt
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As EventHandler = AddressOf Me.Rxpostxt_Leave
				If Me._Rxpostxt IsNot Nothing Then
					RemoveHandler Me._Rxpostxt.Leave, value2
				End If
				Me._Rxpostxt = value
				If Me._Rxpostxt IsNot Nothing Then
					AddHandler Me._Rxpostxt.Leave, value2
				End If
			End Set
		End Property

		' Token: 0x170001BD RID: 445
		' (get) Token: 0x06000580 RID: 1408 RVA: 0x00049600 File Offset: 0x00047A00
		' (set) Token: 0x06000581 RID: 1409 RVA: 0x00049614 File Offset: 0x00047A14
		Friend Overridable Property Zpostxt As TextBox
			<DebuggerNonUserCode()>
			Get
				Return Me._Zpostxt
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As EventHandler = AddressOf Me.Zpostxt_Leave
				If Me._Zpostxt IsNot Nothing Then
					RemoveHandler Me._Zpostxt.Leave, value2
				End If
				Me._Zpostxt = value
				If Me._Zpostxt IsNot Nothing Then
					AddHandler Me._Zpostxt.Leave, value2
				End If
			End Set
		End Property

		' Token: 0x170001BE RID: 446
		' (get) Token: 0x06000582 RID: 1410 RVA: 0x00049660 File Offset: 0x00047A60
		' (set) Token: 0x06000583 RID: 1411 RVA: 0x00049674 File Offset: 0x00047A74
		Friend Overridable Property Ypostxt As TextBox
			<DebuggerNonUserCode()>
			Get
				Return Me._Ypostxt
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As EventHandler = AddressOf Me.Ypostxt_Leave
				If Me._Ypostxt IsNot Nothing Then
					RemoveHandler Me._Ypostxt.Leave, value2
				End If
				Me._Ypostxt = value
				If Me._Ypostxt IsNot Nothing Then
					AddHandler Me._Ypostxt.Leave, value2
				End If
			End Set
		End Property

		' Token: 0x170001BF RID: 447
		' (get) Token: 0x06000584 RID: 1412 RVA: 0x000496C0 File Offset: 0x00047AC0
		' (set) Token: 0x06000585 RID: 1413 RVA: 0x000496D4 File Offset: 0x00047AD4
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

		' Token: 0x170001C0 RID: 448
		' (get) Token: 0x06000586 RID: 1414 RVA: 0x000496E0 File Offset: 0x00047AE0
		' (set) Token: 0x06000587 RID: 1415 RVA: 0x000496F4 File Offset: 0x00047AF4
		Friend Overridable Property S2postxt As TextBox
			<DebuggerNonUserCode()>
			Get
				Return Me._S2postxt
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As EventHandler = AddressOf Me.S2postxt_Leave
				If Me._S2postxt IsNot Nothing Then
					RemoveHandler Me._S2postxt.Leave, value2
				End If
				Me._S2postxt = value
				If Me._S2postxt IsNot Nothing Then
					AddHandler Me._S2postxt.Leave, value2
				End If
			End Set
		End Property

		' Token: 0x170001C1 RID: 449
		' (get) Token: 0x06000588 RID: 1416 RVA: 0x00049740 File Offset: 0x00047B40
		' (set) Token: 0x06000589 RID: 1417 RVA: 0x00049754 File Offset: 0x00047B54
		Friend Overridable Property S1postxt As TextBox
			<DebuggerNonUserCode()>
			Get
				Return Me._S1postxt
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As EventHandler = AddressOf Me.S1postxt_Leave
				If Me._S1postxt IsNot Nothing Then
					RemoveHandler Me._S1postxt.Leave, value2
				End If
				Me._S1postxt = value
				If Me._S1postxt IsNot Nothing Then
					AddHandler Me._S1postxt.Leave, value2
				End If
			End Set
		End Property

		' Token: 0x170001C2 RID: 450
		' (get) Token: 0x0600058A RID: 1418 RVA: 0x000497A0 File Offset: 0x00047BA0
		' (set) Token: 0x0600058B RID: 1419 RVA: 0x000497B4 File Offset: 0x00047BB4
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

		' Token: 0x170001C3 RID: 451
		' (get) Token: 0x0600058C RID: 1420 RVA: 0x000497C0 File Offset: 0x00047BC0
		' (set) Token: 0x0600058D RID: 1421 RVA: 0x000497D4 File Offset: 0x00047BD4
		Friend Overridable Property Usrfrmtxt As TextBox
			<DebuggerNonUserCode()>
			Get
				Return Me._Usrfrmtxt
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Me._Usrfrmtxt = value
			End Set
		End Property

		' Token: 0x170001C4 RID: 452
		' (get) Token: 0x0600058E RID: 1422 RVA: 0x000497E0 File Offset: 0x00047BE0
		' (set) Token: 0x0600058F RID: 1423 RVA: 0x000497F4 File Offset: 0x00047BF4
		Friend Overridable Property Cnfrm_btn As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._Cnfrm_btn
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = AddressOf Me.Cnfrm_btn_Click
				If Me._Cnfrm_btn IsNot Nothing Then
					RemoveHandler Me._Cnfrm_btn.Click, value2
				End If
				Me._Cnfrm_btn = value
				If Me._Cnfrm_btn IsNot Nothing Then
					AddHandler Me._Cnfrm_btn.Click, value2
				End If
			End Set
		End Property

		' Token: 0x170001C5 RID: 453
		' (get) Token: 0x06000590 RID: 1424 RVA: 0x00049840 File Offset: 0x00047C40
		' (set) Token: 0x06000591 RID: 1425 RVA: 0x00049854 File Offset: 0x00047C54
		Friend Overridable Property Cncl_btn As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._Cncl_btn
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = AddressOf Me.Cncl_btn_Click
				If Me._Cncl_btn IsNot Nothing Then
					RemoveHandler Me._Cncl_btn.Click, value2
				End If
				Me._Cncl_btn = value
				If Me._Cncl_btn IsNot Nothing Then
					AddHandler Me._Cncl_btn.Click, value2
				End If
			End Set
		End Property

		' Token: 0x170001C6 RID: 454
		' (get) Token: 0x06000592 RID: 1426 RVA: 0x000498A0 File Offset: 0x00047CA0
		' (set) Token: 0x06000593 RID: 1427 RVA: 0x000498B4 File Offset: 0x00047CB4
		Friend Overridable Property Upload_btn As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._Upload_btn
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = AddressOf Me.Upload_btn_Click
				If Me._Upload_btn IsNot Nothing Then
					RemoveHandler Me._Upload_btn.Click, value2
				End If
				Me._Upload_btn = value
				If Me._Upload_btn IsNot Nothing Then
					AddHandler Me._Upload_btn.Click, value2
				End If
			End Set
		End Property

		' Token: 0x170001C7 RID: 455
		' (get) Token: 0x06000594 RID: 1428 RVA: 0x00049900 File Offset: 0x00047D00
		' (set) Token: 0x06000595 RID: 1429 RVA: 0x00049914 File Offset: 0x00047D14
		Friend Overridable Property Label6 As Label
			<DebuggerNonUserCode()>
			Get
				Return Me._Label6
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._Label6 = value
			End Set
		End Property

		' Token: 0x170001C8 RID: 456
		' (get) Token: 0x06000596 RID: 1430 RVA: 0x00049920 File Offset: 0x00047D20
		' (set) Token: 0x06000597 RID: 1431 RVA: 0x00049934 File Offset: 0x00047D34
		Friend Overridable Property Label5 As Label
			<DebuggerNonUserCode()>
			Get
				Return Me._Label5
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._Label5 = value
			End Set
		End Property

		' Token: 0x170001C9 RID: 457
		' (get) Token: 0x06000598 RID: 1432 RVA: 0x00049940 File Offset: 0x00047D40
		' (set) Token: 0x06000599 RID: 1433 RVA: 0x00049954 File Offset: 0x00047D54
		Friend Overridable Property Label4 As Label
			<DebuggerNonUserCode()>
			Get
				Return Me._Label4
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._Label4 = value
			End Set
		End Property

		' Token: 0x170001CA RID: 458
		' (get) Token: 0x0600059A RID: 1434 RVA: 0x00049960 File Offset: 0x00047D60
		' (set) Token: 0x0600059B RID: 1435 RVA: 0x00049974 File Offset: 0x00047D74
		Friend Overridable Property Label3 As Label
			<DebuggerNonUserCode()>
			Get
				Return Me._Label3
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._Label3 = value
			End Set
		End Property

		' Token: 0x170001CB RID: 459
		' (get) Token: 0x0600059C RID: 1436 RVA: 0x00049980 File Offset: 0x00047D80
		' (set) Token: 0x0600059D RID: 1437 RVA: 0x00049994 File Offset: 0x00047D94
		Friend Overridable Property Label2 As Label
			<DebuggerNonUserCode()>
			Get
				Return Me._Label2
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._Label2 = value
			End Set
		End Property

		' Token: 0x170001CC RID: 460
		' (get) Token: 0x0600059E RID: 1438 RVA: 0x000499A0 File Offset: 0x00047DA0
		' (set) Token: 0x0600059F RID: 1439 RVA: 0x000499B4 File Offset: 0x00047DB4
		Friend Overridable Property Label1 As Label
			<DebuggerNonUserCode()>
			Get
				Return Me._Label1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._Label1 = value
			End Set
		End Property

		' Token: 0x170001CD RID: 461
		' (get) Token: 0x060005A0 RID: 1440 RVA: 0x000499C0 File Offset: 0x00047DC0
		' (set) Token: 0x060005A1 RID: 1441 RVA: 0x000499D4 File Offset: 0x00047DD4
		Friend Overridable Property Label8 As Label
			<DebuggerNonUserCode()>
			Get
				Return Me._Label8
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._Label8 = value
			End Set
		End Property

		' Token: 0x170001CE RID: 462
		' (get) Token: 0x060005A2 RID: 1442 RVA: 0x000499E0 File Offset: 0x00047DE0
		' (set) Token: 0x060005A3 RID: 1443 RVA: 0x000499F4 File Offset: 0x00047DF4
		Friend Overridable Property Label7 As Label
			<DebuggerNonUserCode()>
			Get
				Return Me._Label7
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._Label7 = value
			End Set
		End Property

		' Token: 0x060005A4 RID: 1444 RVA: 0x00049A00 File Offset: 0x00047E00
		Private Sub Upload_btn_Click(sender As Object, e As EventArgs)
			Dim TempPos As Double() = New Double(12) {}
			If Positioncal.ConectStat = 1S Then
				MotoCom32.BscSetCtrlGroupDx(CShort(Connection.nCid), 1, 1)
				Dim nCid As Short = CShort(Connection.nCid)
				Dim isex As Short = 1S
				Dim num As Short = CShort(Me.Rconf)
				Dim num2 As Short = CShort(Me.Toolno)
				MotoCom32.BscIsRobotPos(nCid, Me.Uframe, isex, num, num2, TempPos(0))
				Me.Toolno = CInt(num2)
				Me.Rconf = CInt(num)
				Me.Usrfrmtxt.Text = Me.Uframe
				Me.Xpostxt.Text = TempPos(0).ToString("#0.000")
				Me.Ypostxt.Text = TempPos(1).ToString("#0.000")
				Me.Zpostxt.Text = TempPos(2).ToString("#0.000")
				Me.Rxpostxt.Text = TempPos(3).ToString("#0.000")
				Me.Rypostxt.Text = TempPos(4).ToString("#0.000")
				Me.Rzpostxt.Text = TempPos(5).ToString("#0.000")
				Me.S1postxt.Text = TempPos(6).ToString("#0.000")
				Me.S2postxt.Text = TempPos(7).ToString("#0.000")
				Me.Cnfrm_btn.Enabled = True
			Else
				' The following expression was wrapped in a unchecked-expression
				Connection.Ms_BscOpenComm(Positioncal.ipaddress, Positioncal.BasePath, 0, CLng(Me.Handle.ToInt32()))
				If Connection.ret = 1 Then
					MotoCom32.BscSetCtrlGroupDx(CShort(Connection.nCid), 1, 1)
					Dim nCid2 As Short = CShort(Connection.nCid)
					Dim isex2 As Short = 1S
					Dim num2 As Short = CShort(Me.Rconf)
					Dim num As Short = CShort(Me.Toolno)
					MotoCom32.BscIsRobotPos(nCid2, Me.Uframe, isex2, num2, num, Positioncal.Position(0, 0))
					Me.Toolno = CInt(num)
					Me.Rconf = CInt(num2)
					Me.Usrfrmtxt.Text = Me.Uframe
					Me.Xpostxt.Text = TempPos(0).ToString("#0.000")
					Me.Ypostxt.Text = TempPos(1).ToString("#0.000")
					Me.Zpostxt.Text = TempPos(2).ToString("#0.000")
					Me.Rxpostxt.Text = TempPos(3).ToString("#0.000")
					Me.Rypostxt.Text = TempPos(4).ToString("#0.000")
					Me.Rzpostxt.Text = TempPos(5).ToString("#0.000")
					Me.S1postxt.Text = TempPos(6).ToString("#0.000")
					Me.S2postxt.Text = TempPos(7).ToString("#0.000")
					Me.Cnfrm_btn.Enabled = True
				End If
				Connection.MS_BscCloseComm(Connection.nCid)
			End If
		End Sub

		' Token: 0x060005A5 RID: 1445 RVA: 0x00049CF0 File Offset: 0x000480F0
		Private Sub Cnfrm_btn_Click(sender As Object, e As EventArgs)
			Positioncal.Position(0, 0) = Conversions.ToDouble(Me.Xpostxt.Text)
			Positioncal.Position(1, 0) = Conversions.ToDouble(Me.Ypostxt.Text)
			Positioncal.Position(2, 0) = Conversions.ToDouble(Me.Zpostxt.Text)
			Positioncal.Position(3, 0) = Conversions.ToDouble(Me.Rxpostxt.Text)
			Positioncal.Position(4, 0) = Conversions.ToDouble(Me.Rypostxt.Text)
			Positioncal.Position(5, 0) = Conversions.ToDouble(Me.Rzpostxt.Text)
			Positioncal.Position(6, 0) = Conversions.ToDouble(Me.S1postxt.Text)
			Positioncal.Position(7, 0) = Conversions.ToDouble(Me.S2postxt.Text)
			Me.DialogResult = DialogResult.OK
			Me.Close()
		End Sub

		' Token: 0x060005A6 RID: 1446 RVA: 0x00049DEC File Offset: 0x000481EC
		Private Sub Posıtıonupload_Load(sender As Object, e As EventArgs)
			Me.Cnfrm_btn.Enabled = False
			Select Case Positioncal.StationPosition
				Case 1
					Me.Uframe = "UF1"
				Case 2
					Me.Uframe = "UF2"
				Case 3
					Me.Uframe = "UF3"
				Case 4
					Me.Uframe = "UF4"
				Case 5
					Me.Uframe = "UF5"
			End Select
			Me.Usrfrmtxt.Text = Me.Uframe
			Me.Xpostxt.Text = "0.000"
			Me.Ypostxt.Text = "0.000"
			Me.Zpostxt.Text = "0.000"
			Me.Rxpostxt.Text = "0.000"
			Me.Rypostxt.Text = "0.000"
			Me.Rzpostxt.Text = "0.000"
			Me.S1postxt.Text = "0.000"
			Me.S2postxt.Text = "0.000"
		End Sub

		' Token: 0x060005A7 RID: 1447 RVA: 0x00049EF8 File Offset: 0x000482F8
		Private Sub Cncl_btn_Click(sender As Object, e As EventArgs)
			Me.Close()
		End Sub

		' Token: 0x060005A8 RID: 1448 RVA: 0x00049F00 File Offset: 0x00048300
		Private Sub Xpostxt_Leave(sender As Object, e As EventArgs)
			If Versioned.IsNumeric(Me.Xpostxt.Text) Then
				Dim value As Double = Conversions.ToDouble(Me.Xpostxt.Text)
				Me.Xpostxt.Text = value.ToString("#0.0")
				Positioncal.Position(0, 0) = Conversions.ToDouble(Me.Xpostxt.Text)
			Else
				Interaction.MsgBox("This is not a valid number", MsgBoxStyle.Exclamation, Nothing)
				Me.Xpostxt.Text = Positioncal.Position(0, 0).ToString("#0.0")
			End If
		End Sub

		' Token: 0x060005A9 RID: 1449 RVA: 0x00049F94 File Offset: 0x00048394
		Private Sub Ypostxt_Leave(sender As Object, e As EventArgs)
			If Versioned.IsNumeric(Me.Ypostxt.Text) Then
				Dim value As Double = Conversions.ToDouble(Me.Ypostxt.Text)
				Me.Ypostxt.Text = value.ToString("#0.0")
				Positioncal.Position(1, 0) = Conversions.ToDouble(Me.Ypostxt.Text)
			Else
				Interaction.MsgBox("This is not a valid number", MsgBoxStyle.Exclamation, Nothing)
				Me.Ypostxt.Text = Positioncal.Position(1, 0).ToString("#0.0")
			End If
		End Sub

		' Token: 0x060005AA RID: 1450 RVA: 0x0004A028 File Offset: 0x00048428
		Private Sub Zpostxt_Leave(sender As Object, e As EventArgs)
			If Versioned.IsNumeric(Me.Zpostxt.Text) Then
				Dim value As Double = Conversions.ToDouble(Me.Zpostxt.Text)
				Me.Zpostxt.Text = value.ToString("#0.0")
				Positioncal.Position(2, 0) = Conversions.ToDouble(Me.Zpostxt.Text)
			Else
				Interaction.MsgBox("This is not a valid number", MsgBoxStyle.Exclamation, Nothing)
				Me.Zpostxt.Text = Positioncal.Position(2, 0).ToString("#0.0")
			End If
		End Sub

		' Token: 0x060005AB RID: 1451 RVA: 0x0004A0BC File Offset: 0x000484BC
		Private Sub Rxpostxt_Leave(sender As Object, e As EventArgs)
			If Versioned.IsNumeric(Me.Rxpostxt.Text) Then
				Dim value As Double = Conversions.ToDouble(Me.Rxpostxt.Text)
				Me.Rxpostxt.Text = value.ToString("#0.0")
				Positioncal.Position(3, 0) = Conversions.ToDouble(Me.Rxpostxt.Text)
			Else
				Interaction.MsgBox("This is not a valid number", MsgBoxStyle.Exclamation, Nothing)
				Me.Rxpostxt.Text = Positioncal.Position(3, 0).ToString("#0.0")
			End If
		End Sub

		' Token: 0x060005AC RID: 1452 RVA: 0x0004A150 File Offset: 0x00048550
		Private Sub Rypostxt_Leave(sender As Object, e As EventArgs)
			If Versioned.IsNumeric(Me.Rypostxt.Text) Then
				Dim value As Double = Conversions.ToDouble(Me.Rypostxt.Text)
				Me.Rypostxt.Text = value.ToString("#0.0")
				Positioncal.Position(4, 0) = Conversions.ToDouble(Me.Rypostxt.Text)
			Else
				Interaction.MsgBox("This is not a valid number", MsgBoxStyle.Exclamation, Nothing)
				Me.Rypostxt.Text = Positioncal.Position(4, 0).ToString("#0.0")
			End If
		End Sub

		' Token: 0x060005AD RID: 1453 RVA: 0x0004A1E4 File Offset: 0x000485E4
		Private Sub Rzpostxt_Leave(sender As Object, e As EventArgs)
			If Versioned.IsNumeric(Me.Rzpostxt.Text) Then
				Dim value As Double = Conversions.ToDouble(Me.Rzpostxt.Text)
				Me.Rzpostxt.Text = value.ToString("#0.0")
				Positioncal.Position(5, 0) = Conversions.ToDouble(Me.Rzpostxt.Text)
			Else
				Interaction.MsgBox("This is not a valid number", MsgBoxStyle.Exclamation, Nothing)
				Me.Rzpostxt.Text = Positioncal.Position(5, 0).ToString("#0.0")
			End If
		End Sub

		' Token: 0x060005AE RID: 1454 RVA: 0x0004A278 File Offset: 0x00048678
		Private Sub S1postxt_Leave(sender As Object, e As EventArgs)
			If Versioned.IsNumeric(Me.S1postxt.Text) Then
				Dim value As Double = Conversions.ToDouble(Me.S1postxt.Text)
				Me.S1postxt.Text = value.ToString("#0.0")
				Positioncal.Position(6, 0) = Conversions.ToDouble(Me.S1postxt.Text)
			Else
				Interaction.MsgBox("This is not a valid number", MsgBoxStyle.Exclamation, Nothing)
				Me.S1postxt.Text = Positioncal.Position(6, 0).ToString("#0.0")
			End If
		End Sub

		' Token: 0x060005AF RID: 1455 RVA: 0x0004A30C File Offset: 0x0004870C
		Private Sub S2postxt_Leave(sender As Object, e As EventArgs)
			If Versioned.IsNumeric(Me.S2postxt.Text) Then
				Dim value As Double = Conversions.ToDouble(Me.S2postxt.Text)
				Me.S2postxt.Text = value.ToString("#0.0")
				Positioncal.Position(7, 0) = Conversions.ToDouble(Me.S2postxt.Text)
			Else
				Interaction.MsgBox("This is not a valid number", MsgBoxStyle.Exclamation, Nothing)
				Me.S2postxt.Text = Positioncal.Position(7, 0).ToString("#0.0")
			End If
		End Sub

		' Token: 0x04000247 RID: 583
		<AccessedThroughProperty("Xpostxt")>
		Private _Xpostxt As TextBox

		' Token: 0x04000248 RID: 584
		<AccessedThroughProperty("GroupBox1")>
		Private _GroupBox1 As GroupBox

		' Token: 0x04000249 RID: 585
		<AccessedThroughProperty("Rzpostxt")>
		Private _Rzpostxt As TextBox

		' Token: 0x0400024A RID: 586
		<AccessedThroughProperty("Rypostxt")>
		Private _Rypostxt As TextBox

		' Token: 0x0400024B RID: 587
		<AccessedThroughProperty("Rxpostxt")>
		Private _Rxpostxt As TextBox

		' Token: 0x0400024C RID: 588
		<AccessedThroughProperty("Zpostxt")>
		Private _Zpostxt As TextBox

		' Token: 0x0400024D RID: 589
		<AccessedThroughProperty("Ypostxt")>
		Private _Ypostxt As TextBox

		' Token: 0x0400024E RID: 590
		<AccessedThroughProperty("GroupBox2")>
		Private _GroupBox2 As GroupBox

		' Token: 0x0400024F RID: 591
		<AccessedThroughProperty("S2postxt")>
		Private _S2postxt As TextBox

		' Token: 0x04000250 RID: 592
		<AccessedThroughProperty("S1postxt")>
		Private _S1postxt As TextBox

		' Token: 0x04000251 RID: 593
		<AccessedThroughProperty("GroupBox3")>
		Private _GroupBox3 As GroupBox

		' Token: 0x04000252 RID: 594
		<AccessedThroughProperty("Usrfrmtxt")>
		Private _Usrfrmtxt As TextBox

		' Token: 0x04000253 RID: 595
		<AccessedThroughProperty("Cnfrm_btn")>
		Private _Cnfrm_btn As Button

		' Token: 0x04000254 RID: 596
		<AccessedThroughProperty("Cncl_btn")>
		Private _Cncl_btn As Button

		' Token: 0x04000255 RID: 597
		<AccessedThroughProperty("Upload_btn")>
		Private _Upload_btn As Button

		' Token: 0x04000256 RID: 598
		<AccessedThroughProperty("Label6")>
		Private _Label6 As Label

		' Token: 0x04000257 RID: 599
		<AccessedThroughProperty("Label5")>
		Private _Label5 As Label

		' Token: 0x04000258 RID: 600
		<AccessedThroughProperty("Label4")>
		Private _Label4 As Label

		' Token: 0x04000259 RID: 601
		<AccessedThroughProperty("Label3")>
		Private _Label3 As Label

		' Token: 0x0400025A RID: 602
		<AccessedThroughProperty("Label2")>
		Private _Label2 As Label

		' Token: 0x0400025B RID: 603
		<AccessedThroughProperty("Label1")>
		Private _Label1 As Label

		' Token: 0x0400025C RID: 604
		<AccessedThroughProperty("Label8")>
		Private _Label8 As Label

		' Token: 0x0400025D RID: 605
		<AccessedThroughProperty("Label7")>
		Private _Label7 As Label

		' Token: 0x0400025E RID: 606
		Private Uframe As String

		' Token: 0x0400025F RID: 607
		Private Toolno As Integer

		' Token: 0x04000260 RID: 608
		Private Rconf As Integer
	End Class
End Namespace
