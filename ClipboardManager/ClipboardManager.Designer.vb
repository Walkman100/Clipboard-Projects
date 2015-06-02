﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ClipboardManager
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ClipboardManager))
        Me.lstLog = New System.Windows.Forms.ListBox()
        Me.lblRecent = New System.Windows.Forms.Label()
        Me.btnCopy = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.chkAutoSort = New System.Windows.Forms.CheckBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnMoveUp = New System.Windows.Forms.Button()
        Me.btnMoveDown = New System.Windows.Forms.Button()
        Me.btnEnd = New System.Windows.Forms.Button()
        Me.TimerClipboardChecker = New System.Windows.Forms.Timer(Me.components)
        Me.btnHide = New System.Windows.Forms.Button()
        Me.NotifyIcon = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.grpAddTo = New System.Windows.Forms.GroupBox()
        Me.optAddToEnd = New System.Windows.Forms.RadioButton()
        Me.optAddToStart = New System.Windows.Forms.RadioButton()
        Me.grpMaxEntries = New System.Windows.Forms.GroupBox()
        Me.txtMaxEntries = New System.Windows.Forms.NumericUpDown()
        Me.chkMaxEntries = New System.Windows.Forms.CheckBox()
        Me.grpAddTo.SuspendLayout
        Me.grpMaxEntries.SuspendLayout
        CType(Me.txtMaxEntries,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'lstLog
        '
        Me.lstLog.AllowDrop = true
        Me.lstLog.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.lstLog.FormattingEnabled = true
        Me.lstLog.HorizontalScrollbar = true
        Me.lstLog.IntegralHeight = false
        Me.lstLog.Location = New System.Drawing.Point(12, 25)
        Me.lstLog.Name = "lstLog"
        Me.lstLog.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.lstLog.Size = New System.Drawing.Size(296, 359)
        Me.lstLog.TabIndex = 0
        '
        'lblRecent
        '
        Me.lblRecent.AutoSize = true
        Me.lblRecent.Location = New System.Drawing.Point(12, 9)
        Me.lblRecent.Name = "lblRecent"
        Me.lblRecent.Size = New System.Drawing.Size(120, 13)
        Me.lblRecent.TabIndex = 1
        Me.lblRecent.Text = "Recent Clipboard Items:"
        '
        'btnCopy
        '
        Me.btnCopy.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.btnCopy.Enabled = false
        Me.btnCopy.Location = New System.Drawing.Point(314, 12)
        Me.btnCopy.Name = "btnCopy"
        Me.btnCopy.Size = New System.Drawing.Size(100, 23)
        Me.btnCopy.TabIndex = 2
        Me.btnCopy.Text = "Copy Item"
        Me.btnCopy.UseVisualStyleBackColor = true
        '
        'btnDelete
        '
        Me.btnDelete.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.btnDelete.Enabled = false
        Me.btnDelete.Location = New System.Drawing.Point(314, 41)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(100, 23)
        Me.btnDelete.TabIndex = 3
        Me.btnDelete.Text = "Delete Item"
        Me.btnDelete.UseVisualStyleBackColor = true
        '
        'btnEdit
        '
        Me.btnEdit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.btnEdit.Enabled = false
        Me.btnEdit.Location = New System.Drawing.Point(314, 70)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(100, 23)
        Me.btnEdit.TabIndex = 4
        Me.btnEdit.Text = "Edit Item..."
        Me.btnEdit.UseVisualStyleBackColor = true
        '
        'chkAutoSort
        '
        Me.chkAutoSort.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.chkAutoSort.AutoSize = true
        Me.chkAutoSort.Location = New System.Drawing.Point(320, 157)
        Me.chkAutoSort.Name = "chkAutoSort"
        Me.chkAutoSort.Size = New System.Drawing.Size(70, 17)
        Me.chkAutoSort.TabIndex = 5
        Me.chkAutoSort.Text = "Auto-Sort"
        Me.chkAutoSort.UseVisualStyleBackColor = true
        '
        'btnClear
        '
        Me.btnClear.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.btnClear.Location = New System.Drawing.Point(314, 332)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(100, 23)
        Me.btnClear.TabIndex = 9
        Me.btnClear.Text = "Clear List"
        Me.btnClear.UseVisualStyleBackColor = true
        '
        'btnMoveUp
        '
        Me.btnMoveUp.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.btnMoveUp.Enabled = false
        Me.btnMoveUp.Location = New System.Drawing.Point(314, 99)
        Me.btnMoveUp.Name = "btnMoveUp"
        Me.btnMoveUp.Size = New System.Drawing.Size(100, 23)
        Me.btnMoveUp.TabIndex = 6
        Me.btnMoveUp.Text = "Move Item Up"
        Me.btnMoveUp.UseVisualStyleBackColor = true
        '
        'btnMoveDown
        '
        Me.btnMoveDown.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.btnMoveDown.Enabled = false
        Me.btnMoveDown.Location = New System.Drawing.Point(314, 128)
        Me.btnMoveDown.Name = "btnMoveDown"
        Me.btnMoveDown.Size = New System.Drawing.Size(100, 23)
        Me.btnMoveDown.TabIndex = 7
        Me.btnMoveDown.Text = "Move Item Down"
        Me.btnMoveDown.UseVisualStyleBackColor = true
        '
        'btnEnd
        '
        Me.btnEnd.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.btnEnd.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnEnd.Location = New System.Drawing.Point(314, 361)
        Me.btnEnd.Name = "btnEnd"
        Me.btnEnd.Size = New System.Drawing.Size(100, 23)
        Me.btnEnd.TabIndex = 10
        Me.btnEnd.Text = "Close"
        Me.btnEnd.UseVisualStyleBackColor = true
        '
        'TimerClipboardChecker
        '
        Me.TimerClipboardChecker.Interval = 500
        '
        'btnHide
        '
        Me.btnHide.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.btnHide.Location = New System.Drawing.Point(314, 303)
        Me.btnHide.Name = "btnHide"
        Me.btnHide.Size = New System.Drawing.Size(100, 23)
        Me.btnHide.TabIndex = 8
        Me.btnHide.Text = "Hide"
        Me.btnHide.UseVisualStyleBackColor = true
        '
        'NotifyIcon
        '
        Me.NotifyIcon.Icon = CType(resources.GetObject("NotifyIcon.Icon"),System.Drawing.Icon)
        Me.NotifyIcon.Text = "Clipboard Manager"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"(Click to open)"
        '
        'grpAddTo
        '
        Me.grpAddTo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.grpAddTo.Controls.Add(Me.optAddToEnd)
        Me.grpAddTo.Controls.Add(Me.optAddToStart)
        Me.grpAddTo.Location = New System.Drawing.Point(314, 180)
        Me.grpAddTo.Name = "grpAddTo"
        Me.grpAddTo.Size = New System.Drawing.Size(105, 65)
        Me.grpAddTo.TabIndex = 11
        Me.grpAddTo.TabStop = false
        Me.grpAddTo.Text = "Add new items to:"
        '
        'optAddToEnd
        '
        Me.optAddToEnd.AutoSize = true
        Me.optAddToEnd.Location = New System.Drawing.Point(6, 42)
        Me.optAddToEnd.Name = "optAddToEnd"
        Me.optAddToEnd.Size = New System.Drawing.Size(71, 17)
        Me.optAddToEnd.TabIndex = 1
        Me.optAddToEnd.Text = "End of list"
        Me.optAddToEnd.UseVisualStyleBackColor = true
        '
        'optAddToStart
        '
        Me.optAddToStart.AutoSize = true
        Me.optAddToStart.Checked = true
        Me.optAddToStart.Location = New System.Drawing.Point(6, 19)
        Me.optAddToStart.Name = "optAddToStart"
        Me.optAddToStart.Size = New System.Drawing.Size(74, 17)
        Me.optAddToStart.TabIndex = 0
        Me.optAddToStart.TabStop = true
        Me.optAddToStart.Text = "Start of list"
        Me.optAddToStart.UseVisualStyleBackColor = true
        '
        'grpMaxEntries
        '
        Me.grpMaxEntries.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.grpMaxEntries.Controls.Add(Me.txtMaxEntries)
        Me.grpMaxEntries.Enabled = false
        Me.grpMaxEntries.Location = New System.Drawing.Point(314, 251)
        Me.grpMaxEntries.Name = "grpMaxEntries"
        Me.grpMaxEntries.Size = New System.Drawing.Size(105, 46)
        Me.grpMaxEntries.TabIndex = 12
        Me.grpMaxEntries.TabStop = false
        '
        'txtMaxEntries
        '
        Me.txtMaxEntries.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
                        Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.txtMaxEntries.Location = New System.Drawing.Point(6, 19)
        Me.txtMaxEntries.Name = "txtMaxEntries"
        Me.txtMaxEntries.Size = New System.Drawing.Size(93, 20)
        Me.txtMaxEntries.TabIndex = 0
        Me.txtMaxEntries.Value = New Decimal(New Integer() {27, 0, 0, 0})
        '
        'chkMaxEntries
        '
        Me.chkMaxEntries.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.chkMaxEntries.AutoSize = true
        Me.chkMaxEntries.Location = New System.Drawing.Point(318, 250)
        Me.chkMaxEntries.Name = "chkMaxEntries"
        Me.chkMaxEntries.Size = New System.Drawing.Size(84, 17)
        Me.chkMaxEntries.TabIndex = 13
        Me.chkMaxEntries.Text = "Max Entries:"
        Me.chkMaxEntries.UseVisualStyleBackColor = true
        '
        'ClipboardManager
        '
        Me.AcceptButton = Me.btnCopy
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnEnd
        Me.ClientSize = New System.Drawing.Size(426, 396)
        Me.Controls.Add(Me.btnHide)
        Me.Controls.Add(Me.btnEnd)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.chkMaxEntries)
        Me.Controls.Add(Me.grpMaxEntries)
        Me.Controls.Add(Me.grpAddTo)
        Me.Controls.Add(Me.btnMoveDown)
        Me.Controls.Add(Me.btnMoveUp)
        Me.Controls.Add(Me.chkAutoSort)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnCopy)
        Me.Controls.Add(Me.lblRecent)
        Me.Controls.Add(Me.lstLog)
        Me.HelpButton = true
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.Name = "ClipboardManager"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Clipboard Manager"
        Me.grpAddTo.ResumeLayout(false)
        Me.grpAddTo.PerformLayout
        Me.grpMaxEntries.ResumeLayout(false)
        CType(Me.txtMaxEntries,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout
    End Sub
    Friend optAddToEnd As System.Windows.Forms.RadioButton
    Friend optAddToStart As System.Windows.Forms.RadioButton
    Friend WithEvents chkMaxEntries As System.Windows.Forms.CheckBox
    Friend WithEvents txtMaxEntries As System.Windows.Forms.NumericUpDown
    Friend WithEvents grpMaxEntries As System.Windows.Forms.GroupBox
    Friend WithEvents grpAddTo As System.Windows.Forms.GroupBox
    Friend WithEvents lstLog As System.Windows.Forms.ListBox
    Friend WithEvents lblRecent As System.Windows.Forms.Label
    Friend WithEvents btnCopy As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents chkAutoSort As System.Windows.Forms.CheckBox
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnMoveUp As System.Windows.Forms.Button
    Friend WithEvents btnMoveDown As System.Windows.Forms.Button
    Friend WithEvents btnEnd As System.Windows.Forms.Button
    Friend WithEvents TimerClipboardChecker As System.Windows.Forms.Timer
    Friend WithEvents btnHide As System.Windows.Forms.Button
    Friend WithEvents NotifyIcon As System.Windows.Forms.NotifyIcon

End Class
