Imports System.Data.OleDb
Imports System.IO

Module DataBaseManagement
    Class AccessConnection
        Private ConnectionString As String
        Private DataSourceLocation As String
        Private Connection As OleDb.OleDbConnection
        Private Command As OleDbCommand
        Private DataTable As DataTable
        Private DataAdapter As OleDb.OleDbDataAdapter

        Public Sub SetCustomConnectionString(ByVal pCustomConnectionString As String)
            ConnectionString = pCustomConnectionString
        End Sub
        Public Sub SetDataSourceLocation(ByVal pDataSourceLocation As String)
            DataSourceLocation = pDataSourceLocation
        End Sub
        Public Sub SetConnectionString()

            Dim br As BinaryReader
            Try
                br = New BinaryReader(New FileStream("key.bin", FileMode.Open))
            Catch err As IOException
                Console.WriteLine(err.Message + "\n Cannot open file.")
                Return
            End Try
            Try
                Dim cipherText As String = br.ReadString()
                Dim wrapper As New Simple3Des(br.ReadString())
                Try
                    ConnectionString = "Provider=Microsoft.Jet.Oledb.4.0; Data Source=" + DataSourceLocation + ";Jet OLEDB:Database Password=" + wrapper.DecryptData(cipherText)
                Catch ex As System.Security.Cryptography.CryptographicException
                    MsgBox("The data could not be decrypted with the password.")
                End Try
            Catch err As IOException
                Console.WriteLine(err.Message + "\n Cannot read from file.")
                Return
            End Try
            br.Close()

        End Sub
        Public Function GetDataSourceLocation() As String
            Return DataSourceLocation
        End Function
        Public Function QueryReturnString(ByVal pQuery As String) As String
            SetConnectionString()
            Command = New OleDbCommand(pQuery, Connection)
            Dim tempString As String = ""
            Try
                Connection.Open()
                tempString = Command.ExecuteScalar().ToString()
                Connection.Close()
            Catch ex As Exception
                ErrorMessage(ex.ToString, "Error")
            End Try
            Return tempString
        End Function
        Public Function QueryReturnInteger(ByVal pQuery As String) As Integer
            SetConnectionString()
            Command = New OleDbCommand(pQuery, Connection)
            Dim tempInteger As Integer = 0
            Try
                Connection.Open()
                tempInteger = CType(Command.ExecuteScalar().ToString, Integer)
                Connection.Close()
            Catch ex As Exception
                ErrorMessage(ex.ToString, "Error")
            End Try
            Return tempInteger
        End Function
        Public Function Count(ByVal pQuery As String) As Integer
            SetConnectionString()
            Command = New OleDbCommand(pQuery, Connection)
            Dim tempInteger As Integer = 0
            Try
                Connection.Open()
                tempInteger = CType(Command.ExecuteScalar().ToString, Integer)
                Connection.Close()
            Catch ex As Exception
                ErrorMessage(ex.ToString, "Error")
            End Try
            Return tempInteger
        End Function
        Public Function QueryReturnDataTable(ByVal pQuery As String) As DataTable
            SetConnectionString()
            Command = New OleDbCommand(pQuery, Connection)
            Dim dataTable As New DataTable
            dataTable = New DataTable



            Try
                DataAdapter = New OleDb.OleDbDataAdapter(Command)
                DataAdapter.Fill(dataTable)
            Catch ex As Exception
                ErrorMessage(ex.ToString, "Error")
            End Try
            Return dataTable
        End Function
        Public Function TestConnectionError() As Boolean
            SetConnectionString()
            Connection = New OleDb.OleDbConnection(ConnectionString)
            Try
                Connection.Open()
                Connection.Close()
                Return False
            Catch ex As Exception
                ErrorMessage(ex.ToString, "Error")

                Return True
            End Try
        End Function
        Public Sub Insert(ByVal pQuery As String, ByVal pNotification As Boolean)
            SetConnectionString()
            Command = New OleDbCommand(pQuery, Connection)
            Try
                Connection.Open()
                Command.ExecuteNonQuery()
                Connection.Close()
                If pNotification Then
                    InformationMessage("Successfully Added!", "")
                End If
            Catch ex As Exception
                ErrorMessage(ex.ToString, "Error")
            End Try
        End Sub
        Public Sub Delete(ByVal pQuery As String, ByVal pNotification As Boolean)
            SetConnectionString()
            Command = New OleDbCommand(pQuery, Connection)
            Try
                Connection.Open()
                Command.ExecuteNonQuery()
                Connection.Close()
                If pNotification Then
                    InformationMessage("Successfully Deleted!", "")
                End If
            Catch ex As Exception
                ErrorMessage(ex.ToString, "Error")
            End Try
        End Sub
        Public Sub PopulateDataGrid(ByVal pQuery As String, ByVal pDataGridView As DataGridView, ByVal pDataGridViewAutoSizeColumnMode As DataGridViewAutoSizeColumnMode())
            SetConnectionString()
            Command = New OleDbCommand(pQuery, Connection)
            DataTable = New DataTable

            Try
                DataAdapter = New OleDb.OleDbDataAdapter(Command)
                DataAdapter.Fill(DataTable)
                pDataGridView.DataSource = DataTable
                For i As Integer = 0 To (pDataGridView.ColumnCount - 1)
                    pDataGridView.Columns.Item(i).Resizable = DataGridViewTriState.False
                    pDataGridView.Columns.Item(i).SortMode = DataGridViewColumnSortMode.NotSortable
                    pDataGridView.Columns.Item(i).AutoSizeMode = pDataGridViewAutoSizeColumnMode(i)
                Next
                If pDataGridView.RowCount <> 0 Then
                    pDataGridView.Rows(0).Selected = True
                End If
            Catch ex As Exception
                ErrorMessage(ex.ToString, "Error")
            End Try
        End Sub
        Public Function PopulateDataTable(ByVal pQuery As String) As DataTable
            SetConnectionString()
            Command = New OleDbCommand(pQuery, Connection)
            DataTable = New DataTable

            Try
                DataAdapter = New OleDb.OleDbDataAdapter(Command)
                DataAdapter.Fill(DataTable)
            Catch ex As Exception
                ErrorMessage(ex.ToString, "Error")
            End Try
            Return DataTable
        End Function
        Public Function ReturnRowCount(ByVal pTableName As String) As Integer
            SetConnectionString()
            Command = New OleDbCommand("SELECT COUNT(*) FROM [" + pTableName + "];", Connection)
            Dim tempInteger As Integer = 0
            Try
                Connection.Open()
                tempInteger = CType(Command.ExecuteScalar().ToString, Integer)
                Connection.Close()
            Catch ex As Exception
                ErrorMessage(ex.ToString, "Error")
            End Try
            Return tempInteger
        End Function
        Public Function ReturnLastID(ByVal pIDField As String, ByVal pTableName As String) As Integer
            SetConnectionString()
            Command = New OleDbCommand("SELECT LAST([" + pIDField + "]) FROM [" + pTableName + "];", Connection)
            Dim tempInteger As Integer = 0
            Try
                Connection.Open()
                tempInteger = CType(Command.ExecuteScalar().ToString, Integer)
                Connection.Close()
            Catch ex As Exception
                ErrorMessage(ex.ToString, "Error")
            End Try
            Return tempInteger
        End Function
        Public Sub InsertLoan(ByVal LoanID As Integer, ByVal ClientID As Integer, ByVal StartDate As Date, ByVal DueDate As Date, ByVal InterestRate As Double, ByVal Mode As Integer, ByVal LoanAmount As Double, ByVal RemainingBalance As Double, ByVal LoanStatus As Integer, ByVal TransactionGain As Double)
            SetConnectionString()
            Command = New OleDbCommand("INSERT INTO [dtb_Loans] ([LoanID],[ClientID],[StartDate],[DueDate],[InterestRate],[Mode],[LoanAmount],[RemainingBalance],[LoanStatus],[TransactionGain]) VALUES(" + LoanID.ToString + "," + ClientID.ToString + ",'" + StartDate.ToString("yyyy/MM/dd") + "','" + DueDate.ToString("yyyy/MM/dd") + "'," + InterestRate.ToString + "," + Mode.ToString + "," + LoanAmount.ToString + "," + RemainingBalance.ToString + "," + LoanStatus.ToString + "," + TransactionGain.ToString + ");", Connection)
            Try
                Connection.Open()
                Command.ExecuteNonQuery()
                Connection.Close()
            Catch ex As Exception
                ErrorMessage(ex.ToString, "Error")
            End Try
        End Sub
        Public Sub InsertLoanBalance(ByVal BalanceID As Integer, ByVal LoanID As Integer, ByVal MonthAmountDue As Double, ByVal MonthDueDate As Date, ByVal MonthGain As Double, ByVal PaymentStatus As Integer)
            SetConnectionString()
            Command = New OleDbCommand("INSERT INTO [dtb_LoanBalances] ([BalanceID],[LoanID],[MonthAmountDue],[MonthDueDate],[MonthGain],[PaymentStatus]) VALUES(" + BalanceID.ToString + "," + LoanID.ToString + "," + MonthAmountDue.ToString + ",'" + MonthDueDate.ToShortDateString + "'," + MonthGain.ToString + "," + PaymentStatus.ToString + ");", Connection)
            Try
                Connection.Open()
                Command.ExecuteNonQuery()
                Connection.Close()
            Catch ex As Exception
                ErrorMessage(ex.ToString, "Error")
            End Try
        End Sub
    End Class

    Public Database As New AccessConnection
End Module
