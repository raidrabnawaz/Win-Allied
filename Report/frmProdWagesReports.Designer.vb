<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProdWagesReports
   Inherits WinBaseForms.GUIBaseFormReport

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
        Me.optOrderWorkDetail = New System.Windows.Forms.RadioButton()
        Me.optWagesSheet = New System.Windows.Forms.RadioButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtpDateFrom = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.optPosted = New System.Windows.Forms.RadioButton()
        Me.optUnPosted = New System.Windows.Forms.RadioButton()
        Me.optProductionDW = New System.Windows.Forms.RadioButton()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.optReceivableBalance = New System.Windows.Forms.RadioButton()
        Me.optAll = New System.Windows.Forms.RadioButton()
        Me.optLeaveSummary = New System.Windows.Forms.RadioButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.optWorkerWages = New System.Windows.Forms.RadioButton()
        Me.optProduction = New System.Windows.Forms.RadioButton()
        Me.optExpanseMW = New System.Windows.Forms.RadioButton()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.dtpDateTo = New System.Windows.Forms.DateTimePicker()
        Me.txtCodeFrom = New System.Windows.Forms.TextBox()
        Me.txtEmpName = New System.Windows.Forms.TextBox()
        Me.txtCodeTo = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtAccTitleTo = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtAccTitleFrom = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblPID = New System.Windows.Forms.Label()
        Me.optOperationsRateList = New System.Windows.Forms.RadioButton()
        Me.txtSaleOrderName = New System.Windows.Forms.TextBox()
        Me.lblOrderID = New System.Windows.Forms.Label()
        Me.txtOrderCode = New System.Windows.Forms.TextBox()
        Me.cmbWagesMonth = New System.Windows.Forms.ComboBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.optDemandRequisition = New System.Windows.Forms.RadioButton()
        Me.GroupBox1.SuspendLayout()
        Me.GBHeading.SuspendLayout()
        Me.GBFooter.SuspendLayout()
        Me.GBBody.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdClose
        '
        Me.cmdClose.TabIndex = 1
        '
        'cmdSearch
        '
        Me.cmdSearch.TabIndex = 0
        Me.cmdSearch.Text = "V&iew"
        '
        'GroupBox1
        '
        Me.GroupBox1.TabIndex = 29
        '
        'txtTitle
        '
        Me.txtTitle.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTitle.TabIndex = 1
        '
        'Label16
        '
        Me.Label16.TabIndex = 0
        '
        'GBBody
        '
        Me.GBBody.Controls.Add(Me.optDemandRequisition)
        Me.GBBody.Controls.Add(Me.cmbWagesMonth)
        Me.GBBody.Controls.Add(Me.Label14)
        Me.GBBody.Controls.Add(Me.txtOrderCode)
        Me.GBBody.Controls.Add(Me.lblOrderID)
        Me.GBBody.Controls.Add(Me.txtSaleOrderName)
        Me.GBBody.Controls.Add(Me.optOperationsRateList)
        Me.GBBody.Controls.Add(Me.lblPID)
        Me.GBBody.Controls.Add(Me.Panel1)
        Me.GBBody.Controls.Add(Me.txtAccTitleTo)
        Me.GBBody.Controls.Add(Me.Label11)
        Me.GBBody.Controls.Add(Me.txtAccTitleFrom)
        Me.GBBody.Controls.Add(Me.Label12)
        Me.GBBody.Controls.Add(Me.txtCodeTo)
        Me.GBBody.Controls.Add(Me.Label8)
        Me.GBBody.Controls.Add(Me.txtEmpName)
        Me.GBBody.Controls.Add(Me.txtCodeFrom)
        Me.GBBody.Controls.Add(Me.Label10)
        Me.GBBody.Controls.Add(Me.dtpDateTo)
        Me.GBBody.Controls.Add(Me.Label13)
        Me.GBBody.Controls.Add(Me.Label9)
        Me.GBBody.Controls.Add(Me.optProductionDW)
        Me.GBBody.Controls.Add(Me.Label7)
        Me.GBBody.Controls.Add(Me.Label5)
        Me.GBBody.Controls.Add(Me.Label4)
        Me.GBBody.Controls.Add(Me.optReceivableBalance)
        Me.GBBody.Controls.Add(Me.optLeaveSummary)
        Me.GBBody.Controls.Add(Me.Label3)
        Me.GBBody.Controls.Add(Me.optWorkerWages)
        Me.GBBody.Controls.Add(Me.optProduction)
        Me.GBBody.Controls.Add(Me.optExpanseMW)
        Me.GBBody.Controls.Add(Me.Label1)
        Me.GBBody.Controls.Add(Me.dtpDateFrom)
        Me.GBBody.Controls.Add(Me.Label2)
        Me.GBBody.Controls.Add(Me.optWagesSheet)
        Me.GBBody.Controls.Add(Me.optOrderWorkDetail)
        Me.GBBody.TabIndex = 0
        Me.GBBody.Controls.SetChildIndex(Me.optOrderWorkDetail, 0)
        Me.GBBody.Controls.SetChildIndex(Me.optWagesSheet, 0)
        Me.GBBody.Controls.SetChildIndex(Me.Label2, 0)
        Me.GBBody.Controls.SetChildIndex(Me.dtpDateFrom, 0)
        Me.GBBody.Controls.SetChildIndex(Me.Label1, 0)
        Me.GBBody.Controls.SetChildIndex(Me.optExpanseMW, 0)
        Me.GBBody.Controls.SetChildIndex(Me.optProduction, 0)
        Me.GBBody.Controls.SetChildIndex(Me.optWorkerWages, 0)
        Me.GBBody.Controls.SetChildIndex(Me.Label3, 0)
        Me.GBBody.Controls.SetChildIndex(Me.optLeaveSummary, 0)
        Me.GBBody.Controls.SetChildIndex(Me.optReceivableBalance, 0)
        Me.GBBody.Controls.SetChildIndex(Me.Label4, 0)
        Me.GBBody.Controls.SetChildIndex(Me.Label5, 0)
        Me.GBBody.Controls.SetChildIndex(Me.Label7, 0)
        Me.GBBody.Controls.SetChildIndex(Me.optProductionDW, 0)
        Me.GBBody.Controls.SetChildIndex(Me.Label9, 0)
        Me.GBBody.Controls.SetChildIndex(Me.Label13, 0)
        Me.GBBody.Controls.SetChildIndex(Me.dtpDateTo, 0)
        Me.GBBody.Controls.SetChildIndex(Me.Label10, 0)
        Me.GBBody.Controls.SetChildIndex(Me.txtCodeFrom, 0)
        Me.GBBody.Controls.SetChildIndex(Me.txtEmpName, 0)
        Me.GBBody.Controls.SetChildIndex(Me.Label8, 0)
        Me.GBBody.Controls.SetChildIndex(Me.txtCodeTo, 0)
        Me.GBBody.Controls.SetChildIndex(Me.Label12, 0)
        Me.GBBody.Controls.SetChildIndex(Me.txtAccTitleFrom, 0)
        Me.GBBody.Controls.SetChildIndex(Me.Label11, 0)
        Me.GBBody.Controls.SetChildIndex(Me.txtAccTitleTo, 0)
        Me.GBBody.Controls.SetChildIndex(Me.GroupBox1, 0)
        Me.GBBody.Controls.SetChildIndex(Me.Panel1, 0)
        Me.GBBody.Controls.SetChildIndex(Me.lblPID, 0)
        Me.GBBody.Controls.SetChildIndex(Me.optOperationsRateList, 0)
        Me.GBBody.Controls.SetChildIndex(Me.txtSaleOrderName, 0)
        Me.GBBody.Controls.SetChildIndex(Me.lblOrderID, 0)
        Me.GBBody.Controls.SetChildIndex(Me.txtOrderCode, 0)
        Me.GBBody.Controls.SetChildIndex(Me.Label14, 0)
        Me.GBBody.Controls.SetChildIndex(Me.cmbWagesMonth, 0)
        Me.GBBody.Controls.SetChildIndex(Me.optDemandRequisition, 0)
        '
        'lblHeading
        '
        Me.lblHeading.Text = "Wages Reports"
        '
        'optOrderWorkDetail
        '
        Me.optOrderWorkDetail.AutoSize = True
        Me.optOrderWorkDetail.Checked = True
        Me.optOrderWorkDetail.Location = New System.Drawing.Point(29, 137)
        Me.optOrderWorkDetail.Name = "optOrderWorkDetail"
        Me.optOrderWorkDetail.Size = New System.Drawing.Size(137, 17)
        Me.optOrderWorkDetail.TabIndex = 7
        Me.optOrderWorkDetail.TabStop = True
        Me.optOrderWorkDetail.Text = "Order Wise Work Detail"
        Me.optOrderWorkDetail.UseVisualStyleBackColor = True
        '
        'optWagesSheet
        '
        Me.optWagesSheet.AutoSize = True
        Me.optWagesSheet.Location = New System.Drawing.Point(313, 138)
        Me.optWagesSheet.Name = "optWagesSheet"
        Me.optWagesSheet.Size = New System.Drawing.Size(90, 17)
        Me.optWagesSheet.TabIndex = 9
        Me.optWagesSheet.Text = "Wages Sheet"
        Me.optWagesSheet.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(78, 87)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Employee"
        '
        'dtpDateFrom
        '
        Me.dtpDateFrom.CustomFormat = "dd/MM/yyyy"
        Me.dtpDateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDateFrom.Location = New System.Drawing.Point(137, 58)
        Me.dtpDateFrom.Name = "dtpDateFrom"
        Me.dtpDateFrom.Size = New System.Drawing.Size(118, 20)
        Me.dtpDateFrom.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.LightGray
        Me.Label1.Location = New System.Drawing.Point(21, 132)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(550, 3)
        Me.Label1.TabIndex = 10
        '
        'optPosted
        '
        Me.optPosted.AutoSize = True
        Me.optPosted.Enabled = False
        Me.optPosted.Location = New System.Drawing.Point(231, 3)
        Me.optPosted.Name = "optPosted"
        Me.optPosted.Size = New System.Drawing.Size(58, 17)
        Me.optPosted.TabIndex = 1
        Me.optPosted.Text = "Posted"
        Me.optPosted.UseVisualStyleBackColor = True
        Me.optPosted.Visible = False
        '
        'optUnPosted
        '
        Me.optUnPosted.AutoSize = True
        Me.optUnPosted.Enabled = False
        Me.optUnPosted.Location = New System.Drawing.Point(409, 0)
        Me.optUnPosted.Name = "optUnPosted"
        Me.optUnPosted.Size = New System.Drawing.Size(75, 17)
        Me.optUnPosted.TabIndex = 2
        Me.optUnPosted.Text = "Un Posted"
        Me.optUnPosted.UseVisualStyleBackColor = True
        Me.optUnPosted.Visible = False
        '
        'optProductionDW
        '
        Me.optProductionDW.AutoSize = True
        Me.optProductionDW.Enabled = False
        Me.optProductionDW.Location = New System.Drawing.Point(210, 246)
        Me.optProductionDW.Name = "optProductionDW"
        Me.optProductionDW.Size = New System.Drawing.Size(126, 17)
        Me.optProductionDW.TabIndex = 7
        Me.optProductionDW.Text = "Date wise Production"
        Me.optProductionDW.UseVisualStyleBackColor = True
        Me.optProductionDW.Visible = False
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.LightGray
        Me.Label7.Location = New System.Drawing.Point(23, 295)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(550, 3)
        Me.Label7.TabIndex = 25
        Me.Label7.Visible = False
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.LightGray
        Me.Label5.Location = New System.Drawing.Point(23, 267)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(550, 3)
        Me.Label5.TabIndex = 22
        Me.Label5.Visible = False
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.LightGray
        Me.Label4.Location = New System.Drawing.Point(21, 189)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(550, 3)
        Me.Label4.TabIndex = 18
        '
        'optReceivableBalance
        '
        Me.optReceivableBalance.AutoSize = True
        Me.optReceivableBalance.Enabled = False
        Me.optReceivableBalance.Location = New System.Drawing.Point(210, 274)
        Me.optReceivableBalance.Name = "optReceivableBalance"
        Me.optReceivableBalance.Size = New System.Drawing.Size(156, 17)
        Me.optReceivableBalance.TabIndex = 10
        Me.optReceivableBalance.Text = "Receivable Balance Report"
        Me.optReceivableBalance.UseVisualStyleBackColor = True
        Me.optReceivableBalance.Visible = False
        '
        'optAll
        '
        Me.optAll.AutoSize = True
        Me.optAll.Checked = True
        Me.optAll.Location = New System.Drawing.Point(5, 0)
        Me.optAll.Name = "optAll"
        Me.optAll.Size = New System.Drawing.Size(36, 17)
        Me.optAll.TabIndex = 0
        Me.optAll.TabStop = True
        Me.optAll.Text = "All"
        Me.optAll.UseVisualStyleBackColor = True
        Me.optAll.Visible = False
        '
        'optLeaveSummary
        '
        Me.optLeaveSummary.AutoSize = True
        Me.optLeaveSummary.Enabled = False
        Me.optLeaveSummary.Location = New System.Drawing.Point(393, 247)
        Me.optLeaveSummary.Name = "optLeaveSummary"
        Me.optLeaveSummary.Size = New System.Drawing.Size(28, 17)
        Me.optLeaveSummary.TabIndex = 8
        Me.optLeaveSummary.Text = "-"
        Me.optLeaveSummary.UseVisualStyleBackColor = True
        Me.optLeaveSummary.Visible = False
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.LightGray
        Me.Label3.Location = New System.Drawing.Point(21, 163)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(550, 3)
        Me.Label3.TabIndex = 14
        '
        'optWorkerWages
        '
        Me.optWorkerWages.AutoSize = True
        Me.optWorkerWages.Location = New System.Drawing.Point(189, 138)
        Me.optWorkerWages.Name = "optWorkerWages"
        Me.optWorkerWages.Size = New System.Drawing.Size(97, 17)
        Me.optWorkerWages.TabIndex = 8
        Me.optWorkerWages.Text = "Worker Wages"
        Me.optWorkerWages.UseVisualStyleBackColor = True
        '
        'optProduction
        '
        Me.optProduction.AutoSize = True
        Me.optProduction.Enabled = False
        Me.optProduction.Location = New System.Drawing.Point(32, 246)
        Me.optProduction.Name = "optProduction"
        Me.optProduction.Size = New System.Drawing.Size(111, 17)
        Me.optProduction.TabIndex = 6
        Me.optProduction.Text = "Production Details"
        Me.optProduction.UseVisualStyleBackColor = True
        Me.optProduction.Visible = False
        '
        'optExpanseMW
        '
        Me.optExpanseMW.AutoSize = True
        Me.optExpanseMW.Enabled = False
        Me.optExpanseMW.Location = New System.Drawing.Point(32, 275)
        Me.optExpanseMW.Name = "optExpanseMW"
        Me.optExpanseMW.Size = New System.Drawing.Size(123, 17)
        Me.optExpanseMW.TabIndex = 9
        Me.optExpanseMW.Text = "Month wise Expanse"
        Me.optExpanseMW.UseVisualStyleBackColor = True
        Me.optExpanseMW.Visible = False
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.LightGray
        Me.Label9.Location = New System.Drawing.Point(23, 324)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(550, 3)
        Me.Label9.TabIndex = 26
        Me.Label9.Visible = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(75, 58)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(56, 13)
        Me.Label13.TabIndex = 0
        Me.Label13.Text = "Date From"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(341, 58)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(46, 13)
        Me.Label10.TabIndex = 2
        Me.Label10.Text = "Date To"
        '
        'dtpDateTo
        '
        Me.dtpDateTo.CustomFormat = "dd/MM/yyyy"
        Me.dtpDateTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDateTo.Location = New System.Drawing.Point(393, 58)
        Me.dtpDateTo.Name = "dtpDateTo"
        Me.dtpDateTo.Size = New System.Drawing.Size(118, 20)
        Me.dtpDateTo.TabIndex = 1
        '
        'txtCodeFrom
        '
        Me.txtCodeFrom.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodeFrom.Location = New System.Drawing.Point(255, 6)
        Me.txtCodeFrom.MaxLength = 7
        Me.txtCodeFrom.Name = "txtCodeFrom"
        Me.txtCodeFrom.Size = New System.Drawing.Size(118, 20)
        Me.txtCodeFrom.TabIndex = 2
        Me.txtCodeFrom.Visible = False
        '
        'txtEmpName
        '
        Me.txtEmpName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtEmpName.Location = New System.Drawing.Point(136, 84)
        Me.txtEmpName.MaxLength = 200
        Me.txtEmpName.Name = "txtEmpName"
        Me.txtEmpName.ReadOnly = True
        Me.txtEmpName.Size = New System.Drawing.Size(119, 20)
        Me.txtEmpName.TabIndex = 6
        '
        'txtCodeTo
        '
        Me.txtCodeTo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodeTo.Enabled = False
        Me.txtCodeTo.Location = New System.Drawing.Point(393, 6)
        Me.txtCodeTo.MaxLength = 7
        Me.txtCodeTo.Name = "txtCodeTo"
        Me.txtCodeTo.Size = New System.Drawing.Size(118, 20)
        Me.txtCodeTo.TabIndex = 3
        Me.txtCodeTo.Visible = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(330, 86)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(57, 13)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "Sale Order"
        '
        'txtAccTitleTo
        '
        Me.txtAccTitleTo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtAccTitleTo.Enabled = False
        Me.txtAccTitleTo.Location = New System.Drawing.Point(393, 109)
        Me.txtAccTitleTo.MaxLength = 7
        Me.txtAccTitleTo.Name = "txtAccTitleTo"
        Me.txtAccTitleTo.Size = New System.Drawing.Size(118, 20)
        Me.txtAccTitleTo.TabIndex = 5
        Me.txtAccTitleTo.Visible = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(296, 112)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(86, 13)
        Me.Label11.TabIndex = 32
        Me.Label11.Text = "Account Title To"
        Me.Label11.Visible = False
        '
        'txtAccTitleFrom
        '
        Me.txtAccTitleFrom.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtAccTitleFrom.Enabled = False
        Me.txtAccTitleFrom.Location = New System.Drawing.Point(137, 109)
        Me.txtAccTitleFrom.MaxLength = 7
        Me.txtAccTitleFrom.Name = "txtAccTitleFrom"
        Me.txtAccTitleFrom.Size = New System.Drawing.Size(118, 20)
        Me.txtAccTitleFrom.TabIndex = 4
        Me.txtAccTitleFrom.Visible = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(30, 112)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(96, 13)
        Me.Label12.TabIndex = 30
        Me.Label12.Text = "Account Title From"
        Me.Label12.Visible = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.optAll)
        Me.Panel1.Controls.Add(Me.optPosted)
        Me.Panel1.Controls.Add(Me.optUnPosted)
        Me.Panel1.Location = New System.Drawing.Point(29, 195)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(487, 19)
        Me.Panel1.TabIndex = 34
        '
        'lblPID
        '
        Me.lblPID.AutoSize = True
        Me.lblPID.ForeColor = System.Drawing.Color.Black
        Me.lblPID.Location = New System.Drawing.Point(12, 14)
        Me.lblPID.Name = "lblPID"
        Me.lblPID.Size = New System.Drawing.Size(0, 13)
        Me.lblPID.TabIndex = 35
        Me.lblPID.Visible = False
        '
        'optOperationsRateList
        '
        Me.optOperationsRateList.AutoSize = True
        Me.optOperationsRateList.Location = New System.Drawing.Point(421, 137)
        Me.optOperationsRateList.Name = "optOperationsRateList"
        Me.optOperationsRateList.Size = New System.Drawing.Size(116, 17)
        Me.optOperationsRateList.TabIndex = 36
        Me.optOperationsRateList.Text = "Operation Rate List"
        Me.optOperationsRateList.UseVisualStyleBackColor = True
        '
        'txtSaleOrderName
        '
        Me.txtSaleOrderName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSaleOrderName.Location = New System.Drawing.Point(392, 83)
        Me.txtSaleOrderName.MaxLength = 7
        Me.txtSaleOrderName.Name = "txtSaleOrderName"
        Me.txtSaleOrderName.ReadOnly = True
        Me.txtSaleOrderName.Size = New System.Drawing.Size(118, 20)
        Me.txtSaleOrderName.TabIndex = 37
        '
        'lblOrderID
        '
        Me.lblOrderID.AutoSize = True
        Me.lblOrderID.ForeColor = System.Drawing.Color.Black
        Me.lblOrderID.Location = New System.Drawing.Point(49, 13)
        Me.lblOrderID.Name = "lblOrderID"
        Me.lblOrderID.Size = New System.Drawing.Size(0, 13)
        Me.lblOrderID.TabIndex = 38
        Me.lblOrderID.Visible = False
        '
        'txtOrderCode
        '
        Me.txtOrderCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtOrderCode.Enabled = False
        Me.txtOrderCode.Location = New System.Drawing.Point(131, 6)
        Me.txtOrderCode.MaxLength = 7
        Me.txtOrderCode.Name = "txtOrderCode"
        Me.txtOrderCode.Size = New System.Drawing.Size(118, 20)
        Me.txtOrderCode.TabIndex = 39
        Me.txtOrderCode.Visible = False
        '
        'cmbWagesMonth
        '
        Me.cmbWagesMonth.FormattingEnabled = True
        Me.cmbWagesMonth.Location = New System.Drawing.Point(137, 31)
        Me.cmbWagesMonth.Name = "cmbWagesMonth"
        Me.cmbWagesMonth.Size = New System.Drawing.Size(173, 21)
        Me.cmbWagesMonth.TabIndex = 41
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(62, 34)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(69, 13)
        Me.Label14.TabIndex = 40
        Me.Label14.Text = "Wage Month"
        '
        'optDemandRequisition
        '
        Me.optDemandRequisition.AutoSize = True
        Me.optDemandRequisition.Location = New System.Drawing.Point(29, 169)
        Me.optDemandRequisition.Name = "optDemandRequisition"
        Me.optDemandRequisition.Size = New System.Drawing.Size(120, 17)
        Me.optDemandRequisition.TabIndex = 42
        Me.optDemandRequisition.Text = "Demand Requisition"
        Me.optDemandRequisition.UseVisualStyleBackColor = True
        '
        'frmProdWagesReports
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(594, 523)
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.MaximizeBox = False
        Me.Name = "frmProdWagesReports"
        Me.Text = "Wages Reports"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GBHeading.ResumeLayout(False)
        Me.GBFooter.ResumeLayout(False)
        Me.GBBody.ResumeLayout(False)
        Me.GBBody.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents optOrderWorkDetail As System.Windows.Forms.RadioButton
   Friend WithEvents optWagesSheet As System.Windows.Forms.RadioButton
   Friend WithEvents Label2 As System.Windows.Forms.Label
   Friend WithEvents dtpDateFrom As System.Windows.Forms.DateTimePicker
   Friend WithEvents Label1 As System.Windows.Forms.Label
   Friend WithEvents optPosted As System.Windows.Forms.RadioButton
   Friend WithEvents optUnPosted As System.Windows.Forms.RadioButton
   Friend WithEvents optProductionDW As System.Windows.Forms.RadioButton
   Friend WithEvents Label7 As System.Windows.Forms.Label
   Friend WithEvents Label5 As System.Windows.Forms.Label
   Friend WithEvents Label4 As System.Windows.Forms.Label
   Friend WithEvents optReceivableBalance As System.Windows.Forms.RadioButton
   Friend WithEvents optAll As System.Windows.Forms.RadioButton
   Friend WithEvents optLeaveSummary As System.Windows.Forms.RadioButton
   Friend WithEvents Label3 As System.Windows.Forms.Label
   Friend WithEvents optWorkerWages As System.Windows.Forms.RadioButton
   Friend WithEvents optProduction As System.Windows.Forms.RadioButton
   Friend WithEvents optExpanseMW As System.Windows.Forms.RadioButton
   Friend WithEvents Label9 As System.Windows.Forms.Label
   Friend WithEvents Label13 As System.Windows.Forms.Label
   Friend WithEvents txtEmpName As System.Windows.Forms.TextBox
   Friend WithEvents txtCodeFrom As System.Windows.Forms.TextBox
   Friend WithEvents Label10 As System.Windows.Forms.Label
   Friend WithEvents dtpDateTo As System.Windows.Forms.DateTimePicker
   Friend WithEvents txtCodeTo As System.Windows.Forms.TextBox
   Friend WithEvents Label8 As System.Windows.Forms.Label
   Friend WithEvents txtAccTitleTo As TextBox
   Friend WithEvents Label11 As Label
   Friend WithEvents txtAccTitleFrom As TextBox
   Friend WithEvents Label12 As Label
   Friend WithEvents Panel1 As Panel
   Friend WithEvents lblPID As System.Windows.Forms.Label
   Friend WithEvents optOperationsRateList As System.Windows.Forms.RadioButton
   Friend WithEvents txtSaleOrderName As System.Windows.Forms.TextBox
   Friend WithEvents lblOrderID As System.Windows.Forms.Label
   Friend WithEvents txtOrderCode As System.Windows.Forms.TextBox
   Friend WithEvents cmbWagesMonth As System.Windows.Forms.ComboBox
   Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents optDemandRequisition As RadioButton
End Class
