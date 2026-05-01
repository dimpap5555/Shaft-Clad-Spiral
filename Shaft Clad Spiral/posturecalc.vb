Imports System
Imports Microsoft.VisualBasic.CompilerServices
Imports Microsoft.VisualBasic.FileIO

Namespace WindowsApplication1
	' Token: 0x0200001D RID: 29
	Friend NotInheritable Module posturecalc
		' Token: 0x060005B0 RID: 1456 RVA: 0x00016518 File Offset: 0x00014918
		Public Sub posture(obstdia As Double, procdia As Double, obstdist As Double, endpathdist As Double)
			Dim headcoordsx As Double() = New Double(102) {}
			Dim headcoordsy As Double() = New Double(102) {}
			Dim obstcoordsx As Double() = New Double(102) {}
			Dim obstcoordsy As Object() = New Object(102) {}
			Dim line As Integer
			Using inputfile As TextFieldParser = New TextFieldParser("c:\documents and settings\tech2\desktop\test.txt")
				inputfile.TextFieldType = FieldType.Delimited
				inputfile.SetDelimiters(New String() { "  " })
				While Not inputfile.EndOfData
					Dim currentrow As String() = inputfile.ReadFields()
					Dim row As Integer = 0
					For Each currentfield As String In currentrow
						If row = 0 Then
							headcoordsx(line) = CDbl(Conversions.ToInteger(currentfield))
						Else
							headcoordsy(line) = CDbl(Conversions.ToInteger(currentfield))
						End If
						row += 1
					Next
					line += 1
				End While
			End Using
			line = 0
			While CDbl(line) <= obstdia - procdia / 2.0
				obstcoordsx(line) = obstdist
				obstcoordsy(line) = line
				line += 1
			End While
		End Sub
	End Module
End Namespace
