Imports System.Data.SqlClient
Imports Libreria_Clases

Public Class ClVentas
    Inherits Conexion

    Public Sub llenarPanel(Panel)
        con.Open()
        Dim sql As String = "exec nombreTipo"
        Dim comando As New SqlCommand(sql, con)
        comando.CommandType = CommandType.Text
        Dim lector As SqlDataReader = comando.ExecuteReader()
        While (lector.Read)
            Dim btn As New Button
            btn.CreateControl()
            btn.Name = "btn" + lector(0).ToString
            btn.Dock = DockStyle.Top
            btn.Text = lector(0).ToString

        End While
        con.Close()


    End Sub
    Public Sub llenarDataGrid(datagid As DataGridView, text As String)
        datagid.Columns.Clear()
        datagid.AlternatingRowsDefaultCellStyle.BackColor = Color.Goldenrod
        datagid.DefaultCellStyle.ForeColor = Color.Black
        Try
            Dim sql As String = "exec busquedaPlatillos '" + text + "';"
            Dim cmd As New SqlCommand(sql, con)
            cmd.CommandType = CommandType.Text
            Dim da = New SqlDataAdapter(cmd)
            Dim ds = New DataSet()
            da.Fill(ds, "Platillos")
            If (ds.Tables("Platillos").Rows.Count > 0) Then

                datagid.DataSource = ds.Tables("Platillos")
            Else
                MessageBox.Show("No hay productos de esa categoria", "Inventario", MessageBoxButtons.OK, MessageBoxIcon.Hand)
            End If

            con.Close()
            Exit Try

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Public Sub busquedaLabel(contenedor, consulta)
        Try
            con.Open()
            Dim sql As String = consulta
            Dim comando As New SqlCommand(sql, con)
            comando.CommandType = CommandType.Text
            Dim lector As SqlDataReader = comando.ExecuteReader()
            If (lector.Read() And Not (lector.IsDBNull(0))) Then
                contenedor.Text = lector.GetValue(0)
            End If
            con.Close()
            Exit Try
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Public Sub Clientes(cbbox, consulta)
        Try
            cbbox.Items.Clear()
            con.Open()
            Dim sql As String = consulta
            Dim comando As New SqlCommand(sql, con)
            comando.CommandType = CommandType.Text
            Dim lector As SqlDataReader = comando.ExecuteReader()
            While lector.Read()
                cbbox.Items.Add(lector.GetString(0))
            End While
            con.Close()
            Exit Try
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

End Class
