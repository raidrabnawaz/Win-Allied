Public Class frmACJV
    Dim qryMain As String
    Dim objCommon As New clsCommon
    Private Sub frmACJV_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtID.Text = ""
        ClearHead("")

        FillGrid("") 
        txtVno.Focus()
    End Sub
    Private Sub ClearHead(ByVal myid As String)
        txtID.Text = myid
        lblInformation.Text = ""
        txtVno.Text = ""
        txtCustomer.Text = ""
        lblCustomerName.Text = ""
        txtBank.Text = ""
        lblBankName.Text = ""
        txtChequeNo.Text = ""
        txtAmount.Text = ""
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
        Dim grdcol6 As System.Windows.Forms.DataGridViewTextBoxColumn
        Dim grdcol7 As System.Windows.Forms.DataGridViewTextBoxColumn
        Dim grdcol8 As System.Windows.Forms.DataGridViewTextBoxColumn
        Dim grdcol9 As System.Windows.Forms.DataGridViewTextBoxColumn

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

        grdcol0.DataPropertyName = "VID"
        grdcol0.HeaderText = "VID"
        grdcol0.Name = "grdcol0"
        grdcol0.Visible = False
        '
        'grdcol1
        '
        grdcol1.DataPropertyName = "VNo"
        grdcol1.HeaderText = "VNo"
        grdcol1.Name = "grdcol1"
        grdcol1.Width = 70
        '
        'grdcol2
        '
        grdcol2.DataPropertyName = "VDate"
        grdcol2.HeaderText = "Date"
        grdcol2.Name = "grdcol2"
        grdcol2.Width = 100


        '
        'grdcol3
        '
        grdcol3.DataPropertyName = "DrCode"
        grdcol3.HeaderText = "DrCode"
        grdcol3.Name = "grdcol3"
        grdcol3.Width = 70
        '
        'grdcol4
        '
        grdcol4.DataPropertyName = "DrName"
        grdcol4.HeaderText = "DrName"
        grdcol4.Name = "grdcol4"
        grdcol4.Width = 200




        '
        'grdcol5
        '
        grdcol5.DataPropertyName = "CrCode"
        grdcol5.HeaderText = "CrCode"
        grdcol5.Name = "grdcol5"
        grdcol5.Width = 70
        '
        'grdcol4
        '
        grdcol6.DataPropertyName = "CrName"
        grdcol6.HeaderText = "CrName"
        grdcol6.Name = "grdcol6"
        grdcol6.Width = 200
        '
        'grdcol5
        '
        grdcol7.DataPropertyName = "ChequeNo"
        grdcol7.HeaderText = "ChequeNo"
        grdcol7.Name = "grdcol7"
        grdcol7.Width = 70
        '
        'grdcol8
        '
        grdcol8.DataPropertyName = "Amount"
        grdcol8.HeaderText = "Amount"
        grdcol8.Name = "grdcol8"
        grdcol8.Width = 70
        '
        'grdcol9
        '
        grdcol9.DataPropertyName = "Remarks"
        grdcol9.HeaderText = "Remarks"
        grdcol9.Name = "grdcol9"
        grdcol9.Width = 100

        Me.grdRecord.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {grdcol0, grdcol1, grdcol2, grdcol3, grdcol4, grdcol5, grdcol6, grdcol7, grdcol8, grdcol9})
    End Sub
    Private Sub FillGrid(ByVal strSearch As String)
        grdRecord.DataSource = Nothing
        FillHeader()
        qryMain = " SELECT H.VID, H.VNo, H.VDate, H.PartyCode as DrCode, COA.VName AS DrName, H.ChequeNo, H.Amount, H.Remarks, H.BankCode as CrCode, isnull(B.VName,'') AS CrName " & _
        " FROM dbo.tblAcJV AS H INNER JOIN dbo.tblAcSetupCOA AS COA ON H.PartyCode = COA.VCode LEFT OUTER JOIN dbo.tblAcSetupCOA AS B ON H.BankCode = B.VCode " & _
        " " & strSearch & " ORDER BY H.VID desc "
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
        If txtID.Text = "" And txtVno.Text.Trim = "" Then
            ClearHead("")
            Return
        End If
        txtVno.Text = txtVno.Text.Trim
        If Setint(txtID.Text) <= 0 Then
            If txtVno.Text <> "" Then
                qryMain = " Select top 1 VID from tblAcJV where VNo='" & txtVno.Text & "'"
                qryMain = objCommon.ExecuteScalar(qryMain)
                txtID.Text = Setint(qryMain)
            End If
        End If
        txtID.Text = Setint(txtID.Text)
        qryMain = " SELECT H.VNo, H.VDate, H.PartyCode as DrCode, COA.VName AS DrName, H.ChequeNo, H.Amount, H.Remarks, H.BankCode as CrCode, isnull(B.VName,'') AS CrName " & _
            " FROM dbo.tblAcJV AS H INNER JOIN dbo.tblAcSetupCOA AS COA ON H.PartyCode = COA.VCode LEFT OUTER JOIN dbo.tblAcSetupCOA AS B ON H.BankCode = B.VCode WHERE H.VID=" & txtID.Text & "; "
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

        txtVno.Text = dr("VNo")
        dtpDateFrom.Value = dr("VDate")
        txtCustomer.Text = dr("DrCode")
        lblCustomerName.Text = dr("DrName")
        txtBank.Text = dr("CrCode")
        lblBankName.Text = dr("CrName")
        txtChequeNo.Text = dr("ChequeNo")
        txtAmount.Text = dr("Amount")
        txtVName.Text = dr("Remarks")
    End Sub
    Private Sub cmdNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNew.Click
        ClearHead("")
        txtVno.Focus()
    End Sub
    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        lblInformation.Text = ""
        'varify for empty string
        'varify already existance
      txtVName.Text = txtVName.Text.Trim.Replace("'", "")
        If lblCustomerName.Text = "" Then
            lblInformation.Text = "Please give some Dr Code."
            Return
        End If
        If lblBankName.Text = "" Then
            lblInformation.Text = "Please give some Cr Code."
            Return
        End If
        txtChequeNo.Text = txtChequeNo.Text.Trim
        txtAmount.Text = Setdouble(txtAmount.Text)


        If txtID.Text <> "" Then 'update
            If txtVno.Text.Substring(4, 4) <> CDate(dtpDateFrom.Value).ToString("MMyy") Then
                lblInformation.Text = "Cannot change the month of voucher."
                Return
            End If
            qryMain = " update tblAcJV set VDate='" & CDate(dtpDateFrom.Value).ToString("dd/MMM/yyyy") & "',PartyCode='" & txtCustomer.Text & "',BankCode='" & txtBank.Text & "',ChequeNo='" & txtChequeNo.Text & "',Amount=" & txtAmount.Text & ",  Remarks='" & txtVName.Text & "', UID=" & G_UID & ",Tranzdatetime=getdate(),CompCode=0 where VID = " & txtID.Text & "; "
            objCommon.ExecuteNonQuery(qryMain)
        Else
            Dim strcode As String
            strcode = objCommon.ExecuteScalar("select isnull(max(cast(left(VNo,3) as int)),0) + 1  as VCode from tblAcJV where right(VNo,4) = '" & CDate(dtpDateFrom.Value).ToString("MMyy") & "'; ")
            strcode = Double.Parse(strcode).ToString("000") & "/" & CDate(dtpDateFrom.Value).ToString("MMyy")
            qryMain = "insert into tblAcJV (VNo, RefNo, DocumentType, VDate, PartyCode, BankCode, ChequeNo, Amount, Remarks, IsCancel, CancelDate, IsPosted, PostedDate, FYear, UID, Tranzdatetime, CompCode ) values('" & _
            strcode & "','','Cash','" & CDate(dtpDateFrom.Value).ToString("dd/MMM/yyyy") & "','" & txtCustomer.Text & "','" & txtBank.Text & "','" & txtChequeNo.Text & "'," & txtAmount.Text & ",'" & txtVName.Text & "',0,'01/01/1900',1,'" & CDate(dtpDateFrom.Value).ToString("dd/MMM/yyyy") & "'," & CDate(dtpDateFrom.Value).ToString("yyyy") & "," & G_UID & ",getdate(),0);  "
            objCommon.ExecuteNonQuery(qryMain)
        End If
        ClearHead("")
        FillGrid("")
        lblInformation.Text = "Record Saved."
        txtVno.Focus()
    End Sub
    Private Sub cmdEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEdit.Click
        FillForm()
        txtVno.Focus()
    End Sub
    Private Sub cmdSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSearch.Click
        txtVName.Text = txtVName.Text.Trim
        FillGrid(" where H.VNo like '%" & txtVName.Text & "%' or H.PartyCode like '%" & txtVName.Text & "%' or H.BankCode like '%" & txtVName.Text & "%' or COA.VName like '%" & txtVName.Text & "%' or H.Remarks like '%" & txtVName.Text & "%' ")
    End Sub
    Private Sub cmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancel.Click
        ClearHead("")
        txtVno.Focus()
    End Sub
    Private Sub cmdDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDelete.Click
        If Setdouble(txtID.Text) <= 0 Then
            lblInformation.Text = "Please select some record to delete."
            Return
        End If

        If MessageBox.Show("Do You want to delete record?", G_APP_TITLE, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) = DialogResult.No Then
            Return
        End If

        qryMain = " delete from tblAcJV where VID = " & txtID.Text & ";"
        objCommon.ExecuteNonQuery(qryMain)
        FillGrid("")
        ClearHead(0)
        lblInformation.Text = "Record removed."
    End Sub
    Private Sub grdAtt_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles grdRecord.MouseClick
        If grdRecord.Rows.Count > 0 Then
            Dim MYID As String = grdRecord.Rows(grdRecord.CurrentCell.RowIndex).Cells(0).Value
            txtID.Text = MYID
            FillForm()
            txtVno.Focus()
        End If
    End Sub

    Private Sub txtCustomer_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCustomer.TextChanged, txtBank.TextChanged
        If txtCustomer.Text.Trim.Length <> 7 Then
            lblCustomerName.Text = ""
            Return
        End If
        qryMain = " select top 1 VName from tblAcSetupCOA where VCode ='" & txtCustomer.Text.Trim & "' "
        lblCustomerName.Text = objCommon.ExecuteScalar(qryMain)
    End Sub

    Private Sub txtCustomer_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCustomer.KeyDown
        If e.KeyCode = Keys.F2 Then
            'frmLookupCOA.ETypeID = "0502"
            frmLookupCOA.VCodeIni = txtCustomer.Text.Trim
            frmLookupCOA.ShowDialog()
            If frmLookupCOA.VCode <> "" Then
                txtCustomer.Text = frmLookupCOA.VCode
                lblCustomerName.Text = frmLookupCOA.VName
            End If
            frmLookupCOA.Dispose()
            ElseIf e.KeyCode = Keys.Enter Then
                If txtCustomer.Text.Trim.Length <> 7 Then
                lblCustomerName.Text = ""
                Return
            End If
            qryMain = " select top 1 VName from tblAcSetupCOA where VCode ='" & txtCustomer.Text.Trim & "' "
            lblCustomerName.Text = objCommon.ExecuteScalar(qryMain)
            SendKeys.Send("{TAB}")
        End If
    End Sub
    Private Sub txtBank_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtBank.KeyDown
        If e.KeyCode = Keys.F2 Then
            'frmLookupCOA.ETypeID = "0502"
         frmLookupCOA.VCodeIni = txtBank.Text.Trim
         frmLookupCOA.VCode = ""
         frmLookupCOA.VName = ""
            frmLookupCOA.ShowDialog()
            If frmLookupCOA.VCode <> "" Then
                txtBank.Text = frmLookupCOA.VCode
                lblBankName.Text = frmLookupCOA.VName
            End If
            frmLookupCOA.Dispose()
            ElseIf e.KeyCode = Keys.Enter Then
                If txtBank.Text.Trim.Length <> 7 Then
                lblBankName.Text = ""
                Return
            End If
            qryMain = " select top 1 VName from tblAcSetupCOA where VCode ='" & txtBank.Text.Trim & "' "
            lblBankName.Text = objCommon.ExecuteScalar(qryMain)
            SendKeys.Send("{TAB}")
        End If
    End Sub
End Class