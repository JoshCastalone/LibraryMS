Imports System.ComponentModel
Imports MySql.Data.MySqlClient
Imports MessagingToolkit.Barcode
Imports USB_Barcode_Scanner
Public Class frmBooks
    Public con As MySqlConnection = strstrconnection()
    Dim conn As New MySqlConnection
    Dim cmd As New MySqlCommand
    Dim dadapter As New MySqlDataAdapter
    Dim dt As New DataTable
    Dim dreader As MySqlDataReader
    Dim sql As String
    WithEvents barcodescanner As BarcodeScanner
    Private Sub frmBooks_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Test3DataSet.booktbl' table. You can move, or remove it, as needed.
        Me.BooktblTableAdapter.Fill(Me.Test3DataSet.booktbl)

        'This fetches the info from the category table and fills the combobox with values.
        con.Open()
        cmd.Connection = con
        cmd.CommandText = "SELECT * from categorytbl"
        Dim msd As New MySqlDataAdapter(cmd)
        Dim dname As New DataTable()
        msd.Fill(dname)
        cmbCategory.ValueMember = "category_id"
        cmbCategory.DisplayMember = "category_name"
        cmbCategory.DataSource = dname
        cmbCategory.Text = "Select category..."
        con.Close()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        'Deletes the selected entry from the database.
        Try
            MsgBox("Are you sure you want to delete this item?", MsgBoxStyle.YesNo, "Confirm Delete")
            If MsgBoxResult.Yes Then
                Dim cmd As New MySqlCommand
                con.Open()
                cmd.Connection = con
                cmd.CommandText = "Delete from booktbl where `bk_ISBN` =@ISBN"
                Dim c = cmd.Parameters
                'c.Clear()
                c.AddWithValue("ISBN", txtISBN.Text.Trim())
                cmd.ExecuteNonQuery()
                con.Close()
                MsgBox("Book successfully deleted!", MsgBoxStyle.OkOnly, "Book Deleted")
                Me.BooktblTableAdapter.Fill(Me.Test3DataSet.booktbl)

                'This fetches the info from the category table and fills the combobox with values.
                con.Open()
                cmd.Connection = con
                cmd.CommandText = "SELECT * from categorytbl"
                Dim msd As New MySqlDataAdapter(cmd)
                Dim dname As New DataTable()
                msd.Fill(dname)
                cmbCategory.ValueMember = "category_id"
                cmbCategory.DisplayMember = "category_name"
                cmbCategory.DataSource = dname
                cmbCategory.Text = "Select category..."
                con.Close()

                'This clears all textboxes.
                'LOOP THE CONTROL IN THE FORM OF CONTROLS
                For Each txt As Control In Me.Controls
                    'GETTING THE TYPE OF CONTROL WHICH IS A TEXTBOX
                    If txt.GetType Is GetType(TextBox) Then
                        'CLEARING THE TEXTBOXES
                        txt.Text = Nothing
                    End If
                Next
            Else
                Me.Focus()
            End If
        Catch ex As Exception
            MsgBox("Error occured: Could not insert record" & System.Environment.NewLine & ex.Message)
        End Try
    End Sub

    Private Sub btnInsert_Click(sender As Object, e As EventArgs) Handles btnInsert.Click
        'Inserts values on textboxes and selected item on combo box to the database.
        Try
            Dim cmd As New MySqlCommand
            con.Open()
            cmd.Connection = con
            cmd.CommandText = "insert into booktbl values (@ISBN, @Title, @Edition, @Author, @Publisher, @ACopies, @Total, @Cost, @Remarks, @PubDate, @Category)"
            Dim c = cmd.Parameters
            'c.Clear()
            c.AddWithValue("ISBN", txtISBN.Text.Trim())
            c.AddWithValue("Title", txtTitle.Text.Trim())
            c.AddWithValue("Edition", txtEdition.Text.Trim())
            c.AddWithValue("Author", txtAuthor.Text.Trim())
            c.AddWithValue("Publisher", txtPublisher.Text.Trim())
            c.AddWithValue("ACopies", txtAvail.Text.Trim())
            c.AddWithValue("Total", txtTotal.Text.Trim())
            c.AddWithValue("Cost", txtCost.Text.Trim())
            c.AddWithValue("Remarks", txtRemarks.Text.Trim())
            c.AddWithValue("PubDate", txtDatePub.Text.Trim())
            c.AddWithValue("Category", cmbCategory.SelectedValue)
            cmd.ExecuteNonQuery()
            con.Close()
            MsgBox("Book successfully added!", MsgBoxStyle.OkOnly, "Book Added")
            Me.BooktblTableAdapter.Fill(Me.Test3DataSet.booktbl)

            'This fetches the info from the category table and fills the combobox with values.
            con.Open()
            cmd.Connection = con
            cmd.CommandText = "SELECT * from categorytbl"
            Dim msd As New MySqlDataAdapter(cmd)
            Dim dname As New DataTable()
            msd.Fill(dname)
            cmbCategory.ValueMember = "category_id"
            cmbCategory.DisplayMember = "category_name"
            cmbCategory.DataSource = dname
            cmbCategory.Text = "Select category..."
            con.Close()

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
            MsgBox("Error occured: Could not insert record" & System.Environment.NewLine & ex.Message)
        End Try
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'Clears the text boxes and reloads the combobox.
        Try
            'This fetches the info from the category table and fills the combobox with values.
            con.Open()
            cmd.Connection = con
            cmd.CommandText = "SELECT * from categorytbl"
            Dim msd As New MySqlDataAdapter(cmd)
            Dim dname As New DataTable()
            msd.Fill(dname)
            cmbCategory.ValueMember = "category_id"
            cmbCategory.DisplayMember = "category_name"
            cmbCategory.DataSource = dname
            cmbCategory.Text = "Select category..."
            con.Close()

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
            MsgBox("Error occured: Could not insert record" & System.Environment.NewLine & ex.Message)
        End Try
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        'This updates the selected entry on the database.
        Try
            Dim cmd As New MySqlCommand
            con.Open()
            cmd.Connection = con
            cmd.CommandText = "update booktbl set bk_ISBN =@ISBN, bktitle =@Title, bkedition =@Edition, `bkauthor` =@Author, `bkpublisher` =@Publisher, `bkcopies` =@ACopies, `bk_totalcopies` =@Total, `bk_cost` =@Cost, `bk_remarks` =@Remarks, `bk_publishdate` =@PubDate, `bk_categoryid` =@Category where bk_ISBN =@ISBN"
            Dim c = cmd.Parameters
            'c.Clear()
            c.AddWithValue("ISBN", txtISBN.Text.Trim())
            c.AddWithValue("Title", txtTitle.Text.Trim())
            c.AddWithValue("Edition", txtEdition.Text.Trim())
            c.AddWithValue("Author", txtAuthor.Text.Trim())
            c.AddWithValue("Publisher", txtPublisher.Text.Trim())
            c.AddWithValue("ACopies", txtAvail.Text.Trim())
            c.AddWithValue("Total", txtTotal.Text.Trim())
            c.AddWithValue("Cost", txtCost.Text.Trim())
            c.AddWithValue("Remarks", txtRemarks.Text.Trim())
            c.AddWithValue("PubDate", txtDatePub.Text.Trim())
            c.AddWithValue("Category", cmbCategory.SelectedValue)
            cmd.ExecuteNonQuery()
            con.Close()
            MsgBox("Book successfully updated!", MsgBoxStyle.OkOnly, "Book Updated")
            Me.BooktblTableAdapter.Fill(Me.Test3DataSet.booktbl)

            'This fetches the info from the category table and fills the combobox with values.
            con.Open()
            cmd.Connection = con
            cmd.CommandText = "SELECT * from categorytbl"
            Dim msd As New MySqlDataAdapter(cmd)
            Dim dname As New DataTable()
            msd.Fill(dname)
            cmbCategory.ValueMember = "category_id"
            cmbCategory.DisplayMember = "category_name"
            cmbCategory.DataSource = dname
            cmbCategory.Text = "Select category..."
            con.Close()

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
            MsgBox("Error occured: Could not insert record" & System.Environment.NewLine & ex.Message)
        End Try
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim r = DataGridView1.CurrentRow
        If r.Index <> -1 Then
            txtISBN.Text = r.Cells(0).Value.ToString
            txtTitle.Text = r.Cells(1).Value.ToString
            txtEdition.Text = r.Cells(2).Value.ToString
            txtAuthor.Text = r.Cells(3).Value.ToString
            txtPublisher.Text = r.Cells(4).Value.ToString
            txtAvail.Text = r.Cells(5).Value.ToString
            txtTotal.Text = r.Cells(6).Value.ToString
            txtCost.Text = r.Cells(7).Value.ToString
            txtRemarks.Text = r.Cells(8).Value.ToString
            txtDatePub.Text = r.Cells(9).Value.ToString
            cmbCategory.Text = r.Cells(10).Value.ToString
        End If
    End Sub

    Private Sub frmBooks_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Me.Dispose()
    End Sub

    Private Sub btnBarcode_Click(sender As Object, e As EventArgs) Handles btnBarcode.Click
        If txtISBN.Text = "" Then
            MessageBox.Show("Empty field!")
        Else
            Try
                Dim generator As New BarcodeEncoder
                generator.BackColor = Color.White
                generator.IncludeLabel = True
                generator.CustomLabel = txtTitle.Text & " " & txtAuthor.Text
                frmBarcode.PictureBox1.Image = New Bitmap(generator.Encode(BarcodeFormat.ISBN, txtISBN.Text))
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            frmBarcode.Show()
        End If

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
                txtISBN.Text = dat.Rows(cRow).Item(0).ToString
                txtTitle.Text = dat.Rows(cRow).Item(1).ToString
                txtEdition.Text = dat.Rows(cRow).Item(2).ToString
                txtAuthor.Text = dat.Rows(cRow).Item(3).ToString
                txtPublisher.Text = dat.Rows(cRow).Item(4).ToString
                txtAvail.Text = dat.Rows(cRow).Item(5).ToString
                txtTotal.Text = dat.Rows(cRow).Item(6).ToString
                txtCost.Text = dat.Rows(cRow).Item(7).ToString
                txtRemarks.Text = dat.Rows(cRow).Item(8).ToString
                txtDatePub.Text = dat.Rows(cRow).Item(9).ToString
                cmbCategory.Text = dat.Rows(cRow).Item(10).ToString
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class
'“Never think that war, no matter how necessary, nor how justified, is not a crime.”
'— Ernest Hemingway, 1946
'Reference: Jueun Choi. (2017, April 4). “Never think that war ... is not a crime,” and more defining WWI quotes. USA TODAY;
'USA TODAY. https://www.usatoday.com/story/news/world/2017/04/04/world-war-i-quotes/100031552/
'Retrieved at March 2, 2022 9:52 PM
' #PrayForUkraine
