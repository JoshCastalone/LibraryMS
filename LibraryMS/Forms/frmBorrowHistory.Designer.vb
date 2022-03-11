<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBorrowHistory
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
        Me.btnClear = New System.Windows.Forms.Button()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.DataGridView4 = New System.Windows.Forms.DataGridView()
        Me.BorrowtblBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Borrow = New LibraryMS.Borrow()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.BorrowtblTableAdapter = New LibraryMS.BorrowTableAdapters.borrowtblTableAdapter()
        Me.BkISBNDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BktitleDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BkauthorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BorroweridDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StudentnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BorrowcopiesnumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BorrowdateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DuedateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BorrowtblBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Borrow, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnClear
        '
        Me.btnClear.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClear.Location = New System.Drawing.Point(639, 73)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 16
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'txtSearch
        '
        Me.txtSearch.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSearch.Location = New System.Drawing.Point(70, 75)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(563, 20)
        Me.txtSearch.TabIndex = 14
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
        Me.DataGridView4.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.BkISBNDataGridViewTextBoxColumn, Me.BktitleDataGridViewTextBoxColumn, Me.BkauthorDataGridViewTextBoxColumn, Me.BorroweridDataGridViewTextBoxColumn, Me.StudentnameDataGridViewTextBoxColumn, Me.BorrowcopiesnumberDataGridViewTextBoxColumn, Me.BorrowdateDataGridViewTextBoxColumn, Me.DuedateDataGridViewTextBoxColumn})
        Me.DataGridView4.DataSource = Me.BorrowtblBindingSource
        Me.DataGridView4.Location = New System.Drawing.Point(6, 126)
        Me.DataGridView4.Name = "DataGridView4"
        Me.DataGridView4.ReadOnly = True
        Me.DataGridView4.Size = New System.Drawing.Size(789, 322)
        Me.DataGridView4.TabIndex = 13
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
        'PictureBox2
        '
        Me.PictureBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PictureBox2.Location = New System.Drawing.Point(-1, 3)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(803, 50)
        Me.PictureBox2.TabIndex = 15
        Me.PictureBox2.TabStop = False
        '
        'BorrowtblTableAdapter
        '
        Me.BorrowtblTableAdapter.ClearBeforeFill = True
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
        'frmBorrowHistory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.DataGridView4)
        Me.Name = "frmBorrowHistory"
        Me.Text = "Borrow History"
        CType(Me.DataGridView4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BorrowtblBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Borrow, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnClear As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents DataGridView4 As DataGridView
    Friend WithEvents Borrow As Borrow
    Friend WithEvents BorrowtblBindingSource As BindingSource
    Friend WithEvents BorrowtblTableAdapter As BorrowTableAdapters.borrowtblTableAdapter
    Friend WithEvents BkISBNDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BktitleDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BkauthorDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BorroweridDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StudentnameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BorrowcopiesnumberDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BorrowdateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DuedateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
