Public Class ProdWagesOrder
    Dim qryMain, qry As String
    Dim objCommon As New clsCommon
   Private Sub ProdWagesOrder_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
      G_CURRENTDATE = Date.Now
      If G_CURRENTDATE > G_SOFTENDDATE Then
         End
      End If

      txtID.Text = ""
      objCommon.FillProdWagesMonth(Me.cmbWagesMonth)

      ClearHead("")
      FillHeader()
      cmbWagesMonth.Focus()

   End Sub
    Private Sub ClearHead(ByVal myid As String)
        'If myid = "" Then
        ''do not change txtID.Text 
        'Else
        cmbWagesMonth.SelectedIndex = 0
        txtID.Text = myid
        'IsActive.Checked = False
        'End If
        lblInformation.Text = ""
        grdRecord.DataSource = Nothing
        grdRecord.Rows.Clear()
        cmbWagesMonth.Focus()
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
        Dim grdcol6 As DataGridViewCheckBoxColumn = New DataGridViewCheckBoxColumn()

        grdcol0 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        grdcol1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        grdcol2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        grdcol3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        grdcol4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        grdcol5 = New System.Windows.Forms.DataGridViewTextBoxColumn()


        grdcol0.DataPropertyName = "VID"
        grdcol0.HeaderText = "VID"
        grdcol0.Name = "VID"
        grdcol0.Visible = False
        grdcol0.ReadOnly = False

        grdcol1.DataPropertyName = "OrderID"
        grdcol1.HeaderText = "Sale Order ID"
        grdcol1.Name = "OrderID"
        grdcol1.Visible = False
        grdcol1.ReadOnly = True

        grdcol2.DataPropertyName = "VNo"
        grdcol2.HeaderText = "Sale Order N0."
        grdcol2.Name = "VNo"
        grdcol2.ReadOnly = True



        grdcol3.DataPropertyName = "Vname"
        grdcol3.HeaderText = "Sale Order"
        grdcol3.Name = "Vname"
        grdcol3.Width = 300
        grdcol3.ReadOnly = True

        grdcol4.DataPropertyName = "OrderQtyCuttingActual"
        grdcol4.HeaderText = "OrderQty"
        grdcol4.Name = "OrderQtyCuttingActual"
        grdcol4.ReadOnly = True


        grdcol5.DataPropertyName = "VDate"
        grdcol5.HeaderText = "Order Date"
        grdcol5.Name = "VDate"
        grdcol5.ReadOnly = True


        grdcol6.DataPropertyName = "IsComplete"
        grdcol6.HeaderText = "IsComplete"
        grdcol6.Name = "IsComplete"
        grdcol6.ReadOnly = False




        Me.grdRecord.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {grdcol0, grdcol1, grdcol2, grdcol3, grdcol4, grdcol5, grdcol6})
    End Sub
   Private Sub FillGrid()
      If cmbWagesMonth.ValueMember = "" Then
         Return

      End If
      'grdRecord.DataSource = Nothing
      qryMain = "EXEC SpGetByShow_ProdSaleOrder " & cmbWagesMonth.SelectedValue & ""
      Dim dt As DataTable = objCommon.GetDataTable(qryMain)
      If IsNothing(dt) Then
         'grdRecord.DataSource = Nothing
         'FillHeader()
         'EmptyFields()
         Return
      End If
      If dt.Rows.Count <= 0 Then
         'grdRecord.DataSource = Nothing
         'EmptyFields()
         Return
      End If
      grdRecord.DataSource = dt
   End Sub

    Private Sub cmbWagesMonth_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbWagesMonth.SelectedIndexChanged
        FillForm()
        FillGrid()
    End Sub

    Private Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click
      lblInformation.Text = ""
      'varify for empty string
      'varify already existance
      If cmbWagesMonth.Text = "" Then
         MessageBox.Show("Please Select Month.", G_APP_TITLE)
         cmbWagesMonth.Focus()
         Return
      End If
        'qryMain = " Select top 1 isnull(L1Code,'') as L1Code from tblAcSetupCOAL1 where L1Code <> '" & txtID.Text & "' and VName='" & txtVName.Text & "'; "
        'qryMain = objCommon.ExecuteScalar(qryMain)
        'If qryMain <> "" Then
        '    MessageBox.Show("Account already exists.", G_APP_TITLE)
        '    Return
        'End If
        Try
            If txtID.Text Is "" Then 'update
                txtID.Text = 0                  '    qryMain = " update tblAcSetupCOAL1 set VName='" & txtVName.Text & "',GID='" & cmbGroup.SelectedValue & "' where L1Code = '" & txtID.Text & "'; "
            End If                   '    objCommon.ExecuteNonQuery(qryMain)
            'Else
            '    Dim strcode As String
            '    strcode = objCommon.ExecuteScalar("select isnull(max(cast(L1Code as int)),0) + 1 as L1Code from tblAcSetupCOAL1 where GID = " & cmbGroup.SelectedValue)
            '    strcode = Double.Parse(strcode).ToString("00")
            '    qryMain = "insert into tblAcSetupCOAL1 (L1Code, GID, VName, OldCode) values('" &
            '    strcode & "'," & cmbGroup.SelectedValue & ",'" & txtVName.Text & "','' );  "
            objCommon.openConnection()
            For Each grid As DataGridViewRow In grdRecord.Rows
                Dim IsComplete As Int32 = 0
                If Not IsDBNull(grid.Cells("IsComplete").Value) Then
                    IsComplete = Convert.ToInt32(grid.Cells("IsComplete").Value)
                End If

                'If grid.Cells("IsComplete").Value = 1 Then
                qryMain = "EXEC SpSave_ProdWagesOrder " & grid.Cells("VID").Value & "," & cmbWagesMonth.SelectedValue & ", " & grid.Cells("OrderID").Value & " ,'" & grid.Cells("VName").Value & "'," & grid.Cells("OrderQtyCuttingActual").Value & "," & grid.Cells("OrderQtyCuttingActual").Value & "," & IsComplete & "," & G_Compcode & ",1,1," & G_UID & ",'" & G_IPAddress & "'," & G_UID & ",'" & G_IPAddress & "'"
                objCommon.ExecuteNonQueryWithOpen(qryMain)
                'End If


            Next
            objCommon.CloseConnection()
            'ClearHead("")
            'FillHeader()
            FillGrid()
            lblInformation.Text = "Record Saved."
            txtID.Focus()
        Catch
            MessageBox.Show("Record Not Saved")
        Finally
            objCommon.CloseConnection()
        End Try
    End Sub

    Private Sub FillForm()

        lblInformation.Text = ""
        qryMain = "EXEC SpGetbyID_ProdWagesMonth " & cmbWagesMonth.SelectedValue.ToString & ""
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
        dtpVDateFrom.Value = dr("VDateFrom")
        dtpVDateTo.Value = dr("VDateTo")
    End Sub


End Class