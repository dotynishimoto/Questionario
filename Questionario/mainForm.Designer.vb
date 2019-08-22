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
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend2 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.pnlEnquetes = New System.Windows.Forms.Panel()
        Me.CMDIsoLentesRigidas = New System.Windows.Forms.Button()
        Me.cmd2Tables = New System.Windows.Forms.Button()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.UcListEnquete = New Questionario.ucList()
        Me.cmdCreateTable = New System.Windows.Forms.Button()
        Me.cmdCreateChart = New System.Windows.Forms.Button()
        Me.lblEnquetes = New System.Windows.Forms.Label()
        Me.cmdIsoPerSexo = New System.Windows.Forms.Button()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.pnlPessoas = New System.Windows.Forms.Panel()
        Me.UcList1 = New Questionario.ucList()
        Me.lblPessoas = New System.Windows.Forms.Label()
        Me.cmdDeletePessoas = New System.Windows.Forms.Button()
        Me.cmdEditPessoas = New System.Windows.Forms.Button()
        Me.cmdAddPessoas = New System.Windows.Forms.Button()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.pnlQuestionario = New System.Windows.Forms.Panel()
        Me.lblIDEnquete = New System.Windows.Forms.Label()
        Me.lblQuestionario = New System.Windows.Forms.Label()
        Me.btnDeleteQuest = New System.Windows.Forms.Button()
        Me.cmdResponder = New System.Windows.Forms.Button()
        Me.btnEditQuest = New System.Windows.Forms.Button()
        Me.btnAddQuest = New System.Windows.Forms.Button()
        Me.gridQuestionario = New System.Windows.Forms.DataGridView()
        Me.lblIDQuestionario = New System.Windows.Forms.Label()
        Me.cmdPrepall = New System.Windows.Forms.Button()
        Me.pnlGrupos = New System.Windows.Forms.Panel()
        Me.cmdEditGrupo = New System.Windows.Forms.Button()
        Me.cmdPassPerguntas = New System.Windows.Forms.Button()
        Me.cmdListPerguntas = New System.Windows.Forms.Button()
        Me.gridListPerguntas = New System.Windows.Forms.DataGridView()
        Me.btnDeletePergunta = New System.Windows.Forms.Button()
        Me.lblIDOrdemHold = New System.Windows.Forms.Label()
        Me.btnEditPergunta = New System.Windows.Forms.Button()
        Me.lblIDGrupo = New System.Windows.Forms.Label()
        Me.lblPerguntas = New System.Windows.Forms.Label()
        Me.btnAddPergunta = New System.Windows.Forms.Button()
        Me.cmdPass = New System.Windows.Forms.Button()
        Me.lblIDPergunta = New System.Windows.Forms.Label()
        Me.lblIDOrdem = New System.Windows.Forms.Label()
        Me.lblGrupo = New System.Windows.Forms.Label()
        Me.gridPerguntas = New System.Windows.Forms.DataGridView()
        Me.gridListGrupo = New System.Windows.Forms.DataGridView()
        Me.gridGrupos = New System.Windows.Forms.DataGridView()
        Me.btnListGrupos = New System.Windows.Forms.Button()
        Me.btnAddGrupo = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.tabQuestionario = New System.Windows.Forms.TabControl()
        Me.TabPage3.SuspendLayout()
        Me.pnlEnquetes.SuspendLayout()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.pnlPessoas.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.pnlQuestionario.SuspendLayout()
        CType(Me.gridQuestionario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlGrupos.SuspendLayout()
        CType(Me.gridListPerguntas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridPerguntas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridListGrupo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridGrupos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabQuestionario.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.pnlEnquetes)
        Me.TabPage3.Location = New System.Drawing.Point(4, 25)
        Me.TabPage3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabPage3.Size = New System.Drawing.Size(693, 586)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Enquete"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'pnlEnquetes
        '
        Me.pnlEnquetes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlEnquetes.Controls.Add(Me.CMDIsoLentesRigidas)
        Me.pnlEnquetes.Controls.Add(Me.cmd2Tables)
        Me.pnlEnquetes.Controls.Add(Me.Chart1)
        Me.pnlEnquetes.Controls.Add(Me.UcListEnquete)
        Me.pnlEnquetes.Controls.Add(Me.cmdCreateTable)
        Me.pnlEnquetes.Controls.Add(Me.cmdCreateChart)
        Me.pnlEnquetes.Controls.Add(Me.lblEnquetes)
        Me.pnlEnquetes.Controls.Add(Me.cmdIsoPerSexo)
        Me.pnlEnquetes.Location = New System.Drawing.Point(5, 6)
        Me.pnlEnquetes.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pnlEnquetes.Name = "pnlEnquetes"
        Me.pnlEnquetes.Size = New System.Drawing.Size(682, 545)
        Me.pnlEnquetes.TabIndex = 38
        '
        'CMDIsoLentesRigidas
        '
        Me.CMDIsoLentesRigidas.Location = New System.Drawing.Point(139, 494)
        Me.CMDIsoLentesRigidas.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CMDIsoLentesRigidas.Name = "CMDIsoLentesRigidas"
        Me.CMDIsoLentesRigidas.Size = New System.Drawing.Size(109, 37)
        Me.CMDIsoLentesRigidas.TabIndex = 44
        Me.CMDIsoLentesRigidas.Text = "IsoLentesRigidas"
        Me.CMDIsoLentesRigidas.UseVisualStyleBackColor = True
        '
        'cmd2Tables
        '
        Me.cmd2Tables.Location = New System.Drawing.Point(12, 494)
        Me.cmd2Tables.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmd2Tables.Name = "cmd2Tables"
        Me.cmd2Tables.Size = New System.Drawing.Size(107, 37)
        Me.cmd2Tables.TabIndex = 43
        Me.cmd2Tables.Text = "2 Table PDF"
        Me.cmd2Tables.UseVisualStyleBackColor = True
        '
        'Chart1
        '
        ChartArea2.AxisX.Interval = 1.0R
        ChartArea2.AxisX.IsLabelAutoFit = False
        ChartArea2.AxisX.LabelStyle.Angle = -90
        ChartArea2.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea2)
        Legend2.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend2)
        Me.Chart1.Location = New System.Drawing.Point(25, 231)
        Me.Chart1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Chart1.Name = "Chart1"
        Series2.ChartArea = "ChartArea1"
        Series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie
        Series2.IsValueShownAsLabel = True
        Series2.Legend = "Legend1"
        Series2.Name = "Series1"
        Me.Chart1.Series.Add(Series2)
        Me.Chart1.Size = New System.Drawing.Size(652, 256)
        Me.Chart1.TabIndex = 42
        Me.Chart1.Text = "Chart1"
        '
        'UcListEnquete
        '
        Me.UcListEnquete.Caption = Nothing
        Me.UcListEnquete.Location = New System.Drawing.Point(12, 34)
        Me.UcListEnquete.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.UcListEnquete.Name = "UcListEnquete"
        Me.UcListEnquete.pkField = Nothing
        Me.UcListEnquete.pkVal = Nothing
        Me.UcListEnquete.sayField = Nothing
        Me.UcListEnquete.Size = New System.Drawing.Size(648, 432)
        Me.UcListEnquete.TabIndex = 41
        Me.UcListEnquete.tbName = Nothing
        '
        'cmdCreateTable
        '
        Me.cmdCreateTable.Location = New System.Drawing.Point(392, 494)
        Me.cmdCreateTable.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmdCreateTable.Name = "cmdCreateTable"
        Me.cmdCreateTable.Size = New System.Drawing.Size(141, 37)
        Me.cmdCreateTable.TabIndex = 40
        Me.cmdCreateTable.Text = "Create PDF Table"
        Me.cmdCreateTable.UseVisualStyleBackColor = True
        '
        'cmdCreateChart
        '
        Me.cmdCreateChart.Location = New System.Drawing.Point(540, 494)
        Me.cmdCreateChart.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmdCreateChart.Name = "cmdCreateChart"
        Me.cmdCreateChart.Size = New System.Drawing.Size(120, 37)
        Me.cmdCreateChart.TabIndex = 39
        Me.cmdCreateChart.Text = "Create Chart"
        Me.cmdCreateChart.UseVisualStyleBackColor = True
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
        'cmdIsoPerSexo
        '
        Me.cmdIsoPerSexo.Location = New System.Drawing.Point(277, 494)
        Me.cmdIsoPerSexo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmdIsoPerSexo.Name = "cmdIsoPerSexo"
        Me.cmdIsoPerSexo.Size = New System.Drawing.Size(109, 37)
        Me.cmdIsoPerSexo.TabIndex = 37
        Me.cmdIsoPerSexo.Text = "IsoPerSexo"
        Me.cmdIsoPerSexo.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.pnlPessoas)
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabPage2.Size = New System.Drawing.Size(693, 586)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Pessoas"
        Me.TabPage2.UseVisualStyleBackColor = True
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
        Me.pnlPessoas.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pnlPessoas.Name = "pnlPessoas"
        Me.pnlPessoas.Size = New System.Drawing.Size(685, 574)
        Me.pnlPessoas.TabIndex = 33
        '
        'UcList1
        '
        Me.UcList1.Caption = Nothing
        Me.UcList1.Location = New System.Drawing.Point(5, 30)
        Me.UcList1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.UcList1.Name = "UcList1"
        Me.UcList1.pkField = Nothing
        Me.UcList1.pkVal = Nothing
        Me.UcList1.sayField = Nothing
        Me.UcList1.Size = New System.Drawing.Size(581, 503)
        Me.UcList1.TabIndex = 40
        Me.UcList1.tbName = Nothing
        '
        'lblPessoas
        '
        Me.lblPessoas.AutoSize = True
        Me.lblPessoas.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPessoas.Location = New System.Drawing.Point(211, 2)
        Me.lblPessoas.Name = "lblPessoas"
        Me.lblPessoas.Size = New System.Drawing.Size(95, 25)
        Me.lblPessoas.TabIndex = 28
        Me.lblPessoas.Text = "Pessoas"
        '
        'cmdDeletePessoas
        '
        Me.cmdDeletePessoas.Location = New System.Drawing.Point(593, 101)
        Me.cmdDeletePessoas.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmdDeletePessoas.Name = "cmdDeletePessoas"
        Me.cmdDeletePessoas.Size = New System.Drawing.Size(68, 23)
        Me.cmdDeletePessoas.TabIndex = 30
        Me.cmdDeletePessoas.Text = "Delete"
        Me.cmdDeletePessoas.UseVisualStyleBackColor = True
        '
        'cmdEditPessoas
        '
        Me.cmdEditPessoas.Location = New System.Drawing.Point(593, 71)
        Me.cmdEditPessoas.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmdEditPessoas.Name = "cmdEditPessoas"
        Me.cmdEditPessoas.Size = New System.Drawing.Size(68, 23)
        Me.cmdEditPessoas.TabIndex = 29
        Me.cmdEditPessoas.Text = "Edit"
        Me.cmdEditPessoas.UseVisualStyleBackColor = True
        '
        'cmdAddPessoas
        '
        Me.cmdAddPessoas.Location = New System.Drawing.Point(593, 43)
        Me.cmdAddPessoas.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmdAddPessoas.Name = "cmdAddPessoas"
        Me.cmdAddPessoas.Size = New System.Drawing.Size(68, 23)
        Me.cmdAddPessoas.TabIndex = 28
        Me.cmdAddPessoas.Text = "Add"
        Me.cmdAddPessoas.UseVisualStyleBackColor = True
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.pnlQuestionario)
        Me.TabPage1.Controls.Add(Me.cmdPrepall)
        Me.TabPage1.Controls.Add(Me.pnlGrupos)
        Me.TabPage1.Controls.Add(Me.btnCancel)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabPage1.Size = New System.Drawing.Size(693, 586)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Questionario"
        Me.TabPage1.UseVisualStyleBackColor = True
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
        Me.pnlQuestionario.Location = New System.Drawing.Point(5, 6)
        Me.pnlQuestionario.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pnlQuestionario.Name = "pnlQuestionario"
        Me.pnlQuestionario.Size = New System.Drawing.Size(581, 166)
        Me.pnlQuestionario.TabIndex = 32
        '
        'lblIDEnquete
        '
        Me.lblIDEnquete.AutoSize = True
        Me.lblIDEnquete.Location = New System.Drawing.Point(324, 2)
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
        Me.lblQuestionario.Location = New System.Drawing.Point(172, 7)
        Me.lblQuestionario.Name = "lblQuestionario"
        Me.lblQuestionario.Size = New System.Drawing.Size(146, 25)
        Me.lblQuestionario.TabIndex = 27
        Me.lblQuestionario.Text = "Questionarios"
        '
        'btnDeleteQuest
        '
        Me.btnDeleteQuest.Location = New System.Drawing.Point(448, 138)
        Me.btnDeleteQuest.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnDeleteQuest.Name = "btnDeleteQuest"
        Me.btnDeleteQuest.Size = New System.Drawing.Size(75, 23)
        Me.btnDeleteQuest.TabIndex = 26
        Me.btnDeleteQuest.Text = "Delete"
        Me.btnDeleteQuest.UseVisualStyleBackColor = True
        '
        'cmdResponder
        '
        Me.cmdResponder.Location = New System.Drawing.Point(448, 39)
        Me.cmdResponder.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmdResponder.Name = "cmdResponder"
        Me.cmdResponder.Size = New System.Drawing.Size(75, 34)
        Me.cmdResponder.TabIndex = 22
        Me.cmdResponder.Text = "Iniciar"
        Me.cmdResponder.UseVisualStyleBackColor = True
        '
        'btnEditQuest
        '
        Me.btnEditQuest.Location = New System.Drawing.Point(448, 110)
        Me.btnEditQuest.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnEditQuest.Name = "btnEditQuest"
        Me.btnEditQuest.Size = New System.Drawing.Size(75, 23)
        Me.btnEditQuest.TabIndex = 25
        Me.btnEditQuest.Text = "Edit"
        Me.btnEditQuest.UseVisualStyleBackColor = True
        '
        'btnAddQuest
        '
        Me.btnAddQuest.Location = New System.Drawing.Point(448, 80)
        Me.btnAddQuest.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnAddQuest.Name = "btnAddQuest"
        Me.btnAddQuest.Size = New System.Drawing.Size(75, 23)
        Me.btnAddQuest.TabIndex = 24
        Me.btnAddQuest.Text = "Add"
        Me.btnAddQuest.UseVisualStyleBackColor = True
        '
        'gridQuestionario
        '
        Me.gridQuestionario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridQuestionario.Location = New System.Drawing.Point(4, 39)
        Me.gridQuestionario.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.gridQuestionario.Name = "gridQuestionario"
        Me.gridQuestionario.RowTemplate.Height = 24
        Me.gridQuestionario.Size = New System.Drawing.Size(435, 121)
        Me.gridQuestionario.TabIndex = 23
        '
        'lblIDQuestionario
        '
        Me.lblIDQuestionario.AutoSize = True
        Me.lblIDQuestionario.Location = New System.Drawing.Point(425, 2)
        Me.lblIDQuestionario.Name = "lblIDQuestionario"
        Me.lblIDQuestionario.Size = New System.Drawing.Size(116, 17)
        Me.lblIDQuestionario.TabIndex = 6
        Me.lblIDQuestionario.Text = "lblIDQuestionario"
        Me.lblIDQuestionario.Visible = False
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
        'pnlGrupos
        '
        Me.pnlGrupos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlGrupos.Controls.Add(Me.cmdEditGrupo)
        Me.pnlGrupos.Controls.Add(Me.cmdPassPerguntas)
        Me.pnlGrupos.Controls.Add(Me.cmdListPerguntas)
        Me.pnlGrupos.Controls.Add(Me.gridListPerguntas)
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
        Me.pnlGrupos.Controls.Add(Me.btnAddGrupo)
        Me.pnlGrupos.Location = New System.Drawing.Point(5, 178)
        Me.pnlGrupos.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pnlGrupos.Name = "pnlGrupos"
        Me.pnlGrupos.Size = New System.Drawing.Size(581, 403)
        Me.pnlGrupos.TabIndex = 34
        '
        'cmdEditGrupo
        '
        Me.cmdEditGrupo.Location = New System.Drawing.Point(461, 143)
        Me.cmdEditGrupo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmdEditGrupo.Name = "cmdEditGrupo"
        Me.cmdEditGrupo.Size = New System.Drawing.Size(85, 36)
        Me.cmdEditGrupo.TabIndex = 29
        Me.cmdEditGrupo.Text = "Edit"
        Me.cmdEditGrupo.UseVisualStyleBackColor = True
        '
        'cmdPassPerguntas
        '
        Me.cmdPassPerguntas.Location = New System.Drawing.Point(464, 257)
        Me.cmdPassPerguntas.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmdPassPerguntas.Name = "cmdPassPerguntas"
        Me.cmdPassPerguntas.Size = New System.Drawing.Size(77, 34)
        Me.cmdPassPerguntas.TabIndex = 42
        Me.cmdPassPerguntas.Text = "<<<"
        Me.cmdPassPerguntas.UseVisualStyleBackColor = True
        '
        'cmdListPerguntas
        '
        Me.cmdListPerguntas.Location = New System.Drawing.Point(464, 222)
        Me.cmdListPerguntas.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmdListPerguntas.Name = "cmdListPerguntas"
        Me.cmdListPerguntas.Size = New System.Drawing.Size(77, 31)
        Me.cmdListPerguntas.TabIndex = 41
        Me.cmdListPerguntas.Text = "ListPerguntas"
        Me.cmdListPerguntas.UseVisualStyleBackColor = True
        '
        'gridListPerguntas
        '
        Me.gridListPerguntas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridListPerguntas.Location = New System.Drawing.Point(229, 242)
        Me.gridListPerguntas.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.gridListPerguntas.Name = "gridListPerguntas"
        Me.gridListPerguntas.RowTemplate.Height = 24
        Me.gridListPerguntas.Size = New System.Drawing.Size(211, 150)
        Me.gridListPerguntas.TabIndex = 40
        '
        'btnDeletePergunta
        '
        Me.btnDeletePergunta.Location = New System.Drawing.Point(461, 363)
        Me.btnDeletePergunta.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnDeletePergunta.Name = "btnDeletePergunta"
        Me.btnDeletePergunta.Size = New System.Drawing.Size(80, 30)
        Me.btnDeletePergunta.TabIndex = 15
        Me.btnDeletePergunta.Text = "Delete"
        Me.btnDeletePergunta.UseVisualStyleBackColor = True
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
        'btnEditPergunta
        '
        Me.btnEditPergunta.Location = New System.Drawing.Point(461, 329)
        Me.btnEditPergunta.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnEditPergunta.Name = "btnEditPergunta"
        Me.btnEditPergunta.Size = New System.Drawing.Size(80, 30)
        Me.btnEditPergunta.TabIndex = 14
        Me.btnEditPergunta.Text = "Edit"
        Me.btnEditPergunta.UseVisualStyleBackColor = True
        '
        'lblIDGrupo
        '
        Me.lblIDGrupo.AutoSize = True
        Me.lblIDGrupo.Location = New System.Drawing.Point(500, 4)
        Me.lblIDGrupo.Name = "lblIDGrupo"
        Me.lblIDGrupo.Size = New System.Drawing.Size(75, 17)
        Me.lblIDGrupo.TabIndex = 9
        Me.lblIDGrupo.Text = "lblIDGrupo"
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
        'btnAddPergunta
        '
        Me.btnAddPergunta.Location = New System.Drawing.Point(461, 295)
        Me.btnAddPergunta.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnAddPergunta.Name = "btnAddPergunta"
        Me.btnAddPergunta.Size = New System.Drawing.Size(80, 30)
        Me.btnAddPergunta.TabIndex = 11
        Me.btnAddPergunta.Text = "Add"
        Me.btnAddPergunta.UseVisualStyleBackColor = True
        '
        'cmdPass
        '
        Me.cmdPass.Enabled = False
        Me.cmdPass.Location = New System.Drawing.Point(461, 113)
        Me.cmdPass.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmdPass.Name = "cmdPass"
        Me.cmdPass.Size = New System.Drawing.Size(85, 26)
        Me.cmdPass.TabIndex = 23
        Me.cmdPass.Text = "<<<"
        Me.cmdPass.UseVisualStyleBackColor = True
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
        'gridPerguntas
        '
        Me.gridPerguntas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridPerguntas.Location = New System.Drawing.Point(8, 242)
        Me.gridPerguntas.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.gridPerguntas.Name = "gridPerguntas"
        Me.gridPerguntas.RowTemplate.Height = 24
        Me.gridPerguntas.Size = New System.Drawing.Size(215, 151)
        Me.gridPerguntas.TabIndex = 8
        '
        'gridListGrupo
        '
        Me.gridListGrupo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridListGrupo.Location = New System.Drawing.Point(229, 50)
        Me.gridListGrupo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.gridListGrupo.Name = "gridListGrupo"
        Me.gridListGrupo.RowTemplate.Height = 24
        Me.gridListGrupo.Size = New System.Drawing.Size(211, 150)
        Me.gridListGrupo.TabIndex = 21
        '
        'gridGrupos
        '
        Me.gridGrupos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridGrupos.Location = New System.Drawing.Point(3, 50)
        Me.gridGrupos.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.gridGrupos.Name = "gridGrupos"
        Me.gridGrupos.RowTemplate.Height = 24
        Me.gridGrupos.Size = New System.Drawing.Size(220, 150)
        Me.gridGrupos.TabIndex = 7
        '
        'btnListGrupos
        '
        Me.btnListGrupos.Location = New System.Drawing.Point(461, 50)
        Me.btnListGrupos.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnListGrupos.Name = "btnListGrupos"
        Me.btnListGrupos.Size = New System.Drawing.Size(85, 29)
        Me.btnListGrupos.TabIndex = 20
        Me.btnListGrupos.Text = "ListGrupos"
        Me.btnListGrupos.UseVisualStyleBackColor = True
        '
        'btnAddGrupo
        '
        Me.btnAddGrupo.Location = New System.Drawing.Point(461, 83)
        Me.btnAddGrupo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnAddGrupo.Name = "btnAddGrupo"
        Me.btnAddGrupo.Size = New System.Drawing.Size(85, 26)
        Me.btnAddGrupo.TabIndex = 2
        Me.btnAddGrupo.Text = "Add "
        Me.btnAddGrupo.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(593, 530)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(95, 49)
        Me.btnCancel.TabIndex = 4
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'tabQuestionario
        '
        Me.tabQuestionario.Controls.Add(Me.TabPage1)
        Me.tabQuestionario.Controls.Add(Me.TabPage2)
        Me.tabQuestionario.Controls.Add(Me.TabPage3)
        Me.tabQuestionario.Location = New System.Drawing.Point(3, 2)
        Me.tabQuestionario.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tabQuestionario.Name = "tabQuestionario"
        Me.tabQuestionario.SelectedIndex = 0
        Me.tabQuestionario.Size = New System.Drawing.Size(701, 615)
        Me.tabQuestionario.TabIndex = 39
        '
        'mainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(709, 620)
        Me.Controls.Add(Me.tabQuestionario)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "mainForm"
        Me.Text = "mainForm"
        Me.TabPage3.ResumeLayout(False)
        Me.pnlEnquetes.ResumeLayout(False)
        Me.pnlEnquetes.PerformLayout()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.pnlPessoas.ResumeLayout(False)
        Me.pnlPessoas.PerformLayout()
        Me.TabPage1.ResumeLayout(False)
        Me.pnlQuestionario.ResumeLayout(False)
        Me.pnlQuestionario.PerformLayout()
        CType(Me.gridQuestionario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlGrupos.ResumeLayout(False)
        Me.pnlGrupos.PerformLayout()
        CType(Me.gridListPerguntas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridPerguntas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridListGrupo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridGrupos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabQuestionario.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents pnlEnquetes As Panel
    Friend WithEvents Chart1 As DataVisualization.Charting.Chart
    Friend WithEvents UcListEnquete As ucList
    Friend WithEvents cmdCreateTable As Button
    Friend WithEvents cmdCreateChart As Button
    Friend WithEvents lblEnquetes As Label
    Friend WithEvents cmdIsoPerSexo As Button
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents pnlPessoas As Panel
    Friend WithEvents UcList1 As ucList
    Friend WithEvents lblPessoas As Label
    Friend WithEvents cmdDeletePessoas As Button
    Friend WithEvents cmdEditPessoas As Button
    Friend WithEvents cmdAddPessoas As Button
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents pnlQuestionario As Panel
    Friend WithEvents lblIDEnquete As Label
    Friend WithEvents lblQuestionario As Label
    Friend WithEvents btnDeleteQuest As Button
    Friend WithEvents cmdResponder As Button
    Friend WithEvents btnEditQuest As Button
    Friend WithEvents btnAddQuest As Button
    Friend WithEvents gridQuestionario As DataGridView
    Friend WithEvents lblIDQuestionario As Label
    Friend WithEvents cmdPrepall As Button
    Friend WithEvents pnlGrupos As Panel
    Friend WithEvents btnDeletePergunta As Button
    Friend WithEvents lblIDOrdemHold As Label
    Friend WithEvents btnEditPergunta As Button
    Friend WithEvents lblIDGrupo As Label
    Friend WithEvents lblPerguntas As Label
    Friend WithEvents btnAddPergunta As Button
    Friend WithEvents cmdPass As Button
    Friend WithEvents lblIDPergunta As Label
    Friend WithEvents lblIDOrdem As Label
    Friend WithEvents lblGrupo As Label
    Friend WithEvents gridPerguntas As DataGridView
    Friend WithEvents gridListGrupo As DataGridView
    Friend WithEvents gridGrupos As DataGridView
    Friend WithEvents btnListGrupos As Button
    Friend WithEvents btnAddGrupo As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents tabQuestionario As TabControl
    Friend WithEvents cmd2Tables As Button
    Friend WithEvents CMDIsoLentesRigidas As Button
    Friend WithEvents gridListPerguntas As DataGridView
    Friend WithEvents cmdListPerguntas As Button
    Friend WithEvents cmdPassPerguntas As Button
    Friend WithEvents cmdEditGrupo As Button
End Class
