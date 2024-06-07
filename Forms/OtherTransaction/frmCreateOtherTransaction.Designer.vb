<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCreateOtherTransaction
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
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnCreateLoan = New System.Windows.Forms.Button()
        Me.btnCompute = New System.Windows.Forms.Button()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.txtNetProceeds = New System.Windows.Forms.TextBox()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.txtNewLoanBalance = New System.Windows.Forms.TextBox()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.txtInterestRate = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.txtLoanAmount = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.dtpMaturityDate = New System.Windows.Forms.DateTimePicker()
        Me.dtpEffectiveDate = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cboArea = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtCustomerName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtCusCode = New System.Windows.Forms.TextBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.lblID = New System.Windows.Forms.Label()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.Firebrick
        Me.btnClose.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.White
        Me.btnClose.Location = New System.Drawing.Point(294, 577)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(120, 41)
        Me.btnClose.TabIndex = 73
        Me.btnClose.Text = "CLOSE"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'btnCreateLoan
        '
        Me.btnCreateLoan.BackColor = System.Drawing.Color.Green
        Me.btnCreateLoan.Enabled = False
        Me.btnCreateLoan.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCreateLoan.ForeColor = System.Drawing.Color.White
        Me.btnCreateLoan.Location = New System.Drawing.Point(154, 577)
        Me.btnCreateLoan.Name = "btnCreateLoan"
        Me.btnCreateLoan.Size = New System.Drawing.Size(120, 41)
        Me.btnCreateLoan.TabIndex = 72
        Me.btnCreateLoan.Text = "CREATE"
        Me.btnCreateLoan.UseVisualStyleBackColor = False
        '
        'btnCompute
        '
        Me.btnCompute.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnCompute.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCompute.ForeColor = System.Drawing.Color.White
        Me.btnCompute.Location = New System.Drawing.Point(14, 577)
        Me.btnCompute.Name = "btnCompute"
        Me.btnCompute.Size = New System.Drawing.Size(120, 41)
        Me.btnCompute.TabIndex = 71
        Me.btnCompute.Text = "COMPUTE"
        Me.btnCompute.UseVisualStyleBackColor = False
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.txtNetProceeds)
        Me.GroupBox7.Controls.Add(Me.Label34)
        Me.GroupBox7.Controls.Add(Me.txtNewLoanBalance)
        Me.GroupBox7.Controls.Add(Me.Label33)
        Me.GroupBox7.Location = New System.Drawing.Point(206, 405)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(224, 154)
        Me.GroupBox7.TabIndex = 70
        Me.GroupBox7.TabStop = False
        '
        'txtNetProceeds
        '
        Me.txtNetProceeds.BackColor = System.Drawing.Color.LimeGreen
        Me.txtNetProceeds.Enabled = False
        Me.txtNetProceeds.Font = New System.Drawing.Font("Segoe UI", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNetProceeds.Location = New System.Drawing.Point(15, 111)
        Me.txtNetProceeds.Name = "txtNetProceeds"
        Me.txtNetProceeds.Size = New System.Drawing.Size(198, 30)
        Me.txtNetProceeds.TabIndex = 31
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.Location = New System.Drawing.Point(15, 93)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(89, 17)
        Me.Label34.TabIndex = 30
        Me.Label34.Text = "Net Proceeds"
        '
        'txtNewLoanBalance
        '
        Me.txtNewLoanBalance.Enabled = False
        Me.txtNewLoanBalance.Font = New System.Drawing.Font("Segoe UI", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNewLoanBalance.Location = New System.Drawing.Point(15, 41)
        Me.txtNewLoanBalance.Name = "txtNewLoanBalance"
        Me.txtNewLoanBalance.Size = New System.Drawing.Size(198, 30)
        Me.txtNewLoanBalance.TabIndex = 29
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.Location = New System.Drawing.Point(11, 21)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(120, 17)
        Me.Label33.TabIndex = 28
        Me.Label33.Text = "New Loan Balance"
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.txtInterestRate)
        Me.GroupBox6.Controls.Add(Me.Label24)
        Me.GroupBox6.Controls.Add(Me.txtLoanAmount)
        Me.GroupBox6.Controls.Add(Me.Label23)
        Me.GroupBox6.Location = New System.Drawing.Point(12, 270)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(418, 129)
        Me.GroupBox6.TabIndex = 69
        Me.GroupBox6.TabStop = False
        '
        'txtInterestRate
        '
        Me.txtInterestRate.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInterestRate.Location = New System.Drawing.Point(19, 86)
        Me.txtInterestRate.Name = "txtInterestRate"
        Me.txtInterestRate.Size = New System.Drawing.Size(384, 25)
        Me.txtInterestRate.TabIndex = 25
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(16, 66)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(170, 17)
        Me.Label24.TabIndex = 24
        Me.Label24.Text = "Interest Rate (%) (Optional )"
        '
        'txtLoanAmount
        '
        Me.txtLoanAmount.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLoanAmount.Location = New System.Drawing.Point(19, 32)
        Me.txtLoanAmount.Name = "txtLoanAmount"
        Me.txtLoanAmount.Size = New System.Drawing.Size(384, 25)
        Me.txtLoanAmount.TabIndex = 23
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(15, 12)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(53, 17)
        Me.Label23.TabIndex = 22
        Me.Label23.Text = "Amount"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label4)
        Me.GroupBox4.Controls.Add(Me.Label15)
        Me.GroupBox4.Controls.Add(Me.dtpMaturityDate)
        Me.GroupBox4.Controls.Add(Me.dtpEffectiveDate)
        Me.GroupBox4.Location = New System.Drawing.Point(12, 405)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(186, 149)
        Me.GroupBox4.TabIndex = 68
        Me.GroupBox4.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(9, 23)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 17)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "Date"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(9, 78)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(87, 17)
        Me.Label15.TabIndex = 21
        Me.Label15.Text = "Maturity Date"
        '
        'dtpMaturityDate
        '
        Me.dtpMaturityDate.CalendarFont = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpMaturityDate.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpMaturityDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpMaturityDate.Location = New System.Drawing.Point(12, 98)
        Me.dtpMaturityDate.Name = "dtpMaturityDate"
        Me.dtpMaturityDate.Size = New System.Drawing.Size(155, 27)
        Me.dtpMaturityDate.TabIndex = 20
        '
        'dtpEffectiveDate
        '
        Me.dtpEffectiveDate.CalendarFont = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpEffectiveDate.Enabled = False
        Me.dtpEffectiveDate.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpEffectiveDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpEffectiveDate.Location = New System.Drawing.Point(12, 43)
        Me.dtpEffectiveDate.Name = "dtpEffectiveDate"
        Me.dtpEffectiveDate.Size = New System.Drawing.Size(155, 27)
        Me.dtpEffectiveDate.TabIndex = 16
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cboArea)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.GroupBox5)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtCustomerName)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtCusCode)
        Me.GroupBox1.Controls.Add(Me.btnSearch)
        Me.GroupBox1.Controls.Add(Me.lblID)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(418, 252)
        Me.GroupBox1.TabIndex = 66
        Me.GroupBox1.TabStop = False
        '
        'cboArea
        '
        Me.cboArea.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboArea.FormattingEnabled = True
        Me.cboArea.Location = New System.Drawing.Point(18, 207)
        Me.cboArea.Name = "cboArea"
        Me.cboArea.Size = New System.Drawing.Size(384, 25)
        Me.cboArea.TabIndex = 18
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(16, 187)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(124, 17)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Account Description"
        '
        'TextBox1
        '
        Me.TextBox1.Enabled = False
        Me.TextBox1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(18, 152)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(385, 25)
        Me.TextBox1.TabIndex = 16
        '
        'GroupBox5
        '
        Me.GroupBox5.Location = New System.Drawing.Point(213, 252)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(190, 100)
        Me.GroupBox5.TabIndex = 13
        Me.GroupBox5.TabStop = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Location = New System.Drawing.Point(6, 258)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(412, 100)
        Me.GroupBox3.TabIndex = 12
        Me.GroupBox3.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(16, 132)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(35, 17)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Area"
        '
        'txtCustomerName
        '
        Me.txtCustomerName.Enabled = False
        Me.txtCustomerName.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCustomerName.Location = New System.Drawing.Point(18, 98)
        Me.txtCustomerName.Name = "txtCustomerName"
        Me.txtCustomerName.Size = New System.Drawing.Size(385, 25)
        Me.txtCustomerName.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(15, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 17)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Customer Code"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(15, 78)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(103, 17)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Customer Name"
        '
        'txtCusCode
        '
        Me.txtCusCode.Enabled = False
        Me.txtCusCode.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCusCode.Location = New System.Drawing.Point(18, 45)
        Me.txtCusCode.Name = "txtCusCode"
        Me.txtCusCode.Size = New System.Drawing.Size(313, 25)
        Me.txtCusCode.TabIndex = 5
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnSearch.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.ForeColor = System.Drawing.Color.White
        Me.btnSearch.Location = New System.Drawing.Point(339, 41)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(64, 35)
        Me.btnSearch.TabIndex = 7
        Me.btnSearch.Text = "SEARCH"
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.BackColor = System.Drawing.Color.Red
        Me.lblID.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblID.ForeColor = System.Drawing.Color.White
        Me.lblID.Location = New System.Drawing.Point(122, 25)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(21, 17)
        Me.lblID.TabIndex = 6
        Me.lblID.Text = "ID"
        '
        'frmCreateOtherTransaction
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(445, 634)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnCreateLoan)
        Me.Controls.Add(Me.btnCompute)
        Me.Controls.Add(Me.GroupBox7)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmCreateOtherTransaction"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Create Other Transaction"
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnClose As Button
    Friend WithEvents btnCreateLoan As Button
    Friend WithEvents btnCompute As Button
    Friend WithEvents GroupBox7 As GroupBox
    Friend WithEvents txtNetProceeds As TextBox
    Friend WithEvents Label34 As Label
    Friend WithEvents txtNewLoanBalance As TextBox
    Friend WithEvents Label33 As Label
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents txtInterestRate As TextBox
    Friend WithEvents Label24 As Label
    Friend WithEvents txtLoanAmount As TextBox
    Friend WithEvents Label23 As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Label15 As Label
    Friend WithEvents dtpMaturityDate As DateTimePicker
    Friend WithEvents dtpEffectiveDate As DateTimePicker
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtCustomerName As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtCusCode As TextBox
    Friend WithEvents btnSearch As Button
    Friend WithEvents lblID As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents cboArea As ComboBox
End Class
