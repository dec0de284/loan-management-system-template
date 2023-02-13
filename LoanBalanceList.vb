Public Class LoanBalanceList
    Private tLoanID As String = ""
    Private tBalanceID As String = ""

    Private Sub ColumnFormatConverter(ByVal pDataGridView As DataGridView, ByVal pFormat As String, ByVal pDataGridViewAutoSizeColumnMode As DataGridViewAutoSizeColumnMode())
        Dim newDataTable As New DataTable
        For columnCount As Integer = 0 To (pDataGridView.ColumnCount - 1)
            Select Case columnCount
                Case 0
                    newDataTable.Columns.Add("ID", GetType(String))
                Case 1
                    newDataTable.Columns.Add("Due Date", GetType(String))
                Case 2
                    newDataTable.Columns.Add("Amount", GetType(String))
                Case 3
                    newDataTable.Columns.Add("Status", GetType(String))
            End Select
        Next
        For rowIndex As Integer = 0 To (pDataGridView.RowCount - 1)
            newDataTable.Rows.Add(pDataGridView.Rows(rowIndex).Cells(0).Value.ToString, CType(pDataGridView.Rows(rowIndex).Cells(1).Value, Date).ToShortDateString, CType(pDataGridView.Rows(rowIndex).Cells(2).Value, Double).ToString(pFormat), "Unpaid")
        Next
        pDataGridView.DataSource = newDataTable
        ', ByVal pDataGridViewAutoSizeColumnMode As DataGridViewAutoSizeColumnMode()
        For i As Integer = 0 To (pDataGridView.ColumnCount - 1)
            pDataGridView.Columns.Item(i).Resizable = DataGridViewTriState.False
            pDataGridView.Columns.Item(i).SortMode = DataGridViewColumnSortMode.NotSortable
            pDataGridView.Columns.Item(i).AutoSizeMode = pDataGridViewAutoSizeColumnMode(i)
        Next
        If pDataGridView.RowCount <> 0 Then
            pDataGridView.Rows(0).Selected = True
        End If
    End Sub

    Private Sub EditDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tLoanID = LoanPaymentForm.tLoanID
        LoanPaymentForm.Close()
        Database.PopulateDataGrid("SELECT DISTINCT [BalanceID],[MonthDueDate],[MonthAmountDue], [PaymentStatus] FROM [dtb_LoanBalances] WHERE [LoanID]=" + tLoanID + " AND [PaymentStatus]=0;", SystemAccountsTable, New DataGridViewAutoSizeColumnMode() {DataGridViewAutoSizeColumnMode.DisplayedCells, DataGridViewAutoSizeColumnMode.Fill, DataGridViewAutoSizeColumnMode.Fill, DataGridViewAutoSizeColumnMode.DisplayedCells})
        ColumnFormatConverter(SystemAccountsTable, "C2", New DataGridViewAutoSizeColumnMode() {DataGridViewAutoSizeColumnMode.DisplayedCells, DataGridViewAutoSizeColumnMode.DisplayedCells, DataGridViewAutoSizeColumnMode.Fill, DataGridViewAutoSizeColumnMode.DisplayedCells})
        If SystemAccountsTable.RowCount <> 0 Then
            tBalanceID = SystemAccountsTable.SelectedCells.Item(0).Value.ToString
        Else
            tBalanceID = ""
        End If
    End Sub

    Private Sub SystemAccountsTable_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles SystemAccountsTable.CellClick
        If SystemAccountsTable.RowCount <> 0 Then
            tBalanceID = SystemAccountsTable.SelectedCells.Item(0).Value.ToString
        Else
            tBalanceID = ""
        End If
    End Sub

    Private Sub btn_Edit_Click(sender As Object, e As EventArgs) Handles btn_Edit.Click
        If tBalanceID <> "" Then
            Dim tDataTable As DataTable = Database.PopulateDataTable("SELECT [dtb_Clients].ClientName, [dtb_Clients].ClientAddress, [dtb_Clients].ClientContactNumber, [dtb_Clients].CoMakerName, [dtb_Clients].CoMakerAddress, [dtb_Clients].CoMakerContactNumber, [dtb_Loans].StartDate, [dtb_Loans].DueDate, [dtb_Loans].LoanAmount, [dtb_Loans].RemainingBalance, [dtb_Loans].InterestRate,[dtb_LoanBalances].MonthAmountDue, [dtb_LoanBalances].MonthDueDate FROM (([dtb_Loans] INNER JOIN [dtb_Clients] ON [dtb_Loans].ClientID = [dtb_Clients].ClientID) INNER JOIN [dtb_LoanBalances] ON [dtb_Loans].LoanID = [dtb_LoanBalances].LoanID) WHERE [dtb_LoanBalances].BalanceID=" + tBalanceID.ToString + ";")
            tDataTable.Columns.Add("NewRemainingBalance", GetType(Double))
            tDataTable.Columns.Add("PaymentDate", GetType(Date))
            tDataTable.Rows(0).Item(13) = Math.Round(CType(tDataTable.Rows(0).Item(9), Double), 2) - Math.Round(CType(tDataTable.Rows(0).Item(11), Double), 2)
            tDataTable.Rows(0).Item(14) = Date.Now
            Dim tNewDataTable As New DataTable
            tNewDataTable.Columns.Add("ClientName", GetType(String))
            tNewDataTable.Columns.Add("ClientAddress", GetType(String))
            tNewDataTable.Columns.Add("ClientContactNumber", GetType(String))
            tNewDataTable.Columns.Add("CoMakerName", GetType(String))
            tNewDataTable.Columns.Add("CoMakerAddress", GetType(String))
            tNewDataTable.Columns.Add("CoMakerContactNumber", GetType(String))
            tNewDataTable.Columns.Add("StartDate", GetType(String))
            tNewDataTable.Columns.Add("DueDate", GetType(String))
            tNewDataTable.Columns.Add("LoanAmount", GetType(String))
            tNewDataTable.Columns.Add("RemainingBalance", GetType(String))
            tNewDataTable.Columns.Add("InterestRate", GetType(String))
            tNewDataTable.Columns.Add("MonthAmountDue", GetType(String))
            tNewDataTable.Columns.Add("MonthDueDate", GetType(String))
            tNewDataTable.Columns.Add("NewRemainingBalance", GetType(String))
            tNewDataTable.Columns.Add("PaymentDate", GetType(String))
            For tRows As Integer = 0 To (tDataTable.Rows.Count - 1)
                tNewDataTable.Rows.Add(tDataTable.Rows(0).Item(0).ToString, tDataTable.Rows(0).Item(1).ToString, tDataTable.Rows(0).Item(2).ToString, tDataTable.Rows(0).Item(3).ToString, tDataTable.Rows(0).Item(4).ToString, tDataTable.Rows(0).Item(5).ToString, CType(tDataTable.Rows(0).Item(6), Date).ToShortDateString, CType(tDataTable.Rows(0).Item(7), Date).ToShortDateString, CType(tDataTable.Rows(0).Item(8), Double).ToString("C2"), CType(tDataTable.Rows(0).Item(9), Double).ToString("C2"), CType(tDataTable.Rows(0).Item(10), Double).ToString("P"), CType(tDataTable.Rows(0).Item(11), Double).ToString("C2"), CType(tDataTable.Rows(0).Item(12), Date).ToShortDateString, CType(tDataTable.Rows(0).Item(13), Double).ToString("C2"), CType(tDataTable.Rows(0).Item(14), Date).ToShortDateString)
            Next
            Dim tLoanID As Integer = Database.QueryReturnInteger("SELECT DISTINCT [LoanID] FROM [dtb_LoanBalances] WHERE [BalanceID]=" + tBalanceID.ToString + ";")
            Dim tBalancesCount As Integer = Database.QueryReturnInteger("SELECT COUNT(*) FROM [dtb_LoanBalances] WHERE [LoanID]=" + tLoanID.ToString + " AND [PaymentStatus]=0;")

            'check if only 1 unpaid
            If tBalancesCount = 1 Then
                'update whole loan
                Dim vReportForm2 As New ReportForm
                Dim rLoanLoanFullyPaid As New LoanLoanFullyPaid
                rLoanLoanFullyPaid.Database.Tables(0).SetDataSource(tNewDataTable)
                vReportForm2.ReportContainer.ReportSource = rLoanLoanFullyPaid
                vReportForm2.ReportContainer.Refresh()
                vReportForm2.Show()
                'update payment status and payment date
                Database.Insert("UPDATE [dtb_LoanBalances] SET [PaymentStatus]=1,[PaymentDate]='" + Date.Now.ToShortDateString + "' WHERE [BalanceID]=" + tBalanceID.ToString + ";", False)
                'reduce remaining balance and update whole loan status
                Database.Insert("UPDATE [dtb_Loans] SET [RemainingBalance]=" + tDataTable.Rows(0).Item(13).ToString + ", [LoanStatus]=1, [PaymentDate]='" + Date.Now.ToShortDateString + "' WHERE [LoanID]=" + tLoanID.ToString + ";", False)
            Else
                'update month
                Dim vReportForm As New ReportForm
                Dim rLoanBalancePayment As New LoanBalancePayment
                rLoanBalancePayment.Database.Tables(0).SetDataSource(tNewDataTable)
                'LoanCalculationBreakdownDetailsReport.Subreports.Item(0).Database.Tables(0).SetDataSource(crDetails)
                vReportForm.ReportContainer.ReportSource = rLoanBalancePayment
                vReportForm.ReportContainer.Refresh()
                vReportForm.Show()
                'update payment status and payment date
                Database.Insert("UPDATE [dtb_LoanBalances] SET [PaymentStatus]=1,[PaymentDate]='" + Date.Now.ToShortDateString + "' WHERE [BalanceID]=" + tBalanceID.ToString + ";", False)
                'reduce remaining balance
                Database.Insert("UPDATE [dtb_Loans] SET [RemainingBalance]=" + tDataTable.Rows(0).Item(13).ToString + " WHERE [LoanID]=" + tLoanID.ToString + ";", False)
            End If
            Me.Close()
        Else
            InformationMessage("Please select a balance entry.", "")
        End If
    End Sub
End Class