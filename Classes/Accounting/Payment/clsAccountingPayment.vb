Imports MySql.Data.MySqlClient

Public Class clsAccountingPayment
    Public Sub createAccPaymentLedger(ProcessBy As String,
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
            ConnAccDB()
            sqL = "INSERT INTO tblcashreceipt (doc_number, " &
                                            "doc_date, " &
                                            "acc_number, " &
                                            "account_name, " &
                                            "sub_code, " &
                                            "sub_name, " &
                                            "dept, " &
                                            "debit, " &
                                            "credit, " &
                                            "total_debit, " &
                                            "total_credit, " &
                                            "created_by, " &
              "VALUES (@doc_number, " &
                        "@doc_date, " &
                        "@acc_number, " &
                        "@account_name, " &
                        "@sub_code, " &
                        "@sub_name, " &
                        "@CustomerCode, " &
                        "@dept, " &
                        "@debit, " &
                        "@credit, " &
                        "@total_debit, " &
                        "@total_credit, " &
                        "@created_by, "

            cmd = New MySqlCommand(sqL, connAcc)

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
