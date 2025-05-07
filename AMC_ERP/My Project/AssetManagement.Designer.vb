<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AssetManagement
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
        Asset_Type = New Label()
        Serial = New Label()
        Purchase_Date = New Label()
        Warranty_End_Date = New Label()
        Linked_Contract = New Label()
        txtSerialNumber = New TextBox()
        cmbAssetType = New ComboBox()
        dtpPurchaseDate = New DateTimePicker()
        dtpWarrantyEndDate = New DateTimePicker()
        btnAddAsset = New Button()
        cmbLinkedContract = New ComboBox()
        PictureBox1 = New PictureBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Asset_Type
        ' 
        Asset_Type.AutoSize = True
        Asset_Type.BackColor = Color.Transparent
        Asset_Type.Location = New Point(360, 184)
        Asset_Type.Margin = New Padding(5, 0, 5, 0)
        Asset_Type.Name = "Asset_Type"
        Asset_Type.Size = New Size(103, 23)
        Asset_Type.TabIndex = 0
        Asset_Type.Text = "Asset Type"
        ' 
        ' Serial
        ' 
        Serial.AutoSize = True
        Serial.Location = New Point(360, 245)
        Serial.Margin = New Padding(5, 0, 5, 0)
        Serial.Name = "Serial"
        Serial.Size = New Size(134, 23)
        Serial.TabIndex = 1
        Serial.Text = "Serial number"
        ' 
        ' Purchase_Date
        ' 
        Purchase_Date.AutoSize = True
        Purchase_Date.Location = New Point(360, 323)
        Purchase_Date.Margin = New Padding(5, 0, 5, 0)
        Purchase_Date.Name = "Purchase_Date"
        Purchase_Date.Size = New Size(136, 23)
        Purchase_Date.TabIndex = 2
        Purchase_Date.Text = "Purchase Date"
        ' 
        ' Warranty_End_Date
        ' 
        Warranty_End_Date.AutoSize = True
        Warranty_End_Date.Location = New Point(360, 401)
        Warranty_End_Date.Margin = New Padding(5, 0, 5, 0)
        Warranty_End_Date.Name = "Warranty_End_Date"
        Warranty_End_Date.Size = New Size(183, 23)
        Warranty_End_Date.TabIndex = 3
        Warranty_End_Date.Text = "Warranty End Date"
        ' 
        ' Linked_Contract
        ' 
        Linked_Contract.AutoSize = True
        Linked_Contract.Location = New Point(360, 125)
        Linked_Contract.Margin = New Padding(5, 0, 5, 0)
        Linked_Contract.Name = "Linked_Contract"
        Linked_Contract.Size = New Size(149, 23)
        Linked_Contract.TabIndex = 4
        Linked_Contract.Text = "Linked Contract"
        ' 
        ' txtSerialNumber
        ' 
        txtSerialNumber.Location = New Point(624, 240)
        txtSerialNumber.Margin = New Padding(5)
        txtSerialNumber.Name = "txtSerialNumber"
        txtSerialNumber.Size = New Size(312, 29)
        txtSerialNumber.TabIndex = 5
        ' 
        ' cmbAssetType
        ' 
        cmbAssetType.FormattingEnabled = True
        cmbAssetType.Items.AddRange(New Object() {"Monitors", "CPU's", "Laptops", "Power Backups", "Computer Accessories", "Laptops", "Projectors", "Smart Boards", "Lifts", "Security System", "Motion Sensers", "Vertical TV Displays", "Horizontal TV Displays"})
        cmbAssetType.Location = New Point(624, 179)
        cmbAssetType.Margin = New Padding(5)
        cmbAssetType.Name = "cmbAssetType"
        cmbAssetType.Size = New Size(312, 31)
        cmbAssetType.TabIndex = 6
        ' 
        ' dtpPurchaseDate
        ' 
        dtpPurchaseDate.Location = New Point(624, 314)
        dtpPurchaseDate.Margin = New Padding(5)
        dtpPurchaseDate.Name = "dtpPurchaseDate"
        dtpPurchaseDate.Size = New Size(312, 29)
        dtpPurchaseDate.TabIndex = 8
        ' 
        ' dtpWarrantyEndDate
        ' 
        dtpWarrantyEndDate.Location = New Point(624, 392)
        dtpWarrantyEndDate.Margin = New Padding(5)
        dtpWarrantyEndDate.Name = "dtpWarrantyEndDate"
        dtpWarrantyEndDate.Size = New Size(312, 29)
        dtpWarrantyEndDate.TabIndex = 9
        ' 
        ' btnAddAsset
        ' 
        btnAddAsset.Location = New Point(565, 588)
        btnAddAsset.Margin = New Padding(5)
        btnAddAsset.Name = "btnAddAsset"
        btnAddAsset.Size = New Size(185, 35)
        btnAddAsset.TabIndex = 10
        btnAddAsset.Text = "Add Asset"
        btnAddAsset.UseVisualStyleBackColor = True
        ' 
        ' cmbLinkedContract
        ' 
        cmbLinkedContract.FormattingEnabled = True
        cmbLinkedContract.Location = New Point(624, 121)
        cmbLinkedContract.Margin = New Padding(5)
        cmbLinkedContract.Name = "cmbLinkedContract"
        cmbLinkedContract.Size = New Size(312, 31)
        cmbLinkedContract.TabIndex = 11
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.BackgroundImage = My.Resources.Resources.Exit_icon
        PictureBox1.BackgroundImageLayout = ImageLayout.Zoom
        PictureBox1.Location = New Point(1195, 12)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(50, 50)
        PictureBox1.TabIndex = 12
        PictureBox1.TabStop = False
        ' 
        ' AssetManagement
        ' 
        AutoScaleDimensions = New SizeF(11.0F, 23.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.Form_backgrounds
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1257, 690)
        Controls.Add(PictureBox1)
        Controls.Add(cmbLinkedContract)
        Controls.Add(btnAddAsset)
        Controls.Add(dtpWarrantyEndDate)
        Controls.Add(dtpPurchaseDate)
        Controls.Add(cmbAssetType)
        Controls.Add(txtSerialNumber)
        Controls.Add(Linked_Contract)
        Controls.Add(Warranty_End_Date)
        Controls.Add(Purchase_Date)
        Controls.Add(Serial)
        Controls.Add(Asset_Type)
        DoubleBuffered = True
        Margin = New Padding(5)
        Name = "AssetManagement"
        Text = "AssetManagement"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Asset_Type As Label
    Friend WithEvents Serial As Label
    Friend WithEvents Purchase_Date As Label
    Friend WithEvents Warranty_End_Date As Label
    Friend WithEvents Linked_Contract As Label
    Friend WithEvents txtSerialNumber As TextBox
    Friend WithEvents cmbAssetType As ComboBox
    Friend WithEvents dtpPurchaseDate As DateTimePicker
    Friend WithEvents dtpWarrantyEndDate As DateTimePicker
    Friend WithEvents btnAddAsset As Button
    Friend WithEvents cmbLinkedContract As ComboBox
    Friend WithEvents PictureBox1 As PictureBox
End Class
