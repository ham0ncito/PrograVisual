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
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.lblContrasena = New System.Windows.Forms.Label()
        Me.lblNombreUsuario = New System.Windows.Forms.Label()
        Me.btnLogOut = New System.Windows.Forms.Button()
        Me.btnRecuperar = New System.Windows.Forms.Button()
        Me.btnlog = New System.Windows.Forms.Button()
        Me.pBotones = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.gbDatos.SuspendLayout()
        Me.Panel1.SuspendLayout()
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
        Me.gbDatos.Size = New System.Drawing.Size(422, 142)
        Me.gbDatos.TabIndex = 0
        Me.gbDatos.TabStop = False
        Me.gbDatos.Text = "Ingrese sus datos para continuar"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(158, 86)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBox2.Size = New System.Drawing.Size(215, 25)
        Me.TextBox2.TabIndex = 3
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(158, 38)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(215, 25)
        Me.TextBox1.TabIndex = 2
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
        'lblNombreUsuario
        '
        Me.lblNombreUsuario.AutoSize = True
        Me.lblNombreUsuario.Location = New System.Drawing.Point(25, 38)
        Me.lblNombreUsuario.Name = "lblNombreUsuario"
        Me.lblNombreUsuario.Size = New System.Drawing.Size(71, 18)
        Me.lblNombreUsuario.TabIndex = 0
        Me.lblNombreUsuario.Text = "Username"
        '
        'btnLogOut
        '
        Me.btnLogOut.BackColor = System.Drawing.Color.LightGray
        Me.btnLogOut.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnLogOut.Location = New System.Drawing.Point(226, 0)
        Me.btnLogOut.Name = "btnLogOut"
        Me.btnLogOut.Size = New System.Drawing.Size(113, 59)
        Me.btnLogOut.TabIndex = 1
        Me.btnLogOut.Text = "Log Me Out"
        Me.btnLogOut.UseVisualStyleBackColor = False
        '
        'btnRecuperar
        '
        Me.btnRecuperar.BackColor = System.Drawing.Color.LightGray
        Me.btnRecuperar.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnRecuperar.Location = New System.Drawing.Point(0, 0)
        Me.btnRecuperar.Name = "btnRecuperar"
        Me.btnRecuperar.Size = New System.Drawing.Size(113, 59)
        Me.btnRecuperar.TabIndex = 2
        Me.btnRecuperar.Text = "Olvide mi contraseña"
        Me.btnRecuperar.UseVisualStyleBackColor = False
        '
        'btnlog
        '
        Me.btnlog.BackColor = System.Drawing.Color.LightGray
        Me.btnlog.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnlog.Location = New System.Drawing.Point(113, 0)
        Me.btnlog.Name = "btnlog"
        Me.btnlog.Size = New System.Drawing.Size(113, 59)
        Me.btnlog.TabIndex = 3
        Me.btnlog.Text = "Log In"
        Me.btnlog.UseVisualStyleBackColor = False
        '
        'pBotones
        '
        Me.pBotones.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(12, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.pBotones.BackgroundImage = Global.Juan_Piece_RestauranteOtaku.My.Resources.Resources.Login
        Me.pBotones.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pBotones.Location = New System.Drawing.Point(0, -3)
        Me.pBotones.Name = "pBotones"
        Me.pBotones.Size = New System.Drawing.Size(149, 349)
        Me.pBotones.TabIndex = 4
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnLogOut)
        Me.Panel1.Controls.Add(Me.btnlog)
        Me.Panel1.Controls.Add(Me.btnRecuperar)
        Me.Panel1.Location = New System.Drawing.Point(189, 248)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(339, 59)
        Me.Panel1.TabIndex = 5
        '
        'frLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(580, 330)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.pBotones)
        Me.Controls.Add(Me.gbDatos)
        Me.Font = New System.Drawing.Font("Garamond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Juan Piece Login"
        Me.gbDatos.ResumeLayout(False)
        Me.gbDatos.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gbDatos As GroupBox
    Friend WithEvents btnLogOut As Button
    Friend WithEvents lblNombreUsuario As Label
    Friend WithEvents lblContrasena As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents btnRecuperar As Button
    Friend WithEvents btnlog As Button
    Friend WithEvents pBotones As Panel
    Friend WithEvents Panel1 As Panel
End Class
