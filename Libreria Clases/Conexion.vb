Imports System.Data.SqlClient

Public Class Conexion
    Public con As New SqlConnection("Data Source=localhost;Initial Catalog=JuanPieceDb; Integrated Security=true;")

    Public Property Con1 As SqlConnection
        Get
            Return con
        End Get
        Set(value As SqlConnection)
            con = value
        End Set
    End Property

    Public Function conection()
        Dim con As New SqlConnection("Data Source =localhost; Catalog=JuanPieceDB")
        Return con
    End Function
End Class
