<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddEditQuestionario
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
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.lblIDQuestionario = New System.Windows.Forms.Label()
        Me.lblAutor = New System.Windows.Forms.Label()
        Me.txtTitulo = New System.Windows.Forms.TextBox()
        Me.txtAutor = New System.Windows.Forms.TextBox()
        Me.cmdOK = New System.Windows.Forms.Button()
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.cmdPrepall = New System.Windows.Forms.Button()
        Me.lblQuestionario = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Location = New System.Drawing.Point(24, 50)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(43, 17)
        Me.lblTitulo.TabIndex = 0
        Me.lblTitulo.Text = "Titulo"
        '
        'lblIDQuestionario
        '
        Me.lblIDQuestionario.AutoSize = True
        Me.lblIDQuestionario.Location = New System.Drawing.Point(12, 122)
        Me.lblIDQuestionario.Name = "lblIDQuestionario"
        Me.lblIDQuestionario.Size = New System.Drawing.Size(116, 17)
        Me.lblIDQuestionario.TabIndex = 1
        Me.lblIDQuestionario.Text = "lblIDQuestionario"
        Me.lblIDQuestionario.Visible = False
        '
        'lblAutor
        '
        Me.lblAutor.AutoSize = True
        Me.lblAutor.Location = New System.Drawing.Point(24, 84)
        Me.lblAutor.Name = "lblAutor"
        Me.lblAutor.Size = New System.Drawing.Size(42, 17)
        Me.lblAutor.TabIndex = 2
        Me.lblAutor.Text = "Autor"
        '
        'txtTitulo
        '
        Me.txtTitulo.Location = New System.Drawing.Point(141, 50)
        Me.txtTitulo.Name = "txtTitulo"
        Me.txtTitulo.Size = New System.Drawing.Size(136, 22)
        Me.txtTitulo.TabIndex = 3
        '
        'txtAutor
        '
        Me.txtAutor.Location = New System.Drawing.Point(141, 84)
        Me.txtAutor.Name = "txtAutor"
        Me.txtAutor.Size = New System.Drawing.Size(136, 22)
        Me.txtAutor.TabIndex = 4
        '
        'cmdOK
        '
        Me.cmdOK.Location = New System.Drawing.Point(171, 122)
        Me.cmdOK.Name = "cmdOK"
        Me.cmdOK.Size = New System.Drawing.Size(75, 23)
        Me.cmdOK.TabIndex = 5
        Me.cmdOK.Text = "Ok"
        Me.cmdOK.UseVisualStyleBackColor = True
        '
        'cmdCancel
        '
        Me.cmdCancel.Location = New System.Drawing.Point(261, 122)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(75, 23)
        Me.cmdCancel.TabIndex = 6
        Me.cmdCancel.Text = "Cancel"
        Me.cmdCancel.UseVisualStyleBackColor = True
        '
        'cmdPrepall
        '
        Me.cmdPrepall.Location = New System.Drawing.Point(1, 139)
        Me.cmdPrepall.Name = "cmdPrepall"
        Me.cmdPrepall.Size = New System.Drawing.Size(75, 23)
        Me.cmdPrepall.TabIndex = 7
        Me.cmdPrepall.Text = "cmdPrepall"
        Me.cmdPrepall.UseVisualStyleBackColor = True
        Me.cmdPrepall.Visible = False
        '
        'lblQuestionario
        '
        Me.lblQuestionario.AutoSize = True
        Me.lblQuestionario.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuestionario.Location = New System.Drawing.Point(117, 9)
        Me.lblQuestionario.Name = "lblQuestionario"
        Me.lblQuestionario.Size = New System.Drawing.Size(129, 24)
        Me.lblQuestionario.TabIndex = 8
        Me.lblQuestionario.Text = "Questionario"
        '
        'frmAddEditQuestionario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(348, 165)
        Me.Controls.Add(Me.lblQuestionario)
        Me.Controls.Add(Me.cmdPrepall)
        Me.Controls.Add(Me.cmdCancel)
        Me.Controls.Add(Me.cmdOK)
        Me.Controls.Add(Me.txtAutor)
        Me.Controls.Add(Me.txtTitulo)
        Me.Controls.Add(Me.lblAutor)
        Me.Controls.Add(Me.lblIDQuestionario)
        Me.Controls.Add(Me.lblTitulo)
        Me.Name = "frmAddEditQuestionario"
        Me.Text = "Questionario"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitulo As Label
    Friend WithEvents lblIDQuestionario As Label
    Friend WithEvents lblAutor As Label
    Friend WithEvents txtTitulo As TextBox
    Friend WithEvents txtAutor As TextBox
    Friend WithEvents cmdOK As Button
    Friend WithEvents cmdCancel As Button
    Friend WithEvents cmdPrepall As Button
    Friend WithEvents lblQuestionario As Label
End Class
