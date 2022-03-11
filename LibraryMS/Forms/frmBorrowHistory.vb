Public Class frmBorrowHistory
    Private Sub frmBorrowHistory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Borrow.borrowtbl' table. You can move, or remove it, as needed.
        Me.BorrowtblTableAdapter.Fill(Me.Borrow.borrowtbl)

    End Sub

    Private Sub DataGridView4_Click(sender As Object, e As EventArgs) Handles DataGridView4.Click
        Me.Hide()
        Dim r As DataGridViewRow = DataGridView4.CurrentRow
        frmTransaction.txtISBN2.Text = r.Cells(0).Value.ToString
        frmTransaction.txtTitle.Text = r.Cells(1).Value.ToString
        frmTransaction.txtAuthor2.Text = r.Cells(2).Value.ToString
        frmTransaction.txtBorrower2.Text = r.Cells(3).Value.ToString
        frmTransaction.txtStudentName2.Text = r.Cells(4).Value.ToString
        frmTransaction.dtpIssue2.Text = r.Cells(6).Value.ToString
        frmTransaction.dtpDue2.Text = r.Cells(7).Value.ToString
    End Sub
End Class