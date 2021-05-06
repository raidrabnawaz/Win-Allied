Imports System.Data.SqlClient

Public Class ProdSaleOrderExpectedCost
   Dim qryMain As String
   Dim objCommon As New clsCommon
   Dim CWhere As String
   Private Sub frmACJV_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
      G_CURRENTDATE = Date.Now
      If G_CURRENTDATE > G_SOFTENDDATE Then
         End
      End If

      'txtID.Text = ""
      ClearHead("")

      FillGrid("")
      'txtID.Focus()
   End Sub
   Private Sub ClearHead(ByVal myid As String)
      'txtID.Text = myid
      txtVName.Text = ""
      lblVNo.Text = ""
      lblVID.Text = ""
      lblInformation.Text = ""
      'txtID.Text = ""
   End Sub
   Private Sub FillHeader()

   End Sub
   Private Sub Calculate_TotalAmount()
      Dim TotalAmount As Decimal
      For index As Integer = 0 To grdRecord.RowCount - 1
         TotalAmount += Convert.ToDecimal(grdRecord.Rows(index).Cells("Amount").Value)

      Next
      lblTotalAmount.Text = (Convert.ToDecimal(IIf(txtOtherCharges1.Text = "", 0, txtOtherCharges1.Text)) + Convert.ToDecimal(IIf(txtOtherCharges2.Text = "", 0, txtOtherCharges2.Text)) + Convert.ToDecimal(IIf(txtOtherCharges3.Text = "", 0, txtOtherCharges3.Text)) + Convert.ToDecimal(IIf(txtOtherCharges4.Text = "", 0, txtOtherCharges4.Text)) + TotalAmount)

   End Sub
   Private Sub txtOtherCharges1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtOtherCharges1.TextChanged
      Calculate_TotalAmount()
   End Sub

   Private Sub FillGrid(ByVal strSearch As String)
      grdRecord.Rows.Clear()
      FillHeader()
      'qryMain = " SELECT H.VID, H.VNo, H.VDate, H.PartyCode as DrCode, COA.VName AS DrName, H.ChequeNo, H.Amount, H.Remarks, H.BankCode as CrCode, isnull(B.VName,'') AS CrName " &
      '" FROM dbo.tblAcJV AS H INNER JOIN dbo.tblAcSetupCOA AS COA ON H.PartyCode = COA.VCode LEFT OUTER JOIN dbo.tblAcSetupCOA AS B ON H.BankCode = B.VCode " &
      '" " & strSearch & " ORDER BY H.VID desc "
      Try

         qryMain = "EXEC SpGETProdSOAccessoryCost @OrderID='" & lblVID.Text & "', @CompanyID=" & G_Compcode & ",@FinancialYearID=" & G_FinancialYearID & ",@UserID=" & G_UID & ""

         Dim dt As DataTable = objCommon.GetDataTable(qryMain)

         If IsNothing(dt) Then
            'EmptyFields()
            Return
         End If
         If dt.Rows.Count <= 0 Then
            'EmptyFields()
            Return
         End If
            grdRecord.Rows.Clear()
            txtOtherCharges1.Text = dt.Rows(0)("OtherCharges1").ToString
            txtOtherCharges2.Text = dt.Rows(0)("OtherCharges2").ToString
            txtOtherCharges3.Text = dt.Rows(0)("OtherCharges3").ToString
            txtOtherCharges4.Text = dt.Rows(0)("OtherCharges4").ToString
            lblTotalAmount.Text = Convert.ToInt32(dt.Rows(0)("OtherCharges1")) + Convert.ToInt32(dt.Rows(0)("OtherCharges2")) + Convert.ToInt32(dt.Rows(0)("OtherCharges3")) + Convert.ToInt32(dt.Rows(0)("OtherCharges4"))
            txtRemaeks.Text = dt.Rows(0)("Remarks").ToString
            Dim Col As Integer = 1
         For I As Integer = 0 To dt.Rows.Count - 1


                Dim row As String() = New String() {dt.Rows(I)("VID"), dt.Rows(I)("AccessoryID"), dt.Rows(I)("OrderID"), dt.Rows(I)("ProductID"), dt.Rows(I)("UOMID"), dt.Rows(I)("Product"), "", dt.Rows(I)("Qty"), "", dt.Rows(I)("Vrate"), dt.Rows(I)("Amount"), dt.Rows(I)("POQTY"), dt.Rows(I)("PORate"), dt.Rows(I)("POAmount"), (dt.Rows(I)("Amount") - dt.Rows(I)("POAmount"))}
            grdRecord.Rows.Add(row)
            
         Next
         Calculate_TotalAmount()
      Catch ex As Exception
         MessageBox.Show("No Record Found.")
      End Try
      'grdRecord.DataSource = dt
      'If grdRecord.Rows.Count > 0 Then setGrid(grdRecord)
   End Sub
   Private Sub FillForm()
      lblInformation.Text = ""

      Dim dt As DataTable = objCommon.GetDataTable(qryMain)
      If IsNothing(dt) Then
         ClearHead(0)
         Return
      End If
      If dt.Rows.Count <= 0 Then
         ClearHead(0)
         Return
      End If
      Dim dr As DataRow = dt.Rows(0)

      'txtID.Text = dr("VNo")
      'dtpIssueDate.Value = dr("VDate")
      'txtStoreName.Text = dr("ChequeNo")
   End Sub
   Private Sub cmdNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNew.Click
      ClearHead("")
      'txtID.Focus()
   End Sub
   Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
      lblInformation.Text = ""

      'Dim Lock As String
      'Lock = objCommon.ExecuteScalar("select dbo.fnAllowBackDate('Win-ERP','frmInvGoodsReceiptNote','" & CDate(DateTime.Now).ToString("dd/MMM/yyyy") & "'," & G_UID & "," & G_Compcode & ", " & G_FinancialYearID & ")")

      'If Not (Lock = "") Then
      '   MessageBox.Show(Lock)
      '   Return
      'End If
      Dim myVID As Label = New Label
      For Each grid As DataGridViewRow In grdRecord.Rows

         qryMain = "EXEC SpSave_ProdSaleOrderAccessoryRates " & grid.Cells("VID").Value & ",'---','" & grid.Cells("AccessoryID").Value.ToString & "','" & grid.Cells("OrderID").Value.ToString & "','" & grid.Cells("ProductID").Value.ToString & "','" & grid.Cells("UOMID").Value.ToString & "','" & grid.Cells("Product").Value.ToString & "','" & grid.Cells("Remarks").Value.ToString & "','" & grid.Cells("OtherCharges1").Value.ToString & "','" & grid.Cells("OtherCharges2").Value.ToString & "','" & grid.Cells("OtherCharges3").Value.ToString & "','" & grid.Cells("OtherCharges4").Value.ToString & "','" & grid.Cells("VRate").Value.ToString & "','" & grid.Cells("Rate").Value.ToString & "'," & G_UID & ",'" & G_IPAddress & "'," & G_UID & ",'" & G_IPAddress & "'"
         objCommon.ExecuteNonQuery(qryMain)

      Next

      'MessageBox.Show("Records inserted.")


      'End If
      ClearHead("")
      FillGrid("")
      lblInformation.Text = "Record Saved."
      'txtID.Focus()
   End Sub
   Private Sub cmdEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEdit.Click
      FillForm()
      'txtID.Focus()
   End Sub

   Private Sub grdRecord_EditingControlShowing(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles grdRecord.EditingControlShowing
      If grdRecord.CurrentCell.ColumnIndex = grdRecord.Columns("VRate").Index Then
         AddHandler CType(e.Control, TextBox).KeyPress, AddressOf TextBox_keyPress1
      ElseIf grdRecord.CurrentCell.ColumnIndex = 1 Then
         AddHandler CType(e.Control, TextBox).KeyPress, AddressOf TextBox_keyPress1
      End If

   End Sub
   Private Sub TextBox_keyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs)
      If e.KeyChar <> ControlChars.Back Then If Char.IsDigit(CChar(CStr(e.KeyChar))) = False Then e.Handled = True
   End Sub

   Private Sub TextBox_keyPress1(ByVal sender As Object, ByVal e As KeyPressEventArgs)
      If e.KeyChar <> ControlChars.Back Then If Not (Char.IsDigit(CChar(CStr(e.KeyChar))) Or e.KeyChar = ".") Then e.Handled = True
   End Sub

   Private Sub cmdSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSearch.Click
      FillGrid("")
      'txtVName.Text = txtVName.Text.Trim
      'FillGrid(" where H.VNo like '%" & txtVName.Text & "%' or H.PartyCode like '%" & txtVName.Text & "%' or H.BankCode like '%" & txtVName.Text & "%' or COA.VName like '%" & txtVName.Text & "%' or H.Remarks like '%" & txtVName.Text & "%' ")
   End Sub
   Private Sub cmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancel.Click
      ClearHead("")
      grdRecord.Rows.Clear()
      'txtID.Focus()
   End Sub
   Private Sub cmdDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDelete.Click
      'If Setdouble(txtID.Text) <= 0 Then
      '    lblInformation.Text = "Please select some record to delete."
      '    Return
      'End If

      If MessageBox.Show("Do You want to delete record?", G_APP_TITLE, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) = DialogResult.No Then
         Return
      End If

      'qryMain = " delete from tblAcJV where VID = " & txtID.Text & ";"
      objCommon.ExecuteNonQuery(qryMain)
      FillGrid("")
      ClearHead(0)
      lblInformation.Text = "Record removed."
   End Sub
   Private Sub grdAtt_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles grdRecord.MouseClick
      If grdRecord.Rows.Count > 0 Then
         Dim MYID As String = grdRecord.Rows(grdRecord.CurrentCell.RowIndex).Cells(0).Value
         'txtID.Text = MYID
         'FillForm()
         'txtID.Focus()
      End If
   End Sub

   Private Sub txtSearch_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtVName.KeyDown
      If e.KeyCode = Keys.F2 Then
         frmLookup.LookupQuery = "Exec SpGet_ProdSaleOrder "
         frmLookup.LookupName = "ProdSaleOrder"
         frmLookup.VID = ""
         frmLookup.VCode = ""
         frmLookup.VName = ""
         frmLookup.ShowDialog()
         If frmLookup.VID <> "" Then
            lblVID.Text = frmLookup.VID
            lblVNo.Text = frmLookup.VCode
            txtVName.Text = frmLookup.VName
            'FillForm()
         End If
      End If
   End Sub

   Private Sub grdRecord_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdRecord.CellClick
      Dim index As Integer
      If grdRecord.Rows.Count > 0 Then
         index = e.RowIndex
         'If e.ColumnIndex = grdRecord.Columns("AddExtraCharges").Index Then
         'Exit Sub

         'Dim newMDIChild As New frmProdOtherCharges()
         'newMDIChild.MdiParent = Me.ParentForm
         'newMDIChild.Show()

         Exit Sub
         'End If
      End If
   End Sub

   Private Sub grdRecord_CellEndEdit(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdRecord.CellEndEdit
      Dim Rate, Qty, POAmount As Decimal
      If e.ColumnIndex = grdRecord.Columns("VRate").Index Or e.ColumnIndex = grdRecord.Columns("VQuantity").Index Then
         Rate = Convert.ToDecimal(IIf(grdRecord.Rows(e.RowIndex).Cells("VRate").Value = "", 0, grdRecord.Rows(e.RowIndex).Cells("VRate").Value))
         Qty = Convert.ToDecimal(IIf(grdRecord.Rows(e.RowIndex).Cells("VQuantity").Value = "", 0, grdRecord.Rows(e.RowIndex).Cells("VQuantity").Value))
         POAmount = Convert.ToDecimal(IIf(grdRecord.Rows(e.RowIndex).Cells("POAmount").Value = "", 0, grdRecord.Rows(e.RowIndex).Cells("POAmount").Value))

         grdRecord.Rows(e.RowIndex).Cells("Amount").Value = Rate * Qty
         grdRecord.Rows(e.RowIndex).Cells("AmountDifference").Value = (Rate * Qty) - POAmount
      End If
      Calculate_TotalAmount()
   End Sub

   
   Private Sub txtOtherCharges2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtOtherCharges2.TextChanged
      Calculate_TotalAmount()
   End Sub

   Private Sub txtOtherCharges3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtOtherCharges3.TextChanged
      Calculate_TotalAmount()
   End Sub

   Private Sub txtOtherCharges4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtOtherCharges4.TextChanged
      Calculate_TotalAmount()
   End Sub
End Class