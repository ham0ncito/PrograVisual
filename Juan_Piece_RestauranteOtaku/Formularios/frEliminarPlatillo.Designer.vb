<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frEliminarPlatillo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frEliminarPlatillo))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbPlatillosActivos = New System.Windows.Forms.ComboBox()
        Me.imagenPlatillo = New System.Windows.Forms.PictureBox()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.lblDescripcion = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtContraseña = New System.Windows.Forms.TextBox()
        Me.errorcito = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imagenPlatillo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.errorcito, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Top
        'Me.PictureBox1.Image = Global.Juan_Piece_RestauranteOtaku.My.Resources.Resources.One_Pice__1__PhotoRoom__1_
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(656, 88)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Garamond", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.Brown
        Me.Label1.Location = New System.Drawing.Point(353, 112)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(127, 21)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Platillos Activos"
        '
        'cmbPlatillosActivos
        '
        Me.cmbPlatillosActivos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPlatillosActivos.Font = New System.Drawing.Font("Garamond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.cmbPlatillosActivos.FormattingEnabled = True
        Me.cmbPlatillosActivos.Location = New System.Drawing.Point(353, 166)
        Me.cmbPlatillosActivos.Name = "cmbPlatillosActivos"
        Me.cmbPlatillosActivos.Size = New System.Drawing.Size(272, 26)
        Me.cmbPlatillosActivos.TabIndex = 2
        '
        'imagenPlatillo
        '
        'Me.imagenPlatillo.Image = Global.Juan_Piece_RestauranteOtaku.My.Resources.Resources._149px_Picture_icon_BLACK_svg
        Me.imagenPlatillo.Location = New System.Drawing.Point(41, 112)
        Me.imagenPlatillo.Name = "imagenPlatillo"
        Me.imagenPlatillo.Size = New System.Drawing.Size(272, 126)
        Me.imagenPlatillo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.imagenPlatillo.TabIndex = 3
        Me.imagenPlatillo.TabStop = False
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Font = New System.Drawing.Font("Garamond", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblNombre.ForeColor = System.Drawing.Color.Brown
        Me.lblNombre.Location = New System.Drawing.Point(41, 254)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(127, 21)
        Me.lblNombre.TabIndex = 4
        Me.lblNombre.Text = "Nombre Platillo"
        '
        'lblDescripcion
        '
        Me.lblDescripcion.Font = New System.Drawing.Font("Garamond", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblDescripcion.ForeColor = System.Drawing.Color.Black
        Me.lblDescripcion.Location = New System.Drawing.Point(41, 287)
        Me.lblDescripcion.Name = "lblDescripcion"
        Me.lblDescripcion.Size = New System.Drawing.Size(272, 137)
        Me.lblDescripcion.TabIndex = 5
        Me.lblDescripcion.Text = "Descripcion"
        Me.lblDescripcion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.txtContraseña)
        Me.GroupBox1.Location = New System.Drawing.Point(353, 254)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(272, 157)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ingrese su contraseña para continuar"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(69, 109)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(123, 26)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Eliminar Platillo"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtContraseña
        '
        Me.txtContraseña.Location = New System.Drawing.Point(23, 47)
        Me.txtContraseña.Name = "txtContraseña"
        Me.txtContraseña.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtContraseña.Size = New System.Drawing.Size(228, 23)
        Me.txtContraseña.TabIndex = 0
        '
        'errorcito
        '
        Me.errorcito.ContainerControl = Me
        '
        'frEliminarPlatillo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(656, 439)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblDescripcion)
        Me.Controls.Add(Me.lblNombre)
        Me.Controls.Add(Me.imagenPlatillo)
        Me.Controls.Add(Me.cmbPlatillosActivos)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frEliminarPlatillo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Eliminar Platillo"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imagenPlatillo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.errorcito, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cmbPlatillosActivos As ComboBox
    Friend WithEvents imagenPlatillo As PictureBox
    Friend WithEvents lblNombre As Label
    Friend WithEvents lblDescripcion As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtContraseña As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents errorcito As ErrorProvider
End Class
