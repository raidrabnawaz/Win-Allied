<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProdOtherCharges
   Inherits WinBaseForms.GUIBaseFormEntry

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
      Me.GBHeading.SuspendLayout()
      Me.GBFooter.SuspendLayout()
      Me.SuspendLayout()
      '
      'GBHeading
      '
      Me.GBHeading.Size = New System.Drawing.Size(600, 42)
      '
      'GBFooter
      '
      Me.GBFooter.Location = New System.Drawing.Point(0, 266)
      Me.GBFooter.Size = New System.Drawing.Size(600, 76)
      '
      'GBBody
      '
      Me.GBBody.Size = New System.Drawing.Size(600, 224)
      '
      'lblHeading
      '
      Me.lblHeading.Size = New System.Drawing.Size(600, 42)
      '
      'frmProdOtherCharges
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.ClientSize = New System.Drawing.Size(600, 342)
      Me.Name = "frmProdOtherCharges"
      Me.Text = "frmProdOtherCharges"
      Me.GBHeading.ResumeLayout(False)
      Me.GBFooter.ResumeLayout(False)
      Me.ResumeLayout(False)

   End Sub
End Class
