<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmBookListRecord
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBookListRecord))
        Me.BooktblBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Test3DataSet = New LibraryMS.test3DataSet()
        Me.Booktbl1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.btnClose = New System.Windows.Forms.Button()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.BooktblTableAdapter = New LibraryMS.test3DataSetTableAdapters.booktblTableAdapter()
        Me.Booktbl1TableAdapter = New LibraryMS.test3DataSetTableAdapters.booktbl1TableAdapter()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.lblHelp = New System.Windows.Forms.Label()
        CType(Me.BooktblBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Test3DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Booktbl1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        'Booktbl1BindingSource
        '
        Me.Booktbl1BindingSource.DataMember = "booktbl1"
        Me.Booktbl1BindingSource.DataSource = Me.Test3DataSet
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(12, 67)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(152, 23)
        Me.btnClose.TabIndex = 7
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.BooktblBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "LibraryMS.Report1.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(171, 67)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(628, 393)
        Me.ReportViewer1.TabIndex = 8
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(13, 96)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(152, 23)
        Me.btnReset.TabIndex = 7
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'BooktblTableAdapter
        '
        Me.BooktblTableAdapter.ClearBeforeFill = True
        '
        'Booktbl1TableAdapter
        '
        Me.Booktbl1TableAdapter.ClearBeforeFill = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PictureBox1.Location = New System.Drawing.Point(-153, -1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1064, 39)
        Me.PictureBox1.TabIndex = 16
        Me.PictureBox1.TabStop = False
        '
        'lblHelp
        '
        Me.lblHelp.AutoSize = True
        Me.lblHelp.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHelp.ForeColor = System.Drawing.Color.Blue
        Me.lblHelp.Location = New System.Drawing.Point(49, 419)
        Me.lblHelp.Name = "lblHelp"
        Me.lblHelp.Size = New System.Drawing.Size(71, 13)
        Me.lblHelp.TabIndex = 17
        Me.lblHelp.Text = "Hover on me!"
        Me.ToolTip1.SetToolTip(Me.lblHelp, "On the report viewer, you can sort the entries either by ISBN, Title, Author, ")
        '
        'frmBookListRecord
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 467)
        Me.Controls.Add(Me.lblHelp)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnClose)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmBookListRecord"
        Me.Text = "Book List Record"
        CType(Me.BooktblBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Test3DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Booktbl1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnClose As Button
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents btnReset As Button
    Friend WithEvents Test3DataSet As test3DataSet
    Friend WithEvents BooktblBindingSource As BindingSource
    Friend WithEvents BooktblTableAdapter As test3DataSetTableAdapters.booktblTableAdapter
    Friend WithEvents Booktbl1BindingSource As BindingSource
    Friend WithEvents Booktbl1TableAdapter As test3DataSetTableAdapters.booktbl1TableAdapter
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents lblHelp As Label
End Class
