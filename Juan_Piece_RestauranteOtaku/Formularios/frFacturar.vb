
Imports System.IO

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

    Private Sub dgFacturar_RowEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgFacturar.RowEnter
        ''pcImagen.Image = dgFacturar.CurrentRow.Cells()
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub lblHora_Click(sender As Object, e As EventArgs) Handles lblHora.Click

    End Sub

    Private Sub Tiempo_Tick(sender As Object, e As EventArgs) Handles Tiempo.Tick
        lblHora.Text = Now()
    End Sub

    Private Sub dgFacturar_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgFacturar.CellContentClick

    End Sub

    Private Sub dgFacturar_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgFacturar.CellClick
        carrito()
    End Sub

    Private Sub carrito()
        Dim bytes As Byte() = dgFacturar.CurrentRow.Cells(4).Value
        Using ms As New MemoryStream(bytes)
            imagenProducto.Image = Image.FromStream(ms)
        End Using
        lblNombre.Text = dgFacturar.CurrentRow.Cells(0).Value.ToString
    End Sub

    Private Sub lblNombre_Click(sender As Object, e As EventArgs) Handles lblNombre.Click

    End Sub
End Class