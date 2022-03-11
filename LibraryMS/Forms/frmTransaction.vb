Imports System.ComponentModel
Imports MySql.Data.MySqlClient
Imports USB_Barcode_Scanner
'Barcode scanner dll is brought you by BasselTech
'© BasselTech https://basseltech.com/watch?v=OoFpt-4xjzU&i=1
Public Class frmTransaction
    Public con As MySqlConnection = strstrconnection()
    Dim conn As New MySqlConnection
    Dim cmd As New MySqlCommand
    Dim dadapter As New MySqlDataAdapter
    Dim dt As New DataTable
    Dim dreader As MySqlDataReader
    Dim sql As String
    WithEvents barcodescanner As BarcodeScanner
    Private Sub frmBooks_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Borrow.borrowtbl' table. You can move, or remove it, as needed.
        Me.BorrowtblTableAdapter.Fill(Me.Borrow.borrowtbl)
        'TODO: This line of code loads data into the 'Borrow.returntbl' table. You can move, or remove it, as needed.
        Me.ReturntblTableAdapter.Fill(Me.Borrow.returntbl)

        'firstload(Me)
        barcodescanner = New BarcodeScanner(txtISBN)
        autocompletebook()
        autocompletestudent()
        autocompletebook2()
        autocompletestudent2()
    End Sub
    Sub autocompletebook()
        con.Open()
        cmd.Connection = con
        cmd.CommandText = "Select * from booktbl order by bk_ISBN asc"
        Dim ds As New DataSet
        dadapter = New MySqlDataAdapter(cmd)
        dadapter.Fill(ds)
        Dim col As New AutoCompleteStringCollection
        Dim i As Integer
        For i = 0 To ds.Tables(0).Rows.Count - 1
            col.Add(ds.Tables(0).Rows(i)("bk_ISBN").ToString)
        Next
        con.Close()
        txtISBN.AutoCompleteCustomSource = col
        txtISBN.AutoCompleteMode = AutoCompleteMode.Suggest
    End Sub
    Sub autocompletestudent()
        con.Open()
        cmd.Connection = con
        cmd.CommandText = "Select * from studenttbl where status = 'Active' order by borrower_id asc"
        Dim ds As New DataSet
        dadapter = New MySqlDataAdapter(cmd)
        dadapter.Fill(ds)
        Dim col As New AutoCompleteStringCollection
        Dim i As Integer
        For i = 0 To ds.Tables(0).Rows.Count - 1
            col.Add(ds.Tables(0).Rows(i)("borrower_id").ToString)
        Next
        con.Close()
        txtBorrowerID.AutoCompleteCustomSource = col
        txtBorrowerID.AutoCompleteMode = AutoCompleteMode.Suggest
    End Sub
    Sub autocompletebook2()
        con.Open()
        cmd.Connection = con
        cmd.CommandText = "Select * from booktbl order by bk_ISBN asc"
        Dim ds As New DataSet
        dadapter = New MySqlDataAdapter(cmd)
        dadapter.Fill(ds)
        Dim col As New AutoCompleteStringCollection
        Dim i As Integer
        For i = 0 To ds.Tables(0).Rows.Count - 1
            col.Add(ds.Tables(0).Rows(i)("bk_ISBN").ToString)
        Next
        con.Close()
        txtISBN2.AutoCompleteCustomSource = col
        txtISBN2.AutoCompleteMode = AutoCompleteMode.Suggest
    End Sub
    Sub autocompletestudent2()
        con.Open()
        cmd.Connection = con
        cmd.CommandText = "Select * from studenttbl where status = 'Active' order by borrower_id asc"
        Dim ds As New DataSet
        dadapter = New MySqlDataAdapter(cmd)
        dadapter.Fill(ds)
        Dim col As New AutoCompleteStringCollection
        Dim i As Integer
        For i = 0 To ds.Tables(0).Rows.Count - 1
            col.Add(ds.Tables(0).Rows(i)("borrower_id").ToString)
        Next
        con.Close()
        txtBorrower2.AutoCompleteCustomSource = col
        txtBorrower2.AutoCompleteMode = AutoCompleteMode.Suggest
    End Sub
    Private Sub txtISBN_TextChanged(sender As Object, e As EventArgs) Handles txtISBN.TextChanged '`tblbarcodes` where `human_status` = 'active' and `barcode` = '" & TextBox1.Text & "'
        Try
            sql = "Select booktbl.bk_ISBN, booktbl.bktitle, booktbl.bkedition, booktbl.bkauthor, booktbl.bkpublisher, booktbl.bkcopies, booktbl.bk_totalcopies, booktbl.bk_cost, booktbl.bk_remarks, booktbl.bk_publishdate, categorytbl.category_name FROM booktbl INNER JOIN categorytbl ON booktbl.bk_categoryid = categorytbl.category_id AND booktbl.bk_ISBN = '" & txtISBN.Text & "'"
            reloadtxt(sql)
            Dim cRow As Integer = 0
            If dat.Rows.Count = 0 Then
                'TextBox2.Text = ""
                'TextBox1.Text = ""
                'TextBox3.Text = ""
            Else
                'TextBox1.Text = dt.Rows(cRow).Item(2)
                'TextBox2.Text = dt.Rows(cRow).Item(1)
                'txtISBN.AutoCompleteCustomSource.Add(r.Item(0).ToString)
                'txtISBN.Text = dat.Rows(cRow).Item(0).ToString
                txtBookTitle.Text = dat.Rows(cRow).Item(1).ToString
                txtEdition.Text = dat.Rows(cRow).Item(2).ToString
                txtAuthor.Text = dat.Rows(cRow).Item(3).ToString
                txtPublisher.Text = dat.Rows(cRow).Item(4).ToString
                txtYear.Text = dat.Rows(cRow).Item(9).ToString
                txtCategory.Text = dat.Rows(cRow).Item(10).ToString
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub txtBorrowerID_TextChanged(sender As Object, e As EventArgs) Handles txtBorrowerID.TextChanged
        Try
            sql = "Select * FROM studenttbl where borrower_id = '" & txtBorrowerID.Text & "' and status = 'Active'"
            reloadtxt(sql)
            Dim cRow As Integer = 0
            If dat.Rows.Count = 0 Then
                'TextBox2.Text = ""
                'TextBox1.Text = ""
                'TextBox3.Text = ""
            Else
                txtStudentName.Text = dat.Rows(cRow).Item(1).ToString
                txtSectionStrand.Text = dat.Rows(cRow).Item(6).ToString
                txtGradeLevel.Text = dat.Rows(cRow).Item(5).ToString
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub frmBooks_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Me.Dispose()
        frmMain.Focus()
    End Sub

    Private Sub btnFetchBooks_Click(sender As Object, e As EventArgs) Handles btnFetchBooks.Click
        frmBookSearch2.Show()
    End Sub

    Private Sub btnNewRecord_Click(sender As Object, e As EventArgs) Handles btnNewRecord.Click
        Try
            'This clears all textboxes.
            'LOOP THE CONTROL IN THE FORM OF CONTROLS
            For Each txt As Control In Me.Controls
                'GETTING THE TYPE OF CONTROL WHICH IS A TEXTBOX
                If txt.GetType Is GetType(TextBox) Then
                    'CLEARING THE TEXTBOXES
                    txt.Text = Nothing
                End If
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnFetchBorrower_Click(sender As Object, e As EventArgs) Handles btnFetchBorrower.Click
        frmStudentSearch2.Show()
        frmStudentSearch2.Focus()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            Dim cmd As New MySqlCommand
            con.Open()
            cmd.Connection = con
            cmd.CommandText = "insert into borrowtbl (borrower_id, bk_ISBN, `borrowcopies_number`, `borrow_date`, `due_date`) values (@borrowerID, @bID, @copiesborrowed, @bDate, @dDate)"
            Dim c = cmd.Parameters
            'c.Clear()
            c.AddWithValue("borrowerID", txtBorrowerID.Text.Trim())
            c.AddWithValue("bID", txtISBN.Text.Trim())
            c.AddWithValue("copiesborrowed", "1")
            c.AddWithValue("bDate", dtpIssueDate.Value.Date)
            c.AddWithValue("dDate", dtpDueDate.Value.Date)
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            con.Close()
            MsgBox("Book successfully added to borrowed", MsgBoxStyle.OkOnly, "Book Borrowed")
            Me.BorrowtblTableAdapter.Fill(Me.Borrow.borrowtbl)

            Dim com As New MySqlCommand
            con.Open()
            com.Connection = con
            com.CommandText = "update booktbl set `bkcopies` = `bkcopies` - 1 where bk_ISBN =@ISBN"
            Dim co = com.Parameters
            'c.Clear()
            co.AddWithValue("ISBN", txtISBN.Text.Trim())

            com.ExecuteNonQuery()
            con.Close()

            'This clears all textboxes.

            Me.Focus()
        Catch ex As Exception
            MsgBox(ex.Message)
            Exit Sub
        End Try
    End Sub
    Private Sub btnUpdate_record_Click(sender As Object, e As EventArgs) Handles btnUpdate_record.Click
        Dim cmd As New MySqlCommand
        con.Open()
        cmd.Connection = con
        cmd.CommandText = "update borrowtbl set borrower_id = @borrowerID, bk_ISBN =@bID, `borrowcopies_number` =@copiesborrowed, `borrow_date` =@bDate, `due_date` =@dDate where borrower_id = @borrowerID"
        Dim c = cmd.Parameters
        'c.Clear()
        c.AddWithValue("borrowerID", txtBorrowerID.Text.Trim())
        c.AddWithValue("bID", txtISBN.Text.Trim())
        c.AddWithValue("copiesborrowed", "1")
        c.AddWithValue("bDate", dtpIssueDate.Value.Date)
        c.AddWithValue("dDate", dtpDueDate.Value.Date)
        cmd.ExecuteNonQuery()
        cmd.Dispose()
        con.Close()
        MsgBox("Data updated!", MsgBoxStyle.OkOnly, "Book Borrowed")
        Me.BorrowtblTableAdapter.Fill(Me.Borrow.borrowtbl)

        com.ExecuteNonQuery()
        con.Close()

        'This clears all textboxes.

        Me.Focus()
    End Sub
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Try
            Dim cmd As New MySqlCommand
            con.Open()
            cmd.Connection = con
            cmd.CommandText = "delete from borrowtbl where borrower_id = @borrowerID"
            Dim c = cmd.Parameters
            'c.Clear()
            c.AddWithValue("borrowerID", txtBorrowerID.Text.Trim())
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            con.Close()
            MsgBox("Book successfully added to borrowed", MsgBoxStyle.OkOnly, "Book Borrowed")
            Me.BorrowtblTableAdapter.Fill(Me.Borrow.borrowtbl)

            Dim com As New MySqlCommand
            con.Open()
            com.Connection = con
            com.CommandText = "update booktbl set `bkcopies` = `bkcopies` + 1 where bk_ISBN =@ISBN"
            Dim co = com.Parameters
            'c.Clear()
            co.AddWithValue("ISBN", txtISBN.Text.Trim())

            com.ExecuteNonQuery()
            con.Close()

            'This clears all textboxes.

            Me.Focus()
        Catch ex As Exception
            MsgBox(ex.Message)
            Exit Sub
        End Try
    End Sub
    'Return
    Private Sub btnNew2_Click(sender As Object, e As EventArgs) Handles btnNew2.Click

    End Sub

    Private Sub btnSave2_Click(sender As Object, e As EventArgs) Handles btnSave2.Click
        Try
            Dim cmd As New MySqlCommand
            con.Open()
            cmd.Connection = con
            cmd.CommandText = "insert into returntbl (borrower_id, bk_ISBN, `borrowcopies_number`, `borrow_date`, `due_date`, return_date, penalty) values (@borrowerID, @bID, @copiesborrowed, @bDate, @dDate, @rDate, @Penalty)"
            Dim c = cmd.Parameters
            'c.Clear()
            c.AddWithValue("borrowerID", txtBorrower2.Text.Trim())
            c.AddWithValue("bID", txtISBN2.Text.Trim())
            c.AddWithValue("copiesborrowed", "1")
            c.AddWithValue("bDate", dtpIssue2.Value.Date)
            c.AddWithValue("dDate", dtpDue2.Value.Date)
            c.AddWithValue("rDate", dtpReturn.Value.Date)
            c.AddWithValue("Penalty", Convert.ToDecimal(txtFine.Text))
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            con.Close()
            MsgBox("Book successfully returned", MsgBoxStyle.OkOnly, "Book Returned")
            Me.ReturntblTableAdapter.Fill(Me.Borrow.returntbl)

            Dim com As New MySqlCommand
            con.Open()
            com.Connection = con
            com.CommandText = "update booktbl set `bkcopies` = `bkcopies` + 1 where bk_ISBN =@ISBN"
            Dim co = com.Parameters
            'c.Clear()
            co.AddWithValue("ISBN", txtISBN2.Text.Trim())

            com.ExecuteNonQuery()
            con.Close()

            'This clears all textboxes.

            Me.Focus()
        Catch ex As Exception
            MsgBox(ex.Message)
            Exit Sub
        End Try
    End Sub

    Private Sub btnDelete2_Click(sender As Object, e As EventArgs) Handles btnDelete2.Click
        Try
            Dim cmd As New MySqlCommand
            con.Open()
            cmd.Connection = con
            cmd.CommandText = "delete from returntbl where borrower_id = @borrowerID"
            Dim c = cmd.Parameters
            'c.Clear()
            c.AddWithValue("borrowerID", txtBorrowerID.Text.Trim())
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            con.Close()
            MsgBox("Book successfully added to borrowed", MsgBoxStyle.OkOnly, "Book Borrowed")
            Me.ReturntblTableAdapter.Fill(Me.Borrow.returntbl)

            Dim com As New MySqlCommand
            con.Open()
            com.Connection = con
            com.CommandText = "update booktbl set `bkcopies` = `bkcopies` + 1 where bk_ISBN =@ISBN"
            Dim co = com.Parameters
            'c.Clear()
            co.AddWithValue("ISBN", txtISBN2.Text.Trim())

            com.ExecuteNonQuery()
            con.Close()

            'This clears all textboxes.

            Me.Focus()
        Catch ex As Exception
            MsgBox(ex.Message)
            Exit Sub
        End Try
    End Sub

    Private Sub btnUpdate2_Click(sender As Object, e As EventArgs) Handles btnUpdate2.Click
        Try
            Dim cmd As New MySqlCommand
            con.Open()
            cmd.Connection = con
            cmd.CommandText = "update returnbl set borrower_id = @borrowerID, bk_ISBN =@bID, `borrowcopies_number` =@copiesborrowed, `borrow_date` =@bDate, `due_date` =@dDate, return_date =@rDate, penalty =@Penalty where borrower_id = @borrowerID"
            Dim c = cmd.Parameters
            'c.Clear()
            c.AddWithValue("borrowerID", txtBorrower2.Text.Trim())
            c.AddWithValue("bID", txtISBN2.Text.Trim())
            c.AddWithValue("copiesborrowed", "1")
            c.AddWithValue("bDate", dtpIssue2.Value.Date)
            c.AddWithValue("dDate", dtpDue2.Value.Date)
            c.AddWithValue("rDate", dtpReturn.Value.Date)
            c.AddWithValue("Penalty", Convert.ToDecimal(txtFine.Text))
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            con.Close()
            MsgBox("Data updated!", MsgBoxStyle.OkOnly, "Book Borrowed")
            Me.ReturntblTableAdapter.Fill(Me.Borrow.returntbl)

            com.ExecuteNonQuery()
            con.Close()

            'This clears all textboxes.

            Me.Focus()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub barcodescanner_BarcodeScanned(sender As Object, e As BarcodeScannerEventArgs) Handles barcodescanner.BarcodeScanned
        txtISBN.Text = e.Barcode
    End Sub

    Private Sub DataGridView1_Click(sender As Object, e As EventArgs) Handles DataGridView1.Click
        Try
            'This is to insert the data from the datagridview to the "Student" groupboxes' textboxes and hides this winform.
            Dim r As DataGridViewRow = DataGridView1.CurrentRow
            If r.Index <> -1 Then
                txtISBN.Text = r.Cells(0).Value.ToString
                txtBookTitle.Text = r.Cells(1).Value.ToString
                txtAuthor.Text = r.Cells(2).Value.ToString
                txtBorrowerID.Text = r.Cells(3).Value.ToString
                txtStudentName.Text = r.Cells(4).Value.ToString
                'txtCopies.Text = r.Cells(5).Value.ToString
                dtpIssueDate.Text = r.Cells(6).Value.ToString
                dtpDueDate.Text = r.Cells(7).Value.ToString
                dtpReturn.Text = r.Cells(8).Value.ToString
                txtFine.Text = r.Cells(9).Value.ToString
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try

    End Sub
    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick

    End Sub
    Private Sub DataGridView2_Click(sender As Object, e As EventArgs) Handles DataGridView2.Click
        Try
            'This is to insert the data from the datagridview to the "Student" groupboxes' textboxes and hides this winform.
            Dim r As DataGridViewRow = DataGridView1.CurrentRow
            txtISBN.Text = r.Cells(0).Value.ToString
            txtBookTitle.Text = r.Cells(1).Value.ToString
            txtAuthor.Text = r.Cells(2).Value.ToString
            txtBorrowerID.Text = r.Cells(3).Value.ToString
            txtStudentName.Text = r.Cells(4).Value.ToString
            'txtCopies.Text = r.Cells(5).Value.ToString
            dtpIssueDate.Text = r.Cells(6).Value.ToString
            dtpDueDate.Text = r.Cells(7).Value.ToString
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub


    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        frmStudentSearch3.Show()
    End Sub

    Private Sub txtISBN2_TextChanged(sender As Object, e As EventArgs) Handles txtISBN2.TextChanged
        Try
            sql = "Select booktbl.bk_ISBN, booktbl.bktitle, booktbl.bkedition, booktbl.bkauthor, booktbl.bkpublisher, booktbl.bkcopies, booktbl.bk_totalcopies, booktbl.bk_cost, booktbl.bk_remarks, booktbl.bk_publishdate, categorytbl.category_name FROM booktbl INNER JOIN categorytbl ON booktbl.bk_categoryid = categorytbl.category_id AND booktbl.bk_ISBN = '" & txtISBN.Text & "'"
            reloadtxt(sql)
            Dim cRow As Integer = 0
            If dat.Rows.Count = 0 Then
                'TextBox2.Text = ""
                'TextBox1.Text = ""
                'TextBox3.Text = ""
            Else
                'TextBox1.Text = dt.Rows(cRow).Item(2)
                'TextBox2.Text = dt.Rows(cRow).Item(1)
                'txtISBN.AutoCompleteCustomSource.Add(r.Item(0).ToString)
                'txtISBN.Text = dat.Rows(cRow).Item(0).ToString
                txtTitle.Text = dat.Rows(cRow).Item(1).ToString
                txtEdition2.Text = dat.Rows(cRow).Item(2).ToString
                txtAuthor2.Text = dat.Rows(cRow).Item(3).ToString
                txtPub2.Text = dat.Rows(cRow).Item(4).ToString
                txtYearPub2.Text = dat.Rows(cRow).Item(9).ToString
                txtCat2.Text = dat.Rows(cRow).Item(10).ToString
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtBorrower2_TextChanged(sender As Object, e As EventArgs) Handles txtBorrower2.TextChanged
        Try
            sql = "Select * FROM studenttbl where borrower_id = '" & txtBorrower2.Text & "' and status = 'Active'"
            reloadtxt(sql)
            Dim cRow As Integer = 0
            If dat.Rows.Count = 0 Then
                'TextBox2.Text = ""
                'TextBox1.Text = ""
                'TextBox3.Text = ""
            Else
                txtStudentName2.Text = dat.Rows(cRow).Item(1).ToString
                txtSectionStrand2.Text = dat.Rows(cRow).Item(6).ToString
                txtGradeYear2.Text = dat.Rows(cRow).Item(5).ToString
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnBorrowedHistory.Click
        frmBorrowHistory.Show()
    End Sub

    Private Sub txtISBN2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtISBN2.KeyPress
        Try
            sql = "Select booktbl.bk_ISBN, booktbl.bktitle, booktbl.bkedition, booktbl.bkauthor, booktbl.bkpublisher, booktbl.bkcopies, booktbl.bk_totalcopies, booktbl.bk_cost, booktbl.bk_remarks, booktbl.bk_publishdate, categorytbl.category_name FROM booktbl INNER JOIN categorytbl ON booktbl.bk_categoryid = categorytbl.category_id AND booktbl.bk_ISBN = '" & txtISBN.Text & "'"
            reloadtxt(sql)
            Dim cRow As Integer = 0
            If dat.Rows.Count = 0 Then
                'TextBox2.Text = ""
                'TextBox1.Text = ""
                'TextBox3.Text = ""
            Else
                'TextBox1.Text = dt.Rows(cRow).Item(2)
                'TextBox2.Text = dt.Rows(cRow).Item(1)
                'txtISBN.AutoCompleteCustomSource.Add(r.Item(0).ToString)
                'txtISBN.Text = dat.Rows(cRow).Item(0).ToString
                txtTitle.Text = dat.Rows(cRow).Item(1).ToString
                txtEdition2.Text = dat.Rows(cRow).Item(2).ToString
                txtAuthor2.Text = dat.Rows(cRow).Item(3).ToString
                txtPub2.Text = dat.Rows(cRow).Item(4).ToString
                txtYearPub2.Text = dat.Rows(cRow).Item(9).ToString
                txtCat2.Text = dat.Rows(cRow).Item(10).ToString
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtBorrower2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtBorrower2.KeyPress
        Try
            sql = "Select * FROM studenttbl where borrower_id = '" & txtBorrower2.Text & "' and status = 'Active'"
            reloadtxt(sql)
            Dim cRow As Integer = 0
            If dat.Rows.Count = 0 Then
                'TextBox2.Text = ""
                'TextBox1.Text = ""
                'TextBox3.Text = ""
            Else
                txtStudentName2.Text = dat.Rows(cRow).Item(1).ToString
                txtSectionStrand2.Text = dat.Rows(cRow).Item(6).ToString
                txtGradeYear2.Text = dat.Rows(cRow).Item(5).ToString
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtISBN_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtISBN.KeyPress
        Try
            sql = "Select booktbl.bk_ISBN, booktbl.bktitle, booktbl.bkedition, booktbl.bkauthor, booktbl.bkpublisher, booktbl.bkcopies, booktbl.bk_totalcopies, booktbl.bk_cost, booktbl.bk_remarks, booktbl.bk_publishdate, categorytbl.category_name FROM booktbl INNER JOIN categorytbl ON booktbl.bk_categoryid = categorytbl.category_id AND booktbl.bk_ISBN = '" & txtISBN.Text & "'"
            reloadtxt(sql)
            Dim cRow As Integer = 0
            If dat.Rows.Count = 0 Then
                'TextBox2.Text = ""
                'TextBox1.Text = ""
                'TextBox3.Text = ""
            Else
                'TextBox1.Text = dt.Rows(cRow).Item(2)
                'TextBox2.Text = dt.Rows(cRow).Item(1)
                'txtISBN.AutoCompleteCustomSource.Add(r.Item(0).ToString)
                'txtISBN.Text = dat.Rows(cRow).Item(0).ToString
                txtBookTitle.Text = dat.Rows(cRow).Item(1).ToString
                txtEdition.Text = dat.Rows(cRow).Item(2).ToString
                txtAuthor.Text = dat.Rows(cRow).Item(3).ToString
                txtPublisher.Text = dat.Rows(cRow).Item(4).ToString
                txtYear.Text = dat.Rows(cRow).Item(9).ToString
                txtCategory.Text = dat.Rows(cRow).Item(10).ToString
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtBorrowerID_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtBorrowerID.KeyPress
        Try
            sql = "Select * FROM studenttbl where borrower_id = '" & txtBorrowerID.Text & "' and status = 'Active'"
            reloadtxt(sql)
            Dim cRow As Integer = 0
            If dat.Rows.Count = 0 Then
                'TextBox2.Text = ""
                'TextBox1.Text = ""
                'TextBox3.Text = ""
            Else
                txtStudentName.Text = dat.Rows(cRow).Item(1).ToString
                txtSectionStrand.Text = dat.Rows(cRow).Item(6).ToString
                txtGradeLevel.Text = dat.Rows(cRow).Item(5).ToString
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub













    'Private Sub txtCopies_TextChanged(sender As Object, e As EventArgs) Handles txtCopies.TextChanged
    '    If String.IsNullOrWhiteSpace(txtCopies.Text) Then
    '        MsgBox("Please enter amount.", MsgBoxStyle.OkOnly, "Error!")
    '    End If
    'End Sub

    'Private Sub txtCopies_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCopies.KeyPress
    '    If (Not Char.IsControl(e.KeyChar) AndAlso (Not Char.IsDigit(e.KeyChar) AndAlso
    '        (e.KeyChar <> Microsoft.VisualBasic.ChrW(46) AndAlso (Char.IsWhiteSpace(e.KeyChar))))) Then
    '        e.Handled = True
    '    End If
    'End Sub
End Class