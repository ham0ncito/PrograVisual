
Imports System.Drawing.Printing
Imports System.IO

Public Class frFacturar
    Dim ventas As New ClVentas

    Private Sub frFacturar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Me.WindowState = FormWindowState.Maximized
            dato()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Public Sub dato()
        Try
            ventas.busquedaLabel(lblDiarioVenta, "exec totalDiario")
            ventas.busquedaLabel(lblNumeroFactura, "exec nuevaFactura")
            ventas.Clientes(cmbNombres, "exec nombresCliente")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
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
        Try
            carrito()
            subPrecio()
            Subttotal()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub GenerarFactura()

    End Sub

    Private Sub Facturar()

    End Sub

    Private Sub CancelarFactura()

    End Sub

    Private Sub VerFactura()

    End Sub

    Private Sub Subttotal()
        Try
            Dim total = (Convert.ToDouble(txtCantidad.Text) * Convert.ToDouble(lblPrecio.Text))
            lblSubDetalle.Text = total.ToString
            Exit Try
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
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

    Private Sub subPrecio()
        Try
            Dim HoraFelizInicio As DateTime = DateTime.Parse("10:00:00 PM")
            Dim HoraFelizFin As DateTime = DateTime.Parse("12:00:00 PM")
            If DateTime.Now.TimeOfDay >= HoraFelizInicio.TimeOfDay And DateTime.Now.TimeOfDay < HoraFelizFin.TimeOfDay Then
                lblPrecio.Text = dgFacturar.CurrentRow.Cells(2).Value.ToString
            Else
                lblPrecio.Text = dgFacturar.CurrentRow.Cells(1).Value.ToString
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
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
        Try
            Me.imagenProducto.Image = Global.Juan_Piece_RestauranteOtaku.My.Resources.Resources._149px_Picture_icon_BLACK_svg
            lblNombre.Text = "Nombre del Producto"
            lblPrecio.Text = "0"
            txtCantidad.Text = "0"
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub limpiarDataVenta()
        Try
            CancelarDetalle()
            dgDetalle.Columns.Clear()
            cmbNombres.Text = ""
            infoDgvDetalleVenta()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub infoDgvDetalleVenta()
        Try
            If (dgDetalle.Columns.Count = 0) Then

                dgDetalle.ColumnCount = 4
                dgDetalle.Columns(0).Name = "Cantidad"
                dgDetalle.Columns(1).Name = "Nombre"
                dgDetalle.Columns(2).Name = "Precio"
                dgDetalle.Columns(3).Name = "Total"

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub AgregarCarrto()
        Try
            If (StrComp(lblNombre.Text, "Nombre del Producto") = 0) Then
                MessageBox.Show("Detalle vacio, agregue productos", "No hay productos")
            Else
                dgDetalle.Rows.Add(txtCantidad.Text, lblNombre.Text, lblPrecio.Text, lblSubDetalle.Text)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnCarrito_Click(sender As Object, e As EventArgs) Handles btnCarrito.Click
        AgregarCarrto()
    End Sub

    Private Sub dgDetalle_RowsAdded(sender As Object, e As DataGridViewRowsAddedEventArgs) Handles dgDetalle.RowsAdded
        Try
            DataGridSuma()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub DataGridSuma()
        Try
            Dim total = 0
            For Each item As DataGridViewRow In dgDetalle.Rows
                total += Convert.ToDouble(item.Cells(3).Value)
            Next
            lblSubtotal.Text = total.ToString
            lblTotal.Text = Convert.ToString(total + total * 0.15)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub cmbNombres_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbNombres.SelectedIndexChanged
        buscarId()
    End Sub
    Private Sub buscarId()
        Try
            ventas.busquedaLabel(lblCodigo, "exec buscarId '" + cmbNombres.Text + "'; ")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnNuevoCliente_Click(sender As Object, e As EventArgs) Handles btnNuevoCliente.Click
        Try
            Dim frCliente As New frNuevoCliente()
            AddOwnedForm(frCliente)

            frCliente.Show()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnGenerar_Click(sender As Object, e As EventArgs) Handles btnGenerar.Click
        Try
            Dim ps As New PrinterSettings()
            MessageBox.Show("Factura " + lblNumeroFactura.Text + " en impresion", "Venta realizada")
            Imprimir.PrinterSettings = ps
            MostrarFactura()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnCancelarVenta_Click(sender As Object, e As EventArgs) Handles btnCancelarVenta.Click
        Try
            limpiarDataVenta()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnFactura_Click(sender As Object, e As EventArgs) Handles btnFactura.Click

    End Sub

    Private Sub Imprimir_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles Imprimir.PrintPage
        Dim fuente = New Font("Arial", 12)
        Dim Titulo = New Font("Arial", 24, FontStyle.Bold)
        Dim ubicacion = 420
        e.Graphics.DrawImage(PictureBox1.Image, 350, 60, 150, 150)
        e.Graphics.DrawString(" Restaurante Juan Piece  ", Titulo, Brushes.Black, New RectangleF(250, 220, 600, 60))
        e.Graphics.DrawString(" Boulevard Morazan  3 Calle  2 Avenida  96751362 ", fuente, Brushes.Black, New RectangleF(230, 280, 1000, 100))
        e.Graphics.DrawString(String.Concat("   " + lblHora.Text + "   "), fuente, Brushes.Black, New RectangleF(280, 300, 1000, 100))
        e.Graphics.DrawString(String.Concat("Factura #  " + lblNumeroFactura.Text), fuente, Brushes.Black, New RectangleF(360, 320, 1000, 100))
        e.Graphics.DrawString(String.Concat("Cliente  " + cmbNombres.Text), fuente, Brushes.Black, New RectangleF(200, 380, 1000, 100))
        e.Graphics.DrawString("Listado de productos: ", fuente, Brushes.Black, New RectangleF(200, 420, 1000, 100))
        For Each fila As DataGridViewRow In dgDetalle.Rows

            e.Graphics.DrawString(fila.Cells(0).Value + "      " + fila.Cells(1).Value + "       " + fila.Cells(2).Value + "       " + fila.Cells(3).Value, fuente, Brushes.Black, New RectangleF(200, (ubicacion = ubicacion + 20), 1000, 100))
        Next
        e.Graphics.DrawString("Su subtotal es de : " + lblSubDetalle.Text, fuente, Brushes.Black, New RectangleF(200, (ubicacion = ubicacion + 40), 1000, 100))
        e.Graphics.DrawString("Gracias por confiar en nosotros", fuente, Brushes.Black, New RectangleF(320, (ubicacion = ubicacion + 40), 1000, 100))

    End Sub

    Private Sub ImprimirPreview_Load(sender As Object, e As EventArgs) Handles ImprimirPreview.Load

    End Sub

    Private Sub MostrarFactura()

        ImprimirPreview.Document = Imprimir
        ImprimirPreview.Show()
    End Sub
End Class