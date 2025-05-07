<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LoginForm
    Inherits System.Windows.Forms.Form

    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        lblUsername = New Label()
        lblPassword = New Label()
        txtUsername = New TextBox()
        txtPassword = New TextBox()
        btnLogin = New Button()
        lnkForgotPassword = New LinkLabel()
        PictureBox1 = New PictureBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        '
        ' lblUsername
        '
        lblUsername.AutoSize = True
        lblUsername.ForeColor = Color.Black
        lblUsername.Location = New Point(600, 205)
        lblUsername.Name = "lblUsername"
        lblUsername.Size = New Size(98, 23)
        lblUsername.TabIndex = 0
        lblUsername.Text = "Username"
        '
        ' lblPassword
        '
        lblPassword.AutoSize = True
        lblPassword.ForeColor = Color.Black
        lblPassword.Location = New Point(600, 281)
        lblPassword.Name = "lblPassword"
        lblPassword.Size = New Size(95, 23)
        lblPassword.TabIndex = 1
        lblPassword.Text = "Password"
        '
        ' txtUsername
        '
        txtUsername.BackColor = SystemColors.InactiveCaption
        txtUsername.ForeColor = Color.Black
        txtUsername.BorderStyle = BorderStyle.FixedSingle
        txtUsername.Location = New Point(757, 200)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(201, 29)
        txtUsername.TabIndex = 2
        '
        ' txtPassword
        '
        txtPassword.BackColor = SystemColors.InactiveCaption
        txtPassword.ForeColor = Color.Black
        txtPassword.BorderStyle = BorderStyle.FixedSingle
        txtPassword.Location = New Point(757, 277)
        txtPassword.Name = "txtPassword"
        txtPassword.PasswordChar = "*"c
        txtPassword.Size = New Size(201, 29)
        txtPassword.TabIndex = 3
        '
        ' btnLogin
        '
        btnLogin.BackColor = Color.Black
        btnLogin.ForeColor = Color.White
        btnLogin.FlatAppearance.BorderColor = Color.Red
        btnLogin.FlatAppearance.BorderSize = 1
        btnLogin.FlatStyle = FlatStyle.Flat
        btnLogin.Cursor = Cursors.Hand
        btnLogin.Location = New Point(721, 377)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(118, 35)
        btnLogin.TabIndex = 4
        btnLogin.Text = "Login"
        btnLogin.UseVisualStyleBackColor = False
        '
        ' lnkForgotPassword
        '
        lnkForgotPassword.ActiveLinkColor = Color.Red
        lnkForgotPassword.AutoSize = True
        lnkForgotPassword.BackColor = Color.Black
        lnkForgotPassword.Font = New Font("Georgia", 14.25F, FontStyle.Regular)
        lnkForgotPassword.LinkColor = Color.White
        lnkForgotPassword.Location = New Point(675, 444)
        lnkForgotPassword.Name = "lnkForgotPassword"
        lnkForgotPassword.Size = New Size(222, 23)
        lnkForgotPassword.TabIndex = 5
        lnkForgotPassword.TabStop = True
        lnkForgotPassword.Text = "New User? Register now!"
        '
        ' PictureBox1
        '
        PictureBox1.BackgroundImage = My.Resources.Resources.Exit_icon
        PictureBox1.BackgroundImageLayout = ImageLayout.Zoom
        PictureBox1.Location = New Point(1009, 12)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(50, 50)
        PictureBox1.TabStop = False
        '
        ' LoginForm
        '
        BackColor = Color.White
        BackgroundImage = My.Resources.Resources.Login_form_bg
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1071, 604)
        Controls.Add(PictureBox1)
        Controls.Add(lnkForgotPassword)
        Controls.Add(btnLogin)
        Controls.Add(txtPassword)
        Controls.Add(txtUsername)
        Controls.Add(lblPassword)
        Controls.Add(lblUsername)
        Font = New Font("Georgia", 14.0!, FontStyle.Italic)
        Name = "LoginForm"
        Text = "Login"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblUsername As Label
    Friend WithEvents lblPassword As Label
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents btnLogin As Button
    Friend WithEvents lnkForgotPassword As LinkLabel
    Friend WithEvents PictureBox1 As PictureBox
End Class