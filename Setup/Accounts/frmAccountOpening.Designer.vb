<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmVoucherPosting
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.btnFill = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.rdbtnAccount = New System.Windows.Forms.RadioButton()
        Me.rdbtnCustomer = New System.Windows.Forms.RadioButton()
        Me.rdbtnSupplier = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.rdbtnAll = New System.Windows.Forms.RadioButton()
        Me.rdbtnNotPosted = New System.Windows.Forms.RadioButton()
        Me.rdbtnPosted = New System.Windows.Forms.RadioButton()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblInformation = New System.Windows.Forms.Label()
        Me.grdRecord = New System.Windows.Forms.DataGridView()
        Me.VID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AccountID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Dr = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cr = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CompanyID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FinancialYearID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GBHeading.SuspendLayout()
        Me.GBFooter.SuspendLayout()
        Me.GBBody.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.grdRecord, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdSave
        '
        Me.cmdSave.Location = New System.Drawing.Point(412, 6)
        '
        'cmdEdit
        '
        Me.cmdEdit.Enabled = False
        Me.cmdEdit.Location = New System.Drawing.Point(558, 6)
        Me.cmdEdit.TabIndex = 3
        Me.cmdEdit.Visible = False
        '
        'cmdDelete
        '
        Me.cmdDelete.Enabled = False
        Me.cmdDelete.Location = New System.Drawing.Point(624, 6)
        Me.cmdDelete.TabIndex = 4
        Me.cmdDelete.Visible = False
        '
        'cmdCancel
        '
        Me.cmdCancel.Location = New System.Drawing.Point(478, 6)
        Me.cmdCancel.TabIndex = 2
        '
        'cmdSearch
        '
        Me.cmdSearch.Location = New System.Drawing.Point(346, 6)
        Me.cmdSearch.TabIndex = 0
        Me.cmdSearch.Visible = False
        '
        'cmdNew
        '
        Me.cmdNew.Enabled = False
        Me.cmdNew.Location = New System.Drawing.Point(690, 6)
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
        Me.lblHeading.Text = "Opening"
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
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnFill)
        Me.SplitContainer1.Panel1.Controls.Add(Me.GroupBox3)
        Me.SplitContainer1.Panel1.Controls.Add(Me.GroupBox2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtSearch)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label6)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblInformation)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.grdRecord)
        Me.SplitContainer1.Size = New System.Drawing.Size(961, 386)
        Me.SplitContainer1.SplitterDistance = 93
        Me.SplitContainer1.TabIndex = 0
        '
        'btnFill
        '
        Me.btnFill.BackColor = System.Drawing.Color.Silver
        Me.btnFill.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFill.Location = New System.Drawing.Point(784, 51)
        Me.btnFill.Name = "btnFill"
        Me.btnFill.Size = New System.Drawing.Size(82, 28)
        Me.btnFill.TabIndex = 20
        Me.btnFill.Text = "Fill"
        Me.btnFill.UseVisualStyleBackColor = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.rdbtnAccount)
        Me.GroupBox3.Controls.Add(Me.rdbtnCustomer)
        Me.GroupBox3.Controls.Add(Me.rdbtnSupplier)
        Me.GroupBox3.Location = New System.Drawing.Point(136, 40)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(285, 44)
        Me.GroupBox3.TabIndex = 19
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Opening Type"
        '
        'rdbtnAccount
        '
        Me.rdbtnAccount.AutoSize = True
        Me.rdbtnAccount.Checked = True
        Me.rdbtnAccount.Location = New System.Drawing.Point(10, 19)
        Me.rdbtnAccount.Name = "rdbtnAccount"
        Me.rdbtnAccount.Size = New System.Drawing.Size(65, 17)
        Me.rdbtnAccount.TabIndex = 3
        Me.rdbtnAccount.TabStop = True
        Me.rdbtnAccount.Text = "Account"
        Me.rdbtnAccount.UseVisualStyleBackColor = True
        '
        'rdbtnCustomer
        '
        Me.rdbtnCustomer.AutoSize = True
        Me.rdbtnCustomer.Location = New System.Drawing.Point(206, 19)
        Me.rdbtnCustomer.Name = "rdbtnCustomer"
        Me.rdbtnCustomer.Size = New System.Drawing.Size(69, 17)
        Me.rdbtnCustomer.TabIndex = 2
        Me.rdbtnCustomer.Text = "Customer"
        Me.rdbtnCustomer.UseVisualStyleBackColor = True
        '
        'rdbtnSupplier
        '
        Me.rdbtnSupplier.AutoSize = True
        Me.rdbtnSupplier.Location = New System.Drawing.Point(110, 19)
        Me.rdbtnSupplier.Name = "rdbtnSupplier"
        Me.rdbtnSupplier.Size = New System.Drawing.Size(61, 17)
        Me.rdbtnSupplier.TabIndex = 1
        Me.rdbtnSupplier.Text = "Suppier"
        Me.rdbtnSupplier.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rdbtnAll)
        Me.GroupBox2.Controls.Add(Me.rdbtnNotPosted)
        Me.GroupBox2.Controls.Add(Me.rdbtnPosted)
        Me.GroupBox2.Location = New System.Drawing.Point(504, 39)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(249, 44)
        Me.GroupBox2.TabIndex = 18
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Product Type"
        '
        'rdbtnAll
        '
        Me.rdbtnAll.AutoSize = True
        Me.rdbtnAll.Checked = True
        Me.rdbtnAll.Location = New System.Drawing.Point(204, 19)
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
        Me.rdbtnNotPosted.Location = New System.Drawing.Point(106, 19)
        Me.rdbtnNotPosted.Name = "rdbtnNotPosted"
        Me.rdbtnNotPosted.Size = New System.Drawing.Size(78, 17)
        Me.rdbtnNotPosted.TabIndex = 2
        Me.rdbtnNotPosted.Text = "Not Posted"
        Me.rdbtnNotPosted.UseVisualStyleBackColor = True
        '
        'rdbtnPosted
        '
        Me.rdbtnPosted.AutoSize = True
        Me.rdbtnPosted.Location = New System.Drawing.Point(24, 19)
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
        Me.txtSearch.Size = New System.Drawing.Size(548, 20)
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
        Me.grdRecord.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.VID, Me.AccountID, Me.VName, Me.Dr, Me.Cr, Me.CompanyID, Me.FinancialYearID})
        Me.grdRecord.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdRecord.Location = New System.Drawing.Point(0, 0)
        Me.grdRecord.Name = "grdRecord"
        Me.grdRecord.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grdRecord.Size = New System.Drawing.Size(961, 289)
        Me.grdRecord.TabIndex = 0
        '
        'VID
        '
        Me.VID.DataPropertyName = "VID"
        Me.VID.HeaderText = "VID"
        Me.VID.Name = "VID"
        Me.VID.Visible = False
        '
        'AccountID
        '
        Me.AccountID.DataPropertyName = "AccountID"
        Me.AccountID.HeaderText = "AccountID"
        Me.AccountID.Name = "AccountID"
        Me.AccountID.ReadOnly = True
        '
        'VName
        '
        Me.VName.DataPropertyName = "VName"
        Me.VName.HeaderText = "Description"
        Me.VName.Name = "VName"
        Me.VName.ReadOnly = True
        Me.VName.Width = 368
        '
        'Dr
        '
        Me.Dr.DataPropertyName = "Dr"
        Me.Dr.HeaderText = "Dr"
        Me.Dr.Name = "Dr"
        '
        'Cr
        '
        Me.Cr.DataPropertyName = "Cr"
        Me.Cr.HeaderText = "Cr"
        Me.Cr.Name = "Cr"
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
        'frmVoucherPosting
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(967, 523)
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "frmVoucherPosting"
        Me.Text = "Opening"
        Me.GBHeading.ResumeLayout(False)
        Me.GBFooter.ResumeLayout(False)
        Me.GBBody.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
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
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents rdbtnAccount As RadioButton
    Friend WithEvents rdbtnCustomer As RadioButton
    Friend WithEvents rdbtnSupplier As RadioButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnFill As Button
    Friend WithEvents VID As DataGridViewTextBoxColumn
    Friend WithEvents AccountID As DataGridViewTextBoxColumn
    Friend WithEvents VName As DataGridViewTextBoxColumn
    Friend WithEvents Dr As DataGridViewTextBoxColumn
    Friend WithEvents Cr As DataGridViewTextBoxColumn
    Friend WithEvents CompanyID As DataGridViewTextBoxColumn
    Friend WithEvents FinancialYearID As DataGridViewTextBoxColumn
End Class
