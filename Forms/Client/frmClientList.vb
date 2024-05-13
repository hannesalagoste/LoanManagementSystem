Imports MySql.Data.MySqlClient

Public Class frmClientList


    Private clientAccountClass As New clsClientAccount

    Private Sub frmClientList_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        loadClientList()

    End Sub


    Public Sub loadClientList()
        Try
            ConnDB()
            sqL = "Select clientID,client_code,last_name,first_name,middle_name,gender,age,birth_date,civil_status,mobile_no,occupation,home_add,created_by  From clientaccount"
            cmd = New MySqlCommand(sqL, conn)
            da = New MySqlDataAdapter(cmd)
            Dim ds As DataSet = New DataSet()

            da.Fill(ds, sqL)
            dtgvClientList.DataSource = ds
            dtgvClientList.DataMember = sqL
            dtgvClientList.ColumnHeadersDefaultCellStyle.BackColor = Color.White
            dtgvClientList.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.White
            dtgvClientList.ColumnHeadersDefaultCellStyle.Font = New Font("segue ui", 9, FontStyle.Bold)
            dtgvClientList.RowsDefaultCellStyle.Font = New Font("segue ui", 10, FontStyle.Regular)
            dtgvClientList.EnableHeadersVisualStyles = False
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            DisconnMy()
        End Try
    End Sub

    Private Sub txtSearchBox_TextChanged(sender As Object, e As EventArgs) Handles txtSearchBox.TextChanged

        Try
            ConnDB()
            Dim cmd As New MySqlCommand("Select clientID,client_code,last_name,first_name,middle_name,gender,age,birth_date,civil_status,mobile_no,occupation,home_add,created_by From clientaccount Where last_name like Concat('%',@parm1,'%') Or first_name like Concat('%',@parm1,'%')", conn)
            cmd.Parameters.AddWithValue("parm1", txtSearchBox.Text)
            da = New MySqlDataAdapter(cmd)
            Dim ds As DataSet = New DataSet()
            dtgvClientList.ColumnHeadersDefaultCellStyle.Font = New Font("segue ui", 11, FontStyle.Bold)
            dtgvClientList.EnableHeadersVisualStyles = False

            da.Fill(ds, sqL)
            dtgvClientList.DataSource = ds
            dtgvClientList.DataMember = sqL


        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            DisconnMy()
        End Try
    End Sub

    Private Sub btnAddNewCLient_Click(sender As Object, e As EventArgs) Handles btnAddNewCLient.Click
        frmCreateUpdateClient.Show()
        frmCreateUpdateClient.lblID.Text = ""
    End Sub

    Private Sub dtgvClientList_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgvClientList.CellClick
        Try
            frmCreateUpdateClient.lblID.Text = dtgvClientList(0, dtgvClientList.CurrentRow.Index).Value
            lblID.Text = dtgvClientList(0, dtgvClientList.CurrentRow.Index).Value
            lblClientname.Text = dtgvClientList(2, dtgvClientList.CurrentRow.Index).Value + ", " + dtgvClientList(3, dtgvClientList.CurrentRow.Index).Value

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        frmCreateUpdateClient.Show()
        frmCreateUpdateClient.lblID.Text = lblID.Text
    End Sub



    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        ConnDB()
        sqL = "SELECT * FROM clientaccount where clientID = '" & lblID.Text & "'"
        cmd = New MySql.Data.MySqlClient.MySqlCommand(sqL, conn)
        dr = cmd.ExecuteReader(CommandBehavior.CloseConnection)


        Try


            If frmMain.lblRole.Text = "Administrator" Then
                Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete '" & lblClientname.Text & "' record?", "DELETE DATA", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If result = DialogResult.Yes Then
                    clientAccountClass.DeleteClient(lblID.Text())
                Else
                    frmCreateUpdateClient.Close()
                End If

            Else
                MessageBox.Show("Data not deleted", "DELETE DATA", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

            loadClientList()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnCreateLoan_Click(sender As Object, e As EventArgs) Handles btnCreateLoan.Click
        Try
            frmCreateLoan.lblID.Text = lblID.Text
            frmCreateLoan.Show()
            frmCreateLoan.selectedClient()
            Me.Close()

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

End Class