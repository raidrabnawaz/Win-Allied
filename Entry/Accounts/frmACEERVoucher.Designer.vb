﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmACEERVoucher
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
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.hfIsPosted = New System.Windows.Forms.CheckBox()
        Me.cmbAccType = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbBankAccount = New System.Windows.Forms.ComboBox()
        Me.lblVID = New System.Windows.Forms.Label()
        Me.txtAmount = New System.Windows.Forms.TextBox()
        Me.txtAccountDesc = New System.Windows.Forms.TextBox()
        Me.dtplChequeDate = New System.Windows.Forms.DateTimePicker()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.dtpVoucherDate = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.grdRecord = New System.Windows.Forms.DataGridView()
        Me.lblInformation = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
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
        Me.cmdSave.Location = New System.Drawing.Point(347, 6)
        '
        'cmdEdit
        '
        Me.cmdEdit.Location = New System.Drawing.Point(413, 6)
        '
        'cmdDelete
        '
        Me.cmdDelete.Location = New System.Drawing.Point(611, 6)
        '
        'cmdCancel
        '
        Me.cmdCancel.Location = New System.Drawing.Point(545, 6)
        '
        'cmdSearch
        '
        Me.cmdSearch.Location = New System.Drawing.Point(479, 6)
        '
        'cmdNew
        '
        Me.cmdNew.Location = New System.Drawing.Point(281, 6)
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
        Me.GBFooter.TabIndex = 0
        Me.GBFooter.Controls.SetChildIndex(Me.lblInformation, 0)
        Me.GBFooter.Controls.SetChildIndex(Me.cmdSave, 0)
        Me.GBFooter.Controls.SetChildIndex(Me.cmdEdit, 0)
        Me.GBFooter.Controls.SetChildIndex(Me.cmdSearch, 0)
        Me.GBFooter.Controls.SetChildIndex(Me.cmdCancel, 0)
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
        Me.lblHeading.TabIndex = 0
        Me.lblHeading.Text = "Expense Voucher Claim E.R"
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
        Me.SplitContainer1.Panel1.Controls.Add(Me.DateTimePicker1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label4)
        Me.SplitContainer1.Panel1.Controls.Add(Me.hfIsPosted)
        Me.SplitContainer1.Panel1.Controls.Add(Me.cmbAccType)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.cmbBankAccount)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblVID)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtAmount)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtAccountDesc)
        Me.SplitContainer1.Panel1.Controls.Add(Me.dtplChequeDate)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label11)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label10)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label7)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtID)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label13)
        Me.SplitContainer1.Panel1.Controls.Add(Me.dtpVoucherDate)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label3)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.grdRecord)
        Me.SplitContainer1.Size = New System.Drawing.Size(961, 386)
        Me.SplitContainer1.SplitterDistance = 111
        Me.SplitContainer1.TabIndex = 0
        '
        'hfIsPosted
        '
        Me.hfIsPosted.AutoSize = True
        Me.hfIsPosted.Location = New System.Drawing.Point(19, -3)
        Me.hfIsPosted.Name = "hfIsPosted"
        Me.hfIsPosted.Size = New System.Drawing.Size(66, 17)
        Me.hfIsPosted.TabIndex = 52
        Me.hfIsPosted.Text = "isPosted"
        Me.hfIsPosted.UseVisualStyleBackColor = True
        Me.hfIsPosted.Visible = False
        '
        'cmbAccType
        '
        Me.cmbAccType.FormattingEnabled = True
        Me.cmbAccType.Location = New System.Drawing.Point(165, 41)
        Me.cmbAccType.Name = "cmbAccType"
        Me.cmbAccType.Size = New System.Drawing.Size(121, 21)
        Me.cmbAccType.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(106, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 13)
        Me.Label1.TabIndex = 50
        Me.Label1.Text = "Employee"
        '
        'cmbBankAccount
        '
        Me.cmbBankAccount.FormattingEnabled = True
        Me.cmbBankAccount.Location = New System.Drawing.Point(732, 11)
        Me.cmbBankAccount.Name = "cmbBankAccount"
        Me.cmbBankAccount.Size = New System.Drawing.Size(121, 21)
        Me.cmbBankAccount.TabIndex = 2
        '
        'lblVID
        '
        Me.lblVID.AutoSize = True
        Me.lblVID.ForeColor = System.Drawing.Color.Black
        Me.lblVID.Location = New System.Drawing.Point(0, 1)
        Me.lblVID.Name = "lblVID"
        Me.lblVID.Size = New System.Drawing.Size(13, 13)
        Me.lblVID.TabIndex = 47
        Me.lblVID.Text = "0"
        Me.lblVID.Visible = False
        '
        'txtAmount
        '
        Me.txtAmount.Location = New System.Drawing.Point(734, 71)
        Me.txtAmount.MaxLength = 20
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(121, 20)
        Me.txtAmount.TabIndex = 9
        '
        'txtAccountDesc
        '
        Me.txtAccountDesc.Location = New System.Drawing.Point(452, 42)
        Me.txtAccountDesc.MaxLength = 20
        Me.txtAccountDesc.Name = "txtAccountDesc"
        Me.txtAccountDesc.Size = New System.Drawing.Size(403, 20)
        Me.txtAccountDesc.TabIndex = 6
        '
        'dtplChequeDate
        '
        Me.dtplChequeDate.CustomFormat = "dd/MM/yyyy"
        Me.dtplChequeDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtplChequeDate.Location = New System.Drawing.Point(452, 71)
        Me.dtplChequeDate.Name = "dtplChequeDate"
        Me.dtplChequeDate.Size = New System.Drawing.Size(120, 20)
        Me.dtplChequeDate.TabIndex = 8
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(392, 74)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(53, 13)
        Me.Label11.TabIndex = 32
        Me.Label11.Text = "Period To"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(685, 74)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(43, 13)
        Me.Label10.TabIndex = 30
        Me.Label10.Text = "Amount"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(370, 43)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(75, 13)
        Me.Label7.TabIndex = 25
        Me.Label7.Text = "Account Desc"
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(165, 13)
        Me.txtID.MaxLength = 8
        Me.txtID.Name = "txtID"
        Me.txtID.ReadOnly = True
        Me.txtID.Size = New System.Drawing.Size(121, 20)
        Me.txtID.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(669, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 13)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Claim Type"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(372, 17)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(73, 13)
        Me.Label13.TabIndex = 3
        Me.Label13.Text = "Voucher Date"
        '
        'dtpVoucherDate
        '
        Me.dtpVoucherDate.CustomFormat = "dd/MM/yyyy"
        Me.dtpVoucherDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpVoucherDate.Location = New System.Drawing.Point(452, 14)
        Me.dtpVoucherDate.Name = "dtpVoucherDate"
        Me.dtpVoucherDate.Size = New System.Drawing.Size(120, 20)
        Me.dtpVoucherDate.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(95, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Voucher No"
        '
        'grdRecord
        '
        Me.grdRecord.AllowUserToAddRows = False
        Me.grdRecord.AllowUserToDeleteRows = False
        Me.grdRecord.AllowUserToOrderColumns = True
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.grdRecord.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle6
        Me.grdRecord.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdRecord.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdRecord.Location = New System.Drawing.Point(0, 0)
        Me.grdRecord.Name = "grdRecord"
        Me.grdRecord.ReadOnly = True
        Me.grdRecord.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grdRecord.Size = New System.Drawing.Size(961, 271)
        Me.grdRecord.TabIndex = 0
        '
        'lblInformation
        '
        Me.lblInformation.BackColor = System.Drawing.Color.Transparent
        Me.lblInformation.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInformation.ForeColor = System.Drawing.Color.Green
        Me.lblInformation.Location = New System.Drawing.Point(689, 29)
        Me.lblInformation.Name = "lblInformation"
        Me.lblInformation.Size = New System.Drawing.Size(275, 20)
        Me.lblInformation.TabIndex = 17
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = "dd/MM/yyyy"
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(166, 70)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(120, 20)
        Me.DateTimePicker1.TabIndex = 53
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(96, 76)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 13)
        Me.Label4.TabIndex = 54
        Me.Label4.Text = "Period From"
        '
        'frmACEERVoucher
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(967, 523)
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "frmACEERVoucher"
        Me.Text = "Expense Voucher Claim E.R"
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
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dtpVoucherDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents dtplChequeDate As DateTimePicker
    Friend WithEvents txtAmount As TextBox
    Friend WithEvents txtAccountDesc As TextBox
    Friend WithEvents lblVID As Label
    Friend WithEvents cmbBankAccount As ComboBox
    Friend WithEvents cmbAccType As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents hfIsPosted As CheckBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label4 As Label
End Class
