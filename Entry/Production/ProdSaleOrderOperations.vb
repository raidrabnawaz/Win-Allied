Public Class ProdSaleOrderOperations
   Dim qryMain, qry As String
   Dim objCommon As New clsCommon
   Private Sub frmAttCode_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
      G_CURRENTDATE = Date.Now
      If G_CURRENTDATE > G_SOFTENDDATE Then
         End
      End If

      txtID.Text = ""
      objCommon.FillProdSetType(Me.cmbSetType)
      objCommon.FillProdSaleOrder(Me.cmbSaleOrder)
      objCommon.FillProdOperation(Me.cmbOperation)
      ClearHead("")
      FillHeader()
      'FillGrid()
      cmbSaleOrder.Focus()
      setGrid(grdRecord)
   End Sub
   Private Sub ClearHead(ByVal myid As String)
      'If myid = "" Then
      ''do not change txtID.Text 
      'Else
      'cmbSetType.SelectedValue = 0
      cmbOperation.SelectedValue = 0
      txtSrlNo.Clear()
      'cmbOperation.SelectedIndex = 0
      txtVRate.Text = "0"
      txtID.Text = myid
      'IsActive.Checked = False
      'End If
      lblInformation.Text = ""
      'txtQuantity.Text = ""
      grdRecord.DataSource = Nothing
      grdRecord.Rows.Clear()
      'FillHeader()
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
      Dim grdcol6 As System.Windows.Forms.DataGridViewTextBoxColumn
      Dim grdcol7 As System.Windows.Forms.DataGridViewTextBoxColumn
      Dim grdcol8 As System.Windows.Forms.DataGridViewTextBoxColumn
      Dim grdcol9 As System.Windows.Forms.DataGridViewTextBoxColumn

      grdcol0 = New System.Windows.Forms.DataGridViewTextBoxColumn()
      grdcol1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
      grdcol2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
      grdcol3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
      grdcol4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
      grdcol5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
      grdcol6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
      grdcol7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
      grdcol8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
      grdcol9 = New System.Windows.Forms.DataGridViewTextBoxColumn()

      grdcol0.DataPropertyName = "VID"
      grdcol0.HeaderText = "VID"
      grdcol0.Name = "VID"
      grdcol0.Visible = False
      grdcol0.ReadOnly = True
      '
      grdcol1.DataPropertyName = "SrlNo"
      grdcol1.HeaderText = "Srl No"
      grdcol1.Name = "SrlNo"
      grdcol1.Width = 100
      grdcol1.ReadOnly = True
      '
      'grdcol1
      's
      grdcol2.DataPropertyName = "OperationName"
      grdcol2.HeaderText = "Operation"
      grdcol2.Name = "OperationName"
      grdcol2.Width = 400
      grdcol2.ReadOnly = True

      grdcol3.DataPropertyName = "Quantity"
      grdcol3.HeaderText = "Quantity"
      grdcol3.Name = "Quantity"
      grdcol3.Width = 100
      grdcol3.ReadOnly = False


      grdcol4.DataPropertyName = "SetTypeID"
      grdcol4.HeaderText = "SetTypeID"
      grdcol4.Name = "SetTypeID"
      grdcol4.Visible = False
      grdcol4.ReadOnly = True

      grdcol5.DataPropertyName = "OperationID"
      grdcol5.HeaderText = "OperationID"
      grdcol5.Name = "OperationID"
      grdcol5.Visible = False
      grdcol5.ReadOnly = True

      grdcol6.DataPropertyName = "IsActive"
      grdcol6.HeaderText = "IsActive"
      grdcol6.Name = "IsActive"
      grdcol6.Visible = False
      grdcol6.ReadOnly = True


      grdcol7.DataPropertyName = "VRate"
      grdcol7.HeaderText = "Rate"
      grdcol7.Name = "VRate"
      grdcol7.ReadOnly = False

      grdcol8.DataPropertyName = "IsSpecial"
      grdcol8.HeaderText = "IsSpecial"
      grdcol8.Name = "IsSpecial"
      grdcol8.ReadOnly = True
      grdcol8.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells

      grdcol9.DataPropertyName = "  "
      grdcol9.HeaderText = "  "
      grdcol9.Name = "grdcol9"
      grdcol9.ReadOnly = True
      grdcol9.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells

      Me.grdRecord.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {grdcol0, grdcol1, grdcol2, grdcol3, grdcol4, grdcol5, grdcol6, grdcol7, grdcol8, grdcol9})
   End Sub
   'Private Sub FillGrid()
   '   grdRecord.Rows.Clear()
   '   qryMain = "EXEC SpGetbySetTypeID_ProdOperationSet '" & cmbSetType.SelectedValue.ToString & "' "
   '   Dim dt As DataTable = objCommon.GetDataTable(qryMain)
   '   If IsNothing(dt) Then
   '      'EmptyFields()
   '      Return
   '   End If
   '   If dt.Rows.Count <= 0 Then
   '      'EmptyFields()
   '      Return
   '   End If
   '   For I As Integer = 0 To dt.Rows.Count - 1
   '      Dim row As String() = New String() {0, dt.Rows(I)("SetTypeAbbr"), dt.Rows(I)("OprAbbr"), dt.Rows(I)("Quantity"), dt.Rows(I)("SetTypeID"), dt.Rows(I)("OperationID"), dt.Rows(I)("IsActive"), dt.Rows(I)("VRate"), dt.Rows(I)("IsSpecial")}
   '      grdRecord.Rows.Add(row)
   '   Next

   '   'grdRecord.DataSource = dt
   'End Sub
   'Private Sub FillForm()
   '   lblInformation.Text = ""
   '   If txtID.Text = "" Then
   '      ClearHead("")
   '      Return
   '   End If
   '   qryMain = "EXEC SpGetbyID_ProdOperationSet '" & txtID.Text & "' "
   '   Dim dt As DataTable = objCommon.GetDataTable(qryMain)
   '   If IsNothing(dt) Then
   '      'EmptyFields()
   '      Return
   '   End If
   '   If dt.Rows.Count <= 0 Then
   '      'EmptyFields()
   '      Return
   '   End If
   '   Dim dr As DataRow = dt.Rows(0)
   '   'txtQuantity.Text = dr("Quantity")
   '   cmbOperation.SelectedValue = dr("OperationID")
   '   cmbSetType.SelectedValue = dr("SetTypeID")
   'End Sub
   Private Sub cmdNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNew.Click
      ClearHead("")
      cmbSaleOrder.Focus()
   End Sub
   Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click

      txtSrlNo.Clear()
      cmbOperation.SelectedIndex = 0
      txtVRate.Text = "0"

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
            If txtID.Text Is "" Or txtID.Text = "0" Then 'update
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
            '    Dim strcode As String
            '    strcode = objCommon.ExecuteScalar("select isnull(max(cast(L1Code as int)),0) + 1 as L1Code from tblAcSetupCOAL1 where GID = " & cmbGroup.SelectedValue)
            '    strcode = Double.Parse(strcode).ToString("00")
            '    qryMain = "insert into tblAcSetupCOAL1 (L1Code, GID, VName, OldCode) values('" &
            '    strcode & "'," & cmbGroup.SelectedValue & ",'" & txtVName.Text & "','' );  "
            objCommon.openConnection()
            For Each grid As DataGridViewRow In grdRecord.Rows
                qryMain = "EXEC SpSave_ProdSaleOrderOperation " & grid.Cells("VID").Value & "," & grid.Cells("SrlNo").Value & "," & cmbSaleOrder.SelectedValue & "," & grid.Cells("SetTypeID").Value & ",'" & grid.Cells("OperationName").Value & "','" & dtpVDate.Value.ToString("dd/MMM/yyyy") & "', " & grid.Cells("Quantity").Value & "," & grid.Cells("OperationID").Value & "," & grid.Cells("VRate").Value & "," & grid.Cells("IsActive").Value & "," & grid.Cells("IsSpecial").Value & "," & G_Compcode & ",1," & G_UID & ",'" & G_IPAddress & "'," & G_UID & ",'" & G_IPAddress & "' "
                objCommon.ExecuteNonQueryWithOpen(qryMain)
            Next
            objCommon.CloseConnection()
            cmbOperation.SelectedIndex = 0
            cmbSetType.SelectedIndex = 0
            lblInformation.Text = "Record Saved."
            cmbSaleOrder.Focus()
        Catch
            MessageBox.Show("Record Not Saved")
        Finally
            objCommon.CloseConnection()
        End Try
    End Sub
   Private Sub cmdEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEdit.Click
      'FillForm()
      cmbSaleOrder.Focus()
   End Sub
   Private Sub cmdSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSearch.Click

   End Sub
   Private Sub cmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancel.Click
      ClearHead("")
      cmbSaleOrder.Focus()
   End Sub
   Private Sub cmdDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDelete.Click

   End Sub
   Private Sub grdAtt_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles grdRecord.MouseClick
      'If grdRecord.Rows.Count > 0 Then
      '    Dim MYID As String = grdRecord.Rows(grdRecord.CurrentCell.RowIndex).Cells(0).Value
      '    txtID.Text = MYID
      '    FillForm()
      '    cmbSaleOrder.Focus()
      'End If
   End Sub

   Private Sub cmbSetType_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbSetType.SelectedIndexChanged
      'If cmbSetType.SelectedIndex = 0 Then
      '    ClearHead("")
      'End If
      'FillGrid()
   End Sub





   Private Sub btnAdd_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnAdd.Click

      If cmbOperation.SelectedIndex = 0 Then
         MessageBox.Show("Please select some Operation.", G_APP_TITLE)
         cmbOperation.Focus()
         Return
      End If
      If cmbSaleOrder.SelectedIndex = 0 Then
         MessageBox.Show("Please select Sale Order.", G_APP_TITLE)
         cmbSaleOrder.Focus()
         Return
      End If
      Dim opr As Integer
      If txtID.Text = "" Then

         qry = "EXEC SpGetAlreadyExist_ProdSaleOrderOperations " & cmbOperation.SelectedValue.ToString & ", " & cmbSaleOrder.SelectedValue.ToString & ""
         opr = objCommon.ExecuteScalar(qry)
         If opr > 0 Then
            MessageBox.Show("You cannot add one Operation Multiple Times", G_APP_TITLE)
            cmbOperation.Focus()
            Return

         End If
      End If
      If txtSrlNo.Text Is "" Or txtSrlNo.Text = "0" Then 'update
         txtSrlNo.Text = 0                  '    qryMain = " update tblAcSetupCOAL1 set VName='" & txtVName.Text & "',GID='" & cmbGroup.SelectedValue & "' where L1Code = '" & txtID.Text & "'; "
      End If
      Dim row As String() = New String() {0, txtSrlNo.Text, cmbOperation.Text, 1, cmbSetType.SelectedValue, cmbOperation.SelectedValue, 1, txtVRate.Text, 1}
      grdRecord.Rows.Add(row)

      txtSrlNo.Clear()
      cmbOperation.SelectedIndex = 0
      txtVRate.Text = "0"
   End Sub


    Private Sub cmbSaleOrder_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cmbSaleOrder.SelectedIndexChanged
      If cmbSaleOrder.SelectedIndex = 0 Then
         ClearHead("")
      Else
         qry = "EXEC SpGet_ProdSaleOrderSetTypeID " & cmbSaleOrder.SelectedValue.ToString & ""
         cmbSetType.SelectedValue = objCommon.ExecuteScalar(qry)
         FillGridSaleOrderOperation()
      End If
   End Sub

   Private Sub FillGridSaleOrderOperation()
      grdRecord.Rows.Clear()
      qryMain = "EXEC SpGetbySaleOrderID_ProdSaleOrderOperation " & cmbSaleOrder.SelectedValue.ToString & "," & cmbSetType.SelectedValue.ToString & " "
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
         Dim row As String() = New String() {dt.Rows(I)("VID"), dt.Rows(I)("SrlNo"), dt.Rows(I)("OperationName"), Math.Round(Decimal.Parse(dt.Rows(I)("Quantity")), 2), dt.Rows(I)("SetTypeID"), dt.Rows(I)("OperationID"), dt.Rows(I)("IsActive"), Math.Round(Decimal.Parse(dt.Rows(I)("VRate")), 2), dt.Rows(I)("isSpecial")}
         grdRecord.Rows.Add(row)
         'cmbSetType.SelectedIndex = dt.Rows(I)("SetTypeID")
      Next

   End Sub

   Private Sub grdRecord_CellValueChanged(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles grdRecord.CellValueChanged
      Dim n As Integer = grdRecord.CurrentRow.Index
      grdRecord.Item("grdcol9", n).Style.BackColor = Color.Yellow
      grdRecord.Item("IsSpecial", n).Value = 1
   End Sub

   Private Sub Label1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Label1.Click

   End Sub

   Private Sub cmbOperation_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbOperation.SelectedIndexChanged
      Try
         qry = "EXEC SpGetbyID_ProdOperation '" & cmbOperation.SelectedValue.ToString & "' "
         Dim dtt As DataTable = objCommon.GetDataTable(qry)
         If IsNothing(dtt) Then
            'EmptyFields()
            Return
         Else
            Dim drr As DataRow = dtt.Rows(0)
            txtVRate.Text = drr("VRate")
         End If

      Catch ex As Exception
         'lblInformation.Text = ex.Message
      End Try
   End Sub
End Class