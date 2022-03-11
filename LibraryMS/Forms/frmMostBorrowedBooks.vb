Public Class frmMostBorrowedBooks
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub frmMostBorrowedBooks_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'reports.booktbl' table. You can move, or remove it, as needed.
        Me.booktblTableAdapter.Fill(Me.reports.booktbl)
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
End Class