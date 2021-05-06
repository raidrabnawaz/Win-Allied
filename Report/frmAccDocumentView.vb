Imports System.Collections.Specialized
Imports System.IO
Imports CrystalDecisions.CrystalReports.Engine

Public Class frmAccDocumentView
    Dim qryMain, VoucherNo, VType, cWhere, VDate As String
    Dim objCommon As New clsCommon
    Dim txtVID As Double

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

    Private Sub frmAttCode_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtVnoFrom.Text = ""
        objCommon.FillVoucherTypeJV(Me.cmbVoucherType)
        ClearHead("")
        'FillHeader()
        'FillGrid()
        dtpDateTo.Value = Date.Today
        dtpDateFrom.Value = DateTime.Today.Month & "/1/" & DateTime.Today.Year
        cmbVoucherType.SelectedIndex = 0
        cmdSearch_Click(sender, e)
        txtVnoTo.Focus()
    End Sub
    Private Sub ClearHead(ByVal myid As String)
        'If myid = "" Then
        ''do not change txtID.Text 
        'Else
        txtVnoFrom.Text = myid
        'End If
        lblInformation.Text = ""
        txtVnoTo.Text = ""
    End Sub
    Private Sub FillHeader()
        'grdRecord.DataSource = Nothing
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim grdcol0 As System.Windows.Forms.DataGridViewTextBoxColumn
        Dim grdcol1 As System.Windows.Forms.DataGridViewTextBoxColumn
        Dim grdcol2 As System.Windows.Forms.DataGridViewTextBoxColumn

        grdcol0 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        grdcol1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        grdcol2 = New System.Windows.Forms.DataGridViewTextBoxColumn()

        grdcol0.DataPropertyName = "VID"
        grdcol0.HeaderText = "Code"
        grdcol0.Name = "grdcol0"
        grdcol0.Visible = False
        '
        'grdcol1
        's
        grdcol1.DataPropertyName = "VName"
        grdcol1.HeaderText = "Unit"
        grdcol1.Name = "grdcol2"
        grdcol1.Width = 400

        grdcol2.DataPropertyName = "IsActive"
        grdcol2.HeaderText = "Is Active"
        grdcol2.Name = "grdcol2"
        grdcol2.Width = 100

        Me.grdRecord.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {grdcol0, grdcol1, grdcol2})
    End Sub
    Private Sub FillGrid()
        'grdRecord.DataSource = Nothing
        qryMain = "EXEC SpGet_invUOM"
        Dim dt As DataTable = objCommon.GetDataTable(qryMain)
        If IsNothing(dt) Then
            'EmptyFields()
            Return
        End If
        If dt.Rows.Count <= 0 Then
            'EmptyFields()
            Return
        End If
        grdRecord.DataSource = dt
    End Sub
    Private Sub FillForm()
        lblInformation.Text = ""
        If txtVnoFrom.Text = "" Then
            ClearHead("")
            Return
        End If
        qryMain = "EXEC SpGetbyID_invUOM'" & txtVnoFrom.Text & "' "
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
        txtVnoTo.Text = dr("VName")

    End Sub
    Private Sub cmdNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNew.Click
        ClearHead("")
        txtVnoTo.Focus()
    End Sub
    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        lblInformation.Text = ""
        'varify for empty string
        'varify already existance
      txtVnoTo.Text = txtVnoTo.Text.Trim.Replace("'", "")
        If txtVnoTo.Text = "" Then
            MessageBox.Show("Please give some Name.", G_APP_TITLE)
            Return
        End If
        'qryMain = " Select top 1 isnull(L1Code,'') as L1Code from tblAcSetupCOAL1 where L1Code <> '" & txtID.Text & "' and VName='" & txtVName.Text & "'; "
        'qryMain = objCommon.ExecuteScalar(qryMain)
        'If qryMain <> "" Then
        '    MessageBox.Show("Account already exists.", G_APP_TITLE)
        '    Return
        'End If

        If txtVnoFrom.Text Is "" Then 'update
            txtVnoFrom.Text = 0                  '    qryMain = " update tblAcSetupCOAL1 set VName='" & txtVName.Text & "',GID='" & cmbGroup.SelectedValue & "' where L1Code = '" & txtID.Text & "'; "
        End If                   '    objCommon.ExecuteNonQuery(qryMain)
        'Else
        '    Dim strcode As String
        '    strcode = objCommon.ExecuteScalar("select isnull(max(cast(L1Code as int)),0) + 1 as L1Code from tblAcSetupCOAL1 where GID = " & cmbGroup.SelectedValue)
        '    strcode = Double.Parse(strcode).ToString("00")
        '    qryMain = "insert into tblAcSetupCOAL1 (L1Code, GID, VName, OldCode) values('" &
        '    strcode & "'," & cmbGroup.SelectedValue & ",'" & txtVName.Text & "','' );  "

        'qryMain = "EXEC SpSave_invUOM " & txtVnoFrom.Text & ", " & txtVnoTo.Text & "," & G_UID & ",'','" & G_IPAddress & "'," & G_UID & ",'','" & G_IPAddress & "'"

        'objCommon.ExecuteNonQuery(qryMain)

        ClearHead("")
        FillGrid()
        lblInformation.Text = "Record Saved."
        txtVnoTo.Focus()
    End Sub
    Private Sub cmdEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEdit.Click
        FillForm()
        txtVnoTo.Focus()
    End Sub
    Private Sub cmdSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSearch.Click

      Dim cWhere As String = " AND  VDate between ''" & Convert.ToDateTime(dtpDateFrom.Value).ToString("dd/MMM/yyyy") & "'' AND ''" & Convert.ToDateTime(dtpDateTo.Value).ToString("dd/MMM/yyyy") & "'' "
        If Not txtVnoFrom.Text = "" Then cWhere &= " AND VNo=''" & txtVnoTo.Text & "'' "
        If cmbVoucherType.SelectedIndex > 0 Then
            cWhere &= " AND VType=''" & cmbVoucherType.SelectedValue & "'' "
        End If
        cWhere &= " AND CompanyID=" & G_Compcode & " AND FinancialYearID=" & G_FinancialYearID & " "
        qryMain = "EXEC spGet_DocumentViewAcc '" & cWhere & "'"
        grdRecord.DataSource = objCommon.GetDataTable(qryMain)
        If grdRecord.Rows.Count > 0 Then grdRecord.Columns(0).Visible = False
        If grdRecord.Rows.Count > 0 Then setGrid(grdRecord)
    End Sub
    Private Sub cmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancel.Click
        ClearHead("")
        txtVnoTo.Focus()
    End Sub

    Private Sub grdRecord_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles grdRecord.CellClick
        If e.ColumnIndex = grdRecord.Columns("VNo").Index Then
            'VType = "DocumentView"
            txtVID = Setdouble(grdRecord.Rows(e.RowIndex).Cells(e.ColumnIndex - 1).Value)
            VoucherNo = grdRecord.Rows(e.RowIndex).Cells(e.ColumnIndex).Value
            VType = grdRecord.Rows(e.RowIndex).Cells(e.ColumnIndex + 1).Value
            If Not VType = "" Then
                cmdPrint(VType, txtVID, VoucherNo)
            End If
        End If
    End Sub


    Private Sub cmdPrint(ByVal VType As String, ByVal txtVID As Double, ByVal txtVNo As String)
        MyListDic.Clear()

        rpt = (WinReportsApplication.Classess.AccountsReport.SetReportName("acrptvoucher"))
        FilterVTypeList = ""
        FilterDate = ""
        ReportTitle = ""
        cWhere = " Where H.MID=" & txtVID & " AND H.VNo='" & txtVNo & "' AND H.VType='" & VType & "' AND H.CompanyID=" & G_Compcode
        MyListDic.Add("@VType", "DocumentView")
        MyListDic.Add("@CompanyID", G_Compcode)
        MyListDic.Add("@DateFrom", "1/1/1900")
        MyListDic.Add("@DateTo", "1/1/1900")
        MyListDic.Add("@cWhere", cWhere)
        ReportSpName = "spRptAccVoucher"
        dtrpt = objCommon.GetDataTableSPPrm(ReportSpName, MyListDic)

        'MyListDic.Add("@cWhere", " where AH.txtVID = " & lblVID.Text)
        MyListDic.Add("PrintedBy", "")
        MyListDic.Add("cGroupofCompany", G_CompName)
        'MyListDic.Add("@VID", txtVID)


        Dim MyReportViewer As ReportViewer = New ReportViewer
        MyReportViewer.dtrpt = dtrpt
        MyReportViewer.MyListDic = MyListDic
        MyReportViewer.rtp = rpt
        MyReportViewer.MdiParent = EMSMain
        MyReportViewer.Show()

    End Sub
    Private Sub cmdDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDelete.Click

    End Sub
    Private Sub grdAtt_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles grdRecord.MouseClick
        If grdRecord.Rows.Count > 0 Then
            'Dim MYID As String = grdRecord.Rows(grdRecord.CurrentCell.RowIndex).Cells(0).Value
            'txtVnoFrom.Text = MYID
            'FillForm()
            'txtVnoTo.Focus()
        End If
    End Sub

End Class