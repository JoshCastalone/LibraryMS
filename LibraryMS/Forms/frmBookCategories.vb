Imports MySql.Data.MySqlClient
Public Class frmBookCategories
    Public con As MySqlConnection = strstrconnection()
    Private Sub frmBookCategories_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Test3DataSet.categorytbl' table. You can move, or remove it, as needed.
        Me.CategorytblTableAdapter.Fill(Me.Test3DataSet.categorytbl)
        'This fetches the data contained in the selected columns and displays it at the datagridview upon loading/opening this form.
        'reload("Select `category_id`, `category_name` from `categorytbl`", dtgCategories)
    End Sub

    Private Sub btnInsert_Click(sender As Object, e As EventArgs) Handles btnInsert.Click
        Try
            If txtCatID.Text = "" Or txtCatName.Text = "" Then
                emptymessage()
            Else

                create("Insert into categorytbl(`category_id`, `category_name`) values ('" & txtCatID.Text.Trim & "', '" & txtCatName.Text.Trim & "')")
                Me.CategorytblTableAdapter.Fill(Me.Test3DataSet.categorytbl)
                'reload("Select `category_id` as `Category ID`, `category_name` as `Category Name` from `categorytbl`", dtgCategories)
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub dtgCategories_DoubleClick(sender As Object, e As EventArgs) Handles dtgCategories.DoubleClick
        txtCatID.Text = dtgCategories.CurrentRow.Cells(0).Value
        txtCatName.Text = dtgCategories.CurrentRow.Cells(1).Value
    End Sub

    Private Sub txtCatID_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCatID.KeyPress
        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) And Not e.KeyChar = "." And Not Char.IsWhiteSpace(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        updates("Update categorytbl set `category_id` = '" & txtCatID.Text.Trim & "', `category_name` = '" & txtCatName.Text.Trim & "' where category_id = '" & txtCatID.Text.Trim & "'")
        Me.CategorytblTableAdapter.Fill(Me.Test3DataSet.categorytbl)
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        delete("delete from categorytbl where category_id = '" & txtCatID.Text.Trim & "'")
        Me.CategorytblTableAdapter.Fill(Me.Test3DataSet.categorytbl)
    End Sub
End Class