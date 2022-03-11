<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmBorrower
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBorrower))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtStudentID = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtMobileNo = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtStudentName = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtPhoneNo = New System.Windows.Forms.TextBox()
        Me.btnUpdate_record = New System.Windows.Forms.Button()
        Me.btnDisable = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnNewRecord = New System.Windows.Forms.Button()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.lblStaffProfile = New System.Windows.Forms.Label()
        Me.panel1 = New System.Windows.Forms.Panel()
        Me.txtContactNo = New System.Windows.Forms.GroupBox()
        Me.txtBorrowerID = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtpDOB = New System.Windows.Forms.DateTimePicker()
        Me.txtAcademicYear = New System.Windows.Forms.MaskedTextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.cmbGradeLevel = New System.Windows.Forms.ComboBox()
        Me.cmbGender = New System.Windows.Forms.ComboBox()
        Me.cmbSectionStrand = New System.Windows.Forms.ComboBox()
        Me.label29 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.label28 = New System.Windows.Forms.Label()
        Me.label6 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel1.SuspendLayout()
        Me.txtContactNo.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PictureBox1.Location = New System.Drawing.Point(-141, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1064, 39)
        Me.PictureBox1.TabIndex = 17
        Me.PictureBox1.TabStop = False
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(37, 210)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(42, 16)
        Me.Label14.TabIndex = 106
        Me.Label14.Text = "*Year"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(37, 106)
        Me.Label13.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(58, 16)
        Me.Label13.TabIndex = 104
        Me.Label13.Text = "*Gender"
        '
        'txtStudentID
        '
        Me.txtStudentID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtStudentID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStudentID.Location = New System.Drawing.Point(174, 32)
        Me.txtStudentID.Name = "txtStudentID"
        Me.txtStudentID.Size = New System.Drawing.Size(143, 22)
        Me.txtStudentID.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(37, 35)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(69, 16)
        Me.Label5.TabIndex = 61
        Me.Label5.Text = "Student ID"
        '
        'txtMobileNo
        '
        Me.txtMobileNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMobileNo.Location = New System.Drawing.Point(441, 416)
        Me.txtMobileNo.Name = "txtMobileNo"
        Me.txtMobileNo.Size = New System.Drawing.Size(166, 22)
        Me.txtMobileNo.TabIndex = 11
        '
        'Label4
        '
        Me.Label4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(357, 416)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 16)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "*Mobile No."
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(332, 32)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(28, 23)
        Me.Button1.TabIndex = 17
        Me.Button1.Text = ">"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtStudentName
        '
        Me.txtStudentName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStudentName.Location = New System.Drawing.Point(174, 71)
        Me.txtStudentName.Name = "txtStudentName"
        Me.txtStudentName.Size = New System.Drawing.Size(207, 22)
        Me.txtStudentName.TabIndex = 2
        '
        'Label7
        '
        Me.Label7.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(37, 459)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(42, 16)
        Me.Label7.TabIndex = 49
        Me.Label7.Text = "Email"
        '
        'txtPhoneNo
        '
        Me.txtPhoneNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPhoneNo.Location = New System.Drawing.Point(174, 416)
        Me.txtPhoneNo.Name = "txtPhoneNo"
        Me.txtPhoneNo.Size = New System.Drawing.Size(166, 22)
        Me.txtPhoneNo.TabIndex = 10
        '
        'btnUpdate_record
        '
        Me.btnUpdate_record.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate_record.Location = New System.Drawing.Point(16, 92)
        Me.btnUpdate_record.Name = "btnUpdate_record"
        Me.btnUpdate_record.Size = New System.Drawing.Size(95, 33)
        Me.btnUpdate_record.TabIndex = 15
        Me.btnUpdate_record.Text = "&Update"
        Me.btnUpdate_record.UseVisualStyleBackColor = True
        '
        'btnDisable
        '
        Me.btnDisable.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDisable.Location = New System.Drawing.Point(16, 131)
        Me.btnDisable.Name = "btnDisable"
        Me.btnDisable.Size = New System.Drawing.Size(95, 33)
        Me.btnDisable.TabIndex = 16
        Me.btnDisable.Text = "&Disable"
        Me.btnDisable.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(16, 53)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(95, 33)
        Me.btnSave.TabIndex = 14
        Me.btnSave.Text = "&Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnNewRecord
        '
        Me.btnNewRecord.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNewRecord.Location = New System.Drawing.Point(16, 14)
        Me.btnNewRecord.Name = "btnNewRecord"
        Me.btnNewRecord.Size = New System.Drawing.Size(95, 33)
        Me.btnNewRecord.TabIndex = 13
        Me.btnNewRecord.Text = "&New"
        Me.btnNewRecord.UseVisualStyleBackColor = True
        '
        'txtAddress
        '
        Me.txtAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddress.Location = New System.Drawing.Point(174, 295)
        Me.txtAddress.Multiline = True
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtAddress.Size = New System.Drawing.Size(433, 58)
        Me.txtAddress.TabIndex = 8
        '
        'lblStaffProfile
        '
        Me.lblStaffProfile.AutoSize = True
        Me.lblStaffProfile.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStaffProfile.Location = New System.Drawing.Point(315, -47)
        Me.lblStaffProfile.Name = "lblStaffProfile"
        Me.lblStaffProfile.Size = New System.Drawing.Size(241, 37)
        Me.lblStaffProfile.TabIndex = 20
        Me.lblStaffProfile.Text = "Student Profile"
        '
        'panel1
        '
        Me.panel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.panel1.BackColor = System.Drawing.Color.Transparent
        Me.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panel1.Controls.Add(Me.btnUpdate_record)
        Me.panel1.Controls.Add(Me.btnDisable)
        Me.panel1.Controls.Add(Me.btnSave)
        Me.panel1.Controls.Add(Me.btnNewRecord)
        Me.panel1.Location = New System.Drawing.Point(478, 35)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(129, 175)
        Me.panel1.TabIndex = 19
        '
        'txtContactNo
        '
        Me.txtContactNo.BackColor = System.Drawing.Color.Transparent
        Me.txtContactNo.Controls.Add(Me.txtBorrowerID)
        Me.txtContactNo.Controls.Add(Me.Label8)
        Me.txtContactNo.Controls.Add(Me.panel1)
        Me.txtContactNo.Controls.Add(Me.Label14)
        Me.txtContactNo.Controls.Add(Me.Label13)
        Me.txtContactNo.Controls.Add(Me.txtStudentID)
        Me.txtContactNo.Controls.Add(Me.Label5)
        Me.txtContactNo.Controls.Add(Me.txtMobileNo)
        Me.txtContactNo.Controls.Add(Me.Label4)
        Me.txtContactNo.Controls.Add(Me.Button1)
        Me.txtContactNo.Controls.Add(Me.txtStudentName)
        Me.txtContactNo.Controls.Add(Me.Label7)
        Me.txtContactNo.Controls.Add(Me.txtPhoneNo)
        Me.txtContactNo.Controls.Add(Me.txtAddress)
        Me.txtContactNo.Controls.Add(Me.Label3)
        Me.txtContactNo.Controls.Add(Me.dtpDOB)
        Me.txtContactNo.Controls.Add(Me.txtAcademicYear)
        Me.txtContactNo.Controls.Add(Me.txtEmail)
        Me.txtContactNo.Controls.Add(Me.cmbGradeLevel)
        Me.txtContactNo.Controls.Add(Me.cmbGender)
        Me.txtContactNo.Controls.Add(Me.cmbSectionStrand)
        Me.txtContactNo.Controls.Add(Me.label29)
        Me.txtContactNo.Controls.Add(Me.Label11)
        Me.txtContactNo.Controls.Add(Me.label28)
        Me.txtContactNo.Controls.Add(Me.label6)
        Me.txtContactNo.Controls.Add(Me.label2)
        Me.txtContactNo.Controls.Add(Me.label1)
        Me.txtContactNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContactNo.ForeColor = System.Drawing.Color.Black
        Me.txtContactNo.Location = New System.Drawing.Point(16, 52)
        Me.txtContactNo.Name = "txtContactNo"
        Me.txtContactNo.Size = New System.Drawing.Size(629, 496)
        Me.txtContactNo.TabIndex = 18
        Me.txtContactNo.TabStop = False
        Me.txtContactNo.Text = "Student Profile"
        '
        'txtBorrowerID
        '
        Me.txtBorrowerID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtBorrowerID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBorrowerID.Location = New System.Drawing.Point(174, 137)
        Me.txtBorrowerID.Name = "txtBorrowerID"
        Me.txtBorrowerID.Size = New System.Drawing.Size(143, 22)
        Me.txtBorrowerID.TabIndex = 4
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(37, 140)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(83, 16)
        Me.Label8.TabIndex = 108
        Me.Label8.Text = "*Borrower ID"
        '
        'Label3
        '
        Me.Label3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(37, 298)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 16)
        Me.Label3.TabIndex = 46
        Me.Label3.Text = "*Address"
        '
        'dtpDOB
        '
        Me.dtpDOB.CustomFormat = "dd/MMM/yyyy"
        Me.dtpDOB.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDOB.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDOB.Location = New System.Drawing.Point(174, 376)
        Me.dtpDOB.Name = "dtpDOB"
        Me.dtpDOB.Size = New System.Drawing.Size(122, 22)
        Me.dtpDOB.TabIndex = 9
        '
        'txtAcademicYear
        '
        Me.txtAcademicYear.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAcademicYear.Location = New System.Drawing.Point(174, 247)
        Me.txtAcademicYear.Mask = "0000-0000"
        Me.txtAcademicYear.Name = "txtAcademicYear"
        Me.txtAcademicYear.Size = New System.Drawing.Size(88, 22)
        Me.txtAcademicYear.TabIndex = 7
        '
        'txtEmail
        '
        Me.txtEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.Location = New System.Drawing.Point(174, 456)
        Me.txtEmail.Multiline = True
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(307, 22)
        Me.txtEmail.TabIndex = 12
        '
        'cmbGradeLevel
        '
        Me.cmbGradeLevel.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbGradeLevel.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbGradeLevel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbGradeLevel.FormattingEnabled = True
        Me.cmbGradeLevel.Location = New System.Drawing.Point(174, 207)
        Me.cmbGradeLevel.Name = "cmbGradeLevel"
        Me.cmbGradeLevel.Size = New System.Drawing.Size(143, 23)
        Me.cmbGradeLevel.TabIndex = 6
        '
        'cmbGender
        '
        Me.cmbGender.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbGender.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbGender.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbGender.FormattingEnabled = True
        Me.cmbGender.ItemHeight = 15
        Me.cmbGender.Items.AddRange(New Object() {"Male", "Female"})
        Me.cmbGender.Location = New System.Drawing.Point(174, 103)
        Me.cmbGender.Name = "cmbGender"
        Me.cmbGender.Size = New System.Drawing.Size(143, 23)
        Me.cmbGender.TabIndex = 3
        '
        'cmbSectionStrand
        '
        Me.cmbSectionStrand.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbSectionStrand.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbSectionStrand.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSectionStrand.FormattingEnabled = True
        Me.cmbSectionStrand.Location = New System.Drawing.Point(174, 173)
        Me.cmbSectionStrand.Name = "cmbSectionStrand"
        Me.cmbSectionStrand.Size = New System.Drawing.Size(143, 23)
        Me.cmbSectionStrand.TabIndex = 5
        '
        'label29
        '
        Me.label29.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.label29.AutoSize = True
        Me.label29.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label29.ForeColor = System.Drawing.Color.Black
        Me.label29.Location = New System.Drawing.Point(37, 419)
        Me.label29.Name = "label29"
        Me.label29.Size = New System.Drawing.Size(71, 16)
        Me.label29.TabIndex = 25
        Me.label29.Text = "Phone No."
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(37, 176)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(58, 16)
        Me.Label11.TabIndex = 22
        Me.Label11.Text = "*Section"
        '
        'label28
        '
        Me.label28.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.label28.AutoSize = True
        Me.label28.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label28.Location = New System.Drawing.Point(-479, 510)
        Me.label28.Name = "label28"
        Me.label28.Size = New System.Drawing.Size(43, 18)
        Me.label28.TabIndex = 24
        Me.label28.Text = "Email"
        '
        'label6
        '
        Me.label6.AutoSize = True
        Me.label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label6.Location = New System.Drawing.Point(37, 381)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(42, 16)
        Me.label6.TabIndex = 7
        Me.label6.Text = "*DOB"
        '
        'label2
        '
        Me.label2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.label2.AutoSize = True
        Me.label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label2.ForeColor = System.Drawing.Color.Black
        Me.label2.Location = New System.Drawing.Point(37, 250)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(106, 16)
        Me.label2.TabIndex = 4
        Me.label2.Text = "*Academic Year"
        '
        'label1
        '
        Me.label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.ForeColor = System.Drawing.Color.Black
        Me.label1.Location = New System.Drawing.Point(37, 74)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(98, 16)
        Me.label1.TabIndex = 2
        Me.label1.Text = "*Student Name"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'frmBorrower
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(667, 570)
        Me.Controls.Add(Me.lblStaffProfile)
        Me.Controls.Add(Me.txtContactNo)
        Me.Controls.Add(Me.PictureBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmBorrower"
        Me.Text = "Borrowers"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel1.ResumeLayout(False)
        Me.txtContactNo.ResumeLayout(False)
        Me.txtContactNo.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Private WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Public WithEvents txtStudentID As TextBox
    Private WithEvents Label5 As Label
    Public WithEvents txtMobileNo As TextBox
    Private WithEvents Label4 As Label
    Friend WithEvents Button1 As Button
    Public WithEvents txtStudentName As TextBox
    Private WithEvents Label7 As Label
    Public WithEvents txtPhoneNo As TextBox
    Public WithEvents btnUpdate_record As Button
    Public WithEvents btnDisable As Button
    Public WithEvents btnSave As Button
    Private WithEvents btnNewRecord As Button
    Public WithEvents txtAddress As TextBox
    Friend WithEvents lblStaffProfile As Label
    Private WithEvents panel1 As Panel
    Private WithEvents txtContactNo As GroupBox
    Private WithEvents Label3 As Label
    Friend WithEvents dtpDOB As DateTimePicker
    Public WithEvents txtAcademicYear As MaskedTextBox
    Public WithEvents txtEmail As TextBox
    Public WithEvents cmbSectionStrand As ComboBox
    Private WithEvents label29 As Label
    Private WithEvents Label11 As Label
    Private WithEvents label28 As Label
    Private WithEvents label6 As Label
    Private WithEvents label2 As Label
    Private WithEvents label1 As Label
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Private WithEvents Label8 As Label
    Public WithEvents txtBorrowerID As TextBox
    Public WithEvents cmbGradeLevel As ComboBox
    Public WithEvents cmbGender As ComboBox
End Class
