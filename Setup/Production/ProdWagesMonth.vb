Public Class ProdWagesMonth
    Dim qryMain As String
    Dim objCommon As New clsCommon
   Private Sub ProdWagesMonth_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
      G_CURRENTDATE = Date.Now
      If G_CURRENTDATE > G_SOFTENDDATE Then
         End
      End If

      txtID.Text = ""
      ClearHead("")
      FillHeader()
      FillGrid()
      txtVName.Focus()
   End Sub

    Private Sub ClearHead(ByVal myid As String)
        'If myid = "" Then
        ''do not change txtID.Text 
        'Else
        txtID.Text = myid
        'End If
        lblInformation.Text = ""
        txtVName.Text = ""
        txtVName.Focus()
    End Sub
    Private Sub FillHeader()
        'grdRecord.DataSource = Nothing
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim grdcol0 As System.Windows.Forms.DataGridViewTextBoxColumn
        Dim grdcol1 As System.Windows.Forms.DataGridViewTextBoxColumn
        Dim grdcol2 As System.Windows.Forms.DataGridViewTextBoxColumn
        Dim grdcol3 As System.Windows.Forms.DataGridViewTextBoxColumn

        grdcol0 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        grdcol1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        grdcol2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        grdcol3 = New System.Windows.Forms.DataGridViewTextBoxColumn()

        grdcol0.DataPropertyName = "VID"
        grdcol0.HeaderText = "VID"
        grdcol0.Name = "VID"
        grdcol0.Visible = False
        '

        grdcol1.DataPropertyName = "VName"
        grdcol1.HeaderText = "Month Name"
        grdcol1.Name = "VName"
        grdcol1.Width = 400

        grdcol2.DataPropertyName = "VDateFrom"
        grdcol2.HeaderText = "Month Start Date"
        grdcol2.Name = "VDateFrom"
        grdcol2.Width = 100

        grdcol3.DataPropertyName = "VDateTo"
        grdcol3.HeaderText = "Month End Date"
        grdcol3.Name = "VDateTo"
        grdcol3.Width = 100

        Me.grdRecord.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {grdcol0, grdcol1, grdcol2, grdcol3})
    End Sub
    Private Sub FillGrid()
        'grdRecord.DataSource = Nothing
        qryMain = "EXEC SpGetbyShow_FillGrid_ProdWagesMonth"
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
        qryMain = "EXEC SpGetbyID_ProdWagesMonth '" & txtID.Text & "' "
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
        dtpVDateFrom.Text = dr("VDateFrom")
        dtpVDateTo.Text = dr("VDateTo")

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        lblInformation.Text = ""
        'varify for empty string
        'varify already existance
        txtVName.Text = txtVName.Text.Trim.Replace("'", "")
        If txtVName.Text = "" Then
            MessageBox.Show("Please give some Name.", G_APP_TITLE)
            txtVName.Focus()
            Return
        End If
        If dtpVDateFrom.Value > dtpVDateTo.Value Then
            MessageBox.Show("Please give Correct Date.", G_APP_TITLE)
            dtpVDateTo.Focus()
            Return
        End If


        If txtID.Text Is "" or txtID.Text = "" Then 'update
            txtID.Text = 0                  '    qryMain = " update tblAcSetupCOAL1 set VName='" & txtVName.Text & "',GID='" & cmbGroup.SelectedValue & "' where L1Code = '" & txtID.Text & "'; "
        End If                   '    objCommon.ExecuteNonQuery(qryMain)
        'Else
        '    Dim strcode As String
        '    strcode = objCommon.ExecuteScalar("select isnull(max(cast(L1Code as int)),0) + 1 as L1Code from tblAcSetupCOAL1 where GID = " & cmbGroup.SelectedValue)
        '    strcode = Double.Parse(strcode).ToString("00")
        '    qryMain = "insert into tblAcSetupCOAL1 (L1Code, GID, VName, OldCode) values('" &
        '    strcode & "'," & cmbGroup.SelectedValue & ",'" & txtVName.Text & "','' );  "

        qryMain = "EXEC SpSave_ProdWagesMonth " & txtID.Text & ", '" & txtVName.Text & "','" & dtpVDateFrom.Value.ToString("dd/MMM/yyyy") & "','" & dtpVDateTo.Value.ToString("dd/MMM/yyyy") & "',0,0,1," & G_UID & ",'" & G_IPAddress & "'," & G_UID & ",'" & G_IPAddress & "'"

        objCommon.ExecuteNonQuery(qryMain)

        ClearHead("")
        FillGrid()
        lblInformation.Text = "Record Saved."
        txtVName.Focus()

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        ClearHead("")
        txtVName.Focus()
    End Sub

    Private Sub grdRecord_MouseClick(sender As Object, e As MouseEventArgs) Handles grdRecord.MouseClick
        If grdRecord.Rows.Count > 0 Then
            Dim MYID As String = grdRecord.Rows(grdRecord.CurrentCell.RowIndex).Cells(0).Value
            txtID.Text = MYID
            FillForm()
            txtVName.Focus()
        End If

    End Sub
End Class