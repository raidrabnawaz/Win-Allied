Public Class frmBudget
    Dim objCommon As New clsCommon
    Dim dt As DataTable

    Private Sub frmBackDate_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        G_CURRENTDATE = Date.Now
        If G_CURRENTDATE > G_SOFTENDDATE Then
            End
        End If
        objCommon.FillFinancialYear(cmbFinancialYear, 5)
        objCommon.FillType(cmbType)

        objCommon.FillCompanyNew(cmbCompany)
        cmbCompany.SelectedValue = 5
        cmbCompany.Focus()
    End Sub

    Private Sub FillGrid(ByVal strSearch As String)

        If (cmbCompany.SelectedIndex < 1 Or cmbFinancialYear.SelectedIndex < 1) Then
            Return

        End If
        qryMain = "EXEC SpGetbyCompanyAndFY_Budget " & cmbFinancialYear.SelectedValue & ", " & cmbType.SelectedValue & " "

        dt = objCommon.GetDataTable(qryMain)

        If IsNothing(dt) Then
            Return
        End If
        If dt.Rows.Count <= 0 Then
            Return
        End If
        For row As Int16 = 0 To dt.Rows.Count - 1
            Dim row1 As String() = New String() {dt.Rows(row)("VID").ToString(), dt.Rows(row)("Sr No.").ToString(), dt.Rows(row)("VName").ToString(), dt.Rows(row)("VValue").ToString()}
            grdRecord.Rows.Add(row1)
        Next

    End Sub

    Private Sub cmbFinancialYear_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cmbFinancialYear.SelectedIndexChanged
        grdRecord.Rows.Clear()
        Try
            If cmbType.SelectedIndex = 0 Then
                MessageBox.Show("Select Type.")
                cmbType.Focus()
                Return
            End If
        Catch ae As Exception
            Return
        End Try
        FillGrid("")
        'If (grdRecord.Rows.Count > 0) Then
        '    Return
        'End If


        'If (cmbFinancialYear.SelectedIndex < 1) Then
        '    Return
        'End If
        'Dim startYearDate As Date

        'qryMain = " SELECT VID, VNAME, DateFrom FROM AccFinancialYear WHERE CompanyID = 5 and VID = " & cmbFinancialYear.SelectedValue & "  ORDER BY DATEFROM"
        'Dim dt1 As DataTable = objCommon.GetDataTable(qryMain)
        'startYearDate = DateTime.Parse(dt1.Rows(0)("DateFrom").ToString())
        'For monthCount = 1 To 12
        '    Dim currentDate As Date = startYearDate.AddMonths(monthCount - 1)

        '    grdRecord.Rows.Add(0, monthCount, currentDate.ToString("MMM-yyyy"))
        'Next



    End Sub

    Private Sub cmbCompany_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cmbCompany.SelectedIndexChanged
        'If cmbCompany.SelectedIndex < 1 Then
        '    Return

        'End If
        'objCommon.FillFinancialYear(cmbFinancialYear, cmbCompany.SelectedValue)

    End Sub

    Private Sub cmdSave_Click(ByVal sender As Object, ByVal e As EventArgs) Handles cmdSave.Click

        lblInformation.Text = ""

        If grdRecord.Rows.Count = 0 Then
            MessageBox.Show("Please give Months Detail.", G_APP_TITLE)
            cmbCompany.Focus()
            Return
        End If
        For Each grid As DataGridViewRow In grdRecord.Rows
            If grid.Cells("VID").Value = 0 And grid.Cells("Amount").Value = 0 Then
                GoTo O
            End If
            qryMain = "EXEC SpSave_Budget " & grid.Cells("VID").Value & ",'" & grid.Cells("MonthName").Value & "'," & cmbType.SelectedValue & "," & cmbFinancialYear.SelectedValue & ",'" & DateTime.Now.ToString("dd/MMM/yyyy") & "'," & IIf(grid.Cells("Amount").Value = "", 0, grid.Cells("Amount").Value) & "," & G_UID & ",'','" & G_IPAddress & "'," & G_UID & ",'','" & G_IPAddress & "'"
            objCommon.ExecuteNonQuery(qryMain)
O:
        Next

        lblInformation.Text = "Record Saved."
        cmbCompany.Focus()
        cmbFinancialYear_SelectedIndexChanged(sender, e)
    End Sub

    Private Sub cmdNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNew.Click
        cmbCompany.SelectedValue = -1
        cmbFinancialYear.SelectedValue = -1
    End Sub

    Private Sub cmbType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbType.SelectedIndexChanged
        grdRecord.Rows.Clear()
        If cmbType.SelectedIndex < 1 Then
            Return

        End If
        cmbFinancialYear_SelectedIndexChanged(sender, e)
    End Sub
End Class