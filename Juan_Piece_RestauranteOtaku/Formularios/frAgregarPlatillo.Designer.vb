<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frAgregarPlatillo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frAgregarPlatillo))
        Me.pcLogo = New System.Windows.Forms.PictureBox()
        Me.panelSuperior = New System.Windows.Forms.Panel()
        Me.imagenProducto = New System.Windows.Forms.PictureBox()
        Me.lblTipo = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.lblPesoOnzas = New System.Windows.Forms.Label()
        Me.lblPeso = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmbTipos = New System.Windows.Forms.ComboBox()
        Me.btnConvertir = New System.Windows.Forms.Button()
        Me.gpPesos = New System.Windows.Forms.GroupBox()
        Me.txtPesoOnz = New System.Windows.Forms.TextBox()
        Me.txtPesoG = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.txtNombrePlatillo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnAg = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.txtPrecioN = New System.Windows.Forms.TextBox()
        Me.txtPrecioD = New System.Windows.Forms.TextBox()
        Me.txtPrecioF = New System.Windows.Forms.TextBox()
        Me.opfCargar = New System.Windows.Forms.OpenFileDialog()
        Me.errocrito = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        CType(Me.pcLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelSuperior.SuspendLayout()
        CType(Me.imagenProducto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpPesos.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.errocrito, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'pcLogo
        '
        Me.pcLogo.Dock = System.Windows.Forms.DockStyle.Top
        'Me.pcLogo.Image = Global.Juan_Piece_RestauranteOtaku.My.Resources.Resources.One_Pice__1__PhotoRoom__1_
        ' Me.pcLogo.InitialImage = Global.Juan_Piece_RestauranteOtaku.My.Resources.Resources.One_Pice__1__PhotoRoom__1_
        Me.pcLogo.Location = New System.Drawing.Point(0, 0)
        Me.pcLogo.Name = "pcLogo"
        Me.pcLogo.Size = New System.Drawing.Size(849, 97)
        Me.pcLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pcLogo.TabIndex = 0
        Me.pcLogo.TabStop = False
        '
        'panelSuperior
        '
        Me.panelSuperior.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.panelSuperior.Controls.Add(Me.pcLogo)
        Me.panelSuperior.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelSuperior.Location = New System.Drawing.Point(0, 0)
        Me.panelSuperior.Name = "panelSuperior"
        Me.panelSuperior.Size = New System.Drawing.Size(849, 100)
        Me.panelSuperior.TabIndex = 1
        '
        'imagenProducto
        '
        'Me.imagenProducto.Image = Global.Juan_Piece_RestauranteOtaku.My.Resources.Resources._149px_Picture_icon_BLACK_svg
        Me.imagenProducto.Location = New System.Drawing.Point(28, 120)
        Me.imagenProducto.Name = "imagenProducto"
        Me.imagenProducto.Size = New System.Drawing.Size(355, 186)
        Me.imagenProducto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.imagenProducto.TabIndex = 2
        Me.imagenProducto.TabStop = False
        '
        'lblTipo
        '
        Me.lblTipo.AutoSize = True
        Me.lblTipo.Font = New System.Drawing.Font("Garamond", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblTipo.Location = New System.Drawing.Point(240, 326)
        Me.lblTipo.Name = "lblTipo"
        Me.lblTipo.Size = New System.Drawing.Size(122, 21)
        Me.lblTipo.TabIndex = 3
        Me.lblTipo.Text = "Tipo de Platillo"
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Font = New System.Drawing.Font("Garamond", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblNombre.Location = New System.Drawing.Point(16, 14)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(175, 21)
        Me.lblNombre.TabIndex = 4
        Me.lblNombre.Text = "Nombre del Producto"
        '
        'lblPesoOnzas
        '
        Me.lblPesoOnzas.AutoSize = True
        Me.lblPesoOnzas.Font = New System.Drawing.Font("Garamond", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblPesoOnzas.Location = New System.Drawing.Point(22, 96)
        Me.lblPesoOnzas.Name = "lblPesoOnzas"
        Me.lblPesoOnzas.Size = New System.Drawing.Size(122, 21)
        Me.lblPesoOnzas.TabIndex = 5
        Me.lblPesoOnzas.Text = "Peso en Onzas"
        '
        'lblPeso
        '
        Me.lblPeso.AutoSize = True
        Me.lblPeso.Font = New System.Drawing.Font("Garamond", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblPeso.Location = New System.Drawing.Point(22, 44)
        Me.lblPeso.Name = "lblPeso"
        Me.lblPeso.Size = New System.Drawing.Size(129, 21)
        Me.lblPeso.TabIndex = 6
        Me.lblPeso.Text = "Peso en gramos"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Garamond", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(28, 441)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(119, 21)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Precio Normal"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Garamond", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label6.Location = New System.Drawing.Point(28, 485)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(143, 21)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Precio Descuento"
        '
        'cmbTipos
        '
        Me.cmbTipos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTipos.Font = New System.Drawing.Font("Garamond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.cmbTipos.FormattingEnabled = True
        Me.cmbTipos.Location = New System.Drawing.Point(369, 321)
        Me.cmbTipos.Name = "cmbTipos"
        Me.cmbTipos.Size = New System.Drawing.Size(226, 26)
        Me.cmbTipos.TabIndex = 9
        '
        'btnConvertir
        '
        Me.btnConvertir.Font = New System.Drawing.Font("Garamond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnConvertir.Location = New System.Drawing.Point(116, 140)
        Me.btnConvertir.Name = "btnConvertir"
        Me.btnConvertir.Size = New System.Drawing.Size(97, 31)
        Me.btnConvertir.TabIndex = 10
        Me.btnConvertir.Text = "Convertir"
        Me.btnConvertir.UseVisualStyleBackColor = True
        '
        'gpPesos
        '
        Me.gpPesos.Controls.Add(Me.txtPesoOnz)
        Me.gpPesos.Controls.Add(Me.txtPesoG)
        Me.gpPesos.Controls.Add(Me.lblPeso)
        Me.gpPesos.Controls.Add(Me.btnConvertir)
        Me.gpPesos.Controls.Add(Me.lblPesoOnzas)
        Me.gpPesos.Font = New System.Drawing.Font("Garamond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.gpPesos.Location = New System.Drawing.Point(439, 120)
        Me.gpPesos.Name = "gpPesos"
        Me.gpPesos.Size = New System.Drawing.Size(361, 186)
        Me.gpPesos.TabIndex = 11
        Me.gpPesos.TabStop = False
        Me.gpPesos.Text = "Peso del Platillo"
        '
        'txtPesoOnz
        '
        Me.txtPesoOnz.Location = New System.Drawing.Point(157, 91)
        Me.txtPesoOnz.Multiline = True
        Me.txtPesoOnz.Name = "txtPesoOnz"
        Me.txtPesoOnz.Size = New System.Drawing.Size(172, 26)
        Me.txtPesoOnz.TabIndex = 14
        Me.txtPesoOnz.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtPesoG
        '
        Me.txtPesoG.Location = New System.Drawing.Point(157, 44)
        Me.txtPesoG.Multiline = True
        Me.txtPesoG.Name = "txtPesoG"
        Me.txtPesoG.Size = New System.Drawing.Size(172, 26)
        Me.txtPesoG.TabIndex = 13
        Me.txtPesoG.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtDescripcion)
        Me.GroupBox1.Font = New System.Drawing.Font("Garamond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.GroupBox1.Location = New System.Drawing.Point(439, 362)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(365, 258)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Descripcion del producto"
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Location = New System.Drawing.Point(22, 37)
        Me.txtDescripcion.Multiline = True
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(318, 203)
        Me.txtDescripcion.TabIndex = 0
        Me.txtDescripcion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtNombrePlatillo
        '
        Me.txtNombrePlatillo.Location = New System.Drawing.Point(16, 38)
        Me.txtNombrePlatillo.Multiline = True
        Me.txtNombrePlatillo.Name = "txtNombrePlatillo"
        Me.txtNombrePlatillo.Size = New System.Drawing.Size(355, 26)
        Me.txtNombrePlatillo.TabIndex = 1
        Me.txtNombrePlatillo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Garamond", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(28, 533)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 21)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Precio Feliz"
        '
        'btnAg
        '
        Me.btnAg.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnAg.Location = New System.Drawing.Point(240, 653)
        Me.btnAg.Name = "btnAg"
        Me.btnAg.Size = New System.Drawing.Size(174, 40)
        Me.btnAg.TabIndex = 14
        Me.btnAg.Text = "Agregar Platillo"
        Me.btnAg.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnEliminar.Location = New System.Drawing.Point(439, 653)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(174, 40)
        Me.btnEliminar.TabIndex = 15
        Me.btnEliminar.Text = "Limpiar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'txtPrecioN
        '
        Me.txtPrecioN.Location = New System.Drawing.Point(211, 441)
        Me.txtPrecioN.Multiline = True
        Me.txtPrecioN.Name = "txtPrecioN"
        Me.txtPrecioN.Size = New System.Drawing.Size(172, 26)
        Me.txtPrecioN.TabIndex = 15
        Me.txtPrecioN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtPrecioD
        '
        Me.txtPrecioD.Location = New System.Drawing.Point(211, 485)
        Me.txtPrecioD.Multiline = True
        Me.txtPrecioD.Name = "txtPrecioD"
        Me.txtPrecioD.ReadOnly = True
        Me.txtPrecioD.Size = New System.Drawing.Size(172, 26)
        Me.txtPrecioD.TabIndex = 16
        Me.txtPrecioD.Text = "Este valor lo genera el sistema"
        Me.txtPrecioD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtPrecioF
        '
        Me.txtPrecioF.Location = New System.Drawing.Point(211, 528)
        Me.txtPrecioF.Multiline = True
        Me.txtPrecioF.Name = "txtPrecioF"
        Me.txtPrecioF.ReadOnly = True
        Me.txtPrecioF.Size = New System.Drawing.Size(172, 26)
        Me.txtPrecioF.TabIndex = 17
        Me.txtPrecioF.Text = "Este valor lo genera el sistema"
        Me.txtPrecioF.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'opfCargar
        '
        Me.opfCargar.FileName = "Cargar Imagen"
        '
        'errocrito
        '
        Me.errocrito.BlinkRate = 400
        Me.errocrito.ContainerControl = Me
        '
        'btnCalcular
        '
        Me.btnCalcular.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnCalcular.Location = New System.Drawing.Point(127, 570)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(140, 32)
        Me.btnCalcular.TabIndex = 18
        Me.btnCalcular.Text = "Calcular Precios"
        Me.btnCalcular.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtNombrePlatillo)
        Me.GroupBox2.Controls.Add(Me.lblNombre)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 362)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(402, 258)
        Me.GroupBox2.TabIndex = 19
        Me.GroupBox2.TabStop = False
        '
        'frAgregarPlatillo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(849, 705)
        Me.Controls.Add(Me.btnCalcular)
        Me.Controls.Add(Me.txtPrecioF)
        Me.Controls.Add(Me.txtPrecioD)
        Me.Controls.Add(Me.txtPrecioN)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnAg)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.gpPesos)
        Me.Controls.Add(Me.cmbTipos)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblTipo)
        Me.Controls.Add(Me.imagenProducto)
        Me.Controls.Add(Me.panelSuperior)
        Me.Controls.Add(Me.GroupBox2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frAgregarPlatillo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Agregar Platillo"
        CType(Me.pcLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelSuperior.ResumeLayout(False)
        CType(Me.imagenProducto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpPesos.ResumeLayout(False)
        Me.gpPesos.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.errocrito, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pcLogo As PictureBox
    Friend WithEvents panelSuperior As Panel
    Friend WithEvents imagenProducto As PictureBox
    Friend WithEvents lblTipo As Label
    Friend WithEvents lblNombre As Label
    Friend WithEvents lblPesoOnzas As Label
    Friend WithEvents lblPeso As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents cmbTipos As ComboBox
    Friend WithEvents btnConvertir As Button
    Friend WithEvents gpPesos As GroupBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtDescripcion As TextBox
    Friend WithEvents txtNombrePlatillo As TextBox
    Friend WithEvents txtPesoG As TextBox
    Friend WithEvents txtPesoOnz As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnAg As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents txtPrecioN As TextBox
    Friend WithEvents txtPrecioD As TextBox
    Friend WithEvents txtPrecioF As TextBox
    Friend WithEvents opfCargar As OpenFileDialog
    Friend WithEvents errocrito As ErrorProvider
    Friend WithEvents btnCalcular As Button
    Friend WithEvents GroupBox2 As GroupBox
End Class
