<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProdAdditionalOperation
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
      Me.Label1 = New System.Windows.Forms.Label()
      Me.Label12 = New System.Windows.Forms.Label()
      Me.txtVCode = New System.Windows.Forms.TextBox()
      Me.IsActive = New System.Windows.Forms.CheckBox()
      Me.Label3 = New System.Windows.Forms.Label()
      Me.txtVName = New System.Windows.Forms.TextBox()
      Me.txtID = New System.Windows.Forms.TextBox()
      Me.Label4 = New System.Windows.Forms.Label()
      Me.grdRecord = New System.Windows.Forms.DataGridView()
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
      Me.cmdSave.Location = New System.Drawing.Point(368, 8)
      '
      'cmdEdit
      '
      Me.cmdEdit.Location = New System.Drawing.Point(434, 8)
      '
      'cmdDelete
      '
      Me.cmdDelete.Location = New System.Drawing.Point(632, 8)
      '
      'cmdCancel
      '
      Me.cmdCancel.Location = New System.Drawing.Point(566, 8)
      '
      'cmdSearch
      '
      Me.cmdSearch.Location = New System.Drawing.Point(500, 8)
      '
      'cmdNew
      '
      Me.cmdNew.Location = New System.Drawing.Point(302, 8)
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
      Me.lblHeading.Text = "Additional Operation"
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
      Me.SplitContainer1.Panel1.Controls.Add(Me.Label1)
      Me.SplitContainer1.Panel1.Controls.Add(Me.Label12)
      Me.SplitContainer1.Panel1.Controls.Add(Me.txtVCode)
      Me.SplitContainer1.Panel1.Controls.Add(Me.IsActive)
      Me.SplitContainer1.Panel1.Controls.Add(Me.Label3)
      Me.SplitContainer1.Panel1.Controls.Add(Me.txtVName)
      Me.SplitContainer1.Panel1.Controls.Add(Me.txtID)
      Me.SplitContainer1.Panel1.Controls.Add(Me.Label4)
      '
      'SplitContainer1.Panel2
      '
      Me.SplitContainer1.Panel2.Controls.Add(Me.grdRecord)
      Me.SplitContainer1.Size = New System.Drawing.Size(967, 405)
      Me.SplitContainer1.SplitterDistance = 39
      Me.SplitContainer1.TabIndex = 0
      '
      'Label1
      '
      Me.Label1.AutoSize = True
      Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label1.ForeColor = System.Drawing.Color.Black
      Me.Label1.Location = New System.Drawing.Point(630, 12)
      Me.Label1.Name = "Label1"
      Me.Label1.Size = New System.Drawing.Size(15, 20)
      Me.Label1.TabIndex = 122
      Me.Label1.Text = "*"
      '
      'Label12
      '
      Me.Label12.AutoSize = True
      Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label12.ForeColor = System.Drawing.Color.Black
      Me.Label12.Location = New System.Drawing.Point(311, 12)
      Me.Label12.Name = "Label12"
      Me.Label12.Size = New System.Drawing.Size(15, 20)
      Me.Label12.TabIndex = 121
      Me.Label12.Text = "*"
      '
      'txtVCode
      '
      Me.txtVCode.Location = New System.Drawing.Point(129, 9)
      Me.txtVCode.Name = "txtVCode"
      Me.txtVCode.Size = New System.Drawing.Size(182, 20)
      Me.txtVCode.TabIndex = 116
      '
      'IsActive
      '
      Me.IsActive.AutoSize = True
      Me.IsActive.Location = New System.Drawing.Point(692, 14)
      Me.IsActive.Name = "IsActive"
      Me.IsActive.Size = New System.Drawing.Size(67, 17)
      Me.IsActive.TabIndex = 118
      Me.IsActive.Text = "Is Active"
      Me.IsActive.UseVisualStyleBackColor = True
      '
      'Label3
      '
      Me.Label3.AutoSize = True
      Me.Label3.ForeColor = System.Drawing.Color.Black
      Me.Label3.Location = New System.Drawing.Point(78, 12)
      Me.Label3.Name = "Label3"
      Me.Label3.Size = New System.Drawing.Size(32, 13)
      Me.Label3.TabIndex = 115
      Me.Label3.Text = "Code"
      '
      'txtVName
      '
      Me.txtVName.Location = New System.Drawing.Point(448, 9)
      Me.txtVName.MaxLength = 50
      Me.txtVName.Name = "txtVName"
      Me.txtVName.Size = New System.Drawing.Size(182, 20)
      Me.txtVName.TabIndex = 117
      '
      'txtID
      '
      Me.txtID.Location = New System.Drawing.Point(827, 13)
      Me.txtID.Name = "txtID"
      Me.txtID.ReadOnly = True
      Me.txtID.Size = New System.Drawing.Size(62, 20)
      Me.txtID.TabIndex = 119
      Me.txtID.Visible = False
      '
      'Label4
      '
      Me.Label4.AutoSize = True
      Me.Label4.ForeColor = System.Drawing.Color.Black
      Me.Label4.Location = New System.Drawing.Point(392, 12)
      Me.Label4.Name = "Label4"
      Me.Label4.Size = New System.Drawing.Size(41, 13)
      Me.Label4.TabIndex = 120
      Me.Label4.Text = "Name :"
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
      Me.grdRecord.Size = New System.Drawing.Size(967, 362)
      Me.grdRecord.TabIndex = 1
      '
      'lblInformation
      '
      Me.lblInformation.BackColor = System.Drawing.Color.Transparent
      Me.lblInformation.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lblInformation.ForeColor = System.Drawing.Color.Green
      Me.lblInformation.Location = New System.Drawing.Point(700, 27)
      Me.lblInformation.Name = "lblInformation"
      Me.lblInformation.Size = New System.Drawing.Size(282, 22)
      Me.lblInformation.TabIndex = 7
      Me.lblInformation.Text = "."
      '
      'ProdAdditionalOperation
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.ClientSize = New System.Drawing.Size(967, 523)
      Me.Name = "ProdAdditionalOperation"
      Me.Text = "ProdAdditionalOperation"
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
   Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
   Friend WithEvents Label1 As System.Windows.Forms.Label
   Friend WithEvents Label12 As System.Windows.Forms.Label
   Friend WithEvents txtVCode As System.Windows.Forms.TextBox
   Friend WithEvents IsActive As System.Windows.Forms.CheckBox
   Friend WithEvents Label3 As System.Windows.Forms.Label
   Friend WithEvents txtVName As System.Windows.Forms.TextBox
   Friend WithEvents txtID As System.Windows.Forms.TextBox
   Friend WithEvents Label4 As System.Windows.Forms.Label
   Friend WithEvents grdRecord As System.Windows.Forms.DataGridView
   Friend WithEvents lblInformation As System.Windows.Forms.Label
End Class
