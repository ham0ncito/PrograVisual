Imports System.Data.SqlClient

Public Class Conexion

    Public Function conection()
        Dim con As New SqlConnection("Data Source =localhost; Catalog=JuanPieceDB")
        Return con
    End Function
End Class
