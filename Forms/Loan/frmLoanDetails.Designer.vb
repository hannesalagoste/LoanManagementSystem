<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLoanDetails
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtMonthlyInterest = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtMonthlyPrincipal = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtMonthlyAmort = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtInterestRate = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtTerms = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtLoanAmount = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtLoanTrans = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtLoanType = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtLedgerNo = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtMaturityDate = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtFirstDueDate = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtArea = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtCustomerName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtCusCode = New System.Windows.Forms.TextBox()
        Me.dtgvLedgerList = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnMakePayment = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.lblOldPrincipal = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dtgvLedgerList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtMonthlyInterest)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.txtMonthlyPrincipal)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.txtMonthlyAmort)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.txtInterestRate)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.txtTerms)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.txtLoanAmount)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.txtLoanTrans)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtLoanType)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtLedgerNo)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txtMaturityDate)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtFirstDueDate)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtArea)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtCustomerName)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtCusCode)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(708, 315)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        '
        'txtMonthlyInterest
        '
        Me.txtMonthlyInterest.BackColor = System.Drawing.Color.White
        Me.txtMonthlyInterest.Enabled = False
        Me.txtMonthlyInterest.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMonthlyInterest.Location = New System.Drawing.Point(480, 270)
        Me.txtMonthlyInterest.Name = "txtMonthlyInterest"
        Me.txtMonthlyInterest.Size = New System.Drawing.Size(213, 25)
        Me.txtMonthlyInterest.TabIndex = 33
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(477, 250)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(108, 17)
        Me.Label12.TabIndex = 32
        Me.Label12.Text = "Monthly Interest"
        '
        'txtMonthlyPrincipal
        '
        Me.txtMonthlyPrincipal.BackColor = System.Drawing.Color.White
        Me.txtMonthlyPrincipal.Enabled = False
        Me.txtMonthlyPrincipal.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMonthlyPrincipal.Location = New System.Drawing.Point(250, 270)
        Me.txtMonthlyPrincipal.Name = "txtMonthlyPrincipal"
        Me.txtMonthlyPrincipal.Size = New System.Drawing.Size(213, 25)
        Me.txtMonthlyPrincipal.TabIndex = 31
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(249, 250)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(115, 17)
        Me.Label13.TabIndex = 30
        Me.Label13.Text = "Monthly Principal"
        '
        'txtMonthlyAmort
        '
        Me.txtMonthlyAmort.BackColor = System.Drawing.Color.White
        Me.txtMonthlyAmort.Enabled = False
        Me.txtMonthlyAmort.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMonthlyAmort.Location = New System.Drawing.Point(20, 270)
        Me.txtMonthlyAmort.Name = "txtMonthlyAmort"
        Me.txtMonthlyAmort.Size = New System.Drawing.Size(213, 25)
        Me.txtMonthlyAmort.TabIndex = 29
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(17, 250)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(140, 17)
        Me.Label14.TabIndex = 28
        Me.Label14.Text = "Monthly Amortization"
        '
        'txtInterestRate
        '
        Me.txtInterestRate.BackColor = System.Drawing.Color.White
        Me.txtInterestRate.Enabled = False
        Me.txtInterestRate.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInterestRate.Location = New System.Drawing.Point(478, 212)
        Me.txtInterestRate.Name = "txtInterestRate"
        Me.txtInterestRate.Size = New System.Drawing.Size(213, 25)
        Me.txtInterestRate.TabIndex = 27
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(475, 192)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(85, 17)
        Me.Label9.TabIndex = 26
        Me.Label9.Text = "Interest Rate"
        '
        'txtTerms
        '
        Me.txtTerms.BackColor = System.Drawing.Color.White
        Me.txtTerms.Enabled = False
        Me.txtTerms.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTerms.Location = New System.Drawing.Point(248, 212)
        Me.txtTerms.Name = "txtTerms"
        Me.txtTerms.Size = New System.Drawing.Size(213, 25)
        Me.txtTerms.TabIndex = 25
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(247, 192)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(43, 17)
        Me.Label10.TabIndex = 24
        Me.Label10.Text = "Terms"
        '
        'txtLoanAmount
        '
        Me.txtLoanAmount.BackColor = System.Drawing.Color.White
        Me.txtLoanAmount.Enabled = False
        Me.txtLoanAmount.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLoanAmount.Location = New System.Drawing.Point(18, 212)
        Me.txtLoanAmount.Name = "txtLoanAmount"
        Me.txtLoanAmount.Size = New System.Drawing.Size(213, 25)
        Me.txtLoanAmount.TabIndex = 23
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(15, 192)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(88, 17)
        Me.Label11.TabIndex = 22
        Me.Label11.Text = "Loan Amount"
        '
        'txtLoanTrans
        '
        Me.txtLoanTrans.BackColor = System.Drawing.Color.White
        Me.txtLoanTrans.Enabled = False
        Me.txtLoanTrans.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLoanTrans.Location = New System.Drawing.Point(478, 156)
        Me.txtLoanTrans.Name = "txtLoanTrans"
        Me.txtLoanTrans.Size = New System.Drawing.Size(213, 25)
        Me.txtLoanTrans.TabIndex = 21
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(475, 136)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(75, 17)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "Loan Trans."
        '
        'txtLoanType
        '
        Me.txtLoanType.BackColor = System.Drawing.Color.White
        Me.txtLoanType.Enabled = False
        Me.txtLoanType.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLoanType.Location = New System.Drawing.Point(248, 156)
        Me.txtLoanType.Name = "txtLoanType"
        Me.txtLoanType.Size = New System.Drawing.Size(213, 25)
        Me.txtLoanType.TabIndex = 19
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(247, 136)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(68, 17)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "Loan Type"
        '
        'txtLedgerNo
        '
        Me.txtLedgerNo.BackColor = System.Drawing.Color.White
        Me.txtLedgerNo.Enabled = False
        Me.txtLedgerNo.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLedgerNo.Location = New System.Drawing.Point(18, 156)
        Me.txtLedgerNo.Name = "txtLedgerNo"
        Me.txtLedgerNo.Size = New System.Drawing.Size(213, 25)
        Me.txtLedgerNo.TabIndex = 17
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(15, 136)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(71, 17)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Ledger No."
        '
        'txtMaturityDate
        '
        Me.txtMaturityDate.BackColor = System.Drawing.Color.White
        Me.txtMaturityDate.Enabled = False
        Me.txtMaturityDate.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMaturityDate.Location = New System.Drawing.Point(478, 101)
        Me.txtMaturityDate.Name = "txtMaturityDate"
        Me.txtMaturityDate.Size = New System.Drawing.Size(213, 25)
        Me.txtMaturityDate.TabIndex = 15
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(475, 81)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(93, 17)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Maturity Date"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtFirstDueDate
        '
        Me.txtFirstDueDate.BackColor = System.Drawing.Color.White
        Me.txtFirstDueDate.Enabled = False
        Me.txtFirstDueDate.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFirstDueDate.Location = New System.Drawing.Point(248, 101)
        Me.txtFirstDueDate.Name = "txtFirstDueDate"
        Me.txtFirstDueDate.Size = New System.Drawing.Size(213, 25)
        Me.txtFirstDueDate.TabIndex = 13
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(247, 81)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 17)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "First Due Date"
        '
        'txtArea
        '
        Me.txtArea.BackColor = System.Drawing.Color.White
        Me.txtArea.Enabled = False
        Me.txtArea.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtArea.Location = New System.Drawing.Point(18, 101)
        Me.txtArea.Name = "txtArea"
        Me.txtArea.Size = New System.Drawing.Size(213, 25)
        Me.txtArea.TabIndex = 11
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(15, 81)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(36, 17)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Area"
        '
        'txtCustomerName
        '
        Me.txtCustomerName.BackColor = System.Drawing.Color.White
        Me.txtCustomerName.Enabled = False
        Me.txtCustomerName.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCustomerName.Location = New System.Drawing.Point(248, 45)
        Me.txtCustomerName.Name = "txtCustomerName"
        Me.txtCustomerName.Size = New System.Drawing.Size(443, 25)
        Me.txtCustomerName.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(15, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 17)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Customer Code"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(247, 25)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(103, 17)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Customer Name"
        '
        'txtCusCode
        '
        Me.txtCusCode.BackColor = System.Drawing.Color.White
        Me.txtCusCode.Enabled = False
        Me.txtCusCode.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCusCode.Location = New System.Drawing.Point(18, 45)
        Me.txtCusCode.Name = "txtCusCode"
        Me.txtCusCode.Size = New System.Drawing.Size(213, 25)
        Me.txtCusCode.TabIndex = 5
        '
        'dtgvLedgerList
        '
        Me.dtgvLedgerList.AllowUserToAddRows = False
        Me.dtgvLedgerList.AllowUserToDeleteRows = False
        Me.dtgvLedgerList.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtgvLedgerList.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dtgvLedgerList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgvLedgerList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column8, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7})
        Me.dtgvLedgerList.Location = New System.Drawing.Point(12, 331)
        Me.dtgvLedgerList.Name = "dtgvLedgerList"
        Me.dtgvLedgerList.ReadOnly = True
        Me.dtgvLedgerList.RowHeadersVisible = False
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtgvLedgerList.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.dtgvLedgerList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtgvLedgerList.Size = New System.Drawing.Size(708, 150)
        Me.dtgvLedgerList.TabIndex = 12
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column1.DataPropertyName = "PayDate"
        Me.Column1.HeaderText = "Document Date"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column8
        '
        Me.Column8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column8.DataPropertyName = "ReceiptNo"
        Me.Column8.HeaderText = "Receipt No."
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column2.DataPropertyName = "FormattedPrinAmount"
        Me.Column2.HeaderText = "Principal Amount"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column3.DataPropertyName = "FormattedPrinPayment"
        Me.Column3.HeaderText = "Principal Payments"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column4.DataPropertyName = "FormattedPrinBalance"
        Me.Column4.HeaderText = "Principal Balance"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'Column5
        '
        Me.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column5.DataPropertyName = "FormattedInterestAmount"
        Me.Column5.HeaderText = "Interest Amount"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'Column6
        '
        Me.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column6.DataPropertyName = "FormattedInterestPayment"
        Me.Column6.HeaderText = "Interest Payment"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        '
        'Column7
        '
        Me.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column7.DataPropertyName = "Penalty"
        Me.Column7.HeaderText = "Penalty"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        '
        'btnMakePayment
        '
        Me.btnMakePayment.BackColor = System.Drawing.Color.Green
        Me.btnMakePayment.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMakePayment.ForeColor = System.Drawing.Color.White
        Me.btnMakePayment.Location = New System.Drawing.Point(210, 509)
        Me.btnMakePayment.Name = "btnMakePayment"
        Me.btnMakePayment.Size = New System.Drawing.Size(141, 45)
        Me.btnMakePayment.TabIndex = 63
        Me.btnMakePayment.Text = "MAKE PAYMENT"
        Me.btnMakePayment.UseVisualStyleBackColor = False
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.Firebrick
        Me.btnClose.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.White
        Me.btnClose.Location = New System.Drawing.Point(368, 509)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(141, 45)
        Me.btnClose.TabIndex = 64
        Me.btnClose.Text = "CLOSE"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'lblOldPrincipal
        '
        Me.lblOldPrincipal.AutoSize = True
        Me.lblOldPrincipal.BackColor = System.Drawing.Color.Red
        Me.lblOldPrincipal.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOldPrincipal.ForeColor = System.Drawing.Color.White
        Me.lblOldPrincipal.Location = New System.Drawing.Point(27, 523)
        Me.lblOldPrincipal.Name = "lblOldPrincipal"
        Me.lblOldPrincipal.Size = New System.Drawing.Size(86, 17)
        Me.lblOldPrincipal.TabIndex = 67
        Me.lblOldPrincipal.Text = "Old Principal"
        '
        'frmLoanDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(731, 598)
        Me.Controls.Add(Me.lblOldPrincipal)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnMakePayment)
        Me.Controls.Add(Me.dtgvLedgerList)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmLoanDetails"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Loan Details"
        Me.TopMost = True
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dtgvLedgerList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtArea As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtCustomerName As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtCusCode As TextBox
    Friend WithEvents txtMaturityDate As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtFirstDueDate As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtMonthlyInterest As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txtMonthlyPrincipal As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents txtMonthlyAmort As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents txtInterestRate As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtTerms As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtLoanAmount As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txtLoanTrans As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtLoanType As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtLedgerNo As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents dtgvLedgerList As DataGridView
    Friend WithEvents btnMakePayment As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents lblOldPrincipal As Label
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
End Class
