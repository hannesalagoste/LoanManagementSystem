Imports MySql.Data.MySqlClient

Public Class frmLoanReleaseReportViewer
    Private Sub frmLoanReleaseReportViewer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            ConnDB()
            Dim dtloanaccount As New DataTable
            sqL = "select * from loanaccount WHERE DATE(LoanDate) BETWEEN @FromDate AND @ToDate"
            cmd = New MySqlCommand(sqL, conn)
            da = New MySqlDataAdapter(cmd)
            cmd.Parameters.AddWithValue("@FromDate", fromDate)
            cmd.Parameters.AddWithValue("@ToDate", toDate)
            da.Fill(dtloanaccount)


            Dim report As New rptLoanRelease
            report.Load()
            Dim ctrDateFrom As CrystalDecisions.CrystalReports.Engine.TextObject
            Dim ctrDateTo As CrystalDecisions.CrystalReports.Engine.TextObject
            ctrDateFrom = report.ReportDefinition.ReportObjects("txtFromDate")
            ctrDateFrom.Text = fromDate
            ctrDateTo = report.ReportDefinition.ReportObjects("txtToDate" )
            ctrDateTo.Text = toDate
            report.Database.Tables("loanaccount").SetDataSource(dtloanaccount)
            crvLoanRelease.ReportSource = report
            crvLoanRelease.Refresh()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

End Class