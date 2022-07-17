Imports System.Data.SqlClient

Public Class ClVentas
    Dim con As New SqlConnection("Data Source=localhost;Initial Catalog=JuanPieceDb; Integrated Security=true;")
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
    Public Sub llenarDataGrid(datagid, text)
        Try

            datagid.Rows.Clear()
            Dim sql As String = "exec busquedaPlatillos '" + text + "';"
            Dim cmd As New SqlCommand(sql, con)
            Try
                Dim da As New SqlDataAdapter(cmd)
                Dim ds As New DataSet
                da.Fill(ds)
                datagid.DataSource = ds.Tables(text)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class
