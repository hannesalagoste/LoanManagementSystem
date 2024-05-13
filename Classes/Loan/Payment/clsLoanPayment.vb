Imports MySql.Data.MySqlClient

Public Class clsLoanPayment
    Public Sub createPaymentLedger(ProcessBy As String,
                       Paymode As String,
                       DepBank As String,
                       CHKNo As String,
                       CHKAmount As Decimal,
                       Refund As Decimal,
                       CustomerCode As String,
                       LGNo As String,
                       PayDate As Date,
                       ReceiptNo As String,
                       PrinAmount As Decimal,
                       PrinPayment As Decimal,
                       PrinBalance As Decimal,
                       InterestAmount As Decimal,
                       InterestPayment As Decimal,
                       TotalPayable As Decimal,
                       Penalty As Decimal,
                       Status As String)
        Try
            ConnDB()
            sqL = "INSERT INTO paymentledger (ProcessBy, " &
                                            "Paymode, " &
                                            "DepBank, " &
                                            "CHKNo, " &
                                            "CHKAmount, " &
                                            "Refund, " &
                                            "CustomerCode, " &
                                            "LGNo, " &
                                            "ReceiptNo, " &
                                            "PayDate, " &
                                            "PrinAmount, " &
                                            "PrinPayment, " &
                                            "PrinBalance, " &
                                            "InterestAmount, " &
                                            "InterestPayment, " &
                                            "TotalPayable, " &
                                            "Penalty, " &
                                            "Status) " &
              "VALUES (@ProcessBy, " &
                        "@Paymode, " &
                        "@DepBank, " &
                        "@CHKNo, " &
                        "@CHKAmount, " &
                        "@Refund, " &
                        "@CustomerCode, " &
                        "@LGNo, " &
                        "@ReceiptNo, " &
                        "@PayDate, " &
                        "@PrinAmount, " &
                        "@PrinPayment, " &
                        "@PrinBalance, " &
                        "@InterestAmount, " &
                        "@InterestPayment, " &
                        "@TotalPayable, " &
                        "@Penalty, " &
                        "@Status) "

            cmd = New MySqlCommand(sqL, conn)

            cmd.Parameters.AddWithValue("@ProcessBy", ProcessBy)
            cmd.Parameters.AddWithValue("@Paymode", Paymode)
            cmd.Parameters.AddWithValue("@DepBank", DepBank)
            cmd.Parameters.AddWithValue("@CHKNo", CHKNo)
            cmd.Parameters.AddWithValue("@CHKAmount", CHKAmount)
            cmd.Parameters.AddWithValue("@Refund", Refund)
            cmd.Parameters.AddWithValue("@CustomerCode", CustomerCode)
            cmd.Parameters.AddWithValue("@LGNo", LGNo)
            cmd.Parameters.AddWithValue("@ReceiptNo", ReceiptNo)
            cmd.Parameters.AddWithValue("@PayDate", PayDate)
            cmd.Parameters.AddWithValue("@PrinAmount", PrinAmount)
            cmd.Parameters.AddWithValue("@PrinPayment", PrinPayment)
            cmd.Parameters.AddWithValue("@PrinBalance", PrinBalance)
            cmd.Parameters.AddWithValue("@InterestAmount", InterestAmount)
            cmd.Parameters.AddWithValue("@InterestPayment", InterestPayment)
            cmd.Parameters.AddWithValue("@TotalPayable", TotalPayable)
            cmd.Parameters.AddWithValue("@Penalty", Penalty)
            cmd.Parameters.AddWithValue("@Status", Status)

            cmd.ExecuteNonQuery()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            DisconnMy()
        End Try

    End Sub
End Class
