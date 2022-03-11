<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBookSearch
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBookSearch))
        Me.tabControl1 = New System.Windows.Forms.TabControl()
        Me.tabPage3 = New System.Windows.Forms.TabPage()
        Me.groupBox4 = New System.Windows.Forms.GroupBox()
        Me.btnExport1 = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.dataGridView3 = New System.Windows.Forms.DataGridView()
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
        Me.groupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtISBN = New System.Windows.Forms.TextBox()
        Me.label8 = New System.Windows.Forms.Label()
        Me.groupBox2 = New System.Windows.Forms.GroupBox()
        Me.label7 = New System.Windows.Forms.Label()
        Me.cmbISBN = New System.Windows.Forms.ComboBox()
        Me.Booktbl1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnResetTitle = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.txtTitle = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbTitle = New System.Windows.Forms.ComboBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.btnResetAuth = New System.Windows.Forms.Button()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn19 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn20 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn21 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn22 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.txtAuthor = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox9 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmbAuthor = New System.Windows.Forms.ComboBox()
        Me.Booktbl1TableAdapter = New LibraryMS.test3DataSetTableAdapters.booktbl1TableAdapter()
        Me.BooktblTableAdapter = New LibraryMS.test3DataSetTableAdapters.booktblTableAdapter()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BooktblBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.tabControl1.SuspendLayout()
        Me.tabPage3.SuspendLayout()
        Me.groupBox4.SuspendLayout()
        CType(Me.dataGridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BooktblBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Test3DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupBox3.SuspendLayout()
        Me.groupBox2.SuspendLayout()
        CType(Me.Booktbl1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox8.SuspendLayout()
        Me.GroupBox9.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BooktblBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tabControl1
        '
        Me.tabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabControl1.Controls.Add(Me.tabPage3)
        Me.tabControl1.Controls.Add(Me.TabPage1)
        Me.tabControl1.Controls.Add(Me.TabPage2)
        Me.tabControl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabControl1.Location = New System.Drawing.Point(0, 43)
        Me.tabControl1.Name = "tabControl1"
        Me.tabControl1.SelectedIndex = 0
        Me.tabControl1.Size = New System.Drawing.Size(1064, 556)
        Me.tabControl1.TabIndex = 3
        '
        'tabPage3
        '
        Me.tabPage3.Controls.Add(Me.groupBox4)
        Me.tabPage3.Controls.Add(Me.dataGridView3)
        Me.tabPage3.Controls.Add(Me.groupBox3)
        Me.tabPage3.Controls.Add(Me.groupBox2)
        Me.tabPage3.Location = New System.Drawing.Point(4, 24)
        Me.tabPage3.Name = "tabPage3"
        Me.tabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPage3.Size = New System.Drawing.Size(1056, 528)
        Me.tabPage3.TabIndex = 2
        Me.tabPage3.Text = "By ISBN"
        Me.tabPage3.UseVisualStyleBackColor = True
        '
        'groupBox4
        '
        Me.groupBox4.Controls.Add(Me.btnExport1)
        Me.groupBox4.Controls.Add(Me.btnReset)
        Me.groupBox4.Location = New System.Drawing.Point(577, 15)
        Me.groupBox4.Name = "groupBox4"
        Me.groupBox4.Size = New System.Drawing.Size(227, 87)
        Me.groupBox4.TabIndex = 24
        Me.groupBox4.TabStop = False
        '
        'btnExport1
        '
        Me.btnExport1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExport1.Location = New System.Drawing.Point(122, 27)
        Me.btnExport1.Name = "btnExport1"
        Me.btnExport1.Size = New System.Drawing.Size(90, 40)
        Me.btnExport1.TabIndex = 4
        Me.btnExport1.Text = "&Export Excel"
        Me.btnExport1.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReset.Location = New System.Drawing.Point(16, 27)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(90, 40)
        Me.btnReset.TabIndex = 1
        Me.btnReset.Text = "&Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'dataGridView3
        '
        Me.dataGridView3.AllowUserToAddRows = False
        Me.dataGridView3.AllowUserToDeleteRows = False
        Me.dataGridView3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dataGridView3.AutoGenerateColumns = False
        Me.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataGridView3.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.BkISBNDataGridViewTextBoxColumn, Me.BktitleDataGridViewTextBoxColumn, Me.BkeditionDataGridViewTextBoxColumn, Me.BkauthorDataGridViewTextBoxColumn, Me.BkpublisherDataGridViewTextBoxColumn, Me.BkcopiesDataGridViewTextBoxColumn, Me.BktotalcopiesDataGridViewTextBoxColumn, Me.BkcostDataGridViewTextBoxColumn, Me.BkremarksDataGridViewTextBoxColumn, Me.BkpublishdateDataGridViewTextBoxColumn, Me.CategorynameDataGridViewTextBoxColumn})
        Me.dataGridView3.DataSource = Me.BooktblBindingSource
        Me.dataGridView3.Location = New System.Drawing.Point(3, 108)
        Me.dataGridView3.MultiSelect = False
        Me.dataGridView3.Name = "dataGridView3"
        Me.dataGridView3.ReadOnly = True
        Me.dataGridView3.Size = New System.Drawing.Size(1047, 346)
        Me.dataGridView3.TabIndex = 23
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
        Me.CategorynameDataGridViewTextBoxColumn.HeaderText = "Category Name"
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
        'groupBox3
        '
        Me.groupBox3.Controls.Add(Me.txtISBN)
        Me.groupBox3.Controls.Add(Me.label8)
        Me.groupBox3.Location = New System.Drawing.Point(291, 15)
        Me.groupBox3.Name = "groupBox3"
        Me.groupBox3.Size = New System.Drawing.Size(272, 87)
        Me.groupBox3.TabIndex = 18
        Me.groupBox3.TabStop = False
        '
        'txtISBN
        '
        Me.txtISBN.Location = New System.Drawing.Point(28, 44)
        Me.txtISBN.Name = "txtISBN"
        Me.txtISBN.Size = New System.Drawing.Size(221, 21)
        Me.txtISBN.TabIndex = 9
        '
        'label8
        '
        Me.label8.AutoSize = True
        Me.label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label8.Location = New System.Drawing.Point(25, 20)
        Me.label8.Name = "label8"
        Me.label8.Size = New System.Drawing.Size(57, 15)
        Me.label8.TabIndex = 8
        Me.label8.Text = "Book No."
        '
        'groupBox2
        '
        Me.groupBox2.Controls.Add(Me.label7)
        Me.groupBox2.Controls.Add(Me.cmbISBN)
        Me.groupBox2.Location = New System.Drawing.Point(8, 15)
        Me.groupBox2.Name = "groupBox2"
        Me.groupBox2.Size = New System.Drawing.Size(266, 87)
        Me.groupBox2.TabIndex = 17
        Me.groupBox2.TabStop = False
        '
        'label7
        '
        Me.label7.AutoSize = True
        Me.label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label7.Location = New System.Drawing.Point(25, 20)
        Me.label7.Name = "label7"
        Me.label7.Size = New System.Drawing.Size(35, 15)
        Me.label7.TabIndex = 8
        Me.label7.Text = "ISBN"
        '
        'cmbISBN
        '
        Me.cmbISBN.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cmbISBN.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbISBN.DataSource = Me.BooktblBindingSource1
        Me.cmbISBN.DisplayMember = "bk_ISBN"
        Me.cmbISBN.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbISBN.FormattingEnabled = True
        Me.cmbISBN.Location = New System.Drawing.Point(28, 44)
        Me.cmbISBN.Name = "cmbISBN"
        Me.cmbISBN.Size = New System.Drawing.Size(216, 23)
        Me.cmbISBN.TabIndex = 7
        '
        'Booktbl1BindingSource
        '
        Me.Booktbl1BindingSource.DataMember = "booktbl1"
        Me.Booktbl1BindingSource.DataSource = Me.Test3DataSet
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Controls.Add(Me.DataGridView1)
        Me.TabPage1.Controls.Add(Me.GroupBox5)
        Me.TabPage1.Controls.Add(Me.GroupBox6)
        Me.TabPage1.Location = New System.Drawing.Point(4, 24)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1056, 528)
        Me.TabPage1.TabIndex = 3
        Me.TabPage1.Text = "By Title"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnResetTitle)
        Me.GroupBox1.Location = New System.Drawing.Point(577, 16)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(227, 87)
        Me.GroupBox1.TabIndex = 28
        Me.GroupBox1.TabStop = False
        '
        'btnResetTitle
        '
        Me.btnResetTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnResetTitle.Location = New System.Drawing.Point(16, 27)
        Me.btnResetTitle.Name = "btnResetTitle"
        Me.btnResetTitle.Size = New System.Drawing.Size(90, 40)
        Me.btnResetTitle.TabIndex = 1
        Me.btnResetTitle.Text = "&Reset"
        Me.btnResetTitle.UseVisualStyleBackColor = True
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
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11})
        Me.DataGridView1.DataSource = Me.BooktblBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(3, 109)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(1047, 346)
        Me.DataGridView1.TabIndex = 27
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "bk_ISBN"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ISBN"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "bktitle"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Title"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "bkedition"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Edition"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "bkauthor"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Author"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "bkpublisher"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Publisher"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "bkcopies"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Available Copies"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Width = 75
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "bk_totalcopies"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Total Copies"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.Width = 70
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "bk_cost"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Cost"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        Me.DataGridViewTextBoxColumn8.Width = 80
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "bk_remarks"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Remarks"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "bk_publishdate"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Date Published"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        Me.DataGridViewTextBoxColumn10.Width = 80
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "category_name"
        Me.DataGridViewTextBoxColumn11.HeaderText = "Category Name"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.ReadOnly = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.txtTitle)
        Me.GroupBox5.Controls.Add(Me.Label1)
        Me.GroupBox5.Location = New System.Drawing.Point(291, 16)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(272, 87)
        Me.GroupBox5.TabIndex = 26
        Me.GroupBox5.TabStop = False
        '
        'txtTitle
        '
        Me.txtTitle.Location = New System.Drawing.Point(28, 44)
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.Size = New System.Drawing.Size(221, 21)
        Me.txtTitle.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(25, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 15)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Title"
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.Label2)
        Me.GroupBox6.Controls.Add(Me.cmbTitle)
        Me.GroupBox6.Location = New System.Drawing.Point(8, 16)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(266, 87)
        Me.GroupBox6.TabIndex = 25
        Me.GroupBox6.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(25, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(30, 15)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Title"
        '
        'cmbTitle
        '
        Me.cmbTitle.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cmbTitle.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbTitle.DataSource = Me.BooktblBindingSource
        Me.cmbTitle.DisplayMember = "bktitle"
        Me.cmbTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTitle.FormattingEnabled = True
        Me.cmbTitle.Location = New System.Drawing.Point(28, 44)
        Me.cmbTitle.Name = "cmbTitle"
        Me.cmbTitle.Size = New System.Drawing.Size(216, 23)
        Me.cmbTitle.TabIndex = 7
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.GroupBox7)
        Me.TabPage2.Controls.Add(Me.DataGridView2)
        Me.TabPage2.Controls.Add(Me.GroupBox8)
        Me.TabPage2.Controls.Add(Me.GroupBox9)
        Me.TabPage2.Location = New System.Drawing.Point(4, 24)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1056, 528)
        Me.TabPage2.TabIndex = 4
        Me.TabPage2.Text = "By Author"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.btnResetAuth)
        Me.GroupBox7.Location = New System.Drawing.Point(577, 20)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(227, 87)
        Me.GroupBox7.TabIndex = 28
        Me.GroupBox7.TabStop = False
        '
        'btnResetAuth
        '
        Me.btnResetAuth.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnResetAuth.Location = New System.Drawing.Point(16, 27)
        Me.btnResetAuth.Name = "btnResetAuth"
        Me.btnResetAuth.Size = New System.Drawing.Size(90, 40)
        Me.btnResetAuth.TabIndex = 1
        Me.btnResetAuth.Text = "&Reset"
        Me.btnResetAuth.UseVisualStyleBackColor = True
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
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn15, Me.DataGridViewTextBoxColumn16, Me.DataGridViewTextBoxColumn17, Me.DataGridViewTextBoxColumn18, Me.DataGridViewTextBoxColumn19, Me.DataGridViewTextBoxColumn20, Me.DataGridViewTextBoxColumn21, Me.DataGridViewTextBoxColumn22})
        Me.DataGridView2.DataSource = Me.BooktblBindingSource
        Me.DataGridView2.Location = New System.Drawing.Point(3, 113)
        Me.DataGridView2.MultiSelect = False
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.ReadOnly = True
        Me.DataGridView2.Size = New System.Drawing.Size(1047, 346)
        Me.DataGridView2.TabIndex = 27
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "bk_ISBN"
        Me.DataGridViewTextBoxColumn12.HeaderText = "ISBN"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.ReadOnly = True
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "bktitle"
        Me.DataGridViewTextBoxColumn13.HeaderText = "Title"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.ReadOnly = True
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "bkedition"
        Me.DataGridViewTextBoxColumn14.HeaderText = "Edition"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        Me.DataGridViewTextBoxColumn14.ReadOnly = True
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "bkauthor"
        Me.DataGridViewTextBoxColumn15.HeaderText = "Author"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        Me.DataGridViewTextBoxColumn15.ReadOnly = True
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "bkpublisher"
        Me.DataGridViewTextBoxColumn16.HeaderText = "Publisher"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        Me.DataGridViewTextBoxColumn16.ReadOnly = True
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "bkcopies"
        Me.DataGridViewTextBoxColumn17.HeaderText = "Available Copies"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        Me.DataGridViewTextBoxColumn17.ReadOnly = True
        Me.DataGridViewTextBoxColumn17.Width = 75
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.DataPropertyName = "bk_totalcopies"
        Me.DataGridViewTextBoxColumn18.HeaderText = "Total Copies"
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        Me.DataGridViewTextBoxColumn18.ReadOnly = True
        Me.DataGridViewTextBoxColumn18.Width = 70
        '
        'DataGridViewTextBoxColumn19
        '
        Me.DataGridViewTextBoxColumn19.DataPropertyName = "bk_cost"
        Me.DataGridViewTextBoxColumn19.HeaderText = "Cost"
        Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
        Me.DataGridViewTextBoxColumn19.ReadOnly = True
        Me.DataGridViewTextBoxColumn19.Width = 80
        '
        'DataGridViewTextBoxColumn20
        '
        Me.DataGridViewTextBoxColumn20.DataPropertyName = "bk_remarks"
        Me.DataGridViewTextBoxColumn20.HeaderText = "Remarks"
        Me.DataGridViewTextBoxColumn20.Name = "DataGridViewTextBoxColumn20"
        Me.DataGridViewTextBoxColumn20.ReadOnly = True
        '
        'DataGridViewTextBoxColumn21
        '
        Me.DataGridViewTextBoxColumn21.DataPropertyName = "bk_publishdate"
        Me.DataGridViewTextBoxColumn21.HeaderText = "Date Published"
        Me.DataGridViewTextBoxColumn21.Name = "DataGridViewTextBoxColumn21"
        Me.DataGridViewTextBoxColumn21.ReadOnly = True
        Me.DataGridViewTextBoxColumn21.Width = 80
        '
        'DataGridViewTextBoxColumn22
        '
        Me.DataGridViewTextBoxColumn22.DataPropertyName = "category_name"
        Me.DataGridViewTextBoxColumn22.HeaderText = "Category Name"
        Me.DataGridViewTextBoxColumn22.Name = "DataGridViewTextBoxColumn22"
        Me.DataGridViewTextBoxColumn22.ReadOnly = True
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.txtAuthor)
        Me.GroupBox8.Controls.Add(Me.Label3)
        Me.GroupBox8.Location = New System.Drawing.Point(291, 20)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(272, 87)
        Me.GroupBox8.TabIndex = 26
        Me.GroupBox8.TabStop = False
        '
        'txtAuthor
        '
        Me.txtAuthor.Location = New System.Drawing.Point(28, 44)
        Me.txtAuthor.Name = "txtAuthor"
        Me.txtAuthor.Size = New System.Drawing.Size(221, 21)
        Me.txtAuthor.TabIndex = 9
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(25, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 15)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Author"
        '
        'GroupBox9
        '
        Me.GroupBox9.Controls.Add(Me.Label4)
        Me.GroupBox9.Controls.Add(Me.cmbAuthor)
        Me.GroupBox9.Location = New System.Drawing.Point(8, 20)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Size = New System.Drawing.Size(266, 87)
        Me.GroupBox9.TabIndex = 25
        Me.GroupBox9.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(25, 20)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 15)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Author"
        '
        'cmbAuthor
        '
        Me.cmbAuthor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cmbAuthor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbAuthor.DataSource = Me.BooktblBindingSource
        Me.cmbAuthor.DisplayMember = "bkauthor"
        Me.cmbAuthor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbAuthor.FormattingEnabled = True
        Me.cmbAuthor.Location = New System.Drawing.Point(28, 44)
        Me.cmbAuthor.Name = "cmbAuthor"
        Me.cmbAuthor.Size = New System.Drawing.Size(216, 23)
        Me.cmbAuthor.TabIndex = 7
        '
        'Booktbl1TableAdapter
        '
        Me.Booktbl1TableAdapter.ClearBeforeFill = True
        '
        'BooktblTableAdapter
        '
        Me.BooktblTableAdapter.ClearBeforeFill = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PictureBox1.Location = New System.Drawing.Point(0, -2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1064, 39)
        Me.PictureBox1.TabIndex = 15
        Me.PictureBox1.TabStop = False
        '
        'BooktblBindingSource1
        '
        Me.BooktblBindingSource1.DataMember = "booktbl"
        Me.BooktblBindingSource1.DataSource = Me.Test3DataSet
        '
        'frmBookSearch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1062, 542)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.tabControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmBookSearch"
        Me.Text = "Book Search"
        Me.tabControl1.ResumeLayout(False)
        Me.tabPage3.ResumeLayout(False)
        Me.groupBox4.ResumeLayout(False)
        CType(Me.dataGridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BooktblBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Test3DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupBox3.ResumeLayout(False)
        Me.groupBox3.PerformLayout()
        Me.groupBox2.ResumeLayout(False)
        Me.groupBox2.PerformLayout()
        CType(Me.Booktbl1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.GroupBox7.ResumeLayout(False)
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
        Me.GroupBox9.ResumeLayout(False)
        Me.GroupBox9.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BooktblBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents tabControl1 As TabControl
    Private WithEvents tabPage3 As TabPage
    Friend WithEvents groupBox4 As GroupBox
    Friend WithEvents btnExport1 As Button
    Friend WithEvents btnReset As Button
    Public WithEvents dataGridView3 As DataGridView
    Private WithEvents groupBox3 As GroupBox
    Private WithEvents txtISBN As TextBox
    Private WithEvents label8 As Label
    Private WithEvents groupBox2 As GroupBox
    Private WithEvents label7 As Label
    Public WithEvents cmbISBN As ComboBox
    Friend WithEvents Test3DataSet As test3DataSet
    Friend WithEvents Booktbl1BindingSource As BindingSource
    Friend WithEvents Booktbl1TableAdapter As test3DataSetTableAdapters.booktbl1TableAdapter
    Friend WithEvents BooktblBindingSource As BindingSource
    Friend WithEvents BooktblTableAdapter As test3DataSetTableAdapters.booktblTableAdapter
    Friend WithEvents PictureBox1 As PictureBox
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
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnResetTitle As Button
    Public WithEvents DataGridView1 As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Private WithEvents GroupBox5 As GroupBox
    Private WithEvents txtTitle As TextBox
    Private WithEvents Label1 As Label
    Private WithEvents GroupBox6 As GroupBox
    Private WithEvents Label2 As Label
    Public WithEvents cmbTitle As ComboBox
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents GroupBox7 As GroupBox
    Friend WithEvents btnResetAuth As Button
    Public WithEvents DataGridView2 As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn18 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn19 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn20 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn21 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn22 As DataGridViewTextBoxColumn
    Private WithEvents GroupBox8 As GroupBox
    Private WithEvents txtAuthor As TextBox
    Private WithEvents Label3 As Label
    Private WithEvents GroupBox9 As GroupBox
    Private WithEvents Label4 As Label
    Public WithEvents cmbAuthor As ComboBox
    Friend WithEvents BooktblBindingSource1 As BindingSource
End Class
