Public Class clsCreateLoan
    Public Sub createLoanAccount(
                                createdDate As Date,
                                createdBy As String,
                                createdRole As String,
                                clientCode As String,
                                ledgerNo As String,
                                lDSNo As String,
                                prevLDSNo As String,
                                clientName As String,
                                coMaker As String,
                                area As String,
                                loanType As String,
                                checks As String,
                                checksNo As String,
                                acctNo As String,
                                cash As Decimal,
                                loanDate As Date,
                                firstDueDate As Date,
                                maturityDate As Date,
                                oldBalanceAmount As Decimal,
                                oldInterestAmount As Decimal,
                                loanTrans As String,
                                termOfLoan As String,
                                loanAmount As Decimal,
                                interestRate As Decimal,
                                principal As Decimal,
                                interest As Decimal,
                                monthlyAmort As Decimal,
                                notarialFee As Decimal,
                                finCharge As Decimal,
                                accomodation As Decimal,
                                inspection As Decimal,
                                lPPP As Decimal,
                                newBalance As Decimal,
                                netProceeds As Decimal
                                )

        Try
            ConnDB()

            sqL = "INSERT INTO loanaccount(" &
                "CreatedDate, " &
                "CreatedBy, " &
                "CreatedRole, " &
                "ClientCode, " &
                "LedgerNo, " &
                "LDSNo, " &
                "PrevLDSNo, " &
                "ClientName, " &
                "CoMaker, " &
                "Area, " &
                "LoanType, " &
                "Checks, " &
                "ChecksNo, " &
                "AcctNo, " &
                "Cash, " &
                "LoanDate, " &
                "FirstDueDate, " &
                "MaturityDate, " &
                "OldBalanceAmount, " &
                "OldInterestAmount, " &
                "LoanTrans, " &
                "TermOfLoan, " &
                "LoanAmount, " &
                "InterestRate, " &
                "Principal, " &
                "Interest, " &
                "MonthlyAmort, " &
                "NotarialFee, " &
                "FinCharge, " &
                "Accomodation, " &
                "Inspection, " &
                "LPPP, " &
                "NewBalance, " &
                "NetProceeds) " &
                "VALUES (" &
                "@CreatedDate, " &
                "@CreatedBy, " &
                "@CreatedRole, " &
                "@ClientCode, " &
                "@LedgerNo, " &
                "@LDSNo, " &
                "@PrevLDSNo, " &
                "@ClientName, " &
                "@CoMaker, " &
                "@Area, " &
                "@LoanType, " &
                "@Checks, " &
                "@CheckNo, " &
                "@AcctNo, " &
                "@Cash, " &
                "@LoanDate, " &
                "@FirstDueDate, " &
                "@MaturityDate, " &
                "@OldBalanceAmount, " &
                "@OldInterestAmount, " &
                "@LoanTrans, " &
                "@TermOfLoan, " &
                "@LoanAmount, " &
                "@InterestRate, " &
                "@Principal, " &
                "@Interest, " &
                "@MonthlyAmort, " &
                "@NotarialFee, " &
                "@FinCharge, " &
                "@Accomodation, " &
                "@Inspection, " &
                "@LPPP, " &
                "@NewBalance, " &
                "@NetProceeds)"
            cmd = New MySql.Data.MySqlClient.MySqlCommand(sqL, conn)
            cmd.Parameters.AddWithValue("@CreatedDate", createdDate)
            cmd.Parameters.AddWithValue("@CreatedBy", createdBy)
            cmd.Parameters.AddWithValue("@CreatedRole", createdRole)
            cmd.Parameters.AddWithValue("@ClientCode", clientCode)
            cmd.Parameters.AddWithValue("@LedgerNo", ledgerNo)
            cmd.Parameters.AddWithValue("@LDSNo", lDSNo)
            cmd.Parameters.AddWithValue("@PrevLDSNo", prevLDSNo)
            cmd.Parameters.AddWithValue("@ClientName", clientName)
            cmd.Parameters.AddWithValue("@CoMaker", coMaker)
            cmd.Parameters.AddWithValue("@Area", area)
            cmd.Parameters.AddWithValue("@LoanType", loanType)
            cmd.Parameters.AddWithValue("@Checks", checks)
            cmd.Parameters.AddWithValue("@CheckNo", checksNo)
            cmd.Parameters.AddWithValue("@AcctNo", acctNo)
            cmd.Parameters.AddWithValue("@Cash", cash)
            cmd.Parameters.AddWithValue("@LoanDate", loanDate)
            cmd.Parameters.AddWithValue("@FirstDueDate", firstDueDate)
            cmd.Parameters.AddWithValue("@MaturityDate", maturityDate)
            cmd.Parameters.AddWithValue("@OldBalanceAmount", oldBalanceAmount)
            cmd.Parameters.AddWithValue("@OldInterestAmount", oldInterestAmount)
            cmd.Parameters.AddWithValue("@LoanTrans", loanTrans)
            cmd.Parameters.AddWithValue("@TermOfLoan", termOfLoan)
            cmd.Parameters.AddWithValue("@LoanAmount", loanAmount)
            cmd.Parameters.AddWithValue("@InterestRate", interestRate)
            cmd.Parameters.AddWithValue("@Principal", principal)
            cmd.Parameters.AddWithValue("@Interest", interest)
            cmd.Parameters.AddWithValue("@MonthlyAmort", monthlyAmort)
            cmd.Parameters.AddWithValue("@NotarialFee", notarialFee)
            cmd.Parameters.AddWithValue("@FinCharge", finCharge)
            cmd.Parameters.AddWithValue("@Accomodation", accomodation)
            cmd.Parameters.AddWithValue("@Inspection", inspection)
            cmd.Parameters.AddWithValue("@LPPP", lPPP)
            cmd.Parameters.AddWithValue("@NewBalance", newBalance)
            cmd.Parameters.AddWithValue("@NetProceeds", netProceeds)

            cmd.ExecuteNonQuery()
            MsgBox("Loan Created Successfully", MsgBoxStyle.Information, "Loan Created")

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        Finally
            DisconnMy()
        End Try
    End Sub


End Class
