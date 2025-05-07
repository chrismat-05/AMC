<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RenewalManagement
    Inherits BaseForm
    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Contract = New Label()
        Client = New Label()
        Renewal_Date = New Label()
        cmbContract = New ComboBox()
        cmbClient = New ComboBox()
        dtpRenewalDate = New DateTimePicker()
        btnRenewContract = New Button()
        PictureBox1 = New PictureBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Contract
        ' 
        Contract.AutoSize = True
        Contract.Location = New Point(484, 234)
        Contract.Margin = New Padding(5, 0, 5, 0)
        Contract.Name = "Contract"
        Contract.Size = New Size(86, 23)
        Contract.TabIndex = 0
        Contract.Text = "Contract"
        ' 
        ' Client
        ' 
        Client.AutoSize = True
        Client.Location = New Point(484, 165)
        Client.Margin = New Padding(5, 0, 5, 0)
        Client.Name = "Client"
        Client.Size = New Size(60, 23)
        Client.TabIndex = 1
        Client.Text = "Client"
        ' 
        ' Renewal_Date
        ' 
        Renewal_Date.AutoSize = True
        Renewal_Date.Location = New Point(484, 307)
        Renewal_Date.Margin = New Padding(5, 0, 5, 0)
        Renewal_Date.Name = "Renewal_Date"
        Renewal_Date.Size = New Size(130, 23)
        Renewal_Date.TabIndex = 2
        Renewal_Date.Text = "Renewal Date"
        ' 
        ' cmbContract
        ' 
        cmbContract.FormattingEnabled = True
        cmbContract.Location = New Point(699, 230)
        cmbContract.Margin = New Padding(5)
        cmbContract.Name = "cmbContract"
        cmbContract.Size = New Size(312, 31)
        cmbContract.TabIndex = 4
        ' 
        ' cmbClient
        ' 
        cmbClient.FormattingEnabled = True
        cmbClient.Location = New Point(699, 161)
        cmbClient.Margin = New Padding(5)
        cmbClient.Name = "cmbClient"
        cmbClient.Size = New Size(312, 31)
        cmbClient.TabIndex = 5
        ' 
        ' dtpRenewalDate
        ' 
        dtpRenewalDate.Location = New Point(699, 307)
        dtpRenewalDate.Margin = New Padding(5)
        dtpRenewalDate.Name = "dtpRenewalDate"
        dtpRenewalDate.Size = New Size(312, 29)
        dtpRenewalDate.TabIndex = 6
        ' 
        ' btnRenewContract
        ' 
        btnRenewContract.Location = New Point(597, 442)
        btnRenewContract.Margin = New Padding(5)
        btnRenewContract.Name = "btnRenewContract"
        btnRenewContract.Size = New Size(181, 35)
        btnRenewContract.TabIndex = 7
        btnRenewContract.Text = "Apply for renewal"
        btnRenewContract.UseVisualStyleBackColor = True
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImage = My.Resources.Resources.Exit_icon
        PictureBox1.BackgroundImageLayout = ImageLayout.Zoom
        PictureBox1.Location = New Point(1195, 12)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(50, 50)
        PictureBox1.TabIndex = 10
        PictureBox1.TabStop = False
        ' 
        ' RenewalManagement
        ' 
        AutoScaleDimensions = New SizeF(11.0F, 23.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.Form_backgrounds
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1257, 690)
        Controls.Add(PictureBox1)
        Controls.Add(btnRenewContract)
        Controls.Add(dtpRenewalDate)
        Controls.Add(cmbClient)
        Controls.Add(cmbContract)
        Controls.Add(Renewal_Date)
        Controls.Add(Client)
        Controls.Add(Contract)
        DoubleBuffered = True
        Margin = New Padding(5)
        Name = "RenewalManagement"
        Text = "RenewalManagement"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Contract As Label
    Friend WithEvents Client As Label
    Friend WithEvents Renewal_Date As Label
    Friend WithEvents cmbContract As ComboBox
    Friend WithEvents cmbClient As ComboBox
    Friend WithEvents dtpRenewalDate As DateTimePicker
    Friend WithEvents btnRenewContract As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
