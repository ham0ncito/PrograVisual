Public Class frCerrarSesion
    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim sesion As New ClCerrarSesion
        sesion.VerificarCerrarSesion(frInicio.lblUsuario.Text, txtcontrasena.Text)
        frInicio.Close()
        Dim fr As New frLogin()
        fr.Show()
    End Sub
End Class