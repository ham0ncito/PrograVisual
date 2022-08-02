Public Class frAggIngrediente
    Dim clplatillo As New ClInventario()
    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCantidadUso.SelectedIndexChanged

    End Sub

    Private Sub frAggIngrediente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For i As Integer = 1 To 1000
            cmbCantidadUso.Items.Add(i)
        Next
        clplatillo.llenarData("exec NombrePlatillo", cmbPlatilo)
        clplatillo.llenarData("select nombreIngrediente from Ingredientes", cmbNombreIngrediente)
    End Sub

    Private Sub cmbPlatilo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbPlatilo.SelectedIndexChanged
        Dim sql As String = ("exec infoPlatillo '" + cmbPlatilo.SelectedItem + "'; ")
        clplatillo.buscarInfo(sql, lblCodigo, pcImagen, bllDescripcion)
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        cmbCantidadUso.SelectedIndex = 0
        pcImagen.Image = Global.Juan_Piece_RestauranteOtaku.My.Resources.Resources.Presione_el_boton_de_escanear__2_
        lblCodigo.Text = "Codigo"
        txtPeso.Clear()
        bllDescripcion.Text = "Descripcion"
    End Sub

    Private Sub btnAgg_Click(sender As Object, e As EventArgs) Handles btnAgg.Click

    End Sub
End Class