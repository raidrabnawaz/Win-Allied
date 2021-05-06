Public Class frmSecGroupPages

   Dim objCommon As New clsCommon
   Dim dt As DataTable
   Dim dtPagesInclude As DataTable
   Dim dtPagesExclude As DataTable
   Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
      G_CURRENTDATE = Date.Now
      If G_CURRENTDATE > G_SOFTENDDATE Then
         End
      End If

      txtID.Text = ""
      clbUserGroup.AutoGenerateColumns = False
      grdRecord.AutoGenerateColumns = False
      grdExclude.AutoGenerateColumns = False

      clbUserGroup.DataSource = Nothing
      grdExclude.DataSource = Nothing
      grdRecord.DataSource = Nothing

      txtVName.Focus()


   End Sub
   Private Sub txtVName_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtVName.KeyDown
      lblInformation.Text = ""
      Try
         If e.KeyCode = Keys.F2 Then
            frmLookupUser.ShowDialog()
            'txtID.Text = frmLookupUser.VID
            lblUserID.Text = frmLookupUser.VID
            txtVName.Text = frmLookupUser.VCode
            lblUserName.Text = frmLookupUser.VName
            frmLookupUser.Dispose()
            'cmdNew_Click(sender, e)
            FillForm()
            Return
         End If
         If e.KeyCode = Keys.Enter Then
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
            Me.lblUserID.Text = dt.Rows(0)("UserID") 'frmLookupSecUser.VID
            Me.txtVName.Text = dt.Rows(0)("Userlogin") 'frmLookupSecUser.VNo
            Me.lblUserName.Text = dt.Rows(0)("Userfullname") 'frmLookupSecUser.VNo
            FillForm()

         End If
      Catch ex As Exception
         MessageBox.Show(ex.Message)
      End Try
   End Sub
   Private Sub FillForm()
      Dim dtGroup, dtInclude, dtExclude As DataTable
      Dim i As Int16 = 0
      Dim myUID As Int16 = Setint(lblUserID.Text)
      'fill groups
      qryMain = " SELECT ISNULL(UG.VID, 0) AS VID , G.VID as GID , G.VName , case when ISNULL(UG.VID, 0) > 0 then 1 else 0 end as IsView " & _
      " FROM (select VID,RoleID as GroupID from SecUserRole WHERE UserID= " & myUID & " ) AS UG RIGHT OUTER JOIN dbo.SecRole AS G ON UG.GroupID = G.VID order by VName "
      dtGroup = objCommon.GetDataTable(qryMain)
      clbUserGroup.DataSource = dtGroup
      ' include list
      qryMain = " SELECT ISNULL(SP.VID,0) VID, P.VID AS PageID, ISNULL(SP.UserID,0)as UserID, replicate('-',P.MenuLevel*3) + P.VName as VName , ISNULL(SP.Isactive, 0) Isactive, ISNULL(SP.IsView,0) IsView, ISNULL(SP.IsInsert,0) IsInsert,  " &
    " ISNULL(SP.IsUpdate,0) IsUpdate, ISNULL(SP.IsDelete,0) IsDelete, ISNULL(SP.IsBackdate,0) IsBackdate, ISNULL(SP.IsPrint,0) IsPrint  " &
    " FROM dbo.SecPage AS P LEFT OUTER JOIN " &
    " (SELECT VID, UserID, PageID, Isactive, IsView, IsInsert, IsUpdate, IsDelete, IsBackdate, IsPrint, IncludeExclude,InsertedBy as UID,InsertedDate As Tranzdatetime,5 CompCode FROM dbo.SecUserPage WHERE UserID = " & myUID & " AND ISNULL(IncludeExclude,0)=1 ) AS SP ON P.VID = SP.PageID and P.IsMVC=2 and p.MenuLevel<4 Order By p.SrlNo ; "
      dtInclude = objCommon.GetDataTable(qryMain)
      'grdRecord.DataSource = dtInclude
      ' exclude list
      qryMain = " SELECT ISNULL(SP.VID,0) VID, P.VID AS PageID, ISNULL(SP.UserID,0)as UserID, replicate('-',P.MenuLevel*3) + P.VName as VName , ISNULL(SP.Isactive, 0) Isactive, ISNULL(SP.IsView,0) IsView, ISNULL(SP.IsInsert,0) IsInsert,  " &
    " ISNULL(SP.IsUpdate,0) IsUpdate, ISNULL(SP.IsDelete,0) IsDelete, ISNULL(SP.IsBackdate,0) IsBackdate, ISNULL(SP.IsPrint,0) IsPrint  " &
    " FROM dbo.SecPage AS P LEFT OUTER JOIN " &
    " (SELECT VID, UserID, PageID, Isactive, IsView, IsInsert, IsUpdate, IsDelete, IsBackdate, IsPrint, IncludeExclude,InsertedBy as UID,InsertedDate As Tranzdatetime,5 CompCode  FROM dbo.SecUserPage WHERE UserID = " & myUID & " AND ISNULL(IncludeExclude,0)=0 ) AS SP ON P.VID = SP.PageID  and P.IsMVC=2 and p.MenuLevel<4  Order By p.SrlNo ; "
      dtExclude = objCommon.GetDataTable(qryMain)
      'grdExclude.DataSource = dtExclude
   End Sub
   Private Sub cmdNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNew.Click
      txtVName.Text = ""
      txtID.Text = "0"
      lblUserID.Text = "0"
      txtVName.Text = ""
      lblUserName.Text = ""
      txtVName.Focus()
      grdExclude.DataSource = Nothing
      grdRecord.DataSource = Nothing
      clbUserGroup.DataSource = Nothing
   End Sub

   Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
      lblInformation.Text = ""

      txtVName.Text = txtVName.Text.Trim.ToUpper
      'txtID.Text = Setint(txtID.Text)
      lblUserID.Text = Setint(lblUserID.Text)

      Dim ErrorMsg As String = VerifySave()
      If ErrorMsg <> "" Then
         MessageBox.Show(ErrorMsg, G_APP_TITLE)
         Exit Sub
      End If

      Dim myrowcount As Int16
      Dim myUserID = 0, myGroupID As Int16 = 0
      Dim myVID = 0, myIsactive As Int16 = 0
      Dim dr As DataGridViewRow
      'Group saving start --------------------------------------------------------------------------------------
      myUserID = Setint(lblUserID.Text)
      'myGroupID = Setint(txtID.Text)
      myrowcount = clbUserGroup.RowCount - 1
      Dim ispost, isFixed As Int32

      For lcount As Int16 = 0 To myrowcount
         dr = clbUserGroup.Rows(lcount)
         'G.VID , GID, G.VName , IsView
         myVID = Setdouble(dr.Cells(0).Value)
         myGroupID = Setdouble(dr.Cells(1).Value)
         If Not IsDBNull(dr.Cells(3).Value) Then
            myIsactive = Setdouble(dr.Cells(3).Value)
         Else
            myIsactive = 0
         End If

         If myVID <= 0 Then            'New
            If myIsactive = 1 Then 'insert
               qryMain = "insert into SecUserRole (UserID, RoleID, Isactive, InsertedBy, InsertedDate ) values( " &
          myUserID & ", " & myGroupID & ", 1, " & G_UID & ", GETDATE() ); "
               objCommon.ExecuteNonQuery(qryMain)
            Else
               'do noting
            End If
         Else             'Editing
            If myIsactive = 1 Then
               'do noting
            Else 'delete entry
               qryMain = "delete from SecUserRole where VID=" & myVID & " ; "
               objCommon.ExecuteNonQuery(qryMain)
            End If
         End If
      Next
      'Group saving end --------------------------------------------------------------------------------------

      'include saving start --------------------------------------------------------------------------------------
      Dim myPageID As Int16 = 0
      Dim myIsView = 0, myIsInsert = 0, myIsUpdate = 0, IsDelete = 0, IsBackdate = 0, IsPrint As Int16 = 0

      myrowcount = grdRecord.RowCount - 1
      For lcount As Int16 = 0 To myrowcount
         dr = grdRecord.Rows(lcount)
         'VID, PageID, UserID, VName , Isactive, IsView, IsInsert, IsUpdate, IsDelete, IsBackdate, IsPrint
         myVID = Setdouble(dr.Cells(0).Value)
         myPageID = Setdouble(dr.Cells(1).Value)
         myIsactive = IIf(dr.Cells(4).Value, 1, 0)
         myIsView = IIf(dr.Cells(5).Value, 1, 0)
         myIsInsert = IIf(dr.Cells(6).Value, 1, 0)
         myIsUpdate = IIf(dr.Cells(7).Value, 1, 0)
         IsDelete = IIf(dr.Cells(8).Value, 1, 0)
         IsBackdate = IIf(dr.Cells(9).Value, 1, 0)
         IsPrint = IIf(dr.Cells(10).Value, 1, 0)

         If myVID <= 0 Then            'New
            If myIsView = 1 Then 'insert
               qryMain = "insert into SecUserPage  (UserID, PageID, Isactive, IsView, IsInsert, IsUpdate, IsDelete, IsBackdate, IsPrint, IncludeExclude, InsertedBy, InsertedDate  ) values( " & _
               myUserID & ", " & myPageID & ", " & myIsactive & ", " & myIsView & ", " & myIsInsert & ", " & myIsUpdate & ", " & IsDelete & ", " & IsBackdate & ", " & IsPrint & " , 1 , " & G_UID & ", GETDATE() ); "
               objCommon.ExecuteNonQuery(qryMain)
            Else
               'do noting
            End If
         Else             'Editing
            If myIsView = 1 Then ' update
               qryMain = "update SecUserPage set Isactive=" & myIsactive & ", IsView=" & myIsView & ", IsInsert=" & myIsInsert & ", IsUpdate=" & myIsUpdate & ", IsDelete=" & IsDelete & ", IsBackdate=" & IsBackdate & ", IsPrint= " & IsPrint & " where VID=" & myVID & " ; "
               objCommon.ExecuteNonQuery(qryMain)
            Else 'delete entry
               qryMain = "delete from SecUserPage where VID=" & myVID & " ; "
               objCommon.ExecuteNonQuery(qryMain)
            End If
         End If
      Next
      'include saving end --------------------------------------------------------------------------------------

      'exclude saving start --------------------------------------------------------------------------------------
      myrowcount = grdExclude.RowCount - 1
      For lcount As Int16 = 0 To myrowcount
         dr = grdExclude.Rows(lcount)
         'VID, PageID, UserID, VName , Isactive
         myVID = Setdouble(dr.Cells(0).Value)
         myPageID = Setdouble(dr.Cells(1).Value)
         myIsactive = 0
         myIsView = IIf(dr.Cells(4).Value, 1, 0)
         myIsInsert = 0
         myIsUpdate = 0
         IsDelete = 0
         IsBackdate = 0
         IsPrint = 0

         If myVID <= 0 Then            'New
            If myIsView = 1 Then 'insert
               qryMain = "insert into SecUserPage  (UserID, PageID, Isactive, IsView, IsInsert, IsUpdate, IsDelete, IsBackdate, IsPrint, IncludeExclude, InsertedBy, InsertedDate  ) values( " & _
               myUserID & ", " & myPageID & ", " & myIsactive & ", " & myIsView & ", " & myIsInsert & ", " & myIsUpdate & ", " & IsDelete & ", " & IsBackdate & ", " & IsPrint & " , 0 , " & G_UID & ", GETDATE() ); "
               objCommon.ExecuteNonQuery(qryMain)
            Else
               'do noting
            End If
         Else             'Editing
            If myIsView = 1 Then ' update
               qryMain = "update SecUserPage set Isactive=" & myIsactive & ", IsView=" & myIsView & ", IsInsert=" & myIsInsert & ", IsUpdate=" & myIsUpdate & ", IsDelete=" & IsDelete & ", IsBackdate=" & IsBackdate & ", IsPrint= " & IsPrint & " where VID=" & myVID & " ; "
               objCommon.ExecuteNonQuery(qryMain)
            Else 'delete entry
               qryMain = "delete from SecUserPage where VID=" & myVID & " ; "
               objCommon.ExecuteNonQuery(qryMain)
            End If
         End If
      Next
      'exclude saving end --------------------------------------------------------------------------------------
      lblInformation.Text = "Record Saved."
      txtVName.Focus()
      FillForm()
   End Sub
   Private Function VerifySave() As String
      Dim ErrorMsg As String = ""
      If Setint(lblUserID.Text) = 0 Then
         ErrorMsg &= "Please Select some User." & vbNewLine
      End If
      Return ErrorMsg
   End Function
   Private Sub cmdDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDelete.Click

   End Sub
   Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
      Me.Close()
   End Sub

   'Private Sub grdRecord_CurrentCellDirtyStateChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grdRecord.CurrentCellDirtyStateChanged
   '   If grdRecord.IsCurrentCellDirty Then
   '      grdRecord.CommitEdit(DataGridViewDataErrorContexts.Commit)
   '   End If
   'End Sub

   'Private Sub grdExclude_CurrentCellDirtyStateChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grdExclude.CurrentCellDirtyStateChanged
   '   If grdExclude.IsCurrentCellDirty Then
   '      grdExclude.CommitEdit(DataGridViewDataErrorContexts.Commit)
   '   End If
   'End Sub

End Class