<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLoanPaymentReport
    Inherits System.Windows.Forms.Form

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
        Me.crvLoanPayment = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.rptLoanPayment1 = New LoanManagementSystem.rptLoanPayment()
        Me.lblDocNo = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'crvLoanPayment
        '
        Me.crvLoanPayment.ActiveViewIndex = 0
        Me.crvLoanPayment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crvLoanPayment.Cursor = System.Windows.Forms.Cursors.Default
        Me.crvLoanPayment.DisplayStatusBar = False
        Me.crvLoanPayment.Dock = System.Windows.Forms.DockStyle.Fill
        Me.crvLoanPayment.Location = New System.Drawing.Point(0, 0)
        Me.crvLoanPayment.Name = "crvLoanPayment"
        Me.crvLoanPayment.ReportSource = Me.rptLoanPayment1
        Me.crvLoanPayment.Size = New System.Drawing.Size(800, 450)
        Me.crvLoanPayment.TabIndex = 0
        Me.crvLoanPayment.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'lblDocNo
        '
        Me.lblDocNo.AutoSize = True
        Me.lblDocNo.Location = New System.Drawing.Point(23, 43)
        Me.lblDocNo.Name = "lblDocNo"
        Me.lblDocNo.Size = New System.Drawing.Size(39, 13)
        Me.lblDocNo.TabIndex = 1
        Me.lblDocNo.Text = "Label1"
        '
        'frmLoanPaymentReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblDocNo)
        Me.Controls.Add(Me.crvLoanPayment)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmLoanPaymentReport"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Loan Payment Report"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents crvLoanPayment As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents rptLoanPayment1 As rptLoanPayment
    Friend WithEvents lblDocNo As Label
End Class
