<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRptAccountsDetails
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.optGeneralLedger = New System.Windows.Forms.RadioButton()
        Me.optTrial = New System.Windows.Forms.RadioButton()
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
        Me.optLedgerWithFraction = New System.Windows.Forms.RadioButton()
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
        Me.lblAccountIDto = New System.Windows.Forms.Label()
        Me.lblAccountIDfrom = New System.Windows.Forms.Label()
        Me.cmbExcelExport = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.grdAtt = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GBHeading.SuspendLayout()
        Me.GBFooter.SuspendLayout()
        Me.GBBody.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.grdAtt, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'GBFooter
        '
        Me.GBFooter.Controls.Add(Me.Button1)
        Me.GBFooter.Controls.Add(Me.cmbExcelExport)
        Me.GBFooter.Controls.SetChildIndex(Me.cmbExcelExport, 0)
        Me.GBFooter.Controls.SetChildIndex(Me.cmdSearch, 0)
        Me.GBFooter.Controls.SetChildIndex(Me.cmdClose, 0)
        Me.GBFooter.Controls.SetChildIndex(Me.Button1, 0)
        '
        'GBBody
        '
        Me.GBBody.Controls.Add(Me.GroupBox2)
        Me.GBBody.Controls.Add(Me.lblAccountIDfrom)
        Me.GBBody.Controls.Add(Me.lblAccountIDto)
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
        Me.GBBody.Controls.Add(Me.optLedgerWithFraction)
        Me.GBBody.Controls.Add(Me.optProduction)
        Me.GBBody.Controls.Add(Me.optExpanseMW)
        Me.GBBody.Controls.Add(Me.Label1)
        Me.GBBody.Controls.Add(Me.dtpDateFrom)
        Me.GBBody.Controls.Add(Me.Label2)
        Me.GBBody.Controls.Add(Me.optTrial)
        Me.GBBody.Controls.Add(Me.optGeneralLedger)
        Me.GBBody.TabIndex = 0
        Me.GBBody.Controls.SetChildIndex(Me.optGeneralLedger, 0)
        Me.GBBody.Controls.SetChildIndex(Me.optTrial, 0)
        Me.GBBody.Controls.SetChildIndex(Me.Label2, 0)
        Me.GBBody.Controls.SetChildIndex(Me.dtpDateFrom, 0)
        Me.GBBody.Controls.SetChildIndex(Me.Label1, 0)
        Me.GBBody.Controls.SetChildIndex(Me.optExpanseMW, 0)
        Me.GBBody.Controls.SetChildIndex(Me.optProduction, 0)
        Me.GBBody.Controls.SetChildIndex(Me.optLedgerWithFraction, 0)
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
        Me.GBBody.Controls.SetChildIndex(Me.lblAccountIDto, 0)
        Me.GBBody.Controls.SetChildIndex(Me.lblAccountIDfrom, 0)
        Me.GBBody.Controls.SetChildIndex(Me.GroupBox2, 0)
        '
        'lblHeading
        '
        Me.lblHeading.Text = "Accounts Detail Reports"
        '
        'optGeneralLedger
        '
        Me.optGeneralLedger.AutoSize = True
        Me.optGeneralLedger.Checked = True
        Me.optGeneralLedger.Location = New System.Drawing.Point(29, 137)
        Me.optGeneralLedger.Name = "optGeneralLedger"
        Me.optGeneralLedger.Size = New System.Drawing.Size(98, 17)
        Me.optGeneralLedger.TabIndex = 7
        Me.optGeneralLedger.TabStop = True
        Me.optGeneralLedger.Text = "General Ledger"
        Me.optGeneralLedger.UseVisualStyleBackColor = True
        '
        'optTrial
        '
        Me.optTrial.AutoSize = True
        Me.optTrial.Location = New System.Drawing.Point(391, 137)
        Me.optTrial.Name = "optTrial"
        Me.optTrial.Size = New System.Drawing.Size(87, 17)
        Me.optTrial.TabIndex = 9
        Me.optTrial.Text = "Trial Balance"
        Me.optTrial.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(30, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Account Code From"
        '
        'dtpDateFrom
        '
        Me.dtpDateFrom.CustomFormat = "dd/MM/yyyy"
        Me.dtpDateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDateFrom.Location = New System.Drawing.Point(137, 16)
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
        Me.optPosted.Location = New System.Drawing.Point(8, 2)
        Me.optPosted.Name = "optPosted"
        Me.optPosted.Size = New System.Drawing.Size(58, 17)
        Me.optPosted.TabIndex = 0
        Me.optPosted.Text = "Posted"
        Me.optPosted.UseVisualStyleBackColor = True
        '
        'optUnPosted
        '
        Me.optUnPosted.AutoSize = True
        Me.optUnPosted.Location = New System.Drawing.Point(186, 2)
        Me.optUnPosted.Name = "optUnPosted"
        Me.optUnPosted.Size = New System.Drawing.Size(75, 17)
        Me.optUnPosted.TabIndex = 1
        Me.optUnPosted.Text = "Un Posted"
        Me.optUnPosted.UseVisualStyleBackColor = True
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
        Me.Label4.Location = New System.Drawing.Point(21, 184)
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
        Me.optAll.Location = New System.Drawing.Point(369, 3)
        Me.optAll.Name = "optAll"
        Me.optAll.Size = New System.Drawing.Size(36, 17)
        Me.optAll.TabIndex = 2
        Me.optAll.TabStop = True
        Me.optAll.Text = "All"
        Me.optAll.UseVisualStyleBackColor = True
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
        Me.Label3.Location = New System.Drawing.Point(21, 158)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(550, 3)
        Me.Label3.TabIndex = 14
        '
        'optLedgerWithFraction
        '
        Me.optLedgerWithFraction.AutoSize = True
        Me.optLedgerWithFraction.Location = New System.Drawing.Point(208, 137)
        Me.optLedgerWithFraction.Name = "optLedgerWithFraction"
        Me.optLedgerWithFraction.Size = New System.Drawing.Size(121, 17)
        Me.optLedgerWithFraction.TabIndex = 8
        Me.optLedgerWithFraction.Text = "Ledger with Fraction"
        Me.optLedgerWithFraction.UseVisualStyleBackColor = True
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
        Me.Label13.Location = New System.Drawing.Point(75, 16)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(56, 13)
        Me.Label13.TabIndex = 0
        Me.Label13.Text = "Date From"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(341, 16)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(46, 13)
        Me.Label10.TabIndex = 2
        Me.Label10.Text = "Date To"
        '
        'dtpDateTo
        '
        Me.dtpDateTo.CustomFormat = "dd/MM/yyyy"
        Me.dtpDateTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDateTo.Location = New System.Drawing.Point(393, 16)
        Me.dtpDateTo.Name = "dtpDateTo"
        Me.dtpDateTo.Size = New System.Drawing.Size(118, 20)
        Me.dtpDateTo.TabIndex = 1
        '
        'txtCodeFrom
        '
        Me.txtCodeFrom.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodeFrom.Location = New System.Drawing.Point(137, 41)
        Me.txtCodeFrom.MaxLength = 7
        Me.txtCodeFrom.Name = "txtCodeFrom"
        Me.txtCodeFrom.Size = New System.Drawing.Size(118, 20)
        Me.txtCodeFrom.TabIndex = 2
        '
        'txtVName
        '
        Me.txtVName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtVName.Location = New System.Drawing.Point(137, 93)
        Me.txtVName.MaxLength = 200
        Me.txtVName.Name = "txtVName"
        Me.txtVName.Size = New System.Drawing.Size(374, 20)
        Me.txtVName.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(82, 95)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 13)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Remarks"
        '
        'txtCodeTo
        '
        Me.txtCodeTo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodeTo.Location = New System.Drawing.Point(393, 41)
        Me.txtCodeTo.MaxLength = 7
        Me.txtCodeTo.Name = "txtCodeTo"
        Me.txtCodeTo.Size = New System.Drawing.Size(118, 20)
        Me.txtCodeTo.TabIndex = 3
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(296, 44)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(91, 13)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "Account Code To"
        '
        'txtAccTitleTo
        '
        Me.txtAccTitleTo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtAccTitleTo.Location = New System.Drawing.Point(393, 67)
        Me.txtAccTitleTo.MaxLength = 7
        Me.txtAccTitleTo.Name = "txtAccTitleTo"
        Me.txtAccTitleTo.Size = New System.Drawing.Size(118, 20)
        Me.txtAccTitleTo.TabIndex = 5
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(296, 70)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(86, 13)
        Me.Label11.TabIndex = 32
        Me.Label11.Text = "Account Title To"
        '
        'txtAccTitleFrom
        '
        Me.txtAccTitleFrom.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtAccTitleFrom.Location = New System.Drawing.Point(137, 67)
        Me.txtAccTitleFrom.MaxLength = 7
        Me.txtAccTitleFrom.Name = "txtAccTitleFrom"
        Me.txtAccTitleFrom.Size = New System.Drawing.Size(118, 20)
        Me.txtAccTitleFrom.TabIndex = 4
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(30, 70)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(96, 13)
        Me.Label12.TabIndex = 30
        Me.Label12.Text = "Account Title From"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.optAll)
        Me.Panel1.Controls.Add(Me.optPosted)
        Me.Panel1.Controls.Add(Me.optUnPosted)
        Me.Panel1.Location = New System.Drawing.Point(24, 164)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(487, 19)
        Me.Panel1.TabIndex = 34
        '
        'lblAccountIDto
        '
        Me.lblAccountIDto.AutoSize = True
        Me.lblAccountIDto.ForeColor = System.Drawing.Color.Black
        Me.lblAccountIDto.Location = New System.Drawing.Point(254, 215)
        Me.lblAccountIDto.Name = "lblAccountIDto"
        Me.lblAccountIDto.Size = New System.Drawing.Size(13, 13)
        Me.lblAccountIDto.TabIndex = 35
        Me.lblAccountIDto.Text = "0"
        Me.lblAccountIDto.Visible = False
        '
        'lblAccountIDfrom
        '
        Me.lblAccountIDfrom.AutoSize = True
        Me.lblAccountIDfrom.ForeColor = System.Drawing.Color.Black
        Me.lblAccountIDfrom.Location = New System.Drawing.Point(361, 215)
        Me.lblAccountIDfrom.Name = "lblAccountIDfrom"
        Me.lblAccountIDfrom.Size = New System.Drawing.Size(13, 13)
        Me.lblAccountIDfrom.TabIndex = 36
        Me.lblAccountIDfrom.Text = "0"
        Me.lblAccountIDfrom.Visible = False
        '
        'cmbExcelExport
        '
        Me.cmbExcelExport.BackColor = System.Drawing.Color.Transparent
        Me.cmbExcelExport.ForeColor = System.Drawing.Color.White
        Me.cmbExcelExport.Image = Global.WinBusiness.My.Resources.Resources.btn_blank
        Me.cmbExcelExport.Location = New System.Drawing.Point(369, 8)
        Me.cmbExcelExport.Name = "cmbExcelExport"
        Me.cmbExcelExport.Size = New System.Drawing.Size(66, 61)
        Me.cmbExcelExport.TabIndex = 2
        Me.cmbExcelExport.Text = "Export Ledger"
        Me.cmbExcelExport.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmbExcelExport.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.grdAtt)
        Me.GroupBox2.Location = New System.Drawing.Point(446, 207)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(148, 63)
        Me.GroupBox2.TabIndex = 37
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "GroupBox2"
        Me.GroupBox2.Visible = False
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
        Me.grdAtt.Location = New System.Drawing.Point(3, 16)
        Me.grdAtt.Name = "grdAtt"
        Me.grdAtt.RowHeadersVisible = False
        Me.grdAtt.Size = New System.Drawing.Size(142, 44)
        Me.grdAtt.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Image = Global.WinBusiness.My.Resources.Resources.btn_new
        Me.Button1.Location = New System.Drawing.Point(165, 8)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(66, 61)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "New"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button1.UseVisualStyleBackColor = False
        '
        'frmRptAccountsDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(594, 523)
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.MaximizeBox = False
        Me.Name = "frmRptAccountsDetails"
        Me.Text = "Accounts Detail Reports"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GBHeading.ResumeLayout(False)
        Me.GBFooter.ResumeLayout(False)
        Me.GBBody.ResumeLayout(False)
        Me.GBBody.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.grdAtt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents optGeneralLedger As System.Windows.Forms.RadioButton
   Friend WithEvents optTrial As System.Windows.Forms.RadioButton
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
   Friend WithEvents optLedgerWithFraction As System.Windows.Forms.RadioButton
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
   Friend WithEvents lblAccountIDfrom As System.Windows.Forms.Label
   Friend WithEvents lblAccountIDto As System.Windows.Forms.Label
   Friend WithEvents cmbExcelExport As System.Windows.Forms.Button
   Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
   Friend WithEvents grdAtt As System.Windows.Forms.DataGridView
    Friend WithEvents Button1 As Button
End Class
