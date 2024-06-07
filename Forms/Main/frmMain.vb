Public Class frmMain
    Private Sub ClientListToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClientListToolStripMenuItem.Click
        frmClientList.ShowDialog()
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblDate.Text = userLoginDateTime
        userLoginName = lblUserLogin.Text
        userLoginRole = lblRole.Text
    End Sub

    Private Sub CreateLoanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CreateLoanToolStripMenuItem.Click
        frmCreateLoan.ShowDialog()
    End Sub

    Private Sub AreaSettingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AreaSettingToolStripMenuItem.Click
        frmArea.ShowDialog()
    End Sub

    Private Sub UserSettingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UserSettingToolStripMenuItem.Click
        frmCreateUpdateListUser.ShowDialog()
    End Sub

    Private Sub LoanListToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoanListToolStripMenuItem.Click
        frmLoanList.ShowDialog()
    End Sub

    Private Sub RecieptToolStripMenuItem_Click(sender As Object, e As EventArgs) 
        frmLoanPaymentReport.ShowDialog()
    End Sub

    Private Sub LoanReleaseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoanReleaseToolStripMenuItem.Click
        frmLoanReleaseReport.ShowDialog()
    End Sub

    Private Sub CollectionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CollectionToolStripMenuItem.Click
        frmCollectionReport.ShowDialog()
    End Sub

    Private Sub CashReportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CashReportToolStripMenuItem.Click
        frmCashReport.ShowDialog()
    End Sub

    Private Sub LoanPaymentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoanPaymentToolStripMenuItem.Click
        frmLoanPayment.ShowDialog()
    End Sub

    Private Sub OtherPaymentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OtherPaymentToolStripMenuItem.Click
        frmOtherPayment.ShowDialog()
    End Sub

    Private Sub CreateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CreateToolStripMenuItem.Click
        frmCreateOtherTransaction.ShowDialog()
    End Sub
End Class