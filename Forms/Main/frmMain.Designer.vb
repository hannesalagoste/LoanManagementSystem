<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.UserSettingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CreateLoanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoanListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClientListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AreaSettingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoanReleaseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CollectionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CashReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PaymentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoanPaymentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OtherPaymentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblRole = New System.Windows.Forms.Label()
        Me.lblUserLogin = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.OthersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CreateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip
        '
        Me.MenuStrip.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UserSettingToolStripMenuItem, Me.LoanToolStripMenuItem, Me.ClientListToolStripMenuItem, Me.AreaSettingToolStripMenuItem, Me.ReportsToolStripMenuItem, Me.PaymentToolStripMenuItem, Me.OthersToolStripMenuItem})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Padding = New System.Windows.Forms.Padding(7, 3, 0, 3)
        Me.MenuStrip.Size = New System.Drawing.Size(1168, 27)
        Me.MenuStrip.TabIndex = 0
        Me.MenuStrip.Text = "MenuStrip1"
        '
        'UserSettingToolStripMenuItem
        '
        Me.UserSettingToolStripMenuItem.Name = "UserSettingToolStripMenuItem"
        Me.UserSettingToolStripMenuItem.Size = New System.Drawing.Size(94, 21)
        Me.UserSettingToolStripMenuItem.Text = "User Setting"
        '
        'LoanToolStripMenuItem
        '
        Me.LoanToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CreateLoanToolStripMenuItem, Me.LoanListToolStripMenuItem})
        Me.LoanToolStripMenuItem.Name = "LoanToolStripMenuItem"
        Me.LoanToolStripMenuItem.Size = New System.Drawing.Size(49, 21)
        Me.LoanToolStripMenuItem.Text = "Loan"
        '
        'CreateLoanToolStripMenuItem
        '
        Me.CreateLoanToolStripMenuItem.Name = "CreateLoanToolStripMenuItem"
        Me.CreateLoanToolStripMenuItem.Size = New System.Drawing.Size(148, 22)
        Me.CreateLoanToolStripMenuItem.Text = "Create Loan"
        '
        'LoanListToolStripMenuItem
        '
        Me.LoanListToolStripMenuItem.Name = "LoanListToolStripMenuItem"
        Me.LoanListToolStripMenuItem.Size = New System.Drawing.Size(148, 22)
        Me.LoanListToolStripMenuItem.Text = "Loan List"
        '
        'ClientListToolStripMenuItem
        '
        Me.ClientListToolStripMenuItem.Name = "ClientListToolStripMenuItem"
        Me.ClientListToolStripMenuItem.Size = New System.Drawing.Size(78, 21)
        Me.ClientListToolStripMenuItem.Text = "Client List"
        '
        'AreaSettingToolStripMenuItem
        '
        Me.AreaSettingToolStripMenuItem.Name = "AreaSettingToolStripMenuItem"
        Me.AreaSettingToolStripMenuItem.Size = New System.Drawing.Size(95, 21)
        Me.AreaSettingToolStripMenuItem.Text = "Area Setting"
        '
        'ReportsToolStripMenuItem
        '
        Me.ReportsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LoanReleaseToolStripMenuItem, Me.CollectionToolStripMenuItem, Me.CashReportToolStripMenuItem})
        Me.ReportsToolStripMenuItem.Name = "ReportsToolStripMenuItem"
        Me.ReportsToolStripMenuItem.Size = New System.Drawing.Size(67, 21)
        Me.ReportsToolStripMenuItem.Text = "Reports"
        '
        'LoanReleaseToolStripMenuItem
        '
        Me.LoanReleaseToolStripMenuItem.Name = "LoanReleaseToolStripMenuItem"
        Me.LoanReleaseToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.LoanReleaseToolStripMenuItem.Text = "Loan Release"
        '
        'CollectionToolStripMenuItem
        '
        Me.CollectionToolStripMenuItem.Name = "CollectionToolStripMenuItem"
        Me.CollectionToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.CollectionToolStripMenuItem.Text = "Collection Report"
        '
        'CashReportToolStripMenuItem
        '
        Me.CashReportToolStripMenuItem.Name = "CashReportToolStripMenuItem"
        Me.CashReportToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.CashReportToolStripMenuItem.Text = "Cash Report"
        '
        'PaymentToolStripMenuItem
        '
        Me.PaymentToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LoanPaymentToolStripMenuItem, Me.OtherPaymentToolStripMenuItem})
        Me.PaymentToolStripMenuItem.Name = "PaymentToolStripMenuItem"
        Me.PaymentToolStripMenuItem.Size = New System.Drawing.Size(74, 21)
        Me.PaymentToolStripMenuItem.Text = "Payment"
        '
        'LoanPaymentToolStripMenuItem
        '
        Me.LoanPaymentToolStripMenuItem.Name = "LoanPaymentToolStripMenuItem"
        Me.LoanPaymentToolStripMenuItem.Size = New System.Drawing.Size(169, 22)
        Me.LoanPaymentToolStripMenuItem.Text = "Loan Payment"
        '
        'OtherPaymentToolStripMenuItem
        '
        Me.OtherPaymentToolStripMenuItem.Name = "OtherPaymentToolStripMenuItem"
        Me.OtherPaymentToolStripMenuItem.Size = New System.Drawing.Size(169, 22)
        Me.OtherPaymentToolStripMenuItem.Text = "Other Payment"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblDate)
        Me.GroupBox1.Controls.Add(Me.lblRole)
        Me.GroupBox1.Controls.Add(Me.lblUserLogin)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GroupBox1.Location = New System.Drawing.Point(0, 571)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(1168, 109)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Location = New System.Drawing.Point(45, 76)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(39, 17)
        Me.lblDate.TabIndex = 5
        Me.lblDate.Text = "Date "
        '
        'lblRole
        '
        Me.lblRole.AutoSize = True
        Me.lblRole.Location = New System.Drawing.Point(45, 51)
        Me.lblRole.Name = "lblRole"
        Me.lblRole.Size = New System.Drawing.Size(38, 17)
        Me.lblRole.TabIndex = 4
        Me.lblRole.Text = "Role "
        '
        'lblUserLogin
        '
        Me.lblUserLogin.AutoSize = True
        Me.lblUserLogin.Location = New System.Drawing.Point(45, 26)
        Me.lblUserLogin.Name = "lblUserLogin"
        Me.lblUserLogin.Size = New System.Drawing.Size(39, 17)
        Me.lblUserLogin.TabIndex = 3
        Me.lblUserLogin.Text = "User "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(7, 76)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Date :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(7, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Role :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(7, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "User :"
        '
        'OthersToolStripMenuItem
        '
        Me.OthersToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CreateToolStripMenuItem})
        Me.OthersToolStripMenuItem.Name = "OthersToolStripMenuItem"
        Me.OthersToolStripMenuItem.Size = New System.Drawing.Size(61, 21)
        Me.OthersToolStripMenuItem.Text = "Others"
        '
        'CreateToolStripMenuItem
        '
        Me.CreateToolStripMenuItem.Name = "CreateToolStripMenuItem"
        Me.CreateToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.CreateToolStripMenuItem.Text = "Create "
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1168, 680)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MainMenuStrip = Me.MenuStrip
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Main"
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip As MenuStrip
    Friend WithEvents UserSettingToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LoanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClientListToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AreaSettingToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblDate As Label
    Friend WithEvents lblRole As Label
    Friend WithEvents lblUserLogin As Label
    Friend WithEvents CreateLoanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LoanListToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReportsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LoanReleaseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CollectionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CashReportToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PaymentToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LoanPaymentToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OtherPaymentToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OthersToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CreateToolStripMenuItem As ToolStripMenuItem
End Class
