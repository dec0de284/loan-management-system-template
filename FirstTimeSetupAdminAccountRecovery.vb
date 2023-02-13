Imports System.Text.RegularExpressions
Public Class FirstTimeSetupAdminAccountRecovery

    Public newAdminUsername As String = ""
    Public newAdminPassword As String = ""
    Public newSystemOverduePenalty As Decimal = CDec(0)
    Public pressedButton As Integer
    Public SelectedQuestions(2) As String

    Private Sub button_Submit_Click(sender As Object, e As EventArgs) Handles button_Submit.Click
        'Validation
        Dim ErrorString As String = ""
        Dim ErrorOccured As Boolean = False
        If TextBox1.Text = "" Then
            ErrorOccured = True
            ErrorString = ErrorString + Environment.NewLine + "Error: NO SELECTED SECURITY QUESION 1" + Environment.NewLine
        End If
        If TextBox2.Text = "" Then
            ErrorOccured = True
            ErrorString = ErrorString + Environment.NewLine + "Error: NO ANSWER IN SECURITY QUESION 1" + Environment.NewLine
        End If
        If TextBox4.Text = "" Then
            ErrorOccured = True
            ErrorString = ErrorString + Environment.NewLine + "Error: NO SELECTED SECURITY QUESION 2" + Environment.NewLine
        End If
        If TextBox3.Text = "" Then
            ErrorOccured = True
            ErrorString = ErrorString + Environment.NewLine + "Error: NO ANSWER IN SECURITY QUESION 2" + Environment.NewLine
        End If
        If TextBox6.Text = "" Then
            ErrorOccured = True
            ErrorString = ErrorString + Environment.NewLine + "Error: NO SELECTED SECURITY QUESION 3" + Environment.NewLine
        End If
        If TextBox5.Text = "" Then
            ErrorOccured = True
            ErrorString = ErrorString + Environment.NewLine + "Error: NO ANSWER IN SECURITY QUESION 3" + Environment.NewLine
        End If
        If ErrorOccured And ErrorString <> "" Then
            ErrorMessage(ErrorString, "Error")
        Else
            Try
                Dim AccountID As Integer
                If Database.Count("SELECT COUNT([AccountID]) FROM [dtb_SystemAccounts];") = 0 Then
                    AccountID = 0
                Else
                    Database.ReturnLastID("AccountID", "dtb_SystemAccounts")
                End If
                Database.Insert("INSERT INTO [dtb_SystemAccounts] ([AccountID],[RoleID],[Username],[Password],[Active],[DateCreated],[CreatedBy],[QID1],[A1],[QID2],[A2],[QID3],[A3]) VALUES(" + (AccountID + 1).ToString + ",'1','" + FirstTimeSetupAdminAccount.newAdminUsername + "','" + FirstTimeSetupAdminAccount.newAdminPassword + "', '1','" + Date.Now.ToString() + "','System','" + SelectedQuestions(0) + "','" + TextBox2.Text + "','" + SelectedQuestions(1) + "','" + TextBox3.Text + "','" + SelectedQuestions(2) + "','" + TextBox5.Text + "');", True)
                Dim LogID As Integer
                If Database.Count("SELECT COUNT([LogID]) FROM [dtb_AuditLog];") = 0 Then
                    LogID = 0
                Else
                    LogID = Database.ReturnLastID("LogID", "dtb_AuditLog")
                End If


                Database.Insert("INSERT INTO [dtb_AuditLog] ([LogID], [ActionBy], [Action], [ActionDate], [ActionState], [ActionLevel]) VALUES(" + (LogID + 1).ToString + ",'System','Create Admin Account','" + Date.Now.ToString() + "','Success','Information');", False)
                Me.Hide()
                MainForm.Show()
            Catch ex As Exception
                ErrorMessage("Unexpected error. Please contact System Administrator", "Error")
            End Try
            '    Dim loanOverduePenaltyStatus As String = ""
            '    If CheckBox1.Checked Then
            '        Try
            '            loanOverduePenaltyStatus = "Enabled" + Environment.NewLine + "Penalty Percentage: " + CDec(TextBox1.Text).ToString("N2") + "%"
            '        Catch ex As Exception
            '            ErrorMessage("Unexpected error. Please contact System Administrator", "Error")
            '        End Try
            '    Else
            '        loanOverduePenaltyStatus = "Disabled"
            '    End If
            '    Dim confirmationMessage As String = "IMPORTANT REMINDERS:" + Environment.NewLine + Environment.NewLine + "-PLEASE TAKE DOWN NOTES OF YOUR USERNAME AND PASSWORD ON YOUR PERSONAL NOTEBOOK AND KEEP IT SAFE FROM OTHERS." + Environment.NewLine + Environment.NewLine + "-CREATING AN ADMIN ACCOUNT OCCURS ONLY ONCE. PLEASE DOUBLE CHECK YOUR ENTRIES." + Environment.NewLine + Environment.NewLine + "Are you sure that these are correct?" + Environment.NewLine + "Username: " + textbox_Username.Text + Environment.NewLine + "Loan Overdue Penalty Status: " + loanOverduePenaltyStatus + Environment.NewLine

            '    If MessageBox.Show(confirmationMessage, "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            '        newAdminUsername = textbox_Username.Text
            '        newAdminPassword = textbox_ConfirmPassword.Text
            '        If CheckBox1.Checked Then
            '            Try
            '                newSystemOverduePenalty = CDec(TextBox1.Text)
            '            Catch ex As Exception
            '                ErrorMessage("Unexpected error. Please contact System Administrator", "Error")
            '            End Try
            '        End If
            '    End If



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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        pressedButton = 0
        SecurityQuestionSelect.Show()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        pressedButton = 1
        SecurityQuestionSelect.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        pressedButton = 2
        SecurityQuestionSelect.Show()
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            If MessageBox.Show("IMPORTANT REMINDERS:" + Environment.NewLine + "- CHECK IF SOMEONE IS BEHIND YOU LOOKING AT YOUR SCREEN." + Environment.NewLine + "- DON'T ALLOW ANYONE SAW YOU TYPING THE ANSWERS." + Environment.NewLine + "-PLEASE TAKE DOWN NOTES OF THE QUESTIONS AND ANSWERS ON YOUR PERSONAL NOTEBOOK AND KEEP IT SAFE FROM OTHERS." + Environment.NewLine + Environment.NewLine + "Press OK when ready.", "Reminder", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) = DialogResult.OK Then
                TextBox2.UseSystemPasswordChar = False
            Else
                CheckBox1.Checked = False
            End If
        Else
            TextBox2.UseSystemPasswordChar = True
        End If

    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked Then
            If MessageBox.Show("IMPORTANT REMINDERS:" + Environment.NewLine + "- CHECK IF SOMEONE IS BEHIND YOU LOOKING AT YOUR SCREEN." + Environment.NewLine + "- DON'T ALLOW ANYONE SAW YOU TYPING THE ANSWERS." + Environment.NewLine + "-PLEASE TAKE DOWN NOTES OF THE QUESTIONS AND ANSWERS ON YOUR PERSONAL NOTEBOOK AND KEEP IT SAFE FROM OTHERS." + Environment.NewLine + Environment.NewLine + "Press OK when ready.", "Reminder", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) = DialogResult.OK Then
                TextBox3.UseSystemPasswordChar = False
            Else
                CheckBox2.Checked = False
            End If

        Else
            TextBox3.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged
        If CheckBox3.Checked Then
            If MessageBox.Show("IMPORTANT REMINDERS:" + Environment.NewLine + "- CHECK IF SOMEONE IS BEHIND YOU LOOKING AT YOUR SCREEN." + Environment.NewLine + "- DON'T ALLOW ANYONE SAW YOU TYPING THE ANSWERS." + Environment.NewLine + "- PLEASE TAKE DOWN NOTES OF THE QUESTIONS AND ANSWERS ON YOUR PERSONAL NOTEBOOK AND KEEP IT SAFE FROM OTHERS." + Environment.NewLine + Environment.NewLine + "Press OK when ready.", "Reminder", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) = DialogResult.OK Then
                TextBox5.UseSystemPasswordChar = False
            Else
                CheckBox3.Checked = False
            End If

        Else
            TextBox5.UseSystemPasswordChar = True
        End If
    End Sub

    'Private Sub textbox_Username_TextChanged(sender As Object, e As EventArgs)
    '    'Dim invalid As Regex = New Regex("\W")
    '    'If invalid.IsMatch(textbox_Username.Text) Or textbox_Username.Text = "" Then
    '    '    Label8.Text = "[✗ ] invalid"
    '    '    Label8.ForeColor = Color.Red
    '    'Else
    '    '    Label8.Text = "[✓ ] valid"
    '    '    Label8.ForeColor = Color.Green
    '    'End If

    '    'If textbox_Username.TextLength > 3 Then
    '    '    Label9.Text = "[✓ ] at least 4 characters"
    '    '    Label9.ForeColor = Color.Green
    '    'Else
    '    '    Label9.Text = "[✗ ] at least 4 characters"
    '    '    Label9.ForeColor = Color.Red
    '    'End If
    'End Sub

    'Private Sub cb_ShowPassword_CheckedChanged(sender As Object, e As EventArgs)
    '    If cb_ShowPassword.Checked Then
    '        textbox_Password.UseSystemPasswordChar = False
    '        textbox_ConfirmPassword.UseSystemPasswordChar = False
    '    Else
    '        textbox_Password.UseSystemPasswordChar = True
    '        textbox_ConfirmPassword.UseSystemPasswordChar = True
    '    End If
    'End Sub


    'Private Sub FirstTimeSetupAdminAccount_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
    '    If MessageBox.Show("Are you want to cancel the first time setup?" + Environment.NewLine + "Unsaved changes will be lost.", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
    '        e.Cancel = True
    '    Else
    '        Me.Hide()
    '        SplashScreen.Close()
    '    End If

    'End Sub

    'Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs)
    '    If (CheckBox1.Checked) Then
    '        TextBox1.Text = ""
    '        GroupBox2.Enabled = True
    '        CheckBox1.Text = "Disable Loan Overdue Penalty"
    '    Else
    '        TextBox1.Text = ""
    '        GroupBox2.Enabled = False
    '        CheckBox1.Text = "Enable Loan Overdue Penalty"
    '    End If
    'End Sub

    'Private Sub textbox_Password_TextChanged(sender As Object, e As EventArgs)
    '    Dim specialCharacter As Regex = New Regex("[!@#$%^&*]")
    '    Dim upperCaseLetter As Regex = New Regex("[A-Z]")
    '    Dim threeNumbers As Regex = New Regex("\d")
    '    'One Special Character
    '    If (specialCharacter.IsMatch(textbox_Password.Text)) Then
    '        Label1.Text = "[✓ ] one special character"
    '        Label1.ForeColor = Color.Green
    '    Else
    '        Label1.Text = "[✗ ] one special character"
    '        Label1.ForeColor = Color.Red
    '    End If
    '    'One Uppercase
    '    If (upperCaseLetter.IsMatch(textbox_Password.Text)) Then
    '        Label4.Text = "[✓ ] one uppercase letter"
    '        Label4.ForeColor = Color.Green
    '    Else
    '        Label4.Text = "[✗ ] one uppercase letter"
    '        Label4.ForeColor = Color.Red
    '    End If
    '    'Three Numbers
    '    If threeNumbers.Matches(textbox_Password.Text).Count > 2 Then
    '        Label2.Text = "[✓ ] at least three numbers"
    '        Label2.ForeColor = Color.Green
    '    Else
    '        Label2.Text = "[✗ ] at least three numbers"
    '        Label2.ForeColor = Color.Red
    '    End If
    '    '11 Characters
    '    If textbox_Password.TextLength > 10 Then
    '        Label3.Text = "[✓ ] at least 11 characters"
    '        Label3.ForeColor = Color.Green
    '    Else
    '        Label3.Text = "[✗ ] at least 11 characters"
    '        Label3.ForeColor = Color.Red
    '    End If
    'End Sub

    'Private Sub textbox_ConfirmPassword_TextChanged(sender As Object, e As EventArgs)
    '    If textbox_Password.Text = textbox_ConfirmPassword.Text Then
    '        Label5.Text = "[✓ ] password doesn't match"
    '        Label5.ForeColor = Color.Green
    '    Else
    '        Label5.Text = "[✗ ] password doesn't match"
    '        Label5.ForeColor = Color.Red
    '    End If
    'End Sub

    'Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs)
    '    If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso Not e.KeyChar = "." Then
    '        e.Handled = True
    '    End If
    '    If (TextBox1.Text.IndexOf(".") >= 0 And e.KeyChar = ".") Then e.Handled = True
    'End Sub
End Class