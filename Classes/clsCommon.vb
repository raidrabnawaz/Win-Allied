Imports System
Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Imports System.Collections
Imports System.Collections.Generic
Imports System.Text
Imports System.Collections.Specialized
Imports System.Net
Imports System.Net.Sockets

Public Class clsCommon
#Region "Connection"
    Public Function ObjCon() As SqlConnection
        Return objConnection
    End Function
    Public Sub openConnection()
        objConnection.Open()
    End Sub
    Public Sub CloseConnection()
        objConnection.Close()
    End Sub
#End Region '"Connection"
#Region "Datatype"
    Private Function Setint(ByVal s As String) As Integer
        Setint = 0
        Integer.TryParse(s, Setint)
        Return Setint
    End Function
    Private Function Setdouble(ByVal s As String) As Double
        Setdouble = 0.0
        Double.TryParse(s, Setdouble)
        Return Setdouble
    End Function

#End Region '"Datatype"
#Region "QryExec"
    Public Function ExecuteScalar(ByVal SqlString As String) As String
        Dim str As String = ""
        Dim dbcmd As New SqlCommand(SqlString, objConnection)
        Try
            dbcmd.Connection.Open()
            str = dbcmd.ExecuteScalar()
        Catch ex As SqlClient.SqlException
            Throw ex
        Finally
            dbcmd.Connection.Close()
        End Try
        If IsNothing(str) Then
            str = ""
        End If
        Return str
    End Function
    Public Function ExecuteScalarWithOpen(ByVal SqlString As String) As String
        Dim str As String = ""
        Dim dbcmd As New SqlCommand(SqlString, objConnection)
        Try
            str = dbcmd.ExecuteScalar()
        Catch ex As SqlClient.SqlException
            Throw ex
        End Try
        If IsNothing(str) Then
            str = ""
        End If
        Return str
    End Function
    Public Sub ExecuteNonQuery(ByVal SqlString As String)
        Dim dbcmd As New SqlCommand(SqlString, objConnection)
        Try
            dbcmd.Connection.Open()
            dbcmd.ExecuteNonQuery()
        Catch ex As SqlClient.SqlException
            Throw ex
        Finally
            dbcmd.Connection.Close()
        End Try
    End Sub
    Public Sub ExecuteNonQueryWithOpen(ByVal SqlString As String)
        Dim dbcmd As New SqlCommand(SqlString, objConnection)
        Try
            dbcmd.ExecuteNonQuery()
        Catch ex As SqlClient.SqlException
            Throw ex
        End Try
    End Sub
    Public Function GetDataTable(ByVal query As String) As DataTable
        Try
            Dim da = New SqlDataAdapter(query, strConnectionString)
            Dim ds = New DataSet()
            da.Fill(ds)
            Return ds.Tables(0)
        Catch ex As Exception
            Return Nothing
        End Try
    End Function


    Public Sub ExportToExcel(ByRef grdAtt As System.Windows.Forms.DataGridView)

        If grdAtt Is Nothing OrElse grdAtt.RowCount <= 0 Then
            MsgBox("No record to export !!!")
            Exit Sub
        End If

        Dim xlApp As New Microsoft.Office.Interop.Excel.Application
        Dim xlWorkBook As Microsoft.Office.Interop.Excel.Workbook
        Dim misValue As Object = System.Reflection.Missing.Value

        Try


            xlWorkBook = xlApp.Workbooks.Add(misValue)
            xlApp.Visible = True
            Dim xlWorkSheet = xlWorkBook.ActiveSheet

            'Data transfer from grid to Excel. 
            With xlWorkSheet
                .Range("A1", misValue).EntireRow.Font.Bold = True

                'Set Clipboard Copy Mode
                grdAtt.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText

                grdAtt.SelectAll()

                'Get the content from Grid for Clipboard
                Dim str As String = TryCast(grdAtt.GetClipboardContent().GetData(DataFormats.UnicodeText), String)

                'Set the content to Clipboard
                Clipboard.SetText(str, TextDataFormat.UnicodeText)
                Dim myRowCount As Int16 = grdAtt.RowCount
                myRowCount = myRowCount + 1
                'Identifiy and select the range of cells in excel to paste the clipboard data.
                '.Range("A1:" & ConvertToLetter(grdAtt.ColumnCount) & grdAtt.RowCount, misValue).Select()
                .Range("A1:" & ConvertToLetter(grdAtt.ColumnCount) & myRowCount, misValue).Select()
                'Paste the clipboard data
                .Paste()
                Clipboard.Clear()
            End With
            releaseObjectExl(xlWorkSheet)

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            releaseObjectExl(xlWorkBook)
            releaseObjectExl(xlApp)
        End Try

    End Sub

    Public Function GetDataTableSP(ByVal cSPName As String, ByVal cwhere As String) As DataTable
        Dim dataset As New DataSet()
        Dim ExecCommand As New SqlCommand
        Try
            ExecCommand = New SqlCommand(cSPName, objConnection)
            ExecCommand.CommandType = CommandType.StoredProcedure
            ExecCommand.Connection.Open()
            ExecCommand.CommandTimeout = 0
            ExecCommand.Parameters.Add(New SqlParameter("@cwhere", cwhere))
            Dim myadapter As New SqlDataAdapter(ExecCommand) ', objConnection)
            myadapter.Fill(dataset)
        Catch ex As Exception
            PrintLine(ex.Message)
        Finally
            ExecCommand.Connection.Close()
        End Try
        Return dataset.Tables(0)
    End Function
    Public Function GetDataTableSPPrm(ByVal cSPName As String, ByRef MyListDic As ListDictionary) As DataTable
        Dim ExecCommand As New SqlCommand
        Dim dataset As New DataSet()
        Try
            ExecCommand = New SqlCommand(cSPName, objConnection)
            ExecCommand.CommandType = CommandType.StoredProcedure
            ExecCommand.Connection.Open()
            ExecCommand.CommandTimeout = 0
            For Each item As DictionaryEntry In MyListDic
                ExecCommand.Parameters.AddWithValue(item.Key.ToString(), item.Value.ToString())
            Next
            Dim myadapter As New SqlDataAdapter(ExecCommand)
            myadapter.Fill(dataset)
        Catch ex As Exception
            PrintLine(ex.Message)
        Finally
            ExecCommand.Connection.Close()
        End Try
        Return dataset.Tables(0)
    End Function
