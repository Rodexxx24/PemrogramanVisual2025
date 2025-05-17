Imports MySql.Data.MySqlClient
Imports System.Text.RegularExpressions

Public Class FormRegistrasi

    Private Sub BtnRegistrasi_Click(sender As Object, e As EventArgs) Handles BtnRegistrasi.Click
        ' Validasi Nama Lengkap (huruf saja, max 25)
        If Not Regex.IsMatch(TxtNamaLengkap.Text, "^[a-zA-Z\s]{1,25}$") Then
            MessageBox.Show("Nama lengkap harus huruf saja dan maksimal 25 karakter.", "Validasi Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TxtNamaLengkap.Focus()
            Exit Sub
        End If

        ' Validasi Email (ada @ dan max 25 karakter)
        If TxtEmail.Text.Length > 25 OrElse Not TxtEmail.Text.Contains("@") Then
            MessageBox.Show("Email harus valid dan maksimal 25 karakter.", "Validasi Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TxtEmail.Focus()
            Exit Sub
        End If

        ' Validasi Username (max 18 karakter)
        If TxtUsername.Text.Length = 0 OrElse TxtUsername.Text.Length > 18 Then
            MessageBox.Show("Username harus diisi dan maksimal 18 karakter.", "Validasi Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TxtUsername.Focus()
            Exit Sub
        End If

        ' Validasi Password (max 12 karakter)
        If TxtPassword.Text.Length = 0 OrElse TxtPassword.Text.Length > 12 Then
            MessageBox.Show("Password harus diisi dan maksimal 12 karakter.", "Validasi Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TxtPassword.Focus()
            Exit Sub
        End If

        ' Validasi No.Hp (angka saja, max 13)
        If Not Regex.IsMatch(TxtNoHp.Text, "^\d{1,13}$") Then
            MessageBox.Show("Nomor HP harus angka dan maksimal 13 digit.", "Validasi Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TxtNoHp.Focus()
            Exit Sub
        End If

        ' Validasi Alamat (max 35 karakter)
        If TxtAlamat.Text.Length = 0 OrElse TxtAlamat.Text.Length > 35 Then
            MessageBox.Show("Alamat harus diisi dan maksimal 35 karakter.", "Validasi Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TxtAlamat.Focus()
            Exit Sub
        End If

        ' Validasi Checkbox setuju
        If Not ChkSetuju.Checked Then
            MessageBox.Show("Anda harus menyetujui syarat dan ketentuan.", "Validasi Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            ChkSetuju.Focus()
            Exit Sub
        End If

        ' Simpan data ke database
        Try
            BukaKoneksi()

            Dim cekUser As String = "SELECT username, email FROM akun WHERE username=@username OR email=@email"
            cmd = New MySqlCommand(cekUser, conn)
            cmd.Parameters.AddWithValue("@username", TxtUsername.Text)
            cmd.Parameters.AddWithValue("@email", TxtEmail.Text)
            Dim rd As MySqlDataReader = cmd.ExecuteReader()

            Dim isUsernameUsed As Boolean = False
            Dim isEmailUsed As Boolean = False

            While rd.Read()
                If rd("username").ToString().ToLower() = TxtUsername.Text.ToLower() Then
                    isUsernameUsed = True
                End If
                If rd("email").ToString().ToLower() = TxtEmail.Text.ToLower() Then
                    isEmailUsed = True
                End If
            End While

            rd.Close()

            If isUsernameUsed Or isEmailUsed Then
                Dim pesan As String = "Pendaftaran gagal karena: " & vbCrLf
                If isUsernameUsed Then pesan &= "- Username sudah terdaftar." & vbCrLf
                If isEmailUsed Then pesan &= "- Email sudah terdaftar."
                MessageBox.Show(pesan, "Pendaftaran Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                conn.Close()
                Exit Sub
            End If

            ' Insert data baru
            Dim insertSql As String = "INSERT INTO akun (username, email, password, nama_lengkap, no_hp, alamat) VALUES (@username, @email, @password, @nama, @nohp, @alamat)"
            cmd = New MySqlCommand(insertSql, conn)
            cmd.Parameters.AddWithValue("@username", TxtUsername.Text)
            cmd.Parameters.AddWithValue("@email", TxtEmail.Text)
            cmd.Parameters.AddWithValue("@password", TxtPassword.Text)
            cmd.Parameters.AddWithValue("@nama", TxtNamaLengkap.Text)
            cmd.Parameters.AddWithValue("@nohp", TxtNoHp.Text)
            cmd.Parameters.AddWithValue("@alamat", TxtAlamat.Text)

            cmd.ExecuteNonQuery()
            MessageBox.Show("Registrasi berhasil! Silakan login.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Me.Close()
            FormLogin.Show()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            If conn.State = ConnectionState.Open Then conn.Close()
        End Try

    End Sub

    Private Sub LblLogin_Click(sender As Object, e As EventArgs) Handles LblLogin.Click
        FormLogin.Show()
        Me.Close()
    End Sub

End Class