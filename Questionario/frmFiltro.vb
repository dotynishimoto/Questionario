Public Class frmFiltro
    Dim rs As New ADODB.Recordset
    Dim retVal As Boolean
    Dim da As New System.Data.OleDb.OleDbDataAdapter()
    Dim ds As New DataSet()
    Dim sErro = ""
    Dim s As String

    Private Sub FrmFiltro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.UcSaySomethingMedico.tbName = "tblEnquete"
        Me.UcSaySomethingMedico.pkField = "IDRespondente"
        Me.UcSaySomethingMedico.sayField = "ID"
        Me.UcSaySomethingMedico.TextBox.Location = New Point(0, 0)
        Me.UcSaySomethingMedico.TextBox.Text = "0"

        Me.UcSaySomethingPaciente.tbName = "tblEnquete"
        Me.UcSaySomethingPaciente.pkField = "ID_Paciente"
        Me.UcSaySomethingPaciente.sayField = "ID"
        Me.UcSaySomethingPaciente.TextBox.Location = New Point(0, 0)
        Me.UcSaySomethingPaciente.TextBox.Text = "0"
    End Sub

    Private Sub CmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click
        Me.Hide()
    End Sub

    Private Sub CmdOk_Click(sender As Object, e As EventArgs) Handles cmdOk.Click

        If checkMedico.Checked = False Then
            Me.UcSaySomethingMedico.TextBox.Text = "0"
        End If
        If checkPaciente.Checked = False Then
            Me.UcSaySomethingPaciente.TextBox.Text = "0"
        End If

        If checkDate.Checked = False Then
            dateFilter.Value = New DateTime(1753, 1, 1)

        End If

        s = "Select * from tblEnquete 
Where tblEnquete.IDRespondente = " & Me.UcSaySomethingMedico.TextBox.Text & " 
OR tblEnquete.ID_Paciente = " & Me.UcSaySomethingPaciente.TextBox.Text & " 
OR tblEnquete.Data_Dia =  #" & FormatDateTime(dateFilter.Value, DateFormat.ShortDate) & "#"
        retVal = getRS(s, rs, False, sErro)

        If retVal Then
            da.Fill(ds, rs, "tblEnquete")
            mainForm.gridEnquete.DataSource = (ds.Tables("tblEnquete"))
        Else
            MsgBox("Error while opening Recordset.")
        End If
        Me.Close()
    End Sub

    Private Sub cmdListAll_Click(sender As Object, e As EventArgs) Handles cmdListAll.Click
        Dim rs As New ADODB.Recordset
        Dim retVal As Boolean
        Dim da As New System.Data.OleDb.OleDbDataAdapter
        Dim s As String = "Select * from tblPessoas"
        Dim sErro As String = ""
        ds.Clear()

        retVal = getRS(s, rs, False, sErro)
        If retVal Then
            da.Fill(ds, rs, "tblPessoas")
            gridPessoas.DataSource = (ds.Tables("tblPessoas"))
            gridPessoas.Columns(0).Width = 30
            gridPessoas.Columns(1).Width = 60
            gridPessoas.Columns(3).Visible = False
            gridPessoas.Columns(4).Visible = False
            gridPessoas.Columns(5).Visible = False
            gridPessoas.Columns(6).Visible = False
            gridPessoas.Columns(7).Visible = False
        Else
            MsgBox("Error while opening Recordset.")
        End If
    End Sub
End Class