#End Region '"QryExec"
#Region "ALL DB"
    Public Sub FillCompany(ByRef cmbo As ComboBox, ByVal Userlogin As String, Optional ByVal isActive As Int16 = 1, Optional ByVal filter As String = "")
        cmbo.DataSource = Nothing
        cmbo.SelectedValue = Nothing
        qryMain = " SELECT distinct C.VID, C.VName FROM tblSecUserCompany AS UC INNER JOIN  " &
      " dbo.tblSetupCompany AS C ON UC.Compcode = C.VID INNER JOIN tblSecUser AS U ON UC.UID = U.UserID " &
      " WHERE U.Userlogin= '" & Userlogin & "' and C.Isactive= " & isActive & " ORDER BY C.VName"
        Dim dt As DataTable = GetDataTable(qryMain)
        cmbo.DataSource = dt
        cmbo.DisplayMember = "VName"
        cmbo.ValueMember = "VID"
    End Sub
    Public Sub FillCompanyNew(ByRef cmbo As ComboBox)
        cmbo.DataSource = Nothing
        cmbo.SelectedValue = Nothing
        qryMain = " exec SpGetbyShow_Company"
        Dim dt As DataTable = GetDataTable(qryMain)
        cmbo.DataSource = dt
        cmbo.DisplayMember = "CompanyName"
        cmbo.ValueMember = "CompanyID"

    End Sub
    Public Function FillCompanyDT(Optional ByVal isActive As Int16 = 1, Optional ByVal filter As String = "") As DataTable
        qryMain = " SELECT distinct C.VID, C.VName,U.Userlogin FROM tblSecUserCompany AS UC INNER JOIN  " &
      " dbo.tblSetupCompany AS C ON UC.Compcode = C.VID INNER JOIN tblSecUser AS U ON UC.UID = U.UserID " &
      " WHERE C.Isactive= " & isActive & " ORDER BY C.VName"
        Dim dt As DataTable = GetDataTable(qryMain)
        Return dt
    End Function

    Public Sub FillFinancialYear(ByRef cmbo As ComboBox, ByVal companyID As Int32)
        cmbo.DataSource = Nothing
        cmbo.SelectedValue = Nothing
        qryMain = " SELECT '-1' VType, 'Select Financial Year' VName, '1900-01-01' DateFrom UNION ALL SELECT VID, VNAME, DateFrom FROM AccFinancialYear WHERE CompanyID = " & companyID & " ORDER BY DATEFROM"
        Dim dt As DataTable = GetDataTable(qryMain)
        cmbo.DataSource = dt
        cmbo.DisplayMember = "VName"
        cmbo.ValueMember = "VType"

    End Sub

    Public Sub FillAcSetupVType(ByRef cmbo As ComboBox)
        cmbo.DataSource = Nothing
        cmbo.SelectedValue = Nothing
        qryMain = " SELECT '-1' VType, 'Select Voucher Type' VName UNION ALL SELECT VCode, VName FROM AccVoucherTypeJV ORDER BY VType"
        Dim dt As DataTable = GetDataTable(qryMain)
        cmbo.DataSource = dt
        cmbo.DisplayMember = "VName"
        cmbo.ValueMember = "VType"
    End Sub

    Public Sub FillJVVoucherType(ByRef cmbo As ComboBox)
        cmbo.DataSource = Nothing
        cmbo.SelectedValue = Nothing
        qryMain = "EXEC SpGet_VoucherTypeJV"
        Dim dt As DataTable = GetDataTable(qryMain)
        cmbo.DataSource = dt
        cmbo.DisplayMember = "VName"
        cmbo.ValueMember = "VType"
    End Sub


    Public Sub FillAcSetupCOAGroup(ByRef cmbo As ComboBox)
        cmbo.DataSource = Nothing
        cmbo.SelectedValue = Nothing
        qryMain = " SELECT VID, VName FROM tblAcSetupCOAGroup ORDER BY VName"
        Dim dt As DataTable = GetDataTable(qryMain)
        cmbo.DataSource = dt
        cmbo.DisplayMember = "VName"
        cmbo.ValueMember = "VID"
    End Sub
    Public Sub FillAccountGroup(ByRef cmbo As ComboBox)
        cmbo.DataSource = Nothing
        cmbo.SelectedValue = Nothing
        qryMain = " SELECT '-1' VType, 'Select Account Group' VName UNION ALL SELECT VID, VName FROM AccAccountGroup"
        Dim dt As DataTable = GetDataTable(qryMain)
        cmbo.DataSource = dt
        cmbo.DisplayMember = "VName"
        cmbo.ValueMember = "VType"
    End Sub
    Public Sub FillAccountType(ByRef cmbo As ComboBox)
        cmbo.DataSource = Nothing
        cmbo.SelectedValue = Nothing
        qryMain = " SELECT '-1' VType, 'Select Account Type' VName UNION ALL SELECT VID, VName FROM AccAccountType"
        Dim dt As DataTable = GetDataTable(qryMain)
        cmbo.DataSource = dt
        cmbo.DisplayMember = "VName"
        cmbo.ValueMember = "VType"
    End Sub
    Public Sub FillSingleAccType(ByRef cmbo As ComboBox)
        cmbo.DataSource = Nothing
        cmbo.SelectedValue = Nothing
        qryMain = " exec SpGet_AccSinglAccountType"
        Dim dt As DataTable = GetDataTable(qryMain)
        cmbo.DataSource = dt
        cmbo.DisplayMember = "VName"
        cmbo.ValueMember = "VID"
    End Sub

    Public Sub FillBPVBank(ByRef cmbo As ComboBox)
        cmbo.DataSource = Nothing
        cmbo.SelectedValue = Nothing
        qryMain = " exec SpGetGLByBank_AccAccountCOA " & G_Compcode & ""
        Dim dt As DataTable = GetDataTable(qryMain)
        cmbo.DataSource = dt
        cmbo.DisplayMember = "VName"
        cmbo.ValueMember = "VID"
    End Sub

    Public Sub FillAccHead(ByRef cmbo As ComboBox, ByVal AccTypeID As String)
        cmbo.DataSource = Nothing
        cmbo.SelectedValue = Nothing
        qryMain = " exec Get_AccSingleAccountType " & AccTypeID & "," & G_Compcode & ""
        Dim dt As DataTable = GetDataTable(qryMain)
        cmbo.DataSource = dt
        cmbo.DisplayMember = "VName"
        cmbo.ValueMember = "VID"
    End Sub
    Public Sub FillAccMainHead(ByRef cmbo As ComboBox, ByVal Vtype As String)
        cmbo.DataSource = Nothing
        cmbo.SelectedValue = Nothing
        qryMain = "EXEC SpGetbyGLShow_AccAccountCOA " & G_Compcode & ", '" & Vtype & "'"
        Dim dt As DataTable = GetDataTable(qryMain)
        cmbo.DataSource = dt
        cmbo.DisplayMember = "VName"
        cmbo.ValueMember = "VID"
    End Sub
    Public Sub FillGPDepartment(ByRef cmbo As ComboBox)
        cmbo.DataSource = Nothing
        cmbo.SelectedValue = Nothing
        qryMain = "EXEC SpGet_HRDepartment "
        Dim dt As DataTable = GetDataTable(qryMain)
        cmbo.DataSource = dt
        cmbo.DisplayMember = "VName"
        cmbo.ValueMember = "VID"
    End Sub
    Public Sub FillGPSupplier(ByRef cmbo As ComboBox)
        cmbo.DataSource = Nothing
        cmbo.SelectedValue = Nothing
        qryMain = "EXEC SpGet_GPSupplier "
        Dim dt As DataTable = GetDataTable(qryMain)
        cmbo.DataSource = dt
        cmbo.DisplayMember = "VName"
        cmbo.ValueMember = "VID"
    End Sub
    Public Sub FillGPSupplierName(ByRef cmbo As TextBox, ByVal VID As String)
        Try
            If VID > 0 Then
                qryMain = "EXEC SpGetbyIDGPSupplier " & VID & " "
                Dim dt As DataTable = GetDataTable(qryMain)
                If dt.Rows.Count <= 0 Then
                    Return
                End If
                Dim dr As DataRow = dt.Rows(0)
                cmbo.Text = dr("VName")
            End If

        Catch ex As Exception
            PrintLine(ex.Message)
        End Try
    End Sub

