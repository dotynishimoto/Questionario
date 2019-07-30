<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmFiltro
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
        Me.checkMedico = New System.Windows.Forms.CheckBox()
        Me.checkPaciente = New System.Windows.Forms.CheckBox()
        Me.checkDate = New System.Windows.Forms.CheckBox()
        Me.dateFilter = New System.Windows.Forms.DateTimePicker()
        Me.cmdOk = New System.Windows.Forms.Button()
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.gridPessoas = New System.Windows.Forms.DataGridView()
        Me.cmdListAll = New System.Windows.Forms.Button()
        Me.UcSaySomethingPaciente = New Questionario.ucSaySomething()
        Me.UcSaySomethingMedico = New Questionario.ucSaySomething()
        CType(Me.gridPessoas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'checkMedico
        '
        Me.checkMedico.AutoSize = True
        Me.checkMedico.Location = New System.Drawing.Point(37, 35)
        Me.checkMedico.Name = "checkMedico"
        Me.checkMedico.Size = New System.Drawing.Size(83, 21)
        Me.checkMedico.TabIndex = 0
        Me.checkMedico.Text = "Medico: "
        Me.checkMedico.UseVisualStyleBackColor = True
        '
        'checkPaciente
        '
        Me.checkPaciente.AutoSize = True
        Me.checkPaciente.Location = New System.Drawing.Point(37, 76)
        Me.checkPaciente.Name = "checkPaciente"
        Me.checkPaciente.Size = New System.Drawing.Size(93, 21)
        Me.checkPaciente.TabIndex = 1
        Me.checkPaciente.Text = "Paciente: "
        Me.checkPaciente.UseVisualStyleBackColor = True
        '
        'checkDate
        '
        Me.checkDate.AutoSize = True
        Me.checkDate.Location = New System.Drawing.Point(37, 119)
        Me.checkDate.Name = "checkDate"
        Me.checkDate.Size = New System.Drawing.Size(68, 21)
        Me.checkDate.TabIndex = 2
        Me.checkDate.Text = "Date: "
        Me.checkDate.UseVisualStyleBackColor = True
        '
        'dateFilter
        '
        Me.dateFilter.Location = New System.Drawing.Point(134, 119)
        Me.dateFilter.Name = "dateFilter"
        Me.dateFilter.Size = New System.Drawing.Size(223, 22)
        Me.dateFilter.TabIndex = 5
        Me.dateFilter.Value = New Date(2019, 7, 4, 0, 0, 0, 0)
        '
        'cmdOk
        '
        Me.cmdOk.Location = New System.Drawing.Point(334, 312)
        Me.cmdOk.Name = "cmdOk"
        Me.cmdOk.Size = New System.Drawing.Size(75, 23)
        Me.cmdOk.TabIndex = 6
        Me.cmdOk.Text = "Ok"
        Me.cmdOk.UseVisualStyleBackColor = True
        '
        'cmdCancel
        '
        Me.cmdCancel.Location = New System.Drawing.Point(416, 312)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(75, 23)
        Me.cmdCancel.TabIndex = 7
        Me.cmdCancel.Text = "Cancel"
        Me.cmdCancel.UseVisualStyleBackColor = True
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Location = New System.Drawing.Point(384, 123)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(52, 17)
        Me.lblDate.TabIndex = 8
        Me.lblDate.Text = "lblDate"
        '
        'gridPessoas
        '
        Me.gridPessoas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridPessoas.Location = New System.Drawing.Point(12, 181)
        Me.gridPessoas.Name = "gridPessoas"
        Me.gridPessoas.RowTemplate.Height = 24
        Me.gridPessoas.Size = New System.Drawing.Size(297, 164)
        Me.gridPessoas.TabIndex = 9
        '
        'cmdListAll
        '
        Me.cmdListAll.Location = New System.Drawing.Point(315, 181)
        Me.cmdListAll.Name = "cmdListAll"
        Me.cmdListAll.Size = New System.Drawing.Size(98, 30)
        Me.cmdListAll.TabIndex = 10
        Me.cmdListAll.Text = "ListAll"
        Me.cmdListAll.UseVisualStyleBackColor = True
        '
        'UcSaySomethingPaciente
        '
        Me.UcSaySomethingPaciente.Caption = Nothing
        Me.UcSaySomethingPaciente.Location = New System.Drawing.Point(134, 76)
        Me.UcSaySomethingPaciente.Name = "UcSaySomethingPaciente"
        Me.UcSaySomethingPaciente.pkField = Nothing
        Me.UcSaySomethingPaciente.pkVal = Nothing
        Me.UcSaySomethingPaciente.sayField = Nothing
        Me.UcSaySomethingPaciente.Size = New System.Drawing.Size(311, 28)
        Me.UcSaySomethingPaciente.TabIndex = 4
        Me.UcSaySomethingPaciente.tbName = Nothing
        '
        'UcSaySomethingMedico
        '
        Me.UcSaySomethingMedico.Caption = Nothing
        Me.UcSaySomethingMedico.CausesValidation = False
        Me.UcSaySomethingMedico.Location = New System.Drawing.Point(134, 35)
        Me.UcSaySomethingMedico.Name = "UcSaySomethingMedico"
        Me.UcSaySomethingMedico.pkField = Nothing
        Me.UcSaySomethingMedico.pkVal = Nothing
        Me.UcSaySomethingMedico.sayField = Nothing
        Me.UcSaySomethingMedico.Size = New System.Drawing.Size(311, 28)
        Me.UcSaySomethingMedico.TabIndex = 3
        Me.UcSaySomethingMedico.tbName = Nothing
        '
        'frmFiltro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(503, 357)
        Me.Controls.Add(Me.cmdListAll)
        Me.Controls.Add(Me.gridPessoas)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.cmdCancel)
        Me.Controls.Add(Me.cmdOk)
        Me.Controls.Add(Me.dateFilter)
        Me.Controls.Add(Me.UcSaySomethingPaciente)
        Me.Controls.Add(Me.UcSaySomethingMedico)
        Me.Controls.Add(Me.checkDate)
        Me.Controls.Add(Me.checkPaciente)
        Me.Controls.Add(Me.checkMedico)
        Me.Name = "frmFiltro"
        Me.Text = "frmFiltro"
        CType(Me.gridPessoas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents checkMedico As CheckBox
    Friend WithEvents checkPaciente As CheckBox
    Friend WithEvents checkDate As CheckBox
    Friend WithEvents UcSaySomethingMedico As ucSaySomething
    Friend WithEvents UcSaySomethingPaciente As ucSaySomething
    Friend WithEvents dateFilter As DateTimePicker
    Friend WithEvents cmdOk As Button
    Friend WithEvents cmdCancel As Button
    Friend WithEvents lblDate As Label
    Friend WithEvents gridPessoas As DataGridView
    Friend WithEvents cmdListAll As Button
End Class
