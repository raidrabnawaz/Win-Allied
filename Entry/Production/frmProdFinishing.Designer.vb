<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProdFinishing
    Inherits WinBaseForms.GUIBaseFormEntry

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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.txtSrlNo = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtSizeQty = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmbSaleOrder = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmbSizes = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtpVdate = New System.Windows.Forms.DateTimePicker()
        Me.txtQty = New System.Windows.Forms.TextBox()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.grdRecord = New System.Windows.Forms.DataGridView()
        Me.lblInformation = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GBHeading.SuspendLayout()
        Me.GBFooter.SuspendLayout()
        Me.GBBody.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.grdRecord, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdSave
        '
        Me.cmdSave.Visible = False
        '
        'cmdEdit
        '
        Me.cmdEdit.Visible = False
        '
        'cmdDelete
        '
        Me.cmdDelete.Visible = False
        '
        'cmdCancel
        '
        Me.cmdCancel.Visible = False
        '
        'cmdSearch
        '
        Me.cmdSearch.Visible = False
        '
        'cmdNew
        '
        Me.cmdNew.Visible = False
        '
        'GBHeading
        '
        Me.GBHeading.Controls.Add(Me.lblInformation)
        Me.GBHeading.Size = New System.Drawing.Size(810, 42)
        Me.GBHeading.Controls.SetChildIndex(Me.lblHeading, 0)
        Me.GBHeading.Controls.SetChildIndex(Me.lblInformation, 0)
        '
        'GBFooter
        '
        Me.GBFooter.Location = New System.Drawing.Point(0, 513)
        Me.GBFooter.Size = New System.Drawing.Size(810, 10)
        Me.GBFooter.Visible = False
        '
        'GBBody
        '
        Me.GBBody.Controls.Add(Me.SplitContainer1)
        Me.GBBody.Size = New System.Drawing.Size(810, 471)
        '
        'lblHeading
        '
        Me.lblHeading.Size = New System.Drawing.Size(810, 42)
        Me.lblHeading.Text = "Finishing"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label9)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label7)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label8)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtSrlNo)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label6)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtSizeQty)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label5)
        Me.SplitContainer1.Panel1.Controls.Add(Me.cmbSaleOrder)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label3)
        Me.SplitContainer1.Panel1.Controls.Add(Me.cmbSizes)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.dtpVdate)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtQty)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtID)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label4)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnNew)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnAdd)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.grdRecord)
        Me.SplitContainer1.Size = New System.Drawing.Size(810, 471)
        Me.SplitContainer1.SplitterDistance = 78
        Me.SplitContainer1.TabIndex = 0
        '
        'txtSrlNo
        '
        Me.txtSrlNo.Location = New System.Drawing.Point(278, 14)
        Me.txtSrlNo.MaxLength = 50
        Me.txtSrlNo.Name = "txtSrlNo"
        Me.txtSrlNo.Size = New System.Drawing.Size(151, 20)
        Me.txtSrlNo.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(225, 17)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(39, 13)
        Me.Label6.TabIndex = 75
        Me.Label6.Text = "Srl No:"
        '
        'txtSizeQty
        '
        Me.txtSizeQty.Location = New System.Drawing.Point(278, 45)
        Me.txtSizeQty.MaxLength = 50
        Me.txtSizeQty.Name = "txtSizeQty"
        Me.txtSizeQty.ReadOnly = True
        Me.txtSizeQty.Size = New System.Drawing.Size(151, 20)
        Me.txtSizeQty.TabIndex = 72
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(229, 48)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 13)
        Me.Label5.TabIndex = 73
        Me.Label5.Text = "SizeQty:"
        '
        'cmbSaleOrder
        '
        Me.cmbSaleOrder.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbSaleOrder.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbSaleOrder.FormattingEnabled = True
        Me.cmbSaleOrder.Location = New System.Drawing.Point(500, 14)
        Me.cmbSaleOrder.Name = "cmbSaleOrder"
        Me.cmbSaleOrder.Size = New System.Drawing.Size(151, 21)
        Me.cmbSaleOrder.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(15, 48)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 13)
        Me.Label3.TabIndex = 71
        Me.Label3.Text = "Sizes:"
        '
        'cmbSizes
        '
        Me.cmbSizes.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbSizes.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbSizes.FormattingEnabled = True
        Me.cmbSizes.Location = New System.Drawing.Point(52, 45)
        Me.cmbSizes.Name = "cmbSizes"
        Me.cmbSizes.Size = New System.Drawing.Size(151, 21)
        Me.cmbSizes.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(434, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 13)
        Me.Label1.TabIndex = 70
        Me.Label1.Text = "Sale Order:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(12, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(33, 13)
        Me.Label2.TabIndex = 69
        Me.Label2.Text = "Date:"
        '
        'dtpVdate
        '
        Me.dtpVdate.CustomFormat = "dd/MM/yyyy"
        Me.dtpVdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpVdate.Location = New System.Drawing.Point(48, 11)
        Me.dtpVdate.Name = "dtpVdate"
        Me.dtpVdate.Size = New System.Drawing.Size(155, 20)
        Me.dtpVdate.TabIndex = 0
        '
        'txtQty
        '
        Me.txtQty.Location = New System.Drawing.Point(500, 45)
        Me.txtQty.MaxLength = 50
        Me.txtQty.Name = "txtQty"
        Me.txtQty.Size = New System.Drawing.Size(151, 20)
        Me.txtQty.TabIndex = 4
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(11, 11)
        Me.txtID.Name = "txtID"
        Me.txtID.ReadOnly = True
        Me.txtID.Size = New System.Drawing.Size(50, 20)
        Me.txtID.TabIndex = 67
        Me.txtID.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(447, 48)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 13)
        Me.Label4.TabIndex = 68
        Me.Label4.Text = "PCs/Qty:"
        '
        'btnNew
        '
        Me.btnNew.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNew.Location = New System.Drawing.Point(681, 43)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(78, 23)
        Me.btnNew.TabIndex = 6
        Me.btnNew.Text = "Cancel"
        Me.btnNew.UseVisualStyleBackColor = False
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdd.Location = New System.Drawing.Point(681, 12)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(78, 23)
        Me.btnAdd.TabIndex = 5
        Me.btnAdd.Text = "Save"
        Me.btnAdd.UseVisualStyleBackColor = False
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
        Me.grdRecord.Size = New System.Drawing.Size(810, 389)
        Me.grdRecord.TabIndex = 3
        '
        'lblInformation
        '
        Me.lblInformation.BackColor = System.Drawing.Color.Transparent
        Me.lblInformation.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInformation.ForeColor = System.Drawing.Color.Green
        Me.lblInformation.Location = New System.Drawing.Point(677, 13)
        Me.lblInformation.Name = "lblInformation"
        Me.lblInformation.Size = New System.Drawing.Size(140, 22)
        Me.lblInformation.TabIndex = 11
        Me.lblInformation.Text = "."
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(203, 48)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(15, 20)
        Me.Label8.TabIndex = 76
        Me.Label8.Text = "*"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(651, 48)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(15, 20)
        Me.Label7.TabIndex = 77
        Me.Label7.Text = "*"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(651, 17)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(15, 20)
        Me.Label9.TabIndex = 78
        Me.Label9.Text = "*"
        '
        'frmProdFinishing
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(810, 523)
        Me.Name = "frmProdFinishing"
        Me.Text = "Finishing"
        Me.GBHeading.ResumeLayout(False)
        Me.GBFooter.ResumeLayout(False)
        Me.GBBody.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.grdRecord, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As SplitContainer
   Friend WithEvents btnNew As Button
   Friend WithEvents btnAdd As Button
   Friend WithEvents grdRecord As DataGridView
   Friend WithEvents lblInformation As Label
   Friend WithEvents txtSrlNo As TextBox
   Friend WithEvents Label6 As Label
   Friend WithEvents txtSizeQty As TextBox
   Friend WithEvents Label5 As Label
   Friend WithEvents cmbSaleOrder As ComboBox
   Friend WithEvents Label3 As Label
   Friend WithEvents cmbSizes As ComboBox
   Friend WithEvents Label1 As Label
   Friend WithEvents Label2 As Label
   Friend WithEvents dtpVdate As DateTimePicker
    Friend WithEvents txtQty As TextBox
    Friend WithEvents txtID As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
End Class
