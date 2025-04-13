<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LoginForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LoginForm))
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.lnkForgotPassword = New System.Windows.Forms.LinkLabel()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.chkShowPassword = New System.Windows.Forms.CheckBox()
        Me.btnRegisterRedirect = New System.Windows.Forms.Button()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.pnlLoginContainer = New System.Windows.Forms.Panel()
        Me.lblUserLogin = New System.Windows.Forms.Label()
        Me.pnlLoginContainer.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtPassword
        '
        Me.txtPassword.Font = New System.Drawing.Font("Arial Narrow", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.Location = New System.Drawing.Point(573, 204)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(180, 27)
        Me.txtPassword.TabIndex = 3
        '
        'txtEmail
        '
        Me.txtEmail.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.Location = New System.Drawing.Point(573, 141)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(180, 27)
        Me.txtEmail.TabIndex = 2
        '
        'lnkForgotPassword
        '
        Me.lnkForgotPassword.AutoSize = True
        Me.lnkForgotPassword.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lnkForgotPassword.Location = New System.Drawing.Point(612, 255)
        Me.lnkForgotPassword.Name = "lnkForgotPassword"
        Me.lnkForgotPassword.Size = New System.Drawing.Size(128, 18)
        Me.lnkForgotPassword.TabIndex = 7
        Me.lnkForgotPassword.TabStop = True
        Me.lnkForgotPassword.Text = "Forgot Password"
        '
        'btnLogin
        '
        Me.btnLogin.BackColor = System.Drawing.Color.Gold
        Me.btnLogin.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogin.Location = New System.Drawing.Point(525, 305)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(117, 44)
        Me.btnLogin.TabIndex = 4
        Me.btnLogin.Text = "Login"
        Me.btnLogin.UseVisualStyleBackColor = False
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblPassword.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPassword.Location = New System.Drawing.Point(448, 204)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(103, 24)
        Me.lblPassword.TabIndex = 1
        Me.lblPassword.Text = "Password"
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.Gray
        Me.btnClear.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(705, 305)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(114, 44)
        Me.btnClear.TabIndex = 5
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'chkShowPassword
        '
        Me.chkShowPassword.AutoSize = True
        Me.chkShowPassword.Font = New System.Drawing.Font("Arial Narrow", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkShowPassword.Location = New System.Drawing.Point(780, 204)
        Me.chkShowPassword.Name = "chkShowPassword"
        Me.chkShowPassword.Size = New System.Drawing.Size(142, 26)
        Me.chkShowPassword.TabIndex = 8
        Me.chkShowPassword.Text = "Show Password"
        Me.chkShowPassword.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.chkShowPassword.UseVisualStyleBackColor = True
        '
        'btnRegisterRedirect
        '
        Me.btnRegisterRedirect.BackColor = System.Drawing.Color.DarkOrange
        Me.btnRegisterRedirect.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegisterRedirect.Location = New System.Drawing.Point(890, 305)
        Me.btnRegisterRedirect.Name = "btnRegisterRedirect"
        Me.btnRegisterRedirect.Size = New System.Drawing.Size(111, 44)
        Me.btnRegisterRedirect.TabIndex = 6
        Me.btnRegisterRedirect.Text = "Register"
        Me.btnRegisterRedirect.UseVisualStyleBackColor = False
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblEmail.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmail.Location = New System.Drawing.Point(490, 136)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(61, 24)
        Me.lblEmail.TabIndex = 0
        Me.lblEmail.Text = "Email"
        '
        'pnlLoginContainer
        '
        Me.pnlLoginContainer.BackgroundImage = CType(resources.GetObject("pnlLoginContainer.BackgroundImage"), System.Drawing.Image)
        Me.pnlLoginContainer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pnlLoginContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlLoginContainer.Controls.Add(Me.lblUserLogin)
        Me.pnlLoginContainer.Controls.Add(Me.lnkForgotPassword)
        Me.pnlLoginContainer.Controls.Add(Me.lblEmail)
        Me.pnlLoginContainer.Controls.Add(Me.btnLogin)
        Me.pnlLoginContainer.Controls.Add(Me.btnRegisterRedirect)
        Me.pnlLoginContainer.Controls.Add(Me.lblPassword)
        Me.pnlLoginContainer.Controls.Add(Me.txtEmail)
        Me.pnlLoginContainer.Controls.Add(Me.chkShowPassword)
        Me.pnlLoginContainer.Controls.Add(Me.btnClear)
        Me.pnlLoginContainer.Controls.Add(Me.txtPassword)
        Me.pnlLoginContainer.Location = New System.Drawing.Point(2, -1)
        Me.pnlLoginContainer.Name = "pnlLoginContainer"
        Me.pnlLoginContainer.Size = New System.Drawing.Size(1942, 728)
        Me.pnlLoginContainer.TabIndex = 9
        '
        'lblUserLogin
        '
        Me.lblUserLogin.AutoSize = True
        Me.lblUserLogin.Font = New System.Drawing.Font("Elephant", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUserLogin.Location = New System.Drawing.Point(532, 35)
        Me.lblUserLogin.Name = "lblUserLogin"
        Me.lblUserLogin.Size = New System.Drawing.Size(194, 38)
        Me.lblUserLogin.TabIndex = 9
        Me.lblUserLogin.Text = "User Login"
        '
        'LoginForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1291, 604)
        Me.Controls.Add(Me.pnlLoginContainer)
        Me.Name = "LoginForm"
        Me.Text = "LoginForm"
        Me.pnlLoginContainer.ResumeLayout(False)
        Me.pnlLoginContainer.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents lnkForgotPassword As LinkLabel
    Friend WithEvents btnLogin As Button
    Friend WithEvents lblPassword As Label
    Friend WithEvents btnClear As Button
    Friend WithEvents chkShowPassword As CheckBox
    Friend WithEvents btnRegisterRedirect As Button
    Friend WithEvents lblEmail As Label
    Friend WithEvents pnlLoginContainer As Panel
    Friend WithEvents lblUserLogin As Label
End Class
