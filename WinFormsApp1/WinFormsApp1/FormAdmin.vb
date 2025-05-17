Public Class FormAdmin

    Private Sub LoadUserControl(ByVal uc As UserControl)
        PanelMain.Controls.Clear()       ' Hapus kontrol yang ada
        uc.Dock = DockStyle.Fill         ' Supaya memenuhi panel
        PanelMain.Controls.Add(uc)       ' Tambahkan kontrol
    End Sub

    Private Sub BtnDashboard_Click(sender As Object, e As EventArgs) Handles BtnDashboard.Click
        LoadUserControl(New UC_Dashboard())
    End Sub

    Private Sub FormAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CB_MasterData.Items.Add("Kelola Item")
        CB_MasterData.Items.Add("Kelola Outlet")
        CB_MasterData.Items.Add("Kelola User")

        ' Tampilkan UC_Dashboard pertama kali
        LoadUserControl(New UC_Dashboard())
    End Sub

    Private Sub CB_MasterData_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CB_MasterData.SelectedIndexChanged
        Select Case CB_MasterData.SelectedItem.ToString()
            Case "Kelola Item"
                LoadUserControl(New UC_KelolaItem())

            Case "Kelola Outlet"
                ' LoadUserControl(New UC_KelolaOutlet())

            Case "Kelola User"
                ' LoadUserControl(New UC_KelolaUser())
        End Select
    End Sub

    Private Sub Guna2Button5_Click(sender As Object, e As EventArgs) Handles Guna2Button5.Click
        Application.Exit()
    End Sub
End Class
