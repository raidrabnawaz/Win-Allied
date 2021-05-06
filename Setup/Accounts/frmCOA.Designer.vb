<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCOA
    Inherits System.Windows.Forms.Form
    'Inherits WinBaseForms.GUIBaseFormEntry
    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GBBody = New System.Windows.Forms.Panel()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.TrvPage = New System.Windows.Forms.TreeView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.grdAtt = New System.Windows.Forms.DataGridView()
        Me.txtParentID = New System.Windows.Forms.TextBox()
        Me.txtAccountID = New System.Windows.Forms.TextBox()
        Me.txtAccID = New System.Windows.Forms.TextBox()
        Me.txtControlAccountID = New System.Windows.Forms.TextBox()
        Me.hfType = New System.Windows.Forms.TextBox()
        Me.lblVID = New System.Windows.Forms.Label()
        Me.btnChild = New System.Windows.Forms.Button()
        Me.btnSibling = New System.Windows.Forms.Button()
        Me.chkIsBank = New System.Windows.Forms.CheckBox()
        Me.lblInformation = New System.Windows.Forms.Label()
        Me.GBFooter = New System.Windows.Forms.Panel()
        Me.cmdPrint = New System.Windows.Forms.Button()
        Me.cmdSearch = New System.Windows.Forms.Button()
        Me.cmdNew = New System.Windows.Forms.Button()
        Me.cmdSave = New System.Windows.Forms.Button()
        Me.cmdDelete = New System.Windows.Forms.Button()
        Me.cmdEdit = New System.Windows.Forms.Button()
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.chkAllowWithBank = New System.Windows.Forms.CheckBox()
        Me.chkAllowBackdate = New System.Windows.Forms.CheckBox()
        Me.chkStopTrans = New System.Windows.Forms.CheckBox()
        Me.chkControlAccount = New System.Windows.Forms.CheckBox()
        Me.txtVName = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmbAccType = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbAccGroup = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.GBHeading = New System.Windows.Forms.Panel()
        Me.lblHeading = New System.Windows.Forms.Label()
        Me.ChkIsAnalysis = New System.Windows.Forms.CheckBox()
        Me.ChkEmployee = New System.Windows.Forms.CheckBox()
        Me.ChkCustomer = New System.Windows.Forms.CheckBox()
        Me.ChkSupplier = New System.Windows.Forms.CheckBox()
        Me.ChkCostCenter = New System.Windows.Forms.CheckBox()
        Me.ChkLCCode = New System.Windows.Forms.CheckBox()
        Me.ChkWorkOrder = New System.Windows.Forms.CheckBox()
        Me.GBBody.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.grdAtt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GBFooter.SuspendLayout()
        Me.GBHeading.SuspendLayout()
        Me.SuspendLayout()
        '
        'GBBody
        '
        Me.GBBody.BackColor = System.Drawing.Color.White
        Me.GBBody.Controls.Add(Me.SplitContainer1)
        Me.GBBody.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GBBody.Location = New System.Drawing.Point(0, 42)
        Me.GBBody.Name = "GBBody"
        Me.GBBody.Size = New System.Drawing.Size(1028, 520)
        Me.GBBody.TabIndex = 4
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Margin = New System.Windows.Forms.Padding(2)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.TrvPage)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.ChkWorkOrder)
        Me.SplitContainer1.Panel2.Controls.Add(Me.ChkLCCode)
        Me.SplitContainer1.Panel2.Controls.Add(Me.ChkCostCenter)
        Me.SplitContainer1.Panel2.Controls.Add(Me.ChkSupplier)
        Me.SplitContainer1.Panel2.Controls.Add(Me.ChkCustomer)
        Me.SplitContainer1.Panel2.Controls.Add(Me.ChkEmployee)
        Me.SplitContainer1.Panel2.Controls.Add(Me.ChkIsAnalysis)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Panel1)
        Me.SplitContainer1.Panel2.Controls.Add(Me.txtParentID)
        Me.SplitContainer1.Panel2.Controls.Add(Me.txtAccountID)
        Me.SplitContainer1.Panel2.Controls.Add(Me.txtAccID)
        Me.SplitContainer1.Panel2.Controls.Add(Me.txtControlAccountID)
        Me.SplitContainer1.Panel2.Controls.Add(Me.hfType)
        Me.SplitContainer1.Panel2.Controls.Add(Me.lblVID)
        Me.SplitContainer1.Panel2.Controls.Add(Me.btnChild)
        Me.SplitContainer1.Panel2.Controls.Add(Me.btnSibling)
        Me.SplitContainer1.Panel2.Controls.Add(Me.chkIsBank)
        Me.SplitContainer1.Panel2.Controls.Add(Me.lblInformation)
        Me.SplitContainer1.Panel2.Controls.Add(Me.GBFooter)
        Me.SplitContainer1.Panel2.Controls.Add(Me.chkAllowWithBank)
        Me.SplitContainer1.Panel2.Controls.Add(Me.chkAllowBackdate)
        Me.SplitContainer1.Panel2.Controls.Add(Me.chkStopTrans)
        Me.SplitContainer1.Panel2.Controls.Add(Me.chkControlAccount)
        Me.SplitContainer1.Panel2.Controls.Add(Me.txtVName)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label4)
        Me.SplitContainer1.Panel2.Controls.Add(Me.cmbAccType)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label1)
        Me.SplitContainer1.Panel2.Controls.Add(Me.cmbAccGroup)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label2)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label3)
        Me.SplitContainer1.Panel2.Controls.Add(Me.txtID)
        Me.SplitContainer1.Size = New System.Drawing.Size(1028, 520)
        Me.SplitContainer1.SplitterDistance = 365
        Me.SplitContainer1.SplitterWidth = 3
        Me.SplitContainer1.TabIndex = 0
        '
        'TrvPage
        '
        Me.TrvPage.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TrvPage.Location = New System.Drawing.Point(0, 0)
        Me.TrvPage.Name = "TrvPage"
        Me.TrvPage.Size = New System.Drawing.Size(365, 520)
        Me.TrvPage.TabIndex = 2
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.grdAtt)
        Me.Panel1.Location = New System.Drawing.Point(611, 87)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(109, 61)
        Me.Panel1.TabIndex = 70
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
        'txtParentID
        '
        Me.txtParentID.Enabled = False
        Me.txtParentID.Location = New System.Drawing.Point(339, 298)
        Me.txtParentID.MaxLength = 50
        Me.txtParentID.Name = "txtParentID"
        Me.txtParentID.Size = New System.Drawing.Size(381, 20)
        Me.txtParentID.TabIndex = 54
        Me.txtParentID.Visible = False
        '
        'txtAccountID
        '
        Me.txtAccountID.Enabled = False
        Me.txtAccountID.Location = New System.Drawing.Point(339, 376)
        Me.txtAccountID.MaxLength = 50
        Me.txtAccountID.Name = "txtAccountID"
        Me.txtAccountID.Size = New System.Drawing.Size(381, 20)
        Me.txtAccountID.TabIndex = 53
        Me.txtAccountID.Visible = False
        '
        'txtAccID
        '
        Me.txtAccID.Enabled = False
        Me.txtAccID.Location = New System.Drawing.Point(339, 402)
        Me.txtAccID.MaxLength = 50
        Me.txtAccID.Name = "txtAccID"
        Me.txtAccID.Size = New System.Drawing.Size(381, 20)
        Me.txtAccID.TabIndex = 52
        Me.txtAccID.Visible = False
        '
        'txtControlAccountID
        '
        Me.txtControlAccountID.Enabled = False
        Me.txtControlAccountID.Location = New System.Drawing.Point(339, 350)
        Me.txtControlAccountID.MaxLength = 50
        Me.txtControlAccountID.Name = "txtControlAccountID"
        Me.txtControlAccountID.Size = New System.Drawing.Size(381, 20)
        Me.txtControlAccountID.TabIndex = 51
        Me.txtControlAccountID.Visible = False
        '
        'hfType
        '
        Me.hfType.Enabled = False
        Me.hfType.Location = New System.Drawing.Point(339, 324)
        Me.hfType.MaxLength = 50
        Me.hfType.Name = "hfType"
        Me.hfType.Size = New System.Drawing.Size(381, 20)
        Me.hfType.TabIndex = 50
        Me.hfType.Visible = False
        '
        'lblVID
        '
        Me.lblVID.AutoSize = True
        Me.lblVID.ForeColor = System.Drawing.Color.Black
        Me.lblVID.Location = New System.Drawing.Point(29, 288)
        Me.lblVID.Name = "lblVID"
        Me.lblVID.Size = New System.Drawing.Size(25, 13)
        Me.lblVID.TabIndex = 49
        Me.lblVID.Text = "VID"
        Me.lblVID.Visible = False
        '
        'btnChild
        '
        Me.btnChild.BackColor = System.Drawing.Color.LightGray
        Me.btnChild.Location = New System.Drawing.Point(221, 283)
        Me.btnChild.Name = "btnChild"
        Me.btnChild.Size = New System.Drawing.Size(75, 23)
        Me.btnChild.TabIndex = 10
        Me.btnChild.Text = "Child"
        Me.btnChild.UseVisualStyleBackColor = False
        '
        'btnSibling
        '
        Me.btnSibling.BackColor = System.Drawing.Color.LightGray
        Me.btnSibling.Location = New System.Drawing.Point(111, 283)
        Me.btnSibling.Name = "btnSibling"
        Me.btnSibling.Size = New System.Drawing.Size(75, 23)
        Me.btnSibling.TabIndex = 9
        Me.btnSibling.Text = "Sibling"
        Me.btnSibling.UseVisualStyleBackColor = False
        '
        'chkIsBank
        '
        Me.chkIsBank.AutoSize = True
        Me.chkIsBank.Enabled = False
        Me.chkIsBank.Location = New System.Drawing.Point(378, 213)
        Me.chkIsBank.Name = "chkIsBank"
        Me.chkIsBank.Size = New System.Drawing.Size(62, 17)
        Me.chkIsBank.TabIndex = 5
        Me.chkIsBank.Text = "Is Bank"
        Me.chkIsBank.UseVisualStyleBackColor = True
        Me.chkIsBank.Visible = False
        '
        'lblInformation
        '
        Me.lblInformation.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInformation.ForeColor = System.Drawing.Color.Green
        Me.lblInformation.Location = New System.Drawing.Point(30, 44)
        Me.lblInformation.Name = "lblInformation"
        Me.lblInformation.Size = New System.Drawing.Size(488, 22)
        Me.lblInformation.TabIndex = 0
        Me.lblInformation.Text = "."
        '
        'GBFooter
        '
        Me.GBFooter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GBFooter.Controls.Add(Me.cmdPrint)
        Me.GBFooter.Controls.Add(Me.cmdSearch)
        Me.GBFooter.Controls.Add(Me.cmdNew)
        Me.GBFooter.Controls.Add(Me.cmdSave)
        Me.GBFooter.Controls.Add(Me.cmdDelete)
        Me.GBFooter.Controls.Add(Me.cmdEdit)
        Me.GBFooter.Controls.Add(Me.cmdCancel)
        Me.GBFooter.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GBFooter.Location = New System.Drawing.Point(0, 444)
        Me.GBFooter.Name = "GBFooter"
        Me.GBFooter.Size = New System.Drawing.Size(660, 76)
        Me.GBFooter.TabIndex = 46
        '
        'cmdPrint
        '
        Me.cmdPrint.BackColor = System.Drawing.Color.Transparent
        Me.cmdPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdPrint.ForeColor = System.Drawing.Color.White
        Me.cmdPrint.Image = Global.WinBusiness.My.Resources.Resources.btn_cancel1
        Me.cmdPrint.Location = New System.Drawing.Point(265, 8)
        Me.cmdPrint.Margin = New System.Windows.Forms.Padding(0)
        Me.cmdPrint.Name = "cmdPrint"
        Me.cmdPrint.Size = New System.Drawing.Size(66, 61)
        Me.cmdPrint.TabIndex = 2
        Me.cmdPrint.Text = "&Excel Export"
        Me.cmdPrint.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdPrint.UseVisualStyleBackColor = False
        '
        'cmdSearch
        '
        Me.cmdSearch.BackColor = System.Drawing.Color.Transparent
        Me.cmdSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdSearch.ForeColor = System.Drawing.Color.White
        Me.cmdSearch.Image = Global.WinBusiness.My.Resources.Resources.btn_preview
        Me.cmdSearch.Location = New System.Drawing.Point(199, 8)
        Me.cmdSearch.Margin = New System.Windows.Forms.Padding(0)
        Me.cmdSearch.Name = "cmdSearch"
        Me.cmdSearch.Size = New System.Drawing.Size(66, 61)
        Me.cmdSearch.TabIndex = 1
        Me.cmdSearch.Text = "Searc&h"
        Me.cmdSearch.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdSearch.UseVisualStyleBackColor = False
        '
        'cmdNew
        '
        Me.cmdNew.BackColor = System.Drawing.Color.Transparent
        Me.cmdNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdNew.ForeColor = System.Drawing.Color.White
        Me.cmdNew.Location = New System.Drawing.Point(68, 8)
        Me.cmdNew.Margin = New System.Windows.Forms.Padding(0)
        Me.cmdNew.Name = "cmdNew"
        Me.cmdNew.Size = New System.Drawing.Size(66, 61)
        Me.cmdNew.TabIndex = 45
        Me.cmdNew.Text = "&New"
        Me.cmdNew.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdNew.UseVisualStyleBackColor = False
        Me.cmdNew.Visible = False
        '
        'cmdSave
        '
        Me.cmdSave.BackColor = System.Drawing.Color.Transparent
        Me.cmdSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdSave.ForeColor = System.Drawing.Color.White
        Me.cmdSave.Image = Global.WinBusiness.My.Resources.Resources.btn_save
        Me.cmdSave.Location = New System.Drawing.Point(134, 8)
        Me.cmdSave.Margin = New System.Windows.Forms.Padding(0)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(66, 61)
        Me.cmdSave.TabIndex = 0
        Me.cmdSave.Text = "&Save"
        Me.cmdSave.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdSave.UseVisualStyleBackColor = False
        '
        'cmdDelete
        '
        Me.cmdDelete.BackColor = System.Drawing.Color.Transparent
        Me.cmdDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdDelete.ForeColor = System.Drawing.Color.White
        Me.cmdDelete.Location = New System.Drawing.Point(466, 6)
        Me.cmdDelete.Margin = New System.Windows.Forms.Padding(0)
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.Size = New System.Drawing.Size(66, 61)
        Me.cmdDelete.TabIndex = 44
        Me.cmdDelete.Text = "&Delete"
        Me.cmdDelete.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdDelete.UseVisualStyleBackColor = False
        Me.cmdDelete.Visible = False
        '
        'cmdEdit
        '
        Me.cmdEdit.BackColor = System.Drawing.Color.Transparent
        Me.cmdEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdEdit.ForeColor = System.Drawing.Color.White
        Me.cmdEdit.Location = New System.Drawing.Point(491, 8)
        Me.cmdEdit.Margin = New System.Windows.Forms.Padding(0)
        Me.cmdEdit.Name = "cmdEdit"
        Me.cmdEdit.Size = New System.Drawing.Size(66, 61)
        Me.cmdEdit.TabIndex = 41
        Me.cmdEdit.Text = "&Edit"
        Me.cmdEdit.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdEdit.UseVisualStyleBackColor = False
        Me.cmdEdit.Visible = False
        '
        'cmdCancel
        '
        Me.cmdCancel.BackColor = System.Drawing.Color.Transparent
        Me.cmdCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdCancel.ForeColor = System.Drawing.Color.White
        Me.cmdCancel.Image = Global.WinBusiness.My.Resources.Resources.btn_cancel1
        Me.cmdCancel.Location = New System.Drawing.Point(331, 8)
        Me.cmdCancel.Margin = New System.Windows.Forms.Padding(0)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(66, 61)
        Me.cmdCancel.TabIndex = 3
        Me.cmdCancel.Text = "&Cancel"
        Me.cmdCancel.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdCancel.UseVisualStyleBackColor = False
        '
        'chkAllowWithBank
        '
        Me.chkAllowWithBank.AutoSize = True
        Me.chkAllowWithBank.Location = New System.Drawing.Point(111, 248)
        Me.chkAllowWithBank.Name = "chkAllowWithBank"
        Me.chkAllowWithBank.Size = New System.Drawing.Size(104, 17)
        Me.chkAllowWithBank.TabIndex = 6
        Me.chkAllowWithBank.Text = "Allow With Bank"
        Me.chkAllowWithBank.UseVisualStyleBackColor = True
        '
        'chkAllowBackdate
        '
        Me.chkAllowBackdate.AutoSize = True
        Me.chkAllowBackdate.Enabled = False
        Me.chkAllowBackdate.Location = New System.Drawing.Point(378, 260)
        Me.chkAllowBackdate.Name = "chkAllowBackdate"
        Me.chkAllowBackdate.Size = New System.Drawing.Size(100, 17)
        Me.chkAllowBackdate.TabIndex = 8
        Me.chkAllowBackdate.Text = "Allow Backdate"
        Me.chkAllowBackdate.UseVisualStyleBackColor = True
        Me.chkAllowBackdate.Visible = False
        '
        'chkStopTrans
        '
        Me.chkStopTrans.AutoSize = True
        Me.chkStopTrans.Location = New System.Drawing.Point(111, 224)
        Me.chkStopTrans.Name = "chkStopTrans"
        Me.chkStopTrans.Size = New System.Drawing.Size(107, 17)
        Me.chkStopTrans.TabIndex = 4
        Me.chkStopTrans.Text = "Stop Transection"
        Me.chkStopTrans.UseVisualStyleBackColor = True
        '
        'chkControlAccount
        '
        Me.chkControlAccount.AutoSize = True
        Me.chkControlAccount.Enabled = False
        Me.chkControlAccount.Location = New System.Drawing.Point(378, 236)
        Me.chkControlAccount.Name = "chkControlAccount"
        Me.chkControlAccount.Size = New System.Drawing.Size(102, 17)
        Me.chkControlAccount.TabIndex = 7
        Me.chkControlAccount.Text = "Control Account"
        Me.chkControlAccount.UseVisualStyleBackColor = True
        Me.chkControlAccount.Visible = False
        '
        'txtVName
        '
        Me.txtVName.Location = New System.Drawing.Point(111, 188)
        Me.txtVName.MaxLength = 50
        Me.txtVName.Name = "txtVName"
        Me.txtVName.Size = New System.Drawing.Size(381, 20)
        Me.txtVName.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(22, 188)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Account"
        '
        'cmbAccType
        '
        Me.cmbAccType.BackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.cmbAccType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbAccType.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.cmbAccType.FormattingEnabled = True
        Me.cmbAccType.Location = New System.Drawing.Point(111, 159)
        Me.cmbAccType.Name = "cmbAccType"
        Me.cmbAccType.Size = New System.Drawing.Size(381, 24)
        Me.cmbAccType.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(22, 164)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Account Type"
        '
        'cmbAccGroup
        '
        Me.cmbAccGroup.BackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.cmbAccGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbAccGroup.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.cmbAccGroup.FormattingEnabled = True
        Me.cmbAccGroup.Location = New System.Drawing.Point(111, 130)
        Me.cmbAccGroup.Name = "cmbAccGroup"
        Me.cmbAccGroup.Size = New System.Drawing.Size(381, 24)
        Me.cmbAccGroup.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(22, 135)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Account Group"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(22, 108)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Code"
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(111, 106)
        Me.txtID.Name = "txtID"
        Me.txtID.ReadOnly = True
        Me.txtID.Size = New System.Drawing.Size(381, 20)
        Me.txtID.TabIndex = 0
        '
        'GBHeading
        '
        Me.GBHeading.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GBHeading.Controls.Add(Me.lblHeading)
        Me.GBHeading.Dock = System.Windows.Forms.DockStyle.Top
        Me.GBHeading.Location = New System.Drawing.Point(0, 0)
        Me.GBHeading.Name = "GBHeading"
        Me.GBHeading.Size = New System.Drawing.Size(1028, 42)
        Me.GBHeading.TabIndex = 2
        '
        'lblHeading
        '
        Me.lblHeading.BackColor = System.Drawing.Color.Transparent
        Me.lblHeading.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblHeading.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeading.Location = New System.Drawing.Point(0, 0)
        Me.lblHeading.Margin = New System.Windows.Forms.Padding(0)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(1028, 42)
        Me.lblHeading.TabIndex = 1
        Me.lblHeading.Text = "Chart Of Accounts"
        Me.lblHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ChkIsAnalysis
        '
        Me.ChkIsAnalysis.AutoSize = True
        Me.ChkIsAnalysis.Location = New System.Drawing.Point(27, 324)
        Me.ChkIsAnalysis.Name = "ChkIsAnalysis"
        Me.ChkIsAnalysis.Size = New System.Drawing.Size(72, 17)
        Me.ChkIsAnalysis.TabIndex = 71
        Me.ChkIsAnalysis.Text = "IsAnalysis"
        Me.ChkIsAnalysis.UseVisualStyleBackColor = True
        '
        'ChkEmployee
        '
        Me.ChkEmployee.AutoSize = True
        Me.ChkEmployee.Location = New System.Drawing.Point(27, 350)
        Me.ChkEmployee.Name = "ChkEmployee"
        Me.ChkEmployee.Size = New System.Drawing.Size(72, 17)
        Me.ChkEmployee.TabIndex = 72
        Me.ChkEmployee.Text = "Employee"
        Me.ChkEmployee.UseVisualStyleBackColor = True
        '
        'ChkCustomer
        '
        Me.ChkCustomer.AutoSize = True
        Me.ChkCustomer.Location = New System.Drawing.Point(27, 376)
        Me.ChkCustomer.Name = "ChkCustomer"
        Me.ChkCustomer.Size = New System.Drawing.Size(70, 17)
        Me.ChkCustomer.TabIndex = 73
        Me.ChkCustomer.Text = "Customer"
        Me.ChkCustomer.UseVisualStyleBackColor = True
        '
        'ChkSupplier
        '
        Me.ChkSupplier.AutoSize = True
        Me.ChkSupplier.Location = New System.Drawing.Point(27, 405)
        Me.ChkSupplier.Name = "ChkSupplier"
        Me.ChkSupplier.Size = New System.Drawing.Size(64, 17)
        Me.ChkSupplier.TabIndex = 74
        Me.ChkSupplier.Text = "Supplier"
        Me.ChkSupplier.UseVisualStyleBackColor = True
        '
        'ChkCostCenter
        '
        Me.ChkCostCenter.AutoSize = True
        Me.ChkCostCenter.Location = New System.Drawing.Point(189, 324)
        Me.ChkCostCenter.Name = "ChkCostCenter"
        Me.ChkCostCenter.Size = New System.Drawing.Size(81, 17)
        Me.ChkCostCenter.TabIndex = 75
        Me.ChkCostCenter.Text = "Cost Center"
        Me.ChkCostCenter.UseVisualStyleBackColor = True
        '
        'ChkLCCode
        '
        Me.ChkLCCode.AutoSize = True
        Me.ChkLCCode.Location = New System.Drawing.Point(189, 350)
        Me.ChkLCCode.Name = "ChkLCCode"
        Me.ChkLCCode.Size = New System.Drawing.Size(67, 17)
        Me.ChkLCCode.TabIndex = 76
        Me.ChkLCCode.Text = "LC Code"
        Me.ChkLCCode.UseVisualStyleBackColor = True
        '
        'ChkWorkOrder
        '
        Me.ChkWorkOrder.AutoSize = True
        Me.ChkWorkOrder.Location = New System.Drawing.Point(189, 376)
        Me.ChkWorkOrder.Name = "ChkWorkOrder"
        Me.ChkWorkOrder.Size = New System.Drawing.Size(81, 17)
        Me.ChkWorkOrder.TabIndex = 77
        Me.ChkWorkOrder.Text = "Work Order"
        Me.ChkWorkOrder.UseVisualStyleBackColor = True
        '
        'frmCOA
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1028, 562)
        Me.Controls.Add(Me.GBBody)
        Me.Controls.Add(Me.GBHeading)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCOA"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Chart Of Accounts"
        Me.GBBody.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.grdAtt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GBFooter.ResumeLayout(False)
        Me.GBHeading.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Protected WithEvents GBHeading As System.Windows.Forms.Panel
   Protected WithEvents GBBody As System.Windows.Forms.Panel
   Public WithEvents lblHeading As System.Windows.Forms.Label
   Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
   Friend WithEvents TrvPage As System.Windows.Forms.TreeView
   Friend WithEvents Label3 As System.Windows.Forms.Label
   Friend WithEvents txtID As System.Windows.Forms.TextBox
   Friend WithEvents cmbAccType As System.Windows.Forms.ComboBox
   Friend WithEvents Label1 As System.Windows.Forms.Label
   Friend WithEvents cmbAccGroup As System.Windows.Forms.ComboBox
   Friend WithEvents Label2 As System.Windows.Forms.Label
   Friend WithEvents txtVName As System.Windows.Forms.TextBox
   Friend WithEvents Label4 As System.Windows.Forms.Label
   Friend WithEvents chkAllowWithBank As System.Windows.Forms.CheckBox
   Friend WithEvents chkAllowBackdate As System.Windows.Forms.CheckBox
   Friend WithEvents chkStopTrans As System.Windows.Forms.CheckBox
   Friend WithEvents chkControlAccount As System.Windows.Forms.CheckBox
   Protected WithEvents cmdNew As System.Windows.Forms.Button
   Protected WithEvents cmdDelete As System.Windows.Forms.Button
   Protected WithEvents cmdCancel As System.Windows.Forms.Button
   Protected WithEvents cmdEdit As System.Windows.Forms.Button
   Protected WithEvents cmdSave As System.Windows.Forms.Button
   Protected WithEvents GBFooter As System.Windows.Forms.Panel
   Friend WithEvents lblInformation As System.Windows.Forms.Label
   Friend WithEvents chkIsBank As System.Windows.Forms.CheckBox
   Friend WithEvents btnChild As Button
   Friend WithEvents btnSibling As Button
   Friend WithEvents lblVID As Label
   Friend WithEvents txtAccountID As TextBox
   Friend WithEvents txtAccID As TextBox
   Friend WithEvents txtControlAccountID As TextBox
   Friend WithEvents hfType As TextBox
   Friend WithEvents txtParentID As TextBox
   Protected WithEvents cmdSearch As System.Windows.Forms.Button
   Protected WithEvents cmdPrint As System.Windows.Forms.Button
   Friend WithEvents Panel1 As System.Windows.Forms.Panel
   Friend WithEvents grdAtt As System.Windows.Forms.DataGridView
    Friend WithEvents ChkWorkOrder As CheckBox
    Friend WithEvents ChkLCCode As CheckBox
    Friend WithEvents ChkCostCenter As CheckBox
    Friend WithEvents ChkSupplier As CheckBox
    Friend WithEvents ChkCustomer As CheckBox
    Friend WithEvents ChkEmployee As CheckBox
    Friend WithEvents ChkIsAnalysis As CheckBox
End Class
