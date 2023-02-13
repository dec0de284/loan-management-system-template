Imports System.Text.RegularExpressions



Public Class LoanForm

    Public Structure Loan
        Public Amount As Double
        Public ProcessingFee As Double
        Public Interest As Double
        Public DividedAmount As Double
        Public MonthGain As Double
    End Structure
    Dim vdtb_Loans As tdtb_Loans
    Dim vtdtb_LoansBalances As tdtb_LoansBalances
    Dim vcrBreakdown As DataTable
    Dim pressedCalculate As Boolean
    Private SelectedLoanProfileIndex As Integer ' for selected loan profile

    Dim ClientReportDetails As ClientDetails
    Private ClientID As String = ""
    ReadOnly ClientName As String = ""


    Public Sub UpdateLabel()
        'Label5.Text = "Processing Fee(1%): ₱0"
        'Label6.Text = "Interest (2.5%): ₱0"
        'Label1.Text = "First Month: ₱0"
        'Label7.Text = "Interest (2.5%): ₱0"
        'Label2.Text = "Second Month: ₱0"
        'Label9.Text = "₱0"
        'Label4.Text = "Interest (2.5%): ₱0"
        'Label8.Text = "Third Month: ₱0"
        'If rb_2Months.Checked Then
        '    Label8.Visible = False
        '    Label4.Visible = False

        'ElseIf rb_3Months.Checked Then
        '    Label8.Visible = True
        '    Label4.Visible = True
        'End If
    End Sub

    Private Sub LoanForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tc_LoanProcess.SelectedIndex = 2
        pressedCalculate = False
        Database.PopulateDataGrid("SELECT [ClientID] As [ID], [ClientName] AS [Name] FROM [dtb_Clients] WHERE [Active]=1;", SystemAccountsTable, New DataGridViewAutoSizeColumnMode() {DataGridViewAutoSizeColumnMode.DisplayedCells, DataGridViewAutoSizeColumnMode.Fill})
        If SystemAccountsTable.RowCount <> 0 Then
            ClientID = SystemAccountsTable.SelectedRows(0).Cells(0).Value.ToString
        Else
            ClientID = ""
        End If

        Dim ProfileCount As Integer = Database.QueryReturnInteger("SELECT COUNT(*) FROM dtb_LoanRateProfile;")
        If ProfileCount > 0 Then
            Dim tempTable As New DataTable
            tempTable = Database.QueryReturnDataTable("SELECT [ProfileName] FROM [dtb_LoanRateProfile];")
            If ProfileCount > 1 Then
                For index As Integer = 0 To (ProfileCount - 1)
                    cb_LoanRateProfile.Items.Add(tempTable.Rows.Item(index).Item(0).ToString)
                Next
            End If
        End If
    End Sub

    Private Sub TextBox_LoanAmount_TextChanged(sender As Object, e As EventArgs) Handles tb_LoanAmount.TextChanged
        pressedCalculate = False
        Dim digitsOnly As Regex = New Regex("[^\d]")
        tb_LoanAmount.Text = digitsOnly.Replace(tb_LoanAmount.Text, "")


    End Sub

    Private Sub TextBox_LoanAmount_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tb_LoanAmount.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub Button_Calculate_Click(sender As Object, e As EventArgs) Handles btn_Calculate.Click
        pressedCalculate = True
        If tb_LoanAmount.Text <> "" Then
            'determine the iteration
            Dim rowIteration As Integer
            If cb_YearMonth.SelectedIndex = 1 Then
                If cb_DurationNumber.Items.Count > 0 Then
                    rowIteration = CType(cb_DurationNumber.Items(cb_DurationNumber.SelectedIndex), Integer) * 12
                End If
            ElseIf cb_YearMonth.SelectedIndex = 0 Then
                If cb_DurationNumber.Items.Count > 0 Then
                    rowIteration = CType(cb_DurationNumber.Items(cb_DurationNumber.SelectedIndex), Integer)
                End If
            End If
            vdtb_Loans.Mode = rowIteration
            Dim crBreakdown As New DataTable
            crBreakdown.Columns.Add("MonthAmountDue", GetType(String))
            crBreakdown.Columns.Add("MonthDueDate", GetType(String))
            crBreakdown.Columns.Add("MonthGain", GetType(Double))
            Dim tLoan As Loan
            tLoan.Amount = Math.Round(CType(tb_LoanAmount.Text, Double), 2)
            vdtb_Loans.LoanAmount = tLoan.Amount
            tLoan.ProcessingFee = tLoan.Amount * 0.01
            tLoan.Interest = CType(cb_Interest.Items(cb_Interest.SelectedIndex), Double) / 100.0
            tLoan.DividedAmount = tLoan.Amount / rowIteration
            vcrBreakdown = New DataTable
            vcrBreakdown.Columns.Add("BalanceID", GetType(Integer))
            vcrBreakdown.Columns.Add("LoanID", GetType(Integer))
            vcrBreakdown.Columns.Add("MonthAmountDue", GetType(Double))
            vcrBreakdown.Columns.Add("MonthDueDate", GetType(Date))
            vcrBreakdown.Columns.Add("MonthGain", GetType(Double))
            vcrBreakdown.Columns.Add("PaymentStatus", GetType(Integer))
            vdtb_Loans.LoanID = ReturnNextID("LoanID", "dtb_Loans")
            vtdtb_LoansBalances.BalanceID = ReturnNextID("BalanceID", "dtb_LoanBalances")
            If rowIteration > 1 Then
                For monthRow As Integer = 0 To (rowIteration - 1)
                    vtdtb_LoansBalances.MonthDueDate = Date.Now.AddMonths(monthRow + 1)
                    If monthRow = 0 Then
                        vtdtb_LoansBalances.MonthAmountDue = Math.Round(tLoan.DividedAmount + (tLoan.Amount * tLoan.Interest) + tLoan.ProcessingFee, 2)
                        vtdtb_LoansBalances.MonthGain = Math.Round((tLoan.Amount * tLoan.Interest) + tLoan.ProcessingFee, 2)
                        'totalBeforeFinalMonthGain = totalBeforeFinalMonthGain + vtdtb_LoansBalances.MonthGain
                        '(((tLoan.Amount * CType((rowIteration - monthRow), Double)) / rowIteration) * tLoan.Interest) + tLoan.ProcessingFee
                        crBreakdown.Rows.Add(vtdtb_LoansBalances.MonthAmountDue.ToString("C2"), vtdtb_LoansBalances.MonthDueDate.ToShortDateString, vtdtb_LoansBalances.MonthGain)
                        vcrBreakdown.Rows.Add(vtdtb_LoansBalances.BalanceID, vdtb_Loans.LoanID, vtdtb_LoansBalances.MonthAmountDue, vtdtb_LoansBalances.MonthDueDate, vtdtb_LoansBalances.MonthGain, 0)
                    Else
                        vtdtb_LoansBalances.BalanceID += 1
                        vtdtb_LoansBalances.MonthAmountDue = Math.Round(tLoan.DividedAmount + (((tLoan.Amount * (rowIteration - monthRow)) / rowIteration) * tLoan.Interest), 2)
                        vtdtb_LoansBalances.MonthGain = Math.Round(((tLoan.Amount * (rowIteration - monthRow)) / rowIteration) * tLoan.Interest, 2)
                        crBreakdown.Rows.Add(vtdtb_LoansBalances.MonthAmountDue.ToString("C2"), vtdtb_LoansBalances.MonthDueDate.ToShortDateString, vtdtb_LoansBalances.MonthGain)
                        vcrBreakdown.Rows.Add(vtdtb_LoansBalances.BalanceID, vdtb_Loans.LoanID, vtdtb_LoansBalances.MonthAmountDue, vtdtb_LoansBalances.MonthDueDate, vtdtb_LoansBalances.MonthGain, 0)
                    End If
                Next
            Else
                vtdtb_LoansBalances.MonthAmountDue = Math.Round(tLoan.Amount + (tLoan.Amount * tLoan.Interest) + tLoan.ProcessingFee, 2)
                vtdtb_LoansBalances.MonthGain = Math.Round((tLoan.Amount * tLoan.Interest) + tLoan.ProcessingFee, 2)
                vtdtb_LoansBalances.MonthDueDate = Date.Now.AddMonths(1)
                crBreakdown.Rows.Add(vtdtb_LoansBalances.MonthAmountDue.ToString("C2"), vtdtb_LoansBalances.MonthDueDate.ToShortDateString, vtdtb_LoansBalances.MonthGain)
                vcrBreakdown.Rows.Add(vtdtb_LoansBalances.BalanceID, vdtb_Loans.LoanID, vtdtb_LoansBalances.MonthAmountDue, vtdtb_LoansBalances.MonthDueDate, vtdtb_LoansBalances.MonthGain, 0)
            End If

            Dim crDetails As New DataTable
            crDetails.Columns.Add("ClientName", GetType(String))
            crDetails.Columns.Add("ClientAddress", GetType(String))
            crDetails.Columns.Add("ClientContactNumber", GetType(String))
            crDetails.Columns.Add("CoMakerName", GetType(String))
            crDetails.Columns.Add("CoMakerAddress", GetType(String))
            crDetails.Columns.Add("CoMakerContactNumber", GetType(String))
            crDetails.Columns.Add("LoanAmount", GetType(String))
            crDetails.Columns.Add("Mode", GetType(String))
            crDetails.Columns.Add("InterestRate", GetType(String))
            crDetails.Columns.Add("StartDate", GetType(String))
            crDetails.Columns.Add("DueDate", GetType(String))
            crDetails.Columns.Add("TotalAmount", GetType(String))
            Dim tcrDetails As New DataTable
            Dim tMode As String
            If rowIteration < 12 Then
                If rowIteration = 1 Then
                    tMode = rowIteration.ToString + " Month"
                Else
                    tMode = rowIteration.ToString + " Months"
                End If
            Else
                If rowIteration = 12 Then
                    tMode = (rowIteration / 12).ToString + " Year"
                Else
                    tMode = (rowIteration / 12).ToString + " Years"
                End If
            End If

            tcrDetails = Database.PopulateDataTable("SELECT DISTINCT [ClientName],[ClientAddress],[ClientContactNumber],[CoMakerName],[CoMakerAddress],[CoMakerContactNumber] FROM [dtb_Clients] WHERE [ClientID]=" + ClientID + ";")
            Dim tTotalAmount As Double = 0.00
            For icrBreakdownList As Integer = 0 To (crBreakdown.Rows.Count - 1)
                tTotalAmount += CType(crBreakdown.Rows(icrBreakdownList).Item(2), Double)
            Next
            vdtb_Loans.TransactionGain = Math.Round(tTotalAmount, 2)
            vdtb_Loans.StartDate = Date.Now
            vdtb_Loans.DueDate = Date.Now.AddMonths(rowIteration)
            crDetails.Rows.Add(tcrDetails.Rows(0).Item(0).ToString, tcrDetails.Rows(0).Item(1).ToString, tcrDetails.Rows(0).Item(2).ToString, tcrDetails.Rows(0).Item(3).ToString, tcrDetails.Rows(0).Item(4).ToString, tcrDetails.Rows(0).Item(5).ToString, tLoan.Amount.ToString("C2"), tMode, tLoan.Interest.ToString("P2"), vdtb_Loans.StartDate.ToShortDateString, vdtb_Loans.DueDate.ToShortDateString, (tLoan.Amount + tTotalAmount).ToString("C2"))
            Dim vReportForm As New ReportForm
            Dim LoanCalculationBreakdownDetailsReport As New LoanCalculationBreakdown
            LoanCalculationBreakdownDetailsReport.Database.Tables(0).SetDataSource(crBreakdown)
            LoanCalculationBreakdownDetailsReport.Subreports.Item(0).Database.Tables(0).SetDataSource(crDetails)
            vReportForm.ReportContainer.ReportSource = LoanCalculationBreakdownDetailsReport
            vReportForm.ReportContainer.Refresh()
            vReportForm.Show()

            'OldClientDetails.ClientName = tDataTable.Rows(0)(1).ToString
            'OldClientDetails.ClientAddress = tDataTable.Rows(0)(2).ToString
            'OldClientDetails.ClientContactNumber = tDataTable.Rows(0)(3).ToString
            'OldClientDetails.CoMakerName = tDataTable.Rows(0)(4).ToString
            'OldClientDetails.CoMakerAddress = tDataTable.Rows(0)(5).ToString
            'OldClientDetails.CoMakerContactNumber = tDataTable.Rows(0)(6).ToString

            'CalculationReportDetails
            'Dim LoanIDCount As Integer = Database.QueryReturnInteger("SELECT COUNT(*) FROM [dtb_Loans];")
            'Dim NextLoanID As Integer
            'If LoanIDCount > 0 Then
            '    NextLoanID = 1
            'Else
            '    NextLoanID = Database.QueryReturnInteger("SELECT LAST([LoanID]) FROM [dtb_Loans];")
            'End If
            'Dim vLoans As New DataTable
            'vLoans.Columns.Add("LoanID")
            'vLoans.Columns.Add("ClientID")
            'vLoans.Columns.Add("ClientID")
        Else
            ErrorMessage("Loan amount can't be empty!", "")
        End If
    End Sub

    Private Sub TextBox_SearchClientName_TextChanged(sender As Object, e As EventArgs) Handles tb_SearchClientName.TextChanged
        RegexBoxTextChanged(tb_SearchClientName, "[^a-zA-Z ]")
        If tb_SearchClientName.Text <> "" Then
            Database.PopulateDataGrid("SELECT [ClientID] As [ID], [ClientName] AS [Name] FROM [dtb_Clients] WHERE ([ClientName] LIKE '%" + tb_SearchClientName.Text + "%');", SystemAccountsTable, New DataGridViewAutoSizeColumnMode() {DataGridViewAutoSizeColumnMode.DisplayedCells, DataGridViewAutoSizeColumnMode.Fill})
            If SystemAccountsTable.Rows.Count <> 0 Then
                ClientID = SystemAccountsTable.SelectedRows(0).Cells(0).Value.ToString
            Else
                ClientID = ""
            End If
        ElseIf tb_SearchClientName.Text = "" Then
            Database.PopulateDataGrid("SELECT [ClientID] As [ID], [ClientName] AS [Name] FROM [dtb_Clients];", SystemAccountsTable, New DataGridViewAutoSizeColumnMode() {DataGridViewAutoSizeColumnMode.DisplayedCells, DataGridViewAutoSizeColumnMode.Fill})
            If SystemAccountsTable.Rows.Count <> 0 Then
                ClientID = SystemAccountsTable.SelectedRows(0).Cells(0).Value.ToString
            Else
                ClientID = ""
            End If
        End If
    End Sub

    Private Sub DataGrid_Clients_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles SystemAccountsTable.CellClick
        If SystemAccountsTable.Rows.Count <> 0 Then
            ClientID = SystemAccountsTable.SelectedRows(0).Cells(0).Value.ToString
        Else
            ClientID = ""
        End If
    End Sub

    Private Sub Label1_TextChanged(sender As Object, e As EventArgs)
        Dim windowsForm As Form
        For Each windowsForm In My.Application.OpenForms
            If windowsForm.Name Is LoanBreakDownForm.Name Then
                LoanBreakDownForm.Label1.Text = "Client ID: " + SystemAccountsTable.SelectedCells.Item(0).Value.ToString
                Exit For
            End If
        Next


    End Sub

    Private Sub Button_NextStep2_Click(sender As Object, e As EventArgs) Handles btn_NextStep2.Click
        Dim activeLoans As Integer = Database.QueryReturnInteger("SELECT COUNT(*) FROM [dtb_Loans] WHERE [ClientID]=" + vdtb_Loans.ClientID.ToString + " AND [LoanStatus]=0;")
        If activeLoans > 0 Then
            ErrorMessage("The client has active loan!", "")
        ElseIf ClientID <> "" Then
            tc_LoanProcess.SelectedIndex = 0
            vdtb_Loans.ClientID = CType(ClientID, Integer)
            lbl_ShareCapital.Text = "Share Capital: " + FormatCurrency(Database.QueryReturnString("SELECT [ShareCapital] FROM [dtb_Clients] WHERE [ClientID]=" + ClientID.ToString + ";"), 2)
        Else
            InformationMessage("Please select a client.", "")
        End If
    End Sub

    Private Sub Button_BackStep1_Click(sender As Object, e As EventArgs) Handles btn_BackStep1.Click
        tc_LoanProcess.SelectedIndex = 2
    End Sub

    Private Sub Button_NextStep3_Click(sender As Object, e As EventArgs) Handles btn_NextStep3.Click
        If cb_Interest.SelectedIndex <> -1 Then
            tc_LoanProcess.SelectedIndex = 1
            vdtb_Loans.InterestRate = CType(cb_Interest.Items(cb_Interest.SelectedIndex), Double) / 100.0
        End If


    End Sub

    Private Sub Button_BackStep2_Click(sender As Object, e As EventArgs) Handles btn_BackStep2.Click
        tc_LoanProcess.SelectedIndex = 0
    End Sub

    Private Sub ComboBox_LoanRateProfile_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_LoanRateProfile.SelectedIndexChanged
        If cb_LoanRateProfile.Text <> "" Then
            SelectedLoanProfileIndex = cb_LoanRateProfile.SelectedIndex + 1
            cb_Interest.Text = ""
            cb_Interest.Items.Clear()
            cb_DurationNumber.Text = ""
            cb_DurationNumber.Items.Clear()
            cb_DurationNumber.Enabled = False
            cb_YearMonth.Text = ""
            Dim InterestItemCount As Integer = Database.QueryReturnInteger("SELECT COUNT(*) FROM [dtb_LoanInterestProfile] WHERE [ProfileID]='PF-" + SelectedLoanProfileIndex.ToString + "';")
            If InterestItemCount > 0 Then
                Dim tempInterestTable As New DataTable
                'Database.PopulateDataGrid("SELECT DISTINCT RoleID, Username FROM SystemAccounts;", SystemAccountsTable, New DataGridViewAutoSizeColumnMode() {DataGridViewAutoSizeColumnMode.DisplayedCells, DataGridViewAutoSizeColumnMode.Fill})
                tempInterestTable = Database.QueryReturnDataTable("SELECT DISTINCT [InterestRate] FROM [dtb_LoanInterestProfile] WHERE [ProfileID]='PF-" + SelectedLoanProfileIndex.ToString + "';")
                If InterestItemCount > 1 Then
                    For interestIndex As Integer = 0 To (InterestItemCount - 1)
                        cb_Interest.Items.Add(tempInterestTable.Rows.Item(interestIndex).Item(0).ToString)
                    Next
                Else
                    cb_Interest.Items.Add(tempInterestTable.Rows.Item(0).Item(0).ToString)
                End If
            End If
        Else
            cb_Interest.Text = ""
            cb_Interest.Items.Clear()
            cb_DurationNumber.Text = ""
            cb_DurationNumber.Items.Clear()
            cb_DurationNumber.Enabled = False
            cb_YearMonth.Text = ""
        End If
    End Sub

    Private Sub ComboBox_YearMonth_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_YearMonth.SelectedIndexChanged
        If cb_YearMonth.Text <> "" Then
            cb_DurationNumber.Enabled = True
            cb_DurationNumber.Text = ""
            cb_DurationNumber.Items.Clear()
            Dim YearMonth As Integer = cb_YearMonth.SelectedIndex
            Select Case YearMonth
                Case 0
                    'month
                    Dim MonthItemCount As Integer = Database.QueryReturnInteger("SELECT COUNT(*) FROM [dtb_LoanMonthProfile] WHERE [ProfileID]='PF-" + SelectedLoanProfileIndex.ToString + "';")
                    If MonthItemCount > 0 Then
                        Dim tempMonthTable As New DataTable
                        tempMonthTable = Database.QueryReturnDataTable("SELECT DISTINCT [MonthDuration] FROM [dtb_LoanMonthProfile] WHERE [ProfileID]='PF-" + SelectedLoanProfileIndex.ToString + "';")
                        If MonthItemCount > 1 Then
                            For monthIndex As Integer = 0 To (MonthItemCount - 1)
                                cb_DurationNumber.Items.Add(tempMonthTable.Rows.Item(monthIndex).Item(0).ToString)
                            Next
                        Else
                            cb_DurationNumber.Items.Add(tempMonthTable.Rows.Item(0).Item(0).ToString)
                        End If
                    Else
                        cb_DurationNumber.Text = ""
                        cb_DurationNumber.Items.Clear()
                        cb_DurationNumber.Enabled = False
                    End If
                Case 1
                    'year
                    Dim YearItemCount As Integer = Database.QueryReturnInteger("SELECT COUNT(*) FROM [dtb_LoanYearProfile] WHERE [ProfileID]='PF-" + SelectedLoanProfileIndex.ToString + "';")
                    If YearItemCount > 0 Then
                        Dim tempYearTable As New DataTable
                        tempYearTable = Database.QueryReturnDataTable("SELECT DISTINCT [YearDuration] FROM [dtb_LoanYearProfile] WHERE [ProfileID]='PF-" + SelectedLoanProfileIndex.ToString + "';")
                        If YearItemCount > 1 Then
                            For yearIndex As Integer = 0 To (YearItemCount - 1)
                                cb_DurationNumber.Items.Add(tempYearTable.Rows.Item(yearIndex).Item(0).ToString)
                            Next
                        Else
                            cb_DurationNumber.Items.Add(tempYearTable.Rows.Item(0).Item(0).ToString)
                        End If
                    Else
                        cb_DurationNumber.Text = ""
                        cb_DurationNumber.Items.Clear()
                        cb_DurationNumber.Enabled = False
                    End If
            End Select
        Else
            cb_DurationNumber.Text = ""
            cb_DurationNumber.Items.Clear()
            cb_DurationNumber.Enabled = False
            If cb_LoanRateProfile.Text = "" Then
                InformationMessage("Please select a loan profile.", "")
            End If
        End If
    End Sub

    Private Sub Button_Submit_Click(sender As Object, e As EventArgs) Handles btn_Submit.Click
        '    
        '    Public LoanID As Integer
        '    Public ClientID As Integer
        '    Public StartDate As Date
        '    Public DueDate As Date
        '    Public InterestRate As Integer
        '    Public Mode As Integer
        '    Public LoanAmount As Integer
        '    Public RemainingBalance As Integer
        '    Public LoanStatus As Integer
        '    Public TransactionGain As Integer
        If pressedCalculate Then
            If tb_LoanAmount.Text <> "" And tb_LoanAmount.Text <> "0" Then
                'vdtb_Loans.LoanAmount =  'Math.Round(CType(tb_LoanAmount.Text, Double), 2)
                Dim tShareCapital As Integer = Database.QueryReturnInteger("SELECT [ShareCapital] FROM [dtb_Clients] WHERE [ClientID]=" + vdtb_Loans.ClientID.ToString + ";")
                Dim activeLoans As Integer = Database.QueryReturnInteger("SELECT COUNT(*) FROM [dtb_Loans] WHERE [ClientID]=" + vdtb_Loans.ClientID.ToString + " AND [LoanStatus]=0;")
                If activeLoans > 0 Then
                    ErrorMessage("The client has active loan!", "")
                ElseIf vdtb_Loans.LoanAmount > tShareCapital Then
                    ErrorMessage("Can't request a loan bigger than share capital!", "")
                Else

                    vdtb_Loans.RemainingBalance = vdtb_Loans.LoanAmount
                    vdtb_Loans.LoanStatus = 0
                    Database.InsertLoan(vdtb_Loans.LoanID, vdtb_Loans.ClientID, vdtb_Loans.StartDate, vdtb_Loans.DueDate, vdtb_Loans.InterestRate, vdtb_Loans.Mode, vdtb_Loans.LoanAmount, Math.Round(vdtb_Loans.RemainingBalance + vdtb_Loans.TransactionGain, 2), vdtb_Loans.LoanStatus, vdtb_Loans.TransactionGain)
                    For tableRow As Integer = 0 To (vcrBreakdown.Rows.Count - 1)
                        Database.InsertLoanBalance(vcrBreakdown.Rows(tableRow).Item(0), vcrBreakdown.Rows(tableRow).Item(1), vcrBreakdown.Rows(tableRow).Item(2), vcrBreakdown.Rows(tableRow).Item(3), vcrBreakdown.Rows(tableRow).Item(4), vcrBreakdown.Rows(tableRow).Item(5))
                    Next
                    InformationMessage("Added loan successfully.", "")
                    Me.Close()
                End If


            End If
        Else
            InformationMessage("Please click the 'Calculate' button first.", "")
        End If


    End Sub
End Class