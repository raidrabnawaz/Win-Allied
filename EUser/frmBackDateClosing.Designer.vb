<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBackDateClosing
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
      Me.Label2 = New System.Windows.Forms.Label()
      Me.cmbFinancialYear = New System.Windows.Forms.ComboBox()
      Me.Label1 = New System.Windows.Forms.Label()
      Me.cmbCompany = New System.Windows.Forms.ComboBox()
      Me.grdRecord = New System.Windows.Forms.DataGridView()
      Me.VID = New System.Windows.Forms.DataGridViewTextBoxColumn()
      Me.SrlNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
      Me.MonthName = New System.Windows.Forms.DataGridViewTextBoxColumn()
      Me.DateFrom = New System.Windows.Forms.DataGridViewTextBoxColumn()
      Me.DateTo = New System.Windows.Forms.DataGridViewTextBoxColumn()
      Me.isClosed = New System.Windows.Forms.DataGridViewCheckBoxColumn()
      Me.Modulee = New System.Windows.Forms.DataGridViewTextBoxColumn()
      Me.CompanyID = New System.Windows.Forms.DataGridViewTextBoxColumn()
      Me.FinancialYearID = New System.Windows.Forms.DataGridViewTextBoxColumn()
      Me.lblInformation = New System.Windows.Forms.Label()
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
      Me.cmdSave.Location = New System.Drawing.Point(504, 8)
      '
      'cmdEdit
      '
      Me.cmdEdit.Location = New System.Drawing.Point(570, 8)
      Me.cmdEdit.Visible = False
      '
      'cmdDelete
      '
      Me.cmdDelete.Location = New System.Drawing.Point(768, 8)
      Me.cmdDelete.Visible = False
      '
      'cmdCancel
      '
      Me.cmdCancel.Location = New System.Drawing.Point(702, 8)
      Me.cmdCancel.Visible = False
      '
      'cmdSearch
      '
      Me.cmdSearch.Location = New System.Drawing.Point(636, 8)
      Me.cmdSearch.Visible = False
      '
      'cmdNew
      '
      Me.cmdNew.Location = New System.Drawing.Point(438, 8)
      '
      'GBHeading
      '
      Me.GBHeading.Size = New System.Drawing.Size(967, 42)
      '
      'GBFooter
      '
      Me.GBFooter.Controls.Add(Me.lblInformation)
      Me.GBFooter.Location = New System.Drawing.Point(0, 447)
      Me.GBFooter.Size = New System.Drawing.Size(967, 76)
      Me.GBFooter.Controls.SetChildIndex(Me.cmdSave, 0)
      Me.GBFooter.Controls.SetChildIndex(Me.cmdEdit, 0)
      Me.GBFooter.Controls.SetChildIndex(Me.cmdSearch, 0)
      Me.GBFooter.Controls.SetChildIndex(Me.cmdCancel, 0)
      Me.GBFooter.Controls.SetChildIndex(Me.cmdDelete, 0)
      Me.GBFooter.Controls.SetChildIndex(Me.cmdNew, 0)
      Me.GBFooter.Controls.SetChildIndex(Me.lblInformation, 0)
      '
      'GBBody
      '
      Me.GBBody.Controls.Add(Me.SplitContainer1)
      Me.GBBody.Size = New System.Drawing.Size(967, 405)
      '
      'lblHeading
      '
      Me.lblHeading.Size = New System.Drawing.Size(967, 42)
      Me.lblHeading.Text = "Back Date Closing"
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
      Me.SplitContainer1.Panel1.Controls.Add(Me.Label2)
      Me.SplitContainer1.Panel1.Controls.Add(Me.cmbFinancialYear)
      Me.SplitContainer1.Panel1.Controls.Add(Me.Label1)
      Me.SplitContainer1.Panel1.Controls.Add(Me.cmbCompany)
      '
      'SplitContainer1.Panel2
      '
      Me.SplitContainer1.Panel2.Controls.Add(Me.grdRecord)
      Me.SplitContainer1.Size = New System.Drawing.Size(967, 405)
      Me.SplitContainer1.SplitterDistance = 43
      Me.SplitContainer1.TabIndex = 0
      '
      'Label2
      '
      Me.Label2.AutoSize = True
      Me.Label2.Location = New System.Drawing.Point(508, 13)
      Me.Label2.Name = "Label2"
      Me.Label2.Size = New System.Drawing.Size(80, 13)
      Me.Label2.TabIndex = 23
      Me.Label2.Text = "Financial Year :"
      '
      'cmbFinancialYear
      '
      Me.cmbFinancialYear.FormattingEnabled = True
      Me.cmbFinancialYear.Location = New System.Drawing.Point(594, 9)
      Me.cmbFinancialYear.Name = "cmbFinancialYear"
      Me.cmbFinancialYear.Size = New System.Drawing.Size(308, 21)
      Me.cmbFinancialYear.TabIndex = 22
      '
      'Label1
      '
      Me.Label1.AutoSize = True
      Me.Label1.Location = New System.Drawing.Point(52, 13)
      Me.Label1.Name = "Label1"
      Me.Label1.Size = New System.Drawing.Size(88, 13)
      Me.Label1.TabIndex = 21
      Me.Label1.Text = "Company Name :"
      '
      'cmbCompany
      '
      Me.cmbCompany.FormattingEnabled = True
      Me.cmbCompany.Location = New System.Drawing.Point(143, 9)
      Me.cmbCompany.Name = "cmbCompany"
      Me.cmbCompany.Size = New System.Drawing.Size(308, 21)
      Me.cmbCompany.TabIndex = 20
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
      Me.grdRecord.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.VID, Me.SrlNo, Me.MonthName, Me.DateFrom, Me.DateTo, Me.isClosed, Me.Modulee, Me.CompanyID, Me.FinancialYearID})
      Me.grdRecord.Dock = System.Windows.Forms.DockStyle.Fill
      Me.grdRecord.Location = New System.Drawing.Point(0, 0)
      Me.grdRecord.Name = "grdRecord"
      Me.grdRecord.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
      Me.grdRecord.Size = New System.Drawing.Size(967, 358)
      Me.grdRecord.TabIndex = 1
      '
      'VID
      '
      Me.VID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
      Me.VID.DataPropertyName = "VID"
      Me.VID.HeaderText = "VID"
      Me.VID.Name = "VID"
      Me.VID.Visible = False
      '
      'SrlNo
      '
      Me.SrlNo.HeaderText = "Sr.#"
      Me.SrlNo.Name = "SrlNo"
      '
      'MonthName
      '
      Me.MonthName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
      Me.MonthName.DataPropertyName = "MonthName"
      Me.MonthName.HeaderText = "Month"
      Me.MonthName.Name = "MonthName"
      Me.MonthName.ReadOnly = True
      '
      'DateFrom
      '
      Me.DateFrom.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
      Me.DateFrom.DataPropertyName = "DateFrom"
      Me.DateFrom.HeaderText = "DateFrom"
      Me.DateFrom.Name = "DateFrom"
      Me.DateFrom.ReadOnly = True
      '
      'DateTo
      '
      Me.DateTo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
      Me.DateTo.DataPropertyName = "DateTo"
      Me.DateTo.HeaderText = "DateTo"
      Me.DateTo.Name = "DateTo"
      Me.DateTo.ReadOnly = True
      '
      'isClosed
      '
      Me.isClosed.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
      Me.isClosed.DataPropertyName = "isClosed"
      Me.isClosed.HeaderText = "isLocked"
      Me.isClosed.Name = "isClosed"
      Me.isClosed.Width = 56
      '
      'Modulee
      '
      Me.Modulee.DataPropertyName = "Module"
      Me.Modulee.HeaderText = "Module"
      Me.Modulee.Name = "Modulee"
      Me.Modulee.Visible = False
      '
      'CompanyID
      '
      Me.CompanyID.DataPropertyName = "CompanyID"
      Me.CompanyID.HeaderText = "CompanyID"
      Me.CompanyID.Name = "CompanyID"
      Me.CompanyID.Visible = False
      '
      'FinancialYearID
      '
      Me.FinancialYearID.DataPropertyName = "FinancialYearID"
      Me.FinancialYearID.HeaderText = "FinancialYearID"
      Me.FinancialYearID.Name = "FinancialYearID"
      Me.FinancialYearID.Visible = False
      '
      'lblInformation
      '
      Me.lblInformation.BackColor = System.Drawing.Color.Transparent
      Me.lblInformation.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lblInformation.ForeColor = System.Drawing.Color.Green
      Me.lblInformation.Location = New System.Drawing.Point(576, 28)
      Me.lblInformation.Name = "lblInformation"
      Me.lblInformation.Size = New System.Drawing.Size(275, 22)
      Me.lblInformation.TabIndex = 7
      Me.lblInformation.Text = "."
      '
      'frmBackDateClosing
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.ClientSize = New System.Drawing.Size(967, 523)
      Me.Name = "frmBackDateClosing"
      Me.Text = "Back Date Closing"
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
   Friend WithEvents Label2 As Label
   Friend WithEvents cmbFinancialYear As ComboBox
   Friend WithEvents Label1 As Label
   Friend WithEvents cmbCompany As ComboBox
   Friend WithEvents grdRecord As DataGridView
   Friend WithEvents VID As DataGridViewTextBoxColumn
   Friend WithEvents SrlNo As DataGridViewTextBoxColumn
   Friend WithEvents MonthName As DataGridViewTextBoxColumn
   Friend WithEvents DateFrom As DataGridViewTextBoxColumn
   Friend WithEvents DateTo As DataGridViewTextBoxColumn
   Friend WithEvents isClosed As DataGridViewCheckBoxColumn
   Friend WithEvents Modulee As DataGridViewTextBoxColumn
   Friend WithEvents CompanyID As DataGridViewTextBoxColumn
   Friend WithEvents FinancialYearID As DataGridViewTextBoxColumn
   Friend WithEvents lblInformation As Label
End Class
