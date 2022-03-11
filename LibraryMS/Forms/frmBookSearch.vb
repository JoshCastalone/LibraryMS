Imports MySql.Data.MySqlClient

Public Class frmBookSearch
    Public con As MySqlConnection = strstrconnection()
    'This loads the data from the dataset to the cmbISBN and datagridview.
    Private Sub frmBookSearch_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbISBN.Text = "Select ISBN..."
        cmbTitle.Text = "Select Book..."
        cmbAuthor.Text = "Select Author..."
        'TODO: This line of code loads data into the 'Test3DataSet.booktbl' table. You can move, or remove it, as needed.
        Me.BooktblTableAdapter.Fill(Me.Test3DataSet.booktbl)
    End Sub

    'This filters the results based on the typed value on the cmbISBN.
    Private Sub cmbISBN_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbISBN.SelectedIndexChanged
        'Me.BooktblTableAdapter.FillBooks2(Me.Test3DataSet.booktbl, cmbISBN.Text)
        con.Open()
        cmd.Connection = con
        cmd.CommandText = "SELECT booktbl.bk_ISBN, booktbl.bktitle, booktbl.bkedition, booktbl.bkauthor, booktbl.bkpublisher, booktbl.bkcopies, booktbl.bk_totalcopies, booktbl.bk_cost, booktbl.bk_remarks, booktbl.bk_publishdate, categorytbl.category_name FROM booktbl INNER JOIN categorytbl ON booktbl.bk_categoryid = categorytbl.category_id where booktbl.bk_ISBN like '%" + cmbISBN.Text + "%'"
        Dim msd As New MySqlDataAdapter(cmd)
        Dim dname As New DataTable()
        msd.Fill(dname)
        dataGridView3.DataSource = dname
        con.Close()
    End Sub

    'This reloads the datagridview and clears the cmbISBN and txtISBN's values.
    Private Sub button2_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        cmbISBN.Text = "Select ISBN..."
        txtISBN.Text = ""
        reload("SELECT booktbl.bk_ISBN, booktbl.bktitle, booktbl.bkedition, booktbl.bkauthor, booktbl.bkpublisher, booktbl.bkcopies, booktbl.bk_totalcopies, booktbl.bk_cost, booktbl.bk_remarks, booktbl.bk_publishdate, categorytbl.category_name FROM booktbl INNER JOIN categorytbl ON booktbl.bk_categoryid = categorytbl.category_id", dataGridView3)
    End Sub

    'This filters the results based on the typed value on the txtISBN.
    Private Sub txtISBN_TextChanged(sender As Object, e As EventArgs) Handles txtISBN.TextChanged
        con.Open()
        cmd.Connection = con
        cmd.CommandText = "SELECT booktbl.bk_ISBN, booktbl.bktitle, booktbl.bkedition, booktbl.bkauthor, booktbl.bkpublisher, booktbl.bkcopies, booktbl.bk_totalcopies, booktbl.bk_cost, booktbl.bk_remarks, booktbl.bk_publishdate, categorytbl.category_name FROM booktbl INNER JOIN categorytbl ON booktbl.bk_categoryid = categorytbl.category_id where booktbl.bk_ISBN like '%" + txtISBN.Text.Trim + "%'"
        Dim msd As New MySqlDataAdapter(cmd)
        Dim dname As New DataTable()
        msd.Fill(dname)
        dataGridView3.DataSource = dname
        con.Close()
    End Sub
    'This filters the results based on the typed value on the cmbAuthor.
    Private Sub cmbAuthor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbAuthor.SelectedIndexChanged
        con.Open()
        cmd.Connection = con
        cmd.CommandText = "SELECT booktbl.bk_ISBN, booktbl.bktitle, booktbl.bkedition, booktbl.bkauthor, booktbl.bkpublisher, booktbl.bkcopies, booktbl.bk_totalcopies, booktbl.bk_cost, booktbl.bk_remarks, booktbl.bk_publishdate, categorytbl.category_name FROM booktbl INNER JOIN categorytbl ON booktbl.bk_categoryid = categorytbl.category_id where booktbl.bkauthor like '%" + cmbAuthor.Text + "%'"
        Dim msd As New MySqlDataAdapter(cmd)
        Dim dname As New DataTable()
        msd.Fill(dname)
        DataGridView2.DataSource = dname
        con.Close()
    End Sub

    'This filters the results based on the typed value on the txtAuthor.
    Private Sub txtAuthor_TextChanged(sender As Object, e As EventArgs) Handles txtAuthor.TextChanged
        con.Open()
        cmd.Connection = con
        cmd.CommandText = "SELECT booktbl.bk_ISBN, booktbl.bktitle, booktbl.bkedition, booktbl.bkauthor, booktbl.bkpublisher, booktbl.bkcopies, booktbl.bk_totalcopies, booktbl.bk_cost, booktbl.bk_remarks, booktbl.bk_publishdate, categorytbl.category_name FROM booktbl INNER JOIN categorytbl ON booktbl.bk_categoryid = categorytbl.category_id where booktbl.bkauthor like '%" + txtAuthor.Text + "%'"
        Dim msd As New MySqlDataAdapter(cmd)
        Dim dname As New DataTable()
        msd.Fill(dname)
        DataGridView2.DataSource = dname
        con.Close()
    End Sub

    Private Sub btnResetAuth_Click(sender As Object, e As EventArgs) Handles btnResetAuth.Click
        cmbAuthor.Text = "Select Author..."
        txtAuthor.Text = ""
        reload("SELECT booktbl.bk_ISBN, booktbl.bktitle, booktbl.bkedition, booktbl.bkauthor, booktbl.bkpublisher, booktbl.bkcopies, booktbl.bk_totalcopies, booktbl.bk_cost, booktbl.bk_remarks, booktbl.bk_publishdate, categorytbl.category_name FROM booktbl INNER JOIN categorytbl ON booktbl.bk_categoryid = categorytbl.category_id", DataGridView2)
    End Sub

    'This filters the results based on the typed value on the cmbTitle.
    Private Sub cmbTitle_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbTitle.SelectedIndexChanged
        con.Open()
        cmd.Connection = con
        cmd.CommandText = "SELECT booktbl.bk_ISBN, booktbl.bktitle, booktbl.bkedition, booktbl.bkauthor, booktbl.bkpublisher, booktbl.bkcopies, booktbl.bk_totalcopies, booktbl.bk_cost, booktbl.bk_remarks, booktbl.bk_publishdate, categorytbl.category_name FROM booktbl INNER JOIN categorytbl ON booktbl.bk_categoryid = categorytbl.category_id where booktbl.bktitle like '%" + cmbTitle.Text + "%'"
        Dim msd As New MySqlDataAdapter(cmd)
        Dim dname As New DataTable()
        msd.Fill(dname)
        DataGridView1.DataSource = dname
        con.Close()
    End Sub

    'This filters the results based on the typed value on the txtTitle.
    Private Sub txtTitle_TextChanged(sender As Object, e As EventArgs) Handles txtTitle.TextChanged
        con.Open()
        cmd.Connection = con
        cmd.CommandText = "SELECT booktbl.bk_ISBN, booktbl.bktitle, booktbl.bkedition, booktbl.bkauthor, booktbl.bkpublisher, booktbl.bkcopies, booktbl.bk_totalcopies, booktbl.bk_cost, booktbl.bk_remarks, booktbl.bk_publishdate, categorytbl.category_name FROM booktbl INNER JOIN categorytbl ON booktbl.bk_categoryid = categorytbl.category_id where booktbl.bktitle like '%" + txtTitle.Text + "%'"
        Dim msd As New MySqlDataAdapter(cmd)
        Dim dname As New DataTable()
        msd.Fill(dname)
        DataGridView1.DataSource = dname
        con.Close()
    End Sub

    Private Sub btnResetTitle_Click(sender As Object, e As EventArgs) Handles btnResetTitle.Click
        cmbAuthor.Text = "Select Author..."
        txtAuthor.Text = ""
        reload("SELECT booktbl.bk_ISBN, booktbl.bktitle, booktbl.bkedition, booktbl.bkauthor, booktbl.bkpublisher, booktbl.bkcopies, booktbl.bk_totalcopies, booktbl.bk_cost, booktbl.bk_remarks, booktbl.bk_publishdate, categorytbl.category_name FROM booktbl INNER JOIN categorytbl ON booktbl.bk_categoryid = categorytbl.category_id", DataGridView1)
    End Sub

    'This exports contents of the datagridview to an Excel file.
    Private Sub btnExport_Click(sender As Object, e As EventArgs) Handles btnExport1.Click
        Try
            If dataGridView3.RowCount = Nothing Or DataGridView1.RowCount = Nothing Or DataGridView2.RowCount = Nothing Then
                MessageBox.Show("Sorry nothing to export into excel sheet.." & vbCrLf & "Please retrieve data in datagridview", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            Dim rowsTotal, colsTotal As Short
            Dim I, j, iC As Short
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
            Dim xlApp As New Microsoft.Office.Interop.Excel.Application
            Try
                Dim excelBook As Microsoft.Office.Interop.Excel.Workbook = xlApp.Workbooks.Add
                Dim excelWorksheet As Microsoft.Office.Interop.Excel.Worksheet = CType(excelBook.Worksheets(1), Microsoft.Office.Interop.Excel.Worksheet)
                xlApp.Visible = True

                rowsTotal = dataGridView3.RowCount - 1
                colsTotal = dataGridView3.Columns.Count - 1
                With excelWorksheet
                    .Cells.Select()
                    .Cells.Delete()
                    For iC = 0 To colsTotal
                        .Cells(1, iC + 1).Value = dataGridView3.Columns(iC).HeaderText
                    Next
                    For I = 0 To rowsTotal - 1
                        For j = 0 To colsTotal
                            .Cells(I + 2, j + 1).value = dataGridView3.Rows(I).Cells(j).Value
                        Next j
                    Next I
                    .Rows("1:1").Font.FontStyle = "Bold"
                    .Rows("1:1").Font.Size = 12

                    .Cells.Columns.AutoFit()
                    .Cells.Select()
                    .Cells.EntireColumn.AutoFit()
                    .Cells(1, 1).Select()
                End With
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                'RELEASE ALLOACTED RESOURCES
                System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
                xlApp = Nothing
            End Try
        Catch ex As Exception

        End Try
    End Sub
End Class