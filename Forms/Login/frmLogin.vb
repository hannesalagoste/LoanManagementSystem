Imports MySql.Data.MySqlClient

Public Class frmLogin
    Private classUser As New clsUsersAccount

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim currentDateAndTime As Date = Date.Now

        ConnDB()
        If txtUsername.Text = "admin" Then
            ' frmUserDetails.btnDelete.Enabled = True
        Else
            '  frmUserDetails.btnDelete.Enabled = False

        End If
        Try

            sqL = "SELECT userID FROM useraccount where username='" & txtUsername.Text & "' AND passwordhash  = '" & txtPassword.Text & "'"
            cmd = New MySqlCommand(sqL, conn)
            dr = cmd.ExecuteReader(CommandBehavior.CloseConnection)

            While dr.Read()
                i = 1
                userLoginId = dr("userID")
            End While

            If i > 0 Then
                classUser.getNameOfUserLogin(userLoginId)

                frmMain.lblUserLogin.Text = classUser.userLoginName
                frmMain.lblRole.Text = classUser.userLoginRole
                frmMain.lblDate.Text = currentDateAndTime
                'frmCreateUpdateListUser.lblUserLogin.Text = classUser.userLoginName
                'frmCreateUpdateListUser.lblRole.Text = classUser.userLoginRole
                'frmCreateUpdateListUser.lblDate.Text = currentDateAndTime
                'frmCreateUpdateClient.lblUserLogin.Text = classUser.userLoginName
                'frmCreateUpdateClient.lblDate.Text = currentDateAndTime



                'frmLoading.Show()
                ' frmSetSystemDate.Show()
                frmMain.Show()


                Me.Hide()
                txtUsername.Text = ""
                txtPassword.Text = ""
            Else
                MsgBox("Incorrect username or password!", MsgBoxStyle.Critical, "Login")
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Server Settings !")
            ' frmDBConnectionSettings.Show()
            Me.Hide()
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        End
    End Sub

    Private Sub btnTest_Click(sender As Object, e As EventArgs) Handles btnTest.Click
        Try
            ConnAccDB()
            MessageBox.Show("Connection to database 'accdb' successful", "Connection Test", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Connection Test", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            DisconnAccDB()
        End Try
    End Sub
End Class