<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ClientManagement
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
        Client_Name = New Label()
        Email = New Label()
        Phone = New Label()
        Billing_Information = New Label()
        txtCompanyName = New TextBox()
        txtEmail = New TextBox()
        txtPhone = New TextBox()
        txtBillingInfo = New TextBox()
        btnAddClient = New Button()
        PictureBox1 = New PictureBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Client_Name
        ' 
        Client_Name.AutoSize = True
        Client_Name.Location = New Point(407, 204)
        Client_Name.Margin = New Padding(5, 0, 5, 0)
        Client_Name.Name = "Client_Name"
        Client_Name.Size = New Size(150, 23)
        Client_Name.TabIndex = 0
        Client_Name.Text = "Company Name"
        ' 
        ' Email
        ' 
        Email.AutoSize = True
        Email.Location = New Point(407, 249)
        Email.Margin = New Padding(5, 0, 5, 0)
        Email.Name = "Email"
        Email.Size = New Size(61, 23)
        Email.TabIndex = 1
        Email.Text = "Email"
        ' 
        ' Phone
        ' 
        Phone.AutoSize = True
        Phone.Location = New Point(407, 296)
        Phone.Margin = New Padding(5, 0, 5, 0)
        Phone.Name = "Phone"
        Phone.Size = New Size(63, 23)
        Phone.TabIndex = 2
        Phone.Text = "Phone"
        ' 
        ' Billing_Information
        ' 
        Billing_Information.AutoSize = True
        Billing_Information.Location = New Point(407, 347)
        Billing_Information.Margin = New Padding(5, 0, 5, 0)
        Billing_Information.Name = "Billing_Information"
        Billing_Information.Size = New Size(176, 23)
        Billing_Information.TabIndex = 3
        Billing_Information.Text = "Billing Information"
        ' 
        ' txtCompanyName
        ' 
        txtCompanyName.Location = New Point(680, 200)
        txtCompanyName.Margin = New Padding(5)
        txtCompanyName.Name = "txtCompanyName"
        txtCompanyName.Size = New Size(200, 29)
        txtCompanyName.TabIndex = 4
        ' 
        ' txtEmail
        ' 
        txtEmail.Location = New Point(680, 244)
        txtEmail.Margin = New Padding(5)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(200, 29)
        txtEmail.TabIndex = 5
        ' 
        ' txtPhone
        ' 
        txtPhone.Location = New Point(680, 292)
        txtPhone.Margin = New Padding(5)
        txtPhone.Name = "txtPhone"
        txtPhone.Size = New Size(200, 29)
        txtPhone.TabIndex = 6
        ' 
        ' txtBillingInfo
        ' 
        txtBillingInfo.Location = New Point(680, 342)
        txtBillingInfo.Margin = New Padding(5)
        txtBillingInfo.Name = "txtBillingInfo"
        txtBillingInfo.Size = New Size(200, 29)
        txtBillingInfo.TabIndex = 7
        ' 
        ' btnAddClient
        ' 
        btnAddClient.Location = New Point(580, 453)
        btnAddClient.Margin = New Padding(5)
        btnAddClient.Name = "btnAddClient"
        btnAddClient.Size = New Size(118, 35)
        btnAddClient.TabIndex = 8
        btnAddClient.Text = "Add Client"
        btnAddClient.UseVisualStyleBackColor = True
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImage = My.Resources.Resources.Exit_icon
        PictureBox1.BackgroundImageLayout = ImageLayout.Zoom
        PictureBox1.Location = New Point(1195, 12)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(50, 50)
        PictureBox1.TabIndex = 9
        PictureBox1.TabStop = False
        ' 
        ' ClientManagement
        ' 
        AutoScaleDimensions = New SizeF(11.0F, 23.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.Form_backgrounds
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1257, 690)
        Controls.Add(PictureBox1)
        Controls.Add(btnAddClient)
        Controls.Add(txtBillingInfo)
        Controls.Add(txtPhone)
        Controls.Add(txtEmail)
        Controls.Add(txtCompanyName)
        Controls.Add(Billing_Information)
        Controls.Add(Phone)
        Controls.Add(Email)
        Controls.Add(Client_Name)
        DoubleBuffered = True
        Margin = New Padding(5)
        Name = "ClientManagement"
        Text = "ClientManagement"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Client_Name As Label
    Friend WithEvents Email As Label
    Friend WithEvents Phone As Label
    Friend WithEvents Billing_Information As Label
    Friend WithEvents txtCompanyName As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents txtBillingInfo As TextBox
    Friend WithEvents btnAddClient As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
