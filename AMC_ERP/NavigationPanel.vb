Imports System.Windows.Forms

Public Class Navigation_Panel
    Inherits UserControl

    ' Event declarations for specific actions
    Public Event RenewalManagementClicked As EventHandler
    Public Event ClientManagementClicked As EventHandler
    Public Event ServiceRequestClicked As EventHandler
    Public Event ReportsClicked As EventHandler
    Public Event ContractManagementClicked As EventHandler
    Public Event HomepageClicked As EventHandler
    Public Event AssetManagementClicked As EventHandler
    Public Event FeedbackClicked As EventHandler
    Public Event LogoutClicked As EventHandler

    ' Event handlers for button clicks, raising appropriate events
    Private Sub btnHomepage_Click(sender As Object, e As EventArgs) Handles btnHomepage.Click
        RaiseEvent HomepageClicked(Me, EventArgs.Empty)
    End Sub

    Private Sub btnClients_Click(sender As Object, e As EventArgs) Handles btnClients.Click
        RaiseEvent ClientManagementClicked(Me, EventArgs.Empty)
    End Sub

    Private Sub btnContracts_Click(sender As Object, e As EventArgs) Handles btnContracts.Click
        RaiseEvent ContractManagementClicked(Me, EventArgs.Empty)
    End Sub

    Private Sub btnRenewal_Click(sender As Object, e As EventArgs) Handles btnRenewal.Click
        RaiseEvent RenewalManagementClicked(Me, EventArgs.Empty)
    End Sub

    Private Sub btnAssets_Click(sender As Object, e As EventArgs) Handles btnAssets.Click
        RaiseEvent AssetManagementClicked(Me, EventArgs.Empty)
    End Sub

    Private Sub btnTickets_Click(sender As Object, e As EventArgs) Handles btnTickets.Click
        RaiseEvent ServiceRequestClicked(Me, EventArgs.Empty)
    End Sub

    Private Sub btnFeedback_Click(sender As Object, e As EventArgs) Handles btnFeedback.Click
        RaiseEvent FeedbackClicked(Me, EventArgs.Empty)
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs)
        RaiseEvent LogoutClicked(Me, EventArgs.Empty)
    End Sub

    Private Sub pnlNavigation_Paint(sender As Object, e As PaintEventArgs) Handles pnlNavigation.Paint

    End Sub
End Class