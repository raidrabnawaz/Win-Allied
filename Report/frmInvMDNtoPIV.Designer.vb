﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmInvMDNtoPIV
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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.cmbVoucherType = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dtpDateTo = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtpDateFrom = New System.Windows.Forms.DateTimePicker()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtVnoTo = New System.Windows.Forms.TextBox()
        Me.txtVnoFrom = New System.Windows.Forms.TextBox()
        Me.grdRecord = New System.Windows.Forms.DataGridView()
        Me.mdnVID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.mdnVNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.mdnDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.issueVID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.issueVNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.issueDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.poVID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.poVNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.poDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.igpVID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.igpVNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.igpDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grnVID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grnVNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grnDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblInformation = New System.Windows.Forms.Label()
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
        Me.cmdSave.Location = New System.Drawing.Point(363, 6)
        Me.cmdSave.Visible = False
        '
        'cmdEdit
        '
        Me.cmdEdit.Location = New System.Drawing.Point(429, 6)
        Me.cmdEdit.Visible = False
        '
        'cmdDelete
        '
        Me.cmdDelete.Location = New System.Drawing.Point(627, 6)
        Me.cmdDelete.Visible = False
        '
        'cmdCancel
        '
        Me.cmdCancel.Location = New System.Drawing.Point(561, 6)
        Me.cmdCancel.Visible = False
        '
        'cmdSearch
        '
        Me.cmdSearch.Location = New System.Drawing.Point(495, 6)
        '
        'cmdNew
        '
        Me.cmdNew.Location = New System.Drawing.Point(297, 6)
        Me.cmdNew.TabIndex = 0
        Me.cmdNew.Visible = False
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
        Me.lblHeading.Text = "MDN to PIV"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(243, 11)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Voucher No To:"
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
        Me.SplitContainer1.Panel1.Controls.Add(Me.cmbVoucherType)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label6)
        Me.SplitContainer1.Panel1.Controls.Add(Me.dtpDateTo)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.dtpDateFrom)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label19)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label3)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtVnoTo)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtVnoFrom)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label4)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.grdRecord)
        Me.SplitContainer1.Size = New System.Drawing.Size(961, 386)
        Me.SplitContainer1.SplitterDistance = 65
        Me.SplitContainer1.TabIndex = 7
        '
        'cmbVoucherType
        '
        Me.cmbVoucherType.FormattingEnabled = True
        Me.cmbVoucherType.Items.AddRange(New Object() {"MDN", "Purchase Order", "Inward Gate Pass", "Goods Receipt Note", "Issue Note"})
        Me.cmbVoucherType.Location = New System.Drawing.Point(763, 27)
        Me.cmbVoucherType.Name = "cmbVoucherType"
        Me.cmbVoucherType.Size = New System.Drawing.Size(114, 21)
        Me.cmbVoucherType.TabIndex = 4
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(760, 11)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(77, 13)
        Me.Label6.TabIndex = 24
        Me.Label6.Text = "Voucher Type:"
        '
        'dtpDateTo
        '
        Me.dtpDateTo.CustomFormat = "dd/MM/yyyy"
        Me.dtpDateTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDateTo.Location = New System.Drawing.Point(594, 27)
        Me.dtpDateTo.Name = "dtpDateTo"
        Me.dtpDateTo.Size = New System.Drawing.Size(114, 20)
        Me.dtpDateTo.TabIndex = 3
        Me.dtpDateTo.Value = New Date(2019, 12, 30, 12, 2, 41, 0)
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(591, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 15)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Date To:"
        '
        'dtpDateFrom
        '
        Me.dtpDateFrom.CustomFormat = "dd/MM/yyyy"
        Me.dtpDateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDateFrom.Location = New System.Drawing.Point(411, 27)
        Me.dtpDateFrom.Name = "dtpDateFrom"
        Me.dtpDateFrom.Size = New System.Drawing.Size(114, 20)
        Me.dtpDateFrom.TabIndex = 2
        Me.dtpDateFrom.Value = New Date(2019, 12, 30, 12, 2, 41, 0)
        '
        'Label19
        '
        Me.Label19.Location = New System.Drawing.Point(408, 11)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(78, 15)
        Me.Label19.TabIndex = 20
        Me.Label19.Text = "Date From:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(71, 11)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Voucher No From:"
        '
        'txtVnoTo
        '
        Me.txtVnoTo.Location = New System.Drawing.Point(246, 27)
        Me.txtVnoTo.MaxLength = 50
        Me.txtVnoTo.Name = "txtVnoTo"
        Me.txtVnoTo.Size = New System.Drawing.Size(114, 20)
        Me.txtVnoTo.TabIndex = 1
        '
        'txtVnoFrom
        '
        Me.txtVnoFrom.Location = New System.Drawing.Point(74, 27)
        Me.txtVnoFrom.Name = "txtVnoFrom"
        Me.txtVnoFrom.Size = New System.Drawing.Size(114, 20)
        Me.txtVnoFrom.TabIndex = 0
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
        Me.grdRecord.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.mdnVID, Me.mdnVNo, Me.mdnDate, Me.issueVID, Me.issueVNo, Me.issueDate, Me.poVID, Me.poVNo, Me.poDate, Me.igpVID, Me.igpVNo, Me.igpDate, Me.grnVID, Me.grnVNo, Me.grnDate})
        Me.grdRecord.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdRecord.Location = New System.Drawing.Point(0, 0)
        Me.grdRecord.MultiSelect = False
        Me.grdRecord.Name = "grdRecord"
        Me.grdRecord.ReadOnly = True
        Me.grdRecord.RowHeadersVisible = False
        Me.grdRecord.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.grdRecord.Size = New System.Drawing.Size(961, 317)
        Me.grdRecord.TabIndex = 0
        '
        'mdnVID
        '
        Me.mdnVID.DataPropertyName = "mdnVID"
        Me.mdnVID.HeaderText = "mdnVID"
        Me.mdnVID.Name = "mdnVID"
        Me.mdnVID.ReadOnly = True
        Me.mdnVID.Visible = False
        '
        'mdnVNo
        '
        Me.mdnVNo.DataPropertyName = "mdnVNO"
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Blue
        Me.mdnVNo.DefaultCellStyle = DataGridViewCellStyle2
        Me.mdnVNo.HeaderText = "MDN VNo"
        Me.mdnVNo.Name = "mdnVNo"
        Me.mdnVNo.ReadOnly = True
        '
        'mdnDate
        '
        Me.mdnDate.DataPropertyName = "mdnDate"
        Me.mdnDate.HeaderText = "MDN Date"
        Me.mdnDate.Name = "mdnDate"
        Me.mdnDate.ReadOnly = True
        '
        'issueVID
        '
        Me.issueVID.DataPropertyName = "issueVID"
        Me.issueVID.HeaderText = "IssueVID"
        Me.issueVID.Name = "issueVID"
        Me.issueVID.ReadOnly = True
        Me.issueVID.Visible = False
        '
        'issueVNo
        '
        Me.issueVNo.DataPropertyName = "issueVNo"
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Blue
        Me.issueVNo.DefaultCellStyle = DataGridViewCellStyle3
        Me.issueVNo.HeaderText = "Issue VNo"
        Me.issueVNo.Name = "issueVNo"
        Me.issueVNo.ReadOnly = True
        '
        'issueDate
        '
        Me.issueDate.DataPropertyName = "issueDate"
        Me.issueDate.HeaderText = "Issue Date"
        Me.issueDate.Name = "issueDate"
        Me.issueDate.ReadOnly = True
        '
        'poVID
        '
        Me.poVID.DataPropertyName = "poVID"
        Me.poVID.HeaderText = "poVID"
        Me.poVID.Name = "poVID"
        Me.poVID.ReadOnly = True
        Me.poVID.Visible = False
        '
        'poVNo
        '
        Me.poVNo.DataPropertyName = "poVNo"
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Blue
        Me.poVNo.DefaultCellStyle = DataGridViewCellStyle4
        Me.poVNo.HeaderText = "PO VNo"
        Me.poVNo.Name = "poVNo"
        Me.poVNo.ReadOnly = True
        '
        'poDate
        '
        Me.poDate.DataPropertyName = "poDate"
        Me.poDate.HeaderText = "PO Date"
        Me.poDate.Name = "poDate"
        Me.poDate.ReadOnly = True
        '
        'igpVID
        '
        Me.igpVID.DataPropertyName = "igpVID"
        Me.igpVID.HeaderText = "igpVID"
        Me.igpVID.Name = "igpVID"
        Me.igpVID.ReadOnly = True
        Me.igpVID.Visible = False
        '
        'igpVNo
        '
        Me.igpVNo.DataPropertyName = "igpVNo"
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.Blue
        Me.igpVNo.DefaultCellStyle = DataGridViewCellStyle5
        Me.igpVNo.HeaderText = "IGP VNo"
        Me.igpVNo.Name = "igpVNo"
        Me.igpVNo.ReadOnly = True
        '
        'igpDate
        '
        Me.igpDate.DataPropertyName = "igpDate"
        Me.igpDate.HeaderText = "IGP Date"
        Me.igpDate.Name = "igpDate"
        Me.igpDate.ReadOnly = True
        '
        'grnVID
        '
        Me.grnVID.DataPropertyName = "grnVID"
        Me.grnVID.HeaderText = "grnVID"
        Me.grnVID.Name = "grnVID"
        Me.grnVID.ReadOnly = True
        Me.grnVID.Visible = False
        '
        'grnVNo
        '
        Me.grnVNo.DataPropertyName = "grnVNo"
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.Blue
        Me.grnVNo.DefaultCellStyle = DataGridViewCellStyle6
        Me.grnVNo.HeaderText = "GRN VNo"
        Me.grnVNo.Name = "grnVNo"
        Me.grnVNo.ReadOnly = True
        '
        'grnDate
        '
        Me.grnDate.DataPropertyName = "grnDate"
        Me.grnDate.HeaderText = "GRN Date"
        Me.grnDate.Name = "grnDate"
        Me.grnDate.ReadOnly = True
        '
        'lblInformation
        '
        Me.lblInformation.BackColor = System.Drawing.Color.Transparent
        Me.lblInformation.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInformation.ForeColor = System.Drawing.Color.Green
        Me.lblInformation.Location = New System.Drawing.Point(696, 6)
        Me.lblInformation.Name = "lblInformation"
        Me.lblInformation.Size = New System.Drawing.Size(259, 22)
        Me.lblInformation.TabIndex = 4
        Me.lblInformation.Text = "."
        '
        'frmInvMDNtoPIV
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(967, 523)
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.MaximizeBox = False
        Me.Name = "frmInvMDNtoPIV"
        Me.Text = "MDN to PIV"
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
    Friend WithEvents txtVnoTo As System.Windows.Forms.TextBox
    Friend WithEvents txtVnoFrom As System.Windows.Forms.TextBox
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents grdRecord As System.Windows.Forms.DataGridView
    Friend WithEvents lblInformation As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dtpDateTo As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents dtpDateFrom As DateTimePicker
    Friend WithEvents Label19 As Label
    Friend WithEvents cmbVoucherType As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents mdnVID As DataGridViewTextBoxColumn
    Friend WithEvents mdnVNo As DataGridViewTextBoxColumn
    Friend WithEvents mdnDate As DataGridViewTextBoxColumn
    Friend WithEvents issueVID As DataGridViewTextBoxColumn
    Friend WithEvents issueVNo As DataGridViewTextBoxColumn
    Friend WithEvents issueDate As DataGridViewTextBoxColumn
    Friend WithEvents poVID As DataGridViewTextBoxColumn
    Friend WithEvents poVNo As DataGridViewTextBoxColumn
    Friend WithEvents poDate As DataGridViewTextBoxColumn
    Friend WithEvents igpVID As DataGridViewTextBoxColumn
    Friend WithEvents igpVNo As DataGridViewTextBoxColumn
    Friend WithEvents igpDate As DataGridViewTextBoxColumn
    Friend WithEvents grnVID As DataGridViewTextBoxColumn
    Friend WithEvents grnVNo As DataGridViewTextBoxColumn
    Friend WithEvents grnDate As DataGridViewTextBoxColumn
End Class
