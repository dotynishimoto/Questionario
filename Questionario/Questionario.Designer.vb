<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmQuestionario
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
        Me.btnUpdateGrupo = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnPrepall = New System.Windows.Forms.Button()
        Me.lblIDQuestionario = New System.Windows.Forms.Label()
        Me.gridGrupos = New System.Windows.Forms.DataGridView()
        Me.gridPerguntas = New System.Windows.Forms.DataGridView()
        Me.lblIDGrupo = New System.Windows.Forms.Label()
        Me.lblIDPergunta = New System.Windows.Forms.Label()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.txtTitulo = New System.Windows.Forms.TextBox()
        Me.txtAutor = New System.Windows.Forms.TextBox()
        Me.listQuestionario = New System.Windows.Forms.ListView()
        Me.listGrupos = New System.Windows.Forms.ListView()
        Me.btnListGrupos = New System.Windows.Forms.Button()
        Me.lblIDOrdem = New System.Windows.Forms.Label()
        CType(Me.gridGrupos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridPerguntas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnUpdateGrupo
        '
        Me.btnUpdateGrupo.Location = New System.Drawing.Point(509, 196)
        Me.btnUpdateGrupo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnUpdateGrupo.Name = "btnUpdateGrupo"
        Me.btnUpdateGrupo.Size = New System.Drawing.Size(80, 30)
        Me.btnUpdateGrupo.TabIndex = 2
        Me.btnUpdateGrupo.Text = "Update"
        Me.btnUpdateGrupo.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(683, 454)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(95, 49)
        Me.btnCancel.TabIndex = 4
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnPrepall
        '
        Me.btnPrepall.Location = New System.Drawing.Point(797, 454)
        Me.btnPrepall.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnPrepall.Name = "btnPrepall"
        Me.btnPrepall.Size = New System.Drawing.Size(95, 49)
        Me.btnPrepall.TabIndex = 5
        Me.btnPrepall.Text = "Prepall"
        Me.btnPrepall.UseVisualStyleBackColor = True
        '
        'lblIDQuestionario
        '
        Me.lblIDQuestionario.AutoSize = True
        Me.lblIDQuestionario.Location = New System.Drawing.Point(3, -2)
        Me.lblIDQuestionario.Name = "lblIDQuestionario"
        Me.lblIDQuestionario.Size = New System.Drawing.Size(116, 17)
        Me.lblIDQuestionario.TabIndex = 6
        Me.lblIDQuestionario.Text = "lblIDQuestionario"
        '
        'gridGrupos
        '
        Me.gridGrupos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridGrupos.Location = New System.Drawing.Point(29, 162)
        Me.gridGrupos.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.gridGrupos.Name = "gridGrupos"
        Me.gridGrupos.RowTemplate.Height = 24
        Me.gridGrupos.Size = New System.Drawing.Size(475, 150)
        Me.gridGrupos.TabIndex = 7
        '
        'gridPerguntas
        '
        Me.gridPerguntas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridPerguntas.Location = New System.Drawing.Point(29, 335)
        Me.gridPerguntas.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.gridPerguntas.Name = "gridPerguntas"
        Me.gridPerguntas.RowTemplate.Height = 24
        Me.gridPerguntas.Size = New System.Drawing.Size(475, 159)
        Me.gridPerguntas.TabIndex = 8
        '
        'lblIDGrupo
        '
        Me.lblIDGrupo.AutoSize = True
        Me.lblIDGrupo.Location = New System.Drawing.Point(3, 142)
        Me.lblIDGrupo.Name = "lblIDGrupo"
        Me.lblIDGrupo.Size = New System.Drawing.Size(75, 17)
        Me.lblIDGrupo.TabIndex = 9
        Me.lblIDGrupo.Text = "lblIDGrupo"
        '
        'lblIDPergunta
        '
        Me.lblIDPergunta.AutoSize = True
        Me.lblIDPergunta.Location = New System.Drawing.Point(3, 315)
        Me.lblIDPergunta.Name = "lblIDPergunta"
        Me.lblIDPergunta.Size = New System.Drawing.Size(93, 17)
        Me.lblIDPergunta.TabIndex = 10
        Me.lblIDPergunta.Text = "lblIDPergunta"
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(509, 352)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(80, 30)
        Me.btnAdd.TabIndex = 11
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnEdit
        '
        Me.btnEdit.Location = New System.Drawing.Point(509, 398)
        Me.btnEdit.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(80, 30)
        Me.btnEdit.TabIndex = 14
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(509, 447)
        Me.btnDelete.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(80, 30)
        Me.btnDelete.TabIndex = 15
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'txtTitulo
        '
        Me.txtTitulo.Location = New System.Drawing.Point(528, 18)
        Me.txtTitulo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtTitulo.Name = "txtTitulo"
        Me.txtTitulo.Size = New System.Drawing.Size(100, 22)
        Me.txtTitulo.TabIndex = 16
        '
        'txtAutor
        '
        Me.txtAutor.Location = New System.Drawing.Point(528, 48)
        Me.txtAutor.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtAutor.Name = "txtAutor"
        Me.txtAutor.Size = New System.Drawing.Size(100, 22)
        Me.txtAutor.TabIndex = 17
        '
        'listQuestionario
        '
        Me.listQuestionario.HideSelection = False
        Me.listQuestionario.Location = New System.Drawing.Point(29, 18)
        Me.listQuestionario.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.listQuestionario.Name = "listQuestionario"
        Me.listQuestionario.Size = New System.Drawing.Size(473, 98)
        Me.listQuestionario.TabIndex = 18
        Me.listQuestionario.UseCompatibleStateImageBehavior = False
        '
        'listGrupos
        '
        Me.listGrupos.HideSelection = False
        Me.listGrupos.Location = New System.Drawing.Point(626, 162)
        Me.listGrupos.Name = "listGrupos"
        Me.listGrupos.Size = New System.Drawing.Size(256, 134)
        Me.listGrupos.TabIndex = 19
        Me.listGrupos.UseCompatibleStateImageBehavior = False
        '
        'btnListGrupos
        '
        Me.btnListGrupos.Location = New System.Drawing.Point(509, 247)
        Me.btnListGrupos.Name = "btnListGrupos"
        Me.btnListGrupos.Size = New System.Drawing.Size(88, 29)
        Me.btnListGrupos.TabIndex = 20
        Me.btnListGrupos.Text = "ListGrupos"
        Me.btnListGrupos.UseVisualStyleBackColor = True
        '
        'lblIDOrdem
        '
        Me.lblIDOrdem.AutoSize = True
        Me.lblIDOrdem.Location = New System.Drawing.Point(111, 316)
        Me.lblIDOrdem.Name = "lblIDOrdem"
        Me.lblIDOrdem.Size = New System.Drawing.Size(78, 17)
        Me.lblIDOrdem.TabIndex = 21
        Me.lblIDOrdem.Text = "lblIDOrdem"
        '
        'frmQuestionario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(905, 514)
        Me.Controls.Add(Me.lblIDOrdem)
        Me.Controls.Add(Me.btnListGrupos)
        Me.Controls.Add(Me.listGrupos)
        Me.Controls.Add(Me.listQuestionario)
        Me.Controls.Add(Me.txtAutor)
        Me.Controls.Add(Me.txtTitulo)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.lblIDPergunta)
        Me.Controls.Add(Me.lblIDGrupo)
        Me.Controls.Add(Me.gridPerguntas)
        Me.Controls.Add(Me.gridGrupos)
        Me.Controls.Add(Me.lblIDQuestionario)
        Me.Controls.Add(Me.btnPrepall)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnUpdateGrupo)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "frmQuestionario"
        Me.Text = "Questionario"
        CType(Me.gridGrupos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridPerguntas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnUpdateGrupo As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnPrepall As Button
    Friend WithEvents lblIDQuestionario As Label
    Friend WithEvents gridGrupos As DataGridView
    Friend WithEvents gridPerguntas As DataGridView
    Friend WithEvents lblIDGrupo As Label
    Friend WithEvents lblIDPergunta As Label
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents txtTitulo As TextBox
    Friend WithEvents txtAutor As TextBox
    Friend WithEvents listQuestionario As ListView
    Friend WithEvents listGrupos As ListView
    Friend WithEvents btnListGrupos As Button
    Friend WithEvents lblIDOrdem As Label
End Class
