<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInvIssueNote1
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
        Me.lblEmpID = New System.Windows.Forms.Label()
        Me.txtEmpCode = New System.Windows.Forms.TextBox()
        Me.lblOrderID = New System.Windows.Forms.Label()
        Me.txtOrderNo = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.lblMDNID = New System.Windows.Forms.Label()
        Me.txtMDNNo = New System.Windows.Forms.TextBox()
        Me.cmbEmployee = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtRemarks = New System.Windows.Forms.RichTextBox()
        Me.cmbDepartment = New System.Windows.Forms.ComboBox()
        Me.txtVNo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtpVDate = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtRefNo = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.lblVID = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblVType = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txtAvailableQty = New System.Windows.Forms.TextBox()
        Me.txtProductName = New System.Windows.Forms.TextBox()
        Me.txtProductCode = New System.Windows.Forms.TextBox()
        Me.cmbUom = New System.Windows.Forms.ComboBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.cmbProductBatches = New System.Windows.Forms.ComboBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.lblPID = New System.Windows.Forms.Label()
        Me.lblDID = New System.Windows.Forms.Label()
        Me.txtQuantity = New System.Windows.Forms.TextBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.VID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BatchID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UOMID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VCode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UOM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AvailableQty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Quantity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VType = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DEL = New System.Windows.Forms.DataGridViewImageColumn()
        Me.IsDel = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblDebitSum = New System.Windows.Forms.Label()
        Me.lblCreditSum = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
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
        Me.lblHeading.Text = "Issue Note"
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
        Me.SplitContainer2.Panel1.Controls.Add(Me.lblEmpID)
        Me.SplitContainer2.Panel1.Controls.Add(Me.txtEmpCode)
        Me.SplitContainer2.Panel1.Controls.Add(Me.lblOrderID)
        Me.SplitContainer2.Panel1.Controls.Add(Me.txtOrderNo)
        Me.SplitContainer2.Panel1.Controls.Add(Me.Label18)
        Me.SplitContainer2.Panel1.Controls.Add(Me.lblMDNID)
        Me.SplitContainer2.Panel1.Controls.Add(Me.txtMDNNo)
        Me.SplitContainer2.Panel1.Controls.Add(Me.cmbEmployee)
        Me.SplitContainer2.Panel1.Controls.Add(Me.Label10)
        Me.SplitContainer2.Panel1.Controls.Add(Me.txtRemarks)
        Me.SplitContainer2.Panel1.Controls.Add(Me.cmbDepartment)
        Me.SplitContainer2.Panel1.Controls.Add(Me.txtVNo)
        Me.SplitContainer2.Panel1.Controls.Add(Me.Label1)
        Me.SplitContainer2.Panel1.Controls.Add(Me.Label2)
        Me.SplitContainer2.Panel1.Controls.Add(Me.dtpVDate)
        Me.SplitContainer2.Panel1.Controls.Add(Me.Label3)
        Me.SplitContainer2.Panel1.Controls.Add(Me.txtRefNo)
        Me.SplitContainer2.Panel1.Controls.Add(Me.Label5)
        Me.SplitContainer2.Panel1.Controls.Add(Me.Label4)
        Me.SplitContainer2.Panel1.Controls.Add(Me.Label17)
        Me.SplitContainer2.Panel1.Controls.Add(Me.lblVID)
        Me.SplitContainer2.Panel1.Controls.Add(Me.GroupBox1)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.DataGridView1)
        Me.SplitContainer2.Size = New System.Drawing.Size(953, 379)
        Me.SplitContainer2.SplitterDistance = 139
        Me.SplitContainer2.TabIndex = 0
        '
        'lblEmpID
        '
        Me.lblEmpID.AutoSize = True
        Me.lblEmpID.Location = New System.Drawing.Point(19, 44)
        Me.lblEmpID.Name = "lblEmpID"
        Me.lblEmpID.Size = New System.Drawing.Size(13, 13)
        Me.lblEmpID.TabIndex = 48
        Me.lblEmpID.Text = "0"
        Me.lblEmpID.Visible = False
        '
        'txtEmpCode
        '
        Me.txtEmpCode.Location = New System.Drawing.Point(94, 44)
        Me.txtEmpCode.MaxLength = 20
        Me.txtEmpCode.Name = "txtEmpCode"
        Me.txtEmpCode.ReadOnly = True
        Me.txtEmpCode.Size = New System.Drawing.Size(110, 20)
        Me.txtEmpCode.TabIndex = 4
        '
        'lblOrderID
        '
        Me.lblOrderID.AutoSize = True
        Me.lblOrderID.Location = New System.Drawing.Point(406, 49)
        Me.lblOrderID.Name = "lblOrderID"
        Me.lblOrderID.Size = New System.Drawing.Size(13, 13)
        Me.lblOrderID.TabIndex = 46
        Me.lblOrderID.Text = "0"
        Me.lblOrderID.Visible = False
        '
        'txtOrderNo
        '
        Me.txtOrderNo.Location = New System.Drawing.Point(482, 45)
        Me.txtOrderNo.MaxLength = 20
        Me.txtOrderNo.Name = "txtOrderNo"
        Me.txtOrderNo.ReadOnly = True
        Me.txtOrderNo.Size = New System.Drawing.Size(110, 20)
        Me.txtOrderNo.TabIndex = 6
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.ForeColor = System.Drawing.Color.Black
        Me.Label18.Location = New System.Drawing.Point(425, 49)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(50, 13)
        Me.Label18.TabIndex = 45
        Me.Label18.Text = "Order No"
        '
        'lblMDNID
        '
        Me.lblMDNID.AutoSize = True
        Me.lblMDNID.Location = New System.Drawing.Point(412, 7)
        Me.lblMDNID.Name = "lblMDNID"
        Me.lblMDNID.Size = New System.Drawing.Size(13, 13)
        Me.lblMDNID.TabIndex = 43
        Me.lblMDNID.Text = "0"
        Me.lblMDNID.Visible = False
        '
        'txtMDNNo
        '
        Me.txtMDNNo.Location = New System.Drawing.Point(482, 5)
        Me.txtMDNNo.MaxLength = 20
        Me.txtMDNNo.Name = "txtMDNNo"
        Me.txtMDNNo.ReadOnly = True
        Me.txtMDNNo.Size = New System.Drawing.Size(110, 20)
        Me.txtMDNNo.TabIndex = 2
        '
        'cmbEmployee
        '
        Me.cmbEmployee.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbEmployee.FormattingEnabled = True
        Me.cmbEmployee.Location = New System.Drawing.Point(892, 44)
        Me.cmbEmployee.Name = "cmbEmployee"
        Me.cmbEmployee.Size = New System.Drawing.Size(29, 21)
        Me.cmbEmployee.TabIndex = 4
        Me.cmbEmployee.Visible = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(35, 45)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(53, 13)
        Me.Label10.TabIndex = 33
        Me.Label10.Text = "Employee"
        '
        'txtRemarks
        '
        Me.txtRemarks.Location = New System.Drawing.Point(688, 38)
        Me.txtRemarks.Name = "txtRemarks"
        Me.txtRemarks.Size = New System.Drawing.Size(182, 36)
        Me.txtRemarks.TabIndex = 7
        Me.txtRemarks.Text = ""
        '
        'cmbDepartment
        '
        Me.cmbDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbDepartment.FormattingEnabled = True
        Me.cmbDepartment.Location = New System.Drawing.Point(688, 4)
        Me.cmbDepartment.Name = "cmbDepartment"
        Me.cmbDepartment.Size = New System.Drawing.Size(182, 21)
        Me.cmbDepartment.TabIndex = 3
        '
        'txtVNo
        '
        Me.txtVNo.Location = New System.Drawing.Point(94, 5)
        Me.txtVNo.MaxLength = 8
        Me.txtVNo.Name = "txtVNo"
        Me.txtVNo.ReadOnly = True
        Me.txtVNo.Size = New System.Drawing.Size(110, 20)
        Me.txtVNo.TabIndex = 0
        Me.txtVNo.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(633, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 31
        Me.Label1.Text = "Remarks"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(223, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 13)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "Issue Date"
        '
        'dtpVDate
        '
        Me.dtpVDate.CustomFormat = "dd/MM/yyyy"
        Me.dtpVDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpVDate.Location = New System.Drawing.Point(287, 5)
        Me.dtpVDate.Name = "dtpVDate"
        Me.dtpVDate.Size = New System.Drawing.Size(110, 20)
        Me.dtpVDate.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(34, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 13)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Issue No :"
        '
        'txtRefNo
        '
        Me.txtRefNo.Location = New System.Drawing.Point(287, 45)
        Me.txtRefNo.MaxLength = 20
        Me.txtRefNo.Name = "txtRefNo"
        Me.txtRefNo.Size = New System.Drawing.Size(110, 20)
        Me.txtRefNo.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(620, 8)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(62, 13)
        Me.Label5.TabIndex = 27
        Me.Label5.Text = "Cost Centre"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(431, 8)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 13)
        Me.Label4.TabIndex = 26
        Me.Label4.Text = "MDN No"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.ForeColor = System.Drawing.Color.Black
        Me.Label17.Location = New System.Drawing.Point(237, 45)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(44, 13)
        Me.Label17.TabIndex = 28
        Me.Label17.Text = "Ref. No"
        '
        'lblVID
        '
        Me.lblVID.AutoSize = True
        Me.lblVID.Location = New System.Drawing.Point(2, 3)
        Me.lblVID.Name = "lblVID"
        Me.lblVID.Size = New System.Drawing.Size(25, 13)
        Me.lblVID.TabIndex = 0
        Me.lblVID.Text = "VID"
        Me.lblVID.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblVType)
        Me.GroupBox1.Controls.Add(Me.Label20)
        Me.GroupBox1.Controls.Add(Me.txtAvailableQty)
        Me.GroupBox1.Controls.Add(Me.txtProductName)
        Me.GroupBox1.Controls.Add(Me.txtProductCode)
        Me.GroupBox1.Controls.Add(Me.cmbUom)
        Me.GroupBox1.Controls.Add(Me.Label19)
        Me.GroupBox1.Controls.Add(Me.cmbProductBatches)
        Me.GroupBox1.Controls.Add(Me.btnClear)
        Me.GroupBox1.Controls.Add(Me.lblPID)
        Me.GroupBox1.Controls.Add(Me.lblDID)
        Me.GroupBox1.Controls.Add(Me.txtQuantity)
        Me.GroupBox1.Controls.Add(Me.btnAdd)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 75)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(947, 56)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Detail"
        '
        'lblVType
        '
        Me.lblVType.AutoSize = True
        Me.lblVType.Location = New System.Drawing.Point(400, 12)
        Me.lblVType.Name = "lblVType"
        Me.lblVType.Size = New System.Drawing.Size(13, 13)
        Me.lblVType.TabIndex = 50
        Me.lblVType.Text = "0"
        Me.lblVType.Visible = False
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(650, 12)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(95, 13)
        Me.Label20.TabIndex = 49
        Me.Label20.Text = "Available Quantity:"
        '
        'txtAvailableQty
        '
        Me.txtAvailableQty.Location = New System.Drawing.Point(653, 28)
        Me.txtAvailableQty.MaxLength = 8
        Me.txtAvailableQty.Name = "txtAvailableQty"
        Me.txtAvailableQty.ReadOnly = True
        Me.txtAvailableQty.Size = New System.Drawing.Size(92, 20)
        Me.txtAvailableQty.TabIndex = 4
        Me.txtAvailableQty.TabStop = False
        '
        'txtProductName
        '
        Me.txtProductName.Location = New System.Drawing.Point(75, 28)
        Me.txtProductName.MaxLength = 8
        Me.txtProductName.Name = "txtProductName"
        Me.txtProductName.ReadOnly = True
        Me.txtProductName.Size = New System.Drawing.Size(91, 20)
        Me.txtProductName.TabIndex = 1
        Me.txtProductName.TabStop = False
        '
        'txtProductCode
        '
        Me.txtProductCode.Location = New System.Drawing.Point(18, 29)
        Me.txtProductCode.MaxLength = 8
        Me.txtProductCode.Name = "txtProductCode"
        Me.txtProductCode.ReadOnly = True
        Me.txtProductCode.Size = New System.Drawing.Size(51, 20)
        Me.txtProductCode.TabIndex = 0
        '
        'cmbUom
        '
        Me.cmbUom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbUom.FormattingEnabled = True
        Me.cmbUom.Location = New System.Drawing.Point(572, 28)
        Me.cmbUom.Name = "cmbUom"
        Me.cmbUom.Size = New System.Drawing.Size(75, 21)
        Me.cmbUom.TabIndex = 3
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(569, 12)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(35, 13)
        Me.Label19.TabIndex = 40
        Me.Label19.Text = "UOM:"
        '
        'cmbProductBatches
        '
        Me.cmbProductBatches.FormattingEnabled = True
        Me.cmbProductBatches.Location = New System.Drawing.Point(172, 28)
        Me.cmbProductBatches.Name = "cmbProductBatches"
        Me.cmbProductBatches.Size = New System.Drawing.Size(394, 21)
        Me.cmbProductBatches.TabIndex = 2
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(885, 29)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(48, 23)
        Me.btnClear.TabIndex = 7
        Me.btnClear.Text = "Cancel"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'lblPID
        '
        Me.lblPID.AutoSize = True
        Me.lblPID.Location = New System.Drawing.Point(96, 12)
        Me.lblPID.Name = "lblPID"
        Me.lblPID.Size = New System.Drawing.Size(25, 13)
        Me.lblPID.TabIndex = 36
        Me.lblPID.Text = "PID"
        Me.lblPID.Visible = False
        '
        'lblDID
        '
        Me.lblDID.AutoSize = True
        Me.lblDID.Location = New System.Drawing.Point(2, 27)
        Me.lblDID.Name = "lblDID"
        Me.lblDID.Size = New System.Drawing.Size(13, 13)
        Me.lblDID.TabIndex = 35
        Me.lblDID.Text = "0"
        Me.lblDID.Visible = False
        '
        'txtQuantity
        '
        Me.txtQuantity.Location = New System.Drawing.Point(757, 29)
        Me.txtQuantity.Name = "txtQuantity"
        Me.txtQuantity.Size = New System.Drawing.Size(73, 20)
        Me.txtQuantity.TabIndex = 5
        Me.txtQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(840, 29)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(39, 23)
        Me.btnAdd.TabIndex = 6
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(16, 13)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(47, 13)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Product:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(754, 13)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(49, 13)
        Me.Label9.TabIndex = 7
        Me.Label9.Text = "Quantity:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(169, 12)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(89, 13)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "Product Batches:"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.VID, Me.ProductID, Me.BatchID, Me.UOMID, Me.VCode, Me.ProductName, Me.VName, Me.UOM, Me.AvailableQty, Me.Quantity, Me.VType, Me.DEL, Me.IsDel})
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.Size = New System.Drawing.Size(953, 236)
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
        'BatchID
        '
        Me.BatchID.HeaderText = "BatchID"
        Me.BatchID.Name = "BatchID"
        Me.BatchID.ReadOnly = True
        Me.BatchID.Visible = False
        '
        'UOMID
        '
        Me.UOMID.HeaderText = "UOMID"
        Me.UOMID.Name = "UOMID"
        Me.UOMID.ReadOnly = True
        Me.UOMID.Visible = False
        '
        'VCode
        '
        Me.VCode.HeaderText = "Product Code"
        Me.VCode.Name = "VCode"
        Me.VCode.ReadOnly = True
        '
        'ProductName
        '
        Me.ProductName.HeaderText = "Product Name"
        Me.ProductName.Name = "ProductName"
        Me.ProductName.ReadOnly = True
        '
        'VName
        '
        Me.VName.HeaderText = "Product Batches"
        Me.VName.Name = "VName"
        Me.VName.ReadOnly = True
        Me.VName.Width = 350
        '
        'UOM
        '
        Me.UOM.HeaderText = "UOM"
        Me.UOM.Name = "UOM"
        Me.UOM.ReadOnly = True
        '
        'AvailableQty
        '
        Me.AvailableQty.HeaderText = "AvailableQty"
        Me.AvailableQty.Name = "AvailableQty"
        Me.AvailableQty.ReadOnly = True
        '
        'Quantity
        '
        Me.Quantity.HeaderText = "Quantity"
        Me.Quantity.Name = "Quantity"
        Me.Quantity.ReadOnly = True
        '
        'VType
        '
        Me.VType.HeaderText = "VType"
        Me.VType.Name = "VType"
        Me.VType.ReadOnly = True
        Me.VType.Visible = False
        '
        'DEL
        '
        Me.DEL.HeaderText = "DEL"
        Me.DEL.Image = Global.WinBusiness.My.Resources.Resources.icExitForm
        Me.DEL.Name = "DEL"
        Me.DEL.ReadOnly = True
        Me.DEL.Width = 50
        '
        'IsDel
        '
        Me.IsDel.HeaderText = "IsDel"
        Me.IsDel.Name = "IsDel"
        Me.IsDel.ReadOnly = True
        Me.IsDel.Visible = False
        '
        'lblDebitSum
        '
        Me.lblDebitSum.AutoSize = True
        Me.lblDebitSum.Location = New System.Drawing.Point(783, 6)
        Me.lblDebitSum.Name = "lblDebitSum"
        Me.lblDebitSum.Size = New System.Drawing.Size(13, 13)
        Me.lblDebitSum.TabIndex = 6
        Me.lblDebitSum.Text = "0"
        Me.lblDebitSum.Visible = False
        '
        'lblCreditSum
        '
        Me.lblCreditSum.AutoSize = True
        Me.lblCreditSum.Location = New System.Drawing.Point(919, 6)
        Me.lblCreditSum.Name = "lblCreditSum"
        Me.lblCreditSum.Size = New System.Drawing.Size(13, 13)
        Me.lblCreditSum.TabIndex = 8
        Me.lblCreditSum.Text = "0"
        Me.lblCreditSum.Visible = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(732, 6)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(51, 13)
        Me.Label11.TabIndex = 5
        Me.Label11.Text = "Total Dr: "
        Me.Label11.Visible = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(862, 6)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(50, 13)
        Me.Label12.TabIndex = 7
        Me.Label12.Text = "Total Cr: "
        Me.Label12.Visible = False
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
        Me.dtFDateFrom.Location = New System.Drawing.Point(460, 9)
        Me.dtFDateFrom.Name = "dtFDateFrom"
        Me.dtFDateFrom.Size = New System.Drawing.Size(104, 20)
        Me.dtFDateFrom.TabIndex = 5
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(23, 44)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(58, 13)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Remarks:"
        '
        'Label14
        '
        Me.Label14.Location = New System.Drawing.Point(387, 13)
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
        Me.Label15.Size = New System.Drawing.Size(52, 13)
        Me.Label15.TabIndex = 0
        Me.Label15.Text = "Issue No:"
        '
        'txtFRemarks
        '
        Me.txtFRemarks.Location = New System.Drawing.Point(83, 39)
        Me.txtFRemarks.Name = "txtFRemarks"
        Me.txtFRemarks.Size = New System.Drawing.Size(677, 20)
        Me.txtFRemarks.TabIndex = 9
        '
        'txtFVNo
        '
        Me.txtFVNo.Location = New System.Drawing.Point(83, 11)
        Me.txtFVNo.Name = "txtFVNo"
        Me.txtFVNo.Size = New System.Drawing.Size(223, 20)
        Me.txtFVNo.TabIndex = 1
        '
        'dtFDateTo
        '
        Me.dtFDateTo.CustomFormat = "dd/MM/yyyy"
        Me.dtFDateTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtFDateTo.Location = New System.Drawing.Point(656, 8)
        Me.dtFDateTo.Name = "dtFDateTo"
        Me.dtFDateTo.Size = New System.Drawing.Size(104, 20)
        Me.dtFDateTo.TabIndex = 7
        '
        'Label16
        '
        Me.Label16.Location = New System.Drawing.Point(583, 12)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(67, 13)
        Me.Label16.TabIndex = 6
        Me.Label16.Text = "Date To:"
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(795, 36)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(75, 23)
        Me.btnSearch.TabIndex = 10
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'frmInvIssueNote1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(967, 523)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmInvIssueNote1"
        Me.Text = "Issue Note"
        Me.TabMain.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
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
   Friend WithEvents Label7 As System.Windows.Forms.Label
   Friend WithEvents Label6 As System.Windows.Forms.Label
   Friend WithEvents Label9 As System.Windows.Forms.Label
   Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
   Friend WithEvents btnAdd As System.Windows.Forms.Button
   Friend WithEvents txtQuantity As System.Windows.Forms.TextBox
   Friend WithEvents lblDebitSum As System.Windows.Forms.Label
   Friend WithEvents Label12 As System.Windows.Forms.Label
   Friend WithEvents Label11 As System.Windows.Forms.Label
   Friend WithEvents lblCreditSum As System.Windows.Forms.Label
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
   Friend WithEvents cmbDepartment As ComboBox
   Friend WithEvents txtVNo As TextBox
   Friend WithEvents Label1 As Label
   Friend WithEvents Label2 As Label
   Friend WithEvents dtpVDate As DateTimePicker
   Friend WithEvents Label3 As Label
   Friend WithEvents txtRefNo As TextBox
   Friend WithEvents Label5 As Label
   Friend WithEvents Label4 As Label
   Friend WithEvents Label17 As Label
   Friend WithEvents lblDID As Label
   Friend WithEvents lblPID As Label
   Friend WithEvents btnClear As Button
   Friend WithEvents cmbEmployee As System.Windows.Forms.ComboBox
   Friend WithEvents Label10 As System.Windows.Forms.Label
   Friend WithEvents txtMDNNo As System.Windows.Forms.TextBox
   Friend WithEvents cmbProductBatches As System.Windows.Forms.ComboBox
   Friend WithEvents lblMDNID As System.Windows.Forms.Label
   Friend WithEvents txtOrderNo As System.Windows.Forms.TextBox
   Friend WithEvents Label18 As System.Windows.Forms.Label
   Friend WithEvents cmbUom As System.Windows.Forms.ComboBox
   Friend WithEvents Label19 As System.Windows.Forms.Label
   Friend WithEvents txtProductName As System.Windows.Forms.TextBox
   Friend WithEvents txtProductCode As System.Windows.Forms.TextBox
   Friend WithEvents Label20 As System.Windows.Forms.Label
   Friend WithEvents txtAvailableQty As System.Windows.Forms.TextBox
   Friend WithEvents lblVType As System.Windows.Forms.Label
   Friend WithEvents VID As System.Windows.Forms.DataGridViewTextBoxColumn
   Friend WithEvents ProductID As System.Windows.Forms.DataGridViewTextBoxColumn
   Friend WithEvents BatchID As System.Windows.Forms.DataGridViewTextBoxColumn
   Friend WithEvents UOMID As System.Windows.Forms.DataGridViewTextBoxColumn
   Friend WithEvents VCode As System.Windows.Forms.DataGridViewTextBoxColumn
   Friend WithEvents ProductName As System.Windows.Forms.DataGridViewTextBoxColumn
   Friend WithEvents VName As System.Windows.Forms.DataGridViewTextBoxColumn
   Friend WithEvents UOM As System.Windows.Forms.DataGridViewTextBoxColumn
   Friend WithEvents AvailableQty As System.Windows.Forms.DataGridViewTextBoxColumn
   Friend WithEvents Quantity As System.Windows.Forms.DataGridViewTextBoxColumn
   Friend WithEvents VType As System.Windows.Forms.DataGridViewTextBoxColumn
   Friend WithEvents DEL As System.Windows.Forms.DataGridViewImageColumn
   Friend WithEvents IsDel As System.Windows.Forms.DataGridViewTextBoxColumn
   Friend WithEvents lblOrderID As System.Windows.Forms.Label
    Friend WithEvents txtEmpCode As TextBox
    Friend WithEvents lblEmpID As Label
End Class
