<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmBorrowedBooks
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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBorrowedBooks))
        Me.borrowtblBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Borrow = New LibraryMS.Borrow()
        Me.lblHelp = New System.Windows.Forms.Label()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.borrowtblTableAdapter = New LibraryMS.BorrowTableAdapters.borrowtblTableAdapter()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.borrowtblBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Borrow, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'borrowtblBindingSource
        '
        Me.borrowtblBindingSource.DataMember = "borrowtbl"
        Me.borrowtblBindingSource.DataSource = Me.Borrow
        '
        'Borrow
        '
        Me.Borrow.DataSetName = "Borrow"
        Me.Borrow.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'lblHelp
        '
        Me.lblHelp.AutoSize = True
        Me.lblHelp.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHelp.ForeColor = System.Drawing.Color.Blue
        Me.lblHelp.Location = New System.Drawing.Point(41, 420)
        Me.lblHelp.Name = "lblHelp"
        Me.lblHelp.Size = New System.Drawing.Size(71, 13)
        Me.lblHelp.TabIndex = 21
        Me.lblHelp.Text = "Hover on me!"
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.borrowtblBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "LibraryMS.BorrowedBooks.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(167, 68)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(628, 393)
        Me.ReportViewer1.TabIndex = 19
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(8, 68)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(152, 23)
        Me.btnClose.TabIndex = 18
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PictureBox1.Location = New System.Drawing.Point(-161, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1064, 39)
        Me.PictureBox1.TabIndex = 20
        Me.PictureBox1.TabStop = False
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(9, 97)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(152, 23)
        Me.btnReset.TabIndex = 22
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'borrowtblTableAdapter
        '
        Me.borrowtblTableAdapter.ClearBeforeFill = True
        '
        'frmBorrowedBooks
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 467)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.lblHelp)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(Me.btnClose)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmBorrowedBooks"
        Me.Text = "Borrowed Books"
        CType(Me.borrowtblBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Borrow, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblHelp As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents btnClose As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents borrowtblBindingSource As BindingSource
    Friend WithEvents Borrow As Borrow
    Friend WithEvents borrowtblTableAdapter As BorrowTableAdapters.borrowtblTableAdapter
    Friend WithEvents ToolTip1 As ToolTip
End Class
