﻿Imports System.Data.SqlClient
Imports System.IO
Imports Libreria_Clases



Public Class ClPlatillos
    Inherits Conexion
    Public Sub LlenarPlatilos(datagid)
        datagid.Columns.Clear()
        datagid.AlternatingRowsDefaultCellStyle.BackColor = Color.Goldenrod
        datagid.DefaultCellStyle.ForeColor = Color.Black
        Try
            Dim sql As String = "exec todosPlatillos;"
            Dim cmd As New SqlCommand(sql, con)
            cmd.CommandType = CommandType.Text
            Dim da = New SqlDataAdapter(cmd)
            Dim ds = New DataSet()
            da.Fill(ds, "Platillos")
            datagid.DataSource = ds.Tables("Platillos")
            Exit Try
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Public Sub Ingredientes(datagid, id)
        datagid.Columns.Clear()
        datagid.AlternatingRowsDefaultCellStyle.BackColor = Color.Goldenrod
        datagid.DefaultCellStyle.ForeColor = Color.Black
        Try
            Dim sql As String = "exec Ingredientes '" + id + "';"
            Dim cmd As New SqlCommand(sql, con)
            cmd.CommandType = CommandType.Text
            Dim da = New SqlDataAdapter(cmd)
            Dim ds = New DataSet()
            da.Fill(ds, "Ingredientes")
            datagid.DataSource = ds.Tables("Ingredientes")
            Exit Try
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Public Sub datosDgIngredientes(id, dgIngredientes)
        Try
            dgIngredientes.Columns.Clear()
            con.Open()
            Dim sql As String = "exec todosIngredientes '" + id + "';"
            Dim cmd As New SqlCommand(sql, con)
            cmd.CommandType = CommandType.Text
            Dim da = New SqlDataAdapter(cmd)
            Dim ds = New DataSet()
            da.Fill(ds, "Ingredientes")
            If (ds.Tables("Ingredientes").Rows.Count > 0) Then
                dgIngredientes.DataSource = ds.Tables("Ingredientes")
            Else
                MessageBox.Show("Este producto no tiene ingredientes agregados", "Inventario", MessageBoxButtons.OK, MessageBoxIcon.Hand)
            End If
            con.Close()
            Exit Try
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Public Sub tipos(combo As ComboBox)
        Try
            combo.Items.Clear()
            con.Open()
            Dim sql As String = "exec nombresPlatillos"
            Dim comando As New SqlCommand(sql, con)
            comando.CommandType = CommandType.Text
            Dim lector As SqlDataReader = comando.ExecuteReader()
            While lector.Read()
                combo.Items.Add(lector.GetString(0))
            End While
            con.Close()
            Exit Try
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Public Sub agregarPlatillo(sql As String, nombre As String, precioEstandar As Decimal, precioDescuento As Decimal, precioFeliz As Decimal, descripcion As String, pesoGramos As Decimal, pesoOnzas As Decimal, tipo As String, imagen As PictureBox)
        Try
            con.Open()
            Dim cmd As New SqlCommand(sql, con)
            cmd.Parameters.AddWithValue("@nombre", nombre)
            cmd.Parameters.AddWithValue("@precioEstandar", precioEstandar)
            cmd.Parameters.AddWithValue("@precioDescuento", precioDescuento)
            cmd.Parameters.AddWithValue("@precioFeliz", precioFeliz)
            cmd.Parameters.AddWithValue("@descripcion", descripcion)
            cmd.Parameters.AddWithValue("@pesoGramos", pesoGramos)
            cmd.Parameters.AddWithValue("@pesoOnzas", pesoOnzas)
            cmd.Parameters.AddWithValue("@tipo", tipo)

            Dim Dato() As Byte
            Using ms As New MemoryStream()
                imagen.Image.Save(ms, imagen.Image.RawFormat)
                Dato = ms.ToArray()
            End Using
            With cmd.Parameters.Add("@imagen", SqlDbType.Image)
                .Value = Dato
                .Size = Dato.Length
            End With
            Dim Resultado As Integer = cmd.ExecuteNonQuery()

            con.Close()




        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

End Class
