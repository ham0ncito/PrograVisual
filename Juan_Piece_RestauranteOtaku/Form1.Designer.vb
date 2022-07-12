<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.pMenu = New System.Windows.Forms.Panel()
        Me.btnCerrarSesion = New System.Windows.Forms.Button()
        Me.btnPlatillos = New System.Windows.Forms.Button()
        Me.btnFactura = New System.Windows.Forms.Button()
        Me.btnPedidos = New System.Windows.Forms.Button()
        Me.lblNombreUsuario = New System.Windows.Forms.Label()
        Me.pcUsuario = New System.Windows.Forms.PictureBox()
        Me.pcLogo = New System.Windows.Forms.PictureBox()
        Me.pHeading = New System.Windows.Forms.Panel()
        Me.lblHora = New System.Windows.Forms.Label()
        Me.lblUsuario = New System.Windows.Forms.Label()
        Me.PcAnuncio = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.timer = New System.Windows.Forms.Timer(Me.components)
        Me.pMenu.SuspendLayout()
        CType(Me.pcUsuario, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pHeading.SuspendLayout()
        CType(Me.PcAnuncio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pMenu
        '
        Me.pMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(9, Byte), Integer), CType(CType(9, Byte), Integer))
        Me.pMenu.Controls.Add(Me.btnCerrarSesion)
        Me.pMenu.Controls.Add(Me.btnPlatillos)
        Me.pMenu.Controls.Add(Me.btnFactura)
        Me.pMenu.Controls.Add(Me.btnPedidos)
        Me.pMenu.Controls.Add(Me.lblNombreUsuario)
        Me.pMenu.Controls.Add(Me.pcUsuario)
        Me.pMenu.Controls.Add(Me.pcLogo)
        Me.pMenu.Location = New System.Drawing.Point(1, 1)
        Me.pMenu.Margin = New System.Windows.Forms.Padding(4)
        Me.pMenu.Name = "pMenu"
        Me.pMenu.Size = New System.Drawing.Size(221, 620)
        Me.pMenu.TabIndex = 0
        '
        'btnCerrarSesion
        '
        Me.btnCerrarSesion.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnCerrarSesion.Font = New System.Drawing.Font("Garamond", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnCerrarSesion.Location = New System.Drawing.Point(0, 415)
        Me.btnCerrarSesion.Name = "btnCerrarSesion"
        Me.btnCerrarSesion.Size = New System.Drawing.Size(221, 84)
        Me.btnCerrarSesion.TabIndex = 6
        Me.btnCerrarSesion.Text = "Cerrar Sesion"
        Me.btnCerrarSesion.UseVisualStyleBackColor = True
        '
        'btnPlatillos
        '
        Me.btnPlatillos.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnPlatillos.Font = New System.Drawing.Font("Garamond", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnPlatillos.Location = New System.Drawing.Point(0, 331)
        Me.btnPlatillos.Name = "btnPlatillos"
        Me.btnPlatillos.Size = New System.Drawing.Size(221, 84)
        Me.btnPlatillos.TabIndex = 5
        Me.btnPlatillos.Text = "Platillos"
        Me.btnPlatillos.UseVisualStyleBackColor = True
        '
        'btnFactura
        '
        Me.btnFactura.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnFactura.Font = New System.Drawing.Font("Garamond", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnFactura.Location = New System.Drawing.Point(0, 247)
        Me.btnFactura.Name = "btnFactura"
        Me.btnFactura.Size = New System.Drawing.Size(221, 84)
        Me.btnFactura.TabIndex = 4
        Me.btnFactura.Text = "Factura"
        Me.btnFactura.UseVisualStyleBackColor = True
        '
        'btnPedidos
        '
        Me.btnPedidos.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnPedidos.Font = New System.Drawing.Font("Garamond", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnPedidos.Location = New System.Drawing.Point(0, 163)
        Me.btnPedidos.Name = "btnPedidos"
        Me.btnPedidos.Size = New System.Drawing.Size(221, 84)
        Me.btnPedidos.TabIndex = 3
        Me.btnPedidos.Text = "Pedidos"
        Me.btnPedidos.UseVisualStyleBackColor = True
        '
        'lblNombreUsuario
        '
        Me.lblNombreUsuario.AutoSize = True
        Me.lblNombreUsuario.BackColor = System.Drawing.Color.Transparent
        Me.lblNombreUsuario.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblNombreUsuario.Location = New System.Drawing.Point(83, 562)
        Me.lblNombreUsuario.Name = "lblNombreUsuario"
        Me.lblNombreUsuario.Size = New System.Drawing.Size(57, 18)
        Me.lblNombreUsuario.TabIndex = 2
        Me.lblNombreUsuario.Text = "Usuario"
        '
        'pcUsuario
        '
        Me.pcUsuario.BackColor = System.Drawing.Color.Transparent
        Me.pcUsuario.Image = CType(resources.GetObject("pcUsuario.Image"), System.Drawing.Image)
        Me.pcUsuario.Location = New System.Drawing.Point(11, 547)
        Me.pcUsuario.Name = "pcUsuario"
        Me.pcUsuario.Size = New System.Drawing.Size(66, 48)
        Me.pcUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pcUsuario.TabIndex = 1
        Me.pcUsuario.TabStop = False
        '
        'pcLogo
        '
        Me.pcLogo.BackColor = System.Drawing.Color.Transparent
        Me.pcLogo.Dock = System.Windows.Forms.DockStyle.Top
        Me.pcLogo.Image = CType(resources.GetObject("pcLogo.Image"), System.Drawing.Image)
        Me.pcLogo.Location = New System.Drawing.Point(0, 0)
        Me.pcLogo.Name = "pcLogo"
        Me.pcLogo.Size = New System.Drawing.Size(221, 163)
        Me.pcLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pcLogo.TabIndex = 0
        Me.pcLogo.TabStop = False
        '
        'pHeading
        '
        Me.pHeading.BackColor = System.Drawing.Color.WhiteSmoke
        Me.pHeading.Controls.Add(Me.lblHora)
        Me.pHeading.Controls.Add(Me.lblUsuario)
        Me.pHeading.Location = New System.Drawing.Point(221, 2)
        Me.pHeading.Name = "pHeading"
        Me.pHeading.Size = New System.Drawing.Size(872, 123)
        Me.pHeading.TabIndex = 1
        '
        'lblHora
        '
        Me.lblHora.AutoSize = True
        Me.lblHora.Font = New System.Drawing.Font("Garamond", 24.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point)
        Me.lblHora.Location = New System.Drawing.Point(496, 45)
        Me.lblHora.Name = "lblHora"
        Me.lblHora.Size = New System.Drawing.Size(173, 36)
        Me.lblHora.TabIndex = 1
        Me.lblHora.Text = "Fecha Y Hora"
        '
        'lblUsuario
        '
        Me.lblUsuario.AutoSize = True
        Me.lblUsuario.Font = New System.Drawing.Font("Garamond", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblUsuario.Location = New System.Drawing.Point(26, 32)
        Me.lblUsuario.Name = "lblUsuario"
        Me.lblUsuario.Size = New System.Drawing.Size(393, 54)
        Me.lblUsuario.TabIndex = 0
        Me.lblUsuario.Text = "Bienvenido Usuario"
        '
        'PcAnuncio
        '
        Me.PcAnuncio.BackColor = System.Drawing.Color.Transparent
        Me.PcAnuncio.Image = CType(resources.GetObject("PcAnuncio.Image"), System.Drawing.Image)
        Me.PcAnuncio.Location = New System.Drawing.Point(229, 131)
        Me.PcAnuncio.Name = "PcAnuncio"
        Me.PcAnuncio.Size = New System.Drawing.Size(344, 369)
        Me.PcAnuncio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PcAnuncio.TabIndex = 2
        Me.PcAnuncio.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(579, 131)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(224, 369)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(798, 131)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(293, 369)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 4
        Me.PictureBox2.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Location = New System.Drawing.Point(221, 509)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(872, 96)
        Me.Panel1.TabIndex = 5
        '
        'timer
        '
        Me.timer.Enabled = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.ClientSize = New System.Drawing.Size(1092, 617)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PcAnuncio)
        Me.Controls.Add(Me.pHeading)
        Me.Controls.Add(Me.pMenu)
        Me.Font = New System.Drawing.Font("Garamond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pagina de Inicio"
        Me.pMenu.ResumeLayout(False)
        Me.pMenu.PerformLayout()
        CType(Me.pcUsuario, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pHeading.ResumeLayout(False)
        Me.pHeading.PerformLayout()
        CType(Me.PcAnuncio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents Panel1 As Panel
    Friend WithEvents timer As Timer
End Class
