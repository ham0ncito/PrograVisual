Imports Libreria_Clases
Imports System.Data.SqlClient

Public Class ClCerrarSesion
    Inherits Conexion


    Public Function VerificarCerrarSesion(usuario As String, contrasena As String) As Boolean
        Try
            Dim cmd As New SqlCommand("Use JuanPieceDB; exec LogOut '" + usuario + "' , '" + contrasena + "';", con)
            con.Open()
            cmd.ExecuteNonQuery()
            Dim registro As SqlDataReader = cmd.ExecuteReader()
            If registro.Read Then
                MessageBox.Show(" Sesion Cerrada ", "Nos vemos")
                Return True
            Else
                MessageBox.Show(" Datos incorrectos ", "Error")
            End If
            Exit Try
        Catch x As SqlException
            MessageBox.Show(x.Message)

        End Try
        Return False
    End Function

    Public Function contraseñaCorrecta(usuario As String, contrasena As String) As Boolean
        Try
            Dim cmd As New SqlCommand(" exec LogOut '" + usuario + "' , '" + contrasena + "';", con)
            con.Open()
            cmd.ExecuteNonQuery()
            Dim registro As SqlDataReader = cmd.ExecuteReader()
            If registro.Read Then
                MessageBox.Show("Credenciales Verificadas ", "Verificacion")
                Return True
            Else
                MessageBox.Show(" Datos incorrectos ", "Error en verificacion de credenciales")
                Return False
            End If
            Exit Try
        Catch x As SqlException
            MessageBox.Show(x.Message)

        End Try
        Return False
    End Function

End Class
