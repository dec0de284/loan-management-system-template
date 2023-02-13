Imports System.Text.RegularExpressions

Public Class AddClientForm
    Private tDataTable As DataTable
    'Private matchFound As Boolean
    'Private regions As ComboBox.ObjectCollection
    'Private tempComboBox As ComboBox
    'Dim buttonDetails As ClickedButton = New ClickedButton()
    Public selectedButton As String
    Public selectedClientButton As Boolean

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
        'Revision
        If TextBox1.Text = "" Then
            ErrorOccured = True
            ErrorString = ErrorString + Environment.NewLine + "Error: NO CLIENT REGION ADDRESS!" + Environment.NewLine + "Please click the 'Change' button next to it and choose a region."
        End If
        If TextBox2.Text = "" Then
            ErrorOccured = True
            ErrorString = ErrorString + Environment.NewLine + "Error: NO CLIENT PROVINCE ADDRESS!" + Environment.NewLine + "Please click the 'Change' button next to it and choose a arovince."
        End If
        If TextBox3.Text = "" Then
            ErrorOccured = True
            ErrorString = ErrorString + Environment.NewLine + "Error: NO CLIENT CITY ADDRESS!" + Environment.NewLine + "Please click the 'Change' button next to it and choose a city."
        End If
        If TextBox4.Text = "" Then
            ErrorOccured = True
            ErrorString = ErrorString + Environment.NewLine + "Error: NO CLIENT BARANGAY ADDRESS!" + Environment.NewLine + "Please click the 'Change' button next to it and choose a barangay."
        End If

        If tb_ClientContactNumber.Text = "" Then
            ErrorOccured = True
            ErrorString = ErrorString + Environment.NewLine + "Error: NO CLIENT CONTACT NUMBER!" + Environment.NewLine + "Please enter client contact number in the textbox."
        End If
        ' Validation contact number not equal to 9 (fix)
        If tb_ClientContactNumber.Text.Length <> 9 Then
            ErrorOccured = True
            ErrorString = ErrorString + Environment.NewLine + "Error: ENTER VALID CLIENT CONTACT NUMBER!" + Environment.NewLine + "Please enter a valid client contact number in the textbox."
        End If
        If tb_CoMakerName.Text = "" Then
            ErrorOccured = True
            ErrorString = ErrorString + Environment.NewLine + "Error: NO CO-MAKER NAME!" + Environment.NewLine + "Please enter co-maker name in the textbox."
        End If
        If tb_CoMakerAddress.Text = "" Then
            ErrorOccured = True
            ErrorString = ErrorString + Environment.NewLine + "Error: NO CO-MAKER ADDRESS!" + Environment.NewLine + "Please enter co-maker address in the textbox."
        End If
        'Revision
        If TextBox8.Text = "" Then
            ErrorOccured = True
            ErrorString = ErrorString + Environment.NewLine + "Error: NO CLIENT REGION ADDRESS!" + Environment.NewLine + "Please click the 'Change' button next to it and choose a region."
        End If
        If TextBox7.Text = "" Then
            ErrorOccured = True
            ErrorString = ErrorString + Environment.NewLine + "Error: NO CLIENT PROVINCE ADDRESS!" + Environment.NewLine + "Please click the 'Change' button next to it and choose a arovince."
        End If
        If TextBox6.Text = "" Then
            ErrorOccured = True
            ErrorString = ErrorString + Environment.NewLine + "Error: NO CLIENT CITY ADDRESS!" + Environment.NewLine + "Please click the 'Change' button next to it and choose a city."
        End If
        If TextBox5.Text = "" Then
            ErrorOccured = True
            ErrorString = ErrorString + Environment.NewLine + "Error: NO CLIENT BARANGAY ADDRESS!" + Environment.NewLine + "Please click the 'Change' button next to it and choose a barangay."
        End If
        If tb_CoMakerContactNumber.Text = "" Then
            ErrorOccured = True
            ErrorString = ErrorString + Environment.NewLine + "Error: NO CO-MAKER CONTACT NUMBER!" + Environment.NewLine + "Please enter co-maker contact number in the textbox."
        End If
        ' Validation contact number not equal to 9 (fix)
        If tb_CoMakerContactNumber.Text.Length <> 9 Then
            ErrorOccured = True
            ErrorString = ErrorString + Environment.NewLine + "Error: ENTER VALID CO-MAKER CONTACT NUMBER!" + Environment.NewLine + "Please enter a valid co-maker contact number in the textbox."
        End If
        If tb_ShareCapital.Text = "" Then
            ErrorOccured = True
            ErrorString = ErrorString + Environment.NewLine + "Error: NO SHARE CAPITAL!" + Environment.NewLine + "Please enter share capital in the textbox."
        End If
        'Fix if Capital Share is below 4000
        If tb_ShareCapital.Text <> "" Then
            If Convert.ToInt32(tb_ShareCapital.Text) < 4000 Then
                ErrorOccured = True
                ErrorString = ErrorString + Environment.NewLine + "Error: SHARE CAPITAL MUST BE GREATER THAN 4000" + Environment.NewLine + "Please enter share capital in the textbox."
            End If
        End If
        If ErrorOccured Then
            ErrorMessage(ErrorString, "Error")
        Else
            'confirmation
            Dim ClientName As String = tb_ClientName.Text
            Dim ClientAddress As String = tb_ClientAddress.Text
            Dim ClientRegion As String = TextBox1.Text
            Dim ClientProvince As String = TextBox2.Text
            Dim ClientCity As String = TextBox3.Text
            Dim ClientBarangay As String = TextBox4.Text
            Dim CoMakerName As String = tb_CoMakerName.Text
            Dim CoMakerAddress As String = tb_CoMakerAddress.Text
            Dim CoMakerRegion As String = TextBox8.Text
            Dim CoMakerProvince As String = TextBox7.Text
            Dim CoMakerCity As String = TextBox6.Text
            Dim CoMakerBarangay As String = TextBox5.Text

            Dim ConfirmationString As String = Environment.NewLine + "Please double check before pressing 'Yes'" + Environment.NewLine + Environment.NewLine + "Client Details:" + Environment.NewLine + "Client Name: " + ClientName + Environment.NewLine + "Client Address: " + ClientAddress + Environment.NewLine + "Client Region: " + ClientRegion + Environment.NewLine + "Client Province: " + ClientProvince + Environment.NewLine + "Client City: " + ClientCity + Environment.NewLine + "Client Barangay: " + ClientBarangay + Environment.NewLine + Environment.NewLine + "Co-Maker Name: " + CoMakerName + Environment.NewLine + "Co-Maker Address: " + CoMakerAddress + Environment.NewLine + "Co-Maker Region: " + CoMakerRegion + Environment.NewLine + "Co-Maker Province: " + CoMakerProvince + Environment.NewLine + "Co-Maker City: " + CoMakerCity + Environment.NewLine + "Co-Maker Barangay: " + ClientBarangay + Environment.NewLine
            'InformationMessage(ConfirmationString, "Confirmation")

            If MsgBox(ConfirmationString, vbYesNo, "Confirmation") = vbYes Then

                Dim lastClientID As Integer
                If Database.Count("SELECT COUNT([ClientID]) FROM [dtb_Clients];") = 0 Then
                    lastClientID = 0
                Else
                    lastClientID = Database.QueryReturnInteger("SELECT LAST([ClientID]) FROM [dtb_Clients];")
                End If
                Database.Insert("INSERT INTO [dtb_Clients] ([ClientID], [ClientName], [ClientAddress], [ClientContactNumber], [ClientRegion], [ClientProvince], [CoMakerAddress], [ClientCity], [ClientBarangay], [CoMakerName], [CoMakerRegion], [CoMakerProvince], [CoMakerCity], [CoMakerBarangay], [CoMakerContactNumber], [DateRegistered], [RegisterBy], [ShareCapital], [Active]) VALUES(" + (lastClientID + 1).ToString + ",'" + tb_ClientName.Text + "','" + tb_ClientAddress.Text + "','" + "09" + tb_ClientContactNumber.Text + "','" + ClientRegion + "','" + ClientProvince + "','" + tb_CoMakerAddress.Text + "','" + ClientCity + "','" + ClientBarangay + "','" + tb_CoMakerName.Text + "','" + CoMakerRegion + "','" + CoMakerProvince + "','" + CoMakerCity + "','" + CoMakerBarangay + "','" + "09" + tb_CoMakerContactNumber.Text + "','" + Date.Now.ToString() + "','" + AccountType.GetAccountUsername() + "'," + tb_ShareCapital.Text + ",1);", True)
                Dim LogID As Integer
                If Database.Count("SELECT COUNT([LogID]) FROM [dtb_AuditLog];") = 0 Then
                    LogID = 0
                Else
                    LogID = Database.ReturnLastID("LogID", "dtb_AuditLog")
                End If


                Database.Insert("INSERT INTO [dtb_AuditLog] ([LogID], [ActionBy], [Action], [ActionDate], [ActionState], [ActionLevel]) VALUES(" + (LogID + 1).ToString + ",'" + AccountType.GetAccountUsername() + "','Add Client','" + Date.Now.ToString() + "','Success','Information');", False)
                Me.Close()
            End If
                'get first how many, if > 0 then get them then put into non view datatable
                'Dim lastClientID As Integer = Database.QueryReturnInteger("SELECT LAST([ClientID]) FROM [dtb_Clients];")
                'InformationMessage(lastClientID.ToString, "")


                'For Each form In My.Application.OpenForms
                '    If form.Name Is LoanForm.Name Then
                '        Database.PopulateDataGrid("SELECT DISTINCT ClientName FROM dtb_Clients;", LoanForm.SystemAccountsTable, New DataGridViewAutoSizeColumnMode() {DataGridViewAutoSizeColumnMode.Fill})
                '        Exit For
                '    End If
                'Next
                'Me.Close()
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

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tb_ShareCapital.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles tb_ShareCapital.TextChanged
        Dim digitsOnly As Regex = New Regex("[^\d]")
        tb_ClientContactNumber.Text = digitsOnly.Replace(tb_ClientContactNumber.Text, "")
    End Sub

    Private Sub AddClientForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'matchFound = False
        'tempComboBox = New ComboBox
        ''filling combobox choices
        'tDataTable = New DataTable
        'tDataTable = Database.QueryReturnDataTable("SELECT * FROM dtb_Region;")
        'For tableRows As Integer = 0 To (tDataTable.Rows.Count - 1)
        '    'client region cb
        '    ComboBox2.Items.Add(tDataTable.Rows(tableRows)(0).ToString)
        'Next
        'ComboBox8.DataSource = ComboBox2.Items
        'ComboBox8.Text = ""
        'regions = ComboBox2.Items
    End Sub

    Private Sub ButtonSwitch(pBoolean As Boolean)
        Button1.Enabled = pBoolean
        Button2.Enabled = pBoolean
        Button3.Enabled = pBoolean
        Button4.Enabled = pBoolean
        Button5.Enabled = pBoolean
        Button6.Enabled = pBoolean
        Button7.Enabled = pBoolean
        Button8.Enabled = pBoolean
    End Sub

    'Private ReadOnly Buttons As Button() = {Button1, Button2, Button3, Button4, Button5, Button6, Button7, Button8}
    Private OldButtonSwitchState As Boolean()
    Private Sub SaveOldButtonSwitchState()
        OldButtonSwitchState = New Boolean(7) {Button1.Enabled, Button2.Enabled, Button3.Enabled, Button4.Enabled, Button5.Enabled, Button6.Enabled, Button7.Enabled, Button8.Enabled}
    End Sub

    Public Sub RestoreOldButtonSwitchState()
        If OldButtonSwitchState.Count > 0 Then
            For switchStateIntex As Integer = 0 To (OldButtonSwitchState.Count - 1)
                Select Case switchStateIntex
                    Case 0
                        Button1.Enabled = OldButtonSwitchState(switchStateIntex)
                    Case 1
                        Button2.Enabled = OldButtonSwitchState(switchStateIntex)
                    Case 2
                        Button3.Enabled = OldButtonSwitchState(switchStateIntex)
                    Case 3
                        Button4.Enabled = OldButtonSwitchState(switchStateIntex)
                    Case 4
                        Button5.Enabled = OldButtonSwitchState(switchStateIntex)
                    Case 5
                        Button6.Enabled = OldButtonSwitchState(switchStateIntex)
                    Case 6
                        Button7.Enabled = OldButtonSwitchState(switchStateIntex)
                    Case 7
                        Button8.Enabled = OldButtonSwitchState(switchStateIntex)
                End Select

                'Buttons(switchStateIntex).Enabled = OldButtonSwitchState(switchStateIntex)
            Next
            '        For regionIndex As Integer = 0 To (regions.Count - 1)
            '            'client Region cb
            '            If ComboBox2.Text = regions.Item(regionIndex).ToString Then
            '                matchFound = True
            '            End If
            '            'ComboBox2.Items.Add(tDataTable.Rows(tableRows)(0).ToString)
            '        Next
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        SaveOldButtonSwitchState()
        ButtonSwitch(False)
        selectedClientButton = True
        If TextBox2.Text <> "" Or TextBox3.Text <> "" Or TextBox4.Text <> "" Then
            TextBox2.Text = ""
            TextBox3.Text = ""
            TextBox4.Text = ""
            Button2.Enabled = False
            Button3.Enabled = False
            Button4.Enabled = False
        End If
        selectedButton = "Region"
        'SelectForm.
        SelectForm.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        SaveOldButtonSwitchState()
        ButtonSwitch(False)
        selectedClientButton = True
        If TextBox3.Text <> "" Or TextBox4.Text <> "" Then
            TextBox3.Text = ""
            TextBox4.Text = ""
            Button3.Enabled = False
            Button4.Enabled = False
        End If
        selectedButton = "Province"
        SelectForm.Show()
        If SelectForm.ErrorOccured Then
            SelectForm.ErrorOccured = False
            SelectForm.Close()
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        SaveOldButtonSwitchState()
        ButtonSwitch(False)
        selectedClientButton = True
        If TextBox4.Text <> "" Then
            TextBox4.Text = ""
            Button4.Enabled = False
        End If
        selectedButton = "City"
        SelectForm.Show()
        If SelectForm.ErrorOccured Then
            SelectForm.ErrorOccured = False
            SelectForm.Close()
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        SaveOldButtonSwitchState()
        ButtonSwitch(False)
        selectedButton = "Barangay"
        SelectForm.Show()
        If SelectForm.ErrorOccured Then
            SelectForm.ErrorOccured = False
            SelectForm.Close()
        End If
    End Sub

    Private Sub AddClientForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        'e.Cancel = True
        'For Each form In My.Application.OpenForms
        '    If form.Name Is "Select " + selectedButton Then
        '        form.Close()
        '        'Database.PopulateDataGrid("SELECT DISTINCT ClientName FROM dtb_Clients;", LoanForm.dg_Clients, New DataGridViewAutoSizeColumnMode() {DataGridViewAutoSizeColumnMode.Fill})
        '        Exit For
        '    End If
        'Next
        'e.Cancel = False
        Try
            SelectForm.Close()
        Catch ex As Exception

        End Try
        'Me.Close()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        SaveOldButtonSwitchState()
        ButtonSwitch(False)
        selectedClientButton = False
        If TextBox7.Text <> "" Or TextBox6.Text <> "" Or TextBox5.Text <> "" Then
            TextBox7.Text = ""
            TextBox6.Text = ""
            TextBox5.Text = ""
            Button7.Enabled = False
            Button6.Enabled = False
            Button5.Enabled = False
        End If
        selectedButton = "Region"
        'SelectForm.
        SelectForm.Show()
        If SelectForm.ErrorOccured Then
            SelectForm.ErrorOccured = False
            SelectForm.Close()
        End If
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        SaveOldButtonSwitchState()
        ButtonSwitch(False)
        selectedClientButton = False
        If TextBox6.Text <> "" Or TextBox5.Text <> "" Then
            TextBox6.Text = ""
            TextBox5.Text = ""
            Button6.Enabled = False
            Button5.Enabled = False
        End If
        selectedButton = "Province"
        'SelectForm.
        SelectForm.Show()
        If SelectForm.ErrorOccured Then
            SelectForm.ErrorOccured = False
            SelectForm.Close()
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        SaveOldButtonSwitchState()
        ButtonSwitch(False)
        selectedClientButton = False
        If TextBox5.Text <> "" Then
            TextBox5.Text = ""
            Button5.Enabled = False
        End If
        selectedButton = "City"
        'SelectForm.
        SelectForm.Show()
        If SelectForm.ErrorOccured Then
            SelectForm.ErrorOccured = False
            SelectForm.Close()
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        SaveOldButtonSwitchState()
        ButtonSwitch(False)
        selectedButton = "Barangay"
        'SelectForm.
        SelectForm.Show()
        If SelectForm.ErrorOccured Then
            SelectForm.ErrorOccured = False
            SelectForm.Close()
        End If
    End Sub

    'Private Sub ComboBox2_TextChanged(sender As Object, e As EventArgs) Handles ComboBox2.TextChanged
    '    tDataTable = New DataTable
    '    tDataTable = Database.QueryReturnDataTable("SELECT [Region] FROM [dtb_Region] WHERE ([Region] LIKE '%" + ComboBox2.Text + "%');")
    '    If ComboBox2.Text.Contains("'") = False And ComboBox2.Text IsNot "" And tDataTable.Rows.Count > 0 Then
    '        For regionIndex As Integer = 0 To (regions.Count - 1)
    '            'client Region cb
    '            If ComboBox2.Text = regions.Item(regionIndex).ToString Then
    '                matchFound = True
    '            End If
    '            'ComboBox2.Items.Add(tDataTable.Rows(tableRows)(0).ToString)
    '        Next
    '        If matchFound = False Then
    '            ComboBox3.Enabled = False
    '            If ComboBox2.Items.Count > 0 Then
    '                ComboBox2.Items.Clear()
    '            End If

    '            For tableRows As Integer = 0 To (tDataTable.Rows.Count - 1)
    '                'client region cb
    '                ComboBox2.Items.Add(tDataTable.Rows(tableRows)(0).ToString)
    '                'tempComboBox.Items.Add(tDataTable.Rows(tableRows)(0).ToString)
    '                'ComboBox2.DataSource = tempComboBox.Items
    '            Next
    '        Else
    '            matchFound = False
    '            ComboBox3.Enabled = True
    '        End If



    '        'If matchFound = False Then

    '        'if result is greater than 0
    '        'If  Then
    '        '    'If tempComboBox.Items.Count > 0 Then
    '        '    'tempComboBox.Items.Clear()
    '        '    'End If

    '        'Else
    '        '    InformationMessage("There's no Region that contains '" + ComboBox2.Text + ".'", "Warning")
    '        '    ComboBox2.Text = ""
    '        'End If
    '        'Database.PopulateDataGrid("SELECT RoleID, Username FROM SystemAccounts WHERE (Username LIKE '%" + tb_SearchUsername.Text + "%');", SystemAccountsTable, New DataGridViewAutoSizeColumnMode() {DataGridViewAutoSizeColumnMode.DisplayedCells, DataGridViewAutoSizeColumnMode.Fill})
    '        'ElseIf matchFound Then
    '        'ComboBox3.Enabled = True

    '        'End If
    '    ElseIf tDataTable.Rows.Count = 0 Then
    '        InformationMessage("There's no Region that contains '" + ComboBox2.Text + ".'", "Warning")
    '        ComboBox3.Enabled = False
    '        matchFound = False
    '        ComboBox2.Items.Clear()
    '        For regionItemIndex As Integer = 0 To (regions.Count - 1)
    '            ComboBox2.Items.Add(tDataTable.Rows(regionItemIndex)(0).ToString)
    '        Next
    '    ElseIf ComboBox2.Text.Contains("'") = True Then
    '        ComboBox2.Text = ComboBox2.Text.Replace("'", "")
    '        InformationMessage("Placing an apostrophe in the search box will result to syntax error.", "Warning")
    '    ElseIf ComboBox2.Text = "" Then
    '        ComboBox3.Text = ""
    '        ComboBox3.Enabled = False
    '        ComboBox4.Text = ""
    '        ComboBox4.Enabled = False
    '        ComboBox5.Text = ""
    '        ComboBox5.Enabled = False
    '        matchFound = False
    '        ComboBox2.Items.Clear()
    '        For regionItemIndex As Integer = 0 To (regions.Count - 1)
    '            ComboBox2.Items.Add(tDataTable.Rows(regionItemIndex)(0).ToString)
    '        Next
    '        'ComboBox2.DataSource = regions
    '    End If

    'End Sub
End Class