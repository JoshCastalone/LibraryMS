Imports MySql.Data.MySqlClient
Public Class Form1
    Public con As MySqlConnection = strstrconnection()
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con.Open()
        cmd.Connection = con
        cmd.CommandText = "SELECT * from section_strandtbl"
        Dim msd As New MySqlDataAdapter(cmd)
        Dim dname As New DataTable()
        msd.Fill(dname)
        ComboBox1.ValueMember = "section_strandtbl_id"
        ComboBox1.DisplayMember = "section_strand_name"
        ComboBox1.DataSource = dname
        con.Close()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        lblDM.Text = ComboBox1.Text
        lblVM.Text = ComboBox1.SelectedValue
        Label3.Text = ComboBox1.Text
    End Sub
End Class