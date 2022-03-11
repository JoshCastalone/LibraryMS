<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSysInfo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSysInfo))
        Me.tbpGPU = New System.Windows.Forms.TabPage()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtDriverVer = New System.Windows.Forms.TextBox()
        Me.txtDeviceID = New System.Windows.Forms.TextBox()
        Me.txtDescription = New System.Windows.Forms.TextBox()
        Me.txtRAMGB = New System.Windows.Forms.TextBox()
        Me.txtRefreshRate = New System.Windows.Forms.TextBox()
        Me.txtProcessorName = New System.Windows.Forms.TextBox()
        Me.txtFullName = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.tbpCPU = New System.Windows.Forms.TabPage()
        Me.txtCPU = New System.Windows.Forms.TextBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.tbcSysInfo = New System.Windows.Forms.TabControl()
        Me.tbpRAM = New System.Windows.Forms.TabPage()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtAvailableRAM = New System.Windows.Forms.TextBox()
        Me.txtTotalRAM = New System.Windows.Forms.TextBox()
        Me.tbpStorage = New System.Windows.Forms.TabPage()
        Me.btnShowStorage = New System.Windows.Forms.Button()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtFSpace = New System.Windows.Forms.TextBox()
        Me.txtDTSize = New System.Windows.Forms.TextBox()
        Me.txtDType = New System.Windows.Forms.TextBox()
        Me.txtFileSys = New System.Windows.Forms.TextBox()
        Me.txtStorageName = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lstStorage = New System.Windows.Forms.ListBox()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.SaveToFileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.tbpGPU.SuspendLayout()
        Me.tbpCPU.SuspendLayout()
        Me.tbcSysInfo.SuspendLayout()
        Me.tbpRAM.SuspendLayout()
        Me.tbpStorage.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tbpGPU
        '
        Me.tbpGPU.Controls.Add(Me.Label24)
        Me.tbpGPU.Controls.Add(Me.Label7)
        Me.tbpGPU.Controls.Add(Me.Label6)
        Me.tbpGPU.Controls.Add(Me.Label5)
        Me.tbpGPU.Controls.Add(Me.Label4)
        Me.tbpGPU.Controls.Add(Me.Label3)
        Me.tbpGPU.Controls.Add(Me.Label2)
        Me.tbpGPU.Controls.Add(Me.Label1)
        Me.tbpGPU.Controls.Add(Me.txtDriverVer)
        Me.tbpGPU.Controls.Add(Me.txtDeviceID)
        Me.tbpGPU.Controls.Add(Me.txtDescription)
        Me.tbpGPU.Controls.Add(Me.txtRAMGB)
        Me.tbpGPU.Controls.Add(Me.txtRefreshRate)
        Me.tbpGPU.Controls.Add(Me.txtProcessorName)
        Me.tbpGPU.Controls.Add(Me.txtFullName)
        Me.tbpGPU.Location = New System.Drawing.Point(4, 22)
        Me.tbpGPU.Name = "tbpGPU"
        Me.tbpGPU.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpGPU.Size = New System.Drawing.Size(362, 307)
        Me.tbpGPU.TabIndex = 1
        Me.tbpGPU.Text = "GPU"
        Me.tbpGPU.UseVisualStyleBackColor = True
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(142, 18)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(76, 20)
        Me.Label24.TabIndex = 4
        Me.Label24.Text = "GPU Info"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(11, 227)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(73, 13)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Driver Version"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(11, 199)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(55, 13)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Device ID"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(11, 171)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 13)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Description"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(11, 143)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(111, 13)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Amount of RAM in GB"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(11, 113)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Refresh Rate"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(11, 84)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Processor Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Full Name"
        '
        'txtDriverVer
        '
        Me.txtDriverVer.Location = New System.Drawing.Point(131, 227)
        Me.txtDriverVer.Name = "txtDriverVer"
        Me.txtDriverVer.ReadOnly = True
        Me.txtDriverVer.Size = New System.Drawing.Size(223, 20)
        Me.txtDriverVer.TabIndex = 0
        '
        'txtDeviceID
        '
        Me.txtDeviceID.Location = New System.Drawing.Point(131, 199)
        Me.txtDeviceID.Name = "txtDeviceID"
        Me.txtDeviceID.ReadOnly = True
        Me.txtDeviceID.Size = New System.Drawing.Size(223, 20)
        Me.txtDeviceID.TabIndex = 0
        '
        'txtDescription
        '
        Me.txtDescription.Location = New System.Drawing.Point(131, 171)
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.ReadOnly = True
        Me.txtDescription.Size = New System.Drawing.Size(223, 20)
        Me.txtDescription.TabIndex = 0
        '
        'txtRAMGB
        '
        Me.txtRAMGB.Location = New System.Drawing.Point(131, 143)
        Me.txtRAMGB.Name = "txtRAMGB"
        Me.txtRAMGB.ReadOnly = True
        Me.txtRAMGB.Size = New System.Drawing.Size(223, 20)
        Me.txtRAMGB.TabIndex = 0
        '
        'txtRefreshRate
        '
        Me.txtRefreshRate.Location = New System.Drawing.Point(131, 113)
        Me.txtRefreshRate.Name = "txtRefreshRate"
        Me.txtRefreshRate.ReadOnly = True
        Me.txtRefreshRate.Size = New System.Drawing.Size(223, 20)
        Me.txtRefreshRate.TabIndex = 0
        '
        'txtProcessorName
        '
        Me.txtProcessorName.Location = New System.Drawing.Point(131, 84)
        Me.txtProcessorName.Name = "txtProcessorName"
        Me.txtProcessorName.ReadOnly = True
        Me.txtProcessorName.Size = New System.Drawing.Size(223, 20)
        Me.txtProcessorName.TabIndex = 0
        '
        'txtFullName
        '
        Me.txtFullName.Location = New System.Drawing.Point(131, 54)
        Me.txtFullName.Name = "txtFullName"
        Me.txtFullName.ReadOnly = True
        Me.txtFullName.Size = New System.Drawing.Size(223, 20)
        Me.txtFullName.TabIndex = 0
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(116, 24)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(168, 24)
        Me.Label14.TabIndex = 7
        Me.Label14.Text = "System Information"
        '
        'tbpCPU
        '
        Me.tbpCPU.Controls.Add(Me.txtCPU)
        Me.tbpCPU.Controls.Add(Me.Label25)
        Me.tbpCPU.Controls.Add(Me.TextBox7)
        Me.tbpCPU.Location = New System.Drawing.Point(4, 22)
        Me.tbpCPU.Name = "tbpCPU"
        Me.tbpCPU.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpCPU.Size = New System.Drawing.Size(362, 307)
        Me.tbpCPU.TabIndex = 0
        Me.tbpCPU.Text = "CPU"
        Me.tbpCPU.UseVisualStyleBackColor = True
        '
        'txtCPU
        '
        Me.txtCPU.BackColor = System.Drawing.Color.White
        Me.txtCPU.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCPU.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCPU.Location = New System.Drawing.Point(30, 51)
        Me.txtCPU.Multiline = True
        Me.txtCPU.Name = "txtCPU"
        Me.txtCPU.ReadOnly = True
        Me.txtCPU.Size = New System.Drawing.Size(297, 129)
        Me.txtCPU.TabIndex = 6
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(141, 22)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(74, 20)
        Me.Label25.TabIndex = 5
        Me.Label25.Text = "CPU Info"
        '
        'TextBox7
        '
        Me.TextBox7.Enabled = False
        Me.TextBox7.Location = New System.Drawing.Point(30, 261)
        Me.TextBox7.Multiline = True
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(100, 20)
        Me.TextBox7.TabIndex = 0
        Me.TextBox7.Visible = False
        '
        'tbcSysInfo
        '
        Me.tbcSysInfo.Controls.Add(Me.tbpCPU)
        Me.tbcSysInfo.Controls.Add(Me.tbpGPU)
        Me.tbcSysInfo.Controls.Add(Me.tbpRAM)
        Me.tbcSysInfo.Controls.Add(Me.tbpStorage)
        Me.tbcSysInfo.Controls.Add(Me.TabPage3)
        Me.tbcSysInfo.Location = New System.Drawing.Point(9, 51)
        Me.tbcSysInfo.Name = "tbcSysInfo"
        Me.tbcSysInfo.SelectedIndex = 0
        Me.tbcSysInfo.Size = New System.Drawing.Size(370, 333)
        Me.tbcSysInfo.TabIndex = 5
        '
        'tbpRAM
        '
        Me.tbpRAM.Controls.Add(Me.Label13)
        Me.tbpRAM.Controls.Add(Me.Label15)
        Me.tbpRAM.Controls.Add(Me.txtAvailableRAM)
        Me.tbpRAM.Controls.Add(Me.txtTotalRAM)
        Me.tbpRAM.Location = New System.Drawing.Point(4, 22)
        Me.tbpRAM.Name = "tbpRAM"
        Me.tbpRAM.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpRAM.Size = New System.Drawing.Size(362, 307)
        Me.tbpRAM.TabIndex = 2
        Me.tbpRAM.Text = "RAM"
        Me.tbpRAM.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(142, 149)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(77, 13)
        Me.Label13.TabIndex = 14
        Me.Label13.Text = "Available RAM"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(152, 48)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(58, 13)
        Me.Label15.TabIndex = 15
        Me.Label15.Text = "Total RAM"
        '
        'txtAvailableRAM
        '
        Me.txtAvailableRAM.Location = New System.Drawing.Point(72, 165)
        Me.txtAvailableRAM.Name = "txtAvailableRAM"
        Me.txtAvailableRAM.ReadOnly = True
        Me.txtAvailableRAM.Size = New System.Drawing.Size(223, 20)
        Me.txtAvailableRAM.TabIndex = 6
        '
        'txtTotalRAM
        '
        Me.txtTotalRAM.Location = New System.Drawing.Point(72, 64)
        Me.txtTotalRAM.Name = "txtTotalRAM"
        Me.txtTotalRAM.ReadOnly = True
        Me.txtTotalRAM.Size = New System.Drawing.Size(223, 20)
        Me.txtTotalRAM.TabIndex = 8
        '
        'tbpStorage
        '
        Me.tbpStorage.Controls.Add(Me.btnShowStorage)
        Me.tbpStorage.Controls.Add(Me.Label17)
        Me.tbpStorage.Controls.Add(Me.txtFSpace)
        Me.tbpStorage.Controls.Add(Me.txtDTSize)
        Me.tbpStorage.Controls.Add(Me.txtDType)
        Me.tbpStorage.Controls.Add(Me.txtFileSys)
        Me.tbpStorage.Controls.Add(Me.txtStorageName)
        Me.tbpStorage.Controls.Add(Me.Label12)
        Me.tbpStorage.Controls.Add(Me.Label11)
        Me.tbpStorage.Controls.Add(Me.Label10)
        Me.tbpStorage.Controls.Add(Me.Label9)
        Me.tbpStorage.Controls.Add(Me.Label8)
        Me.tbpStorage.Controls.Add(Me.lstStorage)
        Me.tbpStorage.Location = New System.Drawing.Point(4, 22)
        Me.tbpStorage.Name = "tbpStorage"
        Me.tbpStorage.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpStorage.Size = New System.Drawing.Size(362, 307)
        Me.tbpStorage.TabIndex = 3
        Me.tbpStorage.Text = "Storage"
        Me.tbpStorage.UseVisualStyleBackColor = True
        '
        'btnShowStorage
        '
        Me.btnShowStorage.Location = New System.Drawing.Point(130, 259)
        Me.btnShowStorage.Name = "btnShowStorage"
        Me.btnShowStorage.Size = New System.Drawing.Size(110, 23)
        Me.btnShowStorage.TabIndex = 4
        Me.btnShowStorage.Text = "Show Storage"
        Me.btnShowStorage.UseVisualStyleBackColor = True
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(134, 12)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(98, 20)
        Me.Label17.TabIndex = 3
        Me.Label17.Text = "Storage Info"
        '
        'txtFSpace
        '
        Me.txtFSpace.Location = New System.Drawing.Point(203, 184)
        Me.txtFSpace.Name = "txtFSpace"
        Me.txtFSpace.ReadOnly = True
        Me.txtFSpace.Size = New System.Drawing.Size(142, 20)
        Me.txtFSpace.TabIndex = 2
        '
        'txtDTSize
        '
        Me.txtDTSize.Location = New System.Drawing.Point(203, 152)
        Me.txtDTSize.Name = "txtDTSize"
        Me.txtDTSize.ReadOnly = True
        Me.txtDTSize.Size = New System.Drawing.Size(142, 20)
        Me.txtDTSize.TabIndex = 2
        '
        'txtDType
        '
        Me.txtDType.Location = New System.Drawing.Point(203, 122)
        Me.txtDType.Name = "txtDType"
        Me.txtDType.ReadOnly = True
        Me.txtDType.Size = New System.Drawing.Size(142, 20)
        Me.txtDType.TabIndex = 2
        '
        'txtFileSys
        '
        Me.txtFileSys.Location = New System.Drawing.Point(203, 89)
        Me.txtFileSys.Name = "txtFileSys"
        Me.txtFileSys.ReadOnly = True
        Me.txtFileSys.Size = New System.Drawing.Size(142, 20)
        Me.txtFileSys.TabIndex = 2
        '
        'txtStorageName
        '
        Me.txtStorageName.Location = New System.Drawing.Point(203, 59)
        Me.txtStorageName.Name = "txtStorageName"
        Me.txtStorageName.ReadOnly = True
        Me.txtStorageName.Size = New System.Drawing.Size(142, 20)
        Me.txtStorageName.TabIndex = 2
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(133, 184)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(62, 13)
        Me.Label12.TabIndex = 1
        Me.Label12.Text = "Free Space"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(133, 152)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(54, 13)
        Me.Label11.TabIndex = 1
        Me.Label11.Text = "Total Size"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(133, 122)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(59, 13)
        Me.Label10.TabIndex = 1
        Me.Label10.Text = "Drive Type"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(133, 89)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(60, 13)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "File System"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(133, 59)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(35, 13)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Name"
        '
        'lstStorage
        '
        Me.lstStorage.FormattingEnabled = True
        Me.lstStorage.Location = New System.Drawing.Point(21, 59)
        Me.lstStorage.Name = "lstStorage"
        Me.lstStorage.Size = New System.Drawing.Size(99, 186)
        Me.lstStorage.TabIndex = 0
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.TextBox6)
        Me.TabPage3.Controls.Add(Me.TextBox5)
        Me.TabPage3.Controls.Add(Me.TextBox4)
        Me.TabPage3.Controls.Add(Me.TextBox3)
        Me.TabPage3.Controls.Add(Me.TextBox2)
        Me.TabPage3.Controls.Add(Me.TextBox1)
        Me.TabPage3.Controls.Add(Me.Label23)
        Me.TabPage3.Controls.Add(Me.Label22)
        Me.TabPage3.Controls.Add(Me.Label21)
        Me.TabPage3.Controls.Add(Me.Label20)
        Me.TabPage3.Controls.Add(Me.Label19)
        Me.TabPage3.Controls.Add(Me.Label18)
        Me.TabPage3.Controls.Add(Me.Label16)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(362, 307)
        Me.TabPage3.TabIndex = 4
        Me.TabPage3.Text = "Operating System"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(137, 219)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.ReadOnly = True
        Me.TextBox6.Size = New System.Drawing.Size(192, 20)
        Me.TextBox6.TabIndex = 2
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(137, 191)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.ReadOnly = True
        Me.TextBox5.Size = New System.Drawing.Size(192, 20)
        Me.TextBox5.TabIndex = 2
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(137, 164)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.ReadOnly = True
        Me.TextBox4.Size = New System.Drawing.Size(192, 20)
        Me.TextBox4.TabIndex = 2
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(137, 104)
        Me.TextBox3.Multiline = True
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.ReadOnly = True
        Me.TextBox3.Size = New System.Drawing.Size(192, 54)
        Me.TextBox3.TabIndex = 2
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(137, 77)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(192, 20)
        Me.TextBox2.TabIndex = 2
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(137, 50)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(192, 20)
        Me.TextBox1.TabIndex = 2
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(18, 222)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(55, 13)
        Me.Label23.TabIndex = 1
        Me.Label23.Text = "Language"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(18, 194)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(42, 13)
        Me.Label22.TabIndex = 1
        Me.Label22.Text = "Version"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(18, 167)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(45, 13)
        Me.Label21.TabIndex = 1
        Me.Label21.Text = "Platform"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(18, 107)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(90, 13)
        Me.Label20.TabIndex = 1
        Me.Label20.Text = "Operating System"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(18, 80)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(66, 13)
        Me.Label19.TabIndex = 1
        Me.Label19.Text = "Current User"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(18, 53)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(83, 13)
        Me.Label18.TabIndex = 1
        Me.Label18.Text = "Computer Name"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(103, 17)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(168, 20)
        Me.Label16.TabIndex = 0
        Me.Label16.Text = "Operating System Info"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(131, 22)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(128, 6)
        '
        'SaveToFileToolStripMenuItem
        '
        Me.SaveToFileToolStripMenuItem.Name = "SaveToFileToolStripMenuItem"
        Me.SaveToFileToolStripMenuItem.Size = New System.Drawing.Size(131, 22)
        Me.SaveToFileToolStripMenuItem.Text = "&Save to file"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SaveToFileToolStripMenuItem, Me.ToolStripMenuItem1, Me.PrintToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'PrintToolStripMenuItem
        '
        Me.PrintToolStripMenuItem.Name = "PrintToolStripMenuItem"
        Me.PrintToolStripMenuItem.Size = New System.Drawing.Size(131, 22)
        Me.PrintToolStripMenuItem.Text = "Print"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(392, 24)
        Me.MenuStrip1.TabIndex = 4
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PictureBox1.Location = New System.Drawing.Point(0, 390)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(394, 20)
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'PrintDocument1
        '
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'frmSysInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(392, 410)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.tbcSysInfo)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(408, 449)
        Me.MinimizeBox = False
        Me.Name = "frmSysInfo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "System Info"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.tbpGPU.ResumeLayout(False)
        Me.tbpGPU.PerformLayout()
        Me.tbpCPU.ResumeLayout(False)
        Me.tbpCPU.PerformLayout()
        Me.tbcSysInfo.ResumeLayout(False)
        Me.tbpRAM.ResumeLayout(False)
        Me.tbpRAM.PerformLayout()
        Me.tbpStorage.ResumeLayout(False)
        Me.tbpStorage.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tbpGPU As TabPage
    Friend WithEvents Label14 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents tbpCPU As TabPage
    Friend WithEvents tbcSysInfo As TabControl
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripSeparator
    Friend WithEvents SaveToFileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents Label24 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtDriverVer As TextBox
    Friend WithEvents txtDeviceID As TextBox
    Friend WithEvents txtDescription As TextBox
    Friend WithEvents txtRAMGB As TextBox
    Friend WithEvents txtRefreshRate As TextBox
    Friend WithEvents txtProcessorName As TextBox
    Friend WithEvents txtFullName As TextBox
    Friend WithEvents Label25 As Label
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents tbpRAM As TabPage
    Friend WithEvents Label13 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents txtAvailableRAM As TextBox
    Friend WithEvents txtTotalRAM As TextBox
    Friend WithEvents tbpStorage As TabPage
    Friend WithEvents btnShowStorage As Button
    Friend WithEvents Label17 As Label
    Friend WithEvents txtFSpace As TextBox
    Friend WithEvents txtDTSize As TextBox
    Friend WithEvents txtDType As TextBox
    Friend WithEvents txtFileSys As TextBox
    Friend WithEvents txtStorageName As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents lstStorage As ListBox
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label23 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents txtCPU As TextBox
    Friend WithEvents PrintToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintDialog1 As PrintDialog
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
End Class
