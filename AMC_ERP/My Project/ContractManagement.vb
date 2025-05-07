Imports System.Data.SqlClient
Imports Microsoft.Data.SqlClient
Imports System.IO
Imports Windows.Win32.System
Public Class ContractManagement
    Inherits BaseForm
    Private WithEvents navigationPanel As Navigation_Panel
    Private connectionString As String = "Data Source=.\SQLEXPRESS;Initial Catalog=AMC_DB;Integrated Security=True;TrustServerCertificate=True;"
    Private selectedDocumentPath As String = String.Empty

    Private Sub ContractManagement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Initialize the Navigation Panel
        navigationPanel = New Navigation_Panel()
        navigationPanel.Location = New Point(0, 0)
        navigationPanel.Size = New Size(800, 44)
        Controls.Add(navigationPanel)

        LoadClientsIntoComboBox()

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
        Me.Hide()
    End Sub

    Private Sub ShowContractForm(sender As Object, e As EventArgs)
        MessageBox.Show("Already in Contract Management!")
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
    ' Handles attach document click
    Private Sub btnAttachDocument_Click(sender As Object, e As EventArgs) Handles btnAttachDocument.Click
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            selectedDocumentPath = OpenFileDialog1.FileName
            MessageBox.Show("Document attached: " & Path.GetFileName(selectedDocumentPath), "Attached", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    ' Handles create contract click
    Private Sub btnCreateContract_Click(sender As Object, e As EventArgs) Handles btnCreateContract.Click
        ' Get values
        Dim clientName As String = cmbClientName.Text.Trim()
        Dim scope As String = txtScope.Text.Trim()
        Dim pricing As String = txtPricing.Text.Trim()
        Dim durationText As String = txtDuration.Text.Trim()
        Dim startDate As Date = dtpStartDate.Value.Date
        Dim endDate As Date = dtpEndDate.Value.Date
        Dim contractID As String = GenerateContractID() ' Generate the ID

        ' Validate input
        If String.IsNullOrEmpty(clientName) OrElse String.IsNullOrEmpty(scope) OrElse
           String.IsNullOrEmpty(pricing) OrElse String.IsNullOrEmpty(durationText) Then
            MessageBox.Show("All fields are required!", "Missing Data", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If Not Integer.TryParse(durationText, Nothing) Then
            MessageBox.Show("Duration must be a valid number in months.", "Invalid Duration", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If String.IsNullOrEmpty(selectedDocumentPath) OrElse Not File.Exists(selectedDocumentPath) Then
            MessageBox.Show("Please attach a valid document before submitting.", "No Document", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim durationInMonths As Integer = Convert.ToInt32(durationText)

        If cmbClientName.SelectedIndex = -1 Then
            MessageBox.Show("Please select a client.", "Missing Client", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim selectedClientID As Integer = Convert.ToInt32(cmbClientName.SelectedValue)

        ' Insert into DB
        Using con As New SqlConnection(connectionString)
            ' Modified query to include ContractID
            Dim query As String = "INSERT INTO Contracts (ContractID, ClientID, Scope, Pricing, DurationInMonths, StartDate, EndDate, DocumentPath)
                              VALUES (@ContractID, @ClientID, @Scope, @Pricing, @Duration, @StartDate, @EndDate, @DocumentPath)"

            Using cmd As New SqlCommand(query, con)
                ' Add ContractID parameter
                cmd.Parameters.AddWithValue("@ContractID", contractID)
                cmd.Parameters.AddWithValue("@ClientID", selectedClientID)
                cmd.Parameters.AddWithValue("@Scope", scope)
                cmd.Parameters.AddWithValue("@Pricing", pricing)
                cmd.Parameters.AddWithValue("@Duration", durationInMonths)
                cmd.Parameters.AddWithValue("@StartDate", startDate)
                cmd.Parameters.AddWithValue("@EndDate", endDate)
                cmd.Parameters.AddWithValue("@DocumentPath", selectedDocumentPath)

                Try
                    con.Open()
                    cmd.ExecuteNonQuery()
                    MessageBox.Show($"Contract created successfully!{vbCrLf}Contract ID: {contractID}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    ' Clear fields
                    cmbClientName.SelectedIndex = -1
                    txtScope.Clear()
                    txtPricing.Clear()
                    txtDuration.Clear()
                    dtpStartDate.Value = Date.Today
                    dtpEndDate.Value = Date.Today
                    selectedDocumentPath = String.Empty
                Catch ex As Exception
                    MessageBox.Show("Error: " & ex.Message, "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End Using
        End Using
    End Sub
    Private Sub LoadClientsIntoComboBox()
        Using con As New SqlConnection(connectionString)
            Try
                con.Open()
                Dim query As String = "SELECT ClientID, CompanyName FROM Clients"
                Dim cmd As New SqlCommand(query, con)
                Dim dt As New DataTable()
                dt.Load(cmd.ExecuteReader())

                cmbClientName.DisplayMember = "CompanyName"   ' What is shown
                cmbClientName.ValueMember = "ClientID"        ' What is stored
                cmbClientName.DataSource = dt

                cmbClientName.SelectedIndex = -1              ' Optional: no pre-selection
            Catch ex As Exception
                MessageBox.Show("Failed to load clients: " & ex.Message, "DB Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub
    Private Function GenerateContractID() As String
        Dim datePart As String = DateTime.Now.ToString("yyMMdd")
        Dim randomPart As String = New Random().Next(0, 100).ToString("D2")
        Return $"{datePart}{randomPart}"
    End Function

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Dim login As New LoginForm()
        login.Show()
        Me.Hide()
    End Sub
End Class