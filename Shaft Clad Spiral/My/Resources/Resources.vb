Imports System
Imports System.CodeDom.Compiler
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Globalization
Imports System.Resources
Imports System.Runtime.CompilerServices
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

Namespace My.Resources
	''' <summary>
	'''   A strongly-typed resource class, for looking up localized strings, etc.
	''' </summary>
	' Token: 0x02000015 RID: 21
	<DebuggerNonUserCode()>
	<HideModuleName()>
	<CompilerGenerated()>
	<GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")>
	Friend NotInheritable Module Resources
		''' <summary>
		'''   Returns the cached ResourceManager instance used by this class.
		''' </summary>
		' Token: 0x1700016C RID: 364
		' (get) Token: 0x06000486 RID: 1158 RVA: 0x00002F1C File Offset: 0x0000131C
		<EditorBrowsable(EditorBrowsableState.Advanced)>
		Friend ReadOnly Property ResourceManager As ResourceManager
			Get
				If Object.ReferenceEquals(Resources.resourceMan, Nothing) Then
					Dim temp As ResourceManager = New ResourceManager("WindowsApplication1.Resources", GetType(Resources).Assembly)
					Resources.resourceMan = temp
				End If
				Return Resources.resourceMan
			End Get
		End Property

		' Token: 0x1700016D RID: 365
		' (get) Token: 0x06000487 RID: 1159 RVA: 0x00002F5C File Offset: 0x0000135C
		' (set) Token: 0x06000488 RID: 1160 RVA: 0x00002F70 File Offset: 0x00001370
		<EditorBrowsable(EditorBrowsableState.Advanced)>
		Friend Property Culture As CultureInfo
			Get
				Return Resources.resourceCulture
			End Get
			Set(value As CultureInfo)
				Resources.resourceCulture = value
			End Set
		End Property

		' Token: 0x0400018A RID: 394
		Private resourceMan As ResourceManager

		' Token: 0x0400018B RID: 395
		Private resourceCulture As CultureInfo
	End Module
End Namespace
