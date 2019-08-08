Public Class frmPessoas
    Public Function Prepall() As Boolean
        Dim rs As New ADODB.Recordset
        Dim s As String = "Select * from tblPessoas where ID = " & Val(Trim(lblIDPessoas.Text)) & ""
        Dim sErro As String = ""
        Dim retVal As Boolean

        retVal = getRS(s, rs, False, sErro)


        If retVal And Not rs.EOF Then
            txtNome.Text = rs.Fields("Nome").Value
            txtSobrenome.Text = rs.Fields("Sobrenome").Value
            dateDDN.Value = rs.Fields("Data_de_Nascimento").Value
            comboSexo.Text = rs.Fields("Sexo").Value
            txtCPF.Text = rs.Fields("CPF").Value
            txtProfissao.Text = rs.Fields("Profissao").Value

            'if (rs.Fields("CRM").Value).Equals(DBNull.Value) Then
            'txtCRM.Text = ""
            ' Else
            txtCRM.Text = "" & rs.Fields("CRM").Value
            'End If
            rs.Close()

        End If
            rs = Nothing
        Return retVal
    End Function
    Private Sub CmdPrepall_Click(sender As Object, e As EventArgs) Handles cmdPrepall.Click
        Dim retval As Boolean = Prepall()
    End Sub

    Private Sub CmdOk_Click(sender As Object, e As EventArgs) Handles cmdOk.Click
        Dim rs As New ADODB.Recordset
        Dim s As String = "Select * from tblPessoas where ID = " & Val(Trim(lblIDPessoas.Text)) & ""
        Dim sErro As String = ""
        Dim retVal As Boolean

        retVal = getRS(s, rs, False, sErro)

        If retVal Then
            If Trim(lblIDPessoas.Text) = "" Then
                rs.AddNew()
            End If
            rs.Fields("Nome").Value = txtNome.Text
            rs.Fields("Sobrenome").Value = txtSobrenome.Text
            rs.Fields("Sobrenome").Value = txtSobrenome.Text
            rs.Fields("Data_de_Nascimento").Value = dateDDN.Value
            rs.Fields("Sexo").Value = comboSexo.Text
            rs.Fields("CPF").Value = txtCPF.Text
            rs.Fields("Profissao").Value = txtProfissao.Text
            If txtCRM.Text <> "" Then
                rs.Fields("CRM").Value = txtCRM.Text
            End If
            If txtCPF.Text.Length = 11 Then
                rs.Update()
                rs.Close()
                Me.Hide()
            Else
                MsgBox("Campo CPF tem que conter 11 digitos")
            End If
        Else
            MsgBox("Error while opening Recordset.")
        End If

    End Sub
    Public Sub numberOnly(ByVal e As System.Windows.Forms.KeyPressEventArgs)

        If txtCPF.Text.Length < 11 Then
            If (Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57) Or Asc(e.KeyChar) = 8 Or Asc(e.KeyChar) = 44 Then
                txtCPF.BackColor = Color.White
                lblOnlyNumbers.Visible = False
            Else
                e.Handled = True
                txtCPF.BackColor = Color.Red
                lblOnlyNumbers.Visible = True
            End If
        ElseIf txtCPF.Text.Length = 10 Or Asc(e.KeyChar) = 8 Then
        Else
            e.Handled = True
        End If
    End Sub
    Private Sub txtCPF_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCPF.KeyPress
        numberOnly(e)
    End Sub

    Private Sub CmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click
        Me.Hide()
    End Sub




End Class