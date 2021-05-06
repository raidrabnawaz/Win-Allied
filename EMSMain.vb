Public Class EMSMain
    Dim objCommon As New clsCommon
    Public VType As String
    Private Sub EMSMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        G_CURRENTDATE = Date.Now
        If G_CURRENTDATE > G_SOFTENDDATE Then
            End
      End If

        Try
            qryMain = FillGlobals()
            If qryMain <> "" Then
                MessageBox.Show(qryMain, G_APP_TITLE)
                End
            End If
            DisableResources()
        Catch ex As Exception
            MsgBox(ex.Message)
            End
        End Try

        If G_IsAudit = 0 Then
            Dim newMDIChild1 As New frmLogin1()
            newMDIChild1.MdiParent = Me
            newMDIChild1.Show()
        Else
            Dim newMDIChild As New frmLogin()
            newMDIChild.MdiParent = Me
            newMDIChild.Show()
        End If
    End Sub
#Region "File"
    Private Sub statusStrip1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles statusStrip1.Click
        G_CURRENTDATE = Date.Now
        If G_CURRENTDATE > G_SOFTENDDATE Then
            End
        End If
        If G_IsAuditor = 1 Then
         'If ActivateThisChild("frmLogin1") = False Then
         '    Dim newMDIChild As New frmLogin1()
         '    newMDIChild.MdiParent = Me
         '    newMDIChild.Show()
         'End If
        End If
    End Sub
    Private Sub MFileDatabaseBackup_Click(sender As System.Object, e As System.EventArgs) Handles MFileDatabaseBackup.Click
        G_CURRENTDATE = Date.Now
        If G_CURRENTDATE > G_SOFTENDDATE Then
            End
        End If
        If ActivateThisChild("frmDatabaseBackup") = False Then
            Dim newMDIChild As New frmDatabaseBackup()
            newMDIChild.Name = "frmDatabaseBackup"
            newMDIChild.MdiParent = Me
            newMDIChild.Show()
        End If
    End Sub

    Private Sub MIFileExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MIFileExit.Click
        G_CURRENTDATE = Date.Now
        If G_CURRENTDATE > G_SOFTENDDATE Then
            End
        End If
        End
    End Sub
#End Region
#Region "Setup"
    Private Sub MFileLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MFileLogin.Click
        If G_UID > 0 Then
            Dim myresult As Windows.Forms.DialogResult
            myresult = MessageBox.Show(Me, "Do you want to Log Off...", G_APP_TITLE, MessageBoxButtons.OKCancel)
            If myresult = Windows.Forms.DialogResult.Cancel Then
                Return
            End If
            G_UID = 0
            StatusValueUserName.Text = ""
            StatusValueTime.Text = ""
            DisableResources()
            If ActivateThisChild("frmLogin") = False Then
                Dim newMDIChild As New frmLogin()
                newMDIChild.MdiParent = Me
                newMDIChild.Show()
            End If
        Else
            If ActivateThisChild("frmLogin") = False Then
                Dim newMDIChild As New frmLogin()
                newMDIChild.MdiParent = Me
                newMDIChild.Show()
            End If
        End If

    End Sub
    Private Sub MFileChangePassword_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MFileChangePassword.Click
      'aaaaaaaaaaaaaaaaaa
      If ActivateThisChild("frmChangePassword") = False Then
         Dim newMDIChild As New frmChangePassword()
         newMDIChild.MdiParent = Me
         newMDIChild.Show()
      End If
    End Sub
    Private Sub MISetupReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MISetupReport.Click
        G_CURRENTDATE = Date.Now
        If G_CURRENTDATE > G_SOFTENDDATE Then
            End
        End If
        If ActivateThisChild("frmRptSetup") = False Then
            'Dim newMDIChild As New frmRptSetup()
            'newMDIChild.MdiParent = Me
            'newMDIChild.Show()
        End If
    End Sub
    Private Sub MIAccountsCOAGroups_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MIAccountsCOAGroups.Click
        If ActivateThisChild("frmCAOGroup") = False Then
            Dim newMDIChild As New frmCAOGroup()
            newMDIChild.MdiParent = Me
            newMDIChild.Show()
        End If
    End Sub
    Private Sub MIAccountsCOAHeads_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MIAccountsCOAHeads.Click
        If ActivateThisChild("frmCAOHead") = False Then
            Dim newMDIChild As New frmCAOHead()
            newMDIChild.MdiParent = Me
            newMDIChild.Show()
        End If
    End Sub
    Private Sub MIAccountsOpening_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MIAccountsOpening.Click
        If ActivateThisChild("frmAccountOpening") = False Then
            Dim newMDIChild As New frmVoucherPosting()
            newMDIChild.MdiParent = Me
            newMDIChild.Show()
        End If
    End Sub
    Private Sub MIAccountsCOA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MIAccountsCOA.Click
        If ActivateThisChild("frmCOA") = False Then
            Dim newMDIChild As New frmCOA()
            newMDIChild.MdiParent = Me
            newMDIChild.Show()
        End If
    End Sub

    Private Sub MIAccountsVoucherType_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MIAccountsVoucherType.Click
        If ActivateThisChild("frmInvVoucherType") = False Then
            Dim newMDIChild As New frmInvVoucherType()
            newMDIChild.MdiParent = Me
            newMDIChild.Show()
        End If
    End Sub
    Private Sub MTransAcEERType_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MTransAcEERType.Click
        If ActivateThisChild("frmACEERType") = False Then
            Dim newMDIChild As New frmACEERType()
            newMDIChild.MdiParent = Me
            newMDIChild.Show()
        End If
    End Sub

    Private Sub MIInventoryItemCategory_Click(sender As Object, e As EventArgs) Handles MIInventoryItemCategory.Click
        If ActivateThisChild("frmInvProductMainCategory") = False Then
            Dim newMDIChild As New frmInvProductMainCategory()
            newMDIChild.MdiParent = Me
            newMDIChild.Show()
        End If
    End Sub
    Private Sub MIInventoryItemUnit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MIInventoryItemUnit.Click
        If ActivateThisChild("frmInvItemUnit") = False Then
            Dim newMDIChild As New frmInvItemUnit()
            newMDIChild.MdiParent = Me
            newMDIChild.Show()
        End If
    End Sub
    Private Sub MIInventoryItemDetails_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MIInventoryItemDetails.Click
        If ActivateThisChild("frmInvProducts") = False Then
            Dim newMDIChild As New frmInvProducts()
            newMDIChild.MdiParent = Me
            newMDIChild.Show()
        End If
    End Sub
    Private Sub MIInvPaymentTerm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MIInvPaymentTerm.Click
        If ActivateThisChild("frmInvPaymentTerm") = False Then
            Dim newMDIChild As New frmInvPaymentTerm()
            newMDIChild.MdiParent = Me
            newMDIChild.Show()
        End If
    End Sub
    Private Sub MISupplierDetail_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MISupplierDetail.Click
        If ActivateThisChild("frmInvSupplier") = False Then
            Dim newMDIChild As New frmInvSupplier()
            newMDIChild.MdiParent = Me
            newMDIChild.Show()
        End If
    End Sub
    Private Sub MIInventoryOpening_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MIInventoryOpening.Click
        If ActivateThisChild("frmInvStockOpening") = False Then
            Dim newMDIChild As New frmInvStockOpening()
            newMDIChild.MdiParent = Me
            newMDIChild.Show()
        End If
    End Sub

    Private Sub MIInvStockAdjustment_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MIInvStockAdjustment.Click
        If ActivateThisChild("frmInvStockAdjustment") = False Then
            Dim newMDIChild As New frmInvStockAdjustment()
            newMDIChild.MdiParent = Me
            newMDIChild.Show()
        End If
    End Sub
    Private Sub MIAccountsCurrency_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MIAccountsCurrency.Click
        If ActivateThisChild("frmACCurrency") = False Then
            Dim newMDIChild As New frmACCurrency()
            newMDIChild.MdiParent = Me
            newMDIChild.Show()
        End If
    End Sub
    Private Sub MIAccountsFinancialYear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MIAccountsFinancialYear.Click
        If ActivateThisChild("frmACFinancialYear") = False Then
            Dim newMDIChild As New frmACFinancialYear()
            newMDIChild.MdiParent = Me
            newMDIChild.Show()
        End If
    End Sub
    Private Sub MIAccountsCompany_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MIAccountsCompany.Click
        If ActivateThisChild("frmCompany") = False Then
            Dim newMDIChild As New frmCompany()
            newMDIChild.MdiParent = Me
            newMDIChild.Show()
        End If
    End Sub
    Private Sub MIAccountGroup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MIAccountGroup.Click
        If ActivateThisChild("frmACAccountGroup") = False Then
            Dim newMDIChild As New frmACAccountGroup()
            newMDIChild.MdiParent = Me
            newMDIChild.Show()
        End If
    End Sub
    Private Sub MIAccountType_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MIAccountType.Click
        If ActivateThisChild("frmACAccountType") = False Then
            Dim newMDIChild As New frmACAccountType()
            newMDIChild.MdiParent = Me
            newMDIChild.Show()
        End If
    End Sub
