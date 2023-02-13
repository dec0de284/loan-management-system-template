Public Class SelectForm
    Public RoleID As Integer
    Public Username As String
    Public selectedText As String
    Public ErrorOccured As Boolean = False
    Private tempText As String


    Private Sub EditDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Select " + AddClientForm.selectedButton
        GroupBox1.Text = "Filter " + AddClientForm.selectedButton
        SelectedAccount.Text = "Selected " + AddClientForm.selectedButton

        If AddClientForm.selectedClientButton Then
            Select Case AddClientForm.selectedButton
                Case "Province"
                    tempText = AddClientForm.TextBox1.Text
                Case "City"
                    tempText = AddClientForm.TextBox2.Text
                Case "Barangay"
                    tempText = AddClientForm.TextBox3.Text
            End Select
        Else
            Select Case AddClientForm.selectedButton
                Case "Province"
                    tempText = AddClientForm.TextBox8.Text
                Case "City"
                    tempText = AddClientForm.TextBox7.Text
                Case "Barangay"
                    tempText = AddClientForm.TextBox6.Text
            End Select
        End If

        Select Case AddClientForm.selectedButton
            Case "Region"
                Database.PopulateDataGrid("SELECT * FROM [dtb_Region];", SystemAccountsTable, New DataGridViewAutoSizeColumnMode() {DataGridViewAutoSizeColumnMode.Fill})
            Case "Province"
                Database.PopulateDataGrid("SELECT [Province] FROM [dtb_Province] WHERE [Region]='" + tempText + "';", SystemAccountsTable, New DataGridViewAutoSizeColumnMode() {DataGridViewAutoSizeColumnMode.Fill})
            Case "City"
                Database.PopulateDataGrid("SELECT [City] FROM [dtb_City] WHERE [Province]='" + tempText + "';", SystemAccountsTable, New DataGridViewAutoSizeColumnMode() {DataGridViewAutoSizeColumnMode.Fill})
            Case "Barangay"
                Database.PopulateDataGrid("SELECT [Barangay] FROM [dtb_Barangay] WHERE [City]='" + tempText + "';", SystemAccountsTable, New DataGridViewAutoSizeColumnMode() {DataGridViewAutoSizeColumnMode.Fill})
        End Select
        If SystemAccountsTable.RowCount > 0 Then
            selectedText = CType(SystemAccountsTable.SelectedCells.Item(0).Value, String)
            lbl_Username.Text = AddClientForm.selectedButton + ": " + selectedText
        Else
            ErrorMessage("Unable to fetch " + AddClientForm.selectedButton + " list!", "Error")
            ErrorOccured = True
            AddClientForm.RestoreOldButtonSwitchState()
        End If
        'Try

        'Catch ex As Exception
        '    ErrorMessage("Unable to fetch " + AddClientForm.selectedButton + " list!", "Error")
        '    If AddClientForm.selectedClientButton Then
        '        AddClientForm.TextBox2.Text = ""
        '        AddClientForm.TextBox3.Text = ""
        '        AddClientForm.TextBox4.Text = ""
        '        AddClientForm.Button1.Enabled = True
        '        AddClientForm.Button2.Enabled = False
        '        AddClientForm.Button3.Enabled = False
        '        AddClientForm.Button4.Enabled = False
        '    End If
        '    Me.Close()
        'End Try


        'Database.PopulateDataGrid("SELECT * FROM SystemAccounts;", SystemAccountsTable, New DataGridViewAutoSizeColumnMode() {DataGridViewAutoSizeColumnMode.DisplayedCells, DataGridViewAutoSizeColumnMode.Fill})
        'RoleID = CType(SystemAccountsTable.SelectedCells.Item(0).Value, Integer)
        'If RoleID = 0 Then
        '    RoleAccess.Text = "Role Access: User Account"
        'ElseIf RoleID = 1 Then
        '    RoleAccess.Text = "Role Access: Administrator Account"
        'End If
        'Username = CType(SystemAccountsTable.SelectedCells.Item(1).Value, String)
        'lbl_Username.Text = "Username: " + Username

    End Sub

    Private Sub SystemAccountsTable_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles SystemAccountsTable.CellClick
        'RoleID = CType(SystemAccountsTable.SelectedCells.Item(0).Value, Integer)
        'If RoleID = 0 Then
        '    RoleAccess.Text = "Role Access: User Account"
        'ElseIf RoleID = 1 Then
        '    RoleAccess.Text = "Role Access: Administrator Account"
        'End If
        'Username = CType(SystemAccountsTable.SelectedCells.Item(1).Value, String)
        'lbl_Username.Text = "Username: " + Username
        selectedText = CType(SystemAccountsTable.SelectedCells.Item(0).Value, String)
        lbl_Username.Text = AddClientForm.selectedButton + ": " + selectedText
    End Sub

    Private Sub btn_Edit_Click(sender As Object, e As EventArgs) Handles btn_Edit.Click
        If selectedText <> "N/A" Then
            AddClientForm.RestoreOldButtonSwitchState()
            If AddClientForm.selectedClientButton Then
                Select Case AddClientForm.selectedButton
                    Case "Region"
                        AddClientForm.TextBox1.Text = selectedText
                        AddClientForm.Button2.Enabled = True
                    Case "Province"
                        AddClientForm.TextBox2.Text = selectedText
                        AddClientForm.Button3.Enabled = True
                    Case "City"
                        AddClientForm.TextBox3.Text = selectedText
                        AddClientForm.Button4.Enabled = True
                    Case "Barangay"
                        AddClientForm.TextBox4.Text = selectedText
                End Select
            Else
                Select Case AddClientForm.selectedButton
                    Case "Region"
                        AddClientForm.TextBox8.Text = selectedText
                        AddClientForm.Button7.Enabled = True
                    Case "Province"
                        AddClientForm.TextBox7.Text = selectedText
                        AddClientForm.Button6.Enabled = True
                    Case "City"
                        AddClientForm.TextBox6.Text = selectedText
                        AddClientForm.Button5.Enabled = True
                    Case "Barangay"
                        AddClientForm.TextBox5.Text = selectedText
                End Select
            End If
        Else
            InformationMessage(AddClientForm.selectedButton + " cannot be empty.", "Warning")
        End If
        Me.Close()
    End Sub

    Private Sub tb_SearchUsername_TextChanged(sender As Object, e As EventArgs) Handles tb_SearchUsername.TextChanged
        If tb_SearchUsername.Text.Contains("'") = False Then
            Select Case AddClientForm.selectedButton
                Case "Region"
                    Database.PopulateDataGrid("SELECT * FROM [dtb_Region] WHERE ([Region] LIKE '%" + tb_SearchUsername.Text + "%');", SystemAccountsTable, New DataGridViewAutoSizeColumnMode() {DataGridViewAutoSizeColumnMode.Fill})
                Case "Province"
                    Database.PopulateDataGrid("SELECT [Province] FROM [dtb_Province] WHERE ([Province] LIKE '%" + tb_SearchUsername.Text + "%' AND [Region]='" + tempText + "');", SystemAccountsTable, New DataGridViewAutoSizeColumnMode() {DataGridViewAutoSizeColumnMode.Fill})
                Case "City"
                    Database.PopulateDataGrid("SELECT [City] FROM [dtb_City] WHERE ([City] LIKE '%" + tb_SearchUsername.Text + "%' AND [Province]='" + tempText + "');", SystemAccountsTable, New DataGridViewAutoSizeColumnMode() {DataGridViewAutoSizeColumnMode.Fill})
                Case "Barangay"
                    Database.PopulateDataGrid("SELECT [Barangay] FROM [dtb_Barangay] WHERE ([Barangay] LIKE '%" + tb_SearchUsername.Text + "%' AND [City]='" + tempText + "');", SystemAccountsTable, New DataGridViewAutoSizeColumnMode() {DataGridViewAutoSizeColumnMode.Fill})
            End Select
            If SystemAccountsTable.RowCount > 0 Then
                selectedText = CType(SystemAccountsTable.SelectedCells.Item(0).Value, String)
                lbl_Username.Text = AddClientForm.selectedButton + ": " + selectedText
            End If

            'Database.PopulateDataGrid("SELECT RoleID, Username FROM SystemAccounts WHERE (Username LIKE '%" + tb_SearchUsername.Text + "%');", SystemAccountsTable, New DataGridViewAutoSizeColumnMode() {DataGridViewAutoSizeColumnMode.DisplayedCells, DataGridViewAutoSizeColumnMode.Fill})
        Else
            tb_SearchUsername.Text = tb_SearchUsername.Text.Replace("'", "")
            'InformationMessage("Placing an apostrophe in the search box will result to syntax error.", "Warning")
        End If

        If SystemAccountsTable.Rows.Count = 0 Then
            selectedText = "N/A"
            lbl_Username.Text = AddClientForm.selectedButton + ": " + selectedText
        End If
    End Sub

    'Private Sub btn_Edit_Click(sender As Object, e As EventArgs) Handles btn_Edit.Click
    '    Me.Hide()
    '    EditAccountDetails.Show()
    'End Sub

End Class