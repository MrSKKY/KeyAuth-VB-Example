Imports KeyAuth
'This example works with the CSHARP example.
'https://github.com/KeyAuth/KeyAuth-CSHARP-Example
'If you want to edit the KeyAuth.dll download the example above build the project, edit KeyAuth.cs and build it as .dll
'https://gyazo.com/b4aaf79dfdafaad0f0b2efa507a6cfbd
'import it here and you're ready to go :)
Public Class Login
        Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

            KeyAuth.init()

        'If KeyAuth.checkblack Then
        'MessageBox.Show("User is blacklisted")
        'Else
        'MessageBox.Show("user is blacklisted")
        'End If

    End Sub

        'Put those informations from KeyAuth Website
        Private Shared appname As String = ""  'Application name. right above the blurred text aka the secret on the licenses tab among other tabs
        Private Shared ownerid As String = "" 'ownerid, found in account settings. click your profile picture on top right of dashboard and then account settings.
        Private Shared secret As String = "" 'app secret, the blurred text on licenses tab and other tabs
    Private Shared version As String = "1.0" 'leave alone unless you've changed version on website

    Public Shared KeyAuth As api = New api(appname, ownerid, secret, version)

    'Optional Functions:

    'KeyAuth.webhook("lfvbBrbFhIr", "?sellerkey=CUqDqlCIgl&type=resethash")
    'send secure request to webhook which Is impossible to crack into. the base link set on the website Is https://keyauth.com/api/seller/, which nobody except you can see, so the final request Is https://keyauth.com/api/seller/?sellerkey=CUqDqlCIgl&type=resethash

    'Dim result As Byte() = KeyAuth.download("902901") // downloads application file
    'File.WriteAllBytes("FullPath", result)

    'MessageBox.Show(KeyAuth.var("123456")) // retrieve application variable

    'KeyAuth.register("username", "password", "key")
    'KeyAuth.login("username", "password")

    Private Sub LoginButton_Click(sender As Object, e As EventArgs) Handles LoginButton.Click

            KeyAuth.login(Username.Text, Password.Text)

            If KeyAuth.response.success Then
                Main.Show()
                Me.Hide()
            Else
                Status.Text = "Status: " + KeyAuth.response.message
            End If

        End Sub

        Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click

            Environment.Exit(0)

        End Sub

        Private Sub RegisterButton_Click(sender As Object, e As EventArgs) Handles RegisterButton.Click

            KeyAuth.register(Username.Text, Password.Text, Key.Text)

            If KeyAuth.response.success Then
                Main.Show()
                Me.Hide()
            Else
                Status.Text = "Status: " + KeyAuth.response.message
            End If

        End Sub

        Private Sub UpgradeButton_Click(sender As Object, e As EventArgs) Handles UpgradeButton.Click

            KeyAuth.upgrade(Username.Text, Key.Text) 'success is set to false so people can't press upgrade then press login and skip logging in. it doesn't matter, since you shouldn't take any action on succesfull upgrade anyways. the only thing that needs to be done is the user needs to see the message from upgrade function

            Status.Text = "Status: " + KeyAuth.response.message
            'don't login, because they haven't authenticated. this is just to extend expiry of user with new key.

        End Sub

        Private Sub LicenseButton_Click(sender As Object, e As EventArgs) Handles LicenseButton.Click

            KeyAuth.license(Key.Text)

            If KeyAuth.response.success Then
                Main.Show()
                Me.Hide()
            Else
                Status.Text = "Status: " + KeyAuth.response.message
            End If

        End Sub
    End Class