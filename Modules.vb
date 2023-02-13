'

Imports System.Data.OleDb
Imports System.IO
Imports System.Text.RegularExpressions

Module Modules
    Public AdminStripMenus As ToolStripMenuItem() = New ToolStripMenuItem() {}
    Public Sub ErrorMessage(ByVal pMessage As String, ByVal pTitle As String)
        MessageBox.Show(pMessage, pTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub
    Public Sub InformationMessage(ByVal pMessage As String, ByVal pTitle As String)
        MessageBox.Show(pMessage, pTitle, MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
    Class Account
        Private AccessLevel As Integer
        Private AccountUsername As String
        Private StripMenus As ToolStripMenuItem()

        Public Sub SetAccessLevel(ByVal pAccessLevel As Integer)
            AccessLevel = pAccessLevel
        End Sub
        Public Function GetAccessLevel() As Integer
            Return AccessLevel
        End Function
        Public Sub SetAccountUsername(ByVal pSetAccountUsername As String)
            AccountUsername = pSetAccountUsername
        End Sub
        Public Function GetAccountUsername() As String
            Return AccountUsername
        End Function
        Public Sub SetStripMenus(ByVal paToolStripMenuItem As ToolStripMenuItem())
            StripMenus = paToolStripMenuItem
        End Sub

        Public Sub HideToolStripMenuItem()
            For Each pToolStripMenuItem As ToolStripMenuItem In StripMenus
                pToolStripMenuItem.Visible = False
            Next
        End Sub
        Public Sub ShowToolStripMenuItem()
            For Each pToolStripMenuItem As ToolStripMenuItem In StripMenus
                pToolStripMenuItem.Visible = True
            Next
        End Sub
    End Class

    Public Structure tAccountDetails
        Public Username As String
        Public Password As String
        Public RoleID As Integer
    End Structure
    Public Structure ClientDetails
        Public ClientName As String
        Public ClientAddress As String
        Public ClientContactNumber As String
        Public CoMakerName As String
        Public CoMakerAddress As String
        Public CoMakerContactNumber As String
    End Structure
    'Class ComboBoxItems
    '    Private 
    'End Class
    'Public Structure ClickedButton
    '    Public Database As String
    '    Public SelectedText As String
    'End Structure

    Public Function RoleIDConverter(ByVal pRoleID As Integer) As String
        Dim ConvertedRoleID As String = ""
        If pRoleID = 0 Then
            ConvertedRoleID = "User Account"
        ElseIf pRoleID = 1 Then
            ConvertedRoleID = "Administrator Account"
        End If
        Return ConvertedRoleID
    End Function
    Public Sub CloseOtherForms(ByVal pForm As Form)
        Dim formNames As New List(Of String)
        For Each form As Form In Application.OpenForms
            If form.Name IsNot SplashScreen.Name And form.Name IsNot MainForm.Name Then
                formNames.Add(form.Name)
            End If
        Next
        If formNames.Count > 0 Then
            For Each currentFormName As String In formNames
                Application.OpenForms(currentFormName).Close()

            Next
        End If
        pForm.Show()
    End Sub
    Public Sub ShowReportForm(ByVal pDataTable As DataTable)
        Dim vReportForm As New ReportForm
        Dim AccountDetailsReport As New AccountCreationNotice
        AccountDetailsReport.Database.Tables(0).SetDataSource(pDataTable)
        vReportForm.ReportContainer.ReportSource = AccountDetailsReport
        vReportForm.ReportContainer.Refresh()
        vReportForm.Show()
    End Sub
    Public Sub RegexBoxTextChanged(ByVal pTextBox As TextBox, ByVal pRegex As String)
        Dim restriction As Regex = New Regex(pRegex)
        pTextBox.Text = restriction.Replace(pTextBox.Text, "")
    End Sub
    Public Structure EntryDetails
        Public ProfileID As String
        Public ProfileName As String
        Public InterestRate() As String
        Public MonthDuration() As String
        Public YearDuration() As String
    End Structure

    Public Structure tdtb_Loans
        Public LoanID As Integer
        Public ClientID As Integer
        Public StartDate As Date
        Public DueDate As Date
        Public InterestRate As Double
        Public Mode As Integer
        Public LoanAmount As Double
        Public RemainingBalance As Double
        Public LoanStatus As Integer
        Public TransactionGain As Double
    End Structure

    Public Structure tdtb_LoansBalances
        Public BalanceID As Integer
        Public LoanID As Integer
        Public MonthAmountDue As Double
        Public MonthDueDate As Date
        Public MonthGain As Double
        Public PaymentStatus As Integer
    End Structure
    Public Function ReturnNextID(ByVal pIDField As String, ByVal pTableName As String) As Integer
        Dim tempInteger As Integer
        Dim rowCount As Integer = Database.ReturnRowCount(pTableName)
        If rowCount = 0 Then
            tempInteger = 1
        ElseIf rowCount > 0 Then
            tempInteger = Database.ReturnLastID(pIDField, pTableName) + 1
        End If
        Return tempInteger
    End Function


    Public LoanRateProfile As EntryDetails
    Public LoggedInAccount As AccountDetails
    Public AccountType As New Account

End Module
