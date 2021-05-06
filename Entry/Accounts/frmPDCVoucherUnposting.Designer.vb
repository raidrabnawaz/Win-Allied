<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPDCVoucherUnposting
   Inherits WinBaseForms.GUIBaseFormEntry

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
      Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
      Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
      Me.dtpPostingDate = New System.Windows.Forms.DateTimePicker()
      Me.dtpDateTo = New System.Windows.Forms.DateTimePicker()
      Me.dtpDateFrom = New System.Windows.Forms.DateTimePicker()
      Me.Label4 = New System.Windows.Forms.Label()
      Me.Label3 = New System.Windows.Forms.Label()
      Me.Label2 = New System.Windows.Forms.Label()
      Me.Label1 = New System.Windows.Forms.Label()
      Me.cmbVType = New System.Windows.Forms.ComboBox()
      Me.grdRecord = New System.Windows.Forms.DataGridView()
      Me.VID = New System.Windows.Forms.DataGridViewTextBoxColumn()
      Me.VoucherNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
      Me.VType = New System.Windows.Forms.DataGridViewTextBoxColumn()
      Me.VDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
      Me.ChequeNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
      Me.ChequeDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
      Me.Narration = New System.Windows.Forms.DataGridViewTextBoxColumn()
      Me.IsPosted = New System.Windows.Forms.DataGridViewCheckBoxColumn()
      Me.CompanyID = New System.Windows.Forms.DataGridViewTextBoxColumn()
      Me.FinancialYearID = New System.Windows.Forms.DataGridViewTextBoxColumn()
      Me.GBHeading.SuspendLayout()
      Me.GBFooter.SuspendLayout()
      Me.GBBody.SuspendLayout()
      CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.SplitContainer1.Panel1.SuspendLayout()
      Me.SplitContainer1.Panel2.SuspendLayout()
      Me.SplitContainer1.SuspendLayout()
      CType(Me.grdRecord, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.SuspendLayout()
      '
      'cmdSave
      '
      Me.cmdSave.Location = New System.Drawing.Point(422, 8)
      '
      'cmdEdit
      '
      Me.cmdEdit.Location = New System.Drawing.Point(861, 8)
      Me.cmdEdit.Visible = False
      '
      'cmdDelete
      '
      Me.cmdDelete.Location = New System.Drawing.Point(697, 8)
      Me.cmdDelete.Visible = False
      '
      'cmdCancel
      '
      Me.cmdCancel.Location = New System.Drawing.Point(488, 8)
      '
      'cmdSearch
      '
      Me.cmdSearch.Location = New System.Drawing.Point(356, 8)
      '
      'cmdNew
      '
      Me.cmdNew.Location = New System.Drawing.Point(778, 8)
      Me.cmdNew.Visible = False
      '
      'GBHeading
      '
      Me.GBHeading.Size = New System.Drawing.Size(967, 42)
      '
      'GBFooter
      '
      Me.GBFooter.Location = New System.Drawing.Point(0, 447)
      Me.GBFooter.Size = New System.Drawing.Size(967, 76)
      '
      'GBBody
      '
      Me.GBBody.Controls.Add(Me.SplitContainer1)
      Me.GBBody.Size = New System.Drawing.Size(967, 405)
      '
      'lblHeading
      '
      Me.lblHeading.Size = New System.Drawing.Size(967, 42)
      Me.lblHeading.Text = "Voucher UnPosting"
      '
      'SplitContainer1
      '
      Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
      Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
      Me.SplitContainer1.Name = "SplitContainer1"
      Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
      '
      'SplitContainer1.Panel1
      '
      Me.SplitContainer1.Panel1.Controls.Add(Me.dtpPostingDate)
      Me.SplitContainer1.Panel1.Controls.Add(Me.dtpDateTo)
      Me.SplitContainer1.Panel1.Controls.Add(Me.dtpDateFrom)
      Me.SplitContainer1.Panel1.Controls.Add(Me.Label4)
      Me.SplitContainer1.Panel1.Controls.Add(Me.Label3)
      Me.SplitContainer1.Panel1.Controls.Add(Me.Label2)
      Me.SplitContainer1.Panel1.Controls.Add(Me.Label1)
      Me.SplitContainer1.Panel1.Controls.Add(Me.cmbVType)
      '
      'SplitContainer1.Panel2
      '
      Me.SplitContainer1.Panel2.Controls.Add(Me.grdRecord)
      Me.SplitContainer1.Size = New System.Drawing.Size(967, 405)
      Me.SplitContainer1.SplitterDistance = 38
      Me.SplitContainer1.TabIndex = 0
      '
      'dtpPostingDate
      '
      Me.dtpPostingDate.CustomFormat = "dd/MM/yyyy"
      Me.dtpPostingDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
      Me.dtpPostingDate.Location = New System.Drawing.Point(789, 10)
      Me.dtpPostingDate.Name = "dtpPostingDate"
      Me.dtpPostingDate.Size = New System.Drawing.Size(130, 20)
      Me.dtpPostingDate.TabIndex = 34
      '
      'dtpDateTo
      '
      Me.dtpDateTo.CustomFormat = "dd/MM/yyyy"
      Me.dtpDateTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
      Me.dtpDateTo.Location = New System.Drawing.Point(567, 10)
      Me.dtpDateTo.Name = "dtpDateTo"
      Me.dtpDateTo.Size = New System.Drawing.Size(130, 20)
      Me.dtpDateTo.TabIndex = 33
      '
      'dtpDateFrom
      '
      Me.dtpDateFrom.CustomFormat = "dd/MM/yyyy"
      Me.dtpDateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
      Me.dtpDateFrom.Location = New System.Drawing.Point(348, 10)
      Me.dtpDateFrom.Name = "dtpDateFrom"
      Me.dtpDateFrom.Size = New System.Drawing.Size(130, 20)
      Me.dtpDateFrom.TabIndex = 32
      '
      'Label4
      '
      Me.Label4.AutoSize = True
      Me.Label4.Location = New System.Drawing.Point(286, 13)
      Me.Label4.Name = "Label4"
      Me.Label4.Size = New System.Drawing.Size(56, 13)
      Me.Label4.TabIndex = 31
      Me.Label4.Text = "Date From"
      '
      'Label3
      '
      Me.Label3.AutoSize = True
      Me.Label3.Location = New System.Drawing.Point(515, 13)
      Me.Label3.Name = "Label3"
      Me.Label3.Size = New System.Drawing.Size(46, 13)
      Me.Label3.TabIndex = 30
      Me.Label3.Text = "Date To"
      '
      'Label2
      '
      Me.Label2.AutoSize = True
      Me.Label2.Location = New System.Drawing.Point(715, 13)
      Me.Label2.Name = "Label2"
      Me.Label2.Size = New System.Drawing.Size(68, 13)
      Me.Label2.TabIndex = 29
      Me.Label2.Text = "Posting Date"
      '
      'Label1
      '
      Me.Label1.AutoSize = True
      Me.Label1.Location = New System.Drawing.Point(48, 13)
      Me.Label1.Name = "Label1"
      Me.Label1.Size = New System.Drawing.Size(74, 13)
      Me.Label1.TabIndex = 28
      Me.Label1.Text = "Voucher Type"
      '
      'cmbVType
      '
      Me.cmbVType.FormattingEnabled = True
      Me.cmbVType.Location = New System.Drawing.Point(128, 10)
      Me.cmbVType.Name = "cmbVType"
      Me.cmbVType.Size = New System.Drawing.Size(121, 21)
      Me.cmbVType.TabIndex = 27
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
      Me.grdRecord.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.VID, Me.VoucherNo, Me.VType, Me.VDate, Me.ChequeNo, Me.ChequeDate, Me.Narration, Me.IsPosted, Me.CompanyID, Me.FinancialYearID})
      Me.grdRecord.Dock = System.Windows.Forms.DockStyle.Fill
      Me.grdRecord.Location = New System.Drawing.Point(0, 0)
      Me.grdRecord.Name = "grdRecord"
      Me.grdRecord.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
      Me.grdRecord.Size = New System.Drawing.Size(967, 363)
      Me.grdRecord.TabIndex = 1
      '
      'VID
      '
      Me.VID.DataPropertyName = "VID"
      Me.VID.HeaderText = "VID"
      Me.VID.Name = "VID"
      Me.VID.Visible = False
      '
      'VoucherNo
      '
      Me.VoucherNo.DataPropertyName = "VNo"
      Me.VoucherNo.HeaderText = "Voucher No"
      Me.VoucherNo.Name = "VoucherNo"
      Me.VoucherNo.ReadOnly = True
      '
      'VType
      '
      Me.VType.DataPropertyName = "VType"
      Me.VType.HeaderText = "Voucher Type"
      Me.VType.Name = "VType"
      Me.VType.ReadOnly = True
      '
      'VDate
      '
      Me.VDate.DataPropertyName = "VDate"
      Me.VDate.HeaderText = "Date"
      Me.VDate.Name = "VDate"
      Me.VDate.ReadOnly = True
      '
      'ChequeNo
      '
      Me.ChequeNo.DataPropertyName = "ChequeNo"
      Me.ChequeNo.HeaderText = "Cheque No"
      Me.ChequeNo.Name = "ChequeNo"
      Me.ChequeNo.ReadOnly = True
      '
      'ChequeDate
      '
      Me.ChequeDate.DataPropertyName = "ChequeDate"
      Me.ChequeDate.HeaderText = "Cheque Date"
      Me.ChequeDate.Name = "ChequeDate"
      Me.ChequeDate.ReadOnly = True
      '
      'Narration
      '
      Me.Narration.DataPropertyName = "Narration"
      Me.Narration.HeaderText = "Narration"
      Me.Narration.Name = "Narration"
      Me.Narration.ReadOnly = True
      Me.Narration.Width = 300
      '
      'IsPosted
      '
      Me.IsPosted.DataPropertyName = "IsPosted"
      Me.IsPosted.HeaderText = "Is Posted"
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
      'frmPDCVoucherUnposting
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.ClientSize = New System.Drawing.Size(967, 523)
      Me.Name = "frmPDCVoucherUnposting"
      Me.Text = "Voucher UnPosting"
      Me.GBHeading.ResumeLayout(False)
      Me.GBFooter.ResumeLayout(False)
      Me.GBBody.ResumeLayout(False)
      Me.SplitContainer1.Panel1.ResumeLayout(False)
      Me.SplitContainer1.Panel1.PerformLayout()
      Me.SplitContainer1.Panel2.ResumeLayout(False)
      CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
      Me.SplitContainer1.ResumeLayout(False)
      CType(Me.grdRecord, System.ComponentModel.ISupportInitialize).EndInit()
      Me.ResumeLayout(False)

   End Sub
   Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
   Friend WithEvents dtpPostingDate As System.Windows.Forms.DateTimePicker
   Friend WithEvents dtpDateTo As System.Windows.Forms.DateTimePicker
   Friend WithEvents dtpDateFrom As System.Windows.Forms.DateTimePicker
   Friend WithEvents Label4 As System.Windows.Forms.Label
   Friend WithEvents Label3 As System.Windows.Forms.Label
   Friend WithEvents Label2 As System.Windows.Forms.Label
   Friend WithEvents Label1 As System.Windows.Forms.Label
   Friend WithEvents cmbVType As System.Windows.Forms.ComboBox
   Friend WithEvents grdRecord As System.Windows.Forms.DataGridView
   Friend WithEvents VID As System.Windows.Forms.DataGridViewTextBoxColumn
   Friend WithEvents VoucherNo As System.Windows.Forms.DataGridViewTextBoxColumn
   Friend WithEvents VType As System.Windows.Forms.DataGridViewTextBoxColumn
   Friend WithEvents VDate As System.Windows.Forms.DataGridViewTextBoxColumn
   Friend WithEvents ChequeNo As System.Windows.Forms.DataGridViewTextBoxColumn
   Friend WithEvents ChequeDate As System.Windows.Forms.DataGridViewTextBoxColumn
   Friend WithEvents Narration As System.Windows.Forms.DataGridViewTextBoxColumn
   Friend WithEvents IsPosted As System.Windows.Forms.DataGridViewCheckBoxColumn
   Friend WithEvents CompanyID As System.Windows.Forms.DataGridViewTextBoxColumn
   Friend WithEvents FinancialYearID As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
