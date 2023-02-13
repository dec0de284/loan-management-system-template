Public Class ViewAccounts
    Dim activeUser As String = "1"
    Private Sub EditDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Database.PopulateDataGrid("SELECT [AccountID], [Username], [DateCreated] FROM [dtb_SystemAccounts] WHERE ([Active]=" + activeUser + " AND CreatedBy='" + AccountType.GetAccountUsername + "') ORDER BY [AccountID] DESC;", SystemAccountsTable, New DataGridViewAutoSizeColumnMode() {DataGridViewAutoSizeColumnMode.DisplayedCells, DataGridViewAutoSizeColumnMode.DisplayedCells, DataGridViewAutoSizeColumnMode.Fill})
    End Sub

    Private Sub tb_SearchUsername_TextChanged(sender As Object, e As EventArgs) Handles tb_SearchUsername.TextChanged
        RegexBoxTextChanged(tb_SearchUsername, "[\/\\'""\[\] ]")
        If tb_SearchUsername.Text <> "" Then
            Database.PopulateDataGrid("SELECT [AccountID], [Username], [DateCreated] FROM [dtb_SystemAccounts] WHERE ([Username] LIKE '%" + tb_SearchUsername.Text + "%') AND ([Active]=" + activeUser + " AND CreatedBy='" + AccountType.GetAccountUsername + "') ORDER BY [AccountID] DESC;", SystemAccountsTable, New DataGridViewAutoSizeColumnMode() {DataGridViewAutoSizeColumnMode.DisplayedCells, DataGridViewAutoSizeColumnMode.DisplayedCells, DataGridViewAutoSizeColumnMode.Fill})
        ElseIf tb_SearchUsername.Text = "" Then
            Database.PopulateDataGrid("SELECT [AccountID], [Username], [DateCreated] FROM [dtb_SystemAccounts] WHERE ([Active]=" + activeUser + " AND CreatedBy='" + AccountType.GetAccountUsername + "') ORDER BY [AccountID] DESC;", SystemAccountsTable, New DataGridViewAutoSizeColumnMode() {DataGridViewAutoSizeColumnMode.DisplayedCells, DataGridViewAutoSizeColumnMode.DisplayedCells, DataGridViewAutoSizeColumnMode.Fill})
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            activeUser = "0"
            Database.PopulateDataGrid("SELECT [AccountID], [Username], [DateCreated] FROM [dtb_SystemAccounts] WHERE ([Active]=" + activeUser + " AND CreatedBy='" + AccountType.GetAccountUsername + "') ORDER BY [AccountID] DESC;", SystemAccountsTable, New DataGridViewAutoSizeColumnMode() {DataGridViewAutoSizeColumnMode.DisplayedCells, DataGridViewAutoSizeColumnMode.DisplayedCells, DataGridViewAutoSizeColumnMode.Fill})
        Else
            activeUser = "1"
            Database.PopulateDataGrid("SELECT [AccountID], [Username], [DateCreated] FROM [dtb_SystemAccounts] WHERE ([Active]=" + activeUser + " AND CreatedBy='" + AccountType.GetAccountUsername + "') ORDER BY [AccountID] DESC;", SystemAccountsTable, New DataGridViewAutoSizeColumnMode() {DataGridViewAutoSizeColumnMode.DisplayedCells, DataGridViewAutoSizeColumnMode.DisplayedCells, DataGridViewAutoSizeColumnMode.Fill})
        End If
    End Sub
End Class