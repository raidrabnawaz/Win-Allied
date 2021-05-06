Public Class ProdWagesEntry
   Dim qryMain, qry As String
   Dim objCommon As New clsCommon
   Private Sub frmAttCode_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
      G_CURRENTDATE = Date.Now
      If G_CURRENTDATE > G_SOFTENDDATE Then
         End
      End If

        txtID.Text = ""
        objCommon.FillProdWagesMonth(Me.cmbWagesMonth)
        objCommon.FillProdOperationCategory(Me.cmbOperationCategory)
        objCommon.FillProdSaleOrder(Me.cmbSaleOrder)
        ClearHead("")
      'FillGrid()
      cmbSaleOrder.Focus()
      setGrid(grdRecord)
   End Sub
   Private Sub ClearHead(ByVal myid As String)
        'If myid = "" Then
        ''do not change txtID.Text 
        'Else
        'cmbSetType.SelectedValue = 0
        'cmbOperation.SelectedValue = 0
        'txtVRate.Text = ""
        cmbSaleOrder.SelectedIndex = 0
        cmbWagesMonth.SelectedIndex = 0
        cmbOperationCategory.SelectedIndex = 0
        txtID.Text = myid
        lblSaleOrderDesc.Text = "-"
        'IsActive.Checked = False
        'End If
        lblInformation.Text = ""
      'txtQuantity.Text = ""
      'grdRecord.DataSource = Nothing
      'grdRecord.Rows.Clear()
      'FillHeader()
   End Sub
    
   Private Sub cmdNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNew.Click
      ClearHead("")
      cmbSaleOrder.Focus()
   End Sub
   Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
      lblInformation.Text = ""
        'varify for empty string
        'varify already existance
        'txtQuantity.Text = txtQuantity.Text.Trim.Replace("'", "")
        'If txtQuantity.Text = "" Then
        '   MessageBox.Show("Please give some Name.", G_APP_TITLE)
        '   Return
        'End If
        'qryMain = "EXEC SpGetAlreadyExit_ProdBrand '" & txtID.Text & "','" & txtVCode.Text & "'; "
        'qryMain = objCommon.ExecuteScalar(qryMain)
        'If qryMain > 0 Then
        '   MessageBox.Show("Record already exists.", G_APP_TITLE)
        '   Return
        'End If
        Try
            If txtID.Text Is "" Then 'update
                txtID.Text = 0                  '    qryMain = " update tblAcSetupCOAL1 set VName='" & txtVName.Text & "',GID='" & cmbGroup.SelectedValue & "' where L1Code = '" & txtID.Text & "'; "
            End If
            If cmbSaleOrder.Text = "" Or cmbSaleOrder.SelectedIndex = 0 Then
                MessageBox.Show("Please Select Sale Order.", G_APP_TITLE)
                cmbSaleOrder.Focus()
                Return
            End If
            'If cmbSetType.Text = "" Or cmbSetType.SelectedIndex = 0 Then
            '    MessageBox.Show("Please Select Operation Set.", G_APP_TITLE)
            '    cmbSetType.Focus()
            '    Return
            'End If
            '    objCommon.ExecuteNonQuery(qryMain)
            'Else 
            Dim EmpID, Qty As String
            '    strcode = objCommon.ExecuteScalar("select isnull(max(cast(L1Code as int)),0) + 1 as L1Code from tblAcSetupCOAL1 where GID = " & cmbGroup.SelectedValue)
            '    strcode = Double.Parse(strcode).ToString("00")
            '    qryMain = "insert into tblAcSetupCOAL1 (L1Code, GID, VName, OldCode) values('" &
            '    strcode & "'," & cmbGroup.SelectedValue & ",'" & txtVName.Text & "','' );  "'VID, SrlNo,SaleOrderID,OperationID,OperationQty,OperationName,Rate,EmployeeID,EmpCode,PCs,EmployeeName,Amount
            objCommon.openConnection()
            For Each grid As DataGridViewRow In grdRecord.Rows
                EmpID = grid.Cells("EmployeeID").Value
                Qty = grid.Cells("PCs").Value
                If Not EmpID Is Nothing Then
                    If Not Qty Is Nothing Then
                        qryMain = "EXEC SpSave_ProdWagesEntry " & grid.Cells("VID").Value & "," & grid.Cells("SrlNo").Value & "," & cmbWagesMonth.SelectedValue & "," & grid.Cells("EmployeeID").Value & "," & grid.Cells("EmpCode").Value & "," & grid.Cells("OrderID").Value & "," & grid.Cells("OperationID").Value & "," & grid.Cells("OperationQty").Value & "," & grid.Cells("Rate").Value & ",'" & grid.Cells("OperationName").Value & "'," & grid.Cells("PCs").Value & "," & G_Compcode & ",1," & G_UID & ",'" & G_IPAddress & "'," & G_UID & ",'" & G_IPAddress & "' "
                        objCommon.ExecuteNonQueryWithOpen(qryMain)
                    End If

                End If

            Next
            objCommon.CloseConnection()
            lblInformation.Text = "Record Saved."
            cmbSaleOrder.Focus()
        Catch
            MessageBox.Show("Record Not Saved")
        Finally
            objCommon.CloseConnection()
        End Try

        FillGridSaleOrderOperation()
   End Sub
   Private Sub cmdEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
      'FillForm()
      cmbSaleOrder.Focus()
   End Sub
   Private Sub cmdSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

   End Sub
   Private Sub cmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancel.Click
        ClearHead("")
        cmbSaleOrder.Focus()
    End Sub
    Private Sub cmdDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Private Sub grdAtt_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        'If grdRecord.Rows.Count > 0 Then
        '    Dim MYID As String = grdRecord.Rows(grdRecord.CurrentCell.RowIndex).Cells(0).Value
        '    txtID.Text = MYID
        '    FillForm()
        '    cmbSaleOrder.Focus()
        'End If
    End Sub

    Private Sub cmbSaleOrder_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cmbSaleOrder.SelectedIndexChanged
        If cmbSaleOrder.SelectedIndex = 0 Then
            ClearHead("")
        Else


        End If
    End Sub

    Private Sub FillGridSaleOrderOperation()
        grdRecord.Rows.Clear()
        qryMain = "EXEC SpGetbyOrderID_ProdSaleOrderOperation " & cmbSaleOrder.SelectedValue.ToString & "," & cmbOperationCategory.SelectedValue.ToString & " "
        Dim dt As DataTable = objCommon.GetDataTable(qryMain)
        If IsNothing(dt) Then
            'EmptyFields()
            Return
        End If
        If dt.Rows.Count <= 0 Then
            'EmptyFields()
            Return
        End If


        For I As Integer = 0 To dt.Rows.Count - 1
            Dim row As String() = New String() {0, dt.Rows(I)("SrlNo"), dt.Rows(I)("OrderID"), dt.Rows(I)("OperationID"), dt.Rows(I)("OperationName"), dt.Rows(I)("OrderPCs"), Math.Round(Decimal.Parse(dt.Rows(I)("VRate")), 2)}
            grdRecord.Rows.Add(row)
            'cmbSetType.SelectedIndex = dt.Rows(I)("SetTypeID")
        Next
        lblSaleOrderDesc.Text = dt.Rows(0)("SaleOrderDesc")
    End Sub


    Private Sub grdRecord_CellEndEdit(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdRecord.CellEndEdit
        Dim EmpName As String
        Dim EmpCode, EmpID, OperationPCs, PCs, Rate, Amount As Double
        If e.ColumnIndex = grdRecord.Columns("EmpCode").Index Then
            EmpCode = grdRecord.Rows(e.RowIndex).Cells(e.ColumnIndex).Value

            qry = "EXEC SpGet_EmpProdWagesEntry " & EmpCode & ""
            Dim dtt As DataTable = objCommon.GetDataTable(qry)
            If IsNothing(dtt) Then
                'EmptyFields()
                Return
            End If
            If dtt.Rows.Count <= 0 Then
                'EmptyFields()
                Return
            End If
            EmpID = dtt.Rows(0)("EmployeeID")
            EmpName = dtt.Rows(0)("EmployeeName")

            grdRecord.Rows(e.RowIndex).Cells("EmployeeID").Value = EmpID
            grdRecord.Rows(e.RowIndex).Cells("EmpName").Value = EmpName
            'SaleTaxPer = Setdouble(grdRecord.Rows(e.RowIndex).Cells("SaleTaxPer").Value)

        End If
        If e.ColumnIndex = grdRecord.Columns("PCs").Index Then
            PCs = Setdouble(grdRecord.Rows(e.RowIndex).Cells(e.ColumnIndex).Value)
            OperationPCs = Setdouble(grdRecord.Rows(e.RowIndex).Cells("OperationQty").Value)
            Rate = Setdouble(grdRecord.Rows(e.RowIndex).Cells("Rate").Value)
            If PCs > OperationPCs Then
                MessageBox.Show("PCs cannot be greater than Order PCs", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                grdRecord.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = OperationPCs
                PCs = OperationPCs
            End If
            grdRecord.Rows(e.RowIndex).Cells("Amount").Value = PCs * Rate

        End If
        If e.ColumnIndex = grdRecord.Columns("Rate").Index Then
            Rate = Setdouble(grdRecord.Rows(e.RowIndex).Cells(e.ColumnIndex).Value)
            PCs = Setdouble(grdRecord.Rows(e.RowIndex).Cells("PCs").Value)

            grdRecord.Rows(e.RowIndex).Cells("Amount").Value = PCs * Rate


        End If
        grdRecord.Item("ChangeColor", e.RowIndex).Style.BackColor = Color.Yellow
    End Sub

    Private Sub btnFill_Click(sender As Object, e As EventArgs) Handles btnFill.Click
        FillGridSaleOrderOperation()
    End Sub

    Private Sub grdRecord_MouseClick(sender As Object, e As MouseEventArgs) Handles grdRecord.MouseClick
        If e.Button = MouseButtons.Right Then
            cmdSave_Click(sender, e)
        End If
    End Sub

    Private Sub grdRecord_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles grdRecord.KeyDown
        If e.Control Then
            If e.KeyCode = Keys.S Then
                cmdSave.PerformClick()
            End If
        End If
    End Sub


End Class