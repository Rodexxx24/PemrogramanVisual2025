Imports System.Windows.Forms
Imports System.Runtime.InteropServices

Public Class FormDashboard

    ' Import fungsi Windows API
    <DllImport("user32.dll")>
    Public Shared Function ReleaseCapture() As Boolean
    End Function

    <DllImport("user32.dll")>
    Public Shared Function SendMessage(hWnd As IntPtr, wMsg As Integer, wParam As Integer, lParam As Integer) As Integer
    End Function

    Private Const WM_NCLBUTTONDOWN As Integer = &HA1
    Private Const HTCAPTION As Integer = 2

    Private Sub FormDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TampilkanBeranda()
    End Sub

    Private Sub TampilkanBeranda()
        PanelMain.Controls.Clear()
        PanelMain.Controls.Add(LabelJudul)
        LabelJudul.Text = "Selamat Datang di Aplikasi Laundry Sepatu!"
    End Sub

    Private Sub LabelLogo_Click(sender As Object, e As EventArgs) Handles LabelLogo.Click
        TampilkanBeranda()
    End Sub

    Private Sub ButtonDataPelanggan_Click(sender As Object, e As EventArgs) Handles ButtonDataPelanggan.Click
        Dim uc As New UC_DataPelanggan()
        PanelMain.Controls.Clear()
        uc.Dock = DockStyle.Fill
        PanelMain.Controls.Add(uc)
    End Sub

    Private Sub ButtonTransaksi_Click(sender As Object, e As EventArgs) Handles ButtonTransaksi.Click
        MessageBox.Show("Fitur Transaksi belum tersedia.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub ButtonLaporan_Click(sender As Object, e As EventArgs) Handles ButtonLaporan.Click
        MessageBox.Show("Fitur Laporan belum tersedia.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub ButtonLogout_Click(sender As Object, e As EventArgs) Handles ButtonLogout.Click
        Dim result = MessageBox.Show("Apakah Anda yakin ingin logout?", "Konfirmasi Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Me.Hide()
            FormLogin.ResetForm()
            FormLogin.Show()
        End If
    End Sub

    Private Sub DragForm()
        ReleaseCapture()
        SendMessage(Me.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0)
    End Sub

    Private Sub FormDashboard_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown
        If e.Button = MouseButtons.Left Then
            DragForm()
        End If
    End Sub

    Private Sub PanelMain_MouseDown(sender As Object, e As MouseEventArgs) Handles PanelMain.MouseDown
        If e.Button = MouseButtons.Left Then
            DragForm()
        End If
    End Sub

End Class
