Imports System.Data.SqlClient
Imports Microsoft.Data.SqlClient
Public Class ClientManagement
    Inherits BaseForm
    Private WithEvents navigationPanel As Navigation_Panel
    Private connectionString As String = "Data Source=.\SQLEXPRESS;Initial Catalog=AMC_DB;Integrated Security=True;TrustServerCertificate=True;"

    Private Sub ClientManagement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        Dim renewalForm As New RenewalManagement()
        renewalForm.Show()
        Me.Hide()
    End Sub

    Private Sub ShowClientForm(sender As Object, e As EventArgs)
        MessageBox.Show("Already in Client Management!")
    End Sub

    Private Sub ShowServiceForm(sender As Object, e As EventArgs)
        Dim serviceForm As New ServiceRequest()
        serviceForm.Show()
        Me.Hide()
    End Sub

    Private Sub ShowReportsForm(sender As Object, e As EventArgs)
        Dim reportsForm As New Reports()
        reportsForm.Show()
        Me.Hide()
    End Sub

    Private Sub ShowContractForm(sender As Object, e As EventArgs)
        Dim contractForm As New ContractManagement()
        contractForm.Show()
        Me.Hide()
    End Sub

    Private Sub ShowAssetsForm(sender As Object, e As EventArgs)
        Dim assetsForm As New AssetManagement()
        assetsForm.Show()
        Me.Hide()
    End Sub

    Private Sub ShowFeedbackForm(sender As Object, e As EventArgs)
        Dim feedbackForm As New Feedback()
        feedbackForm.Show()
        Me.Hide()
    End Sub

    Private Sub ShowHome(sender As Object, e As EventArgs)
        Dim HomeForm As New HomePage()
        HomeForm.Show()
        Me.Hide()
    End Sub

    Private Sub LogoutApp(sender As Object, e As EventArgs)
        Application.Exit()
    End Sub
    Private Function GenerateClientID() As String
        Dim yearPrefix As String = DateTime.Now.ToString("yy")
        Dim randomNumber As String = New Random().Next(0, 1000).ToString("D3")
        Return $"{yearPrefix}0{randomNumber}"
    End Function

    Private Sub btnAddClient_Click(sender As Object, e As EventArgs) Handles btnAddClient.Click
        ' Validate Inputs
        If String.IsNullOrWhiteSpace(txtCompanyName.Text) Then
            MessageBox.Show("Company Name is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Add Client to DB
        Try
            Using conn As New SqlConnection(connectionString)
                conn.Open()
                ' Modified query to include ClientID
                Dim query As String = "INSERT INTO Clients (ClientID, CompanyName, Email, Phone, BillingInformation) VALUES (@ClientID, @CompanyName, @Email, @Phone, @BillingInformation)"
                Using cmd As New SqlCommand(query, conn)
                    ' Generate and add ClientID parameter
                    cmd.Parameters.AddWithValue("@ClientID", GenerateClientID())
                    cmd.Parameters.AddWithValue("@CompanyName", txtCompanyName.Text.Trim())
                    cmd.Parameters.AddWithValue("@Email", txtEmail.Text.Trim())
                    cmd.Parameters.AddWithValue("@Phone", txtPhone.Text.Trim())
                    cmd.Parameters.AddWithValue("@BillingInformation", txtBillingInfo.Text.Trim())

                    Dim rowsAffected = cmd.ExecuteNonQuery()

                    If rowsAffected > 0 Then
                        MessageBox.Show("Client added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        ClearFields()
                    Else
                        MessageBox.Show("No rows affected. Something went wrong.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub ClearFields()
        txtCompanyName.Clear()
        txtEmail.Clear()
        txtPhone.Clear()
        txtBillingInfo.Clear()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Dim login As New LoginForm()
        login.Show()
        Me.Hide()
    End Sub
End Class