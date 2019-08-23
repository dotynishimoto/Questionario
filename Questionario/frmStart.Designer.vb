<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStart
    Inherits System.Windows.Forms.Form

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
        Me.cmdStart = New System.Windows.Forms.Button()
        Me.lblQuestionarios = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cmdStart
        '
        Me.cmdStart.Location = New System.Drawing.Point(109, 81)
        Me.cmdStart.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cmdStart.Name = "cmdStart"
        Me.cmdStart.Size = New System.Drawing.Size(90, 41)
        Me.cmdStart.TabIndex = 0
        Me.cmdStart.Text = "Start"
        Me.cmdStart.UseVisualStyleBackColor = True
        '
        'lblQuestionarios
        '
        Me.lblQuestionarios.AutoSize = True
        Me.lblQuestionarios.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuestionarios.Location = New System.Drawing.Point(66, 17)
        Me.lblQuestionarios.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblQuestionarios.Name = "lblQuestionarios"
        Me.lblQuestionarios.Size = New System.Drawing.Size(159, 26)
        Me.lblQuestionarios.TabIndex = 1
        Me.lblQuestionarios.Text = "Questionarios"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 90)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'frmStart
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(275, 143)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lblQuestionarios)
        Me.Controls.Add(Me.cmdStart)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "frmStart"
        Me.Text = "frmStart"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmdStart As Button
    Friend WithEvents lblQuestionarios As Label
    Friend WithEvents Button1 As Button
End Class
