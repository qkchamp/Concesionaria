<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NuevoVendedor
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NuevoVendedor))
        Me.BAceptar = New System.Windows.Forms.Button()
        Me.LComision = New System.Windows.Forms.Label()
        Me.ComisionBox = New System.Windows.Forms.TextBox()
        Me.NombreBox = New System.Windows.Forms.TextBox()
        Me.LNombre = New System.Windows.Forms.Label()
        Me.VendedorBox = New System.Windows.Forms.TextBox()
        Me.LVendedor = New System.Windows.Forms.Label()
        Me.LInfo = New System.Windows.Forms.Label()
        Me.VendedorPhoto = New System.Windows.Forms.PictureBox()
        Me.BLista = New System.Windows.Forms.Button()
        CType(Me.VendedorPhoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BAceptar
        '
        Me.BAceptar.Location = New System.Drawing.Point(260, 195)
        Me.BAceptar.Name = "BAceptar"
        Me.BAceptar.Size = New System.Drawing.Size(75, 23)
        Me.BAceptar.TabIndex = 13
        Me.BAceptar.Text = "Cargar"
        Me.BAceptar.UseVisualStyleBackColor = True
        '
        'LComision
        '
        Me.LComision.AutoSize = True
        Me.LComision.Location = New System.Drawing.Point(11, 154)
        Me.LComision.Name = "LComision"
        Me.LComision.Size = New System.Drawing.Size(49, 13)
        Me.LComision.TabIndex = 12
        Me.LComision.Text = "Comision"
        '
        'ComisionBox
        '
        Me.ComisionBox.Location = New System.Drawing.Point(63, 151)
        Me.ComisionBox.MaxLength = 2
        Me.ComisionBox.Name = "ComisionBox"
        Me.ComisionBox.Size = New System.Drawing.Size(273, 20)
        Me.ComisionBox.TabIndex = 11
        '
        'NombreBox
        '
        Me.NombreBox.Location = New System.Drawing.Point(63, 100)
        Me.NombreBox.Name = "NombreBox"
        Me.NombreBox.Size = New System.Drawing.Size(273, 20)
        Me.NombreBox.TabIndex = 10
        '
        'LNombre
        '
        Me.LNombre.AutoSize = True
        Me.LNombre.Location = New System.Drawing.Point(12, 104)
        Me.LNombre.Name = "LNombre"
        Me.LNombre.Size = New System.Drawing.Size(44, 13)
        Me.LNombre.TabIndex = 9
        Me.LNombre.Text = "Nombre"
        '
        'VendedorBox
        '
        Me.VendedorBox.Location = New System.Drawing.Point(94, 50)
        Me.VendedorBox.Name = "VendedorBox"
        Me.VendedorBox.Size = New System.Drawing.Size(100, 20)
        Me.VendedorBox.TabIndex = 8
        '
        'LVendedor
        '
        Me.LVendedor.AutoSize = True
        Me.LVendedor.Location = New System.Drawing.Point(12, 50)
        Me.LVendedor.Name = "LVendedor"
        Me.LVendedor.Size = New System.Drawing.Size(76, 13)
        Me.LVendedor.TabIndex = 7
        Me.LVendedor.Text = "Nro. Vendedor"
        '
        'LInfo
        '
        Me.LInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LInfo.Location = New System.Drawing.Point(11, 226)
        Me.LInfo.Name = "LInfo"
        Me.LInfo.Size = New System.Drawing.Size(339, 32)
        Me.LInfo.TabIndex = 15
        Me.LInfo.Text = "Atencion: La comisión de los empleados está limitada a un máximo del 80%."
        '
        'VendedorPhoto
        '
        Me.VendedorPhoto.Image = Global.Concesionaria.My.Resources.Resources._362107
        Me.VendedorPhoto.Location = New System.Drawing.Point(220, 12)
        Me.VendedorPhoto.Name = "VendedorPhoto"
        Me.VendedorPhoto.Size = New System.Drawing.Size(116, 74)
        Me.VendedorPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.VendedorPhoto.TabIndex = 14
        Me.VendedorPhoto.TabStop = False
        '
        'BLista
        '
        Me.BLista.Location = New System.Drawing.Point(14, 195)
        Me.BLista.Name = "BLista"
        Me.BLista.Size = New System.Drawing.Size(114, 23)
        Me.BLista.TabIndex = 16
        Me.BLista.Text = "Lista de vendedores"
        Me.BLista.UseVisualStyleBackColor = True
        '
        'NuevoVendedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.ClientSize = New System.Drawing.Size(362, 262)
        Me.Controls.Add(Me.BLista)
        Me.Controls.Add(Me.LInfo)
        Me.Controls.Add(Me.VendedorPhoto)
        Me.Controls.Add(Me.BAceptar)
        Me.Controls.Add(Me.LComision)
        Me.Controls.Add(Me.ComisionBox)
        Me.Controls.Add(Me.NombreBox)
        Me.Controls.Add(Me.LNombre)
        Me.Controls.Add(Me.VendedorBox)
        Me.Controls.Add(Me.LVendedor)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "NuevoVendedor"
        Me.Text = "Nuevo Vendedor"
        CType(Me.VendedorPhoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BAceptar As System.Windows.Forms.Button
    Friend WithEvents LComision As System.Windows.Forms.Label
    Friend WithEvents ComisionBox As System.Windows.Forms.TextBox
    Friend WithEvents NombreBox As System.Windows.Forms.TextBox
    Friend WithEvents LNombre As System.Windows.Forms.Label
    Friend WithEvents VendedorBox As System.Windows.Forms.TextBox
    Friend WithEvents LVendedor As System.Windows.Forms.Label
    Friend WithEvents VendedorPhoto As System.Windows.Forms.PictureBox
    Friend WithEvents LInfo As System.Windows.Forms.Label
    Friend WithEvents BLista As System.Windows.Forms.Button
End Class
