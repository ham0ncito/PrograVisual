Imports System.Data.SqlClient
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
End Class
