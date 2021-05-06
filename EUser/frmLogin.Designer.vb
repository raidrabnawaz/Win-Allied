<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogin
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
      Me.txtUserName = New System.Windows.Forms.TextBox()
      Me.cmdOK = New System.Windows.Forms.Button()
      Me.txtPswd = New System.Windows.Forms.TextBox()
      Me.cmdClose = New System.Windows.Forms.Button()
      Me.cmbFinancialYear = New System.Windows.Forms.ComboBox()
      Me.SuspendLayout()
      '
      'txtUserName
      '
      Me.txtUserName.BackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(232, Byte), Integer))
      Me.txtUserName.BorderStyle = System.Windows.Forms.BorderStyle.None
      Me.txtUserName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
      Me.txtUserName.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtUserName.Location = New System.Drawing.Point(189, 138)
      Me.txtUserName.MaxLength = 50
      Me.txtUserName.Name = "txtUserName"
      Me.txtUserName.Size = New System.Drawing.Size(152, 22)
      Me.txtUserName.TabIndex = 0
      '
      'cmdOK
      '
      Me.cmdOK.BackColor = System.Drawing.Color.Transparent
      Me.cmdOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat
      Me.cmdOK.ForeColor = System.Drawing.Color.Transparent
      Me.cmdOK.Location = New System.Drawing.Point(270, 235)
      Me.cmdOK.Margin = New System.Windows.Forms.Padding(0)
      Me.cmdOK.Name = "cmdOK"
      Me.cmdOK.Size = New System.Drawing.Size(57, 22)
      Me.cmdOK.TabIndex = 3
      Me.cmdOK.TextAlign = System.Drawing.ContentAlignment.BottomCenter
      Me.cmdOK.UseVisualStyleBackColor = False
      '
      'txtPswd
      '
      Me.txtPswd.BackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(232, Byte), Integer))
      Me.txtPswd.BorderStyle = System.Windows.Forms.BorderStyle.None
      Me.txtPswd.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtPswd.Location = New System.Drawing.Point(189, 167)
      Me.txtPswd.MaxLength = 50
      Me.txtPswd.Name = "txtPswd"
      Me.txtPswd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
      Me.txtPswd.Size = New System.Drawing.Size(152, 22)
      Me.txtPswd.TabIndex = 1
      '
      'cmdClose
      '
      Me.cmdClose.BackColor = System.Drawing.Color.Transparent
      Me.cmdClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
      Me.cmdClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
      Me.cmdClose.ForeColor = System.Drawing.Color.Transparent
      Me.cmdClose.Location = New System.Drawing.Point(349, 86)
      Me.cmdClose.Margin = New System.Windows.Forms.Padding(0)
      Me.cmdClose.Name = "cmdClose"
      Me.cmdClose.Size = New System.Drawing.Size(22, 21)
      Me.cmdClose.TabIndex = 4
      Me.cmdClose.TabStop = False
      Me.cmdClose.TextAlign = System.Drawing.ContentAlignment.BottomCenter
      Me.cmdClose.UseVisualStyleBackColor = False
      '
      'cmbFinancialYear
      '
      Me.cmbFinancialYear.BackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(232, Byte), Integer))
      Me.cmbFinancialYear.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
      Me.cmbFinancialYear.FormattingEnabled = True
      Me.cmbFinancialYear.Location = New System.Drawing.Point(188, 195)
      Me.cmbFinancialYear.Name = "cmbFinancialYear"
      Me.cmbFinancialYear.Size = New System.Drawing.Size(153, 24)
      Me.cmbFinancialYear.TabIndex = 2
      '
      'frmLogin
      '
      Me.AcceptButton = Me.cmdOK
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.BackgroundImage = Global.WinBusiness.My.Resources.Resources.loginbg4
      Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
      Me.CancelButton = Me.cmdClose
      Me.ClientSize = New System.Drawing.Size(426, 356)
      Me.Controls.Add(Me.cmbFinancialYear)
      Me.Controls.Add(Me.cmdClose)
      Me.Controls.Add(Me.txtPswd)
      Me.Controls.Add(Me.cmdOK)
      Me.Controls.Add(Me.txtUserName)
      Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
      Me.MaximizeBox = False
      Me.MinimizeBox = False
      Me.Name = "frmLogin"
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
      Me.Text = "Please Log On"
      Me.ResumeLayout(False)
      Me.PerformLayout()

   End Sub
    Friend WithEvents txtUserName As System.Windows.Forms.TextBox
    Protected WithEvents cmdOK As System.Windows.Forms.Button
    Friend WithEvents txtPswd As System.Windows.Forms.TextBox
   Protected WithEvents cmdClose As System.Windows.Forms.Button
   Friend WithEvents cmbFinancialYear As System.Windows.Forms.ComboBox
End Class
