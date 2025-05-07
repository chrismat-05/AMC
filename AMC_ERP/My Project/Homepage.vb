Imports System.Data.SqlClient
Imports Microsoft.Data.SqlClient
Public Class HomePage
    Inherits BaseForm
    Private WithEvents navigationPanel As Navigation_Panel
    Private connectionString As String = "Data Source=.\SQLEXPRESS;Initial Catalog=AMC_DB;Integrated Security=True;TrustServerCertificate=True;"


    Private Sub HomePage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Create navigation panel dynamically
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
        LoadLiveCounters()
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

    Private Sub ShowHome(sender As Object, e As EventArgs)
        ' You can decide if you want to navigate to a home form or just show a message
        MessageBox.Show("Already in Home!")
    End Sub

    Private Sub ShowAssetsForm(sender As Object, e As EventArgs)
        ' Open Asset Management Form
        Dim assetsForm As New AssetManagement()
        assetsForm.Show()
        Me.Hide()
    End Sub

    Private Sub ShowFeedbackForm(sender As Object, e As EventArgs)
        ' Open Feedback Form
        Dim feedbackForm As New Feedback()
        feedbackForm.Show()
        Me.Hide()
    End Sub

    Private Sub LogoutApp(sender As Object, e As EventArgs)
        ' Close the application
        Application.Exit()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Dim login As New LoginForm()
        login.Show()
        Me.Hide()
    End Sub
    Private Sub LoadLiveCounters()
        Using con As New SqlConnection(connectionString)
            con.Open()

            ' Contracts
            Using cmdContracts As New SqlCommand("SELECT COUNT(*) FROM Contracts", con)
                lblContractsCount.Text = cmdContracts.ExecuteScalar().ToString()
            End Using


            ' Clients
            Using cmdClients As New SqlCommand("SELECT COUNT(*) FROM Clients", con)
                lblClientsCount.Text = cmdClients.ExecuteScalar().ToString()
            End Using

            ' Assets
            Using cmdAssets As New SqlCommand("SELECT COUNT(*) FROM Assets", con)
                lblAssetsCount.Text = cmdAssets.ExecuteScalar().ToString()
            End Using
        End Using
    End Sub
End Class
