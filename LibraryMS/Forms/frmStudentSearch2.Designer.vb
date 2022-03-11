<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStudentSearch2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmStudentSearch2))
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.DataGridView4 = New System.Windows.Forms.DataGridView()
        Me.StudentwgtblBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Borrow = New LibraryMS.Borrow()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.StudentwgtblTableAdapter = New LibraryMS.BorrowTableAdapters.studentwgtblTableAdapter()
        Me.StudentidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StudentnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SexDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BorroweridDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BirthdateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SectionstrandDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AddressDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ContactnoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MobileNoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AcademicYearDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StudentwgtblBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Borrow, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PictureBox2.Location = New System.Drawing.Point(1, -8)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(803, 50)
        Me.PictureBox2.TabIndex = 7
        Me.PictureBox2.TabStop = False
        '
        'txtSearch
        '
        Me.txtSearch.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSearch.Location = New System.Drawing.Point(72, 64)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(563, 20)
        Me.txtSearch.TabIndex = 6
        '
        'DataGridView4
        '
        Me.DataGridView4.AllowUserToAddRows = False
        Me.DataGridView4.AllowUserToDeleteRows = False
        Me.DataGridView4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView4.AutoGenerateColumns = False
        Me.DataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView4.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.StudentidDataGridViewTextBoxColumn, Me.StudentnameDataGridViewTextBoxColumn, Me.SexDataGridViewTextBoxColumn, Me.BorroweridDataGridViewTextBoxColumn, Me.BirthdateDataGridViewTextBoxColumn, Me.DataGridViewTextBoxColumn1, Me.SectionstrandDataGridViewTextBoxColumn, Me.AddressDataGridViewTextBoxColumn, Me.ContactnoDataGridViewTextBoxColumn, Me.MobileNoDataGridViewTextBoxColumn, Me.AcademicYearDataGridViewTextBoxColumn, Me.EmailDataGridViewTextBoxColumn})
        Me.DataGridView4.DataSource = Me.StudentwgtblBindingSource
        Me.DataGridView4.Location = New System.Drawing.Point(1, 116)
        Me.DataGridView4.Name = "DataGridView4"
        Me.DataGridView4.ReadOnly = True
        Me.DataGridView4.Size = New System.Drawing.Size(803, 322)
        Me.DataGridView4.TabIndex = 4
        '
        'StudentwgtblBindingSource
        '
        Me.StudentwgtblBindingSource.DataMember = "studentwgtbl"
        Me.StudentwgtblBindingSource.DataSource = Me.Borrow
        '
        'Borrow
        '
        Me.Borrow.DataSetName = "Borrow"
        Me.Borrow.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'btnClear
        '
        Me.btnClear.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClear.Location = New System.Drawing.Point(641, 62)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 8
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'StudentwgtblTableAdapter
        '
        Me.StudentwgtblTableAdapter.ClearBeforeFill = True
        '
        'StudentidDataGridViewTextBoxColumn
        '
        Me.StudentidDataGridViewTextBoxColumn.DataPropertyName = "studentid"
        Me.StudentidDataGridViewTextBoxColumn.HeaderText = "Student ID"
        Me.StudentidDataGridViewTextBoxColumn.Name = "StudentidDataGridViewTextBoxColumn"
        Me.StudentidDataGridViewTextBoxColumn.ReadOnly = True
        '
        'StudentnameDataGridViewTextBoxColumn
        '
        Me.StudentnameDataGridViewTextBoxColumn.DataPropertyName = "student_name"
        Me.StudentnameDataGridViewTextBoxColumn.HeaderText = "Student Name"
        Me.StudentnameDataGridViewTextBoxColumn.Name = "StudentnameDataGridViewTextBoxColumn"
        Me.StudentnameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SexDataGridViewTextBoxColumn
        '
        Me.SexDataGridViewTextBoxColumn.DataPropertyName = "Sex"
        Me.SexDataGridViewTextBoxColumn.HeaderText = "Gender"
        Me.SexDataGridViewTextBoxColumn.Name = "SexDataGridViewTextBoxColumn"
        Me.SexDataGridViewTextBoxColumn.ReadOnly = True
        '
        'BorroweridDataGridViewTextBoxColumn
        '
        Me.BorroweridDataGridViewTextBoxColumn.DataPropertyName = "borrower_id"
        Me.BorroweridDataGridViewTextBoxColumn.HeaderText = "Borrower ID"
        Me.BorroweridDataGridViewTextBoxColumn.Name = "BorroweridDataGridViewTextBoxColumn"
        Me.BorroweridDataGridViewTextBoxColumn.ReadOnly = True
        '
        'BirthdateDataGridViewTextBoxColumn
        '
        Me.BirthdateDataGridViewTextBoxColumn.DataPropertyName = "birthdate"
        Me.BirthdateDataGridViewTextBoxColumn.HeaderText = "Birthdate"
        Me.BirthdateDataGridViewTextBoxColumn.Name = "BirthdateDataGridViewTextBoxColumn"
        Me.BirthdateDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "gradelevel_name"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Grade Level"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'SectionstrandDataGridViewTextBoxColumn
        '
        Me.SectionstrandDataGridViewTextBoxColumn.DataPropertyName = "Section_strand"
        Me.SectionstrandDataGridViewTextBoxColumn.HeaderText = "Section/Strand"
        Me.SectionstrandDataGridViewTextBoxColumn.Name = "SectionstrandDataGridViewTextBoxColumn"
        Me.SectionstrandDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AddressDataGridViewTextBoxColumn
        '
        Me.AddressDataGridViewTextBoxColumn.DataPropertyName = "Address"
        Me.AddressDataGridViewTextBoxColumn.HeaderText = "Address"
        Me.AddressDataGridViewTextBoxColumn.Name = "AddressDataGridViewTextBoxColumn"
        Me.AddressDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ContactnoDataGridViewTextBoxColumn
        '
        Me.ContactnoDataGridViewTextBoxColumn.DataPropertyName = "contact_no"
        Me.ContactnoDataGridViewTextBoxColumn.HeaderText = "Contact No."
        Me.ContactnoDataGridViewTextBoxColumn.Name = "ContactnoDataGridViewTextBoxColumn"
        Me.ContactnoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MobileNoDataGridViewTextBoxColumn
        '
        Me.MobileNoDataGridViewTextBoxColumn.DataPropertyName = "MobileNo"
        Me.MobileNoDataGridViewTextBoxColumn.HeaderText = "Mobile No."
        Me.MobileNoDataGridViewTextBoxColumn.Name = "MobileNoDataGridViewTextBoxColumn"
        Me.MobileNoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AcademicYearDataGridViewTextBoxColumn
        '
        Me.AcademicYearDataGridViewTextBoxColumn.DataPropertyName = "AcademicYear"
        Me.AcademicYearDataGridViewTextBoxColumn.HeaderText = "Academic Year"
        Me.AcademicYearDataGridViewTextBoxColumn.Name = "AcademicYearDataGridViewTextBoxColumn"
        Me.AcademicYearDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EmailDataGridViewTextBoxColumn
        '
        Me.EmailDataGridViewTextBoxColumn.DataPropertyName = "email"
        Me.EmailDataGridViewTextBoxColumn.HeaderText = "Email"
        Me.EmailDataGridViewTextBoxColumn.Name = "EmailDataGridViewTextBoxColumn"
        Me.EmailDataGridViewTextBoxColumn.ReadOnly = True
        '
        'frmStudentSearch2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.DataGridView4)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimizeBox = False
        Me.Name = "frmStudentSearch2"
        Me.Text = "Student Search"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StudentwgtblBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Borrow, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents DataGridView4 As DataGridView
    Friend WithEvents btnClear As Button
    Friend WithEvents GradelevelnameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Borrow As Borrow
    Friend WithEvents StudentwgtblBindingSource As BindingSource
    Friend WithEvents StudentwgtblTableAdapter As BorrowTableAdapters.studentwgtblTableAdapter
    Friend WithEvents StudentidDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StudentnameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SexDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BorroweridDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BirthdateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents SectionstrandDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AddressDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ContactnoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MobileNoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AcademicYearDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EmailDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
