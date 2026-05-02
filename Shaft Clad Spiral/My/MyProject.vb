Imports System
Imports System.CodeDom.Compiler
Imports System.Collections
Imports System.ComponentModel
Imports System.ComponentModel.Design
Imports System.Diagnostics
Imports System.Reflection
Imports System.Runtime.CompilerServices
Imports System.Runtime.InteropServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.ApplicationServices
Imports Microsoft.VisualBasic.CompilerServices

Namespace WindowsApplication1.My
	' Token: 0x02000004 RID: 4
	<GeneratedCode("MyTemplate", "8.0.0.0")>
	<HideModuleName()>
	Friend Module MyProject
		' Token: 0x17000001 RID: 1
		' (get) Token: 0x06000006 RID: 6 RVA: 0x00016B3C File Offset: 0x00014F3C
		<HelpKeyword("My.Computer")>
		Friend ReadOnly Property Computer As MyComputer
			<DebuggerHidden()>
			Get
				Return MyProject.m_ComputerObjectProvider.GetInstance
			End Get
		End Property

		' Token: 0x17000002 RID: 2
		' (get) Token: 0x06000007 RID: 7 RVA: 0x00016B54 File Offset: 0x00014F54
		<HelpKeyword("My.Application")>
		Friend ReadOnly Property Application As MyApplication
			<DebuggerHidden()>
			Get
				Return MyProject.m_AppObjectProvider.GetInstance
			End Get
		End Property

		' Token: 0x17000003 RID: 3
		' (get) Token: 0x06000008 RID: 8 RVA: 0x00016B6C File Offset: 0x00014F6C
		<HelpKeyword("My.User")>
		Friend ReadOnly Property User As User
			<DebuggerHidden()>
			Get
				Return MyProject.m_UserObjectProvider.GetInstance
			End Get
		End Property

		' Token: 0x17000004 RID: 4
		' (get) Token: 0x06000009 RID: 9 RVA: 0x00016B84 File Offset: 0x00014F84
		<HelpKeyword("My.Forms")>
		Friend ReadOnly Property Forms As MyProject.MyForms
			<DebuggerHidden()>
			Get
				Return MyProject.m_MyFormsObjectProvider.GetInstance
			End Get
		End Property

		' Token: 0x17000005 RID: 5
		' (get) Token: 0x0600000A RID: 10 RVA: 0x00016B9C File Offset: 0x00014F9C
		<HelpKeyword("My.WebServices")>
		Friend ReadOnly Property WebServices As MyProject.MyWebServices
			<DebuggerHidden()>
			Get
				Return MyProject.m_MyWebServicesObjectProvider.GetInstance
			End Get
		End Property

		' Token: 0x04000001 RID: 1
		Private m_ComputerObjectProvider As MyProject.ThreadSafeObjectProvider(Of MyComputer) = New MyProject.ThreadSafeObjectProvider(Of MyComputer)()

		' Token: 0x04000002 RID: 2
		Private m_AppObjectProvider As MyProject.ThreadSafeObjectProvider(Of MyApplication) = New MyProject.ThreadSafeObjectProvider(Of MyApplication)()

		' Token: 0x04000003 RID: 3
		Private m_UserObjectProvider As MyProject.ThreadSafeObjectProvider(Of User) = New MyProject.ThreadSafeObjectProvider(Of User)()

		' Token: 0x04000004 RID: 4
		Private m_MyFormsObjectProvider As MyProject.ThreadSafeObjectProvider(Of MyProject.MyForms) = New MyProject.ThreadSafeObjectProvider(Of MyProject.MyForms)()

		' Token: 0x04000005 RID: 5
		Private m_MyWebServicesObjectProvider As MyProject.ThreadSafeObjectProvider(Of MyProject.MyWebServices) = New MyProject.ThreadSafeObjectProvider(Of MyProject.MyWebServices)()

		' Token: 0x02000005 RID: 5
		'<EditorBrowsable(EditorBrowsableState.Never)>
		'<MyGroupCollection("System.Windows.Forms.Form", "Create__Instance__", "Dispose__Instance__", "")>
		Friend NotInheritable Class MyForms
			' Token: 0x17000006 RID: 6
			' (get) Token: 0x0600000B RID: 11 RVA: 0x00016BB4 File Offset: 0x00014FB4
			' (set) Token: 0x0600001D RID: 29 RVA: 0x00016E3C File Offset: 0x0001523C
			Public Property BPARAM As BPARAM
				<DebuggerNonUserCode()>
				Get
					Me.m_BPARAM = MyProject.MyForms.Create__Instance__(Of BPARAM)(Me.m_BPARAM)
					Return Me.m_BPARAM
				End Get
				<DebuggerNonUserCode()>
				Set(value As BPARAM)
					If value Is Me.m_BPARAM Then
						Return
					End If
					If value IsNot Nothing Then
						Throw New ArgumentException("Property can only be set to Nothing")
					End If
					Me.Dispose__Instance__(Of BPARAM)(Me.m_BPARAM)
				End Set
			End Property

			' Token: 0x17000007 RID: 7
			' (get) Token: 0x0600000C RID: 12 RVA: 0x00016BD8 File Offset: 0x00014FD8
			' (set) Token: 0x0600001E RID: 30 RVA: 0x00016E64 File Offset: 0x00015264
			Public Property CONGRVPARAM As CONGRVPARAM
				<DebuggerNonUserCode()>
				Get
					Me.m_CONGRVPARAM = MyProject.MyForms.Create__Instance__(Of CONGRVPARAM)(Me.m_CONGRVPARAM)
					Return Me.m_CONGRVPARAM
				End Get
				<DebuggerNonUserCode()>
				Set(value As CONGRVPARAM)
					If value Is Me.m_CONGRVPARAM Then
						Return
					End If
					If value IsNot Nothing Then
						Throw New ArgumentException("Property can only be set to Nothing")
					End If
					Me.Dispose__Instance__(Of CONGRVPARAM)(Me.m_CONGRVPARAM)
				End Set
			End Property

			' Token: 0x17000008 RID: 8
			' (get) Token: 0x0600000D RID: 13 RVA: 0x00016BFC File Offset: 0x00014FFC
			' (set) Token: 0x0600001F RID: 31 RVA: 0x00016E8C File Offset: 0x0001528C
			Public Property ConnectionSettings As ConnectionSettings
				<DebuggerNonUserCode()>
				Get
					Me.m_ConnectionSettings = MyProject.MyForms.Create__Instance__(Of ConnectionSettings)(Me.m_ConnectionSettings)
					Return Me.m_ConnectionSettings
				End Get
				<DebuggerNonUserCode()>
				Set(value As ConnectionSettings)
					If value Is Me.m_ConnectionSettings Then
						Return
					End If
					If value IsNot Nothing Then
						Throw New ArgumentException("Property can only be set to Nothing")
					End If
					Me.Dispose__Instance__(Of ConnectionSettings)(Me.m_ConnectionSettings)
				End Set
			End Property

			' Token: 0x17000009 RID: 9
			' (get) Token: 0x0600000E RID: 14 RVA: 0x00016C20 File Offset: 0x00015020
			' (set) Token: 0x06000020 RID: 32 RVA: 0x00016EB4 File Offset: 0x000152B4
			Public Property CRPARAM As CRPARAM
				<DebuggerNonUserCode()>
				Get
					Me.m_CRPARAM = MyProject.MyForms.Create__Instance__(Of CRPARAM)(Me.m_CRPARAM)
					Return Me.m_CRPARAM
				End Get
				<DebuggerNonUserCode()>
				Set(value As CRPARAM)
					If value Is Me.m_CRPARAM Then
						Return
					End If
					If value IsNot Nothing Then
						Throw New ArgumentException("Property can only be set to Nothing")
					End If
					Me.Dispose__Instance__(Of CRPARAM)(Me.m_CRPARAM)
				End Set
			End Property

			' Token: 0x1700000A RID: 10
			' (get) Token: 0x0600000F RID: 15 RVA: 0x00016C44 File Offset: 0x00015044
			' (set) Token: 0x06000021 RID: 33 RVA: 0x00016EDC File Offset: 0x000152DC
			Public Property Form1 As Form1
				<DebuggerNonUserCode()>
				Get
					Me.m_Form1 = MyProject.MyForms.Create__Instance__(Of Form1)(Me.m_Form1)
					Return Me.m_Form1
				End Get
				<DebuggerNonUserCode()>
				Set(value As Form1)
					If value Is Me.m_Form1 Then
						Return
					End If
					If value IsNot Nothing Then
						Throw New ArgumentException("Property can only be set to Nothing")
					End If
					Me.Dispose__Instance__(Of Form1)(Me.m_Form1)
				End Set
			End Property

			' Token: 0x1700000B RID: 11
			' (get) Token: 0x06000010 RID: 16 RVA: 0x00016C68 File Offset: 0x00015068
			' (set) Token: 0x06000022 RID: 34 RVA: 0x00016F04 File Offset: 0x00015304
			Public Property GRVPARAM As GRVPARAM
				<DebuggerNonUserCode()>
				Get
					Me.m_GRVPARAM = MyProject.MyForms.Create__Instance__(Of GRVPARAM)(Me.m_GRVPARAM)
					Return Me.m_GRVPARAM
				End Get
				<DebuggerNonUserCode()>
				Set(value As GRVPARAM)
					If value Is Me.m_GRVPARAM Then
						Return
					End If
					If value IsNot Nothing Then
						Throw New ArgumentException("Property can only be set to Nothing")
					End If
					Me.Dispose__Instance__(Of GRVPARAM)(Me.m_GRVPARAM)
				End Set
			End Property

			' Token: 0x1700000C RID: 12
			' (get) Token: 0x06000011 RID: 17 RVA: 0x00016C8C File Offset: 0x0001508C
			' (set) Token: 0x06000023 RID: 35 RVA: 0x00016F2C File Offset: 0x0001532C
			Public Property IObox As IObox
				<DebuggerNonUserCode()>
				Get
					Me.m_IObox = MyProject.MyForms.Create__Instance__(Of IObox)(Me.m_IObox)
					Return Me.m_IObox
				End Get
				<DebuggerNonUserCode()>
				Set(value As IObox)
					If value Is Me.m_IObox Then
						Return
					End If
					If value IsNot Nothing Then
						Throw New ArgumentException("Property can only be set to Nothing")
					End If
					Me.Dispose__Instance__(Of IObox)(Me.m_IObox)
				End Set
			End Property

			' Token: 0x1700000D RID: 13
			' (get) Token: 0x06000012 RID: 18 RVA: 0x00016CB0 File Offset: 0x000150B0
			' (set) Token: 0x06000024 RID: 36 RVA: 0x00016F54 File Offset: 0x00015354
			Public Property KEYPARAM As KEYPARAM
				<DebuggerNonUserCode()>
				Get
					Me.m_KEYPARAM = MyProject.MyForms.Create__Instance__(Of KEYPARAM)(Me.m_KEYPARAM)
					Return Me.m_KEYPARAM
				End Get
				<DebuggerNonUserCode()>
				Set(value As KEYPARAM)
					If value Is Me.m_KEYPARAM Then
						Return
					End If
					If value IsNot Nothing Then
						Throw New ArgumentException("Property can only be set to Nothing")
					End If
					Me.Dispose__Instance__(Of KEYPARAM)(Me.m_KEYPARAM)
				End Set
			End Property

			' Token: 0x1700000E RID: 14
			' (get) Token: 0x06000013 RID: 19 RVA: 0x00016CD4 File Offset: 0x000150D4
			' (set) Token: 0x06000025 RID: 37 RVA: 0x00016F7C File Offset: 0x0001537C
			Public Property Miscsettings As Miscsettings
				<DebuggerNonUserCode()>
				Get
					Me.m_Miscsettings = MyProject.MyForms.Create__Instance__(Of Miscsettings)(Me.m_Miscsettings)
					Return Me.m_Miscsettings
				End Get
				<DebuggerNonUserCode()>
				Set(value As Miscsettings)
					If value Is Me.m_Miscsettings Then
						Return
					End If
					If value IsNot Nothing Then
						Throw New ArgumentException("Property can only be set to Nothing")
					End If
					Me.Dispose__Instance__(Of Miscsettings)(Me.m_Miscsettings)
				End Set
			End Property

			' Token: 0x1700000F RID: 15
			' (get) Token: 0x06000014 RID: 20 RVA: 0x00016CF8 File Offset: 0x000150F8
			' (set) Token: 0x06000026 RID: 38 RVA: 0x00016FA4 File Offset: 0x000153A4
			Public Property MPosıtıonupload As MPosıtıonupload
				<DebuggerNonUserCode()>
				Get
					Me.m_MPosıtıonupload = MyProject.MyForms.Create__Instance__(Of MPosıtıonupload)(Me.m_MPosıtıonupload)
					Return Me.m_MPosıtıonupload
				End Get
				<DebuggerNonUserCode()>
				Set(value As MPosıtıonupload)
					If value Is Me.m_MPosıtıonupload Then
						Return
					End If
					If value IsNot Nothing Then
						Throw New ArgumentException("Property can only be set to Nothing")
					End If
					Me.Dispose__Instance__(Of MPosıtıonupload)(Me.m_MPosıtıonupload)
				End Set
			End Property

			' Token: 0x17000010 RID: 16
			' (get) Token: 0x06000015 RID: 21 RVA: 0x00016D1C File Offset: 0x0001511C
			' (set) Token: 0x06000027 RID: 39 RVA: 0x00016FCC File Offset: 0x000153CC
			Public Property PLANPARAM As PLANPARAM
				<DebuggerNonUserCode()>
				Get
					Me.m_PLANPARAM = MyProject.MyForms.Create__Instance__(Of PLANPARAM)(Me.m_PLANPARAM)
					Return Me.m_PLANPARAM
				End Get
				<DebuggerNonUserCode()>
				Set(value As PLANPARAM)
					If value Is Me.m_PLANPARAM Then
						Return
					End If
					If value IsNot Nothing Then
						Throw New ArgumentException("Property can only be set to Nothing")
					End If
					Me.Dispose__Instance__(Of PLANPARAM)(Me.m_PLANPARAM)
				End Set
			End Property

			' Token: 0x17000011 RID: 17
			' (get) Token: 0x06000016 RID: 22 RVA: 0x00016D40 File Offset: 0x00015140
			' (set) Token: 0x06000028 RID: 40 RVA: 0x00016FF4 File Offset: 0x000153F4
			Public Property POCKETPARAM As POCKETPARAM
				<DebuggerNonUserCode()>
				Get
					Me.m_POCKETPARAM = MyProject.MyForms.Create__Instance__(Of POCKETPARAM)(Me.m_POCKETPARAM)
					Return Me.m_POCKETPARAM
				End Get
				<DebuggerNonUserCode()>
				Set(value As POCKETPARAM)
					If value Is Me.m_POCKETPARAM Then
						Return
					End If
					If value IsNot Nothing Then
						Throw New ArgumentException("Property can only be set to Nothing")
					End If
					Me.Dispose__Instance__(Of POCKETPARAM)(Me.m_POCKETPARAM)
				End Set
			End Property

			' Token: 0x17000012 RID: 18
			' (get) Token: 0x06000017 RID: 23 RVA: 0x00016D64 File Offset: 0x00015164
			' (set) Token: 0x06000029 RID: 41 RVA: 0x0001701C File Offset: 0x0001541C
			Public Property Posıtıonupload As Posıtıonupload
				<DebuggerNonUserCode()>
				Get
					Me.m_Posıtıonupload = MyProject.MyForms.Create__Instance__(Of Posıtıonupload)(Me.m_Posıtıonupload)
					Return Me.m_Posıtıonupload
				End Get
				<DebuggerNonUserCode()>
				Set(value As Posıtıonupload)
					If value Is Me.m_Posıtıonupload Then
						Return
					End If
					If value IsNot Nothing Then
						Throw New ArgumentException("Property can only be set to Nothing")
					End If
					Me.Dispose__Instance__(Of Posıtıonupload)(Me.m_Posıtıonupload)
				End Set
			End Property

			' Token: 0x17000013 RID: 19
			' (get) Token: 0x06000018 RID: 24 RVA: 0x00016D88 File Offset: 0x00015188
			' (set) Token: 0x0600002A RID: 42 RVA: 0x00017044 File Offset: 0x00015444
			Public Property PPARAM As PPARAM
				<DebuggerNonUserCode()>
				Get
					Me.m_PPARAM = MyProject.MyForms.Create__Instance__(Of PPARAM)(Me.m_PPARAM)
					Return Me.m_PPARAM
				End Get
				<DebuggerNonUserCode()>
				Set(value As PPARAM)
					If value Is Me.m_PPARAM Then
						Return
					End If
					If value IsNot Nothing Then
						Throw New ArgumentException("Property can only be set to Nothing")
					End If
					Me.Dispose__Instance__(Of PPARAM)(Me.m_PPARAM)
				End Set
			End Property

			' Token: 0x17000014 RID: 20
			' (get) Token: 0x06000019 RID: 25 RVA: 0x00016DAC File Offset: 0x000151AC
			' (set) Token: 0x0600002B RID: 43 RVA: 0x0001706C File Offset: 0x0001546C
			Public Property Processsetup As Processsetup
				<DebuggerNonUserCode()>
				Get
					Me.m_Processsetup = MyProject.MyForms.Create__Instance__(Of Processsetup)(Me.m_Processsetup)
					Return Me.m_Processsetup
				End Get
				<DebuggerNonUserCode()>
				Set(value As Processsetup)
					If value Is Me.m_Processsetup Then
						Return
					End If
					If value IsNot Nothing Then
						Throw New ArgumentException("Property can only be set to Nothing")
					End If
					Me.Dispose__Instance__(Of Processsetup)(Me.m_Processsetup)
				End Set
			End Property

			' Token: 0x17000015 RID: 21
			' (get) Token: 0x0600001A RID: 26 RVA: 0x00016DD0 File Offset: 0x000151D0
			' (set) Token: 0x0600002C RID: 44 RVA: 0x00017094 File Offset: 0x00015494
			Public Property SPARAM As SPARAM
				<DebuggerNonUserCode()>
				Get
					Me.m_SPARAM = MyProject.MyForms.Create__Instance__(Of SPARAM)(Me.m_SPARAM)
					Return Me.m_SPARAM
				End Get
				<DebuggerNonUserCode()>
				Set(value As SPARAM)
					If value Is Me.m_SPARAM Then
						Return
					End If
					If value IsNot Nothing Then
						Throw New ArgumentException("Property can only be set to Nothing")
					End If
					Me.Dispose__Instance__(Of SPARAM)(Me.m_SPARAM)
				End Set
			End Property

			' Token: 0x17000016 RID: 22
			' (get) Token: 0x0600001B RID: 27 RVA: 0x00016DF4 File Offset: 0x000151F4
			' (set) Token: 0x0600002D RID: 45 RVA: 0x000170BC File Offset: 0x000154BC
			Public Property THREEDCLADPARAM As THREEDCLADPARAM
				<DebuggerNonUserCode()>
				Get
					Me.m_THREEDCLADPARAM = MyProject.MyForms.Create__Instance__(Of THREEDCLADPARAM)(Me.m_THREEDCLADPARAM)
					Return Me.m_THREEDCLADPARAM
				End Get
				<DebuggerNonUserCode()>
				Set(value As THREEDCLADPARAM)
					If value Is Me.m_THREEDCLADPARAM Then
						Return
					End If
					If value IsNot Nothing Then
						Throw New ArgumentException("Property can only be set to Nothing")
					End If
					Me.Dispose__Instance__(Of THREEDCLADPARAM)(Me.m_THREEDCLADPARAM)
				End Set
			End Property

			' Token: 0x17000017 RID: 23
			' (get) Token: 0x0600001C RID: 28 RVA: 0x00016E18 File Offset: 0x00015218
			' (set) Token: 0x0600002E RID: 46 RVA: 0x000170E4 File Offset: 0x000154E4
			Public Property VPARAM As VPARAM
				<DebuggerNonUserCode()>
				Get
					Me.m_VPARAM = MyProject.MyForms.Create__Instance__(Of VPARAM)(Me.m_VPARAM)
					Return Me.m_VPARAM
				End Get
				<DebuggerNonUserCode()>
				Set(value As VPARAM)
					If value Is Me.m_VPARAM Then
						Return
					End If
					If value IsNot Nothing Then
						Throw New ArgumentException("Property can only be set to Nothing")
					End If
					Me.Dispose__Instance__(Of VPARAM)(Me.m_VPARAM)
				End Set
			End Property

			' Token: 0x0600002F RID: 47 RVA: 0x0001710C File Offset: 0x0001550C
			<DebuggerHidden()>
			Private Shared Function Create__Instance__(Of T As {Form, New})(Instance As T) As T
				If Instance Is Nothing OrElse Instance.IsDisposed Then
					If MyProject.MyForms.m_FormBeingCreated IsNot Nothing Then
						If MyProject.MyForms.m_FormBeingCreated.ContainsKey(GetType(T)) Then
							Throw New InvalidOperationException(Utils.GetResourceString("WinForms_RecursiveFormCreate", New String(-1) {}))
						End If
					Else
						MyProject.MyForms.m_FormBeingCreated = New Hashtable()
					End If
					MyProject.MyForms.m_FormBeingCreated.Add(GetType(T), Nothing)
					Try
						Return Activator.CreateInstance(Of T)()
					Catch ex As TargetInvocationException When ex.InnerException IsNot Nothing
						Dim BetterMessage As String = Utils.GetResourceString("WinForms_SeeInnerException", New String() {ex.InnerException.Message})
						Throw New InvalidOperationException(BetterMessage, ex.InnerException)
					Finally
						MyProject.MyForms.m_FormBeingCreated.Remove(GetType(T))
					End Try
					Return Instance
				End If
				Return Instance
			End Function

			' Token: 0x06000030 RID: 48 RVA: 0x00017218 File Offset: 0x00015618
			<DebuggerHidden()>
			Private Sub Dispose__Instance__(Of T As Form)(ByRef instance As T)
				instance.Dispose()
				instance = Nothing
			End Sub

			' Token: 0x06000031 RID: 49 RVA: 0x00017240 File Offset: 0x00015640
			<EditorBrowsable(EditorBrowsableState.Never)>
			<DebuggerHidden()>
			Public Sub New()
			End Sub

			' Token: 0x06000032 RID: 50 RVA: 0x00017248 File Offset: 0x00015648
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public Overrides Function Equals(o As Object) As Boolean
				Return MyBase.Equals(RuntimeHelpers.GetObjectValue(o))
			End Function

			' Token: 0x06000033 RID: 51 RVA: 0x00017264 File Offset: 0x00015664
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public Overrides Function GetHashCode() As Integer
				Return MyBase.GetHashCode()
			End Function

			' Token: 0x06000034 RID: 52 RVA: 0x00017278 File Offset: 0x00015678
			<EditorBrowsable(EditorBrowsableState.Never)>
			Friend Overloads Function [GetType]() As Type
				Return GetType(MyProject.MyForms)
			End Function

			' Token: 0x06000035 RID: 53 RVA: 0x00017290 File Offset: 0x00015690
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public Overrides Function ToString() As String
				Return MyBase.ToString()
			End Function

			' Token: 0x04000006 RID: 6
			Public m_BPARAM As BPARAM

			' Token: 0x04000007 RID: 7
			Public m_CONGRVPARAM As CONGRVPARAM

			' Token: 0x04000008 RID: 8
			Public m_ConnectionSettings As ConnectionSettings

			' Token: 0x04000009 RID: 9
			Public m_CRPARAM As CRPARAM

			' Token: 0x0400000A RID: 10
			Public m_Form1 As Form1

			' Token: 0x0400000B RID: 11
			Public m_GRVPARAM As GRVPARAM

			' Token: 0x0400000C RID: 12
			Public m_IObox As IObox

			' Token: 0x0400000D RID: 13
			Public m_KEYPARAM As KEYPARAM

			' Token: 0x0400000E RID: 14
			Public m_Miscsettings As Miscsettings

			' Token: 0x0400000F RID: 15
			Public m_MPosıtıonupload As MPosıtıonupload

			' Token: 0x04000010 RID: 16
			Public m_PLANPARAM As PLANPARAM

			' Token: 0x04000011 RID: 17
			Public m_POCKETPARAM As POCKETPARAM

			' Token: 0x04000012 RID: 18
			Public m_Posıtıonupload As Posıtıonupload

			' Token: 0x04000013 RID: 19
			Public m_PPARAM As PPARAM

			' Token: 0x04000014 RID: 20
			Public m_Processsetup As Processsetup

			' Token: 0x04000015 RID: 21
			Public m_SPARAM As SPARAM

			' Token: 0x04000016 RID: 22
			Public m_THREEDCLADPARAM As THREEDCLADPARAM

			' Token: 0x04000017 RID: 23
			Public m_VPARAM As VPARAM

			' Token: 0x04000018 RID: 24
			<ThreadStatic()>
			Private Shared m_FormBeingCreated As Hashtable
		End Class

		' Token: 0x02000006 RID: 6
		<EditorBrowsable(EditorBrowsableState.Never)>
		<MyGroupCollection("System.Web.Services.Protocols.SoapHttpClientProtocol", "Create__Instance__", "Dispose__Instance__", "")>
		Friend NotInheritable Class MyWebServices
			' Token: 0x06000036 RID: 54 RVA: 0x000172A4 File Offset: 0x000156A4
			<DebuggerHidden()>
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public Overrides Function Equals(o As Object) As Boolean
				Return MyBase.Equals(RuntimeHelpers.GetObjectValue(o))
			End Function

			' Token: 0x06000037 RID: 55 RVA: 0x000172C0 File Offset: 0x000156C0
			<DebuggerHidden()>
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public Overrides Function GetHashCode() As Integer
				Return MyBase.GetHashCode()
			End Function

			' Token: 0x06000038 RID: 56 RVA: 0x000172D4 File Offset: 0x000156D4
			<EditorBrowsable(EditorBrowsableState.Never)>
			<DebuggerHidden()>
			Friend Overloads Function [GetType]() As Type
				Return GetType(MyProject.MyWebServices)
			End Function

			' Token: 0x06000039 RID: 57 RVA: 0x000172EC File Offset: 0x000156EC
			<DebuggerHidden()>
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public Overrides Function ToString() As String
				Return MyBase.ToString()
			End Function

			' Token: 0x0600003A RID: 58 RVA: 0x00017300 File Offset: 0x00015700
			<DebuggerHidden()>
			Private Shared Function Create__Instance__(Of T As New)(instance As T) As T
				If instance Is Nothing Then
					Return Activator.CreateInstance(Of T)()
				End If
				Return instance
			End Function

			' Token: 0x0600003B RID: 59 RVA: 0x0001731C File Offset: 0x0001571C
			<DebuggerHidden()>
			Private Sub Dispose__Instance__(Of T)(ByRef instance As T)
				instance = Nothing
			End Sub

			' Token: 0x0600003C RID: 60 RVA: 0x00017338 File Offset: 0x00015738
			<EditorBrowsable(EditorBrowsableState.Never)>
			<DebuggerHidden()>
			Public Sub New()
			End Sub
		End Class

		' Token: 0x02000007 RID: 7
		<ComVisible(False)>
		<EditorBrowsable(EditorBrowsableState.Never)>
		Friend NotInheritable Class ThreadSafeObjectProvider(Of T As New)
			' Token: 0x17000018 RID: 24
			' (get) Token: 0x0600003D RID: 61 RVA: 0x00017340 File Offset: 0x00015740
			Friend ReadOnly Property GetInstance As T
				<DebuggerHidden()>
				Get
					If MyProject.ThreadSafeObjectProvider(Of T).m_ThreadStaticValue Is Nothing Then
						MyProject.ThreadSafeObjectProvider(Of T).m_ThreadStaticValue = Activator.CreateInstance(Of T)()
					End If
					Return MyProject.ThreadSafeObjectProvider(Of T).m_ThreadStaticValue
				End Get
			End Property

			' Token: 0x0600003E RID: 62 RVA: 0x00017368 File Offset: 0x00015768
			<EditorBrowsable(EditorBrowsableState.Never)>
			<DebuggerHidden()>
			Public Sub New()
			End Sub

			' Token: 0x04000019 RID: 25
			<ThreadStatic()>
			<CompilerGenerated()>
			Private Shared m_ThreadStaticValue As T
		End Class
	End Module
End Namespace
