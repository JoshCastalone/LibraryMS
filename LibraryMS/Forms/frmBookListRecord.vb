Public Class frmBookListRecord
    'Well, this took my whole Saturday haha!
    Private Sub frmBookListRecord_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Test3DataSet.booktbl' table. You can move, or remove it, as needed.
        Me.BooktblTableAdapter.Fill(Me.Test3DataSet.booktbl)

        Me.ReportViewer1.RefreshReport()
    End Sub

    'This disables the Close button on this form. 
    Protected Overrides ReadOnly Property CreateParams As CreateParams
        Get
            Dim parms As CreateParams = MyBase.CreateParams
            parms.ClassStyle = parms.ClassStyle Or &H200  ' CS_NOCLOSE
            Return parms
        End Get
    End Property

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Dispose()
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        'UncheckRadioButtons(Me)
        Me.ReportViewer1.RefreshReport()
    End Sub
    'Private Sub UncheckRadioButtons(ByVal ctrl As Control)

    '    For Each c As Control In ctrl.Controls
    '        If TypeOf c Is RadioButton Then
    '            CType(c, RadioButton).Checked = False
    '        Else
    '            If c.HasChildren Then UncheckRadioButtons(c)
    '        End If
    '    Next

    'End Sub
End Class