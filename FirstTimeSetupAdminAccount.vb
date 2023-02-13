Imports System.Text.RegularExpressions
Public Class FirstTimeSetupAdminAccount

    Public newAdminUsername As String = ""
    Public newAdminPassword As String = ""
    Public newSystemOverduePenalty As Decimal = CDec(0)

    Private Sub button_Submit_Click(sender As Object, e As EventArgs) Handles button_Submit.Click
        'Validation
        Dim ErrorString As String = ""
        Dim ErrorOccured As Boolean = False
        If CheckBox1.Checked Then
            Try
                If TextBox1.Text = "" Then
                    ErrorString = ErrorString + Environment.NewLine + "Error: PENALTY PERCENTAGE CANNOT BE EMPTY" + Environment.NewLine
                Else
                    Dim percentage As Decimal = CDec(TextBox1.Text)
                    If percentage = CDec(0) Then
                        If MessageBox.Show("Penalty Percentage can't ba zero." + Environment.NewLine + "Do you want to disable Loan Overdue Penalty instead?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                            TextBox1.Text = ""
                            CheckBox1.Checked = False
                        End If
                    ElseIf percentage > CDec(100) Then
                        ErrorString = ErrorString + Environment.NewLine + "Error: PENALTY PERCENTAGE IS GREATER THAN 100%" + Environment.NewLine
                    End If
                End If
                ErrorOccured = True
            Catch ex As Exception
                ErrorMessage(ex.ToString, "Error")
            End Try
        End If
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
            Dim loanOverduePenaltyStatus As String = ""
            If CheckBox1.Checked Then
                Try
                    loanOverduePenaltyStatus = "Enabled" + Environment.NewLine + "Penalty Percentage: " + CDec(TextBox1.Text).ToString("N2") + "%"
                Catch ex As Exception
                    ErrorMessage("Unexpected error. Please contact System Administrator", "Error")
                End Try
            Else
                loanOverduePenaltyStatus = "Disabled"
            End If
            Dim confirmationMessage As String = "IMPORTANT REMINDERS:" + Environment.NewLine + Environment.NewLine + "-PLEASE TAKE DOWN NOTES OF YOUR USERNAME AND PASSWORD ON YOUR PERSONAL NOTEBOOK AND KEEP IT SAFE FROM OTHERS." + Environment.NewLine + Environment.NewLine + "-CREATING AN ADMIN ACCOUNT OCCURS ONLY ONCE. PLEASE DOUBLE CHECK YOUR ENTRIES." + Environment.NewLine + Environment.NewLine + "Are you sure that these are correct?" + Environment.NewLine + "Username: " + textbox_Username.Text + Environment.NewLine + "Loan Overdue Penalty Status: " + loanOverduePenaltyStatus + Environment.NewLine

            If MessageBox.Show(confirmationMessage, "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                newAdminUsername = textbox_Username.Text
                newAdminPassword = textbox_ConfirmPassword.Text
                If CheckBox1.Checked Then
                    Try
                        newSystemOverduePenalty = CDec(TextBox1.Text)
                    Catch ex As Exception
                        ErrorMessage("Unexpected error. Please contact System Administrator", "Error")
                    End Try
                End If
                Me.Hide()
                If MessageBox.Show("The next setup is the setting of Security Questions for your Admin Account." + Environment.NewLine + Environment.NewLine + "IMPORTANT REMINDERS:" + Environment.NewLine + "- CHECK IF SOMEONE IS BEHIND YOU LOOKING AT YOUR SCREEN." + Environment.NewLine + "- DON'T ALLOW ANYONE SAW YOU TYPING THE ANSWERS." + Environment.NewLine + "- PLEASE TAKE DOWN NOTES OF THE QUESTIONS AND ANSWERS ON YOUR PERSONAL NOTEBOOK AND KEEP IT SAFE FROM OTHERS." + Environment.NewLine + Environment.NewLine + "Press OK when ready.", "Next Step", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) = DialogResult.Cancel Then
                    If MessageBox.Show("Are you want to cancel the first time setup?" + Environment.NewLine + "Unsaved changes will be lost.", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                        SplashScreen.Close()
                    Else
                        Me.Show()
                    End If
                Else
                    FirstTimeSetupAdminAccountRecovery.Show()
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

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If (CheckBox1.Checked) Then
            TextBox1.Text = ""
            GroupBox2.Enabled = True
            CheckBox1.Text = "Disable Loan Overdue Penalty"
        Else
            TextBox1.Text = ""
            GroupBox2.Enabled = False
            CheckBox1.Text = "Enable Loan Overdue Penalty"
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

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso Not e.KeyChar = "." Then
            e.Handled = True
        End If
        If (TextBox1.Text.IndexOf(".") >= 0 And e.KeyChar = ".") Then e.Handled = True
    End Sub
End Class