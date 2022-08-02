Public Class frModificarIngrediente
    Dim cl As New ClInventario()
    Private Sub frModificarIngrediente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cl.llenarData("select nombreIngrediente from Ingredientes", cmbNombre)
        cmbNombre.SelectedIndex = 0
    End Sub


    Private Sub convertir()
        If (String.IsNullOrEmpty(txtPesoG.Text)) And Not (String.IsNullOrEmpty(txtPesoOnz.Text)) And IsNumeric(txtPesoOnz.Text) Then
            txtPesoG.Text = Convert.ToDecimal(txtPesoOnz.Text) / 0.035274
        ElseIf (String.IsNullOrEmpty(txtPesoOnz.Text)) And Not (String.IsNullOrEmpty(txtPesoG.Text)) And IsNumeric(txtPesoG.Text) Then
            txtPesoOnz.Text = Convert.ToDecimal(txtPesoG.Text) * 0.035274
        ElseIf Not (String.IsNullOrEmpty(txtPesoG.Text)) And Not (String.IsNullOrEmpty(txtPesoOnz.Text)) And IsNumeric(txtPesoG.Text) And IsNumeric(txtPesoOnz.Text) Then
            MessageBox.Show("No se puede convertir si ambos textbox se encuentran con valores", "Error")
        Else
            MessageBox.Show("Valores no validos", "Error")
        End If
    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click

    End Sub

    Private Sub btnPesos_Click(sender As Object, e As EventArgs) Handles btnPesos.Click
        convertir()
    End Sub

    Private Sub cmbNombre_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbNombre.SelectedIndexChanged
        cl.ingInfo(" exec  infoIngrediente '" + cmbNombre.SelectedItem + "'; ", lblCodigo)
    End Sub
End Class