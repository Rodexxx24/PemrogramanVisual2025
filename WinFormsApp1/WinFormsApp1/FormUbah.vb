Public Class FormUbah
    ' Konstruktor untuk menerima data dari form sebelumnya
    Public Sub New(kode As String, treatment As String, jenis As String, biaya As String)
        ' Wajib dipanggil terlebih dahulu
        InitializeComponent()

        ' Set nilai textbox sesuai data dari UC_KelolaItem
        TxtKode.Text = kode
        txtTreatment.Text = treatment
        TxtJenis.Text = jenis
        TxtBiaya.Text = biaya

        ' Kode tidak boleh diubah (jika kode jadi primary key)
        TxtKode.Enabled = False
    End Sub

    ' Tombol untuk menyimpan perubahan
    Private Sub BtnSimpan_Click(sender As Object, e As EventArgs) Handles BtnSimpan.Click
        If txtTreatment.Text = "" Or TxtJenis.Text = "" Or TxtBiaya.Text = "" Then
            MessageBox.Show("Semua field kecuali Kode wajib diisi.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Try
            BukaKoneksi()
            Dim query As String = "UPDATE item SET Treatment=@treatment, Jenis=@jenis, Biaya=@biaya WHERE Kode=@kode"
            cmd = New MySql.Data.MySqlClient.MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@treatment", txtTreatment.Text)
            cmd.Parameters.AddWithValue("@jenis", TxtJenis.Text)
            cmd.Parameters.AddWithValue("@biaya", TxtBiaya.Text)
            cmd.Parameters.AddWithValue("@kode", TxtKode.Text)
            cmd.ExecuteNonQuery()

            MessageBox.Show("Data berhasil diubah.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        Catch ex As Exception
            MessageBox.Show("Gagal mengubah data: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    ' Tombol untuk menutup form
    Private Sub BtnTutup_Click(sender As Object, e As EventArgs) Handles BtnTutup.Click
        Me.Close()
    End Sub
End Class