#End Region

#Region "Gate Pass"
    Private Sub MIGPProductCategory_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MIGPProductCategory.Click
        If ActivateThisChild("frmGPProductCategory") = False Then
            Dim newMDIChild As New frmGPProductCategory()
            newMDIChild.MdiParent = Me
            newMDIChild.Show()
        End If
    End Sub

    Private Sub MIGPProductType_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MIGPProductType.Click
        If ActivateThisChild("frmGPProductType") = False Then
            Dim newMDIChild As New frmGPProductType()
            newMDIChild.MdiParent = Me
            newMDIChild.Show()
        End If
    End Sub

    Private Sub MIGPProductInfo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MIGPProductInfo.Click
        If ActivateThisChild("frmGPProductInformation") = False Then
            Dim newMDIChild As New frmGPProductInformation()
            newMDIChild.MdiParent = Me
            newMDIChild.Show()
        End If
    End Sub


    Private Sub MIGPUnitofMeasure_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MIGPUnitofMeasure.Click
        If ActivateThisChild("frmGPItemUnit") = False Then
            Dim newMDIChild As New frmProdShippingMethod()
            newMDIChild.MdiParent = Me
            newMDIChild.Show()
        End If
    End Sub
    Private Sub MIGPSupplier_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MIGPSupplier.Click
        If ActivateThisChild("frmGPSupplier") = False Then
            Dim newMDIChild As New frmGPSupplier()
            newMDIChild.MdiParent = Me
            newMDIChild.Show()
        End If
    End Sub

    Private Sub MIGPDepartment_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MIGPDepartment.Click
        If ActivateThisChild("frmGPDepartment") = False Then
            Dim newMDIChild As New frmGPDepartment()
            newMDIChild.MdiParent = Me
            newMDIChild.Show()
        End If
    End Sub


    Private Sub MITransOutwardGatePass_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MITransOutwardGatePass.Click
        If ActivateThisChild("frmOutwardGatePass") = False Then
            Dim newMDIChild As New frmOutwardGatePass()
            newMDIChild.MdiParent = Me
            newMDIChild.Show()
        End If
    End Sub
    Private Sub MTransGPInwardGatePass_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MTransGPInwardGatePass.Click
        If ActivateThisChild("frmGPInwardGatePass") = False Then
            Dim newMDIChild As New frmGPInwardGatePass()
            newMDIChild.MdiParent = Me
            newMDIChild.Show()
        End If
    End Sub
    Private Sub MTransOGPReturnable_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MTransOGPReturnable.Click
        If ActivateThisChild("frmOGPReturnable") = False Then
            Dim newMDIChild As New frmOGPReturnable()
            newMDIChild.MdiParent = Me
            newMDIChild.Show()
        End If
    End Sub
    Private Sub MTransIGPReturnable_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MTransIGPReturnable.Click
        If ActivateThisChild("frmIGPReturnable") = False Then
            Dim newMDIChild As New frmIGPReturnable()
            newMDIChild.MdiParent = Me
            newMDIChild.Show()
        End If
    End Sub
    Private Sub MTransOGPforIGP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MTransOGPforIGP.Click
        If ActivateThisChild("frmOGPforIGPReturnable") = False Then
            Dim newMDIChild As New frmOGPforIGPReturnable()
            newMDIChild.MdiParent = Me
            newMDIChild.Show()
        End If
    End Sub
    Private Sub MTransIGPforOGP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MTransIGPforOGP.Click
        If ActivateThisChild("frmIGPforOGPReturnable") = False Then
            Dim newMDIChild As New frmIGPforOGPReturnable()
            newMDIChild.MdiParent = Me
            newMDIChild.Show()
        End If
    End Sub


