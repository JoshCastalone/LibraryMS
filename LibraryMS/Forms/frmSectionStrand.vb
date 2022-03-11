Public Class frmSectionStrand
    Private Sub frmSectionStrand_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet2.section_strandtbl' table. You can move, or remove it, as needed.
        Me.Section_strandtblTableAdapter.Fill(Me.DataSet2.section_strandtbl)

    End Sub

    Private Sub dtgSecStrand_Click(sender As Object, e As EventArgs) Handles dtgSecStrand.Click
        txtSSID.Text = dtgSecStrand.CurrentRow.Cells(0).Value
        txtSSName.Text = dtgSecStrand.CurrentRow.Cells(1).Value
    End Sub

    Private Sub txtSSID_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSSID.KeyPress
        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) And Not e.KeyChar = "." And Not Char.IsWhiteSpace(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub btnInsert_Click(sender As Object, e As EventArgs) Handles btnInsert.Click
        Try
            If txtSSID.Text = "" Or txtSSName.Text = "" Then
                emptymessage()
            Else
                create("Insert into `section_strandtbl`(`section_strandtbl_id`, `section_strand_name`) values ('" & txtSSID.Text.Trim & "', '" & txtSSName.Text.Trim & "')")
                Me.Section_strandtblTableAdapter.Fill(Me.DataSet2.section_strandtbl)
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
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        updates("Update `section_strandtbl` set `section_strandtbl_id` = '" & txtSSID.Text.Trim & "', `section_strand_name` = '" & txtSSName.Text.Trim & "' where `section_strandtbl_id` = '" & txtSSID.Text.Trim & "'")
        Me.Section_strandtblTableAdapter.Fill(Me.DataSet2.section_strandtbl)
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
        delete("delete from `section_strandtbl` where `section_strandtbl_id` = '" & txtSSID.Text.Trim & "'")
        Me.Section_strandtblTableAdapter.Fill(Me.DataSet2.section_strandtbl)
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
End Class
' "I can turn the lights out now..."
' - Lights Out (Rick Astley)