<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDatabaseBackup
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDatabaseBackup))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtServerName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtDatabaseName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmdSave = New System.Windows.Forms.Button()
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.cmdPictureUpload = New System.Windows.Forms.Button()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.txtPath = New System.Windows.Forms.TextBox()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.GBHeading.SuspendLayout()
        Me.GBFooter.SuspendLayout()
        Me.GBBody.SuspendLayout()
        Me.SuspendLayout()
        '
        'GBHeading
        '
        Me.GBHeading.Margin = New System.Windows.Forms.Padding(5)
        Me.GBHeading.Size = New System.Drawing.Size(729, 52)
        '
        'GBFooter
        '
        Me.GBFooter.Controls.Add(Me.cmdCancel)
        Me.GBFooter.Controls.Add(Me.cmdSave)
        Me.GBFooter.Location = New System.Drawing.Point(0, 324)
        Me.GBFooter.Margin = New System.Windows.Forms.Padding(5)
        Me.GBFooter.Size = New System.Drawing.Size(729, 94)
        '
        'GBBody
        '
        Me.GBBody.Controls.Add(Me.txtPath)
        Me.GBBody.Controls.Add(Me.cmdPictureUpload)
        Me.GBBody.Controls.Add(Me.Label3)
        Me.GBBody.Controls.Add(Me.Label2)
        Me.GBBody.Controls.Add(Me.txtDatabaseName)
        Me.GBBody.Controls.Add(Me.Label1)
        Me.GBBody.Controls.Add(Me.txtServerName)
        Me.GBBody.Margin = New System.Windows.Forms.Padding(5)
        Me.GBBody.Size = New System.Drawing.Size(729, 272)
        '
        'lblHeading
        '
        Me.lblHeading.Size = New System.Drawing.Size(729, 52)
        Me.lblHeading.Text = "Database Backup Form"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(49, 48)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Server Name"
        '
        'txtServerName
        '
        Me.txtServerName.Location = New System.Drawing.Point(181, 44)
        Me.txtServerName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtServerName.MaxLength = 0
        Me.txtServerName.Name = "txtServerName"
        Me.txtServerName.ReadOnly = True
        Me.txtServerName.Size = New System.Drawing.Size(496, 22)
        Me.txtServerName.TabIndex = 1
        Me.txtServerName.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(49, 78)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(110, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Database Name"
        '
        'txtDatabaseName
        '
        Me.txtDatabaseName.BackColor = System.Drawing.SystemColors.Control
        Me.txtDatabaseName.Location = New System.Drawing.Point(181, 74)
        Me.txtDatabaseName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDatabaseName.MaxLength = 0
        Me.txtDatabaseName.Name = "txtDatabaseName"
        Me.txtDatabaseName.ReadOnly = True
        Me.txtDatabaseName.Size = New System.Drawing.Size(496, 22)
        Me.txtDatabaseName.TabIndex = 3
        Me.txtDatabaseName.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(49, 108)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(122, 17)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Select Destination"
        '
        'cmdSave
        '
        Me.cmdSave.BackColor = System.Drawing.Color.Transparent
        Me.cmdSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdSave.ForeColor = System.Drawing.Color.White
        Me.cmdSave.Image = Global.WinBusiness.My.Resources.Resources.btn_save
        Me.cmdSave.Location = New System.Drawing.Point(256, 10)
        Me.cmdSave.Margin = New System.Windows.Forms.Padding(0)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(88, 75)
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
        Me.cmdCancel.Location = New System.Drawing.Point(345, 10)
        Me.cmdCancel.Margin = New System.Windows.Forms.Padding(0)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(88, 75)
        Me.cmdCancel.TabIndex = 5
        Me.cmdCancel.Text = "&Cancel"
        Me.cmdCancel.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdCancel.UseVisualStyleBackColor = False
        '
        'cmdPictureUpload
        '
        Me.cmdPictureUpload.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdPictureUpload.Image = CType(resources.GetObject("cmdPictureUpload.Image"), System.Drawing.Image)
        Me.cmdPictureUpload.Location = New System.Drawing.Point(181, 104)
        Me.cmdPictureUpload.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdPictureUpload.Name = "cmdPictureUpload"
        Me.cmdPictureUpload.Size = New System.Drawing.Size(44, 27)
        Me.cmdPictureUpload.TabIndex = 31
        Me.cmdPictureUpload.UseVisualStyleBackColor = True
        '
        'txtPath
        '
        Me.txtPath.BackColor = System.Drawing.SystemColors.Control
        Me.txtPath.Location = New System.Drawing.Point(181, 139)
        Me.txtPath.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPath.MaxLength = 0
        Me.txtPath.Name = "txtPath"
        Me.txtPath.ReadOnly = True
        Me.txtPath.Size = New System.Drawing.Size(496, 22)
        Me.txtPath.TabIndex = 32
        Me.txtPath.TabStop = False
        '
        'frmDatabaseBackup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(729, 418)
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "frmDatabaseBackup"
        Me.Text = "Database Backup Form"
        Me.GBHeading.ResumeLayout(False)
        Me.GBFooter.ResumeLayout(False)
        Me.GBBody.ResumeLayout(False)
        Me.GBBody.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtDatabaseName As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtServerName As System.Windows.Forms.TextBox
    Protected WithEvents cmdSave As System.Windows.Forms.Button
    Protected WithEvents cmdCancel As System.Windows.Forms.Button
    Friend WithEvents cmdPictureUpload As System.Windows.Forms.Button
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents txtPath As System.Windows.Forms.TextBox
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
End Class
