Public Enum crudOptions
    addNew = -1
    edit = 0
End Enum
Public Enum crudDelete
    Questionario = 0
    Pessoa = 1
    Pergunta = 2
End Enum

Public Enum crudGrid
    gridGrupos = 0
    gridPerguntas = 1
    gridQuestionario = 2
    gridPessoas = 3
    gridEnquete = 4
    gridUpdateGrupo = 5
    gridListPerguntas = 6
End Enum

Public Enum enumfldType
    Unkown
    Texto
    Inteiro
    Dec
    Dia
End Enum
Public Enum crudTipo
    txtRespostaTexto = 0
    txtRespostaNum = 1
    comboOpcao = 2
    datePicker = 3
End Enum
Module Trick
    Public Function getRS(ByVal sql As String, rs As ADODB.Recordset, ByVal RO As Boolean, ByRef sErro As String) As Boolean
        Dim Con As New ADODB.Connection

        On Error Resume Next
        Con.Open("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Doty\Desktop\Questionarios\Questionario.mdb;Persist Security Info=true")
        Con.CursorLocation = ADODB.CursorLocationEnum.adUseClient

        rs.Open(sql, Con, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
        If Err.Number = 0 Then
            Return True
        Else

            sErro = Err.Description
            Return False

        End If
        On Error GoTo 0
        'Con.Close()

    End Function
    Public Function sqlExecute(ByVal sql As String, ByRef sErro As String) As Boolean
        Dim Con As New ADODB.Connection

        'On Error Resume Next
        Con.Open("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Doty\Desktop\Questionarios\Questionario.mdb;Persist Security Info=true")
        'Dim cmd As ADODB.SqlCommand = New SqlCommand(sql, Con)
        Con.Execute(sql)

        Con.Close()
        Return True

    End Function
End Module
