Imports Microsoft.Data.SqlClient
Imports System.Configuration
Imports System.Security.Cryptography
Imports System.Text

Public Class LoginForm
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim connectionString As String = ConfigurationManager.ConnectionStrings("AMCConnectionString").ConnectionString

        Using con As New SqlConnection(connectionString)
            Try
                con.Open()
                ' Modified query to get Role
                Dim query As String = "SELECT Role FROM [dbo].[Users] WHERE Username = @username AND PasswordHash = @password"

                Using cmd As New SqlCommand(query, con)
                    cmd.Parameters.AddWithValue("@username", txtUsername.Text.Trim())
                    Dim passwordHash = ComputeSHA256Hash(txtPassword.Text)
                    cmd.Parameters.AddWithValue("@password", passwordHash)

                    Dim roleObj As Object = cmd.ExecuteScalar()

                    If roleObj IsNot Nothing AndAlso Not IsDBNull(roleObj) Then
                        Dim role As String = roleObj.ToString()

                        ' Role-based navigation
                        If role.ToLower() = "admin" Then
                            Dim reportsForm As New Reports()
                            reportsForm.Show()
                        Else
                            Dim homeForm As New HomePage()
                            homeForm.Show()
                        End If

                        Me.Hide()
                    Else
                        MessageBox.Show("Invalid credentials. Please try again!",
                                  "Error",
                                  MessageBoxButtons.OK,
                                  MessageBoxIcon.Error)
                    End If
                End Using
            Catch ex As Exception
                MessageBox.Show("Database Error: " & ex.Message,
                            "Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error)
            End Try
        End Using
    End Sub


    Private Function ComputeSHA256Hash(input As String) As String
        Using sha256 As SHA256 = SHA256.Create()
            Dim bytes As Byte() = Encoding.UTF8.GetBytes(input)
            Dim hashBytes As Byte() = sha256.ComputeHash(bytes)
            Return BitConverter.ToString(hashBytes).Replace("-", "").ToLower() ' Added ToLower()
        End Using
    End Function

    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtUsername.Select() ' Focus username field on load
    End Sub

    Private Sub lnkForgotPassword_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkForgotPassword.LinkClicked
        Dim registrationform As New Registration()
        registrationform.Show()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Application.Exit()
    End Sub
End Class