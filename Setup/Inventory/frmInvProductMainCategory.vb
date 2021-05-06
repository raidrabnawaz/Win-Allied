Public Class frmInvProductMainCategory
    Dim qryMain, qry, Verify As String
    Dim objCommon As New clsCommon
   Private Sub frmAttCode_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
      G_CURRENTDATE = Date.Now
      If G_CURRENTDATE > G_SOFTENDDATE Then
         End
      End If
      qry = " Select count(VID) from InvProductMainCategory where GLPurchaseCode=0 and GLCostCode=0"
      Dim Cate = objCommon.ExecuteScalar(qry)
      If Cate > 0 Then
         MessageBox.Show(Cate + " Categories donnot have GLCodes linked", G_APP_TITLE)

      End If
      txtID.Text = ""
      'objCommon.FillAcSetupCOAGroup(cmbCategory)
      ClearHead("")
      FillHeader()
      FillGrid()
      txtVName.Focus()
   End Sub
   Private Sub ClearHead(ByVal myid As String)
      For Each ctl In SplitContainer1.Panel1.Controls
         If TypeOf ctl Is TextBox Then ctl.Text = ""
      Next ctl
       
      txtGLPurchase.Text = ""
      txtGLCost.Text = ""
      lblGLCostID.Text = "0"
      lblGLPurchaseID.Text = "0"
      lblInformation.Text = ""
      IsActive.Checked = False
      txtGLCost.Text = ""
      txtGLPurchase.Text = ""

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
      grdcol0.Name = "grdcol0"
      grdcol0.Visible = False
      '
      'grdcol1     VID, VName, GLPurchaseCode, GLCostCode, ItemFor, IsFixedAsset, DepriPer, LifeMonth
      '
      grdcol1.DataPropertyName = "VName"
        grdcol1.HeaderText = "Product Category"
        grdcol1.Name = "grdcol1"
      grdcol1.Width = 400
      '
      'grdcol2
      '
      grdcol2.DataPropertyName = "ItemFor"
      grdcol2.HeaderText = "ItemFor"
      grdcol2.Name = "grdcol2"
      grdcol2.Visible = False

      grdcol3.DataPropertyName = "DepriPer"
        grdcol3.HeaderText = "Depriciation"
        grdcol3.Name = "grdcol3"
      grdcol3.Width = 70

      grdcol4.DataPropertyName = "LifeMonth"
      grdcol4.HeaderText = "Life in Month"
      grdcol4.Name = "grdcol4"
      grdcol4.Width = 70

      grdcol5.DataPropertyName = "GLPurchaseName"
      grdcol5.HeaderText = "GL Purchase Code"
      grdcol5.Name = "grdcol5"
        grdcol5.Width = 150

        grdcol6.DataPropertyName = "GLCostName"
      grdcol6.HeaderText = "GL Cost Code"
      grdcol6.Name = "grdcol6"
        grdcol6.Width = 150

        grdcol7.DataPropertyName = "IsFixedAsset"
      grdcol7.HeaderText = "Is Fixed"
      grdcol7.Name = "grdcol7"
      grdcol7.Visible = False

      grdcol8.DataPropertyName = "GLPurchaseCode"
      grdcol8.HeaderText = "GLPurchaseName"
      grdcol8.Name = "grdcol8"
      grdcol8.Visible = False
      '
      grdcol9.DataPropertyName = "GLCostCode"
      grdcol9.HeaderText = "GLCostCode"
      grdcol9.Name = "grdcol9"
      grdcol9.Visible = False


      Me.grdRecord.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {grdcol0, grdcol1, grdcol2, grdcol3, grdcol4, grdcol5, grdcol6, grdcol7, grdcol8, grdcol9})
   End Sub
   Private Sub FillGrid()
      'grdRecord.DataSource = Nothing
      qryMain = "EXEC SpGet_invProductMainCategory"
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
   Private Sub FillForm()
      lblInformation.Text = ""
      If txtID.Text = "" Then
         ClearHead("")
         Return
      End If
      qryMain = "EXEC SpGetbyID_invProductMainCategory'" & txtID.Text & "' "
      Dim dt As DataTable = objCommon.GetDataTable(qryMain)
      If IsNothing(dt) Then
         'EmptyFields()
         Return
      End If
      If dt.Rows.Count <= 0 Then
         'EmptyFields()     VID, VName, GLPurchaseCode, GLCostCode, ItemFor, IsFixedAsset, DepriPer, LifeMonth
         Return
      End If
      Dim dr As DataRow = dt.Rows(0)
      txtVName.Text = dr("VName")
      'cmbCategory.SelectedValue = dr("ItemFor")
      txtDepriciation.Text = dr("DepriPer")
      txtGLPurchase.Text = dr("GLPurchaseName")
      txtGLCost.Text = dr("GLCostName")
      txtLifeMonth.Text = dr("LifeMonth")
      IsActive.Checked = dr("IsActive")
      lblGLPurchaseID.Text = dr("GLPurchaseCode")
      lblGLCostID.Text = dr("GLCostCode")
      If (dr("IsFixedAsset")) <> 0 Then
         IsFixed.Checked = True
      Else
         IsFixed.Checked = False
      End If

   End Sub
   Private Sub cmdNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNew.Click
      ClearHead("")
      txtVName.Focus()
   End Sub
   Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
      lblInformation.Text = ""
        'varify for empty string
        'varify already existance
        qryMain = "EXEC SpGetAlreadyExist_invProductMainCategory " & Setdouble(txtID.Text) & ",'" & txtVName.Text & "'"
        Verify = objCommon.ExecuteScalar(qryMain)
        If Not Verify = "" Then
            MessageBox.Show("This Product Category Already Exists", G_APP_TITLE)
            txtVName.Focus()
            Return
        End If



        txtVName.Text = txtVName.Text.Trim.Replace("'", "")
      If txtVName.Text = "" Then
         MessageBox.Show("Please give some Category Name.", G_APP_TITLE)
         txtVName.Focus()
         Return
      End If
      If txtLifeMonth.Text = "" Then
         MessageBox.Show("Please give some Life in Months.", G_APP_TITLE)
         txtLifeMonth.Focus()
         Return
      End If
      If txtDepriciation.Text = "" Then
         MessageBox.Show("Please give some Depriciation.", G_APP_TITLE)
         txtDepriciation.Focus()
         Return
      End If
      If lblGLPurchaseID.Text = "" Then
         MessageBox.Show("Please give some Purchase Code.", G_APP_TITLE)
         txtDepriciation.Focus()
         Return
      End If
      If lblGLCostID.Text = "" Then
         MessageBox.Show("Please give some Cost Code.", G_APP_TITLE)
         txtDepriciation.Focus()
         Return
      End If
      If txtID.Text Is "" Or txtID.Text = "" Then
         txtID.Text = 0
      End If


      'update
      '    qryMain = " update tblAcSetupCOAL1 set VName='" & txtVName.Text & "',GID='" & cmbCatetory.SelectedValue & "' where L1Code = '" & txtID.Text & "'; "
      '    objCommon.ExecuteNonQuery(qryMain)
      'Else
      '    Dim strcode As String
      '    strcode = objCommon.ExecuteScalar("select isnull(max(cast(L1Code as int)),0) + 1 as L1Code from tblAcSetupCOAL1 where GID = " & cmbCatetory.SelectedValue)
      '    strcode = Double.Parse(strcode).ToString("00")
      '    qryMain = "insert into tblAcSetupCOAL1 (L1Code, GID, VName, OldCode) values('" &
      '    strcode & "'," & cmbCatetory.SelectedValue & ",'" & txtVName.Text & "','' );  "

      qryMain = "EXEC SpSave_invProductMainCategory " & txtID.Text & ", '" & txtVName.Text & "', " & lblGLPurchaseID.Text & ", " & lblGLCostID.Text & ", 0, 0, 0, 0, " & IsFixed.CheckState & ", " & txtDepriciation.Text
      qryMain &= ", " & txtLifeMonth.Text & ", 0, 0, " & IsActive.CheckState & ", " & G_Compcode & ", " & G_FinancialYearID & ", " & G_UID & ", '" & G_IPAddress & "', " & G_UID & ", '" & G_IPAddress & "'"
      objCommon.ExecuteNonQuery(qryMain)
      '
      ClearHead("")
      FillGrid()
      lblInformation.Text = "Record Saved."
      txtVName.Focus()
   End Sub
   Private Sub cmdEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEdit.Click
      FillForm()
      txtVName.Focus()
   End Sub
   Private Sub cmdSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSearch.Click

   End Sub
   Private Sub cmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancel.Click
      ClearHead("")
      txtVName.Focus()
   End Sub
   Private Sub cmdDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDelete.Click

   End Sub
   Private Sub grdAtt_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles grdRecord.MouseClick
      If grdRecord.Rows.Count > 0 Then
         Dim MYID As String = grdRecord.Rows(grdRecord.CurrentCell.RowIndex).Cells("grdcol0").Value
         txtID.Text = MYID
         FillForm()
         txtVName.Focus()
      End If
   End Sub

   Private Sub txtLifeMonth_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtLifeMonth.KeyPress
      Dim dotLength As Integer = -1
      dotLength = Me.txtLifeMonth.Text.Split(".").Length
      If e.KeyChar <> ControlChars.Back Then
         If dotLength > -1 Then
            e.Handled = Not (Char.IsDigit(e.KeyChar))
         Else
            e.Handled = Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = ".")
         End If
      End If

   End Sub

   Private Sub txtDepriciation_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtDepriciation.KeyPress
      Dim dotLength As Integer = -1
      dotLength = Me.txtDepriciation.Text.Split(".").Length
      If e.KeyChar <> ControlChars.Back Then
         If dotLength > -1 Then
            e.Handled = Not (Char.IsDigit(e.KeyChar))
         Else
            e.Handled = Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = ".")
         End If
      End If
   End Sub



   Private Sub txtGLPurchase_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtGLPurchase.KeyDown
      If e.KeyCode = Keys.F2 Then
         frmLookupCOA.VCodeIni = txtGLPurchase.Text.Trim
         frmLookupCOA.VID = Convert.ToInt64(lblGLPurchaseID.Text.Trim)
         frmLookupCOA.VType = "ProdCat"
         frmLookupCOA.ShowDialog()
         If frmLookupCOA.VCode <> "" Then
            lblGLPurchaseID.Text = frmLookupCOA.VCode
            txtGLPurchase.Text = frmLookupCOA.VName
            frmLookupCOA.Dispose()
         End If
      End If
   End Sub

   Private Sub txtGLCost_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtGLCost.KeyDown
      If e.KeyCode = Keys.F2 Then
         frmLookupCOA.VCodeIni = txtGLCost.Text.Trim
         frmLookupCOA.VID = Convert.ToInt64(lblGLCostID.Text.Trim)
         frmLookupCOA.VType = "ProdCat"
         frmLookupCOA.ShowDialog()
         If frmLookupCOA.VCode <> "" Then
            lblGLCostID.Text = frmLookupCOA.VCode
            txtGLCost.Text = frmLookupCOA.VName
            frmLookupCOA.Dispose()
         End If
      End If
   End Sub
End Class