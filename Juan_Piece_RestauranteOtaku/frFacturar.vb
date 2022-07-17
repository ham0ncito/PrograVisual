
Public Class frFacturar
    Dim ventas As New ClVentas
    Private Sub frFacturar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized

    End Sub

    Private Sub btnFuerte_Click(sender As Object, e As EventArgs) Handles btnFuerte.Click
        ventas.llenarDataGrid(dgFacturar, "Plato Fuerte")
    End Sub

    Private Sub btnEntradas_Click(sender As Object, e As EventArgs) Handles btnEntradas.Click
        ventas.llenarDataGrid(dgFacturar, btnEntradas.Text)
    End Sub

    Private Sub btnSnacks_Click(sender As Object, e As EventArgs) Handles btnSnacks.Click
        ventas.llenarDataGrid(dgFacturar, btnSnacks.Text)
    End Sub

    Private Sub btnSopas_Click(sender As Object, e As EventArgs) Handles btnSopas.Click
        ventas.llenarDataGrid(dgFacturar, btnSopas.Text)
    End Sub

    Private Sub btnRamen_Click(sender As Object, e As EventArgs) Handles btnRamen.Click
        ventas.llenarDataGrid(dgFacturar, btnRamen.Text)
    End Sub

    Private Sub btnSushi_Click(sender As Object, e As EventArgs) Handles btnSushi.Click
        ventas.llenarDataGrid(dgFacturar, btnSushi.Text)
    End Sub

    Private Sub btnPasteles_Click(sender As Object, e As EventArgs) Handles btnPasteles.Click
        ventas.llenarDataGrid(dgFacturar, btnPasteles.Text)
    End Sub

    Private Sub btnOtros_Click(sender As Object, e As EventArgs) Handles btnOtros.Click
        ventas.llenarDataGrid(dgFacturar, btnOtros.Text)
    End Sub
End Class