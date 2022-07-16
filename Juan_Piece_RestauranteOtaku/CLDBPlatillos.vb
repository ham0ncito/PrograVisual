Imports System.Data.SqlClient
Imports Microsoft.SqlServer.Server
Imports Libreria_Clases
Imports System.Data
Imports System.IO

Public Class CLDBPlatillos
    Dim platilloInt As Int16
    Dim nombrePlatillo As String
    Dim precioProductoE As Double
    Dim precioProductoH As Double
    Dim descripcionProducto As String
    Dim imagen As Byte

    Public Property PlatilloInt1 As Short
        Get
            Return platilloInt
        End Get
        Set(value As Short)
            platilloInt = value
        End Set
    End Property

    Public Property NombrePlatillo1 As String
        Get
            Return nombrePlatillo
        End Get
        Set(value As String)
            nombrePlatillo = value
        End Set
    End Property

    Public Property PrecioProductoE1 As Double
        Get
            Return precioProductoE
        End Get
        Set(value As Double)
            precioProductoE = value
        End Set
    End Property

    Public Property PrecioProductoH1 As Double
        Get
            Return precioProductoH
        End Get
        Set(value As Double)
            precioProductoH = value
        End Set
    End Property

    Public Property DescripcionProducto1 As String
        Get
            Return descripcionProducto
        End Get
        Set(value As String)
            descripcionProducto = value
        End Set
    End Property

    Public Property Imagen1 As Byte
        Get
            Return imagen
        End Get
        Set(value As Byte)
            imagen = value
        End Set
    End Property

    Dim con As New SqlConnection("Data Source=localhost;Initial Catalog=JuanPieceDb; Integrated Security=true;")

    Public Function LlenarFlowLayout(FlowLayoutPanel)
        Try
            con.Open()
            Dim sql As String = "Select * from Platillos"
            Dim comando As New SqlCommand(sql, con)
            comando.CommandType = CommandType.Text
            Dim lector As SqlDataReader = comando.ExecuteReader()
            While (lector.Read)
                NombrePlatillo1 = lector.GetString(1)
                PlatilloInt1 = lector.GetInt32(0)
                PrecioProductoE1 = lector.GetDecimal(2)
                PrecioProductoH1 = lector.GetDecimal(4)
                DescripcionProducto1 = lector.GetString(5)
                'Imagen1 = lector.GetByte(10)

                Dim nuevoPlatillo As New Platillos
                nuevoPlatillo.NombreProducto = NombrePlatillo1
                nuevoPlatillo.PrecioProducto = PrecioProductoE1
                nuevoPlatillo.PrecioHoraFeliz = PrecioProductoH1
                nuevoPlatillo.DescripcionProducto = DescripcionProducto1
                ''Dim ms As New MemoryStream(Imagen1)
                ''nuevoPlatillo.Imagen = Image.FromStream(ms)

                FlowLayoutPanel.Controls.Add(nuevoPlatillo)


            End While

            con.Close()
            con.Dispose()
            Exit Try
        Catch ex As SqlException
            MessageBox.Show(ex.Message)

        End Try
    End Function

End Class
