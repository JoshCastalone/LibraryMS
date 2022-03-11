<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBooks
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBooks))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txtISBN = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtTitle = New System.Windows.Forms.TextBox()
        Me.cmbCategory = New System.Windows.Forms.ComboBox()
        Me.txtEdition = New System.Windows.Forms.TextBox()
        Me.txtAuthor = New System.Windows.Forms.TextBox()
        Me.txtPublisher = New System.Windows.Forms.TextBox()
        Me.txtAvail = New System.Windows.Forms.TextBox()
        Me.txtDatePub = New System.Windows.Forms.TextBox()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.txtCost = New System.Windows.Forms.TextBox()
        Me.txtRemarks = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnInsert = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.BkISBNDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BktitleDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BkeditionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BkauthorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BkpublisherDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BkcopiesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BktotalcopiesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BkcostDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BkremarksDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BkpublishdateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CategorynameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BooktblBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Test3DataSet = New LibraryMS.test3DataSet()
        Me.BooktblTableAdapter = New LibraryMS.test3DataSetTableAdapters.booktblTableAdapter()
        Me.btnBarcode = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BooktblBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Test3DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PictureBox1.Location = New System.Drawing.Point(-149, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1064, 39)
        Me.PictureBox1.TabIndex = 16
        Me.PictureBox1.TabStop = False
        '
        'txtISBN
        '
        Me.txtISBN.Location = New System.Drawing.Point(132, 69)
        Me.txtISBN.MaxLength = 13
        Me.txtISBN.Name = "txtISBN"
        Me.txtISBN.Size = New System.Drawing.Size(253, 20)
        Me.txtISBN.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(84, 70)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 16)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "&ISBN:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(89, 98)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 16)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "&Title:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(74, 128)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 16)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "&Edition:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(77, 157)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 16)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "&Author:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(59, 184)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 16)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "&Publisher:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(12, 213)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(114, 16)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "&Available Copies:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(456, 70)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(88, 16)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "&Total Copies:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(506, 98)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(38, 16)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "&Cost:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(478, 128)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(66, 16)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "&Remarks:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(401, 157)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(143, 16)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "&Date Published (Year):"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(478, 184)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(66, 16)
        Me.Label11.TabIndex = 18
        Me.Label11.Text = "&Category:"
        '
        'txtTitle
        '
        Me.txtTitle.Location = New System.Drawing.Point(132, 97)
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.Size = New System.Drawing.Size(253, 20)
        Me.txtTitle.TabIndex = 2
        '
        'cmbCategory
        '
        Me.cmbCategory.FormattingEnabled = True
        Me.cmbCategory.Location = New System.Drawing.Point(550, 183)
        Me.cmbCategory.Name = "cmbCategory"
        Me.cmbCategory.Size = New System.Drawing.Size(190, 21)
        Me.cmbCategory.TabIndex = 11
        '
        'txtEdition
        '
        Me.txtEdition.Location = New System.Drawing.Point(132, 127)
        Me.txtEdition.Name = "txtEdition"
        Me.txtEdition.Size = New System.Drawing.Size(253, 20)
        Me.txtEdition.TabIndex = 3
        '
        'txtAuthor
        '
        Me.txtAuthor.Location = New System.Drawing.Point(132, 156)
        Me.txtAuthor.Name = "txtAuthor"
        Me.txtAuthor.Size = New System.Drawing.Size(253, 20)
        Me.txtAuthor.TabIndex = 4
        '
        'txtPublisher
        '
        Me.txtPublisher.Location = New System.Drawing.Point(132, 183)
        Me.txtPublisher.Name = "txtPublisher"
        Me.txtPublisher.Size = New System.Drawing.Size(253, 20)
        Me.txtPublisher.TabIndex = 5
        '
        'txtAvail
        '
        Me.txtAvail.Location = New System.Drawing.Point(132, 212)
        Me.txtAvail.Name = "txtAvail"
        Me.txtAvail.Size = New System.Drawing.Size(253, 20)
        Me.txtAvail.TabIndex = 6
        '
        'txtDatePub
        '
        Me.txtDatePub.Location = New System.Drawing.Point(550, 156)
        Me.txtDatePub.Name = "txtDatePub"
        Me.txtDatePub.Size = New System.Drawing.Size(192, 20)
        Me.txtDatePub.TabIndex = 10
        '
        'txtTotal
        '
        Me.txtTotal.Location = New System.Drawing.Point(550, 69)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(192, 20)
        Me.txtTotal.TabIndex = 7
        '
        'txtCost
        '
        Me.txtCost.Location = New System.Drawing.Point(550, 97)
        Me.txtCost.Name = "txtCost"
        Me.txtCost.Size = New System.Drawing.Size(192, 20)
        Me.txtCost.TabIndex = 8
        '
        'txtRemarks
        '
        Me.txtRemarks.Location = New System.Drawing.Point(550, 127)
        Me.txtRemarks.Name = "txtRemarks"
        Me.txtRemarks.Size = New System.Drawing.Size(192, 20)
        Me.txtRemarks.TabIndex = 9
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnClear)
        Me.GroupBox1.Controls.Add(Me.btnDelete)
        Me.GroupBox1.Controls.Add(Me.btnUpdate)
        Me.GroupBox1.Controls.Add(Me.btnInsert)
        Me.GroupBox1.Location = New System.Drawing.Point(40, 238)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(370, 57)
        Me.GroupBox1.TabIndex = 21
        Me.GroupBox1.TabStop = False
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(276, 19)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(82, 23)
        Me.btnClear.TabIndex = 15
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(188, 19)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(82, 23)
        Me.btnDelete.TabIndex = 14
        Me.btnDelete.Text = "Delete Book"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(100, 19)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(82, 23)
        Me.btnUpdate.TabIndex = 13
        Me.btnUpdate.Text = "Update Book"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnInsert
        '
        Me.btnInsert.Location = New System.Drawing.Point(12, 19)
        Me.btnInsert.Name = "btnInsert"
        Me.btnInsert.Size = New System.Drawing.Size(82, 23)
        Me.btnInsert.TabIndex = 12
        Me.btnInsert.Text = "Add Book"
        Me.btnInsert.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.BkISBNDataGridViewTextBoxColumn, Me.BktitleDataGridViewTextBoxColumn, Me.BkeditionDataGridViewTextBoxColumn, Me.BkauthorDataGridViewTextBoxColumn, Me.BkpublisherDataGridViewTextBoxColumn, Me.BkcopiesDataGridViewTextBoxColumn, Me.BktotalcopiesDataGridViewTextBoxColumn, Me.BkcostDataGridViewTextBoxColumn, Me.BkremarksDataGridViewTextBoxColumn, Me.BkpublishdateDataGridViewTextBoxColumn, Me.CategorynameDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.BooktblBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(0, 301)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(800, 150)
        Me.DataGridView1.TabIndex = 22
        '
        'BkISBNDataGridViewTextBoxColumn
        '
        Me.BkISBNDataGridViewTextBoxColumn.DataPropertyName = "bk_ISBN"
        Me.BkISBNDataGridViewTextBoxColumn.HeaderText = "ISBN"
        Me.BkISBNDataGridViewTextBoxColumn.Name = "BkISBNDataGridViewTextBoxColumn"
        Me.BkISBNDataGridViewTextBoxColumn.ReadOnly = True
        '
        'BktitleDataGridViewTextBoxColumn
        '
        Me.BktitleDataGridViewTextBoxColumn.DataPropertyName = "bktitle"
        Me.BktitleDataGridViewTextBoxColumn.HeaderText = "Title"
        Me.BktitleDataGridViewTextBoxColumn.Name = "BktitleDataGridViewTextBoxColumn"
        Me.BktitleDataGridViewTextBoxColumn.ReadOnly = True
        '
        'BkeditionDataGridViewTextBoxColumn
        '
        Me.BkeditionDataGridViewTextBoxColumn.DataPropertyName = "bkedition"
        Me.BkeditionDataGridViewTextBoxColumn.HeaderText = "Edition"
        Me.BkeditionDataGridViewTextBoxColumn.Name = "BkeditionDataGridViewTextBoxColumn"
        Me.BkeditionDataGridViewTextBoxColumn.ReadOnly = True
        '
        'BkauthorDataGridViewTextBoxColumn
        '
        Me.BkauthorDataGridViewTextBoxColumn.DataPropertyName = "bkauthor"
        Me.BkauthorDataGridViewTextBoxColumn.HeaderText = "Author"
        Me.BkauthorDataGridViewTextBoxColumn.Name = "BkauthorDataGridViewTextBoxColumn"
        Me.BkauthorDataGridViewTextBoxColumn.ReadOnly = True
        '
        'BkpublisherDataGridViewTextBoxColumn
        '
        Me.BkpublisherDataGridViewTextBoxColumn.DataPropertyName = "bkpublisher"
        Me.BkpublisherDataGridViewTextBoxColumn.HeaderText = "Publisher"
        Me.BkpublisherDataGridViewTextBoxColumn.Name = "BkpublisherDataGridViewTextBoxColumn"
        Me.BkpublisherDataGridViewTextBoxColumn.ReadOnly = True
        '
        'BkcopiesDataGridViewTextBoxColumn
        '
        Me.BkcopiesDataGridViewTextBoxColumn.DataPropertyName = "bkcopies"
        Me.BkcopiesDataGridViewTextBoxColumn.HeaderText = "Available Copies"
        Me.BkcopiesDataGridViewTextBoxColumn.Name = "BkcopiesDataGridViewTextBoxColumn"
        Me.BkcopiesDataGridViewTextBoxColumn.ReadOnly = True
        Me.BkcopiesDataGridViewTextBoxColumn.Width = 75
        '
        'BktotalcopiesDataGridViewTextBoxColumn
        '
        Me.BktotalcopiesDataGridViewTextBoxColumn.DataPropertyName = "bk_totalcopies"
        Me.BktotalcopiesDataGridViewTextBoxColumn.HeaderText = "Total Copies"
        Me.BktotalcopiesDataGridViewTextBoxColumn.Name = "BktotalcopiesDataGridViewTextBoxColumn"
        Me.BktotalcopiesDataGridViewTextBoxColumn.ReadOnly = True
        Me.BktotalcopiesDataGridViewTextBoxColumn.Width = 70
        '
        'BkcostDataGridViewTextBoxColumn
        '
        Me.BkcostDataGridViewTextBoxColumn.DataPropertyName = "bk_cost"
        Me.BkcostDataGridViewTextBoxColumn.HeaderText = "Cost"
        Me.BkcostDataGridViewTextBoxColumn.Name = "BkcostDataGridViewTextBoxColumn"
        Me.BkcostDataGridViewTextBoxColumn.ReadOnly = True
        Me.BkcostDataGridViewTextBoxColumn.Width = 80
        '
        'BkremarksDataGridViewTextBoxColumn
        '
        Me.BkremarksDataGridViewTextBoxColumn.DataPropertyName = "bk_remarks"
        Me.BkremarksDataGridViewTextBoxColumn.HeaderText = "Remarks"
        Me.BkremarksDataGridViewTextBoxColumn.Name = "BkremarksDataGridViewTextBoxColumn"
        Me.BkremarksDataGridViewTextBoxColumn.ReadOnly = True
        '
        'BkpublishdateDataGridViewTextBoxColumn
        '
        Me.BkpublishdateDataGridViewTextBoxColumn.DataPropertyName = "bk_publishdate"
        Me.BkpublishdateDataGridViewTextBoxColumn.HeaderText = "Date Published"
        Me.BkpublishdateDataGridViewTextBoxColumn.Name = "BkpublishdateDataGridViewTextBoxColumn"
        Me.BkpublishdateDataGridViewTextBoxColumn.ReadOnly = True
        Me.BkpublishdateDataGridViewTextBoxColumn.Width = 80
        '
        'CategorynameDataGridViewTextBoxColumn
        '
        Me.CategorynameDataGridViewTextBoxColumn.DataPropertyName = "category_name"
        Me.CategorynameDataGridViewTextBoxColumn.HeaderText = "Category"
        Me.CategorynameDataGridViewTextBoxColumn.Name = "CategorynameDataGridViewTextBoxColumn"
        Me.CategorynameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'BooktblBindingSource
        '
        Me.BooktblBindingSource.DataMember = "booktbl"
        Me.BooktblBindingSource.DataSource = Me.Test3DataSet
        '
        'Test3DataSet
        '
        Me.Test3DataSet.DataSetName = "test3DataSet"
        Me.Test3DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BooktblTableAdapter
        '
        Me.BooktblTableAdapter.ClearBeforeFill = True
        '
        'btnBarcode
        '
        Me.btnBarcode.Location = New System.Drawing.Point(416, 257)
        Me.btnBarcode.Name = "btnBarcode"
        Me.btnBarcode.Size = New System.Drawing.Size(107, 23)
        Me.btnBarcode.TabIndex = 15
        Me.btnBarcode.Text = "Generate Barcode"
        Me.btnBarcode.UseVisualStyleBackColor = True
        '
        'frmBooks
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnBarcode)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cmbCategory)
        Me.Controls.Add(Me.txtRemarks)
        Me.Controls.Add(Me.txtCost)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.txtDatePub)
        Me.Controls.Add(Me.txtAvail)
        Me.Controls.Add(Me.txtPublisher)
        Me.Controls.Add(Me.txtAuthor)
        Me.Controls.Add(Me.txtEdition)
        Me.Controls.Add(Me.txtTitle)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtISBN)
        Me.Controls.Add(Me.PictureBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmBooks"
        Me.Text = "Add Books"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BooktblBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Test3DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txtISBN As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents txtTitle As TextBox
    Friend WithEvents cmbCategory As ComboBox
    Friend WithEvents txtEdition As TextBox
    Friend WithEvents txtAuthor As TextBox
    Friend WithEvents txtPublisher As TextBox
    Friend WithEvents txtAvail As TextBox
    Friend WithEvents txtDatePub As TextBox
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents txtCost As TextBox
    Friend WithEvents txtRemarks As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnClear As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnInsert As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents BkISBNDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BktitleDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BkeditionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BkauthorDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BkpublisherDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BkcopiesDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BktotalcopiesDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BkcostDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BkremarksDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BkpublishdateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CategorynameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Test3DataSet As test3DataSet
    Friend WithEvents BooktblTableAdapter As test3DataSetTableAdapters.booktblTableAdapter
    Friend WithEvents BooktblBindingSource As BindingSource
    Friend WithEvents btnBarcode As Button
End Class
