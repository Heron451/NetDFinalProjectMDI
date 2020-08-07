
'-----------------------------------------------------------------
'Author: Robin Hammond
'Student Number: 100773359
'Date: August 4, 2020.
'Last Modified: July 29, 2020.
'Course: NETD-2202-01 Net Development I
'Assignment: Final Project
'File Name: ParentForm.vb
'Description: In this lab we created a Multi-Document text editing application 
'from scratch. We created a form where users can create new files,
'open existing files and save existing or new files. We also created
'editing utilities for copy, cut and paste in the application.
'An about button was also created which displays a form with information
'about the creator of the application.
'-----------------------------------------------------------------

Option Strict On
Imports System.IO

Public Class ParentForm
	'This Region contains all of our globally declared variables
#Region "Variables"
	Dim docLocation As String = String.Empty 'This is a variable to hold the file location
	Dim docName As String  'This holds the document name
	Dim txtEdit As String = "Multi-Document Text Editor 2.0 - " 'This variable holds the name of the application for the title bar
#End Region
	'This Region contains all the event handlers that manage the buttons in our menu and our menu strip
#Region "Event Handlers"
	' NEW - This New event handler that handles the new file button in the menu and menu strip
	Private Sub mnuNewClick(sender As Object, e As EventArgs) Handles mnuNew.Click, tsbNewFile.Click
		NewFile()
		docLocation = String.Empty
		lblStatus.Text = "New File Started"
		Me.ActiveMdiChild.Text = "Untitled"
	End Sub
	' OPEN - This Open event handler that handles the open file button in the menu and menu strip
	Private Sub mnuOpenClick(sender As Object, e As EventArgs) Handles mnuOpen.Click, tsbOpenFile.Click
		Dim fileReader As String

		If openDialog.ShowDialog() = DialogResult.OK Then
			NewFile()
			docName = openDialog.SafeFileName
			docLocation = openDialog.FileName
			fileReader = My.Computer.FileSystem.ReadAllText(docLocation)
			Me.ActiveMdiChild.Text = docName
			Me.ActiveMdiChild.ActiveControl.Text = fileReader
			lblStatus.Text = docName + " has been opened"
		End If
	End Sub
	' SAVE  - This Save event handler that handles the Save file button in the menu and menu strip
	Private Sub mnuSaveClick(sender As Object, e As EventArgs) Handles mnuSave.Click, tsbSaveFile.Click
		saveDialog.Filter = "Txt Files| *.txt | All Files| *.*"

		If docLocation = String.Empty Then
			'If the docLocation variable is empty then we need to open the save file dialog so the user can save the new file
			If saveDialog.ShowDialog() = DialogResult.OK Then
				docLocation = saveDialog.FileName
				FileSaved(docLocation)
				lblStatus.Text = "File Saved Successfully - " + docName
			End If
		Else
			'If the docLocation is not empty and has a file path in it then we save the file to that existing file using the file path.
			FileSaved(docLocation)
			lblStatus.Text = "File Saved Successfully - " + docName
		End If
	End Sub
	' SAVE AS - This Save As event handler that handles the Save As button in the menu
	Private Sub mnuSaveAsClick(sender As Object, e As EventArgs) Handles mnuSaveAs.Click
		Dim saveDialog As New SaveFileDialog
		Dim saveStream As StreamWriter
		Dim activeChild As ChildForm = DirectCast(Me.ActiveMdiChild, ChildForm)

		saveDialog.Filter = "Txt Files| *.txt | All Files| *.*"

		If saveDialog.ShowDialog() = DialogResult.OK Then
			saveStream = New StreamWriter(saveDialog.FileName)
			saveStream.Write(activeChild.txtDisplay.Text)
			saveStream.Close()

			lblStatus.Text = "File Saved Successfully - " & openDialog.FileName
		End If
	End Sub
	' CLOSE - This Close event handler that handles the close file button in the menu. This closes the current active document.
	Private Sub mnuCloseClick(sender As Object, e As EventArgs) Handles mnuClose.Click
		Me.ActiveMdiChild.Close()
	End Sub
	' EXIT  - This Exit event handler that handles the Exit button in the menu. This closes the whole application.
	Private Sub mnuExitClick(sender As Object, e As EventArgs) Handles mnuExit.Click
		Application.Exit()
	End Sub
	' CUT - This Cut event handler that handles the Cut button in the menu
	Private Sub mnuCutClick(sender As Object, e As EventArgs) Handles mnuCut.Click
		If Not Me.ActiveMdiChild Is Nothing Then
			DirectCast(Me.ActiveMdiChild.ActiveControl, TextBox).Cut()
			lblStatus.Text = "Cut"
		End If
	End Sub
	' COPY - This Copy event handler that handles the Copy button in the menu
	Private Sub mnuCopyClick(sender As Object, e As EventArgs) Handles mnuCopy.Click
		If Not Me.ActiveMdiChild Is Nothing Then
			DirectCast(Me.ActiveMdiChild.ActiveControl, TextBox).Copy()
			lblStatus.Text = "Copied"
		End If
	End Sub
	' PASTE - This Paste event handler that handles the Paste file button in the menu
	Private Sub mnuPasteClick(sender As Object, e As EventArgs) Handles mnuPaste.Click
		If Not Me.ActiveMdiChild Is Nothing Then
			DirectCast(Me.ActiveMdiChild.ActiveControl, TextBox).Paste()
			lblStatus.Text = "Pasted"
		End If
	End Sub
	' CASCADE  - This Cascade event handler that handles the Cascade file button in the menu. This will cascade the currently open document windows.
	Private Sub mnuCascadeClick(sender As Object, e As EventArgs) Handles mnuCascade.Click
		Me.LayoutMdi(MdiLayout.Cascade)
		lblStatus.Text = "Open file windows have been cascaded"
	End Sub
	' TILE VERTICAL  - This Tile Vertical event handler that handles the Tile Vertical button in the menu. This will vertically tile the currently open document windows.
	Private Sub mnuTileVerticalClick(sender As Object, e As EventArgs) Handles mnuTileVertical.Click
		Me.LayoutMdi(MdiLayout.TileVertical)
		lblStatus.Text = "Open file windows have been tiled vertically"
	End Sub
	' TILE HORIZTONAL  - This Tile Horizontal event handler that handles the Tile Horizontal button in the menu. This will horizontally tile the currently open document windows.
	Private Sub mnuTileHorizontalClick(sender As Object, e As EventArgs) Handles mnuTileHorizontal.Click
		Me.LayoutMdi(MdiLayout.TileHorizontal)
		lblStatus.Text = "Open file windows have been tiled horizontally"
	End Sub
	' ABOUT - This event handler handles the about button in the menu. This will open the About Form.
	Private Sub mnuAboutClick(sender As Object, e As EventArgs) Handles mnuAbout.Click
		Dim aboutModal As New aboutForm
		aboutModal.ShowDialog()
	End Sub
	'This event handler makes sure our document location variable is always set to the path of the currently active form. This makes Saving files a bit easier.
	Private Sub ParentFormChildActivate(sender As Object, e As EventArgs) Handles MyBase.MdiChildActivate
		If Not Me.ActiveMdiChild Is Nothing Then
			docLocation = Me.ActiveMdiChild.Text
		End If
	End Sub

#End Region
	' This Region holds all of our functions and Sub Procedures
#Region "Functions and Sub Procedures"
	'This Function handles saving files
	Public Sub FileSaved(ByVal file As String)
		Dim outputStream As StreamWriter
		outputStream = New StreamWriter(file)
		docName = Path.GetFileName(file)
		outputStream.Write(Me.ActiveMdiChild.ActiveControl.Text)
		outputStream.Close()
		Me.ActiveMdiChild.Text = docName + " - " + file
	End Sub
	'This Function handles the creation of a new instance of the Child Form to create a new file
	Public Sub NewFile()
		Dim newDocument As New ChildForm
		newDocument.MdiParent = Me
		newDocument.Show()
	End Sub

#End Region

End Class