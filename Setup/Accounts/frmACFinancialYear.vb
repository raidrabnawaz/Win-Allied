Public Class frmACFinancialYear
    Dim qryMain As String
    Dim objCommon As New clsCommon
    Dim Active As Int32
    Dim Trans As Int32
   Private Sub frmAttCode_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
      G_CURRENTDATE = Date.Now
      If G_CURRENTDATE > G_SOFTENDDATE Then
         End
      End If

      'txtID.Text = ""
      ClearHead("")
      FillHeader()
      FillGrid()
      txtVName.Focus()
   End Sub
    Private Sub ClearHead(ByVal myid As String)
        'If myid = "" Then
        ''do not change txtID.Text 
        'Else
        'txtID.Text = myid
        'End If
        lblInformation.Text = ""
        txtVName.Text = ""
    End Sub
    Private Sub FillHeader()
        'grdRecord.DataSource = Nothing
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim grdcol0 As System.Windows.Forms.DataGridViewTextBoxColumn
        Dim grdcol1 As System.Windows.Forms.DataGridViewTextBoxColumn
        'Dim grdcol2 As System.Windows.Forms.DataGridViewTextBoxColumn

        grdcol0 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        grdcol1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        'grdcol2 = New System.Windows.Forms.DataGridViewTextBoxColumn()

        grdcol0.DataPropertyName = "VID"
        grdcol0.HeaderText = "Code"
        grdcol0.Name = "grdcol0"
        grdcol1.Width = 100
        '
        'grdcol1
        's
        grdcol1.DataPropertyName = "VName"
        grdcol1.HeaderText = "Description"
        grdcol1.Name = "grdcol2"
        grdcol1.Width = 400
        Me.grdRecord.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {grdcol0, grdcol1})
    End Sub
    Private Sub FillGrid()
        'grdRecord.DataSource = Nothing
        qryMain = "EXEC SpGetbyShow_AccFinancialYear"
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
        qryMain = "EXEC SpGetbyID_AccFinancialYear " & lblVID.Text & " "
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
        'txtID.Text = dr("VCode")
        dtpDateFrom.Value = dr("DateFrom").ToString()
        dtpDateTo.Value = dr("DateTo").ToString()
        txtVName.Text = dr("VName")
        Active = Convert.ToInt32(dr("IsActive"))
        If (Active <> 1) Then
            isActive.Checked = False
        Else
            isActive.Checked = True
        End If
        Trans = Convert.ToInt32(dr("IsTransactional"))
        If (Trans <> 1) Then
            isTrasactional.Checked = False
        Else
            isTrasactional.Checked = True
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
        If txtVName.Text = "" Then
            MessageBox.Show("Please give some Name.", G_APP_TITLE)
            txtVName.Focus()
            Return
        End If
        If dtpDateFrom.Value > dtpDateTo.Value Then
            MessageBox.Show("Please give Correct Date.", G_APP_TITLE)
            dtpDateTo.Focus()
            Return
        End If
        'qryMain = " Select top 1 isnull(L1Code,'') as L1Code from tblAcSetupCOAL1 where L1Code <> '" & txtID.Text & "' and VName='" & txtVName.Text & "'; "
        'qryMain = objCommon.ExecuteScalar(qryMain)
        'If qryMain <> "" Then
        '    MessageBox.Show("Account already exists.", G_APP_TITLE)
        '    Return
        'End If

        'If txtID.Text Is "" or txtID.Text = "" Then 'update
        '    txtID.Text = 0                  '    qryMain = " update tblAcSetupCOAL1 set VName='" & txtVName.Text & "',GID='" & cmbGroup.SelectedValue & "' where L1Code = '" & txtID.Text & "'; "
        'End If                   '    objCommon.ExecuteNonQuery(qryMain)
        'Else
        '    Dim strcode As String
        '    strcode = objCommon.ExecuteScalar("select isnull(max(cast(L1Code as int)),0) + 1 as L1Code from tblAcSetupCOAL1 where GID = " & cmbGroup.SelectedValue)
        '    strcode = Double.Parse(strcode).ToString("00")
        '    qryMain = "insert into tblAcSetupCOAL1 (L1Code, GID, VName, OldCode) values('" &
        '    strcode & "'," & cmbGroup.SelectedValue & ",'" & txtVName.Text & "','' );  "
        If (isActive.Checked) Then
            Active = 1
        Else
            Active = 0
        End If
        If (isTrasactional.Checked) Then
            Trans = 1
        Else
            Trans = 0
        End If

        qryMain = "EXEC SpSave_AccFinancialYear " & lblVID.Text & ", '" & txtVName.Text & "','" & CDate(dtpDateFrom.Value).ToString("dd/MMM/yyyy") & "','" & CDate(dtpDateTo.Value).ToString("dd/MMM/yyyy") & "'," & Active & "," & Trans & ",5,14,'','',14,'',''"

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