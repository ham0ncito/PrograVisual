<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Platillos
    Inherits System.Windows.Forms.UserControl

    'UserControl reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.pcbImagenPlatillo = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.lblNombreProducto = New System.Windows.Forms.Label()
        Me.lblPrecio = New System.Windows.Forms.Label()
        CType(Me.pcbImagenPlatillo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'pcbImagenPlatillo
        '
        Me.pcbImagenPlatillo.Image = Global.Juan_Piece_RestauranteOtaku.My.Resources.Resources.ramen_de_pollo_receta_facil_f_1_PhotoRoom__1_
        Me.pcbImagenPlatillo.Location = New System.Drawing.Point(48, 68)
        Me.pcbImagenPlatillo.Name = "pcbImagenPlatillo"
        Me.pcbImagenPlatillo.Size = New System.Drawing.Size(181, 168)
        Me.pcbImagenPlatillo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pcbImagenPlatillo.TabIndex = 0
        Me.pcbImagenPlatillo.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 231)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(294, 100)
        Me.Panel2.TabIndex = 2
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.Control
        Me.Panel3.Controls.Add(Me.lblPrecio)
        Me.Panel3.Controls.Add(Me.lblNombreProducto)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(294, 65)
        Me.Panel3.TabIndex = 3
        '
        'lblNombreProducto
        '
        Me.lblNombreProducto.AutoSize = True
        Me.lblNombreProducto.Font = New System.Drawing.Font("Garamond", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblNombreProducto.Location = New System.Drawing.Point(15, 17)
        Me.lblNombreProducto.Name = "lblNombreProducto"
        Me.lblNombreProducto.Size = New System.Drawing.Size(204, 24)
        Me.lblNombreProducto.TabIndex = 0
        Me.lblNombreProducto.Text = "Nombre del producto"
        '
        'lblPrecio
        '
        Me.lblPrecio.AutoSize = True
        Me.lblPrecio.Font = New System.Drawing.Font("Garamond", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblPrecio.Location = New System.Drawing.Point(15, 41)
        Me.lblPrecio.Name = "lblPrecio"
        Me.lblPrecio.Size = New System.Drawing.Size(154, 24)
        Me.lblPrecio.TabIndex = 1
        Me.lblPrecio.Text = "Precio producto"
        '
        'Platillos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.pcbImagenPlatillo)
        Me.Font = New System.Drawing.Font("Garamond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ForeColor = System.Drawing.Color.Black
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Platillos"
        Me.Size = New System.Drawing.Size(294, 331)
        CType(Me.pcbImagenPlatillo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pcbImagenPlatillo As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents lblNombreProducto As Label
    Friend WithEvents lblPrecio As Label
End Class
