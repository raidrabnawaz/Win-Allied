Public Class ProdCustomer
    Dim qryMain As String
    Dim objCommon As New clsCommon
   Private Sub frmAttCode_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
      G_CURRENTDATE = Date.Now
      If G_CURRENTDATE > G_SOFTENDDATE Then
         End
      End If

      txtID.Text = ""
      FillDropDown()
      ClearHead("")
      FillHeader()
      FillGrid()
      txtVName.Focus()
   End Sub

    Private Sub FillDropDown()
        txtVCode.Text = objCommon.ExecuteScalar("EXEC SpGetVCode_ProdCustomer " & G_Compcode)

        objCommon.FillProdPaymentTerm(Me.cmbPaymentTerm)
        objCommon.FillCustomerType(Me.cmbVType)

    End Sub
    Private Sub ClearHead(ByVal myid As String)
        For Each ctl In SplitContainer1.Panel1.Controls
            If TypeOf ctl Is TextBox Then ctl.Text = ""
        Next ctl

        lblInformation.Text = ""
        dtpMarketingDate.Value = DateAndTime.Now
        cmbPaymentTerm.SelectedIndex = 0
        chkIsActive.Checked = False
        chkIsLead.Checked = False

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
      Dim grdcol12 As System.Windows.Forms.DataGridViewTextBoxColumn
      Dim grdcol13 As System.Windows.Forms.DataGridViewTextBoxColumn
      Dim grdcol14 As System.Windows.Forms.DataGridViewTextBoxColumn
      Dim grdcol15 As System.Windows.Forms.DataGridViewTextBoxColumn
      Dim grdcol16 As System.Windows.Forms.DataGridViewTextBoxColumn
      Dim grdcol17 As System.Windows.Forms.DataGridViewTextBoxColumn
      Dim grdcol18 As System.Windows.Forms.DataGridViewTextBoxColumn

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
      grdcol12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
      grdcol13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
      grdcol14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
      grdcol15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
      grdcol16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
      grdcol17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
      grdcol18 = New System.Windows.Forms.DataGridViewTextBoxColumn()

      grdcol0.DataPropertyName = "VID"
      grdcol0.HeaderText = "Code"
      grdcol0.Name = "grdcol0"
      grdcol0.Visible = False
      '
      'grdcol1
      's
      grdcol1.DataPropertyName = "VCode"
      grdcol1.HeaderText = "Customer Code"
      grdcol1.Name = "grdcol1"
      grdcol1.Width = 70
      grdcol1.Visible = False

      grdcol2.DataPropertyName = "VName"
      grdcol2.HeaderText = "Customer Name"
      grdcol2.Name = "grdcol2"
      grdcol2.Width = 400

      grdcol3.DataPropertyName = "Email"
      grdcol3.HeaderText = "Customer Email"
      grdcol3.Name = "grdcol3"
      grdcol3.Width = 100

      grdcol4.DataPropertyName = "Phone"
      grdcol4.HeaderText = "Customer Phone"
      grdcol4.Name = "grdcol4"
      grdcol4.Width = 100



      grdcol5.DataPropertyName = "IsActive"
      grdcol5.HeaderText = "Is Active"
      grdcol5.Name = "grdcol5"
      grdcol5.Visible = False

      grdcol6.DataPropertyName = "Vatnumber"
      grdcol6.HeaderText = "Vatnumber"
      grdcol6.Name = "grdcol6"
      grdcol5.Visible = False

      grdcol7.DataPropertyName = "ContactPersonInfo"
      grdcol7.HeaderText = "ContactPersonInfo"
      grdcol7.Name = "grdcol7"
      grdcol7.Visible = False


      grdcol8.DataPropertyName = "PaymentTermID"
      grdcol8.HeaderText = "PaymentTermID"
      grdcol8.Name = "grdcol8"
      grdcol8.Visible = False


      grdcol9.DataPropertyName = "CreditLimit"
      grdcol9.HeaderText = "Credit Limit"
      grdcol9.Name = "grdcol9"


      grdcol10.DataPropertyName = "MarketingDate"
      grdcol10.HeaderText = "MarketingDate"
      grdcol10.Name = "grdcol10"
      grdcol10.Visible = False


      grdcol11.DataPropertyName = "IsLeadCustomer"
      grdcol11.HeaderText = "IsLeadCustomer"
      grdcol11.Name = "grdcol11"
      grdcol11.Visible = False


      grdcol12.DataPropertyName = "ZoneID"
      grdcol12.HeaderText = "ZoneID"
      grdcol12.Name = "grdcol12"
      grdcol12.Visible = False


      grdcol13.DataPropertyName = "ZoneID2"
      grdcol13.HeaderText = "ZoneID2"
      grdcol13.Name = "grdcol13"
      grdcol13.Visible = False


      grdcol14.DataPropertyName = "CompanyID"
      grdcol14.HeaderText = "CompanyID"
      grdcol14.Name = "grdcol14"
      grdcol14.Visible = False


      grdcol15.DataPropertyName = "ClusterID"
      grdcol15.HeaderText = "ClusterID"
      grdcol15.Name = "grdcol15"
      grdcol15.Visible = False
       
      Me.grdRecord.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {grdcol0, grdcol1, grdcol2, grdcol3, grdcol4, grdcol5, grdcol6, grdcol7, grdcol8, grdcol9, grdcol10, grdcol11, grdcol12, grdcol13, grdcol14, grdcol15})
   End Sub

    Private Sub FillGrid()
        'grdRecord.DataSource = Nothing
        qryMain = "EXEC SpGetbyShowProdCustomer"
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
      setGrid(grdRecord)
    End Sub
    Private Sub FillForm()
        lblInformation.Text = ""
        If txtID.Text = "" Then
            ClearHead("")
            Return
        End If
        qryMain = "EXEC SpGetbyIDProCustomer'" & txtID.Text & "' "
        Dim dt As DataTable = objCommon.GetDataTable(qryMain)
        If IsNothing(dt) Then
            'EmptyFields()
            Return
        End If
        If dt.Rows.Count <= 0 Then
            'EmptyFields()
            Return
        End If
        Dim dr As DataRow = dt.Rows(0)

        txtVName.Text = dr("VName")
        txtVCode.Text = dr("VCode")
        txtEmail.Text = dr("Email")
        txtPhone.Text = dr("Phone")
        txtContactPerson.Text = dr("ContactPersonInfo")
        txtCreditLimit.Text = dr("CreditLimit")
        txtVatNo.Text = dr("VatNumber")
        dtpMarketingDate.Value = dr("MarketingDate")
        cmbPaymentTerm.SelectedValue = dr("PaymentTermID")
        cmbVType.SelectedValue = dr("CustomerTypeID")
        If (dr("IsActive") <> "1") Then
            chkIsActive.Checked = False
        Else
            chkIsActive.Checked = True
        End If
        If (dr("IsLeadCustomer") <> "1") Then
            chkIsLead.Checked = False
        Else
            chkIsLead.Checked = True
        End If
    End Sub
    Private Sub cmdNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNew.Click
        ClearHead("")
        txtVName.Focus()
    End Sub
    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        lblInformation.Text = ""
        'varify for empty string
        'varify already existance

        'qryMain = " Select top 1 isnull(L1Code,'') as L1Code from tblAcSetupCOAL1 where L1Code <> '" & txtID.Text & "' and VName='" & txtVName.Text & "'; "
        'qryMain = objCommon.ExecuteScalar(qryMain)
        'If qryMain <> "" Then
        '    MessageBox.Show("Account already exists.", G_APP_TITLE)
        '    Return
        'End If
        If txtVName.Text = "" Then
            MessageBox.Show("Please give some Name.", G_APP_TITLE)
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

        If txtID.Text Is "" or txtID.Text = "" Then 'update
            txtID.Text = 0
            txtVCode.Text = objCommon.ExecuteScalar("EXEC SpGetVCode_ProdCustomer " & G_Compcode)        '    qryMain = " update tblAcSetupCOAL1 set VName='" & txtVName.Text & "',GID='" & cmbGroup.SelectedValue & "' where L1Code = '" & txtID.Text & "'; "
        End If                   '    objCommon.ExecuteNonQuery(qryMain)
        'Else
        '    Dim strcode As String
        '    strcode = objCommon.ExecuteScalar("select isnull(max(cast(L1Code as int)),0) + 1 as L1Code from tblAcSetupCOAL1 where GID = " & cmbGroup.SelectedValue)
        '    strcode = Double.Parse(strcode).ToString("00")
        '    qryMain = "insert into tblAcSetupCOAL1 (L1Code, GID, VName, OldCode) values('" &
        '    strcode & "'," & cmbGroup.SelectedValue & ",'" & txtVName.Text & "','' );  "

        qryMain = "EXEC SpSave_ProdCustomer " & txtID.Text & ",'" & txtVCode.Text & "', '" & txtVName.Text & "', " & cmbVType.SelectedValue & ",'" & txtEmail.Text & "','" & txtPhone.Text & "','" & txtVatNo.Text & "','" & txtContactPerson.Text & "'," & cmbPaymentTerm.SelectedValue &
            "," & txtCreditLimit.Text & ",'" & CDate(dtpMarketingDate.Value).ToString("dd/MMM/yyyy") & "'," & chkIsLead.CheckState & ",0,0," & G_Compcode & "," & G_Compcode & "," & chkIsActive.CheckState & "," & G_UID & ",'" & G_IPAddress & "'," & G_UID & ",'" & G_IPAddress & "'"

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

    Private Sub txtCreditLimit_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCreditLimit.KeyPress
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