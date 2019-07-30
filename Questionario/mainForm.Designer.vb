<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class mainForm
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
        Me.cmdPrepall = New System.Windows.Forms.Button()
        Me.lblIDQuestionario = New System.Windows.Forms.Label()
        Me.gridGrupos = New System.Windows.Forms.DataGridView()
        Me.gridPerguntas = New System.Windows.Forms.DataGridView()
        Me.lblIDGrupo = New System.Windows.Forms.Label()
        Me.lblIDPergunta = New System.Windows.Forms.Label()
        Me.btnAddPergunta = New System.Windows.Forms.Button()
        Me.btnEditPergunta = New System.Windows.Forms.Button()
        Me.btnDeletePergunta = New System.Windows.Forms.Button()
        Me.btnListGrupos = New System.Windows.Forms.Button()
        Me.lblIDOrdem = New System.Windows.Forms.Label()
        Me.cmdResponder = New System.Windows.Forms.Button()
        Me.gridQuestionario = New System.Windows.Forms.DataGridView()
        Me.btnAddQuest = New System.Windows.Forms.Button()
        Me.btnEditQuest = New System.Windows.Forms.Button()
        Me.btnDeleteQuest = New System.Windows.Forms.Button()
        Me.gridEnquete = New System.Windows.Forms.DataGridView()
        Me.cmdAddPessoas = New System.Windows.Forms.Button()
        Me.cmdEditPessoas = New System.Windows.Forms.Button()
        Me.cmdDeletePessoas = New System.Windows.Forms.Button()
        Me.pnlQuestionario = New System.Windows.Forms.Panel()
        Me.lblIDEnquete = New System.Windows.Forms.Label()
        Me.lblQuestionario = New System.Windows.Forms.Label()
        Me.pnlPessoas = New System.Windows.Forms.Panel()
        Me.lblPessoas = New System.Windows.Forms.Label()
        Me.pnlGrupos = New System.Windows.Forms.Panel()
        Me.lblIDOrdemHold = New System.Windows.Forms.Label()
        Me.lblPerguntas = New System.Windows.Forms.Label()
        Me.cmdPass = New System.Windows.Forms.Button()
        Me.lblGrupo = New System.Windows.Forms.Label()
        Me.gridListGrupo = New System.Windows.Forms.DataGridView()
        Me.cmdFilter = New System.Windows.Forms.Button()
        Me.pnlEnquetes = New System.Windows.Forms.Panel()
        Me.lblEnquetes = New System.Windows.Forms.Label()
        Me.tabQuestionario = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.UcList1 = New Questionario.ucList()
        CType(Me.gridGrupos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridPerguntas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridQuestionario, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridEnquete, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlQuestionario.SuspendLayout()
        Me.pnlPessoas.SuspendLayout()
        Me.pnlGrupos.SuspendLayout()
        CType(Me.gridListGrupo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlEnquetes.SuspendLayout()
        Me.tabQuestionario.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnUpdateGrupo
        '
        Me.btnUpdateGrupo.Location = New System.Drawing.Point(456, 51)
        Me.btnUpdateGrupo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnUpdateGrupo.Name = "btnUpdateGrupo"
        Me.btnUpdateGrupo.Size = New System.Drawing.Size(120, 46)
        Me.btnUpdateGrupo.TabIndex = 2
        Me.btnUpdateGrupo.Text = "Add New Group"
        Me.btnUpdateGrupo.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(593, 531)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(95, 49)
        Me.btnCancel.TabIndex = 4
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'cmdPrepall
        '
        Me.cmdPrepall.Location = New System.Drawing.Point(593, 6)
        Me.cmdPrepall.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmdPrepall.Name = "cmdPrepall"
        Me.cmdPrepall.Size = New System.Drawing.Size(95, 58)
        Me.cmdPrepall.TabIndex = 5
        Me.cmdPrepall.Text = "Prepall"
        Me.cmdPrepall.UseVisualStyleBackColor = True
        '
        'lblIDQuestionario
        '
        Me.lblIDQuestionario.AutoSize = True
        Me.lblIDQuestionario.Location = New System.Drawing.Point(425, 3)
        Me.lblIDQuestionario.Name = "lblIDQuestionario"
        Me.lblIDQuestionario.Size = New System.Drawing.Size(116, 17)
        Me.lblIDQuestionario.TabIndex = 6
        Me.lblIDQuestionario.Text = "lblIDQuestionario"
        Me.lblIDQuestionario.Visible = False
        '
        'gridGrupos
        '
        Me.gridGrupos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridGrupos.Location = New System.Drawing.Point(3, 51)
        Me.gridGrupos.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.gridGrupos.Name = "gridGrupos"
        Me.gridGrupos.RowTemplate.Height = 24
        Me.gridGrupos.Size = New System.Drawing.Size(220, 150)
        Me.gridGrupos.TabIndex = 7
        '
        'gridPerguntas
        '
        Me.gridPerguntas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridPerguntas.Location = New System.Drawing.Point(8, 242)
        Me.gridPerguntas.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.gridPerguntas.Name = "gridPerguntas"
        Me.gridPerguntas.RowTemplate.Height = 24
        Me.gridPerguntas.Size = New System.Drawing.Size(431, 151)
        Me.gridPerguntas.TabIndex = 8
        '
        'lblIDGrupo
        '
        Me.lblIDGrupo.AutoSize = True
        Me.lblIDGrupo.Location = New System.Drawing.Point(265, 6)
        Me.lblIDGrupo.Name = "lblIDGrupo"
        Me.lblIDGrupo.Size = New System.Drawing.Size(75, 17)
        Me.lblIDGrupo.TabIndex = 9
        Me.lblIDGrupo.Text = "lblIDGrupo"
        Me.lblIDGrupo.Visible = False
        '
        'lblIDPergunta
        '
        Me.lblIDPergunta.AutoSize = True
        Me.lblIDPergunta.Location = New System.Drawing.Point(37, 222)
        Me.lblIDPergunta.Name = "lblIDPergunta"
        Me.lblIDPergunta.Size = New System.Drawing.Size(93, 17)
        Me.lblIDPergunta.TabIndex = 10
        Me.lblIDPergunta.Text = "lblIDPergunta"
        Me.lblIDPergunta.Visible = False
        '
        'btnAddPergunta
        '
        Me.btnAddPergunta.Location = New System.Drawing.Point(461, 275)
        Me.btnAddPergunta.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnAddPergunta.Name = "btnAddPergunta"
        Me.btnAddPergunta.Size = New System.Drawing.Size(80, 30)
        Me.btnAddPergunta.TabIndex = 11
        Me.btnAddPergunta.Text = "Add"
        Me.btnAddPergunta.UseVisualStyleBackColor = True
        '
        'btnEditPergunta
        '
        Me.btnEditPergunta.Location = New System.Drawing.Point(461, 309)
        Me.btnEditPergunta.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnEditPergunta.Name = "btnEditPergunta"
        Me.btnEditPergunta.Size = New System.Drawing.Size(80, 30)
        Me.btnEditPergunta.TabIndex = 14
        Me.btnEditPergunta.Text = "Edit"
        Me.btnEditPergunta.UseVisualStyleBackColor = True
        '
        'btnDeletePergunta
        '
        Me.btnDeletePergunta.Location = New System.Drawing.Point(461, 352)
        Me.btnDeletePergunta.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnDeletePergunta.Name = "btnDeletePergunta"
        Me.btnDeletePergunta.Size = New System.Drawing.Size(80, 30)
        Me.btnDeletePergunta.TabIndex = 15
        Me.btnDeletePergunta.Text = "Delete"
        Me.btnDeletePergunta.UseVisualStyleBackColor = True
        '
        'btnListGrupos
        '
        Me.btnListGrupos.Location = New System.Drawing.Point(456, 143)
        Me.btnListGrupos.Name = "btnListGrupos"
        Me.btnListGrupos.Size = New System.Drawing.Size(120, 42)
        Me.btnListGrupos.TabIndex = 20
        Me.btnListGrupos.Text = "ListGrupos"
        Me.btnListGrupos.UseVisualStyleBackColor = True
        '
        'lblIDOrdem
        '
        Me.lblIDOrdem.AutoSize = True
        Me.lblIDOrdem.Location = New System.Drawing.Point(5, 207)
        Me.lblIDOrdem.Name = "lblIDOrdem"
        Me.lblIDOrdem.Size = New System.Drawing.Size(78, 17)
        Me.lblIDOrdem.TabIndex = 21
        Me.lblIDOrdem.Text = "lblIDOrdem"
        Me.lblIDOrdem.Visible = False
        '
        'cmdResponder
        '
        Me.cmdResponder.Location = New System.Drawing.Point(448, 40)
        Me.cmdResponder.Name = "cmdResponder"
        Me.cmdResponder.Size = New System.Drawing.Size(75, 34)
        Me.cmdResponder.TabIndex = 22
        Me.cmdResponder.Text = "Iniciar"
        Me.cmdResponder.UseVisualStyleBackColor = True
        '
        'gridQuestionario
        '
        Me.gridQuestionario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridQuestionario.Location = New System.Drawing.Point(4, 40)
        Me.gridQuestionario.Name = "gridQuestionario"
        Me.gridQuestionario.RowTemplate.Height = 24
        Me.gridQuestionario.Size = New System.Drawing.Size(435, 121)
        Me.gridQuestionario.TabIndex = 23
        '
        'btnAddQuest
        '
        Me.btnAddQuest.Location = New System.Drawing.Point(448, 80)
        Me.btnAddQuest.Name = "btnAddQuest"
        Me.btnAddQuest.Size = New System.Drawing.Size(75, 23)
        Me.btnAddQuest.TabIndex = 24
        Me.btnAddQuest.Text = "Add"
        Me.btnAddQuest.UseVisualStyleBackColor = True
        '
        'btnEditQuest
        '
        Me.btnEditQuest.Location = New System.Drawing.Point(448, 109)
        Me.btnEditQuest.Name = "btnEditQuest"
        Me.btnEditQuest.Size = New System.Drawing.Size(75, 23)
        Me.btnEditQuest.TabIndex = 25
        Me.btnEditQuest.Text = "Edit"
        Me.btnEditQuest.UseVisualStyleBackColor = True
        '
        'btnDeleteQuest
        '
        Me.btnDeleteQuest.Location = New System.Drawing.Point(448, 138)
        Me.btnDeleteQuest.Name = "btnDeleteQuest"
        Me.btnDeleteQuest.Size = New System.Drawing.Size(75, 23)
        Me.btnDeleteQuest.TabIndex = 26
        Me.btnDeleteQuest.Text = "Delete"
        Me.btnDeleteQuest.UseVisualStyleBackColor = True
        '
        'gridEnquete
        '
        Me.gridEnquete.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridEnquete.Location = New System.Drawing.Point(37, 35)
        Me.gridEnquete.Name = "gridEnquete"
        Me.gridEnquete.RowTemplate.Height = 24
        Me.gridEnquete.Size = New System.Drawing.Size(438, 327)
        Me.gridEnquete.TabIndex = 27
        '
        'cmdAddPessoas
        '
        Me.cmdAddPessoas.Location = New System.Drawing.Point(593, 43)
        Me.cmdAddPessoas.Name = "cmdAddPessoas"
        Me.cmdAddPessoas.Size = New System.Drawing.Size(68, 23)
        Me.cmdAddPessoas.TabIndex = 28
        Me.cmdAddPessoas.Text = "Add"
        Me.cmdAddPessoas.UseVisualStyleBackColor = True
        '
        'cmdEditPessoas
        '
        Me.cmdEditPessoas.Location = New System.Drawing.Point(593, 72)
        Me.cmdEditPessoas.Name = "cmdEditPessoas"
        Me.cmdEditPessoas.Size = New System.Drawing.Size(68, 23)
        Me.cmdEditPessoas.TabIndex = 29
        Me.cmdEditPessoas.Text = "Edit"
        Me.cmdEditPessoas.UseVisualStyleBackColor = True
        '
        'cmdDeletePessoas
        '
        Me.cmdDeletePessoas.Location = New System.Drawing.Point(593, 101)
        Me.cmdDeletePessoas.Name = "cmdDeletePessoas"
        Me.cmdDeletePessoas.Size = New System.Drawing.Size(68, 23)
        Me.cmdDeletePessoas.TabIndex = 30
        Me.cmdDeletePessoas.Text = "Delete"
        Me.cmdDeletePessoas.UseVisualStyleBackColor = True
        '
        'pnlQuestionario
        '
        Me.pnlQuestionario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlQuestionario.Controls.Add(Me.lblIDEnquete)
        Me.pnlQuestionario.Controls.Add(Me.lblQuestionario)
        Me.pnlQuestionario.Controls.Add(Me.btnDeleteQuest)
        Me.pnlQuestionario.Controls.Add(Me.cmdResponder)
        Me.pnlQuestionario.Controls.Add(Me.btnEditQuest)
        Me.pnlQuestionario.Controls.Add(Me.btnAddQuest)
        Me.pnlQuestionario.Controls.Add(Me.gridQuestionario)
        Me.pnlQuestionario.Controls.Add(Me.lblIDQuestionario)
        Me.pnlQuestionario.Location = New System.Drawing.Point(6, 6)
        Me.pnlQuestionario.Name = "pnlQuestionario"
        Me.pnlQuestionario.Size = New System.Drawing.Size(581, 166)
        Me.pnlQuestionario.TabIndex = 32
        '
        'lblIDEnquete
        '
        Me.lblIDEnquete.AutoSize = True
        Me.lblIDEnquete.Location = New System.Drawing.Point(324, 3)
        Me.lblIDEnquete.Name = "lblIDEnquete"
        Me.lblIDEnquete.Size = New System.Drawing.Size(88, 17)
        Me.lblIDEnquete.TabIndex = 28
        Me.lblIDEnquete.Text = "lblIDEnquete"
        Me.lblIDEnquete.Visible = False
        '
        'lblQuestionario
        '
        Me.lblQuestionario.AutoSize = True
        Me.lblQuestionario.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuestionario.Location = New System.Drawing.Point(172, 8)
        Me.lblQuestionario.Name = "lblQuestionario"
        Me.lblQuestionario.Size = New System.Drawing.Size(146, 25)
        Me.lblQuestionario.TabIndex = 27
        Me.lblQuestionario.Text = "Questionarios"
        '
        'pnlPessoas
        '
        Me.pnlPessoas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlPessoas.Controls.Add(Me.UcList1)
        Me.pnlPessoas.Controls.Add(Me.lblPessoas)
        Me.pnlPessoas.Controls.Add(Me.cmdDeletePessoas)
        Me.pnlPessoas.Controls.Add(Me.cmdEditPessoas)
        Me.pnlPessoas.Controls.Add(Me.cmdAddPessoas)
        Me.pnlPessoas.Location = New System.Drawing.Point(3, 6)
        Me.pnlPessoas.Name = "pnlPessoas"
        Me.pnlPessoas.Size = New System.Drawing.Size(669, 371)
        Me.pnlPessoas.TabIndex = 33
        '
        'lblPessoas
        '
        Me.lblPessoas.AutoSize = True
        Me.lblPessoas.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPessoas.Location = New System.Drawing.Point(210, 2)
        Me.lblPessoas.Name = "lblPessoas"
        Me.lblPessoas.Size = New System.Drawing.Size(95, 25)
        Me.lblPessoas.TabIndex = 28
        Me.lblPessoas.Text = "Pessoas"
        '
        'pnlGrupos
        '
        Me.pnlGrupos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlGrupos.Controls.Add(Me.btnDeletePergunta)
        Me.pnlGrupos.Controls.Add(Me.lblIDOrdemHold)
        Me.pnlGrupos.Controls.Add(Me.btnEditPergunta)
        Me.pnlGrupos.Controls.Add(Me.lblIDGrupo)
        Me.pnlGrupos.Controls.Add(Me.lblPerguntas)
        Me.pnlGrupos.Controls.Add(Me.btnAddPergunta)
        Me.pnlGrupos.Controls.Add(Me.cmdPass)
        Me.pnlGrupos.Controls.Add(Me.lblIDPergunta)
        Me.pnlGrupos.Controls.Add(Me.lblIDOrdem)
        Me.pnlGrupos.Controls.Add(Me.lblGrupo)
        Me.pnlGrupos.Controls.Add(Me.gridPerguntas)
        Me.pnlGrupos.Controls.Add(Me.gridListGrupo)
        Me.pnlGrupos.Controls.Add(Me.gridGrupos)
        Me.pnlGrupos.Controls.Add(Me.btnListGrupos)
        Me.pnlGrupos.Controls.Add(Me.btnUpdateGrupo)
        Me.pnlGrupos.Location = New System.Drawing.Point(6, 178)
        Me.pnlGrupos.Name = "pnlGrupos"
        Me.pnlGrupos.Size = New System.Drawing.Size(581, 403)
        Me.pnlGrupos.TabIndex = 34
        '
        'lblIDOrdemHold
        '
        Me.lblIDOrdemHold.AutoSize = True
        Me.lblIDOrdemHold.Location = New System.Drawing.Point(332, 203)
        Me.lblIDOrdemHold.Name = "lblIDOrdemHold"
        Me.lblIDOrdemHold.Size = New System.Drawing.Size(107, 17)
        Me.lblIDOrdemHold.TabIndex = 39
        Me.lblIDOrdemHold.Text = "lblIDOrdemHold"
        Me.lblIDOrdemHold.Visible = False
        '
        'lblPerguntas
        '
        Me.lblPerguntas.AutoSize = True
        Me.lblPerguntas.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPerguntas.Location = New System.Drawing.Point(177, 215)
        Me.lblPerguntas.Name = "lblPerguntas"
        Me.lblPerguntas.Size = New System.Drawing.Size(110, 25)
        Me.lblPerguntas.TabIndex = 22
        Me.lblPerguntas.Text = "Perguntas"
        '
        'cmdPass
        '
        Me.cmdPass.Enabled = False
        Me.cmdPass.Location = New System.Drawing.Point(456, 102)
        Me.cmdPass.Name = "cmdPass"
        Me.cmdPass.Size = New System.Drawing.Size(120, 35)
        Me.cmdPass.TabIndex = 23
        Me.cmdPass.Text = "<<<"
        Me.cmdPass.UseVisualStyleBackColor = True
        '
        'lblGrupo
        '
        Me.lblGrupo.AutoSize = True
        Me.lblGrupo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGrupo.Location = New System.Drawing.Point(187, -2)
        Me.lblGrupo.Name = "lblGrupo"
        Me.lblGrupo.Size = New System.Drawing.Size(82, 25)
        Me.lblGrupo.TabIndex = 22
        Me.lblGrupo.Text = "Grupos"
        '
        'gridListGrupo
        '
        Me.gridListGrupo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridListGrupo.Location = New System.Drawing.Point(229, 50)
        Me.gridListGrupo.Name = "gridListGrupo"
        Me.gridListGrupo.RowTemplate.Height = 24
        Me.gridListGrupo.Size = New System.Drawing.Size(210, 150)
        Me.gridListGrupo.TabIndex = 21
        '
        'cmdFilter
        '
        Me.cmdFilter.Location = New System.Drawing.Point(507, 3)
        Me.cmdFilter.Name = "cmdFilter"
        Me.cmdFilter.Size = New System.Drawing.Size(75, 23)
        Me.cmdFilter.TabIndex = 37
        Me.cmdFilter.Text = "Filter"
        Me.cmdFilter.UseVisualStyleBackColor = True
        '
        'pnlEnquetes
        '
        Me.pnlEnquetes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlEnquetes.Controls.Add(Me.lblEnquetes)
        Me.pnlEnquetes.Controls.Add(Me.cmdFilter)
        Me.pnlEnquetes.Controls.Add(Me.gridEnquete)
        Me.pnlEnquetes.Location = New System.Drawing.Point(53, 6)
        Me.pnlEnquetes.Name = "pnlEnquetes"
        Me.pnlEnquetes.Size = New System.Drawing.Size(586, 410)
        Me.pnlEnquetes.TabIndex = 38
        '
        'lblEnquetes
        '
        Me.lblEnquetes.AutoSize = True
        Me.lblEnquetes.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEnquetes.Location = New System.Drawing.Point(212, 7)
        Me.lblEnquetes.Name = "lblEnquetes"
        Me.lblEnquetes.Size = New System.Drawing.Size(103, 25)
        Me.lblEnquetes.TabIndex = 38
        Me.lblEnquetes.Text = "Enquetes"
        '
        'tabQuestionario
        '
        Me.tabQuestionario.Controls.Add(Me.TabPage1)
        Me.tabQuestionario.Controls.Add(Me.TabPage2)
        Me.tabQuestionario.Controls.Add(Me.TabPage3)
        Me.tabQuestionario.Location = New System.Drawing.Point(3, 3)
        Me.tabQuestionario.Name = "tabQuestionario"
        Me.tabQuestionario.SelectedIndex = 0
        Me.tabQuestionario.Size = New System.Drawing.Size(702, 616)
        Me.tabQuestionario.TabIndex = 39
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.pnlQuestionario)
        Me.TabPage1.Controls.Add(Me.cmdPrepall)
        Me.TabPage1.Controls.Add(Me.pnlGrupos)
        Me.TabPage1.Controls.Add(Me.btnCancel)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(694, 587)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Questionario"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.pnlPessoas)
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(682, 604)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Pessoas"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.pnlEnquetes)
        Me.TabPage3.Location = New System.Drawing.Point(4, 25)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(682, 604)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Enquete"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'UcList1
        '
        Me.UcList1.Caption = Nothing
        Me.UcList1.Location = New System.Drawing.Point(6, 30)
        Me.UcList1.Name = "UcList1"
        Me.UcList1.pkField = Nothing
        Me.UcList1.pkVal = Nothing
        Me.UcList1.sayField = Nothing
        Me.UcList1.Size = New System.Drawing.Size(581, 320)
        Me.UcList1.TabIndex = 40
        Me.UcList1.tbName = Nothing
        '
        'mainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(717, 620)
        Me.Controls.Add(Me.tabQuestionario)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "mainForm"
        Me.Text = "mainForm"
        CType(Me.gridGrupos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridPerguntas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridQuestionario, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridEnquete, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlQuestionario.ResumeLayout(False)
        Me.pnlQuestionario.PerformLayout()
        Me.pnlPessoas.ResumeLayout(False)
        Me.pnlPessoas.PerformLayout()
        Me.pnlGrupos.ResumeLayout(False)
        Me.pnlGrupos.PerformLayout()
        CType(Me.gridListGrupo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlEnquetes.ResumeLayout(False)
        Me.pnlEnquetes.PerformLayout()
        Me.tabQuestionario.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnUpdateGrupo As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents cmdPrepall As Button
    Friend WithEvents lblIDQuestionario As Label
    Friend WithEvents gridGrupos As DataGridView
    Friend WithEvents gridPerguntas As DataGridView
    Friend WithEvents lblIDGrupo As Label
    Friend WithEvents lblIDPergunta As Label
    Friend WithEvents btnAddPergunta As Button
    Friend WithEvents btnEditPergunta As Button
    Friend WithEvents btnDeletePergunta As Button
    Friend WithEvents btnListGrupos As Button
    Friend WithEvents lblIDOrdem As Label
    Friend WithEvents cmdResponder As Button
    Friend WithEvents gridQuestionario As DataGridView
    Friend WithEvents btnAddQuest As Button
    Friend WithEvents btnEditQuest As Button
    Friend WithEvents btnDeleteQuest As Button
    Friend WithEvents gridEnquete As DataGridView
    Friend WithEvents cmdAddPessoas As Button
    Friend WithEvents cmdEditPessoas As Button
    Friend WithEvents cmdDeletePessoas As Button
    Friend WithEvents pnlQuestionario As Panel
    Friend WithEvents pnlPessoas As Panel
    Friend WithEvents lblQuestionario As Label
    Friend WithEvents pnlGrupos As Panel
    Friend WithEvents lblPessoas As Label
    Friend WithEvents cmdFilter As Button
    Friend WithEvents lblIDEnquete As Label
    Friend WithEvents pnlEnquetes As Panel
    Friend WithEvents lblEnquetes As Label
    Friend WithEvents gridListGrupo As DataGridView
    Friend WithEvents lblGrupo As Label
    Friend WithEvents cmdPass As Button
    Friend WithEvents lblPerguntas As Label
    Friend WithEvents lblIDOrdemHold As Label
    Friend WithEvents tabQuestionario As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents UcList1 As ucList
End Class
