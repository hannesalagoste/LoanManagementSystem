Imports MySql.Data.MySqlClient

Public Class frmCreateLoan
    Dim createLoanClass As New clsCreateLoan
    Dim dueDateLedgerClass As New clsDueDateLedger
    Dim paymentLedgerClass As New clsPaymentLedger

    Dim ComputeButtonClickCount As Integer = 0

    Private Sub frmCreateLoan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim currentDate As Date = Date.Now
        Dim year As String = currentDate.Year.ToString()
        Dim month As String = currentDate.Month.ToString("00") ' Ensure two digits for month
        Dim day As String = currentDate.Day.ToString("00") ' Ensure two digits for day
        lblLoanTrans.Text = ""

        lblusername.Text = userLoginName
        lblUserRole.Text = userLoginRole
        lbluserdate.Text = userLoginDateTime

        ' Assign formatted values to text boxes or labels
        ' dtpDate.Text = year & "-" & month & "-" & day
        ComputeButtonClickCount = 0

        lblID.Text = frmClientList.lblID.Text
        selectedClient()
        AutoincrimentLedgerNo()
        AutoincrimentLDSNo()
        dueDateMonthlyComputation()
    End Sub
    Private Sub AutoincrimentLDSNo()
        Dim iYear As Integer = Date.Now.Year
        Dim iMonth As Integer = Date.Now.Month
        Dim iDay As Integer = Date.Now.Day
        Dim formatDate As String = $"{iYear}-{iMonth.ToString("00")}-{iDay.ToString("00")}-"
        Dim x As String = ""
        Dim rand As Random = New Random()
        txtLDSNo.Text = ""

        ConnDB()

        ' Assuming formatDate is correctly defined earlier in your code

        Dim result As String = "" ' Initialize result variable

        Try
            ' Execute the SQL query to retrieve the maximum substring of LDSNo
            sqL = "SELECT MAX(SUBSTRING(LDSNo, -7)) FROM loanaccount"
            cmd = New MySqlCommand(sqL, conn)
            result = cmd.ExecuteScalar()?.ToString()

            ' Check if the result is empty or null
            If String.IsNullOrEmpty(result) Then
                ' If no result found, assign a default value
                result = "0000001"
            Else
                ' Extract the numeric portion from the result
                Dim lastDigits As String = result.TrimStart("0"c)
                ' Parse the lastDigits to an integer and increment by 1
                Dim digit As Integer
                If Integer.TryParse(lastDigits, digit) Then
                    digit += 1 ' Increment digit
                Else
                    ' Parsing failed, handle the error
                    MsgBox("Failed to parse LDSNo", MsgBoxStyle.Exclamation)
                    Return ' Exit the method or handle the error as required
                End If
                ' Format the incremented digit to 7 digits with leading zeros
                result = digit.ToString("D7")
            End If

            ' Construct the final LDSNo
            txtLDSNo.Text = "LDSN-" & formatDate & result

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)

        Finally
            DisconnMy()
        End Try


    End Sub

    Private Sub AutoincrimentLedgerNo()
        Dim iYear As Integer = Date.Now.Year
        Dim iMonth As Integer = Date.Now.Month
        Dim iDay As Integer = Date.Now.Day
        Dim formatDate As String = $"{iYear}-{iMonth.ToString("00")}-{iDay.ToString("00")}-"
        Dim x As String = ""
        Dim rand As Random = New Random()
        txtLedgerNo.Text = ""

        ConnDB()

        ' Assuming formatDate is correctly defined earlier in your code

        Dim result As String = "" ' Initialize result variable

        Try
            ' Execute the SQL query to retrieve the maximum substring of LDSNo
            sqL = "SELECT MAX(SUBSTRING(LedgerNo, -7)) FROM loanaccount"
            cmd = New MySqlCommand(sqL, conn)
            result = cmd.ExecuteScalar()?.ToString()

            ' Check if the result is empty or null
            If String.IsNullOrEmpty(result) Then
                ' If no result found, assign a default value
                result = "0000001"
            Else
                ' Extract the numeric portion from the result
                Dim lastDigits As String = result.TrimStart("0"c)
                ' Parse the lastDigits to an integer and increment by 1
                Dim digit As Integer
                If Integer.TryParse(lastDigits, digit) Then
                    digit += 1 ' Increment digit
                Else
                    ' Parsing failed, handle the error
                    MsgBox("Failed to parse LDSNo", MsgBoxStyle.Exclamation)
                    Return ' Exit the method or handle the error as required
                End If
                ' Format the incremented digit to 7 digits with leading zeros
                result = digit.ToString("D7")
            End If

            ' Construct the final LDSNo
            txtLedgerNo.Text = "LGN-" & formatDate & result

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)

        Finally
            DisconnMy()
        End Try

    End Sub


    Public Sub selectedClient()
        Try
            ConnDB()
            sqL = "select * from clientaccount where clientID = '" & lblID.Text & "' "
            cmd = New MySqlCommand(sqL, conn)
            da = New MySqlDataAdapter(cmd)
            Dim myReader As MySqlDataReader
            myReader = cmd.ExecuteReader()
            If myReader.Read Then
                Dim lastName As String = myReader("last_name")
                Dim firstName As String = myReader("first_name")
                Dim middleName As String = myReader("middle_name")
                Dim firstLetterMiddle As String = middleName.Substring(0, 1)
                Dim coMaker As String = myReader("coFullName")
                txtCustomerName.Text = lastName.ToUpper & ", " & firstName.ToUpper & " " & firstLetterMiddle.ToUpper & "."
                txtCusCode.Text = myReader("client_code")
                txtArea.Text = myReader("area")
                txtComaker.Text = coMaker.ToUpper

            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)

        End Try
    End Sub

    Private Sub rbNew_CheckedChanged(sender As Object, e As EventArgs)
        If rbNew.Checked = True Then
            rbRenew.Checked = False
        End If

    End Sub

    Private Sub rbRenew_CheckedChanged(sender As Object, e As EventArgs)
        If rbRenew.Checked = True Then
            rbNew.Checked = False
        End If
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        frmClientList.Show()
        Me.Close()
    End Sub

    Private Sub txtLoanAmount_TextChanged(sender As Object, e As EventArgs) Handles txtLoanAmount.TextChanged


        principalRateCalculation()
        totalAmort()
    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtAccNo.KeyPress, txtLoanAmount.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
    Private Sub txtInterestRate_TextChanged(sender As Object, e As EventArgs) Handles txtInterestRate.TextChanged

        interestRateCalculation()

    End Sub

    Private Sub txtInterest_TextChanged(sender As Object, e As EventArgs) Handles txtInterest.TextChanged
        totalAmort()

    End Sub
    Private Sub principalRateCalculation()
        Try
            Dim loanAmount As Decimal = txtLoanAmount.Text
            Dim termLoan As Integer = txtLoanTerm.Text
            Dim Principal As Decimal = Math.Round(loanAmount / termLoan, 2)
            txtPrincipal.Text = Principal.ToString("###,###,###,###.00")

            If txtLoanAmount.Text = "" Then
                txtLoanAmount.Focus()
            ElseIf txtLoanTerm.Text = "" Then
                txtLoanTerm.Focus()
            ElseIf txtLoanAmount.Text <> "" Then
                Dim NewBalance As Decimal = txtLoanAmount.Text
                Dim Principal1 As Decimal = Math.Round(loanAmount / termLoan, 2)
                txtPrincipal.Text = Principal1.ToString("###,###,###,###.00")
                txtNewLoanBalance.Text = NewBalance.ToString("###,###,###,###.00")
            End If
        Catch ex As Exception
            MsgBox("Loan Amount Is Empty!", MsgBoxStyle.Exclamation, "Loan Amount")
        End Try
    End Sub
    Private Sub interestRateCalculation()
        Try
            Dim convertInterestRateToDecimal As Decimal = Convert.ToDecimal(txtInterestRate.Text) / 100
            Dim loanAmount As Integer = txtLoanAmount.Text
            If txtInterestRate.Text = "" Then
                txtInterestRate.Focus()
            ElseIf txtInterestRate.Text <> "" Then
                Dim Interest As Decimal = Math.Round(loanAmount * convertInterestRateToDecimal, 1)
                txtInterest.Text = Interest.ToString("###,###,###,###.00")
            End If
        Catch ex As Exception
            MsgBox("Interest Rate Is Empty!", MsgBoxStyle.Exclamation, "Interest Rate")
            txtInterest.Text = ""
        End Try
    End Sub
    Private Sub totalAmort()
        Try
            Dim Principal As Decimal = txtPrincipal.Text
            Dim Interest As Decimal = txtInterest.Text
            Dim TotalAmort As Decimal = Math.Round(Principal + Interest, 2)
            txtTotalAmort.Text = TotalAmort.ToString("###,###,###,###.00")
        Catch ex As Exception

        End Try

    End Sub

    Private Sub txtLoanTerm_TextChanged(sender As Object, e As EventArgs) Handles txtLoanTerm.TextChanged


        Try

            If txtLoanTerm.Text = "" Then
                txtLoanAmount.Enabled = False
                'txtLoanAmount.Text = ""
                ' txtInterestRate.Text = ""
                dtpMaturityDate.Value = dtpEffectiveDate.Value
            Else
                txtLoanAmount.Enabled = True
                maturitydateMonthComputation()
                totalAmort()
                ComputeButtonClickCount = 0
                dtgDueDateList.Rows.Clear()

            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)

            ' MsgBox("Loan Term Is Empty!", MsgBoxStyle.Exclamation, "Term")
        End Try
    End Sub

    Private Sub btnCompute_Click(sender As Object, e As EventArgs) Handles btnCompute.Click
        Try
            Dim LoanAmount As Decimal = txtLoanAmount.Text
            Dim NotarialFee As Decimal = txtNotarialFee.Text
            Dim FinCharges As Decimal = txtFinCharges.Text
            Dim Accomodation As Decimal = txtAccomodation.Text
            Dim Inspection As Decimal = txtInspection.Text
            Dim LPP As Decimal = txtLPPP.Text
            Dim Fees As Decimal = Math.Round(NotarialFee + FinCharges + Accomodation + LPP + Inspection, 1)
            Dim NetProceeds As Decimal = Math.Round(LoanAmount - Fees, 1)
            Dim Term As Integer = txtLoanTerm.Text
            Dim Interest As Decimal = txtInterest.Text
            Dim TotalInterest As Decimal = Term * Interest
            lblTotalInterest.Text = TotalInterest.ToString("###,###,###,###.00")
            txtNetProceeds.Text = NetProceeds.ToString("###,###,###,###.00")

            ComputeButtonClickCount += 1
            If ComputeButtonClickCount = 1 Then
                addingRowsInDueDateList()
            End If
            btnCreateLoan.Enabled = True

        Catch ex As Exception
            MsgBox("Please enter data into the specified fields.", MsgBoxStyle.Exclamation)
            'MsgBox(ex.Message, MsgBoxStyle.Exclamation)

        End Try

    End Sub

    Private Sub dueDateMonthlyComputation()
        Dim startDate As Date = Date.Parse(dtpEffectiveDate.Text)
        Dim firstPayDay As Integer = 1
        'Dim saturday As Integer = 2
        Dim DayOfTheWeek As Integer = dtpEffectiveDate.Value.DayOfWeek
        'Dim todayDate As DateTime = DateTime.Now

        If DayOfTheWeek = "0" Then
            MessageBox.Show("Please select another date exept sunday", "SELECT DATE", MessageBoxButtons.OK, MessageBoxIcon.Error)
            dtpEffectiveDate.Value = DateAdd(DateInterval.Day, 1, startDate)
        Else
            dtpFirstDueDate.Value = DateAdd(DateInterval.Month, firstPayDay, startDate)
        End If
    End Sub
    Private Sub maturitydateMonthComputation()
        Dim startDate As Date = Date.Parse(dtpEffectiveDate.Value)
        Dim MaturityDate As Integer = Integer.Parse(txtLoanTerm.Text)
        'Dim saturday As Integer = Integer.Parse(txtSaturday.Text)
        'Dim todayDate As DateTime = DateTime.Now


        dtpMaturityDate.Value = DateAdd(DateInterval.Month, MaturityDate, startDate)

    End Sub

    Private Sub btnCreateLoan_Click(sender As Object, e As EventArgs) Handles btnCreateLoan.Click
        Try
            createLoan()
            createpaymentLedger()
            Dim dueDate = 1
            For Each row As DataGridViewRow In dtgDueDateList.Rows
                dueDateLedgerClass.createDueDateLedger(row.Cells(0).Value, row.Cells(1).Value, row.Cells(2).Value, row.Cells(3).Value)
                dueDate = dueDate + 1
            Next

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
        frmLoanList.Show()
        Me.Close()

    End Sub

    Private Sub rbNew_CheckedChanged_1(sender As Object, e As EventArgs) Handles rbNew.CheckedChanged
        If rbNew.Checked = True Then
            lblLoanTrans.Text = "New"
        Else
            lblLoanTrans.Text = ""
        End If
    End Sub

    Private Sub rbRenew_CheckedChanged_1(sender As Object, e As EventArgs) Handles rbRenew.CheckedChanged
        If rbRenew.Checked = True Then
            lblLoanTrans.Text = "Renew"
        Else
            lblLoanTrans.Text = ""
        End If
    End Sub

    Private Sub txtLoanAmount_Leave(sender As Object, e As EventArgs) Handles txtLoanAmount.Leave
        Try

            Dim value As String = txtLoanAmount.Text.Replace(",", "").Replace(".", "")
            Dim numValue As Double

            If Double.TryParse(value, numValue) Then
                txtLoanAmount.Text = numValue.ToString("#,##0.00")
            Else
                txtLoanAmount.Text = ""
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)

        End Try
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Public Sub addingRowsInDueDateList()

        Try
            Dim term As Integer = txtLoanTerm.Text
            'Dim startDate As Date = Date.Parse(dtpEffectiveDate.Value)
            'Dim firstPayDay As Integer = Integer.Parse(txtFirstDueDayInterval.Text)
            'Dim saturday As Integer = Integer.Parse(txtSaturday.Text)
            'Dim nextPay As Date = DateAdd(DateInterval.Day, firstPayDay, startDate)
            Dim firstDueDate As Date = dtpFirstDueDate.Value
            Dim NumberOfPayment As Integer

            NumberOfPayment = term * 1
            For i As Integer = 1 To NumberOfPayment
                dtgDueDateList.Rows.Add(txtCusCode.Text, txtLDSNo.Text, txtLedgerNo.Text, Format$(firstDueDate, "dd-MM-yyyy"))
                If firstDueDate.DayOfWeek = 0 Then
                    firstDueDate = DateAdd(DateInterval.Month, 1, firstDueDate)
                Else
                    firstDueDate = DateAdd(DateInterval.Month, 1, firstDueDate)
                End If
                If i = NumberOfPayment - 1 Then
                    dtpMaturityDate.Value = firstDueDate
                End If
            Next


        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)

        End Try

    End Sub
    Public Sub createpaymentLedger()
        Try
            If cboLoanType.SelectedItem = "DIMINISHING" Then
                paymentLedgerClass.createPaymentLedger(userLoginName, txtCusCode.Text, txtLedgerNo.Text, dtpEffectiveDate.Value, Nothing, txtLoanAmount.Text, "00.00", txtLoanAmount.Text, "00.00", "00.00", Nothing, "00.00")
            Else
                paymentLedgerClass.createPaymentLedger(userLoginName, txtCusCode.Text, txtLedgerNo.Text, dtpEffectiveDate.Value, Nothing, txtLoanAmount.Text, "00.00", txtLoanAmount.Text, lblTotalInterest.Text, "00.00", Nothing, "00.00")

            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub
    Public Sub createLoan()
        Try

            createLoanClass.createLoanAccount(
                    userLoginDateTime,
                    userLoginName,
                    userLoginRole,
                    txtCusCode.Text,
                    txtLedgerNo.Text,
                    txtLDSNo.Text,
                    txtPrevLDSNo.Text,
                    txtCustomerName.Text,
                    txtComaker.Text,
                    txtArea.Text,
                    cboLoanType.SelectedItem,
                    cboChecks.Text,
                    txtChecksNo.Text,
                    txtAccNo.Text,
                    txtCash.Text,
                    dtpEffectiveDate.Value,
                    dtpFirstDueDate.Value,
                    dtpMaturityDate.Value,
                    txtOldBalanceAmout.Text,
                    txtOldInterestAmount.Text,
                    lblLoanTrans.Text,
                    txtLoanTerm.Text,
                    txtLoanAmount.Text,
                    txtInterestRate.Text,
                    txtPrincipal.Text,
                    txtInterest.Text,
                    txtTotalAmort.Text,
                    txtNotarialFee.Text,
                    txtFinCharges.Text,
                    txtAccomodation.Text,
                    txtInspection.Text,
                    txtLPPP.Text,
                    txtNewLoanBalance.Text,
                    txtNetProceeds.Text
           )

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)

        End Try

    End Sub

End Class