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

    End Sub
    Public Sub llenarDataGrid(datagid As DataGridView, text As String)
        datagid.Rows.Clear()
        datagid.Rows.Clear()
        datagid.DefaultCellStyle.ForeColor = Color.Black
        Try


            Dim sql As String = "exec busquedaPlatillos '" + text + "';"
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
End Class
