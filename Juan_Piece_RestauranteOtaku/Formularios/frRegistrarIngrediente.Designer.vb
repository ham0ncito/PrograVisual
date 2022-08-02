<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frRegistrarIngrediente
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frRegistrarIngrediente))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.txtNombreIngrediente = New System.Windows.Forms.TextBox()
        Me.cmbCantidad = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.txtPesoOnz = New System.Windows.Forms.TextBox()
        Me.txtPesoG = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.errorcito = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.errorcito, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBox1.Image = Global.Juan_Piece_RestauranteOtaku.My.Resources.Resources.One_Pice__1__PhotoRoom__1_
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(800, 95)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Garamond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Button1.Location = New System.Drawing.Point(219, 413)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(166, 44)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Agregar "
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Garamond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Button2.Location = New System.Drawing.Point(448, 416)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(166, 41)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Limpiar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'txtNombreIngrediente
        '
        Me.txtNombreIngrediente.Font = New System.Drawing.Font("Garamond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtNombreIngrediente.Location = New System.Drawing.Point(37, 227)
        Me.txtNombreIngrediente.Name = "txtNombreIngrediente"
        Me.txtNombreIngrediente.Size = New System.Drawing.Size(288, 25)
        Me.txtNombreIngrediente.TabIndex = 3
        '
        'cmbCantidad
        '
        Me.cmbCantidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCantidad.Font = New System.Drawing.Font("Garamond", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.cmbCantidad.FormattingEnabled = True
        Me.cmbCantidad.Location = New System.Drawing.Point(37, 299)
        Me.cmbCantidad.Name = "cmbCantidad"
        Me.cmbCantidad.Size = New System.Drawing.Size(157, 29)
        Me.cmbCantidad.TabIndex = 4
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.txtPesoOnz)
        Me.GroupBox1.Controls.Add(Me.txtPesoG)
        Me.GroupBox1.Font = New System.Drawing.Font("Garamond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.GroupBox1.Location = New System.Drawing.Point(401, 139)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(366, 246)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Informacion Peso"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Garamond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(13, 141)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 18)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Peso Onzas"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Garamond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(13, 79)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 18)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Peso Gramos"
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Garamond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Button3.Location = New System.Drawing.Point(121, 187)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(136, 35)
        Me.Button3.TabIndex = 6
        Me.Button3.Text = "Calcular"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'txtPesoOnz
        '
        Me.txtPesoOnz.Font = New System.Drawing.Font("Garamond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtPesoOnz.Location = New System.Drawing.Point(132, 134)
        Me.txtPesoOnz.Name = "txtPesoOnz"
        Me.txtPesoOnz.Size = New System.Drawing.Size(196, 25)
        Me.txtPesoOnz.TabIndex = 1
        '
        'txtPesoG
        '
        Me.txtPesoG.Font = New System.Drawing.Font("Garamond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtPesoG.Location = New System.Drawing.Point(132, 76)
        Me.txtPesoG.Name = "txtPesoG"
        Me.txtPesoG.Size = New System.Drawing.Size(198, 25)
        Me.txtPesoG.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Garamond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(37, 195)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(157, 18)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Nombre del ingrediente"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(37, 272)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(114, 15)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Cantidad Disponible"
        '
        'GroupBox2
        '
        Me.GroupBox2.Location = New System.Drawing.Point(10, 139)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(385, 246)
        Me.GroupBox2.TabIndex = 8
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Informacion General"
        '
        'errorcito
        '
        Me.errorcito.ContainerControl = Me
        '
        'frRegistrarIngrediente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 494)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cmbCantidad)
        Me.Controls.Add(Me.txtNombreIngrediente)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frRegistrarIngrediente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registrar Ingrediente"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.errorcito, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents txtNombreIngrediente As TextBox
    Friend WithEvents cmbCantidad As ComboBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtPesoG As TextBox
    Friend WithEvents txtPesoOnz As TextBox
    Friend WithEvents Button3 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents errorcito As ErrorProvider
End Class
