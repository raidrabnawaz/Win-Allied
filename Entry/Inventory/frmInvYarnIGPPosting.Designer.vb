<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInvYarnIGPPosting
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
      Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
      Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
      Me.GroupBox1 = New System.Windows.Forms.GroupBox()
      Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
      Me.txtVNo = New System.Windows.Forms.TextBox()
      Me.dtpPostingDate = New System.Windows.Forms.DateTimePicker()
      Me.dtpDateTo = New System.Windows.Forms.DateTimePicker()
      Me.dtpDateFrom = New System.Windows.Forms.DateTimePicker()
      Me.Label4 = New System.Windows.Forms.Label()
      Me.Label3 = New System.Windows.Forms.Label()
      Me.Label2 = New System.Windows.Forms.Label()
      Me.Label1 = New System.Windows.Forms.Label()
      Me.lblInformation = New System.Windows.Forms.Label()
      Me.grdRecord = New System.Windows.Forms.DataGridView()
      Me.VID = New System.Windows.Forms.DataGridViewTextBoxColumn()
      Me.VoucherNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
      Me.VDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
      Me.Narration = New System.Windows.Forms.DataGridViewTextBoxColumn()
      Me.OGPQuantity = New System.Windows.Forms.DataGridViewTextBoxColumn()
      Me.IGPQuantity = New System.Windows.Forms.DataGridViewTextBoxColumn()
      Me.PendingQty = New System.Windows.Forms.DataGridViewTextBoxColumn()
      Me.IsPosted = New System.Windows.Forms.DataGridViewCheckBoxColumn()
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
      CType(Me.grdRecord, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.SuspendLayout()
      '
      'cmdSave
      '
      Me.cmdSave.Location = New System.Drawing.Point(440, 6)
      '
      'cmdEdit
      '
      Me.cmdEdit.Enabled = False
      Me.cmdEdit.Location = New System.Drawing.Point(586, 6)
      Me.cmdEdit.Visible = False
      '
      'cmdDelete
      '
      Me.cmdDelete.Enabled = False
      Me.cmdDelete.Location = New System.Drawing.Point(652, 6)
      Me.cmdDelete.Visible = False
      '
      'cmdCancel
      '
      Me.cmdCancel.Location = New System.Drawing.Point(506, 6)
      '
      'cmdSearch
      '
      Me.cmdSearch.Location = New System.Drawing.Point(374, 6)
      '
      'cmdNew
      '
      Me.cmdNew.Enabled = False
      Me.cmdNew.Location = New System.Drawing.Point(718, 6)
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
      Me.lblHeading.Text = "Yarn OGP Posting"
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
      Me.SplitContainer1.Panel1.Controls.Add(Me.txtVNo)
      Me.SplitContainer1.Panel1.Controls.Add(Me.dtpPostingDate)
      Me.SplitContainer1.Panel1.Controls.Add(Me.dtpDateTo)
      Me.SplitContainer1.Panel1.Controls.Add(Me.dtpDateFrom)
      Me.SplitContainer1.Panel1.Controls.Add(Me.Label4)
      Me.SplitContainer1.Panel1.Controls.Add(Me.Label3)
      Me.SplitContainer1.Panel1.Controls.Add(Me.Label2)
      Me.SplitContainer1.Panel1.Controls.Add(Me.Label1)
      Me.SplitContainer1.Panel1.Controls.Add(Me.lblInformation)
      '
      'SplitContainer1.Panel2
      '
      Me.SplitContainer1.Panel2.Controls.Add(Me.grdRecord)
      Me.SplitContainer1.Size = New System.Drawing.Size(961, 386)
      Me.SplitContainer1.SplitterDistance = 40
      Me.SplitContainer1.TabIndex = 0
      '
      'txtVNo
      '
      Me.txtVNo.Location = New System.Drawing.Point(114, 8)
      Me.txtVNo.Name = "txtVNo"
      Me.txtVNo.Size = New System.Drawing.Size(130, 20)
      Me.txtVNo.TabIndex = 27
      '
      'dtpPostingDate
      '
      Me.dtpPostingDate.CustomFormat = "dd/MM/yyyy"
      Me.dtpPostingDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
      Me.dtpPostingDate.Location = New System.Drawing.Point(774, 8)
      Me.dtpPostingDate.Name = "dtpPostingDate"
      Me.dtpPostingDate.Size = New System.Drawing.Size(130, 20)
      Me.dtpPostingDate.TabIndex = 26
      '
      'dtpDateTo
      '
      Me.dtpDateTo.CustomFormat = "dd/MM/yyyy"
      Me.dtpDateTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
      Me.dtpDateTo.Location = New System.Drawing.Point(552, 8)
      Me.dtpDateTo.Name = "dtpDateTo"
      Me.dtpDateTo.Size = New System.Drawing.Size(130, 20)
      Me.dtpDateTo.TabIndex = 25
      '
      'dtpDateFrom
      '
      Me.dtpDateFrom.CustomFormat = "dd/MM/yyyy"
      Me.dtpDateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
      Me.dtpDateFrom.Location = New System.Drawing.Point(333, 8)
      Me.dtpDateFrom.Name = "dtpDateFrom"
      Me.dtpDateFrom.Size = New System.Drawing.Size(130, 20)
      Me.dtpDateFrom.TabIndex = 24
      '
      'Label4
      '
      Me.Label4.AutoSize = True
      Me.Label4.Location = New System.Drawing.Point(271, 11)
      Me.Label4.Name = "Label4"
      Me.Label4.Size = New System.Drawing.Size(56, 13)
      Me.Label4.TabIndex = 23
      Me.Label4.Text = "Date From"
      '
      'Label3
      '
      Me.Label3.AutoSize = True
      Me.Label3.Location = New System.Drawing.Point(500, 11)
      Me.Label3.Name = "Label3"
      Me.Label3.Size = New System.Drawing.Size(46, 13)
      Me.Label3.TabIndex = 22
      Me.Label3.Text = "Date To"
      '
      'Label2
      '
      Me.Label2.AutoSize = True
      Me.Label2.Location = New System.Drawing.Point(700, 11)
      Me.Label2.Name = "Label2"
      Me.Label2.Size = New System.Drawing.Size(68, 13)
      Me.Label2.TabIndex = 21
      Me.Label2.Text = "Posting Date"
      '
      'Label1
      '
      Me.Label1.AutoSize = True
      Me.Label1.Location = New System.Drawing.Point(36, 11)
      Me.Label1.Name = "Label1"
      Me.Label1.Size = New System.Drawing.Size(72, 13)
      Me.Label1.TabIndex = 19
      Me.Label1.Text = "Yarn OGP No"
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
      Me.grdRecord.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.VID, Me.VoucherNo, Me.VDate, Me.Narration, Me.OGPQuantity, Me.IGPQuantity, Me.PendingQty, Me.IsPosted, Me.CompanyID, Me.FinancialYearID})
      Me.grdRecord.Dock = System.Windows.Forms.DockStyle.Fill
      Me.grdRecord.Location = New System.Drawing.Point(0, 0)
      Me.grdRecord.Name = "grdRecord"
      Me.grdRecord.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
      Me.grdRecord.Size = New System.Drawing.Size(961, 342)
      Me.grdRecord.TabIndex = 0
      '
      'VID
      '
      Me.VID.DataPropertyName = "VID"
      Me.VID.HeaderText = "VID"
      Me.VID.Name = "VID"
      Me.VID.ReadOnly = True
      Me.VID.Visible = False
      '
      'VoucherNo
      '
      Me.VoucherNo.DataPropertyName = "VNo"
      Me.VoucherNo.HeaderText = "OGP No"
      Me.VoucherNo.Name = "VoucherNo"
      Me.VoucherNo.ReadOnly = True
      '
      'VDate
      '
      Me.VDate.DataPropertyName = "VDate"
      Me.VDate.HeaderText = "Date"
      Me.VDate.Name = "VDate"
      Me.VDate.ReadOnly = True
      '
      'Narration
      '
      Me.Narration.DataPropertyName = "Narration"
      Me.Narration.HeaderText = "Narration"
      Me.Narration.Name = "Narration"
      Me.Narration.ReadOnly = True
      Me.Narration.Width = 300
      '
      'OGPQuantity
      '
      Me.OGPQuantity.DataPropertyName = "OGPQuantity"
      DataGridViewCellStyle2.Format = "N2"
      DataGridViewCellStyle2.NullValue = Nothing
      Me.OGPQuantity.DefaultCellStyle = DataGridViewCellStyle2
      Me.OGPQuantity.HeaderText = "OGP Weight"
      Me.OGPQuantity.Name = "OGPQuantity"
      Me.OGPQuantity.ReadOnly = True
      '
      'IGPQuantity
      '
      Me.IGPQuantity.DataPropertyName = "IGPQuantity"
      DataGridViewCellStyle3.Format = "N2"
      DataGridViewCellStyle3.NullValue = Nothing
      Me.IGPQuantity.DefaultCellStyle = DataGridViewCellStyle3
      Me.IGPQuantity.HeaderText = "IGP Weight"
      Me.IGPQuantity.Name = "IGPQuantity"
      Me.IGPQuantity.ReadOnly = True
      '
      'PendingQty
      '
      Me.PendingQty.DataPropertyName = "PendingQty"
      DataGridViewCellStyle4.Format = "N2"
      DataGridViewCellStyle4.NullValue = Nothing
      Me.PendingQty.DefaultCellStyle = DataGridViewCellStyle4
      Me.PendingQty.HeaderText = "Pending Weight"
      Me.PendingQty.Name = "PendingQty"
      Me.PendingQty.ReadOnly = True
      '
      'IsPosted
      '
      Me.IsPosted.DataPropertyName = "IsPosted"
      Me.IsPosted.HeaderText = "Is Completed"
      Me.IsPosted.Name = "IsPosted"
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
      'frmInvYarnIGPPosting
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.ClientSize = New System.Drawing.Size(967, 523)
      Me.Margin = New System.Windows.Forms.Padding(5)
      Me.Name = "frmInvYarnIGPPosting"
      Me.Text = "Yarn OGP Posting"
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
   Friend WithEvents Label1 As Label
   Friend WithEvents Label4 As Label
   Friend WithEvents Label3 As Label
   Friend WithEvents Label2 As Label
   Friend WithEvents dtpPostingDate As System.Windows.Forms.DateTimePicker
   Friend WithEvents dtpDateTo As System.Windows.Forms.DateTimePicker
   Friend WithEvents dtpDateFrom As System.Windows.Forms.DateTimePicker
   Friend WithEvents txtVNo As System.Windows.Forms.TextBox
   Friend WithEvents VID As System.Windows.Forms.DataGridViewTextBoxColumn
   Friend WithEvents VoucherNo As System.Windows.Forms.DataGridViewTextBoxColumn
   Friend WithEvents VDate As System.Windows.Forms.DataGridViewTextBoxColumn
   Friend WithEvents Narration As System.Windows.Forms.DataGridViewTextBoxColumn
   Friend WithEvents OGPQuantity As System.Windows.Forms.DataGridViewTextBoxColumn
   Friend WithEvents IGPQuantity As System.Windows.Forms.DataGridViewTextBoxColumn
   Friend WithEvents PendingQty As System.Windows.Forms.DataGridViewTextBoxColumn
   Friend WithEvents IsPosted As System.Windows.Forms.DataGridViewCheckBoxColumn
   Friend WithEvents CompanyID As System.Windows.Forms.DataGridViewTextBoxColumn
   Friend WithEvents FinancialYearID As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
