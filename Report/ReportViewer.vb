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
Public Class ReportViewer
    Public MyListDic As ListDictionary
    Public rtp As New ReportClass
    Public dtrpt As DataTable
    Public dtSet As DataSet
    Private Sub ReportViewer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            If dtrpt Is Nothing Then
                rtp.SetDataSource(dtSet.Tables("dtrpt"))
                'Dim ncc = rtp.Subreports.Count
                'Dim ncc111 = rtp.Subreports.Item(0).Name
                'Dim ncc22 = rtp.Subreports.Item(1).Name
                'Dim ncc2223 = rtp.Subreports.Item(2).Name
                'Dim ncc2244 = rtp.Subreports.Item(3).Name
                rtp.Subreports.Item("rptSaleOrderAccessory.rpt").SetDataSource(dtSet.Tables("dtrpt1"))
                rtp.Subreports.Item("rptIssueNoteSub.rpt").SetDataSource(dtSet.Tables("dtrpt2"))
                rtp.Subreports.Item("rptIssueReturnSub.rpt").SetDataSource(dtSet.Tables("dtrpt3"))
                rtp.Subreports.Item("rptOrderWiseWagesSub.rpt").SetDataSource(dtSet.Tables("dtrpt4"))
                'rtp.Subreports.Item(3).SetDataSource(dtSet.Tables("dtrpt4"))
                For Each item As DictionaryEntry In MyListDic
                    rtp.SetParameterValue(item.Key.ToString(), item.Value.ToString())
                Next
                CRVSetup.ReportSource = rtp
            Else
                rtp.SetDataSource(dtrpt)
                For Each item As DictionaryEntry In MyListDic
                    rtp.SetParameterValue(item.Key.ToString(), item.Value.ToString())
                Next
                CRVSetup.ReportSource = rtp
            End If
        Catch ex As Exception
            Debug.Print(ex.ToString())
        End Try
    End Sub
End Class