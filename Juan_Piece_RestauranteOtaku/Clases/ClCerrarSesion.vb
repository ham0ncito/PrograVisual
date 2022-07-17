Imports Libreria_Clases
Imports System.Data.SqlClient

Public Class ClCerrarSesion
    Inherits Conexion


    Public Sub VerificarCerrarSesion(usuario As String, contrasena As String)
        Try
            Dim cmd As New SqlCommand("exec LogOut '" + usuario + "' , ' " + contrasena + "';", con)
            con.Open()
            Dim registro As SqlDataReader = cmd.ExecuteReader()
            If registro.Read() Then
                MessageBox.Show(" Sesion Cerrada ", "Nos vemos")
            End If
            Exit Try
        Catch x As SqlException
            MessageBox.Show(x.Message)
        End Try

    End Sub

End Class
