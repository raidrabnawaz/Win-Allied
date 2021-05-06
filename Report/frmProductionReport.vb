Public Class frmProductionReport
    Dim qryMain, qry As String
    Dim objCommon As New clsCommon

    Dim FilterDate As String = ""
    Dim FilterSaleOrder As String = ""
    Dim FilterVoucharType As String = ""
   

    Private Sub cmbProductionType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbProductionType.SelectedIndexChanged
        cmdSearch_Click(sender, e)
    End Sub


    Private Sub cmbMonth_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbMonth.SelectedIndexChanged
        If cmbMonth.SelectedIndex = 0 Then
            dtpDateFrom.Value = "01/" & Today.ToString("MM/yyyy")
            dtpDateTo.Value = Today.ToString("dd/MMM/yyyy")
            Return
        End If

        qryMain = "EXEC SpGetbyID_ProdWagesMonth " & cmbMonth.SelectedValue.ToString & ""
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
    End Sub

    Private Sub cmdSearch_Click(sender As Object, e As EventArgs) Handles cmdSearch.Click
        '----------------------------------------------------------------------------------------------------------------------
        Dim mydateFrom As Date = dtpDateFrom.Value.ToString("dd/MMM/yyyy")
        Dim mydateTo As Date = dtpDateTo.Value.ToString("dd/MMM/yyyy")
        FilterDate = " OrderDate between ''" & mydateFrom.ToString("dd/MMM/yyyy") & "'' and ''" & mydateTo.ToString("dd/MMM/yyyy") & "'' "
        '----------------------------------------------------------------------------------------------------------------------
        Dim mySaleOrderId As Integer = 0
      If cmbSaleOrder.SelectedIndex > 0 Then
         mySaleOrderId = cmbSaleOrder.SelectedValue
         FilterSaleOrder = " and H.OrderId = " & mySaleOrderId & " "
      End If
      If cmbSaleOrder.SelectedIndex <= 0 Then
         FilterSaleOrder = ""
      End If
        '----------------------------------------------------------------------------------------------------------------------
        Dim myVoucharType As String = 0
        If cmbProductionType.SelectedIndex > 0 Then
            myVoucharType = cmbProductionType.SelectedItem
            FilterVoucharType = " and H.VType = ''" & myVoucharType & "'' "
        End If
        If cmbProductionType.SelectedIndex <= 0 Then
            FilterVoucharType = ""
        End If
        '----------------------------------------------------------------------------------------------------------------------
        Dim cWhere As String = " WHERE " & FilterDate & FilterSaleOrder & FilterVoucharType

        qryMain = "EXEC SpGet_SaleOrderProduction '" & cWhere & "'"
        grdRecord.DataSource = objCommon.GetDataTable(qryMain)
        'If grdRecord.Rows.Count > 0 Then grdRecord.Columns(0).Visible = False
        If grdRecord.Rows.Count > 0 Then setGrid(grdRecord)

    End Sub

    Private Sub cmbSaleOrder_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSaleOrder.SelectedIndexChanged
        cmdSearch_Click(sender, e)
    End Sub

    Private Sub frmProductionReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        objCommon.FillProdSaleOrder(Me.cmbSaleOrder)
        cmbProductionType.SelectedIndex = 0
        objCommon.FillProdWagesMonth(Me.cmbMonth)
        cmdSearch_Click(sender, e)
    End Sub
End Class