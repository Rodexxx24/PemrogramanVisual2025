Imports MySql.Data.MySqlClient

Module ModuleKoneksi
    Public Conn As MySqlConnection
    Public Cmd As MySqlCommand
    Public Rd As MySqlDataReader

    Public Sub BukaKoneksi()
        Try
            Conn = New MySqlConnection("server=localhost;user id=root;password=;database=dbAkun")
            If Conn.State = ConnectionState.Closed Then
                Conn.Open()
            End If
        Catch ex As Exception
            MessageBox.Show("Koneksi Gagal: " & ex.Message)
        End Try
    End Sub
End Module
