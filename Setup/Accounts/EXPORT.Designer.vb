<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EXPORT
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
      Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
      Me.Panel1 = New System.Windows.Forms.Panel()
      Me.grdAtt = New System.Windows.Forms.DataGridView()
      Me.Button1 = New System.Windows.Forms.Button()
      Me.Panel1.SuspendLayout()
      CType(Me.grdAtt, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.SuspendLayout()
      '
      'Panel1
      '
      Me.Panel1.Controls.Add(Me.grdAtt)
      Me.Panel1.Location = New System.Drawing.Point(150, 36)
      Me.Panel1.Name = "Panel1"
      Me.Panel1.Size = New System.Drawing.Size(109, 61)
      Me.Panel1.TabIndex = 69
      Me.Panel1.Visible = False
      '
      'grdAtt
      '
      Me.grdAtt.AllowUserToAddRows = False
      Me.grdAtt.AllowUserToDeleteRows = False
      DataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke
      DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
      Me.grdAtt.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
      Me.grdAtt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
      Me.grdAtt.Dock = System.Windows.Forms.DockStyle.Fill
      Me.grdAtt.Location = New System.Drawing.Point(0, 0)
      Me.grdAtt.Name = "grdAtt"
      Me.grdAtt.RowHeadersVisible = False
      Me.grdAtt.Size = New System.Drawing.Size(109, 61)
      Me.grdAtt.TabIndex = 0
      '
      'Button1
      '
      Me.Button1.Location = New System.Drawing.Point(123, 196)
      Me.Button1.Name = "Button1"
      Me.Button1.Size = New System.Drawing.Size(75, 23)
      Me.Button1.TabIndex = 70
      Me.Button1.Text = "Button1"
      Me.Button1.UseVisualStyleBackColor = True
      '
      'EXPORT
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.ClientSize = New System.Drawing.Size(284, 261)
      Me.Controls.Add(Me.Button1)
      Me.Controls.Add(Me.Panel1)
      Me.Name = "EXPORT"
      Me.Text = "EXPORT"
      Me.Panel1.ResumeLayout(False)
      CType(Me.grdAtt, System.ComponentModel.ISupportInitialize).EndInit()
      Me.ResumeLayout(False)

   End Sub
   Friend WithEvents Panel1 As System.Windows.Forms.Panel
   Friend WithEvents grdAtt As System.Windows.Forms.DataGridView
   Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
