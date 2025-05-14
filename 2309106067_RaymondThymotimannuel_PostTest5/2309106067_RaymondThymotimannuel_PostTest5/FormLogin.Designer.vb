<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormLogin
    Inherits System.Windows.Forms.Form

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormLogin))
        PanelContainer = New Panel()
        LabelTitle = New Label()
        TextBoxUsername = New TextBox()
        TextBoxPassword = New TextBox()
        ButtonLogin = New Button()
        TimerLoading = New Timer(components)
        PanelLoading = New Panel()
        BtnExit = New Button()
        LabelLoading = New Label()
        ButtonExit = New Button()
        PanelContainer.SuspendLayout()
        PanelLoading.SuspendLayout()
        SuspendLayout()
        ' 
        ' PanelContainer
        ' 
        PanelContainer.BackColor = Color.DarkGreen
        PanelContainer.BackgroundImageLayout = ImageLayout.Stretch
        PanelContainer.BorderStyle = BorderStyle.Fixed3D
        PanelContainer.Controls.Add(LabelTitle)
        PanelContainer.Controls.Add(TextBoxUsername)
        PanelContainer.Controls.Add(TextBoxPassword)
        PanelContainer.Controls.Add(ButtonLogin)
        PanelContainer.Location = New Point(25, 75)
        PanelContainer.Name = "PanelContainer"
        PanelContainer.Size = New Size(350, 350)
        PanelContainer.TabIndex = 0
        ' 
        ' LabelTitle
        ' 
        LabelTitle.BackColor = Color.ForestGreen
        LabelTitle.Dock = DockStyle.Top
        LabelTitle.Font = New Font("Poppins", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LabelTitle.ForeColor = Color.White
        LabelTitle.Location = New Point(0, 0)
        LabelTitle.Name = "LabelTitle"
        LabelTitle.Size = New Size(346, 90)
        LabelTitle.TabIndex = 0
        LabelTitle.Text = "Login Laundry"
        LabelTitle.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' TextBoxUsername
        ' 
        TextBoxUsername.Font = New Font("Poppins", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBoxUsername.Location = New Point(35, 110)
        TextBoxUsername.MaxLength = 18
        TextBoxUsername.Name = "TextBoxUsername"
        TextBoxUsername.PlaceholderText = "Username"
        TextBoxUsername.Size = New Size(280, 33)
        TextBoxUsername.TabIndex = 1
        ' 
        ' TextBoxPassword
        ' 
        TextBoxPassword.Font = New Font("Poppins", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBoxPassword.Location = New Point(35, 160)
        TextBoxPassword.MaxLength = 12
        TextBoxPassword.Name = "TextBoxPassword"
        TextBoxPassword.PlaceholderText = "Password"
        TextBoxPassword.Size = New Size(280, 33)
        TextBoxPassword.TabIndex = 2
        TextBoxPassword.UseSystemPasswordChar = True
        ' 
        ' ButtonLogin
        ' 
        ButtonLogin.BackColor = Color.FromArgb(CByte(52), CByte(152), CByte(219))
        ButtonLogin.FlatAppearance.BorderSize = 0
        ButtonLogin.FlatStyle = FlatStyle.Flat
        ButtonLogin.Font = New Font("Poppins", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ButtonLogin.ForeColor = Color.White
        ButtonLogin.Location = New Point(35, 220)
        ButtonLogin.Name = "ButtonLogin"
        ButtonLogin.Size = New Size(280, 45)
        ButtonLogin.TabIndex = 3
        ButtonLogin.Text = "Login"
        ButtonLogin.UseVisualStyleBackColor = False
        ' 
        ' PanelLoading
        ' 
        PanelLoading.BackColor = Color.FromArgb(CByte(180), CByte(255), CByte(255), CByte(255))
        PanelLoading.BackgroundImage = CType(resources.GetObject("PanelLoading.BackgroundImage"), Image)
        PanelLoading.BackgroundImageLayout = ImageLayout.Stretch
        PanelLoading.Controls.Add(BtnExit)
        PanelLoading.Controls.Add(LabelLoading)
        PanelLoading.Dock = DockStyle.Fill
        PanelLoading.Location = New Point(0, 0)
        PanelLoading.Name = "PanelLoading"
        PanelLoading.Size = New Size(400, 500)
        PanelLoading.TabIndex = 1
        ' 
        ' BtnExit
        ' 
        BtnExit.BackColor = Color.Red
        BtnExit.FlatStyle = FlatStyle.Flat
        BtnExit.Font = New Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BtnExit.ForeColor = SystemColors.ButtonHighlight
        BtnExit.Location = New Point(370, 0)
        BtnExit.Name = "BtnExit"
        BtnExit.Size = New Size(30, 30)
        BtnExit.TabIndex = 3
        BtnExit.TabStop = False
        BtnExit.Text = "X"
        BtnExit.UseVisualStyleBackColor = False
        ' 
        ' LabelLoading
        ' 
        LabelLoading.AutoSize = True
        LabelLoading.Font = New Font("Segoe UI", 14F, FontStyle.Italic)
        LabelLoading.ForeColor = Color.Gray
        LabelLoading.Location = New Point(140, 230)
        LabelLoading.Name = "LabelLoading"
        LabelLoading.Size = New Size(116, 32)
        LabelLoading.TabIndex = 0
        LabelLoading.Text = "Memuat..."
        ' 
        ' ButtonExit
        ' 
        ButtonExit.BackColor = Color.Transparent
        ButtonExit.Cursor = Cursors.Hand
        ButtonExit.FlatAppearance.BorderSize = 0
        ButtonExit.FlatStyle = FlatStyle.Flat
        ButtonExit.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        ButtonExit.ForeColor = Color.DarkGray
        ButtonExit.Location = New Point(360, 10)
        ButtonExit.Name = "ButtonExit"
        ButtonExit.Size = New Size(30, 30)
        ButtonExit.TabIndex = 2
        ButtonExit.Text = "X"
        ButtonExit.UseVisualStyleBackColor = False
        ' 
        ' FormLogin
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Silver
        ClientSize = New Size(400, 500)
        ControlBox = False
        Controls.Add(PanelContainer)
        Controls.Add(PanelLoading)
        Controls.Add(ButtonExit)
        FormBorderStyle = FormBorderStyle.None
        MaximizeBox = False
        MinimizeBox = False
        Name = "FormLogin"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Login - Laundry Sepatu"
        PanelContainer.ResumeLayout(False)
        PanelContainer.PerformLayout()
        PanelLoading.ResumeLayout(False)
        PanelLoading.PerformLayout()
        ResumeLayout(False)

    End Sub

    Friend WithEvents PanelContainer As Panel
    Friend WithEvents LabelTitle As Label
    Friend WithEvents TextBoxUsername As TextBox
    Friend WithEvents TextBoxPassword As TextBox
    Friend WithEvents ButtonLogin As Button
    Friend WithEvents TimerLoading As Timer
    Friend WithEvents PanelLoading As Panel
    Friend WithEvents LabelLoading As Label
    Friend WithEvents ButtonExit As Button
    Friend WithEvents BtnExit As Button
End Class
