<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormDashboard
    Inherits System.Windows.Forms.Form

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        PanelMenu = New Panel()
        ButtonLogout = New Button()
        ButtonLaporan = New Button()
        ButtonTransaksi = New Button()
        ButtonDataPelanggan = New Button()
        LabelLogo = New Label()
        PanelMain = New Panel()
        LabelJudul = New Label()
        PanelMenu.SuspendLayout()
        PanelMain.SuspendLayout()
        SuspendLayout()
        ' 
        ' PanelMenu
        ' 
        PanelMenu.BackColor = Color.FromArgb(CByte(33), CByte(47), CByte(61))
        PanelMenu.Controls.Add(ButtonLogout)
        PanelMenu.Controls.Add(ButtonLaporan)
        PanelMenu.Controls.Add(ButtonTransaksi)
        PanelMenu.Controls.Add(ButtonDataPelanggan)
        PanelMenu.Controls.Add(LabelLogo)
        PanelMenu.Dock = DockStyle.Left
        PanelMenu.Location = New Point(0, 0)
        PanelMenu.Margin = New Padding(3, 4, 3, 4)
        PanelMenu.Name = "PanelMenu"
        PanelMenu.Size = New Size(200, 688)
        PanelMenu.TabIndex = 1
        ' 
        ' ButtonLogout
        ' 
        ButtonLogout.BackColor = Color.FromArgb(CByte(192), CByte(57), CByte(43))
        ButtonLogout.Dock = DockStyle.Bottom
        ButtonLogout.FlatAppearance.BorderSize = 0
        ButtonLogout.FlatStyle = FlatStyle.Flat
        ButtonLogout.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        ButtonLogout.ForeColor = Color.White
        ButtonLogout.Location = New Point(0, 632)
        ButtonLogout.Margin = New Padding(3, 4, 3, 4)
        ButtonLogout.Name = "ButtonLogout"
        ButtonLogout.Size = New Size(200, 56)
        ButtonLogout.TabIndex = 0
        ButtonLogout.Text = "Logout"
        ButtonLogout.UseVisualStyleBackColor = False
        ' 
        ' ButtonLaporan
        ' 
        ButtonLaporan.BackColor = Color.FromArgb(CByte(52), CByte(73), CByte(94))
        ButtonLaporan.Dock = DockStyle.Top
        ButtonLaporan.FlatAppearance.BorderSize = 0
        ButtonLaporan.FlatStyle = FlatStyle.Flat
        ButtonLaporan.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        ButtonLaporan.ForeColor = Color.White
        ButtonLaporan.Location = New Point(0, 187)
        ButtonLaporan.Margin = New Padding(3, 4, 3, 4)
        ButtonLaporan.Name = "ButtonLaporan"
        ButtonLaporan.Size = New Size(200, 56)
        ButtonLaporan.TabIndex = 1
        ButtonLaporan.Text = "Laporan"
        ButtonLaporan.UseVisualStyleBackColor = False
        ' 
        ' ButtonTransaksi
        ' 
        ButtonTransaksi.BackColor = Color.FromArgb(CByte(52), CByte(73), CByte(94))
        ButtonTransaksi.Dock = DockStyle.Top
        ButtonTransaksi.FlatAppearance.BorderSize = 0
        ButtonTransaksi.FlatStyle = FlatStyle.Flat
        ButtonTransaksi.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        ButtonTransaksi.ForeColor = Color.White
        ButtonTransaksi.Location = New Point(0, 131)
        ButtonTransaksi.Margin = New Padding(3, 4, 3, 4)
        ButtonTransaksi.Name = "ButtonTransaksi"
        ButtonTransaksi.Size = New Size(200, 56)
        ButtonTransaksi.TabIndex = 2
        ButtonTransaksi.Text = "Transaksi"
        ButtonTransaksi.UseVisualStyleBackColor = False
        ' 
        ' ButtonDataPelanggan
        ' 
        ButtonDataPelanggan.BackColor = Color.FromArgb(CByte(52), CByte(73), CByte(94))
        ButtonDataPelanggan.Dock = DockStyle.Top
        ButtonDataPelanggan.FlatAppearance.BorderSize = 0
        ButtonDataPelanggan.FlatStyle = FlatStyle.Flat
        ButtonDataPelanggan.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        ButtonDataPelanggan.ForeColor = Color.White
        ButtonDataPelanggan.Location = New Point(0, 75)
        ButtonDataPelanggan.Margin = New Padding(3, 4, 3, 4)
        ButtonDataPelanggan.Name = "ButtonDataPelanggan"
        ButtonDataPelanggan.Size = New Size(200, 56)
        ButtonDataPelanggan.TabIndex = 3
        ButtonDataPelanggan.Text = "Data Pelanggan"
        ButtonDataPelanggan.UseVisualStyleBackColor = False
        ' 
        ' LabelLogo
        ' 
        LabelLogo.BackColor = Color.FromArgb(CByte(41), CByte(128), CByte(185))
        LabelLogo.Dock = DockStyle.Top
        LabelLogo.Font = New Font("Segoe UI", 14F, FontStyle.Bold)
        LabelLogo.ForeColor = Color.White
        LabelLogo.Location = New Point(0, 0)
        LabelLogo.Name = "LabelLogo"
        LabelLogo.Size = New Size(200, 75)
        LabelLogo.TabIndex = 4
        LabelLogo.Text = "LAUNDRY"
        LabelLogo.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' PanelMain
        ' 
        PanelMain.BackColor = Color.White
        PanelMain.Controls.Add(LabelJudul)
        PanelMain.Dock = DockStyle.Fill
        PanelMain.Location = New Point(200, 0)
        PanelMain.Margin = New Padding(3, 4, 3, 4)
        PanelMain.Name = "PanelMain"
        PanelMain.Size = New Size(899, 688)
        PanelMain.TabIndex = 0
        ' 
        ' LabelJudul
        ' 
        LabelJudul.Dock = DockStyle.Top
        LabelJudul.Font = New Font("Segoe UI", 18F, FontStyle.Bold)
        LabelJudul.ForeColor = Color.FromArgb(CByte(44), CByte(62), CByte(80))
        LabelJudul.Location = New Point(0, 0)
        LabelJudul.Name = "LabelJudul"
        LabelJudul.Padding = New Padding(20, 25, 0, 25)
        LabelJudul.Size = New Size(899, 29)
        LabelJudul.TabIndex = 0
        LabelJudul.Text = "Selamat Datang di Aplikasi Laundry Sepatu!"
        LabelJudul.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' FormDashboard
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.WhiteSmoke
        ClientSize = New Size(1099, 688)
        ControlBox = False
        Controls.Add(PanelMain)
        Controls.Add(PanelMenu)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(3, 4, 3, 4)
        MaximizeBox = False
        MinimizeBox = False
        Name = "FormDashboard"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Dashboard - Laundry Sepatu"
        PanelMenu.ResumeLayout(False)
        PanelMain.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents PanelMenu As Panel
    Friend WithEvents LabelLogo As Label
    Friend WithEvents ButtonDataPelanggan As Button
    Friend WithEvents ButtonTransaksi As Button
    Friend WithEvents ButtonLaporan As Button
    Friend WithEvents ButtonLogout As Button
    Friend WithEvents PanelMain As Panel
    Friend WithEvents LabelJudul As Label
End Class
