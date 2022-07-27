Public Class frEliminarPlatillo
    Dim clPlato As New ClPlatillos()
    Dim clConexion As New ClCerrarSesion()
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub cmbPlatillosActivos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbPlatillosActivos.SelectedIndexChanged
        clPlato.DataEliminacion(Convert.ToInt64(cmbPlatillosActivos.Text), lblNombre, lblDescripcion, imagenPlatillo)
    End Sub

    Private Sub lblDescripcion_Click(sender As Object, e As EventArgs) Handles lblDescripcion.Click

    End Sub

    Private Sub frEliminarPlatillo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        clPlato.idPlatillos(cmbPlatillosActivos)
        cmbPlatillosActivos.SelectedIndex = 0
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim posicion As Integer = cmbPlatillosActivos.SelectedIndex()
        If (String.IsNullOrEmpty(txtContraseña.Text)) Then
            errorcito.SetError(txtContraseña, "Ingrese su contraseña")
        Else
            errorcito.SetError(txtContraseña, "")
            Try
                If (clConexion.contraseñaCorrecta(ClStaticUsuarios.user, txtContraseña.Text)) Then
                    clPlato.eliminar(cmbPlatillosActivos.SelectedItem)
                    MessageBox.Show(ClStaticUsuarios.user + " El producto seleccionado fue suspendido", "Producto ya no se encuentra en inventario activo")
                    cmbPlatillosActivos.Items.RemoveAt(posicion)
                    cmbPlatillosActivos.SelectedIndex = 0


                Else
                    MessageBox.Show("No pudimos encontrar su usuario", "Error de verificacion")
                End If

            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If


    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtContraseña.TextChanged

    End Sub
End Class