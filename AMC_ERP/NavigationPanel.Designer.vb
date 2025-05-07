<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Navigation_Panel
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        pnlNavigation = New Panel()
        btnFeedback = New Button()
        btnAssets = New Button()
        btnRenewal = New Button()
        btnContracts = New Button()
        btnHomepage = New Button()
        btnClients = New Button()
        btnTickets = New Button()
        pnlNavigation.SuspendLayout()
        SuspendLayout()
        ' 
        ' pnlNavigation
        ' 
        pnlNavigation.BackColor = Color.Transparent
        pnlNavigation.Controls.Add(btnFeedback)
        pnlNavigation.Controls.Add(btnAssets)
        pnlNavigation.Controls.Add(btnRenewal)
        pnlNavigation.Controls.Add(btnContracts)
        pnlNavigation.Controls.Add(btnHomepage)
        pnlNavigation.Controls.Add(btnClients)
        pnlNavigation.Controls.Add(btnTickets)
        pnlNavigation.Dock = DockStyle.Top
        pnlNavigation.Font = New Font("Cambria", 12.0F)
        pnlNavigation.Location = New Point(0, 0)
        pnlNavigation.Name = "pnlNavigation"
        pnlNavigation.Size = New Size(856, 63)
        pnlNavigation.TabIndex = 12
        ' 
        ' btnFeedback
        ' 
        btnFeedback.Font = New Font("Cambria", 12.0F)
        btnFeedback.Location = New Point(652, 12)
        btnFeedback.Name = "btnFeedback"
        btnFeedback.Size = New Size(101, 26)
        btnFeedback.TabIndex = 15
        btnFeedback.Text = "Feedback"
        btnFeedback.UseVisualStyleBackColor = True
        ' 
        ' btnAssets
        ' 
        btnAssets.Font = New Font("Cambria", 12.0F)
        btnAssets.Location = New Point(438, 12)
        btnAssets.Name = "btnAssets"
        btnAssets.Size = New Size(101, 26)
        btnAssets.TabIndex = 14
        btnAssets.Text = "Assets"
        btnAssets.UseVisualStyleBackColor = True
        ' 
        ' btnRenewal
        ' 
        btnRenewal.Font = New Font("Cambria", 12.0F)
        btnRenewal.Location = New Point(331, 12)
        btnRenewal.Name = "btnRenewal"
        btnRenewal.Size = New Size(101, 26)
        btnRenewal.TabIndex = 13
        btnRenewal.Text = "Renewal"
        btnRenewal.UseVisualStyleBackColor = True
        ' 
        ' btnContracts
        ' 
        btnContracts.Font = New Font("Cambria", 12.0F)
        btnContracts.Location = New Point(222, 12)
        btnContracts.Name = "btnContracts"
        btnContracts.Size = New Size(103, 26)
        btnContracts.TabIndex = 7
        btnContracts.Text = "Contracts"
        btnContracts.UseVisualStyleBackColor = True
        ' 
        ' btnHomepage
        ' 
        btnHomepage.Font = New Font("Cambria", 12.0F)
        btnHomepage.Location = New Point(8, 12)
        btnHomepage.Name = "btnHomepage"
        btnHomepage.Size = New Size(101, 26)
        btnHomepage.TabIndex = 1
        btnHomepage.Text = "Homepage"
        btnHomepage.UseVisualStyleBackColor = True
        ' 
        ' btnClients
        ' 
        btnClients.Font = New Font("Cambria", 12.0F)
        btnClients.Location = New Point(115, 12)
        btnClients.Name = "btnClients"
        btnClients.Size = New Size(101, 26)
        btnClients.TabIndex = 8
        btnClients.Text = "Clients"
        btnClients.UseVisualStyleBackColor = True
        ' 
        ' btnTickets
        ' 
        btnTickets.Font = New Font("Cambria", 12.0F)
        btnTickets.Location = New Point(545, 12)
        btnTickets.Name = "btnTickets"
        btnTickets.Size = New Size(101, 26)
        btnTickets.TabIndex = 9
        btnTickets.Text = "Tickets"
        btnTickets.UseVisualStyleBackColor = True
        ' 
        ' Navigation_Panel
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Transparent
        Controls.Add(pnlNavigation)
        Name = "Navigation_Panel"
        Size = New Size(856, 64)
        pnlNavigation.ResumeLayout(False)
        ResumeLayout(False)

    End Sub

    Friend WithEvents pnlNavigation As Panel
    Friend WithEvents btnContracts As Button
    Friend WithEvents btnHomepage As Button
    Friend WithEvents btnClients As Button
    Friend WithEvents btnTickets As Button
    Friend WithEvents btnRenewal As Button
    Friend WithEvents btnFeedback As Button
    Friend WithEvents btnAssets As Button
End Class