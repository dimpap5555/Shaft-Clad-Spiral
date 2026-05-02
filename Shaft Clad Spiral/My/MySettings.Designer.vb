Imports System
Imports System.CodeDom.Compiler
Imports System.ComponentModel
Imports System.Configuration
Imports System.Diagnostics
Imports System.Runtime.CompilerServices
Imports Microsoft.VisualBasic.CompilerServices

Namespace My
	' Token: 0x02000016 RID: 22
	<CompilerGenerated()>
	<EditorBrowsable(EditorBrowsableState.Advanced)>
	<GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "10.0.0.0")>
	Friend NotInheritable Partial Class MySettings
		Inherits ApplicationSettingsBase

		' Token: 0x0600048B RID: 1163 RVA: 0x00002FA8 File Offset: 0x000013A8
		<EditorBrowsable(EditorBrowsableState.Advanced)>
		<DebuggerNonUserCode()>
		Private Shared Sub AutoSaveSettings(sender As Object, e As EventArgs)
			If MyProject.Application.SaveMySettingsOnExit Then
				MySettingsProperty.Settings.Save()
			End If
		End Sub

		' Token: 0x1700016E RID: 366
		' (get) Token: 0x0600048C RID: 1164 RVA: 0x00002FC0 File Offset: 0x000013C0
		Public Shared ReadOnly Property [Default] As MySettings
			Get
				If Not MySettings.addedHandler Then
					Dim obj As Object = MySettings.addedHandlerLockObject
					ObjectFlowControl.CheckForSyncLockOnValueType(obj)
					SyncLock obj
						If Not MySettings.addedHandler Then
							AddHandler MyProject.Application.Shutdown, AddressOf MySettings.AutoSaveSettings
							MySettings.addedHandler = True
						End If
					End SyncLock
				End If
				Return MySettings.defaultInstance
			End Get
		End Property

		' Token: 0x0400018C RID: 396
		Private Shared defaultInstance As MySettings = CType(SettingsBase.Synchronized(New MySettings()), MySettings)

		' Token: 0x0400018D RID: 397
		Private Shared addedHandler As Boolean

		' Token: 0x0400018E RID: 398
		Private Shared addedHandlerLockObject As Object = RuntimeHelpers.GetObjectValue(New Object())
	End Class
End Namespace
