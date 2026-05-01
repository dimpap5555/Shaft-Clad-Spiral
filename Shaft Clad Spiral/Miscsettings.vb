Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.IO
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

Namespace WindowsApplication1
	' Token: 0x02000012 RID: 18
	<DesignerGenerated()>
	Public Partial Class Miscsettings
		Inherits Form

		' Token: 0x0600033D RID: 829 RVA: 0x00038A50 File Offset: 0x00036E50
		<DebuggerNonUserCode()>
		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.Miscsettings_Load
			Me.InitializeComponent()
		End Sub

		' Token: 0x17000130 RID: 304
		' (get) Token: 0x06000340 RID: 832 RVA: 0x0003A510 File Offset: 0x00038910
		' (set) Token: 0x06000341 RID: 833 RVA: 0x0003A524 File Offset: 0x00038924
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

		' Token: 0x17000131 RID: 305
		' (get) Token: 0x06000342 RID: 834 RVA: 0x0003A530 File Offset: 0x00038930
		' (set) Token: 0x06000343 RID: 835 RVA: 0x0003A544 File Offset: 0x00038944
		Friend Overridable Property Horoffsettxt As TextBox
			<DebuggerNonUserCode()>
			Get
				Return Me._Horoffsettxt
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As EventHandler = AddressOf Me.Horoffsettxt_Leave
				If Me._Horoffsettxt IsNot Nothing Then
					RemoveHandler Me._Horoffsettxt.Leave, value2
				End If
				Me._Horoffsettxt = value
				If Me._Horoffsettxt IsNot Nothing Then
					AddHandler Me._Horoffsettxt.Leave, value2
				End If
			End Set
		End Property

		' Token: 0x17000132 RID: 306
		' (get) Token: 0x06000344 RID: 836 RVA: 0x0003A590 File Offset: 0x00038990
		' (set) Token: 0x06000345 RID: 837 RVA: 0x0003A5A4 File Offset: 0x000389A4
		Friend Overridable Property Idlesptxt As TextBox
			<DebuggerNonUserCode()>
			Get
				Return Me._Idlesptxt
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As EventHandler = AddressOf Me.Idlesptxt_Leave
				If Me._Idlesptxt IsNot Nothing Then
					RemoveHandler Me._Idlesptxt.Leave, value2
				End If
				Me._Idlesptxt = value
				If Me._Idlesptxt IsNot Nothing Then
					AddHandler Me._Idlesptxt.Leave, value2
				End If
			End Set
		End Property

		' Token: 0x17000133 RID: 307
		' (get) Token: 0x06000346 RID: 838 RVA: 0x0003A5F0 File Offset: 0x000389F0
		' (set) Token: 0x06000347 RID: 839 RVA: 0x0003A604 File Offset: 0x00038A04
		Friend Overridable Property Diamoffsettxt As TextBox
			<DebuggerNonUserCode()>
			Get
				Return Me._Diamoffsettxt
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As EventHandler = AddressOf Me.Diamoffsettxt_Leave
				If Me._Diamoffsettxt IsNot Nothing Then
					RemoveHandler Me._Diamoffsettxt.Leave, value2
				End If
				Me._Diamoffsettxt = value
				If Me._Diamoffsettxt IsNot Nothing Then
					AddHandler Me._Diamoffsettxt.Leave, value2
				End If
			End Set
		End Property

		' Token: 0x17000134 RID: 308
		' (get) Token: 0x06000348 RID: 840 RVA: 0x0003A650 File Offset: 0x00038A50
		' (set) Token: 0x06000349 RID: 841 RVA: 0x0003A664 File Offset: 0x00038A64
		Friend Overridable Property Approsptxt As TextBox
			<DebuggerNonUserCode()>
			Get
				Return Me._Approsptxt
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As EventHandler = AddressOf Me.Approsptxt_Leave
				If Me._Approsptxt IsNot Nothing Then
					RemoveHandler Me._Approsptxt.Leave, value2
				End If
				Me._Approsptxt = value
				If Me._Approsptxt IsNot Nothing Then
					AddHandler Me._Approsptxt.Leave, value2
				End If
			End Set
		End Property

		' Token: 0x17000135 RID: 309
		' (get) Token: 0x0600034A RID: 842 RVA: 0x0003A6B0 File Offset: 0x00038AB0
		' (set) Token: 0x0600034B RID: 843 RVA: 0x0003A6C4 File Offset: 0x00038AC4
		Friend Overridable Property Distanceoffsettxt As TextBox
			<DebuggerNonUserCode()>
			Get
				Return Me._Distanceoffsettxt
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As EventHandler = AddressOf Me.Distanceoffsettxt_Leave
				If Me._Distanceoffsettxt IsNot Nothing Then
					RemoveHandler Me._Distanceoffsettxt.Leave, value2
				End If
				Me._Distanceoffsettxt = value
				If Me._Distanceoffsettxt IsNot Nothing Then
					AddHandler Me._Distanceoffsettxt.Leave, value2
				End If
			End Set
		End Property

		' Token: 0x17000136 RID: 310
		' (get) Token: 0x0600034C RID: 844 RVA: 0x0003A710 File Offset: 0x00038B10
		' (set) Token: 0x0600034D RID: 845 RVA: 0x0003A724 File Offset: 0x00038B24
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

		' Token: 0x17000137 RID: 311
		' (get) Token: 0x0600034E RID: 846 RVA: 0x0003A770 File Offset: 0x00038B70
		' (set) Token: 0x0600034F RID: 847 RVA: 0x0003A784 File Offset: 0x00038B84
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

		' Token: 0x17000138 RID: 312
		' (get) Token: 0x06000350 RID: 848 RVA: 0x0003A7D0 File Offset: 0x00038BD0
		' (set) Token: 0x06000351 RID: 849 RVA: 0x0003A7E4 File Offset: 0x00038BE4
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

		' Token: 0x17000139 RID: 313
		' (get) Token: 0x06000352 RID: 850 RVA: 0x0003A7F0 File Offset: 0x00038BF0
		' (set) Token: 0x06000353 RID: 851 RVA: 0x0003A804 File Offset: 0x00038C04
		Friend Overridable Property Powderset1txt As TextBox
			<DebuggerNonUserCode()>
			Get
				Return Me._Powderset1txt
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As EventHandler = AddressOf Me.Powderset1txt_Leave
				If Me._Powderset1txt IsNot Nothing Then
					RemoveHandler Me._Powderset1txt.Leave, value2
				End If
				Me._Powderset1txt = value
				If Me._Powderset1txt IsNot Nothing Then
					AddHandler Me._Powderset1txt.Leave, value2
				End If
			End Set
		End Property

		' Token: 0x1700013A RID: 314
		' (get) Token: 0x06000354 RID: 852 RVA: 0x0003A850 File Offset: 0x00038C50
		' (set) Token: 0x06000355 RID: 853 RVA: 0x0003A864 File Offset: 0x00038C64
		Friend Overridable Property Powderset2txt As TextBox
			<DebuggerNonUserCode()>
			Get
				Return Me._Powderset2txt
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As EventHandler = AddressOf Me.Powderset2txt_Leave
				If Me._Powderset2txt IsNot Nothing Then
					RemoveHandler Me._Powderset2txt.Leave, value2
				End If
				Me._Powderset2txt = value
				If Me._Powderset2txt IsNot Nothing Then
					AddHandler Me._Powderset2txt.Leave, value2
				End If
			End Set
		End Property

		' Token: 0x1700013B RID: 315
		' (get) Token: 0x06000356 RID: 854 RVA: 0x0003A8B0 File Offset: 0x00038CB0
		' (set) Token: 0x06000357 RID: 855 RVA: 0x0003A8C4 File Offset: 0x00038CC4
		Friend Overridable Property Positionleveltxt As TextBox
			<DebuggerNonUserCode()>
			Get
				Return Me._Positionleveltxt
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As EventHandler = AddressOf Me.Positionleveltxt_Leave
				If Me._Positionleveltxt IsNot Nothing Then
					RemoveHandler Me._Positionleveltxt.Leave, value2
				End If
				Me._Positionleveltxt = value
				If Me._Positionleveltxt IsNot Nothing Then
					AddHandler Me._Positionleveltxt.Leave, value2
				End If
			End Set
		End Property

		' Token: 0x1700013C RID: 316
		' (get) Token: 0x06000358 RID: 856 RVA: 0x0003A910 File Offset: 0x00038D10
		' (set) Token: 0x06000359 RID: 857 RVA: 0x0003A924 File Offset: 0x00038D24
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

		' Token: 0x1700013D RID: 317
		' (get) Token: 0x0600035A RID: 858 RVA: 0x0003A930 File Offset: 0x00038D30
		' (set) Token: 0x0600035B RID: 859 RVA: 0x0003A944 File Offset: 0x00038D44
		Friend Overridable Property Reversedirflg As RadioButton
			<DebuggerNonUserCode()>
			Get
				Return Me._Reversedirflg
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As RadioButton)
				Me._Reversedirflg = value
			End Set
		End Property

		' Token: 0x1700013E RID: 318
		' (get) Token: 0x0600035C RID: 860 RVA: 0x0003A950 File Offset: 0x00038D50
		' (set) Token: 0x0600035D RID: 861 RVA: 0x0003A964 File Offset: 0x00038D64
		Friend Overridable Property Forwarddirflg As RadioButton
			<DebuggerNonUserCode()>
			Get
				Return Me._Forwarddirflg
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As RadioButton)
				Me._Forwarddirflg = value
			End Set
		End Property

		' Token: 0x1700013F RID: 319
		' (get) Token: 0x0600035E RID: 862 RVA: 0x0003A970 File Offset: 0x00038D70
		' (set) Token: 0x0600035F RID: 863 RVA: 0x0003A984 File Offset: 0x00038D84
		Friend Overridable Property Mindistxt As TextBox
			<DebuggerNonUserCode()>
			Get
				Return Me._Mindistxt
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Me._Mindistxt = value
			End Set
		End Property

		' Token: 0x17000140 RID: 320
		' (get) Token: 0x06000360 RID: 864 RVA: 0x0003A990 File Offset: 0x00038D90
		' (set) Token: 0x06000361 RID: 865 RVA: 0x0003A9A4 File Offset: 0x00038DA4
		Friend Overridable Property WorkXofftxt As TextBox
			<DebuggerNonUserCode()>
			Get
				Return Me._WorkXofftxt
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As EventHandler = AddressOf Me.WorkXofftxt_leave
				If Me._WorkXofftxt IsNot Nothing Then
					RemoveHandler Me._WorkXofftxt.Leave, value2
				End If
				Me._WorkXofftxt = value
				If Me._WorkXofftxt IsNot Nothing Then
					AddHandler Me._WorkXofftxt.Leave, value2
				End If
			End Set
		End Property

		' Token: 0x17000141 RID: 321
		' (get) Token: 0x06000362 RID: 866 RVA: 0x0003A9F0 File Offset: 0x00038DF0
		' (set) Token: 0x06000363 RID: 867 RVA: 0x0003AA04 File Offset: 0x00038E04
		Friend Overridable Property Pprtxt As TextBox
			<DebuggerNonUserCode()>
			Get
				Return Me._Pprtxt
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As EventHandler = AddressOf Me.Pprtxt_Leave
				If Me._Pprtxt IsNot Nothing Then
					RemoveHandler Me._Pprtxt.Leave, value2
				End If
				Me._Pprtxt = value
				If Me._Pprtxt IsNot Nothing Then
					AddHandler Me._Pprtxt.Leave, value2
				End If
			End Set
		End Property

		' Token: 0x17000142 RID: 322
		' (get) Token: 0x06000364 RID: 868 RVA: 0x0003AA50 File Offset: 0x00038E50
		' (set) Token: 0x06000365 RID: 869 RVA: 0x0003AA64 File Offset: 0x00038E64
		Friend Overridable Property Tiltangtxt As TextBox
			<DebuggerNonUserCode()>
			Get
				Return Me._Tiltangtxt
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As EventHandler = AddressOf Me.Tiltangtxt_Leave
				If Me._Tiltangtxt IsNot Nothing Then
					RemoveHandler Me._Tiltangtxt.Leave, value2
				End If
				Me._Tiltangtxt = value
				If Me._Tiltangtxt IsNot Nothing Then
					AddHandler Me._Tiltangtxt.Leave, value2
				End If
			End Set
		End Property

		' Token: 0x17000143 RID: 323
		' (get) Token: 0x06000366 RID: 870 RVA: 0x0003AAB0 File Offset: 0x00038EB0
		' (set) Token: 0x06000367 RID: 871 RVA: 0x0003AAC4 File Offset: 0x00038EC4
		Friend Overridable Property MaxZRobotPostxt As TextBox
			<DebuggerNonUserCode()>
			Get
				Return Me._MaxZRobotPostxt
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As EventHandler = AddressOf Me.MaxZRobotPostxt_Leave
				If Me._MaxZRobotPostxt IsNot Nothing Then
					RemoveHandler Me._MaxZRobotPostxt.Leave, value2
				End If
				Me._MaxZRobotPostxt = value
				If Me._MaxZRobotPostxt IsNot Nothing Then
					AddHandler Me._MaxZRobotPostxt.Leave, value2
				End If
			End Set
		End Property

		' Token: 0x17000144 RID: 324
		' (get) Token: 0x06000368 RID: 872 RVA: 0x0003AB10 File Offset: 0x00038F10
		' (set) Token: 0x06000369 RID: 873 RVA: 0x0003AB24 File Offset: 0x00038F24
		Friend Overridable Property WorkZAxisYawtxt As TextBox
			<DebuggerNonUserCode()>
			Get
				Return Me._WorkZAxisYawtxt
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As EventHandler = AddressOf Me.WorkZAxisYawtxt_leave
				If Me._WorkZAxisYawtxt IsNot Nothing Then
					RemoveHandler Me._WorkZAxisYawtxt.Leave, value2
				End If
				Me._WorkZAxisYawtxt = value
				If Me._WorkZAxisYawtxt IsNot Nothing Then
					AddHandler Me._WorkZAxisYawtxt.Leave, value2
				End If
			End Set
		End Property

		' Token: 0x17000145 RID: 325
		' (get) Token: 0x0600036A RID: 874 RVA: 0x0003AB70 File Offset: 0x00038F70
		' (set) Token: 0x0600036B RID: 875 RVA: 0x0003AB84 File Offset: 0x00038F84
		Friend Overridable Property WorkYAxisTilttxt As TextBox
			<DebuggerNonUserCode()>
			Get
				Return Me._WorkYAxisTilttxt
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As EventHandler = AddressOf Me.WorkYAxisTilttxt_TextChanged
				If Me._WorkYAxisTilttxt IsNot Nothing Then
					RemoveHandler Me._WorkYAxisTilttxt.Leave, value2
				End If
				Me._WorkYAxisTilttxt = value
				If Me._WorkYAxisTilttxt IsNot Nothing Then
					AddHandler Me._WorkYAxisTilttxt.Leave, value2
				End If
			End Set
		End Property

		' Token: 0x0600036C RID: 876 RVA: 0x0003ABD0 File Offset: 0x00038FD0
		Private Sub Miscsettings_Load(sender As Object, e As EventArgs)
			Me.Idlesptxt.Text = Positioncal.IdleSpeed.ToString("#0.0")
			Me.Approsptxt.Text = Positioncal.ApproachSpeed.ToString("#0.0")
			Me.Distanceoffsettxt.Text = Positioncal.IniYAxisOffset.ToString("#0.0")
			Me.Diamoffsettxt.Text = Positioncal.IniZAxisOffset.ToString("#0.0")
			Me.Horoffsettxt.Text = Positioncal.IniXAxisOffset.ToString("#0.0")
			Me.WorkXofftxt.Text = Positioncal.WorkXAxisOffset.ToString("#0.0")
			Me.WorkYAxisTilttxt.Text = Positioncal.WorkYAxisTilt.ToString("#0.00")
			Me.WorkZAxisYawtxt.Text = Positioncal.WorkZAxisYaw.ToString("#0.00")
			Me.Powderset1txt.Text = Positioncal.PowderSettling1.ToString("#0.0")
			Me.Powderset2txt.Text = Positioncal.PowderSettling2.ToString("#0.0")
			Me.Positionleveltxt.Text = Positioncal.PositionLevel.ToString("#0")
			Me.Pprtxt.Text = Positioncal.PPR.ToString("#0")
			Me.Tiltangtxt.Text = Positioncal.Tiltangle.ToString("#0.00")
			Me.Mindistxt.Text = Positioncal.MinDistance.ToString("#0.0")
			Me.MaxZRobotPostxt.Text = (Positioncal.MaxZRobotPos / 1000.0).ToString("#0.0")
			If Positioncal.DirectionFlg = 1 Then
				Me.Forwarddirflg.Checked = True
			Else
				Me.Reversedirflg.Checked = True
			End If
		End Sub

		' Token: 0x0600036D RID: 877 RVA: 0x0003AD94 File Offset: 0x00039194
		Private Sub Cnfrmbtn_Click(sender As Object, e As EventArgs)
			Dim fs As FileStream = New FileStream(Application.StartupPath + "\miscsettings.txt", FileMode.Create)
			Dim w As StreamWriter = New StreamWriter(fs)
			Positioncal.IdleSpeed = Conversions.ToDouble(Me.Idlesptxt.Text)
			Positioncal.ApproachSpeed = Conversions.ToDouble(Me.Approsptxt.Text)
			Positioncal.IniYAxisOffset = Conversions.ToDouble(Me.Distanceoffsettxt.Text)
			Positioncal.IniZAxisOffset = Conversions.ToDouble(Me.Diamoffsettxt.Text)
			Positioncal.IniXAxisOffset = Conversions.ToDouble(Me.Horoffsettxt.Text)
			Positioncal.WorkXAxisOffset = Conversions.ToDouble(Me.WorkXofftxt.Text)
			Positioncal.WorkYAxisTilt = Conversions.ToDouble(Me.WorkYAxisTilttxt.Text)
			Positioncal.WorkZAxisYaw = Conversions.ToDouble(Me.WorkZAxisYawtxt.Text)
			Positioncal.PowderSettling1 = Conversions.ToDouble(Me.Powderset1txt.Text)
			Positioncal.PowderSettling2 = Conversions.ToDouble(Me.Powderset2txt.Text)
			Positioncal.PositionLevel = Conversions.ToInteger(Me.Positionleveltxt.Text)
			Positioncal.PPR = Conversions.ToInteger(Me.Pprtxt.Text)
			Positioncal.Tiltangle = Conversions.ToDouble(Me.Tiltangtxt.Text)
			Positioncal.MinDistance = Conversions.ToDouble(Me.Mindistxt.Text)
			Positioncal.MaxZRobotPos = Conversions.ToDouble(Me.MaxZRobotPostxt.Text) * 1000.0
			If Me.Forwarddirflg.Checked Then
				Positioncal.DirectionFlg = 1
			Else
				Positioncal.DirectionFlg = -1
			End If
			w.WriteLine(Me.Idlesptxt.Text)
			w.WriteLine(Me.Approsptxt.Text)
			w.WriteLine(Me.Distanceoffsettxt.Text)
			w.WriteLine(Me.Diamoffsettxt.Text)
			w.WriteLine(Me.Horoffsettxt.Text)
			w.WriteLine(Me.WorkXofftxt.Text)
			w.WriteLine(Me.WorkYAxisTilttxt.Text)
			w.WriteLine(Me.WorkZAxisYawtxt.Text)
			w.WriteLine(Me.Powderset1txt.Text)
			w.WriteLine(Me.Powderset2txt.Text)
			w.WriteLine(Me.Positionleveltxt.Text)
			w.WriteLine(Me.Pprtxt.Text)
			w.WriteLine(Me.Tiltangtxt.Text)
			w.WriteLine(Me.Mindistxt.Text)
			w.WriteLine(Conversions.ToDouble(Me.MaxZRobotPostxt.Text) * 1000.0)
			w.WriteLine(Positioncal.DirectionFlg)
			w.Close()
			Me.DialogResult = DialogResult.OK
			Me.Close()
		End Sub

		' Token: 0x0600036E RID: 878 RVA: 0x0003B04C File Offset: 0x0003944C
		Private Sub Cnlbtn_Click(sender As Object, e As EventArgs)
			Me.DialogResult = DialogResult.Cancel
			Me.Close()
		End Sub

		' Token: 0x0600036F RID: 879 RVA: 0x0003B05C File Offset: 0x0003945C
		Private Sub Idlesptxt_Leave(sender As Object, e As EventArgs)
			Dim defval As Double = 200.0
			If Versioned.IsNumeric(Me.Idlesptxt.Text) Then
				Dim value As Double = Conversions.ToDouble(Me.Idlesptxt.Text)
				If value < 500.0 And value > 0.1 Then
					Me.Idlesptxt.Text = value.ToString("#0.0")
					Positioncal.IdleSpeed = Conversions.ToDouble(Me.Idlesptxt.Text)
				Else
					Interaction.MsgBox("Valid values of Idle Speed are within 0.1 and 500 mm/s", MsgBoxStyle.Exclamation, Nothing)
					Me.Idlesptxt.Text = defval.ToString("#0.0")
				End If
			Else
				Interaction.MsgBox("This is not a valid number", MsgBoxStyle.Exclamation, Nothing)
				Me.Idlesptxt.Text = defval.ToString("#0.0")
			End If
		End Sub

		' Token: 0x06000370 RID: 880 RVA: 0x0003B130 File Offset: 0x00039530
		Private Sub Approsptxt_Leave(sender As Object, e As EventArgs)
			Dim defval As Double = 50.0
			If Versioned.IsNumeric(Me.Approsptxt.Text) Then
				Dim value As Double = Conversions.ToDouble(Me.Approsptxt.Text)
				If value < 500.0 And value > 0.1 Then
					Me.Approsptxt.Text = value.ToString("#0.0")
					Positioncal.ApproachSpeed = Conversions.ToDouble(Me.Approsptxt.Text)
				Else
					Interaction.MsgBox("Valid values of Approach Speed are within 0.1 and 500 mm/s", MsgBoxStyle.Exclamation, Nothing)
					Me.Approsptxt.Text = defval.ToString("#0.0")
				End If
			Else
				Interaction.MsgBox("This is not a valid number", MsgBoxStyle.Exclamation, Nothing)
				Me.Approsptxt.Text = defval.ToString("#0.0")
			End If
		End Sub

		' Token: 0x06000371 RID: 881 RVA: 0x0003B204 File Offset: 0x00039604
		Private Sub Distanceoffsettxt_Leave(sender As Object, e As EventArgs)
			Dim defval As Double = 500.0
			If Versioned.IsNumeric(Me.Distanceoffsettxt.Text) Then
				Dim value As Double = Conversions.ToDouble(Me.Distanceoffsettxt.Text)
				If value < 1000.0 And value > -1000.0 Then
					Me.Distanceoffsettxt.Text = value.ToString("#0.0")
					Positioncal.IniYAxisOffset = Conversions.ToDouble(Me.Distanceoffsettxt.Text)
				Else
					Interaction.MsgBox("Valid values of Height Offset are within -1000 and 1000 mm", MsgBoxStyle.Exclamation, Nothing)
					Me.Distanceoffsettxt.Text = defval.ToString("#0.0")
				End If
			Else
				Interaction.MsgBox("This is not a valid number", MsgBoxStyle.Exclamation, Nothing)
				Me.Distanceoffsettxt.Text = defval.ToString("#0.0")
			End If
		End Sub

		' Token: 0x06000372 RID: 882 RVA: 0x0003B2D8 File Offset: 0x000396D8
		Private Sub Diamoffsettxt_Leave(sender As Object, e As EventArgs)
			Dim defval As Double = 500.0
			If Versioned.IsNumeric(Me.Diamoffsettxt.Text) Then
				Dim value As Double = Conversions.ToDouble(Me.Diamoffsettxt.Text)
				If value < 1000.0 And value >= -1000.0 Then
					Me.Diamoffsettxt.Text = value.ToString("#0.0")
					Positioncal.IniZAxisOffset = Conversions.ToDouble(Me.Diamoffsettxt.Text)
				Else
					Interaction.MsgBox("Valid values of Diameter Offset are within -1000 and 1000 mm", MsgBoxStyle.Exclamation, Nothing)
					Me.Diamoffsettxt.Text = defval.ToString("#0.0")
				End If
			Else
				Interaction.MsgBox("This is not a valid number", MsgBoxStyle.Exclamation, Nothing)
				Me.Diamoffsettxt.Text = defval.ToString("#0.0")
			End If
		End Sub

		' Token: 0x06000373 RID: 883 RVA: 0x0003B3B0 File Offset: 0x000397B0
		Private Sub Horoffsettxt_Leave(sender As Object, e As EventArgs)
			Dim defval As Double = 500.0
			If Versioned.IsNumeric(Me.Horoffsettxt.Text) Then
				Dim value As Double = Conversions.ToDouble(Me.Horoffsettxt.Text)
				If value < 1000.0 And value >= -1000.0 Then
					Me.Horoffsettxt.Text = value.ToString("#0.0")
					Positioncal.IniXAxisOffset = Conversions.ToDouble(Me.Horoffsettxt.Text)
				Else
					Interaction.MsgBox("Valid values of Horizontal Offset are within -1000 and 1000 mm", MsgBoxStyle.Exclamation, Nothing)
					Me.Horoffsettxt.Text = defval.ToString("#0.0")
				End If
			Else
				Interaction.MsgBox("This is not a valid number", MsgBoxStyle.Exclamation, Nothing)
				Me.Horoffsettxt.Text = defval.ToString("#0.0")
			End If
		End Sub

		' Token: 0x06000374 RID: 884 RVA: 0x0003B488 File Offset: 0x00039888
		Private Sub Powderset1txt_Leave(sender As Object, e As EventArgs)
			Dim defval As Double = 10.0
			If Versioned.IsNumeric(Me.Powderset1txt.Text) Then
				Dim value As Double = Conversions.ToDouble(Me.Powderset1txt.Text)
				If value < 100.0 And value >= 0.01 Then
					Me.Powderset1txt.Text = value.ToString("#0.0")
					Positioncal.PowderSettling1 = Conversions.ToDouble(Me.Powderset1txt.Text)
				Else
					Interaction.MsgBox("Valid values of Powder Settling Time 1 are within 0.01 and 100 s", MsgBoxStyle.Exclamation, Nothing)
					Me.Powderset1txt.Text = defval.ToString("#0.0")
				End If
			Else
				Interaction.MsgBox("This is not a valid number", MsgBoxStyle.Exclamation, Nothing)
				Me.Powderset1txt.Text = defval.ToString("#0.0")
			End If
		End Sub

		' Token: 0x06000375 RID: 885 RVA: 0x0003B560 File Offset: 0x00039960
		Private Sub Powderset2txt_Leave(sender As Object, e As EventArgs)
			Dim defval As Double = 1.0
			If Versioned.IsNumeric(Me.Powderset2txt.Text) Then
				Dim value As Double = Conversions.ToDouble(Me.Powderset2txt.Text)
				If value < 100.0 And value >= 0.01 Then
					Me.Powderset2txt.Text = value.ToString("#0.0")
					Positioncal.PowderSettling2 = Conversions.ToDouble(Me.Powderset2txt.Text)
				Else
					Interaction.MsgBox("Valid values of Powder Settling Time 2 are within 0.01 and 100 s", MsgBoxStyle.Exclamation, Nothing)
					Me.Powderset2txt.Text = defval.ToString("#0.0")
				End If
			Else
				Interaction.MsgBox("This is not a valid number", MsgBoxStyle.Exclamation, Nothing)
				Me.Powderset2txt.Text = defval.ToString("#0.00")
			End If
		End Sub

		' Token: 0x06000376 RID: 886 RVA: 0x0003B638 File Offset: 0x00039A38
		Private Sub Positionleveltxt_Leave(sender As Object, e As EventArgs)
			Dim defval As Integer = 1
			If Versioned.IsNumeric(Me.Positionleveltxt.Text) Then
				' The following expression was wrapped in a checked-expression
				Dim value As Integer = CInt(Math.Round(Conversions.ToDouble(Me.Positionleveltxt.Text)))
				If value <= 8 And value >= 0 Then
					Me.Positionleveltxt.Text = value.ToString("#0")
					Positioncal.PositionLevel = Conversions.ToInteger(Me.Positionleveltxt.Text)
				Else
					Interaction.MsgBox("Valid values of Position Level are within 0 and 8", MsgBoxStyle.Exclamation, Nothing)
					Me.Positionleveltxt.Text = defval.ToString("#0")
				End If
			Else
				Interaction.MsgBox("This is not a valid number", MsgBoxStyle.Exclamation, Nothing)
				Me.Positionleveltxt.Text = defval.ToString("#0")
			End If
		End Sub

		' Token: 0x06000377 RID: 887 RVA: 0x0003B6FC File Offset: 0x00039AFC
		Private Sub Pprtxt_Leave(sender As Object, e As EventArgs)
			Dim defval As Integer = 4
			If Versioned.IsNumeric(Me.Pprtxt.Text) Then
				' The following expression was wrapped in a checked-expression
				Dim value As Integer = CInt(Math.Round(Conversions.ToDouble(Me.Pprtxt.Text)))
				If value <= 12 And value >= 4 Then
					Me.Pprtxt.Text = value.ToString("#0")
					Positioncal.PPR = Conversions.ToInteger(Me.Pprtxt.Text)
				Else
					Interaction.MsgBox("Valid values of PPR are within 4 and 8", MsgBoxStyle.Exclamation, Nothing)
					Me.Pprtxt.Text = defval.ToString("#0")
				End If
			Else
				Interaction.MsgBox("This is not a valid number", MsgBoxStyle.Exclamation, Nothing)
				Me.Pprtxt.Text = defval.ToString("#0")
			End If
		End Sub

		' Token: 0x06000378 RID: 888 RVA: 0x0003B7C0 File Offset: 0x00039BC0
		Private Sub Tiltangtxt_Leave(sender As Object, e As EventArgs)
			Dim defval As Double = 0.1
			If Versioned.IsNumeric(Me.Tiltangtxt.Text) Then
				Dim value As Double = Conversions.ToDouble(Me.Tiltangtxt.Text)
				If value <= 2.0 And value >= 0.0 Then
					Me.Tiltangtxt.Text = value.ToString("#0.0")
					Positioncal.Tiltangle = Conversions.ToDouble(Me.Tiltangtxt.Text)
				Else
					Interaction.MsgBox("Valid values of Tilt Angle are within 0 and 2.0 degrees", MsgBoxStyle.Exclamation, Nothing)
					Me.Tiltangtxt.Text = defval.ToString("#0.0")
				End If
			Else
				Interaction.MsgBox("This is not a valid number", MsgBoxStyle.Exclamation, Nothing)
				Me.Tiltangtxt.Text = defval.ToString("#0.0")
			End If
		End Sub

		' Token: 0x06000379 RID: 889 RVA: 0x0003B898 File Offset: 0x00039C98
		Private Sub WorkYAxisTilttxt_TextChanged(sender As Object, e As EventArgs)
			Dim defval As Double = 0.0
			If Versioned.IsNumeric(Me.WorkYAxisTilttxt.Text) Then
				Dim value As Double = Conversions.ToDouble(Me.WorkYAxisTilttxt.Text)
				If value <= 45.0 And value >= -45.0 Then
					Me.WorkYAxisTilttxt.Text = value.ToString("#0.00")
					Positioncal.WorkYAxisTilt = Conversions.ToDouble(Me.WorkYAxisTilttxt.Text)
				Else
					Interaction.MsgBox("Valid values of Tilt Angle are within -45 and 45 degrees", MsgBoxStyle.Exclamation, Nothing)
					Me.WorkYAxisTilttxt.Text = defval.ToString("#0.00")
				End If
			Else
				Interaction.MsgBox("This is not a valid number", MsgBoxStyle.Exclamation, Nothing)
				Me.WorkYAxisTilttxt.Text = defval.ToString("#0.00")
			End If
		End Sub

		' Token: 0x0600037A RID: 890 RVA: 0x0003B970 File Offset: 0x00039D70
		Private Sub WorkXofftxt_leave(sender As Object, e As EventArgs)
			Dim defval As Double = 0.0
			If Versioned.IsNumeric(Me.WorkXofftxt.Text) Then
				Dim value As Double = Conversions.ToDouble(Me.WorkXofftxt.Text)
				If value < 500.0 And value >= -500.0 Then
					Me.WorkXofftxt.Text = value.ToString("#0.0")
					Positioncal.WorkXAxisOffset = Conversions.ToDouble(Me.WorkXofftxt.Text)
				Else
					Interaction.MsgBox("Valid values of Horizontal Offset are within -500 and 500 mm", MsgBoxStyle.Exclamation, Nothing)
					Me.WorkXofftxt.Text = defval.ToString("#0.0")
				End If
			Else
				Interaction.MsgBox("This is not a valid number", MsgBoxStyle.Exclamation, Nothing)
				Me.WorkXofftxt.Text = defval.ToString("#0.0")
			End If
		End Sub

		' Token: 0x0600037B RID: 891 RVA: 0x0003BA48 File Offset: 0x00039E48
		Private Sub MaxZRobotPostxt_Leave(sender As Object, e As EventArgs)
			Dim defval As Double = 570.0
			If Versioned.IsNumeric(Me.MaxZRobotPostxt.Text) Then
				Dim value As Double = Conversions.ToDouble(Me.MaxZRobotPostxt.Text)
				If value < 1500.0 And value >= -1500.0 Then
					Me.MaxZRobotPostxt.Text = value.ToString("#0.0")
					Positioncal.MaxZRobotPos = Conversions.ToDouble(Me.MaxZRobotPostxt.Text) * 1000.0
				Else
					Interaction.MsgBox("Valid values of Maximum Z Axis value in RF are within -1500 and 1500 mm", MsgBoxStyle.Exclamation, Nothing)
					Me.MaxZRobotPostxt.Text = defval.ToString("#0.0")
				End If
			Else
				Interaction.MsgBox("This is not a valid number", MsgBoxStyle.Exclamation, Nothing)
				Me.MaxZRobotPostxt.Text = defval.ToString("#0.0")
			End If
		End Sub

		' Token: 0x0600037C RID: 892 RVA: 0x0003BB28 File Offset: 0x00039F28
		Private Sub WorkZAxisYawtxt_leave(sender As Object, e As EventArgs)
			Dim defval As Double = 0.0
			If Versioned.IsNumeric(Me.WorkZAxisYawtxt.Text) Then
				Dim value As Double = Conversions.ToDouble(Me.WorkZAxisYawtxt.Text)
				If value <= 45.0 And value >= -45.0 Then
					Me.WorkZAxisYawtxt.Text = value.ToString("#0.00")
					Positioncal.WorkZAxisYaw = Conversions.ToDouble(Me.WorkZAxisYawtxt.Text)
				Else
					Interaction.MsgBox("Valid values of Yaw Angle are within -45 and 45 degrees", MsgBoxStyle.Exclamation, Nothing)
					Me.WorkZAxisYawtxt.Text = defval.ToString("#0.00")
				End If
			Else
				Interaction.MsgBox("This is not a valid number", MsgBoxStyle.Exclamation, Nothing)
				Me.WorkZAxisYawtxt.Text = defval.ToString("#0.00")
			End If
		End Sub

		' Token: 0x0400013E RID: 318
		<AccessedThroughProperty("GroupBox2")>
		Private _GroupBox2 As GroupBox

		' Token: 0x0400013F RID: 319
		<AccessedThroughProperty("Horoffsettxt")>
		Private _Horoffsettxt As TextBox

		' Token: 0x04000140 RID: 320
		<AccessedThroughProperty("Idlesptxt")>
		Private _Idlesptxt As TextBox

		' Token: 0x04000141 RID: 321
		<AccessedThroughProperty("Diamoffsettxt")>
		Private _Diamoffsettxt As TextBox

		' Token: 0x04000142 RID: 322
		<AccessedThroughProperty("Approsptxt")>
		Private _Approsptxt As TextBox

		' Token: 0x04000143 RID: 323
		<AccessedThroughProperty("Distanceoffsettxt")>
		Private _Distanceoffsettxt As TextBox

		' Token: 0x04000144 RID: 324
		<AccessedThroughProperty("Cnlbtn")>
		Private _Cnlbtn As Button

		' Token: 0x04000145 RID: 325
		<AccessedThroughProperty("Cnfrmbtn")>
		Private _Cnfrmbtn As Button

		' Token: 0x04000146 RID: 326
		<AccessedThroughProperty("GroupBox1")>
		Private _GroupBox1 As GroupBox

		' Token: 0x04000147 RID: 327
		<AccessedThroughProperty("Powderset1txt")>
		Private _Powderset1txt As TextBox

		' Token: 0x04000148 RID: 328
		<AccessedThroughProperty("Powderset2txt")>
		Private _Powderset2txt As TextBox

		' Token: 0x04000149 RID: 329
		<AccessedThroughProperty("Positionleveltxt")>
		Private _Positionleveltxt As TextBox

		' Token: 0x0400014A RID: 330
		<AccessedThroughProperty("GroupBox3")>
		Private _GroupBox3 As GroupBox

		' Token: 0x0400014B RID: 331
		<AccessedThroughProperty("Reversedirflg")>
		Private _Reversedirflg As RadioButton

		' Token: 0x0400014C RID: 332
		<AccessedThroughProperty("Forwarddirflg")>
		Private _Forwarddirflg As RadioButton

		' Token: 0x0400014D RID: 333
		<AccessedThroughProperty("Mindistxt")>
		Private _Mindistxt As TextBox

		' Token: 0x0400014E RID: 334
		<AccessedThroughProperty("WorkXofftxt")>
		Private _WorkXofftxt As TextBox

		' Token: 0x0400014F RID: 335
		<AccessedThroughProperty("Pprtxt")>
		Private _Pprtxt As TextBox

		' Token: 0x04000150 RID: 336
		<AccessedThroughProperty("Tiltangtxt")>
		Private _Tiltangtxt As TextBox

		' Token: 0x04000151 RID: 337
		<AccessedThroughProperty("MaxZRobotPostxt")>
		Private _MaxZRobotPostxt As TextBox

		' Token: 0x04000152 RID: 338
		<AccessedThroughProperty("WorkZAxisYawtxt")>
		Private _WorkZAxisYawtxt As TextBox

		' Token: 0x04000153 RID: 339
		<AccessedThroughProperty("WorkYAxisTilttxt")>
		Private _WorkYAxisTilttxt As TextBox
	End Class
End Namespace
