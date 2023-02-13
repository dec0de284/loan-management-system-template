Imports System.Text.RegularExpressions
Public Class UserAccountCreation

    Public newUserUsername As String = ""
    Public newUserPassword As String = ""

    Private Sub button_Submit_Click(sender As Object, e As EventArgs) Handles button_Submit.Click
        'Validation
        Dim ErrorString As String = ""
        Dim ErrorOccured As Boolean = False
        If Label9.ForeColor = Color.Red Then
            ErrorOccured = True
            ErrorString = ErrorString + Environment.NewLine + "Error: USERNAME MUST BE AT LEAST 4 CHARACTERS" + Environment.NewLine
        End If
        If Label8.ForeColor = Color.Red Then
            ErrorOccured = True
            ErrorString = ErrorString + Environment.NewLine + "Error: USERNAME MUST BE VALID" + Environment.NewLine
        End If
        If Label1.ForeColor = Color.Red Then
            ErrorOccured = True
            ErrorString = ErrorString + Environment.NewLine + "Error: ONE SPECIAL CHARACTER IS REQUIRED IN PASSWORD" + Environment.NewLine
        End If
        If Label4.ForeColor = Color.Red Then
            ErrorOccured = True
            ErrorString = ErrorString + Environment.NewLine + "Error: ONE UPPERCASE LETTER IS REQUIRED IN PASSWORD" + Environment.NewLine
        End If
        If Label2.ForeColor = Color.Red Then
            ErrorOccured = True
            ErrorString = ErrorString + Environment.NewLine + "Error: AT LEAST THREE NUMBERS ARE REQUIRED IN PASSWORD" + Environment.NewLine
        End If
        If Label3.ForeColor = Color.Red Then
            ErrorOccured = True
            ErrorString = ErrorString + Environment.NewLine + "Error: PASSWORD MUST BE AT LEAST 11 CHARACTERS" + Environment.NewLine
        End If
        If Label5.ForeColor = Color.Red Then
            ErrorOccured = True
            ErrorString = ErrorString + Environment.NewLine + "Error: PASSWORD DOESN'T MATCH" + Environment.NewLine
        End If
        If ErrorOccured And ErrorString <> "" Then
            ErrorMessage(ErrorString, "Error")
        Else

            Dim confirmationMessage As String = "IMPORTANT REMINDERS:" + Environment.NewLine + Environment.NewLine + "-PLEASE TAKE DOWN NOTES OF YOUR USERNAME AND PASSWORD ON YOUR PERSONAL NOTEBOOK AND KEEP IT SAFE FROM OTHERS." + Environment.NewLine + Environment.NewLine + "-CREATING AN ADMIN ACCOUNT OCCURS ONLY ONCE. PLEASE DOUBLE CHECK YOUR ENTRIES." + Environment.NewLine + Environment.NewLine + "Are you sure that these are correct?" + Environment.NewLine + "Username: " + textbox_Username.Text + Environment.NewLine

            If MessageBox.Show(confirmationMessage, "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                newUserUsername = textbox_Username.Text
                newUserPassword = textbox_ConfirmPassword.Text
                Me.Hide()
                If MessageBox.Show("The next setup is the setting of Security Questions for the User Account." + Environment.NewLine + Environment.NewLine + "IMPORTANT REMINDERS:" + Environment.NewLine + "- CHECK IF SOMEONE IS BEHIND YOU LOOKING AT YOUR SCREEN." + Environment.NewLine + "- DON'T ALLOW ANYONE SAW YOU TYPING THE ANSWERS." + Environment.NewLine + "- PLEASE TAKE DOWN NOTES OF THE QUESTIONS AND ANSWERS ON YOUR PERSONAL NOTEBOOK AND KEEP IT SAFE FROM OTHERS." + Environment.NewLine + Environment.NewLine + "Press OK when ready.", "Next Step", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) = DialogResult.Cancel Then
                    If MessageBox.Show("Are you want to cancel the first time setup?" + Environment.NewLine + "Unsaved changes will be lost.", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                        SplashScreen.Close()
                    Else
                        Me.Show()
                    End If
                Else
                    UserAccountSecurityQuestions.Show()
                End If
            End If



            'Dim RoleID As Integer
            'If access_Administrator.Checked Then
            '    RoleID = 1
            'ElseIf access_User.Checked Then
            '    RoleID = 0
            'End If
            'Database.Insert("INSERT INTO SystemAccounts ([RoleID], [Username], [Password]) VALUES('" + RoleID.ToString + "','" + textbox_Username.Text + "','" + textbox_Password.Text + "');", True)
            'Dim tTable As New DataTable
            'tTable.Columns.Add("Role", GetType(String))
            'tTable.Columns.Add("Username", GetType(String))
            'tTable.Columns.Add("Password", GetType(String))
            'tTable.Rows.Add(RoleIDConverter(RoleID), textbox_Username.Text, textbox_Password.Text)
            'ShowReportForm(tTable)
            'Me.Close()
        End If

    End Sub

    Private Sub textbox_Username_TextChanged(sender As Object, e As EventArgs) Handles textbox_Username.TextChanged
        Dim invalid As Regex = New Regex("\W")
        If invalid.IsMatch(textbox_Username.Text) Or textbox_Username.Text = "" Then
            Label8.Text = "[✗ ] invalid"
            Label8.ForeColor = Color.Red
        Else
            Label8.Text = "[✓ ] valid"
            Label8.ForeColor = Color.Green
        End If

        If textbox_Username.TextLength > 3 Then
            Label9.Text = "[✓ ] at least 4 characters"
            Label9.ForeColor = Color.Green
        Else
            Label9.Text = "[✗ ] at least 4 characters"
            Label9.ForeColor = Color.Red
        End If
    End Sub

    'Private Sub cb_ShowPassword_CheckedChanged(sender As Object, e As EventArgs)
    '    If cb_ShowPassword.Checked Then
    '        textbox_Password.UseSystemPasswordChar = False
    '        textbox_ConfirmPassword.UseSystemPasswordChar = False
    '    Else
    '        textbox_Password.UseSystemPasswordChar = True
    '        textbox_ConfirmPassword.UseSystemPasswordChar = True
    '    End If
    'End Sub


    Private Sub FirstTimeSetupAdminAccount_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If MessageBox.Show("Are you want to cancel the first time setup?" + Environment.NewLine + "Unsaved changes will be lost.", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
            e.Cancel = True
        Else
            Me.Hide()
            SplashScreen.Close()
        End If

    End Sub

    Private Sub textbox_Password_TextChanged(sender As Object, e As EventArgs) Handles textbox_Password.TextChanged
        Dim specialCharacter As Regex = New Regex("[!@#$%^&*]")
        Dim upperCaseLetter As Regex = New Regex("[A-Z]")
        Dim threeNumbers As Regex = New Regex("\d")
        'One Special Character
        If (specialCharacter.IsMatch(textbox_Password.Text)) Then
            Label1.Text = "[✓ ] one special character"
            Label1.ForeColor = Color.Green
        Else
            Label1.Text = "[✗ ] one special character"
            Label1.ForeColor = Color.Red
        End If
        'One Uppercase
        If (upperCaseLetter.IsMatch(textbox_Password.Text)) Then
            Label4.Text = "[✓ ] one uppercase letter"
            Label4.ForeColor = Color.Green
        Else
            Label4.Text = "[✗ ] one uppercase letter"
            Label4.ForeColor = Color.Red
        End If
        'Three Numbers
        If threeNumbers.Matches(textbox_Password.Text).Count > 2 Then
            Label2.Text = "[✓ ] at least three numbers"
            Label2.ForeColor = Color.Green
        Else
            Label2.Text = "[✗ ] at least three numbers"
            Label2.ForeColor = Color.Red
        End If
        '11 Characters
        If textbox_Password.TextLength > 10 Then
            Label3.Text = "[✓ ] at least 11 characters"
            Label3.ForeColor = Color.Green
        Else
            Label3.Text = "[✗ ] at least 11 characters"
            Label3.ForeColor = Color.Red
        End If
    End Sub

    Private Sub textbox_ConfirmPassword_TextChanged(sender As Object, e As EventArgs) Handles textbox_ConfirmPassword.TextChanged
        If textbox_Password.Text = textbox_ConfirmPassword.Text Then
            Label5.Text = "[✓ ] password doesn't match"
            Label5.ForeColor = Color.Green
        Else
            Label5.Text = "[✗ ] password doesn't match"
            Label5.ForeColor = Color.Red
        End If
    End Sub


End Class