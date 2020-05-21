Public Class ChangeUsername
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        My.Settings.RobloxUsername = TextBox1.Text
        My.Settings.Save()
        If My.Settings.RobloxUsername = Nothing Or My.Settings.RobloxUsername = "" Then
            Settings.Label2.Text = "Kullanıcı adı: " + "(Yok)"
        Else
            Settings.Label2.Text = "Kullanıcı adı: " + My.Settings.RobloxUsername
        End If
        Settings.Show()
        Me.Close()
    End Sub
End Class