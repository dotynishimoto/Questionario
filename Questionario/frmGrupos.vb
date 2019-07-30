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
            rs.AddNew()
            rs.Fields("Titulo").Value = txtTitulo.Text
            rs.Update()
            lblID.Text = rs.Fields("ID").Value
            rs.Close()
        Else
            MsgBox("Error while opening Recordset.")

        End If

        s = "Select * from rrQuestionarioGrupo "
        retVal = getRS(s, rs, False, sErro)
        If retVal Then
            rs.AddNew()
            rs.Fields("ID_Questionario").Value = lblIDQuestionario.Text
            rs.Fields("ID_Grupo").Value = lblID.Text
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


End Class