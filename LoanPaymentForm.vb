Public Class LoanPaymentForm
    Public tLoanID As String = ""

    Private Sub ColumnFormatConverter(ByVal pDataGridView As DataGridView, ByVal pFormat As String)
        Dim newDataTable As New DataTable
        For columnCount As Integer = 0 To (pDataGridView.ColumnCount - 1)
            newDataTable.Columns.Add(pDataGridView.Columns(columnCount).Name, GetType(String))
        Next
        For rowIndex As Integer = 0 To (pDataGridView.RowCount - 1)
            newDataTable.Rows.Add(pDataGridView.Rows(rowIndex).Cells(0).Value.ToString, pDataGridView.Rows(rowIndex).Cells(1).Value.ToString, CType(pDataGridView.Rows(rowIndex).Cells(2).Value, Double).ToString(pFormat))
        Next
        pDataGridView.DataSource = newDataTable
    End Sub

    Private Sub EditDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Database.PopulateDataGrid("SELECT [dtb_Loans].LoanID, [dtb_Clients].ClientName, [dtb_Loans].LoanAmount FROM [dtb_Loans] INNER JOIN [dtb_Clients] ON [dtb_Loans].ClientID=[dtb_Clients].ClientID WHERE [dtb_Loans].LoanStatus=0;", SystemAccountsTable, New DataGridViewAutoSizeColumnMode() {DataGridViewAutoSizeColumnMode.DisplayedCells, DataGridViewAutoSizeColumnMode.Fill, DataGridViewAutoSizeColumnMode.DisplayedCells})
        ColumnFormatConverter(SystemAccountsTable, "C2")
        If SystemAccountsTable.RowCount <> 0 Then
            tLoanID = SystemAccountsTable.SelectedCells.Item(0).Value.ToString
        Else
            tLoanID = ""
        End If
    End Sub

    Private Sub SystemAccountsTable_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles SystemAccountsTable.CellClick
        If SystemAccountsTable.RowCount <> 0 Then
            tLoanID = SystemAccountsTable.SelectedCells.Item(0).Value.ToString
        Else
            tLoanID = ""
        End If
    End Sub

    Private Sub tb_SearchUsername_TextChanged(sender As Object, e As EventArgs) Handles tb_SearchClientName.TextChanged
        RegexBoxTextChanged(tb_SearchClientName, "[^a-zA-Z ]")
        If tb_SearchClientName.Text <> "" Then
            Database.PopulateDataGrid("SELECT [dtb_Loans].LoanID, [dtb_Clients].ClientName, [dtb_Loans].LoanAmount FROM [dtb_Loans] INNER JOIN [dtb_Clients] ON [dtb_Loans].ClientID=[dtb_Clients].ClientID WHERE [dtb_Loans].LoanStatus=0 AND ([dtb_Clients].ClientName LIKE '%" + tb_SearchClientName.Text + "%');", SystemAccountsTable, New DataGridViewAutoSizeColumnMode() {DataGridViewAutoSizeColumnMode.DisplayedCells, DataGridViewAutoSizeColumnMode.Fill, DataGridViewAutoSizeColumnMode.DisplayedCells})
            ColumnFormatConverter(SystemAccountsTable, "C2")
            If SystemAccountsTable.RowCount <> 0 Then
                tLoanID = SystemAccountsTable.SelectedCells.Item(0).Value.ToString
            Else
                tLoanID = ""
            End If
        Else
            Database.PopulateDataGrid("SELECT [dtb_Loans].LoanID, [dtb_Clients].ClientName, [dtb_Loans].LoanAmount FROM [dtb_Loans] INNER JOIN [dtb_Clients] ON [dtb_Loans].ClientID=[dtb_Clients].ClientID WHERE [dtb_Loans].LoanStatus=0;", SystemAccountsTable, New DataGridViewAutoSizeColumnMode() {DataGridViewAutoSizeColumnMode.DisplayedCells, DataGridViewAutoSizeColumnMode.Fill, DataGridViewAutoSizeColumnMode.DisplayedCells})
            ColumnFormatConverter(SystemAccountsTable, "C2")
            tLoanID = ""
        End If

    End Sub

    Private Sub btn_Edit_Click(sender As Object, e As EventArgs) Handles btn_Edit.Click
        If tLoanID = "" Then
            InformationMessage("Please select a loan entry.", "")
        Else
            LoanBalanceList.Show()
        End If
    End Sub
End Class