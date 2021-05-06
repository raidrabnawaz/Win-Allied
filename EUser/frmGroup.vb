Public Class frmGroup
    
   Dim objCommon As New clsCommon

   Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
      G_CURRENTDATE = Date.Now
      If G_CURRENTDATE > G_SOFTENDDATE Then
         End
      End If

      txtID.Text = ""
      ClearHead(0)
      FillGrid()
      txtVName.Focus()
   End Sub
    Private Sub ClearHead(ByVal myid As Integer)
        If myid = -1 Then
            'do not change txtID.Text 
        Else
            txtID.Text = myid
        End If
        lblInformation.Text = ""
        txtVName.Text = ""
    End Sub
    Private Sub FillHeader()
        'grdRecord.DataSource = Nothing
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim grdcol0 As System.Windows.Forms.DataGridViewTextBoxColumn
        Dim grdcol1 As System.Windows.Forms.DataGridViewTextBoxColumn
        Dim grdcol2 As System.Windows.Forms.DataGridViewTextBoxColumn

        grdcol0 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        grdcol1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        grdcol2 = New System.Windows.Forms.DataGridViewTextBoxColumn()

        grdcol0.DataPropertyName = "VID"
        grdcol0.HeaderText = "VID"
        grdcol0.Name = "grdcol0"
        grdcol0.Visible = False
        '
        'grdcol1
        '
        grdcol1.DataPropertyName = "VName"
        grdcol1.HeaderText = "Group Name"
        grdcol1.Name = "grdcol1"
        grdcol1.ReadOnly = True
        grdcol1.Width = 500
        '
        'grdcol2
        '
        'grdcol2.DataPropertyName = "INI"
        'grdcol2.HeaderText = "INI"
        'grdcol2.Name = "grdcol2"
        'grdcol2.ReadOnly = True
        'grdcol2.Width = 80
        Me.grdRecord.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {grdcol0, grdcol1})
    End Sub
    Private Sub FillGrid()
        grdRecord.DataSource = Nothing
        grdRecord.Rows.Clear()
        grdRecord.Columns.Clear()
        FillHeader()
      qryMain = " SELECT VID, VName From SecRole WHERE Isactive = 1 ORDER BY VName "
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
      qryMain = " SELECT top 1 VName From SecRole WHERE VID=" & Setdouble(txtID.Text) & ""
        Dim dt As DataTable = objCommon.GetDataTable(qryMain)
        If IsNothing(dt) Then
            ClearHead(0)
            Return
        End If
        If dt.Rows.Count <= 0 Then
            ClearHead(0)
            Return
        End If
        Dim dr As DataRow = dt.Rows(0)
        txtVName.Text = dr("VName")
    End Sub
    Private Sub cmdNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNew.Click
        txtVName.Text = ""
        txtID.Text = ""
        txtVName.Focus()
    End Sub
    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        lblInformation.Text = ""

        'varify for empty string
        'varify group > -1
        'varify already existance
        txtVName.Text = txtVName.Text.Trim.ToUpper
        txtID.Text = txtID.Text.Trim.ToUpper
        If txtVName.Text = "" Then
            MessageBox.Show("Please give some name.", G_APP_TITLE)
            Return
        End If
      qryMain = " Select top 1 VID from SecRole where VID <>'" & txtID.Text & "' and VName='" & txtVName.Text & "' "
        qryMain = objCommon.ExecuteScalar(qryMain)
        If qryMain <> "" Then
            MessageBox.Show("Group already exists.", G_APP_TITLE)
            Return
        End If

        If Setint(txtID.Text) > 0 Then 'update
         qryMain = " update SecRole set VName='" & txtVName.Text & "', UpdatedBy=" & G_UID & ",UpdatedDate=getdate() where VID = " & Setint(txtID.Text)
            objCommon.ExecuteNonQuery(qryMain)
        Else
         qryMain = "insert into SecRole (VName,Isactive, InsertedBy, InsertedDate ) values('" & _
         txtVName.Text & "',1, " & G_UID & ",getdate() ); select @@identity as VID ; "
            qryMain = objCommon.ExecuteScalar(qryMain)
            txtID.Text = Setint(qryMain)
        End If
        FillGrid()
      lblInformation.Text = "Record Saved."
      txtVName.Text = ""
      txtID.Text = ""
      txtVName.Focus()
        txtVName.Focus()
    End Sub
    Private Sub cmdDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDelete.Click

    End Sub

    Private Sub kryptongrdRecord_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles grdRecord.MouseClick
        Dim MYID As Integer = grdRecord.Rows(grdRecord.CurrentCell.RowIndex).Cells(0).Value
        txtID.Text = MYID
        FillForm()
        txtVName.Focus()
    End Sub

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub


   Private Sub txtVName_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txtVName.KeyDown
      If e.KeyCode = Keys.Enter Then
         cmdSave_Click(Nothing, Nothing)
      End If
   End Sub
End Class