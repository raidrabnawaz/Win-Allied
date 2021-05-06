Public Class frmLookup
   Dim objCommon As New clsCommon
   Dim dt As New DataTable
   Dim dv As DataView
    Public VID, VCode, VName, UOMID, LookupName, LookupQuery, Qty, IsAccessory, LeadTime, ExcessPer, OrderNo, OrderID, DepartmentID, SupplierID As String
    Private LookupFilter As String
    Private Sub FillGrid()
        dv = New DataView(dt)
        Select Case LookupName
            Case "Product"
                LookupFilter = " VCode LIKE '%" & Me.txtVName.Text.Trim & "%' or VName LIKE '%" & Me.txtVName.Text.Trim & "%' "
            Case "Employee"
                LookupFilter = " EmployeeCode LIKE '%" & Me.txtVName.Text.Trim & "%' or EmployeeName LIKE '%" & Me.txtVName.Text.Trim & "%' "
            Case "StProduct"
                LookupFilter = " VName LIKE '%" & Me.txtVName.Text.Trim & "%' "
            Case "InvProduct"
                LookupFilter = " VCode LIKE '%" & Me.txtVName.Text.Trim & "%' or ProductDesc LIKE '%" & Me.txtVName.Text.Trim & "%' "
            Case "ProductGRN"
                LookupFilter = " VCode LIKE '%" & Me.txtVName.Text.Trim & "%' or VName LIKE '%" & Me.txtVName.Text.Trim & "%'"
            Case "Pending MDN For PO"
                LookupFilter = " VNo LIKE '%" & Me.txtVName.Text.Trim & "%' or DepName LIKE '%" & Me.txtVName.Text.Trim & "%' or VCode LIKE '%" & Me.txtVName.Text.Trim & "%' or ProductName LIKE '%" & Me.txtVName.Text.Trim & "%' "
            Case "Supplier"
                LookupFilter = " VCode LIKE '%" & Me.txtVName.Text.Trim & "%' or VName LIKE '%" & Me.txtVName.Text.Trim & "%' "
            Case "Employee"
                LookupFilter = " VCode LIKE '%" & Me.txtVName.Text.Trim & "%' or VName LIKE '%" & Me.txtVName.Text.Trim & "%' "
            Case "SalesCustomer"
                LookupFilter = " VType LIKE '%" & Me.txtVName.Text.Trim & "%' or VName LIKE '%" & Me.txtVName.Text.Trim & "%' "
            Case "ProdSaleOrder"
                LookupFilter = " VType LIKE '%" & Me.txtVName.Text.Trim & "%' or VName LIKE '%" & Me.txtVName.Text.Trim & "%' "
            Case Else
                LookupFilter = ""
        End Select
        If Me.txtVName.Text.Trim <> "" Then
            dv.RowFilter = LookupFilter
        End If
        grdAcctLookup.DataSource = dv
        If grdAcctLookup.Rows.Count > 0 Then grdAcctLookup.Columns(0).Visible = False
        If grdAcctLookup.Rows.Count > 0 Then setGrid(grdAcctLookup)
    End Sub
    Private Sub LookupAcct_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
      Me.Text = LookupName
      FillDt()
      FillGrid()
      'VID = ""
      'VCode = ""
      'VName = ""
      'UOMID = ""
      'LookupName = ""
      'LookupQuery = ""
      'Qty = ""
      'SupplierID = ""
   End Sub
   Private Sub txtVName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtVName.TextChanged
      FillGrid()
   End Sub
   Private Sub grdAcctLookup_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdAcctLookup.CellDoubleClick
        If LookupName = "ProductGRN" Then
            VID = grdAcctLookup.Rows(e.RowIndex).Cells(0).Value
            VCode = grdAcctLookup.Rows(e.RowIndex).Cells(1).Value
            VName = grdAcctLookup.Rows(e.RowIndex).Cells(2).Value
            UOMID = grdAcctLookup.Rows(e.RowIndex).Cells(3).Value

        ElseIf LookupName = "GRNB" Then
            VID = grdAcctLookup.Rows(e.RowIndex).Cells("VID").Value
            VCode = grdAcctLookup.Rows(e.RowIndex).Cells("VCode").Value
            VName = grdAcctLookup.Rows(e.RowIndex).Cells("VNo").Value

        ElseIf LookupName = "ProductOGP" Then
            VID = grdAcctLookup.Rows(e.RowIndex).Cells("VID").Value
            VCode = grdAcctLookup.Rows(e.RowIndex).Cells("VCode").Value
            VName = grdAcctLookup.Rows(e.RowIndex).Cells("VName").Value
            UOMID = grdAcctLookup.Rows(e.RowIndex).Cells("UOMID").Value

        ElseIf LookupName = "InvProduct" Then
            VID = grdAcctLookup.Rows(e.RowIndex).Cells("VID").Value
            VCode = grdAcctLookup.Rows(e.RowIndex).Cells("VCode").Value
            VName = grdAcctLookup.Rows(e.RowIndex).Cells("ProductDesc").Value
            UOMID = grdAcctLookup.Rows(e.RowIndex).Cells("UomID").Value
            Qty = grdAcctLookup.Rows(e.RowIndex).Cells("Qty").Value

        ElseIf LookupName = "SalesCustomer" Then
            VID = grdAcctLookup.Rows(e.RowIndex).Cells("VID").Value
            VCode = grdAcctLookup.Rows(e.RowIndex).Cells("VCode").Value
            VName = grdAcctLookup.Rows(e.RowIndex).Cells("VName").Value
            'UOMID = grdAcctLookup.Rows(e.RowIndex).Cells("UomID").Value
            'Qty = grdAcctLookup.Rows(e.RowIndex).Cells("Qty").Value
        ElseIf LookupName = "ProdSaleOrder" Then
            VID = grdAcctLookup.Rows(e.RowIndex).Cells("VID").Value
            VCode = grdAcctLookup.Rows(e.RowIndex).Cells("VNo").Value
            VName = grdAcctLookup.Rows(e.RowIndex).Cells("VName").Value

        ElseIf LookupName = "StProduct" Then
            VID = grdAcctLookup.Rows(e.RowIndex).Cells("VID").Value
            VName = grdAcctLookup.Rows(e.RowIndex).Cells("VName").Value

        ElseIf LookupName = "YarnOGP" Then
            VID = grdAcctLookup.Rows(e.RowIndex).Cells("VID").Value
            VName = grdAcctLookup.Rows(e.RowIndex).Cells("VCode").Value + "-" + grdAcctLookup.Rows(e.RowIndex).Cells("VName").Value
            SupplierID = grdAcctLookup.Rows(e.RowIndex).Cells("SupplierID").Value
            OrderID = grdAcctLookup.Rows(e.RowIndex).Cells("OrderID").Value
            DepartmentID = grdAcctLookup.Rows(e.RowIndex).Cells("DepartmentID").Value

        ElseIf LookupName = "Product" Then

            VID = grdAcctLookup.Rows(e.RowIndex).Cells(0).Value
            VCode = grdAcctLookup.Rows(e.RowIndex).Cells(1).Value
            VName = grdAcctLookup.Rows(e.RowIndex).Cells(2).Value
            IsAccessory = grdAcctLookup.Rows(e.RowIndex).Cells(3).Value
            LeadTime = grdAcctLookup.Rows(e.RowIndex).Cells(4).Value
            ExcessPer = grdAcctLookup.Rows(e.RowIndex).Cells(5).Value

        ElseIf LookupName = "InvFetch" Then

            VID = grdAcctLookup.Rows(e.RowIndex).Cells(0).Value
            VCode = grdAcctLookup.Rows(e.RowIndex).Cells(1).Value
            VName = grdAcctLookup.Rows(e.RowIndex).Cells(2).Value
            OrderNo = grdAcctLookup.Rows(e.RowIndex).Cells("OrderNo").Value
            OrderID = grdAcctLookup.Rows(e.RowIndex).Cells("OrderID").Value
            DepartmentID = grdAcctLookup.Rows(e.RowIndex).Cells("DepartmentID").Value

        ElseIf LookupName = "Employee" Then

            VID = grdAcctLookup.Rows(e.RowIndex).Cells(0).Value
            VCode = grdAcctLookup.Rows(e.RowIndex).Cells(1).Value
            VName = grdAcctLookup.Rows(e.RowIndex).Cells(2).Value

        Else

         VID = grdAcctLookup.Rows(e.RowIndex).Cells(0).Value
         VCode = grdAcctLookup.Rows(e.RowIndex).Cells(1).Value
         VName = grdAcctLookup.Rows(e.RowIndex).Cells(2).Value

      End If

      Me.Close()
   End Sub
   Private Sub chkActive_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkActive.CheckedChanged
      FillDt()
   End Sub
   Private Sub FillDt()
      dt = Nothing
      qryMain = LookupQuery
      dt = objCommon.GetDataTable(qryMain)
   End Sub



   Private Sub grdAcctLookup_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles grdAcctLookup.KeyDown
      If e.KeyCode = Keys.Enter Then
         If grdAcctLookup.Rows.Count > 0 Then
            Dim cell As DataGridViewCell = grdAcctLookup.CurrentCell()
                If LookupName = "ProductGRN" Then
                    VID = grdAcctLookup.Rows(cell.RowIndex).Cells(0).Value
                    VCode = grdAcctLookup.Rows(cell.RowIndex).Cells(1).Value
                    VName = grdAcctLookup.Rows(cell.RowIndex).Cells(2).Value
                    UOMID = grdAcctLookup.Rows(cell.RowIndex).Cells(3).Value
                    Me.Close()

                ElseIf LookupName = "GRNB" Then
                    VID = grdAcctLookup.Rows(cell.RowIndex).Cells("VID").Value
                    VCode = grdAcctLookup.Rows(cell.RowIndex).Cells("VCode").Value
                    VName = grdAcctLookup.Rows(cell.RowIndex).Cells("VNo").Value
                    Me.Close()

                ElseIf LookupName = "ProductOGP" Then
                    VID = grdAcctLookup.Rows(cell.RowIndex).Cells("VID").Value
                    VCode = grdAcctLookup.Rows(cell.RowIndex).Cells("VCode").Value
                    VName = grdAcctLookup.Rows(cell.RowIndex).Cells("VName").Value
                    UOMID = grdAcctLookup.Rows(cell.RowIndex).Cells("UOMID").Value
                    Me.Close()

                ElseIf LookupName = "InvProduct" Then
                    VID = grdAcctLookup.Rows(cell.RowIndex).Cells("VID").Value
                    VCode = grdAcctLookup.Rows(cell.RowIndex).Cells("VCode").Value
                    VName = grdAcctLookup.Rows(cell.RowIndex).Cells("ProductDesc").Value
                    UOMID = grdAcctLookup.Rows(cell.RowIndex).Cells("UomID").Value
                    Qty = grdAcctLookup.Rows(cell.RowIndex).Cells("Qty").Value
                    Me.Close()
                ElseIf LookupName = "SalesCustomer" Then
                    VID = grdAcctLookup.Rows(cell.RowIndex).Cells("VID").Value
                    VCode = grdAcctLookup.Rows(cell.RowIndex).Cells("VCode").Value
                    VName = grdAcctLookup.Rows(cell.RowIndex).Cells("VName").Value
                    Me.Close()
                    'UOMID = grdAcctLookup.Rows(e.RowIndex).Cells("UomID").Value
                    'Qty = grdAcctLookup.Rows(e.RowIndex).Cells("Qty").Value
                ElseIf LookupName = "ProdSaleOrder" Then
                    VID = grdAcctLookup.Rows(cell.RowIndex).Cells("VID").Value
                    VCode = grdAcctLookup.Rows(cell.RowIndex).Cells("VNo").Value
                    VName = grdAcctLookup.Rows(cell.RowIndex).Cells("VName").Value
                    Me.Close()

                ElseIf LookupName = "StProduct" Then
                    VID = grdAcctLookup.Rows(cell.RowIndex).Cells("VID").Value
                    VName = grdAcctLookup.Rows(cell.RowIndex).Cells("VName").Value
                    Me.Close()

                ElseIf LookupName = "YarnOGP" Then
                    VID = grdAcctLookup.Rows(cell.RowIndex).Cells("VID").Value
                    VName = grdAcctLookup.Rows(cell.RowIndex).Cells("VCode").Value + "-" + grdAcctLookup.Rows(cell.RowIndex).Cells("VName").Value
                    SupplierID = grdAcctLookup.Rows(cell.RowIndex).Cells("SupplierID").Value
                    Me.Close()

                ElseIf LookupName = "Product" Then

                    VID = grdAcctLookup.Rows(cell.RowIndex).Cells(0).Value
                    VCode = grdAcctLookup.Rows(cell.RowIndex).Cells(1).Value
                    VName = grdAcctLookup.Rows(cell.RowIndex).Cells(2).Value
                    IsAccessory = grdAcctLookup.Rows(cell.RowIndex).Cells(3).Value
                    LeadTime = grdAcctLookup.Rows(cell.RowIndex).Cells(4).Value
                    ExcessPer = grdAcctLookup.Rows(cell.RowIndex).Cells(5).Value
                    Me.Close()
                ElseIf LookupName = "InvFetch" Then

                    VID = grdAcctLookup.Rows(cell.RowIndex).Cells(0).Value
                    VCode = grdAcctLookup.Rows(cell.RowIndex).Cells(1).Value
                    VName = grdAcctLookup.Rows(cell.RowIndex).Cells(2).Value
                    OrderNo = grdAcctLookup.Rows(cell.RowIndex).Cells("OrderNo").Value
                    OrderID = grdAcctLookup.Rows(cell.RowIndex).Cells("OrderID").Value
                    DepartmentID = grdAcctLookup.Rows(cell.RowIndex).Cells("DepartmentID").Value
                    Me.Close()

                ElseIf LookupName = "Employee" Then

                    VID = grdAcctLookup.Rows(cell.RowIndex).Cells(0).Value
                    VCode = grdAcctLookup.Rows(cell.RowIndex).Cells(1).Value
                    VName = grdAcctLookup.Rows(cell.RowIndex).Cells(2).Value
                    Me.Close()

                Else

                    VID = grdAcctLookup.Rows(cell.RowIndex).Cells(0).Value
                    VCode = grdAcctLookup.Rows(cell.RowIndex).Cells(1).Value
                    VName = grdAcctLookup.Rows(cell.RowIndex).Cells(2).Value
                    Me.Close()
                End If
            End If
      End If
   End Sub
End Class