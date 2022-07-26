﻿Imports System.Data.SqlClient
Imports System.IO

Public Class frLogin
    Private form As frInicio
    Private fr As New frInicio()

    Public Property Form1 As frInicio
        Get
            Return fr
        End Get
        Set(value As frInicio)
            frInicio = value
        End Set
    End Property

    Private Sub btnlog_Click(sender As Object, e As EventArgs) Handles btnlog.Click

        If (Not (String.IsNullOrEmpty(txtContrasena.Text)) And Not (String.IsNullOrEmpty(txtUsername.Text))) Then
            ErrorProvider1.SetError(gbDatos, "")
            Try
                Dim con As New SqlConnection("DATA SOURCE=localhost;INITIAL CATALOG=JuanPieceDB;TRUSTED_CONNECTION=TRUE;INTEGRATED SECURITY=TRUE")
                con.Open()
                Dim bytes As Byte()
                Dim sql As String = "Exec usuario @usern = '" + txtUsername.Text + "', @pass = '" + txtContrasena.Text + "';"
                Dim cmd As New SqlCommand(sql, con)

                cmd.ExecuteNonQuery()
                Dim dr As SqlDataReader = cmd.ExecuteReader()
                If (dr.Read) Then
                    MessageBox.Show("Bienvenido/a de nuevo " + dr.GetString(1), "Login Exitoso")
                    bytes = dr.GetValue(2)

                    Me.Hide()
                    AddOwnedForm(fr)
                    fr.lblNombreUsuario.Text = txtUsername.Text
                    Using ms As New MemoryStream(bytes)
                        fr.pcUsuario.Image = Image.FromStream(ms)
                    End Using
                    fr.lblUsuario.Text = "Bienvenido/a " + dr.GetString(1)
                    fr.Show()
                Else
                    MessageBox.Show("Usuario no existe", "Error de login")
                End If



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
        If (MessageBox.Show("¿Desea continuar?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes) Then
            Me.Close()
        End If

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