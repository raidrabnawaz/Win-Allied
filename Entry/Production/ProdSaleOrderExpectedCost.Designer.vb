<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProdSaleOrderExpectedCost
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
      Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
      Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
      Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
      Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
      Me.GroupBox1 = New System.Windows.Forms.GroupBox()
      Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
      Me.lblTotalAmount = New System.Windows.Forms.Label()
      Me.txtOtherCharges3 = New System.Windows.Forms.TextBox()
      Me.Label7 = New System.Windows.Forms.Label()
      Me.txtOtherCharges4 = New System.Windows.Forms.TextBox()
      Me.Label5 = New System.Windows.Forms.Label()
      Me.txtRemaeks = New System.Windows.Forms.TextBox()
      Me.Label4 = New System.Windows.Forms.Label()
      Me.Label3 = New System.Windows.Forms.Label()
      Me.txtOtherCharges2 = New System.Windows.Forms.TextBox()
      Me.Label2 = New System.Windows.Forms.Label()
      Me.txtOtherCharges1 = New System.Windows.Forms.TextBox()
      Me.Label1 = New System.Windows.Forms.Label()
      Me.lblVNo = New System.Windows.Forms.Label()
      Me.lblVID = New System.Windows.Forms.Label()
      Me.txtVName = New System.Windows.Forms.TextBox()
      Me.Label6 = New System.Windows.Forms.Label()
      Me.lblInformation = New System.Windows.Forms.Label()
      Me.grdRecord = New System.Windows.Forms.DataGridView()
      Me.VID = New System.Windows.Forms.DataGridViewTextBoxColumn()
      Me.AccessoryID = New System.Windows.Forms.DataGridViewTextBoxColumn()
      Me.OrderID = New System.Windows.Forms.DataGridViewTextBoxColumn()
      Me.ProductID = New System.Windows.Forms.DataGridViewTextBoxColumn()
      Me.UOMID = New System.Windows.Forms.DataGridViewTextBoxColumn()
      Me.Product = New System.Windows.Forms.DataGridViewTextBoxColumn()
      Me.Remarks = New System.Windows.Forms.DataGridViewTextBoxColumn()
      Me.VQuantity = New System.Windows.Forms.DataGridViewTextBoxColumn()
      Me.LastRate = New System.Windows.Forms.DataGridViewTextBoxColumn()
      Me.VRate = New System.Windows.Forms.DataGridViewTextBoxColumn()
      Me.Amount = New System.Windows.Forms.DataGridViewTextBoxColumn()
      Me.POQuantity = New System.Windows.Forms.DataGridViewTextBoxColumn()
      Me.PORate = New System.Windows.Forms.DataGridViewTextBoxColumn()
      Me.POAmount = New System.Windows.Forms.DataGridViewTextBoxColumn()
      Me.AmountDifference = New System.Windows.Forms.DataGridViewTextBoxColumn()
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
      Me.cmdSave.Location = New System.Drawing.Point(535, 6)
      '
      'cmdEdit
      '
      Me.cmdEdit.Enabled = False
      Me.cmdEdit.Location = New System.Drawing.Point(681, 6)
      Me.cmdEdit.TabIndex = 3
      Me.cmdEdit.Visible = False
      '
      'cmdDelete
      '
      Me.cmdDelete.Enabled = False
      Me.cmdDelete.Location = New System.Drawing.Point(747, 6)
      Me.cmdDelete.TabIndex = 4
      Me.cmdDelete.Visible = False
      '
      'cmdCancel
      '
      Me.cmdCancel.Location = New System.Drawing.Point(601, 6)
      Me.cmdCancel.TabIndex = 2
      '
      'cmdSearch
      '
      Me.cmdSearch.Location = New System.Drawing.Point(469, 6)
      Me.cmdSearch.TabIndex = 0
      '
      'cmdNew
      '
      Me.cmdNew.Enabled = False
      Me.cmdNew.Location = New System.Drawing.Point(813, 6)
      Me.cmdNew.TabIndex = 5
      Me.cmdNew.Visible = False
      '
      'GBHeading
      '
      Me.GBHeading.Margin = New System.Windows.Forms.Padding(5)
      Me.GBHeading.Size = New System.Drawing.Size(1160, 42)
      '
      'GBFooter
      '
      Me.GBFooter.Location = New System.Drawing.Point(0, 418)
      Me.GBFooter.Margin = New System.Windows.Forms.Padding(5)
      Me.GBFooter.Size = New System.Drawing.Size(1160, 76)
      Me.GBFooter.TabIndex = 0
      '
      'GBBody
      '
      Me.GBBody.Controls.Add(Me.GroupBox1)
      Me.GBBody.Margin = New System.Windows.Forms.Padding(5)
      Me.GBBody.Size = New System.Drawing.Size(1160, 376)
      '
      'lblHeading
      '
      Me.lblHeading.Size = New System.Drawing.Size(1160, 42)
      Me.lblHeading.TabIndex = 0
      Me.lblHeading.Text = "Sale Order Expected Cost"
      '
      'GroupBox1
      '
      Me.GroupBox1.Controls.Add(Me.SplitContainer1)
      Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
      Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
      Me.GroupBox1.Name = "GroupBox1"
      Me.GroupBox1.Size = New System.Drawing.Size(1160, 376)
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
      Me.SplitContainer1.Panel1.Controls.Add(Me.lblTotalAmount)
      Me.SplitContainer1.Panel1.Controls.Add(Me.txtOtherCharges3)
      Me.SplitContainer1.Panel1.Controls.Add(Me.Label7)
      Me.SplitContainer1.Panel1.Controls.Add(Me.txtOtherCharges4)
      Me.SplitContainer1.Panel1.Controls.Add(Me.Label5)
      Me.SplitContainer1.Panel1.Controls.Add(Me.txtRemaeks)
      Me.SplitContainer1.Panel1.Controls.Add(Me.Label4)
      Me.SplitContainer1.Panel1.Controls.Add(Me.Label3)
      Me.SplitContainer1.Panel1.Controls.Add(Me.txtOtherCharges2)
      Me.SplitContainer1.Panel1.Controls.Add(Me.Label2)
      Me.SplitContainer1.Panel1.Controls.Add(Me.txtOtherCharges1)
      Me.SplitContainer1.Panel1.Controls.Add(Me.Label1)
      Me.SplitContainer1.Panel1.Controls.Add(Me.lblVNo)
      Me.SplitContainer1.Panel1.Controls.Add(Me.lblVID)
      Me.SplitContainer1.Panel1.Controls.Add(Me.txtVName)
      Me.SplitContainer1.Panel1.Controls.Add(Me.Label6)
      Me.SplitContainer1.Panel1.Controls.Add(Me.lblInformation)
      '
      'SplitContainer1.Panel2
      '
      Me.SplitContainer1.Panel2.Controls.Add(Me.grdRecord)
      Me.SplitContainer1.Size = New System.Drawing.Size(1154, 357)
      Me.SplitContainer1.SplitterDistance = 69
      Me.SplitContainer1.TabIndex = 0
      '
      'lblTotalAmount
      '
      Me.lblTotalAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
      Me.lblTotalAmount.Enabled = False
      Me.lblTotalAmount.ForeColor = System.Drawing.Color.Black
      Me.lblTotalAmount.Location = New System.Drawing.Point(988, 39)
      Me.lblTotalAmount.Name = "lblTotalAmount"
      Me.lblTotalAmount.Size = New System.Drawing.Size(155, 17)
      Me.lblTotalAmount.TabIndex = 32
      Me.lblTotalAmount.Text = "0"
      '
      'txtOtherCharges3
      '
      Me.txtOtherCharges3.Location = New System.Drawing.Point(894, 8)
      Me.txtOtherCharges3.Name = "txtOtherCharges3"
      Me.txtOtherCharges3.Size = New System.Drawing.Size(77, 20)
      Me.txtOtherCharges3.TabIndex = 30
      '
      'Label7
      '
      Me.Label7.AutoSize = True
      Me.Label7.ForeColor = System.Drawing.Color.Black
      Me.Label7.Location = New System.Drawing.Point(901, 41)
      Me.Label7.Name = "Label7"
      Me.Label7.Size = New System.Drawing.Size(70, 13)
      Me.Label7.TabIndex = 31
      Me.Label7.Text = "Total Amount"
      '
      'txtOtherCharges4
      '
      Me.txtOtherCharges4.Location = New System.Drawing.Point(1066, 8)
      Me.txtOtherCharges4.Name = "txtOtherCharges4"
      Me.txtOtherCharges4.Size = New System.Drawing.Size(77, 20)
      Me.txtOtherCharges4.TabIndex = 28
      '
      'Label5
      '
      Me.Label5.AutoSize = True
      Me.Label5.ForeColor = System.Drawing.Color.Black
      Me.Label5.Location = New System.Drawing.Point(985, 12)
      Me.Label5.Name = "Label5"
      Me.Label5.Size = New System.Drawing.Size(81, 13)
      Me.Label5.TabIndex = 29
      Me.Label5.Text = "Other Charges4"
      '
      'txtRemaeks
      '
      Me.txtRemaeks.Location = New System.Drawing.Point(124, 37)
      Me.txtRemaeks.Name = "txtRemaeks"
      Me.txtRemaeks.Size = New System.Drawing.Size(674, 20)
      Me.txtRemaeks.TabIndex = 26
      '
      'Label4
      '
      Me.Label4.AutoSize = True
      Me.Label4.ForeColor = System.Drawing.Color.Black
      Me.Label4.Location = New System.Drawing.Point(64, 41)
      Me.Label4.Name = "Label4"
      Me.Label4.Size = New System.Drawing.Size(49, 13)
      Me.Label4.TabIndex = 27
      Me.Label4.Text = "Remarks"
      '
      'Label3
      '
      Me.Label3.AutoSize = True
      Me.Label3.ForeColor = System.Drawing.Color.Black
      Me.Label3.Location = New System.Drawing.Point(813, 12)
      Me.Label3.Name = "Label3"
      Me.Label3.Size = New System.Drawing.Size(81, 13)
      Me.Label3.TabIndex = 25
      Me.Label3.Text = "Other Charges3"
      '
      'txtOtherCharges2
      '
      Me.txtOtherCharges2.Location = New System.Drawing.Point(721, 8)
      Me.txtOtherCharges2.Name = "txtOtherCharges2"
      Me.txtOtherCharges2.Size = New System.Drawing.Size(77, 20)
      Me.txtOtherCharges2.TabIndex = 22
      '
      'Label2
      '
      Me.Label2.AutoSize = True
      Me.Label2.ForeColor = System.Drawing.Color.Black
      Me.Label2.Location = New System.Drawing.Point(640, 12)
      Me.Label2.Name = "Label2"
      Me.Label2.Size = New System.Drawing.Size(81, 13)
      Me.Label2.TabIndex = 23
      Me.Label2.Text = "Other Charges2"
      '
      'txtOtherCharges1
      '
      Me.txtOtherCharges1.Location = New System.Drawing.Point(554, 8)
      Me.txtOtherCharges1.Name = "txtOtherCharges1"
      Me.txtOtherCharges1.Size = New System.Drawing.Size(77, 20)
      Me.txtOtherCharges1.TabIndex = 20
      '
      'Label1
      '
      Me.Label1.AutoSize = True
      Me.Label1.ForeColor = System.Drawing.Color.Black
      Me.Label1.Location = New System.Drawing.Point(473, 12)
      Me.Label1.Name = "Label1"
      Me.Label1.Size = New System.Drawing.Size(81, 13)
      Me.Label1.TabIndex = 21
      Me.Label1.Text = "Other Charges1"
      '
      'lblVNo
      '
      Me.lblVNo.AutoSize = True
      Me.lblVNo.ForeColor = System.Drawing.Color.Black
      Me.lblVNo.Location = New System.Drawing.Point(47, 12)
      Me.lblVNo.Name = "lblVNo"
      Me.lblVNo.Size = New System.Drawing.Size(10, 13)
      Me.lblVNo.TabIndex = 19
      Me.lblVNo.Text = "-"
      Me.lblVNo.Visible = False
      '
      'lblVID
      '
      Me.lblVID.AutoSize = True
      Me.lblVID.ForeColor = System.Drawing.Color.Black
      Me.lblVID.Location = New System.Drawing.Point(9, 12)
      Me.lblVID.Name = "lblVID"
      Me.lblVID.Size = New System.Drawing.Size(10, 13)
      Me.lblVID.TabIndex = 18
      Me.lblVID.Text = "-"
      Me.lblVID.Visible = False
      '
      'txtVName
      '
      Me.txtVName.Location = New System.Drawing.Point(124, 8)
      Me.txtVName.Name = "txtVName"
      Me.txtVName.Size = New System.Drawing.Size(342, 20)
      Me.txtVName.TabIndex = 0
      '
      'Label6
      '
      Me.Label6.AutoSize = True
      Me.Label6.ForeColor = System.Drawing.Color.Black
      Me.Label6.Location = New System.Drawing.Point(64, 12)
      Me.Label6.Name = "Label6"
      Me.Label6.Size = New System.Drawing.Size(57, 13)
      Me.Label6.TabIndex = 15
      Me.Label6.Text = "Sale Order"
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
      Me.grdRecord.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
      Me.grdRecord.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.VID, Me.AccessoryID, Me.OrderID, Me.ProductID, Me.UOMID, Me.Product, Me.Remarks, Me.VQuantity, Me.LastRate, Me.VRate, Me.Amount, Me.POQuantity, Me.PORate, Me.POAmount, Me.AmountDifference})
      Me.grdRecord.Dock = System.Windows.Forms.DockStyle.Fill
      Me.grdRecord.Location = New System.Drawing.Point(0, 0)
      Me.grdRecord.Name = "grdRecord"
      Me.grdRecord.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
      Me.grdRecord.Size = New System.Drawing.Size(1154, 284)
      Me.grdRecord.TabIndex = 0
      '
      'VID
      '
      Me.VID.DataPropertyName = "VID"
      Me.VID.HeaderText = "VID"
      Me.VID.Name = "VID"
      Me.VID.Visible = False
      '
      'AccessoryID
      '
      Me.AccessoryID.DataPropertyName = "AccessoryID"
      Me.AccessoryID.HeaderText = "AccessoryID"
      Me.AccessoryID.Name = "AccessoryID"
      Me.AccessoryID.ReadOnly = True
      Me.AccessoryID.Visible = False
      '
      'OrderID
      '
      Me.OrderID.DataPropertyName = "OrderID"
      Me.OrderID.HeaderText = "OrderID"
      Me.OrderID.Name = "OrderID"
      Me.OrderID.ReadOnly = True
      Me.OrderID.Visible = False
      '
      'ProductID
      '
      Me.ProductID.DataPropertyName = "ProductID"
      Me.ProductID.HeaderText = "ProductID"
      Me.ProductID.Name = "ProductID"
      Me.ProductID.ReadOnly = True
      Me.ProductID.Visible = False
      Me.ProductID.Width = 400
      '
      'UOMID
      '
      Me.UOMID.DataPropertyName = "UOMID"
      Me.UOMID.HeaderText = "UOMID"
      Me.UOMID.Name = "UOMID"
      Me.UOMID.ReadOnly = True
      Me.UOMID.Visible = False
      '
      'Product
      '
      Me.Product.DataPropertyName = "Product"
      DataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver
      Me.Product.DefaultCellStyle = DataGridViewCellStyle1
      Me.Product.HeaderText = "Product"
      Me.Product.Name = "Product"
      Me.Product.ReadOnly = True
      Me.Product.Width = 300
      '
      'Remarks
      '
      Me.Remarks.DataPropertyName = "Remarks"
      Me.Remarks.HeaderText = "Remarks"
      Me.Remarks.Name = "Remarks"
      Me.Remarks.ReadOnly = True
      Me.Remarks.Visible = False
      Me.Remarks.Width = 200
      '
      'VQuantity
      '
      DataGridViewCellStyle2.BackColor = System.Drawing.Color.Silver
      Me.VQuantity.DefaultCellStyle = DataGridViewCellStyle2
      Me.VQuantity.HeaderText = "Qty"
      Me.VQuantity.Name = "VQuantity"
      Me.VQuantity.ReadOnly = True
      '
      'LastRate
      '
      DataGridViewCellStyle3.BackColor = System.Drawing.Color.Silver
      Me.LastRate.DefaultCellStyle = DataGridViewCellStyle3
      Me.LastRate.HeaderText = "Last Rate"
      Me.LastRate.Name = "LastRate"
      Me.LastRate.ReadOnly = True
      '
      'VRate
      '
      Me.VRate.DataPropertyName = "VRate"
      Me.VRate.HeaderText = "Rate"
      Me.VRate.Name = "VRate"
      '
      'Amount
      '
      DataGridViewCellStyle4.BackColor = System.Drawing.Color.Silver
      Me.Amount.DefaultCellStyle = DataGridViewCellStyle4
      Me.Amount.HeaderText = "Expected"
      Me.Amount.Name = "Amount"
      Me.Amount.ReadOnly = True
      '
      'POQuantity
      '
      DataGridViewCellStyle5.BackColor = System.Drawing.Color.LightGreen
      Me.POQuantity.DefaultCellStyle = DataGridViewCellStyle5
      Me.POQuantity.HeaderText = "PO Qty"
      Me.POQuantity.Name = "POQuantity"
      Me.POQuantity.ReadOnly = True
      '
      'PORate
      '
      DataGridViewCellStyle6.BackColor = System.Drawing.Color.LightGreen
      Me.PORate.DefaultCellStyle = DataGridViewCellStyle6
      Me.PORate.HeaderText = "PO Rate"
      Me.PORate.Name = "PORate"
      Me.PORate.ReadOnly = True
      '
      'POAmount
      '
      DataGridViewCellStyle7.BackColor = System.Drawing.Color.LightGreen
      Me.POAmount.DefaultCellStyle = DataGridViewCellStyle7
      Me.POAmount.HeaderText = "PO Amount"
      Me.POAmount.Name = "POAmount"
      Me.POAmount.ReadOnly = True
      '
      'AmountDifference
      '
      DataGridViewCellStyle8.BackColor = System.Drawing.Color.LightGreen
      Me.AmountDifference.DefaultCellStyle = DataGridViewCellStyle8
      Me.AmountDifference.HeaderText = "Difference"
      Me.AmountDifference.Name = "AmountDifference"
      Me.AmountDifference.ReadOnly = True
      '
      'ProdSaleOrderExpectedCost
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.ClientSize = New System.Drawing.Size(1160, 494)
      Me.Margin = New System.Windows.Forms.Padding(5)
      Me.Name = "ProdSaleOrderExpectedCost"
      Me.Text = "Sale Orde rExpected Cost"
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
   Friend WithEvents txtVName As TextBox
   Friend WithEvents lblVNo As System.Windows.Forms.Label
   Friend WithEvents lblVID As System.Windows.Forms.Label
   Friend WithEvents txtOtherCharges3 As System.Windows.Forms.TextBox
   Friend WithEvents Label7 As System.Windows.Forms.Label
   Friend WithEvents txtOtherCharges4 As System.Windows.Forms.TextBox
   Friend WithEvents Label5 As System.Windows.Forms.Label
   Friend WithEvents txtRemaeks As System.Windows.Forms.TextBox
   Friend WithEvents Label4 As System.Windows.Forms.Label
   Friend WithEvents Label3 As System.Windows.Forms.Label
   Friend WithEvents txtOtherCharges2 As System.Windows.Forms.TextBox
   Friend WithEvents Label2 As System.Windows.Forms.Label
   Friend WithEvents txtOtherCharges1 As System.Windows.Forms.TextBox
   Friend WithEvents Label1 As System.Windows.Forms.Label
   Friend WithEvents lblTotalAmount As System.Windows.Forms.Label
   Friend WithEvents VID As System.Windows.Forms.DataGridViewTextBoxColumn
   Friend WithEvents AccessoryID As System.Windows.Forms.DataGridViewTextBoxColumn
   Friend WithEvents OrderID As System.Windows.Forms.DataGridViewTextBoxColumn
   Friend WithEvents ProductID As System.Windows.Forms.DataGridViewTextBoxColumn
   Friend WithEvents UOMID As System.Windows.Forms.DataGridViewTextBoxColumn
   Friend WithEvents Product As System.Windows.Forms.DataGridViewTextBoxColumn
   Friend WithEvents Remarks As System.Windows.Forms.DataGridViewTextBoxColumn
   Friend WithEvents VQuantity As System.Windows.Forms.DataGridViewTextBoxColumn
   Friend WithEvents LastRate As System.Windows.Forms.DataGridViewTextBoxColumn
   Friend WithEvents VRate As System.Windows.Forms.DataGridViewTextBoxColumn
   Friend WithEvents Amount As System.Windows.Forms.DataGridViewTextBoxColumn
   Friend WithEvents POQuantity As System.Windows.Forms.DataGridViewTextBoxColumn
   Friend WithEvents PORate As System.Windows.Forms.DataGridViewTextBoxColumn
   Friend WithEvents POAmount As System.Windows.Forms.DataGridViewTextBoxColumn
   Friend WithEvents AmountDifference As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
