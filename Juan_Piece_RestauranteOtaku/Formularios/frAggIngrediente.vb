Public Class frAggIngrediente
    Dim clinventario As New ClInventario()
    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCantidadUso.SelectedIndexChanged

    End Sub

    Private Sub frAggIngrediente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For i As Integer = 1 To 1000
            cmbCantidadUso.Items.Add(i)
        Next
        clinventario.llenarData("exec NombrePlatillo", cmbPlatilo)
        clinventario.llenarData("select nombreIngrediente from Ingredientes", cmbNombreIngrediente)
        cmbCantidadUso.SelectedIndex = 0
        cmbNombreIngrediente.SelectedIndex = 0
        cmbPlatilo.SelectedIndex = 0
    End Sub

    Private Sub cmbPlatilo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbPlatilo.SelectedIndexChanged
        Dim sql As String = ("exec infoPlatillo '" + cmbPlatilo.SelectedItem + "'; ")
        clinventario.buscarInfo(sql, lblcodigoPlatillo, pcImagen, bllDescripcion)
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        cmbCantidadUso.SelectedIndex = 0
        pcImagen.Image = Global.Juan_Piece_RestauranteOtaku.My.Resources.Resources.Presione_el_boton_de_escanear__2_
        lblCodigoIngrediente.Text = "Codigo"
        lblcodigoPlatillo.Text = "Codigo"
        cmbNombreIngrediente.SelectedIndex = 0
        cmbPlatilo.SelectedIndex = 0
        txtPeso.Clear()
        bllDescripcion.Text = "Descripcion"
    End Sub

    Private Sub btnAgg_Click(sender As Object, e As EventArgs) Handles btnAgg.Click
        Try
            If (String.IsNullOrEmpty(txtPeso.Text)) Then
                errorcito.SetError(txtPeso, "Ingrese valores")
            ElseIf (Not (IsNumeric(txtPeso.Text)) Or Convert.ToInt32(txtPeso.Text <= 0)) Then
                errorcito.SetError(txtPeso, "Ingrese valores validos")
            Else
                errorcito.SetError(txtPeso, "")
                Dim sql As String = String.Concat("Insert into DetallePlatillos values(", Convert.ToInt32(lblcodigoPlatillo.Text), " , ", Convert.ToInt32(lblCodigoIngrediente.Text), ", ", Convert.ToInt32(cmbCantidadUso.SelectedItem), ", ", Convert.ToInt32((Convert.ToInt32(txtPeso.Text) * 0.035274)), ", ", Convert.ToInt32(txtPeso.Text), "); ")
                clinventario.agregarIngredienteAPlatillo(sql)
            End If
        Catch x As Exception
            MessageBox.Show(x.Message)
        End Try
    End Sub

    Private Sub cmbNombreIngrediente_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbNombreIngrediente.SelectedIndexChanged
        clinventario.ingInfo(" exec  infoIngrediente '" + cmbNombreIngrediente.SelectedItem + "'; ", lblCodigoIngrediente)
    End Sub
End Class