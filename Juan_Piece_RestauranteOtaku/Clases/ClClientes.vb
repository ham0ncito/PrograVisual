Imports System.Data.SqlClient
Imports Libreria_Clases
Public Class ClClientes
    Inherits Conexion

    Public Sub agCliente(nombre, telefono, direccion)
        Try
            con.Open()
            Dim sql As String = "exec ingresarCliente '" + nombre + "', '" + telefono + "', '" + direccion + "';"
            Dim cmd As New SqlCommand(sql, con)
            cmd.CommandType = CommandType.Text
            cmd.ExecuteNonQuery()
            MessageBox.Show("Registro agregado", "Nuevo Cliente")
            Exit Try
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

End Class
