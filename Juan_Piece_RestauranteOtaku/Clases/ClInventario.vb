Imports System.Data.SqlClient
Imports Libreria_Clases


Public Class ClInventario
    Inherits Conexion

    Public Sub LlenarDatagrid(daagrid As DataGridView, sql As String, nombre As String)
        Try
            con.Open()
            Dim comando As New SqlCommand(sql, con)
            comando.CommandType = CommandType.Text
            Dim da = New SqlDataAdapter(comando)
            Dim ds = New DataSet()
            da.Fill(ds, nombre)
            If (ds.Tables(nombre).Rows.Count > 0) Then
                daagrid.DataSource = ds.Tables(nombre)
            End If
            con.Close()
        Catch x As Exception
            MessageBox.Show(x.Message)
        End Try
    End Sub
End Class
