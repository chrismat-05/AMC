<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Reports
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
        Report_Type = New Label()
        btnGenerateReport = New Button()
        cmbReportType = New ComboBox()
        PictureBox1 = New PictureBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Report_Type
        ' 
        Report_Type.AutoSize = True
        Report_Type.Location = New Point(518, 212)
        Report_Type.Margin = New Padding(5, 0, 5, 0)
        Report_Type.Name = "Report_Type"
        Report_Type.Size = New Size(117, 23)
        Report_Type.TabIndex = 0
        Report_Type.Text = "Report Type"
        ' 
        ' btnGenerateReport
        ' 
        btnGenerateReport.Location = New Point(599, 432)
        btnGenerateReport.Margin = New Padding(5)
        btnGenerateReport.Name = "btnGenerateReport"
        btnGenerateReport.Size = New Size(171, 35)
        btnGenerateReport.TabIndex = 4
        btnGenerateReport.Text = "Generate Report"
        btnGenerateReport.UseVisualStyleBackColor = True
        ' 
        ' cmbReportType
        ' 
        cmbReportType.FormattingEnabled = True
        cmbReportType.Location = New Point(711, 208)
        cmbReportType.Margin = New Padding(5)
        cmbReportType.Name = "cmbReportType"
        cmbReportType.Size = New Size(188, 31)
        cmbReportType.TabIndex = 5
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
        ' Reports
        ' 
        AutoScaleDimensions = New SizeF(11F, 23F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.Form_backgrounds
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1257, 690)
        Controls.Add(PictureBox1)
        Controls.Add(cmbReportType)
        Controls.Add(btnGenerateReport)
        Controls.Add(Report_Type)
        DoubleBuffered = True
        Margin = New Padding(5)
        Name = "Reports"
        Text = "Reports"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Report_Type As Label
    Friend WithEvents btnGenerateReport As Button
    Friend WithEvents cmbReportType As ComboBox
    Friend WithEvents PictureBox1 As PictureBox
End Class
