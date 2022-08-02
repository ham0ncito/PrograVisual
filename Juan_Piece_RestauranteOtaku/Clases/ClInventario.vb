Imports System.Data.SqlClient
Imports System.IO
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

    Public Sub llenarData(comad As String, cmb As ComboBox)
        Try
            con.Open()
            cmb.Items.Clear()

            Dim comando As New SqlCommand(comad, con)
            comando.CommandType = CommandType.Text
            Dim lector As SqlDataReader = comando.ExecuteReader()
            While lector.Read()
                cmb.Items.Add(lector.GetString(0))
            End While
            con.Close()
            Exit Try
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Public Sub buscarInfo(busqueda As String, id As Label, imagen As PictureBox, descripcion As Label)
        Try
            con.Open()
            Dim cmd As New SqlCommand(busqueda, con)
            Dim img As Byte()

            Dim comando As New SqlCommand(busqueda, con)
            comando.CommandType = CommandType.Text
            Dim lector As SqlDataReader = comando.ExecuteReader()
            If lector.Read() Then
                id.Text = lector.GetValue(0).ToString
                descripcion.Text = lector.GetValue(2).ToString
                img = lector.GetValue(3)
                Using ms As New MemoryStream(img)
                    imagen.Image = Image.FromStream(ms)
                End Using
            End If
            con.Close()
            Exit Try
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Public Sub ingInfo(busqueda As String, id As Label)
        Try
            con.Open()
            Dim cmd As New SqlCommand(busqueda, con)
            Dim img As Byte()

            Dim comando As New SqlCommand(busqueda, con)
            comando.CommandType = CommandType.Text
            Dim lector As SqlDataReader = comando.ExecuteReader()
            If lector.Read() Then
                id.Text = lector.GetValue(0).ToString
            End If
            con.Close()
            Exit Try
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Public Sub agregarIngredienteAPlatillo(comando As String)
        Try
            con.Open()
            Dim cmd As New SqlCommand(comando, con)
            cmd.ExecuteNonQuery()
            con.Close()
            MessageBox.Show("Ingredientes agregado", "Ingrediente agregado", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class
