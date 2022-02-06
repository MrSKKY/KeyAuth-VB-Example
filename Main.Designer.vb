<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
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
        Me.components = New System.ComponentModel.Container()
        Me.customerPanelLink = New Siticone.UI.WinForms.SiticoneLabel()
        Me.version = New Siticone.UI.WinForms.SiticoneLabel()
        Me.numKeys = New Siticone.UI.WinForms.SiticoneLabel()
        Me.numOnlineUsers = New Siticone.UI.WinForms.SiticoneLabel()
        Me.numUsers = New Siticone.UI.WinForms.SiticoneLabel()
        Me.lastLogin = New Siticone.UI.WinForms.SiticoneLabel()
        Me.createDate = New Siticone.UI.WinForms.SiticoneLabel()
        Me.hwid = New Siticone.UI.WinForms.SiticoneLabel()
        Me.ip = New Siticone.UI.WinForms.SiticoneLabel()
        Me.ChatMsg = New Siticone.UI.WinForms.SiticoneRoundedTextBox()
        Me.SendMsg = New Siticone.UI.WinForms.SiticoneRoundedButton()
        Me.ChatBox = New System.Windows.Forms.DataGridView()
        Me.Sender = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Message = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Time = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.subscription = New Siticone.UI.WinForms.SiticoneLabel()
        Me.expiry = New Siticone.UI.WinForms.SiticoneLabel()
        Me.key = New Siticone.UI.WinForms.SiticoneLabel()
        Me.label2 = New System.Windows.Forms.Label()
        Me.MinimizeButton = New Siticone.UI.WinForms.SiticoneControlBox()
        Me.CloseButton = New Siticone.UI.WinForms.SiticoneControlBox()
        Me.ChatTimer = New System.Windows.Forms.Timer(Me.components)
        CType(Me.ChatBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'customerPanelLink
        '
        Me.customerPanelLink.BackColor = System.Drawing.Color.Transparent
        Me.customerPanelLink.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.customerPanelLink.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.customerPanelLink.Location = New System.Drawing.Point(15, 268)
        Me.customerPanelLink.Margin = New System.Windows.Forms.Padding(2)
        Me.customerPanelLink.Name = "customerPanelLink"
        Me.customerPanelLink.Size = New System.Drawing.Size(130, 15)
        Me.customerPanelLink.TabIndex = 70
        Me.customerPanelLink.Text = "customerPanelLinkLabel"
        '
        'version
        '
        Me.version.BackColor = System.Drawing.Color.Transparent
        Me.version.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.version.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.version.Location = New System.Drawing.Point(15, 250)
        Me.version.Margin = New System.Windows.Forms.Padding(2)
        Me.version.Name = "version"
        Me.version.Size = New System.Drawing.Size(69, 15)
        Me.version.TabIndex = 69
        Me.version.Text = "versionLabel"
        '
        'numKeys
        '
        Me.numKeys.BackColor = System.Drawing.Color.Transparent
        Me.numKeys.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numKeys.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.numKeys.Location = New System.Drawing.Point(15, 232)
        Me.numKeys.Margin = New System.Windows.Forms.Padding(2)
        Me.numKeys.Name = "numKeys"
        Me.numKeys.Size = New System.Drawing.Size(79, 15)
        Me.numKeys.TabIndex = 68
        Me.numKeys.Text = "numKeysLabel"
        '
        'numOnlineUsers
        '
        Me.numOnlineUsers.BackColor = System.Drawing.Color.Transparent
        Me.numOnlineUsers.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numOnlineUsers.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.numOnlineUsers.Location = New System.Drawing.Point(15, 211)
        Me.numOnlineUsers.Margin = New System.Windows.Forms.Padding(2)
        Me.numOnlineUsers.Name = "numOnlineUsers"
        Me.numOnlineUsers.Size = New System.Drawing.Size(117, 15)
        Me.numOnlineUsers.TabIndex = 67
        Me.numOnlineUsers.Text = "numOnlineUsersLabel"
        '
        'numUsers
        '
        Me.numUsers.BackColor = System.Drawing.Color.Transparent
        Me.numUsers.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numUsers.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.numUsers.Location = New System.Drawing.Point(15, 191)
        Me.numUsers.Margin = New System.Windows.Forms.Padding(2)
        Me.numUsers.Name = "numUsers"
        Me.numUsers.Size = New System.Drawing.Size(83, 15)
        Me.numUsers.TabIndex = 66
        Me.numUsers.Text = "numUsersLabel"
        '
        'lastLogin
        '
        Me.lastLogin.BackColor = System.Drawing.Color.Transparent
        Me.lastLogin.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lastLogin.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lastLogin.Location = New System.Drawing.Point(15, 162)
        Me.lastLogin.Margin = New System.Windows.Forms.Padding(2)
        Me.lastLogin.Name = "lastLogin"
        Me.lastLogin.Size = New System.Drawing.Size(79, 15)
        Me.lastLogin.TabIndex = 65
        Me.lastLogin.Text = "lastLoginLabel"
        '
        'createDate
        '
        Me.createDate.BackColor = System.Drawing.Color.Transparent
        Me.createDate.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.createDate.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.createDate.Location = New System.Drawing.Point(15, 144)
        Me.createDate.Margin = New System.Windows.Forms.Padding(2)
        Me.createDate.Name = "createDate"
        Me.createDate.Size = New System.Drawing.Size(86, 15)
        Me.createDate.TabIndex = 64
        Me.createDate.Text = "createDateLabel"
        '
        'hwid
        '
        Me.hwid.BackColor = System.Drawing.Color.Transparent
        Me.hwid.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hwid.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.hwid.Location = New System.Drawing.Point(15, 126)
        Me.hwid.Margin = New System.Windows.Forms.Padding(2)
        Me.hwid.Name = "hwid"
        Me.hwid.Size = New System.Drawing.Size(57, 15)
        Me.hwid.TabIndex = 63
        Me.hwid.Text = "hwidLabel"
        '
        'ip
        '
        Me.ip.BackColor = System.Drawing.Color.Transparent
        Me.ip.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ip.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ip.Location = New System.Drawing.Point(15, 108)
        Me.ip.Margin = New System.Windows.Forms.Padding(2)
        Me.ip.Name = "ip"
        Me.ip.Size = New System.Drawing.Size(41, 15)
        Me.ip.TabIndex = 62
        Me.ip.Text = "ipLabel"
        '
        'ChatMsg
        '
        Me.ChatMsg.AllowDrop = True
        Me.ChatMsg.BorderColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.ChatMsg.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.ChatMsg.DefaultText = ""
        Me.ChatMsg.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.ChatMsg.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.ChatMsg.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.ChatMsg.DisabledState.Parent = Me.ChatMsg
        Me.ChatMsg.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.ChatMsg.FillColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.ChatMsg.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ChatMsg.FocusedState.Parent = Me.ChatMsg
        Me.ChatMsg.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.ChatMsg.HoveredState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ChatMsg.HoveredState.Parent = Me.ChatMsg
        Me.ChatMsg.Location = New System.Drawing.Point(29, 552)
        Me.ChatMsg.Margin = New System.Windows.Forms.Padding(4)
        Me.ChatMsg.Name = "ChatMsg"
        Me.ChatMsg.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.ChatMsg.PlaceholderText = ""
        Me.ChatMsg.SelectedText = ""
        Me.ChatMsg.ShadowDecoration.Parent = Me.ChatMsg
        Me.ChatMsg.Size = New System.Drawing.Size(335, 30)
        Me.ChatMsg.TabIndex = 61
        Me.ChatMsg.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'SendMsg
        '
        Me.SendMsg.BorderColor = System.Drawing.Color.DodgerBlue
        Me.SendMsg.BorderThickness = 1
        Me.SendMsg.CheckedState.Parent = Me.SendMsg
        Me.SendMsg.CustomImages.Parent = Me.SendMsg
        Me.SendMsg.FillColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.SendMsg.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SendMsg.ForeColor = System.Drawing.Color.White
        Me.SendMsg.HoveredState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.SendMsg.HoveredState.Parent = Me.SendMsg
        Me.SendMsg.Location = New System.Drawing.Point(371, 555)
        Me.SendMsg.Name = "SendMsg"
        Me.SendMsg.ShadowDecoration.Parent = Me.SendMsg
        Me.SendMsg.Size = New System.Drawing.Size(151, 27)
        Me.SendMsg.TabIndex = 60
        Me.SendMsg.Text = "Send"
        '
        'ChatBox
        '
        Me.ChatBox.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.ChatBox.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ChatBox.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Sender, Me.Message, Me.Time})
        Me.ChatBox.GridColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.ChatBox.Location = New System.Drawing.Point(29, 312)
        Me.ChatBox.Name = "ChatBox"
        Me.ChatBox.Size = New System.Drawing.Size(493, 227)
        Me.ChatBox.TabIndex = 59
        '
        'Sender
        '
        Me.Sender.HeaderText = "Sender"
        Me.Sender.Name = "Sender"
        Me.Sender.Width = 75
        '
        'Message
        '
        Me.Message.HeaderText = "Message"
        Me.Message.Name = "Message"
        Me.Message.Width = 200
        '
        'Time
        '
        Me.Time.HeaderText = "Time"
        Me.Time.MaxInputLength = 50000
        Me.Time.Name = "Time"
        Me.Time.Width = 175
        '
        'subscription
        '
        Me.subscription.BackColor = System.Drawing.Color.Transparent
        Me.subscription.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.subscription.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.subscription.Location = New System.Drawing.Point(15, 90)
        Me.subscription.Margin = New System.Windows.Forms.Padding(2)
        Me.subscription.Name = "subscription"
        Me.subscription.Size = New System.Drawing.Size(95, 15)
        Me.subscription.TabIndex = 58
        Me.subscription.Text = "subscriptionLabel"
        '
        'expiry
        '
        Me.expiry.BackColor = System.Drawing.Color.Transparent
        Me.expiry.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.expiry.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.expiry.Location = New System.Drawing.Point(15, 69)
        Me.expiry.Margin = New System.Windows.Forms.Padding(2)
        Me.expiry.Name = "expiry"
        Me.expiry.Size = New System.Drawing.Size(63, 15)
        Me.expiry.TabIndex = 57
        Me.expiry.Text = "expiryLabel"
        '
        'key
        '
        Me.key.BackColor = System.Drawing.Color.Transparent
        Me.key.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.key.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.key.Location = New System.Drawing.Point(15, 49)
        Me.key.Margin = New System.Windows.Forms.Padding(2)
        Me.key.Name = "key"
        Me.key.Size = New System.Drawing.Size(82, 15)
        Me.key.TabIndex = 56
        Me.key.Text = "usernameLabel"
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.label2.Location = New System.Drawing.Point(11, 9)
        Me.label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(98, 19)
        Me.label2.TabIndex = 55
        Me.label2.Text = "KeyAuth Main"
        '
        'MinimizeButton
        '
        Me.MinimizeButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MinimizeButton.BorderRadius = 10
        Me.MinimizeButton.ControlBoxType = Siticone.UI.WinForms.Enums.ControlBoxType.MinimizeBox
        Me.MinimizeButton.FillColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.MinimizeButton.HoveredState.Parent = Me.MinimizeButton
        Me.MinimizeButton.IconColor = System.Drawing.Color.White
        Me.MinimizeButton.Location = New System.Drawing.Point(456, 4)
        Me.MinimizeButton.Name = "MinimizeButton"
        Me.MinimizeButton.ShadowDecoration.Parent = Me.MinimizeButton
        Me.MinimizeButton.Size = New System.Drawing.Size(45, 29)
        Me.MinimizeButton.TabIndex = 72
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
        Me.CloseButton.Location = New System.Drawing.Point(501, 4)
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.ShadowDecoration.Parent = Me.CloseButton
        Me.CloseButton.Size = New System.Drawing.Size(45, 29)
        Me.CloseButton.TabIndex = 71
        '
        'ChatTimer
        '
        Me.ChatTimer.Enabled = True
        Me.ChatTimer.Interval = 1
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(550, 600)
        Me.Controls.Add(Me.MinimizeButton)
        Me.Controls.Add(Me.CloseButton)
        Me.Controls.Add(Me.customerPanelLink)
        Me.Controls.Add(Me.version)
        Me.Controls.Add(Me.numKeys)
        Me.Controls.Add(Me.numOnlineUsers)
        Me.Controls.Add(Me.numUsers)
        Me.Controls.Add(Me.lastLogin)
        Me.Controls.Add(Me.createDate)
        Me.Controls.Add(Me.hwid)
        Me.Controls.Add(Me.ip)
        Me.Controls.Add(Me.ChatMsg)
        Me.Controls.Add(Me.SendMsg)
        Me.Controls.Add(Me.ChatBox)
        Me.Controls.Add(Me.subscription)
        Me.Controls.Add(Me.expiry)
        Me.Controls.Add(Me.key)
        Me.Controls.Add(Me.label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Main"
        Me.Text = "Main"
        CType(Me.ChatBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents customerPanelLink As Siticone.UI.WinForms.SiticoneLabel
    Private WithEvents version As Siticone.UI.WinForms.SiticoneLabel
    Private WithEvents numKeys As Siticone.UI.WinForms.SiticoneLabel
    Private WithEvents numOnlineUsers As Siticone.UI.WinForms.SiticoneLabel
    Private WithEvents numUsers As Siticone.UI.WinForms.SiticoneLabel
    Private WithEvents lastLogin As Siticone.UI.WinForms.SiticoneLabel
    Private WithEvents createDate As Siticone.UI.WinForms.SiticoneLabel
    Private WithEvents hwid As Siticone.UI.WinForms.SiticoneLabel
    Private WithEvents ip As Siticone.UI.WinForms.SiticoneLabel
    Private WithEvents ChatMsg As Siticone.UI.WinForms.SiticoneRoundedTextBox
    Private WithEvents SendMsg As Siticone.UI.WinForms.SiticoneRoundedButton
    Private WithEvents ChatBox As DataGridView
    Private WithEvents Sender As DataGridViewTextBoxColumn
    Private WithEvents Message As DataGridViewTextBoxColumn
    Private WithEvents Time As DataGridViewTextBoxColumn
    Private WithEvents subscription As Siticone.UI.WinForms.SiticoneLabel
    Private WithEvents expiry As Siticone.UI.WinForms.SiticoneLabel
    Private WithEvents key As Siticone.UI.WinForms.SiticoneLabel
    Private WithEvents label2 As Label
    Private WithEvents MinimizeButton As Siticone.UI.WinForms.SiticoneControlBox
    Private WithEvents CloseButton As Siticone.UI.WinForms.SiticoneControlBox
    Private WithEvents ChatTimer As Timer
End Class
