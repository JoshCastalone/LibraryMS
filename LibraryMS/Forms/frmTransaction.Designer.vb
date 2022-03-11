<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTransaction
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTransaction))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tbpBorrow = New System.Windows.Forms.TabPage()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.BkISBNDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BktitleDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BkauthorDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BorroweridDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StudentnameDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BorrowcopiesnumberDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BorrowdateDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DuedateDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BorrowtblBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Borrow = New LibraryMS.Borrow()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dtpDueDate = New System.Windows.Forms.DateTimePicker()
        Me.dtpIssueDate = New System.Windows.Forms.DateTimePicker()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.panel1 = New System.Windows.Forms.Panel()
        Me.btnUpdate_record = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnNewRecord = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnFetchBorrower = New System.Windows.Forms.Button()
        Me.txtBorrowerID = New System.Windows.Forms.TextBox()
        Me.txtStudentName = New System.Windows.Forms.TextBox()
        Me.txtSectionStrand = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtGradeLevel = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtISBN = New System.Windows.Forms.TextBox()
        Me.txtPublisher = New System.Windows.Forms.TextBox()
        Me.txtAuthor = New System.Windows.Forms.TextBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.btnFetchBooks = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtCategory = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtYear = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtEdition = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtBookTitle = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtTransactionID = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbpReturn = New System.Windows.Forms.TabPage()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.BkISBNDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BktitleDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BkauthorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BorroweridDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StudentnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BorrowcopiesnumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BorrowdateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DuedateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReturndateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PenaltyDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReturntblBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnUpdate2 = New System.Windows.Forms.Button()
        Me.btnDelete2 = New System.Windows.Forms.Button()
        Me.btnSave2 = New System.Windows.Forms.Button()
        Me.btnNew2 = New System.Windows.Forms.Button()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.txtBorrower2 = New System.Windows.Forms.TextBox()
        Me.txtStudentName2 = New System.Windows.Forms.TextBox()
        Me.txtSectionStrand2 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtGradeYear2 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.txtISBN2 = New System.Windows.Forms.TextBox()
        Me.txtPub2 = New System.Windows.Forms.TextBox()
        Me.txtAuthor2 = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.txtCat2 = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.txtYearPub2 = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.txtEdition2 = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.txtTitle = New System.Windows.Forms.TextBox()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.btnBorrowedHistory = New System.Windows.Forms.Button()
        Me.txtFine = New System.Windows.Forms.TextBox()
        Me.dtpReturn = New System.Windows.Forms.DateTimePicker()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.dtpDue2 = New System.Windows.Forms.DateTimePicker()
        Me.dtpIssue2 = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ReturntblTableAdapter = New LibraryMS.BorrowTableAdapters.returntblTableAdapter()
        Me.BorrowtblTableAdapter = New LibraryMS.BorrowTableAdapters.borrowtblTableAdapter()
        Me.TabControl1.SuspendLayout()
        Me.tbpBorrow.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BorrowtblBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Borrow, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.panel1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.tbpReturn.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReturntblBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.tbpBorrow)
        Me.TabControl1.Controls.Add(Me.tbpReturn)
        Me.TabControl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(3, 43)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(989, 596)
        Me.TabControl1.TabIndex = 0
        '
        'tbpBorrow
        '
        Me.tbpBorrow.Controls.Add(Me.DataGridView1)
        Me.tbpBorrow.Controls.Add(Me.GroupBox1)
        Me.tbpBorrow.Controls.Add(Me.panel1)
        Me.tbpBorrow.Controls.Add(Me.GroupBox3)
        Me.tbpBorrow.Controls.Add(Me.GroupBox2)
        Me.tbpBorrow.Controls.Add(Me.txtTransactionID)
        Me.tbpBorrow.Controls.Add(Me.Label1)
        Me.tbpBorrow.Location = New System.Drawing.Point(4, 25)
        Me.tbpBorrow.Name = "tbpBorrow"
        Me.tbpBorrow.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpBorrow.Size = New System.Drawing.Size(981, 567)
        Me.tbpBorrow.TabIndex = 0
        Me.tbpBorrow.Text = "Borrow"
        Me.tbpBorrow.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.BkISBNDataGridViewTextBoxColumn1, Me.BktitleDataGridViewTextBoxColumn1, Me.BkauthorDataGridViewTextBoxColumn1, Me.BorroweridDataGridViewTextBoxColumn1, Me.StudentnameDataGridViewTextBoxColumn1, Me.BorrowcopiesnumberDataGridViewTextBoxColumn1, Me.BorrowdateDataGridViewTextBoxColumn1, Me.DuedateDataGridViewTextBoxColumn1})
        Me.DataGridView1.DataSource = Me.BorrowtblBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(481, 86)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(479, 366)
        Me.DataGridView1.TabIndex = 28
        '
        'BkISBNDataGridViewTextBoxColumn1
        '
        Me.BkISBNDataGridViewTextBoxColumn1.DataPropertyName = "bk_ISBN"
        Me.BkISBNDataGridViewTextBoxColumn1.HeaderText = "bk_ISBN"
        Me.BkISBNDataGridViewTextBoxColumn1.Name = "BkISBNDataGridViewTextBoxColumn1"
        Me.BkISBNDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'BktitleDataGridViewTextBoxColumn1
        '
        Me.BktitleDataGridViewTextBoxColumn1.DataPropertyName = "bktitle"
        Me.BktitleDataGridViewTextBoxColumn1.HeaderText = "bktitle"
        Me.BktitleDataGridViewTextBoxColumn1.Name = "BktitleDataGridViewTextBoxColumn1"
        Me.BktitleDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'BkauthorDataGridViewTextBoxColumn1
        '
        Me.BkauthorDataGridViewTextBoxColumn1.DataPropertyName = "bkauthor"
        Me.BkauthorDataGridViewTextBoxColumn1.HeaderText = "bkauthor"
        Me.BkauthorDataGridViewTextBoxColumn1.Name = "BkauthorDataGridViewTextBoxColumn1"
        Me.BkauthorDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'BorroweridDataGridViewTextBoxColumn1
        '
        Me.BorroweridDataGridViewTextBoxColumn1.DataPropertyName = "borrower_id"
        Me.BorroweridDataGridViewTextBoxColumn1.HeaderText = "borrower_id"
        Me.BorroweridDataGridViewTextBoxColumn1.Name = "BorroweridDataGridViewTextBoxColumn1"
        Me.BorroweridDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'StudentnameDataGridViewTextBoxColumn1
        '
        Me.StudentnameDataGridViewTextBoxColumn1.DataPropertyName = "student_name"
        Me.StudentnameDataGridViewTextBoxColumn1.HeaderText = "student_name"
        Me.StudentnameDataGridViewTextBoxColumn1.Name = "StudentnameDataGridViewTextBoxColumn1"
        Me.StudentnameDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'BorrowcopiesnumberDataGridViewTextBoxColumn1
        '
        Me.BorrowcopiesnumberDataGridViewTextBoxColumn1.DataPropertyName = "borrowcopies_number"
        Me.BorrowcopiesnumberDataGridViewTextBoxColumn1.HeaderText = "borrowcopies_number"
        Me.BorrowcopiesnumberDataGridViewTextBoxColumn1.Name = "BorrowcopiesnumberDataGridViewTextBoxColumn1"
        Me.BorrowcopiesnumberDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'BorrowdateDataGridViewTextBoxColumn1
        '
        Me.BorrowdateDataGridViewTextBoxColumn1.DataPropertyName = "borrow_date"
        Me.BorrowdateDataGridViewTextBoxColumn1.HeaderText = "borrow_date"
        Me.BorrowdateDataGridViewTextBoxColumn1.Name = "BorrowdateDataGridViewTextBoxColumn1"
        Me.BorrowdateDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DuedateDataGridViewTextBoxColumn1
        '
        Me.DuedateDataGridViewTextBoxColumn1.DataPropertyName = "due_date"
        Me.DuedateDataGridViewTextBoxColumn1.HeaderText = "due_date"
        Me.DuedateDataGridViewTextBoxColumn1.Name = "DuedateDataGridViewTextBoxColumn1"
        Me.DuedateDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'BorrowtblBindingSource
        '
        Me.BorrowtblBindingSource.DataMember = "borrowtbl"
        Me.BorrowtblBindingSource.DataSource = Me.Borrow
        '
        'Borrow
        '
        Me.Borrow.DataSetName = "Borrow"
        Me.Borrow.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.dtpDueDate)
        Me.GroupBox1.Controls.Add(Me.dtpIssueDate)
        Me.GroupBox1.Controls.Add(Me.Label19)
        Me.GroupBox1.Controls.Add(Me.Label20)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(19, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(438, 95)
        Me.GroupBox1.TabIndex = 23
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Issue Details"
        '
        'dtpDueDate
        '
        Me.dtpDueDate.CustomFormat = "dd/MMM/yyyy"
        Me.dtpDueDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDueDate.Location = New System.Drawing.Point(137, 56)
        Me.dtpDueDate.Name = "dtpDueDate"
        Me.dtpDueDate.Size = New System.Drawing.Size(149, 22)
        Me.dtpDueDate.TabIndex = 31
        '
        'dtpIssueDate
        '
        Me.dtpIssueDate.CustomFormat = "dd/MMM/yyyy"
        Me.dtpIssueDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpIssueDate.Location = New System.Drawing.Point(137, 19)
        Me.dtpIssueDate.Name = "dtpIssueDate"
        Me.dtpIssueDate.Size = New System.Drawing.Size(149, 22)
        Me.dtpIssueDate.TabIndex = 1
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(17, 23)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(72, 16)
        Me.Label19.TabIndex = 29
        Me.Label19.Text = "Issue Date"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(17, 56)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(65, 16)
        Me.Label20.TabIndex = 28
        Me.Label20.Text = "Due Date"
        '
        'panel1
        '
        Me.panel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.panel1.BackColor = System.Drawing.Color.Transparent
        Me.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panel1.Controls.Add(Me.btnUpdate_record)
        Me.panel1.Controls.Add(Me.btnDelete)
        Me.panel1.Controls.Add(Me.btnSave)
        Me.panel1.Controls.Add(Me.btnNewRecord)
        Me.panel1.Location = New System.Drawing.Point(481, 17)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(293, 63)
        Me.panel1.TabIndex = 27
        '
        'btnUpdate_record
        '
        Me.btnUpdate_record.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate_record.Location = New System.Drawing.Point(218, 14)
        Me.btnUpdate_record.Name = "btnUpdate_record"
        Me.btnUpdate_record.Size = New System.Drawing.Size(62, 33)
        Me.btnUpdate_record.TabIndex = 3
        Me.btnUpdate_record.Text = "&Update"
        Me.btnUpdate_record.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Location = New System.Drawing.Point(150, 14)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(62, 33)
        Me.btnDelete.TabIndex = 2
        Me.btnDelete.Text = "&Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(82, 14)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(62, 33)
        Me.btnSave.TabIndex = 1
        Me.btnSave.Text = "&Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnNewRecord
        '
        Me.btnNewRecord.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNewRecord.Location = New System.Drawing.Point(14, 14)
        Me.btnNewRecord.Name = "btnNewRecord"
        Me.btnNewRecord.Size = New System.Drawing.Size(62, 33)
        Me.btnNewRecord.TabIndex = 0
        Me.btnNewRecord.Text = "&New"
        Me.btnNewRecord.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.btnFetchBorrower)
        Me.GroupBox3.Controls.Add(Me.txtBorrowerID)
        Me.GroupBox3.Controls.Add(Me.txtStudentName)
        Me.GroupBox3.Controls.Add(Me.txtSectionStrand)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.txtGradeLevel)
        Me.GroupBox3.Controls.Add(Me.Label16)
        Me.GroupBox3.Controls.Add(Me.Label17)
        Me.GroupBox3.Controls.Add(Me.Label18)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(19, 107)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(438, 138)
        Me.GroupBox3.TabIndex = 25
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Borrower Details"
        '
        'btnFetchBorrower
        '
        Me.btnFetchBorrower.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFetchBorrower.Location = New System.Drawing.Point(359, 20)
        Me.btnFetchBorrower.Name = "btnFetchBorrower"
        Me.btnFetchBorrower.Size = New System.Drawing.Size(28, 23)
        Me.btnFetchBorrower.TabIndex = 27
        Me.btnFetchBorrower.Text = ">"
        Me.btnFetchBorrower.UseVisualStyleBackColor = True
        '
        'txtBorrowerID
        '
        Me.txtBorrowerID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtBorrowerID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtBorrowerID.Location = New System.Drawing.Point(155, 21)
        Me.txtBorrowerID.Name = "txtBorrowerID"
        Me.txtBorrowerID.Size = New System.Drawing.Size(198, 22)
        Me.txtBorrowerID.TabIndex = 24
        '
        'txtStudentName
        '
        Me.txtStudentName.Location = New System.Drawing.Point(155, 51)
        Me.txtStudentName.Name = "txtStudentName"
        Me.txtStudentName.ReadOnly = True
        Me.txtStudentName.Size = New System.Drawing.Size(270, 22)
        Me.txtStudentName.TabIndex = 1
        '
        'txtSectionStrand
        '
        Me.txtSectionStrand.Location = New System.Drawing.Point(155, 79)
        Me.txtSectionStrand.Name = "txtSectionStrand"
        Me.txtSectionStrand.ReadOnly = True
        Me.txtSectionStrand.Size = New System.Drawing.Size(270, 22)
        Me.txtSectionStrand.TabIndex = 2
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(17, 82)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(96, 16)
        Me.Label13.TabIndex = 23
        Me.Label13.Text = "Section/Strand"
        '
        'txtGradeLevel
        '
        Me.txtGradeLevel.Location = New System.Drawing.Point(155, 107)
        Me.txtGradeLevel.Name = "txtGradeLevel"
        Me.txtGradeLevel.ReadOnly = True
        Me.txtGradeLevel.Size = New System.Drawing.Size(270, 22)
        Me.txtGradeLevel.TabIndex = 3
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(17, 110)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(78, 16)
        Me.Label16.TabIndex = 17
        Me.Label16.Text = "Grade Year"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(17, 24)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(78, 16)
        Me.Label17.TabIndex = 3
        Me.Label17.Text = "Borrower ID"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(17, 54)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(93, 16)
        Me.Label18.TabIndex = 1
        Me.Label18.Text = "Student Name"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.txtISBN)
        Me.GroupBox2.Controls.Add(Me.txtPublisher)
        Me.GroupBox2.Controls.Add(Me.txtAuthor)
        Me.GroupBox2.Controls.Add(Me.Label26)
        Me.GroupBox2.Controls.Add(Me.btnFetchBooks)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.txtCategory)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.txtYear)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.txtEdition)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.txtBookTitle)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(19, 251)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(438, 248)
        Me.GroupBox2.TabIndex = 26
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Book Details"
        '
        'txtISBN
        '
        Me.txtISBN.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtISBN.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtISBN.Location = New System.Drawing.Point(119, 26)
        Me.txtISBN.Name = "txtISBN"
        Me.txtISBN.Size = New System.Drawing.Size(100, 22)
        Me.txtISBN.TabIndex = 27
        '
        'txtPublisher
        '
        Me.txtPublisher.Location = New System.Drawing.Point(119, 134)
        Me.txtPublisher.Name = "txtPublisher"
        Me.txtPublisher.ReadOnly = True
        Me.txtPublisher.Size = New System.Drawing.Size(308, 22)
        Me.txtPublisher.TabIndex = 2
        '
        'txtAuthor
        '
        Me.txtAuthor.Location = New System.Drawing.Point(119, 106)
        Me.txtAuthor.Name = "txtAuthor"
        Me.txtAuthor.ReadOnly = True
        Me.txtAuthor.Size = New System.Drawing.Size(308, 22)
        Me.txtAuthor.TabIndex = 2
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(17, 137)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(64, 16)
        Me.Label26.TabIndex = 23
        Me.Label26.Text = "Publisher"
        '
        'btnFetchBooks
        '
        Me.btnFetchBooks.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFetchBooks.Location = New System.Drawing.Point(225, 26)
        Me.btnFetchBooks.Name = "btnFetchBooks"
        Me.btnFetchBooks.Size = New System.Drawing.Size(28, 23)
        Me.btnFetchBooks.TabIndex = 26
        Me.btnFetchBooks.Text = ">"
        Me.btnFetchBooks.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(17, 109)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(46, 16)
        Me.Label12.TabIndex = 23
        Me.Label12.Text = "Author"
        '
        'txtCategory
        '
        Me.txtCategory.Location = New System.Drawing.Point(119, 218)
        Me.txtCategory.Name = "txtCategory"
        Me.txtCategory.ReadOnly = True
        Me.txtCategory.Size = New System.Drawing.Size(121, 22)
        Me.txtCategory.TabIndex = 5
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(17, 221)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(63, 16)
        Me.Label11.TabIndex = 18
        Me.Label11.Text = "Category"
        '
        'txtYear
        '
        Me.txtYear.Location = New System.Drawing.Point(119, 190)
        Me.txtYear.Name = "txtYear"
        Me.txtYear.ReadOnly = True
        Me.txtYear.Size = New System.Drawing.Size(121, 22)
        Me.txtYear.TabIndex = 5
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(17, 193)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(100, 16)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "Year Published"
        '
        'txtEdition
        '
        Me.txtEdition.Location = New System.Drawing.Point(119, 162)
        Me.txtEdition.Name = "txtEdition"
        Me.txtEdition.ReadOnly = True
        Me.txtEdition.Size = New System.Drawing.Size(121, 22)
        Me.txtEdition.TabIndex = 5
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(17, 165)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(49, 16)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "Edition"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(17, 29)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 16)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "ISBN"
        '
        'txtBookTitle
        '
        Me.txtBookTitle.Location = New System.Drawing.Point(119, 54)
        Me.txtBookTitle.Multiline = True
        Me.txtBookTitle.Name = "txtBookTitle"
        Me.txtBookTitle.ReadOnly = True
        Me.txtBookTitle.Size = New System.Drawing.Size(308, 46)
        Me.txtBookTitle.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(17, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Book Title"
        '
        'txtTransactionID
        '
        Me.txtTransactionID.Location = New System.Drawing.Point(168, 41)
        Me.txtTransactionID.Name = "txtTransactionID"
        Me.txtTransactionID.ReadOnly = True
        Me.txtTransactionID.Size = New System.Drawing.Size(204, 22)
        Me.txtTransactionID.TabIndex = 20
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(47, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 16)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Transaction ID"
        '
        'tbpReturn
        '
        Me.tbpReturn.Controls.Add(Me.DataGridView2)
        Me.tbpReturn.Controls.Add(Me.Panel3)
        Me.tbpReturn.Controls.Add(Me.GroupBox5)
        Me.tbpReturn.Controls.Add(Me.GroupBox6)
        Me.tbpReturn.Controls.Add(Me.GroupBox4)
        Me.tbpReturn.Location = New System.Drawing.Point(4, 25)
        Me.tbpReturn.Name = "tbpReturn"
        Me.tbpReturn.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpReturn.Size = New System.Drawing.Size(981, 567)
        Me.tbpReturn.TabIndex = 1
        Me.tbpReturn.Text = "Return"
        Me.tbpReturn.UseVisualStyleBackColor = True
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.AllowUserToDeleteRows = False
        Me.DataGridView2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView2.AutoGenerateColumns = False
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.BkISBNDataGridViewTextBoxColumn, Me.BktitleDataGridViewTextBoxColumn, Me.BkauthorDataGridViewTextBoxColumn, Me.BorroweridDataGridViewTextBoxColumn, Me.StudentnameDataGridViewTextBoxColumn, Me.BorrowcopiesnumberDataGridViewTextBoxColumn, Me.BorrowdateDataGridViewTextBoxColumn, Me.DuedateDataGridViewTextBoxColumn, Me.ReturndateDataGridViewTextBoxColumn, Me.PenaltyDataGridViewTextBoxColumn})
        Me.DataGridView2.DataSource = Me.ReturntblBindingSource
        Me.DataGridView2.Location = New System.Drawing.Point(478, 96)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.ReadOnly = True
        Me.DataGridView2.Size = New System.Drawing.Size(479, 366)
        Me.DataGridView2.TabIndex = 45
        '
        'BkISBNDataGridViewTextBoxColumn
        '
        Me.BkISBNDataGridViewTextBoxColumn.DataPropertyName = "bk_ISBN"
        Me.BkISBNDataGridViewTextBoxColumn.HeaderText = "bk_ISBN"
        Me.BkISBNDataGridViewTextBoxColumn.Name = "BkISBNDataGridViewTextBoxColumn"
        Me.BkISBNDataGridViewTextBoxColumn.ReadOnly = True
        '
        'BktitleDataGridViewTextBoxColumn
        '
        Me.BktitleDataGridViewTextBoxColumn.DataPropertyName = "bktitle"
        Me.BktitleDataGridViewTextBoxColumn.HeaderText = "bktitle"
        Me.BktitleDataGridViewTextBoxColumn.Name = "BktitleDataGridViewTextBoxColumn"
        Me.BktitleDataGridViewTextBoxColumn.ReadOnly = True
        '
        'BkauthorDataGridViewTextBoxColumn
        '
        Me.BkauthorDataGridViewTextBoxColumn.DataPropertyName = "bkauthor"
        Me.BkauthorDataGridViewTextBoxColumn.HeaderText = "bkauthor"
        Me.BkauthorDataGridViewTextBoxColumn.Name = "BkauthorDataGridViewTextBoxColumn"
        Me.BkauthorDataGridViewTextBoxColumn.ReadOnly = True
        '
        'BorroweridDataGridViewTextBoxColumn
        '
        Me.BorroweridDataGridViewTextBoxColumn.DataPropertyName = "borrower_id"
        Me.BorroweridDataGridViewTextBoxColumn.HeaderText = "borrower_id"
        Me.BorroweridDataGridViewTextBoxColumn.Name = "BorroweridDataGridViewTextBoxColumn"
        Me.BorroweridDataGridViewTextBoxColumn.ReadOnly = True
        '
        'StudentnameDataGridViewTextBoxColumn
        '
        Me.StudentnameDataGridViewTextBoxColumn.DataPropertyName = "student_name"
        Me.StudentnameDataGridViewTextBoxColumn.HeaderText = "student_name"
        Me.StudentnameDataGridViewTextBoxColumn.Name = "StudentnameDataGridViewTextBoxColumn"
        Me.StudentnameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'BorrowcopiesnumberDataGridViewTextBoxColumn
        '
        Me.BorrowcopiesnumberDataGridViewTextBoxColumn.DataPropertyName = "borrowcopies_number"
        Me.BorrowcopiesnumberDataGridViewTextBoxColumn.HeaderText = "borrowcopies_number"
        Me.BorrowcopiesnumberDataGridViewTextBoxColumn.Name = "BorrowcopiesnumberDataGridViewTextBoxColumn"
        Me.BorrowcopiesnumberDataGridViewTextBoxColumn.ReadOnly = True
        '
        'BorrowdateDataGridViewTextBoxColumn
        '
        Me.BorrowdateDataGridViewTextBoxColumn.DataPropertyName = "borrow_date"
        Me.BorrowdateDataGridViewTextBoxColumn.HeaderText = "borrow_date"
        Me.BorrowdateDataGridViewTextBoxColumn.Name = "BorrowdateDataGridViewTextBoxColumn"
        Me.BorrowdateDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DuedateDataGridViewTextBoxColumn
        '
        Me.DuedateDataGridViewTextBoxColumn.DataPropertyName = "due_date"
        Me.DuedateDataGridViewTextBoxColumn.HeaderText = "due_date"
        Me.DuedateDataGridViewTextBoxColumn.Name = "DuedateDataGridViewTextBoxColumn"
        Me.DuedateDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ReturndateDataGridViewTextBoxColumn
        '
        Me.ReturndateDataGridViewTextBoxColumn.DataPropertyName = "return_date"
        Me.ReturndateDataGridViewTextBoxColumn.HeaderText = "return_date"
        Me.ReturndateDataGridViewTextBoxColumn.Name = "ReturndateDataGridViewTextBoxColumn"
        Me.ReturndateDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PenaltyDataGridViewTextBoxColumn
        '
        Me.PenaltyDataGridViewTextBoxColumn.DataPropertyName = "penalty"
        Me.PenaltyDataGridViewTextBoxColumn.HeaderText = "penalty"
        Me.PenaltyDataGridViewTextBoxColumn.Name = "PenaltyDataGridViewTextBoxColumn"
        Me.PenaltyDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ReturntblBindingSource
        '
        Me.ReturntblBindingSource.DataMember = "returntbl"
        Me.ReturntblBindingSource.DataSource = Me.Borrow
        '
        'Panel3
        '
        Me.Panel3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel3.BackColor = System.Drawing.Color.Transparent
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.btnUpdate2)
        Me.Panel3.Controls.Add(Me.btnDelete2)
        Me.Panel3.Controls.Add(Me.btnSave2)
        Me.Panel3.Controls.Add(Me.btnNew2)
        Me.Panel3.Location = New System.Drawing.Point(478, 18)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(293, 63)
        Me.Panel3.TabIndex = 44
        '
        'btnUpdate2
        '
        Me.btnUpdate2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate2.Location = New System.Drawing.Point(218, 14)
        Me.btnUpdate2.Name = "btnUpdate2"
        Me.btnUpdate2.Size = New System.Drawing.Size(62, 33)
        Me.btnUpdate2.TabIndex = 3
        Me.btnUpdate2.Text = "&Update"
        Me.btnUpdate2.UseVisualStyleBackColor = True
        '
        'btnDelete2
        '
        Me.btnDelete2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete2.Location = New System.Drawing.Point(150, 14)
        Me.btnDelete2.Name = "btnDelete2"
        Me.btnDelete2.Size = New System.Drawing.Size(62, 33)
        Me.btnDelete2.TabIndex = 2
        Me.btnDelete2.Text = "&Delete"
        Me.btnDelete2.UseVisualStyleBackColor = True
        '
        'btnSave2
        '
        Me.btnSave2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave2.Location = New System.Drawing.Point(82, 14)
        Me.btnSave2.Name = "btnSave2"
        Me.btnSave2.Size = New System.Drawing.Size(62, 33)
        Me.btnSave2.TabIndex = 1
        Me.btnSave2.Text = "&Save"
        Me.btnSave2.UseVisualStyleBackColor = True
        '
        'btnNew2
        '
        Me.btnNew2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNew2.Location = New System.Drawing.Point(14, 14)
        Me.btnNew2.Name = "btnNew2"
        Me.btnNew2.Size = New System.Drawing.Size(62, 33)
        Me.btnNew2.TabIndex = 0
        Me.btnNew2.Text = "&New"
        Me.btnNew2.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox5.Controls.Add(Me.Button5)
        Me.GroupBox5.Controls.Add(Me.txtBorrower2)
        Me.GroupBox5.Controls.Add(Me.txtStudentName2)
        Me.GroupBox5.Controls.Add(Me.txtSectionStrand2)
        Me.GroupBox5.Controls.Add(Me.Label6)
        Me.GroupBox5.Controls.Add(Me.txtGradeYear2)
        Me.GroupBox5.Controls.Add(Me.Label7)
        Me.GroupBox5.Controls.Add(Me.Label8)
        Me.GroupBox5.Controls.Add(Me.Label14)
        Me.GroupBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.Location = New System.Drawing.Point(16, 147)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(438, 138)
        Me.GroupBox5.TabIndex = 42
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Borrower Details"
        '
        'Button5
        '
        Me.Button5.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(359, 20)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(28, 23)
        Me.Button5.TabIndex = 27
        Me.Button5.Text = ">"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'txtBorrower2
        '
        Me.txtBorrower2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtBorrower2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtBorrower2.Location = New System.Drawing.Point(155, 21)
        Me.txtBorrower2.Name = "txtBorrower2"
        Me.txtBorrower2.Size = New System.Drawing.Size(198, 22)
        Me.txtBorrower2.TabIndex = 24
        '
        'txtStudentName2
        '
        Me.txtStudentName2.Location = New System.Drawing.Point(155, 51)
        Me.txtStudentName2.Name = "txtStudentName2"
        Me.txtStudentName2.ReadOnly = True
        Me.txtStudentName2.Size = New System.Drawing.Size(270, 22)
        Me.txtStudentName2.TabIndex = 1
        '
        'txtSectionStrand2
        '
        Me.txtSectionStrand2.Location = New System.Drawing.Point(155, 79)
        Me.txtSectionStrand2.Name = "txtSectionStrand2"
        Me.txtSectionStrand2.ReadOnly = True
        Me.txtSectionStrand2.Size = New System.Drawing.Size(270, 22)
        Me.txtSectionStrand2.TabIndex = 2
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(17, 82)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(96, 16)
        Me.Label6.TabIndex = 23
        Me.Label6.Text = "Section/Strand"
        '
        'txtGradeYear2
        '
        Me.txtGradeYear2.Location = New System.Drawing.Point(155, 107)
        Me.txtGradeYear2.Name = "txtGradeYear2"
        Me.txtGradeYear2.ReadOnly = True
        Me.txtGradeYear2.Size = New System.Drawing.Size(270, 22)
        Me.txtGradeYear2.TabIndex = 3
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(17, 110)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(78, 16)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Grade Year"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(17, 24)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(78, 16)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "Borrower ID"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(17, 54)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(93, 16)
        Me.Label14.TabIndex = 1
        Me.Label14.Text = "Student Name"
        '
        'GroupBox6
        '
        Me.GroupBox6.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox6.Controls.Add(Me.txtISBN2)
        Me.GroupBox6.Controls.Add(Me.txtPub2)
        Me.GroupBox6.Controls.Add(Me.txtAuthor2)
        Me.GroupBox6.Controls.Add(Me.Label15)
        Me.GroupBox6.Controls.Add(Me.Button6)
        Me.GroupBox6.Controls.Add(Me.Label21)
        Me.GroupBox6.Controls.Add(Me.txtCat2)
        Me.GroupBox6.Controls.Add(Me.Label22)
        Me.GroupBox6.Controls.Add(Me.txtYearPub2)
        Me.GroupBox6.Controls.Add(Me.Label23)
        Me.GroupBox6.Controls.Add(Me.txtEdition2)
        Me.GroupBox6.Controls.Add(Me.Label24)
        Me.GroupBox6.Controls.Add(Me.Label25)
        Me.GroupBox6.Controls.Add(Me.txtTitle)
        Me.GroupBox6.Controls.Add(Me.Label29)
        Me.GroupBox6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox6.Location = New System.Drawing.Point(16, 291)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(438, 248)
        Me.GroupBox6.TabIndex = 43
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Book Details"
        '
        'txtISBN2
        '
        Me.txtISBN2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtISBN2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtISBN2.Location = New System.Drawing.Point(119, 26)
        Me.txtISBN2.Name = "txtISBN2"
        Me.txtISBN2.Size = New System.Drawing.Size(100, 22)
        Me.txtISBN2.TabIndex = 27
        '
        'txtPub2
        '
        Me.txtPub2.Location = New System.Drawing.Point(119, 134)
        Me.txtPub2.Name = "txtPub2"
        Me.txtPub2.ReadOnly = True
        Me.txtPub2.Size = New System.Drawing.Size(308, 22)
        Me.txtPub2.TabIndex = 2
        '
        'txtAuthor2
        '
        Me.txtAuthor2.Location = New System.Drawing.Point(119, 106)
        Me.txtAuthor2.Name = "txtAuthor2"
        Me.txtAuthor2.ReadOnly = True
        Me.txtAuthor2.Size = New System.Drawing.Size(308, 22)
        Me.txtAuthor2.TabIndex = 2
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(17, 137)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(64, 16)
        Me.Label15.TabIndex = 23
        Me.Label15.Text = "Publisher"
        '
        'Button6
        '
        Me.Button6.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.Location = New System.Drawing.Point(225, 26)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(28, 23)
        Me.Button6.TabIndex = 26
        Me.Button6.Text = ">"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(17, 109)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(46, 16)
        Me.Label21.TabIndex = 23
        Me.Label21.Text = "Author"
        '
        'txtCat2
        '
        Me.txtCat2.Location = New System.Drawing.Point(119, 218)
        Me.txtCat2.Name = "txtCat2"
        Me.txtCat2.ReadOnly = True
        Me.txtCat2.Size = New System.Drawing.Size(121, 22)
        Me.txtCat2.TabIndex = 5
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(17, 221)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(63, 16)
        Me.Label22.TabIndex = 18
        Me.Label22.Text = "Category"
        '
        'txtYearPub2
        '
        Me.txtYearPub2.Location = New System.Drawing.Point(119, 190)
        Me.txtYearPub2.Name = "txtYearPub2"
        Me.txtYearPub2.ReadOnly = True
        Me.txtYearPub2.Size = New System.Drawing.Size(121, 22)
        Me.txtYearPub2.TabIndex = 5
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(17, 193)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(100, 16)
        Me.Label23.TabIndex = 18
        Me.Label23.Text = "Year Published"
        '
        'txtEdition2
        '
        Me.txtEdition2.Location = New System.Drawing.Point(119, 162)
        Me.txtEdition2.Name = "txtEdition2"
        Me.txtEdition2.ReadOnly = True
        Me.txtEdition2.Size = New System.Drawing.Size(121, 22)
        Me.txtEdition2.TabIndex = 5
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(17, 165)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(49, 16)
        Me.Label24.TabIndex = 18
        Me.Label24.Text = "Edition"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(17, 29)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(39, 16)
        Me.Label25.TabIndex = 3
        Me.Label25.Text = "ISBN"
        '
        'txtTitle
        '
        Me.txtTitle.Location = New System.Drawing.Point(119, 54)
        Me.txtTitle.Multiline = True
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.ReadOnly = True
        Me.txtTitle.Size = New System.Drawing.Size(308, 46)
        Me.txtTitle.TabIndex = 1
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(17, 57)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(69, 16)
        Me.Label29.TabIndex = 1
        Me.Label29.Text = "Book Title"
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox4.Controls.Add(Me.btnBorrowedHistory)
        Me.GroupBox4.Controls.Add(Me.txtFine)
        Me.GroupBox4.Controls.Add(Me.dtpReturn)
        Me.GroupBox4.Controls.Add(Me.Label28)
        Me.GroupBox4.Controls.Add(Me.Label27)
        Me.GroupBox4.Controls.Add(Me.dtpDue2)
        Me.GroupBox4.Controls.Add(Me.dtpIssue2)
        Me.GroupBox4.Controls.Add(Me.Label3)
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(17, 6)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(437, 135)
        Me.GroupBox4.TabIndex = 32
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Issue Details"
        '
        'btnBorrowedHistory
        '
        Me.btnBorrowedHistory.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBorrowedHistory.Location = New System.Drawing.Point(230, 86)
        Me.btnBorrowedHistory.Name = "btnBorrowedHistory"
        Me.btnBorrowedHistory.Size = New System.Drawing.Size(28, 23)
        Me.btnBorrowedHistory.TabIndex = 28
        Me.btnBorrowedHistory.Text = ">"
        Me.btnBorrowedHistory.UseVisualStyleBackColor = True
        '
        'txtFine
        '
        Me.txtFine.Location = New System.Drawing.Point(102, 87)
        Me.txtFine.Name = "txtFine"
        Me.txtFine.Size = New System.Drawing.Size(116, 22)
        Me.txtFine.TabIndex = 38
        '
        'dtpReturn
        '
        Me.dtpReturn.CustomFormat = "dd/MMM/yyyy"
        Me.dtpReturn.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpReturn.Location = New System.Drawing.Point(102, 54)
        Me.dtpReturn.Name = "dtpReturn"
        Me.dtpReturn.Size = New System.Drawing.Size(116, 22)
        Me.dtpReturn.TabIndex = 36
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(62, 90)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(34, 16)
        Me.Label28.TabIndex = 37
        Me.Label28.Text = "Fine"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(17, 59)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(79, 16)
        Me.Label27.TabIndex = 37
        Me.Label27.Text = "Return Date"
        '
        'dtpDue2
        '
        Me.dtpDue2.CustomFormat = "dd/MMM/yyyy"
        Me.dtpDue2.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDue2.Location = New System.Drawing.Point(298, 18)
        Me.dtpDue2.Name = "dtpDue2"
        Me.dtpDue2.Size = New System.Drawing.Size(116, 22)
        Me.dtpDue2.TabIndex = 35
        '
        'dtpIssue2
        '
        Me.dtpIssue2.CustomFormat = "dd/MMM/yyyy"
        Me.dtpIssue2.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpIssue2.Location = New System.Drawing.Point(102, 18)
        Me.dtpIssue2.Name = "dtpIssue2"
        Me.dtpIssue2.Size = New System.Drawing.Size(116, 22)
        Me.dtpIssue2.TabIndex = 32
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(24, 23)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 16)
        Me.Label3.TabIndex = 34
        Me.Label3.Text = "Issue Date"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(227, 23)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 16)
        Me.Label5.TabIndex = 33
        Me.Label5.Text = "Due Date"
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PictureBox1.Location = New System.Drawing.Point(-9, -2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1001, 39)
        Me.PictureBox1.TabIndex = 15
        Me.PictureBox1.TabStop = False
        '
        'ReturntblTableAdapter
        '
        Me.ReturntblTableAdapter.ClearBeforeFill = True
        '
        'BorrowtblTableAdapter
        '
        Me.BorrowtblTableAdapter.ClearBeforeFill = True
        '
        'frmTransaction
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(993, 645)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.TabControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmTransaction"
        Me.Text = "Transactions"
        Me.TabControl1.ResumeLayout(False)
        Me.tbpBorrow.ResumeLayout(False)
        Me.tbpBorrow.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BorrowtblBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Borrow, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.panel1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.tbpReturn.ResumeLayout(False)
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReturntblBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents tbpBorrow As TabPage
    Friend WithEvents tbpReturn As TabPage
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents dtpIssueDate As DateTimePicker
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
    Private WithEvents panel1 As Panel
    Public WithEvents btnUpdate_record As Button
    Public WithEvents btnDelete As Button
    Public WithEvents btnSave As Button
    Private WithEvents btnNewRecord As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents txtStudentName As TextBox
    Friend WithEvents btnFetchBooks As Button
    Friend WithEvents txtSectionStrand As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents txtGradeLevel As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtAuthor As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txtEdition As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtBookTitle As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtTransactionID As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents txtBorrowerID As TextBox
    Friend WithEvents txtISBN As TextBox
    Friend WithEvents txtCategory As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txtYear As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnFetchBorrower As Button
    Friend WithEvents txtPublisher As TextBox
    Friend WithEvents Label26 As Label
    Friend WithEvents dtpDueDate As DateTimePicker
    Friend WithEvents txtFine As TextBox
    Friend WithEvents dtpReturn As DateTimePicker
    Friend WithEvents Label27 As Label
    Friend WithEvents dtpDue2 As DateTimePicker
    Friend WithEvents dtpIssue2 As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents DataGridView2 As DataGridView
    Private WithEvents Panel3 As Panel
    Public WithEvents btnUpdate2 As Button
    Public WithEvents btnDelete2 As Button
    Public WithEvents btnSave2 As Button
    Private WithEvents btnNew2 As Button
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents Button5 As Button
    Friend WithEvents txtBorrower2 As TextBox
    Friend WithEvents txtStudentName2 As TextBox
    Friend WithEvents txtSectionStrand2 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtGradeYear2 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents txtISBN2 As TextBox
    Friend WithEvents txtPub2 As TextBox
    Friend WithEvents txtAuthor2 As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Button6 As Button
    Friend WithEvents Label21 As Label
    Friend WithEvents txtCat2 As TextBox
    Friend WithEvents Label22 As Label
    Friend WithEvents txtYearPub2 As TextBox
    Friend WithEvents Label23 As Label
    Friend WithEvents txtEdition2 As TextBox
    Friend WithEvents Label24 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents txtTitle As TextBox
    Friend WithEvents Label29 As Label
    Friend WithEvents Borrow As Borrow
    Friend WithEvents ReturntblBindingSource As BindingSource
    Friend WithEvents ReturntblTableAdapter As BorrowTableAdapters.returntblTableAdapter
    Friend WithEvents BorrowtblBindingSource As BindingSource
    Friend WithEvents BorrowtblTableAdapter As BorrowTableAdapters.borrowtblTableAdapter
    Friend WithEvents BkISBNDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents BktitleDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents BkauthorDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents BorroweridDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents StudentnameDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents BorrowcopiesnumberDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents BorrowdateDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DuedateDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents BkISBNDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BktitleDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BkauthorDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BorroweridDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StudentnameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BorrowcopiesnumberDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BorrowdateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DuedateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ReturndateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PenaltyDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents btnBorrowedHistory As Button
End Class
