<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class HomePage
    Inherits BaseForm

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        PictureBox1 = New PictureBox()
        lblContractsCount = New Label()
        lblClientsCount = New Label()
        lblAssetsCount = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImage = My.Resources.Resources.Exit_icon
        PictureBox1.BackgroundImageLayout = ImageLayout.Zoom
        PictureBox1.Location = New Point(1323, 12)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(50, 50)
        PictureBox1.TabIndex = 9
        PictureBox1.TabStop = False
        ' 
        ' lblContractsCount
        ' 
        lblContractsCount.AutoSize = True
        lblContractsCount.Location = New Point(659, 428)
        lblContractsCount.Name = "lblContractsCount"
        lblContractsCount.Size = New Size(65, 23)
        lblContractsCount.TabIndex = 10
        lblContractsCount.Text = "Label1"
        ' 
        ' lblClientsCount
        ' 
        lblClientsCount.AutoSize = True
        lblClientsCount.Location = New Point(281, 428)
        lblClientsCount.Name = "lblClientsCount"
        lblClientsCount.Size = New Size(65, 23)
        lblClientsCount.TabIndex = 11
        lblClientsCount.Text = "Label1"
        ' 
        ' lblAssetsCount
        ' 
        lblAssetsCount.AutoSize = True
        lblAssetsCount.Location = New Point(1075, 428)
        lblAssetsCount.Name = "lblAssetsCount"
        lblAssetsCount.Size = New Size(65, 23)
        lblAssetsCount.TabIndex = 12
        lblAssetsCount.Text = "Label1"
        ' 
        ' HomePage
        ' 
        AccessibleRole = AccessibleRole.None
        AutoScaleDimensions = New SizeF(11.0F, 23.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.Homepage
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1385, 598)
        Controls.Add(lblAssetsCount)
        Controls.Add(lblClientsCount)
        Controls.Add(lblContractsCount)
        Controls.Add(PictureBox1)
        DoubleBuffered = True
        Margin = New Padding(5)
        Name = "HomePage"
        Text = "Homepage"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblContractsCount As Label
    Friend WithEvents lblClientsCount As Label
    Friend WithEvents lblAssetsCount As Label
End Class
