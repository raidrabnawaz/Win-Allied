Public Class frmInvSupplierPayment
   Dim qryMain As String
   Dim objCommon As New clsCommon
   Private Sub frmAttCode_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
      G_CURRENTDATE = Date.Now
      If G_CURRENTDATE > G_SOFTENDDATE Then
         End
      End If

      txtID.Text = ""
      ClearHead("")
      'FillHeader()
      'FillGrid()

      objCommon.FillInvSupplier(Me.cmbSupplier)
      objCommon.FillPOSBank(Me.cmbBank)
      FillGrid()
      txtNarration.Focus()
   End Sub
   Private Sub ClearHead(ByVal myid As String)
      'If myid = "" Then
      ''do not change txtID.Text 
      'Else
      txtVCode.Text = ""
      txtID.Text = myid
      cmbSupplier.SelectedValue = 0
      txtAmount.Text = "" 
      'End If
      lblInformation.Text = ""
      txtNarration.Text = ""
   End Sub
   'Private Sub FillHeader()
   '   'grdRecord.DataSource = Nothing
   '   Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
   '   Dim grdcol0 As System.Windows.Forms.DataGridViewTextBoxColumn
   '   Dim grdcol1 As System.Windows.Forms.DataGridViewTextBoxColumn
   '   Dim grdcol2 As System.Windows.Forms.DataGridViewTextBoxColumn
   '   Dim grdcol3 As System.Windows.Forms.DataGridViewTextBoxColumn
   '   Dim grdcol4 As System.Windows.Forms.DataGridViewTextBoxColumn
   '   Dim grdcol5 As System.Windows.Forms.DataGridViewTextBoxColumn
   '   Dim grdcol6 As System.Windows.Forms.DataGridViewTextBoxColumn
   '   Dim grdcol7 As System.Windows.Forms.DataGridViewTextBoxColumn


   '   grdcol0 = New System.Windows.Forms.DataGridViewTextBoxColumn()
   '   grdcol1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
   '   grdcol2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
   '   grdcol3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
   '   grdcol4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
   '   grdcol5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
   '   grdcol6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
   '   grdcol7 = New System.Windows.Forms.DataGridViewTextBoxColumn()

   '   grdcol0.DataPropertyName = "PurchaseOrderID"
   '   grdcol0.HeaderText = "VID"
   '   grdcol0.Name = "grdcol0"
   '   grdcol0.Visible = False
   '   grdcol0.ReadOnly = True
   '   '
   '   grdcol1.DataPropertyName = "VNO"
   '   grdcol1.HeaderText = "Voucher No"
   '   grdcol1.Name = "grdcol1"
   '   grdcol1.Width = 100
   '   grdcol1.ReadOnly = True
   '   '
   '   'grdcol1
   '   's
   '   grdcol2.DataPropertyName = "VDate"
   '   grdcol2.HeaderText = "Voucher Date"
   '   grdcol2.Name = "grdcol2"
   '   grdcol2.Width = 100
   '   grdcol2.ReadOnly = True

   '   grdcol3.DataPropertyName = "FreightAmount"
   '   grdcol3.HeaderText = "Freight Amount"
   '   grdcol3.Name = "grdcol3"
   '   grdcol3.Width = 100
   '   grdcol2.ReadOnly = True


   '   grdcol4.DataPropertyName = "Amount"
   '   grdcol4.HeaderText = "Amount"
   '   grdcol4.Name = "grdcol4"
   '   grdcol4.Width = 100
   '   grdcol4.ReadOnly = True


   '   grdcol5.DataPropertyName = "SupplierID"
   '   grdcol5.HeaderText = "SypplierID"
   '   grdcol5.Name = "grdcol5"
   '   grdcol5.Visible = False
   '   grdcol5.ReadOnly = True


   '   grdcol6.DataPropertyName = "IGPID"
   '   grdcol6.HeaderText = "IGPID"
   '   grdcol6.Name = "grdcol6"
   '   grdcol6.Visible = False
   '   grdcol6.ReadOnly = True


   '   grdcol7.DataPropertyName = "GRNID"
   '   grdcol7.HeaderText = "GRNID"
   '   grdcol7.Name = "grdcol7"
   '   grdcol7.Visible = False
   '   grdcol7.ReadOnly = True

   '   Me.grdRecord.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {grdcol0, grdcol1, grdcol2, grdcol3, grdcol4, grdcol5, grdcol6, grdcol7})
   'End Sub
   Private Sub FillGrid()
      'grdRecord.DataSource = Nothing   
      'qryMain = "EXEC SpGetByShow_InvPayment " & G_Compcode & ""
      qryMain = "EXEC spGetSupplierGRN '" & cmbSupplier.SelectedValue.ToString & "'"
      Dim dt As DataTable = objCommon.GetDataTable(qryMain)
      If IsNothing(dt) Then
         'EmptyFields()
         Return
      End If
      Dim row As String()
      For Each rows As DataRow In dt.Rows
         row = New String() {0, rows("PurchaseOrderID"), rows("SupplierID"), rows("IGPID"), rows("GRNID"), rows("PONO"), rows("OrderNo"), rows("GRNNO"), rows("GRNDate"), rows("FreightAmount"), rows("GRNAmount"), 0, rows("GRNAmount"), 0, 0, 0, ""}
         grdRecord.Rows.Add(row)
      Next rows
      If dt.Rows.Count <= 0 Then
         'EmptyFields()
         Return
      End If
      'grdRecord.DataSource = dt
   End Sub
   Private Sub FillForm()
      lblInformation.Text = ""
      If txtID.Text = "" Then
         ClearHead("")
         Return
      End If
      qryMain = "EXEC SpGetbyIDInvPaymentMainDetail '" & txtID.Text & "' "
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
      txtNarration.Text = dr("VName")
      txtVCode.Text = dr("VAbbr")
      txtAmount.Text = dr("VRate")
      cmbSupplier.SelectedValue = dr("CategoryID")
      'If (dr("IsActive") <> 1) Then
      '   IsActive.Checked = False
      'Else
      '   IsActive.Checked = True
      'End If
      'If (dr("isSpecial") <> 1) Then
      '   chkIsSpecial.Checked = False
      'Else
      '   chkIsSpecial.Checked = True
      'End If
   End Sub
   Private Sub cmdNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNew.Click
      ClearHead("")
      txtNarration.Focus()
   End Sub
   Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
      lblInformation.Text = ""
      'varify for empty string
      'varify already existance
      Try
         Dim ErrMsg As String = verifySave()
         If Not ErrMsg = "" Then
            MessageBox.Show(ErrMsg, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
         End If
      
      txtNarration.Text = txtNarration.Text.Trim.Replace("'", "")
      If txtNarration.Text = "" Then
         MessageBox.Show("Please give some Name.", G_APP_TITLE)
         Return
      End If
      'qryMain = "EXEC SpGetAlreadyExit_ProdOperation '" & txtID.Text & "','" & txtVCode.Text & "'; "
      'qryMain = objCommon.ExecuteScalar(qryMain)
      'If qryMain > 0 Then
      '   MessageBox.Show("Record already exists.", G_APP_TITLE)
      '   Return
      'End If

      If txtID.Text Is "" Then 'update
         txtID.Text = 0                  '    qryMain = " update tblAcSetupCOAL1 set VName='" & txtVName.Text & "',GID='" & cmbGroup.SelectedValue & "' where L1Code = '" & txtID.Text & "'; "
      End If                   '    objCommon.ExecuteNonQuery(qryMain)
      'Else
      '    Dim strcode As String
      '    strcode = objCommon.ExecuteScalar("select isnull(max(cast(L1Code as int)),0) + 1 as L1Code from tblAcSetupCOAL1 where GID = " & cmbGroup.SelectedValue)
      '    strcode = Double.Parse(strcode).ToString("00")
      '    qryMain = "insert into tblAcSetupCOAL1 (L1Code, GID, VName, OldCode) values('" &
      '    strcode & "'," & cmbGroup.SelectedValue & ",'" & txtVName.Text & "','' );  "
      Dim MID As Integer = 0
      qryMain = "EXEC SpSave_InvPayment " & txtID.Text & "," & cmbSupplier.SelectedValue & "," & txtVCode.Text & ", '" & txtAmount.Text & "','" & txtNarration.Text & "' ," & G_Compcode & "," & G_Compcode & " ,''," & G_UID & ",'" & G_IPAddress & "',''," & G_UID & ",'" & G_IPAddress & "'"
      MID = objCommon.ExecuteScalar(qryMain)
            objCommon.openConnection()
            For Each grid As DataGridViewRow In grdRecord.Rows
                qryMain = "EXEC SpSave_InvPaymentDet " & grid.Cells("VID").Value & ", " & MID & ", '" & grid.Cells("ProductID").Value & "', '', " & grid.Cells("UomID").Value & ", " & grid.Cells("Quantity").Value & ", " & G_UID & ", '" & G_IPAddress & "', " & G_UID & ",'" & G_IPAddress & "', " & IIf(grid.Cells("IsDel").Value = Nothing, 0, 1)
                objCommon.ExecuteNonQueryWithOpen(qryMain)
            Next
            objCommon.CloseConnection()
            ClearHead("")
      FillGrid()
      lblInformation.Text = "Record Saved."
         txtNarration.Focus()
      Catch ex As Exception
            MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            objCommon.CloseConnection()
        End Try
   End Sub

   Private Function verifySave() As String
      Dim verify As String = ""
      If grdRecord.Rows.Count = 0 Then
         verify &= "Must Enter Detail.!" & vbNewLine
         'txtVCode.Focus()
      End If
        Dim Lock As String
        Lock = objCommon.ExecuteScalar("select dbo.fnAllowBackDate('Win-ERP','frmInvSupplierPayment','" & CDate(dtpVDate.Value).ToString("dd/MMM/yyyy") & "'," & G_UID & "," & G_Compcode & ", " & G_FinancialYearID & ")")

        If Not (Lock = "") Then
            verify = Lock
            Return verify
        End If
        If grdRecord.Rows.Count = 1 And grdRecord.Rows(0).Visible = False Then
         verify &= "Must Enter Detail.!" & vbNewLine
         'txtVCode.Focus()
      End If

      'For Each grid As DataGridViewRow In grdRecord.Rows
      '   If Not Setdouble(grid.Cells("DetAmount").Value) > 0 Then
      '      verify &= "Please Add Some Amount.!" & vbNewLine
      '   End If
      'Next

      'If cmbPoType.SelectedValue = "-1" Then
      '    verify &= "Select Valid Department.!" & vbNewLine
      '    cmbPoType.Focus()
      'End If

      Return verify
   End Function

   Private Sub cmdEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEdit.Click
      FillForm()
      txtNarration.Focus()
   End Sub
   Private Sub cmdSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSearch.Click
      'FillGrid()
   End Sub
   Private Sub cmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancel.Click
      ClearHead("")
      txtNarration.Focus()
   End Sub
   Private Sub cmdDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDelete.Click

   End Sub
   Private Sub grdAtt_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles grdRecord.MouseClick
      'If grdRecord.Rows.Count > 0 Then
      '   Dim MYID As String = grdRecord.Rows(grdRecord.CurrentCell.RowIndex).Cells(0).Value
      '   txtID.Text = MYID
      '   FillForm()
      '   txtNarration.Focus()
      'End If
   End Sub

   Private Sub cmbSupplier_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbSupplier.SelectedIndexChanged
      FillGrid()
   End Sub

   Private Sub grdRecord_EditingControlShowing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles grdRecord.EditingControlShowing
      If grdRecord.CurrentCell.ColumnIndex = grdRecord.Columns("DetDiscount").Index Then
         AddHandler CType(e.Control, TextBox).KeyPress, AddressOf TextBox_keyPress
      ElseIf grdRecord.CurrentCell.ColumnIndex = 1 Then
         AddHandler CType(e.Control, TextBox).KeyPress, AddressOf TextBox_keyPress1
      End If
      If grdRecord.CurrentCell.ColumnIndex = grdRecord.Columns("DetExtra").Index Then
         AddHandler CType(e.Control, TextBox).KeyPress, AddressOf TextBox_keyPress1
      ElseIf grdRecord.CurrentCell.ColumnIndex = 1 Then
         AddHandler CType(e.Control, TextBox).KeyPress, AddressOf TextBox_keyPress1
      End If
      If grdRecord.CurrentCell.ColumnIndex = grdRecord.Columns("DetAmount").Index Then
         AddHandler CType(e.Control, TextBox).KeyPress, AddressOf TextBox_keyPress1
      ElseIf grdRecord.CurrentCell.ColumnIndex = 1 Then
         AddHandler CType(e.Control, TextBox).KeyPress, AddressOf TextBox_keyPress1
      End If
   End Sub
   Private Sub TextBox_keyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs)
      If e.KeyChar <> ControlChars.Back Then If Not (Char.IsDigit(CChar(CStr(e.KeyChar))) Or e.KeyChar = ".") Then e.Handled = True
      'If e.KeyChar <> ControlChars.Back Then If Char.IsDigit(CChar(CStr(e.KeyChar))) = False Then e.Handled = True
   End Sub

   Private Sub TextBox_keyPress1(ByVal sender As Object, ByVal e As KeyPressEventArgs)
      If e.KeyChar <> ControlChars.Back Then If Not (Char.IsDigit(CChar(CStr(e.KeyChar))) Or e.KeyChar = ".") Then e.Handled = True
   End Sub

   Private Sub grdRecord_CellEndEdit(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdRecord.CellEndEdit
      Dim EQty, Extra, PendingQty, Discount As Double
      If e.ColumnIndex = grdRecord.Columns("DetAmount").Index Then
         EQty = Setdouble(grdRecord.Rows(e.RowIndex).Cells(e.ColumnIndex).Value)
         Extra = Setdouble(grdRecord.Rows(e.RowIndex).Cells(e.ColumnIndex - 1).Value)
         Discount = Setdouble(grdRecord.Rows(e.RowIndex).Cells(e.ColumnIndex - 2).Value)
         grdRecord.Rows(e.RowIndex).Cells("DetAmount").Value = EQty + Extra - Discount
         'grdRecord.Rows(e.RowIndex).Cells("PendingAmount").Value = Setdouble(grdRecord.Rows(e.RowIndex).Cells("GRNAmount").Value) - Setdouble(grdRecord.Rows(e.RowIndex).Cells("CollectedAmount").Value)
         PendingQty = Setdouble(grdRecord.Rows(e.RowIndex).Cells("PendingAmount").Value)
         If EQty > PendingQty Then
            MessageBox.Show("Amount cannot be greater than Pending Amount.!", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            grdRecord.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = PendingQty
            EQty = PendingQty
         End If
          
      End If
   End Sub
End Class