<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ChildForm
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
		Me.txtDisplay = New System.Windows.Forms.TextBox()
		Me.SuspendLayout()
		'
		'txtDisplay
		'
		Me.txtDisplay.Dock = System.Windows.Forms.DockStyle.Fill
		Me.txtDisplay.Location = New System.Drawing.Point(0, 0)
		Me.txtDisplay.Margin = New System.Windows.Forms.Padding(10, 9, 10, 9)
		Me.txtDisplay.Multiline = True
		Me.txtDisplay.Name = "txtDisplay"
		Me.txtDisplay.ScrollBars = System.Windows.Forms.ScrollBars.Both
		Me.txtDisplay.Size = New System.Drawing.Size(1096, 471)
		Me.txtDisplay.TabIndex = 0
		'
		'ChildForm
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(19.0!, 37.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(1096, 471)
		Me.Controls.Add(Me.txtDisplay)
		Me.Margin = New System.Windows.Forms.Padding(10, 9, 10, 9)
		Me.Name = "ChildForm"
		Me.Text = "Child Form"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents txtDisplay As TextBox
End Class
