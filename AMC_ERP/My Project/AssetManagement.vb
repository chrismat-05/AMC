Imports System.Data.SqlClient
Imports Microsoft.Data.SqlClient
Public Class AssetManagement
    Inherits BaseForm
    Private WithEvents navigationPanel As Navigation_Panel
    Private connectionString As String = "Data Source=.\SQLEXPRESS;Initial Catalog=AMC_DB;Integrated Security=True;TrustServerCertificate=True;"

    Private Sub AssetManagement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Initialize the Navigation Panel
        navigationPanel = New Navigation_Panel()
        navigationPanel.Location = New Point(0, 0)
        navigationPanel.Size = New Size(800, 44)
        Controls.Add(navigationPanel)

        LoadContractsIntoComboBox()


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
        Dim contractForm As New ContractManagement()
        contractForm.Show()
        Me.Hide()
    End Sub

    Private Sub ShowAssetsForm(sender As Object, e As EventArgs)
        MessageBox.Show("Already in Asset Management!")
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
    Private Sub btnAddAsset_Click(sender As Object, e As EventArgs) Handles btnAddAsset.Click
        ' Get values from form controls
        Dim assetType As String = cmbAssetType.SelectedItem?.ToString()
        Dim serialNumber As String = txtSerialNumber.Text.Trim()
        Dim purchaseDate As Date = dtpPurchaseDate.Value.Date
        Dim warrantyEndDate As Date = dtpWarrantyEndDate.Value.Date
        Dim linkedContractIDText As String = cmbLinkedContract.SelectedValue?.ToString().Trim()
        Dim assetID As Integer = GenerateAssetID() ' Generate the ID

        ' Validation
        If String.IsNullOrEmpty(assetType) OrElse
       String.IsNullOrEmpty(serialNumber) OrElse
       String.IsNullOrEmpty(linkedContractIDText) Then

            MessageBox.Show("Please fill all required fields.", "Missing Info", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If Not Integer.TryParse(linkedContractIDText, Nothing) Then
            MessageBox.Show("Linked Contract ID must be a valid number.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim linkedContractID As Integer = Convert.ToInt32(linkedContractIDText)

        ' Insert into database
        Using con As New SqlConnection(connectionString)
            ' Modified query to include AssetID
            Dim query As String = "INSERT INTO Assets (AssetID, AssetType, SerialNumber, PurchaseDate, WarrantyEndDate, LinkedContractID) 
                               VALUES (@AssetID, @AssetType, @SerialNumber, @PurchaseDate, @WarrantyEndDate, @LinkedContractID)"

            Using cmd As New SqlCommand(query, con)
                ' Add AssetID parameter
                cmd.Parameters.AddWithValue("@AssetID", assetID)
                cmd.Parameters.AddWithValue("@AssetType", assetType)
                cmd.Parameters.AddWithValue("@SerialNumber", serialNumber)
                cmd.Parameters.AddWithValue("@PurchaseDate", purchaseDate)
                cmd.Parameters.AddWithValue("@WarrantyEndDate", warrantyEndDate)
                cmd.Parameters.AddWithValue("@LinkedContractID", linkedContractID)

                Try
                    con.Open()
                    cmd.ExecuteNonQuery()
                    MessageBox.Show($"Asset added successfully!{vbCrLf}Asset ID: {assetID}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    ' Clear form
                    cmbAssetType.SelectedIndex = -1
                    txtSerialNumber.Clear()
                    cmbLinkedContract.SelectedIndex = -1
                    dtpPurchaseDate.Value = Date.Today
                    dtpWarrantyEndDate.Value = Date.Today
                Catch ex As Exception
                    MessageBox.Show("Error while adding asset: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End Using
        End Using
    End Sub
    Private Sub LoadContractsIntoComboBox()
        Using con As New SqlConnection(connectionString)
            Try
                con.Open()
                Dim query As String = "SELECT c.ContractID, cl.CompanyName, c.StartDate, c.EndDate " &
                                  "FROM Contracts c " &
                                  "JOIN Clients cl ON c.ClientID = cl.ClientID"

                Dim cmd As New SqlCommand(query, con)
                Dim dt As New DataTable()
                dt.Load(cmd.ExecuteReader())

                ' Add a column for display purposes
                dt.Columns.Add("Display", GetType(String))
                For Each row As DataRow In dt.Rows
                    row("Display") = row("ContractID").ToString() & " - " & row("CompanyName").ToString()
                Next

                cmbLinkedContract.DisplayMember = "Display"
                cmbLinkedContract.ValueMember = "ContractID"
                cmbLinkedContract.DataSource = dt

            Catch ex As Exception
                MessageBox.Show("Error loading contracts: " & ex.Message)
            End Try
        End Using
    End Sub
    Private Sub cmbLinkedContract_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbLinkedContract.SelectedIndexChanged
        If cmbLinkedContract.SelectedIndex = -1 Then Exit Sub

        Dim selectedRow As DataRowView = TryCast(cmbLinkedContract.SelectedItem, DataRowView)
        If selectedRow IsNot Nothing Then
            dtpPurchaseDate.Value = Convert.ToDateTime(selectedRow("StartDate"))
            dtpWarrantyEndDate.Value = Convert.ToDateTime(selectedRow("EndDate"))
        End If
    End Sub
    Private Function GenerateAssetID() As Integer
        Using conn As New SqlConnection(connectionString)
            Dim cmd As New SqlCommand("SELECT ISNULL(MAX(AssetID), 1110) + 1 FROM Assets", conn)
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