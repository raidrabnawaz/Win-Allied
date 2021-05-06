Imports System.Data.SqlClient

Public Class frmFabricOGPPosting
    Dim qryMain As String
    Dim objCommon As New clsCommon
    Dim CWhere As String
    Dim dt As DataTable

    Private Sub frmACJV_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        G_CURRENTDATE = Date.Now
        If G_CURRENTDATE > G_SOFTENDDATE Then
            End
        End If

        'txtID.Text = ""
        ClearHead("")
        'objCommon.FillPDCVType(Me.cmbVType)
        dtpDateFrom.Value = "01/" & Today.ToString("MM/yyyy")
        dtpDateTo.Value = Date.Today
        dtpPostingDate.Value = Date.Today
        dtpDateFrom.MaxDate = dtpDateTo.Value
        'txtID.Focus()
        FillGrid("")
    End Sub
    Private Sub ClearHead(ByVal myid As String)
        'txtID.Text = myid
        lblInformation.Text = ""
        txtVNo.Text = ""
        dtpDateFrom.Value = "01/" & Today.ToString("MM/yyyy")
        dtpDateTo.ResetText()
        dtpPostingDate.ResetText()

        'txtID.Text = ""
    End Sub
    Private Sub FillHeader()
        'grdRecord.DataSource = Nothing
        'Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        'Dim grdcol0 As System.Windows.Forms.DataGridViewTextBoxColumn
        'Dim grdcol1 As System.Windows.Forms.DataGridViewTextBoxColumn
        'Dim grdcol2 As System.Windows.Forms.DataGridViewTextBoxColumn
        'Dim grdcol3 As System.Windows.Forms.DataGridViewTextBoxColumn
        'Dim grdcol4 As System.Windows.Forms.DataGridViewTextBoxColumn
        'Dim grdcol5 As System.Windows.Forms.DataGridViewTextBoxColumn
        'Dim grdcol6 As System.Windows.Forms.DataGridViewTextBoxColumn

        'grdcol0 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        'grdcol1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        'grdcol2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        'grdcol3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        'grdcol4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        'grdcol5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        'grdcol6 = New System.Windows.Forms.DataGridViewTextBoxColumn()

        'grdcol0.DataPropertyName = "VID"
        'grdcol0.HeaderText = "VID"
        'grdcol0.Name = "grdcol0"
        'grdcol0.Visible = False
        ''
        ''grdcol1
        ''
        'grdcol1.DataPropertyName = "AccountID"
        'grdcol1.HeaderText = "Account ID"
        'grdcol1.Name = "grdcol1"
        'grdcol1.Visible = False
        ''
        ''grdcol2
        ''
        'grdcol2.DataPropertyName = "VName"
        'grdcol2.HeaderText = "Account"
        'grdcol2.Name = "grdcol2"
        'grdcol2.Width = 400
        ''
        ''grdcol3
        ''
        'grdcol3.DataPropertyName = "Dr"
        'grdcol3.HeaderText = "Dr"
        'grdcol3.Name = "grdcol3"
        'grdcol3.ReadOnly = False
        'grdcol3.Width = 200

        'grdcol4.DataPropertyName = "Cr"
        'grdcol4.HeaderText = "Cr"
        'grdcol4.ReadOnly = False
        'grdcol4.Name = "grdcol4"
        'grdcol4.Width = 200

        ''
        'grdcol5.DataPropertyName = "CompanyID"
        'grdcol5.HeaderText = "CompanyID"
        'grdcol5.Name = "grdcol5"
        'grdcol5.Visible = False

        'grdcol6.DataPropertyName = "FinancialYearID"
        'grdcol6.HeaderText = "FinancialYearID"
        'grdcol6.Name = "grdcol6"
        'grdcol6.Visible = False
        ''

        'Me.grdRecord.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {grdcol0, grdcol1, grdcol2, grdcol3, grdcol4, grdcol5, grdcol6})
    End Sub
    Private Sub FillGrid(ByVal strSearch As String)
        If Not IsNothing(dt) Then
            dt.Rows.Clear()
            grdRecord.DataSource = dt
        End If

        'qryMain = " SELECT H.VID, H.VNo, H.VDate, H.PartyCode as DrCode, COA.VName AS DrName, H.ChequeNo, H.Amount, H.Remarks, H.BankCode as CrCode, isnull(B.VName,'') AS CrName " &
        '" FROM dbo.tblAcJV AS H INNER JOIN dbo.tblAcSetupCOA AS COA ON H.PartyCode = COA.VCode LEFT OUTER JOIN dbo.tblAcSetupCOA AS B ON H.BankCode = B.VCode " &
        '" " & strSearch & " ORDER BY H.VID desc "
        'Dim qry As String = ""
        'If (rdbtnPosted.Checked) Then
        '    qry = " AND (Dr + Cr) > 0 "

        'ElseIf (rdbtnNotPosted.Checked) Then
        '    qry = " AND (Dr + Cr) = 0 "
        'ElseIf (rdbtnAll.Checked) Then
        '    qry = ""
        'End If

        'CWhere = "WHERE CompanyID=" & G_Compcode & " AND FinancialYearID IN(0, 14) and VName like ''%" & txtSearch.Text & "%''" & qry & ""
        'exec SPGetbyPendingPosting @DateFrom='2019-07-01 00:00:00',@DateTo='2020-01-15 00:00:00',@VType=N'0',@CompanyID=5,@FinancialYearID=14


        qryMain = "EXEC SPGetKnitFabricOGPPendingPosting @DateFrom='" & CDate(dtpDateFrom.Value).ToString("dd/MMM/yyyy") & "',@DateTo='" & CDate(dtpDateTo.Value).ToString("dd/MMM/yyyy") & "',@VNo='" & txtVNo.Text & "', @CompanyID=" & G_Compcode & ",@FinancialYearID=" & G_FinancialYearID & ""

        dt = objCommon.GetDataTable(qryMain)

        If IsNothing(dt) Then
            'EmptyFields()
            Return
        End If
        If dt.Rows.Count <= 0 Then
            'EmptyFields()
            Return
        End If
        grdRecord.DataSource = dt
        If grdRecord.Rows.Count > 0 Then setGrid(grdRecord)
    End Sub
    Private Sub FillForm()
        lblInformation.Text = ""
        'If txtID.Text = "" And txtID.Text.Trim = "" Then
        '    ClearHead("")
        '    Return
        'End If
        'txtID.Text = txtID.Text.Trim
        'If Setint(txtID.Text) <= 0 Then
        '    If txtID.Text <> "" Then
        '        qryMain = " Select top 1 VID from tblAcJV where VNo='" & txtID.Text & "'"
        '        qryMain = objCommon.ExecuteScalar(qryMain)
        '        txtID.Text = Setint(qryMain)
        '    End If
        'End If
        'txtID.Text = Setint(txtID.Text)
        'qryMain = " SELECT H.VNo, H.VDate, H.PartyCode as DrCode, COA.VName AS DrName, H.ChequeNo, H.Amount, H.Remarks, H.BankCode as CrCode, isnull(B.VName,'') AS CrName " &
        '    " FROM dbo.tblAcJV AS H INNER JOIN dbo.tblAcSetupCOA AS COA ON H.PartyCode = COA.VCode LEFT OUTER JOIN dbo.tblAcSetupCOA AS B ON H.BankCode = B.VCode WHERE H.VID=" & txtID.Text & "; "
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

        'txtID.Text = dr("VNo")
        'dtpIssueDate.Value = dr("VDate")
        'txtStoreName.Text = dr("ChequeNo")
    End Sub
    Private Sub cmdNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNew.Click
        ClearHead("")
        'txtID.Focus()
    End Sub
    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        lblInformation.Text = ""
        Try


            'varify for empty string
            ''varify already existance
            'txtVName.Text = txtVName.Text.Trim.ToUpper.Replace("'", "")
            'If lblCustomerName.Text = "" Then
            '    lblInformation.Text = "Please give some Dr Code."
            '    Return
            'End If
            'If lblBankName.Text = "" Then
            '    lblInformation.Text = "Please give some Cr Code."
            '    Return
            'End If
            'txtMDNRefNo.Text = txtMDNRefNo.Text.Trim
            'txtAmount.Text = Setdouble(txtAmount.Text)


            'If txtID.Text <> "" Then 'update
            '    If txtID.Text.Substring(4, 4) <> CDate(dtpMDNDate.Value).ToString("MMyy") Then
            '        lblInformation.Text = "Cannot change the month of voucher."
            '        Return
            '    End If
            '    qryMain = " update tblAcJV set VDate='" & CDate(dtpMDNDate.Value).ToString("dd/MMM/yyyy") & "',PartyCode='" & txtCustomer.Text & "',BankCode='" & txtBank.Text & "',ChequeNo='" & txtMDNRefNo.Text & "',Amount=" & txtAmount.Text & ",  Remarks='" & txtVName.Text & "', UID=" & G_UID & ",Tranzdatetime=getdate(),CompCode=0 where VID = " & txtID.Text & "; "
            '    objCommon.ExecuteNonQuery(qryMain)
            'Else
            '    Dim strcode As String
            '    strcode = objCommon.ExecuteScalar("select isnull(max(cast(left(VNo,3) as int)),0) + 1  as VCode from tblAcJV where right(VNo,4) = '" & CDate(dtpMDNDate.Value).ToString("MMyy") & "'; ")
            '    strcode = Double.Parse(strcode).ToString("000") & "/" & CDate(dtpMDNDate.Value).ToString("MMyy")
            '    qryMain = "insert into tblAcJV (VNo, RefNo, DocumentType, VDate, PartyCode, BankCode, ChequeNo, Amount, Remarks, IsCancel, CancelDate, IsPosted, PostedDate, FYear, UID, Tranzdatetime, CompCode ) values('" &
            '    strcode & "','','Cash','" & CDate(dtpMDNDate.Value).ToString("dd/MMM/yyyy") & "','" & txtCustomer.Text & "','" & txtBank.Text & "','" & txtMDNRefNo.Text & "'," & txtAmount.Text & ",'" & txtVName.Text & "',0,'01/01/1900',1,'" & CDate(dtpMDNDate.Value).ToString("dd/MMM/yyyy") & "'," & CDate(dtpMDNDate.Value).ToString("yyyy") & "," & G_UID & ",getdate(),0);  "
            'For Each row As DataGridViewRow In grdRecord.Rows
            Dim myVID As Label = New Label
            objCommon.openConnection()
            For Each grid As DataGridViewRow In grdRecord.Rows

                'myVID.Text = grid.Cells("VID").Value.ToString
                'Dim myAccountID As Label = New Label
                'myAccountID.Text = grid.Cells("AccountID").Value.ToString
                'Dim myDr As TextBox = New TextBox
                'myDr.Text = grid.Cells("Dr").Value.ToString
                'Dim myCr As TextBox = New TextBox
                'myCr.Text = grid.Cells("Cr").Value.ToString

                'If (String.IsNullOrEmpty(Setdouble(myVID.Text))) Then
                '    If (Convert.ToDecimal(myDr.Text) > 0 Or Convert.ToDecimal(myCr.Text) > 0) Then
                '        myVID.Text = 0
                '    Else
                Dim ispost As Int32
                If Not IsDBNull(grid.Cells("IsPosted").Value) Then
                    ispost = grid.Cells("IsPosted").Value
                    'Continue For
                    '    End If

                    'End If
                    If ispost = 1 Then
                        qryMain = "EXEC SPSaveKnitFarbciOGPPosting " & grid.Cells("VID").Value.ToString & " ," & ispost & " ," & G_UID & " ,'" & CDate(dtpPostingDate.Value).ToString("dd/MMM/yyyy") & "' "
                        'qryMain = "EXEC SpSaveAccOpening '" & myVID.Text & "'," & myAccountID.Text & "," & myDr.Text & "," & myCr.Text & "," & G_Compcode & "," & G_FinancialYearID & "," & G_UID & ",'" & G_IPAddress & "'," & G_UID & ",'" & G_IPAddress & "'"
                        objCommon.ExecuteNonQueryWithOpen(qryMain)
                    End If
                End If
            Next
            objCommon.CloseConnection()
            'MessageBox.Show("Records inserted.")
        Catch ex As Exception
            MessageBox.Show("Records insertion Failed.")
        Finally
            objCommon.CloseConnection()

        End Try
        'End If
        ClearHead("")
        FillGrid("")
        lblInformation.Text = "Record Saved."
        'txtID.Focus()
    End Sub
    Private Sub cmdEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEdit.Click
        FillForm()
        'txtID.Focus()
    End Sub


    Private Sub cmdSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSearch.Click
        FillGrid("")
        'txtVName.Text = txtVName.Text.Trim
        'FillGrid(" where H.VNo like '%" & txtVName.Text & "%' or H.PartyCode like '%" & txtVName.Text & "%' or H.BankCode like '%" & txtVName.Text & "%' or COA.VName like '%" & txtVName.Text & "%' or H.Remarks like '%" & txtVName.Text & "%' ")
    End Sub
    Private Sub cmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancel.Click
        ClearHead("")
        'txtID.Focus()
    End Sub
    Private Sub cmdDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDelete.Click
        'If Setdouble(txtID.Text) <= 0 Then
        '    lblInformation.Text = "Please select some record to delete."
        '    Return
        'End If

        If MessageBox.Show("Do You want to delete record?", G_APP_TITLE, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) = DialogResult.No Then
            Return
        End If

        'qryMain = " delete from tblAcJV where VID = " & txtID.Text & ";"
        objCommon.ExecuteNonQuery(qryMain)
        FillGrid("")
        ClearHead(0)
        lblInformation.Text = "Record removed."
    End Sub
    Private Sub grdAtt_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles grdRecord.MouseClick
        If grdRecord.Rows.Count > 0 Then
            Dim MYID As String = grdRecord.Rows(grdRecord.CurrentCell.RowIndex).Cells(0).Value
            'txtID.Text = MYID
            'FillForm()
            'txtID.Focus()
        End If
    End Sub

    Private Sub txtCustomer_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'If txtCustomer.Text.Trim.Length <> 7 Then
        '    lblCustomerName.Text = ""
        '    Return
        'End If
        'qryMain = " select top 1 VName from tblAcSetupCOA where VCode ='" & txtCustomer.Text.Trim & "' "
        'lblCustomerName.Text = objCommon.ExecuteScalar(qryMain)
    End Sub

    Private Sub txtCustomer_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.F2 Then
            ''frmLookupCOA.ETypeID = "0502"
            'frmLookupCOA.VCodeIni = txtCustomer.Text.Trim
            'frmLookupCOA.ShowDialog()
            'txtCustomer.Text = frmLookupCOA.VCode
            'lblCustomerName.Text = frmLookupCOA.VName
            'frmLookupCOA.Dispose()
        ElseIf e.KeyCode = Keys.Enter Then
            'If txtCustomer.Text.Trim.Length <> 7 Then
            '    lblCustomerName.Text = ""
            '    Return
            'End If
            'qryMain = " select top 1 VName from tblAcSetupCOA where VCode ='" & txtCustomer.Text.Trim & "' "
            'lblCustomerName.Text = objCommon.ExecuteScalar(qryMain)
            SendKeys.Send("{TAB}")
        End If
    End Sub
    Private Sub txtBank_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.F2 Then
            'frmLookupCOA.ETypeID = "0502"
            'frmLookupCOA.VCodeIni = txtBank.Text.Trim
            'frmLookupCOA.ShowDialog()
            'txtBank.Text = frmLookupCOA.VCode
            'lblBankName.Text = frmLookupCOA.VName
            'frmLookupCOA.Dispose()
        ElseIf e.KeyCode = Keys.Enter Then
            'If txtBank.Text.Trim.Length <> 7 Then
            '    lblBankName.Text = ""
            '    Return
            'End If
            'qryMain = " select top 1 VName from tblAcSetupCOA where VCode ='" & txtBank.Text.Trim & "' "
            'lblBankName.Text = objCommon.ExecuteScalar(qryMain)
            SendKeys.Send("{TAB}")
        End If
    End Sub
End Class