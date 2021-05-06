Imports System.Collections.Specialized
Imports System.IO
Imports CrystalDecisions.CrystalReports.Engine
 

Public Class frmInvGRNReturn
    Dim index As Integer = -1
    Dim objCommon As New clsCommon
    Dim dt As New DataTable
    Dim qryMain As String
   Dim action As Char = Convert.ToChar("I")

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
      dtFDateTo.Value = Date.Today
      dtFDateFrom.Value = Convert.ToDateTime("01/" & Today.ToString("MM/yyyy"))
      Me.lblVID.Text = "0"
      btnSearch_Click(sender, e)
      Me.ActiveControl = dtpVDate
   End Sub

    Private Sub clearHead()
        txtRemarks.Text = String.Empty
        dtpVDate.Value = Date.Today
        'cmbPoType.SelectedValue = -1
        txtOrderNo.Text = String.Empty
        txtOrderNo.Text = String.Empty
        txtFRemarks.Text = String.Empty
        txtVNo.Text = String.Empty
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

            Dim MID As Integer = 0
            qryMain = "EXEC SpSaveInvGrnReturnMain " & lblVID.Text & ", '', " & lblIGPID.Text & ", '" & CDate(dtpVDate.Value).ToString("dd/MMM/yyyy") & "', '" & txtOrderNo.Text & "', '" & txtRemarks.Text & "', '" & txtNarration.Text
            qryMain += "', " & G_Compcode & ", " & G_FinancialYearID & ", " & G_UID & ", '" & G_IPAddress & "', " & G_UID & ",'" & G_IPAddress & "'"
         MID = Convert.ToInt32(objCommon.ExecuteScalar(qryMain))
            objCommon.openConnection()
            For Each grid As DataGridViewRow In DataGridView1.Rows
                If Setdouble(grid.Cells("Quantity").Value.ToString()) > 0 Then
                    qryMain = "EXEC SpSaveInvGrnReturnDetail " & grid.Cells("VID").Value.ToString() & ", " & MID & ", '" & grid.Cells("ProductID").Value.ToString() & "', " & grid.Cells("UomID").Value.ToString() & ", " & grid.Cells("Quantity").Value.ToString() & ", " & grid.Cells("VTypePk").Value.ToString() & ", " & G_UID & ", '" & G_IPAddress & "', " & G_UID & ",'" & G_IPAddress & "', " & If(grid.Cells("IsDel").Value = "", 0, 1)
                    objCommon.ExecuteNonQueryWithOpen(qryMain)
                End If
            Next
            objCommon.CloseConnection()
            MessageBox.Show("Voucher Successfully Save", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
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
        For Each grid As DataGridViewRow In DataGridView1.Rows
         If Not Setdouble(grid.Cells("Quantity").Value.ToString()) > 0 Then
            verify &= "Please Add Some Qunatity.!" & vbNewLine
         End If
        Next

        Dim Lock As String
        Lock = objCommon.ExecuteScalar("select dbo.fnAllowBackDate('Win-ERP','frmInvGRNReturn','" & CDate(dtpVDate.Value).ToString("dd/MMM/yyyy") & "'," & G_UID & "," & G_Compcode & ", " & G_FinancialYearID & ")")

        If Not (Lock = "") Then
            verify = Lock
            Return verify
        End If
        If DataGridView1.Rows.Count = 1 And DataGridView1.Rows(0).Visible = False Then
            verify &= "Must Enter Detail.!" & vbNewLine
            'txtVCode.Focus()
        End If

        If lblIGPID.Text = "-1" Then
            verify &= "Select Valid IGP No" & vbNewLine
            txtIGPNo.Focus()
        End If

        Return verify
    End Function
    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        Dim cWhere As String = " WHERE VDATE between ''" & Convert.ToDateTime(dtFDateFrom.Value).ToString("dd/MMM/yyyy") & "'' AND ''" & Convert.ToDateTime(dtFDateTo.Value).ToString("dd/MMM/yyyy") & "'' "
        If Not txtFVNo.Text = "" Then cWhere &= " AND VNo like ''%" & txtFVNo.Text & "%'' "
        'If Not cmbFVtype.SelectedValue = "-1" Then cWhere &= " AND VType='" & cmbFVtype.SelectedValue & "' "
        If Not txtFRemarks.Text = "" Then cWhere &= " AND Remarks like ''%" & txtFRemarks.Text & "%'' "
        qryMain = "EXEC SpGetInvSearchLookUp 'GRNReturn', @CWhere='" & cWhere & "' "
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

    Private Sub cmdPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrint.Click    ''pending
        MyListDic.Clear()
      rpt = (WinReportsApplication.Classess.InventoryReport.SetReportName("rfGoodsReceiptNoteReturn"))
        'ReportFilePath = Path.Combine(Directory.GetCurrentDirectory(), "Reports\CrystalReport2.rpt")
        FilterVTypeList = ""
        FilterDate = ""
        ReportTitle = ""
        MyListDic.Add("@VID", lblVID.Text)
      ReportSpName = "SpRptInvGRNReturn"
      dtrpt = objCommon.GetDataTableSPPrm(ReportSpName, MyListDic)

      MyListDic.Add("PrintedBy", G_Userlogin)
        MyListDic.Add("off_Name", G_UID)
        MyListDic.Add("comp_Name", G_CompName)


        'MyListDic.Add("@cWhere", " where AH.VId = " & lblVID.Text)


        Dim MyReportViewer As ReportViewer = New ReportViewer
      MyReportViewer.dtrpt = dtrpt
      MyReportViewer.MyListDic = MyListDic
      MyReportViewer.rtp = rpt
        MyReportViewer.MdiParent = EMSMain
        MyReportViewer.Show()

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

    Private Sub TxtIGPNo_KeyDown(sender As Object, e As KeyEventArgs) Handles txtIGPNo.KeyDown
      If e.KeyCode = Keys.F2 Then
         frmLookup.LookupQuery = "SELECT VID, VDate, VNo,Remarks,ProductName FROM ViewInvGRNMainDetail WHERE (Qty - ReturnQty) > 0"
         frmLookup.LookupName = "Pending GRN Return "
         frmLookup.VID = ""
         frmLookup.VCode = ""
         frmLookup.VName = ""
         frmLookup.ShowDialog()
         If frmLookup.VID <> "" Then
            lblIGPID.Text = frmLookup.VID
            txtIGPNo.Text = frmLookup.VName
         End If
         'frmLookupCOA.Dispose()
         DataGridView1.Rows.Clear()
         dtpVDate.Focus()
         loadDetGrid()
      End If
    End Sub
    Private Sub loadDetGrid()
        dt = objCommon.GetDataTable("SELECT 0 VID, ProductID, UomID, VCode, ProductName,  UOM, Qty POQty, Qty - UsedQty PendingQty, 0 IGPQty, UsedQty, DID  FROM ViewInvGRNMainDetail WHERE (Qty - ReturnQty) >0 AND VID = " & Setdouble(lblIGPID.Text))
        Dim row As String()
        For Each rows As DataRow In dt.Rows
         row = New String() {"0", rows("ProductID").ToString(), rows("UomID").ToString(), rows("VCode").ToString(), rows("ProductName").ToString(), rows("UOM").ToString(), rows("POQty").ToString(), rows("PendingQty").ToString(), rows("IGPQty").ToString(), rows("DID").ToString()}
            DataGridView1.Rows.Add(row)
        Next rows
    End Sub
    Private Sub DataGridView1_EditingControlShowing(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles DataGridView1.EditingControlShowing
        If DataGridView1.CurrentCell.ColumnIndex = DataGridView1.Columns("Quantity").Index Then
            AddHandler CType(e.Control, TextBox).KeyPress, AddressOf TextBox_keyPress
        ElseIf DataGridView1.CurrentCell.ColumnIndex = 1 Then
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
    Private Sub DataGridView1_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellEndEdit
        Dim EQty, PendingQty As Double
        If e.ColumnIndex = DataGridView1.Columns("Quantity").Index Then
         EQty = Setdouble(DataGridView1.Rows(e.RowIndex).Cells(e.ColumnIndex).Value.ToString())
         PendingQty = Setdouble(DataGridView1.Rows(e.RowIndex).Cells("PendingQty").Value.ToString())
            If EQty > PendingQty Then
                MessageBox.Show("GRN Qty cannot be greater than Pending Qty.!", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                DataGridView1.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = PendingQty
                EQty = PendingQty
            End If
            DataGridView1.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = EQty
        End If
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If DataGridView1.Rows.Count > 0 Then
            index = e.RowIndex
            If e.ColumnIndex = DataGridView1.Columns("DEL").Index Then
                DataGridView1.Rows(index).Visible = False
                DataGridView1.Rows(index).Cells("IsDel").Value = 1
                DataGridView1.Rows(index).Cells("Quantity").Value = 0
                Exit Sub
            End If
        End If
    End Sub

    Private Sub GrdAtt_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles grdAtt.CellClick
        If grdAtt.Rows.Count > 0 Then
            If grdAtt.RowCount > -1 Then
                Me.TabMain.SelectedTab = TabPage1
            lblVID.Text = grdAtt.Rows(grdAtt.CurrentCell.RowIndex).Cells("VID").Value.ToString()
                dt = objCommon.GetDataTable("EXEC SpGetInvGRNReturnMainDetail " & Setdouble(lblVID.Text))
                If dt.Rows.Count > 0 Then
               lblVID.Text = dt.Rows(0)("VID").ToString()
               txtVNo.Text = dt.Rows(0)("VNo").ToString()
               dtpVDate.Value = Convert.ToDateTime(dt.Rows(0)("VDate"))
               txtIGPNo.Text = dt.Rows(0)("GRNNo").ToString()
               lblIGPID.Text = dt.Rows(0)("GRNID").ToString()
               txtOrderNo.Text = dt.Rows(0)("OrderNo").ToString()
               txtRemarks.Text = dt.Rows(0)("Remarks").ToString()
               txtNarration.Text = dt.Rows(0)("Narration").ToString()
                    DataGridView1.Rows.Clear()
                    For I As Integer = 0 To dt.Rows.Count - 1
                  Dim row As String() = New String() {dt.Rows(I)("DID").ToString(), dt.Rows(I)("ProductID").ToString(), dt.Rows(I)("UomID").ToString(), dt.Rows(I)("VCode").ToString(), dt.Rows(I)("ProductName").ToString(), dt.Rows(I)("UOM").ToString(), dt.Rows(I)("GRNQty").ToString(), Math.Round(Decimal.Parse(dt.Rows(I)("PendingQty")), 2).ToString(), Math.Round(Decimal.Parse(dt.Rows(I)("Qty")), 2).ToString(), dt.Rows(I)("VtypePk").ToString()}
                        DataGridView1.Rows.Add(row)
                    Next
                End If
            End If
        End If
   End Sub

    Private Sub txtMachineCode_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dtpVDate.KeyUp,
      txtOrderNo.KeyUp, txtNarration.KeyUp, txtRemarks.KeyUp, txtIGPNo.KeyUp
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If 'ijaz
    End Sub 'Pending

    Private Sub btnExcelExport_Click(sender As Object, e As EventArgs) Handles btnExcelExport.Click
        objCommon.ExportToExcel(grdAtt)
    End Sub
End Class