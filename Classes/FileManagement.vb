Module FileManagement
    Public Function Check(ByVal FileName As String)
        Return My.Computer.FileSystem.FileExists(Application.StartupPath + "\" + FileName)
    End Function
End Module