#End Region
#Region "Production"
    Private Sub ProdShippingMethod_Click(sender As Object, e As EventArgs) Handles ProdShippingMethod.Click
        If ActivateThisChild("ProdShipMehtod") = False Then
            Dim newMDIChild As New ProdShipMehtod()
            newMDIChild.MdiParent = Me
            newMDIChild.Show()
        End If
    End Sub

    Private Sub ProdProduction_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ProdProduction.Click
        If ActivateThisChild("frmProduction") = False Then
            Dim newMDIChild As New frmProduction()
            newMDIChild.MdiParent = Me
            newMDIChild.Show()
        End If
    End Sub


    Private Sub MTransSaleOrderClosing_Click(ByVal sender As Object, ByVal e As EventArgs) Handles MTransSaleOrderClosing.Click
        If ActivateThisChild("ProdOrderClosing") = False Then
            Dim newMDIChild As New ProdOrderClosing()
            newMDIChild.MdiParent = Me
            newMDIChild.Show()
        End If
    End Sub


    Private Sub MTransFaultCategory_Click(ByVal sender As Object, ByVal e As EventArgs) Handles MTransFaultCategory.Click
        If ActivateThisChild("ProdFaultCategory") = False Then
            Dim newMDIChild As New ProdFaultCategory()
            newMDIChild.MdiParent = Me
            newMDIChild.Show()
        End If
    End Sub


    Private Sub ProdDispatching_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ProdDispatching.Click
        If ActivateThisChild("frmProdDispatching") = False Then
            Dim newMDIChild As New frmProdDispatching()
            newMDIChild.MdiParent = Me
            newMDIChild.Show()
        End If
    End Sub


    Private Sub MTransHalls_Click(ByVal sender As Object, ByVal e As EventArgs) Handles MTransHalls.Click
        If ActivateThisChild("ProdHalls") = False Then
            Dim newMDIChild As New ProdHalls()
            newMDIChild.MdiParent = Me
            newMDIChild.Show()
        End If
    End Sub


    Private Sub MTransFaults_Click(ByVal sender As Object, ByVal e As EventArgs) Handles MTransFaults.Click
        If ActivateThisChild("ProdFault") = False Then
            Dim newMDIChild As New ProdFault()
            newMDIChild.MdiParent = Me
            newMDIChild.Show()
        End If
    End Sub


    Private Sub InvVendorReports_Click(ByVal sender As Object, ByVal e As EventArgs) Handles InvVendorReports.Click
        If ActivateThisChild("frmInvVendorReports") = False Then
            Dim newMDIChild As New frmInvVendorReports()
            newMDIChild.MdiParent = Me
            newMDIChild.Show()
        End If
    End Sub

    Private Sub ProdWagesReports_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ProdWagesReports.Click
        If ActivateThisChild("frmProdWagesReports") = False Then
            Dim newMDIChild As New frmProdWagesReports()
            newMDIChild.MdiParent = Me
            newMDIChild.Show()
        End If
    End Sub

    Private Sub ProdProductionReports_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ProdProductionReports.Click
        If ActivateThisChild("frmProductionReport") = False Then
            Dim newMDIChild As New frmProductionReport()
            newMDIChild.MdiParent = Me
            newMDIChild.Show()
        End If
    End Sub

    Private Sub ProdAccessoryType_Click(sender As Object, e As EventArgs) Handles ProdAccessoryType.Click
        If ActivateThisChild("ProdAccessoryType") = False Then
            Dim newMDIChild As New ProdAccessoryType()
            newMDIChild.MdiParent = Me
            newMDIChild.Show()
        End If
    End Sub

    Private Sub ProdAccessoryNature_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ProdAccessoryNature.Click
        If ActivateThisChild("ProdAccessoryNature") = False Then
            Dim newMDIChild As New ProdAccessoryNature()
            newMDIChild.MdiParent = Me
            newMDIChild.Show()
        End If
    End Sub

    Private Sub ProdBrand_Click(sender As Object, e As EventArgs) Handles ProdBrand.Click
        If ActivateThisChild("ProdBrand") = False Then
            Dim newMDIChild As New ProdBrand()
            newMDIChild.MdiParent = Me
            newMDIChild.Show()
        End If
    End Sub

    Private Sub ProdManufacturer_Click(sender As Object, e As EventArgs) Handles ProdManufacturer.Click
        If ActivateThisChild("ProdManufacturer") = False Then
            Dim newMDIChild As New ProdManufacturer()
            newMDIChild.MdiParent = Me
            newMDIChild.Show()
        End If
    End Sub

    Private Sub ProdPaymentTerm_Click(sender As Object, e As EventArgs) Handles ProdPaymentTerm.Click
        If ActivateThisChild("ProdPaymentTerm") = False Then
            Dim newMDIChild As New ProdPaymentTerm()
            newMDIChild.MdiParent = Me
            newMDIChild.Show()
        End If
    End Sub

    Private Sub ProdColor_Click(sender As Object, e As EventArgs) Handles ProdColor.Click
        If ActivateThisChild("ProdColor") = False Then
            Dim newMDIChild As New ProdColor()
            newMDIChild.MdiParent = Me
            newMDIChild.Show()
        End If
    End Sub

    Private Sub MTransHallsAllocation_Click(sender As Object, e As EventArgs) Handles MTransHallsAllocation.Click
        If ActivateThisChild("frmProdHallsAlocation") = False Then
            Dim newMDIChild As New frmProdHallsAlocation()
            newMDIChild.MdiParent = Me
            newMDIChild.Show()
        End If
    End Sub

    Private Sub ProdProductCategory_Click(sender As Object, e As EventArgs) Handles ProdProductCategory.Click
        If ActivateThisChild("ProdProductCategory") = False Then
            Dim newMDIChild As New ProdProductCategory()
            newMDIChild.MdiParent = Me
            newMDIChild.Show()
        End If
    End Sub

    Private Sub ProdProductNature_Click(sender As Object, e As EventArgs) Handles ProdProductNature.Click
        If ActivateThisChild("ProdProductNature") = False Then
            Dim newMDIChild As New ProdProductNature()
            newMDIChild.MdiParent = Me
            newMDIChild.Show()
        End If
    End Sub

    Private Sub ProdGSM_Click(sender As Object, e As EventArgs)
        If ActivateThisChild("ProdGSM") = False Then
            Dim newMDIChild As New ProdGSM()
            newMDIChild.MdiParent = Me
            newMDIChild.Show()
        End If
    End Sub

    Private Sub ProdFabricType_Click(sender As Object, e As EventArgs)
        If ActivateThisChild("ProdFabricType") = False Then
            Dim newMDIChild As New ProdFabricType()
            newMDIChild.MdiParent = Me
            newMDIChild.Show()
        End If
    End Sub

    Private Sub ProdFabricWidth_Click(sender As Object, e As EventArgs)
        If ActivateThisChild("ProdFabricWidth") = False Then
            Dim newMDIChild As New ProdFabricWidth()
            newMDIChild.MdiParent = Me
            newMDIChild.Show()
        End If
    End Sub

    Private Sub ProdStretchType_Click(sender As Object, e As EventArgs)
        If ActivateThisChild("ProdStretchType") = False Then
            Dim newMDIChild As New ProdStretchType()
            newMDIChild.MdiParent = Me
            newMDIChild.Show()
        End If
    End Sub

    Private Sub ProdWeaveType_Click(sender As Object, e As EventArgs)
        If ActivateThisChild("ProdWeaveType") = False Then
            Dim newMDIChild As New ProdWeaveType()
            newMDIChild.MdiParent = Me
            newMDIChild.Show()
        End If
    End Sub

    Private Sub ProdFabric_Click(sender As Object, e As EventArgs)
        If ActivateThisChild("ProdFabric") = False Then
            Dim newMDIChild As New ProdFabric()
            newMDIChild.MdiParent = Me
            newMDIChild.Show()
        End If
    End Sub
    Private Sub ProdProduct_Click(sender As Object, e As EventArgs) Handles ProdProduct.Click
        If ActivateThisChild("ProdProduct") = False Then
            Dim newMDIChild As New ProdProduct()
            newMDIChild.MdiParent = Me
            newMDIChild.Show()
        End If
    End Sub

    Private Sub ProdBuyer_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ProdBuyer.Click
        If ActivateThisChild("ProdBuyer") = False Then
            Dim newMDIChild As New ProdBuyer()
            newMDIChild.MdiParent = Me
            newMDIChild.Show()
        End If
    End Sub

    Private Sub ProdCustomer_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ProdCustomer.Click
        If ActivateThisChild("ProdCustomer") = False Then
            Dim newMDIChild As New ProdCustomer()
            newMDIChild.MdiParent = Me
            newMDIChild.Show()
        End If
    End Sub


    Private Sub MTransProdWagesMonth_Click(ByVal sender As Object, ByVal e As EventArgs) Handles MTransProdWagesMonth.Click
        If ActivateThisChild("ProdWagesMonth") = False Then
            Dim newMDIChild As New ProdWagesMonth()
            newMDIChild.MdiParent = Me
            newMDIChild.Show()
        End If
    End Sub


    Private Sub ProdSaleOrder_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ProdSaleOrder.Click
        If ActivateThisChild("ProdSaleOrder") = False Then
            Dim newMDIChild As New ProdSaleOrder()
            newMDIChild.MdiParent = Me
            newMDIChild.Show()
        End If
    End Sub

    Private Sub ProdSaleOrderAccessoryCost_Click(ByVal sender As Object, ByVal e As EventArgs)
        If ActivateThisChild("ProdSaleOrderExpectedCost") = False Then
            Dim newMDIChild As New ProdSaleOrderExpectedCost()
            newMDIChild.MdiParent = Me
            newMDIChild.Show()
        End If
    End Sub

    Private Sub ProdOperationCategory_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ProdOperationCategory.Click
        If ActivateThisChild("ProdOperationCategory") = False Then
            Dim newMDIChild As New ProdOperationCategory()
            newMDIChild.MdiParent = Me
            newMDIChild.Show()
        End If
    End Sub

    Private Sub ProdOperationSetType_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ProdOperationSetType.Click
        If ActivateThisChild("ProdOperationSetType") = False Then
            Dim newMDIChild As New ProdOperationSetType()
            newMDIChild.MdiParent = Me
            newMDIChild.Show()
        End If
    End Sub

    Private Sub ProdOperations_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ProdOperations.Click
        If ActivateThisChild("ProdOperations") = False Then
            Dim newMDIChild As New ProdOperations()
            newMDIChild.MdiParent = Me
            newMDIChild.Show()
        End If
    End Sub

    Private Sub ProdOperationsSet_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ProdOperationsSet.Click
        If ActivateThisChild("frmProdOperationsSet") = False Then
            Dim newMDIChild As New frmProdOperationsSet()
            newMDIChild.MdiParent = Me
            newMDIChild.Show()
        End If
    End Sub

    Private Sub ProdSaleOrderOperations_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ProdSaleOrderOperations.Click
        If ActivateThisChild("ProdSaleOrderOperations") = False Then
            Dim newMDIChild As New ProdSaleOrderOperations()
            newMDIChild.MdiParent = Me
            newMDIChild.Show()
        End If
    End Sub

    Private Sub ProdWagesEntry_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ProdWagesEntry.Click
        If ActivateThisChild("ProdWagesEntry") = False Then
            Dim newMDIChild As New ProdWagesEntry()
            newMDIChild.MdiParent = Me
            newMDIChild.Show()
        End If
    End Sub

    Private Sub ProdEidtOrderWages_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ProdEidtOrderWages.Click
        If ActivateThisChild("frmProdWagesEntryEdit") = False Then
            Dim newMDIChild As New frmProdWagesEntryEdit()
            newMDIChild.MdiParent = Me
            newMDIChild.Show()
        End If
    End Sub

    Private Sub ProdWagesMonth_Click(ByVal sender As Object, ByVal e As EventArgs)
        'If ActivateThisChild("ProdWagesMonth") = False Then
        '   Dim newMDIChild As New ProdWagesMonth()
        '   newMDIChild.MdiParent = Me
        '   newMDIChild.Show()
        'End If
    End Sub

    Private Sub ProdWagesOrder_Click(ByVal sender As Object, ByVal e As EventArgs)
        If ActivateThisChild("ProdWagesOrder") = False Then
            Dim newMDIChild As New ProdWagesOrder()
            newMDIChild.MdiParent = Me
            newMDIChild.Show()
        End If
    End Sub


    Private Sub InvSupplierAdvance_Click(ByVal sender As Object, ByVal e As EventArgs) Handles InvSupplierAdvance.Click
        If ActivateThisChild("frmInvSupplierAdvance") = False Then
            Dim newMDIChild As New frmInvSupplierAdvance()
            newMDIChild.MdiParent = Me
            newMDIChild.Show()
        End If
    End Sub


    Private Sub MTransSupplierDrCrNote_Click(ByVal sender As Object, ByVal e As EventArgs) Handles MTransSupplierDrCrNote.Click
        If ActivateThisChild("frmSupplierDebitCreditNotes") = False Then
            Dim newMDIChild As New frmSupplierDebitCreditNotes()
            newMDIChild.MdiParent = Me
            newMDIChild.Show()
        End If
    End Sub


