<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frInicio
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frInicio))
        Me.pMenu = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.pcUsuario = New System.Windows.Forms.PictureBox()
        Me.lblNombreUsuario = New System.Windows.Forms.Label()
        Me.btnCerrarSesion = New System.Windows.Forms.Button()
        Me.btnPlatillos = New System.Windows.Forms.Button()
        Me.btnFactura = New System.Windows.Forms.Button()
        Me.btnPedidos = New System.Windows.Forms.Button()
        Me.pcLogo = New System.Windows.Forms.PictureBox()
        Me.pHeading = New System.Windows.Forms.Panel()
        Me.lblHora = New System.Windows.Forms.Label()
        Me.lblUsuario = New System.Windows.Forms.Label()
        Me.PcAnuncio = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.timer = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.pMenu.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.pcUsuario, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pHeading.SuspendLayout()
        CType(Me.PcAnuncio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'pMenu
        '
        Me.pMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(9, Byte), Integer), CType(CType(9, Byte), Integer))
        Me.pMenu.Controls.Add(Me.Panel2)
        Me.pMenu.Controls.Add(Me.btnCerrarSesion)
        Me.pMenu.Controls.Add(Me.btnPlatillos)
        Me.pMenu.Controls.Add(Me.btnFactura)
        Me.pMenu.Controls.Add(Me.btnPedidos)
        Me.pMenu.Controls.Add(Me.pcLogo)
        Me.pMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.pMenu.Location = New System.Drawing.Point(0, 0)
        Me.pMenu.Margin = New System.Windows.Forms.Padding(4)
        Me.pMenu.Name = "pMenu"
        Me.pMenu.Size = New System.Drawing.Size(221, 749)
        Me.pMenu.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.pcUsuario)
        Me.Panel2.Controls.Add(Me.lblNombreUsuario)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 642)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(221, 107)
        Me.Panel2.TabIndex = 7
        '
        'pcUsuario
        '
        Me.pcUsuario.BackColor = System.Drawing.Color.Transparent
        Me.pcUsuario.Image = Global.Juan_Piece_RestauranteOtaku.My.Resources.Resources.user__5___1_
        Me.pcUsuario.Location = New System.Drawing.Point(12, 30)
        Me.pcUsuario.Name = "pcUsuario"
        Me.pcUsuario.Size = New System.Drawing.Size(66, 48)
        Me.pcUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pcUsuario.TabIndex = 1
        Me.pcUsuario.TabStop = False
        '
        'lblNombreUsuario
        '
        Me.lblNombreUsuario.AutoSize = True
        Me.lblNombreUsuario.BackColor = System.Drawing.Color.Transparent
        Me.lblNombreUsuario.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblNombreUsuario.Location = New System.Drawing.Point(84, 60)
        Me.lblNombreUsuario.Name = "lblNombreUsuario"
        Me.lblNombreUsuario.Size = New System.Drawing.Size(57, 18)
        Me.lblNombreUsuario.TabIndex = 2
        Me.lblNombreUsuario.Text = "Usuario"
        '
        'btnCerrarSesion
        '
        Me.btnCerrarSesion.BackColor = System.Drawing.SystemColors.Control
        Me.btnCerrarSesion.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnCerrarSesion.Font = New System.Drawing.Font("Garamond", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnCerrarSesion.Location = New System.Drawing.Point(0, 415)
        Me.btnCerrarSesion.Name = "btnCerrarSesion"
        Me.btnCerrarSesion.Size = New System.Drawing.Size(221, 84)
        Me.btnCerrarSesion.TabIndex = 6
        Me.btnCerrarSesion.Text = "Cerrar Sesion"
        Me.btnCerrarSesion.UseVisualStyleBackColor = False
        '
        'btnPlatillos
        '
        Me.btnPlatillos.BackColor = System.Drawing.SystemColors.Control
        Me.btnPlatillos.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnPlatillos.Font = New System.Drawing.Font("Garamond", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnPlatillos.Location = New System.Drawing.Point(0, 331)
        Me.btnPlatillos.Name = "btnPlatillos"
        Me.btnPlatillos.Size = New System.Drawing.Size(221, 84)
        Me.btnPlatillos.TabIndex = 5
        Me.btnPlatillos.Text = "Platillos"
        Me.btnPlatillos.UseVisualStyleBackColor = False
        '
        'btnFactura
        '
        Me.btnFactura.BackColor = System.Drawing.SystemColors.Control
        Me.btnFactura.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnFactura.Font = New System.Drawing.Font("Garamond", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnFactura.Location = New System.Drawing.Point(0, 247)
        Me.btnFactura.Name = "btnFactura"
        Me.btnFactura.Size = New System.Drawing.Size(221, 84)
        Me.btnFactura.TabIndex = 4
        Me.btnFactura.Text = "Facturar"
        Me.btnFactura.UseVisualStyleBackColor = False
        '
        'btnPedidos
        '
        Me.btnPedidos.BackColor = System.Drawing.SystemColors.Control
        Me.btnPedidos.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnPedidos.Font = New System.Drawing.Font("Garamond", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnPedidos.Location = New System.Drawing.Point(0, 163)
        Me.btnPedidos.Name = "btnPedidos"
        Me.btnPedidos.Size = New System.Drawing.Size(221, 84)
        Me.btnPedidos.TabIndex = 3
        Me.btnPedidos.Text = "Inventario"
        Me.btnPedidos.UseVisualStyleBackColor = False
        '
        'pcLogo
        '
        Me.pcLogo.BackColor = System.Drawing.Color.Transparent
        Me.pcLogo.Dock = System.Windows.Forms.DockStyle.Top
        Me.pcLogo.Image = Global.Juan_Piece_RestauranteOtaku.My.Resources.Resources.One_Pice__1__PhotoRoom__1_
        Me.pcLogo.Location = New System.Drawing.Point(0, 0)
        Me.pcLogo.Name = "pcLogo"
        Me.pcLogo.Size = New System.Drawing.Size(221, 163)
        Me.pcLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pcLogo.TabIndex = 0
        Me.pcLogo.TabStop = False
        '
        'pHeading
        '
        Me.pHeading.BackColor = System.Drawing.Color.Gold
        Me.pHeading.Controls.Add(Me.lblHora)
        Me.pHeading.Controls.Add(Me.lblUsuario)
        Me.pHeading.Dock = System.Windows.Forms.DockStyle.Top
        Me.pHeading.Location = New System.Drawing.Point(221, 0)
        Me.pHeading.Name = "pHeading"
        Me.pHeading.Size = New System.Drawing.Size(1149, 123)
        Me.pHeading.TabIndex = 1
        '
        'lblHora
        '
        Me.lblHora.AutoSize = True
        Me.lblHora.Font = New System.Drawing.Font("Garamond", 18.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point)
        Me.lblHora.Location = New System.Drawing.Point(8, 81)
        Me.lblHora.Name = "lblHora"
        Me.lblHora.Size = New System.Drawing.Size(133, 27)
        Me.lblHora.TabIndex = 1
        Me.lblHora.Text = "Fecha Y Hora"
        '
        'lblUsuario
        '
        Me.lblUsuario.AutoSize = True
        Me.lblUsuario.Font = New System.Drawing.Font("Garamond", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblUsuario.Location = New System.Drawing.Point(8, 7)
        Me.lblUsuario.Name = "lblUsuario"
        Me.lblUsuario.Size = New System.Drawing.Size(260, 36)
        Me.lblUsuario.TabIndex = 0
        Me.lblUsuario.Text = "Bienvenido Usuario"
        '
        'PcAnuncio
        '
        Me.PcAnuncio.BackColor = System.Drawing.Color.Transparent
        Me.PcAnuncio.Dock = System.Windows.Forms.DockStyle.Left
        Me.PcAnuncio.Image = Global.Juan_Piece_RestauranteOtaku.My.Resources.Resources.menu__3_
        Me.PcAnuncio.Location = New System.Drawing.Point(0, 0)
        Me.PcAnuncio.Name = "PcAnuncio"
        Me.PcAnuncio.Size = New System.Drawing.Size(352, 364)
        Me.PcAnuncio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PcAnuncio.TabIndex = 2
        Me.PcAnuncio.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox1.Image = Global.Juan_Piece_RestauranteOtaku.My.Resources.Resources.Happy_Hour
        Me.PictureBox1.Location = New System.Drawing.Point(352, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(201, 364)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox2.Image = Global.Juan_Piece_RestauranteOtaku.My.Resources.Resources.RAMEN
        Me.PictureBox2.Location = New System.Drawing.Point(553, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(300, 364)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 4
        Me.PictureBox2.TabStop = False
        '
        'timer
        '
        Me.timer.Enabled = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(221, 711)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1149, 38)
        Me.Panel1.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Garamond", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(233, 33)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nuestros Favoritos"
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.AllowDrop = True
        Me.FlowLayoutPanel1.AutoScroll = True
        Me.FlowLayoutPanel1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(221, 487)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(1149, 224)
        Me.FlowLayoutPanel1.TabIndex = 6
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox3.Image = Global.Juan_Piece_RestauranteOtaku.My.Resources.Resources.menu__5___1_
        Me.PictureBox3.Location = New System.Drawing.Point(853, 0)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(288, 364)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 7
        Me.PictureBox3.TabStop = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Moccasin
        Me.Panel3.Controls.Add(Me.PictureBox3)
        Me.Panel3.Controls.Add(Me.PictureBox2)
        Me.Panel3.Controls.Add(Me.PictureBox1)
        Me.Panel3.Controls.Add(Me.PcAnuncio)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(221, 123)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1149, 364)
        Me.Panel3.TabIndex = 7
        '
        'frInicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.ClientSize = New System.Drawing.Size(1370, 749)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.pHeading)
        Me.Controls.Add(Me.pMenu)
        Me.Font = New System.Drawing.Font("Garamond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frInicio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pagina de Inicio"
        Me.pMenu.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.pcUsuario, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pHeading.ResumeLayout(False)
        Me.pHeading.PerformLayout()
        CType(Me.PcAnuncio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pMenu As Panel
    Friend WithEvents pcLogo As PictureBox
    Friend WithEvents pcUsuario As PictureBox
    Friend WithEvents lblNombreUsuario As Label
    Friend WithEvents pHeading As Panel
    Friend WithEvents lblUsuario As Label
    Friend WithEvents lblHora As Label
    Friend WithEvents btnPedidos As Button
    Friend WithEvents btnFactura As Button
    Friend WithEvents btnCerrarSesion As Button
    Friend WithEvents btnPlatillos As Button
    Friend WithEvents PcAnuncio As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents timer As Timer
    Friend WithEvents Panel1 As Panel
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
End Class
