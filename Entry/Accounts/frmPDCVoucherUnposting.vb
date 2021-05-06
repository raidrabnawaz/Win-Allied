Public Class frmPDCVoucherUnposting
   Dim qryMain As String
   Dim objCommon As New clsCommon
   Dim CWhere As String
   Dim dt As DataTable

   Private Sub frmPDCVoucherUnposting_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
      G_CURRENTDATE = Date.Now
      If G_CURRENTDATE > G_SOFTENDDATE Then
         End
      End If

      'txtID.Text = ""
      ClearHead("")
      objCommon.FillPDCVType(Me.cmbVType)
      dtpDateFrom.Value = Convert.ToDateTime("01/" & Today.ToString("MM/yyyy"))
      dtpDateTo.Value = Date.Today
      dtpPostingDate.Value = Date.Today
      dtpDateFrom.MaxDate = dtpDateTo.Value
      'txtID.Focus()
      FillGrid("")
   End Sub

   Private Sub ClearHead(ByVal myid As String)
      'txtID.Text = myid
      'lblInformation.Text = ""
      cmbVType.SelectedValue = 0
      dtpDateFrom.Value = Convert.ToDateTime("01/" & Today.ToString("MM/yyyy"))
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


      qryMain = "EXEC SPGetbyUnPosting @DateFrom='" & CDate(dtpDateFrom.Value).ToString("dd/MMM/yyyy") & "',@DateTo='" & CDate(dtpDateTo.Value).ToString("dd/MMM/yyyy") & "',@VType='" & cmbVType.SelectedValue.ToString() & "', @CompanyID=" & G_Compcode & ",@FinancialYearID=" & G_FinancialYearID & ""

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
      'lblInformation.Text = ""
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
         ClearHead("")
         Return
      End If
      If dt.Rows.Count <= 0 Then
         ClearHead("")
         Return
      End If
      Dim dr As DataRow = dt.Rows(0)

      'txtID.Text = dr("VNo")
      'dtpIssueDate.Value = dr("VDate")
      'txtStoreName.Text = dr("ChequeNo")
   End Sub

   Private Sub cmdNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNew.Click

   End Sub

   Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
      Try


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
            Dim ispost, isFixed As Int32
            If IsDBNull(grid.Cells("IsPosted").Value) Then
               ispost = 0
               'Continue For
               '    End If

               'End If
               If ispost = 0 Then
                  If grid.Cells("VType").Value.ToString() = "FBPV" Or grid.Cells("VType").Value.ToString() = "FBRV" Then
                     isFixed = 1
                  Else
                     isFixed = 0
                  End If
                  qryMain = "EXEC SPSaveVoucherUnPosting " & grid.Cells("VID").Value.ToString & ",'" & grid.Cells("VType").Value.ToString & "'," & ispost & "," & G_Compcode & "," & G_UID & "," & isFixed & ",'" & CDate(dtpPostingDate.Value).ToString("dd/MMM/yyyy") & "','" & grid.Cells("ChequeNo").Value.ToString & "','" & grid.Cells("ChequeDate").Value.ToString & "'"
                  'qryMain = "EXEC SpSaveAccOpening '" & myVID.Text & "'," & myAccountID.Text & "," & myDr.Text & "," & myCr.Text & "," & G_Compcode & "," & G_FinancialYearID & "," & G_UID & ",'" & G_IPAddress & "'," & G_UID & ",'" & G_IPAddress & "'"
                  objCommon.ExecuteNonQueryWithOpen(qryMain)
               End If
            End If
         Next
         objCommon.CloseConnection()
         'MessageBox.Show("Records inserted.")


         'End If
         'ClearHead("")
         FillGrid("")
           Catch ex As Exception
            MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            objCommon.CloseConnection()
        End Try

   End Sub

   Private Sub cmdSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSearch.Click
      FillGrid("")

   End Sub

   Private Sub cmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancel.Click
      ClearHead("")
   End Sub
End Class