#End Region

#Region "User Rights"

    Private Sub MTransUsers_Click(ByVal sender As Object, ByVal e As EventArgs) Handles MTransUsers.Click
        If ActivateThisChild("frmSecUser") = False Then
            Dim newMDIChild As New frmSecUser()
            newMDIChild.MdiParent = Me
            newMDIChild.Show()
        End If
    End Sub


    Private Sub MTransUserRights_Click(ByVal sender As Object, ByVal e As EventArgs) Handles MTransUserRights.Click
        If ActivateThisChild("frmSecGroupPages") = False Then
            Dim newMDIChild As New frmSecGroupPages()
            newMDIChild.MdiParent = Me
            newMDIChild.Show()
        End If
    End Sub


    Private Sub MTransUserRolesPages_Click(ByVal sender As Object, ByVal e As EventArgs) Handles MTransUserRolesPages.Click
        If ActivateThisChild("frmGroupPages") = False Then
            Dim newMDIChild As New frmGroupPages()
            newMDIChild.MdiParent = Me
            newMDIChild.Show()
        End If
    End Sub


    Private Sub MTransUserRoles_Click(ByVal sender As Object, ByVal e As EventArgs) Handles MTransUserRoles.Click
        If ActivateThisChild("frmGroup") = False Then
            Dim newMDIChild As New frmGroup()
            newMDIChild.MdiParent = Me
            newMDIChild.Show()
        End If
    End Sub

    Private Sub MTransBackDateClosing_Click(ByVal sender As Object, ByVal e As EventArgs) Handles MTransBackDateClosing.Click
        If ActivateThisChild("frmBackDateClosing") = False Then
            Dim newMDIChild As New frmBackDateClosing()
            newMDIChild.MdiParent = Me
            newMDIChild.Show()
        End If
    End Sub



