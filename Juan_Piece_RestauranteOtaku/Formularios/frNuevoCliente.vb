Public Class frNuevoCliente
    Private Sub btnAgCliente_Click(sender As Object, e As EventArgs) Handles btnAgCliente.Click
        errorProvider()

    End Sub

    Private Sub errorProvider()
        If (String.IsNullOrEmpty(txtDirec.Text) And String.IsNullOrEmpty(txtNombre.Text) And String.IsNullOrEmpty(txtTelefono.Text)) Then
            ErrorProvider1.SetError(btnAgCliente, "Ingrese todos los datos para continuar")
        Else
            ErrorProvider1.SetError(btnAgCliente, "Ingrese todos los datos para continuar")
        End If
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        limpiar()
    End Sub
    Private Sub limpiar()
        If (String.IsNullOrEmpty(txtDirec.Text) And String.IsNullOrEmpty(txtNombre.Text) And String.IsNullOrEmpty(txtTelefono.Text)) Then
            ErrorProvider1.SetError(btnCancelar, "No hay datos para limipiar")
        Else
            ErrorProvider1.SetError(btnCancelar, "")
            txtDirec.Clear()
            txtNombre.Clear()
            txtTelefono.Clear()
        End If
    End Sub
End Class