Imports MySql.Data.MySqlClient

Public Class clsPaymentLedger

    Public Sub createPaymentLedger(ProcessBy As String,
                       CustomerCode As String,
                       LGNo As String,
                       PayDate As Date,
                       ReceiptNo As String,
                       PrinAmount As Decimal,
                       PrinPayment As Decimal,
                       PrinBalance As Decimal,
                       InterestAmount As Decimal,
                       InterestPayment As Decimal,
                       Status As String,
                       Penalty As Decimal)
        Try
            ConnDB()
            sqL = "INSERT INTO paymentledger (ProcessBy, " &
                                            "CustomerCode, " &
                                            "LGNo, " &
                                            "ReceiptNo, " &
                                            "PayDate, " &
                                            "PrinAmount, " &
                                            "PrinPayment, " &
                                            "PrinBalance, " &
                                            "InterestAmount, " &
                                            "InterestPayment, " &
                                            "Status, " &
                                            "Penalty) " &
              "VALUES (@ProcessBy, " &
                        "@CustomerCode, " &
                        "@LGNo, " &
                        "@ReceiptNo, " &
                        "@PayDate, " &
                        "@PrinAmount, " &
                        "@PrinPayment, " &
                        "@PrinBalance, " &
                        "@InterestAmount, " &
                        "@InterestPayment, " &
                        "@Status, " &
                        "@Penalty) "

            cmd = New MySqlCommand(sqL, conn)

            cmd.Parameters.AddWithValue("@ProcessBy", ProcessBy)
            cmd.Parameters.AddWithValue("@CustomerCode", CustomerCode)
            cmd.Parameters.AddWithValue("@LGNo", LGNo)
            cmd.Parameters.AddWithValue("@ReceiptNo", ReceiptNo)
            cmd.Parameters.AddWithValue("@PayDate", PayDate)
            cmd.Parameters.AddWithValue("@PrinAmount", PrinAmount)
            cmd.Parameters.AddWithValue("@PrinPayment", PrinPayment)
            cmd.Parameters.AddWithValue("@PrinBalance", PrinBalance)
            cmd.Parameters.AddWithValue("@InterestAmount", InterestAmount)
            cmd.Parameters.AddWithValue("@InterestPayment", InterestPayment)
            cmd.Parameters.AddWithValue("@Status", Status)
            cmd.Parameters.AddWithValue("@Penalty", Penalty)

            cmd.ExecuteNonQuery()
            'MessageBox.Show("Ledger created successfully", "SAVED", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            DisconnMy()
        End Try

    End Sub
End Class
