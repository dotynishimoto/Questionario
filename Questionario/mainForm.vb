Public Class mainForm

    Dim ds As New DataSet

    Private Sub BtnPrepall_Click(sender As Object, e As EventArgs) Handles cmdPrepall.Click
        prePall()
    End Sub
    Function prePall()
        Me.UcList1.tbName = "tblPessoas"
        Me.UcList1.pkField = "ID"
        Me.UcList1.sayField = "ID"


        Dim rs As New ADODB.Recordset
        Dim retVal As Boolean
        Dim popEnquete As Boolean

        popEnquete = gridPopulate(crudGrid.gridEnquete)
        Dim da As New System.Data.OleDb.OleDbDataAdapter
        Dim s As String = "Select * from tblQuestionarios"
        Dim sErro As String = ""
        ds.Clear() 'pra n duplicar as linhas no dgv..ai limpa e popula de novo o dgv

        retVal = getRS(s, rs, False, sErro)
        If retVal Then
            da.Fill(ds, rs, "tblQuestionarios")
            gridQuestionario.DataSource = (ds.Tables("tblQuestionarios"))
            gridQuestionario.Columns(0).Width = 30

        End If
    End Function
    Private Sub Questionario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'prePall()

    End Sub
    Private Sub gridQuestionario_SelectionChanged(sender As Object, e As EventArgs) Handles gridQuestionario.SelectionChanged
        Dim retVal As Boolean
        retVal = gridPopulate(crudGrid.gridQuestionario)
    End Sub
    Private Sub gridGrupos_SelectionChanged(sender As Object, e As EventArgs) Handles gridGrupos.SelectionChanged
        Dim retVal As Boolean
        retVal = gridPopulate(crudGrid.gridGrupos)
    End Sub
    Private Sub gridPerguntas_SelectionChanged(sender As Object, e As EventArgs) Handles gridPerguntas.SelectionChanged
        Dim retVal As Boolean
        retVal = gridPopulate(crudGrid.gridPerguntas)
    End Sub
    Private Sub gridPessoas_SelectionChanged(sender As Object, e As EventArgs) Handles gridEnquete.SelectionChanged
        Dim retVal As Boolean
        retVal = gridPopulate(crudGrid.gridPessoas)
    End Sub
    Private Sub gridListGrupo_SelectionChanged(sender As Object, e As EventArgs) Handles gridListGrupo.SelectionChanged
        Dim retVal As Boolean
        retVal = gridPopulate(crudGrid.gridUpdateGrupo)
    End Sub
    Private Sub BtnUpdatePergunta_Click(sender As Object, e As EventArgs) Handles btnEditPergunta.Click
        Dim retVal As Boolean
        retVal = addEditPerguntas(crudOptions.edit)
    End Sub
    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles btnAddPergunta.Click
        Dim retVal As Boolean
        retVal = addEditPerguntas(crudOptions.addNew)
    End Sub
    Private Sub BtnEditQuest_Click(sender As Object, e As EventArgs) Handles btnEditQuest.Click
        Dim retVal As Boolean
        retVal = addEditQuestionario(crudOptions.edit)
    End Sub
    Private Sub BtnAddQuest_Click(sender As Object, e As EventArgs) Handles btnAddQuest.Click
        Dim retVal As Boolean
        retVal = addEditQuestionario(crudOptions.addNew)
    End Sub
    Private Sub CmdAddPessoas_Click(sender As Object, e As EventArgs) Handles cmdAddPessoas.Click
        Dim retVal As Boolean
        retVal = addEditPessoas(crudOptions.addNew)
    End Sub
    Private Sub CmdEditPessoas_Click(sender As Object, e As EventArgs) Handles cmdEditPessoas.Click
        Dim retVal As Boolean
        retVal = addEditPessoas(crudOptions.edit)
    End Sub
    Function addEditPerguntas(q As crudOptions) As Boolean
        Dim f As New frmPerguntas
        Select Case q
            Case crudOptions.addNew
                f.lblIDPergunta.Text = ""
                f.lblIDHold.Text = ""
                f.lblIDGrupo.Text = lblIDGrupo.Text
                f.lblIDOrdem.Text = lblIDOrdem.Text
            Case crudOptions.edit
                f.lblIDPergunta.Text = lblIDPergunta.Text
        End Select
        f.Prepall()
        f.ShowDialog()
        f.Close()
        Return True
    End Function
    Function addEditQuestionario(q As crudOptions) As Boolean
        Dim f As New frmAddEditQuestionario
        Select Case q
            Case crudOptions.addNew
                f.lblIDQuestionario.Text = ""
            Case crudOptions.edit
                f.lblIDQuestionario.Text = lblIDQuestionario.Text
        End Select
        f.Prepall()
        f.ShowDialog()
        f.Close()
        Return True
    End Function
    Function addEditPessoas(q As crudOptions) As Boolean
        Dim f As New frmPessoas
        Select Case q
            Case crudOptions.addNew
                f.lblIDPessoas.Text = ""
            Case crudOptions.edit
                f.lblIDPessoas.Text = Me.UcList1.lblSay.Text
                '  f.lblHoldCRM.Text = lblIDHoldCRM.Text
        End Select
        f.Prepall()
        f.ShowDialog()
        f.Close()
        Return True
    End Function
    Function gridPopulate(q As crudOptions) As Boolean
        Dim rs As New ADODB.Recordset
        Dim index As Integer
        Dim selectedrow As DataGridViewRow
        Dim retVal As Boolean
        Dim sErro As String = ""
        Dim da As New System.Data.OleDb.OleDbDataAdapter()
        Dim ds As New DataSet()
        Dim s As String

        Select Case q

            Case crudGrid.gridGrupos
                If Not gridGrupos.CurrentRow Is Nothing Then

                    index = gridGrupos.CurrentRow.Index
                    selectedrow = gridGrupos.Rows(index)
                    lblIDGrupo.Text = selectedrow.Cells(1).Value.ToString
                    lblIDOrdem.Text = selectedrow.Cells(3).Value.ToString

                    s = "SELECT rrGrupoQuestao.ID_Questao, tblQuestoes.Questao, rrGrupoQuestao.ID_Grupo
