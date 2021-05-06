<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmChangePassword
    Inherits WinBaseForms.GUIBaseForm

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
      Me.Label1 = New System.Windows.Forms.Label()
      Me.txtLogin = New System.Windows.Forms.TextBox()
      Me.Label2 = New System.Windows.Forms.Label()
      Me.txtPasswordOld = New System.Windows.Forms.TextBox()
      Me.Label3 = New System.Windows.Forms.Label()
      Me.txtPasswordNew = New System.Windows.Forms.TextBox()
      Me.Label4 = New System.Windows.Forms.Label()
      Me.txtPasswordConfirm = New System.Windows.Forms.TextBox()
      Me.cmdSave = New System.Windows.Forms.Button()
      Me.cmdCancel = New System.Windows.Forms.Button()
      Me.Label16 = New System.Windows.Forms.Label()
      Me.GBHeading.SuspendLayout()
      Me.GBFooter.SuspendLayout()
      Me.GBBody.SuspendLayout()
      Me.SuspendLayout()
      '
      'GBHeading
      '
      Me.GBHeading.Size = New System.Drawing.Size(547, 42)
      '
      'GBFooter
      '
      Me.GBFooter.Controls.Add(Me.cmdCancel)
      Me.GBFooter.Controls.Add(Me.cmdSave)
      Me.GBFooter.Location = New System.Drawing.Point(0, 264)
      Me.GBFooter.Size = New System.Drawing.Size(547, 76)
      '
      'GBBody
      '
      Me.GBBody.Controls.Add(Me.Label16)
      Me.GBBody.Controls.Add(Me.Label4)
      Me.GBBody.Controls.Add(Me.txtPasswordConfirm)
      Me.GBBody.Controls.Add(Me.Label3)
      Me.GBBody.Controls.Add(Me.txtPasswordNew)
      Me.GBBody.Controls.Add(Me.Label2)
      Me.GBBody.Controls.Add(Me.txtPasswordOld)
      Me.GBBody.Controls.Add(Me.Label1)
      Me.GBBody.Controls.Add(Me.txtLogin)
      Me.GBBody.Size = New System.Drawing.Size(547, 222)
      '
      'lblHeading
      '
      Me.lblHeading.Size = New System.Drawing.Size(547, 42)
      Me.lblHeading.Text = "Change Password"
      '
      'Label1
      '
      Me.Label1.AutoSize = True
      Me.Label1.ForeColor = System.Drawing.Color.Black
      Me.Label1.Location = New System.Drawing.Point(37, 39)
      Me.Label1.Name = "Label1"
      Me.Label1.Size = New System.Drawing.Size(58, 13)
      Me.Label1.TabIndex = 0
      Me.Label1.Text = "User Login"
      '
      'txtLogin
      '
      Me.txtLogin.Location = New System.Drawing.Point(136, 36)
      Me.txtLogin.MaxLength = 10
      Me.txtLogin.Name = "txtLogin"
      Me.txtLogin.ReadOnly = True
      Me.txtLogin.Size = New System.Drawing.Size(373, 20)
      Me.txtLogin.TabIndex = 1
      Me.txtLogin.TabStop = False
      '
      'Label2
      '
      Me.Label2.AutoSize = True
      Me.Label2.ForeColor = System.Drawing.Color.Black
      Me.Label2.Location = New System.Drawing.Point(37, 63)
      Me.Label2.Name = "Label2"
      Me.Label2.Size = New System.Drawing.Size(72, 13)
      Me.Label2.TabIndex = 2
      Me.Label2.Text = "Old Password"
      '
      'txtPasswordOld
      '
      Me.txtPasswordOld.Location = New System.Drawing.Point(136, 60)
      Me.txtPasswordOld.MaxLength = 20
      Me.txtPasswordOld.Name = "txtPasswordOld"
      Me.txtPasswordOld.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
      Me.txtPasswordOld.Size = New System.Drawing.Size(373, 20)
      Me.txtPasswordOld.TabIndex = 3
      '
      'Label3
      '
      Me.Label3.AutoSize = True
      Me.Label3.ForeColor = System.Drawing.Color.Black
      Me.Label3.Location = New System.Drawing.Point(37, 88)
      Me.Label3.Name = "Label3"
      Me.Label3.Size = New System.Drawing.Size(78, 13)
      Me.Label3.TabIndex = 4
      Me.Label3.Text = "New Password"
      '
      'txtPasswordNew
      '
      Me.txtPasswordNew.Location = New System.Drawing.Point(136, 85)
      Me.txtPasswordNew.MaxLength = 20
      Me.txtPasswordNew.Name = "txtPasswordNew"
      Me.txtPasswordNew.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
      Me.txtPasswordNew.Size = New System.Drawing.Size(373, 20)
      Me.txtPasswordNew.TabIndex = 5
      '
      'Label4
      '
      Me.Label4.AutoSize = True
      Me.Label4.ForeColor = System.Drawing.Color.Black
      Me.Label4.Location = New System.Drawing.Point(37, 115)
      Me.Label4.Name = "Label4"
      Me.Label4.Size = New System.Drawing.Size(91, 13)
      Me.Label4.TabIndex = 6
      Me.Label4.Text = "Confirm Password"
      '
      'txtPasswordConfirm
      '
      Me.txtPasswordConfirm.Location = New System.Drawing.Point(136, 112)
      Me.txtPasswordConfirm.MaxLength = 20
      Me.txtPasswordConfirm.Name = "txtPasswordConfirm"
      Me.txtPasswordConfirm.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
      Me.txtPasswordConfirm.Size = New System.Drawing.Size(373, 20)
      Me.txtPasswordConfirm.TabIndex = 7
      '
      'cmdSave
      '
      Me.cmdSave.BackColor = System.Drawing.Color.Transparent
      Me.cmdSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
      Me.cmdSave.ForeColor = System.Drawing.Color.White
      Me.cmdSave.Image = Global.WinBusiness.My.Resources.Resources.btn_save
      Me.cmdSave.Location = New System.Drawing.Point(192, 8)
      Me.cmdSave.Margin = New System.Windows.Forms.Padding(0)
      Me.cmdSave.Name = "cmdSave"
      Me.cmdSave.Size = New System.Drawing.Size(66, 61)
      Me.cmdSave.TabIndex = 2
      Me.cmdSave.Text = "&Save"
      Me.cmdSave.TextAlign = System.Drawing.ContentAlignment.BottomCenter
      Me.cmdSave.UseVisualStyleBackColor = False
      '
      'cmdCancel
      '
      Me.cmdCancel.BackColor = System.Drawing.Color.Transparent
      Me.cmdCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
      Me.cmdCancel.ForeColor = System.Drawing.Color.White
      Me.cmdCancel.Image = Global.WinBusiness.My.Resources.Resources.btn_cancel1
      Me.cmdCancel.Location = New System.Drawing.Point(259, 8)
      Me.cmdCancel.Margin = New System.Windows.Forms.Padding(0)
      Me.cmdCancel.Name = "cmdCancel"
      Me.cmdCancel.Size = New System.Drawing.Size(66, 61)
      Me.cmdCancel.TabIndex = 5
      Me.cmdCancel.Text = "&Cancel"
      Me.cmdCancel.TextAlign = System.Drawing.ContentAlignment.BottomCenter
      Me.cmdCancel.UseVisualStyleBackColor = False
      '
      'Label16
      '
      Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label16.ForeColor = System.Drawing.Color.Black
      Me.Label16.Location = New System.Drawing.Point(133, 142)
      Me.Label16.Name = "Label16"
      Me.Label16.Size = New System.Drawing.Size(376, 67)
      Me.Label16.TabIndex = 30
      Me.Label16.Text = "Note : Following characters will be ignored." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "1- ( ' )" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "2- ( - )" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "3- ( ; )" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "4- ( " & _
    "* )  "
      '
      'frmChangePassword
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.ClientSize = New System.Drawing.Size(547, 340)
      Me.Name = "frmChangePassword"
      Me.Text = "Change Password Form"
      Me.GBHeading.ResumeLayout(False)
      Me.GBFooter.ResumeLayout(False)
      Me.GBBody.ResumeLayout(False)
      Me.GBBody.PerformLayout()
      Me.ResumeLayout(False)

   End Sub
   Friend WithEvents Label4 As System.Windows.Forms.Label
   Friend WithEvents txtPasswordConfirm As System.Windows.Forms.TextBox
   Friend WithEvents Label3 As System.Windows.Forms.Label
   Friend WithEvents txtPasswordNew As System.Windows.Forms.TextBox
   Friend WithEvents Label2 As System.Windows.Forms.Label
   Friend WithEvents txtPasswordOld As System.Windows.Forms.TextBox
   Friend WithEvents Label1 As System.Windows.Forms.Label
   Friend WithEvents txtLogin As System.Windows.Forms.TextBox
   Protected WithEvents cmdSave As System.Windows.Forms.Button
   Protected WithEvents cmdCancel As System.Windows.Forms.Button
   Public WithEvents Label16 As System.Windows.Forms.Label
End Class
