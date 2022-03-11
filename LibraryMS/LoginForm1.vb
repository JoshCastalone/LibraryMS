Imports System.ComponentModel
Imports MySql.Data.MySqlClient
Public Class LoginForm1
    Public con As MySqlConnection = strstrconnection()

    ' TODO: Insert code to perform custom authentication using the provided username and password 
    ' (See https://go.microsoft.com/fwlink/?LinkId=35339).  
    ' The custom principal can then be attached to the current thread's principal as follows: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' where CustomPrincipal is the IPrincipal implementation used to perform authentication. 
    ' Subsequently, My.User will return identity information encapsulated in the CustomPrincipal object
    ' such as the username, display name, etc.

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        'Me.Hide()
        'frmMain.Show()
        Try
            con.Open()
            'Dim cmd As New MySqlCommand("Select * from logform_tbl where un =@un and pass =@pass", con)
            Dim cmd As New MySqlCommand("Select * from usertbl where username =@un and pass =@pass", con)
            Dim c = cmd.Parameters
            'c.Clear()
            c.AddWithValue("un", UsernameTextBox.Text.Trim())
            c.AddWithValue("pass", PasswordTextBox.Text.Trim())
            cmd.ExecuteNonQuery()
            Dim dr = cmd.ExecuteReader
            If (dr.Read()) Then

                MessageBox.Show("Login successfully.", "Log-in")
                If UsernameTextBox.Text = "admin" Then
                    frmMain.ManageUsersToolStripMenuItem.Visible = True
                Else
                    frmMain.ManageUsersToolStripMenuItem.Visible = False
                End If
                frmMain.lblUser.Text = UsernameTextBox.Text
                frmMain.Show()
                Me.Hide()
            Else
                MessageBox.Show("Please check your username and password.", "Log-in")
                UsernameTextBox.Clear()
                PasswordTextBox.Clear()
            End If
            con.Close()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        End
    End Sub

    Private Sub LoginForm1_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        End
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub LoginForm1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class