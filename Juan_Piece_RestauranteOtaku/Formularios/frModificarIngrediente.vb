Public Class frModificarIngrediente
    Dim cl As New ClInventario()
    Private Sub frModificarIngrediente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For posicion As Integer = 1 To 100
            cmbCantidad.Items.Add(posicion)
        Next
        cmbCantidad.SelectedIndex = 0
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
        If (String.IsNullOrEmpty(txtNombre.Text) Or txtNombre.TextLength < 5 Or String.IsNullOrEmpty(txtPesoG.Text) Or String.IsNullOrEmpty(txtPesoOnz.Text)) Then
            MessageBox.Show("Ingrese datos", "Datos insuficientes")
        Else
            Try
                Dim sql As String = String.Concat("update Ingredientes set nombreIngrediente = '", txtNombre.Text, "', cantidadDisponible = ", cmbCantidad.SelectedItem.ToString, ", pesoOnzas = ", Convert.ToString(Convert.ToInt32(txtPesoOnz.Text)), ", pesoGramos =  ", Convert.ToString(Convert.ToInt32(txtPesoOnz.Text)), " where ingredienteId = ", Convert.ToInt32(lblCodigo.Text))
                cl.modificarInfo(sql)
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    Private Sub btnPesos_Click(sender As Object, e As EventArgs) Handles btnPesos.Click
        convertir()
    End Sub

    Private Sub cmbNombre_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbNombre.SelectedIndexChanged
        cl.ingInfo(" exec  infoIngrediente '" + cmbNombre.SelectedItem + "'; ", lblCodigo)
        cl.infoIng("exec infoIng " + lblCodigo.Text + ";", cmbCantidad, txtNombre, txtPesoG, txtPesoOnz)
    End Sub

    Private Sub limpiar()
        txtNombre.Clear()
        txtPesoOnz.Clear()
        txtPesoG.Clear()
        cmbNombre.SelectedIndex = 0

    End Sub



End Class