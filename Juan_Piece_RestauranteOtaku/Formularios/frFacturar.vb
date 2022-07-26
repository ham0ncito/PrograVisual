
Imports System.Drawing.Printing
Imports System.IO

Public Class frFacturar
    Dim ventas As New ClVentas

    Private Sub frFacturar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try

            For i As Integer = 1 To 100 Step 1
                cmbCantidad.Items.Add(i)
            Next
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
        If (MessageBox.Show("Desea Continuar", "Saliendo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes) Then
            Me.Close()
        End If

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
            Dim total = (Convert.ToDouble(cmbCantidad.Text) * Convert.ToDouble(lblPrecio.Text))
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
            cmbCantidad.Text = "1"
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

            If (DateTime.Parse(lblHora.Text) > DateTime.Parse("03:59:00 PM")) And (DateTime.Parse(lblHora.Text) < DateTime.Parse("09:01:00 PM")) Then
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

    Private Sub txtCantidad_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        CancelarDetalle()
    End Sub

    Private Sub CancelarDetalle()
        Try
            Me.imagenProducto.Image = Global.Juan_Piece_RestauranteOtaku.My.Resources.Resources._149px_Picture_icon_BLACK_svg
            lblNombre.Text = "Nombre del Producto"
            lblPrecio.Text = "0"
            lblSubDetalle.Text = "0"

            cmbCantidad.Text = "0"
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
                dgDetalle.Columns(0).HeaderText = "Cantidad"
                dgDetalle.Columns(1).Name = "NombrePlatillo"
                dgDetalle.Columns(1).HeaderText = "Nombre Platillo"
                dgDetalle.Columns(2).Name = "Precio"
                dgDetalle.Columns(2).HeaderText = "Precio"
                dgDetalle.Columns(3).Name = "Subtotal"
                dgDetalle.Columns(3).HeaderText = "Subtotal"


            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub AgregarCarrto()
        Dim existeEnCarrito = False
        Dim posicion = 0
        Try
            If (StrComp(lblNombre.Text, "Nombre del Producto") = 0) Or (Convert.ToInt32(cmbCantidad.Text) = 0) Or (lblSubDetalle.Text = "0") Or (StrComp(lblPrecio.Text, "0") = 0) Or (StrComp(lblNombre.Text, "Nombre del Producto") = 0) Then
                MessageBox.Show("Detalle vacio, agregue productos", "No hay productos")
            Else
                For Each row As DataGridViewRow In dgDetalle.Rows
                    If (StrComp(lblNombre.Text, row.Cells("NombrePlatillo").Value.ToString()) = 0) Then
                        existeEnCarrito = True
                    ElseIf existeEnCarrito = False Then
                        posicion = posicion + 1
                    End If

                Next
                If (existeEnCarrito) Then
                    If (MessageBox.Show("El producto ya fue agregado al carrito de ventas, ¿Desea volver a agregarlo", "Producto ya existe", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes) Then
                        dgDetalle.Rows(posicion).Cells("Cantidad").Value = Convert.ToDecimal(cmbCantidad.Text)
                        dgDetalle.Rows(posicion).Cells("Subtotal").Value = Convert.ToDecimal(dgDetalle.Rows(posicion).Cells("Cantidad").Value) * Convert.ToDecimal(dgDetalle.Rows(posicion).Cells("Precio").Value)

                    Else
                        MessageBox.Show("Producto no fue agregado")
                    End If
                Else
                        dgDetalle.Rows.Add(cmbCantidad.Text, lblNombre.Text, lblPrecio.Text, lblSubDetalle.Text)
                End If

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

            frCliente.ShowDialog()
            ventas.Clientes(cmbNombres, "exec nombresCliente")

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnGenerar_Click(sender As Object, e As EventArgs) Handles btnGenerar.Click
        Try
            If (dgDetalle.Rows.Count > 0) And Not (cmbNombres.SelectedItem = "") And Not (StrComp(lblTotal.Text, "00.00") = 0) And Not (StrComp(lblNombre.Text, "Nombre del Producto") = 0) Then
                Dim ps As New PrinterSettings()
                Dim clventa As New ClVentas
                clventa.nuevaVenta(lblCodigo.Text, lblNumeroFactura.Text, "1", dgDetalle)
                MessageBox.Show("Factura " + lblNumeroFactura.Text + " en impresion", "Venta realizada")
                Imprimir.PrinterSettings = ps
                MostrarFactura()
                dato()
                limpiarDataVenta()
                CancelarDetalle()
            Else
                MessageBox.Show("Ingrese todos los datos", "Falta Informacion de venta")
            End If

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
        MostrarFactura()
    End Sub

    Private Sub Imprimir_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles Imprimir.PrintPage
        Dim fuente = New Font("Arial", 12)
        Dim Titulo = New Font("Arial", 24, FontStyle.Bold)
        Dim ubicacion = 500
        e.Graphics.DrawImage(PictureBox1.Image, 350, 60, 150, 150)
        e.Graphics.DrawString(" Restaurante Juan Piece  ", Titulo, Brushes.Black, 210, 220)
        e.Graphics.DrawString(" Boulevard Morazan  3 Calle  2 Avenida  96751362 ", fuente, Brushes.Black, 230, 300)
        e.Graphics.DrawString(String.Concat("   " + lblHora.Text + "   "), fuente, Brushes.Black, 320, 340)
        e.Graphics.DrawString(String.Concat("Factura #  " + lblNumeroFactura.Text), fuente, Brushes.Black, 370, 380)
        e.Graphics.DrawString(String.Concat("Cliente  " + cmbNombres.Text), fuente, Brushes.Black, 200, 420)
        e.Graphics.DrawString("Listado de productos: ", fuente, Brushes.Black, 200, 460)
        For Each fila As DataGridViewRow In dgDetalle.Rows

            e.Graphics.DrawString(fila.Cells(0).Value + "      " + fila.Cells(1).Value + "       " + fila.Cells(2).Value + "       " + fila.Cells(3).Value, fuente, Brushes.Black, 200, ubicacion)
            ubicacion = ubicacion + 20
        Next
        ubicacion = ubicacion + 40
        e.Graphics.DrawString("Su subtotal es de : " + lblSubtotal.Text, fuente, Brushes.Black, 200, ubicacion)
        ubicacion = ubicacion + 40
        e.Graphics.DrawString("Su Total es de : " + lblTotal.Text, fuente, Brushes.Black, 200, ubicacion)
        ubicacion = ubicacion + 40
        e.Graphics.DrawString("Gracias por confiar en nosotros", fuente, Brushes.Black, 320, ubicacion)

    End Sub

    Private Sub ImprimirPreview_Load(sender As Object, e As EventArgs) Handles ImprimirPreview.Load

    End Sub

    Private Sub MostrarFactura()

        ImprimirPreview.Document = Imprimir
        ImprimirPreview.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        ImprimirPreview.ShowDialog()
    End Sub

    Private Sub cmbCantidad_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCantidad.SelectedIndexChanged
        Try
            Subttotal()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class