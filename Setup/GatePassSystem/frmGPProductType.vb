Public Class frmGPProductType
    Dim qryMain As String
    Dim objCommon As New clsCommon
   Private Sub frmAttCode_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
      G_CURRENTDATE = Date.Now
      If G_CURRENTDATE > G_SOFTENDDATE Then
         End
      End If

      lblVID.Text = ""
      objCommon.FillGPProductCategory(Me.cmbProductCategory)
      ClearHead("")
      FillHeader()
      FillGrid()
      txtVName.Focus()
   End Sub
    Private Sub ClearHead(ByVal myid As String)
        'If myid = "" Then
        ''do not change txtID.Text 
        'Else
        lblVID.Text = 0
        txtID.Text = ""
        IsActive.Checked = False
        cmbProductCategory.SelectedIndex = -1
        'End If
        lblInformation.Text = ""
        txtVName.Text = ""
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

        grdcol0 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        grdcol1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        grdcol2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        grdcol3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        grdcol4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        grdcol5 = New System.Windows.Forms.DataGridViewTextBoxColumn()

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
        grdcol1.Width = 100

        grdcol2.DataPropertyName = "VName"
        grdcol2.HeaderText = "Product Type"
        grdcol2.Name = "grdcol2"
        grdcol2.Width = 400

        grdcol3.DataPropertyName = "ProductCategoryID"
        grdcol3.HeaderText = "ProductCategoryID"
        grdcol3.Name = "grdcol3"
        grdcol3.Visible = False

        grdcol4.DataPropertyName = "CategoryName"
        grdcol4.HeaderText = "Product Category"
        grdcol4.Name = "grdcol4"
        grdcol4.Width = 200

        grdcol5.DataPropertyName = "IsActive"
        grdcol5.HeaderText = "Is Active"
        grdcol5.Name = "grdcol5"
        grdcol5.Width = 100

        Me.grdRecord.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {grdcol0, grdcol1, grdcol2, grdcol3, grdcol4, grdcol5})
    End Sub
    Private Sub FillGrid()
        'grdRecord.DataSource = Nothing
        qryMain = "EXEC SpGet_GPProductTypeInformation"
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
        If lblVID.Text = "" Then
            ClearHead("")
            Return
        End If
        qryMain = "EXEC SpGetbyID_GPProductTypeInformation'" & lblVID.Text & "' "
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
        txtID.Text = dr("VCode")
        cmbProductCategory.SelectedValue = dr("ProductCategoryID")
        If (dr("IsActive") <> 1) Then
            IsActive.Checked = False
        Else
            IsActive.Checked = True
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
      txtVName.Text = txtVName.Text.Trim.Replace("'", "")
        If txtID.Text = "" Then
            MessageBox.Show("Please give some Product Code.", G_APP_TITLE)
            txtID.Focus()
            Return
        End If
        If txtVName.Text = "" Then
            MessageBox.Show("Please give some Product Type.", G_APP_TITLE)
            txtVName.Focus()
            Return
        End If
        If cmbProductCategory.SelectedIndex < 0 Then
            MessageBox.Show("Please Select Product Category.", G_APP_TITLE)
            cmbProductCategory.Focus()
            Return
        End If
        'qryMain = " Select top 1 isnull(L1Code,'') as L1Code from tblAcSetupCOAL1 where L1Code <> '" & txtID.Text & "' and VName='" & txtVName.Text & "'; "
        'qryMain = objCommon.ExecuteScalar(qryMain)
        'If qryMain <> "" Then
        '    MessageBox.Show("Account already exists.", G_APP_TITLE)
        '    Return
        'End If

        If txtID.Text Is "" or txtID.Text = "" Then 'update
            txtID.Text = 0                  '    qryMain = " update tblAcSetupCOAL1 set VName='" & txtVName.Text & "',GID='" & cmbGroup.SelectedValue & "' where L1Code = '" & txtID.Text & "'; "
        End If                   '    objCommon.ExecuteNonQuery(qryMain)
        'Else
        '    Dim strcode As String
        '    strcode = objCommon.ExecuteScalar("select isnull(max(cast(L1Code as int)),0) + 1 as L1Code from tblAcSetupCOAL1 where GID = " & cmbGroup.SelectedValue)
        '    strcode = Double.Parse(strcode).ToString("00")
        '    qryMain = "insert into tblAcSetupCOAL1 (L1Code, GID, VName, OldCode) values('" &
        '    strcode & "'," & cmbGroup.SelectedValue & ",'" & txtVName.Text & "','' );  "

        qryMain = "EXEC SpSave_GPProductTypeInformation " & lblVID.Text & ",'" & txtID.Text & "','" & txtVName.Text & "',''," & cmbProductCategory.SelectedValue & "," & IsActive.CheckState & "," & G_Compcode & "," & G_FinancialYearID & "," & G_UID & ",'" & G_IPAddress & "'"

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
            lblVID.Text = MYID
            FillForm()
            txtVName.Focus()
        End If
    End Sub

End Class