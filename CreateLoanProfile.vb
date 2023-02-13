Imports System.Text.RegularExpressions
Public Class CreateLoanProfile
    Private tempDataTable As New DataTable

    Private Sub btn_NextStep2_Click(sender As Object, e As EventArgs) Handles btn_NextStep2.Click
        If tb_ProfileName.Text <> "" Then
            LoanRateProfile.ProfileName = tb_ProfileName.Text
            tc_ProfileCreationProcess.SelectedIndex = 1
        Else
            ErrorMessage("Profile name can't be empty!", "Error")
        End If

    End Sub

    Private Sub btn_BackStep1_Click(sender As Object, e As EventArgs) Handles btn_BackStep1.Click
        tc_ProfileCreationProcess.SelectedIndex = 0
    End Sub

    Private Sub btn_BackStep2_Click(sender As Object, e As EventArgs) Handles btn_BackStep2.Click
        tc_ProfileCreationProcess.SelectedIndex = 1
    End Sub

    Private Sub btn_NextStep3_Click(sender As Object, e As EventArgs) Handles btn_NextStep3.Click
        If Regex.IsMatch(tb_InterestRate.Text, "^\d+(.\d+){0,1}$") And InterestRateGrid.RowCount > 0 Then
            tc_ProfileCreationProcess.SelectedIndex = 2
        ElseIf InterestRateGrid.RowCount = 0 Then
            ErrorMessage("At least one Interest Rate is required!", "Insufficient Input")
        Else
            ErrorMessage("Enter valid Interest Rate!", "Invalid Value")
            'tb_InterestRate.Text = decimalOnly.Replace(tb_InterestRate.Text, "")
        End If
    End Sub

    Private Sub CreateLoanProfile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Database.QueryReturnInteger("SELECT COUNT(*) FROM dtb_LoanRateProfile;") > 0 Then
            'if the profile table is not empty, get last element
            Dim LastID As String = Database.QueryReturnString("SELECT TOP 1 ProfileID FROM dtb_LoanRateProfile ORDER BY ProfileID DESC;")
            Dim digitsOnly As Regex = New Regex("[^\d]")
            Dim NewID As Integer = CType(digitsOnly.Replace(LastID, ""), Integer) + 1
            lbl_ID.Text = "ID: PF-" + NewID.ToString
            LoanRateProfile.ProfileID = "PF-" + NewID.ToString
        Else
            'if the profile table is EMPTY
            lbl_ID.Text = "ID: PF-1"
            LoanRateProfile.ProfileID = "PF-1"
        End If
    End Sub

    Private Sub tb_ProfileName_TextChanged(sender As Object, e As EventArgs) Handles tb_ProfileName.TextChanged
        Dim noComma As Regex = New Regex("[']")
        tb_ProfileName.Text = noComma.Replace(tb_ProfileName.Text, "")
    End Sub

    Private Sub tb_ProfileName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tb_ProfileName.KeyPress
        If e.KeyChar = "'" Then
            e.Handled = True
        End If
    End Sub

    Private Sub tb_InterestRate_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tb_InterestRate.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso Not e.KeyChar = "." Then
            e.Handled = True
        End If
        If (tb_InterestRate.Text.IndexOf(".") >= 0 And e.KeyChar = ".") Then e.Handled = True

    End Sub


    Private Sub btn_AddInterestRate_Click(sender As Object, e As EventArgs) Handles btn_AddInterestRate.Click
        If Regex.IsMatch(tb_InterestRate.Text, "^\d+(.\d+){0,1}$") Then
            Dim errorOccured As Boolean = False
            If InterestRateGrid.Rows.Count > 0 Then
                Dim digitsOnly As Regex = New Regex("[%]")
                For Each rows As DataGridViewRow In InterestRateGrid.Rows
                    If CType(digitsOnly.Replace(rows.Cells.Item(0).Value.ToString, ""), Double) = CType(tb_InterestRate.Text, Double) Then
                        errorOccured = True
                        Exit For
                    End If
                Next
            End If

            If errorOccured Then
                ErrorMessage("The interest rate already exists!", "Duplicate Entry")
            Else
                Dim percentage As Double = CType(tb_InterestRate.Text, Double)
                percentage = percentage / 100
                InterestRateGrid.Rows.Add(percentage.ToString("#0.00%"))
            End If
        Else
            ErrorMessage("Enter valid Interest Rate!", "Invalid Value")
        End If
    End Sub

    Private Sub InterestRateGrid_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles InterestRateGrid.CellClick
        If InterestRateGrid.RowCount > 0 Then
            Dim noPercentSign As Regex = New Regex("[%]")
            tb_InterestRate.Text = noPercentSign.Replace(InterestRateGrid.SelectedCells.Item(0).Value.ToString, "")

        End If
    End Sub

    Private Sub btn_EditInterestRate_Click(sender As Object, e As EventArgs) Handles btn_EditInterestRate.Click
        If Regex.IsMatch(tb_InterestRate.Text, "^\d+(.\d+){0,1}$") Then
            Dim errorOccured As Boolean = False
            If InterestRateGrid.Rows.Count > 0 Then
                Dim digitsOnly As Regex = New Regex("[%]")
                For Each rows As DataGridViewRow In InterestRateGrid.Rows
                    If CType(digitsOnly.Replace(rows.Cells.Item(0).Value.ToString, ""), Double) = CType(tb_InterestRate.Text, Double) Then
                        errorOccured = True
                        Exit For
                    End If
                Next
            End If

            If errorOccured Then
                ErrorMessage("The interest rate already exists!", "Duplicate Entry")
            Else
                Dim percentage As Double = CType(tb_InterestRate.Text, Double)
                percentage = percentage / 100
                InterestRateGrid.SelectedRows.Item(0).SetValues(percentage.ToString("#0.00%"))
            End If
        Else
            ErrorMessage("Enter valid Interest Rate!", "Invalid Value")
        End If
    End Sub

    Private Sub btn_DeleteInterestRate_Click(sender As Object, e As EventArgs) Handles btn_DeleteInterestRate.Click
        If InterestRateGrid.RowCount > 0 Then
            InterestRateGrid.Rows.RemoveAt(InterestRateGrid.SelectedRows.Item(0).Index)
        End If


    End Sub

    Private Sub tb_LoanDuration_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tb_LoanDuration.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub tb_LoanDuration_TextChanged(sender As Object, e As EventArgs) Handles tb_LoanDuration.TextChanged
        Dim digitsOnly As Regex = New Regex("[^\d]")
        tb_LoanDuration.Text = digitsOnly.Replace(tb_LoanDuration.Text, "")
    End Sub

    Private Sub btn_Submit_Click(sender As Object, e As EventArgs) Handles btn_Submit.Click
        If dgv_LoanDuration.RowCount = 0 Then
            ErrorMessage("At least one Loan Duration is required!", "Insufficient Input")
        Else
            Dim confirmationString As String
            confirmationString = Environment.NewLine + "Are you sure that you want to add the following details?" + Environment.NewLine + Environment.NewLine + "Profile Name: " + tb_ProfileName.Text + Environment.NewLine + Environment.NewLine + "Interest(s):" + Environment.NewLine
            ReDim LoanRateProfile.InterestRate(InterestRateGrid.RowCount - 1)
            Dim interestIndex As Integer = 0
            Dim decimalOnly As Regex = New Regex("[%]")
            For Each rows As DataGridViewRow In InterestRateGrid.Rows
                confirmationString = confirmationString + rows.Cells.Item(0).Value.ToString() + Environment.NewLine
                LoanRateProfile.InterestRate(interestIndex) = decimalOnly.Replace(rows.Cells.Item(0).Value.ToString(), "")
                interestIndex = interestIndex + 1
            Next
            confirmationString = confirmationString + Environment.NewLine + "Loan Duration(s):" + Environment.NewLine
            'Month/Year Counter
            Dim monthCount As Integer = 0
            Dim yearCount As Integer = 0
            For Each rows As DataGridViewRow In dgv_LoanDuration.Rows
                If rows.Cells.Item(1).Value.ToString().Contains("Month") Then
                    monthCount = monthCount + 1
                ElseIf rows.Cells.Item(1).Value.ToString().Contains("Year") Then
                    yearCount = yearCount + 1
                End If
                'confirmationString = confirmationString + rows.Cells.Item(0).Value.ToString() + " " + rows.Cells.Item(1).Value.ToString() + Environment.NewLine
            Next
            ReDim LoanRateProfile.MonthDuration(monthCount - 1)
            ReDim LoanRateProfile.YearDuration(yearCount - 1)
            Dim monthDurationIndex As Integer = 0
            Dim yearDurationIndex As Integer = 0
            For Each rows As DataGridViewRow In dgv_LoanDuration.Rows
                confirmationString = confirmationString + rows.Cells.Item(0).Value.ToString() + " " + rows.Cells.Item(1).Value.ToString() + Environment.NewLine
                If rows.Cells.Item(1).Value.ToString().Contains("Month") Then
                    LoanRateProfile.MonthDuration(monthDurationIndex) = rows.Cells.Item(0).Value.ToString()
                    monthDurationIndex = monthDurationIndex + 1
                ElseIf rows.Cells.Item(1).Value.ToString().Contains("Year") Then
                    LoanRateProfile.YearDuration(yearDurationIndex) = rows.Cells.Item(0).Value.ToString()
                    yearDurationIndex = yearDurationIndex + 1
                End If
            Next
            If MessageBox.Show(confirmationString, "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                If Database.QueryReturnInteger("SELECT COUNT(*) FROM dtb_LoanRateProfile WHERE ProfileName='" + LoanRateProfile.ProfileName + "';") = 0 Then
                    Database.Insert("INSERT INTO dtb_LoanRateProfile ([ProfileID], [ProfileName]) VALUES('" + LoanRateProfile.ProfileID + "','" + LoanRateProfile.ProfileName + "');", False)

                    For Each interestRate As String In LoanRateProfile.InterestRate
                        Database.Insert("INSERT INTO dtb_LoanInterestProfile ([ProfileID], [InterestRate]) VALUES('" + LoanRateProfile.ProfileID + "'," + interestRate + ");", False)
                    Next

                    If LoanRateProfile.MonthDuration.Count > 0 Then
                        For Each monthDuration As String In LoanRateProfile.MonthDuration
                            Database.Insert("INSERT INTO dtb_LoanMonthProfile ([ProfileID], [MonthDuration]) VALUES('" + LoanRateProfile.ProfileID + "'," + monthDuration + ");", False)
                        Next
                    End If
                    If LoanRateProfile.YearDuration.Count > 0 Then
                        For Each yearDuration As String In LoanRateProfile.YearDuration
                            Database.Insert("INSERT INTO dtb_LoanYearProfile ([ProfileID], [YearDuration]) VALUES('" + LoanRateProfile.ProfileID + "'," + yearDuration + ");", False)
                        Next
                    End If
                    MessageBox.Show("Successfully Added!", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.Close()
                Else
                    ErrorMessage("Profile already exists!", "Duplicate Entry")
                End If
            End If
        End If
    End Sub

    Private Sub btn_AddLoanDuration_Click(sender As Object, e As EventArgs) Handles btn_AddLoanDuration.Click
        'Validation
        Dim ErrorString As String = ""
        Dim ErrorOccured As Boolean = False

        If tb_LoanDuration.Text = "" Then
            ErrorOccured = True
            ErrorString = ErrorString + Environment.NewLine + "Error: NO INPUT GIVEN!" + Environment.NewLine + "Please enter loan duration in the textbox."
        ElseIf CType(tb_LoanDuration.Text, Integer) = 0 Then
            ErrorOccured = True
            ErrorString = ErrorString + Environment.NewLine + "Error: ZERO VALUE INPUT GIVEN!" + Environment.NewLine + "Zero Loan Duration is not allowed."
        End If
        If ErrorOccured Then
            ErrorMessage(ErrorString, "Error")
        Else

            Dim tempDataGridRow As New DataGridViewRow()
            tempDataGridRow.CreateCells(dgv_LoanDuration)

            If rb_VarietyMonth.Checked Then
                Dim monthTextField As String = "Month"
                If CType(tb_LoanDuration.Text, Integer) > 1 Then
                    monthTextField = monthTextField + "s"
                End If
                tempDataGridRow.Cells(0).Value = tb_LoanDuration.Text
                tempDataGridRow.Cells(1).Value = monthTextField
            ElseIf rb_VarietyYear.Checked Then
                Dim yearTextField As String = "Year"
                If CType(tb_LoanDuration.Text, Integer) > 1 Then
                    yearTextField = yearTextField + "s"
                End If
                tempDataGridRow.Cells(0).Value = tb_LoanDuration.Text
                tempDataGridRow.Cells(1).Value = yearTextField
            End If
            Dim errorHappened As Boolean = False
            If dgv_LoanDuration.Rows.Count > 0 Then
                For Each rows As DataGridViewRow In dgv_LoanDuration.Rows
                    If rows.Cells(0).Value.ToString = tempDataGridRow.Cells(0).Value.ToString And rows.Cells(1).Value.ToString = tempDataGridRow.Cells(1).Value.ToString Then
                        errorHappened = True
                        Exit For
                    End If
                Next
            End If

            If errorHappened Then
                ErrorMessage("The loan duration already exists!", "Duplicate Entry")
            Else
                dgv_LoanDuration.Rows.Add(tempDataGridRow)
                'dgv_LoanDuration.DataSource = tempDataTable
            End If
        End If

    End Sub

    Private Sub btn_EditLoanDuration_Click(sender As Object, e As EventArgs) Handles btn_EditLoanDuration.Click
        'Validation
        Dim ErrorString As String = ""
        Dim ErrorOccured As Boolean = False

        If tb_LoanDuration.Text = "" Then
            ErrorOccured = True
            ErrorString = ErrorString + Environment.NewLine + "Error: NO INPUT GIVEN!" + Environment.NewLine + "Please enter loan duration in the textbox."
        ElseIf CType(tb_LoanDuration.Text, Integer) = 0 Then
            ErrorOccured = True
            ErrorString = ErrorString + Environment.NewLine + "Error: ZERO VALUE INPUT GIVEN!" + Environment.NewLine + "Zero Loan Duration is not allowed."
        End If
        If ErrorOccured Then
            ErrorMessage(ErrorString, "Error")
        Else
            Dim errorHappened As Boolean = False
            If dgv_LoanDuration.Rows.Count > 0 Then
                Dim comparisonString As String = ""
                If rb_VarietyMonth.Checked Then
                    Dim monthTextField As String = "Month"
                    If CType(tb_LoanDuration.Text, Integer) > 1 Then
                        monthTextField = monthTextField + "s"
                    End If
                    comparisonString = monthTextField
                ElseIf rb_VarietyYear.Checked Then
                    Dim yearTextField As String = "Year"
                    If CType(tb_LoanDuration.Text, Integer) > 1 Then
                        yearTextField = yearTextField + "s"
                    End If
                    comparisonString = yearTextField
                End If
                For Each rows As DataGridViewRow In dgv_LoanDuration.Rows
                    If CType(rows.Cells.Item(0).Value.ToString, Integer) = CType(tb_LoanDuration.Text, Integer) And rows.Cells.Item(1).Value.ToString = comparisonString Then
                        errorHappened = True
                        Exit For
                    End If
                Next
                If errorHappened Then
                    ErrorMessage("The loan duration already exists!", "Duplicate Entry")
                Else
                    dgv_LoanDuration.SelectedRows.Item(0).SetValues({tb_LoanDuration.Text, comparisonString})
                End If
            End If
            End If
    End Sub



    Private Sub CreateLoanProfile_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If MessageBox.Show("Are you sure you want to close the form?" + Environment.NewLine + "Unsaved changes will be lost.", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
            e.Cancel = True
        End If
    End Sub

    Private Sub dgv_LoanDuration_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_LoanDuration.CellClick
        If dgv_LoanDuration.RowCount > 0 Then
            Dim stringVariety As String = dgv_LoanDuration.SelectedRows.Item(0).Cells.Item(1).Value.ToString
            If stringVariety.Contains("Month") Then
                rb_VarietyMonth.Checked = True
            ElseIf stringVariety.Contains("Year") Then
                rb_VarietyYear.Checked = True
            End If
            tb_LoanDuration.Text = dgv_LoanDuration.SelectedRows.Item(0).Cells.Item(0).Value.ToString

        End If
    End Sub

    Private Sub btn_DeleteLoanDuration_Click(sender As Object, e As EventArgs) Handles btn_DeleteLoanDuration.Click
        If dgv_LoanDuration.RowCount > 0 Then
            dgv_LoanDuration.Rows.RemoveAt(dgv_LoanDuration.SelectedRows.Item(0).Index)
        End If
    End Sub

End Class