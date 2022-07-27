Imports System.Data.SqlClient
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

            Exit Try
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        con.Close()
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
            cmd.ExecuteNonQuery()

            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Public Sub editarPlatillo(sql As String, id As String, nombre As String, precioEstandar As Decimal, precioDescuento As Decimal, precioFeliz As Decimal, descripcion As String, pesoGramos As Decimal, pesoOnzas As Decimal, tipo As String, imagen As PictureBox)
        Try
            con.Open()
            Dim cmd As New SqlCommand(sql, con)
            cmd.Parameters.AddWithValue("@id", id)
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
            cmd.ExecuteNonQuery()

            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Public Sub idPlatillos(combo As ComboBox)
        Try
            combo.Items.Clear()
            con.Open()
            Dim sql As String = "exec idPlatillosActivos"
            Dim comando As New SqlCommand(sql, con)
            comando.CommandType = CommandType.Text
            Dim lector As SqlDataReader = comando.ExecuteReader()
            While lector.Read()
                combo.Items.Add(Convert.ToString(lector.GetValue(0)))
            End While
            con.Close()
            Exit Try
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub


    Public Sub execData(id As Integer, nombre As TextBox, precioN As TextBox, precioD As TextBox, precioF As TextBox,
                        descripcion As TextBox, pesoG As TextBox, pesoOnz As TextBox, tipo As ComboBox, imagen As PictureBox)
        Try
            con.Open()
            Dim img As Byte()
            Dim sql As String = "exec dataPlatillo " + Convert.ToString(id)
            Dim cmd As New SqlCommand(sql, con)
            cmd.CommandType = CommandType.Text
            Dim lector As SqlDataReader = cmd.ExecuteReader()
            If lector.Read() Then
                nombre.Text = Convert.ToString(lector.GetValue(0))
                precioN.Text = Convert.ToString(lector.GetValue(1))
                precioD.Text = Convert.ToString(lector.GetValue(2))
                precioF.Text = Convert.ToString(lector.GetValue(3))
                descripcion.Text = Convert.ToString(lector.GetValue(4))
                pesoG.Text = Convert.ToString(lector.GetValue(5))
                pesoOnz.Text = Convert.ToString(lector.GetValue(6))
                tipo.SelectedItem = Convert.ToString(lector.GetValue(7))
                img = lector.GetValue(8)
                Using ms As New MemoryStream(img)
                    imagen.Image = Image.FromStream(ms)
                End Using
            End If
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Public Sub eliminar(id As Integer)
        Try

            con.Open()
            Dim sql As String = "exec dataEliminar " + Convert.ToString(id)
            Dim cmd As New SqlCommand(sql, con)
            cmd.ExecuteReader()
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Public Sub DataEliminacion(id As Int64, nombre As Label, descripcion As Label, imagen As PictureBox)
        Try
            con.Open()
            Dim img As Byte()
            Dim sql As String = "exec InfoEliminar " + Convert.ToString(id)
            Dim cmd As New SqlCommand(sql, con)
            cmd.CommandType = CommandType.Text
            Dim lector As SqlDataReader = cmd.ExecuteReader()
            If lector.Read() Then
                nombre.Text = Convert.ToString(lector.GetValue(0))
                descripcion.Text = Convert.ToString(lector.GetValue(1))
                img = lector.GetValue(2)
                Using ms As New MemoryStream(img)
                    imagen.Image = Image.FromStream(ms)
                End Using
            End If
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

End Class
