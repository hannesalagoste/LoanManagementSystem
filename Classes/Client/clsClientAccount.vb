Imports MySql.Data.MySqlClient

Public Class clsClientAccount

    Dim arrImage() As Byte


    'UPLOAD IMAGES

    Public Sub ClientImageUpload(ByVal pic As PictureBox)
        Dim openFileDialog As New OpenFileDialog
        'openFileDialog.InitialDirectory = "C:\Pictures"
        openFileDialog.Filter = "Image Files|*.gif;*.jpg;*.png;*.bmp"
        openFileDialog.Title = "Select an Image File"
        openFileDialog.ShowDialog()
        If openFileDialog.FileName <> "" Then
            pic.Image = Image.FromFile(openFileDialog.FileName)
        End If
    End Sub


    'CREATE CLIENT

    Public Sub CreateClient(ClientPhoto As PictureBox, ClientCode As String, ClientAddedBy As String, ClientCreatedDate As Date, ClientLname As String, ClientFname As String, ClientMname As String, ClientGender As String, ClientAge As Integer, ClientDOB As Date, ClientCivilStatus As String, ClientSpouse As String, ClientArea As String, ClientDescription As String, ClientMobileNumber As String, ClientEmailAddress As String, ClientOccupation As String, ClientHomeAddress As String, ClientZipCode As String, ClientOfficeAddress As String, ClientTINID As String, ClientBankAccountType As String, ClientBankAccountNo As String, ClientValidIdType As String, ClientValidIdNo As String, ClientATMType As String, ClientATMNo As String, ComakerFullname As String, ComakerAddress As String, ComakerNumber As String, ComakerOccupation As String)

        Try

            Dim mstream As New System.IO.MemoryStream()
            ClientPhoto.Image.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg)
            arrImage = mstream.GetBuffer()
            Dim FileSize As UInt32
            FileSize = mstream.Length
            mstream.Close()




            sqL = "INSERT INTO clientaccount(profile_picture,client_code,created_by,createdDate,spouse,area,description, " &
                                        "last_name, first_name, middle_name, " &
                                        "gender, age, birth_date, civil_status, " &
                                        "mobile_no,email_add, occupation,home_add, zipcode, office_add," &
                                        "tin_no, bank_account_type, bank_account_no, valid_id_type,valid_id_no, atm_card_type, atm_card_no, " &
                                        "coFullName, coAddress, coNumber, coOccupation) " &
                                        "VALUES(@profile_picture,@client_code,@created_by,@createdDate,@spouse,@area,@description, " &
                                        "@last_name, @first_name, @middle_name, " &
                                        "@gender, @age, @birth_date, @civil_status, " &
                                        "@mobile_no,@email_add, @occupation, @home_add, @zipcode, @office_add," &
                                        "@tin_no, @bank_account_type, @bank_account_no, @valid_id_type, @valid_id_no, @atm_card_type, @atm_card_no, " &
                                        "@coFullName, @coAddress, @coNumber, @coOccupation)"


            ConnDB()
            cmd = New MySqlCommand(sqL, conn)

            With cmd
                .Parameters.AddWithValue("@profile_picture", arrImage)
                .Parameters.AddWithValue("@client_code", ClientCode)
                .Parameters.AddWithValue("@created_by", ClientAddedBy)
                .Parameters.AddWithValue("@createdDate", ClientCreatedDate)
                .Parameters.AddWithValue("@spouse", ClientSpouse)
                .Parameters.AddWithValue("@area", ClientArea)
                .Parameters.AddWithValue("@description", ClientDescription)
                .Parameters.AddWithValue("@last_name", ClientLname)
                .Parameters.AddWithValue("@first_name", ClientFname)
                .Parameters.AddWithValue("@middle_name", ClientMname)
                .Parameters.AddWithValue("@gender", ClientGender)
                .Parameters.AddWithValue("@age", ClientAge)
                .Parameters.AddWithValue("@birth_date", ClientDOB)
                .Parameters.AddWithValue("@civil_status", ClientCivilStatus)
                .Parameters.AddWithValue("@mobile_no", ClientMobileNumber)
                .Parameters.AddWithValue("@email_add", ClientEmailAddress)
                .Parameters.AddWithValue("@occupation", ClientOccupation)
                .Parameters.AddWithValue("@home_add", ClientHomeAddress)
                .Parameters.AddWithValue("@zipcode", ClientZipCode)
                .Parameters.AddWithValue("@office_add", ClientOfficeAddress)
                .Parameters.AddWithValue("@tin_no", ClientTINID)
                .Parameters.AddWithValue("@bank_account_type", ClientBankAccountType)
                .Parameters.AddWithValue("@bank_account_no", ClientBankAccountNo)
                .Parameters.AddWithValue("@valid_id_type", ClientValidIdType)
                .Parameters.AddWithValue("@valid_id_no", ClientValidIdNo)
                .Parameters.AddWithValue("@atm_card_type", ClientATMType)
                .Parameters.AddWithValue("@atm_card_no", ClientATMNo)
                .Parameters.AddWithValue("@coFullName", ComakerFullname)
                .Parameters.AddWithValue("@coAddress", ComakerAddress)
                .Parameters.AddWithValue("@coNumber", ComakerNumber)
                .Parameters.AddWithValue("@coOccupation", ComakerOccupation)
            End With


            Dim i As Integer
            i = cmd.ExecuteNonQuery
            If i > 0 Then
                MsgBox(ClientLname + " " + "Acccount created successfully..", MsgBoxStyle.Information, "SAVED")
            End If

        Catch ex As Exception
            MsgBox(ex.Message)

        Finally

            conn.Close()
        End Try

    End Sub

    Public Sub DeleteClient(id As String)

        Try
            ConnDB()
            sqL = "DELETE FROM clientaccount WHERE clientID ='" & id.Trim & "'"
            cmd = New MySql.Data.MySqlClient.MySqlCommand(sqL, conn)
            cmd.ExecuteNonQuery()
            MsgBox("Client successfully Deleted", MsgBoxStyle.Information)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        Finally
            DisconnMy()
        End Try
    End Sub
End Class
