<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInvStockLedger
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
      Me.optStockLedger = New System.Windows.Forms.RadioButton()
      Me.optSummaryValue = New System.Windows.Forms.RadioButton()
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
      Me.optActivitySummary = New System.Windows.Forms.RadioButton()
      Me.optProduction = New System.Windows.Forms.RadioButton()
      Me.optExpanseMW = New System.Windows.Forms.RadioButton()
      Me.Label9 = New System.Windows.Forms.Label()
      Me.Label13 = New System.Windows.Forms.Label()
      Me.Label10 = New System.Windows.Forms.Label()
      Me.dtpDateTo = New System.Windows.Forms.DateTimePicker()
      Me.txtCodeFrom = New System.Windows.Forms.TextBox()
      Me.txtVName = New System.Windows.Forms.TextBox()
      Me.Label6 = New System.Windows.Forms.Label()
      Me.txtCodeTo = New System.Windows.Forms.TextBox()
      Me.Label8 = New System.Windows.Forms.Label()
      Me.txtAccTitleTo = New System.Windows.Forms.TextBox()
      Me.Label11 = New System.Windows.Forms.Label()
      Me.txtAccTitleFrom = New System.Windows.Forms.TextBox()
      Me.Label12 = New System.Windows.Forms.Label()
      Me.Panel1 = New System.Windows.Forms.Panel()
      Me.lblPID = New System.Windows.Forms.Label()
      Me.optGRNB = New System.Windows.Forms.RadioButton()
      Me.optPurchaseAnalysis = New System.Windows.Forms.RadioButton()
      Me.optItemAging = New System.Windows.Forms.RadioButton() 
      Me.optYarnOGP = New System.Windows.Forms.RadioButton()
      Me.optFabricIGP = New System.Windows.Forms.RadioButton()
      Me.optFabricOGP = New System.Windows.Forms.RadioButton()
      Me.optFabricIGPDyeing = New System.Windows.Forms.RadioButton()
      Me.Panel2 = New System.Windows.Forms.Panel()
      Me.ListView1 = New System.Windows.Forms.ListView()
      Me.GroupBox1.SuspendLayout()
      Me.GBHeading.SuspendLayout()
      Me.GBFooter.SuspendLayout()
      Me.GBBody.SuspendLayout()
      Me.Panel1.SuspendLayout()
      Me.Panel2.SuspendLayout()
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
      'GBHeading
      '
      Me.GBHeading.Size = New System.Drawing.Size(595, 42)
      '
      'GBFooter
      '
      Me.GBFooter.Size = New System.Drawing.Size(595, 76)
      '
      'GBBody
      '
      Me.GBBody.Controls.Add(Me.Panel2)
      Me.GBBody.Controls.Add(Me.optFabricIGPDyeing)
      Me.GBBody.Controls.Add(Me.optFabricOGP)
      Me.GBBody.Controls.Add(Me.optFabricIGP)
      Me.GBBody.Controls.Add(Me.optYarnOGP)
      Me.GBBody.Controls.Add(Me.optGRNB)
      Me.GBBody.Controls.Add(Me.optPurchaseAnalysis)
      Me.GBBody.Controls.Add(Me.optItemAging)
      Me.GBBody.Controls.Add(Me.lblPID)
      Me.GBBody.Controls.Add(Me.Panel1)
      Me.GBBody.Controls.Add(Me.txtAccTitleTo)
      Me.GBBody.Controls.Add(Me.Label11)
      Me.GBBody.Controls.Add(Me.txtAccTitleFrom)
      Me.GBBody.Controls.Add(Me.Label12)
      Me.GBBody.Controls.Add(Me.txtCodeTo)
      Me.GBBody.Controls.Add(Me.Label8)
      Me.GBBody.Controls.Add(Me.Label6)
      Me.GBBody.Controls.Add(Me.txtVName)
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
      Me.GBBody.Controls.Add(Me.optActivitySummary)
      Me.GBBody.Controls.Add(Me.optProduction)
      Me.GBBody.Controls.Add(Me.optExpanseMW)
      Me.GBBody.Controls.Add(Me.Label1)
      Me.GBBody.Controls.Add(Me.dtpDateFrom)
      Me.GBBody.Controls.Add(Me.Label2)
      Me.GBBody.Controls.Add(Me.optSummaryValue)
      Me.GBBody.Controls.Add(Me.optStockLedger)
      Me.GBBody.Size = New System.Drawing.Size(595, 405)
      Me.GBBody.TabIndex = 0
      Me.GBBody.Controls.SetChildIndex(Me.optStockLedger, 0)
      Me.GBBody.Controls.SetChildIndex(Me.optSummaryValue, 0)
      Me.GBBody.Controls.SetChildIndex(Me.Label2, 0)
      Me.GBBody.Controls.SetChildIndex(Me.dtpDateFrom, 0)
      Me.GBBody.Controls.SetChildIndex(Me.Label1, 0)
      Me.GBBody.Controls.SetChildIndex(Me.optExpanseMW, 0)
      Me.GBBody.Controls.SetChildIndex(Me.optProduction, 0)
      Me.GBBody.Controls.SetChildIndex(Me.optActivitySummary, 0)
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
      Me.GBBody.Controls.SetChildIndex(Me.txtVName, 0)
      Me.GBBody.Controls.SetChildIndex(Me.Label6, 0)
      Me.GBBody.Controls.SetChildIndex(Me.Label8, 0)
      Me.GBBody.Controls.SetChildIndex(Me.txtCodeTo, 0)
      Me.GBBody.Controls.SetChildIndex(Me.Label12, 0)
      Me.GBBody.Controls.SetChildIndex(Me.txtAccTitleFrom, 0)
      Me.GBBody.Controls.SetChildIndex(Me.Label11, 0)
      Me.GBBody.Controls.SetChildIndex(Me.txtAccTitleTo, 0)
      Me.GBBody.Controls.SetChildIndex(Me.GroupBox1, 0)
      Me.GBBody.Controls.SetChildIndex(Me.Panel1, 0)
      Me.GBBody.Controls.SetChildIndex(Me.lblPID, 0)
      Me.GBBody.Controls.SetChildIndex(Me.optItemAging, 0)
      Me.GBBody.Controls.SetChildIndex(Me.optPurchaseAnalysis, 0)
      Me.GBBody.Controls.SetChildIndex(Me.optGRNB, 0)
      Me.GBBody.Controls.SetChildIndex(Me.optYarnOGP, 0)
      Me.GBBody.Controls.SetChildIndex(Me.optFabricIGP, 0)
      Me.GBBody.Controls.SetChildIndex(Me.optFabricOGP, 0)
      Me.GBBody.Controls.SetChildIndex(Me.optFabricIGPDyeing, 0)
      Me.GBBody.Controls.SetChildIndex(Me.Panel2, 0)
      '
      'lblHeading
      '
      Me.lblHeading.Size = New System.Drawing.Size(595, 42)
      Me.lblHeading.Text = "Stock Detail Reports"
      '
      'optStockLedger
      '
      Me.optStockLedger.AutoSize = True
      Me.optStockLedger.Checked = True
      Me.optStockLedger.Location = New System.Drawing.Point(29, 137)
      Me.optStockLedger.Name = "optStockLedger"
      Me.optStockLedger.Size = New System.Drawing.Size(89, 17)
      Me.optStockLedger.TabIndex = 7
      Me.optStockLedger.TabStop = True
      Me.optStockLedger.Text = "Stock Ledger"
      Me.optStockLedger.UseVisualStyleBackColor = True
      '
      'optSummaryValue
      '
      Me.optSummaryValue.AutoSize = True
      Me.optSummaryValue.Location = New System.Drawing.Point(391, 137)
      Me.optSummaryValue.Name = "optSummaryValue"
      Me.optSummaryValue.Size = New System.Drawing.Size(158, 17)
      Me.optSummaryValue.TabIndex = 9
      Me.optSummaryValue.Text = "Item Activity Summary Value"
      Me.optSummaryValue.UseVisualStyleBackColor = True
      '
      'Label2
      '
      Me.Label2.AutoSize = True
      Me.Label2.ForeColor = System.Drawing.Color.Black
      Me.Label2.Location = New System.Drawing.Point(85, 67)
      Me.Label2.Name = "Label2"
      Me.Label2.Size = New System.Drawing.Size(44, 13)
      Me.Label2.TabIndex = 4
      Me.Label2.Text = "Product"
      Me.Label2.Visible = False
      '
      'dtpDateFrom
      '
      Me.dtpDateFrom.CustomFormat = "dd/MM/yyyy"
      Me.dtpDateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
      Me.dtpDateFrom.Location = New System.Drawing.Point(135, 39)
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
      Me.optUnPosted.Location = New System.Drawing.Point(409, 3)
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
      Me.optProductionDW.Location = New System.Drawing.Point(210, 265)
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
      Me.Label7.Location = New System.Drawing.Point(23, 314)
      Me.Label7.Name = "Label7"
      Me.Label7.Size = New System.Drawing.Size(550, 3)
      Me.Label7.TabIndex = 25
      Me.Label7.Visible = False
      '
      'Label5
      '
      Me.Label5.BackColor = System.Drawing.Color.LightGray
      Me.Label5.Location = New System.Drawing.Point(23, 286)
      Me.Label5.Name = "Label5"
      Me.Label5.Size = New System.Drawing.Size(550, 3)
      Me.Label5.TabIndex = 22
      Me.Label5.Visible = False
      '
      'Label4
      '
      Me.Label4.BackColor = System.Drawing.Color.LightGray
      Me.Label4.Location = New System.Drawing.Point(21, 215)
      Me.Label4.Name = "Label4"
      Me.Label4.Size = New System.Drawing.Size(550, 3)
      Me.Label4.TabIndex = 18
      '
      'optReceivableBalance
      '
      Me.optReceivableBalance.AutoSize = True
      Me.optReceivableBalance.Enabled = False
      Me.optReceivableBalance.Location = New System.Drawing.Point(210, 293)
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
      Me.optLeaveSummary.Location = New System.Drawing.Point(393, 266)
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
      Me.Label3.Location = New System.Drawing.Point(21, 189)
      Me.Label3.Name = "Label3"
      Me.Label3.Size = New System.Drawing.Size(550, 3)
      Me.Label3.TabIndex = 14
      '
      'optActivitySummary
      '
      Me.optActivitySummary.AutoSize = True
      Me.optActivitySummary.Location = New System.Drawing.Point(208, 137)
      Me.optActivitySummary.Name = "optActivitySummary"
      Me.optActivitySummary.Size = New System.Drawing.Size(128, 17)
      Me.optActivitySummary.TabIndex = 8
      Me.optActivitySummary.Text = "Item Activity Summary"
      Me.optActivitySummary.UseVisualStyleBackColor = True
      '
      'optProduction
      '
      Me.optProduction.AutoSize = True
      Me.optProduction.Enabled = False
      Me.optProduction.Location = New System.Drawing.Point(32, 265)
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
      Me.optExpanseMW.Location = New System.Drawing.Point(32, 294)
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
      Me.Label13.Location = New System.Drawing.Point(73, 39)
      Me.Label13.Name = "Label13"
      Me.Label13.Size = New System.Drawing.Size(56, 13)
      Me.Label13.TabIndex = 0
      Me.Label13.Text = "Date From"
      '
      'Label10
      '
      Me.Label10.AutoSize = True
      Me.Label10.ForeColor = System.Drawing.Color.Black
      Me.Label10.Location = New System.Drawing.Point(83, 65)
      Me.Label10.Name = "Label10"
      Me.Label10.Size = New System.Drawing.Size(46, 13)
      Me.Label10.TabIndex = 2
      Me.Label10.Text = "Date To"
      '
      'dtpDateTo
      '
      Me.dtpDateTo.CustomFormat = "dd/MM/yyyy"
      Me.dtpDateTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
      Me.dtpDateTo.Location = New System.Drawing.Point(135, 65)
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
      'txtVName
      '
      Me.txtVName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
      Me.txtVName.Location = New System.Drawing.Point(135, 111)
      Me.txtVName.MaxLength = 200
      Me.txtVName.Name = "txtVName"
      Me.txtVName.Size = New System.Drawing.Size(119, 20)
      Me.txtVName.TabIndex = 6
      Me.txtVName.Visible = False
      '
      'Label6
      '
      Me.Label6.AutoSize = True
      Me.Label6.ForeColor = System.Drawing.Color.Black
      Me.Label6.Location = New System.Drawing.Point(80, 118)
      Me.Label6.Name = "Label6"
      Me.Label6.Size = New System.Drawing.Size(49, 13)
      Me.Label6.TabIndex = 8
      Me.Label6.Text = "Remarks"
      Me.Label6.Visible = False
      '
      'txtCodeTo
      '
      Me.txtCodeTo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
      Me.txtCodeTo.Enabled = False
      Me.txtCodeTo.Location = New System.Drawing.Point(391, 64)
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
      Me.Label8.Location = New System.Drawing.Point(275, 39)
      Me.Label8.Name = "Label8"
      Me.Label8.Size = New System.Drawing.Size(97, 13)
      Me.Label8.TabIndex = 6
      Me.Label8.Text = "Product Categories"
      '
      'txtAccTitleTo
      '
      Me.txtAccTitleTo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
      Me.txtAccTitleTo.Enabled = False
      Me.txtAccTitleTo.Location = New System.Drawing.Point(391, 90)
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
      Me.Label11.Location = New System.Drawing.Point(294, 93)
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
      Me.txtAccTitleFrom.Location = New System.Drawing.Point(135, 90)
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
      Me.Label12.Location = New System.Drawing.Point(28, 93)
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
      Me.Panel1.Location = New System.Drawing.Point(24, 195)
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
      'optGRNB
      '
      Me.optGRNB.AutoSize = True
      Me.optGRNB.Location = New System.Drawing.Point(391, 160)
      Me.optGRNB.Name = "optGRNB"
      Me.optGRNB.Size = New System.Drawing.Size(94, 17)
      Me.optGRNB.TabIndex = 41
      Me.optGRNB.Text = "GRN-B Report"
      Me.optGRNB.UseVisualStyleBackColor = True
      '
      'optPurchaseAnalysis
      '
      Me.optPurchaseAnalysis.AutoSize = True
      Me.optPurchaseAnalysis.Location = New System.Drawing.Point(208, 160)
      Me.optPurchaseAnalysis.Name = "optPurchaseAnalysis"
      Me.optPurchaseAnalysis.Size = New System.Drawing.Size(146, 17)
      Me.optPurchaseAnalysis.TabIndex = 40
      Me.optPurchaseAnalysis.Text = "Purchase Analysis Report"
      Me.optPurchaseAnalysis.UseVisualStyleBackColor = True
      '
      'optItemAging
      '
      Me.optItemAging.AutoSize = True
      Me.optItemAging.Location = New System.Drawing.Point(29, 160)
      Me.optItemAging.Name = "optItemAging"
      Me.optItemAging.Size = New System.Drawing.Size(110, 17)
      Me.optItemAging.TabIndex = 39
      Me.optItemAging.Text = "Item Aging Report"
      Me.optItemAging.UseVisualStyleBackColor = True
      '
      'optYarnOGP
      '
      Me.optYarnOGP.AutoSize = True
      Me.optYarnOGP.Location = New System.Drawing.Point(29, 220)
      Me.optYarnOGP.Name = "optYarnOGP"
      Me.optYarnOGP.Size = New System.Drawing.Size(126, 17)
      Me.optYarnOGP.TabIndex = 42
      Me.optYarnOGP.Text = "Yarn OGP Date Wise"
      Me.optYarnOGP.UseVisualStyleBackColor = True
      '
      'optFabricIGP
      '
      Me.optFabricIGP.AutoSize = True
      Me.optFabricIGP.Location = New System.Drawing.Point(208, 221)
      Me.optFabricIGP.Name = "optFabricIGP"
      Me.optFabricIGP.Size = New System.Drawing.Size(128, 17)
      Me.optFabricIGP.TabIndex = 43
      Me.optFabricIGP.Text = "Fabric IGP Date Wise"
      Me.optFabricIGP.UseVisualStyleBackColor = True
      '
      'optFabricOGP
      '
      Me.optFabricOGP.AutoSize = True
      Me.optFabricOGP.Location = New System.Drawing.Point(391, 221)
      Me.optFabricOGP.Name = "optFabricOGP"
      Me.optFabricOGP.Size = New System.Drawing.Size(133, 17)
      Me.optFabricOGP.TabIndex = 44
      Me.optFabricOGP.Text = "Fabric OGP Date Wise"
      Me.optFabricOGP.UseVisualStyleBackColor = True
      '
      'optFabricIGPDyeing
      '
      Me.optFabricIGPDyeing.AutoSize = True
      Me.optFabricIGPDyeing.Location = New System.Drawing.Point(29, 243)
      Me.optFabricIGPDyeing.Name = "optFabricIGPDyeing"
      Me.optFabricIGPDyeing.Size = New System.Drawing.Size(174, 17)
      Me.optFabricIGPDyeing.TabIndex = 45
      Me.optFabricIGPDyeing.Text = "Fabric IGP after Dye Date Wise"
      Me.optFabricIGPDyeing.UseVisualStyleBackColor = True
      '
      'Panel2
      '
      Me.Panel2.Controls.Add(Me.ListView1)
      Me.Panel2.Location = New System.Drawing.Point(378, 41)
      Me.Panel2.Name = "Panel2"
      Me.Panel2.Size = New System.Drawing.Size(171, 90)
      Me.Panel2.TabIndex = 46
      '
      'ListView1
      '
      Me.ListView1.CheckBoxes = True
      Me.ListView1.Dock = System.Windows.Forms.DockStyle.Fill
      Me.ListView1.Location = New System.Drawing.Point(0, 0)
      Me.ListView1.Name = "ListView1"
      Me.ListView1.Size = New System.Drawing.Size(171, 90)
      Me.ListView1.TabIndex = 3
      Me.ListView1.UseCompatibleStateImageBehavior = False
      Me.ListView1.View = System.Windows.Forms.View.List
      '
      'frmInvStockLedger
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.ClientSize = New System.Drawing.Size(595, 523)
      Me.Margin = New System.Windows.Forms.Padding(5)
      Me.MaximizeBox = False
      Me.Name = "frmInvStockLedger"
      Me.Text = "Stock Detail Reports"
      Me.GroupBox1.ResumeLayout(False)
      Me.GroupBox1.PerformLayout()
      Me.GBHeading.ResumeLayout(False)
      Me.GBFooter.ResumeLayout(False)
      Me.GBBody.ResumeLayout(False)
      Me.GBBody.PerformLayout()
      Me.Panel1.ResumeLayout(False)
      Me.Panel1.PerformLayout()
      Me.Panel2.ResumeLayout(False)
      Me.ResumeLayout(False)

   End Sub
    Friend WithEvents optStockLedger As System.Windows.Forms.RadioButton
   Friend WithEvents optSummaryValue As System.Windows.Forms.RadioButton
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
   Friend WithEvents optActivitySummary As System.Windows.Forms.RadioButton
   Friend WithEvents optProduction As System.Windows.Forms.RadioButton
   Friend WithEvents optExpanseMW As System.Windows.Forms.RadioButton
   Friend WithEvents Label9 As System.Windows.Forms.Label
   Friend WithEvents Label13 As System.Windows.Forms.Label
   Friend WithEvents Label6 As System.Windows.Forms.Label
   Friend WithEvents txtVName As System.Windows.Forms.TextBox
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
   Friend WithEvents optGRNB As System.Windows.Forms.RadioButton
   Friend WithEvents optPurchaseAnalysis As System.Windows.Forms.RadioButton
   Friend WithEvents optItemAging As System.Windows.Forms.RadioButton 
   Friend WithEvents optFabricIGPDyeing As System.Windows.Forms.RadioButton
   Friend WithEvents optFabricOGP As System.Windows.Forms.RadioButton
   Friend WithEvents optFabricIGP As System.Windows.Forms.RadioButton
   Friend WithEvents optYarnOGP As System.Windows.Forms.RadioButton
   Friend WithEvents Panel2 As System.Windows.Forms.Panel
   Friend WithEvents ListView1 As System.Windows.Forms.ListView
End Class
