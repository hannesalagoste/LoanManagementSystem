<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCreateUpdateClient
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
        Me.lblID = New System.Windows.Forms.Label()
        Me.lblClientCode = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtFirstname = New System.Windows.Forms.TextBox()
        Me.txtLastname = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtMiddlename = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cboGender = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dtpBOD = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtAge = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cboCivilstatus = New System.Windows.Forms.ComboBox()
        Me.txtSpouse = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cboArea = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cboDescription = New System.Windows.Forms.ComboBox()
        Me.txtOccupation = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtHomeaddress = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtEmailadd = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtMobilenumber = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtZipcode = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtValidIDNumber = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtTinIDNo = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtOfficeaddress = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.cboValidIDType = New System.Windows.Forms.ComboBox()
        Me.cboATMType = New System.Windows.Forms.ComboBox()
        Me.txtATMNumber = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.txtBankAccountNumber = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.cboBankAccountType = New System.Windows.Forms.ComboBox()
        Me.txtComakerOccupation = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.txtComakerAddress = New System.Windows.Forms.TextBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.txtComakerPhoneNumber = New System.Windows.Forms.TextBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.txtComakerFullname = New System.Windows.Forms.TextBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.btnCreate = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnUploadPicture = New System.Windows.Forms.Button()
        Me.picClientProfile = New System.Windows.Forms.PictureBox()
        CType(Me.picClientProfile, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.BackColor = System.Drawing.Color.Red
        Me.lblID.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblID.Location = New System.Drawing.Point(17, 9)
        Me.lblID.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(21, 17)
        Me.lblID.TabIndex = 0
        Me.lblID.Text = "ID"
        '
        'lblClientCode
        '
        Me.lblClientCode.AutoSize = True
        Me.lblClientCode.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClientCode.Location = New System.Drawing.Point(16, 36)
        Me.lblClientCode.Name = "lblClientCode"
        Me.lblClientCode.Size = New System.Drawing.Size(77, 17)
        Me.lblClientCode.TabIndex = 1
        Me.lblClientCode.Text = "Client Code"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(15, 66)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "First Name"
        '
        'txtFirstname
        '
        Me.txtFirstname.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFirstname.Location = New System.Drawing.Point(19, 86)
        Me.txtFirstname.Name = "txtFirstname"
        Me.txtFirstname.Size = New System.Drawing.Size(233, 27)
        Me.txtFirstname.TabIndex = 3
        '
        'txtLastname
        '
        Me.txtLastname.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLastname.Location = New System.Drawing.Point(269, 86)
        Me.txtLastname.Name = "txtLastname"
        Me.txtLastname.Size = New System.Drawing.Size(233, 27)
        Me.txtLastname.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(267, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 17)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Last Name"
        '
        'txtMiddlename
        '
        Me.txtMiddlename.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMiddlename.Location = New System.Drawing.Point(520, 86)
        Me.txtMiddlename.Name = "txtMiddlename"
        Me.txtMiddlename.Size = New System.Drawing.Size(233, 27)
        Me.txtMiddlename.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(518, 66)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(89, 17)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Middle Name"
        '
        'cboGender
        '
        Me.cboGender.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboGender.FormattingEnabled = True
        Me.cboGender.Items.AddRange(New Object() {"Male", "Female"})
        Me.cboGender.Location = New System.Drawing.Point(18, 155)
        Me.cboGender.Name = "cboGender"
        Me.cboGender.Size = New System.Drawing.Size(108, 28)
        Me.cboGender.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(16, 135)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 17)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Gender"
        '
        'dtpBOD
        '
        Me.dtpBOD.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpBOD.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpBOD.Location = New System.Drawing.Point(136, 155)
        Me.dtpBOD.Name = "dtpBOD"
        Me.dtpBOD.Size = New System.Drawing.Size(115, 27)
        Me.dtpBOD.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(133, 135)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(69, 17)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Birth Date"
        '
        'txtAge
        '
        Me.txtAge.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAge.Location = New System.Drawing.Point(267, 155)
        Me.txtAge.Name = "txtAge"
        Me.txtAge.Size = New System.Drawing.Size(70, 27)
        Me.txtAge.TabIndex = 13
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(265, 135)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(32, 17)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Age"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(350, 134)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(74, 17)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Civil Status"
        '
        'cboCivilstatus
        '
        Me.cboCivilstatus.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCivilstatus.FormattingEnabled = True
        Me.cboCivilstatus.Items.AddRange(New Object() {"Single", "Married", "Widowed", "Legally Separated"})
        Me.cboCivilstatus.Location = New System.Drawing.Point(352, 154)
        Me.cboCivilstatus.Name = "cboCivilstatus"
        Me.cboCivilstatus.Size = New System.Drawing.Size(148, 28)
        Me.cboCivilstatus.TabIndex = 14
        '
        'txtSpouse
        '
        Me.txtSpouse.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSpouse.Location = New System.Drawing.Point(520, 154)
        Me.txtSpouse.Name = "txtSpouse"
        Me.txtSpouse.Size = New System.Drawing.Size(233, 27)
        Me.txtSpouse.TabIndex = 17
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(517, 134)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(52, 17)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Spouse"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(17, 196)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(36, 17)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "Area"
        '
        'cboArea
        '
        Me.cboArea.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboArea.FormattingEnabled = True
        Me.cboArea.Location = New System.Drawing.Point(19, 216)
        Me.cboArea.Name = "cboArea"
        Me.cboArea.Size = New System.Drawing.Size(233, 28)
        Me.cboArea.TabIndex = 18
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(265, 196)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(76, 17)
        Me.Label10.TabIndex = 21
        Me.Label10.Text = "Description"
        '
        'cboDescription
        '
        Me.cboDescription.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboDescription.FormattingEnabled = True
        Me.cboDescription.Items.AddRange(New Object() {"Customer", "Employee", "Supplier", "Others"})
        Me.cboDescription.Location = New System.Drawing.Point(267, 216)
        Me.cboDescription.Name = "cboDescription"
        Me.cboDescription.Size = New System.Drawing.Size(233, 28)
        Me.cboDescription.TabIndex = 20
        '
        'txtOccupation
        '
        Me.txtOccupation.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOccupation.Location = New System.Drawing.Point(520, 216)
        Me.txtOccupation.Name = "txtOccupation"
        Me.txtOccupation.Size = New System.Drawing.Size(233, 27)
        Me.txtOccupation.TabIndex = 23
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(517, 196)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(77, 17)
        Me.Label11.TabIndex = 22
        Me.Label11.Text = "Occupation"
        '
        'txtHomeaddress
        '
        Me.txtHomeaddress.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHomeaddress.Location = New System.Drawing.Point(520, 283)
        Me.txtHomeaddress.Name = "txtHomeaddress"
        Me.txtHomeaddress.Size = New System.Drawing.Size(233, 27)
        Me.txtHomeaddress.TabIndex = 29
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(516, 263)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(98, 17)
        Me.Label12.TabIndex = 28
        Me.Label12.Text = "Home Address"
        '
        'txtEmailadd
        '
        Me.txtEmailadd.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmailadd.Location = New System.Drawing.Point(269, 283)
        Me.txtEmailadd.Name = "txtEmailadd"
        Me.txtEmailadd.Size = New System.Drawing.Size(233, 27)
        Me.txtEmailadd.TabIndex = 27
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(266, 263)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(93, 17)
        Me.Label13.TabIndex = 26
        Me.Label13.Text = "Email Address"
        '
        'txtMobilenumber
        '
        Me.txtMobilenumber.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMobilenumber.Location = New System.Drawing.Point(19, 283)
        Me.txtMobilenumber.Name = "txtMobilenumber"
        Me.txtMobilenumber.Size = New System.Drawing.Size(233, 27)
        Me.txtMobilenumber.TabIndex = 25
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(15, 263)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(103, 17)
        Me.Label14.TabIndex = 24
        Me.Label14.Text = "Mobile Number"
        '
        'txtZipcode
        '
        Me.txtZipcode.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtZipcode.Location = New System.Drawing.Point(771, 283)
        Me.txtZipcode.Name = "txtZipcode"
        Me.txtZipcode.Size = New System.Drawing.Size(233, 27)
        Me.txtZipcode.TabIndex = 31
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(768, 263)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(62, 17)
        Me.Label15.TabIndex = 30
        Me.Label15.Text = "Zip Code"
        '
        'txtValidIDNumber
        '
        Me.txtValidIDNumber.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtValidIDNumber.Location = New System.Drawing.Point(771, 354)
        Me.txtValidIDNumber.Name = "txtValidIDNumber"
        Me.txtValidIDNumber.Size = New System.Drawing.Size(233, 27)
        Me.txtValidIDNumber.TabIndex = 39
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(768, 334)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(107, 17)
        Me.Label16.TabIndex = 38
        Me.Label16.Text = "Valid ID Number"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(517, 334)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(85, 17)
        Me.Label17.TabIndex = 36
        Me.Label17.Text = "Valid ID Type"
        '
        'txtTinIDNo
        '
        Me.txtTinIDNo.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTinIDNo.Location = New System.Drawing.Point(269, 354)
        Me.txtTinIDNo.Name = "txtTinIDNo"
        Me.txtTinIDNo.Size = New System.Drawing.Size(233, 27)
        Me.txtTinIDNo.TabIndex = 35
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(265, 334)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(71, 17)
        Me.Label18.TabIndex = 34
        Me.Label18.Text = "TIN ID No."
        '
        'txtOfficeaddress
        '
        Me.txtOfficeaddress.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOfficeaddress.Location = New System.Drawing.Point(19, 354)
        Me.txtOfficeaddress.Name = "txtOfficeaddress"
        Me.txtOfficeaddress.Size = New System.Drawing.Size(233, 27)
        Me.txtOfficeaddress.TabIndex = 33
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(16, 334)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(95, 17)
        Me.Label19.TabIndex = 32
        Me.Label19.Text = "Office Address"
        '
        'cboValidIDType
        '
        Me.cboValidIDType.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboValidIDType.FormattingEnabled = True
        Me.cboValidIDType.Items.AddRange(New Object() {"Philippine Passport", "Unified Multi-Purpose ID (UMID)", "Driver's License", "Postal ID", "Voter's ID", "Professional Regulation Commission (PRC) ID", "Senior Citizen ID", "PhilHealth ID", "National Bureau of Investigation (NBI) Clearance", "Alien Certificate of Registration Identity Card (ACR I-Card)", "Others"})
        Me.cboValidIDType.Location = New System.Drawing.Point(520, 354)
        Me.cboValidIDType.Name = "cboValidIDType"
        Me.cboValidIDType.Size = New System.Drawing.Size(233, 28)
        Me.cboValidIDType.TabIndex = 40
        '
        'cboATMType
        '
        Me.cboATMType.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboATMType.FormattingEnabled = True
        Me.cboATMType.Items.AddRange(New Object() {"Debit", "Credit"})
        Me.cboATMType.Location = New System.Drawing.Point(520, 423)
        Me.cboATMType.Name = "cboATMType"
        Me.cboATMType.Size = New System.Drawing.Size(233, 28)
        Me.cboATMType.TabIndex = 48
        '
        'txtATMNumber
        '
        Me.txtATMNumber.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtATMNumber.Location = New System.Drawing.Point(771, 423)
        Me.txtATMNumber.Name = "txtATMNumber"
        Me.txtATMNumber.Size = New System.Drawing.Size(233, 27)
        Me.txtATMNumber.TabIndex = 47
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(768, 403)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(89, 17)
        Me.Label20.TabIndex = 46
        Me.Label20.Text = "ATM Number"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(517, 403)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(67, 17)
        Me.Label21.TabIndex = 45
        Me.Label21.Text = "ATM Type"
        '
        'txtBankAccountNumber
        '
        Me.txtBankAccountNumber.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBankAccountNumber.Location = New System.Drawing.Point(269, 423)
        Me.txtBankAccountNumber.Name = "txtBankAccountNumber"
        Me.txtBankAccountNumber.Size = New System.Drawing.Size(233, 27)
        Me.txtBankAccountNumber.TabIndex = 44
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(265, 403)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(146, 17)
        Me.Label22.TabIndex = 43
        Me.Label22.Text = "Bank Account Number"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(16, 403)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(124, 17)
        Me.Label23.TabIndex = 41
        Me.Label23.Text = "Bank Account Type"
        '
        'cboBankAccountType
        '
        Me.cboBankAccountType.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboBankAccountType.FormattingEnabled = True
        Me.cboBankAccountType.Items.AddRange(New Object() {"Banco de Oro (BDO)", "Metrobank", "Philippine National Bank (PNB)", "Bank of the Philippine Islands (BPI)", "Land Bank of the Philippines (Landbank)", "Security Bank", "UnionBank of the Philippines (UnionBank)", "China Banking Corporation (China Bank)", "RCBC (Rizal Commercial Banking Corporation)", "EastWest Bank", "Others"})
        Me.cboBankAccountType.Location = New System.Drawing.Point(19, 423)
        Me.cboBankAccountType.Name = "cboBankAccountType"
        Me.cboBankAccountType.Size = New System.Drawing.Size(233, 28)
        Me.cboBankAccountType.TabIndex = 49
        '
        'txtComakerOccupation
        '
        Me.txtComakerOccupation.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtComakerOccupation.Location = New System.Drawing.Point(771, 491)
        Me.txtComakerOccupation.Name = "txtComakerOccupation"
        Me.txtComakerOccupation.Size = New System.Drawing.Size(233, 27)
        Me.txtComakerOccupation.TabIndex = 57
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(768, 471)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(140, 17)
        Me.Label24.TabIndex = 56
        Me.Label24.Text = "Co-maker Occupation"
        '
        'txtComakerAddress
        '
        Me.txtComakerAddress.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtComakerAddress.Location = New System.Drawing.Point(520, 491)
        Me.txtComakerAddress.Name = "txtComakerAddress"
        Me.txtComakerAddress.Size = New System.Drawing.Size(233, 27)
        Me.txtComakerAddress.TabIndex = 55
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(516, 471)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(120, 17)
        Me.Label25.TabIndex = 54
        Me.Label25.Text = "Co-maker Address"
        '
        'txtComakerPhoneNumber
        '
        Me.txtComakerPhoneNumber.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtComakerPhoneNumber.Location = New System.Drawing.Point(269, 491)
        Me.txtComakerPhoneNumber.Name = "txtComakerPhoneNumber"
        Me.txtComakerPhoneNumber.Size = New System.Drawing.Size(233, 27)
        Me.txtComakerPhoneNumber.TabIndex = 53
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(266, 471)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(164, 17)
        Me.Label26.TabIndex = 52
        Me.Label26.Text = "Co-maker Phone Number"
        '
        'txtComakerFullname
        '
        Me.txtComakerFullname.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtComakerFullname.Location = New System.Drawing.Point(19, 491)
        Me.txtComakerFullname.Name = "txtComakerFullname"
        Me.txtComakerFullname.Size = New System.Drawing.Size(233, 27)
        Me.txtComakerFullname.TabIndex = 51
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(15, 471)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(132, 17)
        Me.Label27.TabIndex = 50
        Me.Label27.Text = "Co-maker Full Name"
        '
        'btnCreate
        '
        Me.btnCreate.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCreate.Location = New System.Drawing.Point(209, 545)
        Me.btnCreate.Name = "btnCreate"
        Me.btnCreate.Size = New System.Drawing.Size(141, 45)
        Me.btnCreate.TabIndex = 58
        Me.btnCreate.Text = "CREATE"
        Me.btnCreate.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.Location = New System.Drawing.Point(369, 545)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(141, 45)
        Me.btnUpdate.TabIndex = 59
        Me.btnUpdate.Text = "UPDATE"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(529, 545)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(141, 45)
        Me.btnClear.TabIndex = 60
        Me.btnClear.Text = "CLEAR"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Location = New System.Drawing.Point(689, 545)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(141, 45)
        Me.btnClose.TabIndex = 61
        Me.btnClose.Text = "CLOSE"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnUploadPicture
        '
        Me.btnUploadPicture.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUploadPicture.Location = New System.Drawing.Point(835, 205)
        Me.btnUploadPicture.Name = "btnUploadPicture"
        Me.btnUploadPicture.Size = New System.Drawing.Size(123, 23)
        Me.btnUploadPicture.TabIndex = 63
        Me.btnUploadPicture.Text = "UPLOAD PICTURE"
        Me.btnUploadPicture.UseVisualStyleBackColor = True
        '
        'picClientProfile
        '
        Me.picClientProfile.Image = Global.LoanManagementSystem.My.Resources.Resources.user_dummy
        Me.picClientProfile.Location = New System.Drawing.Point(835, 86)
        Me.picClientProfile.Name = "picClientProfile"
        Me.picClientProfile.Size = New System.Drawing.Size(123, 116)
        Me.picClientProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picClientProfile.TabIndex = 62
        Me.picClientProfile.TabStop = False
        '
        'frmCreateUpdateClient
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1025, 628)
        Me.Controls.Add(Me.btnUploadPicture)
        Me.Controls.Add(Me.picClientProfile)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnCreate)
        Me.Controls.Add(Me.txtComakerOccupation)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.txtComakerAddress)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.txtComakerPhoneNumber)
        Me.Controls.Add(Me.Label26)
        Me.Controls.Add(Me.txtComakerFullname)
        Me.Controls.Add(Me.Label27)
        Me.Controls.Add(Me.cboBankAccountType)
        Me.Controls.Add(Me.cboATMType)
        Me.Controls.Add(Me.txtATMNumber)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.txtBankAccountNumber)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.cboValidIDType)
        Me.Controls.Add(Me.txtValidIDNumber)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.txtTinIDNo)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.txtOfficeaddress)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.txtZipcode)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.txtHomeaddress)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtEmailadd)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txtMobilenumber)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.txtOccupation)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.cboDescription)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.cboArea)
        Me.Controls.Add(Me.txtSpouse)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cboCivilstatus)
        Me.Controls.Add(Me.txtAge)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.dtpBOD)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cboGender)
        Me.Controls.Add(Me.txtMiddlename)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtLastname)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtFirstname)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblClientCode)
        Me.Controls.Add(Me.lblID)
        Me.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "frmCreateUpdateClient"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Create & Update Client"
        Me.TopMost = True
        CType(Me.picClientProfile, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblID As Label
    Friend WithEvents lblClientCode As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtFirstname As TextBox
    Friend WithEvents txtLastname As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtMiddlename As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cboGender As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents dtpBOD As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents txtAge As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents cboCivilstatus As ComboBox
    Friend WithEvents txtSpouse As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents cboArea As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents cboDescription As ComboBox
    Friend WithEvents txtOccupation As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txtHomeaddress As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txtEmailadd As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents txtMobilenumber As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents txtZipcode As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents txtValidIDNumber As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents txtTinIDNo As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents txtOfficeaddress As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents cboValidIDType As ComboBox
    Friend WithEvents cboATMType As ComboBox
    Friend WithEvents txtATMNumber As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents txtBankAccountNumber As TextBox
    Friend WithEvents Label22 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents cboBankAccountType As ComboBox
    Friend WithEvents txtComakerOccupation As TextBox
    Friend WithEvents Label24 As Label
    Friend WithEvents txtComakerAddress As TextBox
    Friend WithEvents Label25 As Label
    Friend WithEvents txtComakerPhoneNumber As TextBox
    Friend WithEvents Label26 As Label
    Friend WithEvents txtComakerFullname As TextBox
    Friend WithEvents Label27 As Label
    Friend WithEvents btnCreate As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents picClientProfile As PictureBox
    Friend WithEvents btnUploadPicture As Button
End Class
