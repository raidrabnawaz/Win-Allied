<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSecGroupPages
    Inherits WinBaseForms.GUIBaseFormS

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
      Me.lblUserID = New System.Windows.Forms.Label()
      Me.Label2 = New System.Windows.Forms.Label()
      Me.Label3 = New System.Windows.Forms.Label()
      Me.grdRecord = New System.Windows.Forms.DataGridView()
      Me.VID = New System.Windows.Forms.DataGridViewTextBoxColumn()
      Me.PageID = New System.Windows.Forms.DataGridViewTextBoxColumn()
      Me.UserID = New System.Windows.Forms.DataGridViewTextBoxColumn()
      Me.VName = New System.Windows.Forms.DataGridViewTextBoxColumn()
      Me.Isactive = New System.Windows.Forms.DataGridViewCheckBoxColumn()
      Me.IsView = New System.Windows.Forms.DataGridViewCheckBoxColumn()
      Me.IsInsert = New System.Windows.Forms.DataGridViewCheckBoxColumn()
      Me.IsUpdate = New System.Windows.Forms.DataGridViewCheckBoxColumn()
      Me.IsDelete = New System.Windows.Forms.DataGridViewCheckBoxColumn()
      Me.IsBackdate = New System.Windows.Forms.DataGridViewCheckBoxColumn()
      Me.IsPrint = New System.Windows.Forms.DataGridViewCheckBoxColumn()
      Me.grdExclude = New System.Windows.Forms.DataGridView()
      Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
      Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
      Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
      Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
      Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
      Me.lblUserName = New System.Windows.Forms.Label()
      Me.clbUserGroup = New System.Windows.Forms.DataGridView()
      Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
      Me.GUID = New System.Windows.Forms.DataGridViewTextBoxColumn()
      Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
      Me.DataGridViewCheckBoxColumn2 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
      CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.SplitContainer1.Panel1.SuspendLayout()
      Me.SplitContainer1.Panel2.SuspendLayout()
      Me.SplitContainer1.SuspendLayout()
      Me.GBHeading.SuspendLayout()
      Me.GBFooter.SuspendLayout()
      Me.GBBody.SuspendLayout()
      CType(Me.grdRecord, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.grdExclude, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.clbUserGroup, System.ComponentModel.ISupportInitialize).BeginInit()
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
      Me.SplitContainer1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
      '
      'SplitContainer1.Panel1
      '
      Me.SplitContainer1.Panel1.Controls.Add(Me.lblUserName)
      Me.SplitContainer1.Panel1.Controls.Add(Me.lblUserID)
      '
      'SplitContainer1.Panel2
      '
      Me.SplitContainer1.Panel2.Controls.Add(Me.clbUserGroup)
      Me.SplitContainer1.Panel2.Controls.Add(Me.grdExclude)
      Me.SplitContainer1.Panel2.Controls.Add(Me.grdRecord)
      Me.SplitContainer1.Panel2.Controls.Add(Me.Label3)
      Me.SplitContainer1.Panel2.Controls.Add(Me.Label2)
      Me.SplitContainer1.Size = New System.Drawing.Size(1016, 411)
      Me.SplitContainer1.SplitterDistance = 30
      Me.SplitContainer1.SplitterWidth = 5
      '
      'txtVName
      '
      Me.txtVName.BackColor = System.Drawing.Color.FloralWhite
      Me.txtVName.Location = New System.Drawing.Point(75, 9)
      Me.txtVName.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
      Me.txtVName.Size = New System.Drawing.Size(171, 20)
      '
      'txtID
      '
      Me.txtID.Location = New System.Drawing.Point(458, 3)
      Me.txtID.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
      '
      'lblVName
      '
      Me.lblVName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
      Me.lblVName.Size = New System.Drawing.Size(58, 13)
      Me.lblVName.Text = "User Login"
      '
      'GBHeading
      '
      Me.GBHeading.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
      Me.GBHeading.Size = New System.Drawing.Size(1016, 42)
      '
      'GBFooter
      '
      Me.GBFooter.Location = New System.Drawing.Point(0, 453)
      Me.GBFooter.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
      Me.GBFooter.Size = New System.Drawing.Size(1016, 76)
      '
      'GBBody
      '
      Me.GBBody.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
      Me.GBBody.Size = New System.Drawing.Size(1016, 411)
      '
      'lblHeading
      '
      Me.lblHeading.Size = New System.Drawing.Size(1016, 42)
      Me.lblHeading.Text = "User Rights"
      '
      'lblUserID
      '
      Me.lblUserID.AutoSize = True
      Me.lblUserID.Location = New System.Drawing.Point(469, 25)
      Me.lblUserID.Name = "lblUserID"
      Me.lblUserID.Size = New System.Drawing.Size(13, 13)
      Me.lblUserID.TabIndex = 26
      Me.lblUserID.Text = "0"
      Me.lblUserID.Visible = False
      '
      'Label2
      '
      Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
      Me.Label2.Location = New System.Drawing.Point(6, 2)
      Me.Label2.Name = "Label2"
      Me.Label2.Size = New System.Drawing.Size(227, 20)
      Me.Label2.TabIndex = 25
      Me.Label2.Text = "User Rolls"
      '
      'Label3
      '
      Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
      Me.Label3.Location = New System.Drawing.Point(239, 2)
      Me.Label3.Name = "Label3"
      Me.Label3.Size = New System.Drawing.Size(825, 20)
      Me.Label3.TabIndex = 26
      Me.Label3.Text = "User Pages"
      '
      'grdRecord
      '
      Me.grdRecord.AllowUserToAddRows = False
      Me.grdRecord.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
      Me.grdRecord.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.VID, Me.PageID, Me.UserID, Me.VName, Me.Isactive, Me.IsView, Me.IsInsert, Me.IsUpdate, Me.IsDelete, Me.IsBackdate, Me.IsPrint})
      Me.grdRecord.Location = New System.Drawing.Point(239, 22)
      Me.grdRecord.Name = "grdRecord"
      Me.grdRecord.RowHeadersVisible = False
      Me.grdRecord.Size = New System.Drawing.Size(826, 230)
      Me.grdRecord.TabIndex = 27
      '
      'VID
      '
      Me.VID.DataPropertyName = "VID"
      Me.VID.HeaderText = "VID"
      Me.VID.Name = "VID"
      Me.VID.ReadOnly = True
      Me.VID.Visible = False
      '
      'PageID
      '
      Me.PageID.DataPropertyName = "PageID"
      Me.PageID.HeaderText = "PageID"
      Me.PageID.Name = "PageID"
      Me.PageID.ReadOnly = True
      Me.PageID.Visible = False
      '
      'UserID
      '
      Me.UserID.DataPropertyName = "UserID"
      Me.UserID.HeaderText = "UserID"
      Me.UserID.Name = "UserID"
      Me.UserID.ReadOnly = True
      Me.UserID.Visible = False
      '
      'VName
      '
      Me.VName.DataPropertyName = "VName"
      Me.VName.HeaderText = "Page Name"
      Me.VName.Name = "VName"
      Me.VName.ReadOnly = True
      Me.VName.Width = 300
      '
      'Isactive
      '
      Me.Isactive.DataPropertyName = "Isactive"
      Me.Isactive.HeaderText = "Active"
      Me.Isactive.Name = "Isactive"
      Me.Isactive.Visible = False
      Me.Isactive.Width = 60
      '
      'IsView
      '
      Me.IsView.DataPropertyName = "IsView"
      Me.IsView.HeaderText = "View"
      Me.IsView.Name = "IsView"
      Me.IsView.Width = 60
      '
      'IsInsert
      '
      Me.IsInsert.DataPropertyName = "IsInsert"
      Me.IsInsert.HeaderText = "Insert"
      Me.IsInsert.Name = "IsInsert"
      Me.IsInsert.Width = 60
      '
      'IsUpdate
      '
      Me.IsUpdate.DataPropertyName = "IsUpdate"
      Me.IsUpdate.HeaderText = "Update"
      Me.IsUpdate.Name = "IsUpdate"
      Me.IsUpdate.Width = 60
      '
      'IsDelete
      '
      Me.IsDelete.DataPropertyName = "IsDelete"
      Me.IsDelete.HeaderText = "Delete"
      Me.IsDelete.Name = "IsDelete"
      Me.IsDelete.Width = 60
      '
      'IsBackdate
      '
      Me.IsBackdate.DataPropertyName = "IsBackdate"
      Me.IsBackdate.HeaderText = "Backdate"
      Me.IsBackdate.Name = "IsBackdate"
      Me.IsBackdate.Width = 60
      '
      'IsPrint
      '
      Me.IsPrint.DataPropertyName = "IsPrint"
      Me.IsPrint.HeaderText = "Print"
      Me.IsPrint.Name = "IsPrint"
      Me.IsPrint.Width = 60
      '
      'grdExclude
      '
      Me.grdExclude.AllowUserToAddRows = False
      Me.grdExclude.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
      Me.grdExclude.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewCheckBoxColumn1})
      Me.grdExclude.Location = New System.Drawing.Point(239, 258)
      Me.grdExclude.Name = "grdExclude"
      Me.grdExclude.RowHeadersVisible = False
      Me.grdExclude.Size = New System.Drawing.Size(826, 200)
      Me.grdExclude.TabIndex = 28
      '
      'DataGridViewTextBoxColumn1
      '
      Me.DataGridViewTextBoxColumn1.DataPropertyName = "VID"
      Me.DataGridViewTextBoxColumn1.HeaderText = "VID"
      Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
      Me.DataGridViewTextBoxColumn1.ReadOnly = True
      Me.DataGridViewTextBoxColumn1.Visible = False
      '
      'DataGridViewTextBoxColumn2
      '
      Me.DataGridViewTextBoxColumn2.DataPropertyName = "PageID"
      Me.DataGridViewTextBoxColumn2.HeaderText = "PageID"
      Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
      Me.DataGridViewTextBoxColumn2.ReadOnly = True
      Me.DataGridViewTextBoxColumn2.Visible = False
      '
      'DataGridViewTextBoxColumn3
      '
      Me.DataGridViewTextBoxColumn3.DataPropertyName = "UserID"
      Me.DataGridViewTextBoxColumn3.HeaderText = "UserID"
      Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
      Me.DataGridViewTextBoxColumn3.ReadOnly = True
      Me.DataGridViewTextBoxColumn3.Visible = False
      '
      'DataGridViewTextBoxColumn4
      '
      Me.DataGridViewTextBoxColumn4.DataPropertyName = "VName"
      Me.DataGridViewTextBoxColumn4.HeaderText = "Page Name"
      Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
      Me.DataGridViewTextBoxColumn4.ReadOnly = True
      Me.DataGridViewTextBoxColumn4.Width = 300
      '
      'DataGridViewCheckBoxColumn1
      '
      Me.DataGridViewCheckBoxColumn1.DataPropertyName = "IsView"
      Me.DataGridViewCheckBoxColumn1.HeaderText = "View"
      Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
      Me.DataGridViewCheckBoxColumn1.Width = 60
      '
      'lblUserName
      '
      Me.lblUserName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lblUserName.Location = New System.Drawing.Point(252, 9)
      Me.lblUserName.Name = "lblUserName"
      Me.lblUserName.Size = New System.Drawing.Size(234, 22)
      Me.lblUserName.TabIndex = 29
      Me.lblUserName.Text = "-"
      '
      'clbUserGroup
      '
      Me.clbUserGroup.AllowUserToAddRows = False
      Me.clbUserGroup.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
      Me.clbUserGroup.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn5, Me.GUID, Me.DataGridViewTextBoxColumn8, Me.DataGridViewCheckBoxColumn2})
      Me.clbUserGroup.Location = New System.Drawing.Point(5, 25)
      Me.clbUserGroup.Name = "clbUserGroup"
      Me.clbUserGroup.RowHeadersVisible = False
      Me.clbUserGroup.Size = New System.Drawing.Size(228, 433)
      Me.clbUserGroup.TabIndex = 29
      '
      'DataGridViewTextBoxColumn5
      '
      Me.DataGridViewTextBoxColumn5.DataPropertyName = "VID"
      Me.DataGridViewTextBoxColumn5.HeaderText = "VID"
      Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
      Me.DataGridViewTextBoxColumn5.Visible = False
      '
      'GUID
      '
      Me.GUID.DataPropertyName = "GID"
      Me.GUID.HeaderText = "GID"
      Me.GUID.Name = "GUID"
      Me.GUID.Visible = False
      '
      'DataGridViewTextBoxColumn8
      '
      Me.DataGridViewTextBoxColumn8.DataPropertyName = "VName"
      Me.DataGridViewTextBoxColumn8.HeaderText = "Rolls Name"
      Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
      Me.DataGridViewTextBoxColumn8.ReadOnly = True
      Me.DataGridViewTextBoxColumn8.Width = 150
      '
      'DataGridViewCheckBoxColumn2
      '
      Me.DataGridViewCheckBoxColumn2.DataPropertyName = "IsView"
      Me.DataGridViewCheckBoxColumn2.HeaderText = "Select"
      Me.DataGridViewCheckBoxColumn2.Name = "DataGridViewCheckBoxColumn2"
      Me.DataGridViewCheckBoxColumn2.Width = 60
      '
      'frmSecGroupPages
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.ClientSize = New System.Drawing.Size(1016, 529)
      Me.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
      Me.Name = "frmSecGroupPages"
      Me.Text = "User Rolls / Pages"
      Me.SplitContainer1.Panel1.ResumeLayout(False)
      Me.SplitContainer1.Panel1.PerformLayout()
      Me.SplitContainer1.Panel2.ResumeLayout(False)
      CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
      Me.SplitContainer1.ResumeLayout(False)
      Me.GBHeading.ResumeLayout(False)
      Me.GBFooter.ResumeLayout(False)
      Me.GBBody.ResumeLayout(False)
      CType(Me.grdRecord, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.grdExclude, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.clbUserGroup, System.ComponentModel.ISupportInitialize).EndInit()
      Me.ResumeLayout(False)

   End Sub
   Friend WithEvents lblUserID As System.Windows.Forms.Label
   Friend WithEvents Label3 As System.Windows.Forms.Label
   Friend WithEvents Label2 As System.Windows.Forms.Label
   Friend WithEvents grdRecord As System.Windows.Forms.DataGridView
   Friend WithEvents grdExclude As System.Windows.Forms.DataGridView
   Friend WithEvents lblUserName As System.Windows.Forms.Label
   Friend WithEvents clbUserGroup As System.Windows.Forms.DataGridView
   Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
   Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
   Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
   Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
   Friend WithEvents DataGridViewCheckBoxColumn1 As System.Windows.Forms.DataGridViewCheckBoxColumn
   Friend WithEvents VID As System.Windows.Forms.DataGridViewTextBoxColumn
   Friend WithEvents PageID As System.Windows.Forms.DataGridViewTextBoxColumn
   Friend WithEvents UserID As System.Windows.Forms.DataGridViewTextBoxColumn
   Friend WithEvents VName As System.Windows.Forms.DataGridViewTextBoxColumn
   Friend WithEvents Isactive As System.Windows.Forms.DataGridViewCheckBoxColumn
   Friend WithEvents IsView As System.Windows.Forms.DataGridViewCheckBoxColumn
   Friend WithEvents IsInsert As System.Windows.Forms.DataGridViewCheckBoxColumn
   Friend WithEvents IsUpdate As System.Windows.Forms.DataGridViewCheckBoxColumn
   Friend WithEvents IsDelete As System.Windows.Forms.DataGridViewCheckBoxColumn
   Friend WithEvents IsBackdate As System.Windows.Forms.DataGridViewCheckBoxColumn
   Friend WithEvents IsPrint As System.Windows.Forms.DataGridViewCheckBoxColumn
   Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
   Friend WithEvents GUID As System.Windows.Forms.DataGridViewTextBoxColumn
   Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
   Friend WithEvents DataGridViewCheckBoxColumn2 As System.Windows.Forms.DataGridViewCheckBoxColumn
End Class
