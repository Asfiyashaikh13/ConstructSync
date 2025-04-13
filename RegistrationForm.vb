Imports System.Data.SqlClient
Imports System.Security.Cryptography
Imports System.Text
Imports System.Text.RegularExpressions

Public Class RegistrationForm
    Dim con As New SqlConnection("Data Source=ASFIYASHAIKH\SQLEXPRESS;Initial Catalog=ConstructSyncDB1;Integrated Security=True;")

    ' REGISTER BUTTON CLICK EVENT
    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        ' Validate email format (@gmail.com required)
        If Not txtEmail.Text.EndsWith("@gmail.com") Then
            MessageBox.Show("❌ Email must end with '@gmail.com'!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        ' Validate password complexity
        If Not IsValidPassword(txtPassword.Text) Then
            MessageBox.Show("❌ Password must contain at least one uppercase letter, one lowercase letter, one number, and one special character!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        ' Check if passwords match
        If txtPassword.Text <> txtConfirmPassword.Text Then
            MessageBox.Show("❌ Passwords do not match!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        ' Check for empty fields
        If txtFullName.Text.Trim() = "" Or txtEmail.Text.Trim() = "" Or txtPassword.Text.Trim() = "" Or txtConfirmPassword.Text.Trim() = "" Or cmbUserRole.SelectedItem Is Nothing Then
            MessageBox.Show("❌ All fields are required!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Try
            ' Check if email already exists
            Dim emailExists As Boolean = False
            Using checkCmd As New SqlCommand("SELECT COUNT(*) FROM Users WHERE Email = @Email", con)
                checkCmd.Parameters.AddWithValue("@Email", txtEmail.Text)
                con.Open()
                emailExists = Convert.ToInt32(checkCmd.ExecuteScalar()) > 0
                con.Close()
            End Using

            If emailExists Then
                MessageBox.Show("❌ Email already exists. Please use a different email!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            ' Hash the password with salt
            Dim hashedPassword As String = HashPassword(txtPassword.Text)

            ' Insert new user into the database
            Using cmd As New SqlCommand("INSERT INTO Users (FullName, Email, Password, Role) VALUES (@FullName, @Email, @Password, @Role)", con)
                cmd.Parameters.AddWithValue("@FullName", txtFullName.Text)
                cmd.Parameters.AddWithValue("@Email", txtEmail.Text)
                cmd.Parameters.AddWithValue("@Password", hashedPassword)
                cmd.Parameters.AddWithValue("@Role", cmbUserRole.SelectedItem.ToString())

                con.Open()
                cmd.ExecuteNonQuery()
                con.Close()
            End Using

            MessageBox.Show("✅ Registration Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' Navigate to Login Form after successful registration
            Dim loginForm As New LoginForm()
            loginForm.Show()
            Me.Hide()

        Catch ex As Exception
            MessageBox.Show("❌ Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
        End Try
    End Sub

    ' CLEAR BUTTON CLICK EVENT
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtFullName.Clear()
        txtEmail.Clear()
        txtPassword.Clear()
        txtConfirmPassword.Clear()
        cmbUserRole.SelectedIndex = -1
        chkShowPassword.Checked = False
    End Sub

    ' LOGIN BUTTON CLICK EVENT
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click
        Dim loginForm As New LoginForm()
        loginForm.Show()
        Me.Hide()
    End Sub

    ' FUNCTION TO VALIDATE PASSWORD COMPLEXITY
    Private Function IsValidPassword(password As String) As Boolean
        Dim regex As New Regex("^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[\W_]).{6,}$")
        Return regex.IsMatch(password)
    End Function

    ' FUNCTION TO HASH PASSWORD
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

    ' SHOW PASSWORD CHECKBOX EVENT
    Private Sub chkShowPassword_CheckedChanged(sender As Object, e As EventArgs) Handles chkShowPassword.CheckedChanged
        txtPassword.UseSystemPasswordChar = Not chkShowPassword.Checked
        txtConfirmPassword.UseSystemPasswordChar = Not chkShowPassword.Checked
    End Sub

    ' ALREADY HAVE AN ACCOUNT? (NAVIGATE TO LOGIN)
    Private Sub lblAlreadyAccount_Click(sender As Object, e As EventArgs) Handles lblAlreadyAccount.Click
        Dim loginForm As New LoginForm()
        loginForm.Show()
        Me.Hide()
    End Sub


End Class
