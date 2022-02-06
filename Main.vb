Public Class Main

    Dim chatchannel As String = "TEST" 'Chat channel name
    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        key.Text = "Username: " + Login.KeyAuth.user_data.username
        expiry.Text = "Expiry: " + UnixTimeToDateTime(Long.Parse(Login.KeyAuth.user_data.subscriptions(0).expiry))
        subscription.Text = "Subscription: " + Login.KeyAuth.user_data.subscriptions(0).subscription
        ip.Text = "IP Address: " + Login.KeyAuth.user_data.ip
        hwid.Text = "HWID: " + Login.KeyAuth.user_data.hwid
        createDate.Text = "Creation date: " + UnixTimeToDateTime(Long.Parse(Login.KeyAuth.user_data.createdate))
        lastLogin.Text = "Last login: " + UnixTimeToDateTime(Long.Parse(Login.KeyAuth.user_data.lastlogin))

        numUsers.Text = "Number of users: " + Login.KeyAuth.app_data.numUsers
        numOnlineUsers.Text = "Number of online users: " + Login.KeyAuth.app_data.numOnlineUsers
        numKeys.Text = "Number of licenses: " + Login.KeyAuth.app_data.numKeys
        version.Text = "Current version: " + Login.KeyAuth.app_data.version
        customerPanelLink.Text = "Customer panel: " + Login.KeyAuth.app_data.customerPanelLink

    End Sub

    Public Function UnixTimeToDateTime(ByVal unixTimeStamp As Double) As Date

        Return New DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc).AddSeconds(unixTimeStamp).ToLocalTime()

    End Function

    Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click

        Environment.Exit(0)

    End Sub

    Private Sub SendMsg_Click(sender As Object, e As EventArgs) Handles SendMsg.Click

        If Login.KeyAuth.chatsend(ChatMsg.Text, chatchannel) Then
            ChatBox.Rows.Insert(0, Login.KeyAuth.user_data.username, ChatMsg.Text, UnixTimeToDateTime(DateTimeOffset.Now.ToUnixTimeSeconds))

        Else

            ChatMsg.Text = "Status: " + Login.KeyAuth.response.message

        End If

    End Sub

    Private Sub ChatTimer_Tick(sender As Object, e As EventArgs) Handles ChatTimer.Tick

        ChatBox.Rows.Clear()
        ChatTimer.Interval = 15000 'get chat messages every 15 seconds

        If (String.IsNullOrEmpty(chatchannel)) Then

            Dim messages = Login.KeyAuth.chatget(chatchannel)
            If messages Is Nothing OrElse Not messages.Any Then

                ChatBox.Rows.Insert(0, "KeyAuth", "No Chat Messages", UnixTimeToDateTime(DateTimeOffset.Now.ToUnixTimeSeconds))

            Else

                For Each Message As KeyAuth.api.msg In messages
                    ChatBox.Rows.Insert(0, Message.author, Message.message, UnixTimeToDateTime(Long.Parse(Message.timestamp)))
                Next
            End If

        Else

            ChatBox.Rows.Insert(0, "KeyAuth", "No Chat Messages", UnixTimeToDateTime(DateTimeOffset.Now.ToUnixTimeSeconds))

        End If
    End Sub
End Class