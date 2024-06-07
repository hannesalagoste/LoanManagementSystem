Imports MySql.Data.MySqlClient

Public Class frmLoanDetails

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
                txtArea.Text = myReader("Area")
                txtTerms.Text = myReader("TermOfLoan") & " month's"
                txtLoanType.Text = myReader("LoanType")
                txtInterestRate.Text = myReader("InterestRate")
                txtLoanTrans.Text = myReader("LoanTrans")
                txtLoanAmount.Text = myReader("LoanAmount")
                txtFirstDueDate.Text = myReader("FirstDueDate")
                txtMaturityDate.Text = myReader("MaturityDate")
                txtMonthlyPrincipal.Text = Convert.ToDecimal(myReader("Principal")).ToString("#,##0.00")
                'txtMonthlyInterest.Text = myReader("Interest")
                ' txtMonthlyAmort.Text = myReader("MonthlyAmort")

                monthlyAmort = myReader("MonthlyAmort")
                monthlyInterest = myReader("Interest")
                'txtMonthlyPrincipal.Text = myReader("Principal")
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
                    "    SELECT PrinBalance, ROW_NUMBER() OVER (ORDER BY PrinBalance ASC, ldgID ASC) AS RowNum " &
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
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)

        End Try
    End Sub

    Public Sub ledgerList()
        Try
            ConnDB()
            sqL = "select PayDate,ReceiptNo,FORMAT(PrinAmount, 2) AS FormattedPrinAmount ,FORMAT(PrinPayment, 2) AS FormattedPrinPayment,FORMAT(PrinBalance, 2) AS FormattedPrinBalance,FORMAT(InterestAmount, 2) AS FormattedInterestAmount ,FORMAT(InterestPayment, 2) AS FormattedInterestPayment ,Penalty from paymentledger where LGNo = '" & txtLedgerNo.Text & "' "
            cmd = New MySqlCommand(sqL, conn)
            da = New MySqlDataAdapter(cmd)
            Dim ds As DataSet = New DataSet()
            da.Fill(ds, sqL)
            dtgvLedgerList.DataSource = ds
            dtgvLedgerList.DataMember = sqL

            dtgvLedgerList.ClearSelection()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)

        End Try
    End Sub

    Private Sub frmLoanDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GetLatestPrincipalBalance()
        selectedLedgerNo()
        ledgerList()
    End Sub

    Private Sub btnMakePayment_Click(sender As Object, e As EventArgs) Handles btnMakePayment.Click
        frmLoanPayment.txtLedgerNo.Text = txtLedgerNo.Text
        frmLoanPayment.Show()
        Me.Close()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class