Imports MySql.Data.MySqlClient

Public Class FormTambah

    ' Referensi ke UC_KelolaItem agar bisa reload data setelah insert
    Public Property KelolaItemUC As UC_KelolaItem

    Private Sub BtnSimpan_Click(sender As Object, e As EventArgs) Handles BtnSimpan.Click
        ' Validasi input sederhana
        If TxtKode.Text = "" Or TxtTreatment.Text = "" Or TxtJenis.Text = "" Or TxtBiaya.Text = "" Then
            MessageBox.Show("Semua field harus diisi.", "Validasi Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' Validasi angka pada Biaya
        Dim biaya As Decimal
        If Not Decimal.TryParse(TxtBiaya.Text, biaya) Then
            MessageBox.Show("Biaya harus berupa angka valid.", "Validasi Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TxtBiaya.Focus()
            Exit Sub
        End If

        Try
            BukaKoneksi()

            ' Cek apakah Kode sudah ada
            Dim cekKode As String = "SELECT * FROM item WHERE kode = @kode"
            cmd = New MySqlCommand(cekKode, conn)
            cmd.Parameters.AddWithValue("@kode", TxtKode.Text)
            Dim rd As MySqlDataReader = cmd.ExecuteReader()

            If rd.HasRows Then
                MessageBox.Show("Kode sudah terdaftar, gunakan kode lain.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                rd.Close()
                conn.Close()
                Exit Sub
            End If
            rd.Close()

            ' Insert data baru
            Dim insertSql As String = "INSERT INTO item (kode, treatment, jenis, biaya) VALUES (@kode, @treatment, @jenis, @biaya)"
            cmd = New MySqlCommand(insertSql, conn)
            cmd.Parameters.AddWithValue("@kode", TxtKode.Text)
            cmd.Parameters.AddWithValue("@treatment", TxtTreatment.Text)
            cmd.Parameters.AddWithValue("@jenis", TxtJenis.Text)
            cmd.Parameters.AddWithValue("@biaya", biaya)

            cmd.ExecuteNonQuery()
            MessageBox.Show("Data berhasil ditambahkan.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' Update DataGridView di UC_KelolaItem (jika properti di-set)
            If KelolaItemUC IsNot Nothing Then
                KelolaItemUC.TampilkanData()
            End If

            ' Kosongkan form jika ingin input data baru
            ClearForm()

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            If conn.State = ConnectionState.Open Then conn.Close()
        End Try
    End Sub

    Private Sub BtnTutup_Click(sender As Object, e As EventArgs) Handles BtnTutup.Click
        Me.Close()
    End Sub

    Public Sub ClearForm()
        TxtKode.Clear()
        TxtTreatment.Clear()
        TxtJenis.Clear()
        TxtBiaya.Clear()
    End Sub

End Class
