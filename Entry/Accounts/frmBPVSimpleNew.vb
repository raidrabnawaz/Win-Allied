Imports System.Collections.Specialized
Imports System.IO
Imports CrystalDecisions.CrystalReports.Engine

Public Class frmBPVSimpleNew
   Dim qryMain, cWhere As String
   Dim VType As String
   Dim objCommon As New clsCommon

   Dim rpt As New ReportClass
   Dim MyListDic As New ListDictionary
   Dim ReportFilePath As String = ""
   Dim ReportTitle As String = ""
   Dim ReportFilter As String = ""
   Dim FilterVTypeList As String = ""
   Dim FilterDate As String = ""
   Dim FilterAccCode As String = ""
   Dim ReportSpName As String = ""
   Dim dtrpt As DataTable


   Private Sub frmACJV_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
      G_CURRENTDATE = Date.Now
      If G_CURRENTDATE > G_SOFTENDDATE Then
         End
      End If

      VType = EMSMain.VType
      txtID.Text = ""
      VType = EMSMain.VType
      If (VType = "FBRV") Then
         lblHeading.Text = "Bank Receipt Voucher Simple"
         Me.Text = "Fixed Bank Receipt Voucher"
      ElseIf (VType = "FBPV") Then
         lblHeading.Text = "Bank Payment Voucher Simple"
         Me.Text = "Fixed Bank Payment Voucher"

      End If
      objCommon.FillSingleAccType(Me.cmbAccType)
      objCommon.FillBPVBank(Me.cmbBankAccount)
      ClearHead("")
      dtpVoucherDate.MinDate = PeriodFrom
      dtpVoucherDate.MaxDate = PeriodTo
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
      cmbAccType.SelectedIndex = 1
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
      Dim grdcol6 As System.Windows.Forms.DataGridViewTextBoxColumn
      Dim grdcol7 As System.Windows.Forms.DataGridViewTextBoxColumn
      Dim grdcol8 As System.Windows.Forms.DataGridViewTextBoxColumn

      grdcol0 = New System.Windows.Forms.DataGridViewTextBoxColumn()
      grdcol1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
      grdcol2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
      grdcol3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
      grdcol4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
      grdcol5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
      grdcol6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
      grdcol7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
      grdcol8 = New System.Windows.Forms.DataGridViewTextBoxColumn()

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
      grdcol3.DataPropertyName = "BankName"
      grdcol3.HeaderText = "Bank"
      grdcol3.Name = "Bank"
      grdcol3.Width = 200
      '
      grdcol4.DataPropertyName = "BankRemarks"
      grdcol4.HeaderText = "Bank Description"
      grdcol4.Name = "BankRemarks"
      grdcol4.Width = 150
      '
      grdcol5.DataPropertyName = "AccountHead"
      grdcol5.HeaderText = "Account Head"
      grdcol5.Name = "AccountHead"
      grdcol5.Width = 200
      '
      grdcol6.DataPropertyName = "AccountRemarks"
      grdcol6.HeaderText = "Account Description"
      grdcol6.Name = "AccountRemarks"
      grdcol6.Width = 150
      '
      'grdcol4
      '
      grdcol7.DataPropertyName = "Amount"
      grdcol7.HeaderText = "Amount"
      grdcol7.Name = "Amount"
      grdcol7.Width = 100
      '
      'grdcol5
      ' 



      Me.grdRecord.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {grdcol0, grdcol1, grdcol2, grdcol3, grdcol4, grdcol5, grdcol6, grdcol7})
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
         ClearHead(0)
         Return
      End If
      If dt.Rows.Count <= 0 Then
         ClearHead(0)
         Return
      End If
      Dim dr As DataRow = dt.Rows(0)
      lblVID.Text = dr("VID")
      txtID.Text = dr("VNo")
      dtpVoucherDate.Value = dr("VDate")
      cmbAccType.SelectedValue = dr("AccountType")
      cmbBankAccount.SelectedValue = dr("BankID")
      txtBankDesc.Text = dr("BankRemarks")
      lblAcctID.Text = dr("AccountID")
      txtAccHeadDet.Text = dr("AccountName")
      txtAccountDesc.Text = dr("AccountRemarks")
      txtChequeNo.Text = dr("ChequeNo")
      dtplChequeDate.Value = dr("ChequeDate")
      txtAmount.Text = dr("Amount")
      txtAccountDesc.Text = dr("AccountRemarks")
      txtAccountDesc.Text = dr("AccountRemarks")
      If (dr("PosteDatedCheque") <> 1) Then
         PostDated.Checked = False
      Else
         PostDated.Checked = True

      End If
      If (dr("CrossCheque") <> 1) Then
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
        If txtAmount.Text = "" Then
            txtAmount.Text = 0
        End If

        Dim strcode As String
        If (txtID.Text = "") Then
         strcode = objCommon.ExecuteScalar("select dbo.fnAccMaxCode(" & G_Compcode & "," & G_UID & "," & G_FinancialYearID & ",'" & VType & "','" & CDate(dtpVoucherDate.Value).ToString("dd/MMM/yyyy") & "', '" & CDate(dtpVoucherDate.Value).ToString("MMyy") & "')")
         strcode = Double.Parse(G_Compcode).ToString("00") & "-" & CDate(dtpVoucherDate.Value).ToString("MMyy") & "-" & Double.Parse(strcode).ToString("0000")
         txtID.Text = strcode 
      End If
      qryMain = "EXEC SpSave_AccVoucherBV  " & lblVID.Text & ",'" & txtID.Text & "','" & VType & "','" & CDate(dtpVoucherDate.Value).ToString("dd/MMM/yyyy") & "',1,1,0," & cmbBankAccount.SelectedValue & ",'" & txtBankDesc.Text & "'," & cmbAccType.SelectedValue & "," & lblAcctID.Text & ",'" & txtAccountDesc.Text & "',''," & G_Compcode & "," & G_FinancialYearID & ",0,0,'" & CDate(dtplChequeDate.Value).ToString("dd/MMM/yyyy") & "',0," & G_UID & ",'" & DateTime.Now.ToString("dd/MMM/yyyy") & "','" & G_IPAddress & "'," & G_UID & ",'" & DateTime.Now.ToString("dd/MMM/yyyy") & "','" & G_IPAddress & "','" & txtChequeNo.Text & "','" & CDate(dtplChequeDate.Value).ToString("dd/MMM/yyyy") & "'," & PostDated.CheckState & "," & CrossCheque.CheckState & "," & txtAmount.Text & ""
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
      If cmbBankAccount.SelectedValue = 0 Then
         verify &= "Please Select some Bank !! "
         cmbBankAccount.Focus()
      End If

      Dim Lock As String
      Lock = objCommon.ExecuteScalar("select dbo.fnAllowBackDate('Win-ERP','" & VType & "','" & CDate(dtpVoucherDate.Value).ToString("dd/MMM/yyyy") & "'," & G_UID & "," & G_Compcode & ", " & G_FinancialYearID & ")")

      If Not (Lock = "") Then
         verify = Lock
         Return verify
      End If

      If lblVID.Text = "" Or lblVID.Text Is "" Then
         lblVID.Text = 0
      End If
      Return verify
   End Function
   Private Sub cmdSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSearch.Click
      MyListDic.Clear()

      If Not lblVID.Text = "" Then

         rpt = (WinReportsApplication.Classess.AccountsReport.SetReportName("acrptvoucher"))
         FilterVTypeList = ""
         FilterDate = ""
         ReportTitle = ""
         cWhere = " Where H.MID=" & lblVID.Text & " AND H.VType='" & VType & "' AND H.CompanyID=" & G_Compcode
         'MyListDic.Add("@cWhere", " where AH.txtVID = " & lblVID.Text)
         'MyListDic.Add("@VID", txtVID)
         MyListDic.Add("@VType", "DocumentView")
         MyListDic.Add("@CompanyID", G_Compcode)
         MyListDic.Add("@DateFrom", "1/1/1900")
         MyListDic.Add("@DateTo", "1/1/1900")
         MyListDic.Add("@cWhere", cWhere)
         ReportSpName = "spRptAccVoucher"
         dtrpt = objCommon.GetDataTableSPPrm(ReportSpName, MyListDic)

         MyListDic.Add("PrintedBy", "")
         MyListDic.Add("cGroupofCompany", G_CompName)

         Dim MyReportViewer As ReportViewer = New ReportViewer

         MyReportViewer.dtrpt = dtrpt
         MyReportViewer.MyListDic = MyListDic
         MyReportViewer.rtp = rpt
         MyReportViewer.MdiParent = EMSMain
         MyReportViewer.Show()



      End If
      'txtVName.Text = txtVName.Text.Trim
      'FillGrid(" where H.VNo like '%" & txtVName.Text & "%' or H.PartyCode like '%" & txtVName.Text & "%' or H.BankCode like '%" & txtVName.Text & "%' or COA.VName like '%" & txtVName.Text & "%' or H.Remarks like '%" & txtVName.Text & "%' ")
   End Sub
   Private Sub cmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancel.Click
      ClearHead("")
      txtID.Focus()
   End Sub
   Private Sub cmdDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDelete.Click
      If Setdouble(lblVID.Text) <= 0 Then
         lblInformation.Text = "Please select some record to delete."
         Return
      End If

      If MessageBox.Show("Are you sure you want to delete this record?", G_APP_TITLE, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) = DialogResult.No Then
         Return
      End If
      qryMain = "EXEC SpCancel_Vouchers " & lblVID.Text & ", '" & VType & "', " & G_UID & ",'" & G_IPAddress & "' "
      objCommon.ExecuteNonQuery(qryMain)
      MessageBox.Show("Voucher removed Successfully ", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
       
      FillGrid("")
      ClearHead(0)
      lblInformation.Text = "Record removed."
   End Sub
   Private Sub grdAtt_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles grdRecord.MouseClick
      If grdRecord.Rows.Count > 0 Then
         Dim MYID As String = grdRecord.Rows(grdRecord.CurrentCell.RowIndex).Cells(1).Value
         lblVID.Text = grdRecord.Rows(grdRecord.CurrentCell.RowIndex).Cells(0).Value
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
      Dim dotLength As Integer = -1
      'dotLength = Me.txtCredit.Text.Split(".").Length


      If e.KeyChar <> ControlChars.Back Then
         If dotLength > -1 Then
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
            frmLookupCOA.AccTypeID = 1
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