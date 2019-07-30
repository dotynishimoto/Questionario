<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmGrupos
    Inherits System.Windows.Forms.Form

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
        Me.btnOk = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.lblID = New System.Windows.Forms.Label()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.txtTitulo = New System.Windows.Forms.TextBox()
        Me.lblIDQuestionario = New System.Windows.Forms.Label()
        Me.lblOrdem = New System.Windows.Forms.Label()
        Me.txtOrdem = New System.Windows.Forms.TextBox()
        Me.lblGrupo = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnOk
        '
        Me.btnOk.Location = New System.Drawing.Point(52, 131)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(75, 23)
        Me.btnOk.TabIndex = 2
        Me.btnOk.Text = "Ok"
        Me.btnOk.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(166, 131)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 3
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.Location = New System.Drawing.Point(123, 168)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(35, 17)
        Me.lblID.TabIndex = 4
        Me.lblID.Text = "lblID"
        Me.lblID.Visible = False
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Location = New System.Drawing.Point(31, 57)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(43, 17)
        Me.lblTitulo.TabIndex = 1
        Me.lblTitulo.Text = "Titulo"
        '
        'txtTitulo
        '
        Me.txtTitulo.Location = New System.Drawing.Point(104, 57)
        Me.txtTitulo.Name = "txtTitulo"
        Me.txtTitulo.Size = New System.Drawing.Size(137, 22)
        Me.txtTitulo.TabIndex = 0
        '
        'lblIDQuestionario
        '
        Me.lblIDQuestionario.AutoSize = True
        Me.lblIDQuestionario.Location = New System.Drawing.Point(1, 168)
        Me.lblIDQuestionario.Name = "lblIDQuestionario"
        Me.lblIDQuestionario.Size = New System.Drawing.Size(116, 17)
        Me.lblIDQuestionario.TabIndex = 5
        Me.lblIDQuestionario.Text = "lblIDQuestionario"
        Me.lblIDQuestionario.Visible = False
        '
        'lblOrdem
        '
        Me.lblOrdem.AutoSize = True
        Me.lblOrdem.Location = New System.Drawing.Point(31, 97)
        Me.lblOrdem.Name = "lblOrdem"
        Me.lblOrdem.Size = New System.Drawing.Size(51, 17)
        Me.lblOrdem.TabIndex = 6
        Me.lblOrdem.Text = "Ordem"
        '
        'txtOrdem
        '
        Me.txtOrdem.Location = New System.Drawing.Point(104, 94)
        Me.txtOrdem.Name = "txtOrdem"
        Me.txtOrdem.Size = New System.Drawing.Size(137, 22)
        Me.txtOrdem.TabIndex = 7
        '
        'lblGrupo
        '
        Me.lblGrupo.AutoSize = True
        Me.lblGrupo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGrupo.Location = New System.Drawing.Point(99, 9)
        Me.lblGrupo.Name = "lblGrupo"
        Me.lblGrupo.Size = New System.Drawing.Size(71, 25)
        Me.lblGrupo.TabIndex = 8
        Me.lblGrupo.Text = "Grupo"
        '
        'frmGrupos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(277, 185)
        Me.Controls.Add(Me.lblGrupo)
        Me.Controls.Add(Me.txtOrdem)
        Me.Controls.Add(Me.lblOrdem)
        Me.Controls.Add(Me.lblIDQuestionario)
        Me.Controls.Add(Me.lblID)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.txtTitulo)
        Me.Name = "frmGrupos"
        Me.Text = "Grupos"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnOk As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents lblID As Label
    Friend WithEvents lblTitulo As Label
    Friend WithEvents txtTitulo As TextBox
    Friend WithEvents lblIDQuestionario As Label
    Friend WithEvents lblOrdem As Label
    Friend WithEvents txtOrdem As TextBox
    Friend WithEvents lblGrupo As Label
End Class
