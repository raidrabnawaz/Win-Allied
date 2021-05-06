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

Public Class frmInvStockLedger
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
   Public PValues As String = ""
   Dim FilterDateOpenProdMW As String = ""
   Dim FilterDateProdMW As String = ""
   'Dim FilterCodeProdMW As String = ""
   Dim FilterRemarksProdMW As String = ""
   Dim rpt As New ReportClass
   Dim ReportSpName As String = ""
   Dim dtrpt As DataTable
   Dim rptName As String = ""

   Private Function FillCheckBoxList() As Boolean
      ListView1.Items.Clear()
      qryMain = "EXEC SpGet_invProductMainCategory"
      Dim dt As DataTable = objCommon.GetDataTable(qryMain)
      If dt.Rows.Count > 0 Then
         Dim items As New List(Of ListViewItem)
         For Each dr As DataRow In dt.Rows
            Dim item As New ListViewItem
            item.Text = dr(1)
            item.SubItems.Add(dr(0))
            items.Add(item)
         Next
         ListView1.Items.AddRange(items.ToArray())
      End If
      PValues = "," & PValues & ","

      For Each a As ListViewItem In ListView1.Items
         If InStr(PValues.Replace("'", ""), "," & a.SubItems(1).Text & ",") Then
            a.Checked = True
            'else
            '   a.Selected = False
         End If
      Next

      Return True
   End Function

   'Private Sub FillCheckBoxList()
   '    'grdRecord.DataSource = Nothing
   '    qryMain = "EXEC SpGet_invProductMainCategory"
   '    Dim dt As DataTable = objCommon.GetDataTable(qryMain)
   '    If IsNothing(dt) Then
   '        'EmptyFields()
   '        Return
   '    End If
   '    If dt.Rows.Count <= 0 Then
   '        'EmptyFields()
   '        Return
   '    End If
   '  CheckedListBox1.DataSource = dt
   '  CheckedListBox1.DisplayMember = "VName"
   '  CheckedListBox1.ValueMember = "VID"
   '  '  For i As Integer = 0 To dt.Rows.Count - 1
   '  '   CheckedListBox1.Items.Add(dt.Rows(i)("VName"))

   '  'Next

   'End Sub
    Private Sub frmRptAttDaily_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        FillCheckBoxList()
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
       
      FilterCode = ""
 
      FilterCode = "0"
      For i As Integer = 0 To ListView1.CheckedItems.Count - 1
         'Dim temp As String = i.Item(item).ToString
         'FilterCode += ", '" & temp & "' "
         FilterCode = FilterCode & "," & ListView1.CheckedItems(i).SubItems(1).Text
      Next
      If Not FilterCode = "0" Then
         FilterCode = " and P.CategoryID in( " & FilterCode & " )"
      Else
         FilterCode = ""
      End If

 
      '----------------------------------------------------------------------------------------------------------------------
      FilterRemarks = " And Narration Like '%" & txtVName.Text.Trim & "%' "
      FilterRemarksProdMW = " and Narration like '%" & txtVName.Text.Trim & "%' "
      '----------------------------------------------------------------------------------------------------------------------
      '----------------------------------------------------------------------------------------------------------------------
      If optStockLedger.Checked Then
         'ReportFilePath = "rptGeneralLedger.rpt"
         rptName = "rfItemLedgerSW"
           
      ElseIf optActivitySummary.Checked Then
         'ReportFilePath = "rptGeneralLedger.rpt"
         rptName = "rptItemSummary"

      ElseIf optSummaryValue.Checked Then
         rptName = "rptItemSummaryValue"

      ElseIf optItemAging.Checked Then
         rptName = "rptStockAging"

      ElseIf optPurchaseAnalysis.Checked Then
         rptName = "rptPurchaseAnalysis"

      ElseIf optGRNB.Checked Then
         rptName = "rptGRNBListing"


         '''''''''''''''''''        Yarn Gate Pass Reports    '''''''''''''''''''''''''''''''''
      ElseIf optYarnOGP.Checked Then
         rptName = "rptYarnOGPDateWise"

      ElseIf optFabricIGP.Checked Then
         rptName = "rptFabricIGPDateWise"

      ElseIf optFabricOGP.Checked Then
         rptName = "rptFabricOGPDateWise"
         
      ElseIf optFabricIGPDyeing.Checked Then
         rptName = "rptDyingIGPDateWise"
         
      ElseIf optPosted.Checked Then

         FilterPosted = " And IsPosted = 1 "

      ElseIf optUnPosted.Checked Then

         FilterPosted = " AND IsPosted = 0 "
 
      End If

      If txtTitle.Text.Trim <> "" Then
         ReportTitle = txtTitle.Text.Trim
      End If

      rpt = (WinReportsApplication.Classess.StockDailyReport.SetReportName(rptName))
      MyListDic.Add("@CWhere", " where 1=1  " & FilterDate & FilterCode & FilterPosted)

      If optStockLedger.Checked Then

         MyListDic.Add("@CWhereOpen", " where 1=1  " & FilterDateOpen & FilterCode)
         ReportSpName = "spRpt_InvStockLedger"
         dtrpt = objCommon.GetDataTableSPPrm(ReportSpName, MyListDic)
         'MyListDic.Add("@isCurrent", "1")
         'MyListDic.Add("@inDocumentCurrency", "0")
         MyListDic.Add("datefrom", dtpDateFrom.Value.ToString("dd/MMM/yyyy"))
         MyListDic.Add("dateto", dtpDateTo.Value.ToString("dd/MMM/yyyy"))
         MyListDic.Add("itemFrom", "")
         MyListDic.Add("itemTo", "")
         MyListDic.Add("off_Name", "")
         MyListDic.Add("ReportTitle", "Stock Ledger Report")
         'MyListDic.Add("Currency", "")
         MyListDic.Add("cCompany", G_CompName)
         'MyListDic.Add("PostedValue", "")
         'MyListDic.Add("CurrencyValue", "")

      ElseIf optSummaryValue.Checked Or optActivitySummary.Checked Then
         MyListDic.Add("@CWhereOpen", " where 1=1  " & FilterDateOpen & FilterCode)
         MyListDic.Add("@isCurrent", "1")
         ReportSpName = "spRptItemActivity"
         dtrpt = objCommon.GetDataTableSPPrm(ReportSpName, MyListDic)
         'MyListDic.Add("@inDocumentCurrency", "0")
         MyListDic.Add("dDateFrom", dtpDateFrom.Value.ToString("dd/MMM/yyyy"))
         MyListDic.Add("dDateTo", dtpDateTo.Value.ToString("dd/MMM/yyyy"))
         MyListDic.Add("itemFrom", txtCodeFrom.Text)
         MyListDic.Add("itemTo", txtCodeTo.Text)
         MyListDic.Add("cGroupofCompany", G_CompName)
         MyListDic.Add("cOffice", "")

      ElseIf optItemAging.Checked Then
         MyListDic.Add("@CWhereOpen", " where 1=1  " & FilterDateOpen & FilterCode)
         MyListDic.Add("@isCurrent", "1")
         ReportSpName = "spRptInvItemAgaing"
         dtrpt = objCommon.GetDataTableSPPrm(ReportSpName, MyListDic)
         'MyListDic.Add("@inDocumentCurrency", "0")
         MyListDic.Add("vDate", dtpDateFrom.Value.ToString("dd/MMM/yyyy"))
         MyListDic.Add("ReportTitle", "Stock Aging Report")
         MyListDic.Add("cCompany", G_CompName)
         MyListDic.Add("cOffice", "")

      ElseIf optPurchaseAnalysis.Checked Then
         MyListDic.Add("@CWhereOpen", " where 1=1  " & FilterDateOpen & FilterCode)
         MyListDic.Add("@isCurrent", "1")
         ReportSpName = "spRptVendorPurchaseRport"
         dtrpt = objCommon.GetDataTableSPPrm(ReportSpName, MyListDic)
         'MyListDic.Add("@inDocumentCurrency", "0")
         MyListDic.Add("dDateFrom", dtpDateFrom.Value.ToString("dd/MMM/yyyy"))
         MyListDic.Add("dDateTo", dtpDateTo.Value.ToString("dd/MMM/yyyy"))
         MyListDic.Add("cCompanyName", G_CompName)
         MyListDic.Add("cGroupofCompany", G_CompName)
         MyListDic.Add("ReportTitle", "GRN # wise Purchase Analysis")

      ElseIf optGRNB.Checked Then
         MyListDic.Add("@CWhereOpen", " where 1=1  " & FilterDateOpen & FilterCode)
         MyListDic.Add("@isCurrent", "1")
         MyListDic.Add("@VType", "GRNB")
         ReportSpName = "spRptInvListing"
         dtrpt = objCommon.GetDataTableSPPrm(ReportSpName, MyListDic)
         'MyListDic.Add("@inDocumentCurrency", "0")
         MyListDic.Add("dDateFrom", dtpDateFrom.Value.ToString("dd/MMM/yyyy"))
         MyListDic.Add("dDateTo", dtpDateTo.Value.ToString("dd/MMM/yyyy"))
         MyListDic.Add("cGroupofCompany", G_CompName)
         MyListDic.Add("ReportTitle", "GRN B Listing")

         '''''''''''''''''''       Yarn Gate Pass Reports    '''''''''''''''''''''''''''''''''
      ElseIf optYarnOGP.Checked Then
         'MyListDic.Add("@isCurrent", "1")
         'MyListDic.Add("@VType", "GRNB")
         'MyListDic.Add("@inDocumentCurrency", "0") 
         ReportSpName = "SpRptKnitYarnOGPDateWise"
         dtrpt = objCommon.GetDataTableSPPrm(ReportSpName, MyListDic)
         MyListDic.Add("vDate", dtpDateTo.Value.ToString("dd/MMM/yyyy"))
         MyListDic.Add("cCompany", G_CompName)
         MyListDic.Add("DateFrom", dtpDateFrom.Value.ToString("dd/MMM/yyyy"))
         MyListDic.Add("DateTo", dtpDateTo.Value.ToString("dd/MMM/yyyy"))
         MyListDic.Add("cGroupofCompany", G_CompName)
         MyListDic.Add("ReportTitle", "Yarn OGP Report Date Date Wise")

      ElseIf optFabricIGP.Checked Then
         'MyListDic.Add("@isCurrent", "1")
         'MyListDic.Add("@VType", "GRNB")
         'MyListDic.Add("@inDocumentCurrency", "0") 
         ReportSpName = "SpRptKnitFabricIGPDateWise"
         dtrpt = objCommon.GetDataTableSPPrm(ReportSpName, MyListDic)
         MyListDic.Add("vDate", dtpDateTo.Value.ToString("dd/MMM/yyyy"))
         MyListDic.Add("cCompany", G_CompName)
         MyListDic.Add("DateFrom", dtpDateFrom.Value.ToString("dd/MMM/yyyy"))
         MyListDic.Add("DateTo", dtpDateTo.Value.ToString("dd/MMM/yyyy"))
         MyListDic.Add("cGroupofCompany", G_CompName)
         MyListDic.Add("ReportTitle", "Fabric IGP Report Date Date Wise")

      ElseIf optFabricOGP.Checked Then
         'MyListDic.Add("@isCurrent", "1")
         'MyListDic.Add("@VType", "GRNB")
         'MyListDic.Add("@inDocumentCurrency", "0") 
         ReportSpName = "SpRptKnitFabricOGPDateWise"
         dtrpt = objCommon.GetDataTableSPPrm(ReportSpName, MyListDic)
         MyListDic.Add("vDate", dtpDateTo.Value.ToString("dd/MMM/yyyy"))
         MyListDic.Add("cCompany", G_CompName)
         MyListDic.Add("DateFrom", dtpDateFrom.Value.ToString("dd/MMM/yyyy"))
         MyListDic.Add("DateTo", dtpDateTo.Value.ToString("dd/MMM/yyyy"))
         MyListDic.Add("cGroupofCompany", G_CompName)
         MyListDic.Add("ReportTitle", "Fabric OGP Report Date Date Wise")

      ElseIf optFabricIGPDyeing.Checked Then
         'MyListDic.Add("@isCurrent", "1")
         'MyListDic.Add("@VType", "GRNB")
         'MyListDic.Add("@inDocumentCurrency", "0") 
         ReportSpName = "SpRptKnitFabricDyeingIGPDateWise"
         dtrpt = objCommon.GetDataTableSPPrm(ReportSpName, MyListDic)
         MyListDic.Add("vDate", dtpDateTo.Value.ToString("dd/MMM/yyyy"))
         MyListDic.Add("cCompany", G_CompName)
         MyListDic.Add("DateFrom", dtpDateFrom.Value.ToString("dd/MMM/yyyy"))
         MyListDic.Add("DateTo", dtpDateTo.Value.ToString("dd/MMM/yyyy"))
         MyListDic.Add("cGroupofCompany", G_CompName)
         MyListDic.Add("ReportTitle", "Fabric IGP after Dye Report Date Date Wise")


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
         frmLookup.LookupQuery = "SELECT VID, VName FROM invProductMainCategory"
         frmLookup.LookupName = "StProduct"
         frmLookup.ShowDialog()
         If frmLookup.VID <> "" Then
            txtCodeTo.Text = ""
            lblPID.Text = frmLookup.VID
            txtCodeFrom.Text = frmLookup.VID
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