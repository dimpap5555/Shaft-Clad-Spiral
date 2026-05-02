Imports System
Imports System.ComponentModel
Imports System.Data
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

Namespace WindowsApplication1
	' Token: 0x02000014 RID: 20
	Public Partial Class MPosıtıonupload
		Inherits Form

		' Token: 0x0600041D RID: 1053 RVA: 0x0003BC00 File Offset: 0x0003A000
		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.Posıtıonupload_Load
			Me.Uframe = ""
			Me.table = New DataTable("table")
			Me.currIndex = 0
			Me.TempPos = New Double(12) {}
			Me.tempfilename = Application.StartupPath + "/tempfile.txt"
			Me.InitializeComponent()
		End Sub

		' Token: 0x17000146 RID: 326
		' (get) Token: 0x06000420 RID: 1056 RVA: 0x0003D3A8 File Offset: 0x0003B7A8
		' (set) Token: 0x06000421 RID: 1057 RVA: 0x0003D3BC File Offset: 0x0003B7BC
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

		' Token: 0x17000147 RID: 327
		' (get) Token: 0x06000422 RID: 1058 RVA: 0x0003D408 File Offset: 0x0003B808
		' (set) Token: 0x06000423 RID: 1059 RVA: 0x0003D41C File Offset: 0x0003B81C
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

		' Token: 0x17000148 RID: 328
		' (get) Token: 0x06000424 RID: 1060 RVA: 0x0003D428 File Offset: 0x0003B828
		' (set) Token: 0x06000425 RID: 1061 RVA: 0x0003D43C File Offset: 0x0003B83C
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

		' Token: 0x17000149 RID: 329
		' (get) Token: 0x06000426 RID: 1062 RVA: 0x0003D488 File Offset: 0x0003B888
		' (set) Token: 0x06000427 RID: 1063 RVA: 0x0003D49C File Offset: 0x0003B89C
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

		' Token: 0x1700014A RID: 330
		' (get) Token: 0x06000428 RID: 1064 RVA: 0x0003D4E8 File Offset: 0x0003B8E8
		' (set) Token: 0x06000429 RID: 1065 RVA: 0x0003D4FC File Offset: 0x0003B8FC
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

		' Token: 0x1700014B RID: 331
		' (get) Token: 0x0600042A RID: 1066 RVA: 0x0003D548 File Offset: 0x0003B948
		' (set) Token: 0x0600042B RID: 1067 RVA: 0x0003D55C File Offset: 0x0003B95C
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

		' Token: 0x1700014C RID: 332
		' (get) Token: 0x0600042C RID: 1068 RVA: 0x0003D5A8 File Offset: 0x0003B9A8
		' (set) Token: 0x0600042D RID: 1069 RVA: 0x0003D5BC File Offset: 0x0003B9BC
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

		' Token: 0x1700014D RID: 333
		' (get) Token: 0x0600042E RID: 1070 RVA: 0x0003D608 File Offset: 0x0003BA08
		' (set) Token: 0x0600042F RID: 1071 RVA: 0x0003D61C File Offset: 0x0003BA1C
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

		' Token: 0x1700014E RID: 334
		' (get) Token: 0x06000430 RID: 1072 RVA: 0x0003D628 File Offset: 0x0003BA28
		' (set) Token: 0x06000431 RID: 1073 RVA: 0x0003D63C File Offset: 0x0003BA3C
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

		' Token: 0x1700014F RID: 335
		' (get) Token: 0x06000432 RID: 1074 RVA: 0x0003D688 File Offset: 0x0003BA88
		' (set) Token: 0x06000433 RID: 1075 RVA: 0x0003D69C File Offset: 0x0003BA9C
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

		' Token: 0x17000150 RID: 336
		' (get) Token: 0x06000434 RID: 1076 RVA: 0x0003D6E8 File Offset: 0x0003BAE8
		' (set) Token: 0x06000435 RID: 1077 RVA: 0x0003D6FC File Offset: 0x0003BAFC
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

		' Token: 0x17000151 RID: 337
		' (get) Token: 0x06000436 RID: 1078 RVA: 0x0003D708 File Offset: 0x0003BB08
		' (set) Token: 0x06000437 RID: 1079 RVA: 0x0003D71C File Offset: 0x0003BB1C
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

		' Token: 0x17000152 RID: 338
		' (get) Token: 0x06000438 RID: 1080 RVA: 0x0003D728 File Offset: 0x0003BB28
		' (set) Token: 0x06000439 RID: 1081 RVA: 0x0003D73C File Offset: 0x0003BB3C
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

		' Token: 0x17000153 RID: 339
		' (get) Token: 0x0600043A RID: 1082 RVA: 0x0003D788 File Offset: 0x0003BB88
		' (set) Token: 0x0600043B RID: 1083 RVA: 0x0003D79C File Offset: 0x0003BB9C
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

		' Token: 0x17000154 RID: 340
		' (get) Token: 0x0600043C RID: 1084 RVA: 0x0003D7E8 File Offset: 0x0003BBE8
		' (set) Token: 0x0600043D RID: 1085 RVA: 0x0003D7FC File Offset: 0x0003BBFC
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

		' Token: 0x17000155 RID: 341
		' (get) Token: 0x0600043E RID: 1086 RVA: 0x0003D848 File Offset: 0x0003BC48
		' (set) Token: 0x0600043F RID: 1087 RVA: 0x0003D85C File Offset: 0x0003BC5C
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

		' Token: 0x17000156 RID: 342
		' (get) Token: 0x06000440 RID: 1088 RVA: 0x0003D868 File Offset: 0x0003BC68
		' (set) Token: 0x06000441 RID: 1089 RVA: 0x0003D87C File Offset: 0x0003BC7C
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

		' Token: 0x17000157 RID: 343
		' (get) Token: 0x06000442 RID: 1090 RVA: 0x0003D888 File Offset: 0x0003BC88
		' (set) Token: 0x06000443 RID: 1091 RVA: 0x0003D89C File Offset: 0x0003BC9C
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

		' Token: 0x17000158 RID: 344
		' (get) Token: 0x06000444 RID: 1092 RVA: 0x0003D8A8 File Offset: 0x0003BCA8
		' (set) Token: 0x06000445 RID: 1093 RVA: 0x0003D8BC File Offset: 0x0003BCBC
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

		' Token: 0x17000159 RID: 345
		' (get) Token: 0x06000446 RID: 1094 RVA: 0x0003D8C8 File Offset: 0x0003BCC8
		' (set) Token: 0x06000447 RID: 1095 RVA: 0x0003D8DC File Offset: 0x0003BCDC
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

		' Token: 0x1700015A RID: 346
		' (get) Token: 0x06000448 RID: 1096 RVA: 0x0003D8E8 File Offset: 0x0003BCE8
		' (set) Token: 0x06000449 RID: 1097 RVA: 0x0003D8FC File Offset: 0x0003BCFC
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

		' Token: 0x1700015B RID: 347
		' (get) Token: 0x0600044A RID: 1098 RVA: 0x0003D908 File Offset: 0x0003BD08
		' (set) Token: 0x0600044B RID: 1099 RVA: 0x0003D91C File Offset: 0x0003BD1C
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

		' Token: 0x1700015C RID: 348
		' (get) Token: 0x0600044C RID: 1100 RVA: 0x0003D928 File Offset: 0x0003BD28
		' (set) Token: 0x0600044D RID: 1101 RVA: 0x0003D93C File Offset: 0x0003BD3C
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

		' Token: 0x1700015D RID: 349
		' (get) Token: 0x0600044E RID: 1102 RVA: 0x0003D948 File Offset: 0x0003BD48
		' (set) Token: 0x0600044F RID: 1103 RVA: 0x0003D95C File Offset: 0x0003BD5C
		Friend Overridable Property GridView As DataGridView
			<DebuggerNonUserCode()>
			Get
				Return Me._GridView
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As DataGridView)
				Dim value2 As DataGridViewCellValidatingEventHandler = AddressOf Me.GridView_CellValidating
				Dim value3 As DataGridViewCellEventHandler = AddressOf Me.GridView_Cellclick
				If Me._GridView IsNot Nothing Then
					RemoveHandler Me._GridView.CellValidating, value2
					RemoveHandler Me._GridView.CellClick, value3
				End If
				Me._GridView = value
				If Me._GridView IsNot Nothing Then
					AddHandler Me._GridView.CellValidating, value2
					AddHandler Me._GridView.CellClick, value3
				End If
			End Set
		End Property

		' Token: 0x1700015E RID: 350
		' (get) Token: 0x06000450 RID: 1104 RVA: 0x0003D9CC File Offset: 0x0003BDCC
		' (set) Token: 0x06000451 RID: 1105 RVA: 0x0003D9E0 File Offset: 0x0003BDE0
		Friend Overridable Property Upbutton As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._Upbutton
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = AddressOf Me.Upbutton_Click
				If Me._Upbutton IsNot Nothing Then
					RemoveHandler Me._Upbutton.Click, value2
				End If
				Me._Upbutton = value
				If Me._Upbutton IsNot Nothing Then
					AddHandler Me._Upbutton.Click, value2
				End If
			End Set
		End Property

		' Token: 0x1700015F RID: 351
		' (get) Token: 0x06000452 RID: 1106 RVA: 0x0003DA2C File Offset: 0x0003BE2C
		' (set) Token: 0x06000453 RID: 1107 RVA: 0x0003DA40 File Offset: 0x0003BE40
		Friend Overridable Property Downbutton As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._Downbutton
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = AddressOf Me.Downbutton_Click
				If Me._Downbutton IsNot Nothing Then
					RemoveHandler Me._Downbutton.Click, value2
				End If
				Me._Downbutton = value
				If Me._Downbutton IsNot Nothing Then
					AddHandler Me._Downbutton.Click, value2
				End If
			End Set
		End Property

		' Token: 0x17000160 RID: 352
		' (get) Token: 0x06000454 RID: 1108 RVA: 0x0003DA8C File Offset: 0x0003BE8C
		' (set) Token: 0x06000455 RID: 1109 RVA: 0x0003DAA0 File Offset: 0x0003BEA0
		Friend Overridable Property Delbutton As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._Delbutton
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = AddressOf Me.Delbutton_Click
				If Me._Delbutton IsNot Nothing Then
					RemoveHandler Me._Delbutton.Click, value2
				End If
				Me._Delbutton = value
				If Me._Delbutton IsNot Nothing Then
					AddHandler Me._Delbutton.Click, value2
				End If
			End Set
		End Property

		' Token: 0x17000161 RID: 353
		' (get) Token: 0x06000456 RID: 1110 RVA: 0x0003DAEC File Offset: 0x0003BEEC
		' (set) Token: 0x06000457 RID: 1111 RVA: 0x0003DB00 File Offset: 0x0003BF00
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

		' Token: 0x17000162 RID: 354
		' (get) Token: 0x06000458 RID: 1112 RVA: 0x0003DB0C File Offset: 0x0003BF0C
		' (set) Token: 0x06000459 RID: 1113 RVA: 0x0003DB20 File Offset: 0x0003BF20
		Friend Overridable Property Label9 As Label
			<DebuggerNonUserCode()>
			Get
				Return Me._Label9
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._Label9 = value
			End Set
		End Property

		' Token: 0x17000163 RID: 355
		' (get) Token: 0x0600045A RID: 1114 RVA: 0x0003DB2C File Offset: 0x0003BF2C
		' (set) Token: 0x0600045B RID: 1115 RVA: 0x0003DB40 File Offset: 0x0003BF40
		Friend Overridable Property Powertxt As TextBox
			<DebuggerNonUserCode()>
			Get
				Return Me._Powertxt
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As EventHandler = AddressOf Me.Powertxt_Leave
				If Me._Powertxt IsNot Nothing Then
					RemoveHandler Me._Powertxt.Leave, value2
				End If
				Me._Powertxt = value
				If Me._Powertxt IsNot Nothing Then
					AddHandler Me._Powertxt.Leave, value2
				End If
			End Set
		End Property

		' Token: 0x17000164 RID: 356
		' (get) Token: 0x0600045C RID: 1116 RVA: 0x0003DB8C File Offset: 0x0003BF8C
		' (set) Token: 0x0600045D RID: 1117 RVA: 0x0003DBA0 File Offset: 0x0003BFA0
		Friend Overridable Property Label10 As Label
			<DebuggerNonUserCode()>
			Get
				Return Me._Label10
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._Label10 = value
			End Set
		End Property

		' Token: 0x17000165 RID: 357
		' (get) Token: 0x0600045E RID: 1118 RVA: 0x0003DBAC File Offset: 0x0003BFAC
		' (set) Token: 0x0600045F RID: 1119 RVA: 0x0003DBC0 File Offset: 0x0003BFC0
		Friend Overridable Property MenuStrip1 As MenuStrip
			<DebuggerNonUserCode()>
			Get
				Return Me._MenuStrip1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As MenuStrip)
				Me._MenuStrip1 = value
			End Set
		End Property

		' Token: 0x17000166 RID: 358
		' (get) Token: 0x06000460 RID: 1120 RVA: 0x0003DBCC File Offset: 0x0003BFCC
		' (set) Token: 0x06000461 RID: 1121 RVA: 0x0003DBE0 File Offset: 0x0003BFE0
		Friend Overridable Property ToolStripMenuItem1 As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._ToolStripMenuItem1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Me._ToolStripMenuItem1 = value
			End Set
		End Property

		' Token: 0x17000167 RID: 359
		' (get) Token: 0x06000462 RID: 1122 RVA: 0x0003DBEC File Offset: 0x0003BFEC
		' (set) Token: 0x06000463 RID: 1123 RVA: 0x0003DC00 File Offset: 0x0003C000
		Friend Overridable Property LoadDataFileToolStripMenuItem As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._LoadDataFileToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.LoadDataFileToolStripMenuItem_Click
				If Me._LoadDataFileToolStripMenuItem IsNot Nothing Then
					RemoveHandler Me._LoadDataFileToolStripMenuItem.Click, value2
				End If
				Me._LoadDataFileToolStripMenuItem = value
				If Me._LoadDataFileToolStripMenuItem IsNot Nothing Then
					AddHandler Me._LoadDataFileToolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		' Token: 0x17000168 RID: 360
		' (get) Token: 0x06000464 RID: 1124 RVA: 0x0003DC4C File Offset: 0x0003C04C
		' (set) Token: 0x06000465 RID: 1125 RVA: 0x0003DC60 File Offset: 0x0003C060
		Friend Overridable Property SaveDataFileToolStripMenuItem As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._SaveDataFileToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.SaveDataFileToolStripMenuItem_Click
				If Me._SaveDataFileToolStripMenuItem IsNot Nothing Then
					RemoveHandler Me._SaveDataFileToolStripMenuItem.Click, value2
				End If
				Me._SaveDataFileToolStripMenuItem = value
				If Me._SaveDataFileToolStripMenuItem IsNot Nothing Then
					AddHandler Me._SaveDataFileToolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		' Token: 0x17000169 RID: 361
		' (get) Token: 0x06000466 RID: 1126 RVA: 0x0003DCAC File Offset: 0x0003C0AC
		' (set) Token: 0x06000467 RID: 1127 RVA: 0x0003DCC0 File Offset: 0x0003C0C0
		Friend Overridable Property Label11 As Label
			<DebuggerNonUserCode()>
			Get
				Return Me._Label11
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._Label11 = value
			End Set
		End Property

		' Token: 0x1700016A RID: 362
		' (get) Token: 0x06000468 RID: 1128 RVA: 0x0003DCCC File Offset: 0x0003C0CC
		' (set) Token: 0x06000469 RID: 1129 RVA: 0x0003DCE0 File Offset: 0x0003C0E0
		Friend Overridable Property Beamdiatxt As TextBox
			<DebuggerNonUserCode()>
			Get
				Return Me._Beamdiatxt
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As EventHandler = AddressOf Me.Beamdiatxt_Leave
				If Me._Beamdiatxt IsNot Nothing Then
					RemoveHandler Me._Beamdiatxt.Leave, value2
				End If
				Me._Beamdiatxt = value
				If Me._Beamdiatxt IsNot Nothing Then
					AddHandler Me._Beamdiatxt.Leave, value2
				End If
			End Set
		End Property

		' Token: 0x1700016B RID: 363
		' (get) Token: 0x0600046A RID: 1130 RVA: 0x0003DD2C File Offset: 0x0003C12C
		' (set) Token: 0x0600046B RID: 1131 RVA: 0x0003DD40 File Offset: 0x0003C140
		Friend Overridable Property ConstBeam As CheckBox
			<DebuggerNonUserCode()>
			Get
				Return Me._ConstBeam
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As CheckBox)
				Dim value2 As EventHandler = AddressOf Me.ConstBeam_CheckedChanged
				If Me._ConstBeam IsNot Nothing Then
					RemoveHandler Me._ConstBeam.CheckedChanged, value2
				End If
				Me._ConstBeam = value
				If Me._ConstBeam IsNot Nothing Then
					AddHandler Me._ConstBeam.CheckedChanged, value2
				End If
			End Set
		End Property

		' Token: 0x0600046C RID: 1132 RVA: 0x0003DD8C File Offset: 0x0003C18C
		Private Sub Upload_btn_Click(sender As Object, e As EventArgs)
			' The following expression was wrapped in a checked-statement
			If Positioncal.ConectStat = 1S Then
				MotoCom32.BscSetCtrlGroupDx(CShort(Connection.nCid), 1, 1)
				Dim nCid As Short = CShort(Connection.nCid)
				Dim isex As Short = 1S
				Dim num As Short = CShort(Me.Rconf)
				Dim num2 As Short = CShort(Me.Toolno)
				MotoCom32.BscIsRobotPos(nCid, Me.Uframe, isex, num, num2, Me.TempPos(0))
				Me.Toolno = CInt(num2)
				Me.Rconf = CInt(num)
				Me.Usrfrmtxt.Text = Me.Uframe
				Me.Xpostxt.Text = Me.TempPos(0).ToString("#0.000")
				Me.Ypostxt.Text = Me.TempPos(1).ToString("#0.000")
				Me.Zpostxt.Text = Me.TempPos(2).ToString("#0.000")
				Me.Rxpostxt.Text = Me.TempPos(3).ToString("#0.000")
				Me.Rypostxt.Text = Me.TempPos(4).ToString("#0.000")
				Me.Rzpostxt.Text = Me.TempPos(5).ToString("#0.000")
				Me.S1postxt.Text = Me.TempPos(6).ToString("#0.000")
				Me.S2postxt.Text = Me.TempPos(7).ToString("#0.000")
				Me.currIndex += 1
				Me.table.Rows.Add(New Object() { Me.table.Rows.Count.ToString("#0"), Me.Powertxt.Text, Me.Beamdiatxt.Text, Me.TempPos(0).ToString("#0.000"), Me.TempPos(1).ToString("#0.000"), Me.TempPos(2).ToString("#0.000"), Me.TempPos(3).ToString("#0.000"), Me.TempPos(4).ToString("#0.000"), Me.TempPos(5).ToString("#0.000"), Me.TempPos(6).ToString("#0.000"), Me.TempPos(7).ToString("#0.000") })
				Me.Cnfrm_btn.Enabled = True
			Else
				' The following expression was wrapped in a unchecked-expression
				Connection.Ms_BscOpenComm(Positioncal.ipaddress, Positioncal.BasePath, 0, CLng(Me.Handle.ToInt32()))
				MotoCom32.BscSetCtrlGroupDx(CShort(Connection.nCid), 1, 1)
				Dim nCid2 As Short = CShort(Connection.nCid)
				Dim isex2 As Short = 1S
				Dim num2 As Short = CShort(Me.Rconf)
				Dim num As Short = CShort(Me.Toolno)
				MotoCom32.BscIsRobotPos(nCid2, Me.Uframe, isex2, num2, num, Me.TempPos(0))
				Me.Toolno = CInt(num)
				Me.Rconf = CInt(num2)
				Me.Usrfrmtxt.Text = Me.Uframe
				Me.Xpostxt.Text = Me.TempPos(0).ToString("#0.000")
				Me.Ypostxt.Text = Me.TempPos(1).ToString("#0.000")
				Me.Zpostxt.Text = Me.TempPos(2).ToString("#0.000")
				Me.Rxpostxt.Text = Me.TempPos(3).ToString("#0.000")
				Me.Rypostxt.Text = Me.TempPos(4).ToString("#0.000")
				Me.Rzpostxt.Text = Me.TempPos(5).ToString("#0.000")
				Me.S1postxt.Text = Me.TempPos(6).ToString("#0.000")
				Me.S2postxt.Text = Me.TempPos(7).ToString("#0.000")
				Me.currIndex += 1
				Me.table.Rows.Add(New Object() { Me.table.Rows.Count.ToString("#0"), Me.Powertxt.Text, Me.Beamdiatxt.Text, Me.TempPos(0).ToString("#0.000"), Me.TempPos(1).ToString("#0.000"), Me.TempPos(2).ToString("#0.000"), Me.TempPos(3).ToString("#0.000"), Me.TempPos(4).ToString("#0.000"), Me.TempPos(5).ToString("#0.000"), Me.TempPos(6).ToString("#0.000"), Me.TempPos(7).ToString("#0.000") })
				Me.Cnfrm_btn.Enabled = True
				Connection.MS_BscCloseComm(Connection.nCid)
			End If
			If Me.ConstBeam.Checked Then
				Dim num3 As Integer = 0
				Dim num4 As Integer = Me.table.Rows.Count - 1
				For i As Integer = num3 To num4
					Me.table.Rows(i)(2) = Conversions.ToDouble(Me.Beamdiatxt.Text)
				Next
			End If
			Me.Upbutton.Enabled = True
			Me.Downbutton.Enabled = True
			Me.Delbutton.Enabled = True
			Me.Cnfrm_btn.Enabled = True
			Positioncal.SavePositionFile(Me.tempfilename, Me.table, Me.Uframe)
		End Sub

		' Token: 0x0600046D RID: 1133 RVA: 0x0003E3D8 File Offset: 0x0003C7D8
		Private Sub Cnfrm_btn_Click(sender As Object, e As EventArgs)
			Positioncal.PointNo = Me.table.Rows.Count
			If Positioncal.PointNo <= 2 Then
				Interaction.MsgBox("At least three tought points are necessary for a trajectory formation. Please add more points.", MsgBoxStyle.Exclamation, Nothing)
			Else
				Positioncal.Position = CType(Utils.CopyArray(CType(Positioncal.Position, Array), New Double(12, Positioncal.PointNo - 1 + 1 - 1) {}), Double(,))
				Dim num As Integer = 0
				Dim num2 As Integer = Me.table.Rows.Count - 1
				For i As Integer = num To num2
					Dim j As Integer = 1
					Do
						Positioncal.Position(j + 7, i) = Conversions.ToDouble(Me.table.Rows(i)(j))
						j += 1
					Loop While j <= 2
					Dim num3 As Integer = 3
					Dim num4 As Integer = Me.table.Columns.Count - 1
					For k As Integer = num3 To num4
						Positioncal.Position(k - 3, i) = Conversions.ToDouble(Me.table.Rows(i)(k))
					Next
					If Conversions.ToBoolean(Operators.OrObject(Operators.CompareObjectLess(Me.table.Rows(i)(1), 450.0, False), Operators.CompareObjectGreater(Me.table.Rows(i)(1), 4500.0, False))) Then
						Interaction.MsgBox(String.Concat(New String() { "Power values between ", 450.0.ToString(), "W and ", 4500.0.ToString(), "W should be entered. Please adjust accordingly." }), MsgBoxStyle.Exclamation, Nothing)
						Return
					End If
				Next
				Positioncal.SavePositionFile(Me.tempfilename, Me.table, Me.Uframe)
				Me.DialogResult = DialogResult.OK
				Me.Close()
			End If
		End Sub

		' Token: 0x0600046E RID: 1134 RVA: 0x0003E5CC File Offset: 0x0003C9CC
		Private Sub Posıtıonupload_Load(sender As Object, e As EventArgs)
			Me.Cnfrm_btn.Enabled = False
			Me.currIndex = 0
			If Me.table.Columns.Count > 0 Then
				Me.table.Columns.Clear()
				Me.table.Rows.Clear()
			End If
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
			Me.Powertxt.Text = 2250.0.ToString("#")
			Me.Beamdiatxt.Text = 1.9.ToString("#0.00")
			Me.table.Columns.Add("Index", Type.[GetType]("System.Int32"))
			Me.table.Columns.Add("Laser Power (W)", Type.[GetType]("System.Int32"))
			Me.table.Columns.Add("Clad Width (mm)", Type.[GetType]("System.Double"))
			Me.table.Columns.Add("X (mm)", Type.[GetType]("System.Double"))
			Me.table.Columns.Add("Y (mm)", Type.[GetType]("System.Double"))
			Me.table.Columns.Add("Z (mm)", Type.[GetType]("System.Double"))
			Me.table.Columns.Add("Rx (deg)", Type.[GetType]("System.Double"))
			Me.table.Columns.Add("Ry (deg)", Type.[GetType]("System.Double"))
			Me.table.Columns.Add("Rz (deg)", Type.[GetType]("System.Double"))
			Me.table.Columns.Add("S1 (deg)", Type.[GetType]("System.Double"))
			Me.table.Columns.Add("S2 (deg)", Type.[GetType]("System.Double"))
			Me.GridView.DataSource = Me.table
			Me.GridView.Columns(0).DefaultCellStyle.Format = "n0"
			Me.GridView.Columns(1).DefaultCellStyle.Format = "n0"
			Me.GridView.Columns(2).DefaultCellStyle.Format = "n2"
			Me.Downbutton.Enabled = False
			Me.Upbutton.Enabled = False
			Me.Delbutton.Enabled = False
		End Sub

		' Token: 0x0600046F RID: 1135 RVA: 0x0003E948 File Offset: 0x0003CD48
		Private Sub Cncl_btn_Click(sender As Object, e As EventArgs)
			Me.Close()
		End Sub

		' Token: 0x06000470 RID: 1136 RVA: 0x0003E950 File Offset: 0x0003CD50
		Private Sub Xpostxt_Leave(sender As Object, e As EventArgs)
			If Versioned.IsNumeric(Me.Xpostxt.Text) Then
				Dim value As Double = Conversions.ToDouble(Me.Xpostxt.Text)
				Me.Xpostxt.Text = value.ToString("#0.000")
				Me.TempPos(0) = Conversions.ToDouble(Me.Xpostxt.Text)
			Else
				Interaction.MsgBox("This is not a valid number", MsgBoxStyle.Exclamation, Nothing)
				Me.Xpostxt.Text = Me.TempPos(0).ToString("#0.000")
			End If
		End Sub

		' Token: 0x06000471 RID: 1137 RVA: 0x0003E9E0 File Offset: 0x0003CDE0
		Private Sub Ypostxt_Leave(sender As Object, e As EventArgs)
			If Versioned.IsNumeric(Me.Ypostxt.Text) Then
				Dim value As Double = Conversions.ToDouble(Me.Ypostxt.Text)
				Me.Ypostxt.Text = value.ToString("#0.000")
				Me.TempPos(1) = Conversions.ToDouble(Me.Ypostxt.Text)
			Else
				Interaction.MsgBox("This is not a valid number", MsgBoxStyle.Exclamation, Nothing)
				Me.Ypostxt.Text = Me.TempPos(1).ToString("#0.000")
			End If
		End Sub

		' Token: 0x06000472 RID: 1138 RVA: 0x0003EA70 File Offset: 0x0003CE70
		Private Sub Zpostxt_Leave(sender As Object, e As EventArgs)
			If Versioned.IsNumeric(Me.Zpostxt.Text) Then
				Dim value As Double = Conversions.ToDouble(Me.Zpostxt.Text)
				Me.Zpostxt.Text = value.ToString("#0.000")
				Me.TempPos(2) = Conversions.ToDouble(Me.Zpostxt.Text)
			Else
				Interaction.MsgBox("This is not a valid number", MsgBoxStyle.Exclamation, Nothing)
				Me.Zpostxt.Text = Me.TempPos(2).ToString("#0.000")
			End If
		End Sub

		' Token: 0x06000473 RID: 1139 RVA: 0x0003EB00 File Offset: 0x0003CF00
		Private Sub Rxpostxt_Leave(sender As Object, e As EventArgs)
			If Versioned.IsNumeric(Me.Rxpostxt.Text) Then
				Dim value As Double = Conversions.ToDouble(Me.Rxpostxt.Text)
				Me.Rxpostxt.Text = value.ToString("#0.000")
				Me.TempPos(3) = Conversions.ToDouble(Me.Rxpostxt.Text)
			Else
				Interaction.MsgBox("This is not a valid number", MsgBoxStyle.Exclamation, Nothing)
				Me.Rxpostxt.Text = Me.TempPos(3).ToString("#0.000")
			End If
		End Sub

		' Token: 0x06000474 RID: 1140 RVA: 0x0003EB90 File Offset: 0x0003CF90
		Private Sub Rypostxt_Leave(sender As Object, e As EventArgs)
			If Versioned.IsNumeric(Me.Rypostxt.Text) Then
				Dim value As Double = Conversions.ToDouble(Me.Rypostxt.Text)
				Me.Rypostxt.Text = value.ToString("#0.000")
				Me.TempPos(4) = Conversions.ToDouble(Me.Rypostxt.Text)
			Else
				Interaction.MsgBox("This is not a valid number", MsgBoxStyle.Exclamation, Nothing)
				Me.Rypostxt.Text = Me.TempPos(4).ToString("#0.000")
			End If
		End Sub

		' Token: 0x06000475 RID: 1141 RVA: 0x0003EC20 File Offset: 0x0003D020
		Private Sub Rzpostxt_Leave(sender As Object, e As EventArgs)
			If Versioned.IsNumeric(Me.Rzpostxt.Text) Then
				Dim value As Double = Conversions.ToDouble(Me.Rzpostxt.Text)
				Me.Rzpostxt.Text = value.ToString("#0.000")
				Me.TempPos(5) = Conversions.ToDouble(Me.Rzpostxt.Text)
			Else
				Interaction.MsgBox("This is not a valid number", MsgBoxStyle.Exclamation, Nothing)
				Me.Rzpostxt.Text = Me.TempPos(5).ToString("#0.000")
			End If
		End Sub

		' Token: 0x06000476 RID: 1142 RVA: 0x0003ECB0 File Offset: 0x0003D0B0
		Private Sub S1postxt_Leave(sender As Object, e As EventArgs)
			If Versioned.IsNumeric(Me.S1postxt.Text) Then
				Dim value As Double = Conversions.ToDouble(Me.S1postxt.Text)
				Me.S1postxt.Text = value.ToString("#0.000")
				Me.TempPos(6) = Conversions.ToDouble(Me.S1postxt.Text)
			Else
				Interaction.MsgBox("This is not a valid number", MsgBoxStyle.Exclamation, Nothing)
				Me.S1postxt.Text = Me.TempPos(6).ToString("#0.000")
			End If
		End Sub

		' Token: 0x06000477 RID: 1143 RVA: 0x0003ED40 File Offset: 0x0003D140
		Private Sub S2postxt_Leave(sender As Object, e As EventArgs)
			If Versioned.IsNumeric(Me.S2postxt.Text) Then
				Dim value As Double = Conversions.ToDouble(Me.S2postxt.Text)
				Me.S2postxt.Text = value.ToString("#0.000")
				Me.TempPos(7) = Conversions.ToDouble(Me.S2postxt.Text)
			Else
				Interaction.MsgBox("This is not a valid number", MsgBoxStyle.Exclamation, Nothing)
				Me.S2postxt.Text = Me.TempPos(7).ToString("#0.000")
			End If
		End Sub

		' Token: 0x06000478 RID: 1144 RVA: 0x0003EDD0 File Offset: 0x0003D1D0
		Private Sub Powertxt_Leave(sender As Object, e As EventArgs)
			If Char.IsNumber(Conversions.ToChar(Me.Powertxt.Text)) Then
				If Conversions.ToDouble(Me.Powertxt.Text) <= 4500.0 And Conversions.ToDouble(Me.Powertxt.Text) >= 450.0 Then
					Dim value As Double = Conversions.ToDouble(Me.Powertxt.Text)
					Me.Powertxt.Text = value.ToString("#0")
				Else
					Interaction.MsgBox(String.Concat(New String() { "Power values between ", 450.0.ToString(), "W and ", 4500.0.ToString(), "W should be entered" }), MsgBoxStyle.Exclamation, Nothing)
					Me.Powertxt.Text = Conversions.ToString(0.5 * Conversions.ToDouble(4500.0.ToString("#0.0")))
				End If
			Else
				Interaction.MsgBox("This is not a valid number", MsgBoxStyle.Exclamation, Nothing)
				Me.Powertxt.Text = Conversions.ToString(0.5 * Conversions.ToDouble(4500.0.ToString("#0.0")))
			End If
		End Sub

		' Token: 0x06000479 RID: 1145 RVA: 0x0003EF34 File Offset: 0x0003D334
		Private Sub Beamdiatxt_Leave(sender As Object, e As EventArgs)
			If Char.IsNumber(Conversions.ToChar(Me.Beamdiatxt.Text)) Then
				If Conversions.ToDouble(Me.Beamdiatxt.Text) >= 1.9 And Conversions.ToDouble(Me.Beamdiatxt.Text) <= 6.25 Then
					Dim value As Double = Conversions.ToDouble(Me.Beamdiatxt.Text)
					Me.Beamdiatxt.Text = value.ToString("#0.00")
				Else
					Interaction.MsgBox(String.Concat(New String() { "Values between ", 1.9.ToString("#0.00"), "mm and ", 6.25.ToString("#0.00"), "mm should be entered" }), MsgBoxStyle.Exclamation, Nothing)
					Me.Beamdiatxt.Text = 4.075.ToString("#0.00")
				End If
			Else
				Interaction.MsgBox("This is not a valid number", MsgBoxStyle.Exclamation, Nothing)
				Me.Beamdiatxt.Text = 4.075.ToString("#0.00")
			End If
		End Sub

		' Token: 0x0600047A RID: 1146 RVA: 0x0003F07C File Offset: 0x0003D47C
		Private Sub Upbutton_Click(sender As Object, e As EventArgs)
			Me.rowIndex = Me.GridView.SelectedCells(0).OwningRow.Index
			Dim row As DataRow = Me.table.NewRow()
			Dim i As Short = 0S
			Do
				row(CInt(i)) = Double.Parse(Me.GridView.Rows(Me.rowIndex).Cells(CInt(i)).Value.ToString())
				i += 1S
			Loop While i <= 10S
			If Me.rowIndex > 0 Then
				Me.table.Rows.RemoveAt(Me.rowIndex)
				Me.table.Rows.InsertAt(row, Me.rowIndex - 1)
				Me.GridView.ClearSelection()
				Me.GridView.Rows(Me.rowIndex - 1).Selected = True
			End If
			Positioncal.SavePositionFile(Me.tempfilename, Me.table, Me.Uframe)
		End Sub

		' Token: 0x0600047B RID: 1147 RVA: 0x0003F178 File Offset: 0x0003D578
		Private Sub Downbutton_Click(sender As Object, e As EventArgs)
			Me.rowIndex = Me.GridView.SelectedCells(0).OwningRow.Index
			Dim row As DataRow = Me.table.NewRow()
			Dim i As Short = 0S
			Do
				row(CInt(i)) = Double.Parse(Me.GridView.Rows(Me.rowIndex).Cells(CInt(i)).Value.ToString())
				i += 1S
			Loop While i <= 10S
			If Me.rowIndex < Me.GridView.Rows.Count - 2 Then
				Me.table.Rows.RemoveAt(Me.rowIndex)
				Me.table.Rows.InsertAt(row, Me.rowIndex + 1)
				Me.GridView.ClearSelection()
				Me.GridView.Rows(Me.rowIndex + 1).Selected = True
			End If
			Positioncal.SavePositionFile(Me.tempfilename, Me.table, Me.Uframe)
		End Sub

		' Token: 0x0600047C RID: 1148 RVA: 0x0003F284 File Offset: 0x0003D684
		Private Sub Delbutton_Click(sender As Object, e As EventArgs)
			Me.rowIndex = Me.GridView.SelectedCells(0).OwningRow.Index
			Dim maxrow As Integer = Me.GridView.Rows.Count
			If Me.rowIndex < maxrow - 1 Then
				Me.table.Rows.RemoveAt(Me.rowIndex)
				Me.currIndex -= 1
			End If
			Positioncal.SavePositionFile(Me.tempfilename, Me.table, Me.Uframe)
			If Me.table.Rows.Count = 0 Then
				Me.Upbutton.Enabled = False
				Me.Downbutton.Enabled = False
				Me.Delbutton.Enabled = False
				Me.Cnfrm_btn.Enabled = False
			ElseIf Me.rowIndex = 0 Then
				Me.GridView.Rows(Me.rowIndex).Selected = True
			Else
				Me.GridView.Rows(Me.rowIndex - 1).Selected = True
			End If
		End Sub

		' Token: 0x0600047D RID: 1149 RVA: 0x0003F394 File Offset: 0x0003D794
		Private Sub LoadDataFileToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Dim OpenFileDialog As OpenFileDialog = New OpenFileDialog()
			OpenFileDialog.Filter = "Position Coordinate File|*.pcf"
			If OpenFileDialog.ShowDialog() = DialogResult.OK Then
				Dim fileName As String = OpenFileDialog.FileName
				Dim stationPosition As Short = CShort(Positioncal.StationPosition)
				Positioncal.LoadPositionFile(fileName, Me.table, Me.Uframe, stationPosition, Me.currIndex)
				Positioncal.StationPosition = CInt(stationPosition)
				Me.Usrfrmtxt.Text = Me.Uframe
				Positioncal.SavePositionFile(Me.tempfilename, Me.table, Me.Uframe)
			End If
			If Me.table.Rows.Count > 0 Then
				Me.Upbutton.Enabled = True
				Me.Downbutton.Enabled = True
				Me.Delbutton.Enabled = True
				Me.Cnfrm_btn.Enabled = True
			End If
		End Sub

		' Token: 0x0600047E RID: 1150 RVA: 0x0003F454 File Offset: 0x0003D854
		Private Sub SaveDataFileToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Dim SaveFileDialog As SaveFileDialog = New SaveFileDialog()
			SaveFileDialog.Filter = "Position Coordinate File|*.pcf"
			If SaveFileDialog.ShowDialog() = DialogResult.OK Then
				Positioncal.SavePositionFile(SaveFileDialog.FileName, Me.table, Me.Uframe)
			End If
		End Sub

		' Token: 0x0600047F RID: 1151 RVA: 0x0003F494 File Offset: 0x0003D894
		Private Sub ConstBeam_CheckedChanged(sender As Object, e As EventArgs)
			' The following expression was wrapped in a checked-statement
			If Me.ConstBeam.Checked Then
				If Me.table.Rows.Count > 1 Then
					Dim Tempcladwidth As Double = Conversions.ToDouble(Me.table.Rows(0)(2))
					Dim num As Integer = 1
					Dim num2 As Integer = Me.table.Rows.Count - 1
					For i As Integer = num To num2
						If Operators.ConditionalCompareObjectNotEqual(Tempcladwidth, Me.table.Rows(i)(2), False) Then
							Interaction.MsgBox("Clad width values are not the same in all taught points. Please review and alter accordingly", MsgBoxStyle.Exclamation, Nothing)
							Exit For
						End If
						Tempcladwidth = Conversions.ToDouble(Me.table.Rows(i)(2))
					Next
				End If
				Positioncal.ConstBeamFlg = 1S
			Else
				Positioncal.ConstBeamFlg = 0S
			End If
		End Sub

		' Token: 0x06000480 RID: 1152 RVA: 0x0003F564 File Offset: 0x0003D964
		Private Sub GridView_CellValidating(sender As Object, e As DataGridViewCellValidatingEventArgs)
			Dim column As DataGridViewColumn = Me.GridView.Columns(e.ColumnIndex)
			Dim rowindex As Integer = Me.GridView.SelectedCells(0).OwningRow.Index
			If rowindex < Me.table.Rows.Count Then
				If Operators.CompareString(column.Name, "Laser Power (W)", False) = 0 Then
					Me.CheckPower(e)
				ElseIf Operators.CompareString(column.Name, "Clad Width (mm)", False) = 0 Then
					Me.CheckCladWidth(e)
				ElseIf column.Index >= 3 Then
					Me.CheckCoord(e)
				End If
			End If
		End Sub

		' Token: 0x06000481 RID: 1153 RVA: 0x0003F604 File Offset: 0x0003DA04
		Private Sub CheckPower(newvalue As DataGridViewCellValidatingEventArgs)
			If String.IsNullOrEmpty(newvalue.FormattedValue.ToString()) Then
				MPosıtıonupload.NotifyUserAndForceRedo("Please enter a Power value", newvalue)
			Else
				Dim s As String = newvalue.FormattedValue.ToString()
				Dim num As Integer = 0
				If Not Integer.TryParse(s, num) Then
					MPosıtıonupload.NotifyUserAndForceRedo("Power value must be a number", newvalue)
				ElseIf CDbl(Integer.Parse(newvalue.FormattedValue.ToString())) < 450.0 Or CDbl(Integer.Parse(newvalue.FormattedValue.ToString())) > Conversions.ToDouble(4500.0.ToString()) Then
					MPosıtıonupload.NotifyUserAndForceRedo(String.Concat(New String() { "This is not a valid value. Power values between ", 450.0.ToString("#0"), "W - ", 4500.0.ToString("#0"), "W should be entered" }), newvalue)
				End If
			End If
		End Sub

		' Token: 0x06000482 RID: 1154 RVA: 0x0003F710 File Offset: 0x0003DB10
		Private Sub CheckCladWidth(newvalue As DataGridViewCellValidatingEventArgs)
			' The following expression was wrapped in a checked-statement
			If String.IsNullOrEmpty(newvalue.FormattedValue.ToString()) Then
				MPosıtıonupload.NotifyUserAndForceRedo("Please enter a clad width value", newvalue)
			Else
				Dim s As String = newvalue.FormattedValue.ToString()
				Dim num As Double = 0.0
				If Not Double.TryParse(s, num) Then
					MPosıtıonupload.NotifyUserAndForceRedo("Clad width value must be a number", newvalue)
				ElseIf Double.Parse(newvalue.FormattedValue.ToString()) < 1.9 Or Double.Parse(newvalue.FormattedValue.ToString()) > 6.25 Then
					If Positioncal.MeanderFlg = 0S Then
						Dim array As String() = New String(4) {}
						array(0) = "This is not a valid value. Clad width values between "
						array(1) = 1.9.ToString("#0.00")
						array(2) = "mm - "
						Dim array2 As String() = array
						Dim num2 As Integer = 3
						num = 6.25
						array2(num2) = num.ToString("#0.00")
						array(4) = "mm should be entered"
						MPosıtıonupload.NotifyUserAndForceRedo(String.Concat(array), newvalue)
					End If
				ElseIf Positioncal.ConstBeamFlg = 1S Then
					Dim num3 As Integer = 0
					Dim num4 As Integer = Me.GridView.Rows.Count - 2
					For i As Integer = num3 To num4
						Me.table.Rows(i)(2) = Double.Parse(newvalue.FormattedValue.ToString())
					Next
				End If
			End If
		End Sub

		' Token: 0x06000483 RID: 1155 RVA: 0x0003F868 File Offset: 0x0003DC68
		Private Sub CheckCoord(newvalue As DataGridViewCellValidatingEventArgs)
			If String.IsNullOrEmpty(newvalue.FormattedValue.ToString()) Then
				MPosıtıonupload.NotifyUserAndForceRedo("Please enter a proper coordinate value", newvalue)
			Else
				Dim s As String = newvalue.FormattedValue.ToString()
				Dim num As Double = 0.0
				If Not Double.TryParse(s, num) Then
					MPosıtıonupload.NotifyUserAndForceRedo("Coordinate value must be a number", newvalue)
				End If
			End If
		End Sub

		' Token: 0x06000484 RID: 1156 RVA: 0x0003F8C0 File Offset: 0x0003DCC0
		Private Shared Sub NotifyUserAndForceRedo(errorMessage As String, newValue As DataGridViewCellValidatingEventArgs)
			MessageBox.Show(errorMessage)
			newValue.Cancel = True
		End Sub

		' Token: 0x06000485 RID: 1157 RVA: 0x0003F8D0 File Offset: 0x0003DCD0
		Private Sub GridView_Cellclick(sender As Object, e As DataGridViewCellEventArgs)
		End Sub

		' Token: 0x0400015C RID: 348
		<AccessedThroughProperty("Xpostxt")>
		Private _Xpostxt As TextBox

		' Token: 0x0400015D RID: 349
		<AccessedThroughProperty("GroupBox1")>
		Private _GroupBox1 As GroupBox

		' Token: 0x0400015E RID: 350
		<AccessedThroughProperty("Rzpostxt")>
		Private _Rzpostxt As TextBox

		' Token: 0x0400015F RID: 351
		<AccessedThroughProperty("Rypostxt")>
		Private _Rypostxt As TextBox

		' Token: 0x04000160 RID: 352
		<AccessedThroughProperty("Rxpostxt")>
		Private _Rxpostxt As TextBox

		' Token: 0x04000161 RID: 353
		<AccessedThroughProperty("Zpostxt")>
		Private _Zpostxt As TextBox

		' Token: 0x04000162 RID: 354
		<AccessedThroughProperty("Ypostxt")>
		Private _Ypostxt As TextBox

		' Token: 0x04000163 RID: 355
		<AccessedThroughProperty("GroupBox2")>
		Private _GroupBox2 As GroupBox

		' Token: 0x04000164 RID: 356
		<AccessedThroughProperty("S2postxt")>
		Private _S2postxt As TextBox

		' Token: 0x04000165 RID: 357
		<AccessedThroughProperty("S1postxt")>
		Private _S1postxt As TextBox

		' Token: 0x04000166 RID: 358
		<AccessedThroughProperty("GroupBox3")>
		Private _GroupBox3 As GroupBox

		' Token: 0x04000167 RID: 359
		<AccessedThroughProperty("Usrfrmtxt")>
		Private _Usrfrmtxt As TextBox

		' Token: 0x04000168 RID: 360
		<AccessedThroughProperty("Cnfrm_btn")>
		Private _Cnfrm_btn As Button

		' Token: 0x04000169 RID: 361
		<AccessedThroughProperty("Cncl_btn")>
		Private _Cncl_btn As Button

		' Token: 0x0400016A RID: 362
		<AccessedThroughProperty("Upload_btn")>
		Private _Upload_btn As Button

		' Token: 0x0400016B RID: 363
		<AccessedThroughProperty("Label6")>
		Private _Label6 As Label

		' Token: 0x0400016C RID: 364
		<AccessedThroughProperty("Label5")>
		Private _Label5 As Label

		' Token: 0x0400016D RID: 365
		<AccessedThroughProperty("Label4")>
		Private _Label4 As Label

		' Token: 0x0400016E RID: 366
		<AccessedThroughProperty("Label3")>
		Private _Label3 As Label

		' Token: 0x0400016F RID: 367
		<AccessedThroughProperty("Label2")>
		Private _Label2 As Label

		' Token: 0x04000170 RID: 368
		<AccessedThroughProperty("Label1")>
		Private _Label1 As Label

		' Token: 0x04000171 RID: 369
		<AccessedThroughProperty("Label8")>
		Private _Label8 As Label

		' Token: 0x04000172 RID: 370
		<AccessedThroughProperty("Label7")>
		Private _Label7 As Label

		' Token: 0x04000173 RID: 371
		<AccessedThroughProperty("GridView")>
		Private _GridView As DataGridView

		' Token: 0x04000174 RID: 372
		<AccessedThroughProperty("Upbutton")>
		Private _Upbutton As Button

		' Token: 0x04000175 RID: 373
		<AccessedThroughProperty("Downbutton")>
		Private _Downbutton As Button

		' Token: 0x04000176 RID: 374
		<AccessedThroughProperty("Delbutton")>
		Private _Delbutton As Button

		' Token: 0x04000177 RID: 375
		<AccessedThroughProperty("GroupBox4")>
		Private _GroupBox4 As GroupBox

		' Token: 0x04000178 RID: 376
		<AccessedThroughProperty("Label9")>
		Private _Label9 As Label

		' Token: 0x04000179 RID: 377
		<AccessedThroughProperty("Powertxt")>
		Private _Powertxt As TextBox

		' Token: 0x0400017A RID: 378
		<AccessedThroughProperty("Label10")>
		Private _Label10 As Label

		' Token: 0x0400017B RID: 379
		<AccessedThroughProperty("MenuStrip1")>
		Private _MenuStrip1 As MenuStrip

		' Token: 0x0400017C RID: 380
		<AccessedThroughProperty("ToolStripMenuItem1")>
		Private _ToolStripMenuItem1 As ToolStripMenuItem

		' Token: 0x0400017D RID: 381
		<AccessedThroughProperty("LoadDataFileToolStripMenuItem")>
		Private _LoadDataFileToolStripMenuItem As ToolStripMenuItem

		' Token: 0x0400017E RID: 382
		<AccessedThroughProperty("SaveDataFileToolStripMenuItem")>
		Private _SaveDataFileToolStripMenuItem As ToolStripMenuItem

		' Token: 0x0400017F RID: 383
		<AccessedThroughProperty("Label11")>
		Private _Label11 As Label

		' Token: 0x04000180 RID: 384
		<AccessedThroughProperty("Beamdiatxt")>
		Private _Beamdiatxt As TextBox

		' Token: 0x04000181 RID: 385
		<AccessedThroughProperty("ConstBeam")>
		Private _ConstBeam As CheckBox

		' Token: 0x04000182 RID: 386
		Private Uframe As String

		' Token: 0x04000183 RID: 387
		Private Toolno As Integer

		' Token: 0x04000184 RID: 388
		Private Rconf As Integer

		' Token: 0x04000185 RID: 389
		Private table As DataTable

		' Token: 0x04000186 RID: 390
		Private rowIndex As Integer

		' Token: 0x04000187 RID: 391
		Private currIndex As Integer

		' Token: 0x04000188 RID: 392
		Private TempPos As Double()

		' Token: 0x04000189 RID: 393
		Private tempfilename As String
	End Class
End Namespace
