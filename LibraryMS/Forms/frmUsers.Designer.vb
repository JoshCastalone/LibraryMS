<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUsers
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txtFName = New System.Windows.Forms.TextBox()
        Me.txtLName = New System.Windows.Forms.TextBox()
        Me.txtPass = New System.Windows.Forms.TextBox()
        Me.cmbRoles = New System.Windows.Forms.ComboBox()
        Me.UsertblBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet1 = New LibraryMS.DataSet1()
        Me.label9 = New System.Windows.Forms.Label()
        Me.label8 = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.dgvUsers = New System.Windows.Forms.DataGridView()
        Me.FnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UsernameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PassDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RoleDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UsertblBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnDisable = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.UsertblTableAdapter = New LibraryMS.DataSet1TableAdapters.usertblTableAdapter()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.txtUName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UsertblBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvUsers, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UsertblBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PictureBox1.Location = New System.Drawing.Point(-147, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1064, 39)
        Me.PictureBox1.TabIndex = 17
        Me.PictureBox1.TabStop = False
        '
        'txtFName
        '
        Me.txtFName.Location = New System.Drawing.Point(152, 58)
        Me.txtFName.Name = "txtFName"
        Me.txtFName.Size = New System.Drawing.Size(171, 20)
        Me.txtFName.TabIndex = 1
        '
        'txtLName
        '
        Me.txtLName.Location = New System.Drawing.Point(152, 89)
        Me.txtLName.Name = "txtLName"
        Me.txtLName.Size = New System.Drawing.Size(171, 20)
        Me.txtLName.TabIndex = 2
        '
        'txtPass
        '
        Me.txtPass.Location = New System.Drawing.Point(152, 152)
        Me.txtPass.Name = "txtPass"
        Me.txtPass.Size = New System.Drawing.Size(171, 20)
        Me.txtPass.TabIndex = 4
        '
        'cmbRoles
        '
        Me.cmbRoles.FormattingEnabled = True
        Me.cmbRoles.Location = New System.Drawing.Point(152, 180)
        Me.cmbRoles.Name = "cmbRoles"
        Me.cmbRoles.Size = New System.Drawing.Size(171, 21)
        Me.cmbRoles.TabIndex = 5
        '
        'UsertblBindingSource1
        '
        Me.UsertblBindingSource1.DataMember = "usertbl"
        Me.UsertblBindingSource1.DataSource = Me.DataSet1
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'label9
        '
        Me.label9.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.label9.AutoSize = True
        Me.label9.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.label9.Location = New System.Drawing.Point(113, 182)
        Me.label9.Name = "label9"
        Me.label9.Size = New System.Drawing.Size(33, 15)
        Me.label9.TabIndex = 29
        Me.label9.Text = "Role:"
        '
        'label8
        '
        Me.label8.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.label8.AutoSize = True
        Me.label8.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.label8.Location = New System.Drawing.Point(86, 156)
        Me.label8.Name = "label8"
        Me.label8.Size = New System.Drawing.Size(60, 15)
        Me.label8.TabIndex = 30
        Me.label8.Text = "Password:"
        '
        'label3
        '
        Me.label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.label3.AutoSize = True
        Me.label3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.label3.Location = New System.Drawing.Point(80, 91)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(66, 15)
        Me.label3.TabIndex = 31
        Me.label3.Text = "Last Name:"
        '
        'label1
        '
        Me.label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.label1.Location = New System.Drawing.Point(79, 60)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(67, 15)
        Me.label1.TabIndex = 32
        Me.label1.Text = "First Name:"
        '
        'dgvUsers
        '
        Me.dgvUsers.AllowUserToAddRows = False
        Me.dgvUsers.AllowUserToDeleteRows = False
        Me.dgvUsers.AutoGenerateColumns = False
        Me.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvUsers.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.FnameDataGridViewTextBoxColumn, Me.LnameDataGridViewTextBoxColumn, Me.UsernameDataGridViewTextBoxColumn, Me.PassDataGridViewTextBoxColumn, Me.RoleDataGridViewTextBoxColumn})
        Me.dgvUsers.DataSource = Me.UsertblBindingSource
        Me.dgvUsers.Location = New System.Drawing.Point(1, 251)
        Me.dgvUsers.Name = "dgvUsers"
        Me.dgvUsers.ReadOnly = True
        Me.dgvUsers.Size = New System.Drawing.Size(420, 239)
        Me.dgvUsers.TabIndex = 33
        '
        'FnameDataGridViewTextBoxColumn
        '
        Me.FnameDataGridViewTextBoxColumn.DataPropertyName = "Fname"
        Me.FnameDataGridViewTextBoxColumn.HeaderText = "First Name"
        Me.FnameDataGridViewTextBoxColumn.Name = "FnameDataGridViewTextBoxColumn"
        Me.FnameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'LnameDataGridViewTextBoxColumn
        '
        Me.LnameDataGridViewTextBoxColumn.DataPropertyName = "Lname"
        Me.LnameDataGridViewTextBoxColumn.HeaderText = "Last Name"
        Me.LnameDataGridViewTextBoxColumn.Name = "LnameDataGridViewTextBoxColumn"
        Me.LnameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'UsernameDataGridViewTextBoxColumn
        '
        Me.UsernameDataGridViewTextBoxColumn.DataPropertyName = "username"
        Me.UsernameDataGridViewTextBoxColumn.HeaderText = "User Name"
        Me.UsernameDataGridViewTextBoxColumn.Name = "UsernameDataGridViewTextBoxColumn"
        Me.UsernameDataGridViewTextBoxColumn.ReadOnly = True
        Me.UsernameDataGridViewTextBoxColumn.Width = 90
        '
        'PassDataGridViewTextBoxColumn
        '
        Me.PassDataGridViewTextBoxColumn.DataPropertyName = "pass"
        Me.PassDataGridViewTextBoxColumn.HeaderText = "Password"
        Me.PassDataGridViewTextBoxColumn.Name = "PassDataGridViewTextBoxColumn"
        Me.PassDataGridViewTextBoxColumn.ReadOnly = True
        '
        'RoleDataGridViewTextBoxColumn
        '
        Me.RoleDataGridViewTextBoxColumn.DataPropertyName = "role"
        Me.RoleDataGridViewTextBoxColumn.HeaderText = "Role"
        Me.RoleDataGridViewTextBoxColumn.Name = "RoleDataGridViewTextBoxColumn"
        Me.RoleDataGridViewTextBoxColumn.ReadOnly = True
        '
        'UsertblBindingSource
        '
        Me.UsertblBindingSource.DataMember = "usertbl"
        Me.UsertblBindingSource.DataSource = Me.DataSet1
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(54, 222)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 6
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnDisable
        '
        Me.btnDisable.Location = New System.Drawing.Point(216, 222)
        Me.btnDisable.Name = "btnDisable"
        Me.btnDisable.Size = New System.Drawing.Size(75, 23)
        Me.btnDisable.TabIndex = 8
        Me.btnDisable.Text = "Disable"
        Me.btnDisable.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(297, 222)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 9
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'UsertblTableAdapter
        '
        Me.UsertblTableAdapter.ClearBeforeFill = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(135, 222)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(75, 23)
        Me.btnUpdate.TabIndex = 7
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'txtUName
        '
        Me.txtUName.Location = New System.Drawing.Point(152, 121)
        Me.txtUName.Name = "txtUName"
        Me.txtUName.Size = New System.Drawing.Size(171, 20)
        Me.txtUName.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(78, 123)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 15)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = "User Name:"
        '
        'frmUsers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(421, 490)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnDisable)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.dgvUsers)
        Me.Controls.Add(Me.label9)
        Me.Controls.Add(Me.label8)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.cmbRoles)
        Me.Controls.Add(Me.txtUName)
        Me.Controls.Add(Me.txtPass)
        Me.Controls.Add(Me.txtLName)
        Me.Controls.Add(Me.txtFName)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "frmUsers"
        Me.Text = "frmUsers"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UsertblBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvUsers, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UsertblBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txtFName As TextBox
    Friend WithEvents txtLName As TextBox
    Friend WithEvents txtPass As TextBox
    Friend WithEvents cmbRoles As ComboBox
    Private WithEvents label9 As Label
    Private WithEvents label8 As Label
    Private WithEvents label3 As Label
    Private WithEvents label1 As Label
    Friend WithEvents dgvUsers As DataGridView
    Friend WithEvents btnSave As Button
    Friend WithEvents btnDisable As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents DataSet1 As DataSet1
    Friend WithEvents UsertblBindingSource As BindingSource
    Friend WithEvents UsertblTableAdapter As DataSet1TableAdapters.usertblTableAdapter
    Friend WithEvents UsertblBindingSource1 As BindingSource
    Friend WithEvents btnUpdate As Button
    Friend WithEvents txtUName As TextBox
    Private WithEvents Label2 As Label
    Friend WithEvents FnameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LnameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UsernameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PassDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RoleDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
