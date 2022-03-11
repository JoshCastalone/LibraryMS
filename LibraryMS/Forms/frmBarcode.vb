Imports System.ComponentModel
Imports MessagingToolkit.Barcode
Public Class frmBarcode
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim sd As New SaveFileDialog
        sd.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.Desktop
        sd.FileName = frmBooks.txtTitle.Text & "-" & frmBooks.txtAuthor.Text
        sd.SupportMultiDottedExtensions = True
        sd.AddExtension = True
        sd.Filter = "PNG File|*.png"
        If sd.ShowDialog() = DialogResult.OK Then
            Try
                PictureBox1.Image.Save(sd.FileName, Imaging.ImageFormat.Png)

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub btnLoad_Click(sender As Object, e As EventArgs) Handles btnLoad.Click
        Dim OD As New OpenFileDialog
        OD.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.Desktop
        If OD.ShowDialog() = DialogResult.OK Then
            Try
                PictureBox1.Load(OD.FileName)
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub btnScan_Click(sender As Object, e As EventArgs) Handles btnScan.Click
        Dim Scanner As New MessagingToolkit.Barcode.BarcodeDecoder
        Dim result As MessagingToolkit.Barcode.Result
        Try
            result = Scanner.Decode(New Bitmap(PictureBox1.Image))
            'MsgBox(result.Text)
            Me.Hide()
            frmBooks.txtISBN.Text = result.ToString
        Catch ex As Exception

        End Try
    End Sub

    Private Sub frmBarcode_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Me.Dispose()
    End Sub
End Class