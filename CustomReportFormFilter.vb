Public Class CustomReportFormFilter
    Public ClientID As String
    Public ClientName As String
    Private tDataTable As DataTable

    Private Sub EditDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tDataTable = Database.PopulateDataTable("SELECT [dtb_LoanBalances].PaymentDate AS [Date], [dtb_Clients].ClientName AS [Name], [dtb_LoanBalances].MonthGain AS [Interest Gained] FROM (([dtb_Loans] INNER JOIN [dtb_LoanBalances] ON [dtb_Loans].LoanID = [dtb_LoanBalances].LoanID) INNER JOIN [dtb_Clients] ON [dtb_Loans].ClientID = [dtb_Clients].ClientID) WHERE [dtb_LoanBalances].PaymentStatus=1 ORDER BY [dtb_LoanBalances].PaymentDate ASC;")
        DateTimePicker1.Value = CType(tDataTable.Rows(0)(0), Date)
        DateTimePicker2.Value = CType(tDataTable.Rows(tDataTable.Rows.Count - 1)(0), Date)
        Dim nDataTable As New DataTable
        nDataTable.Columns.Add("Date", GetType(Date))
        nDataTable.Columns.Add("Name", GetType(String))
        nDataTable.Columns.Add("Interest Gain", GetType(String))
        For itemRow As Integer = 0 To (tDataTable.Rows.Count - 1)
            nDataTable.Rows.Add(tDataTable.Rows(itemRow)(0), tDataTable.Rows(itemRow)(1), FormatCurrency(tDataTable.Rows(itemRow)(2), 2))
        Next
        SystemAccountsTable.DataSource = nDataTable
        Dim pDataGridViewAutoSizeColumnMode As DataGridViewAutoSizeColumnMode() = New DataGridViewAutoSizeColumnMode() {DataGridViewAutoSizeColumnMode.DisplayedCells, DataGridViewAutoSizeColumnMode.Fill, DataGridViewAutoSizeColumnMode.DisplayedCells}
        For i As Integer = 0 To (SystemAccountsTable.ColumnCount - 1)
            SystemAccountsTable.Columns.Item(i).Resizable = DataGridViewTriState.False
            SystemAccountsTable.Columns.Item(i).SortMode = DataGridViewColumnSortMode.NotSortable
            SystemAccountsTable.Columns.Item(i).AutoSizeMode = pDataGridViewAutoSizeColumnMode(i)
        Next
    End Sub

    Private Sub btn_AddCapitalShare_Click(sender As Object, e As EventArgs) Handles btn_GenerateReport.Click

    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        tDataTable = Database.PopulateDataTable("SELECT [dtb_LoanBalances].PaymentDate AS [Date], [dtb_Clients].ClientName AS [Name], [dtb_LoanBalances].MonthGain AS [Interest Gained] FROM (([dtb_Loans] INNER JOIN [dtb_LoanBalances] ON [dtb_Loans].LoanID = [dtb_LoanBalances].LoanID) INNER JOIN [dtb_Clients] ON [dtb_Loans].ClientID = [dtb_Clients].ClientID) WHERE [dtb_LoanBalances].PaymentStatus=1 AND [dtb_LoanBalances].PaymentDate BETWEEN #" + DateTimePicker1.Value.ToShortDateString + "# AND #" + DateTimePicker2.Value.ToShortDateString + "# ORDER BY [dtb_LoanBalances].PaymentDate ASC;")
        Dim nDataTable As New DataTable
        nDataTable.Columns.Add("Date", GetType(Date))
        nDataTable.Columns.Add("Name", GetType(String))
        nDataTable.Columns.Add("Interest Gain", GetType(String))
        For itemRow As Integer = 0 To (tDataTable.Rows.Count - 1)
            nDataTable.Rows.Add(tDataTable.Rows(itemRow)(0), tDataTable.Rows(itemRow)(1), FormatCurrency(tDataTable.Rows(itemRow)(2), 2))
        Next
        SystemAccountsTable.DataSource = nDataTable
        Dim pDataGridViewAutoSizeColumnMode As DataGridViewAutoSizeColumnMode() = New DataGridViewAutoSizeColumnMode() {DataGridViewAutoSizeColumnMode.DisplayedCells, DataGridViewAutoSizeColumnMode.Fill, DataGridViewAutoSizeColumnMode.DisplayedCells}
        For i As Integer = 0 To (SystemAccountsTable.ColumnCount - 1)
            SystemAccountsTable.Columns.Item(i).Resizable = DataGridViewTriState.False
            SystemAccountsTable.Columns.Item(i).SortMode = DataGridViewColumnSortMode.NotSortable
            SystemAccountsTable.Columns.Item(i).AutoSizeMode = pDataGridViewAutoSizeColumnMode(i)
        Next
    End Sub

    Private Sub DateTimePicker2_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker2.ValueChanged
        tDataTable = Database.PopulateDataTable("SELECT [dtb_LoanBalances].PaymentDate AS [Date], [dtb_Clients].ClientName AS [Name], [dtb_LoanBalances].MonthGain AS [Interest Gained] FROM (([dtb_Loans] INNER JOIN [dtb_LoanBalances] ON [dtb_Loans].LoanID = [dtb_LoanBalances].LoanID) INNER JOIN [dtb_Clients] ON [dtb_Loans].ClientID = [dtb_Clients].ClientID) WHERE [dtb_LoanBalances].PaymentStatus=1 AND [dtb_LoanBalances].PaymentDate BETWEEN #" + DateTimePicker1.Value.ToShortDateString + "# AND #" + DateTimePicker2.Value.ToShortDateString + "# ORDER BY [dtb_LoanBalances].PaymentDate ASC;")
        Dim nDataTable As New DataTable
        nDataTable.Columns.Add("Date", GetType(Date))
        nDataTable.Columns.Add("Name", GetType(String))
        nDataTable.Columns.Add("Interest Gain", GetType(String))
        For itemRow As Integer = 0 To (tDataTable.Rows.Count - 1)
            nDataTable.Rows.Add(tDataTable.Rows(itemRow)(0), tDataTable.Rows(itemRow)(1), FormatCurrency(tDataTable.Rows(itemRow)(2), 2))
        Next
        SystemAccountsTable.DataSource = nDataTable
        Dim pDataGridViewAutoSizeColumnMode As DataGridViewAutoSizeColumnMode() = New DataGridViewAutoSizeColumnMode() {DataGridViewAutoSizeColumnMode.DisplayedCells, DataGridViewAutoSizeColumnMode.Fill, DataGridViewAutoSizeColumnMode.DisplayedCells}
        For i As Integer = 0 To (SystemAccountsTable.ColumnCount - 1)
            SystemAccountsTable.Columns.Item(i).Resizable = DataGridViewTriState.False
            SystemAccountsTable.Columns.Item(i).SortMode = DataGridViewColumnSortMode.NotSortable
            SystemAccountsTable.Columns.Item(i).AutoSizeMode = pDataGridViewAutoSizeColumnMode(i)
        Next
    End Sub
End Class