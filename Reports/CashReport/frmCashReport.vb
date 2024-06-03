Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient

Public Class frmCashReport
    Private Sub frmCashReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        getPayableAmount()
    End Sub

    Private Sub getPayableAmount()
        Try


            ConnDB()

            ' Define the date range
            Dim startDate As Date = New Date(2024, 1, 1)
            Dim endDate As Date = New Date(2024, 12, 31)

            sqL = "SELECT SUM(TotalPayable) AS TotalPayable " &
                                 "FROM paymentledger " &
                                 "WHERE ReceiptNo IS NOT NULL "
            cmd = New MySqlCommand(sqL, conn)
            da = New MySqlDataAdapter(cmd)



            ' Add parameters to avoid SQL injection
            cmd.Parameters.AddWithValue("@startDate", startDate)
            cmd.Parameters.AddWithValue("@endDate", endDate)

            ' Execute the command and retrieve the result
            Dim TotalPayable As Object = cmd.ExecuteScalar()

            ' Display the result
            If TotalPayable IsNot DBNull.Value Then
                Console.WriteLine("Total Payable: " & Convert.ToDecimal(TotalPayable))
                lblCollection.Text = TotalPayable
            Else
                Console.WriteLine("Total Payable: 0")
            End If

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub

End Class