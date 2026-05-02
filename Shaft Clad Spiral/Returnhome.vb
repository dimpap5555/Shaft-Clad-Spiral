Imports System
Imports System.Runtime.CompilerServices
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

Namespace WindowsApplication1
	' Token: 0x02000020 RID: 32
	Friend Module Returnhome
		' Token: 0x060005E5 RID: 1509 RVA: 0x000167C0 File Offset: 0x00014BC0
		<MethodImpl(MethodImplOptions.NoInlining Or MethodImplOptions.NoOptimization)>
		Public Sub Rethome(CntrlGrp As Short)
			Dim mydatetime As DateTime = DateAndTime.Now
			Dim headertxt As String = "/JOB" & vbCrLf & "//NAME RETHOME" & vbCrLf & "//POS" & vbCrLf & "///NPOS 1,0,"
			If CntrlGrp = 0S Then
				headertxt += "1,1,0,1" & vbCrLf
			Else
				headertxt += "0,1,0,1" & vbCrLf
			End If
			headertxt += "///TOOL 0" & vbCrLf & "///POSTYPE PULSE" & vbCrLf & "///PULSE" & vbCrLf & "C00000=-1,-114489,-86932,1,-5369,-1" & vbCrLf
			If CntrlGrp = 0S Then
				headertxt += "EC00000=0,0" & vbCrLf
			End If
			headertxt += "///POSTYPE BASE" & vbCrLf & "///RECTAN" & vbCrLf & "///RCONF 1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0" & vbCrLf & "P00000=1057.372,-422.436,620.000,-179.9371,0.0009,-0.0221" & vbCrLf
			If CntrlGrp = 0S Then
				headertxt += "///POSTYPE ANGLE" & vbCrLf & "///ANGLE" & vbCrLf & "EX00000=20.7801,5.3331" & vbCrLf
			End If
			headertxt = headertxt + "//INST" & vbCrLf & "///DATE " + mydatetime.ToString("yyyy/MM/dd HH:mm") + vbCrLf & "///ATTR SC,RW" & vbCrLf & "///GROUP1 RB1"
			If CntrlGrp = 0S Then
				headertxt += vbCrLf & "///GROUP2 ST1"
			End If
			Dim mainprogtxt As String = "NOP" & vbCrLf & "DOUT OG#(1) 0" & vbCrLf & "DOUT OG#(2) 0" & vbCrLf & "ARCOF" & vbCrLf & "CLEAR STACK" & vbCrLf & "SFTOF" & vbCrLf
			If CntrlGrp = 0S Then
				mainprogtxt += "CALL JOB:STRESET" & vbCrLf
			End If
			mainprogtxt = String.Concat(New String() {mainprogtxt, "GETS PX000 $PX000" & vbCrLf & "CNVRT PX000 PX000 BF" & vbCrLf & "GETE D000 P000 (3)" & vbCrLf & "ADD D000 300000" & vbCrLf & "JUMP *LABEL IF D000<", Positioncal.MaxZRobotPos.ToString("#"), vbCrLf & "SET D000 ", Positioncal.MaxZRobotPos.ToString("#"), vbCrLf & "*LABEL" & vbCrLf & "SETE P000 (3) D000" & vbCrLf & "MOVL P000 V=100.0"})
			If CntrlGrp = 0S Then
				mainprogtxt += " +MOVJ EX000" & vbCrLf
			Else
				mainprogtxt += vbCrLf
			End If
			mainprogtxt += "MOVJ C00000 VJ=8.00"
			If CntrlGrp = 0S Then
				mainprogtxt += " +MOVJ EC00000 VJ=100.00" & vbCrLf
			Else
				mainprogtxt += vbCrLf
			End If
			mainprogtxt += "EI LEVEL= 1" & vbCrLf & "END"
			Try
				FileSystem.FileOpen(1, Positioncal.BasePath + "RETHOME.JBI", OpenMode.Output, OpenAccess.[Default], OpenShare.[Default], -1)
				FileSystem.PrintLine(1, New Object() {headertxt})
				FileSystem.PrintLine(1, New Object() {mainprogtxt})
				FileSystem.FileClose(New Integer() {1})
			Catch ex As Exception
				Interaction.MsgBox("Job saving has failed due to the following reason: " + ex.Message, MsgBoxStyle.Exclamation, Nothing)
			End Try
		End Sub
	End Module
End Namespace
