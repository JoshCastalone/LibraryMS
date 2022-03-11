<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGradeLevel
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGradeLevel))
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnInsert = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtGradeName = New System.Windows.Forms.TextBox()
        Me.txtGradeNo = New System.Windows.Forms.TextBox()
        Me.dtgGradeLevel = New System.Windows.Forms.DataGridView()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.DataSet2 = New LibraryMS.DataSet2()
        Me.GradeleveltblBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Gradelevel_tblTableAdapter = New LibraryMS.DataSet2TableAdapters.gradelevel_tblTableAdapter()
        Me.GradelevelidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GradelevelnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dtgGradeLevel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GradeleveltblBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(228, 109)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 23)
        Me.btnDelete.TabIndex = 33
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(147, 109)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(75, 23)
        Me.btnUpdate.TabIndex = 34
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnInsert
        '
        Me.btnInsert.Location = New System.Drawing.Point(66, 109)
        Me.btnInsert.Name = "btnInsert"
        Me.btnInsert.Size = New System.Drawing.Size(75, 23)
        Me.btnInsert.TabIndex = 35
        Me.btnInsert.Text = "Insert"
        Me.btnInsert.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(17, 77)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 13)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = "Grade Level:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 13)
        Me.Label1.TabIndex = 32
        Me.Label1.Text = "Grade Level No.:"
        '
        'txtGradeName
        '
        Me.txtGradeName.Location = New System.Drawing.Point(106, 74)
        Me.txtGradeName.Name = "txtGradeName"
        Me.txtGradeName.Size = New System.Drawing.Size(228, 20)
        Me.txtGradeName.TabIndex = 29
        '
        'txtGradeNo
        '
        Me.txtGradeNo.Location = New System.Drawing.Point(106, 48)
        Me.txtGradeNo.Name = "txtGradeNo"
        Me.txtGradeNo.Size = New System.Drawing.Size(70, 20)
        Me.txtGradeNo.TabIndex = 30
        '
        'dtgGradeLevel
        '
        Me.dtgGradeLevel.AllowUserToAddRows = False
        Me.dtgGradeLevel.AllowUserToDeleteRows = False
        Me.dtgGradeLevel.AutoGenerateColumns = False
        Me.dtgGradeLevel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgGradeLevel.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.GradelevelidDataGridViewTextBoxColumn, Me.GradelevelnameDataGridViewTextBoxColumn})
        Me.dtgGradeLevel.DataSource = Me.GradeleveltblBindingSource
        Me.dtgGradeLevel.Location = New System.Drawing.Point(0, 138)
        Me.dtgGradeLevel.Name = "dtgGradeLevel"
        Me.dtgGradeLevel.ReadOnly = True
        Me.dtgGradeLevel.Size = New System.Drawing.Size(356, 285)
        Me.dtgGradeLevel.TabIndex = 28
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PictureBox1.Location = New System.Drawing.Point(-354, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1064, 39)
        Me.PictureBox1.TabIndex = 36
        Me.PictureBox1.TabStop = False
        '
        'DataSet2
        '
        Me.DataSet2.DataSetName = "DataSet2"
        Me.DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GradeleveltblBindingSource
        '
        Me.GradeleveltblBindingSource.DataMember = "gradelevel_tbl"
        Me.GradeleveltblBindingSource.DataSource = Me.DataSet2
        '
        'Gradelevel_tblTableAdapter
        '
        Me.Gradelevel_tblTableAdapter.ClearBeforeFill = True
        '
        'GradelevelidDataGridViewTextBoxColumn
        '
        Me.GradelevelidDataGridViewTextBoxColumn.DataPropertyName = "gradelevel_id"
        Me.GradelevelidDataGridViewTextBoxColumn.HeaderText = "Grade Level No."
        Me.GradelevelidDataGridViewTextBoxColumn.Name = "GradelevelidDataGridViewTextBoxColumn"
        Me.GradelevelidDataGridViewTextBoxColumn.ReadOnly = True
        '
        'GradelevelnameDataGridViewTextBoxColumn
        '
        Me.GradelevelnameDataGridViewTextBoxColumn.DataPropertyName = "gradelevel_name"
        Me.GradelevelnameDataGridViewTextBoxColumn.HeaderText = "Grade Level"
        Me.GradelevelnameDataGridViewTextBoxColumn.Name = "GradelevelnameDataGridViewTextBoxColumn"
        Me.GradelevelnameDataGridViewTextBoxColumn.ReadOnly = True
        Me.GradelevelnameDataGridViewTextBoxColumn.Width = 210
        '
        'frmGradeLevel
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
        Me.Controls.Add(Me.txtGradeName)
        Me.Controls.Add(Me.txtGradeNo)
        Me.Controls.Add(Me.dtgGradeLevel)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmGradeLevel"
        Me.Text = "Grade Level"
        CType(Me.dtgGradeLevel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GradeleveltblBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnInsert As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtGradeName As TextBox
    Friend WithEvents txtGradeNo As TextBox
    Friend WithEvents dtgGradeLevel As DataGridView
    Friend WithEvents DataSet2 As DataSet2
    Friend WithEvents GradeleveltblBindingSource As BindingSource
    Friend WithEvents Gradelevel_tblTableAdapter As DataSet2TableAdapters.gradelevel_tblTableAdapter
    Friend WithEvents GradelevelidDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GradelevelnameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
