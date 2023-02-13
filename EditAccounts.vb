Public Class EditAccounts
    Public RoleID As Integer
    Public Username As String

    Private Sub EditDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Database.PopulateDataGrid("SELECT DISTINCT RoleID, Username FROM SystemAccounts;", SystemAccountsTable, New DataGridViewAutoSizeColumnMode() {DataGridViewAutoSizeColumnMode.DisplayedCells, DataGridViewAutoSizeColumnMode.Fill})
        RoleID = CType(SystemAccountsTable.SelectedCells.Item(0).Value, Integer)
        If RoleID = 0 Then
            RoleAccess.Text = "Role Access: User Account"
        ElseIf RoleID = 1 Then
            RoleAccess.Text = "Role Access: Administrator Account"
        End If
        Username = CType(SystemAccountsTable.SelectedCells.Item(1).Value, String)
        lbl_Username.Text = "Username: " + Username

    End Sub

    Private Sub SystemAccountsTable_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles SystemAccountsTable.CellClick
        RoleID = CType(SystemAccountsTable.SelectedCells.Item(0).Value, Integer)
        If RoleID = 0 Then
            RoleAccess.Text = "Role Access: User Account"
        ElseIf RoleID = 1 Then
            RoleAccess.Text = "Role Access: Administrator Account"
        End If
        Username = CType(SystemAccountsTable.SelectedCells.Item(1).Value, String)
        lbl_Username.Text = "Username: " + Username
    End Sub

    Private Sub tb_SearchUsername_TextChanged(sender As Object, e As EventArgs) Handles tb_SearchUsername.TextChanged
        If tb_SearchUsername.Text.Contains("'") = False Then
            Database.PopulateDataGrid("SELECT RoleID, Username FROM SystemAccounts WHERE (Username LIKE '%" + tb_SearchUsername.Text + "%');", SystemAccountsTable, New DataGridViewAutoSizeColumnMode() {DataGridViewAutoSizeColumnMode.DisplayedCells, DataGridViewAutoSizeColumnMode.Fill})
        Else
            tb_SearchUsername.Text = tb_SearchUsername.Text.Replace("'", "")
            InformationMessage("Placing an apostrophe in the search box will result to syntax error.", "Warning")
        End If
    End Sub

    Private Sub btn_Edit_Click(sender As Object, e As EventArgs) Handles btn_Edit.Click
        Me.Hide()
        EditAccountDetails.Show()
    End Sub
End Class