#End Region

#Region "Entry"

    Private Sub MTransProduction_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If ActivateThisChild("frmACProduction") = False Then
            Dim newMDIChild As New frmACProduction()
            newMDIChild.MdiParent = Me
            newMDIChild.Show()
        End If
    End Sub
    Private Sub MTransSale_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If ActivateThisChild("frmACSales") = False Then
            Dim newMDIChild As New frmSalesReceipt()
            newMDIChild.MdiParent = Me
            newMDIChild.Show()
        End If
    End Sub
    Private Sub MTransCollection_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MTransCollection.Click
        If ActivateThisChild("frmACCollection") = False Then
            Dim newMDIChild As New frmACCollection()
            newMDIChild.MdiParent = Me
            newMDIChild.Show()
        End If
    End Sub
    Private Sub MTransExpanse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MTransExpanse.Click
        If ActivateThisChild("frmACExpanse") = False Then
            Dim newMDIChild As New frmACExpanse()
            newMDIChild.MdiParent = Me
            newMDIChild.Show()
        End If
    End Sub

    Private Sub MTransJV_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MTransJV.Click
        If ActivateThisChild("frmACJournalVoucher") = True Then
            ActiveMdiChild.Close()
            VType = "JV"
            Dim newMDIChild As New frmACJournalVoucher()
            newMDIChild.MdiParent = Me
            newMDIChild.Show()
        Else
            VType = "JV"
            Dim newMDIChild As New frmACJournalVoucher()
            newMDIChild.MdiParent = Me
            newMDIChild.Show()
        End If
    End Sub

    Private Sub MTransBPV_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MTransBPV.Click
        If ActivateThisChild("frmCPVSimpleNew") = True Then
            ActiveMdiChild.Close()
            VType = "BPV"
            Dim newMDIChild As New frmCPVSimpleNew()
            'If ActivateThisChild("frmACBPV") = False Then
            '    Dim newMDIChild As New frmACBPV()
            newMDIChild.MdiParent = Me
            newMDIChild.Show()
        Else
            VType = "BPV"
            Dim newMDIChild As New frmCPVSimpleNew()
            newMDIChild.MdiParent = Me
            newMDIChild.Show()

        End If
    End Sub

    Private Sub MTransBRV_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MTransBRV.Click
        If ActivateThisChild("frmCPVSimpleNew") = True Then
            ActiveMdiChild.Close()
            VType = "BRV"
            Dim newMDIChild As New frmCPVSimpleNew()
            'If ActivateThisChild("frmACBRV") = False Then
            '    Dim newMDIChild As New frmACBRV()
            newMDIChild.MdiParent = Me
            newMDIChild.Show()
        Else
            VType = "BRV"
            Dim newMDIChild As New frmCPVSimpleNew()
            newMDIChild.MdiParent = Me
            newMDIChild.Show()
        End If
    End Sub

    Private Sub MTransCPV_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MTransCPV.Click
        If ActivateThisChild("frmCPVSimpleNew") = True Then
            ActiveMdiChild.Close()
            VType = "CPV"
            Dim newMDIChild As New frmCPVSimpleNew()
            newMDIChild.MdiParent = Me
            newMDIChild.Show()
        Else
            VType = "CPV"
            Dim newMDIChild As New frmCPVSimpleNew()
            newMDIChild.MdiParent = Me
            newMDIChild.Show()
        End If
    End Sub

    Private Sub MTransCRV_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MTransCRV.Click
        If ActivateThisChild("frmCPVSimpleNew") = True Then
            ActiveMdiChild.Close()
            VType = "CRV"
            Dim newMDIChild As New frmCPVSimpleNew()
            newMDIChild.MdiParent = Me
            newMDIChild.Show()
        Else
            VType = "CRV"
            Dim newMDIChild As New frmCPVSimpleNew()
            newMDIChild.MdiParent = Me
            newMDIChild.Show()
        End If

    End Sub

    'Private Sub MTransCPVSimple_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MTransCPVSimple.Click
    '    If ActivateThisChild("frmACCPVSimple") = True Then
    '        ActiveMdiChild.Close()
    '        VType = "FCPV"
    '        Dim newMDIChild As New frmACCPVSimple()
    '        newMDIChild.MdiParent = Me
    '        newMDIChild.Show()
    '    Else
    '        VType = "FCPV"
    '        Dim newMDIChild As New frmACCPVSimple()
    '        newMDIChild.MdiParent = Me
    '        newMDIChild.Show()
    '    End If
    'End Sub

    'Private Sub MTransCRVSimple_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MTransCRVSimple.Click
    '    If ActivateThisChild("frmACCPVSimple") = True Then
    '        ActiveMdiChild.Close()
    '        VType = "FCRV"
    '        Dim newMDIChild As New frmACCPVSimple()
    '        newMDIChild.MdiParent = Me
    '        newMDIChild.Show()
    '    Else
    '        VType = "FCRV"
    '        Dim newMDIChild As New frmACCPVSimple()
    '        newMDIChild.MdiParent = Me
    '        newMDIChild.Show()
    '    End If
    'End Sub

    'Private Sub MTransBPVSimple_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MTransBPVSimple.Click
    '    If ActivateThisChild("frmACBPVSimple") = False Then
    '        VType = "FBPV"
    '        Dim newMDIChild As New frmACBPVSimple()
    '        newMDIChild.MdiParent = Me
    '        newMDIChild.Show()
    '    End If
    'End Sub


    Private Sub MTransAccBPVSimple_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MTransAccBPVSimple.Click
        If ActivateThisChild("frmBPVSimpleNew") = False Then
            VType = "FBPV"
            Dim newMDIChild As New frmBPVSimpleNew()
            newMDIChild.MdiParent = Me
            newMDIChild.Show()
        End If
    End Sub

    Private Sub MTransAccBRVSimple_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MTransAccBRVSimple.Click
        If ActivateThisChild("frmBPVSimpleNew") = False Then
            VType = "FBRV"
            Dim newMDIChild As New frmBPVSimpleNew()
            newMDIChild.MdiParent = Me
            newMDIChild.Show()
        End If
    End Sub

    Private Sub MTransAccCRVSimple_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MTransAccCRVSimple.Click
        If ActivateThisChild("frmCPVSimpleNew") = False Then
            VType = "FCRV"
            Dim newMDIChild As New frmCPVSimpleNew()
            newMDIChild.MdiParent = Me
            newMDIChild.Show()
        End If
    End Sub

    Private Sub MTransAccCPVSimple_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MTransAccCPVSimple.Click
        If ActivateThisChild("frmCPVSimpleNew") = False Then
            VType = "FCPV"
            Dim newMDIChild As New frmCPVSimpleNew()
            newMDIChild.MdiParent = Me
            newMDIChild.Show()
        End If
    End Sub


    Private Sub MTransVoucherPosting_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MTransVoucherPosting.Click
        If ActivateThisChild("frmPDCVoucherPosting") = False Then
            Dim newMDIChild As New frmPDCVoucherPosting()
            newMDIChild.MdiParent = Me
            newMDIChild.Show()
        End If
    End Sub

    Private Sub MTransJVMultiCurrency_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MTransJVMultiCurrency.Click
        If ActivateThisChild("frmACJVMultiCurrency") = False Then
            VType = "JV"
            Dim newMDIChild As New frmACJVMultiCurrency()
            newMDIChild.MdiParent = Me
            newMDIChild.Show()
        End If
    End Sub

    Private Sub MTransCPVMultiCurrency_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MTransCPVMultiCurrency.Click
        If ActivateThisChild("frmACCPVCSimpleMultiCurrency") = False Then
            VType = "FCPV"
            Dim newMDIChild As New frmACCPVCSimpleMultiCurrency()
            newMDIChild.MdiParent = Me
            newMDIChild.Show()
        End If
    End Sub

    'Private Sub MTransBRVSimple_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MTransBRVSimple.Click
    '    If ActivateThisChild("frmACBPVSimple") = False Then
    '        VType = "FBRV"
    '        Dim newMDIChild As New frmACBPVSimple()
    '        newMDIChild.MdiParent = Me
    '        newMDIChild.Show()
    '    End If
    'End Sub

    Private Sub MTransJVMultipal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If ActivateThisChild("frmACGL") = False Then
            Dim newMDIChild As New frmACJournalVoucher()
            newMDIChild.MdiParent = Me
            newMDIChild.Show()
        End If
    End Sub
    Private Sub MTransMDN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MTransMDN.Click
        If ActivateThisChild("frmInvMDN") = False Then
            Dim newMDIChild As New frmInvMDN()
            newMDIChild.MdiParent = Me

            newMDIChild.Show()
        End If
    End Sub
    Private Sub MTransIssueNote_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MTransIssueNote.Click
        If ActivateThisChild("frmInvIssueNote1") = False Then
            Dim newMDIChild As New frmInvIssueNote1()
            newMDIChild.MdiParent = Me
            newMDIChild.Show()
        End If
    End Sub
    Private Sub MTransIssueNoteReturn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MTransIssueNoteReturn.Click
        If ActivateThisChild("frmInvIssueNoteReturn") = False Then
            Dim newMDIChild As New frmInvIssueNoteReturn()
            newMDIChild.MdiParent = Me
            newMDIChild.Show()
        End If
    End Sub
    Private Sub MTransPurchaseOrder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MTransPurchaseOrder.Click
        If ActivateThisChild("frmInvPurchaseOrder") = False Then
            Dim newMDIChild As New frmInvPurchaseOrder()
            newMDIChild.MdiParent = Me
            newMDIChild.Show()
        End If
    End Sub
    Private Sub MTransInwardGatePass_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MTransInwardGatePass.Click
        If ActivateThisChild("frmInvInwardGatePass") = False Then
            Dim newMDIChild As New frmInvInwardGatePass()
            newMDIChild.MdiParent = Me
            newMDIChild.Show()
        End If
    End Sub
    Private Sub MTransGoodsReceiptNote_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MTransGoodsReceiptNote.Click
        If ActivateThisChild("frmInvGoodsReceiptNote") = False Then
            Dim newMDIChild As New frmInvGoodsReceiptNote()
            newMDIChild.MdiParent = Me
            newMDIChild.Show()
        End If
    End Sub
    Private Sub MTransGRNReturn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MTransGRNReturn.Click
        If ActivateThisChild("frmInvGRNReturn") = False Then
            Dim newMDIChild As New frmInvGRNReturn()
            newMDIChild.MdiParent = Me
            newMDIChild.Show()
        End If
    End Sub

    Private Sub MTransDirectPurchase_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MTransDirectPurchase.Click
        If ActivateThisChild("frmInvDirectPurchase") = False Then
            Dim newMDIChild As New frmInvDirectPurchase()
            newMDIChild.MdiParent = Me
            newMDIChild.Show()
        End If
    End Sub

    Private Sub MTransDirectPurchaseReturn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MTransDirectPurchaseReturn.Click
        If ActivateThisChild("frmInvDirectPurchaseReturn") = False Then
            Dim newMDIChild As New frmInvDirectPurchaseReturn()
            newMDIChild.MdiParent = Me
            newMDIChild.Show()
        End If
    End Sub


    Private Sub MTransYarnOGP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MTransYarnOGP.Click
        If ActivateThisChild("frmInvYarnOGP") = False Then
            Dim newMDIChild As New frmInvYarnOGP()
            newMDIChild.MdiParent = Me
            newMDIChild.Show()
        End If
    End Sub

    Private Sub MTransFabricIGP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MTransFabricIGP.Click
        If ActivateThisChild("frmInvFabricIGP") = False Then
            Dim newMDIChild As New frmInvFabricIGP()
            newMDIChild.MdiParent = Me
            newMDIChild.Show()
        End If
    End Sub

    Private Sub MTransFabricOGP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MTransFabricOGP.Click
        If ActivateThisChild("frmInvFabricOGP") = False Then
            Dim newMDIChild As New frmInvFabricOGP()
            newMDIChild.MdiParent = Me
            newMDIChild.Show()
        End If
    End Sub


    Private Sub MTransFabricIGPDyeing_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MTransFabricIGPDyeing.Click
        If ActivateThisChild("frmInvFabricIGPDyeing") = False Then
            Dim newMDIChild As New frmInvFabricIGPDyeing()
            newMDIChild.MdiParent = Me
            newMDIChild.Show()
        End If
    End Sub


    Private Sub MTransYarnOGPPOsting_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MTransYarnOGPPOsting.Click
        If ActivateThisChild("frmInvYarnIGPPosting") = False Then
            Dim newMDIChild As New frmInvYarnIGPPosting()
            newMDIChild.MdiParent = Me
            newMDIChild.Show()
        End If
    End Sub



    Private Sub MTransFabricOGPPosting_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MTransFabricOGPPosting.Click
        If ActivateThisChild("frmFabricOGPPosting") = False Then
            Dim newMDIChild As New frmFabricOGPPosting()
            newMDIChild.MdiParent = Me
            newMDIChild.Show()
        End If
    End Sub



    Private Sub MTransInvGRNPosting_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MTransInvGRNPosting.Click
        If ActivateThisChild("frmInvGRNPosting") = False Then
            Dim newMDIChild As New frmInvGRNPosting()
            newMDIChild.MdiParent = Me
            newMDIChild.Show()
        End If
    End Sub

    Private Sub MTransMDNtoPIV_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MTransMDNtoPIV.Click
        If ActivateThisChild("frmInvMDNtoPIV") = False Then
            Dim newMDIChild As New frmInvMDNtoPIV()
            newMDIChild.MdiParent = Me
            newMDIChild.Show()
        End If
    End Sub

    Private Sub MTransPartialCancellation_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MTransPartialCancellation.Click
        If ActivateThisChild("frmInvPartialCancel") = False Then
            Dim newMDIChild As New frmInvPartialCancel()
            newMDIChild.MdiParent = Me
         newMDIChild.Show()
      End If
   End Sub

   Private Sub InvSupplierPayment_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InvSupplierPayment.Click
      If ActivateThisChild("frmInvSupplierPayment1") = False Then
         Dim newMDIChild As New frmInvSupplierPayment1()
         newMDIChild.MdiParent = Me
         newMDIChild.Show()
      End If
   End Sub


    Private Sub MTransQuotation_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MTransQuotation.Click
        If ActivateThisChild("frmSaleQuotation") = False Then
            Dim newMDIChild As New frmSaleQuotation()
            newMDIChild.MdiParent = Me
            newMDIChild.Show()
        End If
    End Sub

    Private Sub MTransSalesInvoice_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MTransSalesInvoice.Click
        If ActivateThisChild("frmSaleInvoice") = False Then
            Dim newMDIChild As New frmSaleInvoice()
            newMDIChild.MdiParent = Me
            newMDIChild.Show()
        End If
    End Sub

    Private Sub MTransSaleServiceInvoice_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MTransSaleServiceInvoice.Click
        If ActivateThisChild("frmSaleServiceInvoice") = False Then
            Dim newMDIChild As New frmSaleServiceInvoice()
            newMDIChild.MdiParent = Me
            newMDIChild.Show()
        End If
    End Sub

    Private Sub MTransSaleExport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MTransSaleExport.Click
        If ActivateThisChild("frmSaleInvoiceExport") = False Then
            Dim newMDIChild As New frmSaleInvoiceExport()
            newMDIChild.MdiParent = Me
            newMDIChild.Show()
        End If
    End Sub
    Private Sub MTransSlaesReceipt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MTransSlaesReceipt.Click
      If ActivateThisChild("frmSalesReceipt") = False Then
         Dim newMDIChild As New frmSalesReceipt()
         newMDIChild.MdiParent = Me
         newMDIChild.Show()
      End If
   End Sub

    Private Sub MISaleCustomer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MISaleCustomer.Click
        If ActivateThisChild("frmSaleCustomer") = False Then
            Dim newMDIChild As New frmSaleCustomer()
            newMDIChild.MdiParent = Me
            newMDIChild.Show()
        End If
    End Sub

    Private Sub MTransCustomerAdvance_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MTransCustomerAdvance.Click
        If ActivateThisChild("frmInvCustomerAdvance") = False Then
            Dim newMDIChild As New frmInvCustomerAdvance()
            newMDIChild.MdiParent = Me
            newMDIChild.Show()
        End If
    End Sub

    Private Sub MTransCustomerDrCrNote_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MTransCustomerDrCrNote.Click
        If ActivateThisChild("frmCustomerDebitCreditNotes") = False Then
            Dim newMDIChild As New frmCustomerDebitCreditNotes()
            newMDIChild.MdiParent = Me
            newMDIChild.Show()
        End If
    End Sub


    Private Sub MTransCustomerClearance_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MTransCustomerClearance.Click
        If ActivateThisChild("frmSaleCustomerClearance") = False Then
            Dim newMDIChild As New frmSaleCustomerClearance()
            newMDIChild.MdiParent = Me
            newMDIChild.Show()
        End If
    End Sub


