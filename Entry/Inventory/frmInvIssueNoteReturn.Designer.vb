﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmInvIssueNoteReturn
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lblIssueID = New System.Windows.Forms.Label()
        Me.txtRemarks = New System.Windows.Forms.RichTextBox()
        Me.txtVNo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtpVDate = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtIssueNo = New System.Windows.Forms.TextBox()
        Me.txtOrderNo = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.lblVID = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.VID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UomID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VCode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UOM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DQty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PendingQty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UsedQty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VRate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Quantity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StockID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StockType = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VTypePk = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Del = New System.Windows.Forms.DataGridViewImageColumn()
        Me.IsDel = New System.Windows.Forms.DataGridViewTextBoxColumn()
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
        Me.btnExcelExport = New System.Windows.Forms.Button()
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
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdGL, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdAtt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabMain
        '
        Me.TabMain.Size = New System.Drawing.Size(896, 523)
        '
        'TabPage1
        '
        Me.TabPage1.Size = New System.Drawing.Size(888, 497)
        '
        'TabPage2
        '
        Me.TabPage2.Size = New System.Drawing.Size(888, 497)
        '
        'GBHeading
        '
        Me.GBHeading.Margin = New System.Windows.Forms.Padding(2)
        Me.GBHeading.Size = New System.Drawing.Size(882, 42)
        '
        'lblHeading
        '
        Me.lblHeading.Size = New System.Drawing.Size(882, 42)
        Me.lblHeading.TabIndex = 0
        Me.lblHeading.Text = "Issue Note Return"
        '
        'GBFooter
        '
        Me.GBFooter.Margin = New System.Windows.Forms.Padding(2)
        Me.GBFooter.Size = New System.Drawing.Size(882, 70)
        Me.GBFooter.TabIndex = 0
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
        Me.GBBody.Size = New System.Drawing.Size(882, 379)
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Margin = New System.Windows.Forms.Padding(2)
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnExcelExport)
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
        Me.SplitContainer1.Size = New System.Drawing.Size(882, 491)
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
        Me.SplitContainer2.Panel1.Controls.Add(Me.Label6)
        Me.SplitContainer2.Panel1.Controls.Add(Me.Label5)
        Me.SplitContainer2.Panel1.Controls.Add(Me.Label4)
        Me.SplitContainer2.Panel1.Controls.Add(Me.Label10)
        Me.SplitContainer2.Panel1.Controls.Add(Me.lblIssueID)
        Me.SplitContainer2.Panel1.Controls.Add(Me.txtRemarks)
        Me.SplitContainer2.Panel1.Controls.Add(Me.txtVNo)
        Me.SplitContainer2.Panel1.Controls.Add(Me.Label1)
        Me.SplitContainer2.Panel1.Controls.Add(Me.Label2)
        Me.SplitContainer2.Panel1.Controls.Add(Me.dtpVDate)
        Me.SplitContainer2.Panel1.Controls.Add(Me.Label3)
        Me.SplitContainer2.Panel1.Controls.Add(Me.txtIssueNo)
        Me.SplitContainer2.Panel1.Controls.Add(Me.txtOrderNo)
        Me.SplitContainer2.Panel1.Controls.Add(Me.Label17)
        Me.SplitContainer2.Panel1.Controls.Add(Me.lblVID)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.DataGridView1)
        Me.SplitContainer2.Size = New System.Drawing.Size(882, 379)
        Me.SplitContainer2.SplitterDistance = 93
        Me.SplitContainer2.TabIndex = 0
        Me.SplitContainer2.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(654, 11)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(15, 20)
        Me.Label6.TabIndex = 47
        Me.Label6.Text = "*"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(863, 52)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(15, 20)
        Me.Label5.TabIndex = 46
        Me.Label5.Text = "*"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(863, 11)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(15, 20)
        Me.Label4.TabIndex = 45
        Me.Label4.Text = "*"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(492, 12)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(52, 13)
        Me.Label10.TabIndex = 33
        Me.Label10.Text = "Issue No:"
        '
        'lblIssueID
        '
        Me.lblIssueID.AutoSize = True
        Me.lblIssueID.Location = New System.Drawing.Point(475, 11)
        Me.lblIssueID.Name = "lblIssueID"
        Me.lblIssueID.Size = New System.Drawing.Size(43, 13)
        Me.lblIssueID.TabIndex = 42
        Me.lblIssueID.Text = "IssueID"
        Me.lblIssueID.Visible = False
        '
        'txtRemarks
        '
        Me.txtRemarks.Location = New System.Drawing.Point(101, 38)
        Me.txtRemarks.Name = "txtRemarks"
        Me.txtRemarks.Size = New System.Drawing.Size(763, 46)
        Me.txtRemarks.TabIndex = 15
        Me.txtRemarks.Text = ""
        '
        'txtVNo
        '
        Me.txtVNo.Location = New System.Drawing.Point(103, 8)
        Me.txtVNo.MaxLength = 8
        Me.txtVNo.Name = "txtVNo"
        Me.txtVNo.ReadOnly = True
        Me.txtVNo.Size = New System.Drawing.Size(110, 20)
        Me.txtVNo.TabIndex = 1
        Me.txtVNo.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(44, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 13)
        Me.Label1.TabIndex = 31
        Me.Label1.Text = "Remarks:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(238, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 13)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "Return Date:"
        '
        'dtpVDate
        '
        Me.dtpVDate.CustomFormat = "dd/MM/yyyy"
        Me.dtpVDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpVDate.Location = New System.Drawing.Point(309, 8)
        Me.dtpVDate.Name = "dtpVDate"
        Me.dtpVDate.Size = New System.Drawing.Size(160, 20)
        Me.dtpVDate.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(9, 12)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 13)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Issue Return No:"
        '
        'txtIssueNo
        '
        Me.txtIssueNo.Location = New System.Drawing.Point(544, 8)
        Me.txtIssueNo.MaxLength = 20
        Me.txtIssueNo.Name = "txtIssueNo"
        Me.txtIssueNo.ReadOnly = True
        Me.txtIssueNo.Size = New System.Drawing.Size(110, 20)
        Me.txtIssueNo.TabIndex = 5
        '
        'txtOrderNo
        '
        Me.txtOrderNo.Location = New System.Drawing.Point(753, 8)
        Me.txtOrderNo.MaxLength = 20
        Me.txtOrderNo.Name = "txtOrderNo"
        Me.txtOrderNo.Size = New System.Drawing.Size(110, 20)
        Me.txtOrderNo.TabIndex = 14
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.ForeColor = System.Drawing.Color.Black
        Me.Label17.Location = New System.Drawing.Point(700, 12)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(53, 13)
        Me.Label17.TabIndex = 28
        Me.Label17.Text = "Order No:"
        '
        'lblVID
        '
        Me.lblVID.AutoSize = True
        Me.lblVID.Location = New System.Drawing.Point(5, 11)
        Me.lblVID.Name = "lblVID"
        Me.lblVID.Size = New System.Drawing.Size(25, 13)
        Me.lblVID.TabIndex = 0
        Me.lblVID.Text = "VID"
        Me.lblVID.Visible = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.VID, Me.ProductID, Me.UomID, Me.VCode, Me.VName, Me.UOM, Me.DQty, Me.PendingQty, Me.UsedQty, Me.VRate, Me.Quantity, Me.StockID, Me.StockType, Me.VTypePk, Me.Del, Me.IsDel})
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(882, 282)
        Me.DataGridView1.TabIndex = 0
        Me.DataGridView1.TabStop = False
        '
        'VID
        '
        Me.VID.HeaderText = "VID"
        Me.VID.Name = "VID"
        Me.VID.ReadOnly = True
        Me.VID.Visible = False
        '
        'ProductID
        '
        Me.ProductID.HeaderText = "PID"
        Me.ProductID.Name = "ProductID"
        Me.ProductID.ReadOnly = True
        Me.ProductID.Visible = False
        '
        'UomID
        '
        Me.UomID.HeaderText = "UOM ID"
        Me.UomID.Name = "UomID"
        Me.UomID.ReadOnly = True
        Me.UomID.Visible = False
        '
        'VCode
        '
        Me.VCode.HeaderText = "Product Code"
        Me.VCode.Name = "VCode"
        Me.VCode.ReadOnly = True
        '
        'VName
        '
        Me.VName.HeaderText = "Description"
        Me.VName.Name = "VName"
        Me.VName.ReadOnly = True
        Me.VName.Width = 300
        '
        'UOM
        '
        Me.UOM.HeaderText = "UOM"
        Me.UOM.Name = "UOM"
        Me.UOM.ReadOnly = True
        Me.UOM.Width = 80
        '
        'DQty
        '
        Me.DQty.HeaderText = "Issue Qty"
        Me.DQty.Name = "DQty"
        Me.DQty.ReadOnly = True
        Me.DQty.Width = 80
        '
        'PendingQty
        '
        Me.PendingQty.HeaderText = "Pending Qty"
        Me.PendingQty.Name = "PendingQty"
        Me.PendingQty.ReadOnly = True
        '
        'UsedQty
        '
        Me.UsedQty.HeaderText = "Used Qty"
        Me.UsedQty.Name = "UsedQty"
        Me.UsedQty.Visible = False
        Me.UsedQty.Width = 80
        '
        'VRate
        '
        Me.VRate.HeaderText = "Rate"
        Me.VRate.Name = "VRate"
        Me.VRate.Visible = False
        Me.VRate.Width = 80
        '
        'Quantity
        '
        Me.Quantity.HeaderText = "Return Qty"
        Me.Quantity.Name = "Quantity"
        '
        'StockID
        '
        Me.StockID.HeaderText = "StockID"
        Me.StockID.Name = "StockID"
        Me.StockID.Visible = False
        '
        'StockType
        '
        Me.StockType.HeaderText = "StockType"
        Me.StockType.Name = "StockType"
        Me.StockType.Visible = False
        '
        'VTypePk
        '
        Me.VTypePk.HeaderText = "VTypePK"
        Me.VTypePk.Name = "VTypePk"
        Me.VTypePk.Visible = False
        '
        'Del
        '
        Me.Del.HeaderText = "Del"
        Me.Del.Image = Global.WinBusiness.My.Resources.Resources.icExitForm
        Me.Del.Name = "Del"
        Me.Del.ReadOnly = True
        Me.Del.Width = 50
        '
        'IsDel
        '
        Me.IsDel.HeaderText = "IsDel"
        Me.IsDel.Name = "IsDel"
        Me.IsDel.ReadOnly = True
        Me.IsDel.Visible = False
        '
        'grdGL
        '
        Me.grdGL.AllowUserToAddRows = False
        Me.grdGL.AllowUserToDeleteRows = False
        Me.grdGL.AllowUserToOrderColumns = True
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.grdGL.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
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
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.grdAtt.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle3
        Me.grdAtt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdAtt.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdAtt.Location = New System.Drawing.Point(0, 0)
        Me.grdAtt.Name = "grdAtt"
        Me.grdAtt.RowHeadersVisible = False
        Me.grdAtt.Size = New System.Drawing.Size(882, 403)
        Me.grdAtt.TabIndex = 0
        '
        'dtFDateFrom
        '
        Me.dtFDateFrom.CustomFormat = "dd/MM/yyyy"
        Me.dtFDateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtFDateFrom.Location = New System.Drawing.Point(367, 11)
        Me.dtFDateFrom.Name = "dtFDateFrom"
        Me.dtFDateFrom.Size = New System.Drawing.Size(104, 20)
        Me.dtFDateFrom.TabIndex = 5
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(54, 42)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(58, 13)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Remarks:"
        '
        'Label14
        '
        Me.Label14.Location = New System.Drawing.Point(294, 15)
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
        Me.Label15.Size = New System.Drawing.Size(87, 13)
        Me.Label15.TabIndex = 0
        Me.Label15.Text = "Issue Return No:"
        '
        'txtFRemarks
        '
        Me.txtFRemarks.Location = New System.Drawing.Point(116, 39)
        Me.txtFRemarks.Name = "txtFRemarks"
        Me.txtFRemarks.Size = New System.Drawing.Size(551, 20)
        Me.txtFRemarks.TabIndex = 9
        '
        'txtFVNo
        '
        Me.txtFVNo.Location = New System.Drawing.Point(116, 11)
        Me.txtFVNo.Name = "txtFVNo"
        Me.txtFVNo.Size = New System.Drawing.Size(162, 20)
        Me.txtFVNo.TabIndex = 1
        '
        'dtFDateTo
        '
        Me.dtFDateTo.CustomFormat = "dd/MM/yyyy"
        Me.dtFDateTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtFDateTo.Location = New System.Drawing.Point(563, 10)
        Me.dtFDateTo.Name = "dtFDateTo"
        Me.dtFDateTo.Size = New System.Drawing.Size(104, 20)
        Me.dtFDateTo.TabIndex = 7
        '
        'Label16
        '
        Me.Label16.Location = New System.Drawing.Point(490, 14)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(67, 13)
        Me.Label16.TabIndex = 6
        Me.Label16.Text = "Date To:"
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(689, 39)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(75, 23)
        Me.btnSearch.TabIndex = 10
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'btnExcelExport
        '
        Me.btnExcelExport.Location = New System.Drawing.Point(785, 39)
        Me.btnExcelExport.Name = "btnExcelExport"
        Me.btnExcelExport.Size = New System.Drawing.Size(75, 23)
        Me.btnExcelExport.TabIndex = 12
        Me.btnExcelExport.Text = "&Excel Export"
        Me.btnExcelExport.UseVisualStyleBackColor = True
        '
        'frmInvIssueNoteReturn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(896, 523)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmInvIssueNoteReturn"
        Me.Text = "Issue Note Return"
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
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdGL, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdAtt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
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
    Friend WithEvents txtRemarks As RichTextBox
    Friend WithEvents txtVNo As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents dtpVDate As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents txtOrderNo As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txtIssueNo As TextBox
    Friend WithEvents lblIssueID As Label
    Friend WithEvents VID As DataGridViewTextBoxColumn
    Friend WithEvents ProductID As DataGridViewTextBoxColumn
    Friend WithEvents UomID As DataGridViewTextBoxColumn
    Friend WithEvents VCode As DataGridViewTextBoxColumn
    Friend WithEvents VName As DataGridViewTextBoxColumn
    Friend WithEvents UOM As DataGridViewTextBoxColumn
    Friend WithEvents DQty As DataGridViewTextBoxColumn
    Friend WithEvents PendingQty As DataGridViewTextBoxColumn
    Friend WithEvents UsedQty As DataGridViewTextBoxColumn
    Friend WithEvents VRate As DataGridViewTextBoxColumn
    Friend WithEvents Quantity As DataGridViewTextBoxColumn
    Friend WithEvents StockID As DataGridViewTextBoxColumn
    Friend WithEvents StockType As DataGridViewTextBoxColumn
    Friend WithEvents VTypePk As DataGridViewTextBoxColumn
    Friend WithEvents Del As DataGridViewImageColumn
    Friend WithEvents IsDel As DataGridViewTextBoxColumn
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnExcelExport As Button
End Class
