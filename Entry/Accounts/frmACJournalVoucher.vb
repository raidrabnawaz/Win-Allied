Imports System.Collections.Specialized
Imports System.IO
Imports CrystalDecisions.CrystalReports.Engine

Public Class frmACJournalVoucher
    Dim index As Integer = -1
    Dim objCommon As New clsCommon
    Dim dt As New DataTable
    Dim qryMain As String
    Dim action As String = "I"
    Dim VType As String
    Dim SetDet, CWhere As String
    Dim MID As Integer

    Dim dr As Double, cr As Double
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
        objCommon.FillJVVoucherType(Me.cmbVType)
        objCommon.FillDepartment(Me.cmbDepartment)
        objCommon.FillOrder(Me.cmbOrder)
        objCommon.FillAcSetupVType(Me.cmbFVtype)
        'cmbCurrency.SelectedValue = "JVM"
        VType = EMSMain.VType
        'If (VType = "CPV") Then
        '   lblHeading.Text = "Cash Payment Voucher"
        '   Me.Text = "Cash Payment Voucher"
        'ElseIf (VType = "CRV") Then
        '   lblHeading.Text = "Cash Receipt Voucher"
        '   Me.Text = "Cash Receipt Voucher"
        'ElseIf (VType = "BPV") Then
        '   lblHeading.Text = "Bank Payment Voucher"
        '   Me.Text = "Bank Payment Voucher"
        '      'txtVNo.Size = New Size(84, 20)
        '      'lblDate.Location = New Point(230, 20)
        '      'dtpDate.Size = New Size(82, 20)
        '      'dtpDate.Location = New Point(275, 15)
        '      'lblRefNo.Location = New Point(384, 20)
        '      'txtRefernceNo.Size = New Size(84, 20)
        '      'txtRefernceNo.Location = New Point(457, 15)
        '      'txtRemarks.Size = New Size(444, 20)
        '      'txtNarration.Size = New Size(313, 20)
        '      'lblCheque.Visible = True
        '      'txtChequeNo.Visible = True
        '      'grpBoxCheque.Visible = True
        '      'DataGridView1.Columns("ChequeNo").Visible = True
        '      DataGridView1.Columns("Narration").Width = 450
        'ElseIf (VType = "BRV") Then
        '   lblHeading.Text = "Bank Receipt Voucher"
        '   Me.Text = "Bank Receipt Voucher"
        '      'txtVNo.Size = New Size(84, 20)
        '      'lblDate.Location = New Point(230, 20)
        '      'dtpDate.Size = New Size(82, 20)
        '      'dtpDate.Location = New Point(275, 15)
        '      'lblRefNo.Location = New Point(384, 20)
        '      'txtRefernceNo.Size = New Size(84, 20)
        '      'txtRefernceNo.Location = New Point(457, 15)
        '      'txtRemarks.Size = New Size(444, 20)
        '      'txtNarration.Size = New Size(313, 20)
        '      'lblCheque.Visible = True
        '      'txtChequeNo.Visible = True
        '      'grpBoxCheque.Visible = True
        '      'DataGridView1.Columns("ChequeNo").Visible = True
        '      DataGridView1.Columns("Narration").Width = 450

        'End If
        dtFDateTo.Value = Date.Today
        dtFDateFrom.Value = Convert.ToDateTime(DateTime.Today.Month & "/1/" & DateTime.Today.Year)
        dtpDate.MinDate = Convert.ToDateTime(PeriodFrom)
        dtpDate.MaxDate = Convert.ToDateTime(PeriodTo)
        Me.lblAcctID.Text = ""
        btnSearch_Click(sender, e)
        lblVID.Text = "0"
        txtRefernceNo.Focus()
        setGrid(DataGridView1)
        cmbVType_SelectedIndexChanged(sender, e)
    End Sub

    Private Sub clearHead()
        dtpDate.MaxDate = Convert.ToDateTime(PeriodTo)
        txtRemarks.Text = String.Empty
        cmbVType.Enabled = True
        cmbOrder.SelectedIndex = 0
        cmbVType.SelectedValue = "JV"
        dtpChequeDate.ResetText()
        dtpCancelDate.ResetText()
        chkCancel.Checked = False
        hfIsPosted.Checked = False
        lblAcctID.Text = ""
        Dim ctl As Control
        For Each ctl In SplitContainer1.Panel1.Controls
            If TypeOf ctl Is TextBox Then ctl.Text = ""
        Next ctl
        txtVNo.Text = ""
        txtRefernceNo.Text = ""
        txtChequeHead.Text = ""
        lblVID.Text = "0"
        cmbVType.SelectedIndex = 0
        dtFDateFrom.Value = Convert.ToDateTime(DateTime.Today.Month & "/1/" & DateTime.Today.Year)
    End Sub
    Private Sub clearDet()
        'DataGridView1.Rows.Clear()
        Me.txtAccountHead.Text = String.Empty
        Me.txtNarration.Text = String.Empty
        'Me.txtChequeNo.Text = String.Empty
        Me.txtDebit.Text = "0"
        Me.txtCredit.Text = "0"
        Me.lblAccountTitle.Text = String.Empty
        Me.lblAcctID.Text = String.Empty
        Me.lblInfo.Visible = False
    End Sub

    Private Sub TotalDebitCredit()
        Dim totalDebit As Double = 0
        Dim totalCredit As Double = 0
        For Each grid As DataGridViewRow In DataGridView1.Rows
            totalDebit = totalDebit + Setdouble(grid.Cells("Debit").Value.ToString()) ' Convert.ToDouble(IIf(grid.Cells(6).Value = "", 0, grid.Cells(6).Value))
            totalCredit = totalCredit + Setdouble(grid.Cells("Credit").Value.ToString()) ' Convert.ToDouble(IIf(grid.Cells(7).Value = "", 0, grid.Cells(7).Value))
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
                txtDebit.Text = (totalCredit - totalDebit).ToString()
            Else
                txtCredit.Text = (totalDebit - totalCredit).ToString()
            End If
        End If
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

        If Setdouble(txtDebit.Text) > 0 Then
            For Each grid As DataGridViewRow In DataGridView1.Rows
                If grid.Cells("AccountID").Value.ToString() = lblAcctID.Text And Setdouble(grid.Cells("Credit").Value.ToString()) > 0 Then
                    MessageBox.Show("Cannot add same Account Head on both Debit and Credit sides", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    txtNarration.Focus()
                    Return
                End If
            Next
        End If

        If Setdouble(txtCredit.Text) > 0 Then
            For Each grid As DataGridViewRow In DataGridView1.Rows
                If grid.Cells("AccountID").Value.ToString() = lblAcctID.Text And Setdouble(grid.Cells("Debit").Value.ToString()) > 0 Then
                    MessageBox.Show("Cannot add same Account Head on both Debit and Credit sides", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    txtNarration.Focus()
                    Return
                End If
            Next
        End If

        If index > -1 And Me.lblAcctID.Text.Trim <> String.Empty Then
            DataGridView1.Rows(index).Cells(1).Value = Me.lblAcctID.Text
            DataGridView1.Rows(index).Cells(2).Value = Me.txtAccountHead.Text
            DataGridView1.Rows(index).Cells(4).Value = Me.lblAccountTitle.Text
            DataGridView1.Rows(index).Cells(3).Value = Me.txtNarration.Text
            DataGridView1.Rows(index).Cells(5).Value = Me.txtChequeHead.Text
            DataGridView1.Rows(index).Cells("Debit").Value = dr
            DataGridView1.Rows(index).Cells("Credit").Value = cr
            index = -1
            Me.clearDet()

            If Not (dr = cr) Then
                txtNarration.Text = SetDet
            End If
            Me.TotalDebitCredit()  ' to calculate sum of debit and credit
        ElseIf index = -1 And Me.lblAcctID.Text.Trim <> String.Empty Then

            Dim row As String() = New String() {"0", Me.lblAcctID.Text, Me.txtAccountHead.Text, Me.txtNarration.Text, dr.ToString(), cr.ToString()}
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

    Event DataGridView1ButtonClick(ByVal sender As DataGridView, ByVal e As DataGridViewCellEventArgs)

    Private Sub DataGridView1_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        'If DataGridView1.Rows.Count > 0 Then
        Dim senderGrid = DirectCast(sender, DataGridView)
        If TypeOf senderGrid.Columns(e.ColumnIndex) Is DataGridViewImageColumn AndAlso e.RowIndex >= 0 Then
            RaiseEvent DataGridView1ButtonClick(senderGrid, e)
        Else
            index = e.RowIndex
            If index > -1 Then
                Me.lblAcctID.Text = DataGridView1.Rows(index).Cells(1).Value.ToString()
                Me.txtAccountHead.Text = DataGridView1.Rows(index).Cells(2).Value.ToString()
                Me.lblAccountTitle.Text = DataGridView1.Rows(index).Cells(3).Value.ToString()
                Me.txtNarration.Text = DataGridView1.Rows(index).Cells(3).Value.ToString()
                Me.txtChequeHead.Text = DataGridView1.Rows(index).Cells(5).Value.ToString()
                Me.txtDebit.Text = DataGridView1.Rows(index).Cells("Debit").Value.ToString()
                Me.txtCredit.Text = DataGridView1.Rows(index).Cells("Credit").Value.ToString()
            End If
        End If
    End Sub

    Private Sub DataGridView1_ButtonClick(ByVal sender As DataGridView, ByVal e As DataGridViewCellEventArgs) Handles Me.DataGridView1ButtonClick
        'TODO - Button Clicked - Execute Code Here
        DataGridView1.Rows.Remove(sender.CurrentRow)
        TotalDebitCredit()

    End Sub

    Private Sub txtDebit_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDebit.KeyPress
        Dim dotLength As Integer = 1
        dotLength = Me.txtDebit.Text.Split("."c).Length
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
        dotLength = Me.txtCredit.Text.Split("."c).Length
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
                strcode = objCommon.ExecuteScalar("select dbo.fnAccMaxCode(" & G_Compcode & "," & G_UID & "," & G_FinancialYearID & ",'" & cmbVType.SelectedValue & "','" & CDate(dtpDate.Value).ToString("dd/MMM/yyyy") & "', '" & CDate(dtpDate.Value).ToString("MMyy") & "')")
                If Not (G_CompIni = "BMI") Then
                    strcode = Double.Parse(G_Compcode.ToString()).ToString("00") & "-" & CDate(dtpDate.Value).ToString("MMyy") & "-" & Double.Parse(strcode).ToString("0000")
                End If
                txtVNo.Text = strcode
                chkCancel.Checked = False
                End If

                If (chkCancel.Checked = False) Then
                dtpCancelDate.Value = Convert.ToDateTime("1/1/1900")
            End If

            qryMain = "EXEC SpSave_AccVoucherMain " & lblVID.Text & ",'" & txtVNo.Text & "','" & cmbVType.SelectedValue & "','" & CDate(dtpDate.Value).ToString("dd/MMM/yyyy") & "',1,1,0,'" & txtRemarks.Text & "','" & txtChequeHead.Text & "','" & CDate(dtpChequeDate.Value).ToString("dd/MMM/yyyy") & "','" & txtRefernceNo.Text & "'," & G_Compcode & "," & G_FinancialYearID & "," & hfIsPosted.CheckState & "," & chkCancel.CheckState & ",'" & CDate(dtpCancelDate.Value).ToString("dd/MMM/yyyy") & "',0,'1900-01-01','1900-01-01',0," & cmbDepartment.SelectedValue & "," & cmbOrder.SelectedValue & ",0," & G_UID & ",'" & DateTime.Now.ToString("dd/MMM/yyyy") & "','" & G_IPAddress & "'," & G_UID & ",'" & DateTime.Now.ToString("dd/MMM/yyyy") & "','" & G_IPAddress & "'"
            MID = Convert.ToInt32(objCommon.ExecuteScalar(qryMain))
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
                    If (cmbVType.SelectedValue = "BPV") And (cmbVType.SelectedValue = "BRV") Then
                        grid.Cells("ChequeNo").Value = "-"
                    End If
                    qryMain = "EXEC SpSave_AccVoucherDetail  " & grid.Cells("VID").Value.ToString() & "," & MID & ", " & grid.Cells("AccountID").Value.ToString() & "," & Setdouble(grid.Cells("Debit").Value.ToString()) & "," & Setdouble(grid.Cells("Credit").Value.ToString()) & ",'" & txtChequeHead.Text & "'," & G_CurrencyID & ",1," & G_CurrencyID & ",'" & txtRefernceNo.Text & "','" & grid.Cells("Narration").Value.ToString() & "',0,0," & G_UID & ",'" & DateTime.Now.ToString("dd/MMM/yyyy") & "','" & G_IPAddress & "'," & G_UID & ",'" & DateTime.Now.ToString("dd/MMM/yyyy") & "','" & G_IPAddress & "' "
                    objCommon.ExecuteNonQueryWithOpen(qryMain)
                Next
                objCommon.CloseConnection()
            End If

            MessageBox.Show("Voucher Successfully Saved", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.lblAcctID.Text = ""
            'btnSearch_Click(sender, e)
            DataGridView1.Rows.Clear()
            btnSearch_Click(sender, e)
            lblVID.Text = "0"
            clearHead()
            clearDet()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            objCommon.CloseConnection()
        End Try


        txtVNo.Focus()
    End Sub

    Private Function verifySave() As String
        Dim verify As String = ""
        'If (txtRemarks.Text = "") Then
        '   verify &= "Must Enter Remarks.!" & vbNewLine
        '   txtRemarks.Focus()
        'End If

        Dim Lock As String
        Lock = objCommon.ExecuteScalar("select dbo.fnAllowBackDate('Win-ERP','" & VType & "','" & CDate(dtpDate.Value).ToString("dd/MMM/yyyy") & "'," & G_UID & "," & G_Compcode & ", " & G_FinancialYearID & ")")

        If Not (Lock = "") Then
            verify = Lock
            Return verify
        End If

        If DataGridView1.Rows.Count = 0 Then
            verify &= "Must Enter complete Voucher Detail.!" & vbNewLine
            txtAccountHead.Focus()
        End If

        If Setdouble(lblDebitSum.Text) <> Setdouble(lblCreditSum.Text) Then
            verify &= "Voucher is not Balanced.!" & vbNewLine
            txtAccountHead.Focus()
        End If

        For Each grid As DataGridViewRow In DataGridView1.Rows
            qryMain = "EXEC SpGet_AnalysisCodeCOA  " & grid.Cells("AccountID").Value.ToString() & " "
            If (objCommon.ExecuteScalar(qryMain)) Then
                If (cmbDepartment.SelectedIndex < 1) Then
                    verify &= "Select Cost Center.!" & vbNewLine
                    Return verify
                End If
            End If
        Next

        Return verify
    End Function

    Private Sub txtAccountCode_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtAccountHead.KeyDown
        If e.KeyCode = Keys.F2 Then
            frmLookupCOA.VCodeIni = txtAccountHead.Text.Trim
            frmLookupCOA.VID = Convert.ToInt64(lblVID.Text.Trim)
            frmLookupCOA.VType = VType
            frmLookupCOA.VCode = ""
            frmLookupCOA.VName = ""
            frmLookupCOA.ShowDialog()
            If frmLookupCOA.VCode <> "" Then
                lblAcctID.Text = frmLookupCOA.VCode
                txtAccountHead.Text = frmLookupCOA.VName
                lblAccountTitle.Text = frmLookupCOA.VName
                frmLookupCOA.Dispose()
                txtNarration.Focus()
            End If
        End If
    End Sub

    Private Sub txtChequeNo_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
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
        Try
            If grdAtt.Rows.Count > 0 Then

                If grdAtt.RowCount > -1 Then
                    Me.txtVNo.Text = grdAtt.Rows(grdAtt.CurrentCell.RowIndex).Cells(1).Value.ToString()
                    Me.lblVID.Text = grdAtt.Rows(grdAtt.CurrentCell.RowIndex).Cells(0).Value.ToString()
                    Me.TabMain.SelectedTab = TabPage1
                    dt = objCommon.GetDataTable("EXEC SpGetbyID_AccVoucherMain '" & lblVID.Text & "'")
                    'cmbCurrency.SelectedValue = dt.Rows(0)("VType")
                    dtpDate.Value = Convert.ToDateTime(dt.Rows(0)("VDate"))
                    dtpChequeDate.Value = Convert.ToDateTime(dt.Rows(0)("ChequeDate"))
                    txtChequeHead.Text = dt.Rows(0)("ChequeNo").ToString()
                    txtRemarks.Text = dt.Rows(0)("VName").ToString()
                    cmbOrder.SelectedValue = dt.Rows(0)("OrderID").ToString()
                    txtRefernceNo.Text = dt.Rows(0)("RefNo").ToString()
                    lblVID.Text = dt.Rows(0)("VID").ToString()
                    If (Convert.ToBoolean(dt.Rows(0)("IsCanceled")) = True) Then
                        chkCancel.Checked = True
                    Else
                        chkCancel.Checked = False

                    End If
                    If (Convert.ToBoolean(dt.Rows(0)("IsPosted")) = True) Then
                        hfIsPosted.Checked = True
                    Else
                        hfIsPosted.Checked = False

                    End If
                    If (dt.Rows(0)("CancelDate").ToString() = "01/01/1900 00:00:00") Then
                        dtpCancelDate.ResetText()
                    Else
                        'dtpCancelDate.Text = dt.Rows(0)("CancelDate")
                    End If
                    cmbVType.Enabled = False
                    'If (dt.Rows(0)("IsReOccurring")) Then

                    'End If
                    'If (dt.Rows(0)("IsPosted")) Then

                    'End If
                    'If (dt.Rows(0)("IsAutoReversal")) Then

                    'End If
                    'If (dt.Rows(0)("ReversalDate") = "01/01/1900 00:00:00") Then

                    'End If


                    'dt = objCommon.GetDataTable("SELECT TOP (100) D.VID, D.MID, D.VCodeType, D.VCode, D.Remarks, D.Debit, D.Credit, D.RefNo, D.SrlNo, D.UID, D.Tranzdatetime, COA.VName " & _
                    '                            " FROM tblAcJVDet AS D INNER JOIN tblAcSetupCOA AS COA ON COA.VCode = D.VCode WHERE D.MID=" & Setdouble(lblVID.Text))

                    dt = objCommon.GetDataTable("EXEC SpGetbyID_AccVoucherDetail '" & lblVID.Text & "'")

                    DataGridView1.Rows.Clear()
                    For I As Integer = 0 To dt.Rows.Count - 1
                        Dim row As String() = New String() {dt.Rows(I)("MID").ToString(), dt.Rows(I)("AccountID").ToString(), dt.Rows(I)("AccountTitle").ToString(), dt.Rows(I)("VName").ToString(), Math.Round(Decimal.Parse(dt.Rows(I)("Dr")), 2).ToString(), Math.Round(Decimal.Parse(dt.Rows(I)("Cr")), 2).ToString()}
                        DataGridView1.Rows.Add(row)
                    Next
                    setGrid(DataGridView1)
                End If
            End If
            Me.TotalDebitCredit()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        Dim cWhere As String = " WHERE VDATE between ''" & Convert.ToDateTime(dtFDateFrom.Value).ToString("dd/MMM/yyyy") & "'' AND ''" & Convert.ToDateTime(dtFDateTo.Value).ToString("dd/MMM/yyyy") & "'' "
        If Not txtFVNo.Text = "" Then cWhere &= " AND VNo like ''%" & txtFVNo.Text & "%'' "
        cWhere &= " AND VType=''" & cmbVType.SelectedValue & "'' "
        If Not txtFRemarks.Text = "" Then cWhere &= " AND d.VName like ''%" & txtFRemarks.Text & "%'' "

        qryMain = "EXEC SpGet_AccVoucherMain " & G_FinancialYearID & "," & G_Compcode & ", " & VType & ",'" & cWhere & "'," & G_UID & " "
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
        txtChequeHead.Text = "-"
        dtpChequeDate.Value = Date.Today
        txtRefernceNo.Text = ""
        cmbDepartment.SelectedIndex = 0
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
            Me.Create_CWhere()
            'ReportFilePath = Path.Combine(Directory.GetCurrentDirectory(), "Reports\acrptvoucher.rpt")
            rpt = (WinReportsApplication.Classess.AccountsReport.SetReportName("acrptvoucher"))
            'ReportFilePath = Path.Combine(Directory.GetCurrentDirectory(), "Reports\CrystalReport2.rpt")
            FilterVTypeList = ""
            FilterDate = ""
            ReportTitle = ""
            MyListDic.Add("@VType", VType)
            MyListDic.Add("@CompanyID", G_Compcode)
            MyListDic.Add("@DateFrom", dtpDate.Value)
            MyListDic.Add("@DateTo", dtpDate.Value)
            MyListDic.Add("@cWhere", "Where H.VID= " & lblVID.Text & " and H.VType= '" & cmbVType.SelectedValue & "' and H.VNo='" & txtVNo.Text & "'")
            ReportSpName = "spRptAccVoucher"
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

    Private Sub Create_CWhere()

    End Sub

    Private Sub txtAccountCode_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAccountHead.Enter
        txtAccountHead.SelectionStart = 0
        txtAccountHead.SelectionLength = txtAccountHead.Text.Length
    End Sub
    Private Sub txtNarration_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNarration.Enter
        txtNarration.SelectionStart = 0
        txtNarration.SelectionLength = txtNarration.Text.Length
    End Sub
    Private Sub txtDebit_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDebit.Enter
        txtDebit.SelectionStart = 0
        txtDebit.SelectionLength = txtDebit.Text.Length
    End Sub
    Private Sub txtCredit_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCredit.Enter
        txtCredit.SelectionStart = 0
        txtCredit.SelectionLength = txtCredit.Text.Length
    End Sub

    Private Sub chkCancel_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles chkCancel.CheckedChanged
        If (chkCancel.Checked = True) Then
            dtpCancelDate.Enabled = True
        ElseIf (chkCancel.Checked = False) Then
            dtpCancelDate.Enabled = False
        End If
    End Sub

    Private Sub btnCancel_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnCancel.Click
        clearDet()
    End Sub

    Private Sub dtFDateTo_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles dtFDateTo.ValueChanged
        dtFDateFrom.MaxDate = dtFDateTo.Value
    End Sub

    Private Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnExcelExport.Click
        objCommon.ExportToExcel(grdAtt)
    End Sub
    Dim strcode As String
    Private Sub cmbVType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbVType.SelectedIndexChanged
        Try
            strcode = objCommon.ExecuteScalar("select dbo.fnAccMaxCode(" & G_Compcode & "," & G_UID & "," & G_FinancialYearID & ",'" & cmbVType.SelectedValue & "','" & CDate(dtpDate.Value).ToString("dd/MMM/yyyy") & "', '" & CDate(dtpDate.Value).ToString("MMyy") & "')")
            If Not (G_CompIni = "BMI") Then
                strcode = Double.Parse(G_Compcode.ToString()).ToString("00") & "-" & CDate(dtpDate.Value).ToString("MMyy") & "-" & Double.Parse(strcode).ToString("0000")
            End If
            txtVNo.Text = strcode
            chkCancel.Checked = False
            VType = cmbVType.SelectedValue
        Catch ex As Exception
            Return
        End Try

    End Sub

    Private Sub TabMain_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabMain.SelectedIndexChanged
        If TabMain.SelectedIndex = 1 Then
            btnSearch_Click(sender, e)
        End If
    End Sub

    Private Sub cmdDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDelete.Click
        'qryMain = "EXEC SpDelete_AccVoucherMain " & lblVID.Text & ", 'AccVoucherMain', 'AccVoucherDetail'," & G_UID & " "
        If Setdouble(lblVID.Text) <= 0 Then
            'lblInformation.Text = "Please select some record to delete."
            Return
        End If
        If MessageBox.Show("Are you sure you want to delete this record?", G_APP_TITLE, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) = DialogResult.No Then
            Return
        End If
        qryMain = "EXEC SpCancel_Vouchers " & lblVID.Text & ", '" & VType & "', " & G_UID & ",'" & G_IPAddress & "' "
        objCommon.ExecuteNonQuery(qryMain)
        MessageBox.Show("Voucher removed Successfully ", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        clearHead()
        clearDet()
        DataGridView1.Rows.Clear()
        btnSearch_Click(sender, e)
        txtVNo.Focus()
    End Sub

    Private Sub txtMachineCode_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dtpDate.KeyUp,
     txtAccountHead.KeyUp, txtChequeHead.KeyUp, txtCredit.KeyUp, txtDebit.KeyUp, txtNarration.KeyUp, txtRemarks.KeyUp, txtVNo.KeyUp
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If 'ijaz
    End Sub 'Pending


End Class