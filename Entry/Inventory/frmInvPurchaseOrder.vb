Imports System.Collections.Specialized
Imports System.IO
Imports CrystalDecisions.CrystalReports.Engine

Public Class frmInvPurchaseOrder
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
    Dim FilterDate As String = ""
    Dim FilterAccCode As String = ""
    Dim ReportSpName As String = ""
    Dim dtrpt As DataTable

    Private Sub frmGL_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        G_CURRENTDATE = Date.Now
        If G_CURRENTDATE > G_SOFTENDDATE Then
            End
        End If

        clearHead()
        objCommon.FillPOType(Me.cmbPoType)
        'objCommon.FillPOType(Me.cmbFVtype)
        objCommon.FillDepartment(Me.cmbDepartment)
        objCommon.FillPaymentTerm(Me.cmbPaymentTerm)
        dtFDateTo.Value = Date.Today
        dtFDateFrom.Value = "01/" & Today.ToString("MM/yyyy")
        btnSearch_Click(sender, e)
        Me.ActiveControl = dtpVDate
    End Sub

    Private Sub clearHead()
        For Each ctl In SplitContainer2.Panel1.Controls
            If TypeOf ctl Is TextBox Then ctl.Text = ""
        Next ctl
        txtRemarks.Text = String.Empty
        dtpVDate.Value = Date.Today
        cmbPoType.SelectedValue = -1
        txtOrderNo.Text = String.Empty
        txtFRemarks.Text = String.Empty
        txtVNo.Text = String.Empty
        lblVID.Text = "0"
        lblOrderID.Text = "0"
        index = -1
        cmbPaymentTerm.SelectedValue = -1
        dtpDeliveryDate.ResetText()
        lblSupplierID.Text = "0"
        lblMDNID.Text = "0"
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
            qryMain = "EXEC SpSaveInvPOMain " & lblVID.Text & ", '', '" & cmbPoType.SelectedValue & "', " & lblMDNID.Text & ", '" & CDate(dtpVDate.Value).ToString("dd/MMM/yyyy") & "',0,0,1,0, '" & CDate(dtpDeliveryDate.Value).ToString("dd/MMM/yyyy") & "', " & lblSupplierID.Text & ", " & cmbPaymentTerm.SelectedValue & "," & lblOrderID.Text & "," & cmbDepartment.SelectedValue & ", '" & txtOrderNo.Text & "',0, " & Setdouble(txtFreight.Text) & ", '" & txtPacking.Text & "','" & txtDeliveryTerm.Text & "','" & txtSpecification.Text & "', '" & Setdouble(txtMiscAmount.Text) & "', '" & Setint(txtDueDays.Text) & "','', '" & txtRemarks.Text
            qryMain += "', " & G_Compcode & ", " & G_FinancialYearID & ", " & G_UID & ", '" & G_IPAddress & "', " & G_UID & ",'" & G_IPAddress & "'"
            MID = objCommon.ExecuteScalar(qryMain)
            objCommon.openConnection()
            For Each grid As DataGridViewRow In grdRecord.Rows
                If Setdouble(grid.Cells("Quantity").Value) > 0 Then
                    qryMain = "EXEC SpSaveInvPODetail " & grid.Cells("VID").Value & ", " & MID & ", '" & grid.Cells("ProductID").Value & "', " & grid.Cells("UomID").Value & ", " & grid.Cells("Quantity").Value & ", " & grid.Cells("VRate").Value & ",  " & grid.Cells("SaleTaxPer").Value & ",  " & grid.Cells("VTypePK").Value & ", " & G_UID & ", '" & G_IPAddress & "', " & G_UID & ",'" & G_IPAddress & "', " & IIf(grid.Cells("IsDel").Value = Nothing, 0, 1)
                    objCommon.ExecuteNonQueryWithOpen(qryMain)
                End If
            Next
            objCommon.CloseConnection()
            MessageBox.Show("Voucher Successfully Saved", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            lblVID.Text = MID
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

    End Sub
    Private Function verifySave() As String
        Dim verify As String = ""
        If grdRecord.Rows.Count = 0 Then
            verify &= "Must Enter Detail.!" & vbNewLine
            'txtVCode.Focus()
            Return verify
        End If
        If lblVID.Text = "" Or lblVID.Text Is "" Then
            lblVID.Text = "0"
        End If
        If grdRecord.Rows.Count = 1 And grdRecord.Rows(0).Visible = False Then
            verify &= "Must Enter Detail.!" & vbNewLine
            'txtVCode.Focus()
        End If
        For Each grid As DataGridViewRow In grdRecord.Rows
            If Not Setdouble(grid.Cells("Quantity").Value) > 0 And grid.Cells("Quantity").Visible = True Then
                verify &= "Please Add Some Qunatity.!" & vbNewLine
            End If
        Next
        Dim Lock As String
        Lock = objCommon.ExecuteScalar("select dbo.fnAllowBackDate('Win-ERP','frmInvPurchaseOrder','" & CDate(dtpVDate.Value).ToString("dd/MMM/yyyy") & "'," & G_UID & "," & G_Compcode & ", " & G_FinancialYearID & ")")

        If Not (Lock = "") Then
            verify = Lock
            Return verify
        End If
        For Each grid As DataGridViewRow In grdRecord.Rows
            If Not Setdouble(grid.Cells("VRate").Value) > 0 And grid.Cells("VRate").Visible = True Then
                verify &= "Please give Some Rate.!" & vbNewLine
            End If
        Next
        For Each grid As DataGridViewRow In grdRecord.Rows
            If Not Setdouble(grid.Cells("SaleTaxPer").Value) >= 0 And grid.Cells("SaleTaxPer").Visible = True Then
                verify &= "Please Add Some Sale Tax Percentage.!" & vbNewLine
            End If
        Next

        If cmbPoType.SelectedValue = "-1" Then
            verify &= "Select Valid Po Type.!" & vbNewLine
            cmbPoType.Focus()
        End If

        If cmbPaymentTerm.SelectedValue = "-1" Then
            verify &= "Select Valid Payment Term.!" & vbNewLine
            cmbPaymentTerm.Focus()
        End If

        If lblSupplierID.Text = "0" Then
            verify &= "Select Valid Supplier.!" & vbNewLine
            txtSupplier.Focus()
        End If

        If lblMDNID.Text = "0" Then
            verify &= "Select Valid MDN.!" & vbNewLine
            txtMDNNo.Focus()
        End If
        Return verify
    End Function
    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        Dim cWhere As String = " WHERE VDATE between ''" & Convert.ToDateTime(dtFDateFrom.Value).ToString("dd/MMM/yyyy") & "'' AND ''" & Convert.ToDateTime(dtFDateTo.Value).ToString("dd/MMM/yyyy") & "''"
        If Not txtFVNo.Text = "" Then cWhere &= " AND VNo like ''%" & txtFVNo.Text & "%'' "
        'If Not cmbFVtype.SelectedValue = "-1" Then cWhere &= " AND VType='" & cmbFVtype.SelectedValue & "' "
        If Not txtFRemarks.Text = "" Then cWhere &= " AND Remarks like ''%" & txtFRemarks.Text & "%'' "
        qryMain = "EXEC SpGetInvSearchLookUp 'PO', @CWhere='" & cWhere & "' "
        'qryMain = " SELECT DISTINCT VID, VNO, VDATE,OrderNo,Remarks, VName,Qty FROM ViewInvPOMainDetail " & cWhere & " ORDER BY VDATE DESC, VID "
        grdAtt.DataSource = objCommon.GetDataTable(qryMain)
        If grdAtt.Rows.Count > 0 Then setGrid(grdAtt)
        If grdAtt.Rows.Count > 0 Then grdAtt.Columns(0).Visible = False
    End Sub

    Private Sub cmdNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNew.Click
        clearHead()
        grdRecord.Rows.Clear()
    End Sub

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub

    Private Sub cmdPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrint.Click   ''pending
        MyListDic.Clear()
        rpt = (WinReportsApplication.Classess.InventoryReport.SetReportName("porpt1"))
        FilterVTypeList = ""
        FilterDate = ""
        ReportTitle = ""

        MyListDic.Add("@VID", lblVID.Text)
        ReportSpName = "SpRptinvPOMainDetail"
        dtrpt = objCommon.GetDataTableSPPrm(ReportSpName, MyListDic)

        MyListDic.Add("cCompanyName", G_CompName)
        'MyListDic.Add("cRevised", "123")

        'MyListDic.Add("@cWhere", " where AH.VId = " & lblVID.Text)

        Dim MyReportViewer As ReportViewer = New ReportViewer
        MyReportViewer.dtrpt = dtrpt
        MyReportViewer.MyListDic = MyListDic
        MyReportViewer.rtp = rpt
        MyReportViewer.MdiParent = EMSMain
        MyReportViewer.Show()

    End Sub

    Private Sub cmdDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDelete.Click
        'qryMain = " delete from tblAcJVDet where MId = " & lblVID.Text & " ; delete from tblAcJVHead where VId = " & lblVID.Text & " ; "
        'objCommon.ExecuteNonQuery(qryMain)
        'MessageBox.Show("Voucher removed Successfully ", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        'clearHead()
        'DataGridView1.Rows.Clear()
        'btnSearch_Click(sender, e)
        'txtVNo.Focus()
    End Sub

    Private Sub TxtMDNNo_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles txtMDNNo.KeyDown
        If e.KeyCode = Keys.F2 And lblVID.Text = "0" Then
            frmLookup.LookupQuery = "SELECT VID, VDate, VNo, OrderNo, OrderID, ProductName,DepartmentID FROM ViewInvMdnMainDetail WHERE (Qty - UsedQty) > 0 order by VDate desc"
            frmLookup.LookupName = "InvFetch"
            frmLookup.VID = ""
            frmLookup.VCode = ""
            frmLookup.VName = ""
            frmLookup.ShowDialog()
            If frmLookup.VID <> "" Then
                lblMDNID.Text = frmLookup.VID
                txtMDNNo.Text = frmLookup.VName
                txtOrderNo.Text = frmLookup.OrderNo
                lblOrderID.Text = frmLookup.OrderID
                cmbDepartment.SelectedValue = frmLookup.DepartmentID
            End If
            'frmLookupCOA.Dispose()
            dtpDeliveryDate.Focus()
            loadDetGrid()
        End If
    End Sub

    Private Sub loadDetGrid()
        grdRecord.Rows.Clear()
        dt = objCommon.GetDataTable("SELECT 0 VID, ProductID, UomID, VCode, ProductName,  UOM, Qty MDNQty, Qty - UsedQty PendingQty, 0 POQty, 0 Rate, 0 Amount, UsedQty, issueQty, DID  FROM ViewInvMdnMainDetail WHERE (Qty - UsedQty) >0 AND VID = " & Setdouble(lblMDNID.Text))
        Dim row As String()
        For Each rows As DataRow In dt.Rows
            row = New String() {0, rows("ProductID"), rows("UomID"), rows("VCode"), rows("ProductName"), rows("UOM"), rows("MDNQty"), rows("PendingQty"), rows("POQty"), rows("Rate"), rows("Amount"), 0, 0, rows("DID")}
            grdRecord.Rows.Add(row)
        Next rows
    End Sub

    Private Sub TxtSupplier_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles txtSupplier.KeyDown
        If e.KeyCode = Keys.F2 Then
            frmLookup.LookupQuery = "SELECT VID, VCode, VName FROM invSupplier"
            frmLookup.LookupName = "Supplier"
            frmLookup.VID = ""
            frmLookup.VCode = ""
            frmLookup.VName = ""
            frmLookup.ShowDialog()
            If frmLookup.VID <> "" Then
                lblSupplierID.Text = frmLookup.VID
                txtSupplier.Text = frmLookup.VCode & "-" & frmLookup.VName
            End If
            'frmLookupCOA.Dispose()
            cmbPoType.Focus()
        End If
    End Sub

    Private Sub DataGridView1_EditingControlShowing(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles grdRecord.EditingControlShowing
        If grdRecord.CurrentCell.ColumnIndex = grdRecord.Columns("Quantity").Index Then
            AddHandler CType(e.Control, TextBox).KeyPress, AddressOf TextBox_keyPress
        ElseIf grdRecord.CurrentCell.ColumnIndex = 1 Then
            AddHandler CType(e.Control, TextBox).KeyPress, AddressOf TextBox_keyPress1
        End If
        If grdRecord.CurrentCell.ColumnIndex = grdRecord.Columns("VRate").Index Then
            AddHandler CType(e.Control, TextBox).KeyPress, AddressOf TextBox_keyPress1
        ElseIf grdRecord.CurrentCell.ColumnIndex = 1 Then
            AddHandler CType(e.Control, TextBox).KeyPress, AddressOf TextBox_keyPress1
        End If
    End Sub
    Private Sub TextBox_keyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs)
        If e.KeyChar <> ControlChars.Back Then If Not (Char.IsDigit(CChar(CStr(e.KeyChar))) Or e.KeyChar = ".") Then e.Handled = True
        'If e.KeyChar <> ControlChars.Back Then If Char.IsDigit(CChar(CStr(e.KeyChar))) = False Then e.Handled = True
    End Sub

    Private Sub TextBox_keyPress1(ByVal sender As Object, ByVal e As KeyPressEventArgs)
        If e.KeyChar <> ControlChars.Back Then If Not (Char.IsDigit(CChar(CStr(e.KeyChar))) Or e.KeyChar = ".") Then e.Handled = True
    End Sub


    Private Sub GrdAtt_MouseClick(ByVal sender As Object, ByVal e As MouseEventArgs) Handles grdAtt.MouseClick
        If grdAtt.Rows.Count > 0 Then
            If grdAtt.RowCount > -1 Then
                Me.TabMain.SelectedTab = TabPage1
                lblVID.Text = grdAtt.Rows(grdAtt.CurrentCell.RowIndex).Cells("VID").Value
                dt = objCommon.GetDataTable("EXEC SpGetInvPOMainDetail " & Setdouble(lblVID.Text))
                If dt.Rows.Count > 0 Then
                    lblVID.Text = dt.Rows(0)("VID")
                    txtVNo.Text = dt.Rows(0)("VNo")
                    dtpVDate.Value = dt.Rows(0)("VDate")
                    lblSupplierID.Text = dt.Rows(0)("SupplierID")
                    txtSupplier.Text = dt.Rows(0)("VName")
                    cmbPoType.SelectedValue = dt.Rows(0)("POType")
                    txtMDNNo.Text = dt.Rows(0)("MDNNo")
                    lblMDNID.Text = dt.Rows(0)("MdnID")
                    dtpDeliveryDate.Value = dt.Rows(0)("DeliveryDate")
                    txtDueDays.Text = dt.Rows(0)("DueDays")
                    cmbPaymentTerm.SelectedValue = dt.Rows(0)("PaymentTermID")
                    txtFreight.Text = Math.Round(Decimal.Parse(dt.Rows(0)("FreightAmount")), 2).ToString()
                    txtSpecification.Text = dt.Rows(0)("Specifications")
                    txtPacking.Text = dt.Rows(0)("PackingInstructions")
                    txtDeliveryTerm.Text = dt.Rows(0)("DeliveryTerms")
                    txtMiscAmount.Text = Math.Round(Decimal.Parse(dt.Rows(0)("MiscAmount")), 2).ToString()
                    txtOrderNo.Text = dt.Rows(0)("OrderNo")
                    lblOrderID.Text = dt.Rows(0)("OrderID")
                    txtRemarks.Text = dt.Rows(0)("Remarks")
                    cmbDepartment.SelectedValue = dt.Rows(0)("DepartmentID")
                    grdRecord.Rows.Clear()
                    For I As Integer = 0 To dt.Rows.Count - 1
                        Dim row As String() = New String() {dt.Rows(I)("DID"), dt.Rows(I)("ProductID"), dt.Rows(I)("UomID"), dt.Rows(I)("VCode"), dt.Rows(I)("ProductName"), dt.Rows(I)("UOM"), dt.Rows(I)("MDNQty"), dt.Rows(I)("PendingQty"), dt.Rows(I)("Qty"), Math.Round(Decimal.Parse(dt.Rows(I)("VRate")), 2).ToString(), Math.Round(Decimal.Parse(dt.Rows(I)("DAmount")), 2).ToString(), Math.Round(Decimal.Parse(dt.Rows(I)("STaxPer")), 2).ToString(), Math.Round(Decimal.Parse(dt.Rows(I)("STaxValue")), 2).ToString(), dt.Rows(I)("VtypePk")}
                        grdRecord.Rows.Add(row)
                    Next
                End If
            End If
        End If
    End Sub

    Private Sub DataGridView1_CellClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles grdRecord.CellClick
        If grdRecord.Rows.Count > 0 Then
            index = e.RowIndex
            If e.ColumnIndex = grdRecord.Columns("DEL").Index Then
                'Exit Sub
                grdRecord.Rows(index).Visible = False
                grdRecord.Rows(index).Cells("IsDel").Value = 1
                Exit Sub
            End If
        End If
    End Sub

    Private Sub txtDueDays_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtDueDays.KeyPress
        Dim dotLength As Integer = -1
        dotLength = Me.txtDueDays.Text.Split(".").Length
        If e.KeyChar <> ControlChars.Back Then
            If dotLength > -1 Then
                e.Handled = Not (Char.IsDigit(e.KeyChar))
            Else
                e.Handled = Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = ".")
            End If
        End If

    End Sub

    Private Sub txtFreight_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtFreight.KeyPress
        Dim dotLength As Integer = 1
        dotLength = Me.txtFreight.Text.Split(".").Length
        If e.KeyChar <> ControlChars.Back Then
            If dotLength > 1 Then
                e.Handled = Not (Char.IsDigit(e.KeyChar))
            Else
                e.Handled = Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = ".")
            End If
        End If

    End Sub


    Private Sub txtMachineCode_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dtpVDate.KeyUp,
     txtOrderNo.KeyUp, txtDeliveryTerm.KeyUp, txtRemarks.KeyUp, txtDueDays.KeyUp, txtFreight.KeyUp, txtMDNNo.KeyUp, txtMiscAmount.KeyUp, txtPacking.KeyUp, txtSpecification.KeyUp, txtVNo.KeyUp
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If 'ijaz
    End Sub 'Pending

    Private Sub btnExcelExport_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnExcelExport.Click
        objCommon.ExportToExcel(grdAtt)
    End Sub


    Private Sub grdRecord_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles grdRecord.CellValueChanged
        Dim EQty, VRate, PendingQty, SaleTaxPer As Double
        If grdRecord.Rows.Count > 0 Then
            If e.ColumnIndex = grdRecord.Columns("Quantity").Index Then
                EQty = Setdouble(grdRecord.Rows(e.RowIndex).Cells(e.ColumnIndex).Value)
                VRate = Setdouble(grdRecord.Rows(e.RowIndex).Cells(e.ColumnIndex + 1).Value)
                SaleTaxPer = Setdouble(grdRecord.Rows(e.RowIndex).Cells("SaleTaxPer").Value)
                PendingQty = Setdouble(grdRecord.Rows(e.RowIndex).Cells("PendingQty").Value)
                If EQty > PendingQty And lblVID.Text = "0" Then
                    MessageBox.Show("PO Qty cannot be greater than Pending Qty.!", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                    grdRecord.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = PendingQty
                    EQty = PendingQty
                End If
                grdRecord.Rows(e.RowIndex).Cells("Amount").Value = EQty * VRate
                grdRecord.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = EQty
                grdRecord.Rows(e.RowIndex).Cells(e.ColumnIndex + 1).Value = VRate
                grdRecord.Rows(e.RowIndex).Cells("SaleTaxValue").Value = (Setdouble(grdRecord.Rows(e.RowIndex).Cells("Amount").Value) * SaleTaxPer) / 100
            ElseIf e.ColumnIndex = grdRecord.Columns("VRate").Index Then
                EQty = Setdouble(grdRecord.Rows(e.RowIndex).Cells(e.ColumnIndex - 1).Value)
                VRate = Setdouble(grdRecord.Rows(e.RowIndex).Cells(e.ColumnIndex).Value)
                SaleTaxPer = Setdouble(grdRecord.Rows(e.RowIndex).Cells("SaleTaxPer").Value)
                PendingQty = Setdouble(grdRecord.Rows(e.RowIndex).Cells("PendingQty").Value)
                If EQty > PendingQty And lblVID.Text = "0" Then
                    MessageBox.Show("PO Qty cannot be greater than Pending Qty.!", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                    grdRecord.Rows(e.RowIndex).Cells(e.ColumnIndex - 1).Value = PendingQty
                    EQty = PendingQty
                End If
                grdRecord.Rows(e.RowIndex).Cells("Amount").Value = EQty * VRate
                grdRecord.Rows(e.RowIndex).Cells(e.ColumnIndex - 1).Value = EQty
                grdRecord.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = VRate
                grdRecord.Rows(e.RowIndex).Cells("SaleTaxValue").Value = (Setdouble(grdRecord.Rows(e.RowIndex).Cells("Amount").Value) * SaleTaxPer) / 100
            ElseIf e.ColumnIndex = grdRecord.Columns("SaleTaxPer").Index Then
                SaleTaxPer = Setdouble(grdRecord.Rows(e.RowIndex).Cells("SaleTaxPer").Value)
                grdRecord.Rows(e.RowIndex).Cells("SaleTaxValue").Value = (Setdouble(grdRecord.Rows(e.RowIndex).Cells("Amount").Value) * SaleTaxPer) / 100
            End If
        End If
    End Sub
End Class