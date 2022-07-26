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
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (String.IsNullOrEmpty(txtContraseña.Text)) Then
            errorcito.SetError(txtContraseña, "Ingrese su contraseña")
        Else
            errorcito.SetError(txtContraseña, "")
            Try
                If (clConexion.contraseñaCorrecta(frInicio.Lbl1, txtContraseña.Text)) Then
                    MessageBox.Show("Producto eliminado", "Producto ya no se encuentra en inventario activo")
                    Me.Close()
                Else
                    MessageBox.Show("No pudimos encontrar su usuario", "Error de verificacion")
                End If

            Catch ex As Exception

            End Try
        End If


    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtContraseña.TextChanged

    End Sub
End Class