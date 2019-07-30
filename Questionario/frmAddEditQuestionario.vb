Public Class frmAddEditQuestionario
    Public Function Prepall() As Boolean
        Dim rs As New ADODB.Recordset
        Dim s As String = "Select * from tblQuestionarios where ID = " & Val(Trim(lblIDQuestionario.Text)) & ""
        Dim sErro As String = ""
        Dim retVal As Boolean

        retVal = getRS(s, rs, False, sErro)
        If retVal And Not rs.EOF Then
            txtTitulo.Text = rs.Fields("Titulo").Value
            txtAutor.Text = rs.Fields("Autor").Value
            rs.Close()

        End If
        rs = Nothing
        Return retVal
    End Function

    Private Sub CmdPrepall_Click(sender As Object, e As EventArgs) Handles cmdPrepall.Click
        Dim retval As Boolean = Prepall()
    End Sub

    Private Sub CmdOK_Click(sender As Object, e As EventArgs) Handles cmdOK.Click
        Dim rs As New ADODB.Recordset
        Dim s As String = "Select * from tblQuestionarios where ID = " & Val(Trim(lblIDQuestionario.Text)) & ""
        Dim sErro As String = ""
        Dim retVal As Boolean

        retVal = getRS(s, rs, False, sErro)

        If retVal Then

            If Trim(lblIDQuestionario.Text) = "" Then
                rs.AddNew()
            End If
            rs.Fields("Titulo").Value = txtTitulo.Text
            rs.Fields("Autor").Value = txtAutor.Text
            rs.Update()
            rs.Close()
        Else
            MsgBox("Error while opening Recordset.")
        End If
        mainForm.cmdPrepall.PerformClick()
        Me.Hide()

    End Sub

    Private Sub CmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click
        Me.Hide()
    End Sub


End Class