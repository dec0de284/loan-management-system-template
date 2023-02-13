Public Class YearlyReportFormFilter
    'Public ClientID As String
    'Public ClientName As String
    Private tDataTable As DataTable
    Private SelectedYear As String = ""
    Private TotalYearGain As Double
    Private tReportDataTable As DataTable

    Private Sub EditDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'filling combobox choices
        tDataTable = New DataTable
        tDataTable = Database.QueryReturnDataTable("SELECT DISTINCT Year([PaymentDate]) FROM [dtb_LoanBalances] WHERE [PaymentStatus]=1 ORDER BY Year([PaymentDate]) DESC;")
        For tableRows As Integer = 0 To (tDataTable.Rows.Count - 1)
            ComboBox1.Items.Add(tDataTable.Rows(tableRows)(0).ToString)
        Next
        ComboBox1.Text = ComboBox1.Items(0).ToString
        ComboBox1.SelectedIndex = 0
        SelectedYear = ComboBox1.Items(ComboBox1.SelectedIndex).ToString
        tDataTable = New DataTable
        tDataTable = Database.PopulateDataTable("SELECT [dtb_LoanBalances].PaymentDate AS [Payment Date], [dtb_Clients].ClientName AS [Name], [dtb_LoanBalances].MonthGain AS [Interest Gained] FROM (([dtb_Loans] INNER JOIN [dtb_LoanBalances] ON [dtb_Loans].LoanID = [dtb_LoanBalances].LoanID) INNER JOIN [dtb_Clients] ON [dtb_Loans].ClientID = [dtb_Clients].ClientID) WHERE [dtb_LoanBalances].PaymentStatus=1 AND [dtb_LoanBalances].PaymentDate BETWEEN #1/1/" + SelectedYear + "# AND #12/31/" + SelectedYear + "# ORDER BY [dtb_LoanBalances].PaymentDate ASC;")
        TotalYearGain = 0
        For dataTableRows As Integer = 0 To (tDataTable.Rows.Count - 1)
            TotalYearGain = TotalYearGain + Math.Round(CType(tDataTable.Rows(dataTableRows)(2), Double), 2)
        Next
        Dim nDataTable As New DataTable
        nDataTable.Columns.Add("Date", GetType(String))
        nDataTable.Columns.Add("Name", GetType(String))
        nDataTable.Columns.Add("Gain", GetType(String))
        For itemRow As Integer = 0 To (tDataTable.Rows.Count - 1)
            nDataTable.Rows.Add(CType(tDataTable.Rows(itemRow)(0), Date).ToShortDateString, tDataTable.Rows(itemRow)(1), FormatCurrency(tDataTable.Rows(itemRow)(2), 2))
        Next
        tReportDataTable = nDataTable
        SystemAccountsTable.DataSource = nDataTable
        Dim pDataGridViewAutoSizeColumnMode As DataGridViewAutoSizeColumnMode() = New DataGridViewAutoSizeColumnMode() {DataGridViewAutoSizeColumnMode.DisplayedCells, DataGridViewAutoSizeColumnMode.Fill, DataGridViewAutoSizeColumnMode.DisplayedCells}
        For i As Integer = 0 To (SystemAccountsTable.ColumnCount - 1)
            SystemAccountsTable.Columns.Item(i).Resizable = DataGridViewTriState.False
            SystemAccountsTable.Columns.Item(i).SortMode = DataGridViewColumnSortMode.NotSortable
            SystemAccountsTable.Columns.Item(i).AutoSizeMode = pDataGridViewAutoSizeColumnMode(i)
        Next
    End Sub

    Private Sub btn_AddCapitalShare_Click(sender As Object, e As EventArgs) Handles btn_GenerateReport.Click
        tDataTable = New DataTable
        tDataTable = Database.PopulateDataTable("SELECT DISTINCT dtb_Clients.ClientName, Sum(dtb_LoanBalances.[MonthGain]) AS MonthGainOfSum FROM (dtb_Clients INNER JOIN dtb_Loans ON dtb_Clients.ClientID = dtb_Loans.ClientID) INNER JOIN dtb_LoanBalances ON dtb_Loans.LoanID = dtb_LoanBalances.LoanID WHERE (((dtb_LoanBalances.PaymentStatus)=1) AND ((dtb_LoanBalances.PaymentDate) Between #1/1/" + SelectedYear + "# And #12/31/" + SelectedYear + "#)) GROUP BY dtb_Clients.ClientName ORDER BY dtb_Clients.ClientName;")
        Dim nDataTable As New DataTable
        nDataTable.Columns.Add("Name", GetType(String))
        nDataTable.Columns.Add("GainSum", GetType(String))
        For itemRow As Integer = 0 To (tDataTable.Rows.Count - 1)
            nDataTable.Rows.Add(tDataTable.Rows(itemRow)(0), FormatCurrency(tDataTable.Rows(itemRow)(1), 2))
        Next
        Dim vReportForm As New ReportForm
        Dim rYearlyReport As New YearlyReport
        rYearlyReport.Database.Tables(0).SetDataSource(tReportDataTable)
        rYearlyReport.Subreports.Item(0).Database.Tables(0).SetDataSource(nDataTable)
        vReportForm.ReportContainer.ReportSource = rYearlyReport
        vReportForm.ReportContainer.Refresh()
        vReportForm.Show()
    End Sub

    Private Sub ComboBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ComboBox1.KeyPress
        e.Handled = True
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        SelectedYear = ComboBox1.Items(ComboBox1.SelectedIndex).ToString
        tDataTable = New DataTable
        tDataTable = Database.PopulateDataTable("SELECT [dtb_LoanBalances].PaymentDate AS [Payment Date], [dtb_Clients].ClientName AS [Name], [dtb_LoanBalances].MonthGain AS [Interest Gained] FROM (([dtb_Loans] INNER JOIN [dtb_LoanBalances] ON [dtb_Loans].LoanID = [dtb_LoanBalances].LoanID) INNER JOIN [dtb_Clients] ON [dtb_Loans].ClientID = [dtb_Clients].ClientID) WHERE [dtb_LoanBalances].PaymentStatus=1 AND [dtb_LoanBalances].PaymentDate BETWEEN #1/1/" + SelectedYear + "# AND #12/31/" + SelectedYear + "# ORDER BY [dtb_LoanBalances].PaymentDate ASC;")
        For dataTableRows As Integer = 0 To (tDataTable.Rows.Count - 1)
            TotalYearGain = TotalYearGain + Math.Round(CType(tDataTable.Rows(dataTableRows)(2), Double), 2)
        Next
        Dim nDataTable As New DataTable
        nDataTable.Columns.Add("Date", GetType(String))
        nDataTable.Columns.Add("Name", GetType(String))
        nDataTable.Columns.Add("Gain", GetType(String))
        For itemRow As Integer = 0 To (tDataTable.Rows.Count - 1)
            nDataTable.Rows.Add(CType(tDataTable.Rows(itemRow)(0), Date).ToShortDateString, tDataTable.Rows(itemRow)(1), FormatCurrency(tDataTable.Rows(itemRow)(2), 2))
        Next
        tReportDataTable = nDataTable
        SystemAccountsTable.DataSource = nDataTable
        Dim pDataGridViewAutoSizeColumnMode As DataGridViewAutoSizeColumnMode() = New DataGridViewAutoSizeColumnMode() {DataGridViewAutoSizeColumnMode.DisplayedCells, DataGridViewAutoSizeColumnMode.Fill, DataGridViewAutoSizeColumnMode.DisplayedCells}
        For i As Integer = 0 To (SystemAccountsTable.ColumnCount - 1)
            SystemAccountsTable.Columns.Item(i).Resizable = DataGridViewTriState.False
            SystemAccountsTable.Columns.Item(i).SortMode = DataGridViewColumnSortMode.NotSortable
            SystemAccountsTable.Columns.Item(i).AutoSizeMode = pDataGridViewAutoSizeColumnMode(i)
        Next
    End Sub
End Class