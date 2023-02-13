Imports System.Text.RegularExpressions

Public Class EditClientForm
    Dim OldClientDetails As ClientDetails
    Dim NewClientDetails As ClientDetails
    Dim ClientID As String
    Private Structure UpdateStatus
        Public Updated As Boolean
        Public UpdateString As String
    End Structure
    Dim status As UpdateStatus
    Private Sub EditClientForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ClientID = ClientList.ClientID
        ClientList.Close()
        Dim tDataTable As DataTable = Database.PopulateDataTable("SELECT * FROM [dtb_Clients] WHERE [ClientID]=" + ClientID + ";")
        OldClientDetails.ClientName = tDataTable.Rows(0)(1).ToString
        OldClientDetails.ClientAddress = tDataTable.Rows(0)(2).ToString
        OldClientDetails.ClientContactNumber = tDataTable.Rows(0)(3).ToString
        OldClientDetails.CoMakerName = tDataTable.Rows(0)(4).ToString
        OldClientDetails.CoMakerAddress = tDataTable.Rows(0)(5).ToString
        OldClientDetails.CoMakerContactNumber = tDataTable.Rows(0)(6).ToString
        lbl_ClientID.Text = lbl_ClientID.Text + ClientID
        lbl_ClientName.Text = lbl_ClientName.Text + OldClientDetails.ClientName
        tb_ClientName.Text = OldClientDetails.ClientName
        tb_ClientAddress.Text = OldClientDetails.ClientAddress
        tb_ClientContactNumber.Text = OldClientDetails.ClientContactNumber
        tb_CoMakerName.Text = OldClientDetails.CoMakerName
        tb_CoMakerAddress.Text = OldClientDetails.CoMakerAddress
        tb_CoMakerContactNumber.Text = OldClientDetails.CoMakerContactNumber
    End Sub

    Private Sub ComparisonUpdater(ByVal Field As String, ByVal OldValue As String, ByVal NewValue As String)
        If OldValue <> NewValue Then
            Database.Insert("UPDATE [dtb_Clients] SET [" + Field + "]='" + NewValue + "' WHERE [ClientID]=" + ClientID + ";", False)
            status.Updated = True
            status.UpdateString = status.UpdateString + Environment.NewLine + "Successfully Updated: " + OldValue + " [Old] to " + NewValue + " [New]" + Environment.NewLine
        End If
    End Sub

    Private Sub btn_Submit_Click(sender As Object, e As EventArgs) Handles btn_Submit.Click
        'Validation
        Dim ErrorString As String = ""
        Dim ErrorOccured As Boolean = False

        If tb_ClientName.Text = "" Then
            ErrorOccured = True
            ErrorString = ErrorString + Environment.NewLine + "Error: NO CLIENT NAME!" + Environment.NewLine + "Please enter client name in the textbox."
        End If
        If tb_ClientAddress.Text = "" Then
            ErrorOccured = True
            ErrorString = ErrorString + Environment.NewLine + "Error: NO CLIENT ADDRESS!" + Environment.NewLine + "Please enter client address in the textbox."
        End If
        If tb_ClientContactNumber.Text = "" Then
            ErrorOccured = True
            ErrorString = ErrorString + Environment.NewLine + "Error: NO CLIENT CONTACT NUMBER!" + Environment.NewLine + "Please enter client contact number in the textbox."
        End If
        ' Validation if not number
        'code later
        If tb_CoMakerName.Text = "" Then
            ErrorOccured = True
            ErrorString = ErrorString + Environment.NewLine + "Error: NO CO-MAKER NAME!" + Environment.NewLine + "Please enter co-maker name in the textbox."
        End If
        If tb_CoMakerAddress.Text = "" Then
            ErrorOccured = True
            ErrorString = ErrorString + Environment.NewLine + "Error: NO CO-MAKER ADDRESS!" + Environment.NewLine + "Please enter co-maker address in the textbox."
        End If
        If tb_CoMakerContactNumber.Text = "" Then
            ErrorOccured = True
            ErrorString = ErrorString + Environment.NewLine + "Error: NO CO-MAKER CONTACT NUMBER!" + Environment.NewLine + "Please enter co-maker contact number in the textbox."
        End If
        If ErrorOccured Then
            ErrorMessage(ErrorString, "Error")
        Else
            NewClientDetails.ClientName = tb_ClientName.Text
            NewClientDetails.ClientAddress = tb_ClientAddress.Text
            NewClientDetails.ClientContactNumber = tb_ClientContactNumber.Text
            NewClientDetails.CoMakerName = tb_CoMakerName.Text
            NewClientDetails.CoMakerAddress = tb_CoMakerAddress.Text
            NewClientDetails.CoMakerContactNumber = tb_CoMakerContactNumber.Text
            status.UpdateString = ""
            status.Updated = False
            ComparisonUpdater("ClientName", OldClientDetails.ClientName, NewClientDetails.ClientName)
            ComparisonUpdater("ClientAddress", OldClientDetails.ClientAddress, NewClientDetails.ClientAddress)
            ComparisonUpdater("ClientContactNumber", OldClientDetails.ClientContactNumber, NewClientDetails.ClientContactNumber)
            ComparisonUpdater("CoMakerName", OldClientDetails.CoMakerName, NewClientDetails.CoMakerName)
            ComparisonUpdater("CoMakerAddress", OldClientDetails.CoMakerAddress, NewClientDetails.CoMakerAddress)
            ComparisonUpdater("CoMakerContactNumber", OldClientDetails.CoMakerContactNumber, NewClientDetails.CoMakerContactNumber)
            If status.Updated Then
                InformationMessage(status.UpdateString, "")
            Else
                InformationMessage("Nothing Changed.", "")
            End If
            Me.Close()
            'get first how many, if > 0 then get them then put into non view datatable
            'Dim ClientCount As Integer = Database.QueryReturnInteger("SELECT COUNT(*) FROM dtb_Clients;")
            'Database.Insert("INSERT INTO dtb_Clients ([ClientID], [ClientName],[ClientAddress],[ClientContactNumber],[CoMakerName],[CoMakerAddress],[CoMakerContactNumber],[DateRegistered]) VALUES(" + (ClientCount + 1).ToString + ",'" + tb_ClientName.Text + "','" + tb_ClientAddress.Text + "','" + tb_ClientContactNumber.Text + "','" + tb_CoMakerName.Text + "','" + tb_CoMakerAddress.Text + "','" + tb_CoMakerContactNumber.Text + "','" + Date.Now.ToString("yyyy/MM/dd HH:mm:ss") + "');", False)
            'For Each form In My.Application.OpenForms
            '    If form.Name Is LoanForm.Name Then
            '        Database.PopulateDataGrid("SELECT DISTINCT ClientName FROM dtb_Clients;", LoanForm.dg_Clients, New DataGridViewAutoSizeColumnMode() {DataGridViewAutoSizeColumnMode.Fill})
            '        Exit For
            '    End If
            'Next
        End If
    End Sub

    Private Sub tb_ClientName_TextChanged(sender As Object, e As EventArgs) Handles tb_ClientName.TextChanged
        If tb_ClientName.Text.Contains("'") Then
            tb_ClientName.Text = tb_ClientName.Text.Replace("'", "")
            InformationMessage("Placing an apostrophe in the text box will result to syntax error.", "Warning")
        End If
    End Sub

    Private Sub tb_ClientAddress_TextChanged(sender As Object, e As EventArgs) Handles tb_ClientAddress.TextChanged
        If tb_ClientAddress.Text.Contains("'") Then
            tb_ClientAddress.Text = tb_ClientAddress.Text.Replace("'", "")
            InformationMessage("Placing an apostrophe in the text box will result to syntax error.", "Warning")
        End If
    End Sub

    Private Sub tb_ClientContactNumber_TextChanged(sender As Object, e As EventArgs) Handles tb_ClientContactNumber.TextChanged
        Dim digitsOnly As Regex = New Regex("[^\d]")
        tb_ClientContactNumber.Text = digitsOnly.Replace(tb_ClientContactNumber.Text, "")
    End Sub

    Private Sub tb_CoMakerName_TextChanged(sender As Object, e As EventArgs) Handles tb_CoMakerName.TextChanged
        If tb_CoMakerName.Text.Contains("'") Then
            tb_CoMakerName.Text = tb_CoMakerName.Text.Replace("'", "")
            InformationMessage("Placing an apostrophe in the text box will result to syntax error.", "Warning")
        End If
    End Sub

    Private Sub tb_CoMakerAddress_TextChanged(sender As Object, e As EventArgs) Handles tb_CoMakerAddress.TextChanged
        If tb_CoMakerAddress.Text.Contains("'") Then
            tb_CoMakerAddress.Text = tb_CoMakerAddress.Text.Replace("'", "")
            InformationMessage("Placing an apostrophe in the text box will result to syntax error.", "Warning")
        End If
    End Sub

    Private Sub tb_CoMakerContactNumber_TextChanged(sender As Object, e As EventArgs) Handles tb_CoMakerContactNumber.TextChanged
        Dim digitsOnly As Regex = New Regex("[^\d]")
        tb_CoMakerContactNumber.Text = digitsOnly.Replace(tb_CoMakerContactNumber.Text, "")
    End Sub

    Private Sub tb_ClientContactNumber_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tb_ClientContactNumber.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub tb_CoMakerContactNumber_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tb_CoMakerContactNumber.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub


End Class