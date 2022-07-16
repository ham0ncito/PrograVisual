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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblDescripcion = New System.Windows.Forms.Label()
        Me.lblPrecio = New System.Windows.Forms.Label()
        Me.lblNombreProducto = New System.Windows.Forms.Label()
        Me.pcbImagenPlatillo = New System.Windows.Forms.PictureBox()
        Me.lblHoraFeliz = New System.Windows.Forms.Label()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcbImagenPlatillo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Silver
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.lblHoraFeliz)
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Controls.Add(Me.lblDescripcion)
        Me.Panel2.Controls.Add(Me.lblPrecio)
        Me.Panel2.Controls.Add(Me.lblNombreProducto)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(172, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(292, 265)
        Me.Panel2.TabIndex = 2
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Juan_Piece_RestauranteOtaku.My.Resources.Resources.toppng_com_five_star_rating_623x124
        Me.PictureBox1.Location = New System.Drawing.Point(16, 105)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'lblDescripcion
        '
        Me.lblDescripcion.AutoSize = True
        Me.lblDescripcion.Font = New System.Drawing.Font("Garamond", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point)
        Me.lblDescripcion.Location = New System.Drawing.Point(16, 158)
        Me.lblDescripcion.Name = "lblDescripcion"
        Me.lblDescripcion.Size = New System.Drawing.Size(83, 21)
        Me.lblDescripcion.TabIndex = 2
        Me.lblDescripcion.Text = "Descripcion"
        '
        'lblPrecio
        '
        Me.lblPrecio.AutoSize = True
        Me.lblPrecio.Font = New System.Drawing.Font("Garamond", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblPrecio.ForeColor = System.Drawing.Color.Brown
        Me.lblPrecio.Location = New System.Drawing.Point(16, 54)
        Me.lblPrecio.Name = "lblPrecio"
        Me.lblPrecio.Size = New System.Drawing.Size(154, 24)
        Me.lblPrecio.TabIndex = 1
        Me.lblPrecio.Text = "Precio producto"
        '
        'lblNombreProducto
        '
        Me.lblNombreProducto.AutoSize = True
        Me.lblNombreProducto.Font = New System.Drawing.Font("Garamond", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblNombreProducto.ForeColor = System.Drawing.Color.OrangeRed
        Me.lblNombreProducto.Location = New System.Drawing.Point(16, 30)
        Me.lblNombreProducto.Name = "lblNombreProducto"
        Me.lblNombreProducto.Size = New System.Drawing.Size(204, 24)
        Me.lblNombreProducto.TabIndex = 0
        Me.lblNombreProducto.Text = "Nombre del producto"
        '
        'pcbImagenPlatillo
        '
        Me.pcbImagenPlatillo.BackColor = System.Drawing.SystemColors.ControlDark
        Me.pcbImagenPlatillo.Dock = System.Windows.Forms.DockStyle.Left
        Me.pcbImagenPlatillo.Image = Global.Juan_Piece_RestauranteOtaku.My.Resources.Resources.ramen_de_pollo_receta_facil_f_1_PhotoRoom__1_
        Me.pcbImagenPlatillo.Location = New System.Drawing.Point(0, 0)
        Me.pcbImagenPlatillo.Name = "pcbImagenPlatillo"
        Me.pcbImagenPlatillo.Size = New System.Drawing.Size(172, 265)
        Me.pcbImagenPlatillo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pcbImagenPlatillo.TabIndex = 0
        Me.pcbImagenPlatillo.TabStop = False
        '
        'lblHoraFeliz
        '
        Me.lblHoraFeliz.AutoSize = True
        Me.lblHoraFeliz.Font = New System.Drawing.Font("Garamond", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblHoraFeliz.ForeColor = System.Drawing.Color.Brown
        Me.lblHoraFeliz.Location = New System.Drawing.Point(16, 78)
        Me.lblHoraFeliz.Name = "lblHoraFeliz"
        Me.lblHoraFeliz.Size = New System.Drawing.Size(167, 24)
        Me.lblHoraFeliz.TabIndex = 4
        Me.lblHoraFeliz.Text = "Precio Hora Feliz"
        '
        'Platillos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.pcbImagenPlatillo)
        Me.Font = New System.Drawing.Font("Garamond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ForeColor = System.Drawing.Color.Black
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Platillos"
        Me.Size = New System.Drawing.Size(462, 265)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcbImagenPlatillo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lblNombreProducto As Label
    Friend WithEvents lblPrecio As Label
    Friend WithEvents pcbImagenPlatillo As PictureBox
    Friend WithEvents lblDescripcion As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblHoraFeliz As Label
End Class
