Imports System.Text.RegularExpressions

Public Class AddCapitalShareForm

    Private ClientID As String
    Private ShareCapital As Double

    Private Sub EditClientForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ClientID = ClientList.ClientID
        ClientList.Close()
        Dim tDataTable As DataTable = Database.PopulateDataTable("SELECT DISTINCT [ClientName],[ShareCapital] FROM [dtb_Clients] WHERE [ClientID]=" + ClientID + ";")
        lbl_ClientID.Text = lbl_ClientID.Text + ClientID
        lbl_ClientName.Text = lbl_ClientName.Text + tDataTable.Rows(0)(0).ToString
        ShareCapital = Math.Round(CType(tDataTable.Rows(0)(1), Double), 2)
        lbl_OldShareCapital.Text = lbl_OldShareCapital.Text + ShareCapital.ToString("C2")

    End Sub

    Private Sub btn_Submit_Click(sender As Object, e As EventArgs) Handles btn_Submit.Click
        'Validation
        Dim ErrorString As String = ""
        Dim ErrorOccured As Boolean = False

        If tb_ShareCapital.Text = "" Then
            ErrorOccured = True
            ErrorString = ErrorString + Environment.NewLine + "Error: NO SHARE CAPITAL!" + Environment.NewLine + "Please enter share capital in the textbox."
        End If
        If ErrorOccured Then
            ErrorMessage(ErrorString, "Error")
        Else
            If MsgBox("Add " + FormatCurrency(tb_ShareCapital.Text, 2) + " Share Capital?" + Environment.NewLine + "New Share Capital will be: " + (ShareCapital + Math.Round(CType(tb_ShareCapital.Text, Double), 2)).ToString("C2"), vbYesNo, "") = vbYes Then
                Dim tDataTable As DataTable = Database.PopulateDataTable("SELECT DISTINCT [ClientName],[ClientAddress],[ClientContactNumber],[CoMakerName],[CoMakerAddress],[CoMakerContactNumber] FROM [dtb_Clients] WHERE [ClientID]=" + ClientID + ";")
                tDataTable.Columns.Add("RemainingBalance", GetType(String))
                tDataTable.Columns.Add("NewRemainingBalance", GetType(String))
                tDataTable.Columns.Add("PaymentDate", GetType(String))
                tDataTable.Rows(0)(6) = Math.Round(CType(tb_ShareCapital.Text, Double), 2).ToString("C2")
                tDataTable.Rows(0)(7) = tDataTable.Rows(0)(6)
                tDataTable.Rows(0)(8) = Date.Now.ToShortDateString
                Dim vReportForm As New ReportForm
                Dim rAddShareCapitalReport As New AddShareCapitalReport
                rAddShareCapitalReport.Database.Tables(0).SetDataSource(tDataTable)
                ''LoanCalculationBreakdownDetailsReport.Subreports.Item(0).Database.Tables(0).SetDataSource(crDetails)
                vReportForm.ReportContainer.ReportSource = rAddShareCapitalReport
                vReportForm.ReportContainer.Refresh()
                vReportForm.Show()
                ''update payment status and payment date
                'Database.Insert("UPDATE [dtb_LoanBalances] SET [PaymentStatus]=1,[PaymentDate]='" + Date.Now.ToShortDateString + "' WHERE [BalanceID]=" + tBalanceID.ToString + ";", False)
                ''reduce remaining balance
                'Database.Insert("UPDATE [dtb_Loans] SET [RemainingBalance]=" + CType(tDataTable.Rows(0).Item(13), Double).ToString("D2") + ";", False)
                Database.Insert("UPDATE [dtb_Clients] SET [ShareCapital]=" + (ShareCapital + Math.Round(CType(tb_ShareCapital.Text, Double), 2)).ToString + " WHERE [ClientID]=" + ClientID.ToString + ";", False)
                Close()
            End If
        End If
    End Sub

    Private Sub tb_ClientContactNumber_TextChanged(sender As Object, e As EventArgs) Handles tb_ShareCapital.TextChanged
        Dim digitsOnly As Regex = New Regex("[^\d]")
        tb_ShareCapital.Text = digitsOnly.Replace(tb_ShareCapital.Text, "")
    End Sub

    Private Sub tb_ClientContactNumber_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tb_ShareCapital.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

End Class