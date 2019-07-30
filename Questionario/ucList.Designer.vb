<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ucList
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.grid1 = New System.Windows.Forms.DataGridView()
        Me.comboCampo = New System.Windows.Forms.ComboBox()
        Me.lblCaption = New System.Windows.Forms.Label()
        Me.lblOperador = New System.Windows.Forms.Label()
        Me.comboOperador = New System.Windows.Forms.ComboBox()
        Me.lblVal = New System.Windows.Forms.Label()
        Me.txtVal = New System.Windows.Forms.TextBox()
        Me.cmdFilter = New System.Windows.Forms.Button()
        Me.cmdPrepall = New System.Windows.Forms.Button()
        Me.lblSay = New System.Windows.Forms.Label()
        CType(Me.grid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grid1
        '
        Me.grid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grid1.Location = New System.Drawing.Point(3, 3)
        Me.grid1.Name = "grid1"
        Me.grid1.RowTemplate.Height = 24
        Me.grid1.Size = New System.Drawing.Size(360, 169)
        Me.grid1.TabIndex = 0
        '
        'comboCampo
        '
        Me.comboCampo.FormattingEnabled = True
        Me.comboCampo.Location = New System.Drawing.Point(451, 12)
        Me.comboCampo.Name = "comboCampo"
        Me.comboCampo.Size = New System.Drawing.Size(121, 24)
        Me.comboCampo.TabIndex = 1
        '
        'lblCaption
        '
        Me.lblCaption.AutoSize = True
        Me.lblCaption.Location = New System.Drawing.Point(380, 15)
        Me.lblCaption.Name = "lblCaption"
        Me.lblCaption.Size = New System.Drawing.Size(56, 17)
        Me.lblCaption.TabIndex = 2
        Me.lblCaption.Text = "Campo:"
        '
        'lblOperador
        '
        Me.lblOperador.AutoSize = True
        Me.lblOperador.Location = New System.Drawing.Point(363, 52)
        Me.lblOperador.Name = "lblOperador"
        Me.lblOperador.Size = New System.Drawing.Size(73, 17)
        Me.lblOperador.TabIndex = 3
        Me.lblOperador.Text = "Operador:"
        '
        'comboOperador
        '
        Me.comboOperador.FormattingEnabled = True
        Me.comboOperador.Location = New System.Drawing.Point(451, 49)
        Me.comboOperador.Name = "comboOperador"
        Me.comboOperador.Size = New System.Drawing.Size(121, 24)
        Me.comboOperador.TabIndex = 4
        '
        'lblVal
        '
        Me.lblVal.AutoSize = True
        Me.lblVal.Location = New System.Drawing.Point(404, 88)
        Me.lblVal.Name = "lblVal"
        Me.lblVal.Size = New System.Drawing.Size(32, 17)
        Me.lblVal.TabIndex = 5
        Me.lblVal.Text = "Val:"
        '
        'txtVal
        '
        Me.txtVal.Location = New System.Drawing.Point(451, 85)
        Me.txtVal.Name = "txtVal"
        Me.txtVal.Size = New System.Drawing.Size(100, 22)
        Me.txtVal.TabIndex = 6
        '
        'cmdFilter
        '
        Me.cmdFilter.Location = New System.Drawing.Point(472, 142)
        Me.cmdFilter.Name = "cmdFilter"
        Me.cmdFilter.Size = New System.Drawing.Size(100, 30)
        Me.cmdFilter.TabIndex = 7
        Me.cmdFilter.Text = "Filter"
        Me.cmdFilter.UseVisualStyleBackColor = True
        '
        'cmdPrepall
        '
        Me.cmdPrepall.Location = New System.Drawing.Point(369, 142)
        Me.cmdPrepall.Name = "cmdPrepall"
        Me.cmdPrepall.Size = New System.Drawing.Size(100, 30)
        Me.cmdPrepall.TabIndex = 8
        Me.cmdPrepall.Text = "Prepall"
        Me.cmdPrepall.UseVisualStyleBackColor = True
        '
        'lblSay
        '
        Me.lblSay.AutoSize = True
        Me.lblSay.Location = New System.Drawing.Point(492, 110)
        Me.lblSay.Name = "lblSay"
        Me.lblSay.Size = New System.Drawing.Size(46, 17)
        Me.lblSay.TabIndex = 9
        Me.lblSay.Text = "lblSay"
        '
        'ucList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.lblSay)
        Me.Controls.Add(Me.cmdPrepall)
        Me.Controls.Add(Me.cmdFilter)
        Me.Controls.Add(Me.txtVal)
        Me.Controls.Add(Me.lblVal)
        Me.Controls.Add(Me.comboOperador)
        Me.Controls.Add(Me.lblOperador)
        Me.Controls.Add(Me.lblCaption)
        Me.Controls.Add(Me.comboCampo)
        Me.Controls.Add(Me.grid1)
        Me.Name = "ucList"
        Me.Size = New System.Drawing.Size(592, 281)
        CType(Me.grid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grid1 As DataGridView
    Friend WithEvents comboCampo As ComboBox
    Friend WithEvents lblCaption As Label
    Friend WithEvents lblOperador As Label
    Friend WithEvents comboOperador As ComboBox
    Friend WithEvents lblVal As Label
    Friend WithEvents txtVal As TextBox
    Friend WithEvents cmdFilter As Button
    Friend WithEvents cmdPrepall As Button
    Friend WithEvents lblSay As Label
End Class
