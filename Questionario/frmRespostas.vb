Imports System.Data.OleDb
Public Class frmRespostas
    Dim rs As New ADODB.Recordset
    Dim sErro As String = ""
    Dim retVal As Boolean
    Dim s As String
    Dim somestring As String
    Dim somestring2() As String

    Private Sub Respostas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        s = "SELECT rrQuestionarioGrupo.ID_Questionario, tblGrupoQuestoes.Titulo, tblQuestoes.Questao, rrGrupoQuestao.Ordem, tblQuestoes.ID, tblQuestoes.Tipo, tblQuestoes.Respostas
FROM tblQuestoes INNER JOIN ((tblGrupoQuestoes INNER JOIN rrQuestionarioGrupo ON tblGrupoQuestoes.ID = rrQuestionarioGrupo.ID_Grupo) INNER JOIN rrGrupoQuestao ON tblGrupoQuestoes.ID = rrGrupoQuestao.ID_Grupo) ON tblQuestoes.ID = rrGrupoQuestao.ID_Questao
         WHERE rrQuestionarioGrupo.ID_Questionario=" & Val(Trim(lblIDQuestionario.Text)) & ""

        prepall()

        lblIDHoldEnquete.Text = ""
        Me.UcSaySomething1.tbName = "tblPessoas"
        Me.UcSaySomething1.pkField = "ID"
        Me.UcSaySomething1.sayField = "Nome"
        Me.UcSaySomething1.Caption = "ID Paciente: "
        Me.UcSaySomething1.lblCaption.Location = New Point(53, 5)

        Me.UcSayRespondente.tbName = "tblPessoas"
        Me.UcSayRespondente.pkField = "ID"
        Me.UcSayRespondente.sayField = "Nome"
        Me.UcSayRespondente.Caption = "ID Respondente: "
        Me.UcSayRespondente.lblCaption.Location = New Point(33, 5)
        retVal = getRS(s, rs, False, sErro)

        Dim p As New Point(5, 35)

        txtRespostaTexto.Location = p
        txtRespostaNum.Location = p
        datePicker.Location = p
        comboOpcao.Location = p
    End Sub
    Private Sub nav()
        If retVal Then
            lblPergunta.Visible = True
            lblGrupo.Visible = True
            lblIDPergunta.Text = rs.Fields("ID").Value
            lblIDQuestionario.Text = rs.Fields("ID_Questionario").Value
            lblIDOrdem.Text = rs.Fields("Ordem").Value
            lblPergunta.Text = rs.Fields("Questao").Value
            lblTipo.Text = rs.Fields("Tipo").Value
            lblGrupo.Text = rs.Fields("Titulo").Value

            If lblTipo.Text = "d" Then
                datePicker.Visible = True
            ElseIf lblTipo.Text = "t" Then
                txtRespostaTexto.Visible = True
            ElseIf lblTipo.Text = "o" Then
                comboOpcao.Items.Clear()
                somestring = rs.Fields("Respostas").Value

                somestring2 = somestring.Split(";")

                For i = 0 To somestring2.Length - 1
                    comboOpcao.Items.Add(somestring2(i))
                Next
                comboOpcao.Visible = True
            ElseIf lblTipo.Text = "n" Or lblTipo.Text = "i" Then
                txtRespostaNum.Visible = True
            ElseIf lblTipo.Text = "m" Then
                check.Visible = True
            End If
        Else
            MsgBox("Error while opening Recordset.")
        End If
    End Sub

    Private Sub BtnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        If Not Me.UcSayRespondente.isOK Or Not Me.UcSaySomething1.isOK Then
            MsgBox("ID Paciente ou Respondedor incorreto")
        Else
            nav()
            rs.MoveFirst()
            btnSave.Enabled = True
            btnNext.Enabled = True
            btnPrev.Enabled = True
            btnStart.Enabled = False
            Me.UcSaySomething1.Enabled = False
            dateConsulta.Enabled = False
            Me.UcSayRespondente.Enabled = False
        End If

    End Sub

    Private Sub BtnPrev_Click(sender As Object, e As EventArgs) Handles btnPrev.Click
        If Not rs.EOF Then
            rs.MovePrevious()
            If Not rs.BOF Then
                prepLayout()
                nav()
            Else
                rs.MoveNext()
                MsgBox("Essa e a primeira pergunta")
            End If
        End If
    End Sub

    Private Sub BtnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        If Not rs.EOF Then
            rs.MoveNext()
            If Not rs.EOF Then
                prepLayout()
                nav()
            Else
                rs.MovePrevious()
                MsgBox("Essa e a ultima pergunta")
            End If
        End If
    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Hide()
    End Sub

    Public Sub numberOnly(ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If (Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57) Or Asc(e.KeyChar) = 8 Or Asc(e.KeyChar) = 44 Then
            txtRespostaNum.BackColor = Color.White
        Else
            e.Handled = True
            txtRespostaNum.BackColor = Color.Red
        End If
    End Sub
    Private Sub txtRespostaNum_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtRespostaNum.KeyPress
        numberOnly(e)
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim rs As New ADODB.Recordset

        s = "SELECT tblEnquete.ID, tblEnquete.IDQuestionario, tblEnquete.ID_Paciente, tblEnquete.Data_Dia, tblEnqueteRespostas.ID_Enquete, tblEnqueteRespostas.ID_Questionario, tblEnqueteRespostas.ID_Ordem_Questao, tblEnqueteRespostas.ID_Questao, tblEnqueteRespostas.Questao, tblEnqueteRespostas.Resposta, tblEnqueteRespostas.ID_Respondente, tblEnquete.IDRespondente
FROM tblEnquete INNER JOIN tblEnqueteRespostas ON tblEnquete.ID = tblEnqueteRespostas.ID_Enquete;"
        retVal = getRS(s, rs, False, sErro)

        If retVal Then
            If Trim(lblIDHoldEnquete.Text) = "" Then
                rs.AddNew()
                rs.Fields("ID_Paciente").Value = Me.UcSaySomething1.TextBox.Text
                rs.Fields("Data_Dia").Value = dateConsulta
                rs.Fields("IDQuestionario").Value = lblIDQuestionario.Text
                rs.Fields("IDRespondente").Value = Me.UcSayRespondente.TextBox.Text
                rs.Update()
                lblIDHoldEnquete.Text = rs.Fields("ID").Value
            End If
            If (txtRespostaTexto.Text = "") And (comboOpcao.Text = "") And (txtRespostaNum.Text = "") And (dateConsulta.Value = New DateTime(1753, 1, 1)) Then
                MsgBox("Preencha a resposta")
            Else
                rs.AddNew()

                rs.Fields("ID_Enquete").Value = lblIDHoldEnquete.Text
                rs.Fields("ID_Questionario").Value = lblIDQuestionario.Text
                rs.Fields("ID_Ordem_Questao").Value = lblIDOrdem.Text
                rs.Fields("ID_Questao").Value = lblIDPergunta.Text
                rs.Fields("Questao").Value = lblPergunta.Text
                rs.Fields("ID_Respondente").Value = Me.UcSayRespondente.TextBox.Text
                If lblTipo.Text = "d" Then
                    rs.Fields("Resposta").Value = datePicker.Value
                ElseIf lblTipo.Text = "t" Then
                    rs.Fields("Resposta").Value = txtRespostaTexto.Text
                ElseIf lblTipo.Text = "o" Then
                    rs.Fields("Resposta").Value = comboOpcao.Text
                ElseIf lblTipo.Text = "n" Or lblTipo.Text = "i" Then
                    rs.Fields("Resposta").Value = txtRespostaNum.Text
                ElseIf lblTipo.Text = "m" Then
                    rs.Fields("Resposta").Value = check.ValueMember
                End If
                rs.Update()
                rs.Close()

                MsgBox("Answer saved.")
            End If
        Else
            MsgBox("Error while opening Recordset.")
        End If
    End Sub

    Private Sub txtRespondedor_KeyPress(sender As Object, e As KeyPressEventArgs)
        numberOnly(e)
    End Sub

    Private Sub prepall()
        Dim da As New System.Data.OleDb.OleDbDataAdapter
        Dim s As String = "Select * from tblPessoas"
        Dim ds As New DataSet
        retVal = getRS(s, rs, False, sErro)
        If retVal Then
            da.Fill(ds, rs, "tblPessoas")
            gridPessoas.DataSource = (ds.Tables("tblPessoas"))
            gridPessoas.Columns(0).Width = 25
            gridPessoas.Columns(1).Width = 50
            gridPessoas.Columns(3).Visible = False
            gridPessoas.Columns(4).Visible = False
            gridPessoas.Columns(5).Visible = False
            gridPessoas.Columns(6).Visible = False
            gridPessoas.Columns(7).Visible = False

        Else
            MsgBox("Error while opening Recordset.")
        End If
    End Sub
    Private Sub checkResposta()
        comboOpcao.Text = String.Empty
        txtRespostaTexto.Clear()
        txtRespostaNum.Clear()
        Dim rs As New ADODB.Recordset
        Dim s As String = "Select * from tblEnqueteRespostas where ID_Enquete =" & Val(Trim(lblIDHoldEnquete.Text)) & " and ID_Ordem_Questao = " & Val(Trim(lblIDOrdem.Text)) & " and ID_Questao = " & Val(Trim(lblIDPergunta.Text)) & ""
        retVal = getRS(s, rs, False, sErro)
        If retVal And Not rs.EOF And Not rs.BOF Then
            If lblTipo.Text = "t" Then
                txtRespostaTexto.Text = rs.Fields("Resposta").Value
            ElseIf lblTipo.Text = "n" Or lblTipo.Text = "i" Then
                txtRespostaNum.Text = rs.Fields("Resposta").Value
            ElseIf lblTipo.Text = "o" Then
                comboOpcao.Text = rs.Fields("Resposta").Value
            ElseIf lblTipo.Text = "d" Then
                datePicker.Value = rs.Fields("Resposta").Value
            End If
        Else
            MsgBox("Error while opening Recordset.")
        End If
    End Sub
    Private Sub txtRespostaTexto_VisibleChanged(sender As Object, e As EventArgs)
        checkResposta()
    End Sub

    Private Sub txtRespostaNum_VisibleChanged(sender As Object, e As EventArgs)
        checkResposta()
    End Sub

    Private Sub comboOpcao_VisibleChanged(sender As Object, e As EventArgs)
        checkResposta()
    End Sub

    Private Sub datePicker_VisibleChanged(sender As Object, e As EventArgs)
        checkResposta()
    End Sub

    Function prepLayout()

        txtRespostaTexto.Visible = False
        txtRespostaNum.Visible = False
        comboOpcao.Visible = False
        datePicker.Visible = False
        Return True

    End Function
    Private Sub UcSaySomething1_pkValChanged() Handles UcSaySomething1.pkValChanged
        MsgBox("Pk Changed " & UcSaySomething1.pkVal)
    End Sub

    Private Sub BtnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        Close()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class