﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmACCPVCSimpleMultiCurrency
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
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.hfIsPosted = New System.Windows.Forms.CheckBox()
        Me.cmbAccMainHead = New System.Windows.Forms.ComboBox()
        Me.chkCancel = New System.Windows.Forms.CheckBox()
        Me.dtpCancelDate = New System.Windows.Forms.DateTimePicker()
        Me.lblAcctID = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.lblVID = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblCurrencyID = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cmbCurrency = New System.Windows.Forms.ComboBox()
        Me.cmbAccountHead = New System.Windows.Forms.ComboBox()
        Me.cmbAccType = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblInfo = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.lblAccountTitle = New System.Windows.Forms.Label()
        Me.txtAmount = New System.Windows.Forms.TextBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtNarration = New System.Windows.Forms.TextBox()
        Me.txtRefNo = New System.Windows.Forms.TextBox()
        Me.dtpDate = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtRemarks = New System.Windows.Forms.TextBox()
        Me.txtVNo = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.lblDebitSum = New System.Windows.Forms.Label()
        Me.lblCreditSum = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.grdGL = New System.Windows.Forms.DataGridView()
        Me.grdAtt = New System.Windows.Forms.DataGridView()
        Me.dtFDateFrom = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtFRemarks = New System.Windows.Forms.TextBox()
        Me.cmbFVtype = New System.Windows.Forms.ComboBox()
        Me.txtFVNo = New System.Windows.Forms.TextBox()
        Me.dtFDateTo = New System.Windows.Forms.DateTimePicker()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.VID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AccountID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AccountTypeID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AccountTypeTitle = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VCode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AccountHead = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Narration = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CurrencyID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Currency = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Debit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ExRate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ExAmount = New System.Windows.Forms.DataGridViewTextBoxColumn()
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
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdGL, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdAtt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GBHeading
        '
        Me.GBHeading.Margin = New System.Windows.Forms.Padding(2)
        '
        'lblHeading
        '
        Me.lblHeading.TabIndex = 0
        Me.lblHeading.Text = "Cash Payment Voucher Simple"
        '
        'GBFooter
        '
        Me.GBFooter.Controls.Add(Me.Label12)
        Me.GBFooter.Controls.Add(Me.Label11)
        Me.GBFooter.Controls.Add(Me.lblCreditSum)
        Me.GBFooter.Controls.Add(Me.lblDebitSum)
        Me.GBFooter.Margin = New System.Windows.Forms.Padding(2)
        Me.GBFooter.TabIndex = 0
        Me.GBFooter.Controls.SetChildIndex(Me.cmdPrint, 0)
        Me.GBFooter.Controls.SetChildIndex(Me.cmdClose, 0)
        Me.GBFooter.Controls.SetChildIndex(Me.cmdNew, 0)
        Me.GBFooter.Controls.SetChildIndex(Me.cmdSave, 0)
        Me.GBFooter.Controls.SetChildIndex(Me.cmdDelete, 0)
        Me.GBFooter.Controls.SetChildIndex(Me.lblDebitSum, 0)
        Me.GBFooter.Controls.SetChildIndex(Me.lblCreditSum, 0)
        Me.GBFooter.Controls.SetChildIndex(Me.Label11, 0)
        Me.GBFooter.Controls.SetChildIndex(Me.Label12, 0)
        '
        'cmdClose
        '
        Me.cmdClose.TabIndex = 3
        '
        'cmdNew
        '
        Me.cmdNew.TabIndex = 0
        '
        'cmdDelete
        '
        Me.cmdDelete.TabIndex = 2
        '
        'cmdSave
        '
        Me.cmdSave.TabIndex = 1
        '
        'GBBody
        '
        Me.GBBody.Controls.Add(Me.SplitContainer2)
        Me.GBBody.Margin = New System.Windows.Forms.Padding(2)
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
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label13)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label14)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label15)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtFRemarks)
        Me.SplitContainer1.Panel1.Controls.Add(Me.cmbFVtype)
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
        Me.SplitContainer2.Panel1.Controls.Add(Me.hfIsPosted)
        Me.SplitContainer2.Panel1.Controls.Add(Me.cmbAccMainHead)
        Me.SplitContainer2.Panel1.Controls.Add(Me.chkCancel)
        Me.SplitContainer2.Panel1.Controls.Add(Me.dtpCancelDate)
        Me.SplitContainer2.Panel1.Controls.Add(Me.lblAcctID)
        Me.SplitContainer2.Panel1.Controls.Add(Me.Label19)
        Me.SplitContainer2.Panel1.Controls.Add(Me.lblVID)
        Me.SplitContainer2.Panel1.Controls.Add(Me.Label17)
        Me.SplitContainer2.Panel1.Controls.Add(Me.GroupBox1)
        Me.SplitContainer2.Panel1.Controls.Add(Me.txtRefNo)
        Me.SplitContainer2.Panel1.Controls.Add(Me.dtpDate)
        Me.SplitContainer2.Panel1.Controls.Add(Me.Label5)
        Me.SplitContainer2.Panel1.Controls.Add(Me.Label3)
        Me.SplitContainer2.Panel1.Controls.Add(Me.Label2)
        Me.SplitContainer2.Panel1.Controls.Add(Me.Label1)
        Me.SplitContainer2.Panel1.Controls.Add(Me.txtRemarks)
        Me.SplitContainer2.Panel1.Controls.Add(Me.txtVNo)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.DataGridView1)
        Me.SplitContainer2.Size = New System.Drawing.Size(953, 379)
        Me.SplitContainer2.SplitterDistance = 124
        Me.SplitContainer2.TabIndex = 0
        '
        'hfIsPosted
        '
        Me.hfIsPosted.AutoSize = True
        Me.hfIsPosted.Location = New System.Drawing.Point(887, 19)
        Me.hfIsPosted.Name = "hfIsPosted"
        Me.hfIsPosted.Size = New System.Drawing.Size(66, 17)
        Me.hfIsPosted.TabIndex = 21
        Me.hfIsPosted.Text = "isPosted"
        Me.hfIsPosted.UseVisualStyleBackColor = True
        Me.hfIsPosted.Visible = False
        '
        'cmbAccMainHead
        '
        Me.cmbAccMainHead.FormattingEnabled = True
        Me.cmbAccMainHead.Location = New System.Drawing.Point(306, 12)
        Me.cmbAccMainHead.Name = "cmbAccMainHead"
        Me.cmbAccMainHead.Size = New System.Drawing.Size(136, 21)
        Me.cmbAccMainHead.TabIndex = 1
        '
        'chkCancel
        '
        Me.chkCancel.AutoSize = True
        Me.chkCancel.Location = New System.Drawing.Point(520, 45)
        Me.chkCancel.Name = "chkCancel"
        Me.chkCancel.Size = New System.Drawing.Size(59, 17)
        Me.chkCancel.TabIndex = 5
        Me.chkCancel.Text = "Cancel"
        Me.chkCancel.UseVisualStyleBackColor = True
        '
        'dtpCancelDate
        '
        Me.dtpCancelDate.CustomFormat = "dd/MM/yyyy"
        Me.dtpCancelDate.Enabled = False
        Me.dtpCancelDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpCancelDate.Location = New System.Drawing.Point(753, 38)
        Me.dtpCancelDate.Name = "dtpCancelDate"
        Me.dtpCancelDate.Size = New System.Drawing.Size(104, 20)
        Me.dtpCancelDate.TabIndex = 6
        Me.dtpCancelDate.Value = New Date(2019, 12, 30, 12, 2, 41, 0)
        '
        'lblAcctID
        '
        Me.lblAcctID.AutoSize = True
        Me.lblAcctID.Location = New System.Drawing.Point(884, 3)
        Me.lblAcctID.Name = "lblAcctID"
        Me.lblAcctID.Size = New System.Drawing.Size(40, 13)
        Me.lblAcctID.TabIndex = 6
        Me.lblAcctID.Text = "AcctID"
        Me.lblAcctID.Visible = False
        '
        'Label19
        '
        Me.Label19.Location = New System.Drawing.Point(678, 43)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(78, 15)
        Me.Label19.TabIndex = 18
        Me.Label19.Text = "Cancel Date:"
        '
        'lblVID
        '
        Me.lblVID.AutoSize = True
        Me.lblVID.Location = New System.Drawing.Point(2, 3)
        Me.lblVID.Name = "lblVID"
        Me.lblVID.Size = New System.Drawing.Size(13, 13)
        Me.lblVID.TabIndex = 0
        Me.lblVID.Text = "0"
        Me.lblVID.Visible = False
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(680, 16)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(67, 13)
        Me.Label17.TabIndex = 16
        Me.Label17.Text = "Reference #"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblCurrencyID)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.cmbCurrency)
        Me.GroupBox1.Controls.Add(Me.cmbAccountHead)
        Me.GroupBox1.Controls.Add(Me.cmbAccType)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.lblInfo)
        Me.GroupBox1.Controls.Add(Me.btnCancel)
        Me.GroupBox1.Controls.Add(Me.lblAccountTitle)
        Me.GroupBox1.Controls.Add(Me.txtAmount)
        Me.GroupBox1.Controls.Add(Me.btnAdd)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtNarration)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 67)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(947, 63)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Detail"
        '
        'lblCurrencyID
        '
        Me.lblCurrencyID.AutoSize = True
        Me.lblCurrencyID.Location = New System.Drawing.Point(551, 17)
        Me.lblCurrencyID.Name = "lblCurrencyID"
        Me.lblCurrencyID.Size = New System.Drawing.Size(60, 13)
        Me.lblCurrencyID.TabIndex = 20
        Me.lblCurrencyID.Text = "CurrencyID"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(676, 15)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(52, 13)
        Me.Label10.TabIndex = 19
        Me.Label10.Text = "Currency:"
        '
        'cmbCurrency
        '
        Me.cmbCurrency.FormattingEnabled = True
        Me.cmbCurrency.Location = New System.Drawing.Point(679, 35)
        Me.cmbCurrency.Name = "cmbCurrency"
        Me.cmbCurrency.Size = New System.Drawing.Size(79, 21)
        Me.cmbCurrency.TabIndex = 18
        '
        'cmbAccountHead
        '
        Me.cmbAccountHead.FormattingEnabled = True
        Me.cmbAccountHead.Location = New System.Drawing.Point(124, 34)
        Me.cmbAccountHead.Name = "cmbAccountHead"
        Me.cmbAccountHead.Size = New System.Drawing.Size(163, 21)
        Me.cmbAccountHead.TabIndex = 1
        '
        'cmbAccType
        '
        Me.cmbAccType.FormattingEnabled = True
        Me.cmbAccType.Location = New System.Drawing.Point(21, 33)
        Me.cmbAccType.Name = "cmbAccType"
        Me.cmbAccType.Size = New System.Drawing.Size(97, 21)
        Me.cmbAccType.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(124, 18)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 13)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Account Head:"
        '
        'lblInfo
        '
        Me.lblInfo.AutoSize = True
        Me.lblInfo.BackColor = System.Drawing.SystemColors.Info
        Me.lblInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblInfo.ForeColor = System.Drawing.Color.White
        Me.lblInfo.Location = New System.Drawing.Point(838, 16)
        Me.lblInfo.Name = "lblInfo"
        Me.lblInfo.Size = New System.Drawing.Size(72, 15)
        Me.lblInfo.TabIndex = 16
        Me.lblInfo.Text = "                     "
        Me.lblInfo.Visible = False
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(882, 36)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(56, 23)
        Me.btnCancel.TabIndex = 5
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'lblAccountTitle
        '
        Me.lblAccountTitle.AutoSize = True
        Me.lblAccountTitle.BackColor = System.Drawing.SystemColors.Info
        Me.lblAccountTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAccountTitle.ForeColor = System.Drawing.Color.White
        Me.lblAccountTitle.Location = New System.Drawing.Point(425, 15)
        Me.lblAccountTitle.Name = "lblAccountTitle"
        Me.lblAccountTitle.Size = New System.Drawing.Size(72, 15)
        Me.lblAccountTitle.TabIndex = 15
        Me.lblAccountTitle.Text = "                     "
        Me.lblAccountTitle.Visible = False
        '
        'txtAmount
        '
        Me.txtAmount.Location = New System.Drawing.Point(764, 36)
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(67, 20)
        Me.txtAmount.TabIndex = 3
        Me.txtAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(838, 36)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(39, 23)
        Me.btnAdd.TabIndex = 4
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(18, 17)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(77, 13)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Account Type:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(761, 17)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(46, 13)
        Me.Label9.TabIndex = 7
        Me.Label9.Text = "Amount:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(290, 17)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(53, 13)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "Narration:"
        '
        'txtNarration
        '
        Me.txtNarration.Location = New System.Drawing.Point(293, 36)
        Me.txtNarration.Name = "txtNarration"
        Me.txtNarration.Size = New System.Drawing.Size(380, 20)
        Me.txtNarration.TabIndex = 2
        '
        'txtRefNo
        '
        Me.txtRefNo.Location = New System.Drawing.Point(753, 9)
        Me.txtRefNo.Name = "txtRefNo"
        Me.txtRefNo.Size = New System.Drawing.Size(104, 20)
        Me.txtRefNo.TabIndex = 3
        '
        'dtpDate
        '
        Me.dtpDate.CustomFormat = "dd/MM/yyyy"
        Me.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDate.Location = New System.Drawing.Point(520, 13)
        Me.dtpDate.Name = "dtpDate"
        Me.dtpDate.Size = New System.Drawing.Size(104, 20)
        Me.dtpDate.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(34, 46)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Remarks:"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(224, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Account Head:"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(475, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Date:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(37, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Vr No:"
        '
        'txtRemarks
        '
        Me.txtRemarks.Location = New System.Drawing.Point(97, 41)
        Me.txtRemarks.Name = "txtRemarks"
        Me.txtRemarks.Size = New System.Drawing.Size(345, 20)
        Me.txtRemarks.TabIndex = 4
        '
        'txtVNo
        '
        Me.txtVNo.Location = New System.Drawing.Point(97, 13)
        Me.txtVNo.Name = "txtVNo"
        Me.txtVNo.ReadOnly = True
        Me.txtVNo.Size = New System.Drawing.Size(100, 20)
        Me.txtVNo.TabIndex = 0
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.VID, Me.AccountID, Me.AccountTypeID, Me.AccountTypeTitle, Me.VCode, Me.AccountHead, Me.Narration, Me.CurrencyID, Me.Currency, Me.Debit, Me.ExRate, Me.ExAmount})
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.Size = New System.Drawing.Size(953, 251)
        Me.DataGridView1.TabIndex = 0
        '
        'lblDebitSum
        '
        Me.lblDebitSum.AutoSize = True
        Me.lblDebitSum.Location = New System.Drawing.Point(783, 6)
        Me.lblDebitSum.Name = "lblDebitSum"
        Me.lblDebitSum.Size = New System.Drawing.Size(13, 13)
        Me.lblDebitSum.TabIndex = 6
        Me.lblDebitSum.Text = "0"
        '
        'lblCreditSum
        '
        Me.lblCreditSum.AutoSize = True
        Me.lblCreditSum.Location = New System.Drawing.Point(919, 6)
        Me.lblCreditSum.Name = "lblCreditSum"
        Me.lblCreditSum.Size = New System.Drawing.Size(13, 13)
        Me.lblCreditSum.TabIndex = 8
        Me.lblCreditSum.Text = "0"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(732, 6)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(51, 13)
        Me.Label11.TabIndex = 5
        Me.Label11.Text = "Total Dr: "
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(862, 6)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(50, 13)
        Me.Label12.TabIndex = 7
        Me.Label12.Text = "Total Cr: "
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
        Me.dtFDateFrom.Location = New System.Drawing.Point(288, 11)
        Me.dtFDateFrom.Name = "dtFDateFrom"
        Me.dtFDateFrom.Size = New System.Drawing.Size(104, 20)
        Me.dtFDateFrom.TabIndex = 5
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(20, 44)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(58, 13)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Remarks:"
        '
        'Label13
        '
        Me.Label13.Location = New System.Drawing.Point(715, 49)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(39, 13)
        Me.Label13.TabIndex = 2
        Me.Label13.Text = "Type:"
        Me.Label13.Visible = False
        '
        'Label14
        '
        Me.Label14.Location = New System.Drawing.Point(215, 15)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(67, 13)
        Me.Label14.TabIndex = 4
        Me.Label14.Text = "Date From:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(23, 12)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(37, 13)
        Me.Label15.TabIndex = 0
        Me.Label15.Text = "Vr No:"
        '
        'txtFRemarks
        '
        Me.txtFRemarks.Location = New System.Drawing.Point(83, 39)
        Me.txtFRemarks.Name = "txtFRemarks"
        Me.txtFRemarks.Size = New System.Drawing.Size(506, 20)
        Me.txtFRemarks.TabIndex = 9
        '
        'cmbFVtype
        '
        Me.cmbFVtype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbFVtype.FormattingEnabled = True
        Me.cmbFVtype.Location = New System.Drawing.Point(768, 44)
        Me.cmbFVtype.Name = "cmbFVtype"
        Me.cmbFVtype.Size = New System.Drawing.Size(121, 21)
        Me.cmbFVtype.TabIndex = 3
        Me.cmbFVtype.Visible = False
        '
        'txtFVNo
        '
        Me.txtFVNo.Location = New System.Drawing.Point(83, 11)
        Me.txtFVNo.Name = "txtFVNo"
        Me.txtFVNo.Size = New System.Drawing.Size(100, 20)
        Me.txtFVNo.TabIndex = 1
        '
        'dtFDateTo
        '
        Me.dtFDateTo.CustomFormat = "dd/MM/yyyy"
        Me.dtFDateTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtFDateTo.Location = New System.Drawing.Point(484, 10)
        Me.dtFDateTo.Name = "dtFDateTo"
        Me.dtFDateTo.Size = New System.Drawing.Size(104, 20)
        Me.dtFDateTo.TabIndex = 7
        '
        'Label16
        '
        Me.Label16.Location = New System.Drawing.Point(411, 14)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(67, 13)
        Me.Label16.TabIndex = 6
        Me.Label16.Text = "Date To:"
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(611, 37)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(75, 23)
        Me.btnSearch.TabIndex = 10
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'VID
        '
        Me.VID.HeaderText = "VID"
        Me.VID.Name = "VID"
        Me.VID.ReadOnly = True
        Me.VID.Visible = False
        '
        'AccountID
        '
        Me.AccountID.HeaderText = "Account ID"
        Me.AccountID.Name = "AccountID"
        Me.AccountID.ReadOnly = True
        Me.AccountID.Visible = False
        '
        'AccountTypeID
        '
        Me.AccountTypeID.HeaderText = "Account Type ID"
        Me.AccountTypeID.Name = "AccountTypeID"
        Me.AccountTypeID.ReadOnly = True
        Me.AccountTypeID.Visible = False
        '
        'AccountTypeTitle
        '
        Me.AccountTypeTitle.HeaderText = "Account Type"
        Me.AccountTypeTitle.Name = "AccountTypeTitle"
        Me.AccountTypeTitle.ReadOnly = True
        Me.AccountTypeTitle.Width = 130
        '
        'VCode
        '
        Me.VCode.HeaderText = "Voucher Code"
        Me.VCode.Name = "VCode"
        Me.VCode.ReadOnly = True
        Me.VCode.Visible = False
        '
        'AccountHead
        '
        Me.AccountHead.HeaderText = "Account Head"
        Me.AccountHead.Name = "AccountHead"
        Me.AccountHead.ReadOnly = True
        Me.AccountHead.Width = 160
        '
        'Narration
        '
        Me.Narration.HeaderText = "Narration"
        Me.Narration.Name = "Narration"
        Me.Narration.ReadOnly = True
        Me.Narration.Width = 380
        '
        'CurrencyID
        '
        Me.CurrencyID.HeaderText = "CurrencyID"
        Me.CurrencyID.Name = "CurrencyID"
        Me.CurrencyID.ReadOnly = True
        Me.CurrencyID.Visible = False
        '
        'Currency
        '
        Me.Currency.HeaderText = "Currency"
        Me.Currency.Name = "Currency"
        Me.Currency.ReadOnly = True
        Me.Currency.Width = 80
        '
        'Debit
        '
        Me.Debit.HeaderText = "Amount"
        Me.Debit.Name = "Debit"
        Me.Debit.ReadOnly = True
        Me.Debit.Width = 80
        '
        'ExRate
        '
        Me.ExRate.HeaderText = "ExRate"
        Me.ExRate.Name = "ExRate"
        Me.ExRate.ReadOnly = True
        Me.ExRate.Width = 80
        '
        'ExAmount
        '
        Me.ExAmount.HeaderText = "ExAmount"
        Me.ExAmount.Name = "ExAmount"
        Me.ExAmount.ReadOnly = True
        Me.ExAmount.Width = 80
        '
        'frmACCPVCSimpleMultiCurrency
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(967, 523)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmACCPVCSimpleMultiCurrency"
        Me.Text = "Cash Payment Voucher Simple"
        Me.GBHeading.ResumeLayout(False)
        Me.GBFooter.ResumeLayout(False)
        Me.GBFooter.PerformLayout()
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
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdGL, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdAtt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtRemarks As System.Windows.Forms.TextBox
    Friend WithEvents txtVNo As System.Windows.Forms.TextBox
    Friend WithEvents dtpDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtNarration As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents txtAmount As System.Windows.Forms.TextBox
    Friend WithEvents lblDebitSum As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents lblCreditSum As System.Windows.Forms.Label
    Friend WithEvents lblAcctID As System.Windows.Forms.Label
    Friend WithEvents lblVID As System.Windows.Forms.Label
    Friend WithEvents grdGL As System.Windows.Forms.DataGridView
    Friend WithEvents grdAtt As System.Windows.Forms.DataGridView
    Friend WithEvents dtFDateTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents dtFDateFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtFRemarks As System.Windows.Forms.TextBox
    Friend WithEvents cmbFVtype As System.Windows.Forms.ComboBox
    Friend WithEvents txtFVNo As System.Windows.Forms.TextBox
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents dtpCancelDate As DateTimePicker
    Friend WithEvents Label19 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents txtRefNo As TextBox
    Friend WithEvents chkCancel As CheckBox
    Friend WithEvents btnCancel As Button
    Friend WithEvents lblInfo As Label
    Friend WithEvents lblAccountTitle As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents cmbAccType As ComboBox
    Friend WithEvents cmbAccountHead As ComboBox
    Friend WithEvents cmbAccMainHead As ComboBox
    Friend WithEvents hfIsPosted As CheckBox
    Friend WithEvents Label10 As Label
    Friend WithEvents cmbCurrency As ComboBox
    Friend WithEvents lblCurrencyID As Label
    Friend WithEvents VID As DataGridViewTextBoxColumn
    Friend WithEvents AccountID As DataGridViewTextBoxColumn
    Friend WithEvents AccountTypeID As DataGridViewTextBoxColumn
    Friend WithEvents AccountTypeTitle As DataGridViewTextBoxColumn
    Friend WithEvents VCode As DataGridViewTextBoxColumn
    Friend WithEvents AccountHead As DataGridViewTextBoxColumn
    Friend WithEvents Narration As DataGridViewTextBoxColumn
    Friend WithEvents CurrencyID As DataGridViewTextBoxColumn
    Friend WithEvents Currency As DataGridViewTextBoxColumn
    Friend WithEvents Debit As DataGridViewTextBoxColumn
    Friend WithEvents ExRate As DataGridViewTextBoxColumn
    Friend WithEvents ExAmount As DataGridViewTextBoxColumn
End Class