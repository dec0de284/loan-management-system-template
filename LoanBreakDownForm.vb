Public Class LoanBreakDownForm
    Private Sub LoanBreakDownForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If LoanForm.SystemAccountsTable.RowCount <> 0 Then
            lbl_ClientName.Text = "Client Name: " + LoanForm.SystemAccountsTable.SelectedCells.Item(1).Value.ToString
            Label1.Text = "Client ID: " + LoanForm.SystemAccountsTable.SelectedCells.Item(0).Value.ToString
        Else
            lbl_ClientName.Text = "Client Name: N/A"
        End If
    End Sub
End Class