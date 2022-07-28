<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Platillos
    Inherits System.Windows.Forms.UserControl

    'UserControl reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblHoraFeliz = New System.Windows.Forms.Label()
        Me.pcbImagenPlatillo = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblDescripcion = New System.Windows.Forms.Label()
        Me.lblPrecio = New System.Windows.Forms.Label()
        Me.lblNombreProducto = New System.Windows.Forms.Label()
        Me.Panel2.SuspendLayout()
        CType(Me.pcbImagenPlatillo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.lblHoraFeliz)
        Me.Panel2.Controls.Add(Me.pcbImagenPlatillo)
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Controls.Add(Me.lblDescripcion)
        Me.Panel2.Controls.Add(Me.lblPrecio)
        Me.Panel2.Controls.Add(Me.lblNombreProducto)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(229, 354)
        Me.Panel2.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Garamond", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(13, 185)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 21)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Precio Feliz"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Garamond", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(13, 164)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(119, 21)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Precio Normal"
        '
        'lblHoraFeliz
        '
        Me.lblHoraFeliz.AutoSize = True
        Me.lblHoraFeliz.Font = New System.Drawing.Font("Garamond", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblHoraFeliz.ForeColor = System.Drawing.Color.Brown
        Me.lblHoraFeliz.Location = New System.Drawing.Point(150, 188)
        Me.lblHoraFeliz.Name = "lblHoraFeliz"
        Me.lblHoraFeliz.Size = New System.Drawing.Size(44, 18)
        Me.lblHoraFeliz.TabIndex = 4
        Me.lblHoraFeliz.Text = "00.00"
        Me.lblHoraFeliz.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pcbImagenPlatillo
        '
        Me.pcbImagenPlatillo.BackColor = System.Drawing.Color.White
        ''Me.pcbImagenPlatillo.Image = Global.Juan_Piece_RestauranteOtaku.My.Resources.Resources._149px_Picture_icon_BLACK_svg
        Me.pcbImagenPlatillo.Location = New System.Drawing.Point(27, 60)
        Me.pcbImagenPlatillo.Name = "pcbImagenPlatillo"
        Me.pcbImagenPlatillo.Size = New System.Drawing.Size(167, 95)
        Me.pcbImagenPlatillo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pcbImagenPlatillo.TabIndex = 0
        Me.pcbImagenPlatillo.TabStop = False
        '
        'PictureBox1
        '
        ' Me.PictureBox1.Image = Global.Juan_Piece_RestauranteOtaku.My.Resources.Resources.toppng_com_five_star_rating_623x124
        Me.PictureBox1.Location = New System.Drawing.Point(13, 209)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 37)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'lblDescripcion
        '
        Me.lblDescripcion.AutoEllipsis = True
        Me.lblDescripcion.Font = New System.Drawing.Font("Garamond", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point)
        Me.lblDescripcion.Location = New System.Drawing.Point(0, 249)
        Me.lblDescripcion.Name = "lblDescripcion"
        Me.lblDescripcion.Size = New System.Drawing.Size(224, 105)
        Me.lblDescripcion.TabIndex = 2
        Me.lblDescripcion.Text = "Descripcion"
        Me.lblDescripcion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPrecio
        '
        Me.lblPrecio.AutoSize = True
        Me.lblPrecio.Font = New System.Drawing.Font("Garamond", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblPrecio.ForeColor = System.Drawing.Color.Brown
        Me.lblPrecio.Location = New System.Drawing.Point(150, 164)
        Me.lblPrecio.Name = "lblPrecio"
        Me.lblPrecio.Size = New System.Drawing.Size(44, 18)
        Me.lblPrecio.TabIndex = 1
        Me.lblPrecio.Text = "00.00"
        Me.lblPrecio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblNombreProducto
        '
        Me.lblNombreProducto.Font = New System.Drawing.Font("Garamond", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblNombreProducto.ForeColor = System.Drawing.Color.Crimson
        Me.lblNombreProducto.Location = New System.Drawing.Point(3, 0)
        Me.lblNombreProducto.Name = "lblNombreProducto"
        Me.lblNombreProducto.Size = New System.Drawing.Size(224, 57)
        Me.lblNombreProducto.TabIndex = 0
        Me.lblNombreProducto.Text = "Nombre del producto"
        Me.lblNombreProducto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Platillos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Controls.Add(Me.Panel2)
        Me.Font = New System.Drawing.Font("Garamond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ForeColor = System.Drawing.Color.Black
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Platillos"
        Me.Size = New System.Drawing.Size(229, 354)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.pcbImagenPlatillo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lblNombreProducto As Label
    Friend WithEvents lblPrecio As Label
    Friend WithEvents pcbImagenPlatillo As PictureBox
    Friend WithEvents lblDescripcion As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblHoraFeliz As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
