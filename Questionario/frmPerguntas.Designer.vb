<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPerguntas
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
        Me.lblIDPergunta = New System.Windows.Forms.Label()
        Me.btnPrepall = New System.Windows.Forms.Button()
        Me.btnOk = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.txtQuestao = New System.Windows.Forms.TextBox()
        Me.txtStep = New System.Windows.Forms.TextBox()
        Me.txtRangeMin = New System.Windows.Forms.TextBox()
        Me.txtRangeMax = New System.Windows.Forms.TextBox()
        Me.txtRespostas = New System.Windows.Forms.TextBox()
        Me.lblQuestao = New System.Windows.Forms.Label()
        Me.lblTipo = New System.Windows.Forms.Label()
        Me.lblRespostas = New System.Windows.Forms.Label()
        Me.lblRangeMax = New System.Windows.Forms.Label()
        Me.lblRangeMin = New System.Windows.Forms.Label()
        Me.lblStep = New System.Windows.Forms.Label()
        Me.lblIDGrupo = New System.Windows.Forms.Label()
        Me.lblIDOrdem = New System.Windows.Forms.Label()
        Me.lblIDHold = New System.Windows.Forms.Label()
        Me.comboTipo = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblIDPergunta
        '
        Me.lblIDPergunta.AutoSize = True
        Me.lblIDPergunta.Location = New System.Drawing.Point(15, 11)
        Me.lblIDPergunta.Name = "lblIDPergunta"
        Me.lblIDPergunta.Size = New System.Drawing.Size(93, 17)
        Me.lblIDPergunta.TabIndex = 0
        Me.lblIDPergunta.Text = "lblIDPergunta"
        Me.lblIDPergunta.Visible = False
        '
        'btnPrepall
        '
        Me.btnPrepall.Location = New System.Drawing.Point(544, 297)
        Me.btnPrepall.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnPrepall.Name = "btnPrepall"
        Me.btnPrepall.Size = New System.Drawing.Size(75, 30)
        Me.btnPrepall.TabIndex = 1
        Me.btnPrepall.Text = "prePall"
        Me.btnPrepall.UseVisualStyleBackColor = True
        '
        'btnOk
        '
        Me.btnOk.Location = New System.Drawing.Point(139, 282)
        Me.btnOk.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(79, 46)
        Me.btnOk.TabIndex = 2
        Me.btnOk.Text = "Ok"
        Me.btnOk.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(255, 282)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(79, 46)
        Me.btnCancel.TabIndex = 15
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'txtQuestao
        '
        Me.txtQuestao.Location = New System.Drawing.Point(118, 36)
        Me.txtQuestao.Name = "txtQuestao"
        Me.txtQuestao.Size = New System.Drawing.Size(460, 22)
        Me.txtQuestao.TabIndex = 17
        '
        'txtStep
        '
        Me.txtStep.Location = New System.Drawing.Point(118, 240)
        Me.txtStep.Name = "txtStep"
        Me.txtStep.Size = New System.Drawing.Size(58, 22)
        Me.txtStep.TabIndex = 18
        '
        'txtRangeMin
        '
        Me.txtRangeMin.Location = New System.Drawing.Point(118, 201)
        Me.txtRangeMin.Name = "txtRangeMin"
        Me.txtRangeMin.Size = New System.Drawing.Size(58, 22)
        Me.txtRangeMin.TabIndex = 19
        '
        'txtRangeMax
        '
        Me.txtRangeMax.Location = New System.Drawing.Point(118, 162)
        Me.txtRangeMax.Name = "txtRangeMax"
        Me.txtRangeMax.Size = New System.Drawing.Size(58, 22)
        Me.txtRangeMax.TabIndex = 20
        '
        'txtRespostas
        '
        Me.txtRespostas.Location = New System.Drawing.Point(118, 114)
        Me.txtRespostas.Name = "txtRespostas"
        Me.txtRespostas.Size = New System.Drawing.Size(460, 22)
        Me.txtRespostas.TabIndex = 21
        '
        'lblQuestao
        '
        Me.lblQuestao.AutoSize = True
        Me.lblQuestao.Location = New System.Drawing.Point(15, 41)
        Me.lblQuestao.Name = "lblQuestao"
        Me.lblQuestao.Size = New System.Drawing.Size(62, 17)
        Me.lblQuestao.TabIndex = 23
        Me.lblQuestao.Text = "Questao"
        '
        'lblTipo
        '
        Me.lblTipo.AutoSize = True
        Me.lblTipo.Location = New System.Drawing.Point(15, 78)
        Me.lblTipo.Name = "lblTipo"
        Me.lblTipo.Size = New System.Drawing.Size(36, 17)
        Me.lblTipo.TabIndex = 24
        Me.lblTipo.Text = "Tipo"
        '
        'lblRespostas
        '
        Me.lblRespostas.AutoSize = True
        Me.lblRespostas.Location = New System.Drawing.Point(15, 119)
        Me.lblRespostas.Name = "lblRespostas"
        Me.lblRespostas.Size = New System.Drawing.Size(75, 17)
        Me.lblRespostas.TabIndex = 25
        Me.lblRespostas.Text = "Respostas"
        '
        'lblRangeMax
        '
        Me.lblRangeMax.AutoSize = True
        Me.lblRangeMax.Location = New System.Drawing.Point(15, 165)
        Me.lblRangeMax.Name = "lblRangeMax"
        Me.lblRangeMax.Size = New System.Drawing.Size(75, 17)
        Me.lblRangeMax.TabIndex = 26
        Me.lblRangeMax.Text = "RangeMax"
        '
        'lblRangeMin
        '
        Me.lblRangeMin.AutoSize = True
        Me.lblRangeMin.Location = New System.Drawing.Point(15, 206)
        Me.lblRangeMin.Name = "lblRangeMin"
        Me.lblRangeMin.Size = New System.Drawing.Size(72, 17)
        Me.lblRangeMin.TabIndex = 27
        Me.lblRangeMin.Text = "RangeMin"
        '
        'lblStep
        '
        Me.lblStep.AutoSize = True
        Me.lblStep.Location = New System.Drawing.Point(15, 246)
        Me.lblStep.Name = "lblStep"
        Me.lblStep.Size = New System.Drawing.Size(37, 17)
        Me.lblStep.TabIndex = 28
        Me.lblStep.Text = "Step"
        '
        'lblIDGrupo
        '
        Me.lblIDGrupo.AutoSize = True
        Me.lblIDGrupo.Location = New System.Drawing.Point(136, 11)
        Me.lblIDGrupo.Name = "lblIDGrupo"
        Me.lblIDGrupo.Size = New System.Drawing.Size(75, 17)
        Me.lblIDGrupo.TabIndex = 29
        Me.lblIDGrupo.Text = "lblIDGrupo"
        Me.lblIDGrupo.Visible = False
        '
        'lblIDOrdem
        '
        Me.lblIDOrdem.AutoSize = True
        Me.lblIDOrdem.Location = New System.Drawing.Point(226, 11)
        Me.lblIDOrdem.Name = "lblIDOrdem"
        Me.lblIDOrdem.Size = New System.Drawing.Size(78, 17)
        Me.lblIDOrdem.TabIndex = 30
        Me.lblIDOrdem.Text = "lblIDOrdem"
        Me.lblIDOrdem.Visible = False
        '
        'lblIDHold
        '
        Me.lblIDHold.AutoSize = True
        Me.lblIDHold.Location = New System.Drawing.Point(541, 9)
        Me.lblIDHold.Name = "lblIDHold"
        Me.lblIDHold.Size = New System.Drawing.Size(64, 17)
        Me.lblIDHold.TabIndex = 31
        Me.lblIDHold.Text = "lblIDHold"
        Me.lblIDHold.Visible = False
        '
        'comboTipo
        '
        Me.comboTipo.AutoCompleteCustomSource.AddRange(New String() {"o", "m", "t", "i", "n", "d"})
        Me.comboTipo.FormattingEnabled = True
        Me.comboTipo.Items.AddRange(New Object() {"o", "m", "t", "i", "n", "d"})
        Me.comboTipo.Location = New System.Drawing.Point(118, 75)
        Me.comboTipo.Name = "comboTipo"
        Me.comboTipo.Size = New System.Drawing.Size(121, 24)
        Me.comboTipo.TabIndex = 32
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(245, 61)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(285, 17)
        Me.Label1.TabIndex = 33
        Me.Label1.Text = "O: Opcao; M: Multipla Opcao;T: Texto Livre;" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(245, 82)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(302, 17)
        Me.Label2.TabIndex = 34
        Me.Label2.Text = "I: Numero Inteiro; N: Numero Decimal; D: Data;"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(115, 139)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(462, 17)
        Me.Label3.TabIndex = 35
        Me.Label3.Text = "Separar cada alternativa com "";"". Ex: Muito bom; Bom; Ruim; Muito Ruim"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'frmPerguntas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(619, 340)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.comboTipo)
        Me.Controls.Add(Me.lblIDHold)
        Me.Controls.Add(Me.lblIDOrdem)
        Me.Controls.Add(Me.lblIDGrupo)
        Me.Controls.Add(Me.lblStep)
        Me.Controls.Add(Me.lblRangeMin)
        Me.Controls.Add(Me.lblRangeMax)
        Me.Controls.Add(Me.lblRespostas)
        Me.Controls.Add(Me.lblTipo)
        Me.Controls.Add(Me.lblQuestao)
        Me.Controls.Add(Me.txtRespostas)
        Me.Controls.Add(Me.txtRangeMax)
        Me.Controls.Add(Me.txtRangeMin)
        Me.Controls.Add(Me.txtStep)
        Me.Controls.Add(Me.txtQuestao)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.btnPrepall)
        Me.Controls.Add(Me.lblIDPergunta)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "frmPerguntas"
        Me.Text = "Perguntas"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblIDPergunta As Label
    Friend WithEvents btnPrepall As Button
    Friend WithEvents btnOk As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents txtQuestao As TextBox
    Friend WithEvents txtStep As TextBox
    Friend WithEvents txtRangeMin As TextBox
    Friend WithEvents txtRangeMax As TextBox
    Friend WithEvents txtRespostas As TextBox
    Friend WithEvents lblQuestao As Label
    Friend WithEvents lblTipo As Label
    Friend WithEvents lblRespostas As Label
    Friend WithEvents lblRangeMax As Label
    Friend WithEvents lblRangeMin As Label
    Friend WithEvents lblStep As Label
    Friend WithEvents lblIDGrupo As Label
    Friend WithEvents lblIDOrdem As Label
    Friend WithEvents lblIDHold As Label
    Friend WithEvents comboTipo As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
