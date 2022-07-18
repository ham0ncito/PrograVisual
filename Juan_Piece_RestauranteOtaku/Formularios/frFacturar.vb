
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
        Precio()
        Subttotal()
    End Sub

    Private Sub Subttotal()
        Dim total = (Convert.ToDouble(txtCantidad.Text) * Convert.ToDouble(lblPrecio.Text))
        lblSubDetalle.Text = total.ToString
    End Sub
    Private Sub carrito()
        Try
            Dim bytes As Byte() = dgFacturar.CurrentRow.Cells(4).Value
            Using ms As New MemoryStream(bytes)
                imagenProducto.Image = Image.FromStream(ms)
            End Using
            lblNombre.Text = dgFacturar.CurrentRow.Cells(0).Value.ToString
            txtCantidad.Text = "1"
            Exit Try
        Catch x As Exception
            MessageBox.Show(x.Message)
        End Try
    End Sub

    Private Sub Sumar(t As TextBox)
        If (Convert.ToInt32(t.Text) > 0) Then
            ''lblSubDetalle.Text = Convert.ToInt32(t.Text) *
        End If
    End Sub

    Private Sub Precio()
        Dim HoraFelizInicio As DateTime = DateTime.Parse("10:00:00 PM")
        Dim HoraFelizFin As DateTime = DateTime.Parse("12:00:00 PM")
        If DateTime.Now.TimeOfDay >= HoraFelizInicio.TimeOfDay And DateTime.Now.TimeOfDay < HoraFelizFin.TimeOfDay Then
            lblPrecio.Text = dgFacturar.CurrentRow.Cells(2).Value.ToString
        Else
            lblPrecio.Text = dgFacturar.CurrentRow.Cells(1).Value.ToString
        End If
    End Sub

    Private Sub lblNombre_Click(sender As Object, e As EventArgs) Handles lblNombre.Click

    End Sub

    Private Sub txtCantidad_TextChanged(sender As Object, e As EventArgs) Handles txtCantidad.TextChanged
        Try
            Subttotal()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        CancelarDetalle()
    End Sub

    Private Sub CancelarDetalle()
        Me.imagenProducto.Image = Global.Juan_Piece_RestauranteOtaku.My.Resources.Resources._149px_Picture_icon_BLACK_svg
        lblNombre.Text = "Nombre del Producto"
        lblPrecio.Text = "0"
        txtCantidad.Text = "0"

    End Sub
    Private Sub AgregarCarrto()
        If (StrComp(lblNombre.Text, "Nombre del Producto") = 0) Then
            MessageBox.Show("Detalle vacio, agregue productos", "No hay productos")
        Else
            dgDetalle.Rows.Add(txtCantidad.Text, lblNombre.Text, lblPrecio.Text, lblSubDetalle.Text)
        End If
    End Sub

    Private Sub btnCarrito_Click(sender As Object, e As EventArgs) Handles btnCarrito.Click
        AgregarCarrto()
    End Sub

    Private Sub dgDetalle_RowsAdded(sender As Object, e As DataGridViewRowsAddedEventArgs) Handles dgDetalle.RowsAdded
        DataGridSuma()
    End Sub

    Private Sub DataGridSuma()
        Dim total = 0
        For Each item As DataGridViewRow In dgDetalle.Rows
            total += Convert.ToDouble(item.Cells(3).Value)
        Next
        lblSubtotal.Text = total.ToString
        lblTotal.Text = Convert.ToString(total + total * 0.15)
    End Sub
End Class