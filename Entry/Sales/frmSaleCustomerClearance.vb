Imports System.Collections.Specialized
Imports System.IO
Imports CrystalDecisions.CrystalReports.Engine

Public Class frmSaleCustomerClearance
    Dim index As Integer = -1
    Dim objCommon As New clsCommon
    Dim dt As New DataTable
    Dim qryMain, HeadAmount As String
    Dim action As Char = Convert.ToChar("I")

    Dim rpt As New ReportClass
    Dim MyListDic As New ListDictionary
    Dim ReportFilePath As String = ""
    Dim ReportTitle As String = ""
    Dim ReportFilter As String = ""
    Dim FilterVTypeList As String = ""
    Dim FilterDate As String = ""
    Dim FilterAccCode As String = ""

    Private Sub frmGL_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        G_CURRENTDATE = Date.Now
        If G_CURRENTDATE > G_SOFTENDDATE Then
            End
        End If

        'objCommon.FillPOType(Me.cmbPoType) 
        objCommon.FillCustomer(Me.cmbCustomer)
        objCommon.FillCurrency(Me.cmbCurrency, "''")
        objCommon.FillPayDocType(Me.cmbDocType, "Clearance")
        'objCommon.FillAccMainHead(Me.cmbTaxGLCode, "Tax")
        cmbDocType.SelectedIndex = 0
        'objCommon.FillPaymentTerm(Me.cmbPaymentTerm)
        dtFDateTo.Value = Date.Today
        dtFDateFrom.Value = Convert.ToDateTime("01/" & Today.ToString("MM/yyyy"))
        Me.lblVID.Text = "0"
        btnSearch_Click(sender, e)
        Me.ActiveControl = dtpVDate
    End Sub

    Private Sub clearHead()
        'txtRemarks.Text = String.Empty
        dtpVDate.Value = Date.Today
        txtVCode.Text = ""
        txtNarration.Text = ""
        txtAmount.Text = ""
        'cmbPoType.SelectedValue = -1
        'txtOrderNo.Text = String.Empty
        'txtOrderNo.Text = String.Empty
        'txtMDNNo.Text = String.Empty
        txtFRemarks.Text = String.Empty
        'txtVNo.Text = String.Empty
        txtExchangeRate.Text = ""
        cmbCurrency.SelectedValue = 0
        lblVID.Text = "0"
        lblAdjustedAmountTotal.Text = "0"
        lblExtraTotal.Text = "0"
        lblTotalAmountTotal.Text = "0"
        txtChequeNo.Text = String.Empty
        cmbCustomer.Enabled = True
        cmbDocType.Enabled = True
        cmbDocument.Enabled = True
        index = -1
        dtpVDate.Focus()
    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        Try
            Dim ErrMsg As String = verifySave()
            If Not ErrMsg = "" Then
                MessageBox.Show(ErrMsg, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            Dim MID As Integer = 0
            'qryMain = "EXEC SpSaveInvMdnMain " & lblVID.Text & ", '', '" & CDate(dtpVDate.Value).ToString("dd/MMM/yyyy") & "', '" & txtOrderNo.Text & "', " & cmbPoType.SelectedValue
            'qryMain += ", '" & txtOrderNo.Text & "', '" & txtRemarks.Text & "', " & G_Compcode & ", " & G_FinancialYearID & ", " & G_UID & ", '" & G_IPAddress & "', " & G_UID & ",'" & G_IPAddress & "'"

            Dim DocID As Int32 = 0
            Dim BankID As Int32 = 0
            If cmbDocType.SelectedValue.ToString() = "Cheque" Or cmbDocType.SelectedValue.ToString() = "Cash" Then
                BankID = cmbBank.SelectedValue.ToString()
            Else
                DocID = cmbDocument.SelectedValue.ToString()
            End If
            qryMain = "EXEC SpSave_InvPayment " & lblVID.Text & ",'" & txtVCode.Text & "','" & CDate(dtpVDate.Value).ToString("dd/MMM/yyyy") & "','Clearance','" & cmbCustomer.SelectedValue.ToString() & "'," & G_CurrencyID & "," & IIf(cmbCurrency.SelectedValue = G_CurrencyID, 0, cmbCurrency.SelectedValue) & "," & IIf(cmbCurrency.SelectedValue = G_CurrencyID, 1, Setdouble(txtExchangeRate.Text)) & "," & cmbDocType.SelectedValue.ToString() & "," & DocID & "," & BankID & ",'" & txtChequeNo.Text & "','" & CDate(dtpChequeDate.Value).ToString("dd/MMM/yyyy") & "'," & HeadAmount & ",0.0,'" & CDate(dtpChequeDate.Value).ToString("dd/MMM/yyyy") & "','" & G_Userlogin & "','" & txtNarration.Text & "',0," & G_Compcode & "," & G_UID & ",'" & G_IPAddress & "'," & G_FinancialYearID & "," & G_UID & ",'" & G_IPAddress & "'"
            MID = Convert.ToInt32(objCommon.ExecuteScalar(qryMain))
            objCommon.openConnection()
            For Each grid As DataGridViewRow In grdRecord.Rows

                If grid.Cells("DetAmount").Value > "0" Then
                    qryMain = "EXEC SpSave_InvPaymentDet " & grid.Cells("VID").Value.ToString() & ", " & MID & ", '" & grid.Cells("GRNID").Value.ToString() & "','Clearance', " & grid.Cells("DetAmount").Value.ToString() & "," & grid.Cells("TotalAmount").Value.ToString() & ", " & G_CurrencyID & ",0,0," & grid.Cells("DetDiscount").Value.ToString() & "," & grid.Cells("DetExtra").Value.ToString() & "," & grid.Cells("WHTaxPer").Value.ToString() & "," & grid.Cells("WHTaxAmount").Value.ToString() & ",'--','" & grid.Cells("VType").Value.ToString() & "', '" & grid.Cells("GRNID").Value.ToString() & "', " & G_UID & ", '" & G_IPAddress & "', " & G_UID & ",'" & G_IPAddress & "'"
                    objCommon.ExecuteNonQueryWithOpen(qryMain)
                End If

            Next
            objCommon.CloseConnection()
            MessageBox.Show("Voucher Successfully Saved", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            lblVID.Text = MID.ToString()
            cmdPrint_Click(sender, e)
            cmdNew_Click(sender, e)
            lblVID.Text = "0"
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            objCommon.CloseConnection()
        End Try

        'Me.lblMID.Text = ""
        btnSearch_Click(sender, e)
        'lblVID.Text = "0"
    End Sub
    Private Function verifySave() As String
        Dim verify As String = ""
        If grdRecord.Rows.Count = 0 Then
            verify &= "Must Enter Detail.!" & vbNewLine
            'txtVCode.Focus()
            Return verify
        End If

        If grdRecord.Rows.Count = 1 And grdRecord.Rows(0).Visible = False Then
            verify &= "Must Enter Detail.!" & vbNewLine
            'txtVCode.Focus()
        End If
        If txtAmount.Text = "" Or txtAmount.Text Is "" Then
            txtAmount.Text = "0"
            verify &= "Must Enter Amount.!" & vbNewLine
            txtAmount.Focus()
        End If

        If Not cmbDocType.SelectedValue = "Cheque" Then
            HeadAmount = lblTotalAmountTotal.Text
        Else
            HeadAmount = txtAmount.Text
        End If

        Dim Lock As String
        Lock = objCommon.ExecuteScalar("select dbo.fnAllowBackDate('Win-ERP','frmSaleCustomerClearance','" & CDate(dtpVDate.Value).ToString("dd/MMM/yyyy") & "'," & G_UID & "," & G_Compcode & ", " & G_FinancialYearID & ")")

        If Not (Lock = "") Then
            verify = Lock
            Return verify
        End If
        If lblVID.Text = "" Or lblVID.Text Is "" Then
            lblVID.Text = "0"
        End If

        For Each grid As DataGridViewRow In grdRecord.Rows
            If grid.Cells("DetExtra").Value.ToString = "" Then
                grid.Cells("DetExtra").Value = 0
                'verify &= "Please Add Some Amount.!" & vbNewLine
            End If
        Next
        If cmbDocType.SelectedValue = "Cheque" Then
            If cmbBank.SelectedValue.ToString() = "-1" Then
                verify &= "Please Select Bank.!" & vbNewLine
                cmbBank.Focus()
            End If

        End If
        If cmbDocType.SelectedValue = "Cheque" And txtChequeNo.Text = "" Then
            verify &= "Please Give some Cheque No.!" & vbNewLine
            txtChequeNo.Focus()
        End If
        If Not cmbDocType.SelectedValue = "Cheque" Then
            If cmbDocument.SelectedValue.ToString() = "-1" Then
                verify &= "Please Select some Document.!" & vbNewLine
                cmbDocument.Focus()
            End If

        End If
        'If cmbPoType.SelectedValue = "-1" Then
        '    verify &= "Select Valid Department.!" & vbNewLine
        '    cmbPoType.Focus()
        'End If

        Return verify
    End Function

    Private Sub grdAtt_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles grdAtt.MouseClick
        If grdAtt.Rows.Count > 0 Then
            If grdAtt.RowCount > -1 Then
                Me.TabMain.SelectedTab = TabPage1
                lblVID.Text = grdAtt.Rows(grdAtt.CurrentCell.RowIndex).Cells("VID").Value.ToString()
                dt = objCommon.GetDataTable("EXEC SpGetbyIDInvPaymentMainDetail " & Setdouble(lblVID.Text) & ",'','Clearance'")

                If dt.Rows.Count > 0 Then
                    lblVID.Text = dt.Rows(0)("VID").ToString()
                    txtVCode.Text = dt.Rows(0)("VNo").ToString()
                    dtpVDate.Value = Convert.ToDateTime(dt.Rows(0)("VDate"))
                    txtAmount.Text = dt.Rows(0)("HeadAmount").ToString()
                    txtNarration.Text = dt.Rows(0)("Instructions").ToString()
                    dtpChequeDate.Value = Convert.ToDateTime(dt.Rows(0)("ReceivedDate"))
                    txtChequeNo.Text = dt.Rows(0)("ChequeNo").ToString()
                    cmbCustomer.SelectedValue = dt.Rows(0)("SupplierID").ToString()
                    'txtMDNNo.Text = dt.Rows(0)("MDNNo")
                    cmbDocType.SelectedValue = dt.Rows(0)("DocType")
                    cmbDocument.SelectedValue = dt.Rows(0)("DocID")
                    cmbBank.SelectedValue = dt.Rows(0)("BankID")
                    txtExchangeRate.Text = dt.Rows(0)("ExchangeRate")
                    If dt.Rows(0)("ExchangeID") = 0 Then
                        cmbCurrency.SelectedValue = dt.Rows(0)("CurrencyID")
                    Else
                        cmbCurrency.SelectedValue = dt.Rows(0)("ExchangeID")
                    End If
                    'txtRefNo.Text = dt.Rows(0)("RefNo")
                    'txtRemarks.Text = dt.Rows(0)("Remarks")
                    ''row = New String() {"0", rows("PurchaseOrderID").ToString(), rows("SupplierID").ToString(), rows("IGPID").ToString(), rows("GRNID").ToString(), rows("PONO").ToString(), rows("VType").ToString(), rows("VoucherNo").ToString(), rows("GRNAmount").ToString(), "0", rows("GRNAmount").ToString(), "0", "0", "0", ""}
                    cmbCustomer.Enabled = False
                    cmbDocType.Enabled = False
                    cmbDocument.Enabled = False
                    grdRecord.Rows.Clear()
                    For I As Integer = 0 To dt.Rows.Count - 1
                        Dim row As String() = New String() {dt.Rows(I)("DID").ToString(), dt.Rows(I)("PurchaseOrderID").ToString(), dt.Rows(I)("SupplierID").ToString(), dt.Rows(I)("IGPID").ToString(), dt.Rows(I)("GRNID").ToString(), dt.Rows(I)("PONO").ToString(), dt.Rows(I)("VType").ToString(), dt.Rows(I)("VoucherNo").ToString(), dt.Rows(I)("GRNAmount").ToString(), dt.Rows(I)("DetAmount").ToString(),
                            (Setdouble(dt.Rows(I)("GRNAmount").ToString()) - Setdouble(dt.Rows(I)("DetAmount").ToString())).ToString(), dt.Rows(I)("DetDiscount").ToString(), dt.Rows(I)("DetExtra").ToString(), dt.Rows(I)("DetAmount").ToString(), dt.Rows(I)("WHTaxPer").ToString(), dt.Rows(I)("WHTaxAmount").ToString(), (Setdouble(dt.Rows(I)("DetAmount").ToString()) + Setdouble(dt.Rows(I)("WHTaxAmount").ToString()) + Setdouble(dt.Rows(I)("DetExtra").ToString())).ToString(), dt.Rows(I)("DetInstruction").ToString()}
                        grdRecord.Rows.Add(row)
                    Next
                End If
            End If
        End If
    End Sub



    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        Dim cWhere As String = " WHERE VDATE between ''" & Convert.ToDateTime(dtFDateFrom.Value).ToString("dd/MMM/yyyy") & "'' AND ''" & Convert.ToDateTime(dtFDateTo.Value).ToString("dd/MMM/yyyy") & "''"
        If Not txtFVNo.Text = "" Then cWhere &= " AND VNo like ''%" & txtFVNo.Text & "%'' "
        'If Not cmbFVtype.SelectedValue = "-1" Then cWhere &= " AND VType='" & cmbFVtype.SelectedValue & "' "
        If Not txtFRemarks.Text = "" Then cWhere &= " AND Remarks like ''%" & txtFRemarks.Text & "%'' "
        qryMain = "EXEC SpGetByShow_InvPayment " & G_Compcode & ",'Clearance','" & cWhere & "'"
        grdAtt.DataSource = objCommon.GetDataTable(qryMain)
        If grdAtt.Rows.Count > 0 Then setGrid(grdAtt)
        If grdAtt.Rows.Count > 0 Then grdAtt.Columns(0).Visible = False
    End Sub

    Private Sub cmdNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNew.Click
        grdRecord.Rows.Clear()
        clearHead()
    End Sub

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub

    Private Sub cmdPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrint.Click   ''pending
        MyListDic.Clear()
        rpt = (WinReportsApplication.Classess.InventoryReport.SetReportName("rptIssueNote"))
        FilterVTypeList = ""
        FilterDate = ""
        ReportTitle = ""


        'MyListDic.Add("@cWhere", " where AH.VId = " & lblVID.Text)
        MyListDic.Add("PrintType", "")
        MyListDic.Add("comp_Name", G_CompName)
        MyListDic.Add("@VID", lblVID.Text)


        Dim MyReportViewer As ReportViewer = New ReportViewer
        MyReportViewer.MyListDic = MyListDic
        MyReportViewer.rtp = rpt
        MyReportViewer.MdiParent = EMSMain
        'MyReportViewer.Show()

    End Sub

    Private Sub cmdDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDelete.Click
        'qryMain = " delete from tblAcJVDet where MId = " & lblVID.Text & " ; delete from tblAcJVHead where VId = " & lblVID.Text & " ; "
        'objCommon.ExecuteNonQuery(qryMain)
        'MessageBox.Show("Voucher removed Successfully ", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        'clearHead()
        'grdRecord.Rows.Clear()
        'btnSearch_Click(sender, e)
        'txtVNo.Focus()
    End Sub



    Private Sub grdRecord_EditingControlShowing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles grdRecord.EditingControlShowing
        If grdRecord.CurrentCell.ColumnIndex = grdRecord.Columns("DetDiscount").Index Then
            AddHandler CType(e.Control, TextBox).KeyPress, AddressOf TextBox_keyPress
            'ElseIf grdRecord.CurrentCell.ColumnIndex = 1 Then
            '   AddHandler CType(e.Control, TextBox).KeyPress, AddressOf TextBox_keyPress1
        ElseIf grdRecord.CurrentCell.ColumnIndex = grdRecord.Columns("DetExtra").Index Then
            AddHandler CType(e.Control, TextBox).KeyPress, AddressOf TextBox_keyPress
            'ElseIf grdRecord.CurrentCell.ColumnIndex = 1 Then
            '   AddHandler CType(e.Control, TextBox).KeyPress, AddressOf TextBox_keyPress1
        ElseIf grdRecord.CurrentCell.ColumnIndex = grdRecord.Columns("DetAmount").Index Then
            AddHandler CType(e.Control, TextBox).KeyPress, AddressOf TextBox_keyPress
            'ElseIf grdRecord.CurrentCell.ColumnIndex = 1 Then
            '   AddHandler CType(e.Control, TextBox).KeyPress, AddressOf TextBox_keyPress1
        ElseIf grdRecord.CurrentCell.ColumnIndex = grdRecord.Columns("DetInstructions").Index Then
            AddHandler CType(e.Control, TextBox).KeyPress, AddressOf TextBox_keyPress1
        End If
    End Sub
    Private Sub TextBox_keyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs)
        If e.KeyChar <> ControlChars.Back Then If Not (Char.IsDigit(CChar(CStr(e.KeyChar))) Or e.KeyChar = ".") Then e.Handled = True
        'If e.KeyChar <> ControlChars.Back Then If Char.IsDigit(CChar(CStr(e.KeyChar))) = False Then e.Handled = True
    End Sub

    Private Sub TextBox_keyPress1(ByVal sender As Object, ByVal e As KeyPressEventArgs)
        If e.KeyChar <> ControlChars.Back Then If Char.IsDigit(CChar(CStr(e.KeyChar))) = False Then e.Handled = True
        'If e.KeyChar <> ControlChars.Back Then If Not (Char.IsDigit(CChar(CStr(e.KeyChar))) Or e.KeyChar = ".") Then e.Handled = True
    End Sub


    'dt.Rows(I)("UomID"), dt.Rows(I)("VCode"), dt.Rows(I)("ProductName"), dt.Rows(I)("UOM"), dt.Rows(I)("MDNQty"), dt.Rows(I)("Qty")

    Private Sub loadDetGrid()
        grdRecord.Rows.Clear()
        qryMain = "EXEC spGetSupplierGRN '" & cmbCustomer.SelectedValue.ToString & "','','Clearance'"
        Dim dt As DataTable = objCommon.GetDataTable(qryMain)
        If IsNothing(dt) Then
            'EmptyFields()
            Return
        End If
        Dim row As String()
        For Each rows As DataRow In dt.Rows
            row = New String() {"0", rows("PurchaseOrderID").ToString(), rows("SupplierID").ToString(), rows("IGPID").ToString(), rows("GRNID").ToString(), rows("PONO").ToString(), rows("VType").ToString(), rows("VoucherNo").ToString(), rows("GRNAmount").ToString(), "0", rows("GRNAmount").ToString(), "0", "0", "0", "0", "0", ""}
            grdRecord.Rows.Add(row)
        Next rows
        If dt.Rows.Count <= 0 Then
            'EmptyFields()
            Return
        End If
    End Sub

    Private Sub cmbCustomer_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbCustomer.SelectedIndexChanged
        cmbDocType_SelectedIndexChanged(sender, e)
        loadDetGrid()
    End Sub

    Private Sub grdRecord_CellClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles grdRecord.CellClick
        'If grdRecord.Rows.Count > 0 Then
        '   index = e.RowIndex
        '   If e.ColumnIndex = grdRecord.Columns("DEL").Index Then
        '      'Exit Sub
        '      grdRecord.Rows(index).Visible = False
        '      grdRecord.Rows(index).Cells("IsDel").Value = 1
        '      Exit Sub
        '   End If
        'End If
        If cmbDocType.SelectedValue.ToString = "-1" Then
            MessageBox.Show("Please Select Document Type First", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            cmbDocType.Focus()
            Return
        End If
    End Sub

    Private Sub txtMachineCode_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dtpVDate.KeyUp,
      txtAmount.KeyUp, txtNarration.KeyUp, txtVCode.KeyUp, cmbBank.KeyUp, cmbCustomer.KeyUp, dtpChequeDate.KeyUp
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If 'ijaz
    End Sub 'Pending

    Private Sub cmbDocType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbDocType.SelectedIndexChanged
        If cmbDocType.SelectedIndex > 0 Then
            If cmbDocType.SelectedValue = "Cheque" Then
                cmbDocument.DataSource = Nothing
                txtAmount.ReadOnly = False
                objCommon.FillPOSBank(Me.cmbBank)
                Return
            End If
            cmbDocument.DataSource = Nothing
            If cmbCustomer.SelectedIndex = Nothing Then
                Return
            End If
            cmbBank.DataSource = Nothing
            txtAmount.ReadOnly = True
            objCommon.FillDocument(Me.cmbDocument, Me.cmbCustomer.SelectedValue, Me.cmbDocType.SelectedValue, "Clearance")
            Get_SupplierAmmount()
        End If
    End Sub
    Private Sub Get_SupplierAmmount()
        txtAmount.Clear()
        If cmbCustomer.SelectedIndex = Nothing Or cmbDocType.SelectedIndex = Nothing Or cmbDocument.SelectedIndex < 0 Then
            Return
        End If
        qryMain = "EXEC SpGet_DocumentAmount " & cmbDocument.SelectedValue.ToString & ", '" & cmbDocType.SelectedValue & "','Clearance'"
        Dim dt As DataTable = objCommon.GetDataTable(qryMain)
        If IsNothing(dt) Then
            'EmptyFields()
            Return
        End If
        For Each rows As DataRow In dt.Rows
            txtAmount.Text = rows("NetAmount").ToString()
        Next rows
    End Sub

    Private Sub grdRecord_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles grdRecord.CellValueChanged

        Dim EQty, Extra, PendingQty, Discount, Total, Current, WHTaxPer, WHTaxValue As Double
        If grdRecord.Rows.Count > 0 Then
            If e.ColumnIndex = grdRecord.Columns("DetAmount").Index Then
                Current = Setdouble(grdRecord.Rows(e.RowIndex).Cells(e.ColumnIndex).Value.ToString())
                EQty = Setdouble(grdRecord.Rows(e.RowIndex).Cells(e.ColumnIndex).Value.ToString())
                Extra = Setdouble(grdRecord.Rows(e.RowIndex).Cells(e.ColumnIndex - 1).Value.ToString())
                Discount = Setdouble(grdRecord.Rows(e.RowIndex).Cells(e.ColumnIndex - 2).Value.ToString())
                WHTaxPer = Setdouble(grdRecord.Rows(e.RowIndex).Cells("WHTaxPer").Value)
                Total = EQty + Extra '- Discount
                grdRecord.Rows(e.RowIndex).Cells("WHTaxAmount").Value = (Total * WHTaxPer) / 100
                WHTaxValue = grdRecord.Rows(e.RowIndex).Cells("WHTaxAmount").Value
                grdRecord.Rows(e.RowIndex).Cells("TotalAmount").Value = Total - WHTaxValue

            ElseIf e.ColumnIndex = grdRecord.Columns("DetExtra").Index Then
                Current = Setdouble(grdRecord.Rows(e.RowIndex).Cells(e.ColumnIndex).Value.ToString())
                EQty = Setdouble(grdRecord.Rows(e.RowIndex).Cells(e.ColumnIndex + 1).Value.ToString())
                Extra = Setdouble(grdRecord.Rows(e.RowIndex).Cells(e.ColumnIndex).Value.ToString())
                Discount = Setdouble(grdRecord.Rows(e.RowIndex).Cells(e.ColumnIndex - 1).Value.ToString())
                WHTaxPer = Setdouble(grdRecord.Rows(e.RowIndex).Cells("WHTaxPer").Value)
                Total = EQty + Extra '- Discount
                grdRecord.Rows(e.RowIndex).Cells("WHTaxAmount").Value = (Total * WHTaxPer) / 100
                WHTaxValue = grdRecord.Rows(e.RowIndex).Cells("WHTaxAmount").Value
                grdRecord.Rows(e.RowIndex).Cells("TotalAmount").Value = Total - WHTaxValue

            ElseIf e.ColumnIndex = grdRecord.Columns("WHTaxPer").Index Then

                Current = Setdouble(grdRecord.Rows(e.RowIndex).Cells(e.ColumnIndex).Value.ToString())
                EQty = Setdouble(grdRecord.Rows(e.RowIndex).Cells(e.ColumnIndex - 1).Value.ToString())
                Extra = Setdouble(grdRecord.Rows(e.RowIndex).Cells(e.ColumnIndex - 2).Value.ToString())
                Discount = Setdouble(grdRecord.Rows(e.RowIndex).Cells(e.ColumnIndex - 3).Value.ToString())
                WHTaxPer = Setdouble(grdRecord.Rows(e.RowIndex).Cells("WHTaxPer").Value)
                Total = EQty + Extra '- Discount
                grdRecord.Rows(e.RowIndex).Cells("WHTaxAmount").Value = (Total * WHTaxPer) / 100
                WHTaxValue = grdRecord.Rows(e.RowIndex).Cells("WHTaxAmount").Value
                grdRecord.Rows(e.RowIndex).Cells("TotalAmount").Value = Total - WHTaxValue


            End If
            'grdRecord.Rows(e.RowIndex).Cells("PendingAmount").Value = Setdouble(grdRecord.Rows(e.RowIndex).Cells("GRNAmount").Value) - Setdouble(grdRecord.Rows(e.RowIndex).Cells("CollectedAmount").Value)
            PendingQty = Setdouble(grdRecord.Rows(e.RowIndex).Cells("PendingAmount").Value.ToString())
            If EQty > PendingQty Then
                MessageBox.Show("Amount cannot be greater than Pending Amount.!", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                grdRecord.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = PendingQty
                EQty = PendingQty
                'grdRecord_CellEndEdit(sender, e)
                'Return
            End If
            Dim totalCredit As Double = 0
            Dim ExtraTotal As Double = 0
            Dim AdjustedAmountTotal As Double = 0
            For Each grid As DataGridViewRow In grdRecord.Rows
                If grid.Cells("TotalAmount").Value > "0" Then
                    totalCredit = totalCredit + Setdouble(grid.Cells("TotalAmount").Value.ToString()) ' Convert.ToDouble(IIf(grid.Cells(6).Value = "", 0, grid.Cells(6).Value))
                    ExtraTotal = ExtraTotal + Setdouble(grid.Cells("DetExtra").Value.ToString()) ' Convert.ToDouble(IIf(grid.Cells(6).Value = "", 0, grid.Cells(6).Value))
                    AdjustedAmountTotal = AdjustedAmountTotal + Setdouble(grid.Cells("DetAmount").Value.ToString()) ' Convert.ToDouble(IIf(grid.Cells(6).Value = "", 0, grid.Cells(6).Value))
                End If
            Next
            lblExtraTotal.Text = ExtraTotal.ToString()
            lblAdjustedAmountTotal.Text = AdjustedAmountTotal.ToString()
            lblTotalAmountTotal.Text = totalCredit.ToString()
            If cmbDocType.SelectedValue.ToString = "Cheque" Or cmbDocType.SelectedValue.ToString = "Cash" Then
                'txtAmount.Text = lblTotalAmountTotal.Text
            Else
                If totalCredit > Setdouble(txtAmount.Text) Then
                    MessageBox.Show("Amount cannot be greater than Head Amount.!", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                    grdRecord.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = 0 'Setdouble(txtAmount.Text) - totalCredit + Current
                    'grdRecord_CellEndEdit(sender, e)
                    'EQty = PendingQty

                End If
            End If
        End If
    End Sub


    Private Sub txtAmount_TextChanged(sender As Object, e As EventArgs) Handles txtAmount.TextChanged
        Dim HeadAmount As Double = Setdouble(txtAmount.Text)
        For Each grid As DataGridViewRow In grdRecord.Rows

            If grid.Cells("PendingAmount").Value <= HeadAmount Then
                grid.Cells("DetAmount").Value = grid.Cells("PendingAmount").Value
                HeadAmount = HeadAmount - grid.Cells("PendingAmount").Value

            ElseIf grid.Cells("PendingAmount").Value > HeadAmount Then
                grid.Cells("DetAmount").Value = HeadAmount
                HeadAmount = 0
            End If
            'grid.Cells("DetAmount").Value = grid.Cells("PendingAmount").Value
            'grid.Cells("DetExtra").Value.ToString()
            'grid.Cells("DetAmount").Value.ToString()

        Next
    End Sub

    Private Sub CmbDocument_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbDocument.SelectedIndexChanged
        Get_SupplierAmmount()
    End Sub
End Class