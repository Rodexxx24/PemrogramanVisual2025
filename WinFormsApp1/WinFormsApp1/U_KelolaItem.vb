Imports MySql.Data.MySqlClient

Public Class UC_KelolaItem

    Sub TampilkanData()
        Try
            BukaKoneksi()
            Dim da As New MySqlDataAdapter("SELECT * FROM item", conn)
            Dim dt As New DataTable
            da.Fill(dt)
            DGVItem.DataSource = dt

            ' Ubah nama header kolom jadi kapital awal
            If DGVItem.Columns.Contains("kode") Then DGVItem.Columns("kode").HeaderText = "Kode"
            If DGVItem.Columns.Contains("treatment") Then DGVItem.Columns("treatment").HeaderText = "Treatment"
            If DGVItem.Columns.Contains("jenis") Then DGVItem.Columns("jenis").HeaderText = "Jenis"
            If DGVItem.Columns.Contains("biaya") Then DGVItem.Columns("biaya").HeaderText = "Biaya"

        Catch ex As Exception
            MessageBox.Show("Gagal menampilkan data: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub


    Private Sub UC_KelolaItem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TampilkanData()
    End Sub

    Private Sub BtnTambah_Click(sender As Object, e As EventArgs) Handles BtnTambah.Click
        ' Membuka FormTambah sebagai modal dialog
        Using frmTambah As New FormTambah()
            frmTambah.ShowDialog()
        End Using
        ' Refresh data setelah FormTambah ditutup
        TampilkanData()
    End Sub

    Private Sub BtnUbah_Click(sender As Object, e As EventArgs) Handles BtnUbah.Click
        If DGVItem.SelectedRows.Count = 0 Then
            MessageBox.Show("Pilih satu baris data yang ingin diubah.")
            Exit Sub
        End If

        Dim row = DGVItem.SelectedRows(0)
        Dim kode = row.Cells("kode").Value.ToString()
        Dim treatment = row.Cells("treatment").Value.ToString()
        Dim jenis = row.Cells("jenis").Value.ToString()
        Dim biaya = row.Cells("biaya").Value.ToString()

        ' Membuka FormUbah sebagai modal dialog, kirim data via constructor atau property
        Using frmUbah As New FormUbah(kode, treatment, jenis, biaya)
            frmUbah.ShowDialog()
        End Using
        ' Refresh data setelah FormUbah ditutup
        TampilkanData()
    End Sub

    Private Sub BtnHapus_Click(sender As Object, e As EventArgs) Handles BtnHapus.Click
        If DGVItem.SelectedRows.Count = 0 Then
            MessageBox.Show("Pilih satu baris data yang ingin dihapus.")
            Exit Sub
        End If

        Dim kode = DGVItem.SelectedRows(0).Cells("kode").Value.ToString()

        If MessageBox.Show("Yakin ingin menghapus data dengan kode: " & kode & "?", "Konfirmasi", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            Try
                BukaKoneksi()
                Dim query = "DELETE FROM item WHERE kode=@kode"
                cmd = New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@kode", kode)
                cmd.ExecuteNonQuery()
                MessageBox.Show("Data berhasil dihapus!")
                TampilkanData()
            Catch ex As Exception
                MessageBox.Show("Gagal menghapus data: " & ex.Message)
            Finally
                conn.Close()
            End Try
        End If
    End Sub
    

End Class
