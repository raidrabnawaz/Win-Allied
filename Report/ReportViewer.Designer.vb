<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ReportViewer
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
      Me.CRVSetup = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
      Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
      Me.SuspendLayout()
      '
      'CRVSetup
      '
      Me.CRVSetup.ActiveViewIndex = -1
      Me.CRVSetup.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
      Me.CRVSetup.Cursor = System.Windows.Forms.Cursors.Default
      Me.CRVSetup.Dock = System.Windows.Forms.DockStyle.Fill
      Me.CRVSetup.Location = New System.Drawing.Point(0, 0)
      Me.CRVSetup.Name = "CRVSetup"
      Me.CRVSetup.Size = New System.Drawing.Size(994, 601)
      Me.CRVSetup.TabIndex = 0
      '
      'CrystalReportViewer1
      '
      Me.CrystalReportViewer1.ActiveViewIndex = -1
      Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
      Me.CrystalReportViewer1.Location = New System.Drawing.Point(0, 0)
      Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
      Me.CrystalReportViewer1.SelectionFormula = ""
      Me.CrystalReportViewer1.Size = New System.Drawing.Size(150, 150)
      Me.CrystalReportViewer1.TabIndex = 0
      Me.CrystalReportViewer1.ViewTimeSelectionFormula = ""
      '
      'ReportViewer
      '
      Me.ClientSize = New System.Drawing.Size(994, 601)
      Me.Controls.Add(Me.CRVSetup)
      Me.Name = "ReportViewer"
      Me.Text = "ReportViewer"
      Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
      Me.ResumeLayout(False)

   End Sub
    Private WithEvents CRVSetup As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
