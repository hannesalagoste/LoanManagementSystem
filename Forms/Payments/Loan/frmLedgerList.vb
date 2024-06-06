Imports MySql.Data.MySqlClient

Public Class frmLedgerList

    Private Sub frmLedgerList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            ConnDB()
            sqL = "SELECT ClientCode, LedgerNo,LDSNo, LoanType, Area, ClientName, LoanAmount, MaturityDate  FROM loanaccount"
            cmd = New MySqlCommand(sqL, conn)
            da = New MySqlDataAdapter(cmd)
            Dim ds As DataSet = New DataSet()
            da.Fill(ds, sqL)
            dtgvLoanList.DataSource = ds
            dtgvLoanList.DataMember = sqL

            dtgvLoanList.ClearSelection()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            DisconnMy()
        End Try
    End Sub
    Private Sub txtSearchBox_TextChanged(sender As Object, e As EventArgs) Handles txtSearchBox.TextChanged
        Try
            ConnDB()
            Dim cmd As New MySqlCommand("Select ClientCode, LedgerNo, LoanType, Area, ClientName,LoanAmount, MaturityDate From loanaccount Where LedgerNo like Concat('%',@parm1,'%') Or ClientName like Concat('%',@parm1,'%')", conn)
            cmd.Parameters.AddWithValue("parm1", txtSearchBox.Text)
            da = New MySqlDataAdapter(cmd)
            Dim ds As DataSet = New DataSet()

            da.Fill(ds, sqL)
            dtgvLoanList.DataSource = ds
            dtgvLoanList.DataMember = sqL

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            DisconnMy()
        End Try
    End Sub

    Private Sub dtgvLoanList_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgvLoanList.CellClick
        frmLoanPayment.txtLedgerNo.Text = dtgvLoanList(1, dtgvLoanList.CurrentRow.Index).Value
        frmLoanPayment.Show()
        frmLoanPayment.Update()
        Me.Close()
    End Sub


End Class