Imports System.Data.SqlClient
Imports Microsoft.Data.SqlClient
Imports System.IO

Public Class Reports
    Inherits BaseForm
    Private WithEvents navigationPanel As Navigation_Panel
    Private connectionString As String = "Data Source=.\SQLEXPRESS;Initial Catalog=AMC_DB;Integrated Security=True;TrustServerCertificate=True;"

    Private Sub Report_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Add the Navigation Panel (Don’t Touch)
        navigationPanel = New Navigation_Panel()
        navigationPanel.Location = New Point(0, 0)
        navigationPanel.Size = New Size(800, 44)
        Controls.Add(navigationPanel)

        ' Load actual table names into the ComboBox
        cmbReportType.Items.AddRange(New String() {
            "Clients",
            "Assets",
            "Contracts",
            "Feedbacks",
            "Renewals",
            "ServiceRequests"
        })
        cmbReportType.SelectedIndex = 0

        ' Hook up nav event handlers (Don’t Touch)
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

    ' Navigation handlers (Don’t Touch)
    Private Sub ShowRenewalForm(sender As Object, e As EventArgs) Handles MyBase.FormClosed
        Dim form As New RenewalManagement()
        form.Show()
        Me.Hide()
    End Sub
    Private Sub ShowClientForm(sender As Object, e As EventArgs)
        Dim form As New ClientManagement()
        form.Show()
        Me.Hide()
    End Sub
    Private Sub ShowServiceForm(sender As Object, e As EventArgs)
        Dim form As New ServiceRequest()
        form.Show()
        Me.Hide()
    End Sub
    Private Sub ShowReportsForm(sender As Object, e As EventArgs)
        MessageBox.Show("Already in Reports!")
    End Sub
    Private Sub ShowContractForm(sender As Object, e As EventArgs)
        Dim form As New ContractManagement()
        form.Show()
        Me.Hide()
    End Sub
    Private Sub ShowAssetsForm(sender As Object, e As EventArgs)
        Dim form As New AssetManagement()
        form.Show()
        Me.Hide()
    End Sub
    Private Sub ShowFeedbackForm(sender As Object, e As EventArgs)
        Dim form As New Feedback()
        form.Show()
        Me.Hide()
    End Sub
    Private Sub ShowHome(sender As Object, e As EventArgs)
        Dim form As New HomePage()
        form.Show()
        Me.Hide()
    End Sub
    Private Sub LogoutApp(sender As Object, e As EventArgs)
        Application.Exit()
    End Sub

    ' Generate Report Button Logic
    Private Sub btnGenerateReport_Click(sender As Object, e As EventArgs) Handles btnGenerateReport.Click
        Dim selectedReportType As String = cmbReportType.SelectedItem?.ToString()
        Dim generatedDate As Date = DateTime.Now ' Auto timestamp

        If String.IsNullOrWhiteSpace(selectedReportType) Then
            MessageBox.Show("Please select a report type.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Generate Report ID
        Dim reportId As String = DateTime.Now.ToString("yyMMdd_HHmmss") & "_00#"

        ' Open Save File Dialog
        Using sfd As New SaveFileDialog()
            sfd.Title = "Save Report"
            sfd.Filter = "Text Files (*.txt)|*.txt"
            sfd.FileName = $"{selectedReportType}_Report_{DateTime.Now:yyyyMMdd_HHmmss}.txt"

            If sfd.ShowDialog() = DialogResult.OK Then
                Try
                    ' Generate Report Content
                    Dim reportContent As String = GenerateReportContent(selectedReportType)

                    ' Save content to file
                    File.WriteAllText(sfd.FileName, reportContent)

                    ' Save metadata to DB
                    SaveReportToDatabase(selectedReportType, generatedDate)

                    MessageBox.Show("Report generated and saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Catch ex As Exception
                    MessageBox.Show($"Error saving report: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
        End Using
    End Sub

    ' Generate Content Wrapper
    Private Function GenerateReportContent(reportType As String) As String
        Return FetchTableData(reportType)
    End Function

    ' Fetch Table Data as String
    Private Function FetchTableData(tableName As String) As String
        Dim content As New Text.StringBuilder()
        Using conn As New SqlConnection(connectionString)
            Dim query As String = $"SELECT * FROM {tableName}"
            Using cmd As New SqlCommand(query, conn)
                conn.Open()
                Using reader As SqlDataReader = cmd.ExecuteReader()
                    ' Header row
                    For i As Integer = 0 To reader.FieldCount - 1
                        content.Append(reader.GetName(i)).Append(vbTab)
                    Next
                    content.AppendLine()
                    content.AppendLine(New String("-"c, 50))

                    ' Data rows
                    While reader.Read()
                        For i As Integer = 0 To reader.FieldCount - 1
                            content.Append(reader(i).ToString()).Append(vbTab)
                        Next
                        content.AppendLine()
                    End While
                End Using
            End Using
        End Using
        Return content.ToString()
    End Function

    ' Save Metadata to SQL Table
    Private Sub SaveReportToDatabase(reportType As String, generatedDate As Date)
        Using conn As New SqlConnection(connectionString)
            Dim query As String = "INSERT INTO Reports (ReportType, GeneratedDate) VALUES (@ReportType, @GeneratedDate)"
            Using cmd As New SqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@ReportType", reportType)
                cmd.Parameters.AddWithValue("@GeneratedDate", generatedDate)

                conn.Open()
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Dim login As New LoginForm()
        login.Show()
        Me.Hide()
    End Sub
End Class
