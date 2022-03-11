Imports System.ComponentModel
Imports MySql.Data.MySqlClient
Public Class frmUsers
    Public con As MySqlConnection = strstrconnection()
    Private Sub frmUsers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet1.usertbl' table. You can move, or remove it, as needed.
        Me.UsertblTableAdapter.Fill(Me.DataSet1.usertbl)

        'This fetches data from usertbl and fills the combobox.
        con.Open()
        cmd.Connection = con
        cmd.CommandText = "SELECT * from usertbl"
        Dim msd As New MySqlDataAdapter(cmd)
        Dim dname As New DataTable()
        msd.Fill(dname)
        cmbRoles.ValueMember = "role"
        'cmbRoles.DisplayMember = "role"
        cmbRoles.DataSource = dname
        cmbRoles.Text = "Select User Type..."
        con.Close()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        'This adds the user into both `usertbl` tables.
        Try
            Dim cmd As New MySqlCommand
            con.Open()
            cmd.Connection = con
            'cmd.CommandText = "insert into booktbl values (@ISBN, @Title, @Edition, @Author, @Publisher, @ACopies, @Total, @Cost, @Remarks, @PubDate, @Category)"
            cmd.CommandText = "insert into usertbl values (@FName, @LName, @UName, @Password, @Role, @Status)"
            Dim c = cmd.Parameters
            'c.Clear()
            c.AddWithValue("FName", txtFName.Text.Trim())
            c.AddWithValue("LName", txtLName.Text.Trim())
            c.AddWithValue("UName", txtUName.Text.Trim())
            c.AddWithValue("Password", txtPass.Text.Trim())
            c.AddWithValue("Role", cmbRoles.SelectedValue)
            c.AddWithValue("Status", "Active")
            cmd.ExecuteNonQuery()
            con.Close()
            MsgBox("Book successfully updated!", MsgBoxStyle.OkOnly, "Book Updated")
            Me.UsertblTableAdapter.Fill(Me.DataSet1.usertbl)

            'This fetches data from usertbl and fills the combobox.
            con.Open()
            cmd.Connection = con
            cmd.CommandText = "SELECT * from usertbl"
            Dim msd As New MySqlDataAdapter(cmd)
            Dim dname As New DataTable()
            msd.Fill(dname)
            cmbRoles.ValueMember = "role"
            'cmbRoles.DisplayMember = "role"
            cmbRoles.DataSource = dname
            cmbRoles.Text = "Select User Type..."
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

        End Try
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        'This updates the selected user's info.
        Try
            Dim cmd As New MySqlCommand
            con.Open()
            cmd.Connection = con
            cmd.CommandText = "update usertbl set Fname =@FName, Lname =@LName, username =@UName, pass =@Password, role =@Role, status = 'Active' where Fname =@FName"
            'cmd.CommandText = "update booktbl set bk_ISBN =@ISBN, bktitle =@Title, bkedition =@Edition, `bkauthor` =@Author, `bkpublisher` =@Publisher, `bkcopies` =@ACopies, `bk_totalcopies` =@Total, `bk_cost` =@Cost, `bk_remarks` =@Remarks, `bk_publishdate` =@PubDate, `bk_categoryid` =@Category where bk_ISBN =@ISBN"
            Dim c = cmd.Parameters
            'c.Clear()
            c.AddWithValue("FName", txtFName.Text.Trim())
            c.AddWithValue("LName", txtLName.Text.Trim())
            c.AddWithValue("UName", txtUName.Text.Trim())
            c.AddWithValue("Password", txtPass.Text.Trim())
            c.AddWithValue("Role", cmbRoles.SelectedValue)
            cmd.ExecuteNonQuery()
            con.Close()
            MsgBox("User successfully added!", MsgBoxStyle.OkOnly, "User Added")
            Me.UsertblTableAdapter.Fill(Me.DataSet1.usertbl)

            'This fetches data from usertbl and fills the combobox.
            con.Open()
            cmd.Connection = con
            cmd.CommandText = "SELECT * from usertbl"
            Dim msd As New MySqlDataAdapter(cmd)
            Dim dname As New DataTable()
            msd.Fill(dname)
            cmbRoles.ValueMember = "role"
            'cmbRoles.DisplayMember = "role"
            cmbRoles.DataSource = dname
            cmbRoles.Text = "Select User Type..."
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

        End Try
    End Sub

    Private Sub btnDisable_Click(sender As Object, e As EventArgs) Handles btnDisable.Click
        'This disables the selected user.
        Try
            Dim cmd As New MySqlCommand
            con.Open()
            cmd.Connection = con
            cmd.CommandText = "update usertbl set Fname =@FName, Lname =@LName, username =@UName, pass =@Password, role =@Role, status = 'Inactive' where Fname =@FName"
            'cmd.CommandText = "update booktbl set bk_ISBN =@ISBN, bktitle =@Title, bkedition =@Edition, `bkauthor` =@Author, `bkpublisher` =@Publisher, `bkcopies` =@ACopies, `bk_totalcopies` =@Total, `bk_cost` =@Cost, `bk_remarks` =@Remarks, `bk_publishdate` =@PubDate, `bk_categoryid` =@Category where bk_ISBN =@ISBN"
            Dim c = cmd.Parameters
            'c.Clear()
            c.AddWithValue("FName", txtFName.Text.Trim())
            c.AddWithValue("LName", txtLName.Text.Trim())
            c.AddWithValue("UName", txtUName.Text.Trim())
            c.AddWithValue("Password", txtPass.Text.Trim())
            c.AddWithValue("Role", cmbRoles.SelectedValue)
            cmd.ExecuteNonQuery()
            con.Close()
            MsgBox("User successfully added!", MsgBoxStyle.OkOnly, "User Added")
            Me.UsertblTableAdapter.Fill(Me.DataSet1.usertbl)

            'This fetches data from usertbl and fills the combobox.
            con.Open()
            cmd.Connection = con
            cmd.CommandText = "SELECT * from usertbl"
            Dim msd As New MySqlDataAdapter(cmd)
            Dim dname As New DataTable()
            msd.Fill(dname)
            cmbRoles.ValueMember = "role"
            'cmbRoles.DisplayMember = "role"
            cmbRoles.DataSource = dname
            cmbRoles.Text = "Select User Type..."
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

        End Try
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        'This fetches data from usertbl and fills the combobox.
        con.Open()
        cmd.Connection = con
        cmd.CommandText = "SELECT * from usertbl"
        Dim msd As New MySqlDataAdapter(cmd)
        Dim dname As New DataTable()
        msd.Fill(dname)
        cmbRoles.ValueMember = "role"
        'cmbRoles.DisplayMember = "role"
        cmbRoles.DataSource = dname
        cmbRoles.Text = "Select User Type..."
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
    End Sub

    Private Sub dgvUsers_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvUsers.CellClick
        Dim r = dgvUsers.CurrentRow
        If r.Index <> -1 Then
            txtFName.Text = r.Cells(0).Value.ToString
            txtLName.Text = r.Cells(1).Value.ToString
            txtUName.Text = r.Cells(2).Value.ToString
            txtPass.Text = r.Cells(3).Value.ToString
            cmbRoles.Text = r.Cells(4).Value.ToString
        End If
    End Sub

    Private Sub frmUsers_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Me.Dispose()
    End Sub
End Class
'I would like to thank the sponsors: My parents, my siblings, the entire internet and special thanks to: 
'*Alestorm
'*SB19 (Stream Pagsibol EP, Felip's Palayo, and Pablo's La Luna)
'*Treasure (stream Jikjin)
'*Versailles ~Philharmonic Quintet~
'*L'Arc~en~Ciel