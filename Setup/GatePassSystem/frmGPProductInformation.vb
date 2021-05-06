Public Class frmGPProductInformation
    Dim qryMain As String
    Dim objCommon As New clsCommon
   Private Sub frmAttCode_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
      G_CURRENTDATE = Date.Now
      If G_CURRENTDATE > G_SOFTENDDATE Then
         End
      End If

      txtID.Text = ""
      objCommon.FillGPUOM(Me.cmbUom)
      objCommon.FillGPProductCategory(Me.cmbCategory)
      objCommon.FillGPProductType(Me.cmbProductType)
      ClearHead("")
      FillHeader()
      FillGrid()
      txtVCode.Focus()
      setGrid(grdRecord)
   End Sub
    Private Sub ClearHead(ByVal myid As String)
        For Each ctl In SplitContainer1.Panel1.Controls
            If TypeOf ctl Is TextBox Then ctl.Text = ""
        Next ctl

        lblInformation.Text = ""
        cmbCategory.SelectedIndex = 0
        cmbProductType.SelectedIndex = 0
      cmbUom.SelectedIndex = 0
      txtOpeningBalance.Text = 0
      txtRate.Text = 0
      txtBalanceAmount.Text = 0
      txtReckNo.Text = 0
        IsActive.Checked = False

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
        Dim grdcol13 As System.Windows.Forms.DataGridViewTextBoxColumn
        Dim grdcol14 As System.Windows.Forms.DataGridViewTextBoxColumn
        'Dim grdcol15 As System.Windows.Forms.DataGridViewTextBoxColumn
        'Dim grdcol8 As System.Windows.Forms.DataGridViewTextBoxColumn

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
        grdcol13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        grdcol14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        'grdcol15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        'grdcol8 = New System.Windows.Forms.DataGridViewTextBoxColumn()

        grdcol0.DataPropertyName = "VID"
        grdcol0.HeaderText = "Code"
        grdcol0.Name = "grdcol0"
        grdcol0.Visible = False
        '
        'grdcol1
        's
        grdcol1.DataPropertyName = "UOMID"
        grdcol1.HeaderText = "UOMID"
        grdcol1.Name = "grdcol1"
        grdcol1.Visible = False

        grdcol2.DataPropertyName = "ProductCategoryID"
        grdcol2.HeaderText = "ProductCategoryID"
        grdcol2.Name = "grdcol2"
        grdcol2.Visible = False

        grdcol3.DataPropertyName = "ProductTypeID"
        grdcol3.HeaderText = "ProductTypeID"
        grdcol3.Name = "grdcol3"
        grdcol3.Visible = False

        grdcol4.DataPropertyName = "VCode"
        grdcol4.HeaderText = "Code"
        grdcol4.Name = "grdcol4"
        grdcol4.Width = 100

        grdcol5.DataPropertyName = "VName"
        grdcol5.HeaderText = "Description"
        grdcol5.Name = "grdcol5"
      grdcol5.Width = 400

        grdcol6.DataPropertyName = "UOM"
        grdcol6.HeaderText = "UOM"
        grdcol6.Name = "grdcol6"
        grdcol6.Width = 70

        grdcol7.DataPropertyName = "ProductCategory"
        grdcol7.HeaderText = "Product Category"
        grdcol7.Name = "grdcol7"
        grdcol7.Width = 100


        grdcol8.DataPropertyName = "ProductType"
        grdcol8.HeaderText = "Product Type"
        grdcol8.Name = "grdcol8"
        grdcol8.Width = 100

        grdcol9.DataPropertyName = "OpeningBalance"
        grdcol9.HeaderText = "Opening Balance"
        grdcol9.Name = "grdcol9"
      grdcol9.Width = 100
      grdcol9.Visible = False


        grdcol10.DataPropertyName = "BalanceAmount"
        grdcol10.HeaderText = "Balance Amount"
        grdcol10.Name = "grdcol10"
      grdcol10.Width = 100
      grdcol10.Visible = False


        grdcol11.DataPropertyName = "PRate"
        grdcol11.HeaderText = "Rate"
        grdcol11.Name = "grdcol11"
      grdcol11.Width = 100
      grdcol11.Visible = False


        grdcol12.DataPropertyName = "ReckNo"
        grdcol12.HeaderText = "ReckNo"
        grdcol12.Name = "grdcol12"
        grdcol12.Visible = False

        grdcol13.DataPropertyName = "MinLevel"
        grdcol13.HeaderText = "MinLevel"
        grdcol13.Name = "grdcol13"
        grdcol13.Visible = False


        grdcol14.DataPropertyName = "IsActive"
        grdcol14.HeaderText = "Is Active"
        grdcol14.Name = "grdcol14"
        grdcol14.Visible = False

        Me.grdRecord.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {grdcol0, grdcol1, grdcol2, grdcol3, grdcol4, grdcol5, grdcol6, grdcol7, grdcol8, grdcol9, grdcol10, grdcol11, grdcol12, grdcol13, grdcol14})
    End Sub
    Private Sub FillGrid()
        'grdRecord.DataSource = Nothing
        qryMain = "EXEC SpGet_GPProductInfo"
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
        qryMain = "EXEC SpGetbyID_GPProductInfo'" & txtID.Text & "' "
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
        txtOpeningBalance.Text = dr("OpeningBalance")
        txtBalanceAmount.Text = dr("BalanceAmount")
        txtRate.Text = dr("PRate")
        txtReckNo.Text = dr("ReckNo")
        cmbCategory.SelectedValue = dr("ProductCategoryID")
        cmbProductType.SelectedValue = dr("ProductTypeID")
        cmbUom.SelectedValue = dr("UOMID")
        If (dr("IsActive") <> 1) Then
            IsActive.Checked = False
        Else
            IsActive.Checked = True
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
            MessageBox.Show("Please give some Product Description.", G_APP_TITLE)
            txtVName.Focus()
            Return
        End If
        If cmbProductType.SelectedIndex < 0 Then
            MessageBox.Show("Please select Product Type.", G_APP_TITLE)
            cmbProductType.Focus()
            Return
        End If
        If cmbCategory.SelectedIndex < 0 Then
            MessageBox.Show("Please select Product Category.", G_APP_TITLE)
            cmbCategory.Focus()
            Return
        End If
        If cmbUom.SelectedIndex < 0 Then
            MessageBox.Show("Please select UOM.", G_APP_TITLE)
            cmbUom.Focus()
            Return
        End If
        If txtOpeningBalance.Text = "" Then
            MessageBox.Show("Please give some Product Opening Balance.", G_APP_TITLE)
            txtOpeningBalance.Focus()
            Return
        End If
        If txtBalanceAmount.Text = "" Then
            MessageBox.Show("Please give some Product Balance Amount.", G_APP_TITLE)
            txtBalanceAmount.Focus()
            Return
        End If
        If txtRate.Text = "" Then
            MessageBox.Show("Please give some Product Rate.", G_APP_TITLE)
            txtRate.Focus()
            Return
        End If
        'qryMain = " Select top 1 isnull(L1Code,'') as L1Code from tblAcSetupCOAL1 where L1Code <> '" & txtID.Text & "' and VName='" & txtVName.Text & "'; "
        'qryMain = objCommon.ExecuteScalar(qryMain)
        'If qryMain <> "" Then
        '    MessageBox.Show("Account already exists.", G_APP_TITLE)
        '    Return
        'End If

        If txtID.Text = "" Then 'update
         txtID.Text = 0                  '    qryMain = " update tblAcSetupCOAL1 set VName='" & txtVName.Text & "',GID='" & cmbGroup.SelectedValue & "' where L1Code = '" & txtID.Text & "'; "
      End If                   '    objCommon.ExecuteNonQuery(qryMain)
        'Else
        '    Dim strcode As String
        '    strcode = objCommon.ExecuteScalar("select isnull(max(cast(L1Code as int)),0) + 1 as L1Code from tblAcSetupCOAL1 where GID = " & cmbGroup.SelectedValue)
        '    strcode = Double.Parse(strcode).ToString("00")
        '    qryMain = "insert into tblAcSetupCOAL1 (L1Code, GID, VName, OldCode) values('" &
        '    strcode & "'," & cmbGroup.SelectedValue & ",'" & txtVName.Text & "','' );  "

        qryMain = "EXEC SpSave_GPProductInfo " & txtID.Text & ", " & txtVCode.Text & ", '" & txtVName.Text & "'," & cmbUom.SelectedValue & ", " & cmbProductType.SelectedValue & "," & cmbCategory.SelectedValue & "," & txtOpeningBalance.Text & "," & txtBalanceAmount.Text & "," & txtRate.Text & ",'" & txtReckNo.Text & "',''," & IsActive.CheckState & "," & G_Compcode & "," & G_FinancialYearID & "," & G_UID & ",'" & G_IPAddress & "'"

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

    Private Sub txtOpeningBalance_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtOpeningBalance.KeyPress
        Dim dotLength As Integer = -1
        dotLength = Me.txtOpeningBalance.Text.Split(".").Length
        If e.KeyChar <> ControlChars.Back Then
            If dotLength > -1 Then
                e.Handled = Not (Char.IsDigit(e.KeyChar))
            Else
                e.Handled = Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = ".")
            End If
        End If
    End Sub

    Private Sub txtBalanceAmount_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtBalanceAmount.KeyPress
        Dim dotLength As Integer = -1
        dotLength = Me.txtBalanceAmount.Text.Split(".").Length
        If e.KeyChar <> ControlChars.Back Then
            If dotLength > -1 Then
                e.Handled = Not (Char.IsDigit(e.KeyChar))
            Else
                e.Handled = Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = ".")
            End If
        End If
    End Sub

    Private Sub txtRate_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtRate.KeyPress
        Dim dotLength As Integer = 1
        dotLength = Me.txtRate.Text.Split(".").Length
        If e.KeyChar <> ControlChars.Back Then
            If dotLength > 1 Then
                e.Handled = Not (Char.IsDigit(e.KeyChar))
            Else
                e.Handled = Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = ".")
            End If
        End If
    End Sub

   Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

   End Sub
End Class