Imports Newtonsoft.Json.Linq
Imports System.Text
Imports System.Net
Imports System.IO
Imports System.Text.RegularExpressions
Imports System.Security.Cryptography
Public Class MainForm
    Private Sub ParseInputJSON(ByVal JSONInput As String, ByVal ListToAdd As Object, ByVal Directory As String)

        Dim myJObject = JObject.Parse(JSONInput)
        Dim ItemCount As String = Integer.Parse(PHPFunctions.PHP("https://scripthub.dsf001.site/GetDir.php", "POST", "FileMethod=CountFiles&DirectoryToScan=" & Directory))
        ListToAdd.Items.Clear()
        For i As Integer = 0 To ItemCount + 10

            Try
                ListToAdd.Items.Add(myJObject.SelectToken(i.ToString))
            Catch ex As Exception

            End Try

        Next

    End Sub
    Private Sub RefreshButton_Click(sender As Object, e As EventArgs) Handles RefreshButton.Click
        If DownloadAll.IsBusy Then

        Else
            DownloadAll.RunWorkerAsync()
        End If

    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
#Disable Warning BC42025 ' Access of shared member, constant member, enum member or nested type through an instance
        Me.CheckForIllegalCrossThreadCalls = False
#Enable Warning BC42025 ' Access of shared member, constant member, enum member or nested type through an instance
        Me.Text = "Script Hub BETA " & My.Settings.Version
        Me.BackColor = My.Settings.BackgroundColorMain
        Dim client As New Net.WebClient
        Dim currentver As String = client.DownloadString("https://scripthub.dsf001.site/Settings/Version.txt")
        If My.Settings.Version = currentver Then

        Else
            MsgBox("Kullandığınız Script Hub'un sürümü güncel değil. Lütfen yeni sürümü indiriniz.", vbCritical, "Hata")
            Process.Start("http://scripthub.dsf001.site/")
            End
        End If
        If My.Settings.RobloxUsername = String.Empty Then
            MsgBox("Görünüşe göre kayıtlı bir kullanıcı adınız yok. Script Hub'un bütün özelliklerinden faydalanabilmek için lütfen kullanıcı adınızı ayarlar kısmından belirleyin.", vbInformation, "Bilgi")
        End If
        RefreshButton.PerformClick()
    End Sub

    Private Sub DownloadButton_Click(sender As Object, e As EventArgs) Handles DownloadButton.Click
        Dim client As New Net.WebClient

        Try
            If TabControl1.SelectedIndex = 0 Then
                FastColoredTextBox1.Text = client.DownloadString("https://scripthub.dsf001.site/ScriptHub/FE/" & FEScriptsBox.SelectedItem)
            ElseIf TabControl1.SelectedIndex = 1 Then
                FastColoredTextBox1.Text = client.DownloadString("https://scripthub.dsf001.site/ScriptHub/Basic/" & BasicScriptsBox.SelectedItem)
            ElseIf TabControl1.SelectedIndex = 2 Then
                FastColoredTextBox1.Text = client.DownloadString("https://scripthub.dsf001.site/ScriptHub/Loadstrings/" & LoadStringsBox.SelectedItem)
            ElseIf TabControl1.SelectedIndex = 3 Then
                FastColoredTextBox1.Text = client.DownloadString("https://scripthub.dsf001.site/ScriptHub/Requires/" & RequiresBox.SelectedItem)
                FastColoredTextBox1.Text = FastColoredTextBox1.Text.Replace("TurkAntiHile", My.Settings.RobloxUsername)
            Else
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub ArkaplanRengiToolStripMenuItem_Click(sender As Object, e As EventArgs)
        ColorDialog1.ShowDialog()
        My.Settings.BackgroundColorMain = ColorDialog1.Color
        My.Settings.Save()
        Me.BackColor = My.Settings.BackgroundColorMain
    End Sub

    Private Sub BütünAçıkRobloxplayerbetaLarıKapatToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BütünAçıkRobloxplayerbetaLarıKapatToolStripMenuItem.Click
        For Each P As Process In System.Diagnostics.Process.GetProcessesByName("RobloxPlayerBeta")
            P.Kill()
        Next
    End Sub

    Private Sub RobloxAçıkMıTestEtToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RobloxAçıkMıTestEtToolStripMenuItem.Click
        Dim p() As Process
        p = Process.GetProcessesByName("RobloxPlayerBeta")
        If p.Count > 0 Then
            MsgBox("Roblox Açık.", vbInformation, "Bilgi")
        Else
            MsgBox("Roblox Kapalı.", vbInformation, "Bilgi")
        End If
    End Sub

    Private Sub DownloadAll_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles DownloadAll.DoWork
        Try
            FEScriptsBox.Items.Clear()
            BasicScriptsBox.Items.Clear()
            LoadStringsBox.Items.Clear()
            RequiresBox.Items.Clear()
            StatusLabel.Text = "Yenileniyor..."
            Dim client As New Net.WebClient
            Dim FEScriptList As String = PHPFunctions.PHP("https://scripthub.dsf001.site/GetDir.php", "POST", "FileMethod=ReturnFiles&DirectoryToScan=ScriptHub/FE/")
            ParseInputJSON(FEScriptList, FEScriptsBox, "ScriptHub/FE/")

            Dim BasicScriptList As String = PHPFunctions.PHP("https://scripthub.dsf001.site/GetDir.php", "POST", "FileMethod=ReturnFiles&DirectoryToScan=ScriptHub/Basic/")
            ParseInputJSON(BasicScriptList, BasicScriptsBox, "ScriptHub/Basic/")

            Dim LoadStringList As String = PHPFunctions.PHP("https://scripthub.dsf001.site/GetDir.php", "POST", "FileMethod=ReturnFiles&DirectoryToScan=ScriptHub/Loadstrings/")
            ParseInputJSON(LoadStringList, LoadStringsBox, "ScriptHub/Loadstrings/")

            Dim RequireList As String = PHPFunctions.PHP("https://scripthub.dsf001.site/GetDir.php", "POST", "FileMethod=ReturnFiles&DirectoryToScan=ScriptHub/Requires/")
            ParseInputJSON(RequireList, RequiresBox, "ScriptHub/Requires/")
            StatusLabel.Text = ""
        Catch ex As Exception
            StatusLabel.Text = "Hata!"
        End Try
    End Sub

    Private Sub HakkındaToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles HakkındaToolStripMenuItem1.Click
        About.Show()
    End Sub

    Private Sub CopyButton_Click(sender As Object, e As EventArgs) Handles CopyButton.Click
        Clipboard.SetText(FastColoredTextBox1.Text)
    End Sub

    Private Sub AyarlarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AyarlarToolStripMenuItem.Click
        Settings.Show()
        Me.Hide()

    End Sub

    Private Sub HakkındaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HakkındaToolStripMenuItem.Click

    End Sub
End Class