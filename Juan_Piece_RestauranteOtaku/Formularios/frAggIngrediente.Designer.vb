<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frAggIngrediente
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frAggIngrediente))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.cmbPlatilo = New System.Windows.Forms.ComboBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.pcImagen = New System.Windows.Forms.PictureBox()
        Me.bllDescripcion = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcImagen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.PictureBox1.BackgroundImage = Global.Juan_Piece_RestauranteOtaku.My.Resources.Resources.One_Pice__1__PhotoRoom__1_
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBox1.Image = Global.Juan_Piece_RestauranteOtaku.My.Resources.Resources.One_Pice__1__PhotoRoom__1_
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(904, 83)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'cmbPlatilo
        '
        Me.cmbPlatilo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPlatilo.FormattingEnabled = True
        Me.cmbPlatilo.Location = New System.Drawing.Point(45, 164)
        Me.cmbPlatilo.Name = "cmbPlatilo"
        Me.cmbPlatilo.Size = New System.Drawing.Size(358, 23)
        Me.cmbPlatilo.TabIndex = 2
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(492, 164)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(358, 23)
        Me.ComboBox1.TabIndex = 3
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(634, 230)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(161, 23)
        Me.ComboBox2.TabIndex = 4
        '
        'pcImagen
        '
        Me.pcImagen.Image = Global.Juan_Piece_RestauranteOtaku.My.Resources.Resources.Presione_el_boton_de_escanear__2_
        Me.pcImagen.Location = New System.Drawing.Point(45, 212)
        Me.pcImagen.Name = "pcImagen"
        Me.pcImagen.Size = New System.Drawing.Size(358, 209)
        Me.pcImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pcImagen.TabIndex = 5
        Me.pcImagen.TabStop = False
        '
        'bllDescripcion
        '
        Me.bllDescripcion.Location = New System.Drawing.Point(49, 424)
        Me.bllDescripcion.Name = "bllDescripcion"
        Me.bllDescripcion.Size = New System.Drawing.Size(354, 77)
        Me.bllDescripcion.TabIndex = 6
        Me.bllDescripcion.Text = "Descripcion"
        Me.bllDescripcion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(596, 376)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(150, 36)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Agregar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(634, 290)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(161, 23)
        Me.TextBox1.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Garamond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(492, 133)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(134, 18)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Nombre ingrediente"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(45, 135)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 15)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Nombre Platillo"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Garamond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(492, 233)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(110, 18)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Cantidad de uso"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Garamond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(492, 298)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 18)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Peso"
        '
        'frAggIngrediente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(904, 523)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.bllDescripcion)
        Me.Controls.Add(Me.pcImagen)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.cmbPlatilo)
        Me.Controls.Add(Me.PictureBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frAggIngrediente"
        Me.Text = "Agregar ingredientes a un Platillo"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcImagen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents cmbPlatilo As ComboBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents pcImagen As PictureBox
    Friend WithEvents bllDescripcion As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class
