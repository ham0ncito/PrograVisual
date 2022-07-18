Public Class frPlatillos
    Private Sub frPlatillos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        Dim clPlatillos As New ClPlatillos
        clPlatillos.LlenarPlatilos(dgPlatillos)
    End Sub

    Private Sub btnGenerar_Click(sender As Object, e As EventArgs) Handles btnGenerar.Click

    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub Tiempo_Tick(sender As Object, e As EventArgs) Handles Tiempo.Tick
        lblHora.Text = Now

    End Sub

    Private Sub dgPlatillos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgPlatillos.CellContentClick

    End Sub

    Private Sub dgPlatillos_Click(sender As Object, e As EventArgs) Handles dgPlatillos.Click

        For Each item As DataGridViewRow In dgPlatillos.SelectedRows
            If (Not (String.IsNullOrEmpty(item.Cells(1).Value.ToString))) Then
                lblNombre.Text = item.Cells(1).Value.ToString()
                ''pcImagen.Image = item.Cells(5).
            Else
                limpiar()
            End If
        Next
    End Sub

    Private Sub limpiar()
        lblDescripcion.Text = "Descripcion del producto"
        lblNombre.Text = "Nombre del producto"
        lblPesoGra.Text = "00.00"
        lblPesoOnz.Text = "00.00"
        lblPrecioD.Text = "00.00"
        lblPrecioH.Text = "00.00"
        lblPrecioN.Text = "00.00"
        lblTipo.Text = "Tipo de Platillo"
        pcImagen.Image = Global.Juan_Piece_RestauranteOtaku.My.Resources.Resources._149px_Picture_icon_BLACK_svg
    End Sub
End Class