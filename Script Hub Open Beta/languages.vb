
Public Structure TurkishMainFormLanguages
    Public Shared FormName As String = "Script Hub"
    Public Shared DownloadButton As String = "İndir"
    Public Shared RefreshButton As String = "Yenile"
    Public Shared CopyButton As String = "Kopyala"
    Public Shared SettingsButton As String = "Ayarlar"
    Public Shared OtherButton As String = "Diğer"
    Public Shared AboutButton As String = "Hakkında"
    Public Shared RobloxTab As String = "Roblox İşlemleri"
    Public Shared CloseRoblox As String = "Roblox'u kapat"
    Public Shared TestRoblox As String = "Roblox açık mı test et"
    Public Shared RequiresScriptTab As String = "Requireler"
    Public Shared FEScriptsTab As String = "FE Scriptler"
    Public Shared BasicScriptsTab As String = "Basit Scriptler"
    Public Shared LoadStringsScriptsTab As String = "Loadstringler"
    Public Shared Discord As String = "Discord"
    Public Shared TRExploitersDiscord As String = "TRExploiters"
    Public Shared NotUpdated As String = "Kullandığınız Script Hub'un sürümü güncel değil. Lütfen yeni sürümü indiriniz."
    Public Shared NoSavedUsername As String = "Görünüşe göre kayıtlı bir kullanıcı adınız yok. Script Hub'un bütün özelliklerinden faydalanabilmek için lütfen kullanıcı adınızı ayarlar kısmından belirleyin."
    Public Shared RobloxOpen As String = "Roblox açık"
    Public Shared RobloxNotOpen As String = "Roblox Kapalı"
    Public Shared Refreshing As String = "Yenileniyor..."
    Public Shared ErrorString As String = "Hata!"
End Structure

Public Structure EnglishMainFormLanguages
    Public Shared FormName As String = "Script Hub"
    Public Shared DownloadButton As String = "Download"
    Public Shared RefreshButton As String = "Refresh"
    Public Shared CopyButton As String = "Copy"
    Public Shared SettingsButton As String = "Settings"
    Public Shared OtherButton As String = "Other"
    Public Shared AboutButton As String = "About"
    Public Shared RobloxTab As String = "Roblox stuff"
    Public Shared CloseRoblox As String = "Close Roblox"
    Public Shared TestRoblox As String = "Test if Roblox is open"
    Public Shared RequiresScriptTab As String = "Require Scripts"
    Public Shared FEScriptsTab As String = "FE Scripts"
    Public Shared BasicScriptsTab As String = "Basic Scripts"
    Public Shared LoadStringsScriptsTab As String = "Loadstrings"
    Public Shared Discord As String = "Discord"
    Public Shared TRExploitersDiscord As String = "TRExploiters"
    Public Shared NotUpdated As String = "The version you are currently using is out of date. Please download the newest version."
    Public Shared NoSavedUsername As String = "It seems you don't have a saved username. Please set your username from 'Settings'"
    Public Shared RobloxOpen As String = "Roblox is open"
    Public Shared RobloxNotOpen As String = "Roblox is closed"
    Public Shared Refreshing As String = "Refreshing..."
    Public Shared ErrorString As String = "Error!"
End Structure
Public Structure TurkishSettingsLanguages
    Public Shared FormName As String = "Ayarlar"
    Public Shared BackgroundColorString As String = "Arkaplan rengi: "
    Public Shared UsernameString As String = "Kullanıcı adı: "
    Public Shared ChangeUsernameString As String = "Değiştir"
    Public Shared LanguageString As String = "Dil:"
    Public Shared Back As String = "< Geri"
End Structure
Public Structure EnglishSettingsLanguages
    Public Shared FormName As String = "Settings"
    Public Shared BackgroundColorString As String = "Background: "
    Public Shared UsernameString As String = "Username: "
    Public Shared ChangeUsernameString As String = "Change"
    Public Shared LanguageString As String = "Language:"
    Public Shared Back As String = "< Back"
End Structure
Public Structure TurkishChangeUsernameLanguages
    Public Shared FormName As String = "Kullanıcı adı değiştir"
    Public Shared RobloxUsername As String = "Roblox kullanıcı adı: "
    Public Shared ConfirmButton As String = "Onayla"
End Structure
Public Structure EnglishChangeUsernameLanguages
    Public Shared FormName As String = "Change username"
    Public Shared RobloxUsername As String = "Roblox username: "
    Public Shared ConfirmButton As String = "Apply"
End Structure
Public Structure TurkishAboutLanguages
    Public Shared FormName As String = "Hakkında"
    Public Shared ProgrammerString As String = "Programcı: dsf001#1337"
End Structure

Public Structure EnglishAboutLanguages
    Public Shared FormName As String = "About"
    Public Shared ProgrammerString As String = "Programmer: dsf001#1337"
End Structure


