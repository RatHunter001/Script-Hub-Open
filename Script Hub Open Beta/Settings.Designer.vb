<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Settings
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Settings))
        Me.BackgroundColorLabel = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.UsernameLabel = New System.Windows.Forms.Label()
        Me.ChangeButton = New System.Windows.Forms.Button()
        Me.BackButton = New System.Windows.Forms.Button()
        Me.LanguageLabel = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'BackgroundColorLabel
        '
        Me.BackgroundColorLabel.AutoSize = True
        Me.BackgroundColorLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BackgroundColorLabel.Location = New System.Drawing.Point(13, 13)
        Me.BackgroundColorLabel.Name = "BackgroundColorLabel"
        Me.BackgroundColorLabel.Size = New System.Drawing.Size(115, 20)
        Me.BackgroundColorLabel.TabIndex = 0
        Me.BackgroundColorLabel.Text = "Arkaplan rengi:"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(133, 11)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(25, 25)
        Me.Button1.TabIndex = 1
        Me.Button1.UseVisualStyleBackColor = True
        '
        'UsernameLabel
        '
        Me.UsernameLabel.AutoSize = True
        Me.UsernameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.UsernameLabel.Location = New System.Drawing.Point(13, 48)
        Me.UsernameLabel.Name = "UsernameLabel"
        Me.UsernameLabel.Size = New System.Drawing.Size(95, 20)
        Me.UsernameLabel.TabIndex = 2
        Me.UsernameLabel.Text = "Kullanıcı adı:"
        '
        'ChangeButton
        '
        Me.ChangeButton.Location = New System.Drawing.Point(114, 71)
        Me.ChangeButton.Name = "ChangeButton"
        Me.ChangeButton.Size = New System.Drawing.Size(66, 23)
        Me.ChangeButton.TabIndex = 3
        Me.ChangeButton.Text = "Değiştir"
        Me.ChangeButton.UseVisualStyleBackColor = True
        '
        'BackButton
        '
        Me.BackButton.Location = New System.Drawing.Point(13, 255)
        Me.BackButton.Name = "BackButton"
        Me.BackButton.Size = New System.Drawing.Size(75, 23)
        Me.BackButton.TabIndex = 4
        Me.BackButton.Text = "< Geri"
        Me.BackButton.UseVisualStyleBackColor = True
        '
        'LanguageLabel
        '
        Me.LanguageLabel.AutoSize = True
        Me.LanguageLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.LanguageLabel.Location = New System.Drawing.Point(13, 107)
        Me.LanguageLabel.Name = "LanguageLabel"
        Me.LanguageLabel.Size = New System.Drawing.Size(85, 20)
        Me.LanguageLabel.TabIndex = 5
        Me.LanguageLabel.Text = "Language:"
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"English", "Turkish"})
        Me.ComboBox1.Location = New System.Drawing.Point(104, 107)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 6
        '
        'Settings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(294, 290)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.LanguageLabel)
        Me.Controls.Add(Me.BackButton)
        Me.Controls.Add(Me.ChangeButton)
        Me.Controls.Add(Me.UsernameLabel)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.BackgroundColorLabel)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(310, 329)
        Me.MinimumSize = New System.Drawing.Size(310, 329)
        Me.Name = "Settings"
        Me.Text = "Ayarlar"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BackgroundColorLabel As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents UsernameLabel As Label
    Friend WithEvents ChangeButton As Button
    Friend WithEvents BackButton As Button
    Friend WithEvents LanguageLabel As Label
    Friend WithEvents ComboBox1 As ComboBox
End Class
