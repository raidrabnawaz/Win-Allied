<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBrand
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
      Me.Label4 = New System.Windows.Forms.Label()
      Me.GroupBox1 = New System.Windows.Forms.GroupBox()
      Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
      Me.lblInformation = New System.Windows.Forms.Label()
      Me.txtGroup = New System.Windows.Forms.TextBox()
      Me.txtID = New System.Windows.Forms.TextBox()
      Me.grdRecord = New System.Windows.Forms.DataGridView()
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
      '
      'cmdEdit
      '
      '
      'cmdDelete
      '
      '
      'cmdCancel
      '
      '
      'cmdSearch
      '
      '
      'cmdNew
      '
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
      Me.GBBody.Controls.Add(Me.GroupBox1)
      Me.GBBody.Size = New System.Drawing.Size(967, 405)
      '
      'lblHeading
      '
      Me.lblHeading.Size = New System.Drawing.Size(967, 42)
      Me.lblHeading.Text = "Brand Form"
      '
      'Label4
      '
      Me.Label4.AutoSize = True
      Me.Label4.ForeColor = System.Drawing.Color.Black
      Me.Label4.Location = New System.Drawing.Point(11, 6)
      Me.Label4.Name = "Label4"
      Me.Label4.Size = New System.Drawing.Size(35, 13)
      Me.Label4.TabIndex = 0
      Me.Label4.Text = "Brand"
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
      Me.SplitContainer1.Panel1.Controls.Add(Me.lblInformation)
      Me.SplitContainer1.Panel1.Controls.Add(Me.txtGroup)
      Me.SplitContainer1.Panel1.Controls.Add(Me.txtID)
      Me.SplitContainer1.Panel1.Controls.Add(Me.Label4)
      '
      'SplitContainer1.Panel2
      '
      Me.SplitContainer1.Panel2.Controls.Add(Me.grdRecord)
      Me.SplitContainer1.Size = New System.Drawing.Size(961, 386)
      Me.SplitContainer1.SplitterDistance = 30
      Me.SplitContainer1.TabIndex = 7
      '
      'lblInformation
      '
      Me.lblInformation.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lblInformation.ForeColor = System.Drawing.Color.Green
      Me.lblInformation.Location = New System.Drawing.Point(522, 4)
      Me.lblInformation.Name = "lblInformation"
      Me.lblInformation.Size = New System.Drawing.Size(434, 22)
      Me.lblInformation.TabIndex = 3
      Me.lblInformation.Text = "."
      '
      'txtGroup
      '
      Me.txtGroup.Location = New System.Drawing.Point(110, 3)
      Me.txtGroup.Name = "txtGroup"
      Me.txtGroup.Size = New System.Drawing.Size(373, 20)
      Me.txtGroup.TabIndex = 1
      '
      'txtID
      '
      Me.txtID.Location = New System.Drawing.Point(489, 3)
      Me.txtID.Name = "txtID"
      Me.txtID.Size = New System.Drawing.Size(24, 20)
      Me.txtID.TabIndex = 2
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
      Me.grdRecord.Size = New System.Drawing.Size(961, 352)
      Me.grdRecord.TabIndex = 3
      '
      'frmBrand
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.ClientSize = New System.Drawing.Size(967, 523)
      Me.Name = "frmBrand"
      Me.Text = "Brand Form"
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
    Friend WithEvents txtGroup As System.Windows.Forms.TextBox
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents grdRecord As System.Windows.Forms.DataGridView
    Friend WithEvents lblInformation As System.Windows.Forms.Label
End Class
