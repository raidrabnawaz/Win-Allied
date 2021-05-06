Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Imports System.Collections.Generic
Imports System.Text


Public Module Module1

    Public strConnectionString As String = ConfigurationManager.ConnectionStrings("MainConnectionString").ConnectionString
    Public objConnection As New SqlConnection(strConnectionString)
    Public G_SOFTENDDATE As Date = CDate("01/Feb/2022")
    Public G_CURRENTDATE As Date
    Public G_APP_TITLE As String = "Windows ERP System"
    'Public G_ORG_NAME As String = "RELIANCE APPAREL (PVT) LIMITED"
    'Public G_ORG_INI As String = "REL"
    Public G_CURRENT_VERSION As String = ""
    Private G_CURRENT_VERSIONHard As String = "1.0"
    Public G_UID As Int16
    Public G_IsAdmin As Int16
    Public G_Userlogin As String = ""
    Public G_ServerDateTime As DateTime
    Public G_IsAuditor As Int16
    Public G_FinancialYearID As Int16
    Public G_Compcode As Int16 = 1
    Public G_CompIni As String = ""
    Public G_CurrencyID As Int16 = 1
    Public G_CompName As String = ""
    Public G_CompInitials As String = ""
    Public G_IPAddress As String = ""
    Public G_Dt_Rights As DataTable
    Public G_IsAudit As Int16 = 1
    Public qryMain As String
    Public PeriodFrom As String
    Public PeriodTo As String
    Public DB_ServerName As String = ""
    Public DB_Name As String = ""
    Public DB_Pswd As String = ""
    Public DB_UserName As String = ""
    Public Function FillGlobals() As String
        qryMain = " SELECT top 1 VValue FROM  Globals where Vtype in ('WinApp','') and VName='CurrentVersion' ; "
        Dim dbcmd As New SqlCommand(qryMain, objConnection)
        Try
            dbcmd.Connection.Open()
            qryMain = dbcmd.ExecuteScalar()
            G_CURRENT_VERSION = qryMain
            If G_CURRENT_VERSIONHard <> G_CURRENT_VERSION Then
                Return "Invalid software version"
            End If
        Catch ex As SqlClient.SqlException
            Throw ex
        Finally
            dbcmd.Connection.Close()
        End Try
        Return ""
    End Function
    Public Function Setint(ByVal s As String) As Integer
        Setint = 0
        Integer.TryParse(s, Setint)
        Return Setint
    End Function
    Public Function Setdouble(ByVal s As String) As Double
        Setdouble = 0.0
        Double.TryParse(s, Setdouble)
        Return Setdouble
    End Function

    Public Sub setGrid(ByVal grd As DataGridView)
        For Each column As DataGridViewColumn In grd.Columns
            Select Case column.HeaderText
                Case "VNo"
                    column.HeaderText = "Voucher No"
                Case "VDate"
                    column.HeaderText = "Voucher Date"
                Case "VName"
                    column.HeaderText = "Description"
                    column.Width = 400
                Case "ProductName"
                    column.HeaderText = "Description"
                    column.Width = 300
                Case "ProductDesc"
                    column.HeaderText = "Description"
                    column.Width = 400

                Case "VID"
                    column.Visible = False
                Case "poVID"
                    column.Visible = False
                Case "igpVID"
                    column.Visible = False
                Case "grnVID"
                    column.Visible = False
                Case "issueVID"
                    column.Visible = False
                Case "DID"
                    column.Visible = False
                Case "IsFixed"
                    column.Visible = False
                Case "StockVID"
                    column.Name = "VID"
                    column.Visible = False

                Case "ProductVID"
                    column.Name = "ProductID"
                    column.HeaderText = "Product ID"
                    column.Width = 100

                Case "VRate"
                    column.HeaderText = "Rate"
                    column.Width = 100
                    column.DefaultCellStyle.Format = "N2"

                Case "Rate"
                    column.HeaderText = "Rate"
                    column.Width = 100
                    column.DefaultCellStyle.Format = "N2"

                Case "Qty"
                    column.HeaderText = "Quantity"
                    column.Width = 100
                    column.DefaultCellStyle.Format = "N2"

                Case "Rate"
                    column.HeaderText = "Rate"
                    column.Width = 100
                    column.DefaultCellStyle.Format = "N2"

                Case "Balance"
                    column.HeaderText = "Balance"
                    column.Width = 100
                    column.DefaultCellStyle.Format = "N2"

                Case "Opening Balance"
                    column.HeaderText = "Opening Balance"
                    column.Width = 100
                    column.DefaultCellStyle.Format = "N2"

                Case "Balance Amount"
                    column.HeaderText = "Balance Amount"
                    column.Width = 100
                    column.DefaultCellStyle.Format = "N2"

                Case "Credit Limit"
                    column.HeaderText = "Credit Limit"
                    column.Width = 100
                    column.DefaultCellStyle.Format = "N2"

                Case "Dr"
                    column.HeaderText = "Dr"
                    column.Width = 100
                    column.DefaultCellStyle.Format = "N2"

                Case "Debit"
                    column.HeaderText = "Debit"
                    column.Width = 100
                    column.DefaultCellStyle.Format = "0.00##"

                Case "Credit"
                    column.HeaderText = "Credit"
                    column.Width = 100
                    column.DefaultCellStyle.Format = "N2"

                Case "Cr"
                    column.HeaderText = "Dr"
                    column.Width = 100
                    column.DefaultCellStyle.Format = "N2"

                Case "Amount"
                    column.HeaderText = "Amount"
                    column.Width = 100
                    column.DefaultCellStyle.Format = "N2"

                Case "Quantity"
                    column.HeaderText = "Quantity"
                    column.Width = 100
                    column.DefaultCellStyle.Format = "N2"

                Case "VType"
                    column.HeaderText = "Voucher Type"
                    column.Width = 100
                Case "ChequeNo"
                    column.HeaderText = "Cheque No"
                    column.Width = 100
                Case "ChequeDate"
                    column.HeaderText = "Cheque Date"
                    column.Width = 100
                Case "Narration"

                    column.HeaderText = "Narration"
                    column.Width = 450
                Case "Remarks"
                    column.Width = 350
                Case "OrderNo"
                Case "SupplierName"
                    column.Width = 200
                Case "DepName"
                    column.Width = 200
                Case "IsPosted"
                    'Dim col As New DataGridViewCheckBoxColumn
                    'column = New DataGridViewCheckBoxColumn
                    column.Name = "IsPosted"

                    column.HeaderText = "Is Posted"
                    column.Width = 100

                Case "VValue"
                    column.HeaderText = "Amount"
                    column.Name = "Amount"
                    column.Width = 100

                Case "CompanyID"
                    column.Visible = False
                Case "SupplierID"
                    column.Visible = False
                Case "DepartmentID"
                    column.Visible = False
                Case "FinancialYearID"
                    column.Visible = False
            End Select
        Next
    End Sub
    Public Function GetDBCredentials() As String
        Try
            Dim tempoStr1 As String() = New String(1) {}
            Dim tempoStr2 As String = strConnectionString
            tempoStr2 = tempoStr2.Trim()
            If Not tempoStr2.EndsWith(";") Then
                tempoStr2 = tempoStr2 & ";"
            End If
            tempoStr2 = tempoStr2
            Dim DBCredentials As String() = tempoStr2.Split(";"c)

            For i As Int16 = 0 To DBCredentials.GetLength(0) - 2
                tempoStr1 = DBCredentials(i).Split(("="c))
                If "DATA SOURCE SERVER ADDRESS ADDR NETWORK ADDRESS".Contains(tempoStr1(0).Trim().ToUpper()) Then
                    DB_ServerName = tempoStr1(1).Trim()
                Else
                    If "INITIAL CATALOG DATABASE".Contains(tempoStr1(0).Trim().ToUpper()) Then
                        DB_Name = tempoStr1(1).Trim()
                    Else
                        If "PASSWORD PWD".Contains(tempoStr1(0).Trim().ToUpper()) Then
                            DB_Pswd = tempoStr1(1).Trim()
                        Else
                            If "USER ID UID".Contains(tempoStr1(0).Trim().ToUpper()) Then
                                DB_UserName = tempoStr1(1).Trim()
                            End If
                        End If
                    End If
                End If
            Next
        Catch ex As Exception
            Return "Error Detail:" + Environment.NewLine + ex.Message
        End Try
        Return ""
    End Function
End Module
