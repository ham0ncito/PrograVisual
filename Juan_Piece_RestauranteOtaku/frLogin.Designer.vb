<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frLogin))
        Me.gbDatos = New System.Windows.Forms.GroupBox()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.lblNombreUsuario = New System.Windows.Forms.Label()
        Me.lblContrasena = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.btnBorrarDatos = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.pBotones = New System.Windows.Forms.Panel()
        Me.gbDatos.SuspendLayout()
        Me.pBotones.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbDatos
        '
        Me.gbDatos.BackColor = System.Drawing.Color.Transparent
        Me.gbDatos.Controls.Add(Me.TextBox2)
        Me.gbDatos.Controls.Add(Me.TextBox1)
        Me.gbDatos.Controls.Add(Me.lblContrasena)
        Me.gbDatos.Controls.Add(Me.lblNombreUsuario)
        Me.gbDatos.ForeColor = System.Drawing.Color.White
        Me.gbDatos.Location = New System.Drawing.Point(155, 75)
        Me.gbDatos.Name = "gbDatos"
        Me.gbDatos.Size = New System.Drawing.Size(395, 142)
        Me.gbDatos.TabIndex = 0
        Me.gbDatos.TabStop = False
        Me.gbDatos.Text = "Ingrese sus datos para continuar"
        '
        'btnLogin
        '
        Me.btnLogin.BackColor = System.Drawing.Color.Transparent
        Me.btnLogin.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnLogin.Location = New System.Drawing.Point(0, 33)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(150, 33)
        Me.btnLogin.TabIndex = 1
        Me.btnLogin.Text = "Button1"
        Me.btnLogin.UseVisualStyleBackColor = False
        '
        'lblNombreUsuario
        '
        Me.lblNombreUsuario.AutoSize = True
        Me.lblNombreUsuario.Location = New System.Drawing.Point(25, 38)
        Me.lblNombreUsuario.Name = "lblNombreUsuario"
        Me.lblNombreUsuario.Size = New System.Drawing.Size(71, 18)
        Me.lblNombreUsuario.TabIndex = 0
        Me.lblNombreUsuario.Text = "Username"
        '
        'lblContrasena
        '
        Me.lblContrasena.AutoSize = True
        Me.lblContrasena.Location = New System.Drawing.Point(25, 86)
        Me.lblContrasena.Name = "lblContrasena"
        Me.lblContrasena.Size = New System.Drawing.Size(79, 18)
        Me.lblContrasena.TabIndex = 1
        Me.lblContrasena.Text = "Contraseña"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(158, 38)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(215, 25)
        Me.TextBox1.TabIndex = 2
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(158, 86)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(215, 25)
        Me.TextBox2.TabIndex = 3
        '
        'btnBorrarDatos
        '
        Me.btnBorrarDatos.BackColor = System.Drawing.Color.Transparent
        Me.btnBorrarDatos.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnBorrarDatos.Location = New System.Drawing.Point(0, 66)
        Me.btnBorrarDatos.Name = "btnBorrarDatos"
        Me.btnBorrarDatos.Size = New System.Drawing.Size(150, 42)
        Me.btnBorrarDatos.TabIndex = 2
        Me.btnBorrarDatos.Text = "Button2"
        Me.btnBorrarDatos.UseVisualStyleBackColor = False
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.Color.Transparent
        Me.btnSalir.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnSalir.Location = New System.Drawing.Point(0, 0)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(150, 33)
        Me.btnSalir.TabIndex = 3
        Me.btnSalir.Text = "Button3"
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'pBotones
        '
        Me.pBotones.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(12, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.pBotones.Controls.Add(Me.btnBorrarDatos)
        Me.pBotones.Controls.Add(Me.btnLogin)
        Me.pBotones.Controls.Add(Me.btnSalir)
        Me.pBotones.Location = New System.Drawing.Point(-1, 0)
        Me.pBotones.Name = "pBotones"
        Me.pBotones.Size = New System.Drawing.Size(150, 337)
        Me.pBotones.TabIndex = 4
        '
        'frLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(580, 330)
        Me.Controls.Add(Me.pBotones)
        Me.Controls.Add(Me.gbDatos)
        Me.Font = New System.Drawing.Font("Garamond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frLogin"
        Me.Text = "Login Juan Piece"
        Me.gbDatos.ResumeLayout(False)
        Me.gbDatos.PerformLayout()
        Me.pBotones.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gbDatos As GroupBox
    Friend WithEvents btnLogin As Button
    Friend WithEvents lblNombreUsuario As Label
    Friend WithEvents lblContrasena As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents btnBorrarDatos As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents pBotones As Panel
End Class
