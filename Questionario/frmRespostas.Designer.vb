<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmRespostas
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
        Me.lblIDData = New System.Windows.Forms.Label()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnPrev = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnOk = New System.Windows.Forms.Button()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.lblTipo = New System.Windows.Forms.Label()
        Me.check = New System.Windows.Forms.CheckedListBox()
        Me.dateConsulta = New System.Windows.Forms.DateTimePicker()
        Me.lblIDPergunta = New System.Windows.Forms.Label()
        Me.lblIDQuestionario = New System.Windows.Forms.Label()
        Me.lblIDOrdem = New System.Windows.Forms.Label()
        Me.lblHoldPaciente = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.lblIDHoldEnquete = New System.Windows.Forms.Label()
        Me.pnlPerguntas = New System.Windows.Forms.Panel()
        Me.lblPergunta = New System.Windows.Forms.Label()
        Me.lblGrupo = New System.Windows.Forms.Label()
        Me.txtRespostaNum = New System.Windows.Forms.TextBox()
        Me.txtRespostaTexto = New System.Windows.Forms.TextBox()
        Me.datePicker = New System.Windows.Forms.DateTimePicker()
        Me.comboOpcao = New System.Windows.Forms.ComboBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblEnquete = New System.Windows.Forms.Label()
        Me.gridPessoas = New System.Windows.Forms.DataGridView()
        Me.UcSaySomething1 = New Questionario.ucSaySomething()
        Me.UcSayRespondente = New Questionario.ucSaySomething()
        Me.pnlPerguntas.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.gridPessoas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblIDData
        '
        Me.lblIDData.AutoSize = True
        Me.lblIDData.Location = New System.Drawing.Point(75, 75)
        Me.lblIDData.Name = "lblIDData"
        Me.lblIDData.Size = New System.Drawing.Size(46, 17)
        Me.lblIDData.TabIndex = 1
        Me.lblIDData.Text = "Data: "
        '
        'btnNext
        '
        Me.btnNext.Enabled = False
        Me.btnNext.Location = New System.Drawing.Point(126, 434)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(75, 23)
        Me.btnNext.TabIndex = 5
        Me.btnNext.Text = "Next"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'btnPrev
        '
        Me.btnPrev.Enabled = False
        Me.btnPrev.Location = New System.Drawing.Point(45, 434)
        Me.btnPrev.Name = "btnPrev"
        Me.btnPrev.Size = New System.Drawing.Size(75, 23)
        Me.btnPrev.TabIndex = 6
        Me.btnPrev.Text = "Prev"
        Me.btnPrev.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(576, 434)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 7
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnOk
        '
        Me.btnOk.Location = New System.Drawing.Point(478, 434)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(75, 23)
        Me.btnOk.TabIndex = 8
        Me.btnOk.Text = "Ok"
        Me.btnOk.UseVisualStyleBackColor = True
        '
        'btnStart
        '
        Me.btnStart.Location = New System.Drawing.Point(338, 142)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(75, 23)
        Me.btnStart.TabIndex = 9
        Me.btnStart.Text = "Start"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'lblTipo
        '
        Me.lblTipo.AutoSize = True
        Me.lblTipo.Enabled = False
        Me.lblTipo.Location = New System.Drawing.Point(-3, 238)
        Me.lblTipo.Name = "lblTipo"
        Me.lblTipo.Size = New System.Drawing.Size(36, 17)
        Me.lblTipo.TabIndex = 10
        Me.lblTipo.Text = "Tipo"
        Me.lblTipo.Visible = False
        '
        'check
        '
        Me.check.FormattingEnabled = True
        Me.check.Location = New System.Drawing.Point(292, 6)
        Me.check.Name = "check"
        Me.check.Size = New System.Drawing.Size(120, 89)
        Me.check.TabIndex = 20
        Me.check.Visible = False
        '
        'dateConsulta
        '
        Me.dateConsulta.Location = New System.Drawing.Point(122, 74)
        Me.dateConsulta.Name = "dateConsulta"
        Me.dateConsulta.Size = New System.Drawing.Size(239, 22)
        Me.dateConsulta.TabIndex = 28
        Me.dateConsulta.Value = New Date(2019, 7, 18, 0, 0, 0, 0)
        '
        'lblIDPergunta
        '
        Me.lblIDPergunta.AutoSize = True
        Me.lblIDPergunta.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIDPergunta.Location = New System.Drawing.Point(540, 360)
        Me.lblIDPergunta.Name = "lblIDPergunta"
        Me.lblIDPergunta.Size = New System.Drawing.Size(110, 20)
        Me.lblIDPergunta.TabIndex = 31
        Me.lblIDPergunta.Text = "lblIDPergunta"
        Me.lblIDPergunta.Visible = False
        '
        'lblIDQuestionario
        '
        Me.lblIDQuestionario.AutoSize = True
        Me.lblIDQuestionario.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIDQuestionario.Location = New System.Drawing.Point(540, 320)
        Me.lblIDQuestionario.Name = "lblIDQuestionario"
        Me.lblIDQuestionario.Size = New System.Drawing.Size(138, 20)
        Me.lblIDQuestionario.TabIndex = 32
        Me.lblIDQuestionario.Text = "lblIDQuestionario"
        Me.lblIDQuestionario.Visible = False
        '
        'lblIDOrdem
        '
        Me.lblIDOrdem.AutoSize = True
        Me.lblIDOrdem.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIDOrdem.Location = New System.Drawing.Point(540, 340)
        Me.lblIDOrdem.Name = "lblIDOrdem"
        Me.lblIDOrdem.Size = New System.Drawing.Size(94, 20)
        Me.lblIDOrdem.TabIndex = 33
        Me.lblIDOrdem.Text = "lblIDOrdem"
        Me.lblIDOrdem.Visible = False
        '
        'lblHoldPaciente
        '
        Me.lblHoldPaciente.AutoSize = True
        Me.lblHoldPaciente.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHoldPaciente.Location = New System.Drawing.Point(540, 300)
        Me.lblHoldPaciente.Name = "lblHoldPaciente"
        Me.lblHoldPaciente.Size = New System.Drawing.Size(126, 20)
        Me.lblHoldPaciente.TabIndex = 38
        Me.lblHoldPaciente.Text = "lblHoldPaciente"
        Me.lblHoldPaciente.Visible = False
        '
        'btnSave
        '
        Me.btnSave.Enabled = False
        Me.btnSave.Location = New System.Drawing.Point(207, 434)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 39
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'lblIDHoldEnquete
        '
        Me.lblIDHoldEnquete.AutoSize = True
        Me.lblIDHoldEnquete.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIDHoldEnquete.Location = New System.Drawing.Point(540, 279)
        Me.lblIDHoldEnquete.Name = "lblIDHoldEnquete"
        Me.lblIDHoldEnquete.Size = New System.Drawing.Size(139, 20)
        Me.lblIDHoldEnquete.TabIndex = 40
        Me.lblIDHoldEnquete.Text = "lblIDHoldEnquete"
        '
        'pnlPerguntas
        '
        Me.pnlPerguntas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlPerguntas.Controls.Add(Me.lblPergunta)
        Me.pnlPerguntas.Controls.Add(Me.lblGrupo)
        Me.pnlPerguntas.Controls.Add(Me.txtRespostaNum)
        Me.pnlPerguntas.Controls.Add(Me.txtRespostaTexto)
        Me.pnlPerguntas.Controls.Add(Me.datePicker)
        Me.pnlPerguntas.Controls.Add(Me.comboOpcao)
        Me.pnlPerguntas.Controls.Add(Me.check)
        Me.pnlPerguntas.Location = New System.Drawing.Point(39, 238)
        Me.pnlPerguntas.Name = "pnlPerguntas"
        Me.pnlPerguntas.Size = New System.Drawing.Size(417, 190)
        Me.pnlPerguntas.TabIndex = 48
        '
        'lblPergunta
        '
        Me.lblPergunta.AutoSize = True
        Me.lblPergunta.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPergunta.Location = New System.Drawing.Point(9, 20)
        Me.lblPergunta.Name = "lblPergunta"
        Me.lblPergunta.Size = New System.Drawing.Size(93, 20)
        Me.lblPergunta.TabIndex = 3
        Me.lblPergunta.Text = "lblPergunta"
        '
        'lblGrupo
        '
        Me.lblGrupo.AutoSize = True
        Me.lblGrupo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGrupo.Location = New System.Drawing.Point(11, -1)
        Me.lblGrupo.Name = "lblGrupo"
        Me.lblGrupo.Size = New System.Drawing.Size(72, 20)
        Me.lblGrupo.TabIndex = 29
        Me.lblGrupo.Text = "lblGrupo"
        '
        'txtRespostaNum
        '
        Me.txtRespostaNum.Location = New System.Drawing.Point(181, 17)
        Me.txtRespostaNum.Name = "txtRespostaNum"
        Me.txtRespostaNum.Size = New System.Drawing.Size(73, 22)
        Me.txtRespostaNum.TabIndex = 32
        Me.txtRespostaNum.Visible = False
        '
        'txtRespostaTexto
        '
        Me.txtRespostaTexto.Location = New System.Drawing.Point(15, 73)
        Me.txtRespostaTexto.Name = "txtRespostaTexto"
        Me.txtRespostaTexto.Size = New System.Drawing.Size(176, 22)
        Me.txtRespostaTexto.TabIndex = 33
        Me.txtRespostaTexto.Visible = False
        '
        'datePicker
        '
        Me.datePicker.Location = New System.Drawing.Point(15, 101)
        Me.datePicker.Name = "datePicker"
        Me.datePicker.Size = New System.Drawing.Size(239, 22)
        Me.datePicker.TabIndex = 30
        Me.datePicker.Value = New Date(2019, 7, 12, 0, 0, 0, 0)
        Me.datePicker.Visible = False
        '
        'comboOpcao
        '
        Me.comboOpcao.FormattingEnabled = True
        Me.comboOpcao.Location = New System.Drawing.Point(15, 43)
        Me.comboOpcao.Name = "comboOpcao"
        Me.comboOpcao.Size = New System.Drawing.Size(146, 24)
        Me.comboOpcao.TabIndex = 31
        Me.comboOpcao.Visible = False
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.UcSaySomething1)
        Me.Panel1.Controls.Add(Me.lblEnquete)
        Me.Panel1.Controls.Add(Me.lblIDData)
        Me.Panel1.Controls.Add(Me.dateConsulta)
        Me.Panel1.Controls.Add(Me.UcSayRespondente)
        Me.Panel1.Controls.Add(Me.btnStart)
        Me.Panel1.Location = New System.Drawing.Point(39, 38)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(417, 166)
        Me.Panel1.TabIndex = 49
        '
        'lblEnquete
        '
        Me.lblEnquete.AutoSize = True
        Me.lblEnquete.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEnquete.Location = New System.Drawing.Point(165, -1)
        Me.lblEnquete.Name = "lblEnquete"
        Me.lblEnquete.Size = New System.Drawing.Size(92, 25)
        Me.lblEnquete.TabIndex = 50
        Me.lblEnquete.Text = "Enquete"
        '
        'gridPessoas
        '
        Me.gridPessoas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridPessoas.Location = New System.Drawing.Point(478, 38)
        Me.gridPessoas.Name = "gridPessoas"
        Me.gridPessoas.RowTemplate.Height = 24
        Me.gridPessoas.Size = New System.Drawing.Size(303, 166)
        Me.gridPessoas.TabIndex = 50
        '
        'UcSaySomething1
        '
        Me.UcSaySomething1.Caption = "Caput"
        Me.UcSaySomething1.CausesValidation = False
        Me.UcSaySomething1.Location = New System.Drawing.Point(-37, 31)
        Me.UcSaySomething1.Name = "UcSaySomething1"
        Me.UcSaySomething1.pkField = Nothing
        Me.UcSaySomething1.pkVal = Nothing
        Me.UcSaySomething1.sayField = " "
        Me.UcSaySomething1.Size = New System.Drawing.Size(318, 35)
        Me.UcSaySomething1.TabIndex = 46
        Me.UcSaySomething1.tbName = Nothing
        '
        'UcSayRespondente
        '
        Me.UcSayRespondente.Caption = "Caput"
        Me.UcSayRespondente.CausesValidation = False
        Me.UcSayRespondente.Location = New System.Drawing.Point(-37, 107)
        Me.UcSayRespondente.Name = "UcSayRespondente"
        Me.UcSayRespondente.pkField = Nothing
        Me.UcSayRespondente.pkVal = Nothing
        Me.UcSayRespondente.sayField = Nothing
        Me.UcSayRespondente.Size = New System.Drawing.Size(433, 35)
        Me.UcSayRespondente.TabIndex = 47
        Me.UcSayRespondente.tbName = Nothing
        '
        'frmRespostas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(790, 469)
        Me.Controls.Add(Me.gridPessoas)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.pnlPerguntas)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.lblIDHoldEnquete)
        Me.Controls.Add(Me.lblHoldPaciente)
        Me.Controls.Add(Me.lblIDOrdem)
        Me.Controls.Add(Me.lblIDQuestionario)
        Me.Controls.Add(Me.lblIDPergunta)
        Me.Controls.Add(Me.lblTipo)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnPrev)
        Me.Controls.Add(Me.btnNext)
        Me.Name = "frmRespostas"
        Me.Text = "Respostas"
        Me.pnlPerguntas.ResumeLayout(False)
        Me.pnlPerguntas.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.gridPessoas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblIDData As Label
    Friend WithEvents btnNext As Button
    Friend WithEvents btnPrev As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnOk As Button
    Friend WithEvents btnStart As Button
    Friend WithEvents lblTipo As Label
    Friend WithEvents check As CheckedListBox
    Friend WithEvents dateConsulta As DateTimePicker
    Friend WithEvents lblIDPergunta As Label
    Friend WithEvents lblIDQuestionario As Label
    Friend WithEvents lblIDOrdem As Label
    Friend WithEvents lblHoldPaciente As Label
    Friend WithEvents btnSave As Button
    Friend WithEvents lblIDHoldEnquete As Label
    Friend WithEvents UcSaySomething1 As ucSaySomething
    Friend WithEvents UcSayRespondente As ucSaySomething
    Friend WithEvents pnlPerguntas As Panel
    Friend WithEvents lblPergunta As Label
    Friend WithEvents lblGrupo As Label
    Friend WithEvents txtRespostaNum As TextBox
    Friend WithEvents txtRespostaTexto As TextBox
    Friend WithEvents datePicker As DateTimePicker
    Friend WithEvents comboOpcao As ComboBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblEnquete As Label
    Friend WithEvents gridPessoas As DataGridView
End Class
