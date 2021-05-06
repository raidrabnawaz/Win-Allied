Public Class frmInvPaymentTerm
    Dim qryMain As String
    Dim objCommon As New clsCommon
    Dim Active As Int32
   Private Sub frmAttCode_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
        IsActive.Checked = False
        'End If
        lblInformation.Text = ""
        txtVName.Text = ""
        txtTermDays.Text = ""
        IsActive.Checked = False
    End Sub
    Private Sub FillHeader()
        'grdRecord.DataSource = Nothing
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim grdcol0 As System.Windows.Forms.DataGridViewTextBoxColumn
        Dim grdcol1 As System.Windows.Forms.DataGridViewTextBoxColumn
        Dim grdcol2 As System.Windows.Forms.DataGridViewTextBoxColumn
        Dim grdcol3 As System.Windows.Forms.DataGridViewCheckBoxColumn

        grdcol0 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        grdcol1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        grdcol2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        grdcol3 = New System.Windows.Forms.DataGridViewCheckBoxColumn()

        grdcol0.DataPropertyName = "VID"
        grdcol0.HeaderText = "Code"
        grdcol0.Name = "grdcol0"
        grdcol0.Visible = False
        '
        'grdcol1
        's
        grdcol1.DataPropertyName = "VName"
        grdcol1.HeaderText = "Payment Terms"
        grdcol1.Name = "grdcol1"
        grdcol1.Width = 400

        grdcol2.DataPropertyName = "TermDays"
        grdcol2.HeaderText = "Term Days"
        grdcol2.Name = "grdcol2"
      grdcol2.Width = 100

        grdcol3.DataPropertyName = "IsActive"
        grdcol3.HeaderText = "Is Active"
        grdcol3.Name = "grdcol3"
        grdcol3.Width = 100

        Me.grdRecord.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {grdcol0, grdcol1, grdcol2, grdcol3})
    End Sub
    Private Sub FillGrid()
        'grdRecord.DataSource = Nothing
        qryMain = "EXEC SpGet_FillGrid_POSPaymentTerm"
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
        qryMain = "EXEC SpGet_POSPaymentTerm '" & txtID.Text & "' "
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
        txtTermDays.Text = dr("TermDays")
        If dr("IsActive") <> 1 Then
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
      txtTermDays.Text = txtTermDays.Text.Trim.Replace("'", "")
        If txtVName.Text = "" Then
            MessageBox.Show("Please give some Term Name.", G_APP_TITLE)
            txtVName.Focus()
            Return
        End If
        If txtTermDays.Text = "" Then
            MessageBox.Show("Please give some Term Days.", G_APP_TITLE)
            txtTermDays.Focus()
            Return
        End If


        If (IsActive.Checked) Then
            Active = 1
        Else
            Active = 0
        End If

        'qryMain = " Select top 1 isnull(L1Code,'') as L1Code from tblAcSetupCOAL1 where L1Code <> '" & txtID.Text & "' and VName='" & txtVName.Text & "'; "
        'qryMain = objCommon.ExecuteScalar(qryMain)
        'If qryMain <> "" Then
        '    MessageBox.Show("Account already exists.", G_APP_TITLE)
        '    Return
        'End If

        If txtID.Text Is "" or txtID.Text = "" Or txtID.Text = "" Then 'update
         txtID.Text = 0                  '    qryMain = " update tblAcSetupCOAL1 set VName='" & txtVName.Text & "',GID='" & cmbGroup.SelectedValue & "' where L1Code = '" & txtID.Text & "'; "
      End If                   '    objCommon.ExecuteNonQuery(qryMain)
        'Else
        '    Dim strcode As String
        '    strcode = objCommon.ExecuteScalar("select isnull(max(cast(L1Code as int)),0) + 1 as L1Code from tblAcSetupCOAL1 where GID = " & cmbGroup.SelectedValue)
        '    strcode = Double.Parse(strcode).ToString("00")
        '    qryMain = "insert into tblAcSetupCOAL1 (L1Code, GID, VName, OldCode) values('" &
        '    strcode & "'," & cmbGroup.SelectedValue & ",'" & txtVName.Text & "','' );  "

        qryMain = "EXEC SpSave_POSPaymentTerm " & txtID.Text & ", '" & txtVName.Text & "', " & txtTermDays.Text & "," & Active & "," & G_UID & ",'" & G_IPAddress & "'," & G_UID & ",'" & G_IPAddress & "'"

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
            Dim MYID As String = grdRecord.Rows(grdRecord.CurrentCell.RowIndex).Cells("grdcol0").Value
            txtID.Text = MYID
            FillForm()
            txtVName.Focus()
        End If
    End Sub

    Private Sub txtTermDays_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTermDays.KeyPress
        Dim dotLength As Integer = -1
        dotLength = Me.txtTermDays.Text.Split(".").Length
        If e.KeyChar <> ControlChars.Back Then
            If dotLength > -1 Then
                e.Handled = Not (Char.IsDigit(e.KeyChar))
            Else
                e.Handled = Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = ".")
            End If
        End If
    End Sub
End Class