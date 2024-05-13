Imports MySql.Data.MySqlClient

Public Class frmLoanReleaseReportViewer


    Private Sub frmLoanReleaseReportViewer_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
            ConnDB()
            Dim dtloanaccount As New DataTable
            sqL = "select * from loanaccount WHERE LoanDate >= @FromDate AND LoanDate <= @ToDate"
            cmd = New MySqlCommand(sqL, conn)
            cmd.Parameters.AddWithValue("@FromDate", fromDate)
            cmd.Parameters.AddWithValue("@ToDate", toDate)
            da = New MySqlDataAdapter(cmd)
            da.Fill(dtloanaccount)

            Dim report As New rptLoanRelease
            report.Load()
            ' Set parameter fields for displaying date range
            report.SetParameterValue("FromDate", fromDate)
            report.SetParameterValue("ToDate", toDate)
            report.Database.Tables("loanaccount").SetDataSource(dtloanaccount)
            crvLoanReleaseReportViewer.ReportSource = report
            crvLoanReleaseReportViewer.Refresh()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class