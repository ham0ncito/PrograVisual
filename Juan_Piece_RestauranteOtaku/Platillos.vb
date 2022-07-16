Public Class Platillos

    Private _nombreProducto As String
    Private _precioProducto As String
    Private _descripcionProducto As String
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

    Private Sub Platillos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


End Class
