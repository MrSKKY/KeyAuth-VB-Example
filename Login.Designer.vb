<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Title = New System.Windows.Forms.Label()
        Me.Status = New Siticone.UI.WinForms.SiticoneLabel()
        Me.LicenseButton = New Siticone.UI.WinForms.SiticoneRoundedButton()
        Me.UpgradeButton = New Siticone.UI.WinForms.SiticoneRoundedButton()
        Me.RegisterButton = New Siticone.UI.WinForms.SiticoneRoundedButton()
        Me.Password = New Siticone.UI.WinForms.SiticoneRoundedTextBox()
        Me.Username = New Siticone.UI.WinForms.SiticoneRoundedTextBox()
        Me.Key = New Siticone.UI.WinForms.SiticoneRoundedTextBox()
        Me.LoginButton = New Siticone.UI.WinForms.SiticoneRoundedButton()
        Me.MinimizeButton = New Siticone.UI.WinForms.SiticoneControlBox()
        Me.CloseButton = New Siticone.UI.WinForms.SiticoneControlBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Title
        '
        Me.Title.AutoSize = True
        Me.Title.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold)
        Me.Title.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Title.Location = New System.Drawing.Point(12, 9)
        Me.Title.Name = "Title"
        Me.Title.Size = New System.Drawing.Size(101, 19)
        Me.Title.TabIndex = 0
        Me.Title.Text = "KeyAuth Login"
        '
        'Status
        '
        Me.Status.AutoSize = False
        Me.Status.BackColor = System.Drawing.Color.Transparent
        Me.Status.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Status.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Status.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Status.Location = New System.Drawing.Point(0, 301)
        Me.Status.Margin = New System.Windows.Forms.Padding(2)
        Me.Status.Name = "Status"
        Me.Status.Size = New System.Drawing.Size(400, 42)
        Me.Status.TabIndex = 48
        Me.Status.Text = "Status: Awaiting login"
        Me.Status.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LicenseButton
        '
        Me.LicenseButton.BorderColor = System.Drawing.Color.DodgerBlue
        Me.LicenseButton.BorderThickness = 1
        Me.LicenseButton.CheckedState.Parent = Me.LicenseButton
        Me.LicenseButton.CustomImages.Parent = Me.LicenseButton
        Me.LicenseButton.FillColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.LicenseButton.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LicenseButton.ForeColor = System.Drawing.Color.White
        Me.LicenseButton.HoveredState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.LicenseButton.HoveredState.Parent = Me.LicenseButton
        Me.LicenseButton.Location = New System.Drawing.Point(206, 261)
        Me.LicenseButton.Name = "LicenseButton"
        Me.LicenseButton.ShadowDecoration.Parent = Me.LicenseButton
        Me.LicenseButton.Size = New System.Drawing.Size(153, 27)
        Me.LicenseButton.TabIndex = 47
        Me.LicenseButton.Text = "License"
        '
        'UpgradeButton
        '
        Me.UpgradeButton.BorderColor = System.Drawing.Color.DodgerBlue
        Me.UpgradeButton.BorderThickness = 1
        Me.UpgradeButton.CheckedState.Parent = Me.UpgradeButton
        Me.UpgradeButton.CustomImages.Parent = Me.UpgradeButton
        Me.UpgradeButton.FillColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.UpgradeButton.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UpgradeButton.ForeColor = System.Drawing.Color.White
        Me.UpgradeButton.HoveredState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.UpgradeButton.HoveredState.Parent = Me.UpgradeButton
        Me.UpgradeButton.Location = New System.Drawing.Point(49, 261)
        Me.UpgradeButton.Name = "UpgradeButton"
        Me.UpgradeButton.ShadowDecoration.Parent = Me.UpgradeButton
        Me.UpgradeButton.Size = New System.Drawing.Size(151, 27)
        Me.UpgradeButton.TabIndex = 46
        Me.UpgradeButton.Text = "Upgrade"
        '
        'RegisterButton
        '
        Me.RegisterButton.BorderColor = System.Drawing.Color.DodgerBlue
        Me.RegisterButton.BorderThickness = 1
        Me.RegisterButton.CheckedState.Parent = Me.RegisterButton
        Me.RegisterButton.CustomImages.Parent = Me.RegisterButton
        Me.RegisterButton.FillColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.RegisterButton.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RegisterButton.ForeColor = System.Drawing.Color.White
        Me.RegisterButton.HoveredState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.RegisterButton.HoveredState.Parent = Me.RegisterButton
        Me.RegisterButton.Location = New System.Drawing.Point(206, 228)
        Me.RegisterButton.Name = "RegisterButton"
        Me.RegisterButton.ShadowDecoration.Parent = Me.RegisterButton
        Me.RegisterButton.Size = New System.Drawing.Size(153, 27)
        Me.RegisterButton.TabIndex = 45
        Me.RegisterButton.Text = "Register"
        '
        'Password
        '
        Me.Password.AllowDrop = True
        Me.Password.BorderColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.Password.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Password.DefaultText = ""
        Me.Password.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Password.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Password.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Password.DisabledState.Parent = Me.Password
        Me.Password.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Password.FillColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.Password.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Password.FocusedState.Parent = Me.Password
        Me.Password.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Password.HoveredState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Password.HoveredState.Parent = Me.Password
        Me.Password.Location = New System.Drawing.Point(82, 128)
        Me.Password.Margin = New System.Windows.Forms.Padding(4)
        Me.Password.Name = "Password"
        Me.Password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Password.PlaceholderText = ""
        Me.Password.SelectedText = ""
        Me.Password.ShadowDecoration.Parent = Me.Password
        Me.Password.Size = New System.Drawing.Size(236, 30)
        Me.Password.TabIndex = 44
        Me.Password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Username
        '
        Me.Username.AllowDrop = True
        Me.Username.BorderColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.Username.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Username.DefaultText = ""
        Me.Username.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Username.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Username.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Username.DisabledState.Parent = Me.Username
        Me.Username.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Username.FillColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.Username.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Username.FocusedState.Parent = Me.Username
        Me.Username.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Username.HoveredState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Username.HoveredState.Parent = Me.Username
        Me.Username.Location = New System.Drawing.Point(82, 71)
        Me.Username.Margin = New System.Windows.Forms.Padding(4)
        Me.Username.Name = "Username"
        Me.Username.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Username.PlaceholderText = ""
        Me.Username.SelectedText = ""
        Me.Username.ShadowDecoration.Parent = Me.Username
        Me.Username.Size = New System.Drawing.Size(236, 30)
        Me.Username.TabIndex = 43
        Me.Username.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Key
        '
        Me.Key.AllowDrop = True
        Me.Key.BorderColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.Key.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Key.DefaultText = ""
        Me.Key.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Key.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Key.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Key.DisabledState.Parent = Me.Key
        Me.Key.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Key.FillColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.Key.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Key.FocusedState.Parent = Me.Key
        Me.Key.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Key.HoveredState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Key.HoveredState.Parent = Me.Key
        Me.Key.Location = New System.Drawing.Point(82, 185)
        Me.Key.Margin = New System.Windows.Forms.Padding(4)
        Me.Key.Name = "Key"
        Me.Key.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Key.PlaceholderText = ""
        Me.Key.SelectedText = ""
        Me.Key.ShadowDecoration.Parent = Me.Key
        Me.Key.Size = New System.Drawing.Size(236, 30)
        Me.Key.TabIndex = 42
        Me.Key.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LoginButton
        '
        Me.LoginButton.BorderColor = System.Drawing.Color.DodgerBlue
        Me.LoginButton.BorderThickness = 1
        Me.LoginButton.CheckedState.Parent = Me.LoginButton
        Me.LoginButton.CustomImages.Parent = Me.LoginButton
        Me.LoginButton.FillColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.LoginButton.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LoginButton.ForeColor = System.Drawing.Color.White
        Me.LoginButton.HoveredState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.LoginButton.HoveredState.Parent = Me.LoginButton
        Me.LoginButton.Location = New System.Drawing.Point(49, 228)
        Me.LoginButton.Name = "LoginButton"
        Me.LoginButton.ShadowDecoration.Parent = Me.LoginButton
        Me.LoginButton.Size = New System.Drawing.Size(151, 27)
        Me.LoginButton.TabIndex = 41
        Me.LoginButton.Text = "Login"
        '
        'MinimizeButton
        '
        Me.MinimizeButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MinimizeButton.BorderRadius = 10
        Me.MinimizeButton.ControlBoxType = Siticone.UI.WinForms.Enums.ControlBoxType.MinimizeBox
        Me.MinimizeButton.FillColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.MinimizeButton.HoveredState.Parent = Me.MinimizeButton
        Me.MinimizeButton.IconColor = System.Drawing.Color.White
        Me.MinimizeButton.Location = New System.Drawing.Point(304, 4)
        Me.MinimizeButton.Name = "MinimizeButton"
        Me.MinimizeButton.ShadowDecoration.Parent = Me.MinimizeButton
        Me.MinimizeButton.Size = New System.Drawing.Size(45, 29)
        Me.MinimizeButton.TabIndex = 40
        '
        'CloseButton
        '
        Me.CloseButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CloseButton.BorderRadius = 10
        Me.CloseButton.FillColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.CloseButton.HoveredState.FillColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.CloseButton.HoveredState.IconColor = System.Drawing.Color.White
        Me.CloseButton.HoveredState.Parent = Me.CloseButton
        Me.CloseButton.IconColor = System.Drawing.Color.White
        Me.CloseButton.Location = New System.Drawing.Point(350, 4)
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.ShadowDecoration.Parent = Me.CloseButton
        Me.CloseButton.Size = New System.Drawing.Size(45, 29)
        Me.CloseButton.TabIndex = 39
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(165, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 19)
        Me.Label1.TabIndex = 49
        Me.Label1.Text = "Username"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label2.Location = New System.Drawing.Point(168, 105)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 19)
        Me.Label2.TabIndex = 50
        Me.Label2.Text = "Password"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label3.Location = New System.Drawing.Point(188, 162)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 19)
        Me.Label3.TabIndex = 51
        Me.Label3.Text = "Key"
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(400, 343)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Status)
        Me.Controls.Add(Me.LicenseButton)
        Me.Controls.Add(Me.UpgradeButton)
        Me.Controls.Add(Me.RegisterButton)
        Me.Controls.Add(Me.Password)
        Me.Controls.Add(Me.Username)
        Me.Controls.Add(Me.Key)
        Me.Controls.Add(Me.LoginButton)
        Me.Controls.Add(Me.MinimizeButton)
        Me.Controls.Add(Me.CloseButton)
        Me.Controls.Add(Me.Title)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.name = "Login"
        Me.Text = "Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Title As Label
    Private WithEvents Status As Siticone.UI.WinForms.SiticoneLabel
    Private WithEvents LicenseButton As Siticone.UI.WinForms.SiticoneRoundedButton
    Private WithEvents UpgradeButton As Siticone.UI.WinForms.SiticoneRoundedButton
    Private WithEvents RegisterButton As Siticone.UI.WinForms.SiticoneRoundedButton
    Private WithEvents Password As Siticone.UI.WinForms.SiticoneRoundedTextBox
    Private WithEvents Username As Siticone.UI.WinForms.SiticoneRoundedTextBox
    Private WithEvents Key As Siticone.UI.WinForms.SiticoneRoundedTextBox
    Private WithEvents LoginButton As Siticone.UI.WinForms.SiticoneRoundedButton
    Private WithEvents MinimizeButton As Siticone.UI.WinForms.SiticoneControlBox
    Private WithEvents CloseButton As Siticone.UI.WinForms.SiticoneControlBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
