﻿Imports MySql.Data.MySqlClient

Public Class frmCollectionReport
    Private Sub frmCollectionReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            ConnDB()
            Dim dtReceiptNo As New DataTable
            sqL = "SELECT  * from paymentledger WHERE ReceiptNo IS NOT NULL AND ReceiptNo <> '' ORDER BY PayDate ASC"
            cmd = New MySqlCommand(sqL, conn)
            da = New MySqlDataAdapter(cmd)
            da.Fill(dtReceiptNo)


            Dim dtclientaccount As New DataTable
            sqL = "select * from clientaccount "
            cmd = New MySqlCommand(sqL, conn)
            da = New MySqlDataAdapter(cmd)
            da.Fill(dtclientaccount)


            Dim report As New rptCollection
            report.Load()
            report.Database.Tables("paymentledger").SetDataSource(dtReceiptNo)
            report.Database.Tables("clientaccount").SetDataSource(dtclientaccount)
            crvCollection.ReportSource = report
            crvCollection.Refresh()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class