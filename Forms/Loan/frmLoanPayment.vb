Imports MySql.Data.MySqlClient

Public Class frmLoanPayment
    Dim paymentLoanLedgerClass As New clsLoanPayment

    Private Sub frmLoanPayment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            dueDateList()
            txtProcessor.Text = userLoginName
            GetLatestPrincipalBalance()
            selectedLedgerNo()
            AutoincrementReceiptNo()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)

        End Try

    End Sub


    Private Sub AutoincrementReceiptNo()
        txtDocNo.Text = ""
        Try
            ConnDB()
            Dim sqL As String = "SELECT MAX(ReceiptNo) FROM paymentledger"
            Dim cmd As New MySqlCommand(sqL, conn)
            Dim result As String = cmd.ExecuteScalar()?.ToString()

            If String.IsNullOrEmpty(result) Then
                txtDocNo.Text = "1"
            Else
                Dim digit As Integer
                If Int32.TryParse(result, digit) Then
                    digit += 1
                    txtDocNo.Text = digit.ToString()
                Else
                    txtDocNo.Text = "1"
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        Finally
            DisconnMy()
        End Try
    End Sub


    Public Sub selectedLedgerNo()

        Try
            Dim monthlyAmort As Decimal
            Dim monthlyInterest As Decimal
            Dim OldPrincipal As Decimal = lblOldPrincipal.Text
            ConnDB()
            sqL = "select * from loanaccount where LedgerNo = '" & txtLedgerNo.Text & "' "
            cmd = New MySqlCommand(sqL, conn)
            da = New MySqlDataAdapter(cmd)
            Dim myReader As MySqlDataReader
            myReader = cmd.ExecuteReader()
            If myReader.Read Then
                Dim fullName As String = myReader("ClientName")
                txtCustomerName.Text = fullName.ToUpper
                txtCusCode.Text = myReader("ClientCode")
                txtLoanType.Text = myReader("LoanType")
                txtInterestRate.Text = myReader("InterestRate")
                monthlyAmort = myReader("MonthlyAmort")
                monthlyInterest = myReader("Interest")
                txtMonthlyPrincipal.Text = Convert.ToDecimal(myReader("Principal")).ToString("#,##0.00")
            End If

            If txtLoanType.Text = "DIMINISHING" Then
                Dim InterestRate As Decimal = Convert.ToDecimal(txtInterestRate.Text) / 100
                Dim diminishingInterest As Decimal = OldPrincipal * InterestRate
                Dim monthlyAmortDim As Decimal = txtMonthlyPrincipal.Text + diminishingInterest
                txtMonthlyInterest.Text = diminishingInterest.ToString("###,###,###,###.00")
                txtMonthlyAmort.Text = monthlyAmortDim.ToString("###,###,###,###.00")
            Else
                txtMonthlyInterest.Text = monthlyInterest.ToString("###,###,###,###.00")
                txtMonthlyAmort.Text = monthlyAmort.ToString("###,###,###,###.00")
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Public Sub GetLatestPrincipalBalance()
        Try
            ConnDB()
            sqL = "SELECT PrinBalance " &
                    "FROM ( " &
                    "    SELECT PrinBalance, ROW_NUMBER() OVER (PARTITION BY PayDate ORDER BY PrinBalance ASC, ldgID ASC) AS RowNum " &
                    "    FROM paymentledger " &
                    "    WHERE LGNo = '" & txtLedgerNo.Text & "'" &
                    ") AS SubQuery " &
                    "WHERE RowNum = 1"

            cmd = New MySqlCommand(sqL, conn)
            da = New MySqlDataAdapter(cmd)
            Dim myReader As MySqlDataReader
            myReader = cmd.ExecuteReader()
            If myReader.Read Then
                lblOldPrincipal.Text = myReader("PrinBalance")
                lblOldbalance.Text = Convert.ToDecimal(myReader("PrinBalance")).ToString("#,##0.00")
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)

        End Try
    End Sub



    Public Sub dueDateList()
        Try
            ConnDB()
            sqL = "Select DueDateLID,PaymentStatus, DueDate from duedateledger where LGNo = '" & txtLedgerNo.Text & "' "
            cmd = New MySqlCommand(sqL, conn)
            da = New MySqlDataAdapter(cmd)
            Dim ds As DataSet = New DataSet()
            da.Fill(ds, sqL)
            dtgvDueDateList.DataSource = ds
            dtgvDueDateList.DataMember = sqL
            dtgvDueDateList.ClearSelection()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)

        End Try
    End Sub

    Public Sub createpaymentLedger()
        Try
            paymentLoanLedgerClass.createPaymentLedger(userLoginName, cboPaymode.SelectedItem, txtDepBank.Text, txtCHKNumber.Text, txtCHKAmount.Text, txtRefund.Text, txtCusCode.Text, txtLedgerNo.Text, dtpDate.Value, txtDocNo.Text, "00.00", txtPrincipalAmountPay.Text, lblLoanBalance.Text, "00.00", txtInterestAmountPay.Text, lblTotalPayablePay.Text, txtPenaltyAmountPay.Text, lblStatus.Text)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()
    End Sub

    Private Sub btnPayNow_Click(sender As Object, e As EventArgs) Handles btnPayNow.Click
        Try
            If ckbReceipt.Checked = True Then
                If txtDocNo.Text = "" Then
                    MsgBox("Reciept field is empty", MsgBoxStyle.Exclamation, "Empty field")
                    txtDocNo.Focus()
                ElseIf cboPaymode.SelectedIndex = -1 Then
                    MsgBox("Please select payment mode", MsgBoxStyle.Exclamation, "Payment mode")
                    cboPaymode.Focus()
                Else
                    createpaymentLedger()
                    SaveChangesToDueDateLedger()
                    MsgBox("Payment Confirmed", MsgBoxStyle.Information, "Payment Confirmed")
                    recieptNo = txtDocNo.Text
                    frmLoanPaymentReport.Show()
                    Me.Close()
                End If
            ElseIf lblStatus.Text = "Status" Then
                MsgBox("Please Select in Due Date", MsgBoxStyle.Exclamation, "Due Date")
                dtgvDueDateList.DefaultCellStyle.BackColor = Color.Red
                lblSelectDate.ForeColor = Color.Red


            ElseIf cboPaymode.SelectedIndex = -1 Then
                MsgBox("Please select payment mode", MsgBoxStyle.Exclamation, "Payment mode")
                cboPaymode.Focus()
            Else
                dtgvDueDateList.DefaultCellStyle.BackColor = Color.White
                lblSelectDate.ForeColor = Color.Black

                createpaymentLedger()
                SaveChangesToDueDateLedger()
                MsgBox("Payment Confirmed", MsgBoxStyle.Information, "Payment Confirmed")
                recieptNo = txtDocNo.Text
                frmLoanPaymentReport.Show()
                frmLoanList.Show()
                Me.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Sub txtPrincipalAmountPay_TextChanged(sender As Object, e As EventArgs) Handles txtPrincipalAmountPay.TextChanged
        Try
            Dim PrincipalAmountPay As Double = txtPrincipalAmountPay.Text
            Dim OldPrincipal As Double = lblOldPrincipal.Text
            Dim LoanBalance As Double = OldPrincipal - PrincipalAmountPay
            lblLoanBalance.Text = LoanBalance.ToString("###,###,###,###.00")
        Catch ex As Exception
            ' MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try

    End Sub

    Private Sub rdbAuto_CheckedChanged(sender As Object, e As EventArgs) Handles rdbAuto.CheckedChanged
        If rdbAuto.Checked = True Then
            txtInterestAmountPay.Text = txtMonthlyInterest.Text
            txtPrincipalAmountPay.Text = txtMonthlyPrincipal.Text
            txtInterestAmountPay.Enabled = False
            txtPrincipalAmountPay.Enabled = False
            txtPenaltyAmountPay.Enabled = True
            txtPenaltyAmountPay.Clear()
            lblTotalPayablePay.Text = ""
            txtPenaltyAmountPay.Text = "00.00"
            btnPayNow.Enabled = False
        End If
    End Sub

    Private Sub rdbManual_CheckedChanged(sender As Object, e As EventArgs) Handles rdbManual.CheckedChanged
        If rdbManual.Checked = True Then
            txtInterestAmountPay.Clear()
            txtPrincipalAmountPay.Clear()
            lblLoanBalance.Text = ""
            txtInterestAmountPay.Enabled = True
            txtPrincipalAmountPay.Enabled = True
            txtPenaltyAmountPay.Enabled = True
            txtPenaltyAmountPay.Clear()
            lblTotalPayablePay.Text = ""
            txtPenaltyAmountPay.Text = "00.00"
            btnPayNow.Enabled = False

        End If
    End Sub

    Private Sub btnCompute_Click(sender As Object, e As EventArgs) Handles btnCompute.Click
        Try
            Dim PrincipalAmountPay As Decimal = txtPrincipalAmountPay.Text
            Dim InterestAmountPay As Decimal = txtInterestAmountPay.Text
            Dim TotalPayable As Decimal
            If txtPenaltyAmountPay.Text = "" Then
                TotalPayable = PrincipalAmountPay + InterestAmountPay
                lblTotalPayablePay.Text = TotalPayable.ToString("N2")
            Else
                Dim PenaltyAmountPay As Decimal = txtPenaltyAmountPay.Text
                TotalPayable = PrincipalAmountPay + InterestAmountPay + PenaltyAmountPay
                lblTotalPayablePay.Text = TotalPayable.ToString("N2")
            End If

            checkFieldCheck()
            validateDueDate()

        Catch ex As Exception
            MsgBox("Please check this field. Interest Amount and Principal Amount!", MsgBoxStyle.Exclamation, "Payment Field's is empty")
            If txtInterestAmountPay.Text = "" Then
                txtInterestAmountPay.Focus()
            ElseIf txtInterestAmountPay.Text = "" Then
                txtInterestAmountPay.Focus()
            End If
        End Try
    End Sub

    Private Sub lblTotalPayablePay_TextChanged(sender As Object, e As EventArgs) Handles lblTotalPayablePay.TextChanged
        Try
            If lblTotalPayablePay.Text <> "" Then
                btnPayNow.Enabled = True
            End If
            If lblTotalPayablePay.Text = "" Then
            Else
                checkFieldCheck()

            End If

        Catch ex As Exception
            ' MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub


    Private Sub checkFieldCheck()
        Try
            If cboPaymode.SelectedItem = "Check" Then
                Dim TotalPayble As Decimal = lblTotalPayablePay.Text
                Dim CHKAmount As Decimal = txtCHKAmount.Text
                Dim Refund As Decimal
                Refund = CHKAmount - TotalPayble
                txtRefund.Text = Refund.ToString("N2")
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Sub dtgvDueDateList_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles dtgvDueDateList.CellValueChanged
        Try
            ConnDB()
            If dtgvDueDateList IsNot Nothing AndAlso e.ColumnIndex = dtgvDueDateList.Columns(2).Index AndAlso e.RowIndex >= 0 Then
                Dim rowIndex As Integer = e.RowIndex
                Dim selectedStatus As String = dtgvDueDateList.Rows(rowIndex).Cells(2).Value.ToString()
                Dim primaryKeyValue As Integer = Convert.ToInt32(dtgvDueDateList.Rows(rowIndex).Cells(0).Value)
                sqL = "UPDATE duedateledger SET PaymentStatus = @PaymentStatus WHERE DueDateLID = @primaryKeyValue"
                cmd = New MySql.Data.MySqlClient.MySqlCommand(sqL, conn)
                cmd.Parameters.AddWithValue("@PaymentStatus", selectedStatus)
                cmd.Parameters.AddWithValue("@DueDateLID", primaryKeyValue)
                cmd.ExecuteNonQuery()
            End If

            If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
                Dim dataGridView As DataGridView = TryCast(sender, DataGridView)

                If dataGridView.Columns(e.ColumnIndex).Name = "PaymentStatus" Then
                    Dim row As DataGridViewRow = dataGridView.Rows(e.RowIndex)

                    Dim paymentStatus As Object = row.Cells("PaymentStatus").Value
                    Dim dateValue As Object = row.Cells("DueDate").Value
                    lblStatus.Text = paymentStatus
                    lblDueDate.Text = dateValue

                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try

    End Sub

    Private Sub SaveChangesToDueDateLedger()
        Try
            ConnDB()

            For Each row As DataGridViewRow In dtgvDueDateList.Rows
                If Not row.IsNewRow AndAlso row.Cells("PaymentStatus").Value IsNot Nothing Then
                    Dim dueDateLID As Integer = Convert.ToInt32(row.Cells("DueDateLID").Value)
                    Dim paymentStatus As String = row.Cells("PaymentStatus").Value.ToString()

                    sqL = "UPDATE duedateledger SET PaymentStatus = @PaymentStatus WHERE DueDateLID = @DueDateLID"
                    cmd = New MySql.Data.MySqlClient.MySqlCommand(sqL, conn)
                    cmd.Parameters.AddWithValue("@PaymentStatus", paymentStatus)
                    cmd.Parameters.AddWithValue("@DueDateLID", dueDateLID)
                    cmd.ExecuteNonQuery()
                End If
            Next

        Catch ex As Exception
            MsgBox("Error saving changes in Due Date Ledger: " & ex.Message, MsgBoxStyle.Exclamation)
        Finally
            conn.Close()
        End Try


    End Sub

    Private Sub txtPenaltyAmountPay_Leave(sender As Object, e As EventArgs) Handles txtPenaltyAmountPay.Leave
        Try

            Dim value As String = txtPenaltyAmountPay.Text.Replace(",", "")
            Dim numValue As Double

            If Double.TryParse(value, numValue) Then
                txtPenaltyAmountPay.Text = numValue.ToString("#,##0.00")
            Else
                txtPenaltyAmountPay.Text = ""
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)

        End Try
    End Sub

    Private Sub txtInterestAmountPay_Leave(sender As Object, e As EventArgs) Handles txtInterestAmountPay.Leave
        Try

            Dim value As String = txtInterestAmountPay.Text.Replace(",", "")
            Dim numValue As Double

            If Double.TryParse(value, numValue) Then
                txtInterestAmountPay.Text = numValue.ToString("#,##0.00")
            Else
                txtInterestAmountPay.Text = ""
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)

        End Try
    End Sub

    Private Sub txtPrincipalAmountPay_Leave(sender As Object, e As EventArgs) Handles txtPrincipalAmountPay.Leave
        Try

            Dim value As String = txtPrincipalAmountPay.Text.Replace(",", "")
            Dim numValue As Double

            If Double.TryParse(value, numValue) Then
                txtPrincipalAmountPay.Text = numValue.ToString("#,##0.00")
            Else
                txtPrincipalAmountPay.Text = ""
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)

        End Try
    End Sub

    Private Sub lblLoanBalance_Leave(sender As Object, e As EventArgs) Handles lblLoanBalance.Leave
        Try

            Dim value As String = lblLoanBalance.Text.Replace(",", "")
            Dim numValue As Double

            If Double.TryParse(value, numValue) Then
                lblLoanBalance.Text = numValue.ToString("#,##0.00")
            Else
                lblLoanBalance.Text = ""
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)

        End Try
    End Sub

    Private Sub txtCHKAmount_Leave(sender As Object, e As EventArgs) Handles txtCHKAmount.Leave
        Try

            Dim value As String = txtCHKAmount.Text.Replace(",", "")
            Dim numValue As Double

            If Double.TryParse(value, numValue) Then
                txtCHKAmount.Text = numValue.ToString("#,##0.00")
            Else
                txtCHKAmount.Text = ""
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)

        End Try
    End Sub

    Private Sub cboPaymode_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboPaymode.SelectedIndexChanged
        Try
            If cboPaymode.SelectedIndex = 0 Then
                txtCHKNumber.Enabled = False
                txtCHKAmount.Enabled = False
                txtCHKAmount.Text = "00.00"
                txtRefund.Text = "00.00"
            ElseIf cboPaymode.SelectedIndex = 1 Then
                txtCHKNumber.Enabled = True
                txtCHKAmount.Enabled = True
                txtCHKAmount.Text = ""
                If txtCHKAmount.Text = "" Then
                    MsgBox("Check amount field is empty ", MsgBoxStyle.Exclamation)
                    txtCHKAmount.Focus()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)

        End Try
    End Sub
    Private Sub validateDueDate()
        Dim dueDateText As String = lblDueDate.Text
        Dim dueDate As Date
        If Not Date.TryParse(dueDateText, dueDate) Then

            MsgBox("Please Select in Due Date", MsgBoxStyle.Exclamation, "Due Date")
            dtgvDueDateList.DefaultCellStyle.BackColor = Color.Red
            lblSelectDate.ForeColor = Color.Red
        Else
            dtgvDueDateList.DefaultCellStyle.BackColor = Color.White
            lblSelectDate.ForeColor = Color.Black

            CheckDueDate()
        End If
    End Sub

    Private Sub CheckDueDate()
        Try
            Dim currentDate As Date = "07/06/2024"
            Dim dueDate As Date

            If Date.TryParse(lblDueDate.Text, dueDate) Then
                Dim nextDayOfDueDate As Date = dueDate.AddDays(1)
                If currentDate >= nextDayOfDueDate Then
                    ' Enable penalty TextBox
                    If txtPenaltyAmountPay.Text = "0.00" Or txtPenaltyAmountPay.Text = "00.00" Then
                        txtPenaltyAmountPay.Enabled = True
                        txtPenaltyAmountPay.Focus()
                        txtPenaltyAmountPay.BackColor = Color.Red
                    Else
                        txtPenaltyAmountPay.BackColor = Color.White

                    End If
                Else
                    ' Disable penalty TextBox
                    txtPenaltyAmountPay.Enabled = False
                End If
            Else
                MessageBox.Show("Due date is not valid.")
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try

    End Sub

    Private Sub ckbReceipt_CheckedChanged(sender As Object, e As EventArgs) Handles ckbReceipt.CheckedChanged
        If ckbReceipt.Checked = True Then
            txtDocNo.Enabled = True
            txtDocNo.Focus()
        Else
            txtDocNo.Enabled = False
        End If
    End Sub

    Private Sub lblStatus_TextChanged(sender As Object, e As EventArgs) Handles lblStatus.TextChanged
        Try
            If lblStatus.Text = "Status" Then
            Else
                btnPayNow.Enabled = True
            End If

        Catch ex As Exception
            ' MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub

   
End Class