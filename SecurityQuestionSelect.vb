Imports System.Text.RegularExpressions
Public Class SecurityQuestionSelect

    Public SelectedQuestion As String
    Public SelectedQuestionID As String

    Private Sub EditDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Database.PopulateDataGrid("SELECT * FROM [dtb_SecurityQuestions] ORDER BY [ID] DESC;", SystemAccountsTable, New DataGridViewAutoSizeColumnMode() {DataGridViewAutoSizeColumnMode.DisplayedCells, DataGridViewAutoSizeColumnMode.Fill})
        SelectedQuestion = CType(SystemAccountsTable.SelectedCells.Item(1).Value, String)
        SelectedQuestionID = CType(SystemAccountsTable.SelectedCells.Item(0).Value, String)
        Label2.Text = "Question: " + SelectedQuestion
        Label3.Text = "ID: " + SelectedQuestionID
    End Sub

    Private Sub SystemAccountsTable_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles SystemAccountsTable.CellClick
        SelectedQuestion = CType(SystemAccountsTable.SelectedCells.Item(1).Value, String)
        SelectedQuestionID = CType(SystemAccountsTable.SelectedCells.Item(0).Value, String)
        Label2.Text = "Question: " + SelectedQuestion
        Label3.Text = "ID: " + SelectedQuestionID
    End Sub

    Private Sub tb_SearchUsername_TextChanged(sender As Object, e As EventArgs) Handles tb_SearchUsername.TextChanged
        If tb_SearchUsername.Text.Contains("'") = False Then
            Database.PopulateDataGrid("SELECT * FROM [dtb_SecurityQuestions] WHERE ([Question] LIKE '%" + tb_SearchUsername.Text + "%') ORDER BY [ID] DESC;", SystemAccountsTable, New DataGridViewAutoSizeColumnMode() {DataGridViewAutoSizeColumnMode.DisplayedCells, DataGridViewAutoSizeColumnMode.Fill})
            If SystemAccountsTable.RowCount = 0 Then
                SelectedQuestion = "N/A"
                SelectedQuestionID = "N/A"
                Label2.Text = "Question: N/A"
                Label3.Text = "ID: N/A"
            Else
                SelectedQuestion = CType(SystemAccountsTable.SelectedCells.Item(1).Value, String)
                SelectedQuestionID = CType(SystemAccountsTable.SelectedCells.Item(0).Value, String)
                Label2.Text = "Question: " + SelectedQuestion
                Label3.Text = "ID: " + SelectedQuestionID
            End If
        Else
            tb_SearchUsername.Text = tb_SearchUsername.Text.Replace("'", "")
            InformationMessage("Placing an apostrophe in the search box will result to syntax error.", "Warning")
        End If
    End Sub

    Private Sub btn_Edit_Click(sender As Object, e As EventArgs) Handles btn_Edit.Click
        Dim ErrorOccured As Boolean = False
        If FirstTimeSetupAdminAccountRecovery.pressedButton = 0 Then
            For Each item As String In FirstTimeSetupAdminAccountRecovery.SelectedQuestions
                If item = SelectedQuestionID Then
                    ErrorOccured = True
                End If
            Next
            If ErrorOccured Then
                InformationMessage("The question is already selected.", "Duplicate Security Question")
            Else
                FirstTimeSetupAdminAccountRecovery.TextBox1.Text = SelectedQuestion
                FirstTimeSetupAdminAccountRecovery.SelectedQuestions(0) = SelectedQuestionID
                ErrorOccured = False
            End If
        ElseIf FirstTimeSetupAdminAccountRecovery.pressedButton = 1 Then
            For Each item As String In FirstTimeSetupAdminAccountRecovery.SelectedQuestions
                If item = SelectedQuestionID Then
                    ErrorOccured = True
                End If
            Next
            If ErrorOccured Then
                InformationMessage("The question is already selected.", "Duplicate Security Question")
            Else
                FirstTimeSetupAdminAccountRecovery.TextBox4.Text = SelectedQuestion
                FirstTimeSetupAdminAccountRecovery.SelectedQuestions(1) = SelectedQuestionID
                ErrorOccured = False
            End If
        ElseIf FirstTimeSetupAdminAccountRecovery.pressedButton = 2 Then
            For Each item As String In FirstTimeSetupAdminAccountRecovery.SelectedQuestions
                If item = SelectedQuestionID Then
                    ErrorOccured = True
                End If
            Next
            If ErrorOccured Then
                InformationMessage("The question is already selected.", "Duplicate Security Question")
            Else
                FirstTimeSetupAdminAccountRecovery.TextBox6.Text = SelectedQuestion
                FirstTimeSetupAdminAccountRecovery.SelectedQuestions(2) = SelectedQuestionID
                ErrorOccured = False
            End If

        End If
        If ErrorOccured = False Then
            Me.Hide()
            Database.PopulateDataGrid("SELECT * FROM [dtb_SecurityQuestions] ORDER BY [ID] DESC;", SystemAccountsTable, New DataGridViewAutoSizeColumnMode() {DataGridViewAutoSizeColumnMode.DisplayedCells, DataGridViewAutoSizeColumnMode.Fill})
            SelectedQuestion = CType(SystemAccountsTable.SelectedCells.Item(1).Value, String)
            SelectedQuestionID = CType(SystemAccountsTable.SelectedCells.Item(0).Value, String)
            Label2.Text = "Question: " + SelectedQuestion
            Label3.Text = "ID: " + SelectedQuestionID
            TextBox1.Text = ""
            tb_SearchUsername.Text = ""
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim validQuestion = New Regex("^[A-Z][A-Za-z0-9 ]+(?:\?)")
        If validQuestion.IsMatch(TextBox1.Text) And TextBox1.Text.Length > 9 Then
            If MessageBox.Show("Add '" + TextBox1.Text + "' to question list?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                Dim ID As Integer = Database.ReturnLastID("ID", "dtb_SecurityQuestions")
                InformationMessage(ID.ToString, "")
                Database.Insert("INSERT INTO [dtb_SecurityQuestions] ([ID], [Question]) VALUES(" + (ID + 1).ToString + ",'" + TextBox1.Text + "');", True)
                Dim LogID As Integer
                If Database.Count("SELECT COUNT([LogID]) FROM [dtb_AuditLog];") = 0 Then
                    LogID = 0
                Else
                    LogID = Database.ReturnLastID("LogID", "dtb_AuditLog")
                End If


                Database.Insert("INSERT INTO [dtb_AuditLog] ([LogID], [ActionBy], [Action], [ActionDate], [ActionState], [ActionLevel]) VALUES(" + (LogID + 1).ToString + ",'System','Add Security Question','" + Date.Now.ToString() + "','Success','Information');", False)
                Database.PopulateDataGrid("SELECT * FROM [dtb_SecurityQuestions] ORDER BY [ID] DESC;", SystemAccountsTable, New DataGridViewAutoSizeColumnMode() {DataGridViewAutoSizeColumnMode.DisplayedCells, DataGridViewAutoSizeColumnMode.Fill})

                    SelectedQuestion = CType(SystemAccountsTable.SelectedCells.Item(1).Value, String)
                    SelectedQuestionID = CType(SystemAccountsTable.SelectedCells.Item(0).Value, String)
                    Label2.Text = "Question: " + SelectedQuestion
                    Label3.Text = "ID: " + SelectedQuestionID
                Else

                End If


        Else
            ErrorMessage("SECURITY QUESTION FORMAT ERROR." + Environment.NewLine + "- The first letter of the question must be capitalized." + Environment.NewLine + "- The question mustn't have special characters." + Environment.NewLine + "- Minimum of 10 characters." + Environment.NewLine + "- Must end with a question mark.", "Format Error")
        End If

    End Sub
End Class