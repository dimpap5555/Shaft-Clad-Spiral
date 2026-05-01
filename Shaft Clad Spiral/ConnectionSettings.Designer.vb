Namespace WindowsApplication1
	' Token: 0x0200000C RID: 12
	<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
	Public Partial Class ConnectionSettings
		Inherits Global.System.Windows.Forms.Form

		' Token: 0x0600015D RID: 349 RVA: 0x00023D60 File Offset: 0x00022160
		<Global.System.Diagnostics.DebuggerNonUserCode()>
		Protected Overrides Sub Dispose(disposing As Boolean)
			If disposing AndAlso Me.components IsNot Nothing Then
				Me.components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		' Token: 0x0600015E RID: 350 RVA: 0x00023D80 File Offset: 0x00022180
		<Global.System.Diagnostics.DebuggerStepThrough()>
		Private Sub InitializeComponent()
			Me.Cnlbtn = New Global.System.Windows.Forms.Button()
			Me.Cnfrmbtn = New Global.System.Windows.Forms.Button()
			Me.GroupBox1 = New Global.System.Windows.Forms.GroupBox()
			Me.Ipaddrtxt = New Global.System.Windows.Forms.MaskedTextBox()
			Me.Browse = New Global.System.Windows.Forms.Button()
			Me.basedirtxt = New Global.System.Windows.Forms.TextBox()
			Me.FolderBrowserDialog1 = New Global.System.Windows.Forms.FolderBrowserDialog()
			Dim Lsrplab As Global.System.Windows.Forms.Label = New Global.System.Windows.Forms.Label()
			Dim Powdflab As Global.System.Windows.Forms.Label = New Global.System.Windows.Forms.Label()
			Me.GroupBox1.SuspendLayout()
			Me.SuspendLayout()
			Lsrplab.AutoSize = True
			Lsrplab.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 12F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 161)
			Dim control As Global.System.Windows.Forms.Control = Lsrplab
			Dim location As Global.System.Drawing.Point = New Global.System.Drawing.Point(29, 26)
			control.Location = location
			Dim control2 As Global.System.Windows.Forms.Control = Lsrplab
			Dim margin As Global.System.Windows.Forms.Padding = New Global.System.Windows.Forms.Padding(4, 0, 4, 0)
			control2.Margin = margin
			Lsrplab.Name = "Lsrplab"
			Dim control3 As Global.System.Windows.Forms.Control = Lsrplab
			Dim size As Global.System.Drawing.Size = New Global.System.Drawing.Size(127, 20)
			control3.Size = size
			Lsrplab.TabIndex = 9
			Lsrplab.Text = "Base Directory"
			Powdflab.AutoSize = True
			Powdflab.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 12F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 161)
			Dim control4 As Global.System.Windows.Forms.Control = Powdflab
			location = New Global.System.Drawing.Point(24, 72)
			control4.Location = location
			Dim control5 As Global.System.Windows.Forms.Control = Powdflab
			margin = New Global.System.Windows.Forms.Padding(4, 0, 4, 0)
			control5.Margin = margin
			Powdflab.Name = "Powdflab"
			Dim control6 As Global.System.Windows.Forms.Control = Powdflab
			size = New Global.System.Drawing.Size(172, 20)
			control6.Size = size
			Powdflab.TabIndex = 11
			Powdflab.Text = "IP Address of Robot"
			Me.Cnlbtn.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 11.25F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 161)
			Dim cnlbtn As Global.System.Windows.Forms.Control = Me.Cnlbtn
			location = New Global.System.Drawing.Point(422, 277)
			cnlbtn.Location = location
			Me.Cnlbtn.Name = "Cnlbtn"
			Dim cnlbtn2 As Global.System.Windows.Forms.Control = Me.Cnlbtn
			size = New Global.System.Drawing.Size(85, 26)
			cnlbtn2.Size = size
			Me.Cnlbtn.TabIndex = 27
			Me.Cnlbtn.Text = "Cancel"
			Me.Cnlbtn.TextAlign = Global.System.Drawing.ContentAlignment.TopCenter
			Me.Cnlbtn.UseVisualStyleBackColor = True
			Me.Cnfrmbtn.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 11.25F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 161)
			Dim cnfrmbtn As Global.System.Windows.Forms.Control = Me.Cnfrmbtn
			location = New Global.System.Drawing.Point(297, 277)
			cnfrmbtn.Location = location
			Me.Cnfrmbtn.Name = "Cnfrmbtn"
			Dim cnfrmbtn2 As Global.System.Windows.Forms.Control = Me.Cnfrmbtn
			size = New Global.System.Drawing.Size(85, 26)
			cnfrmbtn2.Size = size
			Me.Cnfrmbtn.TabIndex = 26
			Me.Cnfrmbtn.Text = "Confirm"
			Me.Cnfrmbtn.TextAlign = Global.System.Drawing.ContentAlignment.TopCenter
			Me.Cnfrmbtn.UseVisualStyleBackColor = True
			Me.GroupBox1.Controls.Add(Me.Ipaddrtxt)
			Me.GroupBox1.Controls.Add(Me.Browse)
			Me.GroupBox1.Controls.Add(Me.basedirtxt)
			Me.GroupBox1.Controls.Add(Lsrplab)
			Me.GroupBox1.Controls.Add(Powdflab)
			Me.GroupBox1.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 9.75F, Global.System.Drawing.FontStyle.Bold Or Global.System.Drawing.FontStyle.Italic, Global.System.Drawing.GraphicsUnit.Point, 161)
			Dim groupBox As Global.System.Windows.Forms.Control = Me.GroupBox1
			location = New Global.System.Drawing.Point(12, 12)
			groupBox.Location = location
			Me.GroupBox1.Name = "GroupBox1"
			Dim groupBox2 As Global.System.Windows.Forms.Control = Me.GroupBox1
			size = New Global.System.Drawing.Size(497, 249)
			groupBox2.Size = size
			Me.GroupBox1.TabIndex = 25
			Me.GroupBox1.TabStop = False
			Me.GroupBox1.Text = "Process Parameters"
			Me.Ipaddrtxt.AsciiOnly = True
			Me.Ipaddrtxt.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 9.75F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 161)
			Dim ipaddrtxt As Global.System.Windows.Forms.Control = Me.Ipaddrtxt
			location = New Global.System.Drawing.Point(203, 72)
			ipaddrtxt.Location = location
			Me.Ipaddrtxt.Mask = "000.000.000.000"
			Me.Ipaddrtxt.Name = "Ipaddrtxt"
			Dim ipaddrtxt2 As Global.System.Windows.Forms.Control = Me.Ipaddrtxt
			size = New Global.System.Drawing.Size(119, 22)
			ipaddrtxt2.Size = size
			Me.Ipaddrtxt.TabIndex = 28
			Me.Ipaddrtxt.Text = "192168002002"
			Me.Browse.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 11.25F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 161)
			Dim browse As Global.System.Windows.Forms.Control = Me.Browse
			location = New Global.System.Drawing.Point(401, 24)
			browse.Location = location
			Me.Browse.Name = "Browse"
			Dim browse2 As Global.System.Windows.Forms.Control = Me.Browse
			size = New Global.System.Drawing.Size(85, 26)
			browse2.Size = size
			Me.Browse.TabIndex = 27
			Me.Browse.Text = "Browse"
			Me.Browse.TextAlign = Global.System.Drawing.ContentAlignment.TopCenter
			Me.Browse.UseVisualStyleBackColor = True
			Me.basedirtxt.Font = New Global.System.Drawing.Font("Arial", 12F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 161)
			Dim basedirtxt As Global.System.Windows.Forms.Control = Me.basedirtxt
			location = New Global.System.Drawing.Point(170, 24)
			basedirtxt.Location = location
			Dim basedirtxt2 As Global.System.Windows.Forms.Control = Me.basedirtxt
			margin = New Global.System.Windows.Forms.Padding(4, 5, 4, 5)
			basedirtxt2.Margin = margin
			Me.basedirtxt.Name = "basedirtxt"
			Dim basedirtxt3 As Global.System.Windows.Forms.Control = Me.basedirtxt
			size = New Global.System.Drawing.Size(224, 26)
			basedirtxt3.Size = size
			Me.basedirtxt.TabIndex = 8
			Me.FolderBrowserDialog1.SelectedPath = "Y:\Documentation_Laser\Laser_Programs\Robot Programs\2008 01 18"
			Dim autoScaleDimensions As Global.System.Drawing.SizeF = New Global.System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleDimensions = autoScaleDimensions
			Me.AutoScaleMode = Global.System.Windows.Forms.AutoScaleMode.Font
			size = New Global.System.Drawing.Size(521, 315)
			Me.ClientSize = size
			Me.Controls.Add(Me.Cnlbtn)
			Me.Controls.Add(Me.Cnfrmbtn)
			Me.Controls.Add(Me.GroupBox1)
			Me.FormBorderStyle = Global.System.Windows.Forms.FormBorderStyle.FixedDialog
			Me.MaximizeBox = False
			Me.MinimizeBox = False
			Me.Name = "ConnectionSettings"
			Me.ShowInTaskbar = False
			Me.StartPosition = Global.System.Windows.Forms.FormStartPosition.CenterParent
			Me.Text = "Connection Settings"
			Me.GroupBox1.ResumeLayout(False)
			Me.GroupBox1.PerformLayout()
			Me.ResumeLayout(False)
		End Sub

		' Token: 0x04000083 RID: 131
		Private components As Global.System.ComponentModel.IContainer
	End Class
End Namespace
