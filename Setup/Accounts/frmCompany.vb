Imports System.Data.SqlClient
Imports System.Drawing
Imports System.Data
Imports System.IO
Imports System.Drawing.Imaging


Public Class frmCompany
   Dim qryMain As String
   Dim objCommon As New clsCommon
   Dim Active As Int16
   Dim Vat As Int16
   Dim SalesTax As Int16

   Private Sub frmAttCode_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
      G_CURRENTDATE = Date.Now
      If G_CURRENTDATE > G_SOFTENDDATE Then
         End
      End If

      txtID.Text = ""
      'objCommon.FillPaymentTerm(Me.cmbC)
      objCommon.FillCOuntry(Me.cmbCountry)
      ClearHead("")
      FillHeader()
      FillGrid()
      txtVName.Focus()
   End Sub
   Private Sub ClearHead(ByVal myid As String)
      For Each ctl In SplitContainer1.Panel1.Controls
         If TypeOf ctl Is TextBox Then ctl.Text = ""
      Next ctl

      lblInformation.Text = ""
      cmbCountry.SelectedIndex = 1
      IsActive.Checked = False
      haveSalesTax.Checked = False
      haveVAT.Checked = False
      PictureBox1.Image = Nothing
      cmdPictureUpload.Enabled = False
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

      grdcol0.DataPropertyName = "CompanyID"
      grdcol0.HeaderText = "Company ID"
      grdcol0.Name = "grdcol0"
      grdcol0.Visible = False
      '
      'grdcol1     CompanyID, CompanyCode, CompanyName, CompanyNature, Url, Country, RegistrationNo, IsActive
      '
      grdcol1.DataPropertyName = "CompanyCode"
      grdcol1.HeaderText = "Company Code"
      grdcol1.Name = "grdcol1"
      grdcol1.Width = 50

      grdcol2.DataPropertyName = "CompanyName"
      grdcol2.HeaderText = "Description"
      grdcol2.Name = "grdcol2"
      grdcol2.Width = 400
      '
      'grdcol2
      '
      grdcol3.DataPropertyName = "CompanyNature"
      grdcol3.HeaderText = "Company Nature"
      grdcol3.Name = "grdcol3"
      grdcol3.Visible = False

      grdcol4.DataPropertyName = "Url"
      grdcol4.HeaderText = "Company Url"
      grdcol4.Name = "grdcol4"
      grdcol4.Width = 200
      'ContactPerson, Creditdays, CNIC, SupplierBank, PayTo
      grdcol5.DataPropertyName = "Country"
      grdcol5.HeaderText = "Country"
      grdcol5.Name = "grdcol5"
      grdcol5.Width = 100

      grdcol6.DataPropertyName = "RegistrationNo"
      grdcol6.HeaderText = "Registration No"
      grdcol6.Name = "grdcol6"
      grdcol6.Width = 100

      grdcol7.DataPropertyName = "IsActive"
      grdcol7.HeaderText = "Is Active"
      grdcol7.Name = "grdcol7"
      grdcol7.Width = 50



      Me.grdRecord.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {grdcol0, grdcol1, grdcol2, grdcol3, grdcol4, grdcol5, grdcol6, grdcol7})
   End Sub
   Private Sub FillGrid()
      'grdRecord.DataSource = Nothing
      qryMain = "EXEC SpGet_Company 0"
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
      qryMain = "EXEC SpGet_Company'" & txtID.Text & "' "
      Dim dt As DataTable = objCommon.GetDataTable(qryMain)
      If IsNothing(dt) Then
         'EmptyFields()
         Return
      End If
      If dt.Rows.Count <= 0 Then
         'EmptyFields()     VID, VName, GLPurchaseCode, GLCostCode, ItemFor, IsFixedAsset, DepriPer, LifeMonth
         Return
      End If
      Dim dr As DataRow = dt.Rows(0)

      'CompanyID, CompanyCode, CompanyName, CompanyNature, Url, DisplayUrl, Logo,CurrencyID, SignatureImage, TimeZone, Phone, UAN, Fax, Address, City, Country, HaveSaleTax, 
      'SaleTaxPer, haveVAT, VatPer, NTNHeading, CNICHeading, RegistrationNo, SalestaxNo, IsActive
      Try
         txtVName.Text = dr("CompanyName")
         txtVCode.Text = dr("CompanyCode")
         'cmbC.SelectedValue = dr("PaymentTermID")
         txtDisplayUrl.Text = dr("DisplayUrl")
         txtCompanyUrl.Text = dr("Url")
         cmbCountry.SelectedValue = dr("Country")
         txtCity.Text = dr("City")
         'cmbVType.SelectedItem = dr("VType")
         txtAddress.Text = dr("Address")
         txtUANNo.Text = dr("UAN")
         txtCNIC.Text = dr("CNICHeading")
         txtSalesTax.Text = dr("SalestaxNo")
         txtVATPer.Text = dr("VatPer")
         txtSalesTaxPer.Text = dr("SaleTaxPer")
         txtTimeZone.Text = dr("TimeZone")
         txtPhoneNo.Text = dr("Phone")
         txtFax.Text = dr("Fax")
         txtNTN.Text = dr("NTNHeading")
         Active = dr("IsActive")
         If (Active <> 1) Then
            IsActive.Checked = False
         Else
            IsActive.Checked = True
         End If


         Vat = dr("haveVAT")
         If (Vat <> 1) Then
            haveVAT.Checked = False
            txtVATPer.ReadOnly = True
         Else
            haveVAT.Checked = True
            txtVATPer.ReadOnly = False
         End If


         SalesTax = dr("HaveSaleTax")
         If (SalesTax <> 1) Then
            haveSalesTax.Checked = False
            txtSalesTaxPer.ReadOnly = True
         Else
            haveSalesTax.Checked = True
            txtSalesTaxPer.ReadOnly = False
         End If
         cmdPictureUpload.Enabled = True
      Catch ex As Exception
         MessageBox.Show(ex.Message)
      End Try

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
      If txtVCode.Text = "" Then
         MessageBox.Show("Please give some Code.", G_APP_TITLE)
         txtVCode.Focus()
         Return
      End If
      If txtVName.Text = "" Then
         MessageBox.Show("Please give some Company Name.", G_APP_TITLE)
         txtVName.Focus()
         Return
      End If
      'qryMain = " Select top 1 isnull(L1Code,'') as L1Code from tblAcSetupCOAL1 where L1Code <> '" & txtID.Text & "' and VName='" & txtVName.Text & "'; "
      'qryMain = objCommon.ExecuteScalar(qryMain)
      'If qryMain <> "" Then
      '    MessageBox.Show("Account already exists.", G_APP_TITLE)
      '    Return
      'End If

      If txtID.Text Is "" Or txtID.Text = "" Then
         txtID.Text = 0
      End If

      'update
      '    qryMain = " update tblAcSetupCOAL1 set VName='" & txtVName.Text & "',GID='" & cmbCatetory.SelectedValue & "' where L1Code = '" & txtID.Text & "'; "
      '    objCommon.ExecuteNonQuery(qryMain)
      'Else
      '    Dim strcode As String
      '    strcode = objCommon.ExecuteScalar("select isnull(max(cast(L1Code as int)),0) + 1 as L1Code from tblAcSetupCOAL1 where GID = " & cmbCatetory.SelectedValue)
      '    strcode = Double.Parse(strcode).ToString("00")
      '    qryMain = "insert into tblAcSetupCOAL1 (L1Code, GID, VName, OldCode) values('" &
      '    strcode & "'," & cmbCatetory.SelectedValue & ",'" & txtVName.Text & "','' );  "

      'qryMain = "EXEC SpSave_invProductMainCategory " & txtID.Text & ", " & txtVName.Text & ", " & txtGLPurchase.Text & ", " & txtGLCost.Text & ", 0, 0, " & cmbCategory.SelectedIndex & ", 0, " & IsFixed.Checked & ", " & txtDepriciation.Text
      'qryMain &= ", " & txtLifeMonth.Text & ", 0, 0, 1, 1, 10, 1, ''"
      'CompanyCode, CompanyName, CompanyNature, Url, DisplayUrl, Logo, CurrencyID, SignatureImage, TimeZone, Phone, UAN, Fax, Address, City, Country, HaveSaleTax, SaleTaxPer, HaveVat, VatPer, NTNHeading,  CNICHeading, RegistrationNo, SalestaxNo, IsActive, InsertedBy, InsertedDate, InsertedIp, UpdatedBy, UpdatedDate, UpdatedIp
      If haveVAT.CheckState = 0 Then
         txtVATPer.Text = 0
      End If
      If haveSalesTax.CheckState = 0 Then
         txtSalesTaxPer.Text = 0
      End If
      qryMain = "EXEC SpSave_Company " & txtID.Text & ",'" & txtVCode.Text & "','" & txtVName.Text & "','','" & txtCompanyUrl.Text & "','" & txtDisplayUrl.Text & "','',1,'','" & txtTimeZone.Text & "','" & txtPhoneNo.Text & "','" & txtUANNo.Text & "','" & txtFax.Text & "','" & txtAddress.Text & "','" & txtCity.Text & "'," & cmbCountry.SelectedValue & "," & haveSalesTax.CheckState & "," & txtSalesTaxPer.Text & "," & haveVAT.CheckState & "," & txtVATPer.Text & ",'" & txtNTN.Text & "','" & txtCNIC.Text & "','" & txtRegistrationNo.Text & "','" & txtSalesTax.Text & "'," & IsActive.CheckState & "," & G_UID & ",'','" & G_IPAddress & "'," & G_UID & ",'','" & G_IPAddress & "'"
      objCommon.ExecuteNonQuery(qryMain)
      '
      ClearHead("")
      FillGrid()
      lblInformation.Text = "Record Saved."
      txtVName.Focus()
   End Sub
   Private Sub cmdEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEdit.Click
      FillForm()
      txtVName.Focus()
   End Sub
   Private Sub cmdSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSearch.Click

   End Sub
   Private Sub cmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancel.Click
      ClearHead("")
      txtVName.Focus()
   End Sub
   Private Sub cmdDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDelete.Click

   End Sub
   Private Sub grdAtt_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles grdRecord.MouseClick
      If grdRecord.Rows.Count > 0 Then
         Dim MYID As String = grdRecord.Rows(grdRecord.CurrentCell.RowIndex).Cells(0).Value
         txtID.Text = MYID
         FillForm()
         LoadPicture()
         txtVName.Focus()
      End If
   End Sub

   Private Sub haveVAT_CheckStateChanged(ByVal sender As Object, ByVal e As EventArgs) Handles haveVAT.CheckStateChanged
      If (haveVAT.Checked = True) Then
         txtVATPer.ReadOnly = False
         haveSalesTax.Checked = False
      Else
         txtVATPer.ReadOnly = True
      End If
   End Sub

   Private Sub haveSalesTax_CheckStateChanged(ByVal sender As Object, ByVal e As EventArgs) Handles haveSalesTax.CheckStateChanged
      If (haveSalesTax.Checked = True) Then
         txtSalesTaxPer.ReadOnly = False
         haveVAT.Checked = False
      Else
         txtSalesTaxPer.ReadOnly = True
      End If
   End Sub

   Private Sub txtSalesTaxPer_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtSalesTaxPer.KeyPress
      'If (Not Char.IsControl(e.KeyChar) _
      '             AndAlso (Not Char.IsDigit(e.KeyChar) _
      '             AndAlso (e.KeyChar <> Microsoft.VisualBasic.ChrW(46)))) Then
      '    e.Handled = True
      'End If

      Dim dotLength As Integer = 1
      dotLength = Me.txtSalesTaxPer.Text.Split(".").Length


      If e.KeyChar <> ControlChars.Back Then
         If dotLength > 1 Then
            e.Handled = Not (Char.IsDigit(e.KeyChar))
         Else
            e.Handled = Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = ".")
         End If
      End If

   End Sub

   Private Sub txtVATPer_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtVATPer.KeyPress
      'If (Not Char.IsControl(e.KeyChar) _
      '            AndAlso (Not Char.IsDigit(e.KeyChar) _
      '            AndAlso (e.KeyChar <> Microsoft.VisualBasic.ChrW(46)))) Then
      '    e.Handled = True
      'End If

      Dim dotLength As Integer = 1
      dotLength = Me.txtVATPer.Text.Split(".").Length


      If e.KeyChar <> ControlChars.Back Then
         If dotLength > 1 Then
            e.Handled = Not (Char.IsDigit(e.KeyChar))
         Else
            e.Handled = Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = ".")
         End If
      End If

   End Sub

   Private Sub cmdPictureUpload_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPictureUpload.Click
      Dim result As DialogResult = OpenFileDialog1.ShowDialog()
      If result = DialogResult.OK Then
         Dim image As Byte() = Nothing
         Dim fs As System.IO.FileStream
         fs = OpenFileDialog1.OpenFile ', System.IO.FileMode.Open, System.IO.FileAccess.Read)
         Dim br As New System.IO.BinaryReader(fs)
         image = br.ReadBytes(CInt(fs.Length)) 
         qryMain = " IF EXISTS(select * from CompanyLogo where CompanyID=" & txtID.Text & _
         " ) update CompanyLogo set ImageLength=" & image.Length & " ,Logo=@Imgg where CompanyID =" & txtID.Text & _
         " ELSE INSERT INTO CompanyLogo(CompanyID, ImageLength,CompanyName,CompanyCode , Logo ) VALUES(" & txtID.Text & " ," & image.Length & ",'" & G_CompName & "','" & txtVCode.Text & "' ,@Imgg ) ; "
         objConnection.Open()
         Dim cmd As New System.Data.SqlClient.SqlCommand(qryMain, objConnection)
         cmd.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Imgg", image))
         cmd.ExecuteNonQuery()
         objConnection.Close()

         ''Code for uploading images from a folder with AccCodes
         'If objConnection.State <> ConnectionState.Open Then
         ' objConnection.Open()
         'End If
         'Dim myempid As Double
         'Dim myempcode As String
         'Dim myfilename As String
         'Dim myPath As String = "D:\pic\"
         'Dim myFullPath As String
         'Dim image As Byte() = Nothing
         'Dim fs As System.IO.FileStream

         'Dim Folder As DirectoryInfo
         'Dim Images As FileInfo()
         'Folder = New DirectoryInfo(myPath)
         'Images = Folder.GetFiles()
         'Dim imagesList As List(Of String) = New List(Of String)()

         'For i As Integer = 0 To Images.Length - 1
         ' myfilename = Images(i).Name
         ' myempcode = Setint(myfilename.ToUpper.Replace(".JPG", ""))
         ' myempid = Setint(objCommon.ExecuteScalarWithOpen("select top 1 empid from tblemp where empcode = '" & myempcode & "'"))
         ' If myempid > 0 Then
         ' myFullPath = myPath + myfilename
         ' fs = New FileStream(myFullPath, FileMode.Open, FileAccess.Read) ' OpenFileDialog1.OpenFile ', System.IO.FileMode.Open, System.IO.FileAccess.Read)
         ' Dim br As New System.IO.BinaryReader(fs)
         ' image = br.ReadBytes(CInt(fs.Length))
         ' qryMain = " INSERT INTO tblEmpPic(EmpID, EmpFacePicLength , EmpFacePic ) VALUES(" & myempid & " ," & image.Length & " ,@Imgg ) ; "
         ' Dim cmd As New System.Data.SqlClient.SqlCommand(qryMain, objConnection)
         ' cmd.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Imgg", image))
         ' cmd.ExecuteNonQuery()
         ' Else
         ' 'aaaaaaaaaaaaaa
         ' End If
         'Next
         'objConnection.Close()
         'End
      End If
      LoadPicture()
   End Sub ' OK
   Private Sub LoadPicture()
      PictureBox1.Image = Nothing
      Try
         qryMain = "SELECT Logo,ImageLength From CompanyLogo where CompanyID =" & txtID.Text
         Dim dt As DataTable = objCommon.GetDataTable(qryMain)
         If dt.Rows.Count > 0 Then
            If Not IsNothing(dt.Rows(0)(0)) Then
               If Not (dt.Rows(0).IsNull(0)) Then
                  Dim data As Byte()
                  data = DirectCast(dt.Rows(0)(0), Byte())
                  Dim stream = New System.IO.MemoryStream(data)
                  PictureBox1.Image = Image.FromStream(stream)
               End If
            End If
         Else
            PictureBox1.Image = Nothing
         End If
      Catch ex As Exception

      End Try
   End Sub ' OK
End Class