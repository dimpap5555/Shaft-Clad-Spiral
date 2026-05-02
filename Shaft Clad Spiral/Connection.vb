Imports System
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

Namespace WindowsApplication1
	' Token: 0x0200000B RID: 11
	Friend Module Connection
		' Token: 0x0600015A RID: 346 RVA: 0x00002DF8 File Offset: 0x000011F8
		Public Function Ms_BscOpenComm(strIPaddr As String, path As String, ether_mode As Integer, hwnd As Long) As Integer
			Connection.nCid = CInt(MotoCom32.BscOpen(path, 256S))
			If Connection.nCid >= 0 Then
				Connection.ret = CInt(MotoCom32.BscSetEServerMode(CShort(Connection.nCid), strIPaddr, -1S))
				If Connection.ret = 1 Then
					Connection.ret = CInt(MotoCom32.BscConnect(CShort(Connection.nCid)))
					If Connection.ret <> 1 Then
						Connection.ret = CInt(MotoCom32.BscEnforcedClose(CShort(Connection.nCid)))
						Connection.nCid = -1
						Interaction.MsgBox("Error establishing connection !", MsgBoxStyle.OkOnly, Nothing)
					End If
					Dim remmode As Short = MotoCom32.BscIsRemoteMode(CShort(Connection.nCid))
					If remmode = -1S Then
						Connection.ret = CInt(MotoCom32.BscClose(CShort(Connection.nCid)))
						MotoCom32.BscConnect(CShort(Connection.nCid))
						Interaction.MsgBox("Please set controller to remote mode", MsgBoxStyle.OkOnly, Nothing)
					End If
				Else
					Connection.ret = CInt(MotoCom32.BscClose(CShort(Connection.nCid)))
					Connection.nCid = -1
					Interaction.MsgBox("Error setting up ethernet !", MsgBoxStyle.OkOnly, Nothing)
				End If
			Else
				Interaction.MsgBox("Hardware Key Error !", MsgBoxStyle.OkOnly, Nothing)
				Connection.nCid = -1
				Connection.ret = 0
			End If
			Return Connection.ret
		End Function

		' Token: 0x0600015B RID: 347 RVA: 0x00002EF8 File Offset: 0x000012F8
		Public Function MS_BscCloseComm(ncid As Integer) As Integer
			' The following expression was wrapped in a checked-statement
			Dim ret As Integer = CInt(MotoCom32.BscDisConnect(CShort(ncid)))
			Return CInt(MotoCom32.BscEnforcedClose(CShort(ncid)))
		End Function

		' Token: 0x04000081 RID: 129
		Public nCid As Integer

		' Token: 0x04000082 RID: 130
		Public ret As Integer
	End Module
End Namespace
