<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frModificarIngrediente
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frModificarIngrediente))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.cmbNombre = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblCodigo = New System.Windows.Forms.Label()
        Me.gpIngrediente = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.grpPesos = New System.Windows.Forms.GroupBox()
        Me.btnPesos = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtGramos = New System.Windows.Forms.TextBox()
        Me.txtOnzass = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.btnActualizar = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpIngrediente.SuspendLayout()
        Me.grpPesos.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBox1.Image = Global.Juan_Piece_RestauranteOtaku.My.Resources.Resources.One_Pice__1__PhotoRoom__1_
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(895, 83)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'cmbNombre
        '
        Me.cmbNombre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbNombre.FormattingEnabled = True
        Me.cmbNombre.Location = New System.Drawing.Point(32, 142)
        Me.cmbNombre.Name = "cmbNombre"
        Me.cmbNombre.Size = New System.Drawing.Size(316, 23)
        Me.cmbNombre.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Garamond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(33, 109)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(127, 18)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Codigo ingrediente"
        '
        'lblCodigo
        '
        Me.lblCodigo.AutoSize = True
        Me.lblCodigo.Font = New System.Drawing.Font("Garamond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblCodigo.Location = New System.Drawing.Point(186, 109)
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.Size = New System.Drawing.Size(51, 18)
        Me.lblCodigo.TabIndex = 4
        Me.lblCodigo.Text = "Label2"
        '
        'gpIngrediente
        '
        Me.gpIngrediente.Controls.Add(Me.Label2)
        Me.gpIngrediente.Controls.Add(Me.txtNombre)
        Me.gpIngrediente.Controls.Add(Me.grpPesos)
        Me.gpIngrediente.Font = New System.Drawing.Font("Garamond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.gpIngrediente.Location = New System.Drawing.Point(371, 109)
        Me.gpIngrediente.Name = "gpIngrediente"
        Me.gpIngrediente.Size = New System.Drawing.Size(507, 316)
        Me.gpIngrediente.TabIndex = 5
        Me.gpIngrediente.TabStop = False
        Me.gpIngrediente.Text = "Informacion del ingrediente"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Garamond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(26, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(134, 18)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Nombre ingrediente"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(166, 64)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(242, 25)
        Me.txtNombre.TabIndex = 0
        '
        'grpPesos
        '
        Me.grpPesos.Controls.Add(Me.btnPesos)
        Me.grpPesos.Controls.Add(Me.Label4)
        Me.grpPesos.Controls.Add(Me.txtGramos)
        Me.grpPesos.Controls.Add(Me.txtOnzass)
        Me.grpPesos.Controls.Add(Me.Label3)
        Me.grpPesos.Location = New System.Drawing.Point(26, 119)
        Me.grpPesos.Name = "grpPesos"
        Me.grpPesos.Size = New System.Drawing.Size(427, 176)
        Me.grpPesos.TabIndex = 9
        Me.grpPesos.TabStop = False
        Me.grpPesos.Text = "Peso"
        '
        'btnPesos
        '
        Me.btnPesos.Location = New System.Drawing.Point(132, 141)
        Me.btnPesos.Name = "btnPesos"
        Me.btnPesos.Size = New System.Drawing.Size(146, 29)
        Me.btnPesos.TabIndex = 9
        Me.btnPesos.Text = "Calcular Pesos"
        Me.btnPesos.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Garamond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(22, 42)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(92, 18)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Peso Gramos"
        '
        'txtGramos
        '
        Me.txtGramos.Location = New System.Drawing.Point(132, 39)
        Me.txtGramos.Name = "txtGramos"
        Me.txtGramos.Size = New System.Drawing.Size(242, 25)
        Me.txtGramos.TabIndex = 1
        '
        'txtOnzass
        '
        Me.txtOnzass.Location = New System.Drawing.Point(132, 99)
        Me.txtOnzass.Name = "txtOnzass"
        Me.txtOnzass.Size = New System.Drawing.Size(242, 25)
        Me.txtOnzass.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Garamond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(22, 106)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 18)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Peso Onzas"
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Location = New System.Drawing.Point(45, 215)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(146, 50)
        Me.btnLimpiar.TabIndex = 10
        Me.btnLimpiar.Text = "Limpiar "
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'btnActualizar
        '
        Me.btnActualizar.Location = New System.Drawing.Point(45, 298)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(146, 54)
        Me.btnActualizar.TabIndex = 11
        Me.btnActualizar.Text = "Actualizar Informacion"
        Me.btnActualizar.UseVisualStyleBackColor = True
        '
        'frModificarIngrediente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(895, 471)
        Me.Controls.Add(Me.btnActualizar)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.gpIngrediente)
        Me.Controls.Add(Me.lblCodigo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbNombre)
        Me.Controls.Add(Me.PictureBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frModificarIngrediente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Modificar Ingrediente"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpIngrediente.ResumeLayout(False)
        Me.gpIngrediente.PerformLayout()
        Me.grpPesos.ResumeLayout(False)
        Me.grpPesos.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents cmbNombre As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblCodigo As Label
    Friend WithEvents gpIngrediente As GroupBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtGramos As TextBox
    Friend WithEvents txtOnzass As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents grpPesos As GroupBox
    Friend WithEvents btnPesos As Button
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents btnActualizar As Button
End Class
