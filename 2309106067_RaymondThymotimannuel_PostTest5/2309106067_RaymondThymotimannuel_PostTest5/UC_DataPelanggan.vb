Imports MySql.Data.MySqlClient

Public Class UC_DataPelanggan
    Dim selectedId As Integer = -1

    Private Sub UC_DataPelanggan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TampilData()
    End Sub

    Sub TampilData()
        BukaKoneksi()
        Dim da As New MySqlDataAdapter("SELECT * FROM pelanggan", Conn)
        Dim dt As New DataTable()
        da.Fill(dt)
        DataGridViewPelanggan.DataSource = dt
        Conn.Close()
    End Sub

    Sub Bersihkan()
        TextBoxNama.Text = ""
        TextBoxTelepon.Text = ""
        TextBoxEmail.Text = ""
        TextBoxAlamat.Text = ""
        selectedId = -1
    End Sub

    Function ValidasiInput() As Boolean
        If TextBoxNama.Text.Trim() = "" Then
            MessageBox.Show("Nama wajib diisi. Contoh: Budi Hartono")
            Return False
        End If

        If TextBoxTelepon.Text.Trim() = "" Then
            MessageBox.Show("Nomor telepon wajib diisi. Contoh: 081234567890")
            Return False
        End If

        If Not IsNumeric(TextBoxTelepon.Text.Trim()) Then
            MessageBox.Show("Nomor telepon harus berupa angka.")
            Return False
        End If

        If TextBoxTelepon.Text.Trim().Length > 15 Then
            MessageBox.Show("Nomor telepon maksimal 15 digit.")
            Return False
        End If

        If TextBoxEmail.Text.Trim() = "" Then
            MessageBox.Show("Email wajib diisi. Contoh: nama@email.com")
            Return False
        End If

        If TextBoxEmail.Text.Length > 50 Then
            MessageBox.Show("Email maksimal 50 karakter.")
            Return False
        End If

        If TextBoxAlamat.Text.Trim() = "" Then
            MessageBox.Show("Alamat wajib diisi. Contoh: Jl. Merdeka No. 10, Jakarta")
            Return False
        End If

        Return True
    End Function

    Private Sub BtnTambah_Click(sender As Object, e As EventArgs) Handles BtnTambah.Click
        If Not ValidasiInput() Then Exit Sub

        BukaKoneksi()
        Cmd = New MySqlCommand("INSERT INTO pelanggan(nama, telepon, email, alamat) VALUES(@nama, @telepon, @email, @alamat)", Conn)
        Cmd.Parameters.AddWithValue("@nama", TextBoxNama.Text.Trim())
        Cmd.Parameters.AddWithValue("@telepon", TextBoxTelepon.Text.Trim())
        Cmd.Parameters.AddWithValue("@email", TextBoxEmail.Text.Trim())
        Cmd.Parameters.AddWithValue("@alamat", TextBoxAlamat.Text.Trim())
        Cmd.ExecuteNonQuery()
        Conn.Close()

        MessageBox.Show("Data pelanggan berhasil ditambahkan.")
        TampilData()
        Bersihkan()
    End Sub

    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles BtnEdit.Click
        If selectedId = -1 Then
            MessageBox.Show("Pilih data yang akan diubah.")
            Return
        End If

        If Not ValidasiInput() Then Exit Sub

        BukaKoneksi()
        Cmd = New MySqlCommand("UPDATE pelanggan SET nama=@nama, telepon=@telepon, email=@email, alamat=@alamat WHERE id=@id", Conn)
        Cmd.Parameters.AddWithValue("@id", selectedId)
        Cmd.Parameters.AddWithValue("@nama", TextBoxNama.Text.Trim())
        Cmd.Parameters.AddWithValue("@telepon", TextBoxTelepon.Text.Trim())
        Cmd.Parameters.AddWithValue("@email", TextBoxEmail.Text.Trim())
        Cmd.Parameters.AddWithValue("@alamat", TextBoxAlamat.Text.Trim())
        Cmd.ExecuteNonQuery()
        Conn.Close()

        MessageBox.Show("Data berhasil diperbarui.")
        TampilData()
        Bersihkan()
    End Sub

    Private Sub BtnHapus_Click(sender As Object, e As EventArgs) Handles BtnHapus.Click
        If selectedId = -1 Then
            MessageBox.Show("Pilih data yang akan dihapus.")
            Return
        End If

        If MessageBox.Show("Yakin ingin menghapus data ini?", "Konfirmasi", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            BukaKoneksi()
            Cmd = New MySqlCommand("DELETE FROM pelanggan WHERE id=@id", Conn)
            Cmd.Parameters.AddWithValue("@id", selectedId)
            Cmd.ExecuteNonQuery()
            Conn.Close()

            MessageBox.Show("Data berhasil dihapus.")
            TampilData()
            Bersihkan()
        End If
    End Sub

    Private Sub DataGridViewPelanggan_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewPelanggan.CellClick
        Try
            If e.RowIndex >= 0 AndAlso e.RowIndex < DataGridViewPelanggan.Rows.Count Then
                Dim row = DataGridViewPelanggan.Rows(e.RowIndex)
                If Not row.IsNewRow Then
                    selectedId = Convert.ToInt32(row.Cells("id").Value)
                    TextBoxNama.Text = row.Cells("nama").Value?.ToString()
                    TextBoxTelepon.Text = row.Cells("telepon").Value?.ToString()
                    TextBoxEmail.Text = row.Cells("email").Value?.ToString()
                    TextBoxAlamat.Text = row.Cells("alamat").Value?.ToString()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Gagal memuat data dari baris yang diklik. Detail: " & ex.Message)
        End Try
    End Sub

    Private Sub BtnBersih_Click(sender As Object, e As EventArgs) Handles BtnBersih.Click
        Bersihkan()
    End Sub

    Private Sub BtnRefresh_Click(sender As Object, e As EventArgs) Handles BtnRefresh.Click
        TampilData()
    End Sub
End Class
