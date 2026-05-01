Namespace WindowsApplication1
	' Token: 0x0200001C RID: 28
	<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
	Public Partial Class Posıtıonupload
		Inherits Global.System.Windows.Forms.Form

		' Token: 0x06000574 RID: 1396 RVA: 0x00048674 File Offset: 0x00046A74
		<Global.System.Diagnostics.DebuggerNonUserCode()>
		Protected Overrides Sub Dispose(disposing As Boolean)
			Try
				If disposing AndAlso Me.components IsNot Nothing Then
					Me.components.Dispose()
				End If
			Finally
				MyBase.Dispose(disposing)
			End Try
		End Sub

		' Token: 0x06000575 RID: 1397 RVA: 0x000486B4 File Offset: 0x00046AB4
		<Global.System.Diagnostics.DebuggerStepThrough()>
		Private Sub InitializeComponent()
			Me.Xpostxt = New Global.System.Windows.Forms.TextBox()
			Me.GroupBox1 = New Global.System.Windows.Forms.GroupBox()
			Me.Label6 = New Global.System.Windows.Forms.Label()
			Me.Label5 = New Global.System.Windows.Forms.Label()
			Me.Label4 = New Global.System.Windows.Forms.Label()
			Me.Label3 = New Global.System.Windows.Forms.Label()
			Me.Label2 = New Global.System.Windows.Forms.Label()
			Me.Label1 = New Global.System.Windows.Forms.Label()
			Me.Rzpostxt = New Global.System.Windows.Forms.TextBox()
			Me.Rypostxt = New Global.System.Windows.Forms.TextBox()
			Me.Rxpostxt = New Global.System.Windows.Forms.TextBox()
			Me.Zpostxt = New Global.System.Windows.Forms.TextBox()
			Me.Ypostxt = New Global.System.Windows.Forms.TextBox()
			Me.GroupBox2 = New Global.System.Windows.Forms.GroupBox()
			Me.Label8 = New Global.System.Windows.Forms.Label()
			Me.Label7 = New Global.System.Windows.Forms.Label()
			Me.S2postxt = New Global.System.Windows.Forms.TextBox()
			Me.S1postxt = New Global.System.Windows.Forms.TextBox()
			Me.GroupBox3 = New Global.System.Windows.Forms.GroupBox()
			Me.Usrfrmtxt = New Global.System.Windows.Forms.TextBox()
			Me.Cnfrm_btn = New Global.System.Windows.Forms.Button()
			Me.Cncl_btn = New Global.System.Windows.Forms.Button()
			Me.Upload_btn = New Global.System.Windows.Forms.Button()
			Me.GroupBox1.SuspendLayout()
			Me.GroupBox2.SuspendLayout()
			Me.GroupBox3.SuspendLayout()
			Me.SuspendLayout()
			Me.Xpostxt.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 9.75F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 161)
			Dim xpostxt As Global.System.Windows.Forms.Control = Me.Xpostxt
			Dim location As Global.System.Drawing.Point = New Global.System.Drawing.Point(26, 44)
			xpostxt.Location = location
			Me.Xpostxt.Name = "Xpostxt"
			Dim xpostxt2 As Global.System.Windows.Forms.Control = Me.Xpostxt
			Dim size As Global.System.Drawing.Size = New Global.System.Drawing.Size(75, 22)
			xpostxt2.Size = size
			Me.Xpostxt.TabIndex = 1
			Me.GroupBox1.Controls.Add(Me.Label6)
			Me.GroupBox1.Controls.Add(Me.Label5)
			Me.GroupBox1.Controls.Add(Me.Label4)
			Me.GroupBox1.Controls.Add(Me.Label3)
			Me.GroupBox1.Controls.Add(Me.Label2)
			Me.GroupBox1.Controls.Add(Me.Label1)
			Me.GroupBox1.Controls.Add(Me.Rzpostxt)
			Me.GroupBox1.Controls.Add(Me.Rypostxt)
			Me.GroupBox1.Controls.Add(Me.Rxpostxt)
			Me.GroupBox1.Controls.Add(Me.Zpostxt)
			Me.GroupBox1.Controls.Add(Me.Ypostxt)
			Me.GroupBox1.Controls.Add(Me.Xpostxt)
			Dim groupBox As Global.System.Windows.Forms.Control = Me.GroupBox1
			location = New Global.System.Drawing.Point(34, 116)
			groupBox.Location = location
			Me.GroupBox1.Name = "GroupBox1"
			Dim groupBox2 As Global.System.Windows.Forms.Control = Me.GroupBox1
			size = New Global.System.Drawing.Size(609, 98)
			groupBox2.Size = size
			Me.GroupBox1.TabIndex = 2
			Me.GroupBox1.TabStop = False
			Me.GroupBox1.Text = "Robot Position"
			Me.Label6.AutoSize = True
			Dim label As Global.System.Windows.Forms.Control = Me.Label6
			location = New Global.System.Drawing.Point(519, 28)
			label.Location = location
			Me.Label6.Name = "Label6"
			Dim label2 As Global.System.Windows.Forms.Control = Me.Label6
			size = New Global.System.Drawing.Size(49, 13)
			label2.Size = size
			Me.Label6.TabIndex = 9
			Me.Label6.Text = "Rz (Deg)"
			Me.Label5.AutoSize = True
			Dim label3 As Global.System.Windows.Forms.Control = Me.Label5
			location = New Global.System.Drawing.Point(424, 28)
			label3.Location = location
			Me.Label5.Name = "Label5"
			Dim label4 As Global.System.Windows.Forms.Control = Me.Label5
			size = New Global.System.Drawing.Size(49, 13)
			label4.Size = size
			Me.Label5.TabIndex = 9
			Me.Label5.Text = "Ry (Deg)"
			Me.Label4.AutoSize = True
			Dim label5 As Global.System.Windows.Forms.Control = Me.Label4
			location = New Global.System.Drawing.Point(326, 28)
			label5.Location = location
			Me.Label4.Name = "Label4"
			Dim label6 As Global.System.Windows.Forms.Control = Me.Label4
			size = New Global.System.Drawing.Size(49, 13)
			label6.Size = size
			Me.Label4.TabIndex = 8
			Me.Label4.Text = "Rx (Deg)"
			Me.Label3.AutoSize = True
			Dim label7 As Global.System.Windows.Forms.Control = Me.Label3
			location = New Global.System.Drawing.Point(236, 28)
			label7.Location = location
			Me.Label3.Name = "Label3"
			Dim label8 As Global.System.Windows.Forms.Control = Me.Label3
			size = New Global.System.Drawing.Size(39, 13)
			label8.Size = size
			Me.Label3.TabIndex = 8
			Me.Label3.Text = "Z (mm)"
			Me.Label2.AutoSize = True
			Dim label9 As Global.System.Windows.Forms.Control = Me.Label2
			location = New Global.System.Drawing.Point(139, 28)
			label9.Location = location
			Me.Label2.Name = "Label2"
			Dim label10 As Global.System.Windows.Forms.Control = Me.Label2
			size = New Global.System.Drawing.Size(39, 13)
			label10.Size = size
			Me.Label2.TabIndex = 8
			Me.Label2.Text = "Y (mm)"
			Me.Label1.AutoSize = True
			Dim label11 As Global.System.Windows.Forms.Control = Me.Label1
			location = New Global.System.Drawing.Point(44, 28)
			label11.Location = location
			Me.Label1.Name = "Label1"
			Dim label12 As Global.System.Windows.Forms.Control = Me.Label1
			size = New Global.System.Drawing.Size(39, 13)
			label12.Size = size
			Me.Label1.TabIndex = 7
			Me.Label1.Text = "X (mm)"
			Me.Rzpostxt.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 9.75F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 161)
			Dim rzpostxt As Global.System.Windows.Forms.Control = Me.Rzpostxt
			location = New Global.System.Drawing.Point(506, 44)
			rzpostxt.Location = location
			Me.Rzpostxt.Name = "Rzpostxt"
			Dim rzpostxt2 As Global.System.Windows.Forms.Control = Me.Rzpostxt
			size = New Global.System.Drawing.Size(75, 22)
			rzpostxt2.Size = size
			Me.Rzpostxt.TabIndex = 6
			Me.Rypostxt.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 9.75F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 161)
			Dim rypostxt As Global.System.Windows.Forms.Control = Me.Rypostxt
			location = New Global.System.Drawing.Point(410, 44)
			rypostxt.Location = location
			Me.Rypostxt.Name = "Rypostxt"
			Dim rypostxt2 As Global.System.Windows.Forms.Control = Me.Rypostxt
			size = New Global.System.Drawing.Size(75, 22)
			rypostxt2.Size = size
			Me.Rypostxt.TabIndex = 5
			Me.Rxpostxt.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 9.75F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 161)
			Dim rxpostxt As Global.System.Windows.Forms.Control = Me.Rxpostxt
			location = New Global.System.Drawing.Point(314, 44)
			rxpostxt.Location = location
			Me.Rxpostxt.Name = "Rxpostxt"
			Dim rxpostxt2 As Global.System.Windows.Forms.Control = Me.Rxpostxt
			size = New Global.System.Drawing.Size(75, 22)
			rxpostxt2.Size = size
			Me.Rxpostxt.TabIndex = 4
			Me.Zpostxt.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 9.75F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 161)
			Dim zpostxt As Global.System.Windows.Forms.Control = Me.Zpostxt
			location = New Global.System.Drawing.Point(218, 44)
			zpostxt.Location = location
			Me.Zpostxt.Name = "Zpostxt"
			Dim zpostxt2 As Global.System.Windows.Forms.Control = Me.Zpostxt
			size = New Global.System.Drawing.Size(75, 22)
			zpostxt2.Size = size
			Me.Zpostxt.TabIndex = 3
			Me.Ypostxt.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 9.75F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 161)
			Dim ypostxt As Global.System.Windows.Forms.Control = Me.Ypostxt
			location = New Global.System.Drawing.Point(122, 44)
			ypostxt.Location = location
			Me.Ypostxt.Name = "Ypostxt"
			Dim ypostxt2 As Global.System.Windows.Forms.Control = Me.Ypostxt
			size = New Global.System.Drawing.Size(75, 22)
			ypostxt2.Size = size
			Me.Ypostxt.TabIndex = 2
			Me.GroupBox2.Controls.Add(Me.Label8)
			Me.GroupBox2.Controls.Add(Me.Label7)
			Me.GroupBox2.Controls.Add(Me.S2postxt)
			Me.GroupBox2.Controls.Add(Me.S1postxt)
			Dim groupBox3 As Global.System.Windows.Forms.Control = Me.GroupBox2
			location = New Global.System.Drawing.Point(217, 220)
			groupBox3.Location = location
			Me.GroupBox2.Name = "GroupBox2"
			Dim groupBox4 As Global.System.Windows.Forms.Control = Me.GroupBox2
			size = New Global.System.Drawing.Size(242, 98)
			groupBox4.Size = size
			Me.GroupBox2.TabIndex = 3
			Me.GroupBox2.TabStop = False
			Me.GroupBox2.Text = "Station Position"
			Me.Label8.AutoSize = True
			Dim label13 As Global.System.Windows.Forms.Control = Me.Label8
			location = New Global.System.Drawing.Point(150, 25)
			label13.Location = location
			Me.Label8.Name = "Label8"
			Dim label14 As Global.System.Windows.Forms.Control = Me.Label8
			size = New Global.System.Drawing.Size(49, 13)
			label14.Size = size
			Me.Label8.TabIndex = 10
			Me.Label8.Text = "S2 (Deg)"
			Me.Label7.AutoSize = True
			Dim label15 As Global.System.Windows.Forms.Control = Me.Label7
			location = New Global.System.Drawing.Point(54, 25)
			label15.Location = location
			Me.Label7.Name = "Label7"
			Dim label16 As Global.System.Windows.Forms.Control = Me.Label7
			size = New Global.System.Drawing.Size(49, 13)
			label16.Size = size
			Me.Label7.TabIndex = 9
			Me.Label7.Text = "S1 (Deg)"
			Me.S2postxt.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 9.75F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 161)
			Dim s2postxt As Global.System.Windows.Forms.Control = Me.S2postxt
			location = New Global.System.Drawing.Point(137, 41)
			s2postxt.Location = location
			Me.S2postxt.Name = "S2postxt"
			Dim s2postxt2 As Global.System.Windows.Forms.Control = Me.S2postxt
			size = New Global.System.Drawing.Size(75, 22)
			s2postxt2.Size = size
			Me.S2postxt.TabIndex = 2
			Me.S1postxt.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 9.75F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 161)
			Dim s1postxt As Global.System.Windows.Forms.Control = Me.S1postxt
			location = New Global.System.Drawing.Point(41, 41)
			s1postxt.Location = location
			Me.S1postxt.Name = "S1postxt"
			Dim s1postxt2 As Global.System.Windows.Forms.Control = Me.S1postxt
			size = New Global.System.Drawing.Size(75, 22)
			s1postxt2.Size = size
			Me.S1postxt.TabIndex = 1
			Me.GroupBox3.Controls.Add(Me.Usrfrmtxt)
			Dim groupBox5 As Global.System.Windows.Forms.Control = Me.GroupBox3
			location = New Global.System.Drawing.Point(260, 12)
			groupBox5.Location = location
			Me.GroupBox3.Name = "GroupBox3"
			Dim groupBox6 As Global.System.Windows.Forms.Control = Me.GroupBox3
			size = New Global.System.Drawing.Size(156, 98)
			groupBox6.Size = size
			Me.GroupBox3.TabIndex = 5
			Me.GroupBox3.TabStop = False
			Me.GroupBox3.Text = "User Frame"
			Me.Usrfrmtxt.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 9.75F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 161)
			Dim usrfrmtxt As Global.System.Windows.Forms.Control = Me.Usrfrmtxt
			location = New Global.System.Drawing.Point(41, 41)
			usrfrmtxt.Location = location
			Me.Usrfrmtxt.Name = "Usrfrmtxt"
			Dim usrfrmtxt2 As Global.System.Windows.Forms.Control = Me.Usrfrmtxt
			size = New Global.System.Drawing.Size(75, 22)
			usrfrmtxt2.Size = size
			Me.Usrfrmtxt.TabIndex = 1
			Me.Cnfrm_btn.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 11.25F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 162)
			Dim cnfrm_btn As Global.System.Windows.Forms.Control = Me.Cnfrm_btn
			location = New Global.System.Drawing.Point(466, 346)
			cnfrm_btn.Location = location
			Me.Cnfrm_btn.Name = "Cnfrm_btn"
			Dim cnfrm_btn2 As Global.System.Windows.Forms.Control = Me.Cnfrm_btn
			size = New Global.System.Drawing.Size(87, 27)
			cnfrm_btn2.Size = size
			Me.Cnfrm_btn.TabIndex = 4
			Me.Cnfrm_btn.Text = "Confirm"
			Me.Cnfrm_btn.UseVisualStyleBackColor = True
			Me.Cncl_btn.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 11.25F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 162)
			Dim cncl_btn As Global.System.Windows.Forms.Control = Me.Cncl_btn
			location = New Global.System.Drawing.Point(559, 346)
			cncl_btn.Location = location
			Me.Cncl_btn.Name = "Cncl_btn"
			Dim cncl_btn2 As Global.System.Windows.Forms.Control = Me.Cncl_btn
			size = New Global.System.Drawing.Size(87, 27)
			cncl_btn2.Size = size
			Me.Cncl_btn.TabIndex = 5
			Me.Cncl_btn.Text = "Cancel"
			Me.Cncl_btn.UseVisualStyleBackColor = True
			Me.Upload_btn.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 11.25F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 162)
			Dim upload_btn As Global.System.Windows.Forms.Control = Me.Upload_btn
			location = New Global.System.Drawing.Point(301, 346)
			upload_btn.Location = location
			Me.Upload_btn.Name = "Upload_btn"
			Dim upload_btn2 As Global.System.Windows.Forms.Control = Me.Upload_btn
			size = New Global.System.Drawing.Size(87, 27)
			upload_btn2.Size = size
			Me.Upload_btn.TabIndex = 3
			Me.Upload_btn.Text = "Upload"
			Me.Upload_btn.UseVisualStyleBackColor = True
			Dim autoScaleDimensions As Global.System.Drawing.SizeF = New Global.System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleDimensions = autoScaleDimensions
			Me.AutoScaleMode = Global.System.Windows.Forms.AutoScaleMode.Font
			size = New Global.System.Drawing.Size(678, 403)
			Me.ClientSize = size
			Me.Controls.Add(Me.Cncl_btn)
			Me.Controls.Add(Me.Cnfrm_btn)
			Me.Controls.Add(Me.GroupBox3)
			Me.Controls.Add(Me.GroupBox2)
			Me.Controls.Add(Me.GroupBox1)
			Me.Controls.Add(Me.Upload_btn)
			Me.Name = "Posıtıonupload"
			Me.Text = "Posıtıon Upload"
			Me.GroupBox1.ResumeLayout(False)
			Me.GroupBox1.PerformLayout()
			Me.GroupBox2.ResumeLayout(False)
			Me.GroupBox2.PerformLayout()
			Me.GroupBox3.ResumeLayout(False)
			Me.GroupBox3.PerformLayout()
			Me.ResumeLayout(False)
		End Sub

		' Token: 0x04000246 RID: 582
		Private components As Global.System.ComponentModel.IContainer
	End Class
End Namespace
