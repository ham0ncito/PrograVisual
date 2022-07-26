<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frEditarPlatillo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frEditarPlatillo))
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.txtPrecioF = New System.Windows.Forms.TextBox()
        Me.txtPrecioD = New System.Windows.Forms.TextBox()
        Me.txtPrecioN = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.gpPesos = New System.Windows.Forms.GroupBox()
        Me.txtPesoOnz = New System.Windows.Forms.TextBox()
        Me.txtPesoG = New System.Windows.Forms.TextBox()
        Me.lblPeso = New System.Windows.Forms.Label()
        Me.btnConvertir = New System.Windows.Forms.Button()
        Me.lblPesoOnzas = New System.Windows.Forms.Label()
        Me.cmbTipos = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblTipo = New System.Windows.Forms.Label()
        Me.imagenProducto = New System.Windows.Forms.PictureBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtNombrePlatillo = New System.Windows.Forms.TextBox()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.cmbCodigos = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnAg = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.logo = New System.Windows.Forms.PictureBox()
        Me.opfCargar = New System.Windows.Forms.OpenFileDialog()
        Me.errocrito = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.gpPesos.SuspendLayout()
        CType(Me.imagenProducto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.logo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.errocrito, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnCalcular
        '
        Me.btnCalcular.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnCalcular.Location = New System.Drawing.Point(28, 162)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(140, 32)
        Me.btnCalcular.TabIndex = 31
        Me.btnCalcular.Text = "Calcular Precios"
        Me.btnCalcular.UseVisualStyleBackColor = True
        '
        'txtPrecioF
        '
        Me.txtPrecioF.Location = New System.Drawing.Point(208, 122)
        Me.txtPrecioF.Multiline = True
        Me.txtPrecioF.Name = "txtPrecioF"
        Me.txtPrecioF.ReadOnly = True
        Me.txtPrecioF.Size = New System.Drawing.Size(172, 26)
        Me.txtPrecioF.TabIndex = 30
        Me.txtPrecioF.Text = "Este valor lo genera el sistema"
        Me.txtPrecioF.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtPrecioD
        '
        Me.txtPrecioD.Location = New System.Drawing.Point(208, 79)
        Me.txtPrecioD.Multiline = True
        Me.txtPrecioD.Name = "txtPrecioD"
        Me.txtPrecioD.ReadOnly = True
        Me.txtPrecioD.Size = New System.Drawing.Size(172, 26)
        Me.txtPrecioD.TabIndex = 29
        Me.txtPrecioD.Text = "Este valor lo genera el sistema"
        Me.txtPrecioD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtPrecioN
        '
        Me.txtPrecioN.Location = New System.Drawing.Point(208, 39)
        Me.txtPrecioN.Multiline = True
        Me.txtPrecioN.Name = "txtPrecioN"
        Me.txtPrecioN.Size = New System.Drawing.Size(172, 26)
        Me.txtPrecioN.TabIndex = 28
        Me.txtPrecioN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Garamond", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(25, 127)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 21)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "Precio Feliz"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtDescripcion)
        Me.GroupBox1.Font = New System.Drawing.Font("Garamond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.GroupBox1.Location = New System.Drawing.Point(470, 320)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(415, 227)
        Me.GroupBox1.TabIndex = 26
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Descripcion del producto"
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Location = New System.Drawing.Point(22, 39)
        Me.txtDescripcion.Multiline = True
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(368, 168)
        Me.txtDescripcion.TabIndex = 0
        Me.txtDescripcion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'gpPesos
        '
        Me.gpPesos.Controls.Add(Me.txtPesoOnz)
        Me.gpPesos.Controls.Add(Me.txtPesoG)
        Me.gpPesos.Controls.Add(Me.lblPeso)
        Me.gpPesos.Controls.Add(Me.btnConvertir)
        Me.gpPesos.Controls.Add(Me.lblPesoOnzas)
        Me.gpPesos.Font = New System.Drawing.Font("Garamond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.gpPesos.Location = New System.Drawing.Point(470, 84)
        Me.gpPesos.Name = "gpPesos"
        Me.gpPesos.Size = New System.Drawing.Size(428, 181)
        Me.gpPesos.TabIndex = 25
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
        'btnConvertir
        '
        Me.btnConvertir.Font = New System.Drawing.Font("Garamond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnConvertir.Location = New System.Drawing.Point(25, 139)
        Me.btnConvertir.Name = "btnConvertir"
        Me.btnConvertir.Size = New System.Drawing.Size(97, 31)
        Me.btnConvertir.TabIndex = 10
        Me.btnConvertir.Text = "Convertir"
        Me.btnConvertir.UseVisualStyleBackColor = True
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
        'cmbTipos
        '
        Me.cmbTipos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTipos.Font = New System.Drawing.Font("Garamond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.cmbTipos.FormattingEnabled = True
        Me.cmbTipos.Location = New System.Drawing.Point(607, 278)
        Me.cmbTipos.Name = "cmbTipos"
        Me.cmbTipos.Size = New System.Drawing.Size(210, 26)
        Me.cmbTipos.TabIndex = 24
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Garamond", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label6.Location = New System.Drawing.Point(25, 79)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(143, 21)
        Me.Label6.TabIndex = 23
        Me.Label6.Text = "Precio Descuento"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Garamond", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(25, 39)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(119, 21)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "Precio Normal"
        '
        'lblTipo
        '
        Me.lblTipo.AutoSize = True
        Me.lblTipo.Font = New System.Drawing.Font("Garamond", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblTipo.Location = New System.Drawing.Point(470, 283)
        Me.lblTipo.Name = "lblTipo"
        Me.lblTipo.Size = New System.Drawing.Size(122, 21)
        Me.lblTipo.TabIndex = 21
        Me.lblTipo.Text = "Tipo de Platillo"
        '
        'imagenProducto
        '
        Me.imagenProducto.Image = Global.Juan_Piece_RestauranteOtaku.My.Resources.Resources._149px_Picture_icon_BLACK_svg
        Me.imagenProducto.Location = New System.Drawing.Point(25, 116)
        Me.imagenProducto.Name = "imagenProducto"
        Me.imagenProducto.Size = New System.Drawing.Size(289, 169)
        Me.imagenProducto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.imagenProducto.TabIndex = 20
        Me.imagenProducto.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.btnCalcular)
        Me.GroupBox2.Controls.Add(Me.txtPrecioN)
        Me.GroupBox2.Controls.Add(Me.txtPrecioD)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.txtPrecioF)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Location = New System.Drawing.Point(9, 353)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(419, 200)
        Me.GroupBox2.TabIndex = 32
        Me.GroupBox2.TabStop = False
        '
        'txtNombrePlatillo
        '
        Me.txtNombrePlatillo.Location = New System.Drawing.Point(25, 321)
        Me.txtNombrePlatillo.Multiline = True
        Me.txtNombrePlatillo.Name = "txtNombrePlatillo"
        Me.txtNombrePlatillo.Size = New System.Drawing.Size(355, 26)
        Me.txtNombrePlatillo.TabIndex = 1
        Me.txtNombrePlatillo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Font = New System.Drawing.Font("Garamond", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblNombre.Location = New System.Drawing.Point(25, 297)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(175, 21)
        Me.lblNombre.TabIndex = 4
        Me.lblNombre.Text = "Nombre del Producto"
        '
        'cmbCodigos
        '
        Me.cmbCodigos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCodigos.Font = New System.Drawing.Font("Garamond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.cmbCodigos.FormattingEnabled = True
        Me.cmbCodigos.Location = New System.Drawing.Point(154, 83)
        Me.cmbCodigos.Name = "cmbCodigos"
        Me.cmbCodigos.Size = New System.Drawing.Size(226, 26)
        Me.cmbCodigos.TabIndex = 34
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Garamond", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(30, 84)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(118, 21)
        Me.Label2.TabIndex = 33
        Me.Label2.Text = "Codigo Platillo"
        '
        'btnAg
        '
        Me.btnAg.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnAg.Location = New System.Drawing.Point(254, 575)
        Me.btnAg.Name = "btnAg"
        Me.btnAg.Size = New System.Drawing.Size(174, 40)
        Me.btnAg.TabIndex = 35
        Me.btnAg.Text = "Modificar"
        Me.btnAg.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Button1.Location = New System.Drawing.Point(482, 575)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(174, 40)
        Me.Button1.TabIndex = 36
        Me.Button1.Text = "Limpiar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'logo
        '
        Me.logo.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.logo.Dock = System.Windows.Forms.DockStyle.Top
        Me.logo.Image = Global.Juan_Piece_RestauranteOtaku.My.Resources.Resources.One_Pice__1__PhotoRoom__1_
        Me.logo.Location = New System.Drawing.Point(0, 0)
        Me.logo.Name = "logo"
        Me.logo.Size = New System.Drawing.Size(917, 68)
        Me.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.logo.TabIndex = 37
        Me.logo.TabStop = False
        '
        'opfCargar
        '
        Me.opfCargar.FileName = "OpenFileDialog1"
        '
        'errocrito
        '
        Me.errocrito.ContainerControl = Me
        '
        'frEditarPlatillo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(917, 627)
        Me.Controls.Add(Me.logo)
        Me.Controls.Add(Me.txtNombrePlatillo)
        Me.Controls.Add(Me.lblNombre)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnAg)
        Me.Controls.Add(Me.cmbCodigos)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.gpPesos)
        Me.Controls.Add(Me.cmbTipos)
        Me.Controls.Add(Me.lblTipo)
        Me.Controls.Add(Me.imagenProducto)
        Me.Controls.Add(Me.GroupBox2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frEditarPlatillo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Editar Platillo"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.gpPesos.ResumeLayout(False)
        Me.gpPesos.PerformLayout()
        CType(Me.imagenProducto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.logo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.errocrito, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCalcular As Button
    Friend WithEvents txtPrecioF As TextBox
    Friend WithEvents txtPrecioD As TextBox
    Friend WithEvents txtPrecioN As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtDescripcion As TextBox
    Friend WithEvents gpPesos As GroupBox
    Friend WithEvents txtPesoOnz As TextBox
    Friend WithEvents txtPesoG As TextBox
    Friend WithEvents lblPeso As Label
    Friend WithEvents btnConvertir As Button
    Friend WithEvents lblPesoOnzas As Label
    Friend WithEvents cmbTipos As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblTipo As Label
    Friend WithEvents imagenProducto As PictureBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtNombrePlatillo As TextBox
    Friend WithEvents lblNombre As Label
    Friend WithEvents cmbCodigos As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnAg As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents logo As PictureBox
    Friend WithEvents opfCargar As OpenFileDialog
    Friend WithEvents errocrito As ErrorProvider
End Class
