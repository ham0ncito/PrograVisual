﻿Public Class frEditarPlatillo
    Dim clplatillos As New ClPlatillos()
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCodigos.SelectedIndexChanged
        clplatillos.execData(cmbCodigos.Text, txtNombrePlatillo, txtPrecioN, txtPrecioD, txtPrecioF, txtDescripcion, txtPesoG, txtPesoOnz, cmbTipos, imagenProducto)
    End Sub

    Private Sub frEditarPlatillo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        clplatillos.tipos(cmbTipos)
        clplatillos.idPlatillos(cmbCodigos)
    End Sub

    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        calcularPrecios(0)
    End Sub

    Private Sub lblNombre_Click(sender As Object, e As EventArgs) Handles lblNombre.Click

    End Sub

    Private Sub txtNombrePlatillo_TextChanged(sender As Object, e As EventArgs) Handles txtNombrePlatillo.TextChanged

    End Sub

    Private Sub lblTipo_Click(sender As Object, e As EventArgs) Handles lblTipo.Click

    End Sub

    Private Sub cmbTipos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbTipos.SelectedIndexChanged

    End Sub

    Private Sub btnAg_Click(sender As Object, e As EventArgs) Handles btnAg.Click
        If (verificar() = 4) Then
            Dim clplatillo As New ClPlatillos()
            Dim Sql As String = "
            exec actualizarPlatillo  @id , @nombre, @precioEstandar, 
            @precioDescuento, @precioFeliz, @descripcion, @pesoGramos, @pesoOnzas , @tipo , @imagen
            "
            clplatillo.editarPlatillo(Sql, cmbCodigos.Text, txtNombrePlatillo.Text, Convert.ToDecimal(txtPrecioN.Text), Convert.ToDecimal(txtPrecioD.Text),
               Convert.ToDecimal(txtPrecioF.Text), txtDescripcion.Text, Convert.ToDecimal(txtPesoG.Text), Convert.ToDecimal(txtPesoOnz.Text),
               cmbTipos.Text, imagenProducto)
            MessageBox.Show("Se hizo la modificacion a su platillo")
            limpiarTx()

        Else
            MessageBox.Show("No se pudo hacer la modificacion")
        End If
    End Sub

    Private Sub limpiarTx()
        txtNombrePlatillo.Clear()
        txtDescripcion.Clear()
        txtPesoG.Clear()
        txtPesoOnz.Clear()
        txtPrecioN.Clear()
        txtPrecioD.Text = "Este valor lo genera el sistema"
        txtPrecioF.Text = "Este valor lo genera el sistema"
        imagenProducto.Image = Global.Juan_Piece_RestauranteOtaku.My.Resources.Presione_el_boton_de_escanear__2_
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        limpiarTx()
    End Sub

    Private Function verificar() As Integer
        Try
            Dim contador As Integer = 0
            If txtNombrePlatillo.Text.Length > 5 Then
                contador = contador + 1
                errocrito.SetError(txtNombrePlatillo, "")
            Else
                errocrito.SetError(txtNombrePlatillo, "Datos nos validos")
            End If
            contador = calcularPrecios(contador)
            If IsNumeric(txtPesoG.Text) And IsNumeric(txtPesoOnz.Text) Then
                contador = contador + 1
            Else
                errocrito.SetError(gpPesos, "Datos nos validos")
            End If

            If txtDescripcion.Text.Length > 10 And frNuevoCliente.repite(txtDescripcion.Text) Then
                contador = contador + 1
            Else
                errocrito.SetError(txtDescripcion, "Datos nos validos")
            End If
            Return contador
        Catch x As Exception
            MessageBox.Show(x.Message)
        End Try
    End Function

    Private Function calcularPrecios(contador As Integer) As Integer
        If IsNumeric(txtPrecioN.Text) And Convert.ToDecimal(txtPrecioN.Text) > 0 Then
            contador = contador + 1
            errocrito.SetError(txtNombrePlatillo, "")
            txtPrecioD.Text = Convert.ToDecimal(txtPrecioN.Text) - (Convert.ToDecimal(txtPrecioN.Text) * 0.04)
            txtPrecioF.Text = Convert.ToDecimal(txtPrecioN.Text) - (Convert.ToDecimal(txtPrecioN.Text) * 0.2)
        Else
            errocrito.SetError(txtPrecioN, "Datos nos validos")
        End If
        Return contador
    End Function

    Private Sub imagenProducto_Click(sender As Object, e As EventArgs) Handles imagenProducto.Click
        opfCargar.InitialDirectory = "c:\Users"
        opfCargar.Filter = "JPG|*.jpg|PNG|*.png"
        opfCargar.FileName = "Nuevo Platillo"
        opfCargar.Title = "Cargar Imagen"


        If opfCargar.ShowDialog() = Windows.Forms.DialogResult.OK Then
            imagenProducto.Image = Image.FromFile(opfCargar.FileName)
        End If
    End Sub

    Private Sub btnConvertir_Click(sender As Object, e As EventArgs) Handles btnConvertir.Click
        If (String.IsNullOrEmpty(txtPesoG.Text)) And Not (String.IsNullOrEmpty(txtPesoOnz.Text)) And IsNumeric(txtPesoOnz.Text) Then
            txtPesoG.Text = Convert.ToDecimal(txtPesoOnz.Text) / 0.035274
        ElseIf (String.IsNullOrEmpty(txtPesoOnz.Text)) And Not (String.IsNullOrEmpty(txtPesoG.Text)) And IsNumeric(txtPesoG.Text) Then
            txtPesoOnz.Text = Convert.ToDecimal(txtPesoG.Text) * 0.035274
        ElseIf Not (String.IsNullOrEmpty(txtPesoG.Text)) And Not (String.IsNullOrEmpty(txtPesoOnz.Text)) And IsNumeric(txtPesoG.Text) And IsNumeric(txtPesoOnz.Text) Then
            MessageBox.Show("No se puede convertir si ambos textbox se encuentran con valores", "Error")
        Else
            MessageBox.Show("Valores no validos", "Error")
        End If
    End Sub
End Class