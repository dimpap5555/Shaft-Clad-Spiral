Imports System
Imports System.CodeDom.Compiler
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic.ApplicationServices

Namespace WindowsApplication1.My
	' Token: 0x02000002 RID: 2
	<EditorBrowsable(EditorBrowsableState.Never)>
	<GeneratedCode("MyTemplate", "8.0.0.0")>
	Friend Class MyApplication
		Inherits WindowsFormsApplicationBase

		' Token: 0x06000001 RID: 1 RVA: 0x00016A8C File Offset: 0x00014E8C
		<EditorBrowsable(EditorBrowsableState.Advanced)>
		<DebuggerHidden()>
		<STAThread()>
		<MethodImpl(MethodImplOptions.NoInlining Or MethodImplOptions.NoOptimization)>
		Friend Shared Sub Main(Args As String())
			Try
				Global.System.Windows.Forms.Application.SetCompatibleTextRenderingDefault(WindowsFormsApplicationBase.UseCompatibleTextRendering)
			Finally
			End Try
			MyProject.Application.Run(Args)
		End Sub

		' Token: 0x06000002 RID: 2 RVA: 0x00016AC4 File Offset: 0x00014EC4
		<DebuggerStepThrough()>
		Public Sub New()
			MyBase.New(AuthenticationMode.Windows)
			Me.IsSingleInstance = False
			Me.EnableVisualStyles = True
			Me.SaveMySettingsOnExit = True
			Me.ShutdownStyle = ShutdownMode.AfterMainFormCloses
		End Sub

		' Token: 0x06000003 RID: 3 RVA: 0x00016AEC File Offset: 0x00014EEC
		<DebuggerStepThrough()>
		Protected Overrides Sub OnCreateMainForm()
			Me.MainForm = MyProject.Forms.Form1
		End Sub
	End Class
End Namespace
