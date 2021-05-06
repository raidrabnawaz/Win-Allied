<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProductionReport
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.dtpDateTo = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtpDateFrom = New System.Windows.Forms.DateTimePicker()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.cmbMonth = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbProductionType = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbSaleOrder = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.grdRecord = New System.Windows.Forms.DataGridView()
        Me.SrlNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OrderNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OrderID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OrderName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SizeID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OrderSize = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OrderQtyCuttingActual = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SizeQty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Qty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VType = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OrderDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
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
        Me.cmdSave.Location = New System.Drawing.Point(315, 6)
        Me.cmdSave.Visible = False
        '
        'cmdEdit
        '
        Me.cmdEdit.Location = New System.Drawing.Point(381, 6)
        Me.cmdEdit.Visible = False
        '
        'cmdDelete
        '
        Me.cmdDelete.Location = New System.Drawing.Point(579, 6)
        Me.cmdDelete.Visible = False
        '
        'cmdCancel
        '
        Me.cmdCancel.Location = New System.Drawing.Point(513, 6)
        Me.cmdCancel.Visible = False
        '
        'cmdSearch
        '
        Me.cmdSearch.Location = New System.Drawing.Point(447, 6)
        '
        'cmdNew
        '
        Me.cmdNew.Location = New System.Drawing.Point(249, 6)
        Me.cmdNew.Visible = False
        '
        'GBHeading
        '
        Me.GBHeading.Size = New System.Drawing.Size(967, 42)
        '
        'GBFooter
        '
        Me.GBFooter.Location = New System.Drawing.Point(0, 447)
        Me.GBFooter.Size = New System.Drawing.Size(967, 76)
        '
        'GBBody
        '
        Me.GBBody.Controls.Add(Me.SplitContainer1)
        Me.GBBody.Size = New System.Drawing.Size(967, 405)
        '
        'lblHeading
        '
        Me.lblHeading.Size = New System.Drawing.Size(967, 42)
        Me.lblHeading.Text = "Production Reports"
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
        Me.SplitContainer1.Panel1.Controls.Add(Me.dtpDateTo)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label3)
        Me.SplitContainer1.Panel1.Controls.Add(Me.dtpDateFrom)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label19)
        Me.SplitContainer1.Panel1.Controls.Add(Me.cmbMonth)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.cmbProductionType)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.cmbSaleOrder)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label6)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.grdRecord)
        Me.SplitContainer1.Size = New System.Drawing.Size(967, 405)
        Me.SplitContainer1.SplitterDistance = 63
        Me.SplitContainer1.TabIndex = 0
        '
        'dtpDateTo
        '
        Me.dtpDateTo.CustomFormat = "dd/MM/yyyy"
        Me.dtpDateTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDateTo.Location = New System.Drawing.Point(402, 29)
        Me.dtpDateTo.Name = "dtpDateTo"
        Me.dtpDateTo.Size = New System.Drawing.Size(133, 20)
        Me.dtpDateTo.TabIndex = 32
        Me.dtpDateTo.Value = New Date(2019, 12, 30, 12, 2, 41, 0)
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(399, 11)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 15)
        Me.Label3.TabIndex = 34
        Me.Label3.Text = "Date To:"
        '
        'dtpDateFrom
        '
        Me.dtpDateFrom.CustomFormat = "dd/MM/yyyy"
        Me.dtpDateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDateFrom.Location = New System.Drawing.Point(216, 29)
        Me.dtpDateFrom.Name = "dtpDateFrom"
        Me.dtpDateFrom.Size = New System.Drawing.Size(133, 20)
        Me.dtpDateFrom.TabIndex = 31
        Me.dtpDateFrom.Value = New Date(2019, 12, 30, 12, 2, 41, 0)
        '
        'Label19
        '
        Me.Label19.Location = New System.Drawing.Point(213, 11)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(78, 15)
        Me.Label19.TabIndex = 33
        Me.Label19.Text = "Date From:"
        '
        'cmbMonth
        '
        Me.cmbMonth.FormattingEnabled = True
        Me.cmbMonth.Location = New System.Drawing.Point(30, 29)
        Me.cmbMonth.Name = "cmbMonth"
        Me.cmbMonth.Size = New System.Drawing.Size(133, 21)
        Me.cmbMonth.TabIndex = 29
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(30, 10)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 13)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "Month"
        '
        'cmbProductionType
        '
        Me.cmbProductionType.FormattingEnabled = True
        Me.cmbProductionType.Items.AddRange(New Object() {"--- SELECT ALL ---", "Cutting", "Stitching", "Finishing", "Packing", "Dispatch"})
        Me.cmbProductionType.Location = New System.Drawing.Point(774, 29)
        Me.cmbProductionType.Name = "cmbProductionType"
        Me.cmbProductionType.Size = New System.Drawing.Size(133, 21)
        Me.cmbProductionType.TabIndex = 27
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(771, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 13)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "Voucher Type:"
        '
        'cmbSaleOrder
        '
        Me.cmbSaleOrder.FormattingEnabled = True
        Me.cmbSaleOrder.Location = New System.Drawing.Point(588, 29)
        Me.cmbSaleOrder.Name = "cmbSaleOrder"
        Me.cmbSaleOrder.Size = New System.Drawing.Size(133, 21)
        Me.cmbSaleOrder.TabIndex = 25
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(588, 11)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(57, 13)
        Me.Label6.TabIndex = 26
        Me.Label6.Text = "Sale Order"
        '
        'grdRecord
        '
        Me.grdRecord.AllowUserToAddRows = False
        Me.grdRecord.AllowUserToDeleteRows = False
        Me.grdRecord.AllowUserToOrderColumns = True
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.grdRecord.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle2
        Me.grdRecord.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdRecord.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SrlNo, Me.OrderNo, Me.OrderID, Me.OrderName, Me.SizeID, Me.OrderSize, Me.OrderQtyCuttingActual, Me.SizeQty, Me.Qty, Me.VType, Me.OrderDate})
        Me.grdRecord.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdRecord.Location = New System.Drawing.Point(0, 0)
        Me.grdRecord.MultiSelect = False
        Me.grdRecord.Name = "grdRecord"
        Me.grdRecord.ReadOnly = True
        Me.grdRecord.RowHeadersVisible = False
        Me.grdRecord.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.grdRecord.Size = New System.Drawing.Size(967, 338)
        Me.grdRecord.TabIndex = 1
        '
        'SrlNo
        '
        Me.SrlNo.DataPropertyName = "SrlNo"
        Me.SrlNo.HeaderText = "SrlNo"
        Me.SrlNo.Name = "SrlNo"
        Me.SrlNo.ReadOnly = True
        '
        'OrderNo
        '
        Me.OrderNo.DataPropertyName = "OrderNo"
        Me.OrderNo.HeaderText = "OrderNo"
        Me.OrderNo.Name = "OrderNo"
        Me.OrderNo.ReadOnly = True
        '
        'OrderID
        '
        Me.OrderID.DataPropertyName = "OrderID"
        Me.OrderID.HeaderText = "OrderID"
        Me.OrderID.Name = "OrderID"
        Me.OrderID.ReadOnly = True
        Me.OrderID.Visible = False
        '
        'OrderName
        '
        Me.OrderName.DataPropertyName = "OrderName"
        Me.OrderName.HeaderText = "OrderName"
        Me.OrderName.Name = "OrderName"
        Me.OrderName.ReadOnly = True
        Me.OrderName.Width = 160
        '
        'SizeID
        '
        Me.SizeID.DataPropertyName = "SizeID"
        Me.SizeID.HeaderText = "SizeID"
        Me.SizeID.Name = "SizeID"
        Me.SizeID.ReadOnly = True
        Me.SizeID.Visible = False
        '
        'OrderSize
        '
        Me.OrderSize.DataPropertyName = "OrderSize"
        Me.OrderSize.HeaderText = "OrderSize"
        Me.OrderSize.Name = "OrderSize"
        Me.OrderSize.ReadOnly = True
        '
        'OrderQtyCuttingActual
        '
        Me.OrderQtyCuttingActual.DataPropertyName = "OrderQtyCuttingActual"
        Me.OrderQtyCuttingActual.HeaderText = "OrderQtyCuttingActual"
        Me.OrderQtyCuttingActual.Name = "OrderQtyCuttingActual"
        Me.OrderQtyCuttingActual.ReadOnly = True
        '
        'SizeQty
        '
        Me.SizeQty.DataPropertyName = "SizesQuantity"
        Me.SizeQty.HeaderText = "SizeQty"
        Me.SizeQty.Name = "SizeQty"
        Me.SizeQty.ReadOnly = True
        '
        'Qty
        '
        Me.Qty.DataPropertyName = "Quantity"
        Me.Qty.HeaderText = "Qty"
        Me.Qty.Name = "Qty"
        Me.Qty.ReadOnly = True
        '
        'VType
        '
        Me.VType.DataPropertyName = "VType"
        Me.VType.HeaderText = "VType"
        Me.VType.Name = "VType"
        Me.VType.ReadOnly = True
        '
        'OrderDate
        '
        Me.OrderDate.DataPropertyName = "OrderDate"
        Me.OrderDate.HeaderText = "OrderDate"
        Me.OrderDate.Name = "OrderDate"
        Me.OrderDate.ReadOnly = True
        '
        'frmProductionReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(967, 523)
        Me.Name = "frmProductionReport"
        Me.Text = "frmProductionReport"
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
    Friend WithEvents grdRecord As DataGridView
    Friend WithEvents cmbProductionType As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cmbSaleOrder As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents cmbMonth As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents dtpDateTo As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents dtpDateFrom As DateTimePicker
    Friend WithEvents Label19 As Label
    Friend WithEvents SrlNo As DataGridViewTextBoxColumn
    Friend WithEvents OrderNo As DataGridViewTextBoxColumn
    Friend WithEvents OrderID As DataGridViewTextBoxColumn
    Friend WithEvents OrderName As DataGridViewTextBoxColumn
    Friend WithEvents SizeID As DataGridViewTextBoxColumn
    Friend WithEvents OrderSize As DataGridViewTextBoxColumn
    Friend WithEvents OrderQtyCuttingActual As DataGridViewTextBoxColumn
    Friend WithEvents SizeQty As DataGridViewTextBoxColumn
    Friend WithEvents Qty As DataGridViewTextBoxColumn
    Friend WithEvents VType As DataGridViewTextBoxColumn
    Friend WithEvents OrderDate As DataGridViewTextBoxColumn
End Class
