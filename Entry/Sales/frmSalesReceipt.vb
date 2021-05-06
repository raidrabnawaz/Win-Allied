Imports System.Collections.Specialized
Imports System.IO
Imports CrystalDecisions.CrystalReports.Engine

Public Class frmSalesReceipt
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
      objCommon.FillBank(Me.cmbBank)
      'objCommon.FillPaymentTerm(Me.cmbPaymentTerm)
      dtFDateTo.Value = Date.Today
      dtFDateFrom.Value = "01/" & Today.ToString("MM/yyyy")
      Me.lblVID.Text = "0"
      btnSearch_Click(sender, e)
      Me.ActiveControl = dtpVDate
   End Sub

    Private Sub clearHead()
        txtRemarks.Text = String.Empty
        dtpVDate.Value = Date.Today
        'cmbPoType.SelectedValue = -1
        txtAmount.Text = String.Empty
        txtAmount.Text = String.Empty
        txtCustomer.Text = String.Empty
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
            'qryMain = "EXEC SpSaveInvMdnMain " & lblVID.Text & ", '', '" & CDate(dtpVDate.Value).ToString("dd/MMM/yyyy") & "', '" & txtOrderNo.Text & "', " & cmbPoType.SelectedValue
            'qryMain += ", '" & txtOrderNo.Text & "', '" & txtRemarks.Text & "', " & G_Compcode & ", " & G_FinancialYearID & ", " & G_UID & ", '" & G_IPAddress & "', " & G_UID & ",'" & G_IPAddress & "'"

            qryMain = "EXEC SpSave_SaleReceipt " & lblVID.Text & ",'" & txtVNo.Text & "','" & CDate(dtpVDate.Value).ToString("dd/MMM/yyyy") & "','" & lblCustomerID.Text & "','" & txtAmount.Text & "',0,0,0,0,'1/1/1900','-','" & txtRemarks.Text & "','-'," & cmbBank.SelectedValue & "," & G_Compcode & "," & G_UID & ",'" & G_IPAddress & "'," & G_FinancialYearID & "," & G_UID & ",'" & G_IPAddress & "'"
            MID = objCommon.ExecuteScalar(qryMain)
            objCommon.openConnection()
            For Each grid As DataGridViewRow In DataGridView1.Rows
                qryMain = "EXEC SpSave_SaleReceiptDet " & grid.Cells("VID").Value & ", " & MID & ", '" & grid.Cells("InvID").Value & "', " & grid.Cells("Amount").Value & ",0,0,0, " & grid.Cells("Discount").Value & "," & grid.Cells("Extra").Value & ",'" & grid.Cells("Remarks").Value & "', " & G_UID & ", '" & G_IPAddress & "', " & G_UID & ",'" & G_IPAddress & "'"
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
        'lblVID.Text = "0"
    End Sub
    Private Function verifySave() As String
        Dim verify As String = ""
        If DataGridView1.Rows.Count = 0 Then
            verify &= "Must Enter Detail.!" & vbNewLine
            'txtVCode.Focus()
        End If
        Dim Lock As String
        Lock = objCommon.ExecuteScalar("select dbo.fnAllowBackDate('Win-ERP','frmSalesReceipt','" & CDate(dtpVDate.Value).ToString("dd/MMM/yyyy") & "'," & G_UID & "," & G_Compcode & ", " & G_FinancialYearID & ")")

        If Not (Lock = "") Then
            verify = Lock
            Return verify
        End If
        If DataGridView1.Rows.Count = 1 And DataGridView1.Rows(0).Visible = False Then
            verify &= "Must Enter Detail.!" & vbNewLine
            'txtVCode.Focus()
        End If

        For Each grid As DataGridViewRow In DataGridView1.Rows
            If Not Setdouble(grid.Cells("Amount").Value) >= 0 Then
                verify &= "Please Add Some Amount.!" & vbNewLine
            End If
        Next

        If lblCustomerID.Text = "0" Then
            verify &= "Select Customer.!" & vbNewLine
            txtCustomer.Focus()
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
                lblVID.Text = grdAtt.Rows(grdAtt.CurrentCell.RowIndex).Cells("VID").Value
                dt = objCommon.GetDataTable("EXEC SpGetbyIDSaleReceiptMainDetail " & Setdouble(lblVID.Text))
                If dt.Rows.Count > 0 Then
                    lblVID.Text = dt.Rows(0)("VID")
                    txtVNo.Text = dt.Rows(0)("VNo")
                    dtpVDate.Value = dt.Rows(0)("VDate")
                    txtAmount.Text = dt.Rows(0)("HeadAmount")
                    lblCustomerID.Text = dt.Rows(0)("CustomerID")
                    txtCustomer.Text = dt.Rows(0)("CustomerName")
                    cmbBank.SelectedValue = dt.Rows(0)("BankID")
                    'cmbDepartment.SelectedValue = dt.Rows(0)("DepartmentID")
                    'txtRefNo.Text = dt.Rows(0)("RefNo")
                    txtRemarks.Text = dt.Rows(0)("Instructions")

                    DataGridView1.Rows.Clear()
                    For I As Integer = 0 To dt.Rows.Count - 1
                        Dim row As String() = New String() {dt.Rows(I)("DID"), dt.Rows(I)("InvoiceDate"), dt.Rows(I)("InvID"), dt.Rows(I)("Invoiceno"), dt.Rows(I)("CurrencyID"), dt.Rows(I)("CurrencyCode"), dt.Rows(I)("InvoiceAmount"), dt.Rows(I)("CollectedAmount"), dt.Rows(I)("InvoiceAmount") - dt.Rows(I)("CollectedAmount"), dt.Rows(I)("DetAmount"), dt.Rows(I)("Discount"), dt.Rows(I)("DetExtra"), dt.Rows(I)("DetInstruction")}
                        DataGridView1.Rows.Add(row)
                    Next
                End If
            End If
        End If
    End Sub



    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
      'Dim cWhere As String = " WHERE VDATE between '" & Convert.ToDateTime(dtFDateFrom.Value).ToString("dd/MMM/yyyy") & "' AND '" & Convert.ToDateTime(dtFDateTo.Value).ToString("dd/MMM/yyyy") & "' AND FinancialYearID = " & G_FinancialYearID
        'If Not txtFVNo.Text = "" Then cWhere &= " AND VNo='" & txtFVNo.Text & "' "
        'If Not cmbFVtype.SelectedValue = "-1" Then cWhere &= " AND VType='" & cmbFVtype.SelectedValue & "' "
        'If Not txtFRemarks.Text = "" Then cWhere &= " AND Remarks like '%" & txtRemarks.Text & "%' "
        qryMain = "Exec SpGetByShow_SaleReceipt " & G_Compcode & ""
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
        

        'Dim MyReportViewer As ReportViewer = New ReportViewer
      'MyReportViewer.dtrpt = dtrpt
      'MyReportViewer.MyListDic = MyListDic
      'MyReportViewer.rtp = rpt
        'MyReportViewer.MdiParent = EMSMain
        'MyReportViewer.Show()

    End Sub



    'Private Sub cmdDelete_Click(sender As System.Object, e As System.EventArgs) Handles cmdDelete.Click
    '    qryMain = " delete from tblAcJVDet where MId = " & lblVID.Text & " ; delete from tblAcJVHead where VId = " & lblVID.Text & " ; "
    '    objCommon.ExecuteNonQuery(qryMain)
    '    MessageBox.Show("Voucher removed Successfully ", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '    clearHead()
    '    DataGridView1.Rows.Clear()
    '    btnSearch_Click(sender, e)
    '    'txtVNo.Focus()
    'End Sub

    Private Sub TxtMDNNo_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCustomer.KeyDown
        If e.KeyCode = Keys.F2 Then
            frmLookup.LookupQuery = "SELECT VID,VCode,VName,Email,Phone from SaleCustomer"
         frmLookup.LookupName = "SalesCustomer"
         frmLookup.VID = ""
         frmLookup.VCode = ""
         frmLookup.VName = ""
            frmLookup.ShowDialog()
            If frmLookup.VID <> "" Then
                lblCustomerID.Text = frmLookup.VID
                txtCustomer.Text = frmLookup.VName
            End If
            'frmLookupCOA.Dispose()
            txtAmount.Focus()
                loadDetGrid()
            End If
    End Sub

    Private Sub DataGridView1_EditingControlShowing(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles DataGridView1.EditingControlShowing
        If DataGridView1.CurrentCell.ColumnIndex = DataGridView1.Columns("Amount").Index Then
            AddHandler CType(e.Control, TextBox).KeyPress, AddressOf TextBox_keyPress1

        ElseIf DataGridView1.CurrentCell.ColumnIndex = DataGridView1.Columns("Discount").Index Then
            AddHandler CType(e.Control, TextBox).KeyPress, AddressOf TextBox_keyPress1

        ElseIf DataGridView1.CurrentCell.ColumnIndex = DataGridView1.Columns("Extra").Index Then
            AddHandler CType(e.Control, TextBox).KeyPress, AddressOf TextBox_keyPress1

            'ElseIf DataGridView1.CurrentCell.ColumnIndex = DataGridView1.Columns("Remarks").Index Then
            '    AddHandler CType(e.Control, TextBox).KeyPress, AddressOf TextBox_keyPress3
        End If
    End Sub
    Private Sub TextBox_keyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs)
        'If e.KeyChar <> ControlChars.Back Then If Char.IsDigit(CChar(CStr(e.KeyChar))) = False Then e.Handled = True
        If (Not Char.IsControl(e.KeyChar) _
             AndAlso (Not Char.IsDigit(e.KeyChar) _
             AndAlso (e.KeyChar <> Microsoft.VisualBasic.ChrW(46)))) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox_keyPress1(ByVal sender As Object, ByVal e As KeyPressEventArgs)
        'If e.KeyChar <> ControlChars.Back Then If Not (Char.IsDigit(CChar(CStr(e.KeyChar))) Or e.KeyChar = ".") Then e.Handled = True
        If (Not Char.IsControl(e.KeyChar) _
             AndAlso (Not Char.IsDigit(e.KeyChar) _
             AndAlso (e.KeyChar <> Microsoft.VisualBasic.ChrW(46)))) Then
            e.Handled = True
        End If
    End Sub
    Private Sub TextBox_keyPress3(ByVal sender As Object, ByVal e As KeyPressEventArgs)
        'If e.KeyChar <> ControlChars.Back Then If Not (Char.IsDigit(CChar(CStr(e.KeyChar))) Or e.KeyChar = ".") Then e.Handled = True
    End Sub



    Private Sub DataGridView1_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellEndEdit
        Dim EQty, Extra, PendingQty, Discount As Double
        If e.ColumnIndex = DataGridView1.Columns("Amount").Index Then
            EQty = Setdouble(DataGridView1.Rows(e.RowIndex).Cells(e.ColumnIndex).Value)
            'VRate = Setdouble(DataGridView1.Rows(e.RowIndex).Cells(e.ColumnIndex + 1).Value)
            'SaleTaxPer = Setdouble(DataGridView1.Rows(e.RowIndex).Cells("SaleTaxPer").Value)
            PendingQty = Setdouble(DataGridView1.Rows(e.RowIndex).Cells("P_Amount").Value)
            If EQty > PendingQty Then
                MessageBox.Show("Amount cannot be greater than Pending Amount.!", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                DataGridView1.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = PendingQty
                EQty = PendingQty
            End If
            'DataGridView1.Rows(e.RowIndex).Cells("Amount").Value = EQty * VRate
            'DataGridView1.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = EQty
            'DataGridView1.Rows(e.RowIndex).Cells(e.ColumnIndex + 1).Value = VRate
            'DataGridView1.Rows(e.RowIndex).Cells("SaleTaxValue").Value = (Setdouble(DataGridView1.Rows(e.RowIndex).Cells("Amount").Value) * SaleTaxPer) / 100
            'ElseIf e.ColumnIndex = DataGridView1.Columns("VRate").Index Then
            '    EQty = Setdouble(DataGridView1.Rows(e.RowIndex).Cells(e.ColumnIndex - 1).Value)
            '    VRate = Setdouble(DataGridView1.Rows(e.RowIndex).Cells(e.ColumnIndex).Value)
            '    SaleTaxPer = Setdouble(DataGridView1.Rows(e.RowIndex).Cells("SaleTaxPer").Value)
            '    PendingQty = Setdouble(DataGridView1.Rows(e.RowIndex).Cells("PendingQty").Value)
            If EQty > PendingQty Then
                MessageBox.Show("Amount cannot be greater than Pending Amount.!", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                DataGridView1.Rows(e.RowIndex).Cells(e.ColumnIndex - 1).Value = PendingQty
                EQty = PendingQty
            End If
            'DataGridView1.Rows(e.RowIndex).Cells("Amount").Value = EQty * VRate
            'DataGridView1.Rows(e.RowIndex).Cells(e.ColumnIndex - 1).Value = EQty
            'DataGridView1.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = VRate
            '    DataGridView1.Rows(e.RowIndex).Cells("SaleTaxValue").Value = (Setdouble(DataGridView1.Rows(e.RowIndex).Cells("Amount").Value) * SaleTaxPer) / 100
            'ElseIf e.ColumnIndex = DataGridView1.Columns("SaleTaxPer").Index Then
            '    SaleTaxPer = Setdouble(DataGridView1.Rows(e.RowIndex).Cells("SaleTaxPer").Value)
            '    DataGridView1.Rows(e.RowIndex).Cells("SaleTaxValue").Value = (Setdouble(DataGridView1.Rows(e.RowIndex).Cells("Amount").Value) * SaleTaxPer) / 100
        End If
    End Sub
    'dt.Rows(I)("UomID"), dt.Rows(I)("VCode"), dt.Rows(I)("ProductName"), dt.Rows(I)("UOM"), dt.Rows(I)("MDNQty"), dt.Rows(I)("Qty")

    Private Sub loadDetGrid()
        dt = objCommon.GetDataTable("EXEC SpGetCustomerInvocies " & Setdouble(lblCustomerID.Text))
        Dim row As String()
        For Each rows As DataRow In dt.Rows
            row = New String() {0, rows("VDate"), rows("VID"), rows("InvoiceNo"), rows("CurrencyID"), rows("CurrencyName"), rows("GrandTotal"), rows("CollectedAmount"), rows("GrandTotal") - rows("CollectedAmount"), 0, 0, 0, rows("Remarks")}
            DataGridView1.Rows.Add(row)
        Next rows
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If DataGridView1.Rows.Count > 0 Then
            index = e.RowIndex
            If e.ColumnIndex = DataGridView1.Columns("DEL").Index Then
                'Exit Sub
                DataGridView1.Rows(index).Visible = False
                DataGridView1.Rows(index).Cells("IsDel").Value = 1
                Exit Sub
            End If
        End If
    End Sub

End Class