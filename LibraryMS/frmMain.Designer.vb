<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblUser = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblTime = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.BooksToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StudentsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BookTransactionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BookSearchToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EBooksToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip2 = New System.Windows.Forms.MenuStrip()
        Me.RecordsStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TransactionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BorrowedBooksToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReturnedBooksToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BooksToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.BorrowersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CalculatorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NotepadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TaskManagerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MSWordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WordpadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SystemInfoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ManageUsersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ManageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BookCategoriesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StudentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SectionStrandToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GradeLevelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.MenuStrip2.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.lblUser, Me.ToolStripStatusLabel2, Me.lblTime})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 428)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(800, 22)
        Me.StatusStrip1.TabIndex = 0
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(88, 17)
        Me.ToolStripStatusLabel1.Text = "Logged-in as:"
        '
        'lblUser
        '
        Me.lblUser.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(133, 17)
        Me.lblUser.Text = "ToolStripStatusLabel2"
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(427, 17)
        Me.ToolStripStatusLabel2.Text = "                                                                                 " &
    "                                                           "
        '
        'lblTime
        '
        Me.lblTime.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(133, 17)
        Me.lblTime.Text = "ToolStripStatusLabel3"
        '
        'Timer1
        '
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MenuStrip1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BooksToolStripMenuItem, Me.StudentsToolStripMenuItem, Me.BookTransactionsToolStripMenuItem, Me.BookSearchToolStripMenuItem, Me.EBooksToolStripMenuItem, Me.LogoutToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 24)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 26)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'BooksToolStripMenuItem
        '
        Me.BooksToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.BooksToolStripMenuItem.Name = "BooksToolStripMenuItem"
        Me.BooksToolStripMenuItem.Size = New System.Drawing.Size(64, 22)
        Me.BooksToolStripMenuItem.Text = "Books"
        Me.BooksToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'StudentsToolStripMenuItem
        '
        Me.StudentsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.StudentsToolStripMenuItem.Name = "StudentsToolStripMenuItem"
        Me.StudentsToolStripMenuItem.Size = New System.Drawing.Size(90, 22)
        Me.StudentsToolStripMenuItem.Text = "Borrowers"
        Me.StudentsToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'BookTransactionsToolStripMenuItem
        '
        Me.BookTransactionsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.BookTransactionsToolStripMenuItem.Name = "BookTransactionsToolStripMenuItem"
        Me.BookTransactionsToolStripMenuItem.Size = New System.Drawing.Size(106, 22)
        Me.BookTransactionsToolStripMenuItem.Text = "Transactions"
        Me.BookTransactionsToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'BookSearchToolStripMenuItem
        '
        Me.BookSearchToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.BookSearchToolStripMenuItem.Name = "BookSearchToolStripMenuItem"
        Me.BookSearchToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.BookSearchToolStripMenuItem.Text = "Book Search"
        Me.BookSearchToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'EBooksToolStripMenuItem
        '
        Me.EBooksToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.EBooksToolStripMenuItem.Name = "EBooksToolStripMenuItem"
        Me.EBooksToolStripMenuItem.Size = New System.Drawing.Size(79, 22)
        Me.EBooksToolStripMenuItem.Text = "E-Books"
        Me.EBooksToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(66, 22)
        Me.LogoutToolStripMenuItem.Text = "Logout"
        Me.LogoutToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'MenuStrip2
        '
        Me.MenuStrip2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RecordsStripMenuItem, Me.ToolsToolStripMenuItem, Me.AboutToolStripMenuItem})
        Me.MenuStrip2.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip2.Name = "MenuStrip2"
        Me.MenuStrip2.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
        Me.MenuStrip2.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip2.TabIndex = 3
        Me.MenuStrip2.Text = "MenuStrip2"
        '
        'RecordsStripMenuItem
        '
        Me.RecordsStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TransactionsToolStripMenuItem, Me.BooksToolStripMenuItem1, Me.BorrowersToolStripMenuItem})
        Me.RecordsStripMenuItem.Name = "RecordsStripMenuItem"
        Me.RecordsStripMenuItem.Size = New System.Drawing.Size(65, 20)
        Me.RecordsStripMenuItem.Text = "Records"
        '
        'TransactionsToolStripMenuItem
        '
        Me.TransactionsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BorrowedBooksToolStripMenuItem, Me.ReturnedBooksToolStripMenuItem})
        Me.TransactionsToolStripMenuItem.Name = "TransactionsToolStripMenuItem"
        Me.TransactionsToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
        Me.TransactionsToolStripMenuItem.Text = "Transactions"
        '
        'BorrowedBooksToolStripMenuItem
        '
        Me.BorrowedBooksToolStripMenuItem.Name = "BorrowedBooksToolStripMenuItem"
        Me.BorrowedBooksToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.BorrowedBooksToolStripMenuItem.Text = "Borrowed Books"
        '
        'ReturnedBooksToolStripMenuItem
        '
        Me.ReturnedBooksToolStripMenuItem.Name = "ReturnedBooksToolStripMenuItem"
        Me.ReturnedBooksToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.ReturnedBooksToolStripMenuItem.Text = "Returned Books"
        '
        'BooksToolStripMenuItem1
        '
        Me.BooksToolStripMenuItem1.Name = "BooksToolStripMenuItem1"
        Me.BooksToolStripMenuItem1.Size = New System.Drawing.Size(144, 22)
        Me.BooksToolStripMenuItem1.Text = "Books"
        '
        'BorrowersToolStripMenuItem
        '
        Me.BorrowersToolStripMenuItem.Name = "BorrowersToolStripMenuItem"
        Me.BorrowersToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
        Me.BorrowersToolStripMenuItem.Text = "Borrowers"
        '
        'ToolsToolStripMenuItem
        '
        Me.ToolsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CalculatorToolStripMenuItem, Me.NotepadToolStripMenuItem, Me.TaskManagerToolStripMenuItem, Me.MSWordToolStripMenuItem, Me.WordpadToolStripMenuItem, Me.SystemInfoToolStripMenuItem, Me.ManageUsersToolStripMenuItem, Me.ManageToolStripMenuItem})
        Me.ToolsToolStripMenuItem.Name = "ToolsToolStripMenuItem"
        Me.ToolsToolStripMenuItem.Size = New System.Drawing.Size(49, 20)
        Me.ToolsToolStripMenuItem.Text = "Tools"
        '
        'CalculatorToolStripMenuItem
        '
        Me.CalculatorToolStripMenuItem.Name = "CalculatorToolStripMenuItem"
        Me.CalculatorToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.CalculatorToolStripMenuItem.Text = "Calculator"
        '
        'NotepadToolStripMenuItem
        '
        Me.NotepadToolStripMenuItem.Name = "NotepadToolStripMenuItem"
        Me.NotepadToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.NotepadToolStripMenuItem.Text = "Notepad"
        '
        'TaskManagerToolStripMenuItem
        '
        Me.TaskManagerToolStripMenuItem.Name = "TaskManagerToolStripMenuItem"
        Me.TaskManagerToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.TaskManagerToolStripMenuItem.Text = "Task Manager"
        '
        'MSWordToolStripMenuItem
        '
        Me.MSWordToolStripMenuItem.Name = "MSWordToolStripMenuItem"
        Me.MSWordToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.MSWordToolStripMenuItem.Text = "MS Word"
        '
        'WordpadToolStripMenuItem
        '
        Me.WordpadToolStripMenuItem.Name = "WordpadToolStripMenuItem"
        Me.WordpadToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.WordpadToolStripMenuItem.Text = "Wordpad"
        '
        'SystemInfoToolStripMenuItem
        '
        Me.SystemInfoToolStripMenuItem.Name = "SystemInfoToolStripMenuItem"
        Me.SystemInfoToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.SystemInfoToolStripMenuItem.Text = "System Info"
        '
        'ManageUsersToolStripMenuItem
        '
        Me.ManageUsersToolStripMenuItem.Name = "ManageUsersToolStripMenuItem"
        Me.ManageUsersToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.ManageUsersToolStripMenuItem.Text = "Manage Users"
        '
        'ManageToolStripMenuItem
        '
        Me.ManageToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BookCategoriesToolStripMenuItem, Me.StudentToolStripMenuItem})
        Me.ManageToolStripMenuItem.Name = "ManageToolStripMenuItem"
        Me.ManageToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.ManageToolStripMenuItem.Text = "Manage..."
        '
        'BookCategoriesToolStripMenuItem
        '
        Me.BookCategoriesToolStripMenuItem.Name = "BookCategoriesToolStripMenuItem"
        Me.BookCategoriesToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.BookCategoriesToolStripMenuItem.Text = "Book Categories"
        '
        'StudentToolStripMenuItem
        '
        Me.StudentToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SectionStrandToolStripMenuItem, Me.GradeLevelToolStripMenuItem})
        Me.StudentToolStripMenuItem.Name = "StudentToolStripMenuItem"
        Me.StudentToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.StudentToolStripMenuItem.Text = "Student..."
        '
        'SectionStrandToolStripMenuItem
        '
        Me.SectionStrandToolStripMenuItem.Name = "SectionStrandToolStripMenuItem"
        Me.SectionStrandToolStripMenuItem.Size = New System.Drawing.Size(154, 22)
        Me.SectionStrandToolStripMenuItem.Text = "Section/Strand"
        '
        'GradeLevelToolStripMenuItem
        '
        Me.GradeLevelToolStripMenuItem.Name = "GradeLevelToolStripMenuItem"
        Me.GradeLevelToolStripMenuItem.Size = New System.Drawing.Size(154, 22)
        Me.GradeLevelToolStripMenuItem.Text = "Grade Level"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.MenuStrip2)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.Text = "Dashboard"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.MenuStrip2.ResumeLayout(False)
        Me.MenuStrip2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents lblUser As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As ToolStripStatusLabel
    Friend WithEvents lblTime As ToolStripStatusLabel
    Friend WithEvents Timer1 As Timer
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents BooksToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StudentsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BookTransactionsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BookSearchToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EBooksToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MenuStrip2 As MenuStrip
    Friend WithEvents ToolsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CalculatorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NotepadToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TaskManagerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MSWordToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents WordpadToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SystemInfoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RecordsStripMenuItem As ToolStripMenuItem
    Friend WithEvents ManageUsersToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TransactionsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BorrowedBooksToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReturnedBooksToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BooksToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents BorrowersToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ManageToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BookCategoriesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StudentToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SectionStrandToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GradeLevelToolStripMenuItem As ToolStripMenuItem
End Class
