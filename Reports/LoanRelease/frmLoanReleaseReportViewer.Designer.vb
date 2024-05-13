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
        Me.crvLoanRelease = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.rptLoanRelease1 = New LoanManagementSystem.rptLoanRelease()
        Me.SuspendLayout()
        '
        'crvLoanRelease
        '
        Me.crvLoanRelease.ActiveViewIndex = 0
        Me.crvLoanRelease.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crvLoanRelease.Cursor = System.Windows.Forms.Cursors.Default
        Me.crvLoanRelease.Dock = System.Windows.Forms.DockStyle.Fill
        Me.crvLoanRelease.Location = New System.Drawing.Point(0, 0)
        Me.crvLoanRelease.Name = "crvLoanRelease"
        Me.crvLoanRelease.ReportSource = Me.rptLoanRelease1
        Me.crvLoanRelease.Size = New System.Drawing.Size(800, 450)
        Me.crvLoanRelease.TabIndex = 0
        Me.crvLoanRelease.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'frmLoanReleaseReportViewer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.crvLoanRelease)
        Me.Name = "frmLoanReleaseReportViewer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmLoanReleaseReportViewer"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents crvLoanRelease As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents rptLoanRelease1 As rptLoanRelease
End Class
