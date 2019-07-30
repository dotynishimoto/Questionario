Imports System.Data.OleDb
Public Class frmQuestionario
    Dim rs As New ADODB.Recordset
    Private Const conString As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Doty\Desktop\Questionarios\Questionario.mdb;"
    ReadOnly con As OleDbConnection = New OleDbConnection(conString)
    Dim cmd As OleDbCommand
    Dim adapter As OleDbDataAdapter
    ReadOnly dt As DataTable = New DataTable()
    Dim cmd2 As New SqlClient.SqlCommand()

    Private Sub populate(ID As String, Titulo As String, Autor As String)

        Dim row As String() = New String() {ID, Titulo, Autor}
        Dim item As ListViewItem = New ListViewItem(row)

        listQuestionario.Items.Add(item)
    End Sub
    Private Sub populate2(ID As String, Titulo As String)

        Dim row As String() = New String() {ID, Titulo}
        Dim item As ListViewItem = New ListViewItem(row)

        listGrupos.Items.Add(item)
    End Sub
    Private Sub BtnPrepall_Click(sender As Object, e As EventArgs) Handles btnPrepall.Click


        listQuestionario.View = View.Details
        listQuestionario.FullRowSelect = True

        listQuestionario.Columns.Add("ID", 50)
        listQuestionario.Columns.Add("Titulo", 150)
        listQuestionario.Columns.Add("Autor", 150)

        listQuestionario.Items.Clear()

        Dim sql As String = "SELECT * FROM tblQuestionarios"
        cmd = New OleDbCommand(sql, con)

        Try
            con.Open()
            adapter = New OleDbDataAdapter(cmd)
            adapter.Fill(dt)

            For Each row In dt.Rows
                populate(row(0), row(1), row(2))
            Next
            dt.Rows.Clear()
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            con.Close()

        End Try

    End Sub
    Private Sub Questionario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnPrepall.PerformClick()
    End Sub

    Private Sub gridGrupos_SelectionChanged(sender As Object, e As EventArgs) Handles gridGrupos.SelectionChanged
        Dim retVal As Boolean
        retVal = gridPopulate(crudGrid.gridGrupos)
    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim retVal As Boolean
        retVal = addEdit(crudOptions.addNew)
    End Sub

    Private Sub gridPerguntas_SelectionChanged(sender As Object, e As EventArgs) Handles gridPerguntas.SelectionChanged
        Dim retVal As Boolean
        retVal = gridPopulate(crudGrid.gridPerguntas)
    End Sub

    Function addEdit(q As crudOptions) As Boolean
        Dim f As New Perguntas
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
    Function gridPopulate(q As crudOptions) As Boolean
        Dim index As Integer
        Dim selectedrow As DataGridViewRow
        Dim retVal As Boolean
        Dim sErro As String = ""
        Dim da As New System.Data.OleDb.OleDbDataAdapter()
        Dim ds As New DataSet()

        Select Case q


            Case crudGrid.gridGrupos
                If Not gridGrupos.CurrentRow Is Nothing Then

                    index = gridGrupos.CurrentRow.Index
                    selectedrow = gridGrupos.Rows(index)
                    lblIDGrupo.Text = selectedrow.Cells(1).Value.ToString
                    lblIDOrdem.Text = selectedrow.Cells(2).Value.ToString

                    Dim s As String = "Select * from rrGrupoQuestao where ID_Grupo = " & Val(Trim(lblIDGrupo.Text)) & ""

                    retVal = getRS(s, rs, False, sErro)
                    If retVal Then
                        da.Fill(ds, rs, "rrGrupoQuestao")

                        gridPerguntas.DataSource = (ds.Tables("rrGrupoQuestao"))

                    End If
                End If

            Case crudGrid.gridPerguntas
                If Not gridPerguntas.CurrentRow Is Nothing Then

                    index = gridPerguntas.CurrentRow.Index
                    selectedrow = gridPerguntas.Rows(index)
                    lblIDPergunta.Text = selectedrow.Cells(1).Value.ToString

                End If

        End Select

        Return True
    End Function

    Private Sub BtnUpdatePergunta_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Dim retVal As Boolean
        retVal = addEdit(crudOptions.edit)
    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub BtnUpdateGrupo_Click(sender As Object, e As EventArgs) Handles btnUpdateGrupo.Click
        Dim f As New Grupos
        Dim index As New Integer
        Dim selectedrow As DataGridViewRow
        index = gridGrupos.CurrentRow.Index
        selectedrow = gridGrupos.Rows(index)
        f.lblIDQuestionario.Text = selectedrow.Cells(0).Value.ToString
        f.ShowDialog()

    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim retVal As Boolean
        Dim sql As String = "Delete * from rrGrupoQuestao where ID_Grupo =" & Val(Trim(lblIDGrupo.Text)) & " and ID_Questao = " & Val(Trim(lblIDPergunta.Text)) & ""
        Dim sErro As String = ""
        retVal = sqlExecute(sql, sErro)
        btnPrepall.PerformClick()
    End Sub

    Private Sub listQuestionario_MouseClick(sender As Object, e As MouseEventArgs) Handles listQuestionario.MouseClick

        Dim retVal As Boolean
        Dim sErro As String = ""
        Dim da As New System.Data.OleDb.OleDbDataAdapter()
        Dim ds As New DataSet()
        Dim ponte As String


        Dim idd As Integer = listQuestionario.SelectedItems(0).SubItems(0).Text
        Dim titulo As String = listQuestionario.SelectedItems(0).SubItems(1).Text
        Dim autor As String = listQuestionario.SelectedItems(0).SubItems(2).Text
        txtTitulo.Text = titulo
        txtAutor.Text = autor

        ponte = idd.ToString

        Dim s As String = "Select * from rrQuestionarioGrupo where ID_Questionario = " & Val(Trim(idd)) & ""
        retVal = getRS(s, rs, False, sErro)

        If retVal Then
            da.Fill(ds, rs, "rrQuestionarioGrupo")
            gridGrupos.DataSource = (ds.Tables("rrQuestionarioGrupo"))
        End If
    End Sub

    Private Sub BtnListGrupos_Click(sender As Object, e As EventArgs) Handles btnListGrupos.Click
        listGrupos.View = View.Details
        listGrupos.FullRowSelect = True

        listGrupos.Columns.Add("ID", 50)
        listGrupos.Columns.Add("Titulo", 150)

        listGrupos.Items.Clear()

        Dim sql As String = "SELECT * FROM tblGrupoQuestoes"
        cmd = New OleDbCommand(sql, con)

        Try
            con.Open()
            adapter = New OleDbDataAdapter(cmd)
            adapter.Fill(dt)

            For Each row In dt.Rows
                populate2(row(0), row(1))
            Next
            dt.Rows.Clear()
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            con.Close()

        End Try
    End Sub


End Class