Imports MySql.Data.MySqlClient

Module DBConn

    Public ServerMySQL As String
    Public PortMySQL As String
    Public UserNameMySQL As String
    Public PwdMySQL As String
    Public DBNameMySQL As String
    Public sqL As String
    Public ds As New DataSet
    Public cmd As MySqlCommand
    Public dr As MySqlDataReader
    Public da As MySqlDataAdapter
    Public dt As DataTable
    Public conn As New MySqlConnection
    Public connAcc As New MySqlConnection
    Public result As String
    Public digit As Integer
    Public userLoginId As String
    Public i As Integer
    Public selectedClientomerForLoan As String
    Public data As Byte()
    Public systemDate As Date
    Public systemDateStatus As String
    Public systemDateStatusViaDateEntry As String

    Public userLoginDateTime As Date = Date.Now
    Public userLoginRole As String
    Public userLoginName As String

    Public recieptNo As String
    Public fromDate As Date
    Public toDate As Date


    'FOR  DATABASE CONNECTION LMSDB

    Public Sub ConnDB()
        conn.Close()
        Try
            conn.ConnectionString = "server=localhost; port=3306; user id=root;password=;database=lmsdb"
            conn.Open()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
            ' frmDBConnectionSettings.Show()
        End Try
    End Sub

    Public Sub ConnAccDB()
        connAcc.Close()
        Try
            connAcc.ConnectionString = "server=localhost; port=3306; user id=devhan;password=devhan;database=accdb"
            connAcc.Open()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Public Sub DisconnMy()
        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If
        ' conn.Dispose()
    End Sub

    Public Sub DisconnAccDB()
        If connAcc.State = ConnectionState.Open Then
            connAcc.Close()
        End If
    End Sub



End Module
