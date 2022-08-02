Public Class frRegistrarIngrediente
    Dim clinventario As New ClInventario()

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        convertir()
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

    Private Sub txtPesoOnzas_TextChanged(sender As Object, e As EventArgs) Handles txtPesoOnz.TextChanged

    End Sub

    Private Sub frRegistrarIngrediente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For posicion As Integer = 1 To 100
            cmbCantidad.Items.Add(posicion)
        Next
        cmbCantidad.SelectedIndex = 0
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            If (String.IsNullOrEmpty(txtNombreIngrediente.Text) Or txtNombreIngrediente.TextLength > 5) Then
                errorcito.SetError(txtNombreIngrediente, "Ingrese datos validos")
            ElseIf (String.IsNullOrEmpty(txtPesoG.Text) Or String.IsNullOrEmpty(txtPesoOnz.Text)) Then
                errorcito.SetError(GroupBox1, "Ingrese datos")
            Else
                errorcito.SetError(GroupBox1, "")
                errorcito.SetError(txtNombreIngrediente, "")

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        limpiar()
    End Sub

    Private Sub limpiar()
        txtNombreIngrediente.Clear()
        txtPesoG.Clear()
        txtPesoOnz.Clear()
        cmbCantidad.SelectedIndex = 0
    End Sub
End Class