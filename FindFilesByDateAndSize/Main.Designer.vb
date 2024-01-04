<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.dtPickerStart = New System.Windows.Forms.DateTimePicker()
        Me.mTextBoxStartTime = New System.Windows.Forms.MaskedTextBox()
        Me.lblStartDate = New System.Windows.Forms.Label()
        Me.txtBoxFileSize = New System.Windows.Forms.Label()
        Me.mTextBoxStartFileSize = New System.Windows.Forms.MaskedTextBox()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.lblFolder = New System.Windows.Forms.Label()
        Me.btnBrowseForFolder = New System.Windows.Forms.Button()
        Me.lblDirectoryName = New System.Windows.Forms.Label()
        Me.btnFindFiles = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.lblBetween = New System.Windows.Forms.Label()
        Me.lblAnd = New System.Windows.Forms.Label()
        Me.mTextBoxEndFileSize = New System.Windows.Forms.MaskedTextBox()
        Me.txtFileType = New System.Windows.Forms.TextBox()
        Me.lblTryFileType = New System.Windows.Forms.Label()
        Me.btnTryOpenFile = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnOpenSqlite = New System.Windows.Forms.Button()
        Me.lblFindFilesInfo = New System.Windows.Forms.Label()
        Me.ckUseFileSizeRange = New System.Windows.Forms.CheckBox()
        Me.gBoxFileSizeRange = New System.Windows.Forms.GroupBox()
        Me.lnkLblTip = New System.Windows.Forms.LinkLabel()
        Me.lblStartTime = New System.Windows.Forms.Label()
        Me.lnkLblAppInfo = New System.Windows.Forms.LinkLabel()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dtPickerStart
        '
        Me.dtPickerStart.Location = New System.Drawing.Point(181, 22)
        Me.dtPickerStart.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.dtPickerStart.Name = "dtPickerStart"
        Me.dtPickerStart.Size = New System.Drawing.Size(298, 26)
        Me.dtPickerStart.TabIndex = 0
        '
        'mTextBoxStartTime
        '
        Me.mTextBoxStartTime.Location = New System.Drawing.Point(565, 22)
        Me.mTextBoxStartTime.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.mTextBoxStartTime.Mask = "90:00"
        Me.mTextBoxStartTime.Name = "mTextBoxStartTime"
        Me.mTextBoxStartTime.Size = New System.Drawing.Size(55, 26)
        Me.mTextBoxStartTime.TabIndex = 1
        Me.mTextBoxStartTime.ValidatingType = GetType(Date)
        '
        'lblStartDate
        '
        Me.lblStartDate.AutoSize = True
        Me.lblStartDate.Location = New System.Drawing.Point(24, 25)
        Me.lblStartDate.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblStartDate.Name = "lblStartDate"
        Me.lblStartDate.Size = New System.Drawing.Size(147, 20)
        Me.lblStartDate.TabIndex = 3
        Me.lblStartDate.Text = "Files created after*:"
        '
        'txtBoxFileSize
        '
        Me.txtBoxFileSize.AutoSize = True
        Me.txtBoxFileSize.Location = New System.Drawing.Point(36, 142)
        Me.txtBoxFileSize.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.txtBoxFileSize.Name = "txtBoxFileSize"
        Me.txtBoxFileSize.Size = New System.Drawing.Size(101, 20)
        Me.txtBoxFileSize.TabIndex = 4
        Me.txtBoxFileSize.Text = "File size(KB):"
        '
        'mTextBoxStartFileSize
        '
        Me.mTextBoxStartFileSize.Location = New System.Drawing.Point(288, 137)
        Me.mTextBoxStartFileSize.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.mTextBoxStartFileSize.Mask = "000000000"
        Me.mTextBoxStartFileSize.Name = "mTextBoxStartFileSize"
        Me.mTextBoxStartFileSize.Size = New System.Drawing.Size(109, 26)
        Me.mTextBoxStartFileSize.TabIndex = 2
        '
        'lblFolder
        '
        Me.lblFolder.AutoSize = True
        Me.lblFolder.Location = New System.Drawing.Point(24, 210)
        Me.lblFolder.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFolder.Name = "lblFolder"
        Me.lblFolder.Size = New System.Drawing.Size(64, 20)
        Me.lblFolder.TabIndex = 6
        Me.lblFolder.Text = "Folder*:"
        '
        'btnBrowseForFolder
        '
        Me.btnBrowseForFolder.Location = New System.Drawing.Point(151, 202)
        Me.btnBrowseForFolder.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnBrowseForFolder.Name = "btnBrowseForFolder"
        Me.btnBrowseForFolder.Size = New System.Drawing.Size(112, 35)
        Me.btnBrowseForFolder.TabIndex = 4
        Me.btnBrowseForFolder.Text = "Browse"
        Me.btnBrowseForFolder.UseVisualStyleBackColor = True
        '
        'lblDirectoryName
        '
        Me.lblDirectoryName.AutoSize = True
        Me.lblDirectoryName.Location = New System.Drawing.Point(300, 211)
        Me.lblDirectoryName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDirectoryName.Name = "lblDirectoryName"
        Me.lblDirectoryName.Size = New System.Drawing.Size(0, 20)
        Me.lblDirectoryName.TabIndex = 8
        '
        'btnFindFiles
        '
        Me.btnFindFiles.BackColor = System.Drawing.Color.LawnGreen
        Me.btnFindFiles.ForeColor = System.Drawing.Color.Black
        Me.btnFindFiles.Location = New System.Drawing.Point(28, 254)
        Me.btnFindFiles.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnFindFiles.Name = "btnFindFiles"
        Me.btnFindFiles.Size = New System.Drawing.Size(112, 35)
        Me.btnFindFiles.TabIndex = 5
        Me.btnFindFiles.Text = "Find files"
        Me.btnFindFiles.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(28, 323)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(1130, 306)
        Me.DataGridView1.TabIndex = 10
        '
        'lblBetween
        '
        Me.lblBetween.AutoSize = True
        Me.lblBetween.Location = New System.Drawing.Point(183, 142)
        Me.lblBetween.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblBetween.Name = "lblBetween"
        Me.lblBetween.Size = New System.Drawing.Size(72, 20)
        Me.lblBetween.TabIndex = 11
        Me.lblBetween.Text = "Between"
        '
        'lblAnd
        '
        Me.lblAnd.AutoSize = True
        Me.lblAnd.Location = New System.Drawing.Point(428, 142)
        Me.lblAnd.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAnd.Name = "lblAnd"
        Me.lblAnd.Size = New System.Drawing.Size(36, 20)
        Me.lblAnd.TabIndex = 12
        Me.lblAnd.Text = "and"
        '
        'mTextBoxEndFileSize
        '
        Me.mTextBoxEndFileSize.Location = New System.Drawing.Point(504, 139)
        Me.mTextBoxEndFileSize.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.mTextBoxEndFileSize.Mask = "000000000"
        Me.mTextBoxEndFileSize.Name = "mTextBoxEndFileSize"
        Me.mTextBoxEndFileSize.Size = New System.Drawing.Size(109, 26)
        Me.mTextBoxEndFileSize.TabIndex = 3
        '
        'txtFileType
        '
        Me.txtFileType.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtFileType.Location = New System.Drawing.Point(104, 651)
        Me.txtFileType.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtFileType.Name = "txtFileType"
        Me.txtFileType.Size = New System.Drawing.Size(106, 26)
        Me.txtFileType.TabIndex = 13
        '
        'lblTryFileType
        '
        Me.lblTryFileType.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblTryFileType.AutoSize = True
        Me.lblTryFileType.Location = New System.Drawing.Point(24, 655)
        Me.lblTryFileType.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTryFileType.Name = "lblTryFileType"
        Me.lblTryFileType.Size = New System.Drawing.Size(72, 20)
        Me.lblTryFileType.TabIndex = 14
        Me.lblTryFileType.Text = "File type:"
        '
        'btnTryOpenFile
        '
        Me.btnTryOpenFile.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnTryOpenFile.Location = New System.Drawing.Point(225, 647)
        Me.btnTryOpenFile.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnTryOpenFile.Name = "btnTryOpenFile"
        Me.btnTryOpenFile.Size = New System.Drawing.Size(225, 35)
        Me.btnTryOpenFile.TabIndex = 15
        Me.btnTryOpenFile.Text = "Try opening as file type"
        Me.btnTryOpenFile.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClose.Location = New System.Drawing.Point(1075, 647)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(112, 35)
        Me.btnClose.TabIndex = 16
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnOpenSqlite
        '
        Me.btnOpenSqlite.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnOpenSqlite.Location = New System.Drawing.Point(616, 647)
        Me.btnOpenSqlite.Name = "btnOpenSqlite"
        Me.btnOpenSqlite.Size = New System.Drawing.Size(192, 35)
        Me.btnOpenSqlite.TabIndex = 18
        Me.btnOpenSqlite.Text = "Open as SQLite DB"
        Me.btnOpenSqlite.UseVisualStyleBackColor = True
        '
        'lblFindFilesInfo
        '
        Me.lblFindFilesInfo.AutoSize = True
        Me.lblFindFilesInfo.Location = New System.Drawing.Point(177, 261)
        Me.lblFindFilesInfo.Name = "lblFindFilesInfo"
        Me.lblFindFilesInfo.Size = New System.Drawing.Size(611, 20)
        Me.lblFindFilesInfo.TabIndex = 19
        Me.lblFindFilesInfo.Text = "Note: this process could take several minutes, depending on how many files there " &
    "are."
        '
        'ckUseFileSizeRange
        '
        Me.ckUseFileSizeRange.AutoSize = True
        Me.ckUseFileSizeRange.Location = New System.Drawing.Point(38, 97)
        Me.ckUseFileSizeRange.Name = "ckUseFileSizeRange"
        Me.ckUseFileSizeRange.Size = New System.Drawing.Size(158, 24)
        Me.ckUseFileSizeRange.TabIndex = 21
        Me.ckUseFileSizeRange.Text = "Use file size range"
        Me.ckUseFileSizeRange.UseVisualStyleBackColor = True
        '
        'gBoxFileSizeRange
        '
        Me.gBoxFileSizeRange.Location = New System.Drawing.Point(28, 66)
        Me.gBoxFileSizeRange.Name = "gBoxFileSizeRange"
        Me.gBoxFileSizeRange.Size = New System.Drawing.Size(613, 118)
        Me.gBoxFileSizeRange.TabIndex = 22
        Me.gBoxFileSizeRange.TabStop = False
        Me.gBoxFileSizeRange.Text = "File Size"
        '
        'lnkLblTip
        '
        Me.lnkLblTip.AutoSize = True
        Me.lnkLblTip.Location = New System.Drawing.Point(88, 209)
        Me.lnkLblTip.Name = "lnkLblTip"
        Me.lnkLblTip.Size = New System.Drawing.Size(30, 20)
        Me.lnkLblTip.TabIndex = 23
        Me.lnkLblTip.TabStop = True
        Me.lnkLblTip.Text = "Tip"
        '
        'lblStartTime
        '
        Me.lblStartTime.AutoSize = True
        Me.lblStartTime.Location = New System.Drawing.Point(502, 27)
        Me.lblStartTime.Name = "lblStartTime"
        Me.lblStartTime.Size = New System.Drawing.Size(53, 20)
        Me.lblStartTime.TabIndex = 24
        Me.lblStartTime.Text = "Time*:"
        '
        'lnkLblAppInfo
        '
        Me.lnkLblAppInfo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lnkLblAppInfo.AutoSize = True
        Me.lnkLblAppInfo.Location = New System.Drawing.Point(1117, 25)
        Me.lnkLblAppInfo.Name = "lnkLblAppInfo"
        Me.lnkLblAppInfo.Size = New System.Drawing.Size(70, 20)
        Me.lnkLblAppInfo.TabIndex = 25
        Me.lnkLblAppInfo.TabStop = True
        Me.lnkLblAppInfo.Text = "App Info"
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1200, 692)
        Me.Controls.Add(Me.lnkLblAppInfo)
        Me.Controls.Add(Me.lblStartTime)
        Me.Controls.Add(Me.lnkLblTip)
        Me.Controls.Add(Me.ckUseFileSizeRange)
        Me.Controls.Add(Me.lblFindFilesInfo)
        Me.Controls.Add(Me.btnOpenSqlite)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnTryOpenFile)
        Me.Controls.Add(Me.lblTryFileType)
        Me.Controls.Add(Me.txtFileType)
        Me.Controls.Add(Me.mTextBoxEndFileSize)
        Me.Controls.Add(Me.lblAnd)
        Me.Controls.Add(Me.lblBetween)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnFindFiles)
        Me.Controls.Add(Me.lblDirectoryName)
        Me.Controls.Add(Me.btnBrowseForFolder)
        Me.Controls.Add(Me.lblFolder)
        Me.Controls.Add(Me.mTextBoxStartFileSize)
        Me.Controls.Add(Me.txtBoxFileSize)
        Me.Controls.Add(Me.lblStartDate)
        Me.Controls.Add(Me.mTextBoxStartTime)
        Me.Controls.Add(Me.dtPickerStart)
        Me.Controls.Add(Me.gBoxFileSizeRange)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Main"
        Me.Text = "Find files"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dtPickerStart As DateTimePicker
    Friend WithEvents mTextBoxStartTime As MaskedTextBox
    Friend WithEvents lblStartDate As Label
    Friend WithEvents txtBoxFileSize As Label
    Friend WithEvents mTextBoxStartFileSize As MaskedTextBox
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents lblFolder As Label
    Friend WithEvents btnBrowseForFolder As Button
    Friend WithEvents lblDirectoryName As Label
    Friend WithEvents btnFindFiles As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents lblBetween As Label
    Friend WithEvents lblAnd As Label
    Friend WithEvents mTextBoxEndFileSize As MaskedTextBox
    Friend WithEvents txtFileType As TextBox
    Friend WithEvents lblTryFileType As Label
    Friend WithEvents btnTryOpenFile As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents btnOpenSqlite As Button
    Friend WithEvents lblFindFilesInfo As Label
    Friend WithEvents ckUseFileSizeRange As CheckBox
    Friend WithEvents gBoxFileSizeRange As GroupBox
    Friend WithEvents lnkLblTip As LinkLabel
    Friend WithEvents lblStartTime As Label
    Friend WithEvents lnkLblAppInfo As LinkLabel
End Class
