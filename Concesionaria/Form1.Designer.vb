<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Comisiones
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Comisiones))
        Me.TareaStrip = New System.Windows.Forms.MenuStrip()
        Me.TareasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NuevoVendedorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NuevaFacturaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ComisionesPorVentaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TareaStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'TareaStrip
        '
        Me.TareaStrip.BackColor = System.Drawing.Color.DarkGoldenrod
        Me.TareaStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TareasToolStripMenuItem})
        Me.TareaStrip.Location = New System.Drawing.Point(0, 0)
        Me.TareaStrip.Name = "TareaStrip"
        Me.TareaStrip.Size = New System.Drawing.Size(482, 24)
        Me.TareaStrip.TabIndex = 0
        Me.TareaStrip.Text = "MenuStrip1"
        '
        'TareasToolStripMenuItem
        '
        Me.TareasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoVendedorToolStripMenuItem, Me.NuevaFacturaToolStripMenuItem, Me.ComisionesPorVentaToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.TareasToolStripMenuItem.Name = "TareasToolStripMenuItem"
        Me.TareasToolStripMenuItem.Size = New System.Drawing.Size(51, 20)
        Me.TareasToolStripMenuItem.Text = "Tareas"
        '
        'NuevoVendedorToolStripMenuItem
        '
        Me.NuevoVendedorToolStripMenuItem.Name = "NuevoVendedorToolStripMenuItem"
        Me.NuevoVendedorToolStripMenuItem.Size = New System.Drawing.Size(189, 22)
        Me.NuevoVendedorToolStripMenuItem.Text = "Nuevo vendedor"
        '
        'NuevaFacturaToolStripMenuItem
        '
        Me.NuevaFacturaToolStripMenuItem.Name = "NuevaFacturaToolStripMenuItem"
        Me.NuevaFacturaToolStripMenuItem.Size = New System.Drawing.Size(189, 22)
        Me.NuevaFacturaToolStripMenuItem.Text = "Nueva factura"
        '
        'ComisionesPorVentaToolStripMenuItem
        '
        Me.ComisionesPorVentaToolStripMenuItem.Name = "ComisionesPorVentaToolStripMenuItem"
        Me.ComisionesPorVentaToolStripMenuItem.Size = New System.Drawing.Size(189, 22)
        Me.ComisionesPorVentaToolStripMenuItem.Text = "Comisiones por venta"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(189, 22)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'Comisiones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SandyBrown
        Me.ClientSize = New System.Drawing.Size(482, 285)
        Me.Controls.Add(Me.TareaStrip)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.TareaStrip
        Me.MaximizeBox = False
        Me.Name = "Comisiones"
        Me.Text = "Comisiones vendedores"
        Me.TareaStrip.ResumeLayout(False)
        Me.TareaStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TareaStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents TareasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NuevoVendedorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NuevaFacturaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ComisionesPorVentaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
