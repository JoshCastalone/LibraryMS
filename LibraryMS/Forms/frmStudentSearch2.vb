Imports MySql.Data.MySqlClient
Public Class frmStudentSearch2
    Public con As MySqlConnection = strstrconnection()
    Private Sub frmStudentSearch_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Borrow.studentwgtbl' table. You can move, or remove it, as needed.
        Me.StudentwgtblTableAdapter.FillTable(Me.Borrow.studentwgtbl)
        'TODO: This line of code loads data into the 'Borrow.studenttbl' table. You can move, or remove it, as needed.

    End Sub

    Private Sub DataGridView4_Click(sender As Object, e As EventArgs) Handles DataGridView4.Click
        Try
            'This is to insert the data from the datagridview to the "Student" groupboxes' textboxes and hides this winform.
            Me.Hide()
            Dim r As DataGridViewRow = DataGridView4.CurrentRow
            frmTransaction.txtStudentName.Text = r.Cells(1).Value.ToString
            frmTransaction.txtBorrowerID.Text = r.Cells(3).Value.ToString
            frmTransaction.txtGradeLevel.Text = r.Cells(5).Value.ToString
            frmTransaction.txtSectionStrand.Text = r.Cells(6).Value.ToString
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        con.Open()
        cmd.Connection = con
        cmd.CommandText = "SELECT * FROM studenttbl where borrower_id like '%" + txtSearch.Text.Trim + "%'"
        Dim msd As New MySqlDataAdapter(cmd)
        Dim dname As New DataTable()
        msd.Fill(dname)
        DataGridView4.DataSource = dname
        con.Close()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'reload("SELECT * FROM studenttbl where status = 'Active'", DataGridView4)
        Me.StudentwgtblTableAdapter.FillTable(Me.Borrow.studentwgtbl)
        txtSearch.Clear()
    End Sub
End Class