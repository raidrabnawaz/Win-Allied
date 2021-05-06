Imports System
Imports System.Collections.Generic
Imports System.Collections
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports System.Collections.Specialized
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports System.Configuration
Imports System.Data.SqlClient
Imports System.IO


Public Class frmProdWagesReports
    Dim qryMain As String
    Dim objCommon As New clsCommon
    Dim MyListDic As New ListDictionary
    Dim ReportFilePath As String = ""
    Dim ReportTitle As String = ""
    Dim FilterDateOpen As String = ""
    Dim FilterDate As String = ""
    Dim FilterCode As String = ""
    Dim FilterOrder As String = ""
    Dim FilterRemarks As String = ""
    Dim FilterPosted As String = ""

    Dim rpt As New ReportClass
    Dim FilterDateOpenProdMW As String = ""
    Dim FilterDateProdMW As String = ""
    Dim FilterCodeProdMW As String = ""
    Dim FilterRemarksProdMW As String = ""
    Dim ReportSpName As String = ""
    Dim dtrpt As DataTable
    Dim rptName As String = ""

    Private Sub frmRptAttDaily_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        dtpDateFrom.Value = "01/" & Today.ToString("MM/yyyy")
        dtpDateTo.Value = Today.ToString("dd/MMM/yyyy")
        objCommon.FillProdWagesMonth(Me.cmbWagesMonth)

    End Sub
    Private Sub cmdSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSearch.Click
        MyListDic.Clear()
        ReportFilePath = ""
        ReportTitle = ""
        '----------------------------------------------------------------------------------------------------------------------
        Dim mydateFrom As Date = dtpDateFrom.Value.ToString("dd/MMM/yyyy")
        Dim mydateTo As Date = dtpDateTo.Value.ToString("dd/MMM/yyyy")
        FilterDateOpen = " and VDate < '" & mydateFrom.ToString("dd/MMM/yyyy") & "' "
        FilterDate = " and SO.VDate between '" & mydateFrom.ToString("dd/MMM/yyyy") & "' and '" & mydateTo.ToString("dd/MMM/yyyy") & "' "

        FilterDateOpenProdMW = " and VDate < '" & mydateFrom.ToString("dd/MMM/yyyy") & "' "
        FilterDateProdMW = " and VDate between '" & mydateFrom.ToString("dd/MMM/yyyy") & "' and '" & mydateTo.ToString("dd/MMM/yyyy") & "' "
        '----------------------------------------------------------------------------------------------------------------------
        Dim mycodefrom, mycodeto As String
        txtCodeFrom.Text = txtCodeFrom.Text.Trim
        txtCodeTo.Text = txtCodeTo.Text.Trim
        mycodefrom = txtCodeFrom.Text
        mycodeto = txtCodeTo.Text
        If mycodefrom <> "" Then
            If mycodeto = "" Then
                txtCodeTo.Text = mycodefrom
                mycodeto = txtCodeTo.Text
            End If
        End If
        'If mycodefrom.Length <> 7 Then
        '    mycodefrom = mycodefrom & "0000000"
        '    mycodefrom = mycodefrom.Substring(0, 7)
        'End If
        'If mycodeto.Length <> 7 Then
        '    mycodeto = mycodeto & "9999999"
        '    mycodeto = mycodeto.Substring(0, 7)
        'End If
        If lblPID.Text <> "" Then
            FilterCode = " and E.EmployeeID = " & lblPID.Text & " "
            'FilterCodeProdMW = " and SupplierCode between '" & mycodefrom & "' and '" & mycodeto & "' "
        End If
        If lblOrderID.Text <> "" Then
            FilterOrder = " and SO.VID = " & lblOrderID.Text & " "
            'FilterCodeProdMW = " and SupplierCode between '" & mycodefrom & "' and '" & mycodeto & "' "
        End If
        '----------------------------------------------------------------------------------------------------------------------
        'FilterRemarks = " and Narration like '%" & txtEmpName.Text.Trim & "%' "
        'FilterRemarksProdMW = " and Narration like '%" & txtEmpName.Text.Trim & "%' "
        '----------------------------------------------------------------------------------------------------------------------
        '----------------------------------------------------------------------------------------------------------------------
        If optOrderWorkDetail.Checked Then
            'ReportFilePath = "rptGeneralLedger.rpt"

            rptName = "rptOrderWiseWages"
            ReportTitle = "Order Wise Work Detail" & dtpDateFrom.Value.ToString("dd/MM/yyyy") & " To " & dtpDateTo.Value.ToString("dd/MM/yyyy")
        ElseIf optWorkerWages.Checked Then
            'ReportFilePath = "rptGeneralLedger.rpt"

            rptName = "rptOrderWiseOpList"
            ReportTitle = "General Ledger From " & dtpDateFrom.Value.ToString("dd/MM/yyyy") & " To " & dtpDateTo.Value.ToString("dd/MM/yyyy")
        ElseIf optOperationsRateList.Checked Then
            'ReportFilePath = "rptGeneralLedger.rpt"
            rptName = "rptOperationRateFix"
            ReportTitle = "General Ledger From " & dtpDateFrom.Value.ToString("dd/MM/yyyy") & " To " & dtpDateTo.Value.ToString("dd/MM/yyyy")
        ElseIf optWagesSheet.Checked Then
            rptName = "rptWagesSheet"
            'ReportFilePath = Path.Combine(Directory.GetCurrentDirectory(), "Reports\rptSupplierAnalysis.rpt")
            ReportTitle = "Trial From Wages Sheet " & dtpDateFrom.Value.ToString("dd/MM/yyyy") & " To " & dtpDateTo.Value.ToString("dd/MM/yyyy")
        ElseIf optDemandRequisition.Checked Then
            rptName = "rptDemandRequisitionMonthWise"
            'ReportFilePath = Path.Combine(Directory.GetCurrentDirectory(), "Reports\rptSupplierAnalysis.rpt")
            ReportTitle = "Demand Requisition From " & dtpDateFrom.Value.ToString("dd/MM/yyyy") & " To " & dtpDateTo.Value.ToString("dd/MM/yyyy")
        ElseIf optPosted.Checked Then

            FilterPosted = " And IsPosted = 1 "

            'ReportFilePath = "rptSaleRegister.rpt"
            'FilterCode = FilterCode + " and H.VType = 'Sales' and H.Debit > 0  "
            'ReportTitle = "Sale Register From " & dtpDateFrom.Value.ToString("dd/MM/yyyy") & " To " & dtpDateTo.Value.ToString("dd/MM/yyyy")
        ElseIf optUnPosted.Checked Then

            FilterPosted = " AND IsPosted = 0 "

            'ReportFilePath = "rptSaleDW.rpt"
            '    FilterCode = FilterCode + " and H.VType = 'Sales' and H.Debit > 0  "
            '    ReportTitle = "Sale Report (Date Wise) From " & dtpDateFrom.Value.ToString("dd/MM/yyyy") & " To " & dtpDateTo.Value.ToString("dd/MM/yyyy")
            'ElseIf optProduction.Checked Then
            '        ReportFilePath = "rptProd.rpt"
            '        FilterCode = FilterCode + " and H.VType = 'Prod' and H.Debit > 0   "
            '        ReportTitle = "Production Report From " & dtpDateFrom.Value.ToString("dd/MM/yyyy") & " To " & dtpDateTo.Value.ToString("dd/MM/yyyy")
            '    ElseIf optProductionDW.Checked Then
            '        ReportFilePath = "rptProdDW.rpt"
            '        FilterCodeProdMW = FilterCodeProdMW + " and H.VType = 'Prod' and H.Debit > 0 "
            '        ReportTitle = "Production Report (Date Wise) From " & dtpDateFrom.Value.ToString("dd/MM/yyyy") & " To " & dtpDateTo.Value.ToString("dd/MM/yyyy")
            '        FilterDateOpen = FilterDateOpenProdMW
            '        FilterDate = FilterDateProdMW
            '        FilterCode = FilterCodeProdMW
            '        FilterRemarks = FilterRemarksProdMW
            '    ElseIf optExpanseMW.Checked Then
            '        ReportFilePath = "rptExpanseMW.rpt"
            '        FilterCode = FilterCode + " and H.VCode like '13%' "
            '        ReportTitle = "Expanse Report (Month Wise) From " & dtpDateFrom.Value.ToString("dd/MM/yyyy") & " To " & dtpDateTo.Value.ToString("dd/MM/yyyy")
            '    ElseIf optReceivableBalance.Checked Then
            '        ReportFilePath = "rptReceivableBalance.rpt"
            '    FilterCode = FilterCode + " and H.VCode like '0502%'  "
            '    ReportTitle = "Receivable Balance Report From " & dtpDateFrom.Value.ToString("dd/MM/yyyy") & " To " & dtpDateTo.Value.ToString("dd/MM/yyyy")

        End If

        If txtTitle.Text.Trim <> "" Then
            ReportTitle = txtTitle.Text.Trim
        End If

        rpt = (WinReportsApplication.Classess.WagesReports.SetReportName(rptName))


        'MyListDic.Add("@CWhereOpen", " where 1=1  " & FilterDateOpen & FilterCode)
        'MyListDic.Add("@isCurrent", "1")


        If optWorkerWages.Checked Then
            MyListDic.Add("@CWhere", " where 1=1  " & FilterCode & FilterOrder & FilterDate)
            ReportSpName = "spRptProdOrderWiseEmpWages"
            dtrpt = objCommon.GetDataTableSPPrm(ReportSpName, MyListDic)

            MyListDic.Add("dDateFrom", dtpDateFrom.Value.ToString("dd/MM/yyyy"))
            MyListDic.Add("dDateTo", dtpDateTo.Value.ToString("dd/MM/yyyy"))
            MyListDic.Add("ItemFrom", txtCodeFrom.Text)
            MyListDic.Add("ItemTo", txtCodeTo.Text)

            MyListDic.Add("cGroupofCompany", G_CompName)
            MyListDic.Add("ReportTitle", "Wages of Worker")

        ElseIf optOrderWorkDetail.Checked Then
            MyListDic.Add("@CWhere", " where 1=1  " & FilterCode & FilterOrder & FilterDate)
            ReportSpName = "spRptProdOrderWiseWages"
            dtrpt = objCommon.GetDataTableSPPrm(ReportSpName, MyListDic)

            MyListDic.Add("dDateFrom", dtpDateFrom.Value.ToString("dd/MM/yyyy"))
            MyListDic.Add("dDateTo", dtpDateTo.Value.ToString("dd/MM/yyyy"))
            MyListDic.Add("ItemFrom", txtCodeFrom.Text)
            MyListDic.Add("ItemTo", txtCodeTo.Text)

            MyListDic.Add("cGroupofCompany", G_CompName)
            MyListDic.Add("ReportTitle", "Order Wise Wages Sheet")


        ElseIf optWagesSheet.Checked Then
            MyListDic.Add("@OrderID", Setdouble(lblOrderID.Text))
            MyListDic.Add("@MonthID", cmbWagesMonth.SelectedValue)
            MyListDic.Add("@CompanyID", G_Compcode)
            MyListDic.Add("@CWhere", " where 1=1  " & FilterOrder & FilterDate)
            ReportSpName = "SpRptProdWagesSheet"
            dtrpt = objCommon.GetDataTableSPPrm(ReportSpName, MyListDic)

            MyListDic.Add("dDateFrom", dtpDateFrom.Value.ToString("dd/MM/yyyy"))
            MyListDic.Add("dDateTo", dtpDateTo.Value.ToString("dd/MM/yyyy"))
            MyListDic.Add("ItemFrom", txtCodeFrom.Text)
            MyListDic.Add("ItemTo", txtCodeTo.Text)

            MyListDic.Add("cGroupofCompany", G_CompName)
            MyListDic.Add("ReportTitle", "Wages Sheet")

            'MyListDic.Add("cGroupofCompany", G_CompName)
            'MyListDic.Add("ReportTitle", "Supplier Analysis")
        ElseIf optOperationsRateList.Checked Then
            MyListDic.Add("@CWhere", " where 1=1  " & FilterOrder & FilterDate)
            ReportSpName = "spRptProdFixOperationList"
            dtrpt = objCommon.GetDataTableSPPrm(ReportSpName, MyListDic)

            MyListDic.Add("dDateFrom", dtpDateFrom.Value.ToString("dd/MM/yyyy"))
            MyListDic.Add("dDateTo", dtpDateTo.Value.ToString("dd/MM/yyyy"))
            MyListDic.Add("ItemFrom", txtCodeFrom.Text)
            MyListDic.Add("ItemTo", txtCodeTo.Text)

            MyListDic.Add("cGroupofCompany", G_CompName)
            MyListDic.Add("ReportTitle", "Operation Rate List")

        ElseIf optDemandRequisition.Checked Then
            MyListDic.Add("@OrderID", Setdouble(lblOrderID.Text))
            MyListDic.Add("@MonthID", cmbWagesMonth.SelectedValue)
            MyListDic.Add("@CompanyID", G_Compcode)
            MyListDic.Add("@CWhere", " where 1=1  " & FilterOrder & FilterDate)
            ReportSpName = "SpRptProdWagesDemandRequisition"
            dtrpt = objCommon.GetDataTableSPPrm(ReportSpName, MyListDic)

            MyListDic.Add("dDateFrom", dtpDateFrom.Value.ToString("dd/MM/yyyy"))
            MyListDic.Add("dDateTo", dtpDateTo.Value.ToString("dd/MM/yyyy"))
            'MyListDic.Add("ItemFrom", txtCodeFrom.Text)
            'MyListDic.Add("ItemTo", txtCodeTo.Text)

            MyListDic.Add("cGroupofCompany", G_CompName)
            MyListDic.Add("ReportTitle", "Demand Requisition Report")

        End If


        'MyListDic.Add("ReportTitle", ReportTitle)
        Dim MyReportViewer As ReportViewer = New ReportViewer
        MyReportViewer.dtrpt = dtrpt
        MyReportViewer.MyListDic = MyListDic
        MyReportViewer.rtp = rpt
        MyReportViewer.MdiParent = EMSMain
        MyReportViewer.Show()

    End Sub
    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub
    Private Sub txtVName_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtEmpName.KeyDown
        If e.KeyCode = Keys.F2 Then
            frmLookup.LookupQuery = "Select EmployeeID as VID,FileNo as VCode,EmployeeNameDisplay as VName from ViewEMSEmployee"
            frmLookup.LookupName = "Employee"
            frmLookup.VID = ""
            frmLookup.VCode = ""
            frmLookup.VName = ""
            frmLookup.ShowDialog()
            If frmLookup.VID <> "" Then
                txtCodeTo.Text = ""
                lblPID.Text = frmLookup.VID
                txtCodeFrom.Text = frmLookup.VCode
                txtEmpName.Text = frmLookup.VName
            End If
            'frmLookupCOA.Dispose()
            txtEmpName.Focus()
        End If
    End Sub
    Private Sub txtCodeTo_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCodeTo.KeyDown
        If e.KeyCode = Keys.F2 Then
            frmLookupCOA.ETypeID = "Report"
            frmLookupCOA.VCodeIni = txtCodeTo.Text.Trim
            frmLookupCOA.VCode = ""
            frmLookupCOA.VName = ""
            frmLookupCOA.ShowDialog()
            If frmLookupCOA.VCode <> "" Then
                txtCodeTo.Text = frmLookupCOA.VCode
                txtAccTitleTo.Text = frmLookupCOA.VName
            End If
            frmLookupCOA.Dispose()
        End If
    End Sub

    Private Sub txtSaleOrderName_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtSaleOrderName.KeyDown
        If e.KeyCode = Keys.F2 Then
            frmLookup.LookupQuery = "SELECT VID,'('+VNo+') '+ VName AS VName,VNo as VCode FROM ProdSaleOrder"
            frmLookup.LookupName = "Sale Order"
            frmLookup.VID = ""
            frmLookup.VCode = ""
            frmLookup.VName = ""
            frmLookup.ShowDialog()
            If frmLookup.VID <> "" Then
                txtCodeTo.Text = ""
                lblOrderID.Text = frmLookup.VID
                txtOrderCode.Text = frmLookup.VCode
                txtSaleOrderName.Text = frmLookup.VName
            End If
            'frmLookupCOA.Dispose()
            txtSaleOrderName.Focus()
        End If
    End Sub

    Private Sub cmbWagesMonth_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbWagesMonth.SelectedIndexChanged
        If cmbWagesMonth.SelectedIndex > 0 Then
            qryMain = "EXEC SpGetbyID_ProdWagesMonth " & cmbWagesMonth.SelectedValue.ToString & ""
            Dim dt As DataTable = objCommon.GetDataTable(qryMain)
            If IsNothing(dt) Then
                'EmptyFields()
                Return
            End If
            If dt.Rows.Count <= 0 Then
                'EmptyFields()
                Return
            End If
            Dim dr As DataRow = dt.Rows(0)
            dtpDateFrom.Value = dr("VDateFrom")
            dtpDateTo.Value = dr("VDateTo")
        End If
    End Sub
End Class