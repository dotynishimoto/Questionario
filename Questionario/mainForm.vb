
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports System.IO
Imports System.Data
Imports System.Reflection
Imports System.Windows.Forms.DataVisualization.Charting
Public Class mainForm

    Dim ds As New DataSet

    Private Sub BtnPrepall_Click(sender As Object, e As EventArgs) Handles cmdPrepall.Click
        prePall()
    End Sub
    Function prePall()
        Me.UcList1.tbName = "select * from  tblPessoas"
        Me.UcList1.pkField = "ID"
        Me.UcList1.sayField = "ID"
        Me.UcList1.grid1.Height = 300

        Me.UcListEnquete.tbName = "SELECT tblEnqueteRespostas.ID_Enquete, tblEnqueteRespostas.ID_Questionario, tblPessoas.Nome, tblEnqueteRespostas.Questao, tblEnqueteRespostas.Resposta, tblEnquete.Data_Dia
FROM tblPessoas INNER JOIN (tblEnquete INNER JOIN tblEnqueteRespostas ON tblEnquete.ID = tblEnqueteRespostas.ID_Enquete) ON tblPessoas.ID = tblEnquete.ID_Paciente"
        Me.UcListEnquete.pkField = "ID_Enquete"
        Me.UcListEnquete.sayField = "ID_Enquete"
        'Me.UcListEnquete.grid1.Height = 300


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
    Private Sub gridPessoas_SelectionChanged(sender As Object, e As EventArgs)
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
                    ' gridEnquete.DataSource = (ds.Tables("tblEnquete"))
                    ' gridEnquete.Columns(0).Width = 35
                    'gridEnquete.Columns(1).Width = 60
                    ' gridEnquete.Columns(2).Width = 60
                    'gridEnquete.Columns(3).Width = 60
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

    Private Sub CmdCreateChart_Click(sender As Object, e As EventArgs) Handles cmdCreateChart.Click
        Dim rs As New ADODB.Recordset
        Dim s As String, sErro As String
        Dim retval As Boolean
        sErro = ""
        s = "Select * from tblPessoas"

        retval = getRS(s, rs, False, sErro)
        If retval Then
            Do While Not rs.EOF
                Chart1.Series("Series1").Points.AddXY(rs.Fields("Nome").Value, rs.Fields("ID").Value)
                rs.MoveNext()
            Loop


        End If

    End Sub

    Function createTable()
        Dim dtblTable As New DataTable
        Dim Table As PdfPTable = New PdfPTable(dtblTable.Columns.Count)
        Dim btnColumnHeader As BaseFont = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, BaseFont.NOT_EMBEDDED)
        Dim fntColumnHeader As Font = New Font(btnColumnHeader, 10)
        Dim i As Integer = 0
        Dim j As Integer = 0

        Dim Document As Document = New Document()
        Document.SetPageSize(iTextSharp.text.PageSize.A4)
        Dim pdfWrite As PdfWriter = PdfWriter.GetInstance(Document, New FileStream("TableTeste.pdf", FileMode.Create))

        Document.Open()
        For i = 0 To i < dtblTable.Rows.Count
            Dim cell As PdfPCell = New PdfPCell()
            cell.BackgroundColor = BaseColor.GRAY
            cell.AddElement(New Chunk(dtblTable.Columns(i).ColumnName.ToUpper(), fntColumnHeader))
            Table.AddCell(cell)
        Next

        For i = 0 To i < dtblTable.Rows.Count
            For j = 0 To j < dtblTable.Columns.Count
                Table.AddCell(dtblTable.Rows(i)(j).ToString)
            Next
        Next
        Document.Add(Table)



        Document.Close()
        pdfWrite.Close()

    End Function

    Private Sub CmdCreateTable_Click(sender As Object, e As EventArgs) Handles cmdCreateTable.Click

        Dim paragraph As New Paragraph
        Dim Document As New Document(PageSize.A4, 40, 40, 40, 20)

        Dim pdfWrite As PdfWriter = PdfWriter.GetInstance(Document, New FileStream("TableTeste.pdf", FileMode.Create))

        Document.Open()
        'SETTING DATE
        Dim datee As String
        datee = "Today's date is: " & Date.Now
        Document.Add(New Paragraph(datee))
        'font
        Dim pTitle As New Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN, 16, iTextSharp.text.Font.BOLD, BaseColor.BLACK)
        Dim pHeader As New Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN, 14, iTextSharp.text.Font.BOLDITALIC, BaseColor.BLACK)
        Dim pTable As New Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN, 12, iTextSharp.text.Font.NORMAL, BaseColor.BLACK)
        paragraph = New Paragraph(New Chunk("Relatorio", pTitle))

        'insert title into pdf file
        paragraph.Alignment = Element.ALIGN_CENTER
        paragraph.SpacingAfter = 5.0F

        'set and add page with current settings
        Document.Add(paragraph)

        'create data into table
        Dim Table As New PdfPTable(Me.UcListEnquete.grid1.Columns.Count)

        'setting with of table
        Table.TotalWidth = 500.0F
        Table.LockedWidth = True

        Dim widths(0 To Me.UcListEnquete.grid1.Columns.Count - 1) As Single
        For i As Integer = 0 To Me.UcListEnquete.grid1.Columns.Count - 1
            widths(i) = 1.0F
        Next

        Table.SetWidths(widths)
        Table.HorizontalAlignment = 0
        Table.SpacingBefore = 5.0F

        'declaration pdf cells
        Dim pdfCell As PdfPCell = New PdfPCell
        pdfCell.BorderColor = BaseColor.RED

        'create header
        For i As Integer = 0 To Me.UcListEnquete.grid1.Columns.Count - 1
            pdfCell = New PdfPCell(New Phrase(New Chunk(Me.UcListEnquete.grid1.Columns(i).HeaderText, pHeader)))
            'alignment header table
            pdfCell.HorizontalAlignment = PdfPCell.ALIGN_LEFT

            'Add cells into pdf table
            Table.AddCell(pdfCell)
        Next

        'add data into pdf table
        For i As Integer = 0 To Me.UcListEnquete.grid1.Rows.Count - 2
            For j As Integer = 0 To Me.UcListEnquete.grid1.Columns.Count - 1

                pdfCell = New PdfPCell(New Phrase(Me.UcListEnquete.grid1(j, i).FormattedValue.ToString(), pTable))
                Table.HorizontalAlignment = PdfPCell.ALIGN_CENTER
                Table.AddCell(pdfCell)
            Next
        Next
        'TESTE
        Dim intTblWidth() As Integer = {20, 20, 20, 50, 50, 35}
        Table.SetWidths(intTblWidth)
        Table.WidthPercentage = 50


        Document.Add(Table)
        ' ADD CHART to PDF
        Dim chartimage As New MemoryStream()
        Chart1.SaveImage(chartimage, ChartImageFormat.Png)
        Dim Chart_Image As iTextSharp.text.Image = iTextSharp.text.Image.GetInstance(chartimage.GetBuffer())
        Chart_Image.ScalePercent(100.0F)

        ' Document.Add(Chart_Image)


        'ADD SECOND TABLE
        Dim Table2 As New PdfPTable(gridQuestionario.Columns.Count)
        Dim widths2(0 To gridQuestionario.Columns.Count - 1) As Single
        For i As Integer = 0 To gridQuestionario.Columns.Count - 1
            widths2(i) = 1.0F
        Next
        Table2.SetWidths(widths2)
        Table2.HorizontalAlignment = 0
        Table2.SpacingBefore = 5.0F

        For i As Integer = 0 To Me.gridQuestionario.Columns.Count - 1
            pdfCell = New PdfPCell(New Phrase(New Chunk(Me.gridQuestionario.Columns(i).HeaderText, pHeader)))
            pdfCell.HorizontalAlignment = PdfPCell.ALIGN_LEFT
            Table2.AddCell(pdfCell)
        Next
        For i As Integer = 0 To gridQuestionario.Rows.Count - 2
            For j As Integer = 0 To Me.gridQuestionario.Columns.Count - 1

                pdfCell = New PdfPCell(New Phrase(gridQuestionario(j, i).FormattedValue.ToString(), pTable))
                Table2.HorizontalAlignment = PdfPCell.ALIGN_CENTER
                Table2.AddCell(pdfCell)
            Next
        Next

        ' Table2.WidthPercentage = 50



        Document.Add(Table2)
        Document.Add(Chart_Image)
        Document.Close()
        pdfWrite.Close()
    End Sub


End Class