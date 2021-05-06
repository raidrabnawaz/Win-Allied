Public Class frmInvSupplierAdvance
    Dim qryMain, VVtype As String
    Dim objCommon As New clsCommon
    Private Sub frmAttCode_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        G_CURRENTDATE = Date.Now
        If G_CURRENTDATE > G_SOFTENDDATE Then
            End
        End If

        txtID.Text = ""
        VVtype = "VendorAdvance"
        ClearHead("")

        objCommon.FillInvSupplier(Me.cmbSupplier)
        objCommon.FillCurrency(Me.cmbCurrency, "''")
        objCommon.FillPayDocType(Me.cmbDocType, "Supplier")
        objCommon.FillPOSBank(Me.cmbBank)
        FillHeader()
        FillGrid()
        dtpVDate.Focus()
        cmbSupplier.SelectedIndex = 0
        cmbDocType.SelectedIndex = 0
        cmbSupplier_SelectedIndexChanged(sender, e)
    End Sub
    Private Sub ClearHead(ByVal myid As String)
        txtVCode.Text = objCommon.ExecuteScalar("SELECT dbo.fnAccMaxCode(" & G_Compcode & ",'0', " & G_FinancialYearID & ", '" & VVtype & "', '" & CDate(dtpVDate.Value).ToString("dd/MMM/yyyy") & "','')")
        'If myid = "" Then
        ''do not change txtID.Text 
        'Else
        txtVCode.Text = ""
        txtID.Text = myid
        'IsActive.Checked = False
        'End If
        txtAmount.Text = ""
        txtNarration.Text = ""
        txtTax.Text = ""
        txtIncomeTaxAmount.Text = ""
        txtNetAmount.Text = ""
        txtChequeNo.Text = "-"
        txtExchangeRate.Text = ""
        txtRefNo.Text = ""
        cmbSupplier.SelectedValue = 0
        cmbDocType.SelectedValue = -1
        cmbPONo.SelectedValue = 0
        cmbBank.SelectedValue = 0
        dtpVDate.Value = Date.Now
        lblInformation.Text = ""
        'txtVName.Text = ""
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
        Dim grdcol8 As System.Windows.Forms.DataGridViewTextBoxColumn
        Dim grdcol9 As System.Windows.Forms.DataGridViewTextBoxColumn
        Dim grdcol10 As System.Windows.Forms.DataGridViewTextBoxColumn

        grdcol0 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        grdcol1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        grdcol2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        grdcol3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        grdcol4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        grdcol5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        grdcol6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        grdcol7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        grdcol8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        grdcol9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        grdcol10 = New System.Windows.Forms.DataGridViewTextBoxColumn()


        grdcol0.DataPropertyName = "VID"
        grdcol0.HeaderText = "VID"
        grdcol0.Name = "grdcol0"
        grdcol0.Visible = False
        '
        grdcol1.DataPropertyName = "Vdate"
        grdcol1.HeaderText = "Voucher Date"
        grdcol1.Name = "grdcol1"
        grdcol1.Width = 100

        grdcol2.DataPropertyName = "VNo"
        grdcol2.HeaderText = "Voucher No"
        grdcol2.Name = "grdcol2"
        grdcol2.Width = 100
        '
        'grdcol1
        's
        grdcol3.DataPropertyName = "VendorName"
        grdcol3.HeaderText = "Supplier Name"
        grdcol3.Name = "grdcol3"
        grdcol3.Width = 200





        grdcol4.DataPropertyName = "Amount"
        grdcol4.HeaderText = "Amount"
        grdcol4.Name = "grdcol4"
        grdcol4.Width = 100


        grdcol5.DataPropertyName = "SalesTax"
        grdcol5.HeaderText = "Tax Amount"
        grdcol5.Name = "grdcol5"
        grdcol5.Width = 100

        grdcol6.DataPropertyName = "NetAmount"
        grdcol6.HeaderText = "Net Amount"
        grdcol6.Name = "grdcol6"
        grdcol6.Width = 100

        grdcol7.DataPropertyName = "VName"
        grdcol7.HeaderText = "Description"
        grdcol7.Name = "grdcol7"
        grdcol7.Width = 200
        '


        grdcol8.DataPropertyName = "VStatus"
        grdcol8.HeaderText = "VID"
        grdcol8.Name = "grdcol8"
        grdcol8.Visible = False
        '


        grdcol9.DataPropertyName = "CompanyID"
        grdcol9.HeaderText = "VID"
        grdcol9.Name = "grdcol9"
        grdcol9.Visible = False
        '

        grdcol10.DataPropertyName = "CurrencyName"
        grdcol10.HeaderText = "VID"
        grdcol10.Name = "grdcol10"
        grdcol10.Visible = False
        '


        Me.grdRecord.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {grdcol0, grdcol1, grdcol2, grdcol3, grdcol4, grdcol5, grdcol6, grdcol7, grdcol8, grdcol9, grdcol10})
    End Sub
    Private Sub FillGrid()
        'grdRecord.DataSource = Nothing
        qryMain = "EXEC SpGetbyShow_InvSupplierAdvances " & G_Compcode & ",'" & VVtype & "'"
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
        If txtID.Text = "" Then
            ClearHead("")
            Return
        End If
        qryMain = "EXEC SpGetbyID_InvSupplierAdvances " & txtID.Text & ", '" & VVtype & "', " & G_Compcode & " "
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
        dtpVDate.Value = dr("VDate")
        txtVCode.Text = dr("VNo")
        cmbSupplier.SelectedValue = dr("SupplierID")
        cmbCurrency.SelectedValue = dr("CurrencyID")
        txtExchangeRate.Text = dr("ExchangeRate")
        txtAmount.Text = dr("Amount")
        txtNarration.Text = dr("VName")
        txtChequeNo.Text = dr("ChequeNo")
        dtpChequeDate.Value = dr("ChequeDate")
        txtRefNo.Text = dr("RefNo")
        txtTax.Text = dr("SaleTaxPer")
        txtIncomeTaxAmount.Text = dr("SalesTax")
        cmbBank.SelectedValue = dr("BankID")
        cmbPONo.SelectedValue = dr("POID")
        cmbDocType.SelectedValue = dr("DOCType")

    End Sub
    Public Sub Calculation_NetAmount()
        Dim Amount As Decimal = 0
        Dim TaxPer As Decimal = 0
        Dim TaxAmount As Decimal = 0
        Dim NetAmount As Decimal = 0
        If txtAmount.Text IsNot "" Then
            Amount = Decimal.Parse(txtAmount.Text)
        End If
        If txtTax.Text IsNot "" Then
            TaxPer = Decimal.Parse(txtTax.Text)
        End If
        If TaxPer <> 0 Then
            TaxAmount = (Amount * TaxPer) / 100
        End If

        NetAmount = Amount + TaxAmount
        txtIncomeTaxAmount.Text = Math.Round(TaxAmount, 2).ToString()
        txtNetAmount.Text = Math.Round(NetAmount, 2).ToString()
    End Sub
    Private Sub cmdNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNew.Click
        ClearHead("")
        'txtVName.Focus()
    End Sub
    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        lblInformation.Text = ""
        'If cmbDocType.SelectedIndex = 0 Then
        '    MessageBox.Show("Select Document Type.")
        '    cmbDocType.Focus()
        '    Return
        'End If

        'If cmbPONo.SelectedValue < 0 Then
        '    MessageBox.Show("Select Valid PO No.")
        '    cmbPONo.Focus()
        '    Return
        'End If


        'varify for empty string
        'varify already existance
        Try
            'Dim ErrMsg As String = verifySave()
            'If Not ErrMsg = "" Then
            '   MessageBox.Show(ErrMsg, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            '   Exit Sub
            'End If
            txtVCode.Text = objCommon.ExecuteScalar("SELECT dbo.fnAccVNo(" & G_Compcode & ", " & G_FinancialYearID & ", '" & VVtype & "', '" & CDate(dtpVDate.Value).ToString("dd/MMM/yyyy") & "')")

            '    objCommon.ExecuteNonQuery(qryMain)
            'Else
            '    Dim strcode As String
            '    strcode = objCommon.ExecuteScalar("select isnull(max(cast(L1Code as int)),0) + 1 as L1Code from tblAcSetupCOAL1 where GID = " & cmbGroup.SelectedValue)
            '    strcode = Double.Parse(strcode).ToString("00")
            '    qryMain = "insert into tblAcSetupCOAL1 (L1Code, GID, VName, OldCode) values('" &
            '    strcode & "'," & cmbGroup.SelectedValue & ",'" & txtVName.Text & "','' );  "



            If txtID.Text Is "" Or txtID.Text = "" Then
                txtID.Text = 0
            End If
            If txtAmount.Text Is "" Or txtAmount.Text = "" Then
                txtAmount.Text = 0
            End If


            qryMain = "EXEC SpSave_InvSupplierAdvances " & txtID.Text & ",'" & txtVCode.Text & "', '" & CDate(dtpVDate.Value).ToString("dd/MMM/yyyy") & "','" & txtNarration.Text & "'," & cmbSupplier.SelectedValue & ",'" & txtRefNo.Text & "'," & Setdouble(txtAmount.Text) & "," & Setdouble(txtTax.Text) & "," & Setdouble(txtIncomeTaxAmount.Text) & "," & cmbBank.SelectedValue & "," & Setdouble(txtNetAmount.Text) & ",'" & txtChequeNo.Text & "', '" & CDate(dtpChequeDate.Value).ToString("dd/MMM/yyyy") & "'," & cmbCurrency.SelectedValue & ",0," & Setdouble(txtExchangeRate.Text) & ",0,0,'Advances'," & VVtype & "," & cmbPONo.SelectedValue & "," & cmbPONo.SelectedValue & ",'" & cmbDocType.SelectedValue & "',0," & G_Compcode & "," & G_FinancialYearID & "," & G_UID & ",'" & G_IPAddress & "'," & G_UID & ",'" & G_IPAddress & "'"

            objCommon.ExecuteNonQuery(qryMain)

            ClearHead("")
            FillGrid()
            lblInformation.Text = "Record Saved."
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        'txtVName.Focus()
    End Sub
    Private Function verifySave() As String
        Dim verify As String = ""
        If grdRecord.Rows.Count = 0 Then
            verify &= "Must Enter Detail.!" & vbNewLine
            'txtVCode.Focus()
            Return verify
        End If
        If txtID.Text Is "" Or txtID.Text = "" Then 'update
            txtID.Text = 0                  '   
        End If
        Return verify
    End Function
    Private Sub cmdEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEdit.Click
        FillForm()
        'txtVName.Focus()
    End Sub
    Private Sub cmdSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSearch.Click

    End Sub
    Private Sub cmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancel.Click
        ClearHead("")
        'txtVName.Focus()
    End Sub
    Private Sub cmdDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDelete.Click

    End Sub

    Private Sub Label16_Click(sender As Object, e As EventArgs) Handles Label16.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub cmbSupplier_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSupplier.SelectedIndexChanged

        Try
            objCommon.FillDocument(Me.cmbPONo, Me.cmbSupplier.SelectedValue, "PO", "Payment")
        Catch ex As Exception
            Return
        End Try

    End Sub

    Private Sub txtAmount_TextChanged(sender As Object, e As EventArgs) Handles txtAmount.TextChanged
        Calculation_NetAmount()
    End Sub

    Private Sub txtTax_TextChanged(sender As Object, e As EventArgs) Handles txtTax.TextChanged
        Calculation_NetAmount()
    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub txtIncomeTaxAmount_TextChanged(sender As Object, e As EventArgs) Handles txtIncomeTaxAmount.TextChanged
        Dim Amount As Decimal = 0
        Dim TaxAmount As Decimal = 0
        Dim NetAmount As Decimal = 0
        If txtAmount.Text IsNot "" Then
            Amount = Setdouble(txtAmount.Text)
        End If
        If txtIncomeTaxAmount.Text IsNot "" Then
            TaxAmount = Setdouble(txtIncomeTaxAmount.Text)
        End If


        NetAmount = Amount - TaxAmount
        txtNetAmount.Text = Math.Round(NetAmount, 2).ToString()
    End Sub

    Private Sub txtExchangeRate_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtExchangeRate.KeyPress
        Dim dotLength As Integer = 1
        dotLength = Me.txtExchangeRate.Text.Split(".").Length
        If e.KeyChar <> ControlChars.Back Then
            If dotLength > 1 Then
                e.Handled = Not (Char.IsDigit(e.KeyChar))
            Else
                e.Handled = Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = ".")
            End If
        End If

    End Sub

    Private Sub cmbBank_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmbBank.KeyPress

    End Sub

    Private Sub txtTax_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTax.KeyPress
        Dim dotLength As Integer = 1
        dotLength = Me.txtTax.Text.Split(".").Length
        If e.KeyChar <> ControlChars.Back Then
            If dotLength > 1 Then
                e.Handled = Not (Char.IsDigit(e.KeyChar))
            Else
                e.Handled = Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = ".")
            End If
        End If

    End Sub

    Private Sub txtIncomeTaxAmount_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtIncomeTaxAmount.KeyPress
        Dim dotLength As Integer = 1
        dotLength = Me.txtIncomeTaxAmount.Text.Split(".").Length
        If e.KeyChar <> ControlChars.Back Then
            If dotLength > 1 Then
                e.Handled = Not (Char.IsDigit(e.KeyChar))
            Else
                e.Handled = Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = ".")
            End If
        End If
    End Sub

    Private Sub txtAmount_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAmount.KeyPress
        Dim dotLength As Integer = 1
        dotLength = Me.txtAmount.Text.Split(".").Length
        If e.KeyChar <> ControlChars.Back Then
            If dotLength > 1 Then
                e.Handled = Not (Char.IsDigit(e.KeyChar))
            Else
                e.Handled = Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = ".")
            End If
        End If
    End Sub

    Private Sub grdAtt_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles grdRecord.MouseClick
        If grdRecord.Rows.Count > 0 Then
            Dim MYID As String = grdRecord.Rows(grdRecord.CurrentCell.RowIndex).Cells(0).Value
            txtID.Text = MYID
            FillForm()
            'txtVName.Focus()
        End If
    End Sub


End Class