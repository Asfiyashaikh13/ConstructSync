Imports System.Data.SqlClient
Imports System.Security.Cryptography
Imports System.Text

Public Class LoginForm

    ' Form Load Event
    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pnlLoginContainer.BackgroundImageLayout = ImageLayout.Stretch

        ' ✅ Ensure Admin Exists (Auto-Create)
        EnsureAdminExists()
    End Sub

    ' ✅ Ensure Admin Exists Function
    Private Sub EnsureAdminExists()
        Try
            Using con As New SqlConnection("Data Source=ASFIYASHAIKH\SQLEXPRESS;Initial Catalog=ConstructSyncDB1;Integrated Security=True;")
                con.Open()

                ' Check if Admin exists
                Dim checkQuery As String = "SELECT COUNT(*) FROM Users WHERE Role = 'Admin'"
                Using checkCmd As New SqlCommand(checkQuery, con)
                    Dim count As Integer = Convert.ToInt32(checkCmd.ExecuteScalar())

                    If count = 0 Then
                        ' If no Admin, create default Admin
                        Dim defaultEmail As String = "admin@gmail.com"
                        Dim defaultPassword As String = "Admin@123"
                        Dim hashedPassword As String = HashPassword(defaultPassword)

                        Dim insertQuery As String = "INSERT INTO Users (FullName, Email, Password, Role) VALUES ('Admin User', @Email, @Password, 'Admin')"
                        Using insertCmd As New SqlCommand(insertQuery, con)
                            insertCmd.Parameters.AddWithValue("@Email", defaultEmail)
                            insertCmd.Parameters.AddWithValue("@Password", hashedPassword)
                            insertCmd.ExecuteNonQuery()
                        End Using
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("❌ Error ensuring admin exists: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Login Button Click
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        ' ✅ Validate input fields
        If String.IsNullOrWhiteSpace(txtEmail.Text) OrElse String.IsNullOrWhiteSpace(txtPassword.Text) Then
            MessageBox.Show("❌ Please enter both email and password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        ' ✅ Validate email format
        If Not txtEmail.Text.EndsWith("@gmail.com") Then
            MessageBox.Show("❌ Email must end with '@gmail.com'!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Try
            Dim storedHash As String = ""
            Dim userRole As String = ""
            Dim userID As Integer = -1

            ' ✅ Database Connection
            Using con As New SqlConnection("Data Source=ASFIYASHAIKH\SQLEXPRESS;Initial Catalog=ConstructSyncDB1;Integrated Security=True;")
                con.Open()

                ' ✅ Query with Parameters
                Dim query As String = "SELECT UserID, Password, Role FROM Users WHERE Email = @Email"
                Using cmd As New SqlCommand(query, con)
                    cmd.Parameters.AddWithValue("@Email", txtEmail.Text)

                    Dim reader As SqlDataReader = cmd.ExecuteReader()

                    If reader.Read() Then
                        userID = Convert.ToInt32(reader("UserID"))
                        storedHash = reader("Password").ToString()
                        userRole = reader("Role").ToString()
                    Else
                        MessageBox.Show("❌ Invalid email or password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    End If
                End Using
            End Using

            ' ✅ Password Verification
            If VerifyPassword(txtPassword.Text, storedHash) Then

                ' ✅ Successful Login
                GlobalVariables.LoggedInUserID = userID
                GlobalVariables.UserType = userRole  ' Store the UserType globally

                MessageBox.Show("✅ Login Successful!" & vbCrLf & "Role: " & userRole, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                ' ✅ Navigation based on Role
                If userRole = "Worker" Then
                    GlobalVariables.LoggedInWorkerID = userID
                    Dim workerForm As New WorkerDashboard()
                    workerForm.Show()
                    Me.Hide()

                ElseIf userRole = "Client" Then
                    Dim clientForm As New ClientDashboard()
                    clientForm.Show()
                    Me.Hide()

                ElseIf userRole = "Supervisor" Then
                    Dim supervisorForm As New SupervisorDashboard()
                    supervisorForm.Show()
                    Me.Hide()

                ElseIf userRole = "Admin" Then
                    Dim adminForm As New AdminDashboard()
                    adminForm.Show()
                    Me.Hide()

                Else
                    MessageBox.Show("❌ Unknown role detected!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If

            Else
                MessageBox.Show("❌ Incorrect password! Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Catch ex As Exception
            MessageBox.Show("❌ Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' ✅ Hash Password Function (SHA256)
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

    ' ✅ Verify Password Function
    Private Function VerifyPassword(inputPassword As String, storedHash As String) As Boolean
        Return HashPassword(inputPassword) = storedHash
    End Function

    ' ✅ Navigate to Registration Form
    Private Sub btnRegisterRedirect_Click(sender As Object, e As EventArgs) Handles btnRegisterRedirect.Click
        Dim registerForm As New RegistrationForm()
        registerForm.Show()
        Me.Hide()
    End Sub

    ' ✅ Navigate to Forgot Password Form
    Private Sub lnkForgotPassword_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkForgotPassword.LinkClicked
        Dim forgotPasswordForm As New ForgotPasswordForm()
        forgotPasswordForm.Show()
        Me.Hide()
    End Sub

    ' ✅ Clear Fields
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtEmail.Clear()
        txtPassword.Clear()
    End Sub

    ' ✅ Toggle Password Visibility
    Private Sub chkShowPassword_CheckedChanged(sender As Object, e As EventArgs) Handles chkShowPassword.CheckedChanged
        txtPassword.PasswordChar = If(chkShowPassword.Checked, ControlChars.NullChar, "*"c)
    End Sub

End Class
