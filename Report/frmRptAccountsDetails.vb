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
Imports WinReportsApplication

Public Class frmRptAccountsDetails
    Dim qryMain As String
    Dim objCommon As New clsCommon
    Dim MyListDic As New ListDictionary
    Dim ReportFilePath As String = ""
    Dim rpt As New ReportClass
    Dim ReportTitle As String = ""
    Dim FilterDateOpen As String = ""
    Dim FilterDate As String = ""
    Dim FilterCode As String = ""
    Dim FilterRemarks As String = ""
    Dim FilterPosted As String = ""
    Dim rptName As String = ""
    Dim CWhere As String
    Dim FilterDateOpenProdMW As String = ""
    Dim FilterDateProdMW As String = ""
    Dim FilterCodeProdMW As String = ""
    Dim FilterRemarksProdMW As String = ""

    Dim ReportSpName As String = ""
    Dim dtrpt As DataTable


    Private Sub frmRptAttDaily_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        G_CURRENTDATE = Date.Now
        If G_CURRENTDATE > G_SOFTENDDATE Then
            End
        End If

        dtpDateFrom.Value = "01/" & Today.ToString("MMM/yyyy")
        dtpDateTo.Value = Today.ToString("dd/MMM/yyyy")


    End Sub
    Private Sub cmdSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSearch.Click

        MyListDic.Clear()
        ReportFilePath = ""
        ReportTitle = ""
        FilterCode = ""
        FilterCodeProdMW = ""
        '----------------------------------------------------------------------------------------------------------------------
        Dim mydateFrom As Date = CDate(dtpDateFrom.Value).ToString("dd/MMM/yyyy")
        Dim mydateTo As Date = CDate(dtpDateTo.Value).ToString("dd/MMM/yyyy")
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

        If mycodefrom <> "" And mycodeto <> "" Then
            FilterCode = " and AccountCode between '" & mycodefrom & "' and '" & mycodeto & "' "
            FilterCodeProdMW = " and AccountCode between '" & mycodefrom & "' and '" & mycodeto & "' "
        End If
        '----------------------------------------------------------------------------------------------------------------------
        FilterRemarks = " and Narration like '%" & txtVName.Text.Trim & "%' "
        FilterRemarksProdMW = " and Narration like '%" & txtVName.Text.Trim & "%' "
        '----------------------------------------------------------------------------------------------------------------------
        '----------------------------------------------------------------------------------------------------------------------
        If optGeneralLedger.Checked Then

            rptName = "acrptLedger"
            ReportTitle = "General Ledger From " & dtpDateFrom.Value.ToString("dd/MM/yyyy") & " To " & dtpDateTo.Value.ToString("dd/MM/yyyy")
        ElseIf optLedgerWithFraction.Checked Then

            rptName = "acrptLedgerwithZero"

            ReportTitle = "General Ledger From " & dtpDateFrom.Value.ToString("dd/MM/yyyy") & " To " & dtpDateTo.Value.ToString("dd/MM/yyyy")
        ElseIf optTrial.Checked Then
            rptName = "TrialBalance1"

            ReportTitle = "Trial From " & dtpDateFrom.Value.ToString("dd/MM/yyyy") & " To " & dtpDateTo.Value.ToString("dd/MM/yyyy")
        End If
        If optPosted.Checked Then

            FilterPosted = " And IsPosted = 1 "

        ElseIf optUnPosted.Checked Then

            FilterPosted = " AND IsPosted = 0 "

        End If

        If txtTitle.Text.Trim <> "" Then
            ReportTitle = txtTitle.Text.Trim
        End If

        MyListDic.Add("@CWhere", " where 1=1 AND CompanyID=" & G_Compcode & " and FinancialYearID=" & G_FinancialYearID & " " & FilterDate & FilterCode & FilterPosted)
        MyListDic.Add("@CWhereOpen", " where 1=1 AND CompanyID=" & G_Compcode & " and FinancialYearID=" & G_FinancialYearID & " " & FilterDateOpen & FilterCode)
        MyListDic.Add("@inDocumentCurrency", "0")
        MyListDic.Add("@isCurrent", "1")
        MyListDic.Add("@CompanyID", G_Compcode)
        MyListDic.Add("@UserID", G_UID)
        MyListDic.Add("@isFullLedger", "1")
        MyListDic.Add("@FinancialYearID", G_FinancialYearID)

        rpt = (WinReportsApplication.Classess.AccountsReport.SetReportName(rptName))

        'prm other than SP

        If optGeneralLedger.Checked Or optLedgerWithFraction.Checked Then

            ReportSpName = "spRptAccLedger"
            dtrpt = objCommon.GetDataTableSPPrm(ReportSpName, MyListDic)
            MyListDic.Add("dDateFrom", dtpDateFrom.Value.ToString("dd/MMM/yyyy"))
            MyListDic.Add("dDateTo", dtpDateTo.Value.ToString("dd/MMM/yyyy"))
            MyListDic.Add("cAcFrom", txtCodeFrom.Text)
            MyListDic.Add("cAcTo", txtCodeTo.Text)
            MyListDic.Add("cGroupofCompany", G_CompName)
            MyListDic.Add("coffice", "")
            MyListDic.Add("cPosted", "")
            MyListDic.Add("Currency", "")
            MyListDic.Add("PostedValue", 0)
            MyListDic.Add("CurrencyValue", 0)

        ElseIf optTrial.Checked Then
            ReportSpName = "spRptAccTrail"
            dtrpt = objCommon.GetDataTableSPPrm(ReportSpName, MyListDic)
            MyListDic.Add("cCompany", G_CompName)
            MyListDic.Add("datefrom", dtpDateFrom.Value.ToString("dd/MMM/yyyy"))
            MyListDic.Add("dateto", dtpDateTo.Value.ToString("dd/MMM/yyyy"))
            MyListDic.Add("acfrom", "")
            MyListDic.Add("acto", "")
            MyListDic.Add("coffice", "")
            MyListDic.Add("cPosted", "")
            MyListDic.Add("cCurrency", "")
        End If

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


    Private Sub txtCodeFrom_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCodeFrom.KeyDown
        If e.KeyCode = Keys.F2 Then
            frmLookupCOA.ETypeID = "Report"
            frmLookupCOA.VCodeIni = txtCodeFrom.Text.Trim
            frmLookupCOA.ShowDialog()
            If frmLookupCOA.VCode <> "" Then
                lblAccountIDfrom.Text = frmLookupCOA.VID
                txtCodeFrom.Text = frmLookupCOA.VCode
                txtAccTitleFrom.Text = frmLookupCOA.VName

                If (txtCodeTo.Text = "") Then
                    txtCodeTo.Text = frmLookupCOA.VCode
                End If

                If txtAccTitleTo.Text = "" Then
                    txtAccTitleTo.Text = frmLookupCOA.VName

                End If
            End If
            frmLookupCOA.Dispose()
        End If
    End Sub
    Private Sub txtCodeTo_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCodeTo.KeyDown
        If e.KeyCode = Keys.F2 Then
            frmLookupCOA.ETypeID = "Report"
            frmLookupCOA.VCodeIni = txtCodeTo.Text.Trim
            frmLookupCOA.ShowDialog()
            If frmLookupCOA.VCode <> "" Then
                lblAccountIDto.Text = frmLookupCOA.VID
                txtCodeTo.Text = frmLookupCOA.VCode
                txtAccTitleTo.Text = frmLookupCOA.VName
            End If
            frmLookupCOA.Dispose()
        End If
    End Sub
    Private Sub cmbExcelExport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbExcelExport.Click
        '----------------------------------------------------------------------------------------------------------------------
        Dim mydateFrom As Date = CDate(dtpDateFrom.Value).ToString("dd/MMM/yyyy")
        Dim mydateTo As Date = CDate(dtpDateTo.Value).ToString("dd/MMM/yyyy")
        FilterDateOpen = " and VDate < ''" & mydateFrom.ToString("dd/MMM/yyyy") & "'' "
        FilterDate = " and VDate between ''" & mydateFrom.ToString("dd/MMM/yyyy") & "'' and ''" & mydateTo.ToString("dd/MMM/yyyy") & "'' "

        FilterDateOpenProdMW = " and VDate < ''" & mydateFrom.ToString("dd/MMM/yyyy") & "'' "
        FilterDateProdMW = " and VDate between ''" & mydateFrom.ToString("dd/MMM/yyyy") & "'' and ''" & mydateTo.ToString("dd/MMM/yyyy") & "'' "
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

        If mycodefrom <> "" And mycodeto <> "" Then
            FilterCode = " and AccountCode between ''" & mycodefrom & "'' and ''" & mycodeto & "'' "
            FilterCodeProdMW = " and AccountCode between ''" & mycodefrom & "'' and ''" & mycodeto & "'' "
        End If
        '----------------------------------------------------------------------------------------------------------------------
        FilterRemarks = " and Narration like ''%" & txtVName.Text.Trim & "%'' "
        FilterRemarksProdMW = " and Narration like ''%" & txtVName.Text.Trim & "%'' "
        '----------------------------------------------------------------------------------------------------------------------
        '----------------------------------------------------------------------------------------------------------------------
        If optPosted.Checked Then

            FilterPosted = " And IsPosted = 1 "

        ElseIf optUnPosted.Checked Then

            FilterPosted = " AND IsPosted = 0 "
        End If

        CWhere = " 'where 1=1 AND CompanyID=" & G_Compcode & FilterDate & FilterCode & FilterPosted & "'"
        qryMain = "EXEC SpGetbyExportLedgerExcel  " & CWhere & ""
        Dim dt As DataTable = objCommon.GetDataTable(qryMain)
        grdAtt.DataSource = dt
        objCommon.ExportToExcel(grdAtt)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        txtCodeFrom.Clear()
        txtCodeTo.Clear()
        txtAccTitleFrom.Clear()
        txtAccTitleTo.Clear()
        lblAccountIDfrom.Text = 0
        lblAccountIDto.Text = 0
    End Sub
End Class