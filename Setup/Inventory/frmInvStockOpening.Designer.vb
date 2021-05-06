<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmInvStockOpening
    Inherits WinBaseForms.GUIBaseFormEntry

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

    'Required by the Windows Form DesignerfrmCAOGroup
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.rdbtnAll = New System.Windows.Forms.RadioButton()
        Me.rdbtnNotPosted = New System.Windows.Forms.RadioButton()
        Me.rdbtnPosted = New System.Windows.Forms.RadioButton()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblInformation = New System.Windows.Forms.Label()
        Me.grdRecord = New System.Windows.Forms.DataGridView()
        Me.VID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductDesc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Qty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VRate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CompanyID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FinancialYearID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Amount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GBHeading.SuspendLayout()
        Me.GBFooter.SuspendLayout()
        Me.GBBody.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.grdRecord, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdSave
        '
        Me.cmdSave.Location = New System.Drawing.Point(323, 8)
        '
        'cmdEdit
        '
        Me.cmdEdit.Enabled = False
        Me.cmdEdit.Location = New System.Drawing.Point(469, 8)
        Me.cmdEdit.TabIndex = 3
        Me.cmdEdit.Visible = False
        '
        'cmdDelete
        '
        Me.cmdDelete.Enabled = False
        Me.cmdDelete.Location = New System.Drawing.Point(535, 8)
        Me.cmdDelete.TabIndex = 4
        Me.cmdDelete.Visible = False
        '
        'cmdCancel
        '
        Me.cmdCancel.Location = New System.Drawing.Point(389, 8)
        Me.cmdCancel.TabIndex = 2
        '
        'cmdSearch
        '
        Me.cmdSearch.Location = New System.Drawing.Point(257, 8)
        Me.cmdSearch.TabIndex = 0
        '
        'cmdNew
        '
        Me.cmdNew.Enabled = False
        Me.cmdNew.Location = New System.Drawing.Point(601, 8)
        Me.cmdNew.TabIndex = 5
        Me.cmdNew.Visible = False
        '
        'GBHeading
        '
        Me.GBHeading.Margin = New System.Windows.Forms.Padding(5)
        Me.GBHeading.Size = New System.Drawing.Size(967, 42)
        '
        'GBFooter
        '
        Me.GBFooter.Location = New System.Drawing.Point(0, 447)
        Me.GBFooter.Margin = New System.Windows.Forms.Padding(5)
        Me.GBFooter.Size = New System.Drawing.Size(967, 76)
        Me.GBFooter.TabIndex = 0
        '
        'GBBody
        '
        Me.GBBody.Controls.Add(Me.GroupBox1)
        Me.GBBody.Margin = New System.Windows.Forms.Padding(5)
        Me.GBBody.Size = New System.Drawing.Size(967, 405)
        '
        'lblHeading
        '
        Me.lblHeading.Size = New System.Drawing.Size(967, 42)
        Me.lblHeading.TabIndex = 0
        Me.lblHeading.Text = "Stock Opening"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.SplitContainer1)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(967, 405)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer1.Location = New System.Drawing.Point(3, 16)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.rdbtnAll)
        Me.SplitContainer1.Panel1.Controls.Add(Me.rdbtnNotPosted)
        Me.SplitContainer1.Panel1.Controls.Add(Me.rdbtnPosted)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtSearch)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label6)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblInformation)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.grdRecord)
        Me.SplitContainer1.Size = New System.Drawing.Size(961, 386)
        Me.SplitContainer1.SplitterDistance = 72
        Me.SplitContainer1.TabIndex = 0
        '
        'rdbtnAll
        '
        Me.rdbtnAll.AutoSize = True
        Me.rdbtnAll.Checked = True
        Me.rdbtnAll.Location = New System.Drawing.Point(385, 41)
        Me.rdbtnAll.Name = "rdbtnAll"
        Me.rdbtnAll.Size = New System.Drawing.Size(36, 17)
        Me.rdbtnAll.TabIndex = 3
        Me.rdbtnAll.TabStop = True
        Me.rdbtnAll.Text = "All"
        Me.rdbtnAll.UseVisualStyleBackColor = True
        '
        'rdbtnNotPosted
        '
        Me.rdbtnNotPosted.AutoSize = True
        Me.rdbtnNotPosted.Location = New System.Drawing.Point(287, 41)
        Me.rdbtnNotPosted.Name = "rdbtnNotPosted"
        Me.rdbtnNotPosted.Size = New System.Drawing.Size(78, 17)
        Me.rdbtnNotPosted.TabIndex = 2
        Me.rdbtnNotPosted.Text = "Not Posted"
        Me.rdbtnNotPosted.UseVisualStyleBackColor = True
        '
        'rdbtnPosted
        '
        Me.rdbtnPosted.AutoSize = True
        Me.rdbtnPosted.Location = New System.Drawing.Point(205, 41)
        Me.rdbtnPosted.Name = "rdbtnPosted"
        Me.rdbtnPosted.Size = New System.Drawing.Size(58, 17)
        Me.rdbtnPosted.TabIndex = 1
        Me.rdbtnPosted.Text = "Posted"
        Me.rdbtnPosted.UseVisualStyleBackColor = True
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(205, 14)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(428, 20)
        Me.txtSearch.TabIndex = 0
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(136, 14)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 13)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Search"
        '
        'lblInformation
        '
        Me.lblInformation.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInformation.ForeColor = System.Drawing.Color.Green
        Me.lblInformation.Location = New System.Drawing.Point(82, 96)
        Me.lblInformation.Name = "lblInformation"
        Me.lblInformation.Size = New System.Drawing.Size(859, 20)
        Me.lblInformation.TabIndex = 17
        Me.lblInformation.Text = "."
        '
        'grdRecord
        '
        Me.grdRecord.AllowUserToAddRows = False
        Me.grdRecord.AllowUserToDeleteRows = False
        Me.grdRecord.AllowUserToOrderColumns = True
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.grdRecord.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.grdRecord.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdRecord.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.VID, Me.ProductID, Me.ProductDesc, Me.Qty, Me.VRate, Me.CompanyID, Me.FinancialYearID, Me.Amount})
        Me.grdRecord.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdRecord.Location = New System.Drawing.Point(0, 0)
        Me.grdRecord.Name = "grdRecord"
        Me.grdRecord.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.grdRecord.Size = New System.Drawing.Size(961, 310)
        Me.grdRecord.TabIndex = 0
        '
        'VID
        '
        Me.VID.DataPropertyName = "VID"
        Me.VID.HeaderText = "VID"
        Me.VID.Name = "VID"
        '
        'ProductID
        '
        Me.ProductID.DataPropertyName = "ProductVID"
        Me.ProductID.HeaderText = "Product ID"
        Me.ProductID.Name = "ProductID"
        Me.ProductID.ReadOnly = True
        '
        'ProductDesc
        '
        Me.ProductDesc.DataPropertyName = "ProductDesc"
        Me.ProductDesc.HeaderText = "Description"
        Me.ProductDesc.Name = "ProductDesc"
        Me.ProductDesc.ReadOnly = True
        Me.ProductDesc.Width = 400
        '
        'Qty
        '
        Me.Qty.DataPropertyName = "Qty"
        DataGridViewCellStyle2.Format = "N2"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.Qty.DefaultCellStyle = DataGridViewCellStyle2
        Me.Qty.HeaderText = "Quantity"
        Me.Qty.Name = "Qty"
        '
        'VRate
        '
        Me.VRate.DataPropertyName = "VRate"
        Me.VRate.HeaderText = "Rate"
        Me.VRate.Name = "VRate"
        '
        'CompanyID
        '
        Me.CompanyID.DataPropertyName = "CompanyID"
        Me.CompanyID.HeaderText = "Company ID"
        Me.CompanyID.Name = "CompanyID"
        Me.CompanyID.Visible = False
        '
        'FinancialYearID
        '
        Me.FinancialYearID.DataPropertyName = "FinancialYearID"
        Me.FinancialYearID.HeaderText = "Financial Year ID"
        Me.FinancialYearID.Name = "FinancialYearID"
        Me.FinancialYearID.Visible = False
        '
        'Amount
        '
        Me.Amount.DataPropertyName = "VValue"
        Me.Amount.HeaderText = "Amount"
        Me.Amount.Name = "Amount"
        Me.Amount.ReadOnly = True
        '
        'frmInvStockOpening
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(967, 523)
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "frmInvStockOpening"
        Me.Text = "Stock Opening"
        Me.GBHeading.ResumeLayout(False)
        Me.GBFooter.ResumeLayout(False)
        Me.GBBody.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.grdRecord, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents grdRecord As System.Windows.Forms.DataGridView
    Friend WithEvents lblInformation As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents rdbtnAll As RadioButton
    Friend WithEvents rdbtnNotPosted As RadioButton
   Friend WithEvents rdbtnPosted As RadioButton
   Friend WithEvents VID As System.Windows.Forms.DataGridViewTextBoxColumn
   Friend WithEvents ProductID As System.Windows.Forms.DataGridViewTextBoxColumn
   Friend WithEvents ProductDesc As System.Windows.Forms.DataGridViewTextBoxColumn
   Friend WithEvents Qty As System.Windows.Forms.DataGridViewTextBoxColumn
   Friend WithEvents VRate As System.Windows.Forms.DataGridViewTextBoxColumn
   Friend WithEvents CompanyID As System.Windows.Forms.DataGridViewTextBoxColumn
   Friend WithEvents FinancialYearID As System.Windows.Forms.DataGridViewTextBoxColumn
   Friend WithEvents Amount As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
