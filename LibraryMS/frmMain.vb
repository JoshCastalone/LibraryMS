Imports System.ComponentModel

Public Class frmMain
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ' This gets the current date and time of the computer and displays it on the lblTime.
        lblTime.Text = DateTime.Now.ToString
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        'This closes/hides the frmMain, frees resources used by the form, and calls the log-in form.
        Me.Hide()
        Me.Dispose()
        LoginForm1.Show()
        LoginForm1.UsernameTextBox.Text = ""
        LoginForm1.PasswordTextBox.Text = ""
    End Sub

    Private Sub EBooksToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EBooksToolStripMenuItem.Click
        System.IO.Directory.CreateDirectory(Application.StartupPath & "\PDF_Files\")
        frmPDFReader.Show()
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles Me.Load
        Timer1.Enabled = True
    End Sub

    Private Sub CalculatorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CalculatorToolStripMenuItem.Click
        System.Diagnostics.Process.Start("calc.exe")
    End Sub

    Private Sub NotepadToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NotepadToolStripMenuItem.Click
        System.Diagnostics.Process.Start("notepad.exe")
    End Sub

    Private Sub TaskManagerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TaskManagerToolStripMenuItem.Click
        System.Diagnostics.Process.Start("taskmgr.exe")
    End Sub

    Private Sub MSWordToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MSWordToolStripMenuItem.Click
        System.Diagnostics.Process.Start("WinWord.exe")
    End Sub

    Private Sub WordpadToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WordpadToolStripMenuItem.Click
        System.Diagnostics.Process.Start("Wordpad.exe")
    End Sub

    Private Sub SystemInfoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SystemInfoToolStripMenuItem.Click
        frmSysInfo.Show()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        AboutBox1.Show()
    End Sub

    Private Sub BooksToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BooksToolStripMenuItem.Click
        frmBooks.Show()
    End Sub

    Private Sub BookTransactionsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BookTransactionsToolStripMenuItem.Click
        frmTransaction.Show()
    End Sub

    Private Sub frmMain_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        'This closes/hides the frmMain, frees resources used by the form, and calls the log-in form.
        Me.Hide()
        LoginForm1.Show()
        LoginForm1.UsernameTextBox.Text = ""
        LoginForm1.PasswordTextBox.Text = ""
    End Sub

    Private Sub BookSearchToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BookSearchToolStripMenuItem.Click
        frmBookSearch.Show()
    End Sub

    Private Sub StudentsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StudentsToolStripMenuItem.Click
        frmBorrower.Show()
        frmBorrower.Focus()
    End Sub

    Private Sub BooksToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles BooksToolStripMenuItem1.Click
        frmBookListRecord.Show()
        frmBookListRecord.Focus()
    End Sub

    Private Sub BookCategoriesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BookCategoriesToolStripMenuItem.Click
        frmBookCategories.Show()
        frmBookCategories.Focus()
    End Sub

    'Private Sub Button1_Click(sender As Object, e As EventArgs)
    '    Form1.Show()
    'End Sub

    Private Sub ManageUsersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ManageUsersToolStripMenuItem.Click
        frmUsers.Show()
        frmUsers.Focus()
    End Sub

    Private Sub SectionStrandToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SectionStrandToolStripMenuItem.Click
        frmSectionStrand.Show()
        frmSectionStrand.Focus()
    End Sub

    Private Sub GradeLevelToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GradeLevelToolStripMenuItem.Click
        frmGradeLevel.Show()
        frmGradeLevel.Focus()
    End Sub

    Private Sub BorrowedBooksToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BorrowedBooksToolStripMenuItem.Click
        frmBorrowedBooks.Show()
    End Sub

    Private Sub ReturnedBooksToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReturnedBooksToolStripMenuItem.Click
        frmReturnedBooks.Show()
    End Sub

    Private Sub BorrowersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BorrowersToolStripMenuItem.Click
        frmStudentsList.Show()
    End Sub
End Class

'I'm already disillusioned
'I really hate myself
'I'm not amused at all
'Why? Why am I dumb?
'Why am I not productive?
'Bakit tinatamad na ako mag aral?
'Nasaan na ang spark?
'I can feel na sinusubukan ko na lang mag survive, pero wala na akong natututunan...
'Nakakaumay na :)
