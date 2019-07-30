Public Class frmPerguntas
    Private Sub BtnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        Dim f As New mainForm
        Dim rs As New ADODB.Recordset
        Dim s As String = "Select * from tblQuestoes where ID = " & Val(Trim(lblIDPergunta.Text)) & ""
        Dim sErro As String = ""
        Dim retVal As Boolean

        retVal = getRS(s, rs, False, sErro)

        If retVal Then

            If Trim(lblIDPergunta.Text) = "" Then
                rs.AddNew()
            End If
            rs.Fields("Questao").Value = txtQuestao.Text
            rs.Fields("Tipo").Value = comboTipo.Text
            rs.Fields("Respostas").Value = txtRespostas.Text
            rs.Fields("RangeMax").Value = txtRangeMax.Text
            rs.Fields("RangeMin").Value = txtRangeMin.Text
            rs.Fields("Stepp").Value = txtStep.Text
            rs.Update()
            lblIDPergunta.Text = rs.Fields("ID").Value
            rs.Close()
        Else
            MsgBox("Error while opening Recordset.")
        End If

        s = "Select * from rrGrupoQuestao "
        retVal = getRS(s, rs, False, sErro)
        If retVal Then
            If Trim(lblIDHold.Text) = "" Then
                rs.AddNew()
                rs.Fields("ID_Grupo").Value = lblIDGrupo.Text
                rs.Fields("ID_Questao").Value = lblIDPergunta.Text
                rs.Fields("Ordem").Value = lblIDPergunta.Text
                rs.Update()
                rs.Close()
            End If
        Else
            MsgBox("Error while opening Recordset.")
        End If

        mainForm.prePall()
        rs = Nothing
        Me.Hide()
    End Sub
    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Hide()
    End Sub
    Public Function Prepall() As Boolean
        Dim rs As New ADODB.Recordset
        Dim s As String = "Select * from tblQuestoes where ID = " & Val(Trim(lblIDPergunta.Text)) & ""
        Dim sErro As String = ""
        Dim retVal As Boolean

        retVal = getRS(s, rs, False, sErro)
        If retVal And Not rs.EOF Then
            txtQuestao.Text = rs.Fields("Questao").Value
            comboTipo.Text = rs.Fields("Tipo").Value
            txtRespostas.Text = rs.Fields("Respostas").Value
            txtRangeMax.Text = rs.Fields("RangeMax").Value
            txtRangeMin.Text = rs.Fields("RangeMin").Value
            txtStep.Text = rs.Fields("Stepp").Value
            rs.Close()

        End If
        rs = Nothing
        Return retVal
    End Function
    Private Sub BtnPrepall_Click(sender As Object, e As EventArgs) Handles btnPrepall.Click
        Dim retval As Boolean = Prepall()
    End Sub

End Class