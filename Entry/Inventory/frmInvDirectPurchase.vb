﻿Imports System.Collections.Specialized
Imports System.IO
Imports CrystalDecisions.CrystalReports.Engine


Public Class frmInvDirectPurchase
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
        objCommon.FillAccMainHead(Me.cmbTaxGLCode, "Tax")

        'objCommon.FillAccMainHead(Me.cmbAccountHead, "GRNB")
        'objCommon.FillDepartment(Me.cmbFVtype)
        objCommon.FillUoM(Me.cmbUom)
        dtFDateTo.Value = Date.Today
        dtFDateFrom.Value = "01/" & Today.ToString("MM/yyyy") 'Date.Today
        Me.lblVID.Text = "0"
        btnSearch_Click(sender, e)
        Me.ActiveControl = dtpVDate
    End Sub

    Private Sub clearHead()
        txtNarration.Text = String.Empty
        dtpVDate.Value = Date.Today
        'cmbAccountHead.SelectedValue = -1
        lblAccountTitle.TabIndex = 0
        lblAcctID.TabIndex = 0
        'txtAccountHead.Text = ""
        '  txtOrderNo.Text = String.Empty
        txtInstrumentNo.Text = String.Empty
        txtFRemarks.Text = String.Empty
        txtVNo.Text = String.Empty
        lblVID.Text = "0"
        txtSupplier.Text = String.Empty
        lblSupplierID.Text = "0"
        cmbTaxGLCode.Text = String.Empty
        txtRemarks.Text = String.Empty

        index = -1
        dtpVDate.Focus()
    End Sub
    Private Sub clearDet()
        Me.txtVCode.Text = String.Empty
        Me.txtVName.Text = String.Empty
        Me.txtQuantity.Text = String.Empty
        Me.txtVRate.Text = String.Empty
        Me.txtAmount.Text = String.Empty
        Me.lblDID.Text = 0
        Me.cmbUom.SelectedValue = -1
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

        If (cmbUom.SelectedValue = -1) Then
            MessageBox.Show("Select Valid UOM", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtQuantity.Focus()
            Return
        End If
        If lblPID.Text = "" Then
            MessageBox.Show("Select Valid Product", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtQuantity.Focus()
            Return
        End If

        If index > -1 And Me.lblVID.Text.Trim <> String.Empty Then
            DataGridView1.Rows(index).Cells("VID").Value = Me.lblDID.Text
            DataGridView1.Rows(index).Cells("ProductID").Value = Me.lblPID.Text
            DataGridView1.Rows(index).Cells("UomID").Value = Me.cmbUom.SelectedValue
            DataGridView1.Rows(index).Cells("VCode").Value = Me.txtVCode.Text
            DataGridView1.Rows(index).Cells("VName").Value = Me.txtVName.Text
            DataGridView1.Rows(index).Cells("UOM").Value = Me.cmbUom.Text
            DataGridView1.Rows(index).Cells("Quantity").Value = Me.txtQuantity.Text
            DataGridView1.Rows(index).Cells("VRate").Value = Me.txtVRate.Text
            DataGridView1.Rows(index).Cells("Amount").Value = Me.txtAmount.Text
            'DataGridView1.Rows(index).Cells(7).Value = cr
            index = -1
            Me.clearDet()
        ElseIf index = -1 And Me.lblDID.Text.Trim <> String.Empty Then

            Dim row As String() = New String() {0, lblPID.Text, cmbUom.SelectedValue, Me.txtVCode.Text, Me.txtVName.Text, Me.cmbUom.Text, Me.txtQuantity.Text, Me.txtVRate.Text, Me.txtAmount.Text}
            DataGridView1.Rows.Add(row)
            Me.clearDet()
        Else
            MessageBox.Show("Select Correct Entry", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
        Me.txtVCode.Focus()
    End Sub

    Private Sub DataGridView1_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If DataGridView1.Rows.Count > 0 Then
            index = e.RowIndex
            If e.ColumnIndex = DataGridView1.Columns("DEL").Index Then
                'Exit Sub
                DataGridView1.Rows(index).Visible = False
                DataGridView1.Rows(index).Cells("IsDel").Value = 1
                index = -1
                Exit Sub
            End If
            If index > -1 Then
                Me.lblDID.Text = DataGridView1.Rows(index).Cells("VID").Value
                Me.lblPID.Text = DataGridView1.Rows(index).Cells("ProductID").Value
                Me.cmbUom.SelectedValue = DataGridView1.Rows(index).Cells("UomID").Value
                Me.txtVCode.Text = DataGridView1.Rows(index).Cells("VCode").Value
                Me.txtVName.Text = DataGridView1.Rows(index).Cells("VName").Value
                Me.txtQuantity.Text = DataGridView1.Rows(index).Cells("Quantity").Value
                Me.txtVRate.Text = DataGridView1.Rows(index).Cells("VRate").Value
                Me.txtAmount.Text = DataGridView1.Rows(index).Cells("Amount").Value
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
            If txtInstrumentNo.Text = "" Then
                txtInstrumentNo.Text = 0
            End If

            Dim MID As Integer = 0
            qryMain = "EXEC SpSaveInvGRNBMain " & lblVID.Text & ", ''," & txtInstrumentNo.Text & ", " & cmbTaxGLCode.SelectedValue & ",0,0, '" & CDate(dtpVDate.Value).ToString("dd/MMM/yyyy") & "',''," & lblSupplierID.Text & ""
            qryMain += ",0,'',  '" & txtRemarks.Text & "',  '" & txtNarration.Text & "', " & G_Compcode & ", " & G_FinancialYearID & ", " & G_UID & ", '" & G_IPAddress & "', " & G_UID & ",'" & G_IPAddress & "'"
            MID = objCommon.ExecuteScalar(qryMain)
            objCommon.openConnection()
            For Each grid As DataGridViewRow In DataGridView1.Rows
                qryMain = "EXEC SpSaveInvGRNBDetail " & grid.Cells("VID").Value & ", " & MID & ", " & grid.Cells("ProductID").Value & ", '" & grid.Cells("VName").Value & "', " & grid.Cells("UomID").Value & ", " & grid.Cells("Quantity").Value & ",'', " & grid.Cells("VRate").Value & ", " & grid.Cells("VID").Value & ", " & G_UID & ", '" & G_IPAddress & "', " & G_UID & ",'" & G_IPAddress & "', " & IIf(grid.Cells("IsDel").Value = Nothing, 0, 1)
                objCommon.ExecuteNonQueryWithOpen(qryMain)
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
        If DataGridView1.Rows.Count = 0 Then
            verify &= "Must Enter Detail.!" & vbNewLine
            txtVCode.Focus()
            Return verify
        End If

        If DataGridView1.Rows.Count = 1 And DataGridView1.Rows(0).Visible = False Then
            verify &= "Must Enter Detail.!" & vbNewLine
            'txtVCode.Focus()
        End If

        Dim Lock As String
        Lock = objCommon.ExecuteScalar("select dbo.fnAllowBackDate('Win-ERP','frmInvDirectPurchase','" & CDate(dtpVDate.Value).ToString("dd/MMM/yyyy") & "'," & G_UID & "," & G_Compcode & ", " & G_FinancialYearID & ")")

        If Not (Lock = "") Then
            verify = Lock
            Return verify
        End If

        '  If txtAccountHead.Text = "" Then
        '   verify &= "Select Valid Account.!" & vbNewLine
        '   txtAccountHead.Focus()
        'End If

        Return verify
    End Function
    Private Sub txtProductCode_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtVCode.KeyDown
        If e.KeyCode = Keys.F2 Then
            frmLookup.LookupQuery = "SELECT VID, VCode, VName,UOMID FROM invProduct"
            frmLookup.LookupName = "ProductGRN"
            frmLookup.VID = ""
            frmLookup.VCode = ""
            frmLookup.VName = ""
            frmLookup.ShowDialog()
            If frmLookup.VID <> "" Then
                lblPID.Text = frmLookup.VID
                txtVCode.Text = frmLookup.VCode
                txtVName.Text = frmLookup.VName
                cmbUom.SelectedValue = frmLookup.UOMID
            End If
            frmLookupCOA.Dispose()
            cmbUom.Focus()
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
                lblVID.Text = grdAtt.Rows(grdAtt.CurrentCell.RowIndex).Cells("VID").Value
                dt = objCommon.GetDataTable("EXEC SpGetbyIDInvGRNBMainDetail " & Setdouble(lblVID.Text))
                If dt.Rows.Count > 0 Then
                    lblVID.Text = dt.Rows(0)("VID")
                    txtVNo.Text = dt.Rows(0)("VNo")
                    dtpVDate.Value = dt.Rows(0)("VDate")
                    'txtOrderNo.Text = dt.Rows(0)("OrderNo")
                    'lblAcctID.Text = dt.Rows(0)("AccountID")
                    'txtAccountHead.Text = dt.Rows(0)("AccountName")
                    txtInstrumentNo.Text = dt.Rows(0)("InstrumentNo")
                    txtNarration.Text = dt.Rows(0)("Narration")
                    txtRemarks.Text = dt.Rows(0)("Remarks")
                    lblSupplierID.Text = dt.Rows(0)("SupplierID")
                    txtSupplier.Text = dt.Rows(0)("SupplierCode") & " - " & dt.Rows(0)("SupplierName")
                    cmbTaxGLCode.SelectedValue = dt.Rows(0)("GLTaxCodeID")
                    DataGridView1.Rows.Clear()
                    For I As Integer = 0 To dt.Rows.Count - 1
                        Dim row As String() = New String() {dt.Rows(I)("DID"), dt.Rows(I)("ProductID"), dt.Rows(I)("UomID"), dt.Rows(I)("VCode"), dt.Rows(I)("ProductName"), dt.Rows(I)("UOM"), Math.Round(Decimal.Parse(dt.Rows(I)("Qty")), 2), Math.Round(Decimal.Parse(dt.Rows(I)("VRate")), 2), Math.Round(Decimal.Parse(dt.Rows(I)("Qty") * dt.Rows(I)("VRate")), 2)}
                        DataGridView1.Rows.Add(row)
                    Next
                End If
            End If
        End If
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        Dim cWhere As String = " WHERE VDATE between ''" & Convert.ToDateTime(dtFDateFrom.Value).ToString("dd/MMM/yyyy") & "'' AND ''" & Convert.ToDateTime(dtFDateTo.Value).ToString("dd/MMM/yyyy") & "''"
        If Not txtFVNo.Text = "" Then cWhere &= " AND VNo like ''%" & txtFVNo.Text & "%'' "
        'If Not cmbFVtype.SelectedValue = "-1" Then cWhere &= " AND VType=''GRNB'' "
        If Not txtFRemarks.Text = "" Then cWhere &= " AND Remarks like ''%" & txtFRemarks.Text & "%'' "
        qryMain = "EXEC SpGetInvSearchLookUp 'GRNB', @CWhere='" & cWhere & "' "
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
        rpt = (WinReportsApplication.Classess.InventoryReport.SetReportName("rfDirectPurchase"))
        FilterVTypeList = ""
        FilterDate = ""
        ReportTitle = ""

        MyListDic.Add("@VID", lblVID.Text)
        ReportSpName = "SpRptInvGRNBMain"
        dtrpt = objCommon.GetDataTableSPPrm(ReportSpName, MyListDic)

        MyListDic.Add("comp_Name", G_CompName)
        MyListDic.Add("off_Name", "")
        'MyListDic.Add("@cWhere", " where AH.VId = " & lblVID.Text)


        Dim MyReportViewer As ReportViewer = New ReportViewer
        MyReportViewer.dtrpt = dtrpt
        MyReportViewer.MyListDic = MyListDic
        MyReportViewer.rtp = rpt
        MyReportViewer.MdiParent = EMSMain
        MyReportViewer.Show()

    End Sub

    Private Sub txtAccountCode_Enter(sender As System.Object, e As System.EventArgs) Handles txtVCode.Enter
        txtVCode.SelectionStart = 0
        txtVCode.SelectionLength = txtVCode.Text.Length
    End Sub
    Private Sub txtNarration_Enter(sender As System.Object, e As System.EventArgs) Handles txtVName.Enter
        txtVName.SelectionStart = 0
        txtVName.SelectionLength = txtVName.Text.Length
    End Sub
    Private Sub txtDebit_Enter(sender As System.Object, e As System.EventArgs) Handles txtQuantity.Enter
        txtQuantity.SelectionStart = 0
        txtQuantity.SelectionLength = txtQuantity.Text.Length
    End Sub
    Private Sub txtCredit_Enter(sender As System.Object, e As System.EventArgs)
        'txtCredit.SelectionStart = 0
        'txtCredit.SelectionLength = txtCredit.Text.Length
    End Sub

    Private Sub cmdDelete_Click(sender As System.Object, e As System.EventArgs) Handles cmdDelete.Click
        'qryMain = " delete from tblAcJVDet where MId = " & lblVID.Text & " ; delete from tblAcJVHead where VId = " & lblVID.Text & " ; "
        'objCommon.ExecuteNonQuery(qryMain)
        'MessageBox.Show("Voucher removed Successfully ", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        'clearHead()
        'clearDet()
        'DataGridView1.Rows.Clear()
        'btnSearch_Click(sender, e)
        'txtVNo.Focus()
    End Sub

    Private Sub txtNarration_TextChanged(sender As Object, e As EventArgs) Handles txtVName.TextChanged

    End Sub

    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        clearDet()
    End Sub

    Private Sub txtVRate_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtVRate.KeyPress
        Dim dotLength As Integer = 1
        dotLength = Me.txtVRate.Text.Split(".").Length
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

    Private Sub txtVRate_Leave(ByVal sender As Object, ByVal e As EventArgs) Handles txtVRate.Leave
        If Me.txtVRate.Text = "" Then
            Me.txtVRate.Text = 0
        End If
        If Me.txtQuantity.Text = "" Then
            Me.txtQuantity.Text = 0
        End If
        Me.txtAmount.Text = Convert.ToDouble(Me.txtQuantity.Text) * Convert.ToDouble(Me.txtVRate.Text)

    End Sub

    Private Sub txtAccountCode_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.F2 Then
            'frmLookupCOA.VCodeIni = txtAccountHead.Text.Trim
            frmLookupCOA.VID = lblVID.Text.Trim
            frmLookupCOA.VType = "GRNB"
            frmLookupCOA.VCode = ""
            frmLookupCOA.VName = ""
            frmLookupCOA.ShowDialog()
            If frmLookupCOA.VCode <> "" Then
                lblAcctID.Text = frmLookupCOA.VCode
                'txtAccountHead.Text = frmLookupCOA.VName
                lblAccountTitle.Text = frmLookupCOA.VName
                frmLookupCOA.Dispose()
                'txtAccountHead.Focus()
            End If
        End If
    End Sub




    Private Sub txtInstrumentNo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtInstrumentNo.KeyPress
        Dim dotLength As Integer = -1
        dotLength = Me.txtInstrumentNo.Text.Split(".").Length
        If e.KeyChar <> ControlChars.Back Then
            If dotLength > -1 Then
                e.Handled = Not (Char.IsDigit(e.KeyChar))
            Else
                e.Handled = Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = ".")
            End If
        End If
    End Sub

    Private Sub txtMachineCode_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dtpVDate.KeyUp, txtAmount.KeyUp, txtInstrumentNo.KeyUp, txtNarration.KeyUp, txtQuantity.KeyUp, txtVNo.KeyUp, txtVCode.KeyUp,
      txtVName.KeyUp, txtVRate.KeyUp
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If 'ijaz
    End Sub 'Pending

    Private Sub txtVRate_TextChanged(sender As Object, e As EventArgs) Handles txtVRate.TextChanged
        If Me.txtQuantity.Text = "" Then
            Me.txtQuantity.Text = 0
        End If
        If Me.txtVRate.Text = "" Then
            txtAmount.Text = 0
            Return
        End If
        Me.txtAmount.Text = Convert.ToDouble(Me.txtQuantity.Text) * Convert.ToDouble(Me.txtVRate.Text)

    End Sub

    Private Sub txtQuantity_TextChanged(sender As Object, e As EventArgs) Handles txtQuantity.TextChanged
        If Me.txtVRate.Text = "" Then
            Me.txtVRate.Text = 0
        End If
        If Me.txtQuantity.Text = "" Then
            txtAmount.Text = 0
            Return
        End If
        Me.txtAmount.Text = Convert.ToDouble(Me.txtQuantity.Text) * Convert.ToDouble(Me.txtVRate.Text)

    End Sub

    Private Sub txtQuantity_Leave(sender As Object, e As EventArgs) Handles txtQuantity.Leave
        If Me.txtVRate.Text = "" Then
            Me.txtVRate.Text = 0
        End If
        If Me.txtQuantity.Text = "" Then
            Me.txtQuantity.Text = 0
        End If
        Me.txtAmount.Text = Convert.ToDouble(Me.txtQuantity.Text) * Convert.ToDouble(Me.txtVRate.Text)

    End Sub

    Private Sub btnExcelExport_Click(sender As Object, e As EventArgs) Handles btnExcelExport.Click
        objCommon.ExportToExcel(grdAtt)
    End Sub

    Private Sub txtSupplier_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSupplier.KeyDown
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
            cmbTaxGLCode.Focus()
        End If
    End Sub
End Class