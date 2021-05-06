Public Class frmLookupOperations
    Dim objCommon As New clsCommon
    Dim dt As New DataTable
    Dim dv As DataView
    Public VID, VCode, VName, UOMID, LookupName, LookupQuery, Qty, IsAccessory, LeadTime, ExcessPer, OrderNo, OrderID, DepartmentID, SupplierID As String

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        FillDt()
        FillGrid()
    End Sub

    Public SetTypeID As Int32
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            Dim issaved As Int32 = 0
            For Each grid As DataGridViewRow In grdRecordLookup.Rows
                If DBNull.Value.Equals(grid.Cells("IsSaved").Value) Then
                    issaved = 0
                Else
                    issaved = grid.Cells("IsSaved").Value
                End If
                If grid.Cells("VID").Value > 0 And issaved > 0 Then


                ElseIf grid.Cells("VID").Value = 0 And issaved = 0 Then
                    'DataGridViewCheckBoxCell CbxCell = row.Cells[1] as DataGridViewCheckBoxCell;
                    'If (grid.Cells("IsSaved").Value IsNot Nothing And Not DBNull.Value.Equals(grid.Cells("IsSaved").Value) And grid.Cells("VID").Value = 0) Then
                    '{
                    '    gdPractical.Rows.Add(CbxCell.Value.ToString());
                    '}
                Else
                    qryMain = "EXEC SpSave_ProdOperationSet " & grid.Cells("VID").Value & ",0, " & SetTypeID & " ," & grid.Cells("OperationID").Value & "," & IIf(issaved = 0, 0, 1) & "," & G_Compcode & ",1," & G_UID & ",'" & G_IPAddress & "'," & G_UID & ",'" & G_IPAddress & "'"
                    objCommon.ExecuteNonQuery(qryMain)
                End If

            Next



        Catch ex As Exception
            MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Me.Close()
        End Try

    End Sub

    Private Sub frmLookupOperations_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        objCommon.FillProdOperationCategory(Me.cmbCategory)
        cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown
        cmbCategory.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        cmbCategory.AutoCompleteSource = AutoCompleteSource.ListItems
        Me.Text = LookupName
        FillHeader()
        btnSearch_Click(sender, e)
    End Sub
    Private Sub FillGrid()
        dv = New DataView(dt)

        grdRecordLookup.DataSource = dv

    End Sub
    Private Sub FillDt()
        dt = Nothing
        qryMain = LookupQuery + "," + cmbCategory.SelectedValue.ToString
        dt = objCommon.GetDataTable(qryMain)
    End Sub
    Private Sub FillHeader()
        grdRecordLookup.DataSource = Nothing
        grdRecordLookup.Rows.Clear()
        grdRecordLookup.Columns.Clear()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim grdcol0 As System.Windows.Forms.DataGridViewCheckBoxColumn
        Dim grdcol1 As System.Windows.Forms.DataGridViewTextBoxColumn
        Dim grdcol2 As System.Windows.Forms.DataGridViewTextBoxColumn
        Dim grdcol3 As System.Windows.Forms.DataGridViewTextBoxColumn
        Dim grdcol4 As System.Windows.Forms.DataGridViewTextBoxColumn
        Dim grdcol5 As System.Windows.Forms.DataGridViewTextBoxColumn
        Dim grdcol6 As System.Windows.Forms.DataGridViewTextBoxColumn
        Dim grdcol7 As System.Windows.Forms.DataGridViewTextBoxColumn
        Dim grdcol8 As System.Windows.Forms.DataGridViewTextBoxColumn

        grdcol0 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        grdcol1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        grdcol2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        grdcol3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        grdcol4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        grdcol5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        grdcol6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        grdcol7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        grdcol8 = New System.Windows.Forms.DataGridViewTextBoxColumn()

        grdcol0.DataPropertyName = "IsSaved"
        grdcol0.HeaderText = "Select"
        grdcol0.Name = "IsSaved"
        grdcol0.ReadOnly = False
        grdcol0.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        '
        grdcol1.DataPropertyName = "VID"
        grdcol1.HeaderText = "VID"
        grdcol1.Name = "VID"
        grdcol1.Visible = False

        grdcol2.DataPropertyName = "SrlNo"
        grdcol2.HeaderText = "Srl No"
        grdcol2.Name = "grdcol2"
        grdcol2.Width = 100
        grdcol2.ReadOnly = True
        grdcol2.Visible = False
        '
        'grdcol1
        's

        grdcol3.DataPropertyName = "SetTypeID"
        grdcol3.HeaderText = "Item"
        grdcol3.Name = "SetTypeID"
        grdcol3.Width = 400
        grdcol3.Visible = False

        grdcol4.DataPropertyName = "SetTypeName"
        grdcol4.HeaderText = "Item"
        grdcol4.Name = "grdcol4"
        grdcol4.Width = 400
        grdcol4.ReadOnly = True
        grdcol4.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells

        grdcol5.DataPropertyName = "Category"
        grdcol5.HeaderText = "Category"
        grdcol5.Name = "grdcol5"
        grdcol5.Width = 100
        grdcol5.ReadOnly = True
        grdcol5.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells

        grdcol6.DataPropertyName = "OperationID"
        grdcol6.HeaderText = "Operation"
        grdcol6.Name = "OperationID"
        grdcol6.Width = 100
        grdcol6.Visible = False

        grdcol7.DataPropertyName = "OperationName"
        grdcol7.HeaderText = "Operation"
        grdcol7.Name = "grdcol6"
        grdcol7.Width = 100
        grdcol7.ReadOnly = True
        grdcol7.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill

        grdcol8.DataPropertyName = "Rate"
        grdcol8.HeaderText = "Rate"
        grdcol8.Name = "grdcol8"
        grdcol8.Visible = False





        Me.grdRecordLookup.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {grdcol0, grdcol1, grdcol2, grdcol3, grdcol4, grdcol5, grdcol6, grdcol7, grdcol8})
    End Sub

End Class