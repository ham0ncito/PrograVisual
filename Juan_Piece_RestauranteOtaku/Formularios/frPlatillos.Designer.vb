﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frPlatillos
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frPlatillos))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnFactura = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnCancelarVenta = New System.Windows.Forms.Button()
        Me.btnGenerar = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblHora = New System.Windows.Forms.Label()
        Me.dgPlatillos = New System.Windows.Forms.DataGridView()
        Me.gpInformacionPlatillo = New System.Windows.Forms.GroupBox()
        Me.lblinfo5 = New System.Windows.Forms.Label()
        Me.lblinfo4 = New System.Windows.Forms.Label()
        Me.lblinfo3 = New System.Windows.Forms.Label()
        Me.lblinfo2 = New System.Windows.Forms.Label()
        Me.lblinfo1 = New System.Windows.Forms.Label()
        Me.lblTipo = New System.Windows.Forms.Label()
        Me.lblPesoOnz = New System.Windows.Forms.Label()
        Me.lblPrecioH = New System.Windows.Forms.Label()
        Me.lblPrecioD = New System.Windows.Forms.Label()
        Me.lblPrecioN = New System.Windows.Forms.Label()
        Me.dgIngredientes = New System.Windows.Forms.DataGridView()
        Me.lblDescripcion = New System.Windows.Forms.Label()
        Me.lblPesoGra = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.pcImagen = New System.Windows.Forms.PictureBox()
        Me.Tiempo = New System.Windows.Forms.Timer(Me.components)
        Me.Imprimir = New System.Drawing.Printing.PrintDocument()
        Me.ImprimirPreview = New System.Windows.Forms.PrintPreviewDialog()
        Me.pictureNoIngredientes = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.dgPlatillos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpInformacionPlatillo.SuspendLayout()
        CType(Me.dgIngredientes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcImagen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureNoIngredientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Panel1.Controls.Add(Me.btnSalir)
        Me.Panel1.Controls.Add(Me.btnFactura)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.btnCancelarVenta)
        Me.Panel1.Controls.Add(Me.btnGenerar)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1350, 90)
        Me.Panel1.TabIndex = 0
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnSalir.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnSalir.Font = New System.Drawing.Font("Garamond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnSalir.Location = New System.Drawing.Point(1029, 0)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(143, 90)
        Me.btnSalir.TabIndex = 5
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'btnFactura
        '
        Me.btnFactura.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnFactura.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnFactura.Font = New System.Drawing.Font("Garamond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnFactura.Location = New System.Drawing.Point(886, 0)
        Me.btnFactura.Name = "btnFactura"
        Me.btnFactura.Size = New System.Drawing.Size(143, 90)
        Me.btnFactura.TabIndex = 4
        Me.btnFactura.Text = "Editar Platillo"
        Me.btnFactura.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Left
        ''Me.PictureBox1.Image = Global.Juan_Piece_RestauranteOtaku.My.Resources.Resources.One_Pice__1__PhotoRoom__1_
        Me.PictureBox1.Location = New System.Drawing.Point(682, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(204, 90)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'btnCancelarVenta
        '
        Me.btnCancelarVenta.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnCancelarVenta.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnCancelarVenta.Font = New System.Drawing.Font("Garamond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnCancelarVenta.Location = New System.Drawing.Point(539, 0)
        Me.btnCancelarVenta.Name = "btnCancelarVenta"
        Me.btnCancelarVenta.Size = New System.Drawing.Size(143, 90)
        Me.btnCancelarVenta.TabIndex = 2
        Me.btnCancelarVenta.Text = "Eliminar Platillo"
        Me.btnCancelarVenta.UseVisualStyleBackColor = False
        '
        'btnGenerar
        '
        Me.btnGenerar.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnGenerar.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnGenerar.Font = New System.Drawing.Font("Garamond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnGenerar.Location = New System.Drawing.Point(396, 0)
        Me.btnGenerar.Name = "btnGenerar"
        Me.btnGenerar.Size = New System.Drawing.Size(143, 90)
        Me.btnGenerar.TabIndex = 1
        Me.btnGenerar.Text = "Nuevo Platillo"
        Me.btnGenerar.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.lblHora)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(396, 90)
        Me.Panel2.TabIndex = 0
        '
        'lblHora
        '
        Me.lblHora.AutoSize = True
        Me.lblHora.Font = New System.Drawing.Font("Garamond", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblHora.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lblHora.Location = New System.Drawing.Point(21, 34)
        Me.lblHora.Name = "lblHora"
        Me.lblHora.Size = New System.Drawing.Size(44, 21)
        Me.lblHora.TabIndex = 0
        Me.lblHora.Text = "hora"
        '
        'dgPlatillos
        '
        Me.dgPlatillos.AllowDrop = True
        Me.dgPlatillos.AllowUserToAddRows = False
        Me.dgPlatillos.AllowUserToDeleteRows = False
        Me.dgPlatillos.AllowUserToResizeColumns = False
        Me.dgPlatillos.AllowUserToResizeRows = False
        Me.dgPlatillos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgPlatillos.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.dgPlatillos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgPlatillos.GridColor = System.Drawing.Color.Black
        Me.dgPlatillos.Location = New System.Drawing.Point(21, 111)
        Me.dgPlatillos.Name = "dgPlatillos"
        Me.dgPlatillos.ReadOnly = True
        Me.dgPlatillos.RowTemplate.Height = 25
        Me.dgPlatillos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgPlatillos.Size = New System.Drawing.Size(767, 575)
        Me.dgPlatillos.TabIndex = 2
        '
        'gpInformacionPlatillo
        '
        Me.gpInformacionPlatillo.Controls.Add(Me.pictureNoIngredientes)
        Me.gpInformacionPlatillo.Controls.Add(Me.lblinfo5)
        Me.gpInformacionPlatillo.Controls.Add(Me.lblinfo4)
        Me.gpInformacionPlatillo.Controls.Add(Me.lblinfo3)
        Me.gpInformacionPlatillo.Controls.Add(Me.lblinfo2)
        Me.gpInformacionPlatillo.Controls.Add(Me.lblinfo1)
        Me.gpInformacionPlatillo.Controls.Add(Me.lblTipo)
        Me.gpInformacionPlatillo.Controls.Add(Me.lblPesoOnz)
        Me.gpInformacionPlatillo.Controls.Add(Me.lblPrecioH)
        Me.gpInformacionPlatillo.Controls.Add(Me.lblPrecioD)
        Me.gpInformacionPlatillo.Controls.Add(Me.lblPrecioN)
        Me.gpInformacionPlatillo.Controls.Add(Me.dgIngredientes)
        Me.gpInformacionPlatillo.Controls.Add(Me.lblDescripcion)
        Me.gpInformacionPlatillo.Controls.Add(Me.lblPesoGra)
        Me.gpInformacionPlatillo.Controls.Add(Me.lblNombre)
        Me.gpInformacionPlatillo.Controls.Add(Me.pcImagen)
        Me.gpInformacionPlatillo.Location = New System.Drawing.Point(804, 111)
        Me.gpInformacionPlatillo.Name = "gpInformacionPlatillo"
        Me.gpInformacionPlatillo.Size = New System.Drawing.Size(534, 575)
        Me.gpInformacionPlatillo.TabIndex = 5
        Me.gpInformacionPlatillo.TabStop = False
        Me.gpInformacionPlatillo.Text = "Informacion Platillo"
        '
        'lblinfo5
        '
        Me.lblinfo5.AutoSize = True
        Me.lblinfo5.Font = New System.Drawing.Font("Garamond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblinfo5.Location = New System.Drawing.Point(368, 246)
        Me.lblinfo5.Name = "lblinfo5"
        Me.lblinfo5.Size = New System.Drawing.Size(83, 18)
        Me.lblinfo5.TabIndex = 16
        Me.lblinfo5.Text = "Precio Feliz"
        '
        'lblinfo4
        '
        Me.lblinfo4.AutoSize = True
        Me.lblinfo4.Font = New System.Drawing.Font("Garamond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblinfo4.Location = New System.Drawing.Point(183, 246)
        Me.lblinfo4.Name = "lblinfo4"
        Me.lblinfo4.Size = New System.Drawing.Size(120, 18)
        Me.lblinfo4.TabIndex = 15
        Me.lblinfo4.Text = "Precio Descuento"
        '
        'lblinfo3
        '
        Me.lblinfo3.AutoSize = True
        Me.lblinfo3.Font = New System.Drawing.Font("Garamond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblinfo3.Location = New System.Drawing.Point(27, 246)
        Me.lblinfo3.Name = "lblinfo3"
        Me.lblinfo3.Size = New System.Drawing.Size(100, 18)
        Me.lblinfo3.TabIndex = 14
        Me.lblinfo3.Text = "Precio Normal"
        '
        'lblinfo2
        '
        Me.lblinfo2.AutoSize = True
        Me.lblinfo2.Font = New System.Drawing.Font("Garamond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblinfo2.Location = New System.Drawing.Point(270, 152)
        Me.lblinfo2.Name = "lblinfo2"
        Me.lblinfo2.Size = New System.Drawing.Size(83, 18)
        Me.lblinfo2.TabIndex = 13
        Me.lblinfo2.Text = "Peso Onzas"
        '
        'lblinfo1
        '
        Me.lblinfo1.AutoSize = True
        Me.lblinfo1.Font = New System.Drawing.Font("Garamond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblinfo1.Location = New System.Drawing.Point(270, 134)
        Me.lblinfo1.Name = "lblinfo1"
        Me.lblinfo1.Size = New System.Drawing.Size(92, 18)
        Me.lblinfo1.TabIndex = 12
        Me.lblinfo1.Text = "Peso Gramos"
        '
        'lblTipo
        '
        Me.lblTipo.AutoSize = True
        Me.lblTipo.Font = New System.Drawing.Font("Garamond", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblTipo.ForeColor = System.Drawing.Color.Maroon
        Me.lblTipo.Location = New System.Drawing.Point(270, 104)
        Me.lblTipo.Name = "lblTipo"
        Me.lblTipo.Size = New System.Drawing.Size(113, 24)
        Me.lblTipo.TabIndex = 11
        Me.lblTipo.Text = "Tipo Platillo"
        '
        'lblPesoOnz
        '
        Me.lblPesoOnz.AutoSize = True
        Me.lblPesoOnz.Font = New System.Drawing.Font("Garamond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblPesoOnz.ForeColor = System.Drawing.Color.OrangeRed
        Me.lblPesoOnz.Location = New System.Drawing.Point(389, 152)
        Me.lblPesoOnz.Name = "lblPesoOnz"
        Me.lblPesoOnz.Size = New System.Drawing.Size(44, 18)
        Me.lblPesoOnz.TabIndex = 10
        Me.lblPesoOnz.Text = "00.00"
        '
        'lblPrecioH
        '
        Me.lblPrecioH.AutoSize = True
        Me.lblPrecioH.Font = New System.Drawing.Font("Garamond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblPrecioH.ForeColor = System.Drawing.Color.OrangeRed
        Me.lblPrecioH.Location = New System.Drawing.Point(457, 246)
        Me.lblPrecioH.Name = "lblPrecioH"
        Me.lblPrecioH.Size = New System.Drawing.Size(44, 18)
        Me.lblPrecioH.TabIndex = 9
        Me.lblPrecioH.Text = "00.00"
        '
        'lblPrecioD
        '
        Me.lblPrecioD.AutoSize = True
        Me.lblPrecioD.Font = New System.Drawing.Font("Garamond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblPrecioD.ForeColor = System.Drawing.Color.OrangeRed
        Me.lblPrecioD.Location = New System.Drawing.Point(309, 246)
        Me.lblPrecioD.Name = "lblPrecioD"
        Me.lblPrecioD.Size = New System.Drawing.Size(44, 18)
        Me.lblPrecioD.TabIndex = 8
        Me.lblPrecioD.Text = "00.00"
        '
        'lblPrecioN
        '
        Me.lblPrecioN.AutoSize = True
        Me.lblPrecioN.Font = New System.Drawing.Font("Garamond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblPrecioN.ForeColor = System.Drawing.Color.OrangeRed
        Me.lblPrecioN.Location = New System.Drawing.Point(133, 246)
        Me.lblPrecioN.Name = "lblPrecioN"
        Me.lblPrecioN.Size = New System.Drawing.Size(44, 18)
        Me.lblPrecioN.TabIndex = 7
        Me.lblPrecioN.Text = "00.00"
        '
        'dgIngredientes
        '
        Me.dgIngredientes.AllowUserToAddRows = False
        Me.dgIngredientes.AllowUserToDeleteRows = False
        Me.dgIngredientes.AllowUserToResizeColumns = False
        Me.dgIngredientes.AllowUserToResizeRows = False
        Me.dgIngredientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgIngredientes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders
        Me.dgIngredientes.BackgroundColor = System.Drawing.Color.White
        Me.dgIngredientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgIngredientes.Location = New System.Drawing.Point(27, 287)
        Me.dgIngredientes.Name = "dgIngredientes"
        Me.dgIngredientes.ReadOnly = True
        Me.dgIngredientes.RowTemplate.Height = 25
        Me.dgIngredientes.Size = New System.Drawing.Size(479, 229)
        Me.dgIngredientes.TabIndex = 6
        '
        'lblDescripcion
        '
        Me.lblDescripcion.Font = New System.Drawing.Font("Garamond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblDescripcion.Location = New System.Drawing.Point(270, 170)
        Me.lblDescripcion.Name = "lblDescripcion"
        Me.lblDescripcion.Size = New System.Drawing.Size(236, 63)
        Me.lblDescripcion.TabIndex = 5
        Me.lblDescripcion.Text = "Descripcion"
        Me.lblDescripcion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPesoGra
        '
        Me.lblPesoGra.AutoSize = True
        Me.lblPesoGra.Font = New System.Drawing.Font("Garamond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblPesoGra.ForeColor = System.Drawing.Color.OrangeRed
        Me.lblPesoGra.Location = New System.Drawing.Point(389, 134)
        Me.lblPesoGra.Name = "lblPesoGra"
        Me.lblPesoGra.Size = New System.Drawing.Size(44, 18)
        Me.lblPesoGra.TabIndex = 4
        Me.lblPesoGra.Text = "00.00"
        '
        'lblNombre
        '
        Me.lblNombre.Font = New System.Drawing.Font("Garamond", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblNombre.ForeColor = System.Drawing.Color.Red
        Me.lblNombre.Location = New System.Drawing.Point(270, 19)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(247, 85)
        Me.lblNombre.TabIndex = 3
        Me.lblNombre.Text = "Nombre Del Producto"
        '
        'pcImagen
        '
        '' Me.pcImagen.Image = Global.Juan_Piece_RestauranteOtaku.My.Resources.Resources._149px_Picture_icon_BLACK_svg
        Me.pcImagen.Location = New System.Drawing.Point(27, 37)
        Me.pcImagen.Name = "pcImagen"
        Me.pcImagen.Size = New System.Drawing.Size(222, 196)
        Me.pcImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pcImagen.TabIndex = 2
        Me.pcImagen.TabStop = False
        '
        'Tiempo
        '
        Me.Tiempo.Enabled = True
        '
        'ImprimirPreview
        '
        Me.ImprimirPreview.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.ImprimirPreview.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.ImprimirPreview.ClientSize = New System.Drawing.Size(400, 300)
        Me.ImprimirPreview.Enabled = True
        Me.ImprimirPreview.Icon = CType(resources.GetObject("ImprimirPreview.Icon"), System.Drawing.Icon)
        Me.ImprimirPreview.Name = "ImprimirPreview"
        Me.ImprimirPreview.Visible = False
        '
        'pictureNoIngredientes
        '
        '' Me.pictureNoIngredientes.Image = Global.Juan_Piece_RestauranteOtaku.My.Resources.Resources.noExiste
        Me.pictureNoIngredientes.Location = New System.Drawing.Point(23, 271)
        Me.pictureNoIngredientes.Name = "pictureNoIngredientes"
        Me.pictureNoIngredientes.Size = New System.Drawing.Size(494, 275)
        Me.pictureNoIngredientes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pictureNoIngredientes.TabIndex = 17
        Me.pictureNoIngredientes.TabStop = False
        Me.pictureNoIngredientes.Visible = False
        '
        'frPlatillos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1350, 729)
        Me.Controls.Add(Me.gpInformacionPlatillo)
        Me.Controls.Add(Me.dgPlatillos)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frPlatillos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Platillos"
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.dgPlatillos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpInformacionPlatillo.ResumeLayout(False)
        Me.gpInformacionPlatillo.PerformLayout()
        CType(Me.dgIngredientes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcImagen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureNoIngredientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnGenerar As Button
    Friend WithEvents btnCancelarVenta As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnSalir As Button
    Friend WithEvents btnFactura As Button
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewImageColumn
    Friend WithEvents dgPlatillos As DataGridView
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents lblHora As Label
    Friend WithEvents Tiempo As Timer
    Friend WithEvents Imprimir As Printing.PrintDocument
    Friend WithEvents ImprimirPreview As PrintPreviewDialog
    Friend WithEvents pcImagen As PictureBox
    Friend WithEvents lblNombre As Label
    Friend WithEvents lblPesoGra As Label
    Friend WithEvents lblDescripcion As Label
    Friend WithEvents dgIngredientes As DataGridView
    Friend WithEvents lblPrecioN As Label
    Friend WithEvents lblPrecioD As Label
    Friend WithEvents lblPrecioH As Label
    Friend WithEvents lblPesoOnz As Label
    Friend WithEvents lblTipo As Label
    Friend WithEvents lblinfo1 As Label
    Friend WithEvents lblinfo2 As Label
    Friend WithEvents lblinfo3 As Label
    Friend WithEvents lblinfo4 As Label
    Friend WithEvents lblinfo5 As Label
    Friend WithEvents gpInformacionPlatillo As GroupBox
    Friend WithEvents pictureNoIngredientes As PictureBox
End Class
