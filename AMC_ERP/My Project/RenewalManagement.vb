Imports System.Data.SqlClient
Imports Microsoft.Data.SqlClient

Public Class RenewalManagement
    Inherits BaseForm
    Private WithEvents navigationPanel As Navigation_Panel
    Private connectionString As String = "Data Source=.\SQLEXPRESS;Initial Catalog=AMC_DB;Integrated Security=True;TrustServerCertificate=True;"

    Private Sub RenewalManagement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Initialize the Navigation Panel
        navigationPanel = New Navigation_Panel()
        navigationPanel.Location = New Point(0, 0)
        navigationPanel.Size = New Size(800, 44)
        Controls.Add(navigationPanel)

        LoadClients()

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
        MessageBox.Show("Already in Renewals!")
    End Sub

    Private Sub ShowClientForm(sender As Object, e As EventArgs)
        Dim clientForm As New ClientManagement()
        clientForm.Show()
        Me.Hide()
    End Sub

    Private Sub ShowServiceForm(sender As Object, e As EventArgs)
        Dim serviceForm As New ServiceRequest()
        serviceForm.Show()
        Me.Hide()
    End Sub

    Private Sub ShowReportsForm(sender As Object, e As EventArgs)
        Dim reportsForm As New Reports()
        reportsForm.Show()
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

    Private Sub LoadClients()
        Using con As New SqlConnection(connectionString)
            Dim query As String = "SELECT ClientID, CompanyName FROM Clients"
            Dim cmd As New SqlCommand(query, con)
            Dim adapter As New SqlDataAdapter(cmd)
            Dim table As New DataTable()
            adapter.Fill(table)

            cmbClient.DataSource = table
            cmbClient.DisplayMember = "CompanyName"
            cmbClient.ValueMember = "ClientID"
            cmbClient.SelectedIndex = -1 ' Optional: unselect default
        End Using
    End Sub


    Private Sub LoadContracts(clientId As Integer)
        Using con As New SqlConnection(connectionString)
            Dim query As String = "SELECT ContractID FROM Contracts WHERE ClientID = @ClientID"
            Dim cmd As New SqlCommand(query, con)
            cmd.Parameters.AddWithValue("@ClientID", clientId)

            Dim adapter As New SqlDataAdapter(cmd)
            Dim table As New DataTable()
            adapter.Fill(table)

            cmbContract.DataSource = table
            cmbContract.DisplayMember = "ContractID"
            cmbContract.ValueMember = "ContractID"
            cmbContract.SelectedIndex = -1 ' Optional: unselect default
        End Using
    End Sub

    Private Sub cmbClient_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbClient.SelectedIndexChanged
        If cmbClient.SelectedIndex <> -1 AndAlso cmbClient.SelectedValue IsNot Nothing Then
            ' Make sure it's not a DataRowView
            If Not TypeOf cmbClient.SelectedValue Is DataRowView Then
                Try
                    Dim clientId As Integer = Convert.ToInt32(cmbClient.SelectedValue)
                    LoadContracts(clientId)
                Catch ex As Exception
                    MessageBox.Show("Error loading contracts: " & ex.Message)
                End Try
            End If
        End If
    End Sub

    Private Sub cmbContract_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbContract.SelectedIndexChanged
        If cmbContract.SelectedIndex <> -1 AndAlso cmbContract.SelectedValue IsNot Nothing Then
            ' Ensure the selected value is not a DataRowView
            If Not TypeOf cmbContract.SelectedValue Is DataRowView Then
                Try
                    Dim contractId As Integer = Convert.ToInt32(cmbContract.SelectedValue)
                    SetRenewalDate(contractId)
                Catch ex As Exception
                    MessageBox.Show("Error setting renewal date: " & ex.Message)
                End Try
            End If
        End If
    End Sub

    Private Sub SetRenewalDate(contractId As Integer)
        Using con As New SqlConnection(connectionString)
            Dim query As String = "SELECT EndDate FROM Contracts WHERE ContractID = @ContractID"
            Dim cmd As New SqlCommand(query, con)
            cmd.Parameters.AddWithValue("@ContractID", contractId)

            con.Open()
            Dim result = cmd.ExecuteScalar()
            If result IsNot Nothing AndAlso Not IsDBNull(result) Then
                dtpRenewalDate.Value = Convert.ToDateTime(result)
            Else
                MessageBox.Show("No EndDate found for selected Contract.")
            End If
        End Using
    End Sub
    Private Sub btnRenewContract_Click(sender As Object, e As EventArgs) Handles btnRenewContract.Click
        If cmbClient.SelectedIndex = -1 Or cmbContract.SelectedIndex = -1 Then
            MessageBox.Show("Please select a client and a contract before renewing.")
            Return
        End If

        Try
            Dim clientId As Integer = Convert.ToInt32(cmbClient.SelectedValue)
            Dim contractId As Integer = Convert.ToInt32(cmbContract.SelectedValue)
            Dim renewalDate As Date = dtpRenewalDate.Value
            Dim RenewalID As String = GenerateRenewalID()

            Using con As New SqlConnection(connectionString)
                Dim query As String = "INSERT INTO Renewals (ClientID, ContractID, RenewalDate, RenewalID) VALUES (@ClientID, @ContractID, @RenewalDate, @RenewalID)"
                Using cmd As New SqlCommand(query, con)
                    cmd.Parameters.AddWithValue("@ClientID", clientId)
                    cmd.Parameters.AddWithValue("@ContractID", contractId)
                    cmd.Parameters.AddWithValue("@RenewalDate", renewalDate)
                    cmd.Parameters.AddWithValue("@RenewalID", RenewalID)

                    con.Open()
                    Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
                    If rowsAffected > 0 Then
                        MessageBox.Show("Contract applied for renewal successfully." & vbCrLf & "RenewalID: " & RenewalID & vbCrLf & "Our team will get in touch with you in the next 48 hours. Thank you")
                    Else
                        MessageBox.Show("No rows inserted. Please try again.")
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error while renewing contract: " & ex.Message)
        End Try
    End Sub

    Private Function GenerateRenewalID() As String
        Dim now As DateTime = DateTime.Now
        Dim timestamp As String = now.ToString("yyMMdd_HH:mm:ss")
        Dim suffix As String = "_" & New Random().Next(0, 1000).ToString("D3")
        Return timestamp & suffix
    End Function

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Dim login As New LoginForm()
        login.Show()
        Me.Hide()
    End Sub
End Class