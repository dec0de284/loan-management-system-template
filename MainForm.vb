Imports System.Data.OleDb
Public Class MainForm
    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AccountType.SetStripMenus(New ToolStripMenuItem() {smClient, smReports, smTransactions, aCreateAccount, aDelete, smLogs})
        AccountType.HideToolStripMenuItem()
        cMenuStrip.Visible = True
        SignInForm.Show()

    End Sub

    Private Sub aSignIn_Click(sender As Object, e As EventArgs) Handles aSignIn.Click
        SignInForm.Show()
    End Sub

    Private Sub aSignOut_Click(sender As Object, e As EventArgs) Handles aSignOut.Click
        cMenuStrip.Visible = False
        AccountType.SetStripMenus(New ToolStripMenuItem() {smClient, smReports, smTransactions, aCreateAccount, aDelete, smLogs})
        AccountType.HideToolStripMenuItem()
        aSignIn.Enabled = True
        aSignOut.Enabled = False
        cMenuStrip.Visible = True
        SignInForm.Show()
    End Sub

    Private Sub MainForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        SplashScreen.Close()
    End Sub

    Private Sub aCreateAccount_Click(sender As Object, e As EventArgs) Handles aCreateAccount.Click
        UserAccountCreation.Show()
        'form_CreateAccount.Show()
    End Sub

    Private Sub aEdit_Click(sender As Object, e As EventArgs)
        'Show Edit Accounts Form
        EditAccounts.Show()
    End Sub

    Private Sub tLoanForm_Click(sender As Object, e As EventArgs) Handles tLoanForm.Click
        LoanForm.Show()
    End Sub

    Private Sub cAdd_Click(sender As Object, e As EventArgs) Handles cAdd.Click
        AddClientForm.Show()
    End Sub

    Private Sub rWeekly_Click(sender As Object, e As EventArgs)
        ReportFormSample.Show()
    End Sub

    Private Sub LoanProfileToolStripMenuItem_Click(sender As Object, e As EventArgs)
        CloseOtherForms(CreateLoanProfile)
    End Sub

    Private Sub CreateClientProfileToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub aDelete_Click(sender As Object, e As EventArgs) Handles aDelete.Click
        DeleteAccount.Show()
    End Sub

    Private Sub cEdit_Click(sender As Object, e As EventArgs)
        ClientList.Show()
    End Sub

    Private Sub cDelete_Click(sender As Object, e As EventArgs) Handles cDelete.Click
        DeleteClient.Show()
    End Sub

    Private Sub LoanRateProfileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoanRateProfileToolStripMenuItem.Click
        CreateLoanProfile.Show()
    End Sub

    Private Sub tPayment_Click(sender As Object, e As EventArgs) Handles tPayment.Click
        LoanPaymentForm.Show()
    End Sub

    Private Sub rMonthly_Click(sender As Object, e As EventArgs) Handles rMonthly.Click
        MonthlyReportFormFilter.Show()
    End Sub

    Private Sub rYearly_Click(sender As Object, e As EventArgs) Handles rYearly.Click
        YearlyReportFormFilter.Show()
    End Sub

    Private Sub UserAccountsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UserAccountsToolStripMenuItem.Click
        ViewAccounts.Show()
    End Sub

    Private Sub AuditLogToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AuditLogToolStripMenuItem.Click
        ViewAuditLog.Show()
    End Sub

    Private Sub ClientsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClientsToolStripMenuItem.Click
        ViewClients.Show()
    End Sub

End Class
