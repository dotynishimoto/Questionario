<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucSaySomething
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.lblCaption = New System.Windows.Forms.Label()
        Me.TextBox = New System.Windows.Forms.TextBox()
        Me.lblSay = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblCaption
        '
        Me.lblCaption.AutoSize = True
        Me.lblCaption.Location = New System.Drawing.Point(82, 3)
        Me.lblCaption.Name = "lblCaption"
        Me.lblCaption.Size = New System.Drawing.Size(70, 17)
        Me.lblCaption.TabIndex = 0
        Me.lblCaption.Text = "lblCaption"
        '
        'TextBox
        '
        Me.TextBox.Location = New System.Drawing.Point(158, 3)
        Me.TextBox.Name = "TextBox"
        Me.TextBox.Size = New System.Drawing.Size(100, 22)
        Me.TextBox.TabIndex = 1
        '
        'lblSay
        '
        Me.lblSay.AutoSize = True
        Me.lblSay.Location = New System.Drawing.Point(264, 6)
        Me.lblSay.Name = "lblSay"
        Me.lblSay.Size = New System.Drawing.Size(46, 17)
        Me.lblSay.TabIndex = 2
        Me.lblSay.Text = "lblSay"
        '
        'ucSaySomething
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.lblSay)
        Me.Controls.Add(Me.TextBox)
        Me.Controls.Add(Me.lblCaption)
        Me.Name = "ucSaySomething"
        Me.Size = New System.Drawing.Size(433, 28)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblCaption As Label
    Friend WithEvents TextBox As TextBox
    Friend WithEvents lblSay As Label
End Class
