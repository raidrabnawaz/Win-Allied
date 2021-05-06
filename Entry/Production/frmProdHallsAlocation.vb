Public Class frmProdHallsAlocation
    Dim qryMain As String
    Dim qry As String
    Dim totalQty As Double = 0
    Dim objCommon As New clsCommon
    Private Sub ProdCutting_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        G_CURRENTDATE = Date.Now
        If G_CURRENTDATE > G_SOFTENDDATE Then
            End
        End If

        txtID.Text = ""
        objCommon.FillProdSaleOrder(Me.cmbSaleOrder)
        objCommon.FillProdFormType(Me.cmbFormType)
        objCommon.FillProdHalls(Me.cmbHalls)
        ClearHead("")
        FillHeader()
        'FillGrid()
        txtID.Focus()
        dtpVdate.Value = DateTime.Now()


    End Sub

    Private Sub FillHeader()
        'grdRecord.DataSource = Nothing
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim grdcol0 As System.Windows.Forms.DataGridViewTextBoxColumn
        Dim grdcol1 As System.Windows.Forms.DataGridViewTextBoxColumn
        Dim grdcol2 As System.Windows.Forms.DataGridViewTextBoxColumn
        Dim grdcol3 As System.Windows.Forms.DataGridViewTextBoxColumn
        Dim grdcol4 As System.Windows.Forms.DataGridViewTextBoxColumn
        Dim grdcol5 As System.Windows.Forms.DataGridViewTextBoxColumn
        Dim grdcol6 As System.Windows.Forms.DataGridViewTextBoxColumn
        Dim grdcol7 As System.Windows.Forms.DataGridViewTextBoxColumn

        grdcol0 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        grdcol1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        grdcol2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        grdcol3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        grdcol4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        grdcol5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        grdcol6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        grdcol7 = New System.Windows.Forms.DataGridViewTextBoxColumn()

        grdcol0.DataPropertyName = "VID"
        grdcol0.HeaderText = "VID"
        grdcol0.Name = "grdcol0"
        grdcol0.Visible = False
        '
        'grdcol1
        's

        grdcol1.DataPropertyName = "SrlNO"
        grdcol1.HeaderText = "Srl No"
        grdcol1.Name = "grdcol1"
        grdcol1.Width = 100
        grdcol1.Visible = False

        grdcol2.DataPropertyName = "OrderID"
        grdcol2.HeaderText = "Sale Order Id"
        grdcol2.Name = "grdcol2"
        grdcol2.Visible = False


        grdcol3.DataPropertyName = "OrderName"
        grdcol3.HeaderText = "Sale Order"
        grdcol3.Name = "grdcol3"
        grdcol3.Width = 300

        grdcol4.DataPropertyName = "HallID"
        grdcol4.HeaderText = "HallID"
        grdcol4.Name = "grdcol4"
        grdcol4.Visible = False

        grdcol5.DataPropertyName = "HallName"
        grdcol5.HeaderText = "Hall"
        grdcol5.Name = "grdcol5"
        grdcol5.Width = 100

        grdcol6.DataPropertyName = "Quantity"
        grdcol6.HeaderText = "PCs/Qty"
        grdcol6.Name = "Quantity"
        grdcol6.Width = 100



        grdcol7.DataPropertyName = "VDate"
        grdcol7.HeaderText = "Date"
        grdcol7.Name = "grdcol7"
        grdcol7.Width = 100

        Me.grdRecord.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {grdcol0, grdcol1, grdcol7, grdcol2, grdcol3, grdcol4, grdcol5, grdcol6})

    End Sub

    Private Sub FillGrid()
        grdRecord.DataSource = Nothing
        grdRecord.Rows.Clear()
        grdRecord.Columns.Clear()
        FillHeader()
        qryMain = "EXEC SpGet_ProdHallsAllocation " & cmbSaleOrder.SelectedValue.ToString & ", " & cmbFormType.SelectedValue.ToString & ""
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

    Private Sub ClearHead(ByVal v As String)
        'If myid = "" Then
        ''do not change txtID.Text 
        'Else
        txtID.Text = ""
        cmbSaleOrder.SelectedIndex = 0
        txtQty.Text = ""
        cmbHalls.SelectedIndex = 0
        'End If
        lblInformation.Text = ""
        txtQty.Text = ""
        txtSrlNo.Text = ""
        dtpVdate.Value = DateTime.Now()
    End Sub

    Private Sub grdRecord_MouseClick(ByVal sender As Object, ByVal e As MouseEventArgs) Handles grdRecord.MouseClick
        Dim MYID As String = grdRecord.Rows(grdRecord.CurrentCell.RowIndex).Cells(0).Value
        txtID.Text = MYID
        FillForm()
        cmbSaleOrder.Focus()
    End Sub

    Private Sub FillForm()
        lblInformation.Text = ""
        If txtID.Text = "" Then
            ClearHead("")
            Return
        End If
        qryMain = "EXEC SpGetbyID_ProdHallsAllocation'" & txtID.Text & "' "
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
        cmbSaleOrder.SelectedValue = dr("OrderID")
        cmbHalls.SelectedValue = dr("HallID")
        txtQty.Text = dr("Quantity")
        txtSrlNo.Text = dr("SrlNo")
        dtpVdate.Text = dr("VDate")

    End Sub

    Private Sub cmdNew_Click(ByVal sender As Object, ByVal e As EventArgs) Handles cmdNew.Click
    End Sub

    Private Sub cmdSave_Click(ByVal sender As Object, ByVal e As EventArgs) Handles cmdSave.Click

    End Sub

    Private Sub btnAdd_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnAdd.Click
        lblInformation.Text = ""
        'varify for empty string
        'varify already existance
        If cmbSaleOrder.Text = "" Then
            MessageBox.Show("Please give some Sale Order.", G_APP_TITLE)
            cmbSaleOrder.Focus()
            Return
        End If
        If cmbHalls.Text = "" Then
            MessageBox.Show("Please give some Size.", G_APP_TITLE)
            cmbHalls.Focus()
            Return
        End If
        If txtQty.Text = "" Then
            MessageBox.Show("Please give some Quantity.", G_APP_TITLE)
            txtQty.Focus()
            Return
        End If
        'qryMain = " Select top 1 isnull(L1Code,'') as L1Code from tblAcSetupCOAL1 where L1Code <> '" & txtID.Text & "' and VName='" & txtVName.Text & "'; "
        'qryMain = objCommon.ExecuteScalar(qryMain)
        'If qryMain <> "" Then
        '    MessageBox.Show("Account already exists.", G_APP_TITLE)
        '    Return
        'End If

        If txtID.Text Is "" Then 'update
            txtID.Text = 0                  '    qryMain = " update tblAcSetupCOAL1 set VName='" & txtVName.Text & "',GID='" & cmbGroup.SelectedValue & "' where L1Code = '" & txtID.Text & "'; "
        End If                   '    objCommon.ExecuteNonQuery(qryMain)
        'Else
        '    Dim strcode As String
        '    strcode = objCommon.ExecuteScalar("select isnull(max(cast(L1Code as int)),0) + 1 as L1Code from tblAcSetupCOAL1 where GID = " & cmbGroup.SelectedValue)
        '    strcode = Double.Parse(strcode).ToString("00")
        '    qryMain = "insert into tblAcSetupCOAL1 (L1Code, GID, VName, OldCode) values('" &
        '    strcode & "'," & cmbGroup.SelectedValue & ",'" & txtVName.Text & "','' );  "

        If txtSrlNo.Text = "" Then
            txtSrlNo.Text = 0
        End If
        qryMain = "EXEC SpSave_ProdHallsAllocation " & txtID.Text & "," & txtSrlNo.Text & ", '001' ,'" & CDate(dtpVdate.Value).ToString("dd/MMM/yyyy") & "'," & cmbSaleOrder.SelectedValue & "," & cmbFormType.SelectedValue & "," & cmbHalls.SelectedValue & "," & txtQty.Text & "," & G_Compcode & "," & G_UID & ",'" & G_IPAddress & "'," & G_UID & ",'" & G_IPAddress & "'"

        objCommon.ExecuteNonQuery(qryMain)



        'ClearHead("")
        FillGrid()
        TotalOrderQty()
        'qryMain = "Update ProdSaleOrder set OrderQtyCuttingActual=" & totalQty & " where VID=" & cmbSaleOrder.SelectedValue.ToString & ""
        'objCommon.ExecuteNonQuery(qryMain)
        lblInformation.Text = "Record Saved."
        txtID.Focus()
    End Sub

    Private Sub TotalOrderQty()
        totalQty = 0
        For Each grid As DataGridViewRow In grdRecord.Rows

            totalQty = totalQty + Setdouble(grid.Cells("Quantity").Value) ' Convert.ToDouble(IIf(grid.Cells(7).Value = "", 0, grid.Cells(7).Value))

        Next
    End Sub

    Private Sub btnNew_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnNew.Click
        ClearHead("")
        txtID.Focus()

    End Sub

    Private Sub txtSizeQty_TextChanged(ByVal sender As Object, ByVal e As EventArgs)

    End Sub

    Private Sub cmbSaleOrder_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbSaleOrder.SelectedIndexChanged
        'objCommon.FillProdSaleOrderSizes(Me.cmbSizes, Setdouble(cmbSaleOrder.SelectedValue.ToString), "CutBreakup")
        If cmbFormType.DataSource IsNot Nothing Then
            FillGrid()
        End If

    End Sub


    Private Sub cmbSizes_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbHalls.SelectedIndexChanged
        'If cmbHalls.SelectedIndex > 0 Then
        '    qry = "EXEC SpGet_ProdSaleOrderSizeQty  " & cmbHalls.SelectedValue.ToString & "," & cmbSaleOrder.SelectedValue.ToString & ""
        '    txtSizeQty.Text = objCommon.ExecuteScalar(qry)
        'End If

    End Sub

    Private Sub txtQty_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtQty.KeyPress
        Dim dotLength As Integer = 1
        dotLength = Me.txtQty.Text.Split(".").Length
        If e.KeyChar <> ControlChars.Back Then
            If dotLength > 1 Then
                e.Handled = Not (Char.IsDigit(e.KeyChar))
            Else
                e.Handled = Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = ".")
            End If
        End If
    End Sub

    Private Sub cmbFormType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbFormType.SelectedIndexChanged
        cmbSaleOrder_SelectedIndexChanged(sender, e)
    End Sub
End Class