#Region "Inventory Fill"
    Public Sub FillDepartment(ByRef cmbo As ComboBox)
        cmbo.DataSource = Nothing
        cmbo.SelectedValue = Nothing
        qryMain = "EXEC SpGet_HRDepartment"
        Dim dt As DataTable = GetDataTable(qryMain)
        cmbo.DataSource = dt
        cmbo.DisplayMember = "VName"
        cmbo.ValueMember = "VID"
    End Sub

    Public Sub FillOrder(ByRef cmbo As ComboBox)
        cmbo.DataSource = Nothing
        cmbo.SelectedValue = Nothing
        qryMain = "EXEC SpGet_ProdSaleOrder"
        Dim dt As DataTable = GetDataTable(qryMain)
        cmbo.DataSource = dt
        cmbo.DisplayMember = "VName"
        cmbo.ValueMember = "VID"
    End Sub
    Public Sub FillSaleOrder(ByRef cmbo As ComboBox)
        cmbo.DataSource = Nothing
        cmbo.SelectedValue = Nothing
        qryMain = "EXEC SpGet_ProdSaleOrder"
        Dim dt As DataTable = GetDataTable(qryMain)
        cmbo.DataSource = dt
        cmbo.DisplayMember = "VName"
        cmbo.ValueMember = "VID"
    End Sub


    Public Sub FillEmployee(ByRef cmbo As ComboBox)
        cmbo.DataSource = Nothing
        cmbo.SelectedValue = Nothing
        qryMain = "EXEC SpGet_EMSEmployee"
        Dim dt As DataTable = GetDataTable(qryMain)
        cmbo.DataSource = dt
        cmbo.DisplayMember = "EmployeeName"
        cmbo.ValueMember = "EmployeeID"
    End Sub

    Public Sub FillIssueProduct(ByRef cmbo As ComboBox, ByVal MdnID As Double)
        cmbo.DataSource = Nothing
        cmbo.SelectedValue = Nothing
        qryMain = "EXEC SpGetby_ProductbyMDN '" & MdnID & "'"
        Dim dt As DataTable = GetDataTable(qryMain)
        cmbo.DataSource = dt
        cmbo.DisplayMember = "VName"
        cmbo.ValueMember = "VID"
    End Sub

    Public Sub FillIssueProductBatches(ByRef cmbo As ComboBox, ByVal ProdID As Double)
        cmbo.DataSource = Nothing
        cmbo.SelectedValue = Nothing
        qryMain = "EXEC SpGetby_ProductBatchesGRN " & ProdID & ""
        Dim dt As DataTable = GetDataTable(qryMain)
        cmbo.DataSource = dt
        cmbo.DisplayMember = "VName"
        cmbo.ValueMember = "VType"
    End Sub

    Public Sub FillInvSupplierName(ByRef cmbo As TextBox, ByVal VID As String)
        Try
            If VID > 0 Then
                qryMain = "EXEC SpGetbyIDInvSupplier " & VID & " "
                Dim dt As DataTable = GetDataTable(qryMain)
                If dt.Rows.Count <= 0 Then
                    Return
                End If
                Dim dr As DataRow = dt.Rows(0)
                cmbo.Text = dr("VName")
            End If

        Catch ex As Exception
            PrintLine(ex.Message)
        End Try
    End Sub



    Public Sub FillInvSupplier(ByRef cmbo As ComboBox)
        cmbo.DataSource = Nothing
        cmbo.SelectedValue = Nothing
        qryMain = "EXEC SpGetbySHow_invSupplier"
        Dim dt As DataTable = GetDataTable(qryMain)
        cmbo.DataSource = dt
        cmbo.DisplayMember = "VName"
        cmbo.ValueMember = "VID"
    End Sub


    Public Sub FillPayDocType(ByRef cmbo As ComboBox, ByVal FormType As String)
        cmbo.DataSource = Nothing
        cmbo.SelectedValue = Nothing
        qryMain = "EXEC SpGetPayDocType " & FormType & ""
        Dim dt As DataTable = GetDataTable(qryMain)
        cmbo.DataSource = dt
        cmbo.DisplayMember = "DocName"
        cmbo.ValueMember = "DocCode"
    End Sub


    Public Sub FillPayVoucherType(ByRef cmbo As ComboBox, ByVal FormType As String)
        cmbo.DataSource = Nothing
        cmbo.SelectedValue = Nothing
        qryMain = "EXEC SpGetPayVoucherType " & FormType & ""
        Dim dt As DataTable = GetDataTable(qryMain)
        cmbo.DataSource = dt
        cmbo.DisplayMember = "VName"
        cmbo.ValueMember = "VCode"
    End Sub


    Public Sub FillPOSBank(ByRef cmbo As ComboBox)
        cmbo.DataSource = Nothing
        cmbo.SelectedValue = Nothing
        qryMain = "EXEC SpGet_POSBank " & G_Compcode & ""
        Dim dt As DataTable = GetDataTable(qryMain)
        cmbo.DataSource = dt
        cmbo.DisplayMember = "BankName"
        cmbo.ValueMember = "VID"
    End Sub

    Public Sub FillInvoiceNo(ByRef cmbo As ComboBox, ByVal ID As Int32)
        cmbo.DataSource = Nothing
        cmbo.SelectedValue = Nothing
        qryMain = "EXEC SpGet_SaleInvoices " & ID & ""
        Dim dt As DataTable = GetDataTable(qryMain)
        cmbo.DataSource = dt
        cmbo.DisplayMember = "VNo"
        cmbo.ValueMember = "VID"
    End Sub

    Public Sub FillDocument(ByRef cmbo As ComboBox, ByVal ID As Int32, DocType As String, FormType As String)
        cmbo.DataSource = Nothing
        cmbo.SelectedValue = Nothing
        qryMain = "EXEC SpGet_Document " & ID & ", '" & DocType & "', '" & FormType & "'"
        Dim dt As DataTable = GetDataTable(qryMain)
        cmbo.DataSource = dt
        cmbo.DisplayMember = "VNo"
        cmbo.ValueMember = "VID"
    End Sub
    Public Sub FillCustomer(ByRef cmbo As ComboBox)
        cmbo.DataSource = Nothing
        cmbo.SelectedValue = Nothing
        qryMain = "EXEC SpGet_SaleCustomer"
        Dim dt As DataTable = GetDataTable(qryMain)
        cmbo.DataSource = dt
        cmbo.DisplayMember = "VName"
        cmbo.ValueMember = "VID"
    End Sub
    Public Sub FillBank(ByRef cmbo As ComboBox)
        cmbo.DataSource = Nothing
        cmbo.SelectedValue = Nothing
        qryMain = " SELECT '-1' VType, 'Select Bank' VName UNION ALL SELECT VID, VName from POSBank"
        Dim dt As DataTable = GetDataTable(qryMain)
        cmbo.DataSource = dt
        cmbo.DisplayMember = "VName"
        cmbo.ValueMember = "VType"
    End Sub
    Public Sub FillInvProduct(ByRef cmbo As ComboBox)
        cmbo.DataSource = Nothing
        cmbo.SelectedValue = Nothing
        qryMain = " SELECT '0' VID, 'Select Product' VName UNION ALL SELECT VID, VName from InvProduct"
        Dim dt As DataTable = GetDataTable(qryMain)
        cmbo.DataSource = dt
        cmbo.DisplayMember = "VName"
        cmbo.ValueMember = "VID"
    End Sub


    Public Sub FillCurrency(ByRef cmbo As ComboBox, ByVal VType As String)
        cmbo.DataSource = Nothing
        cmbo.SelectedValue = Nothing
        qryMain = "EXEC SpGetbyShow_POSCurrencyCompany " & G_Compcode & ", " & VType & ""
        Dim dt As DataTable = GetDataTable(qryMain)
        cmbo.DataSource = dt
        cmbo.DisplayMember = "VCode"
        cmbo.ValueMember = "VID"
    End Sub

    Public Sub FillVoucherTypeJV(ByRef cmbo As ComboBox)
        cmbo.DataSource = Nothing
        cmbo.SelectedValue = Nothing
        qryMain = "EXEC SpGetbyShow_VoucherTypeJV "
        Dim dt As DataTable = GetDataTable(qryMain)
        cmbo.DataSource = dt
        cmbo.DisplayMember = "Vname"
        cmbo.ValueMember = "vtype"
    End Sub

    Public Sub FillShipmentMethod(ByRef cmbo As ComboBox)
        cmbo.DataSource = Nothing
        cmbo.SelectedValue = Nothing
        qryMain = " SELECT '-1' VType, '--Select Shipment Method--' VName UNION ALL SELECT VID, VName from POSShippingMethod"
        Dim dt As DataTable = GetDataTable(qryMain)
        cmbo.DataSource = dt
        cmbo.DisplayMember = "VName"
        cmbo.ValueMember = "VType"
    End Sub

    Public Sub FillAddressCustomer(ByRef cmbo As ComboBox, ByVal CustomerID As Int32)
        cmbo.DataSource = Nothing
        cmbo.SelectedValue = Nothing
        qryMain = "EXEC SpGetByShow_SaleCustomerAddress " & CustomerID & ""
        Dim dt As DataTable = GetDataTable(qryMain)
        cmbo.DataSource = dt
        cmbo.DisplayMember = "VName"
        cmbo.ValueMember = "VID"
    End Sub


    Public Sub FillType(ByRef cmbo As ComboBox)
        cmbo.DataSource = Nothing
        cmbo.SelectedValue = Nothing
        qryMain = " exec SpGetbyShow_BudgetType"
        Dim dt As DataTable = GetDataTable(qryMain)
        cmbo.DataSource = dt
        cmbo.DisplayMember = "VName"
        cmbo.ValueMember = "VID"

    End Sub


    Public Function GetDataTableGetMaxCode(ByVal cSPName As String, ByRef MyListDic As ListDictionary) As DataTable
        Dim ExecCommand As New SqlCommand
        Dim dataset As New DataSet()
        Try
            ExecCommand = New SqlCommand(cSPName, objConnection)
            ExecCommand.CommandType = CommandType.Text
            ExecCommand.Connection.Open()
            ExecCommand.CommandTimeout = 0
            For Each item As DictionaryEntry In MyListDic
                ExecCommand.Parameters.AddWithValue(item.Key.ToString(), item.Value.ToString())
            Next
            Dim myadapter As New SqlDataAdapter(ExecCommand)
            myadapter.Fill(dataset)
        Catch ex As Exception
            PrintLine(ex.Message)
        Finally
            ExecCommand.Connection.Close()
        End Try
        Return dataset.Tables(0)
    End Function

    Public Sub FillCOuntry(ByRef cmbo As ComboBox)
        cmbo.DataSource = Nothing
        cmbo.SelectedValue = Nothing
        qryMain = " SELECT '-1' VType, 'Select Country' VName UNION ALL SELECT VID, VName from Country"
        Dim dt As DataTable = GetDataTable(qryMain)
        cmbo.DataSource = dt
        cmbo.DisplayMember = "VName"
        cmbo.ValueMember = "VType"
    End Sub

    Public Sub FillUoM(ByRef cmbo As ComboBox)
        cmbo.DataSource = Nothing
        cmbo.SelectedValue = Nothing
        qryMain = " SELECT '-1' VType, 'Select UOM' VName UNION ALL SELECT VID, VName FROM invUOM"
        Dim dt As DataTable = GetDataTable(qryMain)
        cmbo.DataSource = dt
        cmbo.DisplayMember = "VName"
        cmbo.ValueMember = "VType"
    End Sub



    Public Sub FillProductCategory(ByRef cmbo As ComboBox)
        cmbo.DataSource = Nothing
        cmbo.SelectedValue = Nothing
        qryMain = " SELECT '-1' VType, 'Select Product Category' VName UNION ALL SELECT VID, VName FROM invProductMainCategory"
        Dim dt As DataTable = GetDataTable(qryMain)
        cmbo.DataSource = dt
        cmbo.DisplayMember = "VName"
        cmbo.ValueMember = "VType"
    End Sub
    Public Sub FillProductType(ByRef cmbo As ComboBox)
        cmbo.DataSource = Nothing
        cmbo.SelectedValue = Nothing
        qryMain = "EXEC SpGet_ProductType"
        Dim dt As DataTable = GetDataTable(qryMain)
        cmbo.DataSource = dt
        cmbo.DisplayMember = "VName"
        cmbo.ValueMember = "VID"
    End Sub
    Public Sub FillPOType(ByRef cmbo As ComboBox)
        cmbo.DataSource = Nothing
        cmbo.SelectedValue = Nothing
        qryMain = " SELECT '-1' VType, 'Select PO Type' VName UNION ALL SELECT '0', 'Local' UNION ALL SELECT '1', 'Import'"
        Dim dt As DataTable = GetDataTable(qryMain)
        cmbo.DataSource = dt
        cmbo.DisplayMember = "VName"
        cmbo.ValueMember = "VType"
    End Sub
    Public Sub FillPDCVType(ByRef cmbo As ComboBox)
        cmbo.DataSource = Nothing
        cmbo.SelectedValue = Nothing
        qryMain = "EXEC SpGetbyShow_VoucherType"
        Dim dt As DataTable = GetDataTable(qryMain)
        cmbo.DataSource = dt
        cmbo.DisplayMember = "VName"
        cmbo.ValueMember = "VType"
    End Sub

    Public Sub FillPaymentTerm(ByRef cmbo As ComboBox)
        cmbo.DataSource = Nothing
        cmbo.SelectedValue = Nothing
        qryMain = " SELECT '-1' VType, 'Select Payment Term' VName UNION ALL SELECT VID, VName FROM POSPaymentTerm"
        Dim dt As DataTable = GetDataTable(qryMain)
        cmbo.DataSource = dt
        cmbo.DisplayMember = "VName"
        cmbo.ValueMember = "VType"
    End Sub

    Public Sub FillGPProductCategory(ByRef cmbo As ComboBox)
        cmbo.DataSource = Nothing
        cmbo.SelectedValue = Nothing
        qryMain = "EXEC SpGet_GPProductCategory"
        Dim dt As DataTable = GetDataTable(qryMain)
        cmbo.DataSource = dt
        cmbo.DisplayMember = "VName"
        cmbo.ValueMember = "VID"
    End Sub

    Public Sub FillGPProductType(ByRef cmbo As ComboBox)
        cmbo.DataSource = Nothing
        cmbo.SelectedValue = Nothing
        qryMain = "EXEC SpGet_GPProductTypeInformation"
        Dim dt As DataTable = GetDataTable(qryMain)
        cmbo.DataSource = dt
        cmbo.DisplayMember = "VName"
        cmbo.ValueMember = "VID"
    End Sub


    Public Sub FillGPUOM(ByRef cmbo As ComboBox)
        cmbo.DataSource = Nothing
        cmbo.SelectedValue = Nothing
        qryMain = "EXEC SpGet_GPUOM"
        Dim dt As DataTable = GetDataTable(qryMain)
        cmbo.DataSource = dt
        cmbo.DisplayMember = "VName"
        cmbo.ValueMember = "VID"
    End Sub

    Public Function GetDataTableSPCOA(ByVal cSPName As String, ByRef MyListDic As ListDictionary) As DataTable
        Dim ExecCommand As New SqlCommand
        Dim dataset As New DataSet()
        Try
            ExecCommand = New SqlCommand(cSPName, objConnection)
            ExecCommand.CommandType = CommandType.StoredProcedure
            ExecCommand.Connection.Open()
            ExecCommand.CommandTimeout = 0
            For Each item As DictionaryEntry In MyListDic
                ExecCommand.Parameters.AddWithValue(item.Key.ToString(), item.Value.ToString())
            Next
            Dim myadapter As New SqlDataAdapter(ExecCommand)
            myadapter.Fill(dataset)
        Catch ex As Exception
            PrintLine(ex.Message)
        Finally
            ExecCommand.Connection.Close()
        End Try
        Return dataset.Tables(0)
    End Function



