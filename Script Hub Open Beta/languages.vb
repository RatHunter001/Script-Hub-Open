
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
End Structure

Public Structure AboutLanguages

End Structure
Public Structure SettingsLanguages

End Structure
Public Structure ChangeUsernameLanguages

End Structure
Public Class LanguageFunctions
    Public Shared Sub ChangeLanguage(ByVal form As String, ByVal language As String)
        If form = "MainForm" Then
            If language = "Turkish" Then
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
    End Sub
End Class
