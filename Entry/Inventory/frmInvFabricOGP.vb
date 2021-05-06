Imports System.Collections.Specialized
Imports System.IO
Imports CrystalDecisions.CrystalReports.Engine



Public Class frmInvFabricOGP

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

        'objCommon.FillPOType(Me.cmbPoType)
        'objCommon.FillPOType(Me.cmbFVtype)
        'objCommon.FillPaymentTerm(Me.cmbPaymentTerm)
        objCommon.FillSaleOrder(Me.cmbSaleOrder)
        objCommon.FillDepartment(Me.cmbDepartment)
        objCommon.FillInvSupplier(Me.cmbSupplierCode)
        objCommon.FillUoM(Me.cmbUom)
      dtFDateTo.Value = Date.Today
      dtFDateFrom.Value = "01/" & Today.ToString("MM/yyyy")
      Me.lblVID.Text = "0"
      btnSearch_Click(sender, e)
      Me.ActiveControl = dtpVDate
   End Sub

   Private Sub clearHead()
      For Each ctl In SplitContainer2.Panel1.Controls
         If TypeOf ctl Is TextBox Then ctl.Text = ""
      Next ctl
      txtNarration.Text = String.Empty
      dtpVDate.Value = Date.Today
        'cmbPoType.SelectedValue = -1
        cmbDepartment.SelectedIndex = 0
        cmbSaleOrder.SelectedIndex = 0
        txtBookNo.Text = String.Empty
        txtBookNo.Text = String.Empty
      txtFRemarks.Text = String.Empty
      txtVNo.Text = String.Empty
      cmbSupplierCode.SelectedIndex = -1
      dtpTimeIn.ResetText()
      lblVID.Text = "0"
      index = -1
      dtpVDate.Focus()
   End Sub
   Private Sub clearDet()
      Me.txtVCode.Text = String.Empty
      Me.txtAvailableQty.Text = String.Empty
      Me.txtQuantity.Text = String.Empty
      Me.txtWeight.Text = String.Empty
        Me.txtProductName.Text = String.Empty
        Me.cmbProductBatches.SelectedValue = 0
        'Me.txtTotalQty.Text = String.Empty
        Me.lblDID.Text = 0
      Me.cmbUom.SelectedValue = -1
   End Sub

   Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
      Try
         Dim ErrMsg As String = verifySave()
         If Not ErrMsg = "" Then
            MessageBox.Show(ErrMsg, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
         End If

         Dim MID As Integer = 0
         qryMain = "EXEC SpSaveKnitFabricOGPMain " & lblVID.Text & ", '', " & cmbSupplierCode.SelectedValue & ", '" & CDate(dtpVDate.Value).ToString("dd/MMM/yyyy") & "', '" & txtNarration.Text
            qryMain += "','" & txtBookNo.Text & "','" & txtDriver.Text & "','" & txtVehicleNo.Text & "','" & CDate(dtpTimeIn.Value).ToString("hh:mm tt") & "',  " & cmbDepartment.SelectedValue & "," & cmbSaleOrder.SelectedValue & ", " & G_Compcode & ", " & G_FinancialYearID & ", " & G_UID & ", '" & G_IPAddress & "', " & G_UID & ",'" & G_IPAddress & "'"
            MID = objCommon.ExecuteScalar(qryMain)
            objCommon.openConnection()
            For Each grid As DataGridViewRow In DataGridView1.Rows
                If Setdouble(grid.Cells("Quantity").Value) > 0 Then
                    qryMain = "EXEC SpSaveKnitFabricOGPdetail " & grid.Cells("VID").Value & ", " & MID & ", '" & grid.Cells("ProductID").Value & "','" & grid.Cells("UomID").Value & "',  " & grid.Cells("Quantity").Value & ", " & grid.Cells("Weight").Value & ", '-'," & G_Compcode & "," & G_FinancialYearID & ",'" & grid.Cells("VType").Value & "', " & grid.Cells("VTypePk").Value & ",  " & G_UID & ", '" & G_IPAddress & "', " & G_UID & ",'" & G_IPAddress & "', " & IIf(grid.Cells("IsDel").Value = Nothing, 0, 1)
                    objCommon.ExecuteNonQueryWithOpen(qryMain)
                End If
            Next
            objCommon.CloseConnection()
            MessageBox.Show("Voucher Successfully Save", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
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
      If DataGridView1.Rows.Count = 1 And DataGridView1.Rows(0).Visible = False Then
         verify &= "Must Enter Detail.!" & vbNewLine
         'txtVCode.Focus()
      End If

        Dim Lock As String
        Lock = objCommon.ExecuteScalar("select dbo.fnAllowBackDate('Win-ERP','frmInvFabricOGP','" & CDate(dtpVDate.Value).ToString("dd/MMM/yyyy") & "'," & G_UID & "," & G_Compcode & ", " & G_FinancialYearID & ")")

        If Not (Lock = "") Then
            verify = Lock
            Return verify
        End If
        For Each grid As DataGridViewRow In DataGridView1.Rows
         If Not Setdouble(grid.Cells("Quantity").Value) > 0 Then
            verify &= "Please Add Some Qunatity.!" & vbNewLine
         End If
      Next


      If cmbSupplierCode.SelectedValue = "-1" Then
         verify &= "Select Valid Supplier.!" & vbNewLine
         cmbSupplierCode.Focus()
      End If

      Return verify
   End Function
   Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
      Dim cWhere As String = " WHERE VDATE between ''" & Convert.ToDateTime(dtFDateFrom.Value).ToString("dd/MMM/yyyy") & "'' AND ''" & Convert.ToDateTime(dtFDateTo.Value).ToString("dd/MMM/yyyy") & "''"
        If Not txtFVNo.Text = "" Then cWhere &= " AND VCode like ''%" & txtFVNo.Text & "%'' "
        'If Not cmbFVtype.SelectedValue = "-1" Then cWhere &= " AND VType='" & cmbFVtype.SelectedValue & "' "
        If Not txtFRemarks.Text = "" Then cWhere &= " AND Remarks like ''%" & txtFRemarks.Text & "%'' "
        qryMain = "EXEC SpGetInvSearchLookUp 'OGPForFabricDyeing', @CWhere='" & cWhere & "' "
      grdAtt.DataSource = objCommon.GetDataTable(qryMain)
      If grdAtt.Rows.Count > 0 Then setGrid(grdAtt)
      If grdAtt.Rows.Count > 0 Then grdAtt.Columns(0).Visible = False
   End Sub

   Private Sub cmdNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNew.Click
      clearHead()
      DataGridView1.Rows.Clear()
   End Sub

   Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
      Me.Close()
   End Sub

   Private Sub cmdPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrint.Click   ''pending
      MyListDic.Clear()
      rpt = (WinReportsApplication.Classess.InventoryReport.SetReportName("rfFabricOGP"))
      FilterVTypeList = ""
      FilterDate = ""
      ReportTitle = ""

      MyListDic.Add("@VID", lblVID.Text)
      ReportSpName = "SpRptKnitFabricOGP"
      dtrpt = objCommon.GetDataTableSPPrm(ReportSpName, MyListDic)

      MyListDic.Add("comp_Name", G_CompName)
      MyListDic.Add("ReportTitle", "Fabric Outward Gate Pass")
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
            txtProductName.Text = frmLookup.VName
         End If
         'cmbUom.SelectedValue = frmLookup.UOMID
         'frmLookupCOA.Dispose()
         txtQuantity.Focus()
      End If
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
      If Not (Setdouble(Me.txtWeight.Text) > 0) Then
         MessageBox.Show("Enter Valid Packing", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
         txtQuantity.Focus()
         Return
      End If
      If (cmbUom.SelectedValue = -1) Then
         MessageBox.Show("Select Valid UOM", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
         cmbUom.Focus()
         Return
      End If
      If Setdouble(txtQuantity.Text) > Setdouble(txtAvailableQty.Text) Then
         MessageBox.Show("Quantity cannot be greater than Pending Quantity", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
         txtQuantity.Focus()
         Return
      End If


      If lblPID.Text = "" Then
         MessageBox.Show("Select Valid Product", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
         txtVCode.Focus()
         Return
      End If

      If index > -1 And Me.lblVID.Text.Trim <> String.Empty Then
         DataGridView1.Rows(index).Cells("VID").Value = Me.lblDID.Text
         DataGridView1.Rows(index).Cells("ProductID").Value = Me.lblPID.Text
         DataGridView1.Rows(index).Cells("UomID").Value = Me.cmbUom.SelectedValue
         DataGridView1.Rows(index).Cells("VCode").Value = Me.txtVCode.Text
         DataGridView1.Rows(index).Cells("VName").Value = Me.cmbProductBatches.Text
         DataGridView1.Rows(index).Cells("UOM").Value = Me.cmbUom.Text
         DataGridView1.Rows(index).Cells("DQty").Value = Me.txtAvailableQty.Text
         DataGridView1.Rows(index).Cells("Quantity").Value = Me.txtQuantity.Text
         DataGridView1.Rows(index).Cells("Weight").Value = Me.txtWeight.Text
         DataGridView1.Rows(index).Cells("VType").Value = Me.lblVType.Text
         DataGridView1.Rows(index).Cells("VTypePK").Value = Me.cmbProductBatches.SelectedValue
            'DataGridView1.Rows(index).Cells("Amount").Value = Me.txtTotalQty.Text
            'DataGridView1.Rows(index).Cells(7).Value = cr
            index = -1
         Me.clearDet()
      ElseIf index = -1 And Me.lblDID.Text.Trim <> String.Empty Then

            Dim row As String() = New String() {lblDID.Text, lblPID.Text, Me.cmbUom.SelectedValue, Me.txtVCode.Text, Me.cmbProductBatches.Text, Me.cmbUom.Text, Me.txtAvailableQty.Text, Me.txtQuantity.Text, Me.txtWeight.Text, Me.lblVType.Text, Me.cmbProductBatches.SelectedValue}
            DataGridView1.Rows.Add(row)
         Me.clearDet()
      Else
         MessageBox.Show("Select Correct Entry", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
      End If
      Me.txtVCode.Focus()
   End Sub

   Private Sub TextBox_keyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs)
      If e.KeyChar <> ControlChars.Back Then If Not (Char.IsDigit(CChar(CStr(e.KeyChar))) Or e.KeyChar = ".") Then e.Handled = True
      'If e.KeyChar <> ControlChars.Back Then If Char.IsDigit(CChar(CStr(e.KeyChar))) = False Then e.Handled = True
   End Sub

   Private Sub TextBox_keyPress1(ByVal sender As Object, ByVal e As KeyPressEventArgs)
      If e.KeyChar <> ControlChars.Back Then If Not (Char.IsDigit(CChar(CStr(e.KeyChar))) Or e.KeyChar = ".") Then e.Handled = True
   End Sub
   
   Private Sub DataGridView1_CellClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
      If DataGridView1.Rows.Count > 0 Then
         index = e.RowIndex
         If e.ColumnIndex = DataGridView1.Columns("DEL").Index Then
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
            Me.txtProductName.Text = DataGridView1.Rows(index).Cells("VName").Value
            Me.txtQuantity.Text = DataGridView1.Rows(index).Cells("Quantity").Value
            Me.txtWeight.Text = DataGridView1.Rows(index).Cells("Weight").Value
            Me.cmbProductBatches.SelectedValue = DataGridView1.Rows(index).Cells("VTypePk").Value
                'Me.txtTotalQty.Text = DataGridView1.Rows(index).Cells("Amount").Value
            End If
      End If
   End Sub

   Private Sub GrdAtt_CellClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles grdAtt.CellClick
      If grdAtt.Rows.Count > 0 Then
         If grdAtt.RowCount > -1 Then
            Me.TabMain.SelectedTab = TabPage1
            lblVID.Text = grdAtt.Rows(grdAtt.CurrentCell.RowIndex).Cells("VID").Value
            dt = objCommon.GetDataTable("EXEC SpGetbyIDKnitFabricOGP " & Setdouble(lblVID.Text))
            If dt.Rows.Count > 0 Then
               lblVID.Text = dt.Rows(0)("VID")
               txtVNo.Text = dt.Rows(0)("VCode")
               dtpVDate.Value = dt.Rows(0)("VDate")
               txtNarration.Text = dt.Rows(0)("VName")
               txtBookNo.Text = dt.Rows(0)("InstrumentNo")
               txtDriver.Text = dt.Rows(0)("DriverName")
               txtVehicleNo.Text = dt.Rows(0)("VehicleNo")
               dtpTimeIn.Value = dt.Rows(0)("OutwardTime")
               cmbSupplierCode.SelectedValue = dt.Rows(0)("SupplierID")
                    cmbDepartment.SelectedValue = dt.Rows(0)("DepartmentID")
                    cmbSaleOrder.SelectedValue = dt.Rows(0)("OrderID")
                    DataGridView1.Rows.Clear()
                    For I As Integer = 0 To dt.Rows.Count - 1
                        Dim row As String() = New String() {dt.Rows(I)("DID"), dt.Rows(I)("ProductID"), dt.Rows(I)("UOMID"), dt.Rows(I)("ProductCode"), dt.Rows(I)("ProductName"), dt.Rows(I)("UOMName"), "0", dt.Rows(I)("Qty"), dt.Rows(I)("Packing"), dt.Rows(I)("VType"), dt.Rows(I)("VTypePk")}
                        'Dim row As String() = New String() {lblDID.Text, lblPID.Text, Me.cmbUom.SelectedValue, Me.txtVCode.Text, Me.cmbProductBatches.Text, Me.cmbUom.Text, Me.txtAvailableQty.Text, Me.txtQuantity.Text, Me.txtWeight.Text, Me.lblVType.Text, Me.cmbProductBatches.SelectedValue}

                        DataGridView1.Rows.Add(row)
               Next
            End If
         End If
      End If
   End Sub



    Private Sub txtMachineCode_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dtpVDate.KeyUp,
      txtBookNo.KeyUp, txtDriver.KeyUp, txtNarration.KeyUp, txtVehicleNo.KeyUp, txtVNo.KeyUp
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If 'ijaz
    End Sub 'Pending


    Private Sub lblPID_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblPID.TextChanged
      objCommon.FillIssueProductBatches(Me.cmbProductBatches, Setdouble(lblPID.Text))

   End Sub

   Private Sub cmbProductBatches_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbProductBatches.SelectedIndexChanged
      'If Setdouble(cmbProductBatches.SelectedValue.ToString) > -1 Then
      Dim Batch = cmbProductBatches.Text.Split(":")
      If Batch.Length > 1 Then
         txtAvailableQty.Text = Batch(3)
         lblVType.Text = Batch(1)
      End If
      'End If
   End Sub
 
   Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
      Me.clearDet()
   End Sub

    Private Sub btnExcelExport_Click(sender As Object, e As EventArgs) Handles btnExcelExport.Click
        objCommon.ExportToExcel(grdAtt)
    End Sub
End Class