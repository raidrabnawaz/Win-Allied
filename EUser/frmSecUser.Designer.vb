<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSecUser
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
      Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
      Me.grdRecord = New System.Windows.Forms.DataGridView()
      Me.txtLogin = New System.Windows.Forms.TextBox()
      Me.Label2 = New System.Windows.Forms.Label()
      Me.txtUserPassword = New System.Windows.Forms.TextBox()
      Me.Label3 = New System.Windows.Forms.Label()
      Me.chkIsAllowed = New System.Windows.Forms.CheckBox()
      Me.chkAllowActual = New System.Windows.Forms.CheckBox()
      Me.chkIsAdmin = New System.Windows.Forms.CheckBox()
      Me.chkIsActive = New System.Windows.Forms.CheckBox()
      Me.cmbEmployee = New System.Windows.Forms.ComboBox()
      Me.Label10 = New System.Windows.Forms.Label()
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
      Me.SplitContainer1.Panel1.Controls.Add(Me.cmbEmployee)
      Me.SplitContainer1.Panel1.Controls.Add(Me.Label10)
      Me.SplitContainer1.Panel1.Controls.Add(Me.chkIsActive)
      Me.SplitContainer1.Panel1.Controls.Add(Me.chkIsAdmin)
      Me.SplitContainer1.Panel1.Controls.Add(Me.chkAllowActual)
      Me.SplitContainer1.Panel1.Controls.Add(Me.chkIsAllowed)
      Me.SplitContainer1.Panel1.Controls.Add(Me.txtUserPassword)
      Me.SplitContainer1.Panel1.Controls.Add(Me.Label3)
      Me.SplitContainer1.Panel1.Controls.Add(Me.txtLogin)
      Me.SplitContainer1.Panel1.Controls.Add(Me.Label2)
      '
      'SplitContainer1.Panel2
      '
      Me.SplitContainer1.Panel2.Controls.Add(Me.grdRecord)
      Me.SplitContainer1.SplitterDistance = 61
      '
      'txtVName
      '
      Me.txtVName.BackColor = System.Drawing.Color.FloralWhite
      Me.txtVName.Margin = New System.Windows.Forms.Padding(4)
      Me.txtVName.Size = New System.Drawing.Size(212, 20)
      '
      'lblInformation
      '
      Me.lblInformation.Location = New System.Drawing.Point(692, 7)
      Me.lblInformation.Size = New System.Drawing.Size(264, 22)
      '
      'txtID
      '
      Me.txtID.Location = New System.Drawing.Point(313, 11)
      Me.txtID.Margin = New System.Windows.Forms.Padding(4)
      '
      'lblVName
      '
      Me.lblVName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
      Me.lblVName.Size = New System.Drawing.Size(60, 13)
      Me.lblVName.Text = "User Name"
      '
      'lblHeading
      '
      Me.lblHeading.Text = "User Management"
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
      Me.grdRecord.RowHeadersVisible = False
      Me.grdRecord.Size = New System.Drawing.Size(967, 340)
      Me.grdRecord.TabIndex = 4
      '
      'txtLogin
      '
      Me.txtLogin.Location = New System.Drawing.Point(84, 35)
      Me.txtLogin.Name = "txtLogin"
      Me.txtLogin.Size = New System.Drawing.Size(160, 20)
      Me.txtLogin.TabIndex = 29
      '
      'Label2
      '
      Me.Label2.AutoSize = True
      Me.Label2.Location = New System.Drawing.Point(13, 38)
      Me.Label2.Name = "Label2"
      Me.Label2.Size = New System.Drawing.Size(58, 13)
      Me.Label2.TabIndex = 28
      Me.Label2.Text = "User Login"
      '
      'txtUserPassword
      '
      Me.txtUserPassword.Location = New System.Drawing.Point(343, 35)
      Me.txtUserPassword.Name = "txtUserPassword"
      Me.txtUserPassword.Size = New System.Drawing.Size(160, 20)
      Me.txtUserPassword.TabIndex = 31
      Me.txtUserPassword.UseSystemPasswordChar = True
      '
      'Label3
      '
      Me.Label3.AutoSize = True
      Me.Label3.Location = New System.Drawing.Point(259, 38)
      Me.Label3.Name = "Label3"
      Me.Label3.Size = New System.Drawing.Size(78, 13)
      Me.Label3.TabIndex = 30
      Me.Label3.Text = "User Password"
      '
      'chkIsAllowed
      '
      Me.chkIsAllowed.AutoSize = True
      Me.chkIsAllowed.Location = New System.Drawing.Point(509, 37)
      Me.chkIsAllowed.Name = "chkIsAllowed"
      Me.chkIsAllowed.Size = New System.Drawing.Size(78, 17)
      Me.chkIsAllowed.TabIndex = 32
      Me.chkIsAllowed.Text = "Allow Audit"
      Me.chkIsAllowed.UseVisualStyleBackColor = True
      '
      'chkAllowActual
      '
      Me.chkAllowActual.AutoSize = True
      Me.chkAllowActual.Location = New System.Drawing.Point(603, 38)
      Me.chkAllowActual.Name = "chkAllowActual"
      Me.chkAllowActual.Size = New System.Drawing.Size(84, 17)
      Me.chkAllowActual.TabIndex = 33
      Me.chkAllowActual.Text = "Allow Actual"
      Me.chkAllowActual.UseVisualStyleBackColor = True
      '
      'chkIsAdmin
      '
      Me.chkIsAdmin.AutoSize = True
      Me.chkIsAdmin.Location = New System.Drawing.Point(704, 38)
      Me.chkIsAdmin.Name = "chkIsAdmin"
      Me.chkIsAdmin.Size = New System.Drawing.Size(55, 17)
      Me.chkIsAdmin.TabIndex = 34
      Me.chkIsAdmin.Text = "Admin"
      Me.chkIsAdmin.UseVisualStyleBackColor = True
      '
      'chkIsActive
      '
      Me.chkIsActive.AutoSize = True
      Me.chkIsActive.Location = New System.Drawing.Point(778, 38)
      Me.chkIsActive.Name = "chkIsActive"
      Me.chkIsActive.Size = New System.Drawing.Size(56, 17)
      Me.chkIsActive.TabIndex = 35
      Me.chkIsActive.Text = "Active"
      Me.chkIsActive.UseVisualStyleBackColor = True
      '
      'cmbEmployee
      '
      Me.cmbEmployee.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
      Me.cmbEmployee.FormattingEnabled = True
      Me.cmbEmployee.Location = New System.Drawing.Point(434, 9)
      Me.cmbEmployee.Name = "cmbEmployee"
      Me.cmbEmployee.Size = New System.Drawing.Size(252, 21)
      Me.cmbEmployee.TabIndex = 36
      '
      'Label10
      '
      Me.Label10.AutoSize = True
      Me.Label10.ForeColor = System.Drawing.Color.Black
      Me.Label10.Location = New System.Drawing.Point(344, 14)
      Me.Label10.Name = "Label10"
      Me.Label10.Size = New System.Drawing.Size(84, 13)
      Me.Label10.TabIndex = 37
      Me.Label10.Text = "Employee Name"
      '
      'frmSecUser
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.ClientSize = New System.Drawing.Size(967, 523)
      Me.Margin = New System.Windows.Forms.Padding(5)
      Me.Name = "frmSecUser"
      Me.Text = "Security User"
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
   Friend WithEvents txtLogin As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtUserPassword As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents chkIsAdmin As System.Windows.Forms.CheckBox
    Friend WithEvents chkAllowActual As System.Windows.Forms.CheckBox
    Friend WithEvents chkIsAllowed As System.Windows.Forms.CheckBox
   Friend WithEvents chkIsActive As System.Windows.Forms.CheckBox
   Friend WithEvents cmbEmployee As System.Windows.Forms.ComboBox
   Friend WithEvents Label10 As System.Windows.Forms.Label
End Class
