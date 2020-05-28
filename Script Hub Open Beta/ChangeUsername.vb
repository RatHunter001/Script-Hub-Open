Public Class ChangeUsername
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ApplyButton.Click
        My.Settings.RobloxUsername = TextBox1.Text
        My.Settings.Save()
        If My.Settings.RobloxUsername = Nothing Or My.Settings.RobloxUsername = "" Then
            If My.Settings.Language = "Turkish" Then
                Settings.UsernameLabel.Text = EnglishSettingsLanguages.UsernameString + "(NULL)"
            ElseIf My.Settings.Language = "English" Then
                Settings.UsernameLabel.Text = TurkishSettingsLanguages.UsernameString + "(NULL)"
            Else
                Settings.UsernameLabel.Text = "Kullanıcı adı: " + "(Yok)"
            End If
        Else
            If My.Settings.Language = "Turkish" Then
                Settings.UsernameLabel.Text = TurkishSettingsLanguages.UsernameString + My.Settings.RobloxUsername
            ElseIf My.Settings.Language = "English" Then
                Settings.UsernameLabel.Text = EnglishSettingsLanguages.UsernameString + My.Settings.RobloxUsername
            Else
                Settings.UsernameLabel.Text = "Kullanıcı adı: " + My.Settings.RobloxUsername
            End If
        End If
        Settings.Show()
        Me.Close()
    End Sub

    Private Sub ChangeUsername_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ChangeUsername_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Settings.Show()
    End Sub
End Class