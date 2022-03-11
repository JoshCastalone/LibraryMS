Imports System.ComponentModel

Public Class frmGradeLevel
    Private Sub frmGradeLevel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet2.gradelevel_tbl' table. You can move, or remove it, as needed.
        Me.Gradelevel_tblTableAdapter.Fill(Me.DataSet2.gradelevel_tbl)

    End Sub

    Private Sub btnInsert_Click(sender As Object, e As EventArgs) Handles btnInsert.Click
        If txtGradeNo.Text = "" Or txtGradeName.Text = "" Then
            emptymessage()
        Else
            create("Insert into `gradelevel_tbl`(`gradelevel_id`, `gradelevel_name`) values ('" & txtGradeNo.Text.Trim & "', '" & txtGradeName.Text.Trim & "')")
            Me.Gradelevel_tblTableAdapter.Fill(Me.DataSet2.gradelevel_tbl)
            'This clears all textboxes.
            'LOOP THE CONTROL IN THE FORM OF CONTROLS
            For Each txt As Control In Me.Controls
                'GETTING THE TYPE OF CONTROL WHICH IS A TEXTBOX
                If txt.GetType Is GetType(TextBox) Then
                    'CLEARING THE TEXTBOXES
                    txt.Text = Nothing
                End If
            Next
            Me.Focus()
        End If
    End Sub
    Private Sub dtgGradeLevel_Click(sender As Object, e As EventArgs) Handles dtgGradeLevel.Click
        txtGradeNo.Text = dtgGradeLevel.CurrentRow.Cells(0).Value
        txtGradeName.Text = dtgGradeLevel.CurrentRow.Cells(1).Value
    End Sub

    Private Sub txtGradeNo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtGradeNo.KeyPress
        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) And Not e.KeyChar = "." And Not Char.IsWhiteSpace(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        updates("Update `gradelevel_tbl` set `gradelevel_id` = '" & txtGradeNo.Text.Trim & "', `gradelevel_name` = '" & txtGradeName.Text.Trim & "' where `gradelevel_id` = '" & txtGradeNo.Text.Trim & "'")
        Me.Gradelevel_tblTableAdapter.Fill(Me.DataSet2.gradelevel_tbl)
        'This clears all textboxes.
        'LOOP THE CONTROL IN THE FORM OF CONTROLS
        For Each txt As Control In Me.Controls
            'GETTING THE TYPE OF CONTROL WHICH IS A TEXTBOX
            If txt.GetType Is GetType(TextBox) Then
                'CLEARING THE TEXTBOXES
                txt.Text = Nothing
            End If
        Next
        Me.Focus()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        delete("delete from gradelevel_tbl where `gradelevel_id` = '" & txtGradeNo.Text.Trim & "'")
        Me.Gradelevel_tblTableAdapter.Fill(Me.DataSet2.gradelevel_tbl)
        'This clears all textboxes.
        'LOOP THE CONTROL IN THE FORM OF CONTROLS
        For Each txt As Control In Me.Controls
            'GETTING THE TYPE OF CONTROL WHICH IS A TEXTBOX
            If txt.GetType Is GetType(TextBox) Then
                'CLEARING THE TEXTBOXES
                txt.Text = Nothing
            End If
        Next
        Me.Focus()
    End Sub

    Private Sub frmGradeLevel_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Me.Dispose()
    End Sub
End Class