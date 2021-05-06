<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCompany
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
      Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCompany))
      Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
      Me.GroupBox1 = New System.Windows.Forms.GroupBox()
      Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
      Me.PictureBox1 = New System.Windows.Forms.PictureBox()
      Me.cmdPictureUpload = New System.Windows.Forms.Button()
      Me.Label18 = New System.Windows.Forms.Label()
      Me.Label14 = New System.Windows.Forms.Label()
      Me.Label12 = New System.Windows.Forms.Label()
      Me.txtCompanyUrl = New System.Windows.Forms.TextBox()
      Me.txtRegistrationNo = New System.Windows.Forms.TextBox()
      Me.haveSalesTax = New System.Windows.Forms.CheckBox()
      Me.IsActive = New System.Windows.Forms.CheckBox()
      Me.haveVAT = New System.Windows.Forms.CheckBox()
      Me.txtSalesTaxPer = New System.Windows.Forms.TextBox()
      Me.Label8 = New System.Windows.Forms.Label()
      Me.Label4 = New System.Windows.Forms.Label()
      Me.txtVCode = New System.Windows.Forms.TextBox()
      Me.txtUANNo = New System.Windows.Forms.TextBox()
      Me.Label21 = New System.Windows.Forms.Label()
      Me.Label20 = New System.Windows.Forms.Label()
      Me.Label19 = New System.Windows.Forms.Label()
      Me.Label17 = New System.Windows.Forms.Label()
      Me.Label16 = New System.Windows.Forms.Label()
      Me.Label9 = New System.Windows.Forms.Label()
      Me.txtFax = New System.Windows.Forms.TextBox()
      Me.txtVATPer = New System.Windows.Forms.TextBox()
      Me.Label13 = New System.Windows.Forms.Label()
      Me.Label15 = New System.Windows.Forms.Label()
      Me.txtPhoneNo = New System.Windows.Forms.TextBox()
      Me.txtSalesTax = New System.Windows.Forms.TextBox()
      Me.Label2 = New System.Windows.Forms.Label()
      Me.txtNTN = New System.Windows.Forms.TextBox()
      Me.txtCNIC = New System.Windows.Forms.TextBox()
      Me.Label5 = New System.Windows.Forms.Label()
      Me.txtTimeZone = New System.Windows.Forms.TextBox()
      Me.Label6 = New System.Windows.Forms.Label()
      Me.txtAddress = New System.Windows.Forms.TextBox()
      Me.Label7 = New System.Windows.Forms.Label()
      Me.cmbCountry = New System.Windows.Forms.ComboBox()
      Me.txtCity = New System.Windows.Forms.TextBox()
      Me.Label11 = New System.Windows.Forms.Label()
      Me.txtDisplayUrl = New System.Windows.Forms.TextBox()
      Me.Label10 = New System.Windows.Forms.Label()
      Me.Label3 = New System.Windows.Forms.Label()
      Me.txtVName = New System.Windows.Forms.TextBox()
      Me.txtID = New System.Windows.Forms.TextBox()
      Me.Label1 = New System.Windows.Forms.Label()
      Me.grdRecord = New System.Windows.Forms.DataGridView()
      Me.lblInformation = New System.Windows.Forms.Label()
      Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
      Me.GBHeading.SuspendLayout()
      Me.GBFooter.SuspendLayout()
      Me.GBBody.SuspendLayout()
      Me.GroupBox1.SuspendLayout()
      CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.SplitContainer1.Panel1.SuspendLayout()
      Me.SplitContainer1.Panel2.SuspendLayout()
      Me.SplitContainer1.SuspendLayout()
      CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.grdRecord, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.SuspendLayout()
      '
      'cmdSave
      '
      Me.cmdSave.Location = New System.Drawing.Point(327, 6)
      '
      'cmdEdit
      '
      Me.cmdEdit.Location = New System.Drawing.Point(393, 6)
      '
      'cmdDelete
      '
      Me.cmdDelete.Location = New System.Drawing.Point(591, 6)
      '
      'cmdCancel
      '
      Me.cmdCancel.Location = New System.Drawing.Point(525, 6)
      '
      'cmdSearch
      '
      Me.cmdSearch.Location = New System.Drawing.Point(459, 6)
      '
      'cmdNew
      '
      Me.cmdNew.Location = New System.Drawing.Point(261, 6)
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
      Me.lblHeading.Text = "Company"
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
      Me.SplitContainer1.Panel1.Controls.Add(Me.PictureBox1)
      Me.SplitContainer1.Panel1.Controls.Add(Me.cmdPictureUpload)
      Me.SplitContainer1.Panel1.Controls.Add(Me.Label18)
      Me.SplitContainer1.Panel1.Controls.Add(Me.Label14)
      Me.SplitContainer1.Panel1.Controls.Add(Me.Label12)
      Me.SplitContainer1.Panel1.Controls.Add(Me.txtCompanyUrl)
      Me.SplitContainer1.Panel1.Controls.Add(Me.txtRegistrationNo)
      Me.SplitContainer1.Panel1.Controls.Add(Me.haveSalesTax)
      Me.SplitContainer1.Panel1.Controls.Add(Me.IsActive)
      Me.SplitContainer1.Panel1.Controls.Add(Me.haveVAT)
      Me.SplitContainer1.Panel1.Controls.Add(Me.txtSalesTaxPer)
      Me.SplitContainer1.Panel1.Controls.Add(Me.Label8)
      Me.SplitContainer1.Panel1.Controls.Add(Me.Label4)
      Me.SplitContainer1.Panel1.Controls.Add(Me.txtVCode)
      Me.SplitContainer1.Panel1.Controls.Add(Me.txtUANNo)
      Me.SplitContainer1.Panel1.Controls.Add(Me.Label21)
      Me.SplitContainer1.Panel1.Controls.Add(Me.Label20)
      Me.SplitContainer1.Panel1.Controls.Add(Me.Label19)
      Me.SplitContainer1.Panel1.Controls.Add(Me.Label17)
      Me.SplitContainer1.Panel1.Controls.Add(Me.Label16)
      Me.SplitContainer1.Panel1.Controls.Add(Me.Label9)
      Me.SplitContainer1.Panel1.Controls.Add(Me.txtFax)
      Me.SplitContainer1.Panel1.Controls.Add(Me.txtVATPer)
      Me.SplitContainer1.Panel1.Controls.Add(Me.Label13)
      Me.SplitContainer1.Panel1.Controls.Add(Me.Label15)
      Me.SplitContainer1.Panel1.Controls.Add(Me.txtPhoneNo)
      Me.SplitContainer1.Panel1.Controls.Add(Me.txtSalesTax)
      Me.SplitContainer1.Panel1.Controls.Add(Me.Label2)
      Me.SplitContainer1.Panel1.Controls.Add(Me.txtNTN)
      Me.SplitContainer1.Panel1.Controls.Add(Me.txtCNIC)
      Me.SplitContainer1.Panel1.Controls.Add(Me.Label5)
      Me.SplitContainer1.Panel1.Controls.Add(Me.txtTimeZone)
      Me.SplitContainer1.Panel1.Controls.Add(Me.Label6)
      Me.SplitContainer1.Panel1.Controls.Add(Me.txtAddress)
      Me.SplitContainer1.Panel1.Controls.Add(Me.Label7)
      Me.SplitContainer1.Panel1.Controls.Add(Me.cmbCountry)
      Me.SplitContainer1.Panel1.Controls.Add(Me.txtCity)
      Me.SplitContainer1.Panel1.Controls.Add(Me.Label11)
      Me.SplitContainer1.Panel1.Controls.Add(Me.txtDisplayUrl)
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
      Me.SplitContainer1.SplitterDistance = 214
      Me.SplitContainer1.TabIndex = 7
      '
      'PictureBox1
      '
      Me.PictureBox1.Location = New System.Drawing.Point(616, 155)
      Me.PictureBox1.Name = "PictureBox1"
      Me.PictureBox1.Size = New System.Drawing.Size(122, 56)
      Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
      Me.PictureBox1.TabIndex = 150
      Me.PictureBox1.TabStop = False
      '
      'cmdPictureUpload
      '
      Me.cmdPictureUpload.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.cmdPictureUpload.Image = CType(resources.GetObject("cmdPictureUpload.Image"), System.Drawing.Image)
      Me.cmdPictureUpload.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
      Me.cmdPictureUpload.Location = New System.Drawing.Point(744, 177)
      Me.cmdPictureUpload.Name = "cmdPictureUpload"
      Me.cmdPictureUpload.Size = New System.Drawing.Size(86, 30)
      Me.cmdPictureUpload.TabIndex = 149
      Me.cmdPictureUpload.Text = "Add Logo"
      Me.cmdPictureUpload.TextAlign = System.Drawing.ContentAlignment.MiddleRight
      Me.cmdPictureUpload.UseVisualStyleBackColor = True
      '
      'Label18
      '
      Me.Label18.AutoSize = True
      Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label18.ForeColor = System.Drawing.Color.Black
      Me.Label18.Location = New System.Drawing.Point(914, 37)
      Me.Label18.Name = "Label18"
      Me.Label18.Size = New System.Drawing.Size(15, 20)
      Me.Label18.TabIndex = 146
      Me.Label18.Text = "*"
      '
      'Label14
      '
      Me.Label14.AutoSize = True
      Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label14.ForeColor = System.Drawing.Color.Black
      Me.Label14.Location = New System.Drawing.Point(914, 10)
      Me.Label14.Name = "Label14"
      Me.Label14.Size = New System.Drawing.Size(15, 20)
      Me.Label14.TabIndex = 145
      Me.Label14.Text = "*"
      '
      'Label12
      '
      Me.Label12.AutoSize = True
      Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label12.ForeColor = System.Drawing.Color.Black
      Me.Label12.Location = New System.Drawing.Point(594, 10)
      Me.Label12.Name = "Label12"
      Me.Label12.Size = New System.Drawing.Size(15, 20)
      Me.Label12.TabIndex = 144
      Me.Label12.Text = "*"
      '
      'txtCompanyUrl
      '
      Me.txtCompanyUrl.Location = New System.Drawing.Point(127, 35)
      Me.txtCompanyUrl.MaxLength = 50
      Me.txtCompanyUrl.Name = "txtCompanyUrl"
      Me.txtCompanyUrl.Size = New System.Drawing.Size(161, 20)
      Me.txtCompanyUrl.TabIndex = 3
      '
      'txtRegistrationNo
      '
      Me.txtRegistrationNo.Location = New System.Drawing.Point(127, 150)
      Me.txtRegistrationNo.Name = "txtRegistrationNo"
      Me.txtRegistrationNo.Size = New System.Drawing.Size(161, 20)
      Me.txtRegistrationNo.TabIndex = 14
      '
      'haveSalesTax
      '
      Me.haveSalesTax.AutoSize = True
      Me.haveSalesTax.Location = New System.Drawing.Point(212, 181)
      Me.haveSalesTax.Name = "haveSalesTax"
      Me.haveSalesTax.Size = New System.Drawing.Size(102, 17)
      Me.haveSalesTax.TabIndex = 17
      Me.haveSalesTax.Text = "Have Sales Tax"
      Me.haveSalesTax.UseVisualStyleBackColor = True
      '
      'IsActive
      '
      Me.IsActive.AutoSize = True
      Me.IsActive.Location = New System.Drawing.Point(753, 155)
      Me.IsActive.Name = "IsActive"
      Me.IsActive.Size = New System.Drawing.Size(67, 17)
      Me.IsActive.TabIndex = 16
      Me.IsActive.Text = "Is Active"
      Me.IsActive.UseVisualStyleBackColor = True
      '
      'haveVAT
      '
      Me.haveVAT.AutoSize = True
      Me.haveVAT.Location = New System.Drawing.Point(518, 183)
      Me.haveVAT.Name = "haveVAT"
      Me.haveVAT.Size = New System.Drawing.Size(76, 17)
      Me.haveVAT.TabIndex = 19
      Me.haveVAT.Text = "Have VAT"
      Me.haveVAT.UseVisualStyleBackColor = True
      '
      'txtSalesTaxPer
      '
      Me.txtSalesTaxPer.Location = New System.Drawing.Point(127, 178)
      Me.txtSalesTaxPer.MaxLength = 50
      Me.txtSalesTaxPer.Name = "txtSalesTaxPer"
      Me.txtSalesTaxPer.ReadOnly = True
      Me.txtSalesTaxPer.Size = New System.Drawing.Size(79, 20)
      Me.txtSalesTaxPer.TabIndex = 18
      '
      'Label8
      '
      Me.Label8.AutoSize = True
      Me.Label8.ForeColor = System.Drawing.Color.Black
      Me.Label8.Location = New System.Drawing.Point(48, 181)
      Me.Label8.Name = "Label8"
      Me.Label8.Size = New System.Drawing.Size(73, 13)
      Me.Label8.TabIndex = 143
      Me.Label8.Text = "Sales Tax Per"
      '
      'Label4
      '
      Me.Label4.AutoSize = True
      Me.Label4.ForeColor = System.Drawing.Color.Black
      Me.Label4.Location = New System.Drawing.Point(56, 9)
      Me.Label4.Name = "Label4"
      Me.Label4.Size = New System.Drawing.Size(65, 13)
      Me.Label4.TabIndex = 142
      Me.Label4.Text = "Company ID"
      '
      'txtVCode
      '
      Me.txtVCode.Location = New System.Drawing.Point(433, 6)
      Me.txtVCode.MaxLength = 50
      Me.txtVCode.Name = "txtVCode"
      Me.txtVCode.Size = New System.Drawing.Size(161, 20)
      Me.txtVCode.TabIndex = 1
      '
      'txtUANNo
      '
      Me.txtUANNo.Location = New System.Drawing.Point(433, 92)
      Me.txtUANNo.Name = "txtUANNo"
      Me.txtUANNo.Size = New System.Drawing.Size(161, 20)
      Me.txtUANNo.TabIndex = 9
      '
      'Label21
      '
      Me.Label21.AutoSize = True
      Me.Label21.ForeColor = System.Drawing.Color.Black
      Me.Label21.Location = New System.Drawing.Point(387, 95)
      Me.Label21.Name = "Label21"
      Me.Label21.Size = New System.Drawing.Size(40, 13)
      Me.Label21.TabIndex = 138
      Me.Label21.Text = "UAN #"
      '
      'Label20
      '
      Me.Label20.AutoSize = True
      Me.Label20.ForeColor = System.Drawing.Color.Black
      Me.Label20.Location = New System.Drawing.Point(713, 95)
      Me.Label20.Name = "Label20"
      Me.Label20.Size = New System.Drawing.Size(34, 13)
      Me.Label20.TabIndex = 137
      Me.Label20.Text = "Fax #"
      '
      'Label19
      '
      Me.Label19.AutoSize = True
      Me.Label19.ForeColor = System.Drawing.Color.Black
      Me.Label19.Location = New System.Drawing.Point(24, 126)
      Me.Label19.Name = "Label19"
      Me.Label19.Size = New System.Drawing.Size(97, 13)
      Me.Label19.TabIndex = 136
      Me.Label19.Text = "Sales Tax/VAT No"
      '
      'Label17
      '
      Me.Label17.AutoSize = True
      Me.Label17.ForeColor = System.Drawing.Color.Black
      Me.Label17.Location = New System.Drawing.Point(73, 95)
      Me.Label17.Name = "Label17"
      Me.Label17.Size = New System.Drawing.Size(48, 13)
      Me.Label17.TabIndex = 134
      Me.Label17.Text = "Phone #"
      '
      'Label16
      '
      Me.Label16.AutoSize = True
      Me.Label16.ForeColor = System.Drawing.Color.Black
      Me.Label16.Location = New System.Drawing.Point(369, 153)
      Me.Label16.Name = "Label16"
      Me.Label16.Size = New System.Drawing.Size(58, 13)
      Me.Label16.TabIndex = 133
      Me.Label16.Text = "Time Zone"
      '
      'Label9
      '
      Me.Label9.AutoSize = True
      Me.Label9.ForeColor = System.Drawing.Color.Black
      Me.Label9.Location = New System.Drawing.Point(668, 125)
      Me.Label9.Name = "Label9"
      Me.Label9.Size = New System.Drawing.Size(79, 13)
      Me.Label9.TabIndex = 130
      Me.Label9.Text = "N.T.N Heading"
      '
      'txtFax
      '
      Me.txtFax.Location = New System.Drawing.Point(753, 92)
      Me.txtFax.Name = "txtFax"
      Me.txtFax.Size = New System.Drawing.Size(161, 20)
      Me.txtFax.TabIndex = 10
      '
      'txtVATPer
      '
      Me.txtVATPer.Location = New System.Drawing.Point(433, 181)
      Me.txtVATPer.MaxLength = 50
      Me.txtVATPer.Name = "txtVATPer"
      Me.txtVATPer.ReadOnly = True
      Me.txtVATPer.Size = New System.Drawing.Size(79, 20)
      Me.txtVATPer.TabIndex = 20
      '
      'Label13
      '
      Me.Label13.AutoSize = True
      Me.Label13.ForeColor = System.Drawing.Color.Black
      Me.Label13.Location = New System.Drawing.Point(380, 185)
      Me.Label13.Name = "Label13"
      Me.Label13.Size = New System.Drawing.Size(47, 13)
      Me.Label13.TabIndex = 128
      Me.Label13.Text = "VAT Per"
      '
      'Label15
      '
      Me.Label15.AutoSize = True
      Me.Label15.ForeColor = System.Drawing.Color.Black
      Me.Label15.Location = New System.Drawing.Point(382, 62)
      Me.Label15.Name = "Label15"
      Me.Label15.Size = New System.Drawing.Size(45, 13)
      Me.Label15.TabIndex = 124
      Me.Label15.Text = "Address"
      '
      'txtPhoneNo
      '
      Me.txtPhoneNo.Location = New System.Drawing.Point(127, 92)
      Me.txtPhoneNo.MaxLength = 50
      Me.txtPhoneNo.Name = "txtPhoneNo"
      Me.txtPhoneNo.Size = New System.Drawing.Size(161, 20)
      Me.txtPhoneNo.TabIndex = 8
      '
      'txtSalesTax
      '
      Me.txtSalesTax.Location = New System.Drawing.Point(127, 122)
      Me.txtSalesTax.Name = "txtSalesTax"
      Me.txtSalesTax.Size = New System.Drawing.Size(161, 20)
      Me.txtSalesTax.TabIndex = 11
      '
      'Label2
      '
      Me.Label2.AutoSize = True
      Me.Label2.ForeColor = System.Drawing.Color.Black
      Me.Label2.Location = New System.Drawing.Point(41, 153)
      Me.Label2.Name = "Label2"
      Me.Label2.Size = New System.Drawing.Size(80, 13)
      Me.Label2.TabIndex = 119
      Me.Label2.Text = "Registration No"
      '
      'txtNTN
      '
      Me.txtNTN.Location = New System.Drawing.Point(753, 122)
      Me.txtNTN.Name = "txtNTN"
      Me.txtNTN.Size = New System.Drawing.Size(161, 20)
      Me.txtNTN.TabIndex = 13
      '
      'txtCNIC
      '
      Me.txtCNIC.Location = New System.Drawing.Point(433, 122)
      Me.txtCNIC.MaxLength = 50
      Me.txtCNIC.Name = "txtCNIC"
      Me.txtCNIC.Size = New System.Drawing.Size(161, 20)
      Me.txtCNIC.TabIndex = 12
      '
      'Label5
      '
      Me.Label5.AutoSize = True
      Me.Label5.ForeColor = System.Drawing.Color.Black
      Me.Label5.Location = New System.Drawing.Point(343, 126)
      Me.Label5.Name = "Label5"
      Me.Label5.Size = New System.Drawing.Size(84, 13)
      Me.Label5.TabIndex = 117
      Me.Label5.Text = "C.N.I.C Heading"
      '
      'txtTimeZone
      '
      Me.txtTimeZone.Location = New System.Drawing.Point(433, 150)
      Me.txtTimeZone.MaxLength = 50
      Me.txtTimeZone.Name = "txtTimeZone"
      Me.txtTimeZone.Size = New System.Drawing.Size(161, 20)
      Me.txtTimeZone.TabIndex = 15
      '
      'Label6
      '
      Me.Label6.AutoSize = True
      Me.Label6.ForeColor = System.Drawing.Color.Black
      Me.Label6.Location = New System.Drawing.Point(370, 37)
      Me.Label6.Name = "Label6"
      Me.Label6.Size = New System.Drawing.Size(57, 13)
      Me.Label6.TabIndex = 115
      Me.Label6.Text = "Display Url"
      '
      'txtAddress
      '
      Me.txtAddress.Location = New System.Drawing.Point(433, 62)
      Me.txtAddress.MaxLength = 50
      Me.txtAddress.Name = "txtAddress"
      Me.txtAddress.Size = New System.Drawing.Size(481, 20)
      Me.txtAddress.TabIndex = 7
      '
      'Label7
      '
      Me.Label7.AutoSize = True
      Me.Label7.ForeColor = System.Drawing.Color.Black
      Me.Label7.Location = New System.Drawing.Point(704, 36)
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
      Me.cmbCountry.Location = New System.Drawing.Point(753, 32)
      Me.cmbCountry.Name = "cmbCountry"
      Me.cmbCountry.Size = New System.Drawing.Size(161, 24)
      Me.cmbCountry.TabIndex = 5
      '
      'txtCity
      '
      Me.txtCity.Location = New System.Drawing.Point(127, 62)
      Me.txtCity.Name = "txtCity"
      Me.txtCity.Size = New System.Drawing.Size(161, 20)
      Me.txtCity.TabIndex = 6
      '
      'Label11
      '
      Me.Label11.AutoSize = True
      Me.Label11.ForeColor = System.Drawing.Color.Black
      Me.Label11.Location = New System.Drawing.Point(665, 9)
      Me.Label11.Name = "Label11"
      Me.Label11.Size = New System.Drawing.Size(82, 13)
      Me.Label11.TabIndex = 108
      Me.Label11.Text = "Company Name"
      '
      'txtDisplayUrl
      '
      Me.txtDisplayUrl.Location = New System.Drawing.Point(433, 36)
      Me.txtDisplayUrl.MaxLength = 50
      Me.txtDisplayUrl.Name = "txtDisplayUrl"
      Me.txtDisplayUrl.Size = New System.Drawing.Size(161, 20)
      Me.txtDisplayUrl.TabIndex = 4
      '
      'Label10
      '
      Me.Label10.AutoSize = True
      Me.Label10.ForeColor = System.Drawing.Color.Black
      Me.Label10.Location = New System.Drawing.Point(54, 38)
      Me.Label10.Name = "Label10"
      Me.Label10.Size = New System.Drawing.Size(67, 13)
      Me.Label10.TabIndex = 102
      Me.Label10.Text = "Company Url"
      '
      'Label3
      '
      Me.Label3.AutoSize = True
      Me.Label3.ForeColor = System.Drawing.Color.Black
      Me.Label3.Location = New System.Drawing.Point(348, 9)
      Me.Label3.Name = "Label3"
      Me.Label3.Size = New System.Drawing.Size(79, 13)
      Me.Label3.TabIndex = 0
      Me.Label3.Text = "Company Code"
      '
      'txtVName
      '
      Me.txtVName.Location = New System.Drawing.Point(753, 5)
      Me.txtVName.MaxLength = 50
      Me.txtVName.Name = "txtVName"
      Me.txtVName.Size = New System.Drawing.Size(161, 20)
      Me.txtVName.TabIndex = 2
      '
      'txtID
      '
      Me.txtID.Location = New System.Drawing.Point(127, 6)
      Me.txtID.Name = "txtID"
      Me.txtID.ReadOnly = True
      Me.txtID.Size = New System.Drawing.Size(161, 20)
      Me.txtID.TabIndex = 0
      '
      'Label1
      '
      Me.Label1.AutoSize = True
      Me.Label1.ForeColor = System.Drawing.Color.Black
      Me.Label1.Location = New System.Drawing.Point(97, 65)
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
      Me.grdRecord.Size = New System.Drawing.Size(961, 168)
      Me.grdRecord.TabIndex = 0
      '
      'lblInformation
      '
      Me.lblInformation.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lblInformation.ForeColor = System.Drawing.Color.Green
      Me.lblInformation.Location = New System.Drawing.Point(670, 27)
      Me.lblInformation.Name = "lblInformation"
      Me.lblInformation.Size = New System.Drawing.Size(294, 22)
      Me.lblInformation.TabIndex = 4
      Me.lblInformation.Text = "."
      '
      'OpenFileDialog1
      '
      Me.OpenFileDialog1.FileName = "OpenFileDialog1"
      Me.OpenFileDialog1.Filter = "Image files|*.jpg"
      '
      'frmCompany
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.ClientSize = New System.Drawing.Size(967, 523)
      Me.Margin = New System.Windows.Forms.Padding(5)
      Me.Name = "frmCompany"
      Me.Text = "Company"
      Me.GBHeading.ResumeLayout(False)
      Me.GBFooter.ResumeLayout(False)
      Me.GBBody.ResumeLayout(False)
      Me.GroupBox1.ResumeLayout(False)
      Me.SplitContainer1.Panel1.ResumeLayout(False)
      Me.SplitContainer1.Panel1.PerformLayout()
      Me.SplitContainer1.Panel2.ResumeLayout(False)
      CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
      Me.SplitContainer1.ResumeLayout(False)
      CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.grdRecord, System.ComponentModel.ISupportInitialize).EndInit()
      Me.ResumeLayout(False)

   End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtVName As System.Windows.Forms.TextBox
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents grdRecord As System.Windows.Forms.DataGridView
    Friend WithEvents lblInformation As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtDisplayUrl As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtNTN As TextBox
    Friend WithEvents txtCNIC As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtTimeZone As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents cmbCountry As ComboBox
    Friend WithEvents txtCity As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtFax As TextBox
    Friend WithEvents txtVATPer As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents txtPhoneNo As TextBox
    Friend WithEvents txtSalesTax As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents txtUANNo As TextBox
    Friend WithEvents txtVCode As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtSalesTaxPer As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents haveSalesTax As CheckBox
    Friend WithEvents IsActive As CheckBox
    Friend WithEvents haveVAT As CheckBox
    Friend WithEvents txtRegistrationNo As TextBox
    Friend WithEvents txtCompanyUrl As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label12 As Label
   Friend WithEvents Label18 As Label
   Friend WithEvents cmdPictureUpload As System.Windows.Forms.Button
   Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
   Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
