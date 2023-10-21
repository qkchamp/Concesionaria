<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NuevaFactura
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NuevaFactura))
        Me.LFactura = New System.Windows.Forms.Label()
        Me.FacturaBox = New System.Windows.Forms.TextBox()
        Me.LFecha = New System.Windows.Forms.Label()
        Me.FechaBox = New System.Windows.Forms.TextBox()
        Me.LVendedor = New System.Windows.Forms.Label()
        Me.ImporteBox = New System.Windows.Forms.TextBox()
        Me.LImporte = New System.Windows.Forms.Label()
        Me.BAceptar = New System.Windows.Forms.Button()
        Me.CBVendedor = New System.Windows.Forms.ComboBox()
        Me.FacturaPhoto = New System.Windows.Forms.PictureBox()
        Me.LInfo2 = New System.Windows.Forms.Label()
        CType(Me.FacturaPhoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LFactura
        '
        Me.LFactura.AutoSize = True
        Me.LFactura.Location = New System.Drawing.Point(12, 40)
        Me.LFactura.Name = "LFactura"
        Me.LFactura.Size = New System.Drawing.Size(66, 13)
        Me.LFactura.TabIndex = 0
        Me.LFactura.Text = "Nro. Factura"
        '
        'FacturaBox
        '
        Me.FacturaBox.Location = New System.Drawing.Point(84, 37)
        Me.FacturaBox.Name = "FacturaBox"
        Me.FacturaBox.Size = New System.Drawing.Size(100, 20)
        Me.FacturaBox.TabIndex = 1
        '
        'LFecha
        '
        Me.LFecha.AutoSize = True
        Me.LFecha.Location = New System.Drawing.Point(33, 75)
        Me.LFecha.Name = "LFecha"
        Me.LFecha.Size = New System.Drawing.Size(37, 13)
        Me.LFecha.TabIndex = 2
        Me.LFecha.Text = "Fecha"
        '
        'FechaBox
        '
        Me.FechaBox.Location = New System.Drawing.Point(84, 72)
        Me.FechaBox.Name = "FechaBox"
        Me.FechaBox.ReadOnly = True
        Me.FechaBox.Size = New System.Drawing.Size(100, 20)
        Me.FechaBox.TabIndex = 3
        '
        'LVendedor
        '
        Me.LVendedor.AutoSize = True
        Me.LVendedor.Location = New System.Drawing.Point(27, 111)
        Me.LVendedor.Name = "LVendedor"
        Me.LVendedor.Size = New System.Drawing.Size(53, 13)
        Me.LVendedor.TabIndex = 4
        Me.LVendedor.Text = "Vendedor"
        '
        'ImporteBox
        '
        Me.ImporteBox.Location = New System.Drawing.Point(84, 146)
        Me.ImporteBox.Name = "ImporteBox"
        Me.ImporteBox.Size = New System.Drawing.Size(100, 20)
        Me.ImporteBox.TabIndex = 6
        '
        'LImporte
        '
        Me.LImporte.AutoSize = True
        Me.LImporte.Location = New System.Drawing.Point(31, 147)
        Me.LImporte.Name = "LImporte"
        Me.LImporte.Size = New System.Drawing.Size(42, 13)
        Me.LImporte.TabIndex = 7
        Me.LImporte.Text = "Importe"
        '
        'BAceptar
        '
        Me.BAceptar.Location = New System.Drawing.Point(224, 144)
        Me.BAceptar.Name = "BAceptar"
        Me.BAceptar.Size = New System.Drawing.Size(75, 23)
        Me.BAceptar.TabIndex = 8
        Me.BAceptar.Text = "Emitir"
        Me.BAceptar.UseVisualStyleBackColor = True
        '
        'CBVendedor
        '
        Me.CBVendedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBVendedor.FormattingEnabled = True
        Me.CBVendedor.Location = New System.Drawing.Point(84, 108)
        Me.CBVendedor.Name = "CBVendedor"
        Me.CBVendedor.Size = New System.Drawing.Size(121, 21)
        Me.CBVendedor.TabIndex = 9
        '
        'FacturaPhoto
        '
        Me.FacturaPhoto.Image = Global.Concesionaria.My.Resources.Resources.bill
        Me.FacturaPhoto.Location = New System.Drawing.Point(213, 20)
        Me.FacturaPhoto.Name = "FacturaPhoto"
        Me.FacturaPhoto.Size = New System.Drawing.Size(93, 72)
        Me.FacturaPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.FacturaPhoto.TabIndex = 10
        Me.FacturaPhoto.TabStop = False
        '
        'LInfo2
        '
        Me.LInfo2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LInfo2.Location = New System.Drawing.Point(12, 175)
        Me.LInfo2.Name = "LInfo2"
        Me.LInfo2.Size = New System.Drawing.Size(294, 32)
        Me.LInfo2.TabIndex = 16
        Me.LInfo2.Text = "Atencion: Las facturas emitidas se visualizaran en ""Comisiones por ventas"""
        '
        'NuevaFactura
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Wheat
        Me.ClientSize = New System.Drawing.Size(311, 216)
        Me.Controls.Add(Me.LInfo2)
        Me.Controls.Add(Me.FacturaPhoto)
        Me.Controls.Add(Me.CBVendedor)
        Me.Controls.Add(Me.BAceptar)
        Me.Controls.Add(Me.LImporte)
        Me.Controls.Add(Me.ImporteBox)
        Me.Controls.Add(Me.LVendedor)
        Me.Controls.Add(Me.FechaBox)
        Me.Controls.Add(Me.LFecha)
        Me.Controls.Add(Me.FacturaBox)
        Me.Controls.Add(Me.LFactura)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "NuevaFactura"
        Me.Text = "Nueva Factura"
        CType(Me.FacturaPhoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LFactura As System.Windows.Forms.Label
    Friend WithEvents FacturaBox As System.Windows.Forms.TextBox
    Friend WithEvents LFecha As System.Windows.Forms.Label
    Friend WithEvents FechaBox As System.Windows.Forms.TextBox
    Friend WithEvents LVendedor As System.Windows.Forms.Label
    Friend WithEvents ImporteBox As System.Windows.Forms.TextBox
    Friend WithEvents LImporte As System.Windows.Forms.Label
    Friend WithEvents BAceptar As System.Windows.Forms.Button
    Friend WithEvents CBVendedor As System.Windows.Forms.ComboBox
    Friend WithEvents FacturaPhoto As System.Windows.Forms.PictureBox
    Friend WithEvents LInfo2 As System.Windows.Forms.Label
End Class
