Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.IO
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic.CompilerServices

Namespace WindowsApplication1
	' Token: 0x0200000C RID: 12
	<DesignerGenerated()>
	Public Partial Class ConnectionSettings
		Inherits Form

		' Token: 0x0600015C RID: 348 RVA: 0x00023D3C File Offset: 0x0002213C
		<DebuggerNonUserCode()>
		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.Settings_Load
			Me.InitializeComponent()
		End Sub

		' Token: 0x1700007D RID: 125
		' (get) Token: 0x0600015F RID: 351 RVA: 0x000243A8 File Offset: 0x000227A8
		' (set) Token: 0x06000160 RID: 352 RVA: 0x000243BC File Offset: 0x000227BC
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

		' Token: 0x1700007E RID: 126
		' (get) Token: 0x06000161 RID: 353 RVA: 0x00024408 File Offset: 0x00022808
		' (set) Token: 0x06000162 RID: 354 RVA: 0x0002441C File Offset: 0x0002281C
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

		' Token: 0x1700007F RID: 127
		' (get) Token: 0x06000163 RID: 355 RVA: 0x00024468 File Offset: 0x00022868
		' (set) Token: 0x06000164 RID: 356 RVA: 0x0002447C File Offset: 0x0002287C
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

		' Token: 0x17000080 RID: 128
		' (get) Token: 0x06000165 RID: 357 RVA: 0x00024488 File Offset: 0x00022888
		' (set) Token: 0x06000166 RID: 358 RVA: 0x0002449C File Offset: 0x0002289C
		Friend Overridable Property basedirtxt As TextBox
			<DebuggerNonUserCode()>
			Get
				Return Me._basedirtxt
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Me._basedirtxt = value
			End Set
		End Property

		' Token: 0x17000081 RID: 129
		' (get) Token: 0x06000167 RID: 359 RVA: 0x000244A8 File Offset: 0x000228A8
		' (set) Token: 0x06000168 RID: 360 RVA: 0x000244BC File Offset: 0x000228BC
		Friend Overridable Property Browse As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._Browse
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = AddressOf Me.Browse_Click
				If Me._Browse IsNot Nothing Then
					RemoveHandler Me._Browse.Click, value2
				End If
				Me._Browse = value
				If Me._Browse IsNot Nothing Then
					AddHandler Me._Browse.Click, value2
				End If
			End Set
		End Property

		' Token: 0x17000082 RID: 130
		' (get) Token: 0x06000169 RID: 361 RVA: 0x00024508 File Offset: 0x00022908
		' (set) Token: 0x0600016A RID: 362 RVA: 0x0002451C File Offset: 0x0002291C
		Friend Overridable Property Ipaddrtxt As MaskedTextBox
			<DebuggerNonUserCode()>
			Get
				Return Me._Ipaddrtxt
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As MaskedTextBox)
				Me._Ipaddrtxt = value
			End Set
		End Property

		' Token: 0x17000083 RID: 131
		' (get) Token: 0x0600016B RID: 363 RVA: 0x00024528 File Offset: 0x00022928
		' (set) Token: 0x0600016C RID: 364 RVA: 0x0002453C File Offset: 0x0002293C
		Friend Overridable Property FolderBrowserDialog1 As FolderBrowserDialog
			<DebuggerNonUserCode()>
			Get
				Return Me._FolderBrowserDialog1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As FolderBrowserDialog)
				Me._FolderBrowserDialog1 = value
			End Set
		End Property

		' Token: 0x0600016D RID: 365 RVA: 0x00024548 File Offset: 0x00022948
		Private Sub Cnfrmbtn_Click(sender As Object, e As EventArgs)
			Dim fs As FileStream = New FileStream(Application.StartupPath + "\settings.txt", FileMode.Create)
			Dim w As StreamWriter = New StreamWriter(fs)
			Positioncal.BasePath = Me.basedirtxt.Text
			Positioncal.ipaddress = Me.Ipaddrtxt.Text
			w.WriteLine(Me.basedirtxt.Text)
			w.WriteLine(Me.Ipaddrtxt.Text)
			w.Close()
			Me.DialogResult = DialogResult.OK
			Me.Close()
		End Sub

		' Token: 0x0600016E RID: 366 RVA: 0x000245C8 File Offset: 0x000229C8
		Private Sub Cnlbtn_Click(sender As Object, e As EventArgs)
			Me.DialogResult = DialogResult.Cancel
			Me.Close()
		End Sub

		' Token: 0x0600016F RID: 367 RVA: 0x000245D8 File Offset: 0x000229D8
		Private Sub Browse_Click(sender As Object, e As EventArgs)
			Me.FolderBrowserDialog1.ShowDialog()
			Me.basedirtxt.Text = Me.FolderBrowserDialog1.SelectedPath + "\"
		End Sub

		' Token: 0x06000170 RID: 368 RVA: 0x00024608 File Offset: 0x00022A08
		Private Sub Settings_Load(sender As Object, e As EventArgs)
			Me.basedirtxt.Text = Positioncal.BasePath
			Me.Ipaddrtxt.Text = Positioncal.ipaddress
		End Sub

		' Token: 0x04000084 RID: 132
		<AccessedThroughProperty("Cnlbtn")>
		Private _Cnlbtn As Button

		' Token: 0x04000085 RID: 133
		<AccessedThroughProperty("Cnfrmbtn")>
		Private _Cnfrmbtn As Button

		' Token: 0x04000086 RID: 134
		<AccessedThroughProperty("GroupBox1")>
		Private _GroupBox1 As GroupBox

		' Token: 0x04000087 RID: 135
		<AccessedThroughProperty("basedirtxt")>
		Private _basedirtxt As TextBox

		' Token: 0x04000088 RID: 136
		<AccessedThroughProperty("Browse")>
		Private _Browse As Button

		' Token: 0x04000089 RID: 137
		<AccessedThroughProperty("Ipaddrtxt")>
		Private _Ipaddrtxt As MaskedTextBox

		' Token: 0x0400008A RID: 138
		<AccessedThroughProperty("FolderBrowserDialog1")>
		Private _FolderBrowserDialog1 As FolderBrowserDialog
	End Class
End Namespace
