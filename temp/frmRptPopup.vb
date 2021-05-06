'Public Class frmRptPopup
'    Public PFrmType As String = ""
'    Public Ptable As String = ""
'    Public PValues As String = "" 
'   Dim strViewEmployee As String
'#Region "Form Load"
'   Private Sub frmAttendance_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
'      Ptable = Ptable.Trim
'      If Ptable = "Department" Then
'         qryMain = "SELECT VID, VName from ( SELECT VID, VName From tblSetupDept ) aa "
'      ElseIf Ptable = "Designation" Then
'         qryMain = "SELECT VID, VName from ( SELECT VID, VName From tblSetupDesg ) aa "
'      ElseIf Ptable = "Gender" Then
'         qryMain = "SELECT VID, VName from ( SELECT 'MALE' as VID,'MALE' as VName union all SELECT 'FEMALE' as VID,'FEMALE' as VName union all SELECT 'GIRL' as VID,'GIRL' as VName ) aa "
'      ElseIf Ptable = "Status" Then
'         qryMain = "SELECT 1 as VID,'ON ROLL' as VName union all SELECT 0 as VID,'RESIGNED' as VName  union all SELECT 2 as VID,'Terminate' as VName  union all SELECT 3 as VID,'NSO' as VName"
'         qryMain = "SELECT VID, VName from ( " & qryMain & " ) aa "
'      ElseIf Ptable = "HaveOT" Then
'         qryMain = "SELECT VID, VName from ( SELECT 1 as VID,'YES' as VName union all SELECT 0 as VID,'NO' as VName ) aa "
'      ElseIf Ptable = "Special" Then
'         qryMain = "SELECT VID, VName from ( SELECT 1 as VID,'TOTAL OT' as VName union all " & _
'                  " SELECT 2 as VID,'At Least PP' as VName union all SELECT 3 as VID,'Total OT with At Least PP' as VName union all SELECT 4 as VID,'ON SHIFT' as VName ) aa "
'      ElseIf Ptable = "Manager" Then
'         qryMain = "SELECT VID, VName from ( SELECT 1 as VID,'YES' as VName union all SELECT 0 as VID,'NO' as VName ) aa "
'      ElseIf Ptable = "Religion" Then
'         qryMain = "SELECT VID, VName from ( SELECT 0 as VID,'Muslim' as VName union all SELECT 1 as VID,'Cristian' as VName union all SELECT 3 as VID,'OTHER' as VName ) aa "
'      ElseIf Ptable = "Shift" Then
'         qryMain = "SELECT VID, VName from ( SELECT 0 as VID,'NO' as VName union all SELECT 1 as VID,'YES' as VName) aa "
'      ElseIf Ptable = "ProbitionStatus" Then
'         qryMain = "SELECT VID, VName from ( SELECT 'PROBITION' as VID,'PROBITION' as VName union all SELECT 'PERMANENT' as VID,'PERMANENT' as VName) aa "
'      Else
'         qryMain = "SELECT VID, VName from ( SELECT '-1' as VID,'--- Select ---' as VName ) aa "
'      End If
'      If PValues.Trim = "" Then PValues = "'-1'"
'      qryMain = qryMain & " order by VName "
'      FillGrid()
'   End Sub
'#End Region
'   Private Sub cmdOk_Click(sender As System.Object, e As System.EventArgs) Handles cmdOk.Click
'      Dim myids As String
'      'If ListView1.CheckedItems.Count <= 0 Then
'      '    PForm.txtDepartment.Text = ""
'      '    Return
'      'End If
'      myids = "'-1'"
'      If ListView1.CheckedItems.Count > 0 Then
'         For i As Integer = 0 To ListView1.CheckedItems.Count - 1
'            myids = myids & ",'" & ListView1.CheckedItems(i).SubItems(1).Text & "'"
'         Next
'      End If
'      'If Ptable = "Department" Then
'      '    If PFrmType = "frmRptAttDaily" Then
'      '        PFormAtt.txtDepartment.Text = myids
'      '    ElseIf PFrmType = "frmRptAttMonthly" Then
'      '        PFormAttM.txtDepartment.Text = myids
'      '    Else
'      '        PForm.txtDepartment.Text = myids
'      '    End If
'      'ElseIf Ptable = "Designation" Then
'      '    PForm.txtDesignation.Text = myids
'      'ElseIf Ptable = "Gender" Then
'      '    PForm.txtGender.Text = myids
'      'ElseIf Ptable = "Status" Then
'      '    PForm.txtStatus.Text = myids
'      'ElseIf Ptable = "HaveOT" Then
'      '    myids = myids.Replace("'-1',", "")
'      '    PForm.txtHaveOT.Text = myids
'      'ElseIf Ptable = "Special" Then
'      '    myids = myids.Replace("'-1',", "")
'      '    PForm.txtSpecial.Text = myids
'      'ElseIf Ptable = "Manager" Then
'      '    myids = myids.Replace("'-1',", "")
'      '    PForm.txtManager.Text = myids
'      'ElseIf Ptable = "Religion" Then
'      '    myids = myids.Replace("'-1',", "")
'      '    PForm.txtReligion.Text = myids
'      'ElseIf Ptable = "Shift" Then
'      '    myids = myids.Replace("'-1',", "")
'      '    PForm.txtShift.Text = myids
'      'End If

'      Me.Close()
'   End Sub
'   Private Sub cmdClose_Click(sender As System.Object, e As System.EventArgs) Handles cmdClose.Click
'      Me.Close()
'   End Sub
'   Private Function FillGrid() As Boolean
'      ListView1.Items.Clear()
'      'Dim dt As DataTable = objCommon.GetDataTable(qryMain)
'      If dt.Rows.Count > 0 Then
'         Dim items As New List(Of ListViewItem)
'         For Each dr As DataRow In dt.Rows
'            Dim item As New ListViewItem
'            item.Text = dr(1)
'            item.SubItems.Add(dr(0))
'            items.Add(item)
'         Next
'         ListView1.Items.AddRange(items.ToArray())
'      End If
'      PValues = "," & PValues & ","

'      For Each a As ListViewItem In ListView1.Items
'         If InStr(PValues.Replace("'", ""), "," & a.SubItems(1).Text & ",") Then
'            a.Checked = True
'            'else
'            '   a.Selected = False
'         End If
'      Next

'      Return True
'   End Function
'End Class