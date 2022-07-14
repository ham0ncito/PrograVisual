Public Class frLogin
    Private Sub btnlog_Click(sender As Object, e As EventArgs) Handles btnlog.Click
        Dim fr As frInicio = New frInicio()
        Me.Hide()
        AddOwnedForm(fr)
        fr.lblNombreUsuario.Text = txtUsername.Text
        fr.Show()

    End Sub

    Private Sub btnRecuperar_Click(sender As Object, e As EventArgs) Handles btnRecuperar.Click
        MessageBox.Show("Para recuperar su contraseña, contactese con su proveedor de servicios", "Recuperar contraseña", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub btnLogOut_Click(sender As Object, e As EventArgs) Handles btnLogOut.Click
        Me.Close()
    End Sub
End Class