#End Region
#Region "Production"
    Public Sub FillProdProductCategory(ByRef cmbo As ComboBox)

        cmbo.DataSource = Nothing
        cmbo.SelectedValue = Nothing
        qryMain = "EXEC SpGet_ProdProductCategory"
        Dim dt As DataTable = GetDataTable(qryMain)

        cmbo.DataSource = dt
        cmbo.DisplayMember = "VName"
        cmbo.ValueMember = "VID"
    End Sub
    Public Sub FillProdFabricNature(ByRef cmbo As ComboBox)
        cmbo.DataSource = Nothing
        cmbo.SelectedValue = Nothing
        qryMain = "EXEC SpGet_ProdProductNature"
        Dim dt As DataTable = GetDataTable(qryMain)
        cmbo.DataSource = dt
        cmbo.DisplayMember = "VName"
        cmbo.ValueMember = "VID"
    End Sub
    Public Sub FillProdFabricBrand(ByRef cmbo As ComboBox)
        cmbo.DataSource = Nothing
        cmbo.SelectedValue = Nothing
        qryMain = "EXEC SpGet_ProdBrand"
        Dim dt As DataTable = GetDataTable(qryMain)
        cmbo.DataSource = dt
        cmbo.DisplayMember = "VName"
        cmbo.ValueMember = "VID"
    End Sub
    Public Sub FillProdProductType(ByRef cmbo As ComboBox)
        cmbo.DataSource = Nothing
        cmbo.SelectedValue = Nothing
        qryMain = "EXEC SpGet_ProdFabricType"
        Dim dt As DataTable = GetDataTable(qryMain)
        cmbo.DataSource = dt
        cmbo.DisplayMember = "VName"
        cmbo.ValueMember = "VID"
    End Sub
    Public Sub FillProdManufacturer(ByRef cmbo As ComboBox)
        cmbo.DataSource = Nothing
        cmbo.SelectedValue = Nothing
        qryMain = "EXEC SpGet_ProdManufactured"
        Dim dt As DataTable = GetDataTable(qryMain)
        cmbo.DataSource = dt
        cmbo.DisplayMember = "VName"
        cmbo.ValueMember = "VID"
    End Sub
    Public Sub FillProdColor(ByRef cmbo As ComboBox)
        cmbo.DataSource = Nothing
        cmbo.SelectedValue = Nothing
        qryMain = "EXEC SpGet_ProdColor"
        Dim dt As DataTable = GetDataTable(qryMain)
        cmbo.DataSource = dt
        cmbo.DisplayMember = "VName"
        cmbo.ValueMember = "VID"
    End Sub

    Public Sub FillProdWagesMonth(ByRef cmbo As ComboBox)
        cmbo.DataSource = Nothing
        cmbo.SelectedValue = Nothing
        qryMain = "EXEC SpGet_ProdWagesMonth"
        Dim dt As DataTable = GetDataTable(qryMain)
        cmbo.DataSource = dt
        cmbo.DisplayMember = "VName"
        cmbo.ValueMember = "VID"
    End Sub

    Public Sub FillProdSaleOrderColor(ByRef cmbo As DataGridViewComboBoxCell)
        cmbo.DataSource = Nothing
        qryMain = "EXEC SpGet_ProdColor"
        Dim dt As DataTable = GetDataTable(qryMain)
        cmbo.DataSource = dt
        cmbo.DisplayMember = "VName"
        cmbo.ValueMember = "VID"
    End Sub

    Public Sub FillProdStretch(ByRef cmbo As ComboBox)
        cmbo.DataSource = Nothing
        cmbo.SelectedValue = Nothing
        qryMain = "EXEC SpGet_ProdStretchType"
        Dim dt As DataTable = GetDataTable(qryMain)
        cmbo.DataSource = dt
        cmbo.DisplayMember = "VName"
        cmbo.ValueMember = "VID"
    End Sub
    Public Sub FillProdGSM(ByRef cmbo As ComboBox)
        cmbo.DataSource = Nothing
        cmbo.SelectedValue = Nothing
        qryMain = "EXEC SpGet_ProdGSM"
        Dim dt As DataTable = GetDataTable(qryMain)
        cmbo.DataSource = dt
        cmbo.DisplayMember = "VName"
        cmbo.ValueMember = "VID"
    End Sub
    Public Sub FillProdSizeType(ByRef cmbo As ComboBox)
        cmbo.DataSource = Nothing
        cmbo.SelectedValue = Nothing
        qryMain = "EXEC SpGet_ProdSizeType"
        Dim dt As DataTable = GetDataTable(qryMain)
        cmbo.DataSource = dt
        cmbo.DisplayMember = "VName"
        cmbo.ValueMember = "VID"
    End Sub

    'Public Sub FillProdOperationSetType(ByRef cmbo As ComboBox)
    '   cmbo.DataSource = Nothing
    '   cmbo.SelectedValue = Nothing
    '   qryMain = "EXEC SpGet_ProdOperationSetType"
    '   Dim dt As DataTable = GetDataTable(qryMain)
    '   cmbo.DataSource = dt
    '   cmbo.DisplayMember = "VName"
    '   cmbo.ValueMember = "VID"
    'End Sub


    Public Sub FillProdSaleOrder(ByRef cmbo As ComboBox)
        cmbo.DataSource = Nothing
        cmbo.SelectedValue = Nothing
        qryMain = "SELECT '0' VID, 'Select Sale Order' VName UNION ALL SELECT VID,'('+VNo+') '+ VName AS VName FROM ProdSaleOrder"
        Dim dt As DataTable = GetDataTable(qryMain)
        cmbo.DataSource = dt
        cmbo.DisplayMember = "VName"
        cmbo.ValueMember = "VID"
    End Sub

    Public Sub FillProdAdditionalOperation(ByRef cmbo As ComboBox)
        cmbo.DataSource = Nothing
        cmbo.SelectedValue = Nothing
        qryMain = "EXEC SpGet_ProdAdditionalOperation "
        Dim dt As DataTable = GetDataTable(qryMain)
        cmbo.DataSource = dt
        cmbo.DisplayMember = "VName"
        cmbo.ValueMember = "VID"
    End Sub

    Public Sub FillProdSaleOrderSizes(ByRef cmbo As ComboBox, ByVal OrderID As Integer, ByVal VType As String)
        cmbo.DataSource = Nothing
        cmbo.SelectedValue = Nothing
        qryMain = "EXEC SpGet_ProdGetOrderSizes " & OrderID & ",'" & VType & "'"
        Dim dt As DataTable = GetDataTable(qryMain)
        cmbo.DataSource = dt
        cmbo.DisplayMember = "VName"
        cmbo.ValueMember = "VID"
    End Sub



    Public Sub FillProdWeave(ByRef cmbo As ComboBox)
        cmbo.DataSource = Nothing
        cmbo.SelectedValue = Nothing
        qryMain = "EXEC SpGet_ProdWaveType"
        Dim dt As DataTable = GetDataTable(qryMain)
        cmbo.DataSource = dt
        cmbo.DisplayMember = "VName"
        cmbo.ValueMember = "VID"
    End Sub
    Public Sub FillProdFabricWidth(ByRef cmbo As ComboBox)
        cmbo.DataSource = Nothing
        cmbo.SelectedValue = Nothing
        qryMain = "EXEC SpGet_ProdFabricWidth"
        Dim dt As DataTable = GetDataTable(qryMain)
        cmbo.DataSource = dt
        cmbo.DisplayMember = "VName"
        cmbo.ValueMember = "VID"
    End Sub
    Public Sub FillProdPaymentTerm(ByRef cmbo As ComboBox)
        cmbo.DataSource = Nothing
        cmbo.SelectedValue = Nothing
        qryMain = "EXEC SpGet_ProdPaymentTerm"
        Dim dt As DataTable = GetDataTable(qryMain)
        cmbo.DataSource = dt
        cmbo.DisplayMember = "VName"
        cmbo.ValueMember = "VID"
    End Sub


    Public Sub FillCustomerType(ByRef cmbo As ComboBox)
        cmbo.DataSource = Nothing
        cmbo.SelectedValue = Nothing
        qryMain = "EXEC SpGet_CustomerType"
        Dim dt As DataTable = GetDataTable(qryMain)
        cmbo.DataSource = dt
        cmbo.DisplayMember = "VName"
        cmbo.ValueMember = "VID"
    End Sub


    Public Sub FillProdCustomer(ByRef cmbo As ComboBox)
        cmbo.DataSource = Nothing
        cmbo.SelectedValue = Nothing
        qryMain = "EXEC SpGetbyShowProdCustomer"
        Dim dt As DataTable = GetDataTable(qryMain)
        cmbo.DataSource = dt
        cmbo.DisplayMember = "VName"
        cmbo.ValueMember = "VID"
    End Sub

    Public Sub FillProdBuyer(ByRef cmbo As ComboBox)
        cmbo.DataSource = Nothing
        cmbo.SelectedValue = Nothing
        qryMain = "EXEC SpGetbyShowProdBuyer"
        Dim dt As DataTable = GetDataTable(qryMain)
        cmbo.DataSource = dt
        cmbo.DisplayMember = "VName"
        cmbo.ValueMember = "VID"
    End Sub

    Public Sub FillProdBrand(ByRef cmbo As ComboBox)
        cmbo.DataSource = Nothing
        cmbo.SelectedValue = Nothing
        qryMain = "EXEC SpGet_ProdBrand"
        Dim dt As DataTable = GetDataTable(qryMain)

        cmbo.DataSource = dt
        cmbo.DisplayMember = "VName"
        cmbo.ValueMember = "VID"
    End Sub

    Public Sub FillProdDepartment(ByRef cmbo As ComboBox)
        cmbo.DataSource = Nothing
        cmbo.SelectedValue = Nothing
        qryMain = "EXEC SpGet_HRDepartment"
        Dim dt As DataTable = GetDataTable(qryMain)

        cmbo.DataSource = dt
        cmbo.DisplayMember = "VName"
        cmbo.ValueMember = "VID"
    End Sub

    Public Sub FillProdAccessoryNature(ByRef cmbo As ComboBox)
        cmbo.DataSource = Nothing
        cmbo.SelectedValue = Nothing
        qryMain = "EXEC SpGet_ProdAccessoryNature"
        Dim dt As DataTable = GetDataTable(qryMain)

        cmbo.DataSource = dt
        cmbo.DisplayMember = "VName"
        cmbo.ValueMember = "VID"
    End Sub

    Public Sub FillProdAccessoryType(ByRef cmbo As ComboBox, ByVal NatureID As Double)
        cmbo.DataSource = Nothing
        cmbo.SelectedValue = Nothing
        qryMain = "EXEC SpGet_ProdAccessoryTypebyNature " & NatureID & ""
        Dim dt As DataTable = GetDataTable(qryMain)

        cmbo.DataSource = dt
        cmbo.DisplayMember = "VName"
        cmbo.ValueMember = "VID"
    End Sub

    Public Sub FillProdShippingMethod(ByRef cmbo As ComboBox)
        cmbo.DataSource = Nothing
        cmbo.SelectedValue = Nothing
        qryMain = "EXEC SpGet_ProdShippingMethod"
        Dim dt As DataTable = GetDataTable(qryMain)
        cmbo.DataSource = dt
        cmbo.DisplayMember = "VName"
        cmbo.ValueMember = "VID"
    End Sub

    Public Sub FillProdOperationCategory(ByRef cmbo As ComboBox)
        cmbo.DataSource = Nothing
        cmbo.SelectedValue = Nothing
        qryMain = "EXEC SpGet_ProdOperationCategory"
        Dim dt As DataTable = GetDataTable(qryMain)
        cmbo.DataSource = dt
        cmbo.DisplayMember = "VName"
        cmbo.ValueMember = "VID"
    End Sub

    Public Sub FillProdSetType(ByRef cmbo As ComboBox)
        cmbo.DataSource = Nothing
        cmbo.SelectedValue = Nothing
        qryMain = "EXEC SpGet_ProdOperationSetType"
        Dim dt As DataTable = GetDataTable(qryMain)
        cmbo.DataSource = dt
        cmbo.DisplayMember = "VName"
        cmbo.ValueMember = "VID"
    End Sub


    Public Sub FillProdStyle(ByRef cmbo As ComboBox)
        cmbo.DataSource = Nothing
        cmbo.SelectedValue = Nothing
        qryMain = "EXEC SpGet_ProdStyle"
        Dim dt As DataTable = GetDataTable(qryMain)
        cmbo.DataSource = dt
        cmbo.DisplayMember = "VName"
        cmbo.ValueMember = "VID"
    End Sub


    Public Sub FillProdOperation(ByRef cmbo As ComboBox)
        cmbo.DataSource = Nothing
        cmbo.SelectedValue = Nothing
        qryMain = "EXEC SpGet_ProdOperation"
        Dim dt As DataTable = GetDataTable(qryMain)
        cmbo.DataSource = dt
        cmbo.DisplayMember = "VName"
        cmbo.ValueMember = "VID"
    End Sub


    Public Sub FillProdFormType(ByRef cmbo As ComboBox)
        cmbo.DataSource = Nothing
        cmbo.SelectedValue = Nothing
        qryMain = "EXEC SpGet_ProdDepartments"
        Dim dt As DataTable = GetDataTable(qryMain)

        cmbo.DataSource = dt
        cmbo.DisplayMember = "VName"
        cmbo.ValueMember = "VID"
    End Sub


    Public Sub FillProdHalls(ByRef cmbo As ComboBox)
        cmbo.DataSource = Nothing
        cmbo.SelectedValue = Nothing
        qryMain = "EXEC SpGet_ProdHalls"
        Dim dt As DataTable = GetDataTable(qryMain)

        cmbo.DataSource = dt
        cmbo.DisplayMember = "VName"
        cmbo.ValueMember = "VID"
    End Sub


    Public Sub FillProductFaultCategory(ByRef cmbo As ComboBox)
        cmbo.DataSource = Nothing
        cmbo.SelectedValue = Nothing
        qryMain = " SELECT '-1' VType, 'Select Fault Category' VName UNION ALL SELECT VID, VName FROM ProdFaultCategory"
        Dim dt As DataTable = GetDataTable(qryMain)
        cmbo.DataSource = dt
        cmbo.DisplayMember = "VName"
        cmbo.ValueMember = "VType"
    End Sub


