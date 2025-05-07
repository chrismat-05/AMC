Imports System.Drawing
Imports System.Windows.Forms

Public Class BaseForm
    Inherits Form

    Public Sub New()
        ' Set background and form-wide properties
        Me.BackColor = Color.Snow  ' Clean, white background
        Me.Font = New Font("Georgia", 14, FontStyle.Italic)
        Me.ForeColor = Color.Black

        ' Set a common icon for all forms
        Try
            Me.Icon = New Icon("C:\Users\chris\Documents\AMC_ERP\AMC_ERP\Resources\CMA's AMC ERP.ico")
        Catch ex As Exception
            MessageBox.Show("Unable to load form icon: " & ex.Message)
        End Try

        AddHandler Me.Load, AddressOf ApplyThemeToAllControls
    End Sub

    Private Sub ApplyThemeToAllControls(sender As Object, e As EventArgs)
        ApplyStyles(Me.Controls)
    End Sub

    Private Sub ApplyStyles(controls As Control.ControlCollection)
        For Each ctrl As Control In controls
            ' Apply font to all controls (default style)
            ctrl.Font = Me.Font

            ' Handle Navigation_Panel specially
            If TypeOf ctrl Is Navigation_Panel Then
                For Each inner As Control In ctrl.Controls
                    If TypeOf inner Is Panel Then
                        For Each navBtn In inner.Controls
                            If TypeOf navBtn Is Button Then
                                DirectCast(navBtn, Button).Font = New Font("Georgia", 8, FontStyle.Italic)
                            End If
                        Next
                    End If
                Next
                Continue For
            End If

            ' Apply styles for specific control types
            If TypeOf ctrl Is TextBox Then
                Dim tb As TextBox = DirectCast(ctrl, TextBox)
                tb.BackColor = SystemColors.InactiveCaption
                tb.ForeColor = Color.Black
                tb.BorderStyle = BorderStyle.FixedSingle

            ElseIf TypeOf ctrl Is Button Then
                Dim btn As Button = DirectCast(ctrl, Button)
                btn.BackColor = Color.Black
                btn.ForeColor = Color.White
                btn.FlatStyle = FlatStyle.Flat
                btn.FlatAppearance.BorderColor = Color.Red
                btn.FlatAppearance.BorderSize = 1
                btn.Cursor = Cursors.Hand

            ElseIf TypeOf ctrl Is Label Then
                Dim lbl As Label = DirectCast(ctrl, Label)
                lbl.ForeColor = Color.White
                lbl.BackColor = Color.Transparent

            ElseIf TypeOf ctrl Is LinkLabel Then
                Dim link As LinkLabel = DirectCast(ctrl, LinkLabel)
                link.ForeColor = Color.White
                link.LinkColor = Color.White
                link.ActiveLinkColor = Color.Red
                link.VisitedLinkColor = Color.Gray
            End If

            ' Recurse into child controls
            If ctrl.HasChildren Then
                ApplyStyles(ctrl.Controls)
            End If
        Next
    End Sub
End Class