Public Class frmLoanReleaseReport
    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        fromDate = dtpDateFrom.Value
        toDate = dtpDateTo.Value
        frmLoanReleaseReportViewer.Show()
    End Sub
End Class