#End Region
#Region "Reports"
    Private Sub MReportDetails_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MReportDetails.Click
      If ActivateThisChild("frmRptDetails") = False Then
         Dim newMDIChild As New frmRptAccountsDetails()
         newMDIChild.MdiParent = Me
         newMDIChild.Show()
      End If
   End Sub
   Private Sub AccDocumentView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AccDocumentView.Click
      If ActivateThisChild("frmAccDocumentView") = False Then
         Dim newMDIChild As New frmAccDocumentView()
         newMDIChild.MdiParent = Me
         newMDIChild.Show()
      End If
   End Sub

   Private Sub InvStock_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles frmInvStockLedger.Click
      If ActivateThisChild("frmInvStockLedger") = False Then
         Dim newMDIChild As New frmInvStockLedger()
         newMDIChild.MdiParent = Me
         newMDIChild.Show()
      End If
   End Sub


#End Region
#Region "General Functions"
   Private Function ActivateThisChild(ByVal formName As String) As Boolean
      Dim i As Integer
      For i = 0 To Me.MdiChildren.Length - 1
         If Me.MdiChildren(i).Name = formName Then
            Me.MdiChildren(i).Activate()
            Return True
         End If
      Next
      Return False
   End Function
   Public Sub EnableResources()
      If G_IsAdmin = 1 Then
         For Each _control As Object In Me.Controls
            If TypeOf (_control) Is MenuStrip Then
               For Each itm As ToolStripMenuItem In _control.items
                  itm.Visible = True
                  For Each child As Object In itm.DropDownItems
                     If G_IsAuditor = 1 Then
                        If child.Tag = "Audit" Then
                           child.Visible = False
                        Else
                           child.Visible = True
                           If TypeOf (child) Is ToolStripMenuItem Then
                              Dim subMenu As ToolStripMenuItem = child
                              If (subMenu.HasDropDownItems) Then
                                 For Each subChild As Object In subMenu.DropDownItems
                                    If subChild.Tag = "Audit" Then
                                       subChild.Visible = False
                                    Else
                                       subChild.Visible = True
                                    End If 
                                 Next 
                                 'Else ' Do the desired operations here. 
                                 'subMenu.Visible = True
                              End If
                           End If
                           End If
                     Else
                        child.Visible = True
                     End If
                  Next
               Next
            End If
         Next
         Me.MFileLogin.Text = "Log off"
         Return
      End If

      Dim dr(), drr() As DataRow
      G_Dt_Rights = objCommon.LoadResources(G_UID)
      If IsNothing(G_Dt_Rights) Then
         Return
      End If
      If G_Dt_Rights.Rows.Count <= 0 Then
         Return
      End If
      For Each _control As Object In Me.Controls
         If TypeOf (_control) Is MenuStrip Then
            For Each itm As ToolStripMenuItem In _control.items
               dr = G_Dt_Rights.Select("MenuName ='" & itm.Name & "'", "")
               If dr.Length > 0 Then
                  If dr(0)("IsView") = False Then
                     If itm.Tag = "Open" Then
                        itm.Visible = True
                     Else
                        itm.Visible = False
                     End If
                  Else
                     itm.Visible = True
                     For Each child As Object In itm.DropDownItems
                        dr = G_Dt_Rights.Select("MenuName ='" & child.Name & "'", "")
                        If dr.Length > 0 Then
                           If dr(0)("IsView") = False Then
                              If child.Tag = "Open" Then
                                 child.Visible = True
                                 
                              Else
                                 child.Visible = False
                              End If
                           Else
                              'If G_IsAuditor = 1 Then
                              If child.Tag = "Audit" Then
                                 child.Visible = False
                              Else
                                 child.Visible = True
                                 If TypeOf (child) Is ToolStripMenuItem Then
                                    Dim subMenu As ToolStripMenuItem = child
                                    If (subMenu.HasDropDownItems) Then
                                       For Each subChild As Object In subMenu.DropDownItems
                                          drr = G_Dt_Rights.Select("MenuName ='" & subChild.Name & "'", "")
                                          If drr.Length > 0 Then
                                             If drr(0)("IsView") = False Then
                                                subChild.Visible = False
                                             Else
                                                subChild.Visible = True
                                             End If 
                                          End If
                                          If child.Tag = "Audit" Then
                                             subChild.Visible = False
                                          End If
                                       Next
                                       'Else ' Do the desired operations here. 
                                       'subMenu.Visible = True
                                    End If
                                 End If
                              End If
                              'Else
                              '   child.Visible = True
                              '   If TypeOf (child) Is ToolStripMenuItem Then
                              '      Dim subMenu As ToolStripMenuItem = child
                              '      If (subMenu.HasDropDownItems) Then
                              '         For Each subChild As Object In subMenu.DropDownItems
                              '            drr = G_Dt_Rights.Select("MenuName ='" & subChild.Name & "'", "")
                              '            If drr.Length > 0 Then
                              '               If drr(0)("IsView") = False Then
                              '                  subChild.Visible = False
                              '               Else
                              '                  subChild.Visible = True
                              '               End If

                              '            End If
                              '            If child.Tag = "Audit" Then
                              '               subChild.Visible = False
                              '            End If
                              '         Next
                              '         'Else ' Do the desired operations here. 
                              '         'subMenu.Visible = True
                              '      End If
                              '   End If
                              'End If
                           End If
                        Else
                           If child.Tag = "Open" Then
                              child.Visible = True
                           Else
                              child.Visible = False
                           End If
                           End If
                     Next
                  End If
               Else
                  If itm.Tag = "Open" Then
                     itm.Visible = True
                  Else
                     itm.Visible = False
                  End If
               End If
            Next
         End If
      Next
      Me.MFileLogin.Text = "Log off"
   End Sub
   Public Sub DisableResources()
      'means at application loading
      'set visible =false all menu other then with tag Open
      For Each _control As Object In Me.Controls
         If TypeOf (_control) Is MenuStrip Then
            For Each itm As ToolStripMenuItem In _control.items
               If itm.Tag <> "Open" Then
                  itm.Visible = False
               End If
               For Each child As Object In itm.DropDownItems
                  If child.Tag <> "Open" Then
                     child.Visible = False
                  End If
               Next
            Next
         End If
      Next
      Me.MFileLogin.Text = "Login"
   End Sub




