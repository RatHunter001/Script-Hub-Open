Public Class Settings
    Private Sub Settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Button1.BackColor = My.Settings.BackgroundColorMain
        If My.Settings.Language = "Turkish" Then
            ComboBox1.SelectedItem = "Turkish"
        ElseIf My.Settings.Language = "English" Then
            ComboBox1.SelectedItem = "English"
        Else
            ComboBox1.SelectedItem = "English"
        End If
        If My.Settings.RobloxUsername = Nothing Or My.Settings.RobloxUsername = "" Then
            If My.Settings.Language = "Turkish" Then
                UsernameLabel.Text = TurkishSettingsLanguages.UsernameString + "(NULL)"
            ElseIf My.Settings.Language = "English" Then
                UsernameLabel.Text = EnglishSettingsLanguages.UsernameString + "(NULL)"
            Else
                UsernameLabel.Text = EnglishSettingsLanguages.UsernameString + "(NULL)"
            End If

        Else
            If My.Settings.Language = "Turkish" Then
                UsernameLabel.Text = TurkishSettingsLanguages.UsernameString + My.Settings.RobloxUsername
            ElseIf My.Settings.Language = "English" Then
                UsernameLabel.Text = EnglishSettingsLanguages.UsernameString + My.Settings.RobloxUsername
            Else
                UsernameLabel.Text = EnglishSettingsLanguages.UsernameString + My.Settings.RobloxUsername
            End If

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

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles ChangeButton.Click
        Me.Hide()
        ChangeUsername.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        Me.Close()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

        Select Case ComboBox1.SelectedItem
            Case "Turkish"
                LanguageFunctions.ChangeLanguage("MainForm", "Turkish")
                LanguageFunctions.ChangeLanguage("Settings", "Turkish")
                LanguageFunctions.ChangeLanguage("ChangeUsername", "Turkish")
                LanguageFunctions.ChangeLanguage("About", "Turkish")
            Case "English"
                LanguageFunctions.ChangeLanguage("MainForm", "English")
                LanguageFunctions.ChangeLanguage("Settings", "English")
                LanguageFunctions.ChangeLanguage("ChangeUsername", "English")
                LanguageFunctions.ChangeLanguage("About", "English")
        End Select
        If My.Settings.RobloxUsername = Nothing Or My.Settings.RobloxUsername = "" Then
            If My.Settings.Language = "Turkish" Then
                UsernameLabel.Text = TurkishSettingsLanguages.UsernameString + "(NULL)"
            ElseIf My.Settings.Language = "English" Then
                UsernameLabel.Text = EnglishSettingsLanguages.UsernameString + "(NULL)"
            Else
                UsernameLabel.Text = EnglishSettingsLanguages.UsernameString + "(NULL)"
            End If

        Else
            If My.Settings.Language = "Turkish" Then
                UsernameLabel.Text = TurkishSettingsLanguages.UsernameString + My.Settings.RobloxUsername
            ElseIf My.Settings.Language = "English" Then
                UsernameLabel.Text = EnglishSettingsLanguages.UsernameString + My.Settings.RobloxUsername
            Else
                UsernameLabel.Text = EnglishSettingsLanguages.UsernameString + My.Settings.RobloxUsername
            End If

        End If

    End Sub
End Class