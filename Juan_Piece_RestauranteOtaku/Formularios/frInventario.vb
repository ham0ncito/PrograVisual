Public Class frInventario
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub frPedidos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim clinventario As New ClInventario()
            clinventario.LlenarDatagrid(dgInventario, "exec Inventario", "Inventario")
            clinventario.LlenarDatagrid(dgIngresos, "exec ultimosIngresos", "Ingresos")
        Catch x As Exception
            MessageBox.Show(x.Message)
        End Try
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnElim.Click
        If (MessageBox.Show("Desea Continuar", "Saliendo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes) Then
            Me.Close()
        End If
    End Sub

    Private Sub dgInventario_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgInventario.CellContentClick

    End Sub

    Private Sub btnMod_Click(sender As Object, e As EventArgs) Handles btnMod.Click
        Dim frag As New frModificarIngrediente()
        AddOwnedForm(frag)
        frag.ShowDialog()
    End Sub

    Private Sub btnag_Click(sender As Object, e As EventArgs) Handles btnag.Click
        Dim frag As New frAggIngrediente()
        AddOwnedForm(frag)
        frag.ShowDialog()
    End Sub

    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click
        Dim frag As New frRegistrarIngrediente()
        AddOwnedForm(frag)
        frag.ShowDialog()
    End Sub

    Private Sub btnReporte_Click(sender As Object, e As EventArgs) Handles btnReporte.Click
        ImprimirPreview.Document = ImpInventario
        ImprimirPreview.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        ImprimirPreview.ShowDialog()
    End Sub

    Private Sub Imprimir_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles ImpInventario.PrintPage
        Dim fuente = New Font("Arial", 12)
        Dim Titulo = New Font("Arial", 24, FontStyle.Bold)
        Dim ubicacion = 400
        e.Graphics.DrawImage(PictureBox1.Image, 350, 60, 150, 100)
        e.Graphics.DrawString(" Restaurante Juan Piece  ", Titulo, Brushes.Black, 210, 200)
        e.Graphics.DrawString(" Reporte de Inventario Activo ", fuente, Brushes.Black, 280, 240)
        e.Graphics.DrawString(String.Concat("   " + lblHora.Text + "   "), fuente, Brushes.Black, 300, 260)
        e.Graphics.DrawString("Listado de inventario : ", fuente, Brushes.Black, 20, 320)
        e.Graphics.DrawString("Nombre       Cantidad        Proveedor       Telefono        Correo Electronico   ", fuente, Brushes.Black, 20, 360)
        For Each fila As DataGridViewRow In dgInventario.Rows

            e.Graphics.DrawString(fila.Cells(0).Value.ToString + "    ||   " + fila.Cells(1).Value.ToString + "    ||   " + fila.Cells(4).Value.ToString + "    ||   " + fila.Cells(5).Value.ToString + "    ||   " + fila.Cells(6).Value.ToString + " || ", fuente, Brushes.Black, 20, ubicacion)
            ubicacion = ubicacion + 30
        Next



    End Sub

    Private Sub Tiempo_Tick(sender As Object, e As EventArgs) Handles Tiempo.Tick
        lblHora.Text = TimeOfDay
    End Sub

    Private Sub btnReporteIngresos_Click(sender As Object, e As EventArgs) Handles btnReporteIngresos.Click
        ImpIngresos.Document = ImprimirIngresos
        ImpIngresos.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        ImpIngresos.ShowDialog()
    End Sub

    Private Sub ImprimirIngresos_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles ImprimirIngresos.PrintPage
        Dim fuente = New Font("Arial", 12)
        Dim fuente2 = New Font("Arial", 10)
        Dim Titulo = New Font("Arial", 24, FontStyle.Bold)
        Dim ubicacion = 400
        e.Graphics.DrawImage(PictureBox1.Image, 350, 60, 150, 100)
        e.Graphics.DrawString(" Restaurante Juan Piece  ", Titulo, Brushes.Black, 210, 200)
        e.Graphics.DrawString(" Reporte de ultimos Ingresos ", fuente, Brushes.Black, 280, 240)
        e.Graphics.DrawString(String.Concat("   " + lblHora.Text + "   "), fuente, Brushes.Black, 300, 260)
        e.Graphics.DrawString("Listado de ingresos : ", fuente, Brushes.Black, 20, 320)
        e.Graphics.DrawString("Producto Comprado    Cantidad    Precio de Compra    Nombre del Proveedor    Fecha Ingreso", fuente2, Brushes.Black, 20, 360)
        For Each fila As DataGridViewRow In dgIngresos.Rows

            e.Graphics.DrawString(fila.Cells(0).Value.ToString + "    ||   " + fila.Cells(2).Value.ToString + "    ||   " + fila.Cells(3).Value.ToString + "    ||   " + fila.Cells(4).Value.ToString + "    ||   " + fila.Cells(1).Value.ToString + " || ", fuente, Brushes.Black, 20, ubicacion)
            ubicacion = ubicacion + 30
        Next
    End Sub
End Class