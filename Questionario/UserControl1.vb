Public Class ucSaySomething
    Dim _tbName As String
    Dim _caption As String
    Dim _pkField As String
    Dim _pkVal As String
    Dim _sayField As String
    Dim _isOK As Boolean

    Public Event pkValChanged()

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
            lblCaption.Text = s
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
            TextBox.Text = s
        End Set
    End Property
    ReadOnly Property isOK As Boolean
        Get
            isOK = _isOK
        End Get
    End Property
    Private Function say()

        Dim rs As New ADODB.Recordset
        Dim s As String, sErro As String
        Dim retval As Boolean
        sErro = ""
        lblSay.Text = ""
        _isOK = False
        If sayField = "" Then
            Exit Function
        End If
        If tbName = "" Then
            Exit Function
        End If

        If pkField = "" Then
            Exit Function
        End If

        s = "select " & Me.sayField & " from " & Me.tbName & " where " & Me.pkField & " = " & Val(Me.TextBox.Text)

        retval = getRS(s, rs, False, sErro)
        If retval Then
            If Not rs.EOF Then
                _pkVal = rs.Fields(sayField).Value
                lblSay.Text = _pkVal
                _isOK = True
                RaiseEvent pkValChanged()
            End If
        End If
    End Function

    Private Sub TextBox_TextChanged(sender As Object, e As EventArgs) Handles TextBox.TextChanged
        Dim retval As Boolean = say()

    End Sub

End Class
