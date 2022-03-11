<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSectionStrand
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSectionStrand))
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnInsert = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtSSName = New System.Windows.Forms.TextBox()
        Me.txtSSID = New System.Windows.Forms.TextBox()
        Me.dtgSecStrand = New System.Windows.Forms.DataGridView()
        Me.SectionstrandtblidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SectionstrandnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SectionstrandtblBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet2 = New LibraryMS.DataSet2()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Section_strandtblTableAdapter = New LibraryMS.DataSet2TableAdapters.section_strandtblTableAdapter()
        CType(Me.dtgSecStrand, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SectionstrandtblBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(224, 109)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 23)
        Me.btnDelete.TabIndex = 24
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(143, 109)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(75, 23)
        Me.btnUpdate.TabIndex = 25
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnInsert
        '
        Me.btnInsert.Location = New System.Drawing.Point(62, 109)
        Me.btnInsert.Name = "btnInsert"
        Me.btnInsert.Size = New System.Drawing.Size(75, 23)
        Me.btnInsert.TabIndex = 26
        Me.btnInsert.Text = "Insert"
        Me.btnInsert.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 77)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(113, 13)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Section/Strand Name:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 13)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "Section/Strand ID:"
        '
        'txtSSName
        '
        Me.txtSSName.Location = New System.Drawing.Point(128, 74)
        Me.txtSSName.Name = "txtSSName"
        Me.txtSSName.Size = New System.Drawing.Size(216, 20)
        Me.txtSSName.TabIndex = 20
        '
        'txtSSID
        '
        Me.txtSSID.Location = New System.Drawing.Point(128, 48)
        Me.txtSSID.Name = "txtSSID"
        Me.txtSSID.Size = New System.Drawing.Size(70, 20)
        Me.txtSSID.TabIndex = 21
        '
        'dtgSecStrand
        '
        Me.dtgSecStrand.AllowUserToAddRows = False
        Me.dtgSecStrand.AllowUserToDeleteRows = False
        Me.dtgSecStrand.AutoGenerateColumns = False
        Me.dtgSecStrand.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgSecStrand.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SectionstrandtblidDataGridViewTextBoxColumn, Me.SectionstrandnameDataGridViewTextBoxColumn})
        Me.dtgSecStrand.DataSource = Me.SectionstrandtblBindingSource
        Me.dtgSecStrand.Location = New System.Drawing.Point(0, 138)
        Me.dtgSecStrand.Name = "dtgSecStrand"
        Me.dtgSecStrand.ReadOnly = True
        Me.dtgSecStrand.Size = New System.Drawing.Size(356, 285)
        Me.dtgSecStrand.TabIndex = 19
        '
        'SectionstrandtblidDataGridViewTextBoxColumn
        '
        Me.SectionstrandtblidDataGridViewTextBoxColumn.DataPropertyName = "section_strandtbl_id"
        Me.SectionstrandtblidDataGridViewTextBoxColumn.HeaderText = "Section/Strand ID"
        Me.SectionstrandtblidDataGridViewTextBoxColumn.Name = "SectionstrandtblidDataGridViewTextBoxColumn"
        Me.SectionstrandtblidDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SectionstrandnameDataGridViewTextBoxColumn
        '
        Me.SectionstrandnameDataGridViewTextBoxColumn.DataPropertyName = "section_strand_name"
        Me.SectionstrandnameDataGridViewTextBoxColumn.HeaderText = "Section/Strand Name"
        Me.SectionstrandnameDataGridViewTextBoxColumn.Name = "SectionstrandnameDataGridViewTextBoxColumn"
        Me.SectionstrandnameDataGridViewTextBoxColumn.ReadOnly = True
        Me.SectionstrandnameDataGridViewTextBoxColumn.Width = 210
        '
        'SectionstrandtblBindingSource
        '
        Me.SectionstrandtblBindingSource.DataMember = "section_strandtbl"
        Me.SectionstrandtblBindingSource.DataSource = Me.DataSet2
        '
        'DataSet2
        '
        Me.DataSet2.DataSetName = "DataSet2"
        Me.DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PictureBox1.Location = New System.Drawing.Point(-358, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1064, 39)
        Me.PictureBox1.TabIndex = 27
        Me.PictureBox1.TabStop = False
        '
        'Section_strandtblTableAdapter
        '
        Me.Section_strandtblTableAdapter.ClearBeforeFill = True
        '
        'frmSectionStrand
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
        Me.Controls.Add(Me.txtSSName)
        Me.Controls.Add(Me.txtSSID)
        Me.Controls.Add(Me.dtgSecStrand)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmSectionStrand"
        Me.Text = "Section/Strand"
        CType(Me.dtgSecStrand, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SectionstrandtblBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnInsert As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtSSName As TextBox
    Friend WithEvents txtSSID As TextBox
    Friend WithEvents dtgSecStrand As DataGridView
    Friend WithEvents DataSet2 As DataSet2
    Friend WithEvents SectionstrandtblBindingSource As BindingSource
    Friend WithEvents Section_strandtblTableAdapter As DataSet2TableAdapters.section_strandtblTableAdapter
    Friend WithEvents SectionstrandtblidDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SectionstrandnameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
