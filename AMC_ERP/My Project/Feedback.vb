Imports System.Data.SqlClient
Imports Microsoft.Data.SqlClient
Public Class Feedback
    Inherits BaseForm
    Private WithEvents navigationPanel As Navigation_Panel
    Private connectionString As String = "Data Source=.\SQLEXPRESS;Initial Catalog=AMC_DB;Integrated Security=True;TrustServerCertificate=True;"

    Private Sub Feedback_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Initialize the Navigation Panel
        navigationPanel = New Navigation_Panel()
        navigationPanel.Location = New Point(0, 0)
        navigationPanel.Size = New Size(800, 44)
        Controls.Add(navigationPanel)

        ' Hook up event handlers
        AddHandler navigationPanel.RenewalManagementClicked, AddressOf ShowRenewalForm
        AddHandler navigationPanel.ClientManagementClicked, AddressOf ShowClientForm
        AddHandler navigationPanel.ServiceRequestClicked, AddressOf ShowServiceForm
        AddHandler navigationPanel.ReportsClicked, AddressOf ShowReportsForm
        AddHandler navigationPanel.ContractManagementClicked, AddressOf ShowContractForm
        AddHandler navigationPanel.HomepageClicked, AddressOf ShowHome
        AddHandler navigationPanel.AssetManagementClicked, AddressOf ShowAssetsForm
        AddHandler navigationPanel.FeedbackClicked, AddressOf ShowFeedbackForm
        AddHandler navigationPanel.LogoutClicked, AddressOf LogoutApp
    End Sub

    ' Open the corresponding form when the button is clicked
    Private Sub ShowRenewalForm(sender As Object, e As EventArgs)
        ' Open Renewal Management Form
        Dim renewalForm As New RenewalManagement()
        renewalForm.Show()
        Me.Hide()
    End Sub

    Private Sub ShowClientForm(sender As Object, e As EventArgs)
        ' Open Client Management Form
        Dim clientForm As New ClientManagement()
        clientForm.Show()
        Me.Hide()
    End Sub

    Private Sub ShowServiceForm(sender As Object, e As EventArgs)
        ' Open Service Request Form
        Dim serviceForm As New ServiceRequest()
        serviceForm.Show()
        Me.Hide()
    End Sub

    Private Sub ShowReportsForm(sender As Object, e As EventArgs)
        ' Open Reports Form
        Dim reportsForm As New Reports()
        reportsForm.Show()
        Me.Hide()
    End Sub

    Private Sub ShowContractForm(sender As Object, e As EventArgs)
        ' Open Contract Management Form
        Dim contractForm As New ContractManagement()
        contractForm.Show()
        Me.Hide()
    End Sub

    Private Sub ShowFeedbackForm(sender As Object, e As EventArgs)
        ' You can decide if you want to navigate to a home form or just show a message
        MessageBox.Show("Already in Feedback!")
    End Sub

    Private Sub ShowAssetsForm(sender As Object, e As EventArgs)
        ' Open Asset Management Form
        Dim assetsForm As New AssetManagement()
        assetsForm.Show()
        Me.Hide()
    End Sub

    Private Sub ShowHome(sender As Object, e As EventArgs)
        ' Open Feedback Form
        Dim HomeForm As New HomePage()
        HomeForm.Show()
        Me.Hide()
    End Sub

    Private Sub LogoutApp(sender As Object, e As EventArgs)
        ' Close the application
        Application.Exit()
    End Sub

    Private Sub btnSubmitFeedback_Click(sender As Object, e As EventArgs) Handles btnSubmitFeedback.Click
        Dim clientUsername As String = txtClient.Text.Trim()
        Dim feedbackMessage As String = txtFeedback.Text.Trim()
        Dim ratingValue As Integer = Convert.ToInt32(numRating.Value)
        Dim feedbackID As Integer = GenerateFeedbackID() ' Generate the ID

        If clientUsername = "" OrElse feedbackMessage = "" Then
            MessageBox.Show("Please fill in all fields.")
            Return
        End If

        Using con As New SqlConnection(connectionString)
            ' Modified query to include FeedbackID
            Dim query As String = "INSERT INTO Feedbacks (FeedbackID, Client, FeedbackText, Rating) VALUES (@id, @client, @text, @rating)"

            Using cmd As New SqlCommand(query, con)
                ' Add FeedbackID parameter
                cmd.Parameters.AddWithValue("@id", feedbackID)
                cmd.Parameters.AddWithValue("@client", clientUsername)
                cmd.Parameters.AddWithValue("@text", feedbackMessage)
                cmd.Parameters.AddWithValue("@rating", ratingValue)

                Try
                    con.Open()
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Feedback submitted successfully!" & vbCrLf & $"Feedback ID: {feedbackID}", "Success")
                    txtClient.Clear()
                    txtFeedback.Clear()
                    numRating.Value = 0
                Catch ex As Exception
                    MessageBox.Show("Error submitting feedback: " & ex.Message)
                End Try
            End Using
        End Using
    End Sub
    Private Function GenerateFeedbackID() As Integer
        Using conn As New SqlConnection(connectionString)
            Dim cmd As New SqlCommand("SELECT ISNULL(MAX(FeedbackID), 0) + 1 FROM Feedbacks", conn)
            conn.Open()
            Return Convert.ToInt32(cmd.ExecuteScalar())
        End Using
    End Function

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Dim login As New LoginForm()
        login.Show()
        Me.Hide()
    End Sub
End Class
