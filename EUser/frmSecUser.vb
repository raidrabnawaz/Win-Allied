Public Class frmSecUser

   Dim objCommon As New clsCommon

   Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
      G_CURRENTDATE = Date.Now
      If G_CURRENTDATE > G_SOFTENDDATE Then
         End
      End If

      txtID.Text = "0"
      If G_IsAudit = 0 Then
         chkIsAllowed.Visible = False
      Else
         chkIsAllowed.Visible = True
      End If
      ClearHead(0)
      FillGrid()
      objCommon.FillEmployee(Me.cmbEmployee)
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
      Dim grdcol3 As System.Windows.Forms.DataGridViewTextBoxColumn
      Dim grdcol4 As System.Windows.Forms.DataGridViewCheckBoxColumn
      Dim grdcol5 As System.Windows.Forms.DataGridViewCheckBoxColumn
      Dim grdcol6 As System.Windows.Forms.DataGridViewCheckBoxColumn
      Dim grdcol7 As System.Windows.Forms.DataGridViewCheckBoxColumn
      Dim grdcol8 As System.Windows.Forms.DataGridViewTextBoxColumn
      Dim grdcol9 As System.Windows.Forms.DataGridViewTextBoxColumn

      grdcol0 = New System.Windows.Forms.DataGridViewTextBoxColumn()
      grdcol1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
      grdcol2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
      grdcol3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
      grdcol4 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
      grdcol5 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
      grdcol6 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
      grdcol7 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
      grdcol8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
      grdcol9 = New System.Windows.Forms.DataGridViewTextBoxColumn()

      grdcol0.DataPropertyName = "UserID"
      grdcol0.HeaderText = "UserID"
      grdcol0.Name = "grdcol0"
      grdcol0.Visible = False

      '
      'grdcol1
      '
      grdcol1.DataPropertyName = "Userfullname"
      grdcol1.HeaderText = "User Full Name"
      grdcol1.Name = "grdcol1"
      grdcol1.ReadOnly = True
      grdcol1.Width = 300

      '
      'grdcol2
      '
      grdcol2.DataPropertyName = "Userlogin"
      grdcol2.HeaderText = "User login"
      grdcol2.Name = "grdcol2"
      grdcol2.ReadOnly = True
      grdcol2.Width = 80

      '
      'grdcol3
      '
      grdcol3.DataPropertyName = "Userpassword"
      grdcol3.HeaderText = "User Password"
      grdcol3.Name = "grdcol3"
      grdcol3.Visible = False
      grdcol3.Width = 80

      '
      'grdcol4
      '
      grdcol4.DataPropertyName = "AllowAudit"
      grdcol4.HeaderText = "Allow Audit"
      grdcol4.Name = "grdcol4"
      grdcol4.ReadOnly = True
      grdcol4.Width = 80

      '
      'grdcol5
      '
      grdcol5.DataPropertyName = "AllowActual"
      grdcol5.HeaderText = "Allow Actual"
      grdcol5.Name = "grdcol5"
      grdcol5.ReadOnly = True
      grdcol5.Width = 80

      '
      'grdcol6
      '
      grdcol6.DataPropertyName = "IsAdmin"
      grdcol6.HeaderText = "Admin"
      grdcol6.Name = "grdcol6"
      grdcol6.ReadOnly = True
      grdcol6.Width = 80

      '
      'grdcol7
      '
      grdcol7.DataPropertyName = "IsActive"
      grdcol7.HeaderText = "Active"
      grdcol7.Name = "grdcol7"
      grdcol7.ReadOnly = True
      grdcol7.Width = 80

      '
      'grdcol8
      '
      grdcol8.DataPropertyName = "UserID"
      grdcol8.HeaderText = "UID"
      grdcol8.Name = "grdcol8"
      grdcol8.Visible = False
      grdcol8.Width = 80

      '
      'grdcol9
      '
      grdcol9.DataPropertyName = "DefaultCompanyID"
      grdcol9.HeaderText = "CompCode"
      grdcol9.Name = "grdcol9"
      grdcol9.Visible = False
      grdcol9.Width = 80
      Me.grdRecord.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {grdcol0, grdcol1, grdcol2, grdcol3, grdcol4, grdcol5, grdcol6, grdcol7, grdcol8, grdcol9})
   End Sub
   Private Sub FillGrid()
      grdRecord.DataSource = Nothing
      grdRecord.Rows.Clear()
      grdRecord.Columns.Clear()
      FillHeader()

      'qryMain = " SELECT  UserID, Userfullname, Userlogin, Userpassword, cast(AllowAudit as bit) AllowAudit, cast(AllowActual as bit) AllowActual, cast(IsAdmin as bit) IsAdmin, cast(IsActive as bit) IsActive, UserID, DefaultCompanyID FROM  SecUser "
      qryMain = "EXEC SpGetAll_SecUser "
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
      qryMain = "EXEC SpGetbyID_SecUser " & Setdouble(txtID.Text) & ""
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
      txtID.Text = dr("UserID")
      txtVName.Text = dr("Userfullname")
      txtLogin.Text = dr("Userlogin")
      txtUserPassword.Text = dr("Userpassword")
      chkIsAllowed.Checked = dr("AllowAudit")
      chkAllowActual.Checked = dr("AllowActual")
      chkIsAdmin.Checked = dr("IsAdmin")
      chkIsActive.Checked = dr("IsActive")
      cmbEmployee.SelectedValue = dr("EmployeeID")

   End Sub
   Private Sub cmdNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNew.Click
      txtVName.Text = ""
      txtID.Text = 0
      txtVName.Text = ""
      txtLogin.Text = ""
      txtUserPassword.Text = ""
      chkAllowActual.Checked = False
      chkIsActive.Checked = False
      chkIsAdmin.Checked = False
      chkIsAllowed.Checked = False
      cmbEmployee.SelectedIndex = 0
      txtVName.Focus()

   End Sub
   Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
      lblInformation.Text = ""

      'varify for empty string
      'varify group > -1
      'varify already existance
      txtVName.Text = txtVName.Text.Trim.ToUpper
      txtID.Text = txtID.Text.Trim.ToUpper

      Dim ErrorMsg As String = VerifySave()

      If ErrorMsg <> "" Then
         MessageBox.Show(ErrorMsg, G_APP_TITLE)
         Exit Sub
      End If


      If Setint(txtID.Text) > 0 Then 'update
         '   qryMain = " update SecUser set Userfullname='" & txtVName.Text & "', Userlogin='" & txtLogin.Text & "', Userpassword='" & txtUserPassword.Text & "', AllowAudit=" & IIf(chkIsAllowed.Checked, 1, 0) & ", AllowActual=" & IIf(chkAllowActual.Checked, 1, 0) & ", IsAdmin=" & IIf(chkIsAdmin.Checked, 1, 0) & ", IsActive=" & IIf(chkIsActive.Checked, 1, 0) & ",  UserID=" & G_UID & ",Tranzdatetime=getdate() where UserID = " & Setint(txtID.Text)
         '   objCommon.ExecuteNonQuery(qryMain)
         qryMain = "EXEC SpSave_SecUser " & txtID.Text & "," & cmbEmployee.SelectedValue & ",'" & txtVName.Text & "', '" & txtLogin.Text & "', '" & txtUserPassword.Text & "'," & G_Compcode & ", " & IIf(chkIsAllowed.Checked, 1, 0) & ", " & IIf(chkAllowActual.Checked, 1, 0) & ", " & IIf(chkIsAdmin.Checked, 1, 0) & ",6, " & IIf(chkIsActive.Checked, 1, 0) & ", " & G_UID & ",'1900-01-01','" & G_IPAddress & "'"
         qryMain = objCommon.ExecuteScalar(qryMain)
         txtID.Text = Setint(qryMain)
      Else
         qryMain = "EXEC SpSave_SecUser " & txtID.Text & "," & cmbEmployee.SelectedValue & ",'" & txtVName.Text & "', '" & txtLogin.Text & "', '" & txtUserPassword.Text & "'," & G_Compcode & ", " & IIf(chkIsAllowed.Checked, 1, 0) & ", " & IIf(chkAllowActual.Checked, 1, 0) & ", " & IIf(chkIsAdmin.Checked, 1, 0) & ",6, " & IIf(chkIsActive.Checked, 1, 0) & ", " & G_UID & ",'1900-01-01','" & G_IPAddress & "'"
         qryMain = objCommon.ExecuteScalar(qryMain)
         txtID.Text = Setint(qryMain)

         qryMain = "EXEC SpSave_SecUserCompany 0, " & Setint(txtID.Text) & ",'" & txtVName.Text & "','-','-', " & G_Compcode & ", 1," & G_UID & " ,'1900-01-01','" & G_IPAddress & "'"
         objCommon.ExecuteNonQuery(qryMain)

      End If
      FillGrid()
      lblInformation.Text = "Record Saved."
      cmdNew_Click(Nothing, Nothing)
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

   Private Function VerifySave() As String
      Dim ErrorMsg As String = ""

      txtUserPassword.Text = txtUserPassword.Text.Trim
      txtLogin.Text = txtLogin.Text.Trim

      If txtVName.Text = "" Then
         ErrorMsg &= "Please give some User Name." & vbNewLine
      End If

      If txtLogin.Text.Length < 3 Then
         ErrorMsg &= "Login length cannot less then 3 characters." & vbNewLine
      End If
      If txtUserPassword.Text.Length < 3 Then
         ErrorMsg &= "password length cannot less then 3 characters." & vbNewLine
      End If

      Return ErrorMsg
   End Function

   Private Sub txtVName_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtVName.KeyDown
      lblInformation.Text = ""
      Try
         If e.KeyCode = Keys.F2 Then

            frmLookupUser.ShowDialog()
            txtID.Text = frmLookupUser.VID
            txtVName.Text = frmLookupUser.VName
            txtLogin.Text = frmLookupUser.VCode
            frmLookupUser.Dispose()
            FillForm()
            Return
         End If
         If e.KeyCode = Keys.Enter Then
            Dim dt As DataTable
            qryMain = "SELECT UserID, Userfullname, Userlogin, IsActive FROM SecUser WHERE Userlogin='" & txtVName.Text.Trim & "'"
            dt = objCommon.GetDataTable(qryMain)
            If IsNothing(dt) Then
               lblInformation.Text = "Invalid User.!"
               cmdNew_Click(sender, e)
               Return
            End If
            If dt.Rows.Count <= 0 Then
               lblInformation.Text = "Invalid User.!"
               cmdNew_Click(sender, e)
               Return
            End If

            cmdNew_Click(sender, e)
            Me.txtID.Text = dt.Rows(0)("UserID") 'frmLookupSecUser.VID
            Me.txtVName.Text = dt.Rows(0)("Userfullname") 'frmLookupSecUser.VNo
            Me.txtLogin.Text = dt.Rows(0)("Userlogin") 'frmLookupSecUser.VNo
            FillForm()

         End If
      Catch ex As Exception
         MessageBox.Show(ex.Message)
      End Try
   End Sub
End Class