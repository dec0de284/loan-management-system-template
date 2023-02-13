Public Class form_CreateAccount

    Private Sub button_Submit_Click(sender As Object, e As EventArgs) Handles button_Submit.Click
        'Validation
        Dim ErrorString As String = ""
        Dim ErrorOccured As Boolean = False

        'If access_Administrator.Checked = False And access_User.Checked = False Then
        '    ErrorOccured = True
        '    ErrorString = ErrorString + Environment.NewLine + "Error: NO ACCOUNT ACCESS LEVEL" + Environment.NewLine + "Please choose an access level for the account that will be created."
        'End If
        'If textbox_Username.Text = "" Then
        '    ErrorOccured = True
        '    ErrorString = ErrorString + Environment.NewLine + "Error: NO USERNAME INPUT" + Environment.NewLine + "Please provide the account username." + Environment.NewLine
        'End If
        ''Check if username Exists
        'Dim AccountCount As String = Database.QueryReturnString("SELECT COUNT(*) FROM SystemAccounts WHERE Username='" + textbox_Username.Text + "';")
        'If AccountCount = "1" Then
        '    ErrorOccured = True
        '    ErrorString = ErrorString + Environment.NewLine + "Error: USERNAME INPUT ALREADY EXISTS!" + Environment.NewLine + "Please provide another account username." + Environment.NewLine
        'End If
        'If textbox_Password.Text = "" Then
        '    ErrorOccured = True
        '    ErrorString = ErrorString + Environment.NewLine + "Error: NO PASSWORD INPUT" + Environment.NewLine + "Please provide the account password." + Environment.NewLine
        'End If
        'If textbox_ConfirmPassword.Text = "" Then
        '    ErrorOccured = True
        '    ErrorString = ErrorString + Environment.NewLine + "Error: NO CONFIRM PASSWORD INPUT" + Environment.NewLine + "Please type the account password again." + Environment.NewLine
        'End If
        'If textbox_Password.Text <> textbox_ConfirmPassword.Text Then
        '    ErrorOccured = True
        '    ErrorString = ErrorString + Environment.NewLine + "Error: PASSWORD DOESN'T MATCH!" + Environment.NewLine + "Please type the account password again." + Environment.NewLine
        'End If
        'If ErrorOccured Then
        '    ErrorMessage(ErrorString, "Error")
        'Else
        '    Dim RoleID As Integer
        '    If access_Administrator.Checked Then
        '        RoleID = 1
        '    ElseIf access_User.Checked Then
        '        RoleID = 0
        '    End If
        '    Database.Insert("INSERT INTO SystemAccounts ([RoleID], [Username], [Password]) VALUES('" + RoleID.ToString + "','" + textbox_Username.Text + "','" + textbox_Password.Text + "');", True)
        '    Dim tTable As New DataTable
        '    tTable.Columns.Add("Role", GetType(String))
        '    tTable.Columns.Add("Username", GetType(String))
        '    tTable.Columns.Add("Password", GetType(String))
        '    tTable.Rows.Add(RoleIDConverter(RoleID), textbox_Username.Text, textbox_Password.Text)
        '    ShowReportForm(tTable)
        '    Me.Close()
        'End If

    End Sub

    Private Sub textbox_Username_TextChanged(sender As Object, e As EventArgs) Handles textbox_Username.TextChanged
        RegexBoxTextChanged(textbox_Username, "[^\w]")
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

    Private Sub textbox_Password_TextChanged(sender As Object, e As EventArgs) Handles textbox_Password.TextChanged
        RegexBoxTextChanged(textbox_Password, "[\/\\'""\[\] ]")
    End Sub

    Private Sub textbox_ConfirmPassword_TextChanged(sender As Object, e As EventArgs) Handles textbox_ConfirmPassword.TextChanged
        RegexBoxTextChanged(textbox_ConfirmPassword, "[\/\\'""\[\] ]")
    End Sub
End Class