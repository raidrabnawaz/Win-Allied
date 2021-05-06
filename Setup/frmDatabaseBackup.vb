Public Class frmDatabaseBackup
    Dim objCommon As New clsCommon
    Private Sub frmChangePassword_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        GetDBCredentials()
        'Public DB_ServerName As String = ""
        'Public DB_Name As String = ""
        'Public DB_Pswd As String = ""
        'Public DB_UserName As String = ""
        txtServerName.Text = DB_ServerName
        txtDatabaseName.Text = DB_Name
    End Sub
    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        If txtPath.Text.Trim = "" Then
            MessageBox.Show("Please select some folder", G_APP_TITLE)
            Return
        End If
        Try
            qryMain = " USE " & DB_Name & "; " & _
            " BACKUP DATABASE " & DB_Name & " TO DISK = N'" & txtPath.Text & "\" & DB_Name & "" & Now.ToString("YYYYMMdd HHmmss") & ".Bak' WITH NOFORMAT, INIT,  NAME = N'" & DB_Name & "-Full Database Backup', SKIP, NOREWIND, NOUNLOAD,  STATS = 10 "
            objCommon.ExecuteNonQuery(qryMain)
            MessageBox.Show("Database Save Successfully", G_APP_TITLE)
        Catch ex As Exception
            PrintLine(ex.Message)
        End Try
    End Sub

    Private Sub cmdCancel_Click(sender As System.Object, e As System.EventArgs) Handles cmdCancel.Click
        Me.Close()
    End Sub

    Private Sub cmdPictureUpload_Click(sender As System.Object, e As System.EventArgs) Handles cmdPictureUpload.Click
        Dim result As DialogResult
        result = FolderBrowserDialog1.ShowDialog()
        If result = DialogResult.OK Then
            txtPath.Text = FolderBrowserDialog1.SelectedPath
        Else
            txtPath.Text = ""
        End If

    End Sub
End Class