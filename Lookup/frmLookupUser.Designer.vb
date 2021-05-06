<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLookupUser
   Inherits System.Windows.Forms.Form

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
      Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
      Me.chkActive = New System.Windows.Forms.CheckBox()
      Me.txtVName = New System.Windows.Forms.TextBox()
      Me.Label2 = New System.Windows.Forms.Label()
      Me.grdAcctLookup = New System.Windows.Forms.DataGridView()
      CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.SplitContainer1.Panel1.SuspendLayout()
      Me.SplitContainer1.Panel2.SuspendLayout()
      Me.SplitContainer1.SuspendLayout()
      CType(Me.grdAcctLookup, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.SuspendLayout()
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
      Me.SplitContainer1.Panel1.Controls.Add(Me.chkActive)
      Me.SplitContainer1.Panel1.Controls.Add(Me.txtVName)
      Me.SplitContainer1.Panel1.Controls.Add(Me.Label2)
      '
      'SplitContainer1.Panel2
      '
      Me.SplitContainer1.Panel2.Controls.Add(Me.grdAcctLookup)
      Me.SplitContainer1.Size = New System.Drawing.Size(867, 539)
      Me.SplitContainer1.SplitterDistance = 40
      Me.SplitContainer1.TabIndex = 0
      '
      'chkActive
      '
      Me.chkActive.AutoSize = True
      Me.chkActive.Checked = True
      Me.chkActive.CheckState = System.Windows.Forms.CheckState.Checked
      Me.chkActive.ForeColor = System.Drawing.Color.Black
      Me.chkActive.Location = New System.Drawing.Point(799, 17)
      Me.chkActive.Name = "chkActive"
      Me.chkActive.Size = New System.Drawing.Size(56, 17)
      Me.chkActive.TabIndex = 2
      Me.chkActive.Text = "Active"
      Me.chkActive.UseVisualStyleBackColor = True
      '
      'txtVName
      '
      Me.txtVName.Location = New System.Drawing.Point(65, 12)
      Me.txtVName.Name = "txtVName"
      Me.txtVName.Size = New System.Drawing.Size(728, 20)
      Me.txtVName.TabIndex = 1
      '
      'Label2
      '
      Me.Label2.AutoSize = True
      Me.Label2.Location = New System.Drawing.Point(12, 18)
      Me.Label2.Name = "Label2"
      Me.Label2.Size = New System.Drawing.Size(47, 13)
      Me.Label2.TabIndex = 0
      Me.Label2.Text = "Search :"
      '
      'grdAcctLookup
      '
      Me.grdAcctLookup.AllowUserToAddRows = False
      Me.grdAcctLookup.AllowUserToDeleteRows = False
      Me.grdAcctLookup.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
      Me.grdAcctLookup.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
      Me.grdAcctLookup.Dock = System.Windows.Forms.DockStyle.Fill
      Me.grdAcctLookup.Location = New System.Drawing.Point(0, 0)
      Me.grdAcctLookup.Name = "grdAcctLookup"
      Me.grdAcctLookup.ReadOnly = True
      Me.grdAcctLookup.Size = New System.Drawing.Size(867, 495)
      Me.grdAcctLookup.TabIndex = 0
      '
      'frmLookupUser
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.ClientSize = New System.Drawing.Size(867, 539)
      Me.Controls.Add(Me.SplitContainer1)
      Me.Name = "frmLookupUser"
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
      Me.Text = "User Search"
      Me.SplitContainer1.Panel1.ResumeLayout(False)
      Me.SplitContainer1.Panel1.PerformLayout()
      Me.SplitContainer1.Panel2.ResumeLayout(False)
      CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
      Me.SplitContainer1.ResumeLayout(False)
      CType(Me.grdAcctLookup, System.ComponentModel.ISupportInitialize).EndInit()
      Me.ResumeLayout(False)

   End Sub
   Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
   Friend WithEvents grdAcctLookup As System.Windows.Forms.DataGridView
   Friend WithEvents txtVName As System.Windows.Forms.TextBox
   Friend WithEvents Label2 As System.Windows.Forms.Label
   Friend WithEvents chkActive As System.Windows.Forms.CheckBox
End Class
