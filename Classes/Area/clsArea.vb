Imports MySql.Data.MySqlClient

Public Class clsArea
    Public Sub AddArea(AreaName As String)

        Try
            ConnDB()
            sqL = "INSERT INTO area (areaName) " &
                            "VALUES(@areaName)"

            cmd = New MySqlCommand(sqL, conn)

            cmd.Parameters.AddWithValue("@areaName", AreaName.Trim)

            cmd.ExecuteNonQuery()
            'MessageBox.Show("Area created successfully", "SAVED", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            DisconnMy()
        End Try
    End Sub
    'SELECT AREA
    Public Sub callAllArea(com As ComboBox)

        Try
            ConnDB()
            sqL = "SELECT areaName FROM area"
            cmd = New MySql.Data.MySqlClient.MySqlCommand(sqL, conn)
            dr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
            While dr.Read()
                com.Items.Add(dr("areaName"))

            End While

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            DisconnMy()

        End Try
    End Sub
End Class
