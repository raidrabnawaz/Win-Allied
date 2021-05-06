Public Class frmLogin1
   Dim mymdi As EMSMain
   Dim objCommon As New clsCommon
    Dim dtCompany As New DataTable
    Dim dvCompany As DataView
    Private Sub frmLogin_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        mymdi = CType(Me.MdiParent, EMSMain)
        dtCompany = objCommon.FillCompanyDT(1, "")
        FillCompany()
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
      If IsNothing(cmbCompany.SelectedValue) Then
         MessageBox.Show("Please select company", G_APP_TITLE)
         Return
      End If
      If Setdouble(cmbCompany.SelectedValue.ToString()) <= 0 Then
         MessageBox.Show("Please select company", G_APP_TITLE)
         Return
      End If
      qryMain = " exec SPUserLogin '" & txtUserName.Text & "','" & txtPswd.Text & "'," & cmbCompany.SelectedValue.ToString() & ",0 ; "
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
      G_UID = Convert.ToInt16(dt.Rows(0)(0))
      G_Userlogin = dt.Rows(0)(1).ToString()
      G_IsAdmin = Convert.ToInt16(dt.Rows(0)(2))
      G_ServerDateTime = Convert.ToDateTime(dt.Rows(0)(3))
      G_Compcode = Convert.ToInt16(cmbCompany.SelectedValue)
      G_CompName = cmbCompany.Text
      G_IsAuditor = 0

      mymdi.StatusValueUserName.Text = txtUserName.Text
      mymdi.StatusValueTime.Text = G_ServerDateTime.ToString("dd/MM/yyyy HH:mm")
      mymdi.Text = G_APP_TITLE
      dt.Clear()
      dt = Nothing
      mymdi.EnableResources()
      cmdClose_Click(sender, e)
   End Sub
   Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
      Me.Close()
   End Sub
   Private Sub txtUserName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtUserName.TextChanged
        FillCompany()
    End Sub
    Private Sub FillCompany()
        cmbCompany.DataSource = Nothing
        If IsNothing(dtCompany) Then
            Return
        End If
        If dtCompany.Rows.Count <= 0 Then
            Return
        End If
        dvCompany = New DataView(dtCompany)
        dvCompany.RowFilter = " Userlogin ='" & Me.txtUserName.Text.Trim & "' "
        cmbCompany.DataSource = dvCompany
        cmbCompany.DisplayMember = "VName"
        cmbCompany.ValueMember = "VID"
    End Sub
End Class