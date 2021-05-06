Imports System.Collections.Specialized
Imports System.IO
Imports CrystalDecisions.CrystalReports.Engine



Public Class frmSaleInvoiceExport
    Dim index As Integer = -1
    Dim objCommon As New clsCommon
    Dim dt As New DataTable
    Dim qryMain As String
    Dim action As Char = "I"c
    Dim SaleTax As Double
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

    Private Sub frmGL_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        G_CURRENTDATE = Date.Now
        If G_CURRENTDATE > G_SOFTENDDATE Then
            End
        End If

        objCommon.FillCustomer(Me.cmbCustomer)
        objCommon.FillCurrency(Me.cmbCurrency, "''")
        objCommon.FillBank(Me.cmbBank)
        objCommon.FillPaymentTerm(Me.cmbPaymentTerm)
        objCommon.FillAddressCustomer(Me.cmbAddress, Convert.ToInt32(cmbCustomer.SelectedValue))
        objCommon.FillProdSetType(Me.cmbGoodsDescription)
        objCommon.FillShipmentMethod(Me.cmbShipVia)
        'objCommon.FillUoM(Me.cmbUom)
        dtFDateTo.Value = Date.Today
        dtFDateFrom.Value = Convert.ToDateTime("01/" & Today.ToString("MM/yyyy")) 'Date.Today
        Me.lblVID.Text = "0"
        btnSearch_Click(sender, e)
        Me.ActiveControl = dtpVDate
        clearHead()
        clearDet()
    End Sub

    Private Sub clearHead()
        txtDiscount.Text = String.Empty
        txtSalesTax.Text = String.Empty
        dtpVDate.Value = Date.Today
        cmbCustomer.SelectedValue = -1
        cmbCurrency.SelectedValue = G_CurrencyID
        cmbAddress.SelectedValue = -1
        cmbPaymentTerm.SelectedValue = -1
        'txtOrderNo.Text = String.Empty
        txtRefNo.Text = String.Empty
        txtPaymentCredit.Text = String.Empty
        txtRemarks.Text = String.Empty
        txtFRemarks.Text = String.Empty
        txtExchangeRate.Text = String.Empty
        txtVNo.Text = String.Empty
        cmbBank.SelectedValue = -1
        txtExportRegNo.Text = String.Empty
        txtDestination.Text = String.Empty
        txtDeliveryTerms.Text = String.Empty
        txtLCNo.Text = String.Empty
        dtpLCDate.Value = Date.Today
        cmbGoodsDescription.SelectedValue = 0
        txtHSCode.Text = String.Empty
        cmbShipVia.SelectedValue = -1
        txtMarksNOS.Text = String.Empty
        txtGrossWeight.Text = String.Empty
        txtNetWeight.Text = String.Empty
        lblVID.Text = "0"
        index = -1
        dtpVDate.Focus()
    End Sub
    Private Sub clearDet()
        Me.txtVCode.Text = String.Empty
        Me.txtVName.Text = String.Empty
        Me.txtQuantity.Text = String.Empty
        Me.txtSubTotal.Text = String.Empty
        Me.lblDID.Text = "0"
        Me.txtUnitPrice.Text = String.Empty
        'Me.cmbUom.SelectedValue = -1
    End Sub

    Private Sub GrandTotal()
        Dim totalAmount, amt As Double
        Dim isdel As Int16
        For Each grid As DataGridViewRow In DataGridView1.Rows
            isdel = Setdouble(grid.Cells("IsDel").Value)
            If isdel = 0 Then
                amt = Setdouble(grid.Cells("Amount").Value)
                totalAmount = totalAmount + amt + (amt * Setdouble(txtSalesTax.Text) / 100) ' Convert.ToDouble(IIf(grid.Cells(6).Value = "", 0, grid.Cells(6).Value))
            End If
        Next
        totalAmount = totalAmount - Setdouble(txtDiscount.Text)
        Me.lblGrandTotal.Text = totalAmount.ToString()

    End Sub




    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        'true  xor false = true
        Dim qty As Double
        qty = Setdouble(Me.txtQuantity.Text)
        If Not ((qty > 0)) Then
            MessageBox.Show("Enter Valid Quantity", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtQuantity.Focus()
            Return
        End If

        If (txtUnitPrice.Text = "") Then
            MessageBox.Show("Add Unit Price", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtQuantity.Focus()
            Return
        End If
        If lblPID.Text = "" Then
            MessageBox.Show("Select Valid Product", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtQuantity.Focus()
            Return
        End If

        SaleTax = SaleTax + Setdouble(txtSubTotal.Text * Setdouble(txtSalesTax.Text) / 100)
        If index > -1 And Me.lblVID.Text.Trim <> String.Empty Then
            DataGridView1.Rows(index).Cells("VID").Value = Me.lblDID.Text
            DataGridView1.Rows(index).Cells("ProductID").Value = Me.lblPID.Text
            'DataGridView1.Rows(index).Cells("UomID").Value = Me.cmbUom.SelectedValue
            DataGridView1.Rows(index).Cells("VCode").Value = Me.txtVCode.Text
            DataGridView1.Rows(index).Cells("VName").Value = Me.txtVName.Text
            'DataGridView1.Rows(index).Cells("Condition").Value = Me.txtCondition.Text
            'DataGridView1.Rows(index).Cells("Eta").Value = Me.txtEta.Text
            DataGridView1.Rows(index).Cells("UnitPrice").Value = Me.txtUnitPrice.Text
            DataGridView1.Rows(index).Cells("Quantity").Value = Me.txtQuantity.Text
            DataGridView1.Rows(index).Cells("Amount").Value = Me.txtSubTotal.Text
            'DataGridView1.Rows(index).Cells(7).Value = cr
            index = -1

            Me.clearDet()
        ElseIf index = -1 And Me.lblDID.Text.Trim <> String.Empty Then

            Dim row As String() = New String() {0, lblPID.Text, Me.txtVCode.Text, Me.txtVName.Text, Me.txtUnitPrice.Text, Me.txtQuantity.Text, Me.txtSubTotal.Text}
            DataGridView1.Rows.Add(row)
            'GrandTotal()
            Me.clearDet()
        Else
            MessageBox.Show("Select Correct Entry", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
        Me.txtVCode.Focus()
        GrandTotal()
    End Sub

    Private Sub DataGridView1_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If DataGridView1.Rows.Count > 0 Then
            index = e.RowIndex
            If e.ColumnIndex = DataGridView1.Columns("DEL").Index Then
                'Exit Sub
                DataGridView1.Rows(index).Visible = False
                DataGridView1.Rows(index).Cells("IsDel").Value = 1
                GrandTotal()
                index = -1
                Exit Sub
            End If
            If index > -1 Then
                Me.lblDID.Text = DataGridView1.Rows(index).Cells("VID").Value.ToString()
                Me.lblPID.Text = DataGridView1.Rows(index).Cells("ProductID").Value.ToString()
                Me.txtUnitPrice.Text = DataGridView1.Rows(index).Cells("UnitPrice").Value.ToString()
                Me.txtVCode.Text = DataGridView1.Rows(index).Cells("VCode").Value.ToString()
                Me.txtVName.Text = DataGridView1.Rows(index).Cells("VName").Value.ToString()
                Me.txtQuantity.Text = DataGridView1.Rows(index).Cells("Quantity").Value.ToString()
            End If

        End If

    End Sub

    Private Sub txtQuantity_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtQuantity.KeyPress, txtNetWeight.KeyPress, txtGrossWeight.KeyPress
        Dim dotLength As Integer = 1
        dotLength = Me.txtQuantity.Text.Split("."c).Length
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
            If txtVNo.Text = "" Then
                Dim strcode As String
                strcode = objCommon.ExecuteScalar("select dbo.fnAccMaxCode(" & G_Compcode & "," & G_UID & "," & G_FinancialYearID & ",'SaleInvoice','" & CDate(dtpVDate.Value).ToString("dd/MMM/yyyy") & "', '" & CDate(dtpVDate.Value).ToString("MMyy") & "')")
                'strcode = Double.Parse(G_Compcode).ToString("00") & "-" & CDate(dtpVDate.Value).ToString("MMyy") & "-" & Double.Parse(strcode).ToString("0000")
                txtVNo.Text = strcode
            End If
            Dim MID As Integer = 0
            qryMain = "EXEC SpSave_SaleExportMain @VID=" & lblVID.Text & ", @VNo='" & txtVNo.Text & "', @VDate='" & CDate(dtpVDate.Value).ToString("dd/MMM/yyyy") & "',@QuoteID=0, @CustomerID=" & cmbCustomer.SelectedValue.ToString()
            qryMain += ",@AddressID=" & cmbAddress.SelectedValue.ToString() & ", @PaymentTermID=" & cmbPaymentTerm.SelectedValue.ToString() & ",@CurrencyID=" & G_CurrencyID & ", @ExchangeID=" & IIf(cmbCurrency.SelectedValue = G_CurrencyID, 0, cmbCurrency.SelectedValue) & ",@ExchangeRate=" & IIf(cmbCurrency.SelectedValue = G_CurrencyID, 1, Setdouble(txtExchangeRate.Text)) & ",@SubTotal=0,@PaymentCredit=" & txtPaymentCredit.Text & ",@Handling=0,
                @Discount=" & Setdouble(txtDiscount.Text) & ",@SalesTaxPer=" & Setdouble(txtSalesTax.Text) & ",@SalesTax=" & SaleTax & ", @VatPer=0,@Vat=0,@CCChargesPer=0,@CCCharges=0,@GrandTotal=" & Setdouble(lblGrandTotal.Text) & ",@Eta='--',@Instructions='" & txtRemarks.Text & "',@RefNo='" & txtRefNo.Text & "',@BankID=" & cmbBank.SelectedValue.ToString() _
            & ",@VStatus=0,@ExportRegionNo= '" & txtExportRegNo.Text & "'	, @DestinationPort= '" & txtDestination.Text & "', @DelieveryTerms= '" & txtDeliveryTerms.Text & "', @LCNo= '" & txtLCNo.Text & "', @LCDate= '" & CDate(dtpLCDate.Value).ToString("dd/MMM/yyyy") & "', @OperationSetTypeID= '" & cmbGoodsDescription.SelectedValue & "', @HSCode= '" & txtHSCode.Text & "', @ShippingID	= '" & cmbShipVia.SelectedValue & "',
            @MarksNos	= '" & txtMarksNOS.Text & "', @GrossWeight	=  " & Setdouble(txtGrossWeight.Text) & " , @NetWeight  =  " & Setdouble(txtNetWeight.Text) & " , @CompanyID=" & G_Compcode & ", @FinancialYearID=" & G_FinancialYearID & ", @InsertedBy =" & G_UID & ", @InsertedIp='" & G_IPAddress & "', @UpdatedBy=" & G_UID & ",@UpdatedIp='" & G_IPAddress & "'"
            MID = Convert.ToInt32(objCommon.ExecuteScalar(qryMain))

            objCommon.openConnection()
            For Each grid As DataGridViewRow In DataGridView1.Rows
                qryMain = "EXEC SpSave_SaleExportDetail " & grid.Cells("VID").Value.ToString() & ", " & MID & ",0,0,0, " & grid.Cells("ProductID").Value.ToString() & ", '" & grid.Cells("VName").Value.ToString() & "'," & grid.Cells("UnitPrice").Value.ToString() & ", " & grid.Cells("Quantity").Value.ToString() & ", " & grid.Cells("Amount").Value.ToString() & ",0,'', 0,0,0,0,'', " & G_UID & ", '" & G_IPAddress & "', " & G_UID & ",'" & G_IPAddress & "'"
                objCommon.ExecuteNonQueryWithOpen(qryMain)
            Next
            objCommon.CloseConnection()
            MessageBox.Show("Voucher Successfully Saved", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            'cmdPrint_Click(sender, e)
            cmdNew_Click(sender, e)
            lblVID.Text = "0"

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            objCommon.CloseConnection()
        End Try

        'Me.lblMID.Text = ""
        btnSearch_Click(sender, e)

    End Sub
    Private Function verifySave() As String
        Dim verify As String = ""
        If DataGridView1.Rows.Count = 0 Then
            verify &= "Must Enter Detail.!" & vbNewLine
            txtVCode.Focus()
        ElseIf DataGridView1.Rows(0).Visible = False Then
            verify &= "Must Enter Detail.!" & vbNewLine
            txtVCode.Focus()

        End If


        Dim Lock As String
        Lock = objCommon.ExecuteScalar("select dbo.fnAllowBackDate('Win-ERP','frmSaleInvoice','" & CDate(dtpVDate.Value).ToString("dd/MMM/yyyy") & "'," & G_UID & "," & G_Compcode & ", " & G_FinancialYearID & ")")

        If Not (Lock = "") Then
            verify = Lock
            Return verify
        End If
        For Each grid As DataGridViewRow In DataGridView1.Rows
            If Not Setdouble(grid.Cells("Quantity").Value.ToString()) > 0 Then
                verify &= "Please Add Some Qunatity.!" & vbNewLine
            End If
        Next

        If cmbCustomer.SelectedValue.ToString() = "-1" Then
            verify &= "Select Valid Customer.!" & vbNewLine
            cmbCustomer.Focus()
        End If

        If cmbBank.SelectedValue.ToString() = "-1" Then
            verify &= "Select Valid Bank.!" & vbNewLine
            cmbCustomer.Focus()
        End If

        Return verify
    End Function
    Private Sub txtAccountCode_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtVCode.KeyDown
        If e.KeyCode = Keys.F2 Then
            frmLookup.LookupQuery = "SELECT VID, VCode, VName,IsAccessory,LeadTime,ExcessPer FROM invProduct"
            frmLookup.LookupName = "Product"
            frmLookup.VID = ""
            frmLookup.VCode = ""
            frmLookup.VName = ""
            frmLookup.ShowDialog()
            If frmLookup.VID <> "" Then
                lblPID.Text = frmLookup.VID
                txtVCode.Text = frmLookup.VCode
                txtVName.Text = frmLookup.VName
            End If
            'frmLookupCOA.Dispose()
            txtVCode.Focus()
        End If
    End Sub
    Private Sub txtAccountCode_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtVCode.Leave
        If txtVCode.Text.Trim.Length <> 7 Then
            'lblMID.Text = ""
            'lblAccountTitle.Text = ""
            Return
        End If
        qryMain = " SELECT TOP 1 VID, VCode, VName FROM invProduct WHERE VCode ='" & txtVCode.Text.Trim & "' "
    End Sub

    Private Sub grdAtt_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles grdAtt.MouseClick
        If grdAtt.Rows.Count > 0 Then
            If grdAtt.RowCount > -1 Then
                Me.TabMain.SelectedTab = TabPage1
                lblVID.Text = grdAtt.Rows(grdAtt.CurrentCell.RowIndex).Cells("VID").Value.ToString()
                dt = objCommon.GetDataTable("EXEC SpGetbyIDSaleExportMainDetail " & Setdouble(lblVID.Text))
                If dt.Rows.Count > 0 Then
                    lblVID.Text = dt.Rows(0)("VID").ToString()
                    txtVNo.Text = dt.Rows(0)("VNo").ToString()
                    dtpVDate.Value = Convert.ToDateTime(dt.Rows(0)("VDate"))
                    'dtpCustomerSODate.Value = dt.Rows(0)("CustomerSODate")
                    'txtOrderNo.Text = dt.Rows(0)("OrderNo")
                    cmbCustomer.SelectedValue = dt.Rows(0)("CustomerID")
                    cmbPaymentTerm.SelectedValue = dt.Rows(0)("PaymentTermID")
                    If dt.Rows(0)("ExchangeID") = 0 Then
                        cmbCurrency.SelectedValue = dt.Rows(0)("CurrencyID")
                    Else
                        cmbCurrency.SelectedValue = dt.Rows(0)("ExchangeID")
                    End If
                    cmbAddress.SelectedValue = dt.Rows(0)("AddressID")
                    cmbBank.SelectedValue = dt.Rows(0)("BankID")
                    txtSalesTax.Text = dt.Rows(0)("SalesTaxPer").ToString()
                    txtDiscount.Text = dt.Rows(0)("Discount").ToString()
                    txtRefNo.Text = dt.Rows(0)("RefNo").ToString()
                    txtPaymentCredit.Text = dt.Rows(0)("PaymentCredit").ToString()
                    txtRemarks.Text = dt.Rows(0)("Instructions").ToString()
                    txtExchangeRate.Text = dt.Rows(0)("ExchangeRate").ToString()
                    txtExportRegNo.Text = dt.Rows(0)("ExportRegionNo").ToString()
                    txtDestination.Text = dt.Rows(0)("DestinationPort").ToString()
                    txtDeliveryTerms.Text = dt.Rows(0)("DelieveryTerms").ToString()
                    txtLCNo.Text = dt.Rows(0)("LCNo").ToString()
                    dtpLCDate.Value = dt.Rows(0)("LCDate").ToString()
                    cmbGoodsDescription.SelectedValue = dt.Rows(0)("OperationSetTypeID")
                    txtHSCode.Text = dt.Rows(0)("HSCode").ToString()
                    cmbShipVia.SelectedValue = dt.Rows(0)("ShippingID")
                    txtMarksNOS.Text = dt.Rows(0)("MarksNos").ToString()
                    txtGrossWeight.Text = dt.Rows(0)("GrossWeight").ToString()
                    txtNetWeight.Text = dt.Rows(0)("NetWeight").ToString()
                    DataGridView1.Rows.Clear()
                    For I As Integer = 0 To dt.Rows.Count - 1
                        Dim row As String() = New String() {dt.Rows(I)("DID").ToString(), dt.Rows(I)("OrderID").ToString(), dt.Rows(I)("ProductCode").ToString(), dt.Rows(I)("OrderDesc").ToString(), dt.Rows(I)("UnitPrice").ToString(), dt.Rows(I)("Quantity").ToString(), (Setdouble(dt.Rows(I)("UnitPrice").ToString()) * Setdouble(dt.Rows(I)("Quantity").ToString())).ToString()}
                        DataGridView1.Rows.Add(row)
                    Next
                End If
            End If
        End If
        Me.GrandTotal()
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        Dim cWhere As String = " WHERE VDATE between ''" & Convert.ToDateTime(dtFDateFrom.Value).ToString("dd/MMM/yyyy") & "'' AND ''" & Convert.ToDateTime(dtFDateTo.Value).ToString("dd/MMM/yyyy") & "''"
        If Not txtFVNo.Text = "" Then cWhere &= " AND VNo like ''%" & txtFVNo.Text & "%'' "
        'If Not cmbFVtype.SelectedValue = "-1" Then cWhere &= " AND VType='" & cmbFVtype.SelectedValue & "' "
        If Not txtFRemarks.Text = "" Then cWhere &= " AND Remarks like ''%" & txtFRemarks.Text & "%'' "
        qryMain = "EXEC SpGetInvSearchLookUp 'SaleExport', '" & cWhere & "' "
        grdAtt.DataSource = objCommon.GetDataTable(qryMain)
        If grdAtt.Rows.Count > 0 Then grdAtt.Columns(0).Visible = False
        If grdAtt.Rows.Count > 0 Then setGrid(grdAtt)
    End Sub

    Private Sub cmdNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNew.Click
        clearDet()
        clearHead()
        DataGridView1.Rows.Clear()
    End Sub

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub

    Private Sub cmdPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrint.Click   ''pending
        MyListDic.Clear()
        rpt = (WinReportsApplication.Classess.SalesReports.SetReportName("SaleExport"))
        FilterVTypeList = ""
        FilterDate = ""
        ReportTitle = ""

        MyListDic.Add("@VID", lblVID.Text)
        ReportSpName = "spRptSaleExportMainDetail"
        dtrpt = objCommon.GetDataTableSPPrm(ReportSpName, MyListDic)

        'MyListDic.Add("@Company", G_CompName)
        'MyListDic.Add("PrintedBy", G_Userlogin)
        'MyListDic.Add("IsHeader", True)
        'MyListDic.Add("@cWhere", " where AH.VId = " & lblVID.Text)


        Dim MyReportViewer As ReportViewer = New ReportViewer
        MyReportViewer.dtrpt = dtrpt
        MyReportViewer.MyListDic = MyListDic
        MyReportViewer.rtp = rpt
        MyReportViewer.MdiParent = EMSMain
        MyReportViewer.Show()

    End Sub

    Private Sub txtAccountCode_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtVCode.Enter
        txtVCode.SelectionStart = 0
        txtVCode.SelectionLength = txtVCode.Text.Length
    End Sub
    Private Sub txtNarration_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtVName.Enter
        txtVName.SelectionStart = 0
        txtVName.SelectionLength = txtVName.Text.Length
    End Sub
    Private Sub txtDebit_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtQuantity.Enter
        txtQuantity.SelectionStart = 0
        txtQuantity.SelectionLength = txtQuantity.Text.Length
    End Sub
    Private Sub txtCredit_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'txtCredit.SelectionStart = 0
        'txtCredit.SelectionLength = txtCredit.Text.Length
    End Sub

    Private Sub cmdDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDelete.Click
        'qryMain = " delete from tblAcJVDet where MId = " & lblVID.Text & " ; delete from tblAcJVHead where VId = " & lblVID.Text & " ; "
        'objCommon.ExecuteNonQuery(qryMain)
        'MessageBox.Show("Voucher removed Successfully ", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        'clearHead()
        'clearDet()
        'DataGridView1.Rows.Clear()
        'btnSearch_Click(sender, e)
        'txtVNo.Focus()
    End Sub


    Private Sub BtnClear_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnClear.Click
        clearDet()
    End Sub

    Private Sub txtUnitPrice_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtUnitPrice.KeyPress, txtExchangeRate.KeyPress
        Dim dotLength As Integer = 1
        dotLength = Me.txtUnitPrice.Text.Split(".").Length
        If e.KeyChar <> ControlChars.Back Then
            If dotLength > 1 Then
                e.Handled = Not (Char.IsDigit(e.KeyChar))
            Else
                e.Handled = Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = ".")
            End If
        End If
    End Sub

    Private Sub cmbCustomer_SelectionChangeCommitted(ByVal sender As Object, ByVal e As EventArgs) Handles cmbCustomer.SelectionChangeCommitted
        objCommon.FillAddressCustomer(Me.cmbAddress, Convert.ToInt32(cmbCustomer.SelectedValue))
    End Sub

    Private Sub txtUnitPrice_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles txtUnitPrice.TextChanged
        If txtUnitPrice.Text <> "" And txtQuantity.Text <> "" Then
            txtSubTotal.Text = (Convert.ToDouble(txtUnitPrice.Text) * Convert.ToInt32(txtQuantity.Text)).ToString()
            Return
        End If
        txtSubTotal.Text = 0
    End Sub

    Private Sub txtQuantity_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles txtQuantity.TextChanged
        If txtUnitPrice.Text <> "" And txtQuantity.Text <> "" Then
            txtSubTotal.Text = (Convert.ToDouble(txtUnitPrice.Text) * Convert.ToInt32(txtQuantity.Text)).ToString()
            Return
        End If
        txtSubTotal.Text = 0
    End Sub

    Private Sub txtSalesTax_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtSalesTax.KeyPress
        Dim dotLength As Integer = 1
        dotLength = Me.txtSalesTax.Text.Split("."c).Length
        If e.KeyChar <> ControlChars.Back Then
            If dotLength > 1 Then
                e.Handled = Not (Char.IsDigit(e.KeyChar))
            Else
                e.Handled = Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = ".")
            End If
        End If
    End Sub

    Private Sub txtDiscount_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtDiscount.KeyPress
        Dim dotLength As Integer = 1
        dotLength = Me.txtDiscount.Text.Split("."c).Length
        If e.KeyChar <> ControlChars.Back Then
            If dotLength > 1 Then
                e.Handled = Not (Char.IsDigit(e.KeyChar))
            Else
                e.Handled = Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = ".")
            End If
        End If
    End Sub

    Private Sub txtRefNo_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtRefNo.KeyPress
        Dim dotLength As Integer = -1
        dotLength = Me.txtRefNo.Text.Split("."c).Length
        If e.KeyChar <> ControlChars.Back Then
            If dotLength > -1 Then
                e.Handled = Not (Char.IsDigit(e.KeyChar))
            Else
                e.Handled = Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = ".")
            End If
        End If
    End Sub

    Private Sub txtPaymentCredit_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtPaymentCredit.KeyPress
        Dim dotLength As Integer = 1
        dotLength = Me.txtPaymentCredit.Text.Split("."c).Length
        If e.KeyChar <> ControlChars.Back Then
            If dotLength > 1 Then
                e.Handled = Not (Char.IsDigit(e.KeyChar))
            Else
                e.Handled = Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = ".")
            End If
        End If
    End Sub

    Private Sub cmbCustomer_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCustomer.SelectedIndexChanged
        Try
            objCommon.FillAddressCustomer(Me.cmbAddress, Convert.ToInt32(cmbCustomer.SelectedValue))
        Catch ex As Exception
            Return
        End Try
    End Sub
End Class