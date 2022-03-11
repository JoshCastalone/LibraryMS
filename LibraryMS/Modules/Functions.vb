Imports MySql.Data.MySqlClient
Module Functions
    Public con As MySqlConnection = strstrconnection()
    Public result As String
    Public com As New MySqlCommand
    Public data As New MySqlDataAdapter
    Public dat As New DataTable
    Public inc As Integer = 0
    Public maxrows As Integer
    Public sql As String
    Public Sub reloadtxt(ByVal sql As String)
        Try
            con.Open()
            With com
                .Connection = strcon
                .CommandText = sql
            End With
            dat = New DataTable
            data = New MySqlDataAdapter(sql, con)
            data.Fill(dat)

        Catch ex As Exception
            '   MsgBox(ex.Message)
        Finally

            con.Close()
            data.Dispose()

        End Try
    End Sub
    Public Sub cleartext(ByVal group As Object)
        For Each ctrl As Control In group.Controls
            If ctrl.GetType Is GetType(TextBox) Then
                ctrl.Text = Nothing
                ctrl.Enabled = True
            End If
        Next
    End Sub
    Public Sub emptymessage()
        MsgBox("There are empty fields left that must be filled up!", MsgBoxStyle.Exclamation)
    End Sub
    Public Sub autofill(ByVal sql As String, ByVal txt As Object)
        Try
            con.Open()
            With com
                .Connection = con
                .CommandText = sql
            End With
            dat = New DataTable
            data.SelectCommand = com
            data.Fill(dat)
            Dim row As DataRow
            txt.AutoCompleteCustomSource.Clear()
            For Each row In dt.Rows
                txt.AutoCompleteCustomSource.Add(row.Item(0).ToString)
            Next
        Catch ex As Exception

        End Try
    End Sub
    Public Sub append(ByVal sql As String, ByVal field As String, ByVal txt As Object)
        reloadtxt(sql)
        Try
            Dim row As DataRow
            txt.AutoCompleteCustomSource.Clear()
            For Each row In dat.Rows
                txt.AutoCompleteCustomSource.Add(row.Item(field).ToString)
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub firstload(ByVal frm As frmTransaction)
        reloadtxt(sql)
        Try
            append("Select ISBN from booktbl", "ISBN", frmTransaction.txtISBN.Text)
            sql = "SELECT booktbl.bk_ISBN, booktbl.bktitle, booktbl.bkedition, booktbl.bkauthor, booktbl.bkpublisher, booktbl.bkcopies, booktbl.bk_totalcopies, booktbl.bk_cost, booktbl.bk_remarks, booktbl.bk_publishdate, categorytbl.category_name FROM booktbl INNER JOIN categorytbl ON booktbl.bk_categoryid = categorytbl.category_id"
            'reload(sql, frmBookSearch2.DataGridView4)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

End Module
