Public Class frInicio
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub timer_Tick(sender As Object, e As EventArgs) Handles timer.Tick
        lblHora.Text = Now()
    End Sub

    Private Sub btnCerrarSesion_Click(sender As Object, e As EventArgs) Handles btnCerrarSesion.Click
        Dim frCerrarSesion As New frCerrarSesion()

        frCerrarSesion.Show()
    End Sub

    Private Sub btnPlatillos_Click(sender As Object, e As EventArgs) Handles btnPlatillos.Click

    End Sub
End Class
