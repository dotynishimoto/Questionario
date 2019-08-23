<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReportCreator
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
        Me.NumUpRow = New System.Windows.Forms.NumericUpDown()
        Me.cmdOk = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.numUpColumn = New System.Windows.Forms.NumericUpDown()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.NumUpRow, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numUpColumn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NumUpRow
        '
        Me.NumUpRow.Location = New System.Drawing.Point(434, 11)
        Me.NumUpRow.Margin = New System.Windows.Forms.Padding(2)
        Me.NumUpRow.Name = "NumUpRow"
        Me.NumUpRow.Size = New System.Drawing.Size(52, 20)
        Me.NumUpRow.TabIndex = 0
        '
        'cmdOk
        '
        Me.cmdOk.Location = New System.Drawing.Point(370, 285)
        Me.cmdOk.Name = "cmdOk"
        Me.cmdOk.Size = New System.Drawing.Size(75, 23)
        Me.cmdOk.TabIndex = 1
        Me.cmdOk.Text = "Ok"
        Me.cmdOk.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(397, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 15)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Row"
        '
        'numUpColumn
        '
        Me.numUpColumn.Location = New System.Drawing.Point(434, 35)
        Me.numUpColumn.Margin = New System.Windows.Forms.Padding(2)
        Me.numUpColumn.Name = "numUpColumn"
        Me.numUpColumn.Size = New System.Drawing.Size(52, 20)
        Me.numUpColumn.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(379, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 15)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Column"
        '
        'frmReportCreator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(535, 334)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.numUpColumn)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmdOk)
        Me.Controls.Add(Me.NumUpRow)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frmReportCreator"
        Me.Text = "g"
        CType(Me.NumUpRow, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numUpColumn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents NumUpRow As NumericUpDown
    Friend WithEvents cmdOk As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents numUpColumn As NumericUpDown
    Friend WithEvents Label2 As Label
End Class
