Public Class Settings
    Private Sub Settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Button1.BackColor = My.Settings.BackgroundColorMain
        If My.Settings.RobloxUsername = Nothing Or My.Settings.RobloxUsername = "" Then
            Label2.Text = "Kullanıcı adı: " + "(Yok)"
        Else
            Label2.Text = "Kullanıcı adı: " + My.Settings.RobloxUsername
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MainForm.ColorDialog1.ShowDialog()
        My.Settings.BackgroundColorMain = MainForm.ColorDialog1.Color
        My.Settings.Save()
        MainForm.BackColor = My.Settings.BackgroundColorMain
        Button1.BackColor = My.Settings.BackgroundColorMain
    End Sub

    Private Sub Settings_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        MainForm.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        ChangeUsername.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub
End Class