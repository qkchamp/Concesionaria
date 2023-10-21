Public Class Comisiones

    Private Sub NuevoVendedorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NuevoVendedorToolStripMenuItem.Click
        NuevoVendedor.Show()
    End Sub

    Private Sub NuevaFacturaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NuevaFacturaToolStripMenuItem.Click
        NuevaFactura.Show()
    End Sub

    Private Sub ComisionesPorVentaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComisionesPorVentaToolStripMenuItem.Click
        ComisionesVenta.Show()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()
    End Sub
End Class
