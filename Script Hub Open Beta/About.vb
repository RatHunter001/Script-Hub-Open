Imports System.Text.UnicodeEncoding
Public Class About
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub About_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim client As New Net.WebClient
        client.Encoding = UTF8
        Try
            If My.Settings.Language = "Turkish" Then
                RichTextBox1.Text = client.DownloadString("https://scripthub.dsf001.site/Settings/About/about.php?Language=Turkish")
            ElseIf My.Settings.Language = "English" Then
                RichTextBox1.Text = client.DownloadString("https://scripthub.dsf001.site/Settings/About/about.php?Language=English")
            Else

            End If
            PictureBox1.Load("https://scripthub.dsf001.site/Settings/About/image.php")
        Catch ex As Exception
            PictureBox1.Load("http://scripthub.dsf001.site/logo.png")
        End Try

    End Sub
End Class