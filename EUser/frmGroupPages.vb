Public Class frmGroupPages
    
   Dim objCommon As New clsCommon
    Dim dt As DataTable

   Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
      G_CURRENTDATE = Date.Now
      If G_CURRENTDATE > G_SOFTENDDATE Then
         End
      End If

      txtID.Text = ""
      ClearHead(0)
      'FillGrid()
      fillGroup()
      cmbGroup.Focus()
   End Sub
    Private Sub ClearHead(ByVal myid As Integer)
        If myid = -1 Then
            'do not change txtID.Text 
        Else
         txtID.Text = myid.ToString()
        End If
        lblInformation.Text = ""
        'txtVName.Text = ""
    End Sub
    Private Sub FillHeader()
        'grdRecord.DataSource = Nothing
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim grdcol0 As System.Windows.Forms.DataGridViewTextBoxColumn
        Dim grdcol1 As System.Windows.Forms.DataGridViewTextBoxColumn
        Dim grdcol2 As System.Windows.Forms.DataGridViewCheckBoxColumn
        Dim grdcol3 As System.Windows.Forms.DataGridViewCheckBoxColumn
        Dim grdcol4 As System.Windows.Forms.DataGridViewCheckBoxColumn
        Dim grdcol5 As System.Windows.Forms.DataGridViewCheckBoxColumn
        Dim grdcol6 As System.Windows.Forms.DataGridViewCheckBoxColumn
        Dim grdcol7 As System.Windows.Forms.DataGridViewCheckBoxColumn
        Dim grdcol8 As System.Windows.Forms.DataGridViewCheckBoxColumn
        Dim grdcol9 As System.Windows.Forms.DataGridViewTextBoxColumn


        grdcol0 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        grdcol1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        grdcol2 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        grdcol3 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        grdcol4 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        grdcol5 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        grdcol6 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        grdcol7 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        grdcol8 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        grdcol9 = New System.Windows.Forms.DataGridViewTextBoxColumn()


        grdcol0.DataPropertyName = "VID"
        grdcol0.HeaderText = "VID"
        grdcol0.Name = "grdcol0"
        grdcol0.Visible = False
        '
        'grdcol1
        '
        grdcol1.DataPropertyName = "VName"
        grdcol1.HeaderText = "Page Name"
        grdcol1.Name = "grdcol1"
        grdcol1.ReadOnly = True
        grdcol1.Width = 200
        '
        'grdcol2
        '
        grdcol2.DataPropertyName = "Isactive"
        grdcol2.HeaderText = "Is Active"
        grdcol2.Name = "grdcol2"
        grdcol2.ReadOnly = False
        grdcol2.Width = 80
        grdcol2.Visible = False
        'grdcol3
        '
        grdcol3.DataPropertyName = "IsView"
        grdcol3.HeaderText = "Is View"
        grdcol3.Name = "grdcol3"
        grdcol3.ReadOnly = False
        grdcol3.Width = 80
        'grdcol4
        '
        grdcol4.DataPropertyName = "IsInsert"
        grdcol4.HeaderText = "Is Insert"
        grdcol4.Name = "grdcol4"
        grdcol4.ReadOnly = False
        grdcol4.Width = 80
        grdcol4.Visible = False
        'grdcol5
        '
        grdcol5.DataPropertyName = "IsUpdate"
        grdcol5.HeaderText = "Is Update"
        grdcol5.Name = "grdcol5"
        grdcol5.ReadOnly = False
        grdcol5.Width = 80
        grdcol5.Visible = False
        'grdcol6
        '
        grdcol6.DataPropertyName = "IsDelete"
        grdcol6.HeaderText = "Is Delete"
        grdcol6.Name = "grdcol6"
        grdcol6.ReadOnly = False
        grdcol6.Width = 80
        grdcol6.Visible = False
        'grdcol7
        '
        grdcol7.DataPropertyName = "IsBackdate"
        grdcol7.HeaderText = "Is Backdate"
        grdcol7.Name = "grdcol7"
        grdcol7.ReadOnly = False
        grdcol7.Width = 80
        grdcol7.Visible = False
        'grdcol8
        '
        grdcol8.DataPropertyName = "IsPrint"
        grdcol8.HeaderText = "Is Print"
        grdcol8.Name = "grdcol8"
        grdcol8.ReadOnly = False
        grdcol8.Width = 80
        grdcol8.Visible = False

        grdcol9.DataPropertyName = "PGID"
        grdcol9.HeaderText = "PGID"
        grdcol9.Name = "grdcol9"
        grdcol9.Visible = False
        Me.grdRecord.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {grdcol0, grdcol1, grdcol2, grdcol3, grdcol4, grdcol5, grdcol6, grdcol7, grdcol8, grdcol9})
    End Sub
    Private Sub FillGrid()
        grdRecord.DataSource = Nothing
        grdRecord.Rows.Clear()
        grdRecord.Columns.Clear()
        FillHeader()
      qryMain = " SELECT p.VID, replicate('-',p.MenuLevel*3) + p.VName as VName, isnull(pg.Isactive,0) as Isactive, isnull(pg.IsBackdate,0) as IsBackdate, isnull(pg.IsDelete,0) as IsDelete, isnull(pg.IsInsert,0) as IsInsert, isnull(pg.IsPrint,0) as IsPrint,  " &
              " isnull(pg.IsUpdate,0) as IsUpdate, isnull(pg.IsView,0) as IsView, ISNULL(pg.VID, 0) AS PGID " &
              " FROM (SELECT VID, RoleID, PageID, Isactive, IsView, IsInsert, IsUpdate, IsDelete, IsBackdate, IsPrint, " &
              " InsertedBy as UID, InsertedDate As Tranzdatetime,5 AS CompCode FROM dbo.SecRolePage WHERE RoleID = " & cmbGroup.SelectedValue.ToString & " ) AS pg RIGHT OUTER JOIN " &
              " dbo.SecPage AS p ON pg.PageID = p.VID and p.MenuLevel<4 where  P.IsMVC=2   ORDER BY p.SrlNo"
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
    End Sub
    Private Sub fillGroup()
      qryMain = "Select '-1' as VID, '---Select Group---' as VName union all Select VID,VName From SecRole WHERE Isactive = 1 ORDER BY VName "
        Dim dt As DataTable = objCommon.GetDataTable(qryMain)
        cmbGroup.DataSource = dt
        cmbGroup.DisplayMember = "VName"
        cmbGroup.ValueMember = "VID"
    End Sub
    Private Sub FillForm()
        lblInformation.Text = ""
        If Setdouble(txtID.Text) <= 0 Then
            ClearHead(0)
            Return
        End If
        qryMain = " SELECT top 1 VName,MenuName,Isactive From SecPage WHERE VID=" & Setdouble(txtID.Text) & ""
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
        'txtVName.Text = dr("VName")
        'txtMName.Text = dr("MenuName")
      cmbGroup.Text = dr("VName").ToString()
        'If dr("Isactive") = "0" Then
        '    chkActive.Checked = False
        'Else
        '    chkActive.Checked = True
        'End If
    End Sub
    Private Sub cmdNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNew.Click
        'txtVName.Text = ""
        txtID.Text = ""
        'txtMName.Text = ""
        'chkActive.Checked = False
        cmbGroup.Text = "---Select Group---"
        'txtVName.Focus()
    End Sub
    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        lblInformation.Text = ""

        'varify for empty string
        'varify group > -1
        'varify already existance
        ' txtVName.Text = txtVName.Text.Trim.ToUpper
      txtID.Text = txtID.Text.Trim.ToUpper
        'If txtVName.Text = "" Then
        '    MessageBox.Show("Please give some name.", G_APP_TITLE)
        '    Return
        'End If
        'qryMain = " Select top 1 VID from tblSecPage where VID <>'" & txtID.Text & "' and VName='' "
        'qryMain = objCommon.ExecuteScalar(qryMain)
        'If qryMain <> "" Then
        '    MessageBox.Show("Group already exists.", G_APP_TITLE)
        '    Return
        'End If
        'Dim mlevel As Int32 = Setint(cmbGroup.SelectedValue.ToString) - (-1)

        For i As Int32 = 0 To dt.Rows.Count - 1
         If Setdouble(dt.Rows(i)("PGID").ToString()) > 0 Then 'update
                'qryMain = " update tblSecPageGroup set Isactive = " & IIf(dt.Rows(i)("Isactive") = True, 1, 0) & ",IsView = " & IIf(dt.Rows(i)("IsView") = True, 1, 0) & " , UID=" & G_UID & ", " & _
                '" IsInsert=" & IIf(dt.Rows(i)("IsInsert") = True, 1, 0) & ", IsUpdate=" & IIf(dt.Rows(i)("IsUpdate") = True, 1, 0) & " , IsDelete = " & IIf(dt.Rows(i)("IsDelete") = True, 1, 0) & ", " & _
                '" IsBackdate = " & IIf(dt.Rows(i)("IsBackdate") = True, 1, 0) & ", IsPrint = " & IIf(dt.Rows(i)("IsPrint") = True, 1, 0) & ",  Tranzdatetime=getdate() , CompCode = " & G_Compcode & " " & _
                '" where  PageID = " & dt.Rows(i)("VID") & " and GroupID = " & cmbGroup.SelectedValue.ToString & " "
                qryMain = " update SecRolePage set Isactive = " & If(Convert.ToBoolean(dt.Rows(i)("IsView")) = True, 1, 0) & ",IsView = " & If(Convert.ToBoolean(dt.Rows(i)("IsView")) = True, 1, 0) & " , UpdatedBy=" & G_UID & ", " &
            " IsInsert=" & If(Convert.ToBoolean(dt.Rows(i)("IsView")) = True, 1, 0) & ", IsUpdate=" & If(Convert.ToBoolean(dt.Rows(i)("IsView")) = True, 1, 0) & " , IsDelete = " & If(Convert.ToBoolean(dt.Rows(i)("IsView")) = True, 1, 0) & ", " &
            " IsBackdate = " & If(Convert.ToBoolean(dt.Rows(i)("IsView")) = True, 1, 0) & ", IsPrint = " & If(Convert.ToBoolean(dt.Rows(i)("IsView")) = True, 1, 0) & ",  UpdatedDate=getdate()  " &
            " where  PageID = " & dt.Rows(i)("VID").ToString() & " and RoleID = " & cmbGroup.SelectedValue.ToString & " "
                objCommon.ExecuteNonQuery(qryMain)
         Else
                'qryMain = " insert into tblSecPageGroup (GroupID,PageID,Isactive,IsView,IsInsert,IsUpdate,IsDelete,IsBackdate,IsPrint,UID,Tranzdatetime,CompCode) " & _
                '" values(" & cmbGroup.SelectedValue.ToString & "," & dt.Rows(i)("VID") & "," & IIf(dt.Rows(i)("Isactive") = True, 1, 0) & "," & IIf(dt.Rows(i)("IsView") = True, 1, 0) & ", " & _
                '" " & IIf(dt.Rows(i)("IsInsert") = True, 1, 0) & "," & IIf(dt.Rows(i)("IsUpdate") = True, 1, 0) & "," & IIf(dt.Rows(i)("IsDelete") = True, 1, 0) & ", " & _
                '" " & IIf(dt.Rows(i)("IsBackdate") = True, 1, 0) & "," & IIf(dt.Rows(i)("IsPrint") = True, 1, 0) & "," & G_UID & ",getdate()," & G_Compcode & "); select @@identity as VID ; "
                qryMain = " insert into SecRolePage (RoleID,PageID,Isactive,IsView,IsInsert,IsUpdate,IsDelete,IsBackdate,IsPrint,InsertedBy,InsertedDate) " &
            " values(" & cmbGroup.SelectedValue.ToString & "," & dt.Rows(i)("VID").ToString() & "," & If(Convert.ToBoolean(dt.Rows(i)("IsView")) = True, 1, 0) & "," & If(Convert.ToBoolean(dt.Rows(i)("IsView")) = True, 1, 0) & ", " &
            " " & If(Convert.ToBoolean(dt.Rows(i)("IsView")) = True, 1, 0) & "," & If(Convert.ToBoolean(dt.Rows(i)("IsView")) = True, 1, 0) & "," & If(Convert.ToBoolean(dt.Rows(i)("IsView")) = True, 1, 0) & ", " &
            " " & If(Convert.ToBoolean(dt.Rows(i)("IsView")) = True, 1, 0) & "," & If(Convert.ToBoolean(dt.Rows(i)("IsView")) = True, 1, 0) & "," & G_UID & ",getdate()); select @@identity as VID ; "
                qryMain = objCommon.ExecuteScalar(qryMain)
         End If
        Next
        'txtID.Text = Setint(qryMain)
        'End If
        'FillGrid()
        lblInformation.Text = "Record Saved."
        'txtVName.Focus()
    End Sub
    Private Sub cmdDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDelete.Click

    End Sub

    'Private Sub kryptongrdRecord_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles grdRecord.MouseClick
    '    Dim MYID As Integer = grdRecord.Rows(grdRecord.CurrentCell.RowIndex).Cells(0).Value
    '    txtID.Text = MYID
    '    FillForm()
    '    ' txtVName.Focus()
    'End Sub

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub


    Private Sub cmbGroup_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbGroup.SelectedIndexChanged
        FillGrid()
    End Sub
End Class