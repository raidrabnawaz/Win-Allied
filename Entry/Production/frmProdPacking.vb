Public Class frmProdPacking
   Dim qryMain As String
   Dim qry As String
   Dim objCommon As New clsCommon
   Private Sub ProdPacking_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
      G_CURRENTDATE = Date.Now
      If G_CURRENTDATE > G_SOFTENDDATE Then
         End
      End If

      txtID.Text = ""
      objCommon.FillProdSaleOrder(Me.cmbSaleOrder)
      ClearHead("")
      FillHeader()
      txtID.Focus()
      dtpVdate.Value = DateTime.Now()

   End Sub

   Private Sub FillGrid()
      grdRecord.DataSource = Nothing
      grdRecord.Rows.Clear()
      grdRecord.Columns.Clear()
      FillHeader()
      qryMain = "EXEC SpGet_ProdPacking  " & cmbSaleOrder.SelectedValue.ToString & ""
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

      grdcol0 = New System.Windows.Forms.DataGridViewTextBoxColumn()
      grdcol1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
      grdcol2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
      grdcol3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
      grdcol4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
      grdcol5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
      grdcol6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
      grdcol7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
      grdcol8 = New System.Windows.Forms.DataGridViewTextBoxColumn()

      grdcol0.DataPropertyName = "VID"
      grdcol0.HeaderText = "VID"
      grdcol0.Name = "grdcol0"
      grdcol0.Visible = False
      '
      'grdcol1
      's

      grdcol1.DataPropertyName = "SrlNO"
      grdcol1.HeaderText = "Srl No"
      grdcol1.Name = "grdcol1"
      grdcol1.Width = 100


      grdcol2.DataPropertyName = "OrderID"
      grdcol2.HeaderText = "Sale Order Id"
      grdcol2.Name = "grdcol2"
      grdcol2.Visible = False


      grdcol3.DataPropertyName = "OrderName"
      grdcol3.HeaderText = "Sale Order"
      grdcol3.Name = "grdcol3"
      grdcol3.Width = 100

      grdcol4.DataPropertyName = "SizeID"
      grdcol4.HeaderText = "Size Id"
      grdcol4.Name = "grdcol4"
      grdcol4.Visible = False

      grdcol5.DataPropertyName = "SizeName"
      grdcol5.HeaderText = "Size"
      grdcol5.Name = "grdcol5"
      grdcol5.Width = 100


      grdcol6.DataPropertyName = "SizesQuantity"
      grdcol6.HeaderText = "SizeQty"
      grdcol6.Name = "grdcol6"
      grdcol6.Width = 100

      grdcol7.DataPropertyName = "Quantity"
      grdcol7.HeaderText = "PCs/Qty"
      grdcol7.Name = "grdcol7"
      grdcol7.Width = 100



      grdcol8.DataPropertyName = "VDate"
      grdcol8.HeaderText = "Date"
      grdcol8.Name = "grdcol8"
      grdcol8.Width = 100

      Me.grdRecord.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {grdcol0, grdcol1, grdcol2, grdcol3, grdcol4, grdcol5, grdcol6, grdcol7, grdcol8})

   End Sub

   Private Sub ClearHead(ByVal v As String)
      'If myid = "" Then
      ''do not change txtID.Text 
      'Else
      txtID.Text = ""
      cmbSaleOrder.SelectedIndex = 0
      txtQty.Text = ""
      txtSizeQty.Text = "0"
        'cmbSizes.Text = ""
        'End If
        lblInformation.Text = ""
      txtQty.Text = ""
        'txtSrlNo.Text = ""
        dtpVdate.Value = DateTime.Now()
   End Sub

   Private Sub grdRecord_MouseClick(ByVal sender As Object, ByVal e As MouseEventArgs) Handles grdRecord.MouseClick
      Dim MYID As String = grdRecord.Rows(grdRecord.CurrentCell.RowIndex).Cells(0).Value
      txtID.Text = MYID
      FillForm()
      cmbSaleOrder.Focus()

   End Sub

   Private Sub FillForm()
      lblInformation.Text = ""
      If txtID.Text = "" Then
         ClearHead("")
         Return
      End If
      qryMain = "EXEC SpGetbyID_ProdPacking'" & txtID.Text & "' "
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
      cmbSaleOrder.SelectedValue = dr("OrderID")
        'cmbSizes.SelectedValue = dr("SizeID")
        txtSizeQty.Text = dr("SizesQuantity")
      txtQty.Text = dr("Quantity")
        'txtSrlNo.Text = dr("SrlNo")
        dtpVdate.Text = dr("VDate")
   End Sub

   Private Sub btnAdd_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnAdd.Click
      Try 

         lblInformation.Text = ""
         'varify for empty string
         'varify already existance
         Dim ErrMsg As String = verifySave()
         If Not ErrMsg = "" Then
            MessageBox.Show(ErrMsg, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
         End If

         
         'qryMain = " Select top 1 isnull(L1Code,'') as L1Code from tblAcSetupCOAL1 where L1Code <> '" & txtID.Text & "' and VName='" & txtVName.Text & "'; "
         'qryMain = objCommon.ExecuteScalar(qryMain)
         'If qryMain <> "" Then
         '    MessageBox.Show("Account already exists.", G_APP_TITLE)
         '    Return
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

            'If txtSrlNo.Text = "" Then
            '   txtSrlNo.Text = 0
            'End If
            qryMain = "EXEC SpSave_ProdPacking " & txtID.Text & ",0, '001' ,'" & CDate(dtpVdate.Value).ToString("dd/MMM/yyyy") & "'," & cmbSaleOrder.SelectedValue & ",0," & txtSizeQty.Text & "," & txtQty.Text & "," & G_Compcode & "," & G_UID & ",'" & G_IPAddress & "'," & G_UID & ",'" & G_IPAddress & "'"

            objCommon.ExecuteNonQuery(qryMain)

         ClearHead("")
         FillGrid()
         lblInformation.Text = "Record Saved."
         txtID.Focus()
      Catch ex As Exception
         MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error)
      End Try
   End Sub

   Private Function verifySave() As String
      Dim verify As String = ""
       
      If txtQty.Text > txtSizeQty.Text Then
         verify &= "Quantity cannot be greater than Size Quantity" & vbNewLine
         txtQty.Focus() 
      End If
        Dim Lock As String
        Lock = objCommon.ExecuteScalar("select dbo.fnAllowBackDate('Win-ERP','frmProdPacking','" & CDate(dtpVdate.Value).ToString("dd/MMM/yyyy") & "'," & G_UID & "," & G_Compcode & ", " & G_FinancialYearID & ")")

        If Not (Lock = "") Then
            verify = Lock
            Return verify
        End If
        If cmbSaleOrder.Text = "" Or cmbSaleOrder.SelectedValue = 0 Then
         verify &= "Please give some Sale Order." & vbNewLine
         cmbSaleOrder.Focus()
      End If
        'If cmbSizes.Text = "" Or cmbSizes.SelectedValue = 0 Then
        '   verify &= "Please give some Size." & vbNewLine
        '   cmbSizes.Focus()
        'End If
        If txtQty.Text = "" Then
         verify &= "Please give some Quantity." & vbNewLine
         txtQty.Focus() 
      End If

      Return verify
   End Function

   Private Sub btnNew_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnNew.Click
      ClearHead("")
      txtID.Focus()

   End Sub

    'Private Sub cmbSaleOrder_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbSaleOrder.SelectedIndexChanged
    '   objCommon.FillProdSaleOrderSizes(Me.cmbSizes, Setdouble(cmbSaleOrder.SelectedValue.ToString), "CutBreakup")
    '   FillGrid()

    'End Sub


    'Private Sub cmbSizes_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    If cmbSizes.SelectedIndex > 0 Then
    '        qry = "EXEC SpGet_ProdFinishingSizeQty  " & cmbSizes.SelectedValue.ToString & "," & cmbSaleOrder.SelectedValue.ToString & ""
    '        txtSizeQty.Text = objCommon.ExecuteScalar(qry)
    '    End If

    'End Sub

    Private Sub txtQty_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtQty.KeyPress
      Dim dotLength As Integer = 1
      dotLength = Me.txtQty.Text.Split(".").Length
      If e.KeyChar <> ControlChars.Back Then
         If dotLength > 1 Then
            e.Handled = Not (Char.IsDigit(e.KeyChar))
         Else
            e.Handled = Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = ".")
         End If
      End If
   End Sub
End Class