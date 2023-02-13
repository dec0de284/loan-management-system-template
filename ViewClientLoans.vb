Public Class ViewClientLoans
    Public ClientID As String
    Public ClientName As String

    Private Sub EditDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Database.PopulateDataGrid("SELECT DISTINCT [ClientID],[ClientName] FROM [dtb_Clients];", SystemAccountsTable, New DataGridViewAutoSizeColumnMode() {DataGridViewAutoSizeColumnMode.DisplayedCells, DataGridViewAutoSizeColumnMode.Fill})
        ClientID = CType(SystemAccountsTable.SelectedCells.Item(0).Value, String)
        ClientName = CType(SystemAccountsTable.SelectedCells.Item(1).Value, String)
        lbl_ClientID.Text = "Client ID: " + ClientID
        lbl_ClientName.Text = "Client Name: " + ClientName
    End Sub

    Private Sub SystemAccountsTable_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles SystemAccountsTable.CellClick
        ClientID = CType(SystemAccountsTable.SelectedCells.Item(0).Value, String)
        ClientName = CType(SystemAccountsTable.SelectedCells.Item(1).Value, String)
        lbl_ClientID.Text = "Client ID: " + ClientID
        lbl_ClientName.Text = "Client Name: " + ClientName
    End Sub

    Private Sub tb_SearchClientName_TextChanged(sender As Object, e As EventArgs) Handles tb_SearchClientName.TextChanged
        RegexBoxTextChanged(tb_SearchClientName, "[^a-zA-Z ]")
        If tb_SearchClientName.Text <> "" Then
            Database.PopulateDataGrid("SELECT DISTINCT [ClientID],[ClientName] FROM [dtb_Clients] WHERE ([ClientName] LIKE '%" + tb_SearchClientName.Text + "%');", SystemAccountsTable, New DataGridViewAutoSizeColumnMode() {DataGridViewAutoSizeColumnMode.DisplayedCells, DataGridViewAutoSizeColumnMode.Fill})
            If SystemAccountsTable.Rows.Count = 0 Then
                lbl_ClientID.Text = "Client ID: N/A"
                lbl_ClientName.Text = "Client Name: N/A"
                ClientID = ""
            Else
                ClientID = CType(SystemAccountsTable.SelectedCells.Item(0).Value, String)
                ClientName = CType(SystemAccountsTable.SelectedCells.Item(1).Value, String)
                lbl_ClientID.Text = "Client ID: " + ClientID
                lbl_ClientName.Text = "Client Name: " + ClientName
            End If
        ElseIf tb_SearchClientName.Text = "" Then
            Database.PopulateDataGrid("SELECT DISTINCT [ClientID],[ClientName] FROM [dtb_Clients];", SystemAccountsTable, New DataGridViewAutoSizeColumnMode() {DataGridViewAutoSizeColumnMode.DisplayedCells, DataGridViewAutoSizeColumnMode.Fill})
            ClientID = CType(SystemAccountsTable.SelectedCells.Item(0).Value, String)
            ClientName = CType(SystemAccountsTable.SelectedCells.Item(1).Value, String)
            lbl_ClientID.Text = "Client ID: " + ClientID
            lbl_ClientName.Text = "Client Name: " + ClientName
        End If
    End Sub

    Private Sub btn_Edit_Click(sender As Object, e As EventArgs) Handles btn_Edit.Click
        'Me.Hide()
        'EditAccountDetails.Show()
        If ClientID <> "" Then
            'show edit form
            'EditClientForm.Show()

            'show client loans (revision)
        Else
            InformationMessage("Please select a client to view their loans.", "")
        End If
    End Sub

    Private Sub btn_AddCapitalShare_Click(sender As Object, e As EventArgs)
        If ClientID <> "" Then
            'show edit form
            AddCapitalShareForm.Show()
        Else
            InformationMessage("Please select a client.", "")
        End If

    End Sub
End Class