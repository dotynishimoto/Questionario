Public Class frmStart
    Private Sub CmdStart_Click(sender As Object, e As EventArgs) Handles cmdStart.Click
        mainForm.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        frmReportCreator.Show()
    End Sub
End Class