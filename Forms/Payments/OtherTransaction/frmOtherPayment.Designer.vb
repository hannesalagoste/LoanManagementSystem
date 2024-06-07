<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOtherPayment
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtDepBank = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cboPaymode = New System.Windows.Forms.ComboBox()
        Me.txtCustomerName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtCusCode = New System.Windows.Forms.TextBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.dgvOtherPayment = New System.Windows.Forms.DataGridView()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnPayNow = New System.Windows.Forms.Button()
        Me.btnCompute = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvOtherPayment, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dgvOtherPayment)
        Me.GroupBox1.Controls.Add(Me.btnSearch)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtDepBank)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.cboPaymode)
        Me.GroupBox1.Controls.Add(Me.txtCustomerName)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtCusCode)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(662, 301)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(341, 66)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(60, 15)
        Me.Label7.TabIndex = 39
        Me.Label7.Text = "Dep. Bank"
        '
        'txtDepBank
        '
        Me.txtDepBank.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDepBank.Location = New System.Drawing.Point(344, 83)
        Me.txtDepBank.Name = "txtDepBank"
        Me.txtDepBank.Size = New System.Drawing.Size(303, 25)
        Me.txtDepBank.TabIndex = 38
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(6, 65)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 15)
        Me.Label5.TabIndex = 37
        Me.Label5.Text = "Pay Mode"
        '
        'cboPaymode
        '
        Me.cboPaymode.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboPaymode.FormattingEnabled = True
        Me.cboPaymode.Items.AddRange(New Object() {"Cash ", "Check"})
        Me.cboPaymode.Location = New System.Drawing.Point(9, 83)
        Me.cboPaymode.Name = "cboPaymode"
        Me.cboPaymode.Size = New System.Drawing.Size(289, 25)
        Me.cboPaymode.TabIndex = 36
        '
        'txtCustomerName
        '
        Me.txtCustomerName.BackColor = System.Drawing.Color.White
        Me.txtCustomerName.Enabled = False
        Me.txtCustomerName.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCustomerName.Location = New System.Drawing.Point(344, 35)
        Me.txtCustomerName.Name = "txtCustomerName"
        Me.txtCustomerName.Size = New System.Drawing.Size(303, 25)
        Me.txtCustomerName.TabIndex = 35
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 15)
        Me.Label1.TabIndex = 32
        Me.Label1.Text = "Customer Code"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(341, 17)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 15)
        Me.Label3.TabIndex = 34
        Me.Label3.Text = "Customer Name"
        '
        'txtCusCode
        '
        Me.txtCusCode.BackColor = System.Drawing.Color.White
        Me.txtCusCode.Enabled = False
        Me.txtCusCode.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCusCode.Location = New System.Drawing.Point(10, 35)
        Me.txtCusCode.Name = "txtCusCode"
        Me.txtCusCode.Size = New System.Drawing.Size(251, 25)
        Me.txtCusCode.TabIndex = 33
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnSearch.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.ForeColor = System.Drawing.Color.White
        Me.btnSearch.Location = New System.Drawing.Point(267, 30)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(61, 35)
        Me.btnSearch.TabIndex = 40
        Me.btnSearch.Text = "SEARCH"
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'dgvOtherPayment
        '
        Me.dgvOtherPayment.BackgroundColor = System.Drawing.Color.White
        Me.dgvOtherPayment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvOtherPayment.Location = New System.Drawing.Point(9, 129)
        Me.dgvOtherPayment.Name = "dgvOtherPayment"
        Me.dgvOtherPayment.Size = New System.Drawing.Size(638, 151)
        Me.dgvOtherPayment.TabIndex = 41
        '
        'btnClose
        '
        Me.btnClose.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClose.BackColor = System.Drawing.Color.Firebrick
        Me.btnClose.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.White
        Me.btnClose.Location = New System.Drawing.Point(443, 327)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(116, 45)
        Me.btnClose.TabIndex = 68
        Me.btnClose.Text = "CLOSE"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'btnPayNow
        '
        Me.btnPayNow.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPayNow.BackColor = System.Drawing.Color.Green
        Me.btnPayNow.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPayNow.ForeColor = System.Drawing.Color.White
        Me.btnPayNow.Location = New System.Drawing.Point(308, 327)
        Me.btnPayNow.Name = "btnPayNow"
        Me.btnPayNow.Size = New System.Drawing.Size(116, 45)
        Me.btnPayNow.TabIndex = 67
        Me.btnPayNow.Text = "PAY NOW"
        Me.btnPayNow.UseVisualStyleBackColor = False
        '
        'btnCompute
        '
        Me.btnCompute.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCompute.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnCompute.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCompute.ForeColor = System.Drawing.Color.White
        Me.btnCompute.Location = New System.Drawing.Point(173, 327)
        Me.btnCompute.Name = "btnCompute"
        Me.btnCompute.Size = New System.Drawing.Size(116, 45)
        Me.btnCompute.TabIndex = 66
        Me.btnCompute.Text = "COMPUTE"
        Me.btnCompute.UseVisualStyleBackColor = False
        '
        'frmOtherPayment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(686, 386)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnPayNow)
        Me.Controls.Add(Me.btnCompute)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmOtherPayment"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Other Payment"
        Me.TopMost = True
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvOtherPayment, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtDepBank As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents cboPaymode As ComboBox
    Friend WithEvents txtCustomerName As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtCusCode As TextBox
    Friend WithEvents btnSearch As Button
    Friend WithEvents dgvOtherPayment As DataGridView
    Friend WithEvents btnClose As Button
    Friend WithEvents btnPayNow As Button
    Friend WithEvents btnCompute As Button
End Class
