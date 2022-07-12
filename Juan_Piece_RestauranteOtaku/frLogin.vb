Public Class frLogin
    Private Sub btnlog_Click(sender As Object, e As EventArgs) Handles btnlog.Click
        Dim fr As frInicio = New frInicio()
        Me.Hide()
        fr.Show()

    End Sub
End Class