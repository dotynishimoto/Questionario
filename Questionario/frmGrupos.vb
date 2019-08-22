Public Class frmGrupos
    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Hide()
    End Sub

    Private Sub BtnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        Dim rs As New ADODB.Recordset
        Dim s As String = "Select * from tblGrupoQuestoes "
        Dim sErro As String = ""
        Dim retVal As Boolean

        retVal = getRS(s, rs, False, sErro)
        If retVal Then
            If Trim(lblIDGrupo.Text) = "" Then
                rs.AddNew()
            End If
            rs.Fields("Titulo").Value = txtTitulo.Text

            rs.Update()
                lblIDGrupo.Text = rs.Fields("ID").Value
                rs.Close()
            Else
                MsgBox("Error while opening Recordset.")

        End If


        '   s = "Select * from rrQuestionarioGrupo where ID_Questionario =" & Val(Trim(lblIDQuestionario.Text)) & " And  ID_Grupo=" & lblIDGrupo.Text & ""

        s = "Select * from rrQuestionarioGrupo"
        retVal = getRS(s, rs, False, sErro)
        If retVal Then
            If Trim(lblIDHold.Text) = "" Then
                rs.AddNew()

            End If
            rs.Fields("ID_Questionario").Value = lblIDQuestionario.Text
            rs.Fields("ID_Grupo").Value = lblIDGrupo.Text
            rs.Fields("Ordem").Value = txtOrdem.Text
            rs.Update()
            rs.Close()
        Else
            MsgBox("Error while opening Recordset.")

        End If



        rs = Nothing
        mainForm.prePall()
        Me.Hide()


    End Sub
    Public Function Prepall() As Boolean
        Dim rs As New ADODB.Recordset
        Dim s As String = "SELECT tblGrupoQuestoes.ID, tblGrupoQuestoes.Titulo, rrQuestionarioGrupo.Ordem
FROM tblGrupoQuestoes INNER JOIN rrQuestionarioGrupo ON tblGrupoQuestoes.ID = rrQuestionarioGrupo.ID_Grupo
GROUP BY tblGrupoQuestoes.ID, tblGrupoQuestoes.Titulo, rrQuestionarioGrupo.Ordem
HAVING tblGrupoQuestoes.ID=" & Val(Trim(lblIDGrupo.Text)) & ""
        Dim sErro As String = ""
        Dim retVal As Boolean

        retVal = getRS(s, rs, False, sErro)
        If retVal And Not rs.EOF Then
            txtTitulo.Text = rs.Fields("Titulo").Value
            txtOrdem.Text = rs.Fields("Ordem").Value
        End If
    End Function

    Private Sub CmdPrepall_Click(sender As Object, e As EventArgs) Handles cmdPrepall.Click
        Dim retval As Boolean = Prepall()
    End Sub
End Class