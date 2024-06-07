Imports MySql.Data.MySqlClient

Public Class frmCreateOtherTransaction
    Private Sub frmCreateOtherTransaction_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        load_Area()
    End Sub

    Sub load_Area()
        cboArea.Items.Clear()
        Try
            ConnAccDB()
            cmd = New MySqlCommand("SELECT account_description FROM tblchartaccounts", connAcc)
            dr = cmd.ExecuteReader
            While dr.Read = True
                cboArea.Items.Add(dr.Item("account_description").ToString)
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        connAcc.Close()
    End Sub
End Class