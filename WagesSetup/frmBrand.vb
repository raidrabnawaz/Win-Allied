Public Class frmBrand
    Dim qryMain As String
    Dim objCommon As New clsCommon
   Private Sub frmDepartmentGroup_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
      G_CURRENTDATE = Date.Now
      If G_CURRENTDATE > G_SOFTENDDATE Then
         End
      End If

      txtID.Text = ""
      ClearHead(0)
      FillHeader()
      FillGrid()
      'cmdSave.Enabled = False
      'cmdEdit.Enabled = True
      'cmdSearch.Enabled = True
      'cmdCancel.Enabled = True
      'cmdDelete.Enabled = True
      'cmdNew.Enabled = True
      txtGroup.Focus()
   End Sub
    Private Sub ClearHead(ByVal myid As Integer)
        If myid = -1 Then
            'do not change txtID.Text 
        Else
            txtID.Text = myid
        End If
        lblInformation.Text = ""
        txtGroup.Text = ""
    End Sub
    Private Sub FillHeader()
        'grdRecord.DataSource = Nothing
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim grdcol0 As System.Windows.Forms.DataGridViewTextBoxColumn
        Dim grdcol1 As System.Windows.Forms.DataGridViewTextBoxColumn

        grdcol0 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        grdcol1 = New System.Windows.Forms.DataGridViewTextBoxColumn()

        grdcol0.DataPropertyName = "VID"
        grdcol0.HeaderText = "VID"
        grdcol0.Name = "grdcol0"
        grdcol0.Visible = False
        '
        'grdcol1
        '
        grdcol1.DataPropertyName = "VName"
        grdcol1.HeaderText = "Brand"
        grdcol1.Name = "grdcol1"
        grdcol1.ReadOnly = True
        grdcol1.Width = 500
        Me.grdRecord.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {grdcol0, grdcol1})
    End Sub
    Private Sub FillGrid()
        'grdRecord.DataSource = Nothing
      qryMain = " SELECT VID, VName From tblSetupBrand WHERE Isactive = 1 ORDER BY VName "
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
        If Setdouble(txtID.Text) <= 0 Then
            ClearHead(0)
            Return
        End If
      qryMain = " SELECT top 1 VName From tblSetupBrand WHERE VID=" & Setdouble(txtID.Text) & ""
        txtGroup.Text = objCommon.ExecuteScalar(qryMain)
    End Sub
    Private Sub cmdNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNew.Click
        txtGroup.Text = ""
        txtID.Text = ""
        'cmdSave.Enabled = True
        'cmdEdit.Enabled = False
        'cmdSearch.Enabled = False
        'cmdCancel.Enabled = True
        'cmdDelete.Enabled = False
        'cmdNew.Enabled = False
        txtGroup.Focus()
    End Sub
    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        lblInformation.Text = ""

        'varify for empty string
        'varify group > -1
        'varify already existance
      txtGroup.Text = txtGroup.Text.Trim
      txtID.Text = Setdouble(txtID.Text.Trim)
        If txtGroup.Text = "" Then
            MessageBox.Show("Please give some name.", G_APP_TITLE)
            Return
        End If
      qryMain = " Select top 1 VID from tblSetupBrand where VID <>'" & txtID.Text & "' and VName='" & txtGroup.Text & "' "
        qryMain = objCommon.ExecuteScalar(qryMain)
        If qryMain <> "" Then
            MessageBox.Show("Group already exists.", G_APP_TITLE)
            Return
        End If

        If Setint(txtID.Text) > 0 Then 'update
         qryMain = " update tblSetupBrand set VName='" & txtGroup.Text & "',UID=" & G_UID & ",Tranzdatetime=getdate() where VID = " & Setint(txtID.Text)
            objCommon.ExecuteNonQuery(qryMain)
        Else
         qryMain = "insert into tblSetupBrand (VName, Isactive, UID, Tranzdatetime, CompCode) values('" & _
            txtGroup.Text & "', 1, " & G_UID & ",getdate()," & G_Compcode & "); select @@identity as VID ; "
            qryMain = objCommon.ExecuteScalar(qryMain)
            txtID.Text = Setint(qryMain)
        End If
        FillGrid()
        lblInformation.Text = "Record Saved."
        'cmdSave.Enabled = False
        'cmdEdit.Enabled = True
        'cmdSearch.Enabled = True
        'cmdCancel.Enabled = True
        'cmdDelete.Enabled = True
      'cmdNew.Enabled = True
      ClearHead(0)
        txtGroup.Focus()
    End Sub
    Private Sub cmdEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEdit.Click
        FillForm()
        txtGroup.Focus()
    End Sub
    Private Sub cmdSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSearch.Click

    End Sub
    Private Sub cmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancel.Click
        'cmdSave.Enabled = False
        'cmdEdit.Enabled = True
        'cmdSearch.Enabled = True
        'cmdCancel.Enabled = True
        'cmdDelete.Enabled = True
        'cmdNew.Enabled = True

        ClearHead(0)
        txtGroup.Focus()
    End Sub
    Private Sub cmdDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDelete.Click

    End Sub
    Private Sub grdAtt_MouseClick(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles grdRecord.MouseClick
        If grdRecord.Rows.Count > 0 Then
            Dim MYID As Integer = grdRecord.Rows(grdRecord.CurrentCell.RowIndex).Cells(0).Value
            txtID.Text = MYID
            FillForm()
            txtGroup.Focus()
        End If
    End Sub

    Private Sub txtGroup_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles txtGroup.KeyDown
      If e.KeyCode = Keys.Enter Then
         cmdSave_Click(Nothing, Nothing)
      End If
   End Sub
End Class