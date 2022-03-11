<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBookCategories
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBookCategories))
        Me.dtgCategories = New System.Windows.Forms.DataGridView()
        Me.CategoryidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CategorynameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CategorytblBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Test3DataSet = New LibraryMS.test3DataSet()
        Me.txtCatID = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCatName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnInsert = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.CategorytblTableAdapter = New LibraryMS.test3DataSetTableAdapters.categorytblTableAdapter()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.dtgCategories, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CategorytblBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Test3DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dtgCategories
        '
        Me.dtgCategories.AllowUserToAddRows = False
        Me.dtgCategories.AllowUserToDeleteRows = False
        Me.dtgCategories.AutoGenerateColumns = False
        Me.dtgCategories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgCategories.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CategoryidDataGridViewTextBoxColumn, Me.CategorynameDataGridViewTextBoxColumn})
        Me.dtgCategories.DataSource = Me.CategorytblBindingSource
        Me.dtgCategories.Location = New System.Drawing.Point(1, 134)
        Me.dtgCategories.Name = "dtgCategories"
        Me.dtgCategories.ReadOnly = True
        Me.dtgCategories.Size = New System.Drawing.Size(356, 285)
        Me.dtgCategories.TabIndex = 0
        '
        'CategoryidDataGridViewTextBoxColumn
        '
        Me.CategoryidDataGridViewTextBoxColumn.DataPropertyName = "category_id"
        Me.CategoryidDataGridViewTextBoxColumn.HeaderText = "Category ID"
        Me.CategoryidDataGridViewTextBoxColumn.Name = "CategoryidDataGridViewTextBoxColumn"
        Me.CategoryidDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CategorynameDataGridViewTextBoxColumn
        '
        Me.CategorynameDataGridViewTextBoxColumn.DataPropertyName = "category_name"
        Me.CategorynameDataGridViewTextBoxColumn.HeaderText = "Category Name"
        Me.CategorynameDataGridViewTextBoxColumn.Name = "CategorynameDataGridViewTextBoxColumn"
        Me.CategorynameDataGridViewTextBoxColumn.ReadOnly = True
        Me.CategorynameDataGridViewTextBoxColumn.Width = 210
        '
        'CategorytblBindingSource
        '
        Me.CategorytblBindingSource.DataMember = "categorytbl"
        Me.CategorytblBindingSource.DataSource = Me.Test3DataSet
        '
        'Test3DataSet
        '
        Me.Test3DataSet.DataSetName = "test3DataSet"
        Me.Test3DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'txtCatID
        '
        Me.txtCatID.Location = New System.Drawing.Point(103, 44)
        Me.txtCatID.Name = "txtCatID"
        Me.txtCatID.Size = New System.Drawing.Size(70, 20)
        Me.txtCatID.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Category ID:"
        '
        'txtCatName
        '
        Me.txtCatName.Location = New System.Drawing.Point(103, 70)
        Me.txtCatName.Name = "txtCatName"
        Me.txtCatName.Size = New System.Drawing.Size(228, 20)
        Me.txtCatName.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(14, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Category Name:"
        '
        'btnInsert
        '
        Me.btnInsert.Location = New System.Drawing.Point(63, 105)
        Me.btnInsert.Name = "btnInsert"
        Me.btnInsert.Size = New System.Drawing.Size(75, 23)
        Me.btnInsert.TabIndex = 3
        Me.btnInsert.Text = "Insert"
        Me.btnInsert.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(144, 105)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(75, 23)
        Me.btnUpdate.TabIndex = 3
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(225, 105)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 23)
        Me.btnDelete.TabIndex = 3
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'CategorytblTableAdapter
        '
        Me.CategorytblTableAdapter.ClearBeforeFill = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PictureBox1.Location = New System.Drawing.Point(-357, -2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1064, 39)
        Me.PictureBox1.TabIndex = 18
        Me.PictureBox1.TabStop = False
        '
        'frmBookCategories
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(356, 440)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnInsert)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtCatName)
        Me.Controls.Add(Me.txtCatID)
        Me.Controls.Add(Me.dtgCategories)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmBookCategories"
        Me.Text = "Book Categories"
        CType(Me.dtgCategories, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CategorytblBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Test3DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dtgCategories As DataGridView
    Friend WithEvents txtCatID As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtCatName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnInsert As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents Test3DataSet As test3DataSet
    Friend WithEvents CategorytblBindingSource As BindingSource
    Friend WithEvents CategorytblTableAdapter As test3DataSetTableAdapters.categorytblTableAdapter
    Friend WithEvents CategoryidDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CategorynameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PictureBox1 As PictureBox
End Class
