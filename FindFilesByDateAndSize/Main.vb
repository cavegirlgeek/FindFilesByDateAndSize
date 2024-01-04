Imports System.IO
Imports Microsoft.Data.Sqlite

Public Class Main

    Dim thisDateTime As Date
    Dim fileList() As FileInfo
    Dim startFileSize As Int32 = 0
    Dim endFileSize As Int32 = 0
    Dim counter As Int32 = 0

    Private Sub btnFindFiles_Click(sender As Object, e As EventArgs) Handles btnFindFiles.Click
        ReDim fileList(0)
        counter = 0

        Me.DataGridView1.Rows.Clear()

        Dim validationMessage As String = ""

        If Me.mTextBoxStartTime.Text.ToString.Trim = ":" Then
            validationMessage = "Please enter a time " & vbCrLf
        End If

        If Me.ckUseFileSizeRange.Checked Then
            If String.IsNullOrEmpty(Me.mTextBoxEndFileSize.Text) Or String.IsNullOrEmpty(Me.mTextBoxStartFileSize.Text) Then
                validationMessage += "Please enter a file size range" & vbCrLf
            Else
                Try
                    startFileSize = Integer.Parse(Me.mTextBoxStartFileSize.Text)
                    endFileSize = Integer.Parse(Me.mTextBoxEndFileSize.Text)

                    If startFileSize = 0 Or endFileSize = 0 Then
                        validationMessage += "Please enter a valid file size range" & vbCrLf
                    End If
                Catch ex As Exception
                    validationMessage += "Please enter a file size range" & vbCrLf
                End Try
            End If
        End If

        If Me.lblDirectoryName.Text = "" Then
            validationMessage += "Please browse for and select a directory folder"
        End If

        If Not String.IsNullOrEmpty(validationMessage) Then
            MsgBox(validationMessage, MsgBoxStyle.OkOnly, "Error")
            Return
        End If

        Dim thisDate As String = Me.dtPickerStart.Value.ToShortDateString
        Try
            thisDateTime = thisDate & " " & Me.mTextBoxStartTime.Text.ToString
        Catch ex As Exception
            MsgBox("Please enter a valid time")
            Return
        End Try

        processDirectory(lblDirectoryName.Text)

        processFileNames()
    End Sub

    Private Sub btnBrowseForFolder_Click(sender As Object, e As EventArgs) Handles btnBrowseForFolder.Click
        If FolderBrowserDialog1.ShowDialog() = DialogResult.OK Then
            Me.lblDirectoryName.Text = FolderBrowserDialog1.SelectedPath
        End If
    End Sub


    Private Sub processDirectory(directoryName)

        Try
            'Process the list of files found in the directory.
            Dim fileEntries() As String = Directory.GetFiles(directoryName)

            For Each fileName As String In fileEntries
                Dim fileAWriteDate As Date = File.GetLastWriteTime(fileName)

                Dim minutes As Long = DateDiff(DateInterval.Minute, fileAWriteDate, thisDateTime)

                If hasFileBeenAddedOrChanged(fileAWriteDate, thisDateTime) Then
                    'check if filesize is between start and end file size
                    Dim newFileInfo As FileInfo = New FileInfo(fileName)

                    Dim bAddToList As Boolean = False

                    If Me.ckUseFileSizeRange.Checked Then
                        Dim fileLengthInKB As Int32 = newFileInfo.Length / 1024

                        If fileLengthInKB >= startFileSize And fileLengthInKB <= endFileSize Then
                            bAddToList = True
                        End If
                    End If


                    If bAddToList OrElse Me.ckUseFileSizeRange.Checked = False Then
                        'add it to array list
                        If counter = 0 Then
                            fileList(fileList.Count - 1) = newFileInfo
                        Else
                            ReDim Preserve fileList(fileList.Count)
                            fileList(fileList.Count - 1) = newFileInfo
                        End If
                        counter += 1
                    End If
                End If
            Next

            'Recurse into subdirectories of this directory.
            Dim subdirectoryEntries() As String = Directory.GetDirectories(directoryName)

            For Each subdirectory As String In subdirectoryEntries
                processDirectory(subdirectory)
            Next

        Catch ex As Exception
            Console.WriteLine("Error occurred: " & ex.Message)
        End Try
    End Sub

    Private Function hasFileBeenAddedOrChanged(ByVal date1, ByVal date2)
        Try
            If DateDiff(DateInterval.Minute, date1, date2) < 0 Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            Console.WriteLine("Error occured getting date difference: " & ex.Message)
            Return False
        End Try
    End Function

    Private Sub processFileNames()
        If fileList(0) IsNot Nothing Then
            processGridColumns()
        Else
            MessageBox.Show("No records found")
            Exit Sub
        End If

        Dim count As Int32 = 0
        For Each file In fileList
            If file IsNot Nothing Then
                Try
                    'add to grid
                    Dim filePath As String = getFileType(file.FullName.ToString)
                    Dim row() As String = {count.ToString, file.Length.ToString, filePath, file.FullName.ToString, file.LastWriteTime.ToString}
                    Me.DataGridView1.Rows.Add(row)

                Catch ex As Exception
                    Console.WriteLine("processFileNames error: " & ex.Message)
                End Try
            End If
            count += 1
        Next
    End Sub

    Private Sub processGridColumns()
        Me.DataGridView1.Columns.Clear()
        Me.DataGridView1.Columns.Add("Index", "Index")
        Me.DataGridView1.Columns.Add("Size", "Size")
        Me.DataGridView1.Columns.Add("FileType", "FileType")
        Me.DataGridView1.Columns.Add("Name", "Name")
        Me.DataGridView1.Columns.Add("Last write", "Last write")
        Me.DataGridView1.Columns(0).Width = 50
        Me.DataGridView1.Columns(3).Width = 500

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnTryOpenFile_Click(sender As Object, e As EventArgs) Handles btnTryOpenFile.Click
        If Me.DataGridView1.Rows.Count = 0 OrElse Me.DataGridView1.CurrentRow Is Nothing Then
            MessageBox.Show("No row selected.")
            Exit Sub
        End If

        Dim fileType As String = Me.txtFileType.Text

        If (String.IsNullOrEmpty(fileType)) Then
            MessageBox.Show("Enter a file type", "Missing File type", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        Else
            'get the file, copy it to temp dir?, try renaming it and opening it
            Try
                'get selected row and then get its info
                Dim dgridViewRow As DataGridViewRow = Me.DataGridView1.CurrentRow
                openSelectedFile(fileType, dgridViewRow.Cells(3).Value, False)
            Catch ex As Exception
                MessageBox.Show("Error " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If

    End Sub

    Private Sub openSelectedFile(fileType, filePath, doNotOpen)
        Try
            'rename file using a date time stamp and fileType
            Dim strDate As String = DateTime.Now.ToString("yyyyMMdhhmmss")
            Dim newFileName As String = strDate & "." & fileType
            Dim lastIndex As Int16 = filePath.ToString.LastIndexOf("\")
            Dim directoryName As String = filePath.ToString.Substring(0, lastIndex)

            My.Computer.FileSystem.RenameFile(filePath, newFileName)

            'need to rename the file in the file path of the current row:
            Dim newFilePath As String = directoryName & "\" & newFileName
            Dim dgridViewRow As DataGridViewRow = Me.DataGridView1.CurrentRow
            dgridViewRow.Cells(3).Value = newFilePath

            'attempt to open it
            If Not doNotOpen Then
                System.Diagnostics.Process.Start(newFilePath)
            End If

        Catch ex As Exception
            MessageBox.Show("Error " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Function getFileType(ByVal path As String) As String
        Try

            Dim linesArr() As String = System.IO.File.ReadAllLines(path)

            If (linesArr.Count = 0) Then
                Return ""
            Else
                Return linesArr(0)
            End If
        Catch ex As Exception
            Console.WriteLine(ex.Message)
            'MessageBox.Show("Error " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return ""
    End Function
    Private Sub btnDetermineFileType_Click(sender As Object, e As EventArgs)
        'open file to get first line to determine file type
        Try
            Dim dgridViewRow As DataGridViewRow = Me.DataGridView1.CurrentRow
            Dim filePath As String = dgridViewRow.Cells(3).Value.ToString
            Dim fileType = getFileType(filePath)


            If String.IsNullOrEmpty(filePath) Then
                MsgBox("No lines read")
            Else
                MsgBox(fileType)
            End If

        Catch ex As Exception
            MessageBox.Show("Error " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub openSQLite(ByVal filePath As String)
        Dim SQLLiteConn As New SqliteConnection
        Try

            Dim arrSchema As ArrayList = New ArrayList()

            Dim SQLitecnSTr As String = "Data Source=" & filePath
            SQLLiteConn.ConnectionString = SQLitecnSTr
            SQLLiteConn.Open()
            Using SQLitecmd As New SqliteCommand("select name from sqlite_master", SQLLiteConn)
                'where type in ('table', 'view') and name not like 'sqlite_%' order by 1", SQLLiteConn)

                Dim sqlReader As SqliteDataReader = SQLitecmd.ExecuteReader

                While sqlReader.Read
                    arrSchema.Add(sqlReader.GetValue(0))
                End While
            End Using

            Dim arrTables As ArrayList = New ArrayList
            If arrSchema.Count > 0 Then
                For Each Name As String In arrSchema

                    Try
                        Using SQLitecmd As New SqliteCommand("select * from " & Name, SQLLiteConn)

                            Dim sqlReader As SqliteDataReader = SQLitecmd.ExecuteReader

                            While sqlReader.Read
                                If Not arrTables.Contains(Name) Then
                                    arrTables.Add(Name)
                                End If
                            End While
                        End Using
                    Catch ex As Exception
                        ' MessageBox.Show("Error " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try

                Next

                If arrTables.Count > 0 Then
                    'open a modal with a list of tables from which to choose, then display all records in the table upon user 
                    'selection
                    Dim x As New TableList
                    x.TableList = arrTables
                    x.FilePath = filePath
                    x.ShowDialog()
                    x.Dispose()
                    x = Nothing
                End If
            Else
                MessageBox.Show("No table schemas in database")
            End If

        Catch ex As Exception
            MessageBox.Show("Error " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            SQLLiteConn.Close()
        End Try

    End Sub

    Private Sub btnOpenSqlite_Click(sender As Object, e As EventArgs) Handles btnOpenSqlite.Click
        Try

            If Me.DataGridView1.Rows.Count = 0 OrElse Me.DataGridView1.CurrentRow Is Nothing Then
                MessageBox.Show("No row selected.")
                Exit Sub
            End If

            Dim dgridViewRow As DataGridViewRow = Me.DataGridView1.CurrentRow
            Dim filePath As String = dgridViewRow.Cells(3).Value.ToString
            openSelectedFile("db", filePath, True)

            Dim newFilePath As String = dgridViewRow.Cells(3).Value.ToString
            openSQLite(newFilePath)
        Catch ex As Exception
            MessageBox.Show("Error " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ckUseFileSizeRange_CheckedChanged(sender As Object, e As EventArgs) Handles ckUseFileSizeRange.CheckedChanged
        If ckUseFileSizeRange.Checked Then
            Me.mTextBoxStartFileSize.Enabled = True
            Me.mTextBoxEndFileSize.Enabled = True
        Else
            Me.mTextBoxStartFileSize.Enabled = False
            Me.mTextBoxEndFileSize.Enabled = False
        End If
    End Sub

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.mTextBoxStartFileSize.Enabled = False
        Me.mTextBoxEndFileSize.Enabled = False
        Me.ckUseFileSizeRange.Checked = False
    End Sub

    Private Sub lnkLblTip_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkLblTip.LinkClicked
        MessageBox.Show("Note: Apple iPad/iPhone backed up files are usually located in: " & vbCrLf & vbCrLf &
                            "C:\Users\YOUR_USERNAME\AppData\Roaming\Apple Computer\MobileSync\Backup\")
    End Sub

    Private Sub lnkLblAppInfo_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkLblAppInfo.LinkClicked
        MessageBox.Show("This app is intended for browsing around " & vbCrLf &
                        "iPad/iPhone backup file directories created by ITunes, " & vbCrLf &
                        "in search of files created after a given date and time." & vbCrLf &
                        "Using a file size range from 1 to an upper limit can help" & vbCrLf &
                        "narrow down the search of the file you are looking for.")
    End Sub
End Class