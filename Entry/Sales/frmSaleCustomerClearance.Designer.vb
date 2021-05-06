<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSaleCustomerClearance
    Inherits WinBaseForms.GUIBaseFormA

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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtExchangeRate = New System.Windows.Forms.TextBox()
        Me.cmbCurrency = New System.Windows.Forms.ComboBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.lblTotalAmountTotal = New System.Windows.Forms.Label()
        Me.lblAdjustedAmountTotal = New System.Windows.Forms.Label()
        Me.lblExtraTotal = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtChequeNo = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cmbDocument = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cmbDocType = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmbBank = New System.Windows.Forms.ComboBox()
        Me.dtpVDate = New System.Windows.Forms.DateTimePicker()
        Me.dtpChequeDate = New System.Windows.Forms.DateTimePicker()
        Me.cmbCustomer = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtAmount = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtVCode = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNarration = New System.Windows.Forms.TextBox()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblVID = New System.Windows.Forms.Label()
        Me.grdRecord = New System.Windows.Forms.DataGridView()
        Me.VID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PurchaseOrderID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SupplierID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IGPID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GRNID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PONO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VType = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VoucherNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GRNAmount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CollectedAmount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PendingAmount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DetDiscount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DetExtra = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DetAmount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WHTaxPer = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WHTaxAmount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalAmount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DetInstructions = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grdGL = New System.Windows.Forms.DataGridView()
        Me.grdAtt = New System.Windows.Forms.DataGridView()
        Me.dtFDateFrom = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtFRemarks = New System.Windows.Forms.TextBox()
        Me.txtFVNo = New System.Windows.Forms.TextBox()
        Me.dtFDateTo = New System.Windows.Forms.DateTimePicker()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.TabMain.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.GBHeading.SuspendLayout()
        Me.GBFooter.SuspendLayout()
        Me.GBBody.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        CType(Me.grdRecord, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdGL, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdAtt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabMain
        '
        Me.TabMain.Size = New System.Drawing.Size(927, 523)
        '
        'TabPage1
        '
        Me.TabPage1.Size = New System.Drawing.Size(919, 497)
        '
        'GBHeading
        '
        Me.GBHeading.Margin = New System.Windows.Forms.Padding(2)
        Me.GBHeading.Size = New System.Drawing.Size(913, 42)
        '
        'lblHeading
        '
        Me.lblHeading.Size = New System.Drawing.Size(913, 42)
        Me.lblHeading.TabIndex = 0
        Me.lblHeading.Text = "Customer Clearance"
        '
        'GBFooter
        '
        Me.GBFooter.Margin = New System.Windows.Forms.Padding(2)
        Me.GBFooter.Size = New System.Drawing.Size(913, 70)
        Me.GBFooter.TabIndex = 0
        '
        'cmdClose
        '
        Me.cmdClose.Location = New System.Drawing.Point(498, 7)
        Me.cmdClose.TabIndex = 3
        '
        'cmdNew
        '
        Me.cmdNew.TabIndex = 1
        '
        'cmdDelete
        '
        Me.cmdDelete.Location = New System.Drawing.Point(234, 7)
        Me.cmdDelete.TabIndex = 0
        Me.cmdDelete.Visible = False
        '
        'cmdSave
        '
        Me.cmdSave.TabIndex = 2
        '
        'GBBody
        '
        Me.GBBody.Controls.Add(Me.SplitContainer2)
        Me.GBBody.Margin = New System.Windows.Forms.Padding(2)
        Me.GBBody.Size = New System.Drawing.Size(913, 379)
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Margin = New System.Windows.Forms.Padding(2)
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnSearch)
        Me.SplitContainer1.Panel1.Controls.Add(Me.dtFDateTo)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label16)
        Me.SplitContainer1.Panel1.Controls.Add(Me.dtFDateFrom)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label8)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label14)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label15)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtFRemarks)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtFVNo)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.grdAtt)
        Me.SplitContainer1.SplitterDistance = 85
        Me.SplitContainer1.SplitterWidth = 3
        '
        'cmdPrint
        '
        Me.cmdPrint.Location = New System.Drawing.Point(581, 6)
        Me.cmdPrint.TabIndex = 4
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        Me.SplitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.Label17)
        Me.SplitContainer2.Panel1.Controls.Add(Me.txtExchangeRate)
        Me.SplitContainer2.Panel1.Controls.Add(Me.cmbCurrency)
        Me.SplitContainer2.Panel1.Controls.Add(Me.Label18)
        Me.SplitContainer2.Panel1.Controls.Add(Me.lblTotalAmountTotal)
        Me.SplitContainer2.Panel1.Controls.Add(Me.lblAdjustedAmountTotal)
        Me.SplitContainer2.Panel1.Controls.Add(Me.lblExtraTotal)
        Me.SplitContainer2.Panel1.Controls.Add(Me.Label12)
        Me.SplitContainer2.Panel1.Controls.Add(Me.txtChequeNo)
        Me.SplitContainer2.Panel1.Controls.Add(Me.Label10)
        Me.SplitContainer2.Panel1.Controls.Add(Me.cmbDocument)
        Me.SplitContainer2.Panel1.Controls.Add(Me.Label9)
        Me.SplitContainer2.Panel1.Controls.Add(Me.cmbDocType)
        Me.SplitContainer2.Panel1.Controls.Add(Me.Label11)
        Me.SplitContainer2.Panel1.Controls.Add(Me.Label7)
        Me.SplitContainer2.Panel1.Controls.Add(Me.Label6)
        Me.SplitContainer2.Panel1.Controls.Add(Me.Label5)
        Me.SplitContainer2.Panel1.Controls.Add(Me.cmbBank)
        Me.SplitContainer2.Panel1.Controls.Add(Me.dtpVDate)
        Me.SplitContainer2.Panel1.Controls.Add(Me.dtpChequeDate)
        Me.SplitContainer2.Panel1.Controls.Add(Me.cmbCustomer)
        Me.SplitContainer2.Panel1.Controls.Add(Me.Label2)
        Me.SplitContainer2.Panel1.Controls.Add(Me.txtAmount)
        Me.SplitContainer2.Panel1.Controls.Add(Me.Label1)
        Me.SplitContainer2.Panel1.Controls.Add(Me.txtVCode)
        Me.SplitContainer2.Panel1.Controls.Add(Me.Label3)
        Me.SplitContainer2.Panel1.Controls.Add(Me.txtNarration)
        Me.SplitContainer2.Panel1.Controls.Add(Me.txtID)
        Me.SplitContainer2.Panel1.Controls.Add(Me.Label4)
        Me.SplitContainer2.Panel1.Controls.Add(Me.lblVID)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.grdRecord)
        Me.SplitContainer2.Size = New System.Drawing.Size(913, 379)
        Me.SplitContainer2.SplitterDistance = 122
        Me.SplitContainer2.TabIndex = 0
        Me.SplitContainer2.TabStop = False
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.ForeColor = System.Drawing.Color.Black
        Me.Label17.Location = New System.Drawing.Point(480, 71)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(48, 13)
        Me.Label17.TabIndex = 90
        Me.Label17.Text = "Ex Rate:"
        '
        'txtExchangeRate
        '
        Me.txtExchangeRate.Location = New System.Drawing.Point(528, 68)
        Me.txtExchangeRate.MaxLength = 50
        Me.txtExchangeRate.Name = "txtExchangeRate"
        Me.txtExchangeRate.Size = New System.Drawing.Size(182, 20)
        Me.txtExchangeRate.TabIndex = 89
        '
        'cmbCurrency
        '
        Me.cmbCurrency.FormattingEnabled = True
        Me.cmbCurrency.Location = New System.Drawing.Point(319, 67)
        Me.cmbCurrency.Name = "cmbCurrency"
        Me.cmbCurrency.Size = New System.Drawing.Size(136, 21)
        Me.cmbCurrency.TabIndex = 88
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.ForeColor = System.Drawing.Color.Black
        Me.Label18.Location = New System.Drawing.Point(267, 71)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(52, 13)
        Me.Label18.TabIndex = 87
        Me.Label18.Text = "Currency:"
        '
        'lblTotalAmountTotal
        '
        Me.lblTotalAmountTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotalAmountTotal.Enabled = False
        Me.lblTotalAmountTotal.ForeColor = System.Drawing.Color.Black
        Me.lblTotalAmountTotal.Location = New System.Drawing.Point(830, 94)
        Me.lblTotalAmountTotal.Name = "lblTotalAmountTotal"
        Me.lblTotalAmountTotal.Size = New System.Drawing.Size(65, 18)
        Me.lblTotalAmountTotal.TabIndex = 61
        Me.lblTotalAmountTotal.Text = "0"
        '
        'lblAdjustedAmountTotal
        '
        Me.lblAdjustedAmountTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAdjustedAmountTotal.Enabled = False
        Me.lblAdjustedAmountTotal.ForeColor = System.Drawing.Color.Black
        Me.lblAdjustedAmountTotal.Location = New System.Drawing.Point(759, 95)
        Me.lblAdjustedAmountTotal.Name = "lblAdjustedAmountTotal"
        Me.lblAdjustedAmountTotal.Size = New System.Drawing.Size(65, 18)
        Me.lblAdjustedAmountTotal.TabIndex = 60
        Me.lblAdjustedAmountTotal.Text = "0"
        '
        'lblExtraTotal
        '
        Me.lblExtraTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblExtraTotal.Enabled = False
        Me.lblExtraTotal.ForeColor = System.Drawing.Color.Black
        Me.lblExtraTotal.Location = New System.Drawing.Point(688, 95)
        Me.lblExtraTotal.Name = "lblExtraTotal"
        Me.lblExtraTotal.Size = New System.Drawing.Size(65, 18)
        Me.lblExtraTotal.TabIndex = 59
        Me.lblExtraTotal.Text = "0"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(714, 41)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(64, 13)
        Me.Label12.TabIndex = 58
        Me.Label12.Text = "Cheque No:"
        '
        'txtChequeNo
        '
        Me.txtChequeNo.Location = New System.Drawing.Point(784, 37)
        Me.txtChequeNo.MaxLength = 50
        Me.txtChequeNo.Name = "txtChequeNo"
        Me.txtChequeNo.Size = New System.Drawing.Size(102, 20)
        Me.txtChequeNo.TabIndex = 7
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(260, 41)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(59, 13)
        Me.Label10.TabIndex = 56
        Me.Label10.Text = "Document:"
        '
        'cmbDocument
        '
        Me.cmbDocument.FormattingEnabled = True
        Me.cmbDocument.Location = New System.Drawing.Point(319, 37)
        Me.cmbDocument.Name = "cmbDocument"
        Me.cmbDocument.Size = New System.Drawing.Size(136, 21)
        Me.cmbDocument.TabIndex = 5
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(18, 40)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(86, 13)
        Me.Label9.TabIndex = 54
        Me.Label9.Text = "Document Type:"
        '
        'cmbDocType
        '
        Me.cmbDocType.FormattingEnabled = True
        Me.cmbDocType.Items.AddRange(New Object() {" "})
        Me.cmbDocType.Location = New System.Drawing.Point(104, 37)
        Me.cmbDocType.Name = "cmbDocType"
        Me.cmbDocType.Size = New System.Drawing.Size(129, 21)
        Me.cmbDocType.TabIndex = 4
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(887, 11)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(15, 20)
        Me.Label11.TabIndex = 52
        Me.Label11.Text = "*"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(51, 97)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(53, 13)
        Me.Label7.TabIndex = 38
        Me.Label7.Text = "Narration:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(732, 70)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(46, 13)
        Me.Label6.TabIndex = 37
        Me.Label6.Text = "Amount:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(493, 41)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(35, 13)
        Me.Label5.TabIndex = 36
        Me.Label5.Text = "Bank:"
        '
        'cmbBank
        '
        Me.cmbBank.FormattingEnabled = True
        Me.cmbBank.Location = New System.Drawing.Point(528, 37)
        Me.cmbBank.Name = "cmbBank"
        Me.cmbBank.Size = New System.Drawing.Size(182, 21)
        Me.cmbBank.TabIndex = 6
        '
        'dtpVDate
        '
        Me.dtpVDate.CustomFormat = "dd/MM/yyyy"
        Me.dtpVDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpVDate.Location = New System.Drawing.Point(319, 7)
        Me.dtpVDate.Name = "dtpVDate"
        Me.dtpVDate.Size = New System.Drawing.Size(136, 20)
        Me.dtpVDate.TabIndex = 1
        '
        'dtpChequeDate
        '
        Me.dtpChequeDate.CustomFormat = "dd/MM/yyyy"
        Me.dtpChequeDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpChequeDate.Location = New System.Drawing.Point(104, 68)
        Me.dtpChequeDate.Name = "dtpChequeDate"
        Me.dtpChequeDate.Size = New System.Drawing.Size(129, 20)
        Me.dtpChequeDate.TabIndex = 3
        '
        'cmbCustomer
        '
        Me.cmbCustomer.FormattingEnabled = True
        Me.cmbCustomer.Location = New System.Drawing.Point(528, 7)
        Me.cmbCustomer.Name = "cmbCustomer"
        Me.cmbCustomer.Size = New System.Drawing.Size(358, 21)
        Me.cmbCustomer.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(474, 10)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 13)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "Customer:"
        '
        'txtAmount
        '
        Me.txtAmount.Location = New System.Drawing.Point(784, 68)
        Me.txtAmount.MaxLength = 50
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(102, 20)
        Me.txtAmount.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(31, 72)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 13)
        Me.Label1.TabIndex = 31
        Me.Label1.Text = "Cheque Date:"
        '
        'txtVCode
        '
        Me.txtVCode.Location = New System.Drawing.Point(104, 7)
        Me.txtVCode.Name = "txtVCode"
        Me.txtVCode.Size = New System.Drawing.Size(129, 20)
        Me.txtVCode.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(36, 11)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 13)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "Reciept No:"
        '
        'txtNarration
        '
        Me.txtNarration.Location = New System.Drawing.Point(104, 95)
        Me.txtNarration.MaxLength = 50
        Me.txtNarration.Name = "txtNarration"
        Me.txtNarration.Size = New System.Drawing.Size(574, 20)
        Me.txtNarration.TabIndex = 8
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(0, 0)
        Me.txtID.Name = "txtID"
        Me.txtID.ReadOnly = True
        Me.txtID.Size = New System.Drawing.Size(62, 20)
        Me.txtID.TabIndex = 28
        Me.txtID.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(246, 10)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 13)
        Me.Label4.TabIndex = 30
        Me.Label4.Text = "Reciept Date:"
        '
        'lblVID
        '
        Me.lblVID.AutoSize = True
        Me.lblVID.Location = New System.Drawing.Point(5, 23)
        Me.lblVID.Name = "lblVID"
        Me.lblVID.Size = New System.Drawing.Size(25, 13)
        Me.lblVID.TabIndex = 0
        Me.lblVID.Text = "VID"
        Me.lblVID.Visible = False
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
        Me.grdRecord.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.VID, Me.PurchaseOrderID, Me.SupplierID, Me.IGPID, Me.GRNID, Me.PONO, Me.VType, Me.VoucherNo, Me.GRNAmount, Me.CollectedAmount, Me.PendingAmount, Me.DetDiscount, Me.DetExtra, Me.DetAmount, Me.WHTaxPer, Me.WHTaxAmount, Me.TotalAmount, Me.DetInstructions})
        Me.grdRecord.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdRecord.Location = New System.Drawing.Point(0, 0)
        Me.grdRecord.Name = "grdRecord"
        Me.grdRecord.RowHeadersVisible = False
        Me.grdRecord.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.grdRecord.Size = New System.Drawing.Size(913, 253)
        Me.grdRecord.TabIndex = 1
        '
        'VID
        '
        Me.VID.DataPropertyName = "VID"
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
        Me.PONO.HeaderText = "PONO"
        Me.PONO.Name = "PONO"
        Me.PONO.ReadOnly = True
        Me.PONO.Visible = False
        '
        'VType
        '
        Me.VType.DataPropertyName = "VType"
        Me.VType.HeaderText = "Voucher Type"
        Me.VType.Name = "VType"
        Me.VType.ReadOnly = True
        Me.VType.Width = 80
        '
        'VoucherNo
        '
        Me.VoucherNo.DataPropertyName = "VoucherNo"
        Me.VoucherNo.HeaderText = "Voucher No"
        Me.VoucherNo.Name = "VoucherNo"
        Me.VoucherNo.ReadOnly = True
        Me.VoucherNo.Width = 200
        '
        'GRNAmount
        '
        Me.GRNAmount.DataPropertyName = "GRNAmount"
        Me.GRNAmount.HeaderText = "Amount"
        Me.GRNAmount.Name = "GRNAmount"
        Me.GRNAmount.ReadOnly = True
        Me.GRNAmount.Width = 80
        '
        'CollectedAmount
        '
        Me.CollectedAmount.DataPropertyName = "CollectedAmount"
        Me.CollectedAmount.HeaderText = "Collected Amount"
        Me.CollectedAmount.Name = "CollectedAmount"
        Me.CollectedAmount.ReadOnly = True
        Me.CollectedAmount.Width = 80
        '
        'PendingAmount
        '
        Me.PendingAmount.DataPropertyName = "PendingAmount"
        Me.PendingAmount.HeaderText = "Pending Amount"
        Me.PendingAmount.Name = "PendingAmount"
        Me.PendingAmount.ReadOnly = True
        Me.PendingAmount.Width = 80
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
        Me.DetDiscount.Width = 80
        '
        'DetExtra
        '
        Me.DetExtra.DataPropertyName = "DetExtra"
        DataGridViewCellStyle3.Format = "N2"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.DetExtra.DefaultCellStyle = DataGridViewCellStyle3
        Me.DetExtra.HeaderText = "Extra"
        Me.DetExtra.Name = "DetExtra"
        Me.DetExtra.Width = 80
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
        'WHTaxPer
        '
        Me.WHTaxPer.DataPropertyName = "WHTaxPer"
        Me.WHTaxPer.HeaderText = "W.H.Tax"
        Me.WHTaxPer.Name = "WHTaxPer"
        Me.WHTaxPer.Width = 70
        '
        'WHTaxAmount
        '
        Me.WHTaxAmount.DataPropertyName = "WHTaxAmount"
        Me.WHTaxAmount.HeaderText = "Tax Amount"
        Me.WHTaxAmount.Name = "WHTaxAmount"
        Me.WHTaxAmount.ReadOnly = True
        Me.WHTaxAmount.Width = 70
        '
        'TotalAmount
        '
        Me.TotalAmount.DataPropertyName = "TotalAmount"
        Me.TotalAmount.HeaderText = "Total Amount"
        Me.TotalAmount.Name = "TotalAmount"
        Me.TotalAmount.ReadOnly = True
        '
        'DetInstructions
        '
        Me.DetInstructions.DataPropertyName = "DetInstructions"
        Me.DetInstructions.HeaderText = "Remarks"
        Me.DetInstructions.Name = "DetInstructions"
        Me.DetInstructions.Visible = False
        '
        'grdGL
        '
        Me.grdGL.AllowUserToAddRows = False
        Me.grdGL.AllowUserToDeleteRows = False
        Me.grdGL.AllowUserToOrderColumns = True
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.grdGL.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle6
        Me.grdGL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdGL.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdGL.Location = New System.Drawing.Point(0, 0)
        Me.grdGL.Name = "grdGL"
        Me.grdGL.ReadOnly = True
        Me.grdGL.RowHeadersVisible = False
        Me.grdGL.Size = New System.Drawing.Size(953, 401)
        Me.grdGL.TabIndex = 3
        '
        'grdAtt
        '
        Me.grdAtt.AllowUserToAddRows = False
        Me.grdAtt.AllowUserToDeleteRows = False
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.grdAtt.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle5
        Me.grdAtt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdAtt.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdAtt.Location = New System.Drawing.Point(0, 0)
        Me.grdAtt.Name = "grdAtt"
        Me.grdAtt.RowHeadersVisible = False
        Me.grdAtt.Size = New System.Drawing.Size(953, 403)
        Me.grdAtt.TabIndex = 0
        '
        'dtFDateFrom
        '
        Me.dtFDateFrom.CustomFormat = "dd/MM/yyyy"
        Me.dtFDateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtFDateFrom.Location = New System.Drawing.Point(417, 11)
        Me.dtFDateFrom.Name = "dtFDateFrom"
        Me.dtFDateFrom.Size = New System.Drawing.Size(104, 20)
        Me.dtFDateFrom.TabIndex = 5
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(14, 44)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(63, 13)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Remarks:"
        '
        'Label14
        '
        Me.Label14.Location = New System.Drawing.Point(344, 15)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(67, 13)
        Me.Label14.TabIndex = 4
        Me.Label14.Text = "Date From:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(14, 11)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(64, 13)
        Me.Label15.TabIndex = 0
        Me.Label15.Text = "Receipt No:"
        '
        'txtFRemarks
        '
        Me.txtFRemarks.Location = New System.Drawing.Point(83, 39)
        Me.txtFRemarks.Name = "txtFRemarks"
        Me.txtFRemarks.Size = New System.Drawing.Size(634, 20)
        Me.txtFRemarks.TabIndex = 9
        '
        'txtFVNo
        '
        Me.txtFVNo.Location = New System.Drawing.Point(83, 11)
        Me.txtFVNo.Name = "txtFVNo"
        Me.txtFVNo.Size = New System.Drawing.Size(225, 20)
        Me.txtFVNo.TabIndex = 1
        '
        'dtFDateTo
        '
        Me.dtFDateTo.CustomFormat = "dd/MM/yyyy"
        Me.dtFDateTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtFDateTo.Location = New System.Drawing.Point(613, 10)
        Me.dtFDateTo.Name = "dtFDateTo"
        Me.dtFDateTo.Size = New System.Drawing.Size(104, 20)
        Me.dtFDateTo.TabIndex = 7
        '
        'Label16
        '
        Me.Label16.Location = New System.Drawing.Point(540, 14)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(67, 13)
        Me.Label16.TabIndex = 6
        Me.Label16.Text = "Date To:"
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(746, 39)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(75, 23)
        Me.btnSearch.TabIndex = 10
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'frmSaleCustomerClearance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(927, 523)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmSaleCustomerClearance"
        Me.Text = "Customer Clearance"
        Me.TabMain.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.GBHeading.ResumeLayout(False)
        Me.GBFooter.ResumeLayout(False)
        Me.GBBody.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.PerformLayout()
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        CType(Me.grdRecord, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdGL, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdAtt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents lblVID As System.Windows.Forms.Label
    Friend WithEvents grdGL As System.Windows.Forms.DataGridView
    Friend WithEvents grdAtt As System.Windows.Forms.DataGridView
    Friend WithEvents dtFDateTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents dtFDateFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtFRemarks As System.Windows.Forms.TextBox
    Friend WithEvents txtFVNo As System.Windows.Forms.TextBox
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents grdRecord As System.Windows.Forms.DataGridView
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cmbBank As System.Windows.Forms.ComboBox
    Friend WithEvents dtpVDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpChequeDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmbCustomer As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtAmount As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtVCode As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtNarration As System.Windows.Forms.TextBox
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents txtChequeNo As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents cmbDocument As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents cmbDocType As ComboBox
    Friend WithEvents lblTotalAmountTotal As Label
    Friend WithEvents lblAdjustedAmountTotal As Label
    Friend WithEvents lblExtraTotal As Label
    Friend WithEvents VID As DataGridViewTextBoxColumn
    Friend WithEvents PurchaseOrderID As DataGridViewTextBoxColumn
    Friend WithEvents SupplierID As DataGridViewTextBoxColumn
    Friend WithEvents IGPID As DataGridViewTextBoxColumn
    Friend WithEvents GRNID As DataGridViewTextBoxColumn
    Friend WithEvents PONO As DataGridViewTextBoxColumn
    Friend WithEvents VType As DataGridViewTextBoxColumn
    Friend WithEvents VoucherNo As DataGridViewTextBoxColumn
    Friend WithEvents GRNAmount As DataGridViewTextBoxColumn
    Friend WithEvents CollectedAmount As DataGridViewTextBoxColumn
    Friend WithEvents PendingAmount As DataGridViewTextBoxColumn
    Friend WithEvents DetDiscount As DataGridViewTextBoxColumn
    Friend WithEvents DetExtra As DataGridViewTextBoxColumn
    Friend WithEvents DetAmount As DataGridViewTextBoxColumn
    Friend WithEvents WHTaxPer As DataGridViewTextBoxColumn
    Friend WithEvents WHTaxAmount As DataGridViewTextBoxColumn
    Friend WithEvents TotalAmount As DataGridViewTextBoxColumn
    Friend WithEvents DetInstructions As DataGridViewTextBoxColumn
    Friend WithEvents Label17 As Label
    Friend WithEvents txtExchangeRate As TextBox
    Friend WithEvents cmbCurrency As ComboBox
    Friend WithEvents Label18 As Label
End Class
