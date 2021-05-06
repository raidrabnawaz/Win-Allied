Public Class frmGPSupplier
    Dim qryMain As String
    Dim objCommon As New clsCommon
   Private Sub frmAttCode_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
      G_CURRENTDATE = Date.Now
      If G_CURRENTDATE > G_SOFTENDDATE Then
         End
      End If

      lblVID.Text = ""
      ClearHead("")
      FillHeader()
      FillGrid()
      txtVName.Focus()

   End Sub
    Private Sub ClearHead(ByVal myid As String)
        'If myid = "" Then
        ''do not change lblVID.Text 
        'Else
        lblVID.Text = 0
        txtID.Text = ""
        txtAddress.Text = ""
        txtBalance.Text = ""
        txtNTNNo.Text = ""
        txtSTNNo.Text = ""
        txtPhoneNo.Text = ""
        txtFaxNo.Text = ""
        'End If
        lblInformation.Text = ""
        txtVName.Text = ""
        txtMobileNo.Text = ""
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

        grdcol0 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        grdcol1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        grdcol2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        grdcol3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        grdcol4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        grdcol5 = New System.Windows.Forms.DataGridViewTextBoxColumn()

        grdcol0.DataPropertyName = "VID"
        grdcol0.HeaderText = "VID"
        grdcol0.Name = "grdcol0"
        grdcol0.Visible = False
        '
        'grdcol1
        's
        grdcol1.DataPropertyName = "VCode"
        grdcol1.HeaderText = "Supplier Code"
        grdcol1.Name = "grdcol1"
        grdcol1.Width = 100

        grdcol2.DataPropertyName = "VName"
        grdcol2.HeaderText = "Supplier Name"
        grdcol2.Name = "grdcol2"
        grdcol2.Width = 200

        grdcol3.DataPropertyName = "MobileNo"
        grdcol3.HeaderText = "Mobile No"
        grdcol3.Name = "grdcol3"
        grdcol3.Width = 200


        grdcol4.DataPropertyName = "Balance"
        grdcol4.HeaderText = "Balance"
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
        qryMain = "EXEC SpGet_GPSupplier"
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
      setGrid(grdRecord)
    End Sub
    Private Sub FillForm()
        lblInformation.Text = ""
        If lblVID.Text = "" Then
            ClearHead("")
            Return
        End If
        qryMain = "EXEC SpGetbyIDGPSupplier '" & lblVID.Text & "' "
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
        txtID.Text = dr("VCode")
        txtMobileNo.Text = dr("MobileNo")
        txtVName.Text = dr("VName")
        txtPhoneNo.Text = dr("PhoneNo")
        txtAddress.Text = dr("VAddress")
        txtFaxNo.Text = dr("FaxNumber")
        txtNTNNo.Text = dr("NTN")
        txtSTNNo.Text = dr("STN")
        txtBalance.Text = dr("Balance")
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
      txtMobileNo.Text = txtMobileNo.Text.Trim.Replace("'", "")
        If txtID.Text = "" Then
            MessageBox.Show("Please give Supplier Code.", G_APP_TITLE)
            txtID.Focus()
            Return
        End If
        If txtVName.Text = "" Then
            MessageBox.Show("Please give Supplier Name.", G_APP_TITLE)
            txtVName.Focus()
            Return
        End If
        If txtMobileNo.Text = "" Then
            MessageBox.Show("Please give Supplier Mobile Number.", G_APP_TITLE)
            txtMobileNo.Focus()
            Return
        End If
        If txtBalance.Text = "" Then
            MessageBox.Show("Please give Supplier Balance.", G_APP_TITLE)
            txtBalance.Focus()
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

        qryMain = "EXEC SpSave_GPSupplier " & lblVID.Text & ",'" & txtID.Text & "', '" & txtVName.Text & "','" & txtNTNNo.Text & "','" & txtAddress.Text & "','" & txtSTNNo.Text & "'," & txtBalance.Text & ",'" & txtPhoneNo.Text & "','" & txtFaxNo.Text & "', '" & txtMobileNo.Text & "'," & G_Compcode & "," & IsActive.CheckState & "," & G_UID & ",'" & G_IPAddress & "'," & G_UID & ",'" & G_IPAddress & "'"

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
            lblVID.Text = MYID
            FillForm()
            txtVName.Focus()
        End If
    End Sub

    Private Sub txtBalance_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtBalance.KeyPress
        Dim dotLength As Integer = 1
        dotLength = Me.txtBalance.Text.Split(".").Length
        If e.KeyChar <> ControlChars.Back Then
            If dotLength > 1 Then
                e.Handled = Not (Char.IsDigit(e.KeyChar))
            Else
                e.Handled = Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = ".")
            End If
        End If
    End Sub
End Class