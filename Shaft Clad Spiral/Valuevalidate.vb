Imports System
Imports System.Diagnostics
Imports System.Runtime.CompilerServices
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

Namespace WindowsApplication1
	' Token: 0x02000022 RID: 34
	Public Class Valuevalidate
		' Token: 0x06000639 RID: 1593 RVA: 0x000169AC File Offset: 0x00014DAC
		Public Sub New()
		End Sub

		' Token: 0x0600063A RID: 1594 RVA: 0x000169B4 File Offset: 0x00014DB4
		Public Sub New(LowBound As Double, HiBound As Double, Value As Double, Sender As Object)
			Me._LowBound = LowBound
			Me._HiBound = HiBound
			Me._Value = Value
			Me._Sender = RuntimeHelpers.GetObjectValue(Sender)
		End Sub

		' Token: 0x170001FC RID: 508
		' (set) Token: 0x0600063B RID: 1595 RVA: 0x000169E0 File Offset: 0x00014DE0
		Public WriteOnly Property Value As Double
			Set(value As Double)
				If value < Me._LowBound Or value > Me._HiBound Then
					Interaction.MsgBox("Valid values range between " + Conversions.ToString(Me._LowBound) + " and " + Conversions.ToString(Me._HiBound), MsgBoxStyle.OkOnly, Nothing)
				Else
					Me._LowBound = value
					Dim dataChangedEvent As Valuevalidate.DataChangedEventHandler = Me.DataChangedEvent
					If dataChangedEvent IsNot Nothing Then
						dataChangedEvent(RuntimeHelpers.GetObjectValue(Me._Sender))
					End If
				End If
			End Set
		End Property

		' Token: 0x14000001 RID: 1
		' (add) Token: 0x0600063C RID: 1596 RVA: 0x00016A54 File Offset: 0x00014E54
		' (remove) Token: 0x0600063D RID: 1597 RVA: 0x00016A70 File Offset: 0x00014E70
		<DebuggerNonUserCode()>
		Public Event DataChanged As Valuevalidate.DataChangedEventHandler

		' Token: 0x04000290 RID: 656
		Private _LowBound As Double

		' Token: 0x04000291 RID: 657
		Private _HiBound As Double

		' Token: 0x04000292 RID: 658
		Private _Value As Double

		' Token: 0x04000293 RID: 659
		Private _Sender As Object

		' Token: 0x04000294 RID: 660
		Private _e As EventArgs

		' Token: 0x02000023 RID: 35
		' (Invoke) Token: 0x06000641 RID: 1601
		Public Delegate Sub DataChangedEventHandler(Sender As Object)
	End Class
End Namespace
