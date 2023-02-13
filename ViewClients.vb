Public Class ViewClients
    Dim activeUser As String = "1"
    Private Sub EditDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Database.Count("SELECT COUNT([ClientID]) FROM [dtb_Clients];") = 0 Then
            InformationMessage("There's no client listed.", "")
            Me.Close()
        Else
            Database.PopulateDataGrid("SELECT [ClientID], [ClientName], [DateRegistered], [ShareCapital] FROM [dtb_Clients] WHERE ([Active]=" + activeUser + " AND [RegisterBy]='" + AccountType.GetAccountUsername + "') ORDER BY [ClientID] DESC;", SystemAccountsTable, New DataGridViewAutoSizeColumnMode() {DataGridViewAutoSizeColumnMode.DisplayedCells, DataGridViewAutoSizeColumnMode.DisplayedCells, DataGridViewAutoSizeColumnMode.Fill, DataGridViewAutoSizeColumnMode.DisplayedCells})
        End If

    End Sub

    Private Sub tb_SearchUsername_TextChanged(sender As Object, e As EventArgs) Handles tb_SearchUsername.TextChanged
        RegexBoxTextChanged(tb_SearchUsername, "[\/\\'""\[\] ]")
        If tb_SearchUsername.Text <> "" Then
            Database.PopulateDataGrid("SELECT [ClientID], [ClientName], [DateRegistered], [ShareCapital] FROM [dtb_Clients] WHERE ([ClientName] LIKE '%" + tb_SearchUsername.Text + "%') AND ([Active]=" + activeUser + " AND [RegisterBy]='" + AccountType.GetAccountUsername + "') ORDER BY [AccountID] DESC;", SystemAccountsTable, New DataGridViewAutoSizeColumnMode() {DataGridViewAutoSizeColumnMode.DisplayedCells, DataGridViewAutoSizeColumnMode.DisplayedCells, DataGridViewAutoSizeColumnMode.Fill, DataGridViewAutoSizeColumnMode.DisplayedCells})
        ElseIf tb_SearchUsername.Text = "" Then
            Database.PopulateDataGrid("SELECT [ClientID], [ClientName], [DateRegistered], [ShareCapital] FROM [dtb_Clients] WHERE ([Active]=" + activeUser + " AND [RegisterBy]='" + AccountType.GetAccountUsername + "') ORDER BY [AccountID] DESC;", SystemAccountsTable, New DataGridViewAutoSizeColumnMode() {DataGridViewAutoSizeColumnMode.DisplayedCells, DataGridViewAutoSizeColumnMode.DisplayedCells, DataGridViewAutoSizeColumnMode.Fill, DataGridViewAutoSizeColumnMode.DisplayedCells})
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            activeUser = "0"
            Database.PopulateDataGrid("SELECT [ClientID], [ClientName], [DateRegistered], [ShareCapital] FROM [dtb_Clients] WHERE ([Active]=" + activeUser + " AND [RegisterBy]='" + AccountType.GetAccountUsername + "') ORDER BY [ClientID] DESC;", SystemAccountsTable, New DataGridViewAutoSizeColumnMode() {DataGridViewAutoSizeColumnMode.DisplayedCells, DataGridViewAutoSizeColumnMode.DisplayedCells, DataGridViewAutoSizeColumnMode.Fill, DataGridViewAutoSizeColumnMode.DisplayedCells})
        Else
            activeUser = "1"
            Database.PopulateDataGrid("SELECT [ClientID], [ClientName], [DateRegistered], [ShareCapital] FROM [dtb_Clients] WHERE ([Active]=" + activeUser + " AND [RegisterBy]='" + AccountType.GetAccountUsername + "') ORDER BY [ClientID] DESC;", SystemAccountsTable, New DataGridViewAutoSizeColumnMode() {DataGridViewAutoSizeColumnMode.DisplayedCells, DataGridViewAutoSizeColumnMode.DisplayedCells, DataGridViewAutoSizeColumnMode.Fill, DataGridViewAutoSizeColumnMode.DisplayedCells})
        End If
    End Sub
End Class