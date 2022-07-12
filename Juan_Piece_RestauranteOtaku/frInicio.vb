Public Class frInicio
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub timer_Tick(sender As Object, e As EventArgs) Handles timer.Tick
        lblHora.Text = Now()
    End Sub
End Class
