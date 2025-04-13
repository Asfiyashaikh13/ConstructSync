<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ForgotPasswordForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ForgotPasswordForm))
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtNewPassword = New System.Windows.Forms.TextBox()
        Me.btnResetPassword = New System.Windows.Forms.Button()
        Me.txtConfirmPassword = New System.Windows.Forms.TextBox()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.lblRegisteredEmail = New System.Windows.Forms.Label()
        Me.lblnewpassword = New System.Windows.Forms.Label()
        Me.lblconfirmpassword = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtEmail
        '
        Me.txtEmail.Font = New System.Drawing.Font("Yu Gothic Medium", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.Location = New System.Drawing.Point(668, 158)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(257, 32)
        Me.txtEmail.TabIndex = 0
        '
        'txtNewPassword
        '
        Me.txtNewPassword.Font = New System.Drawing.Font("Yu Gothic Medium", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNewPassword.Location = New System.Drawing.Point(668, 229)
        Me.txtNewPassword.Name = "txtNewPassword"
        Me.txtNewPassword.Size = New System.Drawing.Size(257, 35)
        Me.txtNewPassword.TabIndex = 2
        Me.txtNewPassword.UseSystemPasswordChar = True
        '
        'btnResetPassword
        '
        Me.btnResetPassword.Font = New System.Drawing.Font("Segoe UI Black", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnResetPassword.Location = New System.Drawing.Point(504, 415)
        Me.btnResetPassword.Name = "btnResetPassword"
        Me.btnResetPassword.Size = New System.Drawing.Size(144, 48)
        Me.btnResetPassword.TabIndex = 3
        Me.btnResetPassword.Text = "Reset Password"
        Me.btnResetPassword.UseVisualStyleBackColor = True
        '
        'txtConfirmPassword
        '
        Me.txtConfirmPassword.Font = New System.Drawing.Font("Yu Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtConfirmPassword.Location = New System.Drawing.Point(668, 299)
        Me.txtConfirmPassword.Name = "txtConfirmPassword"
        Me.txtConfirmPassword.Size = New System.Drawing.Size(257, 32)
        Me.txtConfirmPassword.TabIndex = 4
        Me.txtConfirmPassword.UseSystemPasswordChar = True
        '
        'btnLogin
        '
        Me.btnLogin.Font = New System.Drawing.Font("Segoe UI Black", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogin.Location = New System.Drawing.Point(805, 415)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(144, 48)
        Me.btnLogin.TabIndex = 5
        Me.btnLogin.Text = "Login"
        Me.btnLogin.UseVisualStyleBackColor = True
        '
        'lblRegisteredEmail
        '
        Me.lblRegisteredEmail.AutoSize = True
        Me.lblRegisteredEmail.Font = New System.Drawing.Font("Segoe UI Black", 10.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRegisteredEmail.Location = New System.Drawing.Point(426, 158)
        Me.lblRegisteredEmail.Name = "lblRegisteredEmail"
        Me.lblRegisteredEmail.Size = New System.Drawing.Size(217, 25)
        Me.lblRegisteredEmail.TabIndex = 6
        Me.lblRegisteredEmail.Text = " Enter Registered Email"
        '
        'lblnewpassword
        '
        Me.lblnewpassword.AutoSize = True
        Me.lblnewpassword.Font = New System.Drawing.Font("Segoe UI Black", 10.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnewpassword.Location = New System.Drawing.Point(496, 229)
        Me.lblnewpassword.Name = "lblnewpassword"
        Me.lblnewpassword.Size = New System.Drawing.Size(143, 25)
        Me.lblnewpassword.TabIndex = 7
        Me.lblnewpassword.Text = "New Password"
        '
        'lblconfirmpassword
        '
        Me.lblconfirmpassword.AutoSize = True
        Me.lblconfirmpassword.Font = New System.Drawing.Font("Segoe UI Black", 10.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblconfirmpassword.Location = New System.Drawing.Point(467, 306)
        Me.lblconfirmpassword.Name = "lblconfirmpassword"
        Me.lblconfirmpassword.Size = New System.Drawing.Size(175, 25)
        Me.lblconfirmpassword.TabIndex = 8
        Me.lblconfirmpassword.Text = "Confirm Password"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Elephant", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(539, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(286, 38)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Forgot Password"
        '
        'ForgotPasswordForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1391, 558)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblconfirmpassword)
        Me.Controls.Add(Me.lblnewpassword)
        Me.Controls.Add(Me.lblRegisteredEmail)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.txtConfirmPassword)
        Me.Controls.Add(Me.btnResetPassword)
        Me.Controls.Add(Me.txtNewPassword)
        Me.Controls.Add(Me.txtEmail)
        Me.Name = "ForgotPasswordForm"
        Me.Text = "ForgotPassword"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtNewPassword As TextBox
    Friend WithEvents btnResetPassword As Button
    Friend WithEvents txtConfirmPassword As TextBox
    Friend WithEvents btnLogin As Button
    Friend WithEvents lblRegisteredEmail As Label
    Friend WithEvents lblnewpassword As Label
    Friend WithEvents lblconfirmpassword As Label
    Friend WithEvents Label1 As Label
End Class
