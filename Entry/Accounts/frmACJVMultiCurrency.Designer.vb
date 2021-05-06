<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmACJVMultiCurrency
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.grpBoxCheque = New System.Windows.Forms.Panel()
        Me.dtpChequeDate = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtChequeHead = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.lblRefNo = New System.Windows.Forms.Label()
        Me.hfIsPosted = New System.Windows.Forms.CheckBox()
        Me.txtRefernceNo = New System.Windows.Forms.TextBox()
        Me.chkCancel = New System.Windows.Forms.CheckBox()
        Me.dtpCancelDate = New System.Windows.Forms.DateTimePicker()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.lblAcctID = New System.Windows.Forms.Label()
        Me.lblVID = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblCurrencyID = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbCurrency = New System.Windows.Forms.ComboBox()
        Me.lblCheque = New System.Windows.Forms.Label()
        Me.txtChequeNo = New System.Windows.Forms.TextBox()
        Me.lblInfo = New System.Windows.Forms.Label()
        Me.lblAccountTitle = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.txtDebit = New System.Windows.Forms.TextBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtNarration = New System.Windows.Forms.TextBox()
        Me.txtAccountHead = New System.Windows.Forms.TextBox()
        Me.txtCredit = New System.Windows.Forms.TextBox()
        Me.dtpDate = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
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
        Me.AccountHead = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Narration = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AccountTitle = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ChequeNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CurrencyID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Currency = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Debit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Credit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ExRate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ExDebit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ExCredit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Delete = New System.Windows.Forms.DataGridViewImageColumn()
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
        Me.grpBoxCheque.SuspendLayout()
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
        Me.lblHeading.Text = "Journal Voucher"
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
        Me.SplitContainer2.Panel1.Controls.Add(Me.grpBoxCheque)
        Me.SplitContainer2.Panel1.Controls.Add(Me.lblRefNo)
        Me.SplitContainer2.Panel1.Controls.Add(Me.hfIsPosted)
        Me.SplitContainer2.Panel1.Controls.Add(Me.txtRefernceNo)
        Me.SplitContainer2.Panel1.Controls.Add(Me.chkCancel)
        Me.SplitContainer2.Panel1.Controls.Add(Me.dtpCancelDate)
        Me.SplitContainer2.Panel1.Controls.Add(Me.Label19)
        Me.SplitContainer2.Panel1.Controls.Add(Me.lblAcctID)
        Me.SplitContainer2.Panel1.Controls.Add(Me.lblVID)
        Me.SplitContainer2.Panel1.Controls.Add(Me.GroupBox1)
        Me.SplitContainer2.Panel1.Controls.Add(Me.dtpDate)
        Me.SplitContainer2.Panel1.Controls.Add(Me.Label5)
        Me.SplitContainer2.Panel1.Controls.Add(Me.lblDate)
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
        'grpBoxCheque
        '
        Me.grpBoxCheque.Controls.Add(Me.dtpChequeDate)
        Me.grpBoxCheque.Controls.Add(Me.Label3)
        Me.grpBoxCheque.Controls.Add(Me.txtChequeHead)
        Me.grpBoxCheque.Controls.Add(Me.Label21)
        Me.grpBoxCheque.Location = New System.Drawing.Point(549, 7)
        Me.grpBoxCheque.Name = "grpBoxCheque"
        Me.grpBoxCheque.Size = New System.Drawing.Size(195, 61)
        Me.grpBoxCheque.TabIndex = 5
        Me.grpBoxCheque.Visible = False
        '
        'dtpChequeDate
        '
        Me.dtpChequeDate.CustomFormat = "dd/MM/yyyy"
        Me.dtpChequeDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpChequeDate.Location = New System.Drawing.Point(100, 35)
        Me.dtpChequeDate.Name = "dtpChequeDate"
        Me.dtpChequeDate.Size = New System.Drawing.Size(84, 20)
        Me.dtpChequeDate.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(11, 39)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Cheque Date:"
        '
        'txtChequeHead
        '
        Me.txtChequeHead.Location = New System.Drawing.Point(102, 6)
        Me.txtChequeHead.Name = "txtChequeHead"
        Me.txtChequeHead.Size = New System.Drawing.Size(84, 20)
        Me.txtChequeHead.TabIndex = 0
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(27, 9)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(61, 13)
        Me.Label21.TabIndex = 0
        Me.Label21.Text = "Cheque No"
        '
        'lblRefNo
        '
        Me.lblRefNo.AutoSize = True
        Me.lblRefNo.Location = New System.Drawing.Point(505, 18)
        Me.lblRefNo.Name = "lblRefNo"
        Me.lblRefNo.Size = New System.Drawing.Size(67, 13)
        Me.lblRefNo.TabIndex = 4
        Me.lblRefNo.Text = "Reference #"
        '
        'hfIsPosted
        '
        Me.hfIsPosted.AutoSize = True
        Me.hfIsPosted.Location = New System.Drawing.Point(884, 19)
        Me.hfIsPosted.Name = "hfIsPosted"
        Me.hfIsPosted.Size = New System.Drawing.Size(66, 17)
        Me.hfIsPosted.TabIndex = 9
        Me.hfIsPosted.Text = "isPosted"
        Me.hfIsPosted.UseVisualStyleBackColor = True
        Me.hfIsPosted.Visible = False
        '
        'txtRefernceNo
        '
        Me.txtRefernceNo.Location = New System.Drawing.Point(586, 15)
        Me.txtRefernceNo.Name = "txtRefernceNo"
        Me.txtRefernceNo.Size = New System.Drawing.Size(119, 20)
        Me.txtRefernceNo.TabIndex = 2
        '
        'chkCancel
        '
        Me.chkCancel.AutoSize = True
        Me.chkCancel.Location = New System.Drawing.Point(870, 41)
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
        Me.dtpCancelDate.Location = New System.Drawing.Point(747, 41)
        Me.dtpCancelDate.Name = "dtpCancelDate"
        Me.dtpCancelDate.Size = New System.Drawing.Size(104, 20)
        Me.dtpCancelDate.TabIndex = 4
        Me.dtpCancelDate.Value = New Date(2019, 12, 30, 12, 2, 41, 0)
        '
        'Label19
        '
        Me.Label19.Location = New System.Drawing.Point(744, 21)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(78, 15)
        Me.Label19.TabIndex = 6
        Me.Label19.Text = "Cancel Date:"
        '
        'lblAcctID
        '
        Me.lblAcctID.AutoSize = True
        Me.lblAcctID.Location = New System.Drawing.Point(884, 3)
        Me.lblAcctID.Name = "lblAcctID"
        Me.lblAcctID.Size = New System.Drawing.Size(40, 13)
        Me.lblAcctID.TabIndex = 10
        Me.lblAcctID.Text = "AcctID"
        Me.lblAcctID.Visible = False
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
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblCurrencyID)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.cmbCurrency)
        Me.GroupBox1.Controls.Add(Me.lblCheque)
        Me.GroupBox1.Controls.Add(Me.txtChequeNo)
        Me.GroupBox1.Controls.Add(Me.lblInfo)
        Me.GroupBox1.Controls.Add(Me.lblAccountTitle)
        Me.GroupBox1.Controls.Add(Me.btnCancel)
        Me.GroupBox1.Controls.Add(Me.txtDebit)
        Me.GroupBox1.Controls.Add(Me.btnAdd)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtNarration)
        Me.GroupBox1.Controls.Add(Me.txtAccountHead)
        Me.GroupBox1.Controls.Add(Me.txtCredit)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 67)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(947, 63)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Detail"
        '
        'lblCurrencyID
        '
        Me.lblCurrencyID.AutoSize = True
        Me.lblCurrencyID.BackColor = System.Drawing.Color.Transparent
        Me.lblCurrencyID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCurrencyID.ForeColor = System.Drawing.Color.White
        Me.lblCurrencyID.Location = New System.Drawing.Point(406, 14)
        Me.lblCurrencyID.Name = "lblCurrencyID"
        Me.lblCurrencyID.Size = New System.Drawing.Size(72, 15)
        Me.lblCurrencyID.TabIndex = 15
        Me.lblCurrencyID.Text = "                     "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(573, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 13)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Currency:"
        '
        'cmbCurrency
        '
        Me.cmbCurrency.FormattingEnabled = True
        Me.cmbCurrency.Location = New System.Drawing.Point(576, 36)
        Me.cmbCurrency.Name = "cmbCurrency"
        Me.cmbCurrency.Size = New System.Drawing.Size(86, 21)
        Me.cmbCurrency.TabIndex = 13
        '
        'lblCheque
        '
        Me.lblCheque.AutoSize = True
        Me.lblCheque.Location = New System.Drawing.Point(481, 17)
        Me.lblCheque.Name = "lblCheque"
        Me.lblCheque.Size = New System.Drawing.Size(64, 13)
        Me.lblCheque.TabIndex = 6
        Me.lblCheque.Text = "Cheque No:"
        Me.lblCheque.Visible = False
        '
        'txtChequeNo
        '
        Me.txtChequeNo.Location = New System.Drawing.Point(484, 36)
        Me.txtChequeNo.Name = "txtChequeNo"
        Me.txtChequeNo.Size = New System.Drawing.Size(85, 20)
        Me.txtChequeNo.TabIndex = 2
        Me.txtChequeNo.Visible = False
        '
        'lblInfo
        '
        Me.lblInfo.AutoSize = True
        Me.lblInfo.BackColor = System.Drawing.SystemColors.Info
        Me.lblInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblInfo.ForeColor = System.Drawing.Color.White
        Me.lblInfo.Location = New System.Drawing.Point(834, 14)
        Me.lblInfo.Name = "lblInfo"
        Me.lblInfo.Size = New System.Drawing.Size(72, 15)
        Me.lblInfo.TabIndex = 12
        Me.lblInfo.Text = "                     "
        Me.lblInfo.Visible = False
        '
        'lblAccountTitle
        '
        Me.lblAccountTitle.AutoSize = True
        Me.lblAccountTitle.BackColor = System.Drawing.SystemColors.Info
        Me.lblAccountTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAccountTitle.ForeColor = System.Drawing.Color.White
        Me.lblAccountTitle.Location = New System.Drawing.Point(252, 14)
        Me.lblAccountTitle.Name = "lblAccountTitle"
        Me.lblAccountTitle.Size = New System.Drawing.Size(72, 15)
        Me.lblAccountTitle.TabIndex = 4
        Me.lblAccountTitle.Text = "                     "
        Me.lblAccountTitle.Visible = False
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(883, 34)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(56, 23)
        Me.btnCancel.TabIndex = 6
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'txtDebit
        '
        Me.txtDebit.Location = New System.Drawing.Point(668, 36)
        Me.txtDebit.Name = "txtDebit"
        Me.txtDebit.Size = New System.Drawing.Size(78, 20)
        Me.txtDebit.TabIndex = 3
        Me.txtDebit.Text = "0"
        Me.txtDebit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(834, 34)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(39, 23)
        Me.btnAdd.TabIndex = 5
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(749, 17)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(37, 13)
        Me.Label10.TabIndex = 10
        Me.Label10.Text = "Credit:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(18, 17)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(79, 13)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Account Head:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(665, 16)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(35, 13)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Debit:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(162, 17)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(53, 13)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Narration:"
        '
        'txtNarration
        '
        Me.txtNarration.Location = New System.Drawing.Point(165, 36)
        Me.txtNarration.Name = "txtNarration"
        Me.txtNarration.Size = New System.Drawing.Size(404, 20)
        Me.txtNarration.TabIndex = 1
        '
        'txtAccountHead
        '
        Me.txtAccountHead.Location = New System.Drawing.Point(21, 36)
        Me.txtAccountHead.Name = "txtAccountHead"
        Me.txtAccountHead.ReadOnly = True
        Me.txtAccountHead.Size = New System.Drawing.Size(132, 20)
        Me.txtAccountHead.TabIndex = 0
        '
        'txtCredit
        '
        Me.txtCredit.Location = New System.Drawing.Point(752, 36)
        Me.txtCredit.Name = "txtCredit"
        Me.txtCredit.Size = New System.Drawing.Size(78, 20)
        Me.txtCredit.TabIndex = 4
        Me.txtCredit.Text = "0"
        Me.txtCredit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'dtpDate
        '
        Me.dtpDate.CustomFormat = "dd/MM/yyyy"
        Me.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDate.Location = New System.Drawing.Point(353, 15)
        Me.dtpDate.Name = "dtpDate"
        Me.dtpDate.Size = New System.Drawing.Size(115, 20)
        Me.dtpDate.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(34, 44)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Remarks:"
        '
        'lblDate
        '
        Me.lblDate.Location = New System.Drawing.Point(308, 18)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(39, 13)
        Me.lblDate.TabIndex = 2
        Me.lblDate.Text = "Date:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(37, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Vr No:"
        '
        'txtRemarks
        '
        Me.txtRemarks.Location = New System.Drawing.Point(97, 41)
        Me.txtRemarks.Name = "txtRemarks"
        Me.txtRemarks.Size = New System.Drawing.Size(608, 20)
        Me.txtRemarks.TabIndex = 3
        '
        'txtVNo
        '
        Me.txtVNo.Location = New System.Drawing.Point(97, 15)
        Me.txtVNo.Name = "txtVNo"
        Me.txtVNo.ReadOnly = True
        Me.txtVNo.Size = New System.Drawing.Size(133, 20)
        Me.txtVNo.TabIndex = 0
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.VID, Me.AccountID, Me.AccountHead, Me.Narration, Me.AccountTitle, Me.ChequeNo, Me.CurrencyID, Me.Currency, Me.Debit, Me.Credit, Me.ExRate, Me.ExDebit, Me.ExCredit, Me.Delete})
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
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.grdGL.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle2
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
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.grdAtt.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
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
        Me.dtFDateFrom.Value = New Date(2020, 1, 7, 0, 0, 0, 0)
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
        Me.Label13.Location = New System.Drawing.Point(732, 49)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(39, 13)
        Me.Label13.TabIndex = 2
        Me.Label13.Text = "Type:"
        Me.Label13.Visible = False
        '
        'Label14
        '
        Me.Label14.Location = New System.Drawing.Point(215, 12)
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
        Me.cmbFVtype.Location = New System.Drawing.Point(785, 44)
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
        Me.dtFDateTo.Location = New System.Drawing.Point(484, 11)
        Me.dtFDateTo.Name = "dtFDateTo"
        Me.dtFDateTo.Size = New System.Drawing.Size(104, 20)
        Me.dtFDateTo.TabIndex = 7
        '
        'Label16
        '
        Me.Label16.Location = New System.Drawing.Point(411, 12)
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
        'AccountHead
        '
        Me.AccountHead.HeaderText = "Account Head"
        Me.AccountHead.Name = "AccountHead"
        Me.AccountHead.ReadOnly = True
        Me.AccountHead.Width = 170
        '
        'Narration
        '
        Me.Narration.HeaderText = "Narration"
        Me.Narration.Name = "Narration"
        Me.Narration.ReadOnly = True
        Me.Narration.Width = 300
        '
        'AccountTitle
        '
        Me.AccountTitle.HeaderText = "Account Title"
        Me.AccountTitle.Name = "AccountTitle"
        Me.AccountTitle.ReadOnly = True
        Me.AccountTitle.Visible = False
        '
        'ChequeNo
        '
        Me.ChequeNo.HeaderText = "Cheque No"
        Me.ChequeNo.Name = "ChequeNo"
        Me.ChequeNo.ReadOnly = True
        Me.ChequeNo.Visible = False
        Me.ChequeNo.Width = 130
        '
        'CurrencyID
        '
        Me.CurrencyID.HeaderText = "CurrencyID"
        Me.CurrencyID.Name = "CurrencyID"
        Me.CurrencyID.ReadOnly = True
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
        Me.Debit.DataPropertyName = "Dr"
        Me.Debit.HeaderText = "Debit"
        Me.Debit.Name = "Debit"
        Me.Debit.ReadOnly = True
        Me.Debit.Width = 80
        '
        'Credit
        '
        Me.Credit.DataPropertyName = "Cr"
        Me.Credit.HeaderText = "Credit"
        Me.Credit.Name = "Credit"
        Me.Credit.ReadOnly = True
        Me.Credit.Width = 80
        '
        'ExRate
        '
        Me.ExRate.HeaderText = "ExRate"
        Me.ExRate.Name = "ExRate"
        Me.ExRate.ReadOnly = True
        Me.ExRate.Width = 80
        '
        'ExDebit
        '
        Me.ExDebit.HeaderText = "ExDr"
        Me.ExDebit.Name = "ExDebit"
        Me.ExDebit.ReadOnly = True
        Me.ExDebit.Width = 80
        '
        'ExCredit
        '
        Me.ExCredit.HeaderText = "ExCr"
        Me.ExCredit.Name = "ExCredit"
        Me.ExCredit.ReadOnly = True
        Me.ExCredit.Width = 80
        '
        'Delete
        '
        Me.Delete.HeaderText = "Delete"
        Me.Delete.Image = Global.WinBusiness.My.Resources.Resources.icExitForm
        Me.Delete.Name = "Delete"
        Me.Delete.ReadOnly = True
        '
        'frmACJVMultiCurrency
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(967, 523)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmACJVMultiCurrency"
        Me.Text = "Journal Voucher"
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
        Me.grpBoxCheque.ResumeLayout(False)
        Me.grpBoxCheque.PerformLayout()
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
    Friend WithEvents lblDate As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtRemarks As System.Windows.Forms.TextBox
    Friend WithEvents txtVNo As System.Windows.Forms.TextBox
    Friend WithEvents dtpDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtCredit As System.Windows.Forms.TextBox
    Friend WithEvents txtAccountHead As System.Windows.Forms.TextBox
    Friend WithEvents txtNarration As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents txtDebit As System.Windows.Forms.TextBox
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
    Friend WithEvents lblRefNo As Label
    Friend WithEvents txtRefernceNo As TextBox
    Friend WithEvents dtpCancelDate As DateTimePicker
    Friend WithEvents Label19 As Label
    Friend WithEvents chkCancel As CheckBox
    Friend WithEvents btnCancel As Button
    Friend WithEvents hfIsPosted As CheckBox
    Friend WithEvents lblAccountTitle As Label
    Friend WithEvents lblInfo As Label
    Friend WithEvents grpBoxCheque As Panel
    Friend WithEvents dtpChequeDate As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents txtChequeHead As TextBox
    Friend WithEvents Label21 As Label
    Friend WithEvents lblCheque As Label
    Friend WithEvents txtChequeNo As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cmbCurrency As ComboBox
    Friend WithEvents lblCurrencyID As Label
    Friend WithEvents VID As DataGridViewTextBoxColumn
    Friend WithEvents AccountID As DataGridViewTextBoxColumn
    Friend WithEvents AccountHead As DataGridViewTextBoxColumn
    Friend WithEvents Narration As DataGridViewTextBoxColumn
    Friend WithEvents AccountTitle As DataGridViewTextBoxColumn
    Friend WithEvents ChequeNo As DataGridViewTextBoxColumn
    Friend WithEvents CurrencyID As DataGridViewTextBoxColumn
    Friend WithEvents Currency As DataGridViewTextBoxColumn
    Friend WithEvents Debit As DataGridViewTextBoxColumn
    Friend WithEvents Credit As DataGridViewTextBoxColumn
    Friend WithEvents ExRate As DataGridViewTextBoxColumn
    Friend WithEvents ExDebit As DataGridViewTextBoxColumn
    Friend WithEvents ExCredit As DataGridViewTextBoxColumn
    Friend WithEvents Delete As DataGridViewImageColumn
End Class
