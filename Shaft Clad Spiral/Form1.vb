﻿Imports System
Imports System.Drawing
Imports System.IO
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports WindowsApplication1.My

Namespace WindowsApplication1
    Public Partial Class Form1
        Inherits Form

        Private formatstat As Short

        Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        			Me.Timer1.Start()
        			Me.Timer1.Interval = 1000
        			If Global.WindowsApplication1.My.MyProject.Computer.FileSystem.FileExists(Application.StartupPath + "\settings.txt") Then
        				Dim fs As FileStream = New FileStream(Application.StartupPath + "\settings.txt", FileMode.Open)
        				Dim r As StreamReader = New StreamReader(fs)
        				Positioncal.BasePath = r.ReadLine()
        				If Not Global.WindowsApplication1.My.MyProject.Computer.FileSystem.DirectoryExists(Positioncal.BasePath) Then
        					Interaction.MsgBox("The base directory " + Positioncal.BasePath + " does not exist or is not accessible. C:\ will be used instead.", MsgBoxStyle.OkOnly, Nothing)
        					Positioncal.BasePath = "c:\"
        				End If
        				Positioncal.ipaddress = r.ReadLine()
        				r.Close()
        			Else
        				Positioncal.BasePath = "c:\"
        				Positioncal.ipaddress = "192.168.002.002"
        			End If
        			If Global.WindowsApplication1.My.MyProject.Computer.FileSystem.FileExists(Application.StartupPath + "\miscsettings.txt") Then
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
        			If Global.WindowsApplication1.My.MyProject.Computer.FileSystem.FileExists(Application.StartupPath + "\Processsettings.txt") Then
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
        			Global.WindowsApplication1.My.MyProject.Forms.Processsetup.Enabled = True
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

        Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        			Connection.MS_BscCloseComm(Connection.nCid)
        			ProjectData.EndApp()
        		End Sub

        Private Sub Cnfrmbtn_Click(sender As Object, e As EventArgs) Handles Quitbtn.Click
        			Connection.MS_BscCloseComm(Connection.nCid)
        			ProjectData.EndApp()
        		End Sub

        Private Sub connect_Click(sender As Object, e As EventArgs) Handles connect.Click
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

        Private Sub Download_Click(sender As Object, e As EventArgs) Handles Download.Click
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

        Private Sub processcycle_SelectedIndexChanged(sender As Object, e As EventArgs) Handles processcycle.SelectedIndexChanged
        			' The following expression was wrapped in a checked-statement
        			If Not Positioncal.ProjLoad Then
        				Positioncal.ProcCycle = CShort(Me.processcycle.SelectedIndex)
        			Else
        				Positioncal.ProcCycle = CShort(Conversions.ToInteger(Positioncal.ProjParam))
        			End If
        			Select Case Positioncal.ProcCycle
        				Case 0S
        					Dim form2rect As Rectangle = New Rectangle(50, 100, 700, 570)
        					If Global.WindowsApplication1.My.MyProject.Computer.FileSystem.FileExists(Application.StartupPath + "\Scladparam.txt") Then
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
        					Global.WindowsApplication1.My.MyProject.Forms.SPARAM.DesktopBounds = form2rect
        					Global.WindowsApplication1.My.MyProject.Forms.SPARAM.ShowDialog()
        					If Global.WindowsApplication1.My.MyProject.Forms.SPARAM.DialogResult = DialogResult.OK Then
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
        					If Global.WindowsApplication1.My.MyProject.Computer.FileSystem.FileExists(Application.StartupPath + "\Keycladparam.txt") Then
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
        					Global.WindowsApplication1.My.MyProject.Forms.KEYPARAM.DesktopBounds = form2rect2
        					Global.WindowsApplication1.My.MyProject.Forms.KEYPARAM.ShowDialog()
        					If Global.WindowsApplication1.My.MyProject.Forms.KEYPARAM.DialogResult = DialogResult.OK Then
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
        					If Global.WindowsApplication1.My.MyProject.Computer.FileSystem.FileExists(Application.StartupPath + "\Vcladparam.txt") Then
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
        					Global.WindowsApplication1.My.MyProject.Forms.VPARAM.DesktopBounds = form2rect3
        					Global.WindowsApplication1.My.MyProject.Forms.VPARAM.ShowDialog()
        					If Global.WindowsApplication1.My.MyProject.Forms.VPARAM.DialogResult = DialogResult.OK Then
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
        					If Global.WindowsApplication1.My.MyProject.Computer.FileSystem.FileExists(Application.StartupPath + "\Crcladparam.txt") Then
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
        					Global.WindowsApplication1.My.MyProject.Forms.CRPARAM.DesktopBounds = form2rect4
        					Global.WindowsApplication1.My.MyProject.Forms.CRPARAM.ShowDialog()
        					If Global.WindowsApplication1.My.MyProject.Forms.CRPARAM.DialogResult = DialogResult.OK Then
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
        					If Global.WindowsApplication1.My.MyProject.Computer.FileSystem.FileExists(Application.StartupPath + "\Pcladparam.txt") Then
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
        					Global.WindowsApplication1.My.MyProject.Forms.PPARAM.DesktopBounds = form2rect5
        					Global.WindowsApplication1.My.MyProject.Forms.PPARAM.ShowDialog()
        					If Global.WindowsApplication1.My.MyProject.Forms.PPARAM.DialogResult = DialogResult.OK Then
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
        					If Global.WindowsApplication1.My.MyProject.Computer.FileSystem.FileExists(Application.StartupPath + "\Bcladparam.txt") Then
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
        					Global.WindowsApplication1.My.MyProject.Forms.BPARAM.DesktopBounds = form2rect6
        					Global.WindowsApplication1.My.MyProject.Forms.BPARAM.ShowDialog()
        					If Global.WindowsApplication1.My.MyProject.Forms.BPARAM.DialogResult = DialogResult.OK Then
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
        					If Global.WindowsApplication1.My.MyProject.Computer.FileSystem.FileExists(Application.StartupPath + "\Pocketcladparam.txt") Then
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
        					Global.WindowsApplication1.My.MyProject.Forms.POCKETPARAM.DesktopBounds = form2rect7
        					Global.WindowsApplication1.My.MyProject.Forms.POCKETPARAM.ShowDialog()
        					If Global.WindowsApplication1.My.MyProject.Forms.POCKETPARAM.DialogResult = DialogResult.OK Then
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
        					If Global.WindowsApplication1.My.MyProject.Computer.FileSystem.FileExists(Application.StartupPath + "\Groovecladparam.txt") Then
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
        					Global.WindowsApplication1.My.MyProject.Forms.GRVPARAM.DesktopBounds = form2rect8
        					Global.WindowsApplication1.My.MyProject.Forms.GRVPARAM.ShowDialog()
        					If Global.WindowsApplication1.My.MyProject.Forms.GRVPARAM.DialogResult = DialogResult.OK Then
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
        					If Global.WindowsApplication1.My.MyProject.Computer.FileSystem.FileExists(Application.StartupPath + "\Congroovecladparam.txt") Then
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
        					Global.WindowsApplication1.My.MyProject.Forms.CONGRVPARAM.DesktopBounds = form2rect9
        					Global.WindowsApplication1.My.MyProject.Forms.CONGRVPARAM.ShowDialog()
        					If Global.WindowsApplication1.My.MyProject.Forms.CONGRVPARAM.DialogResult = DialogResult.OK Then
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
        					If Global.WindowsApplication1.My.MyProject.Computer.FileSystem.FileExists(Application.StartupPath + "\3Dcladparam.txt") Then
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
        					Global.WindowsApplication1.My.MyProject.Forms.THREEDCLADPARAM.DesktopBounds = form2rect10
        					Global.WindowsApplication1.My.MyProject.Forms.THREEDCLADPARAM.ShowDialog()
        					If Global.WindowsApplication1.My.MyProject.Forms.THREEDCLADPARAM.DialogResult = DialogResult.OK Then
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

        Private Sub Procsetupbtn_Click(sender As Object, e As EventArgs) Handles Procsetupbtn.Click
        			Dim form2rect As Rectangle = New Rectangle(50, 100, 580, 440)
        			Global.WindowsApplication1.My.MyProject.Forms.Processsetup.DesktopBounds = form2rect
        			Global.WindowsApplication1.My.MyProject.Forms.Processsetup.ShowDialog()
        			If Global.WindowsApplication1.My.MyProject.Forms.Processsetup.DialogResult = DialogResult.OK Then
        				processparam.paramset(Positioncal.LaserPowerIni, Positioncal.PowderFeed, CInt(Positioncal.PowderJar), Me.Handle.ToInt32())
        				Me.processcycle.Enabled = True
        				If Positioncal.ConectStat = 1S And Me.processcycle.SelectedIndex >= 0 Then
        					Me.Download.Enabled = True
        				Else
        					Me.Download.Enabled = False
        				End If
        			End If
        		End Sub

        Private Sub ConnectionSettingsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConnectionSettingsToolStripMenuItem.Click
        			Global.WindowsApplication1.My.MyProject.Forms.ConnectionSettings.ShowDialog()
        		End Sub

        Private Sub MisselaneousSettingsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MisselaneousSettingsToolStripMenuItem.Click
        			Dim form2rect As Rectangle = New Rectangle(50, 100, 668, 510)
        			Global.WindowsApplication1.My.MyProject.Forms.Miscsettings.DesktopBounds = form2rect
        			Global.WindowsApplication1.My.MyProject.Forms.Miscsettings.ShowDialog()
        			If Positioncal.ConectStat = 1S And Me.processcycle.SelectedIndex >= 0 Then
        				Me.Download.Enabled = True
        			Else
        				Me.Download.Enabled = False
        			End If
        		End Sub

        Private Sub SaveAsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveAsToolStripMenuItem.Click
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
        					fs = Global.WindowsApplication1.My.MyProject.Computer.FileSystem.OpenTextFileWriter(savefiledialog.FileName, False)
        					If fs IsNot Nothing Then
        						fs.WriteLine(projparam)
        						Positioncal.CurProjPath = savefiledialog.FileName
        						Dim CurProjDir As String = Strings.Left(savefiledialog.FileName, Strings.Len(savefiledialog.FileName) - 4)
        						Global.WindowsApplication1.My.MyProject.Computer.FileSystem.CreateDirectory(CurProjDir)
        						Global.WindowsApplication1.My.MyProject.Computer.FileSystem.CopyFile(Application.StartupPath + settingfile, CurProjDir + settingfile, True)
        						Global.WindowsApplication1.My.MyProject.Computer.FileSystem.CopyFile(Application.StartupPath + "\miscsettings.txt", CurProjDir + "\miscsettings.txt", True)
        						Global.WindowsApplication1.My.MyProject.Computer.FileSystem.CopyFile(Application.StartupPath + "\processsettings.txt", CurProjDir + "\processsettings.txt", True)
        						If Positioncal.ProcCycle = 9S Then
        							Global.WindowsApplication1.My.MyProject.Computer.FileSystem.CopyFile(Application.StartupPath + "\tempfile.txt", CurProjDir + "\positions.txt", True)
        						End If
        						Me.SaveToolStripMenuItem.Enabled = True
        						Me.CloseProjectToolStripMenuItem.Enabled = True
        						MyBase.Text = "Robot Control - " + Global.WindowsApplication1.My.MyProject.Computer.FileSystem.GetName(savefiledialog.FileName)
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

        Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
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
        				fs = Global.WindowsApplication1.My.MyProject.Computer.FileSystem.OpenTextFileWriter(Positioncal.CurProjPath, False)
        				If fs IsNot Nothing Then
        					fs.WriteLine(projparam)
        					Dim CurProjDir As String = Strings.Left(Positioncal.CurProjPath, Strings.Len(Positioncal.CurProjPath) - 4)
        					Global.WindowsApplication1.My.MyProject.Computer.FileSystem.CopyFile(Application.StartupPath + settingfile, CurProjDir + settingfile, True)
        					Global.WindowsApplication1.My.MyProject.Computer.FileSystem.CopyFile(Application.StartupPath + "\miscsettings.txt", CurProjDir + "\miscsettings.txt", True)
        					Global.WindowsApplication1.My.MyProject.Computer.FileSystem.CopyFile(Application.StartupPath + "\processsettings.txt", CurProjDir + "\processsettings.txt", True)
        					If Positioncal.ProcCycle = 9S Then
        						Global.WindowsApplication1.My.MyProject.Computer.FileSystem.CopyFile(Application.StartupPath + "\tempfile.txt", CurProjDir + "\positions.txt", True)
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

        Private Sub OpenProjectToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles OpenProjectToolStripMenuItem1.Click
        			Dim OpenFileDialog As OpenFileDialog = New OpenFileDialog()
        			Dim table As DataTable = New DataTable("table")
        			OpenFileDialog.Filter = "Robot Project file|*.rbp"
        			If OpenFileDialog.ShowDialog() = DialogResult.OK Then
        				Dim projreader As StreamReader = Global.WindowsApplication1.My.MyProject.Computer.FileSystem.OpenTextFileReader(OpenFileDialog.FileName, Encoding.ASCII)
        				Positioncal.ProjParam = projreader.ReadLine()
        				projreader.Close()
        				Dim ProjDir As String = Strings.Left(OpenFileDialog.FileName, Strings.Len(OpenFileDialog.FileName) - 4) + "\"
        				Try
        					Try
        						For Each foundfile As String In Global.WindowsApplication1.My.MyProject.Computer.FileSystem.GetFiles(ProjDir)
        							Global.WindowsApplication1.My.MyProject.Computer.FileSystem.CopyFile(foundfile, Application.StartupPath + "\" + Global.WindowsApplication1.My.MyProject.Computer.FileSystem.GetName(foundfile), True)
        						Next
        					Finally
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
        				MyBase.Text = "Robot Control - " + Global.WindowsApplication1.My.MyProject.Computer.FileSystem.GetName(OpenFileDialog.FileName)
        				Positioncal.ProjLoad = True
        			End If
        		End Sub

        Private Sub CloseProjectToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseProjectToolStripMenuItem.Click
        			MyBase.OnLoad(e)
        			Me.SaveToolStripMenuItem.Enabled = False
        			Me.CloseProjectToolStripMenuItem.Enabled = False
        			MyBase.Text = "Robot Control"
        			Positioncal.ProjLoad = False
        		End Sub

        Private Sub hold_Click(sender As Object, e As EventArgs) Handles hold.Click
        			' The following expression was wrapped in a checked-statement
        			MotoCom32.BscHoldOn(CShort(Connection.nCid))
        			MotoCom32.BscHoldOff(CShort(Connection.nCid))
        		End Sub

        Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
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

        Private Sub Offlinecheck_CheckedChanged(sender As Object, e As EventArgs) Handles Offlinecheck.CheckedChanged
        			If Me.Offlinecheck.Checked And Positioncal.ConectStat = 0S Then
        				Me.connect.Enabled = False
        				Me.Timer1.Enabled = False
        			Else
        				Me.connect.Enabled = True
        				Me.Timer1.Enabled = True
        			End If
        		End Sub
    End Class
End Namespace
