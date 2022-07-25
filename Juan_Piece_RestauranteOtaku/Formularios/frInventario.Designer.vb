<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frInventario
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frInventario))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.btnElim = New System.Windows.Forms.Button()
        Me.btnReporte = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnMod = New System.Windows.Forms.Button()
        Me.btnag = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblHora = New System.Windows.Forms.Label()
        Me.dgInventario = New System.Windows.Forms.DataGridView()
        Me.Tiempo = New System.Windows.Forms.Timer(Me.components)
        Me.Imprimir = New System.Drawing.Printing.PrintDocument()
        Me.ImprimirPreview = New System.Windows.Forms.PrintPreviewDialog()
        Me.lblListadoingredientes = New System.Windows.Forms.Label()
        Me.dgIngresos = New System.Windows.Forms.DataGridView()
        Me.lblIngresos = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.dgInventario, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgIngresos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.btnElim)
        Me.Panel1.Controls.Add(Me.btnReporte)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.btnMod)
        Me.Panel1.Controls.Add(Me.btnag)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1350, 90)
        Me.Panel1.TabIndex = 0
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Button3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Button3.Font = New System.Drawing.Font("Garamond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Button3.Location = New System.Drawing.Point(912, 0)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(143, 90)
        Me.Button3.TabIndex = 6
        Me.Button3.Text = "Eliminar Ingredientes"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'btnElim
        '
        Me.btnElim.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnElim.Font = New System.Drawing.Font("Garamond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnElim.Location = New System.Drawing.Point(1055, 0)
        Me.btnElim.Name = "btnElim"
        Me.btnElim.Size = New System.Drawing.Size(151, 90)
        Me.btnElim.TabIndex = 5
        Me.btnElim.Text = "Salir"
        Me.btnElim.UseVisualStyleBackColor = False
        '
        'btnReporte
        '
        Me.btnReporte.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnReporte.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnReporte.Font = New System.Drawing.Font("Garamond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnReporte.Location = New System.Drawing.Point(769, 0)
        Me.btnReporte.Name = "btnReporte"
        Me.btnReporte.Size = New System.Drawing.Size(143, 90)
        Me.btnReporte.TabIndex = 4
        Me.btnReporte.Text = "Reporte Ingredientes"
        Me.btnReporte.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox1.Image = Global.Juan_Piece_RestauranteOtaku.My.Resources.Resources.One_Pice__1__PhotoRoom__1_
        Me.PictureBox1.Location = New System.Drawing.Point(565, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(204, 90)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'btnMod
        '
        Me.btnMod.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnMod.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnMod.Font = New System.Drawing.Font("Garamond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnMod.Location = New System.Drawing.Point(422, 0)
        Me.btnMod.Name = "btnMod"
        Me.btnMod.Size = New System.Drawing.Size(143, 90)
        Me.btnMod.TabIndex = 2
        Me.btnMod.Text = "Modificar Ingrediente"
        Me.btnMod.UseVisualStyleBackColor = False
        '
        'btnag
        '
        Me.btnag.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnag.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnag.Font = New System.Drawing.Font("Garamond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnag.Location = New System.Drawing.Point(279, 0)
        Me.btnag.Name = "btnag"
        Me.btnag.Size = New System.Drawing.Size(143, 90)
        Me.btnag.TabIndex = 1
        Me.btnag.Text = "Agregar Ingrediente"
        Me.btnag.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.lblHora)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(279, 90)
        Me.Panel2.TabIndex = 0
        '
        'lblHora
        '
        Me.lblHora.AutoSize = True
        Me.lblHora.Font = New System.Drawing.Font("Garamond", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblHora.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lblHora.Location = New System.Drawing.Point(21, 34)
        Me.lblHora.Name = "lblHora"
        Me.lblHora.Size = New System.Drawing.Size(44, 21)
        Me.lblHora.TabIndex = 0
        Me.lblHora.Text = "hora"
        '
        'dgInventario
        '
        Me.dgInventario.AllowDrop = True
        Me.dgInventario.AllowUserToAddRows = False
        Me.dgInventario.AllowUserToDeleteRows = False
        Me.dgInventario.AllowUserToResizeColumns = False
        Me.dgInventario.AllowUserToResizeRows = False
        Me.dgInventario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgInventario.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.dgInventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgInventario.GridColor = System.Drawing.Color.Black
        Me.dgInventario.Location = New System.Drawing.Point(12, 128)
        Me.dgInventario.Name = "dgInventario"
        Me.dgInventario.ReadOnly = True
        Me.dgInventario.RowTemplate.Height = 25
        Me.dgInventario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgInventario.Size = New System.Drawing.Size(690, 545)
        Me.dgInventario.TabIndex = 2
        '
        'Tiempo
        '
        Me.Tiempo.Enabled = True
        '
        'ImprimirPreview
        '
        Me.ImprimirPreview.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.ImprimirPreview.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.ImprimirPreview.ClientSize = New System.Drawing.Size(400, 300)
        Me.ImprimirPreview.Enabled = True
        Me.ImprimirPreview.Icon = CType(resources.GetObject("ImprimirPreview.Icon"), System.Drawing.Icon)
        Me.ImprimirPreview.Name = "ImprimirPreview"
        Me.ImprimirPreview.Visible = False
        '
        'lblListadoingredientes
        '
        Me.lblListadoingredientes.AutoSize = True
        Me.lblListadoingredientes.Font = New System.Drawing.Font("Garamond", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblListadoingredientes.ForeColor = System.Drawing.Color.DarkOrange
        Me.lblListadoingredientes.Location = New System.Drawing.Point(12, 101)
        Me.lblListadoingredientes.Name = "lblListadoingredientes"
        Me.lblListadoingredientes.Size = New System.Drawing.Size(166, 24)
        Me.lblListadoingredientes.TabIndex = 3
        Me.lblListadoingredientes.Text = "Inventario Actual"
        '
        'dgIngresos
        '
        Me.dgIngresos.AllowDrop = True
        Me.dgIngresos.AllowUserToAddRows = False
        Me.dgIngresos.AllowUserToDeleteRows = False
        Me.dgIngresos.AllowUserToResizeColumns = False
        Me.dgIngresos.AllowUserToResizeRows = False
        Me.dgIngresos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgIngresos.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.dgIngresos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgIngresos.GridColor = System.Drawing.Color.Black
        Me.dgIngresos.Location = New System.Drawing.Point(717, 128)
        Me.dgIngresos.Name = "dgIngresos"
        Me.dgIngresos.ReadOnly = True
        Me.dgIngresos.RowTemplate.Height = 25
        Me.dgIngresos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgIngresos.Size = New System.Drawing.Size(621, 545)
        Me.dgIngresos.TabIndex = 4
        '
        'lblIngresos
        '
        Me.lblIngresos.AutoSize = True
        Me.lblIngresos.Font = New System.Drawing.Font("Garamond", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblIngresos.ForeColor = System.Drawing.Color.DarkOrange
        Me.lblIngresos.Location = New System.Drawing.Point(717, 101)
        Me.lblIngresos.Name = "lblIngresos"
        Me.lblIngresos.Size = New System.Drawing.Size(163, 24)
        Me.lblIngresos.TabIndex = 5
        Me.lblIngresos.Text = "Ultimos Ingresos"
        '
        'frInventario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1350, 687)
        Me.Controls.Add(Me.lblIngresos)
        Me.Controls.Add(Me.dgIngresos)
        Me.Controls.Add(Me.lblListadoingredientes)
        Me.Controls.Add(Me.dgInventario)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frInventario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Inventario"
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.dgInventario, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgIngresos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnag As Button
    Friend WithEvents btnMod As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnElim As Button
    Friend WithEvents btnReporte As Button
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewImageColumn
    Friend WithEvents dgInventario As DataGridView
    Friend WithEvents lblHora As Label
    Friend WithEvents Tiempo As Timer
    Friend WithEvents Imprimir As Printing.PrintDocument
    Friend WithEvents ImprimirPreview As PrintPreviewDialog
    Friend WithEvents Button3 As Button
    Friend WithEvents lblListadoingredientes As Label
    Friend WithEvents dgIngresos As DataGridView
    Friend WithEvents lblIngresos As Label
End Class
