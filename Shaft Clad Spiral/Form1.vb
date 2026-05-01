Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Diagnostics
Imports System.Drawing
Imports System.IO
Imports System.Runtime.CompilerServices
Imports System.Text
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports WindowsApplication1.My

Namespace WindowsApplication1
	' Token: 0x0200000E RID: 14
	<DesignerGenerated()>
	Public Partial Class Form1
		Inherits Form

		' Token: 0x060001C7 RID: 455 RVA: 0x0002813C File Offset: 0x0002653C
		<DebuggerNonUserCode()>
		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.Form1_Load
			Me.InitializeComponent()
		End Sub

		' Token: 0x170000A1 RID: 161
		' (get) Token: 0x060001CA RID: 458 RVA: 0x000296A8 File Offset: 0x00027AA8
		' (set) Token: 0x060001CB RID: 459 RVA: 0x000296BC File Offset: 0x00027ABC
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

		' Token: 0x170000A2 RID: 162
		' (get) Token: 0x060001CC RID: 460 RVA: 0x000296C8 File Offset: 0x00027AC8
		' (set) Token: 0x060001CD RID: 461 RVA: 0x000296DC File Offset: 0x00027ADC
		Friend Overridable Property FileToolStripMenuItem As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._FileToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Me._FileToolStripMenuItem = value
			End Set
		End Property

		' Token: 0x170000A3 RID: 163
		' (get) Token: 0x060001CE RID: 462 RVA: 0x000296E8 File Offset: 0x00027AE8
		' (set) Token: 0x060001CF RID: 463 RVA: 0x000296FC File Offset: 0x00027AFC
		Friend Overridable Property OpenProjectToolStripMenuItem1 As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._OpenProjectToolStripMenuItem1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.OpenProjectToolStripMenuItem1_Click
				If Me._OpenProjectToolStripMenuItem1 IsNot Nothing Then
					RemoveHandler Me._OpenProjectToolStripMenuItem1.Click, value2
				End If
				Me._OpenProjectToolStripMenuItem1 = value
				If Me._OpenProjectToolStripMenuItem1 IsNot Nothing Then
					AddHandler Me._OpenProjectToolStripMenuItem1.Click, value2
				End If
			End Set
		End Property

		' Token: 0x170000A4 RID: 164
		' (get) Token: 0x060001D0 RID: 464 RVA: 0x00029748 File Offset: 0x00027B48
		' (set) Token: 0x060001D1 RID: 465 RVA: 0x0002975C File Offset: 0x00027B5C
		Friend Overridable Property SaveToolStripMenuItem As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._SaveToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.SaveToolStripMenuItem_Click
				If Me._SaveToolStripMenuItem IsNot Nothing Then
					RemoveHandler Me._SaveToolStripMenuItem.Click, value2
				End If
				Me._SaveToolStripMenuItem = value
				If Me._SaveToolStripMenuItem IsNot Nothing Then
					AddHandler Me._SaveToolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		' Token: 0x170000A5 RID: 165
		' (get) Token: 0x060001D2 RID: 466 RVA: 0x000297A8 File Offset: 0x00027BA8
		' (set) Token: 0x060001D3 RID: 467 RVA: 0x000297BC File Offset: 0x00027BBC
		Friend Overridable Property SaveAsToolStripMenuItem As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._SaveAsToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.SaveAsToolStripMenuItem_Click
				If Me._SaveAsToolStripMenuItem IsNot Nothing Then
					RemoveHandler Me._SaveAsToolStripMenuItem.Click, value2
				End If
				Me._SaveAsToolStripMenuItem = value
				If Me._SaveAsToolStripMenuItem IsNot Nothing Then
					AddHandler Me._SaveAsToolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		' Token: 0x170000A6 RID: 166
		' (get) Token: 0x060001D4 RID: 468 RVA: 0x00029808 File Offset: 0x00027C08
		' (set) Token: 0x060001D5 RID: 469 RVA: 0x0002981C File Offset: 0x00027C1C
		Friend Overridable Property CloseProjectToolStripMenuItem As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._CloseProjectToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.CloseProjectToolStripMenuItem_Click
				If Me._CloseProjectToolStripMenuItem IsNot Nothing Then
					RemoveHandler Me._CloseProjectToolStripMenuItem.Click, value2
				End If
				Me._CloseProjectToolStripMenuItem = value
				If Me._CloseProjectToolStripMenuItem IsNot Nothing Then
					AddHandler Me._CloseProjectToolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		' Token: 0x170000A7 RID: 167
		' (get) Token: 0x060001D6 RID: 470 RVA: 0x00029868 File Offset: 0x00027C68
		' (set) Token: 0x060001D7 RID: 471 RVA: 0x0002987C File Offset: 0x00027C7C
		Friend Overridable Property ExitToolStripMenuItem As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._ExitToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.ExitToolStripMenuItem_Click
				If Me._ExitToolStripMenuItem IsNot Nothing Then
					RemoveHandler Me._ExitToolStripMenuItem.Click, value2
				End If
				Me._ExitToolStripMenuItem = value
				If Me._ExitToolStripMenuItem IsNot Nothing Then
					AddHandler Me._ExitToolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		' Token: 0x170000A8 RID: 168
		' (get) Token: 0x060001D8 RID: 472 RVA: 0x000298C8 File Offset: 0x00027CC8
		' (set) Token: 0x060001D9 RID: 473 RVA: 0x000298DC File Offset: 0x00027CDC
		Friend Overridable Property HelpToolStripMenuItem As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._HelpToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Me._HelpToolStripMenuItem = value
			End Set
		End Property

		' Token: 0x170000A9 RID: 169
		' (get) Token: 0x060001DA RID: 474 RVA: 0x000298E8 File Offset: 0x00027CE8
		' (set) Token: 0x060001DB RID: 475 RVA: 0x000298FC File Offset: 0x00027CFC
		Friend Overridable Property processcycle As ComboBox
			<DebuggerNonUserCode()>
			Get
				Return Me._processcycle
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ComboBox)
				Dim value2 As EventHandler = AddressOf Me.processcycle_SelectedIndexChanged
				If Me._processcycle IsNot Nothing Then
					RemoveHandler Me._processcycle.SelectedIndexChanged, value2
				End If
				Me._processcycle = value
				If Me._processcycle IsNot Nothing Then
					AddHandler Me._processcycle.SelectedIndexChanged, value2
				End If
			End Set
		End Property

		' Token: 0x170000AA RID: 170
		' (get) Token: 0x060001DC RID: 476 RVA: 0x00029948 File Offset: 0x00027D48
		' (set) Token: 0x060001DD RID: 477 RVA: 0x0002995C File Offset: 0x00027D5C
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

		' Token: 0x170000AB RID: 171
		' (get) Token: 0x060001DE RID: 478 RVA: 0x00029968 File Offset: 0x00027D68
		' (set) Token: 0x060001DF RID: 479 RVA: 0x0002997C File Offset: 0x00027D7C
		Friend Overridable Property HelpToolStripMenuItem1 As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._HelpToolStripMenuItem1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Me._HelpToolStripMenuItem1 = value
			End Set
		End Property

		' Token: 0x170000AC RID: 172
		' (get) Token: 0x060001E0 RID: 480 RVA: 0x00029988 File Offset: 0x00027D88
		' (set) Token: 0x060001E1 RID: 481 RVA: 0x0002999C File Offset: 0x00027D9C
		Friend Overridable Property AboutToolStripMenuItem As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._AboutToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Me._AboutToolStripMenuItem = value
			End Set
		End Property

		' Token: 0x170000AD RID: 173
		' (get) Token: 0x060001E2 RID: 482 RVA: 0x000299A8 File Offset: 0x00027DA8
		' (set) Token: 0x060001E3 RID: 483 RVA: 0x000299BC File Offset: 0x00027DBC
		Friend Overridable Property Quitbtn As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._Quitbtn
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = AddressOf Me.Cnfrmbtn_Click
				If Me._Quitbtn IsNot Nothing Then
					RemoveHandler Me._Quitbtn.Click, value2
				End If
				Me._Quitbtn = value
				If Me._Quitbtn IsNot Nothing Then
					AddHandler Me._Quitbtn.Click, value2
				End If
			End Set
		End Property

		' Token: 0x170000AE RID: 174
		' (get) Token: 0x060001E4 RID: 484 RVA: 0x00029A08 File Offset: 0x00027E08
		' (set) Token: 0x060001E5 RID: 485 RVA: 0x00029A1C File Offset: 0x00027E1C
		Friend Overridable Property connect As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._connect
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = AddressOf Me.connect_Click
				If Me._connect IsNot Nothing Then
					RemoveHandler Me._connect.Click, value2
				End If
				Me._connect = value
				If Me._connect IsNot Nothing Then
					AddHandler Me._connect.Click, value2
				End If
			End Set
		End Property

		' Token: 0x170000AF RID: 175
		' (get) Token: 0x060001E6 RID: 486 RVA: 0x00029A68 File Offset: 0x00027E68
		' (set) Token: 0x060001E7 RID: 487 RVA: 0x00029A7C File Offset: 0x00027E7C
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

		' Token: 0x170000B0 RID: 176
		' (get) Token: 0x060001E8 RID: 488 RVA: 0x00029A88 File Offset: 0x00027E88
		' (set) Token: 0x060001E9 RID: 489 RVA: 0x00029A9C File Offset: 0x00027E9C
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

		' Token: 0x170000B1 RID: 177
		' (get) Token: 0x060001EA RID: 490 RVA: 0x00029AA8 File Offset: 0x00027EA8
		' (set) Token: 0x060001EB RID: 491 RVA: 0x00029ABC File Offset: 0x00027EBC
		Friend Overridable Property hold As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._hold
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = AddressOf Me.hold_Click
				If Me._hold IsNot Nothing Then
					RemoveHandler Me._hold.Click, value2
				End If
				Me._hold = value
				If Me._hold IsNot Nothing Then
					AddHandler Me._hold.Click, value2
				End If
			End Set
		End Property

		' Token: 0x170000B2 RID: 178
		' (get) Token: 0x060001EC RID: 492 RVA: 0x00029B08 File Offset: 0x00027F08
		' (set) Token: 0x060001ED RID: 493 RVA: 0x00029B1C File Offset: 0x00027F1C
		Friend Overridable Property run As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._run
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Me._run = value
			End Set
		End Property

		' Token: 0x170000B3 RID: 179
		' (get) Token: 0x060001EE RID: 494 RVA: 0x00029B28 File Offset: 0x00027F28
		' (set) Token: 0x060001EF RID: 495 RVA: 0x00029B3C File Offset: 0x00027F3C
		Friend Overridable Property Download As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._Download
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = AddressOf Me.Download_Click
				If Me._Download IsNot Nothing Then
					RemoveHandler Me._Download.Click, value2
				End If
				Me._Download = value
				If Me._Download IsNot Nothing Then
					AddHandler Me._Download.Click, value2
				End If
			End Set
		End Property

		' Token: 0x170000B4 RID: 180
		' (get) Token: 0x060001F0 RID: 496 RVA: 0x00029B88 File Offset: 0x00027F88
		' (set) Token: 0x060001F1 RID: 497 RVA: 0x00029B9C File Offset: 0x00027F9C
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

		' Token: 0x170000B5 RID: 181
		' (get) Token: 0x060001F2 RID: 498 RVA: 0x00029BA8 File Offset: 0x00027FA8
		' (set) Token: 0x060001F3 RID: 499 RVA: 0x00029BBC File Offset: 0x00027FBC
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

		' Token: 0x170000B6 RID: 182
		' (get) Token: 0x060001F4 RID: 500 RVA: 0x00029BC8 File Offset: 0x00027FC8
		' (set) Token: 0x060001F5 RID: 501 RVA: 0x00029BDC File Offset: 0x00027FDC
		Friend Overridable Property Procsetupbtn As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._Procsetupbtn
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = AddressOf Me.Procsetupbtn_Click
				If Me._Procsetupbtn IsNot Nothing Then
					RemoveHandler Me._Procsetupbtn.Click, value2
				End If
				Me._Procsetupbtn = value
				If Me._Procsetupbtn IsNot Nothing Then
					AddHandler Me._Procsetupbtn.Click, value2
				End If
			End Set
		End Property

		' Token: 0x170000B7 RID: 183
		' (get) Token: 0x060001F6 RID: 502 RVA: 0x00029C28 File Offset: 0x00028028
		' (set) Token: 0x060001F7 RID: 503 RVA: 0x00029C3C File Offset: 0x0002803C
		Friend Overridable Property ConnectionSettingsToolStripMenuItem As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._ConnectionSettingsToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.ConnectionSettingsToolStripMenuItem_Click
				If Me._ConnectionSettingsToolStripMenuItem IsNot Nothing Then
					RemoveHandler Me._ConnectionSettingsToolStripMenuItem.Click, value2
				End If
				Me._ConnectionSettingsToolStripMenuItem = value
				If Me._ConnectionSettingsToolStripMenuItem IsNot Nothing Then
					AddHandler Me._ConnectionSettingsToolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		' Token: 0x170000B8 RID: 184
		' (get) Token: 0x060001F8 RID: 504 RVA: 0x00029C88 File Offset: 0x00028088
		' (set) Token: 0x060001F9 RID: 505 RVA: 0x00029C9C File Offset: 0x0002809C
		Friend Overridable Property MisselaneousSettingsToolStripMenuItem As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._MisselaneousSettingsToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.MisselaneousSettingsToolStripMenuItem_Click
				If Me._MisselaneousSettingsToolStripMenuItem IsNot Nothing Then
					RemoveHandler Me._MisselaneousSettingsToolStripMenuItem.Click, value2
				End If
				Me._MisselaneousSettingsToolStripMenuItem = value
				If Me._MisselaneousSettingsToolStripMenuItem IsNot Nothing Then
					AddHandler Me._MisselaneousSettingsToolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		' Token: 0x170000B9 RID: 185
		' (get) Token: 0x060001FA RID: 506 RVA: 0x00029CE8 File Offset: 0x000280E8
		' (set) Token: 0x060001FB RID: 507 RVA: 0x00029CFC File Offset: 0x000280FC
		Friend Overridable Property Timer1 As Timer
			<DebuggerNonUserCode()>
			Get
				Return Me._Timer1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Timer)
				Dim value2 As EventHandler = AddressOf Me.Timer1_Tick
				If Me._Timer1 IsNot Nothing Then
					RemoveHandler Me._Timer1.Tick, value2
				End If
				Me._Timer1 = value
				If Me._Timer1 IsNot Nothing Then
					AddHandler Me._Timer1.Tick, value2
				End If
			End Set
		End Property

		' Token: 0x170000BA RID: 186
		' (get) Token: 0x060001FC RID: 508 RVA: 0x00029D48 File Offset: 0x00028148
		' (set) Token: 0x060001FD RID: 509 RVA: 0x00029D5C File Offset: 0x0002815C
		Friend Overridable Property Countdown As Label
			<DebuggerNonUserCode()>
			Get
				Return Me._Countdown
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._Countdown = value
			End Set
		End Property

		' Token: 0x170000BB RID: 187
		' (get) Token: 0x060001FE RID: 510 RVA: 0x00029D68 File Offset: 0x00028168
		' (set) Token: 0x060001FF RID: 511 RVA: 0x00029D7C File Offset: 0x0002817C
		Friend Overridable Property Offlinecheck As CheckBox
			<DebuggerNonUserCode()>
			Get
				Return Me._Offlinecheck
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As CheckBox)
				Dim value2 As EventHandler = AddressOf Me.Offlinecheck_CheckedChanged
				If Me._Offlinecheck IsNot Nothing Then
					RemoveHandler Me._Offlinecheck.CheckedChanged, value2
				End If
				Me._Offlinecheck = value
				If Me._Offlinecheck IsNot Nothing Then
					AddHandler Me._Offlinecheck.CheckedChanged, value2
				End If
			End Set
		End Property

		' Token: 0x170000BC RID: 188
		' (get) Token: 0x06000200 RID: 512 RVA: 0x00029DC8 File Offset: 0x000281C8
		' (set) Token: 0x06000201 RID: 513 RVA: 0x00029DDC File Offset: 0x000281DC
		Friend Overridable Property Progress As Label
			<DebuggerNonUserCode()>
			Get
				Return Me._Progress
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._Progress = value
			End Set
		End Property

		' Token: 0x170000BD RID: 189
		' (get) Token: 0x06000202 RID: 514 RVA: 0x00029DE8 File Offset: 0x000281E8
		' (set) Token: 0x06000203 RID: 515 RVA: 0x00029DFC File Offset: 0x000281FC
		Friend Overridable Property ProgressBar As ProgressBar
			<DebuggerNonUserCode()>
			Get
				Return Me._ProgressBar
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ProgressBar)
				Me._ProgressBar = value
			End Set
		End Property

		' Token: 0x170000BE RID: 190
		' (get) Token: 0x06000204 RID: 516 RVA: 0x00029E08 File Offset: 0x00028208
		' (set) Token: 0x06000205 RID: 517 RVA: 0x00029E1C File Offset: 0x0002821C
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

		' Token: 0x170000BF RID: 191
		' (get) Token: 0x06000206 RID: 518 RVA: 0x00029E28 File Offset: 0x00028228
		' (set) Token: 0x06000207 RID: 519 RVA: 0x00029E3C File Offset: 0x0002823C
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

		' Token: 0x170000C0 RID: 192
		' (get) Token: 0x06000208 RID: 520 RVA: 0x00029E48 File Offset: 0x00028248
		' (set) Token: 0x06000209 RID: 521 RVA: 0x00029E5C File Offset: 0x0002825C
		Friend Overridable Property RZCoord As TextBox
			<DebuggerNonUserCode()>
			Get
				Return Me._RZCoord
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Me._RZCoord = value
			End Set
		End Property

		' Token: 0x170000C1 RID: 193
		' (get) Token: 0x0600020A RID: 522 RVA: 0x00029E68 File Offset: 0x00028268
		' (set) Token: 0x0600020B RID: 523 RVA: 0x00029E7C File Offset: 0x0002827C
		Friend Overridable Property RYCoord As TextBox
			<DebuggerNonUserCode()>
			Get
				Return Me._RYCoord
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Me._RYCoord = value
			End Set
		End Property

		' Token: 0x170000C2 RID: 194
		' (get) Token: 0x0600020C RID: 524 RVA: 0x00029E88 File Offset: 0x00028288
		' (set) Token: 0x0600020D RID: 525 RVA: 0x00029E9C File Offset: 0x0002829C
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

		' Token: 0x170000C3 RID: 195
		' (get) Token: 0x0600020E RID: 526 RVA: 0x00029EA8 File Offset: 0x000282A8
		' (set) Token: 0x0600020F RID: 527 RVA: 0x00029EBC File Offset: 0x000282BC
		Friend Overridable Property RXCoord As TextBox
			<DebuggerNonUserCode()>
			Get
				Return Me._RXCoord
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Me._RXCoord = value
			End Set
		End Property

		' Token: 0x170000C4 RID: 196
		' (get) Token: 0x06000210 RID: 528 RVA: 0x00029EC8 File Offset: 0x000282C8
		' (set) Token: 0x06000211 RID: 529 RVA: 0x00029EDC File Offset: 0x000282DC
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

		' Token: 0x170000C5 RID: 197
		' (get) Token: 0x06000212 RID: 530 RVA: 0x00029EE8 File Offset: 0x000282E8
		' (set) Token: 0x06000213 RID: 531 RVA: 0x00029EFC File Offset: 0x000282FC
		Friend Overridable Property ZCoord As TextBox
			<DebuggerNonUserCode()>
			Get
				Return Me._ZCoord
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Me._ZCoord = value
			End Set
		End Property

		' Token: 0x170000C6 RID: 198
		' (get) Token: 0x06000214 RID: 532 RVA: 0x00029F08 File Offset: 0x00028308
		' (set) Token: 0x06000215 RID: 533 RVA: 0x00029F1C File Offset: 0x0002831C
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

		' Token: 0x170000C7 RID: 199
		' (get) Token: 0x06000216 RID: 534 RVA: 0x00029F28 File Offset: 0x00028328
		' (set) Token: 0x06000217 RID: 535 RVA: 0x00029F3C File Offset: 0x0002833C
		Friend Overridable Property YCoord As TextBox
			<DebuggerNonUserCode()>
			Get
				Return Me._YCoord
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Me._YCoord = value
			End Set
		End Property

		' Token: 0x170000C8 RID: 200
		' (get) Token: 0x06000218 RID: 536 RVA: 0x00029F48 File Offset: 0x00028348
		' (set) Token: 0x06000219 RID: 537 RVA: 0x00029F5C File Offset: 0x0002835C
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

		' Token: 0x170000C9 RID: 201
		' (get) Token: 0x0600021A RID: 538 RVA: 0x00029F68 File Offset: 0x00028368
		' (set) Token: 0x0600021B RID: 539 RVA: 0x00029F7C File Offset: 0x0002837C
		Friend Overridable Property XCoord As TextBox
			<DebuggerNonUserCode()>
			Get
				Return Me._XCoord
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Me._XCoord = value
			End Set
		End Property

		' Token: 0x0600021C RID: 540 RVA: 0x00029F88 File Offset: 0x00028388
		Private Sub Form1_Load(sender As Object, e As EventArgs)
			Me.Timer1.Start()
			Me.Timer1.Interval = 1000
			If MyProject.Computer.FileSystem.FileExists(Application.StartupPath + "\settings.txt") Then
				Dim fs As FileStream = New FileStream(Application.StartupPath + "\settings.txt", FileMode.Open)
				Dim r As StreamReader = New StreamReader(fs)
				Positioncal.BasePath = r.ReadLine()
				If Not MyProject.Computer.FileSystem.DirectoryExists(Positioncal.BasePath) Then
					Interaction.MsgBox("The base directory " + Positioncal.BasePath + " does not exist or is not accessible. C:\ will be used instead.", MsgBoxStyle.OkOnly, Nothing)
					Positioncal.BasePath = "c:\"
				End If
				Positioncal.ipaddress = r.ReadLine()
				r.Close()
			Else
				Positioncal.BasePath = "c:\"
				Positioncal.ipaddress = "192.168.002.002"
			End If
			If MyProject.Computer.FileSystem.FileExists(Application.StartupPath + "\miscsettings.txt") Then
				Dim fs2 As FileStream = New FileStream(Application.StartupPath + "\miscsettings.txt", FileMode.Open)
				Dim r2 As StreamReader = New StreamReader(fs2)
				Positioncal.IdleSpeed = Conversions.ToDouble(r2.ReadLine())
				Positioncal.ApproachSpeed = Conversions.ToDouble(r2.ReadLine())
				Positioncal.IniYAxisOffset = Conversions.ToDouble(r2.ReadLine())
				Positioncal.IniZAxisOffset = Conversions.ToDouble(r2.ReadLine())
				Positioncal.IniXAxisOffset = Conversions.ToDouble(r2.ReadLine())
				Positioncal.WorkXAxisOffset = Conversions.ToDouble(r2.ReadLine())
				Positioncal.WorkYAxisTilt = Conversions.ToDouble(r2.ReadLine())
				Positioncal.WorkZAxisYaw = Conversions.ToDouble(r2.ReadLine())
				Positioncal.PowderSettling1 = Conversions.ToDouble(r2.ReadLine())
				Positioncal.PowderSettling2 = Conversions.ToDouble(r2.ReadLine())
				Positioncal.PositionLevel = Conversions.ToInteger(r2.ReadLine())
				Positioncal.PPR = Conversions.ToInteger(r2.ReadLine())
				Positioncal.Tiltangle = Conversions.ToDouble(r2.ReadLine())
				Positioncal.MinDistance = Conversions.ToDouble(r2.ReadLine())
				Positioncal.MaxZRobotPos = Conversions.ToDouble(r2.ReadLine())
				Positioncal.DirectionFlg = Conversions.ToInteger(r2.ReadLine())
				r2.Close()
			Else
				Interaction.MsgBox("Miscellaneous settings file does not exist. Default settings will be used.", MsgBoxStyle.OkOnly, Nothing)
				Positioncal.IdleSpeed = 200.0
				Positioncal.ApproachSpeed = 50.0
				Positioncal.IniYAxisOffset = 0.0
				Positioncal.IniZAxisOffset = 300.0
				Positioncal.IniXAxisOffset = -200.0
				Positioncal.WorkXAxisOffset = -5.0
				Positioncal.WorkYAxisTilt = 0.0
				Positioncal.WorkZAxisYaw = 0.0
				Positioncal.PowderSettling1 = 10.0
				Positioncal.PowderSettling2 = 1.0
				Positioncal.PositionLevel = 4
				Positioncal.PPR = 5
				Positioncal.Tiltangle = 0.5
				Positioncal.MinDistance = 40.0
				Positioncal.MaxZRobotPos = 555000.0
				Positioncal.DirectionFlg = 1
			End If
			If MyProject.Computer.FileSystem.FileExists(Application.StartupPath + "\Processsettings.txt") Then
				Dim fs3 As FileStream = New FileStream(Application.StartupPath + "\Processsettings.txt", FileMode.Open)
				Dim r3 As StreamReader = New StreamReader(fs3)
				Positioncal.LaserPowerIni = Conversions.ToInteger(r3.ReadLine())
				Positioncal.LaserPowerFin = Conversions.ToInteger(r3.ReadLine())
				Positioncal.LaserReductionTrackNo = Conversions.ToInteger(r3.ReadLine())
				Positioncal.PowderFeed = Conversions.ToDouble(r3.ReadLine())
				Positioncal.PowderJar = Conversions.ToShort(r3.ReadLine())
				Positioncal.ProcessSpeed = Conversions.ToDouble(r3.ReadLine())
				Positioncal.CladWidth = Conversions.ToDouble(r3.ReadLine())
				Positioncal.IniOverPower = Conversions.ToInteger(r3.ReadLine())
				Positioncal.FinOverPower = Conversions.ToInteger(r3.ReadLine())
				Positioncal.IniOverPowerDis = Conversions.ToInteger(r3.ReadLine())
				Positioncal.FinOverPowerDis = Conversions.ToInteger(r3.ReadLine())
				Positioncal.IniPowderRed = Conversions.ToInteger(r3.ReadLine())
				Positioncal.FinPowderRed = Conversions.ToInteger(r3.ReadLine())
				r3.Close()
			Else
				Interaction.MsgBox("Process settings file does not exist. Default settings will be used.", MsgBoxStyle.OkOnly, Nothing)
				Positioncal.LaserPowerIni = 3600
				Positioncal.LaserPowerFin = 3150
				Positioncal.LaserReductionTrackNo = 3
				Positioncal.PowderFeed = 25.0
				Positioncal.PowderJar = 1S
				Positioncal.ProcessSpeed = 15.0
				Positioncal.CladWidth = 6.5
				Positioncal.IniOverPower = 10
				Positioncal.FinOverPower = 20
				Positioncal.IniOverPowerDis = 10
				Positioncal.FinOverPowerDis = 20
				Positioncal.IniPowderRed = 5
				Positioncal.FinPowderRed = 5
			End If
			Me.processcycle.Items.Clear()
			Me.processcycle.Items.Add("Shaft Plain")
			Me.processcycle.Items.Add("Shaft With Key Hole")
			Me.processcycle.Items.Add("Conical")
			Me.processcycle.Items.Add("Crank")
			Me.processcycle.Items.Add("Plane-Rectangular")
			Me.processcycle.Items.Add("Bore")
			Me.processcycle.Items.Add("Pocket")
			Me.processcycle.Items.Add("Groove")
			Me.processcycle.Items.Add("Conical Groove")
			Me.processcycle.Items.Add("3D Clad")
			Me.processcycle.Enabled = False
			MyProject.Forms.Processsetup.Enabled = True
			Me.run.Text = "Stopped"
			Me.run.Enabled = False
			Me.hold.Enabled = False
			Me.Download.Enabled = False
			Me.SaveToolStripMenuItem.Enabled = False
			Me.SaveAsToolStripMenuItem.Enabled = False
			Me.CloseProjectToolStripMenuItem.Enabled = False
			Me.XCoord.Enabled = False
			Me.YCoord.Enabled = False
			Me.ZCoord.Enabled = False
			Me.RXCoord.Enabled = False
			Me.RYCoord.Enabled = False
			Me.RZCoord.Enabled = False
			Me.ProgressBar.Enabled = False
			Me.ProgressBar.Maximum = 0
		End Sub

		' Token: 0x0600021D RID: 541 RVA: 0x0002A5E8 File Offset: 0x000289E8
		<MethodImpl(MethodImplOptions.NoInlining Or MethodImplOptions.NoOptimization)>
		Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Connection.MS_BscCloseComm(Connection.nCid)
			ProjectData.EndApp()
		End Sub

		' Token: 0x0600021E RID: 542 RVA: 0x0002A5FC File Offset: 0x000289FC
		<MethodImpl(MethodImplOptions.NoInlining Or MethodImplOptions.NoOptimization)>
		Private Sub Cnfrmbtn_Click(sender As Object, e As EventArgs)
			Connection.MS_BscCloseComm(Connection.nCid)
			ProjectData.EndApp()
		End Sub

		' Token: 0x0600021F RID: 543 RVA: 0x0002A610 File Offset: 0x00028A10
		Private Sub connect_Click(sender As Object, e As EventArgs)
			Connection.Ms_BscOpenComm(Positioncal.ipaddress, Positioncal.BasePath, 0, CLng(Me.Handle.ToInt32()))
			If Connection.ret = 1 Then
				Me.connect.Text = "Connected"
				Me.connect.ForeColor = Color.Green
				Positioncal.ConectStat = 1S
				If Me.formatstat = 1S Then
					Me.Download.Enabled = True
				Else
					Me.Download.Enabled = False
				End If
			Else
				Interaction.MsgBox("Connection Failure", MsgBoxStyle.Exclamation, Nothing)
				Me.connect.Text = "Disconnected"
				Me.connect.ForeColor = Color.Red
				Positioncal.ConectStat = 0S
			End If
		End Sub

		' Token: 0x06000220 RID: 544 RVA: 0x0002A6C4 File Offset: 0x00028AC4
		Private Sub disconnect_Click(sender As Object, e As EventArgs)
			' The following expression was wrapped in a checked-expression
			Dim closecomconf As Short = CShort(Connection.MS_BscCloseComm(Connection.nCid))
			If closecomconf = 0S Then
				Me.connect.Enabled = True
				Me.run.Enabled = False
				Me.Download.Enabled = False
				Positioncal.ConectStat = 0S
			End If
		End Sub

		' Token: 0x06000221 RID: 545 RVA: 0x0002A70C File Offset: 0x00028B0C
		Private Sub Download_Click(sender As Object, e As EventArgs)
			processparam.paramset(Positioncal.LaserPowerIni, Positioncal.PowderFeed, CInt(Positioncal.PowderJar), Me.Handle.ToInt32())
			Select Case Positioncal.ProcCycle
				Case 0S
					Positioncal.crankclad2(Positioncal.Diameter, 0.01, Positioncal.Width1, Positioncal.Distance, Positioncal.Pitch, Positioncal.ProcessSpeed, 0.0, 0.0, 1.0, 1, 0.0, 0.0, Positioncal.PostureAngle, Positioncal.ConeAngle, Positioncal.IniOverWeld, Positioncal.FinOverWeld, Positioncal.MeanderAmp, Positioncal.MeanderFlg, Positioncal.InitialAng, Positioncal.ToolOffset, 0S, Me.Handle.ToInt32())
				Case 1S
					Positioncal.keyholeclad(Positioncal.Diameter, Positioncal.Width1, Positioncal.Distance, Positioncal.Pitch, Positioncal.ProcessSpeed, Positioncal.KeyDistance, Positioncal.KeyWidth, Positioncal.KeyLength, Positioncal.KeyAngle, Positioncal.PostureAngle, Positioncal.ConeAngle, Positioncal.IniOverWeld, Positioncal.MeanderAmp, Positioncal.MeanderFlg, Positioncal.InitialAng, Me.Handle.ToInt32())
				Case 2S
					Positioncal.valveclad2(Positioncal.Diameter, Positioncal.Width1, Positioncal.Distance, Positioncal.Pitch, Positioncal.ProcessSpeed, 0.0, 0.0, 0.0, 1, 0.0, 0.0, Positioncal.PostureAngle, Positioncal.ConeAngle, Positioncal.StationPosition, Positioncal.IniOverWeld, Positioncal.FinOverWeld, Positioncal.MeanderAmp, Positioncal.MeanderFlg, Positioncal.InitialAng, If((-If((Positioncal.ValveFlg > False), 1, 0)), 1, 0), Positioncal.ToolOffset, 0S, Me.Handle.ToInt32())
				Case 3S
					Positioncal.crankclad2(Positioncal.Diameter, Positioncal.CrankThrow, Positioncal.Width1, Positioncal.Distance, Positioncal.Pitch, Positioncal.ProcessSpeed, 0.0, 0.0, 1.0, 1, 0.0, 0.0, Positioncal.PostureAngle, Positioncal.ConeAngle, Positioncal.IniOverWeld, Positioncal.FinOverWeld, Positioncal.MeanderAmp, Positioncal.MeanderFlg, Positioncal.InitialAng, Positioncal.ToolOffset, 1S, Me.Handle.ToInt32())
				Case 4S
					Positioncal.Planeclad(Positioncal.Length, Positioncal.Width1, Positioncal.Xpos, Positioncal.Ypos, Positioncal.Zpos, Positioncal.Pitch, Positioncal.ProcessSpeed, Positioncal.PostureAngle, Positioncal.MeanderAmp, Positioncal.MeanderFlg, Positioncal.ToolOffset, Me.Handle.ToInt32())
				Case 5S
					Positioncal.boreclad(Positioncal.Diameter, Positioncal.Width1, Positioncal.Distance, Positioncal.Pitch, Positioncal.ProcessSpeed, Positioncal.PostureAngle, Positioncal.ConeAngle, Positioncal.StationPosition, Positioncal.IniOverWeld, Positioncal.FinOverWeld, Positioncal.MeanderAmp, Positioncal.MeanderFlg, Positioncal.InitialAng, Positioncal.ToolOffset, Me.Handle.ToInt32())
				Case 6S
					Positioncal.pocketclad(Positioncal.Diameter, Positioncal.Width1, Positioncal.Xpos, Positioncal.Ypos, Positioncal.Zpos, Positioncal.Pitch, Positioncal.ProcessSpeed, Positioncal.PostureAngle, Positioncal.ConeAngle, Positioncal.IniOverWeld, Positioncal.FinOverWeld, Positioncal.InitialAng, Positioncal.ToolOffset, Me.Handle.ToInt32())
				Case 7S
					Positioncal.crankclad2(Positioncal.Diameter, 0.01, Positioncal.Width1, Positioncal.Distance, Positioncal.Pitch, Positioncal.ProcessSpeed, Positioncal.Leftangle, Positioncal.Rightangle, Positioncal.Layerheight, Positioncal.Layernumber, CDbl(Positioncal.Intoverweld), Positioncal.Rockangle, Positioncal.PostureAngle, Positioncal.ConeAngle, Positioncal.IniOverWeld, Positioncal.FinOverWeld, Positioncal.MeanderAmp, Positioncal.MeanderFlg, Positioncal.InitialAng, Positioncal.ToolOffset, Positioncal.Rockangvar, Me.Handle.ToInt32())
				Case 8S
					Positioncal.valveclad2(Positioncal.Diameter, Positioncal.Width1, Positioncal.Distance, Positioncal.Pitch, Positioncal.ProcessSpeed, Positioncal.Leftangle, Positioncal.Rightangle, Positioncal.Layerheight, Positioncal.Layernumber, CDbl(Positioncal.Intoverweld), Positioncal.Rockangle, Positioncal.PostureAngle, Positioncal.ConeAngle, Positioncal.StationPosition, Positioncal.IniOverWeld, Positioncal.FinOverWeld, Positioncal.MeanderAmp, Positioncal.MeanderFlg, Positioncal.InitialAng, If((-If((Positioncal.ValveFlg > False), 1, 0)), 1, 0), Positioncal.ToolOffset, Positioncal.Rockangvar, Me.Handle.ToInt32())
				Case 9S
					Dim processSpeed As Double = Positioncal.ProcessSpeed
					Dim claddingDir As Short = CShort(Positioncal.CladdingDir)
					Positioncal.ThreeDclad(Positioncal.Width1, Positioncal.Pitch, processSpeed, Positioncal.ToolOffset, Positioncal.StationPosition, Positioncal.MovDir, Positioncal.ArrDir, claddingDir, Positioncal.MeanderAmp, Positioncal.MeanderPitch, Positioncal.MeanderFlg, Positioncal.Copies, Positioncal.Arrayrecptc, Positioncal.Arrayangptc, Me.Handle.ToInt32())
					Positioncal.CladdingDir = CInt(claddingDir)
			End Select
			Dim remmode As Short = MotoCom32.BscIsRemoteMode(CShort(Connection.nCid))
			If remmode = 0S Then
				Interaction.MsgBox("Please set controller to remote mode", MsgBoxStyle.OkOnly, Nothing)
			ElseIf remmode = 1S Then
				Dim nCid As Short = CShort(Connection.nCid)
				Dim text As String = "HOSTMAST.JBI"
				Dim retur As Integer = CInt(MotoCom32.BscDownLoadEx(nCid, text, Positioncal.BasePath, False))
				Dim nCid2 As Short = CShort(Connection.nCid)
				text = "HOSTMOV.JBI"
				retur = CInt(MotoCom32.BscDownLoadEx(nCid2, text, Positioncal.BasePath, False))
				Returnhome.Rethome(Positioncal.ControlGroup)
				Dim nCid3 As Short = CShort(Connection.nCid)
				text = "RETHOME.JBI"
				retur = CInt(MotoCom32.BscDownLoadEx(nCid3, text, Positioncal.BasePath, False))
				Me.ProgressBar.Minimum = 0
				Me.ProgressBar.Maximum = Positioncal.TotalSteps
				retur = CInt(MotoCom32.BscChangeTask(CShort(Connection.nCid), 0S))
				Dim nCid4 As Short = CShort(Connection.nCid)
				text = "HOSTMAST.JBI"
				retur = CInt(MotoCom32.BscSelectJob(nCid4, text))
				retur = CInt(MotoCom32.BscSetMasterJob(CShort(Connection.nCid)))
				retur = CInt(MotoCom32.BscChangeTask(CShort(Connection.nCid), 1S))
				Dim nCid5 As Short = CShort(Connection.nCid)
				text = "HOSTMOV.JBI"
				retur = CInt(MotoCom32.BscSelectJob(nCid5, text))
				retur = CInt(MotoCom32.BscSetMasterJob(CShort(Connection.nCid)))
				Me.Download.Enabled = False
			ElseIf remmode = -1S Then
				Interaction.MsgBox("Connection Failure", MsgBoxStyle.OkOnly, Nothing)
			End If
		End Sub

		' Token: 0x06000222 RID: 546 RVA: 0x0002AD20 File Offset: 0x00029120
		Private Sub processcycle_SelectedIndexChanged(sender As Object, e As EventArgs)
			' The following expression was wrapped in a checked-statement
			If Not Positioncal.ProjLoad Then
				Positioncal.ProcCycle = CShort(Me.processcycle.SelectedIndex)
			Else
				Positioncal.ProcCycle = CShort(Conversions.ToInteger(Positioncal.ProjParam))
			End If
			Select Case Positioncal.ProcCycle
				Case 0S
					Dim form2rect As Rectangle = New Rectangle(50, 100, 700, 570)
					If MyProject.Computer.FileSystem.FileExists(Application.StartupPath + "\Scladparam.txt") Then
						Dim fs As FileStream = New FileStream(Application.StartupPath + "\Scladparam.txt", FileMode.Open)
						Dim r As StreamReader = New StreamReader(fs)
						Positioncal.Diameter = Conversions.ToDouble(r.ReadLine())
						Positioncal.Width1 = Conversions.ToDouble(r.ReadLine())
						Positioncal.Distance = Conversions.ToDouble(r.ReadLine())
						Positioncal.Pitch = Conversions.ToDouble(r.ReadLine())
						Positioncal.ToolOffset = Conversions.ToDouble(r.ReadLine())
						Positioncal.StationPosition = Conversions.ToInteger(r.ReadLine())
						Positioncal.CladdingDir = Conversions.ToInteger(r.ReadLine())
						Positioncal.PostureAngle = Conversions.ToDouble(r.ReadLine())
						Positioncal.ConeAngle = Conversions.ToDouble(r.ReadLine())
						Positioncal.IniOverWeld = Conversions.ToSingle(r.ReadLine())
						Positioncal.FinOverWeld = Conversions.ToSingle(r.ReadLine())
						Positioncal.MeanderAmp = Conversions.ToDouble(r.ReadLine())
						Positioncal.MeanderPitch = Conversions.ToDouble(r.ReadLine())
						Positioncal.InitialAng = Conversions.ToDouble(r.ReadLine())
						Positioncal.MeanderFlg = Conversions.ToShort(r.ReadLine())
						Positioncal.CurrPos = Conversions.ToShort(r.ReadLine())
						r.Close()
					Else
						Positioncal.Diameter = 50.0
						Positioncal.Width1 = 15.0
						Positioncal.Distance = 500.0
						Positioncal.Pitch = 3.2
						Positioncal.ToolOffset = 0.0
						Positioncal.StationPosition = 1
						Positioncal.CladdingDir = 1
						Positioncal.PostureAngle = 90.0
						Positioncal.ConeAngle = 0.0
						Positioncal.IniOverWeld = 100F
						Positioncal.FinOverWeld = 100F
						Positioncal.MeanderAmp = 2.0
						Positioncal.MeanderPitch = 3.2
						Positioncal.InitialAng = 0.0
						Positioncal.MeanderFlg = 0S
						Positioncal.CurrPos = 0S
					End If
					MyProject.Forms.SPARAM.DesktopBounds = form2rect
					MyProject.Forms.SPARAM.ShowDialog()
					If MyProject.Forms.SPARAM.DialogResult = DialogResult.OK Then
						Me.formatstat = 1S
						Me.SaveAsToolStripMenuItem.Enabled = True
						Positioncal.crankclad2(Positioncal.Diameter, 0.01, Positioncal.Width1, Positioncal.Distance, Positioncal.Pitch, Positioncal.ProcessSpeed, 0.0, 0.0, 1.0, 1, 0.0, 0.0, Positioncal.PostureAngle, Positioncal.ConeAngle, Positioncal.IniOverWeld, Positioncal.FinOverWeld, Positioncal.MeanderAmp, Positioncal.MeanderFlg, Positioncal.InitialAng, Positioncal.ToolOffset, 0S, Me.Handle.ToInt32())
						If Positioncal.ConectStat = 1S Then
							Me.Download.Enabled = True
						Else
							Me.Download.Enabled = False
						End If
					End If
				Case 1S
					Dim form2rect2 As Rectangle = New Rectangle(50, 100, 700, 650)
					If MyProject.Computer.FileSystem.FileExists(Application.StartupPath + "\Keycladparam.txt") Then
						Dim fs2 As FileStream = New FileStream(Application.StartupPath + "\Keycladparam.txt", FileMode.Open)
						Dim r2 As StreamReader = New StreamReader(fs2)
						Positioncal.Diameter = Conversions.ToDouble(r2.ReadLine())
						Positioncal.Width1 = Conversions.ToDouble(r2.ReadLine())
						Positioncal.Distance = Conversions.ToDouble(r2.ReadLine())
						Positioncal.Pitch = Conversions.ToDouble(r2.ReadLine())
						Positioncal.PostureAngle = Conversions.ToDouble(r2.ReadLine())
						Positioncal.ConeAngle = Conversions.ToDouble(r2.ReadLine())
						Positioncal.IniOverWeld = Conversions.ToSingle(r2.ReadLine())
						Positioncal.MeanderAmp = Conversions.ToDouble(r2.ReadLine())
						Positioncal.MeanderPitch = Conversions.ToDouble(r2.ReadLine())
						Positioncal.MeanderFlg = Conversions.ToShort(r2.ReadLine())
						Positioncal.Keyno = Conversions.ToInteger(r2.ReadLine())
						Positioncal.KeyDistance = Conversions.ToDouble(r2.ReadLine())
						Positioncal.KeyWidth = Conversions.ToDouble(r2.ReadLine())
						Positioncal.KeyLength = Conversions.ToDouble(r2.ReadLine())
						Positioncal.KeyAngle = Conversions.ToDouble(r2.ReadLine())
						Positioncal.StationPosition = Conversions.ToInteger(r2.ReadLine())
						Positioncal.CurrPos = Conversions.ToShort(r2.ReadLine())
						r2.Close()
					Else
						Positioncal.Diameter = 50.0
						Positioncal.Width1 = 15.0
						Positioncal.Distance = 500.0
						Positioncal.Pitch = 3.2
						Positioncal.PostureAngle = 90.0
						Positioncal.ConeAngle = 0.0
						Positioncal.IniOverWeld = 100F
						Positioncal.MeanderAmp = 2.0
						Positioncal.MeanderPitch = 3.2
						Positioncal.MeanderFlg = 0S
						Positioncal.Keyno = 1
						Positioncal.KeyDistance = 15.0
						Positioncal.KeyWidth = 10.0
						Positioncal.KeyLength = 30.0
						Positioncal.KeyAngle = 0.0
						Positioncal.StationPosition = 0
						Positioncal.CurrPos = 0S
					End If
					MyProject.Forms.KEYPARAM.DesktopBounds = form2rect2
					MyProject.Forms.KEYPARAM.ShowDialog()
					If MyProject.Forms.KEYPARAM.DialogResult = DialogResult.OK Then
						Me.formatstat = 1S
						Me.SaveAsToolStripMenuItem.Enabled = True
						Positioncal.keyholeclad(Positioncal.Diameter, Positioncal.Width1, Positioncal.Distance, Positioncal.Pitch, Positioncal.ProcessSpeed, Positioncal.KeyDistance, Positioncal.KeyWidth, Positioncal.KeyLength, Positioncal.KeyAngle, Positioncal.PostureAngle, Positioncal.ConeAngle, Positioncal.IniOverWeld, Positioncal.MeanderAmp, Positioncal.MeanderFlg, Positioncal.InitialAng, Me.Handle.ToInt32())
						If Positioncal.ConectStat = 1S Then
							Me.Download.Enabled = True
						Else
							Me.Download.Enabled = False
						End If
					End If
				Case 2S
					Dim form2rect3 As Rectangle = New Rectangle(50, 100, 700, 600)
					If MyProject.Computer.FileSystem.FileExists(Application.StartupPath + "\Vcladparam.txt") Then
						Dim fs3 As FileStream = New FileStream(Application.StartupPath + "\Vcladparam.txt", FileMode.Open)
						Dim r3 As StreamReader = New StreamReader(fs3)
						Positioncal.Diameter = Conversions.ToDouble(r3.ReadLine())
						Positioncal.Width1 = Conversions.ToDouble(r3.ReadLine())
						Positioncal.Distance = Conversions.ToDouble(r3.ReadLine())
						Positioncal.Pitch = Conversions.ToDouble(r3.ReadLine())
						Positioncal.PostureAngle = Conversions.ToDouble(r3.ReadLine())
						Positioncal.StationPosition = Conversions.ToInteger(r3.ReadLine())
						Positioncal.ConeAngle = Conversions.ToDouble(r3.ReadLine())
						Positioncal.IniOverWeld = Conversions.ToSingle(r3.ReadLine())
						Positioncal.FinOverWeld = Conversions.ToSingle(r3.ReadLine())
						Positioncal.MeanderAmp = Conversions.ToDouble(r3.ReadLine())
						Positioncal.MeanderPitch = Conversions.ToDouble(r3.ReadLine())
						Positioncal.MeanderFlg = Conversions.ToShort(r3.ReadLine())
						Positioncal.InitialAng = Conversions.ToDouble(r3.ReadLine())
						Positioncal.ToolOffset = Conversions.ToDouble(r3.ReadLine())
						Positioncal.ValveFlg = Conversions.ToBoolean(r3.ReadLine())
						Positioncal.CladdingDir = Conversions.ToInteger(r3.ReadLine())
						Positioncal.CurrPos = Conversions.ToShort(r3.ReadLine())
						r3.Close()
					Else
						Positioncal.Diameter = 300.0
						Positioncal.Width1 = 15.0
						Positioncal.Distance = 200.0
						Positioncal.Pitch = 3.5
						Positioncal.PostureAngle = 90.0
						Positioncal.StationPosition = 4
						Positioncal.ConeAngle = 30.0
						Positioncal.IniOverWeld = 100F
						Positioncal.FinOverWeld = 100F
						Positioncal.MeanderAmp = 2.0
						Positioncal.MeanderPitch = 3.5
						Positioncal.MeanderFlg = 0S
						Positioncal.InitialAng = 0.0
						Positioncal.ToolOffset = 0.0
						Positioncal.ValveFlg = True
						Positioncal.CladdingDir = 1
						Positioncal.CurrPos = 0S
					End If
					MyProject.Forms.VPARAM.DesktopBounds = form2rect3
					MyProject.Forms.VPARAM.ShowDialog()
					If MyProject.Forms.VPARAM.DialogResult = DialogResult.OK Then
						Me.formatstat = 1S
						Positioncal.valveclad2(Positioncal.Diameter, Positioncal.Width1, Positioncal.Distance, Positioncal.Pitch, Positioncal.ProcessSpeed, 0.0, 0.0, 0.0, 1, 0.0, 0.0, Positioncal.PostureAngle, Positioncal.ConeAngle, Positioncal.StationPosition, Positioncal.IniOverWeld, Positioncal.FinOverWeld, Positioncal.MeanderAmp, Positioncal.MeanderFlg, Positioncal.InitialAng, If((-If((Positioncal.ValveFlg > False), 1, 0)), 1, 0), Positioncal.ToolOffset, 0S, Me.Handle.ToInt32())
						Me.SaveAsToolStripMenuItem.Enabled = True
						If Positioncal.ConectStat = 1S Then
							Me.Download.Enabled = True
						Else
							Me.Download.Enabled = False
						End If
					End If
				Case 3S
					Dim form2rect4 As Rectangle = New Rectangle(50, 100, 700, 570)
					If MyProject.Computer.FileSystem.FileExists(Application.StartupPath + "\Crcladparam.txt") Then
						Dim fs4 As FileStream = New FileStream(Application.StartupPath + "\Crcladparam.txt", FileMode.Open)
						Dim r4 As StreamReader = New StreamReader(fs4)
						Positioncal.Diameter = Conversions.ToDouble(r4.ReadLine())
						Positioncal.CrankThrow = Conversions.ToDouble(r4.ReadLine())
						Positioncal.Width1 = Conversions.ToDouble(r4.ReadLine())
						Positioncal.Distance = Conversions.ToDouble(r4.ReadLine())
						Positioncal.Pitch = Conversions.ToDouble(r4.ReadLine())
						Positioncal.PostureAngle = Conversions.ToDouble(r4.ReadLine())
						Positioncal.ConeAngle = Conversions.ToDouble(r4.ReadLine())
						Positioncal.IniOverWeld = Conversions.ToSingle(r4.ReadLine())
						Positioncal.FinOverWeld = Conversions.ToSingle(r4.ReadLine())
						Positioncal.MeanderAmp = Conversions.ToDouble(r4.ReadLine())
						Positioncal.MeanderPitch = Conversions.ToDouble(r4.ReadLine())
						Positioncal.MeanderFlg = Conversions.ToShort(r4.ReadLine())
						Positioncal.InitialAng = Conversions.ToDouble(r4.ReadLine())
						Positioncal.ToolOffset = Conversions.ToDouble(r4.ReadLine())
						Positioncal.StationPosition = Conversions.ToInteger(r4.ReadLine())
						Positioncal.CladdingDir = Conversions.ToInteger(r4.ReadLine())
						Positioncal.CurrPos = Conversions.ToShort(r4.ReadLine())
						r4.Close()
					Else
						Positioncal.Diameter = 200.0
						Positioncal.CrankThrow = 200.0
						Positioncal.Width1 = 15.0
						Positioncal.Distance = 500.0
						Positioncal.Pitch = 3.2
						Positioncal.ToolOffset = 0.0
						Positioncal.PostureAngle = 90.0
						Positioncal.ConeAngle = 0.0
						Positioncal.IniOverWeld = 100F
						Positioncal.FinOverWeld = 100F
						Positioncal.MeanderAmp = 2.0
						Positioncal.MeanderPitch = 3.2
						Positioncal.InitialAng = 0.0
						Positioncal.MeanderFlg = 0S
						Positioncal.StationPosition = 1
						Positioncal.CladdingDir = 1
						Positioncal.CurrPos = 0S
					End If
					MyProject.Forms.CRPARAM.DesktopBounds = form2rect4
					MyProject.Forms.CRPARAM.ShowDialog()
					If MyProject.Forms.CRPARAM.DialogResult = DialogResult.OK Then
						Me.formatstat = 1S
						Positioncal.crankclad2(Positioncal.Diameter, Positioncal.CrankThrow, Positioncal.Width1, Positioncal.Distance, Positioncal.Pitch, Positioncal.ProcessSpeed, 0.0, 0.0, 1.0, 1, 0.0, 0.0, Positioncal.PostureAngle, Positioncal.ConeAngle, Positioncal.IniOverWeld, Positioncal.FinOverWeld, Positioncal.MeanderAmp, Positioncal.MeanderFlg, Positioncal.InitialAng, Positioncal.ToolOffset, 1S, Me.Handle.ToInt32())
						Me.SaveAsToolStripMenuItem.Enabled = True
						If Positioncal.ConectStat = 1S Then
							Me.Download.Enabled = True
						Else
							Me.Download.Enabled = False
						End If
					End If
				Case 4S
					If MyProject.Computer.FileSystem.FileExists(Application.StartupPath + "\Pcladparam.txt") Then
						Dim fs5 As FileStream = New FileStream(Application.StartupPath + "\Pcladparam.txt", FileMode.Open)
						Dim r5 As StreamReader = New StreamReader(fs5)
						Positioncal.Length = Conversions.ToDouble(r5.ReadLine())
						Positioncal.Width1 = Conversions.ToDouble(r5.ReadLine())
						Positioncal.Xpos = Conversions.ToDouble(r5.ReadLine())
						Positioncal.Ypos = Conversions.ToDouble(r5.ReadLine())
						Positioncal.Zpos = Conversions.ToDouble(r5.ReadLine())
						Positioncal.Pitch = Conversions.ToDouble(r5.ReadLine())
						Positioncal.PostureAngle = Conversions.ToDouble(r5.ReadLine())
						Positioncal.MeanderAmp = Conversions.ToDouble(r5.ReadLine())
						Positioncal.MeanderPitch = Conversions.ToDouble(r5.ReadLine())
						Positioncal.MeanderFlg = Conversions.ToShort(r5.ReadLine())
						Positioncal.ToolOffset = Conversions.ToDouble(r5.ReadLine())
						Positioncal.StationPosition = Conversions.ToInteger(r5.ReadLine())
						Positioncal.CurrPos = Conversions.ToShort(r5.ReadLine())
						r5.Close()
					Else
						Positioncal.Length = 50.0
						Positioncal.Width1 = 15.0
						Positioncal.Xpos = 500.0
						Positioncal.Ypos = 500.0
						Positioncal.Zpos = 500.0
						Positioncal.Pitch = 3.2
						Positioncal.PostureAngle = 90.0
						Positioncal.MeanderAmp = 2.0
						Positioncal.MeanderPitch = 3.2
						Positioncal.MeanderFlg = 0S
						Positioncal.ToolOffset = 0.0
						Positioncal.StationPosition = 1
						Positioncal.CurrPos = 0S
					End If
					Dim form2rect5 As Rectangle = New Rectangle(50, 100, 700, 570)
					MyProject.Forms.PPARAM.DesktopBounds = form2rect5
					MyProject.Forms.PPARAM.ShowDialog()
					If MyProject.Forms.PPARAM.DialogResult = DialogResult.OK Then
						Me.formatstat = 1S
						Positioncal.Planeclad(Positioncal.Length, Positioncal.Width1, Positioncal.Xpos, Positioncal.Ypos, Positioncal.Zpos, Positioncal.Pitch, Positioncal.ProcessSpeed, Positioncal.PostureAngle, Positioncal.MeanderAmp, Positioncal.MeanderFlg, Positioncal.ToolOffset, Me.Handle.ToInt32())
						Me.SaveAsToolStripMenuItem.Enabled = True
						If Positioncal.ConectStat = 1S Then
							Me.Download.Enabled = True
						Else
							Me.Download.Enabled = False
						End If
					End If
				Case 5S
					If MyProject.Computer.FileSystem.FileExists(Application.StartupPath + "\Bcladparam.txt") Then
						Dim fs6 As FileStream = New FileStream(Application.StartupPath + "\Bcladparam.txt", FileMode.Open)
						Dim r6 As StreamReader = New StreamReader(fs6)
						Positioncal.Diameter = Conversions.ToDouble(r6.ReadLine())
						Positioncal.Width1 = Conversions.ToDouble(r6.ReadLine())
						Positioncal.Distance = Conversions.ToDouble(r6.ReadLine())
						Positioncal.Pitch = Conversions.ToDouble(r6.ReadLine())
						Positioncal.PostureAngle = Conversions.ToDouble(r6.ReadLine())
						Positioncal.StationPosition = Conversions.ToInteger(r6.ReadLine())
						Positioncal.ConeAngle = Conversions.ToDouble(r6.ReadLine())
						Positioncal.IniOverWeld = Conversions.ToSingle(r6.ReadLine())
						Positioncal.FinOverWeld = Conversions.ToSingle(r6.ReadLine())
						Positioncal.MeanderAmp = Conversions.ToDouble(r6.ReadLine())
						Positioncal.MeanderPitch = Conversions.ToDouble(r6.ReadLine())
						Positioncal.MeanderFlg = Conversions.ToShort(r6.ReadLine())
						Positioncal.InitialAng = Conversions.ToDouble(r6.ReadLine())
						Positioncal.ToolOffset = Conversions.ToDouble(r6.ReadLine())
						Positioncal.CladdingDir = Conversions.ToInteger(r6.ReadLine())
						Positioncal.CurrPos = Conversions.ToShort(r6.ReadLine())
						r6.Close()
					Else
						Positioncal.Diameter = 300.0
						Positioncal.Width1 = 15.0
						Positioncal.Distance = 200.0
						Positioncal.Pitch = 3.5
						Positioncal.PostureAngle = 90.0
						Positioncal.StationPosition = 4
						Positioncal.ConeAngle = 30.0
						Positioncal.IniOverWeld = 100F
						Positioncal.FinOverWeld = 100F
						Positioncal.MeanderAmp = 2.0
						Positioncal.MeanderPitch = 3.5
						Positioncal.MeanderFlg = 0S
						Positioncal.InitialAng = 0.0
						Positioncal.ToolOffset = 0.0
						Positioncal.CladdingDir = 1
						Positioncal.CurrPos = 0S
					End If
					Dim form2rect6 As Rectangle = New Rectangle(50, 100, 700, 570)
					MyProject.Forms.BPARAM.DesktopBounds = form2rect6
					MyProject.Forms.BPARAM.ShowDialog()
					If MyProject.Forms.BPARAM.DialogResult = DialogResult.OK Then
						Me.formatstat = 1S
						Positioncal.boreclad(Positioncal.Diameter, Positioncal.Width1, Positioncal.Distance, Positioncal.Pitch, Positioncal.ProcessSpeed, Positioncal.PostureAngle, Positioncal.ConeAngle, Positioncal.StationPosition, Positioncal.IniOverWeld, Positioncal.FinOverWeld, Positioncal.MeanderAmp, Positioncal.MeanderFlg, Positioncal.InitialAng, Positioncal.ToolOffset, Me.Handle.ToInt32())
						Me.SaveAsToolStripMenuItem.Enabled = True
						If Positioncal.ConectStat = 1S Then
							Me.Download.Enabled = True
						Else
							Me.Download.Enabled = False
						End If
					End If
				Case 6S
					If MyProject.Computer.FileSystem.FileExists(Application.StartupPath + "\Pocketcladparam.txt") Then
						Dim fs7 As FileStream = New FileStream(Application.StartupPath + "\Pocketcladparam.txt", FileMode.Open)
						Dim r7 As StreamReader = New StreamReader(fs7)
						Positioncal.Diameter = Conversions.ToDouble(r7.ReadLine())
						Positioncal.Width1 = Conversions.ToDouble(r7.ReadLine())
						Positioncal.Xpos = Conversions.ToDouble(r7.ReadLine())
						Positioncal.Ypos = Conversions.ToDouble(r7.ReadLine())
						Positioncal.Zpos = Conversions.ToDouble(r7.ReadLine())
						Positioncal.Pitch = Conversions.ToDouble(r7.ReadLine())
						Positioncal.PostureAngle = Conversions.ToDouble(r7.ReadLine())
						Positioncal.ConeAngle = Conversions.ToDouble(r7.ReadLine())
						Positioncal.IniOverWeld = Conversions.ToSingle(r7.ReadLine())
						Positioncal.FinOverWeld = Conversions.ToSingle(r7.ReadLine())
						Positioncal.InitialAng = Conversions.ToDouble(r7.ReadLine())
						Positioncal.ToolOffset = Conversions.ToDouble(r7.ReadLine())
						Positioncal.StationPosition = Conversions.ToInteger(r7.ReadLine())
						Positioncal.CurrPos = Conversions.ToShort(r7.ReadLine())
						r7.Close()
					Else
						Positioncal.Diameter = 200.0
						Positioncal.Width1 = 15.0
						Positioncal.Xpos = 500.0
						Positioncal.Ypos = 500.0
						Positioncal.Zpos = 500.0
						Positioncal.Pitch = 1.0
						Positioncal.PostureAngle = 90.0
						Positioncal.ConeAngle = 0.0
						Positioncal.IniOverWeld = 100F
						Positioncal.FinOverWeld = 100F
						Positioncal.InitialAng = 0.0
						Positioncal.ToolOffset = 0.0
						Positioncal.StationPosition = 1
						Positioncal.CurrPos = 0S
					End If
					Positioncal.MeanderFlg = 0S
					Dim form2rect7 As Rectangle = New Rectangle(50, 100, 700, 570)
					MyProject.Forms.POCKETPARAM.DesktopBounds = form2rect7
					MyProject.Forms.POCKETPARAM.ShowDialog()
					If MyProject.Forms.POCKETPARAM.DialogResult = DialogResult.OK Then
						Me.formatstat = 1S
						Positioncal.pocketclad(Positioncal.Diameter, Positioncal.Width1, Positioncal.Xpos, Positioncal.Ypos, Positioncal.Zpos, Positioncal.Pitch, Positioncal.ProcessSpeed, Positioncal.PostureAngle, Positioncal.ConeAngle, Positioncal.IniOverWeld, Positioncal.FinOverWeld, Positioncal.InitialAng, Positioncal.ToolOffset, Me.Handle.ToInt32())
						Me.SaveAsToolStripMenuItem.Enabled = True
						If Positioncal.ConectStat = 1S Then
							Me.Download.Enabled = True
						Else
							Me.Download.Enabled = False
						End If
					End If
				Case 7S
					Dim form2rect8 As Rectangle = New Rectangle(50, 100, 1000, 571)
					If MyProject.Computer.FileSystem.FileExists(Application.StartupPath + "\Groovecladparam.txt") Then
						Dim fs8 As FileStream = New FileStream(Application.StartupPath + "\Groovecladparam.txt", FileMode.Open)
						Dim r8 As StreamReader = New StreamReader(fs8)
						Positioncal.Diameter = Conversions.ToDouble(r8.ReadLine())
						Positioncal.Width1 = Conversions.ToDouble(r8.ReadLine())
						Positioncal.Distance = Conversions.ToDouble(r8.ReadLine())
						Positioncal.Pitch = Conversions.ToDouble(r8.ReadLine())
						Positioncal.ToolOffset = Conversions.ToDouble(r8.ReadLine())
						Positioncal.StationPosition = Conversions.ToInteger(r8.ReadLine())
						Positioncal.CladdingDir = Conversions.ToInteger(r8.ReadLine())
						Positioncal.Leftangle = Conversions.ToDouble(r8.ReadLine())
						Positioncal.Rightangle = Conversions.ToDouble(r8.ReadLine())
						Positioncal.Layerheight = Conversions.ToDouble(r8.ReadLine())
						Positioncal.Layernumber = Conversions.ToInteger(r8.ReadLine())
						Positioncal.Intoverweld = Conversions.ToSingle(r8.ReadLine())
						Positioncal.Rockangle = Conversions.ToDouble(r8.ReadLine())
						Positioncal.PostureAngle = Conversions.ToDouble(r8.ReadLine())
						Positioncal.ConeAngle = Conversions.ToDouble(r8.ReadLine())
						Positioncal.IniOverWeld = Conversions.ToSingle(r8.ReadLine())
						Positioncal.FinOverWeld = Conversions.ToSingle(r8.ReadLine())
						Positioncal.MeanderAmp = Conversions.ToDouble(r8.ReadLine())
						Positioncal.MeanderPitch = Conversions.ToDouble(r8.ReadLine())
						Positioncal.InitialAng = Conversions.ToDouble(r8.ReadLine())
						Positioncal.MeanderFlg = Conversions.ToShort(r8.ReadLine())
						Positioncal.CurrPos = Conversions.ToShort(r8.ReadLine())
						Positioncal.Rockangvar = Conversions.ToShort(r8.ReadLine())
						r8.Close()
					Else
						Positioncal.Diameter = 50.0
						Positioncal.Width1 = 15.0
						Positioncal.Distance = 500.0
						Positioncal.Pitch = 3.2
						Positioncal.ToolOffset = 0.0
						Positioncal.StationPosition = 1
						Positioncal.CladdingDir = 1
						Positioncal.Leftangle = 45.0
						Positioncal.Rightangle = 45.0
						Positioncal.Layerheight = 1.0
						Positioncal.Layernumber = 3
						Positioncal.Intoverweld = 50F
						Positioncal.Rockangle = 10.0
						Positioncal.PostureAngle = 90.0
						Positioncal.ConeAngle = 0.0
						Positioncal.IniOverWeld = 100F
						Positioncal.FinOverWeld = 100F
						Positioncal.MeanderAmp = 2.0
						Positioncal.MeanderPitch = 3.2
						Positioncal.InitialAng = 0.0
						Positioncal.MeanderFlg = 0S
						Positioncal.CurrPos = 0S
						Positioncal.Rockangvar = 0S
					End If
					MyProject.Forms.GRVPARAM.DesktopBounds = form2rect8
					MyProject.Forms.GRVPARAM.ShowDialog()
					If MyProject.Forms.GRVPARAM.DialogResult = DialogResult.OK Then
						Me.formatstat = 1S
						Me.SaveAsToolStripMenuItem.Enabled = True
						Positioncal.crankclad2(Positioncal.Diameter, 0.01, Positioncal.Width1, Positioncal.Distance, Positioncal.Pitch, Positioncal.ProcessSpeed, Positioncal.Leftangle, Positioncal.Rightangle, Positioncal.Layerheight, Positioncal.Layernumber, CDbl(Positioncal.Intoverweld), Positioncal.Rockangle, Positioncal.PostureAngle, Positioncal.ConeAngle, Positioncal.IniOverWeld, Positioncal.FinOverWeld, Positioncal.MeanderAmp, Positioncal.MeanderFlg, Positioncal.InitialAng, Positioncal.ToolOffset, Positioncal.Rockangvar, Me.Handle.ToInt32())
						If Positioncal.ConectStat = 1S Then
							Me.Download.Enabled = True
						Else
							Me.Download.Enabled = False
						End If
					End If
				Case 8S
					Dim form2rect9 As Rectangle = New Rectangle(50, 100, 1000, 571)
					If MyProject.Computer.FileSystem.FileExists(Application.StartupPath + "\Congroovecladparam.txt") Then
						Dim fs9 As FileStream = New FileStream(Application.StartupPath + "\Congroovecladparam.txt", FileMode.Open)
						Dim r9 As StreamReader = New StreamReader(fs9)
						Positioncal.Diameter = Conversions.ToDouble(r9.ReadLine())
						Positioncal.Width1 = Conversions.ToDouble(r9.ReadLine())
						Positioncal.Distance = Conversions.ToDouble(r9.ReadLine())
						Positioncal.Pitch = Conversions.ToDouble(r9.ReadLine())
						Positioncal.ToolOffset = Conversions.ToDouble(r9.ReadLine())
						Positioncal.StationPosition = Conversions.ToInteger(r9.ReadLine())
						Positioncal.CladdingDir = Conversions.ToInteger(r9.ReadLine())
						Positioncal.Leftangle = Conversions.ToDouble(r9.ReadLine())
						Positioncal.Rightangle = Conversions.ToDouble(r9.ReadLine())
						Positioncal.Layerheight = Conversions.ToDouble(r9.ReadLine())
						Positioncal.Layernumber = Conversions.ToInteger(r9.ReadLine())
						Positioncal.Intoverweld = Conversions.ToSingle(r9.ReadLine())
						Positioncal.Rockangle = Conversions.ToDouble(r9.ReadLine())
						Positioncal.PostureAngle = Conversions.ToDouble(r9.ReadLine())
						Positioncal.ConeAngle = Conversions.ToDouble(r9.ReadLine())
						Positioncal.IniOverWeld = Conversions.ToSingle(r9.ReadLine())
						Positioncal.FinOverWeld = Conversions.ToSingle(r9.ReadLine())
						Positioncal.MeanderAmp = Conversions.ToDouble(r9.ReadLine())
						Positioncal.MeanderPitch = Conversions.ToDouble(r9.ReadLine())
						Positioncal.InitialAng = Conversions.ToDouble(r9.ReadLine())
						Positioncal.MeanderFlg = Conversions.ToShort(r9.ReadLine())
						Positioncal.CurrPos = Conversions.ToShort(r9.ReadLine())
						Positioncal.ValveFlg = Conversions.ToBoolean(r9.ReadLine())
						r9.Close()
					Else
						Positioncal.Diameter = 50.0
						Positioncal.Width1 = 15.0
						Positioncal.Distance = 500.0
						Positioncal.Pitch = 3.2
						Positioncal.ToolOffset = 0.0
						Positioncal.StationPosition = 1
						Positioncal.CladdingDir = 1
						Positioncal.Leftangle = 0.7853981633974483
						Positioncal.Rightangle = 0.7853981633974483
						Positioncal.Layerheight = 1.0
						Positioncal.Layernumber = 3
						Positioncal.Intoverweld = 50F
						Positioncal.Rockangle = 10.0
						Positioncal.PostureAngle = 90.0
						Positioncal.ConeAngle = 0.0
						Positioncal.IniOverWeld = 100F
						Positioncal.FinOverWeld = 100F
						Positioncal.MeanderAmp = 2.0
						Positioncal.MeanderPitch = 3.2
						Positioncal.InitialAng = 0.0
						Positioncal.MeanderFlg = 0S
						Positioncal.CurrPos = 0S
						Positioncal.ValveFlg = True
					End If
					MyProject.Forms.CONGRVPARAM.DesktopBounds = form2rect9
					MyProject.Forms.CONGRVPARAM.ShowDialog()
					If MyProject.Forms.CONGRVPARAM.DialogResult = DialogResult.OK Then
						Me.formatstat = 1S
						Me.SaveAsToolStripMenuItem.Enabled = True
						Positioncal.valveclad2(Positioncal.Diameter, Positioncal.Width1, Positioncal.Distance, Positioncal.Pitch, Positioncal.ProcessSpeed, Positioncal.Leftangle, Positioncal.Rightangle, Positioncal.Layerheight, Positioncal.Layernumber, CDbl(Positioncal.Intoverweld), Positioncal.Rockangle, Positioncal.PostureAngle, Positioncal.ConeAngle, Positioncal.StationPosition, Positioncal.IniOverWeld, Positioncal.FinOverWeld, Positioncal.MeanderAmp, Positioncal.MeanderFlg, Positioncal.InitialAng, If((-If((Positioncal.ValveFlg > False), 1, 0)), 1, 0), Positioncal.ToolOffset, Positioncal.Rockangvar, Me.Handle.ToInt32())
						If Positioncal.ConectStat = 1S Then
							Me.Download.Enabled = True
						Else
							Me.Download.Enabled = False
						End If
					End If
				Case 9S
					Dim form2rect10 As Rectangle = New Rectangle(50, 100, 1000, 500)
					If MyProject.Computer.FileSystem.FileExists(Application.StartupPath + "\3Dcladparam.txt") Then
						Dim fs10 As FileStream = New FileStream(Application.StartupPath + "\3Dcladparam.txt", FileMode.Open)
						Dim r10 As StreamReader = New StreamReader(fs10)
						Dim table As DataTable = New DataTable("table")
						Dim tempfilename As String = Application.StartupPath + "/tempfile.txt"
						Dim UFrame As String = ""
						Positioncal.Width1 = Conversions.ToDouble(r10.ReadLine())
						Positioncal.Pitch = Conversions.ToDouble(r10.ReadLine())
						Positioncal.ToolOffset = Conversions.ToDouble(r10.ReadLine())
						Positioncal.StationPosition = Conversions.ToInteger(r10.ReadLine())
						Positioncal.CladdingDir = Conversions.ToInteger(r10.ReadLine())
						Positioncal.MovDir = Conversions.ToShort(r10.ReadLine())
						Positioncal.Overlaydir = Conversions.ToShort(r10.ReadLine())
						Positioncal.MeanderAmp = Conversions.ToDouble(r10.ReadLine())
						Positioncal.MeanderPitch = Conversions.ToDouble(r10.ReadLine())
						Positioncal.MeanderFlg = Conversions.ToShort(r10.ReadLine())
						Positioncal.ArrDir = Conversions.ToShort(r10.ReadLine())
						Positioncal.Copies = Conversions.ToShort(r10.ReadLine())
						Positioncal.Arrayrecptc = Conversions.ToDouble(r10.ReadLine())
						Positioncal.Arrayangptc = Conversions.ToDouble(r10.ReadLine())
						Positioncal.Arraydir = Conversions.ToShort(r10.ReadLine())
						Positioncal.CurrPos = Conversions.ToShort(r10.ReadLine())
						Positioncal.ConstBeamFlg = Conversions.ToShort(r10.ReadLine())
						Positioncal.Movementtype = Conversions.ToShort(r10.ReadLine())
						r10.Close()
						table.Rows.Clear()
						table.Columns.Add("Index", Type.[GetType]("System.Int32"))
						table.Columns.Add("Laser Power (W)", Type.[GetType]("System.Int32"))
						table.Columns.Add("Clad Width (mm)", Type.[GetType]("System.Double"))
						table.Columns.Add("X (mm)", Type.[GetType]("System.Double"))
						table.Columns.Add("Y (mm)", Type.[GetType]("System.Double"))
						table.Columns.Add("Z (mm)", Type.[GetType]("System.Double"))
						table.Columns.Add("Rx (deg)", Type.[GetType]("System.Double"))
						table.Columns.Add("Ry (deg)", Type.[GetType]("System.Double"))
						table.Columns.Add("Rz (deg)", Type.[GetType]("System.Double"))
						table.Columns.Add("S1 (deg)", Type.[GetType]("System.Double"))
						table.Columns.Add("S2 (deg)", Type.[GetType]("System.Double"))
						Dim filename As String = tempfilename
						Dim num As Short = CShort(Positioncal.StationPosition)
						Positioncal.LoadPositionFile(filename, table, UFrame, num, Positioncal.PointNo)
						Positioncal.StationPosition = CInt(num)
						Positioncal.Position = CType(Utils.CopyArray(CType(Positioncal.Position, Array), New Double(12, Positioncal.PointNo - 1 + 1 - 1) {}), Double(,))
						Dim num2 As Integer = 0
						Dim num3 As Integer = Positioncal.PointNo - 1
						For i As Integer = num2 To num3
							Dim j As Integer = 1
							Do
								Positioncal.Position(j + 7, i) = Conversions.ToDouble(table.Rows(i)(j))
								j += 1
							Loop While j <= 2
							Dim num4 As Integer = 3
							Dim num5 As Integer = table.Columns.Count - 1
							For k As Integer = num4 To num5
								Positioncal.Position(k - 3, i) = Conversions.ToDouble(table.Rows(i)(k))
							Next
						Next
					Else
						Positioncal.Width1 = 15.0
						Positioncal.Pitch = 3.0
						Positioncal.ToolOffset = 0.0
						Positioncal.StationPosition = 0
						Positioncal.CladdingDir = 1
						Positioncal.MovDir = 1S
						Positioncal.Overlaydir = 1S
						Positioncal.MeanderAmp = 2.0
						Positioncal.MeanderPitch = 3.0
						Positioncal.MeanderFlg = 0S
						Positioncal.ArrDir = 3S
						Positioncal.Copies = 1S
						Positioncal.Arrayrecptc = 20.0
						Positioncal.Arrayangptc = 15.0
						Positioncal.Arraydir = 1S
						Positioncal.CurrPos = 0S
						Positioncal.ConstBeamFlg = 0S
						Positioncal.Movementtype = 0S
					End If
					MyProject.Forms.THREEDCLADPARAM.DesktopBounds = form2rect10
					MyProject.Forms.THREEDCLADPARAM.ShowDialog()
					If MyProject.Forms.THREEDCLADPARAM.DialogResult = DialogResult.OK Then
						Me.formatstat = 1S
						Me.SaveAsToolStripMenuItem.Enabled = True
						Dim processSpeed As Double = Positioncal.ProcessSpeed
						Dim num As Short = CShort(Positioncal.CladdingDir)
						Positioncal.ThreeDclad(Positioncal.Width1, Positioncal.Pitch, processSpeed, Positioncal.ToolOffset, Positioncal.StationPosition, Positioncal.MovDir, Positioncal.ArrDir, num, Positioncal.MeanderAmp, Positioncal.MeanderPitch, Positioncal.MeanderFlg, Positioncal.Copies, Positioncal.Arrayrecptc, Positioncal.Arrayangptc, Me.Handle.ToInt32())
						Positioncal.CladdingDir = CInt(num)
						If Positioncal.ConectStat = 1S Then
							Me.Download.Enabled = True
						Else
							Me.Download.Enabled = False
						End If
					End If
			End Select
			Returnhome.Rethome(Positioncal.ControlGroup)
		End Sub

		' Token: 0x06000223 RID: 547 RVA: 0x0002CFD4 File Offset: 0x0002B3D4
		Private Sub Procsetupbtn_Click(sender As Object, e As EventArgs)
			Dim form2rect As Rectangle = New Rectangle(50, 100, 580, 440)
			MyProject.Forms.Processsetup.DesktopBounds = form2rect
			MyProject.Forms.Processsetup.ShowDialog()
			If MyProject.Forms.Processsetup.DialogResult = DialogResult.OK Then
				processparam.paramset(Positioncal.LaserPowerIni, Positioncal.PowderFeed, CInt(Positioncal.PowderJar), Me.Handle.ToInt32())
				Me.processcycle.Enabled = True
				If Positioncal.ConectStat = 1S And Me.processcycle.SelectedIndex >= 0 Then
					Me.Download.Enabled = True
				Else
					Me.Download.Enabled = False
				End If
			End If
		End Sub

		' Token: 0x06000224 RID: 548 RVA: 0x0002D08C File Offset: 0x0002B48C
		Private Sub ConnectionSettingsToolStripMenuItem_Click(sender As Object, e As EventArgs)
			MyProject.Forms.ConnectionSettings.ShowDialog()
		End Sub

		' Token: 0x06000225 RID: 549 RVA: 0x0002D0A0 File Offset: 0x0002B4A0
		Private Sub MisselaneousSettingsToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Dim form2rect As Rectangle = New Rectangle(50, 100, 668, 510)
			MyProject.Forms.Miscsettings.DesktopBounds = form2rect
			MyProject.Forms.Miscsettings.ShowDialog()
			If Positioncal.ConectStat = 1S And Me.processcycle.SelectedIndex >= 0 Then
				Me.Download.Enabled = True
			Else
				Me.Download.Enabled = False
			End If
		End Sub

		' Token: 0x06000226 RID: 550 RVA: 0x0002D118 File Offset: 0x0002B518
		Private Sub SaveAsToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Dim savefiledialog As SaveFileDialog = New SaveFileDialog()
			Dim fs As StreamWriter = Nothing
			Dim misc As FileStream = New FileStream(Application.StartupPath + "\miscsettings.txt", FileMode.Open)
			Dim miscread As StreamReader = New StreamReader(misc)
			Dim proc As FileStream = New FileStream(Application.StartupPath + "\processsettings.txt", FileMode.Open)
			Dim procread As StreamReader = New StreamReader(proc)
			Dim settingfile As String = ""
			Select Case Positioncal.ProcCycle
				Case 0S
					settingfile = "\scladparam.txt"
				Case 1S
					settingfile = "\kcladparam.txt"
				Case 2S
					settingfile = "\vcladparam.txt"
				Case 3S
					settingfile = "\crcladparam.txt"
				Case 4S
					settingfile = "\pcladparam.txt"
				Case 5S
					settingfile = "\bcladparam.txt"
				Case 6S
					settingfile = "\pocketcladparam.txt"
				Case 7S
					settingfile = "\groovecladparam.txt"
				Case 8S
					settingfile = "\congroovecladparam.txt"
				Case 9S
					settingfile = "\3dcladparam.txt"
			End Select
			Dim settings As FileStream = New FileStream(Application.StartupPath + settingfile, FileMode.Open)
			Dim settingsread As StreamReader = New StreamReader(settings)
			Dim projparam As String = Conversions.ToString(CInt(Positioncal.ProcCycle)) + vbCrLf
			projparam += miscread.ReadToEnd()
			miscread.Close()
			projparam += procread.ReadToEnd()
			procread.Close()
			projparam = projparam + Positioncal.ProcCycle.ToString() + vbCrLf
			projparam += settingsread.ReadToEnd()
			settingsread.Close()
			savefiledialog.InitialDirectory = Positioncal.BasePath
			savefiledialog.Title = "Save Project As"
			savefiledialog.Filter = "project files (*.rbp)|*.rbp"
			If savefiledialog.ShowDialog() = DialogResult.OK Then
				Try
					fs = MyProject.Computer.FileSystem.OpenTextFileWriter(savefiledialog.FileName, False)
					If fs IsNot Nothing Then
						fs.WriteLine(projparam)
						Positioncal.CurProjPath = savefiledialog.FileName
						Dim CurProjDir As String = Strings.Left(savefiledialog.FileName, Strings.Len(savefiledialog.FileName) - 4)
						MyProject.Computer.FileSystem.CreateDirectory(CurProjDir)
						MyProject.Computer.FileSystem.CopyFile(Application.StartupPath + settingfile, CurProjDir + settingfile, True)
						MyProject.Computer.FileSystem.CopyFile(Application.StartupPath + "\miscsettings.txt", CurProjDir + "\miscsettings.txt", True)
						MyProject.Computer.FileSystem.CopyFile(Application.StartupPath + "\processsettings.txt", CurProjDir + "\processsettings.txt", True)
						If Positioncal.ProcCycle = 9S Then
							MyProject.Computer.FileSystem.CopyFile(Application.StartupPath + "\tempfile.txt", CurProjDir + "\positions.txt", True)
						End If
						Me.SaveToolStripMenuItem.Enabled = True
						Me.CloseProjectToolStripMenuItem.Enabled = True
						MyBase.Text = "Robot Control - " + MyProject.Computer.FileSystem.GetName(savefiledialog.FileName)
					End If
				Catch ex As Exception
					MessageBox.Show("Cannot create file on disk. Original error: " + ex.Message)
				Finally
					If fs IsNot Nothing Then
						fs.Close()
					End If
				End Try
			End If
		End Sub

		' Token: 0x06000227 RID: 551 RVA: 0x0002D46C File Offset: 0x0002B86C
		Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Dim fs As StreamWriter = Nothing
			Dim misc As FileStream = New FileStream(Application.StartupPath + "\miscsettings.txt", FileMode.Open)
			Dim miscread As StreamReader = New StreamReader(misc)
			Dim proc As FileStream = New FileStream(Application.StartupPath + "\processsettings.txt", FileMode.Open)
			Dim procread As StreamReader = New StreamReader(proc)
			Dim settingfile As String = ""
			Select Case Positioncal.ProcCycle
				Case 0S
					settingfile = "\scladparam.txt"
				Case 1S
					settingfile = "\kcladparam.txt"
				Case 2S
					settingfile = "\vcladparam.txt"
				Case 3S
					settingfile = "\crcladparam.txt"
				Case 4S
					settingfile = "\pcladparam.txt"
				Case 5S
					settingfile = "\bcladparam.txt"
				Case 6S
					settingfile = "\pocketcladparam.txt"
				Case 7S
					settingfile = "\groovecladparam.txt"
				Case 8S
					settingfile = "\congroovecladparam.txt"
				Case 9S
					settingfile = "\3dcladparam.txt"
			End Select
			Dim settings As FileStream = New FileStream(Application.StartupPath + settingfile, FileMode.Open)
			Dim settingsread As StreamReader = New StreamReader(settings)
			Dim projparam As String = Conversions.ToString(CInt(Positioncal.ProcCycle)) + vbCrLf
			projparam += miscread.ReadToEnd()
			miscread.Close()
			projparam += procread.ReadToEnd()
			procread.Close()
			projparam = projparam + Positioncal.ProcCycle.ToString() + vbCrLf
			projparam += settingsread.ReadToEnd()
			settingsread.Close()
			Try
				fs = MyProject.Computer.FileSystem.OpenTextFileWriter(Positioncal.CurProjPath, False)
				If fs IsNot Nothing Then
					fs.WriteLine(projparam)
					Dim CurProjDir As String = Strings.Left(Positioncal.CurProjPath, Strings.Len(Positioncal.CurProjPath) - 4)
					MyProject.Computer.FileSystem.CopyFile(Application.StartupPath + settingfile, CurProjDir + settingfile, True)
					MyProject.Computer.FileSystem.CopyFile(Application.StartupPath + "\miscsettings.txt", CurProjDir + "\miscsettings.txt", True)
					MyProject.Computer.FileSystem.CopyFile(Application.StartupPath + "\processsettings.txt", CurProjDir + "\processsettings.txt", True)
					If Positioncal.ProcCycle = 9S Then
						MyProject.Computer.FileSystem.CopyFile(Application.StartupPath + "\tempfile.txt", CurProjDir + "\positions.txt", True)
					End If
				End If
			Catch ex As Exception
				MessageBox.Show("Cannot create file on disk. Original error: " + ex.Message)
			Finally
				If fs IsNot Nothing Then
					fs.Close()
				End If
			End Try
		End Sub

		' Token: 0x06000228 RID: 552 RVA: 0x0002D728 File Offset: 0x0002BB28
		Private Sub OpenProjectToolStripMenuItem1_Click(sender As Object, e As EventArgs)
			Dim OpenFileDialog As OpenFileDialog = New OpenFileDialog()
			Dim table As DataTable = New DataTable("table")
			OpenFileDialog.Filter = "Robot Project file|*.rbp"
			If OpenFileDialog.ShowDialog() = DialogResult.OK Then
				Dim projreader As StreamReader = MyProject.Computer.FileSystem.OpenTextFileReader(OpenFileDialog.FileName, Encoding.ASCII)
				Positioncal.ProjParam = projreader.ReadLine()
				projreader.Close()
				Dim ProjDir As String = Strings.Left(OpenFileDialog.FileName, Strings.Len(OpenFileDialog.FileName) - 4) + "\"
				Try
					Try
						For Each foundfile As String In MyProject.Computer.FileSystem.GetFiles(ProjDir)
							MyProject.Computer.FileSystem.CopyFile(foundfile, Application.StartupPath + "\" + MyProject.Computer.FileSystem.GetName(foundfile), True)
						Next
					Finally
						Dim enumerator As IEnumerator(Of String)
						If enumerator IsNot Nothing Then
							enumerator.Dispose()
						End If
					End Try
				Catch ex As Exception
					MessageBox.Show("Cannot copy file on disk. Original error: " + ex.Message)
				End Try
				MyBase.OnLoad(e)
				Me.processcycle.Items.Clear()
				Select Case Conversions.ToInteger(Positioncal.ProjParam)
					Case 0
						Me.processcycle.Items.Add("Shaft Plain")
					Case 1
						Me.processcycle.Items.Add("Shaft With Key Hole")
					Case 2
						Me.processcycle.Items.Add("Connical")
					Case 3
						Me.processcycle.Items.Add("Crank")
					Case 4
						Me.processcycle.Items.Add("Plane-Rectangular")
					Case 5
						Me.processcycle.Items.Add("Bore")
					Case 6
						Me.processcycle.Items.Add("Pocket")
					Case 7
						Me.processcycle.Items.Add("Groove")
					Case 8
						Me.processcycle.Items.Add("Conical Groove")
					Case 9
						Dim UFrame As String = ""
						Me.processcycle.Items.Add("3D Clad")
						table.Rows.Clear()
						table.Columns.Add("Index", Type.[GetType]("System.Int32"))
						table.Columns.Add("Laser Power (W)", Type.[GetType]("System.Int32"))
						table.Columns.Add("Clad Width (mm)", Type.[GetType]("System.Double"))
						table.Columns.Add("X (mm)", Type.[GetType]("System.Double"))
						table.Columns.Add("Y (mm)", Type.[GetType]("System.Double"))
						table.Columns.Add("Z (mm)", Type.[GetType]("System.Double"))
						table.Columns.Add("Rx (deg)", Type.[GetType]("System.Double"))
						table.Columns.Add("Ry (deg)", Type.[GetType]("System.Double"))
						table.Columns.Add("Rz (deg)", Type.[GetType]("System.Double"))
						table.Columns.Add("S1 (deg)", Type.[GetType]("System.Double"))
						table.Columns.Add("S2 (deg)", Type.[GetType]("System.Double"))
						Dim filename As String = ProjDir + "Positions.txt"
						Dim stationPosition As Short = CShort(Positioncal.StationPosition)
						Positioncal.LoadPositionFile(filename, table, UFrame, stationPosition, Positioncal.PointNo)
						Positioncal.StationPosition = CInt(stationPosition)
						Positioncal.Position = CType(Utils.CopyArray(CType(Positioncal.Position, Array), New Double(12, Positioncal.PointNo - 1 + 1 - 1) {}), Double(,))
						Dim num As Integer = 0
						Dim num2 As Integer = Positioncal.PointNo - 1
						For i As Integer = num To num2
							Dim j As Integer = 1
							Do
								Positioncal.Position(j + 7, i) = Conversions.ToDouble(table.Rows(i)(j))
								j += 1
							Loop While j <= 2
							Dim num3 As Integer = 3
							Dim num4 As Integer = table.Columns.Count - 1
							For k As Integer = num3 To num4
								Positioncal.Position(k - 3, i) = Conversions.ToDouble(table.Rows(i)(k))
							Next
						Next
				End Select
				Me.SaveToolStripMenuItem.Enabled = True
				Me.CloseProjectToolStripMenuItem.Enabled = True
				MyBase.Text = "Robot Control - " + MyProject.Computer.FileSystem.GetName(OpenFileDialog.FileName)
				Positioncal.ProjLoad = True
			End If
		End Sub

		' Token: 0x06000229 RID: 553 RVA: 0x0002DC2C File Offset: 0x0002C02C
		Private Sub CloseProjectToolStripMenuItem_Click(sender As Object, e As EventArgs)
			MyBase.OnLoad(e)
			Me.SaveToolStripMenuItem.Enabled = False
			Me.CloseProjectToolStripMenuItem.Enabled = False
			MyBase.Text = "Robot Control"
			Positioncal.ProjLoad = False
		End Sub

		' Token: 0x0600022A RID: 554 RVA: 0x0002DC60 File Offset: 0x0002C060
		Private Sub hold_Click(sender As Object, e As EventArgs)
			' The following expression was wrapped in a checked-statement
			MotoCom32.BscHoldOn(CShort(Connection.nCid))
			MotoCom32.BscHoldOff(CShort(Connection.nCid))
		End Sub

		' Token: 0x0600022B RID: 555 RVA: 0x0002DC7C File Offset: 0x0002C07C
		Private Sub Timer1_Tick(sender As Object, e As EventArgs)
			Dim CurrLoc As Double() = New Double(8) {}
			Dim Jobnamear As String() = New String(10) {}
			If Positioncal.time >= 10.0 / CDbl(Me.Timer1.Interval) * 1000.0 And Not Me.Offlinecheck.Checked Then
				' The following expression was wrapped in a checked-expression
				' The following expression was wrapped in a unchecked-expression
				Positioncal.time = CUInt(Math.Round(9.0 / CDbl(Me.Timer1.Interval) * 1000.0))
				Me.connect.PerformClick()
				Me.Countdown.Enabled = False
				Me.Offlinecheck.Enabled = False
			ElseIf Me.Countdown.Enabled And Not Me.Offlinecheck.Checked And Connection.nCid = 0 Then
				' The following expression was wrapped in a checked-expression
				' The following expression was wrapped in a unchecked-expression
				Positioncal.time = CUInt((CULng(Positioncal.time) + 1UL))
				Me.Countdown.Text = "Connecting in " + (10.0 - CDbl((CULng(Positioncal.time) * CULng((CLng(Me.Timer1.Interval))))) / 1000.0).ToString("#0s")
			End If
			If Positioncal.ConectStat = 1S Then
				Dim remmode As Short = MotoCom32.BscIsRemoteMode(CShort(Connection.nCid))
				Dim errorflag As Boolean
				If remmode = -1S AndAlso errorflag Then
					Interaction.MsgBox("Remote mode check failure", MsgBoxStyle.Exclamation, Nothing)
					errorflag = True
				Else
					errorflag = False
					Dim Robstat As Short
					Dim Robstat2 As Short
					Dim retur As Short = MotoCom32.BscGetStatus(CShort(Connection.nCid), Robstat, Robstat2)
					If retur = -1S And Not errorflag Then
						Interaction.MsgBox("Robot status acquisition failure", MsgBoxStyle.Exclamation, Nothing)
						errorflag = True
					Else
						errorflag = False
						If remmode = 1S And (Robstat = 202S Or Robstat = 74S Or Robstat = 210S Or Robstat = 82S Or Robstat = 204S Or Robstat = 76S) Then
							Me.hold.Enabled = True
							Me.hold.ForeColor = Color.Red
							Me.run.Enabled = True
							Me.run.ForeColor = Color.Green
							Me.run.Text = "Running"
							Me.XCoord.Enabled = True
							Me.YCoord.Enabled = True
							Me.ZCoord.Enabled = True
							Me.RXCoord.Enabled = True
							Me.RYCoord.Enabled = True
							Me.RZCoord.Enabled = True
							Me.ProgressBar.Enabled = True
							Dim Subtaskinf As Short = 1S
							If Subtaskinf = 1S Then
								Dim Jobstep As Integer = CInt(MotoCom32.BscIsJobStep(CShort(Connection.nCid)))
								If Not(Jobstep < 0 And Not errorflag) Then
									errorflag = False
									If Jobstep <= Me.ProgressBar.Maximum Then
										Me.ProgressBar.Value = Jobstep
									Else
										Me.ProgressBar.Value = Me.ProgressBar.Maximum
									End If
									Dim Uframe As String = "UF" + Positioncal.StationPosition.ToString()
									Me.XCoord.Text = CurrLoc(0).ToString("#0.00")
									Me.YCoord.Text = CurrLoc(1).ToString("#0.00")
									Me.ZCoord.Text = CurrLoc(2).ToString("#0.00")
									Me.RXCoord.Text = CurrLoc(3).ToString("#0.00")
									Me.RYCoord.Text = CurrLoc(4).ToString("#0.00")
									Me.RZCoord.Text = CurrLoc(5).ToString("#0.00")
									Return
								End If
								Interaction.MsgBox("Job step acquisition failure", MsgBoxStyle.Exclamation, Nothing)
								errorflag = True
							ElseIf Subtaskinf = -1S And Not errorflag Then
								Interaction.MsgBox("Subtask change attempt failure", MsgBoxStyle.Exclamation, Nothing)
								errorflag = True
							End If
						End If
					End If
				End If
				Me.hold.Enabled = False
				Me.run.ForeColor = Color.Red
				Me.run.Text = "Stopped"
				Me.XCoord.Text = ""
				Me.YCoord.Text = ""
				Me.ZCoord.Text = ""
				Me.RXCoord.Text = ""
				Me.RYCoord.Text = ""
				Me.RZCoord.Text = ""
				Me.XCoord.Enabled = False
				Me.YCoord.Enabled = False
				Me.ZCoord.Enabled = False
				Me.RXCoord.Enabled = False
				Me.RYCoord.Enabled = False
				Me.RZCoord.Enabled = False
				Me.ProgressBar.Value = 0
			End If
		End Sub

		' Token: 0x0600022C RID: 556 RVA: 0x0002E128 File Offset: 0x0002C528
		Private Sub Offlinecheck_CheckedChanged(sender As Object, e As EventArgs)
			If Me.Offlinecheck.Checked And Positioncal.ConectStat = 0S Then
				Me.connect.Enabled = False
				Me.Timer1.Enabled = False
			Else
				Me.connect.Enabled = True
				Me.Timer1.Enabled = True
			End If
		End Sub

		' Token: 0x040000AA RID: 170
		<AccessedThroughProperty("MenuStrip1")>
		Private _MenuStrip1 As MenuStrip

		' Token: 0x040000AB RID: 171
		<AccessedThroughProperty("FileToolStripMenuItem")>
		Private _FileToolStripMenuItem As ToolStripMenuItem

		' Token: 0x040000AC RID: 172
		<AccessedThroughProperty("OpenProjectToolStripMenuItem1")>
		Private _OpenProjectToolStripMenuItem1 As ToolStripMenuItem

		' Token: 0x040000AD RID: 173
		<AccessedThroughProperty("SaveToolStripMenuItem")>
		Private _SaveToolStripMenuItem As ToolStripMenuItem

		' Token: 0x040000AE RID: 174
		<AccessedThroughProperty("SaveAsToolStripMenuItem")>
		Private _SaveAsToolStripMenuItem As ToolStripMenuItem

		' Token: 0x040000AF RID: 175
		<AccessedThroughProperty("CloseProjectToolStripMenuItem")>
		Private _CloseProjectToolStripMenuItem As ToolStripMenuItem

		' Token: 0x040000B0 RID: 176
		<AccessedThroughProperty("ExitToolStripMenuItem")>
		Private _ExitToolStripMenuItem As ToolStripMenuItem

		' Token: 0x040000B1 RID: 177
		<AccessedThroughProperty("HelpToolStripMenuItem")>
		Private _HelpToolStripMenuItem As ToolStripMenuItem

		' Token: 0x040000B2 RID: 178
		<AccessedThroughProperty("processcycle")>
		Private _processcycle As ComboBox

		' Token: 0x040000B3 RID: 179
		<AccessedThroughProperty("Label1")>
		Private _Label1 As Label

		' Token: 0x040000B4 RID: 180
		<AccessedThroughProperty("HelpToolStripMenuItem1")>
		Private _HelpToolStripMenuItem1 As ToolStripMenuItem

		' Token: 0x040000B5 RID: 181
		<AccessedThroughProperty("AboutToolStripMenuItem")>
		Private _AboutToolStripMenuItem As ToolStripMenuItem

		' Token: 0x040000B6 RID: 182
		<AccessedThroughProperty("Quitbtn")>
		Private _Quitbtn As Button

		' Token: 0x040000B7 RID: 183
		<AccessedThroughProperty("connect")>
		Private _connect As Button

		' Token: 0x040000B8 RID: 184
		<AccessedThroughProperty("GroupBox1")>
		Private _GroupBox1 As GroupBox

		' Token: 0x040000B9 RID: 185
		<AccessedThroughProperty("GroupBox2")>
		Private _GroupBox2 As GroupBox

		' Token: 0x040000BA RID: 186
		<AccessedThroughProperty("hold")>
		Private _hold As Button

		' Token: 0x040000BB RID: 187
		<AccessedThroughProperty("run")>
		Private _run As Button

		' Token: 0x040000BC RID: 188
		<AccessedThroughProperty("Download")>
		Private _Download As Button

		' Token: 0x040000BD RID: 189
		<AccessedThroughProperty("GroupBox3")>
		Private _GroupBox3 As GroupBox

		' Token: 0x040000BE RID: 190
		<AccessedThroughProperty("GroupBox4")>
		Private _GroupBox4 As GroupBox

		' Token: 0x040000BF RID: 191
		<AccessedThroughProperty("Procsetupbtn")>
		Private _Procsetupbtn As Button

		' Token: 0x040000C0 RID: 192
		<AccessedThroughProperty("ConnectionSettingsToolStripMenuItem")>
		Private _ConnectionSettingsToolStripMenuItem As ToolStripMenuItem

		' Token: 0x040000C1 RID: 193
		<AccessedThroughProperty("MisselaneousSettingsToolStripMenuItem")>
		Private _MisselaneousSettingsToolStripMenuItem As ToolStripMenuItem

		' Token: 0x040000C2 RID: 194
		<AccessedThroughProperty("Timer1")>
		Private _Timer1 As Timer

		' Token: 0x040000C3 RID: 195
		<AccessedThroughProperty("Countdown")>
		Private _Countdown As Label

		' Token: 0x040000C4 RID: 196
		<AccessedThroughProperty("Offlinecheck")>
		Private _Offlinecheck As CheckBox

		' Token: 0x040000C5 RID: 197
		<AccessedThroughProperty("Progress")>
		Private _Progress As Label

		' Token: 0x040000C6 RID: 198
		<AccessedThroughProperty("ProgressBar")>
		Private _ProgressBar As ProgressBar

		' Token: 0x040000C7 RID: 199
		<AccessedThroughProperty("Label7")>
		Private _Label7 As Label

		' Token: 0x040000C8 RID: 200
		<AccessedThroughProperty("Label6")>
		Private _Label6 As Label

		' Token: 0x040000C9 RID: 201
		<AccessedThroughProperty("RZCoord")>
		Private _RZCoord As TextBox

		' Token: 0x040000CA RID: 202
		<AccessedThroughProperty("RYCoord")>
		Private _RYCoord As TextBox

		' Token: 0x040000CB RID: 203
		<AccessedThroughProperty("Label5")>
		Private _Label5 As Label

		' Token: 0x040000CC RID: 204
		<AccessedThroughProperty("RXCoord")>
		Private _RXCoord As TextBox

		' Token: 0x040000CD RID: 205
		<AccessedThroughProperty("Label4")>
		Private _Label4 As Label

		' Token: 0x040000CE RID: 206
		<AccessedThroughProperty("ZCoord")>
		Private _ZCoord As TextBox

		' Token: 0x040000CF RID: 207
		<AccessedThroughProperty("Label3")>
		Private _Label3 As Label

		' Token: 0x040000D0 RID: 208
		<AccessedThroughProperty("YCoord")>
		Private _YCoord As TextBox

		' Token: 0x040000D1 RID: 209
		<AccessedThroughProperty("Label2")>
		Private _Label2 As Label

		' Token: 0x040000D2 RID: 210
		<AccessedThroughProperty("XCoord")>
		Private _XCoord As TextBox

		' Token: 0x040000D3 RID: 211
		Private formatstat As Short
	End Class
End Namespace
