Imports MySql.Data.MySqlClient
Module Module1
    Public conn As MySqlConnection
    Public cmd As MySqlCommand
    Public rd As MySqlDataReader
    Public da As MySqlDataAdapter
    Public ds As DataSet
    Public str As String
    Sub koneksi()
        Try
            Dim str As String = "Server=localhost;user id=root;password=;database=accounting;Convert Zero Datetime=True"
            conn = New MySqlConnection(str)
            If conn.State = ConnectionState.Closed Then
                conn.Open()

            Else

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Module
