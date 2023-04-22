Imports System.ComponentModel
Imports System.IO
Imports System.Text

Public Class Form2

    Private Sub LoadCsvData(sender As Object, e As RunWorkerCompletedEventArgs)
        Dim csvData As List(Of String()) = DirectCast(e.Result, List(Of String()))
        Dim header As String() = csvData(0)


        Dim dt As New DataTable()
        For Each colName As String In header
            dt.Columns.Add(New DataColumn(colName, GetType(String)))
        Next


        For i As Integer = 1 To csvData.Count - 1
            Dim fields As String() = csvData(i)
            Dim row As DataRow = dt.NewRow()
            row.ItemArray = fields
            dt.Rows.Add(row)
        Next


        DataGridView1.DataSource = dt
    End Sub

    Private Sub UploadCsvButton_Click(sender As Object, e As EventArgs) Handles UploadCsvButton.Click

        Dim openFileDialog1 As New OpenFileDialog()
        openFileDialog1.Filter = "CSV Files (*.csv)|*.csv|All Files (*.*)|*.*"


        If openFileDialog1.ShowDialog() = DialogResult.OK Then
            Dim fileName As String = openFileDialog1.FileName
            Dim bgWorker As New BackgroundWorker()
            AddHandler bgWorker.DoWork, AddressOf ParseCsvFile
            AddHandler bgWorker.RunWorkerCompleted, AddressOf LoadCsvData
            bgWorker.RunWorkerAsync(fileName)
        End If
    End Sub

    Private Sub ParseCsvFile(sender As Object, e As DoWorkEventArgs)

        Dim fileName As String = DirectCast(e.Argument, String)
        Dim csvData As New List(Of String())
        Using reader As New StreamReader(fileName)
            While Not reader.EndOfStream

                Dim line As String = reader.ReadLine()
                Dim fields As String() = line.Split(","c)

                csvData.Add(fields)
            End While
        End Using
        e.Result = csvData
    End Sub

    Private Sub BackupCsvButton_Click(sender As Object, e As EventArgs) Handles BackupCsvButton.Click

        If DataGridView1.Rows.Count = 0 Then

            Dim result As DialogResult = MessageBox.Show("Error: DataGridView is empty. Do you still want to create a backup?", "Backup Empty DataGridView", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.No Then
                Return
            End If
        End If


        Dim saveFileDialog1 As New SaveFileDialog()

        saveFileDialog1.Filter = "CSV Files (.csv)|.csv|All Files (.)|."
        If saveFileDialog1.ShowDialog() = DialogResult.OK Then

            Dim fileName As String = saveFileDialog1.FileName
            Using writer As New StreamWriter(fileName)

                Dim headers As New List(Of String)

                For Each column As DataGridViewColumn In DataGridView1.Columns
                    headers.Add(column.HeaderText)
                Next

                writer.WriteLine(String.Join(",", headers))

                For Each row As DataGridViewRow In DataGridView1.Rows
                    Dim fields As New StringBuilder()
                    For Each cell As DataGridViewCell In row.Cells

                        If Not String.IsNullOrWhiteSpace(cell.Value?.ToString()) Then
                            fields.Append(cell.Value.ToString())
                        End If

                        fields.Append(",")
                    Next

                    writer.WriteLine(fields.ToString().TrimEnd(","))
                Next
            End Using
            MessageBox.Show("Your Backup was successfully created!")
        End If
    End Sub


    Private openFileDialog1 As New OpenFileDialog()


    Private Const FILE_FILTER As String = "CSV Files (*.csv)|*.csv|All Files (*.*)|*.*"
    Private Const FILE_SELECT_TITLE As String = "Select a CSV file to delete"


    Private Sub DeleteCsvButton_Click(sender As Object, e As EventArgs) Handles DeleteCsvButton.Click

        openFileDialog1.Filter = FILE_FILTER
        openFileDialog1.Title = FILE_SELECT_TITLE
        openFileDialog1.Multiselect = False


        If openFileDialog1.ShowDialog() <> DialogResult.OK Then
            Return
        End If


        Dim filePath As String = openFileDialog1.FileName
        Dim fileName As String = Path.GetFileName(filePath)


        Dim confirmResult = MessageBox.Show($"Are you sure you want to delete the file {fileName}?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)


        If confirmResult <> DialogResult.Yes Then
            Return
        End If


        Try
            File.Delete(filePath)
            MessageBox.Show("File was Deleted", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As IOException
            MessageBox.Show($"Error: A problem occurred while deleting the file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As UnauthorizedAccessException
            MessageBox.Show($"Error: Permission Denied: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub DataGridView1_CurrentCellChanged(sender As Object, e As EventArgs) Handles DataGridView1.CurrentCellChanged

        Dim currentCell As DataGridViewCell = DataGridView1.CurrentCell


        If currentCell?.RowIndex IsNot Nothing AndAlso currentCell?.ColumnIndex IsNot Nothing Then

            Dim row As String = (currentCell.RowIndex + 1).ToString("D2")
            Dim column As String = (currentCell.ColumnIndex + 1).ToString("D2")


            CurrentCellTextBox.Text = $"Column {column}     Row {row}"
        Else

            CurrentCellTextBox.Text = ""
        End If
    End Sub


    Private Sub ClearGridButton_Click(sender As Object, e As EventArgs) Handles ClearGridButton.Click


        If DataGridView1.Rows.Count = 0 AndAlso DataGridView1.Columns.Count = 0 Then

            MessageBox.Show("Data Grid View is empty.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If


        Dim rowCount As Integer = DataGridView1.Rows.Count
        Dim columnCount As Integer = DataGridView1.Columns.Count


        Dim message As String = $"Are you sure you want to clear the DataGridView?{vbCrLf}This will delete {rowCount} rows and {columnCount} columns."


        Dim result = MessageBox.Show(message, "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)


        If result = DialogResult.Yes Then
            DataGridView1.DataSource = Nothing
        End If

    End Sub

    Private Sub GoToCellButton_Click(sender As Object, e As EventArgs) Handles GoToCellButton.Click

        If DataGridView1.RowCount = 0 OrElse DataGridView1.ColumnCount = 0 OrElse String.IsNullOrEmpty(RowTextBox.Text) OrElse String.IsNullOrEmpty(ColumnTextBox.Text) Then

            RowTextBox.Text = " "
            ColumnTextBox.Text = " "
            Return
        End If


        Dim row As Integer = CInt(RowTextBox.Text)
        Dim column As Integer = CInt(ColumnTextBox.Text)


        If row > 0 AndAlso row <= DataGridView1.RowCount AndAlso column > 0 AndAlso column <= DataGridView1.ColumnCount Then

            DataGridView1.CurrentCell = DataGridView1(column - 1, row - 1)
            DataGridView1.FirstDisplayedScrollingRowIndex = row - 1
        Else
            MessageBox.Show("Invalid row or column number.")
        End If
    End Sub

    Private Function IsIndexSpecified(indexTextBox As TextBox) As Boolean

        If String.IsNullOrEmpty(indexTextBox.Text) Then
            MessageBox.Show("Oops Incorrect index number.")
            Return False
        End If
        Return True
    End Function

    Private Sub RemoveRowButton_Click(sender As Object, e As EventArgs) Handles RemoveRowButton.Click

        Dim rowNumber As Integer
        If String.IsNullOrEmpty(RowTextBox.Text) OrElse Not Integer.TryParse(RowTextBox.Text, rowNumber) Then
            MessageBox.Show("Invalid Row number")
            Return
        End If

        If DataGridView1.ColumnHeadersVisible Then
            rowNumber -= 1
        End If


        If rowNumber < 0 OrElse rowNumber >= DataGridView1.Rows.Count Then
            MessageBox.Show($"Row number {rowNumber + 1} does not exist")
            Return
        End If


        Dim result = MessageBox.Show($"Are you sure you want to remove row number {rowNumber + 1}?", "Confirm", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then

            DataGridView1.Rows.RemoveAt(rowNumber)
        End If
    End Sub

    Private Sub RemoveColumnButton_Click(sender As Object, e As EventArgs) Handles RemoveColumnButton.Click

        Dim columnNumber As Integer
        If Not IsIndexSpecified(ColumnTextBox) OrElse String.IsNullOrEmpty(ColumnTextBox.Text) OrElse Not Integer.TryParse(ColumnTextBox.Text, columnNumber) Then
            MessageBox.Show("Invalid Column number")
            Return
        End If
        columnNumber -= 1


        If columnNumber < 0 OrElse columnNumber >= DataGridView1.Columns.Count Then
            MessageBox.Show($"Column number {columnNumber + 1} does not exist")
            Return
        End If


        Dim result = MessageBox.Show($"Are you sure you want to remove column number {columnNumber + 1}?", "Confirm", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then

            DataGridView1.Columns.RemoveAt(columnNumber)
        End If
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then

            RowTextBox.Text = $"{e.RowIndex + 1}"
            ColumnTextBox.Text = $"{e.ColumnIndex + 1}"
        Else

            RowTextBox.Clear()
            ColumnTextBox.Clear()
        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub CurrentCellTextBox_TextChanged(sender As Object, e As EventArgs) Handles CurrentCellTextBox.TextChanged

    End Sub

    Private Sub ColumnTextBox_TextChanged(sender As Object, e As EventArgs) Handles ColumnTextBox.TextChanged

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