FROM tblQuestoes INNER JOIN rrGrupoQuestao ON tblQuestoes.ID = rrGrupoQuestao.ID_Questao
WHERE rrGrupoQuestao.ID_Grupo= " & Val(Trim(lblIDGrupo.Text)) & ""
                    retVal = getRS(s, rs, False, sErro)
                    If retVal Then
                        da.Fill(ds, rs, "rrGrupoQuestao")
                        gridPerguntas.DataSource = (ds.Tables("rrGrupoQuestao"))
                        gridPerguntas.Columns(2).Visible = False
                        gridPerguntas.Columns(0).Width = 70
                        gridPerguntas.Columns(1).Width = 200

                    End If
                End If

            Case crudGrid.gridPerguntas
                If Not gridPerguntas.CurrentRow Is Nothing Then
                    index = gridPerguntas.CurrentRow.Index
                    selectedrow = gridPerguntas.Rows(index)
                    lblIDPergunta.Text = selectedrow.Cells(0).Value.ToString
                End If

            Case crudGrid.gridQuestionario

                If Not gridQuestionario.CurrentRow Is Nothing Then
                    index = gridQuestionario.CurrentRow.Index
                    selectedrow = gridQuestionario.Rows(index)
                    lblIDQuestionario.Text = selectedrow.Cells(0).Value.ToString

                    s = "Select rrQuestionarioGrupo.ID_Questionario, rrQuestionarioGrupo.ID_Grupo, tblGrupoQuestoes.Titulo, rrQuestionarioGrupo.Ordem
                    From tblGrupoQuestoes INNER Join rrQuestionarioGrupo On tblGrupoQuestoes.ID = rrQuestionarioGrupo.ID_Grupo
                    Where rrQuestionarioGrupo.ID_Questionario = " & Val(Trim(lblIDQuestionario.Text)) & ""

                    retVal = getRS(s, rs, False, sErro)
                    If retVal Then
                        da.Fill(ds, rs, "tblGrupoQuestao")

                        gridGrupos.DataSource = (ds.Tables("tblGrupoQuestao"))
                        gridGrupos.Columns(0).Visible = False
                        gridGrupos.Columns(1).Visible = False
                        gridGrupos.Columns(3).Visible = False
                        gridGrupos.Columns(2).Width = 130
                    End If

                End If

            Case crudGrid.gridPessoas
                If Not Me.UcList1.grid1.CurrentRow Is Nothing Then
                    index = Me.UcList1.grid1.CurrentRow.Index
                    selectedrow = Me.UcList1.grid1.Rows(index)


                End If

            Case crudGrid.gridEnquete
                s = "Select * from tblEnquete"
                retVal = getRS(s, rs, False, sErro)
                If retVal Then

                    da.Fill(ds, rs, "tblEnquete")
                    gridEnquete.DataSource = (ds.Tables("tblEnquete"))
                    gridEnquete.Columns(0).Width = 35
                    gridEnquete.Columns(1).Width = 60
                    gridEnquete.Columns(2).Width = 60
                    gridEnquete.Columns(3).Width = 60
                End If

            Case crudGrid.gridUpdateGrupo
                If Not gridListGrupo.CurrentRow Is Nothing Then
                    index = gridListGrupo.CurrentRow.Index
                    selectedrow = gridListGrupo.Rows(index)
                    lblIDGrupo.Text = selectedrow.Cells(0).Value.ToString
                    lblIDOrdem.Text = selectedrow.Cells(2).Value.ToString
                End If
        End Select
        Return True
    End Function
    Private Sub CmdPass_Click(sender As Object, e As EventArgs) Handles cmdPass.Click
        Dim rs As New ADODB.Recordset

        Dim s As String
        Dim retval As Boolean
        Dim serro As String = ""
        s = "Select * from rrQuestionarioGrupo where ID_Questionario = " & Val(Trim(lblIDQuestionario.Text)) & " and ID_Grupo = " & Val(Trim(lblIDGrupo.Text)) & ""

        retval = getRS(s, rs, False, serro)

        If retval Then
            If rs.RecordCount > 0 Then
                MsgBox("Group already in this questionary")

            Else
                rs.AddNew()

                rs.Fields("ID_Questionario").Value = lblIDQuestionario.Text
                rs.Fields("ID_Grupo").Value = lblIDGrupo.Text
                rs.Fields("Ordem").Value = lblIDOrdem.Text


                rs.Update()
                rs.Close()
            End If
        Else
            MsgBox("Error while opening Recordset.")

        End If
        cmdPrepall.PerformClick()
    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub BtnUpdateGrupo_Click(sender As Object, e As EventArgs) Handles btnUpdateGrupo.Click
        Dim f As New frmGrupos
        f.lblIDQuestionario.Text = lblIDQuestionario.Text
        f.ShowDialog()
    End Sub
    Private Sub BtnDeletePergunta_Click(sender As Object, e As EventArgs) Handles btnDeletePergunta.Click
        Dim retVal As Boolean
        retVal = deleteBtn(crudDelete.Pergunta)
    End Sub
    Private Sub BtnDeleteQuest_Click(sender As Object, e As EventArgs) Handles btnDeleteQuest.Click
        Dim retVal As Boolean
        retVal = deleteBtn(crudDelete.Questionario)
    End Sub
    Private Sub CmdDeletePessoas_Click(sender As Object, e As EventArgs) Handles cmdDeletePessoas.Click
        Dim retVal As Boolean
        retVal = deleteBtn(crudDelete.Pessoa)
    End Sub
    Function deleteBtn(q As crudDelete) As Boolean
        Dim retVal As Boolean
        Dim sql As String = ""
        Dim sErro As String = ""
        Dim s As String = ""
        Dim rs As New ADODB.Recordset
        Select Case q

            Case crudDelete.Questionario
                s = "Select * from tblEnquete where IDQuestionario =" & Val(Trim(lblIDQuestionario.Text)) & ""
                retVal = getRS(s, rs, False, sErro)
                If retVal Then
                    If rs.RecordCount > 0 Then
                        MsgBox("Questionary cannot be deleted.")
                    Else
                        sql = "Delete * from tblQuestionarios where ID =" & Val(Trim(lblIDQuestionario.Text)) & ""
                        retVal = sqlExecute(sql, sErro)
                        MsgBox("Questionario deletado")
                        prePall()

                    End If
                Else
                    MsgBox("Error while opening Recordset.")
                End If
            Case crudDelete.Pessoa
                sql = "Delete * from tblPessoas where ID = " & Val(Trim(Me.UcList1.lblSay.Text)) & ""
                retVal = sqlExecute(sql, sErro)
                MsgBox("Pessoa Deletada.")
                Me.UcList1.cmdPrepall.PerformClick()
            Case crudDelete.Pergunta
                sql = "Delete * from rrGrupoQuestao where ID_Grupo =" & Val(Trim(lblIDGrupo.Text)) & " and ID_Questao = " & Val(Trim(lblIDPergunta.Text)) & ""
                retVal = sqlExecute(sql, sErro)
                MsgBox("Pergunta Deletada")
                prePall()
        End Select

        Return True
    End Function

    Private Sub cmdResponder_Click(sender As Object, e As EventArgs) Handles cmdResponder.Click
        Dim f As New frmRespostas
        f.lblIDQuestionario.Text = lblIDQuestionario.Text
        f.ShowDialog()
    End Sub



    Private Sub CmdFilter_Click(sender As Object, e As EventArgs) Handles cmdFilter.Click
        frmFiltro.Show()
    End Sub

    Private Sub BtnListGrupos_Click(sender As Object, e As EventArgs) Handles btnListGrupos.Click
        Dim rs As New ADODB.Recordset
        cmdPass.Enabled = True
        Dim da As New System.Data.OleDb.OleDbDataAdapter
        Dim retval As Boolean
        Dim sErro As String = ""
        Dim s As String = "SELECT tblGrupoQuestoes.ID, tblGrupoQuestoes.Titulo, rrQuestionarioGrupo.Ordem
FROM tblGrupoQuestoes INNER JOIN rrQuestionarioGrupo ON tblGrupoQuestoes.ID = rrQuestionarioGrupo.ID_Grupo
GROUP BY tblGrupoQuestoes.ID, tblGrupoQuestoes.Titulo, rrQuestionarioGrupo.Ordem"
        retval = getRS(s, rs, False, sErro)
        If retval Then
            da.Fill(ds, rs, "tblGrupoQuestoes")
            gridListGrupo.DataSource = (ds.Tables("tblGrupoQuestoes"))
            gridListGrupo.Columns(0).Width = 25
            gridListGrupo.Columns(2).Visible = False
        Else
            MsgBox("Error while opening Recordset.")
        End If
    End Sub


End Class