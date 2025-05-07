<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ServiceRequest
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
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        txtIssueDescription = New TextBox()
        cmbContract = New ComboBox()
        cmbClientName = New ComboBox()
        dtpDateLogged = New DateTimePicker()
        btnCreateRequest = New Button()
        PictureBox1 = New PictureBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(379, 190)
        Label1.Margin = New Padding(5, 0, 5, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(117, 23)
        Label1.TabIndex = 0
        Label1.Text = "Client Name"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(379, 241)
        Label2.Margin = New Padding(5, 0, 5, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(86, 23)
        Label2.TabIndex = 1
        Label2.Text = "Contract"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(379, 296)
        Label3.Margin = New Padding(5, 0, 5, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(165, 23)
        Label3.TabIndex = 2
        Label3.Text = "Issue_Description"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(379, 356)
        Label4.Margin = New Padding(5, 0, 5, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(126, 23)
        Label4.TabIndex = 3
        Label4.Text = "Date_Logged"
        ' 
        ' txtIssueDescription
        ' 
        txtIssueDescription.Location = New Point(604, 291)
        txtIssueDescription.Margin = New Padding(5)
        txtIssueDescription.Name = "txtIssueDescription"
        txtIssueDescription.Size = New Size(310, 29)
        txtIssueDescription.TabIndex = 6
        ' 
        ' cmbContract
        ' 
        cmbContract.FormattingEnabled = True
        cmbContract.Location = New Point(604, 236)
        cmbContract.Margin = New Padding(5)
        cmbContract.Name = "cmbContract"
        cmbContract.Size = New Size(310, 31)
        cmbContract.TabIndex = 7
        ' 
        ' cmbClientName
        ' 
        cmbClientName.FormattingEnabled = True
        cmbClientName.Location = New Point(604, 186)
        cmbClientName.Margin = New Padding(5)
        cmbClientName.Name = "cmbClientName"
        cmbClientName.Size = New Size(310, 31)
        cmbClientName.TabIndex = 8
        ' 
        ' dtpDateLogged
        ' 
        dtpDateLogged.Location = New Point(602, 347)
        dtpDateLogged.Margin = New Padding(5)
        dtpDateLogged.Name = "dtpDateLogged"
        dtpDateLogged.Size = New Size(312, 29)
        dtpDateLogged.TabIndex = 11
        ' 
        ' btnCreateRequest
        ' 
        btnCreateRequest.Location = New Point(571, 472)
        btnCreateRequest.Margin = New Padding(5)
        btnCreateRequest.Name = "btnCreateRequest"
        btnCreateRequest.Size = New Size(179, 35)
        btnCreateRequest.TabIndex = 13
        btnCreateRequest.Text = "Create Request"
        btnCreateRequest.TextAlign = ContentAlignment.MiddleRight
        btnCreateRequest.UseVisualStyleBackColor = True
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImage = My.Resources.Resources.Exit_icon
        PictureBox1.BackgroundImageLayout = ImageLayout.Zoom
        PictureBox1.Location = New Point(1195, 12)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(50, 50)
        PictureBox1.TabIndex = 14
        PictureBox1.TabStop = False
        ' 
        ' ServiceRequest
        ' 
        AutoScaleDimensions = New SizeF(11.0F, 23.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.Form_backgrounds
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1257, 690)
        Controls.Add(PictureBox1)
        Controls.Add(btnCreateRequest)
        Controls.Add(dtpDateLogged)
        Controls.Add(cmbClientName)
        Controls.Add(cmbContract)
        Controls.Add(txtIssueDescription)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        DoubleBuffered = True
        Margin = New Padding(5)
        Name = "ServiceRequest"
        Text = "ServiceRequest"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtIssueDescription As TextBox
    Friend WithEvents cmbContract As ComboBox
    Friend WithEvents cmbClientName As ComboBox
    Friend WithEvents dtpDateLogged As DateTimePicker
    Friend WithEvents btnCreateRequest As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
