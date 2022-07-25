Public Class frNuevoCliente

    Public combobox As ComboBox


    Private Sub btnAgCliente_Click(sender As Object, e As EventArgs) Handles btnAgCliente.Click
        errorProvider()

    End Sub

    Public Sub errorProvider()
        If (String.IsNullOrEmpty(txtDirec.Text) And String.IsNullOrEmpty(txtNombre.Text) And String.IsNullOrEmpty(txtTelefono.Text)) Then
            ErrorProvider1.SetError(btnAgCliente, "Ingrese todos los datos para continuar")
        ElseIf (IsNumeric(txtTelefono.Text)) And (Len(txtTelefono.Text) = 8) And (Len(txtNombre.Text) > 5) And (Len(txtDirec.Text) > 10) And (repite(txtNombre.Text)) And (repite(txtDirec.Text)) Then
            ErrorProvider1.SetError(btnAgCliente, "")
            agregarCliente()
            limpiar()

            frFacturar.cmbNombres.Items.Add(txtNombre.Text)
            frFacturar.dato()
        Else
            ErrorProvider1.SetError(btnAgCliente, "Valores no validos")
        End If
    End Sub

    Public Function repite(str As String) As Boolean
        Dim cantidadRepetida = 0
        Try
            For i As Integer = 1 To Len(str) - 1
                If (StrComp(str.Chars(i), str.Chars(i - 1)) = 0) Then
                    cantidadRepetida = cantidadRepetida + 1
                End If
            Next
            If (cantidadRepetida >= (Math.Round(Len(str) / 2))) Then
                Return False
            Else
                Return True
            End If
        Catch x As Exception
            MessageBox.Show(x.Message)
        End Try

    End Function

    Public Sub agregarCliente()
        Dim cClientes As New ClClientes
        cClientes.agCliente(txtNombre.Text, txtTelefono.Text, txtDirec.Text)
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

    Private Sub txtNombre_TextChanged(sender As Object, e As EventArgs) Handles txtNombre.TextChanged

    End Sub
End Class