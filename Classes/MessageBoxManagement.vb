Module MessageBoxManagement

    'move file message
    Public Sub MoveFileMessage(ByVal Message As String, ByVal Title As String, ByVal OriginPath As String, ByVal DestinationPath As String)
        My.Computer.FileSystem.MoveFile(OriginPath, DestinationPath)
        MessageBox.Show(Message, Title, MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

End Module
