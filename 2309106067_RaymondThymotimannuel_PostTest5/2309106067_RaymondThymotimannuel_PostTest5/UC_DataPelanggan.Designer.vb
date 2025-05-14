Imports System.Drawing

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UC_DataPelanggan
    Inherits System.Windows.Forms.UserControl

    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UC_DataPelanggan))
        LabelTitle = New Label()
        LabelNama = New Label()
        LabelTelepon = New Label()
        LabelEmail = New Label()
        LabelAlamat = New Label()
        TextBoxNama = New TextBox()
        TextBoxTelepon = New TextBox()
        TextBoxEmail = New TextBox()
        TextBoxAlamat = New TextBox()
        DataGridViewPelanggan = New DataGridView()
        BtnTambah = New Button()
        BtnEdit = New Button()
        BtnHapus = New Button()
        BtnBersih = New Button()
        BtnRefresh = New Button()
        CType(DataGridViewPelanggan, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' LabelTitle
        ' 
        LabelTitle.AutoSize = True
        LabelTitle.BackColor = Color.Transparent
        LabelTitle.Font = New Font("Poppins", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LabelTitle.ForeColor = Color.FromArgb(CByte(40), CByte(40), CByte(40))
        LabelTitle.Location = New Point(20, 20)
        LabelTitle.Name = "LabelTitle"
        LabelTitle.Size = New Size(253, 50)
        LabelTitle.TabIndex = 0
        LabelTitle.Text = "Data Pelanggan"
        ' 
        ' LabelNama
        ' 
        LabelNama.AutoSize = True
        LabelNama.BackColor = Color.Transparent
        LabelNama.Location = New Point(20, 70)
        LabelNama.Name = "LabelNama"
        LabelNama.Size = New Size(58, 26)
        LabelNama.TabIndex = 1
        LabelNama.Text = "Nama"
        ' 
        ' LabelTelepon
        ' 
        LabelTelepon.AutoSize = True
        LabelTelepon.BackColor = Color.Transparent
        LabelTelepon.Location = New Point(20, 110)
        LabelTelepon.Name = "LabelTelepon"
        LabelTelepon.Size = New Size(72, 26)
        LabelTelepon.TabIndex = 2
        LabelTelepon.Text = "Telepon"
        ' 
        ' LabelEmail
        ' 
        LabelEmail.AutoSize = True
        LabelEmail.BackColor = Color.Transparent
        LabelEmail.Location = New Point(20, 150)
        LabelEmail.Name = "LabelEmail"
        LabelEmail.Size = New Size(53, 26)
        LabelEmail.TabIndex = 3
        LabelEmail.Text = "Email"
        ' 
        ' LabelAlamat
        ' 
        LabelAlamat.AutoSize = True
        LabelAlamat.BackColor = Color.Transparent
        LabelAlamat.Location = New Point(20, 190)
        LabelAlamat.Name = "LabelAlamat"
        LabelAlamat.Size = New Size(66, 26)
        LabelAlamat.TabIndex = 4
        LabelAlamat.Text = "Alamat"
        ' 
        ' TextBoxNama
        ' 
        TextBoxNama.Location = New Point(100, 67)
        TextBoxNama.Name = "TextBoxNama"
        TextBoxNama.Size = New Size(250, 30)
        TextBoxNama.TabIndex = 5
        ' 
        ' TextBoxTelepon
        ' 
        TextBoxTelepon.Location = New Point(100, 107)
        TextBoxTelepon.Name = "TextBoxTelepon"
        TextBoxTelepon.Size = New Size(250, 30)
        TextBoxTelepon.TabIndex = 6
        ' 
        ' TextBoxEmail
        ' 
        TextBoxEmail.Location = New Point(100, 147)
        TextBoxEmail.Name = "TextBoxEmail"
        TextBoxEmail.Size = New Size(250, 30)
        TextBoxEmail.TabIndex = 7
        ' 
        ' TextBoxAlamat
        ' 
        TextBoxAlamat.Location = New Point(100, 187)
        TextBoxAlamat.Name = "TextBoxAlamat"
        TextBoxAlamat.Size = New Size(250, 30)
        TextBoxAlamat.TabIndex = 8
        ' 
        ' DataGridViewPelanggan
        ' 
        DataGridViewCellStyle1.BackColor = Color.FromArgb(CByte(240), CByte(240), CByte(240))
        DataGridViewPelanggan.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = Color.FromArgb(CByte(0), CByte(122), CByte(204))
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle2.ForeColor = Color.White
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        DataGridViewPelanggan.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        DataGridViewPelanggan.ColumnHeadersHeight = 29
        DataGridViewPelanggan.EnableHeadersVisualStyles = False
        DataGridViewPelanggan.Location = New Point(380, 67)
        DataGridViewPelanggan.Name = "DataGridViewPelanggan"
        DataGridViewPelanggan.ReadOnly = True
        DataGridViewPelanggan.RowHeadersWidth = 51
        DataGridViewCellStyle3.BackColor = Color.White
        DataGridViewPelanggan.RowsDefaultCellStyle = DataGridViewCellStyle3
        DataGridViewPelanggan.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DataGridViewPelanggan.Size = New Size(500, 320)
        DataGridViewPelanggan.TabIndex = 9
        ' 
        ' BtnTambah
        ' 
        BtnTambah.BackColor = Color.FromArgb(CByte(0), CByte(122), CByte(204))
        BtnTambah.FlatStyle = FlatStyle.Flat
        BtnTambah.ForeColor = Color.White
        BtnTambah.Location = New Point(20, 240)
        BtnTambah.Name = "BtnTambah"
        BtnTambah.Size = New Size(98, 35)
        BtnTambah.TabIndex = 10
        BtnTambah.Text = "Tambah"
        BtnTambah.UseVisualStyleBackColor = False
        ' 
        ' BtnEdit
        ' 
        BtnEdit.BackColor = Color.FromArgb(CByte(0), CByte(122), CByte(204))
        BtnEdit.FlatStyle = FlatStyle.Flat
        BtnEdit.ForeColor = Color.White
        BtnEdit.Location = New Point(124, 240)
        BtnEdit.Name = "BtnEdit"
        BtnEdit.Size = New Size(80, 35)
        BtnEdit.TabIndex = 11
        BtnEdit.Text = "Edit"
        BtnEdit.UseVisualStyleBackColor = False
        ' 
        ' BtnHapus
        ' 
        BtnHapus.BackColor = Color.FromArgb(CByte(204), CByte(0), CByte(0))
        BtnHapus.FlatStyle = FlatStyle.Flat
        BtnHapus.ForeColor = Color.White
        BtnHapus.Location = New Point(210, 240)
        BtnHapus.Name = "BtnHapus"
        BtnHapus.Size = New Size(80, 35)
        BtnHapus.TabIndex = 12
        BtnHapus.Text = "Hapus"
        BtnHapus.UseVisualStyleBackColor = False
        ' 
        ' BtnBersih
        ' 
        BtnBersih.BackColor = Color.Gray
        BtnBersih.FlatStyle = FlatStyle.Flat
        BtnBersih.ForeColor = Color.White
        BtnBersih.Location = New Point(20, 285)
        BtnBersih.Name = "BtnBersih"
        BtnBersih.Size = New Size(130, 35)
        BtnBersih.TabIndex = 13
        BtnBersih.Text = "Bersih"
        BtnBersih.UseVisualStyleBackColor = False
        ' 
        ' BtnRefresh
        ' 
        BtnRefresh.BackColor = Color.Gray
        BtnRefresh.FlatStyle = FlatStyle.Flat
        BtnRefresh.ForeColor = Color.White
        BtnRefresh.Location = New Point(160, 285)
        BtnRefresh.Name = "BtnRefresh"
        BtnRefresh.Size = New Size(130, 35)
        BtnRefresh.TabIndex = 14
        BtnRefresh.Text = "Refresh"
        BtnRefresh.UseVisualStyleBackColor = False
        ' 
        ' UC_DataPelanggan
        ' 
        BackColor = Color.White
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        Controls.Add(LabelTitle)
        Controls.Add(LabelNama)
        Controls.Add(LabelTelepon)
        Controls.Add(LabelEmail)
        Controls.Add(LabelAlamat)
        Controls.Add(TextBoxNama)
        Controls.Add(TextBoxTelepon)
        Controls.Add(TextBoxEmail)
        Controls.Add(TextBoxAlamat)
        Controls.Add(DataGridViewPelanggan)
        Controls.Add(BtnTambah)
        Controls.Add(BtnEdit)
        Controls.Add(BtnHapus)
        Controls.Add(BtnBersih)
        Controls.Add(BtnRefresh)
        Font = New Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Name = "UC_DataPelanggan"
        Size = New Size(900, 450)
        CType(DataGridViewPelanggan, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents LabelTitle As Label
    Friend WithEvents LabelNama As Label
    Friend WithEvents LabelTelepon As Label
    Friend WithEvents LabelEmail As Label
    Friend WithEvents LabelAlamat As Label
    Friend WithEvents TextBoxNama As TextBox
    Friend WithEvents TextBoxTelepon As TextBox
    Friend WithEvents TextBoxEmail As TextBox
    Friend WithEvents TextBoxAlamat As TextBox
    Friend WithEvents DataGridViewPelanggan As DataGridView
    Friend WithEvents BtnTambah As Button
    Friend WithEvents BtnEdit As Button
    Friend WithEvents BtnHapus As Button
    Friend WithEvents BtnBersih As Button
    Friend WithEvents BtnRefresh As Button

End Class
