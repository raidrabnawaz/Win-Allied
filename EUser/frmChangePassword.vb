Public Class frmChangePassword
   Dim objCommon As New clsCommon
   Dim myoldpassword As String
   Private Sub frmChangePassword_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
      G_CURRENTDATE = Date.Now
      If G_CURRENTDATE > G_SOFTENDDATE Then
         End
      End If

      txtLogin.Text = G_Userlogin
      qryMain = "SELECT top 1 UserPassword FROM SecUser where UserID = " & G_UID & " "
      myoldpassword = objCommon.ExecuteScalar(qryMain)
      'txtPasswordOld.Text = qryMain
   End Sub
   Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
      If myoldpassword <> txtPasswordOld.Text.Trim Then
         MsgBox("Password incorrect , please enter correct password")
         Return
      End If
      If txtPasswordNew.Text.Trim <> txtPasswordConfirm.Text.Trim Then
         MsgBox("Kindly enter password in both feilds")
         Return
      End If
      qryMain = "update SecUser set UserPassword='" & txtPasswordNew.Text.Trim & "' where UserID = " & G_UID & " "
      objCommon.ExecuteNonQuery(qryMain)
      MsgBox("Password changed successfully....")
      Me.Close()
   End Sub

   Private Sub cmdCancel_Click(sender As System.Object, e As System.EventArgs) Handles cmdCancel.Click
      Me.Close()
   End Sub
End Class