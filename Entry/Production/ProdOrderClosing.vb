Public Class ProdOrderClosing
    Dim qryMain As String
    Dim objCommon As New clsCommon
    Dim searchType As Int16
    Private Sub btnFill_Click(sender As Object, e As EventArgs) Handles btnFill.Click
        FillGrid()
    End Sub
    Private Sub FillHeader()
        'grdRecord.DataSource = Nothing
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim grdcol0 As System.Windows.Forms.DataGridViewTextBoxColumn
        Dim grdcol1 As System.Windows.Forms.DataGridViewTextBoxColumn
        Dim grdcol2 As System.Windows.Forms.DataGridViewTextBoxColumn
        Dim grdcol3 As System.Windows.Forms.DataGridViewTextBoxColumn
        Dim grdcol4 As System.Windows.Forms.DataGridViewTextBoxColumn
        Dim grdcol5 As System.Windows.Forms.DataGridViewTextBoxColumn
        Dim grdcol6 As System.Windows.Forms.DataGridViewCheckBoxColumn

        grdcol0 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        grdcol1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        grdcol2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        grdcol3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        grdcol4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        grdcol5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        grdcol6 = New System.Windows.Forms.DataGridViewCheckBoxColumn()

        grdcol0.DataPropertyName = "VID"
        grdcol0.HeaderText = "VID"
        grdcol0.Name = "grdcol0"
        grdcol0.Visible = False
        '
        'grdcol1
        's

        grdcol1.DataPropertyName = "SaleOrder"
        grdcol1.HeaderText = "Sale Order"
        grdcol1.Name = "grdcol1"
        grdcol1.Width = 400
        grdcol1.ReadOnly = True

        grdcol2.DataPropertyName = "BuyerPO"
        grdcol2.HeaderText = "PO No"
        grdcol2.Name = "grdcol2"
        grdcol2.ReadOnly = True

        grdcol3.DataPropertyName = "VDate"
        grdcol3.HeaderText = "Order Date"
        grdcol3.Name = "grdcol3"
        grdcol3.Width = 100
        grdcol3.ReadOnly = True

        grdcol4.DataPropertyName = "Qty"
        grdcol4.HeaderText = "Qty/Pcs"
        grdcol4.Name = "grdcol4"
        grdcol4.ReadOnly = True

        grdcol5.DataPropertyName = "Product"
        grdcol5.HeaderText = "Product"
        grdcol5.Name = "grdcol5"
        grdcol5.Width = 100
        grdcol5.ReadOnly = True


        grdcol6.DataPropertyName = "isclosed"
        grdcol6.HeaderText = "isclosed"
        grdcol6.Name = "isclosed"
        grdcol6.Width = 100


        Me.grdRecord.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {grdcol0, grdcol1, grdcol2, grdcol3, grdcol4, grdcol5, grdcol6})

    End Sub
    Private Sub FillGrid()
        If rdbtnOpen.Checked Then
            searchType = 0
        ElseIf rdbtnClosed.Checked Then
            searchType = 1
        ElseIf rdbtnAll.Checked Then
            searchType = 2
        End If
        grdRecord.DataSource = Nothing
        grdRecord.Rows.Clear()
        grdRecord.Columns.Clear()
        FillHeader()
        qryMain = "EXEC SpGet_ProdSaleOrder_Closing " & searchType & ""
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

    Private Sub btnSelectAll_Click(sender As Object, e As EventArgs) Handles btnSelectAll.Click
        For Each grid As DataGridViewRow In grdRecord.Rows
            grid.Cells("isclosed").Value = True
        Next
    End Sub

    Private Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click
        objCommon.openConnection()
        For Each grid As DataGridViewRow In grdRecord.Rows
            Dim isclosed As Int16 = 0
            If DBNull.Value.Equals(grid.Cells("isclosed").Value) Then
                isclosed = 0
            Else
                isclosed = grid.Cells("isclosed").Value
            End If
            qryMain = "EXEC SpSave_ProdSaleOrder_Closing  " & grid.Cells("grdcol0").Value.ToString() & "," & isclosed & "," & G_UID & ",'" & DateTime.Now.ToString("dd/MMM/yyyy") & "','" & G_IPAddress & "' "
            objCommon.ExecuteNonQueryWithOpen(qryMain)
        Next
        objCommon.CloseConnection()
    End Sub
End Class