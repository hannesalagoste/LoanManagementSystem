
Public Class clsUsersAccount
    Public getCode As String
    Public userLoginName As String
    Public userLoginRole As String


    'TRACK USERS
    Public Sub getNameOfUserLogin(userLoginId As Integer)
        Try
            ConnDB()
            sqL = "SELECT fullname, userrole FROM useraccount WHERE userID= '" & userLoginId & "'"
            cmd = New MySql.Data.MySqlClient.MySqlCommand(sqL, conn)
            dr = cmd.ExecuteReader(CommandBehavior.CloseConnection)

            If dr.Read Then

                userLoginName = dr("fullname")
                userLoginRole = dr("userrole")


            Else
                userLoginName = ""
                userLoginRole = ""
            End If
        Catch ex As Exception

        Finally
            DisconnMy()
        End Try
    End Sub

    Public Sub createUserAccount(username As String, passwordhash As String, fullname As String, createdby As String, createdDate As Date, userrole As String)

        Try
            ConnDB()

            sqL = "INSERT INTO useraccount(username,passwordhash,fullname,createdby,createddate,userrole)VALUES(@username,@passwordhash,@fullname,@createdby,@createddate,@userrole)"
            cmd = New MySql.Data.MySqlClient.MySqlCommand(sqL, conn)
            cmd.Parameters.AddWithValue("@username", username)
            cmd.Parameters.AddWithValue("@passwordhash", passwordhash)
            cmd.Parameters.AddWithValue("@fullname", fullname)
            cmd.Parameters.AddWithValue("@createdby", createdby)
            cmd.Parameters.AddWithValue("@createddate", createdDate)
            cmd.Parameters.AddWithValue("@userrole", userrole)
            cmd.ExecuteNonQuery()
            MsgBox("User successfully created", MsgBoxStyle.Information)

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        Finally
            DisconnMy()
        End Try
    End Sub
    Public Sub UpdateUsers(id As String, username As String, password As String, fullname As String, lastmodifiedby As String, lastModifiedDate As Date, userrole As String)

        Try
            ConnDB()
            sqL = "UPDATE useraccount SET username=@username, passwordhash=@passwordhash, fullname=@fullname,  lastmodifiedby=@lastmodifiedby,lastmodifieddate=@lastmodifieddate, userrole=@userrole WHERE userID ='" & id.Trim & "'"
            cmd = New MySql.Data.MySqlClient.MySqlCommand(sqL, conn)
            cmd.Parameters.AddWithValue("@username", username)
            cmd.Parameters.AddWithValue("@passwordhash", password)
            cmd.Parameters.AddWithValue("@fullname", fullname)
            cmd.Parameters.AddWithValue("@lastmodifiedby", lastmodifiedby)
            cmd.Parameters.AddWithValue("@lastmodifieddate", lastModifiedDate)
            cmd.Parameters.AddWithValue("@userrole", userrole)
            cmd.ExecuteNonQuery()
            MsgBox("User successfully Update", MsgBoxStyle.Information)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        Finally
            DisconnMy()
        End Try
    End Sub
    Public Sub DeleteUsers(id As String)

        Try
            ConnDB()
            sqL = "DELETE FROM useraccount WHERE userID ='" & id.Trim & "'"
            cmd = New MySql.Data.MySqlClient.MySqlCommand(sqL, conn)
            cmd.ExecuteNonQuery()
            MsgBox("User successfully Deleted", MsgBoxStyle.Information)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        Finally
            DisconnMy()
        End Try
    End Sub

End Class
