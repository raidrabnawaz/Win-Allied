<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ProdSaleOrderOperations
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
      Me.Label20 = New System.Windows.Forms.Label()
      Me.GroupBox2 = New System.Windows.Forms.GroupBox()
      Me.Label7 = New System.Windows.Forms.Label()
      Me.txtSrlNo = New System.Windows.Forms.TextBox()
      Me.Label6 = New System.Windows.Forms.Label()
      Me.cmbOperation = New System.Windows.Forms.ComboBox()
      Me.btnAdd = New System.Windows.Forms.Button()
      Me.txtVRate = New System.Windows.Forms.TextBox()
      Me.Label1 = New System.Windows.Forms.Label()
      Me.Label5 = New System.Windows.Forms.Label()
      Me.dtpVDate = New System.Windows.Forms.DateTimePicker()
      Me.cmbSetType = New System.Windows.Forms.ComboBox()
      Me.cmbSaleOrder = New System.Windows.Forms.ComboBox()
      Me.Label2 = New System.Windows.Forms.Label()
      Me.Label3 = New System.Windows.Forms.Label()
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
      Me.GroupBox2.SuspendLayout()
      CType(Me.grdRecord, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.SuspendLayout()
      '
      'cmdSave
      '
      Me.cmdSave.Location = New System.Drawing.Point(338, 6)
      Me.cmdSave.TabIndex = 7
      '
      'cmdEdit
      '
      Me.cmdEdit.Location = New System.Drawing.Point(404, 6)
      Me.cmdEdit.TabIndex = 8
      '
      'cmdDelete
      '
      Me.cmdDelete.Location = New System.Drawing.Point(602, 6)
      Me.cmdDelete.TabIndex = 11
      '
      'cmdCancel
      '
      Me.cmdCancel.Location = New System.Drawing.Point(536, 6)
      Me.cmdCancel.TabIndex = 10
      '
      'cmdSearch
      '
      Me.cmdSearch.Location = New System.Drawing.Point(470, 6)
      Me.cmdSearch.TabIndex = 9
      '
      'cmdNew
      '
      Me.cmdNew.Location = New System.Drawing.Point(272, 6)
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
      Me.GBFooter.TabIndex = 105
      Me.GBFooter.Controls.SetChildIndex(Me.cmdSave, 0)
      Me.GBFooter.Controls.SetChildIndex(Me.cmdEdit, 0)
      Me.GBFooter.Controls.SetChildIndex(Me.cmdSearch, 0)
      Me.GBFooter.Controls.SetChildIndex(Me.cmdCancel, 0)
      Me.GBFooter.Controls.SetChildIndex(Me.lblInformation, 0)
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
      Me.lblHeading.TabIndex = 101
      Me.lblHeading.Text = "Sale Order Operations"
      '
      'Label4
      '
      Me.Label4.AutoSize = True
      Me.Label4.ForeColor = System.Drawing.Color.Black
      Me.Label4.Location = New System.Drawing.Point(651, 10)
      Me.Label4.Name = "Label4"
      Me.Label4.Size = New System.Drawing.Size(36, 13)
      Me.Label4.TabIndex = 5
      Me.Label4.Text = "Date :"
      '
      'GroupBox1
      '
      Me.GroupBox1.Controls.Add(Me.SplitContainer1)
      Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
      Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
      Me.GroupBox1.Name = "GroupBox1"
      Me.GroupBox1.Size = New System.Drawing.Size(967, 405)
      Me.GroupBox1.TabIndex = 102
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
      Me.SplitContainer1.Panel1.Controls.Add(Me.Label20)
      Me.SplitContainer1.Panel1.Controls.Add(Me.GroupBox2)
      Me.SplitContainer1.Panel1.Controls.Add(Me.dtpVDate)
      Me.SplitContainer1.Panel1.Controls.Add(Me.cmbSetType)
      Me.SplitContainer1.Panel1.Controls.Add(Me.cmbSaleOrder)
      Me.SplitContainer1.Panel1.Controls.Add(Me.Label2)
      Me.SplitContainer1.Panel1.Controls.Add(Me.Label3)
      Me.SplitContainer1.Panel1.Controls.Add(Me.txtID)
      Me.SplitContainer1.Panel1.Controls.Add(Me.Label4)
      '
      'SplitContainer1.Panel2
      '
      Me.SplitContainer1.Panel2.Controls.Add(Me.grdRecord)
      Me.SplitContainer1.Size = New System.Drawing.Size(961, 386)
      Me.SplitContainer1.SplitterDistance = 82
      Me.SplitContainer1.TabIndex = 103
      '
      'Label20
      '
      Me.Label20.AutoSize = True
      Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label20.ForeColor = System.Drawing.Color.Black
      Me.Label20.Location = New System.Drawing.Point(309, 10)
      Me.Label20.Name = "Label20"
      Me.Label20.Size = New System.Drawing.Size(15, 20)
      Me.Label20.TabIndex = 106
      Me.Label20.Text = "*"
      '
      'GroupBox2
      '
      Me.GroupBox2.Controls.Add(Me.Label7)
      Me.GroupBox2.Controls.Add(Me.txtSrlNo)
      Me.GroupBox2.Controls.Add(Me.Label6)
      Me.GroupBox2.Controls.Add(Me.cmbOperation)
      Me.GroupBox2.Controls.Add(Me.btnAdd)
      Me.GroupBox2.Controls.Add(Me.txtVRate)
      Me.GroupBox2.Controls.Add(Me.Label1)
      Me.GroupBox2.Controls.Add(Me.Label5)
      Me.GroupBox2.ForeColor = System.Drawing.SystemColors.ControlDark
      Me.GroupBox2.Location = New System.Drawing.Point(9, 31)
      Me.GroupBox2.Name = "GroupBox2"
      Me.GroupBox2.Size = New System.Drawing.Size(943, 46)
      Me.GroupBox2.TabIndex = 32
      Me.GroupBox2.TabStop = False
      Me.GroupBox2.Text = "Add Special Operation"
      '
      'Label7
      '
      Me.Label7.AutoSize = True
      Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label7.ForeColor = System.Drawing.Color.Black
      Me.Label7.Location = New System.Drawing.Point(588, 21)
      Me.Label7.Name = "Label7"
      Me.Label7.Size = New System.Drawing.Size(15, 20)
      Me.Label7.TabIndex = 47
      Me.Label7.Text = "*"
      '
      'txtSrlNo
      '
      Me.txtSrlNo.Location = New System.Drawing.Point(133, 21)
      Me.txtSrlNo.MaxLength = 50
      Me.txtSrlNo.Name = "txtSrlNo"
      Me.txtSrlNo.Size = New System.Drawing.Size(167, 20)
      Me.txtSrlNo.TabIndex = 18
      '
      'Label6
      '
      Me.Label6.AutoSize = True
      Me.Label6.ForeColor = System.Drawing.Color.Black
      Me.Label6.Location = New System.Drawing.Point(88, 21)
      Me.Label6.Name = "Label6"
      Me.Label6.Size = New System.Drawing.Size(39, 13)
      Me.Label6.TabIndex = 17
      Me.Label6.Text = "Srl No:"
      '
      'cmbOperation
      '
      Me.cmbOperation.FormattingEnabled = True
      Me.cmbOperation.Location = New System.Drawing.Point(421, 21)
      Me.cmbOperation.Name = "cmbOperation"
      Me.cmbOperation.Size = New System.Drawing.Size(167, 21)
      Me.cmbOperation.TabIndex = 4
      '
      'btnAdd
      '
      Me.btnAdd.ForeColor = System.Drawing.SystemColors.ControlText
      Me.btnAdd.Location = New System.Drawing.Point(837, 16)
      Me.btnAdd.Name = "btnAdd"
      Me.btnAdd.Size = New System.Drawing.Size(73, 23)
      Me.btnAdd.TabIndex = 5
      Me.btnAdd.Text = "Add"
      Me.btnAdd.UseVisualStyleBackColor = True
      '
      'txtVRate
      '
      Me.txtVRate.Location = New System.Drawing.Point(684, 21)
      Me.txtVRate.MaxLength = 50
      Me.txtVRate.Name = "txtVRate"
      Me.txtVRate.ReadOnly = True
      Me.txtVRate.Size = New System.Drawing.Size(136, 20)
      Me.txtVRate.TabIndex = 15
      '
      'Label1
      '
      Me.Label1.AutoSize = True
      Me.Label1.ForeColor = System.Drawing.Color.Black
      Me.Label1.Location = New System.Drawing.Point(344, 21)
      Me.Label1.Name = "Label1"
      Me.Label1.Size = New System.Drawing.Size(61, 13)
      Me.Label1.TabIndex = 14
      Me.Label1.Text = "Operations:"
      '
      'Label5
      '
      Me.Label5.AutoSize = True
      Me.Label5.ForeColor = System.Drawing.Color.Black
      Me.Label5.Location = New System.Drawing.Point(642, 21)
      Me.Label5.Name = "Label5"
      Me.Label5.Size = New System.Drawing.Size(36, 13)
      Me.Label5.TabIndex = 16
      Me.Label5.Text = "Rate :"
      '
      'dtpVDate
      '
      Me.dtpVDate.CustomFormat = "dd/MM/yyyy"
      Me.dtpVDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
      Me.dtpVDate.Location = New System.Drawing.Point(693, 7)
      Me.dtpVDate.Name = "dtpVDate"
      Me.dtpVDate.Size = New System.Drawing.Size(136, 20)
      Me.dtpVDate.TabIndex = 3
      '
      'cmbSetType
      '
      Me.cmbSetType.Enabled = False
      Me.cmbSetType.FormattingEnabled = True
      Me.cmbSetType.Location = New System.Drawing.Point(430, 7)
      Me.cmbSetType.Name = "cmbSetType"
      Me.cmbSetType.Size = New System.Drawing.Size(167, 21)
      Me.cmbSetType.TabIndex = 2
      '
      'cmbSaleOrder
      '
      Me.cmbSaleOrder.FormattingEnabled = True
      Me.cmbSaleOrder.Location = New System.Drawing.Point(142, 7)
      Me.cmbSaleOrder.Name = "cmbSaleOrder"
      Me.cmbSaleOrder.Size = New System.Drawing.Size(167, 21)
      Me.cmbSaleOrder.TabIndex = 1
      '
      'Label2
      '
      Me.Label2.AutoSize = True
      Me.Label2.ForeColor = System.Drawing.Color.Black
      Me.Label2.Location = New System.Drawing.Point(65, 11)
      Me.Label2.Name = "Label2"
      Me.Label2.Size = New System.Drawing.Size(60, 13)
      Me.Label2.TabIndex = 9
      Me.Label2.Text = "Sale Order:"
      '
      'Label3
      '
      Me.Label3.AutoSize = True
      Me.Label3.ForeColor = System.Drawing.Color.Black
      Me.Label3.Location = New System.Drawing.Point(349, 11)
      Me.Label3.Name = "Label3"
      Me.Label3.Size = New System.Drawing.Size(75, 13)
      Me.Label3.TabIndex = 0
      Me.Label3.Text = "Operation Set:"
      '
      'txtID
      '
      Me.txtID.Location = New System.Drawing.Point(4, 6)
      Me.txtID.Name = "txtID"
      Me.txtID.ReadOnly = True
      Me.txtID.Size = New System.Drawing.Size(62, 20)
      Me.txtID.TabIndex = 31
      Me.txtID.Visible = False
      '
      'grdRecord
      '
      Me.grdRecord.AllowUserToAddRows = False
      Me.grdRecord.AllowUserToDeleteRows = False
      DataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke
      DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
      Me.grdRecord.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
      Me.grdRecord.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
      Me.grdRecord.Dock = System.Windows.Forms.DockStyle.Fill
      Me.grdRecord.Location = New System.Drawing.Point(0, 0)
      Me.grdRecord.Name = "grdRecord"
      Me.grdRecord.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
      Me.grdRecord.Size = New System.Drawing.Size(961, 300)
      Me.grdRecord.TabIndex = 100
      '
      'lblInformation
      '
      Me.lblInformation.BackColor = System.Drawing.Color.Transparent
      Me.lblInformation.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lblInformation.ForeColor = System.Drawing.Color.Green
      Me.lblInformation.Location = New System.Drawing.Point(685, 22)
      Me.lblInformation.Name = "lblInformation"
      Me.lblInformation.Size = New System.Drawing.Size(282, 22)
      Me.lblInformation.TabIndex = 4
      Me.lblInformation.Text = "."
      '
      'ProdSaleOrderOperations
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.ClientSize = New System.Drawing.Size(967, 523)
      Me.Margin = New System.Windows.Forms.Padding(5)
      Me.Name = "ProdSaleOrderOperations"
      Me.Text = "Sale Order Operation"
      Me.GBHeading.ResumeLayout(False)
      Me.GBFooter.ResumeLayout(False)
      Me.GBBody.ResumeLayout(False)
      Me.GroupBox1.ResumeLayout(False)
      Me.SplitContainer1.Panel1.ResumeLayout(False)
      Me.SplitContainer1.Panel1.PerformLayout()
      Me.SplitContainer1.Panel2.ResumeLayout(False)
      CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
      Me.SplitContainer1.ResumeLayout(False)
      Me.GroupBox2.ResumeLayout(False)
      Me.GroupBox2.PerformLayout()
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
   Friend WithEvents cmbSaleOrder As System.Windows.Forms.ComboBox
   Friend WithEvents Label2 As System.Windows.Forms.Label
   Friend WithEvents cmbSetType As System.Windows.Forms.ComboBox
   Friend WithEvents btnAdd As System.Windows.Forms.Button
   Friend WithEvents Label1 As System.Windows.Forms.Label
   Friend WithEvents cmbOperation As System.Windows.Forms.ComboBox
   Friend WithEvents txtVRate As System.Windows.Forms.TextBox
   Friend WithEvents Label5 As System.Windows.Forms.Label
   Friend WithEvents dtpVDate As System.Windows.Forms.DateTimePicker
   Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
   Friend WithEvents txtSrlNo As System.Windows.Forms.TextBox
   Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label7 As Label
End Class
