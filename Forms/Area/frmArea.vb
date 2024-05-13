Imports MySql.Data.MySqlClient

Public Class frmArea
    Private ClassArea As New clsArea
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Try
            ConnDB()

            sqL = "Update area Set  areaName=@areaName WHERE areaID = '" & lblID.Text.Trim & "'"

            cmd = New MySqlCommand(sqL, conn)

            cmd.Parameters.AddWithValue("@areaName", txtArea.Text.Trim.ToUpper)

            cmd.ExecuteNonQuery()
            MessageBox.Show("Area updated successfully", "UPDATED", MessageBoxButtons.OK, MessageBoxIcon.Information)
            loadArea()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            DisconnMy()
        End Try
    End Sub

    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
        Try
            ConnDB()

            sqL = "SELECT * FROM area WHERE areaName=@name "
            cmd = New MySqlCommand(sqL, conn)
            cmd.Parameters.AddWithValue("@name", txtArea.Text)
            dr = cmd.ExecuteReader

            If (dr.HasRows) Then
                MessageBox.Show("Area name already exist", "EXIST", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else
                ClassArea.AddArea(txtArea.Text.ToUpper)
                MessageBox.Show("Area has been saved", "SAVED", MessageBoxButtons.OK, MessageBoxIcon.Information)
                loadArea()
            End If


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            DisconnMy()
        End Try
    End Sub


    Public Sub loadArea()
        Try
            ConnDB()
            sqL = "Select areaID,areaName  From area"
            cmd = New MySqlCommand(sqL, conn)
            da = New MySqlDataAdapter(cmd)
            Dim ds As DataSet = New DataSet()

            da.Fill(ds, sqL)
            dtgvArea.DataSource = ds
            dtgvArea.DataMember = sqL

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            DisconnMy()
        End Try
    End Sub

    Private Sub frmArea_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadArea()
    End Sub

    Private Sub dtgvArea_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgvArea.CellContentClick
        lblID.Text = dtgvArea(0, dtgvArea.CurrentRow.Index).Value
        selectArea()
    End Sub


    Public Sub selectArea()
        Try
            ConnDB()
            sqL = "select * from area where areaID = '" & lblID.Text & "' "
            cmd = New MySqlCommand(sqL, conn)
            da = New MySqlDataAdapter(cmd)
            Dim myReader As MySqlDataReader
            myReader = cmd.ExecuteReader()
            If myReader.Read Then
                txtArea.Text = myReader("areaName")
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)

        End Try
    End Sub

    Private Sub lblDelete_Click(sender As Object, e As EventArgs) Handles lblDelete.Click
        Try
            ConnDB()

            sqL = "DELETE FROM area WHERE areaID = '" & lblID.Text.Trim & "'"
            cmd = New MySqlCommand(sqL, conn)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Area Deleted successfully", "DELETED", MessageBoxButtons.OK, MessageBoxIcon.Information)
            loadArea()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            DisconnMy()
        End Try
    End Sub

    Private Sub txtSearchArea_TextChanged(sender As Object, e As EventArgs) Handles txtSearchArea.TextChanged
        Try
            ConnDB()
            Dim cmd As New MySqlCommand("Select areaID,areaName From area Where areaName like Concat('%',@parm1,'%')", conn)
            cmd.Parameters.AddWithValue("parm1", txtSearchArea.Text)
            da = New MySqlDataAdapter(cmd)
            Dim ds As DataSet = New DataSet()

            da.Fill(ds, sqL)
            dtgvArea.DataSource = ds
            dtgvArea.DataMember = sqL

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            DisconnMy()
        End Try
    End Sub

    Private Sub dtgvArea_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgvArea.CellContentDoubleClick
        lblID.Text = dtgvArea(0, dtgvArea.CurrentRow.Index).Value
        selectArea()
    End Sub
End Class