#End Region
#Region "Tempo"

#End Region


    Private Sub PDCVoucherUnPostingToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PDCVoucherUnPostingToolStripMenuItem.Click
      If ActivateThisChild("frmPDCVoucherUnposting") = False Then
         Dim newMDIChild As New frmPDCVoucherUnposting()
         newMDIChild.MdiParent = Me
         newMDIChild.Show()
      End If
   End Sub

   Private Sub AdditionalProcessToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AdditionalProcessToolStripMenuItem.Click
      If ActivateThisChild("frmProdAdditionalProcess") = False Then
         Dim newMDIChild As New frmProdAdditionalProcess()
         newMDIChild.MdiParent = Me
         newMDIChild.Show()
      End If
   End Sub

    Private Sub AdditionalOperationsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AdditionalOperationsToolStripMenuItem.Click
        If ActivateThisChild("ProdAdditionalOperation") = False Then
            Dim newMDIChild As New ProdAdditionalOperation()
            newMDIChild.MdiParent = Me
            newMDIChild.Show()
        End If
    End Sub
    Private Sub MSteupProdOtherCharges_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MSteupProdOtherCharges.Click
        If ActivateThisChild("ProdOtherCharges") = False Then
            Dim newMDIChild As New ProdOtherCharges()
            newMDIChild.MdiParent = Me
            newMDIChild.Show()
        End If
    End Sub
    Private Sub MSetupProdStyle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MSetupProdStyle.Click
        If ActivateThisChild("ProdStyle") = False Then
            Dim newMDIChild As New ProdStyle()
            newMDIChild.MdiParent = Me
            newMDIChild.Show()
        End If
    End Sub
End Class
