Imports System.Collections.Specialized
Imports System.IO
Imports CrystalDecisions.CrystalReports.Engine


Public Class frmCPVSimpleNew
    Dim index As Integer = -1
    Dim objCommon As New clsCommon
    Dim dt As New DataTable
    Dim qryMain As String
    Dim action As Char = "I"

    Dim rpt As New ReportClass

    Dim MyListDic As New ListDictionary
    Dim ReportFilePath As String = ""
    Dim ReportTitle As String = ""
    Dim ReportFilter As String = ""
    Dim FilterVTypeList As String = ""
    Dim VTYpe As String = ""

    Dim FilterDate As String = ""
    Dim FilterAccCode As String = ""
    Dim ReportSpName As String = ""
    Dim dtrpt As DataTable

    Private Sub frmGL_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        G_CURRENTDATE = Date.Now
        If G_CURRENTDATE > G_SOFTENDDATE Then
            End
        End If

        'objCommon.FillAcSetupVType(Me.cmbCurrency)
        VTYpe = EMSMain.VType

        If (VTYpe = "CRV") Then
            lblHeading.Text = "Cash Receipt Voucher"
            Me.Text = "Cash Receipt Voucher"
        ElseIf (VTYpe = "BPV") Then
            lblHeading.Text = "Bank Payment Voucher"
            Me.Text = "Bank Payment Voucher"
        ElseIf (VTYpe = "BRV") Then
            lblHeading.Text = "Bank Receipt Voucher"
            Me.Text = "Bank Receipt Voucher"
        End If

        If (VTYpe = "CPV") Or (VTYpe = "CRV") Then
            PanelChequeNo.Hide()
        End If


        objCommon.FillDepartment(Me.cmbDepartment)
        objCommon.FillAcSetupVType(Me.cmbFVtype)
        objCommon.FillOrder(Me.cmbOrder)
        objCommon.FillSingleAccType(Me.cmbAccType)
        objCommon.FillAccMainHead(Me.cmbAccMainHead, "F" + VTYpe)
        cmbAccType.SelectedIndex = 0
        'cmbCurrency.SelectedValue = "JVM"
        dtFDateTo.Value = Date.Today
        dtFDateFrom.Value = DateTime.Today.Month & "/1/" & DateTime.Today.Year
        dtpDate.MinDate = PeriodFrom
        dtpDate.MaxDate = PeriodTo
        Me.lblAcctID.Text = ""
        btnSearch_Click(sender, e)
        lblVID.Text = "0"
        txtVNo.Focus()
        setGrid(DataGridView1)
    End Sub

    Private Sub clearHead()
        For Each ctl In SplitContainer1.Panel1.Controls
            If TypeOf ctl Is TextBox Then ctl.Text = ""
        Next ctl
        txtRefNo.Text = ""
        For Each ctl In SplitContainer1.Panel1.Controls
            If TypeOf ctl Is CheckBox Then ctl.Text = ""
        Next ctl
        For Each ctl In SplitContainer1.Panel1.Controls
            If TypeOf ctl Is Label Then ctl.Text = ""
        Next ctl
        dtFDateFrom.Value = DateTime.Today.Month & "/1/" & DateTime.Today.Year
        lblVID.Text = "0"
        txtVNo.Text = ""
    End Sub
    Private Sub clearDet()
        Me.txtAccHeadDet.Text = String.Empty
        Me.txtNarration.Text = String.Empty
        'Me.txtChequeNo.Text = String.Empty
        Me.txtAmount.Text = String.Empty
        'Me.txtCredit.Text = String.Empty
        Me.txtAccHeadDet.Text = String.Empty
        Me.lblAcctID.Text = String.Empty
        Me.lblAccountTitle.Text = String.Empty
        Me.cmbAccType.SelectedIndex = 0
        'Me.lblAcctID.Text = String.Empty
    End Sub

    Private Sub TotalDebitCredit()
        Dim totalDebit As Double = 0
        Dim totalCredit As Double = 0
        For Each grid As DataGridViewRow In DataGridView1.Rows
            totalDebit = totalDebit + Setdouble(grid.Cells(6).Value) ' Convert.ToDouble(IIf(grid.Cells(6).Value = "", 0, grid.Cells(6).Value))
            totalCredit = totalCredit + Setdouble(grid.Cells(7).Value) ' Convert.ToDouble(IIf(grid.Cells(7).Value = "", 0, grid.Cells(7).Value))
        Next
        Me.lblDebitSum.Text = totalDebit.ToString
        Me.lblCreditSum.Text = totalCredit.ToString
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        'true  xor false = true
        'Me.cmbAccType.SelectedValue = 1
        Dim dr As Double, cr As Double
        dr = Setdouble(Me.txtAmount.Text)
        'cr = Setdouble(Me.txtCredit.Text)
        If Not ((dr > 0) Xor (cr > 0)) Then
            MessageBox.Show("Select proper Dr/Cr amount", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtAmount.Focus()
            Return
        End If

        If index > -1 And Me.lblAcctID.Text.Trim <> String.Empty Then
            DataGridView1.Rows(index).Cells(1).Value = Me.lblAcctID.Text
            DataGridView1.Rows(index).Cells(2).Value = Me.cmbAccType.SelectedValue
            DataGridView1.Rows(index).Cells(3).Value = Me.cmbAccType.Text
            'DataGridView1.Rows(index).Cells(3).Value = Me.lblAccountTitle.Text
            DataGridView1.Rows(index).Cells(5).Value = Me.txtAccHeadDet.Text
            DataGridView1.Rows(index).Cells(6).Value = Me.txtNarration.Text
            'DataGridView1.Rows(index).Cells(5).Value = Me.txtChequeNo.Text
            DataGridView1.Rows(index).Cells(7).Value = dr
            'DataGridView1.Rows(index).Cells(7).Value = cr
            index = -1
            Me.clearDet()
        ElseIf index = -1 And Me.lblAcctID.Text.Trim <> String.Empty Then

            Dim row As String() = New String() {0, Me.lblAcctID.Text, Me.cmbAccType.SelectedValue, Me.cmbAccType.Text, 0, Me.txtAccHeadDet.Text, Me.txtNarration.Text, dr}
            DataGridView1.Rows.Add(row)
            Me.clearDet()
        Else
            MessageBox.Show("Select Correct Account", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
        Me.TotalDebitCredit()  ' to calculate sum of debit and credit
        Me.txtAccHeadDet.Focus()
    End Sub

    Event DataGridView1ButtonClick(ByVal sender As DataGridView, ByVal e As DataGridViewCellEventArgs)

    Private Sub DataGridView1_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If DataGridView1.Rows.Count > 0 Then
            Dim senderGrid = DirectCast(sender, DataGridView)
            If TypeOf senderGrid.Columns(e.ColumnIndex) Is DataGridViewImageColumn AndAlso e.RowIndex >= 0 Then
                RaiseEvent DataGridView1ButtonClick(senderGrid, e)
            Else
                index = e.RowIndex
                If index > -1 Then
                    'Me.cmbAccType.SelectedIndex = 1
                    Me.cmbAccType.SelectedValue = DataGridView1.Rows(index).Cells("AccountTypeID").Value
                    Me.lblAcctID.Text = DataGridView1.Rows(index).Cells("AccountID").Value
                    Me.txtAccHeadDet.Text = DataGridView1.Rows(index).Cells("AccountHead").Value
                    Me.lblVID.Text = DataGridView1.Rows(index).Cells("VID").Value
                    'Me.lblAccountTitle.Text = DataGridView1.Rows(index).Cells("").Value
                    Me.txtNarration.Text = DataGridView1.Rows(index).Cells("Narration").Value
                    'Me.txtChequeNo.Text = DataGridView1.Rows(index).Cells(5).Value
                    Me.txtAmount.Text = DataGridView1.Rows(index).Cells("Debit").Value


                    'Me.txtCredit.Text = DataGridView1.Rows(index).Cells(7).Value
                End If
            End If
        End If
    End Sub


    Private Sub DataGridView1_ButtonClick(ByVal sender As DataGridView, ByVal e As DataGridViewCellEventArgs) Handles Me.DataGridView1ButtonClick
        'TODO - Button Clicked - Execute Code Here
        DataGridView1.Rows.Remove(sender.CurrentRow)
        TotalDebitCredit()

    End Sub


    Private Sub txtDebit_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtAmount.KeyPress
        Dim dotLength As Integer = 1
        dotLength = Me.txtAmount.Text.Split(".").Length
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

    Private Sub txtCredit_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Dim dotLength As Integer = 1
        'dotLength = Me.txtCredit.Text.Split(".").Length


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
            Dim ErrMsg As String = verifySave()
            If Not ErrMsg = "" Then
                MessageBox.Show(ErrMsg, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            Dim MID As Integer = 0

            'If Setdouble(lblVID.Text) <= 0 Then
            '    Dim strcode As String
            '    strcode = objCommon.ExecuteScalar("select isnull(max(cast(left(VNo,3) as int)),0) + 1  as VCode from tblAcJVHead where right(VNo,4) = '" & CDate(dtpDate.Value).ToString("MMyy") & "'; ")
            '    strcode = Double.Parse(strcode).ToString("000") & "/" & CDate(dtpDate.Value).ToString("MMyy")
            '    qryMain = " insert into tblAcJVHead (VNo, VType, VDate, RefNo, Remarks, IsCancel, CancelDate, IsPosted, PostedDate, FYear, UID, Tranzdatetime, CompCode) " &
            '    " values ('" & strcode & "', '" & cmbCurrency.SelectedValue & "', '" & CDate(dtpDate.Value).ToString("dd/MMM/yyyy") & "', 'RefNo', '" & txtRemarks.Text & "', 0, '01/01/1900', 1, '" & CDate(dtpDate.Value).ToString("dd/MMM/yyyy") & "', " & CDate(dtpDate.Value).ToString("yyyy") & ", " & G_UID & ", getdate(),0) ; select @@identity as VID  ;  "
            'Else
            '    qryMain = " update tblAcJVHead set VType='" & cmbCurrency.SelectedValue & "', VDate='" & CDate(dtpDate.Value).ToString("dd/MMM/yyyy") & "', Remarks='" & txtRemarks.Text & "', UID=" & G_UID & ", Tranzdatetime=getdate() where VID=" & Setdouble(lblVID.Text) & "  ; select " & Setdouble(lblVID.Text) & " as VID  ; "
            'End If
            Dim strcode As String
            If (txtVNo.Text = "") Then
                strcode = objCommon.ExecuteScalar("select dbo.fnAccMaxCode(" & G_Compcode & "," & G_UID & "," & G_FinancialYearID & ",'" & VTYpe & "','" & CDate(dtpDate.Value).ToString("dd/MMM/yyyy") & "', '" & CDate(dtpDate.Value).ToString("MMyy") & "')")
                If Not (G_CompIni = "BMI") Then
                    strcode = Double.Parse(G_Compcode).ToString("00") & "-" & CDate(dtpDate.Value).ToString("MMyy") & "-" & Double.Parse(strcode).ToString("0000")
                End If
                txtVNo.Text = strcode
                chkCancel.Checked = False
            End If
            If (chkCancel.Checked = False) Then
                dtpCancelDate.Value = Convert.ToDateTime("1/1/1900")
            End If
            qryMain = "EXEC SpSave_AccVoucherMainFixed " & lblVID.Text & ",'" & txtVNo.Text & "','" & VTYpe & "','" & CDate(dtpDate.Value).ToString("dd/MMM/yyyy") & "',1,1,0,'" & txtRemarks.Text & "','" & txtRefNo.Text & "'," & G_Compcode & "," & G_FinancialYearID & "," & hfIsPosted.CheckState & "," & chkCancel.CheckState & ",'" & CDate(dtpCancelDate.Value).ToString("dd/MMM/yyyy") & "',0,'1900-01-01'," & cmbDepartment.SelectedValue & "," & cmbOrder.SelectedValue & ",'" & txtChequeHead.Text & "','" & CDate(dtpChequeDate.Value).ToString("dd/MMM/yyyy") & "',0 ," & G_UID & ",'" & DateTime.Now.ToString("dd/MMM/yyyy") & "','" & G_IPAddress & "'," & G_UID & ",'" & DateTime.Now.ToString("dd/MMM/yyyy") & "','" & G_IPAddress & "'," & cmbAccMainHead.SelectedValue & " "
            MID = objCommon.ExecuteScalar(qryMain)
            If (MID) Then
                objCommon.ExecuteNonQuery("EXEC SpDelete_AccVoucherDetailFixed " & MID & "")
                objCommon.openConnection()
                For Each grid As DataGridViewRow In DataGridView1.Rows
                    'If Setdouble(grid.Cells("VID").Value) <= 0 Then
                    '    qryMain = " insert into tblAcJVDet (MID, VCodeType, VCode, Remarks, Debit, Credit, RefNo, SrlNo, UID, Tranzdatetime)  " &
                    '        " values (" & MID & ",1,'" & grid.Cells("AccountNo").Value & "', '" & grid.Cells("Narration").Value & "', " & Setdouble(grid.Cells("Debit").Value) & ", " & Setdouble(grid.Cells("Credit").Value) & ", 'RefNo', 1, " & G_UID & ", getdate()) ;"
                    'Else
                    '    qryMain = " update tblAcJVDet set VCode='" & grid.Cells("AccountNo").Value & "', Remarks='" & grid.Cells("Narration").Value & "', Debit=" & Setdouble(grid.Cells("Debit").Value) & ", Credit=" & Setdouble(grid.Cells("Credit").Value) & ", UID=" & G_UID & ", Tranzdatetime=getdate() where VID = " & Setdouble(grid.Cells("VID").Value)
                    'End If

                    qryMain = "EXEC SpSave_AccVoucherDetailFixed " & grid.Cells("VID").Value & "," & MID & ", " & grid.Cells("AccountID").Value & "," & grid.Cells("AccountTypeID").Value & "," & Setdouble(grid.Cells("Debit").Value) & ",0,'" & grid.Cells("Narration").Value & "'," & G_CurrencyID & ",0,0,0,0," & G_UID & ",'" & DateTime.Now.ToString("dd/MMM/yyyy") & "','" & G_IPAddress & "'," & G_UID & ",'" & DateTime.Now.ToString("dd/MMM/yyyy") & "','" & G_IPAddress & "' "
                    objCommon.ExecuteNonQueryWithOpen(qryMain)
                Next
                objCommon.CloseConnection()
            End If
            MessageBox.Show("Voucher Successfully Saved", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.lblAcctID.Text = ""
            btnSearch_Click(sender, e)
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
        If DataGridView1.Rows.Count = 0 Then
            verify &= "Must Enter Detail.!" & vbNewLine
            txtAccHeadDet.Focus()
            Return verify
        End If
        If lblVID.Text = "" Or lblVID.Text Is "" Then
            lblVID.Text = "0"
        End If
        If cmbAccMainHead.SelectedValue = 0 Then
            verify &= "Must select Main Account Head.!" & vbNewLine
            cmbAccMainHead.Focus()
        End If

        Dim Lock As String
        Lock = objCommon.ExecuteScalar("select dbo.fnAllowBackDate('Win-ERP','" & VTYpe & "','" & CDate(dtpDate.Value).ToString("dd/MMM/yyyy") & "'," & G_UID & "," & G_Compcode & ", " & G_FinancialYearID & ")")

        If Not (Lock = "") Then
            verify = Lock
            Return verify
        End If
        'If cmbAccType.SelectedIndex = 0 Then
        '   verify &= "Must select  Account Type.!" & vbNewLine
        '   cmbAccType.Focus()
        'End If
        'If cmbCurrency.SelectedValue = "-1" Then
        '    verify &= "Select Valid Voucher Type.!" & vbNewLine
        '    cmbCurrency.Focus()
        'End If

        'If Setdouble(lblDebitSum.Text) <> Setdouble(lblCreditSum.Text) Then
        '    verify &= "Please Select Balance Voucher.!" & vbNewLine
        '    cmbAccountHead.Focus()
        'End If
        For Each grid As DataGridViewRow In DataGridView1.Rows
            ' Dim IsAnalysis As String
            qryMain = "EXEC SpGet_AnalysisCodeCOA  " & grid.Cells("AccountID").Value.ToString() & " "
            ' IsAnalysis = objCommon.ExecuteScalar(qryMain)
            If (objCommon.ExecuteScalar(qryMain)) Then
                If (cmbDepartment.SelectedIndex < 1) Then
                    verify &= "Select Cost Center.!" & vbNewLine
                    Return verify
                End If
            End If
        Next

        Return verify
    End Function

    'Private Sub txtAccountCode_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
    '    If e.KeyCode = Keys.F2 Then
    '        frmLookupCOA.VCodeIni = cmbAccountHead.Text.Trim
    '        frmLookupCOA.VID = lblVID.Text.Trim
    '        frmLookupCOA.VType = VTYpe
    '        frmLookupCOA.ShowDialog()
    '        lblAcctID.Text = frmLookupCOA.VCode
    '        cmbAccountHead.Text = frmLookupCOA.VName
    '        lblAccountTitle.Text = frmLookupCOA.VName
    '        frmLookupCOA.Dispose()
    '        cmbAccountHead.Focus()
    '    End If
    'End Sub

    'Private Sub txtChequeNo_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtChequeNo.KeyPress
    '    If e.KeyChar <> ControlChars.Back Then
    '        e.Handled = Not (Char.IsDigit(e.KeyChar))
    '    End If
    'End Sub

    Private Sub txtAccountCode_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs)

        'qryMain = " select top 1 VName from tblAcSetupCOA where VCode ='" & cmbAccountHead.Text.Trim & "' "
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
                dt = objCommon.GetDataTable("EXEC SpGetbyID_AccVoucherMainFixed '" & lblVID.Text & "','" & VTYpe & "'," & G_Compcode & "")
                'cmbCurrency.SelectedValue = dt.Rows(0)("VType")
                dtpDate.Text = dt.Rows(0)("VDate")
                dtpChequeDate.Value = Convert.ToDateTime(dt.Rows(0)("ChequeDate"))
                txtRemarks.Text = dt.Rows(0)("VName")
                txtChequeHead.Text = dt.Rows(0)("ChequeNo")
                txtRefNo.Text = dt.Rows(0)("RefNo")
                cmbAccMainHead.SelectedValue = dt.Rows(0)("AccountID")
                'txtAccountHead.Text
                lblVID.Text = dt.Rows(0)("VID")

                'dt = objCommon.GetDataTable("SELECT TOP (100) D.VID, D.MID, D.VCodeType, D.VCode, D.Remarks, D.Debit, D.Credit, D.RefNo, D.SrlNo, D.UID, D.Tranzdatetime, COA.VName " &
                dt = objCommon.GetDataTable("EXEC SpGetbyID_AccVoucherDetailFixed '" & lblVID.Text & "'")

                'MID,Ampunt,VName,AccountID'VCode,AccountType,AccountTitle,AccountTypeTitle

                DataGridView1.Rows.Clear()
                For I As Integer = 0 To dt.Rows.Count - 1
                    Dim row As String() = New String() {dt.Rows(I)("MID"), dt.Rows(I)("AccountID"), dt.Rows(I)("AccountType"), dt.Rows(I)("AccountTypeTitle"), dt.Rows(I)("VCode"), dt.Rows(I)("AccountTitle"), dt.Rows(I)("VName"), Math.Round(Decimal.Parse(dt.Rows(I)("Amount")), 2)}
                    DataGridView1.Rows.Add(row)
                Next

            End If
        End If
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        Dim cWhere As String = " WHERE VDATE between ''" & Convert.ToDateTime(dtFDateFrom.Value).ToString("dd/MMM/yyyy") & "'' AND ''" & Convert.ToDateTime(dtFDateTo.Value).ToString("dd/MMM/yyyy") & "'' "
        If Not txtFVNo.Text = "" Then cWhere &= " AND VNo like ''%" & txtFVNo.Text & "%'' "
        cWhere &= " AND VType=''" & VTYpe & "'' "
        cWhere &= " AND CompanyID=" & G_Compcode & " AND FinancialYearID=" & G_FinancialYearID & " "
        If Not txtFRemarks.Text = "" Then cWhere &= " AND H.VName like ''%" & txtFRemarks.Text & "%'' "

        qryMain = "EXEC SpGet_AccVoucherMainFixed " & G_FinancialYearID & "," & G_Compcode & "," & VTYpe & ",'" & cWhere & "'," & G_UID & " "
        grdAtt.DataSource = objCommon.GetDataTable(qryMain)
        If grdAtt.Rows.Count > 0 Then grdAtt.Columns(0).Visible = False
        If grdAtt.Rows.Count > 0 Then setGrid(grdAtt)
    End Sub

    Private Sub cmdNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNew.Click
        clearDet()
        'objCommon.FillAcSetupVType(Me.cmbCurrency)
        dtFDateFrom.Value = Date.Today
        dtFDateTo.Value = Date.Today
        dtpDate.Value = Date.Today
        txtRemarks.Text = String.Empty
        txtVNo.Text = String.Empty
        cmbAccMainHead.SelectedValue = -1
        cmbDepartment.SelectedIndex = 0
        txtChequeHead.Text = "-"
        dtpChequeDate.Value = Date.Today
        txtRefNo.Text = ""
        chkCancel.Checked = False
        Me.lblAcctID.Text = ""
        btnSearch_Click(sender, e)
        DataGridView1.Rows.Clear()
        lblVID.Text = "0"
    End Sub

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub

    Private Sub cmdPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrint.Click   ''pending
        MyListDic.Clear()
        If Not txtVNo.Text = "" Then
            rpt = (WinReportsApplication.Classess.AccountsReport.SetReportName("acrptvoucher"))
            'ReportFilePath = Path.Combine(Directory.GetCurrentDirectory(), "Reports\acrptvoucher.rpt")
            'ReportFilePath = Path.Combine(Directory.GetCurrentDirectory(), "Reports\CrystalReport2.rpt")
            FilterVTypeList = ""
            FilterDate = ""
            ReportTitle = ""
            'MyListDic.Add("@VID", lblVID.Text)
            'MyListDic.Add("PrintedBy", G_UID)
            'MyListDic.Add("cGroupofCompany", G_CompName)
            MyListDic.Add("@VType", VTYpe)
            MyListDic.Add("@CompanyID", G_Compcode)
            MyListDic.Add("@DateFrom", dtpDate.Value)
            MyListDic.Add("@DateTo", dtpDate.Value)
            MyListDic.Add("@cWhere", "Where H.VID= " & lblVID.Text & " and H.VType= '" & VTYpe & "' and H.VNo='" & txtVNo.Text & "'")
            ReportSpName = "spRptAccVoucher"
            dtrpt = objCommon.GetDataTableSPPrm(ReportSpName, MyListDic)

            MyListDic.Add("PrintedBy", G_UID)
            MyListDic.Add("cGroupofCompany", G_CompName)


            'MyListDic.Add("@cWhere", " where AH.VId = " & lblVID.Text)


            Dim MyReportViewer As ReportViewer = New ReportViewer
            MyReportViewer.dtrpt = dtrpt
            MyReportViewer.MyListDic = MyListDic
            MyReportViewer.rtp = rpt
            MyReportViewer.MdiParent = EMSMain
            MyReportViewer.Show()
        End If

    End Sub

    Private Sub txtAccountCode_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'cmbAccountHead.SelectionStart = 0
        'cmbAccountHead.SelectionLength = cmbAccountHead.Text.Length
    End Sub
    Private Sub txtNarration_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNarration.Enter
        txtNarration.SelectionStart = 0
        txtNarration.SelectionLength = txtNarration.Text.Length
    End Sub
    Private Sub txtDebit_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAmount.Enter
        txtAmount.SelectionStart = 0
        txtAmount.SelectionLength = txtAmount.Text.Length
    End Sub
    Private Sub txtCredit_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'txtCredit.SelectionStart = 0
        'txtCredit.SelectionLength = txtCredit.Text.Length
    End Sub

    Private Sub cmdDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDelete.Click
        If Setdouble(lblVID.Text) <= 0 Then
            'lblInformation.Text = "Please select some record to delete."
            Return
        End If
        If MessageBox.Show("Are you sure you want to delete this record?", G_APP_TITLE, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) = DialogResult.No Then
            Return
        End If
        qryMain = "EXEC SpCancel_Vouchers " & lblVID.Text & ", '" & VTYpe & "', " & G_UID & ",'" & G_IPAddress & "' "
        objCommon.ExecuteNonQuery(qryMain)
        MessageBox.Show("Voucher removed Successfully ", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        clearHead()
        clearDet()
        DataGridView1.Rows.Clear()
        btnSearch_Click(sender, e)
        txtVNo.Focus()
    End Sub

    'Private Sub txtAccHeadMain_KeyPress(sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
    '    If e.KeyCode = Keys.F2 Then
    '        frmLookupCOA.VCodeIni = txtAccHeadMain.Text.Trim
    '        frmLookupCOA.VID = lblVID.Text.Trim
    '        frmLookupCOA.VType = VTYpe
    '        frmLookupCOA.ShowDialog()
    '        lblAcctID.Text = frmLookupCOA.VCode
    '        txtAccHeadMain.Text = frmLookupCOA.VName
    '        lblAccountTitle.Text = frmLookupCOA.VName
    '        frmLookupCOA.Dispose()
    '        txtAccHeadMain.Focus()
    '    End If
    'End Sub

    Private Sub cmbAccType_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cmbAccType.SelectedIndexChanged
        Dim AccType = cmbAccType.SelectedValue.ToString
        'MsgBox(cmbAccType.SelectedValue.ToString)
        'objCommon.FillAccHead(Me.cmbAccountHead, AccType)
    End Sub

    Private Sub btnCancel_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnCancel.Click
        clearDet()
    End Sub

    Private Sub chkCancel_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles chkCancel.CheckedChanged

        If (chkCancel.Checked = True) Then
            dtpCancelDate.Enabled = True
        ElseIf (chkCancel.Checked = False) Then
            dtpCancelDate.Enabled = False
        End If

    End Sub

    Private Sub dtFDateTo_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles dtFDateTo.ValueChanged
        dtFDateFrom.MaxDate = dtFDateTo.Value
    End Sub

    Private Sub txtMachineCode_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dtpDate.KeyUp,
      cmbAccType.KeyUp, txtAmount.KeyUp, cmbAccMainHead.KeyUp, txtNarration.KeyUp, txtRemarks.KeyUp, txtRefNo.KeyUp
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If 'ijaz
    End Sub 'Pending

    Private Sub txtAccHeadDet_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtAccHeadDet.KeyDown
        If e.KeyCode = Keys.F2 Then
            frmLookupCOA.VCodeIni = txtAccHeadDet.Text.Trim
            frmLookupCOA.AccTypeID = cmbAccType.SelectedValue.ToString()
            frmLookupCOA.VType = "Fixed" 'VTYpe
            frmLookupCOA.VCode = ""
            frmLookupCOA.VName = ""
            frmLookupCOA.ShowDialog()
            If frmLookupCOA.VCode <> "" Then
                lblAcctID.Text = frmLookupCOA.VCode
                txtAccHeadDet.Text = frmLookupCOA.VName
                lblAccountTitle.Text = frmLookupCOA.VName
                frmLookupCOA.Dispose()
                txtNarration.Focus()
            End If
        End If

    End Sub

    Private Sub Label6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label6.Click

    End Sub

    Private Sub btnExcelExport_Click(sender As Object, e As EventArgs) Handles btnExcelExport.Click
        objCommon.ExportToExcel(grdAtt)
    End Sub

    Private Sub SplitContainer2_Panel1_Paint(sender As Object, e As PaintEventArgs) Handles SplitContainer2.Panel1.Paint

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub dtpDate_ValueChanged(sender As Object, e As EventArgs) Handles dtpDate.ValueChanged

    End Sub

    Private Sub cmbAccMainHead_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbAccMainHead.SelectedIndexChanged

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label18_Click(sender As Object, e As EventArgs) Handles Label18.Click

    End Sub

    Private Sub Label20_Click(sender As Object, e As EventArgs) Handles Label20.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class