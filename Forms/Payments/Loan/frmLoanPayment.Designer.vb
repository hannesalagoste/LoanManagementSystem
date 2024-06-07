<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmLoanPayment
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.ckbReceipt = New System.Windows.Forms.CheckBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtDepBank = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cboPaymode = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtDocNo = New System.Windows.Forms.TextBox()
        Me.txtCustomerName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtCusCode = New System.Windows.Forms.TextBox()
        Me.txtLedgerNo = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.dtpDate = New System.Windows.Forms.DateTimePicker()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.txtLoanType = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtInterestRate = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtChargeCode = New System.Windows.Forms.TextBox()
        Me.dtgvDueDateList = New System.Windows.Forms.DataGridView()
        Me.DueDateLID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PaymentStatus = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.DueDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblLoanBalance = New System.Windows.Forms.Label()
        Me.lblOldPrincipal = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtMonthlyPrincipal = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtMonthlyInterest = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtPenaltyAmountPay = New System.Windows.Forms.TextBox()
        Me.txtMonthlyAmort = New System.Windows.Forms.TextBox()
        Me.rdbManual = New System.Windows.Forms.RadioButton()
        Me.rdbAuto = New System.Windows.Forms.RadioButton()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtPrincipalAmountPay = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtInterestAmountPay = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.lblTotalPayablePay = New System.Windows.Forms.Label()
        Me.txtProcessor = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txtRefund = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtCHKAmount = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtCHKNumber = New System.Windows.Forms.TextBox()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnPayNow = New System.Windows.Forms.Button()
        Me.btnCompute = New System.Windows.Forms.Button()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.lblDueDate = New System.Windows.Forms.Label()
        Me.lblSelectDate = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dtgvDueDateList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnSearch)
        Me.GroupBox1.Controls.Add(Me.ckbReceipt)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtDepBank)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.cboPaymode)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtDocNo)
        Me.GroupBox1.Controls.Add(Me.txtCustomerName)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtCusCode)
        Me.GroupBox1.Controls.Add(Me.txtLedgerNo)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(627, 179)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnSearch.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.ForeColor = System.Drawing.Color.White
        Me.btnSearch.Location = New System.Drawing.Point(273, 35)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(61, 35)
        Me.btnSearch.TabIndex = 34
        Me.btnSearch.Text = "SEARCH"
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'ckbReceipt
        '
        Me.ckbReceipt.AutoSize = True
        Me.ckbReceipt.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ckbReceipt.Location = New System.Drawing.Point(359, 42)
        Me.ckbReceipt.Name = "ckbReceipt"
        Me.ckbReceipt.Size = New System.Drawing.Size(66, 19)
        Me.ckbReceipt.TabIndex = 33
        Me.ckbReceipt.Text = "Manual"
        Me.ckbReceipt.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(309, 124)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(60, 15)
        Me.Label7.TabIndex = 31
        Me.Label7.Text = "Dep. Bank"
        '
        'txtDepBank
        '
        Me.txtDepBank.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDepBank.Location = New System.Drawing.Point(312, 141)
        Me.txtDepBank.Name = "txtDepBank"
        Me.txtDepBank.Size = New System.Drawing.Size(303, 25)
        Me.txtDepBank.TabIndex = 30
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(9, 123)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 15)
        Me.Label5.TabIndex = 27
        Me.Label5.Text = "Pay Mode"
        '
        'cboPaymode
        '
        Me.cboPaymode.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboPaymode.FormattingEnabled = True
        Me.cboPaymode.Items.AddRange(New Object() {"Cash ", "Check"})
        Me.cboPaymode.Location = New System.Drawing.Point(12, 141)
        Me.cboPaymode.Name = "cboPaymode"
        Me.cboPaymode.Size = New System.Drawing.Size(289, 25)
        Me.cboPaymode.TabIndex = 26
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(354, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(127, 15)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "Doc. No. /Receipt No."
        '
        'txtDocNo
        '
        Me.txtDocNo.BackColor = System.Drawing.Color.White
        Me.txtDocNo.Enabled = False
        Me.txtDocNo.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDocNo.Location = New System.Drawing.Point(425, 41)
        Me.txtDocNo.Name = "txtDocNo"
        Me.txtDocNo.Size = New System.Drawing.Size(191, 25)
        Me.txtDocNo.TabIndex = 20
        '
        'txtCustomerName
        '
        Me.txtCustomerName.BackColor = System.Drawing.Color.White
        Me.txtCustomerName.Enabled = False
        Me.txtCustomerName.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCustomerName.Location = New System.Drawing.Point(312, 93)
        Me.txtCustomerName.Name = "txtCustomerName"
        Me.txtCustomerName.Size = New System.Drawing.Size(303, 25)
        Me.txtCustomerName.TabIndex = 17
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(9, 74)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 15)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Customer Code"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(309, 75)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 15)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Customer Name"
        '
        'txtCusCode
        '
        Me.txtCusCode.BackColor = System.Drawing.Color.White
        Me.txtCusCode.Enabled = False
        Me.txtCusCode.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCusCode.Location = New System.Drawing.Point(13, 93)
        Me.txtCusCode.Name = "txtCusCode"
        Me.txtCusCode.Size = New System.Drawing.Size(288, 25)
        Me.txtCusCode.TabIndex = 15
        '
        'txtLedgerNo
        '
        Me.txtLedgerNo.BackColor = System.Drawing.Color.White
        Me.txtLedgerNo.Enabled = False
        Me.txtLedgerNo.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLedgerNo.Location = New System.Drawing.Point(13, 41)
        Me.txtLedgerNo.Name = "txtLedgerNo"
        Me.txtLedgerNo.Size = New System.Drawing.Size(255, 25)
        Me.txtLedgerNo.TabIndex = 19
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(10, 22)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(68, 15)
        Me.Label11.TabIndex = 18
        Me.Label11.Text = "Ledger No."
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(13, 41)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(31, 15)
        Me.Label13.TabIndex = 23
        Me.Label13.Text = "Date"
        '
        'dtpDate
        '
        Me.dtpDate.CalendarMonthBackground = System.Drawing.Color.White
        Me.dtpDate.Enabled = False
        Me.dtpDate.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDate.Location = New System.Drawing.Point(16, 61)
        Me.dtpDate.Name = "dtpDate"
        Me.dtpDate.Size = New System.Drawing.Size(121, 25)
        Me.dtpDate.TabIndex = 22
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(10, 145)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(60, 15)
        Me.Label22.TabIndex = 34
        Me.Label22.Text = "Loan Type"
        '
        'txtLoanType
        '
        Me.txtLoanType.BackColor = System.Drawing.Color.White
        Me.txtLoanType.Enabled = False
        Me.txtLoanType.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLoanType.Location = New System.Drawing.Point(12, 163)
        Me.txtLoanType.Name = "txtLoanType"
        Me.txtLoanType.Size = New System.Drawing.Size(183, 25)
        Me.txtLoanType.TabIndex = 35
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(9, 196)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(90, 15)
        Me.Label6.TabIndex = 28
        Me.Label6.Text = "Interest Rate(%)"
        '
        'txtInterestRate
        '
        Me.txtInterestRate.BackColor = System.Drawing.Color.White
        Me.txtInterestRate.Enabled = False
        Me.txtInterestRate.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInterestRate.Location = New System.Drawing.Point(12, 214)
        Me.txtInterestRate.Name = "txtInterestRate"
        Me.txtInterestRate.Size = New System.Drawing.Size(182, 25)
        Me.txtInterestRate.TabIndex = 29
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(10, 93)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 15)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "Chrg. Code"
        '
        'txtChargeCode
        '
        Me.txtChargeCode.BackColor = System.Drawing.Color.White
        Me.txtChargeCode.Enabled = False
        Me.txtChargeCode.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtChargeCode.Location = New System.Drawing.Point(13, 111)
        Me.txtChargeCode.Name = "txtChargeCode"
        Me.txtChargeCode.Size = New System.Drawing.Size(182, 25)
        Me.txtChargeCode.TabIndex = 25
        Me.txtChargeCode.Text = "L/R"
        '
        'dtgvDueDateList
        '
        Me.dtgvDueDateList.AllowUserToAddRows = False
        Me.dtgvDueDateList.AllowUserToDeleteRows = False
        Me.dtgvDueDateList.BackgroundColor = System.Drawing.Color.White
        Me.dtgvDueDateList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgvDueDateList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DueDateLID, Me.PaymentStatus, Me.DueDate})
        Me.dtgvDueDateList.Location = New System.Drawing.Point(658, 36)
        Me.dtgvDueDateList.Name = "dtgvDueDateList"
        Me.dtgvDueDateList.RowHeadersVisible = False
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtgvDueDateList.RowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dtgvDueDateList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtgvDueDateList.Size = New System.Drawing.Size(160, 558)
        Me.dtgvDueDateList.TabIndex = 16
        '
        'DueDateLID
        '
        Me.DueDateLID.DataPropertyName = "DueDateLID"
        Me.DueDateLID.HeaderText = "DueDateLID"
        Me.DueDateLID.Name = "DueDateLID"
        Me.DueDateLID.Visible = False
        '
        'PaymentStatus
        '
        Me.PaymentStatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.PaymentStatus.DataPropertyName = "PaymentStatus"
        Me.PaymentStatus.HeaderText = "Payment Status"
        Me.PaymentStatus.Items.AddRange(New Object() {"Partial", "Paid"})
        Me.PaymentStatus.Name = "PaymentStatus"
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
        Me.GroupBox2.Controls.Add(Me.lblLoanBalance)
        Me.GroupBox2.Controls.Add(Me.Label22)
        Me.GroupBox2.Controls.Add(Me.lblOldPrincipal)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.txtMonthlyPrincipal)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.Label23)
        Me.GroupBox2.Controls.Add(Me.dtpDate)
        Me.GroupBox2.Controls.Add(Me.txtLoanType)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.txtMonthlyInterest)
        Me.GroupBox2.Controls.Add(Me.txtChargeCode)
        Me.GroupBox2.Controls.Add(Me.Label19)
        Me.GroupBox2.Controls.Add(Me.Label21)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.txtPenaltyAmountPay)
        Me.GroupBox2.Controls.Add(Me.txtMonthlyAmort)
        Me.GroupBox2.Controls.Add(Me.txtInterestRate)
        Me.GroupBox2.Controls.Add(Me.rdbManual)
        Me.GroupBox2.Controls.Add(Me.rdbAuto)
        Me.GroupBox2.Controls.Add(Me.Label18)
        Me.GroupBox2.Controls.Add(Me.txtPrincipalAmountPay)
        Me.GroupBox2.Controls.Add(Me.Label17)
        Me.GroupBox2.Controls.Add(Me.txtInterestAmountPay)
        Me.GroupBox2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(12, 199)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(627, 253)
        Me.GroupBox2.TabIndex = 17
        Me.GroupBox2.TabStop = False
        '
        'lblLoanBalance
        '
        Me.lblLoanBalance.BackColor = System.Drawing.Color.LimeGreen
        Me.lblLoanBalance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLoanBalance.ForeColor = System.Drawing.Color.White
        Me.lblLoanBalance.Location = New System.Drawing.Point(414, 214)
        Me.lblLoanBalance.Name = "lblLoanBalance"
        Me.lblLoanBalance.Size = New System.Drawing.Size(201, 25)
        Me.lblLoanBalance.TabIndex = 71
        Me.lblLoanBalance.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblOldPrincipal
        '
        Me.lblOldPrincipal.BackColor = System.Drawing.Color.Brown
        Me.lblOldPrincipal.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOldPrincipal.ForeColor = System.Drawing.Color.White
        Me.lblOldPrincipal.Location = New System.Drawing.Point(214, 214)
        Me.lblOldPrincipal.Name = "lblOldPrincipal"
        Me.lblOldPrincipal.Size = New System.Drawing.Size(175, 25)
        Me.lblOldPrincipal.TabIndex = 69
        Me.lblOldPrincipal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(211, 94)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(101, 15)
        Me.Label10.TabIndex = 30
        Me.Label10.Text = "Monthly Principal"
        '
        'txtMonthlyPrincipal
        '
        Me.txtMonthlyPrincipal.BackColor = System.Drawing.Color.White
        Me.txtMonthlyPrincipal.Enabled = False
        Me.txtMonthlyPrincipal.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMonthlyPrincipal.Location = New System.Drawing.Point(214, 113)
        Me.txtMonthlyPrincipal.Name = "txtMonthlyPrincipal"
        Me.txtMonthlyPrincipal.Size = New System.Drawing.Size(175, 25)
        Me.txtMonthlyPrincipal.TabIndex = 31
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(211, 198)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(72, 15)
        Me.Label23.TabIndex = 38
        Me.Label23.Text = "Old Balance"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(211, 144)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(94, 15)
        Me.Label9.TabIndex = 28
        Me.Label9.Text = "Monthly Interest"
        '
        'txtMonthlyInterest
        '
        Me.txtMonthlyInterest.BackColor = System.Drawing.Color.White
        Me.txtMonthlyInterest.Enabled = False
        Me.txtMonthlyInterest.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMonthlyInterest.Location = New System.Drawing.Point(214, 163)
        Me.txtMonthlyInterest.Name = "txtMonthlyInterest"
        Me.txtMonthlyInterest.Size = New System.Drawing.Size(175, 25)
        Me.txtMonthlyInterest.TabIndex = 29
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(408, 143)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(96, 15)
        Me.Label19.TabIndex = 32
        Me.Label19.Text = "Penalty Amount"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(409, 196)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(79, 15)
        Me.Label21.TabIndex = 36
        Me.Label21.Text = "Loan Balance"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(211, 41)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(124, 15)
        Me.Label8.TabIndex = 26
        Me.Label8.Text = "Monthly Amortization"
        '
        'txtPenaltyAmountPay
        '
        Me.txtPenaltyAmountPay.BackColor = System.Drawing.Color.White
        Me.txtPenaltyAmountPay.Enabled = False
        Me.txtPenaltyAmountPay.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPenaltyAmountPay.Location = New System.Drawing.Point(411, 161)
        Me.txtPenaltyAmountPay.Name = "txtPenaltyAmountPay"
        Me.txtPenaltyAmountPay.Size = New System.Drawing.Size(204, 25)
        Me.txtPenaltyAmountPay.TabIndex = 33
        '
        'txtMonthlyAmort
        '
        Me.txtMonthlyAmort.BackColor = System.Drawing.Color.White
        Me.txtMonthlyAmort.Enabled = False
        Me.txtMonthlyAmort.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMonthlyAmort.Location = New System.Drawing.Point(214, 61)
        Me.txtMonthlyAmort.Name = "txtMonthlyAmort"
        Me.txtMonthlyAmort.Size = New System.Drawing.Size(175, 25)
        Me.txtMonthlyAmort.TabIndex = 27
        '
        'rdbManual
        '
        Me.rdbManual.AutoSize = True
        Me.rdbManual.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbManual.Location = New System.Drawing.Point(280, 15)
        Me.rdbManual.Name = "rdbManual"
        Me.rdbManual.Size = New System.Drawing.Size(65, 19)
        Me.rdbManual.TabIndex = 22
        Me.rdbManual.TabStop = True
        Me.rdbManual.Text = "Manual"
        Me.rdbManual.UseVisualStyleBackColor = True
        '
        'rdbAuto
        '
        Me.rdbAuto.AutoSize = True
        Me.rdbAuto.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbAuto.Location = New System.Drawing.Point(216, 15)
        Me.rdbAuto.Name = "rdbAuto"
        Me.rdbAuto.Size = New System.Drawing.Size(52, 19)
        Me.rdbAuto.TabIndex = 21
        Me.rdbAuto.TabStop = True
        Me.rdbAuto.Text = "Auto"
        Me.rdbAuto.UseVisualStyleBackColor = True
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(409, 93)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(102, 15)
        Me.Label18.TabIndex = 30
        Me.Label18.Text = "Principal Amount"
        '
        'txtPrincipalAmountPay
        '
        Me.txtPrincipalAmountPay.BackColor = System.Drawing.Color.White
        Me.txtPrincipalAmountPay.Enabled = False
        Me.txtPrincipalAmountPay.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrincipalAmountPay.Location = New System.Drawing.Point(412, 111)
        Me.txtPrincipalAmountPay.Name = "txtPrincipalAmountPay"
        Me.txtPrincipalAmountPay.Size = New System.Drawing.Size(204, 25)
        Me.txtPrincipalAmountPay.TabIndex = 31
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(408, 41)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(100, 15)
        Me.Label17.TabIndex = 28
        Me.Label17.Text = "Interest Amount"
        '
        'txtInterestAmountPay
        '
        Me.txtInterestAmountPay.BackColor = System.Drawing.Color.White
        Me.txtInterestAmountPay.Enabled = False
        Me.txtInterestAmountPay.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInterestAmountPay.Location = New System.Drawing.Point(411, 59)
        Me.txtInterestAmountPay.Name = "txtInterestAmountPay"
        Me.txtInterestAmountPay.Size = New System.Drawing.Size(204, 25)
        Me.txtInterestAmountPay.TabIndex = 29
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label16)
        Me.GroupBox3.Controls.Add(Me.lblTotalPayablePay)
        Me.GroupBox3.Controls.Add(Me.txtProcessor)
        Me.GroupBox3.Controls.Add(Me.Label15)
        Me.GroupBox3.Controls.Add(Me.Label20)
        Me.GroupBox3.Controls.Add(Me.txtRefund)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.txtCHKAmount)
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Controls.Add(Me.txtCHKNumber)
        Me.GroupBox3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(12, 456)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(627, 138)
        Me.GroupBox3.TabIndex = 18
        Me.GroupBox3.TabStop = False
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(211, 74)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(66, 17)
        Me.Label16.TabIndex = 32
        Me.Label16.Text = "Processor"
        '
        'lblTotalPayablePay
        '
        Me.lblTotalPayablePay.BackColor = System.Drawing.Color.Orange
        Me.lblTotalPayablePay.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalPayablePay.ForeColor = System.Drawing.Color.White
        Me.lblTotalPayablePay.Location = New System.Drawing.Point(412, 44)
        Me.lblTotalPayablePay.Name = "lblTotalPayablePay"
        Me.lblTotalPayablePay.Size = New System.Drawing.Size(203, 25)
        Me.lblTotalPayablePay.TabIndex = 70
        Me.lblTotalPayablePay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtProcessor
        '
        Me.txtProcessor.BackColor = System.Drawing.Color.White
        Me.txtProcessor.Enabled = False
        Me.txtProcessor.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProcessor.Location = New System.Drawing.Point(214, 95)
        Me.txtProcessor.Name = "txtProcessor"
        Me.txtProcessor.Size = New System.Drawing.Size(401, 25)
        Me.txtProcessor.TabIndex = 33
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(9, 77)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(45, 15)
        Me.Label15.TabIndex = 30
        Me.Label15.Text = "Refund"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(408, 26)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(79, 15)
        Me.Label20.TabIndex = 34
        Me.Label20.Text = "Total Payable"
        '
        'txtRefund
        '
        Me.txtRefund.BackColor = System.Drawing.Color.White
        Me.txtRefund.Enabled = False
        Me.txtRefund.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRefund.Location = New System.Drawing.Point(12, 95)
        Me.txtRefund.Name = "txtRefund"
        Me.txtRefund.Size = New System.Drawing.Size(182, 25)
        Me.txtRefund.TabIndex = 31
        Me.txtRefund.Text = "00.00"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(213, 26)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(78, 15)
        Me.Label12.TabIndex = 28
        Me.Label12.Text = "CHK Amount"
        '
        'txtCHKAmount
        '
        Me.txtCHKAmount.BackColor = System.Drawing.Color.White
        Me.txtCHKAmount.Enabled = False
        Me.txtCHKAmount.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCHKAmount.Location = New System.Drawing.Point(214, 44)
        Me.txtCHKAmount.Name = "txtCHKAmount"
        Me.txtCHKAmount.Size = New System.Drawing.Size(175, 25)
        Me.txtCHKAmount.TabIndex = 29
        Me.txtCHKAmount.Text = "00.00"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(9, 26)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(128, 15)
        Me.Label14.TabIndex = 26
        Me.Label14.Text = "CHK#/Others Payment"
        '
        'txtCHKNumber
        '
        Me.txtCHKNumber.BackColor = System.Drawing.Color.White
        Me.txtCHKNumber.Enabled = False
        Me.txtCHKNumber.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCHKNumber.Location = New System.Drawing.Point(12, 44)
        Me.txtCHKNumber.Name = "txtCHKNumber"
        Me.txtCHKNumber.Size = New System.Drawing.Size(182, 25)
        Me.txtCHKNumber.TabIndex = 27
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.Firebrick
        Me.btnClose.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.White
        Me.btnClose.Location = New System.Drawing.Point(391, 615)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(116, 45)
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
        Me.btnPayNow.Location = New System.Drawing.Point(256, 615)
        Me.btnPayNow.Name = "btnPayNow"
        Me.btnPayNow.Size = New System.Drawing.Size(116, 45)
        Me.btnPayNow.TabIndex = 64
        Me.btnPayNow.Text = "PAY NOW"
        Me.btnPayNow.UseVisualStyleBackColor = False
        '
        'btnCompute
        '
        Me.btnCompute.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnCompute.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCompute.ForeColor = System.Drawing.Color.White
        Me.btnCompute.Location = New System.Drawing.Point(121, 615)
        Me.btnCompute.Name = "btnCompute"
        Me.btnCompute.Size = New System.Drawing.Size(116, 45)
        Me.btnCompute.TabIndex = 63
        Me.btnCompute.Text = "COMPUTE"
        Me.btnCompute.UseVisualStyleBackColor = False
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.BackColor = System.Drawing.Color.Red
        Me.lblStatus.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.ForeColor = System.Drawing.Color.White
        Me.lblStatus.Location = New System.Drawing.Point(655, 602)
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
        Me.lblDueDate.Location = New System.Drawing.Point(655, 622)
        Me.lblDueDate.Name = "lblDueDate"
        Me.lblDueDate.Size = New System.Drawing.Size(66, 17)
        Me.lblDueDate.TabIndex = 68
        Me.lblDueDate.Text = "Due Date"
        '
        'lblSelectDate
        '
        Me.lblSelectDate.AutoSize = True
        Me.lblSelectDate.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSelectDate.ForeColor = System.Drawing.Color.Black
        Me.lblSelectDate.Location = New System.Drawing.Point(655, 19)
        Me.lblSelectDate.Name = "lblSelectDate"
        Me.lblSelectDate.Size = New System.Drawing.Size(148, 15)
        Me.lblSelectDate.TabIndex = 70
        Me.lblSelectDate.Text = "PLEASE SELECT DUE DATE"
        '
        'frmLoanPayment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(841, 687)
        Me.Controls.Add(Me.lblSelectDate)
        Me.Controls.Add(Me.lblDueDate)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnPayNow)
        Me.Controls.Add(Me.btnCompute)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.dtgvDueDateList)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmLoanPayment"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Loan Payment"
        Me.TopMost = True
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dtgvDueDateList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
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
    Friend WithEvents Label16 As Label
    Friend WithEvents txtProcessor As TextBox
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
    Friend WithEvents lblStatus As Label
    Friend WithEvents lblDueDate As Label
    Friend WithEvents ckbReceipt As CheckBox
    Friend WithEvents Label22 As Label
    Friend WithEvents txtLoanType As TextBox
    Friend WithEvents Label23 As Label
    Friend WithEvents lblOldPrincipal As Label
    Friend WithEvents lblTotalPayablePay As Label
    Friend WithEvents lblLoanBalance As Label
    Friend WithEvents lblSelectDate As Label
    Friend WithEvents btnSearch As Button
    Friend WithEvents DueDateLID As DataGridViewTextBoxColumn
    Friend WithEvents PaymentStatus As DataGridViewComboBoxColumn
    Friend WithEvents DueDate As DataGridViewTextBoxColumn
End Class
