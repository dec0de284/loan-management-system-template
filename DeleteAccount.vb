Public Class DeleteAccount
    Public Username As String

    Private Sub EditDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Database.Count("SELECT COUNT([AccountID]) FROM [dtb_SystemAccounts];") = 0 Then
            InformationMessage("There's no active accounts.", "")
            Me.Close()
        Else
            Database.PopulateDataGrid("SELECT DISTINCT [AccountID], [Username] FROM [dtb_SystemAccounts] WHERE ([Active]=1 AND [RoleID]=0);", SystemAccountsTable, New DataGridViewAutoSizeColumnMode() {DataGridViewAutoSizeColumnMode.DisplayedCells, DataGridViewAutoSizeColumnMode.Fill})
            Username = CType(SystemAccountsTable.SelectedCells.Item(1).Value, String)
            lbl_Username.Text = "Username: " + Username
        End If



    End Sub

    Private Sub SystemAccountsTable_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles SystemAccountsTable.CellClick
        Username = CType(SystemAccountsTable.SelectedCells.Item(1).Value, String)
        lbl_Username.Text = "Username: " + Username
    End Sub

    Private Sub tb_SearchUsername_TextChanged(sender As Object, e As EventArgs) Handles tb_SearchUsername.TextChanged
        RegexBoxTextChanged(tb_SearchUsername, "[\/\\'""\[\] ]")
        If tb_SearchUsername.Text <> "" Then
            Database.PopulateDataGrid("SELECT [AccountID], [Username] FROM [dtb_SystemAccounts] WHERE ([Username] LIKE '%" + tb_SearchUsername.Text + "%') AND ([Active]=1 AND [RoleID]=0);", SystemAccountsTable, New DataGridViewAutoSizeColumnMode() {DataGridViewAutoSizeColumnMode.DisplayedCells, DataGridViewAutoSizeColumnMode.Fill})
            If SystemAccountsTable.Rows.Count = 0 Then
                lbl_Username.Text = "Username: N/A"
                Username = ""
            Else
                Username = CType(SystemAccountsTable.SelectedCells.Item(1).Value, String)
                lbl_Username.Text = "Username: " + Username
            End If
        ElseIf tb_SearchUsername.Text = "" Then
            Database.PopulateDataGrid("SELECT [AccountID], [Username] FROM [dtb_SystemAccounts] WHERE ([Username] LIKE '%" + tb_SearchUsername.Text + "%') AND ([Active]=1 AND [RoleID]=0);", SystemAccountsTable, New DataGridViewAutoSizeColumnMode() {DataGridViewAutoSizeColumnMode.DisplayedCells, DataGridViewAutoSizeColumnMode.Fill})
            Username = CType(SystemAccountsTable.SelectedCells.Item(1).Value, String)
            lbl_Username.Text = "Username: " + Username
        End If
    End Sub

    Private Sub btn_Delete_Click(sender As Object, e As EventArgs) Handles btn_Delete.Click
        If Username <> "" Then
            If MsgBox("Are you sure you want to deactivate this account: '" + Username + "'?", vbYesNo, "Confirmation") = vbYes Then
                'Database.Delete("DELETE FROM [SystemAccounts] WHERE [Username]='" + Username + "';", True)
                Database.Insert("UPDATE [dtb_SystemAccounts] SET [Active]=0 WHERE [Username]='" + Username + "';", False)
                SystemAccountsTable.DataSource = Nothing
                SystemAccountsTable.Refresh()
                Database.PopulateDataGrid("SELECT DISTINCT [AccountID], [Username] FROM [dtb_SystemAccounts] WHERE ([Active]=1 AND [RoleID]=0);", SystemAccountsTable, New DataGridViewAutoSizeColumnMode() {DataGridViewAutoSizeColumnMode.DisplayedCells, DataGridViewAutoSizeColumnMode.Fill})
            End If
        Else
            InformationMessage("Please select an account to deactivate.", "")
        End If
    End Sub
End Class