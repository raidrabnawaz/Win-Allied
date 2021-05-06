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


Public Class frmInvVendorReports
   Dim qryMain As String
   Dim objCommon As New clsCommon
   Dim MyListDic As New ListDictionary
   Dim ReportFilePath As String = ""
   Dim ReportTitle As String = ""
   Dim FilterDateOpen As String = ""
   Dim FilterDate As String = ""
   Dim FilterCode As String = ""
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


   End Sub
   Private Sub cmdSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSearch.Click
      MyListDic.Clear()
      ReportFilePath = ""
      ReportTitle = ""
      '----------------------------------------------------------------------------------------------------------------------
      Dim mydateFrom As Date = dtpDateFrom.Value.ToString("dd/MMM/yyyy")
      Dim mydateTo As Date = dtpDateTo.Value.ToString("dd/MMM/yyyy")
      FilterDateOpen = " and VDate < '" & mydateFrom.ToString("dd/MMM/yyyy") & "' "
      FilterDate = " and VDate between '" & mydateFrom.ToString("dd/MMM/yyyy") & "' and '" & mydateTo.ToString("dd/MMM/yyyy") & "' "

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
      If mycodefrom <> "" And mycodeto <> "" Then
         FilterCode = " and SupplierCode between '" & mycodefrom & "' and '" & mycodeto & "' "
         FilterCodeProdMW = " and SupplierCode between '" & mycodefrom & "' and '" & mycodeto & "' "
      End If
      '----------------------------------------------------------------------------------------------------------------------
      FilterRemarks = " and Narration like '%" & txtVName.Text.Trim & "%' "
      FilterRemarksProdMW = " and Narration like '%" & txtVName.Text.Trim & "%' "
      '----------------------------------------------------------------------------------------------------------------------
      '----------------------------------------------------------------------------------------------------------------------
      If optSupplierLedger.Checked Then
         'ReportFilePath = "rptGeneralLedger.rpt"
         rptName = "rptSaleVendorLedger"
         ReportTitle = "Stock Ledger From " & dtpDateFrom.Value.ToString("dd/MM/yyyy") & " To " & dtpDateTo.Value.ToString("dd/MM/yyyy")
      ElseIf optSupplierAging.Checked Then
         'ReportFilePath = "rptGeneralLedger.rpt"
         rptName = "rptVendorAging"
         ReportTitle = "General Ledger From " & dtpDateFrom.Value.ToString("dd/MM/yyyy") & " To " & dtpDateTo.Value.ToString("dd/MM/yyyy")
      ElseIf optSupplierAnalysis.Checked Then
         rptName = "rptSupplierAnalysis"
         ReportTitle = "Trial From " & dtpDateFrom.Value.ToString("dd/MM/yyyy") & " To " & dtpDateTo.Value.ToString("dd/MM/yyyy")
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

      rpt = (WinReportsApplication.Classess.SupplierDetailReports.SetReportName(rptName))

      MyListDic.Add("@CWhere", " where 1=1  " & FilterDate & FilterCode & FilterPosted)
      MyListDic.Add("@CWhereOpen", " where 1=1  " & FilterDateOpen & FilterCode)
      MyListDic.Add("@isCurrent", "1")


      If optSupplierAging.Checked Then
         ReportSpName = "spRptVendorAgaing"
         dtrpt = objCommon.GetDataTableSPPrm(ReportSpName, MyListDic)

         MyListDic.Add("vDate", dtpDateFrom.Value.ToString("dd/MM/yyyy"))
         MyListDic.Add("cCompany", G_CompName)
         MyListDic.Add("coffice", "")

      ElseIf optSupplierLedger.Checked Then
         MyListDic.Add("@inDocumentCurrency", "0")
         ReportSpName = "spRptVendorLedger"
         dtrpt = objCommon.GetDataTableSPPrm(ReportSpName, MyListDic)

         MyListDic.Add("dDateFrom", dtpDateFrom.Value.ToString("dd/MM/yyyy"))
         MyListDic.Add("dDateTo", dtpDateTo.Value.ToString("dd/MM/yyyy"))
         MyListDic.Add("cAcFrom", txtCodeFrom.Text)
         MyListDic.Add("cAcTo", txtCodeTo.Text)
         MyListDic.Add("cGroupofCompany", G_CompName)
         MyListDic.Add("coffice", "")
         MyListDic.Add("cPosted", "")
         MyListDic.Add("Currency", "")
         MyListDic.Add("PostedValue", 0)
         MyListDic.Add("CurrencyValue", 0)

      ElseIf optSupplierAnalysis.Checked Then
         ReportSpName = "spRptVendorAnalysis"
         dtrpt = objCommon.GetDataTableSPPrm(ReportSpName, MyListDic)

         MyListDic.Add("cGroupofCompany", G_CompName)
         MyListDic.Add("ReportTitle", "Supplier Analysis")

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
   Private Sub txtVName_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtVName.KeyDown
      If e.KeyCode = Keys.F2 Then
         frmLookup.LookupQuery = "Select VID,VCode,VName from InvSupplier"
         frmLookup.LookupName = "Supplier"
         frmLookup.VID = ""
         frmLookup.VCode = ""
         frmLookup.VName = ""
         frmLookup.ShowDialog()
         If frmLookup.VID <> "" Then
            txtCodeTo.Text = ""
            lblPID.Text = frmLookup.VID
            txtCodeFrom.Text = frmLookup.VCode
            txtVName.Text = frmLookup.VName
         End If
         'frmLookupCOA.Dispose()
         txtCodeFrom.Focus()
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
End Class