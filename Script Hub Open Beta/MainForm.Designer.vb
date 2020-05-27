<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.FastColoredTextBox1 = New FastColoredTextBoxNS.FastColoredTextBox()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.FEScriptsBox = New System.Windows.Forms.ListBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.BasicScriptsBox = New System.Windows.Forms.ListBox()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.LoadStringsBox = New System.Windows.Forms.ListBox()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.RequiresBox = New System.Windows.Forms.ListBox()
        Me.OtherToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RobloxStuffToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BütünAçıkRobloxplayerbetaLarıKapatToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RobloxAçıkMıTestEtToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DiscordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DsfsDiscordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.AyarlarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.CopyButton = New System.Windows.Forms.Button()
        Me.RefreshButton = New System.Windows.Forms.Button()
        Me.HideForm = New System.Windows.Forms.Timer(Me.components)
        Me.DownloadAll = New System.ComponentModel.BackgroundWorker()
        Me.HideForm1 = New System.Windows.Forms.Timer(Me.components)
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.DownloadButton = New System.Windows.Forms.Button()
        Me.StatusLabel = New System.Windows.Forms.Label()
        Me.StatusTimer = New System.Windows.Forms.Timer(Me.components)
        CType(Me.FastColoredTextBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'FastColoredTextBox1
        '
        Me.FastColoredTextBox1.AutoCompleteBracketsList = New Char() {Global.Microsoft.VisualBasic.ChrW(40), Global.Microsoft.VisualBasic.ChrW(41), Global.Microsoft.VisualBasic.ChrW(123), Global.Microsoft.VisualBasic.ChrW(125), Global.Microsoft.VisualBasic.ChrW(91), Global.Microsoft.VisualBasic.ChrW(93), Global.Microsoft.VisualBasic.ChrW(34), Global.Microsoft.VisualBasic.ChrW(34), Global.Microsoft.VisualBasic.ChrW(39), Global.Microsoft.VisualBasic.ChrW(39)}
        Me.FastColoredTextBox1.AutoIndentCharsPatterns = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "^\s*[\w\.]+(\s\w+)?\s*(?<range>=)\s*(?<range>.+)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.FastColoredTextBox1.AutoScrollMinSize = New System.Drawing.Size(27, 14)
        Me.FastColoredTextBox1.BackBrush = Nothing
        Me.FastColoredTextBox1.BracketsHighlightStrategy = FastColoredTextBoxNS.BracketsHighlightStrategy.Strategy2
        Me.FastColoredTextBox1.CharHeight = 14
        Me.FastColoredTextBox1.CharWidth = 8
        Me.FastColoredTextBox1.CommentPrefix = "--"
        Me.FastColoredTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.FastColoredTextBox1.DisabledColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.FastColoredTextBox1.Font = New System.Drawing.Font("Courier New", 9.75!)
        Me.FastColoredTextBox1.IsReplaceMode = False
        Me.FastColoredTextBox1.Language = FastColoredTextBoxNS.Language.Lua
        Me.FastColoredTextBox1.LeftBracket = Global.Microsoft.VisualBasic.ChrW(40)
        Me.FastColoredTextBox1.LeftBracket2 = Global.Microsoft.VisualBasic.ChrW(123)
        Me.FastColoredTextBox1.Location = New System.Drawing.Point(15, 234)
        Me.FastColoredTextBox1.Name = "FastColoredTextBox1"
        Me.FastColoredTextBox1.Paddings = New System.Windows.Forms.Padding(0)
        Me.FastColoredTextBox1.ReadOnly = True
        Me.FastColoredTextBox1.RightBracket = Global.Microsoft.VisualBasic.ChrW(41)
        Me.FastColoredTextBox1.RightBracket2 = Global.Microsoft.VisualBasic.ChrW(125)
        Me.FastColoredTextBox1.SelectionColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.FastColoredTextBox1.ServiceColors = CType(resources.GetObject("FastColoredTextBox1.ServiceColors"), FastColoredTextBoxNS.ServiceColors)
        Me.FastColoredTextBox1.Size = New System.Drawing.Size(336, 258)
        Me.FastColoredTextBox1.TabIndex = 34
        Me.FastColoredTextBox1.Zoom = 100
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.FEScriptsBox)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(336, 145)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "FE Scriptler"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'FEScriptsBox
        '
        Me.FEScriptsBox.FormattingEnabled = True
        Me.FEScriptsBox.Location = New System.Drawing.Point(0, 0)
        Me.FEScriptsBox.Name = "FEScriptsBox"
        Me.FEScriptsBox.Size = New System.Drawing.Size(336, 147)
        Me.FEScriptsBox.Sorted = True
        Me.FEScriptsBox.TabIndex = 3
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.BasicScriptsBox)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(336, 145)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Basit Scriptler"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'BasicScriptsBox
        '
        Me.BasicScriptsBox.FormattingEnabled = True
        Me.BasicScriptsBox.Location = New System.Drawing.Point(0, 0)
        Me.BasicScriptsBox.Name = "BasicScriptsBox"
        Me.BasicScriptsBox.Size = New System.Drawing.Size(336, 147)
        Me.BasicScriptsBox.Sorted = True
        Me.BasicScriptsBox.TabIndex = 4
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.LoadStringsBox)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(336, 145)
        Me.TabPage3.TabIndex = 3
        Me.TabPage3.Text = "LoadStringler"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'LoadStringsBox
        '
        Me.LoadStringsBox.FormattingEnabled = True
        Me.LoadStringsBox.Location = New System.Drawing.Point(0, 0)
        Me.LoadStringsBox.Name = "LoadStringsBox"
        Me.LoadStringsBox.Size = New System.Drawing.Size(336, 147)
        Me.LoadStringsBox.Sorted = True
        Me.LoadStringsBox.TabIndex = 4
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.RequiresBox)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(336, 145)
        Me.TabPage4.TabIndex = 4
        Me.TabPage4.Text = "Requireler"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'RequiresBox
        '
        Me.RequiresBox.FormattingEnabled = True
        Me.RequiresBox.Location = New System.Drawing.Point(0, 0)
        Me.RequiresBox.Name = "RequiresBox"
        Me.RequiresBox.Size = New System.Drawing.Size(336, 147)
        Me.RequiresBox.Sorted = True
        Me.RequiresBox.TabIndex = 5
        '
        'OtherToolStripMenuItem
        '
        Me.OtherToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem, Me.RobloxStuffToolStripMenuItem, Me.DiscordToolStripMenuItem})
        Me.OtherToolStripMenuItem.Name = "OtherToolStripMenuItem"
        Me.OtherToolStripMenuItem.Size = New System.Drawing.Size(47, 20)
        Me.OtherToolStripMenuItem.Text = "Diğer"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.AboutToolStripMenuItem.Text = "Hakkında"
        '
        'RobloxStuffToolStripMenuItem
        '
        Me.RobloxStuffToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BütünAçıkRobloxplayerbetaLarıKapatToolStripMenuItem, Me.RobloxAçıkMıTestEtToolStripMenuItem})
        Me.RobloxStuffToolStripMenuItem.Name = "RobloxStuffToolStripMenuItem"
        Me.RobloxStuffToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.RobloxStuffToolStripMenuItem.Text = "Roblox işlemleri"
        '
        'BütünAçıkRobloxplayerbetaLarıKapatToolStripMenuItem
        '
        Me.BütünAçıkRobloxplayerbetaLarıKapatToolStripMenuItem.Name = "BütünAçıkRobloxplayerbetaLarıKapatToolStripMenuItem"
        Me.BütünAçıkRobloxplayerbetaLarıKapatToolStripMenuItem.Size = New System.Drawing.Size(276, 22)
        Me.BütünAçıkRobloxplayerbetaLarıKapatToolStripMenuItem.Text = "Bütün açık RobloxPlayerBeta'ları kapat"
        '
        'RobloxAçıkMıTestEtToolStripMenuItem
        '
        Me.RobloxAçıkMıTestEtToolStripMenuItem.Name = "RobloxAçıkMıTestEtToolStripMenuItem"
        Me.RobloxAçıkMıTestEtToolStripMenuItem.Size = New System.Drawing.Size(276, 22)
        Me.RobloxAçıkMıTestEtToolStripMenuItem.Text = "Roblox açık mı test et"
        '
        'DiscordToolStripMenuItem
        '
        Me.DiscordToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DsfsDiscordToolStripMenuItem})
        Me.DiscordToolStripMenuItem.Name = "DiscordToolStripMenuItem"
        Me.DiscordToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.DiscordToolStripMenuItem.Text = "Discord"
        '
        'DsfsDiscordToolStripMenuItem
        '
        Me.DsfsDiscordToolStripMenuItem.Name = "DsfsDiscordToolStripMenuItem"
        Me.DsfsDiscordToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.DsfsDiscordToolStripMenuItem.Text = "TRExploiters"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AyarlarToolStripMenuItem, Me.OtherToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(368, 24)
        Me.MenuStrip1.TabIndex = 31
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'AyarlarToolStripMenuItem
        '
        Me.AyarlarToolStripMenuItem.Name = "AyarlarToolStripMenuItem"
        Me.AyarlarToolStripMenuItem.Size = New System.Drawing.Size(56, 20)
        Me.AyarlarToolStripMenuItem.Text = "Ayarlar"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Location = New System.Drawing.Point(11, 28)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(344, 171)
        Me.TabControl1.TabIndex = 30
        '
        'CopyButton
        '
        Me.CopyButton.Location = New System.Drawing.Point(15, 498)
        Me.CopyButton.Name = "CopyButton"
        Me.CopyButton.Size = New System.Drawing.Size(340, 23)
        Me.CopyButton.TabIndex = 35
        Me.CopyButton.Text = "Kopyala"
        Me.CopyButton.UseVisualStyleBackColor = True
        '
        'RefreshButton
        '
        Me.RefreshButton.Location = New System.Drawing.Point(15, 205)
        Me.RefreshButton.Name = "RefreshButton"
        Me.RefreshButton.Size = New System.Drawing.Size(165, 23)
        Me.RefreshButton.TabIndex = 33
        Me.RefreshButton.Text = "Yenile"
        Me.RefreshButton.UseVisualStyleBackColor = True
        '
        'HideForm
        '
        Me.HideForm.Enabled = True
        Me.HideForm.Interval = 1
        '
        'DownloadAll
        '
        Me.DownloadAll.WorkerReportsProgress = True
        Me.DownloadAll.WorkerSupportsCancellation = True
        '
        'HideForm1
        '
        Me.HideForm1.Interval = 1
        '
        'DownloadButton
        '
        Me.DownloadButton.Location = New System.Drawing.Point(186, 205)
        Me.DownloadButton.Name = "DownloadButton"
        Me.DownloadButton.Size = New System.Drawing.Size(165, 23)
        Me.DownloadButton.TabIndex = 32
        Me.DownloadButton.Text = "İndir"
        Me.DownloadButton.UseVisualStyleBackColor = True
        '
        'StatusLabel
        '
        Me.StatusLabel.AutoSize = True
        Me.StatusLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.StatusLabel.Location = New System.Drawing.Point(12, 531)
        Me.StatusLabel.Name = "StatusLabel"
        Me.StatusLabel.Size = New System.Drawing.Size(0, 18)
        Me.StatusLabel.TabIndex = 36
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(368, 558)
        Me.Controls.Add(Me.StatusLabel)
        Me.Controls.Add(Me.FastColoredTextBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.CopyButton)
        Me.Controls.Add(Me.RefreshButton)
        Me.Controls.Add(Me.DownloadButton)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(384, 597)
        Me.MinimumSize = New System.Drawing.Size(384, 597)
        Me.Name = "MainForm"
        Me.Text = "Script Hub BETA"
        CType(Me.FastColoredTextBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage4.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents FastColoredTextBox1 As FastColoredTextBoxNS.FastColoredTextBox
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents FEScriptsBox As ListBox
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents BasicScriptsBox As ListBox
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents LoadStringsBox As ListBox
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents RequiresBox As ListBox
    Friend WithEvents OtherToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RobloxStuffToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BütünAçıkRobloxplayerbetaLarıKapatToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RobloxAçıkMıTestEtToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DiscordToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DsfsDiscordToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents AyarlarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents CopyButton As Button
    Friend WithEvents RefreshButton As Button
    Friend WithEvents HideForm As Timer
    Friend WithEvents DownloadAll As System.ComponentModel.BackgroundWorker
    Friend WithEvents HideForm1 As Timer
    Friend WithEvents ColorDialog1 As ColorDialog
    Friend WithEvents DownloadButton As Button
    Friend WithEvents StatusLabel As Label
    Friend WithEvents StatusTimer As Timer
End Class
