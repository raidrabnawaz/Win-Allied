Public Class frmLookupUser
   Dim objCommon As New clsCommon
   Dim dt As New DataTable
   Dim dv As DataView
   Public VID, VCode, VName As String

   Private Sub LookupAcct_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
      FillDt()
      FillGrid()
   End Sub

   Private Sub FillGrid()
      dv = New DataView(dt)
      'SELECT     UserID, Userfullname, Userlogin, Userpassword, AllowAudit, AllowActual, IsAdmin, IsActive, UID, Tranzdatetime, CompCode
      'FROM dbo.tblSecUser
      If Me.txtVName.Text.Trim <> "" Then
         dv.RowFilter = " Userlogin LIKE '%" & Me.txtVName.Text.Trim & "%' or Userfullname LIKE '%" & Me.txtVName.Text.Trim & "%'  "
      End If
      grdAcctLookup.DataSource = dv
      grdAcctLookup.Columns(0).Visible = False
   End Sub

   
   Private Sub txtVName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtVName.TextChanged
      FillGrid()
   End Sub
   Private Sub grdAcctLookup_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdAcctLookup.CellDoubleClick
      VID = grdAcctLookup.Rows(e.RowIndex).Cells(0).Value
      VCode = grdAcctLookup.Rows(e.RowIndex).Cells(1).Value
      VName = grdAcctLookup.Rows(e.RowIndex).Cells(2).Value
      Me.Close()
   End Sub
   Private Sub chkActive_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkActive.CheckedChanged
      FillDt()
   End Sub
   Private Sub FillDt()
      dt = Nothing
      'SELECT UserID, Userfullname, Userlogin, Userpassword, AllowAudit, AllowActual, IsAdmin, IsActive, UID, Tranzdatetime, CompCode
      'FROM dbo.tblSecUser
      qryMain = "SELECT UserID, Userlogin, Userfullname FROM SecUser order by Userlogin "
      dt = objCommon.GetDataTable(qryMain)
   End Sub

   Private Sub txtVName_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles txtVName.KeyDown
      If e.KeyCode = Keys.Enter Then
         If grdAcctLookup.Rows.Count > 0 Then
            VID = grdAcctLookup.Rows(0).Cells(0).Value
            VCode = grdAcctLookup.Rows(0).Cells(1).Value
            VName = grdAcctLookup.Rows(0).Cells(2).Value
            Me.Close()
         End If
      End If
   End Sub
End Class