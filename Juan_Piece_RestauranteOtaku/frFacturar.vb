
Public Class frFacturar
    Dim ventas As New ClVentas
    Private Sub frFacturar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized

    End Sub

    Private Sub btnFuerte_Click(sender As Object, e As EventArgs) Handles btnFuerte.Click
        ventas.llenarDataGrid(DataGridView1, Me.btnFuerte.Text)
    End Sub
End Class