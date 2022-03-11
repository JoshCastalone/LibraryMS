<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmBookSearch2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBookSearch2))
        Me.DataGridView4 = New System.Windows.Forms.DataGridView()
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
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Test3DataSet1 = New LibraryMS.test3DataSet()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.BooktblTableAdapter1 = New LibraryMS.test3DataSetTableAdapters.booktblTableAdapter()
        Me.btnClear = New System.Windows.Forms.Button()
        CType(Me.DataGridView4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Test3DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView4
        '
        Me.DataGridView4.AllowUserToAddRows = False
        Me.DataGridView4.AllowUserToDeleteRows = False
        Me.DataGridView4.AutoGenerateColumns = False
        Me.DataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView4.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11})
        Me.DataGridView4.DataSource = Me.BindingSource1
        Me.DataGridView4.Location = New System.Drawing.Point(0, 119)
        Me.DataGridView4.Name = "DataGridView4"
        Me.DataGridView4.ReadOnly = True
        Me.DataGridView4.Size = New System.Drawing.Size(748, 358)
        Me.DataGridView4.TabIndex = 0
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
        Me.DataGridViewTextBoxColumn6.Width = 80
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "bk_totalcopies"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Total Copies"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.Width = 80
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "bk_cost"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Cost"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        Me.DataGridViewTextBoxColumn8.Width = 85
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "bk_remarks"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Remarks"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        Me.DataGridViewTextBoxColumn9.Width = 90
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "bk_publishdate"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Date Published"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        Me.DataGridViewTextBoxColumn10.Width = 90
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "category_name"
        Me.DataGridViewTextBoxColumn11.HeaderText = "Category Name"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.ReadOnly = True
        '
        'BindingSource1
        '
        Me.BindingSource1.DataMember = "booktbl"
        Me.BindingSource1.DataSource = Me.Test3DataSet1
        '
        'Test3DataSet1
        '
        Me.Test3DataSet1.DataSetName = "test3DataSet"
        Me.Test3DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(56, 74)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(568, 20)
        Me.txtSearch.TabIndex = 2
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PictureBox2.Location = New System.Drawing.Point(0, -1)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(748, 50)
        Me.PictureBox2.TabIndex = 3
        Me.PictureBox2.TabStop = False
        '
        'BooktblTableAdapter1
        '
        Me.BooktblTableAdapter1.ClearBeforeFill = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(630, 74)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 1
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'frmBookSearch2
        '
        Me.ClientSize = New System.Drawing.Size(750, 505)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.DataGridView4)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimizeBox = False
        Me.Name = "frmBookSearch2"
        Me.Text = "Book Search"
        CType(Me.DataGridView4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Test3DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
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
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnResetTitle As Button
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
    Private WithEvents GroupBox8 As GroupBox
    Private WithEvents txtAuthor As TextBox
    Private WithEvents Label3 As Label
    Private WithEvents GroupBox9 As GroupBox
    Private WithEvents Label4 As Label
    Public WithEvents cmbAuthor As ComboBox
    Friend WithEvents Test3DataSet As test3DataSet
    Friend WithEvents Booktbl1BindingSource As BindingSource
    Friend WithEvents Booktbl1TableAdapter As test3DataSetTableAdapters.booktbl1TableAdapter
    Friend WithEvents BooktblBindingSource As BindingSource
    Friend WithEvents BooktblTableAdapter As test3DataSetTableAdapters.booktblTableAdapter
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
    Public WithEvents DataGridView1 As DataGridView
    Friend WithEvents BkISBNDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents BktitleDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents BkeditionDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents BkauthorDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents BkpublisherDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents BkcopiesDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents BktotalcopiesDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents BkcostDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents BkremarksDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents BkpublishdateDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents CategorynameDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents BkISBNDataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents BktitleDataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents BkeditionDataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents BkauthorDataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents BkpublisherDataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents BkcopiesDataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents BktotalcopiesDataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents BkcostDataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents BkremarksDataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents BkpublishdateDataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents CategorynameDataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridView4 As DataGridView
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Test3DataSet1 As LibraryMS.test3DataSet
    Friend WithEvents BindingSource1 As BindingSource
    Friend WithEvents BooktblTableAdapter1 As LibraryMS.test3DataSetTableAdapters.booktblTableAdapter
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
    Friend WithEvents btnClear As Button
End Class
