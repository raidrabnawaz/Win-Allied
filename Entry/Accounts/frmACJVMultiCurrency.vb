Imports System.Collections.Specialized
Imports System.IO
Imports CrystalDecisions.CrystalReports.Engine

Public Class frmACJVMultiCurrency
    Dim index As Integer = -1
    Dim objCommon As New clsCommon
    Dim dt As New DataTable
    Dim qryMain As String
    Dim action As String = "I"
    Dim VType As String
    Dim SetDet As String
    Dim MID As Integer

    Dim dr, cr, ExchangeRate As Double
   Dim rpt As New ReportClass
    Dim MyListDic As New ListDictionary
    Dim ReportFilePath As String = ""
    Dim ReportTitle As String = ""
    Dim ReportFilter As String = ""
    Dim FilterVTypeList As String = ""
    Dim FilterDate As String = ""
    Dim FilterAccCode As String = ""
    Dim MyReportViewer As ReportViewer
   Dim ReportSpName As String = ""
   Dim dtrpt As DataTable

   Private Sub frmGL_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
      G_CURRENTDATE = Date.Now
      If G_CURRENTDATE > G_SOFTENDDATE Then
         End
      End If

      'objCommon.FillAcSetupVType(Me.cmbCurrency)
      VType = EMSMain.VType
      objCommon.FillAcSetupVType(Me.cmbFVtype)
      objCommon.FillCurrency(Me.cmbCurrency, VType)
      'cmbCurrency.SelectedValue =


      If (VType = "CPV") Then
         lblHeading.Text = "Cash Payment Voucher"
         Me.Text = "Cash Payment Voucher"
      ElseIf (VType = "CRV") Then
         lblHeading.Text = "Cash Receipt Voucher"
         Me.Text = "Cash Receipt Voucher"
      ElseIf (VType = "BPV") Then
         lblHeading.Text = "Bank Payment Voucher"
         Me.Text = "Bank Payment Voucher"
         txtVNo.Size = New Size(84, 20)
         lblDate.Location = New Point(230, 20)
         dtpDate.Size = New Size(82, 20)
         dtpDate.Location = New Point(275, 15)
         lblRefNo.Location = New Point(384, 20)
         txtRefernceNo.Size = New Size(84, 20)
         txtRefernceNo.Location = New Point(457, 15)
         txtRemarks.Size = New Size(444, 20)
         txtNarration.Size = New Size(313, 20)
         lblCheque.Visible = True
         txtChequeNo.Visible = True
         grpBoxCheque.Visible = True
         DataGridView1.Columns("ChequeNo").Visible = True
         DataGridView1.Columns("Narration").Width = 320
      ElseIf (VType = "BRV") Then
         lblHeading.Text = "Bank Receipt Voucher"
         Me.Text = "Bank Receipt Voucher"
         txtVNo.Size = New Size(84, 20)
         lblDate.Location = New Point(230, 20)
         dtpDate.Size = New Size(82, 20)
         dtpDate.Location = New Point(275, 15)
         lblRefNo.Location = New Point(384, 20)
         txtRefernceNo.Size = New Size(84, 20)
         txtRefernceNo.Location = New Point(457, 15)
         txtRemarks.Size = New Size(444, 20)
         txtNarration.Size = New Size(313, 20)
         lblCheque.Visible = True
         txtChequeNo.Visible = True
         grpBoxCheque.Visible = True
         DataGridView1.Columns("ChequeNo").Visible = True
         DataGridView1.Columns("Narration").Width = 320

      End If
      dtFDateTo.Value = Date.Today
      dtFDateFrom.Value = DateTime.Today.Month & "/1/" & DateTime.Today.Year
      Me.lblAcctID.Text = ""
      btnSearch_Click(sender, e)
      cmbCurrency.SelectedValue = G_CurrencyID
      lblCurrencyID.Text = cmbCurrency.SelectedValue
      lblVID.Text = "0"
      txtRefernceNo.Focus()
      setGrid(DataGridView1)
   End Sub


    Private Sub clearHead()

        txtRemarks.Text = String.Empty
        dtpChequeDate.ResetText()
        dtpCancelDate.ResetText()
        chkCancel.Checked = False
        hfIsPosted.Checked = False
        lblAcctID.Text = ""
        For Each ctl In SplitContainer1.Panel1.Controls
            If TypeOf ctl Is TextBox Then ctl.Text = ""
        Next ctl
        txtRefernceNo.Text = ""
        txtChequeHead.Text = ""
        lblVID.Text = "0"
    End Sub
    Private Sub clearDet()
        Me.txtAccountHead.Text = String.Empty
        Me.txtNarration.Text = String.Empty
        Me.txtChequeNo.Text = String.Empty
        Me.txtDebit.Text = 0
        Me.txtCredit.Text = 0
        cmbCurrency.SelectedValue = G_CurrencyID
        Me.lblAccountTitle.Text = String.Empty
        Me.lblAcctID.Text = String.Empty
        Me.lblInfo.Visible = False
    End Sub

    Private Sub TotalDebitCredit()
        Dim totalDebit As Double = 0
        Dim totalCredit As Double = 0
        For Each grid As DataGridViewRow In DataGridView1.Rows
            totalDebit = totalDebit + Setdouble(grid.Cells("ExDebit").Value) ' Convert.ToDouble(IIf(grid.Cells(6).Value = "", 0, grid.Cells(6).Value))
            totalCredit = totalCredit + Setdouble(grid.Cells("ExCredit").Value) ' Convert.ToDouble(IIf(grid.Cells(7).Value = "", 0, grid.Cells(7).Value))
        Next
        Me.lblDebitSum.Text = totalDebit.ToString
        Me.lblCreditSum.Text = totalCredit.ToString
        If (totalCredit = totalDebit) Then
            lblInfo.Visible = True
            lblInfo.BackColor = Color.Green
            lblInfo.Text = "Balanced"
        Else
            lblInfo.Visible = True
            lblInfo.BackColor = Color.Red
            lblInfo.Text = "Not Balanced"
            If (totalCredit > totalDebit) Then
                txtDebit.Text = totalCredit - totalDebit
            Else
                txtCredit.Text = totalDebit - totalCredit
            End If
        End If
        cmbCurrency.SelectedValue = G_CurrencyID
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        'true  xor false = true
        dr = Setdouble(Me.txtDebit.Text)
        cr = Setdouble(Me.txtCredit.Text)
        SetDet = txtNarration.Text
        If Not ((dr > 0) Xor (cr > 0)) Then
            MessageBox.Show("Select proper Dr/Cr amount", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtDebit.Focus()
            Return
        ElseIf (txtNarration.Text = "") Then
            MessageBox.Show("Enter Narration", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtNarration.Focus()
            Return
        End If
        If Not cmbCurrency.SelectedValue = G_CurrencyID Then
         ExchangeRate = objCommon.ExecuteScalar("Select dbo.ftGetCurrencyExchangeRate (" & G_Compcode & ",'" & CDate(dtpDate.Value).ToString("dd/MMM/yyyy") & "'," & G_CurrencyID & "," & cmbCurrency.SelectedValue & ")")
        End If
        If ExchangeRate = 0 Then
            ExchangeRate = 1
        End If
        If index > -1 And Me.lblAcctID.Text.Trim <> String.Empty Then
            DataGridView1.Rows(index).Cells(1).Value = Me.lblAcctID.Text
            DataGridView1.Rows(index).Cells(2).Value = Me.txtAccountHead.Text
            DataGridView1.Rows(index).Cells(4).Value = Me.lblAccountTitle.Text
            DataGridView1.Rows(index).Cells(3).Value = Me.txtNarration.Text
            DataGridView1.Rows(index).Cells(5).Value = Me.txtChequeNo.Text
            DataGridView1.Rows(index).Cells(6).Value = Me.lblCurrencyID.Text
            DataGridView1.Rows(index).Cells(7).Value = Me.cmbCurrency.SelectedText
            DataGridView1.Rows(index).Cells("Debit").Value = dr
            DataGridView1.Rows(index).Cells("Credit").Value = cr
            DataGridView1.Rows(index).Cells("ExRate").Value = ExchangeRate
            DataGridView1.Rows(index).Cells("ExDebit").Value = ExchangeRate * dr
            DataGridView1.Rows(index).Cells("ExCredit").Value = ExchangeRate * cr
            index = -1
            Me.clearDet()

            If Not (dr = cr) Then
                txtNarration.Text = SetDet
            End If
            Me.TotalDebitCredit()  ' to calculate sum of debit and credit
        ElseIf index = -1 And Me.lblAcctID.Text.Trim <> String.Empty Then

            Dim row As String() = New String() {0, Me.lblAcctID.Text, Me.txtAccountHead.Text, Me.txtNarration.Text, Me.lblAccountTitle.Text, Me.txtChequeNo.Text, Me.lblCurrencyID.Text, Me.cmbCurrency.Text, dr, cr, ExchangeRate, ExchangeRate * dr, ExchangeRate * cr}
            DataGridView1.Rows.Add(row)
            Me.clearDet()
            If Not (dr = cr) Then
                txtNarration.Text = SetDet
            End If
            Me.TotalDebitCredit()  ' to calculate sum of debit and credit
        Else
            MessageBox.Show("Select Correct Account", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
        Me.txtAccountHead.Focus()
    End Sub

    Event DataGridView1ButtonClick(sender As DataGridView, e As DataGridViewCellEventArgs)

    Private Sub DataGridView1_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        'If DataGridView1.Rows.Count > 0 Then
        Dim senderGrid = DirectCast(sender, DataGridView)
        If TypeOf senderGrid.Columns(e.ColumnIndex) Is DataGridViewButtonColumn AndAlso e.RowIndex >= 0 Then
            RaiseEvent DataGridView1ButtonClick(senderGrid, e)
        Else
            index = e.RowIndex
            If index > -1 Then
                Me.lblAcctID.Text = DataGridView1.Rows(index).Cells(1).Value
                Me.txtAccountHead.Text = DataGridView1.Rows(index).Cells(2).Value
                Me.lblAccountTitle.Text = DataGridView1.Rows(index).Cells(3).Value
                Me.txtNarration.Text = DataGridView1.Rows(index).Cells(3).Value
                Me.txtChequeNo.Text = DataGridView1.Rows(index).Cells(5).Value
                Me.txtDebit.Text = DataGridView1.Rows(index).Cells("Debit").Value
                Me.txtCredit.Text = DataGridView1.Rows(index).Cells("Credit").Value
            End If
        End If
    End Sub

    Private Sub DataGridView1_ButtonClick(sender As DataGridView, e As DataGridViewCellEventArgs) Handles Me.DataGridView1ButtonClick
        'TODO - Button Clicked - Execute Code Here
        DataGridView1.Rows.Remove(sender.CurrentRow)
        TotalDebitCredit()

    End Sub

    Private Sub txtDebit_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDebit.KeyPress
      Dim dotLength As Integer = 1
        dotLength = Me.txtDebit.Text.Split(".").Length
        If e.KeyChar <> ControlChars.Back Then
         If dotLength > 1 Then
            e.Handled = Not (Char.IsDigit(e.KeyChar))
         Else
            e.Handled = Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = ".")
         End If
        End If

        If Asc(e.KeyChar) = 13 Then
            btnAdd_Click(sender, e)

        End If
    End Sub

    Private Sub txtCredit_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCredit.KeyPress
      Dim dotLength As Integer = 1
        dotLength = Me.txtCredit.Text.Split(".").Length


        If e.KeyChar <> ControlChars.Back Then
         If dotLength > 1 Then
            e.Handled = Not (Char.IsDigit(e.KeyChar))
         Else
            e.Handled = Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = ".")
         End If
        End If

        If Asc(e.KeyChar) = 13 Then
            btnAdd_Click(sender, e)
        End If
    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        Try
            'VType = "JV"
            MID = 0
            action = verifySave()
            If Not (action = "") Then
                MessageBox.Show(action, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return
            End If
            'If Setdouble(lblVID.Text) <= 0 Then
            '    Dim strcode As String
            '    strcode = objCommon.ExecuteScalar("select isnull(max(cast(left(VNo,3) as int)),0) + 1  as VCode from tblAcJVHead where right(VNo,4) = '" & CDate(dtpDate.Value).ToString("MMyy") & "'; ")
            '    strcode = Double.Parse(strcode).ToString("000") & "/" & CDate(dtpDate.Value).ToString("MMyy")
            '    qryMain = " insert into tblAcJVHead (VNo, VType, VDate, RefNo, Remarks, IsCancel, CancelDate, IsPosted, PostedDate, FYear, UID, Tranzdatetime, CompCode) " & _
            '    " values ('" & strcode & "', '" & cmbCurrency.SelectedValue & "', '" & CDate(dtpDate.Value).ToString("dd/MMM/yyyy") & "', 'RefNo', '" & txtRemarks.Text & "', 0, '01/01/1900', 1, '" & CDate(dtpDate.Value).ToString("dd/MMM/yyyy") & "', " & CDate(dtpDate.Value).ToString("yyyy") & ", " & G_UID & ", getdate(),0) ; select @@identity as VID  ;  "
            'Else
            '    qryMain = " update tblAcJVHead set VType='" & cmbCurrency.SelectedValue & "', VDate='" & CDate(dtpDate.Value).ToString("dd/MMM/yyyy") & "', Remarks='" & txtRemarks.Text & "', UID=" & G_UID & ", Tranzdatetime=getdate() where VID=" & Setdouble(lblVID.Text) & "  ; select " & Setdouble(lblVID.Text) & " as VID  ; "
            'End If
            If Not (VType = "BPV") Or (VType = "BRV") Then
                dtpChequeDate.Value = Convert.ToDateTime("1900-01-01")
                txtChequeHead.Text = ""

            End If




            Dim strcode As String
            If (txtVNo.Text = "") Then
            strcode = objCommon.ExecuteScalar("select dbo.fnAccMaxCode(" & G_Compcode & "," & G_UID & "," & G_FinancialYearID & ",'" & VType & "','" & CDate(dtpDate.Value).ToString("dd/MMM/yyyy") & "', '" & CDate(dtpDate.Value).ToString("MMyy") & "')")
                strcode = Double.Parse(G_Compcode).ToString("00") & "-" & CDate(dtpDate.Value).ToString("MMyy") & "-" & Double.Parse(strcode).ToString("0000")
                txtVNo.Text = strcode
                chkCancel.Checked = False
            End If

            If (chkCancel.Checked = False) Then
                dtpCancelDate.Value = Convert.ToDateTime("1900-01-01")
            End If

         qryMain = "EXEC SpSave_AccVoucherMain '" & lblVID.Text & "','" & txtVNo.Text & "'," & VType & ",'" & CDate(dtpDate.Value).ToString("dd/MMM/yyyy") & "'," & G_CurrencyID & ",0,0,'" & txtRemarks.Text & "','" & txtChequeHead.Text & "','" & CDate(dtpChequeDate.Value).ToString("dd/MMM/yyyy") & "','" & txtRefernceNo.Text & "'," & G_Compcode & "," & G_FinancialYearID & "," & hfIsPosted.CheckState & "," & chkCancel.CheckState & ",'" & CDate(dtpCancelDate.Value).ToString("dd/MMM/yyyy") & "',0,'1900-01-01','1900-01-01',0,0," & G_UID & ",'" & DateTime.Now.ToString("dd/MMM/yyyy") & "','" & G_IPAddress & "'," & G_UID & ",'" & DateTime.Now.ToString("dd/MMM/yyyy") & "','" & G_IPAddress & "'"
            MID = objCommon.ExecuteScalar(qryMain)
            If (MID > 0) Then
                objCommon.ExecuteNonQuery("EXEC SpDelete_AccVoucherDetail " & MID & "")
                objCommon.openConnection()
                For Each grid As DataGridViewRow In DataGridView1.Rows
                    'If Setdouble(grid.Cells("VID").Value) <= 0 Then
                    '    'qryMain = " insert into tblAcJVDet (MID, VCodeType, VCode, Remarks, Debit, Credit, RefNo, SrlNo, UID, Tranzdatetime)  " &
                    '    '    " values (" & MID & ",1,'" & grid.Cells("AccountNo").Value & "', '" & grid.Cells("Narration").Value & "', " & Setdouble(grid.Cells("Debit").Value) & ", " & Setdouble(grid.Cells("Credit").Value) & ", 'RefNo', 1, " & G_UID & ", getdate()) ;"

                    'Else
                    '    'qryMain = " update tblAcJVDet set VCode='" & grid.Cells("AccountNo").Value & "', Remarks='" & grid.Cells("Narration").Value & "', Debit=" & Setdouble(grid.Cells("Debit").Value) & ", Credit=" & Setdouble(grid.Cells("Credit").Value) & ", UID=" & G_UID & ", Tranzdatetime=getdate() where VID = " & Setdouble(grid.Cells("VID").Value)
                    'End If
                    If (VType = "BPV") And (VType = "BRV") Then
                        grid.Cells("ChequeNo").Value = "-"
                    End If
                    qryMain = "EXEC SpSave_AccVoucherDetail  " & grid.Cells("VID").Value & "," & MID & ", " & grid.Cells("AccountID").Value & "," & Setdouble(grid.Cells("Debit").Value) & "," & Setdouble(grid.Cells("Credit").Value) & ",'" & grid.Cells("ChequeNo").Value & "'," & G_CurrencyID & "," & grid.Cells("ExRate").Value & "," & grid.Cells("CurrencyID").Value & ",'" & txtRefernceNo.Text & "','" & grid.Cells("Narration").Value & "',0,0," & G_UID & ",'" & DateTime.Now.ToString("dd/MMM/yyyy") & "','" & G_IPAddress & "'," & G_UID & ",'" & DateTime.Now.ToString("dd/MMM/yyyy") & "','" & G_IPAddress & "' "
                    objCommon.ExecuteNonQueryWithOpen(qryMain)
                Next
                objCommon.CloseConnection()
            End If

            MessageBox.Show("Voucher Successfully Saved", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.lblAcctID.Text = ""
            'btnSearch_Click(sender, e)
            DataGridView1.Rows.Clear()
            lblVID.Text = "0"
            clearHead()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            objCommon.CloseConnection()
        End Try


        txtVNo.Focus()
    End Sub

    Private Function verifySave() As String
        Dim verify As String = ""
        If (txtRemarks.Text = "") Then
            verify &= "Must Enter Remarks.!" & vbNewLine
            txtRemarks.Focus()
        End If

        If DataGridView1.Rows.Count = 0 Then
            verify &= "Must Enter complete Voucher Detail.!" & vbNewLine
            txtAccountHead.Focus()
        End If

        If Setdouble(lblDebitSum.Text) <> Setdouble(lblCreditSum.Text) Then
            verify &= "Voucher is not Balanced.!" & vbNewLine
            txtAccountHead.Focus()
        End If

        Return verify
    End Function

    Private Sub txtAccountCode_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtAccountHead.KeyDown
        If e.KeyCode = Keys.F2 Then
            frmLookupCOA.VCodeIni = txtAccountHead.Text.Trim
            frmLookupCOA.VID = lblVID.Text.Trim
         frmLookupCOA.VType = VType
         frmLookupCOA.VCode = ""
         frmLookupCOA.VName = ""
            frmLookupCOA.ShowDialog()
            If frmLookupCOA.VCode <> "" Then
                lblAcctID.Text = frmLookupCOA.VCode
                txtAccountHead.Text = frmLookupCOA.VName
                lblAccountTitle.Text = frmLookupCOA.VName
            End If
            frmLookupCOA.Dispose()
            txtAccountHead.Focus()

        End If
    End Sub

    Private Sub txtChequeNo_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtChequeNo.KeyPress
        If e.KeyChar <> ControlChars.Back Then
            e.Handled = Not (Char.IsDigit(e.KeyChar))
        End If
    End Sub

    Private Sub txtAccountCode_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAccountHead.Leave
        If txtAccountHead.Text.Trim.Length <> 7 Then
            'lblAcctID.Text = ""
            'lblAccountTitle.Text = ""
            Return
        End If
        'qryMain = " select top 1 VName from tblAcSetupCOA where VCode ='" & txtAccountHead.Text.Trim & "' "
        'lblAccountTitle.Text = objCommon.ExecuteScalar(qryMain)
        'If lblAccountTitle.Text <> "" Then
        '    lblAcctID.Text = txtAccountHead.Text.Trim
        'End If
    End Sub

    Private Sub grdAtt_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles grdAtt.MouseClick
        clearDet()

        If grdAtt.Rows.Count > 0 Then

            If grdAtt.RowCount > -1 Then
                Me.txtVNo.Text = grdAtt.Rows(grdAtt.CurrentCell.RowIndex).Cells(1).Value
                Me.lblVID.Text = grdAtt.Rows(grdAtt.CurrentCell.RowIndex).Cells(0).Value
                Me.TabMain.SelectedTab = TabPage1
                dt = objCommon.GetDataTable("EXEC SpGetbyID_AccVoucherMain '" & lblVID.Text & "'")
                'cmbCurrency.SelectedValue = dt.Rows(0)("VType")
                dtpDate.Text = dt.Rows(0)("VDate")
                txtRemarks.Text = dt.Rows(0)("VName")
                txtRefernceNo.Text = dt.Rows(0)("RefNo")
                lblVID.Text = dt.Rows(0)("VID")
                If (dt.Rows(0)("IsCanceled") = True) Then
                    chkCancel.Checked = True
                Else
                    chkCancel.Checked = False

                End If
                If (dt.Rows(0)("CancelDate") = "01/01/1900 00:00:00") Then
                    dtpCancelDate.ResetText()
                Else
                    'dtpCancelDate.Text = dt.Rows(0)("CancelDate")
                End If
                If (dt.Rows(0)("IsReOccurring")) Then

                End If
                If (dt.Rows(0)("IsPosted")) Then

                End If
                If (dt.Rows(0)("IsAutoReversal")) Then

                End If
                'If (dt.Rows(0)("ReversalDate") = "01/01/1900 00:00:00") Then

                'End If


                'dt = objCommon.GetDataTable("SELECT TOP (100) D.VID, D.MID, D.VCodeType, D.VCode, D.Remarks, D.Debit, D.Credit, D.RefNo, D.SrlNo, D.UID, D.Tranzdatetime, COA.VName " & _
                '                            " FROM tblAcJVDet AS D INNER JOIN tblAcSetupCOA AS COA ON COA.VCode = D.VCode WHERE D.MID=" & Setdouble(lblVID.Text))

                dt = objCommon.GetDataTable("EXEC SpGetbyID_AccVoucherDetail '" & lblVID.Text & "'")

                DataGridView1.Rows.Clear()
                For I As Integer = 0 To dt.Rows.Count - 1
                    Dim row As String() = New String() {dt.Rows(I)("MID"), dt.Rows(I)("AccountID"), dt.Rows(I)("AccountTitle"), dt.Rows(I)("VName"), dt.Rows(I)("AccountTitle"), dt.Rows(I)("ChequeNo"), dt.Rows(I)("ExchangeID"), dt.Rows(I)("CurrencyCode"), dt.Rows(I)("Dr"), dt.Rows(I)("Cr"), dt.Rows(I)("ExchangeRate"), String.Format("{0:N4}", (dt.Rows(I)("ExchangeRate") * dt.Rows(I)("Dr"))), String.Format("{0:N4}", (dt.Rows(I)("ExchangeRate") * dt.Rows(I)("Cr")))}
                    DataGridView1.Rows.Add(row)
                Next

            End If
        End If
        Me.TotalDebitCredit()
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
      Dim cWhere As String = " WHERE VDATE between ''" & Convert.ToDateTime(dtFDateFrom.Value).ToString("dd/MMM/yyyy") & "'' AND ''" & Convert.ToDateTime(dtFDateTo.Value).ToString("dd/MMM/yyyy") & "'' "
        If Not txtFVNo.Text = "" Then cWhere &= " AND VNo=''" & txtFVNo.Text & "'' "
        cWhere &= " AND VType=''" & VType & "'' "
        If Not txtFRemarks.Text = "" Then cWhere &= " AND Remarks like ''%" & txtRemarks.Text & "%'' "

        qryMain = "EXEC SpGet_AccVoucherMain " & G_FinancialYearID & "," & G_Compcode & ", " & VType & ",'" & cWhere & "' "
        grdAtt.DataSource = objCommon.GetDataTable(qryMain)
        If grdAtt.Rows.Count > 0 Then grdAtt.Columns(0).Visible = False
        If grdAtt.Rows.Count > 0 Then setGrid(grdAtt)
    End Sub

    Private Sub cmdNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNew.Click
        clearDet()
        clearHead()
        'objCommon.FillAcSetupVType(Me.cmbCurrency)
        dtFDateFrom.Value = Date.Today
        dtFDateTo.Value = Date.Today
        dtpDate.Value = Date.Today
        txtRemarks.Text = String.Empty
        txtVNo.Text = String.Empty
        Me.lblAcctID.Text = ""
        btnSearch_Click(sender, e)
        DataGridView1.Rows.Clear()
        index = -1
        lblVID.Text = "0"
    End Sub

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub

    Private Sub cmdPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrint.Click   ''pending
        MyListDic.Clear()
        If Not txtVNo.Text = "" Then
         rpt = (WinReportsApplication.Classess.AccountsReport.SetReportName("acrptvoucherMultiCurrency"))
            'ReportFilePath = Path.Combine(Directory.GetCurrentDirectory(), "Reports\CrystalReport2.rpt")
            FilterVTypeList = ""
            FilterDate = ""
            ReportTitle = ""
            MyListDic.Add("@VID", lblVID.Text)
         ReportSpName = "spRpt_AccVoucherMain_IDWise"
         dtrpt = objCommon.GetDataTableSPPrm(ReportSpName, MyListDic)

         MyListDic.Add("PrintedBy", G_UID)
            MyListDic.Add("cGroupofCompany", G_CompName)

            'MyListDic.Add("@cWhere", " where AH.VId = " & lblVID.Text)

            MyReportViewer = New ReportViewer
         MyReportViewer.dtrpt = dtrpt
         MyReportViewer.MyListDic = MyListDic
         MyReportViewer.rtp = rpt
         MyReportViewer.MdiParent = EMSMain
            MyReportViewer.Show()
        End If
    End Sub

    Private Sub txtAccountCode_Enter(sender As System.Object, e As System.EventArgs) Handles txtAccountHead.Enter
        txtAccountHead.SelectionStart = 0
        txtAccountHead.SelectionLength = txtAccountHead.Text.Length
    End Sub
    Private Sub txtNarration_Enter(sender As System.Object, e As System.EventArgs) Handles txtNarration.Enter
        txtNarration.SelectionStart = 0
        txtNarration.SelectionLength = txtNarration.Text.Length
    End Sub
    Private Sub txtDebit_Enter(sender As System.Object, e As System.EventArgs) Handles txtDebit.Enter
        txtDebit.SelectionStart = 0
        txtDebit.SelectionLength = txtDebit.Text.Length
    End Sub
    Private Sub txtCredit_Enter(sender As System.Object, e As System.EventArgs) Handles txtCredit.Enter
        txtCredit.SelectionStart = 0
        txtCredit.SelectionLength = txtCredit.Text.Length
    End Sub

    Private Sub chkCancel_CheckedChanged(sender As Object, e As EventArgs) Handles chkCancel.CheckedChanged
        If (chkCancel.Checked = True) Then
            dtpCancelDate.Enabled = True
        ElseIf (chkCancel.Checked = False) Then
            dtpCancelDate.Enabled = False
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        clearDet()
    End Sub

    Private Sub dtFDateTo_ValueChanged(sender As Object, e As EventArgs) Handles dtFDateTo.ValueChanged
        dtFDateFrom.MaxDate = dtFDateTo.Value
    End Sub

    Private Sub cmbCurrency_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cmbCurrency.SelectionChangeCommitted
        lblCurrencyID.Text = cmbCurrency.SelectedValue
    End Sub

    Private Sub cmdDelete_Click(sender As System.Object, e As System.EventArgs) Handles cmdDelete.Click
        qryMain = "EXEC SpDelete_AccVoucherMain " & lblVID.Text & ", 'AccVoucherMain', 'AccVoucherDetail'," & G_UID & " "
        objCommon.ExecuteNonQuery(qryMain)
        MessageBox.Show("Voucher removed Successfully ", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        clearHead()
        clearDet()
        DataGridView1.Rows.Clear()
        btnSearch_Click(sender, e)
        txtVNo.Focus()
    End Sub
End Class