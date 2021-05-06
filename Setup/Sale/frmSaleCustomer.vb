Public Class frmSaleCustomer
    Dim qryMain As String
    Dim objCommon As New clsCommon
    Dim MID As Int32
   Private Sub frmAttCode_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
      G_CURRENTDATE = Date.Now
      If G_CURRENTDATE > G_SOFTENDDATE Then
         End
      End If

      txtID.Text = ""
      objCommon.FillPaymentTerm(Me.cmbPaymentTerm)
        objCommon.FillCOuntry(Me.cmbCountry)
        objCommon.FillCustomerType(Me.cmbVType)
        ClearHead("")
      FillHeader()
      FillGrid()
      txtVName.Focus()
   End Sub
    Private Sub ClearHead(ByVal myid As String)
        For Each ctl In SplitContainer1.Panel1.Controls
            If TypeOf ctl Is TextBox Then ctl.Text = ""
        Next ctl
        lblDID.Text = "0"
        lblInformation.Text = ""
        cmbPaymentTerm.SelectedIndex = -1
        cmbCountry.SelectedIndex = -1
        IsActive.Checked = False
        IsDefault.Checked = False


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

        grdcol0.DataPropertyName = "VID"
        grdcol0.HeaderText = "VID"
        grdcol0.Name = "grdcol0"
        grdcol0.Visible = False
        '
        'grdcol1     VID, VName, GLPurchaseCode, GLCostCode, ItemFor, IsFixedAsset, DepriPer, LifeMonth
        '
        grdcol1.DataPropertyName = "VCode"
        grdcol1.HeaderText = "Supplier Code"
        grdcol1.Name = "grdcol1"
        grdcol1.Width = 50

        grdcol2.DataPropertyName = "VName"
        grdcol2.HeaderText = "Description"
        grdcol2.Name = "grdcol2"
        grdcol2.Width = 400
        '
        'grdcol2
        '
        grdcol3.DataPropertyName = "IsActive"
        grdcol3.HeaderText = "IsActive"
        grdcol3.Name = "grdcol3"
        grdcol3.Visible = False

        grdcol4.DataPropertyName = "Phone"
        grdcol4.HeaderText = "Phone"
        grdcol4.Name = "grdcol4"
        grdcol4.Width = 100
        'VID,VCode,VName,Email,Phone, CompanyName,BAddress,City,BState,IsActive
        grdcol5.DataPropertyName = "Email"
        grdcol5.HeaderText = "Email"
        grdcol5.Name = "grdcol5"
        grdcol5.Width = 50

        grdcol6.DataPropertyName = "CompanyName"
        grdcol6.HeaderText = "Company Name"
        grdcol6.Name = "grdcol6"
        grdcol6.Width = 50

        grdcol7.DataPropertyName = "BAddress"
        grdcol7.HeaderText = "Address"
        grdcol7.Name = "grdcol7"
        grdcol7.Width = 50

        grdcol8.DataPropertyName = "City"
        grdcol8.HeaderText = "City"
        grdcol8.Name = "grdcol8"
        grdcol8.Width = 50

        grdcol9.DataPropertyName = "BState"
        grdcol9.HeaderText = "State"
        grdcol9.Name = "grdcol9"
        grdcol9.Width = 50

        Me.grdRecord.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {grdcol0, grdcol1, grdcol2, grdcol3, grdcol4, grdcol5, grdcol6, grdcol7, grdcol8, grdcol9})
    End Sub
    Private Sub FillGrid()
        'grdRecord.DataSource = Nothing
        qryMain = "EXEC SpGetbyShowSaleCustomer " & G_Compcode & ""
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
        qryMain = "EXEC SpGetbyIDSaleCustomerAndAddress'" & txtID.Text & "' "
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
            cmbCountry.SelectedValue = dr("CountryID")
            cmbVType.SelectedValue = dr("CustomerTypeID")
            txtCity.Text = dr("City")
            txtAddress.Text = dr("BAddress")
            txtCreditLimit.Text = dr("CreditLimit")
            txtState.Text = dr("BState")
            txtCompName.Text = dr("CompanyName")
            txtZipCode.Text = dr("BZip")
            txtVatNo.Text = dr("VatNumber")
            lblDID.Text = dr("DID")
            If dr("Email") Is DBNull.Value Then txtEmail.Text = "" Else txtEmail.Text = dr("Email")
            If dr("Phone") Is DBNull.Value Then txtPhoneNo.Text = "" Else txtPhoneNo.Text = dr("Phone")
            If dr("WebUrl") Is DBNull.Value Then txtWebUrl.Text = "" Else txtWebUrl.Text = dr("WebUrl")
            If dr("IsActive") = 0 Then IsActive.Checked = False Else IsActive.Checked = True
            If dr("IsDefault") = 0 Then IsDefault.Checked = False Else IsDefault.Checked = True
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
        'varify already existance
      txtVName.Text = txtVName.Text.Trim.Replace("'", "")
        If txtVName.Text = "" Then
            MessageBox.Show("Please give some Supplier Name.", G_APP_TITLE)
            txtVName.Focus()
            Return
        End If
        If cmbPaymentTerm.SelectedIndex <= 0 Then
            MessageBox.Show("Please select Payment Term.", G_APP_TITLE)
            cmbPaymentTerm.Focus()
            Return
        End If
        If txtCreditLimit.Text = "" Then
            MessageBox.Show("Please give some Credit Limit.", G_APP_TITLE)
            txtCreditLimit.Focus()
            Return
        End If
        If cmbCountry.SelectedIndex <= 0 Then
            MessageBox.Show("Please select Country.", G_APP_TITLE)
            cmbCountry.Focus()
            Return
        End If
        'qryMain = " Select top 1 isnull(L1Code,'') as L1Code from tblAcSetupCOAL1 where L1Code <> '" & txtID.Text & "' and VName='" & txtVName.Text & "'; "
        'qryMain = objCommon.ExecuteScalar(qryMain)
        'If qryMain <> "" Then
        '    MessageBox.Show("Account already exists.", G_APP_TITLE)
        '    Return
        'End If
        txtVCode.Text = objCommon.ExecuteScalar("EXEC SpGetVCode_SaleCustomer " & G_Compcode & " ")
        If txtID.Text Is "" or txtID.Text = "" Then
            txtID.Text = 0
        End If

        'update
        '    qryMain = " update tblAcSetupCOAL1 set VName='" & txtVName.Text & "',GID='" & cmbCatetory.SelectedValue & "' where L1Code = '" & txtID.Text & "'; "
        '    objCommon.ExecuteNonQuery(qryMain)
        'Else
        '    Dim strcode As String
        '    strcode = objCommon.ExecuteScalar("select isnull(max(cast(L1Code as int)),0) + 1 as L1Code from tblAcSetupCOAL1 where GID = " & cmbCatetory.SelectedValue)
        '    strcode = Double.Parse(strcode).ToString("00")
        '    qryMain = "insert into tblAcSetupCOAL1 (L1Code, GID, VName, OldCode) values('" &
        '    strcode & "'," & cmbCatetory.SelectedValue & ",'" & txtVName.Text & "','' );  "

        'qryMain = "EXEC SpSave_invProductMainCategory " & txtID.Text & ", " & txtVName.Text & ", " & txtGLPurchase.Text & ", " & txtGLCost.Text & ", 0, 0, " & cmbCategory.SelectedIndex & ", 0, " & IsFixed.Checked & ", " & txtDepriciation.Text
        'qryMain &= ", " & txtLifeMonth.Text & ", 0, 0, 1, 1, 10, 1, ''"
        'VCode, VName, PaymentTermID, ContactPerson, Country, City, VType, Address, Creditdays, CNIC, SupplierBank, PayTo, Email, Phone, Fax, TaxNumber, CompanyID, IsActive, InsertedBy, InsertedIp, InsertedBy, InsertedIp

        qryMain = "EXEC SpSave_SaleCustomer " & txtID.Text & ",'" & txtVCode.Text & "','" & txtVName.Text & "','" & cmbVType.SelectedValue & "','" & txtEmail.Text & "','" & txtPhoneNo.Text & "','" & txtVatNo.Text & "'," & cmbPaymentTerm.SelectedValue & ",0," & txtCreditLimit.Text & "," & G_Compcode & "," & IsActive.CheckState & "," & G_UID & ",'" & G_IPAddress & "'," & G_UID & ",'" & G_IPAddress & "'"
        MID = objCommon.ExecuteScalar(qryMain)
        ','" & cmbCountry.SelectedValue & "','" & txtCity.Text & "','" & txtAddress.Text & "','" & txtState.Text & "','" & txtCompName.Text & "','" & txtZipCode.Text & "','" & txtWebUrl.Text & "'
        qryMain = " EXEC SpSave_SaleCustomerAddress " & lblDID.Text & ",'-','" & txtEmail.Text & "'," & MID & ",'" & txtVName.Text & "','" & txtVName.Text & "','" & txtCompName.Text & "','" & txtAddress.Text & "','" & txtCity.Text & "','" & txtState.Text & "','" & txtZipCode.Text & "'," & cmbCountry.SelectedValue & ",'" & txtPhoneNo.Text & "','" & txtWebUrl.Text & "'," & IsActive.CheckState & "," & IsDefault.CheckState & "," & G_UID & ",'" & G_IPAddress & "'," & G_UID & ",'" & G_IPAddress & "' "
        objCommon.ExecuteNonQuery(qryMain)
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

    Private Sub txtCreditDays_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCreditLimit.KeyPress
        Dim dotLength As Integer = 1
        dotLength = Me.txtCreditLimit.Text.Split(".").Length
        If e.KeyChar <> ControlChars.Back Then
            If dotLength > 1 Then
                e.Handled = Not (Char.IsDigit(e.KeyChar))
            Else
                e.Handled = Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = ".")
            End If
        End If
    End Sub

End Class