Imports System.Collections.Specialized
Imports System.IO
Imports CrystalDecisions.CrystalReports.Engine


Public Class frmInvIssueNote1
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

        objCommon.FillDepartment(Me.cmbDepartment)
        'objCommon.FillDepartment(Me.cmbFVtype)
        objCommon.FillEmployee(Me.cmbEmployee)

        'objCommon.FillIssueProductBatches(Me.cmbProductBatches, Setdouble(cmbProduct.SelectedValue.ToString()))
        objCommon.FillUoM(Me.cmbUom)
        dtFDateTo.Value = Date.Today
        dtFDateFrom.Value = "01/" & Today.ToString("MM/yyyy") 'Date.Today
        Me.lblVID.Text = "0"
        btnSearch_Click(sender, e)
        Me.ActiveControl = dtpVDate
        setGrid(DataGridView1)
    End Sub

    Private Sub clearHead()
        txtRemarks.Text = String.Empty
        dtpVDate.Value = Date.Today
        cmbDepartment.SelectedValue = -1
        lblMDNID.Text = "0"
        lblOrderID.Text = "0"
        txtMDNNo.Text = ""
        txtOrderNo.Text = ""
        cmbDepartment.SelectedValue = -1
        cmbEmployee.SelectedValue = -1
        lblEmpID.Text = ""
        txtEmpCode.Text = ""
        'txtOrderNo.Text = String.Empty
        txtRefNo.Text = String.Empty
        txtFRemarks.Text = String.Empty
        txtVNo.Text = String.Empty
        lblVID.Text = "0"
        index = -1
        dtpVDate.Focus()
    End Sub

    Private Sub clearDet()
        'Me.txtVCode.Text = String.Empty
        'Me.txtVName.Text = String.Empty
        Me.lblPID.Text = ""
        Me.txtAvailableQty.Text = ""
        Me.txtProductCode.Text = ""
        Me.txtProductName.Text = ""
        Me.txtQuantity.Text = String.Empty
        Me.lblDID.Text = 0
        Me.cmbUom.SelectedValue = -1
        Me.cmbProductBatches.SelectedValue = -1
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        'true  xor false = true
        Dim qty As Double
        qty = Setdouble(Me.txtQuantity.Text)
        If Not ((qty > 0)) Then
            MessageBox.Show("Enter Valid Quantity", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtQuantity.Focus()
            Return
        Else

        End If
        If (Setdouble(txtQuantity.Text) > Setdouble(txtAvailableQty.Text)) Then
            MessageBox.Show("Issue Quantity cannot be greater than Available Quantity", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtQuantity.Focus()
            Return
        End If
        If (cmbUom.SelectedValue = -1) Then
            MessageBox.Show("Select Valid UOM", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cmbUom.Focus()
            Return
        End If
        If lblPID.Text = "" Then
            MessageBox.Show("Select Valid Product", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtProductCode.Focus()
            Return
        End If

        If index > -1 And Me.lblVID.Text.Trim <> String.Empty Then
            DataGridView1.Rows(index).Cells("VID").Value = Me.lblDID.Text
            DataGridView1.Rows(index).Cells("ProductID").Value = Me.lblPID.Text
            DataGridView1.Rows(index).Cells("BatchID").Value = Me.cmbProductBatches.SelectedValue
            DataGridView1.Rows(index).Cells("UOMID").Value = Me.cmbUom.SelectedValue
            DataGridView1.Rows(index).Cells("VCode").Value = Me.txtProductCode.Text
            DataGridView1.Rows(index).Cells("VName").Value = Me.cmbProductBatches.Text
            DataGridView1.Rows(index).Cells("ProductName").Value = Me.txtProductName.Text
            DataGridView1.Rows(index).Cells("UOM").Value = Me.cmbUom.Text
            DataGridView1.Rows(index).Cells("AvailableQty").Value = Me.txtAvailableQty.Text
            DataGridView1.Rows(index).Cells("Quantity").Value = Me.txtQuantity.Text
            DataGridView1.Rows(index).Cells("VType").Value = Me.lblVType.Text
            'DataGridView1.Rows(index).Cells(7).Value = cr
            index = -1
            Me.clearDet()
        ElseIf index = -1 And Me.lblDID.Text.Trim <> String.Empty Then

            Dim row As String() = New String() {0, Me.lblPID.Text, Me.cmbProductBatches.SelectedValue.ToString(), cmbUom.SelectedValue.ToString, Me.txtProductCode.Text, Me.txtProductName.Text, Me.cmbProductBatches.Text, cmbUom.Text.ToString, Me.txtAvailableQty.Text, Me.txtQuantity.Text, Me.lblVType.Text}
            DataGridView1.Rows.Add(row)
            Me.clearDet()
        Else
            MessageBox.Show("Select Correct Entry", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
        'Me.txtVCode.Focus()
    End Sub

    Private Sub DataGridView1_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If DataGridView1.Rows.Count > 0 Then
            index = e.RowIndex
            If e.ColumnIndex = DataGridView1.Columns("DEL").Index Then
                'Exit Sub
                DataGridView1.Rows(index).Visible = False
                DataGridView1.Rows(index).Cells("IsDel").Value = 1
                Exit Sub
            End If
            If index > -1 Then
                Me.lblDID.Text = DataGridView1.Rows(index).Cells("VID").Value
                Me.lblPID.Text = DataGridView1.Rows(index).Cells("ProductID").Value
                Me.cmbUom.SelectedValue = DataGridView1.Rows(index).Cells("UomID").Value
                Me.txtProductName.Text = DataGridView1.Rows(index).Cells("ProductName").Value
                Me.txtProductCode.Text = DataGridView1.Rows(index).Cells("VCode").Value
                Me.cmbProductBatches.Text = DataGridView1.Rows(index).Cells("VName").Value
                Me.txtAvailableQty.Text = DataGridView1.Rows(index).Cells("AvailableQty").Value
                Me.txtQuantity.Text = DataGridView1.Rows(index).Cells("Quantity").Value
                Me.lblVType.Text = DataGridView1.Rows(index).Cells("VType").Value
            End If
        End If
    End Sub

    Private Sub txtQuantity_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtQuantity.KeyPress
        Dim dotLength As Integer = 1
        dotLength = Me.txtQuantity.Text.Split(".").Length
        If e.KeyChar <> ControlChars.Back Then
            If dotLength > 1 Then
                e.Handled = Not (Char.IsDigit(e.KeyChar))
                'e.Handled = Not (Char.IsDigit(e.KeyChar))
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
            Dim Vtype As String
            Dim MID As Integer = 0
            If txtOrderNo.Text = "" Then
                Vtype = "Inv"
            Else
                Vtype = "Prod"
            End If
            qryMain = "EXEC SpSaveInvIssueMain " & lblVID.Text & ",'" & txtVNo.Text & "','" & Vtype & "'," & lblMDNID.Text & ",'" & CDate(dtpVDate.Value).ToString("dd/MMM/yyyy") & "'," & lblOrderID.Text & ",'" & txtOrderNo.Text & "','" & txtRefNo.Text & "','" & txtRemarks.Text & "'," & cmbDepartment.SelectedValue & "," & lblEmpID.Text & "," & G_Compcode & "," & G_FinancialYearID & "," & G_UID & ",'" & G_IPAddress & "'," & G_UID & ",'" & G_IPAddress & "'"
            MID = objCommon.ExecuteScalar(qryMain)
            objCommon.openConnection()
            For Each grid As DataGridViewRow In DataGridView1.Rows
                qryMain = "EXEC SpSaveInvIssueDetail " & grid.Cells("VID").Value & ", " & MID & ", '" & grid.Cells("ProductID").Value & "', " & grid.Cells("UomID").Value & ", " & grid.Cells("Quantity").Value & ",0,0," & grid.Cells("BatchID").Value & ",'" & grid.Cells("VType").Value & "', " & G_UID & ", '" & G_IPAddress & "', " & G_UID & ",'" & G_IPAddress & "', " & IIf(grid.Cells("IsDel").Value = Nothing, 0, 1)
                objCommon.ExecuteNonQueryWithOpen(qryMain)
            Next
            objCommon.CloseConnection()
            'qryMain = "EXEC SpSaveInvMdnMain " & lblVID.Text & ", '', '" & CDate(dtpVDate.Value).ToString("dd/MMM/yyyy") & "', '" & txtOrderNo.Text & "', " & cmbDepartment.SelectedValue
            'qryMain += ", '" & txtRefNo.Text & "', '" & txtRemarks.Text & "', " & G_Compcode & ", " & G_FinancialYearID & ", " & G_UID & ", '" & G_IPAddress & "', " & G_UID & ",'" & G_IPAddress & "'"
            'MID = objCommon.ExecuteScalar(qryMain)

            'For Each grid As DataGridViewRow In DataGridView1.Rows
            '   qryMain = "EXEC SpSaveInvMdnDetail " & grid.Cells("VID").Value & ", " & MID & ", '" & grid.Cells("ProductID").Value & "', '', " & grid.Cells("UomID").Value & ", " & grid.Cells("Quantity").Value & ", " & G_UID & ", '" & G_IPAddress & "', " & G_UID & ",'" & G_IPAddress & "', " & IIf(grid.Cells("IsDel").Value = Nothing, 0, 1)
            '   objCommon.ExecuteNonQuery(qryMain)
            'Next
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
        If DataGridView1.Rows.Count = 0 Then
            verify &= "Must Enter Detail.!" & vbNewLine
            'txtVCode.Focus()
            Return verify
        End If
        If lblVID.Text = "" Or lblVID.Text Is "" Then
            lblVID.Text = "0"
        End If
        If lblMDNID.Text = "" Or lblMDNID.Text Is "" Then
            lblMDNID.Text = "0"
        End If
        If lblEmpID.Text = "" Or lblEmpID.Text Is "" Then
            lblEmpID.Text = "0"
        End If
        If DataGridView1.Rows.Count = 1 And DataGridView1.Rows(0).Visible = False Then
            verify &= "Must Enter Detail.!" & vbNewLine
            'txtVCode.Focus()
        End If
        Dim Lock As String
        Lock = objCommon.ExecuteScalar("select dbo.fnAllowBackDate('Win-ERP','frmInvIssueNote1','" & CDate(dtpVDate.Value).ToString("dd/MMM/yyyy") & "'," & G_UID & "," & G_Compcode & ", " & G_FinancialYearID & ")")

        If Not (Lock = "") Then
            verify = Lock
            Return verify
        End If
        If cmbDepartment.SelectedValue = "-1" Then
            verify &= "Select Valid Department.!" & vbNewLine
            cmbDepartment.Focus()
        End If

        'If cmbEmployee.SelectedValue = "-1" Then
        '   verify &= "Select Employee First.!" & vbNewLine
        '   cmbDepartment.Focus()
        'End If

        Return verify
    End Function
    Private Sub TxtMDNNo_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles txtMDNNo.KeyDown
        If e.KeyCode = Keys.F2 And lblVID.Text = "0" Then
            frmLookup.LookupQuery = "EXEC spFetchInvMDNIssuance"
            frmLookup.LookupName = "InvFetch"
            frmLookup.VID = ""
            frmLookup.VName = ""
            frmLookup.ShowDialog()
            If frmLookup.VID <> "" Then
                lblMDNID.Text = frmLookup.VID
                txtMDNNo.Text = frmLookup.VName
                txtOrderNo.Text = frmLookup.OrderNo
                lblOrderID.Text = frmLookup.OrderID
            End If
            'frmLookupCOA.Dispose()
            cmbDepartment.Focus()
            'clearHead()
            DataGridView1.Rows.Clear()
        End If
    End Sub
    'Private Sub txtAccountCode_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '   If txtVCode.Text.Trim.Length <> 7 Then
    '      'lblMID.Text = ""
    '      'lblAccountTitle.Text = ""
    '      Return
    '   End If
    '   qryMain = " SELECT TOP 1 VID, VCode, VName FROM invProduct WHERE VCode ='" & txtVCode.Text.Trim & "' "
    'End Sub

    Private Sub grdAtt_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles grdAtt.MouseClick
        If grdAtt.Rows.Count > 0 Then
            If grdAtt.RowCount > -1 Then
                Me.TabMain.SelectedTab = TabPage1
                lblVID.Text = grdAtt.Rows(grdAtt.CurrentCell.RowIndex).Cells("VID").Value
                dt = objCommon.GetDataTable("EXEC SpGetInvIssueMainDetail " & Setdouble(lblVID.Text))
                If dt.Rows.Count > 0 Then
                    lblVID.Text = dt.Rows(0)("VID")
                    txtVNo.Text = dt.Rows(0)("VNo")
                    dtpVDate.Value = dt.Rows(0)("VDate")
                    txtMDNNo.Text = dt.Rows(0)("MDNNo")
                    lblMDNID.Text = dt.Rows(0)("MdnID")
                    txtOrderNo.Text = dt.Rows(0)("OrderNo")
                    lblOrderID.Text = dt.Rows(0)("OrderID")
                    cmbDepartment.SelectedValue = dt.Rows(0)("DepartmentID")
                    lblEmpID.Text = dt.Rows(0)("EmployeeID")
                    txtEmpCode.Text = dt.Rows(0)("EmpName")
                    txtRefNo.Text = dt.Rows(0)("RefNo")
                    txtRemarks.Text = dt.Rows(0)("Remarks")

                    DataGridView1.Rows.Clear()
                    For I As Integer = 0 To dt.Rows.Count - 1
                        Dim row As String() = New String() {dt.Rows(I)("DID"), dt.Rows(I)("ProductID"), dt.Rows(I)("StockID"), dt.Rows(I)("UomID"), dt.Rows(I)("VCode"), dt.Rows(I)("ProductName"), dt.Rows(I)("BatchName"), dt.Rows(I)("Uom"), Math.Round(Decimal.Parse(dt.Rows(I)("AvailableQty")), 2), Math.Round(Decimal.Parse(dt.Rows(I)("Qty")), 2), dt.Rows(I)("StockType")}
                        DataGridView1.Rows.Add(row)
                    Next
                End If
            End If
        End If
    End Sub

    Private Sub loadDetGrid()
        dt = objCommon.GetDataTable("EXEC SpGetbyIDPendingInvIssue " & Setdouble(lblMDNID.Text))
        Dim row As String()
        For Each rows As DataRow In dt.Rows
            row = New String() {0, rows("ProductID"), rows("UomID"), rows("VCode"), rows("ProductName"), rows("UOM"), rows("MDNQty"), rows("PendingQty"), rows("UsedQty"), 0, 0, rows("StockID"), rows("StockType"), rows("DID")}
            DataGridView1.Rows.Add(row)
        Next rows
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        Dim cWhere As String = " WHERE VDATE between ''" & Convert.ToDateTime(dtFDateFrom.Value).ToString("dd/MMM/yyyy") & "'' AND ''" & Convert.ToDateTime(dtFDateTo.Value).ToString("dd/MMM/yyyy") & "'' "
        If Not txtFVNo.Text = "" Then cWhere &= " AND VNo like ''%" & txtFVNo.Text & "%'' "
        'If Not cmbFVtype.SelectedValue = "-1" Then cWhere &= " AND VType='" & cmbFVtype.SelectedValue & "' "
        If Not txtFRemarks.Text = "" Then cWhere &= " AND Remarks like ''%" & txtFRemarks.Text & "%'' "
        qryMain = "EXEC SpGetInvSearchLookUp 'Issue', @CWhere='" & cWhere & "' "
        'qryMain = "SELECT DISTINCT [VID], [VNo], [VDate],[OrderNo],[Remarks]  FROM ViewInvIssueMainDetail " & cWhere & " ORDER BY VDATE DESC, VID "
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
        rpt = (WinReportsApplication.Classess.InventoryReport.SetReportName("rptIssueNote"))
        FilterVTypeList = ""
        FilterDate = ""
        ReportTitle = ""

        MyListDic.Add("@VID", lblVID.Text)
        ReportSpName = "SpRptInvIssueNote"
        dtrpt = objCommon.GetDataTableSPPrm(ReportSpName, MyListDic)

        'MyListDic.Add("@cWhere", " where AH.VId = " & lblVID.Text)
        MyListDic.Add("PrintType", "")
        MyListDic.Add("comp_Name", G_CompName)


        Dim MyReportViewer As ReportViewer = New ReportViewer
        MyReportViewer.dtrpt = dtrpt
        MyReportViewer.MyListDic = MyListDic
        MyReportViewer.rtp = rpt
        MyReportViewer.MdiParent = EMSMain
        MyReportViewer.Show()

    End Sub

    'Private Sub txtAccountCode_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '   txtVCode.SelectionStart = 0
    '   txtVCode.SelectionLength = txtVCode.Text.Length
    'End Sub
    'Private Sub txtNarration_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '   txtVName.SelectionStart = 0
    '   txtVName.SelectionLength = txtVName.Text.Length
    'End Sub
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

    Private Sub txtNarration_TextChanged(ByVal sender As Object, ByVal e As EventArgs)

    End Sub

    Private Sub BtnClear_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnClear.Click
        clearDet()
    End Sub

    Private Sub txtMachineCode_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dtpVDate.KeyUp,
       txtQuantity.KeyUp, txtRemarks.KeyUp, txtRefNo.KeyUp, txtVNo.KeyUp, cmbDepartment.KeyUp
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If 'ijaz
    End Sub 'Pending



    Private Sub txtProductCode_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblPID.TextChanged
        objCommon.FillIssueProductBatches(Me.cmbProductBatches, Setdouble(lblPID.Text))
    End Sub


    Private Sub txtProductCode_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtProductCode.KeyDown
        If e.KeyCode = Keys.F2 Then
            frmLookup.LookupQuery = "EXEC SpGetby_ProductbyMDN '" & lblMDNID.Text & "'"
            frmLookup.LookupName = "Product"
            frmLookup.VID = ""
            frmLookup.VCode = ""
            frmLookup.VName = ""
            frmLookup.ShowDialog()
            If frmLookup.VID <> "" Then
                lblPID.Text = frmLookup.VID
                txtProductCode.Text = frmLookup.VCode
                txtProductName.Text = frmLookup.VName
            End If
            'cmbUom.SelectedValue = frmLookup.UOMID
            'frmLookupCOA.Dispose()
            cmbProductBatches.Focus()
        End If
    End Sub

    Private Sub txtMDNNo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtMDNNo.TextChanged
        clearDet()
        DataGridView1.Rows.Clear()
    End Sub

    Private Sub cmbProductBatches_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbProductBatches.SelectedIndexChanged
        Dim Batch = cmbProductBatches.Text.Split(":")
        If Batch.Length > 1 Then
            txtAvailableQty.Text = Batch(3)
            lblVType.Text = Batch(1)
        End If
    End Sub

    Private Sub txtEmpCode_KeyDown(sender As Object, e As KeyEventArgs) Handles txtEmpCode.KeyDown
        If e.KeyCode = Keys.F2 Then
            frmLookup.LookupQuery = "EXEC SpGet_EMSEmployee "
            frmLookup.LookupName = "Employee"
            frmLookup.VID = ""
            frmLookup.VCode = ""
            frmLookup.VName = ""
            frmLookup.ShowDialog()
            If frmLookup.VID <> "" Then
                lblEmpID.Text = frmLookup.VID
                txtEmpCode.Text = frmLookup.VCode + "--" + frmLookup.VName
            End If
            'cmbUom.SelectedValue = frmLookup.UOMID
            'frmLookupCOA.Dispose()
            cmbProductBatches.Focus()
        End If
    End Sub
End Class