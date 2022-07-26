Imports System.IO
Imports Libreria_Clases

Public Class frPlatillos
    Dim clPlatillos As New ClPlatillos
    Private Sub frPlatillos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        clPlatillos.LlenarPlatilos(dgPlatillos)
        visibilidad(False)
    End Sub

    Private Sub btnGenerar_Click(sender As Object, e As EventArgs) Handles btnGenerar.Click
        Dim frAg As New frAgregarPlatillo()
        AddOwnedForm(frAg)
        frAg.ShowDialog()
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        If (MessageBox.Show("Desea Continuar", "Saliendo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes) Then
            Me.Close()
        End If
    End Sub

    Private Sub Tiempo_Tick(sender As Object, e As EventArgs) Handles Tiempo.Tick
        lblHora.Text = Now

    End Sub

    Private Sub dgPlatillos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgPlatillos.CellContentClick

    End Sub

    Private Sub dgPlatillos_Click(sender As Object, e As EventArgs) Handles dgPlatillos.Click
        visibilidad(True)
        PlatillosC()
        clPlatillos.datosDgIngredientes(dgPlatillos.CurrentRow.Cells(0).Value.ToString, dgIngredientes)

    End Sub

    Private Sub PlatillosC()
        For Each item As DataGridViewRow In dgPlatillos.SelectedRows
            If (Not (String.IsNullOrEmpty(item.Cells(1).Value.ToString))) Then
                lblNombre.Text = item.Cells(1).Value.ToString()
                Dim bytes As Byte() = item.Cells(6).Value
                Using ms As New MemoryStream(bytes)
                    pcImagen.Image = Image.FromStream(ms)
                End Using
                lblPrecioN.Text = "L " + item.Cells(2).Value.ToString()
                lblPrecioD.Text = "L " + item.Cells(3).Value.ToString()
                lblPrecioH.Text = "L " + item.Cells(4).Value.ToString()
                lblTipo.Text = item.Cells(5).Value.ToString()
                lblDescripcion.Text = item.Cells(7).Value.ToString
                lblPesoOnz.Text = item.Cells(8).Value.ToString() + " onz"
                lblPesoGra.Text = item.Cells(9).Value.ToString() + " g"
            Else
                visibilidad(False)
            End If
        Next
    End Sub

    Private Sub visibilidad(estado As Boolean)
        lblDescripcion.Visible = estado
        lblNombre.Visible = estado
        lblPesoGra.Visible = estado
        lblPesoOnz.Visible = estado
        lblPrecioD.Visible = estado
        lblPrecioH.Visible = estado
        lblPrecioN.Visible = estado
        lblTipo.Visible = estado
        pcImagen.Visible = estado
        dgIngredientes.Visible = estado
        lblinfo1.Visible = estado
        lblinfo2.Visible = estado
        lblinfo3.Visible = estado
        lblinfo4.Visible = estado
        lblinfo5.Visible = estado

    End Sub


    Private Sub limpiar()
        lblDescripcion.Text = "Descripcion del producto"
        lblNombre.Text = "Nombre del producto"
        lblPesoGra.Text = "00.00 onz"
        lblPesoOnz.Text = "00.00 g"
        lblPrecioD.Text = "L 00.00"
        lblPrecioH.Text = "L 00.00"
        lblPrecioN.Text = "L 00.00"
        lblTipo.Text = "Tipo de Platillo"
        pcImagen.Image = Global.Juan_Piece_RestauranteOtaku.My.Resources.Resources._149px_Picture_icon_BLACK_svg
        dgIngredientes.Columns.Clear()
    End Sub


End Class