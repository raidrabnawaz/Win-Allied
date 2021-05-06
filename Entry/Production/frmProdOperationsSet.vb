Public Class frmProdOperationsSet
    Dim qryMain, qry As String
    Dim objCommon As New clsCommon
   Private Sub frmAttCode_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
      G_CURRENTDATE = Date.Now
      If G_CURRENTDATE > G_SOFTENDDATE Then
         End
      End If

      txtID.Text = ""
      objCommon.FillProdOperation(Me.cmbOperation)
      objCommon.FillProdSetType(Me.cmbSetType)
      cmbSetType.SelectedIndex = 0

      ClearHead("")
      'FillHeader()
      txtSrlNo.Focus()
   End Sub
    Private Sub ClearHead(ByVal myid As String)
        'If myid = "" Then
        ''do not change txtID.Text 
        'Else
      cmbOperation.SelectedIndex = 0
        txtVRate.Text = "0"
        txtID.Text = myid
        'IsActive.Checked = False
        'End If
        lblInformation.Text = ""
        txtQuantity.Text = "1"
        txtSrlNo.Text = ""
      'txtSrlNo.Focus()
      FillHeader()
    End Sub
    Private Sub FillHeader()
      grdRecord.DataSource = Nothing 
      grdRecord.Rows.Clear()
      grdRecord.Columns.Clear()
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
        grdcol0.Name = "grdcol0"
        grdcol0.Visible = False
        '
        grdcol1.DataPropertyName = "SrlNo"
        grdcol1.HeaderText = "Srl No"
        grdcol1.Name = "grdcol1"
        grdcol1.Width = 100
        grdcol1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        '
        'grdcol1
        's
        grdcol2.DataPropertyName = "SetTypeID"
        grdcol2.HeaderText = "Item"
        grdcol2.Name = "grdcol2"
        grdcol2.Visible = False

        grdcol3.DataPropertyName = "SetTypeName"
        grdcol3.HeaderText = "Item"
        grdcol3.Name = "grdcol3"
        grdcol3.Width = 100
        grdcol3.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells


        grdcol4.DataPropertyName = "OperationID"
        grdcol4.HeaderText = "Operation"
        grdcol4.Name = "grdcol4"
        grdcol4.Width = 100
        grdcol4.Visible = False

        grdcol5.DataPropertyName = "OperationName"
        grdcol5.HeaderText = "Operation"
        grdcol5.Name = "grdcol5"
        grdcol5.Width = 100
        grdcol5.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill

        grdcol6.DataPropertyName = "Rate"
        grdcol6.HeaderText = "Rate"
        grdcol6.Name = "grdcol6"
        grdcol6.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells

        grdcol7.DataPropertyName = "Quantity"
        grdcol7.HeaderText = "Count"
        grdcol7.Name = "grdcol7"
        grdcol7.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells

        grdcol8.DataPropertyName = "IsActive"
        grdcol8.HeaderText = "IsActive"
        grdcol8.Name = "grdcol8"
        grdcol8.Visible = False

        grdcol9.DataPropertyName = "IsSpecial"
        grdcol9.HeaderText = "IsSpecial"
        grdcol9.Name = "grdcol9"
        grdcol9.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells


        Me.grdRecord.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {grdcol0, grdcol1, grdcol2, grdcol3, grdcol4, grdcol5, grdcol6, grdcol7})
    End Sub
    Private Sub FillGrid()
       
        qryMain = "EXEC SpGetbySetTypeID_ProdOperationSet " & cmbSetType.SelectedValue.ToString & ""
        Dim dt As DataTable = objCommon.GetDataTable(qryMain)
        If IsNothing(dt) Then
            'EmptyFields()
            Return
        End If
      If dt.Rows.Count <= 0 Then 
         FillHeader()
         'EmptyFields()
         Return
      End If
        grdRecord.DataSource = dt
    End Sub
    Private Sub FillForm()

        lblInformation.Text = ""
        If txtID.Text = "" Then
            ClearHead("")
            Return
        End If
        qryMain = "EXEC SpGetbyID_ProdOperationSet '" & txtID.Text & "' "
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
        txtQuantity.Text = dr("Quantity")
        txtSrlNo.Text = dr("SrlNo")
      cmbOperation.SelectedValue = dr("OperationID")
      cmbSetType.SelectedValue = dr("SetTypeID")
    End Sub

    Private Sub grdAtt_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles grdRecord.MouseClick
        If grdRecord.Rows.Count > 0 Then
            Dim MYID As String = grdRecord.Rows(grdRecord.CurrentCell.RowIndex).Cells(0).Value
            txtID.Text = MYID
            FillForm()
            txtQuantity.Focus()
        End If
    End Sub

    Private Sub cmbSetType_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbSetType.SelectedIndexChanged
      cmbOperation.SelectedIndex = 0
      txtVRate.Text = "0"
        txtQuantity.Text = "1"

        'ClearHead("")
        If cmbSetType.SelectedIndex = 0 Then
            ClearHead("")
        End If
        FillGrid()
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

         If txtID.Text Is "" Or txtID.Text = "" Then 'update
            txtID.Text = 0                  '    qryMain = " update tblAcSetupCOAL1 set VName='" & txtVName.Text & "',GID='" & cmbGroup.SelectedValue & "' where L1Code = '" & txtID.Text & "'; "
         End If


         If txtSrlNo.Text = "" Or txtSrlNo.Text = "" Then 'update
            txtSrlNo.Text = 0                  '    qryMain = " update tblAcSetupCOAL1 set VName='" & txtVName.Text & "',GID='" & cmbGroup.SelectedValue & "' where L1Code = '" & txtID.Text & "'; "
         End If
         '    objCommon.ExecuteNonQuery(qryMain)
         'Else
         '    Dim strcode As String
         '    strcode = objCommon.ExecuteScalar("select isnull(max(cast(L1Code as int)),0) + 1 as L1Code from tblAcSetupCOAL1 where GID = " & cmbGroup.SelectedValue)
         '    strcode = Double.Parse(strcode).ToString("00")
         '    qryMain = "insert into tblAcSetupCOAL1 (L1Code, GID, VName, OldCode) values('" &
         '    strcode & "'," & cmbGroup.SelectedValue & ",'" & txtVName.Text & "','' );  "

         qryMain = "EXEC SpSave_ProdOperationSet " & txtID.Text & "," & txtSrlNo.Text & ", " & cmbSetType.SelectedValue & " ," & cmbOperation.SelectedValue & "," & txtQuantity.Text & "," & G_Compcode & ",1," & G_UID & ",'" & G_IPAddress & "'," & G_UID & ",'" & G_IPAddress & "'"

         objCommon.ExecuteNonQuery(qryMain)

         ClearHead("")
         'FillHeader()
         FillGrid()
         lblInformation.Text = "Record Saved."
         txtID.Focus()
      Catch ex As Exception
         MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error)
      End Try

   End Sub

   Private Function verifySave() As String
      Dim verify As String = ""
       
      If cmbSetType.Text = "" Or cmbSetType.SelectedValue = 0 Then
         verify &= "Please give some Item." & vbNewLine
         cmbSetType.Focus()
      End If
      If cmbOperation.Text = "" Or cmbOperation.SelectedValue = 0 Then
         verify &= "Please give some Operation." & vbNewLine
         cmbOperation.Focus()
      End If
      If txtQuantity.Text = "" Then
         verify &= "Please give some Quantity." & vbNewLine
         txtQuantity.Focus() 
      End If
      Dim opr As Integer
      If txtID.Text = "" Then
         qry = "EXEC SpGetAlreadyExit_ProdOperationSet " & cmbOperation.SelectedValue.ToString & ", " & cmbSetType.SelectedValue.ToString & ""
         opr = objCommon.ExecuteScalar(qry)
            If opr > 0 Then
                verify &= "You cannot add one Operation Multiple Times" & vbNewLine
                cmbOperation.Focus()
            End If
            If txtQuantity.Text = "0" Then
                verify &= "Please give some Quantity greater than 0." & vbNewLine
                txtQuantity.Focus()
            End If
        End If
      Return verify
   End Function


    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
      cmbSetType.SelectedIndex = 0
      ClearHead("")
      txtSrlNo.Focus()

    End Sub

    Private Sub btnFetchOperations_Click(sender As Object, e As EventArgs) Handles btnFetchOperations.Click
        If cmbSetType.SelectedValue = 0 Then
            Return
        End If
        frmLookupOperations.SetTypeID = cmbSetType.SelectedValue
        frmLookupOperations.LookupQuery = "Exec SpGetbySetTypeID_ProdOperationSet_LookUp " & cmbSetType.SelectedValue.ToString & " "
            frmLookupOperations.LookupName = "ProdOperationSet"
            frmLookupOperations.VID = ""
            frmLookupOperations.VCode = ""
            frmLookupOperations.VName = ""
        frmLookupOperations.ShowDialog()
        qryMain = "EXEC spProdUpdateOperationSetSrl " & cmbSetType.SelectedValue & " "
        objCommon.ExecuteNonQuery(qryMain)
        FillGrid()
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