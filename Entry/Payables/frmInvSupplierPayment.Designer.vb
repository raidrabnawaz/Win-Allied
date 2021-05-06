<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInvSupplierPayment
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
      Me.Label4 = New System.Windows.Forms.Label()
      Me.GroupBox1 = New System.Windows.Forms.GroupBox()
      Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
      Me.Label7 = New System.Windows.Forms.Label()
      Me.Label6 = New System.Windows.Forms.Label()
      Me.Label5 = New System.Windows.Forms.Label()
      Me.cmbBank = New System.Windows.Forms.ComboBox()
      Me.dtpVDate = New System.Windows.Forms.DateTimePicker()
      Me.dtpPaymentDate = New System.Windows.Forms.DateTimePicker()
      Me.cmbSupplier = New System.Windows.Forms.ComboBox()
      Me.Label2 = New System.Windows.Forms.Label()
      Me.txtAmount = New System.Windows.Forms.TextBox()
      Me.Label1 = New System.Windows.Forms.Label()
      Me.txtVCode = New System.Windows.Forms.TextBox()
      Me.Label3 = New System.Windows.Forms.Label()
      Me.txtNarration = New System.Windows.Forms.TextBox()
      Me.txtID = New System.Windows.Forms.TextBox()
      Me.grdRecord = New System.Windows.Forms.DataGridView()
      Me.lblInformation = New System.Windows.Forms.Label()
      Me.VID = New System.Windows.Forms.DataGridViewTextBoxColumn()
      Me.PurchaseOrderID = New System.Windows.Forms.DataGridViewTextBoxColumn()
      Me.SupplierID = New System.Windows.Forms.DataGridViewTextBoxColumn()
      Me.IGPID = New System.Windows.Forms.DataGridViewTextBoxColumn()
      Me.GRNID = New System.Windows.Forms.DataGridViewTextBoxColumn()
      Me.PONO = New System.Windows.Forms.DataGridViewTextBoxColumn()
      Me.OrderNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
      Me.GRNNO = New System.Windows.Forms.DataGridViewTextBoxColumn()
      Me.GRNDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
      Me.FreightAmount = New System.Windows.Forms.DataGridViewTextBoxColumn()
      Me.GRNAmount = New System.Windows.Forms.DataGridViewTextBoxColumn()
      Me.CollectedAmount = New System.Windows.Forms.DataGridViewTextBoxColumn()
      Me.PendingAmount = New System.Windows.Forms.DataGridViewTextBoxColumn()
      Me.DetDiscount = New System.Windows.Forms.DataGridViewTextBoxColumn()
      Me.DetExtra = New System.Windows.Forms.DataGridViewTextBoxColumn()
      Me.DetAmount = New System.Windows.Forms.DataGridViewTextBoxColumn()
      Me.DetInstructions = New System.Windows.Forms.DataGridViewTextBoxColumn()
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
      Me.cmdSave.Location = New System.Drawing.Point(338, 6)
      '
      'cmdEdit
      '
      Me.cmdEdit.Location = New System.Drawing.Point(404, 6)
      '
      'cmdDelete
      '
      Me.cmdDelete.Location = New System.Drawing.Point(602, 6)
      '
      'cmdCancel
      '
      Me.cmdCancel.Location = New System.Drawing.Point(536, 6)
      '
      'cmdSearch
      '
      Me.cmdSearch.Location = New System.Drawing.Point(470, 6)
      '
      'cmdNew
      '
      Me.cmdNew.Location = New System.Drawing.Point(272, 6)
      Me.cmdNew.TabIndex = 0
      '
      'GBHeading
      '
      Me.GBHeading.Margin = New System.Windows.Forms.Padding(5)
      Me.GBHeading.Size = New System.Drawing.Size(967, 42)
      '
      'GBFooter
      '
      Me.GBFooter.Controls.Add(Me.lblInformation)
      Me.GBFooter.Location = New System.Drawing.Point(0, 447)
      Me.GBFooter.Margin = New System.Windows.Forms.Padding(5)
      Me.GBFooter.Size = New System.Drawing.Size(967, 76)
      Me.GBFooter.Controls.SetChildIndex(Me.cmdSave, 0)
      Me.GBFooter.Controls.SetChildIndex(Me.cmdEdit, 0)
      Me.GBFooter.Controls.SetChildIndex(Me.cmdSearch, 0)
      Me.GBFooter.Controls.SetChildIndex(Me.cmdCancel, 0)
      Me.GBFooter.Controls.SetChildIndex(Me.lblInformation, 0)
      Me.GBFooter.Controls.SetChildIndex(Me.cmdDelete, 0)
      Me.GBFooter.Controls.SetChildIndex(Me.cmdNew, 0)
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
      Me.lblHeading.Text = "Supplier Payment"
      '
      'Label4
      '
      Me.Label4.AutoSize = True
      Me.Label4.ForeColor = System.Drawing.Color.Black
      Me.Label4.Location = New System.Drawing.Point(367, 13)
      Me.Label4.Name = "Label4"
      Me.Label4.Size = New System.Drawing.Size(71, 13)
      Me.Label4.TabIndex = 5
      Me.Label4.Text = "Invoice Date:"
      '
      'GroupBox1
      '
      Me.GroupBox1.Controls.Add(Me.SplitContainer1)
      Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
      Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
      Me.GroupBox1.Name = "GroupBox1"
      Me.GroupBox1.Size = New System.Drawing.Size(967, 405)
      Me.GroupBox1.TabIndex = 4
      Me.GroupBox1.TabStop = False
      '
      'SplitContainer1
      '
      Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
      Me.SplitContainer1.Location = New System.Drawing.Point(3, 16)
      Me.SplitContainer1.Name = "SplitContainer1"
      Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
      '
      'SplitContainer1.Panel1
      '
      Me.SplitContainer1.Panel1.Controls.Add(Me.Label7)
      Me.SplitContainer1.Panel1.Controls.Add(Me.Label6)
      Me.SplitContainer1.Panel1.Controls.Add(Me.Label5)
      Me.SplitContainer1.Panel1.Controls.Add(Me.cmbBank)
      Me.SplitContainer1.Panel1.Controls.Add(Me.dtpVDate)
      Me.SplitContainer1.Panel1.Controls.Add(Me.dtpPaymentDate)
      Me.SplitContainer1.Panel1.Controls.Add(Me.cmbSupplier)
      Me.SplitContainer1.Panel1.Controls.Add(Me.Label2)
      Me.SplitContainer1.Panel1.Controls.Add(Me.txtAmount)
      Me.SplitContainer1.Panel1.Controls.Add(Me.Label1)
      Me.SplitContainer1.Panel1.Controls.Add(Me.txtVCode)
      Me.SplitContainer1.Panel1.Controls.Add(Me.Label3)
      Me.SplitContainer1.Panel1.Controls.Add(Me.txtNarration)
      Me.SplitContainer1.Panel1.Controls.Add(Me.txtID)
      Me.SplitContainer1.Panel1.Controls.Add(Me.Label4)
      '
      'SplitContainer1.Panel2
      '
      Me.SplitContainer1.Panel2.Controls.Add(Me.grdRecord)
      Me.SplitContainer1.Size = New System.Drawing.Size(961, 386)
      Me.SplitContainer1.SplitterDistance = 109
      Me.SplitContainer1.TabIndex = 7
      '
      'Label7
      '
      Me.Label7.AutoSize = True
      Me.Label7.ForeColor = System.Drawing.Color.Black
      Me.Label7.Location = New System.Drawing.Point(75, 74)
      Me.Label7.Name = "Label7"
      Me.Label7.Size = New System.Drawing.Size(53, 13)
      Me.Label7.TabIndex = 23
      Me.Label7.Text = "Narration:"
      '
      'Label6
      '
      Me.Label6.AutoSize = True
      Me.Label6.ForeColor = System.Drawing.Color.Black
      Me.Label6.Location = New System.Drawing.Point(686, 41)
      Me.Label6.Name = "Label6"
      Me.Label6.Size = New System.Drawing.Size(46, 13)
      Me.Label6.TabIndex = 22
      Me.Label6.Text = "Amount:"
      '
      'Label5
      '
      Me.Label5.AutoSize = True
      Me.Label5.ForeColor = System.Drawing.Color.Black
      Me.Label5.Location = New System.Drawing.Point(403, 41)
      Me.Label5.Name = "Label5"
      Me.Label5.Size = New System.Drawing.Size(35, 13)
      Me.Label5.TabIndex = 21
      Me.Label5.Text = "Bank:"
      '
      'cmbBank
      '
      Me.cmbBank.FormattingEnabled = True
      Me.cmbBank.Location = New System.Drawing.Point(444, 41)
      Me.cmbBank.Name = "cmbBank"
      Me.cmbBank.Size = New System.Drawing.Size(136, 21)
      Me.cmbBank.TabIndex = 20
      '
      'dtpVDate
      '
      Me.dtpVDate.CustomFormat = "dd/MM/yyyy"
      Me.dtpVDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
      Me.dtpVDate.Location = New System.Drawing.Point(444, 10)
      Me.dtpVDate.Name = "dtpVDate"
      Me.dtpVDate.Size = New System.Drawing.Size(136, 20)
      Me.dtpVDate.TabIndex = 19
      '
      'dtpPaymentDate
      '
      Me.dtpPaymentDate.CustomFormat = "dd/MM/yyyy"
      Me.dtpPaymentDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
      Me.dtpPaymentDate.Location = New System.Drawing.Point(134, 41)
      Me.dtpPaymentDate.Name = "dtpPaymentDate"
      Me.dtpPaymentDate.Size = New System.Drawing.Size(182, 20)
      Me.dtpPaymentDate.TabIndex = 18
      '
      'cmbSupplier
      '
      Me.cmbSupplier.FormattingEnabled = True
      Me.cmbSupplier.Location = New System.Drawing.Point(738, 7)
      Me.cmbSupplier.Name = "cmbSupplier"
      Me.cmbSupplier.Size = New System.Drawing.Size(182, 21)
      Me.cmbSupplier.TabIndex = 2
      '
      'Label2
      '
      Me.Label2.AutoSize = True
      Me.Label2.ForeColor = System.Drawing.Color.Black
      Me.Label2.Location = New System.Drawing.Point(684, 10)
      Me.Label2.Name = "Label2"
      Me.Label2.Size = New System.Drawing.Size(48, 13)
      Me.Label2.TabIndex = 9
      Me.Label2.Text = "Supplier:"
      '
      'txtAmount
      '
      Me.txtAmount.Location = New System.Drawing.Point(738, 37)
      Me.txtAmount.MaxLength = 50
      Me.txtAmount.Name = "txtAmount"
      Me.txtAmount.Size = New System.Drawing.Size(182, 20)
      Me.txtAmount.TabIndex = 3
      '
      'Label1
      '
      Me.Label1.AutoSize = True
      Me.Label1.ForeColor = System.Drawing.Color.Black
      Me.Label1.Location = New System.Drawing.Point(51, 41)
      Me.Label1.Name = "Label1"
      Me.Label1.Size = New System.Drawing.Size(77, 13)
      Me.Label1.TabIndex = 7
      Me.Label1.Text = "Payment Date:"
      '
      'txtVCode
      '
      Me.txtVCode.Location = New System.Drawing.Point(134, 10)
      Me.txtVCode.Name = "txtVCode"
      Me.txtVCode.Size = New System.Drawing.Size(182, 20)
      Me.txtVCode.TabIndex = 0
      '
      'Label3
      '
      Me.Label3.AutoSize = True
      Me.Label3.ForeColor = System.Drawing.Color.Black
      Me.Label3.Location = New System.Drawing.Point(60, 13)
      Me.Label3.Name = "Label3"
      Me.Label3.Size = New System.Drawing.Size(68, 13)
      Me.Label3.TabIndex = 0
      Me.Label3.Text = "Payment No:"
      '
      'txtNarration
      '
      Me.txtNarration.Location = New System.Drawing.Point(134, 71)
      Me.txtNarration.MaxLength = 50
      Me.txtNarration.Name = "txtNarration"
      Me.txtNarration.Size = New System.Drawing.Size(446, 20)
      Me.txtNarration.TabIndex = 1
      '
      'txtID
      '
      Me.txtID.Location = New System.Drawing.Point(-3, 3)
      Me.txtID.Name = "txtID"
      Me.txtID.ReadOnly = True
      Me.txtID.Size = New System.Drawing.Size(62, 20)
      Me.txtID.TabIndex = 3
      Me.txtID.Visible = False
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
      Me.grdRecord.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.VID, Me.PurchaseOrderID, Me.SupplierID, Me.IGPID, Me.GRNID, Me.PONO, Me.OrderNo, Me.GRNNO, Me.GRNDate, Me.FreightAmount, Me.GRNAmount, Me.CollectedAmount, Me.PendingAmount, Me.DetDiscount, Me.DetExtra, Me.DetAmount, Me.DetInstructions})
      Me.grdRecord.Dock = System.Windows.Forms.DockStyle.Fill
      Me.grdRecord.Location = New System.Drawing.Point(0, 0)
      Me.grdRecord.Name = "grdRecord"
      Me.grdRecord.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
      Me.grdRecord.Size = New System.Drawing.Size(961, 273)
      Me.grdRecord.TabIndex = 0
      '
      'lblInformation
      '
      Me.lblInformation.BackColor = System.Drawing.Color.Transparent
      Me.lblInformation.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lblInformation.ForeColor = System.Drawing.Color.Green
      Me.lblInformation.Location = New System.Drawing.Point(685, 22)
      Me.lblInformation.Name = "lblInformation"
      Me.lblInformation.Size = New System.Drawing.Size(282, 22)
      Me.lblInformation.TabIndex = 4
      Me.lblInformation.Text = "."
      '
      'VID
      '
      Me.VID.HeaderText = "VID"
      Me.VID.Name = "VID"
      Me.VID.ReadOnly = True
      Me.VID.Visible = False
      '
      'PurchaseOrderID
      '
      Me.PurchaseOrderID.DataPropertyName = "PurchaseOrderID"
      Me.PurchaseOrderID.HeaderText = "PurchaseOrderID"
      Me.PurchaseOrderID.Name = "PurchaseOrderID"
      Me.PurchaseOrderID.ReadOnly = True
      Me.PurchaseOrderID.Visible = False
      '
      'SupplierID
      '
      Me.SupplierID.DataPropertyName = "SupplierID"
      Me.SupplierID.HeaderText = "SupplierID"
      Me.SupplierID.Name = "SupplierID"
      Me.SupplierID.ReadOnly = True
      Me.SupplierID.Visible = False
      '
      'IGPID
      '
      Me.IGPID.DataPropertyName = "IGPID"
      Me.IGPID.HeaderText = "IGPID"
      Me.IGPID.Name = "IGPID"
      Me.IGPID.ReadOnly = True
      Me.IGPID.Visible = False
      '
      'GRNID
      '
      Me.GRNID.DataPropertyName = "GRNID"
      Me.GRNID.HeaderText = "GRNID"
      Me.GRNID.Name = "GRNID"
      Me.GRNID.ReadOnly = True
      Me.GRNID.Visible = False
      '
      'PONO
      '
      Me.PONO.DataPropertyName = "PONO"
      Me.PONO.HeaderText = "PO NO"
      Me.PONO.Name = "PONO"
      Me.PONO.ReadOnly = True
      '
      'OrderNo
      '
      Me.OrderNo.DataPropertyName = "OrderNo"
      Me.OrderNo.HeaderText = "Order No"
      Me.OrderNo.Name = "OrderNo"
      Me.OrderNo.ReadOnly = True
      '
      'GRNNO
      '
      Me.GRNNO.DataPropertyName = "GRNNO"
      Me.GRNNO.HeaderText = "GRN No"
      Me.GRNNO.Name = "GRNNO"
      Me.GRNNO.ReadOnly = True
      '
      'GRNDate
      '
      Me.GRNDate.DataPropertyName = "GRNDate"
      Me.GRNDate.HeaderText = "GRN Date"
      Me.GRNDate.Name = "GRNDate"
      Me.GRNDate.ReadOnly = True
      '
      'FreightAmount
      '
      Me.FreightAmount.DataPropertyName = "FreightAmount"
      Me.FreightAmount.HeaderText = "Freight Amount"
      Me.FreightAmount.Name = "FreightAmount"
      Me.FreightAmount.ReadOnly = True
      Me.FreightAmount.Visible = False
      '
      'GRNAmount
      '
      Me.GRNAmount.DataPropertyName = "GRNAmount"
      Me.GRNAmount.HeaderText = "GRN Amount"
      Me.GRNAmount.Name = "GRNAmount"
      Me.GRNAmount.ReadOnly = True
      '
      'CollectedAmount
      '
      Me.CollectedAmount.DataPropertyName = "CollectedAmount"
      Me.CollectedAmount.HeaderText = "Collected Amount"
      Me.CollectedAmount.Name = "CollectedAmount"
      Me.CollectedAmount.ReadOnly = True
      '
      'PendingAmount
      '
      Me.PendingAmount.DataPropertyName = "PendingAmount"
      Me.PendingAmount.HeaderText = "Pending Amount"
      Me.PendingAmount.Name = "PendingAmount"
      Me.PendingAmount.ReadOnly = True
      '
      'DetDiscount
      '
      Me.DetDiscount.DataPropertyName = "DetDiscount"
      DataGridViewCellStyle2.Format = "N2"
      DataGridViewCellStyle2.NullValue = Nothing
      Me.DetDiscount.DefaultCellStyle = DataGridViewCellStyle2
      Me.DetDiscount.HeaderText = "Discount"
      Me.DetDiscount.Name = "DetDiscount"
      Me.DetDiscount.Visible = False
      '
      'DetExtra
      '
      Me.DetExtra.DataPropertyName = "DetExtra"
      DataGridViewCellStyle3.Format = "N2"
      DataGridViewCellStyle3.NullValue = Nothing
      Me.DetExtra.DefaultCellStyle = DataGridViewCellStyle3
      Me.DetExtra.HeaderText = "Extra"
      Me.DetExtra.Name = "DetExtra"
      '
      'DetAmount
      '
      Me.DetAmount.DataPropertyName = "DetAmount"
      DataGridViewCellStyle4.Format = "N2"
      DataGridViewCellStyle4.NullValue = Nothing
      Me.DetAmount.DefaultCellStyle = DataGridViewCellStyle4
      Me.DetAmount.HeaderText = "Amount"
      Me.DetAmount.Name = "DetAmount"
      '
      'DetInstructions
      '
      Me.DetInstructions.DataPropertyName = "DetInstructions"
      Me.DetInstructions.HeaderText = "Remarks"
      Me.DetInstructions.Name = "DetInstructions"
      '
      'frmInvSupplierPayment
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.ClientSize = New System.Drawing.Size(967, 523)
      Me.Margin = New System.Windows.Forms.Padding(5)
      Me.Name = "frmInvSupplierPayment"
      Me.Text = "Supplier Payment"
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
   Friend WithEvents Label4 As System.Windows.Forms.Label
   Friend WithEvents txtNarration As System.Windows.Forms.TextBox
   Friend WithEvents txtID As System.Windows.Forms.TextBox
   Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
   Friend WithEvents grdRecord As System.Windows.Forms.DataGridView
   Friend WithEvents lblInformation As System.Windows.Forms.Label
   Friend WithEvents Label3 As System.Windows.Forms.Label
   Friend WithEvents txtVCode As TextBox
   Friend WithEvents cmbSupplier As System.Windows.Forms.ComboBox
   Friend WithEvents Label2 As System.Windows.Forms.Label
   Friend WithEvents txtAmount As System.Windows.Forms.TextBox
   Friend WithEvents Label1 As System.Windows.Forms.Label
   Friend WithEvents dtpPaymentDate As System.Windows.Forms.DateTimePicker
   Friend WithEvents Label7 As System.Windows.Forms.Label
   Friend WithEvents Label6 As System.Windows.Forms.Label
   Friend WithEvents Label5 As System.Windows.Forms.Label
   Friend WithEvents cmbBank As System.Windows.Forms.ComboBox
   Friend WithEvents dtpVDate As System.Windows.Forms.DateTimePicker
   Friend WithEvents VID As System.Windows.Forms.DataGridViewTextBoxColumn
   Friend WithEvents PurchaseOrderID As System.Windows.Forms.DataGridViewTextBoxColumn
   Friend WithEvents SupplierID As System.Windows.Forms.DataGridViewTextBoxColumn
   Friend WithEvents IGPID As System.Windows.Forms.DataGridViewTextBoxColumn
   Friend WithEvents GRNID As System.Windows.Forms.DataGridViewTextBoxColumn
   Friend WithEvents PONO As System.Windows.Forms.DataGridViewTextBoxColumn
   Friend WithEvents OrderNo As System.Windows.Forms.DataGridViewTextBoxColumn
   Friend WithEvents GRNNO As System.Windows.Forms.DataGridViewTextBoxColumn
   Friend WithEvents GRNDate As System.Windows.Forms.DataGridViewTextBoxColumn
   Friend WithEvents FreightAmount As System.Windows.Forms.DataGridViewTextBoxColumn
   Friend WithEvents GRNAmount As System.Windows.Forms.DataGridViewTextBoxColumn
   Friend WithEvents CollectedAmount As System.Windows.Forms.DataGridViewTextBoxColumn
   Friend WithEvents PendingAmount As System.Windows.Forms.DataGridViewTextBoxColumn
   Friend WithEvents DetDiscount As System.Windows.Forms.DataGridViewTextBoxColumn
   Friend WithEvents DetExtra As System.Windows.Forms.DataGridViewTextBoxColumn
   Friend WithEvents DetAmount As System.Windows.Forms.DataGridViewTextBoxColumn
   Friend WithEvents DetInstructions As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
