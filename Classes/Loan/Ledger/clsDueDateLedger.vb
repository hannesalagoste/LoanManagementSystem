Imports MySql.Data.MySqlClient

Public Class clsDueDateLedger
    Public Sub createDueDateLedger(CustomerCode As String, LDSNo As String, LGNo As String, DueDate As Date)
        Try
            ConnDB()
            sqL = "INSERT INTO duedateledger (CustomerCode, " &
                                            "LDSNo, " &
                                            "LGNo, " &
                                            "DueDate) " &
              "VALUES (@CustomerCode, " &
                        "@LDSNo, " &
                        "@LGNo, " &
                        "@DueDate) "

            cmd = New MySqlCommand(sqL, conn)

            cmd.Parameters.AddWithValue("@CustomerCode", CustomerCode)
            cmd.Parameters.AddWithValue("@LDSNo", LDSNo)
            cmd.Parameters.AddWithValue("@LGNo", LGNo)
            cmd.Parameters.AddWithValue("@DueDate", DueDate)


            cmd.ExecuteNonQuery()
            'MessageBox.Show("Ledger created successfully", "SAVED", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            DisconnMy()
        End Try

    End Sub

End Class
