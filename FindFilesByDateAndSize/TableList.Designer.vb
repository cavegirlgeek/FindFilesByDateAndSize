<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TableList
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TableList))
        Me.lstBoxTables = New System.Windows.Forms.ListBox()
        Me.dgviewTableData = New System.Windows.Forms.DataGridView()
        Me.btnExportData = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.lblSelectTableList = New System.Windows.Forms.Label()
        CType(Me.dgviewTableData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lstBoxTables
        '
        Me.lstBoxTables.FormattingEnabled = True
        Me.lstBoxTables.ItemHeight = 20
        Me.lstBoxTables.Location = New System.Drawing.Point(28, 36)
        Me.lstBoxTables.Name = "lstBoxTables"
        Me.lstBoxTables.Size = New System.Drawing.Size(295, 144)
        Me.lstBoxTables.TabIndex = 0
        '
        'dgviewTableData
        '
        Me.dgviewTableData.AllowUserToAddRows = False
        Me.dgviewTableData.AllowUserToDeleteRows = False
        Me.dgviewTableData.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgviewTableData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgviewTableData.Location = New System.Drawing.Point(28, 195)
        Me.dgviewTableData.Name = "dgviewTableData"
        Me.dgviewTableData.ReadOnly = True
        Me.dgviewTableData.RowTemplate.Height = 28
        Me.dgviewTableData.Size = New System.Drawing.Size(751, 215)
        Me.dgviewTableData.TabIndex = 1
        '
        'btnExportData
        '
        Me.btnExportData.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnExportData.Location = New System.Drawing.Point(28, 427)
        Me.btnExportData.Name = "btnExportData"
        Me.btnExportData.Size = New System.Drawing.Size(120, 30)
        Me.btnExportData.TabIndex = 2
        Me.btnExportData.Text = "Export Data"
        Me.btnExportData.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClose.Location = New System.Drawing.Point(704, 427)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 30)
        Me.btnClose.TabIndex = 3
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'lblSelectTableList
        '
        Me.lblSelectTableList.AutoSize = True
        Me.lblSelectTableList.Location = New System.Drawing.Point(24, 9)
        Me.lblSelectTableList.Name = "lblSelectTableList"
        Me.lblSelectTableList.Size = New System.Drawing.Size(221, 20)
        Me.lblSelectTableList.TabIndex = 4
        Me.lblSelectTableList.Text = "Select a table in the list below:"
        '
        'TableList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(810, 471)
        Me.Controls.Add(Me.lblSelectTableList)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnExportData)
        Me.Controls.Add(Me.dgviewTableData)
        Me.Controls.Add(Me.lstBoxTables)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "TableList"
        Me.Text = "Table List"
        CType(Me.dgviewTableData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lstBoxTables As ListBox
    Friend WithEvents dgviewTableData As DataGridView
    Friend WithEvents btnExportData As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents lblSelectTableList As Label
End Class
