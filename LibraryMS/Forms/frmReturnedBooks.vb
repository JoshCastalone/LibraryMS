Public Class frmReturnedBooks
    'This disables the Close button on this form. 
    Protected Overrides ReadOnly Property CreateParams As CreateParams
        Get
            Dim parms As CreateParams = MyBase.CreateParams
            parms.ClassStyle = parms.ClassStyle Or &H200  ' CS_NOCLOSE
            Return parms
        End Get
    End Property
    Private Sub frmReturnedBooks_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Borrow.returntbl' table. You can move, or remove it, as needed.
        Me.returntblTableAdapter.Fill(Me.Borrow.returntbl)
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class