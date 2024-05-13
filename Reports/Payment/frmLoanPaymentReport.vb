Imports MySql.Data.MySqlClient

Public Class frmLoanPaymentReport
    Private Sub frmLoanPaymentReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblDocNo.Text = recieptNo
        Try
            ConnDB()
            Dim dtReceiptNo As New DataTable
            sqL = "select * from paymentledger WHERE ReceiptNo  = @n1"
            cmd = New MySqlCommand(sqL, conn)
            cmd.Parameters.AddWithValue("n1", recieptNo)
            da = New MySqlDataAdapter(cmd)
            da.Fill(dtReceiptNo)

            Dim dtloanaccount As New DataTable
            sqL = "select * from loanaccount "
            cmd = New MySqlCommand(sqL, conn)
            da = New MySqlDataAdapter(cmd)
            da.Fill(dtloanaccount)

            Dim dtclientaccount As New DataTable
            sqL = "select * from clientaccount "
            cmd = New MySqlCommand(sqL, conn)
            da = New MySqlDataAdapter(cmd)
            da.Fill(dtclientaccount)


            Dim report As New rptLoanPayment
            report.Load()
            report.Database.Tables("paymentledger").SetDataSource(dtReceiptNo)
            report.Database.Tables("loanaccount").SetDataSource(dtloanaccount)
            report.Database.Tables("clientaccount").SetDataSource(dtclientaccount)
            crvLoanPayment.ReportSource = report
            crvLoanPayment.Refresh()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


End Class