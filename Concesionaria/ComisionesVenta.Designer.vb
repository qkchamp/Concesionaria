<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ComisionesVenta
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ComisionesVenta))
        Me.DGV_Comisiones = New System.Windows.Forms.DataGridView()
        Me.LSinDatos = New System.Windows.Forms.Label()
        CType(Me.DGV_Comisiones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGV_Comisiones
        '
        Me.DGV_Comisiones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_Comisiones.Location = New System.Drawing.Point(22, 12)
        Me.DGV_Comisiones.Name = "DGV_Comisiones"
        Me.DGV_Comisiones.Size = New System.Drawing.Size(683, 296)
        Me.DGV_Comisiones.TabIndex = 0
        '
        'LSinDatos
        '
        Me.LSinDatos.AutoSize = True
        Me.LSinDatos.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.LSinDatos.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LSinDatos.ForeColor = System.Drawing.Color.Crimson
        Me.LSinDatos.Location = New System.Drawing.Point(156, 117)
        Me.LSinDatos.Name = "LSinDatos"
        Me.LSinDatos.Size = New System.Drawing.Size(386, 73)
        Me.LSinDatos.TabIndex = 1
        Me.LSinDatos.Text = "SIN DATOS"
        '
        'ComisionesVenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Cornsilk
        Me.ClientSize = New System.Drawing.Size(736, 320)
        Me.Controls.Add(Me.LSinDatos)
        Me.Controls.Add(Me.DGV_Comisiones)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "ComisionesVenta"
        Me.Text = "Comisiones Venta"
        CType(Me.DGV_Comisiones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DGV_Comisiones As System.Windows.Forms.DataGridView
    Friend WithEvents LSinDatos As System.Windows.Forms.Label
End Class