#End Region

#End Region '"ALL DB"
#Region "EMS Menu"
    Public Function LoadResources(ByVal UID As Int16) As DataTable
        qryMain = "SELECT Distinct UserID, PageID, VName, MenuName, " &
            " max(CASE WHEN Isactive=1 THEN 1 ELSE 0 END) as Isactive, max(CASE WHEN IsView=1 THEN 1 ELSE 0 END) as IsView, " &
            " max(CASE WHEN IsInsert=1 THEN 1 ELSE 0 END) as IsInsert, max(CASE WHEN IsUpdate=1 THEN 1 ELSE 0 END) as IsUpdate, " &
            " max(CASE WHEN IsDelete=1 THEN 1 ELSE 0 END) as IsDelete, max(CASE WHEN IsBackdate=1 THEN 1 ELSE 0 END) as IsBackdate, " &
            " max(CASE WHEN IsPrint=1 THEN 1 ELSE 0 END) as IsPrint,SrlNo from ( " &
            "SELECT UG.UserID, P.VID as PageID, P.VName, P.MenuName, PG.Isactive, PG.IsView, PG.IsInsert, PG.IsUpdate, PG.IsDelete, PG.IsBackdate, " &
            " PG.IsPrint, P.SrlNo FROM dbo.SecUserRole AS UG INNER JOIN dbo.SecRolePage AS PG ON UG.RoleID = PG.RoleID INNER JOIN " &
            " dbo.SecPage AS P ON PG.PageID = P.VID where UG.UserID= " & UID & " and P.Isactive= 1 and P.IsMVC=2 " &
            " and P.VID not in (select PageID from SecUserPage where UserID = " & UID & " and IncludeExclude = 1) " &
            " union all SELECT PG.UserID, P.VID as PageID, P.VName, P.MenuName, PG.Isactive, PG.IsView, PG.IsInsert, PG.IsUpdate, PG.IsDelete, " &
            " PG.IsBackdate, PG.IsPrint, P.SrlNo FROM dbo.SecUserPage AS PG INNER JOIN dbo.SecPage AS P ON PG.PageID = P.VID where " &
            " (PG.UserID = " & UID & " And P.Isactive = 1 And PG.IncludeExclude = 1) ) aa where PageID " &
            " not in ( SELECT distinct PPG.VID FROM dbo.SecUserPage AS PPG where PPG.UserID=" & UID & " and PPG.IncludeExclude=0 ) " &
            " group by UserID, PageID, VName, MenuName,SrlNo order by SrlNo "
        Return GetDataTable(qryMain)
    End Function
