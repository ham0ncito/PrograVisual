﻿Public Class Platillos

    Private _nombreProducto As String
    Private _precioProducto As String
    Private _descripcionProducto As String
    Private _precioHoraFeliz As String
    Private _imagen As String

    Public Property NombreProducto As String
        Get
            Return lblNombreProducto.Text
        End Get
        Set(value As String)
            lblNombreProducto.Text = value
        End Set
    End Property

    Public Property PrecioProducto As String
        Get
            Return lblPrecio.Text
        End Get
        Set(value As String)
            lblPrecio.Text = value
        End Set
    End Property

    Public Property DescripcionProducto As String
        Get
            Return lblDescripcion.Text
        End Get
        Set(value As String)
            lblDescripcion.Text = value
        End Set
    End Property

    Public Property Imagen As Image
        Get
            Return pcbImagenPlatillo.Image
        End Get
        Set(value As Image)
            pcbImagenPlatillo.Image = value
        End Set
    End Property

    Public Property PrecioHoraFeliz As String
        Get
            Return lblHoraFeliz.Text
        End Get
        Set(value As String)
            lblHoraFeliz.Text = value
        End Set
    End Property

    Private Sub Platillos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub lblDescripcion_Click(sender As Object, e As EventArgs) Handles lblDescripcion.Click

    End Sub
End Class
