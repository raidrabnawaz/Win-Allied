<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmInvSupplier
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.lblAdvGLCode = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.lblSupplierGLID = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtSupplierGL = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtVCode = New System.Windows.Forms.TextBox()
        Me.txtCreditDays = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.cmbVType = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtFax = New System.Windows.Forms.TextBox()
        Me.txtPayTo = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.cmbPaymentTerm = New System.Windows.Forms.ComboBox()
        Me.txtPhoneNo = New System.Windows.Forms.TextBox()
        Me.txtBankDetail = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNTN = New System.Windows.Forms.TextBox()
        Me.txtSupAdvGLCode = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cmbCountry = New System.Windows.Forms.ComboBox()
        Me.txtCity = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtContactPerson = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtVName = New System.Windows.Forms.TextBox()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.grdRecord = New System.Windows.Forms.DataGridView()
        Me.lblInformation = New System.Windows.Forms.Label()
        Me.tctSupplierGL = New System.Windows.Forms.TextBox()
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
        Me.cmdSave.Location = New System.Drawing.Point(310, 6)
        '
        'cmdEdit
        '
        Me.cmdEdit.Location = New System.Drawing.Point(376, 6)
        '
        'cmdDelete
        '
        Me.cmdDelete.Location = New System.Drawing.Point(574, 6)
        '
        'cmdCancel
        '
        Me.cmdCancel.Location = New System.Drawing.Point(508, 6)
        '
        'cmdSearch
        '
        Me.cmdSearch.Location = New System.Drawing.Point(442, 6)
        '
        'cmdNew
        '
        Me.cmdNew.Location = New System.Drawing.Point(244, 6)
        Me.cmdNew.TabIndex = 0
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
        Me.lblHeading.Text = "Supplier Detail"
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
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblAdvGLCode)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label23)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label22)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label18)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label14)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label12)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblSupplierGLID)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label8)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtSupplierGL)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label4)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtVCode)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtCreditDays)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label21)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label20)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label19)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label17)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label16)
        Me.SplitContainer1.Panel1.Controls.Add(Me.cmbVType)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label9)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtFax)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtPayTo)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label13)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label15)
        Me.SplitContainer1.Panel1.Controls.Add(Me.cmbPaymentTerm)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtPhoneNo)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtBankDetail)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtNTN)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtSupAdvGLCode)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label5)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtEmail)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label6)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtAddress)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label7)
        Me.SplitContainer1.Panel1.Controls.Add(Me.cmbCountry)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtCity)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label11)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtContactPerson)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label10)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label3)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtVName)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtID)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.grdRecord)
        Me.SplitContainer1.Size = New System.Drawing.Size(961, 386)
        Me.SplitContainer1.SplitterDistance = 177
        Me.SplitContainer1.TabIndex = 0
        '
        'lblAdvGLCode
        '
        Me.lblAdvGLCode.AutoSize = True
        Me.lblAdvGLCode.ForeColor = System.Drawing.Color.Black
        Me.lblAdvGLCode.Location = New System.Drawing.Point(3, 108)
        Me.lblAdvGLCode.Name = "lblAdvGLCode"
        Me.lblAdvGLCode.Size = New System.Drawing.Size(16, 13)
        Me.lblAdvGLCode.TabIndex = 151
        Me.lblAdvGLCode.Text = " 0"
        Me.lblAdvGLCode.Visible = False
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.Black
        Me.Label23.Location = New System.Drawing.Point(288, 98)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(15, 20)
        Me.Label23.TabIndex = 150
        Me.Label23.Text = "*"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.Black
        Me.Label22.Location = New System.Drawing.Point(594, 39)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(15, 20)
        Me.Label22.TabIndex = 149
        Me.Label22.Text = "*"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Black
        Me.Label18.Location = New System.Drawing.Point(914, 5)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(15, 20)
        Me.Label18.TabIndex = 148
        Me.Label18.Text = "*"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(594, 7)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(15, 20)
        Me.Label14.TabIndex = 147
        Me.Label14.Text = "*"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(288, 9)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(15, 20)
        Me.Label12.TabIndex = 146
        Me.Label12.Text = "*"
        '
        'lblSupplierGLID
        '
        Me.lblSupplierGLID.AutoSize = True
        Me.lblSupplierGLID.ForeColor = System.Drawing.Color.Black
        Me.lblSupplierGLID.Location = New System.Drawing.Point(319, 65)
        Me.lblSupplierGLID.Name = "lblSupplierGLID"
        Me.lblSupplierGLID.Size = New System.Drawing.Size(16, 13)
        Me.lblSupplierGLID.TabIndex = 145
        Me.lblSupplierGLID.Text = " 0"
        Me.lblSupplierGLID.Visible = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(337, 65)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(90, 13)
        Me.Label8.TabIndex = 144
        Me.Label8.Text = "Supplier GL Code"
        '
        'txtSupplierGL
        '
        Me.txtSupplierGL.Location = New System.Drawing.Point(433, 62)
        Me.txtSupplierGL.MaxLength = 50
        Me.txtSupplierGL.Name = "txtSupplierGL"
        Me.txtSupplierGL.ReadOnly = True
        Me.txtSupplierGL.Size = New System.Drawing.Size(161, 20)
        Me.txtSupplierGL.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(689, 154)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 13)
        Me.Label4.TabIndex = 142
        Me.Label4.Text = "Supplier ID"
        Me.Label4.Visible = False
        '
        'txtVCode
        '
        Me.txtVCode.Location = New System.Drawing.Point(127, 6)
        Me.txtVCode.MaxLength = 50
        Me.txtVCode.Name = "txtVCode"
        Me.txtVCode.Size = New System.Drawing.Size(161, 20)
        Me.txtVCode.TabIndex = 1
        '
        'txtCreditDays
        '
        Me.txtCreditDays.Location = New System.Drawing.Point(433, 92)
        Me.txtCreditDays.Name = "txtCreditDays"
        Me.txtCreditDays.Size = New System.Drawing.Size(161, 20)
        Me.txtCreditDays.TabIndex = 11
        Me.txtCreditDays.Text = "0"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.ForeColor = System.Drawing.Color.Black
        Me.Label21.Location = New System.Drawing.Point(366, 95)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(61, 13)
        Me.Label21.TabIndex = 138
        Me.Label21.Text = "Credit Days"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.ForeColor = System.Drawing.Color.Black
        Me.Label20.Location = New System.Drawing.Point(403, 153)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(24, 13)
        Me.Label20.TabIndex = 137
        Me.Label20.Text = "Fax"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.ForeColor = System.Drawing.Color.Black
        Me.Label19.Location = New System.Drawing.Point(49, 126)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(73, 13)
        Me.Label19.TabIndex = 136
        Me.Label19.Text = "Supplier Bank"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.ForeColor = System.Drawing.Color.Black
        Me.Label17.Location = New System.Drawing.Point(700, 123)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(48, 13)
        Me.Label17.TabIndex = 134
        Me.Label17.Text = "Phone #"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.ForeColor = System.Drawing.Color.Black
        Me.Label16.Location = New System.Drawing.Point(90, 153)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(32, 13)
        Me.Label16.TabIndex = 133
        Me.Label16.Text = "Email"
        '
        'cmbVType
        '
        Me.cmbVType.BackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.cmbVType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbVType.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.cmbVType.FormattingEnabled = True
        Me.cmbVType.Items.AddRange(New Object() {"Local", "Import"})
        Me.cmbVType.Location = New System.Drawing.Point(127, 92)
        Me.cmbVType.Name = "cmbVType"
        Me.cmbVType.Size = New System.Drawing.Size(161, 24)
        Me.cmbVType.TabIndex = 10
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(381, 125)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(46, 13)
        Me.Label9.TabIndex = 130
        Me.Label9.Text = "N.T.N #"
        '
        'txtFax
        '
        Me.txtFax.Location = New System.Drawing.Point(433, 150)
        Me.txtFax.Name = "txtFax"
        Me.txtFax.Size = New System.Drawing.Size(161, 20)
        Me.txtFax.TabIndex = 17
        '
        'txtPayTo
        '
        Me.txtPayTo.Location = New System.Drawing.Point(753, 94)
        Me.txtPayTo.MaxLength = 50
        Me.txtPayTo.Name = "txtPayTo"
        Me.txtPayTo.Size = New System.Drawing.Size(161, 20)
        Me.txtPayTo.TabIndex = 12
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(706, 97)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(41, 13)
        Me.Label13.TabIndex = 128
        Me.Label13.Text = "Pay To"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.ForeColor = System.Drawing.Color.Black
        Me.Label15.Location = New System.Drawing.Point(77, 62)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(45, 13)
        Me.Label15.TabIndex = 124
        Me.Label15.Text = "Address"
        '
        'cmbPaymentTerm
        '
        Me.cmbPaymentTerm.BackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.cmbPaymentTerm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPaymentTerm.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.cmbPaymentTerm.FormattingEnabled = True
        Me.cmbPaymentTerm.Items.AddRange(New Object() {"ASSETS", "BANK", "BANK CHARGES", "BANK GUARANTEE", "CAPITAL", "CASH", "COLLECTION", "COS", "Cost of Short Term Financing", "CUSTOMER", "EQUITY", "EXPENSES", "FIXED ASSETS", "GENERAL", "INSURANCE", "INTERCOMPANY", "INTERUNITS-TRAN", "LC ACCOUNT", "LEASE", "LEASE FINANCIAL CHARGES", "LEASE LIABILITY", "LEASE SECURITY", "LIABILITIES", "LOANS", "MARKUP LIABILITY BANK", "PAYABLES", "PURCHASES", "RECEIVABLES", "REVENUE", "SHORT TERM FINANCING", "STOCK", "SUPPLIER", "TAXES"})
        Me.cmbPaymentTerm.Location = New System.Drawing.Point(753, 0)
        Me.cmbPaymentTerm.Name = "cmbPaymentTerm"
        Me.cmbPaymentTerm.Size = New System.Drawing.Size(161, 24)
        Me.cmbPaymentTerm.TabIndex = 3
        '
        'txtPhoneNo
        '
        Me.txtPhoneNo.Location = New System.Drawing.Point(753, 120)
        Me.txtPhoneNo.MaxLength = 50
        Me.txtPhoneNo.Name = "txtPhoneNo"
        Me.txtPhoneNo.Size = New System.Drawing.Size(161, 20)
        Me.txtPhoneNo.TabIndex = 15
        '
        'txtBankDetail
        '
        Me.txtBankDetail.Location = New System.Drawing.Point(127, 122)
        Me.txtBankDetail.Name = "txtBankDetail"
        Me.txtBankDetail.Size = New System.Drawing.Size(161, 20)
        Me.txtBankDetail.TabIndex = 13
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(13, 97)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(108, 13)
        Me.Label2.TabIndex = 119
        Me.Label2.Text = "Local/Import Supplier"
        '
        'txtNTN
        '
        Me.txtNTN.Location = New System.Drawing.Point(433, 122)
        Me.txtNTN.Name = "txtNTN"
        Me.txtNTN.Size = New System.Drawing.Size(161, 20)
        Me.txtNTN.TabIndex = 14
        '
        'txtSupAdvGLCode
        '
        Me.txtSupAdvGLCode.Location = New System.Drawing.Point(753, 59)
        Me.txtSupAdvGLCode.MaxLength = 50
        Me.txtSupAdvGLCode.Name = "txtSupAdvGLCode"
        Me.txtSupAdvGLCode.ReadOnly = True
        Me.txtSupAdvGLCode.Size = New System.Drawing.Size(161, 20)
        Me.txtSupAdvGLCode.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(639, 62)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(109, 13)
        Me.Label5.TabIndex = 117
        Me.Label5.Text = "Supplier Adv GLCode"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(127, 150)
        Me.txtEmail.MaxLength = 50
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(161, 20)
        Me.txtEmail.TabIndex = 16
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(41, 37)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 13)
        Me.Label6.TabIndex = 115
        Me.Label6.Text = "Contact Person"
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(127, 62)
        Me.txtAddress.MaxLength = 50
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(161, 20)
        Me.txtAddress.TabIndex = 7
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(379, 37)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(43, 13)
        Me.Label7.TabIndex = 113
        Me.Label7.Text = "Country"
        '
        'cmbCountry
        '
        Me.cmbCountry.BackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.cmbCountry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCountry.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.cmbCountry.FormattingEnabled = True
        Me.cmbCountry.Items.AddRange(New Object() {"ASSETS", "BANK", "BANK CHARGES", "BANK GUARANTEE", "CAPITAL", "CASH", "COLLECTION", "COS", "Cost of Short Term Financing", "CUSTOMER", "EQUITY", "EXPENSES", "FIXED ASSETS", "GENERAL", "INSURANCE", "INTERCOMPANY", "INTERUNITS-TRAN", "LC ACCOUNT", "LEASE", "LEASE FINANCIAL CHARGES", "LEASE LIABILITY", "LEASE SECURITY", "LIABILITIES", "LOANS", "MARKUP LIABILITY BANK", "PAYABLES", "PURCHASES", "RECEIVABLES", "REVENUE", "SHORT TERM FINANCING", "STOCK", "SUPPLIER", "TAXES"})
        Me.cmbCountry.Location = New System.Drawing.Point(433, 33)
        Me.cmbCountry.Name = "cmbCountry"
        Me.cmbCountry.Size = New System.Drawing.Size(161, 24)
        Me.cmbCountry.TabIndex = 5
        '
        'txtCity
        '
        Me.txtCity.Location = New System.Drawing.Point(753, 34)
        Me.txtCity.Name = "txtCity"
        Me.txtCity.Size = New System.Drawing.Size(161, 20)
        Me.txtCity.TabIndex = 6
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(346, 7)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(76, 13)
        Me.Label11.TabIndex = 108
        Me.Label11.Text = "Supplier Name"
        '
        'txtContactPerson
        '
        Me.txtContactPerson.Location = New System.Drawing.Point(127, 36)
        Me.txtContactPerson.MaxLength = 50
        Me.txtContactPerson.Name = "txtContactPerson"
        Me.txtContactPerson.Size = New System.Drawing.Size(161, 20)
        Me.txtContactPerson.TabIndex = 4
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(672, 6)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(75, 13)
        Me.Label10.TabIndex = 102
        Me.Label10.Text = "Payment Term"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(48, 11)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Supplier Code"
        '
        'txtVName
        '
        Me.txtVName.Location = New System.Drawing.Point(433, 4)
        Me.txtVName.MaxLength = 50
        Me.txtVName.Name = "txtVName"
        Me.txtVName.Size = New System.Drawing.Size(161, 20)
        Me.txtVName.TabIndex = 2
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(753, 150)
        Me.txtID.Name = "txtID"
        Me.txtID.ReadOnly = True
        Me.txtID.Size = New System.Drawing.Size(161, 20)
        Me.txtID.TabIndex = 0
        Me.txtID.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(723, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(24, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "City"
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
        Me.grdRecord.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdRecord.Location = New System.Drawing.Point(0, 0)
        Me.grdRecord.Name = "grdRecord"
        Me.grdRecord.ReadOnly = True
        Me.grdRecord.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grdRecord.Size = New System.Drawing.Size(961, 205)
        Me.grdRecord.TabIndex = 0
        '
        'lblInformation
        '
        Me.lblInformation.BackColor = System.Drawing.Color.Transparent
        Me.lblInformation.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInformation.ForeColor = System.Drawing.Color.Green
        Me.lblInformation.Location = New System.Drawing.Point(658, 26)
        Me.lblInformation.Name = "lblInformation"
        Me.lblInformation.Size = New System.Drawing.Size(309, 22)
        Me.lblInformation.TabIndex = 4
        Me.lblInformation.Text = "."
        '
        'tctSupplierGL
        '
        Me.tctSupplierGL.Location = New System.Drawing.Point(753, 62)
        Me.tctSupplierGL.MaxLength = 50
        Me.tctSupplierGL.Name = "tctSupplierGL"
        Me.tctSupplierGL.Size = New System.Drawing.Size(161, 20)
        Me.tctSupplierGL.TabIndex = 143
        '
        'frmInvSupplier
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(967, 523)
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "frmInvSupplier"
        Me.Text = "Suuplier Detail"
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
   Friend WithEvents Label4 As Label
   Friend WithEvents txtVCode As TextBox
   Friend WithEvents txtCreditDays As TextBox
   Friend WithEvents Label21 As Label
   Friend WithEvents Label20 As Label
   Friend WithEvents Label19 As Label
   Friend WithEvents Label17 As Label
   Friend WithEvents Label16 As Label
   Friend WithEvents cmbVType As ComboBox
   Friend WithEvents Label9 As Label
   Friend WithEvents txtFax As TextBox
   Friend WithEvents txtPayTo As TextBox
   Friend WithEvents Label13 As Label
   Friend WithEvents Label15 As Label
   Friend WithEvents cmbPaymentTerm As ComboBox
   Friend WithEvents txtPhoneNo As TextBox
   Friend WithEvents txtBankDetail As TextBox
   Friend WithEvents Label2 As Label
   Friend WithEvents txtNTN As TextBox
   Friend WithEvents txtSupAdvGLCode As TextBox
   Friend WithEvents Label5 As Label
   Friend WithEvents txtEmail As TextBox
   Friend WithEvents Label6 As Label
   Friend WithEvents txtAddress As TextBox
   Friend WithEvents Label7 As Label
   Friend WithEvents cmbCountry As ComboBox
   Friend WithEvents txtCity As TextBox
   Friend WithEvents Label11 As Label
   Friend WithEvents txtContactPerson As TextBox
   Friend WithEvents Label10 As Label
   Friend WithEvents Label3 As Label
   Friend WithEvents txtVName As TextBox
   Friend WithEvents txtID As TextBox
   Friend WithEvents Label1 As Label
   Friend WithEvents lblInformation As Label
   Friend WithEvents Label8 As System.Windows.Forms.Label
   Friend WithEvents txtSupplierGL As System.Windows.Forms.TextBox
   Friend WithEvents tctSupplierGL As System.Windows.Forms.TextBox
   Friend WithEvents lblSupplierGLID As System.Windows.Forms.Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label23 As Label
   Friend WithEvents Label22 As Label
   Friend WithEvents lblAdvGLCode As System.Windows.Forms.Label
End Class