#End Region '"EMS Menu"
#Region "Others"
    'Public Sub ExportToExcel(ByRef grdAtt As System.Windows.Forms.DataGridView)

    '    If grdAtt Is Nothing OrElse grdAtt.RowCount <= 0 Then
    '        MsgBox("No record to export !!!")
    '        Exit Sub
    '    End If

    '    Dim xlApp As New Microsoft.Office.Interop.Excel.Application
    '    Dim xlWorkBook As Microsoft.Office.Interop.Excel.Workbook
    '    Dim misValue As Object = System.Reflection.Missing.Value

    '    Try
    '        xlWorkBook = xlApp.Workbooks.Add(misValue)
    '        xlApp.Visible = True
    '        Dim xlWorkSheet = xlWorkBook.ActiveSheet

    '        'Data transfer from grid to Excel. 
    '        With xlWorkSheet
    '            .Range("A1", misValue).EntireRow.Font.Bold = True

    '            'Set Clipboard Copy Mode
    '            grdAtt.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText
    '            grdAtt.SelectAll()

    '            'Get the content from Grid for Clipboard
    '            Dim str As String = TryCast(grdAtt.GetClipboardContent().GetData(DataFormats.UnicodeText), String)

    '            'Set the content to Clipboard
    '            Clipboard.SetText(str, TextDataFormat.UnicodeText)

    '            'Identifiy and select the range of cells in excel to paste the clipboard data.
    '            .Range("A1:" & ConvertToLetter(grdAtt.ColumnCount) & grdAtt.RowCount, misValue).Select()

    '            'Paste the clipboard data
    '            .Paste()
    '            Clipboard.Clear()
    '        End With
    '        releaseObjectExl(xlWorkSheet)

    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message)
    '    Finally
    '        releaseObjectExl(xlWorkBook)
    '        releaseObjectExl(xlApp)
    '    End Try

    'End Sub
    Private Sub releaseObjectExl(ByVal obj As Object)
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
        Finally
            GC.Collect()
        End Try
    End Sub
    Public Function GetComputerName() As String
        Try
            Return System.Environment.MachineName
        Catch generatedExceptionName As Exception
            'throw new Exception(ex.Message);
            Return ""
        End Try
    End Function
    Public Function GetIPAddress() As String
        Dim mcadd As String = ""
        Try
            Dim host As IPHostEntry
            host = Dns.GetHostEntry(Dns.GetHostName())
            For Each ip As IPAddress In host.AddressList
                If ip.AddressFamily = AddressFamily.InterNetwork Then
                    mcadd = mcadd & ip.ToString()
                End If
            Next
            Return mcadd
        Catch generatedExceptionName As Exception
            'throw new Exception(ex.Message);
            Return ""
        End Try
    End Function
    Private Function ConvertToLetter(ByVal num As Integer) As String
        num = num - 1
        If num < 0 Or num >= 27 * 26 Then
            ConvertToLetter = "-"
        Else
            If num < 26 Then
                ConvertToLetter = Chr(num + 65)
            Else
                ConvertToLetter = Chr(num \ 26 + 64) + Chr(num Mod 26 + 65)
            End If
        End If
    End Function
#End Region '"Others"

End Class

