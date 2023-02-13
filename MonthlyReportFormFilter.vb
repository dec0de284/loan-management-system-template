Public Class MonthlyReportFormFilter
    'Public ClientID As String
    'Public ClientName As String
    Private tDataTable As DataTable
    Private SelectedYear As String = ""
    Private SelectedMonth As String = ""
    Private TotalYearGain As Double
    Private tReportDataTable As DataTable
    Private tLoadedStatus As Boolean = True

    Private Function MonthIntToString(ByVal pIntMonth As Integer) As String
        Select Case pIntMonth
            Case 1
                Return "January"
            Case 2
                Return "February"
            Case 3
                Return "March"
            Case 4
                Return "April"
            Case 5
                Return "May"
            Case 6
                Return "June"
            Case 7
                Return "July"
            Case 8
                Return "August"
            Case 9
                Return "September"
            Case 10
                Return "October"
            Case 11
                Return "November"
            Case 12
                Return "December"
            Case Else
                Return ""
        End Select
    End Function

    Private Function MonthStringToInt(ByVal pStringMonth As String) As Integer
        Select Case pStringMonth
            Case "January"
                Return 1
            Case "February"
                Return 2
            Case "March"
                Return 3
            Case "April"
                Return 4
            Case "May"
                Return 5
            Case "June"
                Return 6
            Case "July"
                Return 7
            Case "August"
                Return 8
            Case "September"
                Return 9
            Case "October"
                Return 10
            Case "November"
                Return 11
            Case "December"
                Return 12
            Case Else
                Return 0
        End Select
    End Function

    Private Sub EditDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'filling combobox choices
        tDataTable = New DataTable
        tDataTable = Database.QueryReturnDataTable("SELECT DISTINCT Year([PaymentDate]) FROM [dtb_LoanBalances] WHERE [PaymentStatus]=1 ORDER BY Year([PaymentDate]) DESC;")
        For tableRows As Integer = 0 To (tDataTable.Rows.Count - 1)
            ComboBox1.Items.Add(tDataTable.Rows(tableRows)(0).ToString)
        Next
        ComboBox1.Text = ComboBox1.Items(0).ToString
        ComboBox1.SelectedIndex = 0

        tDataTable = New DataTable
        SelectedYear = ComboBox1.Items(ComboBox1.SelectedIndex).ToString
        tDataTable = Database.QueryReturnDataTable("SELECT DISTINCT Month([PaymentDate]) FROM [dtb_LoanBalances] WHERE [PaymentStatus]=1 AND [PaymentDate] BETWEEN #1/1/" + SelectedYear + "# AND #12/31/" + SelectedYear + "# ORDER BY Month([PaymentDate]) ASC;")
        For tableRows As Integer = 0 To (tDataTable.Rows.Count - 1)
            ComboBox2.Items.Add(MonthIntToString(CType(tDataTable.Rows(tableRows)(0), Integer)))
        Next
        ComboBox2.Text = ComboBox2.Items(0).ToString
        ComboBox2.SelectedIndex = 0
        tLoadedStatus = False
        SelectedMonth = ComboBox2.Items(ComboBox2.SelectedIndex).ToString
        Dim tLastDate As Integer = Date.DaysInMonth(CType(SelectedYear, Integer), MonthStringToInt(SelectedMonth))
        tDataTable = New DataTable
        tDataTable = Database.PopulateDataTable("SELECT [dtb_LoanBalances].PaymentDate AS [Payment Date], [dtb_Clients].ClientName AS [Name], [dtb_LoanBalances].MonthGain AS [Interest Gained] FROM (([dtb_Loans] INNER JOIN [dtb_LoanBalances] ON [dtb_Loans].LoanID = [dtb_LoanBalances].LoanID) INNER JOIN [dtb_Clients] ON [dtb_Loans].ClientID = [dtb_Clients].ClientID) WHERE [dtb_LoanBalances].PaymentStatus=1 AND [dtb_LoanBalances].PaymentDate BETWEEN #" + MonthStringToInt(SelectedMonth).ToString + "/1/" + SelectedYear + "# AND #" + MonthStringToInt(SelectedMonth).ToString + "/" + tLastDate.ToString + "/" + SelectedYear + "# ORDER BY [dtb_LoanBalances].PaymentDate ASC;")
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
        Dim tLastDate As Integer = Date.DaysInMonth(CType(SelectedYear, Integer), MonthStringToInt(SelectedMonth))
        tDataTable = Database.PopulateDataTable("SELECT DISTINCT dtb_Clients.ClientName, Sum(dtb_LoanBalances.[MonthGain]) AS MonthGainOfSum FROM (dtb_Clients INNER JOIN dtb_Loans ON dtb_Clients.ClientID = dtb_Loans.ClientID) INNER JOIN dtb_LoanBalances ON dtb_Loans.LoanID = dtb_LoanBalances.LoanID WHERE (((dtb_LoanBalances.PaymentStatus)=1) AND ((dtb_LoanBalances.PaymentDate) Between #" + MonthStringToInt(SelectedMonth).ToString + "/1/" + SelectedYear + "# And #" + MonthStringToInt(SelectedMonth).ToString + "/" + tLastDate.ToString + "/" + SelectedYear + "#)) GROUP BY dtb_Clients.ClientName ORDER BY dtb_Clients.ClientName;")
        Dim nDataTable As New DataTable
        nDataTable.Columns.Add("Name", GetType(String))
        nDataTable.Columns.Add("GainSum", GetType(String))
        For itemRow As Integer = 0 To (tDataTable.Rows.Count - 1)
            nDataTable.Rows.Add(tDataTable.Rows(itemRow)(0), FormatCurrency(tDataTable.Rows(itemRow)(1), 2))
        Next
        Dim nDataTable2 As New DataTable
        nDataTable2.Columns.Add("DateString")
        nDataTable2.Rows.Add(SelectedMonth + " " + SelectedYear)
        Dim vReportForm As New ReportForm
        Dim rMonthlyReport As New MonthlyReport
        rMonthlyReport.Database.Tables(0).SetDataSource(tReportDataTable)
        rMonthlyReport.Subreports.Item(0).Database.Tables(0).SetDataSource(nDataTable)
        rMonthlyReport.Subreports.Item(1).Database.Tables(0).SetDataSource(nDataTable2)
        vReportForm.ReportContainer.ReportSource = rMonthlyReport
        vReportForm.ReportContainer.Refresh()
        vReportForm.Show()
    End Sub

    Private Sub ComboBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ComboBox1.KeyPress
        e.Handled = True
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If tLoadedStatus = False Then
            SelectedYear = ComboBox1.Items(ComboBox1.SelectedIndex).ToString
            ComboBox2.Items.Clear()
            SelectedMonth = ""
            tDataTable = New DataTable
            tDataTable = Database.QueryReturnDataTable("SELECT DISTINCT Month([PaymentDate]) FROM [dtb_LoanBalances] WHERE [PaymentStatus]=1 AND [PaymentDate] BETWEEN #1/1/" + SelectedYear + "# AND #12/31/" + SelectedYear + "# ORDER BY Month([PaymentDate]) ASC;")
            For tableRows As Integer = 0 To (tDataTable.Rows.Count - 1)
                ComboBox2.Items.Add(MonthIntToString(CType(tDataTable.Rows(tableRows)(0), Integer)))
            Next
            ComboBox2.Text = ComboBox2.Items(0).ToString
            ComboBox2.SelectedIndex = 0
            SelectedMonth = ComboBox2.Items(ComboBox2.SelectedIndex).ToString

            Dim tLastDate As Integer = Date.DaysInMonth(CType(SelectedYear, Integer), MonthStringToInt(SelectedMonth))
            tDataTable = New DataTable
            tDataTable = Database.PopulateDataTable("SELECT [dtb_LoanBalances].PaymentDate AS [Payment Date], [dtb_Clients].ClientName AS [Name], [dtb_LoanBalances].MonthGain AS [Interest Gained] FROM (([dtb_Loans] INNER JOIN [dtb_LoanBalances] ON [dtb_Loans].LoanID = [dtb_LoanBalances].LoanID) INNER JOIN [dtb_Clients] ON [dtb_Loans].ClientID = [dtb_Clients].ClientID) WHERE [dtb_LoanBalances].PaymentStatus=1 AND [dtb_LoanBalances].PaymentDate BETWEEN #" + MonthStringToInt(SelectedMonth).ToString + "/1/" + SelectedYear + "# AND #" + MonthStringToInt(SelectedMonth).ToString + "/" + tLastDate.ToString + "/" + SelectedYear + "# ORDER BY [dtb_LoanBalances].PaymentDate ASC;")
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
        End If
    End Sub

    Private Sub ComboBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ComboBox2.KeyPress
        e.Handled = True
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        If tLoadedStatus = False Then
            SelectedMonth = ComboBox2.Items(ComboBox2.SelectedIndex).ToString
            Dim tLastDate As Integer = Date.DaysInMonth(CType(SelectedYear, Integer), MonthStringToInt(SelectedMonth))
            tDataTable = New DataTable
            tDataTable = Database.PopulateDataTable("SELECT [dtb_LoanBalances].PaymentDate AS [Payment Date], [dtb_Clients].ClientName AS [Name], [dtb_LoanBalances].MonthGain AS [Interest Gained] FROM (([dtb_Loans] INNER JOIN [dtb_LoanBalances] ON [dtb_Loans].LoanID = [dtb_LoanBalances].LoanID) INNER JOIN [dtb_Clients] ON [dtb_Loans].ClientID = [dtb_Clients].ClientID) WHERE [dtb_LoanBalances].PaymentStatus=1 AND [dtb_LoanBalances].PaymentDate BETWEEN #" + MonthStringToInt(SelectedMonth).ToString + "/1/" + SelectedYear + "# AND #" + MonthStringToInt(SelectedMonth).ToString + "/" + tLastDate.ToString + "/" + SelectedYear + "# ORDER BY [dtb_LoanBalances].PaymentDate ASC;")
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
        End If
    End Sub
End Class