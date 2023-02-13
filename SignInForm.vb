
Public Class SignInForm

    Private Sub SignInButton_Click(sender As Object, e As EventArgs) Handles SignInButton.Click
        'Validation
        Dim ErrorString As String = ""
        Dim ErrorOccured As Boolean = False
        If Username.Text = "" Then
            ErrorOccured = True
            ErrorString = ErrorString + Environment.NewLine + "Error: NO USERNAME INPUT" + Environment.NewLine + "Please type the account's username in the textbox." + Environment.NewLine
        End If
        If Password.Text = "" Then
            ErrorOccured = True
            ErrorString = ErrorString + Environment.NewLine + "Error: NO PASSWORD INPUT" + Environment.NewLine + "Please type the account's password in the textbox." + Environment.NewLine
        End If
        If ErrorOccured Then
            ErrorMessage(ErrorString, "Error")
        Else
            'Find username if exist
            Dim AccountCount As Integer = Database.QueryReturnInteger("SELECT COUNT(*) FROM dtb_SystemAccounts WHERE Username='" + Username.Text + "';")
            If AccountCount = 1 Then
                'The username exists
                Dim PasswordDB As String = Database.QueryReturnString("SELECT Password FROM dtb_SystemAccounts WHERE Username='" + Username.Text + "';")
                If Password.Text = PasswordDB Then
                    Dim RoleID As Integer = Database.QueryReturnInteger("SELECT RoleID FROM dtb_SystemAccounts WHERE Username='" + Username.Text + "';")
                    If RoleID = 1 Then
                        MainForm.cMenuStrip.Visible = False
                        'AccountType.SetStripMenus(New ToolStripMenuItem() {MainForm.smClient, MainForm.smLogs, MainForm.smReports, MainForm.smSettings, MainForm.smTransactions, MainForm.aEdit, MainForm.aView, MainForm.aCreate, MainForm.aDelete})
                        AccountType.ShowToolStripMenuItem()
                        AccountType.SetAccessLevel(1)
                    ElseIf RoleID = 0 Then
                        MainForm.cMenuStrip.Visible = False
                        AccountType.SetStripMenus(New ToolStripMenuItem() {MainForm.tLoanForm, MainForm.smReports})
                        AccountType.ShowToolStripMenuItem()
                        AccountType.SetAccessLevel(0)
                    End If
                    MainForm.aSignIn.Enabled = False
                    MainForm.aSignOut.Enabled = True
                    MainForm.cMenuStrip.Visible = True
                    'Details
                    AccountType.SetAccountUsername(Username.Text)
                    Dim LogID As Integer
                    If Database.Count("SELECT COUNT([LogID]) FROM [dtb_AuditLog];") = 0 Then
                        LogID = 0
                    Else
                        LogID = Database.ReturnLastID("LogID", "dtb_AuditLog")
                    End If
                    Database.Insert("INSERT INTO [dtb_AuditLog] ([LogID], [ActionBy], [Action], [ActionDate], [ActionState], [ActionLevel]) VALUES(" + (LogID + 1).ToString + ",'System','Login Attempt','" + Date.Now.ToString() + "','Success','Critical');", False)
                    Me.Hide()
                    'Me.Close()
                Else
                    ErrorMessage("Wrong Password!", "Alert")
                    Dim LogID As Integer
                    If Database.Count("SELECT COUNT([LogID]) FROM [dtb_AuditLog];") = 0 Then
                        LogID = 0
                    Else
                        LogID = Database.ReturnLastID("LogID", "dtb_AuditLog")
                    End If


                    Database.Insert("INSERT INTO [dtb_AuditLog] ([LogID], [ActionBy], [Action], [ActionDate], [ActionState], [ActionLevel]) VALUES(" + (LogID + 1).ToString + ",'System','Login Attempt','" + Date.Now.ToString() + "','Failure','Warning');", False)
                End If
            ElseIf AccountCount = 0 Then
                'The username Doesn't exist
                ErrorMessage("The specified username doesn't exist!" + Environment.NewLine + "Contact the system administrator for account creation.", "Username is not found in database!")
                Dim LogID As Integer
                If Database.Count("SELECT COUNT([LogID]) FROM [dtb_AuditLog];") = 0 Then
                    LogID = 0
                Else
                    LogID = Database.ReturnLastID("LogID", "dtb_AuditLog")
                End If
                Database.Insert("INSERT INTO [dtb_AuditLog] ([LogID], [ActionBy], [Action], [ActionDate], [ActionState], [ActionLevel]) VALUES(" + (LogID + 1).ToString + ",'System','Login Attempt','" + Date.Now.ToString() + "','Failure','Warning');", False)
            End If
        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked

    End Sub

End Class

