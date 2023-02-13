Public Class DeactivateClient
    Public Username As String

    Private Sub EditDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Database.Count("SELECT COUNT([ClientID]) FROM [dtb_Clients];") = 0 Or Database.Count("SELECT COUNT([ClientID]) FROM [dtb_Clients] WHERE ([Active]=1 AND [RegisterBy]='" + AccountType.GetAccountUsername + "') ORDER BY [ClientID] DESC;") = 0 Then
            InformationMessage("There's no client listed.", "")
            Me.Close()
        Else
            Database.PopulateDataGrid("SELECT [ClientID], [ClientName], [DateRegistered], [ShareCapital] FROM [dtb_Clients] WHERE ([Active]=1 AND [RegisterBy]='" + AccountType.GetAccountUsername + "') ORDER BY [ClientID] DESC;", SystemAccountsTable, New DataGridViewAutoSizeColumnMode() {DataGridViewAutoSizeColumnMode.DisplayedCells, DataGridViewAutoSizeColumnMode.DisplayedCells, DataGridViewAutoSizeColumnMode.Fill, DataGridViewAutoSizeColumnMode.DisplayedCells})
            Username = CType(SystemAccountsTable.SelectedCells.Item(1).Value, String)
            lbl_Username.Text = "Client: " + Username
        End If


    End Sub

    Private Sub SystemAccountsTable_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles SystemAccountsTable.CellClick
        Username = CType(SystemAccountsTable.SelectedCells.Item(1).Value, String)
        lbl_Username.Text = "Client: " + Username
    End Sub

    Private Sub tb_SearchUsername_TextChanged(sender As Object, e As EventArgs) Handles tb_SearchUsername.TextChanged
        RegexBoxTextChanged(tb_SearchUsername, "[\/\\'""\[\] ]")
        If tb_SearchUsername.Text <> "" Then
            Database.PopulateDataGrid("SELECT [ClientID], [ClientName], [DateRegistered], [ShareCapital] FROM [dtb_Clients] WHERE ([Username] LIKE '%" + tb_SearchUsername.Text + "%') AND ([Active]=1 AND [RegisterBy]='" + AccountType.GetAccountUsername + "') ORDER BY [ClientID] DESC;", SystemAccountsTable, New DataGridViewAutoSizeColumnMode() {DataGridViewAutoSizeColumnMode.DisplayedCells, DataGridViewAutoSizeColumnMode.DisplayedCells, DataGridViewAutoSizeColumnMode.Fill, DataGridViewAutoSizeColumnMode.DisplayedCells})
            If SystemAccountsTable.Rows.Count = 0 Then
                lbl_Username.Text = "Client: N/A"
                Username = ""
            Else
                Username = CType(SystemAccountsTable.SelectedCells.Item(1).Value, String)
                lbl_Username.Text = "Client: " + Username
            End If
        ElseIf tb_SearchUsername.Text = "" Then
            Database.PopulateDataGrid("SELECT [ClientID], [ClientName], [DateRegistered], [ShareCapital] FROM [dtb_Clients] WHERE ([Active]=1 AND [RegisterBy]='" + AccountType.GetAccountUsername + "') ORDER BY [ClientID] DESC;", SystemAccountsTable, New DataGridViewAutoSizeColumnMode() {DataGridViewAutoSizeColumnMode.DisplayedCells, DataGridViewAutoSizeColumnMode.DisplayedCells, DataGridViewAutoSizeColumnMode.Fill, DataGridViewAutoSizeColumnMode.DisplayedCells})
            Username = CType(SystemAccountsTable.SelectedCells.Item(1).Value, String)
            lbl_Username.Text = "Client: " + Username
        End If
    End Sub

    Private Sub btn_Delete_Click(sender As Object, e As EventArgs) Handles btn_Delete.Click
        If Username <> "" Then
            If MsgBox("Are you sure you want to deactivate this client: '" + Username + "'?", vbYesNo, "Confirmation") = vbYes Then
                'Database.Delete("DELETE FROM [SystemAccounts] WHERE [Username]='" + Username + "';", True)
                Database.Insert("UPDATE [dtb_Clients] SET [Active]=0 WHERE [ClientName]='" + Username + "';", False)
                SystemAccountsTable.DataSource = Nothing
                SystemAccountsTable.Refresh()
                If Database.Count("SELECT COUNT([ClientID]) FROM [dtb_Clients];") = 0 Or Database.Count("SELECT COUNT([ClientID]) FROM [dtb_Clients] WHERE ([Active]=1 AND [RegisterBy]='" + AccountType.GetAccountUsername + "') ORDER BY [ClientID] DESC;") = 0 Then
                    InformationMessage("There's no client listed.", "")
                    Me.Close()
                Else
                    Database.PopulateDataGrid("SELECT [ClientID], [ClientName], [DateRegistered], [ShareCapital] FROM [dtb_Clients] WHERE ([Active]=1 AND [RegisterBy]='" + AccountType.GetAccountUsername + "') ORDER BY [ClientID] DESC;", SystemAccountsTable, New DataGridViewAutoSizeColumnMode() {DataGridViewAutoSizeColumnMode.DisplayedCells, DataGridViewAutoSizeColumnMode.DisplayedCells, DataGridViewAutoSizeColumnMode.Fill, DataGridViewAutoSizeColumnMode.DisplayedCells})
                    Username = CType(SystemAccountsTable.SelectedCells.Item(1).Value, String)
                    lbl_Username.Text = "Client: " + Username
                End If
            End If
        Else
            InformationMessage("Please select an client to deactivate.", "")
        End If
    End Sub
End Class