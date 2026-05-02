Imports System
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

Namespace WindowsApplication1
	' Token: 0x0200001E RID: 30
	Friend Module processparam
		' Token: 0x060005B1 RID: 1457 RVA: 0x00016618 File Offset: 0x00014A18
		<MethodImpl(MethodImplOptions.NoInlining Or MethodImplOptions.NoOptimization)>
		Public Sub paramset(laserpowerini As Integer, powderfeed As Double, powderjar As Integer, hWnd As Integer)
			Dim mydatetime As DateTime = DateAndTime.Now
			Dim power As Double = 0.0025 * CDbl(laserpowerini) * (1.0 + CDbl(Positioncal.IniOverPower) / 100.0) + -1.1111
			powderfeed *= 1.0 - CDbl(Positioncal.IniPowderRed) / 100.0
			Dim headertxt As String = "/JOB" & vbCrLf & "//NAME HOSTMAST" & vbCrLf & "//POS" & vbCrLf & "///NPOS 0,0,0,0,0,0" & vbCrLf & "//INST" & vbCrLf & "///DATE " + mydatetime.ToString("yyyy/MM/dd HH:mm") + vbCrLf & "///COMM MASTER TASK" & vbCrLf & "///ATTR RW,CJ" & vbCrLf & "///LVARS 0,0,0,0,0,0,0,0"
			Dim feed As Double = 0.1 * powderfeed
			Dim beamdia As Double = 2.3596 * Positioncal.CladWidth + -4.4599
			Dim mainprogtxt As String = String.Concat(New String() {"NOP" & vbCrLf & "DOUT OG#(1) 0" & vbCrLf & "AOUT AO#(1) ", power.ToString("#0.00"), vbCrLf & "AOUT AO#(2) ", (feed * 10.0).ToString("#0.00"), vbCrLf & "AOUT AO#(3) ", beamdia.ToString("#0.00"), vbCrLf & "PSTART JOB:HOSTMOV SUB1" & vbCrLf & "PWAIT SUB1" & vbCrLf & "AOUT AO#(1) 0" & vbCrLf & "AOUT AO#(2) 0" & vbCrLf & "AOUT AO#(3) 0" & vbCrLf & "END"})
			Try
				FileSystem.FileOpen(1, Positioncal.BasePath + "hostmast.jbi", OpenMode.Output, OpenAccess.[Default], OpenShare.[Default], -1)
				FileSystem.PrintLine(1, New Object() {headertxt})
				FileSystem.PrintLine(1, New Object() {mainprogtxt})
				FileSystem.FileClose(New Integer() {1})
			Catch ex As Exception
				MessageBox.Show("Cannot create file on disk. Original error: " + ex.Message)
			End Try
		End Sub
	End Module
End Namespace
