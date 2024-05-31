<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCreateLoan
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
        Me.txtCusCode = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblID = New System.Windows.Forms.Label()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.txtCustomerName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtArea = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cboLoanType = New System.Windows.Forms.ComboBox()
        Me.txtComaker = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtCash = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtAccNo = New System.Windows.Forms.TextBox()
        Me.txtChecksNo = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cboChecks = New System.Windows.Forms.ComboBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.txtOldInterestAmount = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtOldBalanceAmout = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtPrevLDSNo = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.dtpMaturityDate = New System.Windows.Forms.DateTimePicker()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.dtpFirstDueDate = New System.Windows.Forms.DateTimePicker()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.dtpEffectiveDate = New System.Windows.Forms.DateTimePicker()
        Me.txtLDSNo = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtLedgerNo = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.lblTotalInterest = New System.Windows.Forms.Label()
        Me.txtInterest = New System.Windows.Forms.TextBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.txtPrincipal = New System.Windows.Forms.TextBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.txtTotalAmort = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txtInterestRate = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.txtLoanAmount = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.lblLoanTrans = New System.Windows.Forms.Label()
        Me.rbRenew = New System.Windows.Forms.RadioButton()
        Me.rbNew = New System.Windows.Forms.RadioButton()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.txtLoanTerm = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.txtNetProceeds = New System.Windows.Forms.TextBox()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.txtNewLoanBalance = New System.Windows.Forms.TextBox()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.txtLPPP = New System.Windows.Forms.TextBox()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.txtInspection = New System.Windows.Forms.TextBox()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.txtAccomodation = New System.Windows.Forms.TextBox()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.txtFinCharges = New System.Windows.Forms.TextBox()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.txtNotarialFee = New System.Windows.Forms.TextBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.dtgDueDateList = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnCompute = New System.Windows.Forms.Button()
        Me.btnCreateLoan = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.lblusername = New System.Windows.Forms.Label()
        Me.lblUserRole = New System.Windows.Forms.Label()
        Me.lbluserdate = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        CType(Me.dtgDueDateList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtCusCode
        '
        Me.txtCusCode.Enabled = False
        Me.txtCusCode.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCusCode.Location = New System.Drawing.Point(18, 45)
        Me.txtCusCode.Name = "txtCusCode"
        Me.txtCusCode.Size = New System.Drawing.Size(313, 27)
        Me.txtCusCode.TabIndex = 5
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
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnSearch.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.ForeColor = System.Drawing.Color.White
        Me.btnSearch.Location = New System.Drawing.Point(339, 42)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(64, 35)
        Me.btnSearch.TabIndex = 7
        Me.btnSearch.Text = "SEARCH"
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'txtCustomerName
        '
        Me.txtCustomerName.Enabled = False
        Me.txtCustomerName.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCustomerName.Location = New System.Drawing.Point(18, 98)
        Me.txtCustomerName.Name = "txtCustomerName"
        Me.txtCustomerName.Size = New System.Drawing.Size(385, 27)
        Me.txtCustomerName.TabIndex = 9
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(15, 78)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(103, 17)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Customer Name"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox5)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtArea)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.cboLoanType)
        Me.GroupBox1.Controls.Add(Me.txtComaker)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtCustomerName)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtCusCode)
        Me.GroupBox1.Controls.Add(Me.btnSearch)
        Me.GroupBox1.Controls.Add(Me.lblID)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(418, 252)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
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
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(217, 185)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(36, 17)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Area"
        '
        'txtArea
        '
        Me.txtArea.Enabled = False
        Me.txtArea.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtArea.Location = New System.Drawing.Point(213, 207)
        Me.txtArea.Name = "txtArea"
        Me.txtArea.Size = New System.Drawing.Size(190, 27)
        Me.txtArea.TabIndex = 14
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(16, 185)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 17)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Loan Type"
        '
        'cboLoanType
        '
        Me.cboLoanType.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboLoanType.FormattingEnabled = True
        Me.cboLoanType.Items.AddRange(New Object() {"STRAIGHT", "DIMINISHING"})
        Me.cboLoanType.Location = New System.Drawing.Point(18, 206)
        Me.cboLoanType.Name = "cboLoanType"
        Me.cboLoanType.Size = New System.Drawing.Size(184, 28)
        Me.cboLoanType.TabIndex = 12
        '
        'txtComaker
        '
        Me.txtComaker.Enabled = False
        Me.txtComaker.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtComaker.Location = New System.Drawing.Point(18, 151)
        Me.txtComaker.Name = "txtComaker"
        Me.txtComaker.Size = New System.Drawing.Size(385, 27)
        Me.txtComaker.TabIndex = 11
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(15, 131)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 17)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Co-maker"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.txtCash)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.txtAccNo)
        Me.GroupBox2.Controls.Add(Me.txtChecksNo)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.cboChecks)
        Me.GroupBox2.Location = New System.Drawing.Point(443, 4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(192, 252)
        Me.GroupBox2.TabIndex = 11
        Me.GroupBox2.TabStop = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(13, 78)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(68, 17)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Check No."
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(12, 185)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(36, 17)
        Me.Label10.TabIndex = 19
        Me.Label10.Text = "Cash"
        '
        'txtCash
        '
        Me.txtCash.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCash.Location = New System.Drawing.Point(15, 207)
        Me.txtCash.Name = "txtCash"
        Me.txtCash.Size = New System.Drawing.Size(159, 27)
        Me.txtCash.TabIndex = 20
        Me.txtCash.Text = "00.00"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(13, 131)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(58, 17)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "Acct No."
        '
        'txtAccNo
        '
        Me.txtAccNo.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAccNo.Location = New System.Drawing.Point(15, 151)
        Me.txtAccNo.Name = "txtAccNo"
        Me.txtAccNo.Size = New System.Drawing.Size(159, 27)
        Me.txtAccNo.TabIndex = 18
        '
        'txtChecksNo
        '
        Me.txtChecksNo.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtChecksNo.Location = New System.Drawing.Point(15, 98)
        Me.txtChecksNo.Name = "txtChecksNo"
        Me.txtChecksNo.Size = New System.Drawing.Size(159, 27)
        Me.txtChecksNo.TabIndex = 17
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(13, 24)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(54, 17)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Check ?"
        '
        'cboChecks
        '
        Me.cboChecks.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboChecks.FormattingEnabled = True
        Me.cboChecks.Items.AddRange(New Object() {"RF", "NO", "YES", "BOTH", "OTHERS"})
        Me.cboChecks.Location = New System.Drawing.Point(15, 45)
        Me.cboChecks.Name = "cboChecks"
        Me.cboChecks.Size = New System.Drawing.Size(159, 28)
        Me.cboChecks.TabIndex = 14
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.txtOldInterestAmount)
        Me.GroupBox4.Controls.Add(Me.Label18)
        Me.GroupBox4.Controls.Add(Me.txtOldBalanceAmout)
        Me.GroupBox4.Controls.Add(Me.Label17)
        Me.GroupBox4.Controls.Add(Me.txtPrevLDSNo)
        Me.GroupBox4.Controls.Add(Me.Label16)
        Me.GroupBox4.Controls.Add(Me.Label15)
        Me.GroupBox4.Controls.Add(Me.dtpMaturityDate)
        Me.GroupBox4.Controls.Add(Me.Label14)
        Me.GroupBox4.Controls.Add(Me.dtpFirstDueDate)
        Me.GroupBox4.Controls.Add(Me.Label13)
        Me.GroupBox4.Controls.Add(Me.dtpEffectiveDate)
        Me.GroupBox4.Controls.Add(Me.txtLDSNo)
        Me.GroupBox4.Controls.Add(Me.Label12)
        Me.GroupBox4.Controls.Add(Me.txtLedgerNo)
        Me.GroupBox4.Controls.Add(Me.Label11)
        Me.GroupBox4.Location = New System.Drawing.Point(16, 255)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(227, 466)
        Me.GroupBox4.TabIndex = 12
        Me.GroupBox4.TabStop = False
        '
        'txtOldInterestAmount
        '
        Me.txtOldInterestAmount.Enabled = False
        Me.txtOldInterestAmount.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOldInterestAmount.Location = New System.Drawing.Point(12, 421)
        Me.txtOldInterestAmount.Name = "txtOldInterestAmount"
        Me.txtOldInterestAmount.Size = New System.Drawing.Size(204, 27)
        Me.txtOldInterestAmount.TabIndex = 27
        Me.txtOldInterestAmount.Text = "00.00"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(9, 401)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(131, 17)
        Me.Label18.TabIndex = 26
        Me.Label18.Text = "Old Interest Amount"
        '
        'txtOldBalanceAmout
        '
        Me.txtOldBalanceAmout.Enabled = False
        Me.txtOldBalanceAmout.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOldBalanceAmout.Location = New System.Drawing.Point(12, 366)
        Me.txtOldBalanceAmout.Name = "txtOldBalanceAmout"
        Me.txtOldBalanceAmout.Size = New System.Drawing.Size(204, 27)
        Me.txtOldBalanceAmout.TabIndex = 25
        Me.txtOldBalanceAmout.Text = "00.00"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(9, 346)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(132, 17)
        Me.Label17.TabIndex = 24
        Me.Label17.Text = "Old Balance Amount"
        '
        'txtPrevLDSNo
        '
        Me.txtPrevLDSNo.Enabled = False
        Me.txtPrevLDSNo.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrevLDSNo.Location = New System.Drawing.Point(12, 311)
        Me.txtPrevLDSNo.Name = "txtPrevLDSNo"
        Me.txtPrevLDSNo.Size = New System.Drawing.Size(204, 27)
        Me.txtPrevLDSNo.TabIndex = 23
        Me.txtPrevLDSNo.Text = "00.00"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(9, 291)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(89, 17)
        Me.Label16.TabIndex = 22
        Me.Label16.Text = "Prev. LDS No."
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(9, 237)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(93, 17)
        Me.Label15.TabIndex = 21
        Me.Label15.Text = "Maturity Date"
        '
        'dtpMaturityDate
        '
        Me.dtpMaturityDate.Enabled = False
        Me.dtpMaturityDate.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpMaturityDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpMaturityDate.Location = New System.Drawing.Point(12, 257)
        Me.dtpMaturityDate.Name = "dtpMaturityDate"
        Me.dtpMaturityDate.Size = New System.Drawing.Size(204, 27)
        Me.dtpMaturityDate.TabIndex = 20
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(9, 183)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(96, 17)
        Me.Label14.TabIndex = 19
        Me.Label14.Text = "First Due Date"
        '
        'dtpFirstDueDate
        '
        Me.dtpFirstDueDate.Enabled = False
        Me.dtpFirstDueDate.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFirstDueDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFirstDueDate.Location = New System.Drawing.Point(12, 203)
        Me.dtpFirstDueDate.Name = "dtpFirstDueDate"
        Me.dtpFirstDueDate.Size = New System.Drawing.Size(204, 27)
        Me.dtpFirstDueDate.TabIndex = 18
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(9, 129)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(92, 17)
        Me.Label13.TabIndex = 17
        Me.Label13.Text = "Effective Date"
        '
        'dtpEffectiveDate
        '
        Me.dtpEffectiveDate.Enabled = False
        Me.dtpEffectiveDate.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpEffectiveDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpEffectiveDate.Location = New System.Drawing.Point(12, 149)
        Me.dtpEffectiveDate.Name = "dtpEffectiveDate"
        Me.dtpEffectiveDate.Size = New System.Drawing.Size(204, 27)
        Me.dtpEffectiveDate.TabIndex = 16
        '
        'txtLDSNo
        '
        Me.txtLDSNo.Enabled = False
        Me.txtLDSNo.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLDSNo.Location = New System.Drawing.Point(12, 95)
        Me.txtLDSNo.Name = "txtLDSNo"
        Me.txtLDSNo.Size = New System.Drawing.Size(204, 27)
        Me.txtLDSNo.TabIndex = 15
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(9, 75)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(90, 17)
        Me.Label12.TabIndex = 14
        Me.Label12.Text = "Doc. /LDS No."
        '
        'txtLedgerNo
        '
        Me.txtLedgerNo.Enabled = False
        Me.txtLedgerNo.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLedgerNo.Location = New System.Drawing.Point(12, 41)
        Me.txtLedgerNo.Name = "txtLedgerNo"
        Me.txtLedgerNo.Size = New System.Drawing.Size(204, 27)
        Me.txtLedgerNo.TabIndex = 13
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(9, 21)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(71, 17)
        Me.Label11.TabIndex = 12
        Me.Label11.Text = "Ledger No."
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.lblTotalInterest)
        Me.GroupBox6.Controls.Add(Me.txtInterest)
        Me.GroupBox6.Controls.Add(Me.Label27)
        Me.GroupBox6.Controls.Add(Me.txtPrincipal)
        Me.GroupBox6.Controls.Add(Me.Label26)
        Me.GroupBox6.Controls.Add(Me.Label25)
        Me.GroupBox6.Controls.Add(Me.txtTotalAmort)
        Me.GroupBox6.Controls.Add(Me.Label19)
        Me.GroupBox6.Controls.Add(Me.txtInterestRate)
        Me.GroupBox6.Controls.Add(Me.Label24)
        Me.GroupBox6.Controls.Add(Me.txtLoanAmount)
        Me.GroupBox6.Controls.Add(Me.Label23)
        Me.GroupBox6.Controls.Add(Me.lblLoanTrans)
        Me.GroupBox6.Controls.Add(Me.rbRenew)
        Me.GroupBox6.Controls.Add(Me.rbNew)
        Me.GroupBox6.Controls.Add(Me.Label21)
        Me.GroupBox6.Controls.Add(Me.txtLoanTerm)
        Me.GroupBox6.Controls.Add(Me.Label20)
        Me.GroupBox6.Location = New System.Drawing.Point(250, 255)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(185, 466)
        Me.GroupBox6.TabIndex = 13
        Me.GroupBox6.TabStop = False
        '
        'lblTotalInterest
        '
        Me.lblTotalInterest.AutoSize = True
        Me.lblTotalInterest.BackColor = System.Drawing.Color.Red
        Me.lblTotalInterest.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalInterest.ForeColor = System.Drawing.Color.White
        Me.lblTotalInterest.Location = New System.Drawing.Point(71, 346)
        Me.lblTotalInterest.Name = "lblTotalInterest"
        Me.lblTotalInterest.Size = New System.Drawing.Size(83, 17)
        Me.lblTotalInterest.TabIndex = 33
        Me.lblTotalInterest.Text = "Total Interest"
        '
        'txtInterest
        '
        Me.txtInterest.Enabled = False
        Me.txtInterest.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInterest.Location = New System.Drawing.Point(13, 366)
        Me.txtInterest.Name = "txtInterest"
        Me.txtInterest.Size = New System.Drawing.Size(162, 27)
        Me.txtInterest.TabIndex = 32
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(10, 346)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(54, 17)
        Me.Label27.TabIndex = 31
        Me.Label27.Text = "Interest"
        '
        'txtPrincipal
        '
        Me.txtPrincipal.Enabled = False
        Me.txtPrincipal.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrincipal.Location = New System.Drawing.Point(13, 311)
        Me.txtPrincipal.Name = "txtPrincipal"
        Me.txtPrincipal.Size = New System.Drawing.Size(162, 27)
        Me.txtPrincipal.TabIndex = 30
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(10, 291)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(61, 17)
        Me.Label26.TabIndex = 29
        Me.Label26.Text = "Principal"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(9, 257)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(165, 20)
        Me.Label25.TabIndex = 28
        Me.Label25.Text = "Monthly Amortization"
        '
        'txtTotalAmort
        '
        Me.txtTotalAmort.Enabled = False
        Me.txtTotalAmort.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalAmort.Location = New System.Drawing.Point(13, 421)
        Me.txtTotalAmort.Name = "txtTotalAmort"
        Me.txtTotalAmort.Size = New System.Drawing.Size(162, 27)
        Me.txtTotalAmort.TabIndex = 27
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(10, 400)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(165, 20)
        Me.Label19.TabIndex = 26
        Me.Label19.Text = "Total  Monthly Amort."
        '
        'txtInterestRate
        '
        Me.txtInterestRate.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInterestRate.Location = New System.Drawing.Point(13, 205)
        Me.txtInterestRate.Name = "txtInterestRate"
        Me.txtInterestRate.Size = New System.Drawing.Size(162, 27)
        Me.txtInterestRate.TabIndex = 25
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(10, 185)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(108, 17)
        Me.Label24.TabIndex = 24
        Me.Label24.Text = "Interest Rate (%)"
        '
        'txtLoanAmount
        '
        Me.txtLoanAmount.Enabled = False
        Me.txtLoanAmount.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLoanAmount.Location = New System.Drawing.Point(13, 151)
        Me.txtLoanAmount.Name = "txtLoanAmount"
        Me.txtLoanAmount.Size = New System.Drawing.Size(162, 27)
        Me.txtLoanAmount.TabIndex = 23
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(10, 131)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(88, 17)
        Me.Label23.TabIndex = 22
        Me.Label23.Text = "Loan Amount"
        '
        'lblLoanTrans
        '
        Me.lblLoanTrans.AutoSize = True
        Me.lblLoanTrans.BackColor = System.Drawing.Color.Red
        Me.lblLoanTrans.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLoanTrans.ForeColor = System.Drawing.Color.White
        Me.lblLoanTrans.Location = New System.Drawing.Point(92, 21)
        Me.lblLoanTrans.Name = "lblLoanTrans"
        Me.lblLoanTrans.Size = New System.Drawing.Size(71, 17)
        Me.lblLoanTrans.TabIndex = 21
        Me.lblLoanTrans.Text = "Loan Trans"
        '
        'rbRenew
        '
        Me.rbRenew.AutoSize = True
        Me.rbRenew.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbRenew.Location = New System.Drawing.Point(71, 44)
        Me.rbRenew.Name = "rbRenew"
        Me.rbRenew.Size = New System.Drawing.Size(64, 21)
        Me.rbRenew.TabIndex = 20
        Me.rbRenew.TabStop = True
        Me.rbRenew.Text = "Renew"
        Me.rbRenew.UseVisualStyleBackColor = True
        '
        'rbNew
        '
        Me.rbNew.AutoSize = True
        Me.rbNew.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbNew.Location = New System.Drawing.Point(13, 44)
        Me.rbNew.Name = "rbNew"
        Me.rbNew.Size = New System.Drawing.Size(52, 21)
        Me.rbNew.TabIndex = 19
        Me.rbNew.TabStop = True
        Me.rbNew.Text = "New"
        Me.rbNew.UseVisualStyleBackColor = True
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(10, 21)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(75, 17)
        Me.Label21.TabIndex = 18
        Me.Label21.Text = "Loan Trans."
        '
        'txtLoanTerm
        '
        Me.txtLoanTerm.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLoanTerm.Location = New System.Drawing.Point(13, 95)
        Me.txtLoanTerm.Name = "txtLoanTerm"
        Me.txtLoanTerm.Size = New System.Drawing.Size(162, 27)
        Me.txtLoanTerm.TabIndex = 17
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(10, 75)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(129, 17)
        Me.Label20.TabIndex = 16
        Me.Label20.Text = "Loan Term (Month's)"
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.txtNetProceeds)
        Me.GroupBox7.Controls.Add(Me.Label34)
        Me.GroupBox7.Controls.Add(Me.txtNewLoanBalance)
        Me.GroupBox7.Controls.Add(Me.Label33)
        Me.GroupBox7.Controls.Add(Me.txtLPPP)
        Me.GroupBox7.Controls.Add(Me.Label32)
        Me.GroupBox7.Controls.Add(Me.txtInspection)
        Me.GroupBox7.Controls.Add(Me.Label31)
        Me.GroupBox7.Controls.Add(Me.txtAccomodation)
        Me.GroupBox7.Controls.Add(Me.Label30)
        Me.GroupBox7.Controls.Add(Me.txtFinCharges)
        Me.GroupBox7.Controls.Add(Me.Label29)
        Me.GroupBox7.Controls.Add(Me.txtNotarialFee)
        Me.GroupBox7.Controls.Add(Me.Label28)
        Me.GroupBox7.Location = New System.Drawing.Point(443, 255)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(192, 466)
        Me.GroupBox7.TabIndex = 14
        Me.GroupBox7.TabStop = False
        '
        'txtNetProceeds
        '
        Me.txtNetProceeds.BackColor = System.Drawing.Color.LimeGreen
        Me.txtNetProceeds.Enabled = False
        Me.txtNetProceeds.Font = New System.Drawing.Font("Segoe UI", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNetProceeds.Location = New System.Drawing.Point(12, 418)
        Me.txtNetProceeds.Name = "txtNetProceeds"
        Me.txtNetProceeds.Size = New System.Drawing.Size(171, 30)
        Me.txtNetProceeds.TabIndex = 31
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.Location = New System.Drawing.Point(8, 396)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(102, 20)
        Me.Label34.TabIndex = 30
        Me.Label34.Text = "Net Proceeds"
        '
        'txtNewLoanBalance
        '
        Me.txtNewLoanBalance.Enabled = False
        Me.txtNewLoanBalance.Font = New System.Drawing.Font("Segoe UI", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNewLoanBalance.Location = New System.Drawing.Point(12, 363)
        Me.txtNewLoanBalance.Name = "txtNewLoanBalance"
        Me.txtNewLoanBalance.Size = New System.Drawing.Size(171, 30)
        Me.txtNewLoanBalance.TabIndex = 29
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.Location = New System.Drawing.Point(8, 340)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(137, 20)
        Me.Label33.TabIndex = 28
        Me.Label33.Text = "New Loan Balance"
        '
        'txtLPPP
        '
        Me.txtLPPP.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLPPP.Location = New System.Drawing.Point(12, 257)
        Me.txtLPPP.Name = "txtLPPP"
        Me.txtLPPP.Size = New System.Drawing.Size(171, 27)
        Me.txtLPPP.TabIndex = 27
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.Location = New System.Drawing.Point(9, 237)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(62, 17)
        Me.Label32.TabIndex = 26
        Me.Label32.Text = "L. P. P. P."
        '
        'txtInspection
        '
        Me.txtInspection.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInspection.Location = New System.Drawing.Point(12, 203)
        Me.txtInspection.Name = "txtInspection"
        Me.txtInspection.Size = New System.Drawing.Size(171, 27)
        Me.txtInspection.TabIndex = 25
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.Location = New System.Drawing.Point(9, 183)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(69, 17)
        Me.Label31.TabIndex = 24
        Me.Label31.Text = "Inspection"
        '
        'txtAccomodation
        '
        Me.txtAccomodation.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAccomodation.Location = New System.Drawing.Point(12, 151)
        Me.txtAccomodation.Name = "txtAccomodation"
        Me.txtAccomodation.Size = New System.Drawing.Size(171, 27)
        Me.txtAccomodation.TabIndex = 23
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.Location = New System.Drawing.Point(9, 131)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(92, 17)
        Me.Label30.TabIndex = 22
        Me.Label30.Text = "Accomodation"
        '
        'txtFinCharges
        '
        Me.txtFinCharges.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFinCharges.Location = New System.Drawing.Point(12, 95)
        Me.txtFinCharges.Name = "txtFinCharges"
        Me.txtFinCharges.Size = New System.Drawing.Size(171, 27)
        Me.txtFinCharges.TabIndex = 21
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.Location = New System.Drawing.Point(9, 75)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(81, 17)
        Me.Label29.TabIndex = 20
        Me.Label29.Text = "Fin. Charges"
        '
        'txtNotarialFee
        '
        Me.txtNotarialFee.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNotarialFee.Location = New System.Drawing.Point(12, 41)
        Me.txtNotarialFee.Name = "txtNotarialFee"
        Me.txtNotarialFee.Size = New System.Drawing.Size(171, 27)
        Me.txtNotarialFee.TabIndex = 19
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.Location = New System.Drawing.Point(9, 21)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(82, 17)
        Me.Label28.TabIndex = 18
        Me.Label28.Text = "Notarial Fee"
        '
        'dtgDueDateList
        '
        Me.dtgDueDateList.AllowUserToAddRows = False
        Me.dtgDueDateList.BackgroundColor = System.Drawing.Color.White
        Me.dtgDueDateList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgDueDateList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4})
        Me.dtgDueDateList.Location = New System.Drawing.Point(642, 13)
        Me.dtgDueDateList.Name = "dtgDueDateList"
        Me.dtgDueDateList.RowHeadersVisible = False
        Me.dtgDueDateList.Size = New System.Drawing.Size(130, 708)
        Me.dtgDueDateList.TabIndex = 15
        '
        'Column1
        '
        Me.Column1.HeaderText = "CustCode"
        Me.Column1.Name = "Column1"
        Me.Column1.Visible = False
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
        'Column4
        '
        Me.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column4.HeaderText = "Due Dates"
        Me.Column4.Name = "Column4"
        '
        'btnCompute
        '
        Me.btnCompute.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnCompute.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCompute.ForeColor = System.Drawing.Color.White
        Me.btnCompute.Location = New System.Drawing.Point(91, 740)
        Me.btnCompute.Name = "btnCompute"
        Me.btnCompute.Size = New System.Drawing.Size(141, 45)
        Me.btnCompute.TabIndex = 59
        Me.btnCompute.Text = "COMPUTE"
        Me.btnCompute.UseVisualStyleBackColor = False
        '
        'btnCreateLoan
        '
        Me.btnCreateLoan.BackColor = System.Drawing.Color.Green
        Me.btnCreateLoan.Enabled = False
        Me.btnCreateLoan.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCreateLoan.ForeColor = System.Drawing.Color.White
        Me.btnCreateLoan.Location = New System.Drawing.Point(244, 740)
        Me.btnCreateLoan.Name = "btnCreateLoan"
        Me.btnCreateLoan.Size = New System.Drawing.Size(141, 45)
        Me.btnCreateLoan.TabIndex = 60
        Me.btnCreateLoan.Text = "CREATE LOAN"
        Me.btnCreateLoan.UseVisualStyleBackColor = False
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.Firebrick
        Me.btnClose.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.White
        Me.btnClose.Location = New System.Drawing.Point(397, 740)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(141, 45)
        Me.btnClose.TabIndex = 62
        Me.btnClose.Text = "CLOSE"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'lblusername
        '
        Me.lblusername.AutoSize = True
        Me.lblusername.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblusername.Location = New System.Drawing.Point(569, 736)
        Me.lblusername.Name = "lblusername"
        Me.lblusername.Size = New System.Drawing.Size(72, 15)
        Me.lblusername.TabIndex = 63
        Me.lblusername.Text = "lblusername"
        '
        'lblUserRole
        '
        Me.lblUserRole.AutoSize = True
        Me.lblUserRole.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUserRole.Location = New System.Drawing.Point(569, 756)
        Me.lblUserRole.Name = "lblUserRole"
        Me.lblUserRole.Size = New System.Drawing.Size(66, 15)
        Me.lblUserRole.TabIndex = 64
        Me.lblUserRole.Text = "lblUserRole"
        '
        'lbluserdate
        '
        Me.lbluserdate.AutoSize = True
        Me.lbluserdate.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbluserdate.Location = New System.Drawing.Point(569, 776)
        Me.lbluserdate.Name = "lbluserdate"
        Me.lbluserdate.Size = New System.Drawing.Size(65, 15)
        Me.lbluserdate.TabIndex = 65
        Me.lbluserdate.Text = "lbluserdate"
        '
        'frmCreateLoan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(783, 808)
        Me.Controls.Add(Me.lbluserdate)
        Me.Controls.Add(Me.lblUserRole)
        Me.Controls.Add(Me.lblusername)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnCreateLoan)
        Me.Controls.Add(Me.btnCompute)
        Me.Controls.Add(Me.dtgDueDateList)
        Me.Controls.Add(Me.GroupBox7)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frmCreateLoan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Create Loan"
        Me.TopMost = True
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        CType(Me.dtgDueDateList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtCusCode As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblID As Label
    Friend WithEvents btnSearch As Button
    Friend WithEvents txtCustomerName As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtComaker As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtArea As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents cboLoanType As ComboBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label7 As Label
    Friend WithEvents cboChecks As ComboBox
    Friend WithEvents txtChecksNo As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txtAccNo As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtCash As TextBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents txtLedgerNo As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txtLDSNo As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents dtpEffectiveDate As DateTimePicker
    Friend WithEvents Label14 As Label
    Friend WithEvents dtpFirstDueDate As DateTimePicker
    Friend WithEvents Label15 As Label
    Friend WithEvents dtpMaturityDate As DateTimePicker
    Friend WithEvents txtPrevLDSNo As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents txtOldInterestAmount As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents txtOldBalanceAmout As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents GroupBox7 As GroupBox
    Friend WithEvents txtLoanTerm As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents rbRenew As RadioButton
    Friend WithEvents rbNew As RadioButton
    Friend WithEvents lblLoanTrans As Label
    Friend WithEvents txtInterestRate As TextBox
    Friend WithEvents Label24 As Label
    Friend WithEvents txtLoanAmount As TextBox
    Friend WithEvents Label23 As Label
    Friend WithEvents txtTotalAmort As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents txtInterest As TextBox
    Friend WithEvents Label27 As Label
    Friend WithEvents txtPrincipal As TextBox
    Friend WithEvents Label26 As Label
    Friend WithEvents txtNotarialFee As TextBox
    Friend WithEvents Label28 As Label
    Friend WithEvents txtLPPP As TextBox
    Friend WithEvents Label32 As Label
    Friend WithEvents txtInspection As TextBox
    Friend WithEvents Label31 As Label
    Friend WithEvents txtAccomodation As TextBox
    Friend WithEvents Label30 As Label
    Friend WithEvents txtFinCharges As TextBox
    Friend WithEvents Label29 As Label
    Friend WithEvents txtNewLoanBalance As TextBox
    Friend WithEvents Label33 As Label
    Friend WithEvents txtNetProceeds As TextBox
    Friend WithEvents Label34 As Label
    Friend WithEvents lblTotalInterest As Label
    Friend WithEvents dtgDueDateList As DataGridView
    Friend WithEvents btnCompute As Button
    Friend WithEvents btnCreateLoan As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents lblusername As Label
    Friend WithEvents lblUserRole As Label
    Friend WithEvents lbluserdate As Label
End Class
