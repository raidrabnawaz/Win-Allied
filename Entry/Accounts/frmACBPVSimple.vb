Public Class frmACBPVSimple
   Dim qryMain As String
   Dim VType As String
   Dim objCommon As New clsCommon
   Private Sub frmACJV_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
      G_CURRENTDATE = Date.Now
      If G_CURRENTDATE > G_SOFTENDDATE Then
         End
      End If

      VType = EMSMain.VType
      txtID.Text = ""
      VType = EMSMain.VType
      If (VType = "FBRV") Then
         lblHeading.Text = "Fixed Bank Receipt Voucher"
         Me.Text = "Fixed Bank Receipt Voucher"
      ElseIf (VType = "FBPV") Then
         lblHeading.Text = "Fixed Bank Payment Voucher"
         Me.Text = "Fixed Bank Payment Voucher"

      End If
      objCommon.FillSingleAccType(Me.cmbAccType)
      objCommon.FillBPVBank(Me.cmbBankAccount)
      ClearHead("")

      FillGrid("")
      txtID.Focus()
   End Sub
   Private Sub ClearHead(ByVal myid As String)
      txtID.Text = myid
      lblInformation.Text = ""
      txtID.Text = ""
      txtAmount.Text = ""
      txtAccountDesc.Text = ""
      txtBankDesc.Text = ""
      txtChequeNo.Text = ""
      cmbBankAccount.SelectedIndex = -1
      cmbAccType.SelectedIndex = 0
      txtAccHeadDet.Text = ""
      lblAcctID.Text = ""
      PostDated.Checked = False
      CrossCheque.Checked = False
      lblVID.Text = ""
      dtplChequeDate.ResetText()
      dtpVoucherDate.ResetText()

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

      grdcol0 = New System.Windows.Forms.DataGridViewTextBoxColumn()
      grdcol1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
      grdcol2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
      grdcol3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
      grdcol4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
      grdcol5 = New System.Windows.Forms.DataGridViewTextBoxColumn()

      grdcol0.DataPropertyName = "VID"
      grdcol0.HeaderText = "VID"
      grdcol0.Name = "grdcol0"
      grdcol0.Visible = False
      '
      'grdcol1
      '
      grdcol1.DataPropertyName = "VNo"
      grdcol1.HeaderText = "Voucher No"
      grdcol1.Name = "grdcol1"
      grdcol1.Width = 100
      '
      'grdcol2
      '
      grdcol2.DataPropertyName = "VDate"
      grdcol2.HeaderText = "Voucher Date"
      grdcol2.Name = "grdcol2"
      grdcol2.Width = 100


      '
      'grdcol3
      '
      grdcol3.DataPropertyName = "VName"
      grdcol3.HeaderText = "Bank Description"
      grdcol3.Name = "grdcol3"
      grdcol3.Width = 300
      '
      'grdcol4
      '
      grdcol4.DataPropertyName = "Amount"
      grdcol4.HeaderText = "Amount"
      grdcol4.Name = "grdcol4"
      grdcol4.Width = 100
      '
      'grdcol5
      '
      grdcol5.DataPropertyName = "Cr"
      grdcol5.HeaderText = "Tare Weight"
      grdcol5.Name = "grdcol5"
      grdcol5.Visible = False
      '



      Me.grdRecord.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {grdcol0, grdcol1, grdcol2, grdcol3, grdcol4, grdcol5})
   End Sub
   Private Sub FillGrid(ByVal strSearch As String)
      grdRecord.DataSource = Nothing
      FillHeader()
      qryMain = "EXEC SpGet_AccVoucherMainFixed " & G_FinancialYearID & "," & G_Compcode & "," & VType & ""
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
      If lblVID.Text = "" And lblVID.Text.Trim = "" Then
         ClearHead("")
         Return
      End If
      lblVID.Text = lblVID.Text.Trim
      qryMain = "EXEC SpGetbyID_AccVoucherMainFixed '" & lblVID.Text & "'," & VType & "," & G_Compcode & ""
      Dim dt As DataTable = objCommon.GetDataTable(qryMain)
      If IsNothing(dt) Then
         ClearHead("")
         Return
      End If
      If dt.Rows.Count <= 0 Then
         ClearHead("")
         Return
      End If
      Dim dr As DataRow = dt.Rows(0)
      lblVID.Text = dr("VID").ToString()
      txtID.Text = dr("VNo").ToString()
      dtpVoucherDate.Value = Convert.ToDateTime(dr("VDate"))
      cmbAccType.SelectedValue = dr("AccountType")
      cmbBankAccount.SelectedValue = dr("BankID")
      txtBankDesc.Text = dr("BankRemarks").ToString()
      lblAcctID.Text = dr("AccountID").ToString()
      txtAccHeadDet.Text = dr("AccountName").ToString()
      txtAccountDesc.Text = dr("AccountRemarks").ToString()
      txtChequeNo.Text = dr("ChequeNo").ToString()
      dtplChequeDate.Value = Convert.ToDateTime(dr("ChequeDate").ToString())
      txtAmount.Text = dr("Amount").ToString()
      txtAccountDesc.Text = dr("AccountRemarks").ToString()
      txtAccountDesc.Text = dr("AccountRemarks").ToString()
      If (Convert.ToInt32(dr("PosteDatedCheque")) <> 1) Then
         PostDated.Checked = False
      Else
         PostDated.Checked = True

      End If
      If (Convert.ToInt32(dr("CrossCheque")) <> 1) Then
         CrossCheque.Checked = False
      Else
         CrossCheque.Checked = True

      End If


   End Sub
   Private Sub cmdNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNew.Click
      ClearHead("")
      txtID.Focus()
   End Sub
   Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
      lblInformation.Text = ""
      'varify for empty string
      ''varify already existance
      'txtVName.Text = txtVName.Text.Trim.ToUpper.Replace("'", "")
      'If lblCustomerName.Text = "" Then
      '    lblInformation.Text = "Please give some Dr Code."
      '    Return
      'End If
      'If lblBankName.Text = "" Then
      '    lblInformation.Text = "Please give some Cr Code."
      '    Return
      'End If
      'txtMDNRefNo.Text = txtMDNRefNo.Text.Trim
      'txtAmount.Text = Setdouble(txtAmount.Text)
      Dim ErrMsg As String = verifySave()
      If Not ErrMsg = "" Then
         MessageBox.Show(ErrMsg, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
         Exit Sub
      End If
      'If txtID.Text <> "" Then 'update
      '    If txtID.Text.Substring(4, 4) <> CDate(dtpMDNDate.Value).ToString("MMyy") Then
      '        lblInformation.Text = "Cannot change the month of voucher."
      '        Return
      '    End If
      '    qryMain = " update tblAcJV set VDate='" & CDate(dtpMDNDate.Value).ToString("dd/MMM/yyyy") & "',PartyCode='" & txtCustomer.Text & "',BankCode='" & txtBank.Text & "',ChequeNo='" & txtMDNRefNo.Text & "',Amount=" & txtAmount.Text & ",  Remarks='" & txtVName.Text & "', UID=" & G_UID & ",Tranzdatetime=getdate(),CompCode=0 where VID = " & txtID.Text & "; "
      '    objCommon.ExecuteNonQuery(qryMain)
      'Else
      '    Dim strcode As String
      '    strcode = objCommon.ExecuteScalar("select isnull(max(cast(left(VNo,3) as int)),0) + 1  as VCode from tblAcJV where right(VNo,4) = '" & CDate(dtpMDNDate.Value).ToString("MMyy") & "'; ")
      '    strcode = Double.Parse(strcode).ToString("000") & "/" & CDate(dtpMDNDate.Value).ToString("MMyy")
      '    qryMain = "insert into tblAcJV (VNo, RefNo, DocumentType, VDate, PartyCode, BankCode, ChequeNo, Amount, Remarks, IsCancel, CancelDate, IsPosted, PostedDate, FYear, UID, Tranzdatetime, CompCode ) values('" &
      '    strcode & "','','Cash','" & CDate(dtpMDNDate.Value).ToString("dd/MMM/yyyy") & "','" & txtCustomer.Text & "','" & txtBank.Text & "','" & txtMDNRefNo.Text & "'," & txtAmount.Text & ",'" & txtVName.Text & "',0,'01/01/1900',1,'" & CDate(dtpMDNDate.Value).ToString("dd/MMM/yyyy") & "'," & CDate(dtpMDNDate.Value).ToString("yyyy") & "," & G_UID & ",getdate(),0);  "
      Dim strcode As String
      If (txtID.Text = "") Or txtID.Text Is "" Then
         strcode = objCommon.ExecuteScalar("select dbo.fnAccMaxCode(" & G_Compcode & "," & G_UID & "," & G_FinancialYearID & ",'" & VType & "','" & CDate(dtpVoucherDate.Value).ToString("dd/MMM/yyyy") & "', '" & CDate(dtpVoucherDate.Value).ToString("MMyy") & "') ")
         strcode = Convert.ToString(G_Compcode) & "-" & CDate(dtpVoucherDate.Value).ToString("MMyy") & "-" & Double.Parse(strcode).ToString("0000")
         txtID.Text = strcode
         lblVID.Text = "0"
      End If
      qryMain = "EXEC SpSave_AccVoucherBV  " & lblVID.Text & ",'" & txtID.Text & "'," & VType & ",'" & CDate(dtpVoucherDate.Value).ToString("dd/MMM/yyyy") & "',1,1,0," & cmbBankAccount.SelectedValue.ToString() & ",'" & txtBankDesc.Text & "'," & cmbAccType.SelectedValue.ToString() & "," & lblAcctID.Text & ",'" & txtAccountDesc.Text & "',''," & G_Compcode & "," & G_FinancialYearID & ",0,0,'" & CDate(dtplChequeDate.Value).ToString("dd/MMM/yyyy") & "',0," & G_UID & ",'" & DateTime.Now.ToString("dd/MMM/yyyy") & "','" & G_IPAddress & "'," & G_UID & ",'" & DateTime.Now.ToString("dd/MMM/yyyy") & "','" & G_IPAddress & "'," & txtChequeNo.Text & ",'" & CDate(dtplChequeDate.Value).ToString("dd/MMM/yyyy") & "'," & PostDated.CheckState & "," & CrossCheque.CheckState & "," & txtAmount.Text & ""
      objCommon.ExecuteNonQuery(qryMain)
      'End If
      ClearHead("")
      FillGrid("")
      lblInformation.Text = "Record Saved."
      txtID.Focus()
   End Sub
   Private Sub cmdEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEdit.Click
      FillForm()
      txtID.Focus()
   End Sub
   Private Function verifySave() As String
      Dim verify As String = ""

      If lblAcctID.Text = "" Then
         verify &= "Please Select some Account Head !! "
         txtAccHeadDet.Focus()
      End If
      If cmbBankAccount.SelectedIndex = 0 Then
         verify &= "Please Select some Bank !! "
         cmbBankAccount.Focus()
      End If

      Return verify
   End Function
   Private Sub cmdSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSearch.Click
      'txtVName.Text = txtVName.Text.Trim
      'FillGrid(" where H.VNo like '%" & txtVName.Text & "%' or H.PartyCode like '%" & txtVName.Text & "%' or H.BankCode like '%" & txtVName.Text & "%' or COA.VName like '%" & txtVName.Text & "%' or H.Remarks like '%" & txtVName.Text & "%' ")
   End Sub
   Private Sub cmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancel.Click
      ClearHead("")
      txtID.Focus()
   End Sub
   Private Sub cmdDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDelete.Click
      If Setdouble(txtID.Text) <= 0 Then
         lblInformation.Text = "Please select some record to delete."
         Return
      End If

      If MessageBox.Show("Do You want to delete record?", G_APP_TITLE, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) = DialogResult.No Then
         Return
      End If

      qryMain = " delete from tblAcJV where VID = " & txtID.Text & ";"
      objCommon.ExecuteNonQuery(qryMain)
      FillGrid("")
      ClearHead("")
      lblInformation.Text = "Record removed."
   End Sub
   Private Sub grdAtt_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles grdRecord.MouseClick
      If grdRecord.Rows.Count > 0 Then
         Dim MYID As String = grdRecord.Rows(grdRecord.CurrentCell.RowIndex).Cells(1).Value.ToString()
         lblVID.Text = grdRecord.Rows(grdRecord.CurrentCell.RowIndex).Cells(0).Value.ToString()
         txtID.Text = MYID
         FillForm()
         txtID.Focus()
      End If
   End Sub

   Private Sub txtCustomer_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
      'If txtCustomer.Text.Trim.Length <> 7 Then
      '    lblCustomerName.Text = ""
      '    Return
      'End If
      'qryMain = " select top 1 VName from tblAcSetupCOA where VCode ='" & txtCustomer.Text.Trim & "' "
      'lblCustomerName.Text = objCommon.ExecuteScalar(qryMain)
   End Sub

   Private Sub txtCustomer_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
      If e.KeyCode = Keys.F2 Then
         ''frmLookupCOA.ETypeID = "0502"
         'frmLookupCOA.VCodeIni = txtCustomer.Text.Trim
         'frmLookupCOA.ShowDialog()
         'txtCustomer.Text = frmLookupCOA.VCode
         'lblCustomerName.Text = frmLookupCOA.VName
         'frmLookupCOA.Dispose()
      ElseIf e.KeyCode = Keys.Enter Then
         'If txtCustomer.Text.Trim.Length <> 7 Then
         '    lblCustomerName.Text = ""
         '    Return
         'End If
         'qryMain = " select top 1 VName from tblAcSetupCOA where VCode ='" & txtCustomer.Text.Trim & "' "
         'lblCustomerName.Text = objCommon.ExecuteScalar(qryMain)
         SendKeys.Send("{TAB}")
      End If
   End Sub
   Private Sub txtBank_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
      If e.KeyCode = Keys.F2 Then
         'frmLookupCOA.ETypeID = "0502"
         'frmLookupCOA.VCodeIni = txtBank.Text.Trim
         'frmLookupCOA.ShowDialog()
         'txtBank.Text = frmLookupCOA.VCode
         'lblBankName.Text = frmLookupCOA.VName
         'frmLookupCOA.Dispose()
      ElseIf e.KeyCode = Keys.Enter Then
         'If txtBank.Text.Trim.Length <> 7 Then
         '    lblBankName.Text = ""
         '    Return
         'End If
         'qryMain = " select top 1 VName from tblAcSetupCOA where VCode ='" & txtBank.Text.Trim & "' "
         'lblBankName.Text = objCommon.ExecuteScalar(qryMain)
         SendKeys.Send("{TAB}")
      End If
   End Sub

   Private Sub cmbAccType_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cmbAccType.SelectedIndexChanged
      Dim AccType = cmbAccType.SelectedValue.ToString
      'MsgBox(cmbAccType.SelectedValue.ToString) 
   End Sub

   Private Sub txtAmount_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtAmount.KeyPress
      Dim dotLength As Integer = 1
      'dotLength = Me.txtCredit.Text.Split(".").Length


      If e.KeyChar <> ControlChars.Back Then
         If dotLength > 1 Then
            e.Handled = Not (Char.IsDigit(e.KeyChar))
         Else
            e.Handled = Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = ".")
         End If
      End If

   End Sub
    Private Sub txtMachineCode_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dtpVoucherDate.KeyUp, cmbBankAccount.KeyUp, txtBankDesc.KeyUp,
      cmbAccType.KeyUp, txtAccountDesc.KeyUp, txtChequeNo.KeyUp, dtplChequeDate.KeyUp, txtAmount.KeyUp
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If 'ijaz
    End Sub 'Pending

    Private Sub txtAccHeadDet_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtAccHeadDet.KeyDown
      If e.KeyCode = Keys.F2 Then
         If cmbAccType.SelectedIndex > 0 Then 
            frmLookupCOA.VCodeIni = txtAccHeadDet.Text.Trim
            frmLookupCOA.AccTypeID = Convert.ToInt64(cmbAccType.SelectedValue.ToString())
            frmLookupCOA.VType = VType
            frmLookupCOA.VCode = ""
            frmLookupCOA.VName = ""
            frmLookupCOA.ShowDialog()
            If frmLookupCOA.VCode <> "" Then
               lblAcctID.Text = frmLookupCOA.VCode
               txtAccHeadDet.Text = frmLookupCOA.VName
               lblAccountTitle.Text = frmLookupCOA.VName
               frmLookupCOA.Dispose()
               txtAccountDesc.Focus()
            End If
         End If
      End If
   End Sub
End Class