Imports MySql.Data.MySqlClient
Imports System.IO

Public Class frmCreateUpdateClient
    Private clientAccountClass As New clsClientAccount
    Private areaClass As New clsArea


    Private Sub frmCreateUpdateClient_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        areaClass.callAllArea(cboArea)
        AutoincrimentClientCode()
        selectClient()
    End Sub

    Private Sub btnUploadPicture_Click(sender As Object, e As EventArgs) Handles btnUploadPicture.Click
        clientAccountClass.ClientImageUpload(picClientProfile)
    End Sub

    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
        Try
            clientAccountClass.CreateClient(picClientProfile, lblClientCode.Text, userLoginName, userLoginDateTime, txtLastname.Text, txtFirstname.Text, txtMiddlename.Text, cboGender.SelectedItem, txtAge.Text, dtpBOD.Value, cboCivilstatus.SelectedItem, txtSpouse.Text, cboArea.SelectedItem, cboDescription.SelectedItem, txtMobilenumber.Text, txtEmailadd.Text, txtOccupation.Text, txtHomeaddress.Text, txtZipcode.Text, txtOfficeaddress.Text, txtTinIDNo.Text, cboBankAccountType.SelectedItem, txtBankAccountNumber.Text, cboValidIDType.SelectedItem, txtValidIDNumber.Text, cboATMType.SelectedItem, txtATMNumber.Text, txtComakerFullname.Text, txtComakerAddress.Text, txtComakerPhoneNumber.Text, txtComakerOccupation.Text)
            frmClientList.loadClientList()
        Catch ex As Exception
            MsgBox(ex.Message)

        Finally
            frmClientList.Show()
            Me.Close()
            DisconnMy()
        End Try

    End Sub



    Private Sub AutoincrimentClientCode()
        lblClientCode.Text = ""
        Try
            ConnDB()
            sqL = "SELECT MAX(client_code) FROM clientaccount"
            cmd = New MySqlCommand(sqL, conn)
            result = cmd.ExecuteScalar().ToString

            If String.IsNullOrEmpty(result) Then
                lblClientCode.Text = "CC-00001"


            End If
            result = result.Substring(3)
            Int32.TryParse(result, digit)
            digit = digit + 1
            result = "CC-" + digit.ToString("D5")
            lblClientCode.Text = result
        Catch ex As Exception
        Finally
            DisconnMy()
        End Try

    End Sub

    Private Sub dtpBOD_ValueChanged(sender As Object, e As EventArgs) Handles dtpBOD.ValueChanged
        Dim ts As TimeSpan = DateTime.Now.Date - dtpBOD.Value
        txtAge.Text = String.Format("{0:n0}", (ts.TotalDays / 365))
    End Sub


    Public Sub selectClient()
        Try
            ConnDB()
            sqL = "select * from clientaccount where clientID = '" & lblID.Text & "' "
            cmd = New MySqlCommand(sqL, conn)
            da = New MySqlDataAdapter(cmd)
            Dim myReader As MySqlDataReader
            myReader = cmd.ExecuteReader()
            If myReader.Read Then
                lblClientCode.Text = myReader("client_code")
                txtLastname.Text = myReader("last_name")
                txtFirstname.Text = myReader("first_name")
                txtMiddlename.Text = myReader("middle_name")
                cboGender.Text = myReader("gender")
                dtpBOD.Value = myReader("birth_date")
                txtAge.Text = myReader("age")
                cboCivilstatus.Text = myReader("civil_status")
                txtOccupation.Text = myReader("occupation")
                txtMobilenumber.Text = myReader("mobile_no")
                txtEmailadd.Text = myReader("email_add")
                txtHomeaddress.Text = myReader("home_add")
                txtZipcode.Text = myReader("zipcode")
                txtOfficeaddress.Text = myReader("office_add")
                txtTinIDNo.Text = myReader("tin_no")
                cboValidIDType.Text = myReader("valid_id_type")
                txtValidIDNumber.Text = myReader("valid_id_no")
                cboBankAccountType.Text = myReader("bank_account_type")
                txtBankAccountNumber.Text = myReader("bank_account_no")
                cboATMType.Text = myReader("atm_card_type")
                txtATMNumber.Text = myReader("atm_card_no")
                txtComakerFullname.Text = myReader("coFullName")
                txtComakerPhoneNumber.Text = myReader("coNumber")
                txtComakerAddress.Text = myReader("coAddress")
                txtComakerOccupation.Text = myReader("coOccupation")

                'cast the picture data as byte()

                data = DirectCast(myReader("profile_picture"), Byte())
                Dim ms As New MemoryStream(data)
                picClientProfile.Image = Image.FromStream(ms)


            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)

        End Try
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs)
        ConnDB()
        sqL = "SELECT * FROM clientaccount where clientID = '" & lblID.Text & "'"
        cmd = New MySqlCommand(sqL, conn)
        dr = cmd.ExecuteReader(CommandBehavior.CloseConnection)


        Try


            If frmMain.lblRole.Text = "Administrator" Then
                MessageBox.Show("Are you sure you want to delete this record?", "DELETE DATA", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                clientAccountClass.DeleteClient(lblID.Text)
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

            frmClientList.loadClientList()
            frmClientList.Show()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click

    End Sub

End Class