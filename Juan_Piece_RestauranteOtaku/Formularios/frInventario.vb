Public Class frInventario
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub frPedidos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim clinventario As New ClInventario()
            clinventario.LlenarDatagrid(dgInventario, "exec Inventario", "Inventario")
            clinventario.LlenarDatagrid(dgIngresos, "exec ultimosIngresos", "Ingresos")
        Catch x As Exception
            MessageBox.Show(x.Message)
        End Try
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnElim.Click
        If (MessageBox.Show("Desea Continuar", "Saliendo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes) Then
            Me.Close()
        End If
    End Sub

    Private Sub dgInventario_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgInventario.CellContentClick

    End Sub
End Class