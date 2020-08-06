<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ParentForm
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
		Me.components = New System.ComponentModel.Container()
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ParentForm))
		Me.menuStrip = New System.Windows.Forms.MenuStrip()
		Me.mnuFile = New System.Windows.Forms.ToolStripMenuItem()
		Me.mnuNew = New System.Windows.Forms.ToolStripMenuItem()
		Me.mnuOpen = New System.Windows.Forms.ToolStripMenuItem()
		Me.mnuSave = New System.Windows.Forms.ToolStripMenuItem()
		Me.mnuSaveAs = New System.Windows.Forms.ToolStripMenuItem()
		Me.mnuClose = New System.Windows.Forms.ToolStripMenuItem()
		Me.mnuExit = New System.Windows.Forms.ToolStripMenuItem()
		Me.mnuEdit = New System.Windows.Forms.ToolStripMenuItem()
		Me.mnuCut = New System.Windows.Forms.ToolStripMenuItem()
		Me.mnuCopy = New System.Windows.Forms.ToolStripMenuItem()
		Me.mnuPaste = New System.Windows.Forms.ToolStripMenuItem()
		Me.mnuWindows = New System.Windows.Forms.ToolStripMenuItem()
		Me.mnuCascade = New System.Windows.Forms.ToolStripMenuItem()
		Me.mnuTileVertical = New System.Windows.Forms.ToolStripMenuItem()
		Me.mnuTileHorizontal = New System.Windows.Forms.ToolStripMenuItem()
		Me.mnuHelp = New System.Windows.Forms.ToolStripMenuItem()
		Me.mnuAbout = New System.Windows.Forms.ToolStripMenuItem()
		Me.staStrip = New System.Windows.Forms.StatusStrip()
		Me.lblStatus = New System.Windows.Forms.ToolStripStatusLabel()
		Me.openDialog = New System.Windows.Forms.OpenFileDialog()
		Me.saveDialog = New System.Windows.Forms.SaveFileDialog()
		Me.ttpHelp = New System.Windows.Forms.ToolTip(Me.components)
		Me.tlStrip = New System.Windows.Forms.ToolStrip()
		Me.tsbNewFile = New System.Windows.Forms.ToolStripButton()
		Me.tsbOpenFile = New System.Windows.Forms.ToolStripButton()
		Me.tsbSaveFile = New System.Windows.Forms.ToolStripButton()
		Me.menuStrip.SuspendLayout()
		Me.staStrip.SuspendLayout()
		Me.tlStrip.SuspendLayout()
		Me.SuspendLayout()
		'
		'menuStrip
		'
		Me.menuStrip.ImageScalingSize = New System.Drawing.Size(48, 48)
		Me.menuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFile, Me.mnuEdit, Me.mnuWindows, Me.mnuHelp})
		Me.menuStrip.Location = New System.Drawing.Point(0, 0)
		Me.menuStrip.Name = "menuStrip"
		Me.menuStrip.Padding = New System.Windows.Forms.Padding(19, 6, 0, 6)
		Me.menuStrip.Size = New System.Drawing.Size(2006, 64)
		Me.menuStrip.TabIndex = 0
		Me.menuStrip.Text = "MenuStrip1"
		'
		'mnuFile
		'
		Me.mnuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuNew, Me.mnuOpen, Me.mnuSave, Me.mnuSaveAs, Me.mnuClose, Me.mnuExit})
		Me.mnuFile.Name = "mnuFile"
		Me.mnuFile.Size = New System.Drawing.Size(103, 52)
		Me.mnuFile.Text = "&File"
		Me.mnuFile.ToolTipText = "Allows you to Open, Save, Create new files and, exit the application"
		'
		'mnuNew
		'
		Me.mnuNew.Name = "mnuNew"
		Me.mnuNew.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
		Me.mnuNew.Size = New System.Drawing.Size(555, 66)
		Me.mnuNew.Text = "&New"
		Me.mnuNew.ToolTipText = "Creates a new text file"
		'
		'mnuOpen
		'
		Me.mnuOpen.Name = "mnuOpen"
		Me.mnuOpen.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
		Me.mnuOpen.Size = New System.Drawing.Size(555, 66)
		Me.mnuOpen.Text = "&Open"
		Me.mnuOpen.ToolTipText = "Allows you to open an existing text file"
		'
		'mnuSave
		'
		Me.mnuSave.Name = "mnuSave"
		Me.mnuSave.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
		Me.mnuSave.Size = New System.Drawing.Size(555, 66)
		Me.mnuSave.Text = "&Save"
		Me.mnuSave.ToolTipText = "Allows you to Save the text file"
		'
		'mnuSaveAs
		'
		Me.mnuSaveAs.Name = "mnuSaveAs"
		Me.mnuSaveAs.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
			Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
		Me.mnuSaveAs.Size = New System.Drawing.Size(555, 66)
		Me.mnuSaveAs.Text = "Save &As"
		Me.mnuSaveAs.ToolTipText = "Allows you to save a new copy of the files with a new name"
		'
		'mnuClose
		'
		Me.mnuClose.Name = "mnuClose"
		Me.mnuClose.Size = New System.Drawing.Size(555, 66)
		Me.mnuClose.Text = "&Close"
		Me.mnuClose.ToolTipText = "Closes the currently selected Document"
		'
		'mnuExit
		'
		Me.mnuExit.Name = "mnuExit"
		Me.mnuExit.Size = New System.Drawing.Size(555, 66)
		Me.mnuExit.Text = "E&xit"
		Me.mnuExit.ToolTipText = "Exits the application"
		'
		'mnuEdit
		'
		Me.mnuEdit.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuCut, Me.mnuCopy, Me.mnuPaste})
		Me.mnuEdit.Name = "mnuEdit"
		Me.mnuEdit.Size = New System.Drawing.Size(108, 52)
		Me.mnuEdit.Text = "&Edit"
		Me.mnuEdit.ToolTipText = "This menu is for options to edit files"
		'
		'mnuCut
		'
		Me.mnuCut.Name = "mnuCut"
		Me.mnuCut.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
		Me.mnuCut.Size = New System.Drawing.Size(424, 66)
		Me.mnuCut.Text = "Cu&t"
		Me.mnuCut.ToolTipText = "Deletes/Cuts the highlighted text"
		'
		'mnuCopy
		'
		Me.mnuCopy.Name = "mnuCopy"
		Me.mnuCopy.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
		Me.mnuCopy.Size = New System.Drawing.Size(424, 66)
		Me.mnuCopy.Text = "&Copy"
		Me.mnuCopy.ToolTipText = "Copies the highlighted text"
		'
		'mnuPaste
		'
		Me.mnuPaste.Name = "mnuPaste"
		Me.mnuPaste.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.V), System.Windows.Forms.Keys)
		Me.mnuPaste.Size = New System.Drawing.Size(424, 66)
		Me.mnuPaste.Text = "&Paste"
		Me.mnuPaste.ToolTipText = "Pastes the data currently in the clipboard"
		'
		'mnuWindows
		'
		Me.mnuWindows.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuCascade, Me.mnuTileVertical, Me.mnuTileHorizontal})
		Me.mnuWindows.Name = "mnuWindows"
		Me.mnuWindows.Size = New System.Drawing.Size(194, 52)
		Me.mnuWindows.Text = "&Windows"
		'
		'mnuCascade
		'
		Me.mnuCascade.Name = "mnuCascade"
		Me.mnuCascade.Size = New System.Drawing.Size(449, 66)
		Me.mnuCascade.Text = "&Cascade"
		Me.mnuCascade.ToolTipText = "Cascades the open windows"
		'
		'mnuTileVertical
		'
		Me.mnuTileVertical.Name = "mnuTileVertical"
		Me.mnuTileVertical.Size = New System.Drawing.Size(449, 66)
		Me.mnuTileVertical.Text = "Tile &Vertical"
		Me.mnuTileVertical.ToolTipText = "Vertically tiles the open  files"
		'
		'mnuTileHorizontal
		'
		Me.mnuTileHorizontal.Name = "mnuTileHorizontal"
		Me.mnuTileHorizontal.Size = New System.Drawing.Size(449, 66)
		Me.mnuTileHorizontal.Text = "Tile &Horizontal"
		Me.mnuTileHorizontal.ToolTipText = "Horizontally tiles the open files"
		'
		'mnuHelp
		'
		Me.mnuHelp.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuAbout})
		Me.mnuHelp.Name = "mnuHelp"
		Me.mnuHelp.Size = New System.Drawing.Size(123, 52)
		Me.mnuHelp.Text = "&Help"
		Me.mnuHelp.ToolTipText = "This section is about the software and the author of it"
		'
		'mnuAbout
		'
		Me.mnuAbout.Name = "mnuAbout"
		Me.mnuAbout.Size = New System.Drawing.Size(315, 66)
		Me.mnuAbout.Text = "&About"
		Me.mnuAbout.ToolTipText = "This section is about the software and the author of it"
		'
		'staStrip
		'
		Me.staStrip.ImageScalingSize = New System.Drawing.Size(48, 48)
		Me.staStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblStatus})
		Me.staStrip.Location = New System.Drawing.Point(0, 1063)
		Me.staStrip.Name = "staStrip"
		Me.staStrip.Padding = New System.Windows.Forms.Padding(3, 0, 44, 0)
		Me.staStrip.Size = New System.Drawing.Size(2006, 63)
		Me.staStrip.TabIndex = 1
		Me.staStrip.Text = "Welcome!"
		'
		'lblStatus
		'
		Me.lblStatus.Name = "lblStatus"
		Me.lblStatus.Size = New System.Drawing.Size(179, 48)
		Me.lblStatus.Text = "Welcome!"
		Me.lblStatus.ToolTipText = "Displays application related messages"
		'
		'openDialog
		'
		Me.openDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*"
		'
		'saveDialog
		'
		Me.saveDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*"
		'
		'tlStrip
		'
		Me.tlStrip.ImageScalingSize = New System.Drawing.Size(48, 48)
		Me.tlStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbNewFile, Me.tsbOpenFile, Me.tsbSaveFile})
		Me.tlStrip.Location = New System.Drawing.Point(0, 64)
		Me.tlStrip.Name = "tlStrip"
		Me.tlStrip.Padding = New System.Windows.Forms.Padding(0, 0, 10, 0)
		Me.tlStrip.Size = New System.Drawing.Size(2006, 29)
		Me.tlStrip.TabIndex = 2
		Me.tlStrip.Text = "ToolStrip1"
		'
		'tsbNewFile
		'
		Me.tsbNewFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
		Me.tsbNewFile.Image = CType(resources.GetObject("tsbNewFile.Image"), System.Drawing.Image)
		Me.tsbNewFile.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
		Me.tsbNewFile.ImageTransparentColor = System.Drawing.Color.Magenta
		Me.tsbNewFile.Name = "tsbNewFile"
		Me.tsbNewFile.Size = New System.Drawing.Size(69, 20)
		Me.tsbNewFile.Text = "New File"
		'
		'tsbOpenFile
		'
		Me.tsbOpenFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
		Me.tsbOpenFile.Image = CType(resources.GetObject("tsbOpenFile.Image"), System.Drawing.Image)
		Me.tsbOpenFile.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
		Me.tsbOpenFile.ImageTransparentColor = System.Drawing.Color.Magenta
		Me.tsbOpenFile.Name = "tsbOpenFile"
		Me.tsbOpenFile.Size = New System.Drawing.Size(69, 20)
		Me.tsbOpenFile.Text = "Open File"
		'
		'tsbSaveFile
		'
		Me.tsbSaveFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
		Me.tsbSaveFile.Image = CType(resources.GetObject("tsbSaveFile.Image"), System.Drawing.Image)
		Me.tsbSaveFile.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
		Me.tsbSaveFile.ImageTransparentColor = System.Drawing.Color.Magenta
		Me.tsbSaveFile.Name = "tsbSaveFile"
		Me.tsbSaveFile.Size = New System.Drawing.Size(69, 20)
		Me.tsbSaveFile.Text = "Save File"
		'
		'ParentForm
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(19.0!, 37.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(2006, 1126)
		Me.Controls.Add(Me.tlStrip)
		Me.Controls.Add(Me.staStrip)
		Me.Controls.Add(Me.menuStrip)
		Me.IsMdiContainer = True
		Me.MainMenuStrip = Me.menuStrip
		Me.Margin = New System.Windows.Forms.Padding(10, 9, 10, 9)
		Me.MinimumSize = New System.Drawing.Size(2042, 1229)
		Me.Name = "ParentForm"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Multi-Document Text Editor 2.0"
		Me.menuStrip.ResumeLayout(False)
		Me.menuStrip.PerformLayout()
		Me.staStrip.ResumeLayout(False)
		Me.staStrip.PerformLayout()
		Me.tlStrip.ResumeLayout(False)
		Me.tlStrip.PerformLayout()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents menuStrip As MenuStrip
	Friend WithEvents mnuFile As ToolStripMenuItem
	Friend WithEvents mnuNew As ToolStripMenuItem
	Friend WithEvents mnuOpen As ToolStripMenuItem
	Friend WithEvents mnuSave As ToolStripMenuItem
	Friend WithEvents mnuSaveAs As ToolStripMenuItem
	Friend WithEvents mnuClose As ToolStripMenuItem
	Friend WithEvents mnuExit As ToolStripMenuItem
	Friend WithEvents mnuEdit As ToolStripMenuItem
	Friend WithEvents mnuCut As ToolStripMenuItem
	Friend WithEvents mnuCopy As ToolStripMenuItem
	Friend WithEvents mnuPaste As ToolStripMenuItem
	Friend WithEvents mnuWindows As ToolStripMenuItem
	Friend WithEvents mnuCascade As ToolStripMenuItem
	Friend WithEvents mnuTileVertical As ToolStripMenuItem
	Friend WithEvents mnuTileHorizontal As ToolStripMenuItem
	Friend WithEvents mnuHelp As ToolStripMenuItem
	Friend WithEvents mnuAbout As ToolStripMenuItem
	Friend WithEvents staStrip As StatusStrip
	Friend WithEvents openDialog As OpenFileDialog
	Friend WithEvents saveDialog As SaveFileDialog
	Friend WithEvents ttpHelp As ToolTip
	Friend WithEvents tlStrip As ToolStrip
	Friend WithEvents lblStatus As ToolStripStatusLabel
	Friend WithEvents tsbNewFile As ToolStripButton
	Friend WithEvents tsbOpenFile As ToolStripButton
	Friend WithEvents tsbSaveFile As ToolStripButton

End Class
