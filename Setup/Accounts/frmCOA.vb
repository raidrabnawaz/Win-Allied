Imports System.Collections.Specialized
Imports System.Data
Imports System.Data.SqlClient
Imports Excel = Microsoft.Office.Interop.Excel

Public Class frmCOA
    Dim qryMain,tempCode As String
    Dim objCommon As New clsCommon
    Dim dtTree As DataTable
    Dim _selectedNode As TreeNode
    Dim MyListDic As New ListDictionary

   Private Sub frmAttCode_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
      G_CURRENTDATE = Date.Now
      If G_CURRENTDATE > G_SOFTENDDATE Then
         End
      End If

      txtID.Text = ""
      ClearHead("")
      objCommon.FillAccountGroup(Me.cmbAccGroup)
      objCommon.FillAccountType(Me.cmbAccType)
      FillTree()
      txtVName.Focus()
   End Sub
    Private Sub ClearHead(ByVal myid As String)
        'If myid = "" Then
        ''do not change txtID.Text 
        'Else
      txtID.Text = myid
      tempCode = ""
        'End If
        'txtID.Text = myAcc
        cmbAccGroup.SelectedIndex = -1
        cmbAccType.SelectedIndex = -1
        txtVName.Text = ""
        lblInformation.Text = ""
        txtVName.Text = ""
        chkIsBank.Checked = False
        chkControlAccount.Checked = False
        chkStopTrans.Checked = False
        chkAllowBackdate.Checked = True
        chkAllowWithBank.Checked = False
    End Sub
    Private Sub FillTree()
        'grdRecord.DataSource = Nothing

        TrvPage.Nodes.Clear()

        'qryMain = " SELECT D.VID, D.HID, H.VName AS HName, D.VName " &
        '" FROM dbo.tblCoaD AS D INNER JOIN dbo.tblCoaH AS H ON D.HID = H.VID ORDER BY D.VID "


        '        qryMain = " select VCode, VName, ParentCode from ( " &
        '" select L1Code as VCode, VName,'0' as ParentCode  from tblAcSetupCOAL1 " &
        '" union all " &
        '" select L2Code, VName,L1Code as ParentCode  from tblAcSetupCOAL2 " &
        '" union all " &
        '" select VCode , VName,L2Code as ParentCode  from tblAcSetupCOA " &
        '" ) bb  order by ParentCode, VCode "

        qryMain = " SELECT VID, VCode, VName, ParentID ParentCode FROM AccAccountCOA WHERE CompanyID =  " & G_Compcode


        dtTree = objCommon.GetDataTable(qryMain)
        If IsNothing(dtTree) Then
            'EmptyFields()
            Return
        End If
        If dtTree.Rows.Count <= 0 Then
            'EmptyFields()
            Return
        End If
        PopulateTreeView("0", Nothing)
    End Sub ' Pending
    Private Sub PopulateTreeView(ByVal parentId As String, ByVal parentNode As TreeNode)
        Dim childNode As TreeNode
        Dim dv As DataView
        dv = New DataView(dtTree)
        'If parentId <> 0 Then
        dv.RowFilter = " ParentCode = '" & parentId & "' "
        'End If


        For Each dr As DataRowView In dv
            Dim t As TreeNode = New TreeNode()
            t.Text = dr("VCode").ToString() & " - " + dr("VName").ToString()
            t.Name = dr("VCode").ToString()
            t.Tag = dr("VID").ToString() 'dtTree.Rows.IndexOf(dr)

            If parentNode Is Nothing Then
                TrvPage.Nodes.Add(t)
                childNode = t
            Else
                parentNode.Nodes.Add(t)
                childNode = t
            End If

            'PopulateTreeView(dr("VCode").ToString().Trim, childNode)
            PopulateTreeView(dr("VID").ToString().Trim, childNode)
        Next


        'For Each dr As DataRow In dtTree.[Select]("[ParentCode]=" & parentId)
        '    Dim t As TreeNode = New TreeNode()
        '    t.Text = dr("VCode").ToString() & " - " + dr("VName").ToString()
        '    t.Name = dr("VCode").ToString()
        '    t.Tag = dtTree.Rows.IndexOf(dr)

        '    If parentNode Is Nothing Then
        '        TrvPage.Nodes.Add(t)
        '        childNode = t
        '    Else
        '        parentNode.Nodes.Add(t)
        '        childNode = t
        '    End If

        '    PopulateTreeView(dr("VCode").ToString().Trim, childNode)
        'Next
    End Sub
    Private Sub FillForm()
        lblInformation.Text = ""
        If txtID.Text = "" Then
            ClearHead("")
            Return
        End If
        Dim ID As String = lblVID.Text
        txtAccountID.Text = ID.Split("-")(0)
        txtAccID.Text = ID.Split("-")(0)
        qryMain = "EXEC SpGetAccAccountCOAByVID " & lblVID.Text & "," & G_Compcode & " "
        Dim dt As DataTable = objCommon.GetDataTable(qryMain)
        If IsNothing(dt) Then
            'EmptyFields()
            Return
        End If
        If dt.Rows.Count <= 0 Then
            'EmptyFields()
            Return
        End If
        Dim dr As DataRow = dt.Rows(0)
        cmbAccGroup.SelectedIndex = dr("AccountGroupID")
        cmbGroupL1_SelectedIndexChanged(Nothing, Nothing)
        cmbAccType.SelectedIndex = dr("AccountTypeID")
        txtVName.Text = dr("VName")
        txtControlAccountID.Text = dr("ParentID")
        'chkIsBank.Checked = IIf(dr("IsAllowTranzBank") = 1, True, False)
        'chkControlAccount.Checked = IIf(dr("IsControlAccount") = 1, True, False)
        'chkStopTrans.Checked = If(dr("IsDisAllowTranz") = 1, True, False)
        'chkAllowBackdate.Checked = IIf(dr("AllowBackDate") = 1, True, False)

        If (dr("IsAllowTranzBank") = 0) Then
            chkAllowWithBank.Checked = False
        Else
            chkAllowWithBank.Checked = True
        End If
        If (dr("IsDisAllowTranz") = 0) Then
            chkStopTrans.Checked = False
        Else
            chkStopTrans.Checked = True
        End If
        If (dr("IsAnalysis") = 0) Then
            ChkIsAnalysis.Checked = False
        Else
            ChkIsAnalysis.Checked = True
        End If
        If (dr("Employee") = 0) Then
            ChkEmployee.Checked = False
        Else
            ChkEmployee.Checked = True
        End If
        If (dr("Customer") = 0) Then
            ChkCustomer.Checked = False
        Else
            ChkCustomer.Checked = True
        End If
        If (dr("Supplier") = 0) Then
            ChkSupplier.Checked = False
        Else
            ChkSupplier.Checked = True
        End If
        If (dr("CostCenter") = 0) Then
            ChkCostCenter.Checked = False
        Else
            ChkCostCenter.Checked = True
        End If
        If (dr("LCCode") = 0) Then
            ChkLCCode.Checked = False
        Else
            ChkLCCode.Checked = True
        End If
        If (dr("WorkOrder") = 0) Then
            ChkWorkOrder.Checked = False
        Else
            ChkWorkOrder.Checked = True
        End If
    End Sub
    Private Sub cmdNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNew.Click
        ClearHead("")
        txtVName.Focus()
    End Sub
    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        lblInformation.Text = ""
        'varify for empty string
        'varify already existance
      txtVName.Text = txtVName.Text.Trim.Replace("'", "")
        If txtVName.Text = "" Then
            MessageBox.Show("Please give some Name.", G_APP_TITLE)
            txtVName.Focus()
            Return
        End If
        If cmbAccGroup.SelectedValue <= 0 Then
            MessageBox.Show("Please select account group .", G_APP_TITLE)
            cmbAccGroup.Focus()
            Return
        End If
        If cmbAccType.SelectedValue <= 0 Then
            MessageBox.Show("Please select account Head.", G_APP_TITLE)
            cmbAccType.Focus()
            Return
        End If
        If (String.IsNullOrEmpty(txtAccountID.Text)) Then
            lblVID.Text = 0
        Else
            lblVID.Text = Convert.ToInt32(txtAccountID.Text)
        End If


        Dim LvlNo As Int16 = 0
        Dim isControl As Int16 = 1

        If (txtID.Text.Length = 15) Then
            LvlNo = 4
            isControl = 0
        ElseIf (txtID.Text.Length = 10) Then
            LvlNo = 3
            isControl = 1
        ElseIf (txtID.Text.Length = 6) Then
            LvlNo = 2
            isControl = 1
        ElseIf (txtID.Text.Length = 2) Then
            LvlNo = 1
            isControl = 1
        ElseIf (LvlNo = 0) Then
            Return
        End If

        If (hfType.Text = "Sibbling") Then
            txtParentID.Text = Convert.ToInt32(txtControlAccountID.Text)
        ElseIf (hfType.Text = "Child") Then
            txtParentID.Text = Convert.ToInt32(txtAccID.Text)
        Else
            txtParentID.Text = Convert.ToInt32(txtControlAccountID.Text)
        End If


        qryMain = "EXEC SpAccAccountCOAInsretUpdate '" & lblVID.Text & "','" & txtID.Text & "','" & txtVName.Text & "'," & txtParentID.Text & "," & isControl & "," & chkStopTrans.Checked & "," & False & "," & chkAllowWithBank.Checked & "," & cmbAccGroup.SelectedIndex & "," & cmbAccType.SelectedIndex & "," & LvlNo & "," & False & "," & ChkIsAnalysis.Checked & "," & ChkEmployee.Checked & "," & ChkCustomer.Checked & "," & ChkSupplier.Checked & "," & ChkCostCenter.Checked & "," & ChkLCCode.Checked & "," & ChkWorkOrder.Checked & "," & G_Compcode & "," & G_FinancialYearID & "," & True & "," & G_UID & ",'" & G_IPAddress & "'," & G_UID & ",'" & G_IPAddress & "'"
        qryMain = objCommon.ExecuteScalar(qryMain)
        'If qryMain = 0 Then
        '    MessageBox.Show("Account already exists.", G_APP_TITLE)
        '    Return
        'End If
        FillTree()



        'If txtID.Text <> "" Then 'update
        '    qryMain = " update tblAcSetupCOA set VName='" & txtVName.Text & "', UID= " & G_UID & ", Tranzdatetime=getdate() where VCode = '" & txtID.Text & "'; "
        '    objCommon.ExecuteNonQuery(qryMain)
        'Else
        '    Dim strcode As String
        '    strcode = objCommon.ExecuteScalar("select isnull(max(cast(VCode as int)),0) + 1  as VCode from tblAcSetupCOA where L2Code = '" & cmbAccType.SelectedValue & "'; ")
        '    strcode = Double.Parse(strcode).ToString("0000000")
        '    strcode = cmbAccType.SelectedValue & strcode.Substring(4, 3)
        '    qryMain = "insert into tblAcSetupCOA (VCode, VName, L1Code, L2Code, OpeningDr, OpeningCr, IsBank, IsControlAccount, StopTransaction, AllowBackDate, AllowWithBank, Remarks, UID, Tranzdatetime, OldCode ) values('" &
        '    strcode & "','" & txtVName.Text & "','" & cmbAccGroup.SelectedValue & "','" & cmbAccType.SelectedValue & "',0,0," & IIf(chkIsBank.Checked, 1, 0) & "," & IIf(chkControlAccount.Checked, 1, 0) & "," & IIf(chkStopTrans.Checked, 1, 0) & "," & IIf(chkAllowBackdate.Checked, 1, 0) & "," & IIf(chkAllowWithBank.Checked, 1, 0) & ",''," & G_UID & ", getdate(),'' );  "

        'qryMain = "EXEC SpAccAccountCOAInsretUpdate '" & lblVID.Text & "'," & txtID.Text & "," & txtVName.Text & "," &  & " "
      objCommon.ExecuteNonQuery(qryMain)
      tempCode = txtID.Text
        'End If
        ClearHead("")
        FillTree()
      lblInformation.Text = "Record Saved(" & tempCode & ")"
        txtVName.Focus()
    End Sub
    Private Sub cmdEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEdit.Click
        FillForm()
        txtVName.Focus()
    End Sub
    Private Sub cmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancel.Click
        ClearHead("")
        txtVName.Focus()
    End Sub
    Private Sub cmdDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDelete.Click

    End Sub
    Private Sub cmbGroupL1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbAccGroup.SelectedIndexChanged
        If IsNothing(cmbAccGroup.SelectedValue) Then
            Return
        End If
        If cmbAccGroup.SelectedValue.ToString <> "System.Data.DataRowView" Then
            'objCommon.FillAcSetupCOAL2(cmbAccType, cmbAccGroup.SelectedValue)
        End If

    End Sub

    Private Sub TrvPage_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TrvPage.DoubleClick
        _selectedNode = TrvPage.SelectedNode
        ShowNodeData(_selectedNode)

    End Sub
    Private Sub ShowNodeData(ByVal nod As TreeNode)
        txtID.Text = nod.Name.Trim
        lblVID.Text = nod.Tag.ToString
        'If txtID.Text.Length = 15 Then
        FillForm()
        'Else
        'ClearHead("")
        'End If
    End Sub

    Private Sub TrvPage_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TrvPage.KeyUp
        If e.KeyCode = Keys.Enter Then
            _selectedNode = TrvPage.SelectedNode
            ShowNodeData(_selectedNode)
        End If
    End Sub

   Private Sub btnChild_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnChild.Click
      If txtID.Text = "" Then
         MessageBox.Show("Please select some Head first to create it's Child", G_APP_TITLE)
         Return
      End If
      Dim myAcc As String = ""
      MyListDic.Clear()
      MyListDic.Add("@VCode", txtID.Text)
      MyListDic.Add("@CompanyID", G_Compcode)
      If (txtID.TextLength >= 15) Then
         MessageBox.Show("Transection Level has no Child", G_APP_TITLE)
         Return
      End If

      If (txtID.Text <> "") Then
         Dim dt As DataTable = objCommon.GetDataTableSPCOA("SPGetAccAccountCOACode", MyListDic)
         myAcc = dt.Rows(0)(0)
      End If

      Dim count As Int16 = myAcc.Count()

      If (count > 15) Then
         MessageBox.Show("Transection Level has no Child", G_APP_TITLE)
         Return
      ElseIf (count = 0) Then
         MessageBox.Show("Transection Level doesn't Exist", G_APP_TITLE)
         Return
      End If
      txtID.Text = myAcc
      cmbAccGroup.SelectedIndex = -1
      cmbAccType.SelectedIndex = -1
      txtVName.Text = ""
      chkAllowWithBank.Checked = False
      chkStopTrans.Checked = False
      hfType.Text = "Child"
      txtAccountID.Text = ""

   End Sub

   Private Sub btnSibling_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSibling.Click
      If txtID.Text = "" Then
         MessageBox.Show("Please select some Head first to create it's Sibling", G_APP_TITLE)
         Return
      End If
      MyListDic.Clear()
      MyListDic.Add("@VCode", txtID.Text)
      MyListDic.Add("@CompanyID", G_Compcode)
      Dim dt As DataTable = objCommon.GetDataTableSPCOA("SPGetAccAccountCOACodeSub", MyListDic)
      Dim myAcc As String = dt.Rows(0)(0)

      txtID.Text = myAcc
      cmbAccGroup.SelectedIndex = -1
      cmbAccType.SelectedIndex = -1
      txtVName.Text = ""
      chkAllowWithBank.Checked = False
      chkStopTrans.Checked = False
      hfType.Text = "Sibbling"
      txtAccountID.Text = ""
   End Sub

   Private Sub cmdSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSearch.Click
      frmLookupCOA.ETypeID = "COA"
      'frmLookupCOA.VCodeIni = txtAccountHead.Text.Trim
      'frmLookupCOA.VID = lblVID.Text.Trim
      'frmLookupCOA.VType = VType
      frmLookupCOA.ShowDialog()
      If frmLookupCOA.VCode <> "" Then
         lblVID.Text = frmLookupCOA.VID
         txtID.Text = frmLookupCOA.VCode
         'lblAccountTitle.Text = frmLookupCOA.VName
         frmLookupCOA.Dispose()
         FillForm()
         txtID.Focus()
      End If

   End Sub

   Private Sub cmdPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrint.Click

      qryMain = "EXEC SpGetAccAccountCOA  " & G_Compcode & ""
      Dim dt As DataTable = objCommon.GetDataTable(qryMain)
      grdAtt.DataSource = dt
      objCommon.ExportToExcel(grdAtt)
   End Sub

    Private Sub SplitContainer1_Panel2_Paint(sender As Object, e As PaintEventArgs) Handles SplitContainer1.Panel2.Paint

    End Sub

    Private Sub releaseObject(ByVal obj As Object)
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
        Finally
            GC.Collect()
        End Try
    End Sub


End Class