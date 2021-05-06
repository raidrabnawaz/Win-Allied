Public Class frmLogin
   Dim mymdi As EMSMain
   Dim objCommon As New clsCommon
   Dim dtCompany As New DataTable
   Dim dvCompany As DataView
   Private Sub frmLogin_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
      G_CURRENTDATE = Date.Now
      If G_CURRENTDATE > G_SOFTENDDATE Then
         End
      End If

      mymdi = CType(Me.MdiParent, EMSMain)
      dtCompany = objCommon.FillCompanyDT(1, "")
        objCommon.FillFinancialYear(cmbFinancialYear, 5)
        'FillCompany()
        qryMain = objCommon.GetComputerName
      If qryMain.ToUpper = "IJAZ-MIS" Then
         txtUserName.Text = "ADMIN"
         txtPswd.Text = "123"
      End If
   End Sub
   Private Sub cmdOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOK.Click
      txtUserName.Text = txtUserName.Text.Trim.Replace("'", "")
      txtPswd.Text = txtPswd.Text.Trim.Replace("'", "")
      If txtUserName.Text.Length < 3 Or txtPswd.Text.Length < 3 Then
         MessageBox.Show("Username / password length cannot less then 3 characters.", G_APP_TITLE)
         Return
      End If
      If cmbFinancialYear.SelectedValue = -1 Then
         MessageBox.Show("Select Valid Financial Year", G_APP_TITLE)
         Return
      End If
      'If IsNothing(cmbCompany.SelectedValue) Then
      '    MessageBox.Show("Please select company", G_APP_TITLE)
      '    Return
      'End If
      'If cmbCompany.SelectedValue <= 0 Then
      '    MessageBox.Show("Please select company", G_APP_TITLE)
      '    Return
      'End If
      'qryMain = " exec SpGetSecUser '" & txtUserName.Text & "','" & txtPswd.Text & "'," & cmbCompany.SelectedValue & ",1 ; "
      qryMain = " exec SpGetSecUser '" & txtUserName.Text & "','" & txtPswd.Text & "','ERP',''; "
      'SELECT top 1 U.UID, U.Userlogin, U.IsAdmin, GETDATE() AS servertime 
      Dim dt As DataTable = objCommon.GetDataTable(qryMain)
      If IsNothing(dt) Then
         MessageBox.Show("Invalid Username / password .", G_APP_TITLE)
         Return
      End If
      If dt.Rows.Count <= 0 Then
         MessageBox.Show("Invalid Username / password .", G_APP_TITLE)
         Return
      End If

      G_UID = dt.Rows(0)(0)
      G_Userlogin = dt.Rows(0)(1)
      G_IsAdmin = dt.Rows(0)("IsAdmin")
      G_ServerDateTime = DateTime.Now
        G_Compcode = dt.Rows(0)("CompanyID")
        G_CompIni = dt.Rows(0)("CompanyCode")
        G_CompName = dt.Rows(0)("CompanyName")
      G_CurrencyID = dt.Rows(0)("CurrencyID")
      G_IsAuditor = 1
      G_FinancialYearID = cmbFinancialYear.SelectedValue
      G_IPAddress = objCommon.GetIPAddress()
      mymdi.StatusValueUserName.Text = txtUserName.Text
      mymdi.StatusValueTime.Text = G_ServerDateTime.ToString("dd/MM/yyyy HH:mm")
      mymdi.StatusValueFinancialYear.Text = cmbFinancialYear.Text
      mymdi.Text = G_APP_TITLE
      dt.Clear()
      dt = Nothing
      mymdi.EnableResources()
      FillPeriod()

      cmdClose_Click(sender, e)
   End Sub
   Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
      Me.Close()
   End Sub
   Private Sub txtUserName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtUserName.TextChanged
      'FillCompany()
   End Sub
   Private Sub FillPeriod()
      qryMain = "EXEC SpGetAccbyIDFinancialYear " & G_Compcode & "," & G_FinancialYearID & ""
      Dim dt As DataTable = objCommon.GetDataTable(qryMain)
      PeriodFrom = Convert.ToDateTime(dt.Rows(0)("DateFrom")).ToString("dd/MMM/yyyy")
      PeriodTo = Convert.ToDateTime(dt.Rows(0)("DateTo")).ToString("dd/MMM/yyyy")

   End Sub

End Class