Imports Microsoft.Data.SqlClient
Imports System.Configuration
Imports System.Security.Cryptography
Imports System.Text

Public Class Registration
    Private connectionString As String = ConfigurationManager.ConnectionStrings("AMCConnectionString").ConnectionString
    Public Sub New()
        InitializeComponent()
    End Sub
    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        ' Validate inputs
        If String.IsNullOrWhiteSpace(txtUsername.Text) OrElse
           String.IsNullOrWhiteSpace(txtPassword.Text) OrElse
           String.IsNullOrWhiteSpace(txtConfirmPassword.Text) Then
            MessageBox.Show("All fields are required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If txtPassword.Text <> txtConfirmPassword.Text Then
            MessageBox.Show("Passwords do not match.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Check if username already exists
        If UsernameExists(txtUsername.Text.Trim) Then
            MessageBox.Show("Username already exists. Please choose another.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Register the user
        Try
            Using con As New SqlConnection(connectionString)
                con.Open()
                Dim query = "INSERT INTO [dbo].[Users] (Username, Role, PasswordHash) VALUES (@Username, @Role, @PasswordHash)"

                Using cmd As New SqlCommand(query, con)
                    cmd.Parameters.AddWithValue("@Username", txtUsername.Text.Trim)
                    cmd.Parameters.AddWithValue("@Role", "Customer") ' Default role
                    cmd.Parameters.AddWithValue("@PasswordHash", ComputeSHA256Hash(txtPassword.Text))

                    Dim rowsAffected = cmd.ExecuteNonQuery

                    If rowsAffected > 0 Then
                        MessageBox.Show("Registration successful! Please login.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Close()
                        Dim loginForm As New LoginForm
                        loginForm.Show()
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Registration failed: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Function UsernameExists(username As String) As Boolean
        Using con As New SqlConnection(connectionString)
            Dim query As String = "SELECT COUNT(*) FROM [dbo].[Users] WHERE Username = @Username"
            Using cmd As New SqlCommand(query, con)
                cmd.Parameters.AddWithValue("@Username", username)
                con.Open()
                Dim result As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                Return result > 0
            End Using
        End Using
    End Function

    Private Function ComputeSHA256Hash(input As String) As String
        Using sha256 As SHA256 = SHA256.Create()
            Dim bytes As Byte() = Encoding.UTF8.GetBytes(input)
            Dim hashBytes As Byte() = sha256.ComputeHash(bytes)
            Return BitConverter.ToString(hashBytes).Replace("-", "").ToLower()
        End Using
    End Function

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Dim login As New LoginForm()
        login.Show()
    End Sub
End Class