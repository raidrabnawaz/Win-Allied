Imports System.Collections.Specialized
Imports System.IO
Imports CrystalDecisions.CrystalReports.Engine

Public Class ProdSaleOrder
   Dim index As Integer = -1
   Dim OrderID As Int64 = 0
    Dim qryMain, qry, strcode As String
    Dim objCommon As New clsCommon

   Dim rpt As New ReportClass
   Dim MyListDic As New ListDictionary
   Dim ReportFilePath As String = ""
   Dim ReportTitle As String = ""
   Dim ReportFilter As String = ""
   Dim ReportSpName As String = ""
   Dim dtrpt = New DataTable
   Dim ReportSpName1 As String = ""
   Dim dtrpt1 As DataTable
   Dim ReportSpName2 As String = ""
   Dim dtrpt2 As DataTable
   Dim ReportSpName3 As String = ""
   Dim dtrpt3 As DataTable
   Dim ReportSpName4 As String = ""
   Dim dtrpt4 As DataTable
   Dim dtSet = New DataSet

   Private Sub frmAttCode_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
      G_CURRENTDATE = Date.Now
      If G_CURRENTDATE > G_SOFTENDDATE Then
         End
      End If

      txtVID.Text = ""
      FillHeader()
      FillCuttingHeader()
      FillDropDown()
        'ClearHead("") 
        'FillGrid()


        txtTitle.Focus()
   End Sub

   Private Sub clearDet()
      'Me.txtVCode.Text = String.Empty
      'Me.txtVName.Text = String.Empty
      Me.txtProdCapacity.Text = String.Empty
      Me.lblDepID.Text = 0
      Me.cmbDepartment.SelectedValue = -1
   End Sub

    Private Sub FillSizesDropDown()
        objCommon.FillProdSaleOrderSizes(Me.cmbSizeType, OrderID, "CutBreakup")
    End Sub
    Private Sub FillDropDown()
        objCommon.FillProdCustomer(Me.cmbCustomer)
        objCommon.FillProdBuyer(Me.cmbBuyer)
        objCommon.FillProdManufacturer(Me.cmbManufacturer)
        objCommon.FillProdBrand(Me.cmbBrand)
        objCommon.FillProdShippingMethod(Me.cmbShippingMethod)
        objCommon.FillCurrency(Me.cmbCurrency, "''")
        objCommon.FillProdDepartment(Me.cmbDepartment)
        objCommon.FillProdAccessoryNature(Me.cmbAccessoryNature)
        objCommon.FillInvProduct(Me.cmbAccessoryProduct)
        objCommon.FillProdColor(Me.cmbAccessoryColor)
        objCommon.FillProdSaleOrderSizes(Me.cmbSizeType, OrderID, "CutBreakup")
        objCommon.FillProdSetType(Me.cmbOperationSetType)
        objCommon.FillProdStyle(Me.cmbStyle)
        objCommon.FillEmployee(Me.cmbSaleRaps)
        'objCommon.FillProdColor(Me.cmbAccessoryColor)
    End Sub


    Private Sub ClearHead(ByVal myid As String)
      'If myid = "" Then
      ''do not change txtVID.Text 
      'Else
      'FillDropDown()
      txtCuttingAccessPer.Text = ""
      grdAtt.Rows.Clear()
      cmbCurrency.SelectedIndex = 0
      cmbCustomer.SelectedIndex = 0
      cmbBrand.SelectedIndex = 0
      cmbBuyer.SelectedIndex = 0
      cmbManufacturer.SelectedIndex = 0
      cmbShippingMethod.SelectedIndex = 0
      cmbOperationSetType.SelectedIndex = 0
        cmbSaleRaps.SelectedIndex = 0
        txtPOQuantity.Text = ""
        txtVNo.Text = ""
        txtVID.Text = myid
      OrderID = 0
      txtBuyerPersonelInfo.Text = ""
      txtBuyerPO.Text = ""
      txtBuyerStyle.Text = ""
      txtDestination.Text = ""
      txtOrderPrice.Text = ""
      txtPattern.Text = ""
      txtSizeChart.Text = ""
        cmbStyle.SelectedIndex = 0
        txtTitle.Text = ""
      txtWash.Text = ""
      lblTempSOID.Text = "0"
      'cmbBrand.Items.Clear()
      'End If
      lblInformation.Text = ""
      txtTitle.Text = ""
      txtVID.ReadOnly = False
   End Sub

   Private Sub ClearSizes()
      grdTrimBreakup.Rows.Clear()
      grdTrimBreakup.Columns.Clear()

      FillHeader()

      grdCuttingBreakup.Rows.Clear()
      grdCuttingBreakup.Columns.Clear()

      FillCuttingHeader()
   End Sub

   Private Sub ClearDepHead(ByVal myid As String)
      'If myid = "" Then
      ''do not change txtVID.Text 
      'Else
      lblDepID.Text = 0
      cmbDepartment.SelectedValue = 0
      'dtpLeadTime.Value = TimeOfDay
      txtDepLeadTime.Text = ""
      txtSrlNo.Text = ""
      txtProdCapacity.Text = ""
      txtProdWorth.Text = ""

   End Sub


    Private Sub btnClearAccessory_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClearAccessory.Click
        Me.lblAccessoryID.Text = ""
        'Me.lblPID.Text = grdAccessory.Rows(index).Cells("ProductID").Value
        Me.cmbAccessoryNature.SelectedIndex = 0
        Me.cmbAccessoryType.SelectedIndex = 0
        Me.cmbAccessoryColor.SelectedIndex = 0
        Me.cmbSizeType.SelectedIndex = 0
        Me.cmbAccessoryProduct.SelectedIndex = 0
        Me.txtAccessoryLeadTime.Text = ""
        Me.dtpMDNDate.Value = Date.Now
        Me.txtAccessoryQty.Text = ""
        Me.txtConsPerPcs.Text = ""
        Me.txtAccessoryExcessPer.Text = ""
        Me.txtRequiredQty.Text = ""
        Me.txtUnitSize.Text = ""
        Me.txtUnitQty.Text = ""
        Me.txtAccessoryRemarks.Text = ""
        Me.lblProductID.Text = "0"
        Me.txtProuductName.Text = ""
        Me.txtExpectedRate.Text = ""


    End Sub

    Public Sub FillHeader()
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

        Dim comboBoxCell As New DataGridViewComboBoxCell
        Dim comboBoxCell2 As New DataGridViewComboBoxCell
        Dim comboBoxCell3 As New DataGridViewComboBoxCell
        Dim comboBoxCell4 As New DataGridViewComboBoxCell
        Dim comboBoxCell5 As New DataGridViewComboBoxCell
        Dim comboBoxCell6 As New DataGridViewComboBoxCell
        Dim comboBoxCell7 As New DataGridViewComboBoxCell
        Dim comboBoxCell8 As New DataGridViewComboBoxCell


        objCommon.FillProdSaleOrderColor(comboBoxCell)
        objCommon.FillProdSaleOrderColor(comboBoxCell2)
        objCommon.FillProdSaleOrderColor(comboBoxCell3)
        objCommon.FillProdSaleOrderColor(comboBoxCell4)
        objCommon.FillProdSaleOrderColor(comboBoxCell5)
        objCommon.FillProdSaleOrderColor(comboBoxCell6)
        objCommon.FillProdSaleOrderColor(comboBoxCell7)
        objCommon.FillProdSaleOrderColor(comboBoxCell8)


        grdcol0.DataPropertyName = "Col1"
        grdcol0.HeaderText = "SizeVID"
        grdcol0.Name = "SizeVID"
        'grdcol0.Width = 50
        grdcol0.Visible = False
        '
        grdcol1.DataPropertyName = "Col2"
        grdcol1.HeaderText = "Sizes"
        grdcol1.Name = "Sizes"
        grdcol1.Width = 100
        '
        'grdcol1
        's
        grdcol2.DataPropertyName = "Col3"
        grdcol2.HeaderText = "Color1"
        grdcol2.Name = "Color1"
        grdcol2.Width = 120

        grdcol3.DataPropertyName = "Col4"
        grdcol3.HeaderText = "Color2"
        grdcol3.Name = "Color2"
        grdcol3.Width = 120

        grdcol4.DataPropertyName = "Col5"
        grdcol4.HeaderText = "Color3"
        grdcol4.Name = "Color3"
        grdcol4.Width = 120

        grdcol5.DataPropertyName = "Col6"
        grdcol5.HeaderText = "Color4"
        grdcol5.Name = "Color4"
        grdcol5.Width = 120

        grdcol6.DataPropertyName = "Col7"
        grdcol6.HeaderText = "Color5"
        grdcol6.Name = "Color5"
        grdcol6.Width = 120


        grdcol7.DataPropertyName = "Col8"
        grdcol7.HeaderText = "Color6"
        grdcol7.Name = "Color6"
        grdcol7.Width = 120

        grdcol8.DataPropertyName = "Col9"
        grdcol8.HeaderText = "Color7"
        grdcol8.Name = "Color7"
        grdcol8.Width = 120

        grdcol9.DataPropertyName = "Col10"
        grdcol9.HeaderText = "Color8"
        grdcol9.Name = "Color8"
        grdcol9.Width = 120

        grdcol10.DataPropertyName = "Col11"
        grdcol10.HeaderText = "Total"
        grdcol10.Name = "Total"
        grdcol10.ReadOnly = True
        grdcol10.Width = 100


        Dim row As ArrayList = New ArrayList
        Dim row2 As ArrayList = New ArrayList
        Dim row3 As ArrayList = New ArrayList
        Dim row4 As ArrayList = New ArrayList
        Dim row5 As ArrayList = New ArrayList
        Dim row6 As ArrayList = New ArrayList
        Dim row7 As ArrayList = New ArrayList
        Dim row8 As ArrayList = New ArrayList
        Dim row9 As ArrayList = New ArrayList
        Dim row10 As ArrayList = New ArrayList
        Dim row11 As ArrayList = New ArrayList
        row.Add("")
        row.Add("Sizes")
        row.Add("")
        row.Add("")
        row.Add("")
        row.Add("")
        row.Add("")
        row.Add("")
        row.Add("")
        row.Add("")
        row.Add("")

        Me.grdTrimBreakup.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {grdcol0, grdcol1, grdcol2, grdcol3, grdcol4, grdcol5, grdcol6, grdcol7, grdcol8, grdcol9, grdcol10})


        grdTrimBreakup.Rows.Add(row.ToArray())
        grdTrimBreakup.Rows.Add(row2.ToArray())
        grdTrimBreakup.Rows.Add(row3.ToArray())
        grdTrimBreakup.Rows.Add(row4.ToArray())
        grdTrimBreakup.Rows.Add(row5.ToArray())
        grdTrimBreakup.Rows.Add(row6.ToArray())
        grdTrimBreakup.Rows.Add(row7.ToArray())
        grdTrimBreakup.Rows.Add(row8.ToArray())
        grdTrimBreakup.Rows.Add(row9.ToArray())
        grdTrimBreakup.Rows.Add(row10.ToArray())
        grdTrimBreakup.Rows.Add(row11.ToArray())
        grdTrimBreakup.Rows(10).ReadOnly = True




        grdTrimBreakup.Rows(0).Cells(1).ReadOnly() = True
        grdTrimBreakup(2, 0) = comboBoxCell
        grdTrimBreakup(3, 0) = comboBoxCell2
        grdTrimBreakup(4, 0) = comboBoxCell3
        grdTrimBreakup(5, 0) = comboBoxCell4
        grdTrimBreakup(6, 0) = comboBoxCell5
        grdTrimBreakup(7, 0) = comboBoxCell6
        grdTrimBreakup(8, 0) = comboBoxCell7
        grdTrimBreakup(9, 0) = comboBoxCell8

    End Sub


    Public Sub FillCuttingHeader()
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

        Dim comboBoxCell As New DataGridViewComboBoxCell
        Dim comboBoxCell2 As New DataGridViewComboBoxCell
        Dim comboBoxCell3 As New DataGridViewComboBoxCell
        Dim comboBoxCell4 As New DataGridViewComboBoxCell
        Dim comboBoxCell5 As New DataGridViewComboBoxCell
        Dim comboBoxCell6 As New DataGridViewComboBoxCell
        Dim comboBoxCell7 As New DataGridViewComboBoxCell
        Dim comboBoxCell8 As New DataGridViewComboBoxCell


        objCommon.FillProdSaleOrderColor(comboBoxCell)
        objCommon.FillProdSaleOrderColor(comboBoxCell2)
        objCommon.FillProdSaleOrderColor(comboBoxCell3)
        objCommon.FillProdSaleOrderColor(comboBoxCell4)
        objCommon.FillProdSaleOrderColor(comboBoxCell5)
        objCommon.FillProdSaleOrderColor(comboBoxCell6)
        objCommon.FillProdSaleOrderColor(comboBoxCell7)
        objCommon.FillProdSaleOrderColor(comboBoxCell8)


        grdcol0.DataPropertyName = "Col1"
        grdcol0.HeaderText = "SizeVID"
        grdcol0.Name = "SizeVID"
        'grdcol0.Width = 50
        grdcol0.Visible = False
        '
        grdcol1.DataPropertyName = "Col2"
        grdcol1.HeaderText = "Sizes"
        grdcol1.Name = "Sizes"
        grdcol1.Width = 100
        '
        'grdcol1
        's
        grdcol2.DataPropertyName = "Col3"
        grdcol2.HeaderText = "Color1"
        grdcol2.Name = "Color1"
        grdcol2.Width = 120

        grdcol3.DataPropertyName = "Col4"
        grdcol3.HeaderText = "Color2"
        grdcol3.Name = "Color2"
        grdcol3.Width = 120

        grdcol4.DataPropertyName = "Col5"
        grdcol4.HeaderText = "Color3"
        grdcol4.Name = "Color3"
        grdcol4.Width = 120

        grdcol5.DataPropertyName = "Col6"
        grdcol5.HeaderText = "Color4"
        grdcol5.Name = "Color4"
        grdcol5.Width = 120

        grdcol6.DataPropertyName = "Col7"
        grdcol6.HeaderText = "Color5"
        grdcol6.Name = "Color5"
        grdcol6.Width = 120


        grdcol7.DataPropertyName = "Col8"
        grdcol7.HeaderText = "Color6"
        grdcol7.Name = "Color6"
        grdcol7.Width = 120

        grdcol8.DataPropertyName = "Col9"
        grdcol8.HeaderText = "Color7"
        grdcol8.Name = "Color7"
        grdcol8.Width = 120

        grdcol9.DataPropertyName = "Col10"
        grdcol9.HeaderText = "Color8"
        grdcol9.Name = "Color8"
        grdcol9.Width = 120

        grdcol10.DataPropertyName = "Col11"
        grdcol10.HeaderText = "Total"
        grdcol10.Name = "Total"
        grdcol10.ReadOnly = True
        grdcol10.Width = 100


        Dim row As ArrayList = New ArrayList
        Dim row2 As ArrayList = New ArrayList
        Dim row3 As ArrayList = New ArrayList
        Dim row4 As ArrayList = New ArrayList
        Dim row5 As ArrayList = New ArrayList
        Dim row6 As ArrayList = New ArrayList
        Dim row7 As ArrayList = New ArrayList
        Dim row8 As ArrayList = New ArrayList
        Dim row9 As ArrayList = New ArrayList
        Dim row10 As ArrayList = New ArrayList
        Dim row11 As ArrayList = New ArrayList
        row.Add("")
        row.Add("Sizes")
        row.Add("")
        row.Add("")
        row.Add("")
        row.Add("")
        row.Add("")
        row.Add("")
        row.Add("")
        row.Add("")
        row.Add("")

        Me.grdCuttingBreakup.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {grdcol0, grdcol1, grdcol2, grdcol3, grdcol4, grdcol5, grdcol6, grdcol7, grdcol8, grdcol9, grdcol10})


        grdCuttingBreakup.Rows.Add(row.ToArray())
        grdCuttingBreakup.Rows.Add(row2.ToArray())
        grdCuttingBreakup.Rows.Add(row3.ToArray())
        grdCuttingBreakup.Rows.Add(row4.ToArray())
        grdCuttingBreakup.Rows.Add(row5.ToArray())
        grdCuttingBreakup.Rows.Add(row6.ToArray())
        grdCuttingBreakup.Rows.Add(row7.ToArray())
        grdCuttingBreakup.Rows.Add(row8.ToArray())
        grdCuttingBreakup.Rows.Add(row9.ToArray())
        grdCuttingBreakup.Rows.Add(row10.ToArray())
        grdCuttingBreakup.Rows.Add(row11.ToArray())
        grdCuttingBreakup.Rows(10).ReadOnly = True




        grdCuttingBreakup.Rows(0).Cells(1).ReadOnly() = True
        grdCuttingBreakup(2, 0) = comboBoxCell
        grdCuttingBreakup(3, 0) = comboBoxCell2
        grdCuttingBreakup(4, 0) = comboBoxCell3
        grdCuttingBreakup(5, 0) = comboBoxCell4
        grdCuttingBreakup(6, 0) = comboBoxCell5
        grdCuttingBreakup(7, 0) = comboBoxCell6
        grdCuttingBreakup(8, 0) = comboBoxCell7
        grdCuttingBreakup(9, 0) = comboBoxCell8


    End Sub


    'Private Sub FillGrid()
    '   'grdRecord.DataSource = Nothing
    '   qryMain = "EXEC SpGet_ProdSaleOrder"
    '   Dim dt As DataTable = objCommon.GetDataTable(qryMain)
    '   If IsNothing(dt) Then
    '      'EmptyFields()
    '      Return
    '   End If
    '   If dt.Rows.Count <= 0 Then
    '      'EmptyFields()
    '      Return
    '   End If 
    'End Sub
    Private Sub FillForm()
        lblInformation.Text = ""
        If txtVID.Text = "" Then
            ClearHead("")
            Return
        End If
        qryMain = "EXEC SpGetByID_ProdSaleOrder '" & txtVID.Text & "' "
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
        OrderID = txtVID.Text
        txtTitle.Text = dr("VName")
        txtVNo.Text = dr("VNo")
        dtpVdate.Value = dr("VDate")
        cmbBuyer.SelectedValue = dr("BuyerID")
        txtBuyerPO.Text = dr("BuyerPO")
        txtBuyerStyle.Text = dr("BuyerStyle")
        txtBuyerPersonelInfo.Text = dr("BuyerContactPersonInfo")
        cmbManufacturer.SelectedValue = dr("ManufacturedID")
        cmbBrand.SelectedValue = dr("BrandID")
        cmbCustomer.SelectedValue = dr("CustomerID")
        txtOrderPrice.Text = dr("OrderPrice")
        cmbCurrency.SelectedValue = dr("CurrencyID")
        cmbSaleRaps.SelectedValue = dr("SaleRapsID")
        txtPOQuantity.Text = dr("POQty")
        cmbStyle.SelectedValue = dr("Style")
        txtPattern.Text = dr("Pattern")
        dtpPOReceiptDate.Value = dr("POReceiptDate")
        dtpPODate.Value = dr("PODate")
        dtpShippingDate.Value = dr("ShippingDate")
        txtSizeChart.Text = dr("SizeChart")
        txtWash.Text = dr("Wash")
        txtDestination.Text = dr("Destination")
        cmbShippingMethod.SelectedValue = dr("ShippingMethodID")
        cmbCurrency.SelectedValue = dr("CurrencyID")
        cmbOperationSetType.SelectedValue = dr("SetTypeID")
        txtCuttingAccessPer.Text = dr("CuttingAccessPer")
        Dim CutttingQty = dr("OrderQtyCutting")
        If CutttingQty = 0 Then
            MessageBox.Show("Please Add Cutting Breakup for this Sale Order", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
        txtVID.ReadOnly = True
        FillSizesDropDown()
    End Sub


    Private Sub FillSaleOrderDepartment()
        lblInformation.Text = ""
        If OrderID = 0 Then
            ClearDepHead("")
            Return
        End If
        qryMain = "EXEC SpGetbyID_ProdSaleOrderDepartment " & OrderID & ""
        Dim dt As DataTable = objCommon.GetDataTable(qryMain)
        If IsNothing(dt) Then
            'EmptyFields()
            Return
        End If
        If dt.Rows.Count <= 0 Then
            'EmptyFields()
            Return
        End If
        grdAtt.DataSource = dt

    End Sub

    Private Sub FillSaleOrderAccessory()
        lblInformation.Text = ""
        If OrderID = 0 Then
            'btnClearAccessory()
            Return
        End If
        qryMain = "EXEC SpGetbyIDSaleOrderAccessory " & OrderID & ""
        Dim dt As DataTable = objCommon.GetDataTable(qryMain)
        If IsNothing(dt) Then
            'EmptyFields()
            While (grdAccessory.Rows.Count >= 1)
                grdAccessory.Rows.RemoveAt(0)
            End While
            Return
        End If
        If dt.Rows.Count <= 0 Then
            'grdAccessory.DataSource = Nothing
            'grdAccessory.Rows.Clear()
            While (grdAccessory.Rows.Count >= 1)
                grdAccessory.Rows.RemoveAt(0)
            End While
            Return
        End If
        grdAccessory.DataSource = dt

    End Sub


    Private Sub FillSaleOrderSizes()
        lblInformation.Text = ""
        If OrderID = 0 Then
            ClearSizes()
            Return
        End If
        Dim VType As String = "TBreakup"
        qryMain = "EXEC SpProdGetOrderSizes " & OrderID & ",'" & VType & "'"
        Dim dt As DataTable = objCommon.GetDataTable(qryMain)
        If IsNothing(dt) Then
            'EmptyFields()
            Return
        End If
        If dt.Rows.Count <= 0 Then
            'EmptyFields()
            Return
        End If
        'grdRecord.DataSource = dt
        grdTrimBreakup.Rows.Clear()
        grdTrimBreakup.Columns.Clear()

        FillHeader()
        'Dim Col As Integer = 1
        'For I As Integer = 0 To dt.Rows.Count - 1
        '   Dim row As String() = New String() {dt.Rows(I)("Col1"), dt.Rows(I)("Col2"), dt.Rows(I)("Col3"), dt.Rows(I)("Col4"), dt.Rows(I)("Col5"), dt.Rows(I)("Col6"), dt.Rows(I)("Col7"), dt.Rows(I)("Col8")}
        'Next
        For Each gridrow As DataGridViewRow In grdTrimBreakup.Rows
            For Each gridcell As DataGridViewColumn In grdTrimBreakup.Columns
                If gridcell.Index < 11 And gridrow.Index < dt.Rows.Count Then
                    grdTrimBreakup(gridcell.Index, gridrow.Index).Value = dt.Rows(gridrow.Index)(gridcell.Index)
                    'grdRecord.Rows.Add(row)
                End If
            Next
        Next

        TotalOrderQty()

    End Sub

    Private Sub FillSaleOrderEffects()
        lblInformation.Text = ""
        If OrderID = 0 Then
            'btnClearEffects_Click(sender, e)
            Return
        End If
        qryMain = "EXEC SpGetbyID_ProdSaleOrderEffect " & OrderID & ""
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
        lblEffectID.Text = dr("VID")
        txtEffect1.Text = dr("Effect1")
        txtEffect2.Text = dr("Effect2")
        txtEffect3.Text = dr("Effect3")
        txtEffect4.Text = dr("Effect4")
        txtEffect5.Text = dr("Effect5")
        txtEffect6.Text = dr("Effect6")
        txtEffect7.Text = dr("Effect7")
        txtEffect8.Text = dr("Effect8")
        txtEffect9.Text = dr("Effect9")
        txtEffect10.Text = dr("Effect10")

    End Sub

    Private Sub FillSaleOrderInstructions()
        lblInformation.Text = ""
        If OrderID = 0 Then
            'ClearDepHead("")
            Return
        End If
        qryMain = "EXEC SpGetbyID_ProdSaleOrderInstruction " & OrderID & ""
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
        lblInstructionID.Text = dr("VID")
        txtGeneralInstructions.Text = dr("General_Instruction")
        txtFabricInstructions.Text = dr("Fabric_Instruction")
        txtCuttingInstructions.Text = dr("Cutting_Instruction")
        txtStitchingInstructions.Text = dr("Stitching_Instruction")
        txtPackingInstructions.Text = dr("Packing_Instruction")
        txtFinishingInstructions.Text = dr("Finishing_Instruction")
        txtDispatchInstructions.Text = dr("Dispatching_Instruction")

    End Sub


    Private Sub btnClearMain_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClearMain.Click
        ClearHead("")
        txtTitle.Focus()
    End Sub
    Private Sub btnSaveMain_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaveMain.Click
        lblInformation.Text = ""
        'varify for empty string
        'varify already existance
        Try

            Dim ErrMsg As String = verifySave()
            If Not ErrMsg = "" Then
                MessageBox.Show(ErrMsg, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If


            txtTitle.Text = txtTitle.Text.Trim.Replace("'", "")
            If txtTitle.Text = "" Then
                MessageBox.Show("Please give some Name.", G_APP_TITLE)
                Return
            End If
            'qryMain = "EXEC SpGetAlreadyExit_ProdColor '" & txtVID.Text & "','" & txtVNo.Text & "'; "
            'qryMain = objCommon.ExecuteScalar(qryMain)
            'If qryMain > 0 Then
            '   MessageBox.Show("Record already exists.", G_APP_TITLE)
            '   Return
            'End If
            '    objCommon.ExecuteNonQuery(qryMain)
            'Else
            '    Dim strcode As String
            '    strcode = objCommon.ExecuteScalar("select isnull(max(cast(L1Code as int)),0) + 1 as L1Code from tblAcSetupCOAL1 where GID = " & cmbGroup.SelectedValue)
            '    strcode = Double.Parse(strcode).ToString("00")
            '    qryMain = "insert into tblAcSetupCOAL1 (L1Code, GID, VName, OldCode) values('" &
            '    strcode & "'," & cmbGroup.SelectedValue & ",'" & txtTitle.Text & "','' );  "      
            'GetMaxCode()

            qryMain = "EXEC SpSave_ProdSaleOrder " & txtVID.Text & ",'" & txtVNo.Text & "','" & CDate(dtpVdate.Value).ToString("dd/MMM/yyyy") & "','" & txtTitle.Text & "'," & cmbBuyer.SelectedValue _
            & ",'" & txtBuyerPO.Text & "','" & txtBuyerStyle.Text & "','" & txtBuyerPersonelInfo.Text & "'," & cmbManufacturer.SelectedValue & "," & cmbBrand.SelectedValue & "," & cmbCustomer.SelectedValue _
            & "," & txtOrderPrice.Text & "," & cmbCurrency.SelectedValue & ",0,0,'" & CDate(dtpPOReceiptDate.Value).ToString("dd/MMM/yyyy") & "','" & CDate(dtpPODate.Value).ToString("dd/MMM/yyyy") & "','" & CDate(dtpShippingDate.Value).ToString("dd/MMM/yyyy") _
            & "',0," & cmbStyle.SelectedValue & ",'" & txtPattern.Text & "','" & txtSizeChart.Text & "','" & txtWash.Text & "','" & txtDestination.Text & "',0," & cmbShippingMethod.SelectedValue & "," & cmbOperationSetType.SelectedValue & ",1," & G_Compcode & "," & G_Compcode & ",'1900-01-01','----'," & cmbSaleRaps.SelectedValue & "," & Setdouble(txtPOQuantity.Text) & "," & G_UID & ",'','" & G_IPAddress & "'," & G_UID & ",'','" & G_IPAddress & "'," & G_FinancialYearID & ""

            OrderID = objCommon.ExecuteScalar(qryMain)

            ClearHead("")
            'FillGrid()
            lblInformation.Text = "Record Saved."
            txtTitle.Focus()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            'objCommon.CloseConnection()
        End Try
    End Sub

    Private Function verifySave() As String
        Dim verify As String = ""
        txtTitle.Text = txtTitle.Text.Trim.Replace("'", "")
        If txtTitle.Text = "" Then
            verify = "Please give some Name." & vbNewLine
            Return verify
        End If
        If txtVNo.Text = "" Then
            verify = "Please give Voucher Number" & vbNewLine
            Return verify
        End If
        If txtOrderPrice.Text Is "" Or txtOrderPrice.Text = "" Then
            txtOrderPrice.Text = "0"
        End If
        If txtVID.Text Is "" Or txtVID.Text = "" Then 'update
            txtVID.Text = 0                  '    qryMain = " update tblAcSetupCOAL1 set VName='" & txtTitle.Text & "',GID='" & cmbGroup.SelectedValue & "' where L1Code = '" & txtVID.Text & "'; "
        End If
        If cmbCustomer.SelectedValue = 0 Or cmbCustomer.SelectedValue = -1 Then
            verify &= "Please select Customer" & vbNewLine
            cmbCustomer.Focus()
        End If
        If cmbBuyer.SelectedValue = 0 Or cmbBuyer.SelectedValue = -1 Then
            verify &= "Please select Buyer" & vbNewLine
            cmbBuyer.Focus()
        End If
        If cmbManufacturer.SelectedValue = 0 Or cmbManufacturer.SelectedValue = -1 Then
            verify &= "Please select Manufacturer" & vbNewLine
            cmbManufacturer.Focus()
        End If
        If cmbBrand.SelectedValue = 0 Or cmbBrand.SelectedValue = -1 Then
            verify &= "Please select Brand" & vbNewLine
            cmbBrand.Focus()
        End If
        If cmbShippingMethod.SelectedValue = 0 Or cmbShippingMethod.SelectedValue = -1 Then
            verify &= "Please select Shipping Method" & vbNewLine
            cmbShippingMethod.Focus()
        End If
        If cmbCurrency.SelectedValue = 0 Or cmbCurrency.SelectedValue = -1 Then
            verify &= "Please select Currency" & vbNewLine
            cmbCurrency.Focus()
        End If
        If cmbOperationSetType.SelectedValue = 0 Or cmbOperationSetType.SelectedValue = -1 Then
            verify &= "Please select Product Type" & vbNewLine
            cmbOperationSetType.Focus()
        End If
        Dim Lock As String
        Lock = objCommon.ExecuteScalar("select dbo.fnAllowBackDate('Win-ERP','ProdSaleOrder','" & CDate(dtpVdate.Value).ToString("dd/MMM/yyyy") & "'," & G_UID & "," & G_Compcode & ", " & G_FinancialYearID & ")")

        If Not (Lock = "") Then
            verify = Lock
            Return verify
        End If
        Return verify
    End Function

    Private Sub cmdEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEdit.Click
        FillForm()
        txtTitle.Focus()
    End Sub

    Private Sub GetMaxCode()
        If (txtVNo.Text = "") Then
            strcode = objCommon.ExecuteScalar("select dbo.fnAccMaxCode(" & G_Compcode & "," & G_UID & "," & G_FinancialYearID & ",'ProdSaleOrder','" & CDate(dtpVdate.Value).ToString("dd/MMM/yyyy") & "', '" & CDate(dtpVdate.Value).ToString("MMyy") & "')")
            strcode = Double.Parse(G_Compcode).ToString("00") & "-" & CDate(dtpVdate.Value).ToString("MMyy") & "-" & Double.Parse(strcode).ToString("0000")
            txtVNo.Text = strcode
        End If
    End Sub

    Private Sub btnSearchMain_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearchMain.Click
        frmLookup.LookupQuery = "Exec SpGet_ProdSaleOrder "
        frmLookup.LookupName = "ProdSaleOrder"
        frmLookup.VID = ""
        frmLookup.VCode = ""
        frmLookup.VName = ""
        frmLookup.ShowDialog()
        If frmLookup.VID <> "" Then
            txtVID.Text = frmLookup.VID
            txtVNo.Text = frmLookup.VCode
            FillForm()
        End If
    End Sub
    Private Sub cmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancel.Click
        ClearHead("")
        txtTitle.Focus()
    End Sub
    Private Sub cmdDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDelete.Click

    End Sub


    Private Sub TotalOrderQty()
        Dim totalQty As Double = 0
        For Each grid As DataGridViewRow In grdTrimBreakup.Rows
            If grid.Index < 10 Then
                totalQty = totalQty + Setdouble(grid.Cells("Total").Value) ' Convert.ToDouble(IIf(grid.Cells(7).Value = "", 0, grid.Cells(7).Value))
            End If
        Next
        grdTrimBreakup(10, 10).Value = totalQty
    End Sub

    Private Sub TotalCuttingQty()
        Dim totalCuttingQty As Double = 0
        For Each gridCut As DataGridViewRow In grdCuttingBreakup.Rows
            If gridCut.Index < 10 Then
                totalCuttingQty = totalCuttingQty + Setdouble(gridCut.Cells("Total").Value) ' Convert.ToDouble(IIf(grid.Cells(7).Value = "", 0, grid.Cells(7).Value))
            End If
        Next
        grdCuttingBreakup(10, 10).Value = totalCuttingQty
    End Sub






    Private Sub btnAddDepartment_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddDepartment.Click
        'true  xor false = true
        Dim qty As Double
        qty = Setdouble(Me.txtProdCapacity.Text)
        If Not ((qty > 0)) Then
            MessageBox.Show("Enter Valid Production Capacity", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtProdCapacity.Focus()
            Return
        End If

        If (cmbDepartment.SelectedValue = -1) Then
            MessageBox.Show("Select Valid Department", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtProdCapacity.Focus()
            Return
        End If

        If (OrderID = 0) Then
            MessageBox.Show("Select Valid Order", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            'txtProdCapacity.Focus()
            Return
        End If
        'If lblPID.Text = "" Then
        '   MessageBox.Show("Select Valid Product", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        '   txtProdCapacity.Focus()
        '   Return
        'End If
        If lblDepID.Text = String.Empty Or lblDepID.Text = "" Then
            lblDepID.Text = 0
        End If

        qryMain = "EXEC SpSave_ProdSaleOrderDepartment  " & lblDepID.Text & "," & OrderID & ",'" & txtDepLeadTime.Text & "',0," & cmbDepartment.SelectedValue & ",'" & txtProdWorth.Text & "','" & txtProdCapacity.Text & "',''," & G_UID & ",'" & G_IPAddress & "',''," & G_UID & ",'" & G_IPAddress & "' "
        objCommon.ExecuteNonQuery(qryMain)
        FillSaleOrderDepartment()
        MessageBox.Show("Department Saved", "Save Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
        cmbDepartment.Focus()
        'If index > -1 And Me.lblDID.Text.Trim <> String.Empty Then
        '   grdAtt.Rows(index).Cells("VID").Value = Me.lblDID.Text
        '   'grdAtt.Rows(index).Cells("ProductID").Value = Me.lblPID.Text
        '   grdAtt.Rows(index).Cells("DepartmentID").Value = Me.cmbDepartment.SelectedValue
        '   grdAtt.Rows(index).Cells("Department").Value = Me.cmbDepartment.Text
        '   grdAtt.Rows(index).Cells("LeadTime").Value = Me.dtpLeadTime.Text
        '   grdAtt.Rows(index).Cells("SrlNo").Value = Me.txtSrlNo.Text
        '   grdAtt.Rows(index).Cells("ProductionWorth").Value = Me.txtProdWorth.Text
        '   grdAtt.Rows(index).Cells("ProductionCapacity").Value = Me.txtProdCapacity.Text
        '   'DataGridView1.Rows(index).Cells(7).Value = cr
        '   index = -1
        '   Me.clearDet()
        'ElseIf index = -1 And Me.lblDID.Text.Trim <> String.Empty Then

        '   Dim row As String() = New String() {0, cmbDepartment.SelectedValue, cmbDepartment.Text, Me.dtpLeadTime.Text, Me.txtSrlNo.Text, Me.txtProdWorth.Text, Me.txtProdCapacity.Text}
        '   grdAtt.Rows.Add(row)
        '   Me.clearDet()
        'Else
        '   MessageBox.Show("Select Correct Entry", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        'End If
        'Me.txtVCode.Focus()
    End Sub

    Private Sub grdAtt_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdAtt.CellClick
        If grdAtt.Rows.Count > 0 Then
            index = e.RowIndex
            'If e.ColumnIndex = grdAtt.Columns("DEL").Index Then
            '   'Exit Sub
            '   grdAtt.Rows(index).Visible = False
            '   grdAtt.Rows(index).Cells("IsDel").Value = 1
            '   Exit Sub
            'End If
            If index > -1 Then
                Me.lblDepID.Text = grdAtt.Rows(index).Cells("VID").Value
                'Me.lblPID.Text = grdAtt.Rows(index).Cells("ProductID").Value
                Me.cmbDepartment.SelectedValue = grdAtt.Rows(index).Cells("DepartmentID").Value
                Me.txtDepLeadTime.Text = grdAtt.Rows(index).Cells("LeadTime").Value
                Me.txtSrlNo.Text = grdAtt.Rows(index).Cells("SrlNo").Value
                Me.txtProdWorth.Text = grdAtt.Rows(index).Cells("ProductionWorth").Value
                Me.txtProdCapacity.Text = grdAtt.Rows(index).Cells("ProductionCapacity").Value
            End If
        End If
    End Sub

    Private Sub btnClearDep_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        lblDepID.Text = 0
        cmbDepartment.SelectedValue = 0
        txtDepLeadTime.Text = ""
        'dtpLeadTime.Value = Date.Now
        txtSrlNo.Text = ""
        txtProdCapacity.Text = ""
        txtProdWorth.Text = ""
    End Sub

    Private Sub TabControl1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabControl1.SelectedIndexChanged
        Select Case TabControl1.SelectedIndex

            Case 0 ' User clicks on First Tab
            ' code to do here

            Case 1 ' User clicks on Second Tab
                ' code to do here
                FillSaleOrderSizes()
            Case 2 ' User clicks on Third Tab
                ' code to do here
                If OrderID = 0 Then
                    ClearDepHead("")

                End If
                FillSaleOrderDepartment()
            Case 3 ' User clicks on Fourth Tab
                ' code to do here
                If OrderID = 0 Then
                    btnClearInstructions_Click(sender, e)
                End If
                FillSaleOrderInstructions()
            Case 4 ' User clicks on Fifth Tab
                ' code to do here
                If OrderID = 0 Then
                    btnClearEffects_Click(sender, e)
                End If
                FillSaleOrderEffects()
            Case 5 ' User clicks on Sixth Tab
            ' code to do here
            Case 6 ' User clicks on Seventh Tab
                ' code to do here
                If OrderID = 0 Then
                    btnClearAccessory_Click(sender, e)
                End If
                FillSaleOrderAccessory()
                FillSizesDropDown()
            Case 7
                FillSaleOrderOTCharges()
        End Select
    End Sub

    Private Sub btnSaveEffects_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaveEffects.Click

        If (OrderID = 0) Then
            MessageBox.Show("Select Valid Order", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            'txtProdCapacity.Focus()
            Return
        End If
        'If lblPID.Text = "" Then
        '   MessageBox.Show("Select Valid Product", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        '   txtProdCapacity.Focus()
        '   Return
        'End If
        If lblEffectID.Text = String.Empty Or lblEffectID.Text = "" Then
            lblEffectID.Text = 0
        End If

        qryMain = "EXEC SpSave_ProdSaleOrderEffect  " & lblEffectID.Text & "," & OrderID & ",'" & txtEffect1.Text & "','" & txtEffect2.Text & "','" & txtEffect3.Text _
         & "','" & txtEffect4.Text & "','" & txtEffect5.Text & "','" & txtEffect6.Text & "','" & txtEffect7.Text & "','" & txtEffect8.Text & "','" & txtEffect9.Text _
         & "','" & txtEffect10.Text & "',''," & G_UID & ",'" & G_IPAddress & "',''," & G_UID & ",'" & G_IPAddress & "' "
        objCommon.ExecuteNonQuery(qryMain)
        FillSaleOrderEffects()
        MessageBox.Show("Effects Saved", "Save Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
        txtEffect1.Focus()
    End Sub

    Private Sub btnClearEffects_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClearEffects.Click
        If OrderID = 0 Then
            lblEffectID.Text = 0
        End If
        txtEffect1.Text = ""
        txtEffect2.Text = ""
        txtEffect3.Text = ""
        txtEffect4.Text = ""
        txtEffect5.Text = ""
        txtEffect6.Text = ""
        txtEffect7.Text = ""
        txtEffect8.Text = ""
        txtEffect9.Text = ""
        txtEffect10.Text = ""

    End Sub


    Private Sub btnClearInstructions_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClearInstructions.Click
        If OrderID = 0 Then
            lblInstructionID.Text = 0
        End If
        txtGeneralInstructions.Text = ""
        txtFabricInstructions.Text = ""
        txtCuttingInstructions.Text = ""
        txtStitchingInstructions.Text = ""
        txtPackingInstructions.Text = ""
        txtFinishingInstructions.Text = ""
        txtDispatchInstructions.Text = ""

    End Sub

    Private Sub btnSaveSaleOrderSizes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaveSaleOrderSizes.Click
        'For col As Integer = 0 To grdRecord.Columns.Count - 1
        '   MessageBox.Show(grdRecord.Rows(0).i(col))
        'Next
        Try
            If (OrderID = 0) Then
                MessageBox.Show("Select Valid Order First", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                'txtProdCapacity.Focus()
                Return
            End If
            Dim strColor As String = "0"
            Dim VType As String = "TBreakup"
            objCommon.openConnection()
            For Each gridcolumn As DataGridViewColumn In grdTrimBreakup.Columns
                If gridcolumn.Index > 1 And gridcolumn.Index < 10 And Setdouble(grdTrimBreakup.Rows(0).Cells(gridcolumn.Index).Value) > 0 Then
                    qryMain = "EXEC SpSave_ProdSaleOrderColor 0," & OrderID & "," & grdTrimBreakup.Rows(0).Cells(gridcolumn.Index).Value & ",0,0,0,'-','" & VType & "','1900-01-01'," & G_UID & ",'" & G_IPAddress & "','1900-01-01'," & G_UID & ",'" & G_IPAddress & "' "
                    strColor = strColor & "," & grdTrimBreakup.Rows(0).Cells(gridcolumn.Index).Value
                    objCommon.ExecuteNonQueryWithOpen(qryMain)
                End If
            Next
            '' remove extra colorid in tblProdSaleOrderColor -- which are not in above list
            qryMain = "delete from ProdSaleOrderColor where orderID=" & OrderID & " and VType='" & VType & "' and ColorID not in (" & strColor & ") "
            objCommon.ExecuteNonQueryWithOpen(qryMain)
            objCommon.CloseConnection()


            Dim SizeID As Integer
            Dim strSizeID As String = "0"
            Dim strColorID As String = "0"
            Dim gridrow1 As DataGridViewRow = grdTrimBreakup.Rows(0)
            objCommon.openConnection()
            For Each gridrow As DataGridViewRow In grdTrimBreakup.Rows
                If gridrow.Index > 0 And gridrow.Index < 10 And gridrow.Cells(1).Value > "0" Then
                    For Each gridcell As DataGridViewColumn In grdTrimBreakup.Columns
                        If gridcell.Index = 1 Then
                            SizeID = Setdouble(gridrow.Cells(0).Value)
                            qryMain = "EXEC SpSave_ProdSaleOrderSizes " & SizeID & "," & OrderID & ",'" & gridrow.Cells(gridcell.Index).Value & "','" & VType & "','1900-01-01'," & G_UID & ",'" & G_IPAddress & "','1900-01-01'," & G_UID & ",'" & G_IPAddress & "' "
                            SizeID = objCommon.ExecuteScalarWithOpen(qryMain)
                        End If
                        If gridcell.Index > 1 And gridcell.Index < 10 And gridrow.Cells(1).Value.ToString > "0" And gridrow.Cells(gridcell.Index).Value > "0" Then
                            'If gridrow.Cells(gridcell.Index).Value Then
                            qryMain = "EXEC SpSave_ProdSaleOrderSizesQty 0," & OrderID & "," & SizeID & "," & Setdouble(gridrow1.Cells(gridcell.Index).Value) & ",0,0," & gridrow.Cells(gridcell.Index).Value & ",'-','" & VType & "','1900-01-01'," & G_UID & ",'" & G_IPAddress & "','1900-01-01'," & G_UID & ",'" & G_IPAddress & "' "
                            objCommon.ExecuteNonQueryWithOpen(qryMain)
                            strColorID = strColorID & "," & grdTrimBreakup.Rows(0).Cells(gridcell.Index).Value

                            strSizeID = strSizeID & "," & SizeID
                            'MessageBox.Show(gridrow.Cells(gridcell.Index).Value)

                        End If


                        'If gridcell.Index > 1 And gridcell.Index < 7 And Setdouble(grdRecord.Rows(0).Cells(gridcell.Index).Value) > 0 Then
                        '   'If gridrow.Cells(gridcell.Index).Value Then
                        '   qryMain = "EXEC SpSave_ProdSaleOrderSizesQty 0," & OrderID & "," & SizeID & "," & grdRecord.Rows(0).Cells(gridcell.Index).Value & ",0,0," & gridrow.Cells(gridcell.Index).Value & ",'-','1900-01-01'," & G_UID & ",'" & G_IPAddress & "','1900-01-01'," & G_UID & ",'" & G_IPAddress & "' "
                        '   objCommon.ExecuteNonQuery(qryMain)

                        '   'MessageBox.Show(gridrow.Cells(gridcell.Index).Value)

                        'End If

                    Next
                End If

            Next
            objCommon.CloseConnection()

            '' remove extra colorid in tblProdSaleOrderColor -- which are not in above list
            qryMain = "delete from  ProdSaleOrderSizesQty where orderID=" & OrderID & " and VType='" & VType & "' and ColorID not in (" & strColorID & ") " &
       " ; delete from  ProdSaleOrderSizesQty where orderID=" & OrderID & " and VType='" & VType & "' and SizeID not in (" & strSizeID & "); " &
       " ; delete from  ProdSaleOrderSizes where orderID=" & OrderID & " and VType='" & VType & "' and VID not in (" & strSizeID &
       "); Update ProdSaleOrder set OrderQty=" & grdTrimBreakup(10, 10).Value & " where VID= " & OrderID & ""
            objCommon.ExecuteNonQuery(qryMain)

            FillSaleOrderSizes()

            'For Each gridrow As DataGridViewRow In grdRecord.Rows
            '   If gridrow.Index > 0 Then
            '      If gridrow.Index = 1 Then

            '         'qryMain = "EXEC SpSaveInvIGPDetail " & grid.Cells("VID").Value & ",'', '" & grid.Cells("ProductID").Value & "', " & grid.Cells("UomID").Value & ", " & grid.Cells("Quantity").Value & ", " & grid.Cells("VTypePK").Value & ", " & G_UID & ", '" & G_IPAddress & "', " & G_UID & ",'" & G_IPAddress & "', " & IIf(grid.Cells("IsDel").Value = Nothing, 0, 1)
            '         'objCommon.ExecuteNonQuery(qryMain)
            '      End If
            '      If gridrow.Index > 1 Then

            '      End If
            '      'qryMain = "EXEC SpSaveInvIGPDetail " & grid.Cells("VID").Value & ",'', '" & grid.Cells("ProductID").Value & "', " & grid.Cells("UomID").Value & ", " & grid.Cells("Quantity").Value & ", " & grid.Cells("VTypePK").Value & ", " & G_UID & ", '" & G_IPAddress & "', " & G_UID & ",'" & G_IPAddress & "', " & IIf(grid.Cells("IsDel").Value = Nothing, 0, 1)
            '      'objCommon.ExecuteNonQuery(qryMain)
            '   End If
            'Next
        Catch
            MessageBox.Show("Record Not Saved")
        Finally
            objCommon.CloseConnection()
        End Try
    End Sub

    Private Sub btnSaveCuttingBreakup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaveCutBreakup.Click
        'For col As Integer = 0 To grdRecord.Columns.Count - 1
        '   MessageBox.Show(grdRecord.Rows(0).i(col))
        'Next

        If (OrderID = 0) Then
            MessageBox.Show("Select Valid Order First", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            'txtProdCapacity.Focus()
            Return
        End If
        Dim strColor As String = "0"
        Dim VType As String = "CutBreakup"
        objCommon.openConnection()
        For Each gridcolumn As DataGridViewColumn In grdCuttingBreakup.Columns
            If gridcolumn.Index > 1 And gridcolumn.Index < 10 And Setdouble(grdCuttingBreakup.Rows(0).Cells(gridcolumn.Index).Value) > 0 Then
                qryMain = "EXEC SpSave_ProdSaleOrderColor 0," & OrderID & "," & grdCuttingBreakup.Rows(0).Cells(gridcolumn.Index).Value & ",0,0,0,'-','" & VType & "','1900-01-01'," & G_UID & ",'" & G_IPAddress & "','1900-01-01'," & G_UID & ",'" & G_IPAddress & "' "
                strColor = strColor & "," & grdCuttingBreakup.Rows(0).Cells(gridcolumn.Index).Value
                objCommon.ExecuteNonQueryWithOpen(qryMain)
            End If
        Next
        '' remove extra colorid in tblProdSaleOrderColor -- which are not in above list
        qryMain = "delete from ProdSaleOrderColor where orderID=" & OrderID & " and VType='" & VType & "' and ColorID not in (" & strColor & ") "
        objCommon.ExecuteNonQueryWithOpen(qryMain)
        objCommon.CloseConnection()


        Dim SizeID As Integer
        Dim strSizeID As String = "0"
        Dim strColorID As String = "0"
        Dim gridrow1 As DataGridViewRow = grdCuttingBreakup.Rows(0)
        objCommon.openConnection()
        For Each gridrow As DataGridViewRow In grdCuttingBreakup.Rows
            If gridrow.Index > 0 And gridrow.Index < 10 And gridrow.Cells(1).Value > "0" Then
                For Each gridcell As DataGridViewColumn In grdCuttingBreakup.Columns
                    If gridcell.Index = 1 Then
                        SizeID = Setdouble(gridrow.Cells(0).Value)
                        qryMain = "EXEC SpSave_ProdSaleOrderSizes " & SizeID & "," & OrderID & ",'" & gridrow.Cells(gridcell.Index).Value & "','" & VType & "','1900-01-01'," & G_UID & ",'" & G_IPAddress & "','1900-01-01'," & G_UID & ",'" & G_IPAddress & "' "
                        SizeID = objCommon.ExecuteScalarWithOpen(qryMain)
                    End If
                    If gridcell.Index > 1 And gridcell.Index < 10 And gridrow1.Cells(gridcell.Index).Value > "0" And gridrow.Cells(gridcell.Index).Value > "0" Then
                        'If gridrow.Cells(gridcell.Index).Value Then
                        qryMain = "EXEC SpSave_ProdSaleOrderSizesQty 0," & OrderID & "," & SizeID & "," & Setdouble(gridrow1.Cells(gridcell.Index).Value) & ",0,0," & gridrow.Cells(gridcell.Index).Value & ",'-','" & VType & "','1900-01-01'," & G_UID & ",'" & G_IPAddress & "','1900-01-01'," & G_UID & ",'" & G_IPAddress & "' "
                        objCommon.ExecuteNonQueryWithOpen(qryMain)
                        strColorID = strColorID & "," & grdCuttingBreakup.Rows(0).Cells(gridcell.Index).Value

                        strSizeID = strSizeID & "," & SizeID
                        'MessageBox.Show(gridrow.Cells(gridcell.Index).Value)

                    End If


                    'If gridcell.Index > 1 And gridcell.Index < 7 And Setdouble(grdRecord.Rows(0).Cells(gridcell.Index).Value) > 0 Then
                    '   'If gridrow.Cells(gridcell.Index).Value Then
                    '   qryMain = "EXEC SpSave_ProdSaleOrderSizesQty 0," & OrderID & "," & SizeID & "," & grdRecord.Rows(0).Cells(gridcell.Index).Value & ",0,0," & gridrow.Cells(gridcell.Index).Value & ",'-','1900-01-01'," & G_UID & ",'" & G_IPAddress & "','1900-01-01'," & G_UID & ",'" & G_IPAddress & "' "
                    '   objCommon.ExecuteNonQuery(qryMain)

                    '   'MessageBox.Show(gridrow.Cells(gridcell.Index).Value)

                    'End If

                Next
            End If

        Next
        objCommon.CloseConnection()

        '' remove extra colorid in tblProdSaleOrderColor -- which are not in above list
        qryMain = "delete from  ProdSaleOrderSizesQty where orderID=" & OrderID & " and VType='" & VType & "'  and ColorID not in (" & strColorID & ") " &
       " ; delete from  ProdSaleOrderSizesQty where orderID=" & OrderID & " and VType='" & VType & "'  and SizeID not in (" & strSizeID & "); " &
       " ; delete from  ProdSaleOrderSizes where orderID=" & OrderID & " and VType='" & VType & "'  and VID not in (" & strSizeID &
       "); Update ProdSaleOrder set OrderQtyCutting=" & grdCuttingBreakup(10, 10).Value & ",CuttingAccessPer=" & Setdouble(txtCuttingAccessPer.Text) & " where VID= " & OrderID & ""
        objCommon.ExecuteNonQuery(qryMain)

        'btnFillGrdCutting_Click(sender, e)
        FillGrdCuttingBreakup()
        'For Each gridrow As DataGridViewRow In grdRecord.Rows
        '   If gridrow.Index > 0 Then
        '      If gridrow.Index = 1 Then

        '         'qryMain = "EXEC SpSaveInvIGPDetail " & grid.Cells("VID").Value & ",'', '" & grid.Cells("ProductID").Value & "', " & grid.Cells("UomID").Value & ", " & grid.Cells("Quantity").Value & ", " & grid.Cells("VTypePK").Value & ", " & G_UID & ", '" & G_IPAddress & "', " & G_UID & ",'" & G_IPAddress & "', " & IIf(grid.Cells("IsDel").Value = Nothing, 0, 1)
        '         'objCommon.ExecuteNonQuery(qryMain)
        '      End If
        '      If gridrow.Index > 1 Then

        '      End If
        '      'qryMain = "EXEC SpSaveInvIGPDetail " & grid.Cells("VID").Value & ",'', '" & grid.Cells("ProductID").Value & "', " & grid.Cells("UomID").Value & ", " & grid.Cells("Quantity").Value & ", " & grid.Cells("VTypePK").Value & ", " & G_UID & ", '" & G_IPAddress & "', " & G_UID & ",'" & G_IPAddress & "', " & IIf(grid.Cells("IsDel").Value = Nothing, 0, 1)
        '      'objCommon.ExecuteNonQuery(qryMain)
        '   End If
        'Next

    End Sub



    Private Sub btnAddAccessory_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddAccessory.Click
        'true  xor false = true
        Dim qty As Double
        qty = Setdouble(Me.txtAccessoryQty.Text)
        If Not ((qty > 0)) Then
            MessageBox.Show("Enter Valid Accessory Quantity", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtProdCapacity.Focus()
            Return
        End If

        If (cmbAccessoryNature.SelectedValue = 0) Then
            MessageBox.Show("Select Valid Accessory Nature", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cmbAccessoryNature.Focus()
            Return
        End If

        'If (cmbSizeType.SelectedValue = 0) Then
        '   MessageBox.Show("Select Valid Size Type", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        '   cmbAccessoryNature.Focus()
        '   Return
        'End If

        'If (cmbAccessoryType.SelectedValue = 0) Then
        '   MessageBox.Show("Select Valid Accessory Type", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        '   cmbAccessoryType.Focus()
        '   Return
        'End If

        If (lblProductID.Text = 0) Then
            MessageBox.Show("Select Valid Product", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cmbAccessoryProduct.Focus()
            Return
        End If
        If cmbSizeType.SelectedValue = "" Then
            Me.cmbSizeType.SelectedIndex = 0
        End If
        If (OrderID = 0) Then
            MessageBox.Show("Select Valid Order First", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            'txtProdCapacity.Focus()
            Return
        End If
        'If lblPID.Text = "" Then
        '   MessageBox.Show("Select Valid Product", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        '   txtProdCapacity.Focus()
        '   Return
        'End If
        If lblAccessoryID.Text = String.Empty Or lblAccessoryID.Text = "" Then
            lblAccessoryID.Text = 0
        End If

        qryMain = "EXEC SpSave_ProdSaleOrderAccessory  " & lblAccessoryID.Text & ",'-'," & OrderID & "," & cmbAccessoryNature.SelectedValue & "," & cmbAccessoryType.SelectedValue & "," & cmbAccessoryColor.SelectedValue & "," & cmbSizeType.SelectedValue & "," & lblProductID.Text & ",1," & txtAccessoryQty.Text & "," & txtConsPerPcs.Text _
         & "," & txtExpectedRate.Text & "," & txtAccessoryExcessPer.Text & "," & txtRequiredQty.Text & ",'" & txtAccessoryRemarks.Text & "'," & txtUnitSize.Text & "," & txtUnitQty.Text & ",'" & txtAccessoryLeadTime.Text & "','" & CDate(dtpMDNDate.Value).ToString("dd/MMM/yyyy") & "'," & G_Compcode & "," & G_UID & ",'" & G_IPAddress & "'," & G_UID & ",'" & G_IPAddress & "' "
        objCommon.ExecuteNonQuery(qryMain)
        'FillSaleOrderDepartment()
        btnClearAccessory_Click(sender, e)
        FillSaleOrderAccessory()
        MessageBox.Show("Accessory Saved", "Save Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
        cmbAccessoryNature.Focus()
    End Sub

    Private Sub cmbAccessoryNature_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbAccessoryNature.SelectedIndexChanged
        objCommon.FillProdAccessoryType(Me.cmbAccessoryType, Setdouble(cmbAccessoryNature.SelectedValue.ToString))
    End Sub

    Private Sub txtAccessoryQty_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAccessoryQty.TextChanged
        txtRequiredQty.Text = Setdouble(txtAccessoryQty.Text) * Setdouble(txtConsPerPcs.Text) * (1 + (Setdouble(txtAccessoryExcessPer.Text) / 100))
    End Sub

    Private Sub txtUnitSize_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtUnitSize.TextChanged
        If txtUnitSize.Text <> "" Then
            txtUnitQty.Text = CInt(Math.Ceiling(Setdouble(txtRequiredQty.Text) / Setdouble(txtUnitSize.Text)))
        End If
    End Sub

    Private Sub txtConsPerPcs_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtConsPerPcs.TextChanged
        txtRequiredQty.Text = Setdouble(txtAccessoryQty.Text) * Setdouble(txtConsPerPcs.Text) * (1 + (Setdouble(txtAccessoryExcessPer.Text) / 100))

    End Sub

    Private Sub txtAccessPer_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAccessoryExcessPer.TextChanged
        txtRequiredQty.Text = Setdouble(txtAccessoryQty.Text) * Setdouble(txtConsPerPcs.Text) * (1 + (Setdouble(txtAccessoryExcessPer.Text) / 100))

    End Sub

    Private Sub grdAccessory_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdAccessory.CellClick
        If grdAccessory.Rows.Count > 0 Then
            index = e.RowIndex
            'If e.ColumnIndex = grdAtt.Columns("DEL").Index Then
            '   'Exit Sub
            '   grdAtt.Rows(index).Visible = False
            '   grdAtt.Rows(index).Cells("IsDel").Value = 1
            '   Exit Sub
            'End If
            If index > -1 Then
                Me.lblAccessoryID.Text = grdAccessory.Rows(index).Cells("AccessoryID").Value
                'Me.lblPID.Text = grdAccessory.Rows(index).Cells("ProductID").Value
                Me.cmbAccessoryNature.SelectedValue = grdAccessory.Rows(index).Cells("AccessoryNatureID").Value
                Me.cmbAccessoryType.SelectedValue = grdAccessory.Rows(index).Cells("AccessoryTypeID").Value
                Me.cmbAccessoryColor.SelectedValue = grdAccessory.Rows(index).Cells("AccessoryColorID").Value
                Me.cmbSizeType.SelectedValue = grdAccessory.Rows(index).Cells("SizeTypeID").Value
                Me.lblProductID.Text = grdAccessory.Rows(index).Cells("ProductID").Value
                Me.txtProuductName.Text = grdAccessory.Rows(index).Cells("ProductName").Value
                Me.txtAccessoryLeadTime.Text = grdAccessory.Rows(index).Cells("AccessoryLeadTime").Value
                Me.dtpMDNDate.Value = grdAccessory.Rows(index).Cells("ExpMDNDate").Value
                Me.txtAccessoryQty.Text = grdAccessory.Rows(index).Cells("AccessoryQty").Value
                Me.txtConsPerPcs.Text = grdAccessory.Rows(index).Cells("ConsPerPcs").Value
                Me.txtAccessoryExcessPer.Text = grdAccessory.Rows(index).Cells("AccessPer").Value
                Me.txtRequiredQty.Text = grdAccessory.Rows(index).Cells("RequiredQty").Value
                Me.txtUnitSize.Text = grdAccessory.Rows(index).Cells("UnitSize").Value
                Me.txtUnitQty.Text = grdAccessory.Rows(index).Cells("UnitQty").Value
                Me.txtAccessoryRemarks.Text = grdAccessory.Rows(index).Cells("AccessoryRemarks").Value
                Me.txtExpectedRate.Text = grdAccessory.Rows(index).Cells("ExpectedRate").Value
            End If
        End If
    End Sub

    Private Sub btnClearOrderSizes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        FillSaleOrderSizes()
    End Sub

    Private Sub btnSaveOrderInstructions_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaveOrderInstructions.Click

        If (OrderID = 0) Then
            MessageBox.Show("Select Valid Order", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            'txtProdCapacity.Focus()
            Return
        End If
        'If lblPID.Text = "" Then
        '   MessageBox.Show("Select Valid Product", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        '   txtProdCapacity.Focus()
        '   Return
        'End If
        If lblInstructionID.Text = String.Empty Or lblInstructionID.Text = "" Then
            lblInstructionID.Text = 0
        End If

        qryMain = "EXEC SpSave_ProdSaleOrderInstruction  " & lblInstructionID.Text & "," & OrderID & ",'" & txtGeneralInstructions.Text & "','" & txtFabricInstructions.Text & "','" & txtCuttingInstructions.Text _
         & "','" & txtStitchingInstructions.Text & "','" & txtPackingInstructions.Text & "','" & txtFinishingInstructions.Text & "','-','" & txtDispatchInstructions.Text _
         & "',''," & G_UID & ",'" & G_IPAddress & "',''," & G_UID & ",'" & G_IPAddress & "' "
        objCommon.ExecuteNonQuery(qryMain)
        FillSaleOrderInstructions()
        MessageBox.Show("Instructions Saved", "Save Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
        txtGeneralInstructions.Focus()
    End Sub


    Private Sub btnFillGrdCutting_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFillGrdCutting.Click
        lblInformation.Text = ""
        If OrderID = 0 Then
            ClearSizes()
            Return
        End If
        Dim VType As String = "TBreakup"
        qryMain = "EXEC SpProdGetOrderSizes " & OrderID & ",'" & VType & "'"
        Dim dt As DataTable = objCommon.GetDataTable(qryMain)
        If IsNothing(dt) Then
            'EmptyFields()
            Return
        End If
        If dt.Rows.Count <= 0 Then
            'EmptyFields()
            Return
        End If
        'grdRecord.DataSource = dt

        'grdCuttingBreakup.Rows.Clear()
        'grdCuttingBreakup.Columns.Clear()

        'FillCuttingHeader()
        'Dim Col As Integer = 1
        'For I As Integer = 0 To dt.Rows.Count - 1
        '   Dim row As String() = New String() {dt.Rows(I)("Col1"), dt.Rows(I)("Col2"), dt.Rows(I)("Col3"), dt.Rows(I)("Col4"), dt.Rows(I)("Col5"), dt.Rows(I)("Col6"), dt.Rows(I)("Col7"), dt.Rows(I)("Col8")}
        'Next
        For Each gridrow As DataGridViewRow In grdCuttingBreakup.Rows
            For Each gridcell As DataGridViewColumn In grdCuttingBreakup.Columns
                If gridcell.Index < 8 And gridrow.Index < dt.Rows.Count Then
                    If gridcell.Index > 1 And gridrow.Index > 0 Then
                        grdCuttingBreakup(gridcell.Index, gridrow.Index).Value = dt.Rows(gridrow.Index)(gridcell.Index) * (1 + (Setdouble(txtCuttingAccessPer.Text) / 100))
                    ElseIf gridcell.Index = 1 Or gridrow.Index = 0 Then
                        grdCuttingBreakup(gridcell.Index, gridrow.Index).Value = dt.Rows(gridrow.Index)(gridcell.Index)
                    End If

                    'grdRecord.Rows.Add(row)
                End If
            Next
        Next

        TotalCuttingQty()

    End Sub

    Private Sub FillGrdCuttingBreakup()
        lblInformation.Text = ""
        If OrderID = 0 Then
            ClearSizes()
            Return
        End If
        Dim VType As String = "CutBreakup"
        qryMain = "EXEC SpProdGetOrderSizes " & OrderID & ",'" & VType & "'"
        Dim dt As DataTable = objCommon.GetDataTable(qryMain)
        If IsNothing(dt) Then
            'EmptyFields()
            Return
        End If
        If dt.Rows.Count <= 0 Then
            'EmptyFields()
            Return
        End If
        'grdRecord.DataSource = dt
        grdCuttingBreakup.Rows.Clear()
        grdCuttingBreakup.Columns.Clear()

        FillCuttingHeader()
        'Dim Col As Integer = 1
        'For I As Integer = 0 To dt.Rows.Count - 1
        '   Dim row As String() = New String() {dt.Rows(I)("Col1"), dt.Rows(I)("Col2"), dt.Rows(I)("Col3"), dt.Rows(I)("Col4"), dt.Rows(I)("Col5"), dt.Rows(I)("Col6"), dt.Rows(I)("Col7"), dt.Rows(I)("Col8")}
        'Next
        For Each gridrow As DataGridViewRow In grdCuttingBreakup.Rows
            For Each gridcell As DataGridViewColumn In grdCuttingBreakup.Columns
                If gridcell.Index < 11 And gridrow.Index < dt.Rows.Count Then

                    grdCuttingBreakup(gridcell.Index, gridrow.Index).Value = dt.Rows(gridrow.Index)(gridcell.Index)


                    'grdRecord.Rows.Add(row)
                End If
            Next
        Next

        TotalCuttingQty()

    End Sub

    Private Sub TabControl2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabControl2.SelectedIndexChanged
        Select Case TabControl1.SelectedIndex

            Case 0 ' User clicks on First Tab
            ' code to do here

            Case 1 ' User clicks on Second Tab
                ' code to do here
                FillGrdCuttingBreakup()
        End Select
    End Sub

    Private Sub txtCuttingAccessPer_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCuttingAccessPer.KeyPress
        Dim dotLength As Integer = 1
        dotLength = Me.txtCuttingAccessPer.Text.Split(".").Length
        If e.KeyChar <> ControlChars.Back Then
            If dotLength > 1 Then
                e.Handled = Not (Char.IsDigit(e.KeyChar))
            Else
                e.Handled = Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = ".")
            End If
        End If
    End Sub

    Private Sub txtOrderPrice_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtOrderPrice.KeyPress, txtPOQuantity.KeyPress
        Dim dotLength As Integer = 1
        dotLength = Me.txtOrderPrice.Text.Split(".").Length
        If e.KeyChar <> ControlChars.Back Then
            If dotLength > 1 Then
                e.Handled = Not (Char.IsDigit(e.KeyChar))
            Else
                e.Handled = Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = ".")
            End If
        End If
    End Sub

    Private Sub txtAccessoryQty_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtAccessoryQty.KeyPress
        Dim dotLength As Integer = 1
        dotLength = Me.txtAccessoryQty.Text.Split(".").Length
        If e.KeyChar <> ControlChars.Back Then
            If dotLength > 1 Then
                e.Handled = Not (Char.IsDigit(e.KeyChar))
            Else
                e.Handled = Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = ".")
            End If
        End If
    End Sub

    Private Sub txtConsPerPcs_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtConsPerPcs.KeyPress
        Dim dotLength As Integer = 1
        dotLength = Me.txtConsPerPcs.Text.Split(".").Length
        If e.KeyChar <> ControlChars.Back Then
            If dotLength > 1 Then
                e.Handled = Not (Char.IsDigit(e.KeyChar))
            Else
                e.Handled = Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = ".")
            End If
        End If
    End Sub

    Private Sub txtAccessPer_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtAccessoryExcessPer.KeyPress
        Dim dotLength As Integer = 1
        dotLength = Me.txtAccessoryExcessPer.Text.Split(".").Length
        If e.KeyChar <> ControlChars.Back Then
            If dotLength > 1 Then
                e.Handled = Not (Char.IsDigit(e.KeyChar))
            Else
                e.Handled = Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = ".")
            End If
        End If
    End Sub

    Private Sub txtUnitSize_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtUnitSize.KeyPress
        Dim dotLength As Integer = 1
        dotLength = Me.txtUnitSize.Text.Split(".").Length
        If e.KeyChar <> ControlChars.Back Then
            If dotLength > 1 Then
                e.Handled = Not (Char.IsDigit(e.KeyChar))
            Else
                e.Handled = Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = ".")
            End If
        End If
    End Sub

    Private Sub btnPrintSaleOrderDetail_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrintSaleOrderDetail.Click
        If txtVID.Text = "" Then
            Return
        End If
        MyListDic.Clear()
        rpt = (WinReportsApplication.Classess.ProductionReports.SetReportName("rptProdSaleOrderDetail"))

        ReportTitle = ""

        MyListDic.Add("@OrderID", txtVID.Text)
        MyListDic.Add("@cWhere", "")
        MyListDic.Add("@UserID", G_UID)
        MyListDic.Add("@CompanyID", G_Compcode)
        ReportSpName = "SpRpt_ProdSaleOrderDetail"
        dtrpt = objCommon.GetDataTableSPPrm(ReportSpName, MyListDic)


        ReportSpName1 = "SPRptSaleOrderAccessorySub"
        dtrpt1 = objCommon.GetDataTableSPPrm(ReportSpName1, MyListDic)

        ReportSpName2 = "SpRptInvIssueMainDetail"
        dtrpt2 = objCommon.GetDataTableSPPrm(ReportSpName2, MyListDic)
        'dtSet.Tables.Add(objCommon.GetDataTableSPPrm(ReportSpName2, MyListDic))

        ReportSpName3 = "SpRptInvIssueReturnMainDetail"
        dtrpt3 = objCommon.GetDataTableSPPrm(ReportSpName3, MyListDic)

        ReportSpName4 = "SpRptProdOrderWiseWagesSub"
        dtrpt4 = objCommon.GetDataTableSPPrm(ReportSpName4, MyListDic)



        dtSet.Tables.Add(dtrpt.Copy())
        dtSet.Tables(0).TableName = "dtrpt"
        dtSet.Tables.Add(dtrpt1.Copy())
        dtSet.Tables(1).TableName = "dtrpt1"
        dtSet.Tables.Add(dtrpt2.Copy())
        dtSet.Tables(2).TableName = "dtrpt2"
        dtSet.Tables.Add(dtrpt3.Copy())
        dtSet.Tables(3).TableName = "dtrpt3"
        dtSet.Tables.Add(dtrpt4.Copy())
        dtSet.Tables(4).TableName = "dtrpt4"



        MyListDic.Add("ReportTitle", "Sale Order Detail Report")
        MyListDic.Add("comp_Name", G_CompName)
        'MyListDic.Add("@cWhere", " where AH.VId = " & lblVID.Text)


        Dim MyReportViewer As ReportViewer = New ReportViewer
        MyReportViewer.dtSet = dtSet
        MyReportViewer.MyListDic = MyListDic
        MyReportViewer.rtp = rpt
        MyReportViewer.MdiParent = EMSMain
        MyReportViewer.Show()

        dtSet.Tables.Clear()
    End Sub


    Private Sub txtProuductName_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtProuductName.KeyDown
        If e.KeyCode = Keys.F2 Then
            frmLookup.LookupQuery = "EXEC SpGet_ProdProductAccessory  " & cmbAccessoryNature.SelectedValue.ToString & "," & cmbAccessoryType.SelectedValue.ToString & "," & cmbAccessoryColor.SelectedValue.ToString & ""
            frmLookup.LookupName = "Product"
            frmLookup.VID = ""
            frmLookup.VCode = ""
            frmLookup.VName = ""
            frmLookup.ShowDialog()
            If frmLookup.VID <> "" Then
                lblProductID.Text = frmLookup.VID
                'txtProductCode.Text = frmLookup.VCode
                txtProuductName.Text = frmLookup.VName
                txtAccessoryLeadTime.Text = frmLookup.LeadTime
                txtAccessoryExcessPer.Text = frmLookup.ExcessPer
            End If
            'cmbUom.SelectedValue = frmLookup.UOMID
            'frmLookupCOA.Dispose()
            txtAccessoryLeadTime.Focus()
        End If
    End Sub


    Private Sub btnFetchOrderSizes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFetchOrderSizes.Click
      frmLookup.LookupQuery = "Exec SpGet_ProdSaleOrder "
      frmLookup.LookupName = "ProdSaleOrder"
      frmLookup.VID = ""
      frmLookup.VCode = ""
      frmLookup.VName = ""
      frmLookup.ShowDialog()
      If frmLookup.VID <> "" Then
            lblTempSOID.Text = frmLookup.VID
            'txtVNo.Text = frmLookup.VCode
            FetchOldSOSizes()
      End If
   End Sub

    Private Sub txtExpectedRate_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtExpectedRate.KeyPress
        Dim dotLength As Integer = 1
        dotLength = Me.txtExpectedRate.Text.Split(".").Length
        If e.KeyChar <> ControlChars.Back Then
            If dotLength > 1 Then
                e.Handled = Not (Char.IsDigit(e.KeyChar))
            Else
                e.Handled = Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = ".")
            End If
        End If
    End Sub

    Private Sub grdCuttingBreakup_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles grdCuttingBreakup.CellValueChanged
        Dim Color1, Color2, Color3, Color4, Color5, Color6, Color7, Color8, Total As Double
        If e.RowIndex > 0 Then
            If e.ColumnIndex = grdCuttingBreakup.Columns("Color1").Index Then
                Color1 = Setdouble(grdCuttingBreakup.Rows(e.RowIndex).Cells(e.ColumnIndex).Value)
                Color2 = Setdouble(grdCuttingBreakup.Rows(e.RowIndex).Cells(e.ColumnIndex + 1).Value)
                Color3 = Setdouble(grdCuttingBreakup.Rows(e.RowIndex).Cells(e.ColumnIndex + 2).Value)
                Color4 = Setdouble(grdCuttingBreakup.Rows(e.RowIndex).Cells(e.ColumnIndex + 3).Value)
                Color5 = Setdouble(grdCuttingBreakup.Rows(e.RowIndex).Cells(e.ColumnIndex + 4).Value)
                Color6 = Setdouble(grdCuttingBreakup.Rows(e.RowIndex).Cells(e.ColumnIndex + 5).Value)
                Color7 = Setdouble(grdCuttingBreakup.Rows(e.RowIndex).Cells(e.ColumnIndex + 6).Value)
                Color8 = Setdouble(grdCuttingBreakup.Rows(e.RowIndex).Cells(e.ColumnIndex + 7).Value)
                'SaleTaxPer = Setdouble(grdRecord.Rows(e.RowIndex).Cells("SaleTaxPer").Value)
                'PendingQty = Setdouble(grdRecord.Rows(e.RowIndex).Cells("PendingQty").Value)
                Total = Color1 + Color2 + Color3 + Color4 + Color5 + Color6 + Color7 + Color8
                'If EQty > PendingQty Then
                '   MessageBox.Show("PO Qty cannot be greater than Pending Qty.!", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                '   grdRecord.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = PendingQty
                '   EQty = PendingQty
                'End If
                grdCuttingBreakup.Rows(e.RowIndex).Cells("Total").Value = Total
                'grdRecord.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = EQty
                'grdRecord.Rows(e.RowIndex).Cells(e.ColumnIndex + 1).Value = VRate
                'grdRecord.Rows(e.RowIndex).Cells("SaleTaxValue").Value = (Setdouble(grdRecord.Rows(e.RowIndex).Cells("Amount").Value) * SaleTaxPer) / 100
            End If
            If e.ColumnIndex = grdCuttingBreakup.Columns("Color2").Index Then
                Color1 = Setdouble(grdCuttingBreakup.Rows(e.RowIndex).Cells(e.ColumnIndex).Value)
                Color2 = Setdouble(grdCuttingBreakup.Rows(e.RowIndex).Cells(e.ColumnIndex - 1).Value)
                Color3 = Setdouble(grdCuttingBreakup.Rows(e.RowIndex).Cells(e.ColumnIndex + 1).Value)
                Color4 = Setdouble(grdCuttingBreakup.Rows(e.RowIndex).Cells(e.ColumnIndex + 2).Value)
                Color5 = Setdouble(grdCuttingBreakup.Rows(e.RowIndex).Cells(e.ColumnIndex + 3).Value)
                Color6 = Setdouble(grdCuttingBreakup.Rows(e.RowIndex).Cells(e.ColumnIndex + 4).Value)
                Color7 = Setdouble(grdCuttingBreakup.Rows(e.RowIndex).Cells(e.ColumnIndex + 5).Value)
                Color8 = Setdouble(grdCuttingBreakup.Rows(e.RowIndex).Cells(e.ColumnIndex + 6).Value)
                'SaleTaxPer = Setdouble(grdRecord.Rows(e.RowIndex).Cells("SaleTaxPer").Value)
                'PendingQty = Setdouble(grdRecord.Rows(e.RowIndex).Cells("PendingQty").Value)
                Total = Color1 + Color2 + Color3 + Color4 + Color5 + Color6 + Color7 + Color8
                'If EQty > PendingQty Then
                '   MessageBox.Show("PO Qty cannot be greater than Pending Qty.!", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                '   grdRecord.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = PendingQty
                '   EQty = PendingQty
                'End If
                grdCuttingBreakup.Rows(e.RowIndex).Cells("Total").Value = Total
                'grdRecord.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = EQty
                'grdRecord.Rows(e.RowIndex).Cells(e.ColumnIndex + 1).Value = VRate
                'grdRecord.Rows(e.RowIndex).Cells("SaleTaxValue").Value = (Setdouble(grdRecord.Rows(e.RowIndex).Cells("Amount").Value) * SaleTaxPer) / 100
            End If
            If e.ColumnIndex = grdCuttingBreakup.Columns("Color3").Index Then
                Color1 = Setdouble(grdCuttingBreakup.Rows(e.RowIndex).Cells(e.ColumnIndex).Value)
                Color2 = Setdouble(grdCuttingBreakup.Rows(e.RowIndex).Cells(e.ColumnIndex - 1).Value)
                Color3 = Setdouble(grdCuttingBreakup.Rows(e.RowIndex).Cells(e.ColumnIndex - 2).Value)
                Color4 = Setdouble(grdCuttingBreakup.Rows(e.RowIndex).Cells(e.ColumnIndex + 1).Value)
                Color5 = Setdouble(grdCuttingBreakup.Rows(e.RowIndex).Cells(e.ColumnIndex + 2).Value)
                Color6 = Setdouble(grdCuttingBreakup.Rows(e.RowIndex).Cells(e.ColumnIndex + 3).Value)
                Color7 = Setdouble(grdCuttingBreakup.Rows(e.RowIndex).Cells(e.ColumnIndex + 4).Value)
                Color8 = Setdouble(grdCuttingBreakup.Rows(e.RowIndex).Cells(e.ColumnIndex + 5).Value)
                'SaleTaxPer = Setdouble(grdRecord.Rows(e.RowIndex).Cells("SaleTaxPer").Value)
                'PendingQty = Setdouble(grdRecord.Rows(e.RowIndex).Cells("PendingQty").Value)
                Total = Color1 + Color2 + Color3 + Color4 + Color5 + Color6 + Color7 + Color8
                'If EQty > PendingQty Then
                '   MessageBox.Show("PO Qty cannot be greater than Pending Qty.!", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                '   grdRecord.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = PendingQty
                '   EQty = PendingQty
                'End If
                grdCuttingBreakup.Rows(e.RowIndex).Cells("Total").Value = Total
                'grdRecord.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = EQty
                'grdRecord.Rows(e.RowIndex).Cells(e.ColumnIndex + 1).Value = VRate
                'grdRecord.Rows(e.RowIndex).Cells("SaleTaxValue").Value = (Setdouble(grdRecord.Rows(e.RowIndex).Cells("Amount").Value) * SaleTaxPer) / 100
            End If
            If e.ColumnIndex = grdCuttingBreakup.Columns("Color4").Index Then
                Color1 = Setdouble(grdCuttingBreakup.Rows(e.RowIndex).Cells(e.ColumnIndex).Value)
                Color2 = Setdouble(grdCuttingBreakup.Rows(e.RowIndex).Cells(e.ColumnIndex - 1).Value)
                Color3 = Setdouble(grdCuttingBreakup.Rows(e.RowIndex).Cells(e.ColumnIndex - 2).Value)
                Color4 = Setdouble(grdCuttingBreakup.Rows(e.RowIndex).Cells(e.ColumnIndex - 3).Value)
                Color5 = Setdouble(grdCuttingBreakup.Rows(e.RowIndex).Cells(e.ColumnIndex + 1).Value)
                Color6 = Setdouble(grdCuttingBreakup.Rows(e.RowIndex).Cells(e.ColumnIndex + 2).Value)
                Color7 = Setdouble(grdCuttingBreakup.Rows(e.RowIndex).Cells(e.ColumnIndex + 3).Value)
                Color8 = Setdouble(grdCuttingBreakup.Rows(e.RowIndex).Cells(e.ColumnIndex + 4).Value)
                'SaleTaxPer = Setdouble(grdRecord.Rows(e.RowIndex).Cells("SaleTaxPer").Value)
                'PendingQty = Setdouble(grdRecord.Rows(e.RowIndex).Cells("PendingQty").Value)
                Total = Color1 + Color2 + Color3 + Color4 + Color5 + Color6 + Color7 + Color8
                'If EQty > PendingQty Then
                '   MessageBox.Show("PO Qty cannot be greater than Pending Qty.!", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                '   grdRecord.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = PendingQty
                '   EQty = PendingQty
                'End If
                grdCuttingBreakup.Rows(e.RowIndex).Cells("Total").Value = Total
                'grdRecord.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = EQty
                'grdRecord.Rows(e.RowIndex).Cells(e.ColumnIndex + 1).Value = VRate
                'grdRecord.Rows(e.RowIndex).Cells("SaleTaxValue").Value = (Setdouble(grdRecord.Rows(e.RowIndex).Cells("Amount").Value) * SaleTaxPer) / 100
            End If
            If e.ColumnIndex = grdCuttingBreakup.Columns("Color5").Index Then
                Color1 = Setdouble(grdCuttingBreakup.Rows(e.RowIndex).Cells(e.ColumnIndex).Value)
                Color2 = Setdouble(grdCuttingBreakup.Rows(e.RowIndex).Cells(e.ColumnIndex - 1).Value)
                Color3 = Setdouble(grdCuttingBreakup.Rows(e.RowIndex).Cells(e.ColumnIndex - 2).Value)
                Color4 = Setdouble(grdCuttingBreakup.Rows(e.RowIndex).Cells(e.ColumnIndex - 3).Value)
                Color5 = Setdouble(grdCuttingBreakup.Rows(e.RowIndex).Cells(e.ColumnIndex - 4).Value)
                Color6 = Setdouble(grdCuttingBreakup.Rows(e.RowIndex).Cells(e.ColumnIndex + 1).Value)
                Color7 = Setdouble(grdCuttingBreakup.Rows(e.RowIndex).Cells(e.ColumnIndex + 2).Value)
                Color8 = Setdouble(grdCuttingBreakup.Rows(e.RowIndex).Cells(e.ColumnIndex + 3).Value)
                'SaleTaxPer = Setdouble(grdRecord.Rows(e.RowIndex).Cells("SaleTaxPer").Value)
                'PendingQty = Setdouble(grdRecord.Rows(e.RowIndex).Cells("PendingQty").Value)
                Total = Color1 + Color2 + Color3 + Color4 + Color5 + Color6 + Color7 + Color8
                'If EQty > PendingQty Then
                '   MessageBox.Show("PO Qty cannot be greater than Pending Qty.!", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                '   grdRecord.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = PendingQty
                '   EQty = PendingQty
                'End If
                grdCuttingBreakup.Rows(e.RowIndex).Cells("Total").Value = Total
                'grdRecord.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = EQty
                'grdRecord.Rows(e.RowIndex).Cells(e.ColumnIndex + 1).Value = VRate
                'grdRecord.Rows(e.RowIndex).Cells("SaleTaxValue").Value = (Setdouble(grdRecord.Rows(e.RowIndex).Cells("Amount").Value) * SaleTaxPer) / 100
            End If
            If e.ColumnIndex = grdCuttingBreakup.Columns("Color6").Index Then
                Color1 = Setdouble(grdCuttingBreakup.Rows(e.RowIndex).Cells(e.ColumnIndex).Value)
                Color2 = Setdouble(grdCuttingBreakup.Rows(e.RowIndex).Cells(e.ColumnIndex - 1).Value)
                Color3 = Setdouble(grdCuttingBreakup.Rows(e.RowIndex).Cells(e.ColumnIndex - 2).Value)
                Color4 = Setdouble(grdCuttingBreakup.Rows(e.RowIndex).Cells(e.ColumnIndex - 3).Value)
                Color5 = Setdouble(grdCuttingBreakup.Rows(e.RowIndex).Cells(e.ColumnIndex - 4).Value)
                Color6 = Setdouble(grdCuttingBreakup.Rows(e.RowIndex).Cells(e.ColumnIndex - 5).Value)
                Color7 = Setdouble(grdCuttingBreakup.Rows(e.RowIndex).Cells(e.ColumnIndex + 1).Value)
                Color8 = Setdouble(grdCuttingBreakup.Rows(e.RowIndex).Cells(e.ColumnIndex + 2).Value)
                'SaleTaxPer = Setdouble(grdRecord.Rows(e.RowIndex).Cells("SaleTaxPer").Value)
                'PendingQty = Setdouble(grdRecord.Rows(e.RowIndex).Cells("PendingQty").Value)
                Total = Color1 + Color2 + Color3 + Color4 + Color5 + Color6 + Color7 + Color8
                'If EQty > PendingQty Then
                '   MessageBox.Show("PO Qty cannot be greater than Pending Qty.!", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                '   grdRecord.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = PendingQty
                '   EQty = PendingQty
                'End If
                grdCuttingBreakup.Rows(e.RowIndex).Cells("Total").Value = Total
                'grdRecord.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = EQty
                'grdRecord.Rows(e.RowIndex).Cells(e.ColumnIndex + 1).Value = VRate
                'grdRecord.Rows(e.RowIndex).Cells("SaleTaxValue").Value = (Setdouble(grdRecord.Rows(e.RowIndex).Cells("Amount").Value) * SaleTaxPer) / 100
            End If
            If e.ColumnIndex = grdCuttingBreakup.Columns("Color7").Index Then
                Color1 = Setdouble(grdCuttingBreakup.Rows(e.RowIndex).Cells(e.ColumnIndex).Value)
                Color2 = Setdouble(grdCuttingBreakup.Rows(e.RowIndex).Cells(e.ColumnIndex - 1).Value)
                Color3 = Setdouble(grdCuttingBreakup.Rows(e.RowIndex).Cells(e.ColumnIndex - 2).Value)
                Color4 = Setdouble(grdCuttingBreakup.Rows(e.RowIndex).Cells(e.ColumnIndex - 3).Value)
                Color5 = Setdouble(grdCuttingBreakup.Rows(e.RowIndex).Cells(e.ColumnIndex - 4).Value)
                Color6 = Setdouble(grdCuttingBreakup.Rows(e.RowIndex).Cells(e.ColumnIndex - 5).Value)
                Color7 = Setdouble(grdCuttingBreakup.Rows(e.RowIndex).Cells(e.ColumnIndex - 6).Value)
                Color8 = Setdouble(grdCuttingBreakup.Rows(e.RowIndex).Cells(e.ColumnIndex + 1).Value)
                'SaleTaxPer = Setdouble(grdRecord.Rows(e.RowIndex).Cells("SaleTaxPer").Value)
                'PendingQty = Setdouble(grdRecord.Rows(e.RowIndex).Cells("PendingQty").Value)
                Total = Color1 + Color2 + Color3 + Color4 + Color5 + Color6 + Color7 + Color8
                'If EQty > PendingQty Then
                '   MessageBox.Show("PO Qty cannot be greater than Pending Qty.!", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                '   grdRecord.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = PendingQty
                '   EQty = PendingQty
                'End If
                grdCuttingBreakup.Rows(e.RowIndex).Cells("Total").Value = Total
                'grdRecord.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = EQty
                'grdRecord.Rows(e.RowIndex).Cells(e.ColumnIndex + 1).Value = VRate
                'grdRecord.Rows(e.RowIndex).Cells("SaleTaxValue").Value = (Setdouble(grdRecord.Rows(e.RowIndex).Cells("Amount").Value) * SaleTaxPer) / 100
            End If
            If e.ColumnIndex = grdCuttingBreakup.Columns("Color8").Index Then
                Color1 = Setdouble(grdCuttingBreakup.Rows(e.RowIndex).Cells(e.ColumnIndex).Value)
                Color2 = Setdouble(grdCuttingBreakup.Rows(e.RowIndex).Cells(e.ColumnIndex - 1).Value)
                Color3 = Setdouble(grdCuttingBreakup.Rows(e.RowIndex).Cells(e.ColumnIndex - 2).Value)
                Color4 = Setdouble(grdCuttingBreakup.Rows(e.RowIndex).Cells(e.ColumnIndex - 3).Value)
                Color5 = Setdouble(grdCuttingBreakup.Rows(e.RowIndex).Cells(e.ColumnIndex - 4).Value)
                Color6 = Setdouble(grdCuttingBreakup.Rows(e.RowIndex).Cells(e.ColumnIndex - 5).Value)
                Color7 = Setdouble(grdCuttingBreakup.Rows(e.RowIndex).Cells(e.ColumnIndex - 6).Value)
                Color8 = Setdouble(grdCuttingBreakup.Rows(e.RowIndex).Cells(e.ColumnIndex - 7).Value)
                'SaleTaxPer = Setdouble(grdRecord.Rows(e.RowIndex).Cells("SaleTaxPer").Value)
                'PendingQty = Setdouble(grdRecord.Rows(e.RowIndex).Cells("PendingQty").Value)
                Total = Color1 + Color2 + Color3 + Color4 + Color5 + Color6 + Color7 + Color8
                'If EQty > PendingQty Then
                '   MessageBox.Show("PO Qty cannot be greater than Pending Qty.!", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                '   grdRecord.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = PendingQty
                '   EQty = PendingQty
                'End If
                grdCuttingBreakup.Rows(e.RowIndex).Cells("Total").Value = Total
                'grdRecord.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = EQty
                'grdRecord.Rows(e.RowIndex).Cells(e.ColumnIndex + 1).Value = VRate
                'grdRecord.Rows(e.RowIndex).Cells("SaleTaxValue").Value = (Setdouble(grdRecord.Rows(e.RowIndex).Cells("Amount").Value) * SaleTaxPer) / 100
            End If

            TotalCuttingQty()
        End If
    End Sub

    Private Sub grdTrimBreakup_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles grdTrimBreakup.CellValueChanged
        Dim Color1, Color2, Color3, Color4, Color5, Color6, Color7, Color8, Total As Double
        If e.RowIndex > 0 Then
            If e.ColumnIndex = grdTrimBreakup.Columns("Color1").Index Then
                Color1 = Setdouble(grdTrimBreakup.Rows(e.RowIndex).Cells(e.ColumnIndex).Value)
                Color2 = Setdouble(grdTrimBreakup.Rows(e.RowIndex).Cells(e.ColumnIndex + 1).Value)
                Color3 = Setdouble(grdTrimBreakup.Rows(e.RowIndex).Cells(e.ColumnIndex + 2).Value)
                Color4 = Setdouble(grdTrimBreakup.Rows(e.RowIndex).Cells(e.ColumnIndex + 3).Value)
                Color5 = Setdouble(grdTrimBreakup.Rows(e.RowIndex).Cells(e.ColumnIndex + 4).Value)
                Color6 = Setdouble(grdTrimBreakup.Rows(e.RowIndex).Cells(e.ColumnIndex + 5).Value)
                Color7 = Setdouble(grdTrimBreakup.Rows(e.RowIndex).Cells(e.ColumnIndex + 6).Value)
                Color8 = Setdouble(grdTrimBreakup.Rows(e.RowIndex).Cells(e.ColumnIndex + 7).Value)
                'SaleTaxPer = Setdouble(grdRecord.Rows(e.RowIndex).Cells("SaleTaxPer").Value)
                'PendingQty = Setdouble(grdRecord.Rows(e.RowIndex).Cells("PendingQty").Value)
                Total = Color1 + Color2 + Color3 + Color4 + Color5 + Color6 + Color7 + Color8
                'If EQty > PendingQty Then
                '   MessageBox.Show("PO Qty cannot be greater than Pending Qty.!", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                '   grdRecord.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = PendingQty
                '   EQty = PendingQty
                'End If
                grdTrimBreakup.Rows(e.RowIndex).Cells("Total").Value = Total
                'grdRecord.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = EQty
                'grdRecord.Rows(e.RowIndex).Cells(e.ColumnIndex + 1).Value = VRate
                'grdRecord.Rows(e.RowIndex).Cells("SaleTaxValue").Value = (Setdouble(grdRecord.Rows(e.RowIndex).Cells("Amount").Value) * SaleTaxPer) / 100
            End If
            If e.ColumnIndex = grdTrimBreakup.Columns("Color2").Index Then
                Color1 = Setdouble(grdTrimBreakup.Rows(e.RowIndex).Cells(e.ColumnIndex).Value)
                Color2 = Setdouble(grdTrimBreakup.Rows(e.RowIndex).Cells(e.ColumnIndex - 1).Value)
                Color3 = Setdouble(grdTrimBreakup.Rows(e.RowIndex).Cells(e.ColumnIndex + 1).Value)
                Color4 = Setdouble(grdTrimBreakup.Rows(e.RowIndex).Cells(e.ColumnIndex + 2).Value)
                Color5 = Setdouble(grdTrimBreakup.Rows(e.RowIndex).Cells(e.ColumnIndex + 3).Value)
                Color6 = Setdouble(grdTrimBreakup.Rows(e.RowIndex).Cells(e.ColumnIndex + 4).Value)
                Color7 = Setdouble(grdTrimBreakup.Rows(e.RowIndex).Cells(e.ColumnIndex + 5).Value)
                Color8 = Setdouble(grdTrimBreakup.Rows(e.RowIndex).Cells(e.ColumnIndex + 6).Value)
                'SaleTaxPer = Setdouble(grdRecord.Rows(e.RowIndex).Cells("SaleTaxPer").Value)
                'PendingQty = Setdouble(grdRecord.Rows(e.RowIndex).Cells("PendingQty").Value)
                Total = Color1 + Color2 + Color3 + Color4 + Color5 + Color6 + Color7 + Color8
                'If EQty > PendingQty Then
                '   MessageBox.Show("PO Qty cannot be greater than Pending Qty.!", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                '   grdRecord.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = PendingQty
                '   EQty = PendingQty
                'End If
                grdTrimBreakup.Rows(e.RowIndex).Cells("Total").Value = Total
                'grdRecord.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = EQty
                'grdRecord.Rows(e.RowIndex).Cells(e.ColumnIndex + 1).Value = VRate
                'grdRecord.Rows(e.RowIndex).Cells("SaleTaxValue").Value = (Setdouble(grdRecord.Rows(e.RowIndex).Cells("Amount").Value) * SaleTaxPer) / 100
            End If
            If e.ColumnIndex = grdTrimBreakup.Columns("Color3").Index Then
                Color1 = Setdouble(grdTrimBreakup.Rows(e.RowIndex).Cells(e.ColumnIndex).Value)
                Color2 = Setdouble(grdTrimBreakup.Rows(e.RowIndex).Cells(e.ColumnIndex - 1).Value)
                Color3 = Setdouble(grdTrimBreakup.Rows(e.RowIndex).Cells(e.ColumnIndex - 2).Value)
                Color4 = Setdouble(grdTrimBreakup.Rows(e.RowIndex).Cells(e.ColumnIndex + 1).Value)
                Color5 = Setdouble(grdTrimBreakup.Rows(e.RowIndex).Cells(e.ColumnIndex + 2).Value)
                Color6 = Setdouble(grdTrimBreakup.Rows(e.RowIndex).Cells(e.ColumnIndex + 3).Value)
                Color7 = Setdouble(grdTrimBreakup.Rows(e.RowIndex).Cells(e.ColumnIndex + 4).Value)
                Color8 = Setdouble(grdTrimBreakup.Rows(e.RowIndex).Cells(e.ColumnIndex + 5).Value)
                'SaleTaxPer = Setdouble(grdRecord.Rows(e.RowIndex).Cells("SaleTaxPer").Value)
                'PendingQty = Setdouble(grdRecord.Rows(e.RowIndex).Cells("PendingQty").Value)
                Total = Color1 + Color2 + Color3 + Color4 + Color5 + Color6 + Color7 + Color8
                'If EQty > PendingQty Then
                '   MessageBox.Show("PO Qty cannot be greater than Pending Qty.!", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                '   grdRecord.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = PendingQty
                '   EQty = PendingQty
                'End If
                grdTrimBreakup.Rows(e.RowIndex).Cells("Total").Value = Total
                'grdRecord.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = EQty
                'grdRecord.Rows(e.RowIndex).Cells(e.ColumnIndex + 1).Value = VRate
                'grdRecord.Rows(e.RowIndex).Cells("SaleTaxValue").Value = (Setdouble(grdRecord.Rows(e.RowIndex).Cells("Amount").Value) * SaleTaxPer) / 100
            End If
            If e.ColumnIndex = grdTrimBreakup.Columns("Color4").Index Then
                Color1 = Setdouble(grdTrimBreakup.Rows(e.RowIndex).Cells(e.ColumnIndex).Value)
                Color2 = Setdouble(grdTrimBreakup.Rows(e.RowIndex).Cells(e.ColumnIndex - 1).Value)
                Color3 = Setdouble(grdTrimBreakup.Rows(e.RowIndex).Cells(e.ColumnIndex - 2).Value)
                Color4 = Setdouble(grdTrimBreakup.Rows(e.RowIndex).Cells(e.ColumnIndex - 3).Value)
                Color5 = Setdouble(grdTrimBreakup.Rows(e.RowIndex).Cells(e.ColumnIndex + 1).Value)
                Color6 = Setdouble(grdTrimBreakup.Rows(e.RowIndex).Cells(e.ColumnIndex + 2).Value)
                Color7 = Setdouble(grdTrimBreakup.Rows(e.RowIndex).Cells(e.ColumnIndex + 3).Value)
                Color8 = Setdouble(grdTrimBreakup.Rows(e.RowIndex).Cells(e.ColumnIndex + 4).Value)
                'SaleTaxPer = Setdouble(grdRecord.Rows(e.RowIndex).Cells("SaleTaxPer").Value)
                'PendingQty = Setdouble(grdRecord.Rows(e.RowIndex).Cells("PendingQty").Value)
                Total = Color1 + Color2 + Color3 + Color4 + Color5 + Color6 + Color7 + Color8
                'If EQty > PendingQty Then
                '   MessageBox.Show("PO Qty cannot be greater than Pending Qty.!", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                '   grdRecord.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = PendingQty
                '   EQty = PendingQty
                'End If
                grdTrimBreakup.Rows(e.RowIndex).Cells("Total").Value = Total
                'grdRecord.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = EQty
                'grdRecord.Rows(e.RowIndex).Cells(e.ColumnIndex + 1).Value = VRate
                'grdRecord.Rows(e.RowIndex).Cells("SaleTaxValue").Value = (Setdouble(grdRecord.Rows(e.RowIndex).Cells("Amount").Value) * SaleTaxPer) / 100
            End If
            If e.ColumnIndex = grdTrimBreakup.Columns("Color5").Index Then
                Color1 = Setdouble(grdTrimBreakup.Rows(e.RowIndex).Cells(e.ColumnIndex).Value)
                Color2 = Setdouble(grdTrimBreakup.Rows(e.RowIndex).Cells(e.ColumnIndex - 1).Value)
                Color3 = Setdouble(grdTrimBreakup.Rows(e.RowIndex).Cells(e.ColumnIndex - 2).Value)
                Color4 = Setdouble(grdTrimBreakup.Rows(e.RowIndex).Cells(e.ColumnIndex - 3).Value)
                Color5 = Setdouble(grdTrimBreakup.Rows(e.RowIndex).Cells(e.ColumnIndex - 4).Value)
                Color6 = Setdouble(grdTrimBreakup.Rows(e.RowIndex).Cells(e.ColumnIndex + 1).Value)
                Color7 = Setdouble(grdTrimBreakup.Rows(e.RowIndex).Cells(e.ColumnIndex + 2).Value)
                Color8 = Setdouble(grdTrimBreakup.Rows(e.RowIndex).Cells(e.ColumnIndex + 3).Value)
                'SaleTaxPer = Setdouble(grdRecord.Rows(e.RowIndex).Cells("SaleTaxPer").Value)
                'PendingQty = Setdouble(grdRecord.Rows(e.RowIndex).Cells("PendingQty").Value)
                Total = Color1 + Color2 + Color3 + Color4 + Color5 + Color6 + Color7 + Color8
                'If EQty > PendingQty Then
                '   MessageBox.Show("PO Qty cannot be greater than Pending Qty.!", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                '   grdRecord.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = PendingQty
                '   EQty = PendingQty
                'End If
                grdTrimBreakup.Rows(e.RowIndex).Cells("Total").Value = Total
                'grdRecord.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = EQty
                'grdRecord.Rows(e.RowIndex).Cells(e.ColumnIndex + 1).Value = VRate
                'grdRecord.Rows(e.RowIndex).Cells("SaleTaxValue").Value = (Setdouble(grdRecord.Rows(e.RowIndex).Cells("Amount").Value) * SaleTaxPer) / 100
            End If
            If e.ColumnIndex = grdTrimBreakup.Columns("Color6").Index Then
                Color1 = Setdouble(grdTrimBreakup.Rows(e.RowIndex).Cells(e.ColumnIndex).Value)
                Color2 = Setdouble(grdTrimBreakup.Rows(e.RowIndex).Cells(e.ColumnIndex - 1).Value)
                Color3 = Setdouble(grdTrimBreakup.Rows(e.RowIndex).Cells(e.ColumnIndex - 2).Value)
                Color4 = Setdouble(grdTrimBreakup.Rows(e.RowIndex).Cells(e.ColumnIndex - 3).Value)
                Color5 = Setdouble(grdTrimBreakup.Rows(e.RowIndex).Cells(e.ColumnIndex - 4).Value)
                Color6 = Setdouble(grdTrimBreakup.Rows(e.RowIndex).Cells(e.ColumnIndex - 5).Value)
                Color7 = Setdouble(grdTrimBreakup.Rows(e.RowIndex).Cells(e.ColumnIndex + 1).Value)
                Color8 = Setdouble(grdTrimBreakup.Rows(e.RowIndex).Cells(e.ColumnIndex + 2).Value)
                'SaleTaxPer = Setdouble(grdRecord.Rows(e.RowIndex).Cells("SaleTaxPer").Value)
                'PendingQty = Setdouble(grdRecord.Rows(e.RowIndex).Cells("PendingQty").Value)
                Total = Color1 + Color2 + Color3 + Color4 + Color5 + Color6 + Color7 + Color8
                'If EQty > PendingQty Then
                '   MessageBox.Show("PO Qty cannot be greater than Pending Qty.!", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                '   grdRecord.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = PendingQty
                '   EQty = PendingQty
                'End If
                grdTrimBreakup.Rows(e.RowIndex).Cells("Total").Value = Total
                'grdRecord.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = EQty
                'grdRecord.Rows(e.RowIndex).Cells(e.ColumnIndex + 1).Value = VRate
                'grdRecord.Rows(e.RowIndex).Cells("SaleTaxValue").Value = (Setdouble(grdRecord.Rows(e.RowIndex).Cells("Amount").Value) * SaleTaxPer) / 100
            End If
            If e.ColumnIndex = grdTrimBreakup.Columns("Color7").Index Then
                Color1 = Setdouble(grdTrimBreakup.Rows(e.RowIndex).Cells(e.ColumnIndex).Value)
                Color2 = Setdouble(grdTrimBreakup.Rows(e.RowIndex).Cells(e.ColumnIndex - 1).Value)
                Color3 = Setdouble(grdTrimBreakup.Rows(e.RowIndex).Cells(e.ColumnIndex - 2).Value)
                Color4 = Setdouble(grdTrimBreakup.Rows(e.RowIndex).Cells(e.ColumnIndex - 3).Value)
                Color5 = Setdouble(grdTrimBreakup.Rows(e.RowIndex).Cells(e.ColumnIndex - 4).Value)
                Color6 = Setdouble(grdTrimBreakup.Rows(e.RowIndex).Cells(e.ColumnIndex - 5).Value)
                Color7 = Setdouble(grdTrimBreakup.Rows(e.RowIndex).Cells(e.ColumnIndex - 6).Value)
                Color8 = Setdouble(grdTrimBreakup.Rows(e.RowIndex).Cells(e.ColumnIndex + 1).Value)
                'SaleTaxPer = Setdouble(grdRecord.Rows(e.RowIndex).Cells("SaleTaxPer").Value)
                'PendingQty = Setdouble(grdRecord.Rows(e.RowIndex).Cells("PendingQty").Value)
                Total = Color1 + Color2 + Color3 + Color4 + Color5 + Color6 + Color7 + Color8
                'If EQty > PendingQty Then
                '   MessageBox.Show("PO Qty cannot be greater than Pending Qty.!", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                '   grdRecord.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = PendingQty
                '   EQty = PendingQty
                'End If
                grdTrimBreakup.Rows(e.RowIndex).Cells("Total").Value = Total
                'grdRecord.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = EQty
                'grdRecord.Rows(e.RowIndex).Cells(e.ColumnIndex + 1).Value = VRate
                'grdRecord.Rows(e.RowIndex).Cells("SaleTaxValue").Value = (Setdouble(grdRecord.Rows(e.RowIndex).Cells("Amount").Value) * SaleTaxPer) / 100
            End If
            If e.ColumnIndex = grdTrimBreakup.Columns("Color8").Index Then
                Color1 = Setdouble(grdTrimBreakup.Rows(e.RowIndex).Cells(e.ColumnIndex).Value)
                Color2 = Setdouble(grdTrimBreakup.Rows(e.RowIndex).Cells(e.ColumnIndex - 1).Value)
                Color3 = Setdouble(grdTrimBreakup.Rows(e.RowIndex).Cells(e.ColumnIndex - 2).Value)
                Color4 = Setdouble(grdTrimBreakup.Rows(e.RowIndex).Cells(e.ColumnIndex - 3).Value)
                Color5 = Setdouble(grdTrimBreakup.Rows(e.RowIndex).Cells(e.ColumnIndex - 4).Value)
                Color6 = Setdouble(grdTrimBreakup.Rows(e.RowIndex).Cells(e.ColumnIndex - 5).Value)
                Color7 = Setdouble(grdTrimBreakup.Rows(e.RowIndex).Cells(e.ColumnIndex - 6).Value)
                Color8 = Setdouble(grdTrimBreakup.Rows(e.RowIndex).Cells(e.ColumnIndex - 7).Value)
                'SaleTaxPer = Setdouble(grdRecord.Rows(e.RowIndex).Cells("SaleTaxPer").Value)
                'PendingQty = Setdouble(grdRecord.Rows(e.RowIndex).Cells("PendingQty").Value)
                Total = Color1 + Color2 + Color3 + Color4 + Color5 + Color6 + Color7 + Color8
                'If EQty > PendingQty Then
                '   MessageBox.Show("PO Qty cannot be greater than Pending Qty.!", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                '   grdRecord.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = PendingQty
                '   EQty = PendingQty
                'End If
                grdTrimBreakup.Rows(e.RowIndex).Cells("Total").Value = Total
                'grdRecord.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = EQty
                'grdRecord.Rows(e.RowIndex).Cells(e.ColumnIndex + 1).Value = VRate
                'grdRecord.Rows(e.RowIndex).Cells("SaleTaxValue").Value = (Setdouble(grdRecord.Rows(e.RowIndex).Cells("Amount").Value) * SaleTaxPer) / 100
            End If
            TotalOrderQty()
        End If
    End Sub

    Private Sub cmbSizeType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSizeType.SelectedIndexChanged
        If cmbSizeType.SelectedIndex > 0 Then
            qry = "EXEC SpGet_ProdSaleOrderSizeQty  " & cmbSizeType.SelectedValue.ToString & "," & OrderID & ""
            txtAccessoryQty.Text = objCommon.ExecuteScalar(qry)
        End If

    End Sub

    Private Sub btnSaveOtherCharges_Click(sender As Object, e As EventArgs) Handles btnSaveOtherCharges.Click
        'SOTVID
        'OTVID
        'OTOrderID
        'OTVName
        'OTAmount
        Try
            objCommon.openConnection()
            For Each grid As DataGridViewRow In grdOtherCharges.Rows
                qryMain = "EXEC SpSave_ProdSaleOrderOTCharges " & grid.Cells("SOTVID").Value & "," & grid.Cells("OTVID").Value & "," & OrderID & "," & grid.Cells("OTVName").Value & ",'" & grid.Cells("OTAmount").Value & "' ," & G_UID & ",'" & G_IPAddress & "'," & G_UID & ",'" & G_IPAddress & "' "
                objCommon.ExecuteNonQueryWithOpen(qryMain)
            Next
            objCommon.CloseConnection()
            MessageBox.Show("Other Charges Saved", "Save Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch
            MessageBox.Show("Record Not Saved")
        Finally
            objCommon.CloseConnection()
        End Try
    End Sub

    Private Sub txtProdWorth_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtProdWorth.KeyPress
        Dim dotLength As Integer = 1
        dotLength = Me.txtProdWorth.Text.Split(".").Length
        If e.KeyChar <> ControlChars.Back Then
            If dotLength > 1 Then
                e.Handled = Not (Char.IsDigit(e.KeyChar))
            Else
                e.Handled = Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = ".")
            End If
        End If
    End Sub

    Private Sub txtProdCapacity_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtProdCapacity.KeyPress
        Dim dotLength As Integer = 1
        dotLength = Me.txtProdCapacity.Text.Split(".").Length
        If e.KeyChar <> ControlChars.Back Then
            If dotLength > 1 Then
                e.Handled = Not (Char.IsDigit(e.KeyChar))
            Else
                e.Handled = Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = ".")
            End If
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If txtVID.Text = "" Then
            Return
        End If
        MyListDic.Clear()
        rpt = (WinReportsApplication.Classess.ProductionReports.SetReportName("rptProdSaleOrderExpectedCost"))
        'FilterVTypeList = ""
        'FilterDate = ""
        ReportTitle = ""

        MyListDic.Add("@OrderID", txtVID.Text)
        MyListDic.Add("@UserID", txtVID.Text)
        MyListDic.Add("@CompanyID", txtVID.Text)
        MyListDic.Add("@FinancialYearID", txtVID.Text)
        ReportSpName = "SpGETProdSOAccessoryCost"
        dtrpt = objCommon.GetDataTableSPPrm(ReportSpName, MyListDic)

        MyListDic.Add("comp_Name", G_CompName)
        MyListDic.Add("ReportTitle", G_CompName)
        'MyListDic.Add("@cWhere", " where AH.VId = " & lblVID.Text)


        Dim MyReportViewer As ReportViewer = New ReportViewer
        MyReportViewer.dtrpt = dtrpt
        MyReportViewer.MyListDic = MyListDic
        MyReportViewer.rtp = rpt
        MyReportViewer.MdiParent = EMSMain
        MyReportViewer.Show()
    End Sub

    Private Sub FetchOldSOSizes()
        lblInformation.Text = ""
        If lblTempSOID.Text = 0 Then
            'ClearHead("") 
            Return
        End If
        Dim VType As String = "TBreakup"
        qryMain = "EXEC SpProdGetOrderSizes " & lblTempSOID.Text & ",'" & VType & "'"
        Dim dt As DataTable = objCommon.GetDataTable(qryMain)
        If IsNothing(dt) Then
            'EmptyFields()
            Return
        End If
        If dt.Rows.Count <= 0 Then
            'EmptyFields()
            Return
        End If

        For Each gridrow As DataGridViewRow In grdTrimBreakup.Rows
            For Each gridcell As DataGridViewColumn In grdTrimBreakup.Columns
                If gridcell.Index < 8 And gridrow.Index < dt.Rows.Count Then
                    If gridcell.Index > 1 And gridrow.Index > 0 Then
                        grdTrimBreakup(gridcell.Index, gridrow.Index).Value = dt.Rows(gridrow.Index)(gridcell.Index) * (1 + (Setdouble(txtCuttingAccessPer.Text) / 100))
                    ElseIf gridcell.Index = 1 Or gridrow.Index = 0 Then
                        grdTrimBreakup(gridcell.Index, gridrow.Index).Value = dt.Rows(gridrow.Index)(gridcell.Index)
                    End If

                    'grdRecord.Rows.Add(row)
                End If
            Next
        Next

        TotalOrderQty()
    End Sub

    Private Sub FillSaleOrderOTCharges()

        'SpGet_ProdSaleOrderOTCharges
        lblInformation.Text = ""
        If OrderID = 0 Then
            'btnClearAccessory()
            Return
        End If
        qryMain = "EXEC SpGet_ProdSaleOrderOTCharges " & OrderID & ""
        Dim dt As DataTable = objCommon.GetDataTable(qryMain)
        If IsNothing(dt) Then
            'EmptyFields()
            While (grdOtherCharges.Rows.Count >= 1)
                grdOtherCharges.Rows.RemoveAt(0)
            End While
            Return
        End If
        If dt.Rows.Count <= 0 Then
            'grdAccessory.DataSource = Nothing
            'grdAccessory.Rows.Clear()
            While (grdOtherCharges.Rows.Count >= 1)
                grdOtherCharges.Rows.RemoveAt(0)
            End While
            Return
        End If
        grdOtherCharges.DataSource = dt

    End Sub

End Class