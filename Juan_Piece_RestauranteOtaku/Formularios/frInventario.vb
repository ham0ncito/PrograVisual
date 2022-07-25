Public Class frInventario
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub frPedidos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        If (MessageBox.Show("Desea Continuar", "Saliendo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes) Then
            Me.Close()
        End If
    End Sub
End Class