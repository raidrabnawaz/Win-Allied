Public Class frmCAOHead
    Dim qryMain As String
    Dim objCommon As New clsCommon
   Private Sub frmAttCode_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
      G_CURRENTDATE = Date.Now
      If G_CURRENTDATE > G_SOFTENDDATE Then
         End
      End If

      txtID.Text = ""
      objCommon.FillAcSetupCOAGroup(cmbGroup)
      ClearHead("")
      FillHeader()
      FillGrid()
      txtVName.Focus()
   End Sub
    Private Sub cmbGroup_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbGroup.SelectedIndexChanged
        If IsNothing(cmbGroup.SelectedValue) Then
            Return
        End If
        If cmbGroup.SelectedValue.ToString <> "System.Data.DataRowView" Then
            'objCommon.FillAccountGroup(cmbGroupL1, cmbGroup.SelectedValue)
        End If
    End Sub

    Private Sub ClearHead(ByVal myid As String)
        'If myid = "" Then
        ''do not change txtID.Text 
        'Else
        txtID.Text = myid
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


        grdcol0 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        grdcol1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        grdcol2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        grdcol3 = New System.Windows.Forms.DataGridViewTextBoxColumn()

        grdcol0.DataPropertyName = "L2Code"
        grdcol0.HeaderText = "L2Code"
        grdcol0.Name = "grdcol0"
        grdcol1.Width = 100
        '
        'grdcol1
        '
        grdcol1.DataPropertyName = "L1Code"
        grdcol1.HeaderText = "Group Code"
        grdcol1.Name = "grdcol1"
        grdcol1.Width = 100
        '
        'grdcol2
        '
        grdcol2.DataPropertyName = "GName"
        grdcol2.HeaderText = "AccGroup"
        grdcol2.Name = "grdcol2"
        grdcol2.Width = 200
        '
        'grdcol3
        '
        grdcol3.DataPropertyName = "VName"
        grdcol3.HeaderText = "AccHead"
        grdcol3.Name = "grdcol3"
        grdcol3.Width = 400

        Me.grdRecord.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {grdcol0, grdcol1, grdcol2, grdcol3})
    End Sub
    Private Sub FillGrid()
        'grdRecord.DataSource = Nothing
        qryMain = " SELECT H.L2Code, H.L1Code, G.VName AS GName, H.VName " & _
        " FROM dbo.tblAcSetupCOAL2 AS H INNER JOIN dbo.tblAcSetupCOAL1 AS G ON H.L1Code = G.L1Code ORDER BY H.L2Code, H.L1Code, GName, H.VName "
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

        qryMain = " SELECT H.L1Code, H.VName, G.GID " & _
        " FROM dbo.tblAcSetupCOAL2 AS H INNER JOIN dbo.tblAcSetupCOAL1 AS G ON H.L1Code = G.L1Code WHERE H.L2Code='" & txtID.Text & "' "

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
        cmbGroup.SelectedValue = dr("GID")
        cmbGroupL1.SelectedValue = dr("L1Code")
        txtVName.Text = dr("VName")
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

        If cmbGroup.SelectedValue <= 0 Then
            MessageBox.Show("Please select account type .", G_APP_TITLE)
            cmbGroup.Focus()
            Return
        End If
        If cmbGroupL1.SelectedValue <= 0 Then
            MessageBox.Show("Please select account group .", G_APP_TITLE)
            cmbGroupL1.Focus()
            Return
        End If



        qryMain = " Select top 1 isnull(L2Code,'') as L2Code from tblAcSetupCOAL2  where L2Code <> '" & txtID.Text & "' and VName='" & txtVName.Text & "' and L1Code = '" & cmbGroupL1.SelectedValue & "'; "
        qryMain = objCommon.ExecuteScalar(qryMain)
        If qryMain <> "" Then
            MessageBox.Show("Account already exists.", G_APP_TITLE)
            Return
        End If

        If txtID.Text <> "" Then 'update
            qryMain = " update tblAcSetupCOAL2 set VName='" & txtVName.Text & "'  where L2Code = '" & txtID.Text & "'; "
            objCommon.ExecuteNonQuery(qryMain)
        Else
            Dim strcode As String
            strcode = objCommon.ExecuteScalar("select isnull(max(cast(L2Code as int)),0) + 1  as L2Code from tblAcSetupCOAL2 where L1Code = '" & cmbGroupL1.SelectedValue & "'; ")
            strcode = Double.Parse(strcode).ToString("0000")
            strcode = cmbGroupL1.SelectedValue & strcode.Substring(2, 2)
            'strcode = cmbGroup.SelectedValue & Double.Parse(strcode).ToString("00")
            qryMain = "insert into tblAcSetupCOAL2 (L2Code, L1Code, VName, OldCode ) values('" & _
            strcode & "','" & cmbGroupL1.SelectedValue & "','" & txtVName.Text & "', '' );  "
            objCommon.ExecuteNonQuery(qryMain)
        End If
        ClearHead("")
        FillGrid()
        lblInformation.Text = "Record Saved."
        txtVName.Focus()
    End Sub ' pending
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