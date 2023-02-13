Public Class EditAccountDetails
    Public RoleID As Integer
    Public Username As String

    Private Sub EditAccountDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RoleID = EditAccounts.RoleID
        Username = EditAccounts.Username
        EditAccounts.Close()
        If RoleID = 0 Then
            lbl_RoleID.Text = "Role Access: User Account"
            access_User.Checked = True
        ElseIf RoleID = 1 Then
            lbl_RoleID.Text = "Role Access: Administrator Account"
            access_Administrator.Checked = True
        End If
        lbl_Username.Text = "Username: " + Username
        textbox_Username.Text = Username
        textbox_Password.Text = Database.QueryReturnString("SELECT DISTINCT Password FROM SystemAccounts WHERE Username='" + Username + "';")
        textbox_ConfirmPassword.Text = textbox_Password.Text
    End Sub



    Private Sub button_Submit_Click(sender As Object, e As EventArgs) Handles button_Submit.Click
        'Validation
        Dim ErrorString As String = ""
        Dim ErrorOccured As Boolean = False

        If access_Administrator.Checked = False And access_User.Checked = False Then
            ErrorOccured = True
            ErrorString = ErrorString + Environment.NewLine + "Error: NO ACCOUNT ACCESS LEVEL" + Environment.NewLine + "Please choose an access level for the account that will be created."
        End If
        If textbox_Username.Text = "" Then
            ErrorOccured = True
            ErrorString = ErrorString + Environment.NewLine + "Error: NO USERNAME INPUT" + Environment.NewLine + "Please provide the account username." + Environment.NewLine
        End If
        'Check if username Exists
        Dim AccountCount As Integer = Database.QueryReturnInteger("SELECT COUNT(*) FROM SystemAccounts WHERE Username='" + textbox_Username.Text + "';")
        If AccountCount = 1 Then 'The username exists!
            Dim GrabbedUsername As String = Database.QueryReturnString("SELECT DISTINCT Username FROM SystemAccounts WHERE Username='" + textbox_Username.Text + "';")
            If Username <> GrabbedUsername Then 'don't overwrite
                ErrorOccured = True 'issue an error
                ErrorString = ErrorString + Environment.NewLine + "Error: ACCOUNT USERNAME ALREADY EXISTS!" + Environment.NewLine + "Please provide another account username." + Environment.NewLine
            End If
        End If
        If textbox_Password.Text = "" Then
            ErrorOccured = True
            ErrorString = ErrorString + Environment.NewLine + "Error: NO PASSWORD INPUT" + Environment.NewLine + "Please provide the account password." + Environment.NewLine
        End If
        If textbox_ConfirmPassword.Text = "" Then
            ErrorOccured = True
            ErrorString = ErrorString + Environment.NewLine + "Error: NO CONFIRM PASSWORD INPUT" + Environment.NewLine + "Please type the account password again." + Environment.NewLine
        End If
        If textbox_Password.Text <> textbox_ConfirmPassword.Text Then
            ErrorOccured = True
            ErrorString = ErrorString + Environment.NewLine + "Error: PASSWORD DOESN'T MATCH!" + Environment.NewLine + "Please type the account password again." + Environment.NewLine
        End If
        If ErrorOccured Then
            ErrorMessage(ErrorString, "Error")
        Else
            Dim OldAccountDetails As New tAccountDetails
            OldAccountDetails.Username = Username
            OldAccountDetails.RoleID = RoleID
            OldAccountDetails.Password = Database.QueryReturnString("SELECT DISTINCT Password FROM SystemAccounts WHERE Username='" + Username + "';")
            Dim NewAccountDetails As New tAccountDetails
            NewAccountDetails.Username = textbox_Username.Text
            NewAccountDetails.Password = textbox_Password.Text
            Dim NewRoleID As Integer
            If access_Administrator.Checked Then
                NewRoleID = 1
            ElseIf access_User.Checked Then
                NewRoleID = 0
            End If
            NewAccountDetails.RoleID = NewRoleID
            Dim Updated As Boolean = False
            Dim UpdatedString As String = ""
            If OldAccountDetails.Username <> NewAccountDetails.Username Then
                'update the new username
                Database.Insert("UPDATE SystemAccounts SET Username='" + NewAccountDetails.Username + "' WHERE Username='" + OldAccountDetails.Username + "';", False)
                Updated = True
                UpdatedString = UpdatedString + Environment.NewLine + "Successfully Updated: " + OldAccountDetails.Username + " [Old] to " + NewAccountDetails.Username + " [New]" + Environment.NewLine
            End If
            If OldAccountDetails.Password <> NewAccountDetails.Password Then
                'update the new password
                'Database.Insert("UPDATE SystemAccounts SET Password='" + NewAccountDetails.Password + "' WHERE Username='" + NewAccountDetails.Username + "';", False)
                Database.Insert("UPDATE [SystemAccounts] SET [Password]='" + NewAccountDetails.Password + "' WHERE Username='" + NewAccountDetails.Username + "';", False)
                Updated = True
                UpdatedString = UpdatedString + Environment.NewLine + "Successfully Updated: " + OldAccountDetails.Password + " [Old] to " + NewAccountDetails.Password + " [New]" + Environment.NewLine
            End If
            If OldAccountDetails.RoleID <> NewAccountDetails.RoleID Then
                'update the role ID
                Database.Insert("UPDATE SystemAccounts SET RoleID=" + NewAccountDetails.RoleID.ToString + " WHERE Username='" + NewAccountDetails.Username + "';", False)
                Updated = True
                UpdatedString = UpdatedString + Environment.NewLine + "Successfully Updated: " + RoleIDConverter(OldAccountDetails.RoleID) + " [Old] to " + RoleIDConverter(NewAccountDetails.RoleID) + " [New]" + Environment.NewLine
            End If
            If Updated Then
                InformationMessage(UpdatedString, "Updated")
            End If
            Me.Hide()
            EditAccounts.Show()
            Me.Close()
        End If

    End Sub

    Private Sub cb_ShowPassword_CheckedChanged(sender As Object, e As EventArgs) Handles cb_ShowPassword.CheckedChanged
        If cb_ShowPassword.Checked Then
            textbox_Password.UseSystemPasswordChar = False
            textbox_ConfirmPassword.UseSystemPasswordChar = False
        Else
            textbox_Password.UseSystemPasswordChar = True
            textbox_ConfirmPassword.UseSystemPasswordChar = True
        End If
    End Sub
End Class