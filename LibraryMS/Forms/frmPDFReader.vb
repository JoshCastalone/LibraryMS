Imports MySql.Data.MySqlClient
Public Class frmPDFReader
    Dim con As MySqlConnection = New MySqlConnection("server=localhost;user id=root;password=BananaF1Sh;database=test3;sslMode=none")
    Dim cmd As MySqlCommand
    Dim da As MySqlDataAdapter
    Dim dt As DataTable
    Dim sql As String
    Private Sub btnView_Click(sender As Object, e As EventArgs) Handles btnView.Click
        Try
            con.Open()
            sql = "SELECT * FROM tblfiles WHERE FileId=" & DataGridView1.CurrentRow.Cells(0).Value
            cmd = New MySqlCommand
            With cmd
                .Connection = con
                .CommandText = sql
            End With
            da = New MySqlDataAdapter
            dt = New DataTable
            da.SelectCommand = cmd
            da.Fill(dt)

            With frmPDFReader2
                .Show()
                .Focus()
                .AxAcroPDF1.src = Application.StartupPath & "\PDF_Files\" & dt.Rows(0).Item("FileName")
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            da.Dispose()
            con.Close()
        End Try
    End Sub

    Private Sub btnUpload_Click(sender As Object, e As EventArgs) Handles btnUpload.Click
        btnBrowse.Enabled = False
        Timer1.Start()
    End Sub

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        Try
            OpenFileDialog1.Filter = "PDF | *.pdf"
            If OpenFileDialog1.ShowDialog = DialogResult.OK Then
                TextBox1.Text = OpenFileDialog1.FileName
                btnUpload.Enabled = True
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Try
            ProgressBar1.Value += 1
            If ProgressBar1.Value = 100 Then
                Timer1.Stop()
                btnBrowse.Enabled = True
                con.Open()
                sql = "INSERT INTO `tblfiles` (`FileName`) VALUES ('" & System.IO.Path.GetFileName(TextBox1.Text) & "')"

                cmd = New MySqlCommand
                With cmd
                    .Connection = con
                    .CommandText = sql
                    .ExecuteNonQuery()
                End With

                If TextBox1.Text <> "" Then
                    System.IO.File.Copy(TextBox1.Text, Application.StartupPath & "\PDF_Files\" & System.IO.Path.GetFileName(TextBox1.Text), True)
                End If
                MsgBox("Scanned file uploaded successfully.")


                TextBox1.Clear()
                ProgressBar1.Value = 0
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
        'call to retrieve file
        Call frmPDFReader_Load(sender, e)
    End Sub

    Private Sub frmPDFReader_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            System.IO.Directory.CreateDirectory(Application.StartupPath & "\PDF_Files\")
            btnUpload.Enabled = False
            con.Open()
            sql = "SELECT * FROM tblfiles"
            cmd = New MySqlCommand
            With cmd
                .Connection = con
                .CommandText = sql
            End With
            da = New MySqlDataAdapter
            dt = New DataTable
            da.SelectCommand = cmd
            da.Fill(dt)

            DataGridView1.DataSource = dt

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            da.Dispose()
        con.Close()
        End Try
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Try
            MsgBox("Are you sure you want to delete this item?", MsgBoxStyle.YesNo, "Confirm Delete")
            If MsgBoxResult.Yes Then
                System.IO.File.Delete(Application.StartupPath & "\PDF_Files\" & dt.Rows(0).Item("FileName"))
                delete("delete from tblfiles where FileId=" & DataGridView1.CurrentRow.Cells(0).Value)
                Try
                    con.Open()
                    sql = "SELECT * FROM tblfiles"
                    cmd = New MySqlCommand
                    With cmd
                        .Connection = con
                        .CommandText = sql
                    End With
                    da = New MySqlDataAdapter
                    dt = New DataTable
                    da.SelectCommand = cmd
                    da.Fill(dt)

                    DataGridView1.DataSource = dt

                Catch ex As Exception
                    MsgBox(ex.Message)
                Finally
                    da.Dispose()
                    con.Close()
                    'MsgBox("Book successfully deleted!", MsgBoxStyle.OkOnly, "Book Deleted")
                End Try
            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub btnOpen_Click(sender As Object, e As EventArgs) Handles btnOpen.Click
        System.Diagnostics.Process.Start(Application.StartupPath & "\PDF_Files\")
    End Sub
End Class