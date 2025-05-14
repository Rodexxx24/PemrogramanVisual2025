Imports MySql.Data.MySqlClient

Public Class FormLogin
    Private targetLeft As Integer
    Private targetTop As Integer
    Private animationSpeed As Integer = 5
    Private WithEvents TimerCentering As New Timer()
    Private WithEvents TimerMasuk As New Timer()
    Private WithEvents TimerKeluar As New Timer()
    Private loginSukses As Boolean = False

    ' FormLoad
    Private Sub FormLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Fokus pada TextBoxUsername
        TextBoxUsername.Focus()

        ' Mengatur form agar tidak memiliki border dan tampil di tengah
        Me.FormBorderStyle = FormBorderStyle.None
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.WindowState = FormWindowState.Normal

        ' Pastikan panel login dimulai di atas layar
        PanelContainer.Top = -PanelContainer.Height  ' Mulai panel di luar layar
        SetTargetPosition()  ' Set posisi panel login ke tengah

        ' Mulai animasi panel masuk
        TimerMasuk.Interval = 5 ' Kecepatan animasi masuk lebih cepat
        TimerMasuk.Start()  ' Mulai animasi

        ' Fokus pada TextBoxUsername untuk pertama kali
        Me.TextBoxUsername.Select()
    End Sub


    ' Resize Form
    Private Sub FormLogin_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        SetTargetPosition()
        TimerCentering.Start()
    End Sub

    ' Atur posisi target panel di tengah
    Private Sub SetTargetPosition()
        targetLeft = (Me.ClientSize.Width - PanelContainer.Width) \ 2
        targetTop = (Me.ClientSize.Height - PanelContainer.Height) \ 2
    End Sub

    ' Efek centering panel
    Private Sub TimerCentering_Tick(sender As Object, e As EventArgs) Handles TimerCentering.Tick
        Dim dx As Integer = (targetLeft - PanelContainer.Left) \ 2
        Dim dy As Integer = (targetTop - PanelContainer.Top) \ 2

        If Math.Abs(dx) < 2 AndAlso Math.Abs(dy) < 2 Then
            PanelContainer.Left = targetLeft
            PanelContainer.Top = targetTop
            TimerCentering.Stop()
        Else
            PanelContainer.Left += dx
            PanelContainer.Top += dy
        End If
    End Sub

    ' Animasi panel masuk dari atas ke tengah
    Private Sub TimerMasuk_Tick(sender As Object, e As EventArgs) Handles TimerMasuk.Tick
        If PanelContainer.Top < targetTop Then
            PanelContainer.Top += 5 ' Lebih lambat agar animasi lebih halus
        Else
            PanelContainer.Top = targetTop
            TimerMasuk.Stop()
            ' Pastikan elemen login dapat diakses setelah animasi selesai
            PanelContainer.Visible = True
        End If
    End Sub

    ' Animasi panel keluar setelah login
    Private Sub TimerKeluar_Tick(sender As Object, e As EventArgs) Handles TimerKeluar.Tick
        If PanelContainer.Top > -PanelContainer.Height Then
            PanelContainer.Top -= 5 ' Perubahan posisi lebih kecil untuk animasi lebih halus
        Else
            TimerKeluar.Stop()
            If loginSukses Then
                MessageBox.Show("Login berhasil!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Hide()
                FormDashboard.Show()
            End If
        End If
    End Sub


    ' Tombol Login Click
    Private Sub ButtonLogin_Click(sender As Object, e As EventArgs) Handles ButtonLogin.Click
        ProsesLogin()
    End Sub

    ' Tombol Enter pada Password
    Private Sub TextBoxPassword_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBoxPassword.KeyDown
        If e.KeyCode = Keys.Enter Then
            ProsesLogin()
        End If
    End Sub

    ' Proses Login
    Private Sub ProsesLogin()
        If TextBoxUsername.Text.Trim() = "" Or TextBoxPassword.Text.Trim() = "" Then
            MessageBox.Show("Silakan isi Username dan Password.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            BukaKoneksi()
            Cmd = New MySqlCommand("SELECT * FROM admin WHERE username=@username AND password=@password", Conn)
            Cmd.Parameters.AddWithValue("@username", TextBoxUsername.Text.Trim())
            Cmd.Parameters.AddWithValue("@password", TextBoxPassword.Text.Trim())
            Rd = Cmd.ExecuteReader()

            If Rd.HasRows Then
                Rd.Read()
                loginSukses = True
                TimerKeluar.Start()
            Else
                MessageBox.Show("Username atau Password salah.", "Gagal Login", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Catch ex As Exception
            MessageBox.Show("Terjadi kesalahan koneksi: " & ex.Message)
        Finally
            Conn.Close()
        End Try
    End Sub

    ' Efek hover pada tombol Login
    Private Sub ButtonLogin_MouseEnter(sender As Object, e As EventArgs) Handles ButtonLogin.MouseEnter
        ButtonLogin.BackColor = Color.FromArgb(41, 128, 185)
        ButtonLogin.Font = New Font(ButtonLogin.Font.Name, ButtonLogin.Font.Size + 2, FontStyle.Bold) ' Font tebal saat hover
    End Sub

    ' Efek hover keluar pada tombol Login
    Private Sub ButtonLogin_MouseLeave(sender As Object, e As EventArgs) Handles ButtonLogin.MouseLeave
        ButtonLogin.BackColor = Color.FromArgb(52, 152, 219)
        ButtonLogin.Font = New Font(ButtonLogin.Font.Name, ButtonLogin.Font.Size - 2, FontStyle.Regular) ' Font kembali normal
    End Sub

    ' Tombol Exit (X) custom
    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        Application.Exit()
    End Sub

    Public Sub ResetForm()
        ' Clear username dan password, dan pastikan kontrol di panel terlihat
        TextBoxUsername.Clear()
        TextBoxPassword.Clear()
        TextBoxUsername.Focus()

        ' Pastikan panel login dalam posisi yang benar
        PanelContainer.Visible = True
        PanelContainer.Top = -PanelContainer.Height  ' Menyembunyikan panel login terlebih dahulu
        SetTargetPosition()  ' Mengatur posisi kembali ke tengah layar
        TimerMasuk.Start()  ' Memulai animasi masuk kembali
    End Sub
End Class
