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
        Dim frPlatillos As New frPlatillos()
        frPlatillos.Show()
    End Sub

    Private Sub btnPedidos_Click(sender As Object, e As EventArgs) Handles btnPedidos.Click
        Dim frPedidos As New frPedidos()
        frPedidos.Show()
    End Sub

    Private Sub frInicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub pMenu_Paint(sender As Object, e As PaintEventArgs) Handles pMenu.Paint

    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click

    End Sub
End Class
