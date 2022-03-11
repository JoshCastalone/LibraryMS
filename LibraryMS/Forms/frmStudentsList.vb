Public Class frmStudentsList
    'This disables the Close button on this form. 
    Protected Overrides ReadOnly Property CreateParams As CreateParams
        Get
            Dim parms As CreateParams = MyBase.CreateParams
            parms.ClassStyle = parms.ClassStyle Or &H200  ' CS_NOCLOSE
            Return parms
        End Get
    End Property
    Private Sub frmStudentsList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Borrow.studentwgtbl' table. You can move, or remove it, as needed.
        Me.studentwgtblTableAdapter.FillTable(Me.Borrow.studentwgtbl)
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
        Me.Dispose()
    End Sub
End Class