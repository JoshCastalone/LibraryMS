Imports MySql.Data.MySqlClient
Public Class frmStudentSearch
    Public con As MySqlConnection = strstrconnection()
    Private Sub frmStudentSearch_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Borrow.studentwgtbl' table. You can move, or remove it, as needed.
        Me.StudentwgtblTableAdapter.FillTable(Me.Borrow.studentwgtbl)
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        reload("SELECT * FROM studenttbl where status = 'Active'", DataGridView4)
        txtSearch.Clear()
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
    Private Sub DataGridView4_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView4.CellMouseClick
        'This is to insert the data from the datagridview to the "Books" groupboxes' textboxes and hides this winform.
        Try
            If e.RowIndex >= 0 Then
                Dim r As DataGridViewRow = DataGridView4.Rows(e.RowIndex)
                frmBorrower.txtStudentID.Text = r.Cells(0).Value.ToString
                frmBorrower.txtStudentName.Text = r.Cells(1).Value.ToString
                frmBorrower.cmbGender.Text = r.Cells(2).Value.ToString
                frmBorrower.txtBorrowerID.Text = r.Cells(3).Value.ToString
                frmBorrower.dtpDOB.Text = r.Cells(4).Value.ToString
                frmBorrower.cmbGradeLevel.Text = r.Cells(5).Value.ToString
                frmBorrower.cmbSectionStrand.Text = r.Cells(6).Value.ToString
                frmBorrower.txtPhoneNo.Text = r.Cells(8).Value.ToString
                frmBorrower.txtAddress.Text = r.Cells(7).Value.ToString
                frmBorrower.txtMobileNo.Text = r.Cells(9).Value.ToString
                frmBorrower.txtAcademicYear.Text = r.Cells(10).Value.ToString
                frmBorrower.txtEmail.Text = r.Cells(11).Value.ToString
                Me.Close()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class

'Yung nabubuang ka na kasi hindi gumagana yung update, pero nakalimutan mo lang yung "What" statement...
'*Insert facepalm*