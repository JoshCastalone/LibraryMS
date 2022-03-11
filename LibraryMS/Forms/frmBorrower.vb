Imports System.ComponentModel
Imports MySql.Data.MySqlClient
Public Class frmBorrower
    Public con As MySqlConnection = strstrconnection()
    Dim gender As String
    'This clears all fields in the winform.
    Private Sub btnNewRecord_Click(sender As Object, e As EventArgs) Handles btnNewRecord.Click
        txtAcademicYear.Clear()
        txtAddress.Clear()
        txtBorrowerID.Clear()
        txtEmail.Clear()
        txtMobileNo.Clear()
        txtPhoneNo.Clear()
        txtStudentID.Clear()
        txtStudentName.Clear()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        'This inserts the values from the winform into the Student table.
        Try
            Dim cmd As New MySqlCommand
            con.Open()
            cmd.Connection = con
            cmd.CommandText = "insert into studenttbl values (@sID, @sName, @gender, @bID, @BDay, @gLevel, @SS, @Add, @contact, @mobile, @academic, @email, @status)"
            Dim c = cmd.Parameters
            'c.Clear()
            c.AddWithValue("sID", txtStudentID.Text.Trim())
            c.AddWithValue("sName", txtStudentName.Text.Trim())
            c.AddWithValue("gender", cmbGender.Text.Trim())
            c.AddWithValue("bID", txtBorrowerID.Text.Trim())
            c.AddWithValue("BDay", dtpDOB.Value.Date)
            c.AddWithValue("gLevel", cmbGradeLevel.SelectedValue())
            c.AddWithValue("SS", cmbSectionStrand.Text.Trim)
            c.AddWithValue("Add", txtAddress.Text.Trim())
            c.AddWithValue("contact", txtPhoneNo.Text.Trim())
            c.AddWithValue("mobile", txtMobileNo.Text.Trim())
            c.AddWithValue("academic", txtAcademicYear.Text.Trim())
            c.AddWithValue("email", txtEmail.Text.Trim)
            c.AddWithValue("status", "Active")
            cmd.ExecuteNonQuery()
            con.Close()
            MsgBox("Student successfully added", MsgBoxStyle.OkOnly, "Student Added")

            'This clears all textboxes.
            txtAcademicYear.Clear()
            txtAddress.Clear()
            txtBorrowerID.Clear()
            txtEmail.Clear()
            txtMobileNo.Clear()
            txtPhoneNo.Clear()
            txtStudentID.Clear()
            txtStudentName.Clear()
            Me.Focus()
            'refreshcombo()
        Catch ex As Exception
            MsgBox("Error occured: Could not insert record" & System.Environment.NewLine & ex.Message)
        End Try
    End Sub

    Private Sub btnDisable_Click(sender As Object, e As EventArgs) Handles btnDisable.Click
        'This sets the student's status to "Inactive"
        Try
            MsgBox("Are you sure you want to delete this student?", MsgBoxStyle.YesNo, "Confirm Delete")
            If MsgBoxResult.Yes Then
                Dim cmd As New MySqlCommand
                con.Open()
                cmd.Connection = con
                cmd.CommandText = "Update studenttbl set `status` =@status where `studentid` =@sID"
                Dim c = cmd.Parameters
                'c.Clear()
                c.AddWithValue("sID", txtStudentID.Text.Trim())
                c.AddWithValue("status", "Inactive")
                cmd.ExecuteNonQuery()
                con.Close()
                MsgBox("Student successfully deleted", MsgBoxStyle.OkOnly, "Student Deleted")
                'Me.BooktblTableAdapter.Fill(Me.Test3DataSet.booktbl)

                'This clears all textboxes.
                txtAcademicYear.Clear()
                txtAddress.Clear()
                txtBorrowerID.Clear()
                txtEmail.Clear()
                txtMobileNo.Clear()
                txtPhoneNo.Clear()
                txtStudentID.Clear()
                txtStudentName.Clear()
            Else
                Me.Focus()
                'refreshcombo()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnUpdate_record_Click(sender As Object, e As EventArgs) Handles btnUpdate_record.Click
        'This updates the values from the Student table.
        Try
            Dim cmd As New MySqlCommand
            con.Open()
            cmd.Connection = con
            cmd.CommandText = "Update studenttbl set `studentid` =@sID, `student_name` =@sName, `Sex` =@gender, `borrower_id` =@bID, `birthdate` =@BDay, `Grade_level` =@gLevel, `Section_strand` =@SS, `Address` =@Add, `contact_no` =@contact, `MobileNo` =@mobile, `AcademicYear` =@academic, `email` =@email where `studentid` =@sID"
            Dim c = cmd.Parameters
            'c.Clear()
            c.AddWithValue("sID", txtStudentID.Text.Trim())
            c.AddWithValue("sName", txtStudentName.Text.Trim())
            c.AddWithValue("gender", cmbGender.Text.Trim())
            c.AddWithValue("bID", txtBorrowerID.Text.Trim())
            c.AddWithValue("BDay", dtpDOB.Value.Date())
            c.AddWithValue("gLevel", cmbGradeLevel.SelectedValue)
            c.AddWithValue("SS", cmbSectionStrand.Text.Trim())
            c.AddWithValue("Add", txtAddress.Text.Trim())
            c.AddWithValue("contact", txtPhoneNo.Text.Trim())
            c.AddWithValue("mobile", txtMobileNo.Text.Trim())
            c.AddWithValue("academic", txtAcademicYear.Text.Trim())
            c.AddWithValue("email", txtEmail.Text.Trim)
            cmd.ExecuteNonQuery()
            con.Close()
            MsgBox("Student successfully updated", MsgBoxStyle.OkOnly, "Student Updated")

            'This clears all textboxes.
            txtAcademicYear.Clear()
            txtAddress.Clear()
            txtBorrowerID.Clear()
            txtEmail.Clear()
            txtMobileNo.Clear()
            txtPhoneNo.Clear()
            txtStudentID.Clear()
            txtStudentName.Clear()
            'refreshcombo()
            Me.Focus()
        Catch ex As Exception
            MsgBox("Error occured: Could not insert record")
        End Try
    End Sub

    Private Sub frmBorrower_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        refreshcombo()
    End Sub

    Private Sub txtEmail_Validating(sender As Object, e As CancelEventArgs) Handles txtEmail.Validating
        Dim rEMail As New System.Text.RegularExpressions.Regex("^[a-zA-Z][\w\.-]{2,28}[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$")
        If txtEmail.Text.Length > 0 Then
            If Not rEMail.IsMatch(txtEmail.Text) Then
                MessageBox.Show("invalid email address", "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
                txtEmail.SelectAll()
                e.Cancel = True
            End If
        End If
    End Sub

    Private Sub txtMobileNo_Validating(sender As Object, e As CancelEventArgs) Handles txtMobileNo.Validating
        If (txtMobileNo.TextLength > 10) Then
            MessageBox.Show("Only 10 digits are allowed", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtMobileNo.Focus()
        End If
    End Sub

    Private Sub txtMobileNo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtMobileNo.KeyPress
        If (e.KeyChar < Chr(48) Or e.KeyChar > Chr(57)) And e.KeyChar <> Chr(8) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtPhoneNo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPhoneNo.KeyPress
        If (e.KeyChar < Chr(48) Or e.KeyChar > Chr(57)) And e.KeyChar <> Chr(8) Then
            e.Handled = True
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        frmStudentSearch.Show()
    End Sub

    Public Sub refreshcombo()
        'This fetches the info from the category table and fills the combobox with values.
        con.Open()
        cmd.Connection = con
        cmd.CommandText = "SELECT * from section_strandtbl"
        Dim msd As New MySqlDataAdapter(cmd)
        Dim dname As New DataTable()
        msd.Fill(dname)
        cmbSectionStrand.ValueMember = "section_strandtbl_id"
        cmbSectionStrand.DisplayMember = "section_strand_name"
        cmbSectionStrand.DataSource = dname
        cmbSectionStrand.Text = ""
        con.Close()

        'This fetches the info from the gradelevel_tbl table and fills the combobox with values.
        con.Open()
        cmd.Connection = con
        cmd.CommandText = "SELECT * from gradelevel_tbl"
        Dim sda As New MySqlDataAdapter(cmd)
        Dim dtable As New DataTable()
        msd.Fill(dtable)
        cmbGradeLevel.ValueMember = "gradelevel_id"
        cmbGradeLevel.DisplayMember = "gradelevel_name"
        cmbGradeLevel.DataSource = dtable
        cmbGradeLevel.Text = ""
        con.Close()
    End Sub
End Class