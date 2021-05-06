Public Class ProdFabric
    Dim qryMain As String
    Dim objCommon As New clsCommon
   Private Sub frmAttCode_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
      G_CURRENTDATE = Date.Now
      If G_CURRENTDATE > G_SOFTENDDATE Then
         End
      End If

      txtID.Text = ""
      FillDropDown()
      ClearHead("")
      FillHeader()
      FillGrid()
      txtVName.Focus()
   End Sub

    Private Sub FillDropDown()
        txtVCode.Text = objCommon.ExecuteScalar("EXEC SpGetVCode_ProdFabric " & G_Compcode)
        objCommon.FillGPUOM(Me.cmbUom)
        objCommon.FillProdProductCategory(Me.cmbCategory)
        objCommon.FillProdFabricNature(Me.cmbFabricNature)
        objCommon.FillProdFabricBrand(Me.cmbFabricBrand)
        objCommon.FillProdProductType(Me.cmbProductType)
        objCommon.FillProdManufacturer(Me.cmbManufacturer)
        objCommon.FillProdColor(Me.cmbColor)
        objCommon.FillProdStretch(Me.cmbStretch)
        objCommon.FillProdGSM(Me.cmbGSM)
        objCommon.FillProdWeave(Me.cmbWeave)
        objCommon.FillProdFabricWidth(Me.cmbFabricWidth)

      'cmbCategory.AutoCompleteSource = AutoCompleteSource.ListItems
      'cmbCategory.AutoCompleteMode = AutoCompleteMode.SuggestAppend
    End Sub
    Private Sub ClearHead(ByVal myid As String)
        For Each ctl In SplitContainer1.Panel1.Controls
            If TypeOf ctl Is TextBox Then ctl.Text = ""
        Next ctl

        lblInformation.Text = ""
        cmbCategory.SelectedIndex = 0
        cmbFabricBrand.SelectedIndex = 0
        cmbUom.SelectedIndex = 0
        cmbColor.SelectedIndex = 0
        cmbFabricBrand.SelectedIndex = 0
        cmbFabricNature.SelectedIndex = 0
        cmbFabricWidth.SelectedIndex = 0
        cmbGSM.SelectedIndex = 0
        cmbManufacturer.SelectedIndex = 0
        cmbProductType.SelectedIndex = 0
        cmbStretch.SelectedIndex = 0
        cmbWeave.SelectedIndex = 0
        chkIsActive.Checked = False

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
        grdcol0.HeaderText = "Code"
        grdcol0.Name = "grdcol0"
        grdcol0.Visible = False
        '
        'grdcol1
        's
        grdcol1.DataPropertyName = "VCode"
        grdcol1.HeaderText = "Fabric Code"
        grdcol1.Name = "grdcol1"
        grdcol1.Width = 50

        grdcol2.DataPropertyName = "VName"
        grdcol2.HeaderText = "Fabric Description"
        grdcol2.Name = "grdcol2"
        grdcol2.Width = 400



        grdcol3.DataPropertyName = "IsActive"
        grdcol3.HeaderText = "Is Active"
        grdcol3.Name = "grdcol8"
        grdcol3.Visible = False


        Me.grdRecord.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {grdcol0, grdcol1, grdcol2, grdcol3})
    End Sub
    Private Sub FillGrid()
        'grdRecord.DataSource = Nothing
        qryMain = "EXEC SpGetbyShowProdFabric"
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
        qryMain = "EXEC SpGetbyIDProFabric'" & txtID.Text & "' "
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

        txtVName.Text = dr("VName")
        txtVCode.Text = dr("VCode")
        txtComposition.Text = dr("Composition")
        txtSuppCode.Text = dr("SupplierCode")
        txtImageType.Text = dr("ImageType")
        txtImageName.Text = dr("ImageName")
        txtImagePath.Text = dr("ImagePath")
        cmbCategory.SelectedValue = dr("CategoryID")
        cmbFabricBrand.SelectedIndex = dr("BrandID")
        cmbUom.SelectedValue = dr("UomID")
        cmbFabricNature.SelectedValue = dr("NatureID")
        cmbProductType.SelectedValue = dr("TypeID")
        cmbManufacturer.SelectedValue = dr("ManufacturerTypeID")
        cmbColor.SelectedValue = dr("ColorID")
        cmbStretch.SelectedValue = dr("StretchID")
        cmbGSM.SelectedValue = dr("GSMID")
        cmbFabricWidth.SelectedValue = dr("WidthID")
        cmbWeave.SelectedValue = dr("WeaveID")
        If (dr("IsActive") <> "1") Then
            chkIsActive.Checked = False
        Else
            chkIsActive.Checked = True
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

        'qryMain = " Select top 1 isnull(L1Code,'') as L1Code from tblAcSetupCOAL1 where L1Code <> '" & txtID.Text & "' and VName='" & txtVName.Text & "'; "
        'qryMain = objCommon.ExecuteScalar(qryMain)
        'If qryMain <> "" Then
        '    MessageBox.Show("Account already exists.", G_APP_TITLE)
        '    Return
        'End If
        If txtVName.Text = "" Then
            MessageBox.Show("Please give some Name.", G_APP_TITLE)
            txtVName.Focus()
            Return
        End If

        If txtID.Text Is "" or txtID.Text = "" Then 'update
            txtID.Text = 0
            txtVCode.Text = objCommon.ExecuteScalar("EXEC SpGetVCode_ProdFabric " & G_Compcode)     '    qryMain = " update tblAcSetupCOAL1 set VName='" & txtVName.Text & "',GID='" & cmbGroup.SelectedValue & "' where L1Code = '" & txtID.Text & "'; "
        End If                   '    objCommon.ExecuteNonQuery(qryMain)
        'Else
        '    Dim strcode As String
        '    strcode = objCommon.ExecuteScalar("select isnull(max(cast(L1Code as int)),0) + 1 as L1Code from tblAcSetupCOAL1 where GID = " & cmbGroup.SelectedValue)
        '    strcode = Double.Parse(strcode).ToString("00")
        '    qryMain = "insert into tblAcSetupCOAL1 (L1Code, GID, VName, OldCode) values('" &
        '    strcode & "'," & cmbGroup.SelectedValue & ",'" & txtVName.Text & "','' );  "

      qryMain = "EXEC SpSave_ProdFabric " & txtID.Text & ",'" & txtVCode.Text & "', '" & txtVName.Text & "','" & txtSuppCode.Text & "','" & txtComposition.Text & "'," & cmbCategory.SelectedValue & ",'" & cmbUom.SelectedValue _
         & "'," & cmbFabricBrand.SelectedValue & "," & cmbFabricNature.SelectedValue & "," & cmbProductType.SelectedValue & "," & cmbManufacturer.SelectedValue & "," & cmbColor.SelectedValue & "," & cmbGSM.SelectedValue _
         & "," & cmbWeave.SelectedValue & "," & cmbStretch.SelectedValue & "," & cmbFabricWidth.SelectedValue & ",'" & txtImageType.Text & "','" & txtImageName.Text & "','" & txtImagePath.Text & "'," & G_Compcode _
         & "," & G_Compcode & "," & chkIsActive.CheckState & "," & G_UID & ",'" & G_IPAddress & "'," & G_UID & ",'" & G_IPAddress & "'"

        objCommon.ExecuteNonQuery(qryMain)

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
            Dim MYID As String = grdRecord.Rows(grdRecord.CurrentCell.RowIndex).Cells(0).Value
            txtID.Text = MYID
            FillForm()
            txtVName.Focus()
        End If
    End Sub

End Class