Public Class EXPORT

   Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
      qryMain = " exec spRptAttDailyAB ;"
      'Dim dt As DataTable = objCommon.GetDataTable(qryMain)
      'grdAtt.DataSource = dt
      'ExportToExcel(grdAtt)
   End Sub
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
End Class