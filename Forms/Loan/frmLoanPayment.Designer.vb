<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLoanPayment
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
        Me.Label22 = New System.Windows.Forms.Label()
        Me.ckbReceipt = New System.Windows.Forms.CheckBox()
        Me.txtLoanType = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtDepBank = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtInterestRate = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cboPaymode = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtChargeCode = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.dtpDate = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtDocNo = New System.Windows.Forms.TextBox()
        Me.txtCustomerName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtCusCode = New System.Windows.Forms.TextBox()
        Me.txtLedgerNo = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.dtgvDueDateList = New System.Windows.Forms.DataGridView()
        Me.DueDateLID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PaymentStatus = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DueDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtMonthlyPrincipal = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtMonthlyInterest = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtMonthlyAmort = New System.Windows.Forms.TextBox()
        Me.rdbManual = New System.Windows.Forms.RadioButton()
        Me.rdbAuto = New System.Windows.Forms.RadioButton()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtRefund = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtCHKAmount = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtCHKNumber = New System.Windows.Forms.TextBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtProcessor = New System.Windows.Forms.TextBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.lblLoanBalance = New System.Windows.Forms.Label()
        Me.lblTotalPayablePay = New System.Windows.Forms.Label()
        Me.lblOldbalance = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txtPenaltyAmountPay = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtPrincipalAmountPay = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtInterestAmountPay = New System.Windows.Forms.TextBox()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnPayNow = New System.Windows.Forms.Button()
        Me.btnCompute = New System.Windows.Forms.Button()
        Me.lblOldPrincipal = New System.Windows.Forms.Label()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.lblDueDate = New System.Windows.Forms.Label()
        Me.lblSelectDate = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dtgvDueDateList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label22)
        Me.GroupBox1.Controls.Add(Me.ckbReceipt)
        Me.GroupBox1.Controls.Add(Me.txtLoanType)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtDepBank)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtInterestRate)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.cboPaymode)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtChargeCode)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.dtpDate)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtDocNo)
        Me.GroupBox1.Controls.Add(Me.txtCustomerName)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtCusCode)
        Me.GroupBox1.Controls.Add(Me.txtLedgerNo)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(640, 202)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(17, 138)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(68, 17)
        Me.Label22.TabIndex = 34
        Me.Label22.Text = "Loan Type"
        '
        'ckbReceipt
        '
        Me.ckbReceipt.AutoSize = True
        Me.ckbReceipt.Font = New System.Drawing.Font("Segoe UI", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ckbReceipt.Location = New System.Drawing.Point(234, 45)
        Me.ckbReceipt.Name = "ckbReceipt"
        Me.ckbReceipt.Size = New System.Drawing.Size(74, 21)
        Me.ckbReceipt.TabIndex = 33
        Me.ckbReceipt.Text = "Manual"
        Me.ckbReceipt.UseVisualStyleBackColor = True
        '
        'txtLoanType
        '
        Me.txtLoanType.BackColor = System.Drawing.Color.White
        Me.txtLoanType.Enabled = False
        Me.txtLoanType.Font = New System.Drawing.Font("Segoe UI Black", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLoanType.Location = New System.Drawing.Point(19, 157)
        Me.txtLoanType.Name = "txtLoanType"
        Me.txtLoanType.Size = New System.Drawing.Size(141, 25)
        Me.txtLoanType.TabIndex = 35
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(484, 138)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(69, 17)
        Me.Label7.TabIndex = 31
        Me.Label7.Text = "Dep. Bank"
        '
        'txtDepBank
        '
        Me.txtDepBank.Font = New System.Drawing.Font("Segoe UI Black", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDepBank.Location = New System.Drawing.Point(487, 157)
        Me.txtDepBank.Name = "txtDepBank"
        Me.txtDepBank.Size = New System.Drawing.Size(133, 25)
        Me.txtDepBank.TabIndex = 30
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(171, 138)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(104, 17)
        Me.Label6.TabIndex = 28
        Me.Label6.Text = "Interest Rate(%)"
        '
        'txtInterestRate
        '
        Me.txtInterestRate.BackColor = System.Drawing.Color.White
        Me.txtInterestRate.Enabled = False
        Me.txtInterestRate.Font = New System.Drawing.Font("Segoe UI Black", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInterestRate.Location = New System.Drawing.Point(174, 157)
        Me.txtInterestRate.Name = "txtInterestRate"
        Me.txtInterestRate.Size = New System.Drawing.Size(143, 25)
        Me.txtInterestRate.TabIndex = 29
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(328, 137)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(66, 17)
        Me.Label5.TabIndex = 27
        Me.Label5.Text = "Pay Mode"
        '
        'cboPaymode
        '
        Me.cboPaymode.Font = New System.Drawing.Font("Segoe UI Black", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboPaymode.FormattingEnabled = True
        Me.cboPaymode.Items.AddRange(New Object() {"Cash ", "Check"})
        Me.cboPaymode.Location = New System.Drawing.Point(331, 157)
        Me.cboPaymode.Name = "cboPaymode"
        Me.cboPaymode.Size = New System.Drawing.Size(142, 25)
        Me.cboPaymode.TabIndex = 26
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(498, 81)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 17)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "Chrg. Code"
        '
        'txtChargeCode
        '
        Me.txtChargeCode.BackColor = System.Drawing.Color.White
        Me.txtChargeCode.Enabled = False
        Me.txtChargeCode.Font = New System.Drawing.Font("Segoe UI Black", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtChargeCode.Location = New System.Drawing.Point(501, 100)
        Me.txtChargeCode.Name = "txtChargeCode"
        Me.txtChargeCode.Size = New System.Drawing.Size(119, 25)
        Me.txtChargeCode.TabIndex = 25
        Me.txtChargeCode.Text = "L/R"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(496, 24)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(37, 17)
        Me.Label13.TabIndex = 23
        Me.Label13.Text = "Date"
        '
        'dtpDate
        '
        Me.dtpDate.CalendarMonthBackground = System.Drawing.Color.White
        Me.dtpDate.Enabled = False
        Me.dtpDate.Font = New System.Drawing.Font("Segoe UI Black", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDate.Location = New System.Drawing.Point(499, 44)
        Me.dtpDate.Name = "dtpDate"
        Me.dtpDate.Size = New System.Drawing.Size(121, 25)
        Me.dtpDate.TabIndex = 22
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(231, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(135, 17)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "Doc. No. /Receipt No."
        '
        'txtDocNo
        '
        Me.txtDocNo.BackColor = System.Drawing.Color.White
        Me.txtDocNo.Enabled = False
        Me.txtDocNo.Font = New System.Drawing.Font("Segoe UI Black", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDocNo.Location = New System.Drawing.Point(311, 44)
        Me.txtDocNo.Name = "txtDocNo"
        Me.txtDocNo.Size = New System.Drawing.Size(179, 25)
        Me.txtDocNo.TabIndex = 20
        '
        'txtCustomerName
        '
        Me.txtCustomerName.BackColor = System.Drawing.Color.White
        Me.txtCustomerName.Enabled = False
        Me.txtCustomerName.Font = New System.Drawing.Font("Segoe UI Black", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCustomerName.Location = New System.Drawing.Point(232, 100)
        Me.txtCustomerName.Name = "txtCustomerName"
        Me.txtCustomerName.Size = New System.Drawing.Size(258, 25)
        Me.txtCustomerName.TabIndex = 17
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 80)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 17)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Customer Code"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(229, 80)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(103, 17)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Customer Name"
        '
        'txtCusCode
        '
        Me.txtCusCode.BackColor = System.Drawing.Color.White
        Me.txtCusCode.Enabled = False
        Me.txtCusCode.Font = New System.Drawing.Font("Segoe UI Black", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCusCode.Location = New System.Drawing.Point(19, 100)
        Me.txtCusCode.Name = "txtCusCode"
        Me.txtCusCode.Size = New System.Drawing.Size(204, 25)
        Me.txtCusCode.TabIndex = 15
        '
        'txtLedgerNo
        '
        Me.txtLedgerNo.BackColor = System.Drawing.Color.White
        Me.txtLedgerNo.Enabled = False
        Me.txtLedgerNo.Font = New System.Drawing.Font("Segoe UI Black", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLedgerNo.Location = New System.Drawing.Point(19, 44)
        Me.txtLedgerNo.Name = "txtLedgerNo"
        Me.txtLedgerNo.Size = New System.Drawing.Size(204, 25)
        Me.txtLedgerNo.TabIndex = 19
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(16, 24)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(71, 17)
        Me.Label11.TabIndex = 18
        Me.Label11.Text = "Ledger No."
        '
        'dtgvDueDateList
        '
        Me.dtgvDueDateList.AllowUserToAddRows = False
        Me.dtgvDueDateList.AllowUserToDeleteRows = False
        Me.dtgvDueDateList.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtgvDueDateList.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dtgvDueDateList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgvDueDateList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DueDateLID, Me.Column1, Me.PaymentStatus, Me.Column2, Me.Column3, Me.DueDate})
        Me.dtgvDueDateList.Location = New System.Drawing.Point(664, 32)
        Me.dtgvDueDateList.Name = "dtgvDueDateList"
        Me.dtgvDueDateList.RowHeadersVisible = False
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtgvDueDateList.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.dtgvDueDateList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtgvDueDateList.Size = New System.Drawing.Size(160, 541)
        Me.dtgvDueDateList.TabIndex = 16
        '
        'DueDateLID
        '
        Me.DueDateLID.DataPropertyName = "DueDateLID"
        Me.DueDateLID.HeaderText = "DueDateLID"
        Me.DueDateLID.Name = "DueDateLID"
        Me.DueDateLID.Visible = False
        '
        'Column1
        '
        Me.Column1.HeaderText = "CustCode"
        Me.Column1.Name = "Column1"
        Me.Column1.Visible = False
        '
        'PaymentStatus
        '
        Me.PaymentStatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.PaymentStatus.DataPropertyName = "PaymentStatus"
        Me.PaymentStatus.HeaderText = "Payment Status"
        Me.PaymentStatus.Items.AddRange(New Object() {"Partial", "Paid"})
        Me.PaymentStatus.Name = "PaymentStatus"
        '
        'Column2
        '
        Me.Column2.HeaderText = "LDSN"
        Me.Column2.Name = "Column2"
        Me.Column2.Visible = False
        '
        'Column3
        '
        Me.Column3.HeaderText = "Ledger No"
        Me.Column3.Name = "Column3"
        Me.Column3.Visible = False
        '
        'DueDate
        '
        Me.DueDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DueDate.DataPropertyName = "DueDate"
        Me.DueDate.HeaderText = "Due Dates"
        Me.DueDate.Name = "DueDate"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.txtMonthlyPrincipal)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.txtMonthlyInterest)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.txtMonthlyAmort)
        Me.GroupBox2.Controls.Add(Me.rdbManual)
        Me.GroupBox2.Controls.Add(Me.rdbAuto)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 221)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(396, 131)
        Me.GroupBox2.TabIndex = 17
        Me.GroupBox2.TabStop = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(211, 18)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(115, 17)
        Me.Label10.TabIndex = 30
        Me.Label10.Text = "Monthly Principal"
        '
        'txtMonthlyPrincipal
        '
        Me.txtMonthlyPrincipal.BackColor = System.Drawing.Color.White
        Me.txtMonthlyPrincipal.Enabled = False
        Me.txtMonthlyPrincipal.Font = New System.Drawing.Font("Segoe UI Black", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMonthlyPrincipal.Location = New System.Drawing.Point(214, 38)
        Me.txtMonthlyPrincipal.Name = "txtMonthlyPrincipal"
        Me.txtMonthlyPrincipal.Size = New System.Drawing.Size(168, 25)
        Me.txtMonthlyPrincipal.TabIndex = 31
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(211, 68)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(108, 17)
        Me.Label9.TabIndex = 28
        Me.Label9.Text = "Monthly Interest"
        '
        'txtMonthlyInterest
        '
        Me.txtMonthlyInterest.BackColor = System.Drawing.Color.White
        Me.txtMonthlyInterest.Enabled = False
        Me.txtMonthlyInterest.Font = New System.Drawing.Font("Segoe UI Black", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMonthlyInterest.Location = New System.Drawing.Point(214, 88)
        Me.txtMonthlyInterest.Name = "txtMonthlyInterest"
        Me.txtMonthlyInterest.Size = New System.Drawing.Size(168, 25)
        Me.txtMonthlyInterest.TabIndex = 29
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(16, 68)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(140, 17)
        Me.Label8.TabIndex = 26
        Me.Label8.Text = "Monthly Amortization"
        '
        'txtMonthlyAmort
        '
        Me.txtMonthlyAmort.BackColor = System.Drawing.Color.White
        Me.txtMonthlyAmort.Enabled = False
        Me.txtMonthlyAmort.Font = New System.Drawing.Font("Segoe UI Black", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMonthlyAmort.Location = New System.Drawing.Point(19, 87)
        Me.txtMonthlyAmort.Name = "txtMonthlyAmort"
        Me.txtMonthlyAmort.Size = New System.Drawing.Size(179, 25)
        Me.txtMonthlyAmort.TabIndex = 27
        '
        'rdbManual
        '
        Me.rdbManual.AutoSize = True
        Me.rdbManual.Font = New System.Drawing.Font("Segoe UI", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbManual.Location = New System.Drawing.Point(87, 33)
        Me.rdbManual.Name = "rdbManual"
        Me.rdbManual.Size = New System.Drawing.Size(81, 24)
        Me.rdbManual.TabIndex = 22
        Me.rdbManual.TabStop = True
        Me.rdbManual.Text = "Manual"
        Me.rdbManual.UseVisualStyleBackColor = True
        '
        'rdbAuto
        '
        Me.rdbAuto.AutoSize = True
        Me.rdbAuto.Font = New System.Drawing.Font("Segoe UI", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbAuto.Location = New System.Drawing.Point(23, 33)
        Me.rdbAuto.Name = "rdbAuto"
        Me.rdbAuto.Size = New System.Drawing.Size(62, 24)
        Me.rdbAuto.TabIndex = 21
        Me.rdbAuto.TabStop = True
        Me.rdbAuto.Text = "Auto"
        Me.rdbAuto.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label15)
        Me.GroupBox3.Controls.Add(Me.txtRefund)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.txtCHKAmount)
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Controls.Add(Me.txtCHKNumber)
        Me.GroupBox3.Location = New System.Drawing.Point(13, 359)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(395, 138)
        Me.GroupBox3.TabIndex = 18
        Me.GroupBox3.TabStop = False
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(15, 75)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(50, 17)
        Me.Label15.TabIndex = 30
        Me.Label15.Text = "Refund"
        '
        'txtRefund
        '
        Me.txtRefund.BackColor = System.Drawing.Color.White
        Me.txtRefund.Enabled = False
        Me.txtRefund.Font = New System.Drawing.Font("Segoe UI Black", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRefund.Location = New System.Drawing.Point(18, 95)
        Me.txtRefund.Name = "txtRefund"
        Me.txtRefund.Size = New System.Drawing.Size(363, 25)
        Me.txtRefund.TabIndex = 31
        Me.txtRefund.Text = "00.00"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(228, 19)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(86, 17)
        Me.Label12.TabIndex = 28
        Me.Label12.Text = "CHK Amount"
        '
        'txtCHKAmount
        '
        Me.txtCHKAmount.BackColor = System.Drawing.Color.White
        Me.txtCHKAmount.Enabled = False
        Me.txtCHKAmount.Font = New System.Drawing.Font("Segoe UI Black", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCHKAmount.Location = New System.Drawing.Point(229, 39)
        Me.txtCHKAmount.Name = "txtCHKAmount"
        Me.txtCHKAmount.Size = New System.Drawing.Size(152, 25)
        Me.txtCHKAmount.TabIndex = 29
        Me.txtCHKAmount.Text = "00.00"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(15, 19)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(144, 17)
        Me.Label14.TabIndex = 26
        Me.Label14.Text = "CHK#/Others Payment"
        '
        'txtCHKNumber
        '
        Me.txtCHKNumber.BackColor = System.Drawing.Color.White
        Me.txtCHKNumber.Enabled = False
        Me.txtCHKNumber.Font = New System.Drawing.Font("Segoe UI Black", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCHKNumber.Location = New System.Drawing.Point(18, 39)
        Me.txtCHKNumber.Name = "txtCHKNumber"
        Me.txtCHKNumber.Size = New System.Drawing.Size(204, 25)
        Me.txtCHKNumber.TabIndex = 27
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label16)
        Me.GroupBox4.Controls.Add(Me.txtProcessor)
        Me.GroupBox4.Location = New System.Drawing.Point(13, 504)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(395, 69)
        Me.GroupBox4.TabIndex = 19
        Me.GroupBox4.TabStop = False
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(15, 10)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(63, 17)
        Me.Label16.TabIndex = 32
        Me.Label16.Text = "Processor"
        '
        'txtProcessor
        '
        Me.txtProcessor.BackColor = System.Drawing.Color.White
        Me.txtProcessor.Enabled = False
        Me.txtProcessor.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProcessor.Location = New System.Drawing.Point(18, 30)
        Me.txtProcessor.Name = "txtProcessor"
        Me.txtProcessor.Size = New System.Drawing.Size(363, 25)
        Me.txtProcessor.TabIndex = 33
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.lblLoanBalance)
        Me.GroupBox5.Controls.Add(Me.lblTotalPayablePay)
        Me.GroupBox5.Controls.Add(Me.lblOldbalance)
        Me.GroupBox5.Controls.Add(Me.Label23)
        Me.GroupBox5.Controls.Add(Me.Label21)
        Me.GroupBox5.Controls.Add(Me.Label20)
        Me.GroupBox5.Controls.Add(Me.Label19)
        Me.GroupBox5.Controls.Add(Me.txtPenaltyAmountPay)
        Me.GroupBox5.Controls.Add(Me.Label18)
        Me.GroupBox5.Controls.Add(Me.txtPrincipalAmountPay)
        Me.GroupBox5.Controls.Add(Me.Label17)
        Me.GroupBox5.Controls.Add(Me.txtInterestAmountPay)
        Me.GroupBox5.Location = New System.Drawing.Point(420, 221)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(232, 352)
        Me.GroupBox5.TabIndex = 20
        Me.GroupBox5.TabStop = False
        '
        'lblLoanBalance
        '
        Me.lblLoanBalance.BackColor = System.Drawing.Color.LimeGreen
        Me.lblLoanBalance.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLoanBalance.ForeColor = System.Drawing.Color.White
        Me.lblLoanBalance.Location = New System.Drawing.Point(16, 313)
        Me.lblLoanBalance.Name = "lblLoanBalance"
        Me.lblLoanBalance.Size = New System.Drawing.Size(201, 25)
        Me.lblLoanBalance.TabIndex = 71
        '
        'lblTotalPayablePay
        '
        Me.lblTotalPayablePay.BackColor = System.Drawing.Color.Orange
        Me.lblTotalPayablePay.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalPayablePay.ForeColor = System.Drawing.Color.White
        Me.lblTotalPayablePay.Location = New System.Drawing.Point(16, 260)
        Me.lblTotalPayablePay.Name = "lblTotalPayablePay"
        Me.lblTotalPayablePay.Size = New System.Drawing.Size(201, 25)
        Me.lblTotalPayablePay.TabIndex = 70
        '
        'lblOldbalance
        '
        Me.lblOldbalance.BackColor = System.Drawing.Color.Brown
        Me.lblOldbalance.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOldbalance.ForeColor = System.Drawing.Color.White
        Me.lblOldbalance.Location = New System.Drawing.Point(16, 202)
        Me.lblOldbalance.Name = "lblOldbalance"
        Me.lblOldbalance.Size = New System.Drawing.Size(201, 25)
        Me.lblOldbalance.TabIndex = 69
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Segoe UI", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(13, 181)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(83, 17)
        Me.Label23.TabIndex = 38
        Me.Label23.Text = "Old Balance"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Segoe UI", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(13, 293)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(91, 17)
        Me.Label21.TabIndex = 36
        Me.Label21.Text = "Loan Balance"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Segoe UI", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(12, 237)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(94, 17)
        Me.Label20.TabIndex = 34
        Me.Label20.Text = "Total Payable"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(10, 121)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(106, 17)
        Me.Label19.TabIndex = 32
        Me.Label19.Text = "Penalty Amount"
        '
        'txtPenaltyAmountPay
        '
        Me.txtPenaltyAmountPay.BackColor = System.Drawing.Color.White
        Me.txtPenaltyAmountPay.Enabled = False
        Me.txtPenaltyAmountPay.Font = New System.Drawing.Font("Segoe UI Black", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPenaltyAmountPay.Location = New System.Drawing.Point(13, 141)
        Me.txtPenaltyAmountPay.Name = "txtPenaltyAmountPay"
        Me.txtPenaltyAmountPay.Size = New System.Drawing.Size(204, 28)
        Me.txtPenaltyAmountPay.TabIndex = 33
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(12, 68)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(113, 17)
        Me.Label18.TabIndex = 30
        Me.Label18.Text = "Principal Amount"
        '
        'txtPrincipalAmountPay
        '
        Me.txtPrincipalAmountPay.BackColor = System.Drawing.Color.White
        Me.txtPrincipalAmountPay.Enabled = False
        Me.txtPrincipalAmountPay.Font = New System.Drawing.Font("Segoe UI Black", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrincipalAmountPay.Location = New System.Drawing.Point(15, 88)
        Me.txtPrincipalAmountPay.Name = "txtPrincipalAmountPay"
        Me.txtPrincipalAmountPay.Size = New System.Drawing.Size(204, 28)
        Me.txtPrincipalAmountPay.TabIndex = 31
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(10, 15)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(106, 17)
        Me.Label17.TabIndex = 28
        Me.Label17.Text = "Interest Amount"
        '
        'txtInterestAmountPay
        '
        Me.txtInterestAmountPay.BackColor = System.Drawing.Color.White
        Me.txtInterestAmountPay.Enabled = False
        Me.txtInterestAmountPay.Font = New System.Drawing.Font("Segoe UI Black", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInterestAmountPay.Location = New System.Drawing.Point(13, 35)
        Me.txtInterestAmountPay.Name = "txtInterestAmountPay"
        Me.txtInterestAmountPay.Size = New System.Drawing.Size(204, 28)
        Me.txtInterestAmountPay.TabIndex = 29
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.Firebrick
        Me.btnClose.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.White
        Me.btnClose.Location = New System.Drawing.Point(433, 596)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(141, 45)
        Me.btnClose.TabIndex = 65
        Me.btnClose.Text = "CLOSE"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'btnPayNow
        '
        Me.btnPayNow.BackColor = System.Drawing.Color.Green
        Me.btnPayNow.Enabled = False
        Me.btnPayNow.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPayNow.ForeColor = System.Drawing.Color.White
        Me.btnPayNow.Location = New System.Drawing.Point(280, 596)
        Me.btnPayNow.Name = "btnPayNow"
        Me.btnPayNow.Size = New System.Drawing.Size(141, 45)
        Me.btnPayNow.TabIndex = 64
        Me.btnPayNow.Text = "PAY NOW"
        Me.btnPayNow.UseVisualStyleBackColor = False
        '
        'btnCompute
        '
        Me.btnCompute.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnCompute.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCompute.ForeColor = System.Drawing.Color.White
        Me.btnCompute.Location = New System.Drawing.Point(127, 596)
        Me.btnCompute.Name = "btnCompute"
        Me.btnCompute.Size = New System.Drawing.Size(141, 45)
        Me.btnCompute.TabIndex = 63
        Me.btnCompute.Text = "COMPUTE"
        Me.btnCompute.UseVisualStyleBackColor = False
        '
        'lblOldPrincipal
        '
        Me.lblOldPrincipal.AutoSize = True
        Me.lblOldPrincipal.BackColor = System.Drawing.Color.Red
        Me.lblOldPrincipal.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOldPrincipal.ForeColor = System.Drawing.Color.White
        Me.lblOldPrincipal.Location = New System.Drawing.Point(599, 589)
        Me.lblOldPrincipal.Name = "lblOldPrincipal"
        Me.lblOldPrincipal.Size = New System.Drawing.Size(86, 17)
        Me.lblOldPrincipal.TabIndex = 66
        Me.lblOldPrincipal.Text = "Old Principal"
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.BackColor = System.Drawing.Color.Red
        Me.lblStatus.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.ForeColor = System.Drawing.Color.White
        Me.lblStatus.Location = New System.Drawing.Point(599, 609)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(45, 17)
        Me.lblStatus.TabIndex = 67
        Me.lblStatus.Text = "Status"
        '
        'lblDueDate
        '
        Me.lblDueDate.AutoSize = True
        Me.lblDueDate.BackColor = System.Drawing.Color.Red
        Me.lblDueDate.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDueDate.ForeColor = System.Drawing.Color.White
        Me.lblDueDate.Location = New System.Drawing.Point(599, 629)
        Me.lblDueDate.Name = "lblDueDate"
        Me.lblDueDate.Size = New System.Drawing.Size(66, 17)
        Me.lblDueDate.TabIndex = 68
        Me.lblDueDate.Text = "Due Date"
        '
        'lblSelectDate
        '
        Me.lblSelectDate.AutoSize = True
        Me.lblSelectDate.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSelectDate.ForeColor = System.Drawing.Color.Black
        Me.lblSelectDate.Location = New System.Drawing.Point(661, 12)
        Me.lblSelectDate.Name = "lblSelectDate"
        Me.lblSelectDate.Size = New System.Drawing.Size(149, 17)
        Me.lblSelectDate.TabIndex = 70
        Me.lblSelectDate.Text = "Please Select Due Date"
        '
        'frmLoanPayment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(836, 681)
        Me.Controls.Add(Me.lblSelectDate)
        Me.Controls.Add(Me.lblDueDate)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.lblOldPrincipal)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnPayNow)
        Me.Controls.Add(Me.btnCompute)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.dtgvDueDateList)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmLoanPayment"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " "
        Me.TopMost = True
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dtgvDueDateList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtCustomerName As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtCusCode As TextBox
    Friend WithEvents txtLedgerNo As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents dtgvDueDateList As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents txtDocNo As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents dtpDate As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents txtChargeCode As TextBox
    Friend WithEvents txtDepBank As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtInterestRate As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents cboPaymode As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents rdbManual As RadioButton
    Friend WithEvents rdbAuto As RadioButton
    Friend WithEvents Label9 As Label
    Friend WithEvents txtMonthlyInterest As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtMonthlyAmort As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtMonthlyPrincipal As TextBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txtCHKAmount As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents txtCHKNumber As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents txtRefund As TextBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Label16 As Label
    Friend WithEvents txtProcessor As TextBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents Label18 As Label
    Friend WithEvents txtPrincipalAmountPay As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents txtInterestAmountPay As TextBox
    Friend WithEvents Label21 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents txtPenaltyAmountPay As TextBox
    Friend WithEvents btnClose As Button
    Friend WithEvents btnPayNow As Button
    Friend WithEvents btnCompute As Button
    Friend WithEvents lblOldPrincipal As Label
    Friend WithEvents lblStatus As Label
    Friend WithEvents lblDueDate As Label
    Friend WithEvents DueDateLID As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents PaymentStatus As DataGridViewComboBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents DueDate As DataGridViewTextBoxColumn
    Friend WithEvents ckbReceipt As CheckBox
    Friend WithEvents Label22 As Label
    Friend WithEvents txtLoanType As TextBox
    Friend WithEvents Label23 As Label
    Friend WithEvents lblOldbalance As Label
    Friend WithEvents lblTotalPayablePay As Label
    Friend WithEvents lblLoanBalance As Label
    Friend WithEvents lblSelectDate As Label
End Class
