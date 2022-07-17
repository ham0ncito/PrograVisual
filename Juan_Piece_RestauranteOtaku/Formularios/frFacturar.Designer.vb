<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frFacturar
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frFacturar))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnFactura = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnCancelarVenta = New System.Windows.Forms.Button()
        Me.btnGenerar = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblHora = New System.Windows.Forms.Label()
        Me.panelIzquierdo = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.lbl = New System.Windows.Forms.Label()
        Me.lblVenta = New System.Windows.Forms.Label()
        Me.btnOtros = New System.Windows.Forms.Button()
        Me.btnPasteles = New System.Windows.Forms.Button()
        Me.btnSushi = New System.Windows.Forms.Button()
        Me.btnRamen = New System.Windows.Forms.Button()
        Me.btnSopas = New System.Windows.Forms.Button()
        Me.btnSnacks = New System.Windows.Forms.Button()
        Me.btnEntradas = New System.Windows.Forms.Button()
        Me.btnFuerte = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.lblCategorias = New System.Windows.Forms.Label()
        Me.dgFacturar = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Tiempo = New System.Windows.Forms.Timer(Me.components)
        Me.Imprimir = New System.Drawing.Printing.PrintDocument()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.panelIzquierdo.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.dgFacturar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Panel1.Size = New System.Drawing.Size(1370, 90)
        Me.Panel1.TabIndex = 0
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnSalir.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnSalir.Font = New System.Drawing.Font("Garamond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnSalir.Location = New System.Drawing.Point(912, 0)
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
        Me.btnFactura.Location = New System.Drawing.Point(769, 0)
        Me.btnFactura.Name = "btnFactura"
        Me.btnFactura.Size = New System.Drawing.Size(143, 90)
        Me.btnFactura.TabIndex = 4
        Me.btnFactura.Text = "Ver Factura"
        Me.btnFactura.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox1.Image = Global.Juan_Piece_RestauranteOtaku.My.Resources.Resources.One_Pice__1__PhotoRoom__1_
        Me.PictureBox1.Location = New System.Drawing.Point(565, 0)
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
        Me.btnCancelarVenta.Location = New System.Drawing.Point(422, 0)
        Me.btnCancelarVenta.Name = "btnCancelarVenta"
        Me.btnCancelarVenta.Size = New System.Drawing.Size(143, 90)
        Me.btnCancelarVenta.TabIndex = 2
        Me.btnCancelarVenta.Text = "Cancelar Venta"
        Me.btnCancelarVenta.UseVisualStyleBackColor = False
        '
        'btnGenerar
        '
        Me.btnGenerar.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnGenerar.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnGenerar.Font = New System.Drawing.Font("Garamond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnGenerar.Location = New System.Drawing.Point(279, 0)
        Me.btnGenerar.Name = "btnGenerar"
        Me.btnGenerar.Size = New System.Drawing.Size(143, 90)
        Me.btnGenerar.TabIndex = 1
        Me.btnGenerar.Text = "Generar Venta"
        Me.btnGenerar.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.lblHora)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(279, 90)
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
        'panelIzquierdo
        '
        Me.panelIzquierdo.AutoScroll = True
        Me.panelIzquierdo.BackColor = System.Drawing.Color.Goldenrod
        Me.panelIzquierdo.Controls.Add(Me.Panel3)
        Me.panelIzquierdo.Controls.Add(Me.btnOtros)
        Me.panelIzquierdo.Controls.Add(Me.btnPasteles)
        Me.panelIzquierdo.Controls.Add(Me.btnSushi)
        Me.panelIzquierdo.Controls.Add(Me.btnRamen)
        Me.panelIzquierdo.Controls.Add(Me.btnSopas)
        Me.panelIzquierdo.Controls.Add(Me.btnSnacks)
        Me.panelIzquierdo.Controls.Add(Me.btnEntradas)
        Me.panelIzquierdo.Controls.Add(Me.btnFuerte)
        Me.panelIzquierdo.Controls.Add(Me.Panel4)
        Me.panelIzquierdo.Dock = System.Windows.Forms.DockStyle.Left
        Me.panelIzquierdo.Location = New System.Drawing.Point(0, 90)
        Me.panelIzquierdo.Name = "panelIzquierdo"
        Me.panelIzquierdo.Size = New System.Drawing.Size(155, 659)
        Me.panelIzquierdo.TabIndex = 1
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Black
        Me.Panel3.Controls.Add(Me.lbl)
        Me.Panel3.Controls.Add(Me.lblVenta)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 514)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(155, 145)
        Me.Panel3.TabIndex = 9
        '
        'lbl
        '
        Me.lbl.AutoSize = True
        Me.lbl.Font = New System.Drawing.Font("Garamond", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbl.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lbl.Location = New System.Drawing.Point(30, 16)
        Me.lbl.Name = "lbl"
        Me.lbl.Size = New System.Drawing.Size(101, 21)
        Me.lbl.TabIndex = 1
        Me.lbl.Text = "Total Diario"
        '
        'lblVenta
        '
        Me.lblVenta.AutoSize = True
        Me.lblVenta.Font = New System.Drawing.Font("Garamond", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblVenta.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lblVenta.Location = New System.Drawing.Point(30, 48)
        Me.lblVenta.Name = "lblVenta"
        Me.lblVenta.Size = New System.Drawing.Size(101, 21)
        Me.lblVenta.TabIndex = 0
        Me.lblVenta.Text = "Total Diario"
        '
        'btnOtros
        '
        Me.btnOtros.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnOtros.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnOtros.Font = New System.Drawing.Font("Garamond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnOtros.Location = New System.Drawing.Point(0, 458)
        Me.btnOtros.Name = "btnOtros"
        Me.btnOtros.Size = New System.Drawing.Size(155, 56)
        Me.btnOtros.TabIndex = 8
        Me.btnOtros.Text = "Otros"
        Me.btnOtros.UseVisualStyleBackColor = False
        '
        'btnPasteles
        '
        Me.btnPasteles.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnPasteles.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnPasteles.Font = New System.Drawing.Font("Garamond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnPasteles.Location = New System.Drawing.Point(0, 402)
        Me.btnPasteles.Name = "btnPasteles"
        Me.btnPasteles.Size = New System.Drawing.Size(155, 56)
        Me.btnPasteles.TabIndex = 7
        Me.btnPasteles.Text = "Pasteles"
        Me.btnPasteles.UseVisualStyleBackColor = False
        '
        'btnSushi
        '
        Me.btnSushi.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnSushi.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnSushi.Font = New System.Drawing.Font("Garamond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnSushi.Location = New System.Drawing.Point(0, 346)
        Me.btnSushi.Name = "btnSushi"
        Me.btnSushi.Size = New System.Drawing.Size(155, 56)
        Me.btnSushi.TabIndex = 6
        Me.btnSushi.Text = "Sushi"
        Me.btnSushi.UseVisualStyleBackColor = False
        '
        'btnRamen
        '
        Me.btnRamen.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnRamen.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnRamen.Font = New System.Drawing.Font("Garamond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnRamen.Location = New System.Drawing.Point(0, 290)
        Me.btnRamen.Name = "btnRamen"
        Me.btnRamen.Size = New System.Drawing.Size(155, 56)
        Me.btnRamen.TabIndex = 5
        Me.btnRamen.Text = "Ramen"
        Me.btnRamen.UseVisualStyleBackColor = False
        '
        'btnSopas
        '
        Me.btnSopas.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnSopas.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnSopas.Font = New System.Drawing.Font("Garamond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnSopas.Location = New System.Drawing.Point(0, 234)
        Me.btnSopas.Name = "btnSopas"
        Me.btnSopas.Size = New System.Drawing.Size(155, 56)
        Me.btnSopas.TabIndex = 4
        Me.btnSopas.Text = "Sopas"
        Me.btnSopas.UseVisualStyleBackColor = False
        '
        'btnSnacks
        '
        Me.btnSnacks.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnSnacks.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnSnacks.Font = New System.Drawing.Font("Garamond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnSnacks.Location = New System.Drawing.Point(0, 178)
        Me.btnSnacks.Name = "btnSnacks"
        Me.btnSnacks.Size = New System.Drawing.Size(155, 56)
        Me.btnSnacks.TabIndex = 3
        Me.btnSnacks.Text = "Snacks"
        Me.btnSnacks.UseVisualStyleBackColor = False
        '
        'btnEntradas
        '
        Me.btnEntradas.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnEntradas.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnEntradas.Font = New System.Drawing.Font("Garamond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnEntradas.Location = New System.Drawing.Point(0, 122)
        Me.btnEntradas.Name = "btnEntradas"
        Me.btnEntradas.Size = New System.Drawing.Size(155, 56)
        Me.btnEntradas.TabIndex = 2
        Me.btnEntradas.Text = "Entradas"
        Me.btnEntradas.UseVisualStyleBackColor = False
        '
        'btnFuerte
        '
        Me.btnFuerte.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnFuerte.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnFuerte.Font = New System.Drawing.Font("Garamond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnFuerte.Location = New System.Drawing.Point(0, 66)
        Me.btnFuerte.Name = "btnFuerte"
        Me.btnFuerte.Size = New System.Drawing.Size(155, 56)
        Me.btnFuerte.TabIndex = 1
        Me.btnFuerte.Text = "Plato Fuerte"
        Me.btnFuerte.UseVisualStyleBackColor = False
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.White
        Me.Panel4.Controls.Add(Me.lblCategorias)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(155, 66)
        Me.Panel4.TabIndex = 0
        '
        'lblCategorias
        '
        Me.lblCategorias.AutoSize = True
        Me.lblCategorias.Font = New System.Drawing.Font("Garamond", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblCategorias.Location = New System.Drawing.Point(21, 21)
        Me.lblCategorias.Name = "lblCategorias"
        Me.lblCategorias.Size = New System.Drawing.Size(110, 27)
        Me.lblCategorias.TabIndex = 0
        Me.lblCategorias.Text = "Categorias"
        '
        'dgFacturar
        '
        Me.dgFacturar.AllowDrop = True
        Me.dgFacturar.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.dgFacturar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgFacturar.GridColor = System.Drawing.Color.Black
        Me.dgFacturar.Location = New System.Drawing.Point(197, 116)
        Me.dgFacturar.Name = "dgFacturar"
        Me.dgFacturar.RowTemplate.Height = 25
        Me.dgFacturar.Size = New System.Drawing.Size(587, 297)
        Me.dgFacturar.TabIndex = 2
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.lblNombre)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.PictureBox2)
        Me.GroupBox1.Location = New System.Drawing.Point(197, 419)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(587, 239)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Facturar venta"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Garamond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(307, 125)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 18)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Subtotal"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Garamond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(190, 125)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 18)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Subtotal"
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Garamond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Button2.Location = New System.Drawing.Point(350, 178)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(136, 44)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "Cancelar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Garamond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Button1.Location = New System.Drawing.Point(190, 178)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(136, 44)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Agregar al carrito"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Garamond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(190, 84)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 18)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Cantidad"
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Font = New System.Drawing.Font("Garamond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblNombre.Location = New System.Drawing.Point(256, 39)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(145, 18)
        Me.lblNombre.TabIndex = 2
        Me.lblNombre.Text = "Nombre del Producto"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(308, 83)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(161, 23)
        Me.TextBox1.TabIndex = 1
        '
        'PictureBox2
        '
        Me.PictureBox2.Location = New System.Drawing.Point(20, 39)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(133, 128)
        Me.PictureBox2.TabIndex = 0
        Me.PictureBox2.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Location = New System.Drawing.Point(804, 111)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(534, 547)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Detalle Venta"
        '
        'Tiempo
        '
        Me.Tiempo.Enabled = True
        '
        'frFacturar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1370, 749)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.dgFacturar)
        Me.Controls.Add(Me.panelIzquierdo)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frFacturar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Facturar"
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.panelIzquierdo.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.dgFacturar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnGenerar As Button
    Friend WithEvents btnCancelarVenta As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnSalir As Button
    Friend WithEvents btnFactura As Button
    Friend WithEvents panelIzquierdo As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents lblCategorias As Label
    Friend WithEvents btnFuerte As Button
    Friend WithEvents btnEntradas As Button
    Friend WithEvents btnSnacks As Button
    Friend WithEvents btnSopas As Button
    Friend WithEvents btnRamen As Button
    Friend WithEvents btnSushi As Button
    Friend WithEvents btnPasteles As Button
    Friend WithEvents btnOtros As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewImageColumn
    Friend WithEvents dgFacturar As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents lblNombre As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblHora As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents lblVenta As Label
    Friend WithEvents lbl As Label
    Friend WithEvents Tiempo As Timer
    Friend WithEvents Imprimir As Printing.PrintDocument
End Class
