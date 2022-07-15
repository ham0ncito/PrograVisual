Imports System.Data.SqlClient
Public Class frLogin
    Private Sub btnlog_Click(sender As Object, e As EventArgs) Handles btnlog.Click
        If (Not (String.IsNullOrEmpty(txtContrasena.Text)) And Not (String.IsNullOrEmpty(txtUsername.Text))) Then
            ErrorProvider1.SetError(gbDatos, "")
            Try
                Dim con As New SqlConnection("Data Source =localhost; Initial Catalog=JuanPieceDB")
                con.Open()
                Dim sql As String = "Exec usuario @usern =" + txtUsername.Text + " @pass =" + txtContrasena.Text
                Dim cmd As New SqlCommand(sql, con)
                Dim da As New SqlDataAdapter
                Dim dt As New DataTable
                da.SelectCommand = cmd
                da.Fill(dt)

            Catch x As SqlException
                MsgBox(x.Message)
            End Try
        Else
                ErrorProvider1.SetError(gbDatos, "Ingrese todos los datos")
        End If

    End Sub

    Private Sub btnRecuperar_Click(sender As Object, e As EventArgs) Handles btnRecuperar.Click
        MessageBox.Show("Para recuperar su contraseña, contactese con su proveedor de servicios", "Recuperar contraseña", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub btnLogOut_Click(sender As Object, e As EventArgs) Handles btnLogOut.Click
        Me.Close()
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles cbmostrar.CheckedChanged
        If (cbmostrar.Checked) Then
            txtContrasena.UseSystemPasswordChar = False
        Else
            txtContrasena.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub frLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtContrasena.UseSystemPasswordChar = True
    End Sub

    Private Sub gbDatos_Enter(sender As Object, e As EventArgs) Handles gbDatos.Enter

    End Sub
End Class