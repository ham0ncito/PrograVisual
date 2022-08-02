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
        Me.cmbNombreIngrediente = New System.Windows.Forms.ComboBox()
        Me.cmbCantidadUso = New System.Windows.Forms.ComboBox()
        Me.pcImagen = New System.Windows.Forms.PictureBox()
        Me.bllDescripcion = New System.Windows.Forms.Label()
        Me.btnAgg = New System.Windows.Forms.Button()
        Me.txtPeso = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblCodigo = New System.Windows.Forms.Label()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcImagen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
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
        Me.cmbPlatilo.Font = New System.Drawing.Font("Garamond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.cmbPlatilo.FormattingEnabled = True
        Me.cmbPlatilo.Location = New System.Drawing.Point(45, 164)
        Me.cmbPlatilo.Name = "cmbPlatilo"
        Me.cmbPlatilo.Size = New System.Drawing.Size(358, 26)
        Me.cmbPlatilo.TabIndex = 2
        '
        'cmbNombreIngrediente
        '
        Me.cmbNombreIngrediente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbNombreIngrediente.Font = New System.Drawing.Font("Garamond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.cmbNombreIngrediente.FormattingEnabled = True
        Me.cmbNombreIngrediente.Location = New System.Drawing.Point(27, 72)
        Me.cmbNombreIngrediente.Name = "cmbNombreIngrediente"
        Me.cmbNombreIngrediente.Size = New System.Drawing.Size(358, 26)
        Me.cmbNombreIngrediente.TabIndex = 3
        '
        'cmbCantidadUso
        '
        Me.cmbCantidadUso.FormattingEnabled = True
        Me.cmbCantidadUso.Location = New System.Drawing.Point(169, 138)
        Me.cmbCantidadUso.Name = "cmbCantidadUso"
        Me.cmbCantidadUso.Size = New System.Drawing.Size(161, 23)
        Me.cmbCantidadUso.TabIndex = 4
        '
        'pcImagen
        '
        Me.pcImagen.Image = Global.Juan_Piece_RestauranteOtaku.My.Resources.Resources.Presione_el_boton_de_escanear__2_
        Me.pcImagen.Location = New System.Drawing.Point(71, 212)
        Me.pcImagen.Name = "pcImagen"
        Me.pcImagen.Size = New System.Drawing.Size(312, 162)
        Me.pcImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pcImagen.TabIndex = 5
        Me.pcImagen.TabStop = False
        '
        'bllDescripcion
        '
        Me.bllDescripcion.Font = New System.Drawing.Font("Garamond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.bllDescripcion.Location = New System.Drawing.Point(49, 394)
        Me.bllDescripcion.Name = "bllDescripcion"
        Me.bllDescripcion.Size = New System.Drawing.Size(354, 77)
        Me.bllDescripcion.TabIndex = 6
        Me.bllDescripcion.Text = "Descripcion"
        Me.bllDescripcion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnAgg
        '
        Me.btnAgg.Location = New System.Drawing.Point(465, 494)
        Me.btnAgg.Name = "btnAgg"
        Me.btnAgg.Size = New System.Drawing.Size(150, 36)
        Me.btnAgg.TabIndex = 7
        Me.btnAgg.Text = "Agregar"
        Me.btnAgg.UseVisualStyleBackColor = True
        '
        'txtPeso
        '
        Me.txtPeso.Location = New System.Drawing.Point(169, 198)
        Me.txtPeso.Name = "txtPeso"
        Me.txtPeso.Size = New System.Drawing.Size(161, 23)
        Me.txtPeso.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Garamond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(27, 41)
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
        Me.Label3.Location = New System.Drawing.Point(27, 141)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(110, 18)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Cantidad de uso"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Garamond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(27, 206)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(106, 18)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Peso en gramos"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblCodigo)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.cmbNombreIngrediente)
        Me.GroupBox1.Controls.Add(Me.cmbCantidadUso)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtPeso)
        Me.GroupBox1.Location = New System.Drawing.Point(465, 148)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(409, 304)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos Ingrediente"
        '
        'lblCodigo
        '
        Me.lblCodigo.AutoSize = True
        Me.lblCodigo.Font = New System.Drawing.Font("Garamond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblCodigo.ForeColor = System.Drawing.Color.OrangeRed
        Me.lblCodigo.Location = New System.Drawing.Point(310, 41)
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.Size = New System.Drawing.Size(53, 18)
        Me.lblCodigo.TabIndex = 14
        Me.lblCodigo.Text = "Codigo"
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Location = New System.Drawing.Point(273, 494)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(150, 36)
        Me.btnLimpiar.TabIndex = 15
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Garamond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label5.ForeColor = System.Drawing.Color.OrangeRed
        Me.Label5.Location = New System.Drawing.Point(350, 135)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 18)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Codigo"
        '
        'frAggIngrediente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(904, 542)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnAgg)
        Me.Controls.Add(Me.bllDescripcion)
        Me.Controls.Add(Me.pcImagen)
        Me.Controls.Add(Me.cmbPlatilo)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frAggIngrediente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Agregar ingredientes a un Platillo"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcImagen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents cmbPlatilo As ComboBox
    Friend WithEvents cmbNombreIngrediente As ComboBox
    Friend WithEvents cmbCantidadUso As ComboBox
    Friend WithEvents pcImagen As PictureBox
    Friend WithEvents bllDescripcion As Label
    Friend WithEvents btnAgg As Button
    Friend WithEvents txtPeso As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblCodigo As Label
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents Label5 As Label
End Class
