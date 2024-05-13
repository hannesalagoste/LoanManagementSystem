<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmLoanReleaseReportViewer
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
        Me.crvLoanReleaseReportViewer = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.rptLoanRelease1 = New LoanManagementSystem.rptLoanRelease()
        Me.SuspendLayout()
        '
        'crvLoanReleaseReportViewer
        '
        Me.crvLoanReleaseReportViewer.ActiveViewIndex = 0
        Me.crvLoanReleaseReportViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crvLoanReleaseReportViewer.Cursor = System.Windows.Forms.Cursors.Default
        Me.crvLoanReleaseReportViewer.DisplayStatusBar = False
        Me.crvLoanReleaseReportViewer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.crvLoanReleaseReportViewer.Location = New System.Drawing.Point(0, 0)
        Me.crvLoanReleaseReportViewer.Name = "crvLoanReleaseReportViewer"
        Me.crvLoanReleaseReportViewer.ReportSource = Me.rptLoanRelease1
        Me.crvLoanReleaseReportViewer.Size = New System.Drawing.Size(912, 509)
        Me.crvLoanReleaseReportViewer.TabIndex = 0
        Me.crvLoanReleaseReportViewer.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'frmLoanReleaseReportViewer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(912, 509)
        Me.Controls.Add(Me.crvLoanReleaseReportViewer)
        Me.Name = "frmLoanReleaseReportViewer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Loan Release Report Viewer"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents crvLoanReleaseReportViewer As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents rptLoanRelease1 As rptLoanRelease
End Class
