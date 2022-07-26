Public Class frCerrarSesion
    Public nombreUsuario As String
    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim sesion As New ClCerrarSesion()

        If (sesion.VerificarCerrarSesion(nombreUsuario, txtcontrasena.Text)) Then
            Me.Hide()

            Dim fr As New frLogin()
            fr.Form1.Close()
            fr.ShowDialog()
        Else
            Me.Hide()
        End If

    End Sub
End Class