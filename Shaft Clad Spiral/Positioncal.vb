Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.Data
Imports System.IO
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

Namespace WindowsApplication1
	' Token: 0x0200001B RID: 27
	Friend Module Positioncal
		' Token: 0x06000562 RID: 1378 RVA: 0x00003120 File Offset: 0x00001520
		<MethodImpl(MethodImplOptions.NoInlining Or MethodImplOptions.NoOptimization)>
		Public Sub ThreeDclad(ByRef width As Double, ByRef pitch As Double, processspeed As Double, ByRef tooloffset As Double, ByRef stationposition As Integer, ByRef movdir As Short, ByRef arrdir As Short, ByRef claddingdir As Short, ByRef meanderamp As Double, ByRef meanderpitch As Double, ByRef meanderflg As Short, ByRef copies As Short, ByRef arrayrecptc As Double, ByRef arrayangptc As Double, hwnd As Integer)
			Dim positions As Double(,) = New Double(6, 11) {}
			Dim expositions As Double(,) = New Double(6, 11) {}
			Dim temppos As Double() = New Double(Positioncal.Position.GetLength(1) - 1 + 1 - 1) {}
			Dim array As Double() = New Double() {0.0, 0.0, 0.0}
			array = New Double() {0.0, 0.0, 0.0}
			Dim currpos As Double() = New Double(2) {}
			Dim synchro As String = ""
			Dim interp As String = ""
			Dim mydatetime As DateTime = DateAndTime.Now
			If meanderflg = 0S Then
				meanderamp = 0.0
			End If
			Dim stationangle As Double
			Select Case stationposition
				Case 1
					stationangle = 0.0
				Case 2
					stationangle = 0.52359877559829882
				Case 3
					stationangle = 0.78539816339744828
				Case 4
					stationangle = 1.0471975511965976
				Case 5
					stationangle = 1.5707963267948966
			End Select
			Dim passes As Double
			Dim effectivepitch As Double
			If Positioncal.ConstBeamFlg = 1S Then
				passes = (Positioncal.Width1 - Positioncal.Position(9, 0) - 2.0 * meanderamp) / pitch
				If passes <= 0.0 Then
					passes = 1.0
					effectivepitch = 0.0
				ElseIf passes < 1.0 Then
					passes = 2.0
					effectivepitch = Positioncal.Width1 - Positioncal.CladWidth / 2.0
				Else
					passes = Math.Ceiling(passes)
					effectivepitch = (Positioncal.Width1 - Positioncal.Position(9, 0) - 2.0 * meanderamp) / passes
				End If
				If (effectivepitch - pitch) / pitch > 0.1 Then
					passes += 1.0
					effectivepitch = (Positioncal.Width1 - Positioncal.Position(9, 0) - 2.0 * meanderamp) / passes
				End If
			Else
				passes = 1.0
				effectivepitch = 0.0
			End If
			passes += 1.0
			Dim Totalpoints As Integer
			Dim xdirmovflg As Short
			Dim ydirmovflg As Short
			Dim zdirmovflg As Short
			Dim spinddirmovflg As Short
			Dim xdirarrflg As Short
			Dim ydirarrflg As Short
			Dim zdirarrflg As Short
			Dim spinddirarrflg As Short
			Totalpoints = CInt(Math.Round(CDbl(Positioncal.PointNo) * passes * CDbl(copies)))
			positions = CType(Utils.CopyArray(CType(positions, Array), New Double(6, Totalpoints + 3 + 1 - 1) {}), Double(,))
			expositions = CType(Utils.CopyArray(CType(expositions, Array), New Double(6, Totalpoints + 3 + 1 - 1) {}), Double(,))
			Select Case movdir
				Case 0S
					xdirmovflg = 1S
					ydirmovflg = 0S
					zdirmovflg = 0S
					spinddirmovflg = 0S
				Case 1S
					xdirmovflg = 0S
					ydirmovflg = 1S
					zdirmovflg = 0S
					spinddirmovflg = 0S
				Case 2S
					xdirmovflg = 0S
					ydirmovflg = 0S
					zdirmovflg = 1S
					spinddirmovflg = 0S
				Case 3S
					xdirmovflg = 0S
					ydirmovflg = 0S
					zdirmovflg = 0S
					spinddirmovflg = 1S
			End Select
			Select Case arrdir
				Case 0S
					xdirarrflg = 1S
					ydirarrflg = 0S
					zdirarrflg = 0S
					spinddirarrflg = 0S
					arrayangptc = 0.0
				Case 1S
					xdirarrflg = 0S
					ydirarrflg = 1S
					zdirarrflg = 0S
					spinddirarrflg = 0S
					arrayangptc = 0.0
				Case 2S
					xdirarrflg = 0S
					ydirarrflg = 0S
					zdirarrflg = 1S
					spinddirarrflg = 0S
					arrayangptc = 0.0
				Case 3S
					xdirarrflg = 0S
					ydirarrflg = 0S
					zdirarrflg = 0S
					spinddirarrflg = 1S
					arrayrecptc = 0.0
			End Select
			Dim Rx As Double
			If Positioncal.Position(3, 0) > 0.0 Then
				Rx = (Positioncal.Position(3, 0) - 90.0) * 3.1415926535897931 / 180.0
			Else
				Rx = (Positioncal.Position(3, 0) + 180.0 + 90.0) * 3.1415926535897931 / 180.0
			End If
			Dim Ry As Double = Positioncal.Position(4, 0) * 3.1415926535897931 / 180.0
			Dim Rz As Double = Positioncal.Position(5, 0) * 3.1415926535897931 / 180.0
			positions(0, 0) = Positioncal.Position(0, 0) + Positioncal.IniXAxisOffset
			positions(1, 0) = Positioncal.Position(1, 0) + Positioncal.IniYAxisOffset
			positions(2, 0) = Positioncal.Position(2, 0) + Positioncal.IniZAxisOffset
			positions(3, 0) = Positioncal.Position(3, 0)
			positions(4, 0) = Positioncal.Position(4, 0)
			positions(5, 0) = Positioncal.Position(5, 0)
			expositions(0, 0) = Positioncal.Position(6, 0) / 360.0 * 331776.0
			expositions(1, 0) = Positioncal.Position(7, 0) / 360.0 * 331776.0
			positions(0, 1) = Positioncal.Position(0, 0) + Positioncal.IniXAxisOffset + tooloffset * Math.Sin(Ry)
			positions(1, 1) = Positioncal.Position(1, 0) + tooloffset * Math.Cos(Rx)
			positions(2, 1) = Positioncal.Position(2, 0) + tooloffset * Math.Sin(Rx) * Math.Cos(Ry)
			positions(3, 1) = Positioncal.Position(3, 0)
			positions(4, 1) = Positioncal.Position(4, 0)
			positions(5, 1) = Positioncal.Position(5, 0)
			expositions(0, 1) = Positioncal.Position(6, 0) / 360.0 * 331776.0
			expositions(1, 1) = Positioncal.Position(7, 0) / 360.0 * 331776.0
			positions(0, 2) = Positioncal.Position(0, 0) + Positioncal.IniXAxisOffset + tooloffset * Math.Sin(Ry)
			positions(1, 2) = Positioncal.Position(1, 0) + tooloffset * Math.Cos(Rx)
			positions(2, 2) = Positioncal.Position(2, 0) + tooloffset * Math.Sin(Rx) * Math.Cos(Ry)
			positions(3, 2) = Positioncal.Position(3, 0)
			positions(4, 2) = Positioncal.Position(4, 0)
			positions(5, 2) = Positioncal.Position(5, 0)
			expositions(0, 2) = Positioncal.Position(6, 0) / 360.0 * 331776.0
			expositions(1, 2) = Positioncal.Position(7, 0) / 360.0 * 331776.0
			Dim num As Integer = 1
			Dim num2 As Integer = CInt(copies)
			For i As Integer = num To num2
				Dim num3 As Integer = 1
				Dim num4 As Integer = CInt(Math.Round(passes))
				For passIndex As Integer = num3 To num4
					Dim num5 As Integer = 1
					Dim pointNo As Integer = Positioncal.PointNo
					For k As Integer = num5 To pointNo

						' The following expression was wrapped in a checked-expression
						If Positioncal.Position(3, k - 1) > 0.0 Then
							' The following expression was wrapped in a checked-expression
							Rx = (Positioncal.Position(3, k - 1) - 90.0) * 3.1415926535897931 / 180.0
						Else
							' The following expression was wrapped in a checked-expression
							Rx = (Positioncal.Position(3, k - 1) + 180.0 + 90.0) * 3.1415926535897931 / 180.0
						End If
						Ry = Positioncal.Position(4, k - 1) * 3.1415926535897931 / 180.0
						Rz = Positioncal.Position(5, k - 1) * 3.1415926535897931 / 180.0

						temppos(0) = Positioncal.Position(0, k - 1)
						temppos(1) = Positioncal.Position(1, k - 1)
						temppos(2) = Positioncal.Position(2, k - 1)
						positions(0, CInt(Math.Round(CDbl((k + (passIndex - 1) * Positioncal.PointNo)) + CDbl((i - 1)) * passes * CDbl(Positioncal.PointNo) + 2.0))) = Positioncal.Position(0, k - 1) + CDbl((CInt(xdirmovflg) * (passIndex - 1) * CInt(Positioncal.Overlaydir))) * effectivepitch + CDbl((xdirarrflg * Positioncal.Arraydir)) * arrayrecptc * CDbl((i - 1)) + tooloffset * Math.Sin(Ry)
						positions(1, CInt(Math.Round(CDbl((k + (passIndex - 1) * Positioncal.PointNo)) + CDbl((i - 1)) * passes * CDbl(Positioncal.PointNo) + 2.0))) = Positioncal.Position(1, k - 1) + CDbl((CInt(ydirmovflg) * (passIndex - 1) * CInt(Positioncal.Overlaydir))) * effectivepitch + CDbl((ydirarrflg * Positioncal.Arraydir)) * arrayrecptc * CDbl((i - 1)) - tooloffset * Math.Cos(Rx)
						positions(2, CInt(Math.Round(CDbl((k + (passIndex - 1) * Positioncal.PointNo)) + CDbl((i - 1)) * passes * CDbl(Positioncal.PointNo) + 2.0))) = Positioncal.Position(2, k - 1) + CDbl((CInt(zdirmovflg) * (passIndex - 1) * CInt(Positioncal.Overlaydir))) * effectivepitch + CDbl((zdirarrflg * Positioncal.Arraydir)) * arrayrecptc * CDbl((i - 1)) + tooloffset * Math.Sin(Rx) * Math.Cos(Ry)
						positions(3, CInt(Math.Round(CDbl((k + (passIndex - 1) * Positioncal.PointNo)) + CDbl((i - 1)) * passes * CDbl(Positioncal.PointNo) + 2.0))) = Positioncal.Position(3, k - 1)
						positions(4, CInt(Math.Round(CDbl((k + (passIndex - 1) * Positioncal.PointNo)) + CDbl((i - 1)) * passes * CDbl(Positioncal.PointNo) + 2.0))) = Positioncal.Position(4, k - 1)
						positions(5, CInt(Math.Round(CDbl((k + (passIndex - 1) * Positioncal.PointNo)) + CDbl((i - 1)) * passes * CDbl(Positioncal.PointNo) + 2.0))) = Positioncal.Position(5, k - 1)
						expositions(0, CInt(Math.Round(CDbl((k + (passIndex - 1) * Positioncal.PointNo)) + CDbl((i - 1)) * passes * CDbl(Positioncal.PointNo) + 2.0))) = Positioncal.Position(6, k - 1) / 360.0 * 331776.0
						Dim array2 As Double(,) = expositions
						Dim num6 As Integer = 1
						Dim num7 As Integer = CInt(Math.Round(CDbl((k + (passIndex - 1) * Positioncal.PointNo)) + CDbl((i - 1)) * passes * CDbl(Positioncal.PointNo) + 2.0))
						Dim num8 As Double = Positioncal.Position(7, k - 1)

						' The following expression was wrapped in a checked-expression
						Dim num9 As Double = CDbl((CInt(spinddirmovflg) * (passIndex - 1) * CInt(Positioncal.Overlaydir))) * effectivepitch
						Dim num10Local As Double = Positioncal.Position(6, k - 1) * 3.1415926535897931 / 180.0
						array2(num6, num7) = (num8 + num9 / Positioncal.FindDist(temppos, num10Local, stationangle) * 180.0 / 3.1415926535897931 + CDbl((CInt(spinddirarrflg) * (i - 1) * CInt(Positioncal.Arraydir))) * arrayangptc) / 360.0 * 331776.0

					Next
				Next
			Next
			positions(0, Totalpoints + 3) = CDbl(Positioncal.HomePos(0))
			positions(1, Totalpoints + 3) = CDbl(Positioncal.HomePos(1))
			positions(2, Totalpoints + 3) = CDbl(Positioncal.HomePos(2))
			positions(3, Totalpoints + 3) = CDbl(Positioncal.HomePos(3))
			positions(4, Totalpoints + 3) = CDbl(Positioncal.HomePos(4))
			positions(5, Totalpoints + 3) = CDbl(Positioncal.HomePos(5))
			expositions(0, Totalpoints + 3) = 0.0
			expositions(1, Totalpoints + 3) = 0.0
			Dim meanderfreq As Double = processspeed / (4.0 * meanderamp)
			Dim processspeedloc As Double = processspeed
			Dim power As Double = 0.0025 * CDbl(Positioncal.LaserPowerIni) + -1.1111
			Positioncal.TotalSteps = Totalpoints + 5
			Select Case Positioncal.Movementtype
				Case 0S
					synchro = "S"
					interp = "C"
				Case 1S
					synchro = "S"
					interp = "L"
				Case 2S
					synchro = ""
					interp = "C"
				Case 3S
					synchro = ""
					interp = "L"
				Case 4S
					synchro = ""
					interp = "C"
				Case 5S
					synchro = ""
					interp = "L"
			End Select
			Dim headertxt As String = "/JOB" & vbCrLf & "//NAME HOSTMOV" & vbCrLf & "//POS" & vbCrLf & "///NPOS " + Conversions.ToString(Totalpoints + 4) + ",0,"
			If Positioncal.Movementtype < 4S Then
				headertxt = headertxt + Conversions.ToString(Totalpoints + 4) + ",2,0,2" & vbCrLf
			Else
				headertxt += "0,2,0,2" & vbCrLf
			End If
			headertxt = String.Concat(New String() {headertxt, "///USER ", stationposition.ToString("#"), vbCrLf & "///TOOL ", Positioncal.Toolno.ToString("#0"), vbCrLf & "///POSTYPE USER ", stationposition.ToString("#"), vbCrLf & "///RECTAN" & vbCrLf & "///RCONF 1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0" & vbCrLf})
			Dim num11 As Integer = 0
			Dim num12 As Integer = Totalpoints + 2
			Dim j As Integer
			For ind As Integer = num11 To num12
				headertxt = headertxt + "C" + ind.ToString("0000#=")
				j = 0
				Do
					headertxt = headertxt + positions(j, ind).ToString("#0.000;-#0.000;0.000") + ","
					j += 1
				Loop While j <= 2
				j = 3
				Do
					headertxt = headertxt + positions(j, ind).ToString("#0.00;-#0.00;0.00") + ","
					j += 1
				Loop While j <= 4
				headertxt = headertxt + positions(5, ind).ToString("#0.00;-#0.00;0.00") + vbCrLf
			Next
			headertxt += "///POSTYPE PULSE" & vbCrLf & "///PULSE" & vbCrLf
			headertxt = headertxt + "C" + (Totalpoints + 3).ToString("0000#=")
			j = 0
			Do
				headertxt = headertxt + positions(j, Totalpoints + 3).ToString("#;-#;0") + ","
				j += 1
			Loop While j <= 4
			headertxt = headertxt + positions(5, Totalpoints + 3).ToString("#;-#;0") + vbCrLf
			If Positioncal.Movementtype < 4S Then
				Dim num13 As Integer = 0
				Dim num14 As Integer = Totalpoints + 3
				For ind As Integer = num13 To num14
					headertxt = String.Concat(New String() {headertxt, "EC", ind.ToString("0000#="), expositions(0, ind).ToString("#;-#;0"), ",", expositions(1, ind).ToString("#0;-#0;0"), vbCrLf})
				Next
			End If
			headertxt = String.Concat(New String() {headertxt, "///POSTYPE BASE" & vbCrLf & "///RECTAN" & vbCrLf & "P0000=0.000,0.000,0.000,0.00,0.00,0.00" & vbCrLf & "P0001=0.000,0.000,0.000,0.00,0.00,0.00" & vbCrLf & "///POSTYPE PULSE" & vbCrLf & "///PULSE" & vbCrLf & "EX0000=0,0" & vbCrLf & "EX0001=0,0" & vbCrLf & "//INST" & vbCrLf & "///DATE ", mydatetime.ToString("yyyy/MM/dd HH:mm"), vbCrLf & "///COMM SUB TASK TO HOSTMAST" & vbCrLf & "///ATTR SC,RW,RJ" & vbCrLf & "////FRAME USER ", stationposition.ToString("#"), vbCrLf & "///GROUP1 RB1" & vbCrLf})
			If Positioncal.Movementtype < 4S Then
				headertxt += "///GROUP2 ST1" & vbCrLf
			End If
			headertxt += "///LVARS 0,0,0,0,0,0,0,0"
			Dim mainprogtxt As String = "NOP" & vbCrLf & "EI LEVEL= 1" & vbCrLf
			If meanderflg = 1S Then
				mainprogtxt += "SETFILE WEV#(1) (8) 0" & vbCrLf & "SETFILE WEV#(1) (9) 0" & vbCrLf
			End If
			If Positioncal.Movementtype < 4S Then
				mainprogtxt += "CALL JOB:STRESET" & vbCrLf
			End If
			Dim array3 As String() = New String(9) {}
			array3(0) = mainprogtxt
			array3(1) = "GETS PX000 $PX000" & vbCrLf & "CNVRT PX000 PX000 RF" & vbCrLf & "GETE D000 P000 (3)" & vbCrLf & "ADD D000 "
			Dim array4 As String() = array3
			Dim num15 As Integer = 2
			Dim num10 As Double = Positioncal.IniZAxisOffset * 1000.0
			array4(num15) = num10.ToString("#0")
			array3(3) = vbCrLf & "JUMP *LABEL1 IF D000<="
			array3(4) = Positioncal.MaxZRobotPos.ToString("#")
			array3(5) = vbCrLf & "SET D000 "
			array3(6) = Positioncal.MaxZRobotPos.ToString("#")
			array3(7) = vbCrLf & "*LABEL1" & vbCrLf & "SETE P000 (3) D000" & vbCrLf & "MOVL P000 V="
			array3(8) = Positioncal.IdleSpeed.ToString("#0.0")
			array3(9) = " PL=0"
			mainprogtxt = String.Concat(array3)
			If Positioncal.Movementtype < 4S Then
				mainprogtxt += " +MOVJ EX000 VJ=100.00" & vbCrLf
			Else
				mainprogtxt += vbCrLf
			End If
			array3 = New String(11) {}
			array3(0) = mainprogtxt
			array3(1) = "GETS PX000 $PX000" & vbCrLf & "GETE D000 P000 (4)" & vbCrLf & "CALL JOB:ARMCOR IF D000>="
			array3(2) = 184115.0.ToString("#")
			array3(3) = vbCrLf & "CALL JOB:ARMCOR IF D000<=-"
			Dim array5 As String() = array3
			Dim num16 As Integer = 4
			num10 = 184115.0
			array5(num16) = num10.ToString("#")
			array3(5) = vbCrLf & "GETPOS PX000 STEP#(2)" & vbCrLf & "CNVRT PX000 PX000 RF" & vbCrLf & "GETE D000 P000 (3)" & vbCrLf & "JUMP *LABEL2 IF D000<"
			array3(6) = Positioncal.MaxZRobotPos.ToString("#")
			array3(7) = vbCrLf & "SUB D000 "
			array3(8) = Positioncal.MaxZRobotPos.ToString("#")
			array3(9) = vbCrLf & "MUL D000 -1" & vbCrLf & "SETE P000 (1) 0" & vbCrLf & "SETE P000 (2) 0" & vbCrLf & "SETE P000 (3) D000" & vbCrLf & "SETE P000 (4) 0" & vbCrLf & "SETE P000 (5) 0" & vbCrLf & "SETE P000 (6) 0" & vbCrLf & "SFTON P000 RF" & vbCrLf & "*LABEL2" & vbCrLf & "MOVL C00000 V="
			array3(10) = Positioncal.IdleSpeed.ToString("#0.0")
			array3(11) = " PL=0 NWAIT"
			mainprogtxt = String.Concat(array3)
			If Positioncal.Movementtype < 4S Then
				mainprogtxt += " +MOVJ EC00000 VJ=100.00" & vbCrLf
			Else
				mainprogtxt += vbCrLf
			End If
			mainprogtxt += "DOUT OT#(1) ON" & vbCrLf & "DOUT OT#(8) ON" & vbCrLf & "JUMP *PILOTON IF IN#(2)=ON" & vbCrLf & "WAIT IN#(6)=ON T=5.00" & vbCrLf & "JUMP *END IF IN#(6)=OFF" & vbCrLf
			If Positioncal.PowderJar = 1S Then
				mainprogtxt += "DOUT OT#(4) ON" & vbCrLf & "DOUT OT#(6) ON" & vbCrLf
			Else
				mainprogtxt += "DOUT OT#(5) ON" & vbCrLf & "DOUT OT#(7) ON" & vbCrLf
			End If
			mainprogtxt = String.Concat(New String() {mainprogtxt, "TIMER T=", Positioncal.PowderSettling1.ToString("#0.00"), vbCrLf & "*PILOTON" & vbCrLf & "SFTOF" & vbCrLf & "MOVL C00001 V=", Positioncal.ApproachSpeed.ToString("#0.0"), " PL=0 DEC=20"})
			If Positioncal.Movementtype < 4S Then
				mainprogtxt += " +MOVJ EC00001 VJ=100.00" & vbCrLf
			Else
				mainprogtxt += vbCrLf
			End If
			mainprogtxt += "WAIT IN#(1)=ON T=5.00" & vbCrLf
			mainprogtxt = String.Concat(New String() {mainprogtxt, "TIMER T=", Positioncal.PowderSettling2.ToString("#0.00"), vbCrLf & "EI LEVEL= 3" & vbCrLf & "*STARTL" & vbCrLf & "DOUT OT#(2) ON" & vbCrLf & "MOVL C", 2.ToString("0000#"), " V=", Positioncal.ApproachSpeed.ToString("#0.0;-#.0;0.0"), " PL=", Positioncal.PositionLevel.ToString("#")})
			If Positioncal.Movementtype < 4S Then
				mainprogtxt = mainprogtxt + " +MOVJ EC" + 2.ToString("0000#") + vbCrLf
			Else
				mainprogtxt += vbCrLf
			End If
			Dim num17 As Integer = 1
			Dim num18 As Integer = CInt(copies)
			For i As Integer = num17 To num18
				Dim num19 As Integer = 1
				Dim num20 As Integer = CInt(Math.Round(passes))
				j = num19
				While j <= num20
					Dim num21 As Integer = 1
					Dim pointNo2 As Integer = Positioncal.PointNo
					Dim k As Integer
					k = num21
					While k <= pointNo2

						' The following expression was wrapped in a checked-expression
						power = 0.0025 * Positioncal.Position(8, k - 1) + -1.1111
						Dim feed As Double = 0.1 * Positioncal.PowderFeed
						Dim beamdia As Double
						Dim meanderamploc As Double
						If Positioncal.ConstBeamFlg <> 1S Then
							beamdia = 2.3596 * Positioncal.CladWidth + -4.4599
							If meanderflg = 1S Then
								If k > 1 Then
									processspeedloc = processspeed * meanderpitch / (4.0 * meanderamploc)
								End If
								meanderamploc = (Positioncal.Position(9, k - 1) - Positioncal.CladWidth) / 2.0
							Else
								processspeedloc = processspeed
							End If
						Else
							' The following expression was wrapped in a checked-expression
							beamdia = 2.3596 * Positioncal.Position(9, k - 1) + -4.4599
							If meanderflg = 1S Then
								meanderamploc = meanderamp
								processspeedloc = processspeed * meanderpitch / (4.0 * meanderamploc)
							Else
								processspeedloc = processspeed
							End If
						End If
						Dim meanderamptemp As Double
						If k = 1 And j = 1 And i = 1 Then
							meanderamptemp = 0.0
						End If
						meanderfreq = processspeed / (4.0 * meanderamploc)
						If k = 1 Then
							' The following expression was wrapped in a checked-expression
							' The following expression was wrapped in a checked-expression
							mainprogtxt = String.Concat(New String() {mainprogtxt, "MOV", interp, " C", (CDbl((k + (passIndex - 1) * Positioncal.PointNo)) + CDbl((i - 1)) * passes * CDbl(Positioncal.PointNo) + 2.0).ToString("0000#"), " V=", Positioncal.ApproachSpeed.ToString("#0.0;-#.0;0.0"), " PL=", Positioncal.PositionLevel.ToString("#")})
							If Positioncal.Movementtype < 4S Then
								' The following expression was wrapped in a checked-expression
								' The following expression was wrapped in a checked-expression
								mainprogtxt = mainprogtxt + " +MOVJ EC" + (CDbl((k + (passIndex - 1) * Positioncal.PointNo)) + CDbl((i - 1)) * passes * CDbl(Positioncal.PointNo) + 2.0).ToString("0000#") + vbCrLf
							Else
								mainprogtxt += vbCrLf
							End If
							mainprogtxt = String.Concat(New String() {mainprogtxt, "ARCON AC=", (feed * 100.0).ToString("#0"), " AV=", power.ToString("#0.0"), vbCrLf & "ARCSET AN3=", beamdia.ToString("#0.0"), vbCrLf})
							If meanderflg = 1S Then
								If meanderamploc <> meanderamptemp Then
									' The following expression was wrapped in a checked-expression
									' The following expression was wrapped in a unchecked-expression
									' The following expression was wrapped in a unchecked-expression
									mainprogtxt = String.Concat(New String() {mainprogtxt, "SETFILE WEV#(1) (4) ", Conversions.ToString(CInt(Math.Round(meanderfreq * 10.0))), vbCrLf & "SETFILE WEV#(1) (5) ", Conversions.ToString(CInt(Math.Round(meanderamploc * 1000.0))), vbCrLf})
								End If
								mainprogtxt = mainprogtxt + synchro + "WVON WEV#(1)" & vbCrLf
							End If
						ElseIf k > 1 And k < Positioncal.PointNo Then
							' The following expression was wrapped in a checked-expression
							' The following expression was wrapped in a checked-expression
							mainprogtxt = String.Concat(New String() {mainprogtxt, synchro, "MOV", interp, " C", (CDbl((k + (passIndex - 1) * Positioncal.PointNo)) + CDbl((i - 1)) * passes * CDbl(Positioncal.PointNo) + 2.0).ToString("0000#"), " V=", processspeedloc.ToString("#0.0;-#.0;0.0"), " PL=", Positioncal.PositionLevel.ToString("#")})
							If Positioncal.Movementtype < 4S Then
								' The following expression was wrapped in a checked-expression
								' The following expression was wrapped in a checked-expression
								mainprogtxt = mainprogtxt + " +MOVJ EC" + (CDbl((k + (passIndex - 1) * Positioncal.PointNo)) + CDbl((i - 1)) * passes * CDbl(Positioncal.PointNo) + 2.0).ToString("0000#") + vbCrLf
							Else
								mainprogtxt += vbCrLf
							End If
							If meanderflg = 1S Then
								mainprogtxt = String.Concat(New String() {mainprogtxt, "ARCSET AC=", (feed * 100.0).ToString("#0"), " AV=", power.ToString("#0.0"), " AN3=", beamdia.ToString("#0.0"), vbCrLf})
								If meanderamploc <> meanderamptemp Then
									' The following expression was wrapped in a checked-expression
									' The following expression was wrapped in a unchecked-expression
									' The following expression was wrapped in a unchecked-expression
									mainprogtxt = String.Concat(New String() {mainprogtxt, "SETFILE WEV#(1) (4) ", Conversions.ToString(CInt(Math.Round(meanderfreq * 10.0))), vbCrLf & "SETFILE WEV#(1) (5) ", Conversions.ToString(CInt(Math.Round(meanderamploc * 1000.0))), vbCrLf})
								End If
							Else
								mainprogtxt = String.Concat(New String() {mainprogtxt, "ARCSET AC=", (feed * 100.0).ToString("#0"), " AV=", power.ToString("#0.0"), " AN3=", beamdia.ToString("#0.0"), vbCrLf})
							End If
						ElseIf k = Positioncal.PointNo Then
							' The following expression was wrapped in a checked-expression
							' The following expression was wrapped in a checked-expression
							mainprogtxt = String.Concat(New String() {mainprogtxt, synchro, "MOV", interp, " C", (CDbl((k + (passIndex - 1) * Positioncal.PointNo)) + CDbl((i - 1)) * passes * CDbl(Positioncal.PointNo) + 2.0).ToString("0000#"), " V=", processspeedloc.ToString("#0.0;-#.0;0.0"), " PL=", Positioncal.PositionLevel.ToString("#")})
							If Positioncal.Movementtype < 4S Then
								' The following expression was wrapped in a checked-expression
								' The following expression was wrapped in a checked-expression
								mainprogtxt = mainprogtxt + " +MOVJ EC" + (CDbl((k + (passIndex - 1) * Positioncal.PointNo)) + CDbl((i - 1)) * passes * CDbl(Positioncal.PointNo) + 2.0).ToString("0000#") + vbCrLf
							Else
								mainprogtxt += vbCrLf
							End If
						End If
						meanderamptemp = meanderamploc

						k += 1
					End While
					mainprogtxt += "ARCOF" & vbCrLf
					If meanderflg = 1S Then
						mainprogtxt = mainprogtxt + synchro + "WVOF" & vbCrLf
					End If
					If k = Positioncal.PointNo And CDbl(j) = passes And i = CInt(copies) Then
						mainprogtxt += "DOUT OG#(1) 0" & vbCrLf & "DOUT OG#(2) 0" & vbCrLf
					End If
					mainprogtxt = String.Concat(New String() {mainprogtxt, "GETS PX000 $PX000" & vbCrLf & "CNVRT PX000 PX000 RF" & vbCrLf & "GETE D000 P000 (3)" & vbCrLf & "ADD D000 ", (Positioncal.IniZAxisOffset * 1000.0).ToString("#0"), vbCrLf & "JUMP *LABEL", (j + (i - 1) * CInt((copies + 1S)) + 2).ToString(), " IF D000<=", Positioncal.MaxZRobotPos.ToString("#"), vbCrLf & "SET D000 ", Positioncal.MaxZRobotPos.ToString("#"), vbCrLf & "*LABEL", (j + (i - 1) * CInt((copies + 1S)) + 2).ToString(), vbCrLf & "SETE P000 (3) D000" & vbCrLf & "MOVL P000 V=", Positioncal.ApproachSpeed.ToString("#0.0"), " PL=0"})
					If Positioncal.Movementtype < 4S Then
						mainprogtxt += " +MOVJ EX000 VJ=100.00" & vbCrLf
					Else
						mainprogtxt += vbCrLf
					End If
					j += 1
				End While
			Next
			mainprogtxt += "DI LEVEL= 2" & vbCrLf & "DOUT OG#(1) 0" & vbCrLf & "JUMP *END" & vbCrLf & "*QVERROR" & vbCrLf & "*END" & vbCrLf
			If Positioncal.Movementtype < 4S Then
				mainprogtxt += "CALL JOB:STRESET" & vbCrLf
			End If
			mainprogtxt = String.Concat(New String() {mainprogtxt, "GETS PX000 $PX000" & vbCrLf & "CNVRT PX000 PX000 RF" & vbCrLf & "GETE D000 P000 (1)" & vbCrLf & "ADD D000 ", (Positioncal.IniXAxisOffset * 1000.0).ToString("#"), vbCrLf & "SETE P000 (1) D000" & vbCrLf & "MOVL P000 V=", Positioncal.ApproachSpeed.ToString("#0.0"), " PL=0"})
			If Positioncal.Movementtype < 4S Then
				mainprogtxt += " +MOVJ EX000 VJ=100.00" & vbCrLf
			Else
				mainprogtxt += vbCrLf
			End If
			mainprogtxt = String.Concat(New String() {mainprogtxt, "MOVL C", (Totalpoints + 3).ToString("0000#"), " V=", Positioncal.IdleSpeed.ToString("#0.0"), " PL=0"})
			If Positioncal.Movementtype < 4S Then
				mainprogtxt = mainprogtxt + " +MOVJ EC" + (Totalpoints + 3).ToString("0000#") + " VJ=100.00" & vbCrLf
			Else
				mainprogtxt += vbCrLf
			End If
			mainprogtxt += "DI LEVEL= 2" & vbCrLf & "END"
			Try
				FileSystem.FileOpen(1, Positioncal.BasePath + "hostmov.jbi", OpenMode.Output, OpenAccess.[Default], OpenShare.[Default], -1)
				FileSystem.PrintLine(1, New Object() {headertxt})
				FileSystem.PrintLine(1, New Object() {mainprogtxt})
				FileSystem.FileClose(New Integer() {1})
				If Positioncal.Movementtype < 4S Then
					Positioncal.ControlGroup = 0S
				Else
					Positioncal.ControlGroup = 1S
				End If
			Catch ex As Exception
				Interaction.MsgBox("Job saving has failed due to the following reason: " + ex.Message, MsgBoxStyle.Exclamation, Nothing)
			End Try
		End Sub

		' Token: 0x06000563 RID: 1379 RVA: 0x00004F1C File Offset: 0x0000331C
		<MethodImpl(MethodImplOptions.NoInlining Or MethodImplOptions.NoOptimization)>
		Public Sub keyholeclad(diameter As Double, width1 As Double, distance As Double, pitch As Double, processspeed As Double, keydistance As Double, keywidth As Double, keylength As Double, keyangle As Double, postureangle As Double, coneangle As Double, inioverweld As Single, meanderamp As Double, meanderflg As Short, initialang As Double, hWnd As Integer)
			Dim robotctr As Short() = New Short(7) {}
			Dim stationctr As Short() = New Short(15) {}
			Dim positions As Double(,) = New Double(6, 6) {}
			Dim expositions As Double(,) = New Double(6, 6) {}
			Dim chordlength As Double = 2.0
			Dim cycles As Integer = -1
			Dim Ryy As Object = Positioncal.WorkYAxisTilt
			Dim Rzz As Object = Positioncal.WorkZAxisYaw
			Dim Rockangle As Object = 1
			Dim mydatetime As DateTime = DateAndTime.Now
			coneangle = coneangle * 3.1415926535897931 / 180.0
			Dim stationangle As Double
			Select Case Positioncal.StationPosition
				Case 1
					stationangle = 0.0
				Case 2
					stationangle = 0.52359877559829882
				Case 3
					stationangle = 0.78539816339744828
				Case 4
					stationangle = 1.0471975511965976
				Case 5
					stationangle = 1.5707963267948966
			End Select
			Dim rotations As Double = (width1 - Positioncal.CladWidth) / pitch
			Dim effectivepitch As Double
			If rotations <= 0.0 Then
				rotations = 0.0
				effectivepitch = 0.0
			ElseIf rotations < 1.0 Then
				rotations = 1.0
				effectivepitch = width1 - Positioncal.CladWidth
			Else
				' The following expression was wrapped in a checked-expression
				rotations = CDbl((CInt(Math.Round(rotations))))
				effectivepitch = (width1 - Positioncal.CladWidth) / rotations
			End If
			If (effectivepitch - pitch) / pitch > 0.1 Then
				rotations += 1.0
				effectivepitch = (width1 - Positioncal.CladWidth) / rotations
			End If
			Dim rotations2 As Integer
			Dim rotations3 As Integer
			Dim rotations4 As Integer
			Dim dtheta As Double
			Dim arcpoints As Integer
			rotations2 = CInt(Math.Round(Math.Floor(keydistance - Positioncal.CladWidth / effectivepitch)))
			rotations3 = 0
			If width1 = keydistance + keywidth / 2.0 + keylength Then
				' The following expression was wrapped in a unchecked-expression
				' The following expression was wrapped in a checked-expression
				While CDbl((rotations3 + rotations2)) * effectivepitch <= keydistance + keywidth / 2.0 + keylength
					rotations3 += 1
				End While
			Else
				' The following expression was wrapped in a unchecked-expression
				' The following expression was wrapped in a checked-expression
				While CDbl((rotations3 + rotations2)) * effectivepitch <= keydistance + keywidth + keylength
					rotations3 += 1
				End While
			End If
			rotations3 -= 1
			rotations4 = CInt(Math.Round(rotations - CDbl(rotations2) - CDbl(rotations3)))
			If rotations4 < 0 Then
				rotations4 = 0
			End If
			dtheta = 2.0 * Math.Asin(chordlength / (keywidth + Positioncal.CladWidth))
			arcpoints = CInt(Math.Round(3.1415926535897931 / dtheta))
			dtheta = 3.1415926535897931 / CDbl(arcpoints)
			chordlength = (keywidth + Positioncal.CladWidth) * Math.Sin(dtheta / 2.0)
			Dim arcs As Short
			If Positioncal.CladWidth + keydistance + keywidth / 2.0 + keylength <= width1 Then
				arcs = 2S
			Else
				arcs = 1S
			End If
			If rotations >= 1.0 Then
				' The following expression was wrapped in a unchecked-expression
				If keydistance + keywidth / 2.0 + keylength <= width1 Then
					positions = CType(Utils.CopyArray(CType(positions, Array), New Double(6, 2 * rotations2 + 2 * rotations4 + 2 * Positioncal.Keyno * (rotations3 + arcpoints + 5) + 7 + 1 - 1) {}), Double(,))
					expositions = CType(Utils.CopyArray(CType(expositions, Array), New Double(6, 2 * rotations2 + 2 * rotations4 + 2 * Positioncal.Keyno * (rotations3 + arcpoints + 5) + 7 + 1 - 1) {}), Double(,))
				Else
					' The following expression was wrapped in a unchecked-expression
					positions = CType(Utils.CopyArray(CType(positions, Array), New Double(6, CInt(Math.Round(2.0 * rotations + CDbl(arcpoints) + 8.0)) + 1 - 1) {}), Double(,))
					expositions = CType(Utils.CopyArray(CType(expositions, Array), New Double(6, CInt(Math.Round(2.0 * rotations + CDbl(arcpoints) + 8.0)) + 1 - 1) {}), Double(,))
				End If
			End If
			positions(0, 0) = Positioncal.IniXAxisOffset
			positions(1, 0) = distance + (keydistance + keywidth / 2.0 + keylength) * Math.Cos(coneangle) + Positioncal.IniYAxisOffset
			positions(2, 0) = diameter / 2.0 + Positioncal.IniZAxisOffset
			positions(3, 0) = postureangle + 90.0
			positions(4, 0) = Conversions.ToDouble(Ryy)
			positions(5, 0) = Conversions.ToDouble(Rzz)
			expositions(0, 0) = stationangle / 6.2831853071795862 * 331776.0
			expositions(1, 0) = (keyangle / 360.0 + Math.Asin(Positioncal.CladWidth / (2.0 * (diameter / 2.0 - (keydistance + keywidth / 2.0 + keylength) * Math.Sin(coneangle)))) / 6.2831853071795862) * 331776.0
			Dim num As Short = 0S
			Dim num2 As Short = CShort((Positioncal.Keyno - 1))
			Dim ind As Integer
			For keyIndex As Short = num To num2
				Dim ycoord As Double = 0.0
				positions(1, CInt(keyIndex) * (CInt(arcs) * arcpoints + 3) + 1) = distance + (keydistance + keywidth / 2.0 + keylength) * Math.Cos(coneangle) + Positioncal.ToolOffset * Math.Cos(postureangle * 3.1415926535897931 / 180.0)
				positions(2, CInt(keyIndex) * (CInt(arcs) * arcpoints + 3) + 1) = diameter / 2.0 - (keydistance + keywidth / 2.0 + keylength) * Math.Sin(coneangle) + Positioncal.ToolOffset * Math.Sin(postureangle * 3.1415926535897931 / 180.0)
				positions(3, CInt(keyIndex) * (CInt(arcs) * arcpoints + 3) + 1) = postureangle + 90.0
				positions(4, CInt(keyIndex) * (CInt(arcs) * arcpoints + 3) + 1) = Conversions.ToDouble(Ryy)
				positions(5, CInt(keyIndex) * (CInt(arcs) * arcpoints + 3) + 1) = Conversions.ToDouble(Rzz)
				expositions(0, CInt(keyIndex) * (CInt(arcs) * arcpoints + 3) + 1) = stationangle / 6.2831853071795862 * 331776.0
				expositions(1, CInt(keyIndex) * (CInt(arcs) * arcpoints + 3) + 1) = (keyangle / 360.0 + CDbl(keyIndex) / CDbl(Positioncal.Keyno) + Math.Asin(Positioncal.CladWidth / (2.0 * (diameter / 2.0 - (keydistance + keywidth / 2.0 + keylength) * Math.Sin(coneangle)))) / 6.2831853071795862) * 331776.0
				Dim thetacoord As Double = Positioncal.CladWidth / 2.0 + keywidth / 2.0
				Dim num3 As Integer = 0
				Dim num4 As Integer = arcpoints
				ind = num3
				While ind <= num4
					' The following expression was wrapped in a unchecked-expression
					positions(1, CInt(keyIndex) * (CInt(arcs) * arcpoints + 3) + ind + 2) = distance + (keydistance + keywidth / 2.0 - ycoord) * Math.Cos(coneangle) + Positioncal.ToolOffset * Math.Cos(postureangle * 3.1415926535897931 / 180.0)
					positions(2, CInt(keyIndex) * (CInt(arcs) * arcpoints + 3) + ind + 2) = diameter / 2.0 - (keydistance + keywidth / 2.0 - ycoord) * Math.Sin(coneangle) + Positioncal.ToolOffset * Math.Sin(postureangle * 3.1415926535897931 / 180.0)
					positions(3, CInt(keyIndex) * (CInt(arcs) * arcpoints + 3) + ind + 2) = postureangle + 90.0
					positions(4, CInt(keyIndex) * (CInt(arcs) * arcpoints + 3) + ind + 2) = Conversions.ToDouble(Ryy)
					positions(5, CInt(keyIndex) * (CInt(arcs) * arcpoints + 3) + ind + 2) = Conversions.ToDouble(Rzz)
					expositions(0, CInt(keyIndex) * (CInt(arcs) * arcpoints + 3) + ind + 2) = stationangle / 6.2831853071795862 * 331776.0
					expositions(1, CInt(keyIndex) * (CInt(arcs) * arcpoints + 3) + ind + 2) = expositions(1, CInt(keyIndex) * (CInt(arcs) * arcpoints + 3) + 1) - (Math.Acos(thetacoord / (diameter / 2.0 - (keydistance + keywidth / 2.0 - ycoord) * Math.Sin(coneangle))) - Math.Acos((Positioncal.CladWidth + keywidth) / 2.0 / (diameter / 2.0 - (keydistance + keywidth / 2.0) * Math.Sin(coneangle)))) / 6.2831853071795862 * 331776.0

					thetacoord -= chordlength * Math.Sin((CDbl(ind) + 0.5) * dtheta)
					ycoord += chordlength * Math.Cos((CDbl(ind) + 0.5) * dtheta)

					ind += 1
				End While
				If Positioncal.CladWidth + keydistance + keywidth / 2.0 + keylength <= width1 Then
					ycoord = 0.0
					thetacoord = -Positioncal.CladWidth / 2.0 - keywidth / 2.0
					Dim num5 As Integer = 0
					Dim num6 As Integer = arcpoints
					ind = num5
					While ind <= num6
						' The following expression was wrapped in a unchecked-expression
						positions(1, CInt(keyIndex) * (CInt(arcs) * arcpoints + 3) + ind + arcpoints + 3) = distance + (keydistance + keywidth / 2.0 + keylength + ycoord) * Math.Cos(coneangle) + Positioncal.ToolOffset * Math.Cos(postureangle * 3.1415926535897931 / 180.0)
						positions(2, CInt(keyIndex) * (CInt(arcs) * arcpoints + 3) + ind + arcpoints + 3) = diameter / 2.0 - (keydistance + keywidth / 2.0 + keylength + ycoord) * Math.Sin(coneangle) + Positioncal.ToolOffset * Math.Sin(postureangle * 3.1415926535897931 / 180.0)
						positions(3, CInt(keyIndex) * (CInt(arcs) * arcpoints + 3) + ind + arcpoints + 3) = postureangle + 90.0
						positions(4, CInt(keyIndex) * (CInt(arcs) * arcpoints + 3) + ind + arcpoints + 3) = Conversions.ToDouble(Ryy)
						positions(5, CInt(keyIndex) * (CInt(arcs) * arcpoints + 3) + ind + arcpoints + 3) = Conversions.ToDouble(Rzz)
						expositions(0, CInt(keyIndex) * (CInt(arcs) * arcpoints + 3) + ind + arcpoints + 3) = stationangle / 6.2831853071795862 * 331776.0
						expositions(1, CInt(keyIndex) * (CInt(arcs) * arcpoints + 3) + ind + arcpoints + 3) = expositions(1, CInt(keyIndex) * (CInt(arcs) * arcpoints + 3) + 1) - (Math.Acos(thetacoord / (diameter / 2.0 - (keydistance + keywidth / 2.0 + keylength + ycoord) * Math.Sin(coneangle))) - Math.Acos((Positioncal.CladWidth + keywidth) / 2.0 / (diameter / 2.0 - (keydistance + keywidth / 2.0 + keylength) * Math.Sin(coneangle)))) / 6.2831853071795862 * 331776.0

						thetacoord += chordlength * Math.Sin((CDbl(ind) + 0.5) * dtheta)
						ycoord += chordlength * Math.Cos((CDbl(ind) + 0.5) * dtheta)

						ind += 1
					End While
				Else
					' The following expression was wrapped in a unchecked-expression
					positions(1, CInt(keyIndex) * (CInt(arcs) * arcpoints + 3) + arcpoints + 3) = distance + (keydistance + keywidth / 2.0 + keylength) * Math.Cos(coneangle) + Positioncal.ToolOffset * Math.Cos(postureangle * 3.1415926535897931 / 180.0)
					positions(2, CInt(keyIndex) * (CInt(arcs) * arcpoints + 3) + arcpoints + 3) = diameter / 2.0 - (keydistance + keywidth / 2.0 + keylength) * Math.Sin(coneangle) + Positioncal.ToolOffset * Math.Sin(postureangle * 3.1415926535897931 / 180.0)
					positions(3, CInt(keyIndex) * (CInt(arcs) * arcpoints + 3) + arcpoints + 3) = postureangle + 90.0
					positions(4, CInt(keyIndex) * (CInt(arcs) * arcpoints + 3) + arcpoints + 3) = Conversions.ToDouble(Ryy)
					positions(5, CInt(keyIndex) * (CInt(arcs) * arcpoints + 3) + arcpoints + 3) = Conversions.ToDouble(Rzz)
					expositions(0, CInt(keyIndex) * (CInt(arcs) * arcpoints + 3) + arcpoints + 3) = stationangle / 6.2831853071795862 * 331776.0
					expositions(1, CInt(keyIndex) * (CInt(arcs) * arcpoints + 3) + arcpoints + 3) = expositions(1, CInt(keyIndex) * (CInt(arcs) * arcpoints + 3) + arcpoints + 2)
				End If
			Next
			Dim sign As Short = 1S
			ind = 1
			While CDbl((ind - 1)) / 2.0 * effectivepitch <= keydistance - Positioncal.CladWidth
				' The following expression was wrapped in a unchecked-expression
				' The following expression was wrapped in a checked-expression
				positions(1, ind + Positioncal.Keyno * (CInt(arcs) * arcpoints + 3)) = distance + (CDbl((ind - 1)) * effectivepitch + Positioncal.CladWidth) * Math.Cos(coneangle) / 2.0 + Positioncal.ToolOffset * Math.Cos(postureangle * 3.1415926535897931 / 180.0)
				positions(2, ind + Positioncal.Keyno * (CInt(arcs) * arcpoints + 3)) = diameter / 2.0 - (CDbl((ind - 1)) * effectivepitch + Positioncal.CladWidth) * Math.Sin(coneangle) / 2.0 + Positioncal.ToolOffset * Math.Sin(postureangle * 3.1415926535897931 / 180.0)
				positions(1, ind + Positioncal.Keyno * (CInt(arcs) * arcpoints + 3) + 1) = distance + (CDbl((ind - 1)) * effectivepitch + Positioncal.CladWidth) * Math.Cos(coneangle) / 2.0 + Positioncal.ToolOffset * Math.Cos(postureangle * 3.1415926535897931 / 180.0)
				positions(2, ind + Positioncal.Keyno * (CInt(arcs) * arcpoints + 3) + 1) = diameter / 2.0 - (CDbl((ind - 1)) * effectivepitch + Positioncal.CladWidth) * Math.Sin(coneangle) / 2.0 + Positioncal.ToolOffset * Math.Sin(postureangle * 3.1415926535897931 / 180.0)
				If ind = 3 Then
					' The following expression was wrapped in a unchecked-expression
					expositions(0, ind + Positioncal.Keyno * (CInt(arcs) * arcpoints + 3) - 1) = stationangle / 6.2831853071795862 * 331776.0
					expositions(1, ind + Positioncal.Keyno * (CInt(arcs) * arcpoints + 3) - 1) = (keyangle / 360.0 - Math.Asin(keywidth / (diameter - Positioncal.CladWidth * Math.Sin(coneangle))) / 6.2831853071795862 + CDbl((ind - 1)) / 2.0 - 0.01) * 331776.0
				ElseIf ind > 2 Then
					' The following expression was wrapped in a unchecked-expression
					expositions(0, ind + Positioncal.Keyno * (CInt(arcs) * arcpoints + 3) - 1) = stationangle / 6.2831853071795862 * 331776.0
					expositions(1, ind + Positioncal.Keyno * (CInt(arcs) * arcpoints + 3) - 1) = (keyangle / 360.0 - Math.Asin(keywidth / (diameter - Positioncal.CladWidth * Math.Sin(coneangle))) / 6.2831853071795862 + CDbl((ind - 1)) / 2.0 + CDbl((inioverweld / 100.0F))) * 331776.0
				End If
				expositions(0, ind + Positioncal.Keyno * (CInt(arcs) * arcpoints + 3)) = stationangle / 6.2831853071795862 * 331776.0
				expositions(1, ind + Positioncal.Keyno * (CInt(arcs) * arcpoints + 3)) = (keyangle / 360.0 - Math.Asin(keywidth / (diameter - Positioncal.CladWidth * Math.Sin(coneangle))) / 6.2831853071795862 + CDbl((ind - 1)) / 2.0) * 331776.0
				positions(3, ind + Positioncal.Keyno * (CInt(arcs) * arcpoints + 3)) = postureangle + 90.0
				positions(4, ind + Positioncal.Keyno * (CInt(arcs) * arcpoints + 3)) = Conversions.ToDouble(Operators.SubtractObject(Ryy, Rockangle))
				positions(5, ind + Positioncal.Keyno * (CInt(arcs) * arcpoints + 3)) = Conversions.ToDouble(Rzz)
				positions(3, ind + Positioncal.Keyno * (CInt(arcs) * arcpoints + 3) + 1) = postureangle + 90.0
				positions(4, ind + Positioncal.Keyno * (CInt(arcs) * arcpoints + 3) + 1) = Conversions.ToDouble(Operators.SubtractObject(Ryy, Rockangle))
				positions(5, ind + Positioncal.Keyno * (CInt(arcs) * arcpoints + 3) + 1) = Conversions.ToDouble(Rzz)
				cycles += 1
				ind += 2
			End While
			Dim num7 As Short = 0S
			Dim num8 As Short = CShort((Positioncal.Keyno - 1))
			For keyIndex As Short = num7 To num8
				Dim num9 As Integer = 1
				Dim num10 As Integer = 2 * rotations3 - 1
				ind = num9
				While ind <= num10
					' The following expression was wrapped in a unchecked-expression
					' The following expression was wrapped in a checked-expression
					positions(1, ind + CInt(keyIndex) * (2 * rotations3) + 2 * rotations2 + Positioncal.Keyno * (CInt(arcs) * arcpoints + 3) + 2) = distance + (CDbl((2 * rotations2 + ind + 1)) * effectivepitch + Positioncal.CladWidth) * Math.Cos(coneangle) / 2.0 + Positioncal.ToolOffset * Math.Cos(postureangle * 3.1415926535897931 / 180.0)
					positions(2, ind + CInt(keyIndex) * (2 * rotations3) + 2 * rotations2 + Positioncal.Keyno * (CInt(arcs) * arcpoints + 3) + 2) = diameter / 2.0 - (CDbl((2 * rotations2 + ind + 1)) * effectivepitch + Positioncal.CladWidth) * Math.Sin(coneangle) / 2.0 + Positioncal.ToolOffset * Math.Sin(postureangle * 3.1415926535897931 / 180.0)
					positions(1, ind + CInt(keyIndex) * (2 * rotations3) + 2 * rotations2 + Positioncal.Keyno * (CInt(arcs) * arcpoints + 3) + 3) = positions(1, ind + CInt(keyIndex) * (2 * rotations3) + 2 * rotations2 + Positioncal.Keyno * (CInt(arcs) * arcpoints + 3) + 2)
					positions(2, ind + CInt(keyIndex) * (2 * rotations3) + 2 * rotations2 + Positioncal.Keyno * (CInt(arcs) * arcpoints + 3) + 3) = positions(2, ind + CInt(keyIndex) * (2 * rotations3) + 2 * rotations2 + Positioncal.Keyno * (CInt(arcs) * arcpoints + 3) + 2)

					' The following expression was wrapped in a checked-expression
					Dim num11 As Double = CDbl((ind + 2 * rotations2 + 1)) * effectivepitch / 2.0
					If num11 <= keydistance + keywidth / 2.0 - Positioncal.CladWidth / 2.0 Then
						' The following expression was wrapped in a checked-expression
						Dim w As Double = 2.0 * Math.Pow(Math.Pow((keywidth + Positioncal.CladWidth) / 2.0, 2.0) - Math.Pow(keydistance + keywidth / 2.0 - Positioncal.CladWidth / 2.0 - CDbl((ind + 1 + 2 * rotations2)) * effectivepitch / 2.0, 2.0), 0.5)
						If ind = 1 And keyIndex = 0S Then
							' The following expression was wrapped in a checked-expression
							expositions(0, ind + CInt(keyIndex) * (2 * rotations3) + 2 * rotations2 + Positioncal.Keyno * (CInt(arcs) * arcpoints + 3) + 1) = stationangle / 6.2831853071795862 * 331776.0
							expositions(1, ind + CInt(keyIndex) * (2 * rotations3) + 2 * rotations2 + Positioncal.Keyno * (CInt(arcs) * arcpoints + 3) + 1) = (keyangle / 360.0 - Math.Asin(keywidth / (diameter - Positioncal.CladWidth * Math.Sin(coneangle))) / 6.2831853071795862 + CDbl(cycles) - 1.0 - Math.Asin(w / (diameter - (Positioncal.CladWidth + CDbl((ind + 1 + 2 * rotations2)) * effectivepitch) * Math.Sin(coneangle))) / 6.2831853071795862) * 331776.0
						ElseIf ind = 1 Then
							' The following expression was wrapped in a checked-expression
							expositions(0, ind + CInt(keyIndex) * (2 * rotations3) + 2 * rotations2 + Positioncal.Keyno * (CInt(arcs) * arcpoints + 3) + 1) = stationangle / 6.2831853071795862 * 331776.0
							expositions(1, ind + CInt(keyIndex) * (2 * rotations3) + 2 * rotations2 + Positioncal.Keyno * (CInt(arcs) * arcpoints + 3) + 1) = (keyangle / 360.0 - CDbl((2S * keyIndex - 1S)) / CDbl((2 * Positioncal.Keyno)) - Math.Asin(keywidth / (diameter - Positioncal.CladWidth * Math.Sin(coneangle))) / 6.2831853071795862 + CDbl(cycles) - CDbl(sign) * (1.0 / CDbl((2 * Positioncal.Keyno)) - Math.Asin(w / (diameter - (Positioncal.CladWidth + CDbl((ind + 1 + 2 * rotations2)) * effectivepitch) * Math.Sin(coneangle))) / 6.2831853071795862)) * 331776.0
						Else
							' The following expression was wrapped in a checked-expression
							expositions(0, ind + CInt(keyIndex) * (2 * rotations3) + 2 * rotations2 + Positioncal.Keyno * (CInt(arcs) * arcpoints + 3) + 1) = stationangle / 6.2831853071795862 * 331776.0
							expositions(1, ind + CInt(keyIndex) * (2 * rotations3) + 2 * rotations2 + Positioncal.Keyno * (CInt(arcs) * arcpoints + 3) + 1) = (keyangle / 360.0 - CDbl((2S * (keyIndex + 1S) - 1S)) / CDbl((2 * Positioncal.Keyno)) - Math.Asin(keywidth / (diameter - Positioncal.CladWidth * Math.Sin(coneangle))) / 6.2831853071795862 + CDbl(cycles) - CDbl(sign) * (1.0 / CDbl((2 * Positioncal.Keyno)) - Math.Asin(w / (diameter - (Positioncal.CladWidth + CDbl((ind + 1 + 2 * rotations2)) * effectivepitch) * Math.Sin(coneangle))) / 6.2831853071795862)) * 331776.0
						End If
						expositions(0, ind + CInt(keyIndex) * (2 * rotations3) + 2 * rotations2 + Positioncal.Keyno * (CInt(arcs) * arcpoints + 3) + 2) = stationangle / 6.2831853071795862 * 331776.0
						expositions(1, ind + CInt(keyIndex) * (2 * rotations3) + 2 * rotations2 + Positioncal.Keyno * (CInt(arcs) * arcpoints + 3) + 2) = (keyangle / 360.0 - CDbl((2S * (keyIndex + 1S) - 1S)) / CDbl((2 * Positioncal.Keyno)) - Math.Asin(keywidth / (diameter - Positioncal.CladWidth * Math.Sin(coneangle))) / 6.2831853071795862 + CDbl(cycles) - CDbl(sign) * (1.0 / CDbl((2 * Positioncal.Keyno)) - Math.Asin(w / (diameter - (Positioncal.CladWidth + CDbl((ind + 1 + 2 * rotations2)) * effectivepitch) * Math.Sin(coneangle))) / 6.2831853071795862)) * 331776.0
					ElseIf num11 <= keydistance + keywidth / 2.0 + keylength - Positioncal.CladWidth / 2.0 Then
						Dim w As Double = keywidth + Positioncal.CladWidth
						expositions(0, ind + CInt(keyIndex) * (2 * rotations3) + 2 * rotations2 + Positioncal.Keyno * (CInt(arcs) * arcpoints + 3) + 1) = stationangle / 6.2831853071795862 * 331776.0
						expositions(1, ind + CInt(keyIndex) * (2 * rotations3) + 2 * rotations2 + Positioncal.Keyno * (CInt(arcs) * arcpoints + 3) + 1) = (keyangle / 360.0 - CDbl((2S * (keyIndex + 1S) - 1S)) / CDbl((2 * Positioncal.Keyno)) - Math.Asin(keywidth / (diameter - Positioncal.CladWidth * Math.Sin(coneangle))) / 6.2831853071795862 + CDbl(cycles) - CDbl(sign) * (1.0 / CDbl((2 * Positioncal.Keyno)) - Math.Asin(w / (diameter - (Positioncal.CladWidth + CDbl((ind + 1 + 2 * rotations2)) * effectivepitch) * Math.Sin(coneangle))) / 6.2831853071795862)) * 331776.0
						expositions(0, ind + CInt(keyIndex) * (2 * rotations3) + 2 * rotations2 + Positioncal.Keyno * (CInt(arcs) * arcpoints + 3) + 2) = stationangle / 6.2831853071795862 * 331776.0
						expositions(1, ind + CInt(keyIndex) * (2 * rotations3) + 2 * rotations2 + Positioncal.Keyno * (CInt(arcs) * arcpoints + 3) + 2) = expositions(1, ind + CInt(keyIndex) * (2 * rotations3) + 2 * rotations2 + Positioncal.Keyno * (CInt(arcs) * arcpoints + 3) + 1)
					ElseIf num11 <= keydistance + keywidth + keylength + Positioncal.CladWidth / 2.0 Then
						Dim w As Double
						If Math.Pow((keywidth + Positioncal.CladWidth) / 2.0, 2.0) < Math.Pow(keydistance + keywidth / 2.0 + keylength - Positioncal.CladWidth / 2.0 - CDbl((ind + 1 + 2 * rotations2)) * effectivepitch / 2.0, 2.0) Then
							w = 0.0
						Else
							' The following expression was wrapped in a checked-expression
							w = 2.0 * Math.Pow(Math.Pow((keywidth + Positioncal.CladWidth) / 2.0, 2.0) - Math.Pow(keydistance + keywidth / 2.0 + keylength - Positioncal.CladWidth / 2.0 - CDbl((ind + 1 + 2 * rotations2)) * effectivepitch / 2.0, 2.0), 0.5)
						End If
						expositions(0, ind + CInt(keyIndex) * (2 * rotations3) + 2 * rotations2 + Positioncal.Keyno * (CInt(arcs) * arcpoints + 3) + 1) = stationangle / 6.2831853071795862 * 331776.0
						expositions(1, ind + CInt(keyIndex) * (2 * rotations3) + 2 * rotations2 + Positioncal.Keyno * (CInt(arcs) * arcpoints + 3) + 1) = (keyangle / 360.0 - CDbl((2S * (keyIndex + 1S) - 1S)) / CDbl((2 * Positioncal.Keyno)) - Math.Asin(keywidth / (diameter - Positioncal.CladWidth * Math.Sin(coneangle))) / 6.2831853071795862 + CDbl(cycles) - CDbl(sign) * (1.0 / CDbl((2 * Positioncal.Keyno)) - Math.Asin(w / (diameter - (Positioncal.CladWidth + CDbl((ind + 1 + 2 * rotations2)) * effectivepitch) * Math.Sin(coneangle))) / 6.2831853071795862)) * 331776.0
						expositions(0, ind + CInt(keyIndex) * (2 * rotations3) + 2 * rotations2 + Positioncal.Keyno * (CInt(arcs) * arcpoints + 3) + 2) = stationangle / 6.2831853071795862 * 331776.0
						expositions(1, ind + CInt(keyIndex) * (2 * rotations3) + 2 * rotations2 + Positioncal.Keyno * (CInt(arcs) * arcpoints + 3) + 2) = expositions(1, ind + CInt(keyIndex) * (2 * rotations3) + 2 * rotations2 + Positioncal.Keyno * (CInt(arcs) * arcpoints + 3) + 1)
						If ind = 2 * rotations3 - 1 Then
							' The following expression was wrapped in a unchecked-expression
							expositions(0, ind + CInt(keyIndex) * (2 * rotations3) + 2 * rotations2 + Positioncal.Keyno * (CInt(arcs) * arcpoints + 3) + 3) = stationangle / 6.2831853071795862 * 331776.0
							expositions(1, ind + CInt(keyIndex) * (2 * rotations3) + 2 * rotations2 + Positioncal.Keyno * (CInt(arcs) * arcpoints + 3) + 3) = (keyangle / 360.0 - CDbl((2S * (keyIndex + 1S) - 1S)) / CDbl((2 * Positioncal.Keyno)) - Math.Asin(keywidth / (diameter - Positioncal.CladWidth * Math.Sin(coneangle))) / 6.2831853071795862 + CDbl(cycles) + CDbl(sign) * (1.0 / CDbl((2 * Positioncal.Keyno)) - Math.Asin(w / (diameter - (Positioncal.CladWidth + CDbl((ind + 1 + 2 * rotations2)) * effectivepitch) * Math.Sin(coneangle))) / 6.2831853071795862)) * 331776.0
						End If
					End If
					positions(3, ind + CInt(keyIndex) * (2 * rotations3) + 2 * rotations2 + Positioncal.Keyno * (CInt(arcs) * arcpoints + 3) + 2) = postureangle + 90.0

					positions(4, ind + CInt(keyIndex) * (2 * rotations3) + 2 * rotations2 + Positioncal.Keyno * (CInt(arcs) * arcpoints + 3) + 2) = Conversions.ToDouble(Operators.AddObject(Ryy, Operators.MultiplyObject(sign, Rockangle)))
					positions(5, ind + CInt(keyIndex) * (2 * rotations3) + 2 * rotations2 + Positioncal.Keyno * (CInt(arcs) * arcpoints + 3) + 2) = Conversions.ToDouble(Rzz)
					positions(3, ind + CInt(keyIndex) * (2 * rotations3) + 2 * rotations2 + Positioncal.Keyno * (CInt(arcs) * arcpoints + 3) + 3) = postureangle + 90.0
					positions(4, ind + CInt(keyIndex) * (2 * rotations3) + 2 * rotations2 + Positioncal.Keyno * (CInt(arcs) * arcpoints + 3) + 3) = Conversions.ToDouble(Operators.AddObject(Ryy, Operators.MultiplyObject(sign, Rockangle)))
					positions(5, ind + CInt(keyIndex) * (2 * rotations3) + 2 * rotations2 + Positioncal.Keyno * (CInt(arcs) * arcpoints + 3) + 3) = Conversions.ToDouble(Rzz)
					If sign = 1S Then
						sign = -1S
					Else
						sign = 1S
					End If
					ind += 2
				End While
			Next
			cycles -= 2
			Dim num12 As Integer = 1
			Dim num13 As Integer = 2 * rotations4 - 1
			ind = num12
			While ind <= num13
				' The following expression was wrapped in a unchecked-expression
				' The following expression was wrapped in a checked-expression
				positions(1, ind + 2 * rotations2 + Positioncal.Keyno * (2 * rotations3 + CInt(arcs) * arcpoints + 3) + 2) = distance + (CDbl((2 * rotations2 + 2 * rotations3 + ind + 1)) * effectivepitch + Positioncal.CladWidth) * Math.Cos(coneangle) / 2.0 + Positioncal.ToolOffset * Math.Cos(postureangle * 3.1415926535897931 / 180.0)
				positions(2, ind + 2 * rotations2 + Positioncal.Keyno * (2 * rotations3 + CInt(arcs) * arcpoints + 3) + 2) = diameter / 2.0 - (CDbl((2 * rotations2 + 2 * rotations3 + ind + 1)) * effectivepitch + Positioncal.CladWidth) * Math.Sin(coneangle) / 2.0 + Positioncal.ToolOffset * Math.Sin(postureangle * 3.1415926535897931 / 180.0)
				positions(1, ind + 2 * rotations2 + Positioncal.Keyno * (2 * rotations3 + CInt(arcs) * arcpoints + 3) + 3) = distance + (CDbl((2 * rotations2 + 2 * rotations3 + ind + 1)) * effectivepitch + Positioncal.CladWidth) * Math.Cos(coneangle) / 2.0 + Positioncal.ToolOffset * Math.Cos(postureangle * 3.1415926535897931 / 180.0)
				positions(2, ind + 2 * rotations2 + Positioncal.Keyno * (2 * rotations3 + CInt(arcs) * arcpoints + 3) + 3) = diameter / 2.0 - (CDbl((2 * rotations2 + 2 * rotations3 + ind + 1)) * effectivepitch + Positioncal.CladWidth) * Math.Sin(coneangle) / 2.0 + Positioncal.ToolOffset * Math.Sin(postureangle * 3.1415926535897931 / 180.0)
				If ind = 3 Then
					' The following expression was wrapped in a unchecked-expression
					expositions(0, ind + 2 * rotations2 + Positioncal.Keyno * (2 * rotations3 + CInt(arcs) * arcpoints + 3) + 1) = stationangle / 6.2831853071795862 * 331776.0
					expositions(1, ind + 2 * rotations2 + Positioncal.Keyno * (2 * rotations3 + CInt(arcs) * arcpoints + 3) + 1) = (keyangle / 360.0 - Math.Asin(keywidth / (diameter - Positioncal.CladWidth * Math.Sin(coneangle))) / 6.2831853071795862 + CDbl(cycles) + 1.0 - 0.01) * 331776.0
				ElseIf ind > 3 Then
					' The following expression was wrapped in a unchecked-expression
					expositions(0, ind + 2 * rotations2 + Positioncal.Keyno * (2 * rotations3 + CInt(arcs) * arcpoints + 3) + 1) = stationangle / 6.2831853071795862 * 331776.0
					expositions(1, ind + 2 * rotations2 + Positioncal.Keyno * (2 * rotations3 + CInt(arcs) * arcpoints + 3) + 1) = (keyangle / 360.0 - Math.Asin(keywidth / (diameter - Positioncal.CladWidth * Math.Sin(coneangle))) / 6.2831853071795862 + CDbl(cycles) + 1.0 + CDbl((inioverweld / 100.0F))) * 331776.0
				End If
				expositions(0, ind + 2 * rotations2 + Positioncal.Keyno * (2 * rotations3 + CInt(arcs) * arcpoints + 3) + 2) = stationangle / 6.2831853071795862 * 331776.0
				expositions(1, ind + 2 * rotations2 + Positioncal.Keyno * (2 * rotations3 + CInt(arcs) * arcpoints + 3) + 2) = (keyangle / 360.0 - Math.Asin(keywidth / (diameter - Positioncal.CladWidth * Math.Sin(coneangle))) / 6.2831853071795862 + CDbl(cycles) + 1.0) * 331776.0
				If ind = 2 * rotations4 - 1 Then
					cycles += 1
					expositions(0, ind + 2 * rotations2 + Positioncal.Keyno * (2 * rotations3 + CInt(arcs) * arcpoints + 3) + 3) = stationangle / 6.2831853071795862 * 331776.0
					expositions(1, ind + 2 * rotations2 + Positioncal.Keyno * (2 * rotations3 + CInt(arcs) * arcpoints + 3) + 3) = (keyangle / 360.0 - Math.Asin(keywidth / (diameter - Positioncal.CladWidth * Math.Sin(coneangle))) / 6.2831853071795862 + CDbl(cycles) + 1.0) * 331776.0
				End If
				positions(3, ind + 2 * rotations2 + Positioncal.Keyno * (2 * rotations3 + CInt(arcs) * arcpoints + 3) + 2) = postureangle + 90.0
				positions(4, ind + 2 * rotations2 + Positioncal.Keyno * (2 * rotations3 + CInt(arcs) * arcpoints + 3) + 2) = Conversions.ToDouble(Operators.SubtractObject(Ryy, Rockangle))
				positions(5, ind + 2 * rotations2 + Positioncal.Keyno * (2 * rotations3 + CInt(arcs) * arcpoints + 3) + 2) = Conversions.ToDouble(Rzz)
				positions(3, ind + 2 * rotations2 + Positioncal.Keyno * (2 * rotations3 + CInt(arcs) * arcpoints + 3) + 3) = postureangle + 90.0
				positions(4, ind + 2 * rotations2 + Positioncal.Keyno * (2 * rotations3 + CInt(arcs) * arcpoints + 3) + 3) = Conversions.ToDouble(Operators.SubtractObject(Ryy, Rockangle))
				positions(5, ind + 2 * rotations2 + Positioncal.Keyno * (2 * rotations3 + CInt(arcs) * arcpoints + 3) + 3) = Conversions.ToDouble(Rzz)
				cycles += 1
				ind += 2
			End While
			positions(0, 2 * rotations2 + 2 * rotations4 + Positioncal.Keyno * (2 * rotations3 + CInt(arcs) * arcpoints + 3) + 3) = CDbl(Positioncal.HomePos(0))
			positions(1, 2 * rotations2 + 2 * rotations4 + Positioncal.Keyno * (2 * rotations3 + CInt(arcs) * arcpoints + 3) + 3) = CDbl(Positioncal.HomePos(1))
			positions(2, 2 * rotations2 + 2 * rotations4 + Positioncal.Keyno * (2 * rotations3 + CInt(arcs) * arcpoints + 3) + 3) = CDbl(Positioncal.HomePos(2))
			positions(3, 2 * rotations2 + 2 * rotations4 + Positioncal.Keyno * (2 * rotations3 + CInt(arcs) * arcpoints + 3) + 3) = CDbl(Positioncal.HomePos(3))
			positions(4, 2 * rotations2 + 2 * rotations4 + Positioncal.Keyno * (2 * rotations3 + CInt(arcs) * arcpoints + 3) + 3) = CDbl(Positioncal.HomePos(4))
			positions(5, 2 * rotations2 + 2 * rotations4 + Positioncal.Keyno * (2 * rotations3 + CInt(arcs) * arcpoints + 3) + 3) = CDbl(Positioncal.HomePos(5))
			expositions(0, 2 * rotations2 + 2 * rotations4 + Positioncal.Keyno * (2 * rotations3 + CInt(arcs) * arcpoints + 3) + 3) = stationangle / 6.2831853071795862 * 331776.0
			expositions(1, 2 * rotations2 + 2 * rotations4 + Positioncal.Keyno * (2 * rotations3 + CInt(arcs) * arcpoints + 3) + 3) = 0.0
			Dim power As Double = 0.0025 * CDbl(Positioncal.LaserPowerIni) + -1.1111
			Dim feed As Double = 0.1 * Positioncal.PowderFeed
			Positioncal.TotalSteps = 2 * rotations2 + Positioncal.Keyno * (2 * rotations3 + CInt(arcs) * arcpoints + 3) + 2 * rotations4 + 4
			Dim headertxt As String = String.Concat(New String() {"/JOB" & vbCrLf & "//NAME HOSTMOV" & vbCrLf & "//POS" & vbCrLf & "///NPOS ", Conversions.ToString(2 * rotations2 + Positioncal.Keyno * (2 * rotations3 + CInt(arcs) * arcpoints + 3) + 2 * rotations4 + 4), ",0,", Conversions.ToString(2 * rotations2 + Positioncal.Keyno * (2 * rotations3 + CInt(arcs) * arcpoints + 3) + 2 * rotations4 + 4), ",1,0,1" & vbCrLf & "///USER ", Positioncal.StationPosition.ToString("#"), vbCrLf & "///TOOL ", Positioncal.Toolno.ToString("#0"), vbCrLf & "///POSTYPE USER" & vbCrLf & "///RECTAN" & vbCrLf & "///RCONF 1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0" & vbCrLf})
			Dim num14 As Integer = 0
			Dim num15 As Integer = 2 * rotations2 + Positioncal.Keyno * (2 * rotations3 + CInt(arcs) * arcpoints + 3) + 2 * rotations4 + 2
			Dim j As Short
			ind = num14
			While ind <= num15
				headertxt = headertxt + "C" + ind.ToString("0000#=")
				j = 0S

				Do
					headertxt = headertxt + positions(CInt(j), ind).ToString("#.000;-#.000;0.000") + ","
					j += 1S
				Loop While j <= 2S
				j = 3S
				Do
					headertxt = headertxt + positions(CInt(j), ind).ToString("#.00;-#.00;0.00") + ","
					j += 1S
				Loop While j <= 4S
				headertxt = headertxt + positions(5, ind).ToString("#.00;-#.00;0.00") + vbCrLf

				ind += 1
			End While
			headertxt += "///POSTYPE PULSE" & vbCrLf & "///PULSE" & vbCrLf
			headertxt = headertxt + "C" + (2 * rotations2 + Positioncal.Keyno * (2 * rotations3 + CInt(arcs) * arcpoints + 3) + 2 * rotations4 + 3).ToString("0000#=")
			j = 0S
			Do
				headertxt = headertxt + positions(CInt(j), 2 * rotations2 + Positioncal.Keyno * (2 * rotations3 + CInt(arcs) * arcpoints + 3) + 2 * rotations4 + 3).ToString("#;-#;0") + ","

				j += 1S

			Loop While j <= 4S
			headertxt = headertxt + positions(5, 2 * rotations2 + Positioncal.Keyno * (2 * rotations3 + CInt(arcs) * arcpoints + 3) + 2 * rotations4 + 3).ToString("#;-#;0") + vbCrLf
			Dim num16 As Integer = 0
			Dim num17 As Integer = 2 * rotations2 + Positioncal.Keyno * (2 * rotations3 + CInt(arcs) * arcpoints + 3) + 2 * rotations4 + 3
			ind = num16
			While ind <= num17
				headertxt = String.Concat(New String() {headertxt, "EC", ind.ToString("0000#="), expositions(0, ind).ToString("#0;-#0;0"), ",", expositions(1, ind).ToString("#0;-#0;0"), vbCrLf})
				ind += 1
			End While
			headertxt = String.Concat(New String() {headertxt, "///POSTYPE BASE" & vbCrLf & "///RECTAN" & vbCrLf & "P0000=0.000,0.000,0.000,0.00,0.00,0.00" & vbCrLf & "///POSTYPE PULSE" & vbCrLf & "///PULSE" & vbCrLf & "EX0000=0,0" & vbCrLf & "//INST" & vbCrLf & "///DATE ", mydatetime.ToString("yyyy/MM/dd HH:mm"), vbCrLf & "///COMM SUB TASK TO HOSTMAST" & vbCrLf & "///ATTR SC,RW,RJ" & vbCrLf & "////FRAME USER ", Positioncal.StationPosition.ToString("#"), vbCrLf & "///GROUP1 RB1" & vbCrLf & "///GROUP2 ST1" & vbCrLf & "///LVARS 0,0,0,0,0,0,0,0"})
			Dim mainprogtxt As String = "NOP" & vbCrLf & "EI LEVEL= 1" & vbCrLf
			If meanderflg = 1S Then
				Dim meanderfreq As Double
				mainprogtxt = String.Concat(New String() {mainprogtxt, "SETFILE WEV#(1) (4) ", Conversions.ToString(CInt(Math.Round(meanderfreq * 10.0))), vbCrLf & "SETFILE WEV#(1) (5) ", Conversions.ToString(CInt(Math.Round(meanderamp * 1000.0))), vbCrLf & "SETFILE WEV#(1) (8) 0" & vbCrLf & "SETFILE WEV#(1) (9) 0" & vbCrLf})
			End If
			mainprogtxt = String.Concat(New String() {mainprogtxt, "CALL JOB:STRESET" & vbCrLf & "GETS PX000 $PX000" & vbCrLf & "CNVRT PX000 PX000 RF" & vbCrLf & "GETE D000 P000 (3)" & vbCrLf & "ADD D000 ", (Positioncal.IniZAxisOffset * 1000.0).ToString("#0"), vbCrLf & "JUMP *LABEL1 IF D000<=", Positioncal.MaxZRobotPos.ToString("#"), vbCrLf & "SET D000 ", Positioncal.MaxZRobotPos.ToString("#"), vbCrLf & "*LABEL1" & vbCrLf & "SETE P000 (3) D000" & vbCrLf & "MOVL P000 V=", Positioncal.IdleSpeed.ToString("#0.0"), " PL=0  +MOVJ EX000 VJ=100.00" & vbCrLf & "GETS PX000 $PX000" & vbCrLf & "GETE D000 P000 (4)" & vbCrLf & "CALL JOB:ARMCOR IF D000>=", 184115.0.ToString("#"), vbCrLf & "CALL JOB:ARMCOR IF D000<=-", 184115.0.ToString("#"), vbCrLf & "GETPOS PX000 STEP#(2)" & vbCrLf & "CNVRT PX000 PX000 RF" & vbCrLf & "GETE D000 P000 (3)" & vbCrLf & "JUMP *LABEL2 IF D000<", Positioncal.MaxZRobotPos.ToString("#"), vbCrLf & "SUB D000 ", Positioncal.MaxZRobotPos.ToString("#"), vbCrLf & "MUL D000 -1" & vbCrLf & "SETE P000 (1) 0" & vbCrLf & "SETE P000 (2) 0" & vbCrLf & "SETE P000 (3) D000" & vbCrLf & "SETE P000 (4) 0" & vbCrLf & "SETE P000 (5) 0" & vbCrLf & "SETE P000 (6) 0" & vbCrLf & "SFTON RB1 P000 RF" & vbCrLf & "*LABEL2" & vbCrLf & "MOVL C00000 V=", Positioncal.IdleSpeed.ToString("#0.0"), " PL=0 NWAIT  +MOVJ EC00000 VJ=100.00" & vbCrLf & "DOUT OT#(1) ON" & vbCrLf & "DOUT OT#(8) ON" & vbCrLf & "JUMP *PILOTON IF IN#(2)=ON" & vbCrLf & "WAIT IN#(6)=ON T=5.00" & vbCrLf & "JUMP *END IF IN#(6)=OFF" & vbCrLf})
			If Positioncal.PowderJar = 1S Then
				mainprogtxt += "DOUT OT#(4) ON" & vbCrLf & "DOUT OT#(6) ON" & vbCrLf
			Else
				mainprogtxt += "DOUT OT#(5) ON" & vbCrLf & "DOUT OT#(7) ON" & vbCrLf
			End If
			mainprogtxt = String.Concat(New String() {mainprogtxt, "JUMP *PILOTON IF IN#(6)=ON" & vbCrLf & "TIMER T=", Positioncal.PowderSettling1.ToString("#0.00"), vbCrLf & "*PILOTON" & vbCrLf & "SFTOF RB1" & vbCrLf & "MOVL C00001 V=", Positioncal.ApproachSpeed.ToString("#0.0"), " PL=0 DEC=20  +MOVJ EC00001 VJ=100.00" & vbCrLf & "WAIT IN#(1)=ON T=5.00" & vbCrLf & "TIMER T=", Positioncal.PowderSettling2.ToString("#0.00"), vbCrLf & "EI LEVEL= 3" & vbCrLf & "*STARTL" & vbCrLf & "DOUT OT#(2) ON" & vbCrLf})
			Dim num18 As Short = 0S
			Dim num19 As Short = CShort((Positioncal.Keyno - 1))
			Dim i As Short
			i = num18
			While i <= num19
				Dim num20 As Integer = 1
				Dim num21 As Integer = CInt(arcs) * arcpoints + 3
				ind = num20
				While ind <= num21
					If ind < CInt(arcs) * arcpoints + 3 Then
						If Not (ind = 1 And keyIndex = 0S) Then
							If ind = 1 Then
								mainprogtxt = String.Concat(New String() {mainprogtxt, "MOVL C", (ind + CInt(keyIndex) * (CInt(arcs) * arcpoints + 3)).ToString("0000#"), " V=", Positioncal.ApproachSpeed.ToString("#.0;-#.0;0.0"), " PL=", Positioncal.PositionLevel.ToString("#"), " +MOVJ EC", (ind + CInt(keyIndex) * (CInt(arcs) * arcpoints + 3)).ToString("0000#"), " VJ=100.00" & vbCrLf})
							ElseIf ind = 2 Or ind = arcpoints + 3 Then
								mainprogtxt = String.Concat(New String() {mainprogtxt, "SMOVL C", (ind + CInt(keyIndex) * (CInt(arcs) * arcpoints + 3)).ToString("0000#"), " V=", processspeed.ToString("#.0;-#.0;0.0"), " PL=", Positioncal.PositionLevel.ToString("#"), " +MOVJ EC", (ind + CInt(keyIndex) * (CInt(arcs) * arcpoints + 3)).ToString("0000#"), " VJ=100.00" & vbCrLf})
							Else
								mainprogtxt = String.Concat(New String() {mainprogtxt, "SMOVC C", (ind + CInt(keyIndex) * (CInt(arcs) * arcpoints + 3)).ToString("0000#"), " V=", processspeed.ToString("#.0;-#.0;0.0"), " PL=", Positioncal.PositionLevel.ToString("#"), " +MOVJ EC", (ind + CInt(keyIndex) * (CInt(arcs) * arcpoints + 3)).ToString("0000#"), " VJ=100.00" & vbCrLf})
							End If
						End If
					Else
						mainprogtxt = String.Concat(New String() {mainprogtxt, "SMOVC C", (ind + CInt(keyIndex) * (CInt(arcs) * arcpoints + 3)).ToString("0000#"), " V=", processspeed.ToString("#.0;-#.0;0.0"), " PL=0 +MOVJ EC", (ind + CInt(keyIndex) * (CInt(arcs) * arcpoints + 3)).ToString("0000#"), " VJ=100.00" & vbCrLf})
					End If
					If ind = 1 Then
						' The following expression was wrapped in a unchecked-expression
						mainprogtxt = String.Concat(New String() {mainprogtxt, "ARCON AC=", (feed * 100.0).ToString("#0"), " AV=", power.ToString("#0.0"), vbCrLf})
					End If
					ind += 1
				End While
				mainprogtxt = String.Concat(New String() {mainprogtxt, "ARCOF" & vbCrLf & "GETS PX000 $PX000" & vbCrLf & "CNVRT PX000 PX000 RF" & vbCrLf & "GETE D000 P000 (3)" & vbCrLf & "ADD D000 ", (Positioncal.IniZAxisOffset * 1000.0).ToString("#0"), vbCrLf & "JUMP *LABEL", CInt((i + 3S)).ToString(), " IF D000<=", Positioncal.MaxZRobotPos.ToString("#"), vbCrLf & "SET D000 ", Positioncal.MaxZRobotPos.ToString("#"), vbCrLf & "*LABEL", CInt((i + 3S)).ToString(), vbCrLf & "SETE P000 (3) D000" & vbCrLf & "MOVL P000 V=", Positioncal.ApproachSpeed.ToString("#0.0"), " PL=2 +MOVJ EX000 VJ=100.00" & vbCrLf})
				i = i + 1S
			End While
			Dim num22 As Integer = 1
			Dim num23 As Integer = 2 * rotations2 + 1
			ind = num22
			While ind <= num23
				' The following expression was wrapped in a unchecked-expression
				' The following expression was wrapped in a checked-expression
				Dim rpm As Double = processspeed * 60.0 / (2.0 * positions(2, ind + Positioncal.Keyno * (CInt(arcs) * arcpoints + 3)) * 3.1415926535897931) * 81.0 / 20.0
				If ind = 1 Then
					' The following expression was wrapped in a unchecked-expression
					mainprogtxt = String.Concat(New String() {mainprogtxt, "MOVL C", (ind + Positioncal.Keyno * (CInt(arcs) * arcpoints + 3)).ToString("0000#"), " V=", Positioncal.ApproachSpeed.ToString("#0.0"), " PL=", Positioncal.PositionLevel.ToString("#"), " +MOVJ EC", (ind + Positioncal.Keyno * (CInt(arcs) * arcpoints + 3)).ToString("0000#"), " VJ=100" & vbCrLf & "ARCON AC=", (feed * 100.0).ToString("#0"), " AV=", power.ToString("#0.0"), vbCrLf})
				Else
					mainprogtxt = String.Concat(New String() {mainprogtxt, "MOVJ C", (ind + Positioncal.Keyno * (CInt(arcs) * arcpoints + 3)).ToString("0000#"), " VJ=100.00 PL=", Positioncal.PositionLevel.ToString("#"), " DEC=20 +MOVJ EC", (ind + Positioncal.Keyno * (CInt(arcs) * arcpoints + 3)).ToString("0000#"), " VJ=", rpm.ToString("#.00;-#.00;0.00"), vbCrLf})
				End If
				mainprogtxt = String.Concat(New String() {mainprogtxt, "MOVJ C", (ind + Positioncal.Keyno * (CInt(arcs) * arcpoints + 3) + 1).ToString("0000#"), " VJ=100.00 PL=", Positioncal.PositionLevel.ToString("#"), " DEC=20 +MOVJ EC", (ind + Positioncal.Keyno * (CInt(arcs) * arcpoints + 3) + 1).ToString("0000#"), " VJ=", rpm.ToString("#.00;-#.00;0.00"), vbCrLf})
				ind += 2
			End While
			mainprogtxt = String.Concat(New String() {mainprogtxt, "ARCOF" & vbCrLf & "GETS PX000 $PX000" & vbCrLf & "CNVRT PX000 PX000 RF" & vbCrLf & "GETE D000 P000 (3)" & vbCrLf & "ADD D000 ", (Positioncal.IniZAxisOffset * 1000.0).ToString("#0"), vbCrLf & "JUMP *LABEL", CInt((i + 3S)).ToString(), " IF D000<=", Positioncal.MaxZRobotPos.ToString("#"), vbCrLf & "SET D000 ", Positioncal.MaxZRobotPos.ToString("#"), vbCrLf & "*LABEL", CInt((i + 3S)).ToString(), vbCrLf & "SETE P000 (3) D000" & vbCrLf & "MOVL P000 V=", Positioncal.ApproachSpeed.ToString("#0.0"), " PL=2 +MOVJ EX000 VJ=100.00" & vbCrLf})
			Dim num24 As Short = 0S
			Dim num25 As Short = CShort((Positioncal.Keyno - 1))
			i = num24
			While i <= num25
				Dim num26 As Integer = 1
				Dim num27 As Integer = 2 * rotations3 - 1
				ind = num26
				While ind <= num27
					' The following expression was wrapped in a unchecked-expression
					' The following expression was wrapped in a checked-expression
					Dim rpm As Double = processspeed * 60.0 / (2.0 * positions(2, ind + CInt(keyIndex) * (2 * rotations3) + 2 * rotations2 + Positioncal.Keyno * (CInt(arcs) * arcpoints + 3) + 2) * 3.1415926535897931) * 81.0 / 20.0
					If ind = 1 Then
						' The following expression was wrapped in a unchecked-expression
						mainprogtxt = String.Concat(New String() {mainprogtxt, "MOVL C", (ind + CInt(keyIndex) * (2 * rotations3) + 2 * rotations2 + Positioncal.Keyno * (CInt(arcs) * arcpoints + 3) + 2).ToString("0000#"), " V=", Positioncal.ApproachSpeed.ToString("#0.0"), " PL=", Positioncal.PositionLevel.ToString("#"), " +MOVJ EC", (ind + CInt(keyIndex) * (2 * rotations3) + 2 * rotations2 + Positioncal.Keyno * (CInt(arcs) * arcpoints + 3) + 2).ToString("0000#"), " VJ=100" & vbCrLf & "ARCON AC=", (feed * 100.0).ToString("#0"), " AV=", power.ToString("#0.0"), vbCrLf})
					Else
						mainprogtxt = String.Concat(New String() {mainprogtxt, "MOVL C", (ind + CInt(keyIndex) * (2 * rotations3) + 2 * rotations2 + Positioncal.Keyno * (CInt(arcs) * arcpoints + 3) + 2).ToString("0000#"), " V=100.0 PL=", Positioncal.PositionLevel.ToString("#"), " +MOVJ EC", (ind + CInt(keyIndex) * (2 * rotations3) + 2 * rotations2 + Positioncal.Keyno * (CInt(arcs) * arcpoints + 3) + 2).ToString("0000#"), " VJ=", rpm.ToString("#.00;-#.00;0.00"), vbCrLf})
					End If
					mainprogtxt = String.Concat(New String() {mainprogtxt, "MOVL C", (ind + CInt(keyIndex) * (2 * rotations3) + 2 * rotations2 + Positioncal.Keyno * (CInt(arcs) * arcpoints + 3) + 3).ToString("0000#"), " V=100.0 PL=", Positioncal.PositionLevel.ToString("#"), " +MOVJ EC", (ind + CInt(keyIndex) * (2 * rotations3) + 2 * rotations2 + Positioncal.Keyno * (CInt(arcs) * arcpoints + 3) + 3).ToString("0000#"), " VJ=", rpm.ToString("#.00;-#.00;0.00"), vbCrLf})
					ind += 2
				End While
				mainprogtxt = String.Concat(New String() {mainprogtxt, "ARCOF" & vbCrLf & "GETS PX000 $PX000" & vbCrLf & "CNVRT PX000 PX000 RF" & vbCrLf & "GETE D000 P000 (3)" & vbCrLf & "ADD D000 ", (Positioncal.IniZAxisOffset * 1000.0).ToString("#0"), vbCrLf & "JUMP *LABEL", (Positioncal.Keyno + CInt(i) + 4).ToString(), " IF D000<=", Positioncal.MaxZRobotPos.ToString("#"), vbCrLf & "SET D000 ", Positioncal.MaxZRobotPos.ToString("#"), vbCrLf & "*LABEL", (Positioncal.Keyno + CInt(i) + 4).ToString(), vbCrLf & "SETE P000 (3) D000" & vbCrLf & "MOVL P000 V=", Positioncal.ApproachSpeed.ToString("#0.0"), " PL=", Positioncal.PositionLevel.ToString("#"), " +MOVJ EX000 VJ=100.00" & vbCrLf})
				i = i + 1S
			End While
			Dim num28 As Integer = 1
			Dim num29 As Integer = 2 * rotations4 - 1
			ind = num28
			While ind <= num29
				' The following expression was wrapped in a unchecked-expression
				' The following expression was wrapped in a checked-expression
				Dim rpm As Double = processspeed * 60.0 / (2.0 * positions(2, ind + Positioncal.Keyno * (2 * rotations3 + CInt(arcs) * arcpoints + 3) + 2) * 3.1415926535897931) * 81.0 / 20.0
				If ind = 1 Then
					' The following expression was wrapped in a unchecked-expression
					mainprogtxt = String.Concat(New String() {mainprogtxt, "MOVL C", (ind + Positioncal.Keyno * (2 * rotations3 + CInt(arcs) * arcpoints + 3) + 2 * rotations2 + 2).ToString("0000#"), " V=", Positioncal.ApproachSpeed.ToString("#0.0"), " PL=", Positioncal.PositionLevel.ToString("#"), " +MOVJ EC", (ind + Positioncal.Keyno * (2 * rotations3 + CInt(arcs) * arcpoints + 3) + 2 * rotations2 + 2).ToString("0000#"), " VJ=100" & vbCrLf & "ARCON AC=", (feed * 100.0).ToString("#0"), " AV=", power.ToString("#0.0"), vbCrLf})
				Else
					mainprogtxt = String.Concat(New String() {mainprogtxt, "MOVL C", (ind + Positioncal.Keyno * (2 * rotations3 + CInt(arcs) * arcpoints + 3) + 2 * rotations2 + 2).ToString("0000#"), " V=100.0 PL=", Positioncal.PositionLevel.ToString("#"), " +MOVJ EC", (ind + Positioncal.Keyno * (2 * rotations3 + CInt(arcs) * arcpoints + 3) + 2 * rotations2 + 2).ToString("0000#"), " VJ=", rpm.ToString("#.00;-#.00;0.00"), vbCrLf})
				End If
				mainprogtxt = String.Concat(New String() {mainprogtxt, "MOVL C", (ind + Positioncal.Keyno * (2 * rotations3 + CInt(arcs) * arcpoints + 3) + 2 * rotations2 + 3).ToString("0000#"), " V=100.0 PL=", Positioncal.PositionLevel.ToString("#"), " +MOVJ EC", (ind + Positioncal.Keyno * (2 * rotations3 + CInt(arcs) * arcpoints + 3) + 2 * rotations2 + 3).ToString("0000#"), " VJ=", rpm.ToString("#.00;-#.00;0.00"), vbCrLf})
				ind += 2
			End While
			mainprogtxt = String.Concat(New String() {mainprogtxt, "ARCOF" & vbCrLf & "DI LEVEL= 2" & vbCrLf & "JUMP *END" & vbCrLf & "*QVERROR" & vbCrLf & "*END" & vbCrLf & "DOUT OG#(1) 0" & vbCrLf & "DOUT OG#(2) 0" & vbCrLf & "CALL JOB:STRESET" & vbCrLf & "GETS PX000 $PX000" & vbCrLf & "CNVRT PX000 PX000 RF" & vbCrLf & "GETE D000 P000 (3)" & vbCrLf & "ADD D000 ", (Positioncal.IniZAxisOffset * 1000.0).ToString("#0"), vbCrLf & "JUMP *LABEL", (2 * Positioncal.Keyno + 4).ToString(), " IF D000<=", Positioncal.MaxZRobotPos.ToString("#"), vbCrLf & "SET D000 ", Positioncal.MaxZRobotPos.ToString("#"), vbCrLf & "*LABEL", (2 * Positioncal.Keyno + 4).ToString(), vbCrLf & "SETE P000 (3) D000" & vbCrLf & "MOVL P000 V=", Positioncal.ApproachSpeed.ToString("#0.0"), " PL=0  +MOVJ EX000 VJ=100.00" & vbCrLf & "GETE D000 P000 (1)" & vbCrLf & "ADD D000 ", (Positioncal.IniXAxisOffset * 1000.0).ToString("#0"), vbCrLf & "SETE P000 (1) D000" & vbCrLf & "MOVL P000 V=100.0 PL=2  +MOVJ EX000 VJ=100.00" & vbCrLf & "MOVL C", (2 * rotations2 + Positioncal.Keyno * (2 * rotations3 + CInt(arcs) * arcpoints + 3) + 2 * rotations4 + 3).ToString("0000#"), " V=", Positioncal.IdleSpeed.ToString("#0.0"), " PL=2  +MOVJ EC", (2 * rotations2 + Positioncal.Keyno * (2 * rotations3 + CInt(arcs) * arcpoints + 3) + 2 * rotations4 + 3).ToString("0000#"), " VJ=100.00" & vbCrLf & "END"})
			Try
				FileSystem.FileOpen(1, Positioncal.BasePath + "hostmov.jbi", OpenMode.Output, OpenAccess.[Default], OpenShare.[Default], -1)
				FileSystem.PrintLine(1, New Object() {headertxt})
				FileSystem.PrintLine(1, New Object() {mainprogtxt})
				FileSystem.FileClose(New Integer() {1})
				Positioncal.ControlGroup = 0S
			Catch ex As Exception
				Interaction.MsgBox("Job saving has failed due to the following reason: " + ex.Message, MsgBoxStyle.Exclamation, Nothing)
			End Try
		End Sub

		' Token: 0x06000564 RID: 1380 RVA: 0x00008B8C File Offset: 0x00006F8C
		<MethodImpl(MethodImplOptions.NoInlining Or MethodImplOptions.NoOptimization)>
		Public Sub valveclad2(diameter As Double, width1 As Double, distance As Double, pitch As Double, processspeed As Double, leftang As Double, rightang As Double, layerheight As Double, layerno As Integer, intoverweld As Double, rockang As Double, postureangle As Double, coneangle As Double, stationposition As Integer, inioverweld As Single, finoverweld As Single, meanderamp As Double, meanderflg As Short, initialang As Double, valveflg As Integer, tooloffset As Double, rockangvar As Short, hWnd As Integer)
			Dim robotctr As Short() = New Short(7) {}
			Dim stationctr As Short() = New Short(15) {}
			Dim positions As Double(,) = New Double(6, 11) {}
			Dim expositions As Double(,) = New Double(6, 11) {}
			Dim totalpoints As Integer = 0
			Dim totalangle As Double = 0.0
			Dim Ry As Integer
			Dim Rz As Integer
			Dim mydatetime As DateTime
			Dim Claddingdir_loc As Short
			Dim Tiltaxispos As Integer
			Ry = CInt(Math.Round(Positioncal.WorkYAxisTilt))
			Rz = CInt(Math.Round(Positioncal.WorkZAxisYaw))
			mydatetime = DateAndTime.Now
			Claddingdir_loc = CShort(Positioncal.CladdingDir)
			Select Case stationposition
				Case 2
					Tiltaxispos = 27648
				Case 3
					Tiltaxispos = 41472
				Case 4
					Tiltaxispos = 55296
				Case 5
					Tiltaxispos = 82944
			End Select
			coneangle = coneangle * 3.1415926535897931 / 180.0
			Positioncal.CrankThrow = 0.01
			If meanderflg = 0S Then
				meanderamp = 0.0
			End If
			Dim vlvgeom As Integer
			If valveflg = 0 Then
				vlvgeom = 1
			Else
				vlvgeom = -1
			End If
			positions(0, 0) = Positioncal.IniXAxisOffset
			positions(1, 0) = distance + CDbl(Claddingdir_loc) * (Positioncal.CladWidth / 2.0 + meanderamp) * Math.Cos(coneangle) + Positioncal.IniYAxisOffset
			positions(2, 0) = Positioncal.CrankThrow + CDbl(vlvgeom) * (diameter / 2.0 + Positioncal.IniZAxisOffset) - CDbl(Claddingdir_loc) * (Positioncal.CladWidth / 2.0 + meanderamp) * Math.Sin(postureangle * 3.1415926535897931 / 180.0)
			positions(3, 0) = 90.0 + postureangle - CDbl(Claddingdir_loc) * rockang
			positions(4, 0) = CDbl(Ry)
			positions(5, 0) = CDbl(Rz)
			positions(0, 1) = Positioncal.IniXAxisOffset
			positions(1, 1) = distance + CDbl(Claddingdir_loc) * (Positioncal.CladWidth / 2.0 + meanderamp) * Math.Cos(coneangle) + tooloffset * Math.Sin(coneangle)
			positions(2, 1) = Positioncal.CrankThrow + CDbl(vlvgeom) * diameter / 2.0 - CDbl(Claddingdir_loc) * (Positioncal.CladWidth / 2.0 + meanderamp) * Math.Sin(coneangle) + tooloffset * Math.Cos(postureangle * 3.1415926535897931 / 180.0)
			positions(3, 1) = 90.0 + postureangle - CDbl(Claddingdir_loc) * rockang
			positions(4, 1) = CDbl(Ry)
			positions(5, 1) = CDbl(Rz)
			positions(0, 2) = Positioncal.WorkXAxisOffset
			positions(1, 2) = distance + CDbl(Claddingdir_loc) * (Positioncal.CladWidth / 2.0 + meanderamp) * Math.Cos(coneangle) + tooloffset * Math.Sin(postureangle * 3.1415926535897931 / 180.0)
			positions(2, 2) = Positioncal.CrankThrow + CDbl(vlvgeom) * diameter / 2.0 - CDbl(Claddingdir_loc) * (Positioncal.CladWidth / 2.0 + meanderamp) * Math.Sin(coneangle) + tooloffset * Math.Cos(postureangle * 3.1415926535897931 / 180.0)
			positions(3, 2) = 90.0 + postureangle - CDbl(Claddingdir_loc) * rockang
			positions(4, 2) = CDbl(Ry)
			positions(5, 2) = CDbl(Rz)
			Dim width_left As Double
			Dim width_right As Double
			If Claddingdir_loc = 1S Then
				width_left = -width1
				width_right = 0.0
			Else
				width_left = 0.0
				width_right = -width1
			End If
			Dim num As Short = 1S
			Dim num2 As Short = CShort(layerno)
			Dim inipoints As Integer
			Dim pointnumber As Integer
			Dim finpoints As Integer
			For layerIndex As Short = num To num2
				Dim finaldistance As Double
				If layerIndex <> 1S Then
					' The following expression was wrapped in a checked-statement
					totalpoints += inipoints + pointnumber + finpoints
					If finaldistance = 0.0 Then
						If Claddingdir_loc = 1S Then
							totalangle += inioverweld_int / 100.0 + CDbl(pointnumber) / CDbl(Positioncal.PPR) + finoverweld_int / 100.0
						Else
							totalangle += inioverweld_int / 100.0 + CDbl(pointnumber) / CDbl(Positioncal.PPR) + finoverweld_int / 100.0
						End If
					ElseIf Claddingdir_loc = 1S Then
						Dim inioverweld_int As Double
						Dim finoverweld_int As Double
						totalangle += inioverweld_int / 100.0 + CDbl((pointnumber - 1)) / CDbl(Positioncal.PPR) + finaldistance + finoverweld_int / 100.0
					Else
						Dim inioverweld_int As Double
						Dim finoverweld_int As Double
						totalangle += inioverweld_int / 100.0 + CDbl((pointnumber - 1)) / CDbl(Positioncal.PPR) + finaldistance + finoverweld_int / 100.0
					End If
				End If
				Dim rotations As Double
				If Claddingdir_loc = 1S Then
					' The following expression was wrapped in a checked-expression
					rotations = Math.Round((width1 - Positioncal.CladWidth - 2.0 * meanderamp + layerheight * (CDbl((layerIndex - 1S)) * Math.Tan(leftang) + CDbl(layerIndex) * Math.Tan(rightang))) / pitch, 3)
				Else
					' The following expression was wrapped in a checked-expression
					rotations = Math.Round((width1 - Positioncal.CladWidth - 2.0 * meanderamp + layerheight * (CDbl(layerIndex) * Math.Tan(leftang) + CDbl((layerIndex - 1S)) * Math.Tan(rightang))) / pitch, 3)
				End If
				If rotations < 0.0 Then
					rotations = 0.0
				End If
				finaldistance = rotations - Conversion.Int(rotations * CDbl(Positioncal.PPR)) / CDbl(Positioncal.PPR)
				If finaldistance < 0.015 And finaldistance > 0.0 Then
					rotations = Conversion.Int(rotations)
					If Claddingdir_loc = 1S Then
						' The following expression was wrapped in a checked-expression
						pitch = (width1 - Positioncal.CladWidth - 2.0 * meanderamp + layerheight * (CDbl((layerIndex - 1S)) * Math.Tan(leftang) + CDbl(layerIndex) * Math.Tan(rightang))) / rotations
					Else
						' The following expression was wrapped in a checked-expression
						pitch = (width1 - Positioncal.CladWidth - 2.0 * meanderamp + layerheight * (CDbl(layerIndex) * Math.Tan(leftang) + CDbl((layerIndex - 1S)) * Math.Tan(rightang))) / rotations
					End If
					finaldistance = 0.0
				End If
				pointnumber = CInt(Math.Round(Math.Ceiling(rotations * CDbl(Positioncal.PPR))))
				Dim inioverweld_int As Double
				If i = 1S Then
					inioverweld_int = CDbl(inioverweld)
				Else
					inioverweld_int = 0.0
				End If
				inipoints = CInt(Math.Round(Math.Round(inioverweld_int / 100.0 * 360.0 / 30.0)))
				If inipoints = 0 And inioverweld_int <> 0.0 Then
					inipoints = 1
				End If
				Dim finoverweld_int As Double
				If CInt(i) <> layerno Then
					finoverweld_int = intoverweld
				Else
					finoverweld_int = CDbl(finoverweld)
				End If
				finpoints = CInt(Math.Round(Math.Round(finoverweld_int / 100.0 * 360.0 / 30.0)))
				If finpoints = 0 And finoverweld_int <> 0.0 Then
					finpoints = 1
				End If
				positions = CType(Utils.CopyArray(CType(positions, Array), New Double(6, totalpoints + inipoints + pointnumber + finpoints + 5 + 1 - 1) {}), Double(,))
				expositions = CType(Utils.CopyArray(CType(expositions, Array), New Double(6, totalpoints + inipoints + pointnumber + finpoints + 5 + 1 - 1) {}), Double(,))
				Dim num3 As Integer = 1
				Dim num4 As Integer = inipoints
				For passIndex As Integer = num3 To num4
					If Claddingdir_loc = 1S Then
						' The following expression was wrapped in a unchecked-expression
						' The following expression was wrapped in a checked-expression
						positions(0, totalpoints + j + 2) = Positioncal.WorkXAxisOffset + CDbl(Positioncal.DirectionFlg) * Positioncal.CrankThrow * Math.Sin((1.0 / CDbl(Positioncal.PPR) + totalangle + inioverweld_int / 100.0 * CDbl((passIndex - 1)) / CDbl(inipoints)) * 2.0 * 3.1415926535897931)
						positions(1, totalpoints + j + 2) = distance + CDbl(Claddingdir_loc) * (width_right + Positioncal.CladWidth / 2.0 + meanderamp - layerheight * CDbl((i - 1S)) * Math.Tan(leftang)) * Math.Cos(coneangle) + tooloffset * Math.Sin(postureangle * 3.1415926535897931 / 180.0)
						positions(2, totalpoints + j + 2) = Positioncal.CrankThrow * Math.Cos((1.0 / CDbl(Positioncal.PPR) + totalangle + inioverweld_int / 100.0 * CDbl((passIndex - 1)) / CDbl(inipoints)) * 2.0 * 3.1415926535897931) + CDbl(vlvgeom) * diameter / 2.0 + layerheight * CDbl((i - 1S)) * Math.Cos(coneangle) - CDbl(Claddingdir_loc) * (width_right + Positioncal.CladWidth / 2.0 + meanderamp - layerheight * CDbl((i - 1S)) * Math.Tan(leftang)) * Math.Sin(coneangle) + tooloffset * Math.Cos(postureangle * 3.1415926535897931 / 180.0)
						positions(3, totalpoints + j + 2) = 90.0 + postureangle - CDbl(Claddingdir_loc) * rockang
						positions(4, totalpoints + j + 2) = CDbl(Ry)
						positions(5, totalpoints + j + 2) = CDbl(Rz)
					Else
						' The following expression was wrapped in a unchecked-expression
						' The following expression was wrapped in a checked-expression
						positions(0, totalpoints + j + 2) = Positioncal.WorkXAxisOffset + CDbl(Positioncal.DirectionFlg) * Positioncal.CrankThrow * Math.Sin((1.0 / CDbl(Positioncal.PPR) + totalangle + inioverweld_int / 100.0 * CDbl((passIndex - 1)) / CDbl(inipoints)) * 2.0 * 3.1415926535897931)
						positions(1, totalpoints + j + 2) = distance + CDbl(Claddingdir_loc) * (width_left + Positioncal.CladWidth / 2.0 + meanderamp - layerheight * CDbl((i - 1S)) * Math.Tan(rightang)) * Math.Cos(coneangle) + tooloffset * Math.Sin(postureangle * 3.1415926535897931 / 180.0)
						positions(2, totalpoints + j + 2) = Positioncal.CrankThrow * Math.Cos((1.0 / CDbl(Positioncal.PPR) + totalangle + inioverweld_int / 100.0 * CDbl((passIndex - 1)) / CDbl(inipoints)) * 2.0 * 3.1415926535897931) + CDbl(vlvgeom) * diameter / 2.0 + layerheight * CDbl((i - 1S)) * Math.Cos(coneangle) - CDbl(Claddingdir_loc) * (width_left + Positioncal.CladWidth / 2.0 + meanderamp - layerheight * CDbl((i - 1S)) * Math.Tan(rightang)) * Math.Sin(coneangle) + tooloffset * Math.Cos(postureangle * 3.1415926535897931 / 180.0)
						positions(3, totalpoints + j + 2) = 90.0 + postureangle - CDbl(Claddingdir_loc) * rockang
						positions(4, totalpoints + j + 2) = CDbl(Ry)
						positions(5, totalpoints + j + 2) = CDbl(Rz)
					End If
					expositions(1, totalpoints + j + 2) = 331776.0 * (initialang / 360.0 + (1.0 / CDbl(Positioncal.PPR) + totalangle + inioverweld_int / 100.0 * CDbl((passIndex - 1)) / CDbl(inipoints)) * CDbl(Positioncal.DirectionFlg))
				Next
				Dim k As Integer = 1
				Dim num5 As Integer = 1
				Dim num6 As Integer = pointnumber
				For j As Integer = num5 To num6
					If Claddingdir_loc = 1S Then
						' The following expression was wrapped in a unchecked-expression
						' The following expression was wrapped in a checked-expression
						positions(0, totalpoints + inipoints + j + 2) = Positioncal.WorkXAxisOffset + CDbl(Positioncal.DirectionFlg) * Positioncal.CrankThrow * Math.Sin((1.0 / CDbl(Positioncal.PPR) + totalangle + inioverweld_int / 100.0 + CDbl((passIndex - 1)) / CDbl(Positioncal.PPR)) * 2.0 * 3.1415926535897931)
						positions(1, totalpoints + inipoints + j + 2) = distance + CDbl(Claddingdir_loc) * (width_right + pitch * CDbl((passIndex - 1)) / CDbl(Positioncal.PPR) + Positioncal.CladWidth / 2.0 + meanderamp - layerheight * CDbl((i - 1S)) * Math.Tan(leftang)) * Math.Cos(coneangle) + tooloffset * Math.Sin(postureangle * 3.1415926535897931 / 180.0)
						positions(2, totalpoints + inipoints + j + 2) = Positioncal.CrankThrow * Math.Cos((1.0 / CDbl(Positioncal.PPR) + totalangle + inioverweld_int / 100.0 + CDbl((passIndex - 1)) / CDbl(Positioncal.PPR)) * 2.0 * 3.1415926535897931) + CDbl(vlvgeom) * diameter / 2.0 + layerheight * CDbl((i - 1S)) * Math.Cos(coneangle) - CDbl(Claddingdir_loc) * (width_right + pitch * CDbl((passIndex - 1)) / CDbl(Positioncal.PPR) + Positioncal.CladWidth / 2.0 + meanderamp - layerheight * CDbl((i - 1S)) * Math.Tan(leftang)) * Math.Sin(coneangle) + tooloffset * Math.Cos(postureangle * 3.1415926535897931 / 180.0)
					Else
						' The following expression was wrapped in a unchecked-expression
						' The following expression was wrapped in a checked-expression
						positions(0, totalpoints + inipoints + j + 2) = Positioncal.WorkXAxisOffset + CDbl(Positioncal.DirectionFlg) * Positioncal.CrankThrow * Math.Sin((1.0 / CDbl(Positioncal.PPR) + totalangle + inioverweld_int / 100.0 + CDbl((passIndex - 1)) / CDbl(Positioncal.PPR)) * 2.0 * 3.1415926535897931)
						positions(1, totalpoints + inipoints + j + 2) = distance + CDbl(Claddingdir_loc) * (width_left + pitch * CDbl((passIndex - 1)) / CDbl(Positioncal.PPR) + Positioncal.CladWidth / 2.0 + meanderamp - layerheight * CDbl((i - 1S)) * Math.Tan(rightang)) * Math.Cos(coneangle) + tooloffset * Math.Sin(postureangle * 3.1415926535897931 / 180.0)
						positions(2, totalpoints + inipoints + j + 2) = Positioncal.CrankThrow * Math.Cos((1.0 / CDbl(Positioncal.PPR) + totalangle + inioverweld_int / 100.0 + CDbl((passIndex - 1)) / CDbl(Positioncal.PPR)) * 2.0 * 3.1415926535897931) + CDbl(vlvgeom) * diameter / 2.0 + layerheight * CDbl((i - 1S)) * Math.Cos(coneangle) - CDbl(Claddingdir_loc) * (width_left + pitch * CDbl((passIndex - 1)) / CDbl(Positioncal.PPR) + Positioncal.CladWidth / 2.0 + meanderamp - layerheight * CDbl((i - 1S)) * Math.Tan(rightang)) * Math.Sin(coneangle) + tooloffset * Math.Cos(postureangle * 3.1415926535897931 / 180.0)
					End If
					If k = 1 Then
						k = -1
					Else
						k = 1
					End If
					positions(3, totalpoints + inipoints + j + 2) = 90.0 + postureangle - CDbl(Claddingdir_loc) * rockang * (1.0 - CDbl((CInt((rockangvar * 2S)) * j)) / CDbl(pointnumber)) + CDbl(k) * Positioncal.Tiltangle
					positions(4, totalpoints + inipoints + j + 2) = CDbl(Ry)
					positions(5, totalpoints + inipoints + j + 2) = CDbl(Rz)
					expositions(1, totalpoints + inipoints + j + 2) = 331776.0 * (initialang / 360.0 + (1.0 / CDbl(Positioncal.PPR) + totalangle + inioverweld_int / 100.0 + CDbl((passIndex - 1)) / CDbl(Positioncal.PPR)) * CDbl(Positioncal.DirectionFlg))
				Next
				Dim num7 As Integer = 1
				Dim num8 As Integer = finpoints
				For j As Integer = num7 To num8
					If Claddingdir_loc = 1S Then
						If finaldistance = 0.0 Then
							' The following expression was wrapped in a unchecked-expression
							' The following expression was wrapped in a checked-expression
							positions(0, totalpoints + inipoints + pointnumber + j + 2) = Positioncal.WorkXAxisOffset + CDbl(Positioncal.DirectionFlg) * Positioncal.CrankThrow * Math.Sin((1.0 / CDbl(Positioncal.PPR) + totalangle + inioverweld_int / 100.0 + finoverweld_int / 100.0 * CDbl((passIndex - 1)) / CDbl(finpoints) + CDbl(pointnumber) / CDbl(Positioncal.PPR)) * 2.0 * 3.1415926535897931)
							positions(1, totalpoints + inipoints + pointnumber + j + 2) = distance + CDbl(Claddingdir_loc) * (width_right + width1 - Positioncal.CladWidth / 2.0 - meanderamp + layerheight * CDbl(i) * Math.Tan(rightang)) * Math.Cos(coneangle) + tooloffset * Math.Sin(postureangle * 3.1415926535897931 / 180.0)
							positions(2, totalpoints + inipoints + pointnumber + j + 2) = Positioncal.CrankThrow * Math.Cos((1.0 / CDbl(Positioncal.PPR) + totalangle + inioverweld_int / 100.0 + finoverweld_int / 100.0 * CDbl((passIndex - 1)) / CDbl(finpoints) + CDbl(pointnumber) / CDbl(Positioncal.PPR)) * 2.0 * 3.1415926535897931) + CDbl(vlvgeom) * diameter / 2.0 + layerheight * CDbl((i - 1S)) * Math.Cos(coneangle) - CDbl(Claddingdir_loc) * (width_right + width1 - Positioncal.CladWidth / 2.0 - meanderamp + layerheight * CDbl(i) * Math.Tan(rightang)) * Math.Sin(coneangle) + tooloffset * Math.Cos(postureangle * 3.1415926535897931 / 180.0)
							expositions(1, totalpoints + inipoints + pointnumber + j + 2) = 331776.0 * (initialang / 360.0 + (1.0 / CDbl(Positioncal.PPR) + totalangle + inioverweld_int / 100.0 + finoverweld_int / 100.0 * CDbl((passIndex - 1)) / CDbl(finpoints) + CDbl(pointnumber) / CDbl(Positioncal.PPR)) * CDbl(Positioncal.DirectionFlg))
						Else
							' The following expression was wrapped in a unchecked-expression
							' The following expression was wrapped in a checked-expression
							' The following expression was wrapped in a checked-expression
							positions(0, totalpoints + inipoints + pointnumber + j + 2) = Positioncal.WorkXAxisOffset + CDbl(Positioncal.DirectionFlg) * Positioncal.CrankThrow * Math.Sin((1.0 / CDbl(Positioncal.PPR) + totalangle + inioverweld_int / 100.0 + finoverweld_int / 100.0 * CDbl((passIndex - 1)) / CDbl(finpoints) + CDbl((pointnumber - 1)) / CDbl(Positioncal.PPR) + finaldistance) * 2.0 * 3.1415926535897931)
							positions(1, totalpoints + inipoints + pointnumber + j + 2) = distance + CDbl(Claddingdir_loc) * (width_right + width1 - Positioncal.CladWidth / 2.0 - meanderamp + layerheight * CDbl(i) * Math.Tan(rightang)) * Math.Cos(coneangle) + tooloffset * Math.Sin(postureangle * 3.1415926535897931 / 180.0)
							positions(2, totalpoints + inipoints + pointnumber + j + 2) = Positioncal.CrankThrow * Math.Cos((1.0 / CDbl(Positioncal.PPR) + totalangle + inioverweld_int / 100.0 + finoverweld_int / 100.0 * CDbl((passIndex - 1)) / CDbl(finpoints) + CDbl((pointnumber - 1)) / CDbl(Positioncal.PPR) + finaldistance) * 2.0 * 3.1415926535897931) + CDbl(vlvgeom) * diameter / 2.0 + layerheight * CDbl((i - 1S)) * Math.Cos(coneangle) - CDbl(Claddingdir_loc) * (width_right + width1 - Positioncal.CladWidth / 2.0 - meanderamp + layerheight * CDbl(i) * Math.Tan(rightang)) * Math.Sin(coneangle) + tooloffset * Math.Cos(postureangle * 3.1415926535897931 / 180.0)
							expositions(1, totalpoints + inipoints + pointnumber + j + 2) = 331776.0 * (initialang / 360.0 + (1.0 / CDbl(Positioncal.PPR) + totalangle + inioverweld_int / 100.0 + finoverweld_int / 100.0 * CDbl((passIndex - 1)) / CDbl(finpoints) + CDbl((pointnumber - 1)) / CDbl(Positioncal.PPR) + finaldistance) * CDbl(Positioncal.DirectionFlg))
						End If
					ElseIf finaldistance = 0.0 Then
						' The following expression was wrapped in a unchecked-expression
						' The following expression was wrapped in a checked-expression
						positions(0, totalpoints + inipoints + pointnumber + j + 2) = Positioncal.WorkXAxisOffset + CDbl(Positioncal.DirectionFlg) * Positioncal.CrankThrow * Math.Sin((1.0 / CDbl(Positioncal.PPR) + totalangle + inioverweld_int / 100.0 + finoverweld_int / 100.0 * CDbl((passIndex - 1)) / CDbl(finpoints) + CDbl(pointnumber) / CDbl(Positioncal.PPR)) * 2.0 * 3.1415926535897931)
						positions(1, totalpoints + inipoints + pointnumber + j + 2) = distance + CDbl(Claddingdir_loc) * (width_left + width1 - Positioncal.CladWidth / 2.0 - meanderamp + layerheight * CDbl(i) * Math.Tan(leftang)) * Math.Cos(coneangle) + tooloffset * Math.Sin(postureangle * 3.1415926535897931 / 180.0)
						positions(2, totalpoints + inipoints + pointnumber + j + 2) = Positioncal.CrankThrow * Math.Cos((1.0 / CDbl(Positioncal.PPR) + totalangle + inioverweld_int / 100.0 + finoverweld_int / 100.0 * CDbl((passIndex - 1)) / CDbl(finpoints) + CDbl(pointnumber) / CDbl(Positioncal.PPR)) * 2.0 * 3.1415926535897931) + CDbl(vlvgeom) * diameter / 2.0 + layerheight * CDbl((i - 1S)) * Math.Cos(coneangle) - CDbl(Claddingdir_loc) * (width_left + width1 - Positioncal.CladWidth / 2.0 - meanderamp + layerheight * CDbl(i) * Math.Tan(leftang)) * Math.Sin(coneangle) + tooloffset * Math.Cos(postureangle * 3.1415926535897931 / 180.0)
						expositions(1, totalpoints + inipoints + pointnumber + j + 2) = 331776.0 * (initialang / 360.0 + (1.0 / CDbl(Positioncal.PPR) + totalangle + inioverweld_int / 100.0 + finoverweld_int / 100.0 * CDbl((passIndex - 1)) / CDbl(finpoints) + CDbl(pointnumber) / CDbl(Positioncal.PPR)) * CDbl(Positioncal.DirectionFlg))
					Else
						' The following expression was wrapped in a unchecked-expression
						' The following expression was wrapped in a checked-expression
						' The following expression was wrapped in a checked-expression
						positions(0, totalpoints + inipoints + pointnumber + j + 2) = Positioncal.WorkXAxisOffset + CDbl(Positioncal.DirectionFlg) * Positioncal.CrankThrow * Math.Sin((1.0 / CDbl(Positioncal.PPR) + totalangle + inioverweld_int / 100.0 + finoverweld_int / 100.0 * CDbl((passIndex - 1)) / CDbl(finpoints) + CDbl((pointnumber - 1)) / CDbl(Positioncal.PPR) + finaldistance) * 2.0 * 3.1415926535897931)
						positions(1, totalpoints + inipoints + pointnumber + j + 2) = distance + CDbl(Claddingdir_loc) * (width_left + width1 - Positioncal.CladWidth / 2.0 - meanderamp + layerheight * CDbl(i) * Math.Tan(leftang)) * Math.Cos(coneangle) + tooloffset * Math.Sin(postureangle * 3.1415926535897931 / 180.0)
						positions(2, totalpoints + inipoints + pointnumber + j + 2) = Positioncal.CrankThrow * Math.Cos((1.0 / CDbl(Positioncal.PPR) + totalangle + inioverweld_int / 100.0 + finoverweld_int / 100.0 * CDbl((passIndex - 1)) / CDbl(finpoints) + CDbl((pointnumber - 1)) / CDbl(Positioncal.PPR) + finaldistance) * 2.0 * 3.1415926535897931) + CDbl(vlvgeom) * diameter / 2.0 + layerheight * CDbl((i - 1S)) * Math.Cos(coneangle) - CDbl(Claddingdir_loc) * (width_left + width1 - Positioncal.CladWidth / 2.0 - meanderamp + layerheight * CDbl(i) * Math.Tan(leftang)) * Math.Sin(coneangle) + tooloffset * Math.Cos(postureangle * 3.1415926535897931 / 180.0)
						expositions(1, totalpoints + inipoints + pointnumber + j + 2) = 331776.0 * (initialang / 360.0 + (1.0 / CDbl(Positioncal.PPR) + totalangle + inioverweld_int / 100.0 + finoverweld_int / 100.0 * CDbl((passIndex - 1)) / CDbl(finpoints) + CDbl((pointnumber - 1)) / CDbl(Positioncal.PPR) + finaldistance) * CDbl(Positioncal.DirectionFlg))
					End If
					positions(3, totalpoints + inipoints + pointnumber + j + 2) = 90.0 + postureangle - CDbl(Claddingdir_loc) * rockang * (1.0 - CDbl((CInt(((1S - rockangvar) * 2S)) * j)) / CDbl(finpoints) - CDbl((rockangvar * 2S)))
					positions(4, totalpoints + inipoints + pointnumber + j + 2) = CDbl(Ry)
					positions(5, totalpoints + inipoints + pointnumber + j + 2) = CDbl(Rz)
				Next
				If CInt(i) = layerno Then
					If Claddingdir_loc = 1S Then
						If finaldistance = 0.0 Then
							' The following expression was wrapped in a unchecked-expression
							positions(0, totalpoints + inipoints + pointnumber + finpoints + 3) = Positioncal.WorkXAxisOffset + CDbl(Positioncal.DirectionFlg) * Positioncal.CrankThrow * Math.Sin((1.0 / CDbl(Positioncal.PPR) + totalangle + inioverweld_int / 100.0 + CDbl(pointnumber) / CDbl(Positioncal.PPR) + finoverweld_int / 100.0) * 2.0 * 3.1415926535897931)
							positions(1, totalpoints + inipoints + pointnumber + finpoints + 3) = distance + CDbl(Claddingdir_loc) * (width_right + width1 - Positioncal.CladWidth / 2.0 - meanderamp + layerheight * CDbl(i) * Math.Tan(rightang)) * Math.Cos(coneangle) + tooloffset * Math.Sin(postureangle * 3.1415926535897931 / 180.0)
							positions(2, totalpoints + inipoints + pointnumber + finpoints + 3) = Positioncal.CrankThrow * Math.Cos((1.0 / CDbl(Positioncal.PPR) + totalangle + inioverweld_int / 100.0 + CDbl(pointnumber) / CDbl(Positioncal.PPR) + finoverweld_int / 100.0) * 2.0 * 3.1415926535897931) + CDbl(vlvgeom) * diameter / 2.0 + layerheight * CDbl((i - 1S)) * Math.Cos(coneangle) - CDbl(Claddingdir_loc) * (width_right + width1 - Positioncal.CladWidth / 2.0 - meanderamp + layerheight * CDbl(i) * Math.Tan(rightang)) * Math.Sin(coneangle) + tooloffset * Math.Cos(postureangle * 3.1415926535897931 / 180.0)
							expositions(1, totalpoints + inipoints + pointnumber + finpoints + 3) = 331776.0 * (initialang / 360.0 + (1.0 / CDbl(Positioncal.PPR) + totalangle + inioverweld_int / 100.0 + CDbl(pointnumber) / CDbl(Positioncal.PPR) + finoverweld_int / 100.0) * CDbl(Positioncal.DirectionFlg))
						Else
							' The following expression was wrapped in a unchecked-expression
							' The following expression was wrapped in a checked-expression
							positions(0, totalpoints + inipoints + pointnumber + finpoints + 3) = Positioncal.WorkXAxisOffset + CDbl(Positioncal.DirectionFlg) * Positioncal.CrankThrow * Math.Sin((1.0 / CDbl(Positioncal.PPR) + totalangle + inioverweld_int / 100.0 + CDbl((pointnumber - 1)) / CDbl(Positioncal.PPR) + finaldistance + finoverweld_int / 100.0) * 2.0 * 3.1415926535897931)
							positions(1, totalpoints + inipoints + pointnumber + finpoints + 3) = distance + CDbl(Claddingdir_loc) * (width_right + width1 - Positioncal.CladWidth / 2.0 - meanderamp + layerheight * CDbl(i) * Math.Tan(rightang)) * Math.Cos(coneangle) + tooloffset * Math.Sin(postureangle * 3.1415926535897931 / 180.0)
							positions(2, totalpoints + inipoints + pointnumber + finpoints + 3) = Positioncal.CrankThrow * Math.Cos((1.0 / CDbl(Positioncal.PPR) + totalangle + inioverweld_int / 100.0 + CDbl((pointnumber - 1)) / CDbl(Positioncal.PPR) + finaldistance + finoverweld_int / 100.0) * 2.0 * 3.1415926535897931) + CDbl(vlvgeom) * diameter / 2.0 + layerheight * CDbl((i - 1S)) * Math.Cos(coneangle) - CDbl(Claddingdir_loc) * (width_right + width1 - Positioncal.CladWidth / 2.0 - meanderamp + layerheight * CDbl(i) * Math.Tan(rightang)) * Math.Sin(coneangle) + tooloffset * Math.Cos(postureangle * 3.1415926535897931 / 180.0)
							expositions(1, totalpoints + inipoints + pointnumber + finpoints + 3) = 331776.0 * (initialang / 360.0 + (1.0 / CDbl(Positioncal.PPR) + totalangle + inioverweld_int / 100.0 + CDbl((pointnumber - 1)) / CDbl(Positioncal.PPR) + finaldistance + finoverweld_int / 100.0) * CDbl(Positioncal.DirectionFlg))
						End If
					ElseIf finaldistance = 0.0 Then
						' The following expression was wrapped in a unchecked-expression
						positions(0, totalpoints + inipoints + pointnumber + finpoints + 3) = Positioncal.WorkXAxisOffset + CDbl(Positioncal.DirectionFlg) * Positioncal.CrankThrow * Math.Sin((1.0 / CDbl(Positioncal.PPR) + totalangle + inioverweld_int / 100.0 + CDbl(pointnumber) / CDbl(Positioncal.PPR) + finoverweld_int / 100.0) * 2.0 * 3.1415926535897931)
						positions(1, totalpoints + inipoints + pointnumber + finpoints + 3) = distance + CDbl(Claddingdir_loc) * (width_left + width1 - Positioncal.CladWidth / 2.0 - meanderamp + layerheight * CDbl(i) * Math.Tan(leftang)) * Math.Cos(coneangle) + tooloffset * Math.Sin(postureangle * 3.1415926535897931 / 180.0)
						positions(2, totalpoints + inipoints + pointnumber + finpoints + 3) = Positioncal.CrankThrow * Math.Cos((1.0 / CDbl(Positioncal.PPR) + totalangle + inioverweld_int / 100.0 + CDbl(pointnumber) / CDbl(Positioncal.PPR) + finoverweld_int / 100.0) * 2.0 * 3.1415926535897931) + CDbl(vlvgeom) * diameter / 2.0 + layerheight * CDbl((i - 1S)) * Math.Cos(coneangle) - CDbl(Claddingdir_loc) * (width_left + width1 - Positioncal.CladWidth / 2.0 - meanderamp + layerheight * CDbl(i) * Math.Tan(leftang)) * Math.Sin(coneangle) + tooloffset * Math.Cos(postureangle * 3.1415926535897931 / 180.0)
						expositions(1, totalpoints + inipoints + pointnumber + finpoints + 3) = 331776.0 * (initialang / 360.0 + (1.0 / CDbl(Positioncal.PPR) + totalangle + inioverweld_int / 100.0 + CDbl(pointnumber) / CDbl(Positioncal.PPR) + finoverweld_int / 100.0) * CDbl(Positioncal.DirectionFlg))
					Else
						' The following expression was wrapped in a unchecked-expression
						' The following expression was wrapped in a checked-expression
						positions(0, totalpoints + inipoints + pointnumber + finpoints + 3) = Positioncal.WorkXAxisOffset + CDbl(Positioncal.DirectionFlg) * Positioncal.CrankThrow * Math.Sin((1.0 / CDbl(Positioncal.PPR) + totalangle + inioverweld_int / 100.0 + CDbl((pointnumber - 1)) / CDbl(Positioncal.PPR) + finaldistance + finoverweld_int / 100.0) * 2.0 * 3.1415926535897931)
						positions(1, totalpoints + inipoints + pointnumber + finpoints + 3) = distance + CDbl(Claddingdir_loc) * (width_left + width1 - Positioncal.CladWidth / 2.0 - meanderamp + layerheight * CDbl(i) * Math.Tan(leftang)) * Math.Cos(coneangle) + tooloffset * Math.Sin(postureangle * 3.1415926535897931 / 180.0)
						positions(2, totalpoints + inipoints + pointnumber + finpoints + 3) = Positioncal.CrankThrow * Math.Cos((1.0 / CDbl(Positioncal.PPR) + totalangle + inioverweld_int / 100.0 + CDbl((pointnumber - 1)) / CDbl(Positioncal.PPR) + finaldistance + finoverweld_int / 100.0) * 2.0 * 3.1415926535897931) + CDbl(vlvgeom) * diameter / 2.0 + layerheight * CDbl((i - 1S)) * Math.Cos(coneangle) - CDbl(Claddingdir_loc) * (width_left + width1 - Positioncal.CladWidth / 2.0 - meanderamp + layerheight * CDbl(i) * Math.Tan(leftang)) * Math.Sin(coneangle) + tooloffset * Math.Cos(postureangle * 3.1415926535897931 / 180.0)
						expositions(1, totalpoints + inipoints + pointnumber + finpoints + 3) = 331776.0 * (initialang / 360.0 + (1.0 / CDbl(Positioncal.PPR) + totalangle + inioverweld_int / 100.0 + CDbl((pointnumber - 1)) / CDbl(Positioncal.PPR) + finaldistance + finoverweld_int / 100.0) * CDbl(Positioncal.DirectionFlg))
					End If
				End If
				positions(3, totalpoints + inipoints + pointnumber + finpoints + 3) = 90.0 + postureangle + CDbl(Claddingdir_loc) * rockang
				positions(4, totalpoints + inipoints + pointnumber + finpoints + 3) = CDbl(Ry)
				positions(5, totalpoints + inipoints + pointnumber + finpoints + 3) = CDbl(Rz)
				If Claddingdir_loc = 1S Then
					Claddingdir_loc = -1S
				Else
					Claddingdir_loc = 1S
				End If
			Next
			positions(0, totalpoints + inipoints + pointnumber + finpoints + 4) = CDbl(Positioncal.HomePos(0))
			positions(1, totalpoints + inipoints + pointnumber + finpoints + 4) = CDbl(Positioncal.HomePos(1))
			positions(2, totalpoints + inipoints + pointnumber + finpoints + 4) = CDbl(Positioncal.HomePos(2))
			positions(3, totalpoints + inipoints + pointnumber + finpoints + 4) = CDbl(Positioncal.HomePos(3))
			positions(4, totalpoints + inipoints + pointnumber + finpoints + 4) = CDbl(Positioncal.HomePos(4))
			positions(5, totalpoints + inipoints + pointnumber + finpoints + 4) = CDbl(Positioncal.HomePos(5))
			expositions(1, 0) = 331776.0 * initialang / 360.0
			expositions(1, 1) = 331776.0 * initialang / 360.0
			expositions(1, 2) = 331776.0 * initialang / 360.0
			expositions(1, totalpoints + inipoints + pointnumber + finpoints + 4) = 0.0
			Dim meanderfreq As Double = processspeed / (4.0 * meanderamp)
			Dim power As Double = 0.0025 * CDbl(Positioncal.LaserPowerIni) + -1.1111
			Dim feed As Double = 0.1 * Positioncal.PowderFeed
			Dim beamdia As Double = 2.3596 * Positioncal.CladWidth + -4.4599
			Dim headertxt As String
			Dim mainprogtxt As String
			Positioncal.TotalSteps = totalpoints + inipoints + pointnumber + finpoints + 5
			headertxt = String.Concat(New String() {"/JOB" & vbCrLf & "//NAME HOSTMOV" & vbCrLf & "//POS" & vbCrLf & "///NPOS ", Conversions.ToString(totalpoints + inipoints + pointnumber + finpoints + 5), ",0,", Conversions.ToString(totalpoints + inipoints + pointnumber + finpoints + 5), ",2,0,2" & vbCrLf & "///USER ", stationposition.ToString("#"), vbCrLf & "///TOOL ", Positioncal.Toolno.ToString("#0"), vbCrLf & "///POSTYPE USER ", stationposition.ToString("#"), vbCrLf & "///RECTAN" & vbCrLf & "///RCONF 1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0" & vbCrLf})
			Dim num9 As Integer = 0
			Dim num10 As Integer = totalpoints + inipoints + pointnumber + finpoints + 3
			Dim i As Short
			For ind As Integer = num9 To num10
				headertxt = headertxt + "C" + ind.ToString("0000#=")
				i = 0S

				Do
					headertxt = headertxt + positions(CInt(i), ind).ToString("#0.000;-#0.000;0.000") + ","
					i += 1S
				Loop While i <= 2S
				i = 3S
				Do
					headertxt = headertxt + positions(CInt(i), ind).ToString("#0.00;-#0.00;0.00") + ","
					i += 1S
				Loop While i <= 4S
				headertxt = headertxt + positions(5, ind).ToString("#0.00;-#0.00;0.00") + vbCrLf

			Next
			headertxt += "///POSTYPE PULSE" & vbCrLf & "///PULSE" & vbCrLf
			headertxt = headertxt + "C" + (totalpoints + inipoints + pointnumber + finpoints + 4).ToString("0000#=")
			i = 0S
			Do
				headertxt = headertxt + positions(CInt(i), totalpoints + inipoints + pointnumber + finpoints + 4).ToString("#;-#;0") + ","

				i += 1S

			Loop While i <= 4S
			headertxt = headertxt + positions(5, totalpoints + inipoints + pointnumber + finpoints + 4).ToString("#;-#;0") + vbCrLf
			Dim num11 As Integer = 0
			Dim num12 As Integer = totalpoints + inipoints + pointnumber + finpoints + 4
			For ind As Integer = num11 To num12
				headertxt = String.Concat(New String() {headertxt, "EC", ind.ToString("0000#="), Tiltaxispos.ToString(), ",", expositions(1, ind).ToString("#;-#;0"), vbCrLf})
			Next
			headertxt = String.Concat(New String() {headertxt, "///POSTYPE BASE" & vbCrLf & "///RECTAN" & vbCrLf & "P0000=0.000,0.000,0.000,0.00,0.00,0.00" & vbCrLf & "P0001=0.000,0.000,0.000,0.00,0.00,0.00" & vbCrLf & "///POSTYPE PULSE" & vbCrLf & "///PULSE" & vbCrLf & "EX0000=0,0" & vbCrLf & "EX0001=0,0" & vbCrLf & "//INST" & vbCrLf & "///DATE ", mydatetime.ToString("yyyy/MM/dd HH:mm"), vbCrLf & "///COMM SUB TASK TO HOSTMAST" & vbCrLf & "///ATTR SC,RW,RJ" & vbCrLf & "////FRAME USER ", stationposition.ToString("#"), vbCrLf & "///GROUP1 RB1" & vbCrLf & "///GROUP2 ST1" & vbCrLf & "///LVARS 0,0,0,0,0,0,0,0"})
			mainprogtxt = "NOP" & vbCrLf & "EI LEVEL= 1" & vbCrLf
			If meanderflg = 1S Then
				' The following expression was wrapped in a unchecked-expression
				' The following expression was wrapped in a unchecked-expression
				mainprogtxt = String.Concat(New String() {mainprogtxt, "SETFILE WEV#(1) (4) ", Conversions.ToString(CInt(Math.Round(meanderfreq * 10.0))), vbCrLf & "SETFILE WEV#(1) (5) ", Conversions.ToString(CInt(Math.Round(meanderamp * 1000.0))), vbCrLf & "SETFILE WEV#(1) (8) 0" & vbCrLf & "SETFILE WEV#(1) (9) 0" & vbCrLf})
			End If
			mainprogtxt = String.Concat(New String() {mainprogtxt, "CALL JOB:STRESET" & vbCrLf & "GETS PX000 $PX000" & vbCrLf & "CNVRT PX000 PX000 RF" & vbCrLf & "GETE D000 P000 (3)" & vbCrLf & "ADD D000 ", (Positioncal.IniZAxisOffset * 1000.0).ToString("#0"), vbCrLf & "JUMP *LABEL1 IF D000<=", Positioncal.MaxZRobotPos.ToString("#"), vbCrLf & "SET D000 ", Positioncal.MaxZRobotPos.ToString("#"), vbCrLf & "*LABEL1" & vbCrLf & "SETE P000 (3) D000" & vbCrLf & "MOVL P000 V=", Positioncal.IdleSpeed.ToString("#0.0"), " PL=0  +MOVJ EX000 VJ=100.00" & vbCrLf & "GETS PX000 $PX000" & vbCrLf & "GETE D000 P000 (4)" & vbCrLf & "CALL JOB:ARMCOR IF D000>=", 184115.0.ToString("#"), vbCrLf & "CALL JOB:ARMCOR IF D000<=-", 184115.0.ToString("#"), vbCrLf & "GETPOS PX000 STEP#(2)" & vbCrLf & "CNVRT PX000 PX000 RF" & vbCrLf & "GETE D000 P000 (3)" & vbCrLf & "JUMP *LABEL2 IF D000<", Positioncal.MaxZRobotPos.ToString("#"), vbCrLf & "SUB D000 ", Positioncal.MaxZRobotPos.ToString("#"), vbCrLf & "MUL D000 -1" & vbCrLf & "SETE P000 (1) 0" & vbCrLf & "SETE P000 (2) 0" & vbCrLf & "SETE P000 (3) D000" & vbCrLf & "SETE P000 (4) 0" & vbCrLf & "SETE P000 (5) 0" & vbCrLf & "SETE P000 (6) 0" & vbCrLf & "SFTON RB1 P000 RF" & vbCrLf & "*LABEL2" & vbCrLf & "MOVL C00000 V=", Positioncal.IdleSpeed.ToString("#0.0"), " PL=0 NWAIT  +MOVJ EC00000 VJ=100.00" & vbCrLf & "DOUT OT#(1) ON" & vbCrLf & "DOUT OT#(8) ON" & vbCrLf & "JUMP *PILOTON IF IN#(2)=ON" & vbCrLf & "WAIT IN#(6)=ON T=5.00" & vbCrLf & "JUMP *END IF IN#(6)=OFF" & vbCrLf})
			If Positioncal.PowderJar = 1S Then
				mainprogtxt += "DOUT OT#(4) ON" & vbCrLf & "DOUT OT#(6) ON" & vbCrLf
			Else
				mainprogtxt += "DOUT OT#(5) ON" & vbCrLf & "DOUT OT#(7) ON" & vbCrLf
			End If
			mainprogtxt = String.Concat(New String() {mainprogtxt, "TIMER T=", Positioncal.PowderSettling1.ToString("#0.00"), vbCrLf & "*PILOTON" & vbCrLf & "SFTOF RB1" & vbCrLf & "MOVL C00001 V=", Positioncal.ApproachSpeed.ToString("#0.0"), " PL=0 DEC=20  +MOVJ EC00001 VJ=100.00" & vbCrLf & "WAIT IN#(1)=ON T=5.00" & vbCrLf})
			mainprogtxt = mainprogtxt + "TIMER T=" + Positioncal.PowderSettling2.ToString("#0.00") + vbCrLf & "EI LEVEL= 3" & vbCrLf & "*STARTL" & vbCrLf & "DOUT OT#(2) ON" & vbCrLf
			If meanderflg = 1S Then
				processspeed = processspeed * Positioncal.MeanderPitch / (4.0 * meanderamp)
			End If
			Dim num13 As Integer = 2
			Dim num14 As Integer = totalpoints + inipoints + pointnumber + finpoints + 3
			For j As Integer = num13 To num14
				If j = 2 Then
					mainprogtxt = String.Concat(New String() {mainprogtxt, "SMOVC C", j.ToString("0000#"), " V=", Positioncal.ApproachSpeed.ToString("#0.0;-#.0;0.0"), " PL=", Positioncal.PositionLevel.ToString("#"), " +MOVJ EC", j.ToString("0000#"), vbCrLf})
				ElseIf j = 3 Then
					' The following expression was wrapped in a unchecked-expression
					mainprogtxt = String.Concat(New String() {mainprogtxt, "SMOVC C", j.ToString("0000#"), " V=", Positioncal.ApproachSpeed.ToString("#0.0;-#.0;0.0"), " PL=", Positioncal.PositionLevel.ToString("#"), " +MOVJ EC", j.ToString("0000#"), vbCrLf & "ARCON AC=", (feed * (1.0 - CDbl(Positioncal.IniPowderRed) / 100.0) * 100.0).ToString("#0"), " AV=", ((1.0 + CDbl(Positioncal.IniOverPower) / 100.0) * power).ToString("#0.0"), vbCrLf & "ARCCTS AC=", (feed * 100.0).ToString("#0"), " AV=", power.ToString("#0.0"), " AN3=", beamdia.ToString("#0.0"), " DIS=", Positioncal.IniOverPowerDis.ToString("#0.0"), vbCrLf})
					If meanderflg = 1S Then
						mainprogtxt += "SWVON WEV#(1)" & vbCrLf
					End If
				ElseIf j = totalpoints + inipoints + pointnumber + finpoints + 3 Then
					mainprogtxt = String.Concat(New String() {mainprogtxt, "SMOVC C", j.ToString("0000#"), " V=", processspeed.ToString("#0.0;-#.0;0.0"), " PL=", Positioncal.PositionLevel.ToString("#"), " NWAIT  +MOVJ EC", j.ToString("0000#"), vbCrLf})
				Else
					mainprogtxt = String.Concat(New String() {mainprogtxt, "SMOVC C", j.ToString("0000#"), " V=", processspeed.ToString("#0.0;-#.0;0.0"), " PL=", Positioncal.PositionLevel.ToString("#"), " +MOVJ EC", j.ToString("0000#"), vbCrLf})
				End If

				' The following expression was wrapped in a checked-expression
				If j >= Positioncal.PPR + 2 And CDbl(Positioncal.LaserReductionTrackNo) >= CDbl((j - 2)) / CDbl(Positioncal.PPR) And Math.IEEERemainder(CDbl((j + 2)), CDbl(Positioncal.PPR)) = 0.0 AndAlso (Positioncal.IniPowderRed <> 0 Or Positioncal.IniOverPower <> 0 Or Positioncal.LaserPowerIni <> Positioncal.LaserPowerFin) Then
					' The following expression was wrapped in a checked-expression
					' The following expression was wrapped in a checked-expression
					power = (CDbl(Positioncal.LaserPowerIni) - CDbl((Positioncal.LaserPowerIni - Positioncal.LaserPowerFin)) / CDbl(Positioncal.LaserReductionTrackNo) * CDbl((j - 2)) / CDbl(Positioncal.PPR)) * 0.0025 + -1.1111
					mainprogtxt = String.Concat(New String() {mainprogtxt, "ARCSET AC=", (feed * 100.0).ToString("#0"), " AV=", power.ToString("#0.0"), " AN3=", beamdia.ToString("#0.0"), vbCrLf})
				End If
				If j = totalpoints + inipoints + pointnumber + finpoints + 2 AndAlso (Positioncal.FinOverPower <> 0 Or Positioncal.FinPowderRed <> 0) Then
					power = 0.0025 * CDbl(Positioncal.LaserPowerFin) * (1.0 + CDbl(Positioncal.FinOverPower) / 100.0) + -1.1111
					feed = 0.1 * (Positioncal.PowderFeed * CDbl((100 - Positioncal.FinPowderRed)) / 100.0)
					mainprogtxt = String.Concat(New String() {mainprogtxt, "ARCCTE AC=", (feed * 100.0).ToString("#0"), " AV=", power.ToString("#0.0"), " AN3=", beamdia.ToString("#0.0"), " DIS=", Positioncal.FinOverPowerDis.ToString("#0.0"), vbCrLf})
				End If
				If (If((-If(((j = totalpoints + inipoints + pointnumber + finpoints + 3) > False), 1S, 0S)), 1S, 0S) And meanderflg) <> 0S Then
					mainprogtxt += "SWVOF" & vbCrLf
				End If

			Next
			mainprogtxt = String.Concat(New String() {mainprogtxt, "DI LEVEL= 2" & vbCrLf & "JUMP *END" & vbCrLf & "*QVERROR" & vbCrLf & "*END" & vbCrLf & "ARCOF" & vbCrLf & "DOUT OG#(1) 0" & vbCrLf & "DOUT OG#(2) 0" & vbCrLf & "CALL JOB:STRESET" & vbCrLf & "GETS PX000 $PX000" & vbCrLf & "CNVRT PX000 PX000 RF" & vbCrLf & "GETE D000 P000 (3)" & vbCrLf & "ADD D000 ", (Positioncal.IniZAxisOffset * 1000.0).ToString("#0"), vbCrLf & "JUMP *LABEL3 IF D000<=", Positioncal.MaxZRobotPos.ToString("#"), vbCrLf & "SET D000 ", Positioncal.MaxZRobotPos.ToString("#"), vbCrLf & "*LABEL3" & vbCrLf & "SETE P000 (3) D000" & vbCrLf & "MOVL P000 V=", Positioncal.ApproachSpeed.ToString("#0.0"), " PL=0  +MOVJ EX000 VJ=100.00" & vbCrLf & "GETE D000 P000 (1)" & vbCrLf & "ADD D000 ", (Positioncal.IniXAxisOffset * 1000.0).ToString("#"), vbCrLf & "SETE P000 (1) D000" & vbCrLf & "MOVL P000 V=", Positioncal.ApproachSpeed.ToString("#0.0"), " PL=0  +MOVJ EX000 VJ=100.00" & vbCrLf & "MOVL C", (totalpoints + inipoints + pointnumber + finpoints + 4).ToString("0000#"), " V=", Positioncal.IdleSpeed.ToString("#0.0"), " PL=0  +MOVJ EC", (totalpoints + inipoints + pointnumber + finpoints + 4).ToString("0000#"), " VJ=100.00" & vbCrLf & "END"})
			Try
				FileSystem.FileOpen(1, Positioncal.BasePath + "hostmov.jbi", OpenMode.Output, OpenAccess.[Default], OpenShare.[Default], -1)
				FileSystem.PrintLine(1, New Object() {headertxt})
				FileSystem.PrintLine(1, New Object() {mainprogtxt})
				FileSystem.FileClose(New Integer() {1})
				Positioncal.ControlGroup = 0S
			Catch ex As Exception
				Interaction.MsgBox("Job saving has failed due to the following reason: " + ex.Message, MsgBoxStyle.Exclamation, Nothing)
			End Try
		End Sub

		' Token: 0x06000565 RID: 1381 RVA: 0x0000BD98 File Offset: 0x0000A198
		<MethodImpl(MethodImplOptions.NoInlining Or MethodImplOptions.NoOptimization)>
		Public Sub crankclad2(diameter As Double, crankthrow As Double, width1 As Double, distance As Double, pitch As Double, processspeed As Double, leftang As Double, rightang As Double, layerheight As Double, layerno As Integer, intoverweld As Double, rockang As Double, postureangle As Double, coneangle As Double, inioverweld As Single, finoverweld As Single, meanderamp As Double, meanderflg As Short, initialang As Double, tooloffset As Double, rockangvar As Short, hWnd As Integer)
			Dim robotctr As Short() = New Short(7) {}
			Dim stationctr As Short() = New Short(15) {}
			Dim positions As Double(,) = New Double(6, 11) {}
			Dim expositions As Double(,) = New Double(6, 11) {}
			Dim totalpoints As Integer = 0
			Dim totalangle As Double = 0.0
			Dim Ry As Double = Positioncal.WorkYAxisTilt
			Dim Rz As Double = Positioncal.WorkZAxisYaw
			Dim mydatetime As DateTime = DateAndTime.Now
			coneangle = coneangle * 3.1415926535897931 / 180.0
			Dim Claddingdir_loc As Short = CShort(Positioncal.CladdingDir)
			If meanderflg = 0S Then
				meanderamp = 0.0
			End If
			Select Case Positioncal.StationPosition
			End Select
			positions(0, 0) = Positioncal.IniXAxisOffset
			positions(1, 0) = distance + CDbl(Claddingdir_loc) * (Positioncal.CladWidth / 2.0 + meanderamp) * Math.Cos(coneangle) + Positioncal.IniYAxisOffset
			positions(2, 0) = crankthrow + diameter / 2.0 - (Positioncal.CladWidth / 2.0 + meanderamp) * Math.Sin(coneangle) + Positioncal.IniZAxisOffset
			positions(3, 0) = 90.0 + postureangle - CDbl(Claddingdir_loc) * rockang
			positions(4, 0) = Ry
			positions(5, 0) = Rz
			positions(0, 1) = Positioncal.IniXAxisOffset
			positions(1, 1) = distance + CDbl(Claddingdir_loc) * (Positioncal.CladWidth / 2.0 + meanderamp) * Math.Cos(coneangle) + tooloffset * Math.Sin(coneangle)
			positions(2, 1) = crankthrow + diameter / 2.0 - (Positioncal.CladWidth / 2.0 + meanderamp) * Math.Sin(coneangle) + tooloffset * Math.Cos(coneangle)
			positions(3, 1) = 90.0 + postureangle - CDbl(Claddingdir_loc) * rockang
			positions(4, 1) = Ry
			positions(5, 1) = Rz
			positions(0, 2) = Positioncal.WorkXAxisOffset
			positions(1, 2) = distance + CDbl(Claddingdir_loc) * (Positioncal.CladWidth / 2.0 + meanderamp) * Math.Cos(coneangle) + tooloffset * Math.Sin(coneangle)
			positions(2, 2) = crankthrow + diameter / 2.0 - (Positioncal.CladWidth / 2.0 + meanderamp) * Math.Sin(coneangle) + tooloffset * Math.Cos(coneangle)
			positions(3, 2) = 90.0 + postureangle - CDbl(Claddingdir_loc) * rockang
			positions(4, 2) = Ry
			positions(5, 2) = Rz
			Dim width_left As Double
			Dim width_right As Double
			If Claddingdir_loc = 1S Then
				width_left = -width1
				width_right = 0.0
			Else
				width_left = 0.0
				width_right = -width1
			End If
			Dim num As Short = 1S
			Dim num2 As Short = CShort(layerno)
			Dim inipoints As Integer
			Dim pointnumber As Integer
			Dim finpoints As Integer
			For layerIndex As Short = num To num2
				Dim finaldistance As Double
				If layerIndex <> 1S Then
					' The following expression was wrapped in a checked-statement
					totalpoints += inipoints + pointnumber + finpoints
					If finaldistance = 0.0 Then
						Dim inioverweld_int As Double
						Dim finoverweld_int As Double
						totalangle += inioverweld_int / 100.0 + CDbl(pointnumber) / CDbl(Positioncal.PPR) + finoverweld_int / 100.0
					Else
						Dim inioverweld_int As Double
						Dim finoverweld_int As Double
						totalangle += inioverweld_int / 100.0 + CDbl((pointnumber - 1)) / CDbl(Positioncal.PPR) + finaldistance + finoverweld_int / 100.0
					End If
				End If
				Dim rotations As Double
				If Claddingdir_loc = 1S Then
					' The following expression was wrapped in a checked-expression
					rotations = Math.Round((width1 - Positioncal.CladWidth - 2.0 * meanderamp + layerheight * (CDbl((layerIndex - 1S)) * Math.Tan(leftang) + CDbl(layerIndex) * Math.Tan(rightang))) / pitch, 3)
				Else
					' The following expression was wrapped in a checked-expression
					rotations = Math.Round((width1 - Positioncal.CladWidth - 2.0 * meanderamp + layerheight * (CDbl(layerIndex) * Math.Tan(leftang) + CDbl((layerIndex - 1S)) * Math.Tan(rightang))) / pitch, 3)
				End If
				If rotations < 0.0 Then
					rotations = 0.0
				End If
				finaldistance = rotations - Conversion.Int(rotations * CDbl(Positioncal.PPR)) / CDbl(Positioncal.PPR)
				If finaldistance < 0.015 And finaldistance > 0.0 Then
					rotations = Conversion.Int(rotations * CDbl(Positioncal.PPR)) / CDbl(Positioncal.PPR)
					If Claddingdir_loc = 1S Then
						' The following expression was wrapped in a checked-expression
						pitch = (width1 - Positioncal.CladWidth - 2.0 * meanderamp + layerheight * (CDbl((i - 1S)) * Math.Tan(leftang) + CDbl(i) * Math.Tan(rightang))) / rotations
					Else
						' The following expression was wrapped in a checked-expression
						pitch = (width1 - Positioncal.CladWidth - 2.0 * meanderamp + layerheight * (CDbl(i) * Math.Tan(leftang) + CDbl((i - 1S)) * Math.Tan(rightang))) / rotations
					End If
					finaldistance = 0.0
				End If
				pointnumber = CInt(Math.Round(Math.Ceiling(rotations * CDbl(Positioncal.PPR))))
				Dim inioverweld_int As Double
				If i = 1S Then
					inioverweld_int = CDbl(inioverweld)
				Else
					inioverweld_int = 0.0
				End If
				inipoints = CInt(Math.Round(Math.Round(inioverweld_int / 100.0 * 360.0 / 30.0)))
				If inipoints = 0 And inioverweld_int <> 0.0 Then
					inipoints = 1
				End If
				Dim finoverweld_int As Double
				If CInt(i) <> layerno Then
					finoverweld_int = intoverweld
				Else
					finoverweld_int = CDbl(finoverweld)
				End If
				finpoints = CInt(Math.Round(Math.Round(finoverweld_int / 100.0 * 360.0 / 30.0)))
				If finpoints = 0 And finoverweld_int <> 0.0 Then
					finpoints = 1
				End If
				positions = CType(Utils.CopyArray(CType(positions, Array), New Double(6, totalpoints + inipoints + pointnumber + finpoints + 5 + 1 - 1) {}), Double(,))
				expositions = CType(Utils.CopyArray(CType(expositions, Array), New Double(6, totalpoints + inipoints + pointnumber + finpoints + 5 + 1 - 1) {}), Double(,))
				Dim num3 As Integer = 1
				Dim num4 As Integer = inipoints
				For passIndex As Integer = num3 To num4
					If Claddingdir_loc = 1S Then
						' The following expression was wrapped in a unchecked-expression
						' The following expression was wrapped in a checked-expression
						positions(0, totalpoints + j + 2) = Positioncal.WorkXAxisOffset + CDbl(Positioncal.DirectionFlg) * crankthrow * Math.Sin((1.0 / CDbl(Positioncal.PPR) + totalangle + inioverweld_int / 100.0 * CDbl((passIndex - 1)) / CDbl(inipoints)) * 2.0 * 3.1415926535897931)
						positions(1, totalpoints + j + 2) = distance + CDbl(Claddingdir_loc) * (width_right + Positioncal.CladWidth / 2.0 + meanderamp - layerheight * CDbl((i - 1S)) * Math.Tan(leftang)) * Math.Cos(coneangle) + tooloffset * Math.Sin(postureangle * 3.1415926535897931 / 180.0)
						positions(2, totalpoints + j + 2) = crankthrow * Math.Cos((1.0 / CDbl(Positioncal.PPR) + totalangle + inioverweld_int / 100.0 * CDbl((passIndex - 1)) / CDbl(inipoints)) * 2.0 * 3.1415926535897931) + diameter / 2.0 + layerheight * CDbl((i - 1S)) * Math.Cos(coneangle) - CDbl(Claddingdir_loc) * (width_right + Positioncal.CladWidth / 2.0 + meanderamp - layerheight * CDbl((i - 1S)) * Math.Tan(leftang)) * Math.Sin(coneangle) + tooloffset * Math.Cos(postureangle * 3.1415926535897931 / 180.0)
						positions(3, totalpoints + j + 2) = 90.0 + postureangle - CDbl(Claddingdir_loc) * rockang
						positions(4, totalpoints + j + 2) = Ry
						positions(5, totalpoints + j + 2) = Rz
					Else
						' The following expression was wrapped in a unchecked-expression
						' The following expression was wrapped in a checked-expression
						positions(0, totalpoints + j + 2) = Positioncal.WorkXAxisOffset + CDbl(Positioncal.DirectionFlg) * crankthrow * Math.Sin((1.0 / CDbl(Positioncal.PPR) + totalangle + inioverweld_int / 100.0 * CDbl((passIndex - 1)) / CDbl(inipoints)) * 2.0 * 3.1415926535897931)
						positions(1, totalpoints + j + 2) = distance + CDbl(Claddingdir_loc) * (width_left + Positioncal.CladWidth / 2.0 + meanderamp - layerheight * CDbl((i - 1S)) * Math.Tan(rightang)) * Math.Cos(coneangle) + tooloffset * Math.Sin(postureangle * 3.1415926535897931 / 180.0)
						positions(2, totalpoints + j + 2) = crankthrow * Math.Cos((1.0 / CDbl(Positioncal.PPR) + totalangle + inioverweld_int / 100.0 * CDbl((passIndex - 1)) / CDbl(inipoints)) * 2.0 * 3.1415926535897931) + diameter / 2.0 + layerheight * CDbl((i - 1S)) * Math.Cos(coneangle) - CDbl(Claddingdir_loc) * (width_left + Positioncal.CladWidth / 2.0 + meanderamp - layerheight * CDbl((i - 1S)) * Math.Tan(rightang)) * Math.Sin(coneangle) + tooloffset * Math.Cos(postureangle * 3.1415926535897931 / 180.0)
						positions(3, totalpoints + j + 2) = 90.0 + postureangle - CDbl(Claddingdir_loc) * rockang
						positions(4, totalpoints + j + 2) = Ry
						positions(5, totalpoints + j + 2) = Rz
					End If
					expositions(1, totalpoints + j + 2) = 331776.0 * (initialang / 360.0 + (1.0 / CDbl(Positioncal.PPR) + totalangle + inioverweld_int / 100.0 * CDbl((passIndex - 1)) / CDbl(inipoints)) * CDbl(Positioncal.DirectionFlg))
				Next
				Dim k As Double = 1.0
				Dim num5 As Integer = 1
				Dim num6 As Integer = pointnumber
				For j As Integer = num5 To num6
					If Claddingdir_loc = 1S Then
						' The following expression was wrapped in a unchecked-expression
						' The following expression was wrapped in a checked-expression
						positions(0, totalpoints + inipoints + j + 2) = Positioncal.WorkXAxisOffset + CDbl(Positioncal.DirectionFlg) * crankthrow * Math.Sin((1.0 / CDbl(Positioncal.PPR) + totalangle + inioverweld_int / 100.0 + CDbl((passIndex - 1)) / CDbl(Positioncal.PPR)) * 2.0 * 3.1415926535897931)
						positions(1, totalpoints + inipoints + j + 2) = distance + CDbl(Claddingdir_loc) * (width_right + pitch * CDbl((passIndex - 1)) / CDbl(Positioncal.PPR) + Positioncal.CladWidth / 2.0 + meanderamp - layerheight * CDbl((i - 1S)) * Math.Tan(leftang)) * Math.Cos(coneangle) + tooloffset * Math.Sin(postureangle * 3.1415926535897931 / 180.0)
						positions(2, totalpoints + inipoints + j + 2) = crankthrow * Math.Cos((1.0 / CDbl(Positioncal.PPR) + totalangle + inioverweld_int / 100.0 + CDbl((passIndex - 1)) / CDbl(Positioncal.PPR)) * 2.0 * 3.1415926535897931) + diameter / 2.0 + layerheight * CDbl((i - 1S)) * Math.Cos(coneangle) - CDbl(Claddingdir_loc) * (width_right + pitch * CDbl((passIndex - 1)) / CDbl(Positioncal.PPR) + Positioncal.CladWidth / 2.0 + meanderamp - layerheight * CDbl((i - 1S)) * Math.Tan(leftang)) * Math.Sin(coneangle) + tooloffset * Math.Cos(postureangle * 3.1415926535897931 / 180.0)
					Else
						' The following expression was wrapped in a unchecked-expression
						' The following expression was wrapped in a checked-expression
						positions(0, totalpoints + inipoints + j + 2) = Positioncal.WorkXAxisOffset + CDbl(Positioncal.DirectionFlg) * crankthrow * Math.Sin((1.0 / CDbl(Positioncal.PPR) + totalangle + inioverweld_int / 100.0 + CDbl((passIndex - 1)) / CDbl(Positioncal.PPR)) * 2.0 * 3.1415926535897931)
						positions(1, totalpoints + inipoints + j + 2) = distance + CDbl(Claddingdir_loc) * (width_left + pitch * CDbl((passIndex - 1)) / CDbl(Positioncal.PPR) + Positioncal.CladWidth / 2.0 + meanderamp - layerheight * CDbl((i - 1S)) * Math.Tan(rightang)) * Math.Cos(coneangle) + tooloffset * Math.Sin(postureangle * 3.1415926535897931 / 180.0)
						positions(2, totalpoints + inipoints + j + 2) = crankthrow * Math.Cos((1.0 / CDbl(Positioncal.PPR) + totalangle + inioverweld_int / 100.0 + CDbl((passIndex - 1)) / CDbl(Positioncal.PPR)) * 2.0 * 3.1415926535897931) + diameter / 2.0 + layerheight * CDbl((i - 1S)) * Math.Cos(coneangle) - CDbl(Claddingdir_loc) * (width_left + pitch * CDbl((passIndex - 1)) / CDbl(Positioncal.PPR) + Positioncal.CladWidth / 2.0 + meanderamp - layerheight * CDbl((i - 1S)) * Math.Tan(rightang)) * Math.Sin(coneangle) + tooloffset * Math.Cos(postureangle * 3.1415926535897931 / 180.0)
					End If
					If k = 1.0 Then
						k = -1.0
					Else
						k = 1.0
					End If
					positions(3, totalpoints + inipoints + j + 2) = 90.0 + postureangle - CDbl(Claddingdir_loc) * rockang * (1.0 - CDbl((CInt((rockangvar * 2S)) * j)) / CDbl(pointnumber)) + k * Positioncal.Tiltangle
					positions(4, totalpoints + inipoints + j + 2) = Ry
					positions(5, totalpoints + inipoints + j + 2) = Rz
					expositions(1, totalpoints + inipoints + j + 2) = 331776.0 * (initialang / 360.0 + (1.0 / CDbl(Positioncal.PPR) + totalangle + inioverweld_int / 100.0 + CDbl((passIndex - 1)) / CDbl(Positioncal.PPR)) * CDbl(Positioncal.DirectionFlg))
				Next
				Dim num7 As Integer = 1
				Dim num8 As Integer = finpoints
				For j As Integer = num7 To num8
					If Claddingdir_loc = 1S Then
						If finaldistance = 0.0 Then
							' The following expression was wrapped in a unchecked-expression
							' The following expression was wrapped in a checked-expression
							positions(0, totalpoints + inipoints + pointnumber + j + 2) = Positioncal.WorkXAxisOffset + CDbl(Positioncal.DirectionFlg) * crankthrow * Math.Sin((1.0 / CDbl(Positioncal.PPR) + totalangle + inioverweld_int / 100.0 + finoverweld_int / 100.0 * CDbl((passIndex - 1)) / CDbl(finpoints) + CDbl(pointnumber) / CDbl(Positioncal.PPR)) * 2.0 * 3.1415926535897931)
							positions(1, totalpoints + inipoints + pointnumber + j + 2) = distance + CDbl(Claddingdir_loc) * (width_right + width1 - Positioncal.CladWidth / 2.0 - meanderamp + layerheight * CDbl(i) * Math.Tan(rightang)) * Math.Cos(coneangle) + tooloffset * Math.Sin(postureangle * 3.1415926535897931 / 180.0)
							positions(2, totalpoints + inipoints + pointnumber + j + 2) = crankthrow * Math.Cos((1.0 / CDbl(Positioncal.PPR) + totalangle + inioverweld_int / 100.0 + finoverweld_int / 100.0 * CDbl((passIndex - 1)) / CDbl(finpoints) + CDbl(pointnumber) / CDbl(Positioncal.PPR)) * 2.0 * 3.1415926535897931) + diameter / 2.0 + layerheight * CDbl((i - 1S)) * Math.Cos(coneangle) - CDbl(Claddingdir_loc) * (width_right + width1 - Positioncal.CladWidth / 2.0 - meanderamp + layerheight * CDbl(i) * Math.Tan(rightang)) * Math.Sin(coneangle) + tooloffset * Math.Cos(postureangle * 3.1415926535897931 / 180.0)
							expositions(1, totalpoints + inipoints + pointnumber + j + 2) = 331776.0 * (initialang / 360.0 + (1.0 / CDbl(Positioncal.PPR) + totalangle + inioverweld_int / 100.0 + finoverweld_int / 100.0 * CDbl((passIndex - 1)) / CDbl(finpoints) + CDbl(pointnumber) / CDbl(Positioncal.PPR)) * CDbl(Positioncal.DirectionFlg))
						Else
							' The following expression was wrapped in a unchecked-expression
							' The following expression was wrapped in a checked-expression
							' The following expression was wrapped in a checked-expression
							positions(0, totalpoints + inipoints + pointnumber + j + 2) = Positioncal.WorkXAxisOffset + CDbl(Positioncal.DirectionFlg) * crankthrow * Math.Sin((1.0 / CDbl(Positioncal.PPR) + totalangle + inioverweld_int / 100.0 + finoverweld_int / 100.0 * CDbl((passIndex - 1)) / CDbl(finpoints) + CDbl((pointnumber - 1)) / CDbl(Positioncal.PPR) + finaldistance) * 2.0 * 3.1415926535897931)
							positions(1, totalpoints + inipoints + pointnumber + j + 2) = distance + CDbl(Claddingdir_loc) * (width_right + width1 - Positioncal.CladWidth / 2.0 - meanderamp + layerheight * CDbl(i) * Math.Tan(rightang)) * Math.Cos(coneangle) + tooloffset * Math.Sin(postureangle * 3.1415926535897931 / 180.0)
							positions(2, totalpoints + inipoints + pointnumber + j + 2) = crankthrow * Math.Cos((1.0 / CDbl(Positioncal.PPR) + totalangle + inioverweld_int / 100.0 + finoverweld_int / 100.0 * CDbl((passIndex - 1)) / CDbl(finpoints) + CDbl((pointnumber - 1)) / CDbl(Positioncal.PPR) + finaldistance) * 2.0 * 3.1415926535897931) + diameter / 2.0 + layerheight * CDbl((i - 1S)) * Math.Cos(coneangle) - CDbl(Claddingdir_loc) * (width_right + width1 - Positioncal.CladWidth / 2.0 - meanderamp + layerheight * CDbl(i) * Math.Tan(rightang)) * Math.Sin(coneangle) + tooloffset * Math.Cos(postureangle * 3.1415926535897931 / 180.0)
							expositions(1, totalpoints + inipoints + pointnumber + j + 2) = 331776.0 * (initialang / 360.0 + (1.0 / CDbl(Positioncal.PPR) + totalangle + inioverweld_int / 100.0 + finoverweld_int / 100.0 * CDbl((passIndex - 1)) / CDbl(finpoints) + CDbl((pointnumber - 1)) / CDbl(Positioncal.PPR) + finaldistance) * CDbl(Positioncal.DirectionFlg))
						End If
					ElseIf finaldistance = 0.0 Then
						' The following expression was wrapped in a unchecked-expression
						' The following expression was wrapped in a checked-expression
						positions(0, totalpoints + inipoints + pointnumber + j + 2) = Positioncal.WorkXAxisOffset + CDbl(Positioncal.DirectionFlg) * crankthrow * Math.Sin((1.0 / CDbl(Positioncal.PPR) + totalangle + inioverweld_int / 100.0 + finoverweld_int / 100.0 * CDbl((passIndex - 1)) / CDbl(finpoints) + CDbl(pointnumber) / CDbl(Positioncal.PPR)) * 2.0 * 3.1415926535897931)
						positions(1, totalpoints + inipoints + pointnumber + j + 2) = distance + CDbl(Claddingdir_loc) * (width_left + width1 - Positioncal.CladWidth / 2.0 - meanderamp + layerheight * CDbl(i) * Math.Tan(leftang)) * Math.Cos(coneangle) + tooloffset * Math.Sin(postureangle * 3.1415926535897931 / 180.0)
						positions(2, totalpoints + inipoints + pointnumber + j + 2) = crankthrow * Math.Cos((1.0 / CDbl(Positioncal.PPR) + totalangle + inioverweld_int / 100.0 + finoverweld_int / 100.0 * CDbl((passIndex - 1)) / CDbl(finpoints) + CDbl(pointnumber) / CDbl(Positioncal.PPR)) * 2.0 * 3.1415926535897931) + diameter / 2.0 + layerheight * CDbl((i - 1S)) * Math.Cos(coneangle) - CDbl(Claddingdir_loc) * (width_left + width1 - Positioncal.CladWidth / 2.0 - meanderamp + layerheight * CDbl(i) * Math.Tan(leftang)) * Math.Sin(coneangle) + tooloffset * Math.Cos(postureangle * 3.1415926535897931 / 180.0)
						expositions(1, totalpoints + inipoints + pointnumber + j + 2) = 331776.0 * (initialang / 360.0 + (1.0 / CDbl(Positioncal.PPR) + totalangle + inioverweld_int / 100.0 + finoverweld_int / 100.0 * CDbl((passIndex - 1)) / CDbl(finpoints) + CDbl(pointnumber) / CDbl(Positioncal.PPR)) * CDbl(Positioncal.DirectionFlg))
					Else
						' The following expression was wrapped in a unchecked-expression
						' The following expression was wrapped in a checked-expression
						' The following expression was wrapped in a checked-expression
						positions(0, totalpoints + inipoints + pointnumber + j + 2) = Positioncal.WorkXAxisOffset + CDbl(Positioncal.DirectionFlg) * crankthrow * Math.Sin((1.0 / CDbl(Positioncal.PPR) + totalangle + inioverweld_int / 100.0 + finoverweld_int / 100.0 * CDbl((passIndex - 1)) / CDbl(finpoints) + CDbl((pointnumber - 1)) / CDbl(Positioncal.PPR) + finaldistance) * 2.0 * 3.1415926535897931)
						positions(1, totalpoints + inipoints + pointnumber + j + 2) = distance + CDbl(Claddingdir_loc) * (width_left + width1 - Positioncal.CladWidth / 2.0 - meanderamp + layerheight * CDbl(i) * Math.Tan(leftang)) * Math.Cos(coneangle) + tooloffset * Math.Sin(postureangle * 3.1415926535897931 / 180.0)
						positions(2, totalpoints + inipoints + pointnumber + j + 2) = crankthrow * Math.Cos((1.0 / CDbl(Positioncal.PPR) + totalangle + inioverweld_int / 100.0 + finoverweld_int / 100.0 * CDbl((passIndex - 1)) / CDbl(finpoints) + CDbl((pointnumber - 1)) / CDbl(Positioncal.PPR) + finaldistance) * 2.0 * 3.1415926535897931) + diameter / 2.0 + layerheight * CDbl((i - 1S)) * Math.Cos(coneangle) - CDbl(Claddingdir_loc) * (width_left + width1 - Positioncal.CladWidth / 2.0 - meanderamp + layerheight * CDbl(i) * Math.Tan(leftang)) * Math.Sin(coneangle) + tooloffset * Math.Cos(postureangle * 3.1415926535897931 / 180.0)
						expositions(1, totalpoints + inipoints + pointnumber + j + 2) = 331776.0 * (initialang / 360.0 + (1.0 / CDbl(Positioncal.PPR) + totalangle + inioverweld_int / 100.0 + finoverweld_int / 100.0 * CDbl((passIndex - 1)) / CDbl(finpoints) + CDbl((pointnumber - 1)) / CDbl(Positioncal.PPR) + finaldistance) * CDbl(Positioncal.DirectionFlg))
					End If
					positions(3, totalpoints + inipoints + pointnumber + j + 2) = 90.0 + postureangle - CDbl(Claddingdir_loc) * rockang * (1.0 - CDbl((CInt(((1S - rockangvar) * 2S)) * j)) / CDbl(finpoints) - CDbl((rockangvar * 2S)))
					positions(4, totalpoints + inipoints + pointnumber + j + 2) = Ry
					positions(5, totalpoints + inipoints + pointnumber + j + 2) = Rz
				Next
				If CInt(i) = layerno Then
					If Claddingdir_loc = 1S Then
						If finaldistance = 0.0 Then
							' The following expression was wrapped in a unchecked-expression
							positions(0, totalpoints + inipoints + pointnumber + finpoints + 3) = Positioncal.WorkXAxisOffset + CDbl(Positioncal.DirectionFlg) * crankthrow * Math.Sin((1.0 / CDbl(Positioncal.PPR) + totalangle + inioverweld_int / 100.0 + CDbl(pointnumber) / CDbl(Positioncal.PPR) + finoverweld_int / 100.0) * 2.0 * 3.1415926535897931)
							positions(1, totalpoints + inipoints + pointnumber + finpoints + 3) = distance + CDbl(Claddingdir_loc) * (width_right + width1 - Positioncal.CladWidth / 2.0 - meanderamp + layerheight * CDbl(i) * Math.Tan(rightang)) * Math.Cos(coneangle) + tooloffset * Math.Sin(postureangle * 3.1415926535897931 / 180.0)
							positions(2, totalpoints + inipoints + pointnumber + finpoints + 3) = crankthrow * Math.Cos((1.0 / CDbl(Positioncal.PPR) + totalangle + inioverweld_int / 100.0 + CDbl(pointnumber) / CDbl(Positioncal.PPR) + finoverweld_int / 100.0) * 2.0 * 3.1415926535897931) + diameter / 2.0 + layerheight * CDbl((i - 1S)) * Math.Cos(coneangle) - CDbl(Claddingdir_loc) * (width_right + width1 - Positioncal.CladWidth / 2.0 - meanderamp + layerheight * CDbl(i) * Math.Tan(rightang)) * Math.Sin(coneangle) + tooloffset * Math.Cos(postureangle * 3.1415926535897931 / 180.0)
							expositions(1, totalpoints + inipoints + pointnumber + finpoints + 3) = 331776.0 * (initialang / 360.0 + (1.0 / CDbl(Positioncal.PPR) + totalangle + inioverweld_int / 100.0 + CDbl(pointnumber) / CDbl(Positioncal.PPR) + finoverweld_int / 100.0) * CDbl(Positioncal.DirectionFlg))
						Else
							' The following expression was wrapped in a unchecked-expression
							' The following expression was wrapped in a checked-expression
							positions(0, totalpoints + inipoints + pointnumber + finpoints + 3) = Positioncal.WorkXAxisOffset + CDbl(Positioncal.DirectionFlg) * crankthrow * Math.Sin((1.0 / CDbl(Positioncal.PPR) + totalangle + inioverweld_int / 100.0 + CDbl((pointnumber - 1)) / CDbl(Positioncal.PPR) + finaldistance + finoverweld_int / 100.0) * 2.0 * 3.1415926535897931)
							positions(1, totalpoints + inipoints + pointnumber + finpoints + 3) = distance + CDbl(Claddingdir_loc) * (width_right + width1 - Positioncal.CladWidth / 2.0 - meanderamp + layerheight * CDbl(i) * Math.Tan(rightang)) * Math.Cos(coneangle) + tooloffset * Math.Sin(postureangle * 3.1415926535897931 / 180.0)
							positions(2, totalpoints + inipoints + pointnumber + finpoints + 3) = crankthrow * Math.Cos((1.0 / CDbl(Positioncal.PPR) + totalangle + inioverweld_int / 100.0 + CDbl((pointnumber - 1)) / CDbl(Positioncal.PPR) + finaldistance + finoverweld_int / 100.0) * 2.0 * 3.1415926535897931) + diameter / 2.0 + layerheight * CDbl((i - 1S)) * Math.Cos(coneangle) - CDbl(Claddingdir_loc) * (width_right + width1 - Positioncal.CladWidth / 2.0 - meanderamp + layerheight * CDbl(i) * Math.Tan(rightang)) * Math.Sin(coneangle) + tooloffset * Math.Cos(postureangle * 3.1415926535897931 / 180.0)
							expositions(1, totalpoints + inipoints + pointnumber + finpoints + 3) = 331776.0 * (initialang / 360.0 + (1.0 / CDbl(Positioncal.PPR) + totalangle + inioverweld_int / 100.0 + CDbl((pointnumber - 1)) / CDbl(Positioncal.PPR) + finaldistance + finoverweld_int / 100.0) * CDbl(Positioncal.DirectionFlg))
						End If
					ElseIf finaldistance = 0.0 Then
						' The following expression was wrapped in a unchecked-expression
						positions(0, totalpoints + inipoints + pointnumber + finpoints + 3) = Positioncal.WorkXAxisOffset + CDbl(Positioncal.DirectionFlg) * crankthrow * Math.Sin((1.0 / CDbl(Positioncal.PPR) + totalangle + inioverweld_int / 100.0 + CDbl(pointnumber) / CDbl(Positioncal.PPR) + finoverweld_int / 100.0) * 2.0 * 3.1415926535897931)
						positions(1, totalpoints + inipoints + pointnumber + finpoints + 3) = distance + CDbl(Claddingdir_loc) * (width_left + width1 - Positioncal.CladWidth / 2.0 - meanderamp + layerheight * CDbl(i) * Math.Tan(leftang)) * Math.Cos(coneangle) + tooloffset * Math.Sin(postureangle * 3.1415926535897931 / 180.0)
						positions(2, totalpoints + inipoints + pointnumber + finpoints + 3) = crankthrow * Math.Cos((1.0 / CDbl(Positioncal.PPR) + totalangle + inioverweld_int / 100.0 + CDbl(pointnumber) / CDbl(Positioncal.PPR) + finoverweld_int / 100.0) * 2.0 * 3.1415926535897931) + diameter / 2.0 + layerheight * CDbl((i - 1S)) * Math.Cos(coneangle) - CDbl(Claddingdir_loc) * (width_left + width1 - Positioncal.CladWidth / 2.0 - meanderamp + layerheight * CDbl(i) * Math.Tan(leftang)) * Math.Sin(coneangle) + tooloffset * Math.Cos(postureangle * 3.1415926535897931 / 180.0)
						expositions(1, totalpoints + inipoints + pointnumber + finpoints + 3) = 331776.0 * (initialang / 360.0 + (1.0 / CDbl(Positioncal.PPR) + totalangle + inioverweld_int / 100.0 + CDbl(pointnumber) / CDbl(Positioncal.PPR) + finoverweld_int / 100.0) * CDbl(Positioncal.DirectionFlg))
					Else
						' The following expression was wrapped in a unchecked-expression
						' The following expression was wrapped in a checked-expression
						positions(0, totalpoints + inipoints + pointnumber + finpoints + 3) = Positioncal.WorkXAxisOffset + CDbl(Positioncal.DirectionFlg) * crankthrow * Math.Sin((1.0 / CDbl(Positioncal.PPR) + totalangle + inioverweld_int / 100.0 + CDbl((pointnumber - 1)) / CDbl(Positioncal.PPR) + finaldistance + finoverweld_int / 100.0) * 2.0 * 3.1415926535897931)
						positions(1, totalpoints + inipoints + pointnumber + finpoints + 3) = distance + CDbl(Claddingdir_loc) * (width_left + width1 - Positioncal.CladWidth / 2.0 - meanderamp + layerheight * CDbl(i) * Math.Tan(leftang)) * Math.Cos(coneangle) + tooloffset * Math.Sin(postureangle * 3.1415926535897931 / 180.0)
						positions(2, totalpoints + inipoints + pointnumber + finpoints + 3) = crankthrow * Math.Cos((1.0 / CDbl(Positioncal.PPR) + totalangle + inioverweld_int / 100.0 + CDbl((pointnumber - 1)) / CDbl(Positioncal.PPR) + finaldistance + finoverweld_int / 100.0) * 2.0 * 3.1415926535897931) + diameter / 2.0 + layerheight * CDbl((i - 1S)) * Math.Cos(coneangle) - CDbl(Claddingdir_loc) * (width_left + width1 - Positioncal.CladWidth / 2.0 - meanderamp + layerheight * CDbl(i) * Math.Tan(leftang)) * Math.Sin(coneangle) + tooloffset * Math.Cos(postureangle * 3.1415926535897931 / 180.0)
						expositions(1, totalpoints + inipoints + pointnumber + finpoints + 3) = 331776.0 * (initialang / 360.0 + (1.0 / CDbl(Positioncal.PPR) + totalangle + inioverweld_int / 100.0 + CDbl((pointnumber - 1)) / CDbl(Positioncal.PPR) + finaldistance + finoverweld_int / 100.0) * CDbl(Positioncal.DirectionFlg))
					End If
				End If
				positions(3, totalpoints + inipoints + pointnumber + finpoints + 3) = 90.0 + postureangle + CDbl(Claddingdir_loc) * rockang
				positions(4, totalpoints + inipoints + pointnumber + finpoints + 3) = Ry
				positions(5, totalpoints + inipoints + pointnumber + finpoints + 3) = Rz
				If Claddingdir_loc = 1S Then
					Claddingdir_loc = -1S
				Else
					Claddingdir_loc = 1S
				End If
			Next
			positions(0, totalpoints + inipoints + pointnumber + finpoints + 4) = CDbl(Positioncal.HomePos(0))
			positions(1, totalpoints + inipoints + pointnumber + finpoints + 4) = CDbl(Positioncal.HomePos(1))
			positions(2, totalpoints + inipoints + pointnumber + finpoints + 4) = CDbl(Positioncal.HomePos(2))
			positions(3, totalpoints + inipoints + pointnumber + finpoints + 4) = CDbl(Positioncal.HomePos(3))
			positions(4, totalpoints + inipoints + pointnumber + finpoints + 4) = CDbl(Positioncal.HomePos(4))
			positions(5, totalpoints + inipoints + pointnumber + finpoints + 4) = CDbl(Positioncal.HomePos(5))
			expositions(1, 0) = 331776.0 * initialang / 360.0
			expositions(1, 1) = 331776.0 * initialang / 360.0
			expositions(1, 2) = 331776.0 * initialang / 360.0
			expositions(1, totalpoints + inipoints + pointnumber + finpoints + 4) = 0.0
			Dim meanderfreq As Double = processspeed / (4.0 * meanderamp)
			Dim power As Double = 0.0025 * CDbl(Positioncal.LaserPowerIni) + -1.1111
			Dim feed As Double = 0.1 * Positioncal.PowderFeed
			Dim beamdia As Double = 2.3596 * Positioncal.CladWidth + -4.4599
			Dim headertxt As String
			Dim mainprogtxt As String
			Positioncal.TotalSteps = totalpoints + inipoints + pointnumber + finpoints + 5
			headertxt = String.Concat(New String() {"/JOB" & vbCrLf & "//NAME HOSTMOV" & vbCrLf & "//POS" & vbCrLf & "///NPOS ", Conversions.ToString(totalpoints + inipoints + pointnumber + finpoints + 5), ",0,", Conversions.ToString(totalpoints + inipoints + pointnumber + finpoints + 5), ",2,0,2" & vbCrLf & "///USER ", Positioncal.StationPosition.ToString("#"), vbCrLf & "///TOOL ", Positioncal.Toolno.ToString("#0"), vbCrLf & "///POSTYPE USER" & vbCrLf & "///RECTAN" & vbCrLf & "///RCONF 1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0" & vbCrLf})
			Dim num9 As Integer = 0
			Dim num10 As Integer = totalpoints + inipoints + pointnumber + finpoints + 3
			Dim i As Short
			For ind As Integer = num9 To num10
				headertxt = headertxt + "C" + ind.ToString("0000#=")
				i = 0S

				Do
					headertxt = headertxt + positions(CInt(i), ind).ToString("#0.000;-#0.000;0.000") + ","
					i += 1S
				Loop While i <= 2S
				i = 3S
				Do
					headertxt = headertxt + positions(CInt(i), ind).ToString("#0.00;-#0.00;0.00") + ","
					i += 1S
				Loop While i <= 4S
				headertxt = headertxt + positions(5, ind).ToString("#0.00;-#0.00;0.00") + vbCrLf

			Next
			headertxt += "///POSTYPE PULSE" & vbCrLf & "///PULSE" & vbCrLf
			headertxt = headertxt + "C" + (totalpoints + inipoints + pointnumber + finpoints + 4).ToString("0000#=")
			i = 0S
			Do
				headertxt = headertxt + positions(CInt(i), totalpoints + inipoints + pointnumber + finpoints + 4).ToString("#;-#;0") + ","

				i += 1S

			Loop While i <= 4S
			headertxt = headertxt + positions(5, totalpoints + inipoints + pointnumber + finpoints + 4).ToString("#;-#;0") + vbCrLf
			Dim num11 As Integer = 0
			Dim num12 As Integer = totalpoints + inipoints + pointnumber + finpoints + 4
			For ind As Integer = num11 To num12
				headertxt = String.Concat(New String() {headertxt, "EC", ind.ToString("0000#="), "0,", expositions(1, ind).ToString("#0;-#0;0"), vbCrLf})
			Next
			headertxt = String.Concat(New String() {headertxt, "///POSTYPE BASE" & vbCrLf & "///RECTAN" & vbCrLf & "P0000=0.000,0.000,0.000,0.00,0.00,0.00" & vbCrLf & "P0001=0.000,0.000,0.000,0.00,0.00,0.00" & vbCrLf & "///POSTYPE PULSE" & vbCrLf & "///PULSE" & vbCrLf & "EX0000=0,0" & vbCrLf & "EX0001=0,0" & vbCrLf & "//INST" & vbCrLf & "///DATE ", mydatetime.ToString("yyyy/MM/dd HH:mm"), vbCrLf & "///COMM SUB TASK TO HOSTMAST" & vbCrLf & "///ATTR SC,RW,RJ" & vbCrLf & "////FRAME USER ", Positioncal.StationPosition.ToString("#"), vbCrLf & "///GROUP1 RB1" & vbCrLf & "///GROUP2 ST1" & vbCrLf & "///LVARS 0,0,0,0,0,0,0,0"})
			mainprogtxt = "NOP" & vbCrLf & "EI LEVEL= 1" & vbCrLf
			If meanderflg = 1S Then
				' The following expression was wrapped in a unchecked-expression
				' The following expression was wrapped in a unchecked-expression
				mainprogtxt = String.Concat(New String() {mainprogtxt, "SETFILE WEV#(1) (4) ", Conversions.ToString(CInt(Math.Round(meanderfreq * 10.0))), vbCrLf & "SETFILE WEV#(1) (5) ", Conversions.ToString(CInt(Math.Round(meanderamp * 1000.0))), vbCrLf & "SETFILE WEV#(1) (8) 0" & vbCrLf & "SETFILE WEV#(1) (9) 0" & vbCrLf})
			End If
			mainprogtxt = String.Concat(New String() {mainprogtxt, "CALL JOB:STRESET" & vbCrLf & "GETS PX000 $PX000" & vbCrLf & "CNVRT PX000 PX000 RF" & vbCrLf & "GETE D000 P000 (3)" & vbCrLf & "ADD D000 ", (Positioncal.IniZAxisOffset * 1000.0).ToString("#0"), vbCrLf & "JUMP *LABEL1 IF D000<=", Positioncal.MaxZRobotPos.ToString("#"), vbCrLf & "SET D000 ", Positioncal.MaxZRobotPos.ToString("#"), vbCrLf & "*LABEL1" & vbCrLf & "SETE P000 (3) D000" & vbCrLf & "MOVL P000 V=", Positioncal.IdleSpeed.ToString("#0.0"), " PL=0  +MOVJ EX000 VJ=100.00" & vbCrLf & "GETS PX000 $PX000" & vbCrLf & "GETE D000 P000 (4)" & vbCrLf & "CALL JOB:ARMCOR IF D000>=", 184115.0.ToString("#"), vbCrLf & "CALL JOB:ARMCOR IF D000<=-", 184115.0.ToString("#"), vbCrLf & "GETPOS PX000 STEP#(2)" & vbCrLf & "CNVRT PX000 PX000 RF" & vbCrLf & "GETE D000 P000 (3)" & vbCrLf & "JUMP *LABEL2 IF D000<", Positioncal.MaxZRobotPos.ToString("#"), vbCrLf & "SUB D000 ", Positioncal.MaxZRobotPos.ToString("#"), vbCrLf & "MUL D000 -1" & vbCrLf & "SETE P000 (1) 0" & vbCrLf & "SETE P000 (2) 0" & vbCrLf & "SETE P000 (3) D000" & vbCrLf & "SETE P000 (4) 0" & vbCrLf & "SETE P000 (5) 0" & vbCrLf & "SETE P000 (6) 0" & vbCrLf & "SFTON RB1 P000 RF" & vbCrLf & "*LABEL2" & vbCrLf & "MOVL C00000 V=", Positioncal.IdleSpeed.ToString("#0.0"), " PL=0 NWAIT  +MOVJ EC00000 VJ=100.00" & vbCrLf & "DOUT OT#(1) ON" & vbCrLf & "DOUT OT#(8) ON" & vbCrLf & "JUMP *PILOTON IF IN#(2)=ON" & vbCrLf & "WAIT IN#(6)=ON T=5.00" & vbCrLf & "JUMP *END IF IN#(6)=OFF" & vbCrLf})
			If Positioncal.PowderJar = 1S Then
				mainprogtxt += "DOUT OT#(4) ON" & vbCrLf & "DOUT OT#(6) ON" & vbCrLf
			Else
				mainprogtxt += "DOUT OT#(5) ON" & vbCrLf & "DOUT OT#(7) ON" & vbCrLf
			End If
			mainprogtxt = String.Concat(New String() {mainprogtxt, "TIMER T=", Positioncal.PowderSettling1.ToString("#0.00"), vbCrLf & "*PILOTON" & vbCrLf & "SFTOF RB1" & vbCrLf & "MOVL C00001 V=", Positioncal.ApproachSpeed.ToString("#0.0"), " PL=0 DEC=20  +MOVJ EC00001 VJ=100.00" & vbCrLf & "WAIT IN#(1)=ON T=5.00" & vbCrLf})
			mainprogtxt = mainprogtxt + "TIMER T=" + Positioncal.PowderSettling2.ToString("#0.00") + vbCrLf & "EI LEVEL= 3" & vbCrLf & "*STARTL" & vbCrLf & "DOUT OT#(2) ON" & vbCrLf
			If meanderflg = 1S Then
				processspeed = processspeed * Positioncal.MeanderPitch / (4.0 * meanderamp)
			End If
			Dim num13 As Integer = 2
			Dim num14 As Integer = totalpoints + inipoints + pointnumber + finpoints + 3
			For j As Integer = num13 To num14
				If j = 2 Then
					mainprogtxt = String.Concat(New String() {mainprogtxt, "SMOVC C", j.ToString("0000#"), " V=", Positioncal.ApproachSpeed.ToString("#0.0;-#.0;0.0"), " PL=", Positioncal.PositionLevel.ToString("#"), " +MOVJ EC", j.ToString("0000#"), vbCrLf})
				ElseIf j = 3 Then
					' The following expression was wrapped in a unchecked-expression
					mainprogtxt = String.Concat(New String() {mainprogtxt, "SMOVC C", j.ToString("0000#"), " V=", Positioncal.ApproachSpeed.ToString("#0.0;-#.0;0.0"), " PL=", Positioncal.PositionLevel.ToString("#"), " +MOVJ EC", j.ToString("0000#"), vbCrLf & "ARCON AC=", (feed * (1.0 - CDbl(Positioncal.IniPowderRed) / 100.0) * 100.0).ToString("#0"), " AV=", ((1.0 + CDbl(Positioncal.IniOverPower) / 100.0) * power).ToString("#0.0"), vbCrLf & "ARCCTS AC=", (feed * 100.0).ToString("#0"), " AV=", power.ToString("#0.0"), " AN3=", beamdia.ToString("#0.0"), " DIS=", Positioncal.IniOverPowerDis.ToString("#0.0"), vbCrLf})
					If meanderflg = 1S Then
						mainprogtxt += "SWVON WEV#(1)" & vbCrLf
					End If
				ElseIf j = totalpoints + inipoints + pointnumber + finpoints + 3 Then
					mainprogtxt = String.Concat(New String() {mainprogtxt, "SMOVC C", j.ToString("0000#"), " V=", processspeed.ToString("#0.0;-#.0;0.0"), " PL=", Positioncal.PositionLevel.ToString("#"), " NWAIT  +MOVJ EC", j.ToString("0000#"), vbCrLf})
				Else
					mainprogtxt = String.Concat(New String() {mainprogtxt, "SMOVC C", j.ToString("0000#"), " V=", processspeed.ToString("#0.0;-#.0;0.0"), " PL=", Positioncal.PositionLevel.ToString("#"), " +MOVJ EC", j.ToString("0000#"), vbCrLf})
				End If

				' The following expression was wrapped in a checked-expression
				If j >= Positioncal.PPR + 2 And CDbl(Positioncal.LaserReductionTrackNo) >= CDbl((j - 2)) / CDbl(Positioncal.PPR) And Math.IEEERemainder(CDbl((j + 2)), CDbl(Positioncal.PPR)) = 0.0 AndAlso (Positioncal.IniPowderRed <> 0 Or Positioncal.IniOverPower <> 0) Then
					' The following expression was wrapped in a checked-expression
					' The following expression was wrapped in a checked-expression
					power = (CDbl(Positioncal.LaserPowerIni) - CDbl((Positioncal.LaserPowerIni - Positioncal.LaserPowerFin)) / CDbl(Positioncal.LaserReductionTrackNo) * CDbl((j - 2)) / CDbl(Positioncal.PPR)) * 0.0025 + -1.1111
					mainprogtxt = String.Concat(New String() {mainprogtxt, "ARCSET AC=", (feed * 100.0).ToString("#0"), " AV=", power.ToString("#0.0"), " AN3=", beamdia.ToString("#0.0"), vbCrLf})
				End If
				If j = totalpoints + inipoints + pointnumber + finpoints + 2 AndAlso (Positioncal.FinOverPower <> 0 Or Positioncal.FinPowderRed <> 0) Then
					power = 0.0025 * CDbl(Positioncal.LaserPowerFin) * (1.0 + CDbl(Positioncal.FinOverPower) / 100.0) + -1.1111
					feed = 0.1 * (Positioncal.PowderFeed * CDbl((100 - Positioncal.FinPowderRed)) / 100.0)
					mainprogtxt = String.Concat(New String() {mainprogtxt, "ARCCTE AC=", (feed * 100.0).ToString("#0"), " AV=", power.ToString("#0.0"), " AN3=", beamdia.ToString("#0.0"), " DIS=", Positioncal.FinOverPowerDis.ToString("#0.0"), vbCrLf})
				End If
				If (If((-If(((j = inipoints + pointnumber + finpoints + 3) > False), 1S, 0S)), 1S, 0S) And meanderflg) <> 0S Then
					mainprogtxt += "SWVOF" & vbCrLf
				End If

			Next
			mainprogtxt = String.Concat(New String() {mainprogtxt, "DI LEVEL= 2" & vbCrLf & "JUMP *END" & vbCrLf & "*QVERROR" & vbCrLf & "*END" & vbCrLf & "ARCOF" & vbCrLf & "DOUT OG#(1) 0" & vbCrLf & "CALL JOB:STRESET" & vbCrLf & "GETS PX000 $PX000" & vbCrLf & "CNVRT PX000 PX000 RF" & vbCrLf & "GETE D000 P000 (3)" & vbCrLf & "ADD D000 ", (Positioncal.IniZAxisOffset * 1000.0).ToString("#0"), vbCrLf & "JUMP *LABEL3 IF D000<=", Positioncal.MaxZRobotPos.ToString("#"), vbCrLf & "SET D000 ", Positioncal.MaxZRobotPos.ToString("#"), vbCrLf & "*LABEL3" & vbCrLf & "SETE P000 (3) D000" & vbCrLf & "MOVL P000 V=", Positioncal.ApproachSpeed.ToString("#0.0"), " PL=0  +MOVJ EX000 VJ=100.00" & vbCrLf & "GETE D000 P000 (1)" & vbCrLf & "ADD D000 ", (Positioncal.IniXAxisOffset * 1000.0).ToString("#0"), vbCrLf & "SETE P000 (1) D000" & vbCrLf & "MOVL P000 V=", Positioncal.ApproachSpeed.ToString("#0.0"), " PL=0  +MOVJ EX000 VJ=100.00" & vbCrLf & "MOVL C", (totalpoints + inipoints + pointnumber + finpoints + 4).ToString("0000#"), " V=", Positioncal.IdleSpeed.ToString("#0.0"), " PL=0  +MOVJ EC", (totalpoints + inipoints + pointnumber + finpoints + 4).ToString("0000#"), " VJ=100.00" & vbCrLf & "END"})
			Try
				FileSystem.FileOpen(1, Positioncal.BasePath + "hostmov.jbi", OpenMode.Output, OpenAccess.[Default], OpenShare.[Default], -1)
				FileSystem.PrintLine(1, New Object() {headertxt})
				FileSystem.PrintLine(1, New Object() {mainprogtxt})
				FileSystem.FileClose(New Integer() {1})
				Positioncal.ControlGroup = 0S
			Catch ex As Exception
				Interaction.MsgBox("Job saving has failed due to the following reason: " + ex.Message, MsgBoxStyle.Exclamation, Nothing)
			End Try
		End Sub

		' Token: 0x06000566 RID: 1382 RVA: 0x0000EDFC File Offset: 0x0000D1FC
		<MethodImpl(MethodImplOptions.NoInlining Or MethodImplOptions.NoOptimization)>
		Public Sub planclad(diameter As Double, crankthrow As Double, width1 As Double, distance As Double, pitch As Double, processspeed As Double, postureangle As Double, coneangle As Double, inioverweld As Single, finoverweld As Single, meanderamp As Double, meanderflg As Short, initialang As Double, tooloffset As Double, hWnd As Integer)
			Dim positions As Double(,) = New Double(6, 11) {}
			Dim expositions As Double(,) = New Double(6, 11) {}
			Dim Ry As Double = Positioncal.WorkYAxisTilt
			Dim Rz As Double = Positioncal.WorkZAxisYaw
			Dim mydatetime As DateTime = DateAndTime.Now
			coneangle = coneangle * 3.1415926535897931 / 180.0
			If meanderflg = 0S Then
				meanderamp = 0.0
			End If
			Dim inipoints As Integer = CInt(Math.Round(Math.Round(CDbl((inioverweld / 100.0F * 360.0F / 30.0F)))))
			If inipoints > Positioncal.PPR Then
				inipoints = Positioncal.PPR
			End If
			Dim rotations As Double = Math.Round((width1 - Positioncal.CladWidth - 2.0 * meanderamp) / (2.0 * pitch), 2)
			Dim finaldistance As Double = rotations - Conversion.Int(rotations * CDbl(Positioncal.PPR)) / CDbl(Positioncal.PPR)
			Dim pointnumber As Integer = CInt(Math.Round(Math.Ceiling(rotations * CDbl(Positioncal.PPR))))
			Dim effectivepitch As Double = 2.0 * pitch
			If rotations >= 1.0 Then
				' The following expression was wrapped in a unchecked-expression
				positions = CType(Utils.CopyArray(CType(positions, Array), New Double(6, CInt(Math.Round(1.5 * CDbl(Positioncal.PPR) + CDbl(pointnumber) + 5.0)) + 1 - 1) {}), Double(,))
				expositions = CType(Utils.CopyArray(CType(expositions, Array), New Double(6, CInt(Math.Round(1.5 * CDbl(Positioncal.PPR) + CDbl(pointnumber) + 5.0)) + 1 - 1) {}), Double(,))
			End If
			positions(0, 0) = Positioncal.IniXAxisOffset
			positions(1, 0) = distance + CDbl(Positioncal.CladdingDir) * (Positioncal.CladWidth / 2.0 + meanderamp) * Math.Cos(coneangle) + Positioncal.IniYAxisOffset
			positions(2, 0) = crankthrow + diameter / 2.0 - (Positioncal.CladWidth / 2.0 + meanderamp) * Math.Sin(coneangle) + Positioncal.IniZAxisOffset
			positions(3, 0) = 90.0 + postureangle
			positions(4, 0) = Ry
			positions(5, 0) = Rz
			positions(0, 1) = Positioncal.IniXAxisOffset
			positions(1, 1) = distance + CDbl(Positioncal.CladdingDir) * (Positioncal.CladWidth / 2.0 + meanderamp) * Math.Cos(coneangle) + tooloffset * Math.Sin(coneangle)
			positions(2, 1) = diameter / 2.0 - (Positioncal.CladWidth / 2.0 + meanderamp) * Math.Sin(coneangle) + tooloffset * Math.Cos(coneangle)
			positions(3, 1) = 90.0 + postureangle
			positions(4, 1) = Ry
			positions(5, 1) = Rz
			Dim num As Integer = 1
			Dim num2 As Integer = CInt(Math.Round(CDbl(Positioncal.PPR) / 2.0))
			For i As Integer = num To num2
				' The following expression was wrapped in a unchecked-expression
				' The following expression was wrapped in a checked-expression
				positions(0, i + 1) = (diameter / 2.0 - CDbl(Positioncal.CladdingDir) * (Positioncal.CladWidth / 2.0 + meanderamp) * Math.Cos(coneangle)) * Math.Sin(CDbl(((inioverweld / 100.0F + 1.0F) * CSng((i - 1)) / CSng(Positioncal.PPR) * 2.0F)) * 3.1415926535897931)
				positions(1, i + 1) = distance + CDbl(Positioncal.CladdingDir) * (Positioncal.CladWidth / 2.0 + meanderamp) * Math.Sin(coneangle) + tooloffset * Math.Cos(coneangle)
				positions(2, i + 1) = (diameter / 2.0 - CDbl(Positioncal.CladdingDir) * (Positioncal.CladWidth / 2.0 + meanderamp) * Math.Cos(coneangle) + 1.5) * Math.Cos(CDbl(((inioverweld / 100.0F + 1.0F) * CSng((i - 1)) / CSng(Positioncal.PPR) * 2.0F)) * 3.1415926535897931) + tooloffset * Math.Sin(coneangle) - 1.5
				positions(3, i + 1) = 90.0 + postureangle
				positions(4, i + 1) = Ry
				positions(5, i + 1) = Rz
			Next
			Dim num3 As Integer = 1
			Dim num4 As Integer = CInt(Math.Round(CDbl(Positioncal.PPR) / 2.0))
			For i As Integer = num3 To num4
				' The following expression was wrapped in a unchecked-expression
				' The following expression was wrapped in a unchecked-expression
				' The following expression was wrapped in a checked-expression
				positions(0, CInt(Math.Round(CDbl(i) + CDbl(Positioncal.PPR) / 2.0 + 1.0))) = (diameter / 2.0 - CDbl(Positioncal.CladdingDir) * (CDbl((i - 1)) / CDbl(Positioncal.PPR) * effectivepitch + Positioncal.CladWidth / 2.0 + meanderamp) * Math.Cos(coneangle)) * Math.Sin(CDbl((inioverweld / 100.0F + 1.0F)) * (CDbl(i) + CDbl(Positioncal.PPR) / 2.0 - 1.0) / CDbl(Positioncal.PPR) * 2.0 * 3.1415926535897931)
				positions(1, CInt(Math.Round(CDbl(i) + CDbl(Positioncal.PPR) / 2.0 + 1.0))) = distance + CDbl(Positioncal.CladdingDir) * (CDbl((i - 1)) / CDbl(Positioncal.PPR) * effectivepitch + Positioncal.CladWidth / 2.0 + meanderamp) * Math.Sin(coneangle) + tooloffset * Math.Cos(coneangle)
				positions(2, CInt(Math.Round(CDbl(i) + CDbl(Positioncal.PPR) / 2.0 + 1.0))) = (diameter / 2.0 - CDbl(Positioncal.CladdingDir) * (CDbl((i - 1)) / CDbl(Positioncal.PPR) * effectivepitch + Positioncal.CladWidth / 2.0 + meanderamp) * Math.Cos(coneangle) + 1.5) * Math.Cos(CDbl((inioverweld / 100.0F + 1.0F)) * (CDbl(i) + CDbl(Positioncal.PPR) / 2.0 - 1.0) / CDbl(Positioncal.PPR) * 2.0 * 3.1415926535897931) + tooloffset * Math.Sin(coneangle) - 1.5
				positions(3, CInt(Math.Round(CDbl(i) + CDbl(Positioncal.PPR) / 2.0 + 1.0))) = 90.0 + postureangle
				positions(4, CInt(Math.Round(CDbl(i) + CDbl(Positioncal.PPR) / 2.0 + 1.0))) = Ry
				positions(5, CInt(Math.Round(CDbl(i) + CDbl(Positioncal.PPR) / 2.0 + 1.0))) = Rz
			Next
			Dim num5 As Integer = 1
			Dim num6 As Integer = pointnumber - 2
			For i As Integer = num5 To num6
				' The following expression was wrapped in a unchecked-expression
				' The following expression was wrapped in a checked-expression
				' The following expression was wrapped in a checked-expression
				positions(0, i + Positioncal.PPR + 1) = (diameter / 2.0 - CDbl(Positioncal.CladdingDir) * ((CDbl((i - 1)) / CDbl(Positioncal.PPR) + 0.5) * effectivepitch + Positioncal.CladWidth / 2.0 + meanderamp) * Math.Cos(coneangle)) * Math.Sin((CDbl((inioverweld / 100.0F)) + CDbl((i + Positioncal.PPR - 1)) / CDbl(Positioncal.PPR)) * 2.0 * 3.1415926535897931)
				positions(1, i + Positioncal.PPR + 1) = distance + CDbl(Positioncal.CladdingDir) * ((CDbl((i - 1)) / CDbl(Positioncal.PPR) + 0.5) * effectivepitch + Positioncal.CladWidth / 2.0 + meanderamp) * Math.Sin(coneangle) + tooloffset * Math.Cos(coneangle)
				positions(2, i + Positioncal.PPR + 1) = (diameter / 2.0 - CDbl(Positioncal.CladdingDir) * ((CDbl((i - 1)) / CDbl(Positioncal.PPR) + 0.5) * effectivepitch + Positioncal.CladWidth / 2.0 + meanderamp) * Math.Cos(coneangle) + 1.5) * Math.Cos((CDbl((inioverweld / 100.0F)) + CDbl((i + Positioncal.PPR - 1)) / CDbl(Positioncal.PPR)) * 2.0 * 3.1415926535897931) + tooloffset * Math.Sin(coneangle) - 1.5
				positions(3, i + Positioncal.PPR + 1) = 90.0 + postureangle
				positions(4, i + Positioncal.PPR + 1) = Ry
				positions(5, i + Positioncal.PPR + 1) = Rz
			Next
			Dim num7 As Integer = 1
			Dim num8 As Integer = CInt(Math.Round(CDbl(Positioncal.PPR) / 2.0))
			For i As Integer = num7 To num8
				If finaldistance = 0.0 Then
					' The following expression was wrapped in a unchecked-expression
					' The following expression was wrapped in a checked-expression
					' The following expression was wrapped in a checked-expression
					positions(0, i + Positioncal.PPR + pointnumber - 1) = (diameter / 2.0 - CDbl(Positioncal.CladdingDir) * (width1 - Positioncal.CladWidth / 2.0 - meanderamp) * Math.Cos(coneangle)) * Math.Sin((CDbl((inioverweld / 100.0F * CSng((i + Positioncal.PPR - 1)) / CSng(Positioncal.PPR))) + CDbl((i + Positioncal.PPR + pointnumber - 3)) / CDbl(Positioncal.PPR)) * 2.0 * 3.1415926535897931)
					positions(1, i + Positioncal.PPR + pointnumber - 1) = distance + CDbl(Positioncal.CladdingDir) * (width1 - Positioncal.CladWidth / 2.0 - meanderamp) * Math.Sin(coneangle) + tooloffset * Math.Cos(coneangle)
					positions(2, i + Positioncal.PPR + pointnumber - 1) = (diameter / 2.0 - CDbl(Positioncal.CladdingDir) * (width1 - Positioncal.CladWidth / 2.0 - meanderamp) * Math.Cos(coneangle) + 1.5) * Math.Cos((CDbl((inioverweld / 100.0F * CSng((i + Positioncal.PPR - 1)) / CSng(Positioncal.PPR))) + CDbl((i + Positioncal.PPR + pointnumber - 3)) / CDbl(Positioncal.PPR)) * 2.0 * 3.1415926535897931) + tooloffset * Math.Sin(coneangle) - 1.5
					positions(3, i + Positioncal.PPR + pointnumber - 1) = 90.0 + postureangle
					positions(4, i + Positioncal.PPR + pointnumber - 1) = Ry
					positions(5, i + Positioncal.PPR + pointnumber - 1) = Rz
				Else
					' The following expression was wrapped in a unchecked-expression
					' The following expression was wrapped in a checked-expression
					' The following expression was wrapped in a checked-expression
					positions(0, i + Positioncal.PPR + pointnumber - 1) = (diameter / 2.0 - CDbl(Positioncal.CladdingDir) * (width1 - Positioncal.CladWidth / 2.0 - meanderamp) * Math.Cos(coneangle)) * Math.Sin((CDbl((inioverweld / 100.0F * CSng((i + Positioncal.PPR - 1)) / CSng(Positioncal.PPR))) + CDbl((i + Positioncal.PPR + pointnumber - 4)) / CDbl(Positioncal.PPR) + finaldistance) * 2.0 * 3.1415926535897931)
					positions(1, i + Positioncal.PPR + pointnumber - 1) = distance + CDbl(Positioncal.CladdingDir) * (width1 - Positioncal.CladWidth / 2.0 - meanderamp) * Math.Sin(coneangle) + tooloffset * Math.Cos(coneangle)
					positions(2, i + Positioncal.PPR + pointnumber - 1) = (diameter / 2.0 - CDbl(Positioncal.CladdingDir) * (width1 - Positioncal.CladWidth / 2.0 - meanderamp) * Math.Cos(coneangle) + 1.5) * Math.Cos((CDbl((inioverweld / 100.0F * CSng((i + Positioncal.PPR - 1)) / CSng(Positioncal.PPR))) + CDbl((i + Positioncal.PPR + pointnumber - 4)) / CDbl(Positioncal.PPR) + finaldistance) * 2.0 * 3.1415926535897931) + tooloffset * Math.Sin(coneangle) - 1.5
					positions(3, i + Positioncal.PPR + pointnumber - 1) = 90.0 + postureangle
					positions(4, i + Positioncal.PPR + pointnumber - 1) = Ry
					positions(5, i + Positioncal.PPR + pointnumber - 1) = Rz
				End If
			Next
			positions(0, CInt(Math.Round(1.5 * CDbl(Positioncal.PPR) + CDbl(pointnumber)))) = (diameter / 2.0 - CDbl(Positioncal.CladdingDir) * (width1 - Positioncal.CladWidth / 2.0 - meanderamp) * Math.Cos(coneangle)) * Math.Sin((CDbl((inioverweld / 100.0F * 2.0F)) + (1.5 * CDbl(Positioncal.PPR) + CDbl(pointnumber) - 3.0) / CDbl(Positioncal.PPR) + finaldistance) * 2.0 * 3.1415926535897931)
			positions(1, CInt(Math.Round(1.5 * CDbl(Positioncal.PPR) + CDbl(pointnumber)))) = distance + CDbl(Positioncal.CladdingDir) * (width1 - Positioncal.CladWidth / 2.0 - meanderamp) * Math.Sin(coneangle) + tooloffset * Math.Cos(coneangle)
			positions(2, CInt(Math.Round(1.5 * CDbl(Positioncal.PPR) + CDbl(pointnumber)))) = (diameter / 2.0 - CDbl(Positioncal.CladdingDir) * (width1 - Positioncal.CladWidth / 2.0 - meanderamp) * Math.Cos(coneangle) + 1.5) * Math.Cos((CDbl((inioverweld / 100.0F * 2.0F)) + (1.5 * CDbl(Positioncal.PPR) + CDbl(pointnumber) - 3.0) / CDbl(Positioncal.PPR) + finaldistance) * 2.0 * 3.1415926535897931) + tooloffset * Math.Sin(coneangle) - 1.5
			positions(3, CInt(Math.Round(1.5 * CDbl(Positioncal.PPR) + CDbl(pointnumber)))) = 90.0 + postureangle
			positions(4, CInt(Math.Round(1.5 * CDbl(Positioncal.PPR) + CDbl(pointnumber)))) = Ry
			positions(5, CInt(Math.Round(1.5 * CDbl(Positioncal.PPR) + CDbl(pointnumber)))) = Rz
			positions(0, CInt(Math.Round(1.5 * CDbl(Positioncal.PPR) + CDbl(pointnumber) + 1.0))) = CDbl(Positioncal.HomePos(0))
			positions(1, CInt(Math.Round(1.5 * CDbl(Positioncal.PPR) + CDbl(pointnumber) + 1.0))) = CDbl(Positioncal.HomePos(1))
			positions(2, CInt(Math.Round(1.5 * CDbl(Positioncal.PPR) + CDbl(pointnumber) + 1.0))) = CDbl(Positioncal.HomePos(2))
			positions(3, CInt(Math.Round(1.5 * CDbl(Positioncal.PPR) + CDbl(pointnumber) + 1.0))) = CDbl(Positioncal.HomePos(3))
			positions(4, CInt(Math.Round(1.5 * CDbl(Positioncal.PPR) + CDbl(pointnumber) + 1.0))) = CDbl(Positioncal.HomePos(4))
			positions(5, CInt(Math.Round(1.5 * CDbl(Positioncal.PPR) + CDbl(pointnumber) + 1.0))) = CDbl(Positioncal.HomePos(5))
			expositions(1, 0) = 331776.0 * initialang / 360.0 * CDbl(Positioncal.DirectionFlg)
			expositions(1, 1) = 331776.0 * initialang / 360.0 * CDbl(Positioncal.DirectionFlg)
			Dim num9 As Integer = 1
			Dim ppr As Integer = Positioncal.PPR
			For i As Integer = num9 To ppr
				' The following expression was wrapped in a unchecked-expression
				' The following expression was wrapped in a checked-expression
				expositions(1, i + 1) = 331776.0 * (initialang / 360.0 + CDbl(((inioverweld / 100.0F + 1.0F) * CSng((i - 1)) / CSng(Positioncal.PPR)))) * CDbl(Positioncal.DirectionFlg)
			Next
			Dim num10 As Integer = 1
			Dim num11 As Integer = pointnumber - 2
			For i As Integer = num10 To num11
				' The following expression was wrapped in a unchecked-expression
				' The following expression was wrapped in a checked-expression
				expositions(1, i + Positioncal.PPR + 1) = 331776.0 * (initialang / 360.0 + CDbl((inioverweld / 100.0F)) + CDbl((i + Positioncal.PPR - 1)) / CDbl(Positioncal.PPR)) * CDbl(Positioncal.DirectionFlg)
			Next
			Dim num12 As Integer = 1
			Dim num13 As Integer = CInt(Math.Round(CDbl(Positioncal.PPR) / 2.0 + 1.0))
			For i As Integer = num12 To num13
				If finaldistance = 0.0 Then
					' The following expression was wrapped in a unchecked-expression
					' The following expression was wrapped in a checked-expression
					' The following expression was wrapped in a checked-expression
					expositions(1, i + Positioncal.PPR + pointnumber - 1) = 331776.0 * (initialang / 360.0 + CDbl((inioverweld / 100.0F * CSng((i + Positioncal.PPR - 1)) / CSng(Positioncal.PPR))) + CDbl((i + Positioncal.PPR + pointnumber - 3)) / CDbl(Positioncal.PPR)) * CDbl(Positioncal.DirectionFlg)
				Else
					' The following expression was wrapped in a unchecked-expression
					' The following expression was wrapped in a checked-expression
					' The following expression was wrapped in a checked-expression
					expositions(1, i + Positioncal.PPR + pointnumber - 1) = 331776.0 * (initialang / 360.0 + CDbl((inioverweld / 100.0F * CSng((i + Positioncal.PPR - 1)) / CSng(Positioncal.PPR))) + CDbl((i + Positioncal.PPR + pointnumber - 4)) / CDbl(Positioncal.PPR) + finaldistance) * CDbl(Positioncal.DirectionFlg)
				End If
			Next
			expositions(1, CInt(Math.Round(1.5 * CDbl(Positioncal.PPR) + CDbl(pointnumber) + 2.0))) = 0.0
			Dim meanderfreq As Double = processspeed / (4.0 * meanderamp)
			Dim power As Double = CDbl(Positioncal.LaserPowerIni) * 0.0025 + -1.1111
			Dim feed As Double = 0.1 * Positioncal.PowderFeed
			Dim headertxt As String = String.Concat(New String() {"/JOB" & vbCrLf & "//NAME HOSTMOV" & vbCrLf & "//POS" & vbCrLf & "///NPOS ", Conversions.ToString(1.5 * CDbl(Positioncal.PPR) + CDbl(pointnumber) + 2.0), ",0,", Conversions.ToString(1.5 * CDbl(Positioncal.PPR) + CDbl(pointnumber) + 2.0), ",2,0,2" & vbCrLf & "///USER 6" & vbCrLf})
			If Positioncal.Toolno = 0 Then
				headertxt += "///TOOL 0" & vbCrLf
			Else
				headertxt += "///TOOL 1" & vbCrLf
			End If
			headertxt += "///POSTYPE USER" & vbCrLf & "///RECTAN" & vbCrLf & "///RCONF 1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0" & vbCrLf
			Dim num14 As Integer = 0
			Dim j As Short
			Dim num15 As Integer = CInt(Math.Round(1.5 * CDbl(Positioncal.PPR) + CDbl(pointnumber)))
			For ind As Integer = num14 To num15
				headertxt = headertxt + "C" + ind.ToString("0000#=")
				j = 0S

				Do
					headertxt = headertxt + positions(CInt(j), ind).ToString("#0.000;-#0.000;0.000") + ","
					j += 1S
				Loop While j <= 2S
				j = 3S
				Do
					headertxt = headertxt + positions(CInt(j), ind).ToString("#0.00;-#0.00;0.00") + ","
					j += 1S
				Loop While j <= 4S
				headertxt = headertxt + positions(5, ind).ToString("#0.00;-#0.00;0.00") + vbCrLf

			Next
			headertxt += "///POSTYPE PULSE" & vbCrLf & "///PULSE" & vbCrLf
			headertxt = headertxt + "C" + (1.5 * CDbl(Positioncal.PPR) + CDbl(pointnumber) + 1.0).ToString("0000#=")
			j = 0S
			Do
				' The following expression was wrapped in a checked-expression
				' The following expression was wrapped in a unchecked-expression
				headertxt = headertxt + positions(CInt(j), CInt(Math.Round(1.5 * CDbl(Positioncal.PPR) + CDbl(pointnumber) + 1.0))).ToString("#;-#;0") + ","
				j += 1S
			Loop While j <= 4S
			Dim mainprogtxt As String
			headertxt = headertxt + positions(5, CInt(Math.Round(1.5 * CDbl(Positioncal.PPR) + CDbl(pointnumber) + 1.0))).ToString("#;-#;0") + vbCrLf
			Dim num16 As Integer = 0
			Dim num17 As Integer = CInt(Math.Round(1.5 * CDbl(Positioncal.PPR) + CDbl(pointnumber) + 1.0))
			For ind As Integer = num16 To num17
				headertxt = String.Concat(New String() {headertxt, "EC", ind.ToString("0000#="), 82944.0.ToString("#"), expositions(1, ind).ToString("#0;-#0;0"), vbCrLf})
			Next
			headertxt = headertxt + "///POSTYPE BASE" & vbCrLf & "///RECTAN" & vbCrLf & "P0000=0.000,0.000,0.000,0.00,0.00,0.00" & vbCrLf & "P0001=0.000,0.000,0.000,0.00,0.00,0.00" & vbCrLf & "///POSTYPE PULSE" & vbCrLf & "///PULSE" & vbCrLf & "EX0000=0" & vbCrLf & "EX0001=0" & vbCrLf & "//INST" & vbCrLf & "///DATE " + mydatetime.ToString("yyyy/MM/dd HH:mm") + vbCrLf & "///COMM SUB TASK TO HOSTMAST" & vbCrLf & "///ATTR SC,RW,RJ" & vbCrLf & "////FRAME USER 5" & vbCrLf & "///GROUP1 RB1" & vbCrLf & "///GROUP2 ST1" & vbCrLf & "///LVARS 0,0,0,0,0,0,0,0"
			mainprogtxt = "NOP" & vbCrLf
			If meanderflg = 1S Then
				' The following expression was wrapped in a unchecked-expression
				' The following expression was wrapped in a unchecked-expression
				mainprogtxt = String.Concat(New String() {mainprogtxt, "SETFILE WEV#(1) (4) ", Conversions.ToString(CInt(Math.Round(meanderfreq * 10.0))), vbCrLf & "SETFILE WEV#(1) (5) ", Conversions.ToString(CInt(Math.Round(meanderamp * 1000.0))), vbCrLf & "SETFILE WEV#(1) (8) 0" & vbCrLf & "SETFILE WEV#(1) (9) 0" & vbCrLf})
			End If
			mainprogtxt = String.Concat(New String() {mainprogtxt, "CALL JOB:STRESET" & vbCrLf & "GETS PX000 $PX000" & vbCrLf & "CNVRT PX000 PX000 UF#(6)" & vbCrLf & "SETE P000 (2) ", (positions(1, 0) * 1000.0).ToString("#"), vbCrLf & "MOVL P000 V=", Positioncal.IdleSpeed.ToString("#0.0"), " PL=0  +MOVJ EX000 VJ=100.00" & vbCrLf & "GETS PX000 $PX000" & vbCrLf & "GETE D000 P000 (4)" & vbCrLf & "CALL JOB:ARMCOR IF D000>=", 184115.0.ToString("#"), vbCrLf & "CALL JOB:ARMCOR IF D000<=-", 184115.0.ToString("#"), vbCrLf & "MOVJ C00000 VJ=", 5.ToString("#0.0"), " PL=0 NWAIT  +MOVJ EC00000 VJ=100.00" & vbCrLf & "DOUT OT#(1) ON" & vbCrLf & "DOUT OT#(8) ON" & vbCrLf & "JUMP *PILOTON IF IN#(2)=ON" & vbCrLf & "WAIT IN#(6)=ON T=5.00" & vbCrLf & "JUMP *END IF IN#(6)=OFF" & vbCrLf & "DOUT OT#(2) ON" & vbCrLf & "DOUT OT#(7) ON" & vbCrLf})
			If Positioncal.PowderJar = 1S Then
				mainprogtxt += "DOUT OT#(5) ON" & vbCrLf
			Else
				mainprogtxt += "DOUT OT#(6) ON" & vbCrLf
			End If
			mainprogtxt = String.Concat(New String() {mainprogtxt, "DOUT OT#(10) ON" & vbCrLf & "TIMER T=", Positioncal.PowderSettling1.ToString("#0.00"), vbCrLf & "*PILOTON" & vbCrLf & "MOVL C00001 V=", Positioncal.ApproachSpeed.ToString("#0.0"), " PL=0 DEC=20  +MOVJ EC00001 VJ=100.00" & vbCrLf & "WAIT IN#(1)=ON T=5.00" & vbCrLf})
			mainprogtxt = mainprogtxt + "TIMER T=" + Positioncal.PowderSettling2.ToString("#0.00") + vbCrLf & "EI LEVEL= 2" & vbCrLf & "*STARTL" & vbCrLf
			If meanderflg = 1S Then
				processspeed = processspeed * Positioncal.MeanderPitch / (4.0 * meanderamp)
			End If
			Dim num18 As Integer = 2
			Dim num19 As Integer = CInt(Math.Round(1.5 * CDbl(Positioncal.PPR) + CDbl(pointnumber)))
			For i As Integer = num18 To num19

				If i = 2 Then
					mainprogtxt = String.Concat(New String() {mainprogtxt, "MOVC C", i.ToString("0000#"), " V=", Positioncal.ApproachSpeed.ToString("#0.00;-#.00;0.00"), " PL=2  +MOVJ EC", i.ToString("0000#"), vbCrLf & "DOUT OT#(3) ON" & vbCrLf & "DOUT OT#(9) ON" & vbCrLf & "ARCON AC=", (feed * (1.0 - CDbl(Positioncal.IniPowderRed) / 100.0) * 100.0).ToString("#0"), " AVP=", ((1.0 + CDbl(Positioncal.IniOverPower) / 100.0) * power * 10.0 + 50.0).ToString("#0"), vbCrLf & "ARCCTS AC=", (feed * 100.0).ToString("#0"), " AVP=", (power * 10.0 + 50.0).ToString("#0"), " AN3=", (10.0 * feed).ToString("#0.0"), " DIS=", Positioncal.IniOverPowerDis.ToString("#0.0"), vbCrLf})
					If meanderflg = 1S Then
						mainprogtxt += "SWVON WEV#(1)" & vbCrLf
					End If
				Else
					mainprogtxt = String.Concat(New String() {mainprogtxt, "MOVC C", i.ToString("0000#"), " V=", processspeed.ToString("#0.00;-#.00;0.00"), " PL=2  +MOVJ EC", i.ToString("0000#"), vbCrLf})
				End If
				If i >= Positioncal.PPR + 2 And CDbl(Positioncal.LaserReductionTrackNo) >= CDbl((i - 2)) / CDbl(Positioncal.PPR) And Math.IEEERemainder(CDbl((i + 2)), CDbl(Positioncal.PPR)) = 0.0 Then
					' The following expression was wrapped in a checked-expression
					' The following expression was wrapped in a checked-expression
					power = (CDbl(Positioncal.LaserPowerIni) - CDbl((Positioncal.LaserPowerIni - Positioncal.LaserPowerFin)) / CDbl(Positioncal.LaserReductionTrackNo) * CDbl((i - 2)) / CDbl(Positioncal.PPR)) * 10.0 / 4500.0
					mainprogtxt = String.Concat(New String() {mainprogtxt, "ARCSET AC=", (feed * 100.0).ToString("#0"), " AVP=", (power * 10.0 + 50.0).ToString("#0"), vbCrLf})
				End If
				If CDbl(i) = 1.5 * CDbl(Positioncal.PPR) + CDbl(pointnumber) - 1.0 AndAlso (Positioncal.FinOverPower <> 0 Or Positioncal.FinPowderRed <> 0) Then
					mainprogtxt = String.Concat(New String() {mainprogtxt, "ARCCTE AC=", (feed * 100.0).ToString("#0"), " AVP=", (power * (1.0 + CDbl(Positioncal.FinOverPower) / 100.0) * 10.0 + 50.0).ToString("#0"), " AN3=", (10.0 * feed).ToString("#0.0"), " DIS=", Positioncal.FinOverPowerDis.ToString("#0.0"), vbCrLf})
				End If
				If (If((-If(((CDbl(i) = 1.5 * CDbl(Positioncal.PPR) + CDbl(pointnumber) - 1.0) > False), 1S, 0S)), 1S, 0S) And meanderflg) <> 0S Then
					mainprogtxt += "WVOF" & vbCrLf
				End If

			Next
			mainprogtxt = String.Concat(New String() {mainprogtxt, "DI LEVEL= 2" & vbCrLf & "JUMP *END" & vbCrLf & "*QVERROR" & vbCrLf & "*END" & vbCrLf & "ARCOF" & vbCrLf & "DOUT OG#(1) 0" & vbCrLf & "DOUT OG#(2) 0" & vbCrLf & "CALL JOB:STRESET" & vbCrLf & "GETS PX000 $PX000" & vbCrLf & "CNVRT PX000 PX000 UF#(6)" & vbCrLf & "GETE D000 P000 (2)" & vbCrLf & "ADD D000 ", (Positioncal.IniYAxisOffset * 1000.0).ToString("#0"), vbCrLf & "SETE P000 (2) D000" & vbCrLf & "MOVL P000 V=", Positioncal.ApproachSpeed.ToString("#0.0"), " PL=0  +MOVJ EX000 VJ=100.00" & vbCrLf & "GETE D000 P000 (1)" & vbCrLf & "ADD D000 ", (Positioncal.IniXAxisOffset * 1000.0).ToString("#"), vbCrLf & "SETE P000 (1) D000" & vbCrLf & "MOVL P000 V=", Positioncal.ApproachSpeed.ToString("#0.0"), " PL=0  +MOVJ EX000 VJ=100.00" & vbCrLf & "MOVL C", (1.5 * CDbl(Positioncal.PPR) + CDbl(pointnumber) + 1.0).ToString("0000#"), " V=", Positioncal.IdleSpeed.ToString("#0.0"), " PL=0  +MOVJ EC", (1.5 * CDbl(Positioncal.PPR) + CDbl(pointnumber) + 1.0).ToString("0000#"), " VJ=100.00" & vbCrLf & "END"})
			Try
				FileSystem.FileOpen(1, Positioncal.BasePath + "hostmov.jbi", OpenMode.Output, OpenAccess.[Default], OpenShare.[Default], -1)
				FileSystem.PrintLine(1, New Object() {headertxt})
				FileSystem.PrintLine(1, New Object() {mainprogtxt})
				FileSystem.FileClose(New Integer() {1})
			Catch ex As Exception
			End Try
		End Sub

		' Token: 0x06000567 RID: 1383 RVA: 0x00010C78 File Offset: 0x0000F078
		<MethodImpl(MethodImplOptions.NoInlining Or MethodImplOptions.NoOptimization)>
		Public Sub Planeclad(length As Double, width1 As Double, xpos As Double, ypos As Double, zpos As Double, pitch As Double, processspeed As Double, postureangle As Double, meanderamp As Double, meanderflg As Short, tooloffset As Double, hWnd As Integer)
			Dim robotctr As Short() = New Short(7) {}
			Dim stationctr As Short() = New Short(15) {}
			Dim positions As Double(,) = New Double(6, 11) {}
			Dim expositions As Double(,) = New Double(6, 11) {}
			Dim Ry As Double = Positioncal.WorkYAxisTilt
			Dim Rz As Double = Positioncal.WorkZAxisYaw
			Dim mydatetime As DateTime = DateAndTime.Now
			If meanderflg = 0S Then
				meanderamp = 0.0
			End If
			Dim rotations As Integer = CInt(Math.Round(Math.Round(width1 - Positioncal.CladWidth - 2.0 * meanderamp / pitch, 2)))
			If rotations < 0 Then
				rotations = 0
			End If
			Dim effectivepitch As Double = (width1 - Positioncal.CladWidth - 2.0 * meanderamp) / CDbl(rotations)
			positions = CType(Utils.CopyArray(CType(positions, Array), New Double(6, 2 * rotations + 5 + 1 - 1) {}), Double(,))
			expositions = CType(Utils.CopyArray(CType(expositions, Array), New Double(6, 2 * rotations + 5 + 1 - 1) {}), Double(,))
			positions(0, 0) = xpos + Positioncal.CladWidth / 2.0 + meanderamp
			positions(1, 0) = ypos + Positioncal.CladWidth / 2.0 + meanderamp
			positions(2, 0) = zpos + Positioncal.IniZAxisOffset
			positions(3, 0) = postureangle + 90.0
			positions(4, 0) = Ry
			positions(5, 0) = Rz
			positions(0, 1) = xpos + Positioncal.CladWidth / 2.0 + meanderamp
			positions(1, 1) = ypos + Positioncal.CladWidth / 2.0 + meanderamp
			positions(2, 1) = zpos
			positions(3, 1) = postureangle + 90.0
			positions(4, 1) = Ry
			positions(5, 1) = Rz
			Dim i As Double = 1.0
			Dim num As Integer = 1
			Dim num2 As Integer = 2 * rotations
			For j As Integer = num To num2 Step 2
				' The following expression was wrapped in a unchecked-expression
				' The following expression was wrapped in a checked-expression
				positions(0, j + 1) = xpos + Positioncal.CladWidth / 2.0 + meanderamp + CDbl((passIndex - 1)) / 2.0 * effectivepitch
				positions(1, j + 1) = positions(1, j) + i * (length - Positioncal.CladWidth - 2.0 * meanderamp)
				positions(2, j + 1) = zpos
				positions(3, j + 1) = postureangle + 90.0
				positions(4, j + 1) = Ry
				positions(5, j + 1) = Rz
				positions(0, j + 2) = xpos + Positioncal.CladWidth / 2.0 + meanderamp + CDbl((j + 1)) / 2.0 * effectivepitch
				positions(1, j + 2) = positions(1, j) + i * (length - Positioncal.CladWidth - 2.0 * meanderamp)
				positions(2, j + 2) = zpos
				positions(3, j + 2) = postureangle + 90.0
				positions(4, j + 2) = Ry
				positions(5, j + 2) = Rz
				postureangle = 180.0 - postureangle
				If i = 1.0 Then
					i = -1.0
				Else
					i = 1.0
				End If
			Next
			positions(0, 2 * rotations + 2) = CDbl(Positioncal.HomePos(0))
			positions(1, 2 * rotations + 2) = CDbl(Positioncal.HomePos(1))
			positions(2, 2 * rotations + 2) = CDbl(Positioncal.HomePos(2))
			positions(3, 2 * rotations + 2) = CDbl(Positioncal.HomePos(3))
			positions(4, 2 * rotations + 2) = CDbl(Positioncal.HomePos(4))
			positions(5, 2 * rotations + 2) = CDbl(Positioncal.HomePos(5))
			Dim meanderfreq As Double = processspeed / (4.0 * meanderamp)
			Dim power As Double = 0.0025 * CDbl(Positioncal.LaserPowerIni) + -1.1111
			Dim feed As Double = 0.1 * Positioncal.PowderFeed
			Dim beamdia As Double = 2.3596 * Positioncal.CladWidth + -4.4599
			Dim headertxt As String
			Dim mainprogtxt As String
			Positioncal.TotalSteps = 2 * rotations + 3
			headertxt = String.Concat(New String() {"/JOB" & vbCrLf & "//NAME HOSTMOV" & vbCrLf & "//POS" & vbCrLf & "///NPOS ", Conversions.ToString(2 * rotations + 3), ",0,0,2,0,0" & vbCrLf & "///USER ", Positioncal.StationPosition.ToString(), vbCrLf & "///TOOL ", Positioncal.Toolno.ToString(), vbCrLf & "///POSTYPE USER" & vbCrLf & "///RECTAN" & vbCrLf & "///RCONF 1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0" & vbCrLf})
			Dim num3 As Integer = 0
			Dim num4 As Integer = 2 * rotations + 1
			Dim k As Short
			For ind As Integer = num3 To num4
				headertxt = headertxt + "C" + ind.ToString("0000#=")
				k = 0S

				Do
					headertxt = headertxt + positions(CInt(k), ind).ToString("#0.000;-#0.000;0.000") + ","
					k += 1S
				Loop While k <= 2S
				k = 3S
				Do
					headertxt = headertxt + positions(CInt(k), ind).ToString("#0.00;-#0.00;0.00") + ","
					k += 1S
				Loop While k <= 4S
				headertxt = headertxt + positions(5, ind).ToString("#0.00;-#0.00;0.00") + vbCrLf

			Next
			headertxt += "///POSTYPE PULSE" & vbCrLf & "///PULSE" & vbCrLf
			headertxt = headertxt + "C" + (2 * rotations + 2).ToString("0000#=")
			k = 0S
			Do
				headertxt = headertxt + positions(CInt(k), 2 * rotations + 2).ToString("#;-#;0") + ","

				k += 1S

			Loop While k <= 4S
			headertxt = headertxt + positions(5, 2 * rotations + 2).ToString("#;-#;0") + vbCrLf
			headertxt = headertxt + "///POSTYPE BASE" & vbCrLf & "///RECTAN" & vbCrLf & "P0000=0.000,0.000,0.000,0.00,0.00,0.00" & vbCrLf & "P0001=0.000,0.000,0.000,0.00,0.00,0.00" & vbCrLf & "//INST" & vbCrLf & "///DATE " + mydatetime.ToString("yyyy/MM/dd HH:mm") + vbCrLf & "///COMM SUB TASK TO HOSTMAST" & vbCrLf & "///ATTR SC,RW,RJ" & vbCrLf & "////FRAME USER 1" & vbCrLf & "///GROUP1 RB1" & vbCrLf & "///LVARS 0,0,0,0,0,0,0,0"
			mainprogtxt = "NOP" & vbCrLf & "EI LEVEL= 1" & vbCrLf
			If meanderflg = 1S Then
				' The following expression was wrapped in a unchecked-expression
				' The following expression was wrapped in a unchecked-expression
				mainprogtxt = String.Concat(New String() {mainprogtxt, "SETFILE WEV#(1) (4) ", Conversions.ToString(CInt(Math.Round(meanderfreq * 10.0))), vbCrLf & "SETFILE WEV#(1) (5) ", Conversions.ToString(CInt(Math.Round(meanderamp * 1000.0))), vbCrLf & "SETFILE WEV#(1) (8) 0" & vbCrLf & "SETFILE WEV#(1) (9) 0" & vbCrLf})
			End If
			mainprogtxt = String.Concat(New String() {mainprogtxt, "GETS PX000 $PX000" & vbCrLf & "CNVRT PX000 PX000 RF" & vbCrLf & "GETE D000 P000 (3)" & vbCrLf & "ADD D000 ", (Positioncal.IniZAxisOffset * 1000.0).ToString("#0"), vbCrLf & "JUMP *LABEL1 IF D000<=", Positioncal.MaxZRobotPos.ToString("#"), vbCrLf & "SET D000 ", Positioncal.MaxZRobotPos.ToString("#"), vbCrLf & "*LABEL1" & vbCrLf & "SETE P000 (3) D000" & vbCrLf & "MOVL P000 V=", Positioncal.IdleSpeed.ToString("#0.0"), " PL=0" & vbCrLf & "GETS PX000 $PX000" & vbCrLf & "GETE D000 P000 (4)" & vbCrLf & "CALL JOB:ARMCOR IF D000>=", 184115.0.ToString("#"), vbCrLf & "CALL JOB:ARMCOR IF D000<=-", 184115.0.ToString("#"), vbCrLf & "GETPOS PX000 STEP#(2)" & vbCrLf & "CNVRT PX000 PX000 RF" & vbCrLf & "GETE D000 P000 (3)" & vbCrLf & "JUMP *LABEL2 IF D000<", Positioncal.MaxZRobotPos.ToString("#"), vbCrLf & "SUB D000 ", Positioncal.MaxZRobotPos.ToString("#"), vbCrLf & "MUL D000 -1" & vbCrLf & "SETE P000 (1) 0" & vbCrLf & "SETE P000 (2) 0" & vbCrLf & "SETE P000 (3) D000" & vbCrLf & "SETE P000 (4) 0" & vbCrLf & "SETE P000 (5) 0" & vbCrLf & "SETE P000 (6) 0" & vbCrLf & "SFTON P000 RF" & vbCrLf & "*LABEL2" & vbCrLf & "MOVL C00000 V=", Positioncal.IdleSpeed.ToString("#0.0"), " PL=0 NWAIT" & vbCrLf & "DOUT OT#(1) ON" & vbCrLf & "DOUT OT#(8) ON" & vbCrLf & "JUMP *PILOTON IF IN#(2)=ON" & vbCrLf & "WAIT IN#(6)=ON T=5.00" & vbCrLf & "JUMP *END IF IN#(6)=OFF" & vbCrLf})
			If Positioncal.PowderJar = 1S Then
				mainprogtxt += "DOUT OT#(4) ON" & vbCrLf & "DOUT OT#(6) ON" & vbCrLf
			Else
				mainprogtxt += "DOUT OT#(5) ON" & vbCrLf & "DOUT OT#(7) ON" & vbCrLf
			End If
			mainprogtxt = String.Concat(New String() {mainprogtxt, "TIMER T=", Positioncal.PowderSettling1.ToString("#0.00"), vbCrLf & "*PILOTON" & vbCrLf & "SFTOF" & vbCrLf & "MOVL C00001 V=", Positioncal.ApproachSpeed.ToString("#0.0"), " PL=0 DEC=20" & vbCrLf & "DOUT OT#(7) ON" & vbCrLf & "WAIT IN#(1)=ON T=5.00" & vbCrLf & "JUMP *QVERROR IF IN#(1)=ON" & vbCrLf & "TIMER T=", Positioncal.PowderSettling2.ToString("#0.00"), vbCrLf & "EI LEVEL= 3" & vbCrLf & "*STARTL" & vbCrLf & "DOUT OT#(2) ON" & vbCrLf})
			If meanderflg = 1S Then
				processspeed = processspeed * Positioncal.MeanderPitch / (4.0 * meanderamp)
			End If
			Dim num5 As Integer = 2
			Dim num6 As Integer = 2 * rotations + 1
			For j As Integer = num5 To num6
				If j = 2 Then
					' The following expression was wrapped in a unchecked-expression
					mainprogtxt = String.Concat(New String() {mainprogtxt, "ARCON AC=", (feed * (1.0 - CDbl(Positioncal.IniPowderRed) / 100.0) * 100.0).ToString("#0"), " AV=", ((1.0 + CDbl(Positioncal.IniOverPower) / 100.0) * power).ToString("#0.0"), vbCrLf & "ARCCTS AC=", (feed * 100.0).ToString("#0"), " AV=", power.ToString("#0.0"), " AN3=", beamdia.ToString("#0.0"), " DIS=", Positioncal.IniOverPowerDis.ToString("#0.0"), vbCrLf})
					If meanderflg = 1S Then
						mainprogtxt += "WVON WEV#(1)" & vbCrLf
					End If
					mainprogtxt = String.Concat(New String() {mainprogtxt, "MOVL C", j.ToString("0000#"), " V=", processspeed.ToString("#0.0;-#.0;0.0"), " PL=", Positioncal.PositionLevel.ToString("#"), vbCrLf})
				ElseIf j = 2 * rotations + 1 Then
					mainprogtxt = String.Concat(New String() {mainprogtxt, "MOVL C", j.ToString("0000#"), " V=", processspeed.ToString("#0.0;-#.0;0.0"), " PL=", Positioncal.PositionLevel.ToString("#"), " NWAIT" & vbCrLf})
				Else
					mainprogtxt = String.Concat(New String() {mainprogtxt, "MOVL C", j.ToString("0000#"), " V=", processspeed.ToString("#0.0;-#.0;0.0"), " PL=", Positioncal.PositionLevel.ToString("#"), vbCrLf})
				End If

				' The following expression was wrapped in a checked-expression
				If j >= 2 And Positioncal.LaserReductionTrackNo >= j - 2 And Math.IEEERemainder(CDbl((j + 2)), 2.0) = 0.0 Then
					' The following expression was wrapped in a checked-expression
					' The following expression was wrapped in a checked-expression
					power = (CDbl(Positioncal.LaserPowerIni) - CDbl((Positioncal.LaserPowerIni - Positioncal.LaserPowerFin)) / CDbl(Positioncal.LaserReductionTrackNo) * CDbl((j - 2)) / CDbl(Positioncal.PPR)) * 0.0025 + -1.1111
					mainprogtxt = String.Concat(New String() {mainprogtxt, "ARCSET AC=", (feed * 100.0).ToString("#0"), " AV=", power.ToString("#0.0"), " AN3=", beamdia.ToString("#0.0"), vbCrLf})
				End If
				If j = 2 * rotations AndAlso (Positioncal.FinOverPower <> 0 Or Positioncal.FinPowderRed <> 0) Then
					power = 0.0025 * CDbl(Positioncal.LaserPowerFin) * (1.0 + CDbl(Positioncal.FinOverPower) / 100.0) + -1.1111
					feed = 0.1 * (Positioncal.PowderFeed * CDbl((100 - Positioncal.FinPowderRed)) / 100.0)
					mainprogtxt = String.Concat(New String() {mainprogtxt, "ARCCTE AC=", (feed * 100.0).ToString("#0"), " AV=", power.ToString("#0.0"), " AN3=", beamdia.ToString("#0.0"), " DIS=", Positioncal.FinOverPowerDis.ToString("#0.0"), vbCrLf})
				End If
				If (If((-If(((j = 2 * rotations + 1) > False), 1S, 0S)), 1S, 0S) And meanderflg) <> 0S Then
					mainprogtxt += "WVOF" & vbCrLf
				End If

			Next
			mainprogtxt = String.Concat(New String() {mainprogtxt, "DI LEVEL= 2" & vbCrLf & "JUMP *END" & vbCrLf & "*QVERROR" & vbCrLf & "*END" & vbCrLf & "ARCOF" & vbCrLf & "DOUT OG#(1) 0" & vbCrLf & "DOUT OG#(2) 0" & vbCrLf & "GETS PX000 $PX000" & vbCrLf & "CNVRT PX000 PX000 BF" & vbCrLf & "GETE D000 P000 (3)" & vbCrLf & "ADD D000 ", (Positioncal.IniZAxisOffset * 1000.0).ToString("#0"), vbCrLf & "JUMP *LABEL3 IF D000<=", Positioncal.MaxZRobotPos.ToString("#"), vbCrLf & "SET D000 ", Positioncal.MaxZRobotPos.ToString("#"), vbCrLf & "*LABEL3" & vbCrLf & "SETE P000 (3) D000" & vbCrLf & "MOVL P000 V=", Positioncal.ApproachSpeed.ToString("#0.0"), " PL=0" & vbCrLf & "GETE D000 P000 (1)" & vbCrLf & "ADD D000 ", (Positioncal.IniXAxisOffset * 1000.0).ToString("#0"), vbCrLf & "SETE P000 (1) D000" & vbCrLf & "MOVL P000 V=", Positioncal.ApproachSpeed.ToString("#0.0"), " PL=0" & vbCrLf & "MOVL C", (2 * rotations + 2).ToString("0000#"), " V=", Positioncal.IdleSpeed.ToString("#0.0"), " PL=0" & vbCrLf & "END"})
			Try
				FileSystem.FileOpen(1, Positioncal.BasePath + "hostmov.jbi", OpenMode.Output, OpenAccess.[Default], OpenShare.[Default], -1)
				FileSystem.PrintLine(1, New Object() {headertxt})
				FileSystem.PrintLine(1, New Object() {mainprogtxt})
				FileSystem.FileClose(New Integer() {1})
				Positioncal.ControlGroup = 1S
			Catch ex As Exception
				Interaction.MsgBox("Job saving has failed due to the following reason: " + ex.Message, MsgBoxStyle.Exclamation, Nothing)
			End Try
		End Sub

		' Token: 0x06000568 RID: 1384 RVA: 0x00011BA0 File Offset: 0x0000FFA0
		<MethodImpl(MethodImplOptions.NoInlining Or MethodImplOptions.NoOptimization)>
		Public Sub boreclad(diameter As Double, width1 As Double, distance As Double, pitch As Double, processspeed As Double, postureangle As Double, coneangle As Double, stationposition As Integer, inioverweld As Single, finoverweld As Single, meanderamp As Double, meanderflg As Short, initialang As Double, tooloffset As Double, hWnd As Integer)
			Dim robotctr As Short() = New Short(7) {}
			Dim stationctr As Short() = New Short(15) {}
			Dim positions As Double(,) = New Double(6, 11) {}
			Dim expositions As Double(,) = New Double(6, 11) {}
			Dim Ry As Integer
			Dim Rz As Integer
			Dim mydatetime As DateTime
			Dim Claddingdir_loc As Short
			Dim Tiltaxispos As Integer
			Dim inipoints As Integer
			Dim finpoints As Integer
			Dim pointnumber As Integer
			Dim finaldistance As Double
			Ry = CInt(Math.Round(Positioncal.WorkYAxisTilt))
			Rz = CInt(Math.Round(Positioncal.WorkZAxisYaw))
			mydatetime = DateAndTime.Now
			Claddingdir_loc = CShort(Positioncal.CladdingDir)
			Select Case stationposition
				Case 2
					Tiltaxispos = 27648
				Case 3
					Tiltaxispos = 41472
				Case 4
					Tiltaxispos = 55296
				Case 5
					Tiltaxispos = 82944
			End Select
			coneangle = coneangle * 3.1415926535897931 / 180.0
			Positioncal.CrankThrow = 0.01
			If meanderflg = 0S Then
				meanderamp = 0.0
			End If
			inipoints = CInt(Math.Round(Math.Round(CDbl((inioverweld / 100.0F * 360.0F / 30.0F)))))
			If inipoints = 0 And inioverweld <> 0F Then
				inipoints = 1
			End If
			finpoints = CInt(Math.Round(Math.Round(CDbl((finoverweld / 100.0F * 360.0F / 30.0F)))))
			If finpoints = 0 And finoverweld <> 0F Then
				finpoints = 1
			End If
			Dim rotations As Double = Math.Round(width1 - Positioncal.CladWidth - 2.0 * meanderamp / pitch, 2)
			If rotations < 0.0 Then
				rotations = 0.0
			End If
			pointnumber = CInt(Math.Round(Math.Ceiling(rotations * CDbl(Positioncal.PPR))))
			finaldistance = rotations - Conversion.Int(rotations * CDbl(Positioncal.PPR)) / CDbl(Positioncal.PPR)
			positions = CType(Utils.CopyArray(CType(positions, Array), New Double(6, inipoints + pointnumber + finpoints + 5 + 1 - 1) {}), Double(,))
			expositions = CType(Utils.CopyArray(CType(expositions, Array), New Double(6, inipoints + pointnumber + finpoints + 5 + 1 - 1) {}), Double(,))
			positions(0, 0) = Positioncal.IniXAxisOffset
			positions(1, 0) = distance + CDbl(Claddingdir_loc) * (Positioncal.CladWidth / 2.0 + meanderamp) * Math.Cos(coneangle) + Positioncal.IniYAxisOffset
			positions(2, 0) = Positioncal.CrankThrow - diameter / 2.0 + CDbl(Claddingdir_loc) * (Positioncal.CladWidth / 2.0 + meanderamp) * Math.Sin(coneangle) - Positioncal.IniZAxisOffset
			positions(3, 0) = postureangle + 90.0
			positions(4, 0) = CDbl(Ry)
			positions(5, 0) = CDbl(Rz)
			positions(0, 1) = Positioncal.IniXAxisOffset
			positions(1, 1) = distance + CDbl(Claddingdir_loc) * (Positioncal.CladWidth / 2.0 + meanderamp) * Math.Cos(coneangle) + tooloffset * Math.Sin(coneangle)
			positions(2, 1) = Positioncal.CrankThrow - diameter / 2.0 + CDbl(Claddingdir_loc) * (Positioncal.CladWidth / 2.0 + meanderamp) * Math.Sin(coneangle) + tooloffset * Math.Cos(coneangle)
			positions(3, 1) = postureangle + 90.0
			positions(4, 1) = CDbl(Ry)
			positions(5, 1) = CDbl(Rz)
			positions(0, 2) = Positioncal.WorkXAxisOffset
			positions(1, 2) = distance + CDbl(Claddingdir_loc) * (Positioncal.CladWidth / 2.0 + meanderamp) * Math.Cos(coneangle) + tooloffset * Math.Sin(coneangle)
			positions(2, 2) = Positioncal.CrankThrow - diameter / 2.0 + CDbl(Claddingdir_loc) * (Positioncal.CladWidth / 2.0 + meanderamp) * Math.Sin(coneangle) + tooloffset * Math.Cos(coneangle)
			positions(3, 2) = postureangle + 90.0
			positions(4, 2) = CDbl(Ry)
			positions(5, 2) = CDbl(Rz)
			Dim num As Integer = 1
			Dim num2 As Integer = inipoints
			For i As Integer = num To num2
				' The following expression was wrapped in a unchecked-expression
				' The following expression was wrapped in a checked-expression
				positions(0, i + 2) = Positioncal.WorkXAxisOffset + Positioncal.CrankThrow * Math.Sin((1.0 / CDbl(Positioncal.PPR) + CDbl((inioverweld / 100.0F * CSng((i - 1)) / CSng(inipoints)))) * 2.0 * 3.1415926535897931)
				positions(1, i + 2) = distance + CDbl(Claddingdir_loc) * (Positioncal.CladWidth / 2.0 + meanderamp) * Math.Cos(coneangle) + tooloffset * Math.Sin(coneangle)
				positions(2, i + 2) = Positioncal.CrankThrow * Math.Cos((1.0 / CDbl(Positioncal.PPR) + CDbl((inioverweld / 100.0F * CSng((i - 1)) / CSng(inipoints)))) * 2.0 * 3.1415926535897931) - diameter / 2.0 + CDbl(Claddingdir_loc) * (Positioncal.CladWidth / 2.0 + meanderamp) * Math.Sin(coneangle) + tooloffset * Math.Cos(coneangle)
				positions(3, i + 2) = postureangle + 90.0
				positions(4, i + 2) = CDbl(Ry)
				positions(5, i + 2) = CDbl(Rz)
			Next
			Dim j As Integer = 1
			Dim num3 As Integer = 1
			Dim num4 As Integer = pointnumber
			For i As Integer = num3 To num4
				' The following expression was wrapped in a unchecked-expression
				' The following expression was wrapped in a checked-expression
				positions(0, i + inipoints + 2) = Positioncal.WorkXAxisOffset + Positioncal.CrankThrow * Math.Sin((1.0 / CDbl(Positioncal.PPR) + CDbl((inioverweld / 100.0F)) + CDbl((i - 1)) / CDbl(Positioncal.PPR)) * 2.0 * 3.1415926535897931)
				positions(1, i + inipoints + 2) = distance + CDbl(Claddingdir_loc) * (pitch * CDbl((i - 1)) / CDbl(Positioncal.PPR) + Positioncal.CladWidth / 2.0 + meanderamp) * Math.Cos(coneangle) + tooloffset * Math.Sin(coneangle)
				positions(2, i + inipoints + 2) = Positioncal.CrankThrow * Math.Cos((1.0 / CDbl(Positioncal.PPR) + CDbl((inioverweld / 100.0F)) + CDbl((i - 1)) / CDbl(Positioncal.PPR)) * 2.0 * 3.1415926535897931) - diameter / 2.0 + CDbl(Claddingdir_loc) * (pitch * CDbl((i - 1)) / CDbl(Positioncal.PPR) + Positioncal.CladWidth / 2.0 + meanderamp) * Math.Sin(coneangle) + tooloffset * Math.Cos(coneangle)
				positions(3, i + inipoints + 2) = postureangle + 90.0 + CDbl(j) * Positioncal.Tiltangle
				positions(4, i + inipoints + 2) = CDbl(Ry)
				positions(5, i + inipoints + 2) = CDbl(Rz)
				If j = 1 Then
					j = -1
				Else
					j = 1
				End If
			Next
			Dim num5 As Integer = 1
			Dim num6 As Integer = finpoints
			For i As Integer = num5 To num6
				If finaldistance = 0.0 Then
					' The following expression was wrapped in a unchecked-expression
					' The following expression was wrapped in a checked-expression
					' The following expression was wrapped in a checked-expression
					positions(0, i + inipoints + pointnumber + 2) = Positioncal.WorkXAxisOffset + Positioncal.CrankThrow * Math.Sin((1.0 / CDbl(Positioncal.PPR) + CDbl((inioverweld / 100.0F)) + CDbl((finoverweld / 100.0F * CSng((i - 1)) / CSng(finpoints))) + CDbl((pointnumber - 1)) / CDbl(Positioncal.PPR)) * 2.0 * 3.1415926535897931)
					positions(1, i + inipoints + pointnumber + 2) = distance + CDbl(Claddingdir_loc) * (width1 - Positioncal.CladWidth / 2.0 - meanderamp) * Math.Cos(coneangle) + tooloffset * Math.Sin(coneangle)
					positions(2, i + inipoints + pointnumber + 2) = Positioncal.CrankThrow * Math.Cos((1.0 / CDbl(Positioncal.PPR) + CDbl((inioverweld / 100.0F)) + CDbl((finoverweld / 100.0F * CSng((i - 1)) / CSng(finpoints))) + CDbl((pointnumber - 1)) / CDbl(Positioncal.PPR)) * 2.0 * 3.1415926535897931) - diameter / 2.0 + CDbl(Claddingdir_loc) * (width1 - Positioncal.CladWidth / 2.0 - meanderamp) * Math.Sin(coneangle) + tooloffset * Math.Cos(coneangle)
				Else
					' The following expression was wrapped in a unchecked-expression
					' The following expression was wrapped in a checked-expression
					' The following expression was wrapped in a checked-expression
					positions(0, i + inipoints + pointnumber + 2) = Positioncal.WorkXAxisOffset + Positioncal.CrankThrow * Math.Sin((1.0 / CDbl(Positioncal.PPR) + CDbl((inioverweld / 100.0F)) + CDbl((finoverweld / 100.0F * CSng((i - 1)) / CSng(finpoints))) + CDbl((pointnumber - 2)) / CDbl(Positioncal.PPR) + finaldistance) * 2.0 * 3.1415926535897931)
					positions(1, i + inipoints + pointnumber + 2) = distance + CDbl(Claddingdir_loc) * (width1 - Positioncal.CladWidth / 2.0 - meanderamp) * Math.Cos(coneangle) + tooloffset * Math.Sin(coneangle)
					positions(2, i + inipoints + pointnumber + 2) = Positioncal.CrankThrow * Math.Cos((1.0 / CDbl(Positioncal.PPR) + CDbl((inioverweld / 100.0F)) + CDbl((finoverweld / 100.0F * CSng((i - 1)) / CSng(finpoints))) + CDbl((pointnumber - 2)) / CDbl(Positioncal.PPR) + finaldistance) * 2.0 * 3.1415926535897931) - diameter / 2.0 + CDbl(Claddingdir_loc) * (width1 - Positioncal.CladWidth / 2.0 - meanderamp) * Math.Sin(coneangle) + tooloffset * Math.Cos(coneangle)
				End If
				positions(3, i + inipoints + pointnumber + 2) = postureangle + 90.0
				positions(4, i + inipoints + pointnumber + 2) = CDbl(Ry)
				positions(5, i + inipoints + pointnumber + 2) = CDbl(Rz)
			Next
			If finaldistance = 0.0 Then
				' The following expression was wrapped in a unchecked-expression
				' The following expression was wrapped in a checked-expression
				positions(0, inipoints + pointnumber + finpoints + 3) = Positioncal.WorkXAxisOffset + Positioncal.CrankThrow * Math.Sin((1.0 / CDbl(Positioncal.PPR) + CDbl((inioverweld / 100.0F)) + CDbl((pointnumber - 1)) / CDbl(Positioncal.PPR) + CDbl((finoverweld / 100.0F))) * 2.0 * 3.1415926535897931)
				positions(1, inipoints + pointnumber + finpoints + 3) = distance + CDbl(Claddingdir_loc) * (width1 - Positioncal.CladWidth / 2.0 - meanderamp) * Math.Cos(coneangle) + tooloffset * Math.Sin(coneangle)
				positions(2, inipoints + pointnumber + finpoints + 3) = Positioncal.CrankThrow * Math.Cos((1.0 / CDbl(Positioncal.PPR) + CDbl((inioverweld / 100.0F)) + CDbl((pointnumber - 1)) / CDbl(Positioncal.PPR) + CDbl((finoverweld / 100.0F))) * 2.0 * 3.1415926535897931) - diameter / 2.0 + CDbl(Claddingdir_loc) * (width1 - Positioncal.CladWidth / 2.0 - meanderamp) * Math.Sin(coneangle) + tooloffset * Math.Cos(coneangle)
			Else
				' The following expression was wrapped in a unchecked-expression
				' The following expression was wrapped in a checked-expression
				positions(0, inipoints + pointnumber + finpoints + 3) = Positioncal.WorkXAxisOffset + Positioncal.CrankThrow * Math.Sin((1.0 / CDbl(Positioncal.PPR) + CDbl((inioverweld / 100.0F)) + CDbl((pointnumber - 2)) / CDbl(Positioncal.PPR) + finaldistance + CDbl((finoverweld / 100.0F))) * 2.0 * 3.1415926535897931)
				positions(1, inipoints + pointnumber + finpoints + 3) = distance + CDbl(Claddingdir_loc) * (width1 - Positioncal.CladWidth / 2.0 - meanderamp) * Math.Cos(coneangle) + tooloffset * Math.Sin(coneangle)
				positions(2, inipoints + pointnumber + finpoints + 3) = Positioncal.CrankThrow * Math.Cos((1.0 / CDbl(Positioncal.PPR) + CDbl((inioverweld / 100.0F)) + CDbl((pointnumber - 2)) / CDbl(Positioncal.PPR) + finaldistance + CDbl((finoverweld / 100.0F))) * 2.0 * 3.1415926535897931) - diameter / 2.0 + CDbl(Claddingdir_loc) * (width1 - Positioncal.CladWidth / 2.0 - meanderamp) * Math.Sin(coneangle) + tooloffset * Math.Cos(coneangle)
			End If
			positions(3, inipoints + pointnumber + finpoints + 3) = postureangle + 90.0
			positions(4, inipoints + pointnumber + finpoints + 3) = CDbl(Ry)
			positions(5, inipoints + pointnumber + finpoints + 3) = CDbl(Rz)
			positions(0, inipoints + pointnumber + finpoints + 4) = CDbl(Positioncal.HomePos(0))
			positions(1, inipoints + pointnumber + finpoints + 4) = CDbl(Positioncal.HomePos(1))
			positions(2, inipoints + pointnumber + finpoints + 4) = CDbl(Positioncal.HomePos(2))
			positions(3, inipoints + pointnumber + finpoints + 4) = CDbl(Positioncal.HomePos(3))
			positions(4, inipoints + pointnumber + finpoints + 4) = CDbl(Positioncal.HomePos(4))
			positions(5, inipoints + pointnumber + finpoints + 4) = CDbl(Positioncal.HomePos(5))
			expositions(1, 0) = 331776.0 * initialang / 360.0
			expositions(1, 1) = 331776.0 * initialang / 360.0
			expositions(1, 2) = 331776.0 * initialang / 360.0
			Dim num7 As Integer = 1
			Dim num8 As Integer = inipoints
			For i As Integer = num7 To num8
				' The following expression was wrapped in a unchecked-expression
				' The following expression was wrapped in a checked-expression
				expositions(1, i + 2) = 331776.0 * (initialang / 360.0 + (1.0 / CDbl(Positioncal.PPR) + CDbl((inioverweld / 100.0F * CSng((i - 1)) / CSng(inipoints)))) * CDbl(Positioncal.DirectionFlg))
			Next
			Dim num9 As Integer = 1
			Dim num10 As Integer = pointnumber
			For i As Integer = num9 To num10
				' The following expression was wrapped in a unchecked-expression
				' The following expression was wrapped in a checked-expression
				expositions(1, i + inipoints + 2) = 331776.0 * (initialang / 360.0 + (1.0 / CDbl(Positioncal.PPR) + CDbl((inioverweld / 100.0F)) + CDbl((i - 1)) / CDbl(Positioncal.PPR)) * CDbl(Positioncal.DirectionFlg))
			Next
			Dim num11 As Integer = 1
			Dim num12 As Integer = finpoints
			For i As Integer = num11 To num12
				If finaldistance = 0.0 Then
					' The following expression was wrapped in a unchecked-expression
					' The following expression was wrapped in a checked-expression
					expositions(1, i + inipoints + pointnumber + 2) = 331776.0 * (initialang / 360.0 + (1.0 / CDbl(Positioncal.PPR) + CDbl((inioverweld / 100.0F)) + CDbl((finoverweld / 100.0F * CSng((i - 1)) / CSng(finpoints))) + CDbl(pointnumber) / CDbl(Positioncal.PPR)) * CDbl(Positioncal.DirectionFlg))
				Else
					' The following expression was wrapped in a unchecked-expression
					' The following expression was wrapped in a checked-expression
					' The following expression was wrapped in a checked-expression
					expositions(1, i + inipoints + pointnumber + 2) = 331776.0 * (initialang / 360.0 + (1.0 / CDbl(Positioncal.PPR) + CDbl((inioverweld / 100.0F)) + CDbl((finoverweld / 100.0F * CSng((i - 1)) / CSng(finpoints))) + CDbl((pointnumber - 1)) / CDbl(Positioncal.PPR) + finaldistance) * CDbl(Positioncal.DirectionFlg))
				End If
			Next
			If finaldistance = 0.0 Then
				' The following expression was wrapped in a unchecked-expression
				expositions(1, inipoints + pointnumber + finpoints + 3) = 331776.0 * (initialang / 360.0 + (1.0 / CDbl(Positioncal.PPR) + CDbl((inioverweld / 100.0F)) + CDbl(pointnumber) / CDbl(Positioncal.PPR) + CDbl((finoverweld / 100.0F))) * CDbl(Positioncal.DirectionFlg))
			Else
				' The following expression was wrapped in a unchecked-expression
				' The following expression was wrapped in a checked-expression
				expositions(1, inipoints + pointnumber + finpoints + 3) = 331776.0 * (initialang / 360.0 + (1.0 / CDbl(Positioncal.PPR) + CDbl((inioverweld / 100.0F)) + CDbl((pointnumber - 1)) / CDbl(Positioncal.PPR) + finaldistance + CDbl((finoverweld / 100.0F))) * CDbl(Positioncal.DirectionFlg))
			End If
			expositions(1, inipoints + pointnumber + finpoints + 4) = 0.0
			Dim meanderfreq As Double = processspeed / (4.0 * meanderamp)
			Dim power As Double = 0.0025 * CDbl(Positioncal.LaserPowerIni) + -1.1111
			Dim feed As Double = 0.1 * Positioncal.PowderFeed
			Dim beamdia As Double = 2.3596 * Positioncal.CladWidth + -4.4599
			Dim headertxt As String
			Dim mainprogtxt As String
			Positioncal.TotalSteps = inipoints + pointnumber + finpoints + 5
			headertxt = String.Concat(New String() {"/JOB" & vbCrLf & "//NAME HOSTMOV" & vbCrLf & "//POS" & vbCrLf & "///NPOS ", Conversions.ToString(inipoints + pointnumber + finpoints + 5), ",0,", Conversions.ToString(inipoints + pointnumber + finpoints + 5), ",2,0,2" & vbCrLf & "///USER ", stationposition.ToString("#"), vbCrLf & "///TOOL ", Positioncal.Toolno.ToString(), vbCrLf & "///POSTYPE USER" & vbCrLf & "///RECTAN" & vbCrLf & "///RCONF 1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0" & vbCrLf})
			Dim num13 As Integer = 0
			Dim num14 As Integer = inipoints + pointnumber + finpoints + 3
			Dim k As Short
			For ind As Integer = num13 To num14
				headertxt = headertxt + "C" + ind.ToString("0000#=")
				k = 0S

				Do
					headertxt = headertxt + positions(CInt(k), ind).ToString("#0.000;-#0.000;0.000") + ","
					k += 1S
				Loop While k <= 2S
				k = 3S
				Do
					headertxt = headertxt + positions(CInt(k), ind).ToString("#0.00;-#0.00;0.00") + ","
					k += 1S
				Loop While k <= 4S
				headertxt = headertxt + positions(5, ind).ToString("#0.00;-#0.00;0.00") + vbCrLf

			Next
			headertxt += "///POSTYPE PULSE" & vbCrLf & "///PULSE" & vbCrLf
			headertxt = headertxt + "C" + (inipoints + pointnumber + finpoints + 4).ToString("0000#=")
			k = 0S
			Do
				headertxt = headertxt + positions(CInt(k), inipoints + pointnumber + finpoints + 4).ToString("#;-#;0") + ","

				k += 1S

			Loop While k <= 4S
			headertxt = headertxt + positions(5, inipoints + pointnumber + finpoints + 4).ToString("#;-#;0") + vbCrLf
			Dim num15 As Integer = 0
			Dim num16 As Integer = inipoints + pointnumber + finpoints + 4
			For ind As Integer = num15 To num16
				headertxt = String.Concat(New String() {headertxt, "EC", ind.ToString("0000#="), Tiltaxispos.ToString(), ",", expositions(1, ind).ToString("#;-#;0"), vbCrLf})
			Next
			headertxt = String.Concat(New String() {headertxt, "///POSTYPE BASE" & vbCrLf & "///RECTAN" & vbCrLf & "P0000=0.000,0.000,0.000,0.00,0.00,0.00" & vbCrLf & "P0001=0.000,0.000,0.000,0.00,0.00,0.00" & vbCrLf & "///POSTYPE PULSE" & vbCrLf & "///PULSE" & vbCrLf & "EX0000=", Tiltaxispos.ToString(), ",0" & vbCrLf & "EX0001=", Tiltaxispos.ToString(), ",0" & vbCrLf & "//INST" & vbCrLf & "///DATE ", mydatetime.ToString("yyyy/MM/dd HH:mm"), vbCrLf & "///COMM SUB TASK TO HOSTMAST" & vbCrLf & "///ATTR SC,RW,RJ" & vbCrLf & "////FRAME USER ", stationposition.ToString("#"), vbCrLf & "///GROUP1 RB1" & vbCrLf & "///GROUP2 ST1" & vbCrLf & "///LVARS 0,0,0,0,0,0,0,0"})
			mainprogtxt = "NOP" & vbCrLf & "EI LEVEL= 1" & vbCrLf
			If meanderflg = 1S Then
				' The following expression was wrapped in a unchecked-expression
				' The following expression was wrapped in a unchecked-expression
				mainprogtxt = String.Concat(New String() {mainprogtxt, "SETFILE WEV#(1) (4) ", Conversions.ToString(CInt(Math.Round(meanderfreq * 10.0))), vbCrLf & "SETFILE WEV#(1) (5) ", Conversions.ToString(CInt(Math.Round(meanderamp * 1000.0))), vbCrLf & "SETFILE WEV#(1) (8) 0" & vbCrLf & "SETFILE WEV#(1) (9) 0" & vbCrLf})
			End If
			mainprogtxt = String.Concat(New String() {mainprogtxt, "CALL JOB:STRESET" & vbCrLf & "GETS PX000 $PX000" & vbCrLf & "CNVRT PX000 PX000 UF#(", stationposition.ToString("#)"), vbCrLf & "GETE D000 P000 (2)" & vbCrLf & "GETE D001 P000 (3)" & vbCrLf & "ADD D000 ", (Positioncal.IniYAxisOffset * 1000.0).ToString("#0"), vbCrLf & "ADD D001 ", (Positioncal.IniZAxisOffset * 1000.0).ToString("#0"), vbCrLf & "SETE P000 (2) D000" & vbCrLf & "SETE P000 (3) D001" & vbCrLf & "MOVL P000 V=", Positioncal.IdleSpeed.ToString("#0.0"), " PL=0  +MOVJ EX000 VJ=100.00" & vbCrLf & "GETS PX000 $PX000" & vbCrLf & "GETE D000 P000 (4)" & vbCrLf & "CALL JOB:ARMCOR IF D000>=", 184115.0.ToString("#"), vbCrLf & "CALL JOB:ARMCOR IF D000<=-", 184115.0.ToString("#"), vbCrLf & "MOVL C00000 V=", Positioncal.IdleSpeed.ToString("#0.0"), " PL=0 NWAIT  +MOVJ EC00000 VJ=100.00" & vbCrLf & "DOUT OT#(1) ON" & vbCrLf & "DOUT OT#(8) ON" & vbCrLf & "JUMP *PILOTON IF IN#(2)=ON" & vbCrLf & "WAIT IN#(6)=ON T=5.00" & vbCrLf & "JUMP *END IF IN#(6)=OFF" & vbCrLf})
			If Positioncal.PowderJar = 1S Then
				mainprogtxt += "DOUT OT#(4) ON" & vbCrLf & "DOUT OT#(6) ON" & vbCrLf
			Else
				mainprogtxt += "DOUT OT#(5) ON" & vbCrLf & "DOUT OT#(7) ON" & vbCrLf
			End If
			mainprogtxt = String.Concat(New String() {mainprogtxt, "TIMER T=", Positioncal.PowderSettling1.ToString("#0.00"), vbCrLf & "*PILOTON" & vbCrLf & "MOVL C00001 V=", Positioncal.ApproachSpeed.ToString("#0.0"), " PL=0 DEC=20  +MOVJ EC00001 VJ=100.00" & vbCrLf & "WAIT IN#(1)=ON T=5.00" & vbCrLf})
			mainprogtxt = mainprogtxt + "TIMER T=" + Positioncal.PowderSettling2.ToString("#0.00") + vbCrLf & "EI LEVEL= 3" & vbCrLf & "*STARTL" & vbCrLf & "DOUT OT#(2) ON" & vbCrLf
			If meanderflg = 1S Then
				processspeed = processspeed * Positioncal.MeanderPitch / (4.0 * meanderamp)
			End If
			Dim num17 As Integer = 2
			Dim num18 As Integer = inipoints + pointnumber + finpoints + 3
			For i As Integer = num17 To num18
				If i = 2 Then
					mainprogtxt = String.Concat(New String() {mainprogtxt, "SMOVC C", i.ToString("0000#"), " V=", Positioncal.ApproachSpeed.ToString("#0.0;-#.0;0.0"), " PL=", Positioncal.PositionLevel.ToString("#"), " +MOVJ EC", i.ToString("0000#"), vbCrLf})
				ElseIf i = 3 Then
					' The following expression was wrapped in a unchecked-expression
					mainprogtxt = String.Concat(New String() {mainprogtxt, "SMOVC C", i.ToString("0000#"), " V=", Positioncal.ApproachSpeed.ToString("#0.0;-#.0;0.0"), " PL=", Positioncal.PositionLevel.ToString("#"), " +MOVJ EC", i.ToString("0000#"), vbCrLf & "ARCON AC=", (feed * (1.0 - CDbl(Positioncal.IniPowderRed) / 100.0) * 100.0).ToString("#0"), " AV=", ((1.0 + CDbl(Positioncal.IniOverPower) / 100.0) * power).ToString("#0.0"), vbCrLf & "ARCCTS AC=", (feed * 100.0).ToString("#0"), " AV=", power.ToString("#0.0"), " AN3=", beamdia.ToString("#0.0"), " DIS=", Positioncal.IniOverPowerDis.ToString("#0.0"), vbCrLf})
					If meanderflg = 1S Then
						mainprogtxt += "SWVON WEV#(1)" & vbCrLf
					End If
				ElseIf i = inipoints + pointnumber + finpoints + 3 Then
					mainprogtxt = String.Concat(New String() {mainprogtxt, "SMOVC C", i.ToString("0000#"), " V=", processspeed.ToString("#0.0;-#.0;0.0"), " PL=", Positioncal.PositionLevel.ToString("#"), " NWAIT  +MOVJ EC", i.ToString("0000#"), vbCrLf})
				Else
					mainprogtxt = String.Concat(New String() {mainprogtxt, "SMOVC C", i.ToString("0000#"), " V=", processspeed.ToString("#0.0;-#.0;0.0"), " PL=", Positioncal.PositionLevel.ToString("#"), " +MOVJ EC", i.ToString("0000#"), vbCrLf})
				End If

				' The following expression was wrapped in a checked-expression
				If i >= Positioncal.PPR + 2 And CDbl(Positioncal.LaserReductionTrackNo) >= CDbl((i - 2)) / CDbl(Positioncal.PPR) And Math.IEEERemainder(CDbl((i + 2)), CDbl(Positioncal.PPR)) = 0.0 AndAlso (Positioncal.IniPowderRed <> 0 Or Positioncal.IniOverPower <> 0) Then
					' The following expression was wrapped in a checked-expression
					' The following expression was wrapped in a checked-expression
					power = (CDbl(Positioncal.LaserPowerIni) - CDbl((Positioncal.LaserPowerIni - Positioncal.LaserPowerFin)) / CDbl(Positioncal.LaserReductionTrackNo) * CDbl((i - 2)) / CDbl(Positioncal.PPR)) * 0.0025 + -1.1111
					mainprogtxt = String.Concat(New String() {mainprogtxt, "ARCSET AC=", (feed * 100.0).ToString("#0"), " AV=", power.ToString("#0.0"), " AN3=", beamdia.ToString(), vbCrLf})
				End If
				If i = inipoints + pointnumber + finpoints + 2 AndAlso (Positioncal.FinPowderRed <> 0 Or Positioncal.FinOverPower <> 0) AndAlso (Positioncal.FinOverPower <> 0 Or Positioncal.FinPowderRed <> 0) Then
					power = 0.0025 * CDbl(Positioncal.LaserPowerFin) * (1.0 + CDbl(Positioncal.FinOverPower) / 100.0) + -1.1111
					feed = 0.1 * (Positioncal.PowderFeed * CDbl((100 - Positioncal.FinPowderRed)) / 100.0)
					mainprogtxt = String.Concat(New String() {mainprogtxt, "ARCCTE AC=", (feed * 100.0).ToString("#0"), " AV=", power.ToString("#0.0"), " AN3=", beamdia.ToString("#0.0"), " DIS=", Positioncal.FinOverPowerDis.ToString("#0.0"), vbCrLf})
				End If
				If (If((-If(((i = inipoints + pointnumber + finpoints + 3) > False), 1S, 0S)), 1S, 0S) And meanderflg) <> 0S Then
					mainprogtxt += "SWVOF" & vbCrLf
				End If

			Next
			mainprogtxt = String.Concat(New String() {mainprogtxt, "DI LEVEL= 2" & vbCrLf & "JUMP *END" & vbCrLf & "*QVERROR" & vbCrLf & "*END" & vbCrLf & "ARCOF" & vbCrLf & "DOUT OG#(1) 0" & vbCrLf & "DOUT OG#(2) 0" & vbCrLf & "CALL JOB:STRESET" & vbCrLf & "GETS PX000 $PX000" & vbCrLf & "CNVRT PX000 PX000 UF#(", stationposition.ToString("#)"), vbCrLf & "GETE D000 P000 (2)" & vbCrLf & "GETE D001 P000 (3)" & vbCrLf & "ADD D000 ", (Positioncal.IniYAxisOffset * 1000.0).ToString("#0"), vbCrLf & "ADD D001 ", (Positioncal.IniZAxisOffset * 1000.0).ToString("#0"), vbCrLf & "SETE P000 (2) D000" & vbCrLf & "SETE P000 (3) D001" & vbCrLf & "CNVRT PX000 PX000 UF#(", stationposition.ToString("#)"), vbCrLf & "MOVL P000 V=", Positioncal.ApproachSpeed.ToString("#0.0"), " PL=0  +MOVJ EX000 VJ=100.00" & vbCrLf & "GETE D000 P000 (1)" & vbCrLf & "ADD D000 ", (Positioncal.IniXAxisOffset * 1000.0).ToString("#0"), vbCrLf & "SETE P000 (1) D000" & vbCrLf & "MOVL P000 V=", Positioncal.ApproachSpeed.ToString("#0.0"), " PL=0  +MOVJ EX000 VJ=100.00" & vbCrLf & "MOVL C", (inipoints + pointnumber + finpoints + 4).ToString("0000#"), " V=", Positioncal.IdleSpeed.ToString("#0.0"), " PL=0  +MOVJ EC", (inipoints + pointnumber + finpoints + 4).ToString("0000#"), " VJ=100.00" & vbCrLf & "END"})
			Try
				FileSystem.FileOpen(1, Positioncal.BasePath + "hostmov.jbi", OpenMode.Output, OpenAccess.[Default], OpenShare.[Default], -1)
				FileSystem.PrintLine(1, New Object() {headertxt})
				FileSystem.PrintLine(1, New Object() {mainprogtxt})
				FileSystem.FileClose(New Integer() {1})
				Positioncal.ControlGroup = 0S
			Catch ex As Exception
				Interaction.MsgBox("Job saving has failed due to the following reason: " + ex.Message, MsgBoxStyle.Exclamation, Nothing)
			End Try
		End Sub

		' Token: 0x06000569 RID: 1385 RVA: 0x00013A04 File Offset: 0x00011E04
		<MethodImpl(MethodImplOptions.NoInlining Or MethodImplOptions.NoOptimization)>
		Public Sub pocketclad(diameter As Double, width1 As Double, Xpos As Double, Ypos As Double, Zpos As Double, pitch As Double, processspeed As Double, postureangle As Double, coneangle As Double, inioverweld As Single, finoverweld As Single, initialang As Double, tooloffset As Double, hWnd As Integer)
			Dim robotctr As Short() = New Short(7) {}
			Dim stationctr As Short() = New Short(15) {}
			Dim positions As Double(,) = New Double(6, 11) {}
			Dim expositions As Double(,) = New Double(6, 11) {}
			Dim Ry As Double = Positioncal.WorkYAxisTilt
			Dim Rz As Double = Positioncal.WorkZAxisYaw
			Dim mydatetime As DateTime = DateAndTime.Now
			coneangle = coneangle * 3.1415926535897931 / 180.0
			Dim inipoints As Integer
			Dim finpoints As Integer
			Dim pointnumber As Integer
			Dim finaldistance As Double
			inipoints = CInt(Math.Round(Math.Round(CDbl((inioverweld / 100.0F * 360.0F / 30.0F)))))
			If inipoints = 0 And inioverweld <> 0F Then
				inipoints = 1
			End If
			finpoints = CInt(Math.Round(Math.Round(CDbl((finoverweld / 100.0F * 360.0F / 30.0F)))))
			If finpoints = 0 And finoverweld <> 0F Then
				finpoints = 1
			End If
			finoverweld = CSng((CDbl(finoverweld) + 10.0 / (6.2831853071795862 * (diameter / 2.0 - (width1 - 2.0 * Positioncal.MeanderAmp - Positioncal.CladWidth) * Math.Sin(coneangle))) * 100.0))
			Dim rotations As Double = Math.Round(width1 / pitch, 2)
			If rotations < 0.0 Then
				rotations = 0.0
			End If
			pointnumber = CInt(Math.Round(Math.Ceiling(rotations * CDbl(Positioncal.PPR))))
			finaldistance = rotations - Conversion.Int(rotations * CDbl(Positioncal.PPR)) / CDbl(Positioncal.PPR)
			positions = CType(Utils.CopyArray(CType(positions, Array), New Double(6, inipoints + pointnumber + finpoints + 5 + 1 - 1) {}), Double(,))
			expositions = CType(Utils.CopyArray(CType(expositions, Array), New Double(6, inipoints + pointnumber + finpoints + 5 + 1 - 1) {}), Double(,))
			positions(0, 0) = Xpos + diameter / 2.0 * Math.Sin(initialang * 3.1415926535897931 / 180.0) + Positioncal.IniXAxisOffset
			positions(1, 0) = Ypos - diameter / 2.0 * Math.Cos(initialang * 3.1415926535897931 / 180.0) + Positioncal.IniYAxisOffset
			positions(2, 0) = Zpos + tooloffset + Positioncal.IniZAxisOffset
			positions(3, 0) = 180.0 - (90.0 - postureangle) * Math.Cos(initialang * 3.1415926535897931 / 180.0)
			positions(4, 0) = -(90.0 - postureangle) * Math.Sin(initialang * 3.1415926535897931 / 180.0)
			positions(5, 0) = Rz
			positions(0, 1) = Xpos + diameter / 2.0 * Math.Sin(initialang * 3.1415926535897931 / 180.0) + Positioncal.IniXAxisOffset
			positions(1, 1) = Ypos - diameter / 2.0 * Math.Cos(initialang * 3.1415926535897931 / 180.0)
			positions(2, 1) = Zpos + tooloffset
			positions(3, 1) = 180.0 - (90.0 - postureangle) * Math.Cos(initialang * 3.1415926535897931 / 180.0)
			positions(4, 1) = -(90.0 - postureangle) * Math.Sin(initialang * 3.1415926535897931 / 180.0)
			positions(5, 1) = Rz
			positions(0, 2) = Xpos + diameter / 2.0 * Math.Sin(initialang * 3.1415926535897931 / 180.0)
			positions(1, 2) = Ypos - diameter / 2.0 * Math.Cos(initialang * 3.1415926535897931 / 180.0)
			positions(2, 2) = Zpos + tooloffset
			positions(3, 2) = 180.0 - (90.0 - postureangle) * Math.Cos(initialang * 3.1415926535897931 / 180.0)
			positions(4, 2) = -(90.0 - postureangle) * Math.Sin(initialang * 3.1415926535897931 / 180.0)
			positions(5, 2) = Rz
			Dim num As Integer = 1
			Dim num2 As Integer = inipoints
			For i As Integer = num To num2
				' The following expression was wrapped in a unchecked-expression
				' The following expression was wrapped in a checked-expression
				positions(0, i + 2) = Xpos + diameter / 2.0 * Math.Sin((initialang / 360.0 + 1.0 / CDbl(Positioncal.PPR) + CDbl((inioverweld / 100.0F * CSng((i - 1)) / CSng(inipoints)))) * 2.0 * 3.1415926535897931)
				positions(1, i + 2) = Ypos - diameter / 2.0 * Math.Cos((initialang / 360.0 + 1.0 / CDbl(Positioncal.PPR) + CDbl((inioverweld / 100.0F * CSng((i - 1)) / CSng(inipoints)))) * 2.0 * 3.1415926535897931)
				positions(2, i + 2) = Zpos + tooloffset
				positions(3, i + 2) = 180.0 - (90.0 - postureangle) * Math.Cos((initialang / 360.0 + 1.0 / CDbl(Positioncal.PPR) + CDbl((inioverweld / 100.0F * CSng((i - 1)) / CSng(inipoints)))) * 2.0 * 3.1415926535897931)
				positions(4, i + 2) = -(90.0 - postureangle) * Math.Sin((initialang / 360.0 + 1.0 / CDbl(Positioncal.PPR) + CDbl((inioverweld / 100.0F * CSng((i - 1)) / CSng(inipoints)))) * 2.0 * 3.1415926535897931)
				positions(5, i + 2) = Rz
			Next
			Dim num3 As Integer = 1
			Dim num4 As Integer = pointnumber
			For i As Integer = num3 To num4
				' The following expression was wrapped in a unchecked-expression
				' The following expression was wrapped in a checked-expression
				' The following expression was wrapped in a checked-expression
				positions(0, i + inipoints + 2) = Xpos + (diameter / 2.0 + CDbl((i - 1)) / CDbl(Positioncal.PPR) * pitch * Math.Sin(coneangle)) * Math.Sin((initialang / 360.0 + 1.0 / CDbl(Positioncal.PPR) + CDbl((inioverweld / 100.0F)) + CDbl((i - 1)) / CDbl(Positioncal.PPR)) * 2.0 * 3.1415926535897931)
				positions(1, i + inipoints + 2) = Ypos - (diameter / 2.0 + CDbl((i - 1)) / CDbl(Positioncal.PPR) * pitch * Math.Sin(coneangle)) * Math.Cos((initialang / 360.0 + 1.0 / CDbl(Positioncal.PPR) + CDbl((inioverweld / 100.0F)) + CDbl((i - 1)) / CDbl(Positioncal.PPR)) * 2.0 * 3.1415926535897931)
				positions(2, i + inipoints + 2) = Zpos + tooloffset + CDbl((i - 1)) / CDbl(Positioncal.PPR) * pitch * Math.Cos(coneangle)
				positions(3, i + inipoints + 2) = 180.0 - (90.0 - postureangle) * Math.Cos((initialang / 360.0 + 1.0 / CDbl(Positioncal.PPR) + CDbl((inioverweld / 100.0F)) + CDbl((i - 1)) / CDbl(Positioncal.PPR)) * 2.0 * 3.1415926535897931)
				positions(4, i + inipoints + 2) = -(90.0 - postureangle) * Math.Sin((initialang / 360.0 + 1.0 / CDbl(Positioncal.PPR) + CDbl((inioverweld / 100.0F)) + CDbl((i - 1)) / CDbl(Positioncal.PPR)) * 2.0 * 3.1415926535897931)
				positions(5, i + inipoints + 2) = Rz
			Next
			Dim num5 As Integer = 1
			Dim num6 As Integer = finpoints
			For i As Integer = num5 To num6
				If finaldistance = 0.0 Then
					' The following expression was wrapped in a unchecked-expression
					' The following expression was wrapped in a checked-expression
					positions(0, i + inipoints + pointnumber + 2) = Xpos + (diameter / 2.0 + width1 * Math.Sin(coneangle)) * Math.Sin((initialang / 360.0 + 1.0 / CDbl(Positioncal.PPR) + CDbl((inioverweld / 100.0F)) + CDbl((finoverweld / 100.0F * CSng((i - 1)) / CSng(finpoints))) + CDbl(pointnumber) / CDbl(Positioncal.PPR)) * 2.0 * 3.1415926535897931)
					positions(1, i + inipoints + pointnumber + 2) = Ypos - (diameter / 2.0 + width1 * Math.Sin(coneangle)) * Math.Cos((initialang / 360.0 + 1.0 / CDbl(Positioncal.PPR) + CDbl((inioverweld / 100.0F)) + CDbl((finoverweld / 100.0F * CSng((i - 1)) / CSng(finpoints))) + CDbl(pointnumber) / CDbl(Positioncal.PPR)) * 2.0 * 3.1415926535897931)
					positions(2, i + inipoints + pointnumber + 2) = Zpos + tooloffset + width1 * Math.Cos(coneangle)
					positions(3, i + inipoints + pointnumber + 2) = 180.0 - (90.0 - postureangle) * Math.Cos((initialang / 360.0 + 1.0 / CDbl(Positioncal.PPR) + CDbl((inioverweld / 100.0F)) + CDbl((finoverweld / 100.0F * CSng((i - 1)) / CSng(finpoints))) + CDbl(pointnumber) / CDbl(Positioncal.PPR)) * 2.0 * 3.1415926535897931)
					positions(4, i + inipoints + pointnumber + 2) = -(90.0 - postureangle) * Math.Sin((initialang / 360.0 + 1.0 / CDbl(Positioncal.PPR) + CDbl((inioverweld / 100.0F)) + CDbl((finoverweld / 100.0F * CSng((i - 1)) / CSng(finpoints))) + CDbl(pointnumber) / CDbl(Positioncal.PPR)) * 2.0 * 3.1415926535897931)
					positions(5, i + inipoints + pointnumber + 2) = Rz
				Else
					' The following expression was wrapped in a unchecked-expression
					' The following expression was wrapped in a checked-expression
					' The following expression was wrapped in a checked-expression
					positions(0, i + inipoints + pointnumber + 2) = Xpos + (diameter / 2.0 + width1 * Math.Sin(coneangle)) * Math.Sin((initialang / 360.0 + 1.0 / CDbl(Positioncal.PPR) + CDbl((inioverweld / 100.0F)) + CDbl((finoverweld / 100.0F * CSng((i - 1)) / CSng(finpoints))) + CDbl((pointnumber - 1)) / CDbl(Positioncal.PPR) + finaldistance) * 2.0 * 3.1415926535897931)
					positions(1, i + inipoints + pointnumber + 2) = Ypos - (diameter / 2.0 + width1 * Math.Sin(coneangle)) * Math.Cos((initialang / 360.0 + 1.0 / CDbl(Positioncal.PPR) + CDbl((inioverweld / 100.0F)) + CDbl((finoverweld / 100.0F * CSng((i - 1)) / CSng(finpoints))) + CDbl((pointnumber - 1)) / CDbl(Positioncal.PPR) + finaldistance) * 2.0 * 3.1415926535897931)
					positions(2, i + inipoints + pointnumber + 2) = Zpos + tooloffset + width1 * Math.Cos(coneangle)
					positions(3, i + inipoints + pointnumber + 2) = 180.0 - (90.0 - postureangle) * Math.Cos((initialang / 360.0 + 1.0 / CDbl(Positioncal.PPR) + CDbl((inioverweld / 100.0F)) + CDbl((finoverweld / 100.0F * CSng((i - 1)) / CSng(finpoints))) + CDbl((pointnumber - 1)) / CDbl(Positioncal.PPR) + finaldistance) * 2.0 * 3.1415926535897931)
					positions(4, i + inipoints + pointnumber + 2) = -(90.0 - postureangle) * Math.Sin((initialang / 360.0 + 1.0 / CDbl(Positioncal.PPR) + CDbl((inioverweld / 100.0F)) + CDbl((finoverweld / 100.0F * CSng((i - 1)) / CSng(finpoints))) + CDbl((pointnumber - 1)) / CDbl(Positioncal.PPR) + finaldistance) * 2.0 * 3.1415926535897931)
					positions(5, i + inipoints + pointnumber + 2) = Rz
				End If
			Next
			If finaldistance = 0.0 Then
				' The following expression was wrapped in a unchecked-expression
				positions(0, inipoints + pointnumber + finpoints + 3) = Xpos + (diameter / 2.0 + width1 * Math.Sin(coneangle)) * Math.Sin((initialang / 360.0 + 1.0 / CDbl(Positioncal.PPR) + CDbl((inioverweld / 100.0F)) + CDbl(pointnumber) / CDbl(Positioncal.PPR) + CDbl((finoverweld / 100.0F))) * 2.0 * 3.1415926535897931)
				positions(1, inipoints + pointnumber + finpoints + 3) = Ypos - (diameter / 2.0 + width1 * Math.Sin(coneangle)) * Math.Cos((initialang / 360.0 + 1.0 / CDbl(Positioncal.PPR) + CDbl((inioverweld / 100.0F)) + CDbl(pointnumber) / CDbl(Positioncal.PPR) + CDbl((finoverweld / 100.0F))) * 2.0 * 3.1415926535897931)
				positions(2, inipoints + pointnumber + finpoints + 3) = Zpos + tooloffset + width1 * Math.Cos(coneangle)
				positions(3, inipoints + pointnumber + finpoints + 3) = 180.0 - (90.0 - postureangle) * Math.Cos((initialang / 360.0 + 1.0 / CDbl(Positioncal.PPR) + CDbl((inioverweld / 100.0F)) + CDbl(pointnumber) / CDbl(Positioncal.PPR) + CDbl((finoverweld / 100.0F))) * 2.0 * 3.1415926535897931)
				positions(4, inipoints + pointnumber + finpoints + 3) = -(90.0 - postureangle) * Math.Sin((initialang / 360.0 + 1.0 / CDbl(Positioncal.PPR) + CDbl((inioverweld / 100.0F)) + CDbl(pointnumber) / CDbl(Positioncal.PPR) + CDbl((finoverweld / 100.0F))) * 2.0 * 3.1415926535897931)
				positions(5, inipoints + pointnumber + finpoints + 3) = Rz
			Else
				' The following expression was wrapped in a unchecked-expression
				' The following expression was wrapped in a checked-expression
				positions(0, inipoints + pointnumber + finpoints + 3) = Xpos + (diameter / 2.0 + width1 * Math.Sin(coneangle)) * Math.Sin((initialang / 360.0 + 1.0 / CDbl(Positioncal.PPR) + CDbl((inioverweld / 100.0F)) + CDbl((pointnumber - 1)) / CDbl(Positioncal.PPR) + finaldistance + CDbl((finoverweld / 100.0F))) * 2.0 * 3.1415926535897931)
				positions(1, inipoints + pointnumber + finpoints + 3) = Ypos - (diameter / 2.0 + width1 * Math.Sin(coneangle)) * Math.Cos((initialang / 360.0 + 1.0 / CDbl(Positioncal.PPR) + CDbl((inioverweld / 100.0F)) + CDbl((pointnumber - 1)) / CDbl(Positioncal.PPR) + finaldistance + CDbl((finoverweld / 100.0F))) * 2.0 * 3.1415926535897931)
				positions(2, inipoints + pointnumber + finpoints + 3) = Zpos + tooloffset + width1 * Math.Cos(coneangle)
				positions(3, inipoints + pointnumber + finpoints + 3) = 180.0 - (90.0 - postureangle) * Math.Cos((initialang / 360.0 + 1.0 / CDbl(Positioncal.PPR) + CDbl((inioverweld / 100.0F)) + CDbl((pointnumber - 1)) / CDbl(Positioncal.PPR) + finaldistance + CDbl((finoverweld / 100.0F))) * 2.0 * 3.1415926535897931)
				positions(4, inipoints + pointnumber + finpoints + 3) = -(90.0 - postureangle) * Math.Sin((initialang / 360.0 + 1.0 / CDbl(Positioncal.PPR) + CDbl((inioverweld / 100.0F)) + CDbl((pointnumber - 1)) / CDbl(Positioncal.PPR) + finaldistance + CDbl((finoverweld / 100.0F))) * 2.0 * 3.1415926535897931)
				positions(5, inipoints + pointnumber + finpoints + 3) = Rz
			End If
			positions(0, inipoints + pointnumber + finpoints + 4) = CDbl(Positioncal.HomePos(0))
			positions(1, inipoints + pointnumber + finpoints + 4) = CDbl(Positioncal.HomePos(1))
			positions(2, inipoints + pointnumber + finpoints + 4) = CDbl(Positioncal.HomePos(2))
			positions(3, inipoints + pointnumber + finpoints + 4) = CDbl(Positioncal.HomePos(3))
			positions(4, inipoints + pointnumber + finpoints + 4) = CDbl(Positioncal.HomePos(4))
			positions(5, inipoints + pointnumber + finpoints + 4) = CDbl(Positioncal.HomePos(5))
			Dim meanderfreq As Double = processspeed / (4.0 * Positioncal.MeanderAmp)
			Dim power As Double = 0.0025 * CDbl(Positioncal.LaserPowerIni) + -1.1111
			Dim feed As Double = 0.1 * Positioncal.PowderFeed
			Dim beamdia As Double = 2.3596 * Positioncal.CladWidth + -4.4599
			Dim headertxt As String
			Dim mainprogtxt As String
			Positioncal.TotalSteps = inipoints + pointnumber + finpoints + 5
			headertxt = String.Concat(New String() {"/JOB" & vbCrLf & "//NAME HOSTMOV" & vbCrLf & "//POS" & vbCrLf & "///NPOS ", Conversions.ToString(inipoints + pointnumber + finpoints + 5), ",0,0,2,0,0" & vbCrLf & "///USER ", Positioncal.StationPosition.ToString("#"), vbCrLf & "///TOOL ", Positioncal.Toolno.ToString("#0"), vbCrLf & "///POSTYPE USER" & vbCrLf & "///RECTAN" & vbCrLf & "///RCONF 1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0" & vbCrLf})
			Dim num7 As Integer = 0
			Dim num8 As Integer = inipoints + pointnumber + finpoints + 3
			Dim j As Short
			For ind As Integer = num7 To num8
				headertxt = headertxt + "C" + ind.ToString("0000#=")
				j = 0S

				Do
					headertxt = headertxt + positions(CInt(j), ind).ToString("#0.000;-#0.000;0.000") + ","
					j += 1S
				Loop While j <= 2S
				j = 3S
				Do
					headertxt = headertxt + positions(CInt(j), ind).ToString("#0.00;-#0.00;0.00") + ","
					j += 1S
				Loop While j <= 4S
				headertxt = headertxt + positions(5, ind).ToString("#0.00;-#0.00;0.00") + vbCrLf

			Next
			headertxt += "///POSTYPE PULSE" & vbCrLf & "///PULSE" & vbCrLf
			headertxt = headertxt + "C" + (inipoints + pointnumber + finpoints + 4).ToString("0000#=")
			j = 0S
			Do
				headertxt = headertxt + positions(CInt(j), inipoints + pointnumber + finpoints + 4).ToString("#;-#;0") + ","

				j += 1S

			Loop While j <= 4S
			headertxt = String.Concat(New String() {headertxt, positions(5, inipoints + pointnumber + finpoints + 4).ToString("#;-#;0"), vbCrLf & "///POSTYPE BASE" & vbCrLf & "///RECTAN" & vbCrLf & "P0000=0.000,0.000,0.000,0.00,0.00,0.00" & vbCrLf & "P0001=0.000,0.000,0.000,0.00,0.00,0.00" & vbCrLf & "//INST" & vbCrLf & "///DATE ", mydatetime.ToString("yyyy/MM/dd HH:mm"), vbCrLf & "///COMM SUB TASK TO HOSTMAST" & vbCrLf & "///ATTR SC,RW,RJ" & vbCrLf & "////FRAME USER ", Positioncal.StationPosition.ToString("#"), vbCrLf & "///GROUP1 RB1" & vbCrLf & "///LVARS 0,0,0,0,0,0,0,0"})
			mainprogtxt = "NOP" & vbCrLf & "EI LEVEL= 1" & vbCrLf
			If Positioncal.MeanderFlg = 1S Then
				' The following expression was wrapped in a unchecked-expression
				' The following expression was wrapped in a unchecked-expression
				mainprogtxt = String.Concat(New String() {mainprogtxt, "SETFILE WEV#(1) (4) ", Conversions.ToString(CInt(Math.Round(meanderfreq * 10.0))), vbCrLf & "SETFILE WEV#(1) (5) ", Conversions.ToString(CInt(Math.Round(Positioncal.MeanderAmp * 1000.0))), vbCrLf & "SETFILE WEV#(1) (8) 0" & vbCrLf & "SETFILE WEV#(1) (9) 0" & vbCrLf})
			End If
			mainprogtxt = String.Concat(New String() {mainprogtxt, "GETS PX000 $PX000" & vbCrLf & "CNVRT PX000 PX000 RF" & vbCrLf & "GETE D000 P000 (3)" & vbCrLf & "ADD D000 ", (Positioncal.IniZAxisOffset * 1000.0).ToString("#0"), vbCrLf & "JUMP *LABEL1 IF D000<=", Positioncal.MaxZRobotPos.ToString("#"), vbCrLf & "SET D000 ", Positioncal.MaxZRobotPos.ToString("#"), vbCrLf & "*LABEL1" & vbCrLf & "SETE P000 (3) D000" & vbCrLf & "MOVL P000 V=", Positioncal.IdleSpeed.ToString("#0.0"), vbCrLf & "GETS PX000 $PX000" & vbCrLf & "GETE D000 P000 (4)" & vbCrLf & "CALL JOB:ARMCOR IF D000>=", 184115.0.ToString("#"), vbCrLf & "CALL JOB:ARMCOR IF D000<=-", 184115.0.ToString("#"), vbCrLf & "GETPOS PX000 STEP#(2)" & vbCrLf & "CNVRT PX000 PX000 RF" & vbCrLf & "GETE D000 P000 (3)" & vbCrLf & "JUMP *LABEL2 IF D000<", Positioncal.MaxZRobotPos.ToString("#"), vbCrLf & "SUB D000 ", Positioncal.MaxZRobotPos.ToString("#"), vbCrLf & "MUL D000 -1" & vbCrLf & "SETE P000 (1) 0" & vbCrLf & "SETE P000 (2) 0" & vbCrLf & "SETE P000 (3) D000" & vbCrLf & "SETE P000 (4) 0" & vbCrLf & "SETE P000 (5) 0" & vbCrLf & "SETE P000 (6) 0" & vbCrLf & "SFTON P000 RF" & vbCrLf & "*LABEL2" & vbCrLf & "MOVL C00000 V=", Positioncal.IdleSpeed.ToString("#0.0"), " PL=0 NWAIT" & vbCrLf & "DOUT OT#(1) ON" & vbCrLf & "DOUT OT#(8) ON" & vbCrLf & "JUMP *PILOTON IF IN#(2)=ON" & vbCrLf & "WAIT IN#(6)=ON T=5.00" & vbCrLf & "JUMP *END IF IN#(6)=OFF" & vbCrLf})
			If Positioncal.PowderJar = 1S Then
				mainprogtxt += "DOUT OT#(4) ON" & vbCrLf & "DOUT OT#(6) ON" & vbCrLf
			Else
				mainprogtxt += "DOUT OT#(5) ON" & vbCrLf & "DOUT OT#(7) ON" & vbCrLf
			End If
			mainprogtxt = String.Concat(New String() {mainprogtxt, "TIMER T=", Positioncal.PowderSettling1.ToString("#0.00"), vbCrLf & "*PILOTON" & vbCrLf & "SFTOF" & vbCrLf & "MOVL C00001 V=", Positioncal.ApproachSpeed.ToString("#0.0"), " PL=0 DEC=20" & vbCrLf & "WAIT IN#(1)=ON T=5.00" & vbCrLf})
			mainprogtxt = mainprogtxt + "TIMER T=" + Positioncal.PowderSettling2.ToString("#0.00") + vbCrLf & "EI LEVEL= 3" & vbCrLf & "*STARTL" & vbCrLf & "DOUT OT#(2) ON" & vbCrLf
			If Positioncal.MeanderFlg = 1S Then
				processspeed = processspeed * Positioncal.MeanderPitch / (4.0 * Positioncal.MeanderAmp)
			End If
			Dim num9 As Integer = 2
			Dim num10 As Integer = inipoints + pointnumber + finpoints + 3
			For i As Integer = num9 To num10
				If i = 2 Then
					mainprogtxt = String.Concat(New String() {mainprogtxt, "MOVC C", i.ToString("0000#"), " V=", Positioncal.ApproachSpeed.ToString("#0.0;-#.0;0.0"), " PL=", Positioncal.PositionLevel.ToString("#"), vbCrLf})
				ElseIf i = 3 Then
					' The following expression was wrapped in a unchecked-expression
					mainprogtxt = String.Concat(New String() {mainprogtxt, "MOVC C", i.ToString("0000#"), " V=", Positioncal.ApproachSpeed.ToString("#0.0;-#.0;0.0"), " PL=", Positioncal.PositionLevel.ToString("#"), vbCrLf & "ARCON AC=", (feed * (1.0 - CDbl(Positioncal.IniPowderRed) / 100.0) * 100.0).ToString("#0"), " AV=", ((1.0 + CDbl(Positioncal.IniOverPower) / 100.0) * power).ToString("#0"), vbCrLf & "ARCCTS AC=", (feed * 100.0).ToString("#0"), " AV=", power.ToString("#0"), " AN3=", beamdia.ToString("#0.0"), " DIS=", Positioncal.IniOverPowerDis.ToString("#0.0"), vbCrLf})
					If Positioncal.MeanderFlg = 1S Then
						mainprogtxt += "WVON WEV#(1)" & vbCrLf
					End If
				ElseIf i = inipoints + pointnumber + finpoints + 3 Then
					mainprogtxt = String.Concat(New String() {mainprogtxt, "MOVC C", i.ToString("0000#"), " V=", processspeed.ToString("#0.0;-#.0;0.0"), " PL=", Positioncal.PositionLevel.ToString("#"), " NWAIT" & vbCrLf})
				Else
					mainprogtxt = String.Concat(New String() {mainprogtxt, "MOVC C", i.ToString("0000#"), " V=", processspeed.ToString("#0.0;-#.0;0.0"), " PL=", Positioncal.PositionLevel.ToString("#"), vbCrLf})
				End If

				' The following expression was wrapped in a checked-expression
				If i >= Positioncal.PPR + 2 And CDbl(Positioncal.LaserReductionTrackNo) >= CDbl((i - 2)) / CDbl(Positioncal.PPR) And Math.IEEERemainder(CDbl((i + 2)), CDbl(Positioncal.PPR)) = 0.0 AndAlso (Positioncal.IniPowderRed <> 0 Or Positioncal.IniOverPower <> 0) Then
					' The following expression was wrapped in a checked-expression
					' The following expression was wrapped in a checked-expression
					power = (CDbl(Positioncal.LaserPowerIni) - CDbl((Positioncal.LaserPowerIni - Positioncal.LaserPowerFin)) / CDbl(Positioncal.LaserReductionTrackNo) * CDbl((i - 2)) / CDbl(Positioncal.PPR)) * 0.0025 + -1.1111
					mainprogtxt = String.Concat(New String() {mainprogtxt, "ARCSET AC=", (feed * 100.0).ToString("#0"), " AV=", power.ToString("#0"), " AN3=", beamdia.ToString("#0.0"), vbCrLf})
				End If
				If i = inipoints + pointnumber + finpoints + 2 AndAlso (Positioncal.FinOverPower <> 0 Or Positioncal.FinPowderRed <> 0) Then
					power = 0.0025 * CDbl(Positioncal.LaserPowerFin) * (1.0 + CDbl(Positioncal.FinOverPower) / 100.0) + -1.1111
					feed = 0.1 * (Positioncal.PowderFeed * CDbl((100 - Positioncal.FinPowderRed)) / 100.0)
					mainprogtxt = String.Concat(New String() {mainprogtxt, "ARCCTE AC=", (feed * 100.0).ToString("#0"), " AV=", power.ToString("#0"), " AN3=", beamdia.ToString("#0.0"), " DIS=", Positioncal.FinOverPowerDis.ToString("#0.0"), vbCrLf})
				End If
				If (If((-If(((i = inipoints + pointnumber + finpoints + 3) > False), 1S, 0S)), 1S, 0S) And Positioncal.MeanderFlg) <> 0S Then
					mainprogtxt += "WVOF" & vbCrLf
				End If

			Next
			mainprogtxt = String.Concat(New String() {mainprogtxt, "DI LEVEL= 2" & vbCrLf & "JUMP *END" & vbCrLf & "*QVERROR" & vbCrLf & "*END" & vbCrLf & "ARCOF" & vbCrLf & "DOUT OG#(1) 0" & vbCrLf & "DOUT OG#(2) 0" & vbCrLf & "GETS PX000 $PX000" & vbCrLf & "CNVRT PX000 PX000 RF" & vbCrLf & "GETE D000 P000 (3)" & vbCrLf & "ADD D000 ", (Positioncal.IniZAxisOffset * 1000.0).ToString("#0"), vbCrLf & "JUMP *LABEL3 IF D000<=", Positioncal.MaxZRobotPos.ToString("#"), vbCrLf & "SET D000 ", Positioncal.MaxZRobotPos.ToString("#"), vbCrLf & "*LABEL3" & vbCrLf & "SETE P000 (3) D000" & vbCrLf & "MOVL P000 V=", Positioncal.ApproachSpeed.ToString("#0.0"), " PL=0" & vbCrLf & "GETE D000 P000 (1)" & vbCrLf & "ADD D000 ", (Positioncal.IniXAxisOffset * 1000.0).ToString("#0"), vbCrLf & "SETE P000 (1) D000" & vbCrLf & "MOVL P000 V=", Positioncal.ApproachSpeed.ToString("#0.0"), " PL=0" & vbCrLf & "MOVL C", (inipoints + pointnumber + finpoints + 4).ToString("0000#"), " V=", Positioncal.IdleSpeed.ToString("#0.0"), " PL=0" & vbCrLf & "END"})
			Try
				FileSystem.FileOpen(1, Positioncal.BasePath + "hostmov.jbi", OpenMode.Output, OpenAccess.[Default], OpenShare.[Default], -1)
				FileSystem.PrintLine(1, New Object() {headertxt})
				FileSystem.PrintLine(1, New Object() {mainprogtxt})
				FileSystem.FileClose(New Integer() {1})
				Positioncal.ControlGroup = 1S
			Catch ex As Exception
				Interaction.MsgBox("Job saving has failed due to the following reason: " + ex.Message, MsgBoxStyle.Exclamation, Nothing)
			End Try
		End Sub

		' Token: 0x0600056A RID: 1386 RVA: 0x000158E4 File Offset: 0x00013CE4
		Public Function vectrot(ByRef axis As Double(), ByRef vector As Double(), ByRef angle As Double) As Double()
			Return New Double() {(Math.Cos(angle) + Math.Pow(axis(0), 2.0) * (1.0 - Math.Cos(angle))) * vector(0) + (axis(0) * axis(1) * (1.0 - Math.Cos(angle)) - axis(2) * Math.Sin(angle)) * vector(1) + (axis(0) * axis(2) * (1.0 - Math.Cos(angle)) + axis(1) * Math.Sin(angle)) * vector(2), (axis(1) * axis(0) * (1.0 - Math.Cos(angle)) + axis(2) * Math.Sin(angle)) * vector(0) + (Math.Cos(angle) + Math.Pow(axis(1), 2.0) * (1.0 - Math.Cos(angle))) * vector(1) + (axis(1) * axis(2) * (1.0 - Math.Cos(angle)) - axis(0) * Math.Sin(angle)) * vector(2), (axis(2) * axis(0) * (1.0 - Math.Cos(angle)) - axis(1) * Math.Sin(angle)) * vector(0) + (axis(2) * axis(1) * (1.0 - Math.Cos(angle)) + axis(0) * Math.Sin(angle)) * vector(1) + (Math.Cos(angle) + Math.Pow(axis(2), 2.0) * (1.0 - Math.Cos(angle))) * vector(2)}
		End Function

		' Token: 0x0600056B RID: 1387 RVA: 0x00015AAC File Offset: 0x00013EAC
		Public Function CrosProd(ByRef Normal As Double(), ByRef Modulus As Double, Vector1 As Double(), Vector2 As Double()) As Double
			Normal(0) = Vector1(1) * Vector2(2) - Vector2(1) * Vector1(2)
			Normal(1) = -Vector1(0) * Vector2(2) + Vector2(0) * Vector1(2)
			Normal(2) = Vector1(0) * Vector2(1) - Vector2(0) * Vector1(1)
			Modulus = Math.Sqrt(Math.Pow(Normal(0), 2.0) + Math.Pow(Normal(1), 2.0) + Math.Pow(Normal(2), 2.0))
			Return Modulus
		End Function

		' Token: 0x0600056C RID: 1388 RVA: 0x00015B34 File Offset: 0x00013F34
		Public Function Inv3(ByRef A As Double(,)) As Double(,)
			Dim temparray As Double(,) = New Double(2, 2) {}
			Dim Det As Double = A(0, 0) * (A(1, 1) * A(2, 2) - A(1, 2) * A(2, 1)) - A(0, 1) * (A(1, 0) * A(2, 2) - A(1, 2) * A(2, 0)) + A(0, 2) * (A(1, 0) * A(2, 1) - A(1, 1) * A(2, 0))
			temparray(0, 0) = (A(1, 1) * A(2, 2) - A(2, 1) * A(1, 2)) / Det
			temparray(1, 0) = (A(1, 2) * A(2, 0) - A(1, 0) * A(2, 2)) / Det
			temparray(2, 0) = (A(1, 0) * A(2, 1) - A(2, 0) * A(1, 1)) / Det
			temparray(0, 1) = (A(0, 2) * A(2, 1) - A(0, 1) * A(2, 2)) / Det
			temparray(1, 1) = (A(0, 0) * A(2, 2) - A(0, 2) * A(2, 0)) / Det
			temparray(2, 1) = (A(0, 1) * A(2, 0) - A(0, 0) * A(2, 1)) / Det
			temparray(0, 2) = (A(0, 1) * A(1, 2) - A(1, 1) * A(0, 2)) / Det
			temparray(1, 2) = (A(0, 2) * A(1, 0) - A(0, 0) * A(1, 2)) / Det
			temparray(2, 2) = (A(0, 0) * A(1, 1) - A(1, 0) * A(0, 1)) / Det
			Return temparray
		End Function

		' Token: 0x0600056D RID: 1389 RVA: 0x00015D9C File Offset: 0x0001419C
		Public Function Inv2(ByRef A As Double(,)) As Double(,)
			Dim temparray As Double(,) = New Double(1, 1) {}
			Dim Det As Double = A(0, 0) * A(1, 1) - A(0, 1) * A(1, 0)
			temparray(0, 0) = A(0, 0) / Det
			temparray(1, 0) = -A(1, 0) / Det
			temparray(0, 1) = -A(0, 1) / Det
			temparray(1, 1) = A(1, 1) / Det
			Return temparray
		End Function

		' Token: 0x0600056E RID: 1390 RVA: 0x00015E2C File Offset: 0x0001422C
		Public Function FindDist(ByRef P As Double(), ByRef Tiltangle As Double, ByRef Stationangle As Double) As Double
			Dim R As Double(,) = New Double(2, 2) {}
			Dim Pr As Double() = New Double(2) {}
			Dim Prr As Double() = New Double(2) {}
			Dim Rb As Double(,) = New Double(2, 2) {}
			Dim a2d As Object(,) = New Object(4, 4) {}
			Dim Tiltnormalrot As Double() = New Double(2) {}
			Dim distance As Double
			If Stationangle <> Tiltangle Then
				Dim num As Double = 0.0
				Dim array As Double(,) = Positioncal.Rotmat(Positioncal.Tiltnormal, Positioncal.Spindnormalhor, num)
				R = Positioncal.Inv3(array)
				Tiltnormalrot(0) = R(0, 0) * Positioncal.Tiltnormal(0) + R(0, 1) * Positioncal.Tiltnormal(1) + R(0, 2) * Positioncal.Tiltnormal(2)
				Tiltnormalrot(1) = R(1, 0) * Positioncal.Tiltnormal(0) + R(1, 1) * Positioncal.Tiltnormal(1) + R(1, 2) * Positioncal.Tiltnormal(2)
				Tiltnormalrot(2) = R(2, 0) * Positioncal.Tiltnormal(0) + R(2, 1) * Positioncal.Tiltnormal(1) + R(2, 2) * Positioncal.Tiltnormal(2)
				Dim Spindnormal As Double() = Positioncal.vectrot(Tiltnormalrot, Positioncal.Spindnormalhor, Stationangle)
				num = Stationangle - Tiltangle
				R = Positioncal.Rotmat(Tiltnormalrot, Spindnormal, num)
				P(1) = P(1) + 443.737
				Pr(0) = R(0, 0) * P(0) + R(0, 1) * P(1) + R(0, 2) * P(2)
				Pr(1) = R(1, 0) * P(0) + R(1, 1) * P(1) + R(1, 2) * P(2)
				Pr(2) = R(2, 0) * P(0) + R(2, 1) * P(1) + R(2, 2) * P(2)
				distance = Math.Sqrt(Math.Pow(Pr(0), 2.0) + Math.Pow(Pr(2), 2.0))
			Else
				distance = Math.Sqrt(Math.Pow(P(0), 2.0) + Math.Pow(P(2), 2.0))
			End If
			Return distance
		End Function

		' Token: 0x0600056F RID: 1391 RVA: 0x00016068 File Offset: 0x00014468
		Public Function Rotmat(ByRef tiltnormal As Double(), ByRef spindnormal As Double(), ByRef angle As Double) As Double(,)
			Dim CoordX As Double() = New Double() {0.0, 0.0, 0.0}
			Dim R As Double(,) = New Double(2, 2) {}
			Dim num As Double = 1.5707963267948966 + angle
			Dim CoordZ As Double() = Positioncal.vectrot(tiltnormal, Positioncal.Spindnormalhor, num)
			Dim RotSpindNormal As Double() = Positioncal.vectrot(tiltnormal, Positioncal.Spindnormalhor, angle)
			Dim modulus As Double
			Positioncal.CrosProd(CoordX, modulus, RotSpindNormal, CoordZ)
			Dim i As Integer = 0
			Do
				Dim j As Integer = 0
				Do
					Select Case i
						Case 0
							R(j, i) = CoordX(j)
						Case 1
							R(j, i) = RotSpindNormal(j)
						Case 2
							R(j, i) = CoordZ(j)
					End Select
					j += 1
				Loop While j <= 2
				i += 1
			Loop While i <= 2
			Return R
		End Function

		' Token: 0x06000570 RID: 1392 RVA: 0x00016140 File Offset: 0x00014540
		Public Function ArraysToDataTable(ParamArray arrays As Array()) As DataTable
			Dim result As DataTable = New DataTable()
			Dim length As Integer = arrays(0).Length
			Dim num As Integer = 0
			Dim num2 As Integer = arrays.Length - 1
			For count As Integer = num To num2
				result.Columns.Add()
				If length <> arrays(count).Length Then
					Throw New ArgumentException("All arrays must be the same length")
				End If
			Next
			Dim num3 As Integer = 0
			Dim num4 As Integer = length - 1
			For index As Integer = num3 To num4
				Dim values As List(Of Object) = New List(Of Object)()
				Dim num5 As Integer = 0
				Dim num6 As Integer = arrays.Length - 1
				For count2 As Integer = num5 To num6
					values.Add(RuntimeHelpers.GetObjectValue(NewLateBinding.LateIndexGet(arrays(count2), New Object() {index}, Nothing)))
				Next
				result.Rows.Add(values.ToArray())
			Next
			Return result
		End Function

		' Token: 0x06000571 RID: 1393 RVA: 0x00016208 File Offset: 0x00014608
		Public Function SavePositionFile(filename As String, datatable As DataTable, UF As String) As Short
			Dim sepChar As String = ","
			Dim saveResult As Short
			Try
				Dim writer As StreamWriter = New StreamWriter(filename, False)
				writer.Write(UF + vbCrLf)
				Dim num As Integer = 0
				Dim num2 As Integer = datatable.Columns.Count - 2
				Dim i As Integer
				i = num
				While i <= num2
					writer.Write(datatable.Columns(i).ColumnName + sepChar)
					i += 1
				End While
				writer.Write(datatable.Columns(i).ColumnName + vbCrLf)
				For Each obj As Object In datatable.Rows
					Dim row As DataRow = CType(obj, DataRow)
					Dim array As Object() = row.ItemArray
					Dim num3 As Integer = 0
					Dim num4 As Integer = array.Length - 2
					i = num3
					While i <= num4
						writer.Write(array(i).ToString() + sepChar)
						i += 1
					End While
					writer.Write(array(i).ToString() + vbCrLf)
				Next
				writer.Close()
				saveResult = 1S
			Catch ex As Exception
				Interaction.MsgBox("Error while saving file", MsgBoxStyle.Critical, Nothing)
				saveResult = -1S
			End Try
			Return saveResult
		End Function

		' Token: 0x06000572 RID: 1394 RVA: 0x00016378 File Offset: 0x00014778
		Public Function LoadPositionFile(filename As String, ByRef datatable As DataTable, ByRef uf As String, ByRef statpos As Short, ByRef index As Integer) As Short
			Dim loadResult As Short = -1S
			' The following expression was wrapped in a checked-statement
			Try
				Dim fs As StreamReader = New StreamReader(filename)
				Dim i As Integer = 0
				datatable.Rows.Clear()
				uf = fs.ReadLine()
				Dim Header As String = fs.ReadLine()
				While Not fs.EndOfStream
					Dim dataline As String = fs.ReadLine()
					Dim tempArray As String() = Strings.Split(dataline, ",", -1, CompareMethod.Binary)
					Dim row As DataRow = datatable.NewRow()
					Dim num As Integer = 0
					Dim num2 As Integer = tempArray.Length - 1
					i = num
					While i <= num2
						Try
							row(i) = Double.Parse(tempArray(i))
						Catch ex As Exception
							MessageBox.Show(ex.Message)
						End Try
						i += 1
					End While
					datatable.Rows.Add(row)
				End While
				index = datatable.Rows.Count
				fs.Close()
				Dim left As String = uf
				If Operators.CompareString(left, "UF1", False) = 0 Then
					Positioncal.StationPosition = 1
				ElseIf Operators.CompareString(left, "UF2", False) = 0 Then
					Positioncal.StationPosition = 2
				ElseIf Operators.CompareString(left, "UF3", False) = 0 Then
					Positioncal.StationPosition = 3
				ElseIf Operators.CompareString(left, "UF4", False) = 0 Then
					Positioncal.StationPosition = 4
				ElseIf Operators.CompareString(left, "UF5", False) = 0 Then
					Positioncal.StationPosition = 5
				End If
				loadResult = 1S
			Catch ex2 As Exception
				Interaction.MsgBox(ex2.Message, MsgBoxStyle.OkOnly, Nothing)
			End Try
			Return loadResult
		End Function

		' Token: 0x040001DA RID: 474
		Public Const MaxRpm As Integer = 2000

		' Token: 0x040001DB RID: 475
		Public Const SpindRatio As Integer = 81

		' Token: 0x040001DC RID: 476
		Public Const PulsesPerRev As Integer = 331776

		' Token: 0x040001DD RID: 477
		Public Const Tiltaxisppr As Integer = 331776

		' Token: 0x040001DE RID: 478
		Public Const MaxPower As Double = 4500.0

		' Token: 0x040001DF RID: 479
		Public Const RAxisPPR As Integer = 368230

		' Token: 0x040001E0 RID: 480
		Public Const StationAxisNo As Integer = 2

		' Token: 0x040001E1 RID: 481
		Public HomePos As Integer() = New Integer() {0, -114487, -86924, 0, -5368, 0}

		' Token: 0x040001E2 RID: 482
		Public Const LaserPowerCalibFactorA As Double = 0.0025

		' Token: 0x040001E3 RID: 483
		Public Const LaserPowerCalibFactorB As Double = -1.1111

		' Token: 0x040001E4 RID: 484
		Public Const LaserBeamCalibFactorA As Double = 2.3596

		' Token: 0x040001E5 RID: 485
		Public Const LaserBeamCalibFactorB As Double = -4.4599

		' Token: 0x040001E6 RID: 486
		Public StationCalib As Double() = New Double() {1052.246678461, -1057.3704219394, 69.6170492284471}

		' Token: 0x040001E7 RID: 487
		Public Spindnormalhor As Double() = New Double() {0.00142159179501997, 0.999998937401028, -0.000322914204078179}

		' Token: 0x040001E8 RID: 488
		Public Tiltnormal As Double() = New Double() {0.999921270031643, -0.00268781499345932, -0.012256809897608}

		' Token: 0x040001E9 RID: 489
		Public Const Chuckdist As Double = 443.737

		' Token: 0x040001EA RID: 490
		Public Const JointIdleSpeed As Integer = 5

		' Token: 0x040001EB RID: 491
		Public Const Minbeamdia As Double = 1.9

		' Token: 0x040001EC RID: 492
		Public Const Maxbeamdia As Double = 6.25

		' Token: 0x040001ED RID: 493
		Public Diameter As Double

		' Token: 0x040001EE RID: 494
		Public CrankThrow As Double

		' Token: 0x040001EF RID: 495
		Public Width1 As Double

		' Token: 0x040001F0 RID: 496
		Public Pitch As Double

		' Token: 0x040001F1 RID: 497
		Public Distance As Double

		' Token: 0x040001F2 RID: 498
		Public LaserPowerIni As Integer

		' Token: 0x040001F3 RID: 499
		Public LaserPowerFin As Integer

		' Token: 0x040001F4 RID: 500
		Public LaserReductionTrackNo As Integer

		' Token: 0x040001F5 RID: 501
		Public StartDistance As Double

		' Token: 0x040001F6 RID: 502
		Public EndDistance As Double

		' Token: 0x040001F7 RID: 503
		Public PowderFeed As Double

		' Token: 0x040001F8 RID: 504
		Public PowderJar As Short

		' Token: 0x040001F9 RID: 505
		Public ProcessSpeed As Double

		' Token: 0x040001FA RID: 506
		Public PostureAngle As Double

		' Token: 0x040001FB RID: 507
		Public ConeAngle As Double

		' Token: 0x040001FC RID: 508
		Public StationPosition As Integer

		' Token: 0x040001FD RID: 509
		Public IniOverWeld As Single

		' Token: 0x040001FE RID: 510
		Public FinOverWeld As Single

		' Token: 0x040001FF RID: 511
		Public MeanderAmp As Double

		' Token: 0x04000200 RID: 512
		Public MeanderPitch As Double

		' Token: 0x04000201 RID: 513
		Public MeanderFlg As Short

		' Token: 0x04000202 RID: 514
		Public InitialAng As Double

		' Token: 0x04000203 RID: 515
		Public ValveFlg As Boolean

		' Token: 0x04000204 RID: 516
		Public CladWidth As Double

		' Token: 0x04000205 RID: 517
		Public KeyDistance As Double

		' Token: 0x04000206 RID: 518
		Public KeyWidth As Double

		' Token: 0x04000207 RID: 519
		Public KeyLength As Double

		' Token: 0x04000208 RID: 520
		Public KeyAngle As Double

		' Token: 0x04000209 RID: 521
		Public BasePath As String

		' Token: 0x0400020A RID: 522
		Public ipaddress As String

		' Token: 0x0400020B RID: 523
		Public IniOverPower As Integer

		' Token: 0x0400020C RID: 524
		Public FinOverPower As Integer

		' Token: 0x0400020D RID: 525
		Public IniOverPowerDis As Integer

		' Token: 0x0400020E RID: 526
		Public FinOverPowerDis As Integer

		' Token: 0x0400020F RID: 527
		Public IniPowderRed As Integer

		' Token: 0x04000210 RID: 528
		Public FinPowderRed As Integer

		' Token: 0x04000211 RID: 529
		Public ToolOffset As Double

		' Token: 0x04000212 RID: 530
		Public IdleSpeed As Double

		' Token: 0x04000213 RID: 531
		Public ApproachSpeed As Double

		' Token: 0x04000214 RID: 532
		Public IniYAxisOffset As Double

		' Token: 0x04000215 RID: 533
		Public IniZAxisOffset As Double

		' Token: 0x04000216 RID: 534
		Public IniXAxisOffset As Double

		' Token: 0x04000217 RID: 535
		Public PowderSettling1 As Double

		' Token: 0x04000218 RID: 536
		Public PowderSettling2 As Double

		' Token: 0x04000219 RID: 537
		Public PositionLevel As Integer

		' Token: 0x0400021A RID: 538
		Public WorkXAxisOffset As Double

		' Token: 0x0400021B RID: 539
		Public WorkYAxisTilt As Double

		' Token: 0x0400021C RID: 540
		Public WorkZAxisYaw As Double

		' Token: 0x0400021D RID: 541
		Public DirectionFlg As Integer

		' Token: 0x0400021E RID: 542
		Public CladdingDir As Integer

		' Token: 0x0400021F RID: 543
		Public MinDistance As Double

		' Token: 0x04000220 RID: 544
		Public PPR As Integer

		' Token: 0x04000221 RID: 545
		Public Tiltangle As Double

		' Token: 0x04000222 RID: 546
		Public SpeedMultiplier As Integer = 2

		' Token: 0x04000223 RID: 547
		Public Const backlash As Integer = 3

		' Token: 0x04000224 RID: 548
		Public Length As Double

		' Token: 0x04000225 RID: 549
		Public Xpos As Double

		' Token: 0x04000226 RID: 550
		Public Ypos As Double

		' Token: 0x04000227 RID: 551
		Public Zpos As Double

		' Token: 0x04000228 RID: 552
		Public Toolno As Integer

		' Token: 0x04000229 RID: 553
		Public CurProjPath As String

		' Token: 0x0400022A RID: 554
		Public Position As Double(,) = New Double(12, 0) {}

		' Token: 0x0400022B RID: 555
		Public ConectStat As Short

		' Token: 0x0400022C RID: 556
		Public CurrPos As Short

		' Token: 0x0400022D RID: 557
		Public ProjLoad As Boolean

		' Token: 0x0400022E RID: 558
		Public ProcCycle As Short

		' Token: 0x0400022F RID: 559
		Public ProjParam As String

		' Token: 0x04000230 RID: 560
		Public Leftangle As Double

		' Token: 0x04000231 RID: 561
		Public Rightangle As Double

		' Token: 0x04000232 RID: 562
		Public Layerheight As Double

		' Token: 0x04000233 RID: 563
		Public Layernumber As Integer

		' Token: 0x04000234 RID: 564
		Public Intoverweld As Single

		' Token: 0x04000235 RID: 565
		Public Rockangle As Double

		' Token: 0x04000236 RID: 566
		Public Rockangvar As Short

		' Token: 0x04000237 RID: 567
		Public Keyno As Integer

		' Token: 0x04000238 RID: 568
		Public time As UInteger

		' Token: 0x04000239 RID: 569
		Public TotalSteps As Integer

		' Token: 0x0400023A RID: 570
		Public PointNo As Integer

		' Token: 0x0400023B RID: 571
		Public MovDir As Short

		' Token: 0x0400023C RID: 572
		Public ArrDir As Short

		' Token: 0x0400023D RID: 573
		Public Copies As Short

		' Token: 0x0400023E RID: 574
		Public Arrayrecptc As Double

		' Token: 0x0400023F RID: 575
		Public Arrayangptc As Double

		' Token: 0x04000240 RID: 576
		Public ConstBeamFlg As Short

		' Token: 0x04000241 RID: 577
		Public Overlaydir As Short

		' Token: 0x04000242 RID: 578
		Public Arraydir As Short

		' Token: 0x04000243 RID: 579
		Public Movementtype As Short

		' Token: 0x04000244 RID: 580
		Public ControlGroup As Short

		' Token: 0x04000245 RID: 581
		Public MaxZRobotPos As Double
	End Module
End Namespace
