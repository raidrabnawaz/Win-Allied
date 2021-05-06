Public Class frmInvProducts
    Dim qryMain, qry As String
    Dim objCommon As New clsCommon
    Private Sub frmAttCode_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        G_CURRENTDATE = Date.Now
        If G_CURRENTDATE > G_SOFTENDDATE Then
            End
        End If
        qry = " Select count(VID) from InvProduct where GLPurchaseCode=0 and GLCostCode=0"
        Dim Cate = objCommon.ExecuteScalar(qry)
        If Cate > 0 Then
            MessageBox.Show(Cate + " Products donnot have GLCodes linked", G_APP_TITLE)

        End If
        txtID.Text = ""
        objCommon.FillUoM(Me.cmbUom)
        objCommon.FillProductCategory(Me.cmbCategory)
        objCommon.FillProductType(Me.cmbProductType)
        ClearHead("")
        FillHeader()
        FillGrid()
        txtVCode.Focus()
        cmbCategory.SelectedIndex = 0
        cmbProductType.SelectedIndex = 0
        cmbUom.SelectedIndex = 0
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
        cmbCategory.SelectedValue = 0
        cmbProductType.SelectedValue = 0
        cmbUom.SelectedIndex = -1
        IsAccessory.Checked = False

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
        Dim grdcol10 As System.Windows.Forms.DataGridViewTextBoxColumn
        Dim grdcol11 As System.Windows.Forms.DataGridViewTextBoxColumn
        Dim grdcol12 As System.Windows.Forms.DataGridViewTextBoxColumn

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
        grdcol10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        grdcol11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        grdcol12 = New System.Windows.Forms.DataGridViewTextBoxColumn()

        grdcol0.DataPropertyName = "VID"
        grdcol0.HeaderText = "Code"
        grdcol0.Name = "grdcol0"
        grdcol0.Visible = False
        '
        'grdcol1
        's
        grdcol1.DataPropertyName = "VCode"
        grdcol1.HeaderText = "Code"
        grdcol1.Name = "grdcol1"
        grdcol1.Width = 50

        grdcol2.DataPropertyName = "VName"
        grdcol2.HeaderText = "Product Description"
        grdcol2.Name = "grdcol2"
        grdcol2.Width = 400

        grdcol3.DataPropertyName = "itemtype"
        grdcol3.HeaderText = "Product Type"
        grdcol3.Name = "grdcol3"
        grdcol3.Width = 120
        grdcol3.Visible = False

        grdcol4.DataPropertyName = "CategoryID"
        grdcol4.HeaderText = "Category ID"
        grdcol4.Name = "grdcol4"
        grdcol4.Visible = False

        grdcol5.DataPropertyName = "UomID"
        grdcol5.HeaderText = "Unit ID"
        grdcol5.Name = "grdcol5"
        grdcol5.Visible = False

        grdcol6.DataPropertyName = "UnitName"
        grdcol6.HeaderText = "UOM"
        grdcol6.Name = "grdcol6"
        grdcol6.Width = 100

        grdcol7.DataPropertyName = "CategoryName"
        grdcol7.HeaderText = "Product Category"
        grdcol7.Name = "grdcol7"
        grdcol7.Width = 140



        grdcol8.DataPropertyName = "IsActive"
        grdcol8.HeaderText = "Is Active"
        grdcol8.Name = "grdcol8"
        grdcol8.Visible = False

        grdcol9.DataPropertyName = "SubCategoryID"
        grdcol9.HeaderText = "SubCategoryID"
        grdcol9.Name = "grdcol9"
        grdcol9.Visible = False

        grdcol10.DataPropertyName = "SubCategoryName"
        grdcol10.HeaderText = "SubCategoryName"
        grdcol10.Name = "grdcol10"
        grdcol10.Visible = False

        grdcol11.DataPropertyName = "DetailCategoryID"
        grdcol11.HeaderText = "DetailCategoryID"
        grdcol11.Name = "grdcol11"
        grdcol11.Visible = False

        grdcol12.DataPropertyName = "DetailCategoryName"
        grdcol12.HeaderText = "DetailCategoryName"
        grdcol12.Name = "grdcol12"
        grdcol12.Visible = False

        Me.grdRecord.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {grdcol0, grdcol1, grdcol2, grdcol3, grdcol4, grdcol5, grdcol6, grdcol7, grdcol8, grdcol9, grdcol10, grdcol11, grdcol12})
    End Sub
    Private Sub FillGrid()
        'grdRecord.DataSource = Nothing
        qryMain = "EXEC SpGet_invProduct"
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
        qryMain = "EXEC SpGetbyID_invProduct'" & txtID.Text & "' "
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
        txtVCode.Text = dr("VCode")
        txtVName.Text = dr("VName")
        cmbCategory.SelectedValue = dr("CategoryID")
        cmbProductType.SelectedValue = dr("itemType")
        cmbUom.SelectedValue = dr("UOMID")
        lblGLCostID.Text = dr("GLCostCode")
        lblGLPurchaseID.Text = dr("GLPurchaseCode")
        txtGLCost.Text = dr("GLCostName")
        txtGLPurchase.Text = dr("GLPurchaseName")
        If (dr("IsAccessory")) <> 0 Then
            IsAccessory.Checked = True
        Else
            IsAccessory.Checked = False
        End If

    End Sub
    Private Sub cmdNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNew.Click
        ClearHead("")
        txtVCode.Focus()
    End Sub
    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        lblInformation.Text = ""
        'varify for empty string
        'varify already existance

        txtVCode.Text = txtVCode.Text.Trim.Replace("'", "")
        If txtVCode.Text = "" Then
            MessageBox.Show("Please give some Product Code.", G_APP_TITLE)
            txtVCode.Focus()
            Return
        End If
        If txtVName.Text = "" Then
            MessageBox.Show("Please give some Product Name.", G_APP_TITLE)
            txtVName.Focus()
            Return
        End If
        If cmbProductType.SelectedIndex <= 0 Then
            MessageBox.Show("Please give some Product Type.", G_APP_TITLE)
            cmbProductType.Focus()
            Return
        End If
        If cmbCategory.SelectedIndex <= 0 Then
            MessageBox.Show("Please give some Product Category.", G_APP_TITLE)
            cmbCategory.Focus()
            Return
        End If
        If cmbUom.SelectedIndex <= 0 Then
            MessageBox.Show("Please give some Product Uom.", G_APP_TITLE)
            cmbUom.Focus()
            Return
        End If

        If txtID.Text Is "" Or txtID.Text = "" Then 'update
            txtID.Text = 0                  '    qryMain = " update tblAcSetupCOAL1 set VName='" & txtVName.Text & "',GID='" & cmbGroup.SelectedValue & "' where L1Code = '" & txtID.Text & "'; "
        End If                   '    objCommon.ExecuteNonQuery(qryMain)



        qry = "EXEC SpGetAlreadyExist_InvProduct '" & txtID.Text & "','" & txtVCode.Text & "'; "
        qry = objCommon.ExecuteScalar(qry)
        If qry > 0 And txtID.Text = 0 Then
            MessageBox.Show("Product with this Code Already Exists", G_APP_TITLE)
            Return
        End If


        'Else
        '    Dim strcode As String
        '    strcode = objCommon.ExecuteScalar("select isnull(max(cast(L1Code as int)),0) + 1 as L1Code from tblAcSetupCOAL1 where GID = " & cmbGroup.SelectedValue)
        '    strcode = Double.Parse(strcode).ToString("00")
        '    qryMain = "insert into tblAcSetupCOAL1 (L1Code, GID, VName, OldCode) values('" &
        '    strcode & "'," & cmbGroup.SelectedValue & ",'" & txtVName.Text & "','' );  "

        qryMain = "EXEC SpSave_invProduct " & txtID.Text & ", " & txtVCode.Text & ", '" & txtVName.Text & "','" & lblGLPurchaseID.Text & "','" & lblGLCostID.Text & "', " & cmbProductType.SelectedValue & "," & cmbCategory.SelectedValue & "," & cmbUom.SelectedValue & ",1," & IsAccessory.CheckState & "," & G_Compcode & "," & G_FinancialYearID & "," & G_UID & ",'" & G_IPAddress & "'"

        objCommon.ExecuteNonQuery(qryMain)

        ClearHead("")
        FillGrid()
        lblInformation.Text = "Record Saved."
        txtVCode.Focus()
    End Sub
    Private Sub cmdEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEdit.Click
        FillForm()
        txtVCode.Focus()
    End Sub
    Private Sub cmdSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSearch.Click

    End Sub
    Private Sub cmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancel.Click
        ClearHead("")
        txtVCode.Focus()
    End Sub
    Private Sub cmdDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDelete.Click

    End Sub
    Private Sub grdAtt_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles grdRecord.MouseClick
        If grdRecord.Rows.Count > 0 Then
            Dim MYID As String = grdRecord.Rows(grdRecord.CurrentCell.RowIndex).Cells(0).Value
            txtID.Text = MYID
            FillForm()
            txtVCode.Focus()
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