Imports Microsoft.Data.Sqlite
Imports System.IO

Public Class TableList

    Private arrListTable As ArrayList

    Private dbFilePath As String

    Private dtRecords As New DataTable

    Public Property FilePath As String
        Get
            Return dbFilePath

        End Get
        Set(value As String)
            dbFilePath = value
        End Set
    End Property
    Public Property TableList As ArrayList
        Get
            Return arrListTable
        End Get
        Set(value As ArrayList)
            arrListTable = value
            arrListTable.Insert(0, "Select")
        End Set
    End Property

    Private Sub TableList_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.lstBoxTables.DataSource = arrListTable
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub lstBoxTables_SelectedValueChanged(sender As Object, e As EventArgs) Handles lstBoxTables.SelectedValueChanged
        'display the data in the grid view
        Dim tableName As String = lstBoxTables.SelectedValue
        If tableName = "Select" Then
            Exit Sub
        End If

        Dim SQLLiteConn As New SqliteConnection
        Try

            Dim SQLitecnSTr As String = "Data Source=" & FilePath
            SQLLiteConn.ConnectionString = SQLitecnSTr
            SQLLiteConn.Open()

            Try
                Using SQLitecmd As New SqliteCommand("select * from " & tableName, SQLLiteConn)

                    Dim sqlReader As SqliteDataReader = SQLitecmd.ExecuteReader
                    Dim arrData As ArrayList = New ArrayList
                    dtRecords = New DataTable()
                    dtRecords.Load(sqlReader)
                    Me.dgviewTableData.DataSource = dtRecords
                End Using
            Catch ex As Exception
                ' MessageBox.Show("Error " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

            Dim x As Int32 = 0
        Catch ex As Exception
            'do something
        Finally
            SQLLiteConn.Close()
        End Try
    End Sub

    Private Sub dgviewTableData_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles dgviewTableData.DataError
        Console.WriteLine(e.Exception.Message)
    End Sub

    Private Sub btnExportData_Click(sender As Object, e As EventArgs) Handles btnExportData.Click
        Try
            Dim strFolderPath As String = String.Empty

            If FolderBrowserDialog1.ShowDialog() = DialogResult.OK Then
                strFolderPath = FolderBrowserDialog1.SelectedPath
            End If

            If strFolderPath = String.Empty Then
                MessageBox.Show("Please select a file directory into which to put the CSV file.")
                Exit Sub
            End If

            Dim strData As String = ""
            If dtRecords.Rows.Count > 0 Then
                Me.Cursor = Cursors.WaitCursor
                For Each column As DataColumn In dtRecords.Columns
                    strData &= column.ColumnName & ","
                Next
                'remove the last comma and wrap line
                Dim lastIndexComma As Int32 = strData.LastIndexOf(",")
                strData = strData.Substring(0, strData.Length - 1)
                strData &= vbCrLf
                For Each row As DataRow In dtRecords.Rows
                    For Each item As Object In row.ItemArray
                        strData &= item.ToString() & ","
                    Next
                    'remove the last comma and wrap line
                    lastIndexComma = strData.LastIndexOf(",")
                    strData = strData.Substring(0, strData.Length - 1)
                    strData &= vbCrLf
                Next

                Dim newDate As String = Today.ToString("yyyyMMdd")
                newDate &= DateTime.Now.ToString("HHmmss")

                'write strData to file
                My.Computer.FileSystem.WriteAllText(strFolderPath & "\" & newDate & ".csv", strData, False)
                MessageBox.Show("CSV file created. ", "Success", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

            Else
                MessageBox.Show("No records to export ", "No Records", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show("Error " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub
End Class