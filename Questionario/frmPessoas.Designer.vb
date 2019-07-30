<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPessoas
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
        Me.lblNome = New System.Windows.Forms.Label()
        Me.lblSobrenome = New System.Windows.Forms.Label()
        Me.lblDDN = New System.Windows.Forms.Label()
        Me.lblSexo = New System.Windows.Forms.Label()
        Me.lblCPF = New System.Windows.Forms.Label()
        Me.lblProfissao = New System.Windows.Forms.Label()
        Me.lblIDPessoas = New System.Windows.Forms.Label()
        Me.txtNome = New System.Windows.Forms.TextBox()
        Me.txtProfissao = New System.Windows.Forms.TextBox()
        Me.txtCPF = New System.Windows.Forms.TextBox()
        Me.txtSobrenome = New System.Windows.Forms.TextBox()
        Me.cmdOk = New System.Windows.Forms.Button()
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.dateDDN = New System.Windows.Forms.DateTimePicker()
        Me.comboSexo = New System.Windows.Forms.ComboBox()
        Me.cmdPrepall = New System.Windows.Forms.Button()
        Me.lblOnlyNumbers = New System.Windows.Forms.Label()
        Me.lblPessoas = New System.Windows.Forms.Label()
        Me.lblCRM = New System.Windows.Forms.Label()
        Me.txtCRM = New System.Windows.Forms.TextBox()
        Me.lblHoldCRM = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblNome
        '
        Me.lblNome.AutoSize = True
        Me.lblNome.Location = New System.Drawing.Point(29, 51)
        Me.lblNome.Name = "lblNome"
        Me.lblNome.Size = New System.Drawing.Size(45, 17)
        Me.lblNome.TabIndex = 0
        Me.lblNome.Text = "Nome"
        '
        'lblSobrenome
        '
        Me.lblSobrenome.AutoSize = True
        Me.lblSobrenome.Location = New System.Drawing.Point(29, 88)
        Me.lblSobrenome.Name = "lblSobrenome"
        Me.lblSobrenome.Size = New System.Drawing.Size(81, 17)
        Me.lblSobrenome.TabIndex = 1
        Me.lblSobrenome.Text = "Sobrenome"
        '
        'lblDDN
        '
        Me.lblDDN.AutoSize = True
        Me.lblDDN.Location = New System.Drawing.Point(29, 123)
        Me.lblDDN.Name = "lblDDN"
        Me.lblDDN.Size = New System.Drawing.Size(136, 17)
        Me.lblDDN.TabIndex = 2
        Me.lblDDN.Text = "Data de Nascimento"
        '
        'lblSexo
        '
        Me.lblSexo.AutoSize = True
        Me.lblSexo.Location = New System.Drawing.Point(29, 166)
        Me.lblSexo.Name = "lblSexo"
        Me.lblSexo.Size = New System.Drawing.Size(39, 17)
        Me.lblSexo.TabIndex = 3
        Me.lblSexo.Text = "Sexo"
        '
        'lblCPF
        '
        Me.lblCPF.AutoSize = True
        Me.lblCPF.Location = New System.Drawing.Point(29, 205)
        Me.lblCPF.Name = "lblCPF"
        Me.lblCPF.Size = New System.Drawing.Size(34, 17)
        Me.lblCPF.TabIndex = 6
        Me.lblCPF.Text = "CPF"
        '
        'lblProfissao
        '
        Me.lblProfissao.AutoSize = True
        Me.lblProfissao.Location = New System.Drawing.Point(29, 239)
        Me.lblProfissao.Name = "lblProfissao"
        Me.lblProfissao.Size = New System.Drawing.Size(67, 17)
        Me.lblProfissao.TabIndex = 7
        Me.lblProfissao.Text = "Profissao"
        '
        'lblIDPessoas
        '
        Me.lblIDPessoas.AutoSize = True
        Me.lblIDPessoas.Location = New System.Drawing.Point(7, 310)
        Me.lblIDPessoas.Name = "lblIDPessoas"
        Me.lblIDPessoas.Size = New System.Drawing.Size(89, 17)
        Me.lblIDPessoas.TabIndex = 8
        Me.lblIDPessoas.Text = "lblIDPessoas"
        Me.lblIDPessoas.Visible = False
        '
        'txtNome
        '
        Me.txtNome.Location = New System.Drawing.Point(194, 51)
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Size = New System.Drawing.Size(152, 22)
        Me.txtNome.TabIndex = 9
        '
        'txtProfissao
        '
        Me.txtProfissao.Location = New System.Drawing.Point(194, 234)
        Me.txtProfissao.Name = "txtProfissao"
        Me.txtProfissao.Size = New System.Drawing.Size(152, 22)
        Me.txtProfissao.TabIndex = 10
        '
        'txtCPF
        '
        Me.txtCPF.Location = New System.Drawing.Point(194, 200)
        Me.txtCPF.Name = "txtCPF"
        Me.txtCPF.Size = New System.Drawing.Size(113, 22)
        Me.txtCPF.TabIndex = 11
        '
        'txtSobrenome
        '
        Me.txtSobrenome.Location = New System.Drawing.Point(194, 85)
        Me.txtSobrenome.Name = "txtSobrenome"
        Me.txtSobrenome.Size = New System.Drawing.Size(152, 22)
        Me.txtSobrenome.TabIndex = 14
        '
        'cmdOk
        '
        Me.cmdOk.Location = New System.Drawing.Point(382, 301)
        Me.cmdOk.Name = "cmdOk"
        Me.cmdOk.Size = New System.Drawing.Size(75, 23)
        Me.cmdOk.TabIndex = 15
        Me.cmdOk.Text = "Ok"
        Me.cmdOk.UseVisualStyleBackColor = True
        '
        'cmdCancel
        '
        Me.cmdCancel.Location = New System.Drawing.Point(484, 301)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(75, 23)
        Me.cmdCancel.TabIndex = 16
        Me.cmdCancel.Text = "Cancel"
        Me.cmdCancel.UseVisualStyleBackColor = True
        '
        'dateDDN
        '
        Me.dateDDN.Location = New System.Drawing.Point(194, 123)
        Me.dateDDN.Name = "dateDDN"
        Me.dateDDN.Size = New System.Drawing.Size(250, 22)
        Me.dateDDN.TabIndex = 17
        Me.dateDDN.Value = New Date(2019, 7, 11, 0, 0, 0, 0)
        '
        'comboSexo
        '
        Me.comboSexo.FormattingEnabled = True
        Me.comboSexo.Items.AddRange(New Object() {"Masculino", "Feminino"})
        Me.comboSexo.Location = New System.Drawing.Point(194, 163)
        Me.comboSexo.Name = "comboSexo"
        Me.comboSexo.Size = New System.Drawing.Size(113, 24)
        Me.comboSexo.TabIndex = 18
        '
        'cmdPrepall
        '
        Me.cmdPrepall.Location = New System.Drawing.Point(102, 305)
        Me.cmdPrepall.Name = "cmdPrepall"
        Me.cmdPrepall.Size = New System.Drawing.Size(75, 26)
        Me.cmdPrepall.TabIndex = 19
        Me.cmdPrepall.Text = "Prepall"
        Me.cmdPrepall.UseVisualStyleBackColor = True
        '
        'lblOnlyNumbers
        '
        Me.lblOnlyNumbers.AutoSize = True
        Me.lblOnlyNumbers.Location = New System.Drawing.Point(313, 203)
        Me.lblOnlyNumbers.Name = "lblOnlyNumbers"
        Me.lblOnlyNumbers.Size = New System.Drawing.Size(125, 17)
        Me.lblOnlyNumbers.TabIndex = 20
        Me.lblOnlyNumbers.Text = "Somente Numeros"
        Me.lblOnlyNumbers.Visible = False
        '
        'lblPessoas
        '
        Me.lblPessoas.AutoSize = True
        Me.lblPessoas.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPessoas.Location = New System.Drawing.Point(262, 9)
        Me.lblPessoas.Name = "lblPessoas"
        Me.lblPessoas.Size = New System.Drawing.Size(84, 25)
        Me.lblPessoas.TabIndex = 21
        Me.lblPessoas.Text = "Pessoa"
        '
        'lblCRM
        '
        Me.lblCRM.AutoSize = True
        Me.lblCRM.Location = New System.Drawing.Point(29, 272)
        Me.lblCRM.Name = "lblCRM"
        Me.lblCRM.Size = New System.Drawing.Size(38, 17)
        Me.lblCRM.TabIndex = 22
        Me.lblCRM.Text = "CRM"
        '
        'txtCRM
        '
        Me.txtCRM.Location = New System.Drawing.Point(194, 266)
        Me.txtCRM.Name = "txtCRM"
        Me.txtCRM.Size = New System.Drawing.Size(152, 22)
        Me.txtCRM.TabIndex = 23
        '
        'lblHoldCRM
        '
        Me.lblHoldCRM.AutoSize = True
        Me.lblHoldCRM.Location = New System.Drawing.Point(7, 293)
        Me.lblHoldCRM.Name = "lblHoldCRM"
        Me.lblHoldCRM.Size = New System.Drawing.Size(81, 17)
        Me.lblHoldCRM.TabIndex = 24
        Me.lblHoldCRM.Text = "lblHoldCRM"
        Me.lblHoldCRM.Visible = False
        '
        'frmPessoas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(599, 336)
        Me.Controls.Add(Me.lblHoldCRM)
        Me.Controls.Add(Me.txtCRM)
        Me.Controls.Add(Me.lblCRM)
        Me.Controls.Add(Me.lblPessoas)
        Me.Controls.Add(Me.lblOnlyNumbers)
        Me.Controls.Add(Me.cmdPrepall)
        Me.Controls.Add(Me.comboSexo)
        Me.Controls.Add(Me.dateDDN)
        Me.Controls.Add(Me.cmdCancel)
        Me.Controls.Add(Me.cmdOk)
        Me.Controls.Add(Me.txtSobrenome)
        Me.Controls.Add(Me.txtCPF)
        Me.Controls.Add(Me.txtProfissao)
        Me.Controls.Add(Me.txtNome)
        Me.Controls.Add(Me.lblIDPessoas)
        Me.Controls.Add(Me.lblProfissao)
        Me.Controls.Add(Me.lblCPF)
        Me.Controls.Add(Me.lblSexo)
        Me.Controls.Add(Me.lblDDN)
        Me.Controls.Add(Me.lblSobrenome)
        Me.Controls.Add(Me.lblNome)
        Me.Name = "frmPessoas"
        Me.Text = "frmPessoas"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblNome As Label
    Friend WithEvents lblSobrenome As Label
    Friend WithEvents lblDDN As Label
    Friend WithEvents lblSexo As Label
    Friend WithEvents lblCPF As Label
    Friend WithEvents lblProfissao As Label
    Friend WithEvents lblIDPessoas As Label
    Friend WithEvents txtNome As TextBox
    Friend WithEvents txtProfissao As TextBox
    Friend WithEvents txtCPF As TextBox
    Friend WithEvents txtSobrenome As TextBox
    Friend WithEvents cmdOk As Button
    Friend WithEvents cmdCancel As Button
    Friend WithEvents dateDDN As DateTimePicker
    Friend WithEvents comboSexo As ComboBox
    Friend WithEvents cmdPrepall As Button
    Friend WithEvents lblOnlyNumbers As Label
    Friend WithEvents lblPessoas As Label
    Friend WithEvents lblCRM As Label
    Friend WithEvents txtCRM As TextBox
    Friend WithEvents lblHoldCRM As Label
End Class
