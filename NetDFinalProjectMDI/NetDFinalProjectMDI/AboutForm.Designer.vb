﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class aboutForm
	Inherits System.Windows.Forms.Form

	'Form overrides dispose to clean up the component list.
	<System.Diagnostics.DebuggerNonUserCode()> _
	Protected Overrides Sub Dispose(ByVal disposing As Boolean)
		Try
			If disposing AndAlso components IsNot Nothing Then
				components.Dispose()
			End If
		Finally
			MyBase.Dispose(disposing)
		End Try
	End Sub

	'Required by the Windows Form Designer
	Private components As System.ComponentModel.IContainer

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.  
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> _
	Private Sub InitializeComponent()
		Me.lblAbout = New System.Windows.Forms.Label()
		Me.SuspendLayout()
		'
		'lblAbout
		'
		Me.lblAbout.AutoSize = True
		Me.lblAbout.Location = New System.Drawing.Point(228, 110)
		Me.lblAbout.Margin = New System.Windows.Forms.Padding(10, 0, 10, 0)
		Me.lblAbout.Name = "lblAbout"
		Me.lblAbout.Size = New System.Drawing.Size(258, 185)
		Me.lblAbout.TabIndex = 0
		Me.lblAbout.Text = "NETD-2202-01" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Final Project" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Robin Hammond" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
		'
		'aboutForm
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(19.0!, 37.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(731, 431)
		Me.Controls.Add(Me.lblAbout)
		Me.Margin = New System.Windows.Forms.Padding(10, 9, 10, 9)
		Me.MaximumSize = New System.Drawing.Size(767, 534)
		Me.MinimumSize = New System.Drawing.Size(767, 534)
		Me.Name = "aboutForm"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
		Me.Text = "About"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents lblAbout As Label
End Class
