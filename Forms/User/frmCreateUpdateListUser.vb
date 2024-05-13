Imports MySql.Data.MySqlClient

Public Class frmCreateUpdateListUser
    Private userAccounClass As New clsUsersAccount


    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
        Try
            userAccounClass.createUserAccount(txtUsername.Text(), txtPassword.Text(), txtFullname.Text.ToUpper(), userLoginName.ToUpper(), userLoginDateTime, txtFullname.Text())
            loadUserData()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub frmCreateUpdateListUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        checkRole()
        loadUserData()
        lblIdCheck()

    End Sub


    Private Sub checkRole()
        If userLoginRole.Trim = "Administrator" Then
            btnCreate.Enabled = True
            btnClear.Enabled = True
        Else
            btnCreate.Enabled = False
            btnUpdate.Enabled = False
            btnDelete.Enabled = False
            dtgvUserList.Enabled = False
        End If
    End Sub

    Private Sub lblIdCheck()
        If userLoginRole.Trim = "Administrator" Then
            If String.IsNullOrEmpty(lblId.Text) Then
                btnCreate.Enabled = True
                btnUpdate.Enabled = False
                btnDelete.Enabled = False
            Else
                btnCreate.Enabled = False
                btnUpdate.Enabled = True
                btnDelete.Enabled = True
            End If
        Else

        End If

    End Sub

    Private Sub loadUserData()
        Try
            ConnDB()
            sqL = "SELECT * FROM useraccount"
            cmd = New MySqlCommand(sqL, conn)
            da = New MySqlDataAdapter(cmd)
            Dim ds As DataSet = New DataSet()
            da.Fill(ds, sqL)
            dtgvUserList.DataSource = ds
            dtgvUserList.DataMember = sqL

            dtgvUserList.ClearSelection()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            DisconnMy()
        End Try
    End Sub

    Private Sub dtgvUserList_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgvUserList.CellContentClick
        Try

            lblId.Text = dtgvUserList(0, dtgvUserList.CurrentRow.Index).Value
            txtUsername.Text = dtgvUserList(1, dtgvUserList.CurrentRow.Index).Value
            txtPassword.Text = dtgvUserList(2, dtgvUserList.CurrentRow.Index).Value
            txtFullname.Text = dtgvUserList(3, dtgvUserList.CurrentRow.Index).Value
            'lblUserLogin.Text = dtgvUserList(6, dtgvUserList.CurrentRow.Index).Value
            'lblDate.Text = dtgvUserList(7, dtgvUserList.CurrentRow.Index).Value
            txtFullname.Text = dtgvUserList(8, dtgvUserList.CurrentRow.Index).Value

        Catch ex As Exception
        End Try

    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Try
            userAccounClass.UpdateUsers(lblId.Text(), txtUsername.Text(), txtPassword.Text, txtFullname.Text.ToUpper(), userLoginName.ToUpper(), userLoginDateTime, txtFullname.Text())

            lblId.Text = ""
            txtUsername.Clear()
            txtPassword.Clear()
            txtFullname.Clear()
            txtFullname.Text = "Please select level"
            loadUserData()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub



    Private Sub lblId_TextChanged(sender As Object, e As EventArgs) Handles lblId.TextChanged
        lblIdCheck()
    End Sub



    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        lblId.Text = ""
        txtUsername.Text = ""
        txtPassword.Text = ""
        txtFullname.Text = ""
        cboUserLevel.SelectedIndex = -1
    End Sub

    Private Sub lblId_Click(sender As Object, e As EventArgs) Handles lblId.Click

    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click

        Dim selectedUserRole As String = ""
        loadUserData()
        ConnDB()
        sqL = "SELECT * FROM useraccount where id = '" & lblId.Text & "'"
        cmd = New MySql.Data.MySqlClient.MySqlCommand(sqL, conn)
        dr = cmd.ExecuteReader(CommandBehavior.CloseConnection)


        Try

            While dr.Read()
                selectedUserRole = dr("userrole").ToString
            End While


            If selectedUserRole = "Administrator" Then
                MessageBox.Show("Admin can't be deleted", "DELETE DATA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ElseIf (MessageBox.Show("Are you sure you want to delete this record?", "DELETE DATA", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes) Then
                userAccounClass.DeleteUsers(lblId.Text())
            Else
                MessageBox.Show("Data not deleted", "DELETE DATA", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If


            'txtid.Clear()
            'txtuname.Clear()
            'txtPassword.Clear()
            'txtfname.Clear()
            'txtlname.Clear()
            'dptDate.ResetText()
            'cboUserLevel.Text = "Please select level"
            'dptlastDate.ResetText()

            loadUserData()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class