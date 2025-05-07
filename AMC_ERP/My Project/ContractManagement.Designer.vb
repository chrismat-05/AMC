<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ContractManagement
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
        Contract_Duration = New Label()
        Scope = New Label()
        Pricing = New Label()
        Start_Date = New Label()
        End_Date = New Label()
        txtScope = New TextBox()
        txtPricing = New TextBox()
        cmbClientName = New ComboBox()
        dtpStartDate = New DateTimePicker()
        dtpEndDate = New DateTimePicker()
        txtDuration = New TextBox()
        OpenFileDialog1 = New OpenFileDialog()
        btnCreateContract = New Button()
        btnAttachDocument = New Button()
        PictureBox1 = New PictureBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Client_Name
        ' 
        Client_Name.AutoSize = True
        Client_Name.Location = New Point(379, 129)
        Client_Name.Margin = New Padding(5, 0, 5, 0)
        Client_Name.Name = "Client_Name"
        Client_Name.Size = New Size(117, 23)
        Client_Name.TabIndex = 0
        Client_Name.Text = "Client Name"
        ' 
        ' Contract_Duration
        ' 
        Contract_Duration.AutoSize = True
        Contract_Duration.Location = New Point(379, 186)
        Contract_Duration.Margin = New Padding(5, 0, 5, 0)
        Contract_Duration.Name = "Contract_Duration"
        Contract_Duration.Size = New Size(170, 23)
        Contract_Duration.TabIndex = 1
        Contract_Duration.Text = "Contract Duration"
        ' 
        ' Scope
        ' 
        Scope.AutoSize = True
        Scope.Location = New Point(379, 249)
        Scope.Margin = New Padding(5, 0, 5, 0)
        Scope.Name = "Scope"
        Scope.Size = New Size(60, 23)
        Scope.TabIndex = 2
        Scope.Text = "Scope"
        ' 
        ' Pricing
        ' 
        Pricing.AutoSize = True
        Pricing.Location = New Point(379, 310)
        Pricing.Margin = New Padding(5, 0, 5, 0)
        Pricing.Name = "Pricing"
        Pricing.Size = New Size(74, 23)
        Pricing.TabIndex = 3
        Pricing.Text = "Pricing"
        ' 
        ' Start_Date
        ' 
        Start_Date.AutoSize = True
        Start_Date.Location = New Point(379, 367)
        Start_Date.Margin = New Padding(5, 0, 5, 0)
        Start_Date.Name = "Start_Date"
        Start_Date.Size = New Size(108, 23)
        Start_Date.TabIndex = 4
        Start_Date.Text = "Start_Date"
        ' 
        ' End_Date
        ' 
        End_Date.AutoSize = True
        End_Date.Location = New Point(379, 427)
        End_Date.Margin = New Padding(5, 0, 5, 0)
        End_Date.Name = "End_Date"
        End_Date.Size = New Size(97, 23)
        End_Date.TabIndex = 5
        End_Date.Text = "End_Date"
        ' 
        ' txtScope
        ' 
        txtScope.Location = New Point(614, 236)
        txtScope.Margin = New Padding(5)
        txtScope.Name = "txtScope"
        txtScope.Size = New Size(312, 29)
        txtScope.TabIndex = 7
        ' 
        ' txtPricing
        ' 
        txtPricing.Location = New Point(614, 305)
        txtPricing.Margin = New Padding(5)
        txtPricing.Name = "txtPricing"
        txtPricing.Size = New Size(312, 29)
        txtPricing.TabIndex = 8
        ' 
        ' cmbClientName
        ' 
        cmbClientName.FormattingEnabled = True
        cmbClientName.Location = New Point(614, 125)
        cmbClientName.Margin = New Padding(5)
        cmbClientName.Name = "cmbClientName"
        cmbClientName.Size = New Size(312, 31)
        cmbClientName.TabIndex = 9
        ' 
        ' dtpStartDate
        ' 
        dtpStartDate.Location = New Point(614, 358)
        dtpStartDate.Margin = New Padding(5)
        dtpStartDate.Name = "dtpStartDate"
        dtpStartDate.Size = New Size(312, 29)
        dtpStartDate.TabIndex = 10
        ' 
        ' dtpEndDate
        ' 
        dtpEndDate.Location = New Point(614, 417)
        dtpEndDate.Margin = New Padding(5)
        dtpEndDate.Name = "dtpEndDate"
        dtpEndDate.Size = New Size(312, 29)
        dtpEndDate.TabIndex = 11
        ' 
        ' txtDuration
        ' 
        txtDuration.Location = New Point(614, 181)
        txtDuration.Margin = New Padding(5)
        txtDuration.Name = "txtDuration"
        txtDuration.Size = New Size(312, 29)
        txtDuration.TabIndex = 12
        ' 
        ' OpenFileDialog1
        ' 
        OpenFileDialog1.FileName = "OpenFileDialog1"
        ' 
        ' btnCreateContract
        ' 
        btnCreateContract.Location = New Point(379, 514)
        btnCreateContract.Margin = New Padding(5)
        btnCreateContract.Name = "btnCreateContract"
        btnCreateContract.Size = New Size(192, 35)
        btnCreateContract.TabIndex = 13
        btnCreateContract.Text = "Create Contract"
        btnCreateContract.UseVisualStyleBackColor = True
        ' 
        ' btnAttachDocument
        ' 
        btnAttachDocument.Location = New Point(687, 514)
        btnAttachDocument.Margin = New Padding(5)
        btnAttachDocument.Name = "btnAttachDocument"
        btnAttachDocument.Size = New Size(239, 35)
        btnAttachDocument.TabIndex = 16
        btnAttachDocument.Text = "Attach Document"
        btnAttachDocument.UseVisualStyleBackColor = True
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImage = My.Resources.Resources.Exit_icon
        PictureBox1.BackgroundImageLayout = ImageLayout.Zoom
        PictureBox1.Location = New Point(1195, 12)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(50, 50)
        PictureBox1.TabIndex = 17
        PictureBox1.TabStop = False
        ' 
        ' ContractManagement
        ' 
        AutoScaleDimensions = New SizeF(11.0F, 23.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.Form_backgrounds
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1257, 690)
        Controls.Add(PictureBox1)
        Controls.Add(btnAttachDocument)
        Controls.Add(btnCreateContract)
        Controls.Add(txtDuration)
        Controls.Add(dtpEndDate)
        Controls.Add(dtpStartDate)
        Controls.Add(cmbClientName)
        Controls.Add(txtPricing)
        Controls.Add(txtScope)
        Controls.Add(End_Date)
        Controls.Add(Start_Date)
        Controls.Add(Pricing)
        Controls.Add(Scope)
        Controls.Add(Contract_Duration)
        Controls.Add(Client_Name)
        DoubleBuffered = True
        Margin = New Padding(5)
        Name = "ContractManagement"
        Text = "ContractManagement"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Client_Name As Label
    Friend WithEvents Contract_Duration As Label
    Friend WithEvents Scope As Label
    Friend WithEvents Pricing As Label
    Friend WithEvents Start_Date As Label
    Friend WithEvents End_Date As Label
    Friend WithEvents txtScope As TextBox
    Friend WithEvents txtPricing As TextBox
    Friend WithEvents cmbClientName As ComboBox
    Friend WithEvents dtpStartDate As DateTimePicker
    Friend WithEvents dtpEndDate As DateTimePicker
    Friend WithEvents txtDuration As TextBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents btnCreateContract As Button
    Friend WithEvents btnAttachDocument As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
