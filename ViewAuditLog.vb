Public Class ViewAuditLog

    Private Sub EditDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Database.PopulateDataGrid("SELECT * FROM [dtb_AuditLog] ORDER BY [LogID] DESC;", SystemAccountsTable, New DataGridViewAutoSizeColumnMode() {DataGridViewAutoSizeColumnMode.DisplayedCells, DataGridViewAutoSizeColumnMode.DisplayedCells, DataGridViewAutoSizeColumnMode.DisplayedCells, DataGridViewAutoSizeColumnMode.Fill, DataGridViewAutoSizeColumnMode.DisplayedCells, DataGridViewAutoSizeColumnMode.DisplayedCells})
    End Sub
End Class