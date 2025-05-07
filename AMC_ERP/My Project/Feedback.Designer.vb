<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Feedback
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

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim lblFeedback As Label
        Client = New Label()
        Rating = New Label()
        numRating = New NumericUpDown()
        txtClient = New TextBox()
        txtFeedback = New TextBox()
        btnSubmitFeedback = New Button()
        PictureBox1 = New PictureBox()
        lblFeedback = New Label()
        CType(numRating, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblFeedback
        ' 
        lblFeedback.AutoSize = True
        lblFeedback.Location = New Point(404, 303)
        lblFeedback.Margin = New Padding(5, 0, 5, 0)
        lblFeedback.Name = "lblFeedback"
        lblFeedback.Size = New Size(205, 23)
        lblFeedback.TabIndex = 1
        lblFeedback.Text = "Feedback / Suggestion"
        ' 
        ' Client
        ' 
        Client.AutoSize = True
        Client.Location = New Point(404, 225)
        Client.Margin = New Padding(5, 0, 5, 0)
        Client.Name = "Client"
        Client.Size = New Size(153, 23)
        Client.TabIndex = 0
        Client.Text = "Client Username"
        ' 
        ' Rating
        ' 
        Rating.AutoSize = True
        Rating.Location = New Point(404, 386)
        Rating.Margin = New Padding(5, 0, 5, 0)
        Rating.Name = "Rating"
        Rating.Size = New Size(69, 23)
        Rating.TabIndex = 2
        Rating.Text = "Rating"
        ' 
        ' numRating
        ' 
        numRating.Location = New Point(674, 389)
        numRating.Margin = New Padding(5)
        numRating.Maximum = New Decimal(New Integer() {5, 0, 0, 0})
        numRating.Name = "numRating"
        numRating.Size = New Size(189, 29)
        numRating.TabIndex = 4
        ' 
        ' txtClient
        ' 
        txtClient.Location = New Point(674, 220)
        txtClient.Margin = New Padding(5)
        txtClient.Name = "txtClient"
        txtClient.Size = New Size(186, 29)
        txtClient.TabIndex = 5
        ' 
        ' txtFeedback
        ' 
        txtFeedback.Location = New Point(674, 298)
        txtFeedback.Margin = New Padding(5)
        txtFeedback.Name = "txtFeedback"
        txtFeedback.Size = New Size(186, 29)
        txtFeedback.TabIndex = 6
        ' 
        ' btnSubmitFeedback
        ' 
        btnSubmitFeedback.Location = New Point(542, 507)
        btnSubmitFeedback.Margin = New Padding(5)
        btnSubmitFeedback.Name = "btnSubmitFeedback"
        btnSubmitFeedback.Size = New Size(200, 35)
        btnSubmitFeedback.TabIndex = 7
        btnSubmitFeedback.Text = "Submit Feedback"
        btnSubmitFeedback.UseVisualStyleBackColor = True
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
        ' Feedback
        ' 
        AutoScaleDimensions = New SizeF(11.0F, 23.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.Form_backgrounds
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1257, 690)
        Controls.Add(PictureBox1)
        Controls.Add(btnSubmitFeedback)
        Controls.Add(txtFeedback)
        Controls.Add(txtClient)
        Controls.Add(numRating)
        Controls.Add(Rating)
        Controls.Add(lblFeedback)
        Controls.Add(Client)
        DoubleBuffered = True
        Margin = New Padding(5)
        Name = "Feedback"
        Text = "Feedback"
        CType(numRating, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Client As Label
    Friend WithEvents Rating As Label
    Friend WithEvents numRating As NumericUpDown
    Friend WithEvents txtClient As TextBox
    Friend WithEvents txtFeedback As TextBox
    Friend WithEvents btnSubmitFeedback As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
