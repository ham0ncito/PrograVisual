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
        Me.lblDiarioVenta = New System.Windows.Forms.Label()
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
        Me.lblSubDetalle = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.panel5 = New System.Windows.Forms.Panel()
        Me.btnNuevoCliente = New System.Windows.Forms.Button()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lblSubtotal = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblCodigo = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.lblCliente = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblNumeroFactura = New System.Windows.Forms.Label()
        Me.dgDetalle = New System.Windows.Forms.DataGridView()
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
        Me.GroupBox2.SuspendLayout()
        Me.panel5.SuspendLayout()
        CType(Me.dgDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Panel3.Controls.Add(Me.lblDiarioVenta)
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
        'lblDiarioVenta
        '
        Me.lblDiarioVenta.AutoSize = True
        Me.lblDiarioVenta.Font = New System.Drawing.Font("Garamond", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblDiarioVenta.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lblDiarioVenta.Location = New System.Drawing.Point(30, 48)
        Me.lblDiarioVenta.Name = "lblDiarioVenta"
        Me.lblDiarioVenta.Size = New System.Drawing.Size(50, 21)
        Me.lblDiarioVenta.TabIndex = 0
        Me.lblDiarioVenta.Text = "00.00"
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
        Me.Panel4.BackColor = System.Drawing.Color.Orange
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
        Me.dgFacturar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgFacturar.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.dgFacturar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgFacturar.GridColor = System.Drawing.Color.Black
        Me.dgFacturar.Location = New System.Drawing.Point(171, 111)
        Me.dgFacturar.Name = "dgFacturar"
        Me.dgFacturar.ReadOnly = True
        Me.dgFacturar.RowTemplate.Height = 25
        Me.dgFacturar.Size = New System.Drawing.Size(617, 317)
        Me.dgFacturar.TabIndex = 2
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblSubDetalle)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.lblNombre)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.PictureBox2)
        Me.GroupBox1.Location = New System.Drawing.Point(171, 447)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(618, 239)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Facturar venta"
        '
        'lblSubDetalle
        '
        Me.lblSubDetalle.AutoSize = True
        Me.lblSubDetalle.Font = New System.Drawing.Font("Garamond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblSubDetalle.Location = New System.Drawing.Point(307, 125)
        Me.lblSubDetalle.Name = "lblSubDetalle"
        Me.lblSubDetalle.Size = New System.Drawing.Size(44, 18)
        Me.lblSubDetalle.TabIndex = 8
        Me.lblSubDetalle.Text = "00.00"
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
        Me.GroupBox2.Controls.Add(Me.panel5)
        Me.GroupBox2.Controls.Add(Me.dgDetalle)
        Me.GroupBox2.Location = New System.Drawing.Point(804, 111)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(534, 575)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Detalle Venta"
        '
        'panel5
        '
        Me.panel5.BackColor = System.Drawing.SystemColors.ControlLight
        Me.panel5.Controls.Add(Me.btnNuevoCliente)
        Me.panel5.Controls.Add(Me.lblTotal)
        Me.panel5.Controls.Add(Me.lblSubtotal)
        Me.panel5.Controls.Add(Me.Label7)
        Me.panel5.Controls.Add(Me.Label6)
        Me.panel5.Controls.Add(Me.lblCodigo)
        Me.panel5.Controls.Add(Me.Label5)
        Me.panel5.Controls.Add(Me.ComboBox1)
        Me.panel5.Controls.Add(Me.lblCliente)
        Me.panel5.Controls.Add(Me.Label4)
        Me.panel5.Controls.Add(Me.lblNumeroFactura)
        Me.panel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panel5.Location = New System.Drawing.Point(3, 302)
        Me.panel5.Name = "panel5"
        Me.panel5.Size = New System.Drawing.Size(528, 270)
        Me.panel5.TabIndex = 1
        '
        'btnNuevoCliente
        '
        Me.btnNuevoCliente.Font = New System.Drawing.Font("Garamond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnNuevoCliente.Location = New System.Drawing.Point(381, 59)
        Me.btnNuevoCliente.Name = "btnNuevoCliente"
        Me.btnNuevoCliente.Size = New System.Drawing.Size(118, 31)
        Me.btnNuevoCliente.TabIndex = 10
        Me.btnNuevoCliente.Text = "Nuevo Cliente"
        Me.btnNuevoCliente.UseVisualStyleBackColor = True
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New System.Drawing.Font("Garamond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblTotal.Location = New System.Drawing.Point(143, 225)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(44, 18)
        Me.lblTotal.TabIndex = 9
        Me.lblTotal.Text = "00.00"
        '
        'lblSubtotal
        '
        Me.lblSubtotal.AutoSize = True
        Me.lblSubtotal.Font = New System.Drawing.Font("Garamond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblSubtotal.Location = New System.Drawing.Point(143, 183)
        Me.lblSubtotal.Name = "lblSubtotal"
        Me.lblSubtotal.Size = New System.Drawing.Size(44, 18)
        Me.lblSubtotal.TabIndex = 8
        Me.lblSubtotal.Text = "00.00"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Garamond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label7.Location = New System.Drawing.Point(25, 225)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(42, 18)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Total"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Garamond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label6.Location = New System.Drawing.Point(25, 183)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(61, 18)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Subtotal"
        '
        'lblCodigo
        '
        Me.lblCodigo.AutoSize = True
        Me.lblCodigo.Font = New System.Drawing.Font("Garamond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblCodigo.Location = New System.Drawing.Point(143, 107)
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.Size = New System.Drawing.Size(19, 18)
        Me.lblCodigo.TabIndex = 5
        Me.lblCodigo.Text = "#"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Garamond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(25, 107)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(102, 18)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Codigo Cliente"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(143, 60)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(195, 23)
        Me.ComboBox1.TabIndex = 3
        '
        'lblCliente
        '
        Me.lblCliente.AutoSize = True
        Me.lblCliente.Font = New System.Drawing.Font("Garamond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblCliente.Location = New System.Drawing.Point(25, 65)
        Me.lblCliente.Name = "lblCliente"
        Me.lblCliente.Size = New System.Drawing.Size(53, 18)
        Me.lblCliente.TabIndex = 2
        Me.lblCliente.Text = "Cliente"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Garamond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(25, 23)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(112, 18)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Numero factura "
        '
        'lblNumeroFactura
        '
        Me.lblNumeroFactura.AutoSize = True
        Me.lblNumeroFactura.Font = New System.Drawing.Font("Garamond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblNumeroFactura.Location = New System.Drawing.Point(143, 23)
        Me.lblNumeroFactura.Name = "lblNumeroFactura"
        Me.lblNumeroFactura.Size = New System.Drawing.Size(19, 18)
        Me.lblNumeroFactura.TabIndex = 0
        Me.lblNumeroFactura.Text = "#"
        '
        'dgDetalle
        '
        Me.dgDetalle.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgDetalle.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgDetalle.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.dgDetalle.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgDetalle.Dock = System.Windows.Forms.DockStyle.Top
        Me.dgDetalle.Location = New System.Drawing.Point(3, 19)
        Me.dgDetalle.Name = "dgDetalle"
        Me.dgDetalle.RowTemplate.Height = 25
        Me.dgDetalle.Size = New System.Drawing.Size(528, 283)
        Me.dgDetalle.TabIndex = 0
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
        Me.GroupBox2.ResumeLayout(False)
        Me.panel5.ResumeLayout(False)
        Me.panel5.PerformLayout()
        CType(Me.dgDetalle, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents dgDetalle As DataGridView
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
    Friend WithEvents lblSubDetalle As Label
    Friend WithEvents lblHora As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents lblDiarioVenta As Label
    Friend WithEvents lbl As Label
    Friend WithEvents Tiempo As Timer
    Friend WithEvents Imprimir As Printing.PrintDocument
    Friend WithEvents panel5 As Panel
    Friend WithEvents lblNumeroFactura As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblCliente As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents lblCodigo As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lblSubtotal As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents btnNuevoCliente As Button
End Class
