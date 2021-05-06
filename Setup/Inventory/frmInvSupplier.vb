Public Class frmInvSupplier
    Dim qryMain, qry, Verify As String
    Dim objCommon As New clsCommon
    Private Sub frmAttCode_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        G_CURRENTDATE = Date.Now
        If G_CURRENTDATE > G_SOFTENDDATE Then
            End
        End If
        qry = " Select count(VID) from InvSupplier where AccountID=0"
        Dim Cate = objCommon.ExecuteScalar(qry)
        If Cate > 0 Then
            MessageBox.Show(Cate + " Suppliers donnot have GLCodes linked", G_APP_TITLE)

        End If
        txtID.Text = ""
        objCommon.FillPaymentTerm(Me.cmbPaymentTerm)
        objCommon.FillCOuntry(Me.cmbCountry)
        ClearHead("")
        FillHeader()
        FillGrid()
        txtVName.Focus()
    End Sub
    Private Sub ClearHead(ByVal myid As String)
        For Each ctl In SplitContainer1.Panel1.Controls
            If TypeOf ctl Is TextBox Then ctl.Text = ""
        Next ctl
        lblSupplierGLID.Text = "0"
        txtCreditDays.Text = "0"
        lblInformation.Text = ""
        cmbPaymentTerm.SelectedIndex = 0
        cmbCountry.SelectedIndex = 0
        cmbVType.SelectedIndex = 0
        lblAdvGLCode.Text = "0"

    End Sub
    Private Sub FillHeader()
        'grdRecord.DataSource = Nothing
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim grdcol0 As System.Windows.Forms.DataGridViewTextBoxColumn
        Dim grdcol1 As System.Windows.Forms.DataGridViewTextBoxColumn
        Dim grdcol2 As System.Windows.Forms.DataGridViewTextBoxColumn
        Dim grdcol3 As System.Windows.Forms.DataGridViewTextBoxColumn
        Dim grdcol4 As System.Windows.Forms.DataGridViewTextBoxColumn
        Dim grdcol5 As System.Windows.Forms.DataGridViewTextBoxColumn
        Dim grdcol6 As System.Windows.Forms.DataGridViewTextBoxColumn
        Dim grdcol7 As System.Windows.Forms.DataGridViewTextBoxColumn
        Dim grdcol8 As System.Windows.Forms.DataGridViewTextBoxColumn
        Dim grdcol9 As System.Windows.Forms.DataGridViewTextBoxColumn
        Dim grdcol10 As System.Windows.Forms.DataGridViewTextBoxColumn
        Dim grdcol11 As System.Windows.Forms.DataGridViewTextBoxColumn

        grdcol0 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        grdcol1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        grdcol2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        grdcol3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        grdcol4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        grdcol5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        grdcol6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        grdcol7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        grdcol8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        grdcol9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        grdcol10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        grdcol11 = New System.Windows.Forms.DataGridViewTextBoxColumn()

        grdcol0.DataPropertyName = "VID"
        grdcol0.HeaderText = "VID"
        grdcol0.Name = "grdcol0"
        grdcol0.Visible = False
        '
        'grdcol1     VID, VName, GLPurchaseCode, GLCostCode, ItemFor, IsFixedAsset, DepriPer, LifeMonth
        '
        grdcol1.DataPropertyName = "VCode"
        grdcol1.HeaderText = "Code"
        grdcol1.Name = "grdcol1"
        grdcol1.Width = 50

        grdcol2.DataPropertyName = "VName"
        grdcol2.HeaderText = "Description"
        grdcol2.Name = "grdcol2"
        grdcol2.Width = 400
        '
        'grdcol2
        '
        grdcol3.DataPropertyName = "PaymentTermID"
        grdcol3.HeaderText = "PaymentTermID"
        grdcol3.Name = "grdcol3"
        grdcol3.Visible = False


        grdcol4.DataPropertyName = "PaymentTermName"
        grdcol4.HeaderText = "PaymentTerm"
        grdcol4.Name = "grdcol4"
        grdcol4.Width = 100
        'ContactPerson, Creditdays, CNIC, SupplierBank, PayTo
        grdcol5.DataPropertyName = "ContactPerson"
        grdcol5.HeaderText = "Contact Person"
        grdcol5.Name = "grdcol5"
        grdcol5.Width = 100

        grdcol6.DataPropertyName = "CNIC"
        grdcol6.HeaderText = "CNIC"
        grdcol6.Name = "grdcol6"
        grdcol6.Visible = False

        grdcol7.DataPropertyName = "SupplierBank"
        grdcol7.HeaderText = "SupplierBank"
        grdcol7.Name = "grdcol7"
        grdcol7.Width = 100

        grdcol8.DataPropertyName = "PayTo"
        grdcol8.HeaderText = "Pay To"
        grdcol8.Name = "grdcol8"
        grdcol8.Visible = False


        grdcol9.DataPropertyName = "AccountID"
        grdcol9.HeaderText = "AccountID"
        grdcol9.Name = "grdcol9"
        grdcol9.Visible = False


        grdcol10.DataPropertyName = "COAAccount"
        grdcol10.HeaderText = "Supplier GL Code"
        grdcol10.Name = "grdcol10"
        grdcol10.Width = 150



        grdcol11.DataPropertyName = "Creditdays"
        grdcol11.HeaderText = "Creditdays"
        grdcol11.Name = "grdcol11"
        grdcol11.Visible = False


        Me.grdRecord.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {grdcol0, grdcol1, grdcol2, grdcol3, grdcol4, grdcol5, grdcol6, grdcol7, grdcol8, grdcol9, grdcol10, grdcol11})
    End Sub
    Private Sub FillGrid()
        'grdRecord.DataSource = Nothing
        qryMain = "EXEC SpGet_invSupplier"
        Dim dt As DataTable = objCommon.GetDataTable(qryMain)
        If IsNothing(dt) Then
            'EmptyFields()
            Return
        End If
        If dt.Rows.Count <= 0 Then
            'EmptyFields()
            Return
        End If
        grdRecord.DataSource = dt
    End Sub
    Private Sub FillForm()
        lblInformation.Text = ""
        If txtID.Text = "" Then
            ClearHead("")
            Return
        End If
        qryMain = "EXEC SpGet_invSupplier'" & txtID.Text & "' "
        Dim dt As DataTable = objCommon.GetDataTable(qryMain)
        If IsNothing(dt) Then
            'EmptyFields()
            Return
        End If
        If dt.Rows.Count <= 0 Then
            'EmptyFields()     VID, VName, GLPurchaseCode, GLCostCode, ItemFor, IsFixedAsset, DepriPer, LifeMonth
            Return
        End If
        Dim dr As DataRow = dt.Rows(0)

        'VID,VCode, VName, PaymentTermID, ContactPerson, Country, City, VType, Address, Creditdays, CNIC, SupplierBank, PayTo, Email, Phone, Fax, TaxNumber
        Try
            txtVName.Text = dr("VName")
            txtVCode.Text = dr("VCode")
            cmbPaymentTerm.SelectedValue = dr("PaymentTermID")
            txtContactPerson.Text = dr("ContactPerson")
            cmbCountry.SelectedValue = dr("Country")
            txtCity.Text = dr("City")
            cmbVType.SelectedItem = dr("VType")
            txtAddress.Text = dr("Address")
            txtCreditDays.Text = dr("Creditdays")
            txtSupAdvGLCode.Text = dr("AdvGLName")
            lblAdvGLCode.Text = dr("AdvGLCode")
            txtBankDetail.Text = dr("SupplierBank")
            txtSupplierGL.Text = dr("COAAccount")
            lblSupplierGLID.Text = dr("AccountID")
            txtPayTo.Text = dr("PayTo")
            'txtEmail.Text = dr("Email")
            If dr("Email") Is DBNull.Value Then txtEmail.Text = "" Else txtEmail.Text = dr("Email")
            If dr("Phone") Is DBNull.Value Then txtPhoneNo.Text = "" Else txtPhoneNo.Text = dr("Phone")
            If dr("Fax") Is DBNull.Value Then txtFax.Text = "" Else txtFax.Text = dr("Fax")
            If dr("TaxNumber") Is DBNull.Value Then txtNTN.Text = "" Else txtNTN.Text = dr("TaxNumber")
            'txtFax.Text = dr("Fax")
            'txtNTN.Text = dr("TaxNumber")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub
    Private Sub cmdNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNew.Click
        ClearHead("")
        txtVName.Focus()
    End Sub
    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        lblInformation.Text = ""
        'varify for empty string   
        qryMain = "EXEC SpGetAlreadyExist_InvSupplier " & Setdouble(txtID.Text) & ",'" & txtVCode.Text & "'"
        Verify = objCommon.ExecuteScalar(qryMain)
        If Not Verify = "0" Then
            MessageBox.Show("Supplier Already Exist with this Code", G_APP_TITLE)
            txtVCode.Focus()
            Return
        End If
        'varify already existance
        txtVName.Text = txtVName.Text.Trim.Replace("'", "")
        If txtVCode.Text = "" Then
            MessageBox.Show("Please give some Code.", G_APP_TITLE)
            txtVCode.Focus()
            Return
        End If
        If txtVName.Text = "" Then
            MessageBox.Show("Please give some Supplier Name.", G_APP_TITLE)
            txtVName.Focus()
            Return
        End If
        If cmbPaymentTerm.SelectedIndex <= 0 Then
            MessageBox.Show("Please select some Payment Term.", G_APP_TITLE)
            cmbPaymentTerm.Focus()
            Return
        End If
        'qryMain = " Select top 1 isnull(L1Code,'') as L1Code from tblAcSetupCOAL1 where L1Code <> '" & txtID.Text & "' and VName='" & txtVName.Text & "'; "
        'qryMain = objCommon.ExecuteScalar(qryMain)
        'If qryMain <> "" Then
        '    MessageBox.Show("Account already exists.", G_APP_TITLE)
        '    Return
        'End If

        If txtID.Text = "" Then
            txtID.Text = 0
        End If


        qryMain = "EXEC SpSaveInvSupplier " & txtID.Text & ",'" & txtVCode.Text & "','" & txtVName.Text & "'," & cmbPaymentTerm.SelectedIndex & "," & lblSupplierGLID.Text & "," & lblAdvGLCode.Text & ",'" & txtContactPerson.Text & "'," & cmbCountry.SelectedValue & ",'" & txtCity.Text & "'," & cmbVType.SelectedItem & ",'" & txtAddress.Text & "'," & txtCreditDays.Text & ",'0','" & txtBankDetail.Text & "','" & txtPayTo.Text & "','" & txtEmail.Text & "','" & txtPhoneNo.Text & "','" & txtFax.Text & "','" & txtNTN.Text & "'," & G_Compcode & ",1," & G_UID & ",'" & G_IPAddress & "'," & G_UID & ",'" & G_IPAddress & "'"
        objCommon.ExecuteNonQuery(qryMain)
        '
        ClearHead("")
        FillGrid()
        lblInformation.Text = "Record Saved."
        txtVName.Focus()
    End Sub
    Private Sub cmdEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEdit.Click
        FillForm()
        txtVName.Focus()
    End Sub
    Private Sub cmdSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSearch.Click

    End Sub
    Private Sub cmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancel.Click
        ClearHead("")
        txtVName.Focus()
    End Sub
    Private Sub cmdDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDelete.Click

    End Sub
    Private Sub grdAtt_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles grdRecord.MouseClick
        If grdRecord.Rows.Count > 0 Then
            Dim MYID As String = grdRecord.Rows(grdRecord.CurrentCell.RowIndex).Cells(0).Value
            txtID.Text = MYID
            FillForm()
            txtVName.Focus()
        End If
    End Sub

    Private Sub txtSupplierGL_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtSupplierGL.KeyDown
        If e.KeyCode = Keys.F2 Then
            frmLookupCOA.VCodeIni = txtSupplierGL.Text.Trim
            frmLookupCOA.VType = "InvSupplier"
            frmLookupCOA.ShowDialog()
            If frmLookupCOA.VCode <> "" Then
                lblSupplierGLID.Text = frmLookupCOA.VCode
                txtSupplierGL.Text = frmLookupCOA.VName
                frmLookupCOA.Dispose()
                txtSupAdvGLCode.Focus()
            End If
        End If
    End Sub


    Private Sub txtCreditDays_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtCreditDays.KeyPress
        Dim dotLength As Integer = -1
        dotLength = Me.txtCreditDays.Text.Split(".").Length
        If e.KeyChar <> ControlChars.Back Then
            If dotLength > -1 Then
                e.Handled = Not (Char.IsDigit(e.KeyChar))
            Else
                e.Handled = Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = ".")
            End If
        End If
    End Sub

    Private Sub txtSupAdvGLCode_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtSupAdvGLCode.KeyDown
        If e.KeyCode = Keys.F2 Then
            frmLookupCOA.VCodeIni = txtSupplierGL.Text.Trim
            frmLookupCOA.VType = "InvSupplier"
            frmLookupCOA.ShowDialog()
            If frmLookupCOA.VCode <> "" Then
                lblAdvGLCode.Text = frmLookupCOA.VCode
                txtSupAdvGLCode.Text = frmLookupCOA.VName
                frmLookupCOA.Dispose()
                cmbVType.Focus()
            End If
        End If
    End Sub
End Class