Public Class frInicio
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub timer_Tick(sender As Object, e As EventArgs) Handles timer.Tick
        lblHora.Text = Now()
    End Sub

    Private Sub btnCerrarSesion_Click(sender As Object, e As EventArgs) Handles btnCerrarSesion.Click
        Dim frCerrarSesion As New frCerrarSesion()
        AddOwnedForm(frCerrarSesion)
        frCerrarSesion.Show()
    End Sub

    Private Sub btnPlatillos_Click(sender As Object, e As EventArgs) Handles btnPlatillos.Click
        Dim frPlatillos As New frPlatillos()
        AddOwnedForm(frPlatillos)
        frPlatillos.Show()
    End Sub

    Private Sub btnPedidos_Click(sender As Object, e As EventArgs) Handles btnPedidos.Click
        Dim frInventari As New frInventario()
        AddOwnedForm(frInventari)
        frInventari.Show()
    End Sub

    Private Sub frInicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        agregarControles()
    End Sub

    Private Sub agregarControles()
        Dim control As New CLDBPlatillos()
        control.LlenarFlowLayout(FlowLayoutPanel1)
    End Sub

    Private Sub pMenu_Paint(sender As Object, e As PaintEventArgs) Handles pMenu.Paint

    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click

    End Sub

    Private Sub FlowLayoutPanel1_Paint(sender As Object, e As PaintEventArgs) Handles FlowLayoutPanel1.Paint

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub btnFactura_Click(sender As Object, e As EventArgs) Handles btnFactura.Click
        Dim frfactura As New frFacturar()
        AddOwnedForm(frfactura)
        frfactura.Show()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class
