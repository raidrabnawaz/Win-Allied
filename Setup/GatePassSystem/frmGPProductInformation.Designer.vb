﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmGPProductInformation
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
      Me.Label18 = New System.Windows.Forms.Label()
      Me.Label17 = New System.Windows.Forms.Label()
      Me.Label16 = New System.Windows.Forms.Label()
      Me.Label15 = New System.Windows.Forms.Label()
      Me.Label14 = New System.Windows.Forms.Label()
      Me.Label13 = New System.Windows.Forms.Label()
      Me.Label12 = New System.Windows.Forms.Label()
      Me.Label11 = New System.Windows.Forms.Label()
      Me.IsActive = New System.Windows.Forms.CheckBox()
      Me.txtReckNo = New System.Windows.Forms.TextBox()
      Me.Label10 = New System.Windows.Forms.Label()
      Me.txtRate = New System.Windows.Forms.TextBox()
      Me.Label9 = New System.Windows.Forms.Label()
      Me.txtBalanceAmount = New System.Windows.Forms.TextBox()
      Me.Label8 = New System.Windows.Forms.Label()
      Me.txtOpeningBalance = New System.Windows.Forms.TextBox()
      Me.Label5 = New System.Windows.Forms.Label()
      Me.cmbUom = New System.Windows.Forms.ComboBox()
      Me.cmbCategory = New System.Windows.Forms.ComboBox()
      Me.cmbProductType = New System.Windows.Forms.ComboBox()
      Me.Label7 = New System.Windows.Forms.Label()
      Me.Label6 = New System.Windows.Forms.Label()
      Me.Label2 = New System.Windows.Forms.Label()
      Me.txtVName = New System.Windows.Forms.TextBox()
      Me.Label1 = New System.Windows.Forms.Label()
      Me.Label3 = New System.Windows.Forms.Label()
      Me.txtVCode = New System.Windows.Forms.TextBox()
      Me.txtID = New System.Windows.Forms.TextBox()
      Me.grdRecord = New System.Windows.Forms.DataGridView()
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
      Me.lblHeading.Text = "Gate Pass Product Information"
      '
      'Label4
      '
      Me.Label4.AutoSize = True
      Me.Label4.ForeColor = System.Drawing.Color.Black
      Me.Label4.Location = New System.Drawing.Point(22, 16)
      Me.Label4.Name = "Label4"
      Me.Label4.Size = New System.Drawing.Size(78, 13)
      Me.Label4.TabIndex = 5
      Me.Label4.Text = "Product Code :"
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
      Me.SplitContainer1.Panel1.Controls.Add(Me.Label18)
      Me.SplitContainer1.Panel1.Controls.Add(Me.Label17)
      Me.SplitContainer1.Panel1.Controls.Add(Me.Label16)
      Me.SplitContainer1.Panel1.Controls.Add(Me.Label15)
      Me.SplitContainer1.Panel1.Controls.Add(Me.Label14)
      Me.SplitContainer1.Panel1.Controls.Add(Me.Label13)
      Me.SplitContainer1.Panel1.Controls.Add(Me.Label12)
      Me.SplitContainer1.Panel1.Controls.Add(Me.Label11)
      Me.SplitContainer1.Panel1.Controls.Add(Me.IsActive)
      Me.SplitContainer1.Panel1.Controls.Add(Me.txtReckNo)
      Me.SplitContainer1.Panel1.Controls.Add(Me.Label10)
      Me.SplitContainer1.Panel1.Controls.Add(Me.txtRate)
      Me.SplitContainer1.Panel1.Controls.Add(Me.Label9)
      Me.SplitContainer1.Panel1.Controls.Add(Me.txtBalanceAmount)
      Me.SplitContainer1.Panel1.Controls.Add(Me.Label8)
      Me.SplitContainer1.Panel1.Controls.Add(Me.txtOpeningBalance)
      Me.SplitContainer1.Panel1.Controls.Add(Me.Label5)
      Me.SplitContainer1.Panel1.Controls.Add(Me.cmbUom)
      Me.SplitContainer1.Panel1.Controls.Add(Me.cmbCategory)
      Me.SplitContainer1.Panel1.Controls.Add(Me.cmbProductType)
      Me.SplitContainer1.Panel1.Controls.Add(Me.Label7)
      Me.SplitContainer1.Panel1.Controls.Add(Me.Label6)
      Me.SplitContainer1.Panel1.Controls.Add(Me.Label2)
      Me.SplitContainer1.Panel1.Controls.Add(Me.txtVName)
      Me.SplitContainer1.Panel1.Controls.Add(Me.Label1)
      Me.SplitContainer1.Panel1.Controls.Add(Me.Label3)
      Me.SplitContainer1.Panel1.Controls.Add(Me.txtVCode)
      Me.SplitContainer1.Panel1.Controls.Add(Me.txtID)
      Me.SplitContainer1.Panel1.Controls.Add(Me.Label4)
      '
      'SplitContainer1.Panel2
      '
      Me.SplitContainer1.Panel2.Controls.Add(Me.grdRecord)
      Me.SplitContainer1.Size = New System.Drawing.Size(961, 386)
      Me.SplitContainer1.SplitterDistance = 83
      Me.SplitContainer1.TabIndex = 7
      '
      'Label18
      '
      Me.Label18.AutoSize = True
      Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label18.ForeColor = System.Drawing.Color.Black
      Me.Label18.Location = New System.Drawing.Point(927, 88)
      Me.Label18.Name = "Label18"
      Me.Label18.Size = New System.Drawing.Size(15, 20)
      Me.Label18.TabIndex = 30
      Me.Label18.Text = "*"
      '
      'Label17
      '
      Me.Label17.AutoSize = True
      Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label17.ForeColor = System.Drawing.Color.Black
      Me.Label17.Location = New System.Drawing.Point(619, 113)
      Me.Label17.Name = "Label17"
      Me.Label17.Size = New System.Drawing.Size(15, 20)
      Me.Label17.TabIndex = 29
      Me.Label17.Text = "*"
      Me.Label17.Visible = False
      '
      'Label16
      '
      Me.Label16.AutoSize = True
      Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label16.ForeColor = System.Drawing.Color.Black
      Me.Label16.Location = New System.Drawing.Point(619, 87)
      Me.Label16.Name = "Label16"
      Me.Label16.Size = New System.Drawing.Size(15, 20)
      Me.Label16.TabIndex = 28
      Me.Label16.Text = "*"
      Me.Label16.Visible = False
      '
      'Label15
      '
      Me.Label15.AutoSize = True
      Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label15.ForeColor = System.Drawing.Color.Black
      Me.Label15.Location = New System.Drawing.Point(883, 12)
      Me.Label15.Name = "Label15"
      Me.Label15.Size = New System.Drawing.Size(15, 20)
      Me.Label15.TabIndex = 27
      Me.Label15.Text = "*"
      '
      'Label14
      '
      Me.Label14.AutoSize = True
      Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label14.ForeColor = System.Drawing.Color.Black
      Me.Label14.Location = New System.Drawing.Point(623, 54)
      Me.Label14.Name = "Label14"
      Me.Label14.Size = New System.Drawing.Size(15, 20)
      Me.Label14.TabIndex = 26
      Me.Label14.Text = "*"
      '
      'Label13
      '
      Me.Label13.AutoSize = True
      Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label13.ForeColor = System.Drawing.Color.Black
      Me.Label13.Location = New System.Drawing.Point(290, 54)
      Me.Label13.Name = "Label13"
      Me.Label13.Size = New System.Drawing.Size(15, 20)
      Me.Label13.TabIndex = 25
      Me.Label13.Text = "*"
      '
      'Label12
      '
      Me.Label12.AutoSize = True
      Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label12.ForeColor = System.Drawing.Color.Black
      Me.Label12.Location = New System.Drawing.Point(623, 12)
      Me.Label12.Name = "Label12"
      Me.Label12.Size = New System.Drawing.Size(15, 20)
      Me.Label12.TabIndex = 17
      Me.Label12.Text = "*"
      '
      'Label11
      '
      Me.Label11.AutoSize = True
      Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label11.ForeColor = System.Drawing.Color.Black
      Me.Label11.Location = New System.Drawing.Point(290, 12)
      Me.Label11.Name = "Label11"
      Me.Label11.Size = New System.Drawing.Size(15, 20)
      Me.Label11.TabIndex = 24
      Me.Label11.Text = "*"
      '
      'IsActive
      '
      Me.IsActive.AutoSize = True
      Me.IsActive.Location = New System.Drawing.Point(701, 54)
      Me.IsActive.Name = "IsActive"
      Me.IsActive.Size = New System.Drawing.Size(67, 17)
      Me.IsActive.TabIndex = 10
      Me.IsActive.Text = "Is Active"
      Me.IsActive.UseVisualStyleBackColor = True
      '
      'txtReckNo
      '
      Me.txtReckNo.Location = New System.Drawing.Point(109, 111)
      Me.txtReckNo.MaxLength = 50
      Me.txtReckNo.Name = "txtReckNo"
      Me.txtReckNo.Size = New System.Drawing.Size(182, 20)
      Me.txtReckNo.TabIndex = 9
      Me.txtReckNo.Text = "0"
      Me.txtReckNo.Visible = False
      '
      'Label10
      '
      Me.Label10.AutoSize = True
      Me.Label10.ForeColor = System.Drawing.Color.Black
      Me.Label10.Location = New System.Drawing.Point(44, 113)
      Me.Label10.Name = "Label10"
      Me.Label10.Size = New System.Drawing.Size(56, 13)
      Me.Label10.TabIndex = 23
      Me.Label10.Text = "Reck No :"
      Me.Label10.Visible = False
      '
      'txtRate
      '
      Me.txtRate.Location = New System.Drawing.Point(745, 88)
      Me.txtRate.MaxLength = 50
      Me.txtRate.Name = "txtRate"
      Me.txtRate.Size = New System.Drawing.Size(182, 20)
      Me.txtRate.TabIndex = 8
      Me.txtRate.Text = "0"
      Me.txtRate.Visible = False
      '
      'Label9
      '
      Me.Label9.AutoSize = True
      Me.Label9.ForeColor = System.Drawing.Color.Black
      Me.Label9.Location = New System.Drawing.Point(703, 92)
      Me.Label9.Name = "Label9"
      Me.Label9.Size = New System.Drawing.Size(36, 13)
      Me.Label9.TabIndex = 21
      Me.Label9.Text = "Rate :"
      Me.Label9.Visible = False
      '
      'txtBalanceAmount
      '
      Me.txtBalanceAmount.Location = New System.Drawing.Point(435, 109)
      Me.txtBalanceAmount.MaxLength = 50
      Me.txtBalanceAmount.Name = "txtBalanceAmount"
      Me.txtBalanceAmount.Size = New System.Drawing.Size(182, 20)
      Me.txtBalanceAmount.TabIndex = 7
      Me.txtBalanceAmount.Text = "0"
      Me.txtBalanceAmount.Visible = False
      '
      'Label8
      '
      Me.Label8.AutoSize = True
      Me.Label8.ForeColor = System.Drawing.Color.Black
      Me.Label8.Location = New System.Drawing.Point(340, 112)
      Me.Label8.Name = "Label8"
      Me.Label8.Size = New System.Drawing.Size(91, 13)
      Me.Label8.TabIndex = 19
      Me.Label8.Text = "Balance Amount :"
      Me.Label8.Visible = False
      '
      'txtOpeningBalance
      '
      Me.txtOpeningBalance.Location = New System.Drawing.Point(435, 84)
      Me.txtOpeningBalance.MaxLength = 50
      Me.txtOpeningBalance.Name = "txtOpeningBalance"
      Me.txtOpeningBalance.Size = New System.Drawing.Size(182, 20)
      Me.txtOpeningBalance.TabIndex = 6
      Me.txtOpeningBalance.Text = "0"
      Me.txtOpeningBalance.Visible = False
      '
      'Label5
      '
      Me.Label5.AutoSize = True
      Me.Label5.ForeColor = System.Drawing.Color.Black
      Me.Label5.Location = New System.Drawing.Point(336, 87)
      Me.Label5.Name = "Label5"
      Me.Label5.Size = New System.Drawing.Size(95, 13)
      Me.Label5.TabIndex = 17
      Me.Label5.Text = "Opening Balance :"
      Me.Label5.Visible = False
      '
      'cmbUom
      '
      Me.cmbUom.BackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(232, Byte), Integer))
      Me.cmbUom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
      Me.cmbUom.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
      Me.cmbUom.FormattingEnabled = True
      Me.cmbUom.Location = New System.Drawing.Point(701, 10)
      Me.cmbUom.Name = "cmbUom"
      Me.cmbUom.Size = New System.Drawing.Size(182, 24)
      Me.cmbUom.TabIndex = 5
      '
      'cmbCategory
      '
      Me.cmbCategory.BackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(232, Byte), Integer))
      Me.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
      Me.cmbCategory.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
      Me.cmbCategory.FormattingEnabled = True
      Me.cmbCategory.Location = New System.Drawing.Point(439, 52)
      Me.cmbCategory.Name = "cmbCategory"
      Me.cmbCategory.Size = New System.Drawing.Size(182, 24)
      Me.cmbCategory.TabIndex = 4
      '
      'cmbProductType
      '
      Me.cmbProductType.BackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(232, Byte), Integer))
      Me.cmbProductType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
      Me.cmbProductType.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
      Me.cmbProductType.FormattingEnabled = True
      Me.cmbProductType.Items.AddRange(New Object() {"Purchase", "Import Purchase", "Sales"})
      Me.cmbProductType.Location = New System.Drawing.Point(109, 52)
      Me.cmbProductType.Name = "cmbProductType"
      Me.cmbProductType.Size = New System.Drawing.Size(182, 24)
      Me.cmbProductType.TabIndex = 3
      '
      'Label7
      '
      Me.Label7.AutoSize = True
      Me.Label7.ForeColor = System.Drawing.Color.Black
      Me.Label7.Location = New System.Drawing.Point(660, 16)
      Me.Label7.Name = "Label7"
      Me.Label7.Size = New System.Drawing.Size(35, 13)
      Me.Label7.TabIndex = 15
      Me.Label7.Text = "UOM:"
      '
      'Label6
      '
      Me.Label6.AutoSize = True
      Me.Label6.ForeColor = System.Drawing.Color.Black
      Me.Label6.Location = New System.Drawing.Point(343, 58)
      Me.Label6.Name = "Label6"
      Me.Label6.Size = New System.Drawing.Size(92, 13)
      Me.Label6.TabIndex = 13
      Me.Label6.Text = "Product Category:"
      '
      'Label2
      '
      Me.Label2.AutoSize = True
      Me.Label2.ForeColor = System.Drawing.Color.Black
      Me.Label2.Location = New System.Drawing.Point(23, 58)
      Me.Label2.Name = "Label2"
      Me.Label2.Size = New System.Drawing.Size(77, 13)
      Me.Label2.TabIndex = 9
      Me.Label2.Text = "Product Type :"
      '
      'txtVName
      '
      Me.txtVName.Location = New System.Drawing.Point(439, 12)
      Me.txtVName.MaxLength = 50
      Me.txtVName.Name = "txtVName"
      Me.txtVName.Size = New System.Drawing.Size(182, 20)
      Me.txtVName.TabIndex = 2
      '
      'Label1
      '
      Me.Label1.AutoSize = True
      Me.Label1.ForeColor = System.Drawing.Color.Black
      Me.Label1.Location = New System.Drawing.Point(329, 16)
      Me.Label1.Name = "Label1"
      Me.Label1.Size = New System.Drawing.Size(106, 13)
      Me.Label1.TabIndex = 7
      Me.Label1.Text = "Product Description :"
      '
      'Label3
      '
      Me.Label3.AutoSize = True
      Me.Label3.ForeColor = System.Drawing.Color.Black
      Me.Label3.Location = New System.Drawing.Point(682, 111)
      Me.Label3.Name = "Label3"
      Me.Label3.Size = New System.Drawing.Size(64, 13)
      Me.Label3.TabIndex = 0
      Me.Label3.Text = "Product ID :"
      Me.Label3.Visible = False
      '
      'txtVCode
      '
      Me.txtVCode.Location = New System.Drawing.Point(109, 12)
      Me.txtVCode.MaxLength = 50
      Me.txtVCode.Name = "txtVCode"
      Me.txtVCode.Size = New System.Drawing.Size(182, 20)
      Me.txtVCode.TabIndex = 1
      '
      'txtID
      '
      Me.txtID.Location = New System.Drawing.Point(752, 110)
      Me.txtID.Name = "txtID"
      Me.txtID.ReadOnly = True
      Me.txtID.Size = New System.Drawing.Size(182, 20)
      Me.txtID.TabIndex = 0
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
      Me.grdRecord.Size = New System.Drawing.Size(961, 299)
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
      'frmGPProductInformation
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.ClientSize = New System.Drawing.Size(967, 523)
      Me.Margin = New System.Windows.Forms.Padding(5)
      Me.Name = "frmGPProductInformation"
      Me.Text = "Gate Pass Product Information"
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
    Friend WithEvents txtVCode As System.Windows.Forms.TextBox
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents grdRecord As System.Windows.Forms.DataGridView
    Friend WithEvents lblInformation As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtVName As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cmbProductType As ComboBox
    Friend WithEvents cmbUom As ComboBox
    Friend WithEvents cmbCategory As ComboBox
    Friend WithEvents txtReckNo As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtRate As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtBalanceAmount As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtOpeningBalance As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents IsActive As CheckBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label18 As Label
End Class
