<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRptPopup
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
      Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
      Me.ListView1 = New System.Windows.Forms.ListView()
      Me.cmdClose = New System.Windows.Forms.Button()
      Me.cmdOk = New System.Windows.Forms.Button()
      CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.SplitContainer2.Panel1.SuspendLayout()
      Me.SplitContainer2.Panel2.SuspendLayout()
      Me.SplitContainer2.SuspendLayout()
      Me.SuspendLayout()
      '
      'SplitContainer2
      '
      Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
      Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
      Me.SplitContainer2.Name = "SplitContainer2"
      Me.SplitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal
      '
      'SplitContainer2.Panel1
      '
      Me.SplitContainer2.Panel1.Controls.Add(Me.ListView1)
      '
      'SplitContainer2.Panel2
      '
      Me.SplitContainer2.Panel2.Controls.Add(Me.cmdClose)
      Me.SplitContainer2.Panel2.Controls.Add(Me.cmdOk)
      Me.SplitContainer2.Size = New System.Drawing.Size(992, 435)
      Me.SplitContainer2.SplitterDistance = 383
      Me.SplitContainer2.TabIndex = 2
      '
      'ListView1
      '
      Me.ListView1.CheckBoxes = True
      Me.ListView1.Location = New System.Drawing.Point(22, 83)
      Me.ListView1.Name = "ListView1"
      Me.ListView1.Size = New System.Drawing.Size(358, 237)
      Me.ListView1.TabIndex = 2
      Me.ListView1.UseCompatibleStateImageBehavior = False
      Me.ListView1.View = System.Windows.Forms.View.List
      '
      'cmdClose
      '
      Me.cmdClose.BackColor = System.Drawing.Color.Transparent
      Me.cmdClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
      Me.cmdClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
      Me.cmdClose.ForeColor = System.Drawing.Color.White
      Me.cmdClose.Location = New System.Drawing.Point(529, 5)
      Me.cmdClose.Margin = New System.Windows.Forms.Padding(0)
      Me.cmdClose.Name = "cmdClose"
      Me.cmdClose.Size = New System.Drawing.Size(66, 42)
      Me.cmdClose.TabIndex = 15
      Me.cmdClose.TextAlign = System.Drawing.ContentAlignment.BottomCenter
      Me.cmdClose.UseVisualStyleBackColor = False
      '
      'cmdOk
      '
      Me.cmdOk.BackColor = System.Drawing.Color.Transparent
      Me.cmdOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat
      Me.cmdOk.ForeColor = System.Drawing.Color.White
      Me.cmdOk.Location = New System.Drawing.Point(604, 5)
      Me.cmdOk.Margin = New System.Windows.Forms.Padding(0)
      Me.cmdOk.Name = "cmdOk"
      Me.cmdOk.Size = New System.Drawing.Size(66, 42)
      Me.cmdOk.TabIndex = 14
      Me.cmdOk.TextAlign = System.Drawing.ContentAlignment.BottomCenter
      Me.cmdOk.UseVisualStyleBackColor = False
      '
      'frmRptPopup
      '
      Me.AcceptButton = Me.cmdOk
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.CancelButton = Me.cmdClose
      Me.ClientSize = New System.Drawing.Size(992, 435)
      Me.Controls.Add(Me.SplitContainer2)
      Me.MaximizeBox = False
      Me.Name = "frmRptPopup"
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
      Me.Text = "Please Select Record"
      Me.SplitContainer2.Panel1.ResumeLayout(False)
      Me.SplitContainer2.Panel2.ResumeLayout(False)
      CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
      Me.SplitContainer2.ResumeLayout(False)
      Me.ResumeLayout(False)

   End Sub
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Protected WithEvents cmdClose As System.Windows.Forms.Button
    Protected WithEvents cmdOk As System.Windows.Forms.Button
End Class
