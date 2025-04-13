Imports System.Data.SqlClient
Imports System.Security.Cryptography
Imports System.Text

Public Class ForgotPasswordForm

    ' Back to Login Form
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim loginForm As New LoginForm()
        loginForm.Show()
        Me.Hide()
    End Sub

    ' Reset Password Button Click
    Private Sub btnResetPassword_Click(sender As Object, e As EventArgs) Handles btnResetPassword.Click
        ' Validate Email and New Password fields
        If txtEmail.Text.Trim() = "" Or txtNewPassword.Text.Trim() = "" Then
            MessageBox.Show("❌ Please enter both email and new password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        ' Validate email format (@gmail.com required)
        If Not txtEmail.Text.EndsWith("@gmail.com") Then
            MessageBox.Show("❌ Email must end with '@gmail.com'!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Try
            Dim userExists As Boolean = False

            ' Check if Email exists in the database
            Using con As New SqlConnection("Data Source=ASFIYASHAIKH\SQLEXPRESS;Initial Catalog=ConstructSyncDB1;Integrated Security=True;")
                con.Open()
                Dim cmd As New SqlCommand("SELECT COUNT(*) FROM Users WHERE Email = @Email", con)
                cmd.Parameters.AddWithValue("@Email", txtEmail.Text)
                Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())

                If count > 0 Then
                    userExists = True
                Else
                    MessageBox.Show("❌ Email not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If
            End Using

            ' If user exists, update the password
            If userExists Then
                Dim newPasswordHash As String = HashPassword(txtNewPassword.Text)

                Using con As New SqlConnection("Data Source=ASFIYASHAIKH\SQLEXPRESS;Initial Catalog=ConstructSyncDB1;Integrated Security=True;")
                    con.Open()
                    Dim cmd As New SqlCommand("UPDATE Users SET Password = @Password WHERE Email = @Email", con)
                    cmd.Parameters.AddWithValue("@Password", newPasswordHash)
                    cmd.Parameters.AddWithValue("@Email", txtEmail.Text)

                    cmd.ExecuteNonQuery()
                    MessageBox.Show("✅ Password Reset Successful! You can now log in with your new password.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    ' Redirect to LoginForm
                    Dim loginForm As New LoginForm()
                    loginForm.Show()
                    Me.Hide()
                End Using
            End If

        Catch ex As Exception
            MessageBox.Show("❌ Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Function to hash the password using SHA-256
    Private Function HashPassword(password As String) As String
        Using sha256 As SHA256 = SHA256.Create()
            Dim bytes As Byte() = sha256.ComputeHash(Encoding.UTF8.GetBytes(password & "CustomSalt"))
            Dim builder As New StringBuilder()
            For Each b As Byte In bytes
                builder.Append(b.ToString("x2"))
            Next
            Return builder.ToString()
        End Using
    End Function


End Class
