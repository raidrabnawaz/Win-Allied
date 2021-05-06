Public Class frmLookupCOA
    Dim objCommon As New clsCommon
    Dim dt As New DataTable
    Dim dv As DataView
    'Public VID, VCode, VName, Department, strIsActive, strEmpType, strViewEmployee As String
    Public VCode, VName, VType As String
    Public VCodeIni As String
   Public VID, AccTypeID As Int64

    Public ETypeID As String 'First 4 chars
    Private Sub FillGrid()
        dv = New DataView(dt)
      If Me.txtVName.Text.Trim <> "" Then
         If (ETypeID = "Report") Then
            dv.RowFilter = " AccountCode LIKE '%" & Me.txtVName.Text.Trim & "%' or  Description like '%" & Me.txtVName.Text.Trim & "%' "
         Else
            dv.RowFilter = "VName like '%" & Me.txtVName.Text.Trim & "%' "
         End If
      ElseIf VCodeIni <> "" Then
         'dv.RowFilter = " VName LIKE '" & VCodeIni & "%' "
         Me.txtVName.Text = VCodeIni
      End If
      grdAcctLookup.DataSource = dv
      If grdAcctLookup.Rows.Count > 0 Then grdAcctLookup.Columns(0).Visible = False
      If grdAcctLookup.Rows.Count > 0 Then setGrid(grdAcctLookup)
    End Sub
    Private Sub LookupAcct_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FillDt()
        FillGrid()
    End Sub
    Private Sub txtVName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtVName.TextChanged
        If txtVName.Text.Trim = "" Then
            VCodeIni = ""
        End If 
        FillGrid()
    End Sub
   Private Sub grdAcctLookup_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdAcctLookup.CellDoubleClick
      If (ETypeID = "Report") Then
         VID = grdAcctLookup.Rows(e.RowIndex).Cells(0).Value
         VCode = grdAcctLookup.Rows(e.RowIndex).Cells(1).Value
         VName = grdAcctLookup.Rows(e.RowIndex).Cells(2).Value
      ElseIf (ETypeID = "COA") Then
         VID = grdAcctLookup.Rows(e.RowIndex).Cells(0).Value
         VCode = grdAcctLookup.Rows(e.RowIndex).Cells(1).Value
         VName = grdAcctLookup.Rows(e.RowIndex).Cells(2).Value
      Else
         VCode = grdAcctLookup.Rows(e.RowIndex).Cells(0).Value
         VName = grdAcctLookup.Rows(e.RowIndex).Cells(1).Value
      End If 
      Me.Close()
   End Sub
   Private Sub chkActive_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkActive.CheckedChanged
      FillDt()
   End Sub
   Private Sub FillDt()
      dt = Nothing
        'qryMain = "SELECT D.VCode, D.VName, H.L2Code, H.VName AS VNameH, HH.L1Code, HH.VName AS VNameHH " &
        '    " FROM dbo.tblAcSetupCOAL1 AS HH INNER JOIN dbo.tblAcSetupCOAL2 AS H ON HH.L1Code = H.L1Code INNER JOIN dbo.tblAcSetupCOA AS D ON H.L2Code = D.L2Code " &
        '    " where D.VCode like '" & ETypeID & "%' order by D.VCode  "     exec SpGetAccAccountCOAByCompany @CompanyID =5
        If (ETypeID = "Report") Then
            qryMain = "EXEC SpGetAccAccountCOAByCompany " & G_Compcode & ""
        ElseIf (ETypeID = "COA") Then
            qryMain = "EXEC SpGetAccAccountCOA " & G_Compcode & ""
        ElseIf (VType = "Fixed") Or (VType = "FCRV") Or (VType = "FBPV") Or (VType = "FBRV") Then
            qryMain = " exec Get_AccSingleAccountType " & AccTypeID & "," & G_Compcode & "" 
      Else
         qryMain = "EXEC SpGetbyGLShow_AccAccountCOA " & G_Compcode & ", '" & VType & "'"
      End If
      dt = objCommon.GetDataTable(qryMain)
   End Sub

     
    Private Sub grdAcctLookup_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles grdAcctLookup.KeyDown
        If e.KeyCode = Keys.Enter Then
            If grdAcctLookup.Rows.Count > 0 Then
            Dim cell As DataGridViewCell = grdAcctLookup.CurrentCell()
            If (ETypeID = "Report") Then
               VID = grdAcctLookup.Rows(cell.RowIndex).Cells(0).Value
               VCode = grdAcctLookup.Rows(cell.RowIndex).Cells(1).Value
               VName = grdAcctLookup.Rows(cell.RowIndex).Cells(2).Value
               Me.Close()
            ElseIf (ETypeID = "COA") Then
               VID = grdAcctLookup.Rows(cell.RowIndex).Cells(0).Value
               VCode = grdAcctLookup.Rows(cell.RowIndex).Cells(1).Value
               VName = grdAcctLookup.Rows(cell.RowIndex).Cells(2).Value
               Me.Close()
            Else
               VCode = grdAcctLookup.Rows(cell.RowIndex).Cells(0).Value
               VName = grdAcctLookup.Rows(cell.RowIndex).Cells(1).Value
               Me.Close()
            End If
         End If
      End If
    End Sub
End Class