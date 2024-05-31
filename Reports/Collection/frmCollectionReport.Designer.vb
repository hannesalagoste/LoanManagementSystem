<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCollectionReport
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
        Me.crvCollection = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.rptCollection1 = New LoanManagementSystem.rptCollection()
        Me.SuspendLayout()
        '
        'crvCollection
        '
        Me.crvCollection.ActiveViewIndex = 0
        Me.crvCollection.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crvCollection.Cursor = System.Windows.Forms.Cursors.Default
        Me.crvCollection.DisplayStatusBar = False
        Me.crvCollection.Dock = System.Windows.Forms.DockStyle.Fill
        Me.crvCollection.Location = New System.Drawing.Point(0, 0)
        Me.crvCollection.Name = "crvCollection"
        Me.crvCollection.ReportSource = Me.rptCollection1
        Me.crvCollection.Size = New System.Drawing.Size(1009, 560)
        Me.crvCollection.TabIndex = 0
        Me.crvCollection.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'frmCollectionReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1009, 560)
        Me.Controls.Add(Me.crvCollection)
        Me.Name = "frmCollectionReport"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Collection Report"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents crvCollection As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents rptCollection1 As rptCollection
End Class
