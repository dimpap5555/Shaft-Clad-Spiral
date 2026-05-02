Imports System
Imports System.ComponentModel.Design
Imports System.Diagnostics
Imports System.Runtime.CompilerServices
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

Namespace My
	' Token: 0x02000017 RID: 23
	<CompilerGenerated()>
	<HideModuleName()>
	<DebuggerNonUserCode()>
	Friend NotInheritable Module MySettingsProperty
		' Token: 0x1700016F RID: 367
		' (get) Token: 0x0600048D RID: 1165 RVA: 0x00003028 File Offset: 0x00001428
		<HelpKeyword("My.Settings")>
		Friend ReadOnly Property Settings As MySettings
			Get
				Return MySettings.[Default]
			End Get
		End Property
	End Module
End Namespace
