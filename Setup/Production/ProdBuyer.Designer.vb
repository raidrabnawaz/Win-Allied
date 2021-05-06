<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProdBuyer
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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dtpMarketingDate = New System.Windows.Forms.DateTimePicker()
        Me.chkIsLead = New System.Windows.Forms.CheckBox()
        Me.txtVatNo = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtVCode = New System.Windows.Forms.TextBox()
        Me.chkIsActive = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtCreditLimit = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtContactPerson = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.cmbPaymentTerm = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtVName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.grdRecord = New System.Windows.Forms.DataGridView()
        Me.lblInformation = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
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
        Me.cmdSave.Location = New System.Drawing.Point(364, 6)
        '
        'cmdEdit
        '
        Me.cmdEdit.Location = New System.Drawing.Point(430, 6)
        '
        'cmdDelete
        '
        Me.cmdDelete.Location = New System.Drawing.Point(628, 6)
        '
        'cmdCancel
        '
        Me.cmdCancel.Location = New System.Drawing.Point(562, 6)
        '
        'cmdSearch
        '
        Me.cmdSearch.Location = New System.Drawing.Point(496, 6)
        '
        'cmdNew
        '
        Me.cmdNew.Location = New System.Drawing.Point(298, 6)
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
        Me.lblHeading.Text = "Production Buyer"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(358, 14)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Buyer Name:"
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
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label6)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label5)
        Me.SplitContainer1.Panel1.Controls.Add(Me.dtpMarketingDate)
        Me.SplitContainer1.Panel1.Controls.Add(Me.chkIsLead)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtVatNo)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label10)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtVCode)
        Me.SplitContainer1.Panel1.Controls.Add(Me.chkIsActive)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtPhone)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtEmail)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtCreditLimit)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label18)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtContactPerson)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label17)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label16)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label14)
        Me.SplitContainer1.Panel1.Controls.Add(Me.cmbPaymentTerm)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label11)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtVName)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label3)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtID)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label4)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.grdRecord)
        Me.SplitContainer1.Size = New System.Drawing.Size(961, 386)
        Me.SplitContainer1.SplitterDistance = 118
        Me.SplitContainer1.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(843, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(15, 20)
        Me.Label2.TabIndex = 113
        Me.Label2.Text = "*"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(574, 12)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(15, 20)
        Me.Label5.TabIndex = 112
        Me.Label5.Text = "*"
        '
        'dtpMarketingDate
        '
        Me.dtpMarketingDate.CustomFormat = "dd/MM/yyyy"
        Me.dtpMarketingDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpMarketingDate.Location = New System.Drawing.Point(703, 67)
        Me.dtpMarketingDate.Name = "dtpMarketingDate"
        Me.dtpMarketingDate.Size = New System.Drawing.Size(140, 20)
        Me.dtpMarketingDate.TabIndex = 8
        '
        'chkIsLead
        '
        Me.chkIsLead.AutoSize = True
        Me.chkIsLead.Location = New System.Drawing.Point(434, 93)
        Me.chkIsLead.Name = "chkIsLead"
        Me.chkIsLead.Size = New System.Drawing.Size(108, 17)
        Me.chkIsLead.TabIndex = 10
        Me.chkIsLead.Text = "Is Lead Customer"
        Me.chkIsLead.UseVisualStyleBackColor = True
        '
        'txtVatNo
        '
        Me.txtVatNo.Location = New System.Drawing.Point(434, 65)
        Me.txtVatNo.MaxLength = 50
        Me.txtVatNo.Name = "txtVatNo"
        Me.txtVatNo.Size = New System.Drawing.Size(140, 20)
        Me.txtVatNo.TabIndex = 7
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(379, 70)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(48, 13)
        Me.Label10.TabIndex = 44
        Me.Label10.Text = "VAT No:"
        '
        'txtVCode
        '
        Me.txtVCode.Location = New System.Drawing.Point(125, 11)
        Me.txtVCode.Name = "txtVCode"
        Me.txtVCode.ReadOnly = True
        Me.txtVCode.Size = New System.Drawing.Size(182, 20)
        Me.txtVCode.TabIndex = 0
        '
        'chkIsActive
        '
        Me.chkIsActive.AutoSize = True
        Me.chkIsActive.Location = New System.Drawing.Point(125, 93)
        Me.chkIsActive.Name = "chkIsActive"
        Me.chkIsActive.Size = New System.Drawing.Size(67, 17)
        Me.chkIsActive.TabIndex = 9
        Me.chkIsActive.Text = "Is Active"
        Me.chkIsActive.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(73, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 13)
        Me.Label1.TabIndex = 42
        Me.Label1.Text = "Phone:"
        '
        'txtPhone
        '
        Me.txtPhone.Location = New System.Drawing.Point(125, 37)
        Me.txtPhone.MaxLength = 50
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(182, 20)
        Me.txtPhone.TabIndex = 3
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(703, 11)
        Me.txtEmail.MaxLength = 50
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(140, 20)
        Me.txtEmail.TabIndex = 2
        '
        'txtCreditLimit
        '
        Me.txtCreditLimit.Location = New System.Drawing.Point(125, 65)
        Me.txtCreditLimit.MaxLength = 50
        Me.txtCreditLimit.Name = "txtCreditLimit"
        Me.txtCreditLimit.Size = New System.Drawing.Size(182, 20)
        Me.txtCreditLimit.TabIndex = 6
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.ForeColor = System.Drawing.Color.Black
        Me.Label18.Location = New System.Drawing.Point(53, 70)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(61, 13)
        Me.Label18.TabIndex = 39
        Me.Label18.Text = "Credit Limit:"
        '
        'txtContactPerson
        '
        Me.txtContactPerson.Location = New System.Drawing.Point(434, 37)
        Me.txtContactPerson.MaxLength = 50
        Me.txtContactPerson.Name = "txtContactPerson"
        Me.txtContactPerson.Size = New System.Drawing.Size(140, 20)
        Me.txtContactPerson.TabIndex = 4
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.ForeColor = System.Drawing.Color.Black
        Me.Label17.Location = New System.Drawing.Point(344, 42)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(83, 13)
        Me.Label17.TabIndex = 37
        Me.Label17.Text = "Contact Person:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.ForeColor = System.Drawing.Color.Black
        Me.Label16.Location = New System.Drawing.Point(608, 70)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(83, 13)
        Me.Label16.TabIndex = 35
        Me.Label16.Text = "Marketing Date:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(656, 14)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(35, 13)
        Me.Label14.TabIndex = 32
        Me.Label14.Text = "Email:"
        '
        'cmbPaymentTerm
        '
        Me.cmbPaymentTerm.BackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.cmbPaymentTerm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPaymentTerm.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.cmbPaymentTerm.FormattingEnabled = True
        Me.cmbPaymentTerm.Location = New System.Drawing.Point(703, 37)
        Me.cmbPaymentTerm.Name = "cmbPaymentTerm"
        Me.cmbPaymentTerm.Size = New System.Drawing.Size(140, 24)
        Me.cmbPaymentTerm.TabIndex = 5
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(613, 42)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(78, 13)
        Me.Label11.TabIndex = 26
        Me.Label11.Text = "Payment Term:"
        '
        'txtVName
        '
        Me.txtVName.Location = New System.Drawing.Point(434, 11)
        Me.txtVName.MaxLength = 50
        Me.txtVName.Name = "txtVName"
        Me.txtVName.Size = New System.Drawing.Size(140, 20)
        Me.txtVName.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(49, 14)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Buyer Code:"
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(10, 34)
        Me.txtID.Name = "txtID"
        Me.txtID.ReadOnly = True
        Me.txtID.Size = New System.Drawing.Size(21, 20)
        Me.txtID.TabIndex = 1
        Me.txtID.Visible = False
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
        Me.grdRecord.Size = New System.Drawing.Size(961, 264)
        Me.grdRecord.TabIndex = 0
        '
        'lblInformation
        '
        Me.lblInformation.BackColor = System.Drawing.Color.Transparent
        Me.lblInformation.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInformation.ForeColor = System.Drawing.Color.Green
        Me.lblInformation.Location = New System.Drawing.Point(702, 24)
        Me.lblInformation.Name = "lblInformation"
        Me.lblInformation.Size = New System.Drawing.Size(262, 22)
        Me.lblInformation.TabIndex = 4
        Me.lblInformation.Text = "."
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(307, 67)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(15, 20)
        Me.Label6.TabIndex = 114
        Me.Label6.Text = "*"
        '
        'ProdBuyer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(967, 523)
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "ProdBuyer"
        Me.Text = "Production Buyer"
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
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents grdRecord As System.Windows.Forms.DataGridView
    Friend WithEvents lblInformation As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtVName As TextBox
    Friend WithEvents txtCreditLimit As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents txtContactPerson As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents cmbPaymentTerm As ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents chkIsActive As CheckBox
    Friend WithEvents txtVCode As TextBox
    Friend WithEvents txtVatNo As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents chkIsLead As CheckBox
    Friend WithEvents dtpMarketingDate As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label6 As Label
End Class
