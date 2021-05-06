Imports System.Collections.Specialized
Imports System.IO
Imports CrystalDecisions.CrystalReports.Engine


Public Class frmIGPforOGPReturnable
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

      objCommon.FillGPDepartment(Me.cmbDeparment)
      'objCommon.FillDepartment(Me.cmbFVtype)
      objCommon.FillGPSupplier(Me.cmbSupplierCode)
      objCommon.FillGPSupplierName(Me.txtSupplier, cmbSupplierCode.SelectedValue)
      dtFDateTo.Value = Date.Today
      dtFDateFrom.Value = "01/" & Today.ToString("MM/yyyy") 'Date.Today
      Me.lblVID.Text = "0"
      btnSearch_Click(sender, e)
      Me.ActiveControl = dtpVDate
   End Sub

    Private Sub clearHead()
      txtDriver.Text = String.Empty
      txtVehicleNo.Text = String.Empty
      dtpTimeIn.Text = TimeOfDay.ToString("hh:mm tt")
      txtNarration.Text = String.Empty
        dtpVDate.Value = Date.Today
        cmbSupplierCode.SelectedIndex = 0
        cmbDeparment.SelectedIndex = 0
        txtNarration.Text = String.Empty
        txtSupplier.Text = String.Empty
        txtFRemarks.Text = String.Empty
      txtVNo.Text = String.Empty
      txtOGPCode.Text = ""
      txtOGPDesc.Text = ""
      lblOGPID.Text = ""
        lblVID.Text = "0"
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
            If (cmbSupplierCode.SelectedIndex < 1) Then
                MessageBox.Show("Give Supplier Details.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                cmbSupplierCode.Focus()
                Return
            End If


            Dim MID As Integer = 0
         qryMain = "EXEC SpSaveGPIGPForOGPReturnableMain " & lblVID.Text & ", '" & txtVNo.Text & "', " & cmbSupplierCode.SelectedValue & "," & lblOGPID.Text & ", '" & CDate(dtpVDate.Value).ToString("dd/MMM/yyyy") & "', '" & txtNarration.Text
         qryMain += "', '" & txtDriver.Text & "', '" & txtVehicleNo.Text & "', '" & dtpTimeIn.Text & "', " & cmbDeparment.SelectedValue & ", " & G_Compcode & ", " & G_FinancialYearID & ", " & G_UID & ", '" & G_IPAddress & "', " & G_UID & ",'" & G_IPAddress & "'"
            MID = objCommon.ExecuteScalar(qryMain)
            objCommon.openConnection()
            For Each grid As DataGridViewRow In DataGridView1.Rows
                qryMain = "EXEC SpSaveGPIGPForOGPReturnableDetail " & grid.Cells("VID").Value & ", " & MID & ", '" & grid.Cells("ProductID").Value & "',  " & grid.Cells("Quantity").Value & ", " & grid.Cells("VRate").Value & ",'OGPToIGPReturnable'," & grid.Cells("VTypePK").Value & ", '" & txtNarration.Text & "', " & G_UID & ", '" & G_IPAddress & "', " & G_UID & ",'" & G_IPAddress & "', " & IIf(grid.Cells("IsDel").Value = Nothing, 0, 1)
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
         txtOGPCode.Focus()
         Return verify
        End If
        Dim Lock As String
        Lock = objCommon.ExecuteScalar("select dbo.fnAllowBackDate('Win-ERP','frmIGPforOGPReturnable','" & CDate(dtpVDate.Value).ToString("dd/MMM/yyyy") & "'," & G_UID & "," & G_Compcode & ", " & G_FinancialYearID & ")")

        If Not (Lock = "") Then
            verify = Lock
            Return verify
        End If
        If lblVID.Text = "" Or lblVID.Text Is "" Then
         lblVID.Text = 0
      End If
      For Each grid As DataGridViewRow In DataGridView1.Rows
         If Not Setdouble(grid.Cells("Quantity").Value) > 0 And grid.Cells("Quantity").Visible = True Then
            verify &= "Please Add Some Qunatity.!" & vbNewLine
         End If
      Next

        If DataGridView1.Rows.Count = 1 And DataGridView1.Rows(0).Visible = False Then
            verify &= "Must Enter Detail.!" & vbNewLine
            'txtVCode.Focus()
        End If

        If cmbSupplierCode.SelectedValue = "-1" Then
            verify &= "Select Valid Account.!" & vbNewLine
            cmbSupplierCode.Focus()
        End If

        Return verify
    End Function

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
            dt = objCommon.GetDataTable("EXEC SpGetbyIDGPIGPForOGPReturnableMainDetail " & Setdouble(lblVID.Text))
            If dt.Rows.Count > 0 Then
               lblVID.Text = dt.Rows(0)("VID")
               txtVNo.Text = dt.Rows(0)("VCode")
               dtpVDate.Value = dt.Rows(0)("VDate")
               txtNarration.Text = dt.Rows(0)("VName")
               txtDriver.Text = dt.Rows(0)("DriverName").ToString()
               txtVehicleNo.Text = dt.Rows(0)("VehicleNo").ToString()
               dtpTimeIn.Text = dt.Rows(0)("InwardTime").ToString()
               lblOGPID.Text = dt.Rows(0)("OGPID")
               txtOGPCode.Text = dt.Rows(0)("OGPCode")
               cmbSupplierCode.SelectedValue = dt.Rows(0)("SupplierID")
               cmbDeparment.SelectedValue = dt.Rows(0)("DepartmentID")
               objCommon.FillGPSupplierName(Me.txtSupplier, cmbSupplierCode.SelectedValue)
               DataGridView1.Rows.Clear()
               For I As Integer = 0 To dt.Rows.Count - 1
                        Dim row As String() = New String() {dt.Rows(I)("DID"), dt.Rows(I)("ProductID"), dt.Rows(I)("ProductCode"), dt.Rows(I)("ProductName"), dt.Rows(I)("OGPQty"), dt.Rows(I)("PendingQty"), dt.Rows(I)("Qty"), Math.Round(Decimal.Parse(dt.Rows(I)("Packing")), 2), Math.Round(Decimal.Parse(dt.Rows(I)("Qty") * dt.Rows(I)("Packing")), 2), dt.Rows(I)("VTypePK")}
                        DataGridView1.Rows.Add(row)
               Next
            End If
         End If
      End If
   End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
      Dim cWhere As String = " WHERE VDATE between ''" & Convert.ToDateTime(dtFDateFrom.Value).ToString("dd/MMM/yyyy") & "'' AND ''" & Convert.ToDateTime(dtFDateTo.Value).ToString("dd/MMM/yyyy") & "'' AND FinancialYearID = " & G_FinancialYearID
        If Not txtFVNo.Text = "" Then cWhere &= " AND VCode like ''%" & txtFVNo.Text & "%'' "
        'If Not cmbFVtype.SelectedValue = "-1" Then cWhere &= " AND VType=''GRNB'' "
        If Not txtFRemarks.Text = "" Then cWhere &= " AND Remarks like ''%" & txtNarration.Text & "%'' "
        qryMain = "EXEC SpGetInvSearchLookUp 'IGPForOGPReturnable', @CWhere='" & cWhere & "' "
        grdAtt.DataSource = objCommon.GetDataTable(qryMain)
        If grdAtt.Rows.Count > 0 Then grdAtt.Columns(0).Visible = False
        If grdAtt.Rows.Count > 0 Then setGrid(grdAtt)
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

      rpt = (WinReportsApplication.Classess.GatePassSystemReports.SetReportName("rfGPIGPforOGP"))
        FilterVTypeList = ""
        FilterDate = ""
        ReportTitle = ""

        MyListDic.Add("@VID", lblVID.Text)
      ReportSpName = "SpRptGPIGPForOGPReturnable"
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

    Private Sub txtCredit_Enter(sender As System.Object, e As System.EventArgs)
        'txtCredit.SelectionStart = 0
        'txtCredit.SelectionLength = txtCredit.Text.Length
    End Sub

    Private Sub cmdDelete_Click(sender As System.Object, e As System.EventArgs) Handles cmdDelete.Click
      'qryMain = " delete from tblAcJVDet where MId = " & lblVID.Text & " ; delete from tblAcJVHead where VId = " & lblVID.Text & " ; "
      'objCommon.ExecuteNonQuery(qryMain)
      'MessageBox.Show("Voucher removed Successfully ", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
      'clearHead()
      'DataGridView1.Rows.Clear()
      'btnSearch_Click(sender, e)
        'txtVNo.Focus()
    End Sub

    Private Sub BtnClear_Click(sender As Object, e As EventArgs)
        clearHead()
        DataGridView1.Rows.Clear()
    End Sub


    Private Sub txtInstrumentNo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSupplier.KeyPress
      Dim dotLength As Integer = 1
        dotLength = Me.txtSupplier.Text.Split(".").Length
        If e.KeyChar <> ControlChars.Back Then
         If dotLength > 1 Then
            e.Handled = Not (Char.IsDigit(e.KeyChar))
         Else
            e.Handled = Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = ".")
         End If
        End If
    End Sub

    Private Sub cmbSupplierCode_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cmbSupplierCode.SelectionChangeCommitted
        objCommon.FillGPSupplierName(Me.txtSupplier, cmbSupplierCode.SelectedValue)
    End Sub

    Private Sub txtIGPCode_KeyDown(sender As Object, e As KeyEventArgs) Handles txtOGPCode.KeyDown
        If e.KeyCode = Keys.F2 Then
            frmLookup.LookupQuery = "EXEC SpGetByShowGPOutWardReturnablemain"
            frmLookup.LookupName = "FetchOGP"
            frmLookup.ShowDialog()
            If frmLookup.VID <> "" Then
                lblOGPID.Text = frmLookup.VID
                txtOGPCode.Text = frmLookup.VCode
                txtOGPDesc.Text = frmLookup.VName
            End If
            'cmbUom.SelectedValue = frmLookup.UOMID
            'frmLookupCOA.Dispose()
            txtNarration.Focus()
                loadDetGrid()
            End If
    End Sub

    Private Sub loadDetGrid()
        dt = objCommon.GetDataTable("SELECT 0 VID, ProductID,  ProductCode, ProductName,   Qty, Qty - ReturnQty PendingQty, 0 POQty, Packing AS Rate, 0 Amount,DID  FROM ViewGPOutwardReturnableMainDetail WHERE (Qty - ReturnQty) >0 AND VID = " & Setdouble(lblOGPID.Text))
        DataGridView1.Rows.Clear()
        Dim row As String()
        For Each rows As DataRow In dt.Rows
            row = New String() {0, rows("ProductID"), rows("ProductCode"), rows("ProductName"), rows("Qty"), rows("PendingQty"), rows("POQty"), rows("Rate"), rows("Amount"), rows("DID")}
            DataGridView1.Rows.Add(row)
        Next rows
    End Sub


    Private Sub DataGridView1_EditingControlShowing(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles DataGridView1.EditingControlShowing
        If DataGridView1.CurrentCell.ColumnIndex = DataGridView1.Columns("Quantity").Index Then
            AddHandler CType(e.Control, TextBox).KeyPress, AddressOf TextBox_keyPress
        ElseIf DataGridView1.CurrentCell.ColumnIndex = 1 Then
            AddHandler CType(e.Control, TextBox).KeyPress, AddressOf TextBox_keyPress1
        End If
        If DataGridView1.CurrentCell.ColumnIndex = DataGridView1.Columns("VRate").Index Then
            AddHandler CType(e.Control, TextBox).KeyPress, AddressOf TextBox_keyPress1
        ElseIf DataGridView1.CurrentCell.ColumnIndex = 1 Then
            AddHandler CType(e.Control, TextBox).KeyPress, AddressOf TextBox_keyPress1
        End If
    End Sub
    Private Sub TextBox_keyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs)
        If e.KeyChar <> ControlChars.Back Then If Char.IsDigit(CChar(CStr(e.KeyChar))) = False Then e.Handled = True
    End Sub

    Private Sub TextBox_keyPress1(ByVal sender As Object, ByVal e As KeyPressEventArgs)
        If e.KeyChar <> ControlChars.Back Then If Not (Char.IsDigit(CChar(CStr(e.KeyChar))) Or e.KeyChar = ".") Then e.Handled = True
    End Sub

    Private Sub DataGridView1_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellEndEdit
        Dim EQty, VRate, PendingQty As Double
        If e.ColumnIndex = DataGridView1.Columns("Quantity").Index Then
            EQty = Setdouble(DataGridView1.Rows(e.RowIndex).Cells(e.ColumnIndex).Value)
            VRate = Setdouble(DataGridView1.Rows(e.RowIndex).Cells(e.ColumnIndex + 1).Value)
            PendingQty = Setdouble(DataGridView1.Rows(e.RowIndex).Cells("PendingQty").Value)
            If EQty > PendingQty Then
                MessageBox.Show("Qty cannot be greater than Pending Qty.!", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                DataGridView1.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = PendingQty
                EQty = PendingQty
            End If
            DataGridView1.Rows(e.RowIndex).Cells("Amount").Value = EQty * VRate
        ElseIf e.ColumnIndex = DataGridView1.Columns("VRate").Index Then
            EQty = Setdouble(DataGridView1.Rows(e.RowIndex).Cells(e.ColumnIndex - 1).Value)
            VRate = Setdouble(DataGridView1.Rows(e.RowIndex).Cells(e.ColumnIndex).Value)
            PendingQty = Setdouble(DataGridView1.Rows(e.RowIndex).Cells("PendingQty").Value)
            If EQty > PendingQty Then
                MessageBox.Show("Qty cannot be greater than Pending Qty.!", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                DataGridView1.Rows(e.RowIndex).Cells(e.ColumnIndex - 1).Value = PendingQty
                EQty = PendingQty
            End If
            DataGridView1.Rows(e.RowIndex).Cells("Amount").Value = EQty * VRate
        End If
    End Sub

    Private Sub txtMachineCode_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dtpVDate.KeyUp,
      txtOGPCode.KeyUp, txtNarration.KeyUp, txtOGPDesc.KeyUp, txtSupplier.KeyUp, txtVNo.KeyUp
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If 'ijaz
    End Sub 'Pending

    Private Sub btnExcelExport_Click(sender As Object, e As EventArgs) Handles btnExcelExport.Click
        objCommon.ExportToExcel(grdAtt)
    End Sub
End Class