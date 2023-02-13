Public Class SetupForm

    Private DatabaseFileLocation As String = ""

    Private Sub RadioButton_MSAccess_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton_MSAccess.CheckedChanged
        If RadioButton_MSAccess.Checked Then
            Button_SearchFile.Enabled = True
            GroupBox_DatabasePassword.Enabled = True
            RichTextBox_Others.Enabled = False
        Else
            Button_SearchFile.Enabled = False
            GroupBox_DatabasePassword.Enabled = False
            RichTextBox_Others.Enabled = True
        End If
    End Sub

    Private Sub RadioButton_NoPassword_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton_NoPassword.CheckedChanged
        If RadioButton_NoPassword.Checked Then
            TextBox_DatabasePassword.Enabled = False
            CheckBox_EncryptPassword.Enabled = False
        Else
            TextBox_DatabasePassword.Enabled = True
            CheckBox_EncryptPassword.Enabled = True
        End If
    End Sub

    Private Sub Button_TestConnection_Click(sender As Object, e As EventArgs) Handles Button_TestConnection.Click

    End Sub

    Private Sub Button_SearchFile_Click(sender As Object, e As EventArgs) Handles Button_SearchFile.Click
        Dim ResponseDialogResult As DialogResult = OpenFileDialog_DataBaseFile.ShowDialog()
        If ResponseDialogResult = DialogResult.OK Then
            DatabaseFileLocation = OpenFileDialog_DataBaseFile.FileName
        End If
    End Sub

End Class