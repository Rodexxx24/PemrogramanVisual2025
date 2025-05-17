Imports MySql.Data.MySqlClient

Public Class FormLogin
    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click
        If TxtUsername.Text = "" Or TxtPassword.Text = "" Then
            MessageBox.Show("Harap isi semua data login!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Try
            BukaKoneksi()

            Dim query As String = "SELECT * FROM akun WHERE (username = @user OR email = @user) AND password = @pass"
            cmd = New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@user", TxtUsername.Text)
            cmd.Parameters.AddWithValue("@pass", TxtPassword.Text)

            rd = cmd.ExecuteReader()

            If rd.HasRows Then
                rd.Read()
                MessageBox.Show("Login berhasil, selamat datang " & rd("username") & "!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)

                FormAdmin.Show()
                Me.Hide()
            Else
                MessageBox.Show("Username/email atau password salah!", "Login Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

            rd.Close()
            conn.Close()
        Catch ex As Exception
            MessageBox.Show("Terjadi kesalahan: " & ex.Message)
        End Try
    End Sub

    Private Sub LblRegis_Click(sender As Object, e As EventArgs) Handles LblRegis.Click
        Dim regisForm As New FormRegistrasi()
        regisForm.Show()
        Me.Hide() ' Sembunyikan FormLogin sementara
    End Sub

    Private Sub Guna2ImageButton1_Click(sender As Object, e As EventArgs) Handles Guna2ImageButton1.Click
        Application.Exit()
    End Sub
End Class