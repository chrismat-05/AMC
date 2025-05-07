Imports System.Data.SqlClient
Imports Microsoft.Data.SqlClient

Public Class ServiceRequest
    Inherits BaseForm
    Private WithEvents navigationPanel As Navigation_Panel
    Private connectionString As String = "Data Source=.\SQLEXPRESS;Initial Catalog=AMC_DB;Integrated Security=True;TrustServerCertificate=True;"

    Private Sub ServiceRequest_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

        ' Load clients
        LoadClients()
    End Sub

    ' Load clients into cmbClientName
    Private Sub LoadClients()
        Using conn As New SqlConnection(connectionString)
            Dim query As String = "SELECT ClientID, CompanyName FROM Clients"
            Dim cmd As New SqlCommand(query, conn)
            Dim adapter As New SqlDataAdapter(cmd)
            Dim dt As New DataTable()

            Try
                conn.Open()
                adapter.Fill(dt)

                cmbClientName.DisplayMember = "CompanyName"
                cmbClientName.ValueMember = "ClientID"
                cmbClientName.DataSource = dt
                cmbClientName.SelectedIndex = -1

            Catch ex As Exception
                MessageBox.Show("Error loading clients: " & ex.Message)
            End Try
        End Using
    End Sub

    ' When client is selected, load related contracts
    Private Sub cmbClientName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbClientName.SelectedIndexChanged
        If cmbClientName.SelectedIndex <> -1 AndAlso cmbClientName.SelectedValue IsNot Nothing AndAlso IsNumeric(cmbClientName.SelectedValue) Then
            Dim selectedClientId As Integer = CInt(cmbClientName.SelectedValue)

            Using conn As New SqlConnection(connectionString)
                Dim query As String = "SELECT ContractID FROM Contracts WHERE ClientID = @ClientID"
                Dim cmd As New SqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@ClientID", selectedClientId)
                Dim adapter As New SqlDataAdapter(cmd)
                Dim dt As New DataTable()

                Try
                    conn.Open()
                    adapter.Fill(dt)

                    If dt.Rows.Count = 0 Then
                        cmbContract.DataSource = Nothing
                        cmbContract.Items.Clear()
                        MessageBox.Show("No contracts found for this client.")
                        Return
                    End If

                    ' Add display formatting
                    Dim displayTable As New DataTable()
                    displayTable.Columns.Add("ContractID", GetType(Integer))
                    displayTable.Columns.Add("ContractLabel", GetType(String))

                    For Each row As DataRow In dt.Rows
                        Dim contractID As Integer = Convert.ToInt32(row("ContractID"))
                        displayTable.Rows.Add(contractID, "Contract #" & contractID.ToString())
                    Next

                    cmbContract.DisplayMember = "ContractLabel"
                    cmbContract.ValueMember = "ContractID"
                    cmbContract.DataSource = displayTable
                    cmbContract.SelectedIndex = -1

                Catch ex As Exception
                    MessageBox.Show("Error loading contracts: " & ex.Message)
                End Try
            End Using
        End If
    End Sub

    ' Create service request when button is clicked
    Private Sub btnCreateRequest_Click(sender As Object, e As EventArgs) Handles btnCreateRequest.Click
        ' Validate inputs
        If cmbClientName.SelectedIndex = -1 OrElse cmbContract.SelectedIndex = -1 OrElse String.IsNullOrWhiteSpace(txtIssueDescription.Text) Then
            MessageBox.Show("Please select a client, contract, and enter a request description.")
            Return
        End If

        ' Get values
        Dim clientId As Integer = CInt(cmbClientName.SelectedValue)
        Dim contractId As Integer = CInt(cmbContract.SelectedValue)
        Dim requestText As String = txtIssueDescription.Text.Trim()
        Dim requestDate As DateTime = DateTime.Now
        Dim requestID As String = GenerateRequestID() ' Generate the ID

        Using conn As New SqlConnection(connectionString)
            ' Modified query to include RequestID
            Dim query As String = "INSERT INTO ServiceRequests (RequestID, ClientID, ContractID, IssueDescription, DateLogged) 
                             VALUES (@RequestID, @ClientID, @ContractID, @IssueDescription, @DateLogged)"
            Dim cmd As New SqlCommand(query, conn)

            ' Add RequestID parameter
            cmd.Parameters.AddWithValue("@RequestID", requestID)
            cmd.Parameters.AddWithValue("@ClientID", clientId)
            cmd.Parameters.AddWithValue("@ContractID", contractId)
            cmd.Parameters.AddWithValue("@IssueDescription", requestText)
            cmd.Parameters.AddWithValue("@DateLogged", requestDate)

            Try
                conn.Open()
                cmd.ExecuteNonQuery()
                MessageBox.Show($"Service request created successfully!{vbCrLf}Request ID: {requestID}")
                txtIssueDescription.Clear()
                cmbClientName.SelectedIndex = -1
                cmbContract.DataSource = Nothing
            Catch ex As Exception
                MessageBox.Show("Error creating request: " & ex.Message)
            End Try
        End Using
    End Sub

    ' Navigation event handlers
    Private Sub ShowRenewalForm(sender As Object, e As EventArgs)
        Dim renewalForm As New RenewalManagement()
        renewalForm.Show()
        Me.Hide()
    End Sub

    Private Sub ShowClientForm(sender As Object, e As EventArgs)
        Dim clientForm As New ClientManagement()
        clientForm.Show()
        Me.Hide()
    End Sub

    Private Sub ShowServiceForm(sender As Object, e As EventArgs)
        MessageBox.Show("Already in Service Requests and Tickets!")
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
        Dim homeForm As New HomePage()
        homeForm.Show()
        Me.Hide()
    End Sub

    Private Sub LogoutApp(sender As Object, e As EventArgs)
        Application.Exit()
    End Sub
    Private Function GenerateRequestID() As String
        Dim now As DateTime = DateTime.Now
        Dim timestamp As String = now.ToString("yyMMdd_HHmmss")
        Dim suffix As String = "_" & New Random().Next(0, 1000).ToString("D3")
        Return timestamp & suffix
    End Function

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Dim login As New LoginForm()
        login.Show()
        Me.Hide()
    End Sub
End Class
