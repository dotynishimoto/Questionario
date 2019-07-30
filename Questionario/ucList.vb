Public Class ucList
    Dim _tbName As String
    Dim _caption As String
    Dim _pkField As String
    Dim _pkVal As String
    Dim _sayField As String
    Dim somestring As String
    Dim somestring2() As String
    Public selectedrow As DataGridViewRow

    Property tbName As String
        Get
            tbName = _tbName
        End Get
        Set(s As String)
            _tbName = s
        End Set
    End Property

    Property sayField As String
        Get
            sayField = _sayField
        End Get
        Set(s As String)
            _sayField = s
        End Set
    End Property

    Property Caption As String
        Get
            Caption = _caption
        End Get
        Set(s As String)
            ' lblCaption.Text = s
            _caption = s
        End Set
    End Property

    Property pkField As String
        Get
            pkField = _pkField
        End Get
        Set(s As String)
            _pkField = s
        End Set
    End Property

    Property pkVal As String
        Get
            pkVal = _pkVal
        End Get
        Set(s As String)
            _pkVal = s
            txtVal.Text = s
        End Set
    End Property



    Private Sub comboCampo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboCampo.SelectedIndexChanged
        Dim rs As New ADODB.Recordset
        Dim s As String, sErro As String
        Dim retval As Boolean
        sErro = ""
        s = "select * from " & Me.tbName
        retval = getRS(s, rs, False, sErro)
        If retval Then
            comboOperador.Items.Clear()
            Select Case fldType(rs.Fields(comboCampo.SelectedItem))
                Case enumfldType.Inteiro
                    comboOperador.Items.Add("=")
                    comboOperador.Items.Add(">=")
                    comboOperador.Items.Add("<=")
                Case enumfldType.Texto
                    comboOperador.Items.Add("=")
                    comboOperador.Items.Add("Like")
                Case enumfldType.Dia
                    comboOperador.Items.Add("=")
                    comboOperador.Items.Add(">=")
                    comboOperador.Items.Add("<=")
            End Select
        End If
    End Sub
    Function fldType(fld As ADODB.Field) As enumfldType
        Select Case fld.Type
            Case ADODB.DataTypeEnum.adInteger
                Return enumfldType.Inteiro
            Case ADODB.DataTypeEnum.adDecimal, ADODB.DataTypeEnum.adCurrency
                Return enumfldType.Dec
            Case ADODB.DataTypeEnum.adVarWChar, ADODB.DataTypeEnum.adChar
                Return enumfldType.Texto
            Case ADODB.DataTypeEnum.adDate
                Return enumfldType.Dia
            Case Else
                Return enumfldType.Unkown
        End Select
    End Function

    Private Sub cmdFilter_Click(sender As Object, e As EventArgs) Handles cmdFilter.Click
        Dim ds As New DataSet
        Dim da As New System.Data.OleDb.OleDbDataAdapter
        Dim rs As New ADODB.Recordset
        Dim s As String, sErro As String
        Dim retval As Boolean
        sErro = ""

        prepGrid(rs, s, sErro, retval)

        Dim sep As String = ""

        If retval Then
            If rs.Fields(comboCampo.SelectedItem).Type = ADODB.DataTypeEnum.adVarWChar Then
                sep = Chr(39)
            Else
                sep = ""
            End If
        End If

        rs.Close()

        Dim sw As String = comboCampo.SelectedItem & " " & comboOperador.SelectedItem
        If (comboOperador.SelectedItem) = "Like" Then
            sw = Replace(sw, sw, sw & sep & "%" & txtVal.Text & "%" & sep)
        ElseIf rs.Fields(comboCampo.SelectedItem).Type = ADODB.DataTypeEnum.adDate Then
            sw = Replace(sw, sw, sw & sep & "'#" & txtVal.Text & "#'" & sep)
        Else
            sw = Replace(sw, sw, sw & sep & txtVal.Text & sep)
        End If

        If sw <> "" Then
            s = Replace(s, s, s & " where " & sw)
            retval = getRS(s, rs, False, sErro)
            If retval Then
                da.Fill(ds, rs, tbName)
                grid1.DataSource = (ds.Tables(tbName))
            End If
        End If
    End Sub

    Private Sub grid1_SelectionChanged(sender As Object, e As EventArgs) Handles grid1.SelectionChanged
        Dim rs As New ADODB.Recordset
        Dim s As String, sErro As String
        Dim retval As Boolean
        Dim filterValues = {Nothing, Nothing, Me.tbName, Nothing}
        sErro = ""
        Dim somestring As String
        Dim index

        prepGrid(rs, s, sErro, retval)
        If retval Then


            If Not grid1.CurrentRow Is Nothing Then

                index = grid1.CurrentRow.Index
                selectedrow = grid1.Rows(index)
                ' For n = 0 To rs.Fields.Count - 1
                'somestring = (rs.Fields(n).Name)
                ' Next n

                ' _pkVal = selectedrow.Cells(sayField).Value.ToString
                ' lblSay2.Text = _pkVal

                _pkField = selectedrow.Cells(sayField).Value.ToString
                lblSay.Text = _pkField
            End If
        End If
    End Sub

    Private Sub CmdPrepall_Click(sender As Object, e As EventArgs) Handles cmdPrepall.Click
        grid1.Columns.Clear()
        Dim ds As New DataSet
        Dim da As New System.Data.OleDb.OleDbDataAdapter
        Dim rs As New ADODB.Recordset
        Dim s As String, sErro As String
        Dim retval As Boolean
        sErro = ""

        prepGrid(rs, s, sErro, retval)


        comboCampo.Items.Clear()
        comboOperador.Items.Clear()
        If retval Then

            da.Fill(ds, rs, tbName)
            grid1.DataSource = (ds.Tables(tbName))

            For i = 0 To rs.Fields.Count - 1
                comboCampo.Items.Add(rs.Fields.Item(i).Name)
            Next
        End If
    End Sub
    Function prepGrid(rs As ADODB.Recordset, ByRef s As String, sErro As String, ByRef retval As Boolean) As Boolean

        s = "select * from " & Me.tbName
        retval = getRS(s, rs, False, sErro)

        Return True
    End Function

End Class
