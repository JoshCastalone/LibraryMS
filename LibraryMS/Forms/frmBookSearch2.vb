Imports MySql.Data.MySqlClient
Public Class frmBookSearch2
    Public con As MySqlConnection = strstrconnection()
    Private Sub frmBookSearch2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Test3DataSet1.booktbl' table. You can move, or remove it, as needed.
        Me.BooktblTableAdapter1.Fill(Me.Test3DataSet1.booktbl)
    End Sub

    Private Sub DataGridView4_DoubleClick(sender As Object, e As EventArgs) Handles DataGridView4.DoubleClick
        Try
            'This is to insert the data from the datagridview to the "Books" groupboxes' textboxes and hides this winform.
            Me.Hide()
            Dim r As DataGridViewRow = DataGridView4.CurrentRow
            frmTransaction.txtISBN.Text = r.Cells(0).Value.ToString
            frmTransaction.txtBookTitle.Text = r.Cells(1).Value.ToString
            frmTransaction.txtEdition.Text = r.Cells(2).Value.ToString
            frmTransaction.txtAuthor.Text = r.Cells(3).Value.ToString
            frmTransaction.txtPublisher.Text = r.Cells(4).Value.ToString
            frmTransaction.txtYear.Text = r.Cells(9).Value.ToString
            frmTransaction.txtCategory.Text = r.Cells(10).Value.ToString
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        con.Open()
        cmd.Connection = con
        cmd.CommandText = "SELECT booktbl.bk_ISBN, booktbl.bktitle, booktbl.bkedition, booktbl.bkauthor, booktbl.bkpublisher, booktbl.bkcopies, booktbl.bk_totalcopies, booktbl.bk_cost, booktbl.bk_remarks, booktbl.bk_publishdate, categorytbl.category_name FROM booktbl INNER JOIN categorytbl ON booktbl.bk_categoryid = categorytbl.category_id where booktbl.bk_ISBN like '%" + txtSearch.Text.Trim + "%'"
        Dim msd As New MySqlDataAdapter(cmd)
        Dim dname As New DataTable()
        msd.Fill(dname)
        DataGridView4.DataSource = dname
        con.Close()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        reload("SELECT booktbl.bk_ISBN, booktbl.bktitle, booktbl.bkedition, booktbl.bkauthor, booktbl.bkpublisher, booktbl.bkcopies, booktbl.bk_totalcopies, booktbl.bk_cost, booktbl.bk_remarks, booktbl.bk_publishdate, categorytbl.category_name FROM booktbl INNER JOIN categorytbl ON booktbl.bk_categoryid = categorytbl.category_id", DataGridView4)
        txtSearch.Clear()
    End Sub
End Class

'This is just utterly ridiculous, Vladimir Putin!
'Just stop this needless war that is the product of your paranoia!
'I hate myself, yes I admit that, but I don't want to end up having to live in nuclear winter
' 'Cause everything would be altered permenently by the aftermath of a nuclear explosion!
' #ScrewYouPutin
' Josh Castalone - 05/03/2022