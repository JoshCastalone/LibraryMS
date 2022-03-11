Imports MySql.Data.MySqlClient
Public Class frmStudentSearch3
    Public con As MySqlConnection = strstrconnection()
    Private Sub frmStudentSearch3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.StudentwgtblTableAdapter.FillTable(Me.Borrow.studentwgtbl)
    End Sub
    Private Sub DataGridView4_Click(sender As Object, e As EventArgs) Handles DataGridView4.Click
        Try
            'This is to insert the data from the datagridview to the "Student" groupboxes' textboxes and hides this winform.
            Me.Hide()
            Dim r As DataGridViewRow = DataGridView4.CurrentRow
            frmTransaction.txtStudentName2.Text = r.Cells(1).Value.ToString
            frmTransaction.txtBorrower2.Text = r.Cells(3).Value.ToString
            frmTransaction.txtGradeYear2.Text = r.Cells(5).Value.ToString
            frmTransaction.txtSectionStrand2.Text = r.Cells(6).Value.ToString
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