<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Registration
    Inherits System.Windows.Forms.Form

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

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label2 = New Label()
        Label3 = New Label()
        txtUsername = New TextBox()
        txtPassword = New TextBox()
        txtConfirmPassword = New TextBox()
        Label4 = New Label()
        btnRegister = New Button()
        PictureBox1 = New PictureBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        '
        ' Label2
        '
        Label2.AutoSize = True
        Label2.ForeColor = Color.Black
        Label2.Location = New Point(695, 221)
        Label2.Name = "Label2"
        Label2.Size = New Size(98, 23)
        Label2.TabIndex = 1
        Label2.Text = "Username"
        '
        ' Label3
        '
        Label3.AutoSize = True
        Label3.ForeColor = Color.Black
        Label3.Location = New Point(695, 312)
        Label3.Name = "Label3"
        Label3.Size = New Size(95, 23)
        Label3.TabIndex = 2
        Label3.Text = "Password"
        '
        ' txtUsername
        '
        txtUsername.BackColor = SystemColors.InactiveCaption
        txtUsername.ForeColor = Color.Black
        txtUsername.BorderStyle = BorderStyle.FixedSingle
        txtUsername.Cursor = Cursors.Hand
        txtUsername.Font = New Font("Georgia", 14.25F, FontStyle.Italic)
        txtUsername.Location = New Point(899, 217)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(240, 29)
        txtUsername.TabIndex = 3
        '
        ' txtPassword
        '
        txtPassword.BackColor = SystemColors.InactiveCaption
        txtPassword.ForeColor = Color.Black
        txtPassword.BorderStyle = BorderStyle.FixedSingle
        txtPassword.Location = New Point(899, 308)
        txtPassword.Name = "txtPassword"
        txtPassword.Size = New Size(239, 29)
        txtPassword.TabIndex = 4
        '
        ' txtConfirmPassword
        '
        txtConfirmPassword.BackColor = SystemColors.InactiveCaption
        txtConfirmPassword.ForeColor = Color.Black
        txtConfirmPassword.BorderStyle = BorderStyle.FixedSingle
        txtConfirmPassword.Location = New Point(899, 400)
        txtConfirmPassword.Name = "txtConfirmPassword"
        txtConfirmPassword.Size = New Size(239, 29)
        txtConfirmPassword.TabIndex = 6
        '
        ' Label4
        '
        Label4.AutoSize = True
        Label4.ForeColor = Color.Black
        Label4.Location = New Point(695, 404)
        Label4.Name = "Label4"
        Label4.Size = New Size(171, 23)
        Label4.TabIndex = 5
        Label4.Text = "Confirm Password"
        '
        ' btnRegister
        '
        btnRegister.BackColor = Color.Black
        btnRegister.ForeColor = Color.White
        btnRegister.FlatAppearance.BorderColor = Color.Red
        btnRegister.FlatAppearance.BorderSize = 1
        btnRegister.FlatStyle = FlatStyle.Flat
        btnRegister.Cursor = Cursors.Hand
        btnRegister.Location = New Point(828, 481)
        btnRegister.Name = "btnRegister"
        btnRegister.Size = New Size(179, 60)
        btnRegister.TabIndex = 7
        btnRegister.Text = "Register"
        btnRegister.UseVisualStyleBackColor = False
        '
        ' PictureBox1
        '
        PictureBox1.BackgroundImage = My.Resources.Resources.Exit_icon
        PictureBox1.BackgroundImageLayout = ImageLayout.Zoom
        PictureBox1.Location = New Point(1195, 12)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(50, 50)
        PictureBox1.TabStop = False
        '
        ' Registration
        '
        BackColor = Color.White
        BackgroundImage = My.Resources.Resources.Registration_form_bg
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1257, 690)
        Controls.Add(PictureBox1)
        Controls.Add(btnRegister)
        Controls.Add(txtConfirmPassword)
        Controls.Add(Label4)
        Controls.Add(txtPassword)
        Controls.Add(txtUsername)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Font = New Font("Georgia", 14.0!, FontStyle.Italic)
        Name = "Registration"
        Text = "Registration"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtConfirmPassword As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btnRegister As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class