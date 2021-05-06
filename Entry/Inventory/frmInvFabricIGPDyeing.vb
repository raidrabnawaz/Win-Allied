Imports System.Collections.Specialized
Imports System.IO
Imports CrystalDecisions.CrystalReports.Engine



Public Class frmInvFabricIGPDyeing
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

        'objCommon.FillGPDepartment(Me.cmbDeparment)
        'objCommon.FillDepartment(Me.cmbFVtype)
        'objCommon.FillInvSupplier(Me.cmbSupplierCode)
        objCommon.FillAccMainHead(Me.cmbTaxGLCode, "Tax")
        objCommon.FillDepartment(Me.cmbDepartment)
        objCommon.FillSaleOrder(Me.cmbSaleOrder)
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
        'cmbSupplierCode.SelectedValue = -1
        'cmbDeparment.SelectedValue = -1
        cmbDepartment.SelectedIndex = 0
        cmbTaxGLCode.SelectedIndex = 0
        cmbSaleOrder.SelectedIndex = 0
        txtNarration.Text = String.Empty
        txtInstrumentNo.Text = String.Empty
      txtDriver.Text = String.Empty
      txtVehicleNo.Text = String.Empty
      dtpTimeIn.ResetText()
        lblSupplierID.Text = 0
        lblOGPID.Text = String.Empty
        txtRefNo.Text = String.Empty
        'txtSupplier.Text = String.Empty
        txtFRemarks.Text = String.Empty
      txtVNo.Text = String.Empty
      txtYarnOGPNo.Text = String.Empty
      lblVID.Text = "0"
      index = -1
      dtpVDate.Focus()
   End Sub
   Private Sub clearDet()
      Me.txtVCode.Text = String.Empty
      Me.txtVName.Text = String.Empty
      Me.txtQuantity.Text = String.Empty
      Me.txtWeight.Text = String.Empty
        Me.txtLossWeight.Text = String.Empty
        Me.txtGainWeight.Text = String.Empty
        Me.txtFabricSent.Text = String.Empty
        Me.txtFabricReceived.Text = String.Empty
        Me.txtPendingWeight.Text = String.Empty
        Me.txtAmount.Text = String.Empty
        Me.txtFreight.Text = String.Empty
        Me.txtOtherCharges.Text = String.Empty
        Me.txtTaxper.Text = String.Empty
        Me.txtTaxAmount.Text = String.Empty
        Me.txtNetAmount.Text = String.Empty
        Me.CheckBoxIsCompleted.Checked = False
        'Me.txtTotalQty.Text = String.Empty
        Me.lblDID.Text = 0
        'Me.cmbUom.SelectedValue = -1
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click

        For i As Integer = 0 To DataGridView1.RowCount - 1
            If i <> index Then
                If DataGridView1.Rows(i).Cells("IsCompleted").Value = True Then
                    MessageBox.Show("Selected OGP Yarn is compeleted", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Return
                End If
            End If
        Next
        Dim Weight As Double = Setdouble(txtWeight.Text)
        Dim PendingWeight As Double = Setdouble(txtPendingWeight.Text)
        Dim LossWeight As Double = Setdouble(txtLossWeight.Text)
        Dim GainWeight As Double = Setdouble(txtGainWeight.Text)
        Dim TotalWeight As Decimal
        For i As Integer = 0 To DataGridView1.RowCount - 1
            If i <> index Then
                TotalWeight += Convert.ToDecimal(DataGridView1.Rows(index).Cells("Weight").Value)
            End If
        Next
        If CheckBoxIsCompleted.Checked = True Then
            Dim NetWeight As Decimal = PendingWeight - TotalWeight - Weight
            If index <> -1 Then
                NetWeight = PendingWeight - TotalWeight - Weight + LossWeight - GainWeight
            End If
            If NetWeight > 0 Then
                txtLossWeight.Text = NetWeight
                txtGainWeight.Text = 0
            Else
                txtGainWeight.Text = (NetWeight * -1)
                txtLossWeight.Text = 0
                txtWeight.Text = PendingWeight
            End If
        End If
        Weight = txtWeight.Text
        If Weight > PendingWeight Then
            MessageBox.Show("Enter Valid Quantity", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.txtQuantity.Text = Me.txtPendingWeight.Text
            Return
        End If
        If Setdouble(Me.txtLossWeight.Text) > 0 And Setdouble(Me.txtGainWeight.Text) > 0 Then
            MessageBox.Show("Enter Only One Quantity from Loss Quantity and Gain Quantity", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        If Setdouble(Me.txtLossWeight.Text) > 0 Or Setdouble(Me.txtGainWeight.Text) > 0 Then
            CheckBoxIsCompleted.Checked = True
            If TotalWeight + Weight + LossWeight - GainWeight > Setdouble(Me.txtPendingWeight.Text) Then
                MessageBox.Show("Enter Valid Loss\Gain Quantity", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Me.txtQuantity.Text = Me.txtPendingWeight.Text
                Return
            End If
        End If
        'true  xor false = true
        Dim qty As Double
        qty = Setdouble(Me.txtQuantity.Text)
        If Not ((qty > 0)) Then
            MessageBox.Show("Enter Valid Quantity", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtQuantity.Focus()
            Return
        End If
        If Not (Setdouble(Me.txtWeight.Text) > 0) Then
            MessageBox.Show("Enter Valid Packing", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtQuantity.Focus()
            Return
        End If
        'If (cmbUom.SelectedValue = -1) Then
        '    MessageBox.Show("Select Valid UOM", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        '    txtQuantity.Focus()
        '    Return
        'End If
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
            DataGridView1.Rows(index).Cells("Weight").Value = Me.txtWeight.Text
            DataGridView1.Rows(index).Cells("LossWeight").Value = IIf(Me.txtLossWeight.Text Is "", 0, Me.txtLossWeight.Text)
            DataGridView1.Rows(index).Cells("GainWeight").Value = IIf(Me.txtGainWeight.Text Is "", 0, Me.txtGainWeight.Text)
            DataGridView1.Rows(index).Cells("IsCompleted").Value = Me.CheckBoxIsCompleted.Checked
            DataGridView1.Rows(index).Cells("Amount").Value = Setdouble(Me.txtAmount.Text)
            DataGridView1.Rows(index).Cells("Freight").Value = Setdouble(Me.txtFreight.Text)
            DataGridView1.Rows(index).Cells("OtherCharges").Value = Setdouble(Me.txtOtherCharges.Text)
            DataGridView1.Rows(index).Cells("TaxPer").Value = Setdouble(Me.txtTaxper.Text)
            DataGridView1.Rows(index).Cells("TaxAmount").Value = Setdouble(Me.txtTaxAmount.Text)
            DataGridView1.Rows(index).Cells("NetAmount").Value = Setdouble(Me.txtNetAmount.Text)
            'DataGridView1.Rows(index).Cells(7).Value = cr
            index = -1
            Me.clearDet()
        ElseIf index = -1 And Me.lblDID.Text.Trim <> String.Empty Then

            Dim row As String() = New String() {lblDID.Text, lblPID.Text, Me.cmbUom.SelectedValue, Me.txtVCode.Text, Me.txtVName.Text, Me.cmbUom.Text, Setdouble(Me.txtQuantity.Text), Setdouble(Me.txtWeight.Text), IIf(Me.txtLossWeight.Text Is "", 0, Me.txtLossWeight.Text), IIf(Me.txtGainWeight.Text Is "", 0, Me.txtGainWeight.Text), Setdouble(Me.txtAmount.Text), Setdouble(Me.txtFreight.Text), Setdouble(Me.txtOtherCharges.Text), Setdouble(Me.txtTaxper.Text), Setdouble(Me.txtTaxAmount.Text), Setdouble(Me.txtNetAmount.Text), Me.CheckBoxIsCompleted.Checked}
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
                Me.txtWeight.Text = DataGridView1.Rows(index).Cells("Weight").Value
                Me.txtLossWeight.Text = DataGridView1.Rows(index).Cells("LossWeight").Value
                Me.txtGainWeight.Text = DataGridView1.Rows(index).Cells("GainWeight").Value
                Me.CheckBoxIsCompleted.Checked = DataGridView1.Rows(index).Cells("IsCompleted").Value
                Me.txtAmount.Text = DataGridView1.Rows(index).Cells("Amount").Value
                Me.txtFreight.Text = DataGridView1.Rows(index).Cells("Freight").Value
                Me.txtOtherCharges.Text = DataGridView1.Rows(index).Cells("OtherCharges").Value
                Me.txtTaxper.Text = DataGridView1.Rows(index).Cells("TaxPer").Value
                Me.txtAmount.Text = DataGridView1.Rows(index).Cells("TaxAmount").Value
                Me.txtNetAmount.Text = DataGridView1.Rows(index).Cells("NetAmount").Value
            End If
        End If
    End Sub

    Private Sub txtQuantity_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtQuantity.KeyPress
        Dim dotLength As Integer = 1
        dotLength = Me.txtQuantity.Text.Split(".").Length
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
            qryMain = "EXEC SpSaveKnitFabricDyeingIGPMain " & lblVID.Text & ", '', '" & CDate(dtpVDate.Value).ToString("dd/MMM/yyyy") & "', '" & txtNarration.Text & "','" & txtInstrumentNo.Text & "','" & txtRefNo.Text
            qryMain += "', '" & txtDriver.Text & "','" & txtVehicleNo.Text & "','" & CDate(dtpTimeIn.Value).ToString("hh:mm tt") & "', " & lblOGPID.Text & "," & lblSupplierID.Text & "," & cmbDepartment.SelectedValue & "," & cmbSaleOrder.SelectedValue & "," & cmbTaxGLCode.SelectedValue & ", " & G_Compcode & ", " & G_FinancialYearID & ", " & G_UID & ", '" & G_IPAddress & "', " & G_UID & ",'" & G_IPAddress & "'"
            MID = objCommon.ExecuteScalar(qryMain)
            objCommon.openConnection()
            For Each grid As DataGridViewRow In DataGridView1.Rows
                qryMain = "EXEC SpSaveKnitFabricDyeingIGPDetail " & grid.Cells("VID").Value & "," & lblOGPID.Text & ", " & MID & ", '" & grid.Cells("ProductID").Value & "', '" & grid.Cells("UOMID").Value & "',  " & grid.Cells("Quantity").Value & ",  " & grid.Cells("LossWeight").Value & ",  " & grid.Cells("GainWeight").Value & ",  " & grid.Cells("Amount").Value & ",  " & grid.Cells("Freight").Value & ",  " & grid.Cells("OtherCharges").Value & ",  " & grid.Cells("TaxPer").Value & ",  " & grid.Cells("TaxAmount").Value & ",  " & grid.Cells("NetAmount").Value & ", " & IIf(grid.Cells("IsCompleted").Value = True, 1, 0) & ",0, " & grid.Cells("Weight").Value & ", '-', " & G_UID & ", '" & G_IPAddress & "', " & G_UID & ",'" & G_IPAddress & "', " & IIf(grid.Cells("IsDel").Value = Nothing, 0, 1)
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
        If lblVID.Text = "" Or lblVID.Text Is "" Then
            lblVID.Text = "0"
        End If
        If DataGridView1.Rows.Count = 1 And DataGridView1.Rows(0).Visible = False Then
            verify &= "Must Enter Detail.!" & vbNewLine
            'txtVCode.Focus()
        End If

        Dim Lock As String
        Lock = objCommon.ExecuteScalar("select dbo.fnAllowBackDate('Win-ERP','frmInvFabricIGPDyeing','" & CDate(dtpVDate.Value).ToString("dd/MMM/yyyy") & "'," & G_UID & "," & G_Compcode & ", " & G_FinancialYearID & ")")

        If Not (Lock = "") Then
            verify = Lock
            Return verify
        End If

        If txtYarnOGPNo.Text = "" Then
            verify &= "Select Valid Yarn OGP.!" & vbNewLine
            txtYarnOGPNo.Focus()
        End If

        Return verify
    End Function
    Private Sub txtAccountCode_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtVCode.KeyDown
        If e.KeyCode = Keys.F2 Then
            frmLookup.LookupQuery = "SELECT VID, VCode, VName, IsAccessory, LeadTime, ExcessPer FROM invProduct where CategoryID=4004"
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
            'cmbUom.SelectedValue = frmLookup.UOMID
            'frmLookupCOA.Dispose()
            txtQuantity.Focus()
        End If
    End Sub
    'Private Sub txtAccountCode_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtVCode.Leave
    '    If txtVCode.Text.Trim.Length <> 7 Then
    '        'lblMID.Text = ""
    '        'lblAccountTitle.Text = ""
    '        Return
    '    End If
    '    qryMain = " SELECT TOP 1 VID, VCode, VName FROM invProduct WHERE VCode ='" & txtVCode.Text.Trim & "' "
    'End Sub

    Private Sub grdAtt_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles grdAtt.MouseClick
        If grdAtt.Rows.Count > 0 Then
            If grdAtt.RowCount > -1 Then
                Me.TabMain.SelectedTab = TabPage1
                lblVID.Text = grdAtt.Rows(grdAtt.CurrentCell.RowIndex).Cells("VID").Value
                dt = objCommon.GetDataTable("EXEC SpGetbyIDKnitFabricDyeingIGP " & Setdouble(lblVID.Text))
                If dt.Rows.Count > 0 Then
                    lblVID.Text = dt.Rows(0)("VID")
                    txtVNo.Text = dt.Rows(0)("VCode")
                    dtpVDate.Value = dt.Rows(0)("VDate")
                    txtNarration.Text = dt.Rows(0)("VName")
                    txtInstrumentNo.Text = dt.Rows(0)("InstrumentNo")
                    txtRefNo.Text = dt.Rows(0)("RefNo")
                    txtDriver.Text = dt.Rows(0)("DriverName")
                    txtVehicleNo.Text = dt.Rows(0)("VehicleNo")
                    lblOGPID.Text = dt.Rows(0)("FabricOGPID")
                    txtYarnOGPNo.Text = dt.Rows(0)("OGPRemarks")
                    dtpTimeIn.Value = dt.Rows(0)("InwardTime")
                    cmbDepartment.SelectedValue = dt.Rows(0)("DepartmentID")
                    cmbSaleOrder.SelectedValue = dt.Rows(0)("OrderID")
                    cmbTaxGLCode.SelectedValue = dt.Rows(0)("TaxGLCode")
                    lblSupplierID.Text = dt.Rows(0)("SupplierID")
                    'cmbSupplierCode.SelectedValue = dt.Rows(0)("SupplierID")
                    'cmbDeparment.SelectedValue = dt.Rows(0)("DepartmentID")
                    'objCommon.FillGPSupplierName(Me.txtSupplier, cmbSupplierCode.SelectedValue)
                    DataGridView1.Rows.Clear()
                    For I As Integer = 0 To dt.Rows.Count - 1
                        Dim row As String() = New String() {dt.Rows(I)("DID"), dt.Rows(I)("ProductID"), dt.Rows(I)("UOMID"), dt.Rows(I)("ProductCode"), dt.Rows(I)("ProductName"), dt.Rows(I)("UOMName"), Math.Round(Decimal.Parse(dt.Rows(I)("Qty")), 2), dt.Rows(I)("Packing"), dt.Rows(I)("LossQty"), dt.Rows(I)("GainQty"), dt.Rows(I)("ExtraAmount"), dt.Rows(I)("Freight"), dt.Rows(I)("OtherCharges"), dt.Rows(I)("TaxPer"), dt.Rows(I)("TaxAmount"), dt.Rows(I)("NetAmount"), IIf(dt.Rows(I)("IsCompleted") = 0, False, True)}
                        DataGridView1.Rows.Add(row)
                    Next
                End If
            End If
        End If
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        Dim cWhere As String = " WHERE VDATE between ''" & Convert.ToDateTime(dtFDateFrom.Value).ToString("dd/MMM/yyyy") & "'' AND ''" & Convert.ToDateTime(dtFDateTo.Value).ToString("dd/MMM/yyyy") & "''"
        If Not txtFVNo.Text = "" Then cWhere &= " AND VCode=''" & txtFVNo.Text & "'' "
        'If Not cmbFVtype.SelectedValue = "-1" Then cWhere &= " AND VType=''GRNB'' "
        If Not txtFRemarks.Text = "" Then cWhere &= " AND Remarks like ''%" & txtFRemarks.Text & "%'' "
        qryMain = "EXEC SpGetInvSearchLookUp 'IGPForFabricDyeing', @CWhere='" & cWhere & "' "
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

    Private Sub cmdPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrint.Click    ''pending
        MyListDic.Clear()
        rpt = (WinReportsApplication.Classess.InventoryReport.SetReportName("rfFabricDying"))
        FilterVTypeList = ""
        FilterDate = ""
        ReportTitle = ""

        MyListDic.Add("@VID", lblVID.Text)
        ReportSpName = "SpRptKnitFabricDyeingIGP"
        dtrpt = objCommon.GetDataTableSPPrm(ReportSpName, MyListDic)

        MyListDic.Add("comp_Name", G_CompName)
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

    Private Sub txtVRate_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtWeight.KeyPress
        Dim dotLength As Integer = 1
        dotLength = Me.txtWeight.Text.Split(".").Length
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

    'Private Sub txtVRate_Leave(ByVal sender As Object, ByVal e As EventArgs) Handles txtWeight.Leave
    '   Me.txtTotalQty.Text = Convert.ToDouble(Me.txtQuantity.Text) * Convert.ToDouble(Me.txtPacking.Text)
    'End Sub

    Private Sub TxtOGPNo_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles txtYarnOGPNo.KeyDown
        If e.KeyCode = Keys.F2 Then
            frmLookup.LookupQuery = "SELECT VID, VDate, VName, VCode, SupplierID, DepartmentID, OrderID FROM ViewKnitFabricOGP where Packing- UsedQty >0 and IsPosted=0"
            frmLookup.LookupName = "YarnOGP"
            frmLookup.VID = ""
            frmLookup.VCode = ""
            frmLookup.VName = ""
            frmLookup.OrderID = ""
            frmLookup.DepartmentID = ""
            frmLookup.ShowDialog()
            If frmLookup.VID <> "" Then
                lblOGPID.Text = frmLookup.VID
                txtYarnOGPNo.Text = frmLookup.VName
                lblSupplierID.Text = frmLookup.SupplierID
                cmbSaleOrder.SelectedValue = frmLookup.OrderID
                cmbDepartment.SelectedValue = frmLookup.DepartmentID
            End If
            'frmLookupCOA.Dispose()
            DataGridView1.Rows.Clear()
            'dtpTimeIn.Focus()
            'loadDetGrid()
        End If
    End Sub

    Private Sub cmbSupplierCode_SelectionChangeCommitted(ByVal sender As Object, ByVal e As EventArgs)

    End Sub

    Private Sub txtMachineCode_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dtpVDate.KeyUp,
      txtWeight.KeyUp, txtNarration.KeyUp, txtQuantity.KeyUp, txtVCode.KeyUp, txtVName.KeyUp, txtVNo.KeyUp, txtInstrumentNo.KeyUp
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If 'ijaz
    End Sub 'Pending

    Private Sub btnExcelExport_Click(sender As Object, e As EventArgs) Handles btnExcelExport.Click
        objCommon.ExportToExcel(grdAtt)
    End Sub

    Private Sub txtYarnOGPNo_TextChanged(sender As Object, e As EventArgs) Handles txtYarnOGPNo.TextChanged
        If Not txtYarnOGPNo.Text = "" Then
            qryMain = "select Cast(Isnull(SUM(OGPD.Packing),0)as numeric(18,2)) as OGPQty, Cast(Isnull(SUM(IGPD.Packing),0)as numeric(18,2)) as IGPQty from KnitFabricDyeingOGPDetail as OGPD left outer join KnitFabricDyeingIGPMain as IGPM on 1=1 left outer join KnitFabricDyeingIGPDetail as IGPD ON IGPM.FabricOGPID = " & lblOGPID.Text & " and IGPM.vid = IGPD.MID where OGPD.MID = " & lblOGPID.Text & " "
            Dim dt As DataTable = objCommon.GetDataTable(qryMain)
            If dt Is Nothing Then
                Return
            End If
            txtFabricSent.Text = dt.Rows(0)("OGPQty")
            txtFabricReceived.Text = dt.Rows(0)("IGPqty")
            txtPendingWeight.Text = dt.Rows(0)("OGPQty") - dt.Rows(0)("IGPqty")
        End If

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtTaxAmount.TextChanged

    End Sub

    Private Sub txtTaxper_TextChanged(sender As Object, e As EventArgs) Handles txtTaxper.TextChanged
        If Setdouble(txtTaxper.Text) > 0 Then
            txtTaxAmount.Text = ((Setdouble(txtAmount.Text) * Setdouble(txtTaxper.Text)) / 100).ToString()
        End If
        txtNetAmount.Text = (Setdouble(txtAmount.Text) + Setdouble(txtFreight.Text) + Setdouble(txtOtherCharges.Text) + Setdouble(txtTaxAmount.Text)).ToString()
    End Sub

    Private Sub txtAmount_TextChanged(sender As Object, e As EventArgs) Handles txtAmount.TextChanged
        txtTaxper_TextChanged(sender, e)
    End Sub

    Private Sub txtFreight_TextChanged(sender As Object, e As EventArgs) Handles txtFreight.TextChanged
        txtTaxper_TextChanged(sender, e)
    End Sub

    Private Sub txtOtherCharges_TextChanged(sender As Object, e As EventArgs) Handles txtOtherCharges.TextChanged
        txtTaxper_TextChanged(sender, e)
    End Sub
End Class