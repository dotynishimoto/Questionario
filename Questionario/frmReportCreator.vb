Public Class frmReportCreator
    Private Sub CmdOk_Click(sender As Object, e As EventArgs) Handles cmdOk.Click
        frmReport.gridReport.Rows.Clear()

        Try
        Dim numColumn As Integer = 0
            Dim numRow As Integer = 0

            If Integer.TryParse(numUpColumn.Text, numColumn) Then
                frmReport.gridReport.ColumnCount = numColumn
            End If

            If Integer.TryParse(NumUpRow.Text, numRow) Then
                frmReport.gridReport.Rows.Add(numRow)
            End If


        Catch ex As Exception

            Throw ex
            'Primeir commit
        End Try

        frmReport.Show()
    End Sub
End Class