Public Class LanguageFunctions
    Public Shared Sub ChangeLanguage(ByVal form As String, ByVal language As String)
        If form = "MainForm" Then
            If language = "Turkish" Then
                'Global settings
                My.Settings.Language = "Turkish"
                My.Settings.Save()
                'Main Form's elements here
                MainForm.DownloadButton.Text = TurkishMainFormLanguages.DownloadButton
                MainForm.RefreshButton.Text = TurkishMainFormLanguages.RefreshButton
                MainForm.CopyButton.Text = TurkishMainFormLanguages.CopyButton
                MainForm.AyarlarToolStripMenuItem.Text = TurkishMainFormLanguages.SettingsButton
                MainForm.OtherToolStripMenuItem.Text = TurkishMainFormLanguages.OtherButton
                MainForm.AboutToolStripMenuItem.Text = TurkishMainFormLanguages.AboutButton
                MainForm.RobloxStuffToolStripMenuItem.Text = TurkishMainFormLanguages.RobloxTab
                MainForm.BütünAçıkRobloxplayerbetaLarıKapatToolStripMenuItem.Text = TurkishMainFormLanguages.CloseRoblox
                MainForm.RobloxAçıkMıTestEtToolStripMenuItem.Text = TurkishMainFormLanguages.TestRoblox
                MainForm.TabPage1.Text = TurkishMainFormLanguages.FEScriptsTab
                MainForm.TabPage2.Text = TurkishMainFormLanguages.BasicScriptsTab
                MainForm.TabPage3.Text = TurkishMainFormLanguages.LoadStringsScriptsTab
                MainForm.TabPage4.Text = TurkishMainFormLanguages.RequiresScriptTab
                MainForm.DiscordToolStripMenuItem.Text = TurkishMainFormLanguages.Discord
                MainForm.DsfsDiscordToolStripMenuItem.Text = TurkishMainFormLanguages.TRExploitersDiscord
            ElseIf language = "English" Then
                'Global settings
                My.Settings.Language = "English"
                My.Settings.Save()
                'Main Form's elements here
                MainForm.DownloadButton.Text = EnglishMainFormLanguages.DownloadButton
                MainForm.RefreshButton.Text = EnglishMainFormLanguages.RefreshButton
                MainForm.CopyButton.Text = EnglishMainFormLanguages.CopyButton
                MainForm.AyarlarToolStripMenuItem.Text = EnglishMainFormLanguages.SettingsButton
                MainForm.OtherToolStripMenuItem.Text = EnglishMainFormLanguages.OtherButton
                MainForm.AboutToolStripMenuItem.Text = EnglishMainFormLanguages.AboutButton
                MainForm.RobloxStuffToolStripMenuItem.Text = EnglishMainFormLanguages.RobloxTab
                MainForm.BütünAçıkRobloxplayerbetaLarıKapatToolStripMenuItem.Text = EnglishMainFormLanguages.CloseRoblox
                MainForm.RobloxAçıkMıTestEtToolStripMenuItem.Text = EnglishMainFormLanguages.TestRoblox
                MainForm.TabPage1.Text = EnglishMainFormLanguages.FEScriptsTab
                MainForm.TabPage2.Text = EnglishMainFormLanguages.BasicScriptsTab
                MainForm.TabPage3.Text = EnglishMainFormLanguages.LoadStringsScriptsTab
                MainForm.TabPage4.Text = EnglishMainFormLanguages.RequiresScriptTab
                MainForm.DiscordToolStripMenuItem.Text = EnglishMainFormLanguages.Discord
                MainForm.DsfsDiscordToolStripMenuItem.Text = EnglishMainFormLanguages.TRExploitersDiscord
            End If
        End If
        If form = "Settings" Then
            If language = "Turkish" Then
                'Global settings
                My.Settings.Language = "Turkish"
                My.Settings.Save()
                'Settings' elements
                Settings.Text = TurkishSettingsLanguages.FormName
                Settings.BackgroundColorLabel.Text = TurkishSettingsLanguages.BackgroundColorString
                Settings.ChangeButton.Text = TurkishSettingsLanguages.ChangeUsernameString
                Settings.LanguageLabel.Text = TurkishSettingsLanguages.LanguageString
                Settings.BackButton.Text = TurkishSettingsLanguages.Back
            ElseIf language = "English" Then
                'Global settings
                My.Settings.Language = "English"
                My.Settings.Save()
                'Settings' elements
                Settings.Text = EnglishSettingsLanguages.FormName
                Settings.BackgroundColorLabel.Text = EnglishSettingsLanguages.BackgroundColorString
                Settings.ChangeButton.Text = EnglishSettingsLanguages.ChangeUsernameString
                Settings.LanguageLabel.Text = EnglishSettingsLanguages.LanguageString
                Settings.BackButton.Text = EnglishSettingsLanguages.Back
            End If
        End If
        If form = "ChangeUsername" Then
            If language = "Turkish" Then
                'Global settings
                My.Settings.Language = "Turkish"
                My.Settings.Save()
                'ChangeUsername's elements 
                ChangeUsername.Text = TurkishChangeUsernameLanguages.FormName
                ChangeUsername.RobloxUsernameLabel.Text = TurkishChangeUsernameLanguages.RobloxUsername
                ChangeUsername.ApplyButton.Text = TurkishChangeUsernameLanguages.ConfirmButton
            ElseIf language = "English" Then
                'Global settings
                My.Settings.Language = "English"
                My.Settings.Save()
                'ChangeUsername's elements 
                ChangeUsername.Text = EnglishChangeUsernameLanguages.FormName
                ChangeUsername.RobloxUsernameLabel.Text = EnglishChangeUsernameLanguages.RobloxUsername
                ChangeUsername.ApplyButton.Text = EnglishChangeUsernameLanguages.ConfirmButton
            End If
        End If
        If form = "About" Then
            If language = "Turkish" Then
                'Global settings
                My.Settings.Language = "Turkish"
                My.Settings.Save()
                'About's elements
                About.Text = TurkishAboutLanguages.FormName
                About.ProgrammerLabel.Text = TurkishAboutLanguages.ProgrammerString
            ElseIf language = "English" Then
                'Global settings
                My.Settings.Language = "English"
                My.Settings.Save()
                'About's elements
                About.Text = EnglishAboutLanguages.FormName
                About.ProgrammerLabel.Text = EnglishAboutLanguages.ProgrammerString
            End If
        End If
    End Sub

End Class
