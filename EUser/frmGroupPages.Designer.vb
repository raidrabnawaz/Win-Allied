<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGroupPages
    Inherits WinBaseForms.GUIBaseFormP

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
      Me.grdRecord = New System.Windows.Forms.DataGridView()
      Me.lblGroup = New System.Windows.Forms.Label()
      Me.cmbGroup = New System.Windows.Forms.ComboBox()
      CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.SplitContainer1.Panel1.SuspendLayout()
      Me.SplitContainer1.Panel2.SuspendLayout()
      Me.SplitContainer1.SuspendLayout()
      Me.GBHeading.SuspendLayout()
      Me.GBFooter.SuspendLayout()
      Me.GBBody.SuspendLayout()
      CType(Me.grdRecord, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.SuspendLayout()
      '
      'cmdDelete
      '
      '
      'cmdSave
      '
      '
      'cmdNew
      '
      '
      'cmdClose
      '
      '
      'SplitContainer1
      '
      '
      'SplitContainer1.Panel1
      '
      Me.SplitContainer1.Panel1.Controls.Add(Me.cmbGroup)
      Me.SplitContainer1.Panel1.Controls.Add(Me.lblGroup)
      '
      'SplitContainer1.Panel2
      '
      Me.SplitContainer1.Panel2.Controls.Add(Me.grdRecord)
      Me.SplitContainer1.SplitterDistance = 47
      '
      'GBHeading
      '
      Me.GBHeading.Size = New System.Drawing.Size(967, 42)
      '
      'lblHeading
      '
      Me.lblHeading.Text = "Rolls Pages"
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
      Me.grdRecord.Size = New System.Drawing.Size(967, 354)
      Me.grdRecord.TabIndex = 4
      '
      'lblGroup
      '
      Me.lblGroup.AutoSize = True
      Me.lblGroup.Location = New System.Drawing.Point(46, 12)
      Me.lblGroup.Name = "lblGroup"
      Me.lblGroup.Size = New System.Drawing.Size(25, 13)
      Me.lblGroup.TabIndex = 35
      Me.lblGroup.Text = "Roll"
      '
      'cmbGroup
      '
      Me.cmbGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
      Me.cmbGroup.FormattingEnabled = True
      Me.cmbGroup.Location = New System.Drawing.Point(77, 8)
      Me.cmbGroup.Name = "cmbGroup"
      Me.cmbGroup.Size = New System.Drawing.Size(364, 21)
      Me.cmbGroup.TabIndex = 34
      '
      'frmGroupPages
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.ClientSize = New System.Drawing.Size(967, 523)
      Me.Name = "frmGroupPages"
      Me.Text = "Rolls Pages"
      Me.SplitContainer1.Panel1.ResumeLayout(False)
      Me.SplitContainer1.Panel1.PerformLayout()
      Me.SplitContainer1.Panel2.ResumeLayout(False)
      CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
      Me.SplitContainer1.ResumeLayout(False)
      Me.GBHeading.ResumeLayout(False)
      Me.GBFooter.ResumeLayout(False)
      Me.GBBody.ResumeLayout(False)
      CType(Me.grdRecord, System.ComponentModel.ISupportInitialize).EndInit()
      Me.ResumeLayout(False)

   End Sub
    Public WithEvents grdRecord As System.Windows.Forms.DataGridView
    Friend WithEvents lblGroup As System.Windows.Forms.Label
    Friend WithEvents cmbGroup As System.Windows.Forms.ComboBox
End Class
