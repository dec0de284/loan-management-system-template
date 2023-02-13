Public Class SplashScreen

    Private FileChecked As Boolean = False
    Private ConnectionChecked As Boolean = False
    Private Sub SplashScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'MainForm.OpenFileDialog.InitialDirectory = Application.StartupPath
    End Sub
    Private Sub LoadTimer_Tick(sender As Object, e As EventArgs) Handles LoadTimer.Tick
        If LoadBar.Value <= 95 Then
            LoadBar.Value += 5
            If FileChecked = False Then
                'LoadingText.Text = "Checking config file..."
                'when the program lauches, check if config exists
                'If Check("config") Then
                '    'config.ini exists
                '    InformationMessage("meow", "it exists")
                'Else
                '    'config file doesn't exist, enter first time system setup
                '    LoadTimer.Stop()
                '    LoadTimer.Enabled = False
                '    Me.Hide()
                '    SetupForm.Show()
                'End If
                Database.SetDataSourceLocation(Application.StartupPath + "\BMPCLoanDB.mdb")
                If My.Computer.FileSystem.FileExists(Database.GetDataSourceLocation) = False Then
                    'The "BMPCLoanDB.mdb" was not located
                    LoadTimer.Stop()
                    MessageBox.Show("The BMPCLoanDB.mdb file was not found!" + Environment.NewLine + "Find the BMPCLoanDB.mdb location in you computer.", "File not found!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Dim ResponseDialogResult As DialogResult = MainForm.OpenFileDialog.ShowDialog()
                    If ResponseDialogResult = DialogResult.OK Then
                        Database.SetDataSourceLocation(MainForm.OpenFileDialog.FileName)
                        LoadTimer.Start()
                    ElseIf ResponseDialogResult = DialogResult.Cancel Then
                        Me.Close()
                    End If
                End If
                FileChecked = True
            End If
            'The "BMPCLoanDB.mdb" was located
            If LoadBar.Value = 40 Then
                LoadingText.Text = "Testing database connection to 'BMPCLoanDB.mdb'..."
                If ConnectionChecked = False Then
                    LoadTimer.Stop()
                    If Database.TestConnectionError() Then
                        Me.Close()
                    End If
                    ConnectionChecked = True
                    LoadTimer.Start()
                End If
            ElseIf LoadBar.Value = 70 Then
                LoadingText.Text = "Successfully connected to 'BMPCLoanDB.mdb'!"
            End If
        Else
            LoadTimer.Stop()
            LoadTimer.Enabled = False
            Me.Hide()
            'Check dtb_SystemAccounts Count
            Dim accountsCount As Integer = Database.Count("SELECT COUNT([AccountID]) FROM [dtb_SystemAccounts];")
            If accountsCount = 0 Then
                'Show First Time Setup
                InformationMessage("There's no accounts detected! Entering First Time Use Setup...", "")
                FirstTimeSetupAdminAccount.Show()
            Else
                MainForm.Show()
            End If
        End If
    